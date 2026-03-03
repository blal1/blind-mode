using System.Collections.Generic;
using Il2CppDummyDll;

namespace YgomGame.Duel;

[Token(Token = "0x2001AE3")]
public class EffectTaskCardHappen : EffectTask
{
	[Token(Token = "0x2001AE4")]
	private enum Step
	{
		[Token(Token = "0x400F667")]
		WaitInit,
		[Token(Token = "0x400F668")]
		WaitTutorial,
		[Token(Token = "0x400F669")]
		InitCard,
		[Token(Token = "0x400F66A")]
		WaitCardLoad,
		[Token(Token = "0x400F66B")]
		Show,
		[Token(Token = "0x400F66C")]
		Finish
	}

	[Token(Token = "0x2001AE5")]
	private enum HappenType
	{
		[Token(Token = "0x400F66E")]
		Happen,
		[Token(Token = "0x400F66F")]
		Apply
	}

	[Token(Token = "0x400F657")]
	[FieldOffset(Offset = "0x18")]
	private int cardID;

	[Token(Token = "0x400F658")]
	[FieldOffset(Offset = "0x1C")]
	private int uniqueID;

	[Token(Token = "0x400F659")]
	[FieldOffset(Offset = "0x20")]
	private int effectID;

	[Token(Token = "0x400F65A")]
	[FieldOffset(Offset = "0x24")]
	private int effectTextID;

	[Token(Token = "0x400F65B")]
	[FieldOffset(Offset = "0x28")]
	private int efxNo;

	[Token(Token = "0x400F65C")]
	[FieldOffset(Offset = "0x2C")]
	private bool finished;

	[Token(Token = "0x400F65D")]
	[FieldOffset(Offset = "0x30")]
	private CardShow cardShow;

	[Token(Token = "0x400F65E")]
	[FieldOffset(Offset = "0x38")]
	private SimpleEffect effAura;

	[Token(Token = "0x400F65F")]
	[FieldOffset(Offset = "0x40")]
	private Engine.CardStatus st;

	[Token(Token = "0x400F660")]
	[FieldOffset(Offset = "0x58")]
	private bool face;

	[Token(Token = "0x400F661")]
	[FieldOffset(Offset = "0x60")]
	private CardRoot cardRoot;

	[Token(Token = "0x400F662")]
	[FieldOffset(Offset = "0x68")]
	private bool tempCard;

	[Token(Token = "0x400F663")]
	[FieldOffset(Offset = "0x69")]
	private bool isAttacker;

	[Token(Token = "0x400F664")]
	[FieldOffset(Offset = "0x6C")]
	private Step step;

	[Token(Token = "0x400F665")]
	[FieldOffset(Offset = "0x70")]
	private HappenType happenType;

	[Token(Token = "0x600AEA9")]
	[Address(RVA = "0x45A590", Offset = "0x459790", VA = "0x18045A590")]
	public static void MinimumEffect(RunEffectWorker worker, int param1, int param2, int param3)
	{
	}

	[Token(Token = "0x600AEAA")]
	[Address(RVA = "0x45AF40", Offset = "0x45A140", VA = "0x18045AF40")]
	public static Dictionary<string, object> PreCreate(RunEffectWorker worker, int param1, int param2, int param3)
	{
		return null;
	}

	[Token(Token = "0x600AEAB")]
	[Address(RVA = "0x45A4F0", Offset = "0x4596F0", VA = "0x18045A4F0")]
	public static EffectTask Create(RunEffectWorker worker, int param1, int param2, int param3, Dictionary<string, object> immediateWork)
	{
		return null;
	}

	[Token(Token = "0x600AEAC")]
	[Address(RVA = "0x45BD50", Offset = "0x45AF50", VA = "0x18045BD50")]
	public EffectTaskCardHappen(RunEffectWorker worker, int param1, int param2, int param3, Dictionary<string, object> immediateWork)
	{
	}

	[Token(Token = "0x600AEAD")]
	[Address(RVA = "0x45BB70", Offset = "0x45AD70", VA = "0x18045BB70", Slot = "4")]
	public override bool Update()
	{
		return default(bool);
	}

	[Token(Token = "0x600AEAE")]
	[Address(RVA = "0x45BA00", Offset = "0x45AC00", VA = "0x18045BA00")]
	private bool StepWaitInit()
	{
		return default(bool);
	}

	[Token(Token = "0x600AEAF")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60")]
	private void StepWaitTutorial()
	{
	}

	[Token(Token = "0x600AEB0")]
	[Address(RVA = "0x45B0D0", Offset = "0x45A2D0", VA = "0x18045B0D0")]
	private bool StepInitCard()
	{
		return default(bool);
	}

	[Token(Token = "0x600AEB1")]
	[Address(RVA = "0x45B5D0", Offset = "0x45A7D0", VA = "0x18045B5D0")]
	private bool StepWaitCardLoad()
	{
		return default(bool);
	}

	[Token(Token = "0x600AEB2")]
	[Address(RVA = "0x45B5B0", Offset = "0x45A7B0", VA = "0x18045B5B0")]
	private void StepShow()
	{
	}

	[Token(Token = "0x600AEB3")]
	[Address(RVA = "0x45A9C0", Offset = "0x459BC0", VA = "0x18045A9C0")]
	private void OnInit()
	{
	}

	[Token(Token = "0x600AEB4")]
	[Address(RVA = "0x45AA90", Offset = "0x459C90", VA = "0x18045AA90")]
	private void OnMove()
	{
	}

	[Token(Token = "0x600AEB5")]
	[Address(RVA = "0x45AF10", Offset = "0x45A110", VA = "0x18045AF10")]
	private void OnWait()
	{
	}

	[Token(Token = "0x600AEB6")]
	[Address(RVA = "0x45A6E0", Offset = "0x4598E0", VA = "0x18045A6E0")]
	private void OnBack()
	{
	}

	[Token(Token = "0x600AEB7")]
	[Address(RVA = "0x45A750", Offset = "0x459950", VA = "0x18045A750")]
	private void OnFinish()
	{
	}
}
