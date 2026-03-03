using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using YgomSystem.ElementSystem;
using YgomSystem.UI.ElementWidget;

namespace YgomGame.MDMarkup;

[Token(Token = "0x2000D0C")]
public class MDMarkupTabsContainerWidget : ElementWidgetBase, IMDMarkupContainerWidget
{
	[Token(Token = "0x4009D6A")]
	[FieldOffset(Offset = "0x20")]
	private readonly string k_ELabelTitleText;

	[Token(Token = "0x4009D6B")]
	[FieldOffset(Offset = "0x28")]
	private readonly string k_ELabelScrollViewTemplate;

	[Token(Token = "0x4009D6C")]
	[FieldOffset(Offset = "0x30")]
	private readonly string k_ELabelTabGroup;

	[Token(Token = "0x4009D6D")]
	[FieldOffset(Offset = "0x38")]
	private readonly string k_ELabelTabTemplate;

	[Token(Token = "0x4009D6E")]
	[FieldOffset(Offset = "0x40")]
	private readonly string k_ELabelTabOnLabel;

	[Token(Token = "0x4009D6F")]
	[FieldOffset(Offset = "0x48")]
	private readonly string k_ELabelTabOffLabel;

	[Token(Token = "0x4009D70")]
	[FieldOffset(Offset = "0x50")]
	private ScrollRect[] m_ScrollRects;

	[Token(Token = "0x4009D71")]
	[FieldOffset(Offset = "0x58")]
	private MDMarkupGraphWidget[] m_MarkupGraphs;

	[Token(Token = "0x4009D72")]
	[FieldOffset(Offset = "0x60")]
	private DirectionalTabGroup m_TabGroup;

	[Token(Token = "0x4009D73")]
	[FieldOffset(Offset = "0x68")]
	private MDMarkupTabsContainer m_ContainerData;

	[Token(Token = "0x4009D74")]
	[FieldOffset(Offset = "0x70")]
	private MDMarkupGraphFactory m_GraphFactory;

	[Token(Token = "0x6004EEA")]
	[Address(RVA = "0x3EF020", Offset = "0x3EE220", VA = "0x1803EF020", Slot = "13")]
	public GameObject FindById(string id)
	{
		return null;
	}

	[Token(Token = "0x6004EEB")]
	[Address(RVA = "0x974CF0", Offset = "0x973EF0", VA = "0x180974CF0")]
	public MDMarkupTabsContainerWidget(ElementObjectManager eom)
	{
	}

	[Token(Token = "0x6004EEC")]
	[Address(RVA = "0x973C00", Offset = "0x972E00", VA = "0x180973C00", Slot = "10")]
	public void Initialize(IMDMarkupContainer containerData)
	{
	}

	[Token(Token = "0x6004EED")]
	[Address(RVA = "0x974500", Offset = "0x973700", VA = "0x180974500", Slot = "11")]
	public void Output(MDMarkupGraphFactory graphFactory, Action onComplete)
	{
	}

	[Token(Token = "0x6004EEE")]
	[Address(RVA = "0x974120", Offset = "0x973320", VA = "0x180974120")]
	private void OutputGraph(int idx, Action onComplete)
	{
	}

	[Token(Token = "0x6004EEF")]
	[Address(RVA = "0x973A50", Offset = "0x972C50", VA = "0x180973A50")]
	private void InitSelectionItemsAtIdx(int idx)
	{
	}

	[Token(Token = "0x6004EF0")]
	[Address(RVA = "0x973F70", Offset = "0x973170", VA = "0x180973F70", Slot = "12")]
	public void OnStart(Dictionary<string, object> args)
	{
	}

	[Token(Token = "0x6004EF1")]
	[Address(RVA = "0x973CD0", Offset = "0x972ED0", VA = "0x180973CD0")]
	private void OnChangeIdx(int newIdx)
	{
	}
}
