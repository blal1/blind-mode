using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace YgomSystem.Network;

[Token(Token = "0x2000240")]
public abstract class Format
{
	[Token(Token = "0x4000B77")]
	[FieldOffset(Offset = "0x0")]
	protected static Format _singleInstance;

	[Token(Token = "0x6000D4C")]
	[Address(RVA = "0xD391D0", Offset = "0xD383D0", VA = "0x180D391D0")]
	public static Format GetInstance()
	{
		return null;
	}

	[Token(Token = "0x6000D4D")]
	public abstract byte[] Serialize(Dictionary<string, object> dict, byte[] token);

	[Token(Token = "0x6000D4E")]
	public abstract Dictionary<string, object> Deserialize(byte[] bin);

	[Token(Token = "0x6000D4F")]
	public abstract void DeserializeAsync(byte[] bin, Action<Dictionary<string, object>> onfinish);

	[Token(Token = "0x6000D50")]
	[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
	protected Format()
	{
	}
}
