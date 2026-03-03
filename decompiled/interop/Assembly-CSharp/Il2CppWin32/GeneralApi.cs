using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppWin32;

public static class GeneralApi : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeMethodInfoPtr_GetWin32ErrorMessage_Internal_Static_String_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetLastWin32ErrorMessage_Internal_Static_String_0;

	static GeneralApi()
	{
		Il2CppClassPointerStore<GeneralApi>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Win32", "GeneralApi");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GeneralApi>.NativeClassPtr);
		NativeMethodInfoPtr_GetWin32ErrorMessage_Internal_Static_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneralApi>.NativeClassPtr, 100664191);
		NativeMethodInfoPtr_GetLastWin32ErrorMessage_Internal_Static_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneralApi>.NativeClassPtr, 100664192);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 40113, XrefRangeEnd = 40125, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string GetWin32ErrorMessage(int error)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&error);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetWin32ErrorMessage_Internal_Static_String_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 40125, XrefRangeEnd = 40141, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string GetLastWin32ErrorMessage()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetLastWin32ErrorMessage_Internal_Static_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	public GeneralApi(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
