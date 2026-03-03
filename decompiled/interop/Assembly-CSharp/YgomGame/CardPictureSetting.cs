using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using YgomGame.Card;
using YgomSystem;

namespace YgomGame;

[Token(Token = "0x20006C7")]
[CreateAssetMenu(menuName = "Scriptable Object/CardPictureSetting")]
public class CardPictureSetting : ScriptableObject
{
	[Serializable]
	[Token(Token = "0x20006C8")]
	public struct FrameSprite
	{
		[Token(Token = "0x4002217")]
		[FieldOffset(Offset = "0x0")]
		public Content.Frame frame;

		[Token(Token = "0x4002218")]
		[FieldOffset(Offset = "0x4")]
		public bool spIllsut;

		[Token(Token = "0x4002219")]
		[FieldOffset(Offset = "0x8")]
		public Sprite sprite;
	}

	[Serializable]
	[Token(Token = "0x20006C9")]
	public struct SpecificCardMaskTextures
	{
		[Token(Token = "0x400221A")]
		[FieldOffset(Offset = "0x0")]
		public int cardid;

		[Token(Token = "0x400221B")]
		[FieldOffset(Offset = "0x8")]
		public Texture cardMask;

		[Token(Token = "0x400221C")]
		[FieldOffset(Offset = "0x10")]
		public Texture cardNormal;
	}

	[Serializable]
	[Token(Token = "0x20006CA")]
	public struct FrameCardNameColor
	{
		[Token(Token = "0x400221D")]
		[FieldOffset(Offset = "0x0")]
		public Content.Frame frame;

		[Token(Token = "0x400221E")]
		[FieldOffset(Offset = "0x4")]
		[ColorUsage(true, true)]
		[SerializeField]
		public Color color;
	}

	[Serializable]
	[Token(Token = "0x20006CB")]
	public struct CardPictureFormatSetting
	{
		[Token(Token = "0x400221F")]
		[FieldOffset(Offset = "0x0")]
		public CardQuality quality;

		[Token(Token = "0x4002220")]
		[FieldOffset(Offset = "0x4")]
		public RenderTextureFormat format;
	}

	[Serializable]
	[Token(Token = "0x20006CC")]
	public struct FinishTypeMateriaTable
	{
		[Token(Token = "0x4002221")]
		[FieldOffset(Offset = "0x0")]
		public CardFinishSetting.FinishType finishType;

		[Token(Token = "0x4002222")]
		[FieldOffset(Offset = "0x8")]
		public Material material;
	}

	[Token(Token = "0x4002204")]
	[FieldOffset(Offset = "0x0")]
	private static CardPictureSetting m_Instance;

	[Token(Token = "0x4002205")]
	private const string PATH = "Card/ScriptableObjects/CardPictureSetting";

	[Token(Token = "0x4002206")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private FinishTypeMateriaTable[] m_FinishTypeMatarialTable;

	[Token(Token = "0x4002207")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private Material m_MatNromalStyle;

	[Token(Token = "0x4002208")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private Texture m_CardMask_N;

	[Token(Token = "0x4002209")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private Texture m_CardMask_P;

	[Token(Token = "0x400220A")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private Texture m_CardMask_L;

	[Token(Token = "0x400220B")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	private Texture m_CardNormal_N;

	[Token(Token = "0x400220C")]
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	private Texture m_CardNormal_P;

	[Token(Token = "0x400220D")]
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	private Texture m_CardNormal_L;

	[Token(Token = "0x400220E")]
	[FieldOffset(Offset = "0x58")]
	[SerializeField]
	private FrameSprite[] m_FrameSpriteTable;

	[Token(Token = "0x400220F")]
	[FieldOffset(Offset = "0x60")]
	[SerializeField]
	private FrameSprite[] m_LoadingSpriteTable;

	[Token(Token = "0x4002210")]
	[FieldOffset(Offset = "0x68")]
	[SerializeField]
	private FrameCardNameColor[] m_FrameCardNameColorTableForShineFinish;

	[Token(Token = "0x4002211")]
	[FieldOffset(Offset = "0x70")]
	[SerializeField]
	private Sprite[] m_LinkNumTexSet;

	[Token(Token = "0x4002212")]
	[FieldOffset(Offset = "0x78")]
	[SerializeField]
	private int m_CardPictureCountMax;

	[Token(Token = "0x4002213")]
	[FieldOffset(Offset = "0x80")]
	[SerializeField]
	private CardPictureFormatSetting[] m_FormatSettings;

	[Token(Token = "0x4002214")]
	[FieldOffset(Offset = "0x88")]
	[SerializeField]
	private int[] m_SpecialIllustMrks;

	[Token(Token = "0x4002215")]
	[FieldOffset(Offset = "0x90")]
	[SerializeField]
	private SpecificCardMaskTextures[] m_SpecificCardMaskTextures;

	[Token(Token = "0x4002216")]
	[FieldOffset(Offset = "0x98")]
	private Dictionary<RubyRoot.Lang, TMP_FontAsset> m_FontAssetTable;

	[Token(Token = "0x1700058C")]
	protected static CardPictureSetting Instance
	{
		[Token(Token = "0x6002D31")]
		[Address(RVA = "0x6FFFC0", Offset = "0x6FF1C0", VA = "0x1806FFFC0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700058D")]
	public static Texture CardMask_N
	{
		[Token(Token = "0x6002D32")]
		[Address(RVA = "0x6FFF00", Offset = "0x6FF100", VA = "0x1806FFF00")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700058E")]
	public static Texture CardMask_P
	{
		[Token(Token = "0x6002D33")]
		[Address(RVA = "0x6FFF20", Offset = "0x6FF120", VA = "0x1806FFF20")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700058F")]
	public static Texture CardMask_L
	{
		[Token(Token = "0x6002D34")]
		[Address(RVA = "0x6FFEE0", Offset = "0x6FF0E0", VA = "0x1806FFEE0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000590")]
	public static Texture CardNormal_N
	{
		[Token(Token = "0x6002D35")]
		[Address(RVA = "0x6FFF60", Offset = "0x6FF160", VA = "0x1806FFF60")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000591")]
	public static Texture CardNormal_P
	{
		[Token(Token = "0x6002D36")]
		[Address(RVA = "0x6FFF80", Offset = "0x6FF180", VA = "0x1806FFF80")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000592")]
	public static Texture CardNormal_L
	{
		[Token(Token = "0x6002D37")]
		[Address(RVA = "0x6FFF40", Offset = "0x6FF140", VA = "0x1806FFF40")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000593")]
	public static int CardPictureCountMax
	{
		[Token(Token = "0x6002D38")]
		[Address(RVA = "0x6FFFA0", Offset = "0x6FF1A0", VA = "0x1806FFFA0")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x6002D39")]
	[Address(RVA = "0x6FFA80", Offset = "0x6FEC80", VA = "0x1806FFA80")]
	public static Material GetCardMaterial(CardFinishSetting.FinishType finishType)
	{
		return null;
	}

	[Token(Token = "0x6002D3A")]
	[Address(RVA = "0x6FF780", Offset = "0x6FE980", VA = "0x1806FF780")]
	public static Sprite GetCardFrame(Content.Frame frame, bool spIlust = false)
	{
		return null;
	}

	[Token(Token = "0x6002D3B")]
	[Address(RVA = "0x6FFD40", Offset = "0x6FEF40", VA = "0x1806FFD40")]
	public static Sprite GetLoadingTex(Content.Frame frame)
	{
		return null;
	}

	[Token(Token = "0x6002D3C")]
	[Address(RVA = "0x6FFCF0", Offset = "0x6FEEF0", VA = "0x1806FFCF0")]
	public static Sprite GetLinkNumTex(int linknum)
	{
		return null;
	}

	[Token(Token = "0x6002D3D")]
	[Address(RVA = "0x6FFB20", Offset = "0x6FED20", VA = "0x1806FFB20")]
	public static Color GetCardNameColorForShineFinish(Content.Frame frame)
	{
		return default(Color);
	}

	[Token(Token = "0x6002D3E")]
	[Address(RVA = "0x6FFC60", Offset = "0x6FEE60", VA = "0x1806FFC60")]
	public static TMP_FontAsset GetFontAsset(RubyRoot.Lang lang)
	{
		return null;
	}

	[Token(Token = "0x6002D3F")]
	[Address(RVA = "0x6FFBE0", Offset = "0x6FEDE0", VA = "0x1806FFBE0")]
	public static RenderTextureFormat GetCardPictureFormat(CardQuality quality)
	{
		return default(RenderTextureFormat);
	}

	[Token(Token = "0x6002D40")]
	[Address(RVA = "0x6FFDD0", Offset = "0x6FEFD0", VA = "0x1806FFDD0")]
	public static bool IsSpeticalIllust(int cardid)
	{
		return default(bool);
	}

	[Token(Token = "0x6002D41")]
	[Address(RVA = "0x6FF820", Offset = "0x6FEA20", VA = "0x1806FF820")]
	public static (Texture, Texture) GetCardMaskFromCardid(int cardid)
	{
		return default((Texture, Texture));
	}

	[Token(Token = "0x6002D42")]
	[Address(RVA = "0x6FFE50", Offset = "0x6FF050", VA = "0x1806FFE50")]
	public CardPictureSetting()
	{
	}
}
