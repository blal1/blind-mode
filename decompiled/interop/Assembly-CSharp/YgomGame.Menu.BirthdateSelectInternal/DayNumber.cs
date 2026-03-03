using Il2CppDummyDll;

namespace YgomGame.Menu.BirthdateSelectInternal;

[Token(Token = "0x2001400")]
internal class DayNumber : AgeNumber
{
	[Token(Token = "0x400C4C9")]
	[FieldOffset(Offset = "0x0")]
	private static readonly string[] fullList;

	[Token(Token = "0x400C4CA")]
	[FieldOffset(Offset = "0x28")]
	private string m_unselectTextCache;

	[Token(Token = "0x6007C6F")]
	[Address(RVA = "0xC61BC0", Offset = "0xC60DC0", VA = "0x180C61BC0")]
	private static string[] createDaysList(int dayNum)
	{
		return null;
	}

	[Token(Token = "0x6007C70")]
	[Address(RVA = "0xC61980", Offset = "0xC60B80", VA = "0x180C61980")]
	public DayNumber(int dayNum, int defaultDay)
	{
	}

	[Token(Token = "0x6007C71")]
	[Address(RVA = "0xC61D80", Offset = "0xC60F80", VA = "0x180C61D80", Slot = "4")]
	protected override int indexToValue(int index)
	{
		return default(int);
	}

	[Token(Token = "0x6007C72")]
	[Address(RVA = "0xC61D40", Offset = "0xC60F40", VA = "0x180C61D40", Slot = "5")]
	protected override string getUnselectText()
	{
		return null;
	}

	[Token(Token = "0x6007C73")]
	[Address(RVA = "0xC60B30", Offset = "0xC5FD30", VA = "0x180C60B30")]
	public int GetDays()
	{
		return default(int);
	}

	[Token(Token = "0x6007C74")]
	[Address(RVA = "0xC60BF0", Offset = "0xC5FDF0", VA = "0x180C60BF0")]
	public void Rebuild(int dayNum)
	{
	}
}
