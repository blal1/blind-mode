using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using YgomSystem.ElementSystem;

namespace YgomSystem.UI.ElementWidget;

[Token(Token = "0x20005F7")]
public class AccordionTabGroupWidget : ElementWidgetBehaviourBase<AccordionTabGroupWidget>
{
	[Token(Token = "0x20005F8")]
	public interface ISubTabData
	{
		[Token(Token = "0x170004BE")]
		string tabText
		{
			[Token(Token = "0x6002742")]
			get;
		}

		[Token(Token = "0x170004BF")]
		string tabTextId
		{
			[Token(Token = "0x6002743")]
			get;
		}

		[Token(Token = "0x170004C0")]
		string param
		{
			[Token(Token = "0x6002744")]
			get;
		}
	}

	[Token(Token = "0x20005F9")]
	public class SubTabSectionData : ISubTabData
	{
		[Token(Token = "0x4001CC9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private string m_TabText;

		[Token(Token = "0x4001CCA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private string m_TabTextId;

		[Token(Token = "0x4001CCB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private string m_Param;

		[Token(Token = "0x4001CCC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public bool isBadge;

		[Token(Token = "0x170004C1")]
		public string tabText
		{
			[Token(Token = "0x6002745")]
			[Address(RVA = "0x40C440", Offset = "0x40B640", VA = "0x18040C440", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170004C2")]
		public string tabTextId
		{
			[Token(Token = "0x6002746")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170004C3")]
		public string param
		{
			[Token(Token = "0x6002747")]
			[Address(RVA = "0x3D8370", Offset = "0x3D7570", VA = "0x1803D8370", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6002748")]
		[Address(RVA = "0x6B0730", Offset = "0x6AF930", VA = "0x1806B0730")]
		public SubTabSectionData(string text, string id, [Optional] string param, bool isBadge = false)
		{
		}
	}

	[Token(Token = "0x20005FA")]
	public class SubTabData : ISubTabData
	{
		[Token(Token = "0x4001CCD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private string m_TabText;

		[Token(Token = "0x4001CCE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private string m_TabTextId;

		[Token(Token = "0x4001CCF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private string m_Param;

		[Token(Token = "0x4001CD0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public bool isBadge;

		[Token(Token = "0x4001CD1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Dictionary<int, SubTabSectionData> m_ChildTabs;

		[Token(Token = "0x170004C4")]
		public string tabText
		{
			[Token(Token = "0x6002749")]
			[Address(RVA = "0x40C440", Offset = "0x40B640", VA = "0x18040C440", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170004C5")]
		public string tabTextId
		{
			[Token(Token = "0x600274A")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170004C6")]
		public string param
		{
			[Token(Token = "0x600274B")]
			[Address(RVA = "0x3D8370", Offset = "0x3D7570", VA = "0x1803D8370", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170004C7")]
		public Dictionary<int, SubTabSectionData> childTabs
		{
			[Token(Token = "0x600274C")]
			[Address(RVA = "0x402CE0", Offset = "0x401EE0", VA = "0x180402CE0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600274D")]
		[Address(RVA = "0x6B0730", Offset = "0x6AF930", VA = "0x1806B0730")]
		public SubTabData(string text, string id, [Optional] string param, bool isBadge = false)
		{
		}

		[Token(Token = "0x600274E")]
		[Address(RVA = "0x6B0600", Offset = "0x6AF800", VA = "0x1806B0600")]
		public void AddChild(string tabText, string tabTextId, int sectionIndex, [Optional] string param, bool isBadge = false)
		{
		}
	}

	[Token(Token = "0x4001CA3")]
	internal const string k_ELabelTarget = "AccordionTab/Root/SubTabs/TabsList";

	[Token(Token = "0x4001CA4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private Dictionary<int, Dictionary<int, SubTabData>> m_MultiTabData;

	[Token(Token = "0x4001CA5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private Dictionary<int, SubTabData> m_TabData;

	[Token(Token = "0x4001CA6")]
	internal const int k_TemplateId_Single = 0;

	[Token(Token = "0x4001CA7")]
	internal const int k_TemplateId_Group = 1;

	[Token(Token = "0x4001CA8")]
	private const string k_ELabelOnText = "OnText";

	[Token(Token = "0x4001CA9")]
	private const string k_ELabelOffText = "OffText";

	[Token(Token = "0x4001CAA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private List<int> m_TemplateIds;

	[Token(Token = "0x4001CAB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public int mainTabIndex;

	[Token(Token = "0x4001CAC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	public int defaultMainTabIdx;

	[Token(Token = "0x4001CAD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private int m_Index;

	[Token(Token = "0x4001CAE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	private int m_SubIndex;

	[Token(Token = "0x4001CAF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public int defaultIdx;

	[Token(Token = "0x4001CB0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	public int defaultSectionIdx;

	[Token(Token = "0x4001CB1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public bool isSetTopTabAsDefaultItem;

	[Token(Token = "0x4001CB2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x59")]
	private bool isAleadySetDefaultItem;

	[Token(Token = "0x4001CB3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private ElementEntityFactory m_EntityFactory;

	[Token(Token = "0x4001CB4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private SnapScrollView m_ScrollView;

	[Token(Token = "0x4001CB5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private Dictionary<GameObject, ElementWidgetBase> m_TabWidgetMap;

	[Token(Token = "0x4001CB6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private Action<int, int, int, int> onPreChangeIdxEvent;

	[Token(Token = "0x4001CB7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private Action<int, int> onChangedIdxEvent;

	[Token(Token = "0x4001CB8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private Action<int> onClickedToggle;

	[Token(Token = "0x4001CB9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private Action<int> onClickedGroupToggle;

	[Token(Token = "0x4001CBA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private Action<int, int> onClickedSectionToggle;

	[Token(Token = "0x4001CBB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	private Dictionary<int, Dictionary<int, bool>> m_AutoAccordionShrinkMap;

	[Token(Token = "0x4001CBC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	private RectTransform mainContent;

	[Token(Token = "0x4001CBD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	private RectTransform content;

	[Token(Token = "0x4001CBE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	[SerializeField]
	[Tooltip("確定時に子SelectorのSelectを試みるか")]
	private bool m_TrySelectChildOnDecided;

	[Token(Token = "0x4001CBF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	[HideInInspector]
	public Selector selector;

	[Token(Token = "0x4001CC0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	public Action<int, int> customOnClickTab;

	[Token(Token = "0x4001CC1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	public Action<int, int, int, int> onChangedTab;

	[Token(Token = "0x4001CC2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	public Action<int, int> onClickedTab;

	[Token(Token = "0x4001CC3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	public Action<GameObject> onCreatedTabEntity;

	[Token(Token = "0x4001CC4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	public Action<GameObject, int, int> onUpdateTabEntity;

	[Token(Token = "0x4001CC5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	public Func<bool> customRightDirection;

	[Token(Token = "0x4001CC6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	[HideInInspector]
	public bool directionBlocker;

	[Token(Token = "0x4001CC7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xFC")]
	private int m_PreSubTabIdx;

	[Token(Token = "0x4001CC8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
	private int m_PreSubTabSectionIdx;

	[Token(Token = "0x170004B7")]
	public Dictionary<int, Dictionary<int, SubTabData>> multiTabData
	{
		[Token(Token = "0x600270F")]
		[Address(RVA = "0x4030F0", Offset = "0x4022F0", VA = "0x1804030F0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170004B8")]
	public Dictionary<int, SubTabData> tabData
	{
		[Token(Token = "0x6002710")]
		[Address(RVA = "0x402CE0", Offset = "0x401EE0", VA = "0x180402CE0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170004B9")]
	public ElementEntityFactory entityFactory
	{
		[Token(Token = "0x6002711")]
		[Address(RVA = "0x589E50", Offset = "0x589050", VA = "0x180589E50")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170004BA")]
	public SnapScrollView scrollView
	{
		[Token(Token = "0x6002712")]
		[Address(RVA = "0x49B9F0", Offset = "0x49ABF0", VA = "0x18049B9F0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170004BB")]
	private Dictionary<int, bool> m_CurrentAutoAccordionShrinkMap
	{
		[Token(Token = "0x6002713")]
		[Address(RVA = "0x689600", Offset = "0x688800", VA = "0x180689600")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170004BC")]
	public int currentTabIndex
	{
		[Token(Token = "0x6002714")]
		[Address(RVA = "0x49BDB0", Offset = "0x49AFB0", VA = "0x18049BDB0")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x170004BD")]
	public int currentSectionIndex
	{
		[Token(Token = "0x6002715")]
		[Address(RVA = "0x49BD80", Offset = "0x49AF80", VA = "0x18049BD80")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x600270C")]
	[Address(RVA = "0x683B20", Offset = "0x682D20", VA = "0x180683B20")]
	public void AddTabData(int tabDataCount, [Optional] Action onCompleted)
	{
	}

	[Token(Token = "0x600270D")]
	[Address(RVA = "0x683C90", Offset = "0x682E90", VA = "0x180683C90")]
	public void AddTabData(int index, int sectionIndex = 0, [Optional] string labelText, [Optional] string labelTextId, [Optional] string labelTextParam, bool badge = false, bool isDefaultItem = false)
	{
	}

	[Token(Token = "0x600270E")]
	[Address(RVA = "0x6838C0", Offset = "0x682AC0", VA = "0x1806838C0")]
	public void AddMultiTabData(int GroupIndex, int index, int sectionIndex = 0, [Optional] string labelText, [Optional] string labelTextId, [Optional] string labelTextParam, bool badge = false, bool isDefaultItem = false)
	{
	}

	[Token(Token = "0x6002716")]
	[Address(RVA = "0x6845E0", Offset = "0x6837E0", VA = "0x1806845E0")]
	public GameObject GetCurrentTabObject()
	{
		return null;
	}

	[Token(Token = "0x6002717")]
	[Address(RVA = "0x684710", Offset = "0x683910", VA = "0x180684710")]
	public ToggleWidget GetCurrentTabToggle()
	{
		return null;
	}

	[Token(Token = "0x6002718")]
	[Address(RVA = "0x684A50", Offset = "0x683C50", VA = "0x180684A50")]
	public ToggleAccordionWidget GetToggleAccordionWidget(int index)
	{
		return null;
	}

	[Token(Token = "0x6002719")]
	[Address(RVA = "0x684B60", Offset = "0x683D60", VA = "0x180684B60")]
	public ToggleWidget GetToggleWidget(int index, int sectionIndex)
	{
		return null;
	}

	[Token(Token = "0x600271A")]
	[Address(RVA = "0x685D00", Offset = "0x684F00", VA = "0x180685D00")]
	public bool IsGroupTab(GameObject go)
	{
		return default(bool);
	}

	[Token(Token = "0x600271B")]
	[Address(RVA = "0x685DD0", Offset = "0x684FD0", VA = "0x180685DD0")]
	public bool IsGroupTab(int index)
	{
		return default(bool);
	}

	[Token(Token = "0x600271C")]
	[Address(RVA = "0x685310", Offset = "0x684510", VA = "0x180685310")]
	public void Initialize([Optional] Action onCompleted)
	{
	}

	[Token(Token = "0x600271D")]
	[Address(RVA = "0x685EB0", Offset = "0x6850B0", VA = "0x180685EB0")]
	private void OnActivateEntity(GameObject entity)
	{
	}

	[Token(Token = "0x600271E")]
	[Address(RVA = "0x686320", Offset = "0x685520", VA = "0x180686320")]
	private void OnDeactivateEntity(GameObject entity)
	{
	}

	[Token(Token = "0x600271F")]
	[Address(RVA = "0x6878E0", Offset = "0x686AE0", VA = "0x1806878E0")]
	public void RefreshTab([Optional] Action onCompleted)
	{
	}

	[Token(Token = "0x6002720")]
	[Address(RVA = "0x687B40", Offset = "0x686D40", VA = "0x180687B40")]
	public bool SelectByIndex(int index, int subIndex)
	{
		return default(bool);
	}

	[Token(Token = "0x6002721")]
	[Address(RVA = "0x688CB0", Offset = "0x687EB0", VA = "0x180688CB0")]
	public void SetLabel(GameObject target, string text)
	{
	}

	[Token(Token = "0x6002722")]
	[Address(RVA = "0x688610", Offset = "0x687810", VA = "0x180688610")]
	public void SetBadge(int index, int sectionIndex, bool frag)
	{
	}

	[Token(Token = "0x6002723")]
	[Address(RVA = "0x688750", Offset = "0x687950", VA = "0x180688750")]
	public bool SetIdx(int idx, int sectionIdx = 0)
	{
		return default(bool);
	}

	[Token(Token = "0x6002724")]
	[Address(RVA = "0x688250", Offset = "0x687450", VA = "0x180688250")]
	public bool SelectCurrentIdx(bool initializeSelection = false, bool selectSection = false)
	{
		return default(bool);
	}

	[Token(Token = "0x6002725")]
	[Address(RVA = "0x684210", Offset = "0x683410", VA = "0x180684210")]
	public bool FocusCurrentIdx(bool containSection = false, bool selectItem = false, bool initializeSelection = false, bool preferenceFocusSectionItem = false)
	{
		return default(bool);
	}

	[Token(Token = "0x6002726")]
	[Address(RVA = "0x684510", Offset = "0x683710", VA = "0x180684510")]
	public bool FocusParentSelector()
	{
		return default(bool);
	}

	[Token(Token = "0x6002727")]
	[Address(RVA = "0x686C00", Offset = "0x685E00", VA = "0x180686C00")]
	private void OnPrechangeTabIdx(int preSubTabIdx, int preSubTabSectionIdx, int newSubTabIdx, int newSubTabSectionIdx)
	{
	}

	[Token(Token = "0x6002728")]
	[Address(RVA = "0x685F00", Offset = "0x685100", VA = "0x180685F00")]
	private void OnChangedTabIdx(int idx, int sectionIdx)
	{
	}

	[Token(Token = "0x6002729")]
	[Address(RVA = "0x685FF0", Offset = "0x6851F0", VA = "0x180685FF0")]
	private void OnCreatedEntity(GameObject entity, int templateIdx, [Optional] ToggleAccordionWidget parentGroup)
	{
	}

	[Token(Token = "0x600272A")]
	[Address(RVA = "0x687040", Offset = "0x686240", VA = "0x180687040")]
	private void OnUpdateEntity(GameObject entity, int dataIdx)
	{
	}

	[Token(Token = "0x600272B")]
	[Address(RVA = "0x685FD0", Offset = "0x6851D0", VA = "0x180685FD0")]
	private void OnCreatedEntityGroupSection(GameObject sectionEntity, [Optional] ToggleAccordionWidget parentGroup)
	{
	}

	[Token(Token = "0x600272C")]
	[Address(RVA = "0x686C40", Offset = "0x685E40", VA = "0x180686C40")]
	private void OnUpdateEntityGroupSection(GameObject sectionEntity, int dataIdx, int sectionDataIdx, ToggleAccordionWidget parent)
	{
	}

	[Token(Token = "0x600272D")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60")]
	private void OnGroupParentSelected()
	{
	}

	[Token(Token = "0x600272E")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60")]
	private void OnGroupSectionSelected()
	{
	}

	[Token(Token = "0x600272F")]
	[Address(RVA = "0x686C10", Offset = "0x685E10", VA = "0x180686C10")]
	private bool OnSelectorSelected(bool initializeSelection = false)
	{
		return default(bool);
	}

	[Token(Token = "0x6002730")]
	[Address(RVA = "0x686370", Offset = "0x685570", VA = "0x180686370")]
	private bool OnInputDirection(PadInputDirection direction)
	{
		return default(bool);
	}

	[Token(Token = "0x6002731")]
	[Address(RVA = "0x688930", Offset = "0x687B30", VA = "0x180688930")]
	private void SetLabelByData(ElementObjectManager eom, int index, int sectionIndex = 0, bool isSection = false)
	{
	}

	[Token(Token = "0x6002732")]
	[Address(RVA = "0x683E60", Offset = "0x683060", VA = "0x180683E60")]
	private void AutoTween(int nextIdx, int sectionIdx, bool isUp = false)
	{
	}

	[Token(Token = "0x6002733")]
	[Address(RVA = "0x687FD0", Offset = "0x6871D0", VA = "0x180687FD0")]
	private bool SelectChildSelector(bool initializeSelect = false)
	{
		return default(bool);
	}

	[Token(Token = "0x6002734")]
	[Address(RVA = "0x688E90", Offset = "0x688090", VA = "0x180688E90")]
	private void SetWidget(ToggleWidget tabWidget)
	{
	}

	[Token(Token = "0x6002735")]
	[Address(RVA = "0x688ED0", Offset = "0x6880D0", VA = "0x180688ED0")]
	private void SetupDirectionInput(ToggleWidget tabWidget, PadInputDirection direction)
	{
	}

	[Token(Token = "0x6002736")]
	[Address(RVA = "0x686A20", Offset = "0x685C20", VA = "0x180686A20")]
	private void OnInputEdgeDirection(ToggleWidget tabWidget, PadInputDirection padInputDirection)
	{
	}

	[Token(Token = "0x6002737")]
	[Address(RVA = "0x684900", Offset = "0x683B00", VA = "0x180684900")]
	public ElementWidgetBase GetCurrentTab(bool getParent = false)
	{
		return null;
	}

	[Token(Token = "0x6002738")]
	[Address(RVA = "0x684E00", Offset = "0x684000", VA = "0x180684E00")]
	private void InitAcordionImmediate(bool isFocus = false)
	{
	}

	[Token(Token = "0x6002739")]
	[Address(RVA = "0x685C40", Offset = "0x684E40", VA = "0x180685C40")]
	public bool IsAutoAcordionShrink(int categoryId)
	{
		return default(bool);
	}

	[Token(Token = "0x600273A")]
	[Address(RVA = "0x6884F0", Offset = "0x6876F0", VA = "0x1806884F0")]
	public void SetAutoAcordionShrink(int categoryId, bool value)
	{
	}

	[Token(Token = "0x600273B")]
	[Address(RVA = "0x689520", Offset = "0x688720", VA = "0x180689520")]
	public AccordionTabGroupWidget()
	{
	}
}
