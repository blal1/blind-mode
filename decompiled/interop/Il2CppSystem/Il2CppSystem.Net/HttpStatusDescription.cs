using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Net;

public static class HttpStatusDescription : Object
{
	private static readonly System.IntPtr NativeMethodInfoPtr_Get_Internal_Static_String_HttpStatusCode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Get_Internal_Static_String_Int32_0;

	static HttpStatusDescription()
	{
		Il2CppClassPointerStore<HttpStatusDescription>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net", "HttpStatusDescription");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HttpStatusDescription>.NativeClassPtr);
		NativeMethodInfoPtr_Get_Internal_Static_String_HttpStatusCode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpStatusDescription>.NativeClassPtr, 100665817);
		NativeMethodInfoPtr_Get_Internal_Static_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpStatusDescription>.NativeClassPtr, 100665818);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 884527, RefRangeEnd = 884529, XrefRangeStart = 884526, XrefRangeEnd = 884527, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string Get(HttpStatusCode code)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&code);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Get_Internal_Static_String_HttpStatusCode_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 884590, RefRangeEnd = 884591, XrefRangeStart = 884529, XrefRangeEnd = 884590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string Get(int code)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&code);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Get_Internal_Static_String_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	public HttpStatusDescription(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
