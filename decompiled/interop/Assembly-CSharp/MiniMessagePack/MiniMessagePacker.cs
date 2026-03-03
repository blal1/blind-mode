using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Il2CppDummyDll;

namespace MiniMessagePack;

[Token(Token = "0x2000100")]
public class MiniMessagePacker
{
	[Token(Token = "0x400063D")]
	[FieldOffset(Offset = "0x10")]
	private byte[] tmp0;

	[Token(Token = "0x400063E")]
	[FieldOffset(Offset = "0x18")]
	private byte[] tmp1;

	[Token(Token = "0x400063F")]
	[FieldOffset(Offset = "0x20")]
	private byte[] string_buf;

	[Token(Token = "0x4000640")]
	[FieldOffset(Offset = "0x28")]
	private Encoding encoder;

	[Token(Token = "0x6000637")]
	[Address(RVA = "0x8C1BD0", Offset = "0x8C0DD0", VA = "0x1808C1BD0")]
	public byte[] Pack(object o)
	{
		return null;
	}

	[Token(Token = "0x6000638")]
	[Address(RVA = "0x8C2E70", Offset = "0x8C2070", VA = "0x1808C2E70")]
	public void Pack(Stream s, object o)
	{
	}

	[Token(Token = "0x6000639")]
	[Address(RVA = "0x8C19E0", Offset = "0x8C0BE0", VA = "0x1808C19E0")]
	private void PackNull(Stream s)
	{
	}

	[Token(Token = "0x600063A")]
	[Address(RVA = "0x8C3550", Offset = "0x8C2750", VA = "0x1808C3550")]
	private void Pack(Stream s, IList list)
	{
	}

	[Token(Token = "0x600063B")]
	[Address(RVA = "0x8C2B00", Offset = "0x8C1D00", VA = "0x1808C2B00")]
	private void Pack(Stream s, IDictionary dict)
	{
	}

	[Token(Token = "0x600063C")]
	[Address(RVA = "0x8C2090", Offset = "0x8C1290", VA = "0x1808C2090")]
	private void Pack(Stream s, bool val)
	{
	}

	[Token(Token = "0x600063D")]
	[Address(RVA = "0x8C2410", Offset = "0x8C1610", VA = "0x1808C2410")]
	private void Pack(Stream s, sbyte val)
	{
	}

	[Token(Token = "0x600063E")]
	[Address(RVA = "0x8C2A60", Offset = "0x8C1C60", VA = "0x1808C2A60")]
	private void Pack(Stream s, byte val)
	{
	}

	[Token(Token = "0x600063F")]
	[Address(RVA = "0x8C2720", Offset = "0x8C1920", VA = "0x1808C2720")]
	private void Pack(Stream s, short val)
	{
	}

	[Token(Token = "0x6000640")]
	[Address(RVA = "0x8C24B0", Offset = "0x8C16B0", VA = "0x1808C24B0")]
	private void Pack(Stream s, ushort val)
	{
	}

	[Token(Token = "0x6000641")]
	[Address(RVA = "0x8C2250", Offset = "0x8C1450", VA = "0x1808C2250")]
	private void Pack(Stream s, int val)
	{
	}

	[Token(Token = "0x6000642")]
	[Address(RVA = "0x8C20D0", Offset = "0x8C12D0", VA = "0x1808C20D0")]
	private void Pack(Stream s, uint val)
	{
	}

	[Token(Token = "0x6000643")]
	[Address(RVA = "0x8C1CE0", Offset = "0x8C0EE0", VA = "0x1808C1CE0")]
	private void Pack(Stream s, long val)
	{
	}

	[Token(Token = "0x6000644")]
	[Address(RVA = "0x8C1A10", Offset = "0x8C0C10", VA = "0x1808C1A10")]
	private void Pack(Stream s, ulong val)
	{
	}

	[Token(Token = "0x6000645")]
	[Address(RVA = "0x8C2600", Offset = "0x8C1800", VA = "0x1808C2600")]
	private void Pack(Stream s, float val)
	{
	}

	[Token(Token = "0x6000646")]
	[Address(RVA = "0x8C1ED0", Offset = "0x8C10D0", VA = "0x1808C1ED0")]
	private void Pack(Stream s, double val)
	{
	}

	[Token(Token = "0x6000647")]
	[Address(RVA = "0x8C28C0", Offset = "0x8C1AC0", VA = "0x1808C28C0")]
	private void Pack(Stream s, string val)
	{
	}

	[Token(Token = "0x6000648")]
	[Address(RVA = "0x8C4B80", Offset = "0x8C3D80", VA = "0x1808C4B80")]
	private void Write(Stream s, ushort val)
	{
	}

	[Token(Token = "0x6000649")]
	[Address(RVA = "0x8C4C00", Offset = "0x8C3E00", VA = "0x1808C4C00")]
	private void Write(Stream s, uint val)
	{
	}

	[Token(Token = "0x600064A")]
	[Address(RVA = "0x8C4A40", Offset = "0x8C3C40", VA = "0x1808C4A40")]
	private void Write(Stream s, ulong val)
	{
	}

	[Token(Token = "0x600064B")]
	[Address(RVA = "0x8C3DE0", Offset = "0x8C2FE0", VA = "0x1808C3DE0")]
	public object Unpack(byte[] buf, int offset, int size)
	{
		return null;
	}

	[Token(Token = "0x600064C")]
	[Address(RVA = "0x8C4A10", Offset = "0x8C3C10", VA = "0x1808C4A10")]
	public object Unpack(byte[] buf)
	{
		return null;
	}

	[Token(Token = "0x600064D")]
	[Address(RVA = "0x8C3EF0", Offset = "0x8C30F0", VA = "0x1808C3EF0")]
	public object Unpack(Stream s)
	{
		return null;
	}

	[Token(Token = "0x600064E")]
	[Address(RVA = "0x8C3C30", Offset = "0x8C2E30", VA = "0x1808C3C30")]
	private long UnpackUint16(Stream s)
	{
		return default(long);
	}

	[Token(Token = "0x600064F")]
	[Address(RVA = "0x8C3CF0", Offset = "0x8C2EF0", VA = "0x1808C3CF0")]
	private long UnpackUint32(Stream s)
	{
		return default(long);
	}

	[Token(Token = "0x6000650")]
	[Address(RVA = "0x8C3B40", Offset = "0x8C2D40", VA = "0x1808C3B40")]
	private string UnpackString(Stream s, long len)
	{
		return null;
	}

	[Token(Token = "0x6000651")]
	[Address(RVA = "0x8C3930", Offset = "0x8C2B30", VA = "0x1808C3930")]
	private byte[] UnpackBinary(Stream s, long len)
	{
		return null;
	}

	[Token(Token = "0x6000652")]
	[Address(RVA = "0x8C3810", Offset = "0x8C2A10", VA = "0x1808C3810")]
	private List<object> UnpackArray(Stream s, long len)
	{
		return null;
	}

	[Token(Token = "0x6000653")]
	[Address(RVA = "0x8C39D0", Offset = "0x8C2BD0", VA = "0x1808C39D0")]
	private Dictionary<string, object> UnpackMap(Stream s, long len)
	{
		return null;
	}

	[Token(Token = "0x6000654")]
	[Address(RVA = "0x8C4CB0", Offset = "0x8C3EB0", VA = "0x1808C4CB0")]
	public MiniMessagePacker()
	{
	}
}
