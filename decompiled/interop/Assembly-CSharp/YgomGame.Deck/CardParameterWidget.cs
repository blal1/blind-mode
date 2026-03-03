using Il2CppDummyDll;
using UnityEngine.UI;
using YgomGame.Card;
using YgomSystem.UI;
using YgomSystem.YGomTMPro;

namespace YgomGame.Deck;

[Token(Token = "0x200109A")]
public abstract class CardParameterWidget : CardBase
{
	[Token(Token = "0x400B0A2")]
	[FieldOffset(Offset = "0xB8")]
	public SelectionButton m_BodyButton;

	[Token(Token = "0x400B0A3")]
	[FieldOffset(Offset = "0xC0")]
	protected CardIconSprites m_CardIconSprites;

	[Token(Token = "0x17001075")]
	protected static Content m_cci
	{
		[Token(Token = "0x600668A")]
		[Address(RVA = "0xAB9260", Offset = "0xAB8460", VA = "0x180AB9260")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001076")]
	protected abstract Image m_AttrIcon
	{
		[Token(Token = "0x600668B")]
		get;
	}

	[Token(Token = "0x17001077")]
	protected abstract Image m_TunerIcon
	{
		[Token(Token = "0x600668C")]
		get;
	}

	[Token(Token = "0x17001078")]
	protected abstract Image m_PendScaleIcon
	{
		[Token(Token = "0x600668D")]
		get;
	}

	[Token(Token = "0x17001079")]
	protected abstract ExtendedTextMeshProUGUI m_PendScaleText
	{
		[Token(Token = "0x600668E")]
		get;
	}

	[Token(Token = "0x1700107A")]
	protected abstract Image m_LvlIcon
	{
		[Token(Token = "0x600668F")]
		get;
	}

	[Token(Token = "0x1700107B")]
	protected abstract ExtendedTextMeshProUGUI m_LvlText
	{
		[Token(Token = "0x6006690")]
		get;
	}

	[Token(Token = "0x1700107C")]
	protected abstract Image m_RankIcon
	{
		[Token(Token = "0x6006691")]
		get;
	}

	[Token(Token = "0x1700107D")]
	protected abstract ExtendedTextMeshProUGUI m_RankText
	{
		[Token(Token = "0x6006692")]
		get;
	}

	[Token(Token = "0x1700107E")]
	protected abstract Image m_LinkIcon
	{
		[Token(Token = "0x6006693")]
		get;
	}

	[Token(Token = "0x1700107F")]
	protected abstract ExtendedTextMeshProUGUI m_LinkText
	{
		[Token(Token = "0x6006694")]
		get;
	}

	[Token(Token = "0x17001080")]
	protected abstract Image m_TypeIcon
	{
		[Token(Token = "0x6006695")]
		get;
	}

	[Token(Token = "0x17001081")]
	protected abstract Image m_SpellTrapTypeIcon
	{
		[Token(Token = "0x6006696")]
		get;
	}

	[Token(Token = "0x17001082")]
	protected abstract Image m_RegulationIcon
	{
		[Token(Token = "0x6006697")]
		get;
	}

	[Token(Token = "0x17001083")]
	protected abstract Image m_RarityIcon
	{
		[Token(Token = "0x6006698")]
		get;
	}

	[Token(Token = "0x6006699")]
	[Address(RVA = "0xAB99B0", Offset = "0xAB8BB0", VA = "0x180AB99B0")]
	protected void setRegulationIcon(int id)
	{
	}

	[Token(Token = "0x600669A")]
	[Address(RVA = "0xAB9B30", Offset = "0xAB8D30", VA = "0x180AB9B30")]
	protected void setRegulationVisible(bool b)
	{
	}

	[Token(Token = "0x600669B")]
	[Address(RVA = "0xAB92F0", Offset = "0xAB84F0", VA = "0x180AB92F0")]
	protected void setAttribute(bool b = true)
	{
	}

	[Token(Token = "0x600669C")]
	[Address(RVA = "0xAB9C90", Offset = "0xAB8E90", VA = "0x180AB9C90")]
	protected void setTuner(bool b = true)
	{
	}

	[Token(Token = "0x600669D")]
	[Address(RVA = "0xAB9600", Offset = "0xAB8800", VA = "0x180AB9600")]
	protected void setPendulumScale(bool b = true)
	{
	}

	[Token(Token = "0x600669E")]
	[Address(RVA = "0xAB93D0", Offset = "0xAB85D0", VA = "0x180AB93D0")]
	protected void setLevel(bool b = true)
	{
	}

	[Token(Token = "0x600669F")]
	[Address(RVA = "0xAB9730", Offset = "0xAB8930", VA = "0x180AB9730")]
	protected void setRank(bool b = true)
	{
	}

	[Token(Token = "0x60066A0")]
	[Address(RVA = "0xAB94D0", Offset = "0xAB86D0", VA = "0x180AB94D0")]
	protected void setLinkRating(bool b = true)
	{
	}

	[Token(Token = "0x60066A1")]
	[Address(RVA = "0xAB9D20", Offset = "0xAB8F20", VA = "0x180AB9D20")]
	protected void setType(bool b = true)
	{
	}

	[Token(Token = "0x60066A2")]
	[Address(RVA = "0xAB9B80", Offset = "0xAB8D80", VA = "0x180AB9B80")]
	protected void setSpellTrapType(bool b = true)
	{
	}

	[Token(Token = "0x60066A3")]
	[Address(RVA = "0xAB9860", Offset = "0xAB8A60", VA = "0x180AB9860")]
	protected void setRarity(bool b = true)
	{
	}

	[Token(Token = "0x60066A4")]
	[Address(RVA = "0x422F60", Offset = "0x422160", VA = "0x180422F60")]
	protected CardParameterWidget()
	{
	}
}
