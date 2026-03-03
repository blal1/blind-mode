using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem;

public static class NotImplemented : Object
{
	private static readonly System.IntPtr NativeMethodInfoPtr_ByDesignWithMessage_Internal_Static_Exception_String_0;

	static NotImplemented()
	{
		Il2CppClassPointerStore<NotImplemented>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System", "NotImplemented");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NotImplemented>.NativeClassPtr);
		NativeMethodInfoPtr_ByDesignWithMessage_Internal_Static_Exception_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NotImplemented>.NativeClassPtr, 100664148);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 869078, XrefRangeEnd = 869082, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Exception ByDesignWithMessage(string message)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ByDesignWithMessage_Internal_Static_Exception_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Exception>(intPtr2) : null;
	}

	public NotImplemented(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
