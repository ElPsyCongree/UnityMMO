﻿#if USE_UNI_LUA
using LuaAPI = UniLua.Lua;
using RealStatePtr = UniLua.ILuaState;
using LuaCSFunction = UniLua.CSharpFunctionDelegate;
#else
using LuaAPI = XLua.LuaDLL.Lua;
using RealStatePtr = System.IntPtr;
using LuaCSFunction = XLua.LuaDLL.lua_CSFunction;
#endif

using System;
using System.Collections.Generic;
using System.Reflection;


namespace XLua.CSObjectWrap
{
    public class XLua_Gen_Initer_Register__
	{
        
        
        static void wrapInit0(LuaEnv luaenv, ObjectTranslator translator)
        {
        
            translator.DelayWrapLoader(typeof(XLuaManager), XLuaManagerWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(XLuaFramework.AppConfig), XLuaFrameworkAppConfigWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(XLuaFramework.CookiesManager), XLuaFrameworkCookiesManagerWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(XLuaFramework.NetPackageType), XLuaFrameworkNetPackageTypeWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(XLuaFramework.NetworkManager), XLuaFrameworkNetworkManagerWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(XLuaFramework.ResourceManager), XLuaFrameworkResourceManagerWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(XLuaFramework.UIHelper), XLuaFrameworkUIHelperWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(XLuaFramework.Util), XLuaFrameworkUtilWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityMMO.GameVariable), UnityMMOGameVariableWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(object), SystemObjectWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.Object), UnityEngineObjectWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.Vector2), UnityEngineVector2Wrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.Vector3), UnityEngineVector3Wrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.Vector4), UnityEngineVector4Wrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.Quaternion), UnityEngineQuaternionWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.Color), UnityEngineColorWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.Ray), UnityEngineRayWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.Bounds), UnityEngineBoundsWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.Ray2D), UnityEngineRay2DWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.Time), UnityEngineTimeWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.GameObject), UnityEngineGameObjectWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.Component), UnityEngineComponentWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.Behaviour), UnityEngineBehaviourWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.Transform), UnityEngineTransformWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.Resources), UnityEngineResourcesWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.TextAsset), UnityEngineTextAssetWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.Keyframe), UnityEngineKeyframeWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.AnimationCurve), UnityEngineAnimationCurveWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.AnimationClip), UnityEngineAnimationClipWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.MonoBehaviour), UnityEngineMonoBehaviourWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.ParticleSystem), UnityEngineParticleSystemWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.SkinnedMeshRenderer), UnityEngineSkinnedMeshRendererWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.Renderer), UnityEngineRendererWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.Light), UnityEngineLightWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.Mathf), UnityEngineMathfWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(System.Collections.Generic.List<int>), SystemCollectionsGenericList_1_SystemInt32_Wrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.UI.InputField), UnityEngineUIInputFieldWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.TextAnchor), UnityEngineTextAnchorWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.RaycastHit), UnityEngineRaycastHitWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.Touch), UnityEngineTouchWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.TouchPhase), UnityEngineTouchPhaseWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.LayerMask), UnityEngineLayerMaskWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.Plane), UnityEnginePlaneWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.RectTransform), UnityEngineRectTransformWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.TextMesh), UnityEngineTextMeshWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.UI.MaskableGraphic), UnityEngineUIMaskableGraphicWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.UI.ScrollRect), UnityEngineUIScrollRectWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.UI.Image), UnityEngineUIImageWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.Animator), UnityEngineAnimatorWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(CircleRawImage), CircleRawImageWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.Camera), UnityEngineCameraWrap.__Register);
        
        }
        
        static void wrapInit1(LuaEnv luaenv, ObjectTranslator translator)
        {
        
            translator.DelayWrapLoader(typeof(UnityEngine.Physics), UnityEnginePhysicsWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.Input), UnityEngineInputWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.KeyCode), UnityEngineKeyCodeWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.RenderTexture), UnityEngineRenderTextureWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.Debug), UnityEngineDebugWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(Unity.Entities.World), UnityEntitiesWorldWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(Unity.Entities.Entity), UnityEntitiesEntityWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(Unity.Entities.GameObjectEntity), UnityEntitiesGameObjectEntityWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(Unity.Entities.EntityManagerExtensions), UnityEntitiesEntityManagerExtensionsWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(Unity.Entities.EntityManager), UnityEntitiesEntityManagerWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(TMPro.TextMeshProUGUI), TMProTextMeshProUGUIWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(TMPro.TMP_Text), TMProTMP_TextWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityMMO.UID), UnityMMOUIDWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityMMO.UIDProxy), UnityMMOUIDProxyWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityMMO.GameConst), UnityMMOGameConstWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityMMO.ResPath), UnityMMOResPathWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityMMO.ECSHelper), UnityMMOECSHelperWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityMMO.GameInput), UnityMMOGameInputWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityMMO.MainWorld), UnityMMOMainWorldWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityMMO.AutoFight), UnityMMOAutoFightWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityMMO.MonsterMgr), UnityMMOMonsterMgrWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityMMO.NPCMgr), UnityMMONPCMgrWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityMMO.RoleInfo), UnityMMORoleInfoWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityMMO.RoleMgr), UnityMMORoleMgrWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityMMO.ResMgr), UnityMMOResMgrWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityMMO.BornInfo), UnityMMOBornInfoWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityMMO.BornInfoData), UnityMMOBornInfoDataWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityMMO.RaycastSceneObjHit), UnityMMORaycastSceneObjHitWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityMMO.SceneHelper), UnityMMOSceneHelperWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityMMO.SceneInfo), UnityMMOSceneInfoWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityMMO.BaseSceneInfoData), UnityMMOBaseSceneInfoDataWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityMMO.SceneInfoKey), UnityMMOSceneInfoKeyWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityMMO.SceneObjectType), UnityMMOSceneObjectTypeWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityMMO.SceneMgr), UnityMMOSceneMgrWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityMMO.FindWayInfo), UnityMMOFindWayInfoWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityMMO.MoveQuery), UnityMMOMoveQueryWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityMMO.PlayerInputSystem), UnityMMOPlayerInputSystemWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityMMO.TestManager), UnityMMOTestManagerWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityMMO.TimeEx), UnityMMOTimeExWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityMMO.TimelineInfo), UnityMMOTimelineInfoWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityMMO.TimelineManager), UnityMMOTimelineManagerWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityMMO.NetMsgDispatcher), UnityMMONetMsgDispatcherWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityMMO.SynchFromNet), UnityMMOSynchFromNetWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityMMO.FightFlyWord), UnityMMOFightFlyWordWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityMMO.Nameboard), UnityMMONameboardWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityMMO.Timer), UnityMMOTimerWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityMMO.TimerExtensions), UnityMMOTimerExtensionsWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityMMO.TimelineInfo.Event), UnityMMOTimelineInfoEventWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityMMO.Nameboard.ColorStyle), UnityMMONameboardColorStyleWrap.__Register);
        
        
        
        }
        
        static void Init(LuaEnv luaenv, ObjectTranslator translator)
        {
            
            wrapInit0(luaenv, translator);
            
            wrapInit1(luaenv, translator);
            
            
            translator.AddInterfaceBridgeCreator(typeof(System.Collections.IEnumerator), SystemCollectionsIEnumeratorBridge.__Create);
            
        }
        
	    static XLua_Gen_Initer_Register__()
        {
		    XLua.LuaEnv.AddIniter(Init);
		}
		
		
	}
	
}
namespace XLua
{
	public partial class ObjectTranslator
	{
		static XLua.CSObjectWrap.XLua_Gen_Initer_Register__ s_gen_reg_dumb_obj = new XLua.CSObjectWrap.XLua_Gen_Initer_Register__();
		static XLua.CSObjectWrap.XLua_Gen_Initer_Register__ gen_reg_dumb_obj {get{return s_gen_reg_dumb_obj;}}
	}
	
	internal partial class InternalGlobals
    {
	    
	    static InternalGlobals()
		{
		    extensionMethodMap = new Dictionary<Type, IEnumerable<MethodInfo>>()
			{
			    
			};
			
			genTryArrayGetPtr = StaticLuaCallbacks.__tryArrayGet;
            genTryArraySetPtr = StaticLuaCallbacks.__tryArraySet;
		}
	}
}
