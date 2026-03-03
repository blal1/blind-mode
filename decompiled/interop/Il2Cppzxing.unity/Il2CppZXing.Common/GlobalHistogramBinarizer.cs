using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppZXing.Common;

public class GlobalHistogramBinarizer : Binarizer
{
	private static readonly IntPtr NativeFieldInfoPtr_EMPTY;

	private static readonly IntPtr NativeFieldInfoPtr_luminances;

	private static readonly IntPtr NativeFieldInfoPtr_buckets;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_LuminanceSource_0;

	private static readonly IntPtr NativeMethodInfoPtr_getBlackRow_Public_Virtual_BitArray_Int32_BitArray_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_BlackMatrix_Public_Virtual_get_BitMatrix_0;

	private static readonly IntPtr NativeMethodInfoPtr_createBinarizer_Public_Virtual_Binarizer_LuminanceSource_0;

	private static readonly IntPtr NativeMethodInfoPtr_initArrays_Private_Void_Int32_0;

	private static readonly IntPtr NativeMethodInfoPtr_estimateBlackPoint_Private_Static_Boolean_Il2CppStructArray_1_Int32_byref_Int32_0;

	public unsafe static Il2CppStructArray<byte> EMPTY
	{
		get
		{
			Unsafe.SkipInit(out IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_EMPTY, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != (IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_EMPTY, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe Il2CppStructArray<byte> luminances
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_luminances);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_luminances)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe Il2CppStructArray<int> buckets
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_buckets);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_buckets)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe override BitMatrix BlackMatrix
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1429183, XrefRangeEnd = 1429193, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_get_BlackMatrix_Public_Virtual_get_BitMatrix_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (IntPtr)0) ? Il2CppObjectPool.Get<BitMatrix>(intPtr2) : null;
		}
	}

	static GlobalHistogramBinarizer()
	{
		Il2CppClassPointerStore<GlobalHistogramBinarizer>.NativeClassPtr = IL2CPP.GetIl2CppClass("zxing.unity.dll", "ZXing.Common", "GlobalHistogramBinarizer");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GlobalHistogramBinarizer>.NativeClassPtr);
		NativeFieldInfoPtr_EMPTY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalHistogramBinarizer>.NativeClassPtr, "EMPTY");
		NativeFieldInfoPtr_luminances = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalHistogramBinarizer>.NativeClassPtr, "luminances");
		NativeFieldInfoPtr_buckets = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalHistogramBinarizer>.NativeClassPtr, "buckets");
		NativeMethodInfoPtr__ctor_Public_Void_LuminanceSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalHistogramBinarizer>.NativeClassPtr, 100664761);
		NativeMethodInfoPtr_getBlackRow_Public_Virtual_BitArray_Int32_BitArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalHistogramBinarizer>.NativeClassPtr, 100664762);
		NativeMethodInfoPtr_get_BlackMatrix_Public_Virtual_get_BitMatrix_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalHistogramBinarizer>.NativeClassPtr, 100664763);
		NativeMethodInfoPtr_createBinarizer_Public_Virtual_Binarizer_LuminanceSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalHistogramBinarizer>.NativeClassPtr, 100664764);
		NativeMethodInfoPtr_initArrays_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalHistogramBinarizer>.NativeClassPtr, 100664765);
		NativeMethodInfoPtr_estimateBlackPoint_Private_Static_Boolean_Il2CppStructArray_1_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalHistogramBinarizer>.NativeClassPtr, 100664766);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1429168, RefRangeEnd = 1429171, XrefRangeStart = 1429158, XrefRangeEnd = 1429168, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe GlobalHistogramBinarizer(LuminanceSource source)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GlobalHistogramBinarizer>.NativeClassPtr))
	{
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)source);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_LuminanceSource_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1429171, XrefRangeEnd = 1429183, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override BitArray getBlackRow(int y, BitArray row)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = (nint)(&y);
		*(IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)row);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_getBlackRow_Public_Virtual_BitArray_Int32_BitArray_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (IntPtr)0) ? Il2CppObjectPool.Get<BitArray>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1429193, XrefRangeEnd = 1429197, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override Binarizer createBinarizer(LuminanceSource source)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)source);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_createBinarizer_Public_Virtual_Binarizer_LuminanceSource_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (IntPtr)0) ? Il2CppObjectPool.Get<Binarizer>(intPtr2) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1429201, RefRangeEnd = 1429203, XrefRangeStart = 1429197, XrefRangeEnd = 1429201, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void initArrays(int luminanceSize)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&luminanceSize);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_initArrays_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1429204, RefRangeEnd = 1429206, XrefRangeStart = 1429203, XrefRangeEnd = 1429204, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool estimateBlackPoint(Il2CppStructArray<int> buckets, out int blackPoint)
	{
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)buckets);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = Unsafe.AsPointer(ref blackPoint);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_estimateBlackPoint_Private_Static_Boolean_Il2CppStructArray_1_Int32_byref_Int32_0, (IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	public GlobalHistogramBinarizer(IntPtr pointer)
		: base(pointer)
	{
	}
}
