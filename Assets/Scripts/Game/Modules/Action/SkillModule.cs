using System;
using Unity.Collections;
using Unity.Entities;
using Unity.Mathematics;
using Unity.Transforms;
using UnityEngine;
using UnityMMO;

public class SkillManager
{
    static SkillManager instance;
    int curComboIndex;
    int career;
    int[] skillIDs = new int[4];//主界面里的四个技能id，因为人物有多于4技能可以选择，所以需要后端记录下来哪四个常用的放在主界面
    public static SkillManager GetInstance()
    {
        if (instance != null)
            return instance;
        instance = new SkillManager();
        return instance;
    }

    public void Init(int career)
    {
        this.career = career;
        this.curComboIndex = 0;
        //just for test
        for (int i = 0; i < 4; i++)
        {
            skillIDs[i] = 100000+career*10000+10+i;
        }
    }

    public int GetCurAttackID()
    {
        return GetAttackID(career, curComboIndex);
    }

    public void ResetCombo()
    {
        curComboIndex = 0;
    }

    public void IncreaseCombo()
    {
        //普攻有四个
        curComboIndex++;
        if (curComboIndex>=4)
            curComboIndex = 0;
    }

    public int GetSkillIDByIndex(int skillIndex)
    {
        if (skillIndex == -1)
            return GetCurAttackID();
        else
            return skillIDs[skillIndex];
    }

    public string GetSkillResPath(int skillID)
    {
        string assetPath;
        int scene_obj_type = GetSceneObjTypeBySkillID(skillID);
        if (scene_obj_type == (int)SceneObjectType.Role)
            assetPath = ResPath.GetRoleSkillResPath(skillID);
        else if(scene_obj_type == (int)SceneObjectType.Monster)
            assetPath = ResPath.GetMonsterSkillResPath(skillID);
        else
            assetPath = "";
        return assetPath;
    }

    public int GetCareerBySkillID(int skillID)
    {
        int scene_obj_type = GetSceneObjTypeBySkillID(skillID);
        if (scene_obj_type == (int)SceneObjectType.Role)
            return (int)math.floor((skillID%100000)/10000);
        return 1;
    }

    public int GetSceneObjTypeBySkillID(int skillID)
    {
        return (int)math.floor((skillID/100000));
    }

    private static int GetAttackID(int career, int comboIndex)
    {
        //技能id：十万位是类型1角色，2怪物，3NPC，万位为职业，个十百位随便用
        return 100000+career*10000+comboIndex;
    }

    public void CastSkill(int skillIndex=-1)
    {
        var roleGameOE = RoleMgr.GetInstance().GetMainRole();
        var roleInfo = roleGameOE.GetComponent<RoleInfo>();
        var skillID = SkillManager.GetInstance().GetSkillIDByIndex(skillIndex);
        
        string assetPath = ResPath.GetRoleSkillResPath(skillID);
        bool isNormalAttack = skillIndex == -1;//普通攻击
        if (!isNormalAttack)
            SkillManager.GetInstance().ResetCombo();//使用非普攻技能时就重置连击索引
        var uid = SceneMgr.Instance.EntityManager.GetComponentData<UID>(roleGameOE.Entity);
        Action<TimelineInfo.Event> afterAdd = null;
        if (isNormalAttack)
        {
            //普攻的话增加连击索引
            afterAdd = (TimelineInfo.Event e)=>
            {
                if (e == TimelineInfo.Event.AfterAdd)
                    SkillManager.GetInstance().IncreaseCombo();
            };
        }
        var timelineInfo = new TimelineInfo{ResPath=assetPath, Owner=roleGameOE.Entity,  StateChange=afterAdd};
        TimelineManager.GetInstance().AddTimeline(uid.Value, timelineInfo, SceneMgr.Instance.EntityManager);
    }

    private SkillManager()
    {
    }
}

public struct SkillSpawnRequest : IComponentData
{
    public long UID;
    public int SkillID;
    private SkillSpawnRequest(long UID, int SkillID)
    {
        this.UID = UID;
        this.SkillID = SkillID;
    }

    public static void Create(EntityCommandBuffer commandBuffer, long UID, int SkillID)
    {
        var data = new SkillSpawnRequest(UID, SkillID);
        commandBuffer.CreateEntity();
        commandBuffer.AddComponent(data);
    }
}


[DisableAutoCreation]
public class SkillSpawnSystem : BaseComponentSystem
{
    public SkillSpawnSystem(GameWorld world) : base(world) {}

    EntityQuery RequestGroup;

    protected override void OnCreateManager()
    {
        base.OnCreateManager();
        RequestGroup = GetEntityQuery(typeof(SkillSpawnRequest));
    }

    protected override void OnUpdate()
    {
        float dt = Time.deltaTime;
        var requestArray = RequestGroup.ToComponentDataArray<SkillSpawnRequest>(Allocator.TempJob);
        if (requestArray.Length == 0)
        {
            requestArray.Dispose();
            return;
        }

        var requestEntityArray = RequestGroup.ToEntityArray(Allocator.TempJob);
        
        // Copy requests as spawning will invalidate Group
        var requests = new SkillSpawnRequest[requestArray.Length];
        for (var i = 0; i < requestArray.Length; i++)
        {
            requests[i] = requestArray[i];
            PostUpdateCommands.DestroyEntity(requestEntityArray[i]);
        }

        for(var i = 0; i < requests.Length; i++)
        {
        }
        requestEntityArray.Dispose();
        requestArray.Dispose();
    }
}