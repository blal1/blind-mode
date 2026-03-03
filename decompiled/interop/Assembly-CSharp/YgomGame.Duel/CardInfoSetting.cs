using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using YgomGame.Card;
using YgomGame.Settings;

namespace YgomGame.Duel;

[Token(Token = "0x2001753")]
[CreateAssetMenu(menuName = "Scriptable Object/CardInfoSetting")]
public class CardInfoSetting : ScriptableObject
{
	[Serializable]
	[Token(Token = "0x2001754")]
	private struct SettingData
	{
		[Token(Token = "0x400DBFA")]
		[FieldOffset(Offset = "0x0")]
		public int FontSize_S;

		[Token(Token = "0x400DBFB")]
		[FieldOffset(Offset = "0x4")]
		public int FontSize_M;

		[Token(Token = "0x400DBFC")]
		[FieldOffset(Offset = "0x8")]
		public int FontSize_L;

		[Token(Token = "0x400DBFD")]
		[FieldOffset(Offset = "0xC")]
		public int FontSizeMobile_S;

		[Token(Token = "0x400DBFE")]
		[FieldOffset(Offset = "0x10")]
		public int FontSizeMobile_M;

		[Token(Token = "0x400DBFF")]
		[FieldOffset(Offset = "0x14")]
		public int FontSizeMobile_L;

		[Token(Token = "0x400DC00")]
		[FieldOffset(Offset = "0x18")]
		public float LineSpacing;

		[Token(Token = "0x400DC01")]
		[FieldOffset(Offset = "0x1C")]
		public float ParagraphSpace;
	}

	[Token(Token = "0x2001755")]
	private enum LanguageScope
	{
		[Token(Token = "0x400DC03")]
		Generic,
		[Token(Token = "0x400DC04")]
		Japanese,
		[Token(Token = "0x400DC05")]
		English,
		[Token(Token = "0x400DC06")]
		French,
		[Token(Token = "0x400DC07")]
		German,
		[Token(Token = "0x400DC08")]
		Spanish,
		[Token(Token = "0x400DC09")]
		Portuguese,
		[Token(Token = "0x400DC0A")]
		Korean,
		[Token(Token = "0x400DC0B")]
		Italian,
		[Token(Token = "0x400DC0C")]
		SCH,
		[Token(Token = "0x400DC0D")]
		TCH
	}

	[Serializable]
	[Token(Token = "0x2001756")]
	private struct SettingDataStringPair
	{
		[Token(Token = "0x400DC0E")]
		[FieldOffset(Offset = "0x0")]
		public LanguageScope language;

		[Token(Token = "0x400DC0F")]
		[FieldOffset(Offset = "0x4")]
		public SettingData setting;
	}

	[Serializable]
	[Token(Token = "0x2001757")]
	public struct FrameColorPalette
	{
		[Token(Token = "0x400DC10")]
		[FieldOffset(Offset = "0x0")]
		public Content.Frame frame;

		[Token(Token = "0x400DC11")]
		[FieldOffset(Offset = "0x4")]
		public Color BgColor0;

		[Token(Token = "0x400DC12")]
		[FieldOffset(Offset = "0x14")]
		public Color BgColor1;
	}

	[Token(Token = "0x400DBF0")]
	[FieldOffset(Offset = "0x0")]
	private static CardInfoSetting m_Instance;

	[Token(Token = "0x400DBF1")]
	private const string PATH = "Duel/ScriptableObject/CardInfoSetting";

	[Token(Token = "0x400DBF2")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private SettingDataStringPair[] m_SettingDataTable;

	[Token(Token = "0x400DBF3")]
	[FieldOffset(Offset = "0x20")]
	private SettingData m_CurrentSettingData;

	[Token(Token = "0x400DBF4")]
	[FieldOffset(Offset = "0x40")]
	private Dictionary<string, LanguageScope> m_LanguageScopeTable;

	[Token(Token = "0x400DBF5")]
	[FieldOffset(Offset = "0x48")]
	private Dictionary<LanguageScope, SettingData> m_LanguageSettingTable;

	[Token(Token = "0x400DBF6")]
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	public FrameColorPalette[] m_CardInfoframeColor;

	[Token(Token = "0x400DBF7")]
	[FieldOffset(Offset = "0x58")]
	[SerializeField]
	public Color m_FontColorNormal;

	[Token(Token = "0x400DBF8")]
	[FieldOffset(Offset = "0x68")]
	[SerializeField]
	public Color m_FontColorChanged;

	[Token(Token = "0x400DBF9")]
	[FieldOffset(Offset = "0x78")]
	[SerializeField]
	public Material m_FrameMaterialSrc;

	[Token(Token = "0x17001685")]
	protected static CardInfoSetting Instance
	{
		[Token(Token = "0x6009281")]
		[Address(RVA = "0xDC6320", Offset = "0xDC5520", VA = "0x180DC6320")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001686")]
	public static int FontSize_S
	{
		[Token(Token = "0x6009282")]
		[Address(RVA = "0xDC6300", Offset = "0xDC5500", VA = "0x180DC6300")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17001687")]
	public static int FontSize_M
	{
		[Token(Token = "0x6009283")]
		[Address(RVA = "0xDC62E0", Offset = "0xDC54E0", VA = "0x180DC62E0")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17001688")]
	public static int FontSize_L
	{
		[Token(Token = "0x6009284")]
		[Address(RVA = "0xDC62C0", Offset = "0xDC54C0", VA = "0x180DC62C0")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17001689")]
	public static float ParaGraphSpace
	{
		[Token(Token = "0x6009285")]
		[Address(RVA = "0xDC65B0", Offset = "0xDC57B0", VA = "0x180DC65B0")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x1700168A")]
	public static float LineSpace
	{
		[Token(Token = "0x6009286")]
		[Address(RVA = "0xDC6590", Offset = "0xDC5790", VA = "0x180DC6590")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x6009287")]
	[Address(RVA = "0xDC5F10", Offset = "0xDC5110", VA = "0x180DC5F10")]
	public static void SetFrameColor(Material mat, Content.Frame frame)
	{
	}

	[Token(Token = "0x6009288")]
	[Address(RVA = "0xDC5CA0", Offset = "0xDC4EA0", VA = "0x180DC5CA0")]
	public static void SetActivatedIconFrameColor(Material mat, Content.Frame frame)
	{
	}

	[Token(Token = "0x6009289")]
	[Address(RVA = "0xDC58B0", Offset = "0xDC4AB0", VA = "0x180DC58B0")]
	public static Material GetFrameMaterial()
	{
		return null;
	}

	[Token(Token = "0x600928A")]
	[Address(RVA = "0xDC5650", Offset = "0xDC4850", VA = "0x180DC5650")]
	public static Color GetFontColor(bool changed)
	{
		return default(Color);
	}

	[Token(Token = "0x600928B")]
	[Address(RVA = "0xDC5770", Offset = "0xDC4970", VA = "0x180DC5770")]
	public static int GetFontSize(SettingsUtil.BasicParam.CARD_TEXT_SIZE size)
	{
		return default(int);
	}

	[Token(Token = "0x600928C")]
	[Address(RVA = "0xDC5A00", Offset = "0xDC4C00", VA = "0x180DC5A00")]
	public static void ResetLanguage()
	{
	}

	[Token(Token = "0x600928D")]
	[Address(RVA = "0xDC5920", Offset = "0xDC4B20", VA = "0x180DC5920")]
	private void Initializer()
	{
	}

	[Token(Token = "0x600928E")]
	[Address(RVA = "0xDC5DD0", Offset = "0xDC4FD0", VA = "0x180DC5DD0")]
	public void SetFrameColorImpl(Material mat, Content.Frame frame)
	{
	}

	[Token(Token = "0x600928F")]
	[Address(RVA = "0xDC5B60", Offset = "0xDC4D60", VA = "0x180DC5B60")]
	public void SetActivatedIconFrameColorImpl(Material mat, Content.Frame frame)
	{
	}

	[Token(Token = "0x6009290")]
	[Address(RVA = "0xDC5850", Offset = "0xDC4A50", VA = "0x180DC5850")]
	public Material GetFrameMaterialImpl()
	{
		return null;
	}

	[Token(Token = "0x6009291")]
	[Address(RVA = "0xDC5630", Offset = "0xDC4830", VA = "0x180DC5630")]
	public Color GetFontColorImpl(bool changed)
	{
		return default(Color);
	}

	[Token(Token = "0x6009292")]
	[Address(RVA = "0xDC56B0", Offset = "0xDC48B0", VA = "0x180DC56B0")]
	public int GetFontSizeImpl(SettingsUtil.BasicParam.CARD_TEXT_SIZE size)
	{
		return default(int);
	}

	[Token(Token = "0x6009293")]
	[Address(RVA = "0xDC6050", Offset = "0xDC5250", VA = "0x180DC6050")]
	public CardInfoSetting()
	{
	}
}
