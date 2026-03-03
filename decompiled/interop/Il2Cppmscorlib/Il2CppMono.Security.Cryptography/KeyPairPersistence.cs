using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Security.Cryptography;

namespace Il2CppMono.Security.Cryptography;

public class KeyPairPersistence : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr__userPathExists;

	private static readonly System.IntPtr NativeFieldInfoPtr__userPath;

	private static readonly System.IntPtr NativeFieldInfoPtr__machinePathExists;

	private static readonly System.IntPtr NativeFieldInfoPtr__machinePath;

	private static readonly System.IntPtr NativeFieldInfoPtr__params;

	private static readonly System.IntPtr NativeFieldInfoPtr__keyvalue;

	private static readonly System.IntPtr NativeFieldInfoPtr__filename;

	private static readonly System.IntPtr NativeFieldInfoPtr__container;

	private static readonly System.IntPtr NativeFieldInfoPtr_lockobj;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_CspParameters_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_CspParameters_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Filename_Public_get_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_KeyValue_Public_get_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_KeyValue_Public_set_Void_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Load_Public_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Save_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Remove_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_UserPath_Private_Static_get_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_MachinePath_Private_Static_get_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__CanSecure_Internal_Static_Boolean_ptr_Char_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ProtectUser_Internal_Static_Boolean_ptr_Char_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ProtectMachine_Internal_Static_Boolean_ptr_Char_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__IsUserProtected_Internal_Static_Boolean_ptr_Char_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__IsMachineProtected_Internal_Static_Boolean_ptr_Char_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CanSecure_Private_Static_Boolean_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ProtectUser_Private_Static_Boolean_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ProtectMachine_Private_Static_Boolean_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsUserProtected_Private_Static_Boolean_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsMachineProtected_Private_Static_Boolean_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_CanChange_Private_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_UseDefaultKeyContainer_Private_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_UseMachineKeyStore_Private_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_ContainerName_Private_get_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Copy_Private_CspParameters_CspParameters_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FromXml_Private_Void_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToXml_Private_String_0;

	public unsafe static bool _userPathExists
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__userPathExists, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__userPathExists, (void*)(&value));
		}
	}

	public unsafe static string _userPath
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__userPath, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__userPath, (void*)IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe static bool _machinePathExists
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__machinePathExists, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__machinePathExists, (void*)(&value));
		}
	}

	public unsafe static string _machinePath
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__machinePath, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__machinePath, (void*)IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe CspParameters _params
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__params);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<CspParameters>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__params)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe string _keyvalue
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__keyvalue);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__keyvalue)), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe string _filename
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__filename);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__filename)), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe string _container
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__container);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__container)), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe static Il2CppSystem.Object lockobj
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_lockobj, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_lockobj, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe string Filename
	{
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 698435, RefRangeEnd = 698440, XrefRangeStart = 698413, XrefRangeEnd = 698435, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Filename_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return IL2CPP.Il2CppStringToManaged(intPtr2);
		}
	}

	public unsafe string KeyValue
	{
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 25665, RefRangeEnd = 25677, XrefRangeStart = 25665, XrefRangeEnd = 25677, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_KeyValue_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return IL2CPP.Il2CppStringToManaged(intPtr2);
		}
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 698441, RefRangeEnd = 698443, XrefRangeStart = 698440, XrefRangeEnd = 698441, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_KeyValue_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe static string UserPath
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 698540, RefRangeEnd = 698541, XrefRangeStart = 698482, XrefRangeEnd = 698540, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_UserPath_Private_Static_get_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return IL2CPP.Il2CppStringToManaged(intPtr2);
		}
	}

	public unsafe static string MachinePath
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 698541, XrefRangeEnd = 698599, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_MachinePath_Private_Static_get_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return IL2CPP.Il2CppStringToManaged(intPtr2);
		}
	}

	public unsafe bool CanChange
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 698657, RefRangeEnd = 698658, XrefRangeStart = 698657, XrefRangeEnd = 698657, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_CanChange_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe bool UseDefaultKeyContainer
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_UseDefaultKeyContainer_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe bool UseMachineKeyStore
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_UseMachineKeyStore_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe string ContainerName
	{
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 698665, RefRangeEnd = 698667, XrefRangeStart = 698658, XrefRangeEnd = 698665, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_ContainerName_Private_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return IL2CPP.Il2CppStringToManaged(intPtr2);
		}
	}

	static KeyPairPersistence()
	{
		Il2CppClassPointerStore<KeyPairPersistence>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "Mono.Security.Cryptography", "KeyPairPersistence");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<KeyPairPersistence>.NativeClassPtr);
		NativeFieldInfoPtr__userPathExists = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KeyPairPersistence>.NativeClassPtr, "_userPathExists");
		NativeFieldInfoPtr__userPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KeyPairPersistence>.NativeClassPtr, "_userPath");
		NativeFieldInfoPtr__machinePathExists = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KeyPairPersistence>.NativeClassPtr, "_machinePathExists");
		NativeFieldInfoPtr__machinePath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KeyPairPersistence>.NativeClassPtr, "_machinePath");
		NativeFieldInfoPtr__params = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KeyPairPersistence>.NativeClassPtr, "_params");
		NativeFieldInfoPtr__keyvalue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KeyPairPersistence>.NativeClassPtr, "_keyvalue");
		NativeFieldInfoPtr__filename = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KeyPairPersistence>.NativeClassPtr, "_filename");
		NativeFieldInfoPtr__container = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KeyPairPersistence>.NativeClassPtr, "_container");
		NativeFieldInfoPtr_lockobj = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KeyPairPersistence>.NativeClassPtr, "lockobj");
		NativeMethodInfoPtr__ctor_Public_Void_CspParameters_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyPairPersistence>.NativeClassPtr, 100663590);
		NativeMethodInfoPtr__ctor_Public_Void_CspParameters_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyPairPersistence>.NativeClassPtr, 100663591);
		NativeMethodInfoPtr_get_Filename_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyPairPersistence>.NativeClassPtr, 100663592);
		NativeMethodInfoPtr_get_KeyValue_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyPairPersistence>.NativeClassPtr, 100663593);
		NativeMethodInfoPtr_set_KeyValue_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyPairPersistence>.NativeClassPtr, 100663594);
		NativeMethodInfoPtr_Load_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyPairPersistence>.NativeClassPtr, 100663595);
		NativeMethodInfoPtr_Save_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyPairPersistence>.NativeClassPtr, 100663596);
		NativeMethodInfoPtr_Remove_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyPairPersistence>.NativeClassPtr, 100663597);
		NativeMethodInfoPtr_get_UserPath_Private_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyPairPersistence>.NativeClassPtr, 100663598);
		NativeMethodInfoPtr_get_MachinePath_Private_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyPairPersistence>.NativeClassPtr, 100663599);
		NativeMethodInfoPtr__CanSecure_Internal_Static_Boolean_ptr_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyPairPersistence>.NativeClassPtr, 100663600);
		NativeMethodInfoPtr__ProtectUser_Internal_Static_Boolean_ptr_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyPairPersistence>.NativeClassPtr, 100663601);
		NativeMethodInfoPtr__ProtectMachine_Internal_Static_Boolean_ptr_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyPairPersistence>.NativeClassPtr, 100663602);
		NativeMethodInfoPtr__IsUserProtected_Internal_Static_Boolean_ptr_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyPairPersistence>.NativeClassPtr, 100663603);
		NativeMethodInfoPtr__IsMachineProtected_Internal_Static_Boolean_ptr_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyPairPersistence>.NativeClassPtr, 100663604);
		NativeMethodInfoPtr_CanSecure_Private_Static_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyPairPersistence>.NativeClassPtr, 100663605);
		NativeMethodInfoPtr_ProtectUser_Private_Static_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyPairPersistence>.NativeClassPtr, 100663606);
		NativeMethodInfoPtr_ProtectMachine_Private_Static_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyPairPersistence>.NativeClassPtr, 100663607);
		NativeMethodInfoPtr_IsUserProtected_Private_Static_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyPairPersistence>.NativeClassPtr, 100663608);
		NativeMethodInfoPtr_IsMachineProtected_Private_Static_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyPairPersistence>.NativeClassPtr, 100663609);
		NativeMethodInfoPtr_get_CanChange_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyPairPersistence>.NativeClassPtr, 100663610);
		NativeMethodInfoPtr_get_UseDefaultKeyContainer_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyPairPersistence>.NativeClassPtr, 100663611);
		NativeMethodInfoPtr_get_UseMachineKeyStore_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyPairPersistence>.NativeClassPtr, 100663612);
		NativeMethodInfoPtr_get_ContainerName_Private_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyPairPersistence>.NativeClassPtr, 100663613);
		NativeMethodInfoPtr_Copy_Private_CspParameters_CspParameters_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyPairPersistence>.NativeClassPtr, 100663614);
		NativeMethodInfoPtr_FromXml_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyPairPersistence>.NativeClassPtr, 100663615);
		NativeMethodInfoPtr_ToXml_Private_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyPairPersistence>.NativeClassPtr, 100663616);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 698393, RefRangeEnd = 698398, XrefRangeStart = 698378, XrefRangeEnd = 698393, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe KeyPairPersistence(CspParameters parameters)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<KeyPairPersistence>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)parameters);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_CspParameters_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 698398, XrefRangeEnd = 698413, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe KeyPairPersistence(CspParameters parameters, string keyPair)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<KeyPairPersistence>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)parameters);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(keyPair);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_CspParameters_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 698454, RefRangeEnd = 698457, XrefRangeStart = 698443, XrefRangeEnd = 698454, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool Load()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Load_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 698476, RefRangeEnd = 698478, XrefRangeStart = 698457, XrefRangeEnd = 698476, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Save()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Save_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 698480, RefRangeEnd = 698482, XrefRangeStart = 698478, XrefRangeEnd = 698480, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Remove()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Remove_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 698599, XrefRangeEnd = 698608, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool _CanSecure(char* root)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)root;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__CanSecure_Internal_Static_Boolean_ptr_Char_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool _ProtectUser(char* path)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)path;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ProtectUser_Internal_Static_Boolean_ptr_Char_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool _ProtectMachine(char* path)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)path;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ProtectMachine_Internal_Static_Boolean_ptr_Char_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool _IsUserProtected(char* path)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)path;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__IsUserProtected_Internal_Static_Boolean_ptr_Char_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool _IsMachineProtected(char* path)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)path;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__IsMachineProtected_Internal_Static_Boolean_ptr_Char_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 698608, XrefRangeEnd = 698614, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool CanSecure(string path)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CanSecure_Private_Static_Boolean_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 698623, RefRangeEnd = 698625, XrefRangeStart = 698614, XrefRangeEnd = 698623, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool ProtectUser(string path)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ProtectUser_Private_Static_Boolean_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 698634, RefRangeEnd = 698635, XrefRangeStart = 698625, XrefRangeEnd = 698634, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool ProtectMachine(string path)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ProtectMachine_Private_Static_Boolean_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 698644, RefRangeEnd = 698646, XrefRangeStart = 698635, XrefRangeEnd = 698644, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool IsUserProtected(string path)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsUserProtected_Private_Static_Boolean_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 698655, RefRangeEnd = 698657, XrefRangeStart = 698646, XrefRangeEnd = 698655, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool IsMachineProtected(string path)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsMachineProtected_Private_Static_Boolean_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 698667, XrefRangeEnd = 698672, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe CspParameters Copy(CspParameters p)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)p);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Copy_Private_CspParameters_CspParameters_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<CspParameters>(intPtr2) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 698689, RefRangeEnd = 698690, XrefRangeStart = 698672, XrefRangeEnd = 698689, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void FromXml(string xml)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(xml);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FromXml_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 698723, RefRangeEnd = 698724, XrefRangeStart = 698690, XrefRangeEnd = 698723, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string ToXml()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToXml_Private_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	public KeyPairPersistence(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
