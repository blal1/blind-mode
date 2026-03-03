using Il2CppDummyDll;

namespace YgomGame.Menu.AgeGate;

[Token(Token = "0x20013F2")]
internal class MonthNumber : AgeNumber
{
	[Token(Token = "0x400C49C")]
	[FieldOffset(Offset = "0x0")]
	private static readonly string[] monthNames;

	[Token(Token = "0x6007C1C")]
	[Address(RVA = "0xC64810", Offset = "0xC63A10", VA = "0x180C64810")]
	public MonthNumber(int defaultMonth)
	{
	}

	[Token(Token = "0x6007C1D")]
	[Address(RVA = "0xC61D80", Offset = "0xC60F80", VA = "0x180C61D80", Slot = "4")]
	protected override int indexToValue(int index)
	{
		return default(int);
	}

	[Token(Token = "0x6007C1E")]
	[Address(RVA = "0xC648E0", Offset = "0xC63AE0", VA = "0x180C648E0", Slot = "5")]
	protected override string getUnselectText()
	{
		return null;
	}
}
