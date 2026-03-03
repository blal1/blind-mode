using Il2CppDummyDll;
using YgomSystem.UI;

namespace YgomGame.Duel;

[Token(Token = "0x20018F8")]
public struct LogBaseData
{
	[Token(Token = "0x400E98F")]
	[FieldOffset(Offset = "0x0")]
	public string loglabel;

	[Token(Token = "0x400E990")]
	[FieldOffset(Offset = "0x8")]
	public int dataindex;

	[Token(Token = "0x400E991")]
	[FieldOffset(Offset = "0x10")]
	public SelectionItem selectionitemL;

	[Token(Token = "0x400E992")]
	[FieldOffset(Offset = "0x18")]
	public SelectionItem selectionitemR;

	[Token(Token = "0x600A0D9")]
	[Address(RVA = "0xEE1750", Offset = "0xEE0950", VA = "0x180EE1750")]
	public LogBaseData(string label, int index)
	{
	}
}
