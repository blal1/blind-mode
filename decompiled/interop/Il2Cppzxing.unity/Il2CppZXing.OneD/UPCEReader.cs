using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Text;
using Il2CppZXing.Common;

namespace Il2CppZXing.OneD;

public sealed class UPCEReader : UPCEANReader
{
	private static readonly IntPtr NativeFieldInfoPtr_MIDDLE_END_PATTERN;

	private static readonly IntPtr NativeFieldInfoPtr_NUMSYS_AND_CHECK_DIGIT_PATTERNS;

	private static readonly IntPtr NativeFieldInfoPtr_decodeMiddleCounters;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_decodeMiddle_FamOrAssem_Virtual_Int32_BitArray_Il2CppStructArray_1_Int32_StringBuilder_0;

	private static readonly IntPtr NativeMethodInfoPtr_decodeEnd_Protected_Virtual_Il2CppStructArray_1_Int32_BitArray_Int32_0;

	private static readonly IntPtr NativeMethodInfoPtr_checkChecksum_Protected_Virtual_Boolean_String_0;

	private static readonly IntPtr NativeMethodInfoPtr_determineNumSysAndCheckDigit_Private_Static_Boolean_StringBuilder_Int32_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_BarcodeFormat_Internal_Virtual_get_BarcodeFormat_0;

	private static readonly IntPtr NativeMethodInfoPtr_convertUPCEtoUPCA_Public_Static_String_String_0;

	public unsafe static Il2CppStructArray<int> MIDDLE_END_PATTERN
	{
		get
		{
			Unsafe.SkipInit(out IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_MIDDLE_END_PATTERN, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != (IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_MIDDLE_END_PATTERN, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Il2CppReferenceArray<Il2CppStructArray<int>> NUMSYS_AND_CHECK_DIGIT_PATTERNS
	{
		get
		{
			Unsafe.SkipInit(out IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_NUMSYS_AND_CHECK_DIGIT_PATTERNS, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != (IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Il2CppStructArray<int>>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_NUMSYS_AND_CHECK_DIGIT_PATTERNS, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe Il2CppStructArray<int> decodeMiddleCounters
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_decodeMiddleCounters);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_decodeMiddleCounters)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe override BarcodeFormat BarcodeFormat
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_BarcodeFormat_Internal_Virtual_get_BarcodeFormat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(BarcodeFormat*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	static UPCEReader()
	{
		Il2CppClassPointerStore<UPCEReader>.NativeClassPtr = IL2CPP.GetIl2CppClass("zxing.unity.dll", "ZXing.OneD", "UPCEReader");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UPCEReader>.NativeClassPtr);
		NativeFieldInfoPtr_MIDDLE_END_PATTERN = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UPCEReader>.NativeClassPtr, "MIDDLE_END_PATTERN");
		NativeFieldInfoPtr_NUMSYS_AND_CHECK_DIGIT_PATTERNS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UPCEReader>.NativeClassPtr, "NUMSYS_AND_CHECK_DIGIT_PATTERNS");
		NativeFieldInfoPtr_decodeMiddleCounters = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UPCEReader>.NativeClassPtr, "decodeMiddleCounters");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UPCEReader>.NativeClassPtr, 100664230);
		NativeMethodInfoPtr_decodeMiddle_FamOrAssem_Virtual_Int32_BitArray_Il2CppStructArray_1_Int32_StringBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UPCEReader>.NativeClassPtr, 100664231);
		NativeMethodInfoPtr_decodeEnd_Protected_Virtual_Il2CppStructArray_1_Int32_BitArray_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UPCEReader>.NativeClassPtr, 100664232);
		NativeMethodInfoPtr_checkChecksum_Protected_Virtual_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UPCEReader>.NativeClassPtr, 100664233);
		NativeMethodInfoPtr_determineNumSysAndCheckDigit_Private_Static_Boolean_StringBuilder_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UPCEReader>.NativeClassPtr, 100664234);
		NativeMethodInfoPtr_get_BarcodeFormat_Internal_Virtual_get_BarcodeFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UPCEReader>.NativeClassPtr, 100664235);
		NativeMethodInfoPtr_convertUPCEtoUPCA_Public_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UPCEReader>.NativeClassPtr, 100664236);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1423984, RefRangeEnd = 1423986, XrefRangeStart = 1423976, XrefRangeEnd = 1423984, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe UPCEReader()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UPCEReader>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1423986, XrefRangeEnd = 1424002, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override int decodeMiddle(BitArray row, Il2CppStructArray<int> startRange, StringBuilder result)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)row);
		*(IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)startRange);
		*(IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)result);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_decodeMiddle_FamOrAssem_Virtual_Int32_BitArray_Il2CppStructArray_1_Int32_StringBuilder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1424002, XrefRangeEnd = 1424016, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override Il2CppStructArray<int> decodeEnd(BitArray row, int endStart)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)row);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &endStart;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_decodeEnd_Protected_Virtual_Il2CppStructArray_1_Int32_BitArray_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1424016, XrefRangeEnd = 1424024, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override bool checkChecksum(string s)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_checkChecksum_Protected_Virtual_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1424024, XrefRangeEnd = 1424029, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool determineNumSysAndCheckDigit(StringBuilder resultString, int lgPatternFound)
	{
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)resultString);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &lgPatternFound;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_determineNumSysAndCheckDigit_Private_Static_Boolean_StringBuilder_Int32_0, (IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1424062, RefRangeEnd = 1424065, XrefRangeStart = 1424029, XrefRangeEnd = 1424062, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string convertUPCEtoUPCA(string upce)
	{
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(upce);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_convertUPCEtoUPCA_Public_Static_String_String_0, (IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	public UPCEReader(IntPtr pointer)
		: base(pointer)
	{
	}
}
