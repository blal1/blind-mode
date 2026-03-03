using System;
using Il2CppDummyDll;

namespace YgomGame.Duel;

[Token(Token = "0x2001AC0")]
public class ZoneCardIn : ZoneCard
{
	[Token(Token = "0x400F587")]
	[FieldOffset(Offset = "0x60")]
	private Action onPlayFinished;

	[Token(Token = "0x600ADDE")]
	[Address(RVA = "0x452720", Offset = "0x451920", VA = "0x180452720")]
	public static ZoneCardIn Create(Zone zone, Mode mode, int index, Action<ZoneCard> onLoadFinished)
	{
		return null;
	}

	[Token(Token = "0x600ADDF")]
	[Address(RVA = "0x4527D0", Offset = "0x4519D0", VA = "0x1804527D0", Slot = "4")]
	public override void Play(int cardID, int uniqueID, bool isFace, Action onPlayFinished)
	{
	}

	[Token(Token = "0x600ADE0")]
	[Address(RVA = "0x452BE0", Offset = "0x451DE0", VA = "0x180452BE0", Slot = "5")]
	public override void Terminate()
	{
	}

	[Token(Token = "0x600ADE1")]
	[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
	public ZoneCardIn()
	{
	}
}
