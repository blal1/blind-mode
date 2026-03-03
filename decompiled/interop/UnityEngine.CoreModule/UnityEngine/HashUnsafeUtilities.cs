using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine;

public static class HashUnsafeUtilities : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeMethodInfoPtr_ComputeHash128_Public_Static_Void_ptr_Void_UInt64_ptr_UInt64_ptr_UInt64_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ComputeHash128_Public_Static_Void_ptr_Void_UInt64_ptr_Hash128_0;

	static HashUnsafeUtilities()
	{
		Il2CppClassPointerStore<HashUnsafeUtilities>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "HashUnsafeUtilities");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HashUnsafeUtilities>.NativeClassPtr);
		NativeMethodInfoPtr_ComputeHash128_Public_Static_Void_ptr_Void_UInt64_ptr_UInt64_ptr_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HashUnsafeUtilities>.NativeClassPtr, 100665531);
		NativeMethodInfoPtr_ComputeHash128_Public_Static_Void_ptr_Void_UInt64_ptr_Hash128_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HashUnsafeUtilities>.NativeClassPtr, 100665532);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1182273, XrefRangeEnd = 1182274, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ComputeHash128(void* data, ulong dataSize, ulong* hash1, ulong* hash2)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)data;
		*(ulong**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &dataSize;
		*(ulong**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = hash1;
		*(ulong**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = hash2;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ComputeHash128_Public_Static_Void_ptr_Void_UInt64_ptr_UInt64_ptr_UInt64_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1182274, XrefRangeEnd = 1182275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ComputeHash128(void* data, ulong dataSize, Hash128* hash)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)data;
		*(ulong**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &dataSize;
		*(Hash128**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = hash;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ComputeHash128_Public_Static_Void_ptr_Void_UInt64_ptr_Hash128_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public HashUnsafeUtilities(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
