using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace YgomGame.Duel;

[Token(Token = "0x2001A92")]
public class LinkEffect : SummonEffectBase
{
	[Token(Token = "0x400F4C7")]
	[FieldOffset(Offset = "0xB8")]
	private List<int> linkMarker;

	[Token(Token = "0x17001AC4")]
	public override Engine.SpSummonType spSummonType
	{
		[Token(Token = "0x600ACC9")]
		[Address(RVA = "0x443230", Offset = "0x442430", VA = "0x180443230", Slot = "4")]
		get
		{
			return default(Engine.SpSummonType);
		}
	}

	[Token(Token = "0x600ACCA")]
	[Address(RVA = "0x442520", Offset = "0x441720", VA = "0x180442520")]
	public static LinkEffect Create()
	{
		return null;
	}

	[Token(Token = "0x600ACCB")]
	[Address(RVA = "0x4425D0", Offset = "0x4417D0", VA = "0x1804425D0", Slot = "5")]
	public override void Load(int destCardID, int destCardUniqueID, int[] materialCardIDs, int[] materialUniqueIDs, int materialNum, int destRareID, bool destIsMyself)
	{
	}

	[Token(Token = "0x600ACCC")]
	[Address(RVA = "0x4427C0", Offset = "0x4419C0", VA = "0x1804427C0", Slot = "6")]
	protected override bool PlayEffect(Action onFinished)
	{
		return default(bool);
	}

	[Token(Token = "0x600ACCD")]
	[Address(RVA = "0x4427F0", Offset = "0x4419F0", VA = "0x1804427F0")]
	private void PlayLinkEffect(int materialNum, Action onFinished)
	{
	}

	[Token(Token = "0x600ACCE")]
	[Address(RVA = "0x4431B0", Offset = "0x4423B0", VA = "0x1804431B0")]
	public LinkEffect()
	{
	}
}
