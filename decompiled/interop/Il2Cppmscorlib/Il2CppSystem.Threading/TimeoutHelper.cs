using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Threading;

public static class TimeoutHelper : Object
{
	private static readonly System.IntPtr NativeMethodInfoPtr_GetTime_Public_Static_UInt32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UpdateTimeOut_Public_Static_Int32_UInt32_Int32_0;

	static TimeoutHelper()
	{
		Il2CppClassPointerStore<TimeoutHelper>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Threading", "TimeoutHelper");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TimeoutHelper>.NativeClassPtr);
		NativeMethodInfoPtr_GetTime_Public_Static_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeoutHelper>.NativeClassPtr, 100667634);
		NativeMethodInfoPtr_UpdateTimeOut_Public_Static_Int32_UInt32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeoutHelper>.NativeClassPtr, 100667635);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 767373, XrefRangeEnd = 767374, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static uint GetTime()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetTime_Public_Static_UInt32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(uint*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 767375, RefRangeEnd = 767379, XrefRangeStart = 767374, XrefRangeEnd = 767375, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int UpdateTimeOut(uint startTime, int originalWaitMillisecondsTimeout)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&startTime);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &originalWaitMillisecondsTimeout;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdateTimeOut_Public_Static_Int32_UInt32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	public TimeoutHelper(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
