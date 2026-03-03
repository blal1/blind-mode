using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppMicrosoft.Win32.SafeHandles;
using Il2CppSystem.Runtime.InteropServices;

namespace Il2CppSystem.Threading;

public class WaitHandle : MarshalByRefObject
{
	private static readonly System.IntPtr NativeFieldInfoPtr_WaitTimeout;

	private static readonly System.IntPtr NativeFieldInfoPtr_MAX_WAITHANDLES;

	private static readonly System.IntPtr NativeFieldInfoPtr_waitHandle;

	private static readonly System.IntPtr NativeFieldInfoPtr_safeWaitHandle;

	private static readonly System.IntPtr NativeFieldInfoPtr_hasThreadAffinity;

	private static readonly System.IntPtr NativeFieldInfoPtr_WAIT_OBJECT_0;

	private static readonly System.IntPtr NativeFieldInfoPtr_WAIT_ABANDONED;

	private static readonly System.IntPtr NativeFieldInfoPtr_WAIT_FAILED;

	private static readonly System.IntPtr NativeFieldInfoPtr_ERROR_TOO_MANY_POSTS;

	private static readonly System.IntPtr NativeFieldInfoPtr_ERROR_NOT_OWNED_BY_CALLER;

	private static readonly System.IntPtr NativeFieldInfoPtr_InvalidHandle;

	private static readonly System.IntPtr NativeFieldInfoPtr_MaxWaitHandles;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Init_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_Handle_Public_Virtual_New_set_Void_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_SafeWaitHandle_Public_get_SafeWaitHandle_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetHandleInternal_Internal_Void_SafeWaitHandle_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_WaitOne_Public_Virtual_New_Boolean_Int32_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_WaitOne_Public_Virtual_New_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_WaitOne_Public_Virtual_New_Boolean_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_WaitOne_Private_Boolean_Int64_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InternalWaitOne_Internal_Static_Boolean_SafeHandle_Int64_Boolean_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_WaitAny_Public_Static_Int32_Il2CppReferenceArray_1_WaitHandle_Int32_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_WaitAny_Public_Static_Int32_Il2CppReferenceArray_1_WaitHandle_TimeSpan_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ThrowAbandonedMutexException_Private_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ThrowAbandonedMutexException_Private_Static_Void_Int32_WaitHandle_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Close_Public_Virtual_New_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Protected_Virtual_New_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_WaitOneNative_Private_Static_Int32_SafeHandle_UInt32_Boolean_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_WaitMultiple_Private_Static_Int32_Il2CppReferenceArray_1_WaitHandle_Int32_Boolean_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Wait_internal_Internal_Static_Int32_ptr_IntPtr_Int32_Boolean_Int32_0;

	public unsafe static int WaitTimeout
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_WaitTimeout, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_WaitTimeout, (void*)(&value));
		}
	}

	public unsafe static int MAX_WAITHANDLES
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_MAX_WAITHANDLES, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_MAX_WAITHANDLES, (void*)(&value));
		}
	}

	public unsafe System.IntPtr waitHandle
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_waitHandle);
			return *(System.IntPtr*)num;
		}
		set
		{
			*(System.IntPtr*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_waitHandle)) = value;
		}
	}

	public unsafe SafeWaitHandle safeWaitHandle
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_safeWaitHandle);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<SafeWaitHandle>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_safeWaitHandle)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe bool hasThreadAffinity
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hasThreadAffinity);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hasThreadAffinity)) = value;
		}
	}

	public unsafe static int WAIT_OBJECT_0
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_WAIT_OBJECT_0, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_WAIT_OBJECT_0, (void*)(&value));
		}
	}

	public unsafe static int WAIT_ABANDONED
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_WAIT_ABANDONED, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_WAIT_ABANDONED, (void*)(&value));
		}
	}

	public unsafe static int WAIT_FAILED
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_WAIT_FAILED, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_WAIT_FAILED, (void*)(&value));
		}
	}

	public unsafe static int ERROR_TOO_MANY_POSTS
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ERROR_TOO_MANY_POSTS, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ERROR_TOO_MANY_POSTS, (void*)(&value));
		}
	}

	public unsafe static int ERROR_NOT_OWNED_BY_CALLER
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ERROR_NOT_OWNED_BY_CALLER, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ERROR_NOT_OWNED_BY_CALLER, (void*)(&value));
		}
	}

	public unsafe static System.IntPtr InvalidHandle
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_InvalidHandle, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_InvalidHandle, (void*)(&value));
		}
	}

	public unsafe static int MaxWaitHandles
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_MaxWaitHandles, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_MaxWaitHandles, (void*)(&value));
		}
	}

	public unsafe virtual System.IntPtr Handle
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 771842, XrefRangeEnd = 771852, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_set_Handle_Public_Virtual_New_set_Void_IntPtr_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe SafeWaitHandle SafeWaitHandle
	{
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 771864, RefRangeEnd = 771869, XrefRangeStart = 771852, XrefRangeEnd = 771864, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_SafeWaitHandle_Public_get_SafeWaitHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<SafeWaitHandle>(intPtr2) : null;
		}
	}

	static WaitHandle()
	{
		Il2CppClassPointerStore<WaitHandle>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Threading", "WaitHandle");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WaitHandle>.NativeClassPtr);
		NativeFieldInfoPtr_WaitTimeout = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WaitHandle>.NativeClassPtr, "WaitTimeout");
		NativeFieldInfoPtr_MAX_WAITHANDLES = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WaitHandle>.NativeClassPtr, "MAX_WAITHANDLES");
		NativeFieldInfoPtr_waitHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WaitHandle>.NativeClassPtr, "waitHandle");
		NativeFieldInfoPtr_safeWaitHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WaitHandle>.NativeClassPtr, "safeWaitHandle");
		NativeFieldInfoPtr_hasThreadAffinity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WaitHandle>.NativeClassPtr, "hasThreadAffinity");
		NativeFieldInfoPtr_WAIT_OBJECT_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WaitHandle>.NativeClassPtr, "WAIT_OBJECT_0");
		NativeFieldInfoPtr_WAIT_ABANDONED = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WaitHandle>.NativeClassPtr, "WAIT_ABANDONED");
		NativeFieldInfoPtr_WAIT_FAILED = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WaitHandle>.NativeClassPtr, "WAIT_FAILED");
		NativeFieldInfoPtr_ERROR_TOO_MANY_POSTS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WaitHandle>.NativeClassPtr, "ERROR_TOO_MANY_POSTS");
		NativeFieldInfoPtr_ERROR_NOT_OWNED_BY_CALLER = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WaitHandle>.NativeClassPtr, "ERROR_NOT_OWNED_BY_CALLER");
		NativeFieldInfoPtr_InvalidHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WaitHandle>.NativeClassPtr, "InvalidHandle");
		NativeFieldInfoPtr_MaxWaitHandles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WaitHandle>.NativeClassPtr, "MaxWaitHandles");
		NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaitHandle>.NativeClassPtr, 100667994);
		NativeMethodInfoPtr_Init_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaitHandle>.NativeClassPtr, 100667995);
		NativeMethodInfoPtr_set_Handle_Public_Virtual_New_set_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaitHandle>.NativeClassPtr, 100667996);
		NativeMethodInfoPtr_get_SafeWaitHandle_Public_get_SafeWaitHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaitHandle>.NativeClassPtr, 100667997);
		NativeMethodInfoPtr_SetHandleInternal_Internal_Void_SafeWaitHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaitHandle>.NativeClassPtr, 100667998);
		NativeMethodInfoPtr_WaitOne_Public_Virtual_New_Boolean_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaitHandle>.NativeClassPtr, 100667999);
		NativeMethodInfoPtr_WaitOne_Public_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaitHandle>.NativeClassPtr, 100668000);
		NativeMethodInfoPtr_WaitOne_Public_Virtual_New_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaitHandle>.NativeClassPtr, 100668001);
		NativeMethodInfoPtr_WaitOne_Private_Boolean_Int64_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaitHandle>.NativeClassPtr, 100668002);
		NativeMethodInfoPtr_InternalWaitOne_Internal_Static_Boolean_SafeHandle_Int64_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaitHandle>.NativeClassPtr, 100668003);
		NativeMethodInfoPtr_WaitAny_Public_Static_Int32_Il2CppReferenceArray_1_WaitHandle_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaitHandle>.NativeClassPtr, 100668004);
		NativeMethodInfoPtr_WaitAny_Public_Static_Int32_Il2CppReferenceArray_1_WaitHandle_TimeSpan_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaitHandle>.NativeClassPtr, 100668005);
		NativeMethodInfoPtr_ThrowAbandonedMutexException_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaitHandle>.NativeClassPtr, 100668006);
		NativeMethodInfoPtr_ThrowAbandonedMutexException_Private_Static_Void_Int32_WaitHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaitHandle>.NativeClassPtr, 100668007);
		NativeMethodInfoPtr_Close_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaitHandle>.NativeClassPtr, 100668008);
		NativeMethodInfoPtr_Dispose_Protected_Virtual_New_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaitHandle>.NativeClassPtr, 100668009);
		NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaitHandle>.NativeClassPtr, 100668010);
		NativeMethodInfoPtr_WaitOneNative_Private_Static_Int32_SafeHandle_UInt32_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaitHandle>.NativeClassPtr, 100668011);
		NativeMethodInfoPtr_WaitMultiple_Private_Static_Int32_Il2CppReferenceArray_1_WaitHandle_Int32_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaitHandle>.NativeClassPtr, 100668012);
		NativeMethodInfoPtr_Wait_internal_Internal_Static_Int32_ptr_IntPtr_Int32_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaitHandle>.NativeClassPtr, 100668013);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 771829, XrefRangeEnd = 771836, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe WaitHandle()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WaitHandle>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 771836, XrefRangeEnd = 771842, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Init()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Init_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 771869, XrefRangeEnd = 771871, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetHandleInternal(SafeWaitHandle handle)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)handle);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetHandleInternal_Internal_Void_SafeWaitHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 771871, XrefRangeEnd = 771879, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual bool WaitOne(int millisecondsTimeout, bool exitContext)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&millisecondsTimeout);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &exitContext;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_WaitOne_Public_Virtual_New_Boolean_Int32_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe virtual bool WaitOne()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_WaitOne_Public_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe virtual bool WaitOne(int millisecondsTimeout)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&millisecondsTimeout);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_WaitOne_Public_Virtual_New_Boolean_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 771879, XrefRangeEnd = 771887, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool WaitOne(long timeout, bool exitContext)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&timeout);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &exitContext;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_WaitOne_Private_Boolean_Int64_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 771887, XrefRangeEnd = 771891, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool InternalWaitOne(SafeHandle waitableSafeHandle, long millisecondsTimeout, bool hasThreadAffinity, bool exitContext)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)waitableSafeHandle);
		*(long**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &millisecondsTimeout;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &hasThreadAffinity;
		*(bool**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &exitContext;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InternalWaitOne_Internal_Static_Boolean_SafeHandle_Int64_Boolean_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 771906, RefRangeEnd = 771908, XrefRangeStart = 771891, XrefRangeEnd = 771906, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int WaitAny(Il2CppReferenceArray<WaitHandle> waitHandles, int millisecondsTimeout, bool exitContext)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)waitHandles);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &millisecondsTimeout;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &exitContext;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_WaitAny_Public_Static_Int32_Il2CppReferenceArray_1_WaitHandle_Int32_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 771916, RefRangeEnd = 771917, XrefRangeStart = 771908, XrefRangeEnd = 771916, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int WaitAny(Il2CppReferenceArray<WaitHandle> waitHandles, TimeSpan timeout, bool exitContext)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)waitHandles);
		*(TimeSpan**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &timeout;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &exitContext;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_WaitAny_Public_Static_Int32_Il2CppReferenceArray_1_WaitHandle_TimeSpan_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 771917, XrefRangeEnd = 771922, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ThrowAbandonedMutexException()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ThrowAbandonedMutexException_Private_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 771922, XrefRangeEnd = 771927, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ThrowAbandonedMutexException(int location, WaitHandle handle)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&location);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)handle);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ThrowAbandonedMutexException_Private_Static_Void_Int32_WaitHandle_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 771927, XrefRangeEnd = 771931, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void Close()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_Close_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 771931, XrefRangeEnd = 771934, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void Dispose(bool explicitDisposing)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&explicitDisposing);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_Dispose_Protected_Virtual_New_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 771938, RefRangeEnd = 771940, XrefRangeStart = 771934, XrefRangeEnd = 771938, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void Dispose()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 771954, RefRangeEnd = 771957, XrefRangeStart = 771940, XrefRangeEnd = 771954, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int WaitOneNative(SafeHandle waitableSafeHandle, uint millisecondsTimeout, bool hasThreadAffinity, bool exitContext)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)waitableSafeHandle);
		*(uint**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &millisecondsTimeout;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &hasThreadAffinity;
		*(bool**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &exitContext;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_WaitOneNative_Private_Static_Int32_SafeHandle_UInt32_Boolean_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 771982, RefRangeEnd = 771983, XrefRangeStart = 771957, XrefRangeEnd = 771982, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int WaitMultiple(Il2CppReferenceArray<WaitHandle> waitHandles, int millisecondsTimeout, bool exitContext, bool WaitAll)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)waitHandles);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &millisecondsTimeout;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &exitContext;
		*(bool**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &WaitAll;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_WaitMultiple_Private_Static_Int32_Il2CppReferenceArray_1_WaitHandle_Int32_Boolean_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 771983, XrefRangeEnd = 771987, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int Wait_internal(System.IntPtr* handles, int numHandles, bool waitAll, int ms)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)handles;
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &numHandles;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &waitAll;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &ms;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Wait_internal_Internal_Static_Int32_ptr_IntPtr_Int32_Boolean_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	public WaitHandle(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
