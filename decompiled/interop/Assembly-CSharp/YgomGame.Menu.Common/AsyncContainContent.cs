using Il2CppDummyDll;

namespace YgomGame.Menu.Common;

[Token(Token = "0x200140F")]
public class AsyncContainContent : IAsyncProgressContent
{
	[Token(Token = "0x400C4F7")]
	[FieldOffset(Offset = "0x10")]
	private AsyncProgressLoadingCountContent m_LoadingCountContent;

	[Token(Token = "0x400C4F8")]
	[FieldOffset(Offset = "0x18")]
	private AsyncProgressContainContent m_AsyncProgressContainContent;

	[Token(Token = "0x6007CB5")]
	[Address(RVA = "0xC54E40", Offset = "0xC54040", VA = "0x180C54E40", Slot = "4")]
	public bool IsDone()
	{
		return default(bool);
	}

	[Token(Token = "0x6007CB6")]
	[Address(RVA = "0xC54E80", Offset = "0xC54080", VA = "0x180C54E80", Slot = "5")]
	public void ProgressUpdate()
	{
	}

	[Token(Token = "0x6007CB7")]
	[Address(RVA = "0xC54DA0", Offset = "0xC53FA0", VA = "0x180C54DA0")]
	public void Clear()
	{
	}

	[Token(Token = "0x6007CB8")]
	[Address(RVA = "0xC54CA0", Offset = "0xC53EA0", VA = "0x180C54CA0")]
	public void AddLoadingCount()
	{
	}

	[Token(Token = "0x6007CB9")]
	[Address(RVA = "0xC54E20", Offset = "0xC54020", VA = "0x180C54E20")]
	public void DecLoadingCount()
	{
	}

	[Token(Token = "0x6007CBA")]
	[Address(RVA = "0xC54CC0", Offset = "0xC53EC0", VA = "0x180C54CC0")]
	public void AssignProgressContent(IAsyncProgressContent progressContent)
	{
	}

	[Token(Token = "0x6007CBB")]
	[Address(RVA = "0xC54EA0", Offset = "0xC540A0", VA = "0x180C54EA0")]
	public AsyncContainContent()
	{
	}
}
