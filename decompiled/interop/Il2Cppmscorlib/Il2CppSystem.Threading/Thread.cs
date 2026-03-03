using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Globalization;
using Il2CppSystem.Runtime.ConstrainedExecution;
using Il2CppSystem.Runtime.Remoting.Contexts;
using Il2CppSystem.Security.Principal;

namespace Il2CppSystem.Threading;

public sealed class Thread : CriticalFinalizerObject
{
	private static readonly System.IntPtr NativeFieldInfoPtr_s_LocalDataStoreMgr;

	private static readonly System.IntPtr NativeFieldInfoPtr_s_LocalDataStore;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_CurrentCulture;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_CurrentUICulture;

	private static readonly System.IntPtr NativeFieldInfoPtr_s_asyncLocalCurrentCulture;

	private static readonly System.IntPtr NativeFieldInfoPtr_s_asyncLocalCurrentUICulture;

	private static readonly System.IntPtr NativeFieldInfoPtr_internal_thread;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_ThreadStartArg;

	private static readonly System.IntPtr NativeFieldInfoPtr_pending_exception;

	private static readonly System.IntPtr NativeFieldInfoPtr_current_thread;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_Delegate;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_ExecutionContext;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_ExecutionContextBelongsToOuterScope;

	private static readonly System.IntPtr NativeFieldInfoPtr_principal;

	private static readonly System.IntPtr NativeFieldInfoPtr_principal_version;

	private static readonly System.IntPtr NativeMethodInfoPtr_AsyncLocalSetCurrentCulture_Private_Static_Void_AsyncLocalValueChangedArgs_1_CultureInfo_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_ThreadStart_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_ThreadStart_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_ParameterizedThreadStart_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_ParameterizedThreadStart_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Start_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Start_Public_Void_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Start_Private_Void_byref_StackCrawlMark_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetExecutionContextReader_Internal_Reader_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_ExecutionContextBelongsToCurrentScope_Internal_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_ExecutionContextBelongsToCurrentScope_Internal_set_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetMutableExecutionContext_Internal_ExecutionContext_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetExecutionContext_Internal_Void_ExecutionContext_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetExecutionContext_Internal_Void_Reader_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ResetAbort_Public_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ResetAbortNative_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_JoinInternal_Private_Boolean_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Join_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Join_Public_Boolean_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SleepInternal_Private_Static_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Sleep_Public_Static_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_YieldInternal_Private_Static_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Yield_Public_Static_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetStartHelper_Private_Void_Delegate_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_CurrentUICulture_Public_get_CultureInfo_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetCurrentUICultureNoAppX_Internal_CultureInfo_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_CurrentCulture_Public_get_CultureInfo_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_CurrentCulture_Public_set_Void_CultureInfo_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetCurrentCultureNoAppX_Private_CultureInfo_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_nativeInitCultureAccessors_Private_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_MemoryBarrier_Public_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ConstructInternalThread_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Internal_Private_get_InternalThread_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_CurrentContext_Public_Static_get_Context_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetCurrentThread_icall_Private_Static_Void_byref_Thread_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetCurrentThread_Private_Static_Thread_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_CurrentThread_Public_Static_get_Thread_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_CurrentThreadId_Internal_Static_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetDomainID_Public_Static_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Thread_internal_Private_Boolean_MulticastDelegate_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_IsThreadPoolThread_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_IsThreadPoolThreadInternal_Internal_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_IsBackground_Public_set_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetName_internal_Private_Static_String_InternalThread_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetName_icall_Private_Static_Void_InternalThread_ptr_Char_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetName_internal_Private_Static_Void_InternalThread_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Name_Public_get_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_Name_Public_set_Void_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_ThreadState_Public_get_ThreadState_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Abort_internal_Private_Static_Void_InternalThread_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Abort_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ClearAbortReason_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SpinWait_nop_Private_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SpinWait_Public_Static_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_StartInternal_Private_Void_Object_byref_StackCrawlMark_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetState_Private_Static_Void_InternalThread_ThreadState_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ClrState_Private_Static_Void_InternalThread_ThreadState_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetState_Private_Static_ThreadState_InternalThread_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SystemMaxStackStize_Private_Static_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetProcessDefaultStackSize_Private_Static_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetStart_Private_Void_MulticastDelegate_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_ManagedThreadId_Public_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_BeginCriticalRegion_Public_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_EndCriticalRegion_Public_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ValidateThreadState_Private_ThreadState_0;

	public unsafe static LocalDataStoreMgr s_LocalDataStoreMgr
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_LocalDataStoreMgr, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<LocalDataStoreMgr>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_LocalDataStoreMgr, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static LocalDataStoreHolder s_LocalDataStore
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_LocalDataStore, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<LocalDataStoreHolder>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_LocalDataStore, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static CultureInfo m_CurrentCulture
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_m_CurrentCulture, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<CultureInfo>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_m_CurrentCulture, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static CultureInfo m_CurrentUICulture
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_m_CurrentUICulture, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<CultureInfo>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_m_CurrentUICulture, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static AsyncLocal<CultureInfo> s_asyncLocalCurrentCulture
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_asyncLocalCurrentCulture, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<AsyncLocal<CultureInfo>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_asyncLocalCurrentCulture, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static AsyncLocal<CultureInfo> s_asyncLocalCurrentUICulture
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_asyncLocalCurrentUICulture, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<AsyncLocal<CultureInfo>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_asyncLocalCurrentUICulture, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe InternalThread internal_thread
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_internal_thread);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<InternalThread>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_internal_thread)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe Object m_ThreadStartArg
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ThreadStartArg);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Object>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ThreadStartArg)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe Object pending_exception
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pending_exception);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Object>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pending_exception)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Thread current_thread
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_current_thread, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Thread>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_current_thread, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe MulticastDelegate m_Delegate
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Delegate);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<MulticastDelegate>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Delegate)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe ExecutionContext m_ExecutionContext
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ExecutionContext);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ExecutionContext>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ExecutionContext)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe bool m_ExecutionContextBelongsToOuterScope
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ExecutionContextBelongsToOuterScope);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ExecutionContextBelongsToOuterScope)) = value;
		}
	}

	public unsafe IPrincipal principal
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_principal);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IPrincipal>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_principal)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe int principal_version
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_principal_version);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_principal_version)) = value;
		}
	}

	public unsafe bool ExecutionContextBelongsToCurrentScope
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_ExecutionContextBelongsToCurrentScope_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_ExecutionContextBelongsToCurrentScope_Internal_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe CultureInfo CurrentUICulture
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 770820, RefRangeEnd = 770821, XrefRangeStart = 770818, XrefRangeEnd = 770820, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_CurrentUICulture_Public_get_CultureInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<CultureInfo>(intPtr2) : null;
		}
	}

	public unsafe CultureInfo CurrentCulture
	{
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 770830, RefRangeEnd = 770842, XrefRangeStart = 770828, XrefRangeEnd = 770830, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_CurrentCulture_Public_get_CultureInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<CultureInfo>(intPtr2) : null;
		}
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 770896, RefRangeEnd = 770897, XrefRangeStart = 770842, XrefRangeEnd = 770896, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_CurrentCulture_Public_set_Void_CultureInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe InternalThread Internal
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 770924, XrefRangeEnd = 770925, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Internal_Private_get_InternalThread_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<InternalThread>(intPtr2) : null;
		}
	}

	public unsafe static Context CurrentContext
	{
		[CallerCount(18)]
		[CachedScanResults(RefRangeStart = 770926, RefRangeEnd = 770944, XrefRangeStart = 770925, XrefRangeEnd = 770926, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_CurrentContext_Public_Static_get_Context_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Context>(intPtr2) : null;
		}
	}

	public unsafe static Thread CurrentThread
	{
		[CallerCount(41)]
		[CachedScanResults(RefRangeStart = 770950, RefRangeEnd = 770991, XrefRangeStart = 770946, XrefRangeEnd = 770950, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_CurrentThread_Public_Static_get_Thread_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Thread>(intPtr2) : null;
		}
	}

	public unsafe static int CurrentThreadId
	{
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 770995, RefRangeEnd = 770998, XrefRangeStart = 770991, XrefRangeEnd = 770995, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_CurrentThreadId_Internal_Static_get_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe bool IsThreadPoolThread
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 771008, XrefRangeEnd = 771009, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_IsThreadPoolThread_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe bool IsThreadPoolThreadInternal
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_IsThreadPoolThreadInternal_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe bool IsBackground
	{
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 771021, RefRangeEnd = 771027, XrefRangeStart = 771009, XrefRangeEnd = 771021, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_IsBackground_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe string Name
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 771034, RefRangeEnd = 771035, XrefRangeStart = 771032, XrefRangeEnd = 771034, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Name_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return IL2CPP.Il2CppStringToManaged(intPtr2);
		}
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 771039, RefRangeEnd = 771041, XrefRangeStart = 771035, XrefRangeEnd = 771039, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_Name_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe ThreadState ThreadState
	{
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 771043, RefRangeEnd = 771047, XrefRangeStart = 771041, XrefRangeEnd = 771043, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_ThreadState_Public_get_ThreadState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(ThreadState*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe int ManagedThreadId
	{
		[CallerCount(15)]
		[CachedScanResults(RefRangeStart = 771079, RefRangeEnd = 771094, XrefRangeStart = 771078, XrefRangeEnd = 771079, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_ManagedThreadId_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	static Thread()
	{
		Il2CppClassPointerStore<Thread>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Threading", "Thread");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Thread>.NativeClassPtr);
		NativeFieldInfoPtr_s_LocalDataStoreMgr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Thread>.NativeClassPtr, "s_LocalDataStoreMgr");
		NativeFieldInfoPtr_s_LocalDataStore = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Thread>.NativeClassPtr, "s_LocalDataStore");
		NativeFieldInfoPtr_m_CurrentCulture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Thread>.NativeClassPtr, "m_CurrentCulture");
		NativeFieldInfoPtr_m_CurrentUICulture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Thread>.NativeClassPtr, "m_CurrentUICulture");
		NativeFieldInfoPtr_s_asyncLocalCurrentCulture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Thread>.NativeClassPtr, "s_asyncLocalCurrentCulture");
		NativeFieldInfoPtr_s_asyncLocalCurrentUICulture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Thread>.NativeClassPtr, "s_asyncLocalCurrentUICulture");
		NativeFieldInfoPtr_internal_thread = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Thread>.NativeClassPtr, "internal_thread");
		NativeFieldInfoPtr_m_ThreadStartArg = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Thread>.NativeClassPtr, "m_ThreadStartArg");
		NativeFieldInfoPtr_pending_exception = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Thread>.NativeClassPtr, "pending_exception");
		NativeFieldInfoPtr_current_thread = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Thread>.NativeClassPtr, "current_thread");
		NativeFieldInfoPtr_m_Delegate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Thread>.NativeClassPtr, "m_Delegate");
		NativeFieldInfoPtr_m_ExecutionContext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Thread>.NativeClassPtr, "m_ExecutionContext");
		NativeFieldInfoPtr_m_ExecutionContextBelongsToOuterScope = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Thread>.NativeClassPtr, "m_ExecutionContextBelongsToOuterScope");
		NativeFieldInfoPtr_principal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Thread>.NativeClassPtr, "principal");
		NativeFieldInfoPtr_principal_version = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Thread>.NativeClassPtr, "principal_version");
		NativeMethodInfoPtr_AsyncLocalSetCurrentCulture_Private_Static_Void_AsyncLocalValueChangedArgs_1_CultureInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Thread>.NativeClassPtr, 100667862);
		NativeMethodInfoPtr__ctor_Public_Void_ThreadStart_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Thread>.NativeClassPtr, 100667863);
		NativeMethodInfoPtr__ctor_Public_Void_ThreadStart_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Thread>.NativeClassPtr, 100667864);
		NativeMethodInfoPtr__ctor_Public_Void_ParameterizedThreadStart_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Thread>.NativeClassPtr, 100667865);
		NativeMethodInfoPtr__ctor_Public_Void_ParameterizedThreadStart_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Thread>.NativeClassPtr, 100667866);
		NativeMethodInfoPtr_Start_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Thread>.NativeClassPtr, 100667867);
		NativeMethodInfoPtr_Start_Public_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Thread>.NativeClassPtr, 100667868);
		NativeMethodInfoPtr_Start_Private_Void_byref_StackCrawlMark_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Thread>.NativeClassPtr, 100667869);
		NativeMethodInfoPtr_GetExecutionContextReader_Internal_Reader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Thread>.NativeClassPtr, 100667870);
		NativeMethodInfoPtr_get_ExecutionContextBelongsToCurrentScope_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Thread>.NativeClassPtr, 100667871);
		NativeMethodInfoPtr_set_ExecutionContextBelongsToCurrentScope_Internal_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Thread>.NativeClassPtr, 100667872);
		NativeMethodInfoPtr_GetMutableExecutionContext_Internal_ExecutionContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Thread>.NativeClassPtr, 100667873);
		NativeMethodInfoPtr_SetExecutionContext_Internal_Void_ExecutionContext_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Thread>.NativeClassPtr, 100667874);
		NativeMethodInfoPtr_SetExecutionContext_Internal_Void_Reader_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Thread>.NativeClassPtr, 100667875);
		NativeMethodInfoPtr_ResetAbort_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Thread>.NativeClassPtr, 100667876);
		NativeMethodInfoPtr_ResetAbortNative_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Thread>.NativeClassPtr, 100667877);
		NativeMethodInfoPtr_JoinInternal_Private_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Thread>.NativeClassPtr, 100667878);
		NativeMethodInfoPtr_Join_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Thread>.NativeClassPtr, 100667879);
		NativeMethodInfoPtr_Join_Public_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Thread>.NativeClassPtr, 100667880);
		NativeMethodInfoPtr_SleepInternal_Private_Static_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Thread>.NativeClassPtr, 100667881);
		NativeMethodInfoPtr_Sleep_Public_Static_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Thread>.NativeClassPtr, 100667882);
		NativeMethodInfoPtr_YieldInternal_Private_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Thread>.NativeClassPtr, 100667883);
		NativeMethodInfoPtr_Yield_Public_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Thread>.NativeClassPtr, 100667884);
		NativeMethodInfoPtr_SetStartHelper_Private_Void_Delegate_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Thread>.NativeClassPtr, 100667885);
		NativeMethodInfoPtr_get_CurrentUICulture_Public_get_CultureInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Thread>.NativeClassPtr, 100667886);
		NativeMethodInfoPtr_GetCurrentUICultureNoAppX_Internal_CultureInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Thread>.NativeClassPtr, 100667887);
		NativeMethodInfoPtr_get_CurrentCulture_Public_get_CultureInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Thread>.NativeClassPtr, 100667888);
		NativeMethodInfoPtr_set_CurrentCulture_Public_set_Void_CultureInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Thread>.NativeClassPtr, 100667889);
		NativeMethodInfoPtr_GetCurrentCultureNoAppX_Private_CultureInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Thread>.NativeClassPtr, 100667890);
		NativeMethodInfoPtr_nativeInitCultureAccessors_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Thread>.NativeClassPtr, 100667891);
		NativeMethodInfoPtr_MemoryBarrier_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Thread>.NativeClassPtr, 100667892);
		NativeMethodInfoPtr_ConstructInternalThread_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Thread>.NativeClassPtr, 100667893);
		NativeMethodInfoPtr_get_Internal_Private_get_InternalThread_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Thread>.NativeClassPtr, 100667894);
		NativeMethodInfoPtr_get_CurrentContext_Public_Static_get_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Thread>.NativeClassPtr, 100667895);
		NativeMethodInfoPtr_GetCurrentThread_icall_Private_Static_Void_byref_Thread_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Thread>.NativeClassPtr, 100667896);
		NativeMethodInfoPtr_GetCurrentThread_Private_Static_Thread_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Thread>.NativeClassPtr, 100667897);
		NativeMethodInfoPtr_get_CurrentThread_Public_Static_get_Thread_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Thread>.NativeClassPtr, 100667898);
		NativeMethodInfoPtr_get_CurrentThreadId_Internal_Static_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Thread>.NativeClassPtr, 100667899);
		NativeMethodInfoPtr_GetDomainID_Public_Static_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Thread>.NativeClassPtr, 100667900);
		NativeMethodInfoPtr_Thread_internal_Private_Boolean_MulticastDelegate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Thread>.NativeClassPtr, 100667901);
		NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Thread>.NativeClassPtr, 100667902);
		NativeMethodInfoPtr_get_IsThreadPoolThread_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Thread>.NativeClassPtr, 100667903);
		NativeMethodInfoPtr_get_IsThreadPoolThreadInternal_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Thread>.NativeClassPtr, 100667904);
		NativeMethodInfoPtr_set_IsBackground_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Thread>.NativeClassPtr, 100667905);
		NativeMethodInfoPtr_GetName_internal_Private_Static_String_InternalThread_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Thread>.NativeClassPtr, 100667906);
		NativeMethodInfoPtr_SetName_icall_Private_Static_Void_InternalThread_ptr_Char_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Thread>.NativeClassPtr, 100667907);
		NativeMethodInfoPtr_SetName_internal_Private_Static_Void_InternalThread_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Thread>.NativeClassPtr, 100667908);
		NativeMethodInfoPtr_get_Name_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Thread>.NativeClassPtr, 100667909);
		NativeMethodInfoPtr_set_Name_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Thread>.NativeClassPtr, 100667910);
		NativeMethodInfoPtr_get_ThreadState_Public_get_ThreadState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Thread>.NativeClassPtr, 100667911);
		NativeMethodInfoPtr_Abort_internal_Private_Static_Void_InternalThread_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Thread>.NativeClassPtr, 100667912);
		NativeMethodInfoPtr_Abort_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Thread>.NativeClassPtr, 100667913);
		NativeMethodInfoPtr_ClearAbortReason_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Thread>.NativeClassPtr, 100667914);
		NativeMethodInfoPtr_SpinWait_nop_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Thread>.NativeClassPtr, 100667915);
		NativeMethodInfoPtr_SpinWait_Public_Static_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Thread>.NativeClassPtr, 100667916);
		NativeMethodInfoPtr_StartInternal_Private_Void_Object_byref_StackCrawlMark_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Thread>.NativeClassPtr, 100667917);
		NativeMethodInfoPtr_SetState_Private_Static_Void_InternalThread_ThreadState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Thread>.NativeClassPtr, 100667918);
		NativeMethodInfoPtr_ClrState_Private_Static_Void_InternalThread_ThreadState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Thread>.NativeClassPtr, 100667919);
		NativeMethodInfoPtr_GetState_Private_Static_ThreadState_InternalThread_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Thread>.NativeClassPtr, 100667920);
		NativeMethodInfoPtr_SystemMaxStackStize_Private_Static_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Thread>.NativeClassPtr, 100667921);
		NativeMethodInfoPtr_GetProcessDefaultStackSize_Private_Static_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Thread>.NativeClassPtr, 100667922);
		NativeMethodInfoPtr_SetStart_Private_Void_MulticastDelegate_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Thread>.NativeClassPtr, 100667923);
		NativeMethodInfoPtr_get_ManagedThreadId_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Thread>.NativeClassPtr, 100667924);
		NativeMethodInfoPtr_BeginCriticalRegion_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Thread>.NativeClassPtr, 100667925);
		NativeMethodInfoPtr_EndCriticalRegion_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Thread>.NativeClassPtr, 100667926);
		NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Thread>.NativeClassPtr, 100667927);
		NativeMethodInfoPtr_ValidateThreadState_Private_ThreadState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Thread>.NativeClassPtr, 100667928);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 770625, XrefRangeEnd = 770632, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void AsyncLocalSetCurrentCulture(AsyncLocalValueChangedArgs<CultureInfo> args)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)args));
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AsyncLocalSetCurrentCulture_Private_Static_Void_AsyncLocalValueChangedArgs_1_CultureInfo_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 770640, RefRangeEnd = 770646, XrefRangeStart = 770632, XrefRangeEnd = 770640, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Thread(ThreadStart start)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Thread>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)start);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_ThreadStart_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 770662, RefRangeEnd = 770663, XrefRangeStart = 770646, XrefRangeEnd = 770662, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Thread(ThreadStart start, int maxStackSize)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Thread>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)start);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &maxStackSize;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_ThreadStart_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 770671, RefRangeEnd = 770672, XrefRangeStart = 770663, XrefRangeEnd = 770671, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Thread(ParameterizedThreadStart start)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Thread>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)start);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_ParameterizedThreadStart_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 770688, RefRangeEnd = 770689, XrefRangeStart = 770672, XrefRangeEnd = 770688, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Thread(ParameterizedThreadStart start, int maxStackSize)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Thread>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)start);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &maxStackSize;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_ParameterizedThreadStart_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(8)]
	[CachedScanResults(RefRangeStart = 770690, RefRangeEnd = 770698, XrefRangeStart = 770689, XrefRangeEnd = 770690, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Start()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Start_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 770702, RefRangeEnd = 770703, XrefRangeStart = 770698, XrefRangeEnd = 770702, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Start(Object parameter)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)parameter);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Start_Public_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 770720, RefRangeEnd = 770722, XrefRangeStart = 770703, XrefRangeEnd = 770720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Start(ref StackCrawlMark stackMark)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)Unsafe.AsPointer(ref stackMark);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Start_Private_Void_byref_StackCrawlMark_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 770723, RefRangeEnd = 770724, XrefRangeStart = 770722, XrefRangeEnd = 770723, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ExecutionContext.Reader GetExecutionContextReader()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetExecutionContextReader_Internal_Reader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return new ExecutionContext.Reader(pointer);
	}

	[CallerCount(9)]
	[CachedScanResults(RefRangeStart = 770727, RefRangeEnd = 770736, XrefRangeStart = 770724, XrefRangeEnd = 770727, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ExecutionContext GetMutableExecutionContext()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetMutableExecutionContext_Internal_ExecutionContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<ExecutionContext>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 770736, XrefRangeEnd = 770737, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetExecutionContext(ExecutionContext value, bool belongsToCurrentScope)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &belongsToCurrentScope;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetExecutionContext_Internal_Void_ExecutionContext_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetExecutionContext(ExecutionContext.Reader value, bool belongsToCurrentScope)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)value));
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &belongsToCurrentScope;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetExecutionContext_Internal_Void_Reader_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 770744, RefRangeEnd = 770745, XrefRangeStart = 770737, XrefRangeEnd = 770744, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ResetAbort()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ResetAbort_Public_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 770745, XrefRangeEnd = 770746, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ResetAbortNative()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ResetAbortNative_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 770746, XrefRangeEnd = 770747, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool JoinInternal(int millisecondsTimeout)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&millisecondsTimeout);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_JoinInternal_Private_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 770748, RefRangeEnd = 770749, XrefRangeStart = 770747, XrefRangeEnd = 770748, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Join()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Join_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 770758, RefRangeEnd = 770759, XrefRangeStart = 770749, XrefRangeEnd = 770758, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool Join(int millisecondsTimeout)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&millisecondsTimeout);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Join_Public_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 770759, XrefRangeEnd = 770760, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SleepInternal(int millisecondsTimeout)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&millisecondsTimeout);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SleepInternal_Private_Static_Void_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(18)]
	[CachedScanResults(RefRangeStart = 770769, RefRangeEnd = 770787, XrefRangeStart = 770760, XrefRangeEnd = 770769, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Sleep(int millisecondsTimeout)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&millisecondsTimeout);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Sleep_Public_Static_Void_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 770788, RefRangeEnd = 770790, XrefRangeStart = 770787, XrefRangeEnd = 770788, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool YieldInternal()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_YieldInternal_Private_Static_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 770788, RefRangeEnd = 770790, XrefRangeStart = 770788, XrefRangeEnd = 770790, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool Yield()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Yield_Public_Static_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 770814, RefRangeEnd = 770818, XrefRangeStart = 770790, XrefRangeEnd = 770814, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetStartHelper(Delegate start, int maxStackSize)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)start);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &maxStackSize;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetStartHelper_Private_Void_Delegate_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 770827, RefRangeEnd = 770828, XrefRangeStart = 770821, XrefRangeEnd = 770827, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe CultureInfo GetCurrentUICultureNoAppX()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetCurrentUICultureNoAppX_Internal_CultureInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<CultureInfo>(intPtr2) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 770903, RefRangeEnd = 770904, XrefRangeStart = 770897, XrefRangeEnd = 770903, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe CultureInfo GetCurrentCultureNoAppX()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetCurrentCultureNoAppX_Private_CultureInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<CultureInfo>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 770904, XrefRangeEnd = 770920, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void nativeInitCultureAccessors()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_nativeInitCultureAccessors_Private_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 770921, RefRangeEnd = 770923, XrefRangeStart = 770920, XrefRangeEnd = 770921, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void MemoryBarrier()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MemoryBarrier_Public_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 770923, XrefRangeEnd = 770924, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ConstructInternalThread()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ConstructInternalThread_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 770944, XrefRangeEnd = 770945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void GetCurrentThread_icall(ref Thread thread)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)thread);
		*ptr = (nint)(&intPtr);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetCurrentThread_icall_Private_Static_Void_byref_Thread_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		System.IntPtr intPtr4 = intPtr;
		thread = ((intPtr4 == (System.IntPtr)0) ? null : new Thread(intPtr4));
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 770945, XrefRangeEnd = 770946, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Thread GetCurrentThread()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetCurrentThread_Private_Static_Thread_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Thread>(intPtr2) : null;
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 770999, RefRangeEnd = 771004, XrefRangeStart = 770998, XrefRangeEnd = 770999, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int GetDomainID()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetDomainID_Public_Static_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 771004, XrefRangeEnd = 771005, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool Thread_internal(MulticastDelegate start)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)start);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Thread_internal_Private_Boolean_MulticastDelegate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 771005, XrefRangeEnd = 771008, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public new unsafe void Finalize()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 771027, XrefRangeEnd = 771028, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string GetName_internal(InternalThread thread)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)thread);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetName_internal_Private_Static_String_InternalThread_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 771028, XrefRangeEnd = 771029, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetName_icall(InternalThread thread, char* name, int nameLength)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)thread);
		*(char**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = name;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &nameLength;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetName_icall_Private_Static_Void_InternalThread_ptr_Char_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 771029, XrefRangeEnd = 771032, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetName_internal(InternalThread thread, string name)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)thread);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(name);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetName_internal_Private_Static_Void_InternalThread_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 771047, XrefRangeEnd = 771048, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Abort_internal(InternalThread thread, Object stateInfo)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)thread);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)stateInfo);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Abort_internal_Private_Static_Void_InternalThread_Object_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 771050, RefRangeEnd = 771052, XrefRangeStart = 771048, XrefRangeEnd = 771050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Abort()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Abort_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(19883)]
	[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 20035, XrefRangeStart = 152, XrefRangeEnd = 20035, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ClearAbortReason()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ClearAbortReason_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 771052, XrefRangeEnd = 771053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SpinWait_nop()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SpinWait_nop_Private_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 771054, RefRangeEnd = 771058, XrefRangeStart = 771053, XrefRangeEnd = 771054, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SpinWait(int iterations)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&iterations);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SpinWait_Public_Static_Void_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 771058, XrefRangeEnd = 771066, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void StartInternal(Object principal, ref StackCrawlMark stackMark)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)principal);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref stackMark);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_StartInternal_Private_Void_Object_byref_StackCrawlMark_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 771066, XrefRangeEnd = 771067, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetState(InternalThread thread, ThreadState set)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)thread);
		*(ThreadState**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &set;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetState_Private_Static_Void_InternalThread_ThreadState_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 771067, XrefRangeEnd = 771068, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ClrState(InternalThread thread, ThreadState clr)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)thread);
		*(ThreadState**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &clr;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ClrState_Private_Static_Void_InternalThread_ThreadState_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 771068, XrefRangeEnd = 771069, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static ThreadState GetState(InternalThread thread)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)thread);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetState_Private_Static_ThreadState_InternalThread_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(ThreadState*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 771069, XrefRangeEnd = 771070, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int SystemMaxStackStize()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SystemMaxStackStize_Private_Static_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 771070, XrefRangeEnd = 771076, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int GetProcessDefaultStackSize(int maxStackSize)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&maxStackSize);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetProcessDefaultStackSize_Private_Static_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 771076, XrefRangeEnd = 771078, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetStart(MulticastDelegate start, int maxStackSize)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)start);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &maxStackSize;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetStart_Private_Void_MulticastDelegate_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(10)]
	[CachedScanResults(RefRangeStart = 771101, RefRangeEnd = 771111, XrefRangeStart = 771094, XrefRangeEnd = 771101, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void BeginCriticalRegion()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_BeginCriticalRegion_Public_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(8)]
	[CachedScanResults(RefRangeStart = 771118, RefRangeEnd = 771126, XrefRangeStart = 771111, XrefRangeEnd = 771118, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void EndCriticalRegion()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_EndCriticalRegion_Public_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(15)]
	[CachedScanResults(RefRangeStart = 771079, RefRangeEnd = 771094, XrefRangeStart = 771079, XrefRangeEnd = 771094, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override int GetHashCode()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 771126, XrefRangeEnd = 771128, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ThreadState ValidateThreadState()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ValidateThreadState_Private_ThreadState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(ThreadState*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	public Thread(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
