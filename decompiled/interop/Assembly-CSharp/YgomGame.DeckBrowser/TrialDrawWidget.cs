using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using YgomGame.Deck;
using YgomSystem.ElementSystem;
using YgomSystem.UI;
using YgomSystem.UI.InfinityScroll;

namespace YgomGame.DeckBrowser;

[Token(Token = "0x200103C")]
public class TrialDrawWidget : DeckBrowserOptionWidget
{
	[Token(Token = "0x400AD85")]
	private const string k_PrefPath = "Prefabs/UI/DeckBrowser/Optionals/DeckBrowserOptionForTrialDraw";

	[Token(Token = "0x400AD86")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
	private ShortcutKeySetter m_ShortcutSettings;

	[Token(Token = "0x400AD87")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
	private InfinityScrollView m_ScrollView;

	[Token(Token = "0x400AD88")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
	private SelectionButton m_PlusOneDrawButton;

	[Token(Token = "0x400AD89")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
	private List<object> m_DeckCardMrks;

	[Token(Token = "0x400AD8A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
	private List<object> m_DeckCardPremiums;

	[Token(Token = "0x400AD8B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
	private List<CardBaseData> m_DeckList;

	[Token(Token = "0x400AD8C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
	private TextMeshProUGUI m_TextDeckNum;

	[Token(Token = "0x400AD8D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
	private int m_Regulation;

	[Token(Token = "0x400AD8E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
	private List<CardBaseData> m_DeckListForTrialDraw;

	[Token(Token = "0x400AD8F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
	private List<CardBaseData> m_HandListForTrialDraw;

	[Token(Token = "0x400AD90")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1B0")]
	private List<object> m_HandMrks;

	[Token(Token = "0x400AD91")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1B8")]
	private List<object> m_HandPremiums;

	[Token(Token = "0x400AD92")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C0")]
	private CardDetailWidget m_DetailWidget;

	[Token(Token = "0x17000F60")]
	private bool isGamePad
	{
		[Token(Token = "0x6006257")]
		[Address(RVA = "0xA9C790", Offset = "0xA9B990", VA = "0x180A9C790")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000F61")]
	private bool isMobile
	{
		[Token(Token = "0x6006258")]
		[Address(RVA = "0xA9C820", Offset = "0xA9BA20", VA = "0x180A9C820")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6006259")]
	[Address(RVA = "0xA9C3C0", Offset = "0xA9B5C0", VA = "0x180A9C3C0")]
	public TrialDrawWidget(ElementObjectManager eom)
	{
	}

	[Token(Token = "0x600625A")]
	[Address(RVA = "0xA9AF40", Offset = "0xA9A140", VA = "0x180A9AF40")]
	public static void Create(Transform parent, Action<TrialDrawWidget> onCreated)
	{
	}

	[Token(Token = "0x600625B")]
	[Address(RVA = "0xA9B8A0", Offset = "0xA9AAA0", VA = "0x180A9B8A0")]
	public void Init(List<object> mrks, List<object> prems, int regulation, [Optional] CardDetailWidget detailView)
	{
	}

	[Token(Token = "0x600625C")]
	[Address(RVA = "0xA9B370", Offset = "0xA9A570", VA = "0x180A9B370")]
	private void FiveDraw()
	{
	}

	[Token(Token = "0x600625D")]
	[Address(RVA = "0xA9C0E0", Offset = "0xA9B2E0", VA = "0x180A9C0E0")]
	private void PlusOneDraw()
	{
	}

	[Token(Token = "0x600625E")]
	[Address(RVA = "0xA9B030", Offset = "0xA9A230", VA = "0x180A9B030")]
	private void DrawCard()
	{
	}

	[Token(Token = "0x600625F")]
	[Address(RVA = "0xA9BF50", Offset = "0xA9B150", VA = "0x180A9BF50")]
	public void OnItemInitialize(GameObject gob)
	{
	}

	[Token(Token = "0x6006260")]
	[Address(RVA = "0xA9BEF0", Offset = "0xA9B0F0", VA = "0x180A9BEF0")]
	public void OnGsvStanby()
	{
	}

	[Token(Token = "0x6006261")]
	[Address(RVA = "0xA9BFB0", Offset = "0xA9B1B0", VA = "0x180A9BFB0")]
	public void OnItemSetData(GameObject gob, int dataindex)
	{
	}

	[Token(Token = "0x6006262")]
	[Address(RVA = "0xA9C260", Offset = "0xA9B460", VA = "0x180A9C260")]
	public void SetDetailViewCard(int mrk, int premiumId)
	{
	}

	[Token(Token = "0x6006263")]
	[Address(RVA = "0xA9C2D0", Offset = "0xA9B4D0", VA = "0x180A9C2D0")]
	public void SetOnClickDetailViewCard(int idx)
	{
	}

	[Token(Token = "0x6006264")]
	[Address(RVA = "0xA9BC80", Offset = "0xA9AE80", VA = "0x180A9BC80")]
	private void OnCreatedCardCallback(DeckCard deckCard, int idx)
	{
	}
}
