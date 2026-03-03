using Il2CppDummyDll;

namespace YgomGame.Menu.AgeGate;

[Token(Token = "0x20013F3")]
internal class DayNumber : AgeNumber
{
	[Token(Token = "0x400C49D")]
	[FieldOffset(Offset = "0x0")]
	private static readonly string[] fullList;

	[Token(Token = "0x6007C20")]
	[Address(RVA = "0xC61A70", Offset = "0xC60C70", VA = "0x180C61A70")]
	private static string[] createDaysList(int dayNum)
	{
		return null;
	}

	[Token(Token = "0x6007C21")]
	[Address(RVA = "0xC618B0", Offset = "0xC60AB0", VA = "0x180C618B0")]
	public DayNumber(int dayNum, int defaultDay)
	{
	}

	[Token(Token = "0x6007C22")]
	[Address(RVA = "0xC61D80", Offset = "0xC60F80", VA = "0x180C61D80", Slot = "4")]
	protected override int indexToValue(int index)
	{
		return default(int);
	}

	[Token(Token = "0x6007C23")]
	[Address(RVA = "0xC61D10", Offset = "0xC60F10", VA = "0x180C61D10", Slot = "5")]
	protected override string getUnselectText()
	{
		return null;
	}

	[Token(Token = "0x6007C24")]
	[Address(RVA = "0xC60B30", Offset = "0xC5FD30", VA = "0x180C60B30")]
	public int GetDays()
	{
		return default(int);
	}

	[Token(Token = "0x6007C25")]
	[Address(RVA = "0xC60B50", Offset = "0xC5FD50", VA = "0x180C60B50")]
	public void Rebuild(int dayNum)
	{
	}
}
