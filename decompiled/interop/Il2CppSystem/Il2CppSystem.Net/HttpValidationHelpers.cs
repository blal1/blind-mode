using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Net;

public static class HttpValidationHelpers : Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_s_httpTrimCharacters;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsInvalidMethodOrHeaderString_Public_Static_Boolean_String_0;

	public unsafe static Il2CppStructArray<char> s_httpTrimCharacters
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_httpTrimCharacters, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<char>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_httpTrimCharacters, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	static HttpValidationHelpers()
	{
		Il2CppClassPointerStore<HttpValidationHelpers>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net", "HttpValidationHelpers");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HttpValidationHelpers>.NativeClassPtr);
		NativeFieldInfoPtr_s_httpTrimCharacters = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpValidationHelpers>.NativeClassPtr, "s_httpTrimCharacters");
		NativeMethodInfoPtr_IsInvalidMethodOrHeaderString_Public_Static_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpValidationHelpers>.NativeClassPtr, 100665819);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 884595, RefRangeEnd = 884596, XrefRangeStart = 884591, XrefRangeEnd = 884595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool IsInvalidMethodOrHeaderString(string stringValue)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(stringValue);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsInvalidMethodOrHeaderString_Public_Static_Boolean_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	public HttpValidationHelpers(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
