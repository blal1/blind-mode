using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using YgomGame.Duel;
using YgomGame.Menu.Common;
using YgomSystem.ElementSystem;
using YgomSystem.UI;

namespace YgomGame.Colosseum;

[Token(Token = "0x2001BBF")]
public class ColosseumDeckManager
{
	[Token(Token = "0x400FB2A")]
	[FieldOffset(Offset = "0x10")]
	public ColosseumPathManager pm;

	[Token(Token = "0x600B4A6")]
	[Address(RVA = "0x4BBD50", Offset = "0x4BAF50", VA = "0x1804BBD50")]
	public ColosseumDeckManager(ColosseumUtil.PlayMode playMode, int identifier = 0)
	{
	}

	[Token(Token = "0x600B4A7")]
	[Address(RVA = "0x4BBDE0", Offset = "0x4BAFE0", VA = "0x1804BBDE0")]
	public ColosseumDeckManager(ColosseumUtil.PlayMode playMode, bool isRental, int identifier = 0)
	{
	}

	[Token(Token = "0x600B4A8")]
	[Address(RVA = "0x438FD0", Offset = "0x4381D0", VA = "0x180438FD0")]
	public ColosseumDeckManager(ColosseumPathManager pathManager)
	{
	}

	[Token(Token = "0x600B4A9")]
	[Address(RVA = "0x4BB5B0", Offset = "0x4BA7B0", VA = "0x1804BB5B0")]
	public DeckCaseWidget SetDeckCase(Dictionary<string, object> deckDic, DeckCaseWidget deckCase, Transform parent)
	{
		return null;
	}

	[Token(Token = "0x600B4AA")]
	[Address(RVA = "0x4BAF70", Offset = "0x4BA170", VA = "0x1804BAF70")]
	public void OnClickDeck(bool isSetDeck, ViewControllerManager manager, int id, int logoId, int logoBgId, ElementObjectManager overviewEOM, Action<int, bool> openDeckEditCallback, DeckSelectViewController2.DeckEventType deckEventType, bool isFixedAccessories, int stage = 0, string deckSelectBgmLabel = "")
	{
	}

	[Token(Token = "0x600B4AB")]
	[Address(RVA = "0x4B9880", Offset = "0x4B8A80", VA = "0x1804B9880")]
	public GameObject CreateEmbedObj(int logoId, int logoBgId, ElementObjectManager overviewEOM, int stage, string deckName = "")
	{
		return null;
	}

	[Token(Token = "0x600B4AC")]
	[Address(RVA = "0x4BA990", Offset = "0x4B9B90", VA = "0x1804BA990")]
	public void OnClickDeck_Rank(ViewControllerManager manager, Util.GameMode mode, int deckId, bool isSetDeck, ElementObjectManager overViewEOM, Action<int, bool> openDeckEditCallback)
	{
	}

	[Token(Token = "0x600B4AD")]
	[Address(RVA = "0x4B9110", Offset = "0x4B8310", VA = "0x1804B9110")]
	private GameObject CreateEmbedObj_Rank(int deckId, ElementObjectManager overviewEOM)
	{
		return null;
	}

	[Token(Token = "0x600B4AE")]
	[Address(RVA = "0x4BA310", Offset = "0x4B9510", VA = "0x1804BA310")]
	public Dictionary<string, object> GetDeckList(int rentalState = 0)
	{
		return null;
	}

	[Token(Token = "0x600B4AF")]
	[Address(RVA = "0x4BA2A0", Offset = "0x4B94A0", VA = "0x1804BA2A0")]
	private Dictionary<string, object> GetDeckAccessory()
	{
		return null;
	}

	[Token(Token = "0x600B4B0")]
	[Address(RVA = "0x4BA730", Offset = "0x4B9930", VA = "0x1804BA730")]
	private int[] GetDeckPickUpCardIDs()
	{
		return null;
	}

	[Token(Token = "0x600B4B1")]
	[Address(RVA = "0x4BA4D0", Offset = "0x4B96D0", VA = "0x1804BA4D0")]
	private int[] GetDeckPickUpCardDecorations()
	{
		return null;
	}

	[Token(Token = "0x600B4B2")]
	[Address(RVA = "0x4BA3E0", Offset = "0x4B95E0", VA = "0x1804BA3E0")]
	private string GetDeckNameTextID()
	{
		return null;
	}
}
