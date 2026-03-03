using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine.Events;
using YgomGame.Menu;
using YgomSystem.Network;
using YgomSystem.UI;

namespace YgomGame.WCS;

[Token(Token = "0x2000758")]
public class WCSTeamTableViewControllerVer2 : BaseMenuViewController, IBackButtonSupported, IHeaderBorderSupported
{
	[Token(Token = "0x200075C")]
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass47_0
	{
		[Token(Token = "0x40024F5")]
		[FieldOffset(Offset = "0x10")]
		public Handle resultHandle;

		[Token(Token = "0x40024F6")]
		[FieldOffset(Offset = "0x18")]
		public int errCode;

		[Token(Token = "0x6003060")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public _003C_003Ec__DisplayClass47_0()
		{
		}

		[Token(Token = "0x6003061")]
		[Address(RVA = "0x439010", Offset = "0x438210", VA = "0x180439010")]
		internal void _003CPolling_003Eb__0(Handle res)
		{
		}

		[Token(Token = "0x6003062")]
		[Address(RVA = "0x5C7C70", Offset = "0x5C6E70", VA = "0x1805C7C70")]
		internal bool _003CPolling_003Eb__1()
		{
			return default(bool);
		}

		[Token(Token = "0x6003063")]
		[Address(RVA = "0x615AB0", Offset = "0x614CB0", VA = "0x180615AB0")]
		internal void _003CPolling_003Eb__2(int code)
		{
		}

		[Token(Token = "0x6003064")]
		[Address(RVA = "0x736180", Offset = "0x735380", VA = "0x180736180")]
		internal bool _003CPolling_003Eb__3()
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2000761")]
	[CompilerGenerated]
	private sealed class _003CPolling_003Ed__47 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4002500")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4002501")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4002502")]
		[FieldOffset(Offset = "0x20")]
		public WCSTeamTableViewControllerVer2 _003C_003E4__this;

		[Token(Token = "0x4002503")]
		[FieldOffset(Offset = "0x28")]
		private _003C_003Ec__DisplayClass47_0 _003C_003E8__1;

		[Token(Token = "0x17000601")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6003070")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000602")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6003072")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600306D")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CPolling_003Ed__47(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x600306E")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x600306F")]
		[Address(RVA = "0x734850", Offset = "0x733A50", VA = "0x180734850", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6003071")]
		[Address(RVA = "0x734D30", Offset = "0x733F30", VA = "0x180734D30", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x40024DF")]
	private const string VC_PREFAB_PATH = "WCS/Portal/WCSTeamTableForPortalVer2";

	[Token(Token = "0x40024E0")]
	internal const string ARG_KEY_DRYRUN = "dryrun";

	[Token(Token = "0x40024E1")]
	private const string ARG_KEY_ROOM_ID = "room_id";

	[Token(Token = "0x40024E2")]
	private const string ARG_KEY_ADMINISTRATOR = "administrator";

	[Token(Token = "0x40024E3")]
	private const string ARG_KEY_BUTTON_DISP_ALWAYS = "ButtonDispAlways";

	[Token(Token = "0x40024E6")]
	[FieldOffset(Offset = "0xD8")]
	private WCSTeamTableViewVer2 _tableView;

	[Token(Token = "0x40024E7")]
	[FieldOffset(Offset = "0xE0")]
	protected int _roomId;

	[Token(Token = "0x40024E8")]
	[FieldOffset(Offset = "0xE8")]
	protected Func<int, Handle> _pollingAPI;

	[Token(Token = "0x40024E9")]
	[FieldOffset(Offset = "0xF0")]
	protected Func<long, long, Handle> _watchAPI;

	[Token(Token = "0x40024EA")]
	[FieldOffset(Offset = "0xF8")]
	protected Func<long, long, Handle> _replayAPI;

	[Token(Token = "0x40024EB")]
	[FieldOffset(Offset = "0x100")]
	protected Func<object> _roomInfoGetter;

	[Token(Token = "0x40024EC")]
	[FieldOffset(Offset = "0x108")]
	private IEnumerator _pollingRoutine;

	[Token(Token = "0x170005F9")]
	protected bool dryrun
	{
		[Token(Token = "0x6003036")]
		[Address(RVA = "0x49B9D0", Offset = "0x49ABD0", VA = "0x18049B9D0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6003037")]
		[Address(RVA = "0x49C1C0", Offset = "0x49B3C0", VA = "0x18049C1C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x170005FA")]
	protected virtual float pollingPeriod
	{
		[Token(Token = "0x6003038")]
		[Address(RVA = "0x431D80", Offset = "0x430F80", VA = "0x180431D80", Slot = "28")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x170005FB")]
	protected override bool setProgressOnInitialize
	{
		[Token(Token = "0x6003039")]
		[Address(RVA = "0x3C7A70", Offset = "0x3C6C70", VA = "0x1803C7A70", Slot = "18")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170005FC")]
	public int roomId
	{
		[Token(Token = "0x600303A")]
		[Address(RVA = "0x746560", Offset = "0x745760", VA = "0x180746560")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x170005FD")]
	protected override Type[] textIds
	{
		[Token(Token = "0x600303B")]
		[Address(RVA = "0x746590", Offset = "0x745790", VA = "0x180746590", Slot = "21")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170005FE")]
	protected virtual object roomInfo
	{
		[Token(Token = "0x600303C")]
		[Address(RVA = "0x746570", Offset = "0x745770", VA = "0x180746570", Slot = "29")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170005FF")]
	private bool checkRequestAPI_OK
	{
		[Token(Token = "0x600303D")]
		[Address(RVA = "0x746460", Offset = "0x745660", VA = "0x180746460")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000600")]
	public bool administrator
	{
		[Token(Token = "0x600303F")]
		[Address(RVA = "0x49BB40", Offset = "0x49AD40", VA = "0x18049BB40")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600303E")]
		[Address(RVA = "0x746790", Offset = "0x745990", VA = "0x180746790")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x6003035")]
	[Address(RVA = "0x745350", Offset = "0x744550", VA = "0x180745350")]
	public static void Go(ViewControllerManager manager, int roomId, bool isAdmin)
	{
	}

	[Token(Token = "0x6003040")]
	[Address(RVA = "0x746130", Offset = "0x745330", VA = "0x180746130", Slot = "11")]
	public override void TransitionStart(TransitionType type)
	{
	}

	[Token(Token = "0x6003041")]
	[Address(RVA = "0x745BB0", Offset = "0x744DB0", VA = "0x180745BB0", Slot = "25")]
	protected override void OnTransitionEnd(TransitionType type)
	{
	}

	[Token(Token = "0x6003042")]
	[Address(RVA = "0x7455B0", Offset = "0x7447B0", VA = "0x1807455B0", Slot = "6")]
	public override void NotificationStackEntry()
	{
	}

	[Token(Token = "0x6003043")]
	[Address(RVA = "0x543AE0", Offset = "0x542CE0", VA = "0x180543AE0", Slot = "7")]
	public override void NotificationStackRemove()
	{
	}

	[Token(Token = "0x6003044")]
	[Address(RVA = "0x745300", Offset = "0x744500", VA = "0x180745300")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6003045")]
	[Address(RVA = "0x745A60", Offset = "0x744C60", VA = "0x180745A60", Slot = "23")]
	protected override void OnCreatedView()
	{
	}

	[Token(Token = "0x6003046")]
	[Address(RVA = "0x745D10", Offset = "0x744F10", VA = "0x180745D10")]
	private void OpenTeamIntroduction(int teamId)
	{
	}

	[Token(Token = "0x6003047")]
	[Address(RVA = "0x746090", Offset = "0x745290", VA = "0x180746090")]
	private void StartPolling()
	{
	}

	[Token(Token = "0x6003048")]
	[Address(RVA = "0x745300", Offset = "0x744500", VA = "0x180745300")]
	private void EndPolling()
	{
	}

	[Token(Token = "0x6003049")]
	[Address(RVA = "0x745190", Offset = "0x744390", VA = "0x180745190", Slot = "30")]
	protected virtual Handle CallPollingAPI()
	{
		return null;
	}

	[Token(Token = "0x600304A")]
	[Address(RVA = "0x745490", Offset = "0x744690", VA = "0x180745490", Slot = "31")]
	protected virtual bool HandleResultCode(Handle handle, UnityAction onSuccess, UnityAction<int> onFailed)
	{
		return default(bool);
	}

	[Token(Token = "0x600304B")]
	[Address(RVA = "0x745590", Offset = "0x744790", VA = "0x180745590", Slot = "32")]
	protected virtual bool IsForceLeaving(WcsCode err)
	{
		return default(bool);
	}

	[Token(Token = "0x600304C")]
	[Address(RVA = "0x745EA0", Offset = "0x7450A0", VA = "0x180745EA0")]
	private void SelectWatchDuel(long pcode)
	{
	}

	[Token(Token = "0x600304D")]
	[Address(RVA = "0x7451C0", Offset = "0x7443C0", VA = "0x1807451C0", Slot = "33")]
	protected virtual void CallWatchDuelAPI(int watchType, long pcode)
	{
	}

	[Token(Token = "0x600304E")]
	[Address(RVA = "0x745E30", Offset = "0x745030", VA = "0x180745E30")]
	[IteratorStateMachine(typeof(_003CPolling_003Ed__47))]
	private IEnumerator Polling()
	{
		return null;
	}

	[Token(Token = "0x600304F")]
	[Address(RVA = "0x743BA0", Offset = "0x742DA0", VA = "0x180743BA0", Slot = "34")]
	protected virtual void ApplyData(object roomInfo)
	{
	}

	[Token(Token = "0x6003050")]
	[Address(RVA = "0x3E3340", Offset = "0x3E2540", VA = "0x1803E3340")]
	public WCSTeamTableViewControllerVer2()
	{
	}
}
