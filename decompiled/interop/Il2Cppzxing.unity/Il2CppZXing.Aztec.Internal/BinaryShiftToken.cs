using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppZXing.Common;

namespace Il2CppZXing.Aztec.Internal;

public sealed class BinaryShiftToken : Token
{
	private static readonly IntPtr NativeFieldInfoPtr_binaryShiftStart;

	private static readonly IntPtr NativeFieldInfoPtr_binaryShiftByteCount;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Token_Int32_Int32_0;

	private static readonly IntPtr NativeMethodInfoPtr_appendTo_Public_Virtual_Void_BitArray_Il2CppStructArray_1_Byte_0;

	private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

	public unsafe short binaryShiftStart
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_binaryShiftStart);
			return *(short*)num;
		}
		set
		{
			*(short*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_binaryShiftStart)) = value;
		}
	}

	public unsafe short binaryShiftByteCount
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_binaryShiftByteCount);
			return *(short*)num;
		}
		set
		{
			*(short*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_binaryShiftByteCount)) = value;
		}
	}

	static BinaryShiftToken()
	{
		Il2CppClassPointerStore<BinaryShiftToken>.NativeClassPtr = IL2CPP.GetIl2CppClass("zxing.unity.dll", "ZXing.Aztec.Internal", "BinaryShiftToken");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BinaryShiftToken>.NativeClassPtr);
		NativeFieldInfoPtr_binaryShiftStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BinaryShiftToken>.NativeClassPtr, "binaryShiftStart");
		NativeFieldInfoPtr_binaryShiftByteCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BinaryShiftToken>.NativeClassPtr, "binaryShiftByteCount");
		NativeMethodInfoPtr__ctor_Public_Void_Token_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryShiftToken>.NativeClassPtr, 100664902);
		NativeMethodInfoPtr_appendTo_Public_Virtual_Void_BitArray_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryShiftToken>.NativeClassPtr, 100664903);
		NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryShiftToken>.NativeClassPtr, 100664904);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1430531, XrefRangeEnd = 1430536, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe BinaryShiftToken(Token previous, int binaryShiftStart, int binaryShiftByteCount)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BinaryShiftToken>.NativeClassPtr))
	{
		IntPtr* ptr = stackalloc IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)previous);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &binaryShiftStart;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(IntPtr)))) = &binaryShiftByteCount;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Token_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1430536, XrefRangeEnd = 1430545, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void appendTo(BitArray bitArray, Il2CppStructArray<byte> text)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)bitArray);
		*(IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)text);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_appendTo_Public_Virtual_Void_BitArray_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1430545, XrefRangeEnd = 1430562, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override string ToString()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToString_Public_Virtual_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	public BinaryShiftToken(IntPtr pointer)
		: base(pointer)
	{
	}
}
