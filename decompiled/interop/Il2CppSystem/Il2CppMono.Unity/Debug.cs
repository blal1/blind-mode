using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppMono.Security.Interface;
using Il2CppSystem;

namespace Il2CppMono.Unity;

public static class Debug : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeMethodInfoPtr_CheckAndThrow_Public_Static_Void_unitytls_errorstate_String_AlertDescription_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CheckAndThrow_Public_Static_Void_unitytls_errorstate_unitytls_x509verify_result_String_AlertDescription_0;

	static Debug()
	{
		Il2CppClassPointerStore<Debug>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "Mono.Unity", "Debug");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Debug>.NativeClassPtr);
		NativeMethodInfoPtr_CheckAndThrow_Public_Static_Void_unitytls_errorstate_String_AlertDescription_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Debug>.NativeClassPtr, 100663333);
		NativeMethodInfoPtr_CheckAndThrow_Public_Static_Void_unitytls_errorstate_unitytls_x509verify_result_String_AlertDescription_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Debug>.NativeClassPtr, 100663334);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 862511, RefRangeEnd = 862512, XrefRangeStart = 862511, XrefRangeEnd = 862511, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void CheckAndThrow(UnityTls.unitytls_errorstate errorState, string context, AlertDescription defaultAlert = AlertDescription.InternalError)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&errorState);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(context);
		*(AlertDescription**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &defaultAlert;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CheckAndThrow_Public_Static_Void_unitytls_errorstate_String_AlertDescription_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	public unsafe static void CheckAndThrow(UnityTls.unitytls_errorstate errorState, UnityTls.unitytls_x509verify_result verifyResult, string context, AlertDescription defaultAlert = AlertDescription.InternalError)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&errorState);
		*(UnityTls.unitytls_x509verify_result**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &verifyResult;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(context);
		*(AlertDescription**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &defaultAlert;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CheckAndThrow_Public_Static_Void_unitytls_errorstate_unitytls_x509verify_result_String_AlertDescription_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public Debug(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
