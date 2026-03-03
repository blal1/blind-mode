using System;
using Il2CppDummyDll;
using UnityEngine;

namespace YgomGame.Duel;

[Token(Token = "0x2001AA4")]
public class SuperFusionCard : SummonCardBase
{
	[Token(Token = "0x400F51D")]
	[FieldOffset(Offset = "0x0")]
	public static string TimelinePath;

	[Token(Token = "0x17001AD6")]
	protected override string timelinePath
	{
		[Token(Token = "0x600AD46")]
		[Address(RVA = "0x44BB90", Offset = "0x44AD90", VA = "0x18044BB90", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001AD7")]
	protected override string seLabel
	{
		[Token(Token = "0x600AD47")]
		[Address(RVA = "0x44BB60", Offset = "0x44AD60", VA = "0x18044BB60", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001AD8")]
	protected override string trailOffsetLabel
	{
		[Token(Token = "0x600AD48")]
		[Address(RVA = "0x44BBE0", Offset = "0x44ADE0", VA = "0x18044BBE0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600AD49")]
	[Address(RVA = "0x44B810", Offset = "0x44AA10", VA = "0x18044B810")]
	public static SuperFusionCard Create(int cardID, int uniqueID, int rareID, Vector3 position, Quaternion rotation, CardRoot.ModelType modelType, Action onLoadFinished, Action onPlayFinished)
	{
		return null;
	}

	[Token(Token = "0x600AD4A")]
	[Address(RVA = "0x44B910", Offset = "0x44AB10", VA = "0x18044B910")]
	public static void PreloadTimeline(Action onFinished)
	{
	}

	[Token(Token = "0x600AD4B")]
	[Address(RVA = "0x44BA60", Offset = "0x44AC60", VA = "0x18044BA60")]
	public static void UnloadPreloadedTimeline()
	{
	}

	[Token(Token = "0x600AD4C")]
	[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
	public SuperFusionCard()
	{
	}
}
