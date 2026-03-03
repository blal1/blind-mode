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

public sealed class UPCAReader : UPCEANReader
{
	private static readonly System.IntPtr NativeFieldInfoPtr_ean13Reader;

	private static readonly System.IntPtr NativeMethodInfoPtr_decodeRow_Public_Virtual_Result_Int32_BitArray_Il2CppStructArray_1_Int32_IDictionary_2_DecodeHintType_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_decodeRow_Public_Virtual_Result_Int32_BitArray_IDictionary_2_DecodeHintType_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_decode_Public_Virtual_Result_BinaryBitmap_IDictionary_2_DecodeHintType_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_BarcodeFormat_Internal_Virtual_get_BarcodeFormat_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_decodeMiddle_FamOrAssem_Virtual_Int32_BitArray_Il2CppStructArray_1_Int32_StringBuilder_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_maybeReturnResult_Private_Static_Result_Result_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe UPCEANReader ean13Reader
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ean13Reader);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<UPCEANReader>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ean13Reader)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe override BarcodeFormat BarcodeFormat
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_BarcodeFormat_Internal_Virtual_get_BarcodeFormat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(BarcodeFormat*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	static UPCAReader()
	{
		Il2CppClassPointerStore<UPCAReader>.NativeClassPtr = IL2CPP.GetIl2CppClass("zxing.unity.dll", "ZXing.OneD", "UPCAReader");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UPCAReader>.NativeClassPtr);
		NativeFieldInfoPtr_ean13Reader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UPCAReader>.NativeClassPtr, "ean13Reader");
		NativeMethodInfoPtr_decodeRow_Public_Virtual_Result_Int32_BitArray_Il2CppStructArray_1_Int32_IDictionary_2_DecodeHintType_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UPCAReader>.NativeClassPtr, 100664190);
		NativeMethodInfoPtr_decodeRow_Public_Virtual_Result_Int32_BitArray_IDictionary_2_DecodeHintType_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UPCAReader>.NativeClassPtr, 100664191);
		NativeMethodInfoPtr_decode_Public_Virtual_Result_BinaryBitmap_IDictionary_2_DecodeHintType_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UPCAReader>.NativeClassPtr, 100664192);
		NativeMethodInfoPtr_get_BarcodeFormat_Internal_Virtual_get_BarcodeFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UPCAReader>.NativeClassPtr, 100664193);
		NativeMethodInfoPtr_decodeMiddle_FamOrAssem_Virtual_Int32_BitArray_Il2CppStructArray_1_Int32_StringBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UPCAReader>.NativeClassPtr, 100664194);
		NativeMethodInfoPtr_maybeReturnResult_Private_Static_Result_Result_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UPCAReader>.NativeClassPtr, 100664195);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UPCAReader>.NativeClassPtr, 100664196);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1423433, XrefRangeEnd = 1423435, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override Result decodeRow(int rowNumber, BitArray row, Il2CppStructArray<int> startGuardRange, IDictionary<DecodeHintType, Il2CppSystem.Object> hints)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&rowNumber);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)row);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)startGuardRange);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)hints);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_decodeRow_Public_Virtual_Result_Int32_BitArray_Il2CppStructArray_1_Int32_IDictionary_2_DecodeHintType_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Result>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1423435, XrefRangeEnd = 1423437, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1423437, XrefRangeEnd = 1423439, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override Result decode(BinaryBitmap image, IDictionary<DecodeHintType, Il2CppSystem.Object> hints)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)image);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)hints);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_decode_Public_Virtual_Result_BinaryBitmap_IDictionary_2_DecodeHintType_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Result>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1423439, XrefRangeEnd = 1423440, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override int decodeMiddle(BitArray row, Il2CppStructArray<int> startRange, StringBuilder resultString)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)row);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)startRange);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)resultString);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_decodeMiddle_FamOrAssem_Virtual_Int32_BitArray_Il2CppStructArray_1_Int32_StringBuilder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1423442, RefRangeEnd = 1423445, XrefRangeStart = 1423440, XrefRangeEnd = 1423442, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Result maybeReturnResult(Result result)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)result);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_maybeReturnResult_Private_Static_Result_Result_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Result>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1423445, XrefRangeEnd = 1423454, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe UPCAReader()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UPCAReader>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public UPCAReader(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
