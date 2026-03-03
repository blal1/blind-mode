using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Il2CppTMPro;

public static class TMP_FontUtilities : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_k_searchedFontAssets;

	private static readonly System.IntPtr NativeMethodInfoPtr_SearchForCharacter_Public_Static_TMP_FontAsset_TMP_FontAsset_UInt32_byref_TMP_Character_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SearchForCharacter_Public_Static_TMP_FontAsset_List_1_TMP_FontAsset_UInt32_byref_TMP_Character_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SearchForCharacterInternal_Private_Static_TMP_FontAsset_TMP_FontAsset_UInt32_byref_TMP_Character_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SearchForCharacterInternal_Private_Static_TMP_FontAsset_List_1_TMP_FontAsset_UInt32_byref_TMP_Character_0;

	public unsafe static List<int> k_searchedFontAssets
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_k_searchedFontAssets, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<int>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_k_searchedFontAssets, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	static TMP_FontUtilities()
	{
		Il2CppClassPointerStore<TMP_FontUtilities>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.TextMeshPro.dll", "TMPro", "TMP_FontUtilities");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TMP_FontUtilities>.NativeClassPtr);
		NativeFieldInfoPtr_k_searchedFontAssets = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_FontUtilities>.NativeClassPtr, "k_searchedFontAssets");
		NativeMethodInfoPtr_SearchForCharacter_Public_Static_TMP_FontAsset_TMP_FontAsset_UInt32_byref_TMP_Character_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FontUtilities>.NativeClassPtr, 100663996);
		NativeMethodInfoPtr_SearchForCharacter_Public_Static_TMP_FontAsset_List_1_TMP_FontAsset_UInt32_byref_TMP_Character_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FontUtilities>.NativeClassPtr, 100663997);
		NativeMethodInfoPtr_SearchForCharacterInternal_Private_Static_TMP_FontAsset_TMP_FontAsset_UInt32_byref_TMP_Character_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FontUtilities>.NativeClassPtr, 100663998);
		NativeMethodInfoPtr_SearchForCharacterInternal_Private_Static_TMP_FontAsset_List_1_TMP_FontAsset_UInt32_byref_TMP_Character_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FontUtilities>.NativeClassPtr, 100663999);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1124164, XrefRangeEnd = 1124179, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static TMP_FontAsset SearchForCharacter(TMP_FontAsset font, uint unicode, out TMP_Character character)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)font);
		*(uint**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &unicode;
		byte* num = (byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)));
		nint num2 = 0;
		*(nint**)num = &num2;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SearchForCharacter_Public_Static_TMP_FontAsset_TMP_FontAsset_UInt32_byref_TMP_Character_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		nint num3 = num2;
		character = ((num3 == 0) ? null : new TMP_Character(num3));
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<TMP_FontAsset>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1124179, XrefRangeEnd = 1124191, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static TMP_FontAsset SearchForCharacter(List<TMP_FontAsset> fonts, uint unicode, out TMP_Character character)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)fonts);
		*(uint**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &unicode;
		byte* num = (byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)));
		nint num2 = 0;
		*(nint**)num = &num2;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SearchForCharacter_Public_Static_TMP_FontAsset_List_1_TMP_FontAsset_UInt32_byref_TMP_Character_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		nint num3 = num2;
		character = ((num3 == 0) ? null : new TMP_Character(num3));
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<TMP_FontAsset>(intPtr2) : null;
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 1124231, RefRangeEnd = 1124235, XrefRangeStart = 1124191, XrefRangeEnd = 1124231, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static TMP_FontAsset SearchForCharacterInternal(TMP_FontAsset font, uint unicode, out TMP_Character character)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)font);
		*(uint**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &unicode;
		byte* num = (byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)));
		nint num2 = 0;
		*(nint**)num = &num2;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SearchForCharacterInternal_Private_Static_TMP_FontAsset_TMP_FontAsset_UInt32_byref_TMP_Character_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		nint num3 = num2;
		character = ((num3 == 0) ? null : new TMP_Character(num3));
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<TMP_FontAsset>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1124235, XrefRangeEnd = 1124247, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static TMP_FontAsset SearchForCharacterInternal(List<TMP_FontAsset> fonts, uint unicode, out TMP_Character character)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)fonts);
		*(uint**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &unicode;
		byte* num = (byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)));
		nint num2 = 0;
		*(nint**)num = &num2;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SearchForCharacterInternal_Private_Static_TMP_FontAsset_List_1_TMP_FontAsset_UInt32_byref_TMP_Character_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		nint num3 = num2;
		character = ((num3 == 0) ? null : new TMP_Character(num3));
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<TMP_FontAsset>(intPtr2) : null;
	}

	public TMP_FontUtilities(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
