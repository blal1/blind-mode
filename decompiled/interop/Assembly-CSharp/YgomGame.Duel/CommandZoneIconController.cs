using Il2CppDummyDll;
using YgomGame.Card;

namespace YgomGame.Duel;

[Token(Token = "0x20019F4")]
public class CommandZoneIconController : ZoneIconController
{
	[Token(Token = "0x600A7B2")]
	[Address(RVA = "0xF3BC30", Offset = "0xF3AE30", VA = "0x180F3BC30")]
	public static CommandZoneIconController Create(RunEffectWorker worker)
	{
		return null;
	}

	[Token(Token = "0x600A7B3")]
	[Address(RVA = "0xF3B390", Offset = "0xF3A590", VA = "0x180F3B390")]
	public int ActivateCommandAvailableZone(uint commandMask, int cardID, int player, int position, int index, bool ignoreCard)
	{
		return default(int);
	}

	[Token(Token = "0x600A7B4")]
	[Address(RVA = "0xF3B740", Offset = "0xF3A940", VA = "0x180F3B740")]
	public int ActivateDecideAvailableZone(bool ignoreCard)
	{
		return default(int);
	}

	[Token(Token = "0x600A7B5")]
	[Address(RVA = "0xF3B830", Offset = "0xF3AA30", VA = "0x180F3B830")]
	public int ActivateSelectStandZone(uint mask)
	{
		return default(int);
	}

	[Token(Token = "0x600A7B6")]
	[Address(RVA = "0xF3BBC0", Offset = "0xF3ADC0", VA = "0x180F3BBC0")]
	public bool CheckSelectStandAvailableZone(int player, int position, uint mask)
	{
		return default(bool);
	}

	[Token(Token = "0x600A7B7")]
	[Address(RVA = "0xF3B8D0", Offset = "0xF3AAD0", VA = "0x180F3B8D0")]
	public int ActivateSelectStandZone(int cardID, int player, int position)
	{
		return default(int);
	}

	[Token(Token = "0x600A7B8")]
	[Address(RVA = "0xF3BCB0", Offset = "0xF3AEB0", VA = "0x180F3BCB0")]
	private bool IsAvailableZoneHandCommand(Engine.CommandType command, int commandPlayer, int commandPosition, int commandIndex, int targetPlayer, int targetPosition)
	{
		return default(bool);
	}

	[Token(Token = "0x600A7B9")]
	[Address(RVA = "0xF3BD50", Offset = "0xF3AF50", VA = "0x180F3BD50")]
	public bool IsCommandAvailableZone(Engine.CommandType command, int commandPlayer, int commandPosition, int commandIndex, int targetPlayer, int targetPosition, Content.Attribute attribute, bool isExMonster, bool isFieldMagic)
	{
		return default(bool);
	}

	[Token(Token = "0x600A7BA")]
	[Address(RVA = "0xF3BAB0", Offset = "0xF3ACB0", VA = "0x180F3BAB0")]
	private bool CheckAvailableZone(int player, int position)
	{
		return default(bool);
	}

	[Token(Token = "0x600A7BB")]
	[Address(RVA = "0x4306B0", Offset = "0x42F8B0", VA = "0x1804306B0")]
	public CommandZoneIconController()
	{
	}
}
