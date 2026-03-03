using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using YgomSystem.ElementSystem;
using YgomSystem.UI.ElementWidget;

namespace YgomSystem.UI.MultiVCTab;

[Token(Token = "0x20005E6")]
public class MultiVCTabHorizonWidget : ElementWidgetBase
{
	[Token(Token = "0x20005E7")]
	public class TabContext
	{
		[Token(Token = "0x4001C68")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public IMultiVCTabProductGruopData groupData;

		[Token(Token = "0x4001C69")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string label;

		[Token(Token = "0x4001C6A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool badge;

		[Token(Token = "0x60026CB")]
		[Address(RVA = "0x5FF240", Offset = "0x5FE440", VA = "0x1805FF240")]
		public TabContext(IMultiVCTabProductGruopData groupData, string label)
		{
		}
	}

	[Token(Token = "0x4001C58")]
	internal const int k_TemplateId_Single = 0;

	[Token(Token = "0x4001C59")]
	internal const int k_TemplateId_Group = 1;

	[Token(Token = "0x4001C5A")]
	private const string k_ELabelTabsList = "HorizonSubTabs";

	[Token(Token = "0x4001C5B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private ElementObjectManager m_TabsListEom;

	[Token(Token = "0x4001C5C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private readonly MultiVCTabRootWidget m_Owner;

	[Token(Token = "0x4001C5D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private Dictionary<int, GameObject> m_map;

	[Token(Token = "0x4001C5E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private Dictionary<GameObject, ISubTabWidget> m_TabWidgetMap;

	[Token(Token = "0x4001C5F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private Dictionary<GameObject, bool> m_AcordionMap;

	[Token(Token = "0x4001C60")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private int m_Idx;

	[Token(Token = "0x4001C61")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private List<TabContext> m_ContextDatas;

	[Token(Token = "0x4001C62")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public int defaultIdx;

	[Token(Token = "0x4001C63")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public readonly Selector selector;

	[Token(Token = "0x4001C67")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private List<MultiVCTabWidget> m_ActiveTabWidget;

	[Token(Token = "0x1700049E")]
	public int idx
	{
		[Token(Token = "0x60026B3")]
		[Address(RVA = "0x49BDB0", Offset = "0x49AFB0", VA = "0x18049BDB0")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x1700049F")]
	public bool exists
	{
		[Token(Token = "0x60026B4")]
		[Address(RVA = "0x696570", Offset = "0x695770", VA = "0x180696570")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170004A0")]
	public List<TabContext> ctxData
	{
		[Token(Token = "0x60026B5")]
		[Address(RVA = "0x580700", Offset = "0x57F900", VA = "0x180580700")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x14000033")]
	public event Action<int, int> onPreChangeIdxEvent
	{
		[Token(Token = "0x60026B6")]
		[Address(RVA = "0x6964C0", Offset = "0x6956C0", VA = "0x1806964C0")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x60026B7")]
		[Address(RVA = "0x6968D0", Offset = "0x695AD0", VA = "0x1806968D0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x14000034")]
	public event Action<int> onChangedIdxEvent
	{
		[Token(Token = "0x60026B8")]
		[Address(RVA = "0x696360", Offset = "0x695560", VA = "0x180696360")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x60026B9")]
		[Address(RVA = "0x696770", Offset = "0x695970", VA = "0x180696770")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x14000035")]
	public event Action<int> onClickSubCategory
	{
		[Token(Token = "0x60026BA")]
		[Address(RVA = "0x696410", Offset = "0x695610", VA = "0x180696410")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x60026BB")]
		[Address(RVA = "0x696820", Offset = "0x695A20", VA = "0x180696820")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x60026BC")]
	[Address(RVA = "0x696150", Offset = "0x695350", VA = "0x180696150")]
	public MultiVCTabHorizonWidget(ElementObjectManager eom, MultiVCTabRootWidget owner)
	{
	}

	[Token(Token = "0x60026BD")]
	[Address(RVA = "0x694DA0", Offset = "0x693FA0", VA = "0x180694DA0")]
	public void InitData(List<TabContext> contextDatas)
	{
	}

	[Token(Token = "0x60026BE")]
	[Address(RVA = "0x694E30", Offset = "0x694030", VA = "0x180694E30")]
	public void InitHorizonTab([Optional] Action onCompleted)
	{
	}

	[Token(Token = "0x60026BF")]
	[Address(RVA = "0x696650", Offset = "0x695850", VA = "0x180696650")]
	public bool isExistActiveBadge()
	{
		return default(bool);
	}

	[Token(Token = "0x60026C0")]
	[Address(RVA = "0x695E90", Offset = "0x695090", VA = "0x180695E90")]
	public void SetActiveHorizonTabEom(bool frag)
	{
	}

	[Token(Token = "0x60026C1")]
	[Address(RVA = "0x6965C0", Offset = "0x6957C0", VA = "0x1806965C0")]
	public bool isActiveHorizonTab()
	{
		return default(bool);
	}

	[Token(Token = "0x60026C2")]
	[Address(RVA = "0x696080", Offset = "0x695280", VA = "0x180696080")]
	public bool SetIdx(int idx)
	{
		return default(bool);
	}

	[Token(Token = "0x60026C3")]
	[Address(RVA = "0x694CE0", Offset = "0x693EE0", VA = "0x180694CE0")]
	public void ClickCurrentIdx()
	{
	}

	[Token(Token = "0x60026C4")]
	[Address(RVA = "0x695DC0", Offset = "0x694FC0", VA = "0x180695DC0")]
	public bool SelectCurrentIdx(bool initializeSelection = false)
	{
		return default(bool);
	}

	[Token(Token = "0x60026C5")]
	[Address(RVA = "0x695F10", Offset = "0x695110", VA = "0x180695F10")]
	public void SetActiveHorizonTab(bool frag)
	{
	}

	[Token(Token = "0x60026C6")]
	[Address(RVA = "0x695690", Offset = "0x694890", VA = "0x180695690")]
	private void OnCreatedEntity(GameObject entity, [Optional] MultiVCTabGroupWidget parentGroup)
	{
	}

	[Token(Token = "0x60026C7")]
	[Address(RVA = "0x695590", Offset = "0x694790", VA = "0x180695590")]
	private MultiVCTabSingleWidget OnCreatedEntitySingle(GameObject entity, [Optional] MultiVCTabGroupWidget parentGroup)
	{
		return null;
	}

	[Token(Token = "0x60026C8")]
	[Address(RVA = "0x695C10", Offset = "0x694E10", VA = "0x180695C10")]
	public void OnUpdateEntity()
	{
	}

	[Token(Token = "0x60026C9")]
	[Address(RVA = "0x695950", Offset = "0x694B50", VA = "0x180695950")]
	private void OnUpdateEntitySignle(MultiVCTabSingleWidget widget, int dataIdx)
	{
	}

	[Token(Token = "0x60026CA")]
	[Address(RVA = "0x6957D0", Offset = "0x6949D0", VA = "0x1806957D0")]
	private bool OnInputDirection(SelectionButton btn)
	{
		return default(bool);
	}
}
