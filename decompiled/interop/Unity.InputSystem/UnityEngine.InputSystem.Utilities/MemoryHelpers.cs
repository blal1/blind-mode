using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using Il2CppSystem.Reflection;

namespace UnityEngine.InputSystem.Utilities;

public static class MemoryHelpers : Il2CppSystem.Object
{
	[StructLayout(LayoutKind.Explicit)]
	public struct BitRegion
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_bitOffset;

		private static readonly System.IntPtr NativeFieldInfoPtr_sizeInBits;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_isEmpty_Public_get_Boolean_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_UInt32_UInt32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_UInt32_UInt32_UInt32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_Overlap_Public_BitRegion_BitRegion_0;

		[FieldOffset(0)]
		public uint bitOffset;

		[FieldOffset(4)]
		public uint sizeInBits;

		public unsafe bool isEmpty
		{
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 1019790, RefRangeEnd = 1019796, XrefRangeStart = 1019790, XrefRangeEnd = 1019790, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_isEmpty_Public_get_Boolean_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
			}
		}

		static BitRegion()
		{
			Il2CppClassPointerStore<BitRegion>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MemoryHelpers>.NativeClassPtr, "BitRegion");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BitRegion>.NativeClassPtr);
			NativeFieldInfoPtr_bitOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BitRegion>.NativeClassPtr, "bitOffset");
			NativeFieldInfoPtr_sizeInBits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BitRegion>.NativeClassPtr, "sizeInBits");
			NativeMethodInfoPtr_get_isEmpty_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BitRegion>.NativeClassPtr, 100668818);
			NativeMethodInfoPtr__ctor_Public_Void_UInt32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BitRegion>.NativeClassPtr, 100668819);
			NativeMethodInfoPtr__ctor_Public_Void_UInt32_UInt32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BitRegion>.NativeClassPtr, 100668820);
			NativeMethodInfoPtr_Overlap_Public_BitRegion_BitRegion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BitRegion>.NativeClassPtr, 100668821);
		}

		[CallerCount(230)]
		[CachedScanResults(RefRangeStart = 409470, RefRangeEnd = 409700, XrefRangeStart = 409470, XrefRangeEnd = 409700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BitRegion(uint bitOffset, uint sizeInBits)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = (nint)(&bitOffset);
			*(uint**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &sizeInBits;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_UInt32_UInt32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1019796, RefRangeEnd = 1019798, XrefRangeStart = 1019796, XrefRangeEnd = 1019796, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BitRegion(uint byteOffset, uint bitOffset, uint sizeInBits)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[3];
			*ptr = (nint)(&byteOffset);
			*(uint**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &bitOffset;
			*(uint**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &sizeInBits;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_UInt32_UInt32_UInt32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1019804, RefRangeEnd = 1019805, XrefRangeStart = 1019798, XrefRangeEnd = 1019804, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BitRegion Overlap(BitRegion other)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&other);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Overlap_Public_BitRegion_BitRegion_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(BitRegion*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		public unsafe Il2CppSystem.Object BoxIl2CppObject()
		{
			return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BitRegion>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
		}
	}

	private sealed class MethodInfoStoreGeneric_Swap_Public_Static_Void_byref_TValue_byref_TValue_0<TValue>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_Swap_Public_Static_Void_byref_TValue_byref_TValue_0, Il2CppClassPointerStore<MemoryHelpers>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TValue>.NativeClassPtr)) }))));
	}

	private static readonly System.IntPtr NativeMethodInfoPtr_Compare_Public_Static_Boolean_ptr_Void_ptr_Void_BitRegion_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ComputeFollowingByteOffset_Public_Static_UInt32_UInt32_UInt32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_WriteSingleBit_Public_Static_Void_ptr_Void_UInt32_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ReadSingleBit_Public_Static_Boolean_ptr_Void_UInt32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_MemCpyBitRegion_Public_Static_Void_ptr_Void_ptr_Void_UInt32_UInt32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_MemCmpBitRegion_Public_Static_Boolean_ptr_Void_ptr_Void_UInt32_UInt32_ptr_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_MemSet_Public_Static_Void_ptr_Void_Int32_Byte_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_MemCpyMasked_Public_Static_Void_ptr_Void_ptr_Void_Int32_ptr_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ReadMultipleBitsAsUInt_Public_Static_UInt32_ptr_Void_UInt32_UInt32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_WriteUIntAsMultipleBits_Public_Static_Void_ptr_Void_UInt32_UInt32_UInt32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ReadTwosComplementMultipleBitsAsInt_Public_Static_Int32_ptr_Void_UInt32_UInt32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_WriteIntAsTwosComplementMultipleBits_Public_Static_Void_ptr_Void_UInt32_UInt32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ReadExcessKMultipleBitsAsInt_Public_Static_Int32_ptr_Void_UInt32_UInt32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_WriteIntAsExcessKMultipleBits_Public_Static_Void_ptr_Void_UInt32_UInt32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ReadMultipleBitsAsNormalizedUInt_Public_Static_Single_ptr_Void_UInt32_UInt32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_WriteNormalizedUIntAsMultipleBits_Public_Static_Void_ptr_Void_UInt32_UInt32_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetBitsInBuffer_Public_Static_Void_ptr_Void_Int32_Int32_Int32_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Swap_Public_Static_Void_byref_TValue_byref_TValue_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AlignNatural_Public_Static_UInt32_UInt32_UInt32_0;

	static MemoryHelpers()
	{
		Il2CppClassPointerStore<MemoryHelpers>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.InputSystem.dll", "UnityEngine.InputSystem.Utilities", "MemoryHelpers");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MemoryHelpers>.NativeClassPtr);
		NativeMethodInfoPtr_Compare_Public_Static_Boolean_ptr_Void_ptr_Void_BitRegion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemoryHelpers>.NativeClassPtr, 100668799);
		NativeMethodInfoPtr_ComputeFollowingByteOffset_Public_Static_UInt32_UInt32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemoryHelpers>.NativeClassPtr, 100668800);
		NativeMethodInfoPtr_WriteSingleBit_Public_Static_Void_ptr_Void_UInt32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemoryHelpers>.NativeClassPtr, 100668801);
		NativeMethodInfoPtr_ReadSingleBit_Public_Static_Boolean_ptr_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemoryHelpers>.NativeClassPtr, 100668802);
		NativeMethodInfoPtr_MemCpyBitRegion_Public_Static_Void_ptr_Void_ptr_Void_UInt32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemoryHelpers>.NativeClassPtr, 100668803);
		NativeMethodInfoPtr_MemCmpBitRegion_Public_Static_Boolean_ptr_Void_ptr_Void_UInt32_UInt32_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemoryHelpers>.NativeClassPtr, 100668804);
		NativeMethodInfoPtr_MemSet_Public_Static_Void_ptr_Void_Int32_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemoryHelpers>.NativeClassPtr, 100668805);
		NativeMethodInfoPtr_MemCpyMasked_Public_Static_Void_ptr_Void_ptr_Void_Int32_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemoryHelpers>.NativeClassPtr, 100668806);
		NativeMethodInfoPtr_ReadMultipleBitsAsUInt_Public_Static_UInt32_ptr_Void_UInt32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemoryHelpers>.NativeClassPtr, 100668807);
		NativeMethodInfoPtr_WriteUIntAsMultipleBits_Public_Static_Void_ptr_Void_UInt32_UInt32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemoryHelpers>.NativeClassPtr, 100668808);
		NativeMethodInfoPtr_ReadTwosComplementMultipleBitsAsInt_Public_Static_Int32_ptr_Void_UInt32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemoryHelpers>.NativeClassPtr, 100668809);
		NativeMethodInfoPtr_WriteIntAsTwosComplementMultipleBits_Public_Static_Void_ptr_Void_UInt32_UInt32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemoryHelpers>.NativeClassPtr, 100668810);
		NativeMethodInfoPtr_ReadExcessKMultipleBitsAsInt_Public_Static_Int32_ptr_Void_UInt32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemoryHelpers>.NativeClassPtr, 100668811);
		NativeMethodInfoPtr_WriteIntAsExcessKMultipleBits_Public_Static_Void_ptr_Void_UInt32_UInt32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemoryHelpers>.NativeClassPtr, 100668812);
		NativeMethodInfoPtr_ReadMultipleBitsAsNormalizedUInt_Public_Static_Single_ptr_Void_UInt32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemoryHelpers>.NativeClassPtr, 100668813);
		NativeMethodInfoPtr_WriteNormalizedUIntAsMultipleBits_Public_Static_Void_ptr_Void_UInt32_UInt32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemoryHelpers>.NativeClassPtr, 100668814);
		NativeMethodInfoPtr_SetBitsInBuffer_Public_Static_Void_ptr_Void_Int32_Int32_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemoryHelpers>.NativeClassPtr, 100668815);
		NativeMethodInfoPtr_Swap_Public_Static_Void_byref_TValue_byref_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemoryHelpers>.NativeClassPtr, 100668816);
		NativeMethodInfoPtr_AlignNatural_Public_Static_UInt32_UInt32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemoryHelpers>.NativeClassPtr, 100668817);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1019806, RefRangeEnd = 1019807, XrefRangeStart = 1019805, XrefRangeEnd = 1019806, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool Compare(void* ptr1, void* ptr2, BitRegion region)
	{
		System.IntPtr* ptr3 = stackalloc System.IntPtr[3];
		*ptr3 = (nint)ptr1;
		*(void**)((byte*)ptr3 + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = ptr2;
		*(BitRegion**)((byte*)ptr3 + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &region;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Compare_Public_Static_Boolean_ptr_Void_ptr_Void_BitRegion_0, (System.IntPtr)0, (void**)ptr3, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 1019807, RefRangeEnd = 1019811, XrefRangeStart = 1019807, XrefRangeEnd = 1019807, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static uint ComputeFollowingByteOffset(uint byteOffset, uint sizeInBits)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&byteOffset);
		*(uint**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &sizeInBits;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ComputeFollowingByteOffset_Public_Static_UInt32_UInt32_UInt32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(uint*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 1019811, RefRangeEnd = 1019818, XrefRangeStart = 1019811, XrefRangeEnd = 1019811, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void WriteSingleBit(void* ptr, uint bitOffset, bool value)
	{
		System.IntPtr* ptr2 = stackalloc System.IntPtr[3];
		*ptr2 = (nint)ptr;
		*(uint**)((byte*)ptr2 + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &bitOffset;
		*(bool**)((byte*)ptr2 + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &value;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_WriteSingleBit_Public_Static_Void_ptr_Void_UInt32_Boolean_0, (System.IntPtr)0, (void**)ptr2, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 1019818, RefRangeEnd = 1019823, XrefRangeStart = 1019818, XrefRangeEnd = 1019818, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool ReadSingleBit(void* ptr, uint bitOffset)
	{
		System.IntPtr* ptr2 = stackalloc System.IntPtr[2];
		*ptr2 = (nint)ptr;
		*(uint**)((byte*)ptr2 + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &bitOffset;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ReadSingleBit_Public_Static_Boolean_ptr_Void_UInt32_0, (System.IntPtr)0, (void**)ptr2, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1019825, RefRangeEnd = 1019826, XrefRangeStart = 1019823, XrefRangeEnd = 1019825, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void MemCpyBitRegion(void* destination, void* source, uint bitOffset, uint bitCount)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)destination;
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = source;
		*(uint**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &bitOffset;
		*(uint**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &bitCount;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MemCpyBitRegion_Public_Static_Void_ptr_Void_ptr_Void_UInt32_UInt32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(8)]
	[CachedScanResults(RefRangeStart = 1019830, RefRangeEnd = 1019838, XrefRangeStart = 1019826, XrefRangeEnd = 1019830, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool MemCmpBitRegion(void* ptr1, void* ptr2, uint bitOffset, uint bitCount, void* mask = null)
	{
		System.IntPtr* ptr3 = stackalloc System.IntPtr[5];
		*ptr3 = (nint)ptr1;
		*(void**)((byte*)ptr3 + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = ptr2;
		*(uint**)((byte*)ptr3 + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &bitOffset;
		*(uint**)((byte*)ptr3 + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &bitCount;
		*(void**)((byte*)ptr3 + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = mask;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MemCmpBitRegion_Public_Static_Boolean_ptr_Void_ptr_Void_UInt32_UInt32_ptr_Void_0, (System.IntPtr)0, (void**)ptr3, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1019838, XrefRangeEnd = 1019839, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void MemSet(void* destination, int numBytes, byte value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)destination;
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &numBytes;
		*(byte**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &value;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MemSet_Public_Static_Void_ptr_Void_Int32_Byte_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1019839, RefRangeEnd = 1019840, XrefRangeStart = 1019839, XrefRangeEnd = 1019839, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void MemCpyMasked(void* destination, void* source, int numBytes, void* mask)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)destination;
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = source;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &numBytes;
		*(void**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = mask;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MemCpyMasked_Public_Static_Void_ptr_Void_ptr_Void_Int32_ptr_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 1019840, RefRangeEnd = 1019844, XrefRangeStart = 1019840, XrefRangeEnd = 1019840, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static uint ReadMultipleBitsAsUInt(void* ptr, uint bitOffset, uint bitCount)
	{
		System.IntPtr* ptr2 = stackalloc System.IntPtr[3];
		*ptr2 = (nint)ptr;
		*(uint**)((byte*)ptr2 + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &bitOffset;
		*(uint**)((byte*)ptr2 + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &bitCount;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ReadMultipleBitsAsUInt_Public_Static_UInt32_ptr_Void_UInt32_UInt32_0, (System.IntPtr)0, (void**)ptr2, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(uint*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1019844, RefRangeEnd = 1019847, XrefRangeStart = 1019844, XrefRangeEnd = 1019844, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void WriteUIntAsMultipleBits(void* ptr, uint bitOffset, uint bitCount, uint value)
	{
		System.IntPtr* ptr2 = stackalloc System.IntPtr[4];
		*ptr2 = (nint)ptr;
		*(uint**)((byte*)ptr2 + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &bitOffset;
		*(uint**)((byte*)ptr2 + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &bitCount;
		*(uint**)((byte*)ptr2 + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &value;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_WriteUIntAsMultipleBits_Public_Static_Void_ptr_Void_UInt32_UInt32_UInt32_0, (System.IntPtr)0, (void**)ptr2, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1019848, RefRangeEnd = 1019849, XrefRangeStart = 1019847, XrefRangeEnd = 1019848, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int ReadTwosComplementMultipleBitsAsInt(void* ptr, uint bitOffset, uint bitCount)
	{
		System.IntPtr* ptr2 = stackalloc System.IntPtr[3];
		*ptr2 = (nint)ptr;
		*(uint**)((byte*)ptr2 + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &bitOffset;
		*(uint**)((byte*)ptr2 + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &bitCount;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ReadTwosComplementMultipleBitsAsInt_Public_Static_Int32_ptr_Void_UInt32_UInt32_0, (System.IntPtr)0, (void**)ptr2, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1019850, RefRangeEnd = 1019851, XrefRangeStart = 1019849, XrefRangeEnd = 1019850, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void WriteIntAsTwosComplementMultipleBits(void* ptr, uint bitOffset, uint bitCount, int value)
	{
		System.IntPtr* ptr2 = stackalloc System.IntPtr[4];
		*ptr2 = (nint)ptr;
		*(uint**)((byte*)ptr2 + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &bitOffset;
		*(uint**)((byte*)ptr2 + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &bitCount;
		*(int**)((byte*)ptr2 + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &value;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_WriteIntAsTwosComplementMultipleBits_Public_Static_Void_ptr_Void_UInt32_UInt32_Int32_0, (System.IntPtr)0, (void**)ptr2, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1019851, XrefRangeEnd = 1019852, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int ReadExcessKMultipleBitsAsInt(void* ptr, uint bitOffset, uint bitCount)
	{
		System.IntPtr* ptr2 = stackalloc System.IntPtr[3];
		*ptr2 = (nint)ptr;
		*(uint**)((byte*)ptr2 + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &bitOffset;
		*(uint**)((byte*)ptr2 + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &bitCount;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ReadExcessKMultipleBitsAsInt_Public_Static_Int32_ptr_Void_UInt32_UInt32_0, (System.IntPtr)0, (void**)ptr2, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1019853, RefRangeEnd = 1019854, XrefRangeStart = 1019852, XrefRangeEnd = 1019853, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void WriteIntAsExcessKMultipleBits(void* ptr, uint bitOffset, uint bitCount, int value)
	{
		System.IntPtr* ptr2 = stackalloc System.IntPtr[4];
		*ptr2 = (nint)ptr;
		*(uint**)((byte*)ptr2 + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &bitOffset;
		*(uint**)((byte*)ptr2 + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &bitCount;
		*(int**)((byte*)ptr2 + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &value;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_WriteIntAsExcessKMultipleBits_Public_Static_Void_ptr_Void_UInt32_UInt32_Int32_0, (System.IntPtr)0, (void**)ptr2, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1019854, XrefRangeEnd = 1019855, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float ReadMultipleBitsAsNormalizedUInt(void* ptr, uint bitOffset, uint bitCount)
	{
		System.IntPtr* ptr2 = stackalloc System.IntPtr[3];
		*ptr2 = (nint)ptr;
		*(uint**)((byte*)ptr2 + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &bitOffset;
		*(uint**)((byte*)ptr2 + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &bitCount;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ReadMultipleBitsAsNormalizedUInt_Public_Static_Single_ptr_Void_UInt32_UInt32_0, (System.IntPtr)0, (void**)ptr2, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1019855, XrefRangeEnd = 1019858, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void WriteNormalizedUIntAsMultipleBits(void* ptr, uint bitOffset, uint bitCount, float value)
	{
		System.IntPtr* ptr2 = stackalloc System.IntPtr[4];
		*ptr2 = (nint)ptr;
		*(uint**)((byte*)ptr2 + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &bitOffset;
		*(uint**)((byte*)ptr2 + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &bitCount;
		*(float**)((byte*)ptr2 + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &value;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_WriteNormalizedUIntAsMultipleBits_Public_Static_Void_ptr_Void_UInt32_UInt32_Single_0, (System.IntPtr)0, (void**)ptr2, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 1019861, RefRangeEnd = 1019865, XrefRangeStart = 1019858, XrefRangeEnd = 1019861, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetBitsInBuffer(void* buffer, int byteOffset, int bitOffset, int sizeInBits, bool value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = (nint)buffer;
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &byteOffset;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &bitOffset;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &sizeInBits;
		*(bool**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &value;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetBitsInBuffer_Public_Static_Void_ptr_Void_Int32_Int32_Int32_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1016171, RefRangeEnd = 1016173, XrefRangeStart = 1016171, XrefRangeEnd = 1016173, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Swap<TValue>(ref TValue a, ref TValue b)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)Unsafe.As<TValue, object>(ref a));
		*ptr = (nint)(&intPtr);
		byte* num = (byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)));
		System.IntPtr intPtr2 = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)Unsafe.As<TValue, object>(ref b));
		*(System.IntPtr**)num = &intPtr2;
		Unsafe.SkipInit(out System.IntPtr intPtr3);
		System.IntPtr intPtr4 = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_Swap_Public_Static_Void_byref_TValue_byref_TValue_0<TValue>.Pointer, (System.IntPtr)0, (void**)ptr, ref intPtr3);
		Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		System.IntPtr intPtr5 = intPtr;
		Unsafe.As<TValue, object>(ref a) = ((intPtr5 == (System.IntPtr)0) ? ((TValue)null) : IL2CPP.PointerToValueGeneric<TValue>(intPtr5, false, false));
		System.IntPtr intPtr6 = intPtr2;
		Unsafe.As<TValue, object>(ref b) = ((intPtr6 == (System.IntPtr)0) ? ((TValue)null) : IL2CPP.PointerToValueGeneric<TValue>(intPtr6, false, false));
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1019869, RefRangeEnd = 1019870, XrefRangeStart = 1019865, XrefRangeEnd = 1019869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static uint AlignNatural(uint offset, uint sizeInBytes)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&offset);
		*(uint**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &sizeInBytes;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AlignNatural_Public_Static_UInt32_UInt32_UInt32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(uint*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	public MemoryHelpers(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
