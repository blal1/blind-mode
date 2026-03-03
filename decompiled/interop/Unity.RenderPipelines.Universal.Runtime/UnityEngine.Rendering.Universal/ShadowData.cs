using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Unity.Collections;

namespace UnityEngine.Rendering.Universal;

public sealed class ShadowData : Il2CppSystem.ValueType
{
	private static readonly System.IntPtr NativeFieldInfoPtr_frameData;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Internal_Void_ContextContainer_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_universalShadowData_Internal_get_UniversalShadowData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_supportsMainLightShadows_Public_get_byref_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_mainLightShadowsEnabled_Internal_get_byref_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_mainLightShadowmapWidth_Public_get_byref_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_mainLightShadowmapHeight_Public_get_byref_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_mainLightShadowCascadesCount_Public_get_byref_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_mainLightShadowCascadesSplit_Public_get_byref_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_mainLightShadowCascadeBorder_Public_get_byref_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_supportsAdditionalLightShadows_Public_get_byref_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_additionalLightShadowsEnabled_Internal_get_byref_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_additionalLightsShadowmapWidth_Public_get_byref_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_additionalLightsShadowmapHeight_Public_get_byref_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_supportsSoftShadows_Public_get_byref_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_shadowmapDepthBufferBits_Public_get_byref_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_bias_Public_get_byref_List_1_Vector4_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_resolution_Public_get_byref_List_1_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_isKeywordAdditionalLightShadowsEnabled_Internal_get_byref_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_isKeywordSoftShadowsEnabled_Internal_get_byref_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_mainLightShadowResolution_Internal_get_byref_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_mainLightRenderTargetWidth_Internal_get_byref_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_mainLightRenderTargetHeight_Internal_get_byref_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_visibleLightsShadowCullingInfos_Internal_get_byref_NativeArray_1_URPLightShadowCullingInfos_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_shadowAtlasLayout_Internal_get_byref_AdditionalLightsShadowAtlasLayout_0;

	public unsafe ContextContainer frameData
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_frameData);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ContextContainer>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_frameData)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe UniversalShadowData universalShadowData
	{
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1107351, RefRangeEnd = 1107355, XrefRangeStart = 1107347, XrefRangeEnd = 1107351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_universalShadowData_Internal_get_UniversalShadowData_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<UniversalShadowData>(intPtr2) : null;
		}
	}

	public unsafe ref bool supportsMainLightShadows
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1107358, RefRangeEnd = 1107359, XrefRangeStart = 1107355, XrefRangeEnd = 1107358, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_supportsMainLightShadows_Public_get_byref_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return ref *(bool*)intPtr2;
		}
	}

	public unsafe ref bool mainLightShadowsEnabled
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1107359, XrefRangeEnd = 1107362, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_mainLightShadowsEnabled_Internal_get_byref_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return ref *(bool*)intPtr2;
		}
	}

	public unsafe ref int mainLightShadowmapWidth
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1107362, XrefRangeEnd = 1107365, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_mainLightShadowmapWidth_Public_get_byref_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return ref *(int*)intPtr2;
		}
	}

	public unsafe ref int mainLightShadowmapHeight
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1107365, XrefRangeEnd = 1107368, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_mainLightShadowmapHeight_Public_get_byref_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return ref *(int*)intPtr2;
		}
	}

	public unsafe ref int mainLightShadowCascadesCount
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1107368, XrefRangeEnd = 1107371, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_mainLightShadowCascadesCount_Public_get_byref_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return ref *(int*)intPtr2;
		}
	}

	public unsafe ref Vector3 mainLightShadowCascadesSplit
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1107371, XrefRangeEnd = 1107374, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_mainLightShadowCascadesSplit_Public_get_byref_Vector3_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return ref *(Vector3*)intPtr2;
		}
	}

	public unsafe ref float mainLightShadowCascadeBorder
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1107374, XrefRangeEnd = 1107377, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_mainLightShadowCascadeBorder_Public_get_byref_Single_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return ref *(float*)intPtr2;
		}
	}

	public unsafe ref bool supportsAdditionalLightShadows
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1107377, XrefRangeEnd = 1107380, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_supportsAdditionalLightShadows_Public_get_byref_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return ref *(bool*)intPtr2;
		}
	}

	public unsafe ref bool additionalLightShadowsEnabled
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1107380, XrefRangeEnd = 1107383, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_additionalLightShadowsEnabled_Internal_get_byref_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return ref *(bool*)intPtr2;
		}
	}

	public unsafe ref int additionalLightsShadowmapWidth
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1107383, XrefRangeEnd = 1107386, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_additionalLightsShadowmapWidth_Public_get_byref_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return ref *(int*)intPtr2;
		}
	}

	public unsafe ref int additionalLightsShadowmapHeight
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1107386, XrefRangeEnd = 1107389, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_additionalLightsShadowmapHeight_Public_get_byref_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return ref *(int*)intPtr2;
		}
	}

	public unsafe ref bool supportsSoftShadows
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1107392, RefRangeEnd = 1107393, XrefRangeStart = 1107389, XrefRangeEnd = 1107392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_supportsSoftShadows_Public_get_byref_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return ref *(bool*)intPtr2;
		}
	}

	public unsafe ref int shadowmapDepthBufferBits
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1107393, XrefRangeEnd = 1107396, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_shadowmapDepthBufferBits_Public_get_byref_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return ref *(int*)intPtr2;
		}
	}

	public unsafe ref List<Vector4> bias
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1107399, RefRangeEnd = 1107400, XrefRangeStart = 1107396, XrefRangeEnd = 1107399, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_bias_Public_get_byref_List_1_Vector4_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return ref *(List<Vector4>*)intPtr2;
		}
	}

	public unsafe ref List<int> resolution
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1107400, XrefRangeEnd = 1107403, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_resolution_Public_get_byref_List_1_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return ref *(List<int>*)intPtr2;
		}
	}

	public unsafe ref bool isKeywordAdditionalLightShadowsEnabled
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1107403, XrefRangeEnd = 1107406, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_isKeywordAdditionalLightShadowsEnabled_Internal_get_byref_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return ref *(bool*)intPtr2;
		}
	}

	public unsafe ref bool isKeywordSoftShadowsEnabled
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1107406, XrefRangeEnd = 1107409, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_isKeywordSoftShadowsEnabled_Internal_get_byref_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return ref *(bool*)intPtr2;
		}
	}

	public unsafe ref int mainLightShadowResolution
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1107409, XrefRangeEnd = 1107412, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_mainLightShadowResolution_Internal_get_byref_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return ref *(int*)intPtr2;
		}
	}

	public unsafe ref int mainLightRenderTargetWidth
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1107412, XrefRangeEnd = 1107415, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_mainLightRenderTargetWidth_Internal_get_byref_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return ref *(int*)intPtr2;
		}
	}

	public unsafe ref int mainLightRenderTargetHeight
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1107415, XrefRangeEnd = 1107418, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_mainLightRenderTargetHeight_Internal_get_byref_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return ref *(int*)intPtr2;
		}
	}

	public unsafe ref NativeArray<URPLightShadowCullingInfos> visibleLightsShadowCullingInfos
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1107418, XrefRangeEnd = 1107421, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_visibleLightsShadowCullingInfos_Internal_get_byref_NativeArray_1_URPLightShadowCullingInfos_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return ref *(NativeArray<URPLightShadowCullingInfos>*)intPtr2;
		}
	}

	public unsafe ref AdditionalLightsShadowAtlasLayout shadowAtlasLayout
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1107421, XrefRangeEnd = 1107424, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_shadowAtlasLayout_Internal_get_byref_AdditionalLightsShadowAtlasLayout_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return ref *(AdditionalLightsShadowAtlasLayout*)intPtr2;
		}
	}

	static ShadowData()
	{
		Il2CppClassPointerStore<ShadowData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Universal.Runtime.dll", "UnityEngine.Rendering.Universal", "ShadowData");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShadowData>.NativeClassPtr);
		NativeFieldInfoPtr_frameData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShadowData>.NativeClassPtr, "frameData");
		NativeMethodInfoPtr__ctor_Internal_Void_ContextContainer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShadowData>.NativeClassPtr, 100666084);
		NativeMethodInfoPtr_get_universalShadowData_Internal_get_UniversalShadowData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShadowData>.NativeClassPtr, 100666085);
		NativeMethodInfoPtr_get_supportsMainLightShadows_Public_get_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShadowData>.NativeClassPtr, 100666086);
		NativeMethodInfoPtr_get_mainLightShadowsEnabled_Internal_get_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShadowData>.NativeClassPtr, 100666087);
		NativeMethodInfoPtr_get_mainLightShadowmapWidth_Public_get_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShadowData>.NativeClassPtr, 100666088);
		NativeMethodInfoPtr_get_mainLightShadowmapHeight_Public_get_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShadowData>.NativeClassPtr, 100666089);
		NativeMethodInfoPtr_get_mainLightShadowCascadesCount_Public_get_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShadowData>.NativeClassPtr, 100666090);
		NativeMethodInfoPtr_get_mainLightShadowCascadesSplit_Public_get_byref_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShadowData>.NativeClassPtr, 100666091);
		NativeMethodInfoPtr_get_mainLightShadowCascadeBorder_Public_get_byref_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShadowData>.NativeClassPtr, 100666092);
		NativeMethodInfoPtr_get_supportsAdditionalLightShadows_Public_get_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShadowData>.NativeClassPtr, 100666093);
		NativeMethodInfoPtr_get_additionalLightShadowsEnabled_Internal_get_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShadowData>.NativeClassPtr, 100666094);
		NativeMethodInfoPtr_get_additionalLightsShadowmapWidth_Public_get_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShadowData>.NativeClassPtr, 100666095);
		NativeMethodInfoPtr_get_additionalLightsShadowmapHeight_Public_get_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShadowData>.NativeClassPtr, 100666096);
		NativeMethodInfoPtr_get_supportsSoftShadows_Public_get_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShadowData>.NativeClassPtr, 100666097);
		NativeMethodInfoPtr_get_shadowmapDepthBufferBits_Public_get_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShadowData>.NativeClassPtr, 100666098);
		NativeMethodInfoPtr_get_bias_Public_get_byref_List_1_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShadowData>.NativeClassPtr, 100666099);
		NativeMethodInfoPtr_get_resolution_Public_get_byref_List_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShadowData>.NativeClassPtr, 100666100);
		NativeMethodInfoPtr_get_isKeywordAdditionalLightShadowsEnabled_Internal_get_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShadowData>.NativeClassPtr, 100666101);
		NativeMethodInfoPtr_get_isKeywordSoftShadowsEnabled_Internal_get_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShadowData>.NativeClassPtr, 100666102);
		NativeMethodInfoPtr_get_mainLightShadowResolution_Internal_get_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShadowData>.NativeClassPtr, 100666103);
		NativeMethodInfoPtr_get_mainLightRenderTargetWidth_Internal_get_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShadowData>.NativeClassPtr, 100666104);
		NativeMethodInfoPtr_get_mainLightRenderTargetHeight_Internal_get_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShadowData>.NativeClassPtr, 100666105);
		NativeMethodInfoPtr_get_visibleLightsShadowCullingInfos_Internal_get_byref_NativeArray_1_URPLightShadowCullingInfos_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShadowData>.NativeClassPtr, 100666106);
		NativeMethodInfoPtr_get_shadowAtlasLayout_Internal_get_byref_AdditionalLightsShadowAtlasLayout_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShadowData>.NativeClassPtr, 100666107);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 110106, RefRangeEnd = 110111, XrefRangeStart = 110106, XrefRangeEnd = 110111, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ShadowData(ContextContainer frameData)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShadowData>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)frameData);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Internal_Void_ContextContainer_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public ShadowData(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public ShadowData()
		: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShadowData>.NativeClassPtr))
	{
	}
}
