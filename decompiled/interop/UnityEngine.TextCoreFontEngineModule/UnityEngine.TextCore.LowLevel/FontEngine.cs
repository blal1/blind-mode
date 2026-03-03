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
using Il2CppSystem.Reflection;
using UnityEngine.Bindings;

namespace UnityEngine.TextCore.LowLevel;

public sealed class FontEngine : Il2CppSystem.Object
{
	private sealed class MethodInfoStoreGeneric_GenericListToMarshallingArray_Private_Static_Void_byref_List_1_T_byref_Il2CppArrayBase_1_T_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_GenericListToMarshallingArray_Private_Static_Void_byref_List_1_T_byref_Il2CppArrayBase_1_T_0, Il2CppClassPointerStore<FontEngine>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private sealed class MethodInfoStoreGeneric_SetMarshallingArraySize_Private_Static_Void_byref_Il2CppArrayBase_1_T_Int32_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_SetMarshallingArraySize_Private_Static_Void_byref_Il2CppArrayBase_1_T_Int32_0, Il2CppClassPointerStore<FontEngine>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private delegate int InitializeFontEngine_InternalDelegate();

	private delegate int DestroyFontEngine_InternalDelegate();

	private delegate void SendCancellationRequest_InternalDelegate();

	private delegate bool get_isProcessingDoneDelegate();

	private delegate float get_generationProgressDelegate();

	private delegate int UnloadAllFontFaces_InternalDelegate();

	private delegate System.IntPtr GetSystemFontNames_InternalDelegate();

	private delegate System.IntPtr GetSystemFontReferencesDelegate();

	private delegate int SetFaceSize_InternalDelegate(int pointSize);

	private delegate int GetFaceCountDelegate();

	private delegate bool TryGetGlyphIndexDelegate(uint unicode, [Out] System.IntPtr glyphIndex);

	private delegate void ReleaseSharedTextureDelegate();

	private delegate System.IntPtr GetAllMultipleSubstitutionRecordsDelegate();

	private delegate int GetMultipleSubstitutionRecordsFromMarshallingArrayDelegate([Out] System.IntPtr substitutionRecords);

	private delegate int PopulatePairAdjustmentRecordMarshallingArray_from_GlyphIndexDelegate(uint glyphIndex, [Out] System.IntPtr recordCount);

	private delegate int LoadFontFace_With_Size_Internal_InjectedDelegate(System.IntPtr filePath, int pointSize);

	private delegate int LoadFontFace_FromSourceFontFile_Internal_InjectedDelegate(System.IntPtr sourceFontFile);

	private delegate int LoadFontFace_With_Size_FromSourceFontFile_Internal_InjectedDelegate(System.IntPtr sourceFontFile, int pointSize);

	private delegate int LoadFontFace_With_Size_And_FaceIndex_FromSourceFontFile_Internal_InjectedDelegate(System.IntPtr sourceFontFile, int pointSize, int faceIndex);

	private delegate int LoadFontFace_FromFont_Internal_InjectedDelegate(System.IntPtr font);

	private delegate int LoadFontFace_With_Size_FromFont_Internal_InjectedDelegate(System.IntPtr font, int pointSize);

	private delegate int LoadFontFace_by_FamilyName_and_StyleName_Internal_InjectedDelegate(System.IntPtr familyName, System.IntPtr styleName);

	private delegate bool TryPackGlyphInAtlas_Internal_InjectedDelegate(System.IntPtr glyph, int padding, GlyphPackingMode packingMode, GlyphRenderMode renderMode, int width, int height, [Out] System.IntPtr freeGlyphRects, System.IntPtr freeGlyphRectCount, [Out] System.IntPtr usedGlyphRects, System.IntPtr usedGlyphRectCount);

	private delegate bool TryPackGlyphsInAtlas_Internal_InjectedDelegate([Out] System.IntPtr glyphsToAdd, System.IntPtr glyphsToAddCount, [Out] System.IntPtr glyphsAdded, System.IntPtr glyphsAddedCount, int padding, GlyphPackingMode packingMode, GlyphRenderMode renderMode, int width, int height, [Out] System.IntPtr freeGlyphRects, System.IntPtr freeGlyphRectCount, [Out] System.IntPtr usedGlyphRects, System.IntPtr usedGlyphRectCount);

	private delegate int RenderGlyphToTexture_Internal_InjectedDelegate([In] System.IntPtr glyphStruct, int padding, GlyphRenderMode renderMode, System.IntPtr texture);

	private delegate int RenderGlyphsToTexture_Internal_InjectedDelegate(System.IntPtr glyphs, int glyphCount, int padding, GlyphRenderMode renderMode, System.IntPtr texture);

	private delegate int RenderGlyphsToTextureBuffer_Internal_InjectedDelegate(System.IntPtr glyphs, int glyphCount, int padding, GlyphRenderMode renderMode, [Out] System.IntPtr texBuffer, int texWidth, int texHeight);

	private delegate int RenderGlyphsToSharedTexture_Internal_InjectedDelegate(System.IntPtr glyphs, int glyphCount, int padding, GlyphRenderMode renderMode);

	private delegate void SetSharedTexture_InjectedDelegate(System.IntPtr texture);

	private delegate bool TryAddGlyphsToTexture_Internal_MultiThread_InjectedDelegate([Out] System.IntPtr glyphsToAdd, System.IntPtr glyphsToAddCount, [Out] System.IntPtr glyphsAdded, System.IntPtr glyphsAddedCount, int padding, GlyphPackingMode packingMode, [Out] System.IntPtr freeGlyphRects, System.IntPtr freeGlyphRectCount, [Out] System.IntPtr usedGlyphRects, System.IntPtr usedGlyphRectCount, GlyphRenderMode renderMode, System.IntPtr texture);

	private delegate void GetOpenTypeLayoutLookups_InjectedDelegate([Out] System.IntPtr ret);

	private delegate void GetAllSingleSubstitutionRecords_InjectedDelegate([Out] System.IntPtr ret);

	private delegate int PopulateSingleSubstitutionRecordMarshallingArray_from_GlyphIndexes_InjectedDelegate(System.IntPtr glyphIndexes, int lookupIndex, [Out] System.IntPtr recordCount);

	private delegate int GetSingleSubstitutionRecordsFromMarshallingArray_InjectedDelegate(System.IntPtr singleSubstitutionRecords);

	private delegate int PopulateMultipleSubstitutionRecordMarshallingArray_from_GlyphIndexes_InjectedDelegate(System.IntPtr glyphIndexes, int lookupIndex, [Out] System.IntPtr recordCount);

	private delegate int PopulateAlternateSubstitutionRecordMarshallingArray_from_GlyphIndexes_InjectedDelegate(System.IntPtr glyphIndexes, int lookupIndex, [Out] System.IntPtr recordCount);

	private delegate int PopulateLigatureSubstitutionRecordMarshallingArray_for_LookupIndex_InjectedDelegate(System.IntPtr glyphIndexes, int lookupIndex, [Out] System.IntPtr recordCount);

	private delegate int PopulateContextualSubstitutionRecordMarshallingArray_from_GlyphIndexes_InjectedDelegate(System.IntPtr glyphIndexes, int lookupIndex, [Out] System.IntPtr recordCount);

	private delegate int PopulateChainingContextualSubstitutionRecordMarshallingArray_from_GlyphIndexes_InjectedDelegate(System.IntPtr glyphIndexes, int lookupIndex, [Out] System.IntPtr recordCount);

	private delegate int PopulatePairAdjustmentRecordMarshallingArray_for_NewlyAddedGlyphIndexes_InjectedDelegate(System.IntPtr newGlyphIndexes, System.IntPtr allGlyphIndexes, [Out] System.IntPtr recordCount);

	private delegate void GetGlyphPairAdjustmentRecord_InjectedDelegate(uint firstGlyphIndex, uint secondGlyphIndex, [Out] System.IntPtr ret);

	private delegate int PopulateSingleAdjustmentRecordMarshallingArray_from_GlyphIndexes_InjectedDelegate(System.IntPtr glyphIndexes, int lookupIndex, [Out] System.IntPtr recordCount);

	private delegate int GetSingleAdjustmentRecordsFromMarshallingArray_InjectedDelegate(System.IntPtr singleSubstitutionRecords);

	private delegate void GetPairAdjustmentRecords_InjectedDelegate(uint glyphIndex, [Out] System.IntPtr ret);

	private delegate void GetPairAdjustmentRecord_InjectedDelegate(uint firstGlyphIndex, uint secondGlyphIndex, [Out] System.IntPtr ret);

	private delegate int PopulatePairAdjustmentRecordMarshallingArray_for_LookupIndex_InjectedDelegate(System.IntPtr glyphIndexes, int lookupIndex, [Out] System.IntPtr recordCount);

	private delegate void GetMarkToBaseAdjustmentRecords_InjectedDelegate(uint baseGlyphIndex, [Out] System.IntPtr ret);

	private delegate void GetMarkToBaseAdjustmentRecord_InjectedDelegate(uint baseGlyphIndex, uint markGlyphIndex, [Out] System.IntPtr ret);

	private delegate int PopulateMarkToBaseAdjustmentRecordMarshallingArray_for_LookupIndex_InjectedDelegate(System.IntPtr glyphIndexes, int lookupIndex, [Out] System.IntPtr recordCount);

	private delegate void GetMarkToMarkAdjustmentRecords_InjectedDelegate(uint baseMarkGlyphIndex, [Out] System.IntPtr ret);

	private delegate void GetMarkToMarkAdjustmentRecord_InjectedDelegate(uint firstGlyphIndex, uint secondGlyphIndex, [Out] System.IntPtr ret);

	private delegate int PopulateMarkToMarkAdjustmentRecordMarshallingArray_for_LookupIndex_InjectedDelegate(System.IntPtr glyphIndexes, int lookupIndex, [Out] System.IntPtr recordCount);

	private delegate void RenderBufferToTexture_InjectedDelegate(System.IntPtr srcTexture, int padding, GlyphRenderMode renderMode, System.IntPtr dstTexture);

	private static readonly System.IntPtr NativeFieldInfoPtr_s_Glyphs;

	private static readonly System.IntPtr NativeFieldInfoPtr_s_GlyphIndexes_MarshallingArray_A;

	private static readonly System.IntPtr NativeFieldInfoPtr_s_GlyphMarshallingStruct_IN;

	private static readonly System.IntPtr NativeFieldInfoPtr_s_GlyphMarshallingStruct_OUT;

	private static readonly System.IntPtr NativeFieldInfoPtr_s_FreeGlyphRects;

	private static readonly System.IntPtr NativeFieldInfoPtr_s_UsedGlyphRects;

	private static readonly System.IntPtr NativeFieldInfoPtr_s_LigatureSubstitutionRecords_MarshallingArray;

	private static readonly System.IntPtr NativeFieldInfoPtr_s_PairAdjustmentRecords_MarshallingArray;

	private static readonly System.IntPtr NativeFieldInfoPtr_s_MarkToBaseAdjustmentRecords_MarshallingArray;

	private static readonly System.IntPtr NativeFieldInfoPtr_s_MarkToMarkAdjustmentRecords_MarshallingArray;

	private static readonly System.IntPtr NativeFieldInfoPtr_s_GlyphLookupDictionary;

	private static readonly System.IntPtr NativeMethodInfoPtr_LoadFontFace_Public_Static_FontEngineError_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LoadFontFace_Internal_Private_Static_Int32_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LoadFontFace_Public_Static_FontEngineError_String_Single_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LoadFontFace_With_Size_And_FaceIndex_Internal_Private_Static_Int32_String_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LoadFontFace_Public_Static_FontEngineError_Font_Single_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LoadFontFace_With_Size_and_FaceIndex_FromFont_Internal_Private_Static_Int32_Font_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LoadFontFace_Public_Static_FontEngineError_String_String_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LoadFontFace_With_Size_by_FamilyName_and_StyleName_Internal_Private_Static_Int32_String_String_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UnloadFontFace_Public_Static_FontEngineError_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UnloadFontFace_Internal_Private_Static_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsColorFontFace_Internal_Static_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TryGetSystemFontReference_Internal_Static_Boolean_String_String_byref_FontReference_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TryGetSystemFontReference_Internal_Private_Static_Boolean_String_String_byref_FontReference_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetFaceInfo_Public_Static_FaceInfo_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetFaceInfo_Internal_Private_Static_Int32_byref_FaceInfo_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetFontFaces_Public_Static_Il2CppStringArray_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetFontFaces_Internal_Private_Static_Il2CppStringArray_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetVariantGlyphIndex_Internal_Static_UInt32_UInt32_UInt32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetGlyphIndex_Internal_Static_UInt32_UInt32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TryGetGlyphWithUnicodeValue_Public_Static_Boolean_UInt32_GlyphLoadFlags_byref_Glyph_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TryGetGlyphWithUnicodeValue_Internal_Private_Static_Boolean_UInt32_GlyphLoadFlags_byref_GlyphMarshallingStruct_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TryGetGlyphWithIndexValue_Public_Static_Boolean_UInt32_GlyphLoadFlags_byref_Glyph_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TryGetGlyphWithIndexValue_Internal_Private_Static_Boolean_UInt32_GlyphLoadFlags_byref_GlyphMarshallingStruct_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetTextureUploadMode_Internal_Static_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TryAddGlyphToTexture_Internal_Static_Boolean_UInt32_Int32_GlyphPackingMode_List_1_GlyphRect_List_1_GlyphRect_GlyphRenderMode_Texture2D_byref_Glyph_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TryAddGlyphToTexture_Internal_Private_Static_Boolean_UInt32_Int32_GlyphPackingMode_Il2CppStructArray_1_GlyphRect_byref_Int32_Il2CppStructArray_1_GlyphRect_byref_Int32_GlyphRenderMode_Texture2D_byref_GlyphMarshallingStruct_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TryAddGlyphsToTexture_Internal_Static_Boolean_List_1_UInt32_Int32_GlyphPackingMode_List_1_GlyphRect_List_1_GlyphRect_GlyphRenderMode_Texture2D_byref_Il2CppReferenceArray_1_Glyph_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TryAddGlyphsToTexture_Internal_Private_Static_Boolean_Il2CppStructArray_1_UInt32_Int32_GlyphPackingMode_Il2CppStructArray_1_GlyphRect_byref_Int32_Il2CppStructArray_1_GlyphRect_byref_Int32_GlyphRenderMode_Texture2D_Il2CppStructArray_1_GlyphMarshallingStruct_byref_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetAllLigatureSubstitutionRecords_Internal_Static_Il2CppReferenceArray_1_LigatureSubstitutionRecord_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetLigatureSubstitutionRecords_Internal_Static_Il2CppReferenceArray_1_LigatureSubstitutionRecord_UInt32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetLigatureSubstitutionRecords_Internal_Static_Il2CppReferenceArray_1_LigatureSubstitutionRecord_List_1_UInt32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetLigatureSubstitutionRecords_Private_Static_Il2CppReferenceArray_1_LigatureSubstitutionRecord_Il2CppStructArray_1_UInt32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PopulateLigatureSubstitutionRecordMarshallingArray_Private_Static_Int32_Il2CppStructArray_1_UInt32_byref_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetLigatureSubstitutionRecordsFromMarshallingArray_Private_Static_Int32_Il2CppReferenceArray_1_LigatureSubstitutionRecord_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetGlyphPairAdjustmentTable_Internal_Static_Il2CppStructArray_1_GlyphPairAdjustmentRecord_Il2CppStructArray_1_UInt32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PopulatePairAdjustmentRecordMarshallingArray_from_KernTable_Private_Static_Int32_Il2CppStructArray_1_UInt32_byref_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetAllPairAdjustmentRecords_Internal_Static_Il2CppStructArray_1_GlyphPairAdjustmentRecord_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetPairAdjustmentRecords_Internal_Static_Il2CppStructArray_1_GlyphPairAdjustmentRecord_List_1_UInt32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetPairAdjustmentRecords_Private_Static_Il2CppStructArray_1_GlyphPairAdjustmentRecord_Il2CppStructArray_1_UInt32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PopulatePairAdjustmentRecordMarshallingArray_Private_Static_Int32_Il2CppStructArray_1_UInt32_byref_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetPairAdjustmentRecordsFromMarshallingArray_Private_Static_Int32_Span_1_GlyphPairAdjustmentRecord_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetAllMarkToBaseAdjustmentRecords_Internal_Static_Il2CppStructArray_1_MarkToBaseAdjustmentRecord_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetMarkToBaseAdjustmentRecords_Internal_Static_Il2CppStructArray_1_MarkToBaseAdjustmentRecord_List_1_UInt32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetMarkToBaseAdjustmentRecords_Private_Static_Il2CppStructArray_1_MarkToBaseAdjustmentRecord_Il2CppStructArray_1_UInt32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PopulateMarkToBaseAdjustmentRecordMarshallingArray_Private_Static_Int32_Il2CppStructArray_1_UInt32_byref_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetMarkToBaseAdjustmentRecordsFromMarshallingArray_Private_Static_Int32_Span_1_MarkToBaseAdjustmentRecord_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetAllMarkToMarkAdjustmentRecords_Internal_Static_Il2CppStructArray_1_MarkToMarkAdjustmentRecord_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetMarkToMarkAdjustmentRecords_Internal_Static_Il2CppStructArray_1_MarkToMarkAdjustmentRecord_List_1_UInt32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetMarkToMarkAdjustmentRecords_Private_Static_Il2CppStructArray_1_MarkToMarkAdjustmentRecord_Il2CppStructArray_1_UInt32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PopulateMarkToMarkAdjustmentRecordMarshallingArray_Private_Static_Int32_Il2CppStructArray_1_UInt32_byref_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetMarkToMarkAdjustmentRecordsFromMarshallingArray_Private_Static_Int32_Span_1_MarkToMarkAdjustmentRecord_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GlyphIndexToMarshallingArray_Private_Static_Void_UInt32_byref_Il2CppStructArray_1_UInt32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GenericListToMarshallingArray_Private_Static_Void_byref_List_1_T_byref_Il2CppArrayBase_1_T_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetMarshallingArraySize_Private_Static_Void_byref_Il2CppArrayBase_1_T_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ResetAtlasTexture_Internal_Static_Void_Texture2D_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LoadFontFace_Internal_Injected_Private_Static_Int32_byref_ManagedSpanWrapper_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LoadFontFace_With_Size_And_FaceIndex_Internal_Injected_Private_Static_Int32_byref_ManagedSpanWrapper_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LoadFontFace_With_Size_and_FaceIndex_FromFont_Internal_Injected_Private_Static_Int32_IntPtr_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LoadFontFace_With_Size_by_FamilyName_and_StyleName_Internal_Injected_Private_Static_Int32_byref_ManagedSpanWrapper_byref_ManagedSpanWrapper_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TryGetSystemFontReference_Internal_Injected_Private_Static_Boolean_byref_ManagedSpanWrapper_byref_ManagedSpanWrapper_byref_FontReference_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TryAddGlyphToTexture_Internal_Injected_Private_Static_Boolean_UInt32_Int32_GlyphPackingMode_byref_BlittableArrayWrapper_byref_Int32_byref_BlittableArrayWrapper_byref_Int32_GlyphRenderMode_IntPtr_byref_GlyphMarshallingStruct_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TryAddGlyphsToTexture_Internal_Injected_Private_Static_Boolean_byref_ManagedSpanWrapper_Int32_GlyphPackingMode_byref_BlittableArrayWrapper_byref_Int32_byref_BlittableArrayWrapper_byref_Int32_GlyphRenderMode_IntPtr_byref_BlittableArrayWrapper_byref_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PopulateLigatureSubstitutionRecordMarshallingArray_Injected_Private_Static_Int32_byref_ManagedSpanWrapper_byref_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PopulatePairAdjustmentRecordMarshallingArray_from_KernTable_Injected_Private_Static_Int32_byref_ManagedSpanWrapper_byref_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetAllPairAdjustmentRecords_Injected_Private_Static_Void_byref_BlittableArrayWrapper_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PopulatePairAdjustmentRecordMarshallingArray_Injected_Private_Static_Int32_byref_ManagedSpanWrapper_byref_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetPairAdjustmentRecordsFromMarshallingArray_Injected_Private_Static_Int32_byref_ManagedSpanWrapper_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetAllMarkToBaseAdjustmentRecords_Injected_Private_Static_Void_byref_BlittableArrayWrapper_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PopulateMarkToBaseAdjustmentRecordMarshallingArray_Injected_Private_Static_Int32_byref_ManagedSpanWrapper_byref_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetMarkToBaseAdjustmentRecordsFromMarshallingArray_Injected_Private_Static_Int32_byref_ManagedSpanWrapper_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetAllMarkToMarkAdjustmentRecords_Injected_Private_Static_Void_byref_BlittableArrayWrapper_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PopulateMarkToMarkAdjustmentRecordMarshallingArray_Injected_Private_Static_Int32_byref_ManagedSpanWrapper_byref_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetMarkToMarkAdjustmentRecordsFromMarshallingArray_Injected_Private_Static_Int32_byref_ManagedSpanWrapper_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ResetAtlasTexture_Injected_Private_Static_Void_IntPtr_0;

	private static readonly InitializeFontEngine_InternalDelegate InitializeFontEngine_InternalDelegateField;

	private static readonly DestroyFontEngine_InternalDelegate DestroyFontEngine_InternalDelegateField;

	private static readonly SendCancellationRequest_InternalDelegate SendCancellationRequest_InternalDelegateField;

	private static readonly get_isProcessingDoneDelegate get_isProcessingDoneDelegateField;

	private static readonly get_generationProgressDelegate get_generationProgressDelegateField;

	private static readonly UnloadAllFontFaces_InternalDelegate UnloadAllFontFaces_InternalDelegateField;

	private static readonly GetSystemFontNames_InternalDelegate GetSystemFontNames_InternalDelegateField;

	private static readonly GetSystemFontReferencesDelegate GetSystemFontReferencesDelegateField;

	private static readonly SetFaceSize_InternalDelegate SetFaceSize_InternalDelegateField;

	private static readonly GetFaceCountDelegate GetFaceCountDelegateField;

	private static readonly TryGetGlyphIndexDelegate TryGetGlyphIndexDelegateField;

	private static readonly ReleaseSharedTextureDelegate ReleaseSharedTextureDelegateField;

	private static readonly GetAllMultipleSubstitutionRecordsDelegate GetAllMultipleSubstitutionRecordsDelegateField;

	private static readonly GetMultipleSubstitutionRecordsFromMarshallingArrayDelegate GetMultipleSubstitutionRecordsFromMarshallingArrayDelegateField;

	private static readonly PopulatePairAdjustmentRecordMarshallingArray_from_GlyphIndexDelegate PopulatePairAdjustmentRecordMarshallingArray_from_GlyphIndexDelegateField;

	private static readonly LoadFontFace_With_Size_Internal_InjectedDelegate LoadFontFace_With_Size_Internal_InjectedDelegateField;

	private static readonly LoadFontFace_FromSourceFontFile_Internal_InjectedDelegate LoadFontFace_FromSourceFontFile_Internal_InjectedDelegateField;

	private static readonly LoadFontFace_With_Size_FromSourceFontFile_Internal_InjectedDelegate LoadFontFace_With_Size_FromSourceFontFile_Internal_InjectedDelegateField;

	private static readonly LoadFontFace_With_Size_And_FaceIndex_FromSourceFontFile_Internal_InjectedDelegate LoadFontFace_With_Size_And_FaceIndex_FromSourceFontFile_Internal_InjectedDelegateField;

	private static readonly LoadFontFace_FromFont_Internal_InjectedDelegate LoadFontFace_FromFont_Internal_InjectedDelegateField;

	private static readonly LoadFontFace_With_Size_FromFont_Internal_InjectedDelegate LoadFontFace_With_Size_FromFont_Internal_InjectedDelegateField;

	private static readonly LoadFontFace_by_FamilyName_and_StyleName_Internal_InjectedDelegate LoadFontFace_by_FamilyName_and_StyleName_Internal_InjectedDelegateField;

	private static readonly TryPackGlyphInAtlas_Internal_InjectedDelegate TryPackGlyphInAtlas_Internal_InjectedDelegateField;

	private static readonly TryPackGlyphsInAtlas_Internal_InjectedDelegate TryPackGlyphsInAtlas_Internal_InjectedDelegateField;

	private static readonly RenderGlyphToTexture_Internal_InjectedDelegate RenderGlyphToTexture_Internal_InjectedDelegateField;

	private static readonly RenderGlyphsToTexture_Internal_InjectedDelegate RenderGlyphsToTexture_Internal_InjectedDelegateField;

	private static readonly RenderGlyphsToTextureBuffer_Internal_InjectedDelegate RenderGlyphsToTextureBuffer_Internal_InjectedDelegateField;

	private static readonly RenderGlyphsToSharedTexture_Internal_InjectedDelegate RenderGlyphsToSharedTexture_Internal_InjectedDelegateField;

	private static readonly SetSharedTexture_InjectedDelegate SetSharedTexture_InjectedDelegateField;

	private static readonly TryAddGlyphsToTexture_Internal_MultiThread_InjectedDelegate TryAddGlyphsToTexture_Internal_MultiThread_InjectedDelegateField;

	private static readonly GetOpenTypeLayoutLookups_InjectedDelegate GetOpenTypeLayoutLookups_InjectedDelegateField;

	private static readonly GetAllSingleSubstitutionRecords_InjectedDelegate GetAllSingleSubstitutionRecords_InjectedDelegateField;

	private static readonly PopulateSingleSubstitutionRecordMarshallingArray_from_GlyphIndexes_InjectedDelegate PopulateSingleSubstitutionRecordMarshallingArray_from_GlyphIndexes_InjectedDelegateField;

	private static readonly GetSingleSubstitutionRecordsFromMarshallingArray_InjectedDelegate GetSingleSubstitutionRecordsFromMarshallingArray_InjectedDelegateField;

	private static readonly PopulateMultipleSubstitutionRecordMarshallingArray_from_GlyphIndexes_InjectedDelegate PopulateMultipleSubstitutionRecordMarshallingArray_from_GlyphIndexes_InjectedDelegateField;

	private static readonly PopulateAlternateSubstitutionRecordMarshallingArray_from_GlyphIndexes_InjectedDelegate PopulateAlternateSubstitutionRecordMarshallingArray_from_GlyphIndexes_InjectedDelegateField;

	private static readonly PopulateLigatureSubstitutionRecordMarshallingArray_for_LookupIndex_InjectedDelegate PopulateLigatureSubstitutionRecordMarshallingArray_for_LookupIndex_InjectedDelegateField;

	private static readonly PopulateContextualSubstitutionRecordMarshallingArray_from_GlyphIndexes_InjectedDelegate PopulateContextualSubstitutionRecordMarshallingArray_from_GlyphIndexes_InjectedDelegateField;

	private static readonly PopulateChainingContextualSubstitutionRecordMarshallingArray_from_GlyphIndexes_InjectedDelegate PopulateChainingContextualSubstitutionRecordMarshallingArray_from_GlyphIndexes_InjectedDelegateField;

	private static readonly PopulatePairAdjustmentRecordMarshallingArray_for_NewlyAddedGlyphIndexes_InjectedDelegate PopulatePairAdjustmentRecordMarshallingArray_for_NewlyAddedGlyphIndexes_InjectedDelegateField;

	private static readonly GetGlyphPairAdjustmentRecord_InjectedDelegate GetGlyphPairAdjustmentRecord_InjectedDelegateField;

	private static readonly PopulateSingleAdjustmentRecordMarshallingArray_from_GlyphIndexes_InjectedDelegate PopulateSingleAdjustmentRecordMarshallingArray_from_GlyphIndexes_InjectedDelegateField;

	private static readonly GetSingleAdjustmentRecordsFromMarshallingArray_InjectedDelegate GetSingleAdjustmentRecordsFromMarshallingArray_InjectedDelegateField;

	private static readonly GetPairAdjustmentRecords_InjectedDelegate GetPairAdjustmentRecords_InjectedDelegateField;

	private static readonly GetPairAdjustmentRecord_InjectedDelegate GetPairAdjustmentRecord_InjectedDelegateField;

	private static readonly PopulatePairAdjustmentRecordMarshallingArray_for_LookupIndex_InjectedDelegate PopulatePairAdjustmentRecordMarshallingArray_for_LookupIndex_InjectedDelegateField;

	private static readonly GetMarkToBaseAdjustmentRecords_InjectedDelegate GetMarkToBaseAdjustmentRecords_InjectedDelegateField;

	private static readonly GetMarkToBaseAdjustmentRecord_InjectedDelegate GetMarkToBaseAdjustmentRecord_InjectedDelegateField;

	private static readonly PopulateMarkToBaseAdjustmentRecordMarshallingArray_for_LookupIndex_InjectedDelegate PopulateMarkToBaseAdjustmentRecordMarshallingArray_for_LookupIndex_InjectedDelegateField;

	private static readonly GetMarkToMarkAdjustmentRecords_InjectedDelegate GetMarkToMarkAdjustmentRecords_InjectedDelegateField;

	private static readonly GetMarkToMarkAdjustmentRecord_InjectedDelegate GetMarkToMarkAdjustmentRecord_InjectedDelegateField;

	private static readonly PopulateMarkToMarkAdjustmentRecordMarshallingArray_for_LookupIndex_InjectedDelegate PopulateMarkToMarkAdjustmentRecordMarshallingArray_for_LookupIndex_InjectedDelegateField;

	private static readonly RenderBufferToTexture_InjectedDelegate RenderBufferToTexture_InjectedDelegateField;

	public unsafe static Il2CppReferenceArray<Glyph> s_Glyphs
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_Glyphs, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Glyph>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_Glyphs, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Il2CppStructArray<uint> s_GlyphIndexes_MarshallingArray_A
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_GlyphIndexes_MarshallingArray_A, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<uint>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_GlyphIndexes_MarshallingArray_A, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Il2CppStructArray<GlyphMarshallingStruct> s_GlyphMarshallingStruct_IN
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_GlyphMarshallingStruct_IN, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<GlyphMarshallingStruct>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_GlyphMarshallingStruct_IN, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Il2CppStructArray<GlyphMarshallingStruct> s_GlyphMarshallingStruct_OUT
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_GlyphMarshallingStruct_OUT, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<GlyphMarshallingStruct>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_GlyphMarshallingStruct_OUT, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Il2CppStructArray<GlyphRect> s_FreeGlyphRects
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_FreeGlyphRects, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<GlyphRect>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_FreeGlyphRects, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Il2CppStructArray<GlyphRect> s_UsedGlyphRects
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_UsedGlyphRects, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<GlyphRect>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_UsedGlyphRects, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Il2CppReferenceArray<LigatureSubstitutionRecord> s_LigatureSubstitutionRecords_MarshallingArray
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_LigatureSubstitutionRecords_MarshallingArray, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<LigatureSubstitutionRecord>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_LigatureSubstitutionRecords_MarshallingArray, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Il2CppStructArray<GlyphPairAdjustmentRecord> s_PairAdjustmentRecords_MarshallingArray
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_PairAdjustmentRecords_MarshallingArray, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<GlyphPairAdjustmentRecord>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_PairAdjustmentRecords_MarshallingArray, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Il2CppStructArray<MarkToBaseAdjustmentRecord> s_MarkToBaseAdjustmentRecords_MarshallingArray
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_MarkToBaseAdjustmentRecords_MarshallingArray, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<MarkToBaseAdjustmentRecord>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_MarkToBaseAdjustmentRecords_MarshallingArray, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Il2CppStructArray<MarkToMarkAdjustmentRecord> s_MarkToMarkAdjustmentRecords_MarshallingArray
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_MarkToMarkAdjustmentRecords_MarshallingArray, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<MarkToMarkAdjustmentRecord>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_MarkToMarkAdjustmentRecords_MarshallingArray, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Dictionary<uint, Glyph> s_GlyphLookupDictionary
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_GlyphLookupDictionary, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<uint, Glyph>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_GlyphLookupDictionary, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public static bool isProcessingDone => get_isProcessingDoneDelegateField();

	public static float generationProgress => get_generationProgressDelegateField();

	static FontEngine()
	{
		Il2CppClassPointerStore<FontEngine>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.TextCoreFontEngineModule.dll", "UnityEngine.TextCore.LowLevel", "FontEngine");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FontEngine>.NativeClassPtr);
		NativeFieldInfoPtr_s_Glyphs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FontEngine>.NativeClassPtr, "s_Glyphs");
		NativeFieldInfoPtr_s_GlyphIndexes_MarshallingArray_A = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FontEngine>.NativeClassPtr, "s_GlyphIndexes_MarshallingArray_A");
		NativeFieldInfoPtr_s_GlyphMarshallingStruct_IN = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FontEngine>.NativeClassPtr, "s_GlyphMarshallingStruct_IN");
		NativeFieldInfoPtr_s_GlyphMarshallingStruct_OUT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FontEngine>.NativeClassPtr, "s_GlyphMarshallingStruct_OUT");
		NativeFieldInfoPtr_s_FreeGlyphRects = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FontEngine>.NativeClassPtr, "s_FreeGlyphRects");
		NativeFieldInfoPtr_s_UsedGlyphRects = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FontEngine>.NativeClassPtr, "s_UsedGlyphRects");
		NativeFieldInfoPtr_s_LigatureSubstitutionRecords_MarshallingArray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FontEngine>.NativeClassPtr, "s_LigatureSubstitutionRecords_MarshallingArray");
		NativeFieldInfoPtr_s_PairAdjustmentRecords_MarshallingArray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FontEngine>.NativeClassPtr, "s_PairAdjustmentRecords_MarshallingArray");
		NativeFieldInfoPtr_s_MarkToBaseAdjustmentRecords_MarshallingArray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FontEngine>.NativeClassPtr, "s_MarkToBaseAdjustmentRecords_MarshallingArray");
		NativeFieldInfoPtr_s_MarkToMarkAdjustmentRecords_MarshallingArray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FontEngine>.NativeClassPtr, "s_MarkToMarkAdjustmentRecords_MarshallingArray");
		NativeFieldInfoPtr_s_GlyphLookupDictionary = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FontEngine>.NativeClassPtr, "s_GlyphLookupDictionary");
		NativeMethodInfoPtr_LoadFontFace_Public_Static_FontEngineError_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontEngine>.NativeClassPtr, 100663354);
		NativeMethodInfoPtr_LoadFontFace_Internal_Private_Static_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontEngine>.NativeClassPtr, 100663355);
		NativeMethodInfoPtr_LoadFontFace_Public_Static_FontEngineError_String_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontEngine>.NativeClassPtr, 100663356);
		NativeMethodInfoPtr_LoadFontFace_With_Size_And_FaceIndex_Internal_Private_Static_Int32_String_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontEngine>.NativeClassPtr, 100663357);
		NativeMethodInfoPtr_LoadFontFace_Public_Static_FontEngineError_Font_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontEngine>.NativeClassPtr, 100663358);
		NativeMethodInfoPtr_LoadFontFace_With_Size_and_FaceIndex_FromFont_Internal_Private_Static_Int32_Font_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontEngine>.NativeClassPtr, 100663359);
		NativeMethodInfoPtr_LoadFontFace_Public_Static_FontEngineError_String_String_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontEngine>.NativeClassPtr, 100663360);
		NativeMethodInfoPtr_LoadFontFace_With_Size_by_FamilyName_and_StyleName_Internal_Private_Static_Int32_String_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontEngine>.NativeClassPtr, 100663361);
		NativeMethodInfoPtr_UnloadFontFace_Public_Static_FontEngineError_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontEngine>.NativeClassPtr, 100663362);
		NativeMethodInfoPtr_UnloadFontFace_Internal_Private_Static_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontEngine>.NativeClassPtr, 100663363);
		NativeMethodInfoPtr_IsColorFontFace_Internal_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontEngine>.NativeClassPtr, 100663364);
		NativeMethodInfoPtr_TryGetSystemFontReference_Internal_Static_Boolean_String_String_byref_FontReference_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontEngine>.NativeClassPtr, 100663365);
		NativeMethodInfoPtr_TryGetSystemFontReference_Internal_Private_Static_Boolean_String_String_byref_FontReference_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontEngine>.NativeClassPtr, 100663366);
		NativeMethodInfoPtr_GetFaceInfo_Public_Static_FaceInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontEngine>.NativeClassPtr, 100663367);
		NativeMethodInfoPtr_GetFaceInfo_Internal_Private_Static_Int32_byref_FaceInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontEngine>.NativeClassPtr, 100663368);
		NativeMethodInfoPtr_GetFontFaces_Public_Static_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontEngine>.NativeClassPtr, 100663369);
		NativeMethodInfoPtr_GetFontFaces_Internal_Private_Static_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontEngine>.NativeClassPtr, 100663370);
		NativeMethodInfoPtr_GetVariantGlyphIndex_Internal_Static_UInt32_UInt32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontEngine>.NativeClassPtr, 100663371);
		NativeMethodInfoPtr_GetGlyphIndex_Internal_Static_UInt32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontEngine>.NativeClassPtr, 100663372);
		NativeMethodInfoPtr_TryGetGlyphWithUnicodeValue_Public_Static_Boolean_UInt32_GlyphLoadFlags_byref_Glyph_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontEngine>.NativeClassPtr, 100663373);
		NativeMethodInfoPtr_TryGetGlyphWithUnicodeValue_Internal_Private_Static_Boolean_UInt32_GlyphLoadFlags_byref_GlyphMarshallingStruct_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontEngine>.NativeClassPtr, 100663374);
		NativeMethodInfoPtr_TryGetGlyphWithIndexValue_Public_Static_Boolean_UInt32_GlyphLoadFlags_byref_Glyph_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontEngine>.NativeClassPtr, 100663375);
		NativeMethodInfoPtr_TryGetGlyphWithIndexValue_Internal_Private_Static_Boolean_UInt32_GlyphLoadFlags_byref_GlyphMarshallingStruct_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontEngine>.NativeClassPtr, 100663376);
		NativeMethodInfoPtr_SetTextureUploadMode_Internal_Static_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontEngine>.NativeClassPtr, 100663377);
		NativeMethodInfoPtr_TryAddGlyphToTexture_Internal_Static_Boolean_UInt32_Int32_GlyphPackingMode_List_1_GlyphRect_List_1_GlyphRect_GlyphRenderMode_Texture2D_byref_Glyph_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontEngine>.NativeClassPtr, 100663378);
		NativeMethodInfoPtr_TryAddGlyphToTexture_Internal_Private_Static_Boolean_UInt32_Int32_GlyphPackingMode_Il2CppStructArray_1_GlyphRect_byref_Int32_Il2CppStructArray_1_GlyphRect_byref_Int32_GlyphRenderMode_Texture2D_byref_GlyphMarshallingStruct_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontEngine>.NativeClassPtr, 100663379);
		NativeMethodInfoPtr_TryAddGlyphsToTexture_Internal_Static_Boolean_List_1_UInt32_Int32_GlyphPackingMode_List_1_GlyphRect_List_1_GlyphRect_GlyphRenderMode_Texture2D_byref_Il2CppReferenceArray_1_Glyph_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontEngine>.NativeClassPtr, 100663380);
		NativeMethodInfoPtr_TryAddGlyphsToTexture_Internal_Private_Static_Boolean_Il2CppStructArray_1_UInt32_Int32_GlyphPackingMode_Il2CppStructArray_1_GlyphRect_byref_Int32_Il2CppStructArray_1_GlyphRect_byref_Int32_GlyphRenderMode_Texture2D_Il2CppStructArray_1_GlyphMarshallingStruct_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontEngine>.NativeClassPtr, 100663381);
		NativeMethodInfoPtr_GetAllLigatureSubstitutionRecords_Internal_Static_Il2CppReferenceArray_1_LigatureSubstitutionRecord_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontEngine>.NativeClassPtr, 100663382);
		NativeMethodInfoPtr_GetLigatureSubstitutionRecords_Internal_Static_Il2CppReferenceArray_1_LigatureSubstitutionRecord_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontEngine>.NativeClassPtr, 100663383);
		NativeMethodInfoPtr_GetLigatureSubstitutionRecords_Internal_Static_Il2CppReferenceArray_1_LigatureSubstitutionRecord_List_1_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontEngine>.NativeClassPtr, 100663384);
		NativeMethodInfoPtr_GetLigatureSubstitutionRecords_Private_Static_Il2CppReferenceArray_1_LigatureSubstitutionRecord_Il2CppStructArray_1_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontEngine>.NativeClassPtr, 100663385);
		NativeMethodInfoPtr_PopulateLigatureSubstitutionRecordMarshallingArray_Private_Static_Int32_Il2CppStructArray_1_UInt32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontEngine>.NativeClassPtr, 100663386);
		NativeMethodInfoPtr_GetLigatureSubstitutionRecordsFromMarshallingArray_Private_Static_Int32_Il2CppReferenceArray_1_LigatureSubstitutionRecord_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontEngine>.NativeClassPtr, 100663387);
		NativeMethodInfoPtr_GetGlyphPairAdjustmentTable_Internal_Static_Il2CppStructArray_1_GlyphPairAdjustmentRecord_Il2CppStructArray_1_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontEngine>.NativeClassPtr, 100663388);
		NativeMethodInfoPtr_PopulatePairAdjustmentRecordMarshallingArray_from_KernTable_Private_Static_Int32_Il2CppStructArray_1_UInt32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontEngine>.NativeClassPtr, 100663389);
		NativeMethodInfoPtr_GetAllPairAdjustmentRecords_Internal_Static_Il2CppStructArray_1_GlyphPairAdjustmentRecord_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontEngine>.NativeClassPtr, 100663390);
		NativeMethodInfoPtr_GetPairAdjustmentRecords_Internal_Static_Il2CppStructArray_1_GlyphPairAdjustmentRecord_List_1_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontEngine>.NativeClassPtr, 100663391);
		NativeMethodInfoPtr_GetPairAdjustmentRecords_Private_Static_Il2CppStructArray_1_GlyphPairAdjustmentRecord_Il2CppStructArray_1_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontEngine>.NativeClassPtr, 100663392);
		NativeMethodInfoPtr_PopulatePairAdjustmentRecordMarshallingArray_Private_Static_Int32_Il2CppStructArray_1_UInt32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontEngine>.NativeClassPtr, 100663393);
		NativeMethodInfoPtr_GetPairAdjustmentRecordsFromMarshallingArray_Private_Static_Int32_Span_1_GlyphPairAdjustmentRecord_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontEngine>.NativeClassPtr, 100663394);
		NativeMethodInfoPtr_GetAllMarkToBaseAdjustmentRecords_Internal_Static_Il2CppStructArray_1_MarkToBaseAdjustmentRecord_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontEngine>.NativeClassPtr, 100663395);
		NativeMethodInfoPtr_GetMarkToBaseAdjustmentRecords_Internal_Static_Il2CppStructArray_1_MarkToBaseAdjustmentRecord_List_1_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontEngine>.NativeClassPtr, 100663396);
		NativeMethodInfoPtr_GetMarkToBaseAdjustmentRecords_Private_Static_Il2CppStructArray_1_MarkToBaseAdjustmentRecord_Il2CppStructArray_1_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontEngine>.NativeClassPtr, 100663397);
		NativeMethodInfoPtr_PopulateMarkToBaseAdjustmentRecordMarshallingArray_Private_Static_Int32_Il2CppStructArray_1_UInt32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontEngine>.NativeClassPtr, 100663398);
		NativeMethodInfoPtr_GetMarkToBaseAdjustmentRecordsFromMarshallingArray_Private_Static_Int32_Span_1_MarkToBaseAdjustmentRecord_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontEngine>.NativeClassPtr, 100663399);
		NativeMethodInfoPtr_GetAllMarkToMarkAdjustmentRecords_Internal_Static_Il2CppStructArray_1_MarkToMarkAdjustmentRecord_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontEngine>.NativeClassPtr, 100663400);
		NativeMethodInfoPtr_GetMarkToMarkAdjustmentRecords_Internal_Static_Il2CppStructArray_1_MarkToMarkAdjustmentRecord_List_1_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontEngine>.NativeClassPtr, 100663401);
		NativeMethodInfoPtr_GetMarkToMarkAdjustmentRecords_Private_Static_Il2CppStructArray_1_MarkToMarkAdjustmentRecord_Il2CppStructArray_1_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontEngine>.NativeClassPtr, 100663402);
		NativeMethodInfoPtr_PopulateMarkToMarkAdjustmentRecordMarshallingArray_Private_Static_Int32_Il2CppStructArray_1_UInt32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontEngine>.NativeClassPtr, 100663403);
		NativeMethodInfoPtr_GetMarkToMarkAdjustmentRecordsFromMarshallingArray_Private_Static_Int32_Span_1_MarkToMarkAdjustmentRecord_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontEngine>.NativeClassPtr, 100663404);
		NativeMethodInfoPtr_GlyphIndexToMarshallingArray_Private_Static_Void_UInt32_byref_Il2CppStructArray_1_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontEngine>.NativeClassPtr, 100663405);
		NativeMethodInfoPtr_GenericListToMarshallingArray_Private_Static_Void_byref_List_1_T_byref_Il2CppArrayBase_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontEngine>.NativeClassPtr, 100663406);
		NativeMethodInfoPtr_SetMarshallingArraySize_Private_Static_Void_byref_Il2CppArrayBase_1_T_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontEngine>.NativeClassPtr, 100663407);
		NativeMethodInfoPtr_ResetAtlasTexture_Internal_Static_Void_Texture2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontEngine>.NativeClassPtr, 100663408);
		NativeMethodInfoPtr_LoadFontFace_Internal_Injected_Private_Static_Int32_byref_ManagedSpanWrapper_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontEngine>.NativeClassPtr, 100663410);
		NativeMethodInfoPtr_LoadFontFace_With_Size_And_FaceIndex_Internal_Injected_Private_Static_Int32_byref_ManagedSpanWrapper_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontEngine>.NativeClassPtr, 100663411);
		NativeMethodInfoPtr_LoadFontFace_With_Size_and_FaceIndex_FromFont_Internal_Injected_Private_Static_Int32_IntPtr_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontEngine>.NativeClassPtr, 100663412);
		NativeMethodInfoPtr_LoadFontFace_With_Size_by_FamilyName_and_StyleName_Internal_Injected_Private_Static_Int32_byref_ManagedSpanWrapper_byref_ManagedSpanWrapper_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontEngine>.NativeClassPtr, 100663413);
		NativeMethodInfoPtr_TryGetSystemFontReference_Internal_Injected_Private_Static_Boolean_byref_ManagedSpanWrapper_byref_ManagedSpanWrapper_byref_FontReference_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontEngine>.NativeClassPtr, 100663414);
		NativeMethodInfoPtr_TryAddGlyphToTexture_Internal_Injected_Private_Static_Boolean_UInt32_Int32_GlyphPackingMode_byref_BlittableArrayWrapper_byref_Int32_byref_BlittableArrayWrapper_byref_Int32_GlyphRenderMode_IntPtr_byref_GlyphMarshallingStruct_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontEngine>.NativeClassPtr, 100663415);
		NativeMethodInfoPtr_TryAddGlyphsToTexture_Internal_Injected_Private_Static_Boolean_byref_ManagedSpanWrapper_Int32_GlyphPackingMode_byref_BlittableArrayWrapper_byref_Int32_byref_BlittableArrayWrapper_byref_Int32_GlyphRenderMode_IntPtr_byref_BlittableArrayWrapper_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontEngine>.NativeClassPtr, 100663416);
		NativeMethodInfoPtr_PopulateLigatureSubstitutionRecordMarshallingArray_Injected_Private_Static_Int32_byref_ManagedSpanWrapper_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontEngine>.NativeClassPtr, 100663417);
		NativeMethodInfoPtr_PopulatePairAdjustmentRecordMarshallingArray_from_KernTable_Injected_Private_Static_Int32_byref_ManagedSpanWrapper_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontEngine>.NativeClassPtr, 100663418);
		NativeMethodInfoPtr_GetAllPairAdjustmentRecords_Injected_Private_Static_Void_byref_BlittableArrayWrapper_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontEngine>.NativeClassPtr, 100663419);
		NativeMethodInfoPtr_PopulatePairAdjustmentRecordMarshallingArray_Injected_Private_Static_Int32_byref_ManagedSpanWrapper_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontEngine>.NativeClassPtr, 100663420);
		NativeMethodInfoPtr_GetPairAdjustmentRecordsFromMarshallingArray_Injected_Private_Static_Int32_byref_ManagedSpanWrapper_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontEngine>.NativeClassPtr, 100663421);
		NativeMethodInfoPtr_GetAllMarkToBaseAdjustmentRecords_Injected_Private_Static_Void_byref_BlittableArrayWrapper_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontEngine>.NativeClassPtr, 100663422);
		NativeMethodInfoPtr_PopulateMarkToBaseAdjustmentRecordMarshallingArray_Injected_Private_Static_Int32_byref_ManagedSpanWrapper_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontEngine>.NativeClassPtr, 100663423);
		NativeMethodInfoPtr_GetMarkToBaseAdjustmentRecordsFromMarshallingArray_Injected_Private_Static_Int32_byref_ManagedSpanWrapper_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontEngine>.NativeClassPtr, 100663424);
		NativeMethodInfoPtr_GetAllMarkToMarkAdjustmentRecords_Injected_Private_Static_Void_byref_BlittableArrayWrapper_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontEngine>.NativeClassPtr, 100663425);
		NativeMethodInfoPtr_PopulateMarkToMarkAdjustmentRecordMarshallingArray_Injected_Private_Static_Int32_byref_ManagedSpanWrapper_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontEngine>.NativeClassPtr, 100663426);
		NativeMethodInfoPtr_GetMarkToMarkAdjustmentRecordsFromMarshallingArray_Injected_Private_Static_Int32_byref_ManagedSpanWrapper_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontEngine>.NativeClassPtr, 100663427);
		NativeMethodInfoPtr_ResetAtlasTexture_Injected_Private_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontEngine>.NativeClassPtr, 100663428);
		InitializeFontEngine_InternalDelegateField = IL2CPP.ResolveICall<InitializeFontEngine_InternalDelegate>("UnityEngine.TextCore.LowLevel.FontEngine::InitializeFontEngine_Internal");
		DestroyFontEngine_InternalDelegateField = IL2CPP.ResolveICall<DestroyFontEngine_InternalDelegate>("UnityEngine.TextCore.LowLevel.FontEngine::DestroyFontEngine_Internal");
		SendCancellationRequest_InternalDelegateField = IL2CPP.ResolveICall<SendCancellationRequest_InternalDelegate>("UnityEngine.TextCore.LowLevel.FontEngine::SendCancellationRequest_Internal");
		get_isProcessingDoneDelegateField = IL2CPP.ResolveICall<get_isProcessingDoneDelegate>("UnityEngine.TextCore.LowLevel.FontEngine::get_isProcessingDone");
		get_generationProgressDelegateField = IL2CPP.ResolveICall<get_generationProgressDelegate>("UnityEngine.TextCore.LowLevel.FontEngine::get_generationProgress");
		UnloadAllFontFaces_InternalDelegateField = IL2CPP.ResolveICall<UnloadAllFontFaces_InternalDelegate>("UnityEngine.TextCore.LowLevel.FontEngine::UnloadAllFontFaces_Internal");
		GetSystemFontNames_InternalDelegateField = IL2CPP.ResolveICall<GetSystemFontNames_InternalDelegate>("UnityEngine.TextCore.LowLevel.FontEngine::GetSystemFontNames_Internal");
		GetSystemFontReferencesDelegateField = IL2CPP.ResolveICall<GetSystemFontReferencesDelegate>("UnityEngine.TextCore.LowLevel.FontEngine::GetSystemFontReferences");
		SetFaceSize_InternalDelegateField = IL2CPP.ResolveICall<SetFaceSize_InternalDelegate>("UnityEngine.TextCore.LowLevel.FontEngine::SetFaceSize_Internal");
		GetFaceCountDelegateField = IL2CPP.ResolveICall<GetFaceCountDelegate>("UnityEngine.TextCore.LowLevel.FontEngine::GetFaceCount");
		TryGetGlyphIndexDelegateField = IL2CPP.ResolveICall<TryGetGlyphIndexDelegate>("UnityEngine.TextCore.LowLevel.FontEngine::TryGetGlyphIndex");
		ReleaseSharedTextureDelegateField = IL2CPP.ResolveICall<ReleaseSharedTextureDelegate>("UnityEngine.TextCore.LowLevel.FontEngine::ReleaseSharedTexture");
		GetAllMultipleSubstitutionRecordsDelegateField = IL2CPP.ResolveICall<GetAllMultipleSubstitutionRecordsDelegate>("UnityEngine.TextCore.LowLevel.FontEngine::GetAllMultipleSubstitutionRecords");
		GetMultipleSubstitutionRecordsFromMarshallingArrayDelegateField = IL2CPP.ResolveICall<GetMultipleSubstitutionRecordsFromMarshallingArrayDelegate>("UnityEngine.TextCore.LowLevel.FontEngine::GetMultipleSubstitutionRecordsFromMarshallingArray");
		PopulatePairAdjustmentRecordMarshallingArray_from_GlyphIndexDelegateField = IL2CPP.ResolveICall<PopulatePairAdjustmentRecordMarshallingArray_from_GlyphIndexDelegate>("UnityEngine.TextCore.LowLevel.FontEngine::PopulatePairAdjustmentRecordMarshallingArray_from_GlyphIndex");
		LoadFontFace_With_Size_Internal_InjectedDelegateField = IL2CPP.ResolveICall<LoadFontFace_With_Size_Internal_InjectedDelegate>("UnityEngine.TextCore.LowLevel.FontEngine::LoadFontFace_With_Size_Internal_Injected");
		LoadFontFace_FromSourceFontFile_Internal_InjectedDelegateField = IL2CPP.ResolveICall<LoadFontFace_FromSourceFontFile_Internal_InjectedDelegate>("UnityEngine.TextCore.LowLevel.FontEngine::LoadFontFace_FromSourceFontFile_Internal_Injected");
		LoadFontFace_With_Size_FromSourceFontFile_Internal_InjectedDelegateField = IL2CPP.ResolveICall<LoadFontFace_With_Size_FromSourceFontFile_Internal_InjectedDelegate>("UnityEngine.TextCore.LowLevel.FontEngine::LoadFontFace_With_Size_FromSourceFontFile_Internal_Injected");
		LoadFontFace_With_Size_And_FaceIndex_FromSourceFontFile_Internal_InjectedDelegateField = IL2CPP.ResolveICall<LoadFontFace_With_Size_And_FaceIndex_FromSourceFontFile_Internal_InjectedDelegate>("UnityEngine.TextCore.LowLevel.FontEngine::LoadFontFace_With_Size_And_FaceIndex_FromSourceFontFile_Internal_Injected");
		LoadFontFace_FromFont_Internal_InjectedDelegateField = IL2CPP.ResolveICall<LoadFontFace_FromFont_Internal_InjectedDelegate>("UnityEngine.TextCore.LowLevel.FontEngine::LoadFontFace_FromFont_Internal_Injected");
		LoadFontFace_With_Size_FromFont_Internal_InjectedDelegateField = IL2CPP.ResolveICall<LoadFontFace_With_Size_FromFont_Internal_InjectedDelegate>("UnityEngine.TextCore.LowLevel.FontEngine::LoadFontFace_With_Size_FromFont_Internal_Injected");
		LoadFontFace_by_FamilyName_and_StyleName_Internal_InjectedDelegateField = IL2CPP.ResolveICall<LoadFontFace_by_FamilyName_and_StyleName_Internal_InjectedDelegate>("UnityEngine.TextCore.LowLevel.FontEngine::LoadFontFace_by_FamilyName_and_StyleName_Internal_Injected");
		TryPackGlyphInAtlas_Internal_InjectedDelegateField = IL2CPP.ResolveICall<TryPackGlyphInAtlas_Internal_InjectedDelegate>("UnityEngine.TextCore.LowLevel.FontEngine::TryPackGlyphInAtlas_Internal_Injected");
		TryPackGlyphsInAtlas_Internal_InjectedDelegateField = IL2CPP.ResolveICall<TryPackGlyphsInAtlas_Internal_InjectedDelegate>("UnityEngine.TextCore.LowLevel.FontEngine::TryPackGlyphsInAtlas_Internal_Injected");
		RenderGlyphToTexture_Internal_InjectedDelegateField = IL2CPP.ResolveICall<RenderGlyphToTexture_Internal_InjectedDelegate>("UnityEngine.TextCore.LowLevel.FontEngine::RenderGlyphToTexture_Internal_Injected");
		RenderGlyphsToTexture_Internal_InjectedDelegateField = IL2CPP.ResolveICall<RenderGlyphsToTexture_Internal_InjectedDelegate>("UnityEngine.TextCore.LowLevel.FontEngine::RenderGlyphsToTexture_Internal_Injected");
		RenderGlyphsToTextureBuffer_Internal_InjectedDelegateField = IL2CPP.ResolveICall<RenderGlyphsToTextureBuffer_Internal_InjectedDelegate>("UnityEngine.TextCore.LowLevel.FontEngine::RenderGlyphsToTextureBuffer_Internal_Injected");
		RenderGlyphsToSharedTexture_Internal_InjectedDelegateField = IL2CPP.ResolveICall<RenderGlyphsToSharedTexture_Internal_InjectedDelegate>("UnityEngine.TextCore.LowLevel.FontEngine::RenderGlyphsToSharedTexture_Internal_Injected");
		SetSharedTexture_InjectedDelegateField = IL2CPP.ResolveICall<SetSharedTexture_InjectedDelegate>("UnityEngine.TextCore.LowLevel.FontEngine::SetSharedTexture_Injected");
		TryAddGlyphsToTexture_Internal_MultiThread_InjectedDelegateField = IL2CPP.ResolveICall<TryAddGlyphsToTexture_Internal_MultiThread_InjectedDelegate>("UnityEngine.TextCore.LowLevel.FontEngine::TryAddGlyphsToTexture_Internal_MultiThread_Injected");
		GetOpenTypeLayoutLookups_InjectedDelegateField = IL2CPP.ResolveICall<GetOpenTypeLayoutLookups_InjectedDelegate>("UnityEngine.TextCore.LowLevel.FontEngine::GetOpenTypeLayoutLookups_Injected");
		GetAllSingleSubstitutionRecords_InjectedDelegateField = IL2CPP.ResolveICall<GetAllSingleSubstitutionRecords_InjectedDelegate>("UnityEngine.TextCore.LowLevel.FontEngine::GetAllSingleSubstitutionRecords_Injected");
		PopulateSingleSubstitutionRecordMarshallingArray_from_GlyphIndexes_InjectedDelegateField = IL2CPP.ResolveICall<PopulateSingleSubstitutionRecordMarshallingArray_from_GlyphIndexes_InjectedDelegate>("UnityEngine.TextCore.LowLevel.FontEngine::PopulateSingleSubstitutionRecordMarshallingArray_from_GlyphIndexes_Injected");
		GetSingleSubstitutionRecordsFromMarshallingArray_InjectedDelegateField = IL2CPP.ResolveICall<GetSingleSubstitutionRecordsFromMarshallingArray_InjectedDelegate>("UnityEngine.TextCore.LowLevel.FontEngine::GetSingleSubstitutionRecordsFromMarshallingArray_Injected");
		PopulateMultipleSubstitutionRecordMarshallingArray_from_GlyphIndexes_InjectedDelegateField = IL2CPP.ResolveICall<PopulateMultipleSubstitutionRecordMarshallingArray_from_GlyphIndexes_InjectedDelegate>("UnityEngine.TextCore.LowLevel.FontEngine::PopulateMultipleSubstitutionRecordMarshallingArray_from_GlyphIndexes_Injected");
		PopulateAlternateSubstitutionRecordMarshallingArray_from_GlyphIndexes_InjectedDelegateField = IL2CPP.ResolveICall<PopulateAlternateSubstitutionRecordMarshallingArray_from_GlyphIndexes_InjectedDelegate>("UnityEngine.TextCore.LowLevel.FontEngine::PopulateAlternateSubstitutionRecordMarshallingArray_from_GlyphIndexes_Injected");
		PopulateLigatureSubstitutionRecordMarshallingArray_for_LookupIndex_InjectedDelegateField = IL2CPP.ResolveICall<PopulateLigatureSubstitutionRecordMarshallingArray_for_LookupIndex_InjectedDelegate>("UnityEngine.TextCore.LowLevel.FontEngine::PopulateLigatureSubstitutionRecordMarshallingArray_for_LookupIndex_Injected");
		PopulateContextualSubstitutionRecordMarshallingArray_from_GlyphIndexes_InjectedDelegateField = IL2CPP.ResolveICall<PopulateContextualSubstitutionRecordMarshallingArray_from_GlyphIndexes_InjectedDelegate>("UnityEngine.TextCore.LowLevel.FontEngine::PopulateContextualSubstitutionRecordMarshallingArray_from_GlyphIndexes_Injected");
		PopulateChainingContextualSubstitutionRecordMarshallingArray_from_GlyphIndexes_InjectedDelegateField = IL2CPP.ResolveICall<PopulateChainingContextualSubstitutionRecordMarshallingArray_from_GlyphIndexes_InjectedDelegate>("UnityEngine.TextCore.LowLevel.FontEngine::PopulateChainingContextualSubstitutionRecordMarshallingArray_from_GlyphIndexes_Injected");
		PopulatePairAdjustmentRecordMarshallingArray_for_NewlyAddedGlyphIndexes_InjectedDelegateField = IL2CPP.ResolveICall<PopulatePairAdjustmentRecordMarshallingArray_for_NewlyAddedGlyphIndexes_InjectedDelegate>("UnityEngine.TextCore.LowLevel.FontEngine::PopulatePairAdjustmentRecordMarshallingArray_for_NewlyAddedGlyphIndexes_Injected");
		GetGlyphPairAdjustmentRecord_InjectedDelegateField = IL2CPP.ResolveICall<GetGlyphPairAdjustmentRecord_InjectedDelegate>("UnityEngine.TextCore.LowLevel.FontEngine::GetGlyphPairAdjustmentRecord_Injected");
		PopulateSingleAdjustmentRecordMarshallingArray_from_GlyphIndexes_InjectedDelegateField = IL2CPP.ResolveICall<PopulateSingleAdjustmentRecordMarshallingArray_from_GlyphIndexes_InjectedDelegate>("UnityEngine.TextCore.LowLevel.FontEngine::PopulateSingleAdjustmentRecordMarshallingArray_from_GlyphIndexes_Injected");
		GetSingleAdjustmentRecordsFromMarshallingArray_InjectedDelegateField = IL2CPP.ResolveICall<GetSingleAdjustmentRecordsFromMarshallingArray_InjectedDelegate>("UnityEngine.TextCore.LowLevel.FontEngine::GetSingleAdjustmentRecordsFromMarshallingArray_Injected");
		GetPairAdjustmentRecords_InjectedDelegateField = IL2CPP.ResolveICall<GetPairAdjustmentRecords_InjectedDelegate>("UnityEngine.TextCore.LowLevel.FontEngine::GetPairAdjustmentRecords_Injected");
		GetPairAdjustmentRecord_InjectedDelegateField = IL2CPP.ResolveICall<GetPairAdjustmentRecord_InjectedDelegate>("UnityEngine.TextCore.LowLevel.FontEngine::GetPairAdjustmentRecord_Injected");
		PopulatePairAdjustmentRecordMarshallingArray_for_LookupIndex_InjectedDelegateField = IL2CPP.ResolveICall<PopulatePairAdjustmentRecordMarshallingArray_for_LookupIndex_InjectedDelegate>("UnityEngine.TextCore.LowLevel.FontEngine::PopulatePairAdjustmentRecordMarshallingArray_for_LookupIndex_Injected");
		GetMarkToBaseAdjustmentRecords_InjectedDelegateField = IL2CPP.ResolveICall<GetMarkToBaseAdjustmentRecords_InjectedDelegate>("UnityEngine.TextCore.LowLevel.FontEngine::GetMarkToBaseAdjustmentRecords_Injected");
		GetMarkToBaseAdjustmentRecord_InjectedDelegateField = IL2CPP.ResolveICall<GetMarkToBaseAdjustmentRecord_InjectedDelegate>("UnityEngine.TextCore.LowLevel.FontEngine::GetMarkToBaseAdjustmentRecord_Injected");
		PopulateMarkToBaseAdjustmentRecordMarshallingArray_for_LookupIndex_InjectedDelegateField = IL2CPP.ResolveICall<PopulateMarkToBaseAdjustmentRecordMarshallingArray_for_LookupIndex_InjectedDelegate>("UnityEngine.TextCore.LowLevel.FontEngine::PopulateMarkToBaseAdjustmentRecordMarshallingArray_for_LookupIndex_Injected");
		GetMarkToMarkAdjustmentRecords_InjectedDelegateField = IL2CPP.ResolveICall<GetMarkToMarkAdjustmentRecords_InjectedDelegate>("UnityEngine.TextCore.LowLevel.FontEngine::GetMarkToMarkAdjustmentRecords_Injected");
		GetMarkToMarkAdjustmentRecord_InjectedDelegateField = IL2CPP.ResolveICall<GetMarkToMarkAdjustmentRecord_InjectedDelegate>("UnityEngine.TextCore.LowLevel.FontEngine::GetMarkToMarkAdjustmentRecord_Injected");
		PopulateMarkToMarkAdjustmentRecordMarshallingArray_for_LookupIndex_InjectedDelegateField = IL2CPP.ResolveICall<PopulateMarkToMarkAdjustmentRecordMarshallingArray_for_LookupIndex_InjectedDelegate>("UnityEngine.TextCore.LowLevel.FontEngine::PopulateMarkToMarkAdjustmentRecordMarshallingArray_for_LookupIndex_Injected");
		RenderBufferToTexture_InjectedDelegateField = IL2CPP.ResolveICall<RenderBufferToTexture_InjectedDelegate>("UnityEngine.TextCore.LowLevel.FontEngine::RenderBufferToTexture_Injected");
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1272720, RefRangeEnd = 1272721, XrefRangeStart = 1272716, XrefRangeEnd = 1272720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static FontEngineError LoadFontFace(string filePath)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(filePath);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LoadFontFace_Public_Static_FontEngineError_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(FontEngineError*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1272738, RefRangeEnd = 1272739, XrefRangeStart = 1272721, XrefRangeEnd = 1272738, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int LoadFontFace_Internal(string filePath)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(filePath);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LoadFontFace_Internal_Private_Static_Int32_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 1272750, RefRangeEnd = 1272754, XrefRangeStart = 1272739, XrefRangeEnd = 1272750, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static FontEngineError LoadFontFace(string filePath, float pointSize, int faceIndex)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(filePath);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &pointSize;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &faceIndex;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LoadFontFace_Public_Static_FontEngineError_String_Single_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(FontEngineError*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1272771, RefRangeEnd = 1272772, XrefRangeStart = 1272754, XrefRangeEnd = 1272771, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int LoadFontFace_With_Size_And_FaceIndex_Internal(string filePath, int pointSize, int faceIndex)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(filePath);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &pointSize;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &faceIndex;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LoadFontFace_With_Size_And_FaceIndex_Internal_Private_Static_Int32_String_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 1272790, RefRangeEnd = 1272797, XrefRangeStart = 1272772, XrefRangeEnd = 1272790, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static FontEngineError LoadFontFace(Font font, float pointSize, int faceIndex)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)font);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &pointSize;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &faceIndex;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LoadFontFace_Public_Static_FontEngineError_Font_Single_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(FontEngineError*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1272797, XrefRangeEnd = 1272805, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int LoadFontFace_With_Size_and_FaceIndex_FromFont_Internal(Font font, int pointSize, int faceIndex)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)font);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &pointSize;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &faceIndex;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LoadFontFace_With_Size_and_FaceIndex_FromFont_Internal_Private_Static_Int32_Font_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1272816, RefRangeEnd = 1272818, XrefRangeStart = 1272805, XrefRangeEnd = 1272816, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static FontEngineError LoadFontFace(string familyName, string styleName, float pointSize)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(familyName);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(styleName);
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &pointSize;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LoadFontFace_Public_Static_FontEngineError_String_String_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(FontEngineError*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1272844, RefRangeEnd = 1272845, XrefRangeStart = 1272818, XrefRangeEnd = 1272844, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int LoadFontFace_With_Size_by_FamilyName_and_StyleName_Internal(string familyName, string styleName, int pointSize)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(familyName);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(styleName);
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &pointSize;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LoadFontFace_With_Size_by_FamilyName_and_StyleName_Internal_Private_Static_Int32_String_String_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1272888, RefRangeEnd = 1272889, XrefRangeStart = 1272845, XrefRangeEnd = 1272888, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static FontEngineError UnloadFontFace()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UnloadFontFace_Public_Static_FontEngineError_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(FontEngineError*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1272889, XrefRangeEnd = 1272891, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int UnloadFontFace_Internal()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UnloadFontFace_Internal_Private_Static_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1272893, RefRangeEnd = 1272894, XrefRangeStart = 1272891, XrefRangeEnd = 1272893, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool IsColorFontFace()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsColorFontFace_Internal_Static_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 1272898, RefRangeEnd = 1272903, XrefRangeStart = 1272894, XrefRangeEnd = 1272898, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool TryGetSystemFontReference(string familyName, string styleName, out FontReference fontRef)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(familyName);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(styleName);
		byte* num = (byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)));
		nint num2 = 0;
		*(nint**)num = &num2;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TryGetSystemFontReference_Internal_Static_Boolean_String_String_byref_FontReference_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		nint num3 = num2;
		fontRef = ((num3 == 0) ? null : new FontReference(num3));
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1272929, RefRangeEnd = 1272930, XrefRangeStart = 1272903, XrefRangeEnd = 1272929, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool TryGetSystemFontReference_Internal(string familyName, string styleName, out FontReference fontRef)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(familyName);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(styleName);
		byte* num = (byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)));
		nint num2 = 0;
		*(nint**)num = &num2;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TryGetSystemFontReference_Internal_Private_Static_Boolean_String_String_byref_FontReference_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		nint num3 = num2;
		fontRef = ((num3 == 0) ? null : new FontReference(num3));
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1272935, RefRangeEnd = 1272937, XrefRangeStart = 1272930, XrefRangeEnd = 1272935, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static FaceInfo GetFaceInfo()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetFaceInfo_Public_Static_FaceInfo_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return new FaceInfo(pointer);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1272937, XrefRangeEnd = 1272939, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int GetFaceInfo_Internal(ref FaceInfo faceInfo)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)faceInfo);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetFaceInfo_Internal_Private_Static_Int32_byref_FaceInfo_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1272944, RefRangeEnd = 1272945, XrefRangeStart = 1272939, XrefRangeEnd = 1272944, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppStringArray GetFontFaces()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetFontFaces_Public_Static_Il2CppStringArray_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1272945, XrefRangeEnd = 1272947, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppStringArray GetFontFaces_Internal()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetFontFaces_Internal_Private_Static_Il2CppStringArray_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1272949, RefRangeEnd = 1272951, XrefRangeStart = 1272947, XrefRangeEnd = 1272949, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static uint GetVariantGlyphIndex(uint unicode, uint variantSelectorUnicode)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&unicode);
		*(uint**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &variantSelectorUnicode;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetVariantGlyphIndex_Internal_Static_UInt32_UInt32_UInt32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(uint*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(19)]
	[CachedScanResults(RefRangeStart = 1272953, RefRangeEnd = 1272972, XrefRangeStart = 1272951, XrefRangeEnd = 1272953, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static uint GetGlyphIndex(uint unicode)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&unicode);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetGlyphIndex_Internal_Static_UInt32_UInt32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(uint*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1272983, RefRangeEnd = 1272985, XrefRangeStart = 1272972, XrefRangeEnd = 1272983, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool TryGetGlyphWithUnicodeValue(uint unicode, GlyphLoadFlags flags, out Glyph glyph)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&unicode);
		*(GlyphLoadFlags**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &flags;
		byte* num = (byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)));
		nint num2 = 0;
		*(nint**)num = &num2;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TryGetGlyphWithUnicodeValue_Public_Static_Boolean_UInt32_GlyphLoadFlags_byref_Glyph_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		nint num3 = num2;
		glyph = ((num3 == 0) ? null : new Glyph(num3));
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1272985, XrefRangeEnd = 1272987, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool TryGetGlyphWithUnicodeValue_Internal(uint unicode, GlyphLoadFlags loadFlags, ref GlyphMarshallingStruct glyphStruct)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&unicode);
		*(GlyphLoadFlags**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &loadFlags;
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref glyphStruct);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TryGetGlyphWithUnicodeValue_Internal_Private_Static_Boolean_UInt32_GlyphLoadFlags_byref_GlyphMarshallingStruct_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1272998, RefRangeEnd = 1272999, XrefRangeStart = 1272987, XrefRangeEnd = 1272998, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool TryGetGlyphWithIndexValue(uint glyphIndex, GlyphLoadFlags flags, out Glyph glyph)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&glyphIndex);
		*(GlyphLoadFlags**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &flags;
		byte* num = (byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)));
		nint num2 = 0;
		*(nint**)num = &num2;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TryGetGlyphWithIndexValue_Public_Static_Boolean_UInt32_GlyphLoadFlags_byref_Glyph_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		nint num3 = num2;
		glyph = ((num3 == 0) ? null : new Glyph(num3));
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1272999, XrefRangeEnd = 1273001, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool TryGetGlyphWithIndexValue_Internal(uint glyphIndex, GlyphLoadFlags loadFlags, ref GlyphMarshallingStruct glyphStruct)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&glyphIndex);
		*(GlyphLoadFlags**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &loadFlags;
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref glyphStruct);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TryGetGlyphWithIndexValue_Internal_Private_Static_Boolean_UInt32_GlyphLoadFlags_byref_GlyphMarshallingStruct_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1273003, RefRangeEnd = 1273005, XrefRangeStart = 1273001, XrefRangeEnd = 1273003, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetTextureUploadMode(bool shouldUploadImmediately)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&shouldUploadImmediately);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetTextureUploadMode_Internal_Static_Void_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1273044, RefRangeEnd = 1273047, XrefRangeStart = 1273005, XrefRangeEnd = 1273044, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool TryAddGlyphToTexture(uint glyphIndex, int padding, GlyphPackingMode packingMode, List<GlyphRect> freeGlyphRects, List<GlyphRect> usedGlyphRects, GlyphRenderMode renderMode, Texture2D texture, out Glyph glyph)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[8];
		*ptr = (nint)(&glyphIndex);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &padding;
		*(GlyphPackingMode**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &packingMode;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)freeGlyphRects);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)usedGlyphRects);
		*(GlyphRenderMode**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &renderMode;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)texture);
		byte* num = (byte*)ptr + checked((nuint)7u * unchecked((nuint)sizeof(System.IntPtr)));
		nint num2 = 0;
		*(nint**)num = &num2;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TryAddGlyphToTexture_Internal_Static_Boolean_UInt32_Int32_GlyphPackingMode_List_1_GlyphRect_List_1_GlyphRect_GlyphRenderMode_Texture2D_byref_Glyph_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		nint num3 = num2;
		glyph = ((num3 == 0) ? null : new Glyph(num3));
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1273062, RefRangeEnd = 1273063, XrefRangeStart = 1273047, XrefRangeEnd = 1273062, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool TryAddGlyphToTexture_Internal(uint glyphIndex, int padding, GlyphPackingMode packingMode, [Out] Il2CppStructArray<GlyphRect> freeGlyphRects, ref int freeGlyphRectCount, [Out] Il2CppStructArray<GlyphRect> usedGlyphRects, ref int usedGlyphRectCount, GlyphRenderMode renderMode, Texture2D texture, out GlyphMarshallingStruct glyph)
	{
		//IL_00c5: Expected native int or pointer, but got O
		//IL_00d7: Expected native int or pointer, but got O
		System.IntPtr* ptr = stackalloc System.IntPtr[10];
		*ptr = (nint)(&glyphIndex);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &padding;
		*(GlyphPackingMode**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &packingMode;
		byte* num = (byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)));
		nint num2 = 0;
		*(nint**)num = &num2;
		*(void**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref freeGlyphRectCount);
		byte* num3 = (byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)));
		nint num4 = 0;
		*(nint**)num3 = &num4;
		*(void**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref usedGlyphRectCount);
		*(GlyphRenderMode**)((byte*)ptr + checked((nuint)7u * unchecked((nuint)sizeof(System.IntPtr)))) = &renderMode;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)8u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)texture);
		*(void**)((byte*)ptr + checked((nuint)9u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref glyph);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TryAddGlyphToTexture_Internal_Private_Static_Boolean_UInt32_Int32_GlyphPackingMode_Il2CppStructArray_1_GlyphRect_byref_Int32_Il2CppStructArray_1_GlyphRect_byref_Int32_GlyphRenderMode_Texture2D_byref_GlyphMarshallingStruct_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		nint num5 = num2;
		Unsafe.Write((void*)(nint)freeGlyphRects, (num5 == 0) ? null : new Il2CppStructArray<GlyphRect>((System.IntPtr)num5));
		nint num6 = num4;
		Unsafe.Write((void*)(nint)usedGlyphRects, (num6 == 0) ? null : new Il2CppStructArray<GlyphRect>((System.IntPtr)num6));
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 1273176, RefRangeEnd = 1273181, XrefRangeStart = 1273063, XrefRangeEnd = 1273176, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool TryAddGlyphsToTexture(List<uint> glyphIndexes, int padding, GlyphPackingMode packingMode, List<GlyphRect> freeGlyphRects, List<GlyphRect> usedGlyphRects, GlyphRenderMode renderMode, Texture2D texture, out Il2CppReferenceArray<Glyph> glyphs)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[8];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)glyphIndexes);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &padding;
		*(GlyphPackingMode**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &packingMode;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)freeGlyphRects);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)usedGlyphRects);
		*(GlyphRenderMode**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &renderMode;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)texture);
		byte* num = (byte*)ptr + checked((nuint)7u * unchecked((nuint)sizeof(System.IntPtr)));
		nint num2 = 0;
		*(nint**)num = &num2;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TryAddGlyphsToTexture_Internal_Static_Boolean_List_1_UInt32_Int32_GlyphPackingMode_List_1_GlyphRect_List_1_GlyphRect_GlyphRenderMode_Texture2D_byref_Il2CppReferenceArray_1_Glyph_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		nint num3 = num2;
		glyphs = ((num3 == 0) ? null : new Il2CppReferenceArray<Glyph>((System.IntPtr)num3));
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1273202, RefRangeEnd = 1273203, XrefRangeStart = 1273181, XrefRangeEnd = 1273202, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool TryAddGlyphsToTexture_Internal(Il2CppStructArray<uint> glyphIndex, int padding, GlyphPackingMode packingMode, [Out] Il2CppStructArray<GlyphRect> freeGlyphRects, ref int freeGlyphRectCount, [Out] Il2CppStructArray<GlyphRect> usedGlyphRects, ref int usedGlyphRectCount, GlyphRenderMode renderMode, Texture2D texture, [Out] Il2CppStructArray<GlyphMarshallingStruct> glyphs, ref int glyphCount)
	{
		//IL_00dc: Expected native int or pointer, but got O
		//IL_00ee: Expected native int or pointer, but got O
		//IL_0100: Expected native int or pointer, but got O
		System.IntPtr* ptr = stackalloc System.IntPtr[11];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)glyphIndex);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &padding;
		*(GlyphPackingMode**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &packingMode;
		byte* num = (byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)));
		nint num2 = 0;
		*(nint**)num = &num2;
		*(void**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref freeGlyphRectCount);
		byte* num3 = (byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)));
		nint num4 = 0;
		*(nint**)num3 = &num4;
		*(void**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref usedGlyphRectCount);
		*(GlyphRenderMode**)((byte*)ptr + checked((nuint)7u * unchecked((nuint)sizeof(System.IntPtr)))) = &renderMode;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)8u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)texture);
		byte* num5 = (byte*)ptr + checked((nuint)9u * unchecked((nuint)sizeof(System.IntPtr)));
		nint num6 = 0;
		*(nint**)num5 = &num6;
		*(void**)((byte*)ptr + checked((nuint)10u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref glyphCount);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TryAddGlyphsToTexture_Internal_Private_Static_Boolean_Il2CppStructArray_1_UInt32_Int32_GlyphPackingMode_Il2CppStructArray_1_GlyphRect_byref_Int32_Il2CppStructArray_1_GlyphRect_byref_Int32_GlyphRenderMode_Texture2D_Il2CppStructArray_1_GlyphMarshallingStruct_byref_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		nint num7 = num2;
		Unsafe.Write((void*)(nint)freeGlyphRects, (num7 == 0) ? null : new Il2CppStructArray<GlyphRect>((System.IntPtr)num7));
		nint num8 = num4;
		Unsafe.Write((void*)(nint)usedGlyphRects, (num8 == 0) ? null : new Il2CppStructArray<GlyphRect>((System.IntPtr)num8));
		nint num9 = num6;
		Unsafe.Write((void*)(nint)glyphs, (num9 == 0) ? null : new Il2CppStructArray<GlyphMarshallingStruct>((System.IntPtr)num9));
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 1273205, RefRangeEnd = 1273210, XrefRangeStart = 1273203, XrefRangeEnd = 1273205, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppReferenceArray<LigatureSubstitutionRecord> GetAllLigatureSubstitutionRecords()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetAllLigatureSubstitutionRecords_Internal_Static_Il2CppReferenceArray_1_LigatureSubstitutionRecord_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<LigatureSubstitutionRecord>>(intPtr2) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1273222, RefRangeEnd = 1273224, XrefRangeStart = 1273210, XrefRangeEnd = 1273222, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppReferenceArray<LigatureSubstitutionRecord> GetLigatureSubstitutionRecords(uint glyphIndex)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&glyphIndex);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetLigatureSubstitutionRecords_Internal_Static_Il2CppReferenceArray_1_LigatureSubstitutionRecord_UInt32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<LigatureSubstitutionRecord>>(intPtr2) : null;
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 1273233, RefRangeEnd = 1273238, XrefRangeStart = 1273224, XrefRangeEnd = 1273233, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppReferenceArray<LigatureSubstitutionRecord> GetLigatureSubstitutionRecords(List<uint> glyphIndexes)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)glyphIndexes);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetLigatureSubstitutionRecords_Internal_Static_Il2CppReferenceArray_1_LigatureSubstitutionRecord_List_1_UInt32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<LigatureSubstitutionRecord>>(intPtr2) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1273264, RefRangeEnd = 1273266, XrefRangeStart = 1273238, XrefRangeEnd = 1273264, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppReferenceArray<LigatureSubstitutionRecord> GetLigatureSubstitutionRecords(Il2CppStructArray<uint> glyphIndexes)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)glyphIndexes);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetLigatureSubstitutionRecords_Private_Static_Il2CppReferenceArray_1_LigatureSubstitutionRecord_Il2CppStructArray_1_UInt32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<LigatureSubstitutionRecord>>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1273266, XrefRangeEnd = 1273278, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int PopulateLigatureSubstitutionRecordMarshallingArray(Il2CppStructArray<uint> glyphIndexes, out int recordCount)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)glyphIndexes);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref recordCount);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PopulateLigatureSubstitutionRecordMarshallingArray_Private_Static_Int32_Il2CppStructArray_1_UInt32_byref_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1273278, XrefRangeEnd = 1273280, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int GetLigatureSubstitutionRecordsFromMarshallingArray([Out] Il2CppReferenceArray<LigatureSubstitutionRecord> ligatureSubstitutionRecords)
	{
		//IL_0039: Expected native int or pointer, but got O
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		nint num = 0;
		*ptr = (nint)(&num);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetLigatureSubstitutionRecordsFromMarshallingArray_Private_Static_Int32_Il2CppReferenceArray_1_LigatureSubstitutionRecord_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		nint num2 = num;
		Unsafe.Write((void*)(nint)ligatureSubstitutionRecords, (num2 == 0) ? null : new Il2CppReferenceArray<LigatureSubstitutionRecord>((System.IntPtr)num2));
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1273308, RefRangeEnd = 1273309, XrefRangeStart = 1273280, XrefRangeEnd = 1273308, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppStructArray<GlyphPairAdjustmentRecord> GetGlyphPairAdjustmentTable(Il2CppStructArray<uint> glyphIndexes)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)glyphIndexes);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetGlyphPairAdjustmentTable_Internal_Static_Il2CppStructArray_1_GlyphPairAdjustmentRecord_Il2CppStructArray_1_UInt32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<GlyphPairAdjustmentRecord>>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1273309, XrefRangeEnd = 1273321, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int PopulatePairAdjustmentRecordMarshallingArray_from_KernTable(Il2CppStructArray<uint> glyphIndexes, out int recordCount)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)glyphIndexes);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref recordCount);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PopulatePairAdjustmentRecordMarshallingArray_from_KernTable_Private_Static_Int32_Il2CppStructArray_1_UInt32_byref_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 1273330, RefRangeEnd = 1273335, XrefRangeStart = 1273321, XrefRangeEnd = 1273330, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppStructArray<GlyphPairAdjustmentRecord> GetAllPairAdjustmentRecords()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetAllPairAdjustmentRecords_Internal_Static_Il2CppStructArray_1_GlyphPairAdjustmentRecord_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<GlyphPairAdjustmentRecord>>(intPtr2) : null;
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 1273344, RefRangeEnd = 1273349, XrefRangeStart = 1273335, XrefRangeEnd = 1273344, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppStructArray<GlyphPairAdjustmentRecord> GetPairAdjustmentRecords(List<uint> glyphIndexes)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)glyphIndexes);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetPairAdjustmentRecords_Internal_Static_Il2CppStructArray_1_GlyphPairAdjustmentRecord_List_1_UInt32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<GlyphPairAdjustmentRecord>>(intPtr2) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1273377, RefRangeEnd = 1273378, XrefRangeStart = 1273349, XrefRangeEnd = 1273377, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppStructArray<GlyphPairAdjustmentRecord> GetPairAdjustmentRecords(Il2CppStructArray<uint> glyphIndexes)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)glyphIndexes);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetPairAdjustmentRecords_Private_Static_Il2CppStructArray_1_GlyphPairAdjustmentRecord_Il2CppStructArray_1_UInt32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<GlyphPairAdjustmentRecord>>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1273378, XrefRangeEnd = 1273390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int PopulatePairAdjustmentRecordMarshallingArray(Il2CppStructArray<uint> glyphIndexes, out int recordCount)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)glyphIndexes);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref recordCount);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PopulatePairAdjustmentRecordMarshallingArray_Private_Static_Int32_Il2CppStructArray_1_UInt32_byref_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1273400, RefRangeEnd = 1273402, XrefRangeStart = 1273390, XrefRangeEnd = 1273400, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int GetPairAdjustmentRecordsFromMarshallingArray(Il2CppSystem.Span<GlyphPairAdjustmentRecord> glyphPairAdjustmentRecords)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)glyphPairAdjustmentRecords));
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetPairAdjustmentRecordsFromMarshallingArray_Private_Static_Int32_Span_1_GlyphPairAdjustmentRecord_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 1273411, RefRangeEnd = 1273416, XrefRangeStart = 1273402, XrefRangeEnd = 1273411, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppStructArray<MarkToBaseAdjustmentRecord> GetAllMarkToBaseAdjustmentRecords()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetAllMarkToBaseAdjustmentRecords_Internal_Static_Il2CppStructArray_1_MarkToBaseAdjustmentRecord_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<MarkToBaseAdjustmentRecord>>(intPtr2) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1273425, RefRangeEnd = 1273427, XrefRangeStart = 1273416, XrefRangeEnd = 1273425, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppStructArray<MarkToBaseAdjustmentRecord> GetMarkToBaseAdjustmentRecords(List<uint> glyphIndexes)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)glyphIndexes);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetMarkToBaseAdjustmentRecords_Internal_Static_Il2CppStructArray_1_MarkToBaseAdjustmentRecord_List_1_UInt32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<MarkToBaseAdjustmentRecord>>(intPtr2) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1273464, RefRangeEnd = 1273465, XrefRangeStart = 1273427, XrefRangeEnd = 1273464, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppStructArray<MarkToBaseAdjustmentRecord> GetMarkToBaseAdjustmentRecords(Il2CppStructArray<uint> glyphIndexes)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)glyphIndexes);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetMarkToBaseAdjustmentRecords_Private_Static_Il2CppStructArray_1_MarkToBaseAdjustmentRecord_Il2CppStructArray_1_UInt32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<MarkToBaseAdjustmentRecord>>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1273465, XrefRangeEnd = 1273477, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int PopulateMarkToBaseAdjustmentRecordMarshallingArray(Il2CppStructArray<uint> glyphIndexes, out int recordCount)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)glyphIndexes);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref recordCount);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PopulateMarkToBaseAdjustmentRecordMarshallingArray_Private_Static_Int32_Il2CppStructArray_1_UInt32_byref_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1273477, XrefRangeEnd = 1273487, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int GetMarkToBaseAdjustmentRecordsFromMarshallingArray(Il2CppSystem.Span<MarkToBaseAdjustmentRecord> adjustmentRecords)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)adjustmentRecords));
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetMarkToBaseAdjustmentRecordsFromMarshallingArray_Private_Static_Int32_Span_1_MarkToBaseAdjustmentRecord_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 1273496, RefRangeEnd = 1273501, XrefRangeStart = 1273487, XrefRangeEnd = 1273496, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppStructArray<MarkToMarkAdjustmentRecord> GetAllMarkToMarkAdjustmentRecords()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetAllMarkToMarkAdjustmentRecords_Internal_Static_Il2CppStructArray_1_MarkToMarkAdjustmentRecord_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<MarkToMarkAdjustmentRecord>>(intPtr2) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1273510, RefRangeEnd = 1273512, XrefRangeStart = 1273501, XrefRangeEnd = 1273510, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppStructArray<MarkToMarkAdjustmentRecord> GetMarkToMarkAdjustmentRecords(List<uint> glyphIndexes)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)glyphIndexes);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetMarkToMarkAdjustmentRecords_Internal_Static_Il2CppStructArray_1_MarkToMarkAdjustmentRecord_List_1_UInt32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<MarkToMarkAdjustmentRecord>>(intPtr2) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1273550, RefRangeEnd = 1273551, XrefRangeStart = 1273512, XrefRangeEnd = 1273550, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppStructArray<MarkToMarkAdjustmentRecord> GetMarkToMarkAdjustmentRecords(Il2CppStructArray<uint> glyphIndexes)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)glyphIndexes);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetMarkToMarkAdjustmentRecords_Private_Static_Il2CppStructArray_1_MarkToMarkAdjustmentRecord_Il2CppStructArray_1_UInt32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<MarkToMarkAdjustmentRecord>>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1273551, XrefRangeEnd = 1273563, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int PopulateMarkToMarkAdjustmentRecordMarshallingArray(Il2CppStructArray<uint> glyphIndexes, out int recordCount)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)glyphIndexes);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref recordCount);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PopulateMarkToMarkAdjustmentRecordMarshallingArray_Private_Static_Int32_Il2CppStructArray_1_UInt32_byref_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1273563, XrefRangeEnd = 1273573, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int GetMarkToMarkAdjustmentRecordsFromMarshallingArray(Il2CppSystem.Span<MarkToMarkAdjustmentRecord> adjustmentRecords)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)adjustmentRecords));
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetMarkToMarkAdjustmentRecordsFromMarshallingArray_Private_Static_Int32_Span_1_MarkToMarkAdjustmentRecord_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1273573, XrefRangeEnd = 1273577, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void GlyphIndexToMarshallingArray(uint glyphIndex, ref Il2CppStructArray<uint> dstArray)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&glyphIndex);
		byte* num = (byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)));
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dstArray);
		*(System.IntPtr**)num = &intPtr;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GlyphIndexToMarshallingArray_Private_Static_Void_UInt32_byref_Il2CppStructArray_1_UInt32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		System.IntPtr intPtr4 = intPtr;
		dstArray = ((intPtr4 == (System.IntPtr)0) ? null : new Il2CppStructArray<uint>(intPtr4));
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 1273584, RefRangeEnd = 1273588, XrefRangeStart = 1273577, XrefRangeEnd = 1273584, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void GenericListToMarshallingArray<T>(ref List<T> srcList, ref Il2CppArrayBase<T> dstArray)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)srcList);
		*ptr = (nint)(&intPtr);
		byte* num = (byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)));
		System.IntPtr intPtr2 = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dstArray);
		*(System.IntPtr**)num = &intPtr2;
		Unsafe.SkipInit(out System.IntPtr intPtr3);
		System.IntPtr intPtr4 = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_GenericListToMarshallingArray_Private_Static_Void_byref_List_1_T_byref_Il2CppArrayBase_1_T_0<T>.Pointer, (System.IntPtr)0, (void**)ptr, ref intPtr3);
		Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		System.IntPtr intPtr5 = intPtr;
		srcList = ((intPtr5 == (System.IntPtr)0) ? null : new List<T>(intPtr5));
		System.IntPtr intPtr6 = intPtr2;
		dstArray = ((intPtr6 == (System.IntPtr)0) ? null : new Il2CppArrayBase<T>(intPtr6));
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 1273593, RefRangeEnd = 1273598, XrefRangeStart = 1273588, XrefRangeEnd = 1273593, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetMarshallingArraySize<T>(ref Il2CppArrayBase<T> marshallingArray, int recordCount)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)marshallingArray);
		*ptr = (nint)(&intPtr);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &recordCount;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_SetMarshallingArraySize_Private_Static_Void_byref_Il2CppArrayBase_1_T_Int32_0<T>.Pointer, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		System.IntPtr intPtr4 = intPtr;
		marshallingArray = ((intPtr4 == (System.IntPtr)0) ? null : new Il2CppArrayBase<T>(intPtr4));
	}

	[CallerCount(10)]
	[CachedScanResults(RefRangeStart = 1273606, RefRangeEnd = 1273616, XrefRangeStart = 1273598, XrefRangeEnd = 1273606, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ResetAtlasTexture(Texture2D texture)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)texture);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ResetAtlasTexture_Internal_Static_Void_Texture2D_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1273616, XrefRangeEnd = 1273618, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int LoadFontFace_Internal_Injected(ref ManagedSpanWrapper filePath)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)Unsafe.AsPointer(ref filePath);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LoadFontFace_Internal_Injected_Private_Static_Int32_byref_ManagedSpanWrapper_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1273618, XrefRangeEnd = 1273620, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int LoadFontFace_With_Size_And_FaceIndex_Internal_Injected(ref ManagedSpanWrapper filePath, int pointSize, int faceIndex)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)Unsafe.AsPointer(ref filePath);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &pointSize;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &faceIndex;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LoadFontFace_With_Size_And_FaceIndex_Internal_Injected_Private_Static_Int32_byref_ManagedSpanWrapper_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1273620, XrefRangeEnd = 1273622, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int LoadFontFace_With_Size_and_FaceIndex_FromFont_Internal_Injected(System.IntPtr font, int pointSize, int faceIndex)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&font);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &pointSize;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &faceIndex;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LoadFontFace_With_Size_and_FaceIndex_FromFont_Internal_Injected_Private_Static_Int32_IntPtr_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1273622, XrefRangeEnd = 1273624, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int LoadFontFace_With_Size_by_FamilyName_and_StyleName_Internal_Injected(ref ManagedSpanWrapper familyName, ref ManagedSpanWrapper styleName, int pointSize)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)Unsafe.AsPointer(ref familyName);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref styleName);
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &pointSize;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LoadFontFace_With_Size_by_FamilyName_and_StyleName_Internal_Injected_Private_Static_Int32_byref_ManagedSpanWrapper_byref_ManagedSpanWrapper_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1273624, XrefRangeEnd = 1273626, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool TryGetSystemFontReference_Internal_Injected(ref ManagedSpanWrapper familyName, ref ManagedSpanWrapper styleName, out FontReference fontRef)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)Unsafe.AsPointer(ref familyName);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref styleName);
		byte* num = (byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)));
		nint num2 = 0;
		*(nint**)num = &num2;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TryGetSystemFontReference_Internal_Injected_Private_Static_Boolean_byref_ManagedSpanWrapper_byref_ManagedSpanWrapper_byref_FontReference_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		nint num3 = num2;
		fontRef = ((num3 == 0) ? null : new FontReference(num3));
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1273626, XrefRangeEnd = 1273628, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool TryAddGlyphToTexture_Internal_Injected(uint glyphIndex, int padding, GlyphPackingMode packingMode, out BlittableArrayWrapper freeGlyphRects, ref int freeGlyphRectCount, out BlittableArrayWrapper usedGlyphRects, ref int usedGlyphRectCount, GlyphRenderMode renderMode, System.IntPtr texture, out GlyphMarshallingStruct glyph)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[10];
		*ptr = (nint)(&glyphIndex);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &padding;
		*(GlyphPackingMode**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &packingMode;
		*(void**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref freeGlyphRects);
		*(void**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref freeGlyphRectCount);
		*(void**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref usedGlyphRects);
		*(void**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref usedGlyphRectCount);
		*(GlyphRenderMode**)((byte*)ptr + checked((nuint)7u * unchecked((nuint)sizeof(System.IntPtr)))) = &renderMode;
		*(System.IntPtr**)((byte*)ptr + checked((nuint)8u * unchecked((nuint)sizeof(System.IntPtr)))) = &texture;
		*(void**)((byte*)ptr + checked((nuint)9u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref glyph);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TryAddGlyphToTexture_Internal_Injected_Private_Static_Boolean_UInt32_Int32_GlyphPackingMode_byref_BlittableArrayWrapper_byref_Int32_byref_BlittableArrayWrapper_byref_Int32_GlyphRenderMode_IntPtr_byref_GlyphMarshallingStruct_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1273628, XrefRangeEnd = 1273630, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool TryAddGlyphsToTexture_Internal_Injected(ref ManagedSpanWrapper glyphIndex, int padding, GlyphPackingMode packingMode, out BlittableArrayWrapper freeGlyphRects, ref int freeGlyphRectCount, out BlittableArrayWrapper usedGlyphRects, ref int usedGlyphRectCount, GlyphRenderMode renderMode, System.IntPtr texture, out BlittableArrayWrapper glyphs, ref int glyphCount)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[11];
		*ptr = (nint)Unsafe.AsPointer(ref glyphIndex);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &padding;
		*(GlyphPackingMode**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &packingMode;
		*(void**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref freeGlyphRects);
		*(void**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref freeGlyphRectCount);
		*(void**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref usedGlyphRects);
		*(void**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref usedGlyphRectCount);
		*(GlyphRenderMode**)((byte*)ptr + checked((nuint)7u * unchecked((nuint)sizeof(System.IntPtr)))) = &renderMode;
		*(System.IntPtr**)((byte*)ptr + checked((nuint)8u * unchecked((nuint)sizeof(System.IntPtr)))) = &texture;
		*(void**)((byte*)ptr + checked((nuint)9u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref glyphs);
		*(void**)((byte*)ptr + checked((nuint)10u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref glyphCount);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TryAddGlyphsToTexture_Internal_Injected_Private_Static_Boolean_byref_ManagedSpanWrapper_Int32_GlyphPackingMode_byref_BlittableArrayWrapper_byref_Int32_byref_BlittableArrayWrapper_byref_Int32_GlyphRenderMode_IntPtr_byref_BlittableArrayWrapper_byref_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1273630, XrefRangeEnd = 1273632, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int PopulateLigatureSubstitutionRecordMarshallingArray_Injected(ref ManagedSpanWrapper glyphIndexes, out int recordCount)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)Unsafe.AsPointer(ref glyphIndexes);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref recordCount);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PopulateLigatureSubstitutionRecordMarshallingArray_Injected_Private_Static_Int32_byref_ManagedSpanWrapper_byref_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1273632, XrefRangeEnd = 1273634, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int PopulatePairAdjustmentRecordMarshallingArray_from_KernTable_Injected(ref ManagedSpanWrapper glyphIndexes, out int recordCount)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)Unsafe.AsPointer(ref glyphIndexes);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref recordCount);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PopulatePairAdjustmentRecordMarshallingArray_from_KernTable_Injected_Private_Static_Int32_byref_ManagedSpanWrapper_byref_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1273634, XrefRangeEnd = 1273636, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void GetAllPairAdjustmentRecords_Injected(out BlittableArrayWrapper ret)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)Unsafe.AsPointer(ref ret);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetAllPairAdjustmentRecords_Injected_Private_Static_Void_byref_BlittableArrayWrapper_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1273636, XrefRangeEnd = 1273638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int PopulatePairAdjustmentRecordMarshallingArray_Injected(ref ManagedSpanWrapper glyphIndexes, out int recordCount)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)Unsafe.AsPointer(ref glyphIndexes);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref recordCount);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PopulatePairAdjustmentRecordMarshallingArray_Injected_Private_Static_Int32_byref_ManagedSpanWrapper_byref_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1273638, XrefRangeEnd = 1273640, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int GetPairAdjustmentRecordsFromMarshallingArray_Injected(ref ManagedSpanWrapper glyphPairAdjustmentRecords)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)Unsafe.AsPointer(ref glyphPairAdjustmentRecords);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetPairAdjustmentRecordsFromMarshallingArray_Injected_Private_Static_Int32_byref_ManagedSpanWrapper_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1273640, XrefRangeEnd = 1273642, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void GetAllMarkToBaseAdjustmentRecords_Injected(out BlittableArrayWrapper ret)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)Unsafe.AsPointer(ref ret);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetAllMarkToBaseAdjustmentRecords_Injected_Private_Static_Void_byref_BlittableArrayWrapper_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1273642, XrefRangeEnd = 1273644, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int PopulateMarkToBaseAdjustmentRecordMarshallingArray_Injected(ref ManagedSpanWrapper glyphIndexes, out int recordCount)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)Unsafe.AsPointer(ref glyphIndexes);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref recordCount);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PopulateMarkToBaseAdjustmentRecordMarshallingArray_Injected_Private_Static_Int32_byref_ManagedSpanWrapper_byref_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1273644, XrefRangeEnd = 1273646, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int GetMarkToBaseAdjustmentRecordsFromMarshallingArray_Injected(ref ManagedSpanWrapper adjustmentRecords)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)Unsafe.AsPointer(ref adjustmentRecords);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetMarkToBaseAdjustmentRecordsFromMarshallingArray_Injected_Private_Static_Int32_byref_ManagedSpanWrapper_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1273646, XrefRangeEnd = 1273648, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void GetAllMarkToMarkAdjustmentRecords_Injected(out BlittableArrayWrapper ret)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)Unsafe.AsPointer(ref ret);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetAllMarkToMarkAdjustmentRecords_Injected_Private_Static_Void_byref_BlittableArrayWrapper_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1273648, XrefRangeEnd = 1273650, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int PopulateMarkToMarkAdjustmentRecordMarshallingArray_Injected(ref ManagedSpanWrapper glyphIndexes, out int recordCount)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)Unsafe.AsPointer(ref glyphIndexes);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref recordCount);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PopulateMarkToMarkAdjustmentRecordMarshallingArray_Injected_Private_Static_Int32_byref_ManagedSpanWrapper_byref_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1273650, XrefRangeEnd = 1273652, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int GetMarkToMarkAdjustmentRecordsFromMarshallingArray_Injected(ref ManagedSpanWrapper adjustmentRecords)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)Unsafe.AsPointer(ref adjustmentRecords);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetMarkToMarkAdjustmentRecordsFromMarshallingArray_Injected_Private_Static_Int32_byref_ManagedSpanWrapper_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1273652, XrefRangeEnd = 1273654, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ResetAtlasTexture_Injected(System.IntPtr texture)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&texture);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ResetAtlasTexture_Injected_Private_Static_Void_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public FontEngine(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public static FontEngineError InitializeFontEngine()
	{
		return (FontEngineError)InitializeFontEngine_Internal();
	}

	public static int InitializeFontEngine_Internal()
	{
		return InitializeFontEngine_InternalDelegateField();
	}

	public static FontEngineError DestroyFontEngine()
	{
		return (FontEngineError)DestroyFontEngine_Internal();
	}

	public static int DestroyFontEngine_Internal()
	{
		return DestroyFontEngine_InternalDelegateField();
	}

	public static void SendCancellationRequest()
	{
		SendCancellationRequest_Internal();
	}

	public static void SendCancellationRequest_Internal()
	{
		SendCancellationRequest_InternalDelegateField();
	}

	public static FontEngineError LoadFontFace(string filePath, int pointSize)
	{
		return (FontEngineError)LoadFontFace_With_Size_Internal(filePath, pointSize);
	}

	public unsafe static int LoadFontFace_With_Size_Internal(string filePath, int pointSize)
	{
		//IL_0018: Expected O, but got Ref
		//IL_0024: Expected O, but got Ref
		//The blocks IL_0029 are reachable both inside and outside the pinned region starting at IL_0018. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		try
		{
			Unsafe.SkipInit(out ManagedSpanWrapper managedSpanWrapper);
			if (!StringMarshaller.TryMarshalEmptyOrNullString(filePath, ref managedSpanWrapper))
			{
				Il2CppSystem.ReadOnlySpan<char> readOnlySpan = Il2CppSystem.MemoryExtensions.AsSpan(filePath);
				fixed (char* begin = &((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).GetPinnableReference())
				{
					managedSpanWrapper = new ManagedSpanWrapper(begin, ((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).Length);
					return LoadFontFace_With_Size_Internal_Injected(ref managedSpanWrapper, pointSize);
				}
			}
			return LoadFontFace_With_Size_Internal_Injected(ref managedSpanWrapper, pointSize);
		}
		finally
		{
		}
	}

	public static FontEngineError LoadFontFace(Il2CppStructArray<byte> sourceFontFile)
	{
		if (((Il2CppArrayBase)sourceFontFile).Length == 0)
		{
			return FontEngineError.Invalid_File;
		}
		return (FontEngineError)LoadFontFace_FromSourceFontFile_Internal(sourceFontFile);
	}

	public unsafe static int LoadFontFace_FromSourceFontFile_Internal(Il2CppStructArray<byte> sourceFontFile)
	{
		//IL_0008: Expected O, but got Ref
		//IL_000f: Expected O, but got Ref
		//IL_001b: Expected O, but got Ref
		Unsafe.SkipInit(out Il2CppSystem.Span<byte> span);
		((Il2CppSystem.Span<byte>)(&span))._002Ector((Il2CppArrayBase<byte>)(object)sourceFontFile);
		int result;
		fixed (byte* begin = &((Il2CppSystem.Span<byte>)(&span)).GetPinnableReference())
		{
			ManagedSpanWrapper sourceFontFile2 = new ManagedSpanWrapper(begin, ((Il2CppSystem.Span<byte>)(&span)).Length);
			result = LoadFontFace_FromSourceFontFile_Internal_Injected(ref sourceFontFile2);
		}
		return result;
	}

	public static FontEngineError LoadFontFace(Il2CppStructArray<byte> sourceFontFile, int pointSize)
	{
		if (((Il2CppArrayBase)sourceFontFile).Length == 0)
		{
			return FontEngineError.Invalid_File;
		}
		return (FontEngineError)LoadFontFace_With_Size_FromSourceFontFile_Internal(sourceFontFile, pointSize);
	}

	public unsafe static int LoadFontFace_With_Size_FromSourceFontFile_Internal(Il2CppStructArray<byte> sourceFontFile, int pointSize)
	{
		//IL_0008: Expected O, but got Ref
		//IL_000f: Expected O, but got Ref
		//IL_001b: Expected O, but got Ref
		Unsafe.SkipInit(out Il2CppSystem.Span<byte> span);
		((Il2CppSystem.Span<byte>)(&span))._002Ector((Il2CppArrayBase<byte>)(object)sourceFontFile);
		int result;
		fixed (byte* begin = &((Il2CppSystem.Span<byte>)(&span)).GetPinnableReference())
		{
			ManagedSpanWrapper sourceFontFile2 = new ManagedSpanWrapper(begin, ((Il2CppSystem.Span<byte>)(&span)).Length);
			result = LoadFontFace_With_Size_FromSourceFontFile_Internal_Injected(ref sourceFontFile2, pointSize);
		}
		return result;
	}

	public static FontEngineError LoadFontFace(Il2CppStructArray<byte> sourceFontFile, float pointSize, int faceIndex)
	{
		if (((Il2CppArrayBase)sourceFontFile).Length == 0)
		{
			return FontEngineError.Invalid_File;
		}
		return (FontEngineError)LoadFontFace_With_Size_And_FaceIndex_FromSourceFontFile_Internal(sourceFontFile, (int)Il2CppSystem.Math.Round(pointSize, Il2CppSystem.MidpointRounding.AwayFromZero), faceIndex);
	}

	public unsafe static int LoadFontFace_With_Size_And_FaceIndex_FromSourceFontFile_Internal(Il2CppStructArray<byte> sourceFontFile, int pointSize, int faceIndex)
	{
		//IL_0008: Expected O, but got Ref
		//IL_000f: Expected O, but got Ref
		//IL_001b: Expected O, but got Ref
		Unsafe.SkipInit(out Il2CppSystem.Span<byte> span);
		((Il2CppSystem.Span<byte>)(&span))._002Ector((Il2CppArrayBase<byte>)(object)sourceFontFile);
		int result;
		fixed (byte* begin = &((Il2CppSystem.Span<byte>)(&span)).GetPinnableReference())
		{
			ManagedSpanWrapper sourceFontFile2 = new ManagedSpanWrapper(begin, ((Il2CppSystem.Span<byte>)(&span)).Length);
			result = LoadFontFace_With_Size_And_FaceIndex_FromSourceFontFile_Internal_Injected(ref sourceFontFile2, pointSize, faceIndex);
		}
		return result;
	}

	public static FontEngineError LoadFontFace(Font font)
	{
		return (FontEngineError)LoadFontFace_FromFont_Internal(font);
	}

	public static int LoadFontFace_FromFont_Internal(Font font)
	{
		return LoadFontFace_FromFont_Internal_Injected(Object.MarshalledUnityObject.Marshal(font));
	}

	public static FontEngineError LoadFontFace(Font font, int pointSize)
	{
		return (FontEngineError)LoadFontFace_With_Size_FromFont_Internal(font, pointSize);
	}

	public static int LoadFontFace_With_Size_FromFont_Internal(Font font, int pointSize)
	{
		return LoadFontFace_With_Size_FromFont_Internal_Injected(Object.MarshalledUnityObject.Marshal(font), pointSize);
	}

	public static FontEngineError LoadFontFace(string familyName, string styleName)
	{
		return (FontEngineError)LoadFontFace_by_FamilyName_and_StyleName_Internal(familyName, styleName);
	}

	public unsafe static int LoadFontFace_by_FamilyName_and_StyleName_Internal(string familyName, string styleName)
	{
		//IL_0018: Expected O, but got Ref
		//IL_0024: Expected O, but got Ref
		//IL_0044: Expected O, but got Ref
		//IL_0052: Expected O, but got Ref
		//The blocks IL_0029, IL_0036, IL_0044, IL_0052, IL_0057 are reachable both inside and outside the pinned region starting at IL_0018. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		//The blocks IL_0057 are reachable both inside and outside the pinned region starting at IL_0044. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		//The blocks IL_0057 are reachable both inside and outside the pinned region starting at IL_0044. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		try
		{
			Unsafe.SkipInit(out ManagedSpanWrapper managedSpanWrapper);
			ref ManagedSpanWrapper familyName2;
			Il2CppSystem.ReadOnlySpan<char> readOnlySpan2;
			Unsafe.SkipInit(out ManagedSpanWrapper managedSpanWrapper2);
			if (!StringMarshaller.TryMarshalEmptyOrNullString(familyName, ref managedSpanWrapper))
			{
				Il2CppSystem.ReadOnlySpan<char> readOnlySpan = Il2CppSystem.MemoryExtensions.AsSpan(familyName);
				fixed (char* begin = &((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).GetPinnableReference())
				{
					managedSpanWrapper = new ManagedSpanWrapper(begin, ((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).Length);
					familyName2 = ref managedSpanWrapper;
					if (!StringMarshaller.TryMarshalEmptyOrNullString(styleName, ref managedSpanWrapper2))
					{
						readOnlySpan2 = Il2CppSystem.MemoryExtensions.AsSpan(styleName);
						fixed (char* begin2 = &((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan2)).GetPinnableReference())
						{
							managedSpanWrapper2 = new ManagedSpanWrapper(begin2, ((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan2)).Length);
							return LoadFontFace_by_FamilyName_and_StyleName_Internal_Injected(ref familyName2, ref managedSpanWrapper2);
						}
					}
					return LoadFontFace_by_FamilyName_and_StyleName_Internal_Injected(ref familyName2, ref managedSpanWrapper2);
				}
			}
			familyName2 = ref managedSpanWrapper;
			if (!StringMarshaller.TryMarshalEmptyOrNullString(styleName, ref managedSpanWrapper2))
			{
				readOnlySpan2 = Il2CppSystem.MemoryExtensions.AsSpan(styleName);
				fixed (char* begin2 = &((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan2)).GetPinnableReference())
				{
					managedSpanWrapper2 = new ManagedSpanWrapper(begin2, ((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan2)).Length);
					return LoadFontFace_by_FamilyName_and_StyleName_Internal_Injected(ref familyName2, ref managedSpanWrapper2);
				}
			}
			return LoadFontFace_by_FamilyName_and_StyleName_Internal_Injected(ref familyName2, ref managedSpanWrapper2);
		}
		finally
		{
		}
	}

	public static FontEngineError UnloadAllFontFaces()
	{
		return (FontEngineError)UnloadAllFontFaces_Internal();
	}

	public static int UnloadAllFontFaces_Internal()
	{
		return UnloadAllFontFaces_InternalDelegateField();
	}

	public static Il2CppStringArray GetSystemFontNames()
	{
		Il2CppStringArray systemFontNames_Internal = GetSystemFontNames_Internal();
		if (systemFontNames_Internal != null && ((Il2CppArrayBase)systemFontNames_Internal).Length == 0)
		{
			return null;
		}
		return systemFontNames_Internal;
	}

	public static Il2CppStringArray GetSystemFontNames_Internal()
	{
		System.IntPtr intPtr = GetSystemFontNames_InternalDelegateField();
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr) : null;
	}

	public static Il2CppReferenceArray<FontReference> GetSystemFontReferences()
	{
		System.IntPtr intPtr = GetSystemFontReferencesDelegateField();
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<FontReference>>(intPtr) : null;
	}

	public static FontEngineError SetFaceSize(int pointSize)
	{
		return (FontEngineError)SetFaceSize_Internal(pointSize);
	}

	public static int SetFaceSize_Internal(int pointSize)
	{
		return SetFaceSize_InternalDelegateField(pointSize);
	}

	public static int GetFaceCount()
	{
		return GetFaceCountDelegateField();
	}

	public unsafe static bool TryGetGlyphIndex(uint unicode, out uint glyphIndex)
	{
		return TryGetGlyphIndexDelegateField(unicode, (nint)Unsafe.AsPointer(ref glyphIndex));
	}

	public static bool TryPackGlyphInAtlas(Glyph glyph, int padding, GlyphPackingMode packingMode, GlyphRenderMode renderMode, int width, int height, List<GlyphRect> freeGlyphRects, List<GlyphRect> usedGlyphRects)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	public static bool TryPackGlyphInAtlas_Internal(ref GlyphMarshallingStruct glyph, int padding, GlyphPackingMode packingMode, GlyphRenderMode renderMode, int width, int height, [Out] Il2CppStructArray<GlyphRect> freeGlyphRects, ref int freeGlyphRectCount, [Out] Il2CppStructArray<GlyphRect> usedGlyphRects, ref int usedGlyphRectCount)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	public static bool TryPackGlyphsInAtlas(List<Glyph> glyphsToAdd, List<Glyph> glyphsAdded, int padding, GlyphPackingMode packingMode, GlyphRenderMode renderMode, int width, int height, List<GlyphRect> freeGlyphRects, List<GlyphRect> usedGlyphRects)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	public static bool TryPackGlyphsInAtlas_Internal([Out] Il2CppStructArray<GlyphMarshallingStruct> glyphsToAdd, ref int glyphsToAddCount, [Out] Il2CppStructArray<GlyphMarshallingStruct> glyphsAdded, ref int glyphsAddedCount, int padding, GlyphPackingMode packingMode, GlyphRenderMode renderMode, int width, int height, [Out] Il2CppStructArray<GlyphRect> freeGlyphRects, ref int freeGlyphRectCount, [Out] Il2CppStructArray<GlyphRect> usedGlyphRects, ref int usedGlyphRectCount)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	public static FontEngineError RenderGlyphToTexture(Glyph glyph, int padding, GlyphRenderMode renderMode, Texture2D texture)
	{
		GlyphMarshallingStruct glyphStruct = new GlyphMarshallingStruct(glyph);
		return (FontEngineError)RenderGlyphToTexture_Internal(glyphStruct, padding, renderMode, texture);
	}

	public static int RenderGlyphToTexture_Internal(GlyphMarshallingStruct glyphStruct, int padding, GlyphRenderMode renderMode, Texture2D texture)
	{
		return RenderGlyphToTexture_Internal_Injected(ref glyphStruct, padding, renderMode, Object.MarshalledUnityObject.Marshal(texture));
	}

	public static FontEngineError RenderGlyphsToTexture(List<Glyph> glyphs, int padding, GlyphRenderMode renderMode, Texture2D texture)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	public unsafe static int RenderGlyphsToTexture_Internal(Il2CppStructArray<GlyphMarshallingStruct> glyphs, int glyphCount, int padding, GlyphRenderMode renderMode, Texture2D texture)
	{
		//IL_0008: Expected O, but got Ref
		//IL_000f: Expected O, but got Ref
		//IL_001b: Expected O, but got Ref
		Unsafe.SkipInit(out Il2CppSystem.Span<GlyphMarshallingStruct> span);
		((Il2CppSystem.Span<GlyphMarshallingStruct>)(&span))._002Ector((Il2CppArrayBase<GlyphMarshallingStruct>)(object)glyphs);
		int result;
		fixed (GlyphMarshallingStruct* begin = &((Il2CppSystem.Span<GlyphMarshallingStruct>)(&span)).GetPinnableReference())
		{
			ManagedSpanWrapper glyphs2 = new ManagedSpanWrapper(begin, ((Il2CppSystem.Span<GlyphMarshallingStruct>)(&span)).Length);
			result = RenderGlyphsToTexture_Internal_Injected(ref glyphs2, glyphCount, padding, renderMode, Object.MarshalledUnityObject.Marshal(texture));
		}
		return result;
	}

	public static FontEngineError RenderGlyphsToTexture(List<Glyph> glyphs, int padding, GlyphRenderMode renderMode, Il2CppStructArray<byte> texBuffer, int texWidth, int texHeight)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	public static int RenderGlyphsToTextureBuffer_Internal(Il2CppStructArray<GlyphMarshallingStruct> glyphs, int glyphCount, int padding, GlyphRenderMode renderMode, [Out] Il2CppStructArray<byte> texBuffer, int texWidth, int texHeight)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	public static FontEngineError RenderGlyphsToSharedTexture(List<Glyph> glyphs, int padding, GlyphRenderMode renderMode)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	public unsafe static int RenderGlyphsToSharedTexture_Internal(Il2CppStructArray<GlyphMarshallingStruct> glyphs, int glyphCount, int padding, GlyphRenderMode renderMode)
	{
		//IL_0008: Expected O, but got Ref
		//IL_000f: Expected O, but got Ref
		//IL_001b: Expected O, but got Ref
		Unsafe.SkipInit(out Il2CppSystem.Span<GlyphMarshallingStruct> span);
		((Il2CppSystem.Span<GlyphMarshallingStruct>)(&span))._002Ector((Il2CppArrayBase<GlyphMarshallingStruct>)(object)glyphs);
		int result;
		fixed (GlyphMarshallingStruct* begin = &((Il2CppSystem.Span<GlyphMarshallingStruct>)(&span)).GetPinnableReference())
		{
			ManagedSpanWrapper glyphs2 = new ManagedSpanWrapper(begin, ((Il2CppSystem.Span<GlyphMarshallingStruct>)(&span)).Length);
			result = RenderGlyphsToSharedTexture_Internal_Injected(ref glyphs2, glyphCount, padding, renderMode);
		}
		return result;
	}

	public static void SetSharedTexture(Texture2D texture)
	{
		SetSharedTexture_Injected(Object.MarshalledUnityObject.Marshal(texture));
	}

	public static void ReleaseSharedTexture()
	{
		ReleaseSharedTextureDelegateField();
	}

	public static bool TryAddGlyphsToTexture(List<Glyph> glyphsToAdd, List<Glyph> glyphsAdded, int padding, GlyphPackingMode packingMode, List<GlyphRect> freeGlyphRects, List<GlyphRect> usedGlyphRects, GlyphRenderMode renderMode, Texture2D texture)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	public static bool TryAddGlyphsToTexture_Internal_MultiThread([Out] Il2CppStructArray<GlyphMarshallingStruct> glyphsToAdd, ref int glyphsToAddCount, [Out] Il2CppStructArray<GlyphMarshallingStruct> glyphsAdded, ref int glyphsAddedCount, int padding, GlyphPackingMode packingMode, [Out] Il2CppStructArray<GlyphRect> freeGlyphRects, ref int freeGlyphRectCount, [Out] Il2CppStructArray<GlyphRect> usedGlyphRects, ref int usedGlyphRectCount, GlyphRenderMode renderMode, Texture2D texture)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	public static Il2CppStructArray<OpenTypeFeature> GetOpenTypeFontFeatureList()
	{
		throw new Il2CppSystem.NotImplementedException();
	}

	public unsafe static int PopulateSingleSubstitutionRecordMarshallingArray_from_GlyphIndexes(Il2CppStructArray<uint> glyphIndexes, int lookupIndex, out int recordCount)
	{
		//IL_0008: Expected O, but got Ref
		//IL_000f: Expected O, but got Ref
		//IL_001b: Expected O, but got Ref
		Unsafe.SkipInit(out Il2CppSystem.Span<uint> span);
		((Il2CppSystem.Span<uint>)(&span))._002Ector((Il2CppArrayBase<uint>)(object)glyphIndexes);
		int result;
		fixed (uint* begin = &((Il2CppSystem.Span<uint>)(&span)).GetPinnableReference())
		{
			ManagedSpanWrapper glyphIndexes2 = new ManagedSpanWrapper(begin, ((Il2CppSystem.Span<uint>)(&span)).Length);
			result = PopulateSingleSubstitutionRecordMarshallingArray_from_GlyphIndexes_Injected(ref glyphIndexes2, lookupIndex, out recordCount);
		}
		return result;
	}

	public static Il2CppReferenceArray<MultipleSubstitutionRecord> GetAllMultipleSubstitutionRecords()
	{
		System.IntPtr intPtr = GetAllMultipleSubstitutionRecordsDelegateField();
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<MultipleSubstitutionRecord>>(intPtr) : null;
	}

	public static Il2CppReferenceArray<MultipleSubstitutionRecord> GetMultipleSubstitutionRecords(int lookupIndex, uint glyphIndex)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	public static Il2CppReferenceArray<MultipleSubstitutionRecord> GetMultipleSubstitutionRecords(int lookupIndex, List<uint> glyphIndexes)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	public static Il2CppReferenceArray<MultipleSubstitutionRecord> GetMultipleSubstitutionRecords(int lookupIndex, Il2CppStructArray<uint> glyphIndexes)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	public unsafe static int PopulateMultipleSubstitutionRecordMarshallingArray_from_GlyphIndexes(Il2CppStructArray<uint> glyphIndexes, int lookupIndex, out int recordCount)
	{
		//IL_0008: Expected O, but got Ref
		//IL_000f: Expected O, but got Ref
		//IL_001b: Expected O, but got Ref
		Unsafe.SkipInit(out Il2CppSystem.Span<uint> span);
		((Il2CppSystem.Span<uint>)(&span))._002Ector((Il2CppArrayBase<uint>)(object)glyphIndexes);
		int result;
		fixed (uint* begin = &((Il2CppSystem.Span<uint>)(&span)).GetPinnableReference())
		{
			ManagedSpanWrapper glyphIndexes2 = new ManagedSpanWrapper(begin, ((Il2CppSystem.Span<uint>)(&span)).Length);
			result = PopulateMultipleSubstitutionRecordMarshallingArray_from_GlyphIndexes_Injected(ref glyphIndexes2, lookupIndex, out recordCount);
		}
		return result;
	}

	public static int GetMultipleSubstitutionRecordsFromMarshallingArray([Out] Il2CppReferenceArray<MultipleSubstitutionRecord> substitutionRecords)
	{
		return GetMultipleSubstitutionRecordsFromMarshallingArrayDelegateField(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)substitutionRecords));
	}

	public unsafe static int PopulateAlternateSubstitutionRecordMarshallingArray_from_GlyphIndexes(Il2CppStructArray<uint> glyphIndexes, int lookupIndex, out int recordCount)
	{
		//IL_0008: Expected O, but got Ref
		//IL_000f: Expected O, but got Ref
		//IL_001b: Expected O, but got Ref
		Unsafe.SkipInit(out Il2CppSystem.Span<uint> span);
		((Il2CppSystem.Span<uint>)(&span))._002Ector((Il2CppArrayBase<uint>)(object)glyphIndexes);
		int result;
		fixed (uint* begin = &((Il2CppSystem.Span<uint>)(&span)).GetPinnableReference())
		{
			ManagedSpanWrapper glyphIndexes2 = new ManagedSpanWrapper(begin, ((Il2CppSystem.Span<uint>)(&span)).Length);
			result = PopulateAlternateSubstitutionRecordMarshallingArray_from_GlyphIndexes_Injected(ref glyphIndexes2, lookupIndex, out recordCount);
		}
		return result;
	}

	public static Il2CppReferenceArray<LigatureSubstitutionRecord> GetLigatureSubstitutionRecords(int lookupIndex, uint glyphIndex)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	public static Il2CppReferenceArray<LigatureSubstitutionRecord> GetLigatureSubstitutionRecords(int lookupIndex, List<uint> glyphIndexes)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	public static Il2CppReferenceArray<LigatureSubstitutionRecord> GetLigatureSubstitutionRecords(int lookupIndex, Il2CppStructArray<uint> glyphIndexes)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	public unsafe static int PopulateLigatureSubstitutionRecordMarshallingArray_for_LookupIndex(Il2CppStructArray<uint> glyphIndexes, int lookupIndex, out int recordCount)
	{
		//IL_0008: Expected O, but got Ref
		//IL_000f: Expected O, but got Ref
		//IL_001b: Expected O, but got Ref
		Unsafe.SkipInit(out Il2CppSystem.Span<uint> span);
		((Il2CppSystem.Span<uint>)(&span))._002Ector((Il2CppArrayBase<uint>)(object)glyphIndexes);
		int result;
		fixed (uint* begin = &((Il2CppSystem.Span<uint>)(&span)).GetPinnableReference())
		{
			ManagedSpanWrapper glyphIndexes2 = new ManagedSpanWrapper(begin, ((Il2CppSystem.Span<uint>)(&span)).Length);
			result = PopulateLigatureSubstitutionRecordMarshallingArray_for_LookupIndex_Injected(ref glyphIndexes2, lookupIndex, out recordCount);
		}
		return result;
	}

	public unsafe static int PopulateContextualSubstitutionRecordMarshallingArray_from_GlyphIndexes(Il2CppStructArray<uint> glyphIndexes, int lookupIndex, out int recordCount)
	{
		//IL_0008: Expected O, but got Ref
		//IL_000f: Expected O, but got Ref
		//IL_001b: Expected O, but got Ref
		Unsafe.SkipInit(out Il2CppSystem.Span<uint> span);
		((Il2CppSystem.Span<uint>)(&span))._002Ector((Il2CppArrayBase<uint>)(object)glyphIndexes);
		int result;
		fixed (uint* begin = &((Il2CppSystem.Span<uint>)(&span)).GetPinnableReference())
		{
			ManagedSpanWrapper glyphIndexes2 = new ManagedSpanWrapper(begin, ((Il2CppSystem.Span<uint>)(&span)).Length);
			result = PopulateContextualSubstitutionRecordMarshallingArray_from_GlyphIndexes_Injected(ref glyphIndexes2, lookupIndex, out recordCount);
		}
		return result;
	}

	public unsafe static int PopulateChainingContextualSubstitutionRecordMarshallingArray_from_GlyphIndexes(Il2CppStructArray<uint> glyphIndexes, int lookupIndex, out int recordCount)
	{
		//IL_0008: Expected O, but got Ref
		//IL_000f: Expected O, but got Ref
		//IL_001b: Expected O, but got Ref
		Unsafe.SkipInit(out Il2CppSystem.Span<uint> span);
		((Il2CppSystem.Span<uint>)(&span))._002Ector((Il2CppArrayBase<uint>)(object)glyphIndexes);
		int result;
		fixed (uint* begin = &((Il2CppSystem.Span<uint>)(&span)).GetPinnableReference())
		{
			ManagedSpanWrapper glyphIndexes2 = new ManagedSpanWrapper(begin, ((Il2CppSystem.Span<uint>)(&span)).Length);
			result = PopulateChainingContextualSubstitutionRecordMarshallingArray_from_GlyphIndexes_Injected(ref glyphIndexes2, lookupIndex, out recordCount);
		}
		return result;
	}

	public static Il2CppStructArray<GlyphPairAdjustmentRecord> GetGlyphPairAdjustmentRecords(List<uint> glyphIndexes, out int recordCount)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	public static Il2CppStructArray<GlyphPairAdjustmentRecord> GetGlyphPairAdjustmentRecords(uint glyphIndex, out int recordCount)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	public unsafe static int PopulatePairAdjustmentRecordMarshallingArray_from_GlyphIndex(uint glyphIndex, out int recordCount)
	{
		return PopulatePairAdjustmentRecordMarshallingArray_from_GlyphIndexDelegateField(glyphIndex, (nint)Unsafe.AsPointer(ref recordCount));
	}

	public static Il2CppStructArray<GlyphPairAdjustmentRecord> GetGlyphPairAdjustmentRecords(List<uint> newGlyphIndexes, List<uint> allGlyphIndexes)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	public unsafe static int PopulatePairAdjustmentRecordMarshallingArray_for_NewlyAddedGlyphIndexes(Il2CppStructArray<uint> newGlyphIndexes, Il2CppStructArray<uint> allGlyphIndexes, out int recordCount)
	{
		//IL_0008: Expected O, but got Ref
		//IL_000f: Expected O, but got Ref
		//IL_001b: Expected O, but got Ref
		//IL_002b: Expected O, but got Ref
		//IL_0032: Expected O, but got Ref
		//IL_0040: Expected O, but got Ref
		Unsafe.SkipInit(out Il2CppSystem.Span<uint> span);
		((Il2CppSystem.Span<uint>)(&span))._002Ector((Il2CppArrayBase<uint>)(object)newGlyphIndexes);
		int result;
		fixed (uint* begin = &((Il2CppSystem.Span<uint>)(&span)).GetPinnableReference())
		{
			ManagedSpanWrapper newGlyphIndexes2 = new ManagedSpanWrapper(begin, ((Il2CppSystem.Span<uint>)(&span)).Length);
			Unsafe.SkipInit(out Il2CppSystem.Span<uint> span2);
			((Il2CppSystem.Span<uint>)(&span2))._002Ector((Il2CppArrayBase<uint>)(object)allGlyphIndexes);
			fixed (uint* begin2 = &((Il2CppSystem.Span<uint>)(&span2)).GetPinnableReference())
			{
				ManagedSpanWrapper allGlyphIndexes2 = new ManagedSpanWrapper(begin2, ((Il2CppSystem.Span<uint>)(&span2)).Length);
				result = PopulatePairAdjustmentRecordMarshallingArray_for_NewlyAddedGlyphIndexes_Injected(ref newGlyphIndexes2, ref allGlyphIndexes2, out recordCount);
			}
		}
		return result;
	}

	public static GlyphPairAdjustmentRecord GetGlyphPairAdjustmentRecord(uint firstGlyphIndex, uint secondGlyphIndex)
	{
		GetGlyphPairAdjustmentRecord_Injected(firstGlyphIndex, secondGlyphIndex, out var ret);
		return ret;
	}

	public static Il2CppStructArray<GlyphAdjustmentRecord> GetSingleAdjustmentRecords(int lookupIndex, uint glyphIndex)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	public static Il2CppStructArray<GlyphAdjustmentRecord> GetSingleAdjustmentRecords(int lookupIndex, List<uint> glyphIndexes)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	public static Il2CppStructArray<GlyphAdjustmentRecord> GetSingleAdjustmentRecords(int lookupIndex, Il2CppStructArray<uint> glyphIndexes)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	public unsafe static int PopulateSingleAdjustmentRecordMarshallingArray_from_GlyphIndexes(Il2CppStructArray<uint> glyphIndexes, int lookupIndex, out int recordCount)
	{
		//IL_0008: Expected O, but got Ref
		//IL_000f: Expected O, but got Ref
		//IL_001b: Expected O, but got Ref
		Unsafe.SkipInit(out Il2CppSystem.Span<uint> span);
		((Il2CppSystem.Span<uint>)(&span))._002Ector((Il2CppArrayBase<uint>)(object)glyphIndexes);
		int result;
		fixed (uint* begin = &((Il2CppSystem.Span<uint>)(&span)).GetPinnableReference())
		{
			ManagedSpanWrapper glyphIndexes2 = new ManagedSpanWrapper(begin, ((Il2CppSystem.Span<uint>)(&span)).Length);
			result = PopulateSingleAdjustmentRecordMarshallingArray_from_GlyphIndexes_Injected(ref glyphIndexes2, lookupIndex, out recordCount);
		}
		return result;
	}

	public unsafe static int GetSingleAdjustmentRecordsFromMarshallingArray(Il2CppSystem.Span<GlyphAdjustmentRecord> singleSubstitutionRecords)
	{
		//IL_0009: Expected O, but got Ref
		//IL_0015: Expected O, but got Ref
		Il2CppSystem.Span<GlyphAdjustmentRecord> span = singleSubstitutionRecords;
		int singleAdjustmentRecordsFromMarshallingArray_Injected;
		fixed (GlyphAdjustmentRecord* begin = &((Il2CppSystem.Span<GlyphAdjustmentRecord>)(&span)).GetPinnableReference())
		{
			ManagedSpanWrapper singleSubstitutionRecords2 = new ManagedSpanWrapper(begin, ((Il2CppSystem.Span<GlyphAdjustmentRecord>)(&span)).Length);
			singleAdjustmentRecordsFromMarshallingArray_Injected = GetSingleAdjustmentRecordsFromMarshallingArray_Injected(ref singleSubstitutionRecords2);
		}
		return singleAdjustmentRecordsFromMarshallingArray_Injected;
	}

	public unsafe static Il2CppStructArray<GlyphPairAdjustmentRecord> GetPairAdjustmentRecords(uint glyphIndex)
	{
		Unsafe.SkipInit(out BlittableArrayWrapper ret);
		Il2CppStructArray<GlyphPairAdjustmentRecord> result;
		try
		{
			GetPairAdjustmentRecords_Injected(glyphIndex, out ret);
		}
		finally
		{
			Unsafe.SkipInit(out Il2CppStructArray<GlyphPairAdjustmentRecord> array);
			ret.Unmarshal(ref *(Il2CppArrayBase<GlyphPairAdjustmentRecord>*)(&array));
			result = array;
		}
		return result;
	}

	public static GlyphPairAdjustmentRecord GetPairAdjustmentRecord(uint firstGlyphIndex, uint secondGlyphIndex)
	{
		GetPairAdjustmentRecord_Injected(firstGlyphIndex, secondGlyphIndex, out var ret);
		return ret;
	}

	public static Il2CppStructArray<GlyphPairAdjustmentRecord> GetPairAdjustmentRecords(int lookupIndex, uint glyphIndex)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	public static Il2CppStructArray<GlyphPairAdjustmentRecord> GetPairAdjustmentRecords(int lookupIndex, List<uint> glyphIndexes)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	public static Il2CppStructArray<GlyphPairAdjustmentRecord> GetPairAdjustmentRecords(int lookupIndex, Il2CppStructArray<uint> glyphIndexes)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	public unsafe static int PopulatePairAdjustmentRecordMarshallingArray_for_LookupIndex(Il2CppStructArray<uint> glyphIndexes, int lookupIndex, out int recordCount)
	{
		//IL_0008: Expected O, but got Ref
		//IL_000f: Expected O, but got Ref
		//IL_001b: Expected O, but got Ref
		Unsafe.SkipInit(out Il2CppSystem.Span<uint> span);
		((Il2CppSystem.Span<uint>)(&span))._002Ector((Il2CppArrayBase<uint>)(object)glyphIndexes);
		int result;
		fixed (uint* begin = &((Il2CppSystem.Span<uint>)(&span)).GetPinnableReference())
		{
			ManagedSpanWrapper glyphIndexes2 = new ManagedSpanWrapper(begin, ((Il2CppSystem.Span<uint>)(&span)).Length);
			result = PopulatePairAdjustmentRecordMarshallingArray_for_LookupIndex_Injected(ref glyphIndexes2, lookupIndex, out recordCount);
		}
		return result;
	}

	public unsafe static Il2CppStructArray<MarkToBaseAdjustmentRecord> GetMarkToBaseAdjustmentRecords(uint baseGlyphIndex)
	{
		Unsafe.SkipInit(out BlittableArrayWrapper ret);
		Il2CppStructArray<MarkToBaseAdjustmentRecord> result;
		try
		{
			GetMarkToBaseAdjustmentRecords_Injected(baseGlyphIndex, out ret);
		}
		finally
		{
			Unsafe.SkipInit(out Il2CppStructArray<MarkToBaseAdjustmentRecord> array);
			ret.Unmarshal(ref *(Il2CppArrayBase<MarkToBaseAdjustmentRecord>*)(&array));
			result = array;
		}
		return result;
	}

	public static MarkToBaseAdjustmentRecord GetMarkToBaseAdjustmentRecord(uint baseGlyphIndex, uint markGlyphIndex)
	{
		GetMarkToBaseAdjustmentRecord_Injected(baseGlyphIndex, markGlyphIndex, out var ret);
		return ret;
	}

	public static Il2CppStructArray<MarkToBaseAdjustmentRecord> GetMarkToBaseAdjustmentRecords(int lookupIndex, List<uint> glyphIndexes)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	public static Il2CppStructArray<MarkToBaseAdjustmentRecord> GetMarkToBaseAdjustmentRecords(int lookupIndex, Il2CppStructArray<uint> glyphIndexes)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	public unsafe static int PopulateMarkToBaseAdjustmentRecordMarshallingArray_for_LookupIndex(Il2CppStructArray<uint> glyphIndexes, int lookupIndex, out int recordCount)
	{
		//IL_0008: Expected O, but got Ref
		//IL_000f: Expected O, but got Ref
		//IL_001b: Expected O, but got Ref
		Unsafe.SkipInit(out Il2CppSystem.Span<uint> span);
		((Il2CppSystem.Span<uint>)(&span))._002Ector((Il2CppArrayBase<uint>)(object)glyphIndexes);
		int result;
		fixed (uint* begin = &((Il2CppSystem.Span<uint>)(&span)).GetPinnableReference())
		{
			ManagedSpanWrapper glyphIndexes2 = new ManagedSpanWrapper(begin, ((Il2CppSystem.Span<uint>)(&span)).Length);
			result = PopulateMarkToBaseAdjustmentRecordMarshallingArray_for_LookupIndex_Injected(ref glyphIndexes2, lookupIndex, out recordCount);
		}
		return result;
	}

	public unsafe static Il2CppStructArray<MarkToMarkAdjustmentRecord> GetMarkToMarkAdjustmentRecords(uint baseMarkGlyphIndex)
	{
		Unsafe.SkipInit(out BlittableArrayWrapper ret);
		Il2CppStructArray<MarkToMarkAdjustmentRecord> result;
		try
		{
			GetMarkToMarkAdjustmentRecords_Injected(baseMarkGlyphIndex, out ret);
		}
		finally
		{
			Unsafe.SkipInit(out Il2CppStructArray<MarkToMarkAdjustmentRecord> array);
			ret.Unmarshal(ref *(Il2CppArrayBase<MarkToMarkAdjustmentRecord>*)(&array));
			result = array;
		}
		return result;
	}

	public static MarkToMarkAdjustmentRecord GetMarkToMarkAdjustmentRecord(uint firstGlyphIndex, uint secondGlyphIndex)
	{
		GetMarkToMarkAdjustmentRecord_Injected(firstGlyphIndex, secondGlyphIndex, out var ret);
		return ret;
	}

	public static Il2CppStructArray<MarkToMarkAdjustmentRecord> GetMarkToMarkAdjustmentRecords(int lookupIndex, List<uint> glyphIndexes)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	public static Il2CppStructArray<MarkToMarkAdjustmentRecord> GetMarkToMarkAdjustmentRecords(int lookupIndex, Il2CppStructArray<uint> glyphIndexes)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	public unsafe static int PopulateMarkToMarkAdjustmentRecordMarshallingArray_for_LookupIndex(Il2CppStructArray<uint> glyphIndexes, int lookupIndex, out int recordCount)
	{
		//IL_0008: Expected O, but got Ref
		//IL_000f: Expected O, but got Ref
		//IL_001b: Expected O, but got Ref
		Unsafe.SkipInit(out Il2CppSystem.Span<uint> span);
		((Il2CppSystem.Span<uint>)(&span))._002Ector((Il2CppArrayBase<uint>)(object)glyphIndexes);
		int result;
		fixed (uint* begin = &((Il2CppSystem.Span<uint>)(&span)).GetPinnableReference())
		{
			ManagedSpanWrapper glyphIndexes2 = new ManagedSpanWrapper(begin, ((Il2CppSystem.Span<uint>)(&span)).Length);
			result = PopulateMarkToMarkAdjustmentRecordMarshallingArray_for_LookupIndex_Injected(ref glyphIndexes2, lookupIndex, out recordCount);
		}
		return result;
	}

	public static void RenderBufferToTexture(Texture2D srcTexture, int padding, GlyphRenderMode renderMode, Texture2D dstTexture)
	{
		RenderBufferToTexture_Injected(Object.MarshalledUnityObject.Marshal(srcTexture), padding, renderMode, Object.MarshalledUnityObject.Marshal(dstTexture));
	}

	public unsafe static int LoadFontFace_With_Size_Internal_Injected(ref ManagedSpanWrapper filePath, int pointSize)
	{
		return LoadFontFace_With_Size_Internal_InjectedDelegateField((nint)Unsafe.AsPointer(ref filePath), pointSize);
	}

	public unsafe static int LoadFontFace_FromSourceFontFile_Internal_Injected(ref ManagedSpanWrapper sourceFontFile)
	{
		return LoadFontFace_FromSourceFontFile_Internal_InjectedDelegateField((nint)Unsafe.AsPointer(ref sourceFontFile));
	}

	public unsafe static int LoadFontFace_With_Size_FromSourceFontFile_Internal_Injected(ref ManagedSpanWrapper sourceFontFile, int pointSize)
	{
		return LoadFontFace_With_Size_FromSourceFontFile_Internal_InjectedDelegateField((nint)Unsafe.AsPointer(ref sourceFontFile), pointSize);
	}

	public unsafe static int LoadFontFace_With_Size_And_FaceIndex_FromSourceFontFile_Internal_Injected(ref ManagedSpanWrapper sourceFontFile, int pointSize, int faceIndex)
	{
		return LoadFontFace_With_Size_And_FaceIndex_FromSourceFontFile_Internal_InjectedDelegateField((nint)Unsafe.AsPointer(ref sourceFontFile), pointSize, faceIndex);
	}

	public static int LoadFontFace_FromFont_Internal_Injected(System.IntPtr font)
	{
		return LoadFontFace_FromFont_Internal_InjectedDelegateField(font);
	}

	public static int LoadFontFace_With_Size_FromFont_Internal_Injected(System.IntPtr font, int pointSize)
	{
		return LoadFontFace_With_Size_FromFont_Internal_InjectedDelegateField(font, pointSize);
	}

	public unsafe static int LoadFontFace_by_FamilyName_and_StyleName_Internal_Injected(ref ManagedSpanWrapper familyName, ref ManagedSpanWrapper styleName)
	{
		return LoadFontFace_by_FamilyName_and_StyleName_Internal_InjectedDelegateField((nint)Unsafe.AsPointer(ref familyName), (nint)Unsafe.AsPointer(ref styleName));
	}

	public unsafe static bool TryPackGlyphInAtlas_Internal_Injected(ref GlyphMarshallingStruct glyph, int padding, GlyphPackingMode packingMode, GlyphRenderMode renderMode, int width, int height, out BlittableArrayWrapper freeGlyphRects, ref int freeGlyphRectCount, out BlittableArrayWrapper usedGlyphRects, ref int usedGlyphRectCount)
	{
		return TryPackGlyphInAtlas_Internal_InjectedDelegateField((nint)Unsafe.AsPointer(ref glyph), padding, packingMode, renderMode, width, height, (nint)Unsafe.AsPointer(ref freeGlyphRects), (nint)Unsafe.AsPointer(ref freeGlyphRectCount), (nint)Unsafe.AsPointer(ref usedGlyphRects), (nint)Unsafe.AsPointer(ref usedGlyphRectCount));
	}

	public unsafe static bool TryPackGlyphsInAtlas_Internal_Injected(out BlittableArrayWrapper glyphsToAdd, ref int glyphsToAddCount, out BlittableArrayWrapper glyphsAdded, ref int glyphsAddedCount, int padding, GlyphPackingMode packingMode, GlyphRenderMode renderMode, int width, int height, out BlittableArrayWrapper freeGlyphRects, ref int freeGlyphRectCount, out BlittableArrayWrapper usedGlyphRects, ref int usedGlyphRectCount)
	{
		return TryPackGlyphsInAtlas_Internal_InjectedDelegateField((nint)Unsafe.AsPointer(ref glyphsToAdd), (nint)Unsafe.AsPointer(ref glyphsToAddCount), (nint)Unsafe.AsPointer(ref glyphsAdded), (nint)Unsafe.AsPointer(ref glyphsAddedCount), padding, packingMode, renderMode, width, height, (nint)Unsafe.AsPointer(ref freeGlyphRects), (nint)Unsafe.AsPointer(ref freeGlyphRectCount), (nint)Unsafe.AsPointer(ref usedGlyphRects), (nint)Unsafe.AsPointer(ref usedGlyphRectCount));
	}

	public unsafe static int RenderGlyphToTexture_Internal_Injected([In] ref GlyphMarshallingStruct glyphStruct, int padding, GlyphRenderMode renderMode, System.IntPtr texture)
	{
		return RenderGlyphToTexture_Internal_InjectedDelegateField((nint)Unsafe.AsPointer(ref glyphStruct), padding, renderMode, texture);
	}

	public unsafe static int RenderGlyphsToTexture_Internal_Injected(ref ManagedSpanWrapper glyphs, int glyphCount, int padding, GlyphRenderMode renderMode, System.IntPtr texture)
	{
		return RenderGlyphsToTexture_Internal_InjectedDelegateField((nint)Unsafe.AsPointer(ref glyphs), glyphCount, padding, renderMode, texture);
	}

	public unsafe static int RenderGlyphsToTextureBuffer_Internal_Injected(ref ManagedSpanWrapper glyphs, int glyphCount, int padding, GlyphRenderMode renderMode, out BlittableArrayWrapper texBuffer, int texWidth, int texHeight)
	{
		return RenderGlyphsToTextureBuffer_Internal_InjectedDelegateField((nint)Unsafe.AsPointer(ref glyphs), glyphCount, padding, renderMode, (nint)Unsafe.AsPointer(ref texBuffer), texWidth, texHeight);
	}

	public unsafe static int RenderGlyphsToSharedTexture_Internal_Injected(ref ManagedSpanWrapper glyphs, int glyphCount, int padding, GlyphRenderMode renderMode)
	{
		return RenderGlyphsToSharedTexture_Internal_InjectedDelegateField((nint)Unsafe.AsPointer(ref glyphs), glyphCount, padding, renderMode);
	}

	public static void SetSharedTexture_Injected(System.IntPtr texture)
	{
		SetSharedTexture_InjectedDelegateField(texture);
	}

	public unsafe static bool TryAddGlyphsToTexture_Internal_MultiThread_Injected(out BlittableArrayWrapper glyphsToAdd, ref int glyphsToAddCount, out BlittableArrayWrapper glyphsAdded, ref int glyphsAddedCount, int padding, GlyphPackingMode packingMode, out BlittableArrayWrapper freeGlyphRects, ref int freeGlyphRectCount, out BlittableArrayWrapper usedGlyphRects, ref int usedGlyphRectCount, GlyphRenderMode renderMode, System.IntPtr texture)
	{
		return TryAddGlyphsToTexture_Internal_MultiThread_InjectedDelegateField((nint)Unsafe.AsPointer(ref glyphsToAdd), (nint)Unsafe.AsPointer(ref glyphsToAddCount), (nint)Unsafe.AsPointer(ref glyphsAdded), (nint)Unsafe.AsPointer(ref glyphsAddedCount), padding, packingMode, (nint)Unsafe.AsPointer(ref freeGlyphRects), (nint)Unsafe.AsPointer(ref freeGlyphRectCount), (nint)Unsafe.AsPointer(ref usedGlyphRects), (nint)Unsafe.AsPointer(ref usedGlyphRectCount), renderMode, texture);
	}

	public unsafe static void GetOpenTypeLayoutLookups_Injected(out BlittableArrayWrapper ret)
	{
		GetOpenTypeLayoutLookups_InjectedDelegateField((nint)Unsafe.AsPointer(ref ret));
	}

	public unsafe static void GetAllSingleSubstitutionRecords_Injected(out BlittableArrayWrapper ret)
	{
		GetAllSingleSubstitutionRecords_InjectedDelegateField((nint)Unsafe.AsPointer(ref ret));
	}

	public unsafe static int PopulateSingleSubstitutionRecordMarshallingArray_from_GlyphIndexes_Injected(ref ManagedSpanWrapper glyphIndexes, int lookupIndex, out int recordCount)
	{
		return PopulateSingleSubstitutionRecordMarshallingArray_from_GlyphIndexes_InjectedDelegateField((nint)Unsafe.AsPointer(ref glyphIndexes), lookupIndex, (nint)Unsafe.AsPointer(ref recordCount));
	}

	public unsafe static int GetSingleSubstitutionRecordsFromMarshallingArray_Injected(ref ManagedSpanWrapper singleSubstitutionRecords)
	{
		return GetSingleSubstitutionRecordsFromMarshallingArray_InjectedDelegateField((nint)Unsafe.AsPointer(ref singleSubstitutionRecords));
	}

	public unsafe static int PopulateMultipleSubstitutionRecordMarshallingArray_from_GlyphIndexes_Injected(ref ManagedSpanWrapper glyphIndexes, int lookupIndex, out int recordCount)
	{
		return PopulateMultipleSubstitutionRecordMarshallingArray_from_GlyphIndexes_InjectedDelegateField((nint)Unsafe.AsPointer(ref glyphIndexes), lookupIndex, (nint)Unsafe.AsPointer(ref recordCount));
	}

	public unsafe static int PopulateAlternateSubstitutionRecordMarshallingArray_from_GlyphIndexes_Injected(ref ManagedSpanWrapper glyphIndexes, int lookupIndex, out int recordCount)
	{
		return PopulateAlternateSubstitutionRecordMarshallingArray_from_GlyphIndexes_InjectedDelegateField((nint)Unsafe.AsPointer(ref glyphIndexes), lookupIndex, (nint)Unsafe.AsPointer(ref recordCount));
	}

	public unsafe static int PopulateLigatureSubstitutionRecordMarshallingArray_for_LookupIndex_Injected(ref ManagedSpanWrapper glyphIndexes, int lookupIndex, out int recordCount)
	{
		return PopulateLigatureSubstitutionRecordMarshallingArray_for_LookupIndex_InjectedDelegateField((nint)Unsafe.AsPointer(ref glyphIndexes), lookupIndex, (nint)Unsafe.AsPointer(ref recordCount));
	}

	public unsafe static int PopulateContextualSubstitutionRecordMarshallingArray_from_GlyphIndexes_Injected(ref ManagedSpanWrapper glyphIndexes, int lookupIndex, out int recordCount)
	{
		return PopulateContextualSubstitutionRecordMarshallingArray_from_GlyphIndexes_InjectedDelegateField((nint)Unsafe.AsPointer(ref glyphIndexes), lookupIndex, (nint)Unsafe.AsPointer(ref recordCount));
	}

	public unsafe static int PopulateChainingContextualSubstitutionRecordMarshallingArray_from_GlyphIndexes_Injected(ref ManagedSpanWrapper glyphIndexes, int lookupIndex, out int recordCount)
	{
		return PopulateChainingContextualSubstitutionRecordMarshallingArray_from_GlyphIndexes_InjectedDelegateField((nint)Unsafe.AsPointer(ref glyphIndexes), lookupIndex, (nint)Unsafe.AsPointer(ref recordCount));
	}

	public unsafe static int PopulatePairAdjustmentRecordMarshallingArray_for_NewlyAddedGlyphIndexes_Injected(ref ManagedSpanWrapper newGlyphIndexes, ref ManagedSpanWrapper allGlyphIndexes, out int recordCount)
	{
		return PopulatePairAdjustmentRecordMarshallingArray_for_NewlyAddedGlyphIndexes_InjectedDelegateField((nint)Unsafe.AsPointer(ref newGlyphIndexes), (nint)Unsafe.AsPointer(ref allGlyphIndexes), (nint)Unsafe.AsPointer(ref recordCount));
	}

	public unsafe static void GetGlyphPairAdjustmentRecord_Injected(uint firstGlyphIndex, uint secondGlyphIndex, out GlyphPairAdjustmentRecord ret)
	{
		GetGlyphPairAdjustmentRecord_InjectedDelegateField(firstGlyphIndex, secondGlyphIndex, (nint)Unsafe.AsPointer(ref ret));
	}

	public unsafe static int PopulateSingleAdjustmentRecordMarshallingArray_from_GlyphIndexes_Injected(ref ManagedSpanWrapper glyphIndexes, int lookupIndex, out int recordCount)
	{
		return PopulateSingleAdjustmentRecordMarshallingArray_from_GlyphIndexes_InjectedDelegateField((nint)Unsafe.AsPointer(ref glyphIndexes), lookupIndex, (nint)Unsafe.AsPointer(ref recordCount));
	}

	public unsafe static int GetSingleAdjustmentRecordsFromMarshallingArray_Injected(ref ManagedSpanWrapper singleSubstitutionRecords)
	{
		return GetSingleAdjustmentRecordsFromMarshallingArray_InjectedDelegateField((nint)Unsafe.AsPointer(ref singleSubstitutionRecords));
	}

	public unsafe static void GetPairAdjustmentRecords_Injected(uint glyphIndex, out BlittableArrayWrapper ret)
	{
		GetPairAdjustmentRecords_InjectedDelegateField(glyphIndex, (nint)Unsafe.AsPointer(ref ret));
	}

	public unsafe static void GetPairAdjustmentRecord_Injected(uint firstGlyphIndex, uint secondGlyphIndex, out GlyphPairAdjustmentRecord ret)
	{
		GetPairAdjustmentRecord_InjectedDelegateField(firstGlyphIndex, secondGlyphIndex, (nint)Unsafe.AsPointer(ref ret));
	}

	public unsafe static int PopulatePairAdjustmentRecordMarshallingArray_for_LookupIndex_Injected(ref ManagedSpanWrapper glyphIndexes, int lookupIndex, out int recordCount)
	{
		return PopulatePairAdjustmentRecordMarshallingArray_for_LookupIndex_InjectedDelegateField((nint)Unsafe.AsPointer(ref glyphIndexes), lookupIndex, (nint)Unsafe.AsPointer(ref recordCount));
	}

	public unsafe static void GetMarkToBaseAdjustmentRecords_Injected(uint baseGlyphIndex, out BlittableArrayWrapper ret)
	{
		GetMarkToBaseAdjustmentRecords_InjectedDelegateField(baseGlyphIndex, (nint)Unsafe.AsPointer(ref ret));
	}

	public unsafe static void GetMarkToBaseAdjustmentRecord_Injected(uint baseGlyphIndex, uint markGlyphIndex, out MarkToBaseAdjustmentRecord ret)
	{
		GetMarkToBaseAdjustmentRecord_InjectedDelegateField(baseGlyphIndex, markGlyphIndex, (nint)Unsafe.AsPointer(ref ret));
	}

	public unsafe static int PopulateMarkToBaseAdjustmentRecordMarshallingArray_for_LookupIndex_Injected(ref ManagedSpanWrapper glyphIndexes, int lookupIndex, out int recordCount)
	{
		return PopulateMarkToBaseAdjustmentRecordMarshallingArray_for_LookupIndex_InjectedDelegateField((nint)Unsafe.AsPointer(ref glyphIndexes), lookupIndex, (nint)Unsafe.AsPointer(ref recordCount));
	}

	public unsafe static void GetMarkToMarkAdjustmentRecords_Injected(uint baseMarkGlyphIndex, out BlittableArrayWrapper ret)
	{
		GetMarkToMarkAdjustmentRecords_InjectedDelegateField(baseMarkGlyphIndex, (nint)Unsafe.AsPointer(ref ret));
	}

	public unsafe static void GetMarkToMarkAdjustmentRecord_Injected(uint firstGlyphIndex, uint secondGlyphIndex, out MarkToMarkAdjustmentRecord ret)
	{
		GetMarkToMarkAdjustmentRecord_InjectedDelegateField(firstGlyphIndex, secondGlyphIndex, (nint)Unsafe.AsPointer(ref ret));
	}

	public unsafe static int PopulateMarkToMarkAdjustmentRecordMarshallingArray_for_LookupIndex_Injected(ref ManagedSpanWrapper glyphIndexes, int lookupIndex, out int recordCount)
	{
		return PopulateMarkToMarkAdjustmentRecordMarshallingArray_for_LookupIndex_InjectedDelegateField((nint)Unsafe.AsPointer(ref glyphIndexes), lookupIndex, (nint)Unsafe.AsPointer(ref recordCount));
	}

	public static void RenderBufferToTexture_Injected(System.IntPtr srcTexture, int padding, GlyphRenderMode renderMode, System.IntPtr dstTexture)
	{
		RenderBufferToTexture_InjectedDelegateField(srcTexture, padding, renderMode, dstTexture);
	}
}
