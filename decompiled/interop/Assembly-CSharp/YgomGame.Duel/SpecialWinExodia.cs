using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Playables;

namespace YgomGame.Duel;

[Token(Token = "0x200192D")]
public class SpecialWinExodia : SpecialWinBase
{
	[Token(Token = "0x400EAF6")]
	[FieldOffset(Offset = "0x20")]
	private List<string> _seList;

	[Token(Token = "0x400EAF7")]
	[FieldOffset(Offset = "0x28")]
	private List<int> cardIDs;

	[Token(Token = "0x400EAF8")]
	[FieldOffset(Offset = "0x30")]
	private List<Texture2D> cardTextures;

	[Token(Token = "0x400EAF9")]
	[FieldOffset(Offset = "0x38")]
	private string[] labels;

	[Token(Token = "0x400EAFA")]
	[FieldOffset(Offset = "0x40")]
	private string labelFront;

	[Token(Token = "0x400EAFB")]
	[FieldOffset(Offset = "0x48")]
	private GameObject cardPictureContainer;

	[Token(Token = "0x170018DF")]
	protected override string prefabPath
	{
		[Token(Token = "0x600A266")]
		[Address(RVA = "0xEFD290", Offset = "0xEFC490", VA = "0x180EFD290", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170018E0")]
	protected override List<string> seList
	{
		[Token(Token = "0x600A267")]
		[Address(RVA = "0x3D8370", Offset = "0x3D7570", VA = "0x1803D8370", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600A268")]
	[Address(RVA = "0xEFC460", Offset = "0xEFB660", VA = "0x180EFC460", Slot = "9")]
	public override void Initialize()
	{
	}

	[Token(Token = "0x600A269")]
	[Address(RVA = "0xEFC950", Offset = "0xEFBB50", VA = "0x180EFC950", Slot = "10")]
	protected override void Setup(PlayableDirector timeline)
	{
	}

	[Token(Token = "0x600A26A")]
	[Address(RVA = "0xEFC8B0", Offset = "0xEFBAB0", VA = "0x180EFC8B0", Slot = "11")]
	protected override void OnFinished()
	{
	}

	[Token(Token = "0x600A26B")]
	[Address(RVA = "0xEFCE10", Offset = "0xEFC010", VA = "0x180EFCE10")]
	public SpecialWinExodia()
	{
	}
}
