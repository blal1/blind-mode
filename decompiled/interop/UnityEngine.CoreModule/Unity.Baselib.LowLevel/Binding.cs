using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;

namespace Unity.Baselib.LowLevel;

public static class Binding
{
	public enum Baselib_ErrorCode
	{
		Success = 0,
		OutOfMemory = 16777216,
		OutOfSystemResources = 16777217,
		InvalidAddressRange = 16777218,
		InvalidArgument = 16777219,
		InvalidBufferSize = 16777220,
		InvalidState = 16777221,
		NotSupported = 16777222,
		Timeout = 16777223,
		UnsupportedAlignment = 33554432,
		InvalidPageSize = 33554433,
		InvalidPageCount = 33554434,
		UnsupportedPageState = 33554435,
		ThreadCannotJoinSelf = 50331648,
		NetworkInitializationError = 67108864,
		AddressInUse = 67108865,
		AddressUnreachable = 67108866,
		AddressFamilyNotSupported = 67108867,
		Disconnected = 67108868,
		InvalidPathname = 83886080,
		RequestedAccessIsNotAllowed = 83886081,
		IOError = 83886082,
		FailedToOpenDynamicLibrary = 100663296,
		FunctionNotFound = 100663297,
		NoSupportedAddressFound = 117440512,
		TryAgain = 117440513,
		UnexpectedError = -1
	}

	public enum Baselib_ErrorState_NativeErrorCodeType : byte
	{
		None,
		PlatformDefined
	}

	public enum Baselib_ErrorState_ExtraInformationType : byte
	{
		None,
		StaticString,
		GenerationCounter
	}

	public enum Baselib_ErrorState_ExplainVerbosity
	{
		ErrorType,
		ErrorType_SourceLocation_Explanation
	}

	public enum Baselib_FileIO_OpenFlags : uint
	{
		Read = 1u,
		Write = 2u,
		OpenAlways = 4u,
		CreateAlways = 8u
	}

	public enum Baselib_FileIO_Priority
	{
		Normal,
		High
	}

	public enum Baselib_FileIO_EventQueue_ResultType
	{
		Baselib_FileIO_EventQueue_Callback = 1,
		Baselib_FileIO_EventQueue_OpenFile,
		Baselib_FileIO_EventQueue_ReadFile,
		Baselib_FileIO_EventQueue_CloseFile
	}

	public enum Baselib_Memory_PageState
	{
		Reserved = 0,
		NoAccess = 1,
		ReadOnly = 2,
		ReadWrite = 4,
		ReadOnly_Executable = 18,
		ReadWrite_Executable = 20
	}

	public enum Baselib_NetworkAddress_Family
	{
		Invalid,
		IPv4,
		IPv6
	}

	public enum Baselib_NetworkAddress_AddressReuse
	{
		DoNotAllow,
		Allow
	}

	public struct Baselib_RegisteredNetwork_Endpoint
	{
	}

	public enum Baselib_RegisteredNetwork_CompletionStatus
	{
		Failed,
		Success
	}

	public enum Baselib_RegisteredNetwork_ProcessStatus
	{
		NonePendingImmediately = 0,
		Done = 0,
		Pending = 1
	}

	public enum Baselib_RegisteredNetwork_CompletionQueueStatus
	{
		NoResultsAvailable,
		ResultsAvailable
	}

	public enum Baselib_Socket_Protocol
	{
		UDP = 1,
		TCP
	}

	public enum Baselib_Socket_PollEvents
	{
		Readable = 1,
		Writable = 2,
		Connected = 4
	}

	public enum Baselib_WakeupFallbackStrategy
	{
		OneByOne,
		All
	}

	private delegate IntPtr Baselib_Memory_AllocateDelegate(UIntPtr size);

	private delegate IntPtr Baselib_Memory_ReallocateDelegate(IntPtr ptr, UIntPtr newSize);

	private delegate void Baselib_Memory_FreeDelegate(IntPtr ptr);

	private delegate IntPtr Baselib_Memory_AlignedAllocateDelegate(UIntPtr size, UIntPtr alignment);

	private delegate IntPtr Baselib_Memory_AlignedReallocateDelegate(IntPtr ptr, UIntPtr newSize, UIntPtr alignment);

	private delegate void Baselib_Memory_AlignedFreeDelegate(IntPtr ptr);

	private delegate bool Baselib_RegisteredNetwork_IsEmulatedDelegate();

	private delegate bool Baselib_SystemFutex_NativeSupportDelegate();

	private delegate void Baselib_SystemFutex_WaitDelegate(IntPtr address, int expected, uint timeoutInMilliseconds);

	private delegate void Baselib_SystemFutex_NotifyDelegate(IntPtr address, uint count, Baselib_WakeupFallbackStrategy wakeupFallbackStrategy);

	private delegate void Baselib_Thread_YieldExecutionDelegate();

	private delegate IntPtr Baselib_Thread_GetCurrentThreadIdDelegate();

	private delegate UIntPtr Baselib_TLS_AllocDelegate();

	private delegate void Baselib_TLS_FreeDelegate(UIntPtr handle);

	private delegate void Baselib_TLS_SetDelegate(UIntPtr handle, UIntPtr value);

	private delegate UIntPtr Baselib_TLS_GetDelegate(UIntPtr handle);

	private delegate ulong Baselib_Timer_GetHighPrecisionTimerTicksDelegate();

	private delegate void Baselib_Timer_WaitForAtLeastDelegate(uint timeInMilliseconds);

	private delegate double Baselib_Timer_GetTimeSinceStartupInSecondsDelegate();

	private delegate void Baselib_RegisteredNetwork_Endpoint_Empty_InjectedDelegate([Out] IntPtr ret);

	public const uint Baselib_NetworkAddress_IpMaxStringLength = 46u;

	public const uint Baselib_RegisteredNetwork_Endpoint_MaxSize = 28u;

	public const int Baselib_SystemSemaphore_MaxCount = int.MaxValue;

	public const uint Baselib_TLS_MinimumGuaranteedSlots = 100u;

	public const ulong Baselib_SecondsPerMinute = 60uL;

	public const ulong Baselib_MillisecondsPerSecond = 1000uL;

	public const ulong Baselib_MillisecondsPerMinute = 60000uL;

	public const ulong Baselib_MicrosecondsPerMillisecond = 1000uL;

	public const ulong Baselib_MicrosecondsPerSecond = 1000000uL;

	public const ulong Baselib_MicrosecondsPerMinute = 60000000uL;

	public const ulong Baselib_NanosecondsPerMicrosecond = 1000uL;

	public const ulong Baselib_NanosecondsPerMillisecond = 1000000uL;

	public const ulong Baselib_NanosecondsPerSecond = 1000000000uL;

	public const ulong Baselib_NanosecondsPerMinute = 60000000000uL;

	public const ulong Baselib_Timer_MaxNumberOfNanosecondsPerTick = 1000uL;

	public const double Baselib_Timer_MinNumberOfNanosecondsPerTick = 0.01;

	public const double Baselib_Timer_HighPrecisionTimerCrossThreadMontotonyTolerance_InNanoseconds = 100.0;

	private static readonly Baselib_Memory_AllocateDelegate Baselib_Memory_AllocateDelegateField = IL2CPP.ResolveICall<Baselib_Memory_AllocateDelegate>("Unity.Baselib.LowLevel.Binding::Baselib_Memory_Allocate");

	private static readonly Baselib_Memory_ReallocateDelegate Baselib_Memory_ReallocateDelegateField = IL2CPP.ResolveICall<Baselib_Memory_ReallocateDelegate>("Unity.Baselib.LowLevel.Binding::Baselib_Memory_Reallocate");

	private static readonly Baselib_Memory_FreeDelegate Baselib_Memory_FreeDelegateField = IL2CPP.ResolveICall<Baselib_Memory_FreeDelegate>("Unity.Baselib.LowLevel.Binding::Baselib_Memory_Free");

	private static readonly Baselib_Memory_AlignedAllocateDelegate Baselib_Memory_AlignedAllocateDelegateField = IL2CPP.ResolveICall<Baselib_Memory_AlignedAllocateDelegate>("Unity.Baselib.LowLevel.Binding::Baselib_Memory_AlignedAllocate");

	private static readonly Baselib_Memory_AlignedReallocateDelegate Baselib_Memory_AlignedReallocateDelegateField = IL2CPP.ResolveICall<Baselib_Memory_AlignedReallocateDelegate>("Unity.Baselib.LowLevel.Binding::Baselib_Memory_AlignedReallocate");

	private static readonly Baselib_Memory_AlignedFreeDelegate Baselib_Memory_AlignedFreeDelegateField = IL2CPP.ResolveICall<Baselib_Memory_AlignedFreeDelegate>("Unity.Baselib.LowLevel.Binding::Baselib_Memory_AlignedFree");

	private static readonly Baselib_RegisteredNetwork_IsEmulatedDelegate Baselib_RegisteredNetwork_IsEmulatedDelegateField = IL2CPP.ResolveICall<Baselib_RegisteredNetwork_IsEmulatedDelegate>("Unity.Baselib.LowLevel.Binding::Baselib_RegisteredNetwork_IsEmulated");

	private static readonly Baselib_SystemFutex_NativeSupportDelegate Baselib_SystemFutex_NativeSupportDelegateField = IL2CPP.ResolveICall<Baselib_SystemFutex_NativeSupportDelegate>("Unity.Baselib.LowLevel.Binding::Baselib_SystemFutex_NativeSupport");

	private static readonly Baselib_SystemFutex_WaitDelegate Baselib_SystemFutex_WaitDelegateField = IL2CPP.ResolveICall<Baselib_SystemFutex_WaitDelegate>("Unity.Baselib.LowLevel.Binding::Baselib_SystemFutex_Wait");

	private static readonly Baselib_SystemFutex_NotifyDelegate Baselib_SystemFutex_NotifyDelegateField = IL2CPP.ResolveICall<Baselib_SystemFutex_NotifyDelegate>("Unity.Baselib.LowLevel.Binding::Baselib_SystemFutex_Notify");

	private static readonly Baselib_Thread_YieldExecutionDelegate Baselib_Thread_YieldExecutionDelegateField = IL2CPP.ResolveICall<Baselib_Thread_YieldExecutionDelegate>("Unity.Baselib.LowLevel.Binding::Baselib_Thread_YieldExecution");

	private static readonly Baselib_Thread_GetCurrentThreadIdDelegate Baselib_Thread_GetCurrentThreadIdDelegateField = IL2CPP.ResolveICall<Baselib_Thread_GetCurrentThreadIdDelegate>("Unity.Baselib.LowLevel.Binding::Baselib_Thread_GetCurrentThreadId");

	private static readonly Baselib_TLS_AllocDelegate Baselib_TLS_AllocDelegateField = IL2CPP.ResolveICall<Baselib_TLS_AllocDelegate>("Unity.Baselib.LowLevel.Binding::Baselib_TLS_Alloc");

	private static readonly Baselib_TLS_FreeDelegate Baselib_TLS_FreeDelegateField = IL2CPP.ResolveICall<Baselib_TLS_FreeDelegate>("Unity.Baselib.LowLevel.Binding::Baselib_TLS_Free");

	private static readonly Baselib_TLS_SetDelegate Baselib_TLS_SetDelegateField = IL2CPP.ResolveICall<Baselib_TLS_SetDelegate>("Unity.Baselib.LowLevel.Binding::Baselib_TLS_Set");

	private static readonly Baselib_TLS_GetDelegate Baselib_TLS_GetDelegateField = IL2CPP.ResolveICall<Baselib_TLS_GetDelegate>("Unity.Baselib.LowLevel.Binding::Baselib_TLS_Get");

	private static readonly Baselib_Timer_GetHighPrecisionTimerTicksDelegate Baselib_Timer_GetHighPrecisionTimerTicksDelegateField = IL2CPP.ResolveICall<Baselib_Timer_GetHighPrecisionTimerTicksDelegate>("Unity.Baselib.LowLevel.Binding::Baselib_Timer_GetHighPrecisionTimerTicks");

	private static readonly Baselib_Timer_WaitForAtLeastDelegate Baselib_Timer_WaitForAtLeastDelegateField = IL2CPP.ResolveICall<Baselib_Timer_WaitForAtLeastDelegate>("Unity.Baselib.LowLevel.Binding::Baselib_Timer_WaitForAtLeast");

	private static readonly Baselib_Timer_GetTimeSinceStartupInSecondsDelegate Baselib_Timer_GetTimeSinceStartupInSecondsDelegateField = IL2CPP.ResolveICall<Baselib_Timer_GetTimeSinceStartupInSecondsDelegate>("Unity.Baselib.LowLevel.Binding::Baselib_Timer_GetTimeSinceStartupInSeconds");

	private static readonly Baselib_RegisteredNetwork_Endpoint_Empty_InjectedDelegate Baselib_RegisteredNetwork_Endpoint_Empty_InjectedDelegateField = IL2CPP.ResolveICall<Baselib_RegisteredNetwork_Endpoint_Empty_InjectedDelegate>("Unity.Baselib.LowLevel.Binding::Baselib_RegisteredNetwork_Endpoint_Empty_Injected");

	public static IntPtr Baselib_Memory_Allocate(UIntPtr size)
	{
		return Baselib_Memory_AllocateDelegateField(size);
	}

	public static IntPtr Baselib_Memory_Reallocate(IntPtr ptr, UIntPtr newSize)
	{
		return Baselib_Memory_ReallocateDelegateField(ptr, newSize);
	}

	public static void Baselib_Memory_Free(IntPtr ptr)
	{
		Baselib_Memory_FreeDelegateField(ptr);
	}

	public static IntPtr Baselib_Memory_AlignedAllocate(UIntPtr size, UIntPtr alignment)
	{
		return Baselib_Memory_AlignedAllocateDelegateField(size, alignment);
	}

	public static IntPtr Baselib_Memory_AlignedReallocate(IntPtr ptr, UIntPtr newSize, UIntPtr alignment)
	{
		return Baselib_Memory_AlignedReallocateDelegateField(ptr, newSize, alignment);
	}

	public static void Baselib_Memory_AlignedFree(IntPtr ptr)
	{
		Baselib_Memory_AlignedFreeDelegateField(ptr);
	}

	public static bool Baselib_RegisteredNetwork_IsEmulated()
	{
		return Baselib_RegisteredNetwork_IsEmulatedDelegateField();
	}

	public static Baselib_RegisteredNetwork_Endpoint Baselib_RegisteredNetwork_Endpoint_Empty()
	{
		Baselib_RegisteredNetwork_Endpoint_Empty_Injected(out var ret);
		return ret;
	}

	public static bool Baselib_SystemFutex_NativeSupport()
	{
		return Baselib_SystemFutex_NativeSupportDelegateField();
	}

	public static void Baselib_SystemFutex_Wait(IntPtr address, int expected, uint timeoutInMilliseconds)
	{
		Baselib_SystemFutex_WaitDelegateField(address, expected, timeoutInMilliseconds);
	}

	public static void Baselib_SystemFutex_Notify(IntPtr address, uint count, Baselib_WakeupFallbackStrategy wakeupFallbackStrategy)
	{
		Baselib_SystemFutex_NotifyDelegateField(address, count, wakeupFallbackStrategy);
	}

	public static void Baselib_Thread_YieldExecution()
	{
		Baselib_Thread_YieldExecutionDelegateField();
	}

	public static IntPtr Baselib_Thread_GetCurrentThreadId()
	{
		return Baselib_Thread_GetCurrentThreadIdDelegateField();
	}

	public static UIntPtr Baselib_TLS_Alloc()
	{
		return Baselib_TLS_AllocDelegateField();
	}

	public static void Baselib_TLS_Free(UIntPtr handle)
	{
		Baselib_TLS_FreeDelegateField(handle);
	}

	public static void Baselib_TLS_Set(UIntPtr handle, UIntPtr value)
	{
		Baselib_TLS_SetDelegateField(handle, value);
	}

	public static UIntPtr Baselib_TLS_Get(UIntPtr handle)
	{
		return Baselib_TLS_GetDelegateField(handle);
	}

	public static ulong Baselib_Timer_GetHighPrecisionTimerTicks()
	{
		return Baselib_Timer_GetHighPrecisionTimerTicksDelegateField();
	}

	public static void Baselib_Timer_WaitForAtLeast(uint timeInMilliseconds)
	{
		Baselib_Timer_WaitForAtLeastDelegateField(timeInMilliseconds);
	}

	public static double Baselib_Timer_GetTimeSinceStartupInSeconds()
	{
		return Baselib_Timer_GetTimeSinceStartupInSecondsDelegateField();
	}

	public unsafe static void Baselib_RegisteredNetwork_Endpoint_Empty_Injected(out Baselib_RegisteredNetwork_Endpoint ret)
	{
		Baselib_RegisteredNetwork_Endpoint_Empty_InjectedDelegateField((nint)Unsafe.AsPointer(ref ret));
	}
}
