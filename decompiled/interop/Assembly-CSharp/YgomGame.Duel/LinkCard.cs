using System;
using Il2CppDummyDll;
using UnityEngine;

namespace YgomGame.Duel;

[Token(Token = "0x2001A90")]
public class LinkCard : SummonCardBase
{
	[Token(Token = "0x400F4C5")]
	[FieldOffset(Offset = "0x0")]
	public static string TimelinePath;

	[Token(Token = "0x17001AC1")]
	protected override string timelinePath
	{
		[Token(Token = "0x600ACBF")]
		[Address(RVA = "0x4424A0", Offset = "0x4416A0", VA = "0x1804424A0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001AC2")]
	protected override string trailOffsetLabel
	{
		[Token(Token = "0x600ACC0")]
		[Address(RVA = "0x4424F0", Offset = "0x4416F0", VA = "0x1804424F0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001AC3")]
	protected override string seLabel
	{
		[Token(Token = "0x600ACC1")]
		[Address(RVA = "0x442470", Offset = "0x441670", VA = "0x180442470", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600ACC2")]
	[Address(RVA = "0x442120", Offset = "0x441320", VA = "0x180442120")]
	public static LinkCard Create(int cardID, int uniqueID, int rareID, Vector3 position, Quaternion rotation, CardRoot.ModelType modelType, Action onLoadFinished, Action onPlayFinished)
	{
		return null;
	}

	[Token(Token = "0x600ACC3")]
	[Address(RVA = "0x442220", Offset = "0x441420", VA = "0x180442220")]
	public static void PreloadTimeline(Action onFinished)
	{
	}

	[Token(Token = "0x600ACC4")]
	[Address(RVA = "0x442370", Offset = "0x441570", VA = "0x180442370")]
	public static void UnloadPreloadedTimeline()
	{
	}

	[Token(Token = "0x600ACC5")]
	[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
	public LinkCard()
	{
	}
}
