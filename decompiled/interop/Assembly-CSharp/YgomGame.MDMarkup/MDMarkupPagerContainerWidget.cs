using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using YgomSystem.ElementSystem;
using YgomSystem.UI;
using YgomSystem.UI.ElementWidget;

namespace YgomGame.MDMarkup;

[Token(Token = "0x2000CFB")]
public class MDMarkupPagerContainerWidget : ElementWidgetBase, IMDMarkupContainerWidget
{
	[Token(Token = "0x4009D09")]
	[FieldOffset(Offset = "0x20")]
	private readonly string k_ELabelTitleText;

	[Token(Token = "0x4009D0A")]
	[FieldOffset(Offset = "0x28")]
	private readonly string k_ELabelScrollView;

	[Token(Token = "0x4009D0B")]
	[FieldOffset(Offset = "0x30")]
	private readonly string k_ELabelCloseButton;

	[Token(Token = "0x4009D0C")]
	[FieldOffset(Offset = "0x38")]
	private readonly string k_ELabelBackShortcutButton;

	[Token(Token = "0x4009D0D")]
	[FieldOffset(Offset = "0x40")]
	private readonly string k_ELabelFooter;

	[Token(Token = "0x4009D0E")]
	[FieldOffset(Offset = "0x48")]
	private ScrollRect m_ScrollRect;

	[Token(Token = "0x4009D0F")]
	[FieldOffset(Offset = "0x50")]
	private SlidePagerWidget m_SlidePagerWidget;

	[Token(Token = "0x4009D10")]
	[FieldOffset(Offset = "0x58")]
	private MDMarkupGraphWidget m_MarkupGraphWidget;

	[Token(Token = "0x4009D11")]
	[FieldOffset(Offset = "0x60")]
	private MDMarkupPagerContainer m_ContainerData;

	[Token(Token = "0x4009D12")]
	[FieldOffset(Offset = "0x68")]
	private GameObject m_Footer;

	[Token(Token = "0x4009D13")]
	[FieldOffset(Offset = "0x70")]
	private SelectionButton m_CloseButton;

	[Token(Token = "0x4009D14")]
	[FieldOffset(Offset = "0x78")]
	private SelectionButton m_BackShortcutButton;

	[Token(Token = "0x4009D15")]
	[FieldOffset(Offset = "0x80")]
	private List<int> m_FocusedPages;

	[Token(Token = "0x4009D16")]
	[FieldOffset(Offset = "0x88")]
	public bool titleVisible;

	[Token(Token = "0x4009D17")]
	[FieldOffset(Offset = "0x8C")]
	public MDMarkupDef.CloseButtonType closeButtonType;

	[Token(Token = "0x17000B16")]
	public MDMarkupGraphWidget markupGraph
	{
		[Token(Token = "0x6004E59")]
		[Address(RVA = "0x5EA220", Offset = "0x5E9420", VA = "0x1805EA220")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x14000070")]
	public event Action onClickCloseEvent
	{
		[Token(Token = "0x6004E5A")]
		[Address(RVA = "0x958190", Offset = "0x957390", VA = "0x180958190")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x6004E5B")]
		[Address(RVA = "0x958240", Offset = "0x957440", VA = "0x180958240")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x6004E5C")]
	[Address(RVA = "0x3EF020", Offset = "0x3EE220", VA = "0x1803EF020", Slot = "13")]
	public GameObject FindById(string id)
	{
		return null;
	}

	[Token(Token = "0x6004E5D")]
	[Address(RVA = "0x957D30", Offset = "0x956F30", VA = "0x180957D30")]
	public MDMarkupPagerContainerWidget(ElementObjectManager eom)
	{
	}

	[Token(Token = "0x6004E5E")]
	[Address(RVA = "0x956D90", Offset = "0x955F90", VA = "0x180956D90", Slot = "10")]
	public void Initialize(IMDMarkupContainer containerData)
	{
	}

	[Token(Token = "0x6004E5F")]
	[Address(RVA = "0x957950", Offset = "0x956B50", VA = "0x180957950", Slot = "11")]
	public void Output(MDMarkupGraphFactory graphFactory, Action onComplete)
	{
	}

	[Token(Token = "0x6004E60")]
	[Address(RVA = "0x957660", Offset = "0x956860", VA = "0x180957660", Slot = "12")]
	public void OnStart(Dictionary<string, object> args)
	{
	}

	[Token(Token = "0x6004E61")]
	[Address(RVA = "0x956F20", Offset = "0x956120", VA = "0x180956F20")]
	private void OnGraphOutputComplete(MDMarkupGraphWidget graphWidget)
	{
	}

	[Token(Token = "0x6004E62")]
	[Address(RVA = "0x957160", Offset = "0x956360", VA = "0x180957160")]
	private void OnPageChanged()
	{
	}
}
