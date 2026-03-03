using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;
using Il2CppSystem.Runtime.ExceptionServices;
using Il2CppSystem.Runtime.Remoting.Contexts;
using Il2CppSystem.Runtime.Remoting.Messaging;
using Il2CppSystem.Security.Policy;
using Il2CppSystem.Threading;

namespace Il2CppSystem;

public sealed class AppDomain : MarshalByRefObject
{
	private static readonly System.IntPtr NativeFieldInfoPtr__mono_app_domain;

	private static readonly System.IntPtr NativeFieldInfoPtr__process_guid;

	private static readonly System.IntPtr NativeFieldInfoPtr_type_resolve_in_progress;

	private static readonly System.IntPtr NativeFieldInfoPtr_assembly_resolve_in_progress;

	private static readonly System.IntPtr NativeFieldInfoPtr_assembly_resolve_in_progress_refonly;

	private static readonly System.IntPtr NativeFieldInfoPtr__evidence;

	private static readonly System.IntPtr NativeFieldInfoPtr__granted;

	private static readonly System.IntPtr NativeFieldInfoPtr__principalPolicy;

	private static readonly System.IntPtr NativeFieldInfoPtr_AssemblyLoad;

	private static readonly System.IntPtr NativeFieldInfoPtr_AssemblyResolve;

	private static readonly System.IntPtr NativeFieldInfoPtr_DomainUnload;

	private static readonly System.IntPtr NativeFieldInfoPtr_ProcessExit;

	private static readonly System.IntPtr NativeFieldInfoPtr_ResourceResolve;

	private static readonly System.IntPtr NativeFieldInfoPtr_TypeResolve;

	private static readonly System.IntPtr NativeFieldInfoPtr_UnhandledException;

	private static readonly System.IntPtr NativeFieldInfoPtr_FirstChanceException;

	private static readonly System.IntPtr NativeFieldInfoPtr__domain_manager;

	private static readonly System.IntPtr NativeFieldInfoPtr_ReflectionOnlyAssemblyResolve;

	private static readonly System.IntPtr NativeFieldInfoPtr__activation;

	private static readonly System.IntPtr NativeFieldInfoPtr__applicationIdentity;

	private static readonly System.IntPtr NativeFieldInfoPtr_compatibility_switch;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsAppXModel_Internal_Static_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_getFriendlyName_Private_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_getCurDomain_Private_Static_AppDomain_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_CurrentDomain_Public_Static_get_AppDomain_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetAssemblies_Private_Il2CppReferenceArray_1_Assembly_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetAssemblies_Public_Virtual_Final_New_Il2CppReferenceArray_1_Assembly_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetData_Public_Virtual_Final_New_Object_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InitializeLifetimeService_Public_Virtual_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LoadAssembly_Internal_Assembly_String_Evidence_Boolean_byref_StackCrawlMark_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Load_Public_Virtual_Final_New_Assembly_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Load_Internal_Assembly_String_Evidence_Boolean_byref_StackCrawlMark_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InternalSetDomainByID_Private_Static_AppDomain_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InternalSetDomain_Private_Static_AppDomain_AppDomain_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InternalPushDomainRefByID_Internal_Static_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InternalPopDomainRef_Internal_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InternalSetContext_Internal_Static_Context_Context_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InternalGetContext_Internal_Static_Context_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InternalGetDefaultContext_Internal_Static_Context_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InternalGetProcessGuid_Internal_Static_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InvokeInDomainByID_Internal_Static_Object_Int32_MethodInfo_Object_Il2CppReferenceArray_1_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetProcessGuid_Internal_Static_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InternalIsFinalizingForUnload_Private_Static_Boolean_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsFinalizingForUnload_Public_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_getDomainID_Private_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DoAssemblyLoad_Private_Void_Assembly_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DoAssemblyResolve_Private_Assembly_String_Assembly_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DoTypeResolve_Internal_Assembly_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DoDomainUnload_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetMarshalledDomainObjRef_Internal_Il2CppStructArray_1_Byte_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ProcessMessageInDomain_Internal_Void_Il2CppStructArray_1_Byte_CADMethodCallMessage_byref_Il2CppStructArray_1_Byte_byref_CADMethodReturnMessage_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_add_DomainUnload_Public_Virtual_Final_New_add_Void_EventHandler_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_remove_DomainUnload_Public_Virtual_Final_New_rem_Void_EventHandler_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_add_UnhandledException_Public_Virtual_Final_New_add_Void_UnhandledExceptionEventHandler_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_remove_UnhandledException_Public_Virtual_Final_New_rem_Void_UnhandledExceptionEventHandler_0;

	public unsafe System.IntPtr _mono_app_domain
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__mono_app_domain);
			return *(System.IntPtr*)num;
		}
		set
		{
			*(System.IntPtr*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__mono_app_domain)) = value;
		}
	}

	public unsafe static string _process_guid
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__process_guid, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__process_guid, (void*)IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe static Dictionary<string, Object> type_resolve_in_progress
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_type_resolve_in_progress, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<string, Object>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_type_resolve_in_progress, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Dictionary<string, Object> assembly_resolve_in_progress
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_assembly_resolve_in_progress, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<string, Object>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_assembly_resolve_in_progress, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Dictionary<string, Object> assembly_resolve_in_progress_refonly
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_assembly_resolve_in_progress_refonly, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<string, Object>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_assembly_resolve_in_progress_refonly, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe Object _evidence
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__evidence);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Object>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__evidence)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe Object _granted
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__granted);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Object>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__granted)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe int _principalPolicy
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__principalPolicy);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__principalPolicy)) = value;
		}
	}

	public unsafe AssemblyLoadEventHandler AssemblyLoad
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_AssemblyLoad);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<AssemblyLoadEventHandler>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_AssemblyLoad)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe ResolveEventHandler AssemblyResolve
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_AssemblyResolve);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ResolveEventHandler>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_AssemblyResolve)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe EventHandler DomainUnload
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DomainUnload);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<EventHandler>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DomainUnload)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe EventHandler ProcessExit
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ProcessExit);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<EventHandler>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ProcessExit)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe ResolveEventHandler ResourceResolve
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ResourceResolve);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ResolveEventHandler>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ResourceResolve)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe ResolveEventHandler TypeResolve
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_TypeResolve);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ResolveEventHandler>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_TypeResolve)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe UnhandledExceptionEventHandler UnhandledException
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_UnhandledException);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<UnhandledExceptionEventHandler>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_UnhandledException)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe EventHandler<FirstChanceExceptionEventArgs> FirstChanceException
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_FirstChanceException);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<EventHandler<FirstChanceExceptionEventArgs>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_FirstChanceException)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe Object _domain_manager
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__domain_manager);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Object>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__domain_manager)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe ResolveEventHandler ReflectionOnlyAssemblyResolve
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ReflectionOnlyAssemblyResolve);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ResolveEventHandler>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ReflectionOnlyAssemblyResolve)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe Object _activation
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__activation);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Object>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__activation)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe Object _applicationIdentity
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__applicationIdentity);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Object>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__applicationIdentity)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe List<string> compatibility_switch
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_compatibility_switch);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<string>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_compatibility_switch)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static AppDomain CurrentDomain
	{
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 758768, RefRangeEnd = 758779, XrefRangeStart = 758768, XrefRangeEnd = 758779, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_CurrentDomain_Public_Static_get_AppDomain_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<AppDomain>(intPtr2) : null;
		}
	}

	static AppDomain()
	{
		Il2CppClassPointerStore<AppDomain>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "AppDomain");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AppDomain>.NativeClassPtr);
		NativeFieldInfoPtr__mono_app_domain = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppDomain>.NativeClassPtr, "_mono_app_domain");
		NativeFieldInfoPtr__process_guid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppDomain>.NativeClassPtr, "_process_guid");
		NativeFieldInfoPtr_type_resolve_in_progress = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppDomain>.NativeClassPtr, "type_resolve_in_progress");
		NativeFieldInfoPtr_assembly_resolve_in_progress = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppDomain>.NativeClassPtr, "assembly_resolve_in_progress");
		NativeFieldInfoPtr_assembly_resolve_in_progress_refonly = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppDomain>.NativeClassPtr, "assembly_resolve_in_progress_refonly");
		NativeFieldInfoPtr__evidence = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppDomain>.NativeClassPtr, "_evidence");
		NativeFieldInfoPtr__granted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppDomain>.NativeClassPtr, "_granted");
		NativeFieldInfoPtr__principalPolicy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppDomain>.NativeClassPtr, "_principalPolicy");
		NativeFieldInfoPtr_AssemblyLoad = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppDomain>.NativeClassPtr, "AssemblyLoad");
		NativeFieldInfoPtr_AssemblyResolve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppDomain>.NativeClassPtr, "AssemblyResolve");
		NativeFieldInfoPtr_DomainUnload = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppDomain>.NativeClassPtr, "DomainUnload");
		NativeFieldInfoPtr_ProcessExit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppDomain>.NativeClassPtr, "ProcessExit");
		NativeFieldInfoPtr_ResourceResolve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppDomain>.NativeClassPtr, "ResourceResolve");
		NativeFieldInfoPtr_TypeResolve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppDomain>.NativeClassPtr, "TypeResolve");
		NativeFieldInfoPtr_UnhandledException = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppDomain>.NativeClassPtr, "UnhandledException");
		NativeFieldInfoPtr_FirstChanceException = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppDomain>.NativeClassPtr, "FirstChanceException");
		NativeFieldInfoPtr__domain_manager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppDomain>.NativeClassPtr, "_domain_manager");
		NativeFieldInfoPtr_ReflectionOnlyAssemblyResolve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppDomain>.NativeClassPtr, "ReflectionOnlyAssemblyResolve");
		NativeFieldInfoPtr__activation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppDomain>.NativeClassPtr, "_activation");
		NativeFieldInfoPtr__applicationIdentity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppDomain>.NativeClassPtr, "_applicationIdentity");
		NativeFieldInfoPtr_compatibility_switch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppDomain>.NativeClassPtr, "compatibility_switch");
		NativeMethodInfoPtr_IsAppXModel_Internal_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppDomain>.NativeClassPtr, 100666972);
		NativeMethodInfoPtr__ctor_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppDomain>.NativeClassPtr, 100666973);
		NativeMethodInfoPtr_getFriendlyName_Private_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppDomain>.NativeClassPtr, 100666974);
		NativeMethodInfoPtr_getCurDomain_Private_Static_AppDomain_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppDomain>.NativeClassPtr, 100666975);
		NativeMethodInfoPtr_get_CurrentDomain_Public_Static_get_AppDomain_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppDomain>.NativeClassPtr, 100666976);
		NativeMethodInfoPtr_GetAssemblies_Private_Il2CppReferenceArray_1_Assembly_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppDomain>.NativeClassPtr, 100666977);
		NativeMethodInfoPtr_GetAssemblies_Public_Virtual_Final_New_Il2CppReferenceArray_1_Assembly_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppDomain>.NativeClassPtr, 100666978);
		NativeMethodInfoPtr_GetData_Public_Virtual_Final_New_Object_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppDomain>.NativeClassPtr, 100666979);
		NativeMethodInfoPtr_InitializeLifetimeService_Public_Virtual_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppDomain>.NativeClassPtr, 100666980);
		NativeMethodInfoPtr_LoadAssembly_Internal_Assembly_String_Evidence_Boolean_byref_StackCrawlMark_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppDomain>.NativeClassPtr, 100666981);
		NativeMethodInfoPtr_Load_Public_Virtual_Final_New_Assembly_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppDomain>.NativeClassPtr, 100666982);
		NativeMethodInfoPtr_Load_Internal_Assembly_String_Evidence_Boolean_byref_StackCrawlMark_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppDomain>.NativeClassPtr, 100666983);
		NativeMethodInfoPtr_InternalSetDomainByID_Private_Static_AppDomain_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppDomain>.NativeClassPtr, 100666984);
		NativeMethodInfoPtr_InternalSetDomain_Private_Static_AppDomain_AppDomain_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppDomain>.NativeClassPtr, 100666985);
		NativeMethodInfoPtr_InternalPushDomainRefByID_Internal_Static_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppDomain>.NativeClassPtr, 100666986);
		NativeMethodInfoPtr_InternalPopDomainRef_Internal_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppDomain>.NativeClassPtr, 100666987);
		NativeMethodInfoPtr_InternalSetContext_Internal_Static_Context_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppDomain>.NativeClassPtr, 100666988);
		NativeMethodInfoPtr_InternalGetContext_Internal_Static_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppDomain>.NativeClassPtr, 100666989);
		NativeMethodInfoPtr_InternalGetDefaultContext_Internal_Static_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppDomain>.NativeClassPtr, 100666990);
		NativeMethodInfoPtr_InternalGetProcessGuid_Internal_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppDomain>.NativeClassPtr, 100666991);
		NativeMethodInfoPtr_InvokeInDomainByID_Internal_Static_Object_Int32_MethodInfo_Object_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppDomain>.NativeClassPtr, 100666992);
		NativeMethodInfoPtr_GetProcessGuid_Internal_Static_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppDomain>.NativeClassPtr, 100666993);
		NativeMethodInfoPtr_InternalIsFinalizingForUnload_Private_Static_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppDomain>.NativeClassPtr, 100666994);
		NativeMethodInfoPtr_IsFinalizingForUnload_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppDomain>.NativeClassPtr, 100666995);
		NativeMethodInfoPtr_getDomainID_Private_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppDomain>.NativeClassPtr, 100666996);
		NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppDomain>.NativeClassPtr, 100666997);
		NativeMethodInfoPtr_DoAssemblyLoad_Private_Void_Assembly_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppDomain>.NativeClassPtr, 100666998);
		NativeMethodInfoPtr_DoAssemblyResolve_Private_Assembly_String_Assembly_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppDomain>.NativeClassPtr, 100666999);
		NativeMethodInfoPtr_DoTypeResolve_Internal_Assembly_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppDomain>.NativeClassPtr, 100667000);
		NativeMethodInfoPtr_DoDomainUnload_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppDomain>.NativeClassPtr, 100667001);
		NativeMethodInfoPtr_GetMarshalledDomainObjRef_Internal_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppDomain>.NativeClassPtr, 100667002);
		NativeMethodInfoPtr_ProcessMessageInDomain_Internal_Void_Il2CppStructArray_1_Byte_CADMethodCallMessage_byref_Il2CppStructArray_1_Byte_byref_CADMethodReturnMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppDomain>.NativeClassPtr, 100667003);
		NativeMethodInfoPtr_add_DomainUnload_Public_Virtual_Final_New_add_Void_EventHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppDomain>.NativeClassPtr, 100667004);
		NativeMethodInfoPtr_remove_DomainUnload_Public_Virtual_Final_New_rem_Void_EventHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppDomain>.NativeClassPtr, 100667005);
		NativeMethodInfoPtr_add_UnhandledException_Public_Virtual_Final_New_add_Void_UnhandledExceptionEventHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppDomain>.NativeClassPtr, 100667006);
		NativeMethodInfoPtr_remove_UnhandledException_Public_Virtual_Final_New_rem_Void_UnhandledExceptionEventHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppDomain>.NativeClassPtr, 100667007);
	}

	[CallerCount(143)]
	[CachedScanResults(RefRangeStart = 9, RefRangeEnd = 152, XrefRangeStart = 9, XrefRangeEnd = 152, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool IsAppXModel()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsAppXModel_Internal_Static_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(19883)]
	[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 20035, XrefRangeStart = 152, XrefRangeEnd = 20035, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AppDomain()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AppDomain>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 758766, XrefRangeEnd = 758767, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string getFriendlyName()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_getFriendlyName_Private_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(11)]
	[CachedScanResults(RefRangeStart = 758768, RefRangeEnd = 758779, XrefRangeStart = 758767, XrefRangeEnd = 758768, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static AppDomain getCurDomain()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_getCurDomain_Private_Static_AppDomain_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<AppDomain>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 758779, XrefRangeEnd = 758780, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Il2CppReferenceArray<Assembly> GetAssemblies(bool refOnly)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&refOnly);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetAssemblies_Private_Il2CppReferenceArray_1_Assembly_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Assembly>>(intPtr2) : null;
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 758781, RefRangeEnd = 758785, XrefRangeStart = 758780, XrefRangeEnd = 758781, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual Il2CppReferenceArray<Assembly> GetAssemblies()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetAssemblies_Public_Virtual_Final_New_Il2CppReferenceArray_1_Assembly_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Assembly>>(intPtr2) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 758786, RefRangeEnd = 758787, XrefRangeStart = 758785, XrefRangeEnd = 758786, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual Object GetData(string name)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetData_Public_Virtual_Final_New_Object_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
	}

	[CallerCount(146)]
	[CachedScanResults(RefRangeStart = 35395, RefRangeEnd = 35541, XrefRangeStart = 35395, XrefRangeEnd = 35541, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override Object InitializeLifetimeService()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InitializeLifetimeService_Public_Virtual_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 758787, XrefRangeEnd = 758788, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Assembly LoadAssembly(string assemblyRef, Evidence securityEvidence, bool refOnly, ref StackCrawlMark stackMark)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(assemblyRef);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)securityEvidence);
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &refOnly;
		*(void**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref stackMark);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LoadAssembly_Internal_Assembly_String_Evidence_Boolean_byref_StackCrawlMark_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Assembly>(intPtr2) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 758790, RefRangeEnd = 758791, XrefRangeStart = 758788, XrefRangeEnd = 758790, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual Assembly Load(string assemblyString)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(assemblyString);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Load_Public_Virtual_Final_New_Assembly_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Assembly>(intPtr2) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 758793, RefRangeEnd = 758794, XrefRangeStart = 758791, XrefRangeEnd = 758793, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Assembly Load(string assemblyString, Evidence assemblySecurity, bool refonly, ref StackCrawlMark stackMark)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(assemblyString);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)assemblySecurity);
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &refonly;
		*(void**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref stackMark);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Load_Internal_Assembly_String_Evidence_Boolean_byref_StackCrawlMark_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Assembly>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 758794, XrefRangeEnd = 758795, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static AppDomain InternalSetDomainByID(int domain_id)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&domain_id);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InternalSetDomainByID_Private_Static_AppDomain_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<AppDomain>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 758795, XrefRangeEnd = 758796, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static AppDomain InternalSetDomain(AppDomain context)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)context);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InternalSetDomain_Private_Static_AppDomain_AppDomain_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<AppDomain>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 758796, XrefRangeEnd = 758797, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void InternalPushDomainRefByID(int domain_id)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&domain_id);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InternalPushDomainRefByID_Internal_Static_Void_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 758797, XrefRangeEnd = 758798, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void InternalPopDomainRef()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InternalPopDomainRef_Internal_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(13)]
	[CachedScanResults(RefRangeStart = 758799, RefRangeEnd = 758812, XrefRangeStart = 758798, XrefRangeEnd = 758799, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Context InternalSetContext(Context context)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)context);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InternalSetContext_Internal_Static_Context_Context_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Context>(intPtr2) : null;
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 758813, RefRangeEnd = 758818, XrefRangeStart = 758812, XrefRangeEnd = 758813, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Context InternalGetContext()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InternalGetContext_Internal_Static_Context_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Context>(intPtr2) : null;
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 758813, RefRangeEnd = 758818, XrefRangeStart = 758813, XrefRangeEnd = 758818, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Context InternalGetDefaultContext()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InternalGetDefaultContext_Internal_Static_Context_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Context>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 758818, XrefRangeEnd = 758819, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string InternalGetProcessGuid(string newguid)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(newguid);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InternalGetProcessGuid_Internal_Static_String_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 758830, RefRangeEnd = 758831, XrefRangeStart = 758819, XrefRangeEnd = 758830, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Object InvokeInDomainByID(int domain_id, MethodInfo method, Object obj, Il2CppReferenceArray<Object> args)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&domain_id);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)method);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)obj);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)args);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InvokeInDomainByID_Internal_Static_Object_Int32_MethodInfo_Object_Il2CppReferenceArray_1_Object_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 758840, RefRangeEnd = 758841, XrefRangeStart = 758831, XrefRangeEnd = 758840, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string GetProcessGuid()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetProcessGuid_Internal_Static_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool InternalIsFinalizingForUnload(int domain_id)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&domain_id);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InternalIsFinalizingForUnload_Private_Static_Boolean_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 758843, RefRangeEnd = 758844, XrefRangeStart = 758841, XrefRangeEnd = 758843, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool IsFinalizingForUnload()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsFinalizingForUnload_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 758844, XrefRangeEnd = 758845, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int getDomainID()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_getDomainID_Private_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override string ToString()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToString_Public_Virtual_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 758845, XrefRangeEnd = 758849, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void DoAssemblyLoad(Assembly assembly)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)assembly);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DoAssemblyLoad_Private_Void_Assembly_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 758849, XrefRangeEnd = 758896, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Assembly DoAssemblyResolve(string name, Assembly requestingAssembly, bool refonly)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)requestingAssembly);
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &refonly;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DoAssemblyResolve_Private_Assembly_String_Assembly_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Assembly>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 758896, XrefRangeEnd = 758934, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Assembly DoTypeResolve(string name)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DoTypeResolve_Internal_Assembly_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Assembly>(intPtr2) : null;
	}

	[CallerCount(0)]
	public unsafe void DoDomainUnload()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DoDomainUnload_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 758934, XrefRangeEnd = 758946, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Il2CppStructArray<byte> GetMarshalledDomainObjRef()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetMarshalledDomainObjRef_Internal_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 758966, RefRangeEnd = 758967, XrefRangeStart = 758946, XrefRangeEnd = 758966, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ProcessMessageInDomain(Il2CppStructArray<byte> arrRequest, CADMethodCallMessage cadMsg, out Il2CppStructArray<byte> arrResponse, out CADMethodReturnMessage cadMrm)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)arrRequest);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cadMsg);
		byte* num = (byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)));
		nint num2 = 0;
		*(nint**)num = &num2;
		byte* num3 = (byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)));
		nint num4 = 0;
		*(nint**)num3 = &num4;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ProcessMessageInDomain_Internal_Void_Il2CppStructArray_1_Byte_CADMethodCallMessage_byref_Il2CppStructArray_1_Byte_byref_CADMethodReturnMessage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		nint num5 = num2;
		arrResponse = ((num5 == 0) ? null : new Il2CppStructArray<byte>((System.IntPtr)num5));
		nint num6 = num4;
		cadMrm = ((num6 == 0) ? null : new CADMethodReturnMessage(num6));
	}

	[SpecialName]
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 758971, RefRangeEnd = 758972, XrefRangeStart = 758967, XrefRangeEnd = 758971, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void add_DomainUnload(EventHandler value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_add_DomainUnload_Public_Virtual_Final_New_add_Void_EventHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[SpecialName]
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 758972, XrefRangeEnd = 758976, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void remove_DomainUnload(EventHandler value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_remove_DomainUnload_Public_Virtual_Final_New_rem_Void_EventHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[SpecialName]
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 758980, RefRangeEnd = 758981, XrefRangeStart = 758976, XrefRangeEnd = 758980, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void add_UnhandledException(UnhandledExceptionEventHandler value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_add_UnhandledException_Public_Virtual_Final_New_add_Void_UnhandledExceptionEventHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[SpecialName]
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 758981, XrefRangeEnd = 758985, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void remove_UnhandledException(UnhandledExceptionEventHandler value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_remove_UnhandledException_Public_Virtual_Final_New_rem_Void_UnhandledExceptionEventHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public AppDomain(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
