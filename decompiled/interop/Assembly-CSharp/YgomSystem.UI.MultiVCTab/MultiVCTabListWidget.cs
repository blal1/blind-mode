using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using YgomSystem.ElementSystem;
using YgomSystem.UI.ElementWidget;

namespace YgomSystem.UI.MultiVCTab;

[Token(Token = "0x20005EA")]
public class MultiVCTabListWidget : ElementWidgetBase
{
	[Token(Token = "0x20005EB")]
	public class TabContext
	{
		[Token(Token = "0x4001C7B")]
		[FieldOffset(Offset = "0x10")]
		public IMultiVCTabProductGruopData groupData;

		[Token(Token = "0x4001C7C")]
		[FieldOffset(Offset = "0x18")]
		public string label;

		[Token(Token = "0x4001C7D")]
		[FieldOffset(Offset = "0x20")]
		public bool badge;

		[Token(Token = "0x4001C7E")]
		[FieldOffset(Offset = "0x28")]
		public List<TabContext> children;

		[Token(Token = "0x170004A5")]
		public bool hasChildren
		{
			[Token(Token = "0x60026D7")]
			[Address(RVA = "0x69E250", Offset = "0x69D450", VA = "0x18069E250")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60026D8")]
		[Address(RVA = "0x69E100", Offset = "0x69D300", VA = "0x18069E100")]
		public TabContext(IMultiVCTabProductGruopData groupData, string label)
		{
		}

		[Token(Token = "0x60026D9")]
		[Address(RVA = "0x69E1C0", Offset = "0x69D3C0", VA = "0x18069E1C0")]
		public TabContext(IMultiVCTabProductGruopData setting, string label, List<TabContext> children)
		{
		}
	}

	[Token(Token = "0x4001C6F")]
	internal const int k_TemplateId_Single = 0;

	[Token(Token = "0x4001C70")]
	internal const int k_TemplateId_Group = 1;

	[Token(Token = "0x4001C71")]
	private const string k_ELabelTabsList = "TabsList";

	[Token(Token = "0x4001C72")]
	[FieldOffset(Offset = "0x20")]
	private readonly SnapScrollView m_ScrollView;

	[Token(Token = "0x4001C73")]
	[FieldOffset(Offset = "0x28")]
	private Dictionary<GameObject, ISubTabWidget> m_TabWidgetMap;

	[Token(Token = "0x4001C74")]
	[FieldOffset(Offset = "0x30")]
	private Dictionary<GameObject, bool> m_AcordionMap;

	[Token(Token = "0x4001C75")]
	[FieldOffset(Offset = "0x38")]
	private int m_Idx;

	[Token(Token = "0x4001C76")]
	[FieldOffset(Offset = "0x3C")]
	private int m_SectionIdx;

	[Token(Token = "0x4001C77")]
	[FieldOffset(Offset = "0x40")]
	private List<TabContext> m_ContextDatas;

	[Token(Token = "0x4001C78")]
	[FieldOffset(Offset = "0x48")]
	public int defaultIdx;

	[Token(Token = "0x4001C79")]
	[FieldOffset(Offset = "0x4C")]
	public int defaultSectionIdx;

	[Token(Token = "0x4001C7A")]
	[FieldOffset(Offset = "0x50")]
	public readonly Selector selector;

	[Token(Token = "0x170004A1")]
	public int idx
	{
		[Token(Token = "0x60026D2")]
		[Address(RVA = "0x40C450", Offset = "0x40B650", VA = "0x18040C450")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x170004A2")]
	public int sectionIdx
	{
		[Token(Token = "0x60026D3")]
		[Address(RVA = "0x5EA1B0", Offset = "0x5E93B0", VA = "0x1805EA1B0")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x170004A3")]
	public bool exists
	{
		[Token(Token = "0x60026D4")]
		[Address(RVA = "0x696A50", Offset = "0x695C50", VA = "0x180696A50")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170004A4")]
	public SnapScrollView scrollView
	{
		[Token(Token = "0x60026D5")]
		[Address(RVA = "0x3D8370", Offset = "0x3D7570", VA = "0x1803D8370")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60026D6")]
	[Address(RVA = "0x696980", Offset = "0x695B80", VA = "0x180696980")]
	public MultiVCTabListWidget(ElementObjectManager eom, MultiVCTabRootWidget owner)
	{
	}
}
