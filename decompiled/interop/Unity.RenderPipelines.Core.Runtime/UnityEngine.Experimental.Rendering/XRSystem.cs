using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine.Rendering;
using UnityEngine.XR;

namespace UnityEngine.Experimental.Rendering;

public static class XRSystem : Il2CppSystem.Object
{
	[ObfuscatedName("UnityEngine.Experimental.Rendering.XRSystem+<>c__DisplayClass44_0")]
	public sealed class __c__DisplayClass44_0 : Il2CppSystem.ValueType
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_camera;

		public unsafe Camera camera
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_camera);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Camera>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_camera)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		static __c__DisplayClass44_0()
		{
			Il2CppClassPointerStore<__c__DisplayClass44_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<XRSystem>.NativeClassPtr, "<>c__DisplayClass44_0");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c__DisplayClass44_0>.NativeClassPtr);
			NativeFieldInfoPtr_camera = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass44_0>.NativeClassPtr, "camera");
		}

		public __c__DisplayClass44_0(System.IntPtr pointer)
			: base(pointer)
		{
		}

		public __c__DisplayClass44_0()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c__DisplayClass44_0>.NativeClassPtr))
		{
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_s_Layout;

	private static readonly System.IntPtr NativeFieldInfoPtr_s_PassAllocator;

	private static readonly System.IntPtr NativeFieldInfoPtr_s_DisplayList;

	private static readonly System.IntPtr NativeFieldInfoPtr_s_Display;

	private static readonly System.IntPtr NativeFieldInfoPtr_s_MSAASamples;

	private static readonly System.IntPtr NativeFieldInfoPtr_s_OcclusionMeshScaling;

	private static readonly System.IntPtr NativeFieldInfoPtr_s_OcclusionMeshMaterial;

	private static readonly System.IntPtr NativeFieldInfoPtr_s_MirrorViewMaterial;

	private static readonly System.IntPtr NativeFieldInfoPtr_s_LayoutOverride;

	private static readonly System.IntPtr NativeFieldInfoPtr_emptyPass;

	private static readonly System.IntPtr NativeFieldInfoPtr__singlePassAllowed_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__foveatedRenderingCaps_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__dumpDebugInfo_k__BackingField;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetActiveDisplay_Public_Static_XRDisplaySubsystem_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_displayActive_Public_Static_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_isHDRDisplayOutputActive_Public_Static_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_singlePassAllowed_Public_Static_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_singlePassAllowed_Public_Static_set_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_foveatedRenderingCaps_Public_Static_get_FoveatedRenderingCaps_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_foveatedRenderingCaps_Public_Static_set_Void_FoveatedRenderingCaps_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_dumpDebugInfo_Public_Static_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_dumpDebugInfo_Public_Static_set_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Initialize_Public_Static_Void_Func_2_XRPassCreateInfo_XRPass_Shader_Shader_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetDisplayMSAASamples_Public_Static_Void_MSAASamples_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetDisplayMSAASamples_Public_Static_MSAASamples_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetOcclusionMeshScale_Internal_Static_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetOcclusionMeshScale_Internal_Static_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetMirrorViewMode_Internal_Static_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetMirrorViewMode_Internal_Static_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetRenderScale_Public_Static_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetRenderViewportScale_Public_Static_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_NewLayout_Public_Static_XRLayout_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_EndLayout_Public_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RenderMirrorView_Public_Static_Void_CommandBuffer_Camera_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetDisplayZRange_Internal_Static_Void_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetLayoutOverride_Private_Static_Void_Action_2_XRLayout_Camera_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_XRSystemInit_Private_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RefreshDeviceInfo_Private_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateDefaultLayout_Internal_Static_Void_Camera_XRLayout_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ReconfigurePass_Internal_Static_Void_XRPass_Camera_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CanUseSinglePass_Private_Static_Boolean_Camera_XRRenderPass_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_BuildView_Private_Static_XRView_XRRenderPass_XRRenderParameter_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_XrRenderTextureDescToUnityRenderTextureDesc_Private_Static_RenderTextureDescriptor_RenderTextureDescriptor_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_BuildPass_Private_Static_XRPassCreateInfo_XRRenderPass_ScriptableCullingParameters_XRLayout_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Method_Internal_Static_Void_XRPass_XRRenderPass_Int32_byref___c__DisplayClass44_0_0;

	public unsafe static XRLayoutStack s_Layout
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_Layout, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<XRLayoutStack>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_Layout, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Il2CppSystem.Func<XRPassCreateInfo, XRPass> s_PassAllocator
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_PassAllocator, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Func<XRPassCreateInfo, XRPass>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_PassAllocator, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static List<XRDisplaySubsystem> s_DisplayList
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_DisplayList, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<XRDisplaySubsystem>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_DisplayList, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static XRDisplaySubsystem s_Display
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_Display, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<XRDisplaySubsystem>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_Display, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static MSAASamples s_MSAASamples
	{
		get
		{
			Unsafe.SkipInit(out MSAASamples result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_MSAASamples, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_MSAASamples, (void*)(&value));
		}
	}

	public unsafe static float s_OcclusionMeshScaling
	{
		get
		{
			Unsafe.SkipInit(out float result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_OcclusionMeshScaling, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_OcclusionMeshScaling, (void*)(&value));
		}
	}

	public unsafe static Material s_OcclusionMeshMaterial
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_OcclusionMeshMaterial, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_OcclusionMeshMaterial, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Material s_MirrorViewMaterial
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_MirrorViewMaterial, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_MirrorViewMaterial, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Il2CppSystem.Action<XRLayout, Camera> s_LayoutOverride
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_LayoutOverride, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Action<XRLayout, Camera>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_LayoutOverride, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static XRPass emptyPass
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_emptyPass, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<XRPass>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_emptyPass, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static bool _singlePassAllowed_k__BackingField
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__singlePassAllowed_k__BackingField, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__singlePassAllowed_k__BackingField, (void*)(&value));
		}
	}

	public unsafe static FoveatedRenderingCaps _foveatedRenderingCaps_k__BackingField
	{
		get
		{
			Unsafe.SkipInit(out FoveatedRenderingCaps result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__foveatedRenderingCaps_k__BackingField, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__foveatedRenderingCaps_k__BackingField, (void*)(&value));
		}
	}

	public unsafe static bool _dumpDebugInfo_k__BackingField
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__dumpDebugInfo_k__BackingField, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__dumpDebugInfo_k__BackingField, (void*)(&value));
		}
	}

	public unsafe static bool displayActive
	{
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 1025740, RefRangeEnd = 1025747, XrefRangeStart = 1025733, XrefRangeEnd = 1025740, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_displayActive_Public_Static_get_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe static bool isHDRDisplayOutputActive
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1025757, RefRangeEnd = 1025758, XrefRangeStart = 1025747, XrefRangeEnd = 1025757, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_isHDRDisplayOutputActive_Public_Static_get_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe static bool singlePassAllowed
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1025758, XrefRangeEnd = 1025762, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_singlePassAllowed_Public_Static_get_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1025762, XrefRangeEnd = 1025766, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_singlePassAllowed_Public_Static_set_Void_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe static FoveatedRenderingCaps foveatedRenderingCaps
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1025766, XrefRangeEnd = 1025770, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_foveatedRenderingCaps_Public_Static_get_FoveatedRenderingCaps_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(FoveatedRenderingCaps*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1025770, XrefRangeEnd = 1025774, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_foveatedRenderingCaps_Public_Static_set_Void_FoveatedRenderingCaps_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe static bool dumpDebugInfo
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1025774, XrefRangeEnd = 1025778, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_dumpDebugInfo_Public_Static_get_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1025778, XrefRangeEnd = 1025782, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_dumpDebugInfo_Public_Static_set_Void_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	static XRSystem()
	{
		Il2CppClassPointerStore<XRSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Experimental.Rendering", "XRSystem");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XRSystem>.NativeClassPtr);
		NativeFieldInfoPtr_s_Layout = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XRSystem>.NativeClassPtr, "s_Layout");
		NativeFieldInfoPtr_s_PassAllocator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XRSystem>.NativeClassPtr, "s_PassAllocator");
		NativeFieldInfoPtr_s_DisplayList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XRSystem>.NativeClassPtr, "s_DisplayList");
		NativeFieldInfoPtr_s_Display = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XRSystem>.NativeClassPtr, "s_Display");
		NativeFieldInfoPtr_s_MSAASamples = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XRSystem>.NativeClassPtr, "s_MSAASamples");
		NativeFieldInfoPtr_s_OcclusionMeshScaling = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XRSystem>.NativeClassPtr, "s_OcclusionMeshScaling");
		NativeFieldInfoPtr_s_OcclusionMeshMaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XRSystem>.NativeClassPtr, "s_OcclusionMeshMaterial");
		NativeFieldInfoPtr_s_MirrorViewMaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XRSystem>.NativeClassPtr, "s_MirrorViewMaterial");
		NativeFieldInfoPtr_s_LayoutOverride = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XRSystem>.NativeClassPtr, "s_LayoutOverride");
		NativeFieldInfoPtr_emptyPass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XRSystem>.NativeClassPtr, "emptyPass");
		NativeFieldInfoPtr__singlePassAllowed_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XRSystem>.NativeClassPtr, "<singlePassAllowed>k__BackingField");
		NativeFieldInfoPtr__foveatedRenderingCaps_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XRSystem>.NativeClassPtr, "<foveatedRenderingCaps>k__BackingField");
		NativeFieldInfoPtr__dumpDebugInfo_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XRSystem>.NativeClassPtr, "<dumpDebugInfo>k__BackingField");
		NativeMethodInfoPtr_GetActiveDisplay_Public_Static_XRDisplaySubsystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XRSystem>.NativeClassPtr, 100663419);
		NativeMethodInfoPtr_get_displayActive_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XRSystem>.NativeClassPtr, 100663420);
		NativeMethodInfoPtr_get_isHDRDisplayOutputActive_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XRSystem>.NativeClassPtr, 100663421);
		NativeMethodInfoPtr_get_singlePassAllowed_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XRSystem>.NativeClassPtr, 100663422);
		NativeMethodInfoPtr_set_singlePassAllowed_Public_Static_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XRSystem>.NativeClassPtr, 100663423);
		NativeMethodInfoPtr_get_foveatedRenderingCaps_Public_Static_get_FoveatedRenderingCaps_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XRSystem>.NativeClassPtr, 100663424);
		NativeMethodInfoPtr_set_foveatedRenderingCaps_Public_Static_set_Void_FoveatedRenderingCaps_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XRSystem>.NativeClassPtr, 100663425);
		NativeMethodInfoPtr_get_dumpDebugInfo_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XRSystem>.NativeClassPtr, 100663426);
		NativeMethodInfoPtr_set_dumpDebugInfo_Public_Static_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XRSystem>.NativeClassPtr, 100663427);
		NativeMethodInfoPtr_Initialize_Public_Static_Void_Func_2_XRPassCreateInfo_XRPass_Shader_Shader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XRSystem>.NativeClassPtr, 100663428);
		NativeMethodInfoPtr_SetDisplayMSAASamples_Public_Static_Void_MSAASamples_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XRSystem>.NativeClassPtr, 100663429);
		NativeMethodInfoPtr_GetDisplayMSAASamples_Public_Static_MSAASamples_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XRSystem>.NativeClassPtr, 100663430);
		NativeMethodInfoPtr_SetOcclusionMeshScale_Internal_Static_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XRSystem>.NativeClassPtr, 100663431);
		NativeMethodInfoPtr_GetOcclusionMeshScale_Internal_Static_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XRSystem>.NativeClassPtr, 100663432);
		NativeMethodInfoPtr_SetMirrorViewMode_Internal_Static_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XRSystem>.NativeClassPtr, 100663433);
		NativeMethodInfoPtr_GetMirrorViewMode_Internal_Static_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XRSystem>.NativeClassPtr, 100663434);
		NativeMethodInfoPtr_SetRenderScale_Public_Static_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XRSystem>.NativeClassPtr, 100663435);
		NativeMethodInfoPtr_GetRenderViewportScale_Public_Static_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XRSystem>.NativeClassPtr, 100663436);
		NativeMethodInfoPtr_NewLayout_Public_Static_XRLayout_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XRSystem>.NativeClassPtr, 100663437);
		NativeMethodInfoPtr_EndLayout_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XRSystem>.NativeClassPtr, 100663438);
		NativeMethodInfoPtr_RenderMirrorView_Public_Static_Void_CommandBuffer_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XRSystem>.NativeClassPtr, 100663439);
		NativeMethodInfoPtr_Dispose_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XRSystem>.NativeClassPtr, 100663440);
		NativeMethodInfoPtr_SetDisplayZRange_Internal_Static_Void_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XRSystem>.NativeClassPtr, 100663441);
		NativeMethodInfoPtr_SetLayoutOverride_Private_Static_Void_Action_2_XRLayout_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XRSystem>.NativeClassPtr, 100663442);
		NativeMethodInfoPtr_XRSystemInit_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XRSystem>.NativeClassPtr, 100663443);
		NativeMethodInfoPtr_RefreshDeviceInfo_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XRSystem>.NativeClassPtr, 100663444);
		NativeMethodInfoPtr_CreateDefaultLayout_Internal_Static_Void_Camera_XRLayout_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XRSystem>.NativeClassPtr, 100663445);
		NativeMethodInfoPtr_ReconfigurePass_Internal_Static_Void_XRPass_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XRSystem>.NativeClassPtr, 100663446);
		NativeMethodInfoPtr_CanUseSinglePass_Private_Static_Boolean_Camera_XRRenderPass_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XRSystem>.NativeClassPtr, 100663447);
		NativeMethodInfoPtr_BuildView_Private_Static_XRView_XRRenderPass_XRRenderParameter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XRSystem>.NativeClassPtr, 100663448);
		NativeMethodInfoPtr_XrRenderTextureDescToUnityRenderTextureDesc_Private_Static_RenderTextureDescriptor_RenderTextureDescriptor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XRSystem>.NativeClassPtr, 100663449);
		NativeMethodInfoPtr_BuildPass_Private_Static_XRPassCreateInfo_XRRenderPass_ScriptableCullingParameters_XRLayout_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XRSystem>.NativeClassPtr, 100663450);
		NativeMethodInfoPtr_Method_Internal_Static_Void_XRPass_XRRenderPass_Int32_byref___c__DisplayClass44_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XRSystem>.NativeClassPtr, 100663452);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1025729, XrefRangeEnd = 1025733, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static XRDisplaySubsystem GetActiveDisplay()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetActiveDisplay_Public_Static_XRDisplaySubsystem_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<XRDisplaySubsystem>(intPtr2) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1025870, RefRangeEnd = 1025871, XrefRangeStart = 1025782, XrefRangeEnd = 1025870, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Initialize(Il2CppSystem.Func<XRPassCreateInfo, XRPass> passAllocator, Shader occlusionMeshPS, Shader mirrorViewPS)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)passAllocator);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)occlusionMeshPS);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)mirrorViewPS);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Initialize_Public_Static_Void_Func_2_XRPassCreateInfo_XRPass_Shader_Shader_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1025903, RefRangeEnd = 1025905, XrefRangeStart = 1025871, XrefRangeEnd = 1025903, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetDisplayMSAASamples(MSAASamples msaaSamples)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&msaaSamples);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetDisplayMSAASamples_Public_Static_Void_MSAASamples_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1025905, XrefRangeEnd = 1025909, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static MSAASamples GetDisplayMSAASamples()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetDisplayMSAASamples_Public_Static_MSAASamples_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(MSAASamples*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1025909, XrefRangeEnd = 1025913, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetOcclusionMeshScale(float occlusionMeshScale)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&occlusionMeshScale);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetOcclusionMeshScale_Internal_Static_Void_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1025913, XrefRangeEnd = 1025917, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float GetOcclusionMeshScale()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetOcclusionMeshScale_Internal_Static_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1025924, RefRangeEnd = 1025925, XrefRangeStart = 1025917, XrefRangeEnd = 1025924, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetMirrorViewMode(int mirrorBlitMode)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&mirrorBlitMode);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetMirrorViewMode_Internal_Static_Void_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1025925, XrefRangeEnd = 1025932, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int GetMirrorViewMode()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetMirrorViewMode_Internal_Static_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1025958, RefRangeEnd = 1025960, XrefRangeStart = 1025932, XrefRangeEnd = 1025958, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetRenderScale(float renderScale)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&renderScale);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetRenderScale_Public_Static_Void_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1025966, RefRangeEnd = 1025968, XrefRangeStart = 1025960, XrefRangeEnd = 1025966, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float GetRenderViewportScale()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetRenderViewportScale_Public_Static_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1025982, RefRangeEnd = 1025983, XrefRangeStart = 1025968, XrefRangeEnd = 1025982, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static XRLayout NewLayout()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_NewLayout_Public_Static_XRLayout_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<XRLayout>(intPtr2) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1026002, RefRangeEnd = 1026003, XrefRangeStart = 1025983, XrefRangeEnd = 1026002, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void EndLayout()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_EndLayout_Public_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1026011, RefRangeEnd = 1026012, XrefRangeStart = 1026003, XrefRangeEnd = 1026011, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void RenderMirrorView(CommandBuffer cmd, Camera camera)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cmd);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)camera);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RenderMirrorView_Public_Static_Void_CommandBuffer_Camera_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1026045, RefRangeEnd = 1026047, XrefRangeStart = 1026012, XrefRangeEnd = 1026045, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Dispose()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Dispose_Public_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1026047, XrefRangeEnd = 1026056, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetDisplayZRange(float zNear, float zFar)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&zNear);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &zFar;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetDisplayZRange_Internal_Static_Void_Single_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1026056, XrefRangeEnd = 1026062, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetLayoutOverride(Il2CppSystem.Action<XRLayout, Camera> action)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)action);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetLayoutOverride_Private_Static_Void_Action_2_XRLayout_Camera_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1026062, XrefRangeEnd = 1026074, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void XRSystemInit()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_XRSystemInit_Private_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1026122, RefRangeEnd = 1026125, XrefRangeStart = 1026074, XrefRangeEnd = 1026122, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void RefreshDeviceInfo()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RefreshDeviceInfo_Private_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1026125, XrefRangeEnd = 1026180, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void CreateDefaultLayout(Camera camera, XRLayout layout)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)camera);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)layout);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateDefaultLayout_Internal_Static_Void_Camera_XRLayout_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1026219, RefRangeEnd = 1026220, XrefRangeStart = 1026180, XrefRangeEnd = 1026219, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ReconfigurePass(XRPass xrPass, Camera camera)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)xrPass);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)camera);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ReconfigurePass_Internal_Static_Void_XRPass_Camera_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1026220, XrefRangeEnd = 1026232, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool CanUseSinglePass(Camera camera, XRDisplaySubsystem.XRRenderPass renderPass)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)camera);
		*(XRDisplaySubsystem.XRRenderPass**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &renderPass;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CanUseSinglePass_Private_Static_Boolean_Camera_XRRenderPass_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1026239, RefRangeEnd = 1026241, XrefRangeStart = 1026232, XrefRangeEnd = 1026239, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static XRView BuildView(XRDisplaySubsystem.XRRenderPass renderPass, XRDisplaySubsystem.XRRenderParameter renderParameter)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&renderPass);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)renderParameter));
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_BuildView_Private_Static_XRView_XRRenderPass_XRRenderParameter_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return new XRView(pointer);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1026241, XrefRangeEnd = 1026245, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static RenderTextureDescriptor XrRenderTextureDescToUnityRenderTextureDesc(RenderTextureDescriptor xrDesc)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&xrDesc);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_XrRenderTextureDescToUnityRenderTextureDesc_Private_Static_RenderTextureDescriptor_RenderTextureDescriptor_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(RenderTextureDescriptor*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1026265, RefRangeEnd = 1026267, XrefRangeStart = 1026245, XrefRangeEnd = 1026265, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static XRPassCreateInfo BuildPass(XRDisplaySubsystem.XRRenderPass xrRenderPass, ScriptableCullingParameters cullingParameters, XRLayout layout)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&xrRenderPass);
		*(ScriptableCullingParameters**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &cullingParameters;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)layout);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_BuildPass_Private_Static_XRPassCreateInfo_XRRenderPass_ScriptableCullingParameters_XRLayout_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return new XRPassCreateInfo(pointer);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1026274, RefRangeEnd = 1026276, XrefRangeStart = 1026267, XrefRangeEnd = 1026274, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Method_Internal_Static_Void_XRPass_XRRenderPass_Int32_byref___c__DisplayClass44_0_0(XRPass xrPass, XRDisplaySubsystem.XRRenderPass renderPass, int renderParamIndex, ref __c__DisplayClass44_0 A_3)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)xrPass);
		*(XRDisplaySubsystem.XRRenderPass**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &renderPass;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &renderParamIndex;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)A_3);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Method_Internal_Static_Void_XRPass_XRRenderPass_Int32_byref___c__DisplayClass44_0_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public XRSystem(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
