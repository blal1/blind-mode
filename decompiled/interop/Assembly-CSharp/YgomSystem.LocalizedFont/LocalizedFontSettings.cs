using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

namespace YgomSystem.LocalizedFont;

[Token(Token = "0x2000292")]
public abstract class LocalizedFontSettings<T_FONT> : LocalizedFontSettingsBase where T_FONT : UnityEngine.Object
{
	[Serializable]
	[Token(Token = "0x2000293")]
	public class LocalizedFontMaterialEntry
	{
		[Token(Token = "0x4000EC2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public string path;

		[Token(Token = "0x4000EC3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public string name;

		[Token(Token = "0x6000FC2")]
		public LocalizedFontMaterialEntry()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x2000294")]
	public class LocalizedFontLocaleEntry
	{
		[Token(Token = "0x4000EC4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Locale locale;

		[Token(Token = "0x4000EC5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public string fontPath;

		[Token(Token = "0x4000EC6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public string fontName;

		[Token(Token = "0x4000EC7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public LocalizedFontMaterialEntry[] materials;

		[Token(Token = "0x6000FC3")]
		public LocalizedFontLocaleEntry()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x2000295")]
	public class LocalizedFontEntry
	{
		[Token(Token = "0x4000EC8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public FontType fontType;

		[Token(Token = "0x4000EC9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public LocalizedFontLocaleEntry[] locales;

		[Token(Token = "0x6000FC4")]
		public LocalizedFontEntry()
		{
		}
	}

	[Token(Token = "0x2000296")]
	private class LoadedFontEntry
	{
		[Token(Token = "0x4000ECA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public string fontPath;

		[Token(Token = "0x4000ECB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public T_FONT font;

		[Token(Token = "0x4000ECC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Material defaultMaterial;

		[Token(Token = "0x4000ECD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Material[] materials;

		[Token(Token = "0x6000FC5")]
		public LoadedFontEntry()
		{
		}
	}

	[Token(Token = "0x4000EB9")]
	private const string k_DummyFontPath = "Fonts/YGOMD-TestFont1 SDF";

	[Token(Token = "0x4000EBA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	[SerializeField]
	protected LocalizedFontEntry[] localizedFonts;

	[Token(Token = "0x4000EBB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private Dictionary<FontType, LoadedFontEntry> m_loadedFonts;

	[Token(Token = "0x4000EBC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private bool m_localeInitialized;

	[Token(Token = "0x4000EBD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private Locale m_localeCache;

	[Token(Token = "0x4000EBE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public bool raiseErrorOnLoadImmediateFont;

	[Token(Token = "0x4000EBF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private Locale m_oldLocale;

	[Token(Token = "0x4000EC0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private Dictionary<FontType, LocalizedFontLocaleEntry> m_otherFonts;

	[Token(Token = "0x4000EC1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private Dictionary<string, LoadedFontEntry> m_fontCache;

	[Token(Token = "0x6000FAD")]
	public LocalizedFontLocaleEntry GetLocalizedFontLocaleEntry(FontType fontType, Locale locale)
	{
		return null;
	}

	[Token(Token = "0x6000FAE")]
	public (FontType, LocalizedFontLocaleEntry) GetEntryFromOtherFontName(string otherFontName)
	{
		return default((FontType, LocalizedFontLocaleEntry));
	}

	[Token(Token = "0x6000FAF")]
	public FontType GetFontTypeFromOtherFontName(string otherFontName)
	{
		return default(FontType);
	}

	[Token(Token = "0x6000FB0")]
	public void UpdateLocaleCache()
	{
	}

	[Token(Token = "0x6000FB1")]
	public Locale GetCurrentLocale(bool updateCache = false)
	{
		return default(Locale);
	}

	[Token(Token = "0x6000FB2")]
	private Material _getFontMaterial(FontType fontType, LoadedFontEntry lfe, Material mat)
	{
		return null;
	}

	[Token(Token = "0x6000FB3")]
	public (T_FONT, Material) GetLocalized(FontType fontType, int materialIndex, Locale locale)
	{
		return default((T_FONT, Material));
	}

	[Token(Token = "0x6000FB4")]
	public (T_FONT, Material) GetLocalized(FontType fontType, int materialIndex)
	{
		return default((T_FONT, Material));
	}

	[Token(Token = "0x6000FB5")]
	public T_FONT GetLocalizedFont(FontType fontType, Locale locale)
	{
		return null;
	}

	[Token(Token = "0x6000FB6")]
	public T_FONT GetLocalizedFont(FontType fontType)
	{
		return null;
	}

	[Token(Token = "0x6000FB7")]
	public void LoadFonts()
	{
	}

	[Token(Token = "0x6000FB8")]
	public bool IsFontsLoaded()
	{
		return default(bool);
	}

	[Token(Token = "0x6000FB9")]
	private LoadedFontEntry _getLocalizedFontEntry(FontType fontType, LocalizedFontLocaleEntry lfle)
	{
		return null;
	}

	[Token(Token = "0x6000FBA")]
	public (T_FONT, Material) ToLocalized(T_FONT font, Material mat)
	{
		return default((T_FONT, Material));
	}

	[Token(Token = "0x6000FBB")]
	public T_FONT ToLocalizedFont(T_FONT font)
	{
		return null;
	}

	[Token(Token = "0x6000FBC")]
	public void ClearFontCache()
	{
	}

	[Token(Token = "0x6000FBD")]
	private void RemoveFontAssetFromTMPResourceManager(UnityEngine.Object fontAsset, [Optional] List<TMP_FontAsset> removedFonts)
	{
	}

	[Token(Token = "0x6000FBE")]
	private void RemoveFontAssetFromTMPResourceManager(TMP_FontAsset fontAsset, [Optional] List<TMP_FontAsset> removedFonts)
	{
	}

	[Token(Token = "0x6000FBF")]
	protected abstract string GetFontName(T_FONT font);

	[Token(Token = "0x6000FC0")]
	protected virtual Material GetFontMaterial(T_FONT font)
	{
		return null;
	}

	[Token(Token = "0x6000FC1")]
	protected LocalizedFontSettings()
	{
	}
}
