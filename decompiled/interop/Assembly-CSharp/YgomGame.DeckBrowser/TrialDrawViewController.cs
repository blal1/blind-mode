using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using YgomGame.Deck;
using YgomGame.Menu;
using YgomSystem.ElementSystem;
using YgomSystem.UI;
using YgomSystem.UI.InfinityScroll;

namespace YgomGame.DeckBrowser;

[Token(Token = "0x200101A")]
public class TrialDrawViewController : BaseMenuViewController, IBackButtonSupported, IHeaderBorderSupported
{
	[Token(Token = "0x200101E")]
	[CompilerGenerated]
	private sealed class _003CInitializeFiveDraw_003Ed__39 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400ACB6")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400ACB7")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400ACB8")]
		[FieldOffset(Offset = "0x20")]
		public TrialDrawViewController _003C_003E4__this;

		[Token(Token = "0x17000F37")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x600615B")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000F38")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600615D")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6006158")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CInitializeFiveDraw_003Ed__39(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6006159")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x600615A")]
		[Address(RVA = "0xA7D0A0", Offset = "0xA7C2A0", VA = "0x180A7D0A0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600615C")]
		[Address(RVA = "0xA7D250", Offset = "0xA7C450", VA = "0x180A7D250", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x400AC91")]
	[FieldOffset(Offset = "0xD0")]
	private readonly string k_ELabelDetailView;

	[Token(Token = "0x400AC92")]
	[FieldOffset(Offset = "0xD8")]
	private readonly string k_ELabelDetailViewMenuRoot;

	[Token(Token = "0x400AC93")]
	[FieldOffset(Offset = "0xE0")]
	[SerializeField]
	private ElementObjectManager m_UIPrefab;

	[Token(Token = "0x400AC94")]
	[FieldOffset(Offset = "0xE8")]
	[SerializeField]
	private ElementObjectManager m_UIPrefabMobile;

	[Token(Token = "0x400AC95")]
	[FieldOffset(Offset = "0xF0")]
	private ElementObjectManager m_UI;

	[Token(Token = "0x400AC96")]
	[FieldOffset(Offset = "0xF8")]
	private CardDetailWidget m_DetailWidget;

	[Token(Token = "0x400AC97")]
	[FieldOffset(Offset = "0x100")]
	private int m_Regulation;

	[Token(Token = "0x400AC98")]
	private const int thresClose = 5;

	[Token(Token = "0x400AC99")]
	[FieldOffset(Offset = "0x104")]
	private float holdTime;

	[Token(Token = "0x400AC9A")]
	[FieldOffset(Offset = "0x108")]
	private readonly string k_ELabelTrialDraw;

	[Token(Token = "0x400AC9B")]
	[FieldOffset(Offset = "0x110")]
	private readonly string k_ELabelTrialDrawInfinityView;

	[Token(Token = "0x400AC9C")]
	[FieldOffset(Offset = "0x118")]
	private readonly string k_ELabelTextDeckNum;

	[Token(Token = "0x400AC9D")]
	[FieldOffset(Offset = "0x120")]
	private readonly string k_ELabelFiveDrawButton;

	[Token(Token = "0x400AC9E")]
	[FieldOffset(Offset = "0x128")]
	private readonly string k_ELabelPlusOneDrawButton;

	[Token(Token = "0x400AC9F")]
	[FieldOffset(Offset = "0x130")]
	private readonly string k_ELabelRegulationIcon;

	[Token(Token = "0x400ACA0")]
	[FieldOffset(Offset = "0x138")]
	private InfinityScrollView m_TrialDrawInfinityView;

	[Token(Token = "0x400ACA1")]
	[FieldOffset(Offset = "0x140")]
	private SelectionButton m_FiveDrawButton;

	[Token(Token = "0x400ACA2")]
	[FieldOffset(Offset = "0x148")]
	private SelectionButton m_PlusOneDrawButton;

	[Token(Token = "0x400ACA3")]
	[FieldOffset(Offset = "0x150")]
	private Image m_RegulationIcon;

	[Token(Token = "0x400ACA4")]
	[FieldOffset(Offset = "0x158")]
	private List<object> m_DeckCardMrks;

	[Token(Token = "0x400ACA5")]
	[FieldOffset(Offset = "0x160")]
	private List<object> m_DeckCardPremiums;

	[Token(Token = "0x400ACA6")]
	[FieldOffset(Offset = "0x168")]
	private List<CardBaseData> m_DeckList;

	[Token(Token = "0x400ACA7")]
	[FieldOffset(Offset = "0x170")]
	private TextMeshProUGUI m_TextDeckNum;

	[Token(Token = "0x400ACA8")]
	[FieldOffset(Offset = "0x178")]
	private List<CardBaseData> m_DeckListForTrialDraw;

	[Token(Token = "0x400ACA9")]
	[FieldOffset(Offset = "0x180")]
	private List<CardBaseData> m_HandListForTrialDraw;

	[Token(Token = "0x400ACAA")]
	[FieldOffset(Offset = "0x188")]
	private List<object> m_HandMrks;

	[Token(Token = "0x400ACAB")]
	[FieldOffset(Offset = "0x190")]
	private List<object> m_HandPremiums;

	[Token(Token = "0x400ACAC")]
	[FieldOffset(Offset = "0x198")]
	private bool m_RegulationVisible;

	[Token(Token = "0x17000F34")]
	protected override Type[] textIds
	{
		[Token(Token = "0x6006139")]
		[Address(RVA = "0xA7AA40", Offset = "0xA79C40", VA = "0x180A7AA40", Slot = "21")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000F35")]
	public bool isMobile
	{
		[Token(Token = "0x600613B")]
		[Address(RVA = "0xA7A9F0", Offset = "0xA79BF0", VA = "0x180A7A9F0")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000F36")]
	public bool isGamePad
	{
		[Token(Token = "0x600613C")]
		[Address(RVA = "0xA7A960", Offset = "0xA79B60", VA = "0x180A7A960")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x600613A")]
	[Address(RVA = "0xA786C0", Offset = "0xA778C0", VA = "0x180A786C0", Slot = "6")]
	public override void NotificationStackEntry()
	{
	}

	[Token(Token = "0x600613D")]
	[Address(RVA = "0xA79D50", Offset = "0xA78F50", VA = "0x180A79D50")]
	public static void Open(ViewControllerManager vc, Dictionary<string, object> args)
	{
	}

	[Token(Token = "0x600613E")]
	[Address(RVA = "0xA78120", Offset = "0xA77320", VA = "0x180A78120")]
	private void FiveDraw()
	{
	}

	[Token(Token = "0x600613F")]
	[Address(RVA = "0xA7A250", Offset = "0xA79450", VA = "0x180A7A250")]
	private void PlusOneDraw()
	{
	}

	[Token(Token = "0x6006140")]
	[Address(RVA = "0xA77E10", Offset = "0xA77010", VA = "0x180A77E10")]
	private void DrawCard()
	{
	}

	[Token(Token = "0x6006141")]
	[Address(RVA = "0xA78650", Offset = "0xA77850", VA = "0x180A78650")]
	[IteratorStateMachine(typeof(_003CInitializeFiveDraw_003Ed__39))]
	private IEnumerator InitializeFiveDraw()
	{
		return null;
	}

	[Token(Token = "0x6006142")]
	[Address(RVA = "0xA79AC0", Offset = "0xA78CC0", VA = "0x180A79AC0")]
	public void OnItemInitialize(GameObject gob)
	{
	}

	[Token(Token = "0x6006143")]
	[Address(RVA = "0xA79A60", Offset = "0xA78C60", VA = "0x180A79A60")]
	public void OnGsvStanby()
	{
	}

	[Token(Token = "0x6006144")]
	[Address(RVA = "0xA79BE0", Offset = "0xA78DE0", VA = "0x180A79BE0")]
	public void OnItemSetData(GameObject gob, int dataindex)
	{
	}

	[Token(Token = "0x6006145")]
	[Address(RVA = "0xA7A3D0", Offset = "0xA795D0", VA = "0x180A7A3D0")]
	public void SetDetailViewCard(int mrk, int premiumId)
	{
	}

	[Token(Token = "0x6006146")]
	[Address(RVA = "0xA7A580", Offset = "0xA79780", VA = "0x180A7A580")]
	public void SetOnClickDetailViewCard(int idx)
	{
	}

	[Token(Token = "0x6006147")]
	[Address(RVA = "0xA79730", Offset = "0xA78930", VA = "0x180A79730")]
	private void OnCreatedCardCallback(DeckCard deckCard, int idx)
	{
	}

	[Token(Token = "0x6006148")]
	[Address(RVA = "0xA7A680", Offset = "0xA79880", VA = "0x180A7A680")]
	public TrialDrawViewController()
	{
	}
}
