using System.Collections.Generic;
using Il2CppDummyDll;

namespace YgomGame.Menu.Common;

[Token(Token = "0x200140E")]
public class AsyncProgressContainContent : IAsyncProgressContent
{
	[Token(Token = "0x400C4F6")]
	[FieldOffset(Offset = "0x10")]
	private List<IAsyncProgressContent> m_AsyncContents;

	[Token(Token = "0x6007CB0")]
	[Address(RVA = "0xC55080", Offset = "0xC54280", VA = "0x180C55080", Slot = "4")]
	public bool IsDone()
	{
		return default(bool);
	}

	[Token(Token = "0x6007CB1")]
	[Address(RVA = "0xC55020", Offset = "0xC54220", VA = "0x180C55020")]
	public void Clear()
	{
	}

	[Token(Token = "0x6007CB2")]
	[Address(RVA = "0xC54F40", Offset = "0xC54140", VA = "0x180C54F40")]
	public void Assign(IAsyncProgressContent progressContent)
	{
	}

	[Token(Token = "0x6007CB3")]
	[Address(RVA = "0xC551B0", Offset = "0xC543B0", VA = "0x180C551B0", Slot = "5")]
	public void ProgressUpdate()
	{
	}

	[Token(Token = "0x6007CB4")]
	[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
	public AsyncProgressContainContent()
	{
	}
}
