using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppZXing.PDF417.Internal;

public sealed class DetectionResultRowIndicatorColumn : DetectionResultColumn
{
	private static readonly IntPtr NativeFieldInfoPtr__IsLeft_k__BackingField;

	private static readonly IntPtr NativeMethodInfoPtr_get_IsLeft_Public_get_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_IsLeft_Public_set_Void_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_BoundingBox_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_setRowNumbers_Private_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_adjustCompleteIndicatorColumnRowNumbers_Public_Void_BarcodeMetadata_0;

	private static readonly IntPtr NativeMethodInfoPtr_getRowHeights_Public_Il2CppStructArray_1_Int32_0;

	private static readonly IntPtr NativeMethodInfoPtr_adjustIncompleteIndicatorColumnRowNumbers_Private_Void_BarcodeMetadata_0;

	private static readonly IntPtr NativeMethodInfoPtr_getBarcodeMetadata_Public_BarcodeMetadata_0;

	private static readonly IntPtr NativeMethodInfoPtr_removeIncorrectCodewords_Private_Void_Il2CppReferenceArray_1_Codeword_BarcodeMetadata_0;

	private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

	public unsafe bool _IsLeft_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__IsLeft_k__BackingField);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__IsLeft_k__BackingField)) = value;
		}
	}

	public unsafe bool IsLeft
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_IsLeft_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 59885, RefRangeEnd = 59887, XrefRangeStart = 59885, XrefRangeEnd = 59887, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = stackalloc IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_IsLeft_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	static DetectionResultRowIndicatorColumn()
	{
		Il2CppClassPointerStore<DetectionResultRowIndicatorColumn>.NativeClassPtr = IL2CPP.GetIl2CppClass("zxing.unity.dll", "ZXing.PDF417.Internal", "DetectionResultRowIndicatorColumn");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DetectionResultRowIndicatorColumn>.NativeClassPtr);
		NativeFieldInfoPtr__IsLeft_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DetectionResultRowIndicatorColumn>.NativeClassPtr, "<IsLeft>k__BackingField");
		NativeMethodInfoPtr_get_IsLeft_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DetectionResultRowIndicatorColumn>.NativeClassPtr, 100663903);
		NativeMethodInfoPtr_set_IsLeft_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DetectionResultRowIndicatorColumn>.NativeClassPtr, 100663904);
		NativeMethodInfoPtr__ctor_Public_Void_BoundingBox_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DetectionResultRowIndicatorColumn>.NativeClassPtr, 100663905);
		NativeMethodInfoPtr_setRowNumbers_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DetectionResultRowIndicatorColumn>.NativeClassPtr, 100663906);
		NativeMethodInfoPtr_adjustCompleteIndicatorColumnRowNumbers_Public_Void_BarcodeMetadata_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DetectionResultRowIndicatorColumn>.NativeClassPtr, 100663907);
		NativeMethodInfoPtr_getRowHeights_Public_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DetectionResultRowIndicatorColumn>.NativeClassPtr, 100663908);
		NativeMethodInfoPtr_adjustIncompleteIndicatorColumnRowNumbers_Private_Void_BarcodeMetadata_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DetectionResultRowIndicatorColumn>.NativeClassPtr, 100663909);
		NativeMethodInfoPtr_getBarcodeMetadata_Public_BarcodeMetadata_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DetectionResultRowIndicatorColumn>.NativeClassPtr, 100663910);
		NativeMethodInfoPtr_removeIncorrectCodewords_Private_Void_Il2CppReferenceArray_1_Codeword_BarcodeMetadata_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DetectionResultRowIndicatorColumn>.NativeClassPtr, 100663911);
		NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DetectionResultRowIndicatorColumn>.NativeClassPtr, 100663912);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1418725, XrefRangeEnd = 1418726, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe DetectionResultRowIndicatorColumn(BoundingBox box, bool isLeft)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DetectionResultRowIndicatorColumn>.NativeClassPtr))
	{
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)box);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &isLeft;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_BoundingBox_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1418726, XrefRangeEnd = 1418727, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void setRowNumbers()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_setRowNumbers_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1418738, RefRangeEnd = 1418741, XrefRangeStart = 1418727, XrefRangeEnd = 1418738, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void adjustCompleteIndicatorColumnRowNumbers(BarcodeMetadata metadata)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)metadata);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_adjustCompleteIndicatorColumnRowNumbers_Public_Void_BarcodeMetadata_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1418741, XrefRangeEnd = 1418747, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Il2CppStructArray<int> getRowHeights()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_getRowHeights_Public_Il2CppStructArray_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1418756, RefRangeEnd = 1418758, XrefRangeStart = 1418747, XrefRangeEnd = 1418756, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void adjustIncompleteIndicatorColumnRowNumbers(BarcodeMetadata metadata)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)metadata);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_adjustIncompleteIndicatorColumnRowNumbers_Private_Void_BarcodeMetadata_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 1418791, RefRangeEnd = 1418798, XrefRangeStart = 1418758, XrefRangeEnd = 1418791, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe BarcodeMetadata getBarcodeMetadata()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_getBarcodeMetadata_Public_BarcodeMetadata_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (IntPtr)0) ? Il2CppObjectPool.Get<BarcodeMetadata>(intPtr2) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1418802, RefRangeEnd = 1418804, XrefRangeStart = 1418798, XrefRangeEnd = 1418802, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void removeIncorrectCodewords(Il2CppReferenceArray<Codeword> codewords, BarcodeMetadata metadata)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)codewords);
		*(IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)metadata);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_removeIncorrectCodewords_Private_Void_Il2CppReferenceArray_1_Codeword_BarcodeMetadata_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1418804, XrefRangeEnd = 1418813, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override string ToString()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToString_Public_Virtual_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	public DetectionResultRowIndicatorColumn(IntPtr pointer)
		: base(pointer)
	{
	}
}
