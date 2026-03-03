using System;
using Il2CppDummyDll;

namespace YgomGame.Menu;

[Token(Token = "0x2001258")]
public abstract class SelectDialogViewControllerBase<RESULT> : InformDialogViewControllerBase<Action<RESULT>>
{
	[Token(Token = "0x6007252")]
	protected void OnDecided(RESULT result)
	{
	}

	[Token(Token = "0x6007253")]
	protected SelectDialogViewControllerBase()
	{
	}
}
[Token(Token = "0x2001259")]
public abstract class SelectDialogViewControllerBase<ARG, RESULT> : InformDialogViewControllerBase<ARG, Action<RESULT>>
{
	[Token(Token = "0x6007254")]
	protected void OnDecided(RESULT result)
	{
	}

	[Token(Token = "0x6007255")]
	protected SelectDialogViewControllerBase()
	{
	}
}
[Token(Token = "0x200125A")]
public abstract class SelectDialogViewControllerBase<ARG1, ARG2, RESULT> : InformDialogViewControllerBase<ARG1, ARG2, Action<RESULT>>
{
	[Token(Token = "0x6007256")]
	protected void OnDecided(RESULT result)
	{
	}

	[Token(Token = "0x6007257")]
	protected void SendResult(RESULT result)
	{
	}

	[Token(Token = "0x6007258")]
	protected SelectDialogViewControllerBase()
	{
	}
}
[Token(Token = "0x200125B")]
public abstract class SelectDialogViewControllerBase<ARG1, ARG2, ARG3, RESULT> : InformDialogViewControllerBase<ARG1, ARG2, ARG3, Action<RESULT>>
{
	[Token(Token = "0x6007259")]
	protected void OnDecided(RESULT result)
	{
	}

	[Token(Token = "0x600725A")]
	protected SelectDialogViewControllerBase()
	{
	}
}
