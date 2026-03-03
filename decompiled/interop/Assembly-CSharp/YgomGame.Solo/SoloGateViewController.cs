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
using YgomSystem.UI.InfinityScroll;

namespace YgomGame.Solo;

[Token(Token = "0x2000895")]
public class SoloGateViewController : BaseMenuViewController, IDynamicChangeDispHeaderSupported
{
	[Token(Token = "0x2000896")]
	private class LoadThumbChecker
	{
		[Token(Token = "0x2000897")]
		[CompilerGenerated]
		private sealed class _003CWaitLoadThumb_003Ed__3 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400872C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x400872D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x400872E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private bool _003Cinitialized_003E5__2;

			[Token(Token = "0x1700066E")]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
			{
				[Token(Token = "0x600341D")]
				[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700066F")]
			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[Token(Token = "0x600341F")]
				[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600341A")]
			[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
			[DebuggerHidden]
			public _003CWaitLoadThumb_003Ed__3(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x600341B")]
			[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			[Token(Token = "0x600341C")]
			[Address(RVA = "0x77BBE0", Offset = "0x77ADE0", VA = "0x18077BBE0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600341E")]
			[Address(RVA = "0x77BD50", Offset = "0x77AF50", VA = "0x18077BD50", Slot = "8")]
			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}
		}

		[Token(Token = "0x4008729")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static Action loadedCallback;

		[Token(Token = "0x400872A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static bool[] isInitializedThumb;

		[Token(Token = "0x400872B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static Coroutine doing;

		[Token(Token = "0x6003417")]
		[Address(RVA = "0x768F40", Offset = "0x768140", VA = "0x180768F40")]
		[IteratorStateMachine(typeof(_003CWaitLoadThumb_003Ed__3))]
		public static IEnumerator WaitLoadThumb()
		{
			return null;
		}

		[Token(Token = "0x6003418")]
		[Address(RVA = "0x768E70", Offset = "0x768070", VA = "0x180768E70")]
		public static void Reset()
		{
		}

		[Token(Token = "0x6003419")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public LoadThumbChecker()
		{
		}
	}

	[Token(Token = "0x20008A0")]
	[CompilerGenerated]
	private sealed class _003CDirectOpenSubgate_003Ed__73 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4008743")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4008744")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4008745")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public SoloGateViewController _003C_003E4__this;

		[Token(Token = "0x4008746")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public int gateId;

		[Token(Token = "0x17000670")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6003439")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000671")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600343B")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6003436")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CDirectOpenSubgate_003Ed__73(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6003437")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6003438")]
		[Address(RVA = "0x7789F0", Offset = "0x777BF0", VA = "0x1807789F0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600343A")]
		[Address(RVA = "0x778CE0", Offset = "0x777EE0", VA = "0x180778CE0", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x20008A1")]
	[CompilerGenerated]
	private sealed class _003CyMovePage_003Ed__86 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4008747")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4008748")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4008749")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public InfinityScrollView isv;

		[Token(Token = "0x400874A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public int targetIndex;

		[Token(Token = "0x400874B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Action onComplete;

		[Token(Token = "0x17000672")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x600343F")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000673")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6003441")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600343C")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CyMovePage_003Ed__86(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x600343D")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x600343E")]
		[Address(RVA = "0x77BD90", Offset = "0x77AF90", VA = "0x18077BD90", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6003440")]
		[Address(RVA = "0x77BFB0", Offset = "0x77B1B0", VA = "0x18077BFB0", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x40086ED")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	private readonly string SCROLL_LABEL;

	[Token(Token = "0x40086EE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	private readonly string SCROLL_SUB_LABEL;

	[Token(Token = "0x40086EF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	private readonly string ROOT_VIEW_LABEL;

	[Token(Token = "0x40086F0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	private readonly string ROOT_SUBGATE_LABEL;

	[Token(Token = "0x40086F1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	private readonly string TXT_GATENAME_LABEL;

	[Token(Token = "0x40086F2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	private readonly string TXT_CLEAR_LABEL;

	[Token(Token = "0x40086F3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
	private readonly string TXT_CONDITIONS_LABEL;

	[Token(Token = "0x40086F4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
	private readonly string TXT_COMPLETE_LABEL;

	[Token(Token = "0x40086F5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
	private readonly string TXT_OVERVIEW_LABEL;

	[Token(Token = "0x40086F6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
	private readonly string IMG_LOCK_LABEL;

	[Token(Token = "0x40086F7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
	private readonly string IMG_GATE_LABEL;

	[Token(Token = "0x40086F8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
	private readonly string IMG_GATE_LOCK_LABEL;

	[Token(Token = "0x40086F9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
	private readonly string IMG_BADGE_LABEL;

	[Token(Token = "0x40086FA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
	private readonly string BTN_LABEL;

	[Token(Token = "0x40086FB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
	private readonly string E_FilterAndSortArea;

	[Token(Token = "0x40086FC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
	private readonly string E_ClearButton;

	[Token(Token = "0x40086FD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
	private readonly string E_FilterButton;

	[Token(Token = "0x40086FE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
	private readonly string E_SortButton;

	[Token(Token = "0x40086FF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
	private readonly string E_TextEmpty;

	[Token(Token = "0x4008700")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
	private readonly string E_TextEmptySub;

	[Token(Token = "0x4008701")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
	private readonly string OBJ_THUMBCONTAINER_LABEL;

	[Token(Token = "0x4008702")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
	private readonly string IMG_ANIME_LABEL;

	[Token(Token = "0x4008703")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
	private readonly string IMG_VOICE_LABEL;

	[Token(Token = "0x4008704")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
	private readonly string IMG_SHADE_LABEL;

	[Token(Token = "0x4008705")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
	private readonly string BTN_PARENTGATE_LABEL;

	[Token(Token = "0x4008706")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
	private readonly string IMG_ANIMEGATE_THUMB_LABEL;

	[Token(Token = "0x4008707")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
	private readonly string TXT_GATELISTTITLE_LABEL;

	[Token(Token = "0x4008708")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
	private readonly string SE_CLICKED_NOCHILD_LABEL;

	[Token(Token = "0x4008709")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1B0")]
	private readonly string SE_CLICKED_HASCHILD_LABEL;

	[Token(Token = "0x400870A")]
	public const string BGM_TUTORIAL = "BGM_TUTORIAL_01";

	[Token(Token = "0x400870B")]
	public const string BGM_SOLO = "BGM_SOLO_GATE";

	[Token(Token = "0x400870C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1B8")]
	private SoloGateUtil.GateManager m_GateManager;

	[Token(Token = "0x400870D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C0")]
	private List<int> masterMainDataList;

	[Token(Token = "0x400870E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C8")]
	private List<int> mainDataList;

	[Token(Token = "0x400870F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1D0")]
	private List<int> masterSubDataList;

	[Token(Token = "0x4008710")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1D8")]
	private List<int> subDataList;

	[Token(Token = "0x4008711")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1E0")]
	private SoloGateUtil.Data expandGate;

	[Token(Token = "0x4008712")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1E8")]
	private InfinityScrollView mainScroll;

	[Token(Token = "0x4008713")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1F0")]
	private GameObject subScrollRoot;

	[Token(Token = "0x4008714")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1F8")]
	private InfinityScrollView subScroll;

	[Token(Token = "0x4008715")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x200")]
	private SoloFilterSortUtil.GateFilter currentGateFilter;

	[Token(Token = "0x4008716")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x204")]
	private SoloFilterSortUtil.GateSort currentGateSort;

	[Token(Token = "0x4008717")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x208")]
	private (int index, int id) currentMainGate;

	[Token(Token = "0x4008718")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x210")]
	private (int index, int id) currentSubGate;

	[Token(Token = "0x4008719")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x218")]
	private int currentGateID;

	[Token(Token = "0x400871A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x21C")]
	private int filterClusterGoThroughPriority;

	[Token(Token = "0x400871B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x220")]
	private Dictionary<int, GameObject> movieThumb;

	[Token(Token = "0x400871C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x228")]
	private Dictionary<int, Vector2> movieThumbSize;

	[Token(Token = "0x400871D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x230")]
	private Dictionary<string, object> m_FilterSortDic;

	[Token(Token = "0x400871E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x238")]
	private GameObject movieThumbObj;

	[Token(Token = "0x400871F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x240")]
	private string tmpPushLabel;

	[Token(Token = "0x4008720")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x248")]
	private string tmpSwapInLabel;

	[Token(Token = "0x4008721")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x250")]
	private RawImage rawImg;

	[Token(Token = "0x4008722")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x258")]
	private int rendererTextureId;

	[Token(Token = "0x4008723")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x25C")]
	private int m_Category;

	[Token(Token = "0x4008724")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x260")]
	private bool whileCloseSubscrollTween;

	[Token(Token = "0x4008725")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x261")]
	private bool isContinueTimelineMaking;

	[Token(Token = "0x4008726")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x262")]
	private bool isInitialzedMain;

	[Token(Token = "0x4008727")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x263")]
	private bool isInitialzedSub;

	[Token(Token = "0x4008728")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x264")]
	private bool isWhileTutorial;

	[Token(Token = "0x1700066B")]
	private string Key_FilterSaveCategory
	{
		[Token(Token = "0x60033ED")]
		[Address(RVA = "0x775690", Offset = "0x774890", VA = "0x180775690")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700066C")]
	public bool IsDispSubScroll
	{
		[Token(Token = "0x60033EE")]
		[Address(RVA = "0x775600", Offset = "0x774800", VA = "0x180775600")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700066D")]
	protected override Type[] textIds
	{
		[Token(Token = "0x60033EF")]
		[Address(RVA = "0x7756F0", Offset = "0x7748F0", VA = "0x1807756F0", Slot = "21")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60033F0")]
	[Address(RVA = "0x770CA0", Offset = "0x76FEA0", VA = "0x180770CA0", Slot = "6")]
	public override void NotificationStackEntry()
	{
	}

	[Token(Token = "0x60033F1")]
	[Address(RVA = "0x770EC0", Offset = "0x7700C0", VA = "0x180770EC0", Slot = "7")]
	public override void NotificationStackRemove()
	{
	}

	[Token(Token = "0x60033F2")]
	[Address(RVA = "0x7712C0", Offset = "0x7704C0", VA = "0x1807712C0", Slot = "23")]
	protected override void OnCreatedView()
	{
	}

	[Token(Token = "0x60033F3")]
	[Address(RVA = "0x772E10", Offset = "0x772010", VA = "0x180772E10")]
	private void Start()
	{
	}

	[Token(Token = "0x60033F4")]
	[Address(RVA = "0x773070", Offset = "0x772270", VA = "0x180773070", Slot = "11")]
	public override void TransitionStart(TransitionType type)
	{
	}

	[Token(Token = "0x60033F5")]
	[Address(RVA = "0x773270", Offset = "0x772470", VA = "0x180773270", Slot = "12")]
	public override bool TransitionUpdate(TransitionType type)
	{
		return default(bool);
	}

	[Token(Token = "0x60033F6")]
	[Address(RVA = "0x76F9F0", Offset = "0x76EBF0", VA = "0x18076F9F0")]
	[IteratorStateMachine(typeof(_003CDirectOpenSubgate_003Ed__73))]
	private IEnumerator DirectOpenSubgate(int gateId)
	{
		return null;
	}

	[Token(Token = "0x60033F7")]
	[Address(RVA = "0x7710D0", Offset = "0x7702D0", VA = "0x1807710D0", Slot = "13")]
	public override bool OnBack()
	{
		return default(bool);
	}

	[Token(Token = "0x60033F8")]
	[Address(RVA = "0x772CF0", Offset = "0x771EF0", VA = "0x180772CF0")]
	private void SetFilterCluster(bool isSet)
	{
	}

	[Token(Token = "0x60033F9")]
	[Address(RVA = "0x7729B0", Offset = "0x771BB0", VA = "0x1807729B0")]
	private void SetFilterAndSortBtnStatus()
	{
	}

	[Token(Token = "0x60033FA")]
	[Address(RVA = "0x76FA70", Offset = "0x76EC70", VA = "0x18076FA70")]
	private string GetSortName(SoloFilterSortUtil.GateSort gateSort)
	{
		return null;
	}

	[Token(Token = "0x60033FB")]
	[Address(RVA = "0x76FDE0", Offset = "0x76EFE0", VA = "0x18076FDE0")]
	private void InitFilter(ElementObjectManager filterEom, bool isTutorial = false)
	{
	}

	[Token(Token = "0x60033FC")]
	[Address(RVA = "0x76FF40", Offset = "0x76F140", VA = "0x18076FF40")]
	private void InitSort(ElementObjectManager filterEom)
	{
	}

	[Token(Token = "0x60033FD")]
	[Address(RVA = "0x76FD00", Offset = "0x76EF00", VA = "0x18076FD00")]
	private void InitDelete(ElementObjectManager filterEom)
	{
	}

	[Token(Token = "0x60033FE")]
	[Address(RVA = "0x773F60", Offset = "0x773160", VA = "0x180773F60")]
	private void UpdateScrollDataList()
	{
	}

	[Token(Token = "0x60033FF")]
	[Address(RVA = "0x773EE0", Offset = "0x7730E0", VA = "0x180773EE0")]
	private void UpdateFilteringContent(bool isReturnChapterMap = false)
	{
	}

	[Token(Token = "0x6003400")]
	[Address(RVA = "0x76F300", Offset = "0x76E500", VA = "0x18076F300")]
	private void CheckFilterResult(List<int> dataList, (int index, int id) currentGate, InfinityScrollView scrollView, bool isReturnChapterMap)
	{
	}

	[Token(Token = "0x6003401")]
	[Address(RVA = "0x774230", Offset = "0x773430", VA = "0x180774230")]
	private void UpdateView(SoloGateUtil.Data data)
	{
	}

	[Token(Token = "0x6003402")]
	[Address(RVA = "0x76FB80", Offset = "0x76ED80", VA = "0x18076FB80")]
	private void HideView(bool isHide = true)
	{
	}

	[Token(Token = "0x6003403")]
	[Address(RVA = "0x7757C0", Offset = "0x7749C0", VA = "0x1807757C0")]
	[IteratorStateMachine(typeof(_003CyMovePage_003Ed__86))]
	private IEnumerator yMovePage(InfinityScrollView isv, int targetIndex, [Optional] Action onComplete)
	{
		return null;
	}

	[Token(Token = "0x6003404")]
	[Address(RVA = "0x770020", Offset = "0x76F220", VA = "0x180770020")]
	private void InitializeScrollDataList()
	{
	}

	[Token(Token = "0x6003405")]
	[Address(RVA = "0x771210", Offset = "0x770410", VA = "0x180771210")]
	private void OnCreatedEntity(GameObject go)
	{
	}

	[Token(Token = "0x6003406")]
	[Address(RVA = "0x771A70", Offset = "0x770C70", VA = "0x180771A70")]
	public void OnItemSetDataMain(GameObject gob, int dataindex)
	{
	}

	[Token(Token = "0x6003407")]
	[Address(RVA = "0x7720B0", Offset = "0x7712B0", VA = "0x1807720B0")]
	public void OnItemSetDataSub(GameObject gob, int dataindex)
	{
	}

	[Token(Token = "0x6003408")]
	[Address(RVA = "0x7724A0", Offset = "0x7716A0", VA = "0x1807724A0")]
	private void OpenSubScroll(SoloGateUtil.Data data, bool isDirect = false)
	{
	}

	[Token(Token = "0x6003409")]
	[Address(RVA = "0x76F740", Offset = "0x76E940", VA = "0x18076F740")]
	private void CloseSubScroll()
	{
	}

	[Token(Token = "0x600340A")]
	[Address(RVA = "0x7707D0", Offset = "0x76F9D0", VA = "0x1807707D0")]
	private void LoadGateThumb(string path)
	{
	}

	[Token(Token = "0x600340B")]
	[Address(RVA = "0x770580", Offset = "0x76F780", VA = "0x180770580", Slot = "28")]
	public HeaderViewController.IsDispHeader IsDispContents()
	{
		return default(HeaderViewController.IsDispHeader);
	}

	[Token(Token = "0x600340C")]
	[Address(RVA = "0x774EB0", Offset = "0x7740B0", VA = "0x180774EB0")]
	public SoloGateViewController()
	{
	}
}
