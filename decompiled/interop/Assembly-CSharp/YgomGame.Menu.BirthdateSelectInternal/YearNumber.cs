using Il2CppDummyDll;

namespace YgomGame.Menu.BirthdateSelectInternal;

[Token(Token = "0x20013FE")]
internal class YearNumber : AgeNumber
{
	[Token(Token = "0x400C4C5")]
	[FieldOffset(Offset = "0x28")]
	private int m_nearYear;

	[Token(Token = "0x400C4C6")]
	[FieldOffset(Offset = "0x30")]
	private string m_unselectTextCache;

	[Token(Token = "0x6007C68")]
	[Address(RVA = "0xC6A730", Offset = "0xC69930", VA = "0x180C6A730")]
	public YearNumber(int near, int far, int defaultYear)
	{
	}

	[Token(Token = "0x6007C69")]
	[Address(RVA = "0xC6AA40", Offset = "0xC69C40", VA = "0x180C6AA40", Slot = "4")]
	protected override int indexToValue(int index)
	{
		return default(int);
	}

	[Token(Token = "0x6007C6A")]
	[Address(RVA = "0xC6AA00", Offset = "0xC69C00", VA = "0x180C6AA00", Slot = "5")]
	protected override string getUnselectText()
	{
		return null;
	}
}
