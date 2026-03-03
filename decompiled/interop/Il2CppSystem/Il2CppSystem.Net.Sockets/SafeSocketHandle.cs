using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppMicrosoft.Win32.SafeHandles;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Diagnostics;
using Il2CppSystem.Threading;

namespace Il2CppSystem.Net.Sockets;

public sealed class SafeSocketHandle : SafeHandleMinusOneIsInvalid
{
	private static readonly System.IntPtr NativeFieldInfoPtr_blocking_threads;

	private static readonly System.IntPtr NativeFieldInfoPtr_threads_stacktraces;

	private static readonly System.IntPtr NativeFieldInfoPtr_in_cleanup;

	private static readonly System.IntPtr NativeFieldInfoPtr_THROW_ON_ABORT_RETRIES;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_IntPtr_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ReleaseHandle_Protected_Virtual_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RegisterForBlockingSyscall_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UnRegisterForBlockingSyscall_Public_Void_0;

	public unsafe List<Thread> blocking_threads
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_blocking_threads);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<Thread>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_blocking_threads)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe Dictionary<Thread, StackTrace> threads_stacktraces
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_threads_stacktraces);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<Thread, StackTrace>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_threads_stacktraces)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe bool in_cleanup
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_in_cleanup);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_in_cleanup)) = value;
		}
	}

	public unsafe static bool THROW_ON_ABORT_RETRIES
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_THROW_ON_ABORT_RETRIES, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_THROW_ON_ABORT_RETRIES, (void*)(&value));
		}
	}

	static SafeSocketHandle()
	{
		Il2CppClassPointerStore<SafeSocketHandle>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net.Sockets", "SafeSocketHandle");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SafeSocketHandle>.NativeClassPtr);
		NativeFieldInfoPtr_blocking_threads = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SafeSocketHandle>.NativeClassPtr, "blocking_threads");
		NativeFieldInfoPtr_threads_stacktraces = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SafeSocketHandle>.NativeClassPtr, "threads_stacktraces");
		NativeFieldInfoPtr_in_cleanup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SafeSocketHandle>.NativeClassPtr, "in_cleanup");
		NativeFieldInfoPtr_THROW_ON_ABORT_RETRIES = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SafeSocketHandle>.NativeClassPtr, "THROW_ON_ABORT_RETRIES");
		NativeMethodInfoPtr__ctor_Public_Void_IntPtr_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SafeSocketHandle>.NativeClassPtr, 100667429);
		NativeMethodInfoPtr_ReleaseHandle_Protected_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SafeSocketHandle>.NativeClassPtr, 100667430);
		NativeMethodInfoPtr_RegisterForBlockingSyscall_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SafeSocketHandle>.NativeClassPtr, 100667431);
		NativeMethodInfoPtr_UnRegisterForBlockingSyscall_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SafeSocketHandle>.NativeClassPtr, 100667432);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 900048, RefRangeEnd = 900050, XrefRangeStart = 900036, XrefRangeEnd = 900048, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe SafeSocketHandle(System.IntPtr preexistingHandle, bool ownsHandle)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SafeSocketHandle>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&preexistingHandle);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &ownsHandle;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_IntPtr_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 900050, XrefRangeEnd = 900122, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override bool ReleaseHandle()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ReleaseHandle_Protected_Virtual_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 900137, RefRangeEnd = 900144, XrefRangeStart = 900122, XrefRangeEnd = 900137, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RegisterForBlockingSyscall()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RegisterForBlockingSyscall_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(14)]
	[CachedScanResults(RefRangeStart = 900164, RefRangeEnd = 900178, XrefRangeStart = 900144, XrefRangeEnd = 900164, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UnRegisterForBlockingSyscall()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UnRegisterForBlockingSyscall_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public SafeSocketHandle(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
