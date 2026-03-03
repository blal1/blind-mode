using System.Collections.Generic;
using Il2CppDummyDll;

namespace YgomGame.Duel;

[Token(Token = "0x2001B50")]
public class EffectTaskRunFusion : EffectTask
{
	[Token(Token = "0x2001B51")]
	private enum Step
	{
		[Token(Token = "0x400F87A")]
		Loading,
		[Token(Token = "0x400F87B")]
		WaitCardEffect,
		[Token(Token = "0x400F87C")]
		Start,
		[Token(Token = "0x400F87D")]
		Wait,
		[Token(Token = "0x400F87E")]
		Finish
	}

	[Token(Token = "0x400F868")]
	[FieldOffset(Offset = "0x18")]
	private bool finished;

	[Token(Token = "0x400F869")]
	[FieldOffset(Offset = "0x1C")]
	private Step step;

	[Token(Token = "0x400F86A")]
	[FieldOffset(Offset = "0x20")]
	private int[] materialUniqueID;

	[Token(Token = "0x400F86B")]
	[FieldOffset(Offset = "0x28")]
	private int[] materialCardID;

	[Token(Token = "0x400F86C")]
	[FieldOffset(Offset = "0x30")]
	private int dstCardId;

	[Token(Token = "0x400F86D")]
	[FieldOffset(Offset = "0x34")]
	private int dstUniqueID;

	[Token(Token = "0x400F86E")]
	[FieldOffset(Offset = "0x38")]
	private int matNum;

	[Token(Token = "0x400F86F")]
	[FieldOffset(Offset = "0x3C")]
	private Engine.SpSummonType summonType;

	[Token(Token = "0x400F870")]
	[FieldOffset(Offset = "0x40")]
	private int player;

	[Token(Token = "0x400F871")]
	[FieldOffset(Offset = "0x44")]
	private bool isMyself;

	[Token(Token = "0x400F872")]
	[FieldOffset(Offset = "0x45")]
	private bool loadingSummonCard;

	[Token(Token = "0x400F873")]
	[FieldOffset(Offset = "0x48")]
	private int leftCardID;

	[Token(Token = "0x400F874")]
	[FieldOffset(Offset = "0x4C")]
	private int leftUniqueID;

	[Token(Token = "0x400F875")]
	[FieldOffset(Offset = "0x50")]
	private int leftScale;

	[Token(Token = "0x400F876")]
	[FieldOffset(Offset = "0x54")]
	private int rightCardID;

	[Token(Token = "0x400F877")]
	[FieldOffset(Offset = "0x58")]
	private int rightUniqueID;

	[Token(Token = "0x400F878")]
	[FieldOffset(Offset = "0x5C")]
	private int rightScale;

	[Token(Token = "0x600B040")]
	[Address(RVA = "0x47BE80", Offset = "0x47B080", VA = "0x18047BE80")]
	public static Dictionary<string, object> PreCreate(RunEffectWorker worker, int param1, int param2, int param3)
	{
		return null;
	}

	[Token(Token = "0x600B041")]
	[Address(RVA = "0x47B7D0", Offset = "0x47A9D0", VA = "0x18047B7D0")]
	public static EffectTask Create(RunEffectWorker worker, int param1, int param2, int param3, Dictionary<string, object> immediateWork)
	{
		return null;
	}

	[Token(Token = "0x600B042")]
	[Address(RVA = "0x47CC50", Offset = "0x47BE50", VA = "0x18047CC50")]
	public EffectTaskRunFusion(RunEffectWorker worker, int param1, int param2, int param3, Dictionary<string, object> immediateWork)
	{
	}

	[Token(Token = "0x600B043")]
	[Address(RVA = "0x47C420", Offset = "0x47B620", VA = "0x18047C420")]
	private void StartLoad()
	{
	}

	[Token(Token = "0x600B044")]
	[Address(RVA = "0x47BD80", Offset = "0x47AF80", VA = "0x18047BD80")]
	private void Loading()
	{
	}

	[Token(Token = "0x600B045")]
	[Address(RVA = "0x47CC00", Offset = "0x47BE00", VA = "0x18047CC00")]
	private bool WaitCardEffect()
	{
		return default(bool);
	}

	[Token(Token = "0x600B046")]
	[Address(RVA = "0x47C960", Offset = "0x47BB60", VA = "0x18047C960")]
	private void StartSummonEffect()
	{
	}

	[Token(Token = "0x600B047")]
	[Address(RVA = "0x47B990", Offset = "0x47AB90", VA = "0x18047B990")]
	private void LoadLinkSummon(int dstCardId, int matNum, int[] materialUniqueID)
	{
	}

	[Token(Token = "0x600B048")]
	[Address(RVA = "0x47BB90", Offset = "0x47AD90", VA = "0x18047BB90")]
	private void LoadWaitLinkSummon()
	{
	}

	[Token(Token = "0x600B049")]
	[Address(RVA = "0x46E850", Offset = "0x46DA50", VA = "0x18046E850")]
	private void StartLinkSummon(int dstCardId, int matNum, int[] materialUniqueID)
	{
	}

	[Token(Token = "0x600B04A")]
	[Address(RVA = "0x47B870", Offset = "0x47AA70", VA = "0x18047B870")]
	private void LoadFusionSummon(int dstCardId, int matNum, int[] materialUniqueID)
	{
	}

	[Token(Token = "0x600B04B")]
	[Address(RVA = "0x47BB40", Offset = "0x47AD40", VA = "0x18047BB40")]
	private void LoadWaitFusionSummon()
	{
	}

	[Token(Token = "0x600B04C")]
	[Address(RVA = "0x47C3E0", Offset = "0x47B5E0", VA = "0x18047C3E0")]
	private void StartFusionSummon(int dstCardId, int matNum, int[] materialUniqueID)
	{
	}

	[Token(Token = "0x600B04D")]
	[Address(RVA = "0x46C900", Offset = "0x46BB00", VA = "0x18046C900")]
	private void LoadSPFusionSummon(int dstCardId, int matNum, int[] materialUniqueID)
	{
	}

	[Token(Token = "0x600B04E")]
	[Address(RVA = "0x459780", Offset = "0x458980", VA = "0x180459780")]
	private void LoadWaitSPFusionSummon()
	{
	}

	[Token(Token = "0x600B04F")]
	[Address(RVA = "0x47C3E0", Offset = "0x47B5E0", VA = "0x18047C3E0")]
	private void StartSPFusionSummon(int dstCardId, int matNum, int[] materialUniqueID)
	{
	}

	[Token(Token = "0x600B050")]
	[Address(RVA = "0x47BA60", Offset = "0x47AC60", VA = "0x18047BA60")]
	private void LoadRitualSummon(int dstCardId, int matNum, int[] materialUniqueID)
	{
	}

	[Token(Token = "0x600B051")]
	[Address(RVA = "0x47BC20", Offset = "0x47AE20", VA = "0x18047BC20")]
	private void LoadWaitRitualSummon()
	{
	}

	[Token(Token = "0x600B052")]
	[Address(RVA = "0x47C3E0", Offset = "0x47B5E0", VA = "0x18047C3E0")]
	private void StartRitualSummon(int dstCardId, int matNum, int[] materialUniqueID)
	{
	}

	[Token(Token = "0x600B053")]
	[Address(RVA = "0x47BAD0", Offset = "0x47ACD0", VA = "0x18047BAD0")]
	private void LoadSyncSummon(int dstCardId, int matNum, int[] materialUniqueID)
	{
	}

	[Token(Token = "0x600B054")]
	[Address(RVA = "0x47BC70", Offset = "0x47AE70", VA = "0x18047BC70")]
	private void LoadWaitSyncSummon()
	{
	}

	[Token(Token = "0x600B055")]
	[Address(RVA = "0x47C3E0", Offset = "0x47B5E0", VA = "0x18047C3E0")]
	private void StartSyncSummon(int dstCardId, int matNum, int[] materialUniqueID)
	{
	}

	[Token(Token = "0x600B056")]
	[Address(RVA = "0x47BD10", Offset = "0x47AF10", VA = "0x18047BD10")]
	private void LoadXyzSummon(int dstCardId, int matNum, int[] materialUniqueID)
	{
	}

	[Token(Token = "0x600B057")]
	[Address(RVA = "0x47BCC0", Offset = "0x47AEC0", VA = "0x18047BCC0")]
	private void LoadWaitXyzSummon()
	{
	}

	[Token(Token = "0x600B058")]
	[Address(RVA = "0x47C3E0", Offset = "0x47B5E0", VA = "0x18047C3E0")]
	private void StartXyzSummon(int dstCardId, int matNum, int[] matList)
	{
	}

	[Token(Token = "0x600B059")]
	[Address(RVA = "0x47BA00", Offset = "0x47AC00", VA = "0x18047BA00")]
	private void LoadPendSummon(int dstCardId, int matNum, int[] matList)
	{
	}

	[Token(Token = "0x600B05A")]
	[Address(RVA = "0x47BBE0", Offset = "0x47ADE0", VA = "0x18047BBE0")]
	private void LoadWaitPendSummon()
	{
	}

	[Token(Token = "0x600B05B")]
	[Address(RVA = "0x47C6A0", Offset = "0x47B8A0", VA = "0x18047C6A0")]
	private void StartPendSummon(int dstCardId, int matNum, int[] matList)
	{
	}

	[Token(Token = "0x600B05C")]
	[Address(RVA = "0x47CA00", Offset = "0x47BC00", VA = "0x18047CA00", Slot = "4")]
	public override bool Update()
	{
		return default(bool);
	}

	[Token(Token = "0x600B05D")]
	[Address(RVA = "0x455950", Offset = "0x454B50", VA = "0x180455950")]
	private void FinishStep()
	{
	}
}
