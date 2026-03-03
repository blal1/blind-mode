using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;

namespace Il2CppSystem.Net;

[System.Serializable]
public class CookieContainer : Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_HeaderInfo;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_domainTable;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_maxCookieSize;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_maxCookies;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_maxCookiesPerDomain;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_count;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_fqdnMyDomain;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddRemoveDomain_Private_Void_String_PathList_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Add_Internal_Void_Cookie_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AgeCookies_Private_Boolean_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ExpireCollection_Private_Int32_CookieCollection_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsLocalDomain_Internal_Boolean_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CookieCutter_Internal_CookieCollection_Uri_String_String_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InternalGetCookies_Internal_CookieCollection_Uri_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_BuildCookieCollectionFromDomainMatches_Private_Void_Uri_Boolean_Int32_CookieCollection_List_1_String_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_MergeUpdateCollections_Private_Void_CookieCollection_CookieCollection_Int32_Boolean_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetCookieHeader_Public_String_Uri_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetCookieHeader_Internal_String_Uri_byref_String_0;

	public unsafe static Il2CppReferenceArray<HeaderVariantInfo> HeaderInfo
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_HeaderInfo, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<HeaderVariantInfo>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_HeaderInfo, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe Hashtable m_domainTable
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_domainTable);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Hashtable>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_domainTable)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe int m_maxCookieSize
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_maxCookieSize);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_maxCookieSize)) = value;
		}
	}

	public unsafe int m_maxCookies
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_maxCookies);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_maxCookies)) = value;
		}
	}

	public unsafe int m_maxCookiesPerDomain
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_maxCookiesPerDomain);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_maxCookiesPerDomain)) = value;
		}
	}

	public unsafe int m_count
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_count);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_count)) = value;
		}
	}

	public unsafe string m_fqdnMyDomain
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_fqdnMyDomain);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_fqdnMyDomain)), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	static CookieContainer()
	{
		Il2CppClassPointerStore<CookieContainer>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net", "CookieContainer");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CookieContainer>.NativeClassPtr);
		NativeFieldInfoPtr_HeaderInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CookieContainer>.NativeClassPtr, "HeaderInfo");
		NativeFieldInfoPtr_m_domainTable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CookieContainer>.NativeClassPtr, "m_domainTable");
		NativeFieldInfoPtr_m_maxCookieSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CookieContainer>.NativeClassPtr, "m_maxCookieSize");
		NativeFieldInfoPtr_m_maxCookies = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CookieContainer>.NativeClassPtr, "m_maxCookies");
		NativeFieldInfoPtr_m_maxCookiesPerDomain = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CookieContainer>.NativeClassPtr, "m_maxCookiesPerDomain");
		NativeFieldInfoPtr_m_count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CookieContainer>.NativeClassPtr, "m_count");
		NativeFieldInfoPtr_m_fqdnMyDomain = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CookieContainer>.NativeClassPtr, "m_fqdnMyDomain");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CookieContainer>.NativeClassPtr, 100666441);
		NativeMethodInfoPtr_AddRemoveDomain_Private_Void_String_PathList_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CookieContainer>.NativeClassPtr, 100666442);
		NativeMethodInfoPtr_Add_Internal_Void_Cookie_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CookieContainer>.NativeClassPtr, 100666443);
		NativeMethodInfoPtr_AgeCookies_Private_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CookieContainer>.NativeClassPtr, 100666444);
		NativeMethodInfoPtr_ExpireCollection_Private_Int32_CookieCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CookieContainer>.NativeClassPtr, 100666445);
		NativeMethodInfoPtr_IsLocalDomain_Internal_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CookieContainer>.NativeClassPtr, 100666446);
		NativeMethodInfoPtr_CookieCutter_Internal_CookieCollection_Uri_String_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CookieContainer>.NativeClassPtr, 100666447);
		NativeMethodInfoPtr_InternalGetCookies_Internal_CookieCollection_Uri_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CookieContainer>.NativeClassPtr, 100666448);
		NativeMethodInfoPtr_BuildCookieCollectionFromDomainMatches_Private_Void_Uri_Boolean_Int32_CookieCollection_List_1_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CookieContainer>.NativeClassPtr, 100666449);
		NativeMethodInfoPtr_MergeUpdateCollections_Private_Void_CookieCollection_CookieCollection_Int32_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CookieContainer>.NativeClassPtr, 100666450);
		NativeMethodInfoPtr_GetCookieHeader_Public_String_Uri_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CookieContainer>.NativeClassPtr, 100666451);
		NativeMethodInfoPtr_GetCookieHeader_Internal_String_Uri_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CookieContainer>.NativeClassPtr, 100666452);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 890070, XrefRangeEnd = 890083, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe CookieContainer()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CookieContainer>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 890089, RefRangeEnd = 890091, XrefRangeStart = 890083, XrefRangeEnd = 890089, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddRemoveDomain(string key, PathList value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddRemoveDomain_Private_Void_String_PathList_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 890145, RefRangeEnd = 890146, XrefRangeStart = 890091, XrefRangeEnd = 890145, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Add(Cookie cookie, bool throwOnError)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cookie);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &throwOnError;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Add_Internal_Void_Cookie_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 890260, RefRangeEnd = 890262, XrefRangeStart = 890146, XrefRangeEnd = 890260, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool AgeCookies(string domain)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(domain);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AgeCookies_Private_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 890269, RefRangeEnd = 890270, XrefRangeStart = 890262, XrefRangeEnd = 890269, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int ExpireCollection(CookieCollection cc)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cc);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ExpireCollection_Private_Int32_CookieCollection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 890291, RefRangeEnd = 890292, XrefRangeStart = 890270, XrefRangeEnd = 890291, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool IsLocalDomain(string host)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(host);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsLocalDomain_Internal_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 890359, RefRangeEnd = 890361, XrefRangeStart = 890292, XrefRangeEnd = 890359, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe CookieCollection CookieCutter(Uri uri, string headerName, string setCookieHeader, bool isThrow)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)uri);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(headerName);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(setCookieHeader);
		*(bool**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &isThrow;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CookieCutter_Internal_CookieCollection_Uri_String_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<CookieCollection>(intPtr2) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 890415, RefRangeEnd = 890416, XrefRangeStart = 890361, XrefRangeEnd = 890415, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe CookieCollection InternalGetCookies(Uri uri)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)uri);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InternalGetCookies_Internal_CookieCollection_Uri_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<CookieCollection>(intPtr2) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 890472, RefRangeEnd = 890474, XrefRangeStart = 890416, XrefRangeEnd = 890472, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void BuildCookieCollectionFromDomainMatches(Uri uri, bool isSecure, int port, CookieCollection cookies, List<string> domainAttribute, bool matchOnlyPlainCookie)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)uri);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &isSecure;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &port;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cookies);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)domainAttribute);
		*(bool**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &matchOnlyPlainCookie;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_BuildCookieCollectionFromDomainMatches_Private_Void_Uri_Boolean_Int32_CookieCollection_List_1_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 890484, RefRangeEnd = 890486, XrefRangeStart = 890474, XrefRangeEnd = 890484, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void MergeUpdateCollections(CookieCollection destination, CookieCollection source, int port, bool isSecure, bool isPlainOnly)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)destination);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)source);
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &port;
		*(bool**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &isSecure;
		*(bool**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &isPlainOnly;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MergeUpdateCollections_Private_Void_CookieCollection_CookieCollection_Int32_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 890486, XrefRangeEnd = 890491, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string GetCookieHeader(Uri uri)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)uri);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetCookieHeader_Public_String_Uri_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 890526, RefRangeEnd = 890528, XrefRangeStart = 890491, XrefRangeEnd = 890526, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string GetCookieHeader(Uri uri, out string optCookie2)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)uri);
		byte* num = (byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)));
		nint num2 = 0;
		*(nint**)num = &num2;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetCookieHeader_Internal_String_Uri_byref_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		optCookie2 = IL2CPP.Il2CppStringToManaged((System.IntPtr)num2);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	public CookieContainer(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
