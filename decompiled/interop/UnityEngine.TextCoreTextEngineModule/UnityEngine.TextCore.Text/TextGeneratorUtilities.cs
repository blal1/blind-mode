using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;
using UnityEngine.TextCore.LowLevel;

namespace UnityEngine.TextCore.Text;

public static class TextGeneratorUtilities : Il2CppSystem.Object
{
	private sealed class MethodInfoStoreGeneric_ResizeInternalArray_Public_Static_Void_byref_Il2CppArrayBase_1_T_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_ResizeInternalArray_Public_Static_Void_byref_Il2CppArrayBase_1_T_0, Il2CppClassPointerStore<TextGeneratorUtilities>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private sealed class MethodInfoStoreGeneric_ResizeInternalArray_Public_Static_Void_byref_Il2CppArrayBase_1_T_Int32_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_ResizeInternalArray_Public_Static_Void_byref_Il2CppArrayBase_1_T_Int32_0, Il2CppClassPointerStore<TextGeneratorUtilities>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_largePositiveVector2;

	private static readonly System.IntPtr NativeFieldInfoPtr_largeNegativeVector2;

	private static readonly System.IntPtr NativeFieldInfoPtr_k_EmojiLookup;

	private static readonly System.IntPtr NativeFieldInfoPtr_k_EmojiPresentationFormLookup;

	private static readonly System.IntPtr NativeMethodInfoPtr_Approximately_Public_Static_Boolean_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_HexCharsToColor_Public_Static_Color32_Il2CppStructArray_1_Char_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_HexToInt_Public_Static_UInt32_Char_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ConvertToFloat_Public_Static_Single_Il2CppStructArray_1_Char_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ConvertToFloat_Public_Static_Single_Il2CppStructArray_1_Char_Int32_Int32_byref_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ResizeInternalArray_Public_Static_Void_byref_Il2CppArrayBase_1_T_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ResizeInternalArray_Public_Static_Void_byref_Il2CppArrayBase_1_T_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InsertOpeningTextStyle_Internal_Static_Void_TextStyle_byref_Il2CppStructArray_1_TextProcessingElement_byref_Int32_byref_Int32_byref_Il2CppReferenceArray_1_TextProcessingStack_1_Int32_byref_TextGenerationSettings_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InsertClosingTextStyle_Internal_Static_Void_TextStyle_byref_Il2CppStructArray_1_TextProcessingElement_byref_Int32_byref_Int32_byref_Il2CppReferenceArray_1_TextProcessingStack_1_Int32_byref_TextGenerationSettings_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ReplaceOpeningStyleTag_Public_Static_Boolean_byref_TextBackingContainer_Int32_byref_Int32_byref_Il2CppStructArray_1_TextProcessingElement_byref_Int32_byref_Int32_byref_Il2CppReferenceArray_1_TextProcessingStack_1_Int32_byref_TextGenerationSettings_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ReplaceOpeningStyleTag_Private_Static_Boolean_byref_Il2CppStructArray_1_UInt32_Int32_byref_Int32_byref_Il2CppStructArray_1_TextProcessingElement_byref_Int32_byref_Int32_byref_Il2CppReferenceArray_1_TextProcessingStack_1_Int32_byref_TextGenerationSettings_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ReplaceClosingStyleTag_Public_Static_Void_byref_Il2CppStructArray_1_TextProcessingElement_byref_Int32_byref_Int32_byref_Il2CppReferenceArray_1_TextProcessingStack_1_Int32_byref_TextGenerationSettings_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InsertOpeningStyleTag_Internal_Static_Void_TextStyle_byref_Il2CppStructArray_1_TextProcessingElement_byref_Int32_byref_Int32_byref_Il2CppReferenceArray_1_TextProcessingStack_1_Int32_byref_TextGenerationSettings_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InsertClosingStyleTag_Internal_Static_Void_byref_Il2CppStructArray_1_TextProcessingElement_byref_Int32_byref_Int32_byref_Il2CppReferenceArray_1_TextProcessingStack_1_Int32_byref_TextGenerationSettings_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InsertTextStyleInTextProcessingArray_Private_Static_Void_byref_Il2CppStructArray_1_TextProcessingElement_byref_Int32_Il2CppStructArray_1_UInt32_byref_Int32_byref_Il2CppReferenceArray_1_TextProcessingStack_1_Int32_byref_TextGenerationSettings_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetStyle_Public_Static_TextStyle_TextGenerationSettings_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetStyleHashCode_Public_Static_Int32_byref_Il2CppStructArray_1_UInt32_Int32_byref_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetStyleHashCode_Public_Static_Int32_byref_TextBackingContainer_Int32_byref_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetUTF16_Public_Static_UInt32_Il2CppStructArray_1_UInt32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetUTF16_Public_Static_UInt32_TextBackingContainer_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetUTF32_Public_Static_UInt32_Il2CppStructArray_1_UInt32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetUTF32_Public_Static_UInt32_TextBackingContainer_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FillCharacterVertexBuffers_Public_Static_Void_Int32_Boolean_TextGenerationSettings_TextInfo_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FillSpriteVertexBuffers_Public_Static_Void_Int32_Boolean_TextGenerationSettings_TextInfo_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AdjustLineOffset_Public_Static_Void_Int32_Int32_Single_TextInfo_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ResizeLineExtents_Public_Static_Void_Int32_TextInfo_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LegacyStyleToNewStyle_Public_Static_FontStyles_FontStyle_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LegacyAlignmentToNewAlignment_Public_Static_TextAlignment_TextAnchor_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetHorizontalAlignment_Internal_Static_HorizontalAlignment_TextAnchor_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetVerticalAlignment_Internal_Static_VerticalAlignment_TextAnchor_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ConvertToUTF32_Public_Static_UInt32_UInt32_UInt32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetMarkupTagHashCode_Public_Static_Int32_TextBackingContainer_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetMarkupTagHashCode_Public_Static_Int32_Il2CppStructArray_1_UInt32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToUpperASCIIFast_Public_Static_Char_Char_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToUpperASCIIFast_Public_Static_UInt32_UInt32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToUpperFast_Public_Static_Char_Char_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetAttributeParameters_Public_Static_Int32_Il2CppStructArray_1_Char_Int32_Int32_byref_Il2CppStructArray_1_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsBitmapRendering_Public_Static_Boolean_GlyphRenderMode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsBaseGlyph_Public_Static_Boolean_UInt32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_MinAlpha_Public_Static_Color_Color_Color_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GammaToLinear_Internal_Static_Color32_Color32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GammaToLinear_Private_Static_Byte_Byte_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsValidUTF16_Public_Static_Boolean_TextBackingContainer_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsValidUTF32_Public_Static_Boolean_TextBackingContainer_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsEmoji_Internal_Static_Boolean_UInt32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsEmojiPresentationForm_Internal_Static_Boolean_UInt32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsHangul_Internal_Static_Boolean_UInt32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsCJK_Internal_Static_Boolean_UInt32_0;

	public const float largePositiveFloat = 32767f;

	public const float largeNegativeFloat = -32767f;

	public const int k_DoubleQuotes = 34;

	public const int k_GreaterThan = 62;

	public const int k_ZeroWidthSpace = 8203;

	public const string k_LookupStringU = "-------------------------------- !-#$%&-()*+,-./0123456789:;<=>?@ABCDEFGHIJKLMNOPQRSTUVWXYZ[-]^_`ABCDEFGHIJKLMNOPQRSTUVWXYZ{|}~-";

	public unsafe static Vector2 largePositiveVector2
	{
		get
		{
			Unsafe.SkipInit(out Vector2 result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_largePositiveVector2, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_largePositiveVector2, (void*)(&value));
		}
	}

	public unsafe static Vector2 largeNegativeVector2
	{
		get
		{
			Unsafe.SkipInit(out Vector2 result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_largeNegativeVector2, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_largeNegativeVector2, (void*)(&value));
		}
	}

	public unsafe static HashSet<uint> k_EmojiLookup
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_k_EmojiLookup, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<HashSet<uint>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_k_EmojiLookup, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static HashSet<uint> k_EmojiPresentationFormLookup
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_k_EmojiPresentationFormLookup, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<HashSet<uint>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_k_EmojiPresentationFormLookup, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	static TextGeneratorUtilities()
	{
		Il2CppClassPointerStore<TextGeneratorUtilities>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.TextCoreTextEngineModule.dll", "UnityEngine.TextCore.Text", "TextGeneratorUtilities");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TextGeneratorUtilities>.NativeClassPtr);
		NativeFieldInfoPtr_largePositiveVector2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGeneratorUtilities>.NativeClassPtr, "largePositiveVector2");
		NativeFieldInfoPtr_largeNegativeVector2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGeneratorUtilities>.NativeClassPtr, "largeNegativeVector2");
		NativeFieldInfoPtr_k_EmojiLookup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGeneratorUtilities>.NativeClassPtr, "k_EmojiLookup");
		NativeFieldInfoPtr_k_EmojiPresentationFormLookup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGeneratorUtilities>.NativeClassPtr, "k_EmojiPresentationFormLookup");
		NativeMethodInfoPtr_Approximately_Public_Static_Boolean_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextGeneratorUtilities>.NativeClassPtr, 100663816);
		NativeMethodInfoPtr_HexCharsToColor_Public_Static_Color32_Il2CppStructArray_1_Char_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextGeneratorUtilities>.NativeClassPtr, 100663817);
		NativeMethodInfoPtr_HexToInt_Public_Static_UInt32_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextGeneratorUtilities>.NativeClassPtr, 100663818);
		NativeMethodInfoPtr_ConvertToFloat_Public_Static_Single_Il2CppStructArray_1_Char_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextGeneratorUtilities>.NativeClassPtr, 100663819);
		NativeMethodInfoPtr_ConvertToFloat_Public_Static_Single_Il2CppStructArray_1_Char_Int32_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextGeneratorUtilities>.NativeClassPtr, 100663820);
		NativeMethodInfoPtr_ResizeInternalArray_Public_Static_Void_byref_Il2CppArrayBase_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextGeneratorUtilities>.NativeClassPtr, 100663821);
		NativeMethodInfoPtr_ResizeInternalArray_Public_Static_Void_byref_Il2CppArrayBase_1_T_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextGeneratorUtilities>.NativeClassPtr, 100663822);
		NativeMethodInfoPtr_InsertOpeningTextStyle_Internal_Static_Void_TextStyle_byref_Il2CppStructArray_1_TextProcessingElement_byref_Int32_byref_Int32_byref_Il2CppReferenceArray_1_TextProcessingStack_1_Int32_byref_TextGenerationSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextGeneratorUtilities>.NativeClassPtr, 100663823);
		NativeMethodInfoPtr_InsertClosingTextStyle_Internal_Static_Void_TextStyle_byref_Il2CppStructArray_1_TextProcessingElement_byref_Int32_byref_Int32_byref_Il2CppReferenceArray_1_TextProcessingStack_1_Int32_byref_TextGenerationSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextGeneratorUtilities>.NativeClassPtr, 100663824);
		NativeMethodInfoPtr_ReplaceOpeningStyleTag_Public_Static_Boolean_byref_TextBackingContainer_Int32_byref_Int32_byref_Il2CppStructArray_1_TextProcessingElement_byref_Int32_byref_Int32_byref_Il2CppReferenceArray_1_TextProcessingStack_1_Int32_byref_TextGenerationSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextGeneratorUtilities>.NativeClassPtr, 100663825);
		NativeMethodInfoPtr_ReplaceOpeningStyleTag_Private_Static_Boolean_byref_Il2CppStructArray_1_UInt32_Int32_byref_Int32_byref_Il2CppStructArray_1_TextProcessingElement_byref_Int32_byref_Int32_byref_Il2CppReferenceArray_1_TextProcessingStack_1_Int32_byref_TextGenerationSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextGeneratorUtilities>.NativeClassPtr, 100663826);
		NativeMethodInfoPtr_ReplaceClosingStyleTag_Public_Static_Void_byref_Il2CppStructArray_1_TextProcessingElement_byref_Int32_byref_Int32_byref_Il2CppReferenceArray_1_TextProcessingStack_1_Int32_byref_TextGenerationSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextGeneratorUtilities>.NativeClassPtr, 100663827);
		NativeMethodInfoPtr_InsertOpeningStyleTag_Internal_Static_Void_TextStyle_byref_Il2CppStructArray_1_TextProcessingElement_byref_Int32_byref_Int32_byref_Il2CppReferenceArray_1_TextProcessingStack_1_Int32_byref_TextGenerationSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextGeneratorUtilities>.NativeClassPtr, 100663828);
		NativeMethodInfoPtr_InsertClosingStyleTag_Internal_Static_Void_byref_Il2CppStructArray_1_TextProcessingElement_byref_Int32_byref_Int32_byref_Il2CppReferenceArray_1_TextProcessingStack_1_Int32_byref_TextGenerationSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextGeneratorUtilities>.NativeClassPtr, 100663829);
		NativeMethodInfoPtr_InsertTextStyleInTextProcessingArray_Private_Static_Void_byref_Il2CppStructArray_1_TextProcessingElement_byref_Int32_Il2CppStructArray_1_UInt32_byref_Int32_byref_Il2CppReferenceArray_1_TextProcessingStack_1_Int32_byref_TextGenerationSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextGeneratorUtilities>.NativeClassPtr, 100663830);
		NativeMethodInfoPtr_GetStyle_Public_Static_TextStyle_TextGenerationSettings_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextGeneratorUtilities>.NativeClassPtr, 100663831);
		NativeMethodInfoPtr_GetStyleHashCode_Public_Static_Int32_byref_Il2CppStructArray_1_UInt32_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextGeneratorUtilities>.NativeClassPtr, 100663832);
		NativeMethodInfoPtr_GetStyleHashCode_Public_Static_Int32_byref_TextBackingContainer_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextGeneratorUtilities>.NativeClassPtr, 100663833);
		NativeMethodInfoPtr_GetUTF16_Public_Static_UInt32_Il2CppStructArray_1_UInt32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextGeneratorUtilities>.NativeClassPtr, 100663834);
		NativeMethodInfoPtr_GetUTF16_Public_Static_UInt32_TextBackingContainer_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextGeneratorUtilities>.NativeClassPtr, 100663835);
		NativeMethodInfoPtr_GetUTF32_Public_Static_UInt32_Il2CppStructArray_1_UInt32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextGeneratorUtilities>.NativeClassPtr, 100663836);
		NativeMethodInfoPtr_GetUTF32_Public_Static_UInt32_TextBackingContainer_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextGeneratorUtilities>.NativeClassPtr, 100663837);
		NativeMethodInfoPtr_FillCharacterVertexBuffers_Public_Static_Void_Int32_Boolean_TextGenerationSettings_TextInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextGeneratorUtilities>.NativeClassPtr, 100663838);
		NativeMethodInfoPtr_FillSpriteVertexBuffers_Public_Static_Void_Int32_Boolean_TextGenerationSettings_TextInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextGeneratorUtilities>.NativeClassPtr, 100663839);
		NativeMethodInfoPtr_AdjustLineOffset_Public_Static_Void_Int32_Int32_Single_TextInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextGeneratorUtilities>.NativeClassPtr, 100663840);
		NativeMethodInfoPtr_ResizeLineExtents_Public_Static_Void_Int32_TextInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextGeneratorUtilities>.NativeClassPtr, 100663841);
		NativeMethodInfoPtr_LegacyStyleToNewStyle_Public_Static_FontStyles_FontStyle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextGeneratorUtilities>.NativeClassPtr, 100663842);
		NativeMethodInfoPtr_LegacyAlignmentToNewAlignment_Public_Static_TextAlignment_TextAnchor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextGeneratorUtilities>.NativeClassPtr, 100663843);
		NativeMethodInfoPtr_GetHorizontalAlignment_Internal_Static_HorizontalAlignment_TextAnchor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextGeneratorUtilities>.NativeClassPtr, 100663844);
		NativeMethodInfoPtr_GetVerticalAlignment_Internal_Static_VerticalAlignment_TextAnchor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextGeneratorUtilities>.NativeClassPtr, 100663845);
		NativeMethodInfoPtr_ConvertToUTF32_Public_Static_UInt32_UInt32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextGeneratorUtilities>.NativeClassPtr, 100663846);
		NativeMethodInfoPtr_GetMarkupTagHashCode_Public_Static_Int32_TextBackingContainer_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextGeneratorUtilities>.NativeClassPtr, 100663847);
		NativeMethodInfoPtr_GetMarkupTagHashCode_Public_Static_Int32_Il2CppStructArray_1_UInt32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextGeneratorUtilities>.NativeClassPtr, 100663848);
		NativeMethodInfoPtr_ToUpperASCIIFast_Public_Static_Char_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextGeneratorUtilities>.NativeClassPtr, 100663849);
		NativeMethodInfoPtr_ToUpperASCIIFast_Public_Static_UInt32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextGeneratorUtilities>.NativeClassPtr, 100663850);
		NativeMethodInfoPtr_ToUpperFast_Public_Static_Char_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextGeneratorUtilities>.NativeClassPtr, 100663851);
		NativeMethodInfoPtr_GetAttributeParameters_Public_Static_Int32_Il2CppStructArray_1_Char_Int32_Int32_byref_Il2CppStructArray_1_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextGeneratorUtilities>.NativeClassPtr, 100663852);
		NativeMethodInfoPtr_IsBitmapRendering_Public_Static_Boolean_GlyphRenderMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextGeneratorUtilities>.NativeClassPtr, 100663853);
		NativeMethodInfoPtr_IsBaseGlyph_Public_Static_Boolean_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextGeneratorUtilities>.NativeClassPtr, 100663854);
		NativeMethodInfoPtr_MinAlpha_Public_Static_Color_Color_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextGeneratorUtilities>.NativeClassPtr, 100663855);
		NativeMethodInfoPtr_GammaToLinear_Internal_Static_Color32_Color32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextGeneratorUtilities>.NativeClassPtr, 100663856);
		NativeMethodInfoPtr_GammaToLinear_Private_Static_Byte_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextGeneratorUtilities>.NativeClassPtr, 100663857);
		NativeMethodInfoPtr_IsValidUTF16_Public_Static_Boolean_TextBackingContainer_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextGeneratorUtilities>.NativeClassPtr, 100663858);
		NativeMethodInfoPtr_IsValidUTF32_Public_Static_Boolean_TextBackingContainer_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextGeneratorUtilities>.NativeClassPtr, 100663859);
		NativeMethodInfoPtr_IsEmoji_Internal_Static_Boolean_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextGeneratorUtilities>.NativeClassPtr, 100663860);
		NativeMethodInfoPtr_IsEmojiPresentationForm_Internal_Static_Boolean_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextGeneratorUtilities>.NativeClassPtr, 100663861);
		NativeMethodInfoPtr_IsHangul_Internal_Static_Boolean_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextGeneratorUtilities>.NativeClassPtr, 100663862);
		NativeMethodInfoPtr_IsCJK_Internal_Static_Boolean_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextGeneratorUtilities>.NativeClassPtr, 100663863);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1282549, RefRangeEnd = 1282551, XrefRangeStart = 1282549, XrefRangeEnd = 1282549, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool Approximately(float a, float b)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&a);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &b;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Approximately_Public_Static_Boolean_Single_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1282551, XrefRangeEnd = 1282587, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Color32 HexCharsToColor(Il2CppStructArray<char> hexChars, int startIndex, int tagCount)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)hexChars);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &startIndex;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &tagCount;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_HexCharsToColor_Public_Static_Color32_Il2CppStructArray_1_Char_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(Color32*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(47)]
	[CachedScanResults(RefRangeStart = 1134533, RefRangeEnd = 1134580, XrefRangeStart = 1134533, XrefRangeEnd = 1134580, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static uint HexToInt(char hex)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&hex);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_HexToInt_Public_Static_UInt32_Char_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(uint*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1282591, RefRangeEnd = 1282592, XrefRangeStart = 1282587, XrefRangeEnd = 1282591, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float ConvertToFloat(Il2CppStructArray<char> chars, int startIndex, int length)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)chars);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &startIndex;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &length;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ConvertToFloat_Public_Static_Single_Il2CppStructArray_1_Char_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1282596, RefRangeEnd = 1282598, XrefRangeStart = 1282592, XrefRangeEnd = 1282596, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float ConvertToFloat(Il2CppStructArray<char> chars, int startIndex, int length, out int lastIndex)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)chars);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &startIndex;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &length;
		*(void**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref lastIndex);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ConvertToFloat_Public_Static_Single_Il2CppStructArray_1_Char_Int32_Int32_byref_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 1282601, RefRangeEnd = 1282607, XrefRangeStart = 1282598, XrefRangeEnd = 1282601, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ResizeInternalArray<T>(ref Il2CppArrayBase<T> array)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)array);
		*ptr = (nint)(&intPtr);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_ResizeInternalArray_Public_Static_Void_byref_Il2CppArrayBase_1_T_0<T>.Pointer, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		System.IntPtr intPtr4 = intPtr;
		array = ((intPtr4 == (System.IntPtr)0) ? null : new Il2CppArrayBase<T>(intPtr4));
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1282609, RefRangeEnd = 1282612, XrefRangeStart = 1282607, XrefRangeEnd = 1282609, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ResizeInternalArray<T>(ref Il2CppArrayBase<T> array, int size)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)array);
		*ptr = (nint)(&intPtr);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &size;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_ResizeInternalArray_Public_Static_Void_byref_Il2CppArrayBase_1_T_Int32_0<T>.Pointer, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		System.IntPtr intPtr4 = intPtr;
		array = ((intPtr4 == (System.IntPtr)0) ? null : new Il2CppArrayBase<T>(intPtr4));
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1282612, XrefRangeEnd = 1282619, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void InsertOpeningTextStyle(TextStyle style, ref Il2CppStructArray<TextProcessingElement> charBuffer, ref int writeIndex, ref int textStyleStackDepth, ref Il2CppReferenceArray<TextProcessingStack<int>> textStyleStacks, ref TextGenerationSettings generationSettings)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)style);
		byte* num = (byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)));
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)charBuffer);
		*(System.IntPtr**)num = &intPtr;
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref writeIndex);
		*(void**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref textStyleStackDepth);
		byte* num2 = (byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)));
		System.IntPtr intPtr2 = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)textStyleStacks);
		*(System.IntPtr**)num2 = &intPtr2;
		byte* num3 = (byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)));
		System.IntPtr intPtr3 = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)generationSettings);
		*(System.IntPtr**)num3 = &intPtr3;
		Unsafe.SkipInit(out System.IntPtr intPtr4);
		System.IntPtr intPtr5 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InsertOpeningTextStyle_Internal_Static_Void_TextStyle_byref_Il2CppStructArray_1_TextProcessingElement_byref_Int32_byref_Int32_byref_Il2CppReferenceArray_1_TextProcessingStack_1_Int32_byref_TextGenerationSettings_0, (System.IntPtr)0, (void**)ptr, ref intPtr4);
		Il2CppException.RaiseExceptionIfNecessary(intPtr4);
		System.IntPtr intPtr6 = intPtr;
		charBuffer = ((intPtr6 == (System.IntPtr)0) ? null : new Il2CppStructArray<TextProcessingElement>(intPtr6));
		System.IntPtr intPtr7 = intPtr2;
		textStyleStacks = ((intPtr7 == (System.IntPtr)0) ? null : new Il2CppReferenceArray<TextProcessingStack<int>>(intPtr7));
		System.IntPtr intPtr8 = intPtr3;
		generationSettings = ((intPtr8 == (System.IntPtr)0) ? null : new TextGenerationSettings(intPtr8));
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1282626, RefRangeEnd = 1282627, XrefRangeStart = 1282619, XrefRangeEnd = 1282626, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void InsertClosingTextStyle(TextStyle style, ref Il2CppStructArray<TextProcessingElement> charBuffer, ref int writeIndex, ref int textStyleStackDepth, ref Il2CppReferenceArray<TextProcessingStack<int>> textStyleStacks, ref TextGenerationSettings generationSettings)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)style);
		byte* num = (byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)));
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)charBuffer);
		*(System.IntPtr**)num = &intPtr;
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref writeIndex);
		*(void**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref textStyleStackDepth);
		byte* num2 = (byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)));
		System.IntPtr intPtr2 = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)textStyleStacks);
		*(System.IntPtr**)num2 = &intPtr2;
		byte* num3 = (byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)));
		System.IntPtr intPtr3 = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)generationSettings);
		*(System.IntPtr**)num3 = &intPtr3;
		Unsafe.SkipInit(out System.IntPtr intPtr4);
		System.IntPtr intPtr5 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InsertClosingTextStyle_Internal_Static_Void_TextStyle_byref_Il2CppStructArray_1_TextProcessingElement_byref_Int32_byref_Int32_byref_Il2CppReferenceArray_1_TextProcessingStack_1_Int32_byref_TextGenerationSettings_0, (System.IntPtr)0, (void**)ptr, ref intPtr4);
		Il2CppException.RaiseExceptionIfNecessary(intPtr4);
		System.IntPtr intPtr6 = intPtr;
		charBuffer = ((intPtr6 == (System.IntPtr)0) ? null : new Il2CppStructArray<TextProcessingElement>(intPtr6));
		System.IntPtr intPtr7 = intPtr2;
		textStyleStacks = ((intPtr7 == (System.IntPtr)0) ? null : new Il2CppReferenceArray<TextProcessingStack<int>>(intPtr7));
		System.IntPtr intPtr8 = intPtr3;
		generationSettings = ((intPtr8 == (System.IntPtr)0) ? null : new TextGenerationSettings(intPtr8));
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1282642, RefRangeEnd = 1282643, XrefRangeStart = 1282627, XrefRangeEnd = 1282642, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool ReplaceOpeningStyleTag(ref TextBackingContainer sourceText, int srcIndex, out int srcOffset, ref Il2CppStructArray<TextProcessingElement> charBuffer, ref int writeIndex, ref int textStyleStackDepth, ref Il2CppReferenceArray<TextProcessingStack<int>> textStyleStacks, ref TextGenerationSettings generationSettings)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[8];
		*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)sourceText);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &srcIndex;
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref srcOffset);
		byte* num = (byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)));
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)charBuffer);
		*(System.IntPtr**)num = &intPtr;
		*(void**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref writeIndex);
		*(void**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref textStyleStackDepth);
		byte* num2 = (byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)));
		System.IntPtr intPtr2 = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)textStyleStacks);
		*(System.IntPtr**)num2 = &intPtr2;
		byte* num3 = (byte*)ptr + checked((nuint)7u * unchecked((nuint)sizeof(System.IntPtr)));
		System.IntPtr intPtr3 = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)generationSettings);
		*(System.IntPtr**)num3 = &intPtr3;
		Unsafe.SkipInit(out System.IntPtr intPtr4);
		System.IntPtr intPtr5 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ReplaceOpeningStyleTag_Public_Static_Boolean_byref_TextBackingContainer_Int32_byref_Int32_byref_Il2CppStructArray_1_TextProcessingElement_byref_Int32_byref_Int32_byref_Il2CppReferenceArray_1_TextProcessingStack_1_Int32_byref_TextGenerationSettings_0, (System.IntPtr)0, (void**)ptr, ref intPtr4);
		Il2CppException.RaiseExceptionIfNecessary(intPtr4);
		System.IntPtr intPtr6 = intPtr;
		charBuffer = ((intPtr6 == (System.IntPtr)0) ? null : new Il2CppStructArray<TextProcessingElement>(intPtr6));
		System.IntPtr intPtr7 = intPtr2;
		textStyleStacks = ((intPtr7 == (System.IntPtr)0) ? null : new Il2CppReferenceArray<TextProcessingStack<int>>(intPtr7));
		System.IntPtr intPtr8 = intPtr3;
		generationSettings = ((intPtr8 == (System.IntPtr)0) ? null : new TextGenerationSettings(intPtr8));
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr5);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1282658, RefRangeEnd = 1282659, XrefRangeStart = 1282643, XrefRangeEnd = 1282658, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool ReplaceOpeningStyleTag(ref Il2CppStructArray<uint> sourceText, int srcIndex, out int srcOffset, ref Il2CppStructArray<TextProcessingElement> charBuffer, ref int writeIndex, ref int textStyleStackDepth, ref Il2CppReferenceArray<TextProcessingStack<int>> textStyleStacks, ref TextGenerationSettings generationSettings)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[8];
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)sourceText);
		*ptr = (nint)(&intPtr);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &srcIndex;
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref srcOffset);
		byte* num = (byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)));
		System.IntPtr intPtr2 = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)charBuffer);
		*(System.IntPtr**)num = &intPtr2;
		*(void**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref writeIndex);
		*(void**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref textStyleStackDepth);
		byte* num2 = (byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)));
		System.IntPtr intPtr3 = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)textStyleStacks);
		*(System.IntPtr**)num2 = &intPtr3;
		byte* num3 = (byte*)ptr + checked((nuint)7u * unchecked((nuint)sizeof(System.IntPtr)));
		System.IntPtr intPtr4 = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)generationSettings);
		*(System.IntPtr**)num3 = &intPtr4;
		Unsafe.SkipInit(out System.IntPtr intPtr5);
		System.IntPtr intPtr6 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ReplaceOpeningStyleTag_Private_Static_Boolean_byref_Il2CppStructArray_1_UInt32_Int32_byref_Int32_byref_Il2CppStructArray_1_TextProcessingElement_byref_Int32_byref_Int32_byref_Il2CppReferenceArray_1_TextProcessingStack_1_Int32_byref_TextGenerationSettings_0, (System.IntPtr)0, (void**)ptr, ref intPtr5);
		Il2CppException.RaiseExceptionIfNecessary(intPtr5);
		System.IntPtr intPtr7 = intPtr;
		sourceText = ((intPtr7 == (System.IntPtr)0) ? null : new Il2CppStructArray<uint>(intPtr7));
		System.IntPtr intPtr8 = intPtr2;
		charBuffer = ((intPtr8 == (System.IntPtr)0) ? null : new Il2CppStructArray<TextProcessingElement>(intPtr8));
		System.IntPtr intPtr9 = intPtr3;
		textStyleStacks = ((intPtr9 == (System.IntPtr)0) ? null : new Il2CppReferenceArray<TextProcessingStack<int>>(intPtr9));
		System.IntPtr intPtr10 = intPtr4;
		generationSettings = ((intPtr10 == (System.IntPtr)0) ? null : new TextGenerationSettings(intPtr10));
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr6);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1282669, RefRangeEnd = 1282671, XrefRangeStart = 1282659, XrefRangeEnd = 1282669, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ReplaceClosingStyleTag(ref Il2CppStructArray<TextProcessingElement> charBuffer, ref int writeIndex, ref int textStyleStackDepth, ref Il2CppReferenceArray<TextProcessingStack<int>> textStyleStacks, ref TextGenerationSettings generationSettings)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)charBuffer);
		*ptr = (nint)(&intPtr);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref writeIndex);
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref textStyleStackDepth);
		byte* num = (byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)));
		System.IntPtr intPtr2 = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)textStyleStacks);
		*(System.IntPtr**)num = &intPtr2;
		byte* num2 = (byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)));
		System.IntPtr intPtr3 = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)generationSettings);
		*(System.IntPtr**)num2 = &intPtr3;
		Unsafe.SkipInit(out System.IntPtr intPtr4);
		System.IntPtr intPtr5 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ReplaceClosingStyleTag_Public_Static_Void_byref_Il2CppStructArray_1_TextProcessingElement_byref_Int32_byref_Int32_byref_Il2CppReferenceArray_1_TextProcessingStack_1_Int32_byref_TextGenerationSettings_0, (System.IntPtr)0, (void**)ptr, ref intPtr4);
		Il2CppException.RaiseExceptionIfNecessary(intPtr4);
		System.IntPtr intPtr6 = intPtr;
		charBuffer = ((intPtr6 == (System.IntPtr)0) ? null : new Il2CppStructArray<TextProcessingElement>(intPtr6));
		System.IntPtr intPtr7 = intPtr2;
		textStyleStacks = ((intPtr7 == (System.IntPtr)0) ? null : new Il2CppReferenceArray<TextProcessingStack<int>>(intPtr7));
		System.IntPtr intPtr8 = intPtr3;
		generationSettings = ((intPtr8 == (System.IntPtr)0) ? null : new TextGenerationSettings(intPtr8));
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1282678, RefRangeEnd = 1282679, XrefRangeStart = 1282671, XrefRangeEnd = 1282678, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void InsertOpeningStyleTag(TextStyle style, ref Il2CppStructArray<TextProcessingElement> charBuffer, ref int writeIndex, ref int textStyleStackDepth, ref Il2CppReferenceArray<TextProcessingStack<int>> textStyleStacks, ref TextGenerationSettings generationSettings)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)style);
		byte* num = (byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)));
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)charBuffer);
		*(System.IntPtr**)num = &intPtr;
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref writeIndex);
		*(void**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref textStyleStackDepth);
		byte* num2 = (byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)));
		System.IntPtr intPtr2 = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)textStyleStacks);
		*(System.IntPtr**)num2 = &intPtr2;
		byte* num3 = (byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)));
		System.IntPtr intPtr3 = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)generationSettings);
		*(System.IntPtr**)num3 = &intPtr3;
		Unsafe.SkipInit(out System.IntPtr intPtr4);
		System.IntPtr intPtr5 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InsertOpeningStyleTag_Internal_Static_Void_TextStyle_byref_Il2CppStructArray_1_TextProcessingElement_byref_Int32_byref_Int32_byref_Il2CppReferenceArray_1_TextProcessingStack_1_Int32_byref_TextGenerationSettings_0, (System.IntPtr)0, (void**)ptr, ref intPtr4);
		Il2CppException.RaiseExceptionIfNecessary(intPtr4);
		System.IntPtr intPtr6 = intPtr;
		charBuffer = ((intPtr6 == (System.IntPtr)0) ? null : new Il2CppStructArray<TextProcessingElement>(intPtr6));
		System.IntPtr intPtr7 = intPtr2;
		textStyleStacks = ((intPtr7 == (System.IntPtr)0) ? null : new Il2CppReferenceArray<TextProcessingStack<int>>(intPtr7));
		System.IntPtr intPtr8 = intPtr3;
		generationSettings = ((intPtr8 == (System.IntPtr)0) ? null : new TextGenerationSettings(intPtr8));
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1282687, RefRangeEnd = 1282688, XrefRangeStart = 1282679, XrefRangeEnd = 1282687, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void InsertClosingStyleTag(ref Il2CppStructArray<TextProcessingElement> charBuffer, ref int writeIndex, ref int textStyleStackDepth, ref Il2CppReferenceArray<TextProcessingStack<int>> textStyleStacks, ref TextGenerationSettings generationSettings)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)charBuffer);
		*ptr = (nint)(&intPtr);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref writeIndex);
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref textStyleStackDepth);
		byte* num = (byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)));
		System.IntPtr intPtr2 = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)textStyleStacks);
		*(System.IntPtr**)num = &intPtr2;
		byte* num2 = (byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)));
		System.IntPtr intPtr3 = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)generationSettings);
		*(System.IntPtr**)num2 = &intPtr3;
		Unsafe.SkipInit(out System.IntPtr intPtr4);
		System.IntPtr intPtr5 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InsertClosingStyleTag_Internal_Static_Void_byref_Il2CppStructArray_1_TextProcessingElement_byref_Int32_byref_Int32_byref_Il2CppReferenceArray_1_TextProcessingStack_1_Int32_byref_TextGenerationSettings_0, (System.IntPtr)0, (void**)ptr, ref intPtr4);
		Il2CppException.RaiseExceptionIfNecessary(intPtr4);
		System.IntPtr intPtr6 = intPtr;
		charBuffer = ((intPtr6 == (System.IntPtr)0) ? null : new Il2CppStructArray<TextProcessingElement>(intPtr6));
		System.IntPtr intPtr7 = intPtr2;
		textStyleStacks = ((intPtr7 == (System.IntPtr)0) ? null : new Il2CppReferenceArray<TextProcessingStack<int>>(intPtr7));
		System.IntPtr intPtr8 = intPtr3;
		generationSettings = ((intPtr8 == (System.IntPtr)0) ? null : new TextGenerationSettings(intPtr8));
	}

	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 1282726, RefRangeEnd = 1282733, XrefRangeStart = 1282688, XrefRangeEnd = 1282726, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void InsertTextStyleInTextProcessingArray(ref Il2CppStructArray<TextProcessingElement> charBuffer, ref int writeIndex, Il2CppStructArray<uint> styleDefinition, ref int textStyleStackDepth, ref Il2CppReferenceArray<TextProcessingStack<int>> textStyleStacks, ref TextGenerationSettings generationSettings)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)charBuffer);
		*ptr = (nint)(&intPtr);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref writeIndex);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)styleDefinition);
		*(void**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref textStyleStackDepth);
		byte* num = (byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)));
		System.IntPtr intPtr2 = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)textStyleStacks);
		*(System.IntPtr**)num = &intPtr2;
		byte* num2 = (byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)));
		System.IntPtr intPtr3 = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)generationSettings);
		*(System.IntPtr**)num2 = &intPtr3;
		Unsafe.SkipInit(out System.IntPtr intPtr4);
		System.IntPtr intPtr5 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InsertTextStyleInTextProcessingArray_Private_Static_Void_byref_Il2CppStructArray_1_TextProcessingElement_byref_Int32_Il2CppStructArray_1_UInt32_byref_Int32_byref_Il2CppReferenceArray_1_TextProcessingStack_1_Int32_byref_TextGenerationSettings_0, (System.IntPtr)0, (void**)ptr, ref intPtr4);
		Il2CppException.RaiseExceptionIfNecessary(intPtr4);
		System.IntPtr intPtr6 = intPtr;
		charBuffer = ((intPtr6 == (System.IntPtr)0) ? null : new Il2CppStructArray<TextProcessingElement>(intPtr6));
		System.IntPtr intPtr7 = intPtr2;
		textStyleStacks = ((intPtr7 == (System.IntPtr)0) ? null : new Il2CppReferenceArray<TextProcessingStack<int>>(intPtr7));
		System.IntPtr intPtr8 = intPtr3;
		generationSettings = ((intPtr8 == (System.IntPtr)0) ? null : new TextGenerationSettings(intPtr8));
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 1282741, RefRangeEnd = 1282747, XrefRangeStart = 1282733, XrefRangeEnd = 1282741, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static TextStyle GetStyle(TextGenerationSettings generationSetting, int hashCode)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)generationSetting);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &hashCode;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetStyle_Public_Static_TextStyle_TextGenerationSettings_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<TextStyle>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1282747, XrefRangeEnd = 1282752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int GetStyleHashCode(ref Il2CppStructArray<uint> text, int index, out int closeIndex)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)text);
		*ptr = (nint)(&intPtr);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &index;
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref closeIndex);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetStyleHashCode_Public_Static_Int32_byref_Il2CppStructArray_1_UInt32_Int32_byref_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		System.IntPtr intPtr4 = intPtr;
		text = ((intPtr4 == (System.IntPtr)0) ? null : new Il2CppStructArray<uint>(intPtr4));
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr3);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1282752, XrefRangeEnd = 1282757, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int GetStyleHashCode(ref TextBackingContainer text, int index, out int closeIndex)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)text);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &index;
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref closeIndex);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetStyleHashCode_Public_Static_Int32_byref_TextBackingContainer_Int32_byref_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1282764, RefRangeEnd = 1282765, XrefRangeStart = 1282757, XrefRangeEnd = 1282764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static uint GetUTF16(Il2CppStructArray<uint> text, int i)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)text);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &i;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetUTF16_Public_Static_UInt32_Il2CppStructArray_1_UInt32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(uint*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1282765, XrefRangeEnd = 1282772, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static uint GetUTF16(TextBackingContainer text, int i)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)text));
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &i;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetUTF16_Public_Static_UInt32_TextBackingContainer_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(uint*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1282783, RefRangeEnd = 1282784, XrefRangeStart = 1282772, XrefRangeEnd = 1282783, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static uint GetUTF32(Il2CppStructArray<uint> text, int i)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)text);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &i;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetUTF32_Public_Static_UInt32_Il2CppStructArray_1_UInt32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(uint*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1282784, XrefRangeEnd = 1282795, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static uint GetUTF32(TextBackingContainer text, int i)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)text));
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &i;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetUTF32_Public_Static_UInt32_TextBackingContainer_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(uint*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1282813, RefRangeEnd = 1282814, XrefRangeStart = 1282795, XrefRangeEnd = 1282813, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void FillCharacterVertexBuffers(int i, bool convertToLinearSpace, TextGenerationSettings generationSettings, TextInfo textInfo)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&i);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &convertToLinearSpace;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)generationSettings);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)textInfo);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FillCharacterVertexBuffers_Public_Static_Void_Int32_Boolean_TextGenerationSettings_TextInfo_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1282831, RefRangeEnd = 1282832, XrefRangeStart = 1282814, XrefRangeEnd = 1282831, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void FillSpriteVertexBuffers(int i, bool convertToLinearSpace, TextGenerationSettings generationSettings, TextInfo textInfo)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&i);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &convertToLinearSpace;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)generationSettings);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)textInfo);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FillSpriteVertexBuffers_Public_Static_Void_Int32_Boolean_TextGenerationSettings_TextInfo_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1282832, RefRangeEnd = 1282834, XrefRangeStart = 1282832, XrefRangeEnd = 1282832, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void AdjustLineOffset(int startIndex, int endIndex, float offset, TextInfo textInfo)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&startIndex);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &endIndex;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &offset;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)textInfo);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AdjustLineOffset_Public_Static_Void_Int32_Int32_Single_TextInfo_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1282848, RefRangeEnd = 1282850, XrefRangeStart = 1282834, XrefRangeEnd = 1282848, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ResizeLineExtents(int size, TextInfo textInfo)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&size);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)textInfo);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ResizeLineExtents_Public_Static_Void_Int32_TextInfo_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1282850, RefRangeEnd = 1282853, XrefRangeStart = 1282850, XrefRangeEnd = 1282850, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static FontStyles LegacyStyleToNewStyle(FontStyle fontStyle)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&fontStyle);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LegacyStyleToNewStyle_Public_Static_FontStyles_FontStyle_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(FontStyles*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1282853, RefRangeEnd = 1282855, XrefRangeStart = 1282853, XrefRangeEnd = 1282853, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static TextAlignment LegacyAlignmentToNewAlignment(TextAnchor anchor)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&anchor);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LegacyAlignmentToNewAlignment_Public_Static_TextAlignment_TextAnchor_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(TextAlignment*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1282855, RefRangeEnd = 1282856, XrefRangeStart = 1282855, XrefRangeEnd = 1282855, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static UnityEngine.TextCore.HorizontalAlignment GetHorizontalAlignment(TextAnchor anchor)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&anchor);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetHorizontalAlignment_Internal_Static_HorizontalAlignment_TextAnchor_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(UnityEngine.TextCore.HorizontalAlignment*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1282856, RefRangeEnd = 1282857, XrefRangeStart = 1282856, XrefRangeEnd = 1282856, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static UnityEngine.TextCore.VerticalAlignment GetVerticalAlignment(TextAnchor anchor)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&anchor);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetVerticalAlignment_Internal_Static_VerticalAlignment_TextAnchor_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(UnityEngine.TextCore.VerticalAlignment*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1282857, RefRangeEnd = 1282858, XrefRangeStart = 1282857, XrefRangeEnd = 1282857, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static uint ConvertToUTF32(uint highSurrogate, uint lowSurrogate)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&highSurrogate);
		*(uint**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &lowSurrogate;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ConvertToUTF32_Public_Static_UInt32_UInt32_UInt32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(uint*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1282863, RefRangeEnd = 1282864, XrefRangeStart = 1282858, XrefRangeEnd = 1282863, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int GetMarkupTagHashCode(TextBackingContainer styleDefinition, int readIndex)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)styleDefinition));
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &readIndex;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetMarkupTagHashCode_Public_Static_Int32_TextBackingContainer_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1282869, RefRangeEnd = 1282870, XrefRangeStart = 1282864, XrefRangeEnd = 1282869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int GetMarkupTagHashCode(Il2CppStructArray<uint> styleDefinition, int readIndex)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)styleDefinition);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &readIndex;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetMarkupTagHashCode_Public_Static_Int32_Il2CppStructArray_1_UInt32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 1282873, RefRangeEnd = 1282877, XrefRangeStart = 1282870, XrefRangeEnd = 1282873, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static char ToUpperASCIIFast(char c)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&c);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToUpperASCIIFast_Public_Static_Char_Char_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(char*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1282880, RefRangeEnd = 1282882, XrefRangeStart = 1282877, XrefRangeEnd = 1282880, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static uint ToUpperASCIIFast(uint c)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&c);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToUpperASCIIFast_Public_Static_UInt32_UInt32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(uint*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1282885, RefRangeEnd = 1282888, XrefRangeStart = 1282882, XrefRangeEnd = 1282885, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static char ToUpperFast(char c)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&c);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToUpperFast_Public_Static_Char_Char_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(char*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1282888, XrefRangeEnd = 1282892, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int GetAttributeParameters(Il2CppStructArray<char> chars, int startIndex, int length, ref Il2CppStructArray<float> parameters)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)chars);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &startIndex;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &length;
		byte* num = (byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)));
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)parameters);
		*(System.IntPtr**)num = &intPtr;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetAttributeParameters_Public_Static_Int32_Il2CppStructArray_1_Char_Int32_Int32_byref_Il2CppStructArray_1_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		System.IntPtr intPtr4 = intPtr;
		parameters = ((intPtr4 == (System.IntPtr)0) ? null : new Il2CppStructArray<float>(intPtr4));
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr3);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1282892, RefRangeEnd = 1282894, XrefRangeStart = 1282892, XrefRangeEnd = 1282892, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool IsBitmapRendering(GlyphRenderMode glyphRenderMode)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&glyphRenderMode);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsBitmapRendering_Public_Static_Boolean_GlyphRenderMode_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1282894, RefRangeEnd = 1282896, XrefRangeStart = 1282894, XrefRangeEnd = 1282894, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool IsBaseGlyph(uint c)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&c);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsBaseGlyph_Public_Static_Boolean_UInt32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 1282896, RefRangeEnd = 1282900, XrefRangeStart = 1282896, XrefRangeEnd = 1282896, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Color MinAlpha(this Color c1, Color c2)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&c1);
		*(Color**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &c2;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MinAlpha_Public_Static_Color_Color_Color_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(Color*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(8)]
	[CachedScanResults(RefRangeStart = 1282906, RefRangeEnd = 1282914, XrefRangeStart = 1282900, XrefRangeEnd = 1282906, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Color32 GammaToLinear(Color32 c)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&c);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GammaToLinear_Internal_Static_Color32_Color32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(Color32*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1282914, RefRangeEnd = 1282917, XrefRangeStart = 1282914, XrefRangeEnd = 1282914, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static byte GammaToLinear(byte value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GammaToLinear_Private_Static_Byte_Byte_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(byte*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe static bool IsValidUTF16(TextBackingContainer text, int index)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)text));
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &index;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsValidUTF16_Public_Static_Boolean_TextBackingContainer_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe static bool IsValidUTF32(TextBackingContainer text, int index)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)text));
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &index;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsValidUTF32_Public_Static_Boolean_TextBackingContainer_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1282925, RefRangeEnd = 1282927, XrefRangeStart = 1282917, XrefRangeEnd = 1282925, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool IsEmoji(uint c)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&c);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsEmoji_Internal_Static_Boolean_UInt32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1282935, RefRangeEnd = 1282937, XrefRangeStart = 1282927, XrefRangeEnd = 1282935, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool IsEmojiPresentationForm(uint c)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&c);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsEmojiPresentationForm_Internal_Static_Boolean_UInt32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1282937, RefRangeEnd = 1282939, XrefRangeStart = 1282937, XrefRangeEnd = 1282937, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool IsHangul(uint c)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&c);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsHangul_Internal_Static_Boolean_UInt32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 1282939, RefRangeEnd = 1282943, XrefRangeStart = 1282939, XrefRangeEnd = 1282939, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool IsCJK(uint c)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&c);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsCJK_Internal_Static_Boolean_UInt32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	public TextGeneratorUtilities(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public static bool IsTagName(ref string text, string tag, int index)
	{
		if (text.Length < index + tag.Length)
		{
			return false;
		}
		for (int i = 0; i < tag.Length; i++)
		{
			if (TextUtilities.ToUpperFast(text[index + i]) != tag[i])
			{
				return false;
			}
		}
		return true;
	}

	public static bool IsTagName(ref Il2CppStructArray<int> text, string tag, int index)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	public static void ReplaceOpeningStyleTag(ref Il2CppStructArray<TextProcessingElement> charBuffer, ref int writeIndex, ref int textStyleStackDepth, ref Il2CppReferenceArray<TextProcessingStack<int>> textStyleStacks, ref TextGenerationSettings generationSettings)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}
}
