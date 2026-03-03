using Il2CppDummyDll;

namespace YgomGame.Duel;

[Token(Token = "0x2001B33")]
public class EffectTaskMaterialRun : EffectTask
{
	[Token(Token = "0x600AFE4")]
	[Address(RVA = "0x471BA0", Offset = "0x470DA0", VA = "0x180471BA0")]
	public static EffectTask Create(RunEffectWorker worker, int param1, int param2, int param3)
	{
		return null;
	}

	[Token(Token = "0x600AFE5")]
	[Address(RVA = "0x471D00", Offset = "0x470F00", VA = "0x180471D00")]
	public EffectTaskMaterialRun(RunEffectWorker worker, int param1, int param2, int param3)
	{
	}

	[Token(Token = "0x600AFE6")]
	[Address(RVA = "0x404830", Offset = "0x403A30", VA = "0x180404830", Slot = "4")]
	public override bool Update()
	{
		return default(bool);
	}
}
