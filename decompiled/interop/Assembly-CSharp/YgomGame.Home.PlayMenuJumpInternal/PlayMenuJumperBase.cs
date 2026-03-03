using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using YgomGame.Colosseum;

namespace YgomGame.Home.PlayMenuJumpInternal;

[Token(Token = "0x2000D78")]
public abstract class PlayMenuJumperBase
{
	[Token(Token = "0x17000BAF")]
	protected abstract ColosseumUtil.PlayMode playMode
	{
		[Token(Token = "0x6005105")]
		get;
	}

	[Token(Token = "0x17000BB0")]
	protected abstract string prefabPath
	{
		[Token(Token = "0x6005106")]
		get;
	}

	[Token(Token = "0x6005107")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "6")]
	protected virtual void ExtendArgs(ref Dictionary<string, object> args)
	{
	}

	[Token(Token = "0x6005108")]
	public abstract void Check(Action<bool> resultCallback);

	[Token(Token = "0x6005109")]
	[Address(RVA = "0x993A10", Offset = "0x992C10", VA = "0x180993A10")]
	public void Jump()
	{
	}

	[Token(Token = "0x600510A")]
	[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
	protected PlayMenuJumperBase()
	{
	}
}
