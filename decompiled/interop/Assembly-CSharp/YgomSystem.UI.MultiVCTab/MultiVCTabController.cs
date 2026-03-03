using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using YgomGame.Menu;
using YgomSystem.ElementSystem;

namespace YgomSystem.UI.MultiVCTab;

[Token(Token = "0x20005E0")]
public class MultiVCTabController : BaseMenuViewController, IBackButtonSupported, IHeaderBorderSupported
{
	[Token(Token = "0x20005E2")]
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass45_0
	{
		[Token(Token = "0x4001C41")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public bool doneInitProduct;

		[Token(Token = "0x4001C42")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public MultiVCTabController _003C_003E4__this;

		[Token(Token = "0x4001C43")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool isLoaded;

		[Token(Token = "0x4001C44")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
		public bool doneApplyList;

		[Token(Token = "0x6002694")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public _003C_003Ec__DisplayClass45_0()
		{
		}

		[Token(Token = "0x6002695")]
		[Address(RVA = "0x465890", Offset = "0x464A90", VA = "0x180465890")]
		internal void _003CyInitialize_003Eb__0()
		{
		}

		[Token(Token = "0x6002696")]
		[Address(RVA = "0x69EDA0", Offset = "0x69DFA0", VA = "0x18069EDA0")]
		internal void _003CyInitialize_003Eb__1(MultiVCTabSettings Settings)
		{
		}

		[Token(Token = "0x6002697")]
		[Address(RVA = "0x69EDD0", Offset = "0x69DFD0", VA = "0x18069EDD0")]
		internal void _003CyInitialize_003Eb__2()
		{
		}

		[Token(Token = "0x6002698")]
		[Address(RVA = "0x69EDE0", Offset = "0x69DFE0", VA = "0x18069EDE0")]
		internal void _003CyInitialize_003Eb__3()
		{
		}

		[Token(Token = "0x6002699")]
		[Address(RVA = "0x69EDF0", Offset = "0x69DFF0", VA = "0x18069EDF0")]
		internal void _003CyInitialize_003Eb__4(int preIdx, int preSecIdx, int idx, int secIdx)
		{
		}

		[Token(Token = "0x600269A")]
		[Address(RVA = "0x69EE30", Offset = "0x69E030", VA = "0x18069EE30")]
		internal void _003CyInitialize_003Eb__5(int idx, int secIdx)
		{
		}

		[Token(Token = "0x600269B")]
		[Address(RVA = "0x69EE60", Offset = "0x69E060", VA = "0x18069EE60")]
		internal bool _003CyInitialize_003Eb__6()
		{
			return default(bool);
		}

		[Token(Token = "0x600269C")]
		[Address(RVA = "0x69EE90", Offset = "0x69E090", VA = "0x18069EE90")]
		internal void _003CyInitialize_003Eb__7()
		{
		}
	}

	[Token(Token = "0x20005E3")]
	[CompilerGenerated]
	private sealed class _003CUpdateView_003Ed__52 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4001C45")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4001C46")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4001C47")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public MultiVCTabController _003C_003E4__this;

		[Token(Token = "0x4001C48")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public bool isFirst;

		[Token(Token = "0x4001C49")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
		public bool isClick;

		[Token(Token = "0x4001C4A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2A")]
		public bool isHorizonTab;

		[Token(Token = "0x4001C4B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2B")]
		public bool isUpdateOnly;

		[Token(Token = "0x4001C4C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Action onCompleted;

		[Token(Token = "0x17000497")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x60026A0")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000498")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60026A2")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600269D")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CUpdateView_003Ed__52(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x600269E")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x600269F")]
		[Address(RVA = "0x69F780", Offset = "0x69E980", VA = "0x18069F780", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60026A1")]
		[Address(RVA = "0x69FDE0", Offset = "0x69EFE0", VA = "0x18069FDE0", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x20005E4")]
	[CompilerGenerated]
	private sealed class _003CyInitialize_003Ed__45 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4001C4D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4001C4E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4001C4F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public MultiVCTabController _003C_003E4__this;

		[Token(Token = "0x4001C50")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private _003C_003Ec__DisplayClass45_0 _003C_003E8__1;

		[Token(Token = "0x17000499")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x60026A6")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700049A")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60026A8")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60026A3")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CyInitialize_003Ed__45(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x60026A4")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x60026A5")]
		[Address(RVA = "0x69FE20", Offset = "0x69F020", VA = "0x18069FE20", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60026A7")]
		[Address(RVA = "0x6A0F60", Offset = "0x6A0160", VA = "0x1806A0F60", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x4001C1E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static readonly string PrefabPath;

	[Token(Token = "0x4001C1F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public static readonly string k_ArgsSettingPrefabPath;

	[Token(Token = "0x4001C20")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public static readonly string k_ArgsSubTabIndex;

	[Token(Token = "0x4001C21")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public static readonly string k_ArgsSubTabSectionIndex;

	[Token(Token = "0x4001C22")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public static readonly string k_ArgsSubTabData;

	[Token(Token = "0x4001C23")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private static string settingPrefabPath;

	[Token(Token = "0x4001C24")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	private CurrentMultiVCTabData currentSubTabArgsData;

	[Token(Token = "0x4001C25")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	private Selector subTabListSelector;

	[Token(Token = "0x4001C26")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	private Selector contentSelector;

	[Token(Token = "0x4001C27")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	private Selector targetScrollrectSelector;

	[Token(Token = "0x4001C28")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	private Selector topSelector;

	[Token(Token = "0x4001C29")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	private ElementObjectManager showcasewidget;

	[Token(Token = "0x4001C2A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
	private ElementObjectManager horizonSubTabs;

	[Token(Token = "0x4001C2B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
	private MultiVCTabHorizonWidget currentHorizonTabWidget;

	[Token(Token = "0x4001C2C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
	private ViewControllerManager content;

	[Token(Token = "0x4001C2D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
	private ViewController currentViewController;

	[Token(Token = "0x4001C2E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
	private MultiVCTabBaseViewController currentMultiVCTabBaseVC;

	[Token(Token = "0x4001C2F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
	private string currentViewControllerName;

	[Token(Token = "0x4001C30")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
	private bool isBack;

	[Token(Token = "0x4001C31")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x131")]
	private bool isPoped;

	[Token(Token = "0x4001C32")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x132")]
	private bool isInitialized;

	[Token(Token = "0x4001C33")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x133")]
	private bool isPushTransition;

	[Token(Token = "0x4001C34")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
	private MultiVCTabSettings m_MultiVCTabSettings;

	[Token(Token = "0x4001C35")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
	private MultiVCTabRootWidget m_RootWidget;

	[Token(Token = "0x4001C36")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
	private int blockCount;

	[Token(Token = "0x4001C37")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14C")]
	private int loadingCount;

	[Token(Token = "0x4001C38")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
	private (int, int) currentAd;

	[Token(Token = "0x4001C39")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
	private Coroutine coroutine;

	[Token(Token = "0x4001C3A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
	public Func<bool, bool> customRightTransitionFunc;

	[Token(Token = "0x4001C3B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
	private int registerCount;

	[Token(Token = "0x4001C3C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x16C")]
	private int m_PreSubTabIdx;

	[Token(Token = "0x4001C3D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
	private int m_PreSubTabSectionIdx;

	[Token(Token = "0x4001C3E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x174")]
	private int m_PreHorizonTabIdx;

	[Token(Token = "0x17000494")]
	public CurrentMultiVCTabData CurrentMultiVCTabData
	{
		[Token(Token = "0x6002667")]
		[Address(RVA = "0x694190", Offset = "0x693390", VA = "0x180694190")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000495")]
	protected override bool setSurfaceActiveOnInitialize
	{
		[Token(Token = "0x6002668")]
		[Address(RVA = "0x404830", Offset = "0x403A30", VA = "0x180404830", Slot = "17")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000496")]
	protected override Type[] textIds
	{
		[Token(Token = "0x6002669")]
		[Address(RVA = "0x694220", Offset = "0x693420", VA = "0x180694220", Slot = "21")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600266A")]
	[Address(RVA = "0x6930A0", Offset = "0x6922A0", VA = "0x1806930A0")]
	public static void Open(ViewControllerManager vcm, Dictionary<string, object> Args)
	{
	}

	[Token(Token = "0x600266B")]
	[Address(RVA = "0x692160", Offset = "0x691360", VA = "0x180692160", Slot = "8")]
	public override void NotificationStack(ViewControllerManager vcm, ViewController vc, bool isEntry)
	{
	}

	[Token(Token = "0x600266C")]
	[Address(RVA = "0x691EE0", Offset = "0x6910E0", VA = "0x180691EE0", Slot = "6")]
	public override void NotificationStackEntry()
	{
	}

	[Token(Token = "0x600266D")]
	[Address(RVA = "0x693200", Offset = "0x692400", VA = "0x180693200")]
	private void RegisterTransAction()
	{
	}

	[Token(Token = "0x600266E")]
	[Address(RVA = "0x692090", Offset = "0x691290", VA = "0x180692090")]
	private void UnregisterTransAction()
	{
	}

	[Token(Token = "0x600266F")]
	[Address(RVA = "0x692090", Offset = "0x691290", VA = "0x180692090", Slot = "7")]
	public override void NotificationStackRemove()
	{
	}

	[Token(Token = "0x6002670")]
	[Address(RVA = "0x6922E0", Offset = "0x6914E0", VA = "0x1806922E0")]
	private void NotifyTransition(TransitionType tt, ViewController vc, ViewController preVc)
	{
	}

	[Token(Token = "0x6002671")]
	[Address(RVA = "0x692E00", Offset = "0x692000", VA = "0x180692E00", Slot = "23")]
	protected override void OnCreatedView()
	{
	}

	[Token(Token = "0x6002672")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "11")]
	public override void TransitionStart(TransitionType type)
	{
	}

	[Token(Token = "0x6002673")]
	[Address(RVA = "0x6942F0", Offset = "0x6934F0", VA = "0x1806942F0")]
	[IteratorStateMachine(typeof(_003CyInitialize_003Ed__45))]
	private IEnumerator yInitialize()
	{
		return null;
	}

	[Token(Token = "0x6002674")]
	[Address(RVA = "0x692FC0", Offset = "0x6921C0", VA = "0x180692FC0")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6002675")]
	[Address(RVA = "0x691E30", Offset = "0x691030", VA = "0x180691E30")]
	private void InitializeData()
	{
	}

	[Token(Token = "0x6002676")]
	[Address(RVA = "0x693B30", Offset = "0x692D30", VA = "0x180693B30")]
	private void Update()
	{
	}

	[Token(Token = "0x6002677")]
	[Address(RVA = "0x694110", Offset = "0x693310", VA = "0x180694110")]
	private string formatPathName(string path)
	{
		return null;
	}

	[Token(Token = "0x6002678")]
	[Address(RVA = "0x690A90", Offset = "0x68FC90", VA = "0x180690A90")]
	private void ActionHorizonTab(int index, bool isClick)
	{
	}

	[Token(Token = "0x6002679")]
	[Address(RVA = "0x690FB0", Offset = "0x6901B0", VA = "0x180690FB0")]
	private void ActionSubTab(int listIndex, bool isClick, int listSectionIndex, [Optional] Action onCompleted)
	{
	}

	[Token(Token = "0x600267A")]
	[Address(RVA = "0x693A70", Offset = "0x692C70", VA = "0x180693A70")]
	[IteratorStateMachine(typeof(_003CUpdateView_003Ed__52))]
	private IEnumerator UpdateView(bool isClick = false, bool isHorizonTab = false, [Optional] Action onCompleted, bool isFirst = false, bool isUpdateOnly = false)
	{
		return null;
	}

	[Token(Token = "0x600267B")]
	[Address(RVA = "0x692650", Offset = "0x691850", VA = "0x180692650", Slot = "13")]
	public override bool OnBack()
	{
		return default(bool);
	}

	[Token(Token = "0x600267C")]
	[Address(RVA = "0x693410", Offset = "0x692610", VA = "0x180693410")]
	private bool TrySelectContent(bool isNotCallSE = false)
	{
		return default(bool);
	}

	[Token(Token = "0x600267D")]
	[Address(RVA = "0x6932D0", Offset = "0x6924D0", VA = "0x1806932D0")]
	public bool SelectSubTabList(bool isNotCallSE = false)
	{
		return default(bool);
	}

	[Token(Token = "0x600267E")]
	[Address(RVA = "0x693660", Offset = "0x692860", VA = "0x180693660")]
	public bool TrySelectHorizonTab(bool onBack = false)
	{
		return default(bool);
	}

	[Token(Token = "0x600267F")]
	[Address(RVA = "0x691D80", Offset = "0x690F80", VA = "0x180691D80")]
	private ViewControllerManager GetContentManager()
	{
		return null;
	}

	[Token(Token = "0x6002680")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60")]
	private void CloseAcordion()
	{
	}

	[Token(Token = "0x6002681")]
	[Address(RVA = "0x692C90", Offset = "0x691E90", VA = "0x180692C90")]
	private void OnClickSubCategory(int dataIdx)
	{
	}

	[Token(Token = "0x6002682")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60")]
	private void OnClickSubCategoryGroup(int dataIdx)
	{
	}

	[Token(Token = "0x6002683")]
	[Address(RVA = "0x692B30", Offset = "0x691D30", VA = "0x180692B30")]
	private void OnClickSubCategorySection(int dataIdx, int sectionIdx)
	{
	}

	[Token(Token = "0x6002684")]
	[Address(RVA = "0x693090", Offset = "0x692290", VA = "0x180693090")]
	private void OnPrechangeSubTabIdx(int preSubTabIdx, int preSubTabSectionIdx, int newSubTabIdx, int newSubTabSectionIdx)
	{
	}

	[Token(Token = "0x6002685")]
	[Address(RVA = "0x6928C0", Offset = "0x691AC0", VA = "0x1806928C0")]
	private void OnChangedSubTabIdx(int idx, int sectionIdx)
	{
	}

	[Token(Token = "0x6002686")]
	[Address(RVA = "0x692A60", Offset = "0x691C60", VA = "0x180692A60")]
	private void OnClickHorizonTab(int horizonIndex)
	{
	}

	[Token(Token = "0x6002687")]
	[Address(RVA = "0x693080", Offset = "0x692280", VA = "0x180693080")]
	private void OnPrechangeHorizonTabIdx(int preSubTabIdx, int newSubTabIdx)
	{
	}

	[Token(Token = "0x6002688")]
	[Address(RVA = "0x6927B0", Offset = "0x6919B0", VA = "0x1806927B0")]
	private void OnChangedHorizonTabIdx(int idx)
	{
	}

	[Token(Token = "0x6002689")]
	[Address(RVA = "0x694060", Offset = "0x693260", VA = "0x180694060")]
	public MultiVCTabController()
	{
	}
}
