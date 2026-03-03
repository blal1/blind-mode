using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Threading;

[StructLayout(LayoutKind.Explicit)]
public struct SpinLock
{
	public class SystemThreading_SpinLockDebugView : Object
	{
		static SystemThreading_SpinLockDebugView()
		{
			Il2CppClassPointerStore<SystemThreading_SpinLockDebugView>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SpinLock>.NativeClassPtr, "SystemThreading_SpinLockDebugView");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SystemThreading_SpinLockDebugView>.NativeClassPtr);
		}

		public SystemThreading_SpinLockDebugView(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_m_owner;

	private static readonly System.IntPtr NativeFieldInfoPtr_MAXIMUM_WAITERS;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Enter_Public_Void_byref_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TryEnter_Public_Void_Int32_byref_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ContinueTryEnter_Private_Void_Int32_byref_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DecrementWaiters_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ContinueTryEnterWithThreadTracking_Private_Void_Int32_UInt32_byref_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Exit_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Exit_Public_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ExitSlowPath_Private_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_IsHeldByCurrentThread_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_IsThreadOwnerTrackingEnabled_Public_get_Boolean_0;

	[FieldOffset(0)]
	public int m_owner;

	public unsafe static int MAXIMUM_WAITERS
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_MAXIMUM_WAITERS, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_MAXIMUM_WAITERS, (void*)(&value));
		}
	}

	public unsafe bool IsHeldByCurrentThread
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 768383, RefRangeEnd = 768384, XrefRangeStart = 768373, XrefRangeEnd = 768383, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_IsHeldByCurrentThread_Public_get_Boolean_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe bool IsThreadOwnerTrackingEnabled
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 768384, XrefRangeEnd = 768385, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_IsThreadOwnerTrackingEnabled_Public_get_Boolean_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	static SpinLock()
	{
		Il2CppClassPointerStore<SpinLock>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Threading", "SpinLock");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpinLock>.NativeClassPtr);
		NativeFieldInfoPtr_m_owner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpinLock>.NativeClassPtr, "m_owner");
		NativeFieldInfoPtr_MAXIMUM_WAITERS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpinLock>.NativeClassPtr, "MAXIMUM_WAITERS");
		NativeMethodInfoPtr__ctor_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpinLock>.NativeClassPtr, 100667722);
		NativeMethodInfoPtr_Enter_Public_Void_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpinLock>.NativeClassPtr, 100667723);
		NativeMethodInfoPtr_TryEnter_Public_Void_Int32_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpinLock>.NativeClassPtr, 100667724);
		NativeMethodInfoPtr_ContinueTryEnter_Private_Void_Int32_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpinLock>.NativeClassPtr, 100667725);
		NativeMethodInfoPtr_DecrementWaiters_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpinLock>.NativeClassPtr, 100667726);
		NativeMethodInfoPtr_ContinueTryEnterWithThreadTracking_Private_Void_Int32_UInt32_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpinLock>.NativeClassPtr, 100667727);
		NativeMethodInfoPtr_Exit_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpinLock>.NativeClassPtr, 100667728);
		NativeMethodInfoPtr_Exit_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpinLock>.NativeClassPtr, 100667729);
		NativeMethodInfoPtr_ExitSlowPath_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpinLock>.NativeClassPtr, 100667730);
		NativeMethodInfoPtr_get_IsHeldByCurrentThread_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpinLock>.NativeClassPtr, 100667731);
		NativeMethodInfoPtr_get_IsThreadOwnerTrackingEnabled_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpinLock>.NativeClassPtr, 100667732);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 768230, XrefRangeEnd = 768233, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe SpinLock(bool enableThreadOwnerTracking)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&enableThreadOwnerTracking);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Boolean_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 768241, RefRangeEnd = 768248, XrefRangeStart = 768233, XrefRangeEnd = 768241, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Enter(ref bool lockTaken)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)Unsafe.AsPointer(ref lockTaken);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Enter_Public_Void_byref_Boolean_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 768248, XrefRangeEnd = 768256, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void TryEnter(int millisecondsTimeout, ref bool lockTaken)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&millisecondsTimeout);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref lockTaken);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TryEnter_Public_Void_Int32_byref_Boolean_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 768302, RefRangeEnd = 768308, XrefRangeStart = 768256, XrefRangeEnd = 768302, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ContinueTryEnter(int millisecondsTimeout, ref bool lockTaken)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&millisecondsTimeout);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref lockTaken);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ContinueTryEnter_Private_Void_Int32_byref_Boolean_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 768319, RefRangeEnd = 768320, XrefRangeStart = 768308, XrefRangeEnd = 768319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void DecrementWaiters()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DecrementWaiters_Private_Void_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 768320, XrefRangeEnd = 768346, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ContinueTryEnterWithThreadTracking(int millisecondsTimeout, uint startTime, ref bool lockTaken)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&millisecondsTimeout);
		*(uint**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &startTime;
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref lockTaken);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ContinueTryEnterWithThreadTracking_Private_Void_Int32_UInt32_byref_Boolean_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 768346, XrefRangeEnd = 768355, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Exit()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Exit_Public_Void_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 768355, XrefRangeEnd = 768364, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Exit(bool useMemoryBarrier)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&useMemoryBarrier);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Exit_Public_Void_Boolean_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 768371, RefRangeEnd = 768373, XrefRangeStart = 768364, XrefRangeEnd = 768371, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ExitSlowPath(bool useMemoryBarrier)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&useMemoryBarrier);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ExitSlowPath_Private_Void_Boolean_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public unsafe Object BoxIl2CppObject()
	{
		return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SpinLock>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}
}
