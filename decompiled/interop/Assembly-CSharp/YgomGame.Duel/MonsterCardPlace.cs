using Il2CppDummyDll;
using UnityEngine;

namespace YgomGame.Duel;

[Token(Token = "0x20019AF")]
public class MonsterCardPlace : BasicCardPlace
{
	[Token(Token = "0x400ED82")]
	[FieldOffset(Offset = "0x98")]
	private BattleAimingEffect btlAimingEff;

	[Token(Token = "0x1700193C")]
	public bool isActiveAimingEffect
	{
		[Token(Token = "0x600A517")]
		[Address(RVA = "0xF2C690", Offset = "0xF2B890", VA = "0x180F2C690")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x600A511")]
	[Address(RVA = "0xF2C100", Offset = "0xF2B300", VA = "0x180F2C100")]
	public MonsterCardPlace(DuelFieldBase duelField, int team, int position, GameObject anchor)
	{
	}

	[Token(Token = "0x600A512")]
	[Address(RVA = "0xF2C3A0", Offset = "0xF2B5A0", VA = "0x180F2C3A0", Slot = "16")]
	public override void Terminate()
	{
	}

	[Token(Token = "0x600A513")]
	[Address(RVA = "0xF2C150", Offset = "0xF2B350", VA = "0x180F2C150", Slot = "42")]
	protected override void OnEnterImpl(CardRoot cardRoot, int index, bool reqUpdateIndices)
	{
	}

	[Token(Token = "0x600A514")]
	[Address(RVA = "0xF2C150", Offset = "0xF2B350", VA = "0x180F2C150", Slot = "43")]
	protected override void OnLeaveImpl(CardRoot cardRoot, int index, bool reqUpdateIndices)
	{
	}

	[Token(Token = "0x600A515")]
	[Address(RVA = "0xF2C160", Offset = "0xF2B360", VA = "0x180F2C160", Slot = "44")]
	protected override void OnRegisterImpl(CardRoot cardRoot, int index)
	{
	}

	[Token(Token = "0x600A516")]
	[Address(RVA = "0xF2C110", Offset = "0xF2B310", VA = "0x180F2C110")]
	public void EndBattleAimingEffect()
	{
	}

	[Token(Token = "0x600A518")]
	[Address(RVA = "0xF2C310", Offset = "0xF2B510", VA = "0x180F2C310")]
	public void SetVisibleAimingEffect(bool visible)
	{
	}

	[Token(Token = "0x600A519")]
	[Address(RVA = "0xF2C440", Offset = "0xF2B640", VA = "0x180F2C440")]
	private void UpdateXyzIndices()
	{
	}
}
