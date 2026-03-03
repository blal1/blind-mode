using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace YgomGame.Duel;

[Token(Token = "0x20019AA")]
public class GraveCardPlace : CardPlace
{
	[Token(Token = "0x400ED71")]
	[FieldOffset(Offset = "0x88")]
	private GameObject anchor;

	[Token(Token = "0x400ED72")]
	[FieldOffset(Offset = "0x90")]
	private SharedDefinition.Location location;

	[Token(Token = "0x400ED73")]
	[FieldOffset(Offset = "0x98")]
	private PlaceStatusLabel statusLabel;

	[Token(Token = "0x400ED74")]
	[FieldOffset(Offset = "0xA0")]
	private int localCardNum;

	[Token(Token = "0x400ED75")]
	[FieldOffset(Offset = "0xA4")]
	private bool showDetailStatus;

	[Token(Token = "0x400ED76")]
	[FieldOffset(Offset = "0xA8")]
	private GhostCard topCardGhost;

	[Token(Token = "0x400ED77")]
	[FieldOffset(Offset = "0xB0")]
	private bool effectActivation;

	[Token(Token = "0x400ED78")]
	[FieldOffset(Offset = "0xB4")]
	private int topCardID;

	[Token(Token = "0x400ED79")]
	[FieldOffset(Offset = "0xB8")]
	private int topCardUniqueID;

	[Token(Token = "0x400ED7A")]
	[FieldOffset(Offset = "0xBC")]
	private bool topCardFace;

	[Token(Token = "0x600A4F6")]
	[Address(RVA = "0xF2BF00", Offset = "0xF2B100", VA = "0x180F2BF00")]
	public GraveCardPlace(DuelFieldBase duelField, int team, int position, GameObject anchor, SharedDefinition.Location location)
	{
	}

	[Token(Token = "0x600A4F7")]
	[Address(RVA = "0xF2AB80", Offset = "0xF29D80", VA = "0x180F2AB80", Slot = "17")]
	protected override void OnPrepareToDuel(bool startAtZero, Action onFinished)
	{
	}

	[Token(Token = "0x600A4F8")]
	[Address(RVA = "0xF2AB00", Offset = "0xF29D00", VA = "0x180F2AB00", Slot = "11")]
	protected override CardLocator OnEnter(CardRoot cardRoot, int index, bool reqUpdateIndices)
	{
		return null;
	}

	[Token(Token = "0x600A4F9")]
	[Address(RVA = "0xF2AB10", Offset = "0xF29D10", VA = "0x180F2AB10", Slot = "12")]
	protected override bool OnLeave(CardRoot cardRoot, int index, bool reqUpdateIndices)
	{
		return default(bool);
	}

	[Token(Token = "0x600A4FA")]
	[Address(RVA = "0xF2ACE0", Offset = "0xF29EE0", VA = "0x180F2ACE0", Slot = "13")]
	protected override void OnRegister(CardRoot cardRoot, int index, bool withEffect)
	{
	}

	[Token(Token = "0x600A4FB")]
	[Address(RVA = "0xF2BD70", Offset = "0xF2AF70", VA = "0x180F2BD70")]
	private void UpdatePopUpText()
	{
	}

	[Token(Token = "0x600A4FC")]
	[Address(RVA = "0xF2BE50", Offset = "0xF2B050", VA = "0x180F2BE50")]
	private void UpdateTopCardInfo()
	{
	}

	[Token(Token = "0x600A4FD")]
	[Address(RVA = "0xF2AD80", Offset = "0xF29F80", VA = "0x180F2AD80", Slot = "14")]
	protected override void OnUnregister(CardRoot cardRoot, int index)
	{
	}

	[Token(Token = "0x600A4FE")]
	[Address(RVA = "0xF2BC30", Offset = "0xF2AE30", VA = "0x180F2BC30", Slot = "16")]
	public override void Terminate()
	{
	}

	[Token(Token = "0x600A4FF")]
	[Address(RVA = "0xF2AD90", Offset = "0xF29F90", VA = "0x180F2AD90", Slot = "4")]
	public override void OnUpdate()
	{
	}

	[Token(Token = "0x600A500")]
	[Address(RVA = "0xF2BAF0", Offset = "0xF2ACF0", VA = "0x180F2BAF0")]
	public void SyncToEngine(Dictionary<string, object> savedEngineParams, Action onFinished, int num = 0)
	{
	}

	[Token(Token = "0x600A501")]
	[Address(RVA = "0xF2B450", Offset = "0xF2A650", VA = "0x180F2B450", Slot = "28")]
	protected override void ReqHighlightImpl(bool available, uint cmdBit, Action onFinished)
	{
	}

	[Token(Token = "0x600A502")]
	[Address(RVA = "0xF2B190", Offset = "0xF2A390", VA = "0x180F2B190", Slot = "31")]
	protected override void ReqDecideEffectImpl(int index, Action onFinished)
	{
	}

	[Token(Token = "0x600A503")]
	[Address(RVA = "0xF2B950", Offset = "0xF2AB50", VA = "0x180F2B950")]
	public void ShowStatusLabel(bool immediate, bool showDetail)
	{
	}

	[Token(Token = "0x600A504")]
	[Address(RVA = "0xF2A7E0", Offset = "0xF299E0", VA = "0x180F2A7E0")]
	public void HideStatusLabel(bool immediate, bool finishDetail = false)
	{
	}

	[Token(Token = "0x600A505")]
	[Address(RVA = "0xF2B870", Offset = "0xF2AA70", VA = "0x180F2B870", Slot = "9")]
	protected override void SetupCardLocator(CardLocator cardLocator)
	{
	}

	[Token(Token = "0x600A506")]
	[Address(RVA = "0xF2AD10", Offset = "0xF29F10", VA = "0x180F2AD10", Slot = "38")]
	public override void OnSelected()
	{
	}

	[Token(Token = "0x600A507")]
	[Address(RVA = "0xF2A990", Offset = "0xF29B90", VA = "0x180F2A990", Slot = "39")]
	public override void OnDeselected()
	{
	}
}
