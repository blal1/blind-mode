using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using YgomSystem.ElementSystem;
using YgomSystem.UI;
using YgomSystem.UI.ElementWidget;

namespace YgomGame.DuelLive;

[Token(Token = "0x2000F65")]
public class SubTabListWidget : ElementWidgetBase
{
	[Token(Token = "0x2000F66")]
	public class TabContext
	{
		[Token(Token = "0x400A7F5")]
		[FieldOffset(Offset = "0x10")]
		public IDuelLiveProductGruopData groupData;

		[Token(Token = "0x400A7F6")]
		[FieldOffset(Offset = "0x18")]
		public string label;

		[Token(Token = "0x400A7F7")]
		[FieldOffset(Offset = "0x20")]
		public string param;

		[Token(Token = "0x400A7F8")]
		[FieldOffset(Offset = "0x28")]
		public bool badge;

		[Token(Token = "0x400A7F9")]
		[FieldOffset(Offset = "0x30")]
		public List<TabContext> children;

		[Token(Token = "0x17000EBC")]
		public bool hasChildren
		{
			[Token(Token = "0x6005D7C")]
			[Address(RVA = "0xA49940", Offset = "0xA48B40", VA = "0x180A49940")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6005D7D")]
		[Address(RVA = "0xA49870", Offset = "0xA48A70", VA = "0x180A49870")]
		public TabContext(IDuelLiveProductGruopData groupData, string label, string param)
		{
		}

		[Token(Token = "0x6005D7E")]
		[Address(RVA = "0xA49740", Offset = "0xA48940", VA = "0x180A49740")]
		public TabContext(IDuelLiveProductGruopData setting, string label, string param, List<TabContext> children)
		{
		}
	}

	[Token(Token = "0x400A7E9")]
	[FieldOffset(Offset = "0x20")]
	private AccordionTabGroupWidget m_AccordionTab;

	[Token(Token = "0x400A7EA")]
	internal const int k_TemplateId_Single = 0;

	[Token(Token = "0x400A7EB")]
	internal const int k_TemplateId_Group = 1;

	[Token(Token = "0x400A7EC")]
	[FieldOffset(Offset = "0x28")]
	private readonly DuelLiveRootWidget m_Owner;

	[Token(Token = "0x400A7ED")]
	[FieldOffset(Offset = "0x30")]
	private readonly ElementEntityFactory m_EntityFactory;

	[Token(Token = "0x400A7EE")]
	[FieldOffset(Offset = "0x38")]
	private readonly SnapScrollView m_ScrollView;

	[Token(Token = "0x400A7EF")]
	[FieldOffset(Offset = "0x40")]
	private List<TabContext> m_ContextDatas;

	[Token(Token = "0x400A7F0")]
	[FieldOffset(Offset = "0x48")]
	public int defaultIdx;

	[Token(Token = "0x400A7F1")]
	[FieldOffset(Offset = "0x4C")]
	public int defaultSectionIdx;

	[Token(Token = "0x400A7F2")]
	[FieldOffset(Offset = "0x50")]
	public readonly Selector selector;

	[Token(Token = "0x400A7F3")]
	[FieldOffset(Offset = "0x58")]
	public RectTransform mainContent;

	[Token(Token = "0x400A7F4")]
	[FieldOffset(Offset = "0x60")]
	public RectTransform content;

	[Token(Token = "0x17000EB6")]
	public AccordionTabGroupWidget accordionTab
	{
		[Token(Token = "0x6005D70")]
		[Address(RVA = "0x3D8370", Offset = "0x3D7570", VA = "0x1803D8370")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000EB7")]
	public int idx
	{
		[Token(Token = "0x6005D71")]
		[Address(RVA = "0xA49700", Offset = "0xA48900", VA = "0x180A49700")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000EB8")]
	public int sectionIdx
	{
		[Token(Token = "0x6005D72")]
		[Address(RVA = "0xA49720", Offset = "0xA48920", VA = "0x180A49720")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000EB9")]
	public bool exists
	{
		[Token(Token = "0x6005D73")]
		[Address(RVA = "0xA496B0", Offset = "0xA488B0", VA = "0x180A496B0")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000EBA")]
	public ElementEntityFactory entityFactory
	{
		[Token(Token = "0x6005D74")]
		[Address(RVA = "0x402CE0", Offset = "0x401EE0", VA = "0x180402CE0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000EBB")]
	public SnapScrollView scrollView
	{
		[Token(Token = "0x6005D75")]
		[Address(RVA = "0x404860", Offset = "0x403A60", VA = "0x180404860")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6005D76")]
	[Address(RVA = "0xA495F0", Offset = "0xA487F0", VA = "0x180A495F0")]
	public SubTabListWidget(ElementObjectManager eom, DuelLiveRootWidget owner)
	{
	}

	[Token(Token = "0x6005D77")]
	[Address(RVA = "0xA48610", Offset = "0xA47810", VA = "0x180A48610")]
	public void Init()
	{
	}

	[Token(Token = "0x6005D78")]
	[Address(RVA = "0x595530", Offset = "0x594730", VA = "0x180595530")]
	public void UpdateContextData(List<TabContext> contextDatas)
	{
	}

	[Token(Token = "0x6005D79")]
	[Address(RVA = "0xA48B10", Offset = "0xA47D10", VA = "0x180A48B10")]
	public Dictionary<int, bool> UpdateBadge(List<List<TabContext>> contexts)
	{
		return null;
	}

	[Token(Token = "0x6005D7A")]
	[Address(RVA = "0xA484A0", Offset = "0xA476A0", VA = "0x180A484A0")]
	public void CheckSectionIdxByCurrentPos()
	{
	}

	[Token(Token = "0x6005D7B")]
	[Address(RVA = "0xA48650", Offset = "0xA47850", VA = "0x180A48650")]
	public void ShowTween(bool isNext)
	{
	}
}
