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

namespace Il2CppZXing.OneD;

public sealed class Code128Reader : OneDReader
{
	private static readonly System.IntPtr NativeFieldInfoPtr_CODE_PATTERNS;

	private static readonly System.IntPtr NativeFieldInfoPtr_MAX_AVG_VARIANCE;

	private static readonly System.IntPtr NativeFieldInfoPtr_MAX_INDIVIDUAL_VARIANCE;

	private static readonly System.IntPtr NativeMethodInfoPtr_findStartPattern_Private_Static_Il2CppStructArray_1_Int32_BitArray_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_decodeCode_Private_Static_Boolean_BitArray_Il2CppStructArray_1_Int32_Int32_byref_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_decodeRow_Public_Virtual_Result_Int32_BitArray_IDictionary_2_DecodeHintType_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe static Il2CppReferenceArray<Il2CppStructArray<int>> CODE_PATTERNS
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_CODE_PATTERNS, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Il2CppStructArray<int>>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_CODE_PATTERNS, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

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

	static Code128Reader()
	{
		Il2CppClassPointerStore<Code128Reader>.NativeClassPtr = IL2CPP.GetIl2CppClass("zxing.unity.dll", "ZXing.OneD", "Code128Reader");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Code128Reader>.NativeClassPtr);
		NativeFieldInfoPtr_CODE_PATTERNS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Code128Reader>.NativeClassPtr, "CODE_PATTERNS");
		NativeFieldInfoPtr_MAX_AVG_VARIANCE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Code128Reader>.NativeClassPtr, "MAX_AVG_VARIANCE");
		NativeFieldInfoPtr_MAX_INDIVIDUAL_VARIANCE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Code128Reader>.NativeClassPtr, "MAX_INDIVIDUAL_VARIANCE");
		NativeMethodInfoPtr_findStartPattern_Private_Static_Il2CppStructArray_1_Int32_BitArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Code128Reader>.NativeClassPtr, 100664054);
		NativeMethodInfoPtr_decodeCode_Private_Static_Boolean_BitArray_Il2CppStructArray_1_Int32_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Code128Reader>.NativeClassPtr, 100664055);
		NativeMethodInfoPtr_decodeRow_Public_Virtual_Result_Int32_BitArray_IDictionary_2_DecodeHintType_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Code128Reader>.NativeClassPtr, 100664056);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Code128Reader>.NativeClassPtr, 100664057);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1420560, RefRangeEnd = 1420561, XrefRangeStart = 1420535, XrefRangeEnd = 1420560, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppStructArray<int> findStartPattern(BitArray row)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)row);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_findStartPattern_Private_Static_Il2CppStructArray_1_Int32_BitArray_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1420561, XrefRangeEnd = 1420578, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool decodeCode(BitArray row, Il2CppStructArray<int> counters, int rowOffset, out int code)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)row);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)counters);
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &rowOffset;
		*(void**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref code);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_decodeCode_Private_Static_Boolean_BitArray_Il2CppStructArray_1_Int32_Int32_byref_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1420578, XrefRangeEnd = 1420709, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1420713, RefRangeEnd = 1420715, XrefRangeStart = 1420709, XrefRangeEnd = 1420713, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Code128Reader()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Code128Reader>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public Code128Reader(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
