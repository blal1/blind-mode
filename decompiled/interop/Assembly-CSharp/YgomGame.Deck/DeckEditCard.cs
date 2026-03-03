using Il2CppDummyDll;
using UnityEngine.UI;
using YgomSystem.YGomTMPro;

namespace YgomGame.Deck;

[Token(Token = "0x20010A6")]
public class DeckEditCard : CardParameterWidget
{
	[Token(Token = "0x400B105")]
	protected const string LABEL_SBN_BODY = "ImageCard";

	[Token(Token = "0x400B106")]
	private const string LABEL_IMG_ATTRIBUTEICON = "IconAttribute";

	[Token(Token = "0x400B107")]
	private const string LABEL_IMG_LEVELICON = "IconLevel";

	[Token(Token = "0x400B108")]
	private const string LABEL_TXT_LEVEL = "TextLevel";

	[Token(Token = "0x400B109")]
	protected const string LABEL_IMG_REGULATIONICON = "IconLimit";

	[Token(Token = "0x400B10A")]
	private const string LABEL_IMG_LINKICON = "IconLink";

	[Token(Token = "0x400B10B")]
	private const string LABEL_TXT_LINK = "TextLink";

	[Token(Token = "0x400B10C")]
	private const string LABEL_IMG_PENDULUMICON = "IconPendulumScale";

	[Token(Token = "0x400B10D")]
	private const string LABEL_TXT_PENDULUM_SCALE = "TextPendulumScale";

	[Token(Token = "0x400B10E")]
	private const string LABEL_IMG_RANKICON = "IconRank";

	[Token(Token = "0x400B10F")]
	private const string LABEL_TXT_RANK = "TextRank";

	[Token(Token = "0x400B110")]
	private const string LABEL_IMG_TUNERICON = "IconTuner";

	[Token(Token = "0x400B111")]
	private const string LABEL_IMG_TYPEICON = "IconType";

	[Token(Token = "0x400B112")]
	private const string LABEL_IMG_SPELLTRAPTYPEICON = "IconSpellTrapType";

	[Token(Token = "0x400B113")]
	private const string LABEL_IMG_RARITYICON = "IconRarity";

	[Token(Token = "0x400B114")]
	[FieldOffset(Offset = "0xC8")]
	private Image AttrIcon;

	[Token(Token = "0x400B115")]
	[FieldOffset(Offset = "0xD0")]
	private Image TunerIcon;

	[Token(Token = "0x400B116")]
	[FieldOffset(Offset = "0xD8")]
	private Image PendScaleIcon;

	[Token(Token = "0x400B117")]
	[FieldOffset(Offset = "0xE0")]
	private ExtendedTextMeshProUGUI PendScaleText;

	[Token(Token = "0x400B118")]
	[FieldOffset(Offset = "0xE8")]
	private Image LvlIcon;

	[Token(Token = "0x400B119")]
	[FieldOffset(Offset = "0xF0")]
	private ExtendedTextMeshProUGUI LvlText;

	[Token(Token = "0x400B11A")]
	[FieldOffset(Offset = "0xF8")]
	private Image RankIcon;

	[Token(Token = "0x400B11B")]
	[FieldOffset(Offset = "0x100")]
	private ExtendedTextMeshProUGUI RankText;

	[Token(Token = "0x400B11C")]
	[FieldOffset(Offset = "0x108")]
	private Image LinkIcon;

	[Token(Token = "0x400B11D")]
	[FieldOffset(Offset = "0x110")]
	private ExtendedTextMeshProUGUI LinkText;

	[Token(Token = "0x400B11E")]
	[FieldOffset(Offset = "0x118")]
	private Image TypeIcon;

	[Token(Token = "0x400B11F")]
	[FieldOffset(Offset = "0x120")]
	private Image SpellTrapTypeIcon;

	[Token(Token = "0x400B120")]
	[FieldOffset(Offset = "0x128")]
	private Image RegulationIcon;

	[Token(Token = "0x400B121")]
	[FieldOffset(Offset = "0x130")]
	private Image RarityIcon;

	[Token(Token = "0x400B122")]
	[FieldOffset(Offset = "0x138")]
	private bool isIni;

	[Token(Token = "0x170010A3")]
	protected override Image m_AttrIcon
	{
		[Token(Token = "0x6006722")]
		[Address(RVA = "0x49BAD0", Offset = "0x49ACD0", VA = "0x18049BAD0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170010A4")]
	protected override Image m_TunerIcon
	{
		[Token(Token = "0x6006723")]
		[Address(RVA = "0x5857B0", Offset = "0x5849B0", VA = "0x1805857B0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170010A5")]
	protected override Image m_TypeIcon
	{
		[Token(Token = "0x6006724")]
		[Address(RVA = "0x4D0610", Offset = "0x4CF810", VA = "0x1804D0610", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170010A6")]
	protected override Image m_SpellTrapTypeIcon
	{
		[Token(Token = "0x6006725")]
		[Address(RVA = "0x9538F0", Offset = "0x952AF0", VA = "0x1809538F0", Slot = "16")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170010A7")]
	protected override Image m_PendScaleIcon
	{
		[Token(Token = "0x6006726")]
		[Address(RVA = "0x5961F0", Offset = "0x5953F0", VA = "0x1805961F0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170010A8")]
	protected override ExtendedTextMeshProUGUI m_PendScaleText
	{
		[Token(Token = "0x6006727")]
		[Address(RVA = "0x5961E0", Offset = "0x5953E0", VA = "0x1805961E0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170010A9")]
	protected override Image m_LvlIcon
	{
		[Token(Token = "0x6006728")]
		[Address(RVA = "0x49BAE0", Offset = "0x49ACE0", VA = "0x18049BAE0", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170010AA")]
	protected override ExtendedTextMeshProUGUI m_LvlText
	{
		[Token(Token = "0x6006729")]
		[Address(RVA = "0x5961D0", Offset = "0x5953D0", VA = "0x1805961D0", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170010AB")]
	protected override Image m_RankIcon
	{
		[Token(Token = "0x600672A")]
		[Address(RVA = "0x596200", Offset = "0x595400", VA = "0x180596200", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170010AC")]
	protected override ExtendedTextMeshProUGUI m_RankText
	{
		[Token(Token = "0x600672B")]
		[Address(RVA = "0x5FC5E0", Offset = "0x5FB7E0", VA = "0x1805FC5E0", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170010AD")]
	protected override Image m_LinkIcon
	{
		[Token(Token = "0x600672C")]
		[Address(RVA = "0x5FC5F0", Offset = "0x5FB7F0", VA = "0x1805FC5F0", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170010AE")]
	protected override ExtendedTextMeshProUGUI m_LinkText
	{
		[Token(Token = "0x600672D")]
		[Address(RVA = "0x3DA790", Offset = "0x3D9990", VA = "0x1803DA790", Slot = "14")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170010AF")]
	protected override Image m_RegulationIcon
	{
		[Token(Token = "0x600672E")]
		[Address(RVA = "0x62DA80", Offset = "0x62CC80", VA = "0x18062DA80", Slot = "17")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170010B0")]
	protected override Image m_RarityIcon
	{
		[Token(Token = "0x600672F")]
		[Address(RVA = "0xABF8A0", Offset = "0xABEAA0", VA = "0x180ABF8A0", Slot = "18")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6006730")]
	[Address(RVA = "0xABEAE0", Offset = "0xABDCE0", VA = "0x180ABEAE0")]
	protected new void InitializeElemnts()
	{
	}

	[Token(Token = "0x6006731")]
	[Address(RVA = "0xABF550", Offset = "0xABE750", VA = "0x180ABF550", Slot = "19")]
	public virtual void SetData(CardBaseData baseData, int regulationID, DeckEditViewController2.DisplayMode mode = DeckEditViewController2.DisplayMode.Simple)
	{
	}

	[Token(Token = "0x6006732")]
	[Address(RVA = "0xABEF30", Offset = "0xABE130", VA = "0x180ABEF30")]
	public void ScalingIcons(float scale = 1.5f)
	{
	}

	[Token(Token = "0x6006733")]
	[Address(RVA = "0x422F60", Offset = "0x422160", VA = "0x180422F60")]
	public DeckEditCard()
	{
	}
}
