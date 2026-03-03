using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Concurrent;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Security.Cryptography;

namespace Il2CppInternal.Cryptography;

public static class OidLookup : Il2CppSystem.Object
{
	[System.Serializable]
	[ObfuscatedName("Internal.Cryptography.OidLookup+<>c")]
	public sealed class __c : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr___9;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr___cctor_b__10_0_Internal_String_KeyValuePair_2_String_String_0;

		private static readonly System.IntPtr NativeMethodInfoPtr___cctor_b__10_1_Internal_String_KeyValuePair_2_String_String_0;

		public unsafe static __c __9
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<__c>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		static __c()
		{
			Il2CppClassPointerStore<__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<OidLookup>.NativeClassPtr, "<>c");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c>.NativeClassPtr);
			NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100664117);
			NativeMethodInfoPtr___cctor_b__10_0_Internal_String_KeyValuePair_2_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100664118);
			NativeMethodInfoPtr___cctor_b__10_1_Internal_String_KeyValuePair_2_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100664119);
		}

		[CallerCount(1950)]
		[CachedScanResults(RefRangeStart = 20036, RefRangeEnd = 21986, XrefRangeStart = 20036, XrefRangeEnd = 21986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 868470, XrefRangeEnd = 868471, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string __cctor_b__10_0(KeyValuePair<string, string> kvp)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)kvp));
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr___cctor_b__10_0_Internal_String_KeyValuePair_2_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return IL2CPP.Il2CppStringToManaged(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 868471, XrefRangeEnd = 868472, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string __cctor_b__10_1(KeyValuePair<string, string> kvp)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)kvp));
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr___cctor_b__10_1_Internal_String_KeyValuePair_2_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return IL2CPP.Il2CppStringToManaged(intPtr2);
		}

		public __c(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_s_lateBoundOidToFriendlyName;

	private static readonly System.IntPtr NativeFieldInfoPtr_s_lateBoundFriendlyNameToOid;

	private static readonly System.IntPtr NativeFieldInfoPtr_s_friendlyNameToOid;

	private static readonly System.IntPtr NativeFieldInfoPtr_s_oidToFriendlyName;

	private static readonly System.IntPtr NativeFieldInfoPtr_s_compatOids;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToFriendlyName_Public_Static_String_String_OidGroup_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToOid_Public_Static_String_String_OidGroup_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ShouldUseCache_Private_Static_Boolean_OidGroup_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_NativeOidToFriendlyName_Private_Static_String_String_OidGroup_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_NativeFriendlyNameToOid_Private_Static_String_String_OidGroup_Boolean_0;

	public unsafe static ConcurrentDictionary<string, string> s_lateBoundOidToFriendlyName
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_lateBoundOidToFriendlyName, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<ConcurrentDictionary<string, string>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_lateBoundOidToFriendlyName, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static ConcurrentDictionary<string, string> s_lateBoundFriendlyNameToOid
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_lateBoundFriendlyNameToOid, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<ConcurrentDictionary<string, string>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_lateBoundFriendlyNameToOid, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Dictionary<string, string> s_friendlyNameToOid
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_friendlyNameToOid, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<string, string>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_friendlyNameToOid, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Dictionary<string, string> s_oidToFriendlyName
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_oidToFriendlyName, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<string, string>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_oidToFriendlyName, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Dictionary<string, string> s_compatOids
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_compatOids, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<string, string>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_compatOids, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	static OidLookup()
	{
		Il2CppClassPointerStore<OidLookup>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "Internal.Cryptography", "OidLookup");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OidLookup>.NativeClassPtr);
		NativeFieldInfoPtr_s_lateBoundOidToFriendlyName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OidLookup>.NativeClassPtr, "s_lateBoundOidToFriendlyName");
		NativeFieldInfoPtr_s_lateBoundFriendlyNameToOid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OidLookup>.NativeClassPtr, "s_lateBoundFriendlyNameToOid");
		NativeFieldInfoPtr_s_friendlyNameToOid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OidLookup>.NativeClassPtr, "s_friendlyNameToOid");
		NativeFieldInfoPtr_s_oidToFriendlyName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OidLookup>.NativeClassPtr, "s_oidToFriendlyName");
		NativeFieldInfoPtr_s_compatOids = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OidLookup>.NativeClassPtr, "s_compatOids");
		NativeMethodInfoPtr_ToFriendlyName_Public_Static_String_String_OidGroup_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OidLookup>.NativeClassPtr, 100664110);
		NativeMethodInfoPtr_ToOid_Public_Static_String_String_OidGroup_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OidLookup>.NativeClassPtr, 100664111);
		NativeMethodInfoPtr_ShouldUseCache_Private_Static_Boolean_OidGroup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OidLookup>.NativeClassPtr, 100664112);
		NativeMethodInfoPtr_NativeOidToFriendlyName_Private_Static_String_String_OidGroup_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OidLookup>.NativeClassPtr, 100664113);
		NativeMethodInfoPtr_NativeFriendlyNameToOid_Private_Static_String_String_OidGroup_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OidLookup>.NativeClassPtr, 100664114);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 868501, RefRangeEnd = 868504, XrefRangeStart = 868472, XrefRangeEnd = 868501, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string ToFriendlyName(string oid, OidGroup oidGroup, bool fallBackToAllGroups)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(oid);
		*(OidGroup**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &oidGroup;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &fallBackToAllGroups;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToFriendlyName_Public_Static_String_String_OidGroup_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 868528, RefRangeEnd = 868529, XrefRangeStart = 868504, XrefRangeEnd = 868528, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string ToOid(string friendlyName, OidGroup oidGroup, bool fallBackToAllGroups)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(friendlyName);
		*(OidGroup**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &oidGroup;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &fallBackToAllGroups;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToOid_Public_Static_String_String_OidGroup_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(27)]
	[CachedScanResults(RefRangeStart = 61071, RefRangeEnd = 61098, XrefRangeStart = 61071, XrefRangeEnd = 61098, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool ShouldUseCache(OidGroup oidGroup)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&oidGroup);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ShouldUseCache_Private_Static_Boolean_OidGroup_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 868555, RefRangeEnd = 868556, XrefRangeStart = 868529, XrefRangeEnd = 868555, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string NativeOidToFriendlyName(string oid, OidGroup oidGroup, bool fallBackToAllGroups)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(oid);
		*(OidGroup**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &oidGroup;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &fallBackToAllGroups;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_NativeOidToFriendlyName_Private_Static_String_String_OidGroup_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 868582, RefRangeEnd = 868583, XrefRangeStart = 868556, XrefRangeEnd = 868582, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string NativeFriendlyNameToOid(string friendlyName, OidGroup oidGroup, bool fallBackToAllGroups)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(friendlyName);
		*(OidGroup**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &oidGroup;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &fallBackToAllGroups;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_NativeFriendlyNameToOid_Private_Static_String_String_OidGroup_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	public OidLookup(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
