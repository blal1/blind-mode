using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppMicrosoft.Win32.SafeHandles;
using Il2CppSystem;
using Il2CppSystem.Text;

namespace Il2CppMicrosoft.Win32;

public sealed class RegistryKey : Il2CppSystem.MarshalByRefObject
{
	[OriginalName("mscorlib.dll", "", "StateFlags")]
	[System.Flags]
	public enum StateFlags
	{
		Dirty = 1,
		SystemKey = 2,
		WriteAccess = 4,
		PerfData = 8
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_HKEY_CLASSES_ROOT;

	private static readonly System.IntPtr NativeFieldInfoPtr_HKEY_CURRENT_USER;

	private static readonly System.IntPtr NativeFieldInfoPtr_HKEY_LOCAL_MACHINE;

	private static readonly System.IntPtr NativeFieldInfoPtr_HKEY_USERS;

	private static readonly System.IntPtr NativeFieldInfoPtr_HKEY_PERFORMANCE_DATA;

	private static readonly System.IntPtr NativeFieldInfoPtr_HKEY_CURRENT_CONFIG;

	private static readonly System.IntPtr NativeFieldInfoPtr_HKEY_DYN_DATA;

	private static readonly System.IntPtr NativeFieldInfoPtr_s_hkeyNames;

	private static readonly System.IntPtr NativeFieldInfoPtr__hkey;

	private static readonly System.IntPtr NativeFieldInfoPtr__keyName;

	private static readonly System.IntPtr NativeFieldInfoPtr__remoteKey;

	private static readonly System.IntPtr NativeFieldInfoPtr__state;

	private static readonly System.IntPtr NativeFieldInfoPtr__checkMode;

	private static readonly System.IntPtr NativeFieldInfoPtr__regView;

	private static readonly System.IntPtr NativeMethodInfoPtr_ClosePerfDataKey_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OpenBaseKeyCore_Private_Static_RegistryKey_RegistryHive_RegistryView_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InternalOpenSubKeyCore_Private_RegistryKey_String_Boolean_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InternalSubKeyCountCore_Private_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InternalGetSubKeyNamesCore_Private_Il2CppStringArray_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InternalGetValueCore_Private_Object_String_Object_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Win32Error_Private_Void_Int32_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetRegistryKeyAccess_Private_Static_Int32_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Private_Void_SafeRegistryHandle_Boolean_Boolean_Boolean_Boolean_RegistryView_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OpenBaseKey_Public_Static_RegistryKey_RegistryHive_RegistryView_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OpenSubKey_Public_RegistryKey_String_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InternalSubKeyCount_Private_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetSubKeyNames_Public_Il2CppStringArray_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InternalGetSubKeyNames_Private_Il2CppStringArray_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetValue_Public_Object_String_Object_RegistryValueOptions_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InternalGetValue_Private_Object_String_Object_Boolean_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FixupName_Private_Static_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FixupPath_Private_Static_Void_StringBuilder_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_EnsureNotDisposed_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetSubKeyPermissionCheck_Private_RegistryKeyPermissionCheck_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ValidateKeyName_Private_Static_Void_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ValidateKeyView_Private_Static_Void_RegistryView_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsSystemKey_Private_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsPerfDataKey_Private_Boolean_0;

	public unsafe static System.IntPtr HKEY_CLASSES_ROOT
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_HKEY_CLASSES_ROOT, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_HKEY_CLASSES_ROOT, (void*)(&value));
		}
	}

	public unsafe static System.IntPtr HKEY_CURRENT_USER
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_HKEY_CURRENT_USER, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_HKEY_CURRENT_USER, (void*)(&value));
		}
	}

	public unsafe static System.IntPtr HKEY_LOCAL_MACHINE
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_HKEY_LOCAL_MACHINE, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_HKEY_LOCAL_MACHINE, (void*)(&value));
		}
	}

	public unsafe static System.IntPtr HKEY_USERS
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_HKEY_USERS, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_HKEY_USERS, (void*)(&value));
		}
	}

	public unsafe static System.IntPtr HKEY_PERFORMANCE_DATA
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_HKEY_PERFORMANCE_DATA, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_HKEY_PERFORMANCE_DATA, (void*)(&value));
		}
	}

	public unsafe static System.IntPtr HKEY_CURRENT_CONFIG
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_HKEY_CURRENT_CONFIG, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_HKEY_CURRENT_CONFIG, (void*)(&value));
		}
	}

	public unsafe static System.IntPtr HKEY_DYN_DATA
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_HKEY_DYN_DATA, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_HKEY_DYN_DATA, (void*)(&value));
		}
	}

	public unsafe static Il2CppStringArray s_hkeyNames
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_hkeyNames, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_hkeyNames, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe SafeRegistryHandle _hkey
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__hkey);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<SafeRegistryHandle>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__hkey)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe string _keyName
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__keyName);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__keyName)), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe bool _remoteKey
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__remoteKey);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__remoteKey)) = value;
		}
	}

	public unsafe StateFlags _state
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__state);
			return *(StateFlags*)num;
		}
		set
		{
			*(StateFlags*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__state)) = value;
		}
	}

	public unsafe RegistryKeyPermissionCheck _checkMode
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__checkMode);
			return *(RegistryKeyPermissionCheck*)num;
		}
		set
		{
			*(RegistryKeyPermissionCheck*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__checkMode)) = value;
		}
	}

	public unsafe RegistryView _regView
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__regView);
			return *(RegistryView*)num;
		}
		set
		{
			*(RegistryView*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__regView)) = value;
		}
	}

	static RegistryKey()
	{
		Il2CppClassPointerStore<RegistryKey>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "Microsoft.Win32", "RegistryKey");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RegistryKey>.NativeClassPtr);
		NativeFieldInfoPtr_HKEY_CLASSES_ROOT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegistryKey>.NativeClassPtr, "HKEY_CLASSES_ROOT");
		NativeFieldInfoPtr_HKEY_CURRENT_USER = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegistryKey>.NativeClassPtr, "HKEY_CURRENT_USER");
		NativeFieldInfoPtr_HKEY_LOCAL_MACHINE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegistryKey>.NativeClassPtr, "HKEY_LOCAL_MACHINE");
		NativeFieldInfoPtr_HKEY_USERS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegistryKey>.NativeClassPtr, "HKEY_USERS");
		NativeFieldInfoPtr_HKEY_PERFORMANCE_DATA = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegistryKey>.NativeClassPtr, "HKEY_PERFORMANCE_DATA");
		NativeFieldInfoPtr_HKEY_CURRENT_CONFIG = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegistryKey>.NativeClassPtr, "HKEY_CURRENT_CONFIG");
		NativeFieldInfoPtr_HKEY_DYN_DATA = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegistryKey>.NativeClassPtr, "HKEY_DYN_DATA");
		NativeFieldInfoPtr_s_hkeyNames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegistryKey>.NativeClassPtr, "s_hkeyNames");
		NativeFieldInfoPtr__hkey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegistryKey>.NativeClassPtr, "_hkey");
		NativeFieldInfoPtr__keyName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegistryKey>.NativeClassPtr, "_keyName");
		NativeFieldInfoPtr__remoteKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegistryKey>.NativeClassPtr, "_remoteKey");
		NativeFieldInfoPtr__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegistryKey>.NativeClassPtr, "_state");
		NativeFieldInfoPtr__checkMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegistryKey>.NativeClassPtr, "_checkMode");
		NativeFieldInfoPtr__regView = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegistryKey>.NativeClassPtr, "_regView");
		NativeMethodInfoPtr_ClosePerfDataKey_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegistryKey>.NativeClassPtr, 100663795);
		NativeMethodInfoPtr_OpenBaseKeyCore_Private_Static_RegistryKey_RegistryHive_RegistryView_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegistryKey>.NativeClassPtr, 100663796);
		NativeMethodInfoPtr_InternalOpenSubKeyCore_Private_RegistryKey_String_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegistryKey>.NativeClassPtr, 100663797);
		NativeMethodInfoPtr_InternalSubKeyCountCore_Private_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegistryKey>.NativeClassPtr, 100663798);
		NativeMethodInfoPtr_InternalGetSubKeyNamesCore_Private_Il2CppStringArray_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegistryKey>.NativeClassPtr, 100663799);
		NativeMethodInfoPtr_InternalGetValueCore_Private_Object_String_Object_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegistryKey>.NativeClassPtr, 100663800);
		NativeMethodInfoPtr_Win32Error_Private_Void_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegistryKey>.NativeClassPtr, 100663801);
		NativeMethodInfoPtr_GetRegistryKeyAccess_Private_Static_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegistryKey>.NativeClassPtr, 100663802);
		NativeMethodInfoPtr__ctor_Private_Void_SafeRegistryHandle_Boolean_Boolean_Boolean_Boolean_RegistryView_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegistryKey>.NativeClassPtr, 100663803);
		NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegistryKey>.NativeClassPtr, 100663804);
		NativeMethodInfoPtr_OpenBaseKey_Public_Static_RegistryKey_RegistryHive_RegistryView_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegistryKey>.NativeClassPtr, 100663805);
		NativeMethodInfoPtr_OpenSubKey_Public_RegistryKey_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegistryKey>.NativeClassPtr, 100663806);
		NativeMethodInfoPtr_InternalSubKeyCount_Private_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegistryKey>.NativeClassPtr, 100663807);
		NativeMethodInfoPtr_GetSubKeyNames_Public_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegistryKey>.NativeClassPtr, 100663808);
		NativeMethodInfoPtr_InternalGetSubKeyNames_Private_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegistryKey>.NativeClassPtr, 100663809);
		NativeMethodInfoPtr_GetValue_Public_Object_String_Object_RegistryValueOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegistryKey>.NativeClassPtr, 100663810);
		NativeMethodInfoPtr_InternalGetValue_Private_Object_String_Object_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegistryKey>.NativeClassPtr, 100663811);
		NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegistryKey>.NativeClassPtr, 100663812);
		NativeMethodInfoPtr_FixupName_Private_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegistryKey>.NativeClassPtr, 100663813);
		NativeMethodInfoPtr_FixupPath_Private_Static_Void_StringBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegistryKey>.NativeClassPtr, 100663814);
		NativeMethodInfoPtr_EnsureNotDisposed_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegistryKey>.NativeClassPtr, 100663815);
		NativeMethodInfoPtr_GetSubKeyPermissionCheck_Private_RegistryKeyPermissionCheck_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegistryKey>.NativeClassPtr, 100663816);
		NativeMethodInfoPtr_ValidateKeyName_Private_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegistryKey>.NativeClassPtr, 100663817);
		NativeMethodInfoPtr_ValidateKeyView_Private_Static_Void_RegistryView_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegistryKey>.NativeClassPtr, 100663818);
		NativeMethodInfoPtr_IsSystemKey_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegistryKey>.NativeClassPtr, 100663819);
		NativeMethodInfoPtr_IsPerfDataKey_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegistryKey>.NativeClassPtr, 100663820);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 700653, XrefRangeEnd = 700658, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ClosePerfDataKey()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ClosePerfDataKey_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 700658, XrefRangeEnd = 700675, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static RegistryKey OpenBaseKeyCore(RegistryHive hKeyHive, RegistryView view)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&hKeyHive);
		*(RegistryView**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &view;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OpenBaseKeyCore_Private_Static_RegistryKey_RegistryHive_RegistryView_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<RegistryKey>(intPtr2) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 700698, RefRangeEnd = 700699, XrefRangeStart = 700675, XrefRangeEnd = 700698, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe RegistryKey InternalOpenSubKeyCore(string name, bool writable, bool throwOnPermissionFailure)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &writable;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &throwOnPermissionFailure;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InternalOpenSubKeyCore_Private_RegistryKey_String_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<RegistryKey>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 700699, XrefRangeEnd = 700701, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int InternalSubKeyCountCore()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InternalSubKeyCountCore_Private_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 700727, RefRangeEnd = 700729, XrefRangeStart = 700701, XrefRangeEnd = 700727, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Il2CppStringArray InternalGetSubKeyNamesCore(int subkeys)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&subkeys);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InternalGetSubKeyNamesCore_Private_Il2CppStringArray_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 700799, RefRangeEnd = 700801, XrefRangeStart = 700729, XrefRangeEnd = 700799, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Il2CppSystem.Object InternalGetValueCore(string name, Il2CppSystem.Object defaultValue, bool doNotExpand)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)defaultValue);
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &doNotExpand;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InternalGetValueCore_Private_Object_String_Object_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 700872, RefRangeEnd = 700874, XrefRangeStart = 700801, XrefRangeEnd = 700872, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Win32Error(int errorCode, string str)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&errorCode);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(str);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Win32Error_Private_Void_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	public unsafe static int GetRegistryKeyAccess(bool isWritable)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&isWritable);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetRegistryKeyAccess_Private_Static_Int32_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 700895, RefRangeEnd = 700898, XrefRangeStart = 700874, XrefRangeEnd = 700895, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe RegistryKey(SafeRegistryHandle hkey, bool writable, bool systemkey, bool remoteKey, bool isPerfData, RegistryView view)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RegistryKey>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)hkey);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &writable;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &systemkey;
		*(bool**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &remoteKey;
		*(bool**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &isPerfData;
		*(RegistryView**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &view;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Private_Void_SafeRegistryHandle_Boolean_Boolean_Boolean_Boolean_RegistryView_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 700898, XrefRangeEnd = 700914, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void Dispose()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 700914, XrefRangeEnd = 700936, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static RegistryKey OpenBaseKey(RegistryHive hKey, RegistryView view)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&hKey);
		*(RegistryView**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &view;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OpenBaseKey_Public_Static_RegistryKey_RegistryHive_RegistryView_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<RegistryKey>(intPtr2) : null;
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 700944, RefRangeEnd = 700950, XrefRangeStart = 700936, XrefRangeEnd = 700944, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe RegistryKey OpenSubKey(string name, bool writable)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &writable;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OpenSubKey_Public_RegistryKey_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<RegistryKey>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 700950, XrefRangeEnd = 700954, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int InternalSubKeyCount()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InternalSubKeyCount_Private_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 700971, RefRangeEnd = 700973, XrefRangeStart = 700954, XrefRangeEnd = 700971, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Il2CppStringArray GetSubKeyNames()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetSubKeyNames_Public_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 700971, RefRangeEnd = 700973, XrefRangeStart = 700971, XrefRangeEnd = 700973, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Il2CppStringArray InternalGetSubKeyNames()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InternalGetSubKeyNames_Private_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
	}

	[CallerCount(13)]
	[CachedScanResults(RefRangeStart = 700989, RefRangeEnd = 701002, XrefRangeStart = 700973, XrefRangeEnd = 700989, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Il2CppSystem.Object GetValue(string name, Il2CppSystem.Object defaultValue, RegistryValueOptions options)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)defaultValue);
		*(RegistryValueOptions**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &options;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetValue_Public_Object_String_Object_RegistryValueOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 701002, XrefRangeEnd = 701008, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Il2CppSystem.Object InternalGetValue(string name, Il2CppSystem.Object defaultValue, bool doNotExpand, bool checkSecurity)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)defaultValue);
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &doNotExpand;
		*(bool**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &checkSecurity;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InternalGetValue_Private_Object_String_Object_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 701008, XrefRangeEnd = 701011, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override string ToString()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToString_Public_Virtual_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 701031, RefRangeEnd = 701032, XrefRangeStart = 701011, XrefRangeEnd = 701031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string FixupName(string name)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FixupName_Private_Static_String_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 701032, XrefRangeEnd = 701041, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void FixupPath(StringBuilder path)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)path);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FixupPath_Private_Static_Void_StringBuilder_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 701041, XrefRangeEnd = 701043, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void EnsureNotDisposed()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_EnsureNotDisposed_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 701043, XrefRangeEnd = 701044, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe RegistryKeyPermissionCheck GetSubKeyPermissionCheck(bool subkeyWritable)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&subkeyWritable);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetSubKeyPermissionCheck_Private_RegistryKeyPermissionCheck_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(RegistryKeyPermissionCheck*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 701061, RefRangeEnd = 701062, XrefRangeStart = 701044, XrefRangeEnd = 701061, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ValidateKeyName(string name)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ValidateKeyName_Private_Static_Void_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 701062, XrefRangeEnd = 701064, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ValidateKeyView(RegistryView view)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&view);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ValidateKeyView_Private_Static_Void_RegistryView_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 701064, XrefRangeEnd = 701065, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool IsSystemKey()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsSystemKey_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 701066, RefRangeEnd = 701067, XrefRangeStart = 701065, XrefRangeEnd = 701066, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool IsPerfDataKey()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsPerfDataKey_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	public RegistryKey(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
