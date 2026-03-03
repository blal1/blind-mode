using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Net;

public class CookieParser : Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_m_tokenizer;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Internal_Void_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Get_Internal_Cookie_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CheckQuoted_Internal_Static_String_String_0;

	public unsafe CookieTokenizer m_tokenizer
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_tokenizer);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<CookieTokenizer>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_tokenizer)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	static CookieParser()
	{
		Il2CppClassPointerStore<CookieParser>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net", "CookieParser");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CookieParser>.NativeClassPtr);
		NativeFieldInfoPtr_m_tokenizer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CookieParser>.NativeClassPtr, "m_tokenizer");
		NativeMethodInfoPtr__ctor_Internal_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CookieParser>.NativeClassPtr, 100666416);
		NativeMethodInfoPtr_Get_Internal_Cookie_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CookieParser>.NativeClassPtr, 100666417);
		NativeMethodInfoPtr_CheckQuoted_Internal_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CookieParser>.NativeClassPtr, 100666418);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 889850, XrefRangeEnd = 889858, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe CookieParser(string cookieString)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CookieParser>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(cookieString);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Internal_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 889927, RefRangeEnd = 889928, XrefRangeStart = 889858, XrefRangeEnd = 889927, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Cookie Get()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Get_Internal_Cookie_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Cookie>(intPtr2) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 889931, RefRangeEnd = 889933, XrefRangeStart = 889928, XrefRangeEnd = 889931, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string CheckQuoted(string value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CheckQuoted_Internal_Static_String_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	public CookieParser(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
