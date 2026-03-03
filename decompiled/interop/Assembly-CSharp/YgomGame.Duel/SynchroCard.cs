using System;
using Il2CppDummyDll;
using UnityEngine;

namespace YgomGame.Duel;

[Token(Token = "0x2001AA6")]
public class SynchroCard : SummonCardBase
{
	[Token(Token = "0x400F51F")]
	[FieldOffset(Offset = "0x0")]
	public static string TimelinePath;

	[Token(Token = "0x17001AD9")]
	protected override string timelinePath
	{
		[Token(Token = "0x600AD50")]
		[Address(RVA = "0x44C640", Offset = "0x44B840", VA = "0x18044C640", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001ADA")]
	protected override string seLabel
	{
		[Token(Token = "0x600AD51")]
		[Address(RVA = "0x44C610", Offset = "0x44B810", VA = "0x18044C610", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001ADB")]
	protected override string trailOffsetLabel
	{
		[Token(Token = "0x600AD52")]
		[Address(RVA = "0x44C690", Offset = "0x44B890", VA = "0x18044C690", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600AD53")]
	[Address(RVA = "0x44C2C0", Offset = "0x44B4C0", VA = "0x18044C2C0")]
	public static SynchroCard Create(int cardID, int uniqueID, int rareID, Vector3 position, Quaternion rotation, CardRoot.ModelType modelType, Action onLoadFinished, Action onPlayFinished)
	{
		return null;
	}

	[Token(Token = "0x600AD54")]
	[Address(RVA = "0x44C3C0", Offset = "0x44B5C0", VA = "0x18044C3C0")]
	public static void PreloadTimeline(Action onFinished)
	{
	}

	[Token(Token = "0x600AD55")]
	[Address(RVA = "0x44C510", Offset = "0x44B710", VA = "0x18044C510")]
	public static void UnloadPreloadedTimeline()
	{
	}

	[Token(Token = "0x600AD56")]
	[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
	public SynchroCard()
	{
	}
}
