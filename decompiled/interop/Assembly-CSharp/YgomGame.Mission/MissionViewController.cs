using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;
using YgomGame.Menu;
using YgomSystem.ElementSystem;
using YgomSystem.UI;
using YgomSystem.UI.ElementWidget;

namespace YgomGame.Mission;

[Token(Token = "0x2000BC5")]
public class MissionViewController : BaseMenuViewController, IBackButtonWithoutSCSupported, IBackButtonSupported, IHeaderBorderSupported
{
	[Token(Token = "0x2000BC6")]
	public enum MissionContentType
	{
		[Token(Token = "0x4009843")]
		Mission,
		[Token(Token = "0x4009844")]
		PanelMission
	}

	[Token(Token = "0x2000BC7")]
	private class Tab
	{
		[Token(Token = "0x4009845")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int tabId;

		[Token(Token = "0x4009846")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public ElementObjectManager tabEom;

		[Token(Token = "0x4009847")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public SelectionButton tabSb;

		[Token(Token = "0x4009848")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Action onClickAction;

		[Token(Token = "0x4009849")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public MissionContentType type;

		[Token(Token = "0x60047C7")]
		[Address(RVA = "0x90EA70", Offset = "0x90DC70", VA = "0x18090EA70")]
		public void SetClickAction()
		{
		}

		[Token(Token = "0x60047C8")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public Tab()
		{
		}
	}

	[Token(Token = "0x2000BC8")]
	private class LaunchException : Exception
	{
		[Token(Token = "0x60047CA")]
		[Address(RVA = "0x8FDA20", Offset = "0x8FCC20", VA = "0x1808FDA20")]
		public LaunchException(string message)
		{
		}
	}

	[Token(Token = "0x4009815")]
	internal const string k_PrefabPath = "Mission/Mission";

	[Token(Token = "0x4009816")]
	private const string k_CautionHelpPath = "mission/caution/caution";

	[Token(Token = "0x4009817")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	private readonly string k_ELabel_ContentArea;

	[Token(Token = "0x4009818")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	private readonly string k_ELabelButtonCaution;

	[Token(Token = "0x4009819")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	private readonly string k_ELabelTabArea;

	[Token(Token = "0x400981A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	private readonly string k_ELabelTabLeft;

	[Token(Token = "0x400981B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	private readonly string k_ELabelTabRight;

	[Token(Token = "0x400981C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	private readonly string k_ELabelTabGroup;

	[Token(Token = "0x400981D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
	private readonly string k_ELabelTabButton;

	[Token(Token = "0x400981E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
	private readonly string k_ELabelTabTemplateGroup;

	[Token(Token = "0x400981F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
	private readonly string k_ELabelBackButtonToTab;

	[Token(Token = "0x4009820")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
	private readonly string k_ELabelBGButton;

	[Token(Token = "0x4009821")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
	private readonly string k_ELabelBadgeBase;

	[Token(Token = "0x4009822")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
	private readonly string k_ELabelBadgeBaseAlert;

	[Token(Token = "0x4009823")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
	private readonly string k_ELabelNumBadge;

	[Token(Token = "0x4009824")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
	private readonly string k_ELabelNumBadgeText;

	[Token(Token = "0x4009825")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
	private readonly string k_ELabelTabMission;

	[Token(Token = "0x4009826")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
	private readonly string k_ELabelTabPanelMission;

	[Token(Token = "0x4009827")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
	private readonly string k_ELabelTabTextOn;

	[Token(Token = "0x4009828")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
	private readonly string k_ELabelTabTextOff;

	[Token(Token = "0x4009829")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
	private readonly string k_ELabelImageOn;

	[Token(Token = "0x400982A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
	private readonly string k_ELabelImageOff;

	[Token(Token = "0x400982B")]
	private const string k_ArgKey_OpenContentType = "openContentType";

	[Token(Token = "0x400982C")]
	private const string k_ArgKey_PoolId = "poolId";

	[Token(Token = "0x400982D")]
	private const string k_ArgKey_OnClosed = "onClosed";

	[Token(Token = "0x400982E")]
	private const string k_ArgKey_SubTabId = "tabId";

	[Token(Token = "0x400982F")]
	private const string k_ArgKey_OnlyMission = "onlyMission";

	[Token(Token = "0x4009830")]
	private const string k_ArgKey_FromDuelMenu = "fromDuelMenu";

	[Token(Token = "0x4009831")]
	private const string k_ArgKey_DoneOpenRequest = "doneOpenRequest";

	[Token(Token = "0x4009832")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
	private bool m_OnlyMission;

	[Token(Token = "0x4009833")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x171")]
	private bool m_DoneEntryTransition;

	[Token(Token = "0x4009834")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
	private IEnumerator m_InitializeRoutine;

	[Token(Token = "0x4009835")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
	private MissionContentType m_ContentType;

	[Token(Token = "0x4009836")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x184")]
	private bool onCompleteInitialize;

	[Token(Token = "0x4009837")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x185")]
	private bool refreshBadge;

	[Token(Token = "0x4009838")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x186")]
	private bool changeMouseToPad;

	[Token(Token = "0x4009839")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x187")]
	private bool isLRMove;

	[Token(Token = "0x400983A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
	private GameObject tabTemplate;

	[Token(Token = "0x400983B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
	private Selector tabAreaSelector;

	[Token(Token = "0x400983C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
	private ElementObjectManager tabAreaEom;

	[Token(Token = "0x400983D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
	private DirectionalTabGroup tabGroup;

	[Token(Token = "0x400983E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
	private List<Tab> mainTabs;

	[Token(Token = "0x400983F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1B0")]
	private List<string> k_ELabelTabList;

	[Token(Token = "0x4009840")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1B8")]
	private SelectionButton onClickSb;

	[Token(Token = "0x4009841")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C0")]
	private Dictionary<MissionContentType, IMissionContent> m_ContentMap;

	[Token(Token = "0x170009AD")]
	protected override bool setSurfaceActiveOnInitialize
	{
		[Token(Token = "0x60047A7")]
		[Address(RVA = "0x404830", Offset = "0x403A30", VA = "0x180404830", Slot = "17")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170009AE")]
	protected override bool setProgressOnInitialize
	{
		[Token(Token = "0x60047A8")]
		[Address(RVA = "0x404830", Offset = "0x403A30", VA = "0x180404830", Slot = "18")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170009AF")]
	protected override int selectorPriorityAddRange
	{
		[Token(Token = "0x60047A9")]
		[Address(RVA = "0x4B8E10", Offset = "0x4B8010", VA = "0x1804B8E10", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x170009B0")]
	protected override Type[] textIds
	{
		[Token(Token = "0x60047AA")]
		[Address(RVA = "0x902C30", Offset = "0x901E30", VA = "0x180902C30", Slot = "21")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170009B1")]
	private IMissionContent currentContent
	{
		[Token(Token = "0x60047AB")]
		[Address(RVA = "0x902BE0", Offset = "0x901DE0", VA = "0x180902BE0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60047A2")]
	[Address(RVA = "0x900340", Offset = "0x8FF540", VA = "0x180900340")]
	public static void OpenPanelMission(int poolId, bool skipCheckLaunch = false, [Optional] Action onSuccess, [Optional] Action onFailed, [Optional] Action onClosed, bool disableErrorNotify = false, bool openOnHome = false, bool isForceLaunch = false, [Optional] Dictionary<string, object> args, bool isSkipPushVC = false, [Optional] Action tabInitialEntry)
	{
	}

	[Token(Token = "0x60047A3")]
	[Address(RVA = "0x901A50", Offset = "0x900C50", VA = "0x180901A50")]
	public void SetPanelMissionArgs(IMissionContent content, int poolId)
	{
	}

	[Token(Token = "0x60047A4")]
	[Address(RVA = "0x8FDD80", Offset = "0x8FCF80", VA = "0x1808FDD80")]
	public int GetPanelMissionPoolId()
	{
		return default(int);
	}

	[Token(Token = "0x60047A5")]
	[Address(RVA = "0x9006C0", Offset = "0x8FF8C0", VA = "0x1809006C0")]
	public static void OpenResidentMission(int tabId = 0, int poolId = 0, bool isOnlyMission = true, bool openOnHome = false, bool fromDuelMenu = false, bool doneOpenRequest = false)
	{
	}

	[Token(Token = "0x60047A6")]
	[Address(RVA = "0x901B60", Offset = "0x900D60", VA = "0x180901B60")]
	public void SetResidentMissionArgs(IMissionContent content, int poolId)
	{
	}

	[Token(Token = "0x60047AC")]
	[Address(RVA = "0x8FFFC0", Offset = "0x8FF1C0", VA = "0x1808FFFC0", Slot = "8")]
	public override void NotificationStack(ViewControllerManager vcm, ViewController vc, bool isEntry)
	{
	}

	[Token(Token = "0x60047AD")]
	[Address(RVA = "0x8FF080", Offset = "0x8FE280", VA = "0x1808FF080", Slot = "6")]
	public override void NotificationStackEntry()
	{
	}

	[Token(Token = "0x60047AE")]
	[Address(RVA = "0x8FFDF0", Offset = "0x8FEFF0", VA = "0x1808FFDF0", Slot = "7")]
	public override void NotificationStackRemove()
	{
	}

	[Token(Token = "0x60047AF")]
	[Address(RVA = "0x9007F0", Offset = "0x8FF9F0", VA = "0x1809007F0", Slot = "10")]
	public override void ProgressUpdate()
	{
	}

	[Token(Token = "0x60047B0")]
	[Address(RVA = "0x902000", Offset = "0x901200", VA = "0x180902000", Slot = "11")]
	public override void TransitionStart(TransitionType type)
	{
	}

	[Token(Token = "0x60047B1")]
	[Address(RVA = "0x902640", Offset = "0x901840", VA = "0x180902640")]
	private void Update()
	{
	}

	[Token(Token = "0x60047B2")]
	[Address(RVA = "0x8FFFD0", Offset = "0x8FF1D0", VA = "0x1808FFFD0", Slot = "23")]
	protected override void OnCreatedView()
	{
	}

	[Token(Token = "0x60047B3")]
	[Address(RVA = "0x8FDF90", Offset = "0x8FD190", VA = "0x1808FDF90")]
	private void Initialize()
	{
	}

	[Token(Token = "0x60047B4")]
	[Address(RVA = "0x9019D0", Offset = "0x900BD0", VA = "0x1809019D0")]
	private void SetActiveOpenTab(ElementObjectManager eom, bool active)
	{
	}

	[Token(Token = "0x60047B5")]
	[Address(RVA = "0x901E80", Offset = "0x901080", VA = "0x180901E80")]
	private void TabTransition(int number, bool isSelectTab = true)
	{
	}

	[Token(Token = "0x60047B6")]
	[Address(RVA = "0x8FDCA0", Offset = "0x8FCEA0", VA = "0x1808FDCA0")]
	private void ButtonSetting(SelectionButton sb, SelectorManager.KeyType keyType, UnityAction action)
	{
	}

	[Token(Token = "0x60047B7")]
	[Address(RVA = "0x8FDD00", Offset = "0x8FCF00", VA = "0x1808FDD00")]
	private bool CanMoveTab(int nowId, int transitionNumber)
	{
		return default(bool);
	}

	[Token(Token = "0x60047B8")]
	[Address(RVA = "0x9024C0", Offset = "0x9016C0", VA = "0x1809024C0")]
	private void UpdateBadge(ElementObjectManager tabEom, int num)
	{
	}

	[Token(Token = "0x60047B9")]
	[Address(RVA = "0x9008C0", Offset = "0x8FFAC0", VA = "0x1809008C0")]
	private void RefreshBadge(MissionContentType type)
	{
	}

	[Token(Token = "0x60047BA")]
	[Address(RVA = "0x9011E0", Offset = "0x9003E0", VA = "0x1809011E0")]
	private void RefreshContent(bool isSelectTab = true)
	{
	}

	[Token(Token = "0x60047BB")]
	[Address(RVA = "0x901C70", Offset = "0x900E70", VA = "0x180901C70")]
	public void TabInitialEntry(bool isSelectTab)
	{
	}

	[Token(Token = "0x60047BC")]
	[Address(RVA = "0x9002A0", Offset = "0x8FF4A0", VA = "0x1809002A0")]
	private void SelectCurrentTab()
	{
	}

	[Token(Token = "0x60047BD")]
	[Address(RVA = "0x4B6FD0", Offset = "0x4B61D0", VA = "0x1804B6FD0")]
	private void OnRequestedPopVC()
	{
	}

	[Token(Token = "0x60047BE")]
	[Address(RVA = "0x900280", Offset = "0x8FF480", VA = "0x180900280")]
	private void OnRequestedRefreshBadge()
	{
	}

	[Token(Token = "0x60047BF")]
	[Address(RVA = "0x900150", Offset = "0x8FF350", VA = "0x180900150")]
	private void OnRequestedClickContent(SelectionButton sb)
	{
	}

	[Token(Token = "0x60047C0")]
	[Address(RVA = "0x9002A0", Offset = "0x8FF4A0", VA = "0x1809002A0")]
	private void OnRequestedTopPanelTransition()
	{
	}

	[Token(Token = "0x60047C1")]
	[Address(RVA = "0x902740", Offset = "0x901940", VA = "0x180902740")]
	public MissionViewController()
	{
	}
}
