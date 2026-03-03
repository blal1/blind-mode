using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppMicrosoft.Win32;

public static class ThrowHelper : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeMethodInfoPtr_ThrowArgumentException_Internal_Static_Void_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ThrowArgumentNullException_Internal_Static_Void_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ThrowSecurityException_Internal_Static_Void_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ThrowObjectDisposedException_Internal_Static_Void_String_String_0;

	static ThrowHelper()
	{
		Il2CppClassPointerStore<ThrowHelper>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "Microsoft.Win32", "ThrowHelper");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ThrowHelper>.NativeClassPtr);
		NativeMethodInfoPtr_ThrowArgumentException_Internal_Static_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThrowHelper>.NativeClassPtr, 100663822);
		NativeMethodInfoPtr_ThrowArgumentNullException_Internal_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThrowHelper>.NativeClassPtr, 100663823);
		NativeMethodInfoPtr_ThrowSecurityException_Internal_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThrowHelper>.NativeClassPtr, 100663824);
		NativeMethodInfoPtr_ThrowObjectDisposedException_Internal_Static_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThrowHelper>.NativeClassPtr, 100663825);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 701067, XrefRangeEnd = 701072, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ThrowArgumentException(string msg, string argument)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(msg);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(argument);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ThrowArgumentException_Internal_Static_Void_String_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 701072, XrefRangeEnd = 701077, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ThrowArgumentNullException(string argument)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(argument);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ThrowArgumentNullException_Internal_Static_Void_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 701077, XrefRangeEnd = 701082, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ThrowSecurityException(string msg)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(msg);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ThrowSecurityException_Internal_Static_Void_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 701087, RefRangeEnd = 701093, XrefRangeStart = 701082, XrefRangeEnd = 701087, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ThrowObjectDisposedException(string objectName, string msg)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(objectName);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(msg);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ThrowObjectDisposedException_Internal_Static_Void_String_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public ThrowHelper(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
