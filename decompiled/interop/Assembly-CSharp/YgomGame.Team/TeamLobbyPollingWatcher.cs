using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using YgomSystem.Network;
using YgomSystem.UI;

namespace YgomGame.Team;

[Token(Token = "0x200165A")]
[DisallowMultipleComponent]
public class TeamLobbyPollingWatcher : MonoBehaviour
{
	[Token(Token = "0x200165B")]
	public interface ICallback
	{
		[Token(Token = "0x6008B23")]
		void OnPollingResponse(Handle handle);

		[Token(Token = "0x6008B24")]
		void OnApplyingStatusChanged(ApplyingBattleData data);

		[Token(Token = "0x6008B25")]
		void OnAppliedFromOtherTeam(AppliedBattleData data);

		[Token(Token = "0x6008B26")]
		void OnOpponentTeamInfoUpdated(OpponentTeamInfo data);
	}

	[Token(Token = "0x200165C")]
	public enum ApplyingStatusOnServer
	{
		[Token(Token = "0x400D60B")]
		NONE,
		[Token(Token = "0x400D60C")]
		WAITING,
		[Token(Token = "0x400D60D")]
		CANCEL,
		[Token(Token = "0x400D60E")]
		REJECT,
		[Token(Token = "0x400D60F")]
		ACCEPT,
		[Token(Token = "0x400D610")]
		READY
	}

	[Token(Token = "0x200165D")]
	public struct ApplyingBattleData
	{
		[Token(Token = "0x400D611")]
		[FieldOffset(Offset = "0x0")]
		public ApplyingStatusOnServer status;

		[Token(Token = "0x400D612")]
		[FieldOffset(Offset = "0x4")]
		public int mrk;

		[Token(Token = "0x400D613")]
		[FieldOffset(Offset = "0x8")]
		public int teamId;

		[Token(Token = "0x6008B27")]
		[Address(RVA = "0x488420", Offset = "0x487620", VA = "0x180488420")]
		public bool Equals(ref ApplyingBattleData other)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x200165E")]
	public struct AppliedBattleData
	{
		[Token(Token = "0x400D614")]
		[FieldOffset(Offset = "0x0")]
		public int mrk;

		[Token(Token = "0x400D615")]
		[FieldOffset(Offset = "0x4")]
		public int duelDurationId;

		[Token(Token = "0x400D616")]
		[FieldOffset(Offset = "0x8")]
		public int teamId;

		[Token(Token = "0x1700153D")]
		public bool valid
		{
			[Token(Token = "0x6008B28")]
			[Address(RVA = "0xD5C970", Offset = "0xD5BB70", VA = "0x180D5C970")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6008B29")]
		[Address(RVA = "0x488420", Offset = "0x487620", VA = "0x180488420")]
		public bool Equals(ref AppliedBattleData other)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2001661")]
	[CompilerGenerated]
	private sealed class _003CCallPolling_003Ed__42 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400D61D")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400D61E")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400D61F")]
		[FieldOffset(Offset = "0x20")]
		public TeamLobbyPollingWatcher _003C_003E4__this;

		[Token(Token = "0x400D620")]
		[FieldOffset(Offset = "0x28")]
		private Handle _003Chandle_003E5__2;

		[Token(Token = "0x1700153E")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6008B32")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700153F")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6008B34")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6008B2F")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CCallPolling_003Ed__42(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6008B30")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6008B31")]
		[Address(RVA = "0xD767A0", Offset = "0xD759A0", VA = "0x180D767A0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6008B33")]
		[Address(RVA = "0xD76910", Offset = "0xD75B10", VA = "0x180D76910", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x2001662")]
	[CompilerGenerated]
	private sealed class _003CWatching_003Ed__41 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400D621")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400D622")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400D623")]
		[FieldOffset(Offset = "0x20")]
		public TeamLobbyPollingWatcher _003C_003E4__this;

		[Token(Token = "0x17001540")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6008B38")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17001541")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6008B3A")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6008B35")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CWatching_003Ed__41(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6008B36")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6008B37")]
		[Address(RVA = "0xD799A0", Offset = "0xD78BA0", VA = "0x180D799A0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6008B39")]
		[Address(RVA = "0xD79CC0", Offset = "0xD78EC0", VA = "0x180D79CC0", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x400D5FC")]
	private const float POLLING_SPAN = 3f;

	[Token(Token = "0x400D5FD")]
	private const string CW_PATH_REQUEST_INFO = "$.DuelMenu.TeamMatch.team_info.request_info";

	[Token(Token = "0x400D5FE")]
	private const string CW_PATH_NEW_REQUEST = "$.DuelMenu.TeamMatch.team_info.new_request";

	[Token(Token = "0x400D5FF")]
	[FieldOffset(Offset = "0x0")]
	private static HashSet<ulong> s_alives;

	[Token(Token = "0x400D600")]
	[FieldOffset(Offset = "0x8")]
	private static ulong s_InstanceNumber;

	[Token(Token = "0x400D601")]
	[FieldOffset(Offset = "0x20")]
	private IEnumerator _routine;

	[Token(Token = "0x400D602")]
	[FieldOffset(Offset = "0x28")]
	private TeamUtil.MatchType _matchType;

	[Token(Token = "0x400D603")]
	[FieldOffset(Offset = "0x30")]
	private ViewControllerManager manager;

	[Token(Token = "0x400D604")]
	[FieldOffset(Offset = "0x38")]
	private ulong number;

	[Token(Token = "0x400D605")]
	[FieldOffset(Offset = "0x40")]
	private bool _isForceLeaveErrOccured;

	[Token(Token = "0x400D606")]
	[FieldOffset(Offset = "0x41")]
	private bool _isFatalErrOccured;

	[Token(Token = "0x400D607")]
	[FieldOffset(Offset = "0x48")]
	private HashSet<ICallback> _callbacks;

	[Token(Token = "0x400D608")]
	[FieldOffset(Offset = "0x50")]
	private ApplyingBattleData _applyingBattleData;

	[Token(Token = "0x400D609")]
	[FieldOffset(Offset = "0x5C")]
	private AppliedBattleData _appliedBattleData;

	[Token(Token = "0x17001538")]
	public ApplyingStatusOnServer applyingStatus
	{
		[Token(Token = "0x6008B0E")]
		[Address(RVA = "0x49BD90", Offset = "0x49AF90", VA = "0x18049BD90")]
		get
		{
			return default(ApplyingStatusOnServer);
		}
	}

	[Token(Token = "0x17001539")]
	private bool isErrorDlgShowing
	{
		[Token(Token = "0x6008B0F")]
		[Address(RVA = "0xD671A0", Offset = "0xD663A0", VA = "0x180D671A0")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700153A")]
	private bool shouldPolling
	{
		[Token(Token = "0x6008B10")]
		[Address(RVA = "0xD672A0", Offset = "0xD664A0", VA = "0x180D672A0")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700153B")]
	private bool checkTerminate
	{
		[Token(Token = "0x6008B11")]
		[Address(RVA = "0xD66FF0", Offset = "0xD661F0", VA = "0x180D66FF0")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700153C")]
	public bool isApplyingToOppTeam
	{
		[Token(Token = "0x6008B12")]
		[Address(RVA = "0xD67180", Offset = "0xD66380", VA = "0x180D67180")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6008B13")]
	[Address(RVA = "0xD66EB0", Offset = "0xD660B0", VA = "0x180D66EB0")]
	public TeamLobbyPollingWatcher()
	{
	}

	[Token(Token = "0x6008B14")]
	[Address(RVA = "0xD66990", Offset = "0xD65B90", VA = "0x180D66990")]
	public void StartWatching()
	{
	}

	[Token(Token = "0x6008B15")]
	[Address(RVA = "0xD66BA0", Offset = "0xD65DA0", VA = "0x180D66BA0")]
	public void StopWatching()
	{
	}

	[Token(Token = "0x6008B16")]
	[Address(RVA = "0xD663D0", Offset = "0xD655D0", VA = "0x180D663D0")]
	public void Register(ICallback target)
	{
	}

	[Token(Token = "0x6008B17")]
	[Address(RVA = "0xD66D40", Offset = "0xD65F40", VA = "0x180D66D40")]
	public void Unregister(ICallback target)
	{
	}

	[Token(Token = "0x6008B18")]
	[Address(RVA = "0xD66110", Offset = "0xD65310", VA = "0x180D66110")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6008B19")]
	[Address(RVA = "0xD66220", Offset = "0xD65420", VA = "0x180D66220")]
	private void OnResponse(Handle res)
	{
	}

	[Token(Token = "0x6008B1A")]
	[Address(RVA = "0xD66600", Offset = "0xD65800", VA = "0x180D66600")]
	private void SendApplyStatusChanged(ApplyingBattleData data)
	{
	}

	[Token(Token = "0x6008B1B")]
	[Address(RVA = "0xD66430", Offset = "0xD65630", VA = "0x180D66430")]
	private void SendApplicationFromOtherTeam(AppliedBattleData data)
	{
	}

	[Token(Token = "0x6008B1C")]
	[Address(RVA = "0xD667D0", Offset = "0xD659D0", VA = "0x180D667D0")]
	private void SendOpponentTeamInfoUpdated(OpponentTeamInfo data)
	{
	}

	[Token(Token = "0x6008B1D")]
	[Address(RVA = "0xD65FD0", Offset = "0xD651D0", VA = "0x180D65FD0")]
	private void OnApplyingBattleDataUpdated(object rootData)
	{
	}

	[Token(Token = "0x6008B1E")]
	[Address(RVA = "0xD65E90", Offset = "0xD65090", VA = "0x180D65E90")]
	private void OnAppliedBattleDataUpdated(object rootData)
	{
	}

	[Token(Token = "0x6008B1F")]
	[Address(RVA = "0xD661B0", Offset = "0xD653B0", VA = "0x180D661B0")]
	private void OnOpponentTeamInfoUpdated(object rootData)
	{
	}

	[Token(Token = "0x6008B20")]
	[Address(RVA = "0xD66DA0", Offset = "0xD65FA0", VA = "0x180D66DA0")]
	[IteratorStateMachine(typeof(_003CWatching_003Ed__41))]
	private IEnumerator Watching()
	{
		return null;
	}

	[Token(Token = "0x6008B21")]
	[Address(RVA = "0xD65E20", Offset = "0xD65020", VA = "0x180D65E20")]
	[IteratorStateMachine(typeof(_003CCallPolling_003Ed__42))]
	private IEnumerator CallPolling()
	{
		return null;
	}
}
