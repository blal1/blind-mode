using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppZXing.PDF417.Internal;

public class DetectionResult : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr__Metadata_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__DetectionResultColumns_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__Box_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__ColumnCount_k__BackingField;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Metadata_Public_get_BarcodeMetadata_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_Metadata_Private_set_Void_BarcodeMetadata_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_DetectionResultColumns_Public_get_Il2CppReferenceArray_1_DetectionResultColumn_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_DetectionResultColumns_Public_set_Void_Il2CppReferenceArray_1_DetectionResultColumn_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Box_Public_get_BoundingBox_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_Box_Internal_set_Void_BoundingBox_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_ColumnCount_Public_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_ColumnCount_Private_set_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_RowCount_Public_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_ErrorCorrectionLevel_Public_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_BarcodeMetadata_BoundingBox_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_getDetectionResultColumns_Public_Il2CppReferenceArray_1_DetectionResultColumn_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_adjustIndicatorColumnRowNumbers_Private_Void_DetectionResultColumn_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_adjustRowNumbers_Private_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_adjustRowNumbersByRow_Private_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_adjustRowNumbersFromBothRI_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_adjustRowNumbersFromRRI_Private_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_adjustRowNumbersFromLRI_Private_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_adjustRowNumberIfValid_Private_Static_Int32_Int32_Int32_Codeword_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_adjustRowNumbers_Private_Void_Int32_Int32_Il2CppReferenceArray_1_Codeword_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_adjustRowNumber_Private_Static_Boolean_Codeword_Codeword_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

	public unsafe BarcodeMetadata _Metadata_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__Metadata_k__BackingField);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<BarcodeMetadata>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__Metadata_k__BackingField)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe Il2CppReferenceArray<DetectionResultColumn> _DetectionResultColumns_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__DetectionResultColumns_k__BackingField);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<DetectionResultColumn>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__DetectionResultColumns_k__BackingField)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe BoundingBox _Box_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__Box_k__BackingField);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<BoundingBox>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__Box_k__BackingField)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe int _ColumnCount_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__ColumnCount_k__BackingField);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__ColumnCount_k__BackingField)) = value;
		}
	}

	public unsafe BarcodeMetadata Metadata
	{
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 50644, RefRangeEnd = 50653, XrefRangeStart = 50644, XrefRangeEnd = 50653, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Metadata_Public_get_BarcodeMetadata_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<BarcodeMetadata>(intPtr2) : null;
		}
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 42532, RefRangeEnd = 42533, XrefRangeStart = 42532, XrefRangeEnd = 42533, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_Metadata_Private_set_Void_BarcodeMetadata_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe Il2CppReferenceArray<DetectionResultColumn> DetectionResultColumns
	{
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 25665, RefRangeEnd = 25677, XrefRangeStart = 25665, XrefRangeEnd = 25677, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_DetectionResultColumns_Public_get_Il2CppReferenceArray_1_DetectionResultColumn_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<DetectionResultColumn>>(intPtr2) : null;
		}
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 86477, RefRangeEnd = 86487, XrefRangeStart = 86477, XrefRangeEnd = 86487, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_DetectionResultColumns_Public_set_Void_Il2CppReferenceArray_1_DetectionResultColumn_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe BoundingBox Box
	{
		[CallerCount(36)]
		[CachedScanResults(RefRangeStart = 32112, RefRangeEnd = 32148, XrefRangeStart = 32112, XrefRangeEnd = 32148, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Box_Public_get_BoundingBox_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<BoundingBox>(intPtr2) : null;
		}
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 32149, RefRangeEnd = 32159, XrefRangeStart = 32149, XrefRangeEnd = 32159, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_Box_Internal_set_Void_BoundingBox_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe int ColumnCount
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 80842, RefRangeEnd = 80843, XrefRangeStart = 80842, XrefRangeEnd = 80843, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_ColumnCount_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 84616, RefRangeEnd = 84621, XrefRangeStart = 84616, XrefRangeEnd = 84621, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_ColumnCount_Private_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe int RowCount
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_RowCount_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe int ErrorCorrectionLevel
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_ErrorCorrectionLevel_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	static DetectionResult()
	{
		Il2CppClassPointerStore<DetectionResult>.NativeClassPtr = IL2CPP.GetIl2CppClass("zxing.unity.dll", "ZXing.PDF417.Internal", "DetectionResult");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DetectionResult>.NativeClassPtr);
		NativeFieldInfoPtr__Metadata_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DetectionResult>.NativeClassPtr, "<Metadata>k__BackingField");
		NativeFieldInfoPtr__DetectionResultColumns_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DetectionResult>.NativeClassPtr, "<DetectionResultColumns>k__BackingField");
		NativeFieldInfoPtr__Box_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DetectionResult>.NativeClassPtr, "<Box>k__BackingField");
		NativeFieldInfoPtr__ColumnCount_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DetectionResult>.NativeClassPtr, "<ColumnCount>k__BackingField");
		NativeMethodInfoPtr_get_Metadata_Public_get_BarcodeMetadata_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DetectionResult>.NativeClassPtr, 100663870);
		NativeMethodInfoPtr_set_Metadata_Private_set_Void_BarcodeMetadata_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DetectionResult>.NativeClassPtr, 100663871);
		NativeMethodInfoPtr_get_DetectionResultColumns_Public_get_Il2CppReferenceArray_1_DetectionResultColumn_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DetectionResult>.NativeClassPtr, 100663872);
		NativeMethodInfoPtr_set_DetectionResultColumns_Public_set_Void_Il2CppReferenceArray_1_DetectionResultColumn_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DetectionResult>.NativeClassPtr, 100663873);
		NativeMethodInfoPtr_get_Box_Public_get_BoundingBox_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DetectionResult>.NativeClassPtr, 100663874);
		NativeMethodInfoPtr_set_Box_Internal_set_Void_BoundingBox_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DetectionResult>.NativeClassPtr, 100663875);
		NativeMethodInfoPtr_get_ColumnCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DetectionResult>.NativeClassPtr, 100663876);
		NativeMethodInfoPtr_set_ColumnCount_Private_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DetectionResult>.NativeClassPtr, 100663877);
		NativeMethodInfoPtr_get_RowCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DetectionResult>.NativeClassPtr, 100663878);
		NativeMethodInfoPtr_get_ErrorCorrectionLevel_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DetectionResult>.NativeClassPtr, 100663879);
		NativeMethodInfoPtr__ctor_Public_Void_BarcodeMetadata_BoundingBox_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DetectionResult>.NativeClassPtr, 100663880);
		NativeMethodInfoPtr_getDetectionResultColumns_Public_Il2CppReferenceArray_1_DetectionResultColumn_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DetectionResult>.NativeClassPtr, 100663881);
		NativeMethodInfoPtr_adjustIndicatorColumnRowNumbers_Private_Void_DetectionResultColumn_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DetectionResult>.NativeClassPtr, 100663882);
		NativeMethodInfoPtr_adjustRowNumbers_Private_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DetectionResult>.NativeClassPtr, 100663883);
		NativeMethodInfoPtr_adjustRowNumbersByRow_Private_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DetectionResult>.NativeClassPtr, 100663884);
		NativeMethodInfoPtr_adjustRowNumbersFromBothRI_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DetectionResult>.NativeClassPtr, 100663885);
		NativeMethodInfoPtr_adjustRowNumbersFromRRI_Private_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DetectionResult>.NativeClassPtr, 100663886);
		NativeMethodInfoPtr_adjustRowNumbersFromLRI_Private_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DetectionResult>.NativeClassPtr, 100663887);
		NativeMethodInfoPtr_adjustRowNumberIfValid_Private_Static_Int32_Int32_Int32_Codeword_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DetectionResult>.NativeClassPtr, 100663888);
		NativeMethodInfoPtr_adjustRowNumbers_Private_Void_Int32_Int32_Il2CppReferenceArray_1_Codeword_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DetectionResult>.NativeClassPtr, 100663889);
		NativeMethodInfoPtr_adjustRowNumber_Private_Static_Boolean_Codeword_Codeword_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DetectionResult>.NativeClassPtr, 100663890);
		NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DetectionResult>.NativeClassPtr, 100663891);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1418504, XrefRangeEnd = 1418512, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe DetectionResult(BarcodeMetadata metadata, BoundingBox box)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DetectionResult>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)metadata);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)box);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_BarcodeMetadata_BoundingBox_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1418528, RefRangeEnd = 1418529, XrefRangeStart = 1418512, XrefRangeEnd = 1418528, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Il2CppReferenceArray<DetectionResultColumn> getDetectionResultColumns()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_getDetectionResultColumns_Public_Il2CppReferenceArray_1_DetectionResultColumn_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<DetectionResultColumn>>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1418529, XrefRangeEnd = 1418532, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void adjustIndicatorColumnRowNumbers(DetectionResultColumn detectionResultColumn)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)detectionResultColumn);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_adjustIndicatorColumnRowNumbers_Private_Void_DetectionResultColumn_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1418532, XrefRangeEnd = 1418538, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int adjustRowNumbers()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_adjustRowNumbers_Private_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1418538, XrefRangeEnd = 1418541, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int adjustRowNumbersByRow()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_adjustRowNumbersByRow_Private_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1418544, RefRangeEnd = 1418547, XrefRangeStart = 1418541, XrefRangeEnd = 1418544, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void adjustRowNumbersFromBothRI()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_adjustRowNumbersFromBothRI_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1418552, RefRangeEnd = 1418555, XrefRangeStart = 1418547, XrefRangeEnd = 1418552, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int adjustRowNumbersFromRRI()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_adjustRowNumbersFromRRI_Private_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1418560, RefRangeEnd = 1418563, XrefRangeStart = 1418555, XrefRangeEnd = 1418560, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int adjustRowNumbersFromLRI()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_adjustRowNumbersFromLRI_Private_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1418563, XrefRangeEnd = 1418565, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int adjustRowNumberIfValid(int rowIndicatorRowNumber, int invalidRowCounts, Codeword codeword)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&rowIndicatorRowNumber);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &invalidRowCounts;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)codeword);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_adjustRowNumberIfValid_Private_Static_Int32_Int32_Int32_Codeword_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1418584, RefRangeEnd = 1418586, XrefRangeStart = 1418565, XrefRangeEnd = 1418584, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void adjustRowNumbers(int barcodeColumn, int codewordsRow, Il2CppReferenceArray<Codeword> codewords)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&barcodeColumn);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &codewordsRow;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)codewords);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_adjustRowNumbers_Private_Void_Int32_Int32_Il2CppReferenceArray_1_Codeword_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1418586, XrefRangeEnd = 1418587, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool adjustRowNumber(Codeword codeword, Codeword otherCodeword)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)codeword);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)otherCodeword);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_adjustRowNumber_Private_Static_Boolean_Codeword_Codeword_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1418587, XrefRangeEnd = 1418644, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override string ToString()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	public DetectionResult(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
