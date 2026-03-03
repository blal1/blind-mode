using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Il2CppTMPro;

public class TMP_FontAssetUtilities : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_s_Instance;

	private static readonly System.IntPtr NativeFieldInfoPtr_k_SearchedAssets;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_instance_Public_Static_get_TMP_FontAssetUtilities_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetCharacterFromFontAsset_Public_Static_TMP_Character_UInt32_TMP_FontAsset_Boolean_FontStyles_FontWeight_byref_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetCharacterFromFontAsset_Internal_Private_Static_TMP_Character_UInt32_TMP_FontAsset_Boolean_FontStyles_FontWeight_byref_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SearchFallbacksForCharacter_Private_Static_TMP_Character_UInt32_TMP_FontAsset_FontStyles_FontWeight_byref_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetCharacterFromFontAssets_Public_Static_TMP_Character_UInt32_TMP_FontAsset_List_1_TMP_FontAsset_Boolean_FontStyles_FontWeight_byref_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetTextElementFromTextAssets_Internal_Static_TMP_TextElement_UInt32_TMP_FontAsset_List_1_TMP_Asset_Boolean_FontStyles_FontWeight_byref_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetSpriteCharacterFromSpriteAsset_Public_Static_TMP_SpriteCharacter_UInt32_TMP_SpriteAsset_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetSpriteCharacterFromSpriteAsset_Internal_Private_Static_TMP_SpriteCharacter_UInt32_TMP_SpriteAsset_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetCodePoint_Internal_Static_UInt32_String_byref_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetCodePoint_Internal_Static_UInt32_Il2CppStructArray_1_UInt32_byref_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe static TMP_FontAssetUtilities s_Instance
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_Instance, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<TMP_FontAssetUtilities>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_Instance, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

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

	public unsafe static TMP_FontAssetUtilities instance
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1124247, XrefRangeEnd = 1124251, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_instance_Public_Static_get_TMP_FontAssetUtilities_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<TMP_FontAssetUtilities>(intPtr2) : null;
		}
	}

	static TMP_FontAssetUtilities()
	{
		Il2CppClassPointerStore<TMP_FontAssetUtilities>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.TextMeshPro.dll", "TMPro", "TMP_FontAssetUtilities");
		NativeFieldInfoPtr_s_Instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_FontAssetUtilities>.NativeClassPtr, "s_Instance");
		NativeFieldInfoPtr_k_SearchedAssets = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_FontAssetUtilities>.NativeClassPtr, "k_SearchedAssets");
		NativeMethodInfoPtr_get_instance_Public_Static_get_TMP_FontAssetUtilities_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FontAssetUtilities>.NativeClassPtr, 100664001);
		NativeMethodInfoPtr_GetCharacterFromFontAsset_Public_Static_TMP_Character_UInt32_TMP_FontAsset_Boolean_FontStyles_FontWeight_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FontAssetUtilities>.NativeClassPtr, 100664002);
		NativeMethodInfoPtr_GetCharacterFromFontAsset_Internal_Private_Static_TMP_Character_UInt32_TMP_FontAsset_Boolean_FontStyles_FontWeight_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FontAssetUtilities>.NativeClassPtr, 100664003);
		NativeMethodInfoPtr_SearchFallbacksForCharacter_Private_Static_TMP_Character_UInt32_TMP_FontAsset_FontStyles_FontWeight_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FontAssetUtilities>.NativeClassPtr, 100664004);
		NativeMethodInfoPtr_GetCharacterFromFontAssets_Public_Static_TMP_Character_UInt32_TMP_FontAsset_List_1_TMP_FontAsset_Boolean_FontStyles_FontWeight_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FontAssetUtilities>.NativeClassPtr, 100664005);
		NativeMethodInfoPtr_GetTextElementFromTextAssets_Internal_Static_TMP_TextElement_UInt32_TMP_FontAsset_List_1_TMP_Asset_Boolean_FontStyles_FontWeight_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FontAssetUtilities>.NativeClassPtr, 100664006);
		NativeMethodInfoPtr_GetSpriteCharacterFromSpriteAsset_Public_Static_TMP_SpriteCharacter_UInt32_TMP_SpriteAsset_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FontAssetUtilities>.NativeClassPtr, 100664007);
		NativeMethodInfoPtr_GetSpriteCharacterFromSpriteAsset_Internal_Private_Static_TMP_SpriteCharacter_UInt32_TMP_SpriteAsset_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FontAssetUtilities>.NativeClassPtr, 100664008);
		NativeMethodInfoPtr_GetCodePoint_Internal_Static_UInt32_String_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FontAssetUtilities>.NativeClassPtr, 100664009);
		NativeMethodInfoPtr_GetCodePoint_Internal_Static_UInt32_Il2CppStructArray_1_UInt32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FontAssetUtilities>.NativeClassPtr, 100664010);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FontAssetUtilities>.NativeClassPtr, 100664011);
	}

	[CallerCount(13)]
	[CachedScanResults(RefRangeStart = 1124276, RefRangeEnd = 1124289, XrefRangeStart = 1124251, XrefRangeEnd = 1124276, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static TMP_Character GetCharacterFromFontAsset(uint unicode, TMP_FontAsset sourceFontAsset, bool includeFallbacks, FontStyles fontStyle, FontWeight fontWeight, out bool isAlternativeTypeface)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = (nint)(&unicode);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)sourceFontAsset);
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &includeFallbacks;
		*(FontStyles**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &fontStyle;
		*(FontWeight**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &fontWeight;
		*(void**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref isAlternativeTypeface);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetCharacterFromFontAsset_Public_Static_TMP_Character_UInt32_TMP_FontAsset_Boolean_FontStyles_FontWeight_byref_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<TMP_Character>(intPtr2) : null;
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 1124307, RefRangeEnd = 1124311, XrefRangeStart = 1124289, XrefRangeEnd = 1124307, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static TMP_Character GetCharacterFromFontAsset_Internal(uint unicode, TMP_FontAsset sourceFontAsset, bool includeFallbacks, FontStyles fontStyle, FontWeight fontWeight, out bool isAlternativeTypeface)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = (nint)(&unicode);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)sourceFontAsset);
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &includeFallbacks;
		*(FontStyles**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &fontStyle;
		*(FontWeight**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &fontWeight;
		*(void**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref isAlternativeTypeface);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetCharacterFromFontAsset_Internal_Private_Static_TMP_Character_UInt32_TMP_FontAsset_Boolean_FontStyles_FontWeight_byref_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<TMP_Character>(intPtr2) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1124330, RefRangeEnd = 1124331, XrefRangeStart = 1124311, XrefRangeEnd = 1124330, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static TMP_Character SearchFallbacksForCharacter(uint unicode, TMP_FontAsset sourceFontAsset, FontStyles fontStyle, FontWeight fontWeight, out bool isAlternativeTypeface)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = (nint)(&unicode);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)sourceFontAsset);
		*(FontStyles**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &fontStyle;
		*(FontWeight**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &fontWeight;
		*(void**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref isAlternativeTypeface);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SearchFallbacksForCharacter_Private_Static_TMP_Character_UInt32_TMP_FontAsset_FontStyles_FontWeight_byref_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<TMP_Character>(intPtr2) : null;
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 1124363, RefRangeEnd = 1124368, XrefRangeStart = 1124331, XrefRangeEnd = 1124363, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static TMP_Character GetCharacterFromFontAssets(uint unicode, TMP_FontAsset sourceFontAsset, List<TMP_FontAsset> fontAssets, bool includeFallbacks, FontStyles fontStyle, FontWeight fontWeight, out bool isAlternativeTypeface)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[7];
		*ptr = (nint)(&unicode);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)sourceFontAsset);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)fontAssets);
		*(bool**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &includeFallbacks;
		*(FontStyles**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &fontStyle;
		*(FontWeight**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &fontWeight;
		*(void**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref isAlternativeTypeface);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetCharacterFromFontAssets_Public_Static_TMP_Character_UInt32_TMP_FontAsset_List_1_TMP_FontAsset_Boolean_FontStyles_FontWeight_byref_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<TMP_Character>(intPtr2) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1124417, RefRangeEnd = 1124419, XrefRangeStart = 1124368, XrefRangeEnd = 1124417, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static TMP_TextElement GetTextElementFromTextAssets(uint unicode, TMP_FontAsset sourceFontAsset, List<TMP_Asset> textAssets, bool includeFallbacks, FontStyles fontStyle, FontWeight fontWeight, out bool isAlternativeTypeface)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[7];
		*ptr = (nint)(&unicode);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)sourceFontAsset);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)textAssets);
		*(bool**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &includeFallbacks;
		*(FontStyles**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &fontStyle;
		*(FontWeight**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &fontWeight;
		*(void**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref isAlternativeTypeface);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetTextElementFromTextAssets_Internal_Static_TMP_TextElement_UInt32_TMP_FontAsset_List_1_TMP_Asset_Boolean_FontStyles_FontWeight_byref_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<TMP_TextElement>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1124419, XrefRangeEnd = 1124471, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static TMP_SpriteCharacter GetSpriteCharacterFromSpriteAsset(uint unicode, TMP_SpriteAsset spriteAsset, bool includeFallbacks)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&unicode);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)spriteAsset);
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &includeFallbacks;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetSpriteCharacterFromSpriteAsset_Public_Static_TMP_SpriteCharacter_UInt32_TMP_SpriteAsset_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<TMP_SpriteCharacter>(intPtr2) : null;
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1124494, RefRangeEnd = 1124497, XrefRangeStart = 1124471, XrefRangeEnd = 1124494, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static TMP_SpriteCharacter GetSpriteCharacterFromSpriteAsset_Internal(uint unicode, TMP_SpriteAsset spriteAsset, bool includeFallbacks)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&unicode);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)spriteAsset);
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &includeFallbacks;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetSpriteCharacterFromSpriteAsset_Internal_Private_Static_TMP_SpriteCharacter_UInt32_TMP_SpriteAsset_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<TMP_SpriteCharacter>(intPtr2) : null;
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1124509, RefRangeEnd = 1124512, XrefRangeStart = 1124497, XrefRangeEnd = 1124509, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static uint GetCodePoint(string text, ref int index)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref index);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetCodePoint_Internal_Static_UInt32_String_byref_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(uint*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1124521, RefRangeEnd = 1124522, XrefRangeStart = 1124512, XrefRangeEnd = 1124521, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static uint GetCodePoint(Il2CppStructArray<uint> codesPoints, ref int index)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)codesPoints);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref index);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetCodePoint_Internal_Static_UInt32_Il2CppStructArray_1_UInt32_byref_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(uint*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1950)]
	[CachedScanResults(RefRangeStart = 20036, RefRangeEnd = 21986, XrefRangeStart = 20036, XrefRangeEnd = 21986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe TMP_FontAssetUtilities()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TMP_FontAssetUtilities>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public TMP_FontAssetUtilities(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
