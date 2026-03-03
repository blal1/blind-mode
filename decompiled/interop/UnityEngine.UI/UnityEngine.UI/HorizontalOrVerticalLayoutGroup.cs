using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace UnityEngine.UI;

public class HorizontalOrVerticalLayoutGroup : LayoutGroup
{
	private static readonly IntPtr NativeFieldInfoPtr_m_Spacing;

	private static readonly IntPtr NativeFieldInfoPtr_m_ChildForceExpandWidth;

	private static readonly IntPtr NativeFieldInfoPtr_m_ChildForceExpandHeight;

	private static readonly IntPtr NativeFieldInfoPtr_m_ChildControlWidth;

	private static readonly IntPtr NativeFieldInfoPtr_m_ChildControlHeight;

	private static readonly IntPtr NativeFieldInfoPtr_m_ChildScaleWidth;

	private static readonly IntPtr NativeFieldInfoPtr_m_ChildScaleHeight;

	private static readonly IntPtr NativeFieldInfoPtr_m_ReverseArrangement;

	private static readonly IntPtr NativeMethodInfoPtr_get_spacing_Public_get_Single_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_spacing_Public_set_Void_Single_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_childForceExpandWidth_Public_get_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_childForceExpandWidth_Public_set_Void_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_childForceExpandHeight_Public_get_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_childForceExpandHeight_Public_set_Void_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_childControlWidth_Public_get_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_childControlWidth_Public_set_Void_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_childControlHeight_Public_get_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_childControlHeight_Public_set_Void_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_childScaleWidth_Public_get_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_childScaleWidth_Public_set_Void_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_childScaleHeight_Public_get_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_childScaleHeight_Public_set_Void_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_reverseArrangement_Public_get_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_reverseArrangement_Public_set_Void_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_CalcAlongAxis_Protected_Void_Int32_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_SetChildrenAlongAxis_Protected_Void_Int32_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetChildSizes_Private_Void_RectTransform_Int32_Boolean_Boolean_byref_Single_byref_Single_byref_Single_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

	public unsafe float m_Spacing
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Spacing);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Spacing)) = value;
		}
	}

	public unsafe bool m_ChildForceExpandWidth
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ChildForceExpandWidth);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ChildForceExpandWidth)) = value;
		}
	}

	public unsafe bool m_ChildForceExpandHeight
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ChildForceExpandHeight);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ChildForceExpandHeight)) = value;
		}
	}

	public unsafe bool m_ChildControlWidth
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ChildControlWidth);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ChildControlWidth)) = value;
		}
	}

	public unsafe bool m_ChildControlHeight
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ChildControlHeight);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ChildControlHeight)) = value;
		}
	}

	public unsafe bool m_ChildScaleWidth
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ChildScaleWidth);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ChildScaleWidth)) = value;
		}
	}

	public unsafe bool m_ChildScaleHeight
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ChildScaleHeight);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ChildScaleHeight)) = value;
		}
	}

	public unsafe bool m_ReverseArrangement
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ReverseArrangement);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ReverseArrangement)) = value;
		}
	}

	public unsafe float spacing
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_spacing_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1293106, RefRangeEnd = 1293107, XrefRangeStart = 1293103, XrefRangeEnd = 1293106, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = stackalloc IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_spacing_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe bool childForceExpandWidth
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_childForceExpandWidth_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1293110, RefRangeEnd = 1293112, XrefRangeStart = 1293107, XrefRangeEnd = 1293110, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = stackalloc IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_childForceExpandWidth_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe bool childForceExpandHeight
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_childForceExpandHeight_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1293115, RefRangeEnd = 1293118, XrefRangeStart = 1293112, XrefRangeEnd = 1293115, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = stackalloc IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_childForceExpandHeight_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe bool childControlWidth
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_childControlWidth_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1293121, RefRangeEnd = 1293123, XrefRangeStart = 1293118, XrefRangeEnd = 1293121, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = stackalloc IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_childControlWidth_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe bool childControlHeight
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_childControlHeight_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1293126, RefRangeEnd = 1293131, XrefRangeStart = 1293123, XrefRangeEnd = 1293126, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = stackalloc IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_childControlHeight_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe bool childScaleWidth
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_childScaleWidth_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1293134, RefRangeEnd = 1293135, XrefRangeStart = 1293131, XrefRangeEnd = 1293134, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = stackalloc IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_childScaleWidth_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe bool childScaleHeight
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_childScaleHeight_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1293138, RefRangeEnd = 1293139, XrefRangeStart = 1293135, XrefRangeEnd = 1293138, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = stackalloc IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_childScaleHeight_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe bool reverseArrangement
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_reverseArrangement_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1293142, RefRangeEnd = 1293143, XrefRangeStart = 1293139, XrefRangeEnd = 1293142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = stackalloc IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_reverseArrangement_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	static HorizontalOrVerticalLayoutGroup()
	{
		Il2CppClassPointerStore<HorizontalOrVerticalLayoutGroup>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UI.dll", "UnityEngine.UI", "HorizontalOrVerticalLayoutGroup");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HorizontalOrVerticalLayoutGroup>.NativeClassPtr);
		NativeFieldInfoPtr_m_Spacing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HorizontalOrVerticalLayoutGroup>.NativeClassPtr, "m_Spacing");
		NativeFieldInfoPtr_m_ChildForceExpandWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HorizontalOrVerticalLayoutGroup>.NativeClassPtr, "m_ChildForceExpandWidth");
		NativeFieldInfoPtr_m_ChildForceExpandHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HorizontalOrVerticalLayoutGroup>.NativeClassPtr, "m_ChildForceExpandHeight");
		NativeFieldInfoPtr_m_ChildControlWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HorizontalOrVerticalLayoutGroup>.NativeClassPtr, "m_ChildControlWidth");
		NativeFieldInfoPtr_m_ChildControlHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HorizontalOrVerticalLayoutGroup>.NativeClassPtr, "m_ChildControlHeight");
		NativeFieldInfoPtr_m_ChildScaleWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HorizontalOrVerticalLayoutGroup>.NativeClassPtr, "m_ChildScaleWidth");
		NativeFieldInfoPtr_m_ChildScaleHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HorizontalOrVerticalLayoutGroup>.NativeClassPtr, "m_ChildScaleHeight");
		NativeFieldInfoPtr_m_ReverseArrangement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HorizontalOrVerticalLayoutGroup>.NativeClassPtr, "m_ReverseArrangement");
		NativeMethodInfoPtr_get_spacing_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HorizontalOrVerticalLayoutGroup>.NativeClassPtr, 100663964);
		NativeMethodInfoPtr_set_spacing_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HorizontalOrVerticalLayoutGroup>.NativeClassPtr, 100663965);
		NativeMethodInfoPtr_get_childForceExpandWidth_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HorizontalOrVerticalLayoutGroup>.NativeClassPtr, 100663966);
		NativeMethodInfoPtr_set_childForceExpandWidth_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HorizontalOrVerticalLayoutGroup>.NativeClassPtr, 100663967);
		NativeMethodInfoPtr_get_childForceExpandHeight_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HorizontalOrVerticalLayoutGroup>.NativeClassPtr, 100663968);
		NativeMethodInfoPtr_set_childForceExpandHeight_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HorizontalOrVerticalLayoutGroup>.NativeClassPtr, 100663969);
		NativeMethodInfoPtr_get_childControlWidth_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HorizontalOrVerticalLayoutGroup>.NativeClassPtr, 100663970);
		NativeMethodInfoPtr_set_childControlWidth_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HorizontalOrVerticalLayoutGroup>.NativeClassPtr, 100663971);
		NativeMethodInfoPtr_get_childControlHeight_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HorizontalOrVerticalLayoutGroup>.NativeClassPtr, 100663972);
		NativeMethodInfoPtr_set_childControlHeight_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HorizontalOrVerticalLayoutGroup>.NativeClassPtr, 100663973);
		NativeMethodInfoPtr_get_childScaleWidth_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HorizontalOrVerticalLayoutGroup>.NativeClassPtr, 100663974);
		NativeMethodInfoPtr_set_childScaleWidth_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HorizontalOrVerticalLayoutGroup>.NativeClassPtr, 100663975);
		NativeMethodInfoPtr_get_childScaleHeight_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HorizontalOrVerticalLayoutGroup>.NativeClassPtr, 100663976);
		NativeMethodInfoPtr_set_childScaleHeight_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HorizontalOrVerticalLayoutGroup>.NativeClassPtr, 100663977);
		NativeMethodInfoPtr_get_reverseArrangement_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HorizontalOrVerticalLayoutGroup>.NativeClassPtr, 100663978);
		NativeMethodInfoPtr_set_reverseArrangement_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HorizontalOrVerticalLayoutGroup>.NativeClassPtr, 100663979);
		NativeMethodInfoPtr_CalcAlongAxis_Protected_Void_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HorizontalOrVerticalLayoutGroup>.NativeClassPtr, 100663980);
		NativeMethodInfoPtr_SetChildrenAlongAxis_Protected_Void_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HorizontalOrVerticalLayoutGroup>.NativeClassPtr, 100663981);
		NativeMethodInfoPtr_GetChildSizes_Private_Void_RectTransform_Int32_Boolean_Boolean_byref_Single_byref_Single_byref_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HorizontalOrVerticalLayoutGroup>.NativeClassPtr, 100663982);
		NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HorizontalOrVerticalLayoutGroup>.NativeClassPtr, 100663983);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 1293159, RefRangeEnd = 1293163, XrefRangeStart = 1293143, XrefRangeEnd = 1293159, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CalcAlongAxis(int axis, bool isVertical)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = (nint)(&axis);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &isVertical;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CalcAlongAxis_Protected_Void_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 1293232, RefRangeEnd = 1293236, XrefRangeStart = 1293163, XrefRangeEnd = 1293232, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetChildrenAlongAxis(int axis, bool isVertical)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = (nint)(&axis);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &isVertical;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetChildrenAlongAxis_Protected_Void_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1293236, XrefRangeEnd = 1293242, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void GetChildSizes(RectTransform child, int axis, bool controlSize, bool childForceExpand, out float min, out float preferred, out float flexible)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[7];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)child);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &axis;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(IntPtr)))) = &controlSize;
		*(bool**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(IntPtr)))) = &childForceExpand;
		*(void**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(IntPtr)))) = Unsafe.AsPointer(ref min);
		*(void**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(IntPtr)))) = Unsafe.AsPointer(ref preferred);
		*(void**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(IntPtr)))) = Unsafe.AsPointer(ref flexible);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetChildSizes_Private_Void_RectTransform_Int32_Boolean_Boolean_byref_Single_byref_Single_byref_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1293096, RefRangeEnd = 1293097, XrefRangeStart = 1293096, XrefRangeEnd = 1293097, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe HorizontalOrVerticalLayoutGroup()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HorizontalOrVerticalLayoutGroup>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public HorizontalOrVerticalLayoutGroup(IntPtr pointer)
		: base(pointer)
	{
	}
}
