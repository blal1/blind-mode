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

public sealed class ITFReader : OneDReader
{
	private static readonly System.IntPtr NativeFieldInfoPtr_MAX_AVG_VARIANCE;

	private static readonly System.IntPtr NativeFieldInfoPtr_MAX_INDIVIDUAL_VARIANCE;

	private static readonly System.IntPtr NativeFieldInfoPtr_DEFAULT_ALLOWED_LENGTHS;

	private static readonly System.IntPtr NativeFieldInfoPtr_narrowLineWidth;

	private static readonly System.IntPtr NativeFieldInfoPtr_START_PATTERN;

	private static readonly System.IntPtr NativeFieldInfoPtr_END_PATTERN_REVERSED;

	private static readonly System.IntPtr NativeFieldInfoPtr_PATTERNS;

	private static readonly System.IntPtr NativeMethodInfoPtr_decodeRow_Public_Virtual_Result_Int32_BitArray_IDictionary_2_DecodeHintType_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_decodeMiddle_Private_Static_Boolean_BitArray_Int32_Int32_StringBuilder_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_decodeStart_Private_Il2CppStructArray_1_Int32_BitArray_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_validateQuietZone_Private_Boolean_BitArray_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_skipWhiteSpace_Private_Static_Int32_BitArray_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_decodeEnd_Private_Il2CppStructArray_1_Int32_BitArray_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_findGuardPattern_Private_Static_Il2CppStructArray_1_Int32_BitArray_Int32_Il2CppStructArray_1_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_decodeDigit_Private_Static_Boolean_Il2CppStructArray_1_Int32_byref_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe static int MAX_AVG_VARIANCE
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_MAX_AVG_VARIANCE, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_MAX_AVG_VARIANCE, (void*)(&value));
		}
	}

	public unsafe static int MAX_INDIVIDUAL_VARIANCE
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_MAX_INDIVIDUAL_VARIANCE, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_MAX_INDIVIDUAL_VARIANCE, (void*)(&value));
		}
	}

	public unsafe static Il2CppStructArray<int> DEFAULT_ALLOWED_LENGTHS
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_DEFAULT_ALLOWED_LENGTHS, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_DEFAULT_ALLOWED_LENGTHS, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe int narrowLineWidth
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_narrowLineWidth);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_narrowLineWidth)) = value;
		}
	}

	public unsafe static Il2CppStructArray<int> START_PATTERN
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_START_PATTERN, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_START_PATTERN, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Il2CppReferenceArray<Il2CppStructArray<int>> END_PATTERN_REVERSED
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_END_PATTERN_REVERSED, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Il2CppStructArray<int>>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_END_PATTERN_REVERSED, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Il2CppReferenceArray<Il2CppStructArray<int>> PATTERNS
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_PATTERNS, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Il2CppStructArray<int>>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_PATTERNS, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	static ITFReader()
	{
		Il2CppClassPointerStore<ITFReader>.NativeClassPtr = IL2CPP.GetIl2CppClass("zxing.unity.dll", "ZXing.OneD", "ITFReader");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ITFReader>.NativeClassPtr);
		NativeFieldInfoPtr_MAX_AVG_VARIANCE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ITFReader>.NativeClassPtr, "MAX_AVG_VARIANCE");
		NativeFieldInfoPtr_MAX_INDIVIDUAL_VARIANCE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ITFReader>.NativeClassPtr, "MAX_INDIVIDUAL_VARIANCE");
		NativeFieldInfoPtr_DEFAULT_ALLOWED_LENGTHS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ITFReader>.NativeClassPtr, "DEFAULT_ALLOWED_LENGTHS");
		NativeFieldInfoPtr_narrowLineWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ITFReader>.NativeClassPtr, "narrowLineWidth");
		NativeFieldInfoPtr_START_PATTERN = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ITFReader>.NativeClassPtr, "START_PATTERN");
		NativeFieldInfoPtr_END_PATTERN_REVERSED = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ITFReader>.NativeClassPtr, "END_PATTERN_REVERSED");
		NativeFieldInfoPtr_PATTERNS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ITFReader>.NativeClassPtr, "PATTERNS");
		NativeMethodInfoPtr_decodeRow_Public_Virtual_Result_Int32_BitArray_IDictionary_2_DecodeHintType_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ITFReader>.NativeClassPtr, 100664115);
		NativeMethodInfoPtr_decodeMiddle_Private_Static_Boolean_BitArray_Int32_Int32_StringBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ITFReader>.NativeClassPtr, 100664116);
		NativeMethodInfoPtr_decodeStart_Private_Il2CppStructArray_1_Int32_BitArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ITFReader>.NativeClassPtr, 100664117);
		NativeMethodInfoPtr_validateQuietZone_Private_Boolean_BitArray_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ITFReader>.NativeClassPtr, 100664118);
		NativeMethodInfoPtr_skipWhiteSpace_Private_Static_Int32_BitArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ITFReader>.NativeClassPtr, 100664119);
		NativeMethodInfoPtr_decodeEnd_Private_Il2CppStructArray_1_Int32_BitArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ITFReader>.NativeClassPtr, 100664120);
		NativeMethodInfoPtr_findGuardPattern_Private_Static_Il2CppStructArray_1_Int32_BitArray_Int32_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ITFReader>.NativeClassPtr, 100664121);
		NativeMethodInfoPtr_decodeDigit_Private_Static_Boolean_Il2CppStructArray_1_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ITFReader>.NativeClassPtr, 100664122);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ITFReader>.NativeClassPtr, 100664123);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1422258, XrefRangeEnd = 1422319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	[CachedScanResults(RefRangeStart = 1422340, RefRangeEnd = 1422341, XrefRangeStart = 1422319, XrefRangeEnd = 1422340, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool decodeMiddle(BitArray row, int payloadStart, int payloadEnd, StringBuilder resultString)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)row);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &payloadStart;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &payloadEnd;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)resultString);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_decodeMiddle_Private_Static_Boolean_BitArray_Int32_Int32_StringBuilder_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1422341, XrefRangeEnd = 1422350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Il2CppStructArray<int> decodeStart(BitArray row)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)row);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_decodeStart_Private_Il2CppStructArray_1_Int32_BitArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1422350, XrefRangeEnd = 1422351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool validateQuietZone(BitArray row, int startPattern)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)row);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &startPattern;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_validateQuietZone_Private_Boolean_BitArray_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1422351, XrefRangeEnd = 1422352, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int skipWhiteSpace(BitArray row)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)row);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_skipWhiteSpace_Private_Static_Int32_BitArray_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1422367, RefRangeEnd = 1422368, XrefRangeStart = 1422352, XrefRangeEnd = 1422367, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Il2CppStructArray<int> decodeEnd(BitArray row)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)row);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_decodeEnd_Private_Il2CppStructArray_1_Int32_BitArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 1422387, RefRangeEnd = 1422391, XrefRangeStart = 1422368, XrefRangeEnd = 1422387, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppStructArray<int> findGuardPattern(BitArray row, int rowOffset, Il2CppStructArray<int> pattern)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)row);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &rowOffset;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)pattern);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_findGuardPattern_Private_Static_Il2CppStructArray_1_Int32_BitArray_Int32_Il2CppStructArray_1_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1422405, RefRangeEnd = 1422407, XrefRangeStart = 1422391, XrefRangeEnd = 1422405, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool decodeDigit(Il2CppStructArray<int> counters, out int bestMatch)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)counters);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref bestMatch);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_decodeDigit_Private_Static_Boolean_Il2CppStructArray_1_Int32_byref_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1422411, RefRangeEnd = 1422413, XrefRangeStart = 1422407, XrefRangeEnd = 1422411, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ITFReader()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ITFReader>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public ITFReader(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
