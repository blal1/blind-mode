using Il2CppDummyDll;

namespace YgomSystem.LocalFileSystem;

[Token(Token = "0x20002F0")]
public class ReadRequest
{
	[Token(Token = "0x20002F1")]
	public enum Status
	{
		[Token(Token = "0x4000FF2")]
		None,
		[Token(Token = "0x4000FF3")]
		Working,
		[Token(Token = "0x4000FF4")]
		Success,
		[Token(Token = "0x4000FF5")]
		Error
	}

	[Token(Token = "0x4000FEF")]
	[FieldOffset(Offset = "0x10")]
	public Status status;

	[Token(Token = "0x4000FF0")]
	[FieldOffset(Offset = "0x18")]
	public byte[] readData;

	[Token(Token = "0x170001D3")]
	public bool isReading
	{
		[Token(Token = "0x600120C")]
		[Address(RVA = "0x413CA0", Offset = "0x412EA0", VA = "0x180413CA0")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170001D4")]
	public bool isSuccess
	{
		[Token(Token = "0x600120D")]
		[Address(RVA = "0x413CB0", Offset = "0x412EB0", VA = "0x180413CB0")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x600120E")]
	[Address(RVA = "0x413C70", Offset = "0x412E70", VA = "0x180413C70")]
	public ReadRequest()
	{
	}
}
