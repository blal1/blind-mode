using Il2CppDummyDll;

namespace YgomGame.Tdy;

[Token(Token = "0x2000859")]
public class TDYMapGameParam : TDYMapParam
{
	[Token(Token = "0x17000653")]
	public override int pollingPeriod
	{
		[Token(Token = "0x60032BF")]
		[Address(RVA = "0x74FC30", Offset = "0x74EE30", VA = "0x18074FC30", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x60032C0")]
	[Address(RVA = "0x74FB90", Offset = "0x74ED90", VA = "0x18074FB90")]
	public TDYMapGameParam()
	{
	}
}
