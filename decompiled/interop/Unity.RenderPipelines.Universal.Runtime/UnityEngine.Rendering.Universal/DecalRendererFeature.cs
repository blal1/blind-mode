using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine.Rendering.Universal.Internal;

namespace UnityEngine.Rendering.Universal;

public class DecalRendererFeature : ScriptableRendererFeature
{
	private static readonly IntPtr NativeFieldInfoPtr__sharedDecalEntityManager_k__BackingField;

	private static readonly IntPtr NativeFieldInfoPtr_m_Settings;

	private static readonly IntPtr NativeFieldInfoPtr_m_Technique;

	private static readonly IntPtr NativeFieldInfoPtr_m_DBufferSettings;

	private static readonly IntPtr NativeFieldInfoPtr_m_ScreenSpaceSettings;

	private static readonly IntPtr NativeFieldInfoPtr_m_RecreateSystems;

	private static readonly IntPtr NativeFieldInfoPtr_m_DecalPreviewPass;

	private static readonly IntPtr NativeFieldInfoPtr_m_DecalEntityManager;

	private static readonly IntPtr NativeFieldInfoPtr_m_DecalUpdateCachedSystem;

	private static readonly IntPtr NativeFieldInfoPtr_m_DecalUpdateCullingGroupSystem;

	private static readonly IntPtr NativeFieldInfoPtr_m_DecalUpdateCulledSystem;

	private static readonly IntPtr NativeFieldInfoPtr_m_DecalCreateDrawCallSystem;

	private static readonly IntPtr NativeFieldInfoPtr_m_DrawErrorSystem;

	private static readonly IntPtr NativeFieldInfoPtr_m_CopyDepthPass;

	private static readonly IntPtr NativeFieldInfoPtr_m_DBufferRenderPass;

	private static readonly IntPtr NativeFieldInfoPtr_m_ForwardEmissivePass;

	private static readonly IntPtr NativeFieldInfoPtr_m_DecalDrawDBufferSystem;

	private static readonly IntPtr NativeFieldInfoPtr_m_DecalDrawForwardEmissiveSystem;

	private static readonly IntPtr NativeFieldInfoPtr_m_DBufferClearMaterial;

	private static readonly IntPtr NativeFieldInfoPtr_m_ScreenSpaceDecalRenderPass;

	private static readonly IntPtr NativeFieldInfoPtr_m_DecalDrawScreenSpaceSystem;

	private static readonly IntPtr NativeFieldInfoPtr_m_DecalSkipCulledSystem;

	private static readonly IntPtr NativeFieldInfoPtr_m_GBufferRenderPass;

	private static readonly IntPtr NativeFieldInfoPtr_m_DrawGBufferSystem;

	private static readonly IntPtr NativeFieldInfoPtr_m_DeferredLights;

	private static readonly IntPtr NativeMethodInfoPtr_get_sharedDecalEntityManager_Private_Static_get_SharedDecalEntityManager_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_settings_Internal_get_byref_DecalSettings_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_intermediateRendering_Internal_get_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_requiresDecalLayers_Internal_get_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_isGLDevice_Internal_Static_get_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_Create_Public_Virtual_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_RequireRenderingLayers_Internal_Virtual_Boolean_Boolean_Boolean_byref_Event_byref_MaskSize_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetDBufferSettings_Internal_DBufferSettings_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetScreenSpaceSettings_Internal_DecalScreenSpaceSettings_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetTechnique_Internal_DecalTechnique_ScriptableRendererData_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetTechnique_Internal_DecalTechnique_ScriptableRenderer_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetTechnique_Internal_DecalTechnique_Boolean_Boolean_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_IsAutomaticDBuffer_Private_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_RecreateSystemsIfNeeded_Private_Boolean_ScriptableRenderer_byref_CameraData_0;

	private static readonly IntPtr NativeMethodInfoPtr_OnCameraPreCull_Public_Virtual_Void_ScriptableRenderer_byref_CameraData_0;

	private static readonly IntPtr NativeMethodInfoPtr_AddRenderPasses_Public_Virtual_Void_ScriptableRenderer_byref_RenderingData_0;

	private static readonly IntPtr NativeMethodInfoPtr_SupportsNativeRenderPass_Internal_Virtual_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_SetupRenderPasses_Public_Virtual_Void_ScriptableRenderer_byref_RenderingData_0;

	private static readonly IntPtr NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_ChangeAdaptivePerformanceDrawDistances_Private_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe static SharedDecalEntityManager _sharedDecalEntityManager_k__BackingField
	{
		get
		{
			Unsafe.SkipInit(out IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__sharedDecalEntityManager_k__BackingField, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != (IntPtr)0) ? Il2CppObjectPool.Get<SharedDecalEntityManager>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__sharedDecalEntityManager_k__BackingField, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe DecalSettings m_Settings
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Settings);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<DecalSettings>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Settings)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe DecalTechnique m_Technique
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Technique);
			return *(DecalTechnique*)num;
		}
		set
		{
			*(DecalTechnique*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Technique)) = value;
		}
	}

	public unsafe DBufferSettings m_DBufferSettings
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_DBufferSettings);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<DBufferSettings>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_DBufferSettings)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe DecalScreenSpaceSettings m_ScreenSpaceSettings
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ScreenSpaceSettings);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<DecalScreenSpaceSettings>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ScreenSpaceSettings)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe bool m_RecreateSystems
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_RecreateSystems);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_RecreateSystems)) = value;
		}
	}

	public unsafe DecalPreviewPass m_DecalPreviewPass
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_DecalPreviewPass);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<DecalPreviewPass>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_DecalPreviewPass)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe DecalEntityManager m_DecalEntityManager
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_DecalEntityManager);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<DecalEntityManager>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_DecalEntityManager)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe DecalUpdateCachedSystem m_DecalUpdateCachedSystem
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_DecalUpdateCachedSystem);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<DecalUpdateCachedSystem>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_DecalUpdateCachedSystem)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe DecalUpdateCullingGroupSystem m_DecalUpdateCullingGroupSystem
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_DecalUpdateCullingGroupSystem);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<DecalUpdateCullingGroupSystem>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_DecalUpdateCullingGroupSystem)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe DecalUpdateCulledSystem m_DecalUpdateCulledSystem
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_DecalUpdateCulledSystem);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<DecalUpdateCulledSystem>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_DecalUpdateCulledSystem)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe DecalCreateDrawCallSystem m_DecalCreateDrawCallSystem
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_DecalCreateDrawCallSystem);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<DecalCreateDrawCallSystem>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_DecalCreateDrawCallSystem)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe DecalDrawErrorSystem m_DrawErrorSystem
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_DrawErrorSystem);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<DecalDrawErrorSystem>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_DrawErrorSystem)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe DBufferCopyDepthPass m_CopyDepthPass
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_CopyDepthPass);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<DBufferCopyDepthPass>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_CopyDepthPass)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe DBufferRenderPass m_DBufferRenderPass
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_DBufferRenderPass);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<DBufferRenderPass>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_DBufferRenderPass)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe DecalForwardEmissivePass m_ForwardEmissivePass
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ForwardEmissivePass);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<DecalForwardEmissivePass>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ForwardEmissivePass)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe DecalDrawDBufferSystem m_DecalDrawDBufferSystem
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_DecalDrawDBufferSystem);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<DecalDrawDBufferSystem>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_DecalDrawDBufferSystem)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe DecalDrawFowardEmissiveSystem m_DecalDrawForwardEmissiveSystem
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_DecalDrawForwardEmissiveSystem);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<DecalDrawFowardEmissiveSystem>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_DecalDrawForwardEmissiveSystem)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe Material m_DBufferClearMaterial
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_DBufferClearMaterial);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Material>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_DBufferClearMaterial)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe DecalScreenSpaceRenderPass m_ScreenSpaceDecalRenderPass
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ScreenSpaceDecalRenderPass);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<DecalScreenSpaceRenderPass>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ScreenSpaceDecalRenderPass)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe DecalDrawScreenSpaceSystem m_DecalDrawScreenSpaceSystem
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_DecalDrawScreenSpaceSystem);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<DecalDrawScreenSpaceSystem>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_DecalDrawScreenSpaceSystem)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe DecalSkipCulledSystem m_DecalSkipCulledSystem
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_DecalSkipCulledSystem);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<DecalSkipCulledSystem>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_DecalSkipCulledSystem)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe DecalGBufferRenderPass m_GBufferRenderPass
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_GBufferRenderPass);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<DecalGBufferRenderPass>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_GBufferRenderPass)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe DecalDrawGBufferSystem m_DrawGBufferSystem
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_DrawGBufferSystem);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<DecalDrawGBufferSystem>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_DrawGBufferSystem)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe DeferredLights m_DeferredLights
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_DeferredLights);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<DeferredLights>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_DeferredLights)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static SharedDecalEntityManager sharedDecalEntityManager
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1096606, XrefRangeEnd = 1096610, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_sharedDecalEntityManager_Private_Static_get_SharedDecalEntityManager_0, (IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (IntPtr)0) ? Il2CppObjectPool.Get<SharedDecalEntityManager>(intPtr2) : null;
		}
	}

	public unsafe ref DecalSettings settings
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_settings_Internal_get_byref_DecalSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return ref *(DecalSettings*)intPtr2;
		}
	}

	public unsafe bool intermediateRendering
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_intermediateRendering_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe bool requiresDecalLayers
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_requiresDecalLayers_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe static bool isGLDevice
	{
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1096611, RefRangeEnd = 1096613, XrefRangeStart = 1096610, XrefRangeEnd = 1096611, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_isGLDevice_Internal_Static_get_Boolean_0, (IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	static DecalRendererFeature()
	{
		Il2CppClassPointerStore<DecalRendererFeature>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Universal.Runtime.dll", "UnityEngine.Rendering.Universal", "DecalRendererFeature");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DecalRendererFeature>.NativeClassPtr);
		NativeFieldInfoPtr__sharedDecalEntityManager_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalRendererFeature>.NativeClassPtr, "<sharedDecalEntityManager>k__BackingField");
		NativeFieldInfoPtr_m_Settings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalRendererFeature>.NativeClassPtr, "m_Settings");
		NativeFieldInfoPtr_m_Technique = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalRendererFeature>.NativeClassPtr, "m_Technique");
		NativeFieldInfoPtr_m_DBufferSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalRendererFeature>.NativeClassPtr, "m_DBufferSettings");
		NativeFieldInfoPtr_m_ScreenSpaceSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalRendererFeature>.NativeClassPtr, "m_ScreenSpaceSettings");
		NativeFieldInfoPtr_m_RecreateSystems = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalRendererFeature>.NativeClassPtr, "m_RecreateSystems");
		NativeFieldInfoPtr_m_DecalPreviewPass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalRendererFeature>.NativeClassPtr, "m_DecalPreviewPass");
		NativeFieldInfoPtr_m_DecalEntityManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalRendererFeature>.NativeClassPtr, "m_DecalEntityManager");
		NativeFieldInfoPtr_m_DecalUpdateCachedSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalRendererFeature>.NativeClassPtr, "m_DecalUpdateCachedSystem");
		NativeFieldInfoPtr_m_DecalUpdateCullingGroupSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalRendererFeature>.NativeClassPtr, "m_DecalUpdateCullingGroupSystem");
		NativeFieldInfoPtr_m_DecalUpdateCulledSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalRendererFeature>.NativeClassPtr, "m_DecalUpdateCulledSystem");
		NativeFieldInfoPtr_m_DecalCreateDrawCallSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalRendererFeature>.NativeClassPtr, "m_DecalCreateDrawCallSystem");
		NativeFieldInfoPtr_m_DrawErrorSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalRendererFeature>.NativeClassPtr, "m_DrawErrorSystem");
		NativeFieldInfoPtr_m_CopyDepthPass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalRendererFeature>.NativeClassPtr, "m_CopyDepthPass");
		NativeFieldInfoPtr_m_DBufferRenderPass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalRendererFeature>.NativeClassPtr, "m_DBufferRenderPass");
		NativeFieldInfoPtr_m_ForwardEmissivePass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalRendererFeature>.NativeClassPtr, "m_ForwardEmissivePass");
		NativeFieldInfoPtr_m_DecalDrawDBufferSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalRendererFeature>.NativeClassPtr, "m_DecalDrawDBufferSystem");
		NativeFieldInfoPtr_m_DecalDrawForwardEmissiveSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalRendererFeature>.NativeClassPtr, "m_DecalDrawForwardEmissiveSystem");
		NativeFieldInfoPtr_m_DBufferClearMaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalRendererFeature>.NativeClassPtr, "m_DBufferClearMaterial");
		NativeFieldInfoPtr_m_ScreenSpaceDecalRenderPass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalRendererFeature>.NativeClassPtr, "m_ScreenSpaceDecalRenderPass");
		NativeFieldInfoPtr_m_DecalDrawScreenSpaceSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalRendererFeature>.NativeClassPtr, "m_DecalDrawScreenSpaceSystem");
		NativeFieldInfoPtr_m_DecalSkipCulledSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalRendererFeature>.NativeClassPtr, "m_DecalSkipCulledSystem");
		NativeFieldInfoPtr_m_GBufferRenderPass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalRendererFeature>.NativeClassPtr, "m_GBufferRenderPass");
		NativeFieldInfoPtr_m_DrawGBufferSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalRendererFeature>.NativeClassPtr, "m_DrawGBufferSystem");
		NativeFieldInfoPtr_m_DeferredLights = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalRendererFeature>.NativeClassPtr, "m_DeferredLights");
		NativeMethodInfoPtr_get_sharedDecalEntityManager_Private_Static_get_SharedDecalEntityManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecalRendererFeature>.NativeClassPtr, 100665194);
		NativeMethodInfoPtr_get_settings_Internal_get_byref_DecalSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecalRendererFeature>.NativeClassPtr, 100665195);
		NativeMethodInfoPtr_get_intermediateRendering_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecalRendererFeature>.NativeClassPtr, 100665196);
		NativeMethodInfoPtr_get_requiresDecalLayers_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecalRendererFeature>.NativeClassPtr, 100665197);
		NativeMethodInfoPtr_get_isGLDevice_Internal_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecalRendererFeature>.NativeClassPtr, 100665198);
		NativeMethodInfoPtr_Create_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecalRendererFeature>.NativeClassPtr, 100665199);
		NativeMethodInfoPtr_RequireRenderingLayers_Internal_Virtual_Boolean_Boolean_Boolean_byref_Event_byref_MaskSize_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecalRendererFeature>.NativeClassPtr, 100665200);
		NativeMethodInfoPtr_GetDBufferSettings_Internal_DBufferSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecalRendererFeature>.NativeClassPtr, 100665201);
		NativeMethodInfoPtr_GetScreenSpaceSettings_Internal_DecalScreenSpaceSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecalRendererFeature>.NativeClassPtr, 100665202);
		NativeMethodInfoPtr_GetTechnique_Internal_DecalTechnique_ScriptableRendererData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecalRendererFeature>.NativeClassPtr, 100665203);
		NativeMethodInfoPtr_GetTechnique_Internal_DecalTechnique_ScriptableRenderer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecalRendererFeature>.NativeClassPtr, 100665204);
		NativeMethodInfoPtr_GetTechnique_Internal_DecalTechnique_Boolean_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecalRendererFeature>.NativeClassPtr, 100665205);
		NativeMethodInfoPtr_IsAutomaticDBuffer_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecalRendererFeature>.NativeClassPtr, 100665206);
		NativeMethodInfoPtr_RecreateSystemsIfNeeded_Private_Boolean_ScriptableRenderer_byref_CameraData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecalRendererFeature>.NativeClassPtr, 100665207);
		NativeMethodInfoPtr_OnCameraPreCull_Public_Virtual_Void_ScriptableRenderer_byref_CameraData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecalRendererFeature>.NativeClassPtr, 100665208);
		NativeMethodInfoPtr_AddRenderPasses_Public_Virtual_Void_ScriptableRenderer_byref_RenderingData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecalRendererFeature>.NativeClassPtr, 100665209);
		NativeMethodInfoPtr_SupportsNativeRenderPass_Internal_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecalRendererFeature>.NativeClassPtr, 100665210);
		NativeMethodInfoPtr_SetupRenderPasses_Public_Virtual_Void_ScriptableRenderer_byref_RenderingData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecalRendererFeature>.NativeClassPtr, 100665211);
		NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecalRendererFeature>.NativeClassPtr, 100665212);
		NativeMethodInfoPtr_ChangeAdaptivePerformanceDrawDistances_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecalRendererFeature>.NativeClassPtr, 100665213);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecalRendererFeature>.NativeClassPtr, 100665214);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1096613, XrefRangeEnd = 1096618, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void Create()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_Create_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1096618, XrefRangeEnd = 1096623, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override bool RequireRenderingLayers(bool isDeferred, bool needsGBufferAccurateNormals, out RenderingLayerUtils.Event atEvent, out RenderingLayerUtils.MaskSize maskSize)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[4];
		*ptr = (nint)(&isDeferred);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &needsGBufferAccurateNormals;
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(IntPtr)))) = Unsafe.AsPointer(ref atEvent);
		*(void**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(IntPtr)))) = Unsafe.AsPointer(ref maskSize);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_RequireRenderingLayers_Internal_Virtual_Boolean_Boolean_Boolean_byref_Event_byref_MaskSize_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1096623, XrefRangeEnd = 1096624, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe DBufferSettings GetDBufferSettings()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetDBufferSettings_Internal_DBufferSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (IntPtr)0) ? Il2CppObjectPool.Get<DBufferSettings>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1096624, XrefRangeEnd = 1096625, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe DecalScreenSpaceSettings GetScreenSpaceSettings()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetScreenSpaceSettings_Internal_DecalScreenSpaceSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (IntPtr)0) ? Il2CppObjectPool.Get<DecalScreenSpaceSettings>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1096625, XrefRangeEnd = 1096636, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe DecalTechnique GetTechnique(ScriptableRendererData renderer)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)renderer);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetTechnique_Internal_DecalTechnique_ScriptableRendererData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(DecalTechnique*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1096636, XrefRangeEnd = 1096643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe DecalTechnique GetTechnique(ScriptableRenderer renderer)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)renderer);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetTechnique_Internal_DecalTechnique_ScriptableRenderer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(DecalTechnique*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 1096674, RefRangeEnd = 1096678, XrefRangeStart = 1096643, XrefRangeEnd = 1096674, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe DecalTechnique GetTechnique(bool isDeferred, bool needsGBufferAccurateNormals, bool checkForInvalidTechniques = true)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[3];
		*ptr = (nint)(&isDeferred);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &needsGBufferAccurateNormals;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(IntPtr)))) = &checkForInvalidTechniques;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetTechnique_Internal_DecalTechnique_Boolean_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(DecalTechnique*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1096678, XrefRangeEnd = 1096689, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool IsAutomaticDBuffer()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsAutomaticDBuffer_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1096806, RefRangeEnd = 1096808, XrefRangeStart = 1096689, XrefRangeEnd = 1096806, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool RecreateSystemsIfNeeded(ScriptableRenderer renderer, [In] ref CameraData cameraData)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)renderer);
		*(IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)cameraData);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RecreateSystemsIfNeeded_Private_Boolean_ScriptableRenderer_byref_CameraData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1096808, XrefRangeEnd = 1096822, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void OnCameraPreCull(ScriptableRenderer renderer, [In] ref CameraData cameraData)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)renderer);
		*(IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)cameraData);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_OnCameraPreCull_Public_Virtual_Void_ScriptableRenderer_byref_CameraData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1096822, XrefRangeEnd = 1096835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void AddRenderPasses(ScriptableRenderer renderer, ref RenderingData renderingData)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)renderer);
		*(IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)renderingData);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_AddRenderPasses_Public_Virtual_Void_ScriptableRenderer_byref_RenderingData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	public unsafe override bool SupportsNativeRenderPass()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_SupportsNativeRenderPass_Internal_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1096835, XrefRangeEnd = 1096838, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void SetupRenderPasses(ScriptableRenderer renderer, [In] ref RenderingData renderingData)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)renderer);
		*(IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)renderingData);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_SetupRenderPasses_Public_Virtual_Void_ScriptableRenderer_byref_RenderingData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1096838, XrefRangeEnd = 1096886, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void Dispose(bool disposing)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&disposing);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(19883)]
	[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 20035, XrefRangeStart = 152, XrefRangeEnd = 20035, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ChangeAdaptivePerformanceDrawDistances()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ChangeAdaptivePerformanceDrawDistances_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1096886, XrefRangeEnd = 1096892, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe DecalRendererFeature()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DecalRendererFeature>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public DecalRendererFeature(IntPtr pointer)
		: base(pointer)
	{
	}
}
