using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Runtime.ConstrainedExecution;

namespace Il2CppSystem.Threading;

public sealed class InternalThread : CriticalFinalizerObject
{
	private static readonly System.IntPtr NativeFieldInfoPtr_lock_thread_id;

	private static readonly System.IntPtr NativeFieldInfoPtr_handle;

	private static readonly System.IntPtr NativeFieldInfoPtr_native_handle;

	private static readonly System.IntPtr NativeFieldInfoPtr_name_chars;

	private static readonly System.IntPtr NativeFieldInfoPtr_name_free;

	private static readonly System.IntPtr NativeFieldInfoPtr_name_length;

	private static readonly System.IntPtr NativeFieldInfoPtr_state;

	private static readonly System.IntPtr NativeFieldInfoPtr_abort_exc;

	private static readonly System.IntPtr NativeFieldInfoPtr_abort_state_handle;

	private static readonly System.IntPtr NativeFieldInfoPtr_thread_id;

	private static readonly System.IntPtr NativeFieldInfoPtr_debugger_thread;

	private static readonly System.IntPtr NativeFieldInfoPtr_static_data;

	private static readonly System.IntPtr NativeFieldInfoPtr_runtime_thread_info;

	private static readonly System.IntPtr NativeFieldInfoPtr_current_appcontext;

	private static readonly System.IntPtr NativeFieldInfoPtr_root_domain_thread;

	private static readonly System.IntPtr NativeFieldInfoPtr__serialized_principal;

	private static readonly System.IntPtr NativeFieldInfoPtr__serialized_principal_version;

	private static readonly System.IntPtr NativeFieldInfoPtr_appdomain_refs;

	private static readonly System.IntPtr NativeFieldInfoPtr_interruption_requested;

	private static readonly System.IntPtr NativeFieldInfoPtr_longlived;

	private static readonly System.IntPtr NativeFieldInfoPtr_threadpool_thread;

	private static readonly System.IntPtr NativeFieldInfoPtr_thread_interrupt_requested;

	private static readonly System.IntPtr NativeFieldInfoPtr_stack_size;

	private static readonly System.IntPtr NativeFieldInfoPtr_apartment_state;

	private static readonly System.IntPtr NativeFieldInfoPtr_critical_region_level;

	private static readonly System.IntPtr NativeFieldInfoPtr_managed_id;

	private static readonly System.IntPtr NativeFieldInfoPtr_small_id;

	private static readonly System.IntPtr NativeFieldInfoPtr_manage_callback;

	private static readonly System.IntPtr NativeFieldInfoPtr_flags;

	private static readonly System.IntPtr NativeFieldInfoPtr_thread_pinning_ref;

	private static readonly System.IntPtr NativeFieldInfoPtr_abort_protected_block_count;

	private static readonly System.IntPtr NativeFieldInfoPtr_priority;

	private static readonly System.IntPtr NativeFieldInfoPtr_owned_mutex;

	private static readonly System.IntPtr NativeFieldInfoPtr_suspended_event;

	private static readonly System.IntPtr NativeFieldInfoPtr_self_suspended;

	private static readonly System.IntPtr NativeFieldInfoPtr_thread_state;

	private static readonly System.IntPtr NativeFieldInfoPtr_netcore0;

	private static readonly System.IntPtr NativeFieldInfoPtr_netcore1;

	private static readonly System.IntPtr NativeFieldInfoPtr_netcore2;

	private static readonly System.IntPtr NativeFieldInfoPtr_last;

	private static readonly System.IntPtr NativeMethodInfoPtr_Thread_free_internal_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe int lock_thread_id
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lock_thread_id);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lock_thread_id)) = value;
		}
	}

	public unsafe System.IntPtr handle
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_handle);
			return *(System.IntPtr*)num;
		}
		set
		{
			*(System.IntPtr*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_handle)) = value;
		}
	}

	public unsafe System.IntPtr native_handle
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_native_handle);
			return *(System.IntPtr*)num;
		}
		set
		{
			*(System.IntPtr*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_native_handle)) = value;
		}
	}

	public unsafe System.IntPtr name_chars
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_name_chars);
			return *(System.IntPtr*)num;
		}
		set
		{
			*(System.IntPtr*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_name_chars)) = value;
		}
	}

	public unsafe int name_free
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_name_free);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_name_free)) = value;
		}
	}

	public unsafe int name_length
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_name_length);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_name_length)) = value;
		}
	}

	public unsafe ThreadState state
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_state);
			return *(ThreadState*)num;
		}
		set
		{
			*(ThreadState*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_state)) = value;
		}
	}

	public unsafe Object abort_exc
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_abort_exc);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Object>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_abort_exc)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe int abort_state_handle
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_abort_state_handle);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_abort_state_handle)) = value;
		}
	}

	public unsafe long thread_id
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_thread_id);
			return *(long*)num;
		}
		set
		{
			*(long*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_thread_id)) = value;
		}
	}

	public unsafe System.IntPtr debugger_thread
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_debugger_thread);
			return *(System.IntPtr*)num;
		}
		set
		{
			*(System.IntPtr*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_debugger_thread)) = value;
		}
	}

	public unsafe System.UIntPtr static_data
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_static_data);
			return *(System.UIntPtr*)num;
		}
		set
		{
			*(System.UIntPtr*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_static_data)) = value;
		}
	}

	public unsafe System.IntPtr runtime_thread_info
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_runtime_thread_info);
			return *(System.IntPtr*)num;
		}
		set
		{
			*(System.IntPtr*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_runtime_thread_info)) = value;
		}
	}

	public unsafe Object current_appcontext
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_current_appcontext);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Object>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_current_appcontext)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe Object root_domain_thread
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_root_domain_thread);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Object>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_root_domain_thread)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe Il2CppStructArray<byte> _serialized_principal
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__serialized_principal);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__serialized_principal)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe int _serialized_principal_version
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__serialized_principal_version);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__serialized_principal_version)) = value;
		}
	}

	public unsafe System.IntPtr appdomain_refs
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_appdomain_refs);
			return *(System.IntPtr*)num;
		}
		set
		{
			*(System.IntPtr*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_appdomain_refs)) = value;
		}
	}

	public unsafe int interruption_requested
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_interruption_requested);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_interruption_requested)) = value;
		}
	}

	public unsafe System.IntPtr longlived
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_longlived);
			return *(System.IntPtr*)num;
		}
		set
		{
			*(System.IntPtr*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_longlived)) = value;
		}
	}

	public unsafe bool threadpool_thread
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_threadpool_thread);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_threadpool_thread)) = value;
		}
	}

	public unsafe bool thread_interrupt_requested
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_thread_interrupt_requested);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_thread_interrupt_requested)) = value;
		}
	}

	public unsafe int stack_size
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_stack_size);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_stack_size)) = value;
		}
	}

	public unsafe byte apartment_state
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_apartment_state);
			return *(byte*)num;
		}
		set
		{
			*(byte*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_apartment_state)) = value;
		}
	}

	public unsafe int critical_region_level
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_critical_region_level);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_critical_region_level)) = value;
		}
	}

	public unsafe int managed_id
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_managed_id);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_managed_id)) = value;
		}
	}

	public unsafe int small_id
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_small_id);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_small_id)) = value;
		}
	}

	public unsafe System.IntPtr manage_callback
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_manage_callback);
			return *(System.IntPtr*)num;
		}
		set
		{
			*(System.IntPtr*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_manage_callback)) = value;
		}
	}

	public unsafe System.IntPtr flags
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_flags);
			return *(System.IntPtr*)num;
		}
		set
		{
			*(System.IntPtr*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_flags)) = value;
		}
	}

	public unsafe System.IntPtr thread_pinning_ref
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_thread_pinning_ref);
			return *(System.IntPtr*)num;
		}
		set
		{
			*(System.IntPtr*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_thread_pinning_ref)) = value;
		}
	}

	public unsafe System.IntPtr abort_protected_block_count
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_abort_protected_block_count);
			return *(System.IntPtr*)num;
		}
		set
		{
			*(System.IntPtr*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_abort_protected_block_count)) = value;
		}
	}

	public unsafe int priority
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_priority);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_priority)) = value;
		}
	}

	public unsafe System.IntPtr owned_mutex
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_owned_mutex);
			return *(System.IntPtr*)num;
		}
		set
		{
			*(System.IntPtr*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_owned_mutex)) = value;
		}
	}

	public unsafe System.IntPtr suspended_event
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_suspended_event);
			return *(System.IntPtr*)num;
		}
		set
		{
			*(System.IntPtr*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_suspended_event)) = value;
		}
	}

	public unsafe int self_suspended
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_self_suspended);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_self_suspended)) = value;
		}
	}

	public unsafe System.IntPtr thread_state
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_thread_state);
			return *(System.IntPtr*)num;
		}
		set
		{
			*(System.IntPtr*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_thread_state)) = value;
		}
	}

	public unsafe System.IntPtr netcore0
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_netcore0);
			return *(System.IntPtr*)num;
		}
		set
		{
			*(System.IntPtr*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_netcore0)) = value;
		}
	}

	public unsafe System.IntPtr netcore1
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_netcore1);
			return *(System.IntPtr*)num;
		}
		set
		{
			*(System.IntPtr*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_netcore1)) = value;
		}
	}

	public unsafe System.IntPtr netcore2
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_netcore2);
			return *(System.IntPtr*)num;
		}
		set
		{
			*(System.IntPtr*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_netcore2)) = value;
		}
	}

	public unsafe System.IntPtr last
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_last);
			return *(System.IntPtr*)num;
		}
		set
		{
			*(System.IntPtr*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_last)) = value;
		}
	}

	static InternalThread()
	{
		Il2CppClassPointerStore<InternalThread>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Threading", "InternalThread");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InternalThread>.NativeClassPtr);
		NativeFieldInfoPtr_lock_thread_id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InternalThread>.NativeClassPtr, "lock_thread_id");
		NativeFieldInfoPtr_handle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InternalThread>.NativeClassPtr, "handle");
		NativeFieldInfoPtr_native_handle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InternalThread>.NativeClassPtr, "native_handle");
		NativeFieldInfoPtr_name_chars = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InternalThread>.NativeClassPtr, "name_chars");
		NativeFieldInfoPtr_name_free = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InternalThread>.NativeClassPtr, "name_free");
		NativeFieldInfoPtr_name_length = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InternalThread>.NativeClassPtr, "name_length");
		NativeFieldInfoPtr_state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InternalThread>.NativeClassPtr, "state");
		NativeFieldInfoPtr_abort_exc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InternalThread>.NativeClassPtr, "abort_exc");
		NativeFieldInfoPtr_abort_state_handle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InternalThread>.NativeClassPtr, "abort_state_handle");
		NativeFieldInfoPtr_thread_id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InternalThread>.NativeClassPtr, "thread_id");
		NativeFieldInfoPtr_debugger_thread = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InternalThread>.NativeClassPtr, "debugger_thread");
		NativeFieldInfoPtr_static_data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InternalThread>.NativeClassPtr, "static_data");
		NativeFieldInfoPtr_runtime_thread_info = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InternalThread>.NativeClassPtr, "runtime_thread_info");
		NativeFieldInfoPtr_current_appcontext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InternalThread>.NativeClassPtr, "current_appcontext");
		NativeFieldInfoPtr_root_domain_thread = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InternalThread>.NativeClassPtr, "root_domain_thread");
		NativeFieldInfoPtr__serialized_principal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InternalThread>.NativeClassPtr, "_serialized_principal");
		NativeFieldInfoPtr__serialized_principal_version = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InternalThread>.NativeClassPtr, "_serialized_principal_version");
		NativeFieldInfoPtr_appdomain_refs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InternalThread>.NativeClassPtr, "appdomain_refs");
		NativeFieldInfoPtr_interruption_requested = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InternalThread>.NativeClassPtr, "interruption_requested");
		NativeFieldInfoPtr_longlived = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InternalThread>.NativeClassPtr, "longlived");
		NativeFieldInfoPtr_threadpool_thread = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InternalThread>.NativeClassPtr, "threadpool_thread");
		NativeFieldInfoPtr_thread_interrupt_requested = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InternalThread>.NativeClassPtr, "thread_interrupt_requested");
		NativeFieldInfoPtr_stack_size = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InternalThread>.NativeClassPtr, "stack_size");
		NativeFieldInfoPtr_apartment_state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InternalThread>.NativeClassPtr, "apartment_state");
		NativeFieldInfoPtr_critical_region_level = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InternalThread>.NativeClassPtr, "critical_region_level");
		NativeFieldInfoPtr_managed_id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InternalThread>.NativeClassPtr, "managed_id");
		NativeFieldInfoPtr_small_id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InternalThread>.NativeClassPtr, "small_id");
		NativeFieldInfoPtr_manage_callback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InternalThread>.NativeClassPtr, "manage_callback");
		NativeFieldInfoPtr_flags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InternalThread>.NativeClassPtr, "flags");
		NativeFieldInfoPtr_thread_pinning_ref = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InternalThread>.NativeClassPtr, "thread_pinning_ref");
		NativeFieldInfoPtr_abort_protected_block_count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InternalThread>.NativeClassPtr, "abort_protected_block_count");
		NativeFieldInfoPtr_priority = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InternalThread>.NativeClassPtr, "priority");
		NativeFieldInfoPtr_owned_mutex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InternalThread>.NativeClassPtr, "owned_mutex");
		NativeFieldInfoPtr_suspended_event = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InternalThread>.NativeClassPtr, "suspended_event");
		NativeFieldInfoPtr_self_suspended = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InternalThread>.NativeClassPtr, "self_suspended");
		NativeFieldInfoPtr_thread_state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InternalThread>.NativeClassPtr, "thread_state");
		NativeFieldInfoPtr_netcore0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InternalThread>.NativeClassPtr, "netcore0");
		NativeFieldInfoPtr_netcore1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InternalThread>.NativeClassPtr, "netcore1");
		NativeFieldInfoPtr_netcore2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InternalThread>.NativeClassPtr, "netcore2");
		NativeFieldInfoPtr_last = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InternalThread>.NativeClassPtr, "last");
		NativeMethodInfoPtr_Thread_free_internal_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InternalThread>.NativeClassPtr, 100668059);
		NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InternalThread>.NativeClassPtr, 100668060);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InternalThread>.NativeClassPtr, 100668061);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 772333, XrefRangeEnd = 772334, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Thread_free_internal()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Thread_free_internal_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 772334, XrefRangeEnd = 772338, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public new unsafe void Finalize()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 772338, XrefRangeEnd = 772339, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe InternalThread()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InternalThread>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public InternalThread(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
