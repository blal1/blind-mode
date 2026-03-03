using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace UnityEngine.Rendering;

public class ProbeTouchupVolume : ProbeAdjustmentVolume
{
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	static ProbeTouchupVolume()
	{
		Il2CppClassPointerStore<ProbeTouchupVolume>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Rendering", "ProbeTouchupVolume");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProbeTouchupVolume>.NativeClassPtr);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeTouchupVolume>.NativeClassPtr, 100665187);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1036611, XrefRangeEnd = 1036612, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ProbeTouchupVolume()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProbeTouchupVolume>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public ProbeTouchupVolume(IntPtr pointer)
		: base(pointer)
	{
	}
}
