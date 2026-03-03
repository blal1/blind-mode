using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace YgomGame.Duel;

[Token(Token = "0x2001990")]
public class BasicCardPlace : CardPlace
{
	[Token(Token = "0x400ECE6")]
	private const float maxStacking = 3f;

	[Token(Token = "0x400ECE8")]
	[FieldOffset(Offset = "0x90")]
	private bool showUnavailavleZoneEff;

	[Token(Token = "0x17001913")]
	public GameObject anchor
	{
		[Token(Token = "0x600A40B")]
		[Address(RVA = "0x49BEA0", Offset = "0x49B0A0", VA = "0x18049BEA0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x600A40C")]
		[Address(RVA = "0x457410", Offset = "0x456610", VA = "0x180457410")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Token(Token = "0x17001914")]
	public override bool isStatusVisible
	{
		[Token(Token = "0x600A419")]
		[Address(RVA = "0x404830", Offset = "0x403A30", VA = "0x180404830", Slot = "22")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x600A40D")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "42")]
	protected virtual void OnEnterImpl(CardRoot cardRoot, int index, bool reqUpdateIndices)
	{
	}

	[Token(Token = "0x600A40E")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "43")]
	protected virtual void OnLeaveImpl(CardRoot cardRoot, int index, bool reqUpdateIndices)
	{
	}

	[Token(Token = "0x600A40F")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "44")]
	protected virtual void OnRegisterImpl(CardRoot cardRoot, int index)
	{
	}

	[Token(Token = "0x600A410")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "45")]
	protected virtual void OnUnregisterImpl(CardRoot cardRoot, int index)
	{
	}

	[Token(Token = "0x600A411")]
	[Address(RVA = "0xF005F0", Offset = "0xEFF7F0", VA = "0x180F005F0")]
	public BasicCardPlace(DuelFieldBase duelField, int team, int position, GameObject anchor)
	{
	}

	[Token(Token = "0x600A412")]
	[Address(RVA = "0xF00590", Offset = "0xEFF790", VA = "0x180F00590")]
	public BasicCardPlace(BasicCardPlace src)
	{
	}

	[Token(Token = "0x600A413")]
	[Address(RVA = "0xEFF770", Offset = "0xEFE970", VA = "0x180EFF770")]
	private void Init(DuelFieldBase duelField, int team, int position, GameObject anchor)
	{
	}

	[Token(Token = "0x600A414")]
	[Address(RVA = "0x404830", Offset = "0x403A30", VA = "0x180404830", Slot = "6")]
	public override bool UpdateTerminate()
	{
		return default(bool);
	}

	[Token(Token = "0x600A415")]
	[Address(RVA = "0xEFF840", Offset = "0xEFEA40", VA = "0x180EFF840", Slot = "12")]
	protected override bool OnLeave(CardRoot cardRoot, int index, bool reqUpdateIndices)
	{
		return default(bool);
	}

	[Token(Token = "0x600A416")]
	[Address(RVA = "0xEFF790", Offset = "0xEFE990", VA = "0x180EFF790", Slot = "11")]
	protected override CardLocator OnEnter(CardRoot cardRoot, int index, bool reqUpdateIndices)
	{
		return null;
	}

	[Token(Token = "0x600A417")]
	[Address(RVA = "0xEFF940", Offset = "0xEFEB40", VA = "0x180EFF940", Slot = "13")]
	protected override void OnRegister(CardRoot cardRoot, int index, bool withEffect)
	{
	}

	[Token(Token = "0x600A418")]
	[Address(RVA = "0xEFF9B0", Offset = "0xEFEBB0", VA = "0x180EFF9B0", Slot = "14")]
	protected override void OnUnregister(CardRoot cardRoot, int index)
	{
	}

	[Token(Token = "0x600A41A")]
	[Address(RVA = "0xEFF9D0", Offset = "0xEFEBD0", VA = "0x180EFF9D0", Slot = "31")]
	protected override void ReqDecideEffectImpl(int index, Action onFinished)
	{
	}

	[Token(Token = "0x600A41B")]
	[Address(RVA = "0xEFF390", Offset = "0xEFE590", VA = "0x180EFF390", Slot = "32")]
	protected override void EndSacrificeTargetEffectImpl(int index, Action onFinished)
	{
	}

	[Token(Token = "0x600A41C")]
	[Address(RVA = "0xF00450", Offset = "0xEFF650", VA = "0x180F00450", Slot = "37")]
	protected override void UpdateStateImpl(Action onFinished)
	{
	}

	[Token(Token = "0x600A41D")]
	[Address(RVA = "0xEFF5F0", Offset = "0xEFE7F0", VA = "0x180EFF5F0", Slot = "15")]
	public override Vector3 GetScreenPos(int index, Vector2 ofsRate)
	{
		return default(Vector3);
	}

	[Token(Token = "0x600A41E")]
	[Address(RVA = "0xEFFD10", Offset = "0xEFEF10", VA = "0x180EFFD10")]
	public void SwapTo(BasicCardPlace to, int toIndexOffset, CardRootTransition transition, Action onFinished)
	{
	}

	[Token(Token = "0x600A41F")]
	[Address(RVA = "0xF00320", Offset = "0xEFF520", VA = "0x180F00320", Slot = "8")]
	protected override void UpdateLocators()
	{
	}

	[Token(Token = "0x600A420")]
	[Address(RVA = "0xEFFA90", Offset = "0xEFEC90", VA = "0x180EFFA90", Slot = "9")]
	protected override void SetupCardLocator(CardLocator cardLocator)
	{
	}
}
