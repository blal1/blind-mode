using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Net;

public class NetRes : Object
{
	private static readonly System.IntPtr NativeMethodInfoPtr_GetWebStatusString_Public_Static_String_String_WebExceptionStatus_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetWebStatusString_Public_Static_String_WebExceptionStatus_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetWebStatusCodeString_Public_Static_String_FtpStatusCode_String_0;

	static NetRes()
	{
		Il2CppClassPointerStore<NetRes>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net", "NetRes");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NetRes>.NativeClassPtr);
		NativeMethodInfoPtr_GetWebStatusString_Public_Static_String_String_WebExceptionStatus_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetRes>.NativeClassPtr, 100666319);
		NativeMethodInfoPtr_GetWebStatusString_Public_Static_String_WebExceptionStatus_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetRes>.NativeClassPtr, 100666320);
		NativeMethodInfoPtr_GetWebStatusCodeString_Public_Static_String_FtpStatusCode_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetRes>.NativeClassPtr, 100666321);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 889122, RefRangeEnd = 889124, XrefRangeStart = 889111, XrefRangeEnd = 889122, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string GetWebStatusString(string Res, WebExceptionStatus Status)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(Res);
		*(WebExceptionStatus**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &Status;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetWebStatusString_Public_Static_String_String_WebExceptionStatus_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 889129, RefRangeEnd = 889130, XrefRangeStart = 889124, XrefRangeEnd = 889129, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string GetWebStatusString(WebExceptionStatus Status)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&Status);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetWebStatusString_Public_Static_String_WebExceptionStatus_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 889149, RefRangeEnd = 889150, XrefRangeStart = 889130, XrefRangeEnd = 889149, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string GetWebStatusCodeString(FtpStatusCode statusCode, string statusDescription)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&statusCode);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(statusDescription);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetWebStatusCodeString_Public_Static_String_FtpStatusCode_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	public NetRes(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
