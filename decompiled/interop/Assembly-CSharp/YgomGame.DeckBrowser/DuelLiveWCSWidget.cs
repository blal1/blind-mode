using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;
using YgomGame.Deck;
using YgomSystem.ElementSystem;

namespace YgomGame.DeckBrowser;

[Token(Token = "0x200102A")]
public class DuelLiveWCSWidget : DeckBrowserOptionWidget
{
	[Token(Token = "0x400AD26")]
	private const string k_PrefPath = "Prefabs/UI/DeckBrowser/Optionals/DeckBrowserOptionForDuelLiveWCS";

	[Token(Token = "0x400AD27")]
	private const int numShareCard = 3;

	[Token(Token = "0x400AD28")]
	[FieldOffset(Offset = "0x160")]
	private List<int> m_ShareCardIds;

	[Token(Token = "0x400AD29")]
	[FieldOffset(Offset = "0x168")]
	private List<int> m_SharePremiumIds;

	[Token(Token = "0x400AD2A")]
	[FieldOffset(Offset = "0x170")]
	private readonly string k_ELabelPickupCard;

	[Token(Token = "0x400AD2B")]
	[FieldOffset(Offset = "0x178")]
	private readonly string k_ELabelShareCardButton;

	[Token(Token = "0x400AD2C")]
	[FieldOffset(Offset = "0x180")]
	private readonly string k_ELabelShareCardImage;

	[Token(Token = "0x400AD2D")]
	[FieldOffset(Offset = "0x188")]
	private readonly string k_ELabelShareCardCursor;

	[Token(Token = "0x400AD2E")]
	[FieldOffset(Offset = "0x190")]
	private List<ElementObjectManager> m_ShareCardEoms;

	[Token(Token = "0x400AD2F")]
	[FieldOffset(Offset = "0x198")]
	private UnityAction<CardBaseData> m_OnClickAction;

	[Token(Token = "0x400AD30")]
	[FieldOffset(Offset = "0x1A0")]
	private UnityAction<CardBaseData> m_OnSelectedAction;

	[Token(Token = "0x400AD31")]
	[FieldOffset(Offset = "0x1A8")]
	private UnityAction<CardBaseData> m_OnSelectedKeyL2Action;

	[Token(Token = "0x60061FB")]
	[Address(RVA = "0xA91060", Offset = "0xA90260", VA = "0x180A91060")]
	public void SetOnClickAction(UnityAction<CardBaseData> action)
	{
	}

	[Token(Token = "0x60061FC")]
	[Address(RVA = "0xA91080", Offset = "0xA90280", VA = "0x180A91080")]
	public void SetOnSelectedAction(UnityAction<CardBaseData> action)
	{
	}

	[Token(Token = "0x60061FD")]
	[Address(RVA = "0xA910A0", Offset = "0xA902A0", VA = "0x180A910A0")]
	public void SetOnSelectedKeyL2Action(UnityAction<CardBaseData> action)
	{
	}

	[Token(Token = "0x60061FE")]
	[Address(RVA = "0xA910C0", Offset = "0xA902C0", VA = "0x180A910C0")]
	public DuelLiveWCSWidget(ElementObjectManager eom, List<int> shareCardIDs)
	{
	}

	[Token(Token = "0x60061FF")]
	[Address(RVA = "0xA90A90", Offset = "0xA8FC90", VA = "0x180A90A90")]
	public static void Create(Transform parent, List<int> shareCardIDs, Action<DuelLiveWCSWidget> onCreated)
	{
	}

	[Token(Token = "0x6006200")]
	[Address(RVA = "0xA90BB0", Offset = "0xA8FDB0", VA = "0x180A90BB0")]
	private void InitializeShareCards(List<int> shareCardIDs)
	{
	}
}
