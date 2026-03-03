using Il2CppDummyDll;

namespace YgomGame.Menu.Common;

[Token(Token = "0x200140D")]
public class AsyncProgressLoadingCountContent : IAsyncProgressContent
{
	[Token(Token = "0x400C4F5")]
	[FieldOffset(Offset = "0x10")]
	private int m_LoadingCount;

	[Token(Token = "0x6007CAA")]
	[Address(RVA = "0xB7F3E0", Offset = "0xB7E5E0", VA = "0x180B7F3E0")]
	public void Clear()
	{
	}

	[Token(Token = "0x6007CAB")]
	[Address(RVA = "0x5F0320", Offset = "0x5EF520", VA = "0x1805F0320")]
	public void AddLoadingCount()
	{
	}

	[Token(Token = "0x6007CAC")]
	[Address(RVA = "0x9C74A0", Offset = "0x9C66A0", VA = "0x1809C74A0")]
	public void DecLoadingCount()
	{
	}

	[Token(Token = "0x6007CAD")]
	[Address(RVA = "0xC55360", Offset = "0xC54560", VA = "0x180C55360", Slot = "4")]
	public bool IsDone()
	{
		return default(bool);
	}

	[Token(Token = "0x6007CAE")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
	public void ProgressUpdate()
	{
	}

	[Token(Token = "0x6007CAF")]
	[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
	public AsyncProgressLoadingCountContent()
	{
	}
}
