using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace UnityEngine.Rendering.Universal;

[Serializable]
public sealed class DepthOfFieldModeParameter : VolumeParameter<DepthOfFieldMode>
{
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_DepthOfFieldMode_Boolean_0;

	static DepthOfFieldModeParameter()
	{
		Il2CppClassPointerStore<DepthOfFieldModeParameter>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Universal.Runtime.dll", "UnityEngine.Rendering.Universal", "DepthOfFieldModeParameter");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DepthOfFieldModeParameter>.NativeClassPtr);
		NativeMethodInfoPtr__ctor_Public_Void_DepthOfFieldMode_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DepthOfFieldModeParameter>.NativeClassPtr, 100664816);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1088842, XrefRangeEnd = 1088845, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe DepthOfFieldModeParameter(DepthOfFieldMode value, bool overrideState = false)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DepthOfFieldModeParameter>.NativeClassPtr))
	{
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = (nint)(&value);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &overrideState;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_DepthOfFieldMode_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public DepthOfFieldModeParameter(IntPtr pointer)
		: base(pointer)
	{
	}
}
