using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace YgomGame.Duel;

[Token(Token = "0x200193A")]
public class AttackTargetingOperation
{
	[Token(Token = "0x400EB34")]
	[FieldOffset(Offset = "0x10")]
	private DuelGameObjectManager goManager;

	[Token(Token = "0x400EB35")]
	[FieldOffset(Offset = "0x18")]
	private List<int> targets;

	[Token(Token = "0x400EB36")]
	[FieldOffset(Offset = "0x20")]
	private TargetingLine targetingLine;

	[Token(Token = "0x400EB37")]
	[FieldOffset(Offset = "0x28")]
	private AttackZoneIconController zoneIcon;

	[Token(Token = "0x400EB38")]
	[FieldOffset(Offset = "0x30")]
	private Vector3 basePosition;

	[Token(Token = "0x400EB39")]
	[FieldOffset(Offset = "0x3C")]
	private Vector2 startScreenPoint;

	[Token(Token = "0x400EB3A")]
	[FieldOffset(Offset = "0x44")]
	private int attackPlayer;

	[Token(Token = "0x400EB3B")]
	[FieldOffset(Offset = "0x48")]
	private int attackPosition;

	[Token(Token = "0x400EB3C")]
	[FieldOffset(Offset = "0x4C")]
	private int targetPlayer;

	[Token(Token = "0x400EB3D")]
	[FieldOffset(Offset = "0x50")]
	private int targetPosition;

	[Token(Token = "0x170018E8")]
	public bool activate
	{
		[Token(Token = "0x600A28E")]
		[Address(RVA = "0xEE86B0", Offset = "0xEE78B0", VA = "0x180EE86B0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600A28F")]
		[Address(RVA = "0xEE86D0", Offset = "0xEE78D0", VA = "0x180EE86D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x170018E9")]
	public bool dragOperation
	{
		[Token(Token = "0x600A290")]
		[Address(RVA = "0xEE86C0", Offset = "0xEE78C0", VA = "0x180EE86C0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600A291")]
		[Address(RVA = "0xEE86E0", Offset = "0xEE78E0", VA = "0x180EE86E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x600A292")]
	[Address(RVA = "0xEE7830", Offset = "0xEE6A30", VA = "0x180EE7830")]
	public static AttackTargetingOperation Create(DuelGameObjectManager goManager)
	{
		return null;
	}

	[Token(Token = "0x600A293")]
	[Address(RVA = "0xEE7DC0", Offset = "0xEE6FC0", VA = "0x180EE7DC0")]
	public void Initialize(DuelGameObjectManager goManager)
	{
	}

	[Token(Token = "0x600A294")]
	[Address(RVA = "0xEE7F20", Offset = "0xEE7120", VA = "0x180EE7F20")]
	public void Tarminate()
	{
	}

	[Token(Token = "0x600A295")]
	[Address(RVA = "0xEE72D0", Offset = "0xEE64D0", VA = "0x180EE72D0")]
	public void BeginDragTargeting(int attackPlayer, int attackPosition, int targetMask, Vector2 screenPoint)
	{
	}

	[Token(Token = "0x600A296")]
	[Address(RVA = "0xEE75D0", Offset = "0xEE67D0", VA = "0x180EE75D0")]
	public void BeginSingleTargeting(int attackPlayer, int attackPosition, int targetPlayer, int targetPosition)
	{
	}

	[Token(Token = "0x600A297")]
	[Address(RVA = "0xEE7780", Offset = "0xEE6980", VA = "0x180EE7780")]
	private void BeginTargeting(int attackPlayer, int attackPosition, Vector2 screenPoint)
	{
	}

	[Token(Token = "0x600A298")]
	[Address(RVA = "0xEE7FD0", Offset = "0xEE71D0", VA = "0x180EE7FD0")]
	public void UpdateTargeting(Vector2 screenPoint)
	{
	}

	[Token(Token = "0x600A299")]
	[Address(RVA = "0xEE7B00", Offset = "0xEE6D00", VA = "0x180EE7B00")]
	private Vector3 GetTargetWorldPosition(int player, int position)
	{
		return default(Vector3);
	}

	[Token(Token = "0x600A29A")]
	[Address(RVA = "0xEE79B0", Offset = "0xEE6BB0", VA = "0x180EE79B0")]
	public (int, int) EndTargeting(bool forceHideLine)
	{
		return default((int, int));
	}

	[Token(Token = "0x600A29B")]
	[Address(RVA = "0xEE7EB0", Offset = "0xEE70B0", VA = "0x180EE7EB0")]
	private void SelectAttackableZone(int player, int position)
	{
	}

	[Token(Token = "0x600A29C")]
	[Address(RVA = "0xEE7EF0", Offset = "0xEE70F0", VA = "0x180EE7EF0")]
	public void SetDispLine(bool disp)
	{
	}

	[Token(Token = "0x600A29D")]
	[Address(RVA = "0xEE7A90", Offset = "0xEE6C90", VA = "0x180EE7A90")]
	public (int, int, int, int) GetCurrentTargetingInfo()
	{
		return default((int, int, int, int));
	}

	[Token(Token = "0x600A29E")]
	[Address(RVA = "0xEE8630", Offset = "0xEE7830", VA = "0x180EE8630")]
	public AttackTargetingOperation()
	{
	}
}
