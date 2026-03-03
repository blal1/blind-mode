using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Threading;

public static class _ThreadPoolWaitCallback : Object
{
	private static readonly System.IntPtr NativeMethodInfoPtr_PerformWaitCallback_Internal_Static_Boolean_0;

	static _ThreadPoolWaitCallback()
	{
		Il2CppClassPointerStore<_ThreadPoolWaitCallback>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Threading", "_ThreadPoolWaitCallback");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<_ThreadPoolWaitCallback>.NativeClassPtr);
		NativeMethodInfoPtr_PerformWaitCallback_Internal_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_ThreadPoolWaitCallback>.NativeClassPtr, 100667968);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 771661, XrefRangeEnd = 771665, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool PerformWaitCallback()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PerformWaitCallback_Internal_Static_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	public _ThreadPoolWaitCallback(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
