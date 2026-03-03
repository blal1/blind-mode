using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.TextCore.Text;

public class TextGenerator : Il2CppSystem.Object
{
	public sealed class MissingCharacterEventCallback : Il2CppSystem.MulticastDelegate
	{
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_UInt32_Int32_TextInfo_FontAsset_0;

		static MissingCharacterEventCallback()
		{
			Il2CppClassPointerStore<MissingCharacterEventCallback>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, "MissingCharacterEventCallback");
			NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MissingCharacterEventCallback>.NativeClassPtr, 100663764);
			NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_UInt32_Int32_TextInfo_FontAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MissingCharacterEventCallback>.NativeClassPtr, 100663765);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1279727, XrefRangeEnd = 1279730, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MissingCharacterEventCallback(Il2CppSystem.Object @object, System.IntPtr method)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MissingCharacterEventCallback>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)@object);
			*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &method;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(0)]
		public unsafe virtual void Invoke(uint unicode, int stringIndex, TextInfo text, FontAsset fontAsset)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[4];
			*ptr = (nint)(&unicode);
			*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &stringIndex;
			*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)text);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)fontAsset);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_UInt32_Int32_TextInfo_FontAsset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		public MissingCharacterEventCallback(System.IntPtr pointer)
			: base(pointer)
		{
		}

		public static implicit operator MissingCharacterEventCallback(System.Action<uint, int, TextInfo, FontAsset> P_0)
		{
			return DelegateSupport.ConvertDelegate<MissingCharacterEventCallback>((System.Delegate)P_0);
		}

		public static MissingCharacterEventCallback operator +(MissingCharacterEventCallback P_0, MissingCharacterEventCallback P_1)
		{
			return ((Il2CppObjectBase)Il2CppSystem.Delegate.Combine(P_0, P_1)).Cast<MissingCharacterEventCallback>();
		}

		public static MissingCharacterEventCallback operator -(MissingCharacterEventCallback P_0, MissingCharacterEventCallback P_1)
		{
			object obj = Il2CppSystem.Delegate.Remove(P_0, P_1);
			if (obj != null)
			{
				obj = ((Il2CppObjectBase)obj).Cast<MissingCharacterEventCallback>();
			}
			return (MissingCharacterEventCallback)obj;
		}
	}

	public sealed class SpecialCharacter : Il2CppSystem.ValueType
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_character;

		private static readonly System.IntPtr NativeFieldInfoPtr_fontAsset;

		private static readonly System.IntPtr NativeFieldInfoPtr_material;

		private static readonly System.IntPtr NativeFieldInfoPtr_materialIndex;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Character_Int32_0;

		public unsafe Character character
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_character);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Character>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_character)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
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

		public unsafe Material material
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_material);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Material>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_material)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe int materialIndex
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_materialIndex);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_materialIndex)) = value;
			}
		}

		static SpecialCharacter()
		{
			Il2CppClassPointerStore<SpecialCharacter>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, "SpecialCharacter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpecialCharacter>.NativeClassPtr);
			NativeFieldInfoPtr_character = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpecialCharacter>.NativeClassPtr, "character");
			NativeFieldInfoPtr_fontAsset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpecialCharacter>.NativeClassPtr, "fontAsset");
			NativeFieldInfoPtr_material = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpecialCharacter>.NativeClassPtr, "material");
			NativeFieldInfoPtr_materialIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpecialCharacter>.NativeClassPtr, "materialIndex");
			NativeMethodInfoPtr__ctor_Public_Void_Character_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpecialCharacter>.NativeClassPtr, 100663766);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1279730, XrefRangeEnd = 1279741, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SpecialCharacter(Character character, int materialIndex)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SpecialCharacter>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)character);
			*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &materialIndex;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Character_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		public SpecialCharacter(System.IntPtr pointer)
			: base(pointer)
		{
		}

		public SpecialCharacter()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SpecialCharacter>.NativeClassPtr))
		{
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_k_Tab;

	private static readonly System.IntPtr NativeFieldInfoPtr_k_LineFeed;

	private static readonly System.IntPtr NativeFieldInfoPtr_k_VerticalTab;

	private static readonly System.IntPtr NativeFieldInfoPtr_k_CarriageReturn;

	private static readonly System.IntPtr NativeFieldInfoPtr_k_Space;

	private static readonly System.IntPtr NativeFieldInfoPtr_k_DoubleQuotes;

	private static readonly System.IntPtr NativeFieldInfoPtr_k_NumberSign;

	private static readonly System.IntPtr NativeFieldInfoPtr_k_PercentSign;

	private static readonly System.IntPtr NativeFieldInfoPtr_k_SingleQuote;

	private static readonly System.IntPtr NativeFieldInfoPtr_k_Plus;

	private static readonly System.IntPtr NativeFieldInfoPtr_k_Period;

	private static readonly System.IntPtr NativeFieldInfoPtr_k_LesserThan;

	private static readonly System.IntPtr NativeFieldInfoPtr_k_Equal;

	private static readonly System.IntPtr NativeFieldInfoPtr_k_GreaterThan;

	private static readonly System.IntPtr NativeFieldInfoPtr_k_Underline;

	private static readonly System.IntPtr NativeFieldInfoPtr_k_NoBreakSpace;

	private static readonly System.IntPtr NativeFieldInfoPtr_k_SoftHyphen;

	private static readonly System.IntPtr NativeFieldInfoPtr_k_HyphenMinus;

	private static readonly System.IntPtr NativeFieldInfoPtr_k_FigureSpace;

	private static readonly System.IntPtr NativeFieldInfoPtr_k_Hyphen;

	private static readonly System.IntPtr NativeFieldInfoPtr_k_NonBreakingHyphen;

	private static readonly System.IntPtr NativeFieldInfoPtr_k_ZeroWidthSpace;

	private static readonly System.IntPtr NativeFieldInfoPtr_k_NarrowNoBreakSpace;

	private static readonly System.IntPtr NativeFieldInfoPtr_k_WordJoiner;

	private static readonly System.IntPtr NativeFieldInfoPtr_k_HorizontalEllipsis;

	private static readonly System.IntPtr NativeFieldInfoPtr_k_LineSeparator;

	private static readonly System.IntPtr NativeFieldInfoPtr_k_ParagraphSeparator;

	private static readonly System.IntPtr NativeFieldInfoPtr_k_RightSingleQuote;

	private static readonly System.IntPtr NativeFieldInfoPtr_k_Square;

	private static readonly System.IntPtr NativeFieldInfoPtr_k_HangulJamoStart;

	private static readonly System.IntPtr NativeFieldInfoPtr_k_HangulJamoEnd;

	private static readonly System.IntPtr NativeFieldInfoPtr_k_CjkStart;

	private static readonly System.IntPtr NativeFieldInfoPtr_k_CjkEnd;

	private static readonly System.IntPtr NativeFieldInfoPtr_k_HangulJameExtendedStart;

	private static readonly System.IntPtr NativeFieldInfoPtr_k_HangulJameExtendedEnd;

	private static readonly System.IntPtr NativeFieldInfoPtr_k_HangulSyllablesStart;

	private static readonly System.IntPtr NativeFieldInfoPtr_k_HangulSyllablesEnd;

	private static readonly System.IntPtr NativeFieldInfoPtr_k_CjkIdeographsStart;

	private static readonly System.IntPtr NativeFieldInfoPtr_k_CjkIdeographsEnd;

	private static readonly System.IntPtr NativeFieldInfoPtr_k_CjkFormsStart;

	private static readonly System.IntPtr NativeFieldInfoPtr_k_CjkFormsEnd;

	private static readonly System.IntPtr NativeFieldInfoPtr_k_CjkHalfwidthStart;

	private static readonly System.IntPtr NativeFieldInfoPtr_k_CjkHalfwidthEnd;

	private static readonly System.IntPtr NativeFieldInfoPtr_k_EndOfText;

	private static readonly System.IntPtr NativeFieldInfoPtr_k_FloatUnset;

	private static readonly System.IntPtr NativeFieldInfoPtr_k_MaxCharacters;

	private static readonly System.IntPtr NativeFieldInfoPtr_s_TextGenerator;

	private static readonly System.IntPtr NativeFieldInfoPtr__IsExecutingJob_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_TextBackingArray;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_TextProcessingArray;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_InternalTextProcessingArraySize;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_VertexBufferAutoSizeReduction;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_HtmlTag;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_HighlightState;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_IsIgnoringAlignment;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_IsTextTruncated;

	private static readonly System.IntPtr NativeFieldInfoPtr_OnMissingCharacter;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_RectTransformCorners;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_MarginWidth;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_MarginHeight;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_PreferredWidth;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_PreferredHeight;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_CurrentFontAsset;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_CurrentMaterial;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_CurrentMaterialIndex;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_MaterialReferenceStack;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_Padding;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_CurrentSpriteAsset;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_TotalCharacterCount;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_FontSize;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_FontScaleMultiplier;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_CurrentFontSize;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_SizeStack;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_TextStyleStacks;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_TextStyleStackDepth;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_FontStyleInternal;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_FontStyleStack;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_FontWeightInternal;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_FontWeightStack;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_LineJustification;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_LineJustificationStack;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_BaselineOffset;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_BaselineOffsetStack;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_FontColor32;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_HtmlColor;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_UnderlineColor;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_StrikethroughColor;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_ColorStack;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_UnderlineColorStack;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_StrikethroughColorStack;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_HighlightColorStack;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_HighlightStateStack;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_ItalicAngleStack;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_ColorGradientPreset;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_ColorGradientStack;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_ColorGradientPresetIsTinted;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_ActionStack;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_LineOffset;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_LineHeight;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_IsDrivenLineSpacing;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_CSpacing;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_MonoSpacing;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_DuoSpace;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_XAdvance;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_TagLineIndent;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_TagIndent;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_IndentStack;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_TagNoParsing;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_CharacterCount;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_FirstCharacterOfLine;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_LastCharacterOfLine;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_FirstVisibleCharacterOfLine;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_LastVisibleCharacterOfLine;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_MaxLineAscender;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_MaxLineDescender;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_LineNumber;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_LineVisibleCharacterCount;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_LineVisibleSpaceCount;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_FirstOverflowCharacterIndex;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_MarginLeft;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_MarginRight;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_Width;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_MeshExtents;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_MaxCapHeight;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_MaxAscender;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_MaxDescender;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_IsNonBreakingSpace;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_SavedWordWrapState;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_SavedLineState;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_SavedEllipsisState;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_SavedLastValidState;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_SavedSoftLineBreakState;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_TextElementType;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_isTextLayoutPhase;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_SpriteIndex;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_SpriteColor;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_CachedTextElement;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_HighlightColor;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_CharWidthAdjDelta;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_MaxFontSize;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_MinFontSize;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_AutoSizeIterationCount;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_AutoSizeMaxIterationCount;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_StartOfLineAscender;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_LineSpacingDelta;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_MaterialReferences;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_SpriteCount;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_StyleStack;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_EllipsisInsertionCandidateStack;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_SpriteAnimationId;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_ItalicAngle;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_FXScale;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_FXRotation;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_LastBaseGlyphIndex;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_PageAscender;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_XmlAttribute;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_AttributeParameterValues;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_MaterialReferenceIndexLookup;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_IsCalculatingPreferredValues;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_TintSprite;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_Ellipsis;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_Underline;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_InternalTextElementInfo;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_IsExecutingJob_Internal_Static_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_IsExecutingJob_Internal_Static_set_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GenerateText_Public_Void_TextGenerationSettings_TextInfo_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_isTextTruncated_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GenerateTextMesh_Internal_Void_TextGenerationSettings_TextInfo_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ValidateHtmlTag_Private_Boolean_Il2CppStructArray_1_TextProcessingElement_Int32_byref_Int32_TextGenerationSettings_TextInfo_byref_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CloseLastLinkTag_Internal_Void_TextInfo_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CloseAllLinkTags_Internal_Void_TextInfo_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CloseLinkTag_Private_Void_TextInfo_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ClearMarkupTagAttributes_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SaveWordWrappingState_Private_Void_byref_WordWrapState_Int32_Int32_TextInfo_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RestoreWordWrappingState_Private_Int32_byref_WordWrapState_TextInfo_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SaveGlyphVertexInfo_Private_Void_Single_Single_Color32_TextGenerationSettings_TextInfo_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SaveSpriteVertexInfo_Private_Void_Color32_TextGenerationSettings_TextInfo_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DrawUnderlineMesh_Private_Void_Vector3_Vector3_Single_Single_Single_Single_Color32_TextGenerationSettings_TextInfo_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DrawTextHighlight_Private_Void_Vector3_Vector3_Color32_TextGenerationSettings_TextInfo_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ClearMesh_Private_Static_Void_Boolean_TextInfo_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LayoutPhase_Public_Void_TextInfo_TextGenerationSettings_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ParsingPhase_Public_Void_TextInfo_TextGenerationSettings_byref_UInt32_byref_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InsertNewLine_Private_Void_Int32_Single_Single_Single_Single_Single_Single_Single_byref_Boolean_byref_Single_TextGenerationSettings_TextInfo_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetPreferredValues_Public_Vector2_TextGenerationSettings_TextInfo_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetPreferredValuesInternal_Private_Vector2_TextGenerationSettings_TextInfo_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CalculatePreferredValues_Protected_Virtual_New_Vector2_byref_Single_Vector2_Boolean_TextGenerationSettings_TextInfo_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Prepare_Internal_Void_TextGenerationSettings_TextInfo_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PrepareFontAsset_Internal_Boolean_TextGenerationSettings_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetArraySizes_Private_Int32_Il2CppStructArray_1_TextProcessingElement_TextGenerationSettings_TextInfo_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetTextElement_Private_TextElement_TextGenerationSettings_UInt32_FontAsset_FontStyles_TextFontWeight_byref_Boolean_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PopulateTextBackingArray_Private_Void_byref_RenderedText_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PopulateTextProcessingArray_Private_Void_TextGenerationSettings_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PopulateFontAsset_Private_Boolean_TextGenerationSettings_Il2CppStructArray_1_TextProcessingElement_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ComputeMarginSize_Private_Void_Rect_Vector4_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetSpecialCharacters_Protected_Boolean_TextGenerationSettings_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetEllipsisSpecialCharacter_Protected_Boolean_TextGenerationSettings_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetUnderlineSpecialCharacter_Protected_Boolean_TextGenerationSettings_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DoMissingGlyphCallback_Protected_Void_UInt32_Int32_FontAsset_TextInfo_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe static int k_Tab
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_k_Tab, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_k_Tab, (void*)(&value));
		}
	}

	public unsafe static int k_LineFeed
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_k_LineFeed, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_k_LineFeed, (void*)(&value));
		}
	}

	public unsafe static int k_VerticalTab
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_k_VerticalTab, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_k_VerticalTab, (void*)(&value));
		}
	}

	public unsafe static int k_CarriageReturn
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_k_CarriageReturn, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_k_CarriageReturn, (void*)(&value));
		}
	}

	public unsafe static int k_Space
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_k_Space, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_k_Space, (void*)(&value));
		}
	}

	public unsafe static int k_DoubleQuotes
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_k_DoubleQuotes, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_k_DoubleQuotes, (void*)(&value));
		}
	}

	public unsafe static int k_NumberSign
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_k_NumberSign, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_k_NumberSign, (void*)(&value));
		}
	}

	public unsafe static int k_PercentSign
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_k_PercentSign, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_k_PercentSign, (void*)(&value));
		}
	}

	public unsafe static int k_SingleQuote
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_k_SingleQuote, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_k_SingleQuote, (void*)(&value));
		}
	}

	public unsafe static int k_Plus
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_k_Plus, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_k_Plus, (void*)(&value));
		}
	}

	public unsafe static int k_Period
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_k_Period, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_k_Period, (void*)(&value));
		}
	}

	public unsafe static int k_LesserThan
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_k_LesserThan, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_k_LesserThan, (void*)(&value));
		}
	}

	public unsafe static int k_Equal
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_k_Equal, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_k_Equal, (void*)(&value));
		}
	}

	public unsafe static int k_GreaterThan
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_k_GreaterThan, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_k_GreaterThan, (void*)(&value));
		}
	}

	public unsafe static int k_Underline
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_k_Underline, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_k_Underline, (void*)(&value));
		}
	}

	public unsafe static int k_NoBreakSpace
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_k_NoBreakSpace, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_k_NoBreakSpace, (void*)(&value));
		}
	}

	public unsafe static int k_SoftHyphen
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_k_SoftHyphen, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_k_SoftHyphen, (void*)(&value));
		}
	}

	public unsafe static int k_HyphenMinus
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_k_HyphenMinus, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_k_HyphenMinus, (void*)(&value));
		}
	}

	public unsafe static int k_FigureSpace
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_k_FigureSpace, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_k_FigureSpace, (void*)(&value));
		}
	}

	public unsafe static int k_Hyphen
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_k_Hyphen, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_k_Hyphen, (void*)(&value));
		}
	}

	public unsafe static int k_NonBreakingHyphen
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_k_NonBreakingHyphen, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_k_NonBreakingHyphen, (void*)(&value));
		}
	}

	public unsafe static int k_ZeroWidthSpace
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_k_ZeroWidthSpace, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_k_ZeroWidthSpace, (void*)(&value));
		}
	}

	public unsafe static int k_NarrowNoBreakSpace
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_k_NarrowNoBreakSpace, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_k_NarrowNoBreakSpace, (void*)(&value));
		}
	}

	public unsafe static int k_WordJoiner
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_k_WordJoiner, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_k_WordJoiner, (void*)(&value));
		}
	}

	public unsafe static int k_HorizontalEllipsis
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_k_HorizontalEllipsis, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_k_HorizontalEllipsis, (void*)(&value));
		}
	}

	public unsafe static int k_LineSeparator
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_k_LineSeparator, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_k_LineSeparator, (void*)(&value));
		}
	}

	public unsafe static int k_ParagraphSeparator
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_k_ParagraphSeparator, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_k_ParagraphSeparator, (void*)(&value));
		}
	}

	public unsafe static int k_RightSingleQuote
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_k_RightSingleQuote, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_k_RightSingleQuote, (void*)(&value));
		}
	}

	public unsafe static int k_Square
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_k_Square, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_k_Square, (void*)(&value));
		}
	}

	public unsafe static int k_HangulJamoStart
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_k_HangulJamoStart, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_k_HangulJamoStart, (void*)(&value));
		}
	}

	public unsafe static int k_HangulJamoEnd
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_k_HangulJamoEnd, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_k_HangulJamoEnd, (void*)(&value));
		}
	}

	public unsafe static int k_CjkStart
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_k_CjkStart, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_k_CjkStart, (void*)(&value));
		}
	}

	public unsafe static int k_CjkEnd
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_k_CjkEnd, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_k_CjkEnd, (void*)(&value));
		}
	}

	public unsafe static int k_HangulJameExtendedStart
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_k_HangulJameExtendedStart, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_k_HangulJameExtendedStart, (void*)(&value));
		}
	}

	public unsafe static int k_HangulJameExtendedEnd
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_k_HangulJameExtendedEnd, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_k_HangulJameExtendedEnd, (void*)(&value));
		}
	}

	public unsafe static int k_HangulSyllablesStart
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_k_HangulSyllablesStart, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_k_HangulSyllablesStart, (void*)(&value));
		}
	}

	public unsafe static int k_HangulSyllablesEnd
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_k_HangulSyllablesEnd, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_k_HangulSyllablesEnd, (void*)(&value));
		}
	}

	public unsafe static int k_CjkIdeographsStart
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_k_CjkIdeographsStart, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_k_CjkIdeographsStart, (void*)(&value));
		}
	}

	public unsafe static int k_CjkIdeographsEnd
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_k_CjkIdeographsEnd, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_k_CjkIdeographsEnd, (void*)(&value));
		}
	}

	public unsafe static int k_CjkFormsStart
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_k_CjkFormsStart, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_k_CjkFormsStart, (void*)(&value));
		}
	}

	public unsafe static int k_CjkFormsEnd
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_k_CjkFormsEnd, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_k_CjkFormsEnd, (void*)(&value));
		}
	}

	public unsafe static int k_CjkHalfwidthStart
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_k_CjkHalfwidthStart, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_k_CjkHalfwidthStart, (void*)(&value));
		}
	}

	public unsafe static int k_CjkHalfwidthEnd
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_k_CjkHalfwidthEnd, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_k_CjkHalfwidthEnd, (void*)(&value));
		}
	}

	public unsafe static int k_EndOfText
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_k_EndOfText, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_k_EndOfText, (void*)(&value));
		}
	}

	public unsafe static float k_FloatUnset
	{
		get
		{
			Unsafe.SkipInit(out float result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_k_FloatUnset, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_k_FloatUnset, (void*)(&value));
		}
	}

	public unsafe static int k_MaxCharacters
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_k_MaxCharacters, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_k_MaxCharacters, (void*)(&value));
		}
	}

	public unsafe static TextGenerator s_TextGenerator
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_TextGenerator, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<TextGenerator>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_TextGenerator, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static bool _IsExecutingJob_k__BackingField
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__IsExecutingJob_k__BackingField, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__IsExecutingJob_k__BackingField, (void*)(&value));
		}
	}

	public unsafe TextBackingContainer m_TextBackingArray
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_TextBackingArray);
			return new TextBackingContainer(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TextBackingContainer>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_TextBackingArray), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TextBackingContainer>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe Il2CppStructArray<TextProcessingElement> m_TextProcessingArray
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_TextProcessingArray);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<TextProcessingElement>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_TextProcessingArray)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe int m_InternalTextProcessingArraySize
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_InternalTextProcessingArraySize);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_InternalTextProcessingArraySize)) = value;
		}
	}

	public unsafe bool m_VertexBufferAutoSizeReduction
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_VertexBufferAutoSizeReduction);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_VertexBufferAutoSizeReduction)) = value;
		}
	}

	public unsafe Il2CppStructArray<char> m_HtmlTag
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_HtmlTag);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<char>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_HtmlTag)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe HighlightState m_HighlightState
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_HighlightState);
			return *(HighlightState*)num;
		}
		set
		{
			*(HighlightState*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_HighlightState)) = value;
		}
	}

	public unsafe bool m_IsIgnoringAlignment
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_IsIgnoringAlignment);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_IsIgnoringAlignment)) = value;
		}
	}

	public unsafe bool m_IsTextTruncated
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_IsTextTruncated);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_IsTextTruncated)) = value;
		}
	}

	public unsafe static MissingCharacterEventCallback OnMissingCharacter
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_OnMissingCharacter, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<MissingCharacterEventCallback>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_OnMissingCharacter, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe Il2CppStructArray<Vector3> m_RectTransformCorners
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_RectTransformCorners);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector3>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_RectTransformCorners)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe float m_MarginWidth
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_MarginWidth);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_MarginWidth)) = value;
		}
	}

	public unsafe float m_MarginHeight
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_MarginHeight);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_MarginHeight)) = value;
		}
	}

	public unsafe float m_PreferredWidth
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_PreferredWidth);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_PreferredWidth)) = value;
		}
	}

	public unsafe float m_PreferredHeight
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_PreferredHeight);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_PreferredHeight)) = value;
		}
	}

	public unsafe FontAsset m_CurrentFontAsset
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_CurrentFontAsset);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<FontAsset>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_CurrentFontAsset)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe Material m_CurrentMaterial
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_CurrentMaterial);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Material>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_CurrentMaterial)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe int m_CurrentMaterialIndex
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_CurrentMaterialIndex);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_CurrentMaterialIndex)) = value;
		}
	}

	public unsafe TextProcessingStack<MaterialReference> m_MaterialReferenceStack
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_MaterialReferenceStack);
			return new TextProcessingStack<MaterialReference>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TextProcessingStack<MaterialReference>>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_MaterialReferenceStack), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TextProcessingStack<MaterialReference>>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe float m_Padding
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Padding);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Padding)) = value;
		}
	}

	public unsafe SpriteAsset m_CurrentSpriteAsset
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_CurrentSpriteAsset);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<SpriteAsset>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_CurrentSpriteAsset)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe int m_TotalCharacterCount
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_TotalCharacterCount);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_TotalCharacterCount)) = value;
		}
	}

	public unsafe float m_FontSize
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_FontSize);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_FontSize)) = value;
		}
	}

	public unsafe float m_FontScaleMultiplier
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_FontScaleMultiplier);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_FontScaleMultiplier)) = value;
		}
	}

	public unsafe float m_CurrentFontSize
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_CurrentFontSize);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_CurrentFontSize)) = value;
		}
	}

	public unsafe TextProcessingStack<float> m_SizeStack
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_SizeStack);
			return new TextProcessingStack<float>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TextProcessingStack<float>>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_SizeStack), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TextProcessingStack<float>>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe Il2CppReferenceArray<TextProcessingStack<int>> m_TextStyleStacks
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_TextStyleStacks);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<TextProcessingStack<int>>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_TextStyleStacks)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe int m_TextStyleStackDepth
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_TextStyleStackDepth);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_TextStyleStackDepth)) = value;
		}
	}

	public unsafe FontStyles m_FontStyleInternal
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_FontStyleInternal);
			return *(FontStyles*)num;
		}
		set
		{
			*(FontStyles*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_FontStyleInternal)) = value;
		}
	}

	public unsafe FontStyleStack m_FontStyleStack
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_FontStyleStack);
			return *(FontStyleStack*)num;
		}
		set
		{
			*(FontStyleStack*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_FontStyleStack)) = value;
		}
	}

	public unsafe TextFontWeight m_FontWeightInternal
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_FontWeightInternal);
			return *(TextFontWeight*)num;
		}
		set
		{
			*(TextFontWeight*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_FontWeightInternal)) = value;
		}
	}

	public unsafe TextProcessingStack<TextFontWeight> m_FontWeightStack
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_FontWeightStack);
			return new TextProcessingStack<TextFontWeight>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TextProcessingStack<TextFontWeight>>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_FontWeightStack), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TextProcessingStack<TextFontWeight>>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe TextAlignment m_LineJustification
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_LineJustification);
			return *(TextAlignment*)num;
		}
		set
		{
			*(TextAlignment*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_LineJustification)) = value;
		}
	}

	public unsafe TextProcessingStack<TextAlignment> m_LineJustificationStack
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_LineJustificationStack);
			return new TextProcessingStack<TextAlignment>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TextProcessingStack<TextAlignment>>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_LineJustificationStack), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TextProcessingStack<TextAlignment>>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe float m_BaselineOffset
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_BaselineOffset);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_BaselineOffset)) = value;
		}
	}

	public unsafe TextProcessingStack<float> m_BaselineOffsetStack
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_BaselineOffsetStack);
			return new TextProcessingStack<float>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TextProcessingStack<float>>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_BaselineOffsetStack), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TextProcessingStack<float>>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe Color32 m_FontColor32
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_FontColor32);
			return *(Color32*)num;
		}
		set
		{
			*(Color32*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_FontColor32)) = value;
		}
	}

	public unsafe Color32 m_HtmlColor
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_HtmlColor);
			return *(Color32*)num;
		}
		set
		{
			*(Color32*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_HtmlColor)) = value;
		}
	}

	public unsafe Color32 m_UnderlineColor
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_UnderlineColor);
			return *(Color32*)num;
		}
		set
		{
			*(Color32*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_UnderlineColor)) = value;
		}
	}

	public unsafe Color32 m_StrikethroughColor
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_StrikethroughColor);
			return *(Color32*)num;
		}
		set
		{
			*(Color32*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_StrikethroughColor)) = value;
		}
	}

	public unsafe TextProcessingStack<Color32> m_ColorStack
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ColorStack);
			return new TextProcessingStack<Color32>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TextProcessingStack<Color32>>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ColorStack), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TextProcessingStack<Color32>>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe TextProcessingStack<Color32> m_UnderlineColorStack
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_UnderlineColorStack);
			return new TextProcessingStack<Color32>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TextProcessingStack<Color32>>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_UnderlineColorStack), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TextProcessingStack<Color32>>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe TextProcessingStack<Color32> m_StrikethroughColorStack
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_StrikethroughColorStack);
			return new TextProcessingStack<Color32>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TextProcessingStack<Color32>>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_StrikethroughColorStack), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TextProcessingStack<Color32>>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe TextProcessingStack<Color32> m_HighlightColorStack
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_HighlightColorStack);
			return new TextProcessingStack<Color32>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TextProcessingStack<Color32>>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_HighlightColorStack), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TextProcessingStack<Color32>>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe TextProcessingStack<HighlightState> m_HighlightStateStack
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_HighlightStateStack);
			return new TextProcessingStack<HighlightState>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TextProcessingStack<HighlightState>>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_HighlightStateStack), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TextProcessingStack<HighlightState>>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe TextProcessingStack<int> m_ItalicAngleStack
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ItalicAngleStack);
			return new TextProcessingStack<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TextProcessingStack<int>>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ItalicAngleStack), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TextProcessingStack<int>>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe TextColorGradient m_ColorGradientPreset
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ColorGradientPreset);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<TextColorGradient>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ColorGradientPreset)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe TextProcessingStack<TextColorGradient> m_ColorGradientStack
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ColorGradientStack);
			return new TextProcessingStack<TextColorGradient>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TextProcessingStack<TextColorGradient>>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ColorGradientStack), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TextProcessingStack<TextColorGradient>>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe bool m_ColorGradientPresetIsTinted
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ColorGradientPresetIsTinted);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ColorGradientPresetIsTinted)) = value;
		}
	}

	public unsafe TextProcessingStack<int> m_ActionStack
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ActionStack);
			return new TextProcessingStack<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TextProcessingStack<int>>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ActionStack), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TextProcessingStack<int>>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe float m_LineOffset
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_LineOffset);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_LineOffset)) = value;
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

	public unsafe bool m_IsDrivenLineSpacing
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_IsDrivenLineSpacing);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_IsDrivenLineSpacing)) = value;
		}
	}

	public unsafe float m_CSpacing
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_CSpacing);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_CSpacing)) = value;
		}
	}

	public unsafe float m_MonoSpacing
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_MonoSpacing);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_MonoSpacing)) = value;
		}
	}

	public unsafe bool m_DuoSpace
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_DuoSpace);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_DuoSpace)) = value;
		}
	}

	public unsafe float m_XAdvance
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_XAdvance);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_XAdvance)) = value;
		}
	}

	public unsafe float m_TagLineIndent
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_TagLineIndent);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_TagLineIndent)) = value;
		}
	}

	public unsafe float m_TagIndent
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_TagIndent);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_TagIndent)) = value;
		}
	}

	public unsafe TextProcessingStack<float> m_IndentStack
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_IndentStack);
			return new TextProcessingStack<float>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TextProcessingStack<float>>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_IndentStack), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TextProcessingStack<float>>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe bool m_TagNoParsing
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_TagNoParsing);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_TagNoParsing)) = value;
		}
	}

	public unsafe int m_CharacterCount
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_CharacterCount);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_CharacterCount)) = value;
		}
	}

	public unsafe int m_FirstCharacterOfLine
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_FirstCharacterOfLine);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_FirstCharacterOfLine)) = value;
		}
	}

	public unsafe int m_LastCharacterOfLine
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_LastCharacterOfLine);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_LastCharacterOfLine)) = value;
		}
	}

	public unsafe int m_FirstVisibleCharacterOfLine
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_FirstVisibleCharacterOfLine);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_FirstVisibleCharacterOfLine)) = value;
		}
	}

	public unsafe int m_LastVisibleCharacterOfLine
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_LastVisibleCharacterOfLine);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_LastVisibleCharacterOfLine)) = value;
		}
	}

	public unsafe float m_MaxLineAscender
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_MaxLineAscender);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_MaxLineAscender)) = value;
		}
	}

	public unsafe float m_MaxLineDescender
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_MaxLineDescender);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_MaxLineDescender)) = value;
		}
	}

	public unsafe int m_LineNumber
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_LineNumber);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_LineNumber)) = value;
		}
	}

	public unsafe int m_LineVisibleCharacterCount
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_LineVisibleCharacterCount);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_LineVisibleCharacterCount)) = value;
		}
	}

	public unsafe int m_LineVisibleSpaceCount
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_LineVisibleSpaceCount);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_LineVisibleSpaceCount)) = value;
		}
	}

	public unsafe int m_FirstOverflowCharacterIndex
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_FirstOverflowCharacterIndex);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_FirstOverflowCharacterIndex)) = value;
		}
	}

	public unsafe float m_MarginLeft
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_MarginLeft);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_MarginLeft)) = value;
		}
	}

	public unsafe float m_MarginRight
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_MarginRight);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_MarginRight)) = value;
		}
	}

	public unsafe float m_Width
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Width);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Width)) = value;
		}
	}

	public unsafe Extents m_MeshExtents
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_MeshExtents);
			return *(Extents*)num;
		}
		set
		{
			*(Extents*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_MeshExtents)) = value;
		}
	}

	public unsafe float m_MaxCapHeight
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_MaxCapHeight);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_MaxCapHeight)) = value;
		}
	}

	public unsafe float m_MaxAscender
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_MaxAscender);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_MaxAscender)) = value;
		}
	}

	public unsafe float m_MaxDescender
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_MaxDescender);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_MaxDescender)) = value;
		}
	}

	public unsafe bool m_IsNonBreakingSpace
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_IsNonBreakingSpace);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_IsNonBreakingSpace)) = value;
		}
	}

	public unsafe WordWrapState m_SavedWordWrapState
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_SavedWordWrapState);
			return new WordWrapState(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<WordWrapState>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_SavedWordWrapState), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<WordWrapState>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe WordWrapState m_SavedLineState
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_SavedLineState);
			return new WordWrapState(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<WordWrapState>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_SavedLineState), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<WordWrapState>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe WordWrapState m_SavedEllipsisState
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_SavedEllipsisState);
			return new WordWrapState(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<WordWrapState>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_SavedEllipsisState), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<WordWrapState>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe WordWrapState m_SavedLastValidState
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_SavedLastValidState);
			return new WordWrapState(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<WordWrapState>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_SavedLastValidState), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<WordWrapState>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe WordWrapState m_SavedSoftLineBreakState
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_SavedSoftLineBreakState);
			return new WordWrapState(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<WordWrapState>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_SavedSoftLineBreakState), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<WordWrapState>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe TextElementType m_TextElementType
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_TextElementType);
			return *(TextElementType*)num;
		}
		set
		{
			*(TextElementType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_TextElementType)) = value;
		}
	}

	public unsafe bool m_isTextLayoutPhase
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_isTextLayoutPhase);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_isTextLayoutPhase)) = value;
		}
	}

	public unsafe int m_SpriteIndex
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_SpriteIndex);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_SpriteIndex)) = value;
		}
	}

	public unsafe Color32 m_SpriteColor
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_SpriteColor);
			return *(Color32*)num;
		}
		set
		{
			*(Color32*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_SpriteColor)) = value;
		}
	}

	public unsafe TextElement m_CachedTextElement
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_CachedTextElement);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<TextElement>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_CachedTextElement)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe Color32 m_HighlightColor
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_HighlightColor);
			return *(Color32*)num;
		}
		set
		{
			*(Color32*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_HighlightColor)) = value;
		}
	}

	public unsafe float m_CharWidthAdjDelta
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_CharWidthAdjDelta);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_CharWidthAdjDelta)) = value;
		}
	}

	public unsafe float m_MaxFontSize
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_MaxFontSize);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_MaxFontSize)) = value;
		}
	}

	public unsafe float m_MinFontSize
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_MinFontSize);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_MinFontSize)) = value;
		}
	}

	public unsafe int m_AutoSizeIterationCount
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_AutoSizeIterationCount);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_AutoSizeIterationCount)) = value;
		}
	}

	public unsafe int m_AutoSizeMaxIterationCount
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_AutoSizeMaxIterationCount);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_AutoSizeMaxIterationCount)) = value;
		}
	}

	public unsafe float m_StartOfLineAscender
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_StartOfLineAscender);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_StartOfLineAscender)) = value;
		}
	}

	public unsafe float m_LineSpacingDelta
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_LineSpacingDelta);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_LineSpacingDelta)) = value;
		}
	}

	public unsafe Il2CppReferenceArray<MaterialReference> m_MaterialReferences
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_MaterialReferences);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<MaterialReference>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_MaterialReferences)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe int m_SpriteCount
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_SpriteCount);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_SpriteCount)) = value;
		}
	}

	public unsafe TextProcessingStack<int> m_StyleStack
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_StyleStack);
			return new TextProcessingStack<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TextProcessingStack<int>>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_StyleStack), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TextProcessingStack<int>>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe TextProcessingStack<WordWrapState> m_EllipsisInsertionCandidateStack
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_EllipsisInsertionCandidateStack);
			return new TextProcessingStack<WordWrapState>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TextProcessingStack<WordWrapState>>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_EllipsisInsertionCandidateStack), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TextProcessingStack<WordWrapState>>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe int m_SpriteAnimationId
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_SpriteAnimationId);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_SpriteAnimationId)) = value;
		}
	}

	public unsafe int m_ItalicAngle
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ItalicAngle);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ItalicAngle)) = value;
		}
	}

	public unsafe Vector3 m_FXScale
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_FXScale);
			return *(Vector3*)num;
		}
		set
		{
			*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_FXScale)) = value;
		}
	}

	public unsafe Quaternion m_FXRotation
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_FXRotation);
			return *(Quaternion*)num;
		}
		set
		{
			*(Quaternion*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_FXRotation)) = value;
		}
	}

	public unsafe int m_LastBaseGlyphIndex
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_LastBaseGlyphIndex);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_LastBaseGlyphIndex)) = value;
		}
	}

	public unsafe float m_PageAscender
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_PageAscender);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_PageAscender)) = value;
		}
	}

	public unsafe Il2CppStructArray<RichTextTagAttribute> m_XmlAttribute
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_XmlAttribute);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<RichTextTagAttribute>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_XmlAttribute)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe Il2CppStructArray<float> m_AttributeParameterValues
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_AttributeParameterValues);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<float>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_AttributeParameterValues)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe Dictionary<int, int> m_MaterialReferenceIndexLookup
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_MaterialReferenceIndexLookup);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<int, int>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_MaterialReferenceIndexLookup)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe bool m_IsCalculatingPreferredValues
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_IsCalculatingPreferredValues);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_IsCalculatingPreferredValues)) = value;
		}
	}

	public unsafe bool m_TintSprite
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_TintSprite);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_TintSprite)) = value;
		}
	}

	public unsafe SpecialCharacter m_Ellipsis
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Ellipsis);
			return new SpecialCharacter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SpecialCharacter>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Ellipsis), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<SpecialCharacter>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe SpecialCharacter m_Underline
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Underline);
			return new SpecialCharacter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SpecialCharacter>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Underline), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<SpecialCharacter>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe Il2CppReferenceArray<TextElementInfo> m_InternalTextElementInfo
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_InternalTextElementInfo);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<TextElementInfo>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_InternalTextElementInfo)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static bool IsExecutingJob
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1279741, XrefRangeEnd = 1279743, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_IsExecutingJob_Internal_Static_get_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1279743, XrefRangeEnd = 1279745, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_IsExecutingJob_Internal_Static_set_Void_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe bool isTextTruncated
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1279762, RefRangeEnd = 1279763, XrefRangeStart = 1279762, XrefRangeEnd = 1279762, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_isTextTruncated_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public bool vertexBufferAutoSizeReduction
	{
		get
		{
			return m_VertexBufferAutoSizeReduction;
		}
		set
		{
			m_VertexBufferAutoSizeReduction = value;
		}
	}

	static TextGenerator()
	{
		Il2CppClassPointerStore<TextGenerator>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.TextCoreTextEngineModule.dll", "UnityEngine.TextCore.Text", "TextGenerator");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr);
		NativeFieldInfoPtr_k_Tab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, "k_Tab");
		NativeFieldInfoPtr_k_LineFeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, "k_LineFeed");
		NativeFieldInfoPtr_k_VerticalTab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, "k_VerticalTab");
		NativeFieldInfoPtr_k_CarriageReturn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, "k_CarriageReturn");
		NativeFieldInfoPtr_k_Space = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, "k_Space");
		NativeFieldInfoPtr_k_DoubleQuotes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, "k_DoubleQuotes");
		NativeFieldInfoPtr_k_NumberSign = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, "k_NumberSign");
		NativeFieldInfoPtr_k_PercentSign = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, "k_PercentSign");
		NativeFieldInfoPtr_k_SingleQuote = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, "k_SingleQuote");
		NativeFieldInfoPtr_k_Plus = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, "k_Plus");
		NativeFieldInfoPtr_k_Period = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, "k_Period");
		NativeFieldInfoPtr_k_LesserThan = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, "k_LesserThan");
		NativeFieldInfoPtr_k_Equal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, "k_Equal");
		NativeFieldInfoPtr_k_GreaterThan = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, "k_GreaterThan");
		NativeFieldInfoPtr_k_Underline = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, "k_Underline");
		NativeFieldInfoPtr_k_NoBreakSpace = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, "k_NoBreakSpace");
		NativeFieldInfoPtr_k_SoftHyphen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, "k_SoftHyphen");
		NativeFieldInfoPtr_k_HyphenMinus = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, "k_HyphenMinus");
		NativeFieldInfoPtr_k_FigureSpace = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, "k_FigureSpace");
		NativeFieldInfoPtr_k_Hyphen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, "k_Hyphen");
		NativeFieldInfoPtr_k_NonBreakingHyphen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, "k_NonBreakingHyphen");
		NativeFieldInfoPtr_k_ZeroWidthSpace = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, "k_ZeroWidthSpace");
		NativeFieldInfoPtr_k_NarrowNoBreakSpace = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, "k_NarrowNoBreakSpace");
		NativeFieldInfoPtr_k_WordJoiner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, "k_WordJoiner");
		NativeFieldInfoPtr_k_HorizontalEllipsis = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, "k_HorizontalEllipsis");
		NativeFieldInfoPtr_k_LineSeparator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, "k_LineSeparator");
		NativeFieldInfoPtr_k_ParagraphSeparator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, "k_ParagraphSeparator");
		NativeFieldInfoPtr_k_RightSingleQuote = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, "k_RightSingleQuote");
		NativeFieldInfoPtr_k_Square = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, "k_Square");
		NativeFieldInfoPtr_k_HangulJamoStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, "k_HangulJamoStart");
		NativeFieldInfoPtr_k_HangulJamoEnd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, "k_HangulJamoEnd");
		NativeFieldInfoPtr_k_CjkStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, "k_CjkStart");
		NativeFieldInfoPtr_k_CjkEnd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, "k_CjkEnd");
		NativeFieldInfoPtr_k_HangulJameExtendedStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, "k_HangulJameExtendedStart");
		NativeFieldInfoPtr_k_HangulJameExtendedEnd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, "k_HangulJameExtendedEnd");
		NativeFieldInfoPtr_k_HangulSyllablesStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, "k_HangulSyllablesStart");
		NativeFieldInfoPtr_k_HangulSyllablesEnd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, "k_HangulSyllablesEnd");
		NativeFieldInfoPtr_k_CjkIdeographsStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, "k_CjkIdeographsStart");
		NativeFieldInfoPtr_k_CjkIdeographsEnd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, "k_CjkIdeographsEnd");
		NativeFieldInfoPtr_k_CjkFormsStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, "k_CjkFormsStart");
		NativeFieldInfoPtr_k_CjkFormsEnd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, "k_CjkFormsEnd");
		NativeFieldInfoPtr_k_CjkHalfwidthStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, "k_CjkHalfwidthStart");
		NativeFieldInfoPtr_k_CjkHalfwidthEnd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, "k_CjkHalfwidthEnd");
		NativeFieldInfoPtr_k_EndOfText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, "k_EndOfText");
		NativeFieldInfoPtr_k_FloatUnset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, "k_FloatUnset");
		NativeFieldInfoPtr_k_MaxCharacters = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, "k_MaxCharacters");
		NativeFieldInfoPtr_s_TextGenerator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, "s_TextGenerator");
		NativeFieldInfoPtr__IsExecutingJob_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, "<IsExecutingJob>k__BackingField");
		NativeFieldInfoPtr_m_TextBackingArray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, "m_TextBackingArray");
		NativeFieldInfoPtr_m_TextProcessingArray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, "m_TextProcessingArray");
		NativeFieldInfoPtr_m_InternalTextProcessingArraySize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, "m_InternalTextProcessingArraySize");
		NativeFieldInfoPtr_m_VertexBufferAutoSizeReduction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, "m_VertexBufferAutoSizeReduction");
		NativeFieldInfoPtr_m_HtmlTag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, "m_HtmlTag");
		NativeFieldInfoPtr_m_HighlightState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, "m_HighlightState");
		NativeFieldInfoPtr_m_IsIgnoringAlignment = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, "m_IsIgnoringAlignment");
		NativeFieldInfoPtr_m_IsTextTruncated = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, "m_IsTextTruncated");
		NativeFieldInfoPtr_OnMissingCharacter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, "OnMissingCharacter");
		NativeFieldInfoPtr_m_RectTransformCorners = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, "m_RectTransformCorners");
		NativeFieldInfoPtr_m_MarginWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, "m_MarginWidth");
		NativeFieldInfoPtr_m_MarginHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, "m_MarginHeight");
		NativeFieldInfoPtr_m_PreferredWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, "m_PreferredWidth");
		NativeFieldInfoPtr_m_PreferredHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, "m_PreferredHeight");
		NativeFieldInfoPtr_m_CurrentFontAsset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, "m_CurrentFontAsset");
		NativeFieldInfoPtr_m_CurrentMaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, "m_CurrentMaterial");
		NativeFieldInfoPtr_m_CurrentMaterialIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, "m_CurrentMaterialIndex");
		NativeFieldInfoPtr_m_MaterialReferenceStack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, "m_MaterialReferenceStack");
		NativeFieldInfoPtr_m_Padding = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, "m_Padding");
		NativeFieldInfoPtr_m_CurrentSpriteAsset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, "m_CurrentSpriteAsset");
		NativeFieldInfoPtr_m_TotalCharacterCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, "m_TotalCharacterCount");
		NativeFieldInfoPtr_m_FontSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, "m_FontSize");
		NativeFieldInfoPtr_m_FontScaleMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, "m_FontScaleMultiplier");
		NativeFieldInfoPtr_m_CurrentFontSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, "m_CurrentFontSize");
		NativeFieldInfoPtr_m_SizeStack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, "m_SizeStack");
		NativeFieldInfoPtr_m_TextStyleStacks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, "m_TextStyleStacks");
		NativeFieldInfoPtr_m_TextStyleStackDepth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, "m_TextStyleStackDepth");
		NativeFieldInfoPtr_m_FontStyleInternal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, "m_FontStyleInternal");
		NativeFieldInfoPtr_m_FontStyleStack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, "m_FontStyleStack");
		NativeFieldInfoPtr_m_FontWeightInternal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, "m_FontWeightInternal");
		NativeFieldInfoPtr_m_FontWeightStack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, "m_FontWeightStack");
		NativeFieldInfoPtr_m_LineJustification = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, "m_LineJustification");
		NativeFieldInfoPtr_m_LineJustificationStack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, "m_LineJustificationStack");
		NativeFieldInfoPtr_m_BaselineOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, "m_BaselineOffset");
		NativeFieldInfoPtr_m_BaselineOffsetStack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, "m_BaselineOffsetStack");
		NativeFieldInfoPtr_m_FontColor32 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, "m_FontColor32");
		NativeFieldInfoPtr_m_HtmlColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, "m_HtmlColor");
		NativeFieldInfoPtr_m_UnderlineColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, "m_UnderlineColor");
		NativeFieldInfoPtr_m_StrikethroughColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, "m_StrikethroughColor");
		NativeFieldInfoPtr_m_ColorStack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, "m_ColorStack");
		NativeFieldInfoPtr_m_UnderlineColorStack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, "m_UnderlineColorStack");
		NativeFieldInfoPtr_m_StrikethroughColorStack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, "m_StrikethroughColorStack");
		NativeFieldInfoPtr_m_HighlightColorStack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, "m_HighlightColorStack");
		NativeFieldInfoPtr_m_HighlightStateStack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, "m_HighlightStateStack");
		NativeFieldInfoPtr_m_ItalicAngleStack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, "m_ItalicAngleStack");
		NativeFieldInfoPtr_m_ColorGradientPreset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, "m_ColorGradientPreset");
		NativeFieldInfoPtr_m_ColorGradientStack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, "m_ColorGradientStack");
		NativeFieldInfoPtr_m_ColorGradientPresetIsTinted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, "m_ColorGradientPresetIsTinted");
		NativeFieldInfoPtr_m_ActionStack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, "m_ActionStack");
		NativeFieldInfoPtr_m_LineOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, "m_LineOffset");
		NativeFieldInfoPtr_m_LineHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, "m_LineHeight");
		NativeFieldInfoPtr_m_IsDrivenLineSpacing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, "m_IsDrivenLineSpacing");
		NativeFieldInfoPtr_m_CSpacing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, "m_CSpacing");
		NativeFieldInfoPtr_m_MonoSpacing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, "m_MonoSpacing");
		NativeFieldInfoPtr_m_DuoSpace = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, "m_DuoSpace");
		NativeFieldInfoPtr_m_XAdvance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, "m_XAdvance");
		NativeFieldInfoPtr_m_TagLineIndent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, "m_TagLineIndent");
		NativeFieldInfoPtr_m_TagIndent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, "m_TagIndent");
		NativeFieldInfoPtr_m_IndentStack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, "m_IndentStack");
		NativeFieldInfoPtr_m_TagNoParsing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, "m_TagNoParsing");
		NativeFieldInfoPtr_m_CharacterCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, "m_CharacterCount");
		NativeFieldInfoPtr_m_FirstCharacterOfLine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, "m_FirstCharacterOfLine");
		NativeFieldInfoPtr_m_LastCharacterOfLine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, "m_LastCharacterOfLine");
		NativeFieldInfoPtr_m_FirstVisibleCharacterOfLine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, "m_FirstVisibleCharacterOfLine");
		NativeFieldInfoPtr_m_LastVisibleCharacterOfLine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, "m_LastVisibleCharacterOfLine");
		NativeFieldInfoPtr_m_MaxLineAscender = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, "m_MaxLineAscender");
		NativeFieldInfoPtr_m_MaxLineDescender = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, "m_MaxLineDescender");
		NativeFieldInfoPtr_m_LineNumber = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, "m_LineNumber");
		NativeFieldInfoPtr_m_LineVisibleCharacterCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, "m_LineVisibleCharacterCount");
		NativeFieldInfoPtr_m_LineVisibleSpaceCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, "m_LineVisibleSpaceCount");
		NativeFieldInfoPtr_m_FirstOverflowCharacterIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, "m_FirstOverflowCharacterIndex");
		NativeFieldInfoPtr_m_MarginLeft = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, "m_MarginLeft");
		NativeFieldInfoPtr_m_MarginRight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, "m_MarginRight");
		NativeFieldInfoPtr_m_Width = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, "m_Width");
		NativeFieldInfoPtr_m_MeshExtents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, "m_MeshExtents");
		NativeFieldInfoPtr_m_MaxCapHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, "m_MaxCapHeight");
		NativeFieldInfoPtr_m_MaxAscender = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, "m_MaxAscender");
		NativeFieldInfoPtr_m_MaxDescender = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, "m_MaxDescender");
		NativeFieldInfoPtr_m_IsNonBreakingSpace = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, "m_IsNonBreakingSpace");
		NativeFieldInfoPtr_m_SavedWordWrapState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, "m_SavedWordWrapState");
		NativeFieldInfoPtr_m_SavedLineState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, "m_SavedLineState");
		NativeFieldInfoPtr_m_SavedEllipsisState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, "m_SavedEllipsisState");
		NativeFieldInfoPtr_m_SavedLastValidState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, "m_SavedLastValidState");
		NativeFieldInfoPtr_m_SavedSoftLineBreakState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, "m_SavedSoftLineBreakState");
		NativeFieldInfoPtr_m_TextElementType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, "m_TextElementType");
		NativeFieldInfoPtr_m_isTextLayoutPhase = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, "m_isTextLayoutPhase");
		NativeFieldInfoPtr_m_SpriteIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, "m_SpriteIndex");
		NativeFieldInfoPtr_m_SpriteColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, "m_SpriteColor");
		NativeFieldInfoPtr_m_CachedTextElement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, "m_CachedTextElement");
		NativeFieldInfoPtr_m_HighlightColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, "m_HighlightColor");
		NativeFieldInfoPtr_m_CharWidthAdjDelta = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, "m_CharWidthAdjDelta");
		NativeFieldInfoPtr_m_MaxFontSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, "m_MaxFontSize");
		NativeFieldInfoPtr_m_MinFontSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, "m_MinFontSize");
		NativeFieldInfoPtr_m_AutoSizeIterationCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, "m_AutoSizeIterationCount");
		NativeFieldInfoPtr_m_AutoSizeMaxIterationCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, "m_AutoSizeMaxIterationCount");
		NativeFieldInfoPtr_m_StartOfLineAscender = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, "m_StartOfLineAscender");
		NativeFieldInfoPtr_m_LineSpacingDelta = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, "m_LineSpacingDelta");
		NativeFieldInfoPtr_m_MaterialReferences = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, "m_MaterialReferences");
		NativeFieldInfoPtr_m_SpriteCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, "m_SpriteCount");
		NativeFieldInfoPtr_m_StyleStack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, "m_StyleStack");
		NativeFieldInfoPtr_m_EllipsisInsertionCandidateStack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, "m_EllipsisInsertionCandidateStack");
		NativeFieldInfoPtr_m_SpriteAnimationId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, "m_SpriteAnimationId");
		NativeFieldInfoPtr_m_ItalicAngle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, "m_ItalicAngle");
		NativeFieldInfoPtr_m_FXScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, "m_FXScale");
		NativeFieldInfoPtr_m_FXRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, "m_FXRotation");
		NativeFieldInfoPtr_m_LastBaseGlyphIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, "m_LastBaseGlyphIndex");
		NativeFieldInfoPtr_m_PageAscender = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, "m_PageAscender");
		NativeFieldInfoPtr_m_XmlAttribute = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, "m_XmlAttribute");
		NativeFieldInfoPtr_m_AttributeParameterValues = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, "m_AttributeParameterValues");
		NativeFieldInfoPtr_m_MaterialReferenceIndexLookup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, "m_MaterialReferenceIndexLookup");
		NativeFieldInfoPtr_m_IsCalculatingPreferredValues = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, "m_IsCalculatingPreferredValues");
		NativeFieldInfoPtr_m_TintSprite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, "m_TintSprite");
		NativeFieldInfoPtr_m_Ellipsis = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, "m_Ellipsis");
		NativeFieldInfoPtr_m_Underline = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, "m_Underline");
		NativeFieldInfoPtr_m_InternalTextElementInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, "m_InternalTextElementInfo");
		NativeMethodInfoPtr_get_IsExecutingJob_Internal_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, 100663728);
		NativeMethodInfoPtr_set_IsExecutingJob_Internal_Static_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, 100663729);
		NativeMethodInfoPtr_GenerateText_Public_Void_TextGenerationSettings_TextInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, 100663730);
		NativeMethodInfoPtr_get_isTextTruncated_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, 100663731);
		NativeMethodInfoPtr_GenerateTextMesh_Internal_Void_TextGenerationSettings_TextInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, 100663732);
		NativeMethodInfoPtr_ValidateHtmlTag_Private_Boolean_Il2CppStructArray_1_TextProcessingElement_Int32_byref_Int32_TextGenerationSettings_TextInfo_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, 100663733);
		NativeMethodInfoPtr_CloseLastLinkTag_Internal_Void_TextInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, 100663734);
		NativeMethodInfoPtr_CloseAllLinkTags_Internal_Void_TextInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, 100663735);
		NativeMethodInfoPtr_CloseLinkTag_Private_Void_TextInfo_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, 100663736);
		NativeMethodInfoPtr_ClearMarkupTagAttributes_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, 100663737);
		NativeMethodInfoPtr_SaveWordWrappingState_Private_Void_byref_WordWrapState_Int32_Int32_TextInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, 100663738);
		NativeMethodInfoPtr_RestoreWordWrappingState_Private_Int32_byref_WordWrapState_TextInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, 100663739);
		NativeMethodInfoPtr_SaveGlyphVertexInfo_Private_Void_Single_Single_Color32_TextGenerationSettings_TextInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, 100663740);
		NativeMethodInfoPtr_SaveSpriteVertexInfo_Private_Void_Color32_TextGenerationSettings_TextInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, 100663741);
		NativeMethodInfoPtr_DrawUnderlineMesh_Private_Void_Vector3_Vector3_Single_Single_Single_Single_Color32_TextGenerationSettings_TextInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, 100663742);
		NativeMethodInfoPtr_DrawTextHighlight_Private_Void_Vector3_Vector3_Color32_TextGenerationSettings_TextInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, 100663743);
		NativeMethodInfoPtr_ClearMesh_Private_Static_Void_Boolean_TextInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, 100663744);
		NativeMethodInfoPtr_LayoutPhase_Public_Void_TextInfo_TextGenerationSettings_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, 100663745);
		NativeMethodInfoPtr_ParsingPhase_Public_Void_TextInfo_TextGenerationSettings_byref_UInt32_byref_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, 100663746);
		NativeMethodInfoPtr_InsertNewLine_Private_Void_Int32_Single_Single_Single_Single_Single_Single_Single_byref_Boolean_byref_Single_TextGenerationSettings_TextInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, 100663747);
		NativeMethodInfoPtr_GetPreferredValues_Public_Vector2_TextGenerationSettings_TextInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, 100663748);
		NativeMethodInfoPtr_GetPreferredValuesInternal_Private_Vector2_TextGenerationSettings_TextInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, 100663749);
		NativeMethodInfoPtr_CalculatePreferredValues_Protected_Virtual_New_Vector2_byref_Single_Vector2_Boolean_TextGenerationSettings_TextInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, 100663750);
		NativeMethodInfoPtr_Prepare_Internal_Void_TextGenerationSettings_TextInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, 100663751);
		NativeMethodInfoPtr_PrepareFontAsset_Internal_Boolean_TextGenerationSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, 100663752);
		NativeMethodInfoPtr_SetArraySizes_Private_Int32_Il2CppStructArray_1_TextProcessingElement_TextGenerationSettings_TextInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, 100663753);
		NativeMethodInfoPtr_GetTextElement_Private_TextElement_TextGenerationSettings_UInt32_FontAsset_FontStyles_TextFontWeight_byref_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, 100663754);
		NativeMethodInfoPtr_PopulateTextBackingArray_Private_Void_byref_RenderedText_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, 100663755);
		NativeMethodInfoPtr_PopulateTextProcessingArray_Private_Void_TextGenerationSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, 100663756);
		NativeMethodInfoPtr_PopulateFontAsset_Private_Boolean_TextGenerationSettings_Il2CppStructArray_1_TextProcessingElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, 100663757);
		NativeMethodInfoPtr_ComputeMarginSize_Private_Void_Rect_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, 100663758);
		NativeMethodInfoPtr_GetSpecialCharacters_Protected_Boolean_TextGenerationSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, 100663759);
		NativeMethodInfoPtr_GetEllipsisSpecialCharacter_Protected_Boolean_TextGenerationSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, 100663760);
		NativeMethodInfoPtr_GetUnderlineSpecialCharacter_Protected_Boolean_TextGenerationSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, 100663761);
		NativeMethodInfoPtr_DoMissingGlyphCallback_Protected_Void_UInt32_Int32_FontAsset_TextInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, 100663762);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, 100663763);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1279761, RefRangeEnd = 1279762, XrefRangeStart = 1279745, XrefRangeEnd = 1279761, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void GenerateText(TextGenerationSettings settings, TextInfo textInfo)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)settings);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)textInfo);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GenerateText_Public_Void_TextGenerationSettings_TextInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1279786, RefRangeEnd = 1279787, XrefRangeStart = 1279763, XrefRangeEnd = 1279786, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void GenerateTextMesh(TextGenerationSettings generationSettings, TextInfo textInfo)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)generationSettings);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)textInfo);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GenerateTextMesh_Internal_Void_TextGenerationSettings_TextInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 1279862, RefRangeEnd = 1279866, XrefRangeStart = 1279787, XrefRangeEnd = 1279862, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool ValidateHtmlTag(Il2CppStructArray<TextProcessingElement> chars, int startIndex, out int endIndex, TextGenerationSettings generationSettings, TextInfo textInfo, out bool isThreadSuccess)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)chars);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &startIndex;
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref endIndex);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)generationSettings);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)textInfo);
		*(void**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref isThreadSuccess);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ValidateHtmlTag_Private_Boolean_Il2CppStructArray_1_TextProcessingElement_Int32_byref_Int32_TextGenerationSettings_TextInfo_byref_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe void CloseLastLinkTag(TextInfo textInfo)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)textInfo);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CloseLastLinkTag_Internal_Void_TextInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	public unsafe void CloseAllLinkTags(TextInfo textInfo)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)textInfo);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CloseAllLinkTags_Internal_Void_TextInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	public unsafe void CloseLinkTag(TextInfo textInfo, int index)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)textInfo);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &index;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CloseLinkTag_Private_Void_TextInfo_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	public unsafe void ClearMarkupTagAttributes()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ClearMarkupTagAttributes_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(18)]
	[CachedScanResults(RefRangeStart = 1279884, RefRangeEnd = 1279902, XrefRangeStart = 1279866, XrefRangeEnd = 1279884, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SaveWordWrappingState(ref WordWrapState state, int index, int count, TextInfo textInfo)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)state);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &index;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &count;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)textInfo);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SaveWordWrappingState_Private_Void_byref_WordWrapState_Int32_Int32_TextInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(9)]
	[CachedScanResults(RefRangeStart = 1279920, RefRangeEnd = 1279929, XrefRangeStart = 1279902, XrefRangeEnd = 1279920, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int RestoreWordWrappingState(ref WordWrapState state, TextInfo textInfo)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)state);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)textInfo);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RestoreWordWrappingState_Private_Int32_byref_WordWrapState_TextInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1279964, RefRangeEnd = 1279965, XrefRangeStart = 1279929, XrefRangeEnd = 1279964, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SaveGlyphVertexInfo(float padding, float stylePadding, Color32 vertexColor, TextGenerationSettings generationSettings, TextInfo textInfo)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = (nint)(&padding);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &stylePadding;
		*(Color32**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &vertexColor;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)generationSettings);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)textInfo);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SaveGlyphVertexInfo_Private_Void_Single_Single_Color32_TextGenerationSettings_TextInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1280001, RefRangeEnd = 1280002, XrefRangeStart = 1279965, XrefRangeEnd = 1280001, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SaveSpriteVertexInfo(Color32 vertexColor, TextGenerationSettings generationSettings, TextInfo textInfo)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&vertexColor);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)generationSettings);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)textInfo);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SaveSpriteVertexInfo_Private_Void_Color32_TextGenerationSettings_TextInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(8)]
	[CachedScanResults(RefRangeStart = 1280027, RefRangeEnd = 1280035, XrefRangeStart = 1280002, XrefRangeEnd = 1280027, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void DrawUnderlineMesh(Vector3 start, Vector3 end, float startScale, float endScale, float maxScale, float sdfScale, Color32 underlineColor, TextGenerationSettings generationSettings, TextInfo textInfo)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[9];
		*ptr = (nint)(&start);
		*(Vector3**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &end;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &startScale;
		*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &endScale;
		*(float**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &maxScale;
		*(float**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &sdfScale;
		*(Color32**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = &underlineColor;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)7u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)generationSettings);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)8u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)textInfo);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DrawUnderlineMesh_Private_Void_Vector3_Vector3_Single_Single_Single_Single_Color32_TextGenerationSettings_TextInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 1280050, RefRangeEnd = 1280055, XrefRangeStart = 1280035, XrefRangeEnd = 1280050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void DrawTextHighlight(Vector3 start, Vector3 end, Color32 highlightColor, TextGenerationSettings generationSettings, TextInfo textInfo)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = (nint)(&start);
		*(Vector3**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &end;
		*(Color32**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &highlightColor;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)generationSettings);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)textInfo);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DrawTextHighlight_Private_Void_Vector3_Vector3_Color32_TextGenerationSettings_TextInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1280055, XrefRangeEnd = 1280057, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ClearMesh(bool updateMesh, TextInfo textInfo)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&updateMesh);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)textInfo);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ClearMesh_Private_Static_Void_Boolean_TextInfo_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1280385, RefRangeEnd = 1280386, XrefRangeStart = 1280057, XrefRangeEnd = 1280385, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void LayoutPhase(TextInfo textInfo, TextGenerationSettings generationSettings, float maxVisibleDescender)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)textInfo);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)generationSettings);
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &maxVisibleDescender;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LayoutPhase_Public_Void_TextInfo_TextGenerationSettings_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1280994, RefRangeEnd = 1280995, XrefRangeStart = 1280386, XrefRangeEnd = 1280994, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ParsingPhase(TextInfo textInfo, TextGenerationSettings generationSettings, out uint charCode, out float maxVisibleDescender)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)textInfo);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)generationSettings);
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref charCode);
		*(void**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref maxVisibleDescender);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ParsingPhase_Public_Void_TextInfo_TextGenerationSettings_byref_UInt32_byref_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1281013, RefRangeEnd = 1281014, XrefRangeStart = 1280995, XrefRangeEnd = 1281013, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void InsertNewLine(int i, float baseScale, float currentElementScale, float currentEmScale, float boldSpacingAdjustment, float characterSpacingAdjustment, float width, float lineGap, ref bool isMaxVisibleDescenderSet, ref float maxVisibleDescender, TextGenerationSettings generationSettings, TextInfo textInfo)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[12];
		*ptr = (nint)(&i);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &baseScale;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &currentElementScale;
		*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &currentEmScale;
		*(float**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &boldSpacingAdjustment;
		*(float**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &characterSpacingAdjustment;
		*(float**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = &width;
		*(float**)((byte*)ptr + checked((nuint)7u * unchecked((nuint)sizeof(System.IntPtr)))) = &lineGap;
		*(void**)((byte*)ptr + checked((nuint)8u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref isMaxVisibleDescenderSet);
		*(void**)((byte*)ptr + checked((nuint)9u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref maxVisibleDescender);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)10u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)generationSettings);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)11u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)textInfo);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InsertNewLine_Private_Void_Int32_Single_Single_Single_Single_Single_Single_Single_byref_Boolean_byref_Single_TextGenerationSettings_TextInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1281038, RefRangeEnd = 1281039, XrefRangeStart = 1281014, XrefRangeEnd = 1281038, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Vector2 GetPreferredValues(TextGenerationSettings settings, TextInfo textInfo)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)settings);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)textInfo);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetPreferredValues_Public_Vector2_TextGenerationSettings_TextInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(Vector2*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1281039, XrefRangeEnd = 1281047, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Vector2 GetPreferredValuesInternal(TextGenerationSettings generationSettings, TextInfo textInfo)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)generationSettings);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)textInfo);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetPreferredValuesInternal_Private_Vector2_TextGenerationSettings_TextInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(Vector2*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1281047, XrefRangeEnd = 1281389, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual Vector2 CalculatePreferredValues(ref float fontSize, Vector2 marginSize, bool isTextAutoSizingEnabled, TextGenerationSettings generationSettings, TextInfo textInfo)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = (nint)Unsafe.AsPointer(ref fontSize);
		*(Vector2**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &marginSize;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &isTextAutoSizingEnabled;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)generationSettings);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)textInfo);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_CalculatePreferredValues_Protected_Virtual_New_Vector2_byref_Single_Vector2_Boolean_TextGenerationSettings_TextInfo_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(Vector2*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1281397, RefRangeEnd = 1281399, XrefRangeStart = 1281389, XrefRangeEnd = 1281397, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Prepare(TextGenerationSettings generationSettings, TextInfo textInfo)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)generationSettings);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)textInfo);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Prepare_Internal_Void_TextGenerationSettings_TextInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1281399, XrefRangeEnd = 1281405, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool PrepareFontAsset(TextGenerationSettings generationSettings)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)generationSettings);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PrepareFontAsset_Internal_Boolean_TextGenerationSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1281628, RefRangeEnd = 1281629, XrefRangeStart = 1281405, XrefRangeEnd = 1281628, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int SetArraySizes(Il2CppStructArray<TextProcessingElement> textProcessingArray, TextGenerationSettings generationSettings, TextInfo textInfo)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)textProcessingArray);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)generationSettings);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)textInfo);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetArraySizes_Private_Int32_Il2CppStructArray_1_TextProcessingElement_TextGenerationSettings_TextInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1281666, RefRangeEnd = 1281668, XrefRangeStart = 1281629, XrefRangeEnd = 1281666, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe TextElement GetTextElement(TextGenerationSettings generationSettings, uint unicode, FontAsset fontAsset, FontStyles fontStyle, TextFontWeight fontWeight, out bool isUsingAlternativeTypeface, bool populateLigatures)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[7];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)generationSettings);
		*(uint**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &unicode;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)fontAsset);
		*(FontStyles**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &fontStyle;
		*(TextFontWeight**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &fontWeight;
		*(void**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref isUsingAlternativeTypeface);
		*(bool**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = &populateLigatures;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetTextElement_Private_TextElement_TextGenerationSettings_UInt32_FontAsset_FontStyles_TextFontWeight_byref_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<TextElement>(intPtr2) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1281677, RefRangeEnd = 1281679, XrefRangeStart = 1281668, XrefRangeEnd = 1281677, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void PopulateTextBackingArray([In] ref RenderedText sourceText)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)sourceText);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PopulateTextBackingArray_Private_Void_byref_RenderedText_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1281757, RefRangeEnd = 1281759, XrefRangeStart = 1281679, XrefRangeEnd = 1281757, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void PopulateTextProcessingArray(TextGenerationSettings generationSettings)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)generationSettings);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PopulateTextProcessingArray_Private_Void_TextGenerationSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1281925, RefRangeEnd = 1281926, XrefRangeStart = 1281759, XrefRangeEnd = 1281925, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool PopulateFontAsset(TextGenerationSettings generationSettings, Il2CppStructArray<TextProcessingElement> textProcessingArray)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)generationSettings);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)textProcessingArray);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PopulateFontAsset_Private_Boolean_TextGenerationSettings_Il2CppStructArray_1_TextProcessingElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe void ComputeMarginSize(Rect rect, Vector4 margins)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&rect);
		*(Vector4**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &margins;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ComputeMarginSize_Private_Void_Rect_Vector4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1281926, XrefRangeEnd = 1281928, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool GetSpecialCharacters(TextGenerationSettings generationSettings)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)generationSettings);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetSpecialCharacters_Protected_Boolean_TextGenerationSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 1281942, RefRangeEnd = 1281947, XrefRangeStart = 1281928, XrefRangeEnd = 1281942, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool GetEllipsisSpecialCharacter(TextGenerationSettings generationSettings)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)generationSettings);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetEllipsisSpecialCharacter_Protected_Boolean_TextGenerationSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 1281962, RefRangeEnd = 1281967, XrefRangeStart = 1281947, XrefRangeEnd = 1281962, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool GetUnderlineSpecialCharacter(TextGenerationSettings generationSettings)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)generationSettings);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetUnderlineSpecialCharacter_Protected_Boolean_TextGenerationSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1281969, RefRangeEnd = 1281970, XrefRangeStart = 1281967, XrefRangeEnd = 1281969, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void DoMissingGlyphCallback(uint unicode, int stringIndex, FontAsset fontAsset, TextInfo textInfo)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&unicode);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &stringIndex;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)fontAsset);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)textInfo);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DoMissingGlyphCallback_Protected_Void_UInt32_Int32_FontAsset_TextInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1282104, RefRangeEnd = 1282106, XrefRangeStart = 1281970, XrefRangeEnd = 1282104, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe TextGenerator()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public TextGenerator(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public static TextGenerator GetTextGenerator()
	{
		if (s_TextGenerator == null)
		{
			s_TextGenerator = new TextGenerator();
		}
		return s_TextGenerator;
	}

	[SpecialName]
	public static void add_OnMissingCharacter(MissingCharacterEventCallback value)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	[SpecialName]
	public static void remove_OnMissingCharacter(MissingCharacterEventCallback value)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}
}
