using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Threading;

public class ReaderWriterLockSlim : Object
{
	[StructLayout(LayoutKind.Explicit)]
	public struct TimeoutTracker
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_m_total;

		private static readonly System.IntPtr NativeFieldInfoPtr_m_start;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_RemainingMilliseconds_Public_get_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_IsExpired_Public_get_Boolean_0;

		[FieldOffset(0)]
		public int m_total;

		[FieldOffset(4)]
		public int m_start;

		public unsafe int RemainingMilliseconds
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 862071, XrefRangeEnd = 862072, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_RemainingMilliseconds_Public_get_Int32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
			}
		}

		public unsafe bool IsExpired
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 862072, XrefRangeEnd = 862073, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_IsExpired_Public_get_Boolean_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
			}
		}

		static TimeoutTracker()
		{
			Il2CppClassPointerStore<TimeoutTracker>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ReaderWriterLockSlim>.NativeClassPtr, "TimeoutTracker");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TimeoutTracker>.NativeClassPtr);
			NativeFieldInfoPtr_m_total = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeoutTracker>.NativeClassPtr, "m_total");
			NativeFieldInfoPtr_m_start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeoutTracker>.NativeClassPtr, "m_start");
			NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeoutTracker>.NativeClassPtr, 100663698);
			NativeMethodInfoPtr_get_RemainingMilliseconds_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeoutTracker>.NativeClassPtr, 100663699);
			NativeMethodInfoPtr_get_IsExpired_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeoutTracker>.NativeClassPtr, 100663700);
		}

		[CallerCount(0)]
		public unsafe TimeoutTracker(int millisecondsTimeout)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&millisecondsTimeout);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Int32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		public unsafe Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TimeoutTracker>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_fIsReentrant;

	private static readonly System.IntPtr NativeFieldInfoPtr_myLock;

	private static readonly System.IntPtr NativeFieldInfoPtr_numWriteWaiters;

	private static readonly System.IntPtr NativeFieldInfoPtr_numReadWaiters;

	private static readonly System.IntPtr NativeFieldInfoPtr_numWriteUpgradeWaiters;

	private static readonly System.IntPtr NativeFieldInfoPtr_numUpgradeWaiters;

	private static readonly System.IntPtr NativeFieldInfoPtr_fNoWaiters;

	private static readonly System.IntPtr NativeFieldInfoPtr_upgradeLockOwnerId;

	private static readonly System.IntPtr NativeFieldInfoPtr_writeLockOwnerId;

	private static readonly System.IntPtr NativeFieldInfoPtr_writeEvent;

	private static readonly System.IntPtr NativeFieldInfoPtr_readEvent;

	private static readonly System.IntPtr NativeFieldInfoPtr_upgradeEvent;

	private static readonly System.IntPtr NativeFieldInfoPtr_waitUpgradeEvent;

	private static readonly System.IntPtr NativeFieldInfoPtr_s_nextLockID;

	private static readonly System.IntPtr NativeFieldInfoPtr_lockID;

	private static readonly System.IntPtr NativeFieldInfoPtr_t_rwc;

	private static readonly System.IntPtr NativeFieldInfoPtr_fUpgradeThreadHoldingRead;

	private static readonly System.IntPtr NativeFieldInfoPtr_owners;

	private static readonly System.IntPtr NativeFieldInfoPtr_fDisposed;

	private static readonly System.IntPtr NativeMethodInfoPtr_InitializeThreadCounts_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_LockRecursionPolicy_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsRWEntryEmpty_Private_Static_Boolean_ReaderWriterCount_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsRwHashEntryChanged_Private_Boolean_ReaderWriterCount_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetThreadRWCount_Private_ReaderWriterCount_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_EnterReadLock_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TryEnterReadLock_Public_Boolean_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TryEnterReadLock_Private_Boolean_TimeoutTracker_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TryEnterReadLockCore_Private_Boolean_TimeoutTracker_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ExitReadLock_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LazyCreateEvent_Private_Void_byref_EventWaitHandle_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_WaitOnEvent_Private_Boolean_EventWaitHandle_byref_UInt32_TimeoutTracker_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ExitAndWakeUpAppropriateWaiters_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ExitAndWakeUpAppropriateWaitersPreferringWriters_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ExitAndWakeUpAppropriateReadWaiters_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetWritersWaiting_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ClearWritersWaiting_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetUpgraderWaiting_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ClearUpgraderWaiting_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetNumReaders_Private_UInt32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_EnterMyLock_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_EnterMyLockSpin_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ExitMyLock_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SpinWait_Private_Static_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Private_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_IsReadLockHeld_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_IsUpgradeableReadLockHeld_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_IsWriteLockHeld_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_RecursiveReadCount_Public_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_RecursiveUpgradeCount_Public_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_RecursiveWriteCount_Public_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_WaitingReadCount_Public_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_WaitingUpgradeCount_Public_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_WaitingWriteCount_Public_get_Int32_0;

	public unsafe bool fIsReentrant
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fIsReentrant);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fIsReentrant)) = value;
		}
	}

	public unsafe int myLock
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_myLock);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_myLock)) = value;
		}
	}

	public unsafe uint numWriteWaiters
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_numWriteWaiters);
			return *(uint*)num;
		}
		set
		{
			*(uint*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_numWriteWaiters)) = value;
		}
	}

	public unsafe uint numReadWaiters
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_numReadWaiters);
			return *(uint*)num;
		}
		set
		{
			*(uint*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_numReadWaiters)) = value;
		}
	}

	public unsafe uint numWriteUpgradeWaiters
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_numWriteUpgradeWaiters);
			return *(uint*)num;
		}
		set
		{
			*(uint*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_numWriteUpgradeWaiters)) = value;
		}
	}

	public unsafe uint numUpgradeWaiters
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_numUpgradeWaiters);
			return *(uint*)num;
		}
		set
		{
			*(uint*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_numUpgradeWaiters)) = value;
		}
	}

	public unsafe bool fNoWaiters
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fNoWaiters);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fNoWaiters)) = value;
		}
	}

	public unsafe int upgradeLockOwnerId
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_upgradeLockOwnerId);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_upgradeLockOwnerId)) = value;
		}
	}

	public unsafe int writeLockOwnerId
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_writeLockOwnerId);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_writeLockOwnerId)) = value;
		}
	}

	public unsafe EventWaitHandle writeEvent
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_writeEvent);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<EventWaitHandle>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_writeEvent)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe EventWaitHandle readEvent
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_readEvent);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<EventWaitHandle>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_readEvent)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe EventWaitHandle upgradeEvent
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_upgradeEvent);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<EventWaitHandle>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_upgradeEvent)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe EventWaitHandle waitUpgradeEvent
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_waitUpgradeEvent);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<EventWaitHandle>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_waitUpgradeEvent)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static long s_nextLockID
	{
		get
		{
			Unsafe.SkipInit(out long result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_nextLockID, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_nextLockID, (void*)(&value));
		}
	}

	public unsafe long lockID
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lockID);
			return *(long*)num;
		}
		set
		{
			*(long*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lockID)) = value;
		}
	}

	public unsafe static ReaderWriterCount t_rwc
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_t_rwc, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<ReaderWriterCount>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_t_rwc, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe bool fUpgradeThreadHoldingRead
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fUpgradeThreadHoldingRead);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fUpgradeThreadHoldingRead)) = value;
		}
	}

	public unsafe uint owners
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_owners);
			return *(uint*)num;
		}
		set
		{
			*(uint*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_owners)) = value;
		}
	}

	public unsafe bool fDisposed
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fDisposed);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fDisposed)) = value;
		}
	}

	public unsafe bool IsReadLockHeld
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 862214, XrefRangeEnd = 862218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_IsReadLockHeld_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe bool IsUpgradeableReadLockHeld
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 862218, XrefRangeEnd = 862220, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_IsUpgradeableReadLockHeld_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe bool IsWriteLockHeld
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 862220, XrefRangeEnd = 862222, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_IsWriteLockHeld_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe int RecursiveReadCount
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 862222, XrefRangeEnd = 862226, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_RecursiveReadCount_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe int RecursiveUpgradeCount
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 862226, XrefRangeEnd = 862228, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_RecursiveUpgradeCount_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe int RecursiveWriteCount
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 862228, XrefRangeEnd = 862230, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_RecursiveWriteCount_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe int WaitingReadCount
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_WaitingReadCount_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe int WaitingUpgradeCount
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_WaitingUpgradeCount_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe int WaitingWriteCount
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 54510, RefRangeEnd = 54511, XrefRangeStart = 54510, XrefRangeEnd = 54511, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_WaitingWriteCount_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	static ReaderWriterLockSlim()
	{
		Il2CppClassPointerStore<ReaderWriterLockSlim>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Core.dll", "System.Threading", "ReaderWriterLockSlim");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ReaderWriterLockSlim>.NativeClassPtr);
		NativeFieldInfoPtr_fIsReentrant = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReaderWriterLockSlim>.NativeClassPtr, "fIsReentrant");
		NativeFieldInfoPtr_myLock = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReaderWriterLockSlim>.NativeClassPtr, "myLock");
		NativeFieldInfoPtr_numWriteWaiters = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReaderWriterLockSlim>.NativeClassPtr, "numWriteWaiters");
		NativeFieldInfoPtr_numReadWaiters = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReaderWriterLockSlim>.NativeClassPtr, "numReadWaiters");
		NativeFieldInfoPtr_numWriteUpgradeWaiters = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReaderWriterLockSlim>.NativeClassPtr, "numWriteUpgradeWaiters");
		NativeFieldInfoPtr_numUpgradeWaiters = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReaderWriterLockSlim>.NativeClassPtr, "numUpgradeWaiters");
		NativeFieldInfoPtr_fNoWaiters = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReaderWriterLockSlim>.NativeClassPtr, "fNoWaiters");
		NativeFieldInfoPtr_upgradeLockOwnerId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReaderWriterLockSlim>.NativeClassPtr, "upgradeLockOwnerId");
		NativeFieldInfoPtr_writeLockOwnerId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReaderWriterLockSlim>.NativeClassPtr, "writeLockOwnerId");
		NativeFieldInfoPtr_writeEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReaderWriterLockSlim>.NativeClassPtr, "writeEvent");
		NativeFieldInfoPtr_readEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReaderWriterLockSlim>.NativeClassPtr, "readEvent");
		NativeFieldInfoPtr_upgradeEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReaderWriterLockSlim>.NativeClassPtr, "upgradeEvent");
		NativeFieldInfoPtr_waitUpgradeEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReaderWriterLockSlim>.NativeClassPtr, "waitUpgradeEvent");
		NativeFieldInfoPtr_s_nextLockID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReaderWriterLockSlim>.NativeClassPtr, "s_nextLockID");
		NativeFieldInfoPtr_lockID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReaderWriterLockSlim>.NativeClassPtr, "lockID");
		NativeFieldInfoPtr_t_rwc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReaderWriterLockSlim>.NativeClassPtr, "t_rwc");
		NativeFieldInfoPtr_fUpgradeThreadHoldingRead = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReaderWriterLockSlim>.NativeClassPtr, "fUpgradeThreadHoldingRead");
		NativeFieldInfoPtr_owners = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReaderWriterLockSlim>.NativeClassPtr, "owners");
		NativeFieldInfoPtr_fDisposed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReaderWriterLockSlim>.NativeClassPtr, "fDisposed");
		NativeMethodInfoPtr_InitializeThreadCounts_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReaderWriterLockSlim>.NativeClassPtr, 100663662);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReaderWriterLockSlim>.NativeClassPtr, 100663663);
		NativeMethodInfoPtr__ctor_Public_Void_LockRecursionPolicy_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReaderWriterLockSlim>.NativeClassPtr, 100663664);
		NativeMethodInfoPtr_IsRWEntryEmpty_Private_Static_Boolean_ReaderWriterCount_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReaderWriterLockSlim>.NativeClassPtr, 100663665);
		NativeMethodInfoPtr_IsRwHashEntryChanged_Private_Boolean_ReaderWriterCount_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReaderWriterLockSlim>.NativeClassPtr, 100663666);
		NativeMethodInfoPtr_GetThreadRWCount_Private_ReaderWriterCount_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReaderWriterLockSlim>.NativeClassPtr, 100663667);
		NativeMethodInfoPtr_EnterReadLock_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReaderWriterLockSlim>.NativeClassPtr, 100663668);
		NativeMethodInfoPtr_TryEnterReadLock_Public_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReaderWriterLockSlim>.NativeClassPtr, 100663669);
		NativeMethodInfoPtr_TryEnterReadLock_Private_Boolean_TimeoutTracker_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReaderWriterLockSlim>.NativeClassPtr, 100663670);
		NativeMethodInfoPtr_TryEnterReadLockCore_Private_Boolean_TimeoutTracker_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReaderWriterLockSlim>.NativeClassPtr, 100663671);
		NativeMethodInfoPtr_ExitReadLock_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReaderWriterLockSlim>.NativeClassPtr, 100663672);
		NativeMethodInfoPtr_LazyCreateEvent_Private_Void_byref_EventWaitHandle_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReaderWriterLockSlim>.NativeClassPtr, 100663673);
		NativeMethodInfoPtr_WaitOnEvent_Private_Boolean_EventWaitHandle_byref_UInt32_TimeoutTracker_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReaderWriterLockSlim>.NativeClassPtr, 100663674);
		NativeMethodInfoPtr_ExitAndWakeUpAppropriateWaiters_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReaderWriterLockSlim>.NativeClassPtr, 100663675);
		NativeMethodInfoPtr_ExitAndWakeUpAppropriateWaitersPreferringWriters_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReaderWriterLockSlim>.NativeClassPtr, 100663676);
		NativeMethodInfoPtr_ExitAndWakeUpAppropriateReadWaiters_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReaderWriterLockSlim>.NativeClassPtr, 100663677);
		NativeMethodInfoPtr_SetWritersWaiting_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReaderWriterLockSlim>.NativeClassPtr, 100663678);
		NativeMethodInfoPtr_ClearWritersWaiting_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReaderWriterLockSlim>.NativeClassPtr, 100663679);
		NativeMethodInfoPtr_SetUpgraderWaiting_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReaderWriterLockSlim>.NativeClassPtr, 100663680);
		NativeMethodInfoPtr_ClearUpgraderWaiting_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReaderWriterLockSlim>.NativeClassPtr, 100663681);
		NativeMethodInfoPtr_GetNumReaders_Private_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReaderWriterLockSlim>.NativeClassPtr, 100663682);
		NativeMethodInfoPtr_EnterMyLock_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReaderWriterLockSlim>.NativeClassPtr, 100663683);
		NativeMethodInfoPtr_EnterMyLockSpin_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReaderWriterLockSlim>.NativeClassPtr, 100663684);
		NativeMethodInfoPtr_ExitMyLock_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReaderWriterLockSlim>.NativeClassPtr, 100663685);
		NativeMethodInfoPtr_SpinWait_Private_Static_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReaderWriterLockSlim>.NativeClassPtr, 100663686);
		NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReaderWriterLockSlim>.NativeClassPtr, 100663687);
		NativeMethodInfoPtr_Dispose_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReaderWriterLockSlim>.NativeClassPtr, 100663688);
		NativeMethodInfoPtr_get_IsReadLockHeld_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReaderWriterLockSlim>.NativeClassPtr, 100663689);
		NativeMethodInfoPtr_get_IsUpgradeableReadLockHeld_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReaderWriterLockSlim>.NativeClassPtr, 100663690);
		NativeMethodInfoPtr_get_IsWriteLockHeld_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReaderWriterLockSlim>.NativeClassPtr, 100663691);
		NativeMethodInfoPtr_get_RecursiveReadCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReaderWriterLockSlim>.NativeClassPtr, 100663692);
		NativeMethodInfoPtr_get_RecursiveUpgradeCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReaderWriterLockSlim>.NativeClassPtr, 100663693);
		NativeMethodInfoPtr_get_RecursiveWriteCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReaderWriterLockSlim>.NativeClassPtr, 100663694);
		NativeMethodInfoPtr_get_WaitingReadCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReaderWriterLockSlim>.NativeClassPtr, 100663695);
		NativeMethodInfoPtr_get_WaitingUpgradeCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReaderWriterLockSlim>.NativeClassPtr, 100663696);
		NativeMethodInfoPtr_get_WaitingWriteCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReaderWriterLockSlim>.NativeClassPtr, 100663697);
	}

	[CallerCount(0)]
	public unsafe void InitializeThreadCounts()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InitializeThreadCounts_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 862073, XrefRangeEnd = 862077, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ReaderWriterLockSlim()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ReaderWriterLockSlim>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 862077, XrefRangeEnd = 862081, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ReaderWriterLockSlim(LockRecursionPolicy recursionPolicy)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ReaderWriterLockSlim>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&recursionPolicy);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_LockRecursionPolicy_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	public unsafe static bool IsRWEntryEmpty(ReaderWriterCount rwc)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)rwc);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsRWEntryEmpty_Private_Static_Boolean_ReaderWriterCount_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe bool IsRwHashEntryChanged(ReaderWriterCount lrwc)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)lrwc);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsRwHashEntryChanged_Private_Boolean_ReaderWriterCount_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 862081, XrefRangeEnd = 862096, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ReaderWriterCount GetThreadRWCount(bool dontAllocate)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&dontAllocate);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetThreadRWCount_Private_ReaderWriterCount_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<ReaderWriterCount>(intPtr2) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 862097, RefRangeEnd = 862098, XrefRangeStart = 862096, XrefRangeEnd = 862097, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void EnterReadLock()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_EnterReadLock_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 862098, XrefRangeEnd = 862107, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool TryEnterReadLock(int millisecondsTimeout)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&millisecondsTimeout);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TryEnterReadLock_Public_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 862107, XrefRangeEnd = 862108, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool TryEnterReadLock(TimeoutTracker timeout)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&timeout);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TryEnterReadLock_Private_Boolean_TimeoutTracker_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 862114, RefRangeEnd = 862117, XrefRangeStart = 862108, XrefRangeEnd = 862114, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool TryEnterReadLockCore(TimeoutTracker timeout)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&timeout);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TryEnterReadLockCore_Private_Boolean_TimeoutTracker_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 862129, RefRangeEnd = 862130, XrefRangeStart = 862117, XrefRangeEnd = 862129, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ExitReadLock()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ExitReadLock_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 862130, XrefRangeEnd = 862144, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void LazyCreateEvent(ref EventWaitHandle waitEvent, bool makeAutoResetEvent)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)waitEvent);
		*ptr = (nint)(&intPtr);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &makeAutoResetEvent;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LazyCreateEvent_Private_Void_byref_EventWaitHandle_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		System.IntPtr intPtr4 = intPtr;
		waitEvent = ((intPtr4 == (System.IntPtr)0) ? null : new EventWaitHandle(intPtr4));
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 862144, XrefRangeEnd = 862151, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool WaitOnEvent(EventWaitHandle waitEvent, ref uint numWaiters, TimeoutTracker timeout, bool isWriteWaiter)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)waitEvent);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref numWaiters);
		*(TimeoutTracker**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &timeout;
		*(bool**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &isWriteWaiter;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_WaitOnEvent_Private_Boolean_EventWaitHandle_byref_UInt32_TimeoutTracker_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 862151, XrefRangeEnd = 862157, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ExitAndWakeUpAppropriateWaiters()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ExitAndWakeUpAppropriateWaiters_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 862157, XrefRangeEnd = 862163, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ExitAndWakeUpAppropriateWaitersPreferringWriters()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ExitAndWakeUpAppropriateWaitersPreferringWriters_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 862166, RefRangeEnd = 862168, XrefRangeStart = 862163, XrefRangeEnd = 862166, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ExitAndWakeUpAppropriateReadWaiters()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ExitAndWakeUpAppropriateReadWaiters_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	public unsafe void SetWritersWaiting()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetWritersWaiting_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	public unsafe void ClearWritersWaiting()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ClearWritersWaiting_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	public unsafe void SetUpgraderWaiting()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetUpgraderWaiting_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	public unsafe void ClearUpgraderWaiting()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ClearUpgraderWaiting_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	public unsafe uint GetNumReaders()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetNumReaders_Private_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(uint*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 862168, XrefRangeEnd = 862170, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void EnterMyLock()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_EnterMyLock_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 862180, RefRangeEnd = 862185, XrefRangeStart = 862170, XrefRangeEnd = 862180, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void EnterMyLockSpin()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_EnterMyLockSpin_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 862185, XrefRangeEnd = 862186, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ExitMyLock()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ExitMyLock_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 862186, XrefRangeEnd = 862193, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SpinWait(int SpinCount)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&SpinCount);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SpinWait_Private_Static_Void_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 862193, XrefRangeEnd = 862194, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void Dispose()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 862213, RefRangeEnd = 862214, XrefRangeStart = 862194, XrefRangeEnd = 862213, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Dispose(bool disposing)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&disposing);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Dispose_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public ReaderWriterLockSlim(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
