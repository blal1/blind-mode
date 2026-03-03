using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.TextCore.Text;

public static class FontAssetUtilities : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_k_SearchedAssets;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetCharacterFromFontAsset_Internal_Static_Character_UInt32_FontAsset_Boolean_FontStyles_TextFontWeight_byref_Boolean_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetCharacterFromFontAsset_Internal_Private_Static_Character_UInt32_FontAsset_Boolean_FontStyles_TextFontWeight_byref_Boolean_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetCharacterFromFontAssetsInternal_Internal_Static_Character_UInt32_FontAsset_List_1_FontAsset_List_1_FontAsset_Boolean_FontStyles_TextFontWeight_byref_Boolean_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetCharacterFromFontAssetsInternal_Private_Static_Character_UInt32_List_1_FontAsset_Boolean_FontStyles_TextFontWeight_byref_Boolean_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetTextElementFromTextAssets_Internal_Static_TextElement_UInt32_FontAsset_List_1_TextAsset_Boolean_FontStyles_TextFontWeight_byref_Boolean_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetSpriteCharacterFromSpriteAsset_Public_Static_SpriteCharacter_UInt32_SpriteAsset_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetSpriteCharacterFromSpriteAsset_Internal_Private_Static_SpriteCharacter_UInt32_SpriteAsset_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetCodePoint_Public_Static_UInt32_String_byref_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetCodePoint_Public_Static_UInt32_Il2CppStructArray_1_UInt32_byref_Int32_0;

	public unsafe static HashSet<int> k_SearchedAssets
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_k_SearchedAssets, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<HashSet<int>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_k_SearchedAssets, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	static FontAssetUtilities()
	{
		Il2CppClassPointerStore<FontAssetUtilities>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.TextCoreTextEngineModule.dll", "UnityEngine.TextCore.Text", "FontAssetUtilities");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FontAssetUtilities>.NativeClassPtr);
		NativeFieldInfoPtr_k_SearchedAssets = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FontAssetUtilities>.NativeClassPtr, "k_SearchedAssets");
		NativeMethodInfoPtr_GetCharacterFromFontAsset_Internal_Static_Character_UInt32_FontAsset_Boolean_FontStyles_TextFontWeight_byref_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontAssetUtilities>.NativeClassPtr, 100663581);
		NativeMethodInfoPtr_GetCharacterFromFontAsset_Internal_Private_Static_Character_UInt32_FontAsset_Boolean_FontStyles_TextFontWeight_byref_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontAssetUtilities>.NativeClassPtr, 100663582);
		NativeMethodInfoPtr_GetCharacterFromFontAssetsInternal_Internal_Static_Character_UInt32_FontAsset_List_1_FontAsset_List_1_FontAsset_Boolean_FontStyles_TextFontWeight_byref_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontAssetUtilities>.NativeClassPtr, 100663583);
		NativeMethodInfoPtr_GetCharacterFromFontAssetsInternal_Private_Static_Character_UInt32_List_1_FontAsset_Boolean_FontStyles_TextFontWeight_byref_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontAssetUtilities>.NativeClassPtr, 100663584);
		NativeMethodInfoPtr_GetTextElementFromTextAssets_Internal_Static_TextElement_UInt32_FontAsset_List_1_TextAsset_Boolean_FontStyles_TextFontWeight_byref_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontAssetUtilities>.NativeClassPtr, 100663585);
		NativeMethodInfoPtr_GetSpriteCharacterFromSpriteAsset_Public_Static_SpriteCharacter_UInt32_SpriteAsset_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontAssetUtilities>.NativeClassPtr, 100663586);
		NativeMethodInfoPtr_GetSpriteCharacterFromSpriteAsset_Internal_Private_Static_SpriteCharacter_UInt32_SpriteAsset_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontAssetUtilities>.NativeClassPtr, 100663587);
		NativeMethodInfoPtr_GetCodePoint_Public_Static_UInt32_String_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontAssetUtilities>.NativeClassPtr, 100663588);
		NativeMethodInfoPtr_GetCodePoint_Public_Static_UInt32_Il2CppStructArray_1_UInt32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontAssetUtilities>.NativeClassPtr, 100663589);
	}

	[CallerCount(13)]
	[CachedScanResults(RefRangeStart = 1278234, RefRangeEnd = 1278247, XrefRangeStart = 1278218, XrefRangeEnd = 1278234, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Character GetCharacterFromFontAsset(uint unicode, FontAsset sourceFontAsset, bool includeFallbacks, FontStyles fontStyle, TextFontWeight fontWeight, out bool isAlternativeTypeface, bool populateLigatures)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[7];
		*ptr = (nint)(&unicode);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)sourceFontAsset);
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &includeFallbacks;
		*(FontStyles**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &fontStyle;
		*(TextFontWeight**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &fontWeight;
		*(void**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref isAlternativeTypeface);
		*(bool**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = &populateLigatures;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetCharacterFromFontAsset_Internal_Static_Character_UInt32_FontAsset_Boolean_FontStyles_TextFontWeight_byref_Boolean_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Character>(intPtr2) : null;
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 1278306, RefRangeEnd = 1278310, XrefRangeStart = 1278247, XrefRangeEnd = 1278306, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Character GetCharacterFromFontAsset_Internal(uint unicode, FontAsset sourceFontAsset, bool includeFallbacks, FontStyles fontStyle, TextFontWeight fontWeight, out bool isAlternativeTypeface, bool populateLigatures)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[7];
		*ptr = (nint)(&unicode);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)sourceFontAsset);
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &includeFallbacks;
		*(FontStyles**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &fontStyle;
		*(TextFontWeight**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &fontWeight;
		*(void**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref isAlternativeTypeface);
		*(bool**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = &populateLigatures;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetCharacterFromFontAsset_Internal_Private_Static_Character_UInt32_FontAsset_Boolean_FontStyles_TextFontWeight_byref_Boolean_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Character>(intPtr2) : null;
	}

	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 1278327, RefRangeEnd = 1278334, XrefRangeStart = 1278310, XrefRangeEnd = 1278327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Character GetCharacterFromFontAssetsInternal(uint unicode, FontAsset sourceFontAsset, List<FontAsset> fontAssets, List<FontAsset> OSFallbackList, bool includeFallbacks, FontStyles fontStyle, TextFontWeight fontWeight, out bool isAlternativeTypeface, bool populateLigatures = true)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[9];
		*ptr = (nint)(&unicode);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)sourceFontAsset);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)fontAssets);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)OSFallbackList);
		*(bool**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &includeFallbacks;
		*(FontStyles**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &fontStyle;
		*(TextFontWeight**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = &fontWeight;
		*(void**)((byte*)ptr + checked((nuint)7u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref isAlternativeTypeface);
		*(bool**)((byte*)ptr + checked((nuint)8u * unchecked((nuint)sizeof(System.IntPtr)))) = &populateLigatures;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetCharacterFromFontAssetsInternal_Internal_Static_Character_UInt32_FontAsset_List_1_FontAsset_List_1_FontAsset_Boolean_FontStyles_TextFontWeight_byref_Boolean_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Character>(intPtr2) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1278358, RefRangeEnd = 1278360, XrefRangeStart = 1278334, XrefRangeEnd = 1278358, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Character GetCharacterFromFontAssetsInternal(uint unicode, List<FontAsset> fontAssets, bool includeFallbacks, FontStyles fontStyle, TextFontWeight fontWeight, out bool isAlternativeTypeface, bool populateLigatures = true)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[7];
		*ptr = (nint)(&unicode);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)fontAssets);
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &includeFallbacks;
		*(FontStyles**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &fontStyle;
		*(TextFontWeight**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &fontWeight;
		*(void**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref isAlternativeTypeface);
		*(bool**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = &populateLigatures;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetCharacterFromFontAssetsInternal_Private_Static_Character_UInt32_List_1_FontAsset_Boolean_FontStyles_TextFontWeight_byref_Boolean_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Character>(intPtr2) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1278399, RefRangeEnd = 1278401, XrefRangeStart = 1278360, XrefRangeEnd = 1278399, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static TextElement GetTextElementFromTextAssets(uint unicode, FontAsset sourceFontAsset, List<TextAsset> textAssets, bool includeFallbacks, FontStyles fontStyle, TextFontWeight fontWeight, out bool isAlternativeTypeface, bool populateLigatures)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[8];
		*ptr = (nint)(&unicode);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)sourceFontAsset);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)textAssets);
		*(bool**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &includeFallbacks;
		*(FontStyles**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &fontStyle;
		*(TextFontWeight**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &fontWeight;
		*(void**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref isAlternativeTypeface);
		*(bool**)((byte*)ptr + checked((nuint)7u * unchecked((nuint)sizeof(System.IntPtr)))) = &populateLigatures;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetTextElementFromTextAssets_Internal_Static_TextElement_UInt32_FontAsset_List_1_TextAsset_Boolean_FontStyles_TextFontWeight_byref_Boolean_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<TextElement>(intPtr2) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1278440, RefRangeEnd = 1278441, XrefRangeStart = 1278401, XrefRangeEnd = 1278440, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static SpriteCharacter GetSpriteCharacterFromSpriteAsset(uint unicode, SpriteAsset spriteAsset, bool includeFallbacks)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&unicode);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)spriteAsset);
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &includeFallbacks;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetSpriteCharacterFromSpriteAsset_Public_Static_SpriteCharacter_UInt32_SpriteAsset_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<SpriteCharacter>(intPtr2) : null;
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1278459, RefRangeEnd = 1278462, XrefRangeStart = 1278441, XrefRangeEnd = 1278459, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static SpriteCharacter GetSpriteCharacterFromSpriteAsset_Internal(uint unicode, SpriteAsset spriteAsset, bool includeFallbacks)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&unicode);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)spriteAsset);
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &includeFallbacks;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetSpriteCharacterFromSpriteAsset_Internal_Private_Static_SpriteCharacter_UInt32_SpriteAsset_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<SpriteCharacter>(intPtr2) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1278474, RefRangeEnd = 1278475, XrefRangeStart = 1278462, XrefRangeEnd = 1278474, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static uint GetCodePoint(string text, ref int index)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref index);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetCodePoint_Public_Static_UInt32_String_byref_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(uint*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1278475, XrefRangeEnd = 1278484, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static uint GetCodePoint(Il2CppStructArray<uint> codesPoints, ref int index)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)codesPoints);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref index);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetCodePoint_Public_Static_UInt32_Il2CppStructArray_1_UInt32_byref_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(uint*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	public FontAssetUtilities(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public static Character GetCharacterFromFontAssets(uint unicode, FontAsset sourceFontAsset, List<FontAsset> fontAssets, List<FontAsset> OSFallbackList, bool includeFallbacks, FontStyles fontStyle, TextFontWeight fontWeight, out bool isAlternativeTypeface)
	{
		return GetCharacterFromFontAssetsInternal(unicode, sourceFontAsset, fontAssets, OSFallbackList, includeFallbacks, fontStyle, fontWeight, out isAlternativeTypeface);
	}
}
