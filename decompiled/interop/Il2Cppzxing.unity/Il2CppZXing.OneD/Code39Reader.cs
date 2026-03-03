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

public sealed class Code39Reader : OneDReader
{
	private static readonly System.IntPtr NativeFieldInfoPtr_ALPHABET_STRING;

	private static readonly System.IntPtr NativeFieldInfoPtr_CHARACTER_ENCODINGS;

	private static readonly System.IntPtr NativeFieldInfoPtr_ASTERISK_ENCODING;

	private static readonly System.IntPtr NativeFieldInfoPtr_usingCheckDigit;

	private static readonly System.IntPtr NativeFieldInfoPtr_extendedMode;

	private static readonly System.IntPtr NativeFieldInfoPtr_decodeRowResult;

	private static readonly System.IntPtr NativeFieldInfoPtr_counters;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Boolean_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_decodeRow_Public_Virtual_Result_Int32_BitArray_IDictionary_2_DecodeHintType_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_findAsteriskPattern_Private_Static_Il2CppStructArray_1_Int32_BitArray_Il2CppStructArray_1_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_toNarrowWidePattern_Private_Static_Int32_Il2CppStructArray_1_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_patternToChar_Private_Static_Boolean_Int32_byref_Char_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_decodeExtended_Private_Static_String_String_0;

	public unsafe static string ALPHABET_STRING
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ALPHABET_STRING, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ALPHABET_STRING, (void*)IL2CPP.ManagedStringToIl2Cpp(value));
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

	public unsafe static int ASTERISK_ENCODING
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ASTERISK_ENCODING, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ASTERISK_ENCODING, (void*)(&value));
		}
	}

	public unsafe bool usingCheckDigit
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_usingCheckDigit);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_usingCheckDigit)) = value;
		}
	}

	public unsafe bool extendedMode
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_extendedMode);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_extendedMode)) = value;
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

	static Code39Reader()
	{
		Il2CppClassPointerStore<Code39Reader>.NativeClassPtr = IL2CPP.GetIl2CppClass("zxing.unity.dll", "ZXing.OneD", "Code39Reader");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Code39Reader>.NativeClassPtr);
		NativeFieldInfoPtr_ALPHABET_STRING = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Code39Reader>.NativeClassPtr, "ALPHABET_STRING");
		NativeFieldInfoPtr_CHARACTER_ENCODINGS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Code39Reader>.NativeClassPtr, "CHARACTER_ENCODINGS");
		NativeFieldInfoPtr_ASTERISK_ENCODING = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Code39Reader>.NativeClassPtr, "ASTERISK_ENCODING");
		NativeFieldInfoPtr_usingCheckDigit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Code39Reader>.NativeClassPtr, "usingCheckDigit");
		NativeFieldInfoPtr_extendedMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Code39Reader>.NativeClassPtr, "extendedMode");
		NativeFieldInfoPtr_decodeRowResult = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Code39Reader>.NativeClassPtr, "decodeRowResult");
		NativeFieldInfoPtr_counters = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Code39Reader>.NativeClassPtr, "counters");
		NativeMethodInfoPtr__ctor_Public_Void_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Code39Reader>.NativeClassPtr, 100664066);
		NativeMethodInfoPtr_decodeRow_Public_Virtual_Result_Int32_BitArray_IDictionary_2_DecodeHintType_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Code39Reader>.NativeClassPtr, 100664067);
		NativeMethodInfoPtr_findAsteriskPattern_Private_Static_Il2CppStructArray_1_Int32_BitArray_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Code39Reader>.NativeClassPtr, 100664068);
		NativeMethodInfoPtr_toNarrowWidePattern_Private_Static_Int32_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Code39Reader>.NativeClassPtr, 100664069);
		NativeMethodInfoPtr_patternToChar_Private_Static_Boolean_Int32_byref_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Code39Reader>.NativeClassPtr, 100664070);
		NativeMethodInfoPtr_decodeExtended_Private_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Code39Reader>.NativeClassPtr, 100664071);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1420875, RefRangeEnd = 1420877, XrefRangeStart = 1420862, XrefRangeEnd = 1420875, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Code39Reader(bool usingCheckDigit, bool extendedMode)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Code39Reader>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&usingCheckDigit);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &extendedMode;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1420877, XrefRangeEnd = 1420981, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	[CachedScanResults(RefRangeStart = 1420997, RefRangeEnd = 1420998, XrefRangeStart = 1420981, XrefRangeEnd = 1420997, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppStructArray<int> findAsteriskPattern(BitArray row, Il2CppStructArray<int> counters)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)row);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)counters);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_findAsteriskPattern_Private_Static_Il2CppStructArray_1_Int32_BitArray_Il2CppStructArray_1_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1421000, RefRangeEnd = 1421002, XrefRangeStart = 1420998, XrefRangeEnd = 1421000, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int toNarrowWidePattern(Il2CppStructArray<int> counters)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)counters);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_toNarrowWidePattern_Private_Static_Int32_Il2CppStructArray_1_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1421002, XrefRangeEnd = 1421012, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool patternToChar(int pattern, out char c)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&pattern);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref c);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_patternToChar_Private_Static_Boolean_Int32_byref_Char_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1421030, RefRangeEnd = 1421031, XrefRangeStart = 1421012, XrefRangeEnd = 1421030, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string decodeExtended(string encoded)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(encoded);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_decodeExtended_Private_Static_String_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	public Code39Reader(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
