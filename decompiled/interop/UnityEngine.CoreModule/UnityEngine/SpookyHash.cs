using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine;

public static class SpookyHash : Il2CppSystem.Object
{
	[StructLayout(LayoutKind.Explicit)]
	public struct U
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_p8;

		private static readonly System.IntPtr NativeFieldInfoPtr_p32;

		private static readonly System.IntPtr NativeFieldInfoPtr_p64;

		private static readonly System.IntPtr NativeFieldInfoPtr_i;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_ptr_UInt16_0;

		[FieldOffset(0)]
		public System.IntPtr p8;

		[FieldOffset(0)]
		public System.IntPtr p32;

		[FieldOffset(0)]
		public System.IntPtr p64;

		[FieldOffset(0)]
		public ulong i;

		static U()
		{
			Il2CppClassPointerStore<U>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SpookyHash>.NativeClassPtr, "U");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<U>.NativeClassPtr);
			NativeFieldInfoPtr_p8 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<U>.NativeClassPtr, "p8");
			NativeFieldInfoPtr_p32 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<U>.NativeClassPtr, "p32");
			NativeFieldInfoPtr_p64 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<U>.NativeClassPtr, "p64");
			NativeFieldInfoPtr_i = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<U>.NativeClassPtr, "i");
			NativeMethodInfoPtr__ctor_Public_Void_ptr_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<U>.NativeClassPtr, 100665541);
		}

		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 687877, RefRangeEnd = 687880, XrefRangeStart = 687877, XrefRangeEnd = 687880, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe U(ushort* p8)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)p8;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_ptr_UInt16_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		public unsafe Il2CppSystem.Object BoxIl2CppObject()
		{
			return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<U>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
		}
	}

	private static readonly System.IntPtr NativeMethodInfoPtr_Hash_Public_Static_Void_ptr_Void_UInt64_ptr_UInt64_ptr_UInt64_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_End_Private_Static_Void_ptr_UInt64_byref_UInt64_byref_UInt64_byref_UInt64_byref_UInt64_byref_UInt64_byref_UInt64_byref_UInt64_byref_UInt64_byref_UInt64_byref_UInt64_byref_UInt64_byref_UInt64_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_EndPartial_Private_Static_Void_byref_UInt64_byref_UInt64_byref_UInt64_byref_UInt64_byref_UInt64_byref_UInt64_byref_UInt64_byref_UInt64_byref_UInt64_byref_UInt64_byref_UInt64_byref_UInt64_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Rot64_Private_Static_Void_byref_UInt64_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Short_Private_Static_Void_ptr_Void_UInt64_ptr_UInt64_ptr_UInt64_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ShortMix_Private_Static_Void_byref_UInt64_byref_UInt64_byref_UInt64_byref_UInt64_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ShortEnd_Private_Static_Void_byref_UInt64_byref_UInt64_byref_UInt64_byref_UInt64_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Mix_Private_Static_Void_ptr_UInt64_byref_UInt64_byref_UInt64_byref_UInt64_byref_UInt64_byref_UInt64_byref_UInt64_byref_UInt64_byref_UInt64_byref_UInt64_byref_UInt64_byref_UInt64_byref_UInt64_0;

	public const int k_NumVars = 12;

	public const int k_BlockSize = 96;

	public const int k_BufferSize = 192;

	public const ulong k_DeadBeefConst = 16045690984833335023uL;

	static SpookyHash()
	{
		Il2CppClassPointerStore<SpookyHash>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "SpookyHash");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpookyHash>.NativeClassPtr);
		NativeMethodInfoPtr_Hash_Public_Static_Void_ptr_Void_UInt64_ptr_UInt64_ptr_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpookyHash>.NativeClassPtr, 100665533);
		NativeMethodInfoPtr_End_Private_Static_Void_ptr_UInt64_byref_UInt64_byref_UInt64_byref_UInt64_byref_UInt64_byref_UInt64_byref_UInt64_byref_UInt64_byref_UInt64_byref_UInt64_byref_UInt64_byref_UInt64_byref_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpookyHash>.NativeClassPtr, 100665534);
		NativeMethodInfoPtr_EndPartial_Private_Static_Void_byref_UInt64_byref_UInt64_byref_UInt64_byref_UInt64_byref_UInt64_byref_UInt64_byref_UInt64_byref_UInt64_byref_UInt64_byref_UInt64_byref_UInt64_byref_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpookyHash>.NativeClassPtr, 100665535);
		NativeMethodInfoPtr_Rot64_Private_Static_Void_byref_UInt64_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpookyHash>.NativeClassPtr, 100665536);
		NativeMethodInfoPtr_Short_Private_Static_Void_ptr_Void_UInt64_ptr_UInt64_ptr_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpookyHash>.NativeClassPtr, 100665537);
		NativeMethodInfoPtr_ShortMix_Private_Static_Void_byref_UInt64_byref_UInt64_byref_UInt64_byref_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpookyHash>.NativeClassPtr, 100665538);
		NativeMethodInfoPtr_ShortEnd_Private_Static_Void_byref_UInt64_byref_UInt64_byref_UInt64_byref_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpookyHash>.NativeClassPtr, 100665539);
		NativeMethodInfoPtr_Mix_Private_Static_Void_ptr_UInt64_byref_UInt64_byref_UInt64_byref_UInt64_byref_UInt64_byref_UInt64_byref_UInt64_byref_UInt64_byref_UInt64_byref_UInt64_byref_UInt64_byref_UInt64_byref_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpookyHash>.NativeClassPtr, 100665540);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1182284, RefRangeEnd = 1182287, XrefRangeStart = 1182275, XrefRangeEnd = 1182284, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Hash(void* message, ulong length, ulong* hash1, ulong* hash2)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)message;
		*(ulong**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &length;
		*(ulong**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = hash1;
		*(ulong**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = hash2;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Hash_Public_Static_Void_ptr_Void_UInt64_ptr_UInt64_ptr_UInt64_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1182287, XrefRangeEnd = 1182290, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void End(ulong* data, ref ulong h0, ref ulong h1, ref ulong h2, ref ulong h3, ref ulong h4, ref ulong h5, ref ulong h6, ref ulong h7, ref ulong h8, ref ulong h9, ref ulong h10, ref ulong h11)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[13];
		*ptr = (nint)data;
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref h0);
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref h1);
		*(void**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref h2);
		*(void**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref h3);
		*(void**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref h4);
		*(void**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref h5);
		*(void**)((byte*)ptr + checked((nuint)7u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref h6);
		*(void**)((byte*)ptr + checked((nuint)8u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref h7);
		*(void**)((byte*)ptr + checked((nuint)9u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref h8);
		*(void**)((byte*)ptr + checked((nuint)10u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref h9);
		*(void**)((byte*)ptr + checked((nuint)11u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref h10);
		*(void**)((byte*)ptr + checked((nuint)12u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref h11);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_End_Private_Static_Void_ptr_UInt64_byref_UInt64_byref_UInt64_byref_UInt64_byref_UInt64_byref_UInt64_byref_UInt64_byref_UInt64_byref_UInt64_byref_UInt64_byref_UInt64_byref_UInt64_byref_UInt64_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 1182290, RefRangeEnd = 1182296, XrefRangeStart = 1182290, XrefRangeEnd = 1182290, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void EndPartial(ref ulong h0, ref ulong h1, ref ulong h2, ref ulong h3, ref ulong h4, ref ulong h5, ref ulong h6, ref ulong h7, ref ulong h8, ref ulong h9, ref ulong h10, ref ulong h11)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[12];
		*ptr = (nint)Unsafe.AsPointer(ref h0);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref h1);
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref h2);
		*(void**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref h3);
		*(void**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref h4);
		*(void**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref h5);
		*(void**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref h6);
		*(void**)((byte*)ptr + checked((nuint)7u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref h7);
		*(void**)((byte*)ptr + checked((nuint)8u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref h8);
		*(void**)((byte*)ptr + checked((nuint)9u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref h9);
		*(void**)((byte*)ptr + checked((nuint)10u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref h10);
		*(void**)((byte*)ptr + checked((nuint)11u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref h11);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_EndPartial_Private_Static_Void_byref_UInt64_byref_UInt64_byref_UInt64_byref_UInt64_byref_UInt64_byref_UInt64_byref_UInt64_byref_UInt64_byref_UInt64_byref_UInt64_byref_UInt64_byref_UInt64_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	public unsafe static void Rot64(ref ulong x, int k)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)Unsafe.AsPointer(ref x);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &k;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Rot64_Private_Static_Void_byref_UInt64_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1182304, RefRangeEnd = 1182305, XrefRangeStart = 1182296, XrefRangeEnd = 1182304, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Short(void* message, ulong length, ulong* hash1, ulong* hash2)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)message;
		*(ulong**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &length;
		*(ulong**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = hash1;
		*(ulong**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = hash2;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Short_Private_Static_Void_ptr_Void_UInt64_ptr_UInt64_ptr_UInt64_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	public unsafe static void ShortMix(ref ulong h0, ref ulong h1, ref ulong h2, ref ulong h3)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)Unsafe.AsPointer(ref h0);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref h1);
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref h2);
		*(void**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref h3);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ShortMix_Private_Static_Void_byref_UInt64_byref_UInt64_byref_UInt64_byref_UInt64_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	public unsafe static void ShortEnd(ref ulong h0, ref ulong h1, ref ulong h2, ref ulong h3)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)Unsafe.AsPointer(ref h0);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref h1);
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref h2);
		*(void**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref h3);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ShortEnd_Private_Static_Void_byref_UInt64_byref_UInt64_byref_UInt64_byref_UInt64_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	public unsafe static void Mix(ulong* data, ref ulong s0, ref ulong s1, ref ulong s2, ref ulong s3, ref ulong s4, ref ulong s5, ref ulong s6, ref ulong s7, ref ulong s8, ref ulong s9, ref ulong s10, ref ulong s11)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[13];
		*ptr = (nint)data;
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref s0);
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref s1);
		*(void**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref s2);
		*(void**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref s3);
		*(void**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref s4);
		*(void**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref s5);
		*(void**)((byte*)ptr + checked((nuint)7u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref s6);
		*(void**)((byte*)ptr + checked((nuint)8u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref s7);
		*(void**)((byte*)ptr + checked((nuint)9u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref s8);
		*(void**)((byte*)ptr + checked((nuint)10u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref s9);
		*(void**)((byte*)ptr + checked((nuint)11u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref s10);
		*(void**)((byte*)ptr + checked((nuint)12u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref s11);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Mix_Private_Static_Void_ptr_UInt64_byref_UInt64_byref_UInt64_byref_UInt64_byref_UInt64_byref_UInt64_byref_UInt64_byref_UInt64_byref_UInt64_byref_UInt64_byref_UInt64_byref_UInt64_byref_UInt64_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public SpookyHash(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
