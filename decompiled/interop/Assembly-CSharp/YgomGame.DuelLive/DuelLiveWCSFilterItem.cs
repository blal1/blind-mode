using Il2CppDummyDll;

namespace YgomGame.DuelLive;

[Token(Token = "0x2000F01")]
public class DuelLiveWCSFilterItem
{
	[Token(Token = "0x2000F02")]
	public enum Target
	{
		[Token(Token = "0x400A5B2")]
		Team,
		[Token(Token = "0x400A5B3")]
		Leader
	}

	[Token(Token = "0x400A5AB")]
	[FieldOffset(Offset = "0x10")]
	public int filterNo;

	[Token(Token = "0x400A5AC")]
	[FieldOffset(Offset = "0x14")]
	public Target target;

	[Token(Token = "0x400A5AD")]
	[FieldOffset(Offset = "0x18")]
	public int ID;

	[Token(Token = "0x400A5AE")]
	[FieldOffset(Offset = "0x20")]
	public string mainText;

	[Token(Token = "0x400A5AF")]
	[FieldOffset(Offset = "0x28")]
	public string subText;

	[Token(Token = "0x400A5B0")]
	[FieldOffset(Offset = "0x30")]
	public int teamIconID;

	[Token(Token = "0x6005AD1")]
	[Address(RVA = "0xA11DF0", Offset = "0xA10FF0", VA = "0x180A11DF0")]
	public bool CheckProduct(DuelLiveProductContext ctx)
	{
		return default(bool);
	}

	[Token(Token = "0x6005AD2")]
	[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
	public DuelLiveWCSFilterItem()
	{
	}
}
