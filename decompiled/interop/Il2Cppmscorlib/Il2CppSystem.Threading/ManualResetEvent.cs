using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace Il2CppSystem.Threading;

public sealed class ManualResetEvent : EventWaitHandle
{
	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Boolean_0;

	static ManualResetEvent()
	{
		Il2CppClassPointerStore<ManualResetEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Threading", "ManualResetEvent");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ManualResetEvent>.NativeClassPtr);
		NativeMethodInfoPtr__ctor_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManualResetEvent>.NativeClassPtr, 100667565);
	}

	[CallerCount(13)]
	[CachedScanResults(RefRangeStart = 766837, RefRangeEnd = 766850, XrefRangeStart = 766836, XrefRangeEnd = 766837, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ManualResetEvent(bool initialState)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ManualResetEvent>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&initialState);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public ManualResetEvent(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
