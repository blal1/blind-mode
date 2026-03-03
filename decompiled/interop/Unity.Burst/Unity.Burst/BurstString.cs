using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Unity.Burst;

public static class BurstString : Il2CppSystem.Object
{
	public class PreserveAttribute : Il2CppSystem.Attribute
	{
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		static PreserveAttribute()
		{
			Il2CppClassPointerStore<PreserveAttribute>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BurstString>.NativeClassPtr, "PreserveAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PreserveAttribute>.NativeClassPtr);
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PreserveAttribute>.NativeClassPtr, 100663394);
		}

		[CallerCount(134)]
		[CachedScanResults(RefRangeStart = 24861, RefRangeEnd = 24995, XrefRangeStart = 24861, XrefRangeEnd = 24995, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PreserveAttribute()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PreserveAttribute>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		public PreserveAttribute(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[OriginalName("Unity.Burst.dll", "", "NumberBufferKind")]
	public enum NumberBufferKind
	{
		Integer,
		Float
	}

	[StructLayout(LayoutKind.Explicit)]
	public struct NumberBuffer
	{
		private static readonly System.IntPtr NativeFieldInfoPtr__buffer;

		private static readonly System.IntPtr NativeFieldInfoPtr_Kind;

		private static readonly System.IntPtr NativeFieldInfoPtr_DigitsCount;

		private static readonly System.IntPtr NativeFieldInfoPtr_Scale;

		private static readonly System.IntPtr NativeFieldInfoPtr_IsNegative;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_NumberBufferKind_ptr_Byte_Int32_Int32_Boolean_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_GetDigitsPointer_Public_ptr_Byte_0;

		[FieldOffset(0)]
		public readonly System.IntPtr _buffer;

		[FieldOffset(8)]
		public NumberBufferKind Kind;

		[FieldOffset(12)]
		public int DigitsCount;

		[FieldOffset(16)]
		public int Scale;

		[FieldOffset(20)]
		[MarshalAs(UnmanagedType.U1)]
		public readonly bool IsNegative;

		static NumberBuffer()
		{
			Il2CppClassPointerStore<NumberBuffer>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BurstString>.NativeClassPtr, "NumberBuffer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NumberBuffer>.NativeClassPtr);
			NativeFieldInfoPtr__buffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NumberBuffer>.NativeClassPtr, "_buffer");
			NativeFieldInfoPtr_Kind = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NumberBuffer>.NativeClassPtr, "Kind");
			NativeFieldInfoPtr_DigitsCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NumberBuffer>.NativeClassPtr, "DigitsCount");
			NativeFieldInfoPtr_Scale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NumberBuffer>.NativeClassPtr, "Scale");
			NativeFieldInfoPtr_IsNegative = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NumberBuffer>.NativeClassPtr, "IsNegative");
			NativeMethodInfoPtr__ctor_Public_Void_NumberBufferKind_ptr_Byte_Int32_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberBuffer>.NativeClassPtr, 100663395);
			NativeMethodInfoPtr_GetDigitsPointer_Public_ptr_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberBuffer>.NativeClassPtr, 100663396);
		}

		[CallerCount(0)]
		public unsafe NumberBuffer(NumberBufferKind kind, byte* buffer, int digitsCount, int scale, bool isNegative)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[5];
			*ptr = (nint)(&kind);
			*(byte**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = buffer;
			*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &digitsCount;
			*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &scale;
			*(bool**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &isNegative;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_NumberBufferKind_ptr_Byte_Int32_Int32_Boolean_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(98)]
		[CachedScanResults(RefRangeStart = 110111, RefRangeEnd = 110209, XrefRangeStart = 110111, XrefRangeEnd = 110209, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe byte* GetDigitsPointer()
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr result = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetDigitsPointer_Public_ptr_Byte_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (byte*)result;
		}

		public unsafe Il2CppSystem.Object BoxIl2CppObject()
		{
			return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NumberBuffer>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
		}
	}

	[OriginalName("Unity.Burst.dll", "", "NumberFormatKind")]
	public enum NumberFormatKind : byte
	{
		General,
		Decimal,
		DecimalForceSigned,
		Hexadecimal
	}

	[StructLayout(LayoutKind.Explicit)]
	public struct FormatOptions
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_Kind;

		private static readonly System.IntPtr NativeFieldInfoPtr_AlignAndSize;

		private static readonly System.IntPtr NativeFieldInfoPtr_Specifier;

		private static readonly System.IntPtr NativeFieldInfoPtr_Lowercase;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_NumberFormatKind_SByte_Byte_Boolean_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_Uppercase_Public_get_Boolean_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_GetBase_Public_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		[FieldOffset(0)]
		public NumberFormatKind Kind;

		[FieldOffset(1)]
		public sbyte AlignAndSize;

		[FieldOffset(2)]
		public byte Specifier;

		[FieldOffset(3)]
		[MarshalAs(UnmanagedType.U1)]
		public bool Lowercase;

		public unsafe bool Uppercase
		{
			[CallerCount(0)]
			get
			{
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Uppercase_Public_get_Boolean_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
			}
		}

		static FormatOptions()
		{
			Il2CppClassPointerStore<FormatOptions>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BurstString>.NativeClassPtr, "FormatOptions");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FormatOptions>.NativeClassPtr);
			NativeFieldInfoPtr_Kind = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FormatOptions>.NativeClassPtr, "Kind");
			NativeFieldInfoPtr_AlignAndSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FormatOptions>.NativeClassPtr, "AlignAndSize");
			NativeFieldInfoPtr_Specifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FormatOptions>.NativeClassPtr, "Specifier");
			NativeFieldInfoPtr_Lowercase = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FormatOptions>.NativeClassPtr, "Lowercase");
			NativeMethodInfoPtr__ctor_Public_Void_NumberFormatKind_SByte_Byte_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FormatOptions>.NativeClassPtr, 100663397);
			NativeMethodInfoPtr_get_Uppercase_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FormatOptions>.NativeClassPtr, 100663398);
			NativeMethodInfoPtr_GetBase_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FormatOptions>.NativeClassPtr, 100663399);
			NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FormatOptions>.NativeClassPtr, 100663400);
		}

		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 959176, RefRangeEnd = 959177, XrefRangeStart = 959176, XrefRangeEnd = 959176, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FormatOptions(NumberFormatKind kind, sbyte alignAndSize, byte specifier, bool lowercase)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[4];
			*ptr = (nint)(&kind);
			*(sbyte**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &alignAndSize;
			*(byte**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &specifier;
			*(bool**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &lowercase;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_NumberFormatKind_SByte_Byte_Boolean_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(0)]
		public unsafe int GetBase()
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetBase_Public_Int32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 959177, XrefRangeEnd = 959220, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToString_Public_Virtual_String_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return IL2CPP.Il2CppStringToManaged(intPtr2);
		}

		public unsafe Il2CppSystem.Object BoxIl2CppObject()
		{
			return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<FormatOptions>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
		}
	}

	[StructLayout(LayoutKind.Explicit)]
	public struct tBigInt
	{
		[StructLayout(LayoutKind.Explicit)]
		[ObfuscatedName("Unity.Burst.BurstString+tBigInt+<m_blocks>e__FixedBuffer")]
		public struct _m_blocks_e__FixedBuffer
		{
			private static readonly System.IntPtr NativeFieldInfoPtr_FixedElementField;

			[FieldOffset(0)]
			public uint FixedElementField;

			static _m_blocks_e__FixedBuffer()
			{
				Il2CppClassPointerStore<_m_blocks_e__FixedBuffer>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<tBigInt>.NativeClassPtr, "<m_blocks>e__FixedBuffer");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<_m_blocks_e__FixedBuffer>.NativeClassPtr);
				NativeFieldInfoPtr_FixedElementField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_m_blocks_e__FixedBuffer>.NativeClassPtr, "FixedElementField");
			}

			public unsafe Il2CppSystem.Object BoxIl2CppObject()
			{
				return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<_m_blocks_e__FixedBuffer>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
			}
		}

		private static readonly System.IntPtr NativeFieldInfoPtr_m_length;

		private static readonly System.IntPtr NativeFieldInfoPtr_m_blocks;

		private static readonly System.IntPtr NativeMethodInfoPtr_GetLength_Public_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_GetBlock_Public_UInt32_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_IsZero_Public_Boolean_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_SetU64_Public_Void_UInt64_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_SetU32_Public_Void_UInt32_0;

		[FieldOffset(0)]
		public int m_length;

		[FieldOffset(4)]
		public _m_blocks_e__FixedBuffer m_blocks;

		static tBigInt()
		{
			Il2CppClassPointerStore<tBigInt>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BurstString>.NativeClassPtr, "tBigInt");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<tBigInt>.NativeClassPtr);
			NativeFieldInfoPtr_m_length = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<tBigInt>.NativeClassPtr, "m_length");
			NativeFieldInfoPtr_m_blocks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<tBigInt>.NativeClassPtr, "m_blocks");
			NativeMethodInfoPtr_GetLength_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<tBigInt>.NativeClassPtr, 100663401);
			NativeMethodInfoPtr_GetBlock_Public_UInt32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<tBigInt>.NativeClassPtr, 100663402);
			NativeMethodInfoPtr_IsZero_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<tBigInt>.NativeClassPtr, 100663403);
			NativeMethodInfoPtr_SetU64_Public_Void_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<tBigInt>.NativeClassPtr, 100663404);
			NativeMethodInfoPtr_SetU32_Public_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<tBigInt>.NativeClassPtr, 100663405);
		}

		[CallerCount(175)]
		[CachedScanResults(RefRangeStart = 52464, RefRangeEnd = 52639, XrefRangeStart = 52464, XrefRangeEnd = 52639, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetLength()
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetLength_Public_Int32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		[CallerCount(0)]
		public unsafe uint GetBlock(int idx)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&idx);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetBlock_Public_UInt32_Int32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(uint*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 87177, RefRangeEnd = 87189, XrefRangeStart = 87177, XrefRangeEnd = 87189, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsZero()
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsZero_Public_Boolean_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		[CallerCount(0)]
		public unsafe void SetU64(ulong val)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&val);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetU64_Public_Void_UInt64_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(0)]
		public unsafe void SetU32(uint val)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&val);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetU32_Public_Void_UInt32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		public unsafe Il2CppSystem.Object BoxIl2CppObject()
		{
			return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<tBigInt>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
		}
	}

	[OriginalName("Unity.Burst.dll", "", "CutoffMode")]
	public enum CutoffMode
	{
		Unique,
		TotalLength,
		FractionLength
	}

	[StructLayout(LayoutKind.Explicit)]
	public struct tFloatUnion32
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_m_floatingPoint;

		private static readonly System.IntPtr NativeFieldInfoPtr_m_integer;

		private static readonly System.IntPtr NativeMethodInfoPtr_IsNegative_Public_Boolean_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_GetExponent_Public_UInt32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_GetMantissa_Public_UInt32_0;

		[FieldOffset(0)]
		public float m_floatingPoint;

		[FieldOffset(0)]
		public uint m_integer;

		static tFloatUnion32()
		{
			Il2CppClassPointerStore<tFloatUnion32>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BurstString>.NativeClassPtr, "tFloatUnion32");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<tFloatUnion32>.NativeClassPtr);
			NativeFieldInfoPtr_m_floatingPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<tFloatUnion32>.NativeClassPtr, "m_floatingPoint");
			NativeFieldInfoPtr_m_integer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<tFloatUnion32>.NativeClassPtr, "m_integer");
			NativeMethodInfoPtr_IsNegative_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<tFloatUnion32>.NativeClassPtr, 100663406);
			NativeMethodInfoPtr_GetExponent_Public_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<tFloatUnion32>.NativeClassPtr, 100663407);
			NativeMethodInfoPtr_GetMantissa_Public_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<tFloatUnion32>.NativeClassPtr, 100663408);
		}

		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 765814, RefRangeEnd = 765815, XrefRangeStart = 765814, XrefRangeEnd = 765815, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsNegative()
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsNegative_Public_Boolean_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		[CallerCount(0)]
		public unsafe uint GetExponent()
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetExponent_Public_UInt32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(uint*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		[CallerCount(0)]
		public unsafe uint GetMantissa()
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetMantissa_Public_UInt32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(uint*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		public unsafe Il2CppSystem.Object BoxIl2CppObject()
		{
			return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<tFloatUnion32>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
		}
	}

	[StructLayout(LayoutKind.Explicit)]
	public struct tFloatUnion64
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_m_floatingPoint;

		private static readonly System.IntPtr NativeFieldInfoPtr_m_integer;

		private static readonly System.IntPtr NativeMethodInfoPtr_IsNegative_Public_Boolean_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_GetExponent_Public_UInt32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_GetMantissa_Public_UInt64_0;

		[FieldOffset(0)]
		public double m_floatingPoint;

		[FieldOffset(0)]
		public ulong m_integer;

		static tFloatUnion64()
		{
			Il2CppClassPointerStore<tFloatUnion64>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BurstString>.NativeClassPtr, "tFloatUnion64");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<tFloatUnion64>.NativeClassPtr);
			NativeFieldInfoPtr_m_floatingPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<tFloatUnion64>.NativeClassPtr, "m_floatingPoint");
			NativeFieldInfoPtr_m_integer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<tFloatUnion64>.NativeClassPtr, "m_integer");
			NativeMethodInfoPtr_IsNegative_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<tFloatUnion64>.NativeClassPtr, 100663409);
			NativeMethodInfoPtr_GetExponent_Public_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<tFloatUnion64>.NativeClassPtr, 100663410);
			NativeMethodInfoPtr_GetMantissa_Public_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<tFloatUnion64>.NativeClassPtr, 100663411);
		}

		[CallerCount(0)]
		public unsafe bool IsNegative()
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsNegative_Public_Boolean_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		[CallerCount(0)]
		public unsafe uint GetExponent()
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetExponent_Public_UInt32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(uint*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		[CallerCount(0)]
		public unsafe ulong GetMantissa()
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetMantissa_Public_UInt64_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(ulong*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		public unsafe Il2CppSystem.Object BoxIl2CppObject()
		{
			return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<tFloatUnion64>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_SplitByColon;

	private static readonly System.IntPtr NativeFieldInfoPtr_logTable;

	private static readonly System.IntPtr NativeFieldInfoPtr_g_PowerOf10_U32;

	private static readonly System.IntPtr NativeFieldInfoPtr_InfinityString;

	private static readonly System.IntPtr NativeFieldInfoPtr_NanString;

	private static readonly System.IntPtr NativeMethodInfoPtr_CopyFixedString_Public_Static_Void_ptr_Byte_Int32_ptr_Byte_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Format_Public_Static_Void_ptr_Byte_byref_Int32_Int32_ptr_Byte_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Format_Public_Static_Void_ptr_Byte_byref_Int32_Int32_Single_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Format_Public_Static_Void_ptr_Byte_byref_Int32_Int32_Double_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Format_Public_Static_Void_ptr_Byte_byref_Int32_Int32_Boolean_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Format_Public_Static_Void_ptr_Byte_byref_Int32_Int32_Char_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Format_Public_Static_Void_ptr_Byte_byref_Int32_Int32_Byte_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Format_Public_Static_Void_ptr_Byte_byref_Int32_Int32_UInt16_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Format_Public_Static_Void_ptr_Byte_byref_Int32_Int32_UInt32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Format_Public_Static_Void_ptr_Byte_byref_Int32_Int32_UInt64_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Format_Public_Static_Void_ptr_Byte_byref_Int32_Int32_SByte_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Format_Public_Static_Void_ptr_Byte_byref_Int32_Int32_Int16_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Format_Public_Static_Void_ptr_Byte_byref_Int32_Int32_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Format_Public_Static_Void_ptr_Byte_byref_Int32_Int32_Int64_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ConvertUnsignedIntegerToString_Private_Static_Void_ptr_Byte_byref_Int32_Int32_UInt64_FormatOptions_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetLengthIntegerToString_Private_Static_Int32_Int64_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ConvertIntegerToString_Private_Static_Void_ptr_Byte_byref_Int32_Int32_Int64_FormatOptions_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FormatNumber_Private_Static_Void_ptr_Byte_byref_Int32_Int32_byref_NumberBuffer_Int32_FormatOptions_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FormatDecimalOrHexadecimal_Private_Static_Void_ptr_Byte_byref_Int32_Int32_byref_NumberBuffer_Int32_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ValueToIntegerChar_Private_Static_Byte_Int32_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AlignRight_Private_Static_Boolean_ptr_Byte_byref_Int32_Int32_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AlignLeft_Private_Static_Boolean_ptr_Byte_byref_Int32_Int32_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetLengthForFormatGeneral_Private_Static_Int32_byref_NumberBuffer_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FormatGeneral_Private_Static_Void_ptr_Byte_byref_Int32_Int32_byref_NumberBuffer_Int32_Byte_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RoundNumber_Private_Static_Void_byref_NumberBuffer_Int32_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ShouldRoundUp_Private_Static_Boolean_ptr_Byte_Int32_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LogBase2_Private_Static_UInt32_UInt32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_BigInt_Compare_Private_Static_Int32_byref_tBigInt_byref_tBigInt_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_BigInt_Add_Private_Static_Void_byref_tBigInt_byref_tBigInt_byref_tBigInt_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_BigInt_Add_internal_Private_Static_Void_byref_tBigInt_byref_tBigInt_byref_tBigInt_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_BigInt_Multiply_Private_Static_Void_byref_tBigInt_byref_tBigInt_byref_tBigInt_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_BigInt_Multiply_internal_Private_Static_Void_byref_tBigInt_byref_tBigInt_byref_tBigInt_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_BigInt_Multiply_Private_Static_Void_byref_tBigInt_byref_tBigInt_UInt32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_BigInt_Multiply2_Private_Static_Void_byref_tBigInt_byref_tBigInt_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_BigInt_Multiply2_Private_Static_Void_byref_tBigInt_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_BigInt_Multiply10_Private_Static_Void_byref_tBigInt_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_g_PowerOf10_Big_Private_Static_tBigInt_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_BigInt_Pow10_Private_Static_Void_byref_tBigInt_UInt32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_BigInt_MultiplyPow10_Private_Static_Void_byref_tBigInt_byref_tBigInt_UInt32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_BigInt_Pow2_Private_Static_Void_byref_tBigInt_UInt32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_BigInt_DivideWithRemainder_MaxQuotient9_Private_Static_UInt32_byref_tBigInt_byref_tBigInt_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_BigInt_ShiftLeft_Private_Static_Void_byref_tBigInt_UInt32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Dragon4_Private_Static_UInt32_UInt64_Int32_UInt32_Boolean_CutoffMode_UInt32_ptr_Byte_UInt32_byref_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FormatInfinityNaN_Private_Static_Void_ptr_Byte_byref_Int32_Int32_UInt64_Boolean_FormatOptions_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ConvertFloatToString_Private_Static_Void_ptr_Byte_byref_Int32_Int32_Single_FormatOptions_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ConvertDoubleToString_Private_Static_Void_ptr_Byte_byref_Int32_Int32_Double_FormatOptions_0;

	public unsafe static Il2CppStructArray<char> SplitByColon
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_SplitByColon, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<char>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_SplitByColon, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Il2CppStructArray<byte> logTable
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_logTable, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_logTable, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Il2CppStructArray<uint> g_PowerOf10_U32
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_g_PowerOf10_U32, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<uint>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_g_PowerOf10_U32, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Il2CppStructArray<byte> InfinityString
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_InfinityString, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_InfinityString, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Il2CppStructArray<byte> NanString
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_NanString, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_NanString, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	static BurstString()
	{
		Il2CppClassPointerStore<BurstString>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Burst.dll", "Unity.Burst", "BurstString");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BurstString>.NativeClassPtr);
		NativeFieldInfoPtr_SplitByColon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BurstString>.NativeClassPtr, "SplitByColon");
		NativeFieldInfoPtr_logTable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BurstString>.NativeClassPtr, "logTable");
		NativeFieldInfoPtr_g_PowerOf10_U32 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BurstString>.NativeClassPtr, "g_PowerOf10_U32");
		NativeFieldInfoPtr_InfinityString = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BurstString>.NativeClassPtr, "InfinityString");
		NativeFieldInfoPtr_NanString = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BurstString>.NativeClassPtr, "NanString");
		NativeMethodInfoPtr_CopyFixedString_Public_Static_Void_ptr_Byte_Int32_ptr_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstString>.NativeClassPtr, 100663347);
		NativeMethodInfoPtr_Format_Public_Static_Void_ptr_Byte_byref_Int32_Int32_ptr_Byte_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstString>.NativeClassPtr, 100663348);
		NativeMethodInfoPtr_Format_Public_Static_Void_ptr_Byte_byref_Int32_Int32_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstString>.NativeClassPtr, 100663349);
		NativeMethodInfoPtr_Format_Public_Static_Void_ptr_Byte_byref_Int32_Int32_Double_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstString>.NativeClassPtr, 100663350);
		NativeMethodInfoPtr_Format_Public_Static_Void_ptr_Byte_byref_Int32_Int32_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstString>.NativeClassPtr, 100663351);
		NativeMethodInfoPtr_Format_Public_Static_Void_ptr_Byte_byref_Int32_Int32_Char_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstString>.NativeClassPtr, 100663352);
		NativeMethodInfoPtr_Format_Public_Static_Void_ptr_Byte_byref_Int32_Int32_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstString>.NativeClassPtr, 100663353);
		NativeMethodInfoPtr_Format_Public_Static_Void_ptr_Byte_byref_Int32_Int32_UInt16_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstString>.NativeClassPtr, 100663354);
		NativeMethodInfoPtr_Format_Public_Static_Void_ptr_Byte_byref_Int32_Int32_UInt32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstString>.NativeClassPtr, 100663355);
		NativeMethodInfoPtr_Format_Public_Static_Void_ptr_Byte_byref_Int32_Int32_UInt64_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstString>.NativeClassPtr, 100663356);
		NativeMethodInfoPtr_Format_Public_Static_Void_ptr_Byte_byref_Int32_Int32_SByte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstString>.NativeClassPtr, 100663357);
		NativeMethodInfoPtr_Format_Public_Static_Void_ptr_Byte_byref_Int32_Int32_Int16_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstString>.NativeClassPtr, 100663358);
		NativeMethodInfoPtr_Format_Public_Static_Void_ptr_Byte_byref_Int32_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstString>.NativeClassPtr, 100663359);
		NativeMethodInfoPtr_Format_Public_Static_Void_ptr_Byte_byref_Int32_Int32_Int64_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstString>.NativeClassPtr, 100663360);
		NativeMethodInfoPtr_ConvertUnsignedIntegerToString_Private_Static_Void_ptr_Byte_byref_Int32_Int32_UInt64_FormatOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstString>.NativeClassPtr, 100663361);
		NativeMethodInfoPtr_GetLengthIntegerToString_Private_Static_Int32_Int64_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstString>.NativeClassPtr, 100663362);
		NativeMethodInfoPtr_ConvertIntegerToString_Private_Static_Void_ptr_Byte_byref_Int32_Int32_Int64_FormatOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstString>.NativeClassPtr, 100663363);
		NativeMethodInfoPtr_FormatNumber_Private_Static_Void_ptr_Byte_byref_Int32_Int32_byref_NumberBuffer_Int32_FormatOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstString>.NativeClassPtr, 100663364);
		NativeMethodInfoPtr_FormatDecimalOrHexadecimal_Private_Static_Void_ptr_Byte_byref_Int32_Int32_byref_NumberBuffer_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstString>.NativeClassPtr, 100663365);
		NativeMethodInfoPtr_ValueToIntegerChar_Private_Static_Byte_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstString>.NativeClassPtr, 100663366);
		NativeMethodInfoPtr_AlignRight_Private_Static_Boolean_ptr_Byte_byref_Int32_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstString>.NativeClassPtr, 100663367);
		NativeMethodInfoPtr_AlignLeft_Private_Static_Boolean_ptr_Byte_byref_Int32_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstString>.NativeClassPtr, 100663368);
		NativeMethodInfoPtr_GetLengthForFormatGeneral_Private_Static_Int32_byref_NumberBuffer_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstString>.NativeClassPtr, 100663369);
		NativeMethodInfoPtr_FormatGeneral_Private_Static_Void_ptr_Byte_byref_Int32_Int32_byref_NumberBuffer_Int32_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstString>.NativeClassPtr, 100663370);
		NativeMethodInfoPtr_RoundNumber_Private_Static_Void_byref_NumberBuffer_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstString>.NativeClassPtr, 100663371);
		NativeMethodInfoPtr_ShouldRoundUp_Private_Static_Boolean_ptr_Byte_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstString>.NativeClassPtr, 100663372);
		NativeMethodInfoPtr_LogBase2_Private_Static_UInt32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstString>.NativeClassPtr, 100663373);
		NativeMethodInfoPtr_BigInt_Compare_Private_Static_Int32_byref_tBigInt_byref_tBigInt_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstString>.NativeClassPtr, 100663374);
		NativeMethodInfoPtr_BigInt_Add_Private_Static_Void_byref_tBigInt_byref_tBigInt_byref_tBigInt_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstString>.NativeClassPtr, 100663375);
		NativeMethodInfoPtr_BigInt_Add_internal_Private_Static_Void_byref_tBigInt_byref_tBigInt_byref_tBigInt_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstString>.NativeClassPtr, 100663376);
		NativeMethodInfoPtr_BigInt_Multiply_Private_Static_Void_byref_tBigInt_byref_tBigInt_byref_tBigInt_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstString>.NativeClassPtr, 100663377);
		NativeMethodInfoPtr_BigInt_Multiply_internal_Private_Static_Void_byref_tBigInt_byref_tBigInt_byref_tBigInt_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstString>.NativeClassPtr, 100663378);
		NativeMethodInfoPtr_BigInt_Multiply_Private_Static_Void_byref_tBigInt_byref_tBigInt_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstString>.NativeClassPtr, 100663379);
		NativeMethodInfoPtr_BigInt_Multiply2_Private_Static_Void_byref_tBigInt_byref_tBigInt_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstString>.NativeClassPtr, 100663380);
		NativeMethodInfoPtr_BigInt_Multiply2_Private_Static_Void_byref_tBigInt_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstString>.NativeClassPtr, 100663381);
		NativeMethodInfoPtr_BigInt_Multiply10_Private_Static_Void_byref_tBigInt_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstString>.NativeClassPtr, 100663382);
		NativeMethodInfoPtr_g_PowerOf10_Big_Private_Static_tBigInt_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstString>.NativeClassPtr, 100663383);
		NativeMethodInfoPtr_BigInt_Pow10_Private_Static_Void_byref_tBigInt_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstString>.NativeClassPtr, 100663384);
		NativeMethodInfoPtr_BigInt_MultiplyPow10_Private_Static_Void_byref_tBigInt_byref_tBigInt_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstString>.NativeClassPtr, 100663385);
		NativeMethodInfoPtr_BigInt_Pow2_Private_Static_Void_byref_tBigInt_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstString>.NativeClassPtr, 100663386);
		NativeMethodInfoPtr_BigInt_DivideWithRemainder_MaxQuotient9_Private_Static_UInt32_byref_tBigInt_byref_tBigInt_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstString>.NativeClassPtr, 100663387);
		NativeMethodInfoPtr_BigInt_ShiftLeft_Private_Static_Void_byref_tBigInt_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstString>.NativeClassPtr, 100663388);
		NativeMethodInfoPtr_Dragon4_Private_Static_UInt32_UInt64_Int32_UInt32_Boolean_CutoffMode_UInt32_ptr_Byte_UInt32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstString>.NativeClassPtr, 100663389);
		NativeMethodInfoPtr_FormatInfinityNaN_Private_Static_Void_ptr_Byte_byref_Int32_Int32_UInt64_Boolean_FormatOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstString>.NativeClassPtr, 100663390);
		NativeMethodInfoPtr_ConvertFloatToString_Private_Static_Void_ptr_Byte_byref_Int32_Int32_Single_FormatOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstString>.NativeClassPtr, 100663391);
		NativeMethodInfoPtr_ConvertDoubleToString_Private_Static_Void_ptr_Byte_byref_Int32_Int32_Double_FormatOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstString>.NativeClassPtr, 100663392);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 959220, XrefRangeEnd = 959221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void CopyFixedString(byte* dest, int destLength, byte* src, int srcLength)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)dest;
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &destLength;
		*(byte**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = src;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &srcLength;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CopyFixedString_Public_Static_Void_ptr_Byte_Int32_ptr_Byte_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 959221, XrefRangeEnd = 959228, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Format(byte* dest, ref int destIndex, int destLength, byte* src, int srcLength, int formatOptionsRaw)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = (nint)dest;
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref destIndex);
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &destLength;
		*(byte**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = src;
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &srcLength;
		*(int**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &formatOptionsRaw;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Format_Public_Static_Void_ptr_Byte_byref_Int32_Int32_ptr_Byte_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 959228, XrefRangeEnd = 959232, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Format(byte* dest, ref int destIndex, int destLength, float value, int formatOptionsRaw)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = (nint)dest;
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref destIndex);
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &destLength;
		*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &value;
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &formatOptionsRaw;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Format_Public_Static_Void_ptr_Byte_byref_Int32_Int32_Single_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 959232, XrefRangeEnd = 959236, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Format(byte* dest, ref int destIndex, int destLength, double value, int formatOptionsRaw)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = (nint)dest;
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref destIndex);
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &destLength;
		*(double**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &value;
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &formatOptionsRaw;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Format_Public_Static_Void_ptr_Byte_byref_Int32_Int32_Double_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 959236, XrefRangeEnd = 959243, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Format(byte* dest, ref int destIndex, int destLength, bool value, int formatOptionsRaw)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = (nint)dest;
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref destIndex);
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &destLength;
		*(bool**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &value;
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &formatOptionsRaw;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Format_Public_Static_Void_ptr_Byte_byref_Int32_Int32_Boolean_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 959243, XrefRangeEnd = 959253, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Format(byte* dest, ref int destIndex, int destLength, char value, int formatOptionsRaw)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = (nint)dest;
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref destIndex);
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &destLength;
		*(char**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &value;
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &formatOptionsRaw;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Format_Public_Static_Void_ptr_Byte_byref_Int32_Int32_Char_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 959253, XrefRangeEnd = 959260, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Format(byte* dest, ref int destIndex, int destLength, byte value, int formatOptionsRaw)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = (nint)dest;
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref destIndex);
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &destLength;
		*(byte**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &value;
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &formatOptionsRaw;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Format_Public_Static_Void_ptr_Byte_byref_Int32_Int32_Byte_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 959260, XrefRangeEnd = 959267, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Format(byte* dest, ref int destIndex, int destLength, ushort value, int formatOptionsRaw)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = (nint)dest;
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref destIndex);
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &destLength;
		*(ushort**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &value;
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &formatOptionsRaw;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Format_Public_Static_Void_ptr_Byte_byref_Int32_Int32_UInt16_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 959267, XrefRangeEnd = 959271, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Format(byte* dest, ref int destIndex, int destLength, uint value, int formatOptionsRaw)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = (nint)dest;
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref destIndex);
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &destLength;
		*(uint**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &value;
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &formatOptionsRaw;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Format_Public_Static_Void_ptr_Byte_byref_Int32_Int32_UInt32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 959271, XrefRangeEnd = 959275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Format(byte* dest, ref int destIndex, int destLength, ulong value, int formatOptionsRaw)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = (nint)dest;
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref destIndex);
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &destLength;
		*(ulong**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &value;
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &formatOptionsRaw;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Format_Public_Static_Void_ptr_Byte_byref_Int32_Int32_UInt64_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 959275, XrefRangeEnd = 959282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Format(byte* dest, ref int destIndex, int destLength, sbyte value, int formatOptionsRaw)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = (nint)dest;
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref destIndex);
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &destLength;
		*(sbyte**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &value;
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &formatOptionsRaw;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Format_Public_Static_Void_ptr_Byte_byref_Int32_Int32_SByte_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 959282, XrefRangeEnd = 959289, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Format(byte* dest, ref int destIndex, int destLength, short value, int formatOptionsRaw)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = (nint)dest;
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref destIndex);
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &destLength;
		*(short**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &value;
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &formatOptionsRaw;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Format_Public_Static_Void_ptr_Byte_byref_Int32_Int32_Int16_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 959289, XrefRangeEnd = 959296, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Format(byte* dest, ref int destIndex, int destLength, int value, int formatOptionsRaw)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = (nint)dest;
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref destIndex);
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &destLength;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &value;
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &formatOptionsRaw;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Format_Public_Static_Void_ptr_Byte_byref_Int32_Int32_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 959296, XrefRangeEnd = 959303, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Format(byte* dest, ref int destIndex, int destLength, long value, int formatOptionsRaw)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = (nint)dest;
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref destIndex);
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &destLength;
		*(long**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &value;
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &formatOptionsRaw;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Format_Public_Static_Void_ptr_Byte_byref_Int32_Int32_Int64_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(8)]
	[CachedScanResults(RefRangeStart = 959314, RefRangeEnd = 959322, XrefRangeStart = 959303, XrefRangeEnd = 959314, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ConvertUnsignedIntegerToString(byte* dest, ref int destIndex, int destLength, ulong value, FormatOptions options)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = (nint)dest;
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref destIndex);
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &destLength;
		*(ulong**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &value;
		*(FormatOptions**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &options;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ConvertUnsignedIntegerToString_Private_Static_Void_ptr_Byte_byref_Int32_Int32_UInt64_FormatOptions_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	public unsafe static int GetLengthIntegerToString(long value, int basis, int zeroPadding)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&value);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &basis;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &zeroPadding;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetLengthIntegerToString_Private_Static_Int32_Int64_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 959333, RefRangeEnd = 959338, XrefRangeStart = 959322, XrefRangeEnd = 959333, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ConvertIntegerToString(byte* dest, ref int destIndex, int destLength, long value, FormatOptions options)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = (nint)dest;
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref destIndex);
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &destLength;
		*(long**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &value;
		*(FormatOptions**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &options;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ConvertIntegerToString_Private_Static_Void_ptr_Byte_byref_Int32_Int32_Int64_FormatOptions_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 959358, RefRangeEnd = 959362, XrefRangeStart = 959338, XrefRangeEnd = 959358, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void FormatNumber(byte* dest, ref int destIndex, int destLength, ref NumberBuffer number, int nMaxDigits, FormatOptions options)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = (nint)dest;
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref destIndex);
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &destLength;
		*(void**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref number);
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &nMaxDigits;
		*(FormatOptions**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &options;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FormatNumber_Private_Static_Void_ptr_Byte_byref_Int32_Int32_byref_NumberBuffer_Int32_FormatOptions_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 959362, XrefRangeEnd = 959363, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void FormatDecimalOrHexadecimal(byte* dest, ref int destIndex, int destLength, ref NumberBuffer number, int zeroPadding, bool outputPositiveSign)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = (nint)dest;
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref destIndex);
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &destLength;
		*(void**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref number);
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &zeroPadding;
		*(bool**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &outputPositiveSign;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FormatDecimalOrHexadecimal_Private_Static_Void_ptr_Byte_byref_Int32_Int32_byref_NumberBuffer_Int32_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	public unsafe static byte ValueToIntegerChar(int value, bool uppercase)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&value);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &uppercase;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ValueToIntegerChar_Private_Static_Byte_Int32_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(byte*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 959366, RefRangeEnd = 959371, XrefRangeStart = 959363, XrefRangeEnd = 959366, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool AlignRight(byte* dest, ref int destIndex, int destLength, int align, int length)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = (nint)dest;
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref destIndex);
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &destLength;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &align;
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &length;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AlignRight_Private_Static_Boolean_ptr_Byte_byref_Int32_Int32_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe static bool AlignLeft(byte* dest, ref int destIndex, int destLength, int align, int length)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = (nint)dest;
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref destIndex);
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &destLength;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &align;
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &length;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AlignLeft_Private_Static_Boolean_ptr_Byte_byref_Int32_Int32_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 959375, RefRangeEnd = 959376, XrefRangeStart = 959371, XrefRangeEnd = 959375, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int GetLengthForFormatGeneral(ref NumberBuffer number, int nMaxDigits)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)Unsafe.AsPointer(ref number);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &nMaxDigits;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetLengthForFormatGeneral_Private_Static_Int32_byref_NumberBuffer_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 959382, RefRangeEnd = 959383, XrefRangeStart = 959376, XrefRangeEnd = 959382, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void FormatGeneral(byte* dest, ref int destIndex, int destLength, ref NumberBuffer number, int nMaxDigits, byte expChar)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = (nint)dest;
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref destIndex);
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &destLength;
		*(void**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref number);
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &nMaxDigits;
		*(byte**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &expChar;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FormatGeneral_Private_Static_Void_ptr_Byte_byref_Int32_Int32_byref_NumberBuffer_Int32_Byte_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 959383, XrefRangeEnd = 959388, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void RoundNumber(ref NumberBuffer number, int pos, bool isCorrectlyRounded)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)Unsafe.AsPointer(ref number);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &pos;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &isCorrectlyRounded;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RoundNumber_Private_Static_Void_byref_NumberBuffer_Int32_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	public unsafe static bool ShouldRoundUp(byte* dig, int i, bool isCorrectlyRounded)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)dig;
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &i;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &isCorrectlyRounded;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ShouldRoundUp_Private_Static_Boolean_ptr_Byte_Int32_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 959392, RefRangeEnd = 959395, XrefRangeStart = 959388, XrefRangeEnd = 959392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static uint LogBase2(uint val)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&val);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LogBase2_Private_Static_UInt32_UInt32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(uint*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe static int BigInt_Compare([In] ref tBigInt lhs, [In] ref tBigInt rhs)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)Unsafe.AsPointer(ref lhs);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref rhs);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_BigInt_Compare_Private_Static_Int32_byref_tBigInt_byref_tBigInt_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 959395, XrefRangeEnd = 959401, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void BigInt_Add(out tBigInt pResult, [In] ref tBigInt lhs, [In] ref tBigInt rhs)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)Unsafe.AsPointer(ref pResult);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref lhs);
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref rhs);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_BigInt_Add_Private_Static_Void_byref_tBigInt_byref_tBigInt_byref_tBigInt_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 959402, RefRangeEnd = 959404, XrefRangeStart = 959401, XrefRangeEnd = 959402, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void BigInt_Add_internal(out tBigInt pResult, [In] ref tBigInt pLarge, [In] ref tBigInt pSmall)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)Unsafe.AsPointer(ref pResult);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref pLarge);
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref pSmall);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_BigInt_Add_internal_Private_Static_Void_byref_tBigInt_byref_tBigInt_byref_tBigInt_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 959410, RefRangeEnd = 959413, XrefRangeStart = 959404, XrefRangeEnd = 959410, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void BigInt_Multiply(out tBigInt pResult, [In] ref tBigInt lhs, [In] ref tBigInt rhs)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)Unsafe.AsPointer(ref pResult);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref lhs);
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref rhs);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_BigInt_Multiply_Private_Static_Void_byref_tBigInt_byref_tBigInt_byref_tBigInt_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 959415, RefRangeEnd = 959418, XrefRangeStart = 959413, XrefRangeEnd = 959415, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void BigInt_Multiply_internal(out tBigInt pResult, [In] ref tBigInt pLarge, [In] ref tBigInt pSmall)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)Unsafe.AsPointer(ref pResult);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref pLarge);
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref pSmall);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_BigInt_Multiply_internal_Private_Static_Void_byref_tBigInt_byref_tBigInt_byref_tBigInt_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	public unsafe static void BigInt_Multiply(out tBigInt pResult, [In] ref tBigInt lhs, uint rhs)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)Unsafe.AsPointer(ref pResult);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref lhs);
		*(uint**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &rhs;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_BigInt_Multiply_Private_Static_Void_byref_tBigInt_byref_tBigInt_UInt32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	public unsafe static void BigInt_Multiply2(out tBigInt pResult, [In] ref tBigInt input)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)Unsafe.AsPointer(ref pResult);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref input);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_BigInt_Multiply2_Private_Static_Void_byref_tBigInt_byref_tBigInt_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	public unsafe static void BigInt_Multiply2(ref tBigInt pResult)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)Unsafe.AsPointer(ref pResult);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_BigInt_Multiply2_Private_Static_Void_byref_tBigInt_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	public unsafe static void BigInt_Multiply10(ref tBigInt pResult)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)Unsafe.AsPointer(ref pResult);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_BigInt_Multiply10_Private_Static_Void_byref_tBigInt_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 959418, RefRangeEnd = 959421, XrefRangeStart = 959418, XrefRangeEnd = 959418, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static tBigInt g_PowerOf10_Big(int i)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&i);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_g_PowerOf10_Big_Private_Static_tBigInt_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(tBigInt*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 959421, XrefRangeEnd = 959430, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void BigInt_Pow10(out tBigInt pResult, uint exponent)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)Unsafe.AsPointer(ref pResult);
		*(uint**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &exponent;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_BigInt_Pow10_Private_Static_Void_byref_tBigInt_UInt32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 959440, RefRangeEnd = 959441, XrefRangeStart = 959430, XrefRangeEnd = 959440, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void BigInt_MultiplyPow10(out tBigInt pResult, [In] ref tBigInt input, uint exponent)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)Unsafe.AsPointer(ref pResult);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref input);
		*(uint**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &exponent;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_BigInt_MultiplyPow10_Private_Static_Void_byref_tBigInt_byref_tBigInt_UInt32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	public unsafe static void BigInt_Pow2(out tBigInt pResult, uint exponent)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)Unsafe.AsPointer(ref pResult);
		*(uint**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &exponent;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_BigInt_Pow2_Private_Static_Void_byref_tBigInt_UInt32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 959446, RefRangeEnd = 959448, XrefRangeStart = 959441, XrefRangeEnd = 959446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static uint BigInt_DivideWithRemainder_MaxQuotient9(ref tBigInt pDividend, [In] ref tBigInt divisor)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)Unsafe.AsPointer(ref pDividend);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref divisor);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_BigInt_DivideWithRemainder_MaxQuotient9_Private_Static_UInt32_byref_tBigInt_byref_tBigInt_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(uint*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 959448, RefRangeEnd = 959453, XrefRangeStart = 959448, XrefRangeEnd = 959448, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void BigInt_ShiftLeft(ref tBigInt pResult, uint shift)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)Unsafe.AsPointer(ref pResult);
		*(uint**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &shift;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_BigInt_ShiftLeft_Private_Static_Void_byref_tBigInt_UInt32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 959562, RefRangeEnd = 959564, XrefRangeStart = 959453, XrefRangeEnd = 959562, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static uint Dragon4(ulong mantissa, int exponent, uint mantissaHighBitIdx, bool hasUnequalMargins, CutoffMode cutoffMode, uint cutoffNumber, byte* pOutBuffer, uint bufferSize, out int pOutExponent)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[9];
		*ptr = (nint)(&mantissa);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &exponent;
		*(uint**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &mantissaHighBitIdx;
		*(bool**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &hasUnequalMargins;
		*(CutoffMode**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &cutoffMode;
		*(uint**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &cutoffNumber;
		*(byte**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = pOutBuffer;
		*(uint**)((byte*)ptr + checked((nuint)7u * unchecked((nuint)sizeof(System.IntPtr)))) = &bufferSize;
		*(void**)((byte*)ptr + checked((nuint)8u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref pOutExponent);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Dragon4_Private_Static_UInt32_UInt64_Int32_UInt32_Boolean_CutoffMode_UInt32_ptr_Byte_UInt32_byref_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(uint*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 959577, RefRangeEnd = 959579, XrefRangeStart = 959564, XrefRangeEnd = 959577, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void FormatInfinityNaN(byte* dest, ref int destIndex, int destLength, ulong mantissa, bool isNegative, FormatOptions formatOptions)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = (nint)dest;
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref destIndex);
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &destLength;
		*(ulong**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &mantissa;
		*(bool**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &isNegative;
		*(FormatOptions**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &formatOptions;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FormatInfinityNaN_Private_Static_Void_ptr_Byte_byref_Int32_Int32_UInt64_Boolean_FormatOptions_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 959601, RefRangeEnd = 959602, XrefRangeStart = 959579, XrefRangeEnd = 959601, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ConvertFloatToString(byte* dest, ref int destIndex, int destLength, float value, FormatOptions formatOptions)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = (nint)dest;
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref destIndex);
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &destLength;
		*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &value;
		*(FormatOptions**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &formatOptions;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ConvertFloatToString_Private_Static_Void_ptr_Byte_byref_Int32_Int32_Single_FormatOptions_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 959624, RefRangeEnd = 959625, XrefRangeStart = 959602, XrefRangeEnd = 959624, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ConvertDoubleToString(byte* dest, ref int destIndex, int destLength, double value, FormatOptions formatOptions)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = (nint)dest;
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref destIndex);
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &destLength;
		*(double**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &value;
		*(FormatOptions**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &formatOptions;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ConvertDoubleToString_Private_Static_Void_ptr_Byte_byref_Int32_Int32_Double_FormatOptions_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public BurstString(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
