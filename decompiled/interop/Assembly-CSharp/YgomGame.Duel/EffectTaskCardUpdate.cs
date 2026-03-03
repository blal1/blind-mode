using System.Collections.Generic;
using Il2CppDummyDll;

namespace YgomGame.Duel;

[Token(Token = "0x2001AFE")]
public class EffectTaskCardUpdate : EffectTask
{
	[Token(Token = "0x600AF24")]
	[Address(RVA = "0x466DD0", Offset = "0x465FD0", VA = "0x180466DD0")]
	public static Dictionary<string, object> PreCreate(RunEffectWorker worker, int param1, int param2, int param3)
	{
		return null;
	}

	[Token(Token = "0x600AF25")]
	[Address(RVA = "0x466C80", Offset = "0x465E80", VA = "0x180466C80")]
	public static EffectTask Create(RunEffectWorker worker, int param1, int param2, int param3, Dictionary<string, object> immediateWork)
	{
		return null;
	}

	[Token(Token = "0x600AF26")]
	[Address(RVA = "0x466EB0", Offset = "0x4660B0", VA = "0x180466EB0")]
	public EffectTaskCardUpdate(RunEffectWorker worker, int param1, int param2, int param3, Dictionary<string, object> immediateWork)
	{
	}

	[Token(Token = "0x600AF27")]
	[Address(RVA = "0x404830", Offset = "0x403A30", VA = "0x180404830", Slot = "4")]
	public override bool Update()
	{
		return default(bool);
	}
}
