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

public sealed class UPCEANExtension5Support : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_CHECK_DIGIT_ENCODINGS;

	private static readonly System.IntPtr NativeFieldInfoPtr_decodeMiddleCounters;

	private static readonly System.IntPtr NativeFieldInfoPtr_decodeRowStringBuffer;

	private static readonly System.IntPtr NativeMethodInfoPtr_decodeRow_Internal_Result_Int32_BitArray_Il2CppStructArray_1_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_decodeMiddle_Private_Int32_BitArray_Il2CppStructArray_1_Int32_StringBuilder_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_extensionChecksum_Private_Static_Int32_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_determineCheckDigit_Private_Static_Boolean_Int32_byref_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_parseExtensionString_Private_Static_IDictionary_2_ResultMetadataType_Object_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_parseExtension5String_Private_Static_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe static Il2CppStructArray<int> CHECK_DIGIT_ENCODINGS
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_CHECK_DIGIT_ENCODINGS, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_CHECK_DIGIT_ENCODINGS, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe Il2CppStructArray<int> decodeMiddleCounters
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_decodeMiddleCounters);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_decodeMiddleCounters)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe StringBuilder decodeRowStringBuffer
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_decodeRowStringBuffer);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<StringBuilder>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_decodeRowStringBuffer)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	static UPCEANExtension5Support()
	{
		Il2CppClassPointerStore<UPCEANExtension5Support>.NativeClassPtr = IL2CPP.GetIl2CppClass("zxing.unity.dll", "ZXing.OneD", "UPCEANExtension5Support");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UPCEANExtension5Support>.NativeClassPtr);
		NativeFieldInfoPtr_CHECK_DIGIT_ENCODINGS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UPCEANExtension5Support>.NativeClassPtr, "CHECK_DIGIT_ENCODINGS");
		NativeFieldInfoPtr_decodeMiddleCounters = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UPCEANExtension5Support>.NativeClassPtr, "decodeMiddleCounters");
		NativeFieldInfoPtr_decodeRowStringBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UPCEANExtension5Support>.NativeClassPtr, "decodeRowStringBuffer");
		NativeMethodInfoPtr_decodeRow_Internal_Result_Int32_BitArray_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UPCEANExtension5Support>.NativeClassPtr, 100664203);
		NativeMethodInfoPtr_decodeMiddle_Private_Int32_BitArray_Il2CppStructArray_1_Int32_StringBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UPCEANExtension5Support>.NativeClassPtr, 100664204);
		NativeMethodInfoPtr_extensionChecksum_Private_Static_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UPCEANExtension5Support>.NativeClassPtr, 100664205);
		NativeMethodInfoPtr_determineCheckDigit_Private_Static_Boolean_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UPCEANExtension5Support>.NativeClassPtr, 100664206);
		NativeMethodInfoPtr_parseExtensionString_Private_Static_IDictionary_2_ResultMetadataType_Object_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UPCEANExtension5Support>.NativeClassPtr, 100664207);
		NativeMethodInfoPtr_parseExtension5String_Private_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UPCEANExtension5Support>.NativeClassPtr, 100664208);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UPCEANExtension5Support>.NativeClassPtr, 100664209);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1423590, RefRangeEnd = 1423592, XrefRangeStart = 1423552, XrefRangeEnd = 1423590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Result decodeRow(int rowNumber, BitArray row, Il2CppStructArray<int> extensionStartRange)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&rowNumber);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)row);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)extensionStartRange);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_decodeRow_Internal_Result_Int32_BitArray_Il2CppStructArray_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Result>(intPtr2) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1423611, RefRangeEnd = 1423612, XrefRangeStart = 1423592, XrefRangeEnd = 1423611, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int decodeMiddle(BitArray row, Il2CppStructArray<int> startRange, StringBuilder resultString)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)row);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)startRange);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)resultString);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_decodeMiddle_Private_Int32_BitArray_Il2CppStructArray_1_Int32_StringBuilder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1423612, XrefRangeEnd = 1423614, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int extensionChecksum(string s)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_extensionChecksum_Private_Static_Int32_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1423614, XrefRangeEnd = 1423618, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool determineCheckDigit(int lgPatternFound, out int checkDigit)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&lgPatternFound);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref checkDigit);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_determineCheckDigit_Private_Static_Boolean_Int32_byref_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1423618, XrefRangeEnd = 1423631, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static IDictionary<ResultMetadataType, Il2CppSystem.Object> parseExtensionString(string raw)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(raw);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_parseExtensionString_Private_Static_IDictionary_2_ResultMetadataType_Object_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<IDictionary<ResultMetadataType, Il2CppSystem.Object>>(intPtr2) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1423653, RefRangeEnd = 1423655, XrefRangeStart = 1423631, XrefRangeEnd = 1423653, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string parseExtension5String(string raw)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(raw);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_parseExtension5String_Private_Static_String_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1423655, XrefRangeEnd = 1423665, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe UPCEANExtension5Support()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UPCEANExtension5Support>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public UPCEANExtension5Support(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
