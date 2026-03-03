using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Unity.Collections;

namespace UnityEngine.Rendering.Universal;

public class UniversalLightData : ContextItem
{
	private static readonly IntPtr NativeFieldInfoPtr_mainLightIndex;

	private static readonly IntPtr NativeFieldInfoPtr_additionalLightsCount;

	private static readonly IntPtr NativeFieldInfoPtr_maxPerObjectAdditionalLightsCount;

	private static readonly IntPtr NativeFieldInfoPtr_visibleLights;

	private static readonly IntPtr NativeFieldInfoPtr_shadeAdditionalLightsPerVertex;

	private static readonly IntPtr NativeFieldInfoPtr_supportsMixedLighting;

	private static readonly IntPtr NativeFieldInfoPtr_reflectionProbeBoxProjection;

	private static readonly IntPtr NativeFieldInfoPtr_reflectionProbeBlending;

	private static readonly IntPtr NativeFieldInfoPtr_supportsLightLayers;

	private static readonly IntPtr NativeFieldInfoPtr_supportsAdditionalLights;

	private static readonly IntPtr NativeMethodInfoPtr_Reset_Public_Virtual_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe int mainLightIndex
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mainLightIndex);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mainLightIndex)) = value;
		}
	}

	public unsafe int additionalLightsCount
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_additionalLightsCount);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_additionalLightsCount)) = value;
		}
	}

	public unsafe int maxPerObjectAdditionalLightsCount
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxPerObjectAdditionalLightsCount);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxPerObjectAdditionalLightsCount)) = value;
		}
	}

	public unsafe NativeArray<VisibleLight> visibleLights
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_visibleLights);
			return new NativeArray<VisibleLight>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<VisibleLight>>.NativeClassPtr, (IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_visibleLights), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<VisibleLight>>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe bool shadeAdditionalLightsPerVertex
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_shadeAdditionalLightsPerVertex);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_shadeAdditionalLightsPerVertex)) = value;
		}
	}

	public unsafe bool supportsMixedLighting
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_supportsMixedLighting);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_supportsMixedLighting)) = value;
		}
	}

	public unsafe bool reflectionProbeBoxProjection
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_reflectionProbeBoxProjection);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_reflectionProbeBoxProjection)) = value;
		}
	}

	public unsafe bool reflectionProbeBlending
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_reflectionProbeBlending);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_reflectionProbeBlending)) = value;
		}
	}

	public unsafe bool supportsLightLayers
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_supportsLightLayers);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_supportsLightLayers)) = value;
		}
	}

	public unsafe bool supportsAdditionalLights
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_supportsAdditionalLights);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_supportsAdditionalLights)) = value;
		}
	}

	static UniversalLightData()
	{
		Il2CppClassPointerStore<UniversalLightData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Universal.Runtime.dll", "UnityEngine.Rendering.Universal", "UniversalLightData");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UniversalLightData>.NativeClassPtr);
		NativeFieldInfoPtr_mainLightIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalLightData>.NativeClassPtr, "mainLightIndex");
		NativeFieldInfoPtr_additionalLightsCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalLightData>.NativeClassPtr, "additionalLightsCount");
		NativeFieldInfoPtr_maxPerObjectAdditionalLightsCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalLightData>.NativeClassPtr, "maxPerObjectAdditionalLightsCount");
		NativeFieldInfoPtr_visibleLights = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalLightData>.NativeClassPtr, "visibleLights");
		NativeFieldInfoPtr_shadeAdditionalLightsPerVertex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalLightData>.NativeClassPtr, "shadeAdditionalLightsPerVertex");
		NativeFieldInfoPtr_supportsMixedLighting = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalLightData>.NativeClassPtr, "supportsMixedLighting");
		NativeFieldInfoPtr_reflectionProbeBoxProjection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalLightData>.NativeClassPtr, "reflectionProbeBoxProjection");
		NativeFieldInfoPtr_reflectionProbeBlending = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalLightData>.NativeClassPtr, "reflectionProbeBlending");
		NativeFieldInfoPtr_supportsLightLayers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalLightData>.NativeClassPtr, "supportsLightLayers");
		NativeFieldInfoPtr_supportsAdditionalLights = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalLightData>.NativeClassPtr, "supportsAdditionalLights");
		NativeMethodInfoPtr_Reset_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalLightData>.NativeClassPtr, 100664553);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalLightData>.NativeClassPtr, 100664554);
	}

	[CallerCount(0)]
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
	public unsafe UniversalLightData()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UniversalLightData>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public UniversalLightData(IntPtr pointer)
		: base(pointer)
	{
	}
}
