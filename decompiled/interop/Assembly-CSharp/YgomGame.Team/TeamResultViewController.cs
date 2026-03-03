using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;
using YgomGame.Common;
using YgomGame.Duel;
using YgomGame.Menu;
using YgomSystem.ElementSystem;
using YgomSystem.Network;
using YgomSystem.UI;

namespace YgomGame.Team;

[Token(Token = "0x200167D")]
public class TeamResultViewController : BaseMenuViewController
{
	[Token(Token = "0x200167E")]
	internal enum ResultTableStatus
	{
		[Token(Token = "0x400D6F9")]
		REPLAY = 1,
		[Token(Token = "0x400D6FA")]
		SPECTATE
	}

	[Token(Token = "0x200167F")]
	internal enum ResultStatus
	{
		[Token(Token = "0x400D6FC")]
		WAIT,
		[Token(Token = "0x400D6FD")]
		WIN,
		[Token(Token = "0x400D6FE")]
		LOSE,
		[Token(Token = "0x400D6FF")]
		DRAW
	}

	[Token(Token = "0x2001680")]
	internal class ResultTableData
	{
		[Token(Token = "0x400D700")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		internal MemberData[] members;

		[Token(Token = "0x400D701")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		internal string regulation;

		[Token(Token = "0x400D702")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		internal ResultStatus myResult;

		[Token(Token = "0x400D703")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		internal ResultStatus enemyResult;

		[Token(Token = "0x400D704")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		internal int regulationID;

		[Token(Token = "0x400D705")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		internal int index;

		[Token(Token = "0x400D706")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		internal long did;

		[Token(Token = "0x400D707")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		internal int progress;

		[Token(Token = "0x6008C34")]
		[Address(RVA = "0xD80220", Offset = "0xD7F420", VA = "0x180D80220")]
		public ResultTableData(MemberData[] members, int index, int regulationID, string regulation, ResultStatus myResult, ResultStatus enemyResult, long did, int progress)
		{
		}
	}

	[Token(Token = "0x2001681")]
	internal class MemberData
	{
		[Token(Token = "0x400D708")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		internal int pcode;

		[Token(Token = "0x400D709")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		internal string name;

		[Token(Token = "0x400D70A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		internal int iconID;

		[Token(Token = "0x400D70B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		internal int iconFrameID;

		[Token(Token = "0x400D70C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		internal int commentID;

		[Token(Token = "0x400D70D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		internal bool isResistedPlatform;

		[Token(Token = "0x400D70E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2D")]
		internal bool isSamePlatform;

		[Token(Token = "0x400D70F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		internal string platformName;

		[Token(Token = "0x400D710")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		internal int platformID;

		[Token(Token = "0x400D711")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		internal int follow_num;

		[Token(Token = "0x400D712")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		internal int follower_num;

		[Token(Token = "0x400D713")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		internal int level;

		[Token(Token = "0x400D714")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		internal int rank;

		[Token(Token = "0x400D715")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		internal int rate;

		[Token(Token = "0x400D716")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		internal int exp;

		[Token(Token = "0x400D717")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		internal int need_exp;

		[Token(Token = "0x400D718")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		internal int wallpaper;

		[Token(Token = "0x400D719")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		internal ulong xuid;

		[Token(Token = "0x400D71A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		internal int avater_id;

		[Token(Token = "0x400D71B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		internal int edit;

		[Token(Token = "0x400D71C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		internal List<object> tag;

		[Token(Token = "0x400D71D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		internal int official;

		[Token(Token = "0x400D71E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		internal string onlineID;

		[Token(Token = "0x6008C35")]
		[Address(RVA = "0xD7A670", Offset = "0xD79870", VA = "0x180D7A670")]
		public MemberData()
		{
		}
	}

	[Token(Token = "0x2001682")]
	internal class TeamResultRoomInfo
	{
		[Token(Token = "0x400D71F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		internal int teamID;

		[Token(Token = "0x400D720")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		internal int myCardMrk;

		[Token(Token = "0x400D721")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		internal int enemyCardMrk;

		[Token(Token = "0x400D722")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		internal int memberNum;

		[Token(Token = "0x400D723")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		internal long myTeamMasterID;

		[Token(Token = "0x400D724")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		internal long enemyTeamMasterID;

		[Token(Token = "0x400D725")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		internal int nextTeamID;

		[Token(Token = "0x6008C36")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public TeamResultRoomInfo()
		{
		}
	}

	[Token(Token = "0x200168F")]
	[CompilerGenerated]
	private sealed class _003CPlayResultEffect_003Ed__76 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400D748")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400D749")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400D74A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public TeamResultViewController _003C_003E4__this;

		[Token(Token = "0x400D74B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Action onFinished;

		[Token(Token = "0x1700155E")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6008C5E")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700155F")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6008C60")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6008C5B")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CPlayResultEffect_003Ed__76(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6008C5C")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6008C5D")]
		[Address(RVA = "0xD8D680", Offset = "0xD8C880", VA = "0x180D8D680", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6008C5F")]
		[Address(RVA = "0xD8D810", Offset = "0xD8CA10", VA = "0x180D8D810", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x400D6CA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static readonly string viewControllerPath;

	[Token(Token = "0x400D6CB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	protected readonly string OBJ_COMMENT_LABEL;

	[Token(Token = "0x400D6CC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	protected readonly string OBJ_TABLE_TMP_LABEL;

	[Token(Token = "0x400D6CD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	protected readonly string TXT_COMMENT_LABEL;

	[Token(Token = "0x400D6CE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	protected readonly string SCROLL_LABEL;

	[Token(Token = "0x400D6CF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	protected readonly string IMG_LEFT_BG_CARD_LABEL;

	[Token(Token = "0x400D6D0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	protected readonly string IMG_RIGHT_BG_CARD_LABEL;

	[Token(Token = "0x400D6D1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
	protected readonly string TXT_TMP_TITLE_LABEL;

	[Token(Token = "0x400D6D2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
	protected readonly string OBJ_RESULTLIST_LABEL;

	[Token(Token = "0x400D6D3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
	protected readonly string OBJ_WLD_AREA_LABEL;

	[Token(Token = "0x400D6D4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
	protected readonly string TEXT_WIN_LABEL;

	[Token(Token = "0x400D6D5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
	protected readonly string TEXT_LOSE_LABEL;

	[Token(Token = "0x400D6D6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
	protected readonly string TEXT_DRAW_LABEL;

	[Token(Token = "0x400D6D7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
	protected readonly string OBJ_PLAYER_LEFT_LABEL;

	[Token(Token = "0x400D6D8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
	protected readonly string OBJ_PLAYER_RIGHT_LABEL;

	[Token(Token = "0x400D6D9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
	protected readonly string OBJ_TEAM_LEFT_CROWN_LABEL;

	[Token(Token = "0x400D6DA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
	protected readonly string OBJ_TEAM_RIGHT_CROWN_LABEL;

	[Token(Token = "0x400D6DB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
	protected readonly string OBJ_TEAM_LEFT_SCORE_LABEL;

	[Token(Token = "0x400D6DC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
	protected readonly string OBJ_TEAM_RIGHT_SCORE_LABEL;

	[Token(Token = "0x400D6DD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
	protected readonly string TXT_TEAM_NAME_LEFT_LABEL;

	[Token(Token = "0x400D6DE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
	protected readonly string TXT_TEAM_NAME_RIGHT_LABEL;

	[Token(Token = "0x400D6DF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
	protected readonly string BTN_EXIT_LABEL;

	[Token(Token = "0x400D6E0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
	protected readonly string BTN_REORGANIZE_LABEL;

	[Token(Token = "0x400D6E1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
	protected readonly string BTN_COMMENT_LEFT_LABEL;

	[Token(Token = "0x400D6E2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
	protected readonly string BTN_REPLAY_LABEL;

	[Token(Token = "0x400D6E3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
	protected readonly string TXT_ROOM_MEMBER_LABEL;

	[Token(Token = "0x400D6E4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
	protected readonly string BTN_PROFILE_LABEL;

	[Token(Token = "0x400D6E5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
	protected readonly string IMG_ICON_LABEL;

	[Token(Token = "0x400D6E6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
	protected readonly string PLATFORM_NAME_LABEL;

	[Token(Token = "0x400D6E7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1B0")]
	protected readonly string PLATFORM_ICON_LABEL;

	[Token(Token = "0x400D6E8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1B8")]
	protected long myPcode;

	[Token(Token = "0x400D6E9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C0")]
	private int leftScore;

	[Token(Token = "0x400D6EA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C4")]
	private int rightScore;

	[Token(Token = "0x400D6EB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C8")]
	private bool isFinishedResultEffect;

	[Token(Token = "0x400D6EC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1CC")]
	private int callingApiCount;

	[Token(Token = "0x400D6ED")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1D0")]
	private string[] tableComments;

	[Token(Token = "0x400D6EE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1D8")]
	internal Dictionary<int, string> regulationList;

	[Token(Token = "0x400D6EF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1E0")]
	internal List<ResultTableData> resultTableDataList;

	[Token(Token = "0x400D6F0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1E8")]
	internal TeamResultRoomInfo teamResultRoomInfo;

	[Token(Token = "0x400D6F1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1F0")]
	private bool isReorgaButtonActive;

	[Token(Token = "0x400D6F2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1F4")]
	private ResultStatus teamResultStatus;

	[Token(Token = "0x400D6F3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1F8")]
	private Dictionary<int, GameObject> _tableTemplates;

	[Token(Token = "0x400D6F4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x200")]
	private float pastSec;

	[Token(Token = "0x400D6F5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x204")]
	private int myid;

	[Token(Token = "0x400D6F6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x208")]
	private bool isResultError;

	[Token(Token = "0x400D6F7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x210")]
	private GameObject profileParent;

	[Token(Token = "0x1700155B")]
	protected override Type[] textIds
	{
		[Token(Token = "0x6008BF8")]
		[Address(RVA = "0xD76460", Offset = "0xD75660", VA = "0x180D76460", Slot = "21")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700155C")]
	private bool isCallingApi
	{
		[Token(Token = "0x6008BF9")]
		[Address(RVA = "0xD76450", Offset = "0xD75650", VA = "0x180D76450")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700155D")]
	protected bool existDialog
	{
		[Token(Token = "0x6008C01")]
		[Address(RVA = "0xD76360", Offset = "0xD75560", VA = "0x180D76360")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6008BFA")]
	[Address(RVA = "0xD6FF50", Offset = "0xD6F150", VA = "0x180D6FF50")]
	public static void Open(ViewControllerManager manager)
	{
	}

	[Token(Token = "0x6008BFB")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "8")]
	public override void NotificationStack(ViewControllerManager vcm, ViewController vc, bool isEntry)
	{
	}

	[Token(Token = "0x6008BFC")]
	[Address(RVA = "0x3E4080", Offset = "0x3E3280", VA = "0x1803E4080", Slot = "6")]
	public override void NotificationStackEntry()
	{
	}

	[Token(Token = "0x6008BFD")]
	[Address(RVA = "0x543AE0", Offset = "0x542CE0", VA = "0x180543AE0", Slot = "7")]
	public override void NotificationStackRemove()
	{
	}

	[Token(Token = "0x6008BFE")]
	[Address(RVA = "0xD6FED0", Offset = "0xD6F0D0", VA = "0x180D6FED0", Slot = "15")]
	public override void OnFocusChanged(bool setfocus)
	{
	}

	[Token(Token = "0x6008BFF")]
	[Address(RVA = "0xD6FD20", Offset = "0xD6EF20", VA = "0x180D6FD20", Slot = "23")]
	protected override void OnCreatedView()
	{
	}

	[Token(Token = "0x6008C00")]
	[Address(RVA = "0xD6F3A0", Offset = "0xD6E5A0", VA = "0x180D6F3A0")]
	private void Init()
	{
	}

	[Token(Token = "0x6008C02")]
	[Address(RVA = "0xD75BC0", Offset = "0xD74DC0", VA = "0x180D75BC0")]
	private void Update()
	{
	}

	[Token(Token = "0x6008C03")]
	[Address(RVA = "0xD70050", Offset = "0xD6F250", VA = "0x180D70050")]
	internal void SetBGCard(int mrk, string label, bool off = false)
	{
	}

	[Token(Token = "0x6008C04")]
	[Address(RVA = "0xD6EBE0", Offset = "0xD6DDE0", VA = "0x180D6EBE0")]
	protected void OnClickExitButton()
	{
	}

	[Token(Token = "0x6008C05")]
	[Address(RVA = "0xD6EF50", Offset = "0xD6E150", VA = "0x180D6EF50")]
	protected void CreateTableTemplates()
	{
	}

	[Token(Token = "0x6008C06")]
	[Address(RVA = "0xD6ED60", Offset = "0xD6DF60", VA = "0x180D6ED60")]
	protected GameObject CreateTableTemplate(GameObject template, [Optional] UnityAction onClick)
	{
		return null;
	}

	[Token(Token = "0x6008C07")]
	[Address(RVA = "0xD70800", Offset = "0xD6FA00", VA = "0x180D70800")]
	private void SetTeamInfo()
	{
	}

	[Token(Token = "0x6008C08")]
	[Address(RVA = "0xD713F0", Offset = "0xD705F0", VA = "0x180D713F0")]
	internal void SetTeamTable(bool init = false)
	{
	}

	[Token(Token = "0x6008C09")]
	[Address(RVA = "0xD75250", Offset = "0xD74450", VA = "0x180D75250")]
	internal void UpdateTeamResultView()
	{
	}

	[Token(Token = "0x6008C0A")]
	[Address(RVA = "0xD6F810", Offset = "0xD6EA10", VA = "0x180D6F810")]
	private void OnClickRecreateButton()
	{
	}

	[Token(Token = "0x6008C0B")]
	[Address(RVA = "0xD6F670", Offset = "0xD6E870", VA = "0x180D6F670")]
	public bool OnClickActionWithCheck(UnityAction onFinish)
	{
		return default(bool);
	}

	[Token(Token = "0x6008C0C")]
	[Address(RVA = "0xD6F530", Offset = "0xD6E730", VA = "0x180D6F530")]
	public bool OnClickActionWithCheckRecreate(UnityAction onFinish)
	{
		return default(bool);
	}

	[Token(Token = "0x6008C0D")]
	[Address(RVA = "0xD74110", Offset = "0xD73310", VA = "0x180D74110")]
	internal void UpdateTabel()
	{
	}

	[Token(Token = "0x6008C0E")]
	[Address(RVA = "0xD6FB00", Offset = "0xD6ED00", VA = "0x180D6FB00")]
	private void OnClickReplayButton(ResultTableData data)
	{
	}

	[Token(Token = "0x6008C0F")]
	[Address(RVA = "0xD6F7B0", Offset = "0xD6E9B0", VA = "0x180D6F7B0")]
	private void OnClickProfileButton(MemberData data)
	{
	}

	[Token(Token = "0x6008C10")]
	[Address(RVA = "0xD76730", Offset = "0xD75930", VA = "0x180D76730")]
	private void setActiveFooter(bool active)
	{
	}

	[Token(Token = "0x6008C11")]
	[Address(RVA = "0xD736E0", Offset = "0xD728E0", VA = "0x180D736E0")]
	private void ShowTableResultText(ElementObjectManager eom, ResultStatus status)
	{
	}

	[Token(Token = "0x6008C12")]
	[Address(RVA = "0xD70280", Offset = "0xD6F480", VA = "0x180D70280")]
	private void SetComment(MatchingComment balloon, MemberData data)
	{
	}

	[Token(Token = "0x6008C13")]
	[Address(RVA = "0xD6FFC0", Offset = "0xD6F1C0", VA = "0x180D6FFC0")]
	[IteratorStateMachine(typeof(_003CPlayResultEffect_003Ed__76))]
	private IEnumerator PlayResultEffect([Optional] Action onFinished)
	{
		return null;
	}

	[Token(Token = "0x6008C14")]
	[Address(RVA = "0xD70300", Offset = "0xD6F500", VA = "0x180D70300")]
	private Dictionary<string, object> SetProfCardArgs(MemberData data)
	{
		return null;
	}

	[Token(Token = "0x6008C15")]
	[Address(RVA = "0xD6F280", Offset = "0xD6E480", VA = "0x180D6F280")]
	private static Dictionary<string, object> GetTeamResultInfo()
	{
		return null;
	}

	[Token(Token = "0x6008C16")]
	[Address(RVA = "0xD6F2E0", Offset = "0xD6E4E0", VA = "0x180D6F2E0")]
	private static List<object> GetTeamResultTableInfoList()
	{
		return null;
	}

	[Token(Token = "0x6008C17")]
	[Address(RVA = "0xD6F340", Offset = "0xD6E540", VA = "0x180D6F340")]
	private static List<object> GetTeamResultTableResultList()
	{
		return null;
	}

	[Token(Token = "0x6008C18")]
	[Address(RVA = "0xD6F220", Offset = "0xD6E420", VA = "0x180D6F220")]
	private static Dictionary<string, object> GetTeamResultDuelResult()
	{
		return null;
	}

	[Token(Token = "0x6008C19")]
	[Address(RVA = "0xD6F130", Offset = "0xD6E330", VA = "0x180D6F130")]
	public static int GetTeamComment(long pcode)
	{
		return default(int);
	}

	[Token(Token = "0x6008C1A")]
	[Address(RVA = "0xD6F1C0", Offset = "0xD6E3C0", VA = "0x180D6F1C0")]
	private static int GetTeamID()
	{
		return default(int);
	}

	[Token(Token = "0x6008C1B")]
	[Address(RVA = "0xD6E6B0", Offset = "0xD6D8B0", VA = "0x180D6E6B0")]
	protected void AddCallingCount()
	{
	}

	[Token(Token = "0x6008C1C")]
	[Address(RVA = "0xD6F120", Offset = "0xD6E320", VA = "0x180D6F120")]
	protected void DecCallingCount()
	{
	}

	[Token(Token = "0x6008C1D")]
	[Address(RVA = "0xD6EC80", Offset = "0xD6DE80", VA = "0x180D6EC80")]
	internal void CallAPITeamResultTablePoling([Optional] Action onFinish)
	{
	}

	[Token(Token = "0x6008C1E")]
	[Address(RVA = "0xD6E880", Offset = "0xD6DA80", VA = "0x180D6E880", Slot = "28")]
	internal virtual void CallAPIRoomSetUserComment(int commentID)
	{
	}

	[Token(Token = "0x6008C1F")]
	[Address(RVA = "0xD6FEB0", Offset = "0xD6F0B0", VA = "0x180D6FEB0")]
	internal void OnErrorCallAPI(TeamCode teamCode)
	{
	}

	[Token(Token = "0x6008C20")]
	[Address(RVA = "0xD6E920", Offset = "0xD6DB20", VA = "0x180D6E920")]
	internal void CallAPITeamCreate(Action onSuccess)
	{
	}

	[Token(Token = "0x6008C21")]
	[Address(RVA = "0xD6EAC0", Offset = "0xD6DCC0", VA = "0x180D6EAC0")]
	internal void CallAPITeamEntryNewTeam(int teamId, Action onSuccess)
	{
	}

	[Token(Token = "0x6008C22")]
	[Address(RVA = "0xD6E7B0", Offset = "0xD6D9B0", VA = "0x180D6E7B0")]
	protected void CallAPIPvPWatchDuel(long pcode)
	{
	}

	[Token(Token = "0x6008C23")]
	[Address(RVA = "0xD6E6C0", Offset = "0xD6D8C0", VA = "0x180D6E6C0")]
	public static void CallAPIPlayReplay(Util.GameMode gameMode, long did, int idx = 0, int eid = 0, [Optional] Action<PvPCode> onFailed)
	{
	}

	[Token(Token = "0x6008C24")]
	[Address(RVA = "0xD6EBE0", Offset = "0xD6DDE0", VA = "0x180D6EBE0")]
	internal void CallAPITeamExitRoom()
	{
	}

	[Token(Token = "0x6008C25")]
	[Address(RVA = "0xD75D20", Offset = "0xD74F20", VA = "0x180D75D20")]
	public TeamResultViewController()
	{
	}
}
