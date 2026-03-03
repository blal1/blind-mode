using Il2CppDummyDll;
using YgomSystem.ElementSystem;

namespace YgomGame.Duel;

[Token(Token = "0x200190F")]
public class LogShowPhase : LogItemBase
{
	[Token(Token = "0x400EA67")]
	[FieldOffset(Offset = "0x50")]
	protected string LABEL_EO_PHASETEXT;

	[Token(Token = "0x400EA68")]
	[FieldOffset(Offset = "0x58")]
	protected string LABEL_EO_CARDNAME;

	[Token(Token = "0x400EA69")]
	[FieldOffset(Offset = "0x60")]
	private ElementObjectManager m_EOManager_Origin;

	[Token(Token = "0x170018B6")]
	protected ElementObjectManager m_EOManager
	{
		[Token(Token = "0x600A1A5")]
		[Address(RVA = "0xEF3630", Offset = "0xEF2830", VA = "0x180EF3630")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600A1A4")]
	[Address(RVA = "0xEF32F0", Offset = "0xEF24F0", VA = "0x180EF32F0")]
	public void SetData(ShowPhaseData data)
	{
	}

	[Token(Token = "0x600A1A6")]
	[Address(RVA = "0xEF35B0", Offset = "0xEF27B0", VA = "0x180EF35B0")]
	public LogShowPhase()
	{
	}
}
