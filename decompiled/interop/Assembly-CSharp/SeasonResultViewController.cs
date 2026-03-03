using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using YgomGame.Menu;
using YgomSystem.ElementSystem;
using YgomSystem.UI;
using YgomSystem.UI.FreeScroll;
using YgomSystem.UI.MultiVCTab;

[Token(Token = "0x2000087")]
public class SeasonResultViewController : MultiVCTabBaseViewController, IMultiVCTabSupport, IBackButtonSupported, IHeaderBorderSupported
{
	[Token(Token = "0x2000088")]
	private enum ResultType
	{
		[Token(Token = "0x40002CF")]
		WCSfinal,
		[Token(Token = "0x40002D0")]
		WCS,
		[Token(Token = "0x40002D1")]
		Cup,
		[Token(Token = "0x40002D2")]
		SeasonPoint,
		[Token(Token = "0x40002D3")]
		RateDuel
	}

	[Token(Token = "0x40002AF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	private string Label_Main;

	[Token(Token = "0x40002B0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	private string Label_ScrollView;

	[Token(Token = "0x40002B1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
	private string Label_TitleText;

	[Token(Token = "0x40002B2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
	private string Label_ButtonArea;

	[Token(Token = "0x40002B3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
	private string Label_ButtonTemplate;

	[Token(Token = "0x40002B4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
	private string Label_text;

	[Token(Token = "0x40002B5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
	private string Label_TextNotice;

	[Token(Token = "0x40002B6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
	private string Label_TextDate;

	[Token(Token = "0x40002B7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
	private string Label_EventLogo;

	[Token(Token = "0x40002B8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
	private string Label_ButtonGroup;

	[Token(Token = "0x40002B9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
	private string Label_ButtonDetail;

	[Token(Token = "0x40002BA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
	private readonly string WCSfinal_ICON_PATH;

	[Token(Token = "0x40002BB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
	private readonly string WCS_ICON_PATH;

	[Token(Token = "0x40002BC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
	private readonly string SEASONPOINT_ICON_PATH;

	[Token(Token = "0x40002BD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
	private string Label_WCSTemplate;

	[Token(Token = "0x40002BE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
	private string Label_WCSpreTemplate;

	[Token(Token = "0x40002BF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
	private string Label_CupTemplate;

	[Token(Token = "0x40002C0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
	private string Label_SeasonPointTemplate;

	[Token(Token = "0x40002C1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
	private int seasonId;

	[Token(Token = "0x40002C2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
	private string startDate;

	[Token(Token = "0x40002C3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
	private string endDate;

	[Token(Token = "0x40002C4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
	private CurrentMultiVCTabData argsData;

	[Token(Token = "0x40002C5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
	private FreeScrollView m_FreeScrollView;

	[Token(Token = "0x40002C6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
	private ScrollRect m_ScrollRect;

	[Token(Token = "0x40002C7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1B0")]
	private GameObject m_Content;

	[Token(Token = "0x40002C8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1B8")]
	private GameObject m_ContentArea;

	[Token(Token = "0x40002C9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C0")]
	private GameObject m_ContentGroup;

	[Token(Token = "0x40002CA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C8")]
	private Dictionary<ResultType, ElementObjectManager> templateMap;

	[Token(Token = "0x40002CB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1D0")]
	private List<int> cupMonthList;

	[Token(Token = "0x40002CC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1D8")]
	private List<SelectionItem> leftButtonList;

	[Token(Token = "0x40002CD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1E0")]
	private List<SelectionItem> instanceButtonList;

	[Token(Token = "0x17000045")]
	protected override Type[] textIds
	{
		[Token(Token = "0x600029A")]
		[Address(RVA = "0x3FB2D0", Offset = "0x3FA4D0", VA = "0x1803FB2D0", Slot = "21")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600029B")]
	[Address(RVA = "0x3FA5D0", Offset = "0x3F97D0", VA = "0x1803FA5D0", Slot = "6")]
	public override void NotificationStackEntry()
	{
	}

	[Token(Token = "0x600029C")]
	[Address(RVA = "0x3FA5F0", Offset = "0x3F97F0", VA = "0x1803FA5F0", Slot = "23")]
	protected override void OnCreatedView()
	{
	}

	[Token(Token = "0x600029D")]
	[Address(RVA = "0x3FA6C0", Offset = "0x3F98C0", VA = "0x1803FA6C0", Slot = "28")]
	public override void OnTabChangedAction()
	{
	}

	[Token(Token = "0x600029E")]
	[Address(RVA = "0x3F8420", Offset = "0x3F7620", VA = "0x1803F8420")]
	private void CallAPI(Action onSuccess)
	{
	}

	[Token(Token = "0x600029F")]
	[Address(RVA = "0x3F85C0", Offset = "0x3F77C0", VA = "0x1803F85C0")]
	private void InitData([Optional] Action onComplted)
	{
	}

	[Token(Token = "0x60002A0")]
	[Address(RVA = "0x3FA790", Offset = "0x3F9990", VA = "0x1803FA790")]
	private void Start()
	{
	}

	[Token(Token = "0x60002A1")]
	[Address(RVA = "0x3F9690", Offset = "0x3F8890", VA = "0x1803F9690")]
	private void InitFreeScroll()
	{
	}

	[Token(Token = "0x60002A2")]
	[Address(RVA = "0x3FB230", Offset = "0x3FA430", VA = "0x1803FB230")]
	private bool customRightTransition(bool isInitialize)
	{
		return default(bool);
	}

	[Token(Token = "0x60002A3")]
	[Address(RVA = "0x3F8520", Offset = "0x3F7720", VA = "0x1803F8520")]
	private bool CustomTransition(SelectionItem selectedItem, PadInputDirection direction, Vector2 dir, bool byAnalog)
	{
		return default(bool);
	}

	[Token(Token = "0x60002A4")]
	[Address(RVA = "0x3F9990", Offset = "0x3F8B90", VA = "0x1803F9990")]
	private void InstantiateButton(ElementObjectManager parent, int count, ResultType resultType)
	{
	}

	[Token(Token = "0x60002A5")]
	[Address(RVA = "0x3FAD70", Offset = "0x3F9F70", VA = "0x1803FAD70")]
	public SeasonResultViewController()
	{
	}
}
