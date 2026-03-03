using Il2CppDummyDll;
using YgomGame.TextIDs;

namespace YgomGame.Menu.BirthdateSelectInternal;

[Token(Token = "0x20013FF")]
internal class MonthNumber : AgeNumber
{
	[Token(Token = "0x400C4C7")]
	[FieldOffset(Offset = "0x0")]
	private static readonly IDS_GC[] k_monthNameIDs;

	[Token(Token = "0x400C4C8")]
	[FieldOffset(Offset = "0x28")]
	private string m_unselectTextCache;

	[Token(Token = "0x6007C6B")]
	[Address(RVA = "0xC64650", Offset = "0xC63850", VA = "0x180C64650")]
	public MonthNumber(int defaultMonth)
	{
	}

	[Token(Token = "0x6007C6C")]
	[Address(RVA = "0xC61D80", Offset = "0xC60F80", VA = "0x180C61D80", Slot = "4")]
	protected override int indexToValue(int index)
	{
		return default(int);
	}

	[Token(Token = "0x6007C6D")]
	[Address(RVA = "0xC64910", Offset = "0xC63B10", VA = "0x180C64910", Slot = "5")]
	protected override string getUnselectText()
	{
		return null;
	}
}
