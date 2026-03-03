using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace YgomGame.Tdy;

[Token(Token = "0x200084B")]
public class TdyGetKizunaParameter
{
	[Token(Token = "0x40085C7")]
	[FieldOffset(Offset = "0x10")]
	public PlayEffectDesc eff;

	[Token(Token = "0x40085C8")]
	[FieldOffset(Offset = "0x18")]
	public List<RewardDialogData> rewardDatas;

	[Token(Token = "0x40085C9")]
	[FieldOffset(Offset = "0x20")]
	public Action finishCallback;

	[Token(Token = "0x6003292")]
	[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
	public TdyGetKizunaParameter()
	{
	}
}
