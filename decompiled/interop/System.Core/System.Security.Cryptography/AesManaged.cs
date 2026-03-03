using Il2CppDummyDll;

namespace System.Security.Cryptography;

[Token(Token = "0x2000003")]
public sealed class AesManaged : Aes
{
	[Token(Token = "0x4000001")]
	[FieldOffset(Offset = "0x48")]
	private RijndaelManaged m_rijndael;

	[Token(Token = "0x17000001")]
	public override int FeedbackSize
	{
		[Token(Token = "0x6000004")]
		[Address(RVA = "0x20586A0", Offset = "0x20578A0", VA = "0x1820586A0", Slot = "8")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000002")]
	public override byte[] IV
	{
		[Token(Token = "0x6000005")]
		[Address(RVA = "0x20586D0", Offset = "0x20578D0", VA = "0x1820586D0", Slot = "9")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000006")]
		[Address(RVA = "0x20587C0", Offset = "0x20579C0", VA = "0x1820587C0", Slot = "10")]
		set
		{
		}
	}

	[Token(Token = "0x17000003")]
	public override byte[] Key
	{
		[Token(Token = "0x6000007")]
		[Address(RVA = "0x2058730", Offset = "0x2057930", VA = "0x182058730", Slot = "11")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000008")]
		[Address(RVA = "0x2058820", Offset = "0x2057A20", VA = "0x182058820", Slot = "12")]
		set
		{
		}
	}

	[Token(Token = "0x17000004")]
	public override int KeySize
	{
		[Token(Token = "0x6000009")]
		[Address(RVA = "0x2058700", Offset = "0x2057900", VA = "0x182058700", Slot = "14")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x600000A")]
		[Address(RVA = "0x20587F0", Offset = "0x20579F0", VA = "0x1820587F0", Slot = "15")]
		set
		{
		}
	}

	[Token(Token = "0x17000005")]
	public override CipherMode Mode
	{
		[Token(Token = "0x600000B")]
		[Address(RVA = "0x2058760", Offset = "0x2057960", VA = "0x182058760", Slot = "16")]
		get
		{
			return default(CipherMode);
		}
		[Token(Token = "0x600000C")]
		[Address(RVA = "0x2058850", Offset = "0x2057A50", VA = "0x182058850", Slot = "17")]
		set
		{
		}
	}

	[Token(Token = "0x17000006")]
	public override PaddingMode Padding
	{
		[Token(Token = "0x600000D")]
		[Address(RVA = "0x2058790", Offset = "0x2057990", VA = "0x182058790", Slot = "18")]
		get
		{
			return default(PaddingMode);
		}
		[Token(Token = "0x600000E")]
		[Address(RVA = "0x2058900", Offset = "0x2057B00", VA = "0x182058900", Slot = "19")]
		set
		{
		}
	}

	[Token(Token = "0x6000003")]
	[Address(RVA = "0x2058510", Offset = "0x2057710", VA = "0x182058510")]
	public AesManaged()
	{
	}

	[Token(Token = "0x600000F")]
	[Address(RVA = "0x2058200", Offset = "0x2057400", VA = "0x182058200", Slot = "22")]
	public override ICryptoTransform CreateDecryptor()
	{
		return null;
	}

	[Token(Token = "0x6000010")]
	[Address(RVA = "0x2058060", Offset = "0x2057260", VA = "0x182058060", Slot = "23")]
	public override ICryptoTransform CreateDecryptor(byte[] key, byte[] iv)
	{
		return null;
	}

	[Token(Token = "0x6000011")]
	[Address(RVA = "0x20583D0", Offset = "0x20575D0", VA = "0x1820583D0", Slot = "20")]
	public override ICryptoTransform CreateEncryptor()
	{
		return null;
	}

	[Token(Token = "0x6000012")]
	[Address(RVA = "0x2058230", Offset = "0x2057430", VA = "0x182058230", Slot = "21")]
	public override ICryptoTransform CreateEncryptor(byte[] key, byte[] iv)
	{
		return null;
	}

	[Token(Token = "0x6000013")]
	[Address(RVA = "0x2058400", Offset = "0x2057600", VA = "0x182058400", Slot = "5")]
	protected override void Dispose(bool disposing)
	{
	}

	[Token(Token = "0x6000014")]
	[Address(RVA = "0x20584B0", Offset = "0x20576B0", VA = "0x1820584B0", Slot = "25")]
	public override void GenerateIV()
	{
	}

	[Token(Token = "0x6000015")]
	[Address(RVA = "0x20584E0", Offset = "0x20576E0", VA = "0x1820584E0", Slot = "24")]
	public override void GenerateKey()
	{
	}
}
