using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace UnityEngine.Timeline;

[Serializable]
public class SignalTrack : MarkerTrack
{
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	static SignalTrack()
	{
		Il2CppClassPointerStore<SignalTrack>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Timeline.dll", "UnityEngine.Timeline", "SignalTrack");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SignalTrack>.NativeClassPtr);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SignalTrack>.NativeClassPtr, 100663991);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe SignalTrack()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SignalTrack>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public SignalTrack(IntPtr pointer)
		: base(pointer)
	{
	}
}
