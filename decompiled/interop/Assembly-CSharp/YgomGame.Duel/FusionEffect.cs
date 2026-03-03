using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine.Playables;
using YgomSystem.ElementSystem;

namespace YgomGame.Duel;

[Token(Token = "0x2001A8D")]
public class FusionEffect : SummonEffectBase
{
	[Token(Token = "0x2001A8E")]
	public enum FusionType
	{
		[Token(Token = "0x400F4BE")]
		Fusion,
		[Token(Token = "0x400F4BF")]
		SuperFusion,
		[Token(Token = "0x400F4C0")]
		Invocation,
		[Token(Token = "0x400F4C1")]
		InvocationAlt
	}

	[Token(Token = "0x400F4B7")]
	[FieldOffset(Offset = "0x0")]
	private static string[] indexLabel;

	[Token(Token = "0x400F4B8")]
	[FieldOffset(Offset = "0xB8")]
	private PlayableDirector showCardTimeline;

	[Token(Token = "0x400F4B9")]
	[FieldOffset(Offset = "0xC0")]
	private List<PlayableDirector> showCardTimelineUnits;

	[Token(Token = "0x400F4BA")]
	[FieldOffset(Offset = "0xC8")]
	private PlayableDirector bgTimeline;

	[Token(Token = "0x400F4BB")]
	[FieldOffset(Offset = "0xD0")]
	private Action onFinishCallback;

	[Token(Token = "0x17001ABF")]
	public override Engine.SpSummonType spSummonType
	{
		[Token(Token = "0x600ACAD")]
		[Address(RVA = "0x3EF020", Offset = "0x3EE220", VA = "0x1803EF020", Slot = "4")]
		get
		{
			return default(Engine.SpSummonType);
		}
	}

	[Token(Token = "0x17001AC0")]
	public FusionType fusionType
	{
		[Token(Token = "0x600ACAE")]
		[Address(RVA = "0x4226F0", Offset = "0x4218F0", VA = "0x1804226F0")]
		[CompilerGenerated]
		get
		{
			return default(FusionType);
		}
		[Token(Token = "0x600ACAF")]
		[Address(RVA = "0x422700", Offset = "0x421900", VA = "0x180422700")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x600ACB0")]
	[Address(RVA = "0x420A30", Offset = "0x41FC30", VA = "0x180420A30")]
	public static FusionEffect Create()
	{
		return null;
	}

	[Token(Token = "0x600ACB1")]
	[Address(RVA = "0x420D80", Offset = "0x41FF80", VA = "0x180420D80", Slot = "5")]
	public override void Load(int destCardID, int destCardUniqueID, int[] materialCardIDs, int[] materialUniqueIDs, int materialNum, int destRareID, bool destIsMyself)
	{
	}

	[Token(Token = "0x600ACB2")]
	[Address(RVA = "0x420F30", Offset = "0x420130", VA = "0x180420F30", Slot = "6")]
	protected override bool PlayEffect(Action onFinished)
	{
		return default(bool);
	}

	[Token(Token = "0x600ACB3")]
	[Address(RVA = "0x420F40", Offset = "0x420140", VA = "0x180420F40")]
	private bool PlayFusionEffect(int materialNum, Action onFinished)
	{
		return default(bool);
	}

	[Token(Token = "0x600ACB4")]
	[Address(RVA = "0x421970", Offset = "0x420B70", VA = "0x180421970")]
	private void SetupCardShowTimeline(PlayableDirector timeline, int materialNum)
	{
	}

	[Token(Token = "0x600ACB5")]
	[Address(RVA = "0x421D30", Offset = "0x420F30", VA = "0x180421D30")]
	private void SetupFusionTimeline(PlayableDirector timeline, int materialNum)
	{
	}

	[Token(Token = "0x600ACB6")]
	[Address(RVA = "0x4218E0", Offset = "0x420AE0", VA = "0x1804218E0")]
	private void PlayMainTimeline(int materialNum, Action onFinished)
	{
	}

	[Token(Token = "0x600ACB7")]
	[Address(RVA = "0x421C00", Offset = "0x420E00", VA = "0x180421C00")]
	private void SetupDestCardTexture(ElementObjectManager manager)
	{
	}

	[Token(Token = "0x600ACB8")]
	[Address(RVA = "0x422250", Offset = "0x421450", VA = "0x180422250", Slot = "8")]
	public override bool Skip()
	{
		return default(bool);
	}

	[Token(Token = "0x600ACB9")]
	[Address(RVA = "0x420AE0", Offset = "0x41FCE0", VA = "0x180420AE0", Slot = "7")]
	protected override void Finish()
	{
	}

	[Token(Token = "0x600ACBA")]
	[Address(RVA = "0x422670", Offset = "0x421870", VA = "0x180422670")]
	public FusionEffect()
	{
	}
}
