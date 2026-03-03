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

namespace Il2CppZXing.QrCode.Internal;

public class FinderPatternFinder : Il2CppSystem.Object
{
	public sealed class EstimatedModuleComparator : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeMethodInfoPtr_Compare_Public_Virtual_Final_New_Int32_FinderPattern_FinderPattern_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		static EstimatedModuleComparator()
		{
			Il2CppClassPointerStore<EstimatedModuleComparator>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FinderPatternFinder>.NativeClassPtr, "EstimatedModuleComparator");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EstimatedModuleComparator>.NativeClassPtr);
			NativeMethodInfoPtr_Compare_Public_Virtual_Final_New_Int32_FinderPattern_FinderPattern_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EstimatedModuleComparator>.NativeClassPtr, 100663690);
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EstimatedModuleComparator>.NativeClassPtr, 100663691);
		}

		[CallerCount(0)]
		public unsafe virtual int Compare(FinderPattern center1, FinderPattern center2)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)center1);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)center2);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Compare_Public_Virtual_Final_New_Int32_FinderPattern_FinderPattern_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		[CallerCount(1950)]
		[CachedScanResults(RefRangeStart = 20036, RefRangeEnd = 21986, XrefRangeStart = 20036, XrefRangeEnd = 21986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EstimatedModuleComparator()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EstimatedModuleComparator>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		public EstimatedModuleComparator(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_moduleComparator;

	private static readonly System.IntPtr NativeFieldInfoPtr_image;

	private static readonly System.IntPtr NativeFieldInfoPtr_possibleCenters;

	private static readonly System.IntPtr NativeFieldInfoPtr_hasSkipped;

	private static readonly System.IntPtr NativeFieldInfoPtr_crossCheckStateCount;

	private static readonly System.IntPtr NativeFieldInfoPtr_resultPointCallback;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_BitMatrix_ResultPointCallback_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_find_Internal_Virtual_New_FinderPatternInfo_IDictionary_2_DecodeHintType_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_centerFromEnd_Private_Static_Nullable_1_Single_Il2CppStructArray_1_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_foundPatternCross_FamOrAssem_Static_Boolean_Il2CppStructArray_1_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_foundPatternDiagonal_Protected_Static_Boolean_Il2CppStructArray_1_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_CrossCheckStateCount_Private_get_Il2CppStructArray_1_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_doClearCounts_Protected_Static_Void_Il2CppStructArray_1_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_doShiftCounts2_Protected_Static_Void_Il2CppStructArray_1_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_crossCheckDiagonal_Private_Boolean_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_crossCheckVertical_Private_Nullable_1_Single_Int32_Int32_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_crossCheckHorizontal_Private_Nullable_1_Single_Int32_Int32_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_handlePossibleCenter_Protected_Boolean_Il2CppStructArray_1_Int32_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_findRowSkip_Private_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_haveMultiplyConfirmedCenters_Private_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_squaredDistance_Private_Static_Double_FinderPattern_FinderPattern_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_selectBestPatterns_Private_Il2CppReferenceArray_1_FinderPattern_0;

	public unsafe static EstimatedModuleComparator moduleComparator
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_moduleComparator, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<EstimatedModuleComparator>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_moduleComparator, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe BitMatrix image
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_image);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<BitMatrix>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_image)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe List<FinderPattern> possibleCenters
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_possibleCenters);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<FinderPattern>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_possibleCenters)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe bool hasSkipped
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hasSkipped);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hasSkipped)) = value;
		}
	}

	public unsafe Il2CppStructArray<int> crossCheckStateCount
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_crossCheckStateCount);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_crossCheckStateCount)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe ResultPointCallback resultPointCallback
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_resultPointCallback);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ResultPointCallback>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_resultPointCallback)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe Il2CppStructArray<int> CrossCheckStateCount
	{
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1416823, RefRangeEnd = 1416826, XrefRangeStart = 1416817, XrefRangeEnd = 1416823, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_CrossCheckStateCount_Private_get_Il2CppStructArray_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
		}
	}

	static FinderPatternFinder()
	{
		Il2CppClassPointerStore<FinderPatternFinder>.NativeClassPtr = IL2CPP.GetIl2CppClass("zxing.unity.dll", "ZXing.QrCode.Internal", "FinderPatternFinder");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FinderPatternFinder>.NativeClassPtr);
		NativeFieldInfoPtr_moduleComparator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FinderPatternFinder>.NativeClassPtr, "moduleComparator");
		NativeFieldInfoPtr_image = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FinderPatternFinder>.NativeClassPtr, "image");
		NativeFieldInfoPtr_possibleCenters = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FinderPatternFinder>.NativeClassPtr, "possibleCenters");
		NativeFieldInfoPtr_hasSkipped = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FinderPatternFinder>.NativeClassPtr, "hasSkipped");
		NativeFieldInfoPtr_crossCheckStateCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FinderPatternFinder>.NativeClassPtr, "crossCheckStateCount");
		NativeFieldInfoPtr_resultPointCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FinderPatternFinder>.NativeClassPtr, "resultPointCallback");
		NativeMethodInfoPtr__ctor_Public_Void_BitMatrix_ResultPointCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FinderPatternFinder>.NativeClassPtr, 100663673);
		NativeMethodInfoPtr_find_Internal_Virtual_New_FinderPatternInfo_IDictionary_2_DecodeHintType_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FinderPatternFinder>.NativeClassPtr, 100663674);
		NativeMethodInfoPtr_centerFromEnd_Private_Static_Nullable_1_Single_Il2CppStructArray_1_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FinderPatternFinder>.NativeClassPtr, 100663675);
		NativeMethodInfoPtr_foundPatternCross_FamOrAssem_Static_Boolean_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FinderPatternFinder>.NativeClassPtr, 100663676);
		NativeMethodInfoPtr_foundPatternDiagonal_Protected_Static_Boolean_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FinderPatternFinder>.NativeClassPtr, 100663677);
		NativeMethodInfoPtr_get_CrossCheckStateCount_Private_get_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FinderPatternFinder>.NativeClassPtr, 100663678);
		NativeMethodInfoPtr_doClearCounts_Protected_Static_Void_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FinderPatternFinder>.NativeClassPtr, 100663679);
		NativeMethodInfoPtr_doShiftCounts2_Protected_Static_Void_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FinderPatternFinder>.NativeClassPtr, 100663680);
		NativeMethodInfoPtr_crossCheckDiagonal_Private_Boolean_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FinderPatternFinder>.NativeClassPtr, 100663681);
		NativeMethodInfoPtr_crossCheckVertical_Private_Nullable_1_Single_Int32_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FinderPatternFinder>.NativeClassPtr, 100663682);
		NativeMethodInfoPtr_crossCheckHorizontal_Private_Nullable_1_Single_Int32_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FinderPatternFinder>.NativeClassPtr, 100663683);
		NativeMethodInfoPtr_handlePossibleCenter_Protected_Boolean_Il2CppStructArray_1_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FinderPatternFinder>.NativeClassPtr, 100663684);
		NativeMethodInfoPtr_findRowSkip_Private_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FinderPatternFinder>.NativeClassPtr, 100663685);
		NativeMethodInfoPtr_haveMultiplyConfirmedCenters_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FinderPatternFinder>.NativeClassPtr, 100663686);
		NativeMethodInfoPtr_squaredDistance_Private_Static_Double_FinderPattern_FinderPattern_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FinderPatternFinder>.NativeClassPtr, 100663687);
		NativeMethodInfoPtr_selectBestPatterns_Private_Il2CppReferenceArray_1_FinderPattern_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FinderPatternFinder>.NativeClassPtr, 100663688);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1416726, XrefRangeEnd = 1416740, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe FinderPatternFinder(BitMatrix image, ResultPointCallback resultPointCallback)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FinderPatternFinder>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)image);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)resultPointCallback);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_BitMatrix_ResultPointCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1416740, XrefRangeEnd = 1416788, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual FinderPatternInfo find(IDictionary<DecodeHintType, Il2CppSystem.Object> hints)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)hints);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_find_Internal_Virtual_New_FinderPatternInfo_IDictionary_2_DecodeHintType_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<FinderPatternInfo>(intPtr2) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1416791, RefRangeEnd = 1416792, XrefRangeStart = 1416788, XrefRangeEnd = 1416791, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppSystem.Nullable<float> centerFromEnd(Il2CppStructArray<int> stateCount, int end)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)stateCount);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &end;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_centerFromEnd_Private_Static_Nullable_1_Single_Il2CppStructArray_1_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return new Il2CppSystem.Nullable<float>(pointer);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1416803, RefRangeEnd = 1416805, XrefRangeStart = 1416792, XrefRangeEnd = 1416803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool foundPatternCross(Il2CppStructArray<int> stateCount)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)stateCount);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_foundPatternCross_FamOrAssem_Static_Boolean_Il2CppStructArray_1_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1416816, RefRangeEnd = 1416817, XrefRangeStart = 1416805, XrefRangeEnd = 1416816, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool foundPatternDiagonal(Il2CppStructArray<int> stateCount)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)stateCount);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_foundPatternDiagonal_Protected_Static_Boolean_Il2CppStructArray_1_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1416829, RefRangeEnd = 1416830, XrefRangeStart = 1416826, XrefRangeEnd = 1416829, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void doClearCounts(Il2CppStructArray<int> counts)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)counts);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_doClearCounts_Protected_Static_Void_Il2CppStructArray_1_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	public unsafe static void doShiftCounts2(Il2CppStructArray<int> stateCount)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)stateCount);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_doShiftCounts2_Protected_Static_Void_Il2CppStructArray_1_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1416843, RefRangeEnd = 1416844, XrefRangeStart = 1416830, XrefRangeEnd = 1416843, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool crossCheckDiagonal(int centerI, int centerJ)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&centerI);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &centerJ;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_crossCheckDiagonal_Private_Boolean_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1416848, RefRangeEnd = 1416849, XrefRangeStart = 1416844, XrefRangeEnd = 1416848, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Il2CppSystem.Nullable<float> crossCheckVertical(int startI, int centerJ, int maxCount, int originalStateCountTotal)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&startI);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &centerJ;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &maxCount;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &originalStateCountTotal;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_crossCheckVertical_Private_Nullable_1_Single_Int32_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return new Il2CppSystem.Nullable<float>(pointer);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1416853, RefRangeEnd = 1416854, XrefRangeStart = 1416849, XrefRangeEnd = 1416853, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Il2CppSystem.Nullable<float> crossCheckHorizontal(int startJ, int centerI, int maxCount, int originalStateCountTotal)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&startJ);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &centerI;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &maxCount;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &originalStateCountTotal;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_crossCheckHorizontal_Private_Nullable_1_Single_Int32_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return new Il2CppSystem.Nullable<float>(pointer);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1416914, RefRangeEnd = 1416916, XrefRangeStart = 1416854, XrefRangeEnd = 1416914, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool handlePossibleCenter(Il2CppStructArray<int> stateCount, int i, int j)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)stateCount);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &i;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &j;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_handlePossibleCenter_Protected_Boolean_Il2CppStructArray_1_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1416930, RefRangeEnd = 1416931, XrefRangeStart = 1416916, XrefRangeEnd = 1416930, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int findRowSkip()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_findRowSkip_Private_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1416952, RefRangeEnd = 1416954, XrefRangeStart = 1416931, XrefRangeEnd = 1416952, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool haveMultiplyConfirmedCenters()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_haveMultiplyConfirmedCenters_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1416954, RefRangeEnd = 1416957, XrefRangeStart = 1416954, XrefRangeEnd = 1416954, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static double squaredDistance(FinderPattern a, FinderPattern b)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)a);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)b);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_squaredDistance_Private_Static_Double_FinderPattern_FinderPattern_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(double*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1416994, RefRangeEnd = 1416995, XrefRangeStart = 1416957, XrefRangeEnd = 1416994, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Il2CppReferenceArray<FinderPattern> selectBestPatterns()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_selectBestPatterns_Private_Il2CppReferenceArray_1_FinderPattern_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<FinderPattern>>(intPtr2) : null;
	}

	public FinderPatternFinder(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
