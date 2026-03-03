using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace Il2CppSystem.Threading;

public static class Monitor : Object
{
	private static readonly System.IntPtr NativeMethodInfoPtr_Enter_Public_Static_Void_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Enter_Public_Static_Void_Object_byref_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ThrowLockTakenException_Private_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Exit_Public_Static_Void_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TryEnter_Public_Static_Void_Object_byref_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Wait_Public_Static_Boolean_Object_Int32_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Wait_Public_Static_Boolean_Object_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Pulse_Public_Static_Void_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PulseAll_Public_Static_Void_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Monitor_test_synchronised_Private_Static_Boolean_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Monitor_pulse_Private_Static_Void_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ObjPulse_Private_Static_Void_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Monitor_pulse_all_Private_Static_Void_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ObjPulseAll_Private_Static_Void_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Monitor_wait_Private_Static_Boolean_Object_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ObjWait_Private_Static_Boolean_Boolean_Int32_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_try_enter_with_atomic_var_Private_Static_Void_Object_Int32_byref_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ReliableEnterTimeout_Private_Static_Void_Object_Int32_byref_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ReliableEnter_Private_Static_Void_Object_byref_Boolean_0;

	static Monitor()
	{
		Il2CppClassPointerStore<Monitor>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Threading", "Monitor");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Monitor>.NativeClassPtr);
		NativeMethodInfoPtr_Enter_Public_Static_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Monitor>.NativeClassPtr, 100667807);
		NativeMethodInfoPtr_Enter_Public_Static_Void_Object_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Monitor>.NativeClassPtr, 100667808);
		NativeMethodInfoPtr_ThrowLockTakenException_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Monitor>.NativeClassPtr, 100667809);
		NativeMethodInfoPtr_Exit_Public_Static_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Monitor>.NativeClassPtr, 100667810);
		NativeMethodInfoPtr_TryEnter_Public_Static_Void_Object_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Monitor>.NativeClassPtr, 100667811);
		NativeMethodInfoPtr_Wait_Public_Static_Boolean_Object_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Monitor>.NativeClassPtr, 100667812);
		NativeMethodInfoPtr_Wait_Public_Static_Boolean_Object_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Monitor>.NativeClassPtr, 100667813);
		NativeMethodInfoPtr_Pulse_Public_Static_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Monitor>.NativeClassPtr, 100667814);
		NativeMethodInfoPtr_PulseAll_Public_Static_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Monitor>.NativeClassPtr, 100667815);
		NativeMethodInfoPtr_Monitor_test_synchronised_Private_Static_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Monitor>.NativeClassPtr, 100667816);
		NativeMethodInfoPtr_Monitor_pulse_Private_Static_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Monitor>.NativeClassPtr, 100667817);
		NativeMethodInfoPtr_ObjPulse_Private_Static_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Monitor>.NativeClassPtr, 100667818);
		NativeMethodInfoPtr_Monitor_pulse_all_Private_Static_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Monitor>.NativeClassPtr, 100667819);
		NativeMethodInfoPtr_ObjPulseAll_Private_Static_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Monitor>.NativeClassPtr, 100667820);
		NativeMethodInfoPtr_Monitor_wait_Private_Static_Boolean_Object_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Monitor>.NativeClassPtr, 100667821);
		NativeMethodInfoPtr_ObjWait_Private_Static_Boolean_Boolean_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Monitor>.NativeClassPtr, 100667822);
		NativeMethodInfoPtr_try_enter_with_atomic_var_Private_Static_Void_Object_Int32_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Monitor>.NativeClassPtr, 100667823);
		NativeMethodInfoPtr_ReliableEnterTimeout_Private_Static_Void_Object_Int32_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Monitor>.NativeClassPtr, 100667824);
		NativeMethodInfoPtr_ReliableEnter_Private_Static_Void_Object_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Monitor>.NativeClassPtr, 100667825);
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 769027, RefRangeEnd = 769033, XrefRangeStart = 769026, XrefRangeEnd = 769027, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Enter(Object obj)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)obj);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Enter_Public_Static_Void_Object_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(358)]
	[CachedScanResults(RefRangeStart = 769041, RefRangeEnd = 769399, XrefRangeStart = 769033, XrefRangeEnd = 769041, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Enter(Object obj, ref bool lockTaken)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)obj);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref lockTaken);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Enter_Public_Static_Void_Object_byref_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 769407, RefRangeEnd = 769409, XrefRangeStart = 769399, XrefRangeEnd = 769407, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ThrowLockTakenException()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ThrowLockTakenException_Private_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(847)]
	[CachedScanResults(RefRangeStart = 769410, RefRangeEnd = 770257, XrefRangeStart = 769409, XrefRangeEnd = 769410, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Exit(Object obj)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)obj);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Exit_Public_Static_Void_Object_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 770265, RefRangeEnd = 770268, XrefRangeStart = 770257, XrefRangeEnd = 770265, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void TryEnter(Object obj, ref bool lockTaken)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)obj);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref lockTaken);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TryEnter_Public_Static_Void_Object_byref_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 770288, RefRangeEnd = 770292, XrefRangeStart = 770268, XrefRangeEnd = 770288, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool Wait(Object obj, int millisecondsTimeout, bool exitContext)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)obj);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &millisecondsTimeout;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &exitContext;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Wait_Public_Static_Boolean_Object_Int32_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 770288, RefRangeEnd = 770292, XrefRangeStart = 770288, XrefRangeEnd = 770292, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool Wait(Object obj, int millisecondsTimeout)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)obj);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &millisecondsTimeout;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Wait_Public_Static_Boolean_Object_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 770306, RefRangeEnd = 770307, XrefRangeStart = 770292, XrefRangeEnd = 770306, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Pulse(Object obj)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)obj);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Pulse_Public_Static_Void_Object_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 770321, RefRangeEnd = 770324, XrefRangeStart = 770307, XrefRangeEnd = 770321, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void PulseAll(Object obj)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)obj);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PulseAll_Public_Static_Void_Object_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 770324, XrefRangeEnd = 770325, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool Monitor_test_synchronised(Object obj)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)obj);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Monitor_test_synchronised_Private_Static_Boolean_Object_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 770325, XrefRangeEnd = 770326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Monitor_pulse(Object obj)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)obj);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Monitor_pulse_Private_Static_Void_Object_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 770326, XrefRangeEnd = 770334, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ObjPulse(Object obj)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)obj);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ObjPulse_Private_Static_Void_Object_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 770334, XrefRangeEnd = 770335, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Monitor_pulse_all(Object obj)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)obj);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Monitor_pulse_all_Private_Static_Void_Object_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 770335, XrefRangeEnd = 770343, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ObjPulseAll(Object obj)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)obj);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ObjPulseAll_Private_Static_Void_Object_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 770343, XrefRangeEnd = 770344, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool Monitor_wait(Object obj, int ms)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)obj);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &ms;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Monitor_wait_Private_Static_Boolean_Object_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 770344, XrefRangeEnd = 770358, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool ObjWait(bool exitContext, int millisecondsTimeout, Object obj)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&exitContext);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &millisecondsTimeout;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)obj);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ObjWait_Private_Static_Boolean_Boolean_Int32_Object_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 770358, XrefRangeEnd = 770359, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void try_enter_with_atomic_var(Object obj, int millisecondsTimeout, ref bool lockTaken)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)obj);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &millisecondsTimeout;
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref lockTaken);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_try_enter_with_atomic_var_Private_Static_Void_Object_Int32_byref_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 770359, XrefRangeEnd = 770372, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ReliableEnterTimeout(Object obj, int timeout, ref bool lockTaken)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)obj);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &timeout;
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref lockTaken);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ReliableEnterTimeout_Private_Static_Void_Object_Int32_byref_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 770372, XrefRangeEnd = 770379, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ReliableEnter(Object obj, ref bool lockTaken)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)obj);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref lockTaken);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ReliableEnter_Private_Static_Void_Object_byref_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public Monitor(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
