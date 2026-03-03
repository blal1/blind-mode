using System.Collections.Generic;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using YgomGame.Deck;
using YgomSystem.ElementSystem;
using YgomSystem.UI.ElementWidget;
using YgomSystem.UI.InfinityScroll;

namespace YgomGame.DeckBrowser;

[Token(Token = "0x2001028")]
public class DeckViewWidget : ElementWidgetBehaviourBase<DeckViewWidget>
{
	[Token(Token = "0x400AD0E")]
	private const string k_ELabelDeckNameText = "HeaderArea/TextDeckNameTMP";

	[Token(Token = "0x400AD0F")]
	private const string k_ELabelTemplate = "MainDeckView/template";

	[Token(Token = "0x400AD10")]
	private const string k_ELabelMainDeckContent = "MainDeckView/MainDeckContent";

	[Token(Token = "0x400AD11")]
	private const string k_ELabelMainDeckNumText = "MainDeckView/TextMainDeckCardNum";

	[Token(Token = "0x400AD12")]
	private const string k_ELabelExtraDeckContent = "ExDeckView/ExDeckContent";

	[Token(Token = "0x400AD13")]
	private const string k_ELabelExtraDeckNumText = "ExDeckView/TextExDeckCardNum";

	[Token(Token = "0x400AD14")]
	private const string k_ELabelTemplateParent = "MainDeckView/TemplateParent";

	[Token(Token = "0x400AD15")]
	private const string k_ELabelLoadingIcon = "Loading";

	[Token(Token = "0x400AD16")]
	[FieldOffset(Offset = "0x28")]
	private TMP_Text m_DeckNameText;

	[Token(Token = "0x400AD17")]
	[FieldOffset(Offset = "0x30")]
	private DeckCardWidget m_Template;

	[Token(Token = "0x400AD18")]
	[FieldOffset(Offset = "0x38")]
	private RectTransform m_MainDeckContent;

	[Token(Token = "0x400AD19")]
	[FieldOffset(Offset = "0x40")]
	private TextMeshProUGUI m_MainDeckNumText;

	[Token(Token = "0x400AD1A")]
	[FieldOffset(Offset = "0x48")]
	private RectTransform m_ExtraDeckContent;

	[Token(Token = "0x400AD1B")]
	[FieldOffset(Offset = "0x50")]
	private TextMeshProUGUI m_ExtraDeckNumText;

	[Token(Token = "0x400AD1C")]
	[FieldOffset(Offset = "0x58")]
	private List<DeckCardWidget> m_MainDeckWidgets;

	[Token(Token = "0x400AD1D")]
	[FieldOffset(Offset = "0x60")]
	private List<DeckCardWidget> m_ExtraDeckWidgets;

	[Token(Token = "0x400AD1E")]
	[FieldOffset(Offset = "0x68")]
	private Transform m_TemplateParent;

	[Token(Token = "0x400AD1F")]
	[FieldOffset(Offset = "0x70")]
	private GameObject m_LoadingIcon;

	[Token(Token = "0x400AD20")]
	[FieldOffset(Offset = "0x78")]
	private GridLayoutGroup m_MainGridLayoutGroup;

	[Token(Token = "0x400AD21")]
	private const int CARDGROUP_ROW_MAX = 7;

	[Token(Token = "0x400AD22")]
	[FieldOffset(Offset = "0x80")]
	private InfinityScrollView m_InfinityScroll;

	[Token(Token = "0x400AD23")]
	[FieldOffset(Offset = "0x88")]
	private List<int> templateList;

	[Token(Token = "0x400AD24")]
	[FieldOffset(Offset = "0x90")]
	private bool m_IsMobile;

	[Token(Token = "0x17000F53")]
	public TMP_Text deckNameText
	{
		[Token(Token = "0x60061E6")]
		[Address(RVA = "0x4030F0", Offset = "0x4022F0", VA = "0x1804030F0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000F54")]
	public TextMeshProUGUI mainDeckNumText
	{
		[Token(Token = "0x60061E7")]
		[Address(RVA = "0x404850", Offset = "0x403A50", VA = "0x180404850")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000F55")]
	public TextMeshProUGUI extraDeckNumText
	{
		[Token(Token = "0x60061E8")]
		[Address(RVA = "0x580700", Offset = "0x57F900", VA = "0x180580700")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000F56")]
	public IReadOnlyList<DeckCardWidget> mainDeckWidgets
	{
		[Token(Token = "0x60061E9")]
		[Address(RVA = "0x5EA220", Offset = "0x5E9420", VA = "0x1805EA220")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000F57")]
	public IReadOnlyList<DeckCardWidget> extraDeckWidgets
	{
		[Token(Token = "0x60061EA")]
		[Address(RVA = "0x589E50", Offset = "0x589050", VA = "0x180589E50")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60061EB")]
	[Address(RVA = "0xA77410", Offset = "0xA76610", VA = "0x180A77410")]
	public static DeckViewWidget Create(ElementObjectManager eom, bool isMobile, int numDecks = 40, int numExDecks = 15)
	{
		return null;
	}

	[Token(Token = "0x60061EC")]
	[Address(RVA = "0xA77230", Offset = "0xA76430", VA = "0x180A77230")]
	public DeckCardWidget AddToMainDeckByID(int id, int prem = 1, bool isRental = false)
	{
		return null;
	}

	[Token(Token = "0x60061ED")]
	[Address(RVA = "0xA77050", Offset = "0xA76250", VA = "0x180A77050")]
	public DeckCardWidget AddToExtraDeckByID(int id, int prem = 1, bool isRental = false)
	{
		return null;
	}

	[Token(Token = "0x60061EE")]
	[Address(RVA = "0xA77320", Offset = "0xA76520", VA = "0x180A77320")]
	public DeckCardWidget AddToMainDeckMobile(DeckCard deckCard)
	{
		return null;
	}

	[Token(Token = "0x60061EF")]
	[Address(RVA = "0xA77140", Offset = "0xA76340", VA = "0x180A77140")]
	public DeckCardWidget AddToExtraDeckMobile(DeckCard deckCard)
	{
		return null;
	}

	[Token(Token = "0x60061F0")]
	[Address(RVA = "0xA76F30", Offset = "0xA76130", VA = "0x180A76F30")]
	private DeckCardWidget AddCard(Transform parent, int id, int prem = 1, bool isRental = false)
	{
		return null;
	}

	[Token(Token = "0x60061F1")]
	[Address(RVA = "0xA777E0", Offset = "0xA769E0", VA = "0x180A777E0")]
	public void DispLoadingIcon(bool isLoading)
	{
	}

	[Token(Token = "0x60061F2")]
	[Address(RVA = "0xA779E0", Offset = "0xA76BE0", VA = "0x180A779E0")]
	public void SortInDeckCard()
	{
	}

	[Token(Token = "0x60061F3")]
	[Address(RVA = "0xA77800", Offset = "0xA76A00", VA = "0x180A77800")]
	private void InitializeInfinityScroll()
	{
	}

	[Token(Token = "0x60061F4")]
	[Address(RVA = "0xA779B0", Offset = "0xA76BB0", VA = "0x180A779B0")]
	public void OnItemInitialize(GameObject gob)
	{
	}

	[Token(Token = "0x60061F5")]
	[Address(RVA = "0xA77950", Offset = "0xA76B50", VA = "0x180A77950")]
	public void OnGsvStanby()
	{
	}

	[Token(Token = "0x60061F6")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60")]
	public void OnItemSetData(GameObject gob, int dataindex)
	{
	}

	[Token(Token = "0x60061F7")]
	[Address(RVA = "0xA77D50", Offset = "0xA76F50", VA = "0x180A77D50")]
	public DeckViewWidget()
	{
	}
}
