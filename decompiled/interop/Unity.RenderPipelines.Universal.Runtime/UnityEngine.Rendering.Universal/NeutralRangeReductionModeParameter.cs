using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace UnityEngine.Rendering.Universal;

[Serializable]
public sealed class NeutralRangeReductionModeParameter : VolumeParameter<NeutralRangeReductionMode>
{
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_NeutralRangeReductionMode_Boolean_0;

	static NeutralRangeReductionModeParameter()
	{
		Il2CppClassPointerStore<NeutralRangeReductionModeParameter>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Universal.Runtime.dll", "UnityEngine.Rendering.Universal", "NeutralRangeReductionModeParameter");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NeutralRangeReductionModeParameter>.NativeClassPtr);
		NativeMethodInfoPtr__ctor_Public_Void_NeutralRangeReductionMode_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NeutralRangeReductionModeParameter>.NativeClassPtr, 100664850);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1089327, XrefRangeEnd = 1089330, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe NeutralRangeReductionModeParameter(NeutralRangeReductionMode value, bool overrideState = false)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NeutralRangeReductionModeParameter>.NativeClassPtr))
	{
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = (nint)(&value);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &overrideState;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_NeutralRangeReductionMode_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public NeutralRangeReductionModeParameter(IntPtr pointer)
		: base(pointer)
	{
	}
}
