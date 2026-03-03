using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using YgomGame.Menu;
using YgomSystem.ElementSystem;
using YgomSystem.UI;
using YgomSystem.Utility;
using YgomSystem.YGomTMPro;

namespace YgomGame.DuelLive;

[Token(Token = "0x2000F2B")]
public class DuelLiveWCSFilterDialog : SelectDialogViewControllerBase<IReadOnlyCollection<DuelLiveWCSFilterItem>, int, int>
{
	[Token(Token = "0x2000F2C")]
	private class FilterItemDesc
	{
		[Token(Token = "0x400A68C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int filterNo;

		[Token(Token = "0x400A68D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string label1;

		[Token(Token = "0x400A68E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string label2;

		[Token(Token = "0x400A68F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public bool onoff;

		[Token(Token = "0x400A690")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public string iconPath;

		[Token(Token = "0x6005BFB")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public FilterItemDesc()
		{
		}
	}

	[Token(Token = "0x2000F2D")]
	private class FilterToggleUI
	{
		[Token(Token = "0x400A691")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private bool m_isOn;

		[Token(Token = "0x400A692")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private int m_number;

		[Token(Token = "0x400A693")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private GameObject m_off;

		[Token(Token = "0x400A694")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private GameObject m_on;

		[Token(Token = "0x400A695")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private ExtendedTextMeshProUGUI m_label1;

		[Token(Token = "0x400A696")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private ExtendedTextMeshProUGUI m_label2;

		[Token(Token = "0x400A697")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Image m_icon;

		[Token(Token = "0x400A698")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private SelectionButton m_button;

		[Token(Token = "0x400A699")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private RectTransform m_rt;

		[Token(Token = "0x17000E5C")]
		public bool isOn
		{
			[Token(Token = "0x6005BFC")]
			[Address(RVA = "0x465880", Offset = "0x464A80", VA = "0x180465880")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000E5D")]
		public int number
		{
			[Token(Token = "0x6005BFD")]
			[Address(RVA = "0x64B770", Offset = "0x64A970", VA = "0x18064B770")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000E5E")]
		public RectTransform rectTransform
		{
			[Token(Token = "0x6005BFE")]
			[Address(RVA = "0x414E80", Offset = "0x414080", VA = "0x180414E80")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000E5F")]
		public SelectionButton button
		{
			[Token(Token = "0x6005BFF")]
			[Address(RVA = "0x404850", Offset = "0x403A50", VA = "0x180404850")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000E60")]
		public string labelMain
		{
			[Token(Token = "0x6005C00")]
			[Address(RVA = "0xA14C90", Offset = "0xA13E90", VA = "0x180A14C90")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000E61")]
		public string labelSub
		{
			[Token(Token = "0x6005C01")]
			[Address(RVA = "0xA14CC0", Offset = "0xA13EC0", VA = "0x180A14CC0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6005C02")]
		[Address(RVA = "0xA147A0", Offset = "0xA139A0", VA = "0x180A147A0")]
		public void Initialize(ElementObjectManager eom, int number, string label1, string label2, bool onoff, string iconPath, Action<FilterToggleUI> selectedCallback, Action<FilterToggleUI, bool> clickCallback)
		{
		}

		[Token(Token = "0x6005C03")]
		[Address(RVA = "0xA14B20", Offset = "0xA13D20", VA = "0x180A14B20")]
		public void SetOn(bool isOn)
		{
		}

		[Token(Token = "0x6005C04")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public FilterToggleUI()
		{
		}
	}

	[Token(Token = "0x2000F2F")]
	private class FilterCategoryUI
	{
		[Token(Token = "0x400A69D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private RectTransform m_root;

		[Token(Token = "0x400A69E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private RectTransform m_buttonArea;

		[Token(Token = "0x400A69F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private List<FilterToggleUI> m_toggles;

		[Token(Token = "0x400A6A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Action<FilterToggleUI> m_toggleSelectedCallback;

		[Token(Token = "0x400A6A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Action<FilterToggleUI, bool> m_toggleClickCallback;

		[Token(Token = "0x17000E62")]
		public RectTransform root
		{
			[Token(Token = "0x6005C08")]
			[Address(RVA = "0x40C440", Offset = "0x40B640", VA = "0x18040C440")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000E63")]
		public RectTransform buttonArea
		{
			[Token(Token = "0x6005C09")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000E64")]
		public Action<FilterToggleUI> toggleSelectedCallback
		{
			[Token(Token = "0x6005C0B")]
			[Address(RVA = "0x402FB0", Offset = "0x4021B0", VA = "0x180402FB0")]
			set
			{
			}
		}

		[Token(Token = "0x17000E65")]
		public Action<FilterToggleUI, bool> toggleClickCallback
		{
			[Token(Token = "0x6005C0C")]
			[Address(RVA = "0x4130D0", Offset = "0x4122D0", VA = "0x1804130D0")]
			set
			{
			}
		}

		[Token(Token = "0x6005C0A")]
		[Address(RVA = "0xA144E0", Offset = "0xA136E0", VA = "0x180A144E0")]
		public void Initialize(ElementObjectManager eom, string label)
		{
		}

		[Token(Token = "0x6005C0D")]
		[Address(RVA = "0xA14140", Offset = "0xA13340", VA = "0x180A14140")]
		public FilterToggleUI AddToggle(GameObject templateObj, int number, string label1, string label2, string iconPath, bool onoff)
		{
			return null;
		}

		[Token(Token = "0x6005C0E")]
		[Address(RVA = "0xA143A0", Offset = "0xA135A0", VA = "0x180A143A0")]
		public FilterToggleUI FindToggle(int number)
		{
			return null;
		}

		[Token(Token = "0x6005C0F")]
		[Address(RVA = "0xA14470", Offset = "0xA13670", VA = "0x180A14470")]
		public FilterToggleUI GetFirstToggle()
		{
			return null;
		}

		[Token(Token = "0x6005C10")]
		[Address(RVA = "0xA145E0", Offset = "0xA137E0", VA = "0x180A145E0")]
		public void SwitchToggle(int selectedNumber, bool onoff)
		{
		}

		[Token(Token = "0x6005C11")]
		[Address(RVA = "0xA14720", Offset = "0xA13920", VA = "0x180A14720")]
		public FilterCategoryUI()
		{
		}
	}

	[Token(Token = "0x2000F32")]
	[CompilerGenerated]
	private sealed class _003CInitializeFileterMenu_003Ed__33 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400A6A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400A6A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400A6A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public DuelLiveWCSFilterDialog _003C_003E4__this;

		[Token(Token = "0x400A6A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private int _003Ci_003E5__2;

		[Token(Token = "0x17000E66")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6005C1C")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000E67")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6005C1E")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6005C19")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CInitializeFileterMenu_003Ed__33(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6005C1A")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6005C1B")]
		[Address(RVA = "0xA2D080", Offset = "0xA2C280", VA = "0x180A2D080", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6005C1D")]
		[Address(RVA = "0xA2D560", Offset = "0xA2C760", VA = "0x180A2D560", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x400A673")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	private List<FilterItemDesc> m_teamFilterItems;

	[Token(Token = "0x400A674")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	private List<FilterItemDesc> m_leaderFilterItems;

	[Token(Token = "0x400A675")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	private FilterCategoryUI m_teamCategoryUI;

	[Token(Token = "0x400A676")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	private FilterCategoryUI m_leaderCategoryUI;

	[Token(Token = "0x400A677")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
	[SerializeField]
	private KeyConfigContainer keyConfig;

	[Token(Token = "0x400A678")]
	private const string PREFAB_PATH_FILTERDIALOG = "DuelLive/DuelLiveWCSFilterDialog";

	[Token(Token = "0x400A679")]
	private const string k_ELabelFilterMenuArea = "FilterMenuArea";

	[Token(Token = "0x400A67A")]
	private const string k_ELabelFilterScroll = "FilterScroll";

	[Token(Token = "0x400A67B")]
	private const string k_ELabelFooterArea = "FooterArea";

	[Token(Token = "0x400A67C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
	private ElementObjectManager m_FilterMenuEom;

	[Token(Token = "0x400A67D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
	private ElementObjectManager m_FooterEom;

	[Token(Token = "0x400A67E")]
	private const string k_ALabelFilterToggleTemplate = "FilterToggleTemplate";

	[Token(Token = "0x400A67F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
	private GameObject m_FilterToggleTemplate;

	[Token(Token = "0x400A680")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
	private ExtendedScrollRect m_FilterScroll;

	[Token(Token = "0x400A681")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
	private bool m_contentScrollAnimation;

	[Token(Token = "0x400A682")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x12C")]
	private Vector2 m_targetContentPosition;

	[Token(Token = "0x400A683")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
	private Coroutine m_InitializeCoroutine;

	[Token(Token = "0x400A684")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
	private int m_selectedFilterNo;

	[Token(Token = "0x400A685")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x144")]
	private bool m_ignoreToggleEvent;

	[Token(Token = "0x400A686")]
	private const string k_ELabelCancelButton = "CancelButton";

	[Token(Token = "0x400A687")]
	private const string k_ELabelFilterButton = "FilterButton";

	[Token(Token = "0x400A688")]
	private const string k_ELabelCancelShortcut = "CancelShortcut";

	[Token(Token = "0x400A689")]
	private const string k_ELabelFilterShortcut = "FilterShortcut";

	[Token(Token = "0x400A68A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
	private SelectionButton m_CancelButton;

	[Token(Token = "0x400A68B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
	private SelectionButton m_FilterButton;

	[Token(Token = "0x6005BEC")]
	[Address(RVA = "0xA11360", Offset = "0xA10560", VA = "0x180A11360")]
	public static void Open(IReadOnlyCollection<DuelLiveWCSFilterItem> filterList, int defaultFilter, [Optional] Action<int> callback)
	{
	}

	[Token(Token = "0x6005BED")]
	[Address(RVA = "0xA11100", Offset = "0xA10300", VA = "0x180A11100", Slot = "6")]
	public override void NotificationStackEntry()
	{
	}

	[Token(Token = "0x6005BEE")]
	[Address(RVA = "0xA11260", Offset = "0xA10460", VA = "0x180A11260", Slot = "23")]
	protected override void OnCreatedView()
	{
	}

	[Token(Token = "0x6005BEF")]
	[Address(RVA = "0xA10DC0", Offset = "0xA0FFC0", VA = "0x180A10DC0")]
	private void InitializeSetting()
	{
	}

	[Token(Token = "0x6005BF0")]
	[Address(RVA = "0xA10A80", Offset = "0xA0FC80", VA = "0x180A10A80")]
	private void InitializeFooter()
	{
	}

	[Token(Token = "0x6005BF1")]
	[Address(RVA = "0xA10A10", Offset = "0xA0FC10", VA = "0x180A10A10")]
	[IteratorStateMachine(typeof(_003CInitializeFileterMenu_003Ed__33))]
	private IEnumerator InitializeFileterMenu()
	{
		return null;
	}

	[Token(Token = "0x6005BF2")]
	[Address(RVA = "0xA11B70", Offset = "0xA10D70", VA = "0x180A11B70")]
	private void setupFilterUI(FilterCategoryUI categoryUI, List<FilterItemDesc> items)
	{
	}

	[Token(Token = "0x6005BF3")]
	[Address(RVA = "0xA11900", Offset = "0xA10B00", VA = "0x180A11900")]
	private bool calcScrollTargetPos(FilterCategoryUI categoryUI, FilterToggleUI toggleUI, out Vector2 targetContentPos)
	{
		return default(bool);
	}

	[Token(Token = "0x6005BF4")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60")]
	private void OnReset()
	{
	}

	[Token(Token = "0x6005BF5")]
	[Address(RVA = "0xA11560", Offset = "0xA10760", VA = "0x180A11560")]
	private void Update()
	{
	}

	[Token(Token = "0x6005BF6")]
	[Address(RVA = "0xA111E0", Offset = "0xA103E0", VA = "0x180A111E0", Slot = "13")]
	public override bool OnBack()
	{
		return default(bool);
	}

	[Token(Token = "0x6005BF7")]
	[Address(RVA = "0xA117D0", Offset = "0xA109D0", VA = "0x180A117D0")]
	public DuelLiveWCSFilterDialog()
	{
	}
}
