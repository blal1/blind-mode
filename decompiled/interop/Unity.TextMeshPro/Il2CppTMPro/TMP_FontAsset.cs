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
using Unity.Profiling;
using UnityEngine;
using UnityEngine.TextCore;
using UnityEngine.TextCore.LowLevel;

namespace Il2CppTMPro;

[System.Serializable]
public class TMP_FontAsset : TMP_Asset
{
	[System.Serializable]
	[ObfuscatedName("TMPro.TMP_FontAsset+<>c")]
	public sealed class __c : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr___9;

		private static readonly System.IntPtr NativeFieldInfoPtr___9__145_0;

		private static readonly System.IntPtr NativeFieldInfoPtr___9__146_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__SortCharacterTable_b__145_0_Internal_UInt32_TMP_Character_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__SortGlyphTable_b__146_0_Internal_UInt32_Glyph_0;

		public unsafe static __c __9
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<__c>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe static Il2CppSystem.Func<TMP_Character, uint> __9__145_0
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__145_0, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Func<TMP_Character, uint>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__145_0, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe static Il2CppSystem.Func<Glyph, uint> __9__146_0
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__146_0, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Func<Glyph, uint>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__146_0, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		static __c()
		{
			Il2CppClassPointerStore<__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, "<>c");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c>.NativeClassPtr);
			NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9");
			NativeFieldInfoPtr___9__145_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__145_0");
			NativeFieldInfoPtr___9__146_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__146_0");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100663957);
			NativeMethodInfoPtr__SortCharacterTable_b__145_0_Internal_UInt32_TMP_Character_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100663958);
			NativeMethodInfoPtr__SortGlyphTable_b__146_0_Internal_UInt32_Glyph_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100663959);
		}

		[CallerCount(1950)]
		[CachedScanResults(RefRangeStart = 20036, RefRangeEnd = 21986, XrefRangeStart = 20036, XrefRangeEnd = 21986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(0)]
		public unsafe uint _SortCharacterTable_b__145_0(TMP_Character c)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)c);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__SortCharacterTable_b__145_0_Internal_UInt32_TMP_Character_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(uint*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1121765, XrefRangeEnd = 1121767, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe uint _SortGlyphTable_b__146_0(Glyph c)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)c);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__SortGlyphTable_b__146_0_Internal_UInt32_Glyph_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(uint*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		public __c(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	private sealed class MethodInfoStoreGeneric_CopyListDataToArray_Private_Void_List_1_T_byref_Il2CppArrayBase_1_T_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_CopyListDataToArray_Private_Void_List_1_T_byref_Il2CppArrayBase_1_T_0, Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_m_SourceFontFileGUID;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_CreationSettings;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_SourceFontFile;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_SourceFontFilePath;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_AtlasPopulationMode;

	private static readonly System.IntPtr NativeFieldInfoPtr_InternalDynamicOS;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_FamilyNameHashCode;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_StyleNameHashCode;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_GlyphTable;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_GlyphLookupDictionary;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_CharacterTable;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_CharacterLookupDictionary;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_AtlasTexture;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_AtlasTextures;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_AtlasTextureIndex;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_IsMultiAtlasTexturesEnabled;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_GetFontFeatures;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_ClearDynamicDataOnBuild;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_AtlasWidth;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_AtlasHeight;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_AtlasPadding;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_AtlasRenderMode;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_UsedGlyphRects;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_FreeGlyphRects;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_FontFeatureTable;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_ShouldReimportFontFeatures;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_FallbackFontAssetTable;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_FontWeightTable;

	private static readonly System.IntPtr NativeFieldInfoPtr_fontWeights;

	private static readonly System.IntPtr NativeFieldInfoPtr_normalStyle;

	private static readonly System.IntPtr NativeFieldInfoPtr_normalSpacingOffset;

	private static readonly System.IntPtr NativeFieldInfoPtr_boldStyle;

	private static readonly System.IntPtr NativeFieldInfoPtr_boldSpacing;

	private static readonly System.IntPtr NativeFieldInfoPtr_italicStyle;

	private static readonly System.IntPtr NativeFieldInfoPtr_tabSize;

	private static readonly System.IntPtr NativeFieldInfoPtr_IsFontAssetLookupTablesDirty;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_fontInfo;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_glyphInfoList;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_KerningTable;

	private static readonly System.IntPtr NativeFieldInfoPtr_fallbackFontAssets;

	private static readonly System.IntPtr NativeFieldInfoPtr_atlas;

	private static readonly System.IntPtr NativeFieldInfoPtr_s_CallbackInstances;

	private static readonly System.IntPtr NativeFieldInfoPtr_k_ReadFontAssetDefinitionMarker;

	private static readonly System.IntPtr NativeFieldInfoPtr_k_AddSynthesizedCharactersMarker;

	private static readonly System.IntPtr NativeFieldInfoPtr_k_TryAddGlyphMarker;

	private static readonly System.IntPtr NativeFieldInfoPtr_k_TryAddCharacterMarker;

	private static readonly System.IntPtr NativeFieldInfoPtr_k_TryAddCharactersMarker;

	private static readonly System.IntPtr NativeFieldInfoPtr_k_UpdateLigatureSubstitutionRecordsMarker;

	private static readonly System.IntPtr NativeFieldInfoPtr_k_UpdateGlyphAdjustmentRecordsMarker;

	private static readonly System.IntPtr NativeFieldInfoPtr_k_UpdateDiacriticalMarkAdjustmentRecordsMarker;

	private static readonly System.IntPtr NativeFieldInfoPtr_k_ClearFontAssetDataMarker;

	private static readonly System.IntPtr NativeFieldInfoPtr_k_UpdateFontAssetDataMarker;

	private static readonly System.IntPtr NativeFieldInfoPtr_s_DefaultMaterialSuffix;

	private static readonly System.IntPtr NativeFieldInfoPtr_k_SearchedFontAssetLookup;

	private static readonly System.IntPtr NativeFieldInfoPtr_k_FontAssets_FontFeaturesUpdateQueue;

	private static readonly System.IntPtr NativeFieldInfoPtr_k_FontAssets_FontFeaturesUpdateQueueLookup;

	private static readonly System.IntPtr NativeFieldInfoPtr_k_FontAssets_AtlasTexturesUpdateQueue;

	private static readonly System.IntPtr NativeFieldInfoPtr_k_FontAssets_AtlasTexturesUpdateQueueLookup;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_GlyphsToRender;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_GlyphsRendered;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_GlyphIndexList;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_GlyphIndexListNewlyAdded;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_GlyphsToAdd;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_GlyphsToAddLookup;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_CharactersToAdd;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_CharactersToAddLookup;

	private static readonly System.IntPtr NativeFieldInfoPtr_s_MissingCharacterList;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_MissingUnicodesFromFontFile;

	private static readonly System.IntPtr NativeFieldInfoPtr_k_GlyphIndexArray;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_creationSettings_Public_get_FontAssetCreationSettings_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_creationSettings_Public_set_Void_FontAssetCreationSettings_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_sourceFontFile_Public_get_Font_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_sourceFontFile_Internal_set_Void_Font_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_atlasPopulationMode_Public_get_AtlasPopulationMode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_atlasPopulationMode_Public_set_Void_AtlasPopulationMode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_familyNameHashCode_Internal_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_familyNameHashCode_Internal_set_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_styleNameHashCode_Internal_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_styleNameHashCode_Internal_set_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_glyphTable_Public_get_List_1_Glyph_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_glyphTable_Internal_set_Void_List_1_Glyph_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_glyphLookupTable_Public_get_Dictionary_2_UInt32_Glyph_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_characterTable_Public_get_List_1_TMP_Character_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_characterTable_Internal_set_Void_List_1_TMP_Character_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_characterLookupTable_Public_get_Dictionary_2_UInt32_TMP_Character_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_atlasTexture_Public_get_Texture2D_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_atlasTextures_Public_get_Il2CppReferenceArray_1_Texture2D_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_atlasTextures_Public_set_Void_Il2CppReferenceArray_1_Texture2D_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_atlasTextureCount_Public_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_isMultiAtlasTexturesEnabled_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_isMultiAtlasTexturesEnabled_Public_set_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_getFontFeatures_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_getFontFeatures_Public_set_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_clearDynamicDataOnBuild_Internal_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_clearDynamicDataOnBuild_Internal_set_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_atlasWidth_Public_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_atlasWidth_Internal_set_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_atlasHeight_Public_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_atlasHeight_Internal_set_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_atlasPadding_Public_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_atlasPadding_Internal_set_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_atlasRenderMode_Public_get_GlyphRenderMode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_atlasRenderMode_Internal_set_Void_GlyphRenderMode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_usedGlyphRects_Internal_get_List_1_GlyphRect_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_usedGlyphRects_Internal_set_Void_List_1_GlyphRect_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_freeGlyphRects_Internal_get_List_1_GlyphRect_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_freeGlyphRects_Internal_set_Void_List_1_GlyphRect_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_fontFeatureTable_Public_get_TMP_FontFeatureTable_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_fontFeatureTable_Internal_set_Void_TMP_FontFeatureTable_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_fallbackFontAssetTable_Public_get_List_1_TMP_FontAsset_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_fallbackFontAssetTable_Public_set_Void_List_1_TMP_FontAsset_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_fontWeightTable_Public_get_Il2CppReferenceArray_1_TMP_FontWeightPair_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_fontWeightTable_Internal_set_Void_Il2CppReferenceArray_1_TMP_FontWeightPair_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_fontInfo_Public_get_FaceInfo_Legacy_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateFontAsset_Public_Static_TMP_FontAsset_String_String_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateFontAsset_Public_Static_TMP_FontAsset_String_Int32_Int32_Int32_GlyphRenderMode_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateFontAsset_Private_Static_TMP_FontAsset_String_Int32_Int32_Int32_GlyphRenderMode_Int32_Int32_AtlasPopulationMode_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateFontAsset_Public_Static_TMP_FontAsset_Font_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateFontAsset_Public_Static_TMP_FontAsset_Font_Int32_Int32_GlyphRenderMode_Int32_Int32_AtlasPopulationMode_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateFontAsset_Private_Static_TMP_FontAsset_Font_Int32_Int32_Int32_GlyphRenderMode_Int32_Int32_AtlasPopulationMode_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateFontAssetInstance_Private_Static_TMP_FontAsset_Font_Int32_GlyphRenderMode_Int32_Int32_AtlasPopulationMode_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RegisterCallbackInstance_Private_Void_TMP_FontAsset_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ReadFontAssetDefinition_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InitializeDictionaryLookupTables_Internal_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InitializeGlyphLookupDictionary_Internal_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InitializeCharacterLookupDictionary_Internal_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ClearFallbackCharacterTable_Internal_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InitializeLigatureSubstitutionLookupDictionary_Internal_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InitializeGlyphPaidAdjustmentRecordsLookupDictionary_Internal_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InitializeMarkToBaseAdjustmentRecordsLookupDictionary_Internal_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InitializeMarkToMarkAdjustmentRecordsLookupDictionary_Internal_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddSynthesizedCharactersAndFaceMetrics_Internal_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddSynthesizedCharacter_Private_Void_UInt32_Boolean_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddCharacterToLookupCache_Internal_Void_UInt32_TMP_Character_FontStyles_FontWeight_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LoadFontFace_Internal_FontEngineError_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SortCharacterTable_Internal_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SortGlyphTable_Internal_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SortFontFeatureTable_Internal_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SortAllTables_Internal_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_HasCharacter_Public_Boolean_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_HasCharacter_Public_Boolean_Char_Boolean_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_HasCharacter_Internal_Private_Boolean_UInt32_Boolean_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_HasCharacters_Public_Boolean_String_byref_List_1_Char_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_HasCharacters_Public_Boolean_String_byref_Il2CppStructArray_1_UInt32_Boolean_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_HasCharacters_Public_Boolean_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetCharacters_Public_Static_String_TMP_FontAsset_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetCharactersArray_Public_Static_Il2CppStructArray_1_Int32_TMP_FontAsset_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetGlyphIndex_Internal_UInt32_UInt32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetGlyphVariantIndex_Internal_UInt32_UInt32_UInt32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RegisterFontAssetForFontFeatureUpdate_Internal_Static_Void_TMP_FontAsset_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UpdateFontFeaturesForFontAssetsInQueue_Internal_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RegisterAtlasTextureForApply_Internal_Static_Void_Texture2D_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UpdateAtlasTexturesInQueue_Internal_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UpdateFontAssetsInUpdateQueue_Internal_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TryAddCharacters_Public_Boolean_Il2CppStructArray_1_UInt32_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TryAddCharacters_Public_Boolean_Il2CppStructArray_1_UInt32_byref_Il2CppStructArray_1_UInt32_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TryAddCharacters_Public_Boolean_String_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TryAddCharacters_Public_Boolean_String_byref_String_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddGlyphInternal_Internal_Boolean_UInt32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TryAddGlyphInternal_Internal_Boolean_UInt32_byref_Glyph_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TryAddCharacterInternal_Internal_Boolean_UInt32_byref_TMP_Character_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TryGetCharacter_and_QueueRenderToTexture_Internal_Boolean_UInt32_byref_TMP_Character_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TryAddGlyphsToAtlasTextures_Internal_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TryAddGlyphsToNewAtlasTexture_Private_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetupNewAtlasTexture_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UpdateAtlasTexture_Internal_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UpdateFontFeaturesForNewlyAddedGlyphs_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UpdateGPOSFontFeaturesForNewlyAddedGlyphs_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ImportFontFeatures_Internal_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UpdateGSUBFontFeaturesForNewGlyphIndex_Private_Void_UInt32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UpdateLigatureSubstitutionRecords_Internal_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddLigatureSubstitutionRecords_Private_Void_Il2CppReferenceArray_1_LigatureSubstitutionRecord_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UpdateGlyphAdjustmentRecords_Internal_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddPairAdjustmentRecords_Private_Void_Il2CppStructArray_1_GlyphPairAdjustmentRecord_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UpdateGlyphAdjustmentRecords_Internal_Void_Il2CppStructArray_1_UInt32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UpdateDiacriticalMarkAdjustmentRecords_Internal_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddMarkToBaseAdjustmentRecords_Private_Void_Il2CppStructArray_1_MarkToBaseAdjustmentRecord_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddMarkToMarkAdjustmentRecords_Private_Void_Il2CppStructArray_1_MarkToMarkAdjustmentRecord_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CopyListDataToArray_Private_Void_List_1_T_byref_Il2CppArrayBase_1_T_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UpdateFontAssetData_Internal_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ClearFontAssetData_Public_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ClearCharacterAndGlyphTablesInternal_Internal_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ClearFontFeaturesInternal_Internal_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ClearCharacterAndGlyphTables_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ClearFontFeaturesTables_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ClearAtlasTextures_Internal_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DestroyAtlasTextures_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UpgradeGlyphAdjustmentTableToFontFeatureTable_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe string m_SourceFontFileGUID
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_SourceFontFileGUID);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_SourceFontFileGUID)), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe FontAssetCreationSettings m_CreationSettings
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_CreationSettings);
			return new FontAssetCreationSettings(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<FontAssetCreationSettings>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_CreationSettings), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<FontAssetCreationSettings>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe Font m_SourceFontFile
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_SourceFontFile);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Font>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_SourceFontFile)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe string m_SourceFontFilePath
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_SourceFontFilePath);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_SourceFontFilePath)), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe AtlasPopulationMode m_AtlasPopulationMode
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_AtlasPopulationMode);
			return *(AtlasPopulationMode*)num;
		}
		set
		{
			*(AtlasPopulationMode*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_AtlasPopulationMode)) = value;
		}
	}

	public unsafe bool InternalDynamicOS
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_InternalDynamicOS);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_InternalDynamicOS)) = value;
		}
	}

	public unsafe int m_FamilyNameHashCode
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_FamilyNameHashCode);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_FamilyNameHashCode)) = value;
		}
	}

	public unsafe int m_StyleNameHashCode
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_StyleNameHashCode);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_StyleNameHashCode)) = value;
		}
	}

	public unsafe List<Glyph> m_GlyphTable
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_GlyphTable);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<Glyph>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_GlyphTable)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe Dictionary<uint, Glyph> m_GlyphLookupDictionary
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_GlyphLookupDictionary);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<uint, Glyph>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_GlyphLookupDictionary)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe List<TMP_Character> m_CharacterTable
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_CharacterTable);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<TMP_Character>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_CharacterTable)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe Dictionary<uint, TMP_Character> m_CharacterLookupDictionary
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_CharacterLookupDictionary);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<uint, TMP_Character>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_CharacterLookupDictionary)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe Texture2D m_AtlasTexture
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_AtlasTexture);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Texture2D>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_AtlasTexture)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe Il2CppReferenceArray<Texture2D> m_AtlasTextures
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_AtlasTextures);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Texture2D>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_AtlasTextures)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe int m_AtlasTextureIndex
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_AtlasTextureIndex);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_AtlasTextureIndex)) = value;
		}
	}

	public unsafe bool m_IsMultiAtlasTexturesEnabled
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_IsMultiAtlasTexturesEnabled);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_IsMultiAtlasTexturesEnabled)) = value;
		}
	}

	public unsafe bool m_GetFontFeatures
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_GetFontFeatures);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_GetFontFeatures)) = value;
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

	public unsafe int m_AtlasWidth
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_AtlasWidth);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_AtlasWidth)) = value;
		}
	}

	public unsafe int m_AtlasHeight
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_AtlasHeight);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_AtlasHeight)) = value;
		}
	}

	public unsafe int m_AtlasPadding
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_AtlasPadding);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_AtlasPadding)) = value;
		}
	}

	public unsafe GlyphRenderMode m_AtlasRenderMode
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_AtlasRenderMode);
			return *(GlyphRenderMode*)num;
		}
		set
		{
			*(GlyphRenderMode*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_AtlasRenderMode)) = value;
		}
	}

	public unsafe List<GlyphRect> m_UsedGlyphRects
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_UsedGlyphRects);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<GlyphRect>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_UsedGlyphRects)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe List<GlyphRect> m_FreeGlyphRects
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_FreeGlyphRects);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<GlyphRect>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_FreeGlyphRects)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe TMP_FontFeatureTable m_FontFeatureTable
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_FontFeatureTable);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<TMP_FontFeatureTable>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_FontFeatureTable)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe bool m_ShouldReimportFontFeatures
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ShouldReimportFontFeatures);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ShouldReimportFontFeatures)) = value;
		}
	}

	public unsafe List<TMP_FontAsset> m_FallbackFontAssetTable
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_FallbackFontAssetTable);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<TMP_FontAsset>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_FallbackFontAssetTable)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe Il2CppReferenceArray<TMP_FontWeightPair> m_FontWeightTable
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_FontWeightTable);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<TMP_FontWeightPair>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_FontWeightTable)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe Il2CppReferenceArray<TMP_FontWeightPair> fontWeights
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fontWeights);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<TMP_FontWeightPair>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fontWeights)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe float normalStyle
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_normalStyle);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_normalStyle)) = value;
		}
	}

	public unsafe float normalSpacingOffset
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_normalSpacingOffset);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_normalSpacingOffset)) = value;
		}
	}

	public unsafe float boldStyle
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_boldStyle);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_boldStyle)) = value;
		}
	}

	public unsafe float boldSpacing
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_boldSpacing);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_boldSpacing)) = value;
		}
	}

	public unsafe byte italicStyle
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_italicStyle);
			return *(byte*)num;
		}
		set
		{
			*(byte*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_italicStyle)) = value;
		}
	}

	public unsafe byte tabSize
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tabSize);
			return *(byte*)num;
		}
		set
		{
			*(byte*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tabSize)) = value;
		}
	}

	public unsafe bool IsFontAssetLookupTablesDirty
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IsFontAssetLookupTablesDirty);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IsFontAssetLookupTablesDirty)) = value;
		}
	}

	public unsafe FaceInfo_Legacy m_fontInfo
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_fontInfo);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<FaceInfo_Legacy>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_fontInfo)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe List<TMP_Glyph> m_glyphInfoList
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_glyphInfoList);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<TMP_Glyph>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_glyphInfoList)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe KerningTable m_KerningTable
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_KerningTable);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<KerningTable>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_KerningTable)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe List<TMP_FontAsset> fallbackFontAssets
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fallbackFontAssets);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<TMP_FontAsset>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fallbackFontAssets)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe Texture2D atlas
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_atlas);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Texture2D>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_atlas)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static List<Il2CppSystem.WeakReference<TMP_FontAsset>> s_CallbackInstances
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_CallbackInstances, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<Il2CppSystem.WeakReference<TMP_FontAsset>>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_CallbackInstances, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static ProfilerMarker k_ReadFontAssetDefinitionMarker
	{
		get
		{
			Unsafe.SkipInit(out ProfilerMarker result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_k_ReadFontAssetDefinitionMarker, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_k_ReadFontAssetDefinitionMarker, (void*)(&value));
		}
	}

	public unsafe static ProfilerMarker k_AddSynthesizedCharactersMarker
	{
		get
		{
			Unsafe.SkipInit(out ProfilerMarker result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_k_AddSynthesizedCharactersMarker, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_k_AddSynthesizedCharactersMarker, (void*)(&value));
		}
	}

	public unsafe static ProfilerMarker k_TryAddGlyphMarker
	{
		get
		{
			Unsafe.SkipInit(out ProfilerMarker result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_k_TryAddGlyphMarker, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_k_TryAddGlyphMarker, (void*)(&value));
		}
	}

	public unsafe static ProfilerMarker k_TryAddCharacterMarker
	{
		get
		{
			Unsafe.SkipInit(out ProfilerMarker result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_k_TryAddCharacterMarker, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_k_TryAddCharacterMarker, (void*)(&value));
		}
	}

	public unsafe static ProfilerMarker k_TryAddCharactersMarker
	{
		get
		{
			Unsafe.SkipInit(out ProfilerMarker result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_k_TryAddCharactersMarker, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_k_TryAddCharactersMarker, (void*)(&value));
		}
	}

	public unsafe static ProfilerMarker k_UpdateLigatureSubstitutionRecordsMarker
	{
		get
		{
			Unsafe.SkipInit(out ProfilerMarker result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_k_UpdateLigatureSubstitutionRecordsMarker, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_k_UpdateLigatureSubstitutionRecordsMarker, (void*)(&value));
		}
	}

	public unsafe static ProfilerMarker k_UpdateGlyphAdjustmentRecordsMarker
	{
		get
		{
			Unsafe.SkipInit(out ProfilerMarker result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_k_UpdateGlyphAdjustmentRecordsMarker, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_k_UpdateGlyphAdjustmentRecordsMarker, (void*)(&value));
		}
	}

	public unsafe static ProfilerMarker k_UpdateDiacriticalMarkAdjustmentRecordsMarker
	{
		get
		{
			Unsafe.SkipInit(out ProfilerMarker result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_k_UpdateDiacriticalMarkAdjustmentRecordsMarker, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_k_UpdateDiacriticalMarkAdjustmentRecordsMarker, (void*)(&value));
		}
	}

	public unsafe static ProfilerMarker k_ClearFontAssetDataMarker
	{
		get
		{
			Unsafe.SkipInit(out ProfilerMarker result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_k_ClearFontAssetDataMarker, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_k_ClearFontAssetDataMarker, (void*)(&value));
		}
	}

	public unsafe static ProfilerMarker k_UpdateFontAssetDataMarker
	{
		get
		{
			Unsafe.SkipInit(out ProfilerMarker result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_k_UpdateFontAssetDataMarker, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_k_UpdateFontAssetDataMarker, (void*)(&value));
		}
	}

	public unsafe static string s_DefaultMaterialSuffix
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_DefaultMaterialSuffix, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_DefaultMaterialSuffix, (void*)IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe static HashSet<int> k_SearchedFontAssetLookup
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_k_SearchedFontAssetLookup, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<HashSet<int>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_k_SearchedFontAssetLookup, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static List<TMP_FontAsset> k_FontAssets_FontFeaturesUpdateQueue
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_k_FontAssets_FontFeaturesUpdateQueue, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<TMP_FontAsset>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_k_FontAssets_FontFeaturesUpdateQueue, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static HashSet<int> k_FontAssets_FontFeaturesUpdateQueueLookup
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_k_FontAssets_FontFeaturesUpdateQueueLookup, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<HashSet<int>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_k_FontAssets_FontFeaturesUpdateQueueLookup, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static List<Texture2D> k_FontAssets_AtlasTexturesUpdateQueue
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_k_FontAssets_AtlasTexturesUpdateQueue, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<Texture2D>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_k_FontAssets_AtlasTexturesUpdateQueue, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static HashSet<int> k_FontAssets_AtlasTexturesUpdateQueueLookup
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_k_FontAssets_AtlasTexturesUpdateQueueLookup, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<HashSet<int>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_k_FontAssets_AtlasTexturesUpdateQueueLookup, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe List<Glyph> m_GlyphsToRender
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_GlyphsToRender);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<Glyph>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_GlyphsToRender)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe List<Glyph> m_GlyphsRendered
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_GlyphsRendered);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<Glyph>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_GlyphsRendered)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe List<uint> m_GlyphIndexList
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_GlyphIndexList);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<uint>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_GlyphIndexList)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe List<uint> m_GlyphIndexListNewlyAdded
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_GlyphIndexListNewlyAdded);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<uint>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_GlyphIndexListNewlyAdded)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe List<uint> m_GlyphsToAdd
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_GlyphsToAdd);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<uint>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_GlyphsToAdd)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe HashSet<uint> m_GlyphsToAddLookup
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_GlyphsToAddLookup);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<HashSet<uint>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_GlyphsToAddLookup)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe List<TMP_Character> m_CharactersToAdd
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_CharactersToAdd);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<TMP_Character>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_CharactersToAdd)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe HashSet<uint> m_CharactersToAddLookup
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_CharactersToAddLookup);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<HashSet<uint>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_CharactersToAddLookup)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe List<uint> s_MissingCharacterList
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_s_MissingCharacterList);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<uint>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_s_MissingCharacterList)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe HashSet<uint> m_MissingUnicodesFromFontFile
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_MissingUnicodesFromFontFile);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<HashSet<uint>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_MissingUnicodesFromFontFile)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Il2CppStructArray<uint> k_GlyphIndexArray
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_k_GlyphIndexArray, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<uint>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_k_GlyphIndexArray, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe FontAssetCreationSettings creationSettings
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_creationSettings_Public_get_FontAssetCreationSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new FontAssetCreationSettings(pointer);
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1121767, XrefRangeEnd = 1121768, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)value));
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_creationSettings_Public_set_Void_FontAssetCreationSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe Font sourceFontFile
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_sourceFontFile_Public_get_Font_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Font>(intPtr2) : null;
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_sourceFontFile_Internal_set_Void_Font_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe AtlasPopulationMode atlasPopulationMode
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_atlasPopulationMode_Public_get_AtlasPopulationMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(AtlasPopulationMode*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_atlasPopulationMode_Public_set_Void_AtlasPopulationMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe int familyNameHashCode
	{
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1121773, RefRangeEnd = 1121777, XrefRangeStart = 1121768, XrefRangeEnd = 1121773, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_familyNameHashCode_Internal_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
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
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_familyNameHashCode_Internal_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe int styleNameHashCode
	{
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1121782, RefRangeEnd = 1121786, XrefRangeStart = 1121777, XrefRangeEnd = 1121782, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_styleNameHashCode_Internal_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
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
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_styleNameHashCode_Internal_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe List<Glyph> glyphTable
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_glyphTable_Public_get_List_1_Glyph_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<Glyph>>(intPtr2) : null;
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_glyphTable_Internal_set_Void_List_1_Glyph_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe Dictionary<uint, Glyph> glyphLookupTable
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1121786, XrefRangeEnd = 1121787, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_glyphLookupTable_Public_get_Dictionary_2_UInt32_Glyph_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<uint, Glyph>>(intPtr2) : null;
		}
	}

	public unsafe List<TMP_Character> characterTable
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_characterTable_Public_get_List_1_TMP_Character_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<TMP_Character>>(intPtr2) : null;
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_characterTable_Internal_set_Void_List_1_TMP_Character_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe Dictionary<uint, TMP_Character> characterLookupTable
	{
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 1121788, RefRangeEnd = 1121802, XrefRangeStart = 1121787, XrefRangeEnd = 1121788, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_characterLookupTable_Public_get_Dictionary_2_UInt32_TMP_Character_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<uint, TMP_Character>>(intPtr2) : null;
		}
	}

	public unsafe Texture2D atlasTexture
	{
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1121807, RefRangeEnd = 1121809, XrefRangeStart = 1121802, XrefRangeEnd = 1121807, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_atlasTexture_Public_get_Texture2D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Texture2D>(intPtr2) : null;
		}
	}

	public unsafe Il2CppReferenceArray<Texture2D> atlasTextures
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 391880, RefRangeEnd = 391881, XrefRangeStart = 391880, XrefRangeEnd = 391881, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_atlasTextures_Public_get_Il2CppReferenceArray_1_Texture2D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Texture2D>>(intPtr2) : null;
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_atlasTextures_Public_set_Void_Il2CppReferenceArray_1_Texture2D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe int atlasTextureCount
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1121809, RefRangeEnd = 1121810, XrefRangeStart = 1121809, XrefRangeEnd = 1121809, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_atlasTextureCount_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe bool isMultiAtlasTexturesEnabled
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_isMultiAtlasTexturesEnabled_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_isMultiAtlasTexturesEnabled_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe bool getFontFeatures
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_getFontFeatures_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_getFontFeatures_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe bool clearDynamicDataOnBuild
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_clearDynamicDataOnBuild_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_clearDynamicDataOnBuild_Internal_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe int atlasWidth
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_atlasWidth_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
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
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_atlasWidth_Internal_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe int atlasHeight
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_atlasHeight_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
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
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_atlasHeight_Internal_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe int atlasPadding
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_atlasPadding_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
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
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_atlasPadding_Internal_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe GlyphRenderMode atlasRenderMode
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_atlasRenderMode_Public_get_GlyphRenderMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(GlyphRenderMode*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_atlasRenderMode_Internal_set_Void_GlyphRenderMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe List<GlyphRect> usedGlyphRects
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_usedGlyphRects_Internal_get_List_1_GlyphRect_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<GlyphRect>>(intPtr2) : null;
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_usedGlyphRects_Internal_set_Void_List_1_GlyphRect_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe List<GlyphRect> freeGlyphRects
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_freeGlyphRects_Internal_get_List_1_GlyphRect_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<GlyphRect>>(intPtr2) : null;
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_freeGlyphRects_Internal_set_Void_List_1_GlyphRect_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe TMP_FontFeatureTable fontFeatureTable
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_fontFeatureTable_Public_get_TMP_FontFeatureTable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<TMP_FontFeatureTable>(intPtr2) : null;
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_fontFeatureTable_Internal_set_Void_TMP_FontFeatureTable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe List<TMP_FontAsset> fallbackFontAssetTable
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_fallbackFontAssetTable_Public_get_List_1_TMP_FontAsset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<TMP_FontAsset>>(intPtr2) : null;
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_fallbackFontAssetTable_Public_set_Void_List_1_TMP_FontAsset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe Il2CppReferenceArray<TMP_FontWeightPair> fontWeightTable
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 392549, RefRangeEnd = 392550, XrefRangeStart = 392549, XrefRangeEnd = 392550, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_fontWeightTable_Public_get_Il2CppReferenceArray_1_TMP_FontWeightPair_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<TMP_FontWeightPair>>(intPtr2) : null;
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_fontWeightTable_Internal_set_Void_Il2CppReferenceArray_1_TMP_FontWeightPair_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe FaceInfo_Legacy fontInfo
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_fontInfo_Public_get_FaceInfo_Legacy_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<FaceInfo_Legacy>(intPtr2) : null;
		}
	}

	static TMP_FontAsset()
	{
		Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.TextMeshPro.dll", "TMPro", "TMP_FontAsset");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr);
		NativeFieldInfoPtr_m_SourceFontFileGUID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, "m_SourceFontFileGUID");
		NativeFieldInfoPtr_m_CreationSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, "m_CreationSettings");
		NativeFieldInfoPtr_m_SourceFontFile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, "m_SourceFontFile");
		NativeFieldInfoPtr_m_SourceFontFilePath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, "m_SourceFontFilePath");
		NativeFieldInfoPtr_m_AtlasPopulationMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, "m_AtlasPopulationMode");
		NativeFieldInfoPtr_InternalDynamicOS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, "InternalDynamicOS");
		NativeFieldInfoPtr_m_FamilyNameHashCode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, "m_FamilyNameHashCode");
		NativeFieldInfoPtr_m_StyleNameHashCode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, "m_StyleNameHashCode");
		NativeFieldInfoPtr_m_GlyphTable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, "m_GlyphTable");
		NativeFieldInfoPtr_m_GlyphLookupDictionary = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, "m_GlyphLookupDictionary");
		NativeFieldInfoPtr_m_CharacterTable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, "m_CharacterTable");
		NativeFieldInfoPtr_m_CharacterLookupDictionary = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, "m_CharacterLookupDictionary");
		NativeFieldInfoPtr_m_AtlasTexture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, "m_AtlasTexture");
		NativeFieldInfoPtr_m_AtlasTextures = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, "m_AtlasTextures");
		NativeFieldInfoPtr_m_AtlasTextureIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, "m_AtlasTextureIndex");
		NativeFieldInfoPtr_m_IsMultiAtlasTexturesEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, "m_IsMultiAtlasTexturesEnabled");
		NativeFieldInfoPtr_m_GetFontFeatures = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, "m_GetFontFeatures");
		NativeFieldInfoPtr_m_ClearDynamicDataOnBuild = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, "m_ClearDynamicDataOnBuild");
		NativeFieldInfoPtr_m_AtlasWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, "m_AtlasWidth");
		NativeFieldInfoPtr_m_AtlasHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, "m_AtlasHeight");
		NativeFieldInfoPtr_m_AtlasPadding = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, "m_AtlasPadding");
		NativeFieldInfoPtr_m_AtlasRenderMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, "m_AtlasRenderMode");
		NativeFieldInfoPtr_m_UsedGlyphRects = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, "m_UsedGlyphRects");
		NativeFieldInfoPtr_m_FreeGlyphRects = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, "m_FreeGlyphRects");
		NativeFieldInfoPtr_m_FontFeatureTable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, "m_FontFeatureTable");
		NativeFieldInfoPtr_m_ShouldReimportFontFeatures = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, "m_ShouldReimportFontFeatures");
		NativeFieldInfoPtr_m_FallbackFontAssetTable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, "m_FallbackFontAssetTable");
		NativeFieldInfoPtr_m_FontWeightTable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, "m_FontWeightTable");
		NativeFieldInfoPtr_fontWeights = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, "fontWeights");
		NativeFieldInfoPtr_normalStyle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, "normalStyle");
		NativeFieldInfoPtr_normalSpacingOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, "normalSpacingOffset");
		NativeFieldInfoPtr_boldStyle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, "boldStyle");
		NativeFieldInfoPtr_boldSpacing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, "boldSpacing");
		NativeFieldInfoPtr_italicStyle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, "italicStyle");
		NativeFieldInfoPtr_tabSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, "tabSize");
		NativeFieldInfoPtr_IsFontAssetLookupTablesDirty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, "IsFontAssetLookupTablesDirty");
		NativeFieldInfoPtr_m_fontInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, "m_fontInfo");
		NativeFieldInfoPtr_m_glyphInfoList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, "m_glyphInfoList");
		NativeFieldInfoPtr_m_KerningTable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, "m_KerningTable");
		NativeFieldInfoPtr_fallbackFontAssets = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, "fallbackFontAssets");
		NativeFieldInfoPtr_atlas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, "atlas");
		NativeFieldInfoPtr_s_CallbackInstances = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, "s_CallbackInstances");
		NativeFieldInfoPtr_k_ReadFontAssetDefinitionMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, "k_ReadFontAssetDefinitionMarker");
		NativeFieldInfoPtr_k_AddSynthesizedCharactersMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, "k_AddSynthesizedCharactersMarker");
		NativeFieldInfoPtr_k_TryAddGlyphMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, "k_TryAddGlyphMarker");
		NativeFieldInfoPtr_k_TryAddCharacterMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, "k_TryAddCharacterMarker");
		NativeFieldInfoPtr_k_TryAddCharactersMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, "k_TryAddCharactersMarker");
		NativeFieldInfoPtr_k_UpdateLigatureSubstitutionRecordsMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, "k_UpdateLigatureSubstitutionRecordsMarker");
		NativeFieldInfoPtr_k_UpdateGlyphAdjustmentRecordsMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, "k_UpdateGlyphAdjustmentRecordsMarker");
		NativeFieldInfoPtr_k_UpdateDiacriticalMarkAdjustmentRecordsMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, "k_UpdateDiacriticalMarkAdjustmentRecordsMarker");
		NativeFieldInfoPtr_k_ClearFontAssetDataMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, "k_ClearFontAssetDataMarker");
		NativeFieldInfoPtr_k_UpdateFontAssetDataMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, "k_UpdateFontAssetDataMarker");
		NativeFieldInfoPtr_s_DefaultMaterialSuffix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, "s_DefaultMaterialSuffix");
		NativeFieldInfoPtr_k_SearchedFontAssetLookup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, "k_SearchedFontAssetLookup");
		NativeFieldInfoPtr_k_FontAssets_FontFeaturesUpdateQueue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, "k_FontAssets_FontFeaturesUpdateQueue");
		NativeFieldInfoPtr_k_FontAssets_FontFeaturesUpdateQueueLookup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, "k_FontAssets_FontFeaturesUpdateQueueLookup");
		NativeFieldInfoPtr_k_FontAssets_AtlasTexturesUpdateQueue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, "k_FontAssets_AtlasTexturesUpdateQueue");
		NativeFieldInfoPtr_k_FontAssets_AtlasTexturesUpdateQueueLookup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, "k_FontAssets_AtlasTexturesUpdateQueueLookup");
		NativeFieldInfoPtr_m_GlyphsToRender = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, "m_GlyphsToRender");
		NativeFieldInfoPtr_m_GlyphsRendered = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, "m_GlyphsRendered");
		NativeFieldInfoPtr_m_GlyphIndexList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, "m_GlyphIndexList");
		NativeFieldInfoPtr_m_GlyphIndexListNewlyAdded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, "m_GlyphIndexListNewlyAdded");
		NativeFieldInfoPtr_m_GlyphsToAdd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, "m_GlyphsToAdd");
		NativeFieldInfoPtr_m_GlyphsToAddLookup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, "m_GlyphsToAddLookup");
		NativeFieldInfoPtr_m_CharactersToAdd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, "m_CharactersToAdd");
		NativeFieldInfoPtr_m_CharactersToAddLookup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, "m_CharactersToAddLookup");
		NativeFieldInfoPtr_s_MissingCharacterList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, "s_MissingCharacterList");
		NativeFieldInfoPtr_m_MissingUnicodesFromFontFile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, "m_MissingUnicodesFromFontFile");
		NativeFieldInfoPtr_k_GlyphIndexArray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, "k_GlyphIndexArray");
		NativeMethodInfoPtr_get_creationSettings_Public_get_FontAssetCreationSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, 100663834);
		NativeMethodInfoPtr_set_creationSettings_Public_set_Void_FontAssetCreationSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, 100663835);
		NativeMethodInfoPtr_get_sourceFontFile_Public_get_Font_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, 100663836);
		NativeMethodInfoPtr_set_sourceFontFile_Internal_set_Void_Font_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, 100663837);
		NativeMethodInfoPtr_get_atlasPopulationMode_Public_get_AtlasPopulationMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, 100663838);
		NativeMethodInfoPtr_set_atlasPopulationMode_Public_set_Void_AtlasPopulationMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, 100663839);
		NativeMethodInfoPtr_get_familyNameHashCode_Internal_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, 100663840);
		NativeMethodInfoPtr_set_familyNameHashCode_Internal_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, 100663841);
		NativeMethodInfoPtr_get_styleNameHashCode_Internal_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, 100663842);
		NativeMethodInfoPtr_set_styleNameHashCode_Internal_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, 100663843);
		NativeMethodInfoPtr_get_glyphTable_Public_get_List_1_Glyph_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, 100663844);
		NativeMethodInfoPtr_set_glyphTable_Internal_set_Void_List_1_Glyph_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, 100663845);
		NativeMethodInfoPtr_get_glyphLookupTable_Public_get_Dictionary_2_UInt32_Glyph_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, 100663846);
		NativeMethodInfoPtr_get_characterTable_Public_get_List_1_TMP_Character_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, 100663847);
		NativeMethodInfoPtr_set_characterTable_Internal_set_Void_List_1_TMP_Character_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, 100663848);
		NativeMethodInfoPtr_get_characterLookupTable_Public_get_Dictionary_2_UInt32_TMP_Character_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, 100663849);
		NativeMethodInfoPtr_get_atlasTexture_Public_get_Texture2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, 100663850);
		NativeMethodInfoPtr_get_atlasTextures_Public_get_Il2CppReferenceArray_1_Texture2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, 100663851);
		NativeMethodInfoPtr_set_atlasTextures_Public_set_Void_Il2CppReferenceArray_1_Texture2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, 100663852);
		NativeMethodInfoPtr_get_atlasTextureCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, 100663853);
		NativeMethodInfoPtr_get_isMultiAtlasTexturesEnabled_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, 100663854);
		NativeMethodInfoPtr_set_isMultiAtlasTexturesEnabled_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, 100663855);
		NativeMethodInfoPtr_get_getFontFeatures_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, 100663856);
		NativeMethodInfoPtr_set_getFontFeatures_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, 100663857);
		NativeMethodInfoPtr_get_clearDynamicDataOnBuild_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, 100663858);
		NativeMethodInfoPtr_set_clearDynamicDataOnBuild_Internal_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, 100663859);
		NativeMethodInfoPtr_get_atlasWidth_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, 100663860);
		NativeMethodInfoPtr_set_atlasWidth_Internal_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, 100663861);
		NativeMethodInfoPtr_get_atlasHeight_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, 100663862);
		NativeMethodInfoPtr_set_atlasHeight_Internal_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, 100663863);
		NativeMethodInfoPtr_get_atlasPadding_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, 100663864);
		NativeMethodInfoPtr_set_atlasPadding_Internal_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, 100663865);
		NativeMethodInfoPtr_get_atlasRenderMode_Public_get_GlyphRenderMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, 100663866);
		NativeMethodInfoPtr_set_atlasRenderMode_Internal_set_Void_GlyphRenderMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, 100663867);
		NativeMethodInfoPtr_get_usedGlyphRects_Internal_get_List_1_GlyphRect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, 100663868);
		NativeMethodInfoPtr_set_usedGlyphRects_Internal_set_Void_List_1_GlyphRect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, 100663869);
		NativeMethodInfoPtr_get_freeGlyphRects_Internal_get_List_1_GlyphRect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, 100663870);
		NativeMethodInfoPtr_set_freeGlyphRects_Internal_set_Void_List_1_GlyphRect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, 100663871);
		NativeMethodInfoPtr_get_fontFeatureTable_Public_get_TMP_FontFeatureTable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, 100663872);
		NativeMethodInfoPtr_set_fontFeatureTable_Internal_set_Void_TMP_FontFeatureTable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, 100663873);
		NativeMethodInfoPtr_get_fallbackFontAssetTable_Public_get_List_1_TMP_FontAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, 100663874);
		NativeMethodInfoPtr_set_fallbackFontAssetTable_Public_set_Void_List_1_TMP_FontAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, 100663875);
		NativeMethodInfoPtr_get_fontWeightTable_Public_get_Il2CppReferenceArray_1_TMP_FontWeightPair_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, 100663876);
		NativeMethodInfoPtr_set_fontWeightTable_Internal_set_Void_Il2CppReferenceArray_1_TMP_FontWeightPair_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, 100663877);
		NativeMethodInfoPtr_get_fontInfo_Public_get_FaceInfo_Legacy_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, 100663878);
		NativeMethodInfoPtr_CreateFontAsset_Public_Static_TMP_FontAsset_String_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, 100663879);
		NativeMethodInfoPtr_CreateFontAsset_Public_Static_TMP_FontAsset_String_Int32_Int32_Int32_GlyphRenderMode_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, 100663880);
		NativeMethodInfoPtr_CreateFontAsset_Private_Static_TMP_FontAsset_String_Int32_Int32_Int32_GlyphRenderMode_Int32_Int32_AtlasPopulationMode_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, 100663881);
		NativeMethodInfoPtr_CreateFontAsset_Public_Static_TMP_FontAsset_Font_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, 100663882);
		NativeMethodInfoPtr_CreateFontAsset_Public_Static_TMP_FontAsset_Font_Int32_Int32_GlyphRenderMode_Int32_Int32_AtlasPopulationMode_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, 100663883);
		NativeMethodInfoPtr_CreateFontAsset_Private_Static_TMP_FontAsset_Font_Int32_Int32_Int32_GlyphRenderMode_Int32_Int32_AtlasPopulationMode_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, 100663884);
		NativeMethodInfoPtr_CreateFontAssetInstance_Private_Static_TMP_FontAsset_Font_Int32_GlyphRenderMode_Int32_Int32_AtlasPopulationMode_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, 100663885);
		NativeMethodInfoPtr_RegisterCallbackInstance_Private_Void_TMP_FontAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, 100663886);
		NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, 100663887);
		NativeMethodInfoPtr_ReadFontAssetDefinition_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, 100663888);
		NativeMethodInfoPtr_InitializeDictionaryLookupTables_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, 100663889);
		NativeMethodInfoPtr_InitializeGlyphLookupDictionary_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, 100663890);
		NativeMethodInfoPtr_InitializeCharacterLookupDictionary_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, 100663891);
		NativeMethodInfoPtr_ClearFallbackCharacterTable_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, 100663892);
		NativeMethodInfoPtr_InitializeLigatureSubstitutionLookupDictionary_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, 100663893);
		NativeMethodInfoPtr_InitializeGlyphPaidAdjustmentRecordsLookupDictionary_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, 100663894);
		NativeMethodInfoPtr_InitializeMarkToBaseAdjustmentRecordsLookupDictionary_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, 100663895);
		NativeMethodInfoPtr_InitializeMarkToMarkAdjustmentRecordsLookupDictionary_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, 100663896);
		NativeMethodInfoPtr_AddSynthesizedCharactersAndFaceMetrics_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, 100663897);
		NativeMethodInfoPtr_AddSynthesizedCharacter_Private_Void_UInt32_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, 100663898);
		NativeMethodInfoPtr_AddCharacterToLookupCache_Internal_Void_UInt32_TMP_Character_FontStyles_FontWeight_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, 100663899);
		NativeMethodInfoPtr_LoadFontFace_Internal_FontEngineError_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, 100663900);
		NativeMethodInfoPtr_SortCharacterTable_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, 100663901);
		NativeMethodInfoPtr_SortGlyphTable_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, 100663902);
		NativeMethodInfoPtr_SortFontFeatureTable_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, 100663903);
		NativeMethodInfoPtr_SortAllTables_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, 100663904);
		NativeMethodInfoPtr_HasCharacter_Public_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, 100663905);
		NativeMethodInfoPtr_HasCharacter_Public_Boolean_Char_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, 100663906);
		NativeMethodInfoPtr_HasCharacter_Internal_Private_Boolean_UInt32_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, 100663907);
		NativeMethodInfoPtr_HasCharacters_Public_Boolean_String_byref_List_1_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, 100663908);
		NativeMethodInfoPtr_HasCharacters_Public_Boolean_String_byref_Il2CppStructArray_1_UInt32_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, 100663909);
		NativeMethodInfoPtr_HasCharacters_Public_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, 100663910);
		NativeMethodInfoPtr_GetCharacters_Public_Static_String_TMP_FontAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, 100663911);
		NativeMethodInfoPtr_GetCharactersArray_Public_Static_Il2CppStructArray_1_Int32_TMP_FontAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, 100663912);
		NativeMethodInfoPtr_GetGlyphIndex_Internal_UInt32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, 100663913);
		NativeMethodInfoPtr_GetGlyphVariantIndex_Internal_UInt32_UInt32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, 100663914);
		NativeMethodInfoPtr_RegisterFontAssetForFontFeatureUpdate_Internal_Static_Void_TMP_FontAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, 100663915);
		NativeMethodInfoPtr_UpdateFontFeaturesForFontAssetsInQueue_Internal_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, 100663916);
		NativeMethodInfoPtr_RegisterAtlasTextureForApply_Internal_Static_Void_Texture2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, 100663917);
		NativeMethodInfoPtr_UpdateAtlasTexturesInQueue_Internal_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, 100663918);
		NativeMethodInfoPtr_UpdateFontAssetsInUpdateQueue_Internal_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, 100663919);
		NativeMethodInfoPtr_TryAddCharacters_Public_Boolean_Il2CppStructArray_1_UInt32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, 100663920);
		NativeMethodInfoPtr_TryAddCharacters_Public_Boolean_Il2CppStructArray_1_UInt32_byref_Il2CppStructArray_1_UInt32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, 100663921);
		NativeMethodInfoPtr_TryAddCharacters_Public_Boolean_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, 100663922);
		NativeMethodInfoPtr_TryAddCharacters_Public_Boolean_String_byref_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, 100663923);
		NativeMethodInfoPtr_AddGlyphInternal_Internal_Boolean_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, 100663924);
		NativeMethodInfoPtr_TryAddGlyphInternal_Internal_Boolean_UInt32_byref_Glyph_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, 100663925);
		NativeMethodInfoPtr_TryAddCharacterInternal_Internal_Boolean_UInt32_byref_TMP_Character_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, 100663926);
		NativeMethodInfoPtr_TryGetCharacter_and_QueueRenderToTexture_Internal_Boolean_UInt32_byref_TMP_Character_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, 100663927);
		NativeMethodInfoPtr_TryAddGlyphsToAtlasTextures_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, 100663928);
		NativeMethodInfoPtr_TryAddGlyphsToNewAtlasTexture_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, 100663929);
		NativeMethodInfoPtr_SetupNewAtlasTexture_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, 100663930);
		NativeMethodInfoPtr_UpdateAtlasTexture_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, 100663931);
		NativeMethodInfoPtr_UpdateFontFeaturesForNewlyAddedGlyphs_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, 100663932);
		NativeMethodInfoPtr_UpdateGPOSFontFeaturesForNewlyAddedGlyphs_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, 100663933);
		NativeMethodInfoPtr_ImportFontFeatures_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, 100663934);
		NativeMethodInfoPtr_UpdateGSUBFontFeaturesForNewGlyphIndex_Private_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, 100663935);
		NativeMethodInfoPtr_UpdateLigatureSubstitutionRecords_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, 100663936);
		NativeMethodInfoPtr_AddLigatureSubstitutionRecords_Private_Void_Il2CppReferenceArray_1_LigatureSubstitutionRecord_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, 100663937);
		NativeMethodInfoPtr_UpdateGlyphAdjustmentRecords_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, 100663938);
		NativeMethodInfoPtr_AddPairAdjustmentRecords_Private_Void_Il2CppStructArray_1_GlyphPairAdjustmentRecord_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, 100663939);
		NativeMethodInfoPtr_UpdateGlyphAdjustmentRecords_Internal_Void_Il2CppStructArray_1_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, 100663940);
		NativeMethodInfoPtr_UpdateDiacriticalMarkAdjustmentRecords_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, 100663941);
		NativeMethodInfoPtr_AddMarkToBaseAdjustmentRecords_Private_Void_Il2CppStructArray_1_MarkToBaseAdjustmentRecord_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, 100663942);
		NativeMethodInfoPtr_AddMarkToMarkAdjustmentRecords_Private_Void_Il2CppStructArray_1_MarkToMarkAdjustmentRecord_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, 100663943);
		NativeMethodInfoPtr_CopyListDataToArray_Private_Void_List_1_T_byref_Il2CppArrayBase_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, 100663944);
		NativeMethodInfoPtr_UpdateFontAssetData_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, 100663945);
		NativeMethodInfoPtr_ClearFontAssetData_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, 100663946);
		NativeMethodInfoPtr_ClearCharacterAndGlyphTablesInternal_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, 100663947);
		NativeMethodInfoPtr_ClearFontFeaturesInternal_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, 100663948);
		NativeMethodInfoPtr_ClearCharacterAndGlyphTables_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, 100663949);
		NativeMethodInfoPtr_ClearFontFeaturesTables_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, 100663950);
		NativeMethodInfoPtr_ClearAtlasTextures_Internal_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, 100663951);
		NativeMethodInfoPtr_DestroyAtlasTextures_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, 100663952);
		NativeMethodInfoPtr_UpgradeGlyphAdjustmentTableToFontFeatureTable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, 100663953);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr, 100663954);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1121810, XrefRangeEnd = 1121838, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static TMP_FontAsset CreateFontAsset(string familyName, string styleName, int pointSize = 90)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(familyName);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(styleName);
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &pointSize;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateFontAsset_Public_Static_TMP_FontAsset_String_String_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<TMP_FontAsset>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1121838, XrefRangeEnd = 1121842, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static TMP_FontAsset CreateFontAsset(string fontFilePath, int faceIndex, int samplingPointSize, int atlasPadding, GlyphRenderMode renderMode, int atlasWidth, int atlasHeight)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[7];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(fontFilePath);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &faceIndex;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &samplingPointSize;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &atlasPadding;
		*(GlyphRenderMode**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &renderMode;
		*(int**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &atlasWidth;
		*(int**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = &atlasHeight;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateFontAsset_Public_Static_TMP_FontAsset_String_Int32_Int32_Int32_GlyphRenderMode_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<TMP_FontAsset>(intPtr2) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1121861, RefRangeEnd = 1121863, XrefRangeStart = 1121842, XrefRangeEnd = 1121861, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static TMP_FontAsset CreateFontAsset(string fontFilePath, int faceIndex, int samplingPointSize, int atlasPadding, GlyphRenderMode renderMode, int atlasWidth, int atlasHeight, AtlasPopulationMode atlasPopulationMode, bool enableMultiAtlasSupport = true)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[9];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(fontFilePath);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &faceIndex;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &samplingPointSize;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &atlasPadding;
		*(GlyphRenderMode**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &renderMode;
		*(int**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &atlasWidth;
		*(int**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = &atlasHeight;
		*(AtlasPopulationMode**)((byte*)ptr + checked((nuint)7u * unchecked((nuint)sizeof(System.IntPtr)))) = &atlasPopulationMode;
		*(bool**)((byte*)ptr + checked((nuint)8u * unchecked((nuint)sizeof(System.IntPtr)))) = &enableMultiAtlasSupport;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateFontAsset_Private_Static_TMP_FontAsset_String_Int32_Int32_Int32_GlyphRenderMode_Int32_Int32_AtlasPopulationMode_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<TMP_FontAsset>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1121863, XrefRangeEnd = 1121880, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static TMP_FontAsset CreateFontAsset(Font font)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)font);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateFontAsset_Public_Static_TMP_FontAsset_Font_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<TMP_FontAsset>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1121880, XrefRangeEnd = 1121894, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static TMP_FontAsset CreateFontAsset(Font font, int samplingPointSize, int atlasPadding, GlyphRenderMode renderMode, int atlasWidth, int atlasHeight, AtlasPopulationMode atlasPopulationMode = AtlasPopulationMode.Dynamic, bool enableMultiAtlasSupport = true)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[8];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)font);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &samplingPointSize;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &atlasPadding;
		*(GlyphRenderMode**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &renderMode;
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &atlasWidth;
		*(int**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &atlasHeight;
		*(AtlasPopulationMode**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = &atlasPopulationMode;
		*(bool**)((byte*)ptr + checked((nuint)7u * unchecked((nuint)sizeof(System.IntPtr)))) = &enableMultiAtlasSupport;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateFontAsset_Public_Static_TMP_FontAsset_Font_Int32_Int32_GlyphRenderMode_Int32_Int32_AtlasPopulationMode_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<TMP_FontAsset>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1121894, XrefRangeEnd = 1121905, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static TMP_FontAsset CreateFontAsset(Font font, int faceIndex, int samplingPointSize, int atlasPadding, GlyphRenderMode renderMode, int atlasWidth, int atlasHeight, AtlasPopulationMode atlasPopulationMode = AtlasPopulationMode.Dynamic, bool enableMultiAtlasSupport = true)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[9];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)font);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &faceIndex;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &samplingPointSize;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &atlasPadding;
		*(GlyphRenderMode**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &renderMode;
		*(int**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &atlasWidth;
		*(int**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = &atlasHeight;
		*(AtlasPopulationMode**)((byte*)ptr + checked((nuint)7u * unchecked((nuint)sizeof(System.IntPtr)))) = &atlasPopulationMode;
		*(bool**)((byte*)ptr + checked((nuint)8u * unchecked((nuint)sizeof(System.IntPtr)))) = &enableMultiAtlasSupport;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateFontAsset_Private_Static_TMP_FontAsset_Font_Int32_Int32_Int32_GlyphRenderMode_Int32_Int32_AtlasPopulationMode_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<TMP_FontAsset>(intPtr2) : null;
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 1121992, RefRangeEnd = 1121996, XrefRangeStart = 1121905, XrefRangeEnd = 1121992, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static TMP_FontAsset CreateFontAssetInstance(Font font, int atlasPadding, GlyphRenderMode renderMode, int atlasWidth, int atlasHeight, AtlasPopulationMode atlasPopulationMode, bool enableMultiAtlasSupport)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[7];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)font);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &atlasPadding;
		*(GlyphRenderMode**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &renderMode;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &atlasWidth;
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &atlasHeight;
		*(AtlasPopulationMode**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &atlasPopulationMode;
		*(bool**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = &enableMultiAtlasSupport;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateFontAssetInstance_Private_Static_TMP_FontAsset_Font_Int32_GlyphRenderMode_Int32_Int32_AtlasPopulationMode_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<TMP_FontAsset>(intPtr2) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1122036, RefRangeEnd = 1122037, XrefRangeStart = 1121996, XrefRangeEnd = 1122036, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RegisterCallbackInstance(TMP_FontAsset instance)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)instance);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RegisterCallbackInstance_Private_Void_TMP_FontAsset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1122037, XrefRangeEnd = 1122051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnDestroy()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(17)]
	[CachedScanResults(RefRangeStart = 1122137, RefRangeEnd = 1122154, XrefRangeStart = 1122051, XrefRangeEnd = 1122137, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ReadFontAssetDefinition()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ReadFontAssetDefinition_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1122220, RefRangeEnd = 1122221, XrefRangeStart = 1122154, XrefRangeEnd = 1122220, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void InitializeDictionaryLookupTables()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InitializeDictionaryLookupTables_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1122261, RefRangeEnd = 1122262, XrefRangeStart = 1122221, XrefRangeEnd = 1122261, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void InitializeGlyphLookupDictionary()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InitializeGlyphLookupDictionary_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1122292, RefRangeEnd = 1122294, XrefRangeStart = 1122262, XrefRangeEnd = 1122292, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void InitializeCharacterLookupDictionary()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InitializeCharacterLookupDictionary_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1122340, RefRangeEnd = 1122341, XrefRangeStart = 1122294, XrefRangeEnd = 1122340, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ClearFallbackCharacterTable()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ClearFallbackCharacterTable_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1122378, RefRangeEnd = 1122379, XrefRangeStart = 1122341, XrefRangeEnd = 1122378, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void InitializeLigatureSubstitutionLookupDictionary()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InitializeLigatureSubstitutionLookupDictionary_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1122407, RefRangeEnd = 1122408, XrefRangeStart = 1122379, XrefRangeEnd = 1122407, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void InitializeGlyphPaidAdjustmentRecordsLookupDictionary()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InitializeGlyphPaidAdjustmentRecordsLookupDictionary_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1122408, XrefRangeEnd = 1122430, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void InitializeMarkToBaseAdjustmentRecordsLookupDictionary()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InitializeMarkToBaseAdjustmentRecordsLookupDictionary_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1122430, XrefRangeEnd = 1122452, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void InitializeMarkToMarkAdjustmentRecordsLookupDictionary()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InitializeMarkToMarkAdjustmentRecordsLookupDictionary_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1122479, RefRangeEnd = 1122481, XrefRangeStart = 1122452, XrefRangeEnd = 1122479, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddSynthesizedCharactersAndFaceMetrics()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddSynthesizedCharactersAndFaceMetrics_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(12)]
	[CachedScanResults(RefRangeStart = 1122503, RefRangeEnd = 1122515, XrefRangeStart = 1122481, XrefRangeEnd = 1122503, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddSynthesizedCharacter(uint unicode, bool isFontFaceLoaded, bool addImmediately = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&unicode);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &isFontFaceLoaded;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &addImmediately;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddSynthesizedCharacter_Private_Void_UInt32_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1122519, RefRangeEnd = 1122520, XrefRangeStart = 1122515, XrefRangeEnd = 1122519, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddCharacterToLookupCache(uint unicode, TMP_Character character, FontStyles fontStyle = FontStyles.Normal, FontWeight fontWeight = FontWeight.Regular, bool isAlternativeTypeface = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = (nint)(&unicode);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)character);
		*(FontStyles**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &fontStyle;
		*(FontWeight**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &fontWeight;
		*(bool**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &isAlternativeTypeface;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddCharacterToLookupCache_Internal_Void_UInt32_TMP_Character_FontStyles_FontWeight_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(10)]
	[CachedScanResults(RefRangeStart = 1122541, RefRangeEnd = 1122551, XrefRangeStart = 1122520, XrefRangeEnd = 1122541, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe FontEngineError LoadFontFace()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LoadFontFace_Internal_FontEngineError_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(FontEngineError*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1122551, XrefRangeEnd = 1122574, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SortCharacterTable()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SortCharacterTable_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1122574, XrefRangeEnd = 1122597, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SortGlyphTable()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SortGlyphTable_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1122597, XrefRangeEnd = 1122601, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SortFontFeatureTable()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SortFontFeatureTable_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1122601, XrefRangeEnd = 1122651, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SortAllTables()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SortAllTables_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1122651, XrefRangeEnd = 1122655, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool HasCharacter(int character)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&character);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_HasCharacter_Public_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1122655, XrefRangeEnd = 1122753, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool HasCharacter(char character, bool searchFallbacks = false, bool tryAddCharacter = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&character);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &searchFallbacks;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &tryAddCharacter;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_HasCharacter_Public_Boolean_Char_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 1122779, RefRangeEnd = 1122786, XrefRangeStart = 1122753, XrefRangeEnd = 1122779, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool HasCharacter_Internal(uint character, bool searchFallbacks = false, bool tryAddCharacter = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&character);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &searchFallbacks;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &tryAddCharacter;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_HasCharacter_Internal_Private_Boolean_UInt32_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1122786, XrefRangeEnd = 1122806, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool HasCharacters(string text, out List<char> missingCharacters)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
		byte* num = (byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)));
		nint num2 = 0;
		*(nint**)num = &num2;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_HasCharacters_Public_Boolean_String_byref_List_1_Char_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		nint num3 = num2;
		missingCharacters = ((num3 == 0) ? null : new List<char>(num3));
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1122916, RefRangeEnd = 1122918, XrefRangeStart = 1122806, XrefRangeEnd = 1122916, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool HasCharacters(string text, out Il2CppStructArray<uint> missingCharacters, bool searchFallbacks = false, bool tryAddCharacter = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
		byte* num = (byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)));
		nint num2 = 0;
		*(nint**)num = &num2;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &searchFallbacks;
		*(bool**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &tryAddCharacter;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_HasCharacters_Public_Boolean_String_byref_Il2CppStructArray_1_UInt32_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		nint num3 = num2;
		missingCharacters = ((num3 == 0) ? null : new Il2CppStructArray<uint>((System.IntPtr)num3));
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1122927, RefRangeEnd = 1122929, XrefRangeStart = 1122918, XrefRangeEnd = 1122927, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool HasCharacters(string text)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_HasCharacters_Public_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1122929, XrefRangeEnd = 1122939, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string GetCharacters(TMP_FontAsset fontAsset)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)fontAsset);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetCharacters_Public_Static_String_TMP_FontAsset_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1122939, XrefRangeEnd = 1122947, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppStructArray<int> GetCharactersArray(TMP_FontAsset fontAsset)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)fontAsset);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetCharactersArray_Public_Static_Il2CppStructArray_1_Int32_TMP_FontAsset_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1122956, RefRangeEnd = 1122958, XrefRangeStart = 1122947, XrefRangeEnd = 1122956, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe uint GetGlyphIndex(uint unicode)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&unicode);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetGlyphIndex_Internal_UInt32_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(uint*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1122963, RefRangeEnd = 1122965, XrefRangeStart = 1122958, XrefRangeEnd = 1122963, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe uint GetGlyphVariantIndex(uint unicode, uint variantSelectorUnicode)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&unicode);
		*(uint**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &variantSelectorUnicode;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetGlyphVariantIndex_Internal_UInt32_UInt32_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(uint*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1122979, RefRangeEnd = 1122981, XrefRangeStart = 1122965, XrefRangeEnd = 1122979, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void RegisterFontAssetForFontFeatureUpdate(TMP_FontAsset fontAsset)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)fontAsset);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RegisterFontAssetForFontFeatureUpdate_Internal_Static_Void_TMP_FontAsset_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1123009, RefRangeEnd = 1123010, XrefRangeStart = 1122981, XrefRangeEnd = 1123009, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void UpdateFontFeaturesForFontAssetsInQueue()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdateFontFeaturesForFontAssetsInQueue_Internal_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1123010, XrefRangeEnd = 1123024, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void RegisterAtlasTextureForApply(Texture2D texture)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)texture);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RegisterAtlasTextureForApply_Internal_Static_Void_Texture2D_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1123024, XrefRangeEnd = 1123046, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void UpdateAtlasTexturesInQueue()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdateAtlasTexturesInQueue_Internal_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1123072, RefRangeEnd = 1123074, XrefRangeStart = 1123046, XrefRangeEnd = 1123072, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void UpdateFontAssetsInUpdateQueue()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdateFontAssetsInUpdateQueue_Internal_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1123074, XrefRangeEnd = 1123075, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool TryAddCharacters(Il2CppStructArray<uint> unicodes, bool includeFontFeatures = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)unicodes);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &includeFontFeatures;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TryAddCharacters_Public_Boolean_Il2CppStructArray_1_UInt32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1123197, RefRangeEnd = 1123199, XrefRangeStart = 1123075, XrefRangeEnd = 1123197, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool TryAddCharacters(Il2CppStructArray<uint> unicodes, out Il2CppStructArray<uint> missingUnicodes, bool includeFontFeatures = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)unicodes);
		byte* num = (byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)));
		nint num2 = 0;
		*(nint**)num = &num2;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &includeFontFeatures;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TryAddCharacters_Public_Boolean_Il2CppStructArray_1_UInt32_byref_Il2CppStructArray_1_UInt32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		nint num3 = num2;
		missingUnicodes = ((num3 == 0) ? null : new Il2CppStructArray<uint>((System.IntPtr)num3));
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1123200, RefRangeEnd = 1123201, XrefRangeStart = 1123199, XrefRangeEnd = 1123200, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool TryAddCharacters(string characters, bool includeFontFeatures = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(characters);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &includeFontFeatures;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TryAddCharacters_Public_Boolean_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1123327, RefRangeEnd = 1123328, XrefRangeStart = 1123201, XrefRangeEnd = 1123327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool TryAddCharacters(string characters, out string missingCharacters, bool includeFontFeatures = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(characters);
		byte* num = (byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)));
		nint num2 = 0;
		*(nint**)num = &num2;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &includeFontFeatures;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TryAddCharacters_Public_Boolean_String_byref_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		missingCharacters = IL2CPP.Il2CppStringToManaged((System.IntPtr)num2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1123328, XrefRangeEnd = 1123329, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool AddGlyphInternal(uint glyphIndex)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&glyphIndex);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddGlyphInternal_Internal_Boolean_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 1123374, RefRangeEnd = 1123379, XrefRangeStart = 1123329, XrefRangeEnd = 1123374, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool TryAddGlyphInternal(uint glyphIndex, out Glyph glyph)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&glyphIndex);
		byte* num = (byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)));
		nint num2 = 0;
		*(nint**)num = &num2;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TryAddGlyphInternal_Internal_Boolean_UInt32_byref_Glyph_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		nint num3 = num2;
		glyph = ((num3 == 0) ? null : new Glyph(num3));
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 1123413, RefRangeEnd = 1123417, XrefRangeStart = 1123379, XrefRangeEnd = 1123413, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool TryAddCharacterInternal(uint unicode, out TMP_Character character)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&unicode);
		byte* num = (byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)));
		nint num2 = 0;
		*(nint**)num = &num2;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TryAddCharacterInternal_Internal_Boolean_UInt32_byref_TMP_Character_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		nint num3 = num2;
		character = ((num3 == 0) ? null : new TMP_Character(num3));
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1123417, XrefRangeEnd = 1123479, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool TryGetCharacter_and_QueueRenderToTexture(uint unicode, out TMP_Character character)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&unicode);
		byte* num = (byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)));
		nint num2 = 0;
		*(nint**)num = &num2;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TryGetCharacter_and_QueueRenderToTexture_Internal_Boolean_UInt32_byref_TMP_Character_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		nint num3 = num2;
		character = ((num3 == 0) ? null : new TMP_Character(num3));
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(19883)]
	[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 20035, XrefRangeStart = 152, XrefRangeEnd = 20035, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void TryAddGlyphsToAtlasTextures()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TryAddGlyphsToAtlasTextures_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1123525, RefRangeEnd = 1123527, XrefRangeStart = 1123479, XrefRangeEnd = 1123525, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool TryAddGlyphsToNewAtlasTexture()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TryAddGlyphsToNewAtlasTexture_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1123545, RefRangeEnd = 1123547, XrefRangeStart = 1123527, XrefRangeEnd = 1123545, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetupNewAtlasTexture()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetupNewAtlasTexture_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1123547, XrefRangeEnd = 1123554, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdateAtlasTexture()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdateAtlasTexture_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1123566, RefRangeEnd = 1123568, XrefRangeStart = 1123554, XrefRangeEnd = 1123566, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdateFontFeaturesForNewlyAddedGlyphs()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdateFontFeaturesForNewlyAddedGlyphs_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1123568, XrefRangeEnd = 1123575, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdateGPOSFontFeaturesForNewlyAddedGlyphs()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdateGPOSFontFeaturesForNewlyAddedGlyphs_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1123575, XrefRangeEnd = 1123593, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ImportFontFeatures()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ImportFontFeatures_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1123598, RefRangeEnd = 1123600, XrefRangeStart = 1123593, XrefRangeEnd = 1123598, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdateGSUBFontFeaturesForNewGlyphIndex(uint glyphIndex)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&glyphIndex);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdateGSUBFontFeaturesForNewGlyphIndex_Private_Void_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1123600, XrefRangeEnd = 1123605, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdateLigatureSubstitutionRecords()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdateLigatureSubstitutionRecords_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 1123652, RefRangeEnd = 1123657, XrefRangeStart = 1123605, XrefRangeEnd = 1123652, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddLigatureSubstitutionRecords(Il2CppReferenceArray<UnityEngine.TextCore.LowLevel.LigatureSubstitutionRecord> records)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)records);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddLigatureSubstitutionRecords_Private_Void_Il2CppReferenceArray_1_LigatureSubstitutionRecord_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1123657, XrefRangeEnd = 1123662, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdateGlyphAdjustmentRecords()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdateGlyphAdjustmentRecords_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 1123683, RefRangeEnd = 1123689, XrefRangeStart = 1123662, XrefRangeEnd = 1123683, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddPairAdjustmentRecords(Il2CppStructArray<GlyphPairAdjustmentRecord> records)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)records);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddPairAdjustmentRecords_Private_Void_Il2CppStructArray_1_GlyphPairAdjustmentRecord_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1123689, XrefRangeEnd = 1123714, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdateGlyphAdjustmentRecords(Il2CppStructArray<uint> glyphIndexes)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)glyphIndexes);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdateGlyphAdjustmentRecords_Internal_Void_Il2CppStructArray_1_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1123723, RefRangeEnd = 1123726, XrefRangeStart = 1123714, XrefRangeEnd = 1123723, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdateDiacriticalMarkAdjustmentRecords()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdateDiacriticalMarkAdjustmentRecords_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1123752, RefRangeEnd = 1123755, XrefRangeStart = 1123726, XrefRangeEnd = 1123752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddMarkToBaseAdjustmentRecords(Il2CppStructArray<UnityEngine.TextCore.LowLevel.MarkToBaseAdjustmentRecord> records)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)records);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddMarkToBaseAdjustmentRecords_Private_Void_Il2CppStructArray_1_MarkToBaseAdjustmentRecord_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1123781, RefRangeEnd = 1123784, XrefRangeStart = 1123755, XrefRangeEnd = 1123781, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddMarkToMarkAdjustmentRecords(Il2CppStructArray<UnityEngine.TextCore.LowLevel.MarkToMarkAdjustmentRecord> records)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)records);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddMarkToMarkAdjustmentRecords_Private_Void_Il2CppStructArray_1_MarkToMarkAdjustmentRecord_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1123784, XrefRangeEnd = 1123793, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CopyListDataToArray<T>(List<T> srcList, ref Il2CppArrayBase<T> dstArray)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)srcList);
		byte* num = (byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)));
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dstArray);
		*(System.IntPtr**)num = &intPtr;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_CopyListDataToArray_Private_Void_List_1_T_byref_Il2CppArrayBase_1_T_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		System.IntPtr intPtr4 = intPtr;
		dstArray = ((intPtr4 == (System.IntPtr)0) ? null : new Il2CppArrayBase<T>(intPtr4));
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1123793, XrefRangeEnd = 1123811, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdateFontAssetData()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdateFontAssetData_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1123844, RefRangeEnd = 1123845, XrefRangeStart = 1123811, XrefRangeEnd = 1123844, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ClearFontAssetData(bool setAtlasSizeToZero = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&setAtlasSizeToZero);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ClearFontAssetData_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1123845, XrefRangeEnd = 1123848, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ClearCharacterAndGlyphTablesInternal()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ClearCharacterAndGlyphTablesInternal_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1123848, XrefRangeEnd = 1123850, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ClearFontFeaturesInternal()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ClearFontFeaturesInternal_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1123861, RefRangeEnd = 1123864, XrefRangeStart = 1123850, XrefRangeEnd = 1123861, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ClearCharacterAndGlyphTables()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ClearCharacterAndGlyphTables_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1123869, RefRangeEnd = 1123872, XrefRangeStart = 1123864, XrefRangeEnd = 1123869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ClearFontFeaturesTables()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ClearFontFeaturesTables_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1123891, RefRangeEnd = 1123894, XrefRangeStart = 1123872, XrefRangeEnd = 1123891, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ClearAtlasTextures(bool setAtlasSizeToZero = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&setAtlasSizeToZero);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ClearAtlasTextures_Internal_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1123894, XrefRangeEnd = 1123902, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void DestroyAtlasTextures()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DestroyAtlasTextures_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1123943, RefRangeEnd = 1123944, XrefRangeStart = 1123902, XrefRangeEnd = 1123943, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpgradeGlyphAdjustmentTableToFontFeatureTable()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpgradeGlyphAdjustmentTableToFontFeatureTable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1123944, XrefRangeEnd = 1124027, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe TMP_FontAsset()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TMP_FontAsset>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public TMP_FontAsset(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
