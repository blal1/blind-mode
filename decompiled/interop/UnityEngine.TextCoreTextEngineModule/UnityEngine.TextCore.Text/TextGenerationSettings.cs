using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.TextCore.Text;

public class TextGenerationSettings : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_IsEditorTextRenderingModeBitmap;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_RenderedText;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_CachedRenderedText;

	private static readonly System.IntPtr NativeFieldInfoPtr_screenRect;

	private static readonly System.IntPtr NativeFieldInfoPtr_pixelsPerPoint;

	private static readonly System.IntPtr NativeFieldInfoPtr_isEditorRenderingModeBitmap;

	private static readonly System.IntPtr NativeFieldInfoPtr_fontAsset;

	private static readonly System.IntPtr NativeFieldInfoPtr_fontStyle;

	private static readonly System.IntPtr NativeFieldInfoPtr_textSettings;

	private static readonly System.IntPtr NativeFieldInfoPtr_textAlignment;

	private static readonly System.IntPtr NativeFieldInfoPtr_overflowMode;

	private static readonly System.IntPtr NativeFieldInfoPtr_wordWrappingRatio;

	private static readonly System.IntPtr NativeFieldInfoPtr_color;

	private static readonly System.IntPtr NativeFieldInfoPtr_shouldConvertToLinearSpace;

	private static readonly System.IntPtr NativeFieldInfoPtr_fontSize;

	private static readonly System.IntPtr NativeFieldInfoPtr_autoSize;

	private static readonly System.IntPtr NativeFieldInfoPtr_fontSizeMin;

	private static readonly System.IntPtr NativeFieldInfoPtr_fontSizeMax;

	private static readonly System.IntPtr NativeFieldInfoPtr_fontFeatures;

	private static readonly System.IntPtr NativeFieldInfoPtr_emojiFallbackSupport;

	private static readonly System.IntPtr NativeFieldInfoPtr_richText;

	private static readonly System.IntPtr NativeFieldInfoPtr_isRightToLeft;

	private static readonly System.IntPtr NativeFieldInfoPtr_extraPadding;

	private static readonly System.IntPtr NativeFieldInfoPtr_parseControlCharacters;

	private static readonly System.IntPtr NativeFieldInfoPtr_isPlaceholder;

	private static readonly System.IntPtr NativeFieldInfoPtr_tagNoParsing;

	private static readonly System.IntPtr NativeFieldInfoPtr_characterSpacing;

	private static readonly System.IntPtr NativeFieldInfoPtr_wordSpacing;

	private static readonly System.IntPtr NativeFieldInfoPtr_lineSpacing;

	private static readonly System.IntPtr NativeFieldInfoPtr_paragraphSpacing;

	private static readonly System.IntPtr NativeFieldInfoPtr_lineSpacingMax;

	private static readonly System.IntPtr NativeFieldInfoPtr_textWrappingMode;

	private static readonly System.IntPtr NativeFieldInfoPtr_maxVisibleCharacters;

	private static readonly System.IntPtr NativeFieldInfoPtr_maxVisibleWords;

	private static readonly System.IntPtr NativeFieldInfoPtr_maxVisibleLines;

	private static readonly System.IntPtr NativeFieldInfoPtr_firstVisibleCharacter;

	private static readonly System.IntPtr NativeFieldInfoPtr_useMaxVisibleDescender;

	private static readonly System.IntPtr NativeFieldInfoPtr_fontWeight;

	private static readonly System.IntPtr NativeFieldInfoPtr_isIMGUI;

	private static readonly System.IntPtr NativeFieldInfoPtr_charWidthMaxAdj;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_renderedText_Public_get_RenderedText_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_renderedText_Public_set_Void_RenderedText_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_text_Public_get_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_text_Public_set_Void_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_TextGenerationSettings_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_TextGenerationSettings_TextGenerationSettings_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

	public unsafe static Il2CppSystem.Func<bool> IsEditorTextRenderingModeBitmap
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_IsEditorTextRenderingModeBitmap, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Func<bool>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_IsEditorTextRenderingModeBitmap, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe RenderedText m_RenderedText
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_RenderedText);
			return new RenderedText(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RenderedText>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_RenderedText), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<RenderedText>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe string m_CachedRenderedText
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_CachedRenderedText);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_CachedRenderedText)), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe Rect screenRect
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_screenRect);
			return *(Rect*)num;
		}
		set
		{
			*(Rect*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_screenRect)) = value;
		}
	}

	public unsafe float pixelsPerPoint
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pixelsPerPoint);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pixelsPerPoint)) = value;
		}
	}

	public unsafe bool isEditorRenderingModeBitmap
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isEditorRenderingModeBitmap);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isEditorRenderingModeBitmap)) = value;
		}
	}

	public unsafe FontAsset fontAsset
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fontAsset);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<FontAsset>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fontAsset)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe FontStyles fontStyle
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fontStyle);
			return *(FontStyles*)num;
		}
		set
		{
			*(FontStyles*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fontStyle)) = value;
		}
	}

	public unsafe TextSettings textSettings
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_textSettings);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<TextSettings>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_textSettings)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe TextAlignment textAlignment
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_textAlignment);
			return *(TextAlignment*)num;
		}
		set
		{
			*(TextAlignment*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_textAlignment)) = value;
		}
	}

	public unsafe TextOverflowMode overflowMode
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_overflowMode);
			return *(TextOverflowMode*)num;
		}
		set
		{
			*(TextOverflowMode*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_overflowMode)) = value;
		}
	}

	public unsafe static float wordWrappingRatio
	{
		get
		{
			Unsafe.SkipInit(out float result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_wordWrappingRatio, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_wordWrappingRatio, (void*)(&value));
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

	public unsafe bool shouldConvertToLinearSpace
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_shouldConvertToLinearSpace);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_shouldConvertToLinearSpace)) = value;
		}
	}

	public unsafe float fontSize
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fontSize);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fontSize)) = value;
		}
	}

	public unsafe static bool autoSize
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_autoSize, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_autoSize, (void*)(&value));
		}
	}

	public unsafe static float fontSizeMin
	{
		get
		{
			Unsafe.SkipInit(out float result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_fontSizeMin, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_fontSizeMin, (void*)(&value));
		}
	}

	public unsafe static float fontSizeMax
	{
		get
		{
			Unsafe.SkipInit(out float result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_fontSizeMax, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_fontSizeMax, (void*)(&value));
		}
	}

	public unsafe static List<OTL_FeatureTag> fontFeatures
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_fontFeatures, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<OTL_FeatureTag>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_fontFeatures, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe bool emojiFallbackSupport
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_emojiFallbackSupport);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_emojiFallbackSupport)) = value;
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

	public unsafe bool isRightToLeft
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isRightToLeft);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isRightToLeft)) = value;
		}
	}

	public unsafe float extraPadding
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_extraPadding);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_extraPadding)) = value;
		}
	}

	public unsafe bool parseControlCharacters
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_parseControlCharacters);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_parseControlCharacters)) = value;
		}
	}

	public unsafe bool isPlaceholder
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isPlaceholder);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isPlaceholder)) = value;
		}
	}

	public unsafe static bool tagNoParsing
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_tagNoParsing, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_tagNoParsing, (void*)(&value));
		}
	}

	public unsafe float characterSpacing
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_characterSpacing);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_characterSpacing)) = value;
		}
	}

	public unsafe float wordSpacing
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_wordSpacing);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_wordSpacing)) = value;
		}
	}

	public unsafe static float lineSpacing
	{
		get
		{
			Unsafe.SkipInit(out float result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_lineSpacing, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_lineSpacing, (void*)(&value));
		}
	}

	public unsafe float paragraphSpacing
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_paragraphSpacing);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_paragraphSpacing)) = value;
		}
	}

	public unsafe static float lineSpacingMax
	{
		get
		{
			Unsafe.SkipInit(out float result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_lineSpacingMax, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_lineSpacingMax, (void*)(&value));
		}
	}

	public unsafe TextWrappingMode textWrappingMode
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_textWrappingMode);
			return *(TextWrappingMode*)num;
		}
		set
		{
			*(TextWrappingMode*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_textWrappingMode)) = value;
		}
	}

	public unsafe static int maxVisibleCharacters
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_maxVisibleCharacters, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_maxVisibleCharacters, (void*)(&value));
		}
	}

	public unsafe static int maxVisibleWords
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_maxVisibleWords, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_maxVisibleWords, (void*)(&value));
		}
	}

	public unsafe static int maxVisibleLines
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_maxVisibleLines, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_maxVisibleLines, (void*)(&value));
		}
	}

	public unsafe static int firstVisibleCharacter
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_firstVisibleCharacter, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_firstVisibleCharacter, (void*)(&value));
		}
	}

	public unsafe static bool useMaxVisibleDescender
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_useMaxVisibleDescender, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_useMaxVisibleDescender, (void*)(&value));
		}
	}

	public unsafe TextFontWeight fontWeight
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fontWeight);
			return *(TextFontWeight*)num;
		}
		set
		{
			*(TextFontWeight*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fontWeight)) = value;
		}
	}

	public unsafe bool isIMGUI
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isIMGUI);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isIMGUI)) = value;
		}
	}

	public unsafe static float charWidthMaxAdj
	{
		get
		{
			Unsafe.SkipInit(out float result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_charWidthMaxAdj, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_charWidthMaxAdj, (void*)(&value));
		}
	}

	public unsafe RenderedText renderedText
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_renderedText_Public_get_RenderedText_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new RenderedText(pointer);
		}
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1282108, RefRangeEnd = 1282111, XrefRangeStart = 1282106, XrefRangeEnd = 1282108, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)value));
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_renderedText_Public_set_Void_RenderedText_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe string text
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1282111, XrefRangeEnd = 1282113, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_text_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return IL2CPP.Il2CppStringToManaged(intPtr2);
		}
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1282121, RefRangeEnd = 1282123, XrefRangeStart = 1282113, XrefRangeEnd = 1282121, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_text_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	static TextGenerationSettings()
	{
		Il2CppClassPointerStore<TextGenerationSettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.TextCoreTextEngineModule.dll", "UnityEngine.TextCore.Text", "TextGenerationSettings");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TextGenerationSettings>.NativeClassPtr);
		NativeFieldInfoPtr_IsEditorTextRenderingModeBitmap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerationSettings>.NativeClassPtr, "IsEditorTextRenderingModeBitmap");
		NativeFieldInfoPtr_m_RenderedText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerationSettings>.NativeClassPtr, "m_RenderedText");
		NativeFieldInfoPtr_m_CachedRenderedText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerationSettings>.NativeClassPtr, "m_CachedRenderedText");
		NativeFieldInfoPtr_screenRect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerationSettings>.NativeClassPtr, "screenRect");
		NativeFieldInfoPtr_pixelsPerPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerationSettings>.NativeClassPtr, "pixelsPerPoint");
		NativeFieldInfoPtr_isEditorRenderingModeBitmap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerationSettings>.NativeClassPtr, "isEditorRenderingModeBitmap");
		NativeFieldInfoPtr_fontAsset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerationSettings>.NativeClassPtr, "fontAsset");
		NativeFieldInfoPtr_fontStyle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerationSettings>.NativeClassPtr, "fontStyle");
		NativeFieldInfoPtr_textSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerationSettings>.NativeClassPtr, "textSettings");
		NativeFieldInfoPtr_textAlignment = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerationSettings>.NativeClassPtr, "textAlignment");
		NativeFieldInfoPtr_overflowMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerationSettings>.NativeClassPtr, "overflowMode");
		NativeFieldInfoPtr_wordWrappingRatio = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerationSettings>.NativeClassPtr, "wordWrappingRatio");
		NativeFieldInfoPtr_color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerationSettings>.NativeClassPtr, "color");
		NativeFieldInfoPtr_shouldConvertToLinearSpace = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerationSettings>.NativeClassPtr, "shouldConvertToLinearSpace");
		NativeFieldInfoPtr_fontSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerationSettings>.NativeClassPtr, "fontSize");
		NativeFieldInfoPtr_autoSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerationSettings>.NativeClassPtr, "autoSize");
		NativeFieldInfoPtr_fontSizeMin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerationSettings>.NativeClassPtr, "fontSizeMin");
		NativeFieldInfoPtr_fontSizeMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerationSettings>.NativeClassPtr, "fontSizeMax");
		NativeFieldInfoPtr_fontFeatures = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerationSettings>.NativeClassPtr, "fontFeatures");
		NativeFieldInfoPtr_emojiFallbackSupport = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerationSettings>.NativeClassPtr, "emojiFallbackSupport");
		NativeFieldInfoPtr_richText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerationSettings>.NativeClassPtr, "richText");
		NativeFieldInfoPtr_isRightToLeft = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerationSettings>.NativeClassPtr, "isRightToLeft");
		NativeFieldInfoPtr_extraPadding = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerationSettings>.NativeClassPtr, "extraPadding");
		NativeFieldInfoPtr_parseControlCharacters = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerationSettings>.NativeClassPtr, "parseControlCharacters");
		NativeFieldInfoPtr_isPlaceholder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerationSettings>.NativeClassPtr, "isPlaceholder");
		NativeFieldInfoPtr_tagNoParsing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerationSettings>.NativeClassPtr, "tagNoParsing");
		NativeFieldInfoPtr_characterSpacing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerationSettings>.NativeClassPtr, "characterSpacing");
		NativeFieldInfoPtr_wordSpacing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerationSettings>.NativeClassPtr, "wordSpacing");
		NativeFieldInfoPtr_lineSpacing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerationSettings>.NativeClassPtr, "lineSpacing");
		NativeFieldInfoPtr_paragraphSpacing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerationSettings>.NativeClassPtr, "paragraphSpacing");
		NativeFieldInfoPtr_lineSpacingMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerationSettings>.NativeClassPtr, "lineSpacingMax");
		NativeFieldInfoPtr_textWrappingMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerationSettings>.NativeClassPtr, "textWrappingMode");
		NativeFieldInfoPtr_maxVisibleCharacters = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerationSettings>.NativeClassPtr, "maxVisibleCharacters");
		NativeFieldInfoPtr_maxVisibleWords = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerationSettings>.NativeClassPtr, "maxVisibleWords");
		NativeFieldInfoPtr_maxVisibleLines = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerationSettings>.NativeClassPtr, "maxVisibleLines");
		NativeFieldInfoPtr_firstVisibleCharacter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerationSettings>.NativeClassPtr, "firstVisibleCharacter");
		NativeFieldInfoPtr_useMaxVisibleDescender = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerationSettings>.NativeClassPtr, "useMaxVisibleDescender");
		NativeFieldInfoPtr_fontWeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerationSettings>.NativeClassPtr, "fontWeight");
		NativeFieldInfoPtr_isIMGUI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerationSettings>.NativeClassPtr, "isIMGUI");
		NativeFieldInfoPtr_charWidthMaxAdj = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerationSettings>.NativeClassPtr, "charWidthMaxAdj");
		NativeMethodInfoPtr_get_renderedText_Public_get_RenderedText_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextGenerationSettings>.NativeClassPtr, 100663767);
		NativeMethodInfoPtr_set_renderedText_Public_set_Void_RenderedText_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextGenerationSettings>.NativeClassPtr, 100663768);
		NativeMethodInfoPtr_get_text_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextGenerationSettings>.NativeClassPtr, 100663769);
		NativeMethodInfoPtr_set_text_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextGenerationSettings>.NativeClassPtr, 100663770);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextGenerationSettings>.NativeClassPtr, 100663771);
		NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_TextGenerationSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextGenerationSettings>.NativeClassPtr, 100663772);
		NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextGenerationSettings>.NativeClassPtr, 100663773);
		NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextGenerationSettings>.NativeClassPtr, 100663774);
		NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_TextGenerationSettings_TextGenerationSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextGenerationSettings>.NativeClassPtr, 100663775);
		NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextGenerationSettings>.NativeClassPtr, 100663776);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1282124, RefRangeEnd = 1282125, XrefRangeStart = 1282123, XrefRangeEnd = 1282124, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe TextGenerationSettings()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TextGenerationSettings>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1282141, RefRangeEnd = 1282142, XrefRangeStart = 1282125, XrefRangeEnd = 1282141, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual bool Equals(TextGenerationSettings other)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)other);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_TextGenerationSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1282142, XrefRangeEnd = 1282150, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override bool Equals(Il2CppSystem.Object obj)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)obj);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1282150, XrefRangeEnd = 1282206, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override int GetHashCode()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1282206, XrefRangeEnd = 1282207, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool operator !=(TextGenerationSettings left, TextGenerationSettings right)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)left);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)right);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_TextGenerationSettings_TextGenerationSettings_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1282207, XrefRangeEnd = 1282432, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override string ToString()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	public TextGenerationSettings(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public static bool operator ==(TextGenerationSettings left, TextGenerationSettings right)
	{
		return Il2CppSystem.Object.Equals(left, right);
	}
}
