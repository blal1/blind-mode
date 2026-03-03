using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;

namespace UnityEngine.Rendering.Universal;

[System.Serializable]
public class ScreenSpaceAmbientOcclusionSettings : Il2CppSystem.Object
{
	[OriginalName("Unity.RenderPipelines.Universal.Runtime.dll", "", "DepthSource")]
	public enum DepthSource
	{
		Depth,
		DepthNormals
	}

	[OriginalName("Unity.RenderPipelines.Universal.Runtime.dll", "", "NormalQuality")]
	public enum NormalQuality
	{
		Low,
		Medium,
		High
	}

	[OriginalName("Unity.RenderPipelines.Universal.Runtime.dll", "", "AOSampleOption")]
	public enum AOSampleOption
	{
		High,
		Medium,
		Low
	}

	[OriginalName("Unity.RenderPipelines.Universal.Runtime.dll", "", "AOMethodOptions")]
	public enum AOMethodOptions
	{
		BlueNoise,
		InterleavedGradient
	}

	[OriginalName("Unity.RenderPipelines.Universal.Runtime.dll", "", "BlurQualityOptions")]
	public enum BlurQualityOptions
	{
		High,
		Medium,
		Low
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_AOMethod;

	private static readonly System.IntPtr NativeFieldInfoPtr_Downsample;

	private static readonly System.IntPtr NativeFieldInfoPtr_AfterOpaque;

	private static readonly System.IntPtr NativeFieldInfoPtr_Source;

	private static readonly System.IntPtr NativeFieldInfoPtr_NormalSamples;

	private static readonly System.IntPtr NativeFieldInfoPtr_Intensity;

	private static readonly System.IntPtr NativeFieldInfoPtr_DirectLightingStrength;

	private static readonly System.IntPtr NativeFieldInfoPtr_Radius;

	private static readonly System.IntPtr NativeFieldInfoPtr_Samples;

	private static readonly System.IntPtr NativeFieldInfoPtr_BlurQuality;

	private static readonly System.IntPtr NativeFieldInfoPtr_Falloff;

	private static readonly System.IntPtr NativeFieldInfoPtr_SampleCount;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe AOMethodOptions AOMethod
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_AOMethod);
			return *(AOMethodOptions*)num;
		}
		set
		{
			*(AOMethodOptions*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_AOMethod)) = value;
		}
	}

	public unsafe bool Downsample
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Downsample);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Downsample)) = value;
		}
	}

	public unsafe bool AfterOpaque
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_AfterOpaque);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_AfterOpaque)) = value;
		}
	}

	public unsafe DepthSource Source
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Source);
			return *(DepthSource*)num;
		}
		set
		{
			*(DepthSource*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Source)) = value;
		}
	}

	public unsafe NormalQuality NormalSamples
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_NormalSamples);
			return *(NormalQuality*)num;
		}
		set
		{
			*(NormalQuality*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_NormalSamples)) = value;
		}
	}

	public unsafe float Intensity
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Intensity);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Intensity)) = value;
		}
	}

	public unsafe float DirectLightingStrength
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DirectLightingStrength);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DirectLightingStrength)) = value;
		}
	}

	public unsafe float Radius
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Radius);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Radius)) = value;
		}
	}

	public unsafe AOSampleOption Samples
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Samples);
			return *(AOSampleOption*)num;
		}
		set
		{
			*(AOSampleOption*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Samples)) = value;
		}
	}

	public unsafe BlurQualityOptions BlurQuality
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_BlurQuality);
			return *(BlurQualityOptions*)num;
		}
		set
		{
			*(BlurQualityOptions*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_BlurQuality)) = value;
		}
	}

	public unsafe float Falloff
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Falloff);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Falloff)) = value;
		}
	}

	public unsafe int SampleCount
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SampleCount);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SampleCount)) = value;
		}
	}

	static ScreenSpaceAmbientOcclusionSettings()
	{
		Il2CppClassPointerStore<ScreenSpaceAmbientOcclusionSettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Universal.Runtime.dll", "UnityEngine.Rendering.Universal", "ScreenSpaceAmbientOcclusionSettings");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ScreenSpaceAmbientOcclusionSettings>.NativeClassPtr);
		NativeFieldInfoPtr_AOMethod = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenSpaceAmbientOcclusionSettings>.NativeClassPtr, "AOMethod");
		NativeFieldInfoPtr_Downsample = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenSpaceAmbientOcclusionSettings>.NativeClassPtr, "Downsample");
		NativeFieldInfoPtr_AfterOpaque = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenSpaceAmbientOcclusionSettings>.NativeClassPtr, "AfterOpaque");
		NativeFieldInfoPtr_Source = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenSpaceAmbientOcclusionSettings>.NativeClassPtr, "Source");
		NativeFieldInfoPtr_NormalSamples = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenSpaceAmbientOcclusionSettings>.NativeClassPtr, "NormalSamples");
		NativeFieldInfoPtr_Intensity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenSpaceAmbientOcclusionSettings>.NativeClassPtr, "Intensity");
		NativeFieldInfoPtr_DirectLightingStrength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenSpaceAmbientOcclusionSettings>.NativeClassPtr, "DirectLightingStrength");
		NativeFieldInfoPtr_Radius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenSpaceAmbientOcclusionSettings>.NativeClassPtr, "Radius");
		NativeFieldInfoPtr_Samples = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenSpaceAmbientOcclusionSettings>.NativeClassPtr, "Samples");
		NativeFieldInfoPtr_BlurQuality = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenSpaceAmbientOcclusionSettings>.NativeClassPtr, "BlurQuality");
		NativeFieldInfoPtr_Falloff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenSpaceAmbientOcclusionSettings>.NativeClassPtr, "Falloff");
		NativeFieldInfoPtr_SampleCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenSpaceAmbientOcclusionSettings>.NativeClassPtr, "SampleCount");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenSpaceAmbientOcclusionSettings>.NativeClassPtr, 100665250);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1097305, XrefRangeEnd = 1097306, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ScreenSpaceAmbientOcclusionSettings()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ScreenSpaceAmbientOcclusionSettings>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public ScreenSpaceAmbientOcclusionSettings(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
