using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;
using UnityEngine.InputSystem.Utilities;

namespace UnityEngine.InputSystem.LowLevel;

[StructLayout(LayoutKind.Explicit)]
public struct InputStateBlock
{
	private static readonly System.IntPtr NativeFieldInfoPtr_InvalidOffset;

	private static readonly System.IntPtr NativeFieldInfoPtr_AutomaticOffset;

	private static readonly System.IntPtr NativeFieldInfoPtr_FormatInvalid;

	private static readonly System.IntPtr NativeFieldInfoPtr_kFormatInvalid;

	private static readonly System.IntPtr NativeFieldInfoPtr_FormatBit;

	private static readonly System.IntPtr NativeFieldInfoPtr_kFormatBit;

	private static readonly System.IntPtr NativeFieldInfoPtr_FormatSBit;

	private static readonly System.IntPtr NativeFieldInfoPtr_kFormatSBit;

	private static readonly System.IntPtr NativeFieldInfoPtr_FormatInt;

	private static readonly System.IntPtr NativeFieldInfoPtr_kFormatInt;

	private static readonly System.IntPtr NativeFieldInfoPtr_FormatUInt;

	private static readonly System.IntPtr NativeFieldInfoPtr_kFormatUInt;

	private static readonly System.IntPtr NativeFieldInfoPtr_FormatShort;

	private static readonly System.IntPtr NativeFieldInfoPtr_kFormatShort;

	private static readonly System.IntPtr NativeFieldInfoPtr_FormatUShort;

	private static readonly System.IntPtr NativeFieldInfoPtr_kFormatUShort;

	private static readonly System.IntPtr NativeFieldInfoPtr_FormatByte;

	private static readonly System.IntPtr NativeFieldInfoPtr_kFormatByte;

	private static readonly System.IntPtr NativeFieldInfoPtr_FormatSByte;

	private static readonly System.IntPtr NativeFieldInfoPtr_kFormatSByte;

	private static readonly System.IntPtr NativeFieldInfoPtr_FormatLong;

	private static readonly System.IntPtr NativeFieldInfoPtr_kFormatLong;

	private static readonly System.IntPtr NativeFieldInfoPtr_FormatULong;

	private static readonly System.IntPtr NativeFieldInfoPtr_kFormatULong;

	private static readonly System.IntPtr NativeFieldInfoPtr_FormatFloat;

	private static readonly System.IntPtr NativeFieldInfoPtr_kFormatFloat;

	private static readonly System.IntPtr NativeFieldInfoPtr_FormatDouble;

	private static readonly System.IntPtr NativeFieldInfoPtr_kFormatDouble;

	private static readonly System.IntPtr NativeFieldInfoPtr_FormatVector2;

	private static readonly System.IntPtr NativeFieldInfoPtr_kFormatVector2;

	private static readonly System.IntPtr NativeFieldInfoPtr_FormatVector3;

	private static readonly System.IntPtr NativeFieldInfoPtr_kFormatVector3;

	private static readonly System.IntPtr NativeFieldInfoPtr_FormatQuaternion;

	private static readonly System.IntPtr NativeFieldInfoPtr_kFormatQuaternion;

	private static readonly System.IntPtr NativeFieldInfoPtr_FormatVector2Short;

	private static readonly System.IntPtr NativeFieldInfoPtr_FormatVector3Short;

	private static readonly System.IntPtr NativeFieldInfoPtr_FormatVector2Byte;

	private static readonly System.IntPtr NativeFieldInfoPtr_FormatVector3Byte;

	private static readonly System.IntPtr NativeFieldInfoPtr_FormatPose;

	private static readonly System.IntPtr NativeFieldInfoPtr_kFormatPose;

	private static readonly System.IntPtr NativeFieldInfoPtr__format_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_ByteOffset;

	private static readonly System.IntPtr NativeFieldInfoPtr__bitOffset_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__sizeInBits_k__BackingField;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetSizeOfPrimitiveFormatInBits_Public_Static_Int32_FourCC_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetPrimitiveFormatFromType_Public_Static_FourCC_Type_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_format_Public_get_FourCC_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_format_Public_set_Void_FourCC_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_byteOffset_Public_get_UInt32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_byteOffset_Public_set_Void_UInt32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_bitOffset_Public_get_UInt32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_bitOffset_Public_set_Void_UInt32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_sizeInBits_Public_get_UInt32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_sizeInBits_Public_set_Void_UInt32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_alignedSizeInBytes_Internal_get_UInt32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_effectiveByteOffset_Internal_get_UInt32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_effectiveBitOffset_Internal_get_UInt32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ReadInt_Public_Int32_ptr_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_WriteInt_Public_Void_ptr_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ReadFloat_Public_Single_ptr_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_WriteFloat_Public_Void_ptr_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FloatToPrimitiveValue_Internal_PrimitiveValue_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ReadDouble_Public_Double_ptr_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_WriteDouble_Public_Void_ptr_Void_Double_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Write_Public_Void_ptr_Void_PrimitiveValue_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CopyToFrom_Public_Void_ptr_Void_ptr_Void_0;

	[FieldOffset(0)]
	public FourCC _format_k__BackingField;

	[FieldOffset(4)]
	public uint m_ByteOffset;

	[FieldOffset(8)]
	public uint _bitOffset_k__BackingField;

	[FieldOffset(12)]
	public uint _sizeInBits_k__BackingField;

	public unsafe static uint InvalidOffset
	{
		get
		{
			Unsafe.SkipInit(out uint result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_InvalidOffset, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_InvalidOffset, (void*)(&value));
		}
	}

	public unsafe static uint AutomaticOffset
	{
		get
		{
			Unsafe.SkipInit(out uint result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_AutomaticOffset, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_AutomaticOffset, (void*)(&value));
		}
	}

	public unsafe static FourCC FormatInvalid
	{
		get
		{
			Unsafe.SkipInit(out FourCC result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_FormatInvalid, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_FormatInvalid, (void*)(&value));
		}
	}

	public unsafe static int kFormatInvalid
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_kFormatInvalid, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_kFormatInvalid, (void*)(&value));
		}
	}

	public unsafe static FourCC FormatBit
	{
		get
		{
			Unsafe.SkipInit(out FourCC result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_FormatBit, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_FormatBit, (void*)(&value));
		}
	}

	public unsafe static int kFormatBit
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_kFormatBit, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_kFormatBit, (void*)(&value));
		}
	}

	public unsafe static FourCC FormatSBit
	{
		get
		{
			Unsafe.SkipInit(out FourCC result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_FormatSBit, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_FormatSBit, (void*)(&value));
		}
	}

	public unsafe static int kFormatSBit
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_kFormatSBit, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_kFormatSBit, (void*)(&value));
		}
	}

	public unsafe static FourCC FormatInt
	{
		get
		{
			Unsafe.SkipInit(out FourCC result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_FormatInt, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_FormatInt, (void*)(&value));
		}
	}

	public unsafe static int kFormatInt
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_kFormatInt, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_kFormatInt, (void*)(&value));
		}
	}

	public unsafe static FourCC FormatUInt
	{
		get
		{
			Unsafe.SkipInit(out FourCC result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_FormatUInt, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_FormatUInt, (void*)(&value));
		}
	}

	public unsafe static int kFormatUInt
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_kFormatUInt, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_kFormatUInt, (void*)(&value));
		}
	}

	public unsafe static FourCC FormatShort
	{
		get
		{
			Unsafe.SkipInit(out FourCC result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_FormatShort, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_FormatShort, (void*)(&value));
		}
	}

	public unsafe static int kFormatShort
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_kFormatShort, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_kFormatShort, (void*)(&value));
		}
	}

	public unsafe static FourCC FormatUShort
	{
		get
		{
			Unsafe.SkipInit(out FourCC result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_FormatUShort, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_FormatUShort, (void*)(&value));
		}
	}

	public unsafe static int kFormatUShort
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_kFormatUShort, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_kFormatUShort, (void*)(&value));
		}
	}

	public unsafe static FourCC FormatByte
	{
		get
		{
			Unsafe.SkipInit(out FourCC result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_FormatByte, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_FormatByte, (void*)(&value));
		}
	}

	public unsafe static int kFormatByte
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_kFormatByte, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_kFormatByte, (void*)(&value));
		}
	}

	public unsafe static FourCC FormatSByte
	{
		get
		{
			Unsafe.SkipInit(out FourCC result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_FormatSByte, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_FormatSByte, (void*)(&value));
		}
	}

	public unsafe static int kFormatSByte
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_kFormatSByte, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_kFormatSByte, (void*)(&value));
		}
	}

	public unsafe static FourCC FormatLong
	{
		get
		{
			Unsafe.SkipInit(out FourCC result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_FormatLong, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_FormatLong, (void*)(&value));
		}
	}

	public unsafe static int kFormatLong
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_kFormatLong, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_kFormatLong, (void*)(&value));
		}
	}

	public unsafe static FourCC FormatULong
	{
		get
		{
			Unsafe.SkipInit(out FourCC result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_FormatULong, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_FormatULong, (void*)(&value));
		}
	}

	public unsafe static int kFormatULong
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_kFormatULong, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_kFormatULong, (void*)(&value));
		}
	}

	public unsafe static FourCC FormatFloat
	{
		get
		{
			Unsafe.SkipInit(out FourCC result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_FormatFloat, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_FormatFloat, (void*)(&value));
		}
	}

	public unsafe static int kFormatFloat
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_kFormatFloat, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_kFormatFloat, (void*)(&value));
		}
	}

	public unsafe static FourCC FormatDouble
	{
		get
		{
			Unsafe.SkipInit(out FourCC result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_FormatDouble, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_FormatDouble, (void*)(&value));
		}
	}

	public unsafe static int kFormatDouble
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_kFormatDouble, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_kFormatDouble, (void*)(&value));
		}
	}

	public unsafe static FourCC FormatVector2
	{
		get
		{
			Unsafe.SkipInit(out FourCC result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_FormatVector2, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_FormatVector2, (void*)(&value));
		}
	}

	public unsafe static int kFormatVector2
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_kFormatVector2, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_kFormatVector2, (void*)(&value));
		}
	}

	public unsafe static FourCC FormatVector3
	{
		get
		{
			Unsafe.SkipInit(out FourCC result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_FormatVector3, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_FormatVector3, (void*)(&value));
		}
	}

	public unsafe static int kFormatVector3
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_kFormatVector3, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_kFormatVector3, (void*)(&value));
		}
	}

	public unsafe static FourCC FormatQuaternion
	{
		get
		{
			Unsafe.SkipInit(out FourCC result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_FormatQuaternion, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_FormatQuaternion, (void*)(&value));
		}
	}

	public unsafe static int kFormatQuaternion
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_kFormatQuaternion, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_kFormatQuaternion, (void*)(&value));
		}
	}

	public unsafe static FourCC FormatVector2Short
	{
		get
		{
			Unsafe.SkipInit(out FourCC result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_FormatVector2Short, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_FormatVector2Short, (void*)(&value));
		}
	}

	public unsafe static FourCC FormatVector3Short
	{
		get
		{
			Unsafe.SkipInit(out FourCC result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_FormatVector3Short, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_FormatVector3Short, (void*)(&value));
		}
	}

	public unsafe static FourCC FormatVector2Byte
	{
		get
		{
			Unsafe.SkipInit(out FourCC result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_FormatVector2Byte, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_FormatVector2Byte, (void*)(&value));
		}
	}

	public unsafe static FourCC FormatVector3Byte
	{
		get
		{
			Unsafe.SkipInit(out FourCC result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_FormatVector3Byte, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_FormatVector3Byte, (void*)(&value));
		}
	}

	public unsafe static FourCC FormatPose
	{
		get
		{
			Unsafe.SkipInit(out FourCC result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_FormatPose, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_FormatPose, (void*)(&value));
		}
	}

	public unsafe static int kFormatPose
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_kFormatPose, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_kFormatPose, (void*)(&value));
		}
	}

	public unsafe FourCC format
	{
		[CallerCount(175)]
		[CachedScanResults(RefRangeStart = 52464, RefRangeEnd = 52639, XrefRangeStart = 52464, XrefRangeEnd = 52639, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_format_Public_get_FourCC_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(FourCC*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 53703, RefRangeEnd = 53715, XrefRangeStart = 53703, XrefRangeEnd = 53715, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_format_Public_set_Void_FourCC_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe uint byteOffset
	{
		[CallerCount(0)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_byteOffset_Public_get_UInt32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(uint*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 376349, RefRangeEnd = 376359, XrefRangeStart = 376349, XrefRangeEnd = 376359, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_byteOffset_Public_set_Void_UInt32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe uint bitOffset
	{
		[CallerCount(24)]
		[CachedScanResults(RefRangeStart = 719678, RefRangeEnd = 719702, XrefRangeStart = 719678, XrefRangeEnd = 719702, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_bitOffset_Public_get_UInt32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(uint*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 765810, RefRangeEnd = 765814, XrefRangeStart = 765810, XrefRangeEnd = 765814, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_bitOffset_Public_set_Void_UInt32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe uint sizeInBits
	{
		[CallerCount(0)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_sizeInBits_Public_get_UInt32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(uint*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 376360, RefRangeEnd = 376363, XrefRangeStart = 376360, XrefRangeEnd = 376363, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_sizeInBits_Public_set_Void_UInt32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe uint alignedSizeInBytes
	{
		[CallerCount(16)]
		[CachedScanResults(RefRangeStart = 1009739, RefRangeEnd = 1009755, XrefRangeStart = 1009736, XrefRangeEnd = 1009739, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_alignedSizeInBytes_Internal_get_UInt32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(uint*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe uint effectiveByteOffset
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1009758, RefRangeEnd = 1009759, XrefRangeStart = 1009755, XrefRangeEnd = 1009758, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_effectiveByteOffset_Internal_get_UInt32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(uint*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe uint effectiveBitOffset
	{
		[CallerCount(25)]
		[CachedScanResults(RefRangeStart = 1009762, RefRangeEnd = 1009787, XrefRangeStart = 1009759, XrefRangeEnd = 1009762, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_effectiveBitOffset_Internal_get_UInt32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(uint*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	static InputStateBlock()
	{
		Il2CppClassPointerStore<InputStateBlock>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.InputSystem.dll", "UnityEngine.InputSystem.LowLevel", "InputStateBlock");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InputStateBlock>.NativeClassPtr);
		NativeFieldInfoPtr_InvalidOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputStateBlock>.NativeClassPtr, "InvalidOffset");
		NativeFieldInfoPtr_AutomaticOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputStateBlock>.NativeClassPtr, "AutomaticOffset");
		NativeFieldInfoPtr_FormatInvalid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputStateBlock>.NativeClassPtr, "FormatInvalid");
		NativeFieldInfoPtr_kFormatInvalid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputStateBlock>.NativeClassPtr, "kFormatInvalid");
		NativeFieldInfoPtr_FormatBit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputStateBlock>.NativeClassPtr, "FormatBit");
		NativeFieldInfoPtr_kFormatBit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputStateBlock>.NativeClassPtr, "kFormatBit");
		NativeFieldInfoPtr_FormatSBit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputStateBlock>.NativeClassPtr, "FormatSBit");
		NativeFieldInfoPtr_kFormatSBit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputStateBlock>.NativeClassPtr, "kFormatSBit");
		NativeFieldInfoPtr_FormatInt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputStateBlock>.NativeClassPtr, "FormatInt");
		NativeFieldInfoPtr_kFormatInt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputStateBlock>.NativeClassPtr, "kFormatInt");
		NativeFieldInfoPtr_FormatUInt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputStateBlock>.NativeClassPtr, "FormatUInt");
		NativeFieldInfoPtr_kFormatUInt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputStateBlock>.NativeClassPtr, "kFormatUInt");
		NativeFieldInfoPtr_FormatShort = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputStateBlock>.NativeClassPtr, "FormatShort");
		NativeFieldInfoPtr_kFormatShort = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputStateBlock>.NativeClassPtr, "kFormatShort");
		NativeFieldInfoPtr_FormatUShort = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputStateBlock>.NativeClassPtr, "FormatUShort");
		NativeFieldInfoPtr_kFormatUShort = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputStateBlock>.NativeClassPtr, "kFormatUShort");
		NativeFieldInfoPtr_FormatByte = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputStateBlock>.NativeClassPtr, "FormatByte");
		NativeFieldInfoPtr_kFormatByte = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputStateBlock>.NativeClassPtr, "kFormatByte");
		NativeFieldInfoPtr_FormatSByte = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputStateBlock>.NativeClassPtr, "FormatSByte");
		NativeFieldInfoPtr_kFormatSByte = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputStateBlock>.NativeClassPtr, "kFormatSByte");
		NativeFieldInfoPtr_FormatLong = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputStateBlock>.NativeClassPtr, "FormatLong");
		NativeFieldInfoPtr_kFormatLong = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputStateBlock>.NativeClassPtr, "kFormatLong");
		NativeFieldInfoPtr_FormatULong = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputStateBlock>.NativeClassPtr, "FormatULong");
		NativeFieldInfoPtr_kFormatULong = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputStateBlock>.NativeClassPtr, "kFormatULong");
		NativeFieldInfoPtr_FormatFloat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputStateBlock>.NativeClassPtr, "FormatFloat");
		NativeFieldInfoPtr_kFormatFloat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputStateBlock>.NativeClassPtr, "kFormatFloat");
		NativeFieldInfoPtr_FormatDouble = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputStateBlock>.NativeClassPtr, "FormatDouble");
		NativeFieldInfoPtr_kFormatDouble = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputStateBlock>.NativeClassPtr, "kFormatDouble");
		NativeFieldInfoPtr_FormatVector2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputStateBlock>.NativeClassPtr, "FormatVector2");
		NativeFieldInfoPtr_kFormatVector2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputStateBlock>.NativeClassPtr, "kFormatVector2");
		NativeFieldInfoPtr_FormatVector3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputStateBlock>.NativeClassPtr, "FormatVector3");
		NativeFieldInfoPtr_kFormatVector3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputStateBlock>.NativeClassPtr, "kFormatVector3");
		NativeFieldInfoPtr_FormatQuaternion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputStateBlock>.NativeClassPtr, "FormatQuaternion");
		NativeFieldInfoPtr_kFormatQuaternion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputStateBlock>.NativeClassPtr, "kFormatQuaternion");
		NativeFieldInfoPtr_FormatVector2Short = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputStateBlock>.NativeClassPtr, "FormatVector2Short");
		NativeFieldInfoPtr_FormatVector3Short = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputStateBlock>.NativeClassPtr, "FormatVector3Short");
		NativeFieldInfoPtr_FormatVector2Byte = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputStateBlock>.NativeClassPtr, "FormatVector2Byte");
		NativeFieldInfoPtr_FormatVector3Byte = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputStateBlock>.NativeClassPtr, "FormatVector3Byte");
		NativeFieldInfoPtr_FormatPose = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputStateBlock>.NativeClassPtr, "FormatPose");
		NativeFieldInfoPtr_kFormatPose = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputStateBlock>.NativeClassPtr, "kFormatPose");
		NativeFieldInfoPtr__format_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputStateBlock>.NativeClassPtr, "<format>k__BackingField");
		NativeFieldInfoPtr_m_ByteOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputStateBlock>.NativeClassPtr, "m_ByteOffset");
		NativeFieldInfoPtr__bitOffset_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputStateBlock>.NativeClassPtr, "<bitOffset>k__BackingField");
		NativeFieldInfoPtr__sizeInBits_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputStateBlock>.NativeClassPtr, "<sizeInBits>k__BackingField");
		NativeMethodInfoPtr_GetSizeOfPrimitiveFormatInBits_Public_Static_Int32_FourCC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputStateBlock>.NativeClassPtr, 100667819);
		NativeMethodInfoPtr_GetPrimitiveFormatFromType_Public_Static_FourCC_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputStateBlock>.NativeClassPtr, 100667820);
		NativeMethodInfoPtr_get_format_Public_get_FourCC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputStateBlock>.NativeClassPtr, 100667821);
		NativeMethodInfoPtr_set_format_Public_set_Void_FourCC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputStateBlock>.NativeClassPtr, 100667822);
		NativeMethodInfoPtr_get_byteOffset_Public_get_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputStateBlock>.NativeClassPtr, 100667823);
		NativeMethodInfoPtr_set_byteOffset_Public_set_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputStateBlock>.NativeClassPtr, 100667824);
		NativeMethodInfoPtr_get_bitOffset_Public_get_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputStateBlock>.NativeClassPtr, 100667825);
		NativeMethodInfoPtr_set_bitOffset_Public_set_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputStateBlock>.NativeClassPtr, 100667826);
		NativeMethodInfoPtr_get_sizeInBits_Public_get_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputStateBlock>.NativeClassPtr, 100667827);
		NativeMethodInfoPtr_set_sizeInBits_Public_set_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputStateBlock>.NativeClassPtr, 100667828);
		NativeMethodInfoPtr_get_alignedSizeInBytes_Internal_get_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputStateBlock>.NativeClassPtr, 100667829);
		NativeMethodInfoPtr_get_effectiveByteOffset_Internal_get_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputStateBlock>.NativeClassPtr, 100667830);
		NativeMethodInfoPtr_get_effectiveBitOffset_Internal_get_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputStateBlock>.NativeClassPtr, 100667831);
		NativeMethodInfoPtr_ReadInt_Public_Int32_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputStateBlock>.NativeClassPtr, 100667832);
		NativeMethodInfoPtr_WriteInt_Public_Void_ptr_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputStateBlock>.NativeClassPtr, 100667833);
		NativeMethodInfoPtr_ReadFloat_Public_Single_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputStateBlock>.NativeClassPtr, 100667834);
		NativeMethodInfoPtr_WriteFloat_Public_Void_ptr_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputStateBlock>.NativeClassPtr, 100667835);
		NativeMethodInfoPtr_FloatToPrimitiveValue_Internal_PrimitiveValue_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputStateBlock>.NativeClassPtr, 100667836);
		NativeMethodInfoPtr_ReadDouble_Public_Double_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputStateBlock>.NativeClassPtr, 100667837);
		NativeMethodInfoPtr_WriteDouble_Public_Void_ptr_Void_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputStateBlock>.NativeClassPtr, 100667838);
		NativeMethodInfoPtr_Write_Public_Void_ptr_Void_PrimitiveValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputStateBlock>.NativeClassPtr, 100667839);
		NativeMethodInfoPtr_CopyToFrom_Public_Void_ptr_Void_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputStateBlock>.NativeClassPtr, 100667840);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1009676, RefRangeEnd = 1009679, XrefRangeStart = 1009636, XrefRangeEnd = 1009676, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int GetSizeOfPrimitiveFormatInBits(FourCC type)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&type);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetSizeOfPrimitiveFormatInBits_Public_Static_Int32_FourCC_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1009735, RefRangeEnd = 1009736, XrefRangeStart = 1009679, XrefRangeEnd = 1009735, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static FourCC GetPrimitiveFormatFromType(Il2CppSystem.Type type)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)type);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetPrimitiveFormatFromType_Public_Static_FourCC_Type_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(FourCC*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1009791, RefRangeEnd = 1009793, XrefRangeStart = 1009787, XrefRangeEnd = 1009791, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int ReadInt(void* statePtr)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)statePtr;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ReadInt_Public_Int32_ptr_Void_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1009807, RefRangeEnd = 1009808, XrefRangeStart = 1009793, XrefRangeEnd = 1009807, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void WriteInt(void* statePtr, int value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)statePtr;
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &value;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_WriteInt_Public_Void_ptr_Void_Int32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1009808, XrefRangeEnd = 1009812, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float ReadFloat(void* statePtr)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)statePtr;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ReadFloat_Public_Single_ptr_Void_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1009812, XrefRangeEnd = 1009820, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void WriteFloat(void* statePtr, float value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)statePtr;
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &value;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_WriteFloat_Public_Void_ptr_Void_Single_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1009841, RefRangeEnd = 1009842, XrefRangeStart = 1009820, XrefRangeEnd = 1009841, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe PrimitiveValue FloatToPrimitiveValue(float value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FloatToPrimitiveValue_Internal_PrimitiveValue_Single_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(PrimitiveValue*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1009846, RefRangeEnd = 1009847, XrefRangeStart = 1009842, XrefRangeEnd = 1009846, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe double ReadDouble(void* statePtr)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)statePtr;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ReadDouble_Public_Double_ptr_Void_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(double*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1009855, RefRangeEnd = 1009856, XrefRangeStart = 1009847, XrefRangeEnd = 1009855, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void WriteDouble(void* statePtr, double value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)statePtr;
		*(double**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &value;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_WriteDouble_Public_Void_ptr_Void_Double_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1009861, RefRangeEnd = 1009863, XrefRangeStart = 1009856, XrefRangeEnd = 1009861, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Write(void* statePtr, PrimitiveValue value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)statePtr;
		*(PrimitiveValue**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &value;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Write_Public_Void_ptr_Void_PrimitiveValue_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 1009880, RefRangeEnd = 1009884, XrefRangeStart = 1009863, XrefRangeEnd = 1009880, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CopyToFrom(void* toStatePtr, void* fromStatePtr)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)toStatePtr;
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = fromStatePtr;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CopyToFrom_Public_Void_ptr_Void_ptr_Void_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<InputStateBlock>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}
}
