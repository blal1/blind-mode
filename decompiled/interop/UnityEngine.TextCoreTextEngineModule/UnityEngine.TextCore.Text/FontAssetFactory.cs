using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine.TextCore.LowLevel;

namespace UnityEngine.TextCore.Text;

public class FontAssetFactory : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_visitedFontAssets;

	private static readonly System.IntPtr NativeMethodInfoPtr_ConvertFontToFontAsset_Internal_Static_FontAsset_Font_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetupFontAssetSettings_Internal_Static_Void_FontAsset_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetHideFlags_Public_Static_Void_FontAsset_0;

	public const GlyphRenderMode k_DefaultEditorBitmapGlyphRenderMode = GlyphRenderMode.SMOOTH_HINTED;

	public unsafe static HashSet<FontAsset> visitedFontAssets
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_visitedFontAssets, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<HashSet<FontAsset>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_visitedFontAssets, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	static FontAssetFactory()
	{
		Il2CppClassPointerStore<FontAssetFactory>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.TextCoreTextEngineModule.dll", "UnityEngine.TextCore.Text", "FontAssetFactory");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FontAssetFactory>.NativeClassPtr);
		NativeFieldInfoPtr_visitedFontAssets = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FontAssetFactory>.NativeClassPtr, "visitedFontAssets");
		NativeMethodInfoPtr_ConvertFontToFontAsset_Internal_Static_FontAsset_Font_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontAssetFactory>.NativeClassPtr, 100663577);
		NativeMethodInfoPtr_SetupFontAssetSettings_Internal_Static_Void_FontAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontAssetFactory>.NativeClassPtr, 100663578);
		NativeMethodInfoPtr_SetHideFlags_Public_Static_Void_FontAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontAssetFactory>.NativeClassPtr, 100663579);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1278199, RefRangeEnd = 1278200, XrefRangeStart = 1278174, XrefRangeEnd = 1278199, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static FontAsset ConvertFontToFontAsset(Font font)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)font);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ConvertFontToFontAsset_Internal_Static_FontAsset_Font_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<FontAsset>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1278200, XrefRangeEnd = 1278208, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetupFontAssetSettings(FontAsset fontAsset)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)fontAsset);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetupFontAssetSettings_Internal_Static_Void_FontAsset_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1278215, RefRangeEnd = 1278218, XrefRangeStart = 1278208, XrefRangeEnd = 1278215, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetHideFlags(FontAsset fontAsset)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)fontAsset);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetHideFlags_Public_Static_Void_FontAsset_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public FontAssetFactory(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public static FontAsset CloneFontAssetWithBitmapRendering(FontAsset baseFontAsset, int fontSize)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	public static FontAsset CloneFontAssetWithBitmapRenderingInternal(FontAsset baseFontAsset, int fontSize)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	public unsafe static FontAsset CloneFontAssetWithBitmapSettings(FontAsset source, int size)
	{
		//IL_0042: Expected O, but got Ref
		//IL_0050: Expected O, but got Ref
		bool flag = source.atlasRenderMode != GlyphRenderMode.SDFAA || !source.IsEditorFont || source.sourceFontFile == null;
		FontAsset fontAsset;
		if (source.atlasPopulationMode == AtlasPopulationMode.DynamicOS)
		{
			FaceInfo faceInfo = source.faceInfo;
			string familyName = ((FaceInfo)(&faceInfo)).familyName;
			faceInfo = source.faceInfo;
			fontAsset = FontAsset.CreateFontAsset(familyName, ((FaceInfo)(&faceInfo)).styleName, size, 6, GlyphRenderMode.SMOOTH_HINTED);
			if (fontAsset != null)
			{
				SetupFontAssetForBitmapSettings(fontAsset);
			}
		}
		else if (flag)
		{
			fontAsset = Object.Instantiate(source);
			if (fontAsset != null)
			{
				fontAsset.fallbackFontAssetTable = new List<FontAsset>();
				fontAsset.m_IsClone = true;
				fontAsset.IsEditorFont = true;
				SetHideFlags(fontAsset);
			}
		}
		else
		{
			fontAsset = FontAsset.CreateFontAsset(source.sourceFontFile, size, 6, GlyphRenderMode.SMOOTH_HINTED, source.atlasWidth, source.atlasHeight);
			if (fontAsset != null)
			{
				SetupFontAssetForBitmapSettings(fontAsset);
			}
		}
		return fontAsset;
	}

	public static void ProcessFontWeights(FontAsset resultFontAsset, FontAsset baseFontAsset, int fontSize)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	public static void ProcessFallbackFonts(FontAsset resultFontAsset, FontAsset baseFontAsset, int fontSize)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	public static void SetupFontAssetForBitmapSettings(FontAsset fontAsset)
	{
		if ((bool)fontAsset)
		{
			SetHideFlags(fontAsset);
			fontAsset.IsEditorFont = true;
			fontAsset.isMultiAtlasTexturesEnabled = true;
			fontAsset.atlasTexture.filterMode = FilterMode.Point;
		}
	}
}
