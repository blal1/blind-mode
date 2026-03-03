using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppZXing.Common;

namespace Il2CppZXing.Aztec.Internal;

public sealed class Detector : Il2CppSystem.Object
{
	public sealed class Point : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr__X_k__BackingField;

		private static readonly System.IntPtr NativeFieldInfoPtr__Y_k__BackingField;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_X_Public_get_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_set_X_Private_set_Void_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_Y_Public_get_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_set_Y_Private_set_Void_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_toResultPoint_Public_ResultPoint_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Int32_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		public unsafe int _X_k__BackingField
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__X_k__BackingField);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__X_k__BackingField)) = value;
			}
		}

		public unsafe int _Y_k__BackingField
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__Y_k__BackingField);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__Y_k__BackingField)) = value;
			}
		}

		public unsafe int X
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 50668, RefRangeEnd = 50669, XrefRangeStart = 50668, XrefRangeEnd = 50669, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_X_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
			}
			[CallerCount(8)]
			[CachedScanResults(RefRangeStart = 86468, RefRangeEnd = 86476, XrefRangeStart = 86468, XrefRangeEnd = 86476, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = stackalloc System.IntPtr[1];
				*ptr = (nint)(&value);
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_X_Private_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
			}
		}

		public unsafe int Y
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 82717, RefRangeEnd = 82718, XrefRangeStart = 82717, XrefRangeEnd = 82718, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Y_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
			}
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 164133, RefRangeEnd = 164138, XrefRangeStart = 164133, XrefRangeEnd = 164138, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = stackalloc System.IntPtr[1];
				*ptr = (nint)(&value);
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_Y_Private_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
			}
		}

		static Point()
		{
			Il2CppClassPointerStore<Point>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Detector>.NativeClassPtr, "Point");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Point>.NativeClassPtr);
			NativeFieldInfoPtr__X_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Point>.NativeClassPtr, "<X>k__BackingField");
			NativeFieldInfoPtr__Y_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Point>.NativeClassPtr, "<Y>k__BackingField");
			NativeMethodInfoPtr_get_X_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Point>.NativeClassPtr, 100664888);
			NativeMethodInfoPtr_set_X_Private_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Point>.NativeClassPtr, 100664889);
			NativeMethodInfoPtr_get_Y_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Point>.NativeClassPtr, 100664890);
			NativeMethodInfoPtr_set_Y_Private_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Point>.NativeClassPtr, 100664891);
			NativeMethodInfoPtr_toResultPoint_Public_ResultPoint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Point>.NativeClassPtr, 100664892);
			NativeMethodInfoPtr__ctor_Internal_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Point>.NativeClassPtr, 100664893);
			NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Point>.NativeClassPtr, 100664894);
		}

		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 1430224, RefRangeEnd = 1430232, XrefRangeStart = 1430220, XrefRangeEnd = 1430224, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ResultPoint toResultPoint()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_toResultPoint_Public_ResultPoint_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<ResultPoint>(intPtr2) : null;
		}

		[CallerCount(296)]
		[CachedScanResults(RefRangeStart = 207370, RefRangeEnd = 207666, XrefRangeStart = 207370, XrefRangeEnd = 207666, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Point(int x, int y)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Point>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = (nint)(&x);
			*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &y;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Internal_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1430232, XrefRangeEnd = 1430249, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToString_Public_Virtual_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return IL2CPP.Il2CppStringToManaged(intPtr2);
		}

		public Point(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_EXPECTED_CORNER_BITS;

	private static readonly System.IntPtr NativeFieldInfoPtr_image;

	private static readonly System.IntPtr NativeFieldInfoPtr_compact;

	private static readonly System.IntPtr NativeFieldInfoPtr_nbLayers;

	private static readonly System.IntPtr NativeFieldInfoPtr_nbDataBlocks;

	private static readonly System.IntPtr NativeFieldInfoPtr_nbCenterLayers;

	private static readonly System.IntPtr NativeFieldInfoPtr_shift;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_BitMatrix_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_detect_Public_AztecDetectorResult_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_extractParameters_Private_Boolean_Il2CppReferenceArray_1_ResultPoint_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_getRotation_Private_Static_Int32_Il2CppStructArray_1_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_getCorrectedParameterData_Private_Static_Int32_Int64_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_getBullsEyeCorners_Private_Il2CppReferenceArray_1_ResultPoint_Point_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_getMatrixCenter_Private_Point_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_getMatrixCornerPoints_Private_Il2CppReferenceArray_1_ResultPoint_Il2CppReferenceArray_1_ResultPoint_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_sampleGrid_Private_BitMatrix_BitMatrix_ResultPoint_ResultPoint_ResultPoint_ResultPoint_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_sampleLine_Private_Int32_ResultPoint_ResultPoint_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_isWhiteOrBlackRectangle_Private_Boolean_Point_Point_Point_Point_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_getColor_Private_Int32_Point_Point_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_getFirstDifferent_Private_Point_Point_Boolean_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_expandSquare_Private_Static_Il2CppReferenceArray_1_ResultPoint_Il2CppReferenceArray_1_ResultPoint_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_isValid_Private_Boolean_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_isValid_Private_Boolean_ResultPoint_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_distance_Private_Static_Single_Point_Point_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_distance_Private_Static_Single_ResultPoint_ResultPoint_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_getDimension_Private_Int32_0;

	public unsafe static Il2CppStructArray<int> EXPECTED_CORNER_BITS
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_EXPECTED_CORNER_BITS, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_EXPECTED_CORNER_BITS, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
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

	public unsafe bool compact
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_compact);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_compact)) = value;
		}
	}

	public unsafe int nbLayers
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_nbLayers);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_nbLayers)) = value;
		}
	}

	public unsafe int nbDataBlocks
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_nbDataBlocks);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_nbDataBlocks)) = value;
		}
	}

	public unsafe int nbCenterLayers
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_nbCenterLayers);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_nbCenterLayers)) = value;
		}
	}

	public unsafe int shift
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_shift);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_shift)) = value;
		}
	}

	static Detector()
	{
		Il2CppClassPointerStore<Detector>.NativeClassPtr = IL2CPP.GetIl2CppClass("zxing.unity.dll", "ZXing.Aztec.Internal", "Detector");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Detector>.NativeClassPtr);
		NativeFieldInfoPtr_EXPECTED_CORNER_BITS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Detector>.NativeClassPtr, "EXPECTED_CORNER_BITS");
		NativeFieldInfoPtr_image = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Detector>.NativeClassPtr, "image");
		NativeFieldInfoPtr_compact = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Detector>.NativeClassPtr, "compact");
		NativeFieldInfoPtr_nbLayers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Detector>.NativeClassPtr, "nbLayers");
		NativeFieldInfoPtr_nbDataBlocks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Detector>.NativeClassPtr, "nbDataBlocks");
		NativeFieldInfoPtr_nbCenterLayers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Detector>.NativeClassPtr, "nbCenterLayers");
		NativeFieldInfoPtr_shift = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Detector>.NativeClassPtr, "shift");
		NativeMethodInfoPtr__ctor_Public_Void_BitMatrix_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Detector>.NativeClassPtr, 100664868);
		NativeMethodInfoPtr_detect_Public_AztecDetectorResult_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Detector>.NativeClassPtr, 100664869);
		NativeMethodInfoPtr_extractParameters_Private_Boolean_Il2CppReferenceArray_1_ResultPoint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Detector>.NativeClassPtr, 100664870);
		NativeMethodInfoPtr_getRotation_Private_Static_Int32_Il2CppStructArray_1_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Detector>.NativeClassPtr, 100664871);
		NativeMethodInfoPtr_getCorrectedParameterData_Private_Static_Int32_Int64_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Detector>.NativeClassPtr, 100664872);
		NativeMethodInfoPtr_getBullsEyeCorners_Private_Il2CppReferenceArray_1_ResultPoint_Point_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Detector>.NativeClassPtr, 100664873);
		NativeMethodInfoPtr_getMatrixCenter_Private_Point_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Detector>.NativeClassPtr, 100664874);
		NativeMethodInfoPtr_getMatrixCornerPoints_Private_Il2CppReferenceArray_1_ResultPoint_Il2CppReferenceArray_1_ResultPoint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Detector>.NativeClassPtr, 100664875);
		NativeMethodInfoPtr_sampleGrid_Private_BitMatrix_BitMatrix_ResultPoint_ResultPoint_ResultPoint_ResultPoint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Detector>.NativeClassPtr, 100664876);
		NativeMethodInfoPtr_sampleLine_Private_Int32_ResultPoint_ResultPoint_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Detector>.NativeClassPtr, 100664877);
		NativeMethodInfoPtr_isWhiteOrBlackRectangle_Private_Boolean_Point_Point_Point_Point_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Detector>.NativeClassPtr, 100664878);
		NativeMethodInfoPtr_getColor_Private_Int32_Point_Point_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Detector>.NativeClassPtr, 100664879);
		NativeMethodInfoPtr_getFirstDifferent_Private_Point_Point_Boolean_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Detector>.NativeClassPtr, 100664880);
		NativeMethodInfoPtr_expandSquare_Private_Static_Il2CppReferenceArray_1_ResultPoint_Il2CppReferenceArray_1_ResultPoint_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Detector>.NativeClassPtr, 100664881);
		NativeMethodInfoPtr_isValid_Private_Boolean_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Detector>.NativeClassPtr, 100664882);
		NativeMethodInfoPtr_isValid_Private_Boolean_ResultPoint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Detector>.NativeClassPtr, 100664883);
		NativeMethodInfoPtr_distance_Private_Static_Single_Point_Point_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Detector>.NativeClassPtr, 100664884);
		NativeMethodInfoPtr_distance_Private_Static_Single_ResultPoint_ResultPoint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Detector>.NativeClassPtr, 100664885);
		NativeMethodInfoPtr_getDimension_Private_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Detector>.NativeClassPtr, 100664886);
	}

	[CallerCount(215)]
	[CachedScanResults(RefRangeStart = 79185, RefRangeEnd = 79400, XrefRangeStart = 79185, XrefRangeEnd = 79400, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Detector(BitMatrix image)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Detector>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)image);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_BitMatrix_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1430270, RefRangeEnd = 1430272, XrefRangeStart = 1430249, XrefRangeEnd = 1430270, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AztecDetectorResult detect(bool isMirror)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&isMirror);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_detect_Public_AztecDetectorResult_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<AztecDetectorResult>(intPtr2) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1430292, RefRangeEnd = 1430293, XrefRangeStart = 1430272, XrefRangeEnd = 1430292, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool extractParameters(Il2CppReferenceArray<ResultPoint> bullsEyeCorners)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)bullsEyeCorners);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_extractParameters_Private_Boolean_Il2CppReferenceArray_1_ResultPoint_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1430293, XrefRangeEnd = 1430299, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int getRotation(Il2CppStructArray<int> sides, int length)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)sides);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &length;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_getRotation_Private_Static_Int32_Il2CppStructArray_1_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1430299, XrefRangeEnd = 1430312, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int getCorrectedParameterData(long parameterData, bool compact)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&parameterData);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &compact;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_getCorrectedParameterData_Private_Static_Int32_Int64_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1430325, RefRangeEnd = 1430326, XrefRangeStart = 1430312, XrefRangeEnd = 1430325, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Il2CppReferenceArray<ResultPoint> getBullsEyeCorners(Point pCenter)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)pCenter);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_getBullsEyeCorners_Private_Il2CppReferenceArray_1_ResultPoint_Point_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ResultPoint>>(intPtr2) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1430394, RefRangeEnd = 1430395, XrefRangeStart = 1430326, XrefRangeEnd = 1430394, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Point getMatrixCenter()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_getMatrixCenter_Private_Point_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Point>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1430395, XrefRangeEnd = 1430401, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Il2CppReferenceArray<ResultPoint> getMatrixCornerPoints(Il2CppReferenceArray<ResultPoint> bullsEyeCorners)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)bullsEyeCorners);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_getMatrixCornerPoints_Private_Il2CppReferenceArray_1_ResultPoint_Il2CppReferenceArray_1_ResultPoint_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ResultPoint>>(intPtr2) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1430410, RefRangeEnd = 1430411, XrefRangeStart = 1430401, XrefRangeEnd = 1430410, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe BitMatrix sampleGrid(BitMatrix image, ResultPoint topLeft, ResultPoint topRight, ResultPoint bottomRight, ResultPoint bottomLeft)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)image);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)topLeft);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)topRight);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)bottomRight);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)bottomLeft);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_sampleGrid_Private_BitMatrix_BitMatrix_ResultPoint_ResultPoint_ResultPoint_ResultPoint_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<BitMatrix>(intPtr2) : null;
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 1430422, RefRangeEnd = 1430426, XrefRangeStart = 1430411, XrefRangeEnd = 1430422, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int sampleLine(ResultPoint p1, ResultPoint p2, int size)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)p1);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)p2);
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &size;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_sampleLine_Private_Int32_ResultPoint_ResultPoint_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1430443, RefRangeEnd = 1430444, XrefRangeStart = 1430426, XrefRangeEnd = 1430443, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool isWhiteOrBlackRectangle(Point p1, Point p2, Point p3, Point p4)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)p1);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)p2);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)p3);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)p4);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_isWhiteOrBlackRectangle_Private_Boolean_Point_Point_Point_Point_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 1430464, RefRangeEnd = 1430468, XrefRangeStart = 1430444, XrefRangeEnd = 1430464, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int getColor(Point p1, Point p2)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)p1);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)p2);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_getColor_Private_Int32_Point_Point_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(12)]
	[CachedScanResults(RefRangeStart = 1430477, RefRangeEnd = 1430489, XrefRangeStart = 1430468, XrefRangeEnd = 1430477, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Point getFirstDifferent(Point init, bool color, int dx, int dy)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)init);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &color;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &dx;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &dy;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_getFirstDifferent_Private_Point_Point_Boolean_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Point>(intPtr2) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1430513, RefRangeEnd = 1430515, XrefRangeStart = 1430489, XrefRangeEnd = 1430513, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppReferenceArray<ResultPoint> expandSquare(Il2CppReferenceArray<ResultPoint> cornerPoints, int oldSide, int newSide)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cornerPoints);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &oldSide;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &newSide;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_expandSquare_Private_Static_Il2CppReferenceArray_1_ResultPoint_Il2CppReferenceArray_1_ResultPoint_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ResultPoint>>(intPtr2) : null;
	}

	[CallerCount(0)]
	public unsafe bool isValid(int x, int y)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&x);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &y;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_isValid_Private_Boolean_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 1430519, RefRangeEnd = 1430523, XrefRangeStart = 1430515, XrefRangeEnd = 1430519, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool isValid(ResultPoint point)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)point);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_isValid_Private_Boolean_ResultPoint_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1430528, RefRangeEnd = 1430530, XrefRangeStart = 1430523, XrefRangeEnd = 1430528, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float distance(Point a, Point b)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)a);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)b);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_distance_Private_Static_Single_Point_Point_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1430530, XrefRangeEnd = 1430531, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float distance(ResultPoint a, ResultPoint b)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)a);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)b);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_distance_Private_Static_Single_ResultPoint_ResultPoint_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe int getDimension()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_getDimension_Private_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	public Detector(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
