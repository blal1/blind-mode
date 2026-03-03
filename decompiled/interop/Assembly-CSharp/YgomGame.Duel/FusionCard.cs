using System;
using Il2CppDummyDll;
using UnityEngine;

namespace YgomGame.Duel;

[Token(Token = "0x2001A8B")]
public class FusionCard : SummonCardBase
{
	[Token(Token = "0x400F4B5")]
	[FieldOffset(Offset = "0x0")]
	public static string TimelinePath;

	[Token(Token = "0x17001ABC")]
	protected override string timelinePath
	{
		[Token(Token = "0x600ACA3")]
		[Address(RVA = "0x4209B0", Offset = "0x41FBB0", VA = "0x1804209B0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001ABD")]
	protected override string seLabel
	{
		[Token(Token = "0x600ACA4")]
		[Address(RVA = "0x420980", Offset = "0x41FB80", VA = "0x180420980", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001ABE")]
	protected override string trailOffsetLabel
	{
		[Token(Token = "0x600ACA5")]
		[Address(RVA = "0x420A00", Offset = "0x41FC00", VA = "0x180420A00", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600ACA6")]
	[Address(RVA = "0x420630", Offset = "0x41F830", VA = "0x180420630")]
	public static FusionCard Create(int cardID, int uniqueID, int rareID, Vector3 position, Quaternion rotation, CardRoot.ModelType modelType, Action onLoadFinished, Action onPlayFinished)
	{
		return null;
	}

	[Token(Token = "0x600ACA7")]
	[Address(RVA = "0x420730", Offset = "0x41F930", VA = "0x180420730")]
	public static void PreloadTimeline(Action onFinished)
	{
	}

	[Token(Token = "0x600ACA8")]
	[Address(RVA = "0x420880", Offset = "0x41FA80", VA = "0x180420880")]
	public static void UnloadPreloadedTimeline()
	{
	}

	[Token(Token = "0x600ACA9")]
	[Address(RVA = "0x3DC070", Offset = "0x3DB270", VA = "0x1803DC070")]
	public FusionCard()
	{
	}
}
