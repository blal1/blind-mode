using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace YgomSystem.Network;

[Token(Token = "0x2000241")]
public class FormatYgom : Format
{
	[Token(Token = "0x6000D52")]
	[Address(RVA = "0xD38F10", Offset = "0xD38110", VA = "0x180D38F10", Slot = "4")]
	public override byte[] Serialize(Dictionary<string, object> dict, byte[] token)
	{
		return null;
	}

	[Token(Token = "0x6000D53")]
	[Address(RVA = "0xD38690", Offset = "0xD37890", VA = "0x180D38690", Slot = "5")]
	public override Dictionary<string, object> Deserialize(byte[] bin)
	{
		return null;
	}

	[Token(Token = "0x6000D54")]
	[Address(RVA = "0xD37D50", Offset = "0xD36F50", VA = "0x180D37D50", Slot = "6")]
	public override void DeserializeAsync(byte[] bin, Action<Dictionary<string, object>> onfinish)
	{
	}

	[Token(Token = "0x6000D55")]
	[Address(RVA = "0xD39180", Offset = "0xD38380", VA = "0x180D39180")]
	public FormatYgom()
	{
	}
}
