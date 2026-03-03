using System.Collections.Generic;
using Il2CppDummyDll;

namespace YgomGame.Duel;

[Token(Token = "0x20018FA")]
public struct MoveMultiData
{
	[Token(Token = "0x400E999")]
	[FieldOffset(Offset = "0x0")]
	public List<ShowActionData> actionDatas;

	[Token(Token = "0x600A0ED")]
	[Address(RVA = "0xEE4C90", Offset = "0xEE3E90", VA = "0x180EE4C90")]
	public MoveMultiData(List<ShowActionData> data)
	{
	}
}
