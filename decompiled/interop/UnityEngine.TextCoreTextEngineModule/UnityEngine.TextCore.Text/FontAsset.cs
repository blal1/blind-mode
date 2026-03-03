using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;
using Unity.Profiling;
using UnityEngine.Bindings;
using UnityEngine.TextCore.LowLevel;

namespace UnityEngine.TextCore.Text;

[System.Serializable]
public class FontAsset : TextAsset
{
	[System.Serializable]
	[ObfuscatedName("UnityEngine.TextCore.Text.FontAsset+<>c")]
	public sealed class __c : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr___9;

		private static readonly System.IntPtr NativeFieldInfoPtr___9__189_0;

		private static readonly System.IntPtr NativeFieldInfoPtr___9__190_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__SortCharacterTable_b__189_0_Internal_UInt32_Character_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__SortGlyphTable_b__190_0_Internal_UInt32_Glyph_0;

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

		public unsafe static Il2CppSystem.Func<Character, uint> __9__189_0
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__189_0, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Func<Character, uint>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__189_0, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe static Il2CppSystem.Func<Glyph, uint> __9__190_0
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__190_0, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Func<Glyph, uint>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__190_0, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		static __c()
		{
			Il2CppClassPointerStore<__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, "<>c");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c>.NativeClassPtr);
			NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9");
			NativeFieldInfoPtr___9__189_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__189_0");
			NativeFieldInfoPtr___9__190_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__190_0");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100663574);
			NativeMethodInfoPtr__SortCharacterTable_b__189_0_Internal_UInt32_Character_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100663575);
			NativeMethodInfoPtr__SortGlyphTable_b__190_0_Internal_UInt32_Glyph_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100663576);
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
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1275302, XrefRangeEnd = 1275304, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe uint _SortCharacterTable_b__189_0(Character c)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)c);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__SortCharacterTable_b__189_0_Internal_UInt32_Character_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(uint*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe uint _SortGlyphTable_b__190_0(Glyph c)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)c);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__SortGlyphTable_b__190_0_Internal_UInt32_Glyph_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(uint*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		public __c(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	private sealed class MethodInfoStoreGeneric_EnsureAdditionalCapacity_Private_Static_Void_List_1_T_Int32_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_EnsureAdditionalCapacity_Private_Static_Void_List_1_T_Int32_0, Il2CppClassPointerStore<FontAsset>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private sealed class MethodInfoStoreGeneric_EnsureAdditionalCapacity_Private_Static_Void_Dictionary_2_TKey_TValue_Int32_0<TKey, TValue>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_EnsureAdditionalCapacity_Private_Static_Void_Dictionary_2_TKey_TValue_Int32_0, Il2CppClassPointerStore<FontAsset>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[2]
		{
			Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TKey>.NativeClassPtr)),
			Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TValue>.NativeClassPtr))
		}))));
	}

	private sealed class MethodInfoStoreGeneric_InitializeLookup_Private_Static_Void_ICollection_byref_Dictionary_2_UInt32_T_Int32_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_InitializeLookup_Private_Static_Void_ICollection_byref_Dictionary_2_UInt32_T_Int32_0, Il2CppClassPointerStore<FontAsset>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private sealed class MethodInfoStoreGeneric_InitializeList_Private_Static_Void_ICollection_byref_List_1_T_Int32_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_InitializeList_Private_Static_Void_ICollection_byref_List_1_T_Int32_0, Il2CppClassPointerStore<FontAsset>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	public static class BindingsMarshaller
	{
	}

	[System.Serializable]
	public sealed class _003C_003Ec
	{
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_kFontAssetByInstanceId;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_SourceFontFileGUID;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_fontAssetCreationEditorSettings;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_SourceFontFile;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_SourceFontFilePath;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_AtlasPopulationMode;

	private static readonly System.IntPtr NativeFieldInfoPtr_InternalDynamicOS;

	private static readonly System.IntPtr NativeFieldInfoPtr_IsEditorFont;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_FaceInfo;

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

	private static readonly System.IntPtr NativeFieldInfoPtr_m_RegularStyleWeight;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_RegularStyleSpacing;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_BoldStyleWeight;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_BoldStyleSpacing;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_ItalicStyleSlant;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_TabMultiple;

	private static readonly System.IntPtr NativeFieldInfoPtr_IsFontAssetLookupTablesDirty;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_NativeFontAsset;

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

	private static readonly System.IntPtr NativeFieldInfoPtr_m_VariantGlyphIndexes;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_IsClone;

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

	private static readonly System.IntPtr NativeFieldInfoPtr_k_FontAssets_KerningUpdateQueue;

	private static readonly System.IntPtr NativeFieldInfoPtr_k_FontAssets_KerningUpdateQueueLookup;

	private static readonly System.IntPtr NativeFieldInfoPtr_k_FontAssets_AtlasTexturesUpdateQueue;

	private static readonly System.IntPtr NativeFieldInfoPtr_k_FontAssets_AtlasTexturesUpdateQueueLookup;

	private static readonly System.IntPtr NativeFieldInfoPtr_k_GlyphIndexArray;

	private static readonly System.IntPtr NativeFieldInfoPtr_visitedFontAssets;

	private static readonly System.IntPtr NativeMethodInfoPtr_EnsureAdditionalCapacity_Private_Static_Void_List_1_T_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_EnsureAdditionalCapacity_Private_Static_Void_Dictionary_2_TKey_TValue_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_fontAssetCreationEditorSettings_Public_get_FontAssetCreationEditorSettings_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_fontAssetCreationEditorSettings_Public_set_Void_FontAssetCreationEditorSettings_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_sourceFontFile_Public_get_Font_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_sourceFontFile_Internal_set_Void_Font_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_atlasPopulationMode_Public_get_AtlasPopulationMode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_atlasPopulationMode_Public_set_Void_AtlasPopulationMode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_faceInfo_Public_get_FaceInfo_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_faceInfo_Public_set_Void_FaceInfo_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_familyNameHashCode_Internal_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_familyNameHashCode_Internal_set_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_styleNameHashCode_Internal_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_styleNameHashCode_Internal_set_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_glyphTable_Public_get_List_1_Glyph_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_glyphTable_Internal_set_Void_List_1_Glyph_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_glyphLookupTable_Public_get_Dictionary_2_UInt32_Glyph_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_characterTable_Public_get_List_1_Character_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_characterTable_Internal_set_Void_List_1_Character_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_characterLookupTable_Public_get_Dictionary_2_UInt32_Character_0;

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

	private static readonly System.IntPtr NativeMethodInfoPtr_get_fontFeatureTable_Public_get_FontFeatureTable_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_fontFeatureTable_Internal_set_Void_FontFeatureTable_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_fallbackFontAssetTable_Public_get_List_1_FontAsset_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_fallbackFontAssetTable_Public_set_Void_List_1_FontAsset_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_fontWeightTable_Public_get_Il2CppReferenceArray_1_FontWeightPair_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_fontWeightTable_Internal_set_Void_Il2CppReferenceArray_1_FontWeightPair_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_regularStyleWeight_Public_get_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_regularStyleWeight_Public_set_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_regularStyleSpacing_Public_get_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_regularStyleSpacing_Public_set_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_boldStyleWeight_Public_get_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_boldStyleWeight_Public_set_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_boldStyleSpacing_Public_get_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_boldStyleSpacing_Public_set_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_italicStyleSlant_Public_get_Byte_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_italicStyleSlant_Public_set_Void_Byte_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_tabMultiple_Public_get_Byte_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_tabMultiple_Public_set_Void_Byte_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateFontAsset_Public_Static_FontAsset_String_String_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateFontAssetInternal_Internal_Static_FontAsset_String_String_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateFontAsset_Internal_Static_FontAsset_String_String_Int32_Int32_GlyphRenderMode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateFontAssetOSFallbackList_Internal_Static_List_1_FontAsset_Il2CppStringArray_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateFontAssetWithOSFallbackList_Internal_Static_FontAsset_Il2CppStringArray_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateFontAssetFromFamilyName_Private_Static_FontAsset_String_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateFontAsset_Public_Static_FontAsset_String_Int32_Int32_Int32_GlyphRenderMode_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateFontAsset_Private_Static_FontAsset_String_Int32_Int32_Int32_GlyphRenderMode_Int32_Int32_AtlasPopulationMode_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateFontAsset_Public_Static_FontAsset_Font_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateFontAsset_Public_Static_FontAsset_Font_Int32_Int32_GlyphRenderMode_Int32_Int32_AtlasPopulationMode_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateFontAsset_Private_Static_FontAsset_Font_Int32_Int32_Int32_GlyphRenderMode_Int32_Int32_AtlasPopulationMode_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateFontAssetInstance_Private_Static_FontAsset_Font_Int32_GlyphRenderMode_Int32_Int32_AtlasPopulationMode_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetFontAssetByID_Internal_Static_FontAsset_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RegisterCallbackInstance_Private_Void_FontAsset_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ReadFontAssetDefinition_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InitializeDictionaryLookupTables_Internal_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InitializeLookup_Private_Static_Void_ICollection_byref_Dictionary_2_UInt32_T_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InitializeList_Private_Static_Void_ICollection_byref_List_1_T_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InitializeGlyphLookupDictionary_Internal_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InitializeCharacterLookupDictionary_Internal_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ClearFallbackCharacterTable_Internal_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InitializeLigatureSubstitutionLookupDictionary_Internal_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InitializeGlyphPairAdjustmentRecordsLookupDictionary_Internal_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InitializeMarkToBaseAdjustmentRecordsLookupDictionary_Internal_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InitializeMarkToMarkAdjustmentRecordsLookupDictionary_Internal_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddSynthesizedCharactersAndFaceMetrics_Internal_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddSynthesizedCharacter_Private_Void_UInt32_Boolean_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddCharacterToLookupCache_Internal_Void_UInt32_Character_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddCharacterToLookupCache_Internal_Void_UInt32_Character_FontStyles_TextFontWeight_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetCharacterInLookupCache_Internal_Boolean_UInt32_FontStyles_TextFontWeight_byref_Character_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RemoveCharacterInLookupCache_Internal_Void_UInt32_FontStyles_TextFontWeight_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ContainsCharacterInLookupCache_Internal_Boolean_UInt32_FontStyles_TextFontWeight_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateCompositeKey_Private_UInt32_UInt32_FontStyles_TextFontWeight_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LoadFontFace_Internal_FontEngineError_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SortCharacterTable_Internal_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SortGlyphTable_Internal_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SortFontFeatureTable_Internal_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SortAllTables_Internal_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_HasCharacter_Public_Boolean_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_HasCharacter_Public_Boolean_Char_Boolean_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_HasCharacter_Public_Boolean_UInt32_Boolean_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_HasCharacterWithStyle_Internal_Private_Boolean_UInt32_FontStyles_TextFontWeight_Boolean_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_HasCharacter_Internal_Private_Boolean_UInt32_FontStyles_TextFontWeight_Boolean_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_HasCharacters_Public_Boolean_String_byref_List_1_Char_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_HasCharacters_Public_Boolean_String_byref_Il2CppStructArray_1_UInt32_Boolean_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_HasCharacters_Public_Boolean_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetCharacters_Public_Static_String_FontAsset_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetCharactersArray_Public_Static_Il2CppStructArray_1_Int32_FontAsset_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetGlyphIndex_Internal_UInt32_UInt32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetGlyphIndex_Internal_UInt32_UInt32_byref_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetGlyphVariantIndex_Internal_UInt32_UInt32_UInt32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UpdateFontAssetData_Internal_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ClearFontAssetData_Public_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ClearCharacterAndGlyphTablesInternal_Internal_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ClearCharacterAndGlyphTables_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ClearFontFeaturesTables_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ClearAtlasTextures_Internal_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DestroyAtlasTextures_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RegisterFontAssetForFontFeatureUpdate_Internal_Static_Void_FontAsset_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RegisterFontAssetForKerningUpdate_Internal_Static_Void_FontAsset_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UpdateFontFeaturesForFontAssetsInQueue_Internal_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RegisterAtlasTextureForApply_Internal_Static_Void_Texture2D_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UpdateAtlasTexturesInQueue_Internal_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UpdateFontAssetsInUpdateQueue_Internal_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TryAddCharacters_Public_Boolean_Il2CppStructArray_1_UInt32_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TryAddCharacters_Public_Boolean_Il2CppStructArray_1_UInt32_byref_Il2CppStructArray_1_UInt32_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TryAddCharacters_Public_Boolean_String_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TryAddCharacters_Public_Boolean_String_byref_String_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TryAddGlyphVariantIndexInternal_Internal_Boolean_UInt32_UInt32_UInt32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TryGetGlyphVariantIndexInternal_Internal_Boolean_UInt32_UInt32_byref_UInt32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TryAddGlyphInternal_Internal_Boolean_UInt32_byref_Glyph_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TryAddCharacterInternal_Internal_Boolean_UInt32_byref_Character_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TryAddCharacterInternal_Internal_Boolean_UInt32_FontStyles_TextFontWeight_byref_Character_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TryAddGlyphToAtlas_Private_Boolean_UInt32_byref_Glyph_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TryAddGlyphToTexture_Private_Boolean_UInt32_byref_Glyph_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TryAddGlyphsToNewAtlasTexture_Private_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetupNewAtlasTexture_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateCharacterAndAddToCache_Private_Character_UInt32_Glyph_FontStyles_TextFontWeight_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UpdateFontFeaturesForNewlyAddedGlyphs_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UpdateGlyphAdjustmentRecordsForNewGlyphs_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UpdateGPOSFontFeaturesForNewlyAddedGlyphs_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ImportFontFeatures_Internal_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UpdateGSUBFontFeaturesForNewGlyphIndex_Private_Void_UInt32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UpdateLigatureSubstitutionRecords_Internal_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddLigatureSubstitutionRecords_Private_Void_Il2CppReferenceArray_1_LigatureSubstitutionRecord_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UpdateGlyphAdjustmentRecords_Internal_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddPairAdjustmentRecords_Private_Void_Il2CppStructArray_1_GlyphPairAdjustmentRecord_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UpdateDiacriticalMarkAdjustmentRecords_Internal_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddMarkToBaseAdjustmentRecords_Private_Void_Il2CppStructArray_1_MarkToBaseAdjustmentRecord_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddMarkToMarkAdjustmentRecords_Private_Void_Il2CppStructArray_1_MarkToMarkAdjustmentRecord_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_nativeFontAsset_Internal_get_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_EnsureNativeFontAssetIsCreated_Internal_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UpdateFallbacks_Internal_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UpdateWeightFallbacks_Internal_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UpdateFaceInfo_Internal_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetFallbacks_Internal_Il2CppStructArray_1_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_HasRecursion_Private_Boolean_FontAsset_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_HasRecursionInternal_Private_Boolean_FontAsset_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetWeightFallbacks_Private_ValueTuple_2_Il2CppStructArray_1_IntPtr_Il2CppStructArray_1_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateHbFaceIfNeeded_Internal_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UpdateFallbacks_Private_Static_Void_IntPtr_Il2CppStructArray_1_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UpdateWeightFallbacks_Private_Static_Void_IntPtr_Il2CppStructArray_1_IntPtr_Il2CppStructArray_1_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Create_Private_Static_IntPtr_FaceInfo_Font_Font_String_Int32_Il2CppStructArray_1_IntPtr_Il2CppStructArray_1_IntPtr_Il2CppStructArray_1_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UpdateFaceInfo_Private_Static_Void_IntPtr_FaceInfo_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Destroy_Private_Static_Void_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UpdateFallbacks_Injected_Private_Static_Void_IntPtr_byref_ManagedSpanWrapper_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UpdateWeightFallbacks_Injected_Private_Static_Void_IntPtr_byref_ManagedSpanWrapper_byref_ManagedSpanWrapper_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Create_Injected_Private_Static_IntPtr_byref_FaceInfo_IntPtr_IntPtr_byref_ManagedSpanWrapper_Int32_byref_ManagedSpanWrapper_byref_ManagedSpanWrapper_byref_ManagedSpanWrapper_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UpdateFaceInfo_Injected_Private_Static_Void_IntPtr_byref_FaceInfo_0;

	public unsafe static Dictionary<int, FontAsset> kFontAssetByInstanceId
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_kFontAssetByInstanceId, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<int, FontAsset>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_kFontAssetByInstanceId, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

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

	public unsafe FontAssetCreationEditorSettings m_fontAssetCreationEditorSettings
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_fontAssetCreationEditorSettings);
			return new FontAssetCreationEditorSettings(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<FontAssetCreationEditorSettings>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_fontAssetCreationEditorSettings), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<FontAssetCreationEditorSettings>.NativeClassPtr, ref *(uint*)null));
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

	public unsafe bool IsEditorFont
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IsEditorFont);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IsEditorFont)) = value;
		}
	}

	public unsafe FaceInfo m_FaceInfo
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_FaceInfo);
			return new FaceInfo(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<FaceInfo>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_FaceInfo), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<FaceInfo>.NativeClassPtr, ref *(uint*)null));
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

	public unsafe List<Character> m_CharacterTable
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_CharacterTable);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<Character>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_CharacterTable)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe Dictionary<uint, Character> m_CharacterLookupDictionary
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_CharacterLookupDictionary);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<uint, Character>>(intPtr) : null;
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

	public unsafe FontFeatureTable m_FontFeatureTable
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_FontFeatureTable);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<FontFeatureTable>(intPtr) : null;
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

	public unsafe List<FontAsset> m_FallbackFontAssetTable
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_FallbackFontAssetTable);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<FontAsset>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_FallbackFontAssetTable)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe Il2CppReferenceArray<FontWeightPair> m_FontWeightTable
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_FontWeightTable);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<FontWeightPair>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_FontWeightTable)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe float m_RegularStyleWeight
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_RegularStyleWeight);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_RegularStyleWeight)) = value;
		}
	}

	public unsafe float m_RegularStyleSpacing
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_RegularStyleSpacing);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_RegularStyleSpacing)) = value;
		}
	}

	public unsafe float m_BoldStyleWeight
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_BoldStyleWeight);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_BoldStyleWeight)) = value;
		}
	}

	public unsafe float m_BoldStyleSpacing
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_BoldStyleSpacing);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_BoldStyleSpacing)) = value;
		}
	}

	public unsafe byte m_ItalicStyleSlant
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ItalicStyleSlant);
			return *(byte*)num;
		}
		set
		{
			*(byte*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ItalicStyleSlant)) = value;
		}
	}

	public unsafe byte m_TabMultiple
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_TabMultiple);
			return *(byte*)num;
		}
		set
		{
			*(byte*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_TabMultiple)) = value;
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

	public unsafe System.IntPtr m_NativeFontAsset
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_NativeFontAsset);
			return *(System.IntPtr*)num;
		}
		set
		{
			*(System.IntPtr*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_NativeFontAsset)) = value;
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

	public unsafe List<Character> m_CharactersToAdd
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_CharactersToAdd);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<Character>>(intPtr) : null;
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

	public unsafe Dictionary<Il2CppSystem.ValueTuple<uint, uint>, uint> m_VariantGlyphIndexes
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_VariantGlyphIndexes);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<Il2CppSystem.ValueTuple<uint, uint>, uint>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_VariantGlyphIndexes)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe bool m_IsClone
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_IsClone);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_IsClone)) = value;
		}
	}

	public unsafe static List<Il2CppSystem.WeakReference<FontAsset>> s_CallbackInstances
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_CallbackInstances, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<Il2CppSystem.WeakReference<FontAsset>>>(intPtr2) : null;
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

	public unsafe static List<FontAsset> k_FontAssets_FontFeaturesUpdateQueue
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_k_FontAssets_FontFeaturesUpdateQueue, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<FontAsset>>(intPtr2) : null;
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

	public unsafe static List<FontAsset> k_FontAssets_KerningUpdateQueue
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_k_FontAssets_KerningUpdateQueue, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<FontAsset>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_k_FontAssets_KerningUpdateQueue, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static HashSet<int> k_FontAssets_KerningUpdateQueueLookup
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_k_FontAssets_KerningUpdateQueueLookup, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<HashSet<int>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_k_FontAssets_KerningUpdateQueueLookup, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
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

	public unsafe static HashSet<int> visitedFontAssets
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_visitedFontAssets, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<HashSet<int>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_visitedFontAssets, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe FontAssetCreationEditorSettings fontAssetCreationEditorSettings
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_fontAssetCreationEditorSettings_Public_get_FontAssetCreationEditorSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new FontAssetCreationEditorSettings(pointer);
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1275331, XrefRangeEnd = 1275332, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)value));
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_fontAssetCreationEditorSettings_Public_set_Void_FontAssetCreationEditorSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
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
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 1275332, RefRangeEnd = 1275338, XrefRangeStart = 1275332, XrefRangeEnd = 1275332, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

	public unsafe FaceInfo faceInfo
	{
		[CallerCount(22)]
		[CachedScanResults(RefRangeStart = 1275338, RefRangeEnd = 1275360, XrefRangeStart = 1275338, XrefRangeEnd = 1275338, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_faceInfo_Public_get_FaceInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new FaceInfo(pointer);
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1275360, XrefRangeEnd = 1275370, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)value));
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_faceInfo_Public_set_Void_FaceInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe int familyNameHashCode
	{
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1275372, RefRangeEnd = 1275376, XrefRangeStart = 1275370, XrefRangeEnd = 1275372, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
		[CachedScanResults(RefRangeStart = 1275378, RefRangeEnd = 1275382, XrefRangeStart = 1275376, XrefRangeEnd = 1275378, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1275382, XrefRangeEnd = 1275383, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

	public unsafe List<Character> characterTable
	{
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1275383, RefRangeEnd = 1275386, XrefRangeStart = 1275383, XrefRangeEnd = 1275383, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_characterTable_Public_get_List_1_Character_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<Character>>(intPtr2) : null;
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_characterTable_Internal_set_Void_List_1_Character_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe Dictionary<uint, Character> characterLookupTable
	{
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 1275387, RefRangeEnd = 1275394, XrefRangeStart = 1275386, XrefRangeEnd = 1275387, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_characterLookupTable_Public_get_Dictionary_2_UInt32_Character_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<uint, Character>>(intPtr2) : null;
		}
	}

	public unsafe Texture2D atlasTexture
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1275394, XrefRangeEnd = 1275399, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
		[CallerCount(0)]
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
		[CallerCount(0)]
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
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1275399, RefRangeEnd = 1275404, XrefRangeStart = 1275399, XrefRangeEnd = 1275399, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1275404, RefRangeEnd = 1275409, XrefRangeStart = 1275404, XrefRangeEnd = 1275404, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1275409, RefRangeEnd = 1275414, XrefRangeStart = 1275409, XrefRangeEnd = 1275409, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 1275414, RefRangeEnd = 1275422, XrefRangeStart = 1275414, XrefRangeEnd = 1275414, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

	public unsafe FontFeatureTable fontFeatureTable
	{
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 1275422, RefRangeEnd = 1275430, XrefRangeStart = 1275422, XrefRangeEnd = 1275422, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_fontFeatureTable_Public_get_FontFeatureTable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<FontFeatureTable>(intPtr2) : null;
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_fontFeatureTable_Internal_set_Void_FontFeatureTable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe List<FontAsset> fallbackFontAssetTable
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_fallbackFontAssetTable_Public_get_List_1_FontAsset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<FontAsset>>(intPtr2) : null;
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_fallbackFontAssetTable_Public_set_Void_List_1_FontAsset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe Il2CppReferenceArray<FontWeightPair> fontWeightTable
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_fontWeightTable_Public_get_Il2CppReferenceArray_1_FontWeightPair_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<FontWeightPair>>(intPtr2) : null;
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_fontWeightTable_Internal_set_Void_Il2CppReferenceArray_1_FontWeightPair_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe float regularStyleWeight
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_regularStyleWeight_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_regularStyleWeight_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe float regularStyleSpacing
	{
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 1275430, RefRangeEnd = 1275437, XrefRangeStart = 1275430, XrefRangeEnd = 1275430, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_regularStyleSpacing_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_regularStyleSpacing_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe float boldStyleWeight
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1275437, RefRangeEnd = 1275438, XrefRangeStart = 1275437, XrefRangeEnd = 1275437, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_boldStyleWeight_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_boldStyleWeight_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe float boldStyleSpacing
	{
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1275438, RefRangeEnd = 1275440, XrefRangeStart = 1275438, XrefRangeEnd = 1275438, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_boldStyleSpacing_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_boldStyleSpacing_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe byte italicStyleSlant
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1275440, RefRangeEnd = 1275441, XrefRangeStart = 1275440, XrefRangeEnd = 1275440, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_italicStyleSlant_Public_get_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(byte*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_italicStyleSlant_Public_set_Void_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe byte tabMultiple
	{
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1275441, RefRangeEnd = 1275443, XrefRangeStart = 1275441, XrefRangeEnd = 1275441, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_tabMultiple_Public_get_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(byte*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_tabMultiple_Public_set_Void_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe System.IntPtr nativeFontAsset
	{
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 1277774, RefRangeEnd = 1277780, XrefRangeStart = 1277762, XrefRangeEnd = 1277774, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_nativeFontAsset_Internal_get_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(System.IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	static FontAsset()
	{
		Il2CppClassPointerStore<FontAsset>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.TextCoreTextEngineModule.dll", "UnityEngine.TextCore.Text", "FontAsset");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FontAsset>.NativeClassPtr);
		NativeFieldInfoPtr_kFontAssetByInstanceId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, "kFontAssetByInstanceId");
		NativeFieldInfoPtr_m_SourceFontFileGUID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, "m_SourceFontFileGUID");
		NativeFieldInfoPtr_m_fontAssetCreationEditorSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, "m_fontAssetCreationEditorSettings");
		NativeFieldInfoPtr_m_SourceFontFile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, "m_SourceFontFile");
		NativeFieldInfoPtr_m_SourceFontFilePath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, "m_SourceFontFilePath");
		NativeFieldInfoPtr_m_AtlasPopulationMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, "m_AtlasPopulationMode");
		NativeFieldInfoPtr_InternalDynamicOS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, "InternalDynamicOS");
		NativeFieldInfoPtr_IsEditorFont = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, "IsEditorFont");
		NativeFieldInfoPtr_m_FaceInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, "m_FaceInfo");
		NativeFieldInfoPtr_m_FamilyNameHashCode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, "m_FamilyNameHashCode");
		NativeFieldInfoPtr_m_StyleNameHashCode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, "m_StyleNameHashCode");
		NativeFieldInfoPtr_m_GlyphTable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, "m_GlyphTable");
		NativeFieldInfoPtr_m_GlyphLookupDictionary = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, "m_GlyphLookupDictionary");
		NativeFieldInfoPtr_m_CharacterTable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, "m_CharacterTable");
		NativeFieldInfoPtr_m_CharacterLookupDictionary = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, "m_CharacterLookupDictionary");
		NativeFieldInfoPtr_m_AtlasTexture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, "m_AtlasTexture");
		NativeFieldInfoPtr_m_AtlasTextures = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, "m_AtlasTextures");
		NativeFieldInfoPtr_m_AtlasTextureIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, "m_AtlasTextureIndex");
		NativeFieldInfoPtr_m_IsMultiAtlasTexturesEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, "m_IsMultiAtlasTexturesEnabled");
		NativeFieldInfoPtr_m_GetFontFeatures = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, "m_GetFontFeatures");
		NativeFieldInfoPtr_m_ClearDynamicDataOnBuild = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, "m_ClearDynamicDataOnBuild");
		NativeFieldInfoPtr_m_AtlasWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, "m_AtlasWidth");
		NativeFieldInfoPtr_m_AtlasHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, "m_AtlasHeight");
		NativeFieldInfoPtr_m_AtlasPadding = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, "m_AtlasPadding");
		NativeFieldInfoPtr_m_AtlasRenderMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, "m_AtlasRenderMode");
		NativeFieldInfoPtr_m_UsedGlyphRects = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, "m_UsedGlyphRects");
		NativeFieldInfoPtr_m_FreeGlyphRects = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, "m_FreeGlyphRects");
		NativeFieldInfoPtr_m_FontFeatureTable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, "m_FontFeatureTable");
		NativeFieldInfoPtr_m_ShouldReimportFontFeatures = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, "m_ShouldReimportFontFeatures");
		NativeFieldInfoPtr_m_FallbackFontAssetTable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, "m_FallbackFontAssetTable");
		NativeFieldInfoPtr_m_FontWeightTable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, "m_FontWeightTable");
		NativeFieldInfoPtr_m_RegularStyleWeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, "m_RegularStyleWeight");
		NativeFieldInfoPtr_m_RegularStyleSpacing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, "m_RegularStyleSpacing");
		NativeFieldInfoPtr_m_BoldStyleWeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, "m_BoldStyleWeight");
		NativeFieldInfoPtr_m_BoldStyleSpacing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, "m_BoldStyleSpacing");
		NativeFieldInfoPtr_m_ItalicStyleSlant = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, "m_ItalicStyleSlant");
		NativeFieldInfoPtr_m_TabMultiple = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, "m_TabMultiple");
		NativeFieldInfoPtr_IsFontAssetLookupTablesDirty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, "IsFontAssetLookupTablesDirty");
		NativeFieldInfoPtr_m_NativeFontAsset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, "m_NativeFontAsset");
		NativeFieldInfoPtr_m_GlyphsToRender = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, "m_GlyphsToRender");
		NativeFieldInfoPtr_m_GlyphsRendered = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, "m_GlyphsRendered");
		NativeFieldInfoPtr_m_GlyphIndexList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, "m_GlyphIndexList");
		NativeFieldInfoPtr_m_GlyphIndexListNewlyAdded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, "m_GlyphIndexListNewlyAdded");
		NativeFieldInfoPtr_m_GlyphsToAdd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, "m_GlyphsToAdd");
		NativeFieldInfoPtr_m_GlyphsToAddLookup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, "m_GlyphsToAddLookup");
		NativeFieldInfoPtr_m_CharactersToAdd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, "m_CharactersToAdd");
		NativeFieldInfoPtr_m_CharactersToAddLookup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, "m_CharactersToAddLookup");
		NativeFieldInfoPtr_s_MissingCharacterList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, "s_MissingCharacterList");
		NativeFieldInfoPtr_m_MissingUnicodesFromFontFile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, "m_MissingUnicodesFromFontFile");
		NativeFieldInfoPtr_m_VariantGlyphIndexes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, "m_VariantGlyphIndexes");
		NativeFieldInfoPtr_m_IsClone = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, "m_IsClone");
		NativeFieldInfoPtr_s_CallbackInstances = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, "s_CallbackInstances");
		NativeFieldInfoPtr_k_ReadFontAssetDefinitionMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, "k_ReadFontAssetDefinitionMarker");
		NativeFieldInfoPtr_k_AddSynthesizedCharactersMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, "k_AddSynthesizedCharactersMarker");
		NativeFieldInfoPtr_k_TryAddGlyphMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, "k_TryAddGlyphMarker");
		NativeFieldInfoPtr_k_TryAddCharacterMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, "k_TryAddCharacterMarker");
		NativeFieldInfoPtr_k_TryAddCharactersMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, "k_TryAddCharactersMarker");
		NativeFieldInfoPtr_k_UpdateLigatureSubstitutionRecordsMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, "k_UpdateLigatureSubstitutionRecordsMarker");
		NativeFieldInfoPtr_k_UpdateGlyphAdjustmentRecordsMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, "k_UpdateGlyphAdjustmentRecordsMarker");
		NativeFieldInfoPtr_k_UpdateDiacriticalMarkAdjustmentRecordsMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, "k_UpdateDiacriticalMarkAdjustmentRecordsMarker");
		NativeFieldInfoPtr_k_ClearFontAssetDataMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, "k_ClearFontAssetDataMarker");
		NativeFieldInfoPtr_k_UpdateFontAssetDataMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, "k_UpdateFontAssetDataMarker");
		NativeFieldInfoPtr_s_DefaultMaterialSuffix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, "s_DefaultMaterialSuffix");
		NativeFieldInfoPtr_k_SearchedFontAssetLookup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, "k_SearchedFontAssetLookup");
		NativeFieldInfoPtr_k_FontAssets_FontFeaturesUpdateQueue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, "k_FontAssets_FontFeaturesUpdateQueue");
		NativeFieldInfoPtr_k_FontAssets_FontFeaturesUpdateQueueLookup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, "k_FontAssets_FontFeaturesUpdateQueueLookup");
		NativeFieldInfoPtr_k_FontAssets_KerningUpdateQueue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, "k_FontAssets_KerningUpdateQueue");
		NativeFieldInfoPtr_k_FontAssets_KerningUpdateQueueLookup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, "k_FontAssets_KerningUpdateQueueLookup");
		NativeFieldInfoPtr_k_FontAssets_AtlasTexturesUpdateQueue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, "k_FontAssets_AtlasTexturesUpdateQueue");
		NativeFieldInfoPtr_k_FontAssets_AtlasTexturesUpdateQueueLookup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, "k_FontAssets_AtlasTexturesUpdateQueueLookup");
		NativeFieldInfoPtr_k_GlyphIndexArray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, "k_GlyphIndexArray");
		NativeFieldInfoPtr_visitedFontAssets = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, "visitedFontAssets");
		NativeMethodInfoPtr_EnsureAdditionalCapacity_Private_Static_Void_List_1_T_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, 100663401);
		NativeMethodInfoPtr_EnsureAdditionalCapacity_Private_Static_Void_Dictionary_2_TKey_TValue_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, 100663402);
		NativeMethodInfoPtr_get_fontAssetCreationEditorSettings_Public_get_FontAssetCreationEditorSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, 100663403);
		NativeMethodInfoPtr_set_fontAssetCreationEditorSettings_Public_set_Void_FontAssetCreationEditorSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, 100663404);
		NativeMethodInfoPtr_get_sourceFontFile_Public_get_Font_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, 100663405);
		NativeMethodInfoPtr_set_sourceFontFile_Internal_set_Void_Font_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, 100663406);
		NativeMethodInfoPtr_get_atlasPopulationMode_Public_get_AtlasPopulationMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, 100663407);
		NativeMethodInfoPtr_set_atlasPopulationMode_Public_set_Void_AtlasPopulationMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, 100663408);
		NativeMethodInfoPtr_get_faceInfo_Public_get_FaceInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, 100663409);
		NativeMethodInfoPtr_set_faceInfo_Public_set_Void_FaceInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, 100663410);
		NativeMethodInfoPtr_get_familyNameHashCode_Internal_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, 100663411);
		NativeMethodInfoPtr_set_familyNameHashCode_Internal_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, 100663412);
		NativeMethodInfoPtr_get_styleNameHashCode_Internal_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, 100663413);
		NativeMethodInfoPtr_set_styleNameHashCode_Internal_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, 100663414);
		NativeMethodInfoPtr_get_glyphTable_Public_get_List_1_Glyph_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, 100663415);
		NativeMethodInfoPtr_set_glyphTable_Internal_set_Void_List_1_Glyph_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, 100663416);
		NativeMethodInfoPtr_get_glyphLookupTable_Public_get_Dictionary_2_UInt32_Glyph_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, 100663417);
		NativeMethodInfoPtr_get_characterTable_Public_get_List_1_Character_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, 100663418);
		NativeMethodInfoPtr_set_characterTable_Internal_set_Void_List_1_Character_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, 100663419);
		NativeMethodInfoPtr_get_characterLookupTable_Public_get_Dictionary_2_UInt32_Character_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, 100663420);
		NativeMethodInfoPtr_get_atlasTexture_Public_get_Texture2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, 100663421);
		NativeMethodInfoPtr_get_atlasTextures_Public_get_Il2CppReferenceArray_1_Texture2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, 100663422);
		NativeMethodInfoPtr_set_atlasTextures_Public_set_Void_Il2CppReferenceArray_1_Texture2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, 100663423);
		NativeMethodInfoPtr_get_atlasTextureCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, 100663424);
		NativeMethodInfoPtr_get_isMultiAtlasTexturesEnabled_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, 100663425);
		NativeMethodInfoPtr_set_isMultiAtlasTexturesEnabled_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, 100663426);
		NativeMethodInfoPtr_get_getFontFeatures_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, 100663427);
		NativeMethodInfoPtr_set_getFontFeatures_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, 100663428);
		NativeMethodInfoPtr_get_clearDynamicDataOnBuild_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, 100663429);
		NativeMethodInfoPtr_set_clearDynamicDataOnBuild_Internal_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, 100663430);
		NativeMethodInfoPtr_get_atlasWidth_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, 100663431);
		NativeMethodInfoPtr_set_atlasWidth_Internal_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, 100663432);
		NativeMethodInfoPtr_get_atlasHeight_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, 100663433);
		NativeMethodInfoPtr_set_atlasHeight_Internal_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, 100663434);
		NativeMethodInfoPtr_get_atlasPadding_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, 100663435);
		NativeMethodInfoPtr_set_atlasPadding_Internal_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, 100663436);
		NativeMethodInfoPtr_get_atlasRenderMode_Public_get_GlyphRenderMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, 100663437);
		NativeMethodInfoPtr_set_atlasRenderMode_Internal_set_Void_GlyphRenderMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, 100663438);
		NativeMethodInfoPtr_get_usedGlyphRects_Internal_get_List_1_GlyphRect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, 100663439);
		NativeMethodInfoPtr_set_usedGlyphRects_Internal_set_Void_List_1_GlyphRect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, 100663440);
		NativeMethodInfoPtr_get_freeGlyphRects_Internal_get_List_1_GlyphRect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, 100663441);
		NativeMethodInfoPtr_set_freeGlyphRects_Internal_set_Void_List_1_GlyphRect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, 100663442);
		NativeMethodInfoPtr_get_fontFeatureTable_Public_get_FontFeatureTable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, 100663443);
		NativeMethodInfoPtr_set_fontFeatureTable_Internal_set_Void_FontFeatureTable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, 100663444);
		NativeMethodInfoPtr_get_fallbackFontAssetTable_Public_get_List_1_FontAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, 100663445);
		NativeMethodInfoPtr_set_fallbackFontAssetTable_Public_set_Void_List_1_FontAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, 100663446);
		NativeMethodInfoPtr_get_fontWeightTable_Public_get_Il2CppReferenceArray_1_FontWeightPair_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, 100663447);
		NativeMethodInfoPtr_set_fontWeightTable_Internal_set_Void_Il2CppReferenceArray_1_FontWeightPair_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, 100663448);
		NativeMethodInfoPtr_get_regularStyleWeight_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, 100663449);
		NativeMethodInfoPtr_set_regularStyleWeight_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, 100663450);
		NativeMethodInfoPtr_get_regularStyleSpacing_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, 100663451);
		NativeMethodInfoPtr_set_regularStyleSpacing_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, 100663452);
		NativeMethodInfoPtr_get_boldStyleWeight_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, 100663453);
		NativeMethodInfoPtr_set_boldStyleWeight_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, 100663454);
		NativeMethodInfoPtr_get_boldStyleSpacing_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, 100663455);
		NativeMethodInfoPtr_set_boldStyleSpacing_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, 100663456);
		NativeMethodInfoPtr_get_italicStyleSlant_Public_get_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, 100663457);
		NativeMethodInfoPtr_set_italicStyleSlant_Public_set_Void_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, 100663458);
		NativeMethodInfoPtr_get_tabMultiple_Public_get_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, 100663459);
		NativeMethodInfoPtr_set_tabMultiple_Public_set_Void_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, 100663460);
		NativeMethodInfoPtr_CreateFontAsset_Public_Static_FontAsset_String_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, 100663461);
		NativeMethodInfoPtr_CreateFontAssetInternal_Internal_Static_FontAsset_String_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, 100663462);
		NativeMethodInfoPtr_CreateFontAsset_Internal_Static_FontAsset_String_String_Int32_Int32_GlyphRenderMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, 100663463);
		NativeMethodInfoPtr_CreateFontAssetOSFallbackList_Internal_Static_List_1_FontAsset_Il2CppStringArray_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, 100663464);
		NativeMethodInfoPtr_CreateFontAssetWithOSFallbackList_Internal_Static_FontAsset_Il2CppStringArray_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, 100663465);
		NativeMethodInfoPtr_CreateFontAssetFromFamilyName_Private_Static_FontAsset_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, 100663466);
		NativeMethodInfoPtr_CreateFontAsset_Public_Static_FontAsset_String_Int32_Int32_Int32_GlyphRenderMode_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, 100663467);
		NativeMethodInfoPtr_CreateFontAsset_Private_Static_FontAsset_String_Int32_Int32_Int32_GlyphRenderMode_Int32_Int32_AtlasPopulationMode_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, 100663468);
		NativeMethodInfoPtr_CreateFontAsset_Public_Static_FontAsset_Font_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, 100663469);
		NativeMethodInfoPtr_CreateFontAsset_Public_Static_FontAsset_Font_Int32_Int32_GlyphRenderMode_Int32_Int32_AtlasPopulationMode_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, 100663470);
		NativeMethodInfoPtr_CreateFontAsset_Private_Static_FontAsset_Font_Int32_Int32_Int32_GlyphRenderMode_Int32_Int32_AtlasPopulationMode_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, 100663471);
		NativeMethodInfoPtr_CreateFontAssetInstance_Private_Static_FontAsset_Font_Int32_GlyphRenderMode_Int32_Int32_AtlasPopulationMode_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, 100663472);
		NativeMethodInfoPtr_GetFontAssetByID_Internal_Static_FontAsset_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, 100663473);
		NativeMethodInfoPtr_RegisterCallbackInstance_Private_Void_FontAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, 100663474);
		NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, 100663475);
		NativeMethodInfoPtr_ReadFontAssetDefinition_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, 100663476);
		NativeMethodInfoPtr_InitializeDictionaryLookupTables_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, 100663477);
		NativeMethodInfoPtr_InitializeLookup_Private_Static_Void_ICollection_byref_Dictionary_2_UInt32_T_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, 100663478);
		NativeMethodInfoPtr_InitializeList_Private_Static_Void_ICollection_byref_List_1_T_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, 100663479);
		NativeMethodInfoPtr_InitializeGlyphLookupDictionary_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, 100663480);
		NativeMethodInfoPtr_InitializeCharacterLookupDictionary_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, 100663481);
		NativeMethodInfoPtr_ClearFallbackCharacterTable_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, 100663482);
		NativeMethodInfoPtr_InitializeLigatureSubstitutionLookupDictionary_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, 100663483);
		NativeMethodInfoPtr_InitializeGlyphPairAdjustmentRecordsLookupDictionary_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, 100663484);
		NativeMethodInfoPtr_InitializeMarkToBaseAdjustmentRecordsLookupDictionary_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, 100663485);
		NativeMethodInfoPtr_InitializeMarkToMarkAdjustmentRecordsLookupDictionary_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, 100663486);
		NativeMethodInfoPtr_AddSynthesizedCharactersAndFaceMetrics_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, 100663487);
		NativeMethodInfoPtr_AddSynthesizedCharacter_Private_Void_UInt32_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, 100663488);
		NativeMethodInfoPtr_AddCharacterToLookupCache_Internal_Void_UInt32_Character_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, 100663489);
		NativeMethodInfoPtr_AddCharacterToLookupCache_Internal_Void_UInt32_Character_FontStyles_TextFontWeight_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, 100663490);
		NativeMethodInfoPtr_GetCharacterInLookupCache_Internal_Boolean_UInt32_FontStyles_TextFontWeight_byref_Character_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, 100663491);
		NativeMethodInfoPtr_RemoveCharacterInLookupCache_Internal_Void_UInt32_FontStyles_TextFontWeight_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, 100663492);
		NativeMethodInfoPtr_ContainsCharacterInLookupCache_Internal_Boolean_UInt32_FontStyles_TextFontWeight_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, 100663493);
		NativeMethodInfoPtr_CreateCompositeKey_Private_UInt32_UInt32_FontStyles_TextFontWeight_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, 100663494);
		NativeMethodInfoPtr_LoadFontFace_Internal_FontEngineError_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, 100663495);
		NativeMethodInfoPtr_SortCharacterTable_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, 100663496);
		NativeMethodInfoPtr_SortGlyphTable_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, 100663497);
		NativeMethodInfoPtr_SortFontFeatureTable_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, 100663498);
		NativeMethodInfoPtr_SortAllTables_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, 100663499);
		NativeMethodInfoPtr_HasCharacter_Public_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, 100663500);
		NativeMethodInfoPtr_HasCharacter_Public_Boolean_Char_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, 100663501);
		NativeMethodInfoPtr_HasCharacter_Public_Boolean_UInt32_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, 100663502);
		NativeMethodInfoPtr_HasCharacterWithStyle_Internal_Private_Boolean_UInt32_FontStyles_TextFontWeight_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, 100663503);
		NativeMethodInfoPtr_HasCharacter_Internal_Private_Boolean_UInt32_FontStyles_TextFontWeight_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, 100663504);
		NativeMethodInfoPtr_HasCharacters_Public_Boolean_String_byref_List_1_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, 100663505);
		NativeMethodInfoPtr_HasCharacters_Public_Boolean_String_byref_Il2CppStructArray_1_UInt32_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, 100663506);
		NativeMethodInfoPtr_HasCharacters_Public_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, 100663507);
		NativeMethodInfoPtr_GetCharacters_Public_Static_String_FontAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, 100663508);
		NativeMethodInfoPtr_GetCharactersArray_Public_Static_Il2CppStructArray_1_Int32_FontAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, 100663509);
		NativeMethodInfoPtr_GetGlyphIndex_Internal_UInt32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, 100663510);
		NativeMethodInfoPtr_GetGlyphIndex_Internal_UInt32_UInt32_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, 100663511);
		NativeMethodInfoPtr_GetGlyphVariantIndex_Internal_UInt32_UInt32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, 100663512);
		NativeMethodInfoPtr_UpdateFontAssetData_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, 100663513);
		NativeMethodInfoPtr_ClearFontAssetData_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, 100663514);
		NativeMethodInfoPtr_ClearCharacterAndGlyphTablesInternal_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, 100663515);
		NativeMethodInfoPtr_ClearCharacterAndGlyphTables_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, 100663516);
		NativeMethodInfoPtr_ClearFontFeaturesTables_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, 100663517);
		NativeMethodInfoPtr_ClearAtlasTextures_Internal_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, 100663518);
		NativeMethodInfoPtr_DestroyAtlasTextures_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, 100663519);
		NativeMethodInfoPtr_RegisterFontAssetForFontFeatureUpdate_Internal_Static_Void_FontAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, 100663520);
		NativeMethodInfoPtr_RegisterFontAssetForKerningUpdate_Internal_Static_Void_FontAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, 100663521);
		NativeMethodInfoPtr_UpdateFontFeaturesForFontAssetsInQueue_Internal_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, 100663522);
		NativeMethodInfoPtr_RegisterAtlasTextureForApply_Internal_Static_Void_Texture2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, 100663523);
		NativeMethodInfoPtr_UpdateAtlasTexturesInQueue_Internal_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, 100663524);
		NativeMethodInfoPtr_UpdateFontAssetsInUpdateQueue_Internal_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, 100663525);
		NativeMethodInfoPtr_TryAddCharacters_Public_Boolean_Il2CppStructArray_1_UInt32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, 100663526);
		NativeMethodInfoPtr_TryAddCharacters_Public_Boolean_Il2CppStructArray_1_UInt32_byref_Il2CppStructArray_1_UInt32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, 100663527);
		NativeMethodInfoPtr_TryAddCharacters_Public_Boolean_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, 100663528);
		NativeMethodInfoPtr_TryAddCharacters_Public_Boolean_String_byref_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, 100663529);
		NativeMethodInfoPtr_TryAddGlyphVariantIndexInternal_Internal_Boolean_UInt32_UInt32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, 100663530);
		NativeMethodInfoPtr_TryGetGlyphVariantIndexInternal_Internal_Boolean_UInt32_UInt32_byref_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, 100663531);
		NativeMethodInfoPtr_TryAddGlyphInternal_Internal_Boolean_UInt32_byref_Glyph_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, 100663532);
		NativeMethodInfoPtr_TryAddCharacterInternal_Internal_Boolean_UInt32_byref_Character_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, 100663533);
		NativeMethodInfoPtr_TryAddCharacterInternal_Internal_Boolean_UInt32_FontStyles_TextFontWeight_byref_Character_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, 100663534);
		NativeMethodInfoPtr_TryAddGlyphToAtlas_Private_Boolean_UInt32_byref_Glyph_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, 100663535);
		NativeMethodInfoPtr_TryAddGlyphToTexture_Private_Boolean_UInt32_byref_Glyph_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, 100663536);
		NativeMethodInfoPtr_TryAddGlyphsToNewAtlasTexture_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, 100663537);
		NativeMethodInfoPtr_SetupNewAtlasTexture_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, 100663538);
		NativeMethodInfoPtr_CreateCharacterAndAddToCache_Private_Character_UInt32_Glyph_FontStyles_TextFontWeight_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, 100663539);
		NativeMethodInfoPtr_UpdateFontFeaturesForNewlyAddedGlyphs_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, 100663540);
		NativeMethodInfoPtr_UpdateGlyphAdjustmentRecordsForNewGlyphs_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, 100663541);
		NativeMethodInfoPtr_UpdateGPOSFontFeaturesForNewlyAddedGlyphs_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, 100663542);
		NativeMethodInfoPtr_ImportFontFeatures_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, 100663543);
		NativeMethodInfoPtr_UpdateGSUBFontFeaturesForNewGlyphIndex_Private_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, 100663544);
		NativeMethodInfoPtr_UpdateLigatureSubstitutionRecords_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, 100663545);
		NativeMethodInfoPtr_AddLigatureSubstitutionRecords_Private_Void_Il2CppReferenceArray_1_LigatureSubstitutionRecord_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, 100663546);
		NativeMethodInfoPtr_UpdateGlyphAdjustmentRecords_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, 100663547);
		NativeMethodInfoPtr_AddPairAdjustmentRecords_Private_Void_Il2CppStructArray_1_GlyphPairAdjustmentRecord_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, 100663548);
		NativeMethodInfoPtr_UpdateDiacriticalMarkAdjustmentRecords_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, 100663549);
		NativeMethodInfoPtr_AddMarkToBaseAdjustmentRecords_Private_Void_Il2CppStructArray_1_MarkToBaseAdjustmentRecord_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, 100663550);
		NativeMethodInfoPtr_AddMarkToMarkAdjustmentRecords_Private_Void_Il2CppStructArray_1_MarkToMarkAdjustmentRecord_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, 100663551);
		NativeMethodInfoPtr_get_nativeFontAsset_Internal_get_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, 100663552);
		NativeMethodInfoPtr_EnsureNativeFontAssetIsCreated_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, 100663553);
		NativeMethodInfoPtr_UpdateFallbacks_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, 100663554);
		NativeMethodInfoPtr_UpdateWeightFallbacks_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, 100663555);
		NativeMethodInfoPtr_UpdateFaceInfo_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, 100663556);
		NativeMethodInfoPtr_GetFallbacks_Internal_Il2CppStructArray_1_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, 100663557);
		NativeMethodInfoPtr_HasRecursion_Private_Boolean_FontAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, 100663558);
		NativeMethodInfoPtr_HasRecursionInternal_Private_Boolean_FontAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, 100663559);
		NativeMethodInfoPtr_GetWeightFallbacks_Private_ValueTuple_2_Il2CppStructArray_1_IntPtr_Il2CppStructArray_1_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, 100663560);
		NativeMethodInfoPtr_CreateHbFaceIfNeeded_Internal_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, 100663561);
		NativeMethodInfoPtr_UpdateFallbacks_Private_Static_Void_IntPtr_Il2CppStructArray_1_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, 100663562);
		NativeMethodInfoPtr_UpdateWeightFallbacks_Private_Static_Void_IntPtr_Il2CppStructArray_1_IntPtr_Il2CppStructArray_1_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, 100663563);
		NativeMethodInfoPtr_Create_Private_Static_IntPtr_FaceInfo_Font_Font_String_Int32_Il2CppStructArray_1_IntPtr_Il2CppStructArray_1_IntPtr_Il2CppStructArray_1_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, 100663564);
		NativeMethodInfoPtr_UpdateFaceInfo_Private_Static_Void_IntPtr_FaceInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, 100663565);
		NativeMethodInfoPtr_Destroy_Private_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, 100663566);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, 100663567);
		NativeMethodInfoPtr_UpdateFallbacks_Injected_Private_Static_Void_IntPtr_byref_ManagedSpanWrapper_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, 100663569);
		NativeMethodInfoPtr_UpdateWeightFallbacks_Injected_Private_Static_Void_IntPtr_byref_ManagedSpanWrapper_byref_ManagedSpanWrapper_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, 100663570);
		NativeMethodInfoPtr_Create_Injected_Private_Static_IntPtr_byref_FaceInfo_IntPtr_IntPtr_byref_ManagedSpanWrapper_Int32_byref_ManagedSpanWrapper_byref_ManagedSpanWrapper_byref_ManagedSpanWrapper_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, 100663571);
		NativeMethodInfoPtr_UpdateFaceInfo_Injected_Private_Static_Void_IntPtr_byref_FaceInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontAsset>.NativeClassPtr, 100663572);
	}

	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 1275307, RefRangeEnd = 1275314, XrefRangeStart = 1275304, XrefRangeEnd = 1275307, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void EnsureAdditionalCapacity<T>(List<T> container, int additionalCapacity)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)container);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &additionalCapacity;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_EnsureAdditionalCapacity_Private_Static_Void_List_1_T_Int32_0<T>.Pointer, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1275330, RefRangeEnd = 1275331, XrefRangeStart = 1275314, XrefRangeEnd = 1275330, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void EnsureAdditionalCapacity<TKey, TValue>(Dictionary<TKey, TValue> container, int additionalCapacity)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)container);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &additionalCapacity;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_EnsureAdditionalCapacity_Private_Static_Void_Dictionary_2_TKey_TValue_Int32_0<TKey, TValue>.Pointer, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1275478, RefRangeEnd = 1275479, XrefRangeStart = 1275443, XrefRangeEnd = 1275478, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static FontAsset CreateFontAsset(string familyName, string styleName, int pointSize = 90)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(familyName);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(styleName);
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &pointSize;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateFontAsset_Public_Static_FontAsset_String_String_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<FontAsset>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1275479, XrefRangeEnd = 1275484, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static FontAsset CreateFontAssetInternal(string familyName, string styleName, int pointSize = 90)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(familyName);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(styleName);
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &pointSize;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateFontAssetInternal_Internal_Static_FontAsset_String_String_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<FontAsset>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1275484, XrefRangeEnd = 1275493, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static FontAsset CreateFontAsset(string familyName, string styleName, int pointSize, int padding, GlyphRenderMode renderMode)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(familyName);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(styleName);
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &pointSize;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &padding;
		*(GlyphRenderMode**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &renderMode;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateFontAsset_Internal_Static_FontAsset_String_String_Int32_Int32_GlyphRenderMode_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<FontAsset>(intPtr2) : null;
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1275511, RefRangeEnd = 1275514, XrefRangeStart = 1275493, XrefRangeEnd = 1275511, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static List<FontAsset> CreateFontAssetOSFallbackList(Il2CppStringArray fallbacksFamilyNames, int pointSize = 90)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)fallbacksFamilyNames);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &pointSize;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateFontAssetOSFallbackList_Internal_Static_List_1_FontAsset_Il2CppStringArray_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<FontAsset>>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1275514, XrefRangeEnd = 1275536, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static FontAsset CreateFontAssetWithOSFallbackList(Il2CppStringArray fallbacksFamilyNames, int pointSize = 90)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)fallbacksFamilyNames);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &pointSize;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateFontAssetWithOSFallbackList_Internal_Static_FontAsset_Il2CppStringArray_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<FontAsset>(intPtr2) : null;
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 1275553, RefRangeEnd = 1275557, XrefRangeStart = 1275536, XrefRangeEnd = 1275553, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static FontAsset CreateFontAssetFromFamilyName(string familyName, int pointSize = 90)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(familyName);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &pointSize;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateFontAssetFromFamilyName_Private_Static_FontAsset_String_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<FontAsset>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1275557, XrefRangeEnd = 1275561, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static FontAsset CreateFontAsset(string fontFilePath, int faceIndex, int samplingPointSize, int atlasPadding, GlyphRenderMode renderMode, int atlasWidth, int atlasHeight)
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
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateFontAsset_Public_Static_FontAsset_String_Int32_Int32_Int32_GlyphRenderMode_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<FontAsset>(intPtr2) : null;
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 1275584, RefRangeEnd = 1275588, XrefRangeStart = 1275561, XrefRangeEnd = 1275584, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static FontAsset CreateFontAsset(string fontFilePath, int faceIndex, int samplingPointSize, int atlasPadding, GlyphRenderMode renderMode, int atlasWidth, int atlasHeight, AtlasPopulationMode atlasPopulationMode, bool enableMultiAtlasSupport = true)
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
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateFontAsset_Private_Static_FontAsset_String_Int32_Int32_Int32_GlyphRenderMode_Int32_Int32_AtlasPopulationMode_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<FontAsset>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1275588, XrefRangeEnd = 1275595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static FontAsset CreateFontAsset(Font font)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)font);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateFontAsset_Public_Static_FontAsset_Font_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<FontAsset>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1275595, XrefRangeEnd = 1275599, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static FontAsset CreateFontAsset(Font font, int samplingPointSize, int atlasPadding, GlyphRenderMode renderMode, int atlasWidth, int atlasHeight, AtlasPopulationMode atlasPopulationMode = AtlasPopulationMode.Dynamic, bool enableMultiAtlasSupport = true)
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
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateFontAsset_Public_Static_FontAsset_Font_Int32_Int32_GlyphRenderMode_Int32_Int32_AtlasPopulationMode_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<FontAsset>(intPtr2) : null;
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1275685, RefRangeEnd = 1275688, XrefRangeStart = 1275599, XrefRangeEnd = 1275685, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static FontAsset CreateFontAsset(Font font, int faceIndex, int samplingPointSize, int atlasPadding, GlyphRenderMode renderMode, int atlasWidth, int atlasHeight, AtlasPopulationMode atlasPopulationMode = AtlasPopulationMode.Dynamic, bool enableMultiAtlasSupport = true)
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
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateFontAsset_Private_Static_FontAsset_Font_Int32_Int32_Int32_GlyphRenderMode_Int32_Int32_AtlasPopulationMode_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<FontAsset>(intPtr2) : null;
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1275793, RefRangeEnd = 1275796, XrefRangeStart = 1275688, XrefRangeEnd = 1275793, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static FontAsset CreateFontAssetInstance(Font font, int atlasPadding, GlyphRenderMode renderMode, int atlasWidth, int atlasHeight, AtlasPopulationMode atlasPopulationMode, bool enableMultiAtlasSupport)
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
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateFontAssetInstance_Private_Static_FontAsset_Font_Int32_GlyphRenderMode_Int32_Int32_AtlasPopulationMode_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<FontAsset>(intPtr2) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1275804, RefRangeEnd = 1275805, XrefRangeStart = 1275796, XrefRangeEnd = 1275804, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static FontAsset GetFontAssetByID(int id)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&id);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetFontAssetByID_Internal_Static_FontAsset_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<FontAsset>(intPtr2) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1275845, RefRangeEnd = 1275846, XrefRangeStart = 1275805, XrefRangeEnd = 1275845, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RegisterCallbackInstance(FontAsset instance)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)instance);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RegisterCallbackInstance_Private_Void_FontAsset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1275846, XrefRangeEnd = 1275876, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnDestroy()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(26)]
	[CachedScanResults(RefRangeStart = 1275979, RefRangeEnd = 1276005, XrefRangeStart = 1275876, XrefRangeEnd = 1275979, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ReadFontAssetDefinition()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ReadFontAssetDefinition_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1276005, XrefRangeEnd = 1276029, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void InitializeDictionaryLookupTables()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InitializeDictionaryLookupTables_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1276040, RefRangeEnd = 1276041, XrefRangeStart = 1276029, XrefRangeEnd = 1276040, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void InitializeLookup<T>(ICollection source, ref Dictionary<uint, T> lookup, int defaultCapacity = 16)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)source);
		byte* num = (byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)));
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)lookup);
		*(System.IntPtr**)num = &intPtr;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &defaultCapacity;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_InitializeLookup_Private_Static_Void_ICollection_byref_Dictionary_2_UInt32_T_Int32_0<T>.Pointer, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		System.IntPtr intPtr4 = intPtr;
		lookup = ((intPtr4 == (System.IntPtr)0) ? null : new Dictionary<uint, T>(intPtr4));
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1276051, RefRangeEnd = 1276053, XrefRangeStart = 1276041, XrefRangeEnd = 1276051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void InitializeList<T>(ICollection source, ref List<T> list, int defaultCapacity = 16)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)source);
		byte* num = (byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)));
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list);
		*(System.IntPtr**)num = &intPtr;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &defaultCapacity;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_InitializeList_Private_Static_Void_ICollection_byref_List_1_T_Int32_0<T>.Pointer, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		System.IntPtr intPtr4 = intPtr;
		list = ((intPtr4 == (System.IntPtr)0) ? null : new List<T>(intPtr4));
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1276085, RefRangeEnd = 1276087, XrefRangeStart = 1276053, XrefRangeEnd = 1276085, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void InitializeGlyphLookupDictionary()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InitializeGlyphLookupDictionary_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1276120, RefRangeEnd = 1276122, XrefRangeStart = 1276087, XrefRangeEnd = 1276120, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void InitializeCharacterLookupDictionary()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InitializeCharacterLookupDictionary_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1276169, RefRangeEnd = 1276170, XrefRangeStart = 1276122, XrefRangeEnd = 1276169, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ClearFallbackCharacterTable()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ClearFallbackCharacterTable_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1276212, RefRangeEnd = 1276214, XrefRangeStart = 1276170, XrefRangeEnd = 1276212, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void InitializeLigatureSubstitutionLookupDictionary()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InitializeLigatureSubstitutionLookupDictionary_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1276241, RefRangeEnd = 1276243, XrefRangeStart = 1276214, XrefRangeEnd = 1276241, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void InitializeGlyphPairAdjustmentRecordsLookupDictionary()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InitializeGlyphPairAdjustmentRecordsLookupDictionary_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1276268, RefRangeEnd = 1276270, XrefRangeStart = 1276243, XrefRangeEnd = 1276268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void InitializeMarkToBaseAdjustmentRecordsLookupDictionary()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InitializeMarkToBaseAdjustmentRecordsLookupDictionary_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1276295, RefRangeEnd = 1276297, XrefRangeStart = 1276270, XrefRangeEnd = 1276295, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void InitializeMarkToMarkAdjustmentRecordsLookupDictionary()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InitializeMarkToMarkAdjustmentRecordsLookupDictionary_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1276320, RefRangeEnd = 1276321, XrefRangeStart = 1276297, XrefRangeEnd = 1276320, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddSynthesizedCharactersAndFaceMetrics()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddSynthesizedCharactersAndFaceMetrics_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(12)]
	[CachedScanResults(RefRangeStart = 1276376, RefRangeEnd = 1276388, XrefRangeStart = 1276321, XrefRangeEnd = 1276376, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1276388, XrefRangeEnd = 1276393, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddCharacterToLookupCache(uint unicode, Character character)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&unicode);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)character);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddCharacterToLookupCache_Internal_Void_UInt32_Character_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 1276399, RefRangeEnd = 1276404, XrefRangeStart = 1276393, XrefRangeEnd = 1276399, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddCharacterToLookupCache(uint unicode, Character character, FontStyles fontStyle, TextFontWeight fontWeight)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&unicode);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)character);
		*(FontStyles**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &fontStyle;
		*(TextFontWeight**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &fontWeight;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddCharacterToLookupCache_Internal_Void_UInt32_Character_FontStyles_TextFontWeight_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1276410, RefRangeEnd = 1276412, XrefRangeStart = 1276404, XrefRangeEnd = 1276410, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool GetCharacterInLookupCache(uint unicode, FontStyles fontStyle, TextFontWeight fontWeight, out Character character)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&unicode);
		*(FontStyles**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &fontStyle;
		*(TextFontWeight**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &fontWeight;
		byte* num = (byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)));
		nint num2 = 0;
		*(nint**)num = &num2;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetCharacterInLookupCache_Internal_Boolean_UInt32_FontStyles_TextFontWeight_byref_Character_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		nint num3 = num2;
		character = ((num3 == 0) ? null : new Character(num3));
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 1276418, RefRangeEnd = 1276422, XrefRangeStart = 1276412, XrefRangeEnd = 1276418, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RemoveCharacterInLookupCache(uint unicode, FontStyles fontStyle, TextFontWeight fontWeight)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&unicode);
		*(FontStyles**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &fontStyle;
		*(TextFontWeight**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &fontWeight;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RemoveCharacterInLookupCache_Internal_Void_UInt32_FontStyles_TextFontWeight_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1276422, XrefRangeEnd = 1276428, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool ContainsCharacterInLookupCache(uint unicode, FontStyles fontStyle, TextFontWeight fontWeight)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&unicode);
		*(FontStyles**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &fontStyle;
		*(TextFontWeight**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &fontWeight;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ContainsCharacterInLookupCache_Internal_Boolean_UInt32_FontStyles_TextFontWeight_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe uint CreateCompositeKey(uint unicode, FontStyles fontStyle = FontStyles.Normal, TextFontWeight fontWeight = TextFontWeight.Regular)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&unicode);
		*(FontStyles**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &fontStyle;
		*(TextFontWeight**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &fontWeight;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateCompositeKey_Private_UInt32_UInt32_FontStyles_TextFontWeight_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(uint*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(11)]
	[CachedScanResults(RefRangeStart = 1276449, RefRangeEnd = 1276460, XrefRangeStart = 1276428, XrefRangeEnd = 1276449, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1276460, XrefRangeEnd = 1276483, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SortCharacterTable()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SortCharacterTable_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1276483, XrefRangeEnd = 1276506, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SortGlyphTable()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SortGlyphTable_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1276506, XrefRangeEnd = 1276510, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SortFontFeatureTable()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SortFontFeatureTable_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1276510, XrefRangeEnd = 1276560, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SortAllTables()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SortAllTables_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1276560, XrefRangeEnd = 1276564, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1276564, XrefRangeEnd = 1276565, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1276617, RefRangeEnd = 1276618, XrefRangeStart = 1276565, XrefRangeEnd = 1276617, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool HasCharacter(uint character, bool searchFallbacks = false, bool tryAddCharacter = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&character);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &searchFallbacks;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &tryAddCharacter;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_HasCharacter_Public_Boolean_UInt32_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1276618, XrefRangeEnd = 1276619, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool HasCharacterWithStyle_Internal(uint character, FontStyles fontStyle, TextFontWeight fontWeight, bool searchFallbacks = false, bool tryAddCharacter = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = (nint)(&character);
		*(FontStyles**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &fontStyle;
		*(TextFontWeight**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &fontWeight;
		*(bool**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &searchFallbacks;
		*(bool**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &tryAddCharacter;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_HasCharacterWithStyle_Internal_Private_Boolean_UInt32_FontStyles_TextFontWeight_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 1276647, RefRangeEnd = 1276651, XrefRangeStart = 1276619, XrefRangeEnd = 1276647, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool HasCharacter_Internal(uint character, FontStyles fontStyle = FontStyles.Normal, TextFontWeight fontWeight = TextFontWeight.Regular, bool searchFallbacks = false, bool tryAddCharacter = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = (nint)(&character);
		*(FontStyles**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &fontStyle;
		*(TextFontWeight**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &fontWeight;
		*(bool**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &searchFallbacks;
		*(bool**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &tryAddCharacter;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_HasCharacter_Internal_Private_Boolean_UInt32_FontStyles_TextFontWeight_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1276651, XrefRangeEnd = 1276681, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1276681, XrefRangeEnd = 1276758, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1276758, XrefRangeEnd = 1276764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1276764, XrefRangeEnd = 1276775, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string GetCharacters(FontAsset fontAsset)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)fontAsset);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetCharacters_Public_Static_String_FontAsset_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1276775, XrefRangeEnd = 1276784, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppStructArray<int> GetCharactersArray(FontAsset fontAsset)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)fontAsset);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetCharactersArray_Public_Static_Il2CppStructArray_1_Int32_FontAsset_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1276784, XrefRangeEnd = 1276797, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	[CachedScanResults(RefRangeStart = 1276811, RefRangeEnd = 1276813, XrefRangeStart = 1276797, XrefRangeEnd = 1276811, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe uint GetGlyphIndex(uint unicode, out bool success)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&unicode);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref success);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetGlyphIndex_Internal_UInt32_UInt32_byref_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(uint*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1276818, RefRangeEnd = 1276820, XrefRangeStart = 1276813, XrefRangeEnd = 1276818, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1276820, XrefRangeEnd = 1276834, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdateFontAssetData()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdateFontAssetData_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1276834, XrefRangeEnd = 1276868, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1276868, XrefRangeEnd = 1276871, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ClearCharacterAndGlyphTablesInternal()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ClearCharacterAndGlyphTablesInternal_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1276882, RefRangeEnd = 1276885, XrefRangeStart = 1276871, XrefRangeEnd = 1276882, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ClearCharacterAndGlyphTables()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ClearCharacterAndGlyphTables_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1276890, RefRangeEnd = 1276892, XrefRangeStart = 1276885, XrefRangeEnd = 1276890, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ClearFontFeaturesTables()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ClearFontFeaturesTables_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1276911, RefRangeEnd = 1276914, XrefRangeStart = 1276892, XrefRangeEnd = 1276911, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1276914, XrefRangeEnd = 1276924, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void DestroyAtlasTextures()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DestroyAtlasTextures_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1276924, XrefRangeEnd = 1276938, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void RegisterFontAssetForFontFeatureUpdate(FontAsset fontAsset)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)fontAsset);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RegisterFontAssetForFontFeatureUpdate_Internal_Static_Void_FontAsset_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1276938, XrefRangeEnd = 1276952, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void RegisterFontAssetForKerningUpdate(FontAsset fontAsset)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)fontAsset);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RegisterFontAssetForKerningUpdate_Internal_Static_Void_FontAsset_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1276994, RefRangeEnd = 1276995, XrefRangeStart = 1276952, XrefRangeEnd = 1276994, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void UpdateFontFeaturesForFontAssetsInQueue()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdateFontFeaturesForFontAssetsInQueue_Internal_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1276995, XrefRangeEnd = 1277009, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void RegisterAtlasTextureForApply(Texture2D texture)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)texture);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RegisterAtlasTextureForApply_Internal_Static_Void_Texture2D_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1277009, XrefRangeEnd = 1277031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void UpdateAtlasTexturesInQueue()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdateAtlasTexturesInQueue_Internal_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1277057, RefRangeEnd = 1277060, XrefRangeStart = 1277031, XrefRangeEnd = 1277057, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void UpdateFontAssetsInUpdateQueue()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdateFontAssetsInUpdateQueue_Internal_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1277060, XrefRangeEnd = 1277061, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1277273, RefRangeEnd = 1277276, XrefRangeStart = 1277061, XrefRangeEnd = 1277273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1277276, XrefRangeEnd = 1277277, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	[CachedScanResults(RefRangeStart = 1277291, RefRangeEnd = 1277292, XrefRangeStart = 1277277, XrefRangeEnd = 1277291, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1277298, RefRangeEnd = 1277300, XrefRangeStart = 1277292, XrefRangeEnd = 1277298, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool TryAddGlyphVariantIndexInternal(uint unicode, uint nextCharacter, uint variantGlyphIndex)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&unicode);
		*(uint**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &nextCharacter;
		*(uint**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &variantGlyphIndex;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TryAddGlyphVariantIndexInternal_Internal_Boolean_UInt32_UInt32_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1277306, RefRangeEnd = 1277308, XrefRangeStart = 1277300, XrefRangeEnd = 1277306, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool TryGetGlyphVariantIndexInternal(uint unicode, uint nextCharacter, out uint variantGlyphIndex)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&unicode);
		*(uint**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &nextCharacter;
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref variantGlyphIndex);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TryGetGlyphVariantIndexInternal_Internal_Boolean_UInt32_UInt32_byref_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 1277327, RefRangeEnd = 1277332, XrefRangeStart = 1277308, XrefRangeEnd = 1277327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1277332, XrefRangeEnd = 1277333, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool TryAddCharacterInternal(uint unicode, out Character character)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&unicode);
		byte* num = (byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)));
		nint num2 = 0;
		*(nint**)num = &num2;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TryAddCharacterInternal_Internal_Boolean_UInt32_byref_Character_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		nint num3 = num2;
		character = ((num3 == 0) ? null : new Character(num3));
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 1277382, RefRangeEnd = 1277388, XrefRangeStart = 1277333, XrefRangeEnd = 1277382, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool TryAddCharacterInternal(uint unicode, FontStyles fontStyle, TextFontWeight fontWeight, out Character character, bool populateLigatures = true)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = (nint)(&unicode);
		*(FontStyles**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &fontStyle;
		*(TextFontWeight**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &fontWeight;
		byte* num = (byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)));
		nint num2 = 0;
		*(nint**)num = &num2;
		*(bool**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &populateLigatures;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TryAddCharacterInternal_Internal_Boolean_UInt32_FontStyles_TextFontWeight_byref_Character_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		nint num3 = num2;
		character = ((num3 == 0) ? null : new Character(num3));
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1277409, RefRangeEnd = 1277411, XrefRangeStart = 1277388, XrefRangeEnd = 1277409, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool TryAddGlyphToAtlas(uint glyphIndex, out Glyph glyph, bool populateLigatures = true)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&glyphIndex);
		byte* num = (byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)));
		nint num2 = 0;
		*(nint**)num = &num2;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &populateLigatures;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TryAddGlyphToAtlas_Private_Boolean_UInt32_byref_Glyph_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		nint num3 = num2;
		glyph = ((num3 == 0) ? null : new Glyph(num3));
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1277419, RefRangeEnd = 1277421, XrefRangeStart = 1277411, XrefRangeEnd = 1277419, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool TryAddGlyphToTexture(uint glyphIndex, out Glyph glyph, bool populateLigatures = true)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&glyphIndex);
		byte* num = (byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)));
		nint num2 = 0;
		*(nint**)num = &num2;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &populateLigatures;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TryAddGlyphToTexture_Private_Boolean_UInt32_byref_Glyph_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		nint num3 = num2;
		glyph = ((num3 == 0) ? null : new Glyph(num3));
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1277470, RefRangeEnd = 1277471, XrefRangeStart = 1277421, XrefRangeEnd = 1277470, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	[CachedScanResults(RefRangeStart = 1277491, RefRangeEnd = 1277493, XrefRangeStart = 1277471, XrefRangeEnd = 1277491, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetupNewAtlasTexture()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetupNewAtlasTexture_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1277514, RefRangeEnd = 1277516, XrefRangeStart = 1277493, XrefRangeEnd = 1277514, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Character CreateCharacterAndAddToCache(uint unicode, Glyph glyph, FontStyles fontStyle, TextFontWeight fontWeight)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&unicode);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)glyph);
		*(FontStyles**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &fontStyle;
		*(TextFontWeight**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &fontWeight;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateCharacterAndAddToCache_Private_Character_UInt32_Glyph_FontStyles_TextFontWeight_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Character>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1277516, XrefRangeEnd = 1277524, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdateFontFeaturesForNewlyAddedGlyphs()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdateFontFeaturesForNewlyAddedGlyphs_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1277524, XrefRangeEnd = 1277526, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdateGlyphAdjustmentRecordsForNewGlyphs()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdateGlyphAdjustmentRecordsForNewGlyphs_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1277526, XrefRangeEnd = 1277529, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdateGPOSFontFeaturesForNewlyAddedGlyphs()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdateGPOSFontFeaturesForNewlyAddedGlyphs_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1277529, XrefRangeEnd = 1277547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ImportFontFeatures()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ImportFontFeatures_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1277547, XrefRangeEnd = 1277552, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1277552, XrefRangeEnd = 1277557, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdateLigatureSubstitutionRecords()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdateLigatureSubstitutionRecords_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 1277615, RefRangeEnd = 1277622, XrefRangeStart = 1277557, XrefRangeEnd = 1277615, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddLigatureSubstitutionRecords(Il2CppReferenceArray<LigatureSubstitutionRecord> records)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)records);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddLigatureSubstitutionRecords_Private_Void_Il2CppReferenceArray_1_LigatureSubstitutionRecord_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 1277628, RefRangeEnd = 1277634, XrefRangeStart = 1277622, XrefRangeEnd = 1277628, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdateGlyphAdjustmentRecords()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdateGlyphAdjustmentRecords_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 1277661, RefRangeEnd = 1277665, XrefRangeStart = 1277634, XrefRangeEnd = 1277661, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddPairAdjustmentRecords(Il2CppStructArray<GlyphPairAdjustmentRecord> records)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)records);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddPairAdjustmentRecords_Private_Void_Il2CppStructArray_1_GlyphPairAdjustmentRecord_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 1277682, RefRangeEnd = 1277686, XrefRangeStart = 1277665, XrefRangeEnd = 1277682, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdateDiacriticalMarkAdjustmentRecords()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdateDiacriticalMarkAdjustmentRecords_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 1277720, RefRangeEnd = 1277724, XrefRangeStart = 1277686, XrefRangeEnd = 1277720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddMarkToBaseAdjustmentRecords(Il2CppStructArray<MarkToBaseAdjustmentRecord> records)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)records);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddMarkToBaseAdjustmentRecords_Private_Void_Il2CppStructArray_1_MarkToBaseAdjustmentRecord_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 1277758, RefRangeEnd = 1277762, XrefRangeStart = 1277724, XrefRangeEnd = 1277758, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddMarkToMarkAdjustmentRecords(Il2CppStructArray<MarkToMarkAdjustmentRecord> records)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)records);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddMarkToMarkAdjustmentRecords_Private_Void_Il2CppStructArray_1_MarkToMarkAdjustmentRecord_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 1277792, RefRangeEnd = 1277796, XrefRangeStart = 1277780, XrefRangeEnd = 1277792, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void EnsureNativeFontAssetIsCreated()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_EnsureNativeFontAssetIsCreated_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1277796, XrefRangeEnd = 1277813, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdateFallbacks()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdateFallbacks_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1277813, XrefRangeEnd = 1277834, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdateWeightFallbacks()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdateWeightFallbacks_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1277834, XrefRangeEnd = 1277843, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdateFaceInfo()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdateFaceInfo_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1277895, RefRangeEnd = 1277898, XrefRangeStart = 1277843, XrefRangeEnd = 1277895, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Il2CppStructArray<System.IntPtr> GetFallbacks()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetFallbacks_Internal_Il2CppStructArray_1_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<System.IntPtr>>(intPtr2) : null;
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1277907, RefRangeEnd = 1277910, XrefRangeStart = 1277898, XrefRangeEnd = 1277907, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool HasRecursion(FontAsset fontAsset)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)fontAsset);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_HasRecursion_Private_Boolean_FontAsset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 1277960, RefRangeEnd = 1277964, XrefRangeStart = 1277910, XrefRangeEnd = 1277960, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool HasRecursionInternal(FontAsset fontAsset)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)fontAsset);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_HasRecursionInternal_Private_Boolean_FontAsset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1278002, RefRangeEnd = 1278005, XrefRangeStart = 1277964, XrefRangeEnd = 1278002, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Il2CppSystem.ValueTuple<Il2CppStructArray<System.IntPtr>, Il2CppStructArray<System.IntPtr>> GetWeightFallbacks()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetWeightFallbacks_Private_ValueTuple_2_Il2CppStructArray_1_IntPtr_Il2CppStructArray_1_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return new Il2CppSystem.ValueTuple<Il2CppStructArray<System.IntPtr>, Il2CppStructArray<System.IntPtr>>(pointer);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1278007, RefRangeEnd = 1278008, XrefRangeStart = 1278005, XrefRangeEnd = 1278007, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void CreateHbFaceIfNeeded()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateHbFaceIfNeeded_Internal_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1278008, XrefRangeEnd = 1278020, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void UpdateFallbacks(System.IntPtr ptr, Il2CppStructArray<System.IntPtr> fallbacks)
	{
		System.IntPtr* ptr2 = stackalloc System.IntPtr[2];
		*ptr2 = (nint)(&ptr);
		*(System.IntPtr*)((byte*)ptr2 + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)fallbacks);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdateFallbacks_Private_Static_Void_IntPtr_Il2CppStructArray_1_IntPtr_0, (System.IntPtr)0, (void**)ptr2, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1278020, XrefRangeEnd = 1278036, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void UpdateWeightFallbacks(System.IntPtr ptr, Il2CppStructArray<System.IntPtr> regularFallbacks, Il2CppStructArray<System.IntPtr> italicFallbacks)
	{
		System.IntPtr* ptr2 = stackalloc System.IntPtr[3];
		*ptr2 = (nint)(&ptr);
		*(System.IntPtr*)((byte*)ptr2 + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)regularFallbacks);
		*(System.IntPtr*)((byte*)ptr2 + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)italicFallbacks);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdateWeightFallbacks_Private_Static_Void_IntPtr_Il2CppStructArray_1_IntPtr_Il2CppStructArray_1_IntPtr_0, (System.IntPtr)0, (void**)ptr2, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1278072, RefRangeEnd = 1278074, XrefRangeStart = 1278036, XrefRangeEnd = 1278072, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static System.IntPtr Create(FaceInfo faceInfo, Font sourceFontFile, Font sourceFont_EditorRef, string sourceFontFilePath, int fontInstanceID, Il2CppStructArray<System.IntPtr> fallbacks, Il2CppStructArray<System.IntPtr> weightFallbacks, Il2CppStructArray<System.IntPtr> italicFallbacks)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[8];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)faceInfo));
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)sourceFontFile);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)sourceFont_EditorRef);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(sourceFontFilePath);
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &fontInstanceID;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)fallbacks);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)weightFallbacks);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)7u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)italicFallbacks);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Create_Private_Static_IntPtr_FaceInfo_Font_Font_String_Int32_Il2CppStructArray_1_IntPtr_Il2CppStructArray_1_IntPtr_Il2CppStructArray_1_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(System.IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1278074, XrefRangeEnd = 1278079, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void UpdateFaceInfo(System.IntPtr ptr, FaceInfo faceInfo)
	{
		System.IntPtr* ptr2 = stackalloc System.IntPtr[2];
		*ptr2 = (nint)(&ptr);
		*(System.IntPtr*)((byte*)ptr2 + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)faceInfo));
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdateFaceInfo_Private_Static_Void_IntPtr_FaceInfo_0, (System.IntPtr)0, (void**)ptr2, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1278079, XrefRangeEnd = 1278081, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Destroy(System.IntPtr ptr)
	{
		System.IntPtr* ptr2 = stackalloc System.IntPtr[1];
		*ptr2 = (nint)(&ptr);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Destroy_Private_Static_Void_IntPtr_0, (System.IntPtr)0, (void**)ptr2, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1278081, XrefRangeEnd = 1278166, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe FontAsset()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FontAsset>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1278166, XrefRangeEnd = 1278168, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void UpdateFallbacks_Injected(System.IntPtr ptr, ref ManagedSpanWrapper fallbacks)
	{
		System.IntPtr* ptr2 = stackalloc System.IntPtr[2];
		*ptr2 = (nint)(&ptr);
		*(void**)((byte*)ptr2 + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref fallbacks);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdateFallbacks_Injected_Private_Static_Void_IntPtr_byref_ManagedSpanWrapper_0, (System.IntPtr)0, (void**)ptr2, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1278168, XrefRangeEnd = 1278170, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void UpdateWeightFallbacks_Injected(System.IntPtr ptr, ref ManagedSpanWrapper regularFallbacks, ref ManagedSpanWrapper italicFallbacks)
	{
		System.IntPtr* ptr2 = stackalloc System.IntPtr[3];
		*ptr2 = (nint)(&ptr);
		*(void**)((byte*)ptr2 + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref regularFallbacks);
		*(void**)((byte*)ptr2 + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref italicFallbacks);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdateWeightFallbacks_Injected_Private_Static_Void_IntPtr_byref_ManagedSpanWrapper_byref_ManagedSpanWrapper_0, (System.IntPtr)0, (void**)ptr2, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1278170, XrefRangeEnd = 1278172, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static System.IntPtr Create_Injected([In] ref FaceInfo faceInfo, System.IntPtr sourceFontFile, System.IntPtr sourceFont_EditorRef, ref ManagedSpanWrapper sourceFontFilePath, int fontInstanceID, ref ManagedSpanWrapper fallbacks, ref ManagedSpanWrapper weightFallbacks, ref ManagedSpanWrapper italicFallbacks)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[8];
		*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)faceInfo);
		*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &sourceFontFile;
		*(System.IntPtr**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &sourceFont_EditorRef;
		*(void**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref sourceFontFilePath);
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &fontInstanceID;
		*(void**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref fallbacks);
		*(void**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref weightFallbacks);
		*(void**)((byte*)ptr + checked((nuint)7u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref italicFallbacks);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Create_Injected_Private_Static_IntPtr_byref_FaceInfo_IntPtr_IntPtr_byref_ManagedSpanWrapper_Int32_byref_ManagedSpanWrapper_byref_ManagedSpanWrapper_byref_ManagedSpanWrapper_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(System.IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1278172, XrefRangeEnd = 1278174, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void UpdateFaceInfo_Injected(System.IntPtr ptr, [In] ref FaceInfo faceInfo)
	{
		System.IntPtr* ptr2 = stackalloc System.IntPtr[2];
		*ptr2 = (nint)(&ptr);
		*(System.IntPtr*)((byte*)ptr2 + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)faceInfo);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdateFaceInfo_Injected_Private_Static_Void_IntPtr_byref_FaceInfo_0, (System.IntPtr)0, (void**)ptr2, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public FontAsset(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
