using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.Rendering;

public static class RenderPipelineManager : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_s_CleanUpPipeline;

	private static readonly System.IntPtr NativeFieldInfoPtr_s_CurrentPipelineType;

	private static readonly System.IntPtr NativeFieldInfoPtr_s_CurrentPipelineAsset;

	private static readonly System.IntPtr NativeFieldInfoPtr_s_CurrentPipeline;

	private static readonly System.IntPtr NativeFieldInfoPtr_beginContextRendering;

	private static readonly System.IntPtr NativeFieldInfoPtr_endContextRendering;

	private static readonly System.IntPtr NativeFieldInfoPtr_beginCameraRendering;

	private static readonly System.IntPtr NativeFieldInfoPtr_endCameraRendering;

	private static readonly System.IntPtr NativeFieldInfoPtr_activeRenderPipelineTypeChanged;

	private static readonly System.IntPtr NativeFieldInfoPtr_activeRenderPipelineAssetChanged;

	private static readonly System.IntPtr NativeFieldInfoPtr_activeRenderPipelineCreated;

	private static readonly System.IntPtr NativeFieldInfoPtr_activeRenderPipelineDisposed;

	private static readonly System.IntPtr NativeFieldInfoPtr_beginFrameRendering;

	private static readonly System.IntPtr NativeFieldInfoPtr_endFrameRendering;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_currentPipeline_Public_Static_get_RenderPipeline_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_currentPipeline_Private_Static_set_Void_RenderPipeline_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_add_beginContextRendering_Public_Static_add_Void_Action_2_ScriptableRenderContext_List_1_Camera_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_remove_beginContextRendering_Public_Static_rem_Void_Action_2_ScriptableRenderContext_List_1_Camera_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_add_endContextRendering_Public_Static_add_Void_Action_2_ScriptableRenderContext_List_1_Camera_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_remove_endContextRendering_Public_Static_rem_Void_Action_2_ScriptableRenderContext_List_1_Camera_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_add_beginCameraRendering_Public_Static_add_Void_Action_2_ScriptableRenderContext_Camera_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_remove_beginCameraRendering_Public_Static_rem_Void_Action_2_ScriptableRenderContext_Camera_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_add_endCameraRendering_Public_Static_add_Void_Action_2_ScriptableRenderContext_Camera_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_remove_endCameraRendering_Public_Static_rem_Void_Action_2_ScriptableRenderContext_Camera_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_BeginContextRendering_Internal_Static_Void_ScriptableRenderContext_List_1_Camera_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_BeginCameraRendering_Internal_Static_Void_ScriptableRenderContext_Camera_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_EndContextRendering_Internal_Static_Void_ScriptableRenderContext_List_1_Camera_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_EndCameraRendering_Internal_Static_Void_ScriptableRenderContext_Camera_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnActiveRenderPipelineTypeChanged_Internal_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnActiveRenderPipelineAssetChanged_Internal_Static_Void_ScriptableObject_ScriptableObject_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_HandleRenderPipelineChange_Internal_Static_Void_RenderPipelineAsset_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RecreateCurrentPipeline_Internal_Static_Void_RenderPipelineAsset_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CleanupRenderPipeline_Internal_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetCurrentPipelineAssetType_Private_Static_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DoRenderLoop_Internal_Private_Static_Void_RenderPipelineAsset_IntPtr_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TryPrepareRenderPipeline_Internal_Static_Boolean_RenderPipelineAsset_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_isCurrentPipelineValid_Private_Static_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsPipelineRequireCreation_Private_Static_Boolean_0;

	public const string k_BuiltinPipelineName = "Built-in Pipeline";

	public unsafe static bool s_CleanUpPipeline
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_CleanUpPipeline, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_CleanUpPipeline, (void*)(&value));
		}
	}

	public unsafe static string s_CurrentPipelineType
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_CurrentPipelineType, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_CurrentPipelineType, (void*)IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe static RenderPipelineAsset s_CurrentPipelineAsset
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_CurrentPipelineAsset, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<RenderPipelineAsset>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_CurrentPipelineAsset, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static RenderPipeline s_CurrentPipeline
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_CurrentPipeline, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<RenderPipeline>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_CurrentPipeline, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Il2CppSystem.Action<ScriptableRenderContext, List<Camera>> beginContextRendering
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_beginContextRendering, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Action<ScriptableRenderContext, List<Camera>>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_beginContextRendering, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Il2CppSystem.Action<ScriptableRenderContext, List<Camera>> endContextRendering
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_endContextRendering, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Action<ScriptableRenderContext, List<Camera>>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_endContextRendering, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Il2CppSystem.Action<ScriptableRenderContext, Camera> beginCameraRendering
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_beginCameraRendering, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Action<ScriptableRenderContext, Camera>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_beginCameraRendering, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Il2CppSystem.Action<ScriptableRenderContext, Camera> endCameraRendering
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_endCameraRendering, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Action<ScriptableRenderContext, Camera>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_endCameraRendering, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Il2CppSystem.Action activeRenderPipelineTypeChanged
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_activeRenderPipelineTypeChanged, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Action>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_activeRenderPipelineTypeChanged, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Il2CppSystem.Action<RenderPipelineAsset, RenderPipelineAsset> activeRenderPipelineAssetChanged
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_activeRenderPipelineAssetChanged, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Action<RenderPipelineAsset, RenderPipelineAsset>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_activeRenderPipelineAssetChanged, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Il2CppSystem.Action activeRenderPipelineCreated
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_activeRenderPipelineCreated, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Action>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_activeRenderPipelineCreated, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Il2CppSystem.Action activeRenderPipelineDisposed
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_activeRenderPipelineDisposed, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Action>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_activeRenderPipelineDisposed, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Il2CppSystem.Action<ScriptableRenderContext, Il2CppReferenceArray<Camera>> beginFrameRendering
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_beginFrameRendering, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Action<ScriptableRenderContext, Il2CppReferenceArray<Camera>>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_beginFrameRendering, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Il2CppSystem.Action<ScriptableRenderContext, Il2CppReferenceArray<Camera>> endFrameRendering
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_endFrameRendering, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Action<ScriptableRenderContext, Il2CppReferenceArray<Camera>>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_endFrameRendering, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static RenderPipeline currentPipeline
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1238707, XrefRangeEnd = 1238711, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_currentPipeline_Public_Static_get_RenderPipeline_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<RenderPipeline>(intPtr2) : null;
		}
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1238725, RefRangeEnd = 1238726, XrefRangeStart = 1238711, XrefRangeEnd = 1238725, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_currentPipeline_Private_Static_set_Void_RenderPipeline_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe static bool isCurrentPipelineValid
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1239055, XrefRangeEnd = 1239062, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_isCurrentPipelineValid_Private_Static_get_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public static RenderPipelineAsset currentPipelineAsset => s_CurrentPipelineAsset;

	public static bool pipelineSwitchCompleted => (object)s_CurrentPipelineAsset == GraphicsSettings.currentRenderPipeline && !IsPipelineRequireCreation();

	static RenderPipelineManager()
	{
		Il2CppClassPointerStore<RenderPipelineManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Rendering", "RenderPipelineManager");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RenderPipelineManager>.NativeClassPtr);
		NativeFieldInfoPtr_s_CleanUpPipeline = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderPipelineManager>.NativeClassPtr, "s_CleanUpPipeline");
		NativeFieldInfoPtr_s_CurrentPipelineType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderPipelineManager>.NativeClassPtr, "s_CurrentPipelineType");
		NativeFieldInfoPtr_s_CurrentPipelineAsset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderPipelineManager>.NativeClassPtr, "s_CurrentPipelineAsset");
		NativeFieldInfoPtr_s_CurrentPipeline = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderPipelineManager>.NativeClassPtr, "s_CurrentPipeline");
		NativeFieldInfoPtr_beginContextRendering = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderPipelineManager>.NativeClassPtr, "beginContextRendering");
		NativeFieldInfoPtr_endContextRendering = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderPipelineManager>.NativeClassPtr, "endContextRendering");
		NativeFieldInfoPtr_beginCameraRendering = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderPipelineManager>.NativeClassPtr, "beginCameraRendering");
		NativeFieldInfoPtr_endCameraRendering = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderPipelineManager>.NativeClassPtr, "endCameraRendering");
		NativeFieldInfoPtr_activeRenderPipelineTypeChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderPipelineManager>.NativeClassPtr, "activeRenderPipelineTypeChanged");
		NativeFieldInfoPtr_activeRenderPipelineAssetChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderPipelineManager>.NativeClassPtr, "activeRenderPipelineAssetChanged");
		NativeFieldInfoPtr_activeRenderPipelineCreated = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderPipelineManager>.NativeClassPtr, "activeRenderPipelineCreated");
		NativeFieldInfoPtr_activeRenderPipelineDisposed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderPipelineManager>.NativeClassPtr, "activeRenderPipelineDisposed");
		NativeFieldInfoPtr_beginFrameRendering = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderPipelineManager>.NativeClassPtr, "beginFrameRendering");
		NativeFieldInfoPtr_endFrameRendering = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderPipelineManager>.NativeClassPtr, "endFrameRendering");
		NativeMethodInfoPtr_get_currentPipeline_Public_Static_get_RenderPipeline_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderPipelineManager>.NativeClassPtr, 100668604);
		NativeMethodInfoPtr_set_currentPipeline_Private_Static_set_Void_RenderPipeline_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderPipelineManager>.NativeClassPtr, 100668605);
		NativeMethodInfoPtr_add_beginContextRendering_Public_Static_add_Void_Action_2_ScriptableRenderContext_List_1_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderPipelineManager>.NativeClassPtr, 100668606);
		NativeMethodInfoPtr_remove_beginContextRendering_Public_Static_rem_Void_Action_2_ScriptableRenderContext_List_1_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderPipelineManager>.NativeClassPtr, 100668607);
		NativeMethodInfoPtr_add_endContextRendering_Public_Static_add_Void_Action_2_ScriptableRenderContext_List_1_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderPipelineManager>.NativeClassPtr, 100668608);
		NativeMethodInfoPtr_remove_endContextRendering_Public_Static_rem_Void_Action_2_ScriptableRenderContext_List_1_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderPipelineManager>.NativeClassPtr, 100668609);
		NativeMethodInfoPtr_add_beginCameraRendering_Public_Static_add_Void_Action_2_ScriptableRenderContext_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderPipelineManager>.NativeClassPtr, 100668610);
		NativeMethodInfoPtr_remove_beginCameraRendering_Public_Static_rem_Void_Action_2_ScriptableRenderContext_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderPipelineManager>.NativeClassPtr, 100668611);
		NativeMethodInfoPtr_add_endCameraRendering_Public_Static_add_Void_Action_2_ScriptableRenderContext_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderPipelineManager>.NativeClassPtr, 100668612);
		NativeMethodInfoPtr_remove_endCameraRendering_Public_Static_rem_Void_Action_2_ScriptableRenderContext_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderPipelineManager>.NativeClassPtr, 100668613);
		NativeMethodInfoPtr_BeginContextRendering_Internal_Static_Void_ScriptableRenderContext_List_1_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderPipelineManager>.NativeClassPtr, 100668614);
		NativeMethodInfoPtr_BeginCameraRendering_Internal_Static_Void_ScriptableRenderContext_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderPipelineManager>.NativeClassPtr, 100668615);
		NativeMethodInfoPtr_EndContextRendering_Internal_Static_Void_ScriptableRenderContext_List_1_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderPipelineManager>.NativeClassPtr, 100668616);
		NativeMethodInfoPtr_EndCameraRendering_Internal_Static_Void_ScriptableRenderContext_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderPipelineManager>.NativeClassPtr, 100668617);
		NativeMethodInfoPtr_OnActiveRenderPipelineTypeChanged_Internal_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderPipelineManager>.NativeClassPtr, 100668618);
		NativeMethodInfoPtr_OnActiveRenderPipelineAssetChanged_Internal_Static_Void_ScriptableObject_ScriptableObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderPipelineManager>.NativeClassPtr, 100668619);
		NativeMethodInfoPtr_HandleRenderPipelineChange_Internal_Static_Void_RenderPipelineAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderPipelineManager>.NativeClassPtr, 100668620);
		NativeMethodInfoPtr_RecreateCurrentPipeline_Internal_Static_Void_RenderPipelineAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderPipelineManager>.NativeClassPtr, 100668621);
		NativeMethodInfoPtr_CleanupRenderPipeline_Internal_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderPipelineManager>.NativeClassPtr, 100668622);
		NativeMethodInfoPtr_GetCurrentPipelineAssetType_Private_Static_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderPipelineManager>.NativeClassPtr, 100668623);
		NativeMethodInfoPtr_DoRenderLoop_Internal_Private_Static_Void_RenderPipelineAsset_IntPtr_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderPipelineManager>.NativeClassPtr, 100668624);
		NativeMethodInfoPtr_TryPrepareRenderPipeline_Internal_Static_Boolean_RenderPipelineAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderPipelineManager>.NativeClassPtr, 100668625);
		NativeMethodInfoPtr_get_isCurrentPipelineValid_Private_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderPipelineManager>.NativeClassPtr, 100668626);
		NativeMethodInfoPtr_IsPipelineRequireCreation_Private_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderPipelineManager>.NativeClassPtr, 100668627);
	}

	[SpecialName]
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1238739, RefRangeEnd = 1238740, XrefRangeStart = 1238726, XrefRangeEnd = 1238739, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void add_beginContextRendering(Il2CppSystem.Action<ScriptableRenderContext, List<Camera>> value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_add_beginContextRendering_Public_Static_add_Void_Action_2_ScriptableRenderContext_List_1_Camera_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[SpecialName]
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1238753, RefRangeEnd = 1238754, XrefRangeStart = 1238740, XrefRangeEnd = 1238753, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void remove_beginContextRendering(Il2CppSystem.Action<ScriptableRenderContext, List<Camera>> value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_remove_beginContextRendering_Public_Static_rem_Void_Action_2_ScriptableRenderContext_List_1_Camera_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[SpecialName]
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1238767, RefRangeEnd = 1238768, XrefRangeStart = 1238754, XrefRangeEnd = 1238767, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void add_endContextRendering(Il2CppSystem.Action<ScriptableRenderContext, List<Camera>> value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_add_endContextRendering_Public_Static_add_Void_Action_2_ScriptableRenderContext_List_1_Camera_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[SpecialName]
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1238781, RefRangeEnd = 1238782, XrefRangeStart = 1238768, XrefRangeEnd = 1238781, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void remove_endContextRendering(Il2CppSystem.Action<ScriptableRenderContext, List<Camera>> value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_remove_endContextRendering_Public_Static_rem_Void_Action_2_ScriptableRenderContext_List_1_Camera_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[SpecialName]
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1238795, RefRangeEnd = 1238797, XrefRangeStart = 1238782, XrefRangeEnd = 1238795, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void add_beginCameraRendering(Il2CppSystem.Action<ScriptableRenderContext, Camera> value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_add_beginCameraRendering_Public_Static_add_Void_Action_2_ScriptableRenderContext_Camera_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[SpecialName]
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1238810, RefRangeEnd = 1238812, XrefRangeStart = 1238797, XrefRangeEnd = 1238810, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void remove_beginCameraRendering(Il2CppSystem.Action<ScriptableRenderContext, Camera> value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_remove_beginCameraRendering_Public_Static_rem_Void_Action_2_ScriptableRenderContext_Camera_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[SpecialName]
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1238825, RefRangeEnd = 1238826, XrefRangeStart = 1238812, XrefRangeEnd = 1238825, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void add_endCameraRendering(Il2CppSystem.Action<ScriptableRenderContext, Camera> value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_add_endCameraRendering_Public_Static_add_Void_Action_2_ScriptableRenderContext_Camera_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[SpecialName]
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1238839, RefRangeEnd = 1238840, XrefRangeStart = 1238826, XrefRangeEnd = 1238839, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void remove_endCameraRendering(Il2CppSystem.Action<ScriptableRenderContext, Camera> value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_remove_endCameraRendering_Public_Static_rem_Void_Action_2_ScriptableRenderContext_Camera_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1238840, XrefRangeEnd = 1238850, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void BeginContextRendering(ScriptableRenderContext context, List<Camera> cameras)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&context);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cameras);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_BeginContextRendering_Internal_Static_Void_ScriptableRenderContext_List_1_Camera_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1238850, XrefRangeEnd = 1238854, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void BeginCameraRendering(ScriptableRenderContext context, Camera camera)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&context);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)camera);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_BeginCameraRendering_Internal_Static_Void_ScriptableRenderContext_Camera_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1238854, XrefRangeEnd = 1238864, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void EndContextRendering(ScriptableRenderContext context, List<Camera> cameras)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&context);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cameras);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_EndContextRendering_Internal_Static_Void_ScriptableRenderContext_List_1_Camera_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1238864, XrefRangeEnd = 1238868, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void EndCameraRendering(ScriptableRenderContext context, Camera camera)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&context);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)camera);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_EndCameraRendering_Internal_Static_Void_ScriptableRenderContext_Camera_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1238868, XrefRangeEnd = 1238872, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void OnActiveRenderPipelineTypeChanged()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnActiveRenderPipelineTypeChanged_Internal_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1238872, XrefRangeEnd = 1238879, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void OnActiveRenderPipelineAssetChanged(ScriptableObject from, ScriptableObject to)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)from);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)to);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnActiveRenderPipelineAssetChanged_Internal_Static_Void_ScriptableObject_ScriptableObject_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1238879, XrefRangeEnd = 1238888, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void HandleRenderPipelineChange(RenderPipelineAsset pipelineAsset)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)pipelineAsset);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_HandleRenderPipelineChange_Internal_Static_Void_RenderPipelineAsset_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1238888, XrefRangeEnd = 1238899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void RecreateCurrentPipeline(RenderPipelineAsset pipelineAsset)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)pipelineAsset);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RecreateCurrentPipeline_Internal_Static_Void_RenderPipelineAsset_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1238956, RefRangeEnd = 1238959, XrefRangeStart = 1238899, XrefRangeEnd = 1238956, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void CleanupRenderPipeline()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CleanupRenderPipeline_Internal_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1238959, XrefRangeEnd = 1238963, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string GetCurrentPipelineAssetType()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetCurrentPipelineAssetType_Private_Static_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1238963, XrefRangeEnd = 1239007, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void DoRenderLoop_Internal(RenderPipelineAsset pipelineAsset, System.IntPtr loopPtr, Object renderRequest)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)pipelineAsset);
		*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &loopPtr;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)renderRequest);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DoRenderLoop_Internal_Private_Static_Void_RenderPipelineAsset_IntPtr_Object_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1239054, RefRangeEnd = 1239055, XrefRangeStart = 1239007, XrefRangeEnd = 1239054, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool TryPrepareRenderPipeline(RenderPipelineAsset pipelineAsset)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)pipelineAsset);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TryPrepareRenderPipeline_Internal_Static_Boolean_RenderPipelineAsset_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1239062, XrefRangeEnd = 1239070, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool IsPipelineRequireCreation()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsPipelineRequireCreation_Private_Static_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	public RenderPipelineManager(System.IntPtr pointer)
		: base(pointer)
	{
	}

	[SpecialName]
	public static void add_activeRenderPipelineTypeChanged(Il2CppSystem.Action value)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	[SpecialName]
	public static void remove_activeRenderPipelineTypeChanged(Il2CppSystem.Action value)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	[SpecialName]
	public static void add_activeRenderPipelineAssetChanged(Il2CppSystem.Action<RenderPipelineAsset, RenderPipelineAsset> value)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	[SpecialName]
	public static void remove_activeRenderPipelineAssetChanged(Il2CppSystem.Action<RenderPipelineAsset, RenderPipelineAsset> value)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	[SpecialName]
	public static void add_activeRenderPipelineCreated(Il2CppSystem.Action value)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	[SpecialName]
	public static void remove_activeRenderPipelineCreated(Il2CppSystem.Action value)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	[SpecialName]
	public static void add_activeRenderPipelineDisposed(Il2CppSystem.Action value)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	[SpecialName]
	public static void remove_activeRenderPipelineDisposed(Il2CppSystem.Action value)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	[SpecialName]
	public static void add_beginFrameRendering(Il2CppSystem.Action<ScriptableRenderContext, Il2CppReferenceArray<Camera>> value)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	[SpecialName]
	public static void remove_beginFrameRendering(Il2CppSystem.Action<ScriptableRenderContext, Il2CppReferenceArray<Camera>> value)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	[SpecialName]
	public static void add_endFrameRendering(Il2CppSystem.Action<ScriptableRenderContext, Il2CppReferenceArray<Camera>> value)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	[SpecialName]
	public static void remove_endFrameRendering(Il2CppSystem.Action<ScriptableRenderContext, Il2CppReferenceArray<Camera>> value)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}
}
