using Il2CppDummyDll;
using YgomSystem.ElementSystem;

namespace YgomGame.Duel;

[Token(Token = "0x2001908")]
public class LogShowCardName : LogItemBase
{
	[Token(Token = "0x400EA4D")]
	[FieldOffset(Offset = "0x50")]
	protected string LABEL_EO_CONTENT;

	[Token(Token = "0x400EA4E")]
	[FieldOffset(Offset = "0x58")]
	protected string LABEL_EO_COLORBARTEAM0;

	[Token(Token = "0x400EA4F")]
	[FieldOffset(Offset = "0x60")]
	protected string LABEL_EO_COLORBARTEAM1;

	[Token(Token = "0x400EA50")]
	[FieldOffset(Offset = "0x68")]
	protected string LABEL_EO_COST_BG;

	[Token(Token = "0x400EA51")]
	[FieldOffset(Offset = "0x70")]
	protected string LABEL_EO_CARDNAME;

	[Token(Token = "0x400EA52")]
	[FieldOffset(Offset = "0x78")]
	private ElementObjectManager m_EOManager_Origin;

	[Token(Token = "0x170018B4")]
	protected ElementObjectManager m_EOManager
	{
		[Token(Token = "0x600A194")]
		[Address(RVA = "0xEF2A90", Offset = "0xEF1C90", VA = "0x180EF2A90")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600A193")]
	[Address(RVA = "0xEF26E0", Offset = "0xEF18E0", VA = "0x180EF26E0")]
	public void SetData(ShowCardNameData data)
	{
	}

	[Token(Token = "0x600A195")]
	[Address(RVA = "0xEF29A0", Offset = "0xEF1BA0", VA = "0x180EF29A0")]
	public LogShowCardName()
	{
	}
}
