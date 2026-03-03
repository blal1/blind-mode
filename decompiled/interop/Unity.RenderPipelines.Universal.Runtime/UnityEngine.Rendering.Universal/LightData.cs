using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Unity.Collections;

namespace UnityEngine.Rendering.Universal;

public sealed class LightData : Il2CppSystem.ValueType
{
	private static readonly System.IntPtr NativeFieldInfoPtr_frameData;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Internal_Void_ContextContainer_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_universalLightData_Internal_get_UniversalLightData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_mainLightIndex_Public_get_byref_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_additionalLightsCount_Public_get_byref_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_maxPerObjectAdditionalLightsCount_Public_get_byref_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_visibleLights_Public_get_byref_NativeArray_1_VisibleLight_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_shadeAdditionalLightsPerVertex_Public_get_byref_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_supportsMixedLighting_Public_get_byref_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_reflectionProbeBoxProjection_Public_get_byref_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_reflectionProbeBlending_Public_get_byref_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_supportsLightLayers_Public_get_byref_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_supportsAdditionalLights_Public_get_byref_Boolean_0;

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

	public unsafe UniversalLightData universalLightData
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1106948, XrefRangeEnd = 1106952, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_universalLightData_Internal_get_UniversalLightData_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<UniversalLightData>(intPtr2) : null;
		}
	}

	public unsafe ref int mainLightIndex
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1106955, RefRangeEnd = 1106956, XrefRangeStart = 1106952, XrefRangeEnd = 1106955, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_mainLightIndex_Public_get_byref_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return ref *(int*)intPtr2;
		}
	}

	public unsafe ref int additionalLightsCount
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1106956, XrefRangeEnd = 1106959, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_additionalLightsCount_Public_get_byref_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return ref *(int*)intPtr2;
		}
	}

	public unsafe ref int maxPerObjectAdditionalLightsCount
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1106959, XrefRangeEnd = 1106962, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_maxPerObjectAdditionalLightsCount_Public_get_byref_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return ref *(int*)intPtr2;
		}
	}

	public unsafe ref NativeArray<VisibleLight> visibleLights
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1106962, XrefRangeEnd = 1106965, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_visibleLights_Public_get_byref_NativeArray_1_VisibleLight_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return ref *(NativeArray<VisibleLight>*)intPtr2;
		}
	}

	public unsafe ref bool shadeAdditionalLightsPerVertex
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1106965, XrefRangeEnd = 1106968, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_shadeAdditionalLightsPerVertex_Public_get_byref_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return ref *(bool*)intPtr2;
		}
	}

	public unsafe ref bool supportsMixedLighting
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1106968, XrefRangeEnd = 1106971, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_supportsMixedLighting_Public_get_byref_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return ref *(bool*)intPtr2;
		}
	}

	public unsafe ref bool reflectionProbeBoxProjection
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1106971, XrefRangeEnd = 1106974, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_reflectionProbeBoxProjection_Public_get_byref_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return ref *(bool*)intPtr2;
		}
	}

	public unsafe ref bool reflectionProbeBlending
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1106974, XrefRangeEnd = 1106977, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_reflectionProbeBlending_Public_get_byref_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return ref *(bool*)intPtr2;
		}
	}

	public unsafe ref bool supportsLightLayers
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1106977, XrefRangeEnd = 1106980, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_supportsLightLayers_Public_get_byref_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return ref *(bool*)intPtr2;
		}
	}

	public unsafe ref bool supportsAdditionalLights
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1106980, XrefRangeEnd = 1106983, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_supportsAdditionalLights_Public_get_byref_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return ref *(bool*)intPtr2;
		}
	}

	static LightData()
	{
		Il2CppClassPointerStore<LightData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Universal.Runtime.dll", "UnityEngine.Rendering.Universal", "LightData");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LightData>.NativeClassPtr);
		NativeFieldInfoPtr_frameData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightData>.NativeClassPtr, "frameData");
		NativeMethodInfoPtr__ctor_Internal_Void_ContextContainer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightData>.NativeClassPtr, 100665999);
		NativeMethodInfoPtr_get_universalLightData_Internal_get_UniversalLightData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightData>.NativeClassPtr, 100666000);
		NativeMethodInfoPtr_get_mainLightIndex_Public_get_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightData>.NativeClassPtr, 100666001);
		NativeMethodInfoPtr_get_additionalLightsCount_Public_get_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightData>.NativeClassPtr, 100666002);
		NativeMethodInfoPtr_get_maxPerObjectAdditionalLightsCount_Public_get_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightData>.NativeClassPtr, 100666003);
		NativeMethodInfoPtr_get_visibleLights_Public_get_byref_NativeArray_1_VisibleLight_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightData>.NativeClassPtr, 100666004);
		NativeMethodInfoPtr_get_shadeAdditionalLightsPerVertex_Public_get_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightData>.NativeClassPtr, 100666005);
		NativeMethodInfoPtr_get_supportsMixedLighting_Public_get_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightData>.NativeClassPtr, 100666006);
		NativeMethodInfoPtr_get_reflectionProbeBoxProjection_Public_get_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightData>.NativeClassPtr, 100666007);
		NativeMethodInfoPtr_get_reflectionProbeBlending_Public_get_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightData>.NativeClassPtr, 100666008);
		NativeMethodInfoPtr_get_supportsLightLayers_Public_get_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightData>.NativeClassPtr, 100666009);
		NativeMethodInfoPtr_get_supportsAdditionalLights_Public_get_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightData>.NativeClassPtr, 100666010);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 110106, RefRangeEnd = 110111, XrefRangeStart = 110106, XrefRangeEnd = 110111, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe LightData(ContextContainer frameData)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LightData>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)frameData);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Internal_Void_ContextContainer_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public LightData(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public LightData()
		: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LightData>.NativeClassPtr))
	{
	}
}
