using System;
using Il2CppDummyDll;
using UnityEngine;

namespace YgomGame.Duel;

[Token(Token = "0x2001A97")]
public class RitualCard : SummonCardBase
{
	[Token(Token = "0x400F4DF")]
	[FieldOffset(Offset = "0x0")]
	public static string TimelinePath;

	[Token(Token = "0x17001AC7")]
	protected override string timelinePath
	{
		[Token(Token = "0x600ACEB")]
		[Address(RVA = "0x445030", Offset = "0x444230", VA = "0x180445030", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001AC8")]
	protected override string seLabel
	{
		[Token(Token = "0x600ACEC")]
		[Address(RVA = "0x445000", Offset = "0x444200", VA = "0x180445000", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001AC9")]
	protected override string trailOffsetLabel
	{
		[Token(Token = "0x600ACED")]
		[Address(RVA = "0x445080", Offset = "0x444280", VA = "0x180445080", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600ACEE")]
	[Address(RVA = "0x444CB0", Offset = "0x443EB0", VA = "0x180444CB0")]
	public static RitualCard Create(int cardID, int uniqueID, int rareID, Vector3 position, Quaternion rotation, CardRoot.ModelType modelType, Action onLoadFinished, Action onPlayFinished)
	{
		return null;
	}

	[Token(Token = "0x600ACEF")]
	[Address(RVA = "0x444DB0", Offset = "0x443FB0", VA = "0x180444DB0")]
	public static void PreloadTimeline(Action onFinished)
	{
	}

	[Token(Token = "0x600ACF0")]
	[Address(RVA = "0x444F00", Offset = "0x444100", VA = "0x180444F00")]
	public static void UnloadPreloadedTimeline()
	{
	}

	[Token(Token = "0x600ACF1")]
	[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
	public RitualCard()
	{
	}
}
