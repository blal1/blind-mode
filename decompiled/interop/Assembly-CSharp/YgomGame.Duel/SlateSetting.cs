using System;
using Il2CppDummyDll;
using UnityEngine;
using YgomGame.Card;

namespace YgomGame.Duel;

[Token(Token = "0x2001830")]
public class SlateSetting : ScriptableObject
{
	[Serializable]
	[Token(Token = "0x2001831")]
	public struct FrameColorPalette
	{
		[Token(Token = "0x400E2D5")]
		[FieldOffset(Offset = "0x0")]
		public Content.Frame frame;

		[Token(Token = "0x400E2D6")]
		[FieldOffset(Offset = "0x4")]
		public Color topCol;

		[Token(Token = "0x400E2D7")]
		[FieldOffset(Offset = "0x14")]
		public Color bottomCol;

		[Token(Token = "0x400E2D8")]
		[FieldOffset(Offset = "0x28")]
		public Texture topTex;

		[Token(Token = "0x400E2D9")]
		[FieldOffset(Offset = "0x30")]
		public Texture bottomTex;
	}

	[Serializable]
	[Token(Token = "0x2001832")]
	public struct AttributeColorPalette
	{
		[Token(Token = "0x400E2DA")]
		[FieldOffset(Offset = "0x0")]
		public Content.Attribute attr;

		[Token(Token = "0x400E2DB")]
		[FieldOffset(Offset = "0x4")]
		public Color color;

		[Token(Token = "0x400E2DC")]
		[FieldOffset(Offset = "0x18")]
		public Texture texture;

		[Token(Token = "0x400E2DD")]
		[FieldOffset(Offset = "0x20")]
		public string text;
	}

	[Serializable]
	[Token(Token = "0x2001833")]
	public struct MagicIcon
	{
		[Token(Token = "0x400E2DE")]
		[FieldOffset(Offset = "0x0")]
		public Content.Icon icon;

		[Token(Token = "0x400E2DF")]
		[FieldOffset(Offset = "0x8")]
		public Texture texture;
	}

	[Token(Token = "0x400E2CB")]
	[FieldOffset(Offset = "0x0")]
	private static SlateSetting m_Instance;

	[Token(Token = "0x400E2CC")]
	private const string PATH = "Duel/ScriptableObject/SlateSetting";

	[Token(Token = "0x400E2CD")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private FrameColorPalette[] FieldCardframeColor;

	[Token(Token = "0x400E2CE")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private AttributeColorPalette[] attributeBaseColorPalettes;

	[Token(Token = "0x400E2CF")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private MagicIcon[] magicIcons;

	[Token(Token = "0x400E2D0")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private Color levelBaseColor;

	[Token(Token = "0x400E2D1")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	private Color rankBaseColor;

	[Token(Token = "0x400E2D2")]
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	private Color linkBaseColor;

	[Token(Token = "0x400E2D3")]
	[FieldOffset(Offset = "0x60")]
	[SerializeField]
	private Color fontColorNormal;

	[Token(Token = "0x400E2D4")]
	[FieldOffset(Offset = "0x70")]
	[SerializeField]
	private Color fontColorChanged;

	[Token(Token = "0x1700173F")]
	protected static SlateSetting Instance
	{
		[Token(Token = "0x60099BE")]
		[Address(RVA = "0xE3C9B0", Offset = "0xE3BBB0", VA = "0x180E3C9B0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001740")]
	public static Color LevelBaseColor
	{
		[Token(Token = "0x60099BF")]
		[Address(RVA = "0xE3CB30", Offset = "0xE3BD30", VA = "0x180E3CB30")]
		get
		{
			return default(Color);
		}
	}

	[Token(Token = "0x17001741")]
	public static Color RankBaseColor
	{
		[Token(Token = "0x60099C0")]
		[Address(RVA = "0xE3CB90", Offset = "0xE3BD90", VA = "0x180E3CB90")]
		get
		{
			return default(Color);
		}
	}

	[Token(Token = "0x17001742")]
	public static Color LinkBaseColor
	{
		[Token(Token = "0x60099C1")]
		[Address(RVA = "0xE3CB60", Offset = "0xE3BD60", VA = "0x180E3CB60")]
		get
		{
			return default(Color);
		}
	}

	[Token(Token = "0x17001743")]
	public static Color FontColorNormal
	{
		[Token(Token = "0x60099C2")]
		[Address(RVA = "0xE3C980", Offset = "0xE3BB80", VA = "0x180E3C980")]
		get
		{
			return default(Color);
		}
	}

	[Token(Token = "0x17001744")]
	public static Color FontColorChanged
	{
		[Token(Token = "0x60099C3")]
		[Address(RVA = "0xE3C950", Offset = "0xE3BB50", VA = "0x180E3C950")]
		get
		{
			return default(Color);
		}
	}

	[Token(Token = "0x60099C4")]
	[Address(RVA = "0xE3C700", Offset = "0xE3B900", VA = "0x180E3C700")]
	public static (Color, Color, Texture, Texture) GetFrameColor(Content.Frame frame)
	{
		return default((Color, Color, Texture, Texture));
	}

	[Token(Token = "0x60099C5")]
	[Address(RVA = "0xE3C5A0", Offset = "0xE3B7A0", VA = "0x180E3C5A0")]
	public static (Color, Texture, string) GetAttributeBaseColor(Content.Attribute attr)
	{
		return default((Color, Texture, string));
	}

	[Token(Token = "0x60099C6")]
	[Address(RVA = "0xE3C890", Offset = "0xE3BA90", VA = "0x180E3C890")]
	public static Texture GetIconTexture(Content.Icon icon)
	{
		return null;
	}

	[Token(Token = "0x60099C7")]
	[Address(RVA = "0xE3C920", Offset = "0xE3BB20", VA = "0x180E3C920")]
	public SlateSetting()
	{
	}
}
