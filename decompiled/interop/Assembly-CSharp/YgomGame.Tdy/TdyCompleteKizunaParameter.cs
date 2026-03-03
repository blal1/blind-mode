using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace YgomGame.Tdy;

[Token(Token = "0x200083D")]
public class TdyCompleteKizunaParameter
{
	[Token(Token = "0x4008594")]
	[FieldOffset(Offset = "0x10")]
	public List<RewardDialogData> rewardDatas;

	[Token(Token = "0x4008595")]
	[FieldOffset(Offset = "0x18")]
	public Action finishCallback;

	[Token(Token = "0x600323F")]
	[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
	public TdyCompleteKizunaParameter()
	{
	}
}
