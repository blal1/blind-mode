using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.TextCore.Text;

public sealed class WordWrapState : Il2CppSystem.ValueType
{
	private static readonly System.IntPtr NativeFieldInfoPtr_previousWordBreak;

	private static readonly System.IntPtr NativeFieldInfoPtr_totalCharacterCount;

	private static readonly System.IntPtr NativeFieldInfoPtr_visibleCharacterCount;

	private static readonly System.IntPtr NativeFieldInfoPtr_visibleSpaceCount;

	private static readonly System.IntPtr NativeFieldInfoPtr_visibleSpriteCount;

	private static readonly System.IntPtr NativeFieldInfoPtr_visibleLinkCount;

	private static readonly System.IntPtr NativeFieldInfoPtr_firstCharacterIndex;

	private static readonly System.IntPtr NativeFieldInfoPtr_firstVisibleCharacterIndex;

	private static readonly System.IntPtr NativeFieldInfoPtr_lastCharacterIndex;

	private static readonly System.IntPtr NativeFieldInfoPtr_lastVisibleCharIndex;

	private static readonly System.IntPtr NativeFieldInfoPtr_lineNumber;

	private static readonly System.IntPtr NativeFieldInfoPtr_maxCapHeight;

	private static readonly System.IntPtr NativeFieldInfoPtr_maxAscender;

	private static readonly System.IntPtr NativeFieldInfoPtr_maxDescender;

	private static readonly System.IntPtr NativeFieldInfoPtr_maxLineAscender;

	private static readonly System.IntPtr NativeFieldInfoPtr_maxLineDescender;

	private static readonly System.IntPtr NativeFieldInfoPtr_startOfLineAscender;

	private static readonly System.IntPtr NativeFieldInfoPtr_xAdvance;

	private static readonly System.IntPtr NativeFieldInfoPtr_preferredWidth;

	private static readonly System.IntPtr NativeFieldInfoPtr_preferredHeight;

	private static readonly System.IntPtr NativeFieldInfoPtr_previousLineScale;

	private static readonly System.IntPtr NativeFieldInfoPtr_pageAscender;

	private static readonly System.IntPtr NativeFieldInfoPtr_wordCount;

	private static readonly System.IntPtr NativeFieldInfoPtr_fontStyle;

	private static readonly System.IntPtr NativeFieldInfoPtr_fontScale;

	private static readonly System.IntPtr NativeFieldInfoPtr_fontScaleMultiplier;

	private static readonly System.IntPtr NativeFieldInfoPtr_italicAngle;

	private static readonly System.IntPtr NativeFieldInfoPtr_currentFontSize;

	private static readonly System.IntPtr NativeFieldInfoPtr_baselineOffset;

	private static readonly System.IntPtr NativeFieldInfoPtr_lineOffset;

	private static readonly System.IntPtr NativeFieldInfoPtr_textInfo;

	private static readonly System.IntPtr NativeFieldInfoPtr_lineInfo;

	private static readonly System.IntPtr NativeFieldInfoPtr_vertexColor;

	private static readonly System.IntPtr NativeFieldInfoPtr_underlineColor;

	private static readonly System.IntPtr NativeFieldInfoPtr_strikethroughColor;

	private static readonly System.IntPtr NativeFieldInfoPtr_highlightColor;

	private static readonly System.IntPtr NativeFieldInfoPtr_highlightState;

	private static readonly System.IntPtr NativeFieldInfoPtr_basicStyleStack;

	private static readonly System.IntPtr NativeFieldInfoPtr_italicAngleStack;

	private static readonly System.IntPtr NativeFieldInfoPtr_colorStack;

	private static readonly System.IntPtr NativeFieldInfoPtr_underlineColorStack;

	private static readonly System.IntPtr NativeFieldInfoPtr_strikethroughColorStack;

	private static readonly System.IntPtr NativeFieldInfoPtr_highlightColorStack;

	private static readonly System.IntPtr NativeFieldInfoPtr_highlightStateStack;

	private static readonly System.IntPtr NativeFieldInfoPtr_colorGradientStack;

	private static readonly System.IntPtr NativeFieldInfoPtr_sizeStack;

	private static readonly System.IntPtr NativeFieldInfoPtr_indentStack;

	private static readonly System.IntPtr NativeFieldInfoPtr_fontWeightStack;

	private static readonly System.IntPtr NativeFieldInfoPtr_styleStack;

	private static readonly System.IntPtr NativeFieldInfoPtr_baselineStack;

	private static readonly System.IntPtr NativeFieldInfoPtr_actionStack;

	private static readonly System.IntPtr NativeFieldInfoPtr_materialReferenceStack;

	private static readonly System.IntPtr NativeFieldInfoPtr_lineJustificationStack;

	private static readonly System.IntPtr NativeFieldInfoPtr_lastBaseGlyphIndex;

	private static readonly System.IntPtr NativeFieldInfoPtr_spriteAnimationId;

	private static readonly System.IntPtr NativeFieldInfoPtr_currentFontAsset;

	private static readonly System.IntPtr NativeFieldInfoPtr_currentSpriteAsset;

	private static readonly System.IntPtr NativeFieldInfoPtr_currentMaterial;

	private static readonly System.IntPtr NativeFieldInfoPtr_currentMaterialIndex;

	private static readonly System.IntPtr NativeFieldInfoPtr_meshExtents;

	private static readonly System.IntPtr NativeFieldInfoPtr_tagNoParsing;

	private static readonly System.IntPtr NativeFieldInfoPtr_isNonBreakingSpace;

	private static readonly System.IntPtr NativeFieldInfoPtr_isDrivenLineSpacing;

	private static readonly System.IntPtr NativeFieldInfoPtr_fxScale;

	private static readonly System.IntPtr NativeFieldInfoPtr_fxRotation;

	public unsafe int previousWordBreak
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_previousWordBreak);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_previousWordBreak)) = value;
		}
	}

	public unsafe int totalCharacterCount
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_totalCharacterCount);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_totalCharacterCount)) = value;
		}
	}

	public unsafe int visibleCharacterCount
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_visibleCharacterCount);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_visibleCharacterCount)) = value;
		}
	}

	public unsafe int visibleSpaceCount
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_visibleSpaceCount);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_visibleSpaceCount)) = value;
		}
	}

	public unsafe int visibleSpriteCount
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_visibleSpriteCount);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_visibleSpriteCount)) = value;
		}
	}

	public unsafe int visibleLinkCount
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_visibleLinkCount);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_visibleLinkCount)) = value;
		}
	}

	public unsafe int firstCharacterIndex
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_firstCharacterIndex);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_firstCharacterIndex)) = value;
		}
	}

	public unsafe int firstVisibleCharacterIndex
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_firstVisibleCharacterIndex);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_firstVisibleCharacterIndex)) = value;
		}
	}

	public unsafe int lastCharacterIndex
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lastCharacterIndex);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lastCharacterIndex)) = value;
		}
	}

	public unsafe int lastVisibleCharIndex
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lastVisibleCharIndex);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lastVisibleCharIndex)) = value;
		}
	}

	public unsafe int lineNumber
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lineNumber);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lineNumber)) = value;
		}
	}

	public unsafe float maxCapHeight
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxCapHeight);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxCapHeight)) = value;
		}
	}

	public unsafe float maxAscender
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxAscender);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxAscender)) = value;
		}
	}

	public unsafe float maxDescender
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxDescender);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxDescender)) = value;
		}
	}

	public unsafe float maxLineAscender
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxLineAscender);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxLineAscender)) = value;
		}
	}

	public unsafe float maxLineDescender
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxLineDescender);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxLineDescender)) = value;
		}
	}

	public unsafe float startOfLineAscender
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_startOfLineAscender);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_startOfLineAscender)) = value;
		}
	}

	public unsafe float xAdvance
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_xAdvance);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_xAdvance)) = value;
		}
	}

	public unsafe float preferredWidth
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_preferredWidth);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_preferredWidth)) = value;
		}
	}

	public unsafe float preferredHeight
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_preferredHeight);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_preferredHeight)) = value;
		}
	}

	public unsafe float previousLineScale
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_previousLineScale);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_previousLineScale)) = value;
		}
	}

	public unsafe float pageAscender
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pageAscender);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pageAscender)) = value;
		}
	}

	public unsafe int wordCount
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_wordCount);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_wordCount)) = value;
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

	public unsafe float fontScale
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fontScale);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fontScale)) = value;
		}
	}

	public unsafe float fontScaleMultiplier
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fontScaleMultiplier);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fontScaleMultiplier)) = value;
		}
	}

	public unsafe int italicAngle
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_italicAngle);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_italicAngle)) = value;
		}
	}

	public unsafe float currentFontSize
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currentFontSize);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currentFontSize)) = value;
		}
	}

	public unsafe float baselineOffset
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_baselineOffset);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_baselineOffset)) = value;
		}
	}

	public unsafe float lineOffset
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lineOffset);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lineOffset)) = value;
		}
	}

	public unsafe TextInfo textInfo
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_textInfo);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<TextInfo>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_textInfo)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe LineInfo lineInfo
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lineInfo);
			return *(LineInfo*)num;
		}
		set
		{
			*(LineInfo*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lineInfo)) = value;
		}
	}

	public unsafe Color32 vertexColor
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_vertexColor);
			return *(Color32*)num;
		}
		set
		{
			*(Color32*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_vertexColor)) = value;
		}
	}

	public unsafe Color32 underlineColor
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_underlineColor);
			return *(Color32*)num;
		}
		set
		{
			*(Color32*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_underlineColor)) = value;
		}
	}

	public unsafe Color32 strikethroughColor
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_strikethroughColor);
			return *(Color32*)num;
		}
		set
		{
			*(Color32*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_strikethroughColor)) = value;
		}
	}

	public unsafe Color32 highlightColor
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_highlightColor);
			return *(Color32*)num;
		}
		set
		{
			*(Color32*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_highlightColor)) = value;
		}
	}

	public unsafe HighlightState highlightState
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_highlightState);
			return *(HighlightState*)num;
		}
		set
		{
			*(HighlightState*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_highlightState)) = value;
		}
	}

	public unsafe FontStyleStack basicStyleStack
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_basicStyleStack);
			return *(FontStyleStack*)num;
		}
		set
		{
			*(FontStyleStack*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_basicStyleStack)) = value;
		}
	}

	public unsafe TextProcessingStack<int> italicAngleStack
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_italicAngleStack);
			return new TextProcessingStack<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TextProcessingStack<int>>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_italicAngleStack), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TextProcessingStack<int>>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe TextProcessingStack<Color32> colorStack
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_colorStack);
			return new TextProcessingStack<Color32>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TextProcessingStack<Color32>>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_colorStack), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TextProcessingStack<Color32>>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe TextProcessingStack<Color32> underlineColorStack
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_underlineColorStack);
			return new TextProcessingStack<Color32>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TextProcessingStack<Color32>>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_underlineColorStack), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TextProcessingStack<Color32>>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe TextProcessingStack<Color32> strikethroughColorStack
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_strikethroughColorStack);
			return new TextProcessingStack<Color32>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TextProcessingStack<Color32>>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_strikethroughColorStack), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TextProcessingStack<Color32>>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe TextProcessingStack<Color32> highlightColorStack
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_highlightColorStack);
			return new TextProcessingStack<Color32>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TextProcessingStack<Color32>>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_highlightColorStack), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TextProcessingStack<Color32>>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe TextProcessingStack<HighlightState> highlightStateStack
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_highlightStateStack);
			return new TextProcessingStack<HighlightState>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TextProcessingStack<HighlightState>>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_highlightStateStack), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TextProcessingStack<HighlightState>>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe TextProcessingStack<TextColorGradient> colorGradientStack
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_colorGradientStack);
			return new TextProcessingStack<TextColorGradient>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TextProcessingStack<TextColorGradient>>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_colorGradientStack), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TextProcessingStack<TextColorGradient>>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe TextProcessingStack<float> sizeStack
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sizeStack);
			return new TextProcessingStack<float>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TextProcessingStack<float>>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sizeStack), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TextProcessingStack<float>>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe TextProcessingStack<float> indentStack
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_indentStack);
			return new TextProcessingStack<float>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TextProcessingStack<float>>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_indentStack), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TextProcessingStack<float>>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe TextProcessingStack<TextFontWeight> fontWeightStack
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fontWeightStack);
			return new TextProcessingStack<TextFontWeight>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TextProcessingStack<TextFontWeight>>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fontWeightStack), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TextProcessingStack<TextFontWeight>>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe TextProcessingStack<int> styleStack
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_styleStack);
			return new TextProcessingStack<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TextProcessingStack<int>>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_styleStack), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TextProcessingStack<int>>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe TextProcessingStack<float> baselineStack
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_baselineStack);
			return new TextProcessingStack<float>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TextProcessingStack<float>>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_baselineStack), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TextProcessingStack<float>>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe TextProcessingStack<int> actionStack
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_actionStack);
			return new TextProcessingStack<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TextProcessingStack<int>>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_actionStack), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TextProcessingStack<int>>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe TextProcessingStack<MaterialReference> materialReferenceStack
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_materialReferenceStack);
			return new TextProcessingStack<MaterialReference>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TextProcessingStack<MaterialReference>>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_materialReferenceStack), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TextProcessingStack<MaterialReference>>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe TextProcessingStack<TextAlignment> lineJustificationStack
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lineJustificationStack);
			return new TextProcessingStack<TextAlignment>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TextProcessingStack<TextAlignment>>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lineJustificationStack), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TextProcessingStack<TextAlignment>>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe int lastBaseGlyphIndex
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lastBaseGlyphIndex);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lastBaseGlyphIndex)) = value;
		}
	}

	public unsafe int spriteAnimationId
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_spriteAnimationId);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_spriteAnimationId)) = value;
		}
	}

	public unsafe FontAsset currentFontAsset
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currentFontAsset);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<FontAsset>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currentFontAsset)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe SpriteAsset currentSpriteAsset
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currentSpriteAsset);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<SpriteAsset>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currentSpriteAsset)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe Material currentMaterial
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currentMaterial);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Material>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currentMaterial)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe int currentMaterialIndex
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currentMaterialIndex);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currentMaterialIndex)) = value;
		}
	}

	public unsafe Extents meshExtents
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_meshExtents);
			return *(Extents*)num;
		}
		set
		{
			*(Extents*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_meshExtents)) = value;
		}
	}

	public unsafe bool tagNoParsing
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tagNoParsing);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tagNoParsing)) = value;
		}
	}

	public unsafe bool isNonBreakingSpace
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isNonBreakingSpace);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isNonBreakingSpace)) = value;
		}
	}

	public unsafe bool isDrivenLineSpacing
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isDrivenLineSpacing);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isDrivenLineSpacing)) = value;
		}
	}

	public unsafe Vector3 fxScale
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fxScale);
			return *(Vector3*)num;
		}
		set
		{
			*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fxScale)) = value;
		}
	}

	public unsafe Quaternion fxRotation
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fxRotation);
			return *(Quaternion*)num;
		}
		set
		{
			*(Quaternion*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fxRotation)) = value;
		}
	}

	static WordWrapState()
	{
		Il2CppClassPointerStore<WordWrapState>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.TextCoreTextEngineModule.dll", "UnityEngine.TextCore.Text", "WordWrapState");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WordWrapState>.NativeClassPtr);
		NativeFieldInfoPtr_previousWordBreak = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WordWrapState>.NativeClassPtr, "previousWordBreak");
		NativeFieldInfoPtr_totalCharacterCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WordWrapState>.NativeClassPtr, "totalCharacterCount");
		NativeFieldInfoPtr_visibleCharacterCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WordWrapState>.NativeClassPtr, "visibleCharacterCount");
		NativeFieldInfoPtr_visibleSpaceCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WordWrapState>.NativeClassPtr, "visibleSpaceCount");
		NativeFieldInfoPtr_visibleSpriteCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WordWrapState>.NativeClassPtr, "visibleSpriteCount");
		NativeFieldInfoPtr_visibleLinkCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WordWrapState>.NativeClassPtr, "visibleLinkCount");
		NativeFieldInfoPtr_firstCharacterIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WordWrapState>.NativeClassPtr, "firstCharacterIndex");
		NativeFieldInfoPtr_firstVisibleCharacterIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WordWrapState>.NativeClassPtr, "firstVisibleCharacterIndex");
		NativeFieldInfoPtr_lastCharacterIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WordWrapState>.NativeClassPtr, "lastCharacterIndex");
		NativeFieldInfoPtr_lastVisibleCharIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WordWrapState>.NativeClassPtr, "lastVisibleCharIndex");
		NativeFieldInfoPtr_lineNumber = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WordWrapState>.NativeClassPtr, "lineNumber");
		NativeFieldInfoPtr_maxCapHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WordWrapState>.NativeClassPtr, "maxCapHeight");
		NativeFieldInfoPtr_maxAscender = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WordWrapState>.NativeClassPtr, "maxAscender");
		NativeFieldInfoPtr_maxDescender = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WordWrapState>.NativeClassPtr, "maxDescender");
		NativeFieldInfoPtr_maxLineAscender = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WordWrapState>.NativeClassPtr, "maxLineAscender");
		NativeFieldInfoPtr_maxLineDescender = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WordWrapState>.NativeClassPtr, "maxLineDescender");
		NativeFieldInfoPtr_startOfLineAscender = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WordWrapState>.NativeClassPtr, "startOfLineAscender");
		NativeFieldInfoPtr_xAdvance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WordWrapState>.NativeClassPtr, "xAdvance");
		NativeFieldInfoPtr_preferredWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WordWrapState>.NativeClassPtr, "preferredWidth");
		NativeFieldInfoPtr_preferredHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WordWrapState>.NativeClassPtr, "preferredHeight");
		NativeFieldInfoPtr_previousLineScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WordWrapState>.NativeClassPtr, "previousLineScale");
		NativeFieldInfoPtr_pageAscender = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WordWrapState>.NativeClassPtr, "pageAscender");
		NativeFieldInfoPtr_wordCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WordWrapState>.NativeClassPtr, "wordCount");
		NativeFieldInfoPtr_fontStyle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WordWrapState>.NativeClassPtr, "fontStyle");
		NativeFieldInfoPtr_fontScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WordWrapState>.NativeClassPtr, "fontScale");
		NativeFieldInfoPtr_fontScaleMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WordWrapState>.NativeClassPtr, "fontScaleMultiplier");
		NativeFieldInfoPtr_italicAngle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WordWrapState>.NativeClassPtr, "italicAngle");
		NativeFieldInfoPtr_currentFontSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WordWrapState>.NativeClassPtr, "currentFontSize");
		NativeFieldInfoPtr_baselineOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WordWrapState>.NativeClassPtr, "baselineOffset");
		NativeFieldInfoPtr_lineOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WordWrapState>.NativeClassPtr, "lineOffset");
		NativeFieldInfoPtr_textInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WordWrapState>.NativeClassPtr, "textInfo");
		NativeFieldInfoPtr_lineInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WordWrapState>.NativeClassPtr, "lineInfo");
		NativeFieldInfoPtr_vertexColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WordWrapState>.NativeClassPtr, "vertexColor");
		NativeFieldInfoPtr_underlineColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WordWrapState>.NativeClassPtr, "underlineColor");
		NativeFieldInfoPtr_strikethroughColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WordWrapState>.NativeClassPtr, "strikethroughColor");
		NativeFieldInfoPtr_highlightColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WordWrapState>.NativeClassPtr, "highlightColor");
		NativeFieldInfoPtr_highlightState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WordWrapState>.NativeClassPtr, "highlightState");
		NativeFieldInfoPtr_basicStyleStack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WordWrapState>.NativeClassPtr, "basicStyleStack");
		NativeFieldInfoPtr_italicAngleStack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WordWrapState>.NativeClassPtr, "italicAngleStack");
		NativeFieldInfoPtr_colorStack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WordWrapState>.NativeClassPtr, "colorStack");
		NativeFieldInfoPtr_underlineColorStack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WordWrapState>.NativeClassPtr, "underlineColorStack");
		NativeFieldInfoPtr_strikethroughColorStack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WordWrapState>.NativeClassPtr, "strikethroughColorStack");
		NativeFieldInfoPtr_highlightColorStack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WordWrapState>.NativeClassPtr, "highlightColorStack");
		NativeFieldInfoPtr_highlightStateStack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WordWrapState>.NativeClassPtr, "highlightStateStack");
		NativeFieldInfoPtr_colorGradientStack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WordWrapState>.NativeClassPtr, "colorGradientStack");
		NativeFieldInfoPtr_sizeStack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WordWrapState>.NativeClassPtr, "sizeStack");
		NativeFieldInfoPtr_indentStack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WordWrapState>.NativeClassPtr, "indentStack");
		NativeFieldInfoPtr_fontWeightStack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WordWrapState>.NativeClassPtr, "fontWeightStack");
		NativeFieldInfoPtr_styleStack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WordWrapState>.NativeClassPtr, "styleStack");
		NativeFieldInfoPtr_baselineStack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WordWrapState>.NativeClassPtr, "baselineStack");
		NativeFieldInfoPtr_actionStack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WordWrapState>.NativeClassPtr, "actionStack");
		NativeFieldInfoPtr_materialReferenceStack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WordWrapState>.NativeClassPtr, "materialReferenceStack");
		NativeFieldInfoPtr_lineJustificationStack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WordWrapState>.NativeClassPtr, "lineJustificationStack");
		NativeFieldInfoPtr_lastBaseGlyphIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WordWrapState>.NativeClassPtr, "lastBaseGlyphIndex");
		NativeFieldInfoPtr_spriteAnimationId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WordWrapState>.NativeClassPtr, "spriteAnimationId");
		NativeFieldInfoPtr_currentFontAsset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WordWrapState>.NativeClassPtr, "currentFontAsset");
		NativeFieldInfoPtr_currentSpriteAsset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WordWrapState>.NativeClassPtr, "currentSpriteAsset");
		NativeFieldInfoPtr_currentMaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WordWrapState>.NativeClassPtr, "currentMaterial");
		NativeFieldInfoPtr_currentMaterialIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WordWrapState>.NativeClassPtr, "currentMaterialIndex");
		NativeFieldInfoPtr_meshExtents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WordWrapState>.NativeClassPtr, "meshExtents");
		NativeFieldInfoPtr_tagNoParsing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WordWrapState>.NativeClassPtr, "tagNoParsing");
		NativeFieldInfoPtr_isNonBreakingSpace = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WordWrapState>.NativeClassPtr, "isNonBreakingSpace");
		NativeFieldInfoPtr_isDrivenLineSpacing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WordWrapState>.NativeClassPtr, "isDrivenLineSpacing");
		NativeFieldInfoPtr_fxScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WordWrapState>.NativeClassPtr, "fxScale");
		NativeFieldInfoPtr_fxRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WordWrapState>.NativeClassPtr, "fxRotation");
	}

	public WordWrapState(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public WordWrapState()
		: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WordWrapState>.NativeClassPtr))
	{
	}
}
