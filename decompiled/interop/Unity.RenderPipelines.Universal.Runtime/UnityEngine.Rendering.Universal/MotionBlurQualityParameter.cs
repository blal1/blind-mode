using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace UnityEngine.Rendering.Universal;

[Serializable]
public sealed class MotionBlurQualityParameter : VolumeParameter<MotionBlurQuality>
{
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_MotionBlurQuality_Boolean_0;

	static MotionBlurQualityParameter()
	{
		Il2CppClassPointerStore<MotionBlurQualityParameter>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Universal.Runtime.dll", "UnityEngine.Rendering.Universal", "MotionBlurQualityParameter");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MotionBlurQualityParameter>.NativeClassPtr);
		NativeMethodInfoPtr__ctor_Public_Void_MotionBlurQuality_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MotionBlurQualityParameter>.NativeClassPtr, 100664831);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1088948, XrefRangeEnd = 1088951, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe MotionBlurQualityParameter(MotionBlurQuality value, bool overrideState = false)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MotionBlurQualityParameter>.NativeClassPtr))
	{
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = (nint)(&value);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &overrideState;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_MotionBlurQuality_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public MotionBlurQualityParameter(IntPtr pointer)
		: base(pointer)
	{
	}
}
