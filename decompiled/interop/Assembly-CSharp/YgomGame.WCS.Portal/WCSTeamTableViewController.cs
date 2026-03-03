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

namespace YgomGame.WCS.Portal;

[Token(Token = "0x2000792")]
public class WCSTeamTableViewController : WCSTeamTableViewControllerBase, IBackButtonSupported, IHeaderBorderSupported
{
	[Token(Token = "0x2000798")]
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass31_0
	{
		[Token(Token = "0x4002600")]
		[FieldOffset(Offset = "0x10")]
		public Handle resultHandle;

		[Token(Token = "0x4002601")]
		[FieldOffset(Offset = "0x18")]
		public int errCode;

		[Token(Token = "0x60031AE")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public _003C_003Ec__DisplayClass31_0()
		{
		}

		[Token(Token = "0x60031AF")]
		[Address(RVA = "0x439010", Offset = "0x438210", VA = "0x180439010")]
		internal void _003CPolling_003Eb__0(Handle res)
		{
		}

		[Token(Token = "0x60031B0")]
		[Address(RVA = "0x5C7C70", Offset = "0x5C6E70", VA = "0x1805C7C70")]
		internal bool _003CPolling_003Eb__1()
		{
			return default(bool);
		}

		[Token(Token = "0x60031B1")]
		[Address(RVA = "0x615AB0", Offset = "0x614CB0", VA = "0x180615AB0")]
		internal void _003CPolling_003Eb__2(int code)
		{
		}

		[Token(Token = "0x60031B2")]
		[Address(RVA = "0x736180", Offset = "0x735380", VA = "0x180736180")]
		internal bool _003CPolling_003Eb__3()
		{
			return default(bool);
		}
	}

	[Token(Token = "0x200079A")]
	[CompilerGenerated]
	private sealed class _003CPolling_003Ed__31 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4002603")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4002604")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4002605")]
		[FieldOffset(Offset = "0x20")]
		public WCSTeamTableViewController _003C_003E4__this;

		[Token(Token = "0x4002606")]
		[FieldOffset(Offset = "0x28")]
		private _003C_003Ec__DisplayClass31_0 _003C_003E8__1;

		[Token(Token = "0x17000628")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x60031B8")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000629")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60031BA")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60031B5")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CPolling_003Ed__31(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x60031B6")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x60031B7")]
		[Address(RVA = "0x758E20", Offset = "0x758020", VA = "0x180758E20", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60031B9")]
		[Address(RVA = "0x759200", Offset = "0x758400", VA = "0x180759200", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x40025ED")]
	private const string VC_PREFAB_PATH = "WCS/Portal/WCSTeamTableForPortal";

	[Token(Token = "0x40025EE")]
	private const string ARG_KEY_ROOM_ID = "room_id";

	[Token(Token = "0x40025EF")]
	private const string ARG_KEY_ROOM_UNIQUE_ID = "room_unique_id";

	[Token(Token = "0x40025F0")]
	private const string ARG_KEY_APPLY_IMMEDIATE = "ApplyImmediate";

	[Token(Token = "0x40025F1")]
	[FieldOffset(Offset = "0xF0")]
	protected int _roomId;

	[Token(Token = "0x40025F2")]
	[FieldOffset(Offset = "0xF8")]
	private string _roomUniqueId;

	[Token(Token = "0x40025F3")]
	[FieldOffset(Offset = "0x100")]
	private IEnumerator _pollingRoutine;

	[Token(Token = "0x17000622")]
	protected virtual float pollingPeriod
	{
		[Token(Token = "0x600318A")]
		[Address(RVA = "0x431D80", Offset = "0x430F80", VA = "0x180431D80", Slot = "30")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x17000623")]
	protected override bool setProgressOnInitialize
	{
		[Token(Token = "0x600318B")]
		[Address(RVA = "0x3C7A70", Offset = "0x3C6C70", VA = "0x1803C7A70", Slot = "18")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000624")]
	protected override int outGameBgId
	{
		[Token(Token = "0x600318C")]
		[Address(RVA = "0x549EC0", Offset = "0x5490C0", VA = "0x180549EC0", Slot = "20")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000625")]
	public int roomId
	{
		[Token(Token = "0x600318D")]
		[Address(RVA = "0x764490", Offset = "0x763690", VA = "0x180764490")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000626")]
	public string roomUniqueId
	{
		[Token(Token = "0x600318E")]
		[Address(RVA = "0x596200", Offset = "0x595400", VA = "0x180596200")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000627")]
	protected virtual object roomInfo
	{
		[Token(Token = "0x600318F")]
		[Address(RVA = "0x7644A0", Offset = "0x7636A0", VA = "0x1807644A0", Slot = "31")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6003189")]
	[Address(RVA = "0x764020", Offset = "0x763220", VA = "0x180764020")]
	public static void Open(ViewControllerManager manager, int roomId, string roomUniqueId)
	{
	}

	[Token(Token = "0x6003190")]
	[Address(RVA = "0x764250", Offset = "0x763450", VA = "0x180764250", Slot = "11")]
	public override void TransitionStart(TransitionType type)
	{
	}

	[Token(Token = "0x6003191")]
	[Address(RVA = "0x763E50", Offset = "0x763050", VA = "0x180763E50", Slot = "25")]
	protected override void OnTransitionEnd(TransitionType type)
	{
	}

	[Token(Token = "0x6003192")]
	[Address(RVA = "0x763E00", Offset = "0x763000", VA = "0x180763E00", Slot = "28")]
	protected override void OnDestroy()
	{
	}

	[Token(Token = "0x6003193")]
	[Address(RVA = "0x763CF0", Offset = "0x762EF0", VA = "0x180763CF0", Slot = "6")]
	public override void NotificationStackEntry()
	{
	}

	[Token(Token = "0x6003194")]
	[Address(RVA = "0x763A70", Offset = "0x762C70", VA = "0x180763A70", Slot = "29")]
	protected override void InitializeView()
	{
	}

	[Token(Token = "0x6003195")]
	[Address(RVA = "0x762930", Offset = "0x761B30", VA = "0x180762930", Slot = "32")]
	protected virtual void ApplyData(object roomInfo)
	{
	}

	[Token(Token = "0x6003196")]
	[Address(RVA = "0x763F00", Offset = "0x763100", VA = "0x180763F00")]
	private void OpenTeamIntroduction(int teamId)
	{
	}

	[Token(Token = "0x6003197")]
	[Address(RVA = "0x763800", Offset = "0x762A00", VA = "0x180763800", Slot = "33")]
	protected virtual void CallWatchDuelAPI(long pcode)
	{
	}

	[Token(Token = "0x6003198")]
	[Address(RVA = "0x7641B0", Offset = "0x7633B0", VA = "0x1807641B0")]
	private void StartPolling()
	{
	}

	[Token(Token = "0x6003199")]
	[Address(RVA = "0x763920", Offset = "0x762B20", VA = "0x180763920")]
	private void EndPolling()
	{
	}

	[Token(Token = "0x600319A")]
	[Address(RVA = "0x7637F0", Offset = "0x7629F0", VA = "0x1807637F0", Slot = "34")]
	protected virtual Handle CallPollingAPI()
	{
		return null;
	}

	[Token(Token = "0x600319B")]
	[Address(RVA = "0x764140", Offset = "0x763340", VA = "0x180764140")]
	[IteratorStateMachine(typeof(_003CPolling_003Ed__31))]
	private IEnumerator Polling()
	{
		return null;
	}

	[Token(Token = "0x600319C")]
	[Address(RVA = "0x763970", Offset = "0x762B70", VA = "0x180763970", Slot = "35")]
	protected virtual bool HandleResultCode(Handle handle, UnityAction onSuccess, UnityAction<int> onFailed)
	{
		return default(bool);
	}

	[Token(Token = "0x600319D")]
	[Address(RVA = "0x745590", Offset = "0x744790", VA = "0x180745590", Slot = "36")]
	protected virtual bool IsForceLeaving(WcsCode err)
	{
		return default(bool);
	}

	[Token(Token = "0x600319E")]
	[Address(RVA = "0x764450", Offset = "0x763650", VA = "0x180764450")]
	public WCSTeamTableViewController()
	{
	}
}
