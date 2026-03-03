using Il2CppDummyDll;

namespace System.Security.Cryptography;

[Token(Token = "0x2000004")]
public sealed class AesCryptoServiceProvider : Aes
{
	[Token(Token = "0x17000007")]
	public override byte[] IV
	{
		[Token(Token = "0x600001B")]
		[Address(RVA = "0x2057F90", Offset = "0x2057190", VA = "0x182057F90", Slot = "9")]
		get
		{
			return null;
		}
		[Token(Token = "0x600001C")]
		[Address(RVA = "0x2057FB0", Offset = "0x20571B0", VA = "0x182057FB0", Slot = "10")]
		set
		{
		}
	}

	[Token(Token = "0x17000008")]
	public override byte[] Key
	{
		[Token(Token = "0x600001D")]
		[Address(RVA = "0x2057FA0", Offset = "0x20571A0", VA = "0x182057FA0", Slot = "11")]
		get
		{
			return null;
		}
		[Token(Token = "0x600001E")]
		[Address(RVA = "0x2057FD0", Offset = "0x20571D0", VA = "0x182057FD0", Slot = "12")]
		set
		{
		}
	}

	[Token(Token = "0x17000009")]
	public override int KeySize
	{
		[Token(Token = "0x600001F")]
		[Address(RVA = "0x40C450", Offset = "0x40B650", VA = "0x18040C450", Slot = "14")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6000020")]
		[Address(RVA = "0x2057FC0", Offset = "0x20571C0", VA = "0x182057FC0", Slot = "15")]
		set
		{
		}
	}

	[Token(Token = "0x1700000A")]
	public override int FeedbackSize
	{
		[Token(Token = "0x6000021")]
		[Address(RVA = "0x64B770", Offset = "0x64A970", VA = "0x18064B770", Slot = "8")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x1700000B")]
	public override CipherMode Mode
	{
		[Token(Token = "0x6000022")]
		[Address(RVA = "0x5EA1B0", Offset = "0x5E93B0", VA = "0x1805EA1B0", Slot = "16")]
		get
		{
			return default(CipherMode);
		}
		[Token(Token = "0x6000023")]
		[Address(RVA = "0x2057FE0", Offset = "0x20571E0", VA = "0x182057FE0", Slot = "17")]
		set
		{
		}
	}

	[Token(Token = "0x1700000C")]
	public override PaddingMode Padding
	{
		[Token(Token = "0x6000024")]
		[Address(RVA = "0x5FA7B0", Offset = "0x5F99B0", VA = "0x1805FA7B0", Slot = "18")]
		get
		{
			return default(PaddingMode);
		}
		[Token(Token = "0x6000025")]
		[Address(RVA = "0x2058050", Offset = "0x2057250", VA = "0x182058050", Slot = "19")]
		set
		{
		}
	}

	[Token(Token = "0x6000016")]
	[Address(RVA = "0x2057F30", Offset = "0x2057130", VA = "0x182057F30")]
	public AesCryptoServiceProvider()
	{
	}

	[Token(Token = "0x6000017")]
	[Address(RVA = "0x2057ED0", Offset = "0x20570D0", VA = "0x182057ED0", Slot = "25")]
	public override void GenerateIV()
	{
	}

	[Token(Token = "0x6000018")]
	[Address(RVA = "0x2057F00", Offset = "0x2057100", VA = "0x182057F00", Slot = "24")]
	public override void GenerateKey()
	{
	}

	[Token(Token = "0x6000019")]
	[Address(RVA = "0x2057CC0", Offset = "0x2056EC0", VA = "0x182057CC0", Slot = "23")]
	public override ICryptoTransform CreateDecryptor(byte[] key, byte[] iv)
	{
		return null;
	}

	[Token(Token = "0x600001A")]
	[Address(RVA = "0x2057DC0", Offset = "0x2056FC0", VA = "0x182057DC0", Slot = "21")]
	public override ICryptoTransform CreateEncryptor(byte[] key, byte[] iv)
	{
		return null;
	}

	[Token(Token = "0x6000026")]
	[Address(RVA = "0x1DF18C0", Offset = "0x1DF0AC0", VA = "0x181DF18C0", Slot = "22")]
	public override ICryptoTransform CreateDecryptor()
	{
		return null;
	}

	[Token(Token = "0x6000027")]
	[Address(RVA = "0x1DF1930", Offset = "0x1DF0B30", VA = "0x181DF1930", Slot = "20")]
	public override ICryptoTransform CreateEncryptor()
	{
		return null;
	}

	[Token(Token = "0x6000028")]
	[Address(RVA = "0x2057EC0", Offset = "0x20570C0", VA = "0x182057EC0", Slot = "5")]
	protected override void Dispose(bool disposing)
	{
	}
}
