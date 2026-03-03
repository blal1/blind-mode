using System;
using Il2CppDummyDll;
using UnityEngine;

namespace YgomGame.Duel;

[Token(Token = "0x2001AA9")]
public class XyzCard : SummonCardBase
{
	[Token(Token = "0x400F52F")]
	[FieldOffset(Offset = "0x0")]
	public static string TimelinePath;

	[Token(Token = "0x17001ADF")]
	protected override string timelinePath
	{
		[Token(Token = "0x600AD6B")]
		[Address(RVA = "0x451F70", Offset = "0x451170", VA = "0x180451F70", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001AE0")]
	protected override string trailOffsetLabel
	{
		[Token(Token = "0x600AD6C")]
		[Address(RVA = "0x451FC0", Offset = "0x4511C0", VA = "0x180451FC0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001AE1")]
	protected override string seLabel
	{
		[Token(Token = "0x600AD6D")]
		[Address(RVA = "0x451F40", Offset = "0x451140", VA = "0x180451F40", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600AD6E")]
	[Address(RVA = "0x451BF0", Offset = "0x450DF0", VA = "0x180451BF0")]
	public static XyzCard Create(int cardID, int uniqueID, int rareID, Vector3 position, Quaternion rotation, CardRoot.ModelType modelType, Action onLoadFinished, Action onPlayFinished)
	{
		return null;
	}

	[Token(Token = "0x600AD6F")]
	[Address(RVA = "0x451CF0", Offset = "0x450EF0", VA = "0x180451CF0")]
	public static void PreloadTimeline(Action onFinished)
	{
	}

	[Token(Token = "0x600AD70")]
	[Address(RVA = "0x451E40", Offset = "0x451040", VA = "0x180451E40")]
	public static void UnloadPreloadedTimeline()
	{
	}

	[Token(Token = "0x600AD71")]
	[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
	public XyzCard()
	{
	}
}
