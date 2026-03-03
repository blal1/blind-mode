using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Playables;

namespace YgomGame.Duel;

[Token(Token = "0x200192C")]
public abstract class SpecialWinCommonBase : SpecialWinBase
{
	[Token(Token = "0x400EAF1")]
	[FieldOffset(Offset = "0x20")]
	protected List<Texture2D> cardTextures;

	[Token(Token = "0x400EAF2")]
	[FieldOffset(Offset = "0x28")]
	private string labelFront;

	[Token(Token = "0x400EAF3")]
	[FieldOffset(Offset = "0x30")]
	protected GameObject cardPictureContainer;

	[Token(Token = "0x400EAF4")]
	[FieldOffset(Offset = "0x38")]
	protected List<int> cardIDs;

	[Token(Token = "0x400EAF5")]
	[FieldOffset(Offset = "0x40")]
	private List<string> _seList;

	[Token(Token = "0x170018DC")]
	protected abstract string[] labels
	{
		[Token(Token = "0x600A260")]
		get;
	}

	[Token(Token = "0x170018DD")]
	protected override bool destroyOnWinStart
	{
		[Token(Token = "0x600A261")]
		[Address(RVA = "0x404830", Offset = "0x403A30", VA = "0x180404830", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170018DE")]
	protected override List<string> seList
	{
		[Token(Token = "0x600A262")]
		[Address(RVA = "0x404850", Offset = "0x403A50", VA = "0x180404850", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600A263")]
	[Address(RVA = "0xEFC130", Offset = "0xEFB330", VA = "0x180EFC130", Slot = "10")]
	protected override void Setup(PlayableDirector timeline)
	{
	}

	[Token(Token = "0x600A264")]
	[Address(RVA = "0xEFC090", Offset = "0xEFB290", VA = "0x180EFC090", Slot = "11")]
	protected override void OnFinished()
	{
	}

	[Token(Token = "0x600A265")]
	[Address(RVA = "0xEFC2B0", Offset = "0xEFB4B0", VA = "0x180EFC2B0")]
	protected SpecialWinCommonBase()
	{
	}
}
