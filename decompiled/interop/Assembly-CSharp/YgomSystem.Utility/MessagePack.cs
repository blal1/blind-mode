using System.IO;
using Il2CppDummyDll;
using MiniMessagePack;

namespace YgomSystem.Utility;

[Token(Token = "0x20003EC")]
public class MessagePack
{
	[Token(Token = "0x40013A7")]
	[FieldOffset(Offset = "0x0")]
	public static MiniMessagePacker packer;

	[Token(Token = "0x600192E")]
	[Address(RVA = "0x5D0AA0", Offset = "0x5CFCA0", VA = "0x1805D0AA0")]
	public static byte[] Pack(object o)
	{
		return null;
	}

	[Token(Token = "0x600192F")]
	[Address(RVA = "0x5D0B10", Offset = "0x5CFD10", VA = "0x1805D0B10")]
	public void Pack(Stream s, object o)
	{
	}

	[Token(Token = "0x6001930")]
	[Address(RVA = "0x5D0B90", Offset = "0x5CFD90", VA = "0x1805D0B90")]
	public static object Unpack(byte[] buf, int offset, int size)
	{
		return null;
	}

	[Token(Token = "0x6001931")]
	[Address(RVA = "0x5D0C20", Offset = "0x5CFE20", VA = "0x1805D0C20")]
	public static object Unpack(byte[] buf)
	{
		return null;
	}

	[Token(Token = "0x6001932")]
	[Address(RVA = "0x5D0C90", Offset = "0x5CFE90", VA = "0x1805D0C90")]
	public static object Unpack(Stream s)
	{
		return null;
	}

	[Token(Token = "0x6001933")]
	[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
	public MessagePack()
	{
	}
}
