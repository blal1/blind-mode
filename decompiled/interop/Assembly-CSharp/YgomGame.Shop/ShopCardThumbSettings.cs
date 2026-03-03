using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace YgomGame.Shop;

[Token(Token = "0x20009CE")]
[CreateAssetMenu]
public class ShopCardThumbSettings : ScriptableObject
{
	[Serializable]
	[Token(Token = "0x20009CF")]
	public class ThumbSetting : IRawImageUVSetting
	{
		[Token(Token = "0x4008DDC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int mrk;

		[Token(Token = "0x4008DDD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public Vector2 uvRectPos;

		[Token(Token = "0x4008DDE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Vector2 uvRectSize;

		[NonSerialized]
		[Token(Token = "0x4008DDF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float aspectRatio;

		[Token(Token = "0x6003BD3")]
		[Address(RVA = "0x83EC80", Offset = "0x83DE80", VA = "0x18083EC80")]
		public bool EqualSetting(ThumbSetting other)
		{
			return default(bool);
		}

		[Token(Token = "0x6003BD4")]
		[Address(RVA = "0x83EE00", Offset = "0x83E000", VA = "0x18083EE00")]
		public ThumbSetting(int mrk)
		{
		}

		[Token(Token = "0x6003BD5")]
		[Address(RVA = "0x83EEB0", Offset = "0x83E0B0", VA = "0x18083EEB0")]
		public ThumbSetting(int mrk, ThumbSetting source)
		{
		}

		[Token(Token = "0x6003BD6")]
		[Address(RVA = "0x83ED60", Offset = "0x83DF60", VA = "0x18083ED60", Slot = "4")]
		public void ImportRawImage(RawImage rawImage)
		{
		}

		[Token(Token = "0x6003BD7")]
		[Address(RVA = "0x83ED00", Offset = "0x83DF00", VA = "0x18083ED00", Slot = "5")]
		public void ExportRawImage(RawImage rawImage)
		{
		}

		[Token(Token = "0x6003BD8")]
		[Address(RVA = "0x83EDB0", Offset = "0x83DFB0", VA = "0x18083EDB0")]
		public void ImportSetting(ThumbSetting source)
		{
		}
	}

	[Serializable]
	[Token(Token = "0x20009D0")]
	private class SettingMap
	{
		[Token(Token = "0x4008DE0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[SerializeField]
		private List<ThumbSetting> m_Settings;

		[Token(Token = "0x4008DE1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Dictionary<int, ThumbSetting> m_SettingsMap;

		[Token(Token = "0x4008DE2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private ThumbSetting m_DefaultSetting;

		[Token(Token = "0x170007E8")]
		public ThumbSetting defaultSetting
		{
			[Token(Token = "0x6003BD9")]
			[Address(RVA = "0x3D8370", Offset = "0x3D7570", VA = "0x1803D8370")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6003BDA")]
		[Address(RVA = "0x824F30", Offset = "0x824130", VA = "0x180824F30")]
		public void ClearCache()
		{
		}

		[Token(Token = "0x6003BDB")]
		[Address(RVA = "0x824F80", Offset = "0x824180", VA = "0x180824F80")]
		public ThumbSetting GetSetting(int mrk)
		{
			return null;
		}

		[Token(Token = "0x6003BDC")]
		[Address(RVA = "0x8253B0", Offset = "0x8245B0", VA = "0x1808253B0")]
		public bool IsExists(int mrk)
		{
			return default(bool);
		}

		[Token(Token = "0x6003BDD")]
		[Address(RVA = "0x8251F0", Offset = "0x8243F0", VA = "0x1808251F0")]
		public void Import(int mrk, RawImage rawImage)
		{
		}

		[Token(Token = "0x6003BDE")]
		[Address(RVA = "0x8252D0", Offset = "0x8244D0", VA = "0x1808252D0")]
		public void Import(ThumbSetting source)
		{
		}

		[Token(Token = "0x6003BDF")]
		[Address(RVA = "0x825480", Offset = "0x824680", VA = "0x180825480")]
		public void RemoveByMrk(int mrk)
		{
		}

		[Token(Token = "0x6003BE0")]
		[Address(RVA = "0x8255C0", Offset = "0x8247C0", VA = "0x1808255C0")]
		public SettingMap()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x20009D4")]
	public class ImageThumbSetting : IRawImageUVSetting
	{
		[Token(Token = "0x4008DE6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string path;

		[Token(Token = "0x4008DE7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Vector2 uvRectPos;

		[Token(Token = "0x4008DE8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Vector2 uvRectSize;

		[NonSerialized]
		[Token(Token = "0x4008DE9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float aspectRatio;

		[Token(Token = "0x6003BE7")]
		[Address(RVA = "0x8229F0", Offset = "0x821BF0", VA = "0x1808229F0")]
		public bool EqualSetting(ImageThumbSetting other)
		{
			return default(bool);
		}

		[Token(Token = "0x6003BE8")]
		[Address(RVA = "0x822AF0", Offset = "0x821CF0", VA = "0x180822AF0")]
		public bool IsEmpty()
		{
			return default(bool);
		}

		[Token(Token = "0x6003BE9")]
		[Address(RVA = "0x822BD0", Offset = "0x821DD0", VA = "0x180822BD0")]
		public ImageThumbSetting(string path)
		{
		}

		[Token(Token = "0x6003BEA")]
		[Address(RVA = "0x822C90", Offset = "0x821E90", VA = "0x180822C90")]
		public ImageThumbSetting(string path, ImageThumbSetting source)
		{
		}

		[Token(Token = "0x6003BEB")]
		[Address(RVA = "0x778880", Offset = "0x777A80", VA = "0x180778880", Slot = "4")]
		public void ImportRawImage(RawImage rawImage)
		{
		}

		[Token(Token = "0x6003BEC")]
		[Address(RVA = "0x7787D0", Offset = "0x7779D0", VA = "0x1807787D0", Slot = "5")]
		public void ExportRawImage(RawImage rawImage)
		{
		}

		[Token(Token = "0x6003BED")]
		[Address(RVA = "0x822A90", Offset = "0x821C90", VA = "0x180822A90")]
		public void ImportSetting(ImageThumbSetting source)
		{
		}
	}

	[Serializable]
	[Token(Token = "0x20009D5")]
	private class ImageThumbSettingMap
	{
		[Token(Token = "0x4008DEA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[SerializeField]
		private List<ImageThumbSetting> m_Settings;

		[Token(Token = "0x4008DEB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Dictionary<string, ImageThumbSetting> m_SettingsMap;

		[Token(Token = "0x4008DEC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private ImageThumbSetting m_DefaultSetting;

		[Token(Token = "0x4008DED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private List<ImageThumbSetting> m_DefaultRegSettings;

		[Token(Token = "0x170007E9")]
		public ImageThumbSetting defaultSetting
		{
			[Token(Token = "0x6003BEE")]
			[Address(RVA = "0x3D8370", Offset = "0x3D7570", VA = "0x1803D8370")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170007EA")]
		public List<ImageThumbSetting> defaultRegSettings
		{
			[Token(Token = "0x6003BEF")]
			[Address(RVA = "0x4030F0", Offset = "0x4022F0", VA = "0x1804030F0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6003BF0")]
		[Address(RVA = "0x8220E0", Offset = "0x8212E0", VA = "0x1808220E0")]
		public void ClearCache()
		{
		}

		[Token(Token = "0x6003BF1")]
		[Address(RVA = "0x822130", Offset = "0x821330", VA = "0x180822130")]
		public ImageThumbSetting GetSetting(string path)
		{
			return null;
		}

		[Token(Token = "0x6003BF2")]
		[Address(RVA = "0x8226A0", Offset = "0x8218A0", VA = "0x1808226A0")]
		public bool IsExists(string path)
		{
			return default(bool);
		}

		[Token(Token = "0x6003BF3")]
		[Address(RVA = "0x822580", Offset = "0x821780", VA = "0x180822580")]
		public void Import(string path, RawImage rawImage)
		{
		}

		[Token(Token = "0x6003BF4")]
		[Address(RVA = "0x822450", Offset = "0x821650", VA = "0x180822450")]
		public void Import(ImageThumbSetting source)
		{
		}

		[Token(Token = "0x6003BF5")]
		[Address(RVA = "0x822780", Offset = "0x821980", VA = "0x180822780")]
		public void RemoveByPath(string path)
		{
		}

		[Token(Token = "0x6003BF6")]
		[Address(RVA = "0x8228D0", Offset = "0x821AD0", VA = "0x1808228D0")]
		public ImageThumbSettingMap()
		{
		}
	}

	[Token(Token = "0x20009D8")]
	public enum Format
	{
		[Token(Token = "0x4008DF1")]
		None = -1,
		[Token(Token = "0x4008DF2")]
		SmallPack = 0,
		[Token(Token = "0x4008DF3")]
		Large = 1,
		[Token(Token = "0x4008DF4")]
		PickThumb = 2,
		[Token(Token = "0x4008DF5")]
		PickWideTrimThumb = 3,
		[Token(Token = "0x4008DF6")]
		Additional_1 = 10,
		[Token(Token = "0x4008DF7")]
		Additional_2 = 11,
		[Token(Token = "0x4008DF8")]
		Additional_3 = 12
	}

	[Token(Token = "0x4008DC9")]
	private const string k_SettingPath = "Definition/Shop/CardThumbSettings";

	[Token(Token = "0x4008DCA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private float m_LargeAspect;

	[Token(Token = "0x4008DCB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	[SerializeField]
	private float m_SmallAspect;

	[Token(Token = "0x4008DCC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private SettingMap m_LargeMap;

	[Token(Token = "0x4008DCD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private SettingMap m_SmallPackMap;

	[Token(Token = "0x4008DCE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	private SettingMap m_PickMap;

	[Token(Token = "0x4008DCF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[SerializeField]
	private SettingMap m_PickWideTrimMap;

	[Token(Token = "0x4008DD0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[SerializeField]
	private SettingMap m_Additional_1_Map;

	[Token(Token = "0x4008DD1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[SerializeField]
	private SettingMap m_Additional_2_Map;

	[Token(Token = "0x4008DD2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[SerializeField]
	private SettingMap m_Additional_3_Map;

	[Token(Token = "0x4008DD3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[SerializeField]
	private ImageThumbSettingMap m_LargeImageMap;

	[Token(Token = "0x4008DD4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	[SerializeField]
	private ImageThumbSettingMap m_SmallImageMap;

	[Token(Token = "0x4008DD5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	[SerializeField]
	private ImageThumbSettingMap m_PickImageMap;

	[Token(Token = "0x4008DD6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	[SerializeField]
	private ImageThumbSettingMap m_PickWideTrimImageMap;

	[Token(Token = "0x4008DD7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	[SerializeField]
	private ImageThumbSettingMap m_Additional_1_ImageMap;

	[Token(Token = "0x4008DD8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	[SerializeField]
	private ImageThumbSettingMap m_Additional_2_ImageMap;

	[Token(Token = "0x4008DD9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	[SerializeField]
	private ImageThumbSettingMap m_Additional_3_ImageMap;

	[Token(Token = "0x4008DDA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	[SerializeField]
	private ThumbSetting m_NoneSetting;

	[Token(Token = "0x4008DDB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	[SerializeField]
	private ImageThumbSetting m_NoneImageSetting;

	[Token(Token = "0x6003BC3")]
	[Address(RVA = "0x83A2A0", Offset = "0x8394A0", VA = "0x18083A2A0")]
	public void ClearCache()
	{
	}

	[Token(Token = "0x6003BC4")]
	[Address(RVA = "0x83AD70", Offset = "0x839F70", VA = "0x18083AD70")]
	private SettingMap GetSettingMap(Format format)
	{
		return null;
	}

	[Token(Token = "0x6003BC5")]
	[Address(RVA = "0x83AB80", Offset = "0x839D80", VA = "0x18083AB80")]
	private ImageThumbSettingMap GetImageSettingMap(Format format)
	{
		return null;
	}

	[Token(Token = "0x6003BC6")]
	[Address(RVA = "0x83ADF0", Offset = "0x839FF0", VA = "0x18083ADF0")]
	public ThumbSetting GetSetting(Format format, int mrk)
	{
		return null;
	}

	[Token(Token = "0x6003BC7")]
	[Address(RVA = "0x83AC00", Offset = "0x839E00", VA = "0x18083AC00")]
	public ImageThumbSetting GetImageSetting(Format format, string path)
	{
		return null;
	}

	[Token(Token = "0x6003BC8")]
	[Address(RVA = "0x83B250", Offset = "0x83A450", VA = "0x18083B250")]
	public bool IsExitsSetting(Format format, int mrk, [Optional] string path)
	{
		return default(bool);
	}

	[Token(Token = "0x6003BC9")]
	[Address(RVA = "0x83B130", Offset = "0x83A330", VA = "0x18083B130")]
	public bool IsExitsImageSetting(Format format, string path)
	{
		return default(bool);
	}

	[Token(Token = "0x6003BCA")]
	[Address(RVA = "0x83AF50", Offset = "0x83A150", VA = "0x18083AF50")]
	public bool HasAspectRatioSetting(Format format)
	{
		return default(bool);
	}

	[Token(Token = "0x6003BCB")]
	[Address(RVA = "0x83AFD0", Offset = "0x83A1D0", VA = "0x18083AFD0")]
	public void ImportData(Format format, int mrk, RawImage rawImage)
	{
	}

	[Token(Token = "0x6003BCC")]
	[Address(RVA = "0x83B080", Offset = "0x83A280", VA = "0x18083B080")]
	public void ImportImageData(Format format, string path, RawImage rawImage)
	{
	}

	[Token(Token = "0x6003BCD")]
	[Address(RVA = "0x83AF60", Offset = "0x83A160", VA = "0x18083AF60")]
	public void ImportAspectRatio(Format format, RectTransform rectTransform)
	{
	}

	[Token(Token = "0x6003BCE")]
	[Address(RVA = "0x839D10", Offset = "0x838F10", VA = "0x180839D10")]
	public void AddByMrk(ShopCardThumbSettings source, int mrk)
	{
	}

	[Token(Token = "0x6003BCF")]
	[Address(RVA = "0x83A650", Offset = "0x839850", VA = "0x18083A650")]
	public void DeleteByMrk(int mrk)
	{
	}

	[Token(Token = "0x6003BD0")]
	[Address(RVA = "0x839FE0", Offset = "0x8391E0", VA = "0x180839FE0")]
	public void AddByPath(ShopCardThumbSettings source, string path)
	{
	}

	[Token(Token = "0x6003BD1")]
	[Address(RVA = "0x83A8E0", Offset = "0x839AE0", VA = "0x18083A8E0")]
	public void DeleteByPath(string path)
	{
	}

	[Token(Token = "0x6003BD2")]
	[Address(RVA = "0x83B350", Offset = "0x83A550", VA = "0x18083B350")]
	public ShopCardThumbSettings()
	{
	}
}
