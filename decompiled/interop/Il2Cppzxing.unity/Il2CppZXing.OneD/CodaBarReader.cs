using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Text;
using Il2CppZXing.Common;

namespace Il2CppZXing.OneD;

public sealed class CodaBarReader : OneDReader
{
	private static readonly System.IntPtr NativeFieldInfoPtr_MAX_ACCEPTABLE;

	private static readonly System.IntPtr NativeFieldInfoPtr_PADDING;

	private static readonly System.IntPtr NativeFieldInfoPtr_ALPHABET;

	private static readonly System.IntPtr NativeFieldInfoPtr_CHARACTER_ENCODINGS;

	private static readonly System.IntPtr NativeFieldInfoPtr_STARTEND_ENCODING;

	private static readonly System.IntPtr NativeFieldInfoPtr_decodeRowResult;

	private static readonly System.IntPtr NativeFieldInfoPtr_counters;

	private static readonly System.IntPtr NativeFieldInfoPtr_counterLength;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_decodeRow_Public_Virtual_Result_Int32_BitArray_IDictionary_2_DecodeHintType_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_validatePattern_Private_Boolean_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_setCounters_Private_Boolean_BitArray_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_counterAppend_Private_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_findStartPattern_Private_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_arrayContains_Internal_Static_Boolean_Il2CppStructArray_1_Char_Char_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_toNarrowWidePattern_Private_Int32_Int32_0;

	public unsafe static int MAX_ACCEPTABLE
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_MAX_ACCEPTABLE, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_MAX_ACCEPTABLE, (void*)(&value));
		}
	}

	public unsafe static int PADDING
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_PADDING, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_PADDING, (void*)(&value));
		}
	}

	public unsafe static Il2CppStructArray<char> ALPHABET
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ALPHABET, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<char>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ALPHABET, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Il2CppStructArray<int> CHARACTER_ENCODINGS
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_CHARACTER_ENCODINGS, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_CHARACTER_ENCODINGS, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Il2CppStructArray<char> STARTEND_ENCODING
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_STARTEND_ENCODING, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<char>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_STARTEND_ENCODING, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe StringBuilder decodeRowResult
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_decodeRowResult);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<StringBuilder>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_decodeRowResult)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe Il2CppStructArray<int> counters
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_counters);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_counters)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe int counterLength
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_counterLength);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_counterLength)) = value;
		}
	}

	static CodaBarReader()
	{
		Il2CppClassPointerStore<CodaBarReader>.NativeClassPtr = IL2CPP.GetIl2CppClass("zxing.unity.dll", "ZXing.OneD", "CodaBarReader");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CodaBarReader>.NativeClassPtr);
		NativeFieldInfoPtr_MAX_ACCEPTABLE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CodaBarReader>.NativeClassPtr, "MAX_ACCEPTABLE");
		NativeFieldInfoPtr_PADDING = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CodaBarReader>.NativeClassPtr, "PADDING");
		NativeFieldInfoPtr_ALPHABET = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CodaBarReader>.NativeClassPtr, "ALPHABET");
		NativeFieldInfoPtr_CHARACTER_ENCODINGS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CodaBarReader>.NativeClassPtr, "CHARACTER_ENCODINGS");
		NativeFieldInfoPtr_STARTEND_ENCODING = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CodaBarReader>.NativeClassPtr, "STARTEND_ENCODING");
		NativeFieldInfoPtr_decodeRowResult = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CodaBarReader>.NativeClassPtr, "decodeRowResult");
		NativeFieldInfoPtr_counters = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CodaBarReader>.NativeClassPtr, "counters");
		NativeFieldInfoPtr_counterLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CodaBarReader>.NativeClassPtr, "counterLength");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CodaBarReader>.NativeClassPtr, 100664041);
		NativeMethodInfoPtr_decodeRow_Public_Virtual_Result_Int32_BitArray_IDictionary_2_DecodeHintType_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CodaBarReader>.NativeClassPtr, 100664042);
		NativeMethodInfoPtr_validatePattern_Private_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CodaBarReader>.NativeClassPtr, 100664043);
		NativeMethodInfoPtr_setCounters_Private_Boolean_BitArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CodaBarReader>.NativeClassPtr, 100664044);
		NativeMethodInfoPtr_counterAppend_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CodaBarReader>.NativeClassPtr, 100664045);
		NativeMethodInfoPtr_findStartPattern_Private_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CodaBarReader>.NativeClassPtr, 100664046);
		NativeMethodInfoPtr_arrayContains_Internal_Static_Boolean_Il2CppStructArray_1_Char_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CodaBarReader>.NativeClassPtr, 100664047);
		NativeMethodInfoPtr_toNarrowWidePattern_Private_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CodaBarReader>.NativeClassPtr, 100664048);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1420309, RefRangeEnd = 1420311, XrefRangeStart = 1420296, XrefRangeEnd = 1420309, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe CodaBarReader()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CodaBarReader>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1420311, XrefRangeEnd = 1420384, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override Result decodeRow(int rowNumber, BitArray row, IDictionary<DecodeHintType, Il2CppSystem.Object> hints)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&rowNumber);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)row);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)hints);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_decodeRow_Public_Virtual_Result_Int32_BitArray_IDictionary_2_DecodeHintType_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Result>(intPtr2) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1420415, RefRangeEnd = 1420416, XrefRangeStart = 1420384, XrefRangeEnd = 1420415, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool validatePattern(int start)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&start);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_validatePattern_Private_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1420416, XrefRangeEnd = 1420425, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool setCounters(BitArray row)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)row);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_setCounters_Private_Boolean_BitArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1420430, RefRangeEnd = 1420432, XrefRangeStart = 1420425, XrefRangeEnd = 1420430, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void counterAppend(int e)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&e);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_counterAppend_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1420438, RefRangeEnd = 1420439, XrefRangeStart = 1420432, XrefRangeEnd = 1420438, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int findStartPattern()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_findStartPattern_Private_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1420439, XrefRangeEnd = 1420440, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool arrayContains(Il2CppStructArray<char> array, char key)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)array);
		*(char**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &key;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_arrayContains_Internal_Static_Boolean_Il2CppStructArray_1_Char_Char_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1420448, RefRangeEnd = 1420450, XrefRangeStart = 1420440, XrefRangeEnd = 1420448, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int toNarrowWidePattern(int position)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&position);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_toNarrowWidePattern_Private_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	public CodaBarReader(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
