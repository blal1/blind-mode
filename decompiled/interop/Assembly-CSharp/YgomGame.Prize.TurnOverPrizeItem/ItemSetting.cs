using System;
using Il2CppDummyDll;

namespace YgomGame.Prize.TurnOverPrizeItem;

[Serializable]
[Token(Token = "0x2000B9B")]
public struct ItemSetting
{
	[Token(Token = "0x400975F")]
	[FieldOffset(Offset = "0x0")]
	public int id;

	[Token(Token = "0x4009760")]
	[FieldOffset(Offset = "0x8")]
	public string label;
}
