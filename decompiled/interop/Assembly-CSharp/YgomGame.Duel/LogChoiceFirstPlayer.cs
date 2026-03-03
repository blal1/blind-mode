using Il2CppDummyDll;
using YgomSystem.ElementSystem;

namespace YgomGame.Duel;

[Token(Token = "0x20018F7")]
public class LogChoiceFirstPlayer : LogItemBase
{
	[Token(Token = "0x400E989")]
	[FieldOffset(Offset = "0x50")]
	protected string LABEL_EO_CONTENT;

	[Token(Token = "0x400E98A")]
	[FieldOffset(Offset = "0x58")]
	protected string LABEL_EO_COLORBARTEAM0;

	[Token(Token = "0x400E98B")]
	[FieldOffset(Offset = "0x60")]
	protected string LABEL_EO_COLORBARTEAM1;

	[Token(Token = "0x400E98C")]
	[FieldOffset(Offset = "0x68")]
	protected string LABEL_EO_TEXT;

	[Token(Token = "0x400E98D")]
	[FieldOffset(Offset = "0x70")]
	protected string LABEL_EO_COIN;

	[Token(Token = "0x400E98E")]
	[FieldOffset(Offset = "0x78")]
	private ElementObjectManager m_EOManager_Origin;

	[Token(Token = "0x1700187C")]
	protected ElementObjectManager m_EOManager
	{
		[Token(Token = "0x600A0D7")]
		[Address(RVA = "0xEE1A90", Offset = "0xEE0C90", VA = "0x180EE1A90")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600A0D6")]
	[Address(RVA = "0xEE1790", Offset = "0xEE0990", VA = "0x180EE1790")]
	public void SetData(ChoiceFirstPlayerData data)
	{
	}

	[Token(Token = "0x600A0D8")]
	[Address(RVA = "0xEE19A0", Offset = "0xEE0BA0", VA = "0x180EE19A0")]
	public LogChoiceFirstPlayer()
	{
	}
}
