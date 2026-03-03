using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppInternal.Cryptography;

public static class Helpers : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeMethodInfoPtr_CloneByteArray_Public_Static_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToHexArrayUpper_Public_Static_Il2CppStructArray_1_Char_Il2CppStructArray_1_Byte_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToHexStringUpper_Public_Static_String_Il2CppStructArray_1_Byte_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_NibbleToHex_Private_Static_Char_Byte_0;

	static Helpers()
	{
		Il2CppClassPointerStore<Helpers>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "Internal.Cryptography", "Helpers");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Helpers>.NativeClassPtr);
		NativeMethodInfoPtr_CloneByteArray_Public_Static_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Helpers>.NativeClassPtr, 100663876);
		NativeMethodInfoPtr_ToHexArrayUpper_Public_Static_Il2CppStructArray_1_Char_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Helpers>.NativeClassPtr, 100663877);
		NativeMethodInfoPtr_ToHexStringUpper_Public_Static_String_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Helpers>.NativeClassPtr, 100663878);
		NativeMethodInfoPtr_NibbleToHex_Private_Static_Char_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Helpers>.NativeClassPtr, 100663879);
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 701250, RefRangeEnd = 701256, XrefRangeStart = 701247, XrefRangeEnd = 701250, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppStructArray<byte> CloneByteArray(this Il2CppStructArray<byte> src)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)src);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CloneByteArray_Public_Static_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 701262, RefRangeEnd = 701264, XrefRangeStart = 701256, XrefRangeEnd = 701262, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppStructArray<char> ToHexArrayUpper(this Il2CppStructArray<byte> bytes)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)bytes);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToHexArrayUpper_Public_Static_Il2CppStructArray_1_Char_Il2CppStructArray_1_Byte_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<char>>(intPtr2) : null;
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 701272, RefRangeEnd = 701276, XrefRangeStart = 701264, XrefRangeEnd = 701272, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string ToHexStringUpper(this Il2CppStructArray<byte> bytes)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)bytes);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToHexStringUpper_Public_Static_String_Il2CppStructArray_1_Byte_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(0)]
	public unsafe static char NibbleToHex(byte b)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&b);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_NibbleToHex_Private_Static_Char_Byte_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(char*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	public Helpers(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
