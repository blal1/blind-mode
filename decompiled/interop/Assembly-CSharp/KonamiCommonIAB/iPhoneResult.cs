using Il2CppDummyDll;

namespace KonamiCommonIAB;

[Token(Token = "0x200011B")]
internal class iPhoneResult : Result
{
	[Token(Token = "0x40006AE")]
	[FieldOffset(Offset = "0x10")]
	private int _code;

	[Token(Token = "0x17000098")]
	public override int code
	{
		[Token(Token = "0x6000708")]
		[Address(RVA = "0x3C7100", Offset = "0x3C6300", VA = "0x1803C7100", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x6000709")]
	[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
	public iPhoneResult(int r)
	{
	}

	[Token(Token = "0x600070A")]
	[Address(RVA = "0x4098D0", Offset = "0x408AD0", VA = "0x1804098D0", Slot = "7")]
	public override bool isSuccess()
	{
		return default(bool);
	}

	[Token(Token = "0x600070B")]
	[Address(RVA = "0x9E9670", Offset = "0x9E8870", VA = "0x1809E9670", Slot = "8")]
	public override bool isFailure()
	{
		return default(bool);
	}

	[Token(Token = "0x600070C")]
	[Address(RVA = "0x3C7100", Offset = "0x3C6300", VA = "0x1803C7100", Slot = "5")]
	public override int getResponse()
	{
		return default(int);
	}

	[Token(Token = "0x600070D")]
	[Address(RVA = "0x9E96D0", Offset = "0x9E88D0", VA = "0x1809E96D0", Slot = "6")]
	public override string getMessage()
	{
		return null;
	}
}
