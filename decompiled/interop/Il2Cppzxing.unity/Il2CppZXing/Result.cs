using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Il2CppZXing;

public sealed class Result : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr__Text_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__RawBytes_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__ResultPoints_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__BarcodeFormat_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__ResultMetadata_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__Timestamp_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__NumBits_k__BackingField;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Text_Public_get_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_Text_Private_set_Void_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_RawBytes_Public_get_Il2CppStructArray_1_Byte_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_RawBytes_Private_set_Void_Il2CppStructArray_1_Byte_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_ResultPoints_Public_get_Il2CppReferenceArray_1_ResultPoint_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_ResultPoints_Private_set_Void_Il2CppReferenceArray_1_ResultPoint_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_BarcodeFormat_Public_get_BarcodeFormat_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_BarcodeFormat_Private_set_Void_BarcodeFormat_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_ResultMetadata_Public_get_IDictionary_2_ResultMetadataType_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_ResultMetadata_Private_set_Void_IDictionary_2_ResultMetadataType_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_Timestamp_Private_set_Void_Int64_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_NumBits_Private_set_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Il2CppStructArray_1_Byte_Il2CppReferenceArray_1_ResultPoint_BarcodeFormat_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Il2CppStructArray_1_Byte_Int32_Il2CppReferenceArray_1_ResultPoint_BarcodeFormat_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Il2CppStructArray_1_Byte_Int32_Il2CppReferenceArray_1_ResultPoint_BarcodeFormat_Int64_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_putMetadata_Public_Void_ResultMetadataType_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_putAllMetadata_Public_Void_IDictionary_2_ResultMetadataType_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_addResultPoints_Public_Void_Il2CppReferenceArray_1_ResultPoint_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

	public unsafe string _Text_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__Text_k__BackingField);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__Text_k__BackingField)), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe Il2CppStructArray<byte> _RawBytes_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__RawBytes_k__BackingField);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__RawBytes_k__BackingField)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe Il2CppReferenceArray<ResultPoint> _ResultPoints_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__ResultPoints_k__BackingField);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ResultPoint>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__ResultPoints_k__BackingField)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe BarcodeFormat _BarcodeFormat_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__BarcodeFormat_k__BackingField);
			return *(BarcodeFormat*)num;
		}
		set
		{
			*(BarcodeFormat*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__BarcodeFormat_k__BackingField)) = value;
		}
	}

	public unsafe IDictionary<ResultMetadataType, Il2CppSystem.Object> _ResultMetadata_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__ResultMetadata_k__BackingField);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IDictionary<ResultMetadataType, Il2CppSystem.Object>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__ResultMetadata_k__BackingField)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe long _Timestamp_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__Timestamp_k__BackingField);
			return *(long*)num;
		}
		set
		{
			*(long*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__Timestamp_k__BackingField)) = value;
		}
	}

	public unsafe int _NumBits_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__NumBits_k__BackingField);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__NumBits_k__BackingField)) = value;
		}
	}

	public unsafe string Text
	{
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 50644, RefRangeEnd = 50653, XrefRangeStart = 50644, XrefRangeEnd = 50653, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Text_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return IL2CPP.Il2CppStringToManaged(intPtr2);
		}
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 42532, RefRangeEnd = 42533, XrefRangeStart = 42532, XrefRangeEnd = 42533, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_Text_Private_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe Il2CppStructArray<byte> RawBytes
	{
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 25665, RefRangeEnd = 25677, XrefRangeStart = 25665, XrefRangeEnd = 25677, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_RawBytes_Public_get_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
		}
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 86477, RefRangeEnd = 86487, XrefRangeStart = 86477, XrefRangeEnd = 86487, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_RawBytes_Private_set_Void_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe Il2CppReferenceArray<ResultPoint> ResultPoints
	{
		[CallerCount(36)]
		[CachedScanResults(RefRangeStart = 32112, RefRangeEnd = 32148, XrefRangeStart = 32112, XrefRangeEnd = 32148, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_ResultPoints_Public_get_Il2CppReferenceArray_1_ResultPoint_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ResultPoint>>(intPtr2) : null;
		}
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 32149, RefRangeEnd = 32159, XrefRangeStart = 32149, XrefRangeEnd = 32159, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_ResultPoints_Private_set_Void_Il2CppReferenceArray_1_ResultPoint_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe BarcodeFormat BarcodeFormat
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 80842, RefRangeEnd = 80843, XrefRangeStart = 80842, XrefRangeEnd = 80843, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_BarcodeFormat_Public_get_BarcodeFormat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(BarcodeFormat*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 84616, RefRangeEnd = 84621, XrefRangeStart = 84616, XrefRangeEnd = 84621, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_BarcodeFormat_Private_set_Void_BarcodeFormat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe IDictionary<ResultMetadataType, Il2CppSystem.Object> ResultMetadata
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 50643, RefRangeEnd = 50644, XrefRangeStart = 50643, XrefRangeEnd = 50644, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_ResultMetadata_Public_get_IDictionary_2_ResultMetadataType_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<IDictionary<ResultMetadataType, Il2CppSystem.Object>>(intPtr2) : null;
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_ResultMetadata_Private_set_Void_IDictionary_2_ResultMetadataType_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe long Timestamp
	{
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_Timestamp_Private_set_Void_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe int NumBits
	{
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_NumBits_Private_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	static Result()
	{
		Il2CppClassPointerStore<Result>.NativeClassPtr = IL2CPP.GetIl2CppClass("zxing.unity.dll", "ZXing", "Result");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Result>.NativeClassPtr);
		NativeFieldInfoPtr__Text_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Result>.NativeClassPtr, "<Text>k__BackingField");
		NativeFieldInfoPtr__RawBytes_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Result>.NativeClassPtr, "<RawBytes>k__BackingField");
		NativeFieldInfoPtr__ResultPoints_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Result>.NativeClassPtr, "<ResultPoints>k__BackingField");
		NativeFieldInfoPtr__BarcodeFormat_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Result>.NativeClassPtr, "<BarcodeFormat>k__BackingField");
		NativeFieldInfoPtr__ResultMetadata_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Result>.NativeClassPtr, "<ResultMetadata>k__BackingField");
		NativeFieldInfoPtr__Timestamp_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Result>.NativeClassPtr, "<Timestamp>k__BackingField");
		NativeFieldInfoPtr__NumBits_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Result>.NativeClassPtr, "<NumBits>k__BackingField");
		NativeMethodInfoPtr_get_Text_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Result>.NativeClassPtr, 100663486);
		NativeMethodInfoPtr_set_Text_Private_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Result>.NativeClassPtr, 100663487);
		NativeMethodInfoPtr_get_RawBytes_Public_get_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Result>.NativeClassPtr, 100663488);
		NativeMethodInfoPtr_set_RawBytes_Private_set_Void_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Result>.NativeClassPtr, 100663489);
		NativeMethodInfoPtr_get_ResultPoints_Public_get_Il2CppReferenceArray_1_ResultPoint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Result>.NativeClassPtr, 100663490);
		NativeMethodInfoPtr_set_ResultPoints_Private_set_Void_Il2CppReferenceArray_1_ResultPoint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Result>.NativeClassPtr, 100663491);
		NativeMethodInfoPtr_get_BarcodeFormat_Public_get_BarcodeFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Result>.NativeClassPtr, 100663492);
		NativeMethodInfoPtr_set_BarcodeFormat_Private_set_Void_BarcodeFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Result>.NativeClassPtr, 100663493);
		NativeMethodInfoPtr_get_ResultMetadata_Public_get_IDictionary_2_ResultMetadataType_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Result>.NativeClassPtr, 100663494);
		NativeMethodInfoPtr_set_ResultMetadata_Private_set_Void_IDictionary_2_ResultMetadataType_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Result>.NativeClassPtr, 100663495);
		NativeMethodInfoPtr_set_Timestamp_Private_set_Void_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Result>.NativeClassPtr, 100663496);
		NativeMethodInfoPtr_set_NumBits_Private_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Result>.NativeClassPtr, 100663497);
		NativeMethodInfoPtr__ctor_Public_Void_String_Il2CppStructArray_1_Byte_Il2CppReferenceArray_1_ResultPoint_BarcodeFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Result>.NativeClassPtr, 100663498);
		NativeMethodInfoPtr__ctor_Public_Void_String_Il2CppStructArray_1_Byte_Int32_Il2CppReferenceArray_1_ResultPoint_BarcodeFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Result>.NativeClassPtr, 100663499);
		NativeMethodInfoPtr__ctor_Public_Void_String_Il2CppStructArray_1_Byte_Int32_Il2CppReferenceArray_1_ResultPoint_BarcodeFormat_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Result>.NativeClassPtr, 100663500);
		NativeMethodInfoPtr_putMetadata_Public_Void_ResultMetadataType_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Result>.NativeClassPtr, 100663501);
		NativeMethodInfoPtr_putAllMetadata_Public_Void_IDictionary_2_ResultMetadataType_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Result>.NativeClassPtr, 100663502);
		NativeMethodInfoPtr_addResultPoints_Public_Void_Il2CppReferenceArray_1_ResultPoint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Result>.NativeClassPtr, 100663503);
		NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Result>.NativeClassPtr, 100663504);
	}

	[CallerCount(17)]
	[CachedScanResults(RefRangeStart = 1412864, RefRangeEnd = 1412881, XrefRangeStart = 1412853, XrefRangeEnd = 1412864, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Result(string text, Il2CppStructArray<byte> rawBytes, Il2CppReferenceArray<ResultPoint> resultPoints, BarcodeFormat format)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Result>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)rawBytes);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)resultPoints);
		*(BarcodeFormat**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &format;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_String_Il2CppStructArray_1_Byte_Il2CppReferenceArray_1_ResultPoint_BarcodeFormat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1412891, RefRangeEnd = 1412892, XrefRangeStart = 1412881, XrefRangeEnd = 1412891, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Result(string text, Il2CppStructArray<byte> rawBytes, int numBits, Il2CppReferenceArray<ResultPoint> resultPoints, BarcodeFormat format)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Result>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)rawBytes);
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &numBits;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)resultPoints);
		*(BarcodeFormat**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &format;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_String_Il2CppStructArray_1_Byte_Int32_Il2CppReferenceArray_1_ResultPoint_BarcodeFormat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1412892, XrefRangeEnd = 1412897, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Result(string text, Il2CppStructArray<byte> rawBytes, int numBits, Il2CppReferenceArray<ResultPoint> resultPoints, BarcodeFormat format, long timestamp)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Result>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)rawBytes);
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &numBits;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)resultPoints);
		*(BarcodeFormat**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &format;
		*(long**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &timestamp;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_String_Il2CppStructArray_1_Byte_Int32_Il2CppReferenceArray_1_ResultPoint_BarcodeFormat_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(17)]
	[CachedScanResults(RefRangeStart = 1412907, RefRangeEnd = 1412924, XrefRangeStart = 1412897, XrefRangeEnd = 1412907, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void putMetadata(ResultMetadataType type, Il2CppSystem.Object value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&type);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_putMetadata_Public_Void_ResultMetadataType_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 1412949, RefRangeEnd = 1412953, XrefRangeStart = 1412924, XrefRangeEnd = 1412949, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void putAllMetadata(IDictionary<ResultMetadataType, Il2CppSystem.Object> metadata)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)metadata);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_putAllMetadata_Public_Void_IDictionary_2_ResultMetadataType_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1412960, RefRangeEnd = 1412961, XrefRangeStart = 1412953, XrefRangeEnd = 1412960, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void addResultPoints(Il2CppReferenceArray<ResultPoint> newPoints)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)newPoints);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_addResultPoints_Public_Void_Il2CppReferenceArray_1_ResultPoint_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1412961, XrefRangeEnd = 1412963, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override string ToString()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToString_Public_Virtual_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	public Result(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
