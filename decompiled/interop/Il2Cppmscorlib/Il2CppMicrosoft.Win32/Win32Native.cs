using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppMicrosoft.Win32;

public static class Win32Native : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeMethodInfoPtr_GetMessage_Public_Static_String_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_MakeHRFromErrorCode_Public_Static_Int32_Int32_0;

	static Win32Native()
	{
		Il2CppClassPointerStore<Win32Native>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "Microsoft.Win32", "Win32Native");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Win32Native>.NativeClassPtr);
		NativeMethodInfoPtr_GetMessage_Public_Static_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Win32Native>.NativeClassPtr, 100663826);
		NativeMethodInfoPtr_MakeHRFromErrorCode_Public_Static_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Win32Native>.NativeClassPtr, 100663827);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 701097, RefRangeEnd = 701100, XrefRangeStart = 701093, XrefRangeEnd = 701097, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string GetMessage(int hr)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&hr);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetMessage_Public_Static_String_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 701100, RefRangeEnd = 701106, XrefRangeStart = 701100, XrefRangeEnd = 701100, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int MakeHRFromErrorCode(int errorCode)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&errorCode);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MakeHRFromErrorCode_Public_Static_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	public Win32Native(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
