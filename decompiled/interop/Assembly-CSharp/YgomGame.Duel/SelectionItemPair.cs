using Il2CppDummyDll;
using YgomSystem.UI;

namespace YgomGame.Duel;

[Token(Token = "0x20018BA")]
public struct SelectionItemPair
{
	[Token(Token = "0x400E7F1")]
	[FieldOffset(Offset = "0x0")]
	public SelectionItem sbtnl;

	[Token(Token = "0x400E7F2")]
	[FieldOffset(Offset = "0x8")]
	public SelectionItem sbtnr;

	[Token(Token = "0x6009F1C")]
	[Address(RVA = "0x5BF700", Offset = "0x5BE900", VA = "0x1805BF700")]
	public SelectionItemPair(SelectionItem sbtnl, SelectionItem sbtnr)
	{
	}
}
