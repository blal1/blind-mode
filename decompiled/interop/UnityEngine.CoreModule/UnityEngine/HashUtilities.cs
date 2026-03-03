using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using Unity.Collections.LowLevel.Unsafe;

namespace UnityEngine;

public static class HashUtilities : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeMethodInfoPtr_AppendHash_Public_Static_Void_byref_Hash128_byref_Hash128_0;

	static HashUtilities()
	{
		Il2CppClassPointerStore<HashUtilities>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "HashUtilities");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HashUtilities>.NativeClassPtr);
		NativeMethodInfoPtr_AppendHash_Public_Static_Void_byref_Hash128_byref_Hash128_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HashUtilities>.NativeClassPtr, 100665530);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1182272, RefRangeEnd = 1182273, XrefRangeStart = 1182271, XrefRangeEnd = 1182272, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void AppendHash(ref Hash128 inHash, ref Hash128 outHash)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)Unsafe.AsPointer(ref inHash);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref outHash);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AppendHash_Public_Static_Void_byref_Hash128_byref_Hash128_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public HashUtilities(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public unsafe static void QuantisedMatrixHash(ref Matrix4x4 value, ref Hash128 hash)
	{
		fixed (Hash128* hash2 = &hash)
		{
			int* ptr = stackalloc int[16];
			for (int i = 0; i < 16; i++)
			{
				ptr[i] = (int)(value[i] * 1000f + 0.5f);
			}
			HashUnsafeUtilities.ComputeHash128(ptr, 64uL, hash2);
		}
	}

	public unsafe static void QuantisedVectorHash(ref Vector3 value, ref Hash128 hash)
	{
		fixed (Hash128* hash2 = &hash)
		{
			int* ptr = stackalloc int[3];
			for (int i = 0; i < 3; i++)
			{
				ptr[i] = (int)(value[i] * 1000f + 0.5f);
			}
			HashUnsafeUtilities.ComputeHash128(ptr, 12uL, hash2);
		}
	}

	public unsafe static void ComputeHash128<T>(ref T value, ref Hash128 hash) where T : struct
	{
		void* data = UnsafeUtility.AddressOf(ref value);
		ulong dataSize = (ulong)UnsafeUtility.SizeOf<T>();
		Hash128* hash2 = (Hash128*)UnsafeUtility.AddressOf(ref hash);
		HashUnsafeUtilities.ComputeHash128(data, dataSize, hash2);
	}

	public static void ComputeHash128(Il2CppStructArray<byte> value, ref Hash128 hash)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}
}
