using Il2CppDummyDll;

namespace YgomGame.Stats;

[Token(Token = "0x2000879")]
public class CardStatsData
{
	[Token(Token = "0x200087A")]
	public enum CARD_STATS_EFFECT_TYPE
	{
		[Token(Token = "0x400866E")]
		CARD_STATS_EFFECT_TYPE_0,
		[Token(Token = "0x400866F")]
		CARD_STATS_EFFECT_TYPE_1,
		[Token(Token = "0x4008670")]
		CARD_STATS_EFFECT_TYPE_2,
		[Token(Token = "0x4008671")]
		CARD_STATS_EFFECT_TYPE_MAX
	}

	[Token(Token = "0x4008669")]
	[FieldOffset(Offset = "0x10")]
	public int m_Item;

	[Token(Token = "0x400866A")]
	[FieldOffset(Offset = "0x18")]
	public double m_fValue;

	[Token(Token = "0x400866B")]
	[FieldOffset(Offset = "0x20")]
	public string m_Value;

	[Token(Token = "0x400866C")]
	[FieldOffset(Offset = "0x28")]
	public CARD_STATS_EFFECT_TYPE m_EffectType;

	[Token(Token = "0x600335F")]
	[Address(RVA = "0x766EF0", Offset = "0x7660F0", VA = "0x180766EF0")]
	public string GetItemString()
	{
		return null;
	}

	[Token(Token = "0x6003360")]
	[Address(RVA = "0x766F00", Offset = "0x766100", VA = "0x180766F00")]
	public string GetItemUnitString()
	{
		return null;
	}

	[Token(Token = "0x6003361")]
	[Address(RVA = "0x3D8370", Offset = "0x3D7570", VA = "0x1803D8370")]
	public string GetValueString()
	{
		return null;
	}

	[Token(Token = "0x6003362")]
	[Address(RVA = "0x62E210", Offset = "0x62D410", VA = "0x18062E210")]
	public CARD_STATS_EFFECT_TYPE GetValueEffectType()
	{
		return default(CARD_STATS_EFFECT_TYPE);
	}

	[Token(Token = "0x6003363")]
	[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
	public CardStatsData()
	{
	}
}
