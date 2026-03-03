using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace Il2CppSystem.Threading;

public sealed class AutoResetEvent : EventWaitHandle
{
	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Boolean_0;

	static AutoResetEvent()
	{
		Il2CppClassPointerStore<AutoResetEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Threading", "AutoResetEvent");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AutoResetEvent>.NativeClassPtr);
		NativeMethodInfoPtr__ctor_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AutoResetEvent>.NativeClassPtr, 100667554);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 766766, RefRangeEnd = 766767, XrefRangeStart = 766765, XrefRangeEnd = 766766, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AutoResetEvent(bool initialState)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AutoResetEvent>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&initialState);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public AutoResetEvent(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
