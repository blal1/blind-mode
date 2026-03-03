using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using UnityEngine.TextCore;

namespace Il2CppTMPro;

[System.Serializable]
public class TMP_Settings : ScriptableObject
{
	public class LineBreakingTable : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_leadingCharacters;

		private static readonly System.IntPtr NativeFieldInfoPtr_followingCharacters;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		public unsafe HashSet<uint> leadingCharacters
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_leadingCharacters);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<HashSet<uint>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_leadingCharacters)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe HashSet<uint> followingCharacters
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_followingCharacters);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<HashSet<uint>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_followingCharacters)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		static LineBreakingTable()
		{
			Il2CppClassPointerStore<LineBreakingTable>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TMP_Settings>.NativeClassPtr, "LineBreakingTable");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LineBreakingTable>.NativeClassPtr);
			NativeFieldInfoPtr_leadingCharacters = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LineBreakingTable>.NativeClassPtr, "leadingCharacters");
			NativeFieldInfoPtr_followingCharacters = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LineBreakingTable>.NativeClassPtr, "followingCharacters");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LineBreakingTable>.NativeClassPtr, 100664459);
		}

		[CallerCount(1950)]
		[CachedScanResults(RefRangeStart = 20036, RefRangeEnd = 21986, XrefRangeStart = 20036, XrefRangeEnd = 21986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LineBreakingTable()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LineBreakingTable>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		public LineBreakingTable(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_s_Instance;

	private static readonly System.IntPtr NativeFieldInfoPtr_assetVersion;

	private static readonly System.IntPtr NativeFieldInfoPtr_s_CurrentAssetVersion;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_TextWrappingMode;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_enableKerning;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_ActiveFontFeatures;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_enableExtraPadding;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_enableTintAllSprites;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_enableParseEscapeCharacters;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_EnableRaycastTarget;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_GetFontFeaturesAtRuntime;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_missingGlyphCharacter;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_ClearDynamicDataOnBuild;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_warningsDisabled;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_defaultFontAsset;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_defaultFontAssetPath;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_defaultFontSize;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_defaultAutoSizeMinRatio;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_defaultAutoSizeMaxRatio;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_defaultTextMeshProTextContainerSize;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_defaultTextMeshProUITextContainerSize;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_autoSizeTextContainer;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_IsTextObjectScaleStatic;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_fallbackFontAssets;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_matchMaterialPreset;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_HideSubTextObjects;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_defaultSpriteAsset;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_defaultSpriteAssetPath;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_enableEmojiSupport;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_MissingCharacterSpriteUnicode;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_EmojiFallbackTextAssets;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_defaultColorGradientPresetsPath;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_defaultStyleSheet;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_StyleSheetsResourcePath;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_leadingCharacters;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_followingCharacters;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_linebreakingRules;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_UseModernHangulLineBreakingRules;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_version_Public_Static_get_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetAssetVersion_Internal_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_textWrappingMode_Public_Static_get_TextWrappingModes_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_enableKerning_Public_Static_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_fontFeatures_Public_Static_get_List_1_OTL_FeatureTag_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_enableExtraPadding_Public_Static_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_enableTintAllSprites_Public_Static_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_enableParseEscapeCharacters_Public_Static_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_enableRaycastTarget_Public_Static_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_getFontFeaturesAtRuntime_Public_Static_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_missingGlyphCharacter_Public_Static_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_missingGlyphCharacter_Public_Static_set_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_clearDynamicDataOnBuild_Public_Static_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_warningsDisabled_Public_Static_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_defaultFontAsset_Public_Static_get_TMP_FontAsset_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_defaultFontAsset_Public_Static_set_Void_TMP_FontAsset_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_defaultFontAssetPath_Public_Static_get_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_defaultFontSize_Public_Static_get_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_defaultTextAutoSizingMinRatio_Public_Static_get_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_defaultTextAutoSizingMaxRatio_Public_Static_get_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_defaultTextMeshProTextContainerSize_Public_Static_get_Vector2_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_defaultTextMeshProUITextContainerSize_Public_Static_get_Vector2_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_autoSizeTextContainer_Public_Static_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_isTextObjectScaleStatic_Public_Static_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_isTextObjectScaleStatic_Public_Static_set_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_fallbackFontAssets_Public_Static_get_List_1_TMP_FontAsset_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_fallbackFontAssets_Public_Static_set_Void_List_1_TMP_FontAsset_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_matchMaterialPreset_Public_Static_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_hideSubTextObjects_Public_Static_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_defaultSpriteAsset_Public_Static_get_TMP_SpriteAsset_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_defaultSpriteAsset_Public_Static_set_Void_TMP_SpriteAsset_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_defaultSpriteAssetPath_Public_Static_get_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_enableEmojiSupport_Public_Static_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_enableEmojiSupport_Public_Static_set_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_missingCharacterSpriteUnicode_Public_Static_get_UInt32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_missingCharacterSpriteUnicode_Public_Static_set_Void_UInt32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_emojiFallbackTextAssets_Public_Static_get_List_1_TMP_Asset_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_emojiFallbackTextAssets_Public_Static_set_Void_List_1_TMP_Asset_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_defaultColorGradientPresetsPath_Public_Static_get_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_defaultStyleSheet_Public_Static_get_TMP_StyleSheet_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_defaultStyleSheet_Public_Static_set_Void_TMP_StyleSheet_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_styleSheetsResourcePath_Public_Static_get_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_leadingCharacters_Public_Static_get_TextAsset_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_followingCharacters_Public_Static_get_TextAsset_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_linebreakingRules_Public_Static_get_LineBreakingTable_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_useModernHangulLineBreakingRules_Public_Static_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_useModernHangulLineBreakingRules_Public_Static_set_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_instance_Public_Static_get_TMP_Settings_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_isTMPSettingsNull_Internal_Static_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LoadDefaultSettings_Public_Static_TMP_Settings_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetSettings_Public_Static_TMP_Settings_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetFontAsset_Public_Static_TMP_FontAsset_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetSpriteAsset_Public_Static_TMP_SpriteAsset_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetStyleSheet_Public_Static_TMP_StyleSheet_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LoadLinebreakingRules_Public_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetCharacters_Private_Static_HashSet_1_UInt32_TextAsset_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe static TMP_Settings s_Instance
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_Instance, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<TMP_Settings>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_Instance, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe string assetVersion
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_assetVersion);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_assetVersion)), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe static string s_CurrentAssetVersion
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_CurrentAssetVersion, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_CurrentAssetVersion, (void*)IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe TextWrappingModes m_TextWrappingMode
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_TextWrappingMode);
			return *(TextWrappingModes*)num;
		}
		set
		{
			*(TextWrappingModes*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_TextWrappingMode)) = value;
		}
	}

	public unsafe bool m_enableKerning
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_enableKerning);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_enableKerning)) = value;
		}
	}

	public unsafe List<OTL_FeatureTag> m_ActiveFontFeatures
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ActiveFontFeatures);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<OTL_FeatureTag>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ActiveFontFeatures)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe bool m_enableExtraPadding
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_enableExtraPadding);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_enableExtraPadding)) = value;
		}
	}

	public unsafe bool m_enableTintAllSprites
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_enableTintAllSprites);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_enableTintAllSprites)) = value;
		}
	}

	public unsafe bool m_enableParseEscapeCharacters
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_enableParseEscapeCharacters);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_enableParseEscapeCharacters)) = value;
		}
	}

	public unsafe bool m_EnableRaycastTarget
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_EnableRaycastTarget);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_EnableRaycastTarget)) = value;
		}
	}

	public unsafe bool m_GetFontFeaturesAtRuntime
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_GetFontFeaturesAtRuntime);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_GetFontFeaturesAtRuntime)) = value;
		}
	}

	public unsafe int m_missingGlyphCharacter
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_missingGlyphCharacter);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_missingGlyphCharacter)) = value;
		}
	}

	public unsafe bool m_ClearDynamicDataOnBuild
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ClearDynamicDataOnBuild);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ClearDynamicDataOnBuild)) = value;
		}
	}

	public unsafe bool m_warningsDisabled
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_warningsDisabled);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_warningsDisabled)) = value;
		}
	}

	public unsafe TMP_FontAsset m_defaultFontAsset
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_defaultFontAsset);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<TMP_FontAsset>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_defaultFontAsset)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe string m_defaultFontAssetPath
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_defaultFontAssetPath);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_defaultFontAssetPath)), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe float m_defaultFontSize
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_defaultFontSize);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_defaultFontSize)) = value;
		}
	}

	public unsafe float m_defaultAutoSizeMinRatio
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_defaultAutoSizeMinRatio);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_defaultAutoSizeMinRatio)) = value;
		}
	}

	public unsafe float m_defaultAutoSizeMaxRatio
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_defaultAutoSizeMaxRatio);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_defaultAutoSizeMaxRatio)) = value;
		}
	}

	public unsafe Vector2 m_defaultTextMeshProTextContainerSize
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_defaultTextMeshProTextContainerSize);
			return *(Vector2*)num;
		}
		set
		{
			*(Vector2*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_defaultTextMeshProTextContainerSize)) = value;
		}
	}

	public unsafe Vector2 m_defaultTextMeshProUITextContainerSize
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_defaultTextMeshProUITextContainerSize);
			return *(Vector2*)num;
		}
		set
		{
			*(Vector2*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_defaultTextMeshProUITextContainerSize)) = value;
		}
	}

	public unsafe bool m_autoSizeTextContainer
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_autoSizeTextContainer);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_autoSizeTextContainer)) = value;
		}
	}

	public unsafe bool m_IsTextObjectScaleStatic
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_IsTextObjectScaleStatic);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_IsTextObjectScaleStatic)) = value;
		}
	}

	public unsafe List<TMP_FontAsset> m_fallbackFontAssets
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_fallbackFontAssets);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<TMP_FontAsset>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_fallbackFontAssets)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe bool m_matchMaterialPreset
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_matchMaterialPreset);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_matchMaterialPreset)) = value;
		}
	}

	public unsafe bool m_HideSubTextObjects
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_HideSubTextObjects);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_HideSubTextObjects)) = value;
		}
	}

	public unsafe TMP_SpriteAsset m_defaultSpriteAsset
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_defaultSpriteAsset);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<TMP_SpriteAsset>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_defaultSpriteAsset)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe string m_defaultSpriteAssetPath
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_defaultSpriteAssetPath);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_defaultSpriteAssetPath)), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe bool m_enableEmojiSupport
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_enableEmojiSupport);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_enableEmojiSupport)) = value;
		}
	}

	public unsafe uint m_MissingCharacterSpriteUnicode
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_MissingCharacterSpriteUnicode);
			return *(uint*)num;
		}
		set
		{
			*(uint*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_MissingCharacterSpriteUnicode)) = value;
		}
	}

	public unsafe List<TMP_Asset> m_EmojiFallbackTextAssets
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_EmojiFallbackTextAssets);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<TMP_Asset>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_EmojiFallbackTextAssets)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe string m_defaultColorGradientPresetsPath
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_defaultColorGradientPresetsPath);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_defaultColorGradientPresetsPath)), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe TMP_StyleSheet m_defaultStyleSheet
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_defaultStyleSheet);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<TMP_StyleSheet>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_defaultStyleSheet)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe string m_StyleSheetsResourcePath
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_StyleSheetsResourcePath);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_StyleSheetsResourcePath)), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe TextAsset m_leadingCharacters
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_leadingCharacters);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<TextAsset>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_leadingCharacters)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe TextAsset m_followingCharacters
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_followingCharacters);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<TextAsset>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_followingCharacters)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe LineBreakingTable m_linebreakingRules
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_linebreakingRules);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<LineBreakingTable>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_linebreakingRules)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe bool m_UseModernHangulLineBreakingRules
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_UseModernHangulLineBreakingRules);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_UseModernHangulLineBreakingRules)) = value;
		}
	}

	public unsafe static string version
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1128447, XrefRangeEnd = 1128449, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_version_Public_Static_get_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return IL2CPP.Il2CppStringToManaged(intPtr2);
		}
	}

	public unsafe static TextWrappingModes textWrappingMode
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1128465, RefRangeEnd = 1128466, XrefRangeStart = 1128461, XrefRangeEnd = 1128465, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_textWrappingMode_Public_Static_get_TextWrappingModes_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(TextWrappingModes*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe static bool enableKerning
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1128466, XrefRangeEnd = 1128474, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_enableKerning_Public_Static_get_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe static List<OTL_FeatureTag> fontFeatures
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1128478, RefRangeEnd = 1128479, XrefRangeStart = 1128474, XrefRangeEnd = 1128478, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_fontFeatures_Public_Static_get_List_1_OTL_FeatureTag_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<OTL_FeatureTag>>(intPtr2) : null;
		}
	}

	public unsafe static bool enableExtraPadding
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1128483, RefRangeEnd = 1128484, XrefRangeStart = 1128479, XrefRangeEnd = 1128483, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_enableExtraPadding_Public_Static_get_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe static bool enableTintAllSprites
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1128488, RefRangeEnd = 1128489, XrefRangeStart = 1128484, XrefRangeEnd = 1128488, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_enableTintAllSprites_Public_Static_get_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe static bool enableParseEscapeCharacters
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1128493, RefRangeEnd = 1128494, XrefRangeStart = 1128489, XrefRangeEnd = 1128493, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_enableParseEscapeCharacters_Public_Static_get_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe static bool enableRaycastTarget
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1128498, RefRangeEnd = 1128499, XrefRangeStart = 1128494, XrefRangeEnd = 1128498, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_enableRaycastTarget_Public_Static_get_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe static bool getFontFeaturesAtRuntime
	{
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1128503, RefRangeEnd = 1128506, XrefRangeStart = 1128499, XrefRangeEnd = 1128503, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_getFontFeaturesAtRuntime_Public_Static_get_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe static int missingGlyphCharacter
	{
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1128510, RefRangeEnd = 1128514, XrefRangeStart = 1128506, XrefRangeEnd = 1128510, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_missingGlyphCharacter_Public_Static_get_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1128514, XrefRangeEnd = 1128518, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_missingGlyphCharacter_Public_Static_set_Void_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe static bool clearDynamicDataOnBuild
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1128522, RefRangeEnd = 1128523, XrefRangeStart = 1128518, XrefRangeEnd = 1128522, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_clearDynamicDataOnBuild_Public_Static_get_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe static bool warningsDisabled
	{
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 1128527, RefRangeEnd = 1128533, XrefRangeStart = 1128523, XrefRangeEnd = 1128527, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_warningsDisabled_Public_Static_get_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe static TMP_FontAsset defaultFontAsset
	{
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 1128537, RefRangeEnd = 1128551, XrefRangeStart = 1128533, XrefRangeEnd = 1128537, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_defaultFontAsset_Public_Static_get_TMP_FontAsset_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<TMP_FontAsset>(intPtr2) : null;
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1128551, XrefRangeEnd = 1128557, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_defaultFontAsset_Public_Static_set_Void_TMP_FontAsset_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe static string defaultFontAssetPath
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1128561, RefRangeEnd = 1128562, XrefRangeStart = 1128557, XrefRangeEnd = 1128561, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_defaultFontAssetPath_Public_Static_get_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return IL2CPP.Il2CppStringToManaged(intPtr2);
		}
	}

	public unsafe static float defaultFontSize
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1128566, RefRangeEnd = 1128567, XrefRangeStart = 1128562, XrefRangeEnd = 1128566, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_defaultFontSize_Public_Static_get_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe static float defaultTextAutoSizingMinRatio
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1128571, RefRangeEnd = 1128572, XrefRangeStart = 1128567, XrefRangeEnd = 1128571, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_defaultTextAutoSizingMinRatio_Public_Static_get_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe static float defaultTextAutoSizingMaxRatio
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1128576, RefRangeEnd = 1128577, XrefRangeStart = 1128572, XrefRangeEnd = 1128576, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_defaultTextAutoSizingMaxRatio_Public_Static_get_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe static Vector2 defaultTextMeshProTextContainerSize
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1128581, RefRangeEnd = 1128582, XrefRangeStart = 1128577, XrefRangeEnd = 1128581, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_defaultTextMeshProTextContainerSize_Public_Static_get_Vector2_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(Vector2*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe static Vector2 defaultTextMeshProUITextContainerSize
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1128586, RefRangeEnd = 1128587, XrefRangeStart = 1128582, XrefRangeEnd = 1128586, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_defaultTextMeshProUITextContainerSize_Public_Static_get_Vector2_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(Vector2*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe static bool autoSizeTextContainer
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1128591, RefRangeEnd = 1128592, XrefRangeStart = 1128587, XrefRangeEnd = 1128591, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_autoSizeTextContainer_Public_Static_get_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe static bool isTextObjectScaleStatic
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1128596, RefRangeEnd = 1128597, XrefRangeStart = 1128592, XrefRangeEnd = 1128596, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_isTextObjectScaleStatic_Public_Static_get_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1128597, XrefRangeEnd = 1128601, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_isTextObjectScaleStatic_Public_Static_set_Void_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe static List<TMP_FontAsset> fallbackFontAssets
	{
		[CallerCount(19)]
		[CachedScanResults(RefRangeStart = 1128605, RefRangeEnd = 1128624, XrefRangeStart = 1128601, XrefRangeEnd = 1128605, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_fallbackFontAssets_Public_Static_get_List_1_TMP_FontAsset_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<TMP_FontAsset>>(intPtr2) : null;
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1128624, XrefRangeEnd = 1128630, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_fallbackFontAssets_Public_Static_set_Void_List_1_TMP_FontAsset_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe static bool matchMaterialPreset
	{
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1128634, RefRangeEnd = 1128638, XrefRangeStart = 1128630, XrefRangeEnd = 1128634, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_matchMaterialPreset_Public_Static_get_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe static bool hideSubTextObjects
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1128638, XrefRangeEnd = 1128642, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_hideSubTextObjects_Public_Static_get_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe static TMP_SpriteAsset defaultSpriteAsset
	{
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 1128646, RefRangeEnd = 1128652, XrefRangeStart = 1128642, XrefRangeEnd = 1128646, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_defaultSpriteAsset_Public_Static_get_TMP_SpriteAsset_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<TMP_SpriteAsset>(intPtr2) : null;
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1128652, XrefRangeEnd = 1128658, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_defaultSpriteAsset_Public_Static_set_Void_TMP_SpriteAsset_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe static string defaultSpriteAssetPath
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1128658, XrefRangeEnd = 1128662, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_defaultSpriteAssetPath_Public_Static_get_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return IL2CPP.Il2CppStringToManaged(intPtr2);
		}
	}

	public unsafe static bool enableEmojiSupport
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1128662, XrefRangeEnd = 1128666, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_enableEmojiSupport_Public_Static_get_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1128666, XrefRangeEnd = 1128670, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_enableEmojiSupport_Public_Static_set_Void_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe static uint missingCharacterSpriteUnicode
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1128670, XrefRangeEnd = 1128674, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_missingCharacterSpriteUnicode_Public_Static_get_UInt32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(uint*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1128674, XrefRangeEnd = 1128678, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_missingCharacterSpriteUnicode_Public_Static_set_Void_UInt32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe static List<TMP_Asset> emojiFallbackTextAssets
	{
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 1128682, RefRangeEnd = 1128688, XrefRangeStart = 1128678, XrefRangeEnd = 1128682, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_emojiFallbackTextAssets_Public_Static_get_List_1_TMP_Asset_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<TMP_Asset>>(intPtr2) : null;
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1128688, XrefRangeEnd = 1128694, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_emojiFallbackTextAssets_Public_Static_set_Void_List_1_TMP_Asset_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe static string defaultColorGradientPresetsPath
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1128694, XrefRangeEnd = 1128698, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_defaultColorGradientPresetsPath_Public_Static_get_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return IL2CPP.Il2CppStringToManaged(intPtr2);
		}
	}

	public unsafe static TMP_StyleSheet defaultStyleSheet
	{
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1128702, RefRangeEnd = 1128704, XrefRangeStart = 1128698, XrefRangeEnd = 1128702, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_defaultStyleSheet_Public_Static_get_TMP_StyleSheet_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<TMP_StyleSheet>(intPtr2) : null;
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1128704, XrefRangeEnd = 1128710, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_defaultStyleSheet_Public_Static_set_Void_TMP_StyleSheet_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe static string styleSheetsResourcePath
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1128710, XrefRangeEnd = 1128714, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_styleSheetsResourcePath_Public_Static_get_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return IL2CPP.Il2CppStringToManaged(intPtr2);
		}
	}

	public unsafe static TextAsset leadingCharacters
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1128714, XrefRangeEnd = 1128718, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_leadingCharacters_Public_Static_get_TextAsset_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<TextAsset>(intPtr2) : null;
		}
	}

	public unsafe static TextAsset followingCharacters
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1128718, XrefRangeEnd = 1128722, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_followingCharacters_Public_Static_get_TextAsset_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<TextAsset>(intPtr2) : null;
		}
	}

	public unsafe static LineBreakingTable linebreakingRules
	{
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 1128732, RefRangeEnd = 1128741, XrefRangeStart = 1128722, XrefRangeEnd = 1128732, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_linebreakingRules_Public_Static_get_LineBreakingTable_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<LineBreakingTable>(intPtr2) : null;
		}
	}

	public unsafe static bool useModernHangulLineBreakingRules
	{
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1128745, RefRangeEnd = 1128748, XrefRangeStart = 1128741, XrefRangeEnd = 1128745, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_useModernHangulLineBreakingRules_Public_Static_get_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1128752, RefRangeEnd = 1128753, XrefRangeStart = 1128748, XrefRangeEnd = 1128752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_useModernHangulLineBreakingRules_Public_Static_set_Void_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe static TMP_Settings instance
	{
		[CallerCount(61)]
		[CachedScanResults(RefRangeStart = 1128797, RefRangeEnd = 1128858, XrefRangeStart = 1128753, XrefRangeEnd = 1128797, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_instance_Public_Static_get_TMP_Settings_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<TMP_Settings>(intPtr2) : null;
		}
	}

	public unsafe static bool isTMPSettingsNull
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1128866, RefRangeEnd = 1128867, XrefRangeStart = 1128858, XrefRangeEnd = 1128866, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_isTMPSettingsNull_Internal_Static_get_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	static TMP_Settings()
	{
		Il2CppClassPointerStore<TMP_Settings>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.TextMeshPro.dll", "TMPro", "TMP_Settings");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TMP_Settings>.NativeClassPtr);
		NativeFieldInfoPtr_s_Instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Settings>.NativeClassPtr, "s_Instance");
		NativeFieldInfoPtr_assetVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Settings>.NativeClassPtr, "assetVersion");
		NativeFieldInfoPtr_s_CurrentAssetVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Settings>.NativeClassPtr, "s_CurrentAssetVersion");
		NativeFieldInfoPtr_m_TextWrappingMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Settings>.NativeClassPtr, "m_TextWrappingMode");
		NativeFieldInfoPtr_m_enableKerning = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Settings>.NativeClassPtr, "m_enableKerning");
		NativeFieldInfoPtr_m_ActiveFontFeatures = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Settings>.NativeClassPtr, "m_ActiveFontFeatures");
		NativeFieldInfoPtr_m_enableExtraPadding = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Settings>.NativeClassPtr, "m_enableExtraPadding");
		NativeFieldInfoPtr_m_enableTintAllSprites = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Settings>.NativeClassPtr, "m_enableTintAllSprites");
		NativeFieldInfoPtr_m_enableParseEscapeCharacters = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Settings>.NativeClassPtr, "m_enableParseEscapeCharacters");
		NativeFieldInfoPtr_m_EnableRaycastTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Settings>.NativeClassPtr, "m_EnableRaycastTarget");
		NativeFieldInfoPtr_m_GetFontFeaturesAtRuntime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Settings>.NativeClassPtr, "m_GetFontFeaturesAtRuntime");
		NativeFieldInfoPtr_m_missingGlyphCharacter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Settings>.NativeClassPtr, "m_missingGlyphCharacter");
		NativeFieldInfoPtr_m_ClearDynamicDataOnBuild = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Settings>.NativeClassPtr, "m_ClearDynamicDataOnBuild");
		NativeFieldInfoPtr_m_warningsDisabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Settings>.NativeClassPtr, "m_warningsDisabled");
		NativeFieldInfoPtr_m_defaultFontAsset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Settings>.NativeClassPtr, "m_defaultFontAsset");
		NativeFieldInfoPtr_m_defaultFontAssetPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Settings>.NativeClassPtr, "m_defaultFontAssetPath");
		NativeFieldInfoPtr_m_defaultFontSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Settings>.NativeClassPtr, "m_defaultFontSize");
		NativeFieldInfoPtr_m_defaultAutoSizeMinRatio = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Settings>.NativeClassPtr, "m_defaultAutoSizeMinRatio");
		NativeFieldInfoPtr_m_defaultAutoSizeMaxRatio = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Settings>.NativeClassPtr, "m_defaultAutoSizeMaxRatio");
		NativeFieldInfoPtr_m_defaultTextMeshProTextContainerSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Settings>.NativeClassPtr, "m_defaultTextMeshProTextContainerSize");
		NativeFieldInfoPtr_m_defaultTextMeshProUITextContainerSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Settings>.NativeClassPtr, "m_defaultTextMeshProUITextContainerSize");
		NativeFieldInfoPtr_m_autoSizeTextContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Settings>.NativeClassPtr, "m_autoSizeTextContainer");
		NativeFieldInfoPtr_m_IsTextObjectScaleStatic = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Settings>.NativeClassPtr, "m_IsTextObjectScaleStatic");
		NativeFieldInfoPtr_m_fallbackFontAssets = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Settings>.NativeClassPtr, "m_fallbackFontAssets");
		NativeFieldInfoPtr_m_matchMaterialPreset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Settings>.NativeClassPtr, "m_matchMaterialPreset");
		NativeFieldInfoPtr_m_HideSubTextObjects = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Settings>.NativeClassPtr, "m_HideSubTextObjects");
		NativeFieldInfoPtr_m_defaultSpriteAsset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Settings>.NativeClassPtr, "m_defaultSpriteAsset");
		NativeFieldInfoPtr_m_defaultSpriteAssetPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Settings>.NativeClassPtr, "m_defaultSpriteAssetPath");
		NativeFieldInfoPtr_m_enableEmojiSupport = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Settings>.NativeClassPtr, "m_enableEmojiSupport");
		NativeFieldInfoPtr_m_MissingCharacterSpriteUnicode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Settings>.NativeClassPtr, "m_MissingCharacterSpriteUnicode");
		NativeFieldInfoPtr_m_EmojiFallbackTextAssets = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Settings>.NativeClassPtr, "m_EmojiFallbackTextAssets");
		NativeFieldInfoPtr_m_defaultColorGradientPresetsPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Settings>.NativeClassPtr, "m_defaultColorGradientPresetsPath");
		NativeFieldInfoPtr_m_defaultStyleSheet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Settings>.NativeClassPtr, "m_defaultStyleSheet");
		NativeFieldInfoPtr_m_StyleSheetsResourcePath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Settings>.NativeClassPtr, "m_StyleSheetsResourcePath");
		NativeFieldInfoPtr_m_leadingCharacters = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Settings>.NativeClassPtr, "m_leadingCharacters");
		NativeFieldInfoPtr_m_followingCharacters = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Settings>.NativeClassPtr, "m_followingCharacters");
		NativeFieldInfoPtr_m_linebreakingRules = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Settings>.NativeClassPtr, "m_linebreakingRules");
		NativeFieldInfoPtr_m_UseModernHangulLineBreakingRules = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Settings>.NativeClassPtr, "m_UseModernHangulLineBreakingRules");
		NativeMethodInfoPtr_get_version_Public_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Settings>.NativeClassPtr, 100664401);
		NativeMethodInfoPtr_SetAssetVersion_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Settings>.NativeClassPtr, 100664402);
		NativeMethodInfoPtr_get_textWrappingMode_Public_Static_get_TextWrappingModes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Settings>.NativeClassPtr, 100664403);
		NativeMethodInfoPtr_get_enableKerning_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Settings>.NativeClassPtr, 100664404);
		NativeMethodInfoPtr_get_fontFeatures_Public_Static_get_List_1_OTL_FeatureTag_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Settings>.NativeClassPtr, 100664405);
		NativeMethodInfoPtr_get_enableExtraPadding_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Settings>.NativeClassPtr, 100664406);
		NativeMethodInfoPtr_get_enableTintAllSprites_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Settings>.NativeClassPtr, 100664407);
		NativeMethodInfoPtr_get_enableParseEscapeCharacters_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Settings>.NativeClassPtr, 100664408);
		NativeMethodInfoPtr_get_enableRaycastTarget_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Settings>.NativeClassPtr, 100664409);
		NativeMethodInfoPtr_get_getFontFeaturesAtRuntime_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Settings>.NativeClassPtr, 100664410);
		NativeMethodInfoPtr_get_missingGlyphCharacter_Public_Static_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Settings>.NativeClassPtr, 100664411);
		NativeMethodInfoPtr_set_missingGlyphCharacter_Public_Static_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Settings>.NativeClassPtr, 100664412);
		NativeMethodInfoPtr_get_clearDynamicDataOnBuild_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Settings>.NativeClassPtr, 100664413);
		NativeMethodInfoPtr_get_warningsDisabled_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Settings>.NativeClassPtr, 100664414);
		NativeMethodInfoPtr_get_defaultFontAsset_Public_Static_get_TMP_FontAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Settings>.NativeClassPtr, 100664415);
		NativeMethodInfoPtr_set_defaultFontAsset_Public_Static_set_Void_TMP_FontAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Settings>.NativeClassPtr, 100664416);
		NativeMethodInfoPtr_get_defaultFontAssetPath_Public_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Settings>.NativeClassPtr, 100664417);
		NativeMethodInfoPtr_get_defaultFontSize_Public_Static_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Settings>.NativeClassPtr, 100664418);
		NativeMethodInfoPtr_get_defaultTextAutoSizingMinRatio_Public_Static_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Settings>.NativeClassPtr, 100664419);
		NativeMethodInfoPtr_get_defaultTextAutoSizingMaxRatio_Public_Static_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Settings>.NativeClassPtr, 100664420);
		NativeMethodInfoPtr_get_defaultTextMeshProTextContainerSize_Public_Static_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Settings>.NativeClassPtr, 100664421);
		NativeMethodInfoPtr_get_defaultTextMeshProUITextContainerSize_Public_Static_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Settings>.NativeClassPtr, 100664422);
		NativeMethodInfoPtr_get_autoSizeTextContainer_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Settings>.NativeClassPtr, 100664423);
		NativeMethodInfoPtr_get_isTextObjectScaleStatic_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Settings>.NativeClassPtr, 100664424);
		NativeMethodInfoPtr_set_isTextObjectScaleStatic_Public_Static_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Settings>.NativeClassPtr, 100664425);
		NativeMethodInfoPtr_get_fallbackFontAssets_Public_Static_get_List_1_TMP_FontAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Settings>.NativeClassPtr, 100664426);
		NativeMethodInfoPtr_set_fallbackFontAssets_Public_Static_set_Void_List_1_TMP_FontAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Settings>.NativeClassPtr, 100664427);
		NativeMethodInfoPtr_get_matchMaterialPreset_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Settings>.NativeClassPtr, 100664428);
		NativeMethodInfoPtr_get_hideSubTextObjects_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Settings>.NativeClassPtr, 100664429);
		NativeMethodInfoPtr_get_defaultSpriteAsset_Public_Static_get_TMP_SpriteAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Settings>.NativeClassPtr, 100664430);
		NativeMethodInfoPtr_set_defaultSpriteAsset_Public_Static_set_Void_TMP_SpriteAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Settings>.NativeClassPtr, 100664431);
		NativeMethodInfoPtr_get_defaultSpriteAssetPath_Public_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Settings>.NativeClassPtr, 100664432);
		NativeMethodInfoPtr_get_enableEmojiSupport_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Settings>.NativeClassPtr, 100664433);
		NativeMethodInfoPtr_set_enableEmojiSupport_Public_Static_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Settings>.NativeClassPtr, 100664434);
		NativeMethodInfoPtr_get_missingCharacterSpriteUnicode_Public_Static_get_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Settings>.NativeClassPtr, 100664435);
		NativeMethodInfoPtr_set_missingCharacterSpriteUnicode_Public_Static_set_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Settings>.NativeClassPtr, 100664436);
		NativeMethodInfoPtr_get_emojiFallbackTextAssets_Public_Static_get_List_1_TMP_Asset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Settings>.NativeClassPtr, 100664437);
		NativeMethodInfoPtr_set_emojiFallbackTextAssets_Public_Static_set_Void_List_1_TMP_Asset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Settings>.NativeClassPtr, 100664438);
		NativeMethodInfoPtr_get_defaultColorGradientPresetsPath_Public_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Settings>.NativeClassPtr, 100664439);
		NativeMethodInfoPtr_get_defaultStyleSheet_Public_Static_get_TMP_StyleSheet_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Settings>.NativeClassPtr, 100664440);
		NativeMethodInfoPtr_set_defaultStyleSheet_Public_Static_set_Void_TMP_StyleSheet_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Settings>.NativeClassPtr, 100664441);
		NativeMethodInfoPtr_get_styleSheetsResourcePath_Public_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Settings>.NativeClassPtr, 100664442);
		NativeMethodInfoPtr_get_leadingCharacters_Public_Static_get_TextAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Settings>.NativeClassPtr, 100664443);
		NativeMethodInfoPtr_get_followingCharacters_Public_Static_get_TextAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Settings>.NativeClassPtr, 100664444);
		NativeMethodInfoPtr_get_linebreakingRules_Public_Static_get_LineBreakingTable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Settings>.NativeClassPtr, 100664445);
		NativeMethodInfoPtr_get_useModernHangulLineBreakingRules_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Settings>.NativeClassPtr, 100664446);
		NativeMethodInfoPtr_set_useModernHangulLineBreakingRules_Public_Static_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Settings>.NativeClassPtr, 100664447);
		NativeMethodInfoPtr_get_instance_Public_Static_get_TMP_Settings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Settings>.NativeClassPtr, 100664448);
		NativeMethodInfoPtr_get_isTMPSettingsNull_Internal_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Settings>.NativeClassPtr, 100664449);
		NativeMethodInfoPtr_LoadDefaultSettings_Public_Static_TMP_Settings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Settings>.NativeClassPtr, 100664450);
		NativeMethodInfoPtr_GetSettings_Public_Static_TMP_Settings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Settings>.NativeClassPtr, 100664451);
		NativeMethodInfoPtr_GetFontAsset_Public_Static_TMP_FontAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Settings>.NativeClassPtr, 100664452);
		NativeMethodInfoPtr_GetSpriteAsset_Public_Static_TMP_SpriteAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Settings>.NativeClassPtr, 100664453);
		NativeMethodInfoPtr_GetStyleSheet_Public_Static_TMP_StyleSheet_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Settings>.NativeClassPtr, 100664454);
		NativeMethodInfoPtr_LoadLinebreakingRules_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Settings>.NativeClassPtr, 100664455);
		NativeMethodInfoPtr_GetCharacters_Private_Static_HashSet_1_UInt32_TextAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Settings>.NativeClassPtr, 100664456);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Settings>.NativeClassPtr, 100664457);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1128449, XrefRangeEnd = 1128461, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetAssetVersion()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetAssetVersion_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1128867, XrefRangeEnd = 1128891, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static TMP_Settings LoadDefaultSettings()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LoadDefaultSettings_Public_Static_TMP_Settings_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<TMP_Settings>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1128891, XrefRangeEnd = 1128902, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static TMP_Settings GetSettings()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetSettings_Public_Static_TMP_Settings_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<TMP_Settings>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1128902, XrefRangeEnd = 1128913, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static TMP_FontAsset GetFontAsset()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetFontAsset_Public_Static_TMP_FontAsset_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<TMP_FontAsset>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1128913, XrefRangeEnd = 1128924, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static TMP_SpriteAsset GetSpriteAsset()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetSpriteAsset_Public_Static_TMP_SpriteAsset_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<TMP_SpriteAsset>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1128924, XrefRangeEnd = 1128935, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static TMP_StyleSheet GetStyleSheet()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetStyleSheet_Public_Static_TMP_StyleSheet_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<TMP_StyleSheet>(intPtr2) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1128961, RefRangeEnd = 1128962, XrefRangeStart = 1128935, XrefRangeEnd = 1128961, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void LoadLinebreakingRules()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LoadLinebreakingRules_Public_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1128974, RefRangeEnd = 1128976, XrefRangeStart = 1128962, XrefRangeEnd = 1128974, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static HashSet<uint> GetCharacters(TextAsset file)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)file);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetCharacters_Private_Static_HashSet_1_UInt32_TextAsset_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<HashSet<uint>>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1128976, XrefRangeEnd = 1128990, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe TMP_Settings()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TMP_Settings>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public TMP_Settings(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
