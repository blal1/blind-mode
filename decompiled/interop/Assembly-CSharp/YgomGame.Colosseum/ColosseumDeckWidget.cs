using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine.Events;
using YgomGame.Menu.Common;
using YgomSystem.ElementSystem;
using YgomSystem.UI;
using YgomSystem.UI.ElementWidget;
using YgomSystem.UI.PropertyOverrider;

namespace YgomGame.Colosseum;

[Token(Token = "0x2001BC4")]
public class ColosseumDeckWidget : ElementWidgetBehaviourBase<ColosseumDeckWidget>
{
	[Token(Token = "0x2001BC5")]
	public class ButtonInfo
	{
		[Token(Token = "0x400FB51")]
		[FieldOffset(Offset = "0x10")]
		public bool isSetDeck;

		[Token(Token = "0x400FB52")]
		[FieldOffset(Offset = "0x11")]
		public bool cantUseDeck;

		[Token(Token = "0x400FB53")]
		[FieldOffset(Offset = "0x12")]
		public bool duelInteractable;

		[Token(Token = "0x400FB54")]
		[FieldOffset(Offset = "0x18")]
		public string duelLabel;

		[Token(Token = "0x400FB55")]
		[FieldOffset(Offset = "0x20")]
		public string deckLabel;

		[Token(Token = "0x400FB56")]
		[FieldOffset(Offset = "0x28")]
		public string tabLabel;

		[Token(Token = "0x400FB57")]
		[FieldOffset(Offset = "0x30")]
		public int rentalState;

		[Token(Token = "0x400FB58")]
		[FieldOffset(Offset = "0x38")]
		public ColosseumDeckManager deckManager;

		[Token(Token = "0x400FB59")]
		[FieldOffset(Offset = "0x40")]
		public UnityAction onClickDeck;

		[Token(Token = "0x400FB5A")]
		[FieldOffset(Offset = "0x48")]
		public UnityAction onClickDuel;

		[Token(Token = "0x400FB5B")]
		[FieldOffset(Offset = "0x50")]
		public UnityAction onClickDuelInactive;

		[Token(Token = "0x600B4CB")]
		[Address(RVA = "0x4B6BB0", Offset = "0x4B5DB0", VA = "0x1804B6BB0")]
		public ButtonInfo(ColosseumPathManager pathManager, bool isSetDeck, bool cantUseDeck, bool duelInteractable, string duelLabel, string deckLabel, string tabLabel, int rentalState = 0)
		{
		}

		[Token(Token = "0x600B4CC")]
		[Address(RVA = "0x4B6B10", Offset = "0x4B5D10", VA = "0x1804B6B10")]
		public ButtonInfo(ColosseumDeckManager deckManager, bool isSetDeck, bool cantUseDeck, bool duelInteractable, string duelLabel, string deckLabel, string tabLabel, int rentalState = 0)
		{
		}
	}

	[Token(Token = "0x2001BC6")]
	public class ButtonInfoEntry : ButtonInfo
	{
		[Token(Token = "0x400FB5C")]
		[FieldOffset(Offset = "0x58")]
		public readonly string E_ButtonEntry;

		[Token(Token = "0x400FB5D")]
		[FieldOffset(Offset = "0x60")]
		public readonly string E_TextEntry;

		[Token(Token = "0x400FB5E")]
		[FieldOffset(Offset = "0x68")]
		public bool isDispEntry;

		[Token(Token = "0x400FB5F")]
		[FieldOffset(Offset = "0x70")]
		public UnityAction onClickEntry;

		[Token(Token = "0x400FB60")]
		[FieldOffset(Offset = "0x78")]
		public string entryLabel;

		[Token(Token = "0x600B4CD")]
		[Address(RVA = "0x4B69D0", Offset = "0x4B5BD0", VA = "0x1804B69D0")]
		public ButtonInfoEntry(ColosseumPathManager pathManager, bool isSetDeck, bool cantUseDeck, bool duelInteractable, string duelLabel, string deckLabel, string tabLabel, int rentalState = 0)
		{
		}
	}

	[Token(Token = "0x2001BC7")]
	public class ColosseumDeck
	{
		[Token(Token = "0x400FB61")]
		[FieldOffset(Offset = "0x10")]
		public ButtonInfo buttonInfo;

		[Token(Token = "0x400FB62")]
		[FieldOffset(Offset = "0x18")]
		public ElementObjectManager tabEom;

		[Token(Token = "0x400FB63")]
		[FieldOffset(Offset = "0x20")]
		public ElementObjectManager btnEom;

		[Token(Token = "0x400FB64")]
		[FieldOffset(Offset = "0x28")]
		private DeckCaseWidget deckCase;

		[Token(Token = "0x600B4CE")]
		[Address(RVA = "0x4BDA60", Offset = "0x4BCC60", VA = "0x1804BDA60")]
		public ColosseumDeck(ButtonInfo buttonInfo, ElementObjectManager tabEom, ElementObjectManager btnEom)
		{
		}

		[Token(Token = "0x600B4CF")]
		[Address(RVA = "0x4BD200", Offset = "0x4BC400", VA = "0x1804BD200")]
		public void UpdateDisp()
		{
		}

		[Token(Token = "0x600B4D0")]
		[Address(RVA = "0x4BD150", Offset = "0x4BC350", VA = "0x1804BD150")]
		public void SelectDeckButton()
		{
		}
	}

	[Token(Token = "0x400FB3D")]
	private const string E_TabGroup = "TabGroup";

	[Token(Token = "0x400FB3E")]
	private const string E_IconL = "IconL";

	[Token(Token = "0x400FB3F")]
	private const string E_IconR = "IconR";

	[Token(Token = "0x400FB40")]
	private const string E_TemplateTab = "TemplateTab";

	[Token(Token = "0x400FB41")]
	private const string E_TextOff = "TextOff";

	[Token(Token = "0x400FB42")]
	private const string E_TextOn = "TextOn";

	[Token(Token = "0x400FB43")]
	public const string E_TemplateDeckButton = "TemplateDeckButton";

	[Token(Token = "0x400FB44")]
	public const string E_ButtonDeck = "ButtonDeck";

	[Token(Token = "0x400FB45")]
	public const string E_ButtonPlay = "ButtonPlay";

	[Token(Token = "0x400FB46")]
	public const string E_ImageDeck = "ImageDeck";

	[Token(Token = "0x400FB47")]
	public const string E_ImageDeckBg = "ImageDeckBg";

	[Token(Token = "0x400FB48")]
	public const string E_ImageDeckDisabled = "ImageDeckDisabled";

	[Token(Token = "0x400FB49")]
	public const string E_ImageDeckEmpty = "ImageDeckEmpty";

	[Token(Token = "0x400FB4A")]
	public const string E_TextDeck = "TextDeck";

	[Token(Token = "0x400FB4B")]
	public const string E_TextPlay = "TextPlay";

	[Token(Token = "0x400FB4C")]
	public const string E_TextLimit = "TextLimit";

	[Token(Token = "0x400FB4D")]
	private const string E_ImageBack = "ImageBack";

	[Token(Token = "0x400FB4E")]
	[FieldOffset(Offset = "0x28")]
	private DirectionalToggleGroupWidget toggleGroup;

	[Token(Token = "0x400FB4F")]
	[FieldOffset(Offset = "0x30")]
	private List<ColosseumDeck> colosseumDecks;

	[Token(Token = "0x400FB50")]
	[FieldOffset(Offset = "0x38")]
	private PlatformOverriderGroup m_OverriderGroup;

	[Token(Token = "0x600B4C0")]
	[Address(RVA = "0x4BC140", Offset = "0x4BB340", VA = "0x1804BC140")]
	public static ColosseumDeckWidget Create(ElementObjectManager eom)
	{
		return null;
	}

	[Token(Token = "0x600B4C1")]
	[Address(RVA = "0x4BC0F0", Offset = "0x4BB2F0", VA = "0x1804BC0F0", Slot = "4")]
	protected override void CollectComponents()
	{
	}

	[Token(Token = "0x600B4C2")]
	[Address(RVA = "0x4BC180", Offset = "0x4BB380", VA = "0x1804BC180")]
	public void Initialize(Selector parentSelector, List<ButtonInfo> buttonInfos)
	{
	}

	[Token(Token = "0x600B4C3")]
	[Address(RVA = "0x4BBE90", Offset = "0x4BB090", VA = "0x1804BBE90")]
	public void ClearColosseumDecks()
	{
	}

	[Token(Token = "0x600B4C4")]
	[Address(RVA = "0x4BCF40", Offset = "0x4BC140", VA = "0x1804BCF40")]
	public void UpdateDisp(List<ButtonInfo> buttonInfos)
	{
	}

	[Token(Token = "0x600B4C5")]
	[Address(RVA = "0x4BCC00", Offset = "0x4BBE00", VA = "0x1804BCC00")]
	public void SelectDeckButton()
	{
	}

	[Token(Token = "0x600B4C6")]
	[Address(RVA = "0x4BCD70", Offset = "0x4BBF70", VA = "0x1804BCD70")]
	private void SetShortcutLRDeck(bool isSet)
	{
	}

	[Token(Token = "0x600B4C7")]
	[Address(RVA = "0x4BCB40", Offset = "0x4BBD40", VA = "0x1804BCB40")]
	public bool IsSetDeck(int index, bool defaultValue = false)
	{
		return default(bool);
	}

	[Token(Token = "0x600B4C8")]
	[Address(RVA = "0x4BCBD0", Offset = "0x4BBDD0", VA = "0x1804BCBD0")]
	public void MoveIdxToggle(int index)
	{
	}

	[Token(Token = "0x600B4C9")]
	[Address(RVA = "0x402CE0", Offset = "0x401EE0", VA = "0x180402CE0")]
	public List<ColosseumDeck> GetColosseumDecks()
	{
		return null;
	}

	[Token(Token = "0x600B4CA")]
	[Address(RVA = "0x4BD110", Offset = "0x4BC310", VA = "0x1804BD110")]
	public ColosseumDeckWidget()
	{
	}
}
