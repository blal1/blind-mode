using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using YgomSystem.ElementSystem;
using YgomSystem.UI;
using YgomSystem.UI.ElementWidget;
using YgomSystem.UI.InfinityScroll;

namespace YgomGame.DuelLive;

[Token(Token = "0x2000F64")]
public class ProductWidget : ElementWidgetBase
{
	[Token(Token = "0x400A7BB")]
	private const string k_TLabelProductRandom = "templateDuelLive";

	[Token(Token = "0x400A7BC")]
	private const string k_TLabelProductVS = "templateVS";

	[Token(Token = "0x400A7BD")]
	private const string k_TLabelProductEvent = "templateEvent";

	[Token(Token = "0x400A7BE")]
	private const string k_TLabelProductOfficialAccount = "templateSpecialAccount";

	[Token(Token = "0x400A7BF")]
	private const string k_TLabelProductCommingSoon = "templateComingSoon";

	[Token(Token = "0x400A7C0")]
	private const string k_TLabelProductVSNew = "templateVSNew";

	[Token(Token = "0x400A7C1")]
	private const string k_TLabelCard_0_0 = "Card_0_0";

	[Token(Token = "0x400A7C2")]
	private const string k_TLabelCard_0_1 = "Card_0_1";

	[Token(Token = "0x400A7C3")]
	private const string k_TLabelCard_0_2 = "Card_0_2";

	[Token(Token = "0x400A7C4")]
	private const string k_TLabelCard_1_0 = "Card_1_0";

	[Token(Token = "0x400A7C5")]
	private const string k_TLabelCard_1_1 = "Card_1_1";

	[Token(Token = "0x400A7C6")]
	private const string k_TLabelCard_1_2 = "Card_1_2";

	[Token(Token = "0x400A7C7")]
	private const string k_TLabelButtonMenu = "ButtonMenu";

	[Token(Token = "0x400A7C8")]
	private const string k_TLabelButtonPlay = "Button";

	[Token(Token = "0x400A7C9")]
	private const string k_TLabelShortcutIcon = "ShortcutIcon0";

	[Token(Token = "0x400A7CA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public int index;

	[Token(Token = "0x400A7CB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public int menuId;

	[Token(Token = "0x400A7CC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public int replayIdx;

	[Token(Token = "0x400A7CD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public long duelLiveId;

	[Token(Token = "0x400A7CE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public int sectionId;

	[Token(Token = "0x400A7CF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public int widgetType;

	[Token(Token = "0x400A7D0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public string name1;

	[Token(Token = "0x400A7D1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public string name2;

	[Token(Token = "0x400A7D2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public int playerIcon1;

	[Token(Token = "0x400A7D3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	public int playerIcon2;

	[Token(Token = "0x400A7D4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public int playerIconFrame1;

	[Token(Token = "0x400A7D5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	public int playerIconFrame2;

	[Token(Token = "0x400A7D6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public int playerDeckCase1;

	[Token(Token = "0x400A7D7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	public int playerDeckCase2;

	[Token(Token = "0x400A7D8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public int winnerId;

	[Token(Token = "0x400A7D9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	public bool isDeckPublic;

	[Token(Token = "0x400A7DA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public SelectionButton buttonProduct;

	[Token(Token = "0x400A7DB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public SelectionButton buttonPlay;

	[Token(Token = "0x400A7DC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public SelectionButton buttonDeck;

	[Token(Token = "0x400A7DD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public ShortcutIcon shortcutIcon;

	[Token(Token = "0x400A7DE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private List<ElementObjectManager> widgetManagers;

	[Token(Token = "0x400A7DF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public List<SelectionButton> widgetButtons;

	[Token(Token = "0x400A7E0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	public Action<ProductWidget> onClickProductWidgetCallback;

	[Token(Token = "0x400A7E1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	public Action<ProductWidget> onSelectedCallback;

	[Token(Token = "0x400A7E2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	public Action<ProductWidget> onClickPlayButtonCallback;

	[Token(Token = "0x400A7E3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	public List<object> mrkList;

	[Token(Token = "0x400A7E4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	public int pcode1;

	[Token(Token = "0x400A7E5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
	public int pcode2;

	[Token(Token = "0x400A7E6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	public int highlightId;

	[Token(Token = "0x400A7E7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
	public int highlightCardMenuId;

	[Token(Token = "0x400A7E8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	private InfinityScrollView ownerIsv;

	[Token(Token = "0x6005D61")]
	[Address(RVA = "0xA47BA0", Offset = "0xA46DA0", VA = "0x180A47BA0")]
	public ProductWidget(ElementObjectManager eom)
	{
	}

	[Token(Token = "0x6005D62")]
	[Address(RVA = "0xA468E0", Offset = "0xA45AE0", VA = "0x180A468E0")]
	public void SetAll(IProductContext productCtx, [Optional] InfinityScrollView ownerISV)
	{
	}

	[Token(Token = "0x6005D63")]
	[Address(RVA = "0xA45EC0", Offset = "0xA450C0", VA = "0x180A45EC0")]
	private void CheckRegistButtonInISV()
	{
	}

	[Token(Token = "0x6005D64")]
	[Address(RVA = "0xA474F0", Offset = "0xA466F0", VA = "0x180A474F0")]
	private void SetViewVS(ElementObjectManager manager, IProductContext productCtx)
	{
	}

	[Token(Token = "0x6005D65")]
	[Address(RVA = "0xA470D0", Offset = "0xA462D0", VA = "0x180A470D0")]
	private void SetViewEvent(ElementObjectManager manager, IProductContext productCtx)
	{
	}

	[Token(Token = "0x6005D66")]
	[Address(RVA = "0xA47430", Offset = "0xA46630", VA = "0x180A47430")]
	private void SetViewOfficialAccount(ElementObjectManager manager, IProductContext productCtx)
	{
	}

	[Token(Token = "0x6005D67")]
	[Address(RVA = "0xA46470", Offset = "0xA45670", VA = "0x180A46470")]
	private void InitNewTemplate(ElementObjectManager manager)
	{
	}

	[Token(Token = "0x6005D68")]
	[Address(RVA = "0xA462D0", Offset = "0xA454D0", VA = "0x180A462D0")]
	private void InitButtonProduct(ElementObjectManager manager)
	{
	}

	[Token(Token = "0x6005D69")]
	[Address(RVA = "0xA47020", Offset = "0xA46220", VA = "0x180A47020")]
	private void SetButtonProduct(ElementObjectManager manager)
	{
	}

	[Token(Token = "0x6005D6A")]
	[Address(RVA = "0xA46750", Offset = "0xA45950", VA = "0x180A46750")]
	protected void OnClickProductWidget()
	{
	}

	[Token(Token = "0x6005D6B")]
	[Address(RVA = "0xA467E0", Offset = "0xA459E0", VA = "0x180A467E0")]
	protected void OnSelected()
	{
	}

	[Token(Token = "0x6005D6C")]
	[Address(RVA = "0xA46770", Offset = "0xA45970", VA = "0x180A46770")]
	protected void OnDeselected()
	{
	}

	[Token(Token = "0x6005D6D")]
	[Address(RVA = "0xA46730", Offset = "0xA45930", VA = "0x180A46730")]
	protected void OnClickPlayButton()
	{
	}
}
