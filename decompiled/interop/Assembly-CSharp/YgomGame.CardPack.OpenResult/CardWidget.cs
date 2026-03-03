using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using YgomSystem.ElementSystem;

namespace YgomGame.CardPack.OpenResult;

[Token(Token = "0x2001542")]
public class CardWidget : YgomGame.CardPack.CardWidget
{
	[Token(Token = "0x400CBD3")]
	[FieldOffset(Offset = "0x78")]
	private readonly string k_ELabelSecretPulldown;

	[Token(Token = "0x400CBD4")]
	[FieldOffset(Offset = "0x80")]
	public readonly SecretPulldownWidget secretPulldownWidget;

	[Token(Token = "0x400CBD5")]
	[FieldOffset(Offset = "0x88")]
	public Action<CardWidget> onClickCardCallback;

	[Token(Token = "0x400CBD6")]
	[FieldOffset(Offset = "0x90")]
	public Action<CardWidget> onClickPulldownCallback;

	[Token(Token = "0x400CBD7")]
	[FieldOffset(Offset = "0x98")]
	public Action<CardWidget> onSelectedCardCallback;

	[Token(Token = "0x17001407")]
	public int mrk
	{
		[Token(Token = "0x6008351")]
		[Address(RVA = "0x662060", Offset = "0x661260", VA = "0x180662060")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6008352")]
		[Address(RVA = "0xCBCFE0", Offset = "0xCBC1E0", VA = "0x180CBCFE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17001408")]
	public int idx
	{
		[Token(Token = "0x6008353")]
		[Address(RVA = "0x80F760", Offset = "0x80E960", VA = "0x18080F760")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6008354")]
		[Address(RVA = "0x422F50", Offset = "0x422150", VA = "0x180422F50")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x6008355")]
	[Address(RVA = "0xCBC9B0", Offset = "0xCBBBB0", VA = "0x180CBC9B0")]
	public CardWidget(ElementObjectManager eom, GameObject pulldownRoot)
	{
	}

	[Token(Token = "0x6008356")]
	[Address(RVA = "0xCBC540", Offset = "0xCBB740", VA = "0x180CBC540")]
	public void Binding(int mrk, int idx, int pRareType, IReadOnlyList<int> shopIds)
	{
	}

	[Token(Token = "0x6008357")]
	[Address(RVA = "0xCBC950", Offset = "0xCBBB50", VA = "0x180CBC950", Slot = "11")]
	protected override void OnClick()
	{
	}
}
