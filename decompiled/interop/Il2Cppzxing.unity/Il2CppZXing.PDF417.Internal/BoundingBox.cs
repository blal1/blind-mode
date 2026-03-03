using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppZXing.Common;

namespace Il2CppZXing.PDF417.Internal;

public sealed class BoundingBox : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_image;

	private static readonly System.IntPtr NativeFieldInfoPtr__TopLeft_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__TopRight_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__BottomLeft_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__BottomRight_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__MinX_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__MaxX_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__MinY_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__MaxY_k__BackingField;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_TopLeft_Public_get_ResultPoint_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_TopLeft_Private_set_Void_ResultPoint_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_TopRight_Public_get_ResultPoint_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_TopRight_Private_set_Void_ResultPoint_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_BottomLeft_Public_get_ResultPoint_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_BottomLeft_Private_set_Void_ResultPoint_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_BottomRight_Public_get_ResultPoint_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_BottomRight_Private_set_Void_ResultPoint_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_MinX_Public_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_MinX_Private_set_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_MaxX_Public_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_MaxX_Private_set_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_MinY_Public_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_MinY_Private_set_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_MaxY_Public_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_MaxY_Private_set_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Create_Public_Static_BoundingBox_BitMatrix_ResultPoint_ResultPoint_ResultPoint_ResultPoint_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Create_Public_Static_BoundingBox_BoundingBox_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Private_Void_BitMatrix_ResultPoint_ResultPoint_ResultPoint_ResultPoint_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Private_Void_BoundingBox_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_merge_Internal_Static_BoundingBox_BoundingBox_BoundingBox_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_addMissingRows_Public_BoundingBox_Int32_Int32_Boolean_0;

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

	public unsafe ResultPoint _TopLeft_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__TopLeft_k__BackingField);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ResultPoint>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__TopLeft_k__BackingField)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe ResultPoint _TopRight_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__TopRight_k__BackingField);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ResultPoint>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__TopRight_k__BackingField)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe ResultPoint _BottomLeft_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__BottomLeft_k__BackingField);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ResultPoint>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__BottomLeft_k__BackingField)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe ResultPoint _BottomRight_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__BottomRight_k__BackingField);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ResultPoint>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__BottomRight_k__BackingField)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe int _MinX_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__MinX_k__BackingField);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__MinX_k__BackingField)) = value;
		}
	}

	public unsafe int _MaxX_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__MaxX_k__BackingField);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__MaxX_k__BackingField)) = value;
		}
	}

	public unsafe int _MinY_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__MinY_k__BackingField);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__MinY_k__BackingField)) = value;
		}
	}

	public unsafe int _MaxY_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__MaxY_k__BackingField);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__MaxY_k__BackingField)) = value;
		}
	}

	public unsafe ResultPoint TopLeft
	{
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 25665, RefRangeEnd = 25677, XrefRangeStart = 25665, XrefRangeEnd = 25677, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_TopLeft_Public_get_ResultPoint_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<ResultPoint>(intPtr2) : null;
		}
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 86477, RefRangeEnd = 86487, XrefRangeStart = 86477, XrefRangeEnd = 86487, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_TopLeft_Private_set_Void_ResultPoint_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe ResultPoint TopRight
	{
		[CallerCount(36)]
		[CachedScanResults(RefRangeStart = 32112, RefRangeEnd = 32148, XrefRangeStart = 32112, XrefRangeEnd = 32148, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_TopRight_Public_get_ResultPoint_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<ResultPoint>(intPtr2) : null;
		}
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 32149, RefRangeEnd = 32159, XrefRangeStart = 32149, XrefRangeEnd = 32159, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_TopRight_Private_set_Void_ResultPoint_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe ResultPoint BottomLeft
	{
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 42604, RefRangeEnd = 42610, XrefRangeStart = 42604, XrefRangeEnd = 42610, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_BottomLeft_Public_get_ResultPoint_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<ResultPoint>(intPtr2) : null;
		}
		[CallerCount(15)]
		[CachedScanResults(RefRangeStart = 41896, RefRangeEnd = 41911, XrefRangeStart = 41896, XrefRangeEnd = 41911, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_BottomLeft_Private_set_Void_ResultPoint_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe ResultPoint BottomRight
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 50643, RefRangeEnd = 50644, XrefRangeStart = 50643, XrefRangeEnd = 50644, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_BottomRight_Public_get_ResultPoint_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<ResultPoint>(intPtr2) : null;
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_BottomRight_Private_set_Void_ResultPoint_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe int MinX
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_MinX_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 202040, RefRangeEnd = 202045, XrefRangeStart = 202040, XrefRangeEnd = 202045, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_MinX_Private_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe int MaxX
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_MaxX_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 143832, RefRangeEnd = 143841, XrefRangeStart = 143832, XrefRangeEnd = 143841, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_MaxX_Private_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe int MinY
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_MinY_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_MinY_Private_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe int MaxY
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_MaxY_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_MaxY_Private_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	static BoundingBox()
	{
		Il2CppClassPointerStore<BoundingBox>.NativeClassPtr = IL2CPP.GetIl2CppClass("zxing.unity.dll", "ZXing.PDF417.Internal", "BoundingBox");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BoundingBox>.NativeClassPtr);
		NativeFieldInfoPtr_image = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoundingBox>.NativeClassPtr, "image");
		NativeFieldInfoPtr__TopLeft_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoundingBox>.NativeClassPtr, "<TopLeft>k__BackingField");
		NativeFieldInfoPtr__TopRight_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoundingBox>.NativeClassPtr, "<TopRight>k__BackingField");
		NativeFieldInfoPtr__BottomLeft_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoundingBox>.NativeClassPtr, "<BottomLeft>k__BackingField");
		NativeFieldInfoPtr__BottomRight_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoundingBox>.NativeClassPtr, "<BottomRight>k__BackingField");
		NativeFieldInfoPtr__MinX_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoundingBox>.NativeClassPtr, "<MinX>k__BackingField");
		NativeFieldInfoPtr__MaxX_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoundingBox>.NativeClassPtr, "<MaxX>k__BackingField");
		NativeFieldInfoPtr__MinY_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoundingBox>.NativeClassPtr, "<MinY>k__BackingField");
		NativeFieldInfoPtr__MaxY_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoundingBox>.NativeClassPtr, "<MaxY>k__BackingField");
		NativeMethodInfoPtr_get_TopLeft_Public_get_ResultPoint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoundingBox>.NativeClassPtr, 100663822);
		NativeMethodInfoPtr_set_TopLeft_Private_set_Void_ResultPoint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoundingBox>.NativeClassPtr, 100663823);
		NativeMethodInfoPtr_get_TopRight_Public_get_ResultPoint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoundingBox>.NativeClassPtr, 100663824);
		NativeMethodInfoPtr_set_TopRight_Private_set_Void_ResultPoint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoundingBox>.NativeClassPtr, 100663825);
		NativeMethodInfoPtr_get_BottomLeft_Public_get_ResultPoint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoundingBox>.NativeClassPtr, 100663826);
		NativeMethodInfoPtr_set_BottomLeft_Private_set_Void_ResultPoint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoundingBox>.NativeClassPtr, 100663827);
		NativeMethodInfoPtr_get_BottomRight_Public_get_ResultPoint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoundingBox>.NativeClassPtr, 100663828);
		NativeMethodInfoPtr_set_BottomRight_Private_set_Void_ResultPoint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoundingBox>.NativeClassPtr, 100663829);
		NativeMethodInfoPtr_get_MinX_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoundingBox>.NativeClassPtr, 100663830);
		NativeMethodInfoPtr_set_MinX_Private_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoundingBox>.NativeClassPtr, 100663831);
		NativeMethodInfoPtr_get_MaxX_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoundingBox>.NativeClassPtr, 100663832);
		NativeMethodInfoPtr_set_MaxX_Private_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoundingBox>.NativeClassPtr, 100663833);
		NativeMethodInfoPtr_get_MinY_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoundingBox>.NativeClassPtr, 100663834);
		NativeMethodInfoPtr_set_MinY_Private_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoundingBox>.NativeClassPtr, 100663835);
		NativeMethodInfoPtr_get_MaxY_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoundingBox>.NativeClassPtr, 100663836);
		NativeMethodInfoPtr_set_MaxY_Private_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoundingBox>.NativeClassPtr, 100663837);
		NativeMethodInfoPtr_Create_Public_Static_BoundingBox_BitMatrix_ResultPoint_ResultPoint_ResultPoint_ResultPoint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoundingBox>.NativeClassPtr, 100663838);
		NativeMethodInfoPtr_Create_Public_Static_BoundingBox_BoundingBox_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoundingBox>.NativeClassPtr, 100663839);
		NativeMethodInfoPtr__ctor_Private_Void_BitMatrix_ResultPoint_ResultPoint_ResultPoint_ResultPoint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoundingBox>.NativeClassPtr, 100663840);
		NativeMethodInfoPtr__ctor_Private_Void_BoundingBox_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoundingBox>.NativeClassPtr, 100663841);
		NativeMethodInfoPtr_merge_Internal_Static_BoundingBox_BoundingBox_BoundingBox_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoundingBox>.NativeClassPtr, 100663842);
		NativeMethodInfoPtr_addMissingRows_Public_BoundingBox_Int32_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoundingBox>.NativeClassPtr, 100663843);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1418122, XrefRangeEnd = 1418128, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static BoundingBox Create(BitMatrix image, ResultPoint topLeft, ResultPoint bottomLeft, ResultPoint topRight, ResultPoint bottomRight)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)image);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)topLeft);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)bottomLeft);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)topRight);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)bottomRight);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Create_Public_Static_BoundingBox_BitMatrix_ResultPoint_ResultPoint_ResultPoint_ResultPoint_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<BoundingBox>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1418128, XrefRangeEnd = 1418137, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static BoundingBox Create(BoundingBox box)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)box);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Create_Public_Static_BoundingBox_BoundingBox_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<BoundingBox>(intPtr2) : null;
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 1418164, RefRangeEnd = 1418169, XrefRangeStart = 1418137, XrefRangeEnd = 1418164, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe BoundingBox(BitMatrix image, ResultPoint topLeft, ResultPoint bottomLeft, ResultPoint topRight, ResultPoint bottomRight)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BoundingBox>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)image);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)topLeft);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)bottomLeft);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)topRight);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)bottomRight);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Private_Void_BitMatrix_ResultPoint_ResultPoint_ResultPoint_ResultPoint_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1418169, XrefRangeEnd = 1418175, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe BoundingBox(BoundingBox boundingBox)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BoundingBox>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)boundingBox);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Private_Void_BoundingBox_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1418175, XrefRangeEnd = 1418179, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static BoundingBox merge(BoundingBox leftBox, BoundingBox rightBox)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)leftBox);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)rightBox);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_merge_Internal_Static_BoundingBox_BoundingBox_BoundingBox_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<BoundingBox>(intPtr2) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1418191, RefRangeEnd = 1418192, XrefRangeStart = 1418179, XrefRangeEnd = 1418191, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe BoundingBox addMissingRows(int missingStartRows, int missingEndRows, bool isLeft)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&missingStartRows);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &missingEndRows;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &isLeft;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_addMissingRows_Public_BoundingBox_Int32_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<BoundingBox>(intPtr2) : null;
	}

	public BoundingBox(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
