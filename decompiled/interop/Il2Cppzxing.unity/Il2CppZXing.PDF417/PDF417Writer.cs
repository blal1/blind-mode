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
using Il2CppZXing.PDF417.Internal;

namespace Il2CppZXing.PDF417;

public sealed class PDF417Writer : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeMethodInfoPtr_encode_Public_Virtual_Final_New_BitMatrix_String_BarcodeFormat_Int32_Int32_IDictionary_2_EncodeHintType_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_bitMatrixFromEncoder_Private_Static_BitMatrix_PDF417_String_Int32_Int32_Int32_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_bitMatrixFromBitArray_Private_Static_BitMatrix_Il2CppReferenceArray_1_Il2CppStructArray_1_SByte_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_rotateArray_Private_Static_Il2CppReferenceArray_1_Il2CppStructArray_1_SByte_Il2CppReferenceArray_1_Il2CppStructArray_1_SByte_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	static PDF417Writer()
	{
		Il2CppClassPointerStore<PDF417Writer>.NativeClassPtr = IL2CPP.GetIl2CppClass("zxing.unity.dll", "ZXing.PDF417", "PDF417Writer");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PDF417Writer>.NativeClassPtr);
		NativeMethodInfoPtr_encode_Public_Virtual_Final_New_BitMatrix_String_BarcodeFormat_Int32_Int32_IDictionary_2_EncodeHintType_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PDF417Writer>.NativeClassPtr, 100663803);
		NativeMethodInfoPtr_bitMatrixFromEncoder_Private_Static_BitMatrix_PDF417_String_Int32_Int32_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PDF417Writer>.NativeClassPtr, 100663804);
		NativeMethodInfoPtr_bitMatrixFromBitArray_Private_Static_BitMatrix_Il2CppReferenceArray_1_Il2CppStructArray_1_SByte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PDF417Writer>.NativeClassPtr, 100663805);
		NativeMethodInfoPtr_rotateArray_Private_Static_Il2CppReferenceArray_1_Il2CppStructArray_1_SByte_Il2CppReferenceArray_1_Il2CppStructArray_1_SByte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PDF417Writer>.NativeClassPtr, 100663806);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PDF417Writer>.NativeClassPtr, 100663807);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1417876, XrefRangeEnd = 1418032, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual BitMatrix encode(string contents, BarcodeFormat format, int width, int height, IDictionary<EncodeHintType, Il2CppSystem.Object> hints)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(contents);
		*(BarcodeFormat**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &format;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &width;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &height;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)hints);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_encode_Public_Virtual_Final_New_BitMatrix_String_BarcodeFormat_Int32_Int32_IDictionary_2_EncodeHintType_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<BitMatrix>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1418032, XrefRangeEnd = 1418037, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static BitMatrix bitMatrixFromEncoder(Il2CppZXing.PDF417.Internal.PDF417 encoder, string contents, int errorCorrectionLevel, int width, int height, int margin, int aspectRatio)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[7];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)encoder);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(contents);
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &errorCorrectionLevel;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &width;
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &height;
		*(int**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &margin;
		*(int**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = &aspectRatio;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_bitMatrixFromEncoder_Private_Static_BitMatrix_PDF417_String_Int32_Int32_Int32_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<BitMatrix>(intPtr2) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1418043, RefRangeEnd = 1418045, XrefRangeStart = 1418037, XrefRangeEnd = 1418043, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static BitMatrix bitMatrixFromBitArray(Il2CppReferenceArray<Il2CppStructArray<sbyte>> input, int margin)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)input);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &margin;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_bitMatrixFromBitArray_Private_Static_BitMatrix_Il2CppReferenceArray_1_Il2CppStructArray_1_SByte_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<BitMatrix>(intPtr2) : null;
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1418055, RefRangeEnd = 1418058, XrefRangeStart = 1418045, XrefRangeEnd = 1418055, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppReferenceArray<Il2CppStructArray<sbyte>> rotateArray(Il2CppReferenceArray<Il2CppStructArray<sbyte>> bitarray)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)bitarray);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_rotateArray_Private_Static_Il2CppReferenceArray_1_Il2CppStructArray_1_SByte_Il2CppReferenceArray_1_Il2CppStructArray_1_SByte_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Il2CppStructArray<sbyte>>>(intPtr2) : null;
	}

	[CallerCount(1950)]
	[CachedScanResults(RefRangeStart = 20036, RefRangeEnd = 21986, XrefRangeStart = 20036, XrefRangeEnd = 21986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe PDF417Writer()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PDF417Writer>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public PDF417Writer(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
