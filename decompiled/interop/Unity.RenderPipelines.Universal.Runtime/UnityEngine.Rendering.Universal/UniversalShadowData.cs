using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using Unity.Collections;

namespace UnityEngine.Rendering.Universal;

public class UniversalShadowData : ContextItem
{
	private static readonly IntPtr NativeFieldInfoPtr_supportsMainLightShadows;

	private static readonly IntPtr NativeFieldInfoPtr_mainLightShadowsEnabled;

	private static readonly IntPtr NativeFieldInfoPtr_mainLightShadowmapWidth;

	private static readonly IntPtr NativeFieldInfoPtr_mainLightShadowmapHeight;

	private static readonly IntPtr NativeFieldInfoPtr_mainLightShadowCascadesCount;

	private static readonly IntPtr NativeFieldInfoPtr_mainLightShadowCascadesSplit;

	private static readonly IntPtr NativeFieldInfoPtr_mainLightShadowCascadeBorder;

	private static readonly IntPtr NativeFieldInfoPtr_supportsAdditionalLightShadows;

	private static readonly IntPtr NativeFieldInfoPtr_additionalLightShadowsEnabled;

	private static readonly IntPtr NativeFieldInfoPtr_additionalLightsShadowmapWidth;

	private static readonly IntPtr NativeFieldInfoPtr_additionalLightsShadowmapHeight;

	private static readonly IntPtr NativeFieldInfoPtr_supportsSoftShadows;

	private static readonly IntPtr NativeFieldInfoPtr_shadowmapDepthBufferBits;

	private static readonly IntPtr NativeFieldInfoPtr_bias;

	private static readonly IntPtr NativeFieldInfoPtr_resolution;

	private static readonly IntPtr NativeFieldInfoPtr_isKeywordAdditionalLightShadowsEnabled;

	private static readonly IntPtr NativeFieldInfoPtr_isKeywordSoftShadowsEnabled;

	private static readonly IntPtr NativeFieldInfoPtr_mainLightShadowResolution;

	private static readonly IntPtr NativeFieldInfoPtr_mainLightRenderTargetWidth;

	private static readonly IntPtr NativeFieldInfoPtr_mainLightRenderTargetHeight;

	private static readonly IntPtr NativeFieldInfoPtr_visibleLightsShadowCullingInfos;

	private static readonly IntPtr NativeFieldInfoPtr_shadowAtlasLayout;

	private static readonly IntPtr NativeMethodInfoPtr_Reset_Public_Virtual_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe bool supportsMainLightShadows
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_supportsMainLightShadows);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_supportsMainLightShadows)) = value;
		}
	}

	public unsafe bool mainLightShadowsEnabled
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mainLightShadowsEnabled);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mainLightShadowsEnabled)) = value;
		}
	}

	public unsafe int mainLightShadowmapWidth
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mainLightShadowmapWidth);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mainLightShadowmapWidth)) = value;
		}
	}

	public unsafe int mainLightShadowmapHeight
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mainLightShadowmapHeight);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mainLightShadowmapHeight)) = value;
		}
	}

	public unsafe int mainLightShadowCascadesCount
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mainLightShadowCascadesCount);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mainLightShadowCascadesCount)) = value;
		}
	}

	public unsafe Vector3 mainLightShadowCascadesSplit
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mainLightShadowCascadesSplit);
			return *(Vector3*)num;
		}
		set
		{
			*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mainLightShadowCascadesSplit)) = value;
		}
	}

	public unsafe float mainLightShadowCascadeBorder
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mainLightShadowCascadeBorder);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mainLightShadowCascadeBorder)) = value;
		}
	}

	public unsafe bool supportsAdditionalLightShadows
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_supportsAdditionalLightShadows);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_supportsAdditionalLightShadows)) = value;
		}
	}

	public unsafe bool additionalLightShadowsEnabled
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_additionalLightShadowsEnabled);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_additionalLightShadowsEnabled)) = value;
		}
	}

	public unsafe int additionalLightsShadowmapWidth
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_additionalLightsShadowmapWidth);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_additionalLightsShadowmapWidth)) = value;
		}
	}

	public unsafe int additionalLightsShadowmapHeight
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_additionalLightsShadowmapHeight);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_additionalLightsShadowmapHeight)) = value;
		}
	}

	public unsafe bool supportsSoftShadows
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_supportsSoftShadows);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_supportsSoftShadows)) = value;
		}
	}

	public unsafe int shadowmapDepthBufferBits
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_shadowmapDepthBufferBits);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_shadowmapDepthBufferBits)) = value;
		}
	}

	public unsafe List<Vector4> bias
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bias);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<List<Vector4>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bias)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe List<int> resolution
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_resolution);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<List<int>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_resolution)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe bool isKeywordAdditionalLightShadowsEnabled
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isKeywordAdditionalLightShadowsEnabled);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isKeywordAdditionalLightShadowsEnabled)) = value;
		}
	}

	public unsafe bool isKeywordSoftShadowsEnabled
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isKeywordSoftShadowsEnabled);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isKeywordSoftShadowsEnabled)) = value;
		}
	}

	public unsafe int mainLightShadowResolution
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mainLightShadowResolution);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mainLightShadowResolution)) = value;
		}
	}

	public unsafe int mainLightRenderTargetWidth
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mainLightRenderTargetWidth);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mainLightRenderTargetWidth)) = value;
		}
	}

	public unsafe int mainLightRenderTargetHeight
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mainLightRenderTargetHeight);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mainLightRenderTargetHeight)) = value;
		}
	}

	public unsafe NativeArray<URPLightShadowCullingInfos> visibleLightsShadowCullingInfos
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_visibleLightsShadowCullingInfos);
			return new NativeArray<URPLightShadowCullingInfos>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<URPLightShadowCullingInfos>>.NativeClassPtr, (IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_visibleLightsShadowCullingInfos), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<URPLightShadowCullingInfos>>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe AdditionalLightsShadowAtlasLayout shadowAtlasLayout
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_shadowAtlasLayout);
			return new AdditionalLightsShadowAtlasLayout(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AdditionalLightsShadowAtlasLayout>.NativeClassPtr, (IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_shadowAtlasLayout), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AdditionalLightsShadowAtlasLayout>.NativeClassPtr, ref *(uint*)null));
		}
	}

	static UniversalShadowData()
	{
		Il2CppClassPointerStore<UniversalShadowData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Universal.Runtime.dll", "UnityEngine.Rendering.Universal", "UniversalShadowData");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UniversalShadowData>.NativeClassPtr);
		NativeFieldInfoPtr_supportsMainLightShadows = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalShadowData>.NativeClassPtr, "supportsMainLightShadows");
		NativeFieldInfoPtr_mainLightShadowsEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalShadowData>.NativeClassPtr, "mainLightShadowsEnabled");
		NativeFieldInfoPtr_mainLightShadowmapWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalShadowData>.NativeClassPtr, "mainLightShadowmapWidth");
		NativeFieldInfoPtr_mainLightShadowmapHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalShadowData>.NativeClassPtr, "mainLightShadowmapHeight");
		NativeFieldInfoPtr_mainLightShadowCascadesCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalShadowData>.NativeClassPtr, "mainLightShadowCascadesCount");
		NativeFieldInfoPtr_mainLightShadowCascadesSplit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalShadowData>.NativeClassPtr, "mainLightShadowCascadesSplit");
		NativeFieldInfoPtr_mainLightShadowCascadeBorder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalShadowData>.NativeClassPtr, "mainLightShadowCascadeBorder");
		NativeFieldInfoPtr_supportsAdditionalLightShadows = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalShadowData>.NativeClassPtr, "supportsAdditionalLightShadows");
		NativeFieldInfoPtr_additionalLightShadowsEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalShadowData>.NativeClassPtr, "additionalLightShadowsEnabled");
		NativeFieldInfoPtr_additionalLightsShadowmapWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalShadowData>.NativeClassPtr, "additionalLightsShadowmapWidth");
		NativeFieldInfoPtr_additionalLightsShadowmapHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalShadowData>.NativeClassPtr, "additionalLightsShadowmapHeight");
		NativeFieldInfoPtr_supportsSoftShadows = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalShadowData>.NativeClassPtr, "supportsSoftShadows");
		NativeFieldInfoPtr_shadowmapDepthBufferBits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalShadowData>.NativeClassPtr, "shadowmapDepthBufferBits");
		NativeFieldInfoPtr_bias = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalShadowData>.NativeClassPtr, "bias");
		NativeFieldInfoPtr_resolution = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalShadowData>.NativeClassPtr, "resolution");
		NativeFieldInfoPtr_isKeywordAdditionalLightShadowsEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalShadowData>.NativeClassPtr, "isKeywordAdditionalLightShadowsEnabled");
		NativeFieldInfoPtr_isKeywordSoftShadowsEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalShadowData>.NativeClassPtr, "isKeywordSoftShadowsEnabled");
		NativeFieldInfoPtr_mainLightShadowResolution = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalShadowData>.NativeClassPtr, "mainLightShadowResolution");
		NativeFieldInfoPtr_mainLightRenderTargetWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalShadowData>.NativeClassPtr, "mainLightRenderTargetWidth");
		NativeFieldInfoPtr_mainLightRenderTargetHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalShadowData>.NativeClassPtr, "mainLightRenderTargetHeight");
		NativeFieldInfoPtr_visibleLightsShadowCullingInfos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalShadowData>.NativeClassPtr, "visibleLightsShadowCullingInfos");
		NativeFieldInfoPtr_shadowAtlasLayout = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalShadowData>.NativeClassPtr, "shadowAtlasLayout");
		NativeMethodInfoPtr_Reset_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalShadowData>.NativeClassPtr, 100664629);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalShadowData>.NativeClassPtr, 100664630);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1087539, XrefRangeEnd = 1087543, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void Reset()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_Reset_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(134)]
	[CachedScanResults(RefRangeStart = 24861, RefRangeEnd = 24995, XrefRangeStart = 24861, XrefRangeEnd = 24995, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe UniversalShadowData()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UniversalShadowData>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public UniversalShadowData(IntPtr pointer)
		: base(pointer)
	{
	}
}
