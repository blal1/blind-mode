using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Net;

public static class WebExceptionMapping : Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_s_Mapping;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetWebStatusString_Internal_Static_String_WebExceptionStatus_0;

	public unsafe static Il2CppStringArray s_Mapping
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_Mapping, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_Mapping, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	static WebExceptionMapping()
	{
		Il2CppClassPointerStore<WebExceptionMapping>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net", "WebExceptionMapping");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WebExceptionMapping>.NativeClassPtr);
		NativeFieldInfoPtr_s_Mapping = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebExceptionMapping>.NativeClassPtr, "s_Mapping");
		NativeMethodInfoPtr_GetWebStatusString_Internal_Static_String_WebExceptionStatus_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebExceptionMapping>.NativeClassPtr, 100666199);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 888002, RefRangeEnd = 888004, XrefRangeStart = 887984, XrefRangeEnd = 888002, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string GetWebStatusString(WebExceptionStatus status)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&status);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetWebStatusString_Internal_Static_String_WebExceptionStatus_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	public WebExceptionMapping(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
