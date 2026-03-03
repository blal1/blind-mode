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

namespace Il2CppZXing.PDF417.Internal;

public sealed class PDF417DetectorResult : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr__Bits_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__Points_k__BackingField;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Bits_Public_get_BitMatrix_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_Bits_Private_set_Void_BitMatrix_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Points_Public_get_List_1_Il2CppReferenceArray_1_ResultPoint_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_Points_Private_set_Void_List_1_Il2CppReferenceArray_1_ResultPoint_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_BitMatrix_List_1_Il2CppReferenceArray_1_ResultPoint_0;

	public unsafe BitMatrix _Bits_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__Bits_k__BackingField);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<BitMatrix>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__Bits_k__BackingField)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe List<Il2CppReferenceArray<ResultPoint>> _Points_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__Points_k__BackingField);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<Il2CppReferenceArray<ResultPoint>>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__Points_k__BackingField)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe BitMatrix Bits
	{
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 50644, RefRangeEnd = 50653, XrefRangeStart = 50644, XrefRangeEnd = 50653, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Bits_Public_get_BitMatrix_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<BitMatrix>(intPtr2) : null;
		}
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 42532, RefRangeEnd = 42533, XrefRangeStart = 42532, XrefRangeEnd = 42533, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_Bits_Private_set_Void_BitMatrix_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe List<Il2CppReferenceArray<ResultPoint>> Points
	{
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 25665, RefRangeEnd = 25677, XrefRangeStart = 25665, XrefRangeEnd = 25677, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Points_Public_get_List_1_Il2CppReferenceArray_1_ResultPoint_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<Il2CppReferenceArray<ResultPoint>>>(intPtr2) : null;
		}
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 86477, RefRangeEnd = 86487, XrefRangeStart = 86477, XrefRangeEnd = 86487, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_Points_Private_set_Void_List_1_Il2CppReferenceArray_1_ResultPoint_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	static PDF417DetectorResult()
	{
		Il2CppClassPointerStore<PDF417DetectorResult>.NativeClassPtr = IL2CPP.GetIl2CppClass("zxing.unity.dll", "ZXing.PDF417.Internal", "PDF417DetectorResult");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PDF417DetectorResult>.NativeClassPtr);
		NativeFieldInfoPtr__Bits_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PDF417DetectorResult>.NativeClassPtr, "<Bits>k__BackingField");
		NativeFieldInfoPtr__Points_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PDF417DetectorResult>.NativeClassPtr, "<Points>k__BackingField");
		NativeMethodInfoPtr_get_Bits_Public_get_BitMatrix_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PDF417DetectorResult>.NativeClassPtr, 100663951);
		NativeMethodInfoPtr_set_Bits_Private_set_Void_BitMatrix_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PDF417DetectorResult>.NativeClassPtr, 100663952);
		NativeMethodInfoPtr_get_Points_Public_get_List_1_Il2CppReferenceArray_1_ResultPoint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PDF417DetectorResult>.NativeClassPtr, 100663953);
		NativeMethodInfoPtr_set_Points_Private_set_Void_List_1_Il2CppReferenceArray_1_ResultPoint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PDF417DetectorResult>.NativeClassPtr, 100663954);
		NativeMethodInfoPtr__ctor_Public_Void_BitMatrix_List_1_Il2CppReferenceArray_1_ResultPoint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PDF417DetectorResult>.NativeClassPtr, 100663955);
	}

	[CallerCount(138)]
	[CachedScanResults(RefRangeStart = 141598, RefRangeEnd = 141736, XrefRangeStart = 141598, XrefRangeEnd = 141736, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe PDF417DetectorResult(BitMatrix bits, List<Il2CppReferenceArray<ResultPoint>> points)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PDF417DetectorResult>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)bits);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)points);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_BitMatrix_List_1_Il2CppReferenceArray_1_ResultPoint_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public PDF417DetectorResult(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
