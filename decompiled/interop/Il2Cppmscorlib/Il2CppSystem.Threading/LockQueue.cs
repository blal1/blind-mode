using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Threading;

public class LockQueue : Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_rwlock;

	private static readonly System.IntPtr NativeFieldInfoPtr_lockCount;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_ReaderWriterLock_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Wait_Public_Boolean_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_IsEmpty_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Pulse_Public_Void_0;

	public unsafe ReaderWriterLock rwlock
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rwlock);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ReaderWriterLock>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rwlock)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe int lockCount
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lockCount);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lockCount)) = value;
		}
	}

	public unsafe bool IsEmpty
	{
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 772199, RefRangeEnd = 772202, XrefRangeStart = 772195, XrefRangeEnd = 772199, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_IsEmpty_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	static LockQueue()
	{
		Il2CppClassPointerStore<LockQueue>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Threading", "LockQueue");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LockQueue>.NativeClassPtr);
		NativeFieldInfoPtr_rwlock = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LockQueue>.NativeClassPtr, "rwlock");
		NativeFieldInfoPtr_lockCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LockQueue>.NativeClassPtr, "lockCount");
		NativeMethodInfoPtr__ctor_Public_Void_ReaderWriterLock_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LockQueue>.NativeClassPtr, 100668038);
		NativeMethodInfoPtr_Wait_Public_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LockQueue>.NativeClassPtr, 100668039);
		NativeMethodInfoPtr_get_IsEmpty_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LockQueue>.NativeClassPtr, 100668040);
		NativeMethodInfoPtr_Pulse_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LockQueue>.NativeClassPtr, 100668041);
	}

	[CallerCount(215)]
	[CachedScanResults(RefRangeStart = 79185, RefRangeEnd = 79400, XrefRangeStart = 79185, XrefRangeEnd = 79400, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe LockQueue(ReaderWriterLock rwlock)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LockQueue>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)rwlock);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_ReaderWriterLock_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 772194, RefRangeEnd = 772195, XrefRangeStart = 772186, XrefRangeEnd = 772194, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool Wait(int timeout)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&timeout);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Wait_Public_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 772208, RefRangeEnd = 772210, XrefRangeStart = 772202, XrefRangeEnd = 772208, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Pulse()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Pulse_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public LockQueue(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
