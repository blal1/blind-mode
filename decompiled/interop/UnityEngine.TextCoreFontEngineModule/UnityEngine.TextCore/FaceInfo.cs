using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;
using UnityEngine.TextCore.LowLevel;

namespace UnityEngine.TextCore;

[System.Serializable]
public sealed class FaceInfo : Il2CppSystem.ValueType
{
	private static readonly System.IntPtr NativeFieldInfoPtr_m_FaceIndex;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_FamilyName;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_StyleName;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_PointSize;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_Scale;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_UnitsPerEM;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_LineHeight;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_AscentLine;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_CapLine;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_MeanLine;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_Baseline;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_DescentLine;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_SuperscriptOffset;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_SuperscriptSize;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_SubscriptOffset;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_SubscriptSize;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_UnderlineOffset;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_UnderlineThickness;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_StrikethroughOffset;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_StrikethroughThickness;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_TabWidth;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_faceIndex_Internal_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_familyName_Public_get_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_styleName_Public_get_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_pointSize_Public_get_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_scale_Public_get_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_scale_Public_set_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_unitsPerEM_Internal_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_unitsPerEM_Internal_set_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_lineHeight_Public_get_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_ascentLine_Public_get_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_capLine_Public_get_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_capLine_Public_set_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_meanLine_Public_get_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_meanLine_Public_set_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_baseline_Public_get_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_descentLine_Public_get_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_superscriptOffset_Public_get_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_superscriptSize_Public_get_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_subscriptOffset_Public_get_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_subscriptSize_Public_get_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_underlineOffset_Public_get_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_underlineThickness_Public_get_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_strikethroughOffset_Public_get_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_strikethroughOffset_Public_set_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_tabWidth_Public_get_Single_0;

	public unsafe int m_FaceIndex
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_FaceIndex);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_FaceIndex)) = value;
		}
	}

	public unsafe string m_FamilyName
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_FamilyName);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_FamilyName)), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe string m_StyleName
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_StyleName);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_StyleName)), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe float m_PointSize
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_PointSize);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_PointSize)) = value;
		}
	}

	public unsafe float m_Scale
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Scale);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Scale)) = value;
		}
	}

	public unsafe int m_UnitsPerEM
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_UnitsPerEM);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_UnitsPerEM)) = value;
		}
	}

	public unsafe float m_LineHeight
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_LineHeight);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_LineHeight)) = value;
		}
	}

	public unsafe float m_AscentLine
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_AscentLine);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_AscentLine)) = value;
		}
	}

	public unsafe float m_CapLine
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_CapLine);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_CapLine)) = value;
		}
	}

	public unsafe float m_MeanLine
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_MeanLine);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_MeanLine)) = value;
		}
	}

	public unsafe float m_Baseline
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Baseline);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Baseline)) = value;
		}
	}

	public unsafe float m_DescentLine
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_DescentLine);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_DescentLine)) = value;
		}
	}

	public unsafe float m_SuperscriptOffset
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_SuperscriptOffset);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_SuperscriptOffset)) = value;
		}
	}

	public unsafe float m_SuperscriptSize
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_SuperscriptSize);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_SuperscriptSize)) = value;
		}
	}

	public unsafe float m_SubscriptOffset
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_SubscriptOffset);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_SubscriptOffset)) = value;
		}
	}

	public unsafe float m_SubscriptSize
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_SubscriptSize);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_SubscriptSize)) = value;
		}
	}

	public unsafe float m_UnderlineOffset
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_UnderlineOffset);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_UnderlineOffset)) = value;
		}
	}

	public unsafe float m_UnderlineThickness
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_UnderlineThickness);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_UnderlineThickness)) = value;
		}
	}

	public unsafe float m_StrikethroughOffset
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_StrikethroughOffset);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_StrikethroughOffset)) = value;
		}
	}

	public unsafe float m_StrikethroughThickness
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_StrikethroughThickness);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_StrikethroughThickness)) = value;
		}
	}

	public unsafe float m_TabWidth
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_TabWidth);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_TabWidth)) = value;
		}
	}

	public unsafe int faceIndex
	{
		[CallerCount(256)]
		[CachedScanResults(RefRangeStart = 1153990, RefRangeEnd = 1154246, XrefRangeStart = 1153990, XrefRangeEnd = 1154246, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_faceIndex_Internal_get_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		set
		{
			m_FaceIndex = value;
		}
	}

	public unsafe string familyName
	{
		[CallerCount(29)]
		[CachedScanResults(RefRangeStart = 765815, RefRangeEnd = 765844, XrefRangeStart = 765815, XrefRangeEnd = 765844, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_familyName_Public_get_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return IL2CPP.Il2CppStringToManaged(intPtr2);
		}
		set
		{
			m_FamilyName = value;
		}
	}

	public unsafe string styleName
	{
		[CallerCount(200)]
		[CachedScanResults(RefRangeStart = 1156232, RefRangeEnd = 1156432, XrefRangeStart = 1156232, XrefRangeEnd = 1156432, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_styleName_Public_get_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return IL2CPP.Il2CppStringToManaged(intPtr2);
		}
		set
		{
			m_StyleName = value;
		}
	}

	public unsafe float pointSize
	{
		[CallerCount(62)]
		[CachedScanResults(RefRangeStart = 1154293, RefRangeEnd = 1154355, XrefRangeStart = 1154293, XrefRangeEnd = 1154355, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_pointSize_Public_get_Single_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		set
		{
			m_PointSize = value;
		}
	}

	public unsafe float scale
	{
		[CallerCount(53)]
		[CachedScanResults(RefRangeStart = 1156476, RefRangeEnd = 1156529, XrefRangeStart = 1156476, XrefRangeEnd = 1156529, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_scale_Public_get_Single_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 340116, RefRangeEnd = 340118, XrefRangeStart = 340116, XrefRangeEnd = 340118, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_scale_Public_set_Void_Single_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe int unitsPerEM
	{
		[CallerCount(24)]
		[CachedScanResults(RefRangeStart = 1156529, RefRangeEnd = 1156553, XrefRangeStart = 1156529, XrefRangeEnd = 1156553, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_unitsPerEM_Internal_get_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 102244, RefRangeEnd = 102245, XrefRangeStart = 102244, XrefRangeEnd = 102245, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_unitsPerEM_Internal_set_Void_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe float lineHeight
	{
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 1157013, RefRangeEnd = 1157023, XrefRangeStart = 1157013, XrefRangeEnd = 1157023, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_lineHeight_Public_get_Single_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		set
		{
			m_LineHeight = value;
		}
	}

	public unsafe float ascentLine
	{
		[CallerCount(25)]
		[CachedScanResults(RefRangeStart = 1157023, RefRangeEnd = 1157048, XrefRangeStart = 1157023, XrefRangeEnd = 1157048, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_ascentLine_Public_get_Single_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		set
		{
			m_AscentLine = value;
		}
	}

	public unsafe float capLine
	{
		[CallerCount(18)]
		[CachedScanResults(RefRangeStart = 1252544, RefRangeEnd = 1252562, XrefRangeStart = 1252544, XrefRangeEnd = 1252562, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_capLine_Public_get_Single_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 145606, RefRangeEnd = 145613, XrefRangeStart = 145606, XrefRangeEnd = 145613, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_capLine_Public_set_Void_Single_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe float meanLine
	{
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 1153342, RefRangeEnd = 1153348, XrefRangeStart = 1153342, XrefRangeEnd = 1153348, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_meanLine_Public_get_Single_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 675749, RefRangeEnd = 675751, XrefRangeStart = 675749, XrefRangeEnd = 675751, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_meanLine_Public_set_Void_Single_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe float baseline
	{
		[CallerCount(15)]
		[CachedScanResults(RefRangeStart = 1252565, RefRangeEnd = 1252580, XrefRangeStart = 1252565, XrefRangeEnd = 1252580, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_baseline_Public_get_Single_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		set
		{
			m_Baseline = value;
		}
	}

	public unsafe float descentLine
	{
		[CallerCount(45)]
		[CachedScanResults(RefRangeStart = 1114260, RefRangeEnd = 1114305, XrefRangeStart = 1114260, XrefRangeEnd = 1114305, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_descentLine_Public_get_Single_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		set
		{
			m_DescentLine = value;
		}
	}

	public unsafe float superscriptOffset
	{
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1114306, RefRangeEnd = 1114309, XrefRangeStart = 1114306, XrefRangeEnd = 1114309, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_superscriptOffset_Public_get_Single_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		set
		{
			m_SuperscriptOffset = value;
		}
	}

	public unsafe float superscriptSize
	{
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1252562, RefRangeEnd = 1252565, XrefRangeStart = 1252562, XrefRangeEnd = 1252565, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_superscriptSize_Public_get_Single_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		set
		{
			m_SuperscriptSize = value;
		}
	}

	public unsafe float subscriptOffset
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_subscriptOffset_Public_get_Single_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		set
		{
			m_SubscriptOffset = value;
		}
	}

	public unsafe float subscriptSize
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_subscriptSize_Public_get_Single_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		set
		{
			m_SubscriptSize = value;
		}
	}

	public unsafe float underlineOffset
	{
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1272613, RefRangeEnd = 1272616, XrefRangeStart = 1272613, XrefRangeEnd = 1272613, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_underlineOffset_Public_get_Single_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		set
		{
			m_UnderlineOffset = value;
		}
	}

	public unsafe float underlineThickness
	{
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1272616, RefRangeEnd = 1272618, XrefRangeStart = 1272616, XrefRangeEnd = 1272616, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_underlineThickness_Public_get_Single_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		set
		{
			m_UnderlineThickness = value;
		}
	}

	public unsafe float strikethroughOffset
	{
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1254528, RefRangeEnd = 1254533, XrefRangeStart = 1254528, XrefRangeEnd = 1254533, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_strikethroughOffset_Public_get_Single_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 842835, RefRangeEnd = 842837, XrefRangeStart = 842835, XrefRangeEnd = 842837, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_strikethroughOffset_Public_set_Void_Single_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe float tabWidth
	{
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1272618, RefRangeEnd = 1272623, XrefRangeStart = 1272618, XrefRangeEnd = 1272618, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_tabWidth_Public_get_Single_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		set
		{
			m_TabWidth = value;
		}
	}

	public float strikethroughThickness
	{
		get
		{
			return m_StrikethroughThickness;
		}
		set
		{
			m_StrikethroughThickness = value;
		}
	}

	static FaceInfo()
	{
		Il2CppClassPointerStore<FaceInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.TextCoreFontEngineModule.dll", "UnityEngine.TextCore", "FaceInfo");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FaceInfo>.NativeClassPtr);
		NativeFieldInfoPtr_m_FaceIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FaceInfo>.NativeClassPtr, "m_FaceIndex");
		NativeFieldInfoPtr_m_FamilyName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FaceInfo>.NativeClassPtr, "m_FamilyName");
		NativeFieldInfoPtr_m_StyleName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FaceInfo>.NativeClassPtr, "m_StyleName");
		NativeFieldInfoPtr_m_PointSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FaceInfo>.NativeClassPtr, "m_PointSize");
		NativeFieldInfoPtr_m_Scale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FaceInfo>.NativeClassPtr, "m_Scale");
		NativeFieldInfoPtr_m_UnitsPerEM = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FaceInfo>.NativeClassPtr, "m_UnitsPerEM");
		NativeFieldInfoPtr_m_LineHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FaceInfo>.NativeClassPtr, "m_LineHeight");
		NativeFieldInfoPtr_m_AscentLine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FaceInfo>.NativeClassPtr, "m_AscentLine");
		NativeFieldInfoPtr_m_CapLine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FaceInfo>.NativeClassPtr, "m_CapLine");
		NativeFieldInfoPtr_m_MeanLine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FaceInfo>.NativeClassPtr, "m_MeanLine");
		NativeFieldInfoPtr_m_Baseline = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FaceInfo>.NativeClassPtr, "m_Baseline");
		NativeFieldInfoPtr_m_DescentLine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FaceInfo>.NativeClassPtr, "m_DescentLine");
		NativeFieldInfoPtr_m_SuperscriptOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FaceInfo>.NativeClassPtr, "m_SuperscriptOffset");
		NativeFieldInfoPtr_m_SuperscriptSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FaceInfo>.NativeClassPtr, "m_SuperscriptSize");
		NativeFieldInfoPtr_m_SubscriptOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FaceInfo>.NativeClassPtr, "m_SubscriptOffset");
		NativeFieldInfoPtr_m_SubscriptSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FaceInfo>.NativeClassPtr, "m_SubscriptSize");
		NativeFieldInfoPtr_m_UnderlineOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FaceInfo>.NativeClassPtr, "m_UnderlineOffset");
		NativeFieldInfoPtr_m_UnderlineThickness = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FaceInfo>.NativeClassPtr, "m_UnderlineThickness");
		NativeFieldInfoPtr_m_StrikethroughOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FaceInfo>.NativeClassPtr, "m_StrikethroughOffset");
		NativeFieldInfoPtr_m_StrikethroughThickness = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FaceInfo>.NativeClassPtr, "m_StrikethroughThickness");
		NativeFieldInfoPtr_m_TabWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FaceInfo>.NativeClassPtr, "m_TabWidth");
		NativeMethodInfoPtr_get_faceIndex_Internal_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FaceInfo>.NativeClassPtr, 100663297);
		NativeMethodInfoPtr_get_familyName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FaceInfo>.NativeClassPtr, 100663298);
		NativeMethodInfoPtr_get_styleName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FaceInfo>.NativeClassPtr, 100663299);
		NativeMethodInfoPtr_get_pointSize_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FaceInfo>.NativeClassPtr, 100663300);
		NativeMethodInfoPtr_get_scale_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FaceInfo>.NativeClassPtr, 100663301);
		NativeMethodInfoPtr_set_scale_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FaceInfo>.NativeClassPtr, 100663302);
		NativeMethodInfoPtr_get_unitsPerEM_Internal_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FaceInfo>.NativeClassPtr, 100663303);
		NativeMethodInfoPtr_set_unitsPerEM_Internal_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FaceInfo>.NativeClassPtr, 100663304);
		NativeMethodInfoPtr_get_lineHeight_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FaceInfo>.NativeClassPtr, 100663305);
		NativeMethodInfoPtr_get_ascentLine_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FaceInfo>.NativeClassPtr, 100663306);
		NativeMethodInfoPtr_get_capLine_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FaceInfo>.NativeClassPtr, 100663307);
		NativeMethodInfoPtr_set_capLine_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FaceInfo>.NativeClassPtr, 100663308);
		NativeMethodInfoPtr_get_meanLine_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FaceInfo>.NativeClassPtr, 100663309);
		NativeMethodInfoPtr_set_meanLine_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FaceInfo>.NativeClassPtr, 100663310);
		NativeMethodInfoPtr_get_baseline_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FaceInfo>.NativeClassPtr, 100663311);
		NativeMethodInfoPtr_get_descentLine_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FaceInfo>.NativeClassPtr, 100663312);
		NativeMethodInfoPtr_get_superscriptOffset_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FaceInfo>.NativeClassPtr, 100663313);
		NativeMethodInfoPtr_get_superscriptSize_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FaceInfo>.NativeClassPtr, 100663314);
		NativeMethodInfoPtr_get_subscriptOffset_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FaceInfo>.NativeClassPtr, 100663315);
		NativeMethodInfoPtr_get_subscriptSize_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FaceInfo>.NativeClassPtr, 100663316);
		NativeMethodInfoPtr_get_underlineOffset_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FaceInfo>.NativeClassPtr, 100663317);
		NativeMethodInfoPtr_get_underlineThickness_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FaceInfo>.NativeClassPtr, 100663318);
		NativeMethodInfoPtr_get_strikethroughOffset_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FaceInfo>.NativeClassPtr, 100663319);
		NativeMethodInfoPtr_set_strikethroughOffset_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FaceInfo>.NativeClassPtr, 100663320);
		NativeMethodInfoPtr_get_tabWidth_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FaceInfo>.NativeClassPtr, 100663321);
	}

	public FaceInfo(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public FaceInfo()
		: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FaceInfo>.NativeClassPtr))
	{
	}

	public unsafe bool Compare(FaceInfo other)
	{
		//IL_000e: Expected O, but got Ref
		//IL_0025: Expected O, but got Ref
		//IL_003c: Expected O, but got Ref
		//IL_004e: Expected O, but got Ref
		//IL_0060: Expected O, but got Ref
		//IL_0078: Expected O, but got Ref
		//IL_0090: Expected O, but got Ref
		//IL_00a7: Expected O, but got Ref
		//IL_00be: Expected O, but got Ref
		//IL_00d5: Expected O, but got Ref
		//IL_00ec: Expected O, but got Ref
		//IL_0103: Expected O, but got Ref
		//IL_011a: Expected O, but got Ref
		//IL_0131: Expected O, but got Ref
		//IL_0148: Expected O, but got Ref
		//IL_015c: Expected O, but got Ref
		//IL_0170: Expected O, but got Ref
		//IL_0184: Expected O, but got Ref
		//IL_0198: Expected O, but got Ref
		//IL_01ac: Expected O, but got Ref
		//IL_01c0: Expected O, but got Ref
		return familyName == ((FaceInfo)(&other)).familyName && styleName == ((FaceInfo)(&other)).styleName && faceIndex == ((FaceInfo)(&other)).faceIndex && pointSize == ((FaceInfo)(&other)).pointSize && FontEngineUtilities.Approximately(scale, ((FaceInfo)(&other)).scale) && FontEngineUtilities.Approximately(unitsPerEM, ((FaceInfo)(&other)).unitsPerEM) && FontEngineUtilities.Approximately(lineHeight, ((FaceInfo)(&other)).lineHeight) && FontEngineUtilities.Approximately(ascentLine, ((FaceInfo)(&other)).ascentLine) && FontEngineUtilities.Approximately(capLine, ((FaceInfo)(&other)).capLine) && FontEngineUtilities.Approximately(meanLine, ((FaceInfo)(&other)).meanLine) && FontEngineUtilities.Approximately(baseline, ((FaceInfo)(&other)).baseline) && FontEngineUtilities.Approximately(descentLine, ((FaceInfo)(&other)).descentLine) && FontEngineUtilities.Approximately(superscriptOffset, ((FaceInfo)(&other)).superscriptOffset) && FontEngineUtilities.Approximately(superscriptSize, ((FaceInfo)(&other)).superscriptSize) && FontEngineUtilities.Approximately(subscriptOffset, ((FaceInfo)(&other)).subscriptOffset) && FontEngineUtilities.Approximately(subscriptSize, ((FaceInfo)(&other)).subscriptSize) && FontEngineUtilities.Approximately(underlineOffset, ((FaceInfo)(&other)).underlineOffset) && FontEngineUtilities.Approximately(underlineThickness, ((FaceInfo)(&other)).underlineThickness) && FontEngineUtilities.Approximately(strikethroughOffset, ((FaceInfo)(&other)).strikethroughOffset) && FontEngineUtilities.Approximately(strikethroughThickness, ((FaceInfo)(&other)).strikethroughThickness) && FontEngineUtilities.Approximately(tabWidth, ((FaceInfo)(&other)).tabWidth);
	}
}
