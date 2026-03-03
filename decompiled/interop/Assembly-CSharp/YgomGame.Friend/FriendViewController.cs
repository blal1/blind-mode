using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using YgomGame.Menu;
using YgomSystem.ElementSystem;
using YgomSystem.Network;
using YgomSystem.UI;
using YgomSystem.UI.ElementWidget;

namespace YgomGame.Friend;

[Token(Token = "0x2000DCA")]
public class FriendViewController : BaseBlurOverlayViewController
{
	[Token(Token = "0x2000DCB")]
	private enum PlayerActionSheetEntry
	{
		[Token(Token = "0x400A0A7")]
		None = 0,
		[Token(Token = "0x400A0A8")]
		Profile = 2,
		[Token(Token = "0x400A0A9")]
		Pin = 4,
		[Token(Token = "0x400A0AA")]
		Audience = 8,
		[Token(Token = "0x400A0AB")]
		Duel = 0x10,
		[Token(Token = "0x400A0AC")]
		Block = 0x20
	}

	[Token(Token = "0x2000DCE")]
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass60_0
	{
		[Token(Token = "0x400A0B8")]
		[FieldOffset(Offset = "0x10")]
		public bool readyGetListAPI;

		[Token(Token = "0x400A0B9")]
		[FieldOffset(Offset = "0x11")]
		public bool reaqdyRefreshFollowerAPI;

		[Token(Token = "0x6005330")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public _003C_003Ec__DisplayClass60_0()
		{
		}

		[Token(Token = "0x6005331")]
		[Address(RVA = "0x9B03A0", Offset = "0x9AF5A0", VA = "0x1809B03A0")]
		internal void _003CResumeBySuspend_003Eb__0(Handle handle)
		{
		}

		[Token(Token = "0x6005332")]
		[Address(RVA = "0x4658A0", Offset = "0x464AA0", VA = "0x1804658A0")]
		internal void _003CResumeBySuspend_003Eb__1()
		{
		}
	}

	[Token(Token = "0x2000DD9")]
	[CompilerGenerated]
	private sealed class _003CResumeBySuspend_003Ed__60 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400A0CE")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400A0CF")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400A0D0")]
		[FieldOffset(Offset = "0x20")]
		public FriendViewController _003C_003E4__this;

		[Token(Token = "0x400A0D1")]
		[FieldOffset(Offset = "0x28")]
		private _003C_003Ec__DisplayClass60_0 _003C_003E8__1;

		[Token(Token = "0x17000C2F")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x600534B")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000C30")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600534D")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6005348")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CResumeBySuspend_003Ed__60(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6005349")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x600534A")]
		[Address(RVA = "0x9ADCF0", Offset = "0x9ACEF0", VA = "0x1809ADCF0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600534C")]
		[Address(RVA = "0x9AE0D0", Offset = "0x9AD2D0", VA = "0x1809AE0D0", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x400A070")]
	[FieldOffset(Offset = "0xD8")]
	private readonly string k_FriendActionSheetIcon;

	[Token(Token = "0x400A071")]
	[FieldOffset(Offset = "0xE0")]
	private readonly string k_OVGroupLabel_Default;

	[Token(Token = "0x400A072")]
	[FieldOffset(Offset = "0xE8")]
	private readonly string k_OVGroupLabel_Campaign;

	[Token(Token = "0x400A073")]
	[FieldOffset(Offset = "0xF0")]
	private readonly string k_ELabelBackButton;

	[Token(Token = "0x400A074")]
	[FieldOffset(Offset = "0xF8")]
	private readonly string k_ELabelCancelButton;

	[Token(Token = "0x400A075")]
	[FieldOffset(Offset = "0x100")]
	private readonly string k_ELabelFollowRoot;

	[Token(Token = "0x400A076")]
	[FieldOffset(Offset = "0x108")]
	private readonly string k_ELabelFriendSearchButton;

	[Token(Token = "0x400A077")]
	[FieldOffset(Offset = "0x110")]
	private readonly string k_ELabelFollowNumText;

	[Token(Token = "0x400A078")]
	[FieldOffset(Offset = "0x118")]
	private readonly string k_ELabelFollowToggle;

	[Token(Token = "0x400A079")]
	[FieldOffset(Offset = "0x120")]
	private readonly string k_ELabelFollowList;

	[Token(Token = "0x400A07A")]
	[FieldOffset(Offset = "0x128")]
	private readonly string k_ELabelFollowCPButtonAreaBase;

	[Token(Token = "0x400A07B")]
	[FieldOffset(Offset = "0x130")]
	private readonly string k_ELabelFollowCPButton;

	[Token(Token = "0x400A07C")]
	[FieldOffset(Offset = "0x138")]
	private readonly string k_ELabelFollowCPText;

	[Token(Token = "0x400A07D")]
	[FieldOffset(Offset = "0x140")]
	private readonly string k_ELabelFollowCPBadge;

	[Token(Token = "0x400A07E")]
	[FieldOffset(Offset = "0x148")]
	private readonly string k_ELabelFollowBasicForm;

	[Token(Token = "0x400A07F")]
	[FieldOffset(Offset = "0x150")]
	private readonly string k_ELabelFollowerRoot;

	[Token(Token = "0x400A080")]
	[FieldOffset(Offset = "0x158")]
	private readonly string k_ELabelFollowerToggle;

	[Token(Token = "0x400A081")]
	[FieldOffset(Offset = "0x160")]
	private readonly string k_ELabelFollowerList;

	[Token(Token = "0x400A082")]
	[FieldOffset(Offset = "0x168")]
	private readonly string k_ELabelFollowerHeadLoadingIcon;

	[Token(Token = "0x400A083")]
	[FieldOffset(Offset = "0x170")]
	private readonly string k_ELabelFollowerTailLoadingIcon;

	[Token(Token = "0x400A084")]
	[FieldOffset(Offset = "0x178")]
	private readonly string k_ELabelBlockRoot;

	[Token(Token = "0x400A085")]
	[FieldOffset(Offset = "0x180")]
	private readonly string k_ELabelBlockToggle;

	[Token(Token = "0x400A086")]
	[FieldOffset(Offset = "0x188")]
	private readonly string k_ELabelBlockList;

	[Token(Token = "0x400A087")]
	[FieldOffset(Offset = "0x190")]
	private readonly string k_ASArgsFriendActionPcode;

	[Token(Token = "0x400A088")]
	[FieldOffset(Offset = "0x198")]
	private readonly string k_ASLabelAudience;

	[Token(Token = "0x400A089")]
	[FieldOffset(Offset = "0x1A0")]
	private readonly string k_ASLabelDuel;

	[Token(Token = "0x400A08A")]
	[FieldOffset(Offset = "0x1A8")]
	private readonly string k_TweenToOpen;

	[Token(Token = "0x400A08B")]
	[FieldOffset(Offset = "0x1B0")]
	private readonly string k_TweenListToClose;

	[Token(Token = "0x400A08C")]
	[FieldOffset(Offset = "0x1B8")]
	private int m_CurrentInvitationId;

	[Token(Token = "0x400A08D")]
	[FieldOffset(Offset = "0x1C0")]
	private ElementObjectManager m_FriendActionSheetIconPref;

	[Token(Token = "0x400A08E")]
	[FieldOffset(Offset = "0x1C8")]
	private FriendDefinitionSetting m_FriendDefinitionSetting;

	[Token(Token = "0x400A08F")]
	[FieldOffset(Offset = "0x1D0")]
	private GameObject m_FollowRoot;

	[Token(Token = "0x400A090")]
	[FieldOffset(Offset = "0x1D8")]
	private ToggleWidget m_FollowToggle;

	[Token(Token = "0x400A091")]
	[FieldOffset(Offset = "0x1E0")]
	private FriendListWidget m_FollowListWidget;

	[Token(Token = "0x400A092")]
	[FieldOffset(Offset = "0x1E8")]
	private TMP_Text m_FollowNumText;

	[Token(Token = "0x400A093")]
	[FieldOffset(Offset = "0x1F0")]
	private Selector m_FollowInnerSelector;

	[Token(Token = "0x400A094")]
	[FieldOffset(Offset = "0x1F8")]
	private GameObject m_FollowerRoot;

	[Token(Token = "0x400A095")]
	[FieldOffset(Offset = "0x200")]
	private ToggleWidget m_FollowerToggle;

	[Token(Token = "0x400A096")]
	[FieldOffset(Offset = "0x208")]
	private FriendListWidget m_FollowerListWidget;

	[Token(Token = "0x400A097")]
	[FieldOffset(Offset = "0x210")]
	private GameObject m_BlockRoot;

	[Token(Token = "0x400A098")]
	[FieldOffset(Offset = "0x218")]
	private ToggleWidget m_BlockToggle;

	[Token(Token = "0x400A099")]
	[FieldOffset(Offset = "0x220")]
	private FriendListWidget m_BlockListWidget;

	[Token(Token = "0x400A09A")]
	[FieldOffset(Offset = "0x228")]
	private bool m_IsReady;

	[Token(Token = "0x400A09B")]
	[FieldOffset(Offset = "0x229")]
	private bool m_IsInitializedFollowerList;

	[Token(Token = "0x400A09C")]
	[FieldOffset(Offset = "0x22A")]
	private bool m_IsInitializedBlockList;

	[Token(Token = "0x400A09D")]
	[FieldOffset(Offset = "0x230")]
	private FollowContextCollection m_FollowContexts;

	[Token(Token = "0x400A09E")]
	[FieldOffset(Offset = "0x238")]
	private FollowerContextCollection m_FollowerContexts;

	[Token(Token = "0x400A09F")]
	[FieldOffset(Offset = "0x240")]
	private BlockContextCollection m_BlockContexts;

	[Token(Token = "0x400A0A0")]
	[FieldOffset(Offset = "0x248")]
	private bool m_Quite;

	[Token(Token = "0x400A0A1")]
	[FieldOffset(Offset = "0x249")]
	private bool m_IsSuspended;

	[Token(Token = "0x400A0A2")]
	[FieldOffset(Offset = "0x24C")]
	private float m_PollingTimer;

	[Token(Token = "0x400A0A3")]
	[FieldOffset(Offset = "0x250")]
	private float m_PollingSpan;

	[Token(Token = "0x400A0A4")]
	[FieldOffset(Offset = "0x258")]
	private List<long> m_SearchDisplayPcodeList;

	[Token(Token = "0x400A0A5")]
	[FieldOffset(Offset = "0x260")]
	private bool m_IsAbortPolling;

	[Token(Token = "0x17000C2D")]
	protected override bool supportedVCStacking
	{
		[Token(Token = "0x60052F0")]
		[Address(RVA = "0x404830", Offset = "0x403A30", VA = "0x180404830", Slot = "29")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000C2E")]
	protected override Type[] textIds
	{
		[Token(Token = "0x60052F1")]
		[Address(RVA = "0x986B30", Offset = "0x985D30", VA = "0x180986B30", Slot = "21")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60052F2")]
	[Address(RVA = "0x981A60", Offset = "0x980C60", VA = "0x180981A60", Slot = "6")]
	public override void NotificationStackEntry()
	{
	}

	[Token(Token = "0x60052F3")]
	[Address(RVA = "0x985100", Offset = "0x984300", VA = "0x180985100")]
	private void RefreshFollowBasicForm()
	{
	}

	[Token(Token = "0x60052F4")]
	[Address(RVA = "0x982AC0", Offset = "0x981CC0", VA = "0x180982AC0", Slot = "23")]
	protected override void OnCreatedView()
	{
	}

	[Token(Token = "0x60052F5")]
	[Address(RVA = "0x985540", Offset = "0x984740", VA = "0x180985540")]
	private void Start()
	{
	}

	[Token(Token = "0x60052F6")]
	[Address(RVA = "0x981CC0", Offset = "0x980EC0", VA = "0x180981CC0", Slot = "8")]
	public override void NotificationStack(ViewControllerManager vcm, ViewController vc, bool isEntry)
	{
	}

	[Token(Token = "0x60052F7")]
	[Address(RVA = "0x9854D0", Offset = "0x9846D0", VA = "0x1809854D0")]
	[IteratorStateMachine(typeof(_003CResumeBySuspend_003Ed__60))]
	private IEnumerator ResumeBySuspend()
	{
		return null;
	}

	[Token(Token = "0x60052F8")]
	[Address(RVA = "0x986080", Offset = "0x985280", VA = "0x180986080")]
	private void Update()
	{
	}

	[Token(Token = "0x60052F9")]
	[Address(RVA = "0x9819C0", Offset = "0x980BC0", VA = "0x1809819C0")]
	private bool HandlePollingError(Handle handle, bool asPolling)
	{
		return default(bool);
	}

	[Token(Token = "0x60052FA")]
	[Address(RVA = "0x985360", Offset = "0x984560", VA = "0x180985360")]
	private void RequestRefreshInfoAPI(long[] refreshPcodes, bool asPolling, Action onComplete)
	{
	}

	[Token(Token = "0x60052FB")]
	[Address(RVA = "0x980C10", Offset = "0x97FE10", VA = "0x180980C10")]
	private void ApplyRefreshInfo(bool skipListWidgetUpdate = false)
	{
	}

	[Token(Token = "0x60052FC")]
	[Address(RVA = "0x9843E0", Offset = "0x9835E0", VA = "0x1809843E0")]
	private void OpenPlayerActionSheet(IPlayerContext player, PlayerActionSheetEntry visibleFlags)
	{
	}

	[Token(Token = "0x60052FD")]
	[Address(RVA = "0x985040", Offset = "0x984240", VA = "0x180985040")]
	private void PlayToOpen(GameObject target)
	{
	}

	[Token(Token = "0x60052FE")]
	[Address(RVA = "0x984F80", Offset = "0x984180", VA = "0x180984F80")]
	private void PlayToClose(GameObject target)
	{
	}

	[Token(Token = "0x60052FF")]
	[Address(RVA = "0x984F00", Offset = "0x984100", VA = "0x180984F00")]
	private void PlayFollowerLoadingIcon(bool isHead)
	{
	}

	[Token(Token = "0x6005300")]
	[Address(RVA = "0x985980", Offset = "0x984B80", VA = "0x180985980")]
	private void StopFollowerLoadingIcon(bool isHead)
	{
	}

	[Token(Token = "0x6005301")]
	[Address(RVA = "0x983F00", Offset = "0x983100", VA = "0x180983F00")]
	private void OnInputDownFollowToggle()
	{
	}

	[Token(Token = "0x6005302")]
	[Address(RVA = "0x983EA0", Offset = "0x9830A0", VA = "0x180983EA0")]
	private void OnInputDownFollowCPButton()
	{
	}

	[Token(Token = "0x6005303")]
	[Address(RVA = "0x983650", Offset = "0x982850", VA = "0x180983650")]
	private void OnFollowToggleChange(bool isOn)
	{
	}

	[Token(Token = "0x6005304")]
	[Address(RVA = "0x983DF0", Offset = "0x982FF0", VA = "0x180983DF0")]
	private void OnFollowerToggleChange(bool isOn)
	{
	}

	[Token(Token = "0x6005305")]
	[Address(RVA = "0x981F70", Offset = "0x981170", VA = "0x180981F70")]
	private void OnBlockToggleChange(bool isOn)
	{
	}

	[Token(Token = "0x6005306")]
	[Address(RVA = "0x981E80", Offset = "0x981080", VA = "0x180981E80")]
	private void OnActiveToggleChange(int toggleIdx, bool isOn)
	{
	}

	[Token(Token = "0x6005307")]
	[Address(RVA = "0x983920", Offset = "0x982B20", VA = "0x180983920")]
	private void OnFollowerReachScrollHead()
	{
	}

	[Token(Token = "0x6005308")]
	[Address(RVA = "0x983BF0", Offset = "0x982DF0", VA = "0x180983BF0")]
	private void OnFollowerReachScrollTail()
	{
	}

	[Token(Token = "0x6005309")]
	[Address(RVA = "0x983830", Offset = "0x982A30", VA = "0x180983830")]
	private void OnFollowerAdditionalLoad(long date, long pcode, int dir, Action complete)
	{
	}

	[Token(Token = "0x600530A")]
	[Address(RVA = "0x982870", Offset = "0x981A70", VA = "0x180982870")]
	private void OnClickFriendSearchButton()
	{
	}

	[Token(Token = "0x600530B")]
	[Address(RVA = "0x9822B0", Offset = "0x9814B0", VA = "0x1809822B0")]
	private void OnClickFollowCPButton()
	{
	}

	[Token(Token = "0x600530C")]
	[Address(RVA = "0x983700", Offset = "0x982900", VA = "0x180983700")]
	private void OnFollowUpdateDataCount()
	{
	}

	[Token(Token = "0x600530D")]
	[Address(RVA = "0x984030", Offset = "0x983230", VA = "0x180984030")]
	private void OnOpenCloseFollowList(bool isOpen)
	{
	}

	[Token(Token = "0x600530E")]
	[Address(RVA = "0x984110", Offset = "0x983310", VA = "0x180984110")]
	private void OnOpenCloseFollowerList(bool isOpen)
	{
	}

	[Token(Token = "0x600530F")]
	[Address(RVA = "0x983FC0", Offset = "0x9831C0", VA = "0x180983FC0")]
	private void OnOpenCloseBlockList(bool isOpen)
	{
	}

	[Token(Token = "0x6005310")]
	[Address(RVA = "0x9822F0", Offset = "0x9814F0", VA = "0x1809822F0")]
	private void OnClickFollowPlayer(IPlayerContext player)
	{
	}

	[Token(Token = "0x6005311")]
	[Address(RVA = "0x982300", Offset = "0x981500", VA = "0x180982300")]
	private void OnClickFollowerPlayer(IPlayerContext player)
	{
	}

	[Token(Token = "0x6005312")]
	[Address(RVA = "0x9820C0", Offset = "0x9812C0", VA = "0x1809820C0")]
	private void OnClickBlockPlayer(IPlayerContext player)
	{
	}

	[Token(Token = "0x6005313")]
	[Address(RVA = "0x982770", Offset = "0x981970", VA = "0x180982770")]
	private void OnClickFriendProfile(long pcode)
	{
	}

	[Token(Token = "0x6005314")]
	[Address(RVA = "0x9828D0", Offset = "0x981AD0", VA = "0x1809828D0")]
	private void OnClickFriendSetPin(long pcode)
	{
	}

	[Token(Token = "0x6005315")]
	[Address(RVA = "0x982020", Offset = "0x981220", VA = "0x180982020")]
	private void OnClickBlockOff(long pcode)
	{
	}

	[Token(Token = "0x6005316")]
	[Address(RVA = "0x984180", Offset = "0x983380", VA = "0x180984180")]
	private void OpenFriendDuelAudienceActionSheet(long pcode)
	{
	}

	[Token(Token = "0x6005317")]
	[Address(RVA = "0x982310", Offset = "0x981510", VA = "0x180982310")]
	private void OnClickFriendDuelAudience(long pcode, long rapid)
	{
	}

	[Token(Token = "0x6005318")]
	[Address(RVA = "0x9823D0", Offset = "0x9815D0", VA = "0x1809823D0")]
	private void OnClickFriendDuelEntry(long pcode)
	{
	}

	[Token(Token = "0x6005319")]
	[Address(RVA = "0x8D0040", Offset = "0x8CF240", VA = "0x1808D0040")]
	private Handle APIRoomEntry(int _id_, int _is_specter_, Dictionary<string, object> _options_)
	{
		return null;
	}

	[Token(Token = "0x600531A")]
	[Address(RVA = "0x982A30", Offset = "0x981C30", VA = "0x180982A30")]
	private void OnClickFriendTeamEntry(int teamId)
	{
	}

	[Token(Token = "0x600531B")]
	[Address(RVA = "0x9820D0", Offset = "0x9812D0", VA = "0x1809820D0")]
	private void OnClickCancel()
	{
	}

	[Token(Token = "0x600531C")]
	[Address(RVA = "0x9863A0", Offset = "0x9855A0", VA = "0x1809863A0")]
	public FriendViewController()
	{
	}
}
