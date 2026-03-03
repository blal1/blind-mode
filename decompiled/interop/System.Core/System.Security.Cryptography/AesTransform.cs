using Il2CppDummyDll;
using Mono.Security.Cryptography;

namespace System.Security.Cryptography;

[Token(Token = "0x2000005")]
internal class AesTransform : Mono.Security.Cryptography.SymmetricTransform
{
	[Token(Token = "0x4000002")]
	[FieldOffset(Offset = "0x58")]
	private uint[] expandedKey;

	[Token(Token = "0x4000003")]
	[FieldOffset(Offset = "0x60")]
	private int Nk;

	[Token(Token = "0x4000004")]
	[FieldOffset(Offset = "0x64")]
	private int Nr;

	[Token(Token = "0x4000005")]
	[FieldOffset(Offset = "0x0")]
	private static readonly uint[] Rcon;

	[Token(Token = "0x4000006")]
	[FieldOffset(Offset = "0x8")]
	private static readonly byte[] SBox;

	[Token(Token = "0x4000007")]
	[FieldOffset(Offset = "0x10")]
	private static readonly byte[] iSBox;

	[Token(Token = "0x4000008")]
	[FieldOffset(Offset = "0x18")]
	private static readonly uint[] T0;

	[Token(Token = "0x4000009")]
	[FieldOffset(Offset = "0x20")]
	private static readonly uint[] T1;

	[Token(Token = "0x400000A")]
	[FieldOffset(Offset = "0x28")]
	private static readonly uint[] T2;

	[Token(Token = "0x400000B")]
	[FieldOffset(Offset = "0x30")]
	private static readonly uint[] T3;

	[Token(Token = "0x400000C")]
	[FieldOffset(Offset = "0x38")]
	private static readonly uint[] iT0;

	[Token(Token = "0x400000D")]
	[FieldOffset(Offset = "0x40")]
	private static readonly uint[] iT1;

	[Token(Token = "0x400000E")]
	[FieldOffset(Offset = "0x48")]
	private static readonly uint[] iT2;

	[Token(Token = "0x400000F")]
	[FieldOffset(Offset = "0x50")]
	private static readonly uint[] iT3;

	[Token(Token = "0x6000029")]
	[Address(RVA = "0x205EA80", Offset = "0x205DC80", VA = "0x18205EA80")]
	public AesTransform(Aes algo, bool encryption, byte[] key, byte[] iv)
	{
	}

	[Token(Token = "0x600002A")]
	[Address(RVA = "0x205B730", Offset = "0x205A930", VA = "0x18205B730", Slot = "15")]
	protected override void ECB(byte[] input, byte[] output)
	{
	}

	[Token(Token = "0x600002B")]
	[Address(RVA = "0x205E530", Offset = "0x205D730", VA = "0x18205E530")]
	private uint SubByte(uint a)
	{
		return default(uint);
	}

	[Token(Token = "0x600002C")]
	[Address(RVA = "0x205B760", Offset = "0x205A960", VA = "0x18205B760")]
	private void Encrypt128(byte[] indata, byte[] outdata, uint[] ekey)
	{
	}

	[Token(Token = "0x600002D")]
	[Address(RVA = "0x2058930", Offset = "0x2057B30", VA = "0x182058930")]
	private void Decrypt128(byte[] indata, byte[] outdata, uint[] ekey)
	{
	}
}
