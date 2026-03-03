using Il2CppDummyDll;

namespace YgomGame.Tdy;

[Token(Token = "0x2000857")]
public class PrefPath
{
	[Token(Token = "0x40085FB")]
	[FieldOffset(Offset = "0x0")]
	public static readonly string TdyTopMenu;

	[Token(Token = "0x40085FC")]
	[FieldOffset(Offset = "0x8")]
	public static readonly string TdyChain;

	[Token(Token = "0x40085FD")]
	[FieldOffset(Offset = "0x10")]
	public static readonly string TdyResult;

	[Token(Token = "0x40085FE")]
	[FieldOffset(Offset = "0x18")]
	public static readonly string TdyGetKizuna;

	[Token(Token = "0x40085FF")]
	[FieldOffset(Offset = "0x20")]
	public static readonly string TdyCompleteKizuna;

	[Token(Token = "0x4008600")]
	[FieldOffset(Offset = "0x28")]
	public static readonly string TdyDuelTransition;

	[Token(Token = "0x60032B8")]
	[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
	public PrefPath()
	{
	}
}
