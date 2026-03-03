using Il2CppDummyDll;

namespace YgomGame.Menu.AgeGate;

[Token(Token = "0x20013F1")]
internal class YearNumber : AgeNumber
{
	[Token(Token = "0x400C49B")]
	[FieldOffset(Offset = "0x28")]
	private int m_nowYear;

	[Token(Token = "0x6007C19")]
	[Address(RVA = "0xC6A890", Offset = "0xC69A90", VA = "0x180C6A890")]
	public YearNumber(int nowYear, int range, int defaultYear)
	{
	}

	[Token(Token = "0x6007C1A")]
	[Address(RVA = "0xC6AA40", Offset = "0xC69C40", VA = "0x180C6AA40", Slot = "4")]
	protected override int indexToValue(int index)
	{
		return default(int);
	}

	[Token(Token = "0x6007C1B")]
	[Address(RVA = "0xC6A9D0", Offset = "0xC69BD0", VA = "0x180C6A9D0", Slot = "5")]
	protected override string getUnselectText()
	{
		return null;
	}
}
