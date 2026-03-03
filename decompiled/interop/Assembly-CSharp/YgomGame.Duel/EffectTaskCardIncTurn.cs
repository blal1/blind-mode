using Il2CppDummyDll;
using UnityEngine;

namespace YgomGame.Duel;

[Token(Token = "0x2001AE6")]
public class EffectTaskCardIncTurn : EffectTask
{
	[Token(Token = "0x400F670")]
	[FieldOffset(Offset = "0x18")]
	private bool finished;

	[Token(Token = "0x400F671")]
	[FieldOffset(Offset = "0x20")]
	private GameObject obj;

	[Token(Token = "0x400F672")]
	[FieldOffset(Offset = "0x28")]
	private DuelTurnCount turnCount;

	[Token(Token = "0x400F673")]
	private const string prefabPath = "Prefabs/Duel/DuelTurnCount";

	[Token(Token = "0x400F674")]
	[FieldOffset(Offset = "0x30")]
	private float waitTime;

	[Token(Token = "0x600AEBA")]
	[Address(RVA = "0x45C020", Offset = "0x45B220", VA = "0x18045C020")]
	public static EffectTask Create(RunEffectWorker workerHUD, int param1, int param2, int param3)
	{
		return null;
	}

	[Token(Token = "0x600AEBB")]
	[Address(RVA = "0x45C350", Offset = "0x45B550", VA = "0x18045C350")]
	public EffectTaskCardIncTurn(RunEffectWorker workerHUD, int param1, int param2, int param3)
	{
	}

	[Token(Token = "0x600AEBC")]
	[Address(RVA = "0x45C280", Offset = "0x45B480", VA = "0x18045C280", Slot = "4")]
	public override bool Update()
	{
		return default(bool);
	}

	[Token(Token = "0x600AEBD")]
	[Address(RVA = "0x45C270", Offset = "0x45B470", VA = "0x18045C270", Slot = "5")]
	public override void OnDestroy()
	{
	}

	[Token(Token = "0x600AEBE")]
	[Address(RVA = "0x45C1D0", Offset = "0x45B3D0", VA = "0x18045C1D0")]
	private void DestroyTurnCount()
	{
	}
}
