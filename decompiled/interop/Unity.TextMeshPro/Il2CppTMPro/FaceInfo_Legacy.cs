using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;

namespace Il2CppTMPro;

[System.Serializable]
public class FaceInfo_Legacy : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_Name;

	private static readonly System.IntPtr NativeFieldInfoPtr_PointSize;

	private static readonly System.IntPtr NativeFieldInfoPtr_Scale;

	private static readonly System.IntPtr NativeFieldInfoPtr_CharacterCount;

	private static readonly System.IntPtr NativeFieldInfoPtr_LineHeight;

	private static readonly System.IntPtr NativeFieldInfoPtr_Baseline;

	private static readonly System.IntPtr NativeFieldInfoPtr_Ascender;

	private static readonly System.IntPtr NativeFieldInfoPtr_CapHeight;

	private static readonly System.IntPtr NativeFieldInfoPtr_Descender;

	private static readonly System.IntPtr NativeFieldInfoPtr_CenterLine;

	private static readonly System.IntPtr NativeFieldInfoPtr_SuperscriptOffset;

	private static readonly System.IntPtr NativeFieldInfoPtr_SubscriptOffset;

	private static readonly System.IntPtr NativeFieldInfoPtr_SubSize;

	private static readonly System.IntPtr NativeFieldInfoPtr_Underline;

	private static readonly System.IntPtr NativeFieldInfoPtr_UnderlineThickness;

	private static readonly System.IntPtr NativeFieldInfoPtr_strikethrough;

	private static readonly System.IntPtr NativeFieldInfoPtr_strikethroughThickness;

	private static readonly System.IntPtr NativeFieldInfoPtr_TabWidth;

	private static readonly System.IntPtr NativeFieldInfoPtr_Padding;

	private static readonly System.IntPtr NativeFieldInfoPtr_AtlasWidth;

	private static readonly System.IntPtr NativeFieldInfoPtr_AtlasHeight;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe string Name
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Name);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Name)), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe float PointSize
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PointSize);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PointSize)) = value;
		}
	}

	public unsafe float Scale
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Scale);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Scale)) = value;
		}
	}

	public unsafe int CharacterCount
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CharacterCount);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CharacterCount)) = value;
		}
	}

	public unsafe float LineHeight
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_LineHeight);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_LineHeight)) = value;
		}
	}

	public unsafe float Baseline
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Baseline);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Baseline)) = value;
		}
	}

	public unsafe float Ascender
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Ascender);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Ascender)) = value;
		}
	}

	public unsafe float CapHeight
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CapHeight);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CapHeight)) = value;
		}
	}

	public unsafe float Descender
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Descender);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Descender)) = value;
		}
	}

	public unsafe float CenterLine
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CenterLine);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CenterLine)) = value;
		}
	}

	public unsafe float SuperscriptOffset
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SuperscriptOffset);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SuperscriptOffset)) = value;
		}
	}

	public unsafe float SubscriptOffset
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SubscriptOffset);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SubscriptOffset)) = value;
		}
	}

	public unsafe float SubSize
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SubSize);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SubSize)) = value;
		}
	}

	public unsafe float Underline
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Underline);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Underline)) = value;
		}
	}

	public unsafe float UnderlineThickness
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_UnderlineThickness);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_UnderlineThickness)) = value;
		}
	}

	public unsafe float strikethrough
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_strikethrough);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_strikethrough)) = value;
		}
	}

	public unsafe float strikethroughThickness
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_strikethroughThickness);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_strikethroughThickness)) = value;
		}
	}

	public unsafe float TabWidth
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_TabWidth);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_TabWidth)) = value;
		}
	}

	public unsafe float Padding
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Padding);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Padding)) = value;
		}
	}

	public unsafe float AtlasWidth
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_AtlasWidth);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_AtlasWidth)) = value;
		}
	}

	public unsafe float AtlasHeight
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_AtlasHeight);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_AtlasHeight)) = value;
		}
	}

	static FaceInfo_Legacy()
	{
		Il2CppClassPointerStore<FaceInfo_Legacy>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.TextMeshPro.dll", "TMPro", "FaceInfo_Legacy");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FaceInfo_Legacy>.NativeClassPtr);
		NativeFieldInfoPtr_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FaceInfo_Legacy>.NativeClassPtr, "Name");
		NativeFieldInfoPtr_PointSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FaceInfo_Legacy>.NativeClassPtr, "PointSize");
		NativeFieldInfoPtr_Scale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FaceInfo_Legacy>.NativeClassPtr, "Scale");
		NativeFieldInfoPtr_CharacterCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FaceInfo_Legacy>.NativeClassPtr, "CharacterCount");
		NativeFieldInfoPtr_LineHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FaceInfo_Legacy>.NativeClassPtr, "LineHeight");
		NativeFieldInfoPtr_Baseline = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FaceInfo_Legacy>.NativeClassPtr, "Baseline");
		NativeFieldInfoPtr_Ascender = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FaceInfo_Legacy>.NativeClassPtr, "Ascender");
		NativeFieldInfoPtr_CapHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FaceInfo_Legacy>.NativeClassPtr, "CapHeight");
		NativeFieldInfoPtr_Descender = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FaceInfo_Legacy>.NativeClassPtr, "Descender");
		NativeFieldInfoPtr_CenterLine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FaceInfo_Legacy>.NativeClassPtr, "CenterLine");
		NativeFieldInfoPtr_SuperscriptOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FaceInfo_Legacy>.NativeClassPtr, "SuperscriptOffset");
		NativeFieldInfoPtr_SubscriptOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FaceInfo_Legacy>.NativeClassPtr, "SubscriptOffset");
		NativeFieldInfoPtr_SubSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FaceInfo_Legacy>.NativeClassPtr, "SubSize");
		NativeFieldInfoPtr_Underline = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FaceInfo_Legacy>.NativeClassPtr, "Underline");
		NativeFieldInfoPtr_UnderlineThickness = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FaceInfo_Legacy>.NativeClassPtr, "UnderlineThickness");
		NativeFieldInfoPtr_strikethrough = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FaceInfo_Legacy>.NativeClassPtr, "strikethrough");
		NativeFieldInfoPtr_strikethroughThickness = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FaceInfo_Legacy>.NativeClassPtr, "strikethroughThickness");
		NativeFieldInfoPtr_TabWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FaceInfo_Legacy>.NativeClassPtr, "TabWidth");
		NativeFieldInfoPtr_Padding = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FaceInfo_Legacy>.NativeClassPtr, "Padding");
		NativeFieldInfoPtr_AtlasWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FaceInfo_Legacy>.NativeClassPtr, "AtlasWidth");
		NativeFieldInfoPtr_AtlasHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FaceInfo_Legacy>.NativeClassPtr, "AtlasHeight");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FaceInfo_Legacy>.NativeClassPtr, 100663960);
	}

	[CallerCount(1950)]
	[CachedScanResults(RefRangeStart = 20036, RefRangeEnd = 21986, XrefRangeStart = 20036, XrefRangeEnd = 21986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe FaceInfo_Legacy()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FaceInfo_Legacy>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public FaceInfo_Legacy(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
