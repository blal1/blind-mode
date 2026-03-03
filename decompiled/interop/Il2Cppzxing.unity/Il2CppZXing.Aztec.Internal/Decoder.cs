using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppZXing.Common;

namespace Il2CppZXing.Aztec.Internal;

public sealed class Decoder : Il2CppSystem.Object
{
	[OriginalName("zxing.unity.dll", "", "Table")]
	public enum Table
	{
		UPPER,
		LOWER,
		MIXED,
		DIGIT,
		PUNCT,
		BINARY
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_UPPER_TABLE;

	private static readonly System.IntPtr NativeFieldInfoPtr_LOWER_TABLE;

	private static readonly System.IntPtr NativeFieldInfoPtr_MIXED_TABLE;

	private static readonly System.IntPtr NativeFieldInfoPtr_PUNCT_TABLE;

	private static readonly System.IntPtr NativeFieldInfoPtr_DIGIT_TABLE;

	private static readonly System.IntPtr NativeFieldInfoPtr_codeTables;

	private static readonly System.IntPtr NativeFieldInfoPtr_codeTableMap;

	private static readonly System.IntPtr NativeFieldInfoPtr_ddata;

	private static readonly System.IntPtr NativeMethodInfoPtr_decode_Public_DecoderResult_AztecDetectorResult_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_getEncodedData_Private_Static_String_Il2CppStructArray_1_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_getTable_Private_Static_Table_Char_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_getCharacter_Private_Static_String_Il2CppStringArray_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_correctBits_Private_Il2CppStructArray_1_Boolean_Il2CppStructArray_1_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_extractBits_Private_Il2CppStructArray_1_Boolean_BitMatrix_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_readCode_Private_Static_Int32_Il2CppStructArray_1_Boolean_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_readByte_Private_Static_Byte_Il2CppStructArray_1_Boolean_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_convertBoolArrayToByteArray_Internal_Static_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_totalBitsInLayer_Private_Static_Int32_Int32_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe static Il2CppStringArray UPPER_TABLE
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_UPPER_TABLE, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_UPPER_TABLE, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Il2CppStringArray LOWER_TABLE
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_LOWER_TABLE, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_LOWER_TABLE, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Il2CppStringArray MIXED_TABLE
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_MIXED_TABLE, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_MIXED_TABLE, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Il2CppStringArray PUNCT_TABLE
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_PUNCT_TABLE, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_PUNCT_TABLE, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Il2CppStringArray DIGIT_TABLE
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_DIGIT_TABLE, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_DIGIT_TABLE, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static IDictionary<Table, Il2CppStringArray> codeTables
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_codeTables, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<IDictionary<Table, Il2CppStringArray>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_codeTables, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static IDictionary<char, Table> codeTableMap
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_codeTableMap, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<IDictionary<char, Table>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_codeTableMap, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe AztecDetectorResult ddata
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ddata);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<AztecDetectorResult>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ddata)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	static Decoder()
	{
		Il2CppClassPointerStore<Decoder>.NativeClassPtr = IL2CPP.GetIl2CppClass("zxing.unity.dll", "ZXing.Aztec.Internal", "Decoder");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Decoder>.NativeClassPtr);
		NativeFieldInfoPtr_UPPER_TABLE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Decoder>.NativeClassPtr, "UPPER_TABLE");
		NativeFieldInfoPtr_LOWER_TABLE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Decoder>.NativeClassPtr, "LOWER_TABLE");
		NativeFieldInfoPtr_MIXED_TABLE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Decoder>.NativeClassPtr, "MIXED_TABLE");
		NativeFieldInfoPtr_PUNCT_TABLE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Decoder>.NativeClassPtr, "PUNCT_TABLE");
		NativeFieldInfoPtr_DIGIT_TABLE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Decoder>.NativeClassPtr, "DIGIT_TABLE");
		NativeFieldInfoPtr_codeTables = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Decoder>.NativeClassPtr, "codeTables");
		NativeFieldInfoPtr_codeTableMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Decoder>.NativeClassPtr, "codeTableMap");
		NativeFieldInfoPtr_ddata = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Decoder>.NativeClassPtr, "ddata");
		NativeMethodInfoPtr_decode_Public_DecoderResult_AztecDetectorResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decoder>.NativeClassPtr, 100664856);
		NativeMethodInfoPtr_getEncodedData_Private_Static_String_Il2CppStructArray_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decoder>.NativeClassPtr, 100664857);
		NativeMethodInfoPtr_getTable_Private_Static_Table_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decoder>.NativeClassPtr, 100664858);
		NativeMethodInfoPtr_getCharacter_Private_Static_String_Il2CppStringArray_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decoder>.NativeClassPtr, 100664859);
		NativeMethodInfoPtr_correctBits_Private_Il2CppStructArray_1_Boolean_Il2CppStructArray_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decoder>.NativeClassPtr, 100664860);
		NativeMethodInfoPtr_extractBits_Private_Il2CppStructArray_1_Boolean_BitMatrix_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decoder>.NativeClassPtr, 100664861);
		NativeMethodInfoPtr_readCode_Private_Static_Int32_Il2CppStructArray_1_Boolean_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decoder>.NativeClassPtr, 100664862);
		NativeMethodInfoPtr_readByte_Private_Static_Byte_Il2CppStructArray_1_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decoder>.NativeClassPtr, 100664863);
		NativeMethodInfoPtr_convertBoolArrayToByteArray_Internal_Static_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decoder>.NativeClassPtr, 100664864);
		NativeMethodInfoPtr_totalBitsInLayer_Private_Static_Int32_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decoder>.NativeClassPtr, 100664865);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decoder>.NativeClassPtr, 100664866);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1430087, RefRangeEnd = 1430089, XrefRangeStart = 1430069, XrefRangeEnd = 1430087, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe DecoderResult decode(AztecDetectorResult detectorResult)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)detectorResult);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_decode_Public_DecoderResult_AztecDetectorResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<DecoderResult>(intPtr2) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1430132, RefRangeEnd = 1430133, XrefRangeStart = 1430089, XrefRangeEnd = 1430132, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string getEncodedData(Il2CppStructArray<bool> correctedBits)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)correctedBits);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_getEncodedData_Private_Static_String_Il2CppStructArray_1_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1430150, RefRangeEnd = 1430151, XrefRangeStart = 1430133, XrefRangeEnd = 1430150, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Table getTable(char t)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&t);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_getTable_Private_Static_Table_Char_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(Table*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe static string getCharacter(Il2CppStringArray table, int code)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)table);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &code;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_getCharacter_Private_Static_String_Il2CppStringArray_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1430188, RefRangeEnd = 1430189, XrefRangeStart = 1430151, XrefRangeEnd = 1430188, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Il2CppStructArray<bool> correctBits(Il2CppStructArray<bool> rawbits)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)rawbits);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_correctBits_Private_Il2CppStructArray_1_Boolean_Il2CppStructArray_1_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<bool>>(intPtr2) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1430202, RefRangeEnd = 1430203, XrefRangeStart = 1430189, XrefRangeEnd = 1430202, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Il2CppStructArray<bool> extractBits(BitMatrix matrix)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)matrix);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_extractBits_Private_Il2CppStructArray_1_Boolean_BitMatrix_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<bool>>(intPtr2) : null;
	}

	[CallerCount(0)]
	public unsafe static int readCode(Il2CppStructArray<bool> rawbits, int startIndex, int length)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)rawbits);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &startIndex;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &length;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_readCode_Private_Static_Int32_Il2CppStructArray_1_Boolean_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1430203, XrefRangeEnd = 1430206, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static byte readByte(Il2CppStructArray<bool> rawbits, int startIndex)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)rawbits);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &startIndex;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_readByte_Private_Static_Byte_Il2CppStructArray_1_Boolean_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(byte*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1430219, RefRangeEnd = 1430220, XrefRangeStart = 1430206, XrefRangeEnd = 1430219, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppStructArray<byte> convertBoolArrayToByteArray(Il2CppStructArray<bool> boolArr)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)boolArr);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_convertBoolArrayToByteArray_Internal_Static_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
	}

	[CallerCount(0)]
	public unsafe static int totalBitsInLayer(int layers, bool compact)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&layers);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &compact;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_totalBitsInLayer_Private_Static_Int32_Int32_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1950)]
	[CachedScanResults(RefRangeStart = 20036, RefRangeEnd = 21986, XrefRangeStart = 20036, XrefRangeEnd = 21986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Decoder()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Decoder>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public Decoder(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
