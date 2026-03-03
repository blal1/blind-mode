using Il2CppDummyDll;

namespace KonamiCommonIAB;

[Token(Token = "0x200011F")]
internal class WindowsShiftResult : Result
{
	[Token(Token = "0x40006BD")]
	[FieldOffset(Offset = "0x10")]
	private int _code;

	[Token(Token = "0x1700009F")]
	public override int code
	{
		[Token(Token = "0x6000716")]
		[Address(RVA = "0x3C7100", Offset = "0x3C6300", VA = "0x1803C7100", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x6000717")]
	[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
	public WindowsShiftResult(int r)
	{
	}

	[Token(Token = "0x6000718")]
	[Address(RVA = "0x4098D0", Offset = "0x408AD0", VA = "0x1804098D0", Slot = "7")]
	public override bool isSuccess()
	{
		return default(bool);
	}

	[Token(Token = "0x6000719")]
	[Address(RVA = "0x9E9670", Offset = "0x9E8870", VA = "0x1809E9670", Slot = "8")]
	public override bool isFailure()
	{
		return default(bool);
	}

	[Token(Token = "0x600071A")]
	[Address(RVA = "0x3C7100", Offset = "0x3C6300", VA = "0x1803C7100", Slot = "5")]
	public override int getResponse()
	{
		return default(int);
	}

	[Token(Token = "0x600071B")]
	[Address(RVA = "0x9E9630", Offset = "0x9E8830", VA = "0x1809E9630", Slot = "6")]
	public override string getMessage()
	{
		return null;
	}
}
