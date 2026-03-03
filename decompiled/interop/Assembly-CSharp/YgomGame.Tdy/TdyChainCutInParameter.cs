using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace YgomGame.Tdy;

[Token(Token = "0x2000838")]
public class TdyChainCutInParameter
{
	[Token(Token = "0x4008588")]
	[FieldOffset(Offset = "0x10")]
	public Queue<PlayEffectDesc> playQueue;

	[Token(Token = "0x4008589")]
	[FieldOffset(Offset = "0x18")]
	public Action finishCallback;

	[Token(Token = "0x600322C")]
	[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
	public TdyChainCutInParameter()
	{
	}
}
