using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppZXing.Common;

public sealed class HybridBinarizer : GlobalHistogramBinarizer
{
	private static readonly IntPtr NativeFieldInfoPtr_matrix;

	private static readonly IntPtr NativeMethodInfoPtr_get_BlackMatrix_Public_Virtual_get_BitMatrix_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_LuminanceSource_0;

	private static readonly IntPtr NativeMethodInfoPtr_createBinarizer_Public_Virtual_Binarizer_LuminanceSource_0;

	private static readonly IntPtr NativeMethodInfoPtr_binarizeEntireImage_Private_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_calculateThresholdForBlock_Private_Static_Void_Il2CppStructArray_1_Byte_Int32_Int32_Int32_Int32_Il2CppReferenceArray_1_Il2CppStructArray_1_Int32_BitMatrix_0;

	private static readonly IntPtr NativeMethodInfoPtr_cap_Private_Static_Int32_Int32_Int32_0;

	private static readonly IntPtr NativeMethodInfoPtr_thresholdBlock_Private_Static_Void_Il2CppStructArray_1_Byte_Int32_Int32_Int32_Int32_BitMatrix_0;

	private static readonly IntPtr NativeMethodInfoPtr_calculateBlackPoints_Private_Static_Il2CppReferenceArray_1_Il2CppStructArray_1_Int32_Il2CppStructArray_1_Byte_Int32_Int32_Int32_Int32_0;

	public unsafe BitMatrix matrix
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_matrix);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<BitMatrix>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_matrix)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe override BitMatrix BlackMatrix
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1429366, XrefRangeEnd = 1429373, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_BlackMatrix_Public_Virtual_get_BitMatrix_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (IntPtr)0) ? Il2CppObjectPool.Get<BitMatrix>(intPtr2) : null;
		}
	}

	static HybridBinarizer()
	{
		Il2CppClassPointerStore<HybridBinarizer>.NativeClassPtr = IL2CPP.GetIl2CppClass("zxing.unity.dll", "ZXing.Common", "HybridBinarizer");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HybridBinarizer>.NativeClassPtr);
		NativeFieldInfoPtr_matrix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HybridBinarizer>.NativeClassPtr, "matrix");
		NativeMethodInfoPtr_get_BlackMatrix_Public_Virtual_get_BitMatrix_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HybridBinarizer>.NativeClassPtr, 100664774);
		NativeMethodInfoPtr__ctor_Public_Void_LuminanceSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HybridBinarizer>.NativeClassPtr, 100664775);
		NativeMethodInfoPtr_createBinarizer_Public_Virtual_Binarizer_LuminanceSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HybridBinarizer>.NativeClassPtr, 100664776);
		NativeMethodInfoPtr_binarizeEntireImage_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HybridBinarizer>.NativeClassPtr, 100664777);
		NativeMethodInfoPtr_calculateThresholdForBlock_Private_Static_Void_Il2CppStructArray_1_Byte_Int32_Int32_Int32_Int32_Il2CppReferenceArray_1_Il2CppStructArray_1_Int32_BitMatrix_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HybridBinarizer>.NativeClassPtr, 100664778);
		NativeMethodInfoPtr_cap_Private_Static_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HybridBinarizer>.NativeClassPtr, 100664779);
		NativeMethodInfoPtr_thresholdBlock_Private_Static_Void_Il2CppStructArray_1_Byte_Int32_Int32_Int32_Int32_BitMatrix_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HybridBinarizer>.NativeClassPtr, 100664780);
		NativeMethodInfoPtr_calculateBlackPoints_Private_Static_Il2CppReferenceArray_1_Il2CppStructArray_1_Int32_Il2CppStructArray_1_Byte_Int32_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HybridBinarizer>.NativeClassPtr, 100664781);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1429377, RefRangeEnd = 1429378, XrefRangeStart = 1429373, XrefRangeEnd = 1429377, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe HybridBinarizer(LuminanceSource source)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HybridBinarizer>.NativeClassPtr))
	{
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)source);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_LuminanceSource_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1429378, XrefRangeEnd = 1429385, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override Binarizer createBinarizer(LuminanceSource source)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)source);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_createBinarizer_Public_Virtual_Binarizer_LuminanceSource_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (IntPtr)0) ? Il2CppObjectPool.Get<Binarizer>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1429385, XrefRangeEnd = 1429392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void binarizeEntireImage()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_binarizeEntireImage_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1429396, RefRangeEnd = 1429398, XrefRangeStart = 1429392, XrefRangeEnd = 1429396, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void calculateThresholdForBlock(Il2CppStructArray<byte> luminances, int subWidth, int subHeight, int width, int height, Il2CppReferenceArray<Il2CppStructArray<int>> blackPoints, BitMatrix matrix)
	{
		IntPtr* ptr = stackalloc IntPtr[7];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)luminances);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &subWidth;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(IntPtr)))) = &subHeight;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(IntPtr)))) = &width;
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(IntPtr)))) = &height;
		*(IntPtr*)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)blackPoints);
		*(IntPtr*)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)matrix);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_calculateThresholdForBlock_Private_Static_Void_Il2CppStructArray_1_Byte_Int32_Int32_Int32_Int32_Il2CppReferenceArray_1_Il2CppStructArray_1_Int32_BitMatrix_0, (IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	public unsafe static int cap(int value, int max)
	{
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = (nint)(&value);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &max;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_cap_Private_Static_Int32_Int32_Int32_0, (IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1429398, XrefRangeEnd = 1429400, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void thresholdBlock(Il2CppStructArray<byte> luminances, int xoffset, int yoffset, int threshold, int stride, BitMatrix matrix)
	{
		IntPtr* ptr = stackalloc IntPtr[6];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)luminances);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &xoffset;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(IntPtr)))) = &yoffset;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(IntPtr)))) = &threshold;
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(IntPtr)))) = &stride;
		*(IntPtr*)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)matrix);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_thresholdBlock_Private_Static_Void_Il2CppStructArray_1_Byte_Int32_Int32_Int32_Int32_BitMatrix_0, (IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1429410, RefRangeEnd = 1429412, XrefRangeStart = 1429400, XrefRangeEnd = 1429410, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppReferenceArray<Il2CppStructArray<int>> calculateBlackPoints(Il2CppStructArray<byte> luminances, int subWidth, int subHeight, int width, int height)
	{
		IntPtr* ptr = stackalloc IntPtr[5];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)luminances);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &subWidth;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(IntPtr)))) = &subHeight;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(IntPtr)))) = &width;
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(IntPtr)))) = &height;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_calculateBlackPoints_Private_Static_Il2CppReferenceArray_1_Il2CppStructArray_1_Int32_Il2CppStructArray_1_Byte_Int32_Int32_Int32_Int32_0, (IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Il2CppStructArray<int>>>(intPtr2) : null;
	}

	public HybridBinarizer(IntPtr pointer)
		: base(pointer)
	{
	}
}
