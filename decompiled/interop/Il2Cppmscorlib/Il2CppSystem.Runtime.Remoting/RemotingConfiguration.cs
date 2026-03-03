using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;

namespace Il2CppSystem.Runtime.Remoting;

public static class RemotingConfiguration : Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_applicationID;

	private static readonly System.IntPtr NativeFieldInfoPtr_applicationName;

	private static readonly System.IntPtr NativeFieldInfoPtr_processGuid;

	private static readonly System.IntPtr NativeFieldInfoPtr_defaultConfigRead;

	private static readonly System.IntPtr NativeFieldInfoPtr_defaultDelayedConfigRead;

	private static readonly System.IntPtr NativeFieldInfoPtr__errorMode;

	private static readonly System.IntPtr NativeFieldInfoPtr_wellKnownClientEntries;

	private static readonly System.IntPtr NativeFieldInfoPtr_activatedClientEntries;

	private static readonly System.IntPtr NativeFieldInfoPtr_wellKnownServiceEntries;

	private static readonly System.IntPtr NativeFieldInfoPtr_activatedServiceEntries;

	private static readonly System.IntPtr NativeFieldInfoPtr_channelTemplates;

	private static readonly System.IntPtr NativeFieldInfoPtr_clientProviderTemplates;

	private static readonly System.IntPtr NativeFieldInfoPtr_serverProviderTemplates;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_ApplicationName_Public_Static_get_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_ApplicationName_Public_Static_set_Void_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_ProcessId_Public_Static_get_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LoadDefaultDelayedChannels_Internal_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsActivationAllowed_Public_Static_Boolean_Type_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsRemotelyActivatedClientType_Public_Static_ActivatedClientTypeEntry_Type_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsWellKnownClientType_Public_Static_WellKnownClientTypeEntry_Type_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RegisterActivatedClientType_Public_Static_Void_ActivatedClientTypeEntry_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RegisterActivatedServiceType_Public_Static_Void_ActivatedServiceTypeEntry_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RegisterWellKnownClientType_Public_Static_Void_WellKnownClientTypeEntry_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RegisterWellKnownServiceType_Public_Static_Void_WellKnownServiceTypeEntry_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RegisterChannelTemplate_Internal_Static_Void_ChannelData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RegisterClientProviderTemplate_Internal_Static_Void_ProviderData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RegisterServerProviderTemplate_Internal_Static_Void_ProviderData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RegisterChannels_Internal_Static_Void_ArrayList_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RegisterTypes_Internal_Static_Void_ArrayList_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CustomErrorsEnabled_Public_Static_Boolean_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetCustomErrorsMode_Internal_Static_Void_String_0;

	public unsafe static string applicationID
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_applicationID, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_applicationID, (void*)IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe static string applicationName
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_applicationName, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_applicationName, (void*)IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe static string processGuid
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_processGuid, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_processGuid, (void*)IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe static bool defaultConfigRead
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_defaultConfigRead, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_defaultConfigRead, (void*)(&value));
		}
	}

	public unsafe static bool defaultDelayedConfigRead
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_defaultDelayedConfigRead, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_defaultDelayedConfigRead, (void*)(&value));
		}
	}

	public unsafe static CustomErrorsModes _errorMode
	{
		get
		{
			Unsafe.SkipInit(out CustomErrorsModes result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__errorMode, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__errorMode, (void*)(&value));
		}
	}

	public unsafe static Hashtable wellKnownClientEntries
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_wellKnownClientEntries, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Hashtable>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_wellKnownClientEntries, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Hashtable activatedClientEntries
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_activatedClientEntries, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Hashtable>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_activatedClientEntries, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Hashtable wellKnownServiceEntries
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_wellKnownServiceEntries, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Hashtable>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_wellKnownServiceEntries, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Hashtable activatedServiceEntries
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_activatedServiceEntries, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Hashtable>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_activatedServiceEntries, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Hashtable channelTemplates
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_channelTemplates, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Hashtable>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_channelTemplates, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Hashtable clientProviderTemplates
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_clientProviderTemplates, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Hashtable>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_clientProviderTemplates, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Hashtable serverProviderTemplates
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_serverProviderTemplates, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Hashtable>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_serverProviderTemplates, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static string ApplicationName
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 790051, XrefRangeEnd = 790055, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_ApplicationName_Public_Static_get_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return IL2CPP.Il2CppStringToManaged(intPtr2);
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 790055, XrefRangeEnd = 790061, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_ApplicationName_Public_Static_set_Void_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe static string ProcessId
	{
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 790074, RefRangeEnd = 790077, XrefRangeStart = 790061, XrefRangeEnd = 790074, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_ProcessId_Public_Static_get_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return IL2CPP.Il2CppStringToManaged(intPtr2);
		}
	}

	static RemotingConfiguration()
	{
		Il2CppClassPointerStore<RemotingConfiguration>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Remoting", "RemotingConfiguration");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RemotingConfiguration>.NativeClassPtr);
		NativeFieldInfoPtr_applicationID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemotingConfiguration>.NativeClassPtr, "applicationID");
		NativeFieldInfoPtr_applicationName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemotingConfiguration>.NativeClassPtr, "applicationName");
		NativeFieldInfoPtr_processGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemotingConfiguration>.NativeClassPtr, "processGuid");
		NativeFieldInfoPtr_defaultConfigRead = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemotingConfiguration>.NativeClassPtr, "defaultConfigRead");
		NativeFieldInfoPtr_defaultDelayedConfigRead = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemotingConfiguration>.NativeClassPtr, "defaultDelayedConfigRead");
		NativeFieldInfoPtr__errorMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemotingConfiguration>.NativeClassPtr, "_errorMode");
		NativeFieldInfoPtr_wellKnownClientEntries = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemotingConfiguration>.NativeClassPtr, "wellKnownClientEntries");
		NativeFieldInfoPtr_activatedClientEntries = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemotingConfiguration>.NativeClassPtr, "activatedClientEntries");
		NativeFieldInfoPtr_wellKnownServiceEntries = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemotingConfiguration>.NativeClassPtr, "wellKnownServiceEntries");
		NativeFieldInfoPtr_activatedServiceEntries = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemotingConfiguration>.NativeClassPtr, "activatedServiceEntries");
		NativeFieldInfoPtr_channelTemplates = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemotingConfiguration>.NativeClassPtr, "channelTemplates");
		NativeFieldInfoPtr_clientProviderTemplates = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemotingConfiguration>.NativeClassPtr, "clientProviderTemplates");
		NativeFieldInfoPtr_serverProviderTemplates = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemotingConfiguration>.NativeClassPtr, "serverProviderTemplates");
		NativeMethodInfoPtr_get_ApplicationName_Public_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemotingConfiguration>.NativeClassPtr, 100669832);
		NativeMethodInfoPtr_set_ApplicationName_Public_Static_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemotingConfiguration>.NativeClassPtr, 100669833);
		NativeMethodInfoPtr_get_ProcessId_Public_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemotingConfiguration>.NativeClassPtr, 100669834);
		NativeMethodInfoPtr_LoadDefaultDelayedChannels_Internal_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemotingConfiguration>.NativeClassPtr, 100669835);
		NativeMethodInfoPtr_IsActivationAllowed_Public_Static_Boolean_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemotingConfiguration>.NativeClassPtr, 100669836);
		NativeMethodInfoPtr_IsRemotelyActivatedClientType_Public_Static_ActivatedClientTypeEntry_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemotingConfiguration>.NativeClassPtr, 100669837);
		NativeMethodInfoPtr_IsWellKnownClientType_Public_Static_WellKnownClientTypeEntry_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemotingConfiguration>.NativeClassPtr, 100669838);
		NativeMethodInfoPtr_RegisterActivatedClientType_Public_Static_Void_ActivatedClientTypeEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemotingConfiguration>.NativeClassPtr, 100669839);
		NativeMethodInfoPtr_RegisterActivatedServiceType_Public_Static_Void_ActivatedServiceTypeEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemotingConfiguration>.NativeClassPtr, 100669840);
		NativeMethodInfoPtr_RegisterWellKnownClientType_Public_Static_Void_WellKnownClientTypeEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemotingConfiguration>.NativeClassPtr, 100669841);
		NativeMethodInfoPtr_RegisterWellKnownServiceType_Public_Static_Void_WellKnownServiceTypeEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemotingConfiguration>.NativeClassPtr, 100669842);
		NativeMethodInfoPtr_RegisterChannelTemplate_Internal_Static_Void_ChannelData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemotingConfiguration>.NativeClassPtr, 100669843);
		NativeMethodInfoPtr_RegisterClientProviderTemplate_Internal_Static_Void_ProviderData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemotingConfiguration>.NativeClassPtr, 100669844);
		NativeMethodInfoPtr_RegisterServerProviderTemplate_Internal_Static_Void_ProviderData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemotingConfiguration>.NativeClassPtr, 100669845);
		NativeMethodInfoPtr_RegisterChannels_Internal_Static_Void_ArrayList_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemotingConfiguration>.NativeClassPtr, 100669846);
		NativeMethodInfoPtr_RegisterTypes_Internal_Static_Void_ArrayList_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemotingConfiguration>.NativeClassPtr, 100669847);
		NativeMethodInfoPtr_CustomErrorsEnabled_Public_Static_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemotingConfiguration>.NativeClassPtr, 100669848);
		NativeMethodInfoPtr_SetCustomErrorsMode_Internal_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemotingConfiguration>.NativeClassPtr, 100669849);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 790129, RefRangeEnd = 790130, XrefRangeStart = 790077, XrefRangeEnd = 790129, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void LoadDefaultDelayedChannels()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LoadDefaultDelayedChannels_Internal_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 790141, RefRangeEnd = 790142, XrefRangeStart = 790130, XrefRangeEnd = 790141, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool IsActivationAllowed(Type svrType)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)svrType);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsActivationAllowed_Public_Static_Boolean_Type_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 790155, RefRangeEnd = 790156, XrefRangeStart = 790142, XrefRangeEnd = 790155, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static ActivatedClientTypeEntry IsRemotelyActivatedClientType(Type svrType)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)svrType);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsRemotelyActivatedClientType_Public_Static_ActivatedClientTypeEntry_Type_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<ActivatedClientTypeEntry>(intPtr2) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 790169, RefRangeEnd = 790170, XrefRangeStart = 790156, XrefRangeEnd = 790169, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static WellKnownClientTypeEntry IsWellKnownClientType(Type svrType)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)svrType);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsWellKnownClientType_Public_Static_WellKnownClientTypeEntry_Type_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<WellKnownClientTypeEntry>(intPtr2) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 790188, RefRangeEnd = 790189, XrefRangeStart = 790170, XrefRangeEnd = 790188, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void RegisterActivatedClientType(ActivatedClientTypeEntry entry)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)entry);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RegisterActivatedClientType_Public_Static_Void_ActivatedClientTypeEntry_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 790200, RefRangeEnd = 790201, XrefRangeStart = 790189, XrefRangeEnd = 790200, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void RegisterActivatedServiceType(ActivatedServiceTypeEntry entry)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)entry);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RegisterActivatedServiceType_Public_Static_Void_ActivatedServiceTypeEntry_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 790219, RefRangeEnd = 790220, XrefRangeStart = 790201, XrefRangeEnd = 790219, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void RegisterWellKnownClientType(WellKnownClientTypeEntry entry)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)entry);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RegisterWellKnownClientType_Public_Static_Void_WellKnownClientTypeEntry_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 790235, RefRangeEnd = 790236, XrefRangeStart = 790220, XrefRangeEnd = 790235, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void RegisterWellKnownServiceType(WellKnownServiceTypeEntry entry)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)entry);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RegisterWellKnownServiceType_Public_Static_Void_WellKnownServiceTypeEntry_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 790236, XrefRangeEnd = 790241, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void RegisterChannelTemplate(ChannelData channel)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)channel);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RegisterChannelTemplate_Internal_Static_Void_ChannelData_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 790241, XrefRangeEnd = 790246, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void RegisterClientProviderTemplate(ProviderData prov)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)prov);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RegisterClientProviderTemplate_Internal_Static_Void_ProviderData_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 790246, XrefRangeEnd = 790251, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void RegisterServerProviderTemplate(ProviderData prov)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)prov);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RegisterServerProviderTemplate_Internal_Static_Void_ProviderData_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 790317, RefRangeEnd = 790318, XrefRangeStart = 790251, XrefRangeEnd = 790317, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void RegisterChannels(ArrayList channels, bool onlyDelayed)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)channels);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &onlyDelayed;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RegisterChannels_Internal_Static_Void_ArrayList_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 790362, RefRangeEnd = 790363, XrefRangeStart = 790318, XrefRangeEnd = 790362, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void RegisterTypes(ArrayList types)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)types);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RegisterTypes_Internal_Static_Void_ArrayList_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 790369, RefRangeEnd = 790370, XrefRangeStart = 790363, XrefRangeEnd = 790369, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool CustomErrorsEnabled(bool isLocalRequest)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&isLocalRequest);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CustomErrorsEnabled_Public_Static_Boolean_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 790395, RefRangeEnd = 790396, XrefRangeStart = 790370, XrefRangeEnd = 790395, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetCustomErrorsMode(string mode)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(mode);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetCustomErrorsMode_Internal_Static_Void_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public RemotingConfiguration(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
