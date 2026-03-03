using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine;

public sealed class TextGenerationSettings : Il2CppSystem.ValueType
{
	private static readonly System.IntPtr NativeFieldInfoPtr_font;

	private static readonly System.IntPtr NativeFieldInfoPtr_color;

	private static readonly System.IntPtr NativeFieldInfoPtr_fontSize;

	private static readonly System.IntPtr NativeFieldInfoPtr_lineSpacing;

	private static readonly System.IntPtr NativeFieldInfoPtr_richText;

	private static readonly System.IntPtr NativeFieldInfoPtr_scaleFactor;

	private static readonly System.IntPtr NativeFieldInfoPtr_fontStyle;

	private static readonly System.IntPtr NativeFieldInfoPtr_textAnchor;

	private static readonly System.IntPtr NativeFieldInfoPtr_alignByGeometry;

	private static readonly System.IntPtr NativeFieldInfoPtr_resizeTextForBestFit;

	private static readonly System.IntPtr NativeFieldInfoPtr_resizeTextMinSize;

	private static readonly System.IntPtr NativeFieldInfoPtr_resizeTextMaxSize;

	private static readonly System.IntPtr NativeFieldInfoPtr_updateBounds;

	private static readonly System.IntPtr NativeFieldInfoPtr_verticalOverflow;

	private static readonly System.IntPtr NativeFieldInfoPtr_horizontalOverflow;

	private static readonly System.IntPtr NativeFieldInfoPtr_generationExtents;

	private static readonly System.IntPtr NativeFieldInfoPtr_pivot;

	private static readonly System.IntPtr NativeFieldInfoPtr_generateOutOfBounds;

	private static readonly System.IntPtr NativeMethodInfoPtr_CompareColors_Private_Boolean_Color_Color_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CompareVector2_Private_Boolean_Vector2_Vector2_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Boolean_TextGenerationSettings_0;

	public unsafe Font font
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_font);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Font>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_font)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe Color color
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_color);
			return *(Color*)num;
		}
		set
		{
			*(Color*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_color)) = value;
		}
	}

	public unsafe int fontSize
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fontSize);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fontSize)) = value;
		}
	}

	public unsafe float lineSpacing
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lineSpacing);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lineSpacing)) = value;
		}
	}

	public unsafe bool richText
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_richText);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_richText)) = value;
		}
	}

	public unsafe float scaleFactor
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_scaleFactor);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_scaleFactor)) = value;
		}
	}

	public unsafe FontStyle fontStyle
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fontStyle);
			return *(FontStyle*)num;
		}
		set
		{
			*(FontStyle*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fontStyle)) = value;
		}
	}

	public unsafe TextAnchor textAnchor
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_textAnchor);
			return *(TextAnchor*)num;
		}
		set
		{
			*(TextAnchor*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_textAnchor)) = value;
		}
	}

	public unsafe bool alignByGeometry
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_alignByGeometry);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_alignByGeometry)) = value;
		}
	}

	public unsafe bool resizeTextForBestFit
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_resizeTextForBestFit);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_resizeTextForBestFit)) = value;
		}
	}

	public unsafe int resizeTextMinSize
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_resizeTextMinSize);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_resizeTextMinSize)) = value;
		}
	}

	public unsafe int resizeTextMaxSize
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_resizeTextMaxSize);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_resizeTextMaxSize)) = value;
		}
	}

	public unsafe bool updateBounds
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_updateBounds);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_updateBounds)) = value;
		}
	}

	public unsafe VerticalWrapMode verticalOverflow
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_verticalOverflow);
			return *(VerticalWrapMode*)num;
		}
		set
		{
			*(VerticalWrapMode*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_verticalOverflow)) = value;
		}
	}

	public unsafe HorizontalWrapMode horizontalOverflow
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_horizontalOverflow);
			return *(HorizontalWrapMode*)num;
		}
		set
		{
			*(HorizontalWrapMode*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_horizontalOverflow)) = value;
		}
	}

	public unsafe Vector2 generationExtents
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_generationExtents);
			return *(Vector2*)num;
		}
		set
		{
			*(Vector2*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_generationExtents)) = value;
		}
	}

	public unsafe Vector2 pivot
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pivot);
			return *(Vector2*)num;
		}
		set
		{
			*(Vector2*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pivot)) = value;
		}
	}

	public unsafe bool generateOutOfBounds
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_generateOutOfBounds);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_generateOutOfBounds)) = value;
		}
	}

	static TextGenerationSettings()
	{
		Il2CppClassPointerStore<TextGenerationSettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.TextRenderingModule.dll", "UnityEngine", "TextGenerationSettings");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TextGenerationSettings>.NativeClassPtr);
		NativeFieldInfoPtr_font = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerationSettings>.NativeClassPtr, "font");
		NativeFieldInfoPtr_color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerationSettings>.NativeClassPtr, "color");
		NativeFieldInfoPtr_fontSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerationSettings>.NativeClassPtr, "fontSize");
		NativeFieldInfoPtr_lineSpacing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerationSettings>.NativeClassPtr, "lineSpacing");
		NativeFieldInfoPtr_richText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerationSettings>.NativeClassPtr, "richText");
		NativeFieldInfoPtr_scaleFactor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerationSettings>.NativeClassPtr, "scaleFactor");
		NativeFieldInfoPtr_fontStyle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerationSettings>.NativeClassPtr, "fontStyle");
		NativeFieldInfoPtr_textAnchor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerationSettings>.NativeClassPtr, "textAnchor");
		NativeFieldInfoPtr_alignByGeometry = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerationSettings>.NativeClassPtr, "alignByGeometry");
		NativeFieldInfoPtr_resizeTextForBestFit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerationSettings>.NativeClassPtr, "resizeTextForBestFit");
		NativeFieldInfoPtr_resizeTextMinSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerationSettings>.NativeClassPtr, "resizeTextMinSize");
		NativeFieldInfoPtr_resizeTextMaxSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerationSettings>.NativeClassPtr, "resizeTextMaxSize");
		NativeFieldInfoPtr_updateBounds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerationSettings>.NativeClassPtr, "updateBounds");
		NativeFieldInfoPtr_verticalOverflow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerationSettings>.NativeClassPtr, "verticalOverflow");
		NativeFieldInfoPtr_horizontalOverflow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerationSettings>.NativeClassPtr, "horizontalOverflow");
		NativeFieldInfoPtr_generationExtents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerationSettings>.NativeClassPtr, "generationExtents");
		NativeFieldInfoPtr_pivot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerationSettings>.NativeClassPtr, "pivot");
		NativeFieldInfoPtr_generateOutOfBounds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerationSettings>.NativeClassPtr, "generateOutOfBounds");
		NativeMethodInfoPtr_CompareColors_Private_Boolean_Color_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextGenerationSettings>.NativeClassPtr, 100663297);
		NativeMethodInfoPtr_CompareVector2_Private_Boolean_Vector2_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextGenerationSettings>.NativeClassPtr, 100663298);
		NativeMethodInfoPtr_Equals_Public_Boolean_TextGenerationSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextGenerationSettings>.NativeClassPtr, 100663299);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1284872, XrefRangeEnd = 1284876, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool CompareColors(Color left, Color right)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&left);
		*(Color**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &right;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CompareColors_Private_Boolean_Color_Color_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1284877, RefRangeEnd = 1284879, XrefRangeStart = 1284876, XrefRangeEnd = 1284877, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool CompareVector2(Vector2 left, Vector2 right)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&left);
		*(Vector2**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &right;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CompareVector2_Private_Boolean_Vector2_Vector2_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1284892, RefRangeEnd = 1284893, XrefRangeStart = 1284879, XrefRangeEnd = 1284892, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool Equals(TextGenerationSettings other)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)other));
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Equals_Public_Boolean_TextGenerationSettings_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	public TextGenerationSettings(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public TextGenerationSettings()
		: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TextGenerationSettings>.NativeClassPtr))
	{
	}
}
