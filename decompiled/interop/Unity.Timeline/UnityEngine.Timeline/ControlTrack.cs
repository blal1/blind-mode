using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace UnityEngine.Timeline;

public class ControlTrack : TrackAsset
{
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	static ControlTrack()
	{
		Il2CppClassPointerStore<ControlTrack>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Timeline.dll", "UnityEngine.Timeline", "ControlTrack");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ControlTrack>.NativeClassPtr);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlTrack>.NativeClassPtr, 100663825);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1139726, XrefRangeEnd = 1139730, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ControlTrack()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ControlTrack>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public ControlTrack(IntPtr pointer)
		: base(pointer)
	{
	}
}
