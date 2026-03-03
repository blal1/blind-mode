using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Text.RegularExpressions;

namespace UnityEngineInternal;

public static class WebRequestUtils : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_domainRegex;

	private static readonly System.IntPtr NativeMethodInfoPtr_RedirectTo_Internal_Static_String_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_MakeInitialUrl_Internal_Static_String_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_MakeUriString_Internal_Static_String_Uri_String_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_URLDecode_Private_Static_String_String_0;

	public unsafe static Regex domainRegex
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_domainRegex, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Regex>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_domainRegex, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	static WebRequestUtils()
	{
		Il2CppClassPointerStore<WebRequestUtils>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UnityWebRequestModule.dll", "UnityEngineInternal", "WebRequestUtils");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WebRequestUtils>.NativeClassPtr);
		NativeFieldInfoPtr_domainRegex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebRequestUtils>.NativeClassPtr, "domainRegex");
		NativeMethodInfoPtr_RedirectTo_Internal_Static_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebRequestUtils>.NativeClassPtr, 100663297);
		NativeMethodInfoPtr_MakeInitialUrl_Internal_Static_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebRequestUtils>.NativeClassPtr, 100663298);
		NativeMethodInfoPtr_MakeUriString_Internal_Static_String_Uri_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebRequestUtils>.NativeClassPtr, 100663299);
		NativeMethodInfoPtr_URLDecode_Private_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebRequestUtils>.NativeClassPtr, 100663300);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1408001, XrefRangeEnd = 1408018, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string RedirectTo(string baseUri, string redirectUri)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(baseUri);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(redirectUri);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RedirectTo_Internal_Static_String_String_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1408059, RefRangeEnd = 1408060, XrefRangeStart = 1408018, XrefRangeEnd = 1408059, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string MakeInitialUrl(string targetUrl, string localUrl)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(targetUrl);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(localUrl);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MakeInitialUrl_Internal_Static_String_String_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1408128, RefRangeEnd = 1408129, XrefRangeStart = 1408060, XrefRangeEnd = 1408128, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string MakeUriString(Il2CppSystem.Uri targetUri, string targetUrl, bool prependProtocol)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)targetUri);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(targetUrl);
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &prependProtocol;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MakeUriString_Internal_Static_String_Uri_String_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1408151, RefRangeEnd = 1408153, XrefRangeStart = 1408129, XrefRangeEnd = 1408151, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string URLDecode(string encoded)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(encoded);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_URLDecode_Private_Static_String_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	public WebRequestUtils(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
