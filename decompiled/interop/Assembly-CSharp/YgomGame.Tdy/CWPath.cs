using Il2CppDummyDll;

namespace YgomGame.Tdy;

[Token(Token = "0x2000856")]
public class CWPath
{
	[Token(Token = "0x40085F4")]
	[FieldOffset(Offset = "0x0")]
	public static readonly string TdyInfo;

	[Token(Token = "0x40085F5")]
	[FieldOffset(Offset = "0x8")]
	public static readonly string TdyInfoPlayEffects;

	[Token(Token = "0x40085F6")]
	[FieldOffset(Offset = "0x10")]
	public static readonly string DuelResultInfo;

	[Token(Token = "0x40085F7")]
	[FieldOffset(Offset = "0x18")]
	public static readonly string DuelResultInfoPlayEffects;

	[Token(Token = "0x40085F8")]
	[FieldOffset(Offset = "0x20")]
	public static readonly string DuelResultInfoRewards;

	[Token(Token = "0x40085F9")]
	[FieldOffset(Offset = "0x28")]
	public static readonly string DuelResultInfoCompleteRewards;

	[Token(Token = "0x40085FA")]
	[FieldOffset(Offset = "0x30")]
	public static readonly string MasterTdyHoldingEndts;

	[Token(Token = "0x60032B6")]
	[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
	public CWPath()
	{
	}
}
