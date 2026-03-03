using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;
using YgomGame.Common;
using YgomGame.Menu;
using YgomGame.Menu.Common;
using YgomSystem.ElementSystem;
using YgomSystem.Network;
using YgomSystem.UI;
using YgomSystem.YGomTMPro;

namespace YgomGame.Team;

[Token(Token = "0x2001690")]
public class TeamRoomViewController : BaseMenuViewController, TeamLobbyPollingWatcher.ICallback, IHeaderBorderSupported
{
	[Token(Token = "0x2001691")]
	internal abstract class TeamBehaviour
	{
		[Token(Token = "0x2001692")]
		internal class TableData
		{
			[Token(Token = "0x400D784")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			internal MemberData member;

			[Token(Token = "0x400D785")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			internal string regulation;

			[Token(Token = "0x400D786")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			internal int regulationID;

			[Token(Token = "0x400D787")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			internal int index;

			[Token(Token = "0x17001563")]
			internal bool entry
			{
				[Token(Token = "0x6008CA2")]
				[Address(RVA = "0x588F60", Offset = "0x588160", VA = "0x180588F60")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x6008CA1")]
				[Address(RVA = "0x588F70", Offset = "0x588170", VA = "0x180588F70")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Token(Token = "0x6008CA3")]
			[Address(RVA = "0xD802B0", Offset = "0xD7F4B0", VA = "0x180D802B0")]
			public TableData(MemberData member, int regulationID, string regulation, int index, bool entry)
			{
			}
		}

		[Token(Token = "0x2001693")]
		internal class MemberData
		{
			[Token(Token = "0x400D789")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			internal long pcode;

			[Token(Token = "0x400D78A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			internal string name;

			[Token(Token = "0x400D78B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			internal int iconID;

			[Token(Token = "0x400D78C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			internal int iconFrameID;

			[Token(Token = "0x400D78D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			internal int commentID;

			[Token(Token = "0x400D78E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			internal bool isResistedPlatform;

			[Token(Token = "0x400D78F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2D")]
			internal bool isSamePlatform;

			[Token(Token = "0x400D790")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			internal string platformName;

			[Token(Token = "0x400D791")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			internal string regulation;

			[Token(Token = "0x400D792")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			internal bool isMyAccount;

			[Token(Token = "0x6008CA4")]
			[Address(RVA = "0xD7A5F0", Offset = "0xD797F0", VA = "0x180D7A5F0")]
			public MemberData()
			{
			}
		}

		[Token(Token = "0x2001694")]
		internal class TeamRoomInfo
		{
			[Token(Token = "0x400D793")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			internal int teamID;

			[Token(Token = "0x400D794")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			internal string roomName;

			[Token(Token = "0x400D795")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			internal long roomMasterID;

			[Token(Token = "0x400D796")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			internal int memberNum;

			[Token(Token = "0x400D797")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			internal int roomSpecterID;

			[Token(Token = "0x400D798")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			internal int specterNum;

			[Token(Token = "0x400D799")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			internal int memberMax;

			[Token(Token = "0x400D79A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			internal int regID;

			[Token(Token = "0x400D79B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			internal string regulation;

			[Token(Token = "0x400D79C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			internal int roomComment;

			[Token(Token = "0x400D79D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			internal int cardMrk;

			[Token(Token = "0x6008CA5")]
			[Address(RVA = "0xD89A80", Offset = "0xD88C80", VA = "0x180D89A80")]
			public TeamRoomInfo()
			{
			}
		}

		[Token(Token = "0x400D74E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		protected readonly string BTN_LABEL;

		[Token(Token = "0x400D74F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		protected readonly string TXT_LABEL;

		[Token(Token = "0x400D750")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		protected readonly string ROOT_MENU_LABEL;

		[Token(Token = "0x400D751")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		protected readonly string TMP_BTN_MENU_LABEL;

		[Token(Token = "0x400D752")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		protected readonly string BTN_EXIT_LABEL;

		[Token(Token = "0x400D753")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		protected readonly string BTN_DECK_LABEL;

		[Token(Token = "0x400D754")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		protected readonly string BTN_DECK_READONLY_LABEL;

		[Token(Token = "0x400D755")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		protected readonly string CARD_AREA_LABEL;

		[Token(Token = "0x400D756")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		protected readonly string IMG_ICON_LABEL;

		[Token(Token = "0x400D757")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		protected readonly string PLATFORM_NAME_LABEL;

		[Token(Token = "0x400D758")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		protected readonly string PLATFORM_ICON_LABEL;

		[Token(Token = "0x400D759")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		protected readonly string TXT_TITLE_LABEL;

		[Token(Token = "0x400D75A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		protected readonly string TXT_ROOM_MEMBER_LABEL;

		[Token(Token = "0x400D75B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		protected readonly string TXT_TEAM_NAME_LABEL;

		[Token(Token = "0x400D75C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		protected readonly string BTN_COMMENT_LEFT_LABEL;

		[Token(Token = "0x400D75D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		protected readonly string BTN_ENTRY_LABEL;

		[Token(Token = "0x400D75E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		protected readonly string TXT_ENTRY_BUTTON_STATUS_LABEL;

		[Token(Token = "0x400D75F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		protected readonly string BTN_LEAVE_LABEL;

		[Token(Token = "0x400D760")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		protected readonly string OBJ_COMMENT_LABEL;

		[Token(Token = "0x400D761")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		protected readonly string TXT_COMMENT_LABEL;

		[Token(Token = "0x400D762")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		protected readonly string OBJ_CARDIMAGE_LABEL;

		[Token(Token = "0x400D763")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		protected readonly string TMP_SMALLBUTTON_LABEL;

		[Token(Token = "0x400D764")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		protected readonly string OBJ_SMALLBUTTON_GROUP_LABEL;

		[Token(Token = "0x400D765")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		protected readonly string BTN_REGULATION_LABEL;

		[Token(Token = "0x400D766")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		protected readonly string BTN_DECIDE_LABEL;

		[Token(Token = "0x400D767")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		protected readonly string BTN_DECIDE_DESIGNATION_LABEL;

		[Token(Token = "0x400D768")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		internal readonly ViewControllerManager manager;

		[Token(Token = "0x400D769")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		internal readonly TeamRoomViewController vc;

		[Token(Token = "0x400D76A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		internal readonly ElementObjectManager viewEom;

		[Token(Token = "0x400D76B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		protected long myPcode;

		[Token(Token = "0x400D76C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		protected bool isSitting;

		[Token(Token = "0x400D76D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		protected string beforeRoomName;

		[Token(Token = "0x400D76E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		protected string[] _tableComments;

		[Token(Token = "0x400D76F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		internal Dictionary<int, string> regulationList;

		[Token(Token = "0x400D770")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		internal int mySelectRegulationId;

		[Token(Token = "0x400D771")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x124")]
		private int callingApiCount;

		[Token(Token = "0x400D772")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		internal int currentDeckId;

		[Token(Token = "0x400D773")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		internal TeamRoomInfo teamRoomInfo;

		[Token(Token = "0x400D774")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		internal List<TableData> tableDataList;

		[Token(Token = "0x400D775")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		protected DeckCaseWidget deckCase;

		[Token(Token = "0x400D776")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		protected StringBuilder deckNameBuf;

		[Token(Token = "0x400D777")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		internal int dataCount;

		[Token(Token = "0x400D778")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x154")]
		internal int teamCardId;

		[Token(Token = "0x400D779")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		internal bool isRoomInfoExist;

		[Token(Token = "0x400D77A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x159")]
		internal bool isStartTeamDuelMatching;

		[Token(Token = "0x400D77B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x15A")]
		internal bool isStartTeamMateMatching;

		[Token(Token = "0x400D77C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x15B")]
		internal bool isOpenWatingWindow;

		[Token(Token = "0x400D77D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x15C")]
		internal bool isTeamMemberRecruted;

		[Token(Token = "0x400D77E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x15D")]
		internal bool isSearchedMember;

		[Token(Token = "0x400D77F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x15E")]
		internal bool isClickedTeamMemberMatching;

		[Token(Token = "0x400D780")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x15F")]
		protected bool _isLeader;

		[Token(Token = "0x400D781")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		internal Dictionary<int, GameObject> _tableTemplates;

		[Token(Token = "0x400D782")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		protected internal TeamLobbyPollingWatcher watchDog;

		[Token(Token = "0x400D783")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
		protected List<(int id, string name, int duration, int order)> _duelDurationConfigItems;

		[Token(Token = "0x17001562")]
		internal bool isCallingApi
		{
			[Token(Token = "0x6008C6F")]
			[Address(RVA = "0xD89A70", Offset = "0xD88C70", VA = "0x180D89A70")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6008C70")]
		[Address(RVA = "0xD89420", Offset = "0xD88620", VA = "0x180D89420")]
		internal TeamBehaviour(ViewControllerManager manager, TeamRoomViewController vc, ElementObjectManager viewEom)
		{
		}

		[Token(Token = "0x6008C71")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "4")]
		internal virtual void PlayDUELBtnTextChanging(string text)
		{
		}

		[Token(Token = "0x6008C72")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		internal virtual void StopDUELBtnTextChanging()
		{
		}

		[Token(Token = "0x6008C73")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "6")]
		internal virtual void OnApplyingStatusChanged(TeamLobbyPollingWatcher.ApplyingBattleData data)
		{
		}

		[Token(Token = "0x6008C74")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "7")]
		internal virtual void OnAppliedFromOtherTeam(TeamLobbyPollingWatcher.AppliedBattleData data)
		{
		}

		[Token(Token = "0x6008C75")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "8")]
		internal virtual void OnOpponentTeamInfoUpdated(OpponentTeamInfo data)
		{
		}

		[Token(Token = "0x6008C76")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "9")]
		internal virtual void Onterminal()
		{
		}

		[Token(Token = "0x6008C77")]
		internal abstract void Initialize();

		[Token(Token = "0x6008C78")]
		protected abstract void CreateMenuButtons([Optional] Action onFinished);

		[Token(Token = "0x6008C79")]
		[Address(RVA = "0xD86750", Offset = "0xD85950", VA = "0x180D86750")]
		internal void OnRemove()
		{
		}

		[Token(Token = "0x6008C7A")]
		[Address(RVA = "0xD86400", Offset = "0xD85600", VA = "0x180D86400")]
		public bool OnClickActionWithCheckSitting(UnityAction onFinish)
		{
			return default(bool);
		}

		[Token(Token = "0x6008C7B")]
		[Address(RVA = "0xD862C0", Offset = "0xD854C0", VA = "0x180D862C0")]
		public void OnClickActionStartDuel(UnityAction onFinish)
		{
		}

		[Token(Token = "0x6008C7C")]
		[Address(RVA = "0xD86590", Offset = "0xD85790", VA = "0x180D86590")]
		public void OnClickExitButton()
		{
		}

		[Token(Token = "0x6008C7D")]
		[Address(RVA = "0xD88800", Offset = "0xD87A00", VA = "0x180D88800")]
		public void ShowCompleteEffect()
		{
		}

		[Token(Token = "0x6008C7E")]
		[Address(RVA = "0xD856D0", Offset = "0xD848D0", VA = "0x180D856D0")]
		protected SelectionButton CreateMenuButton(Selector selector, GameObject template, string label, [Optional] UnityAction onClick, bool isDefaultItem = false, bool isCheck = false)
		{
			return null;
		}

		[Token(Token = "0x6008C7F")]
		[Address(RVA = "0xD85570", Offset = "0xD84770", VA = "0x180D85570")]
		protected void ChangeButtonCallback(SelectionButton button, UnityAction newAction, bool isSittingCheck = false)
		{
		}

		[Token(Token = "0x6008C80")]
		[Address(RVA = "0xD86F40", Offset = "0xD86140", VA = "0x180D86F40")]
		internal void SetCallbackInputLeft(SelectionButton btn)
		{
		}

		[Token(Token = "0x6008C81")]
		[Address(RVA = "0xD859E0", Offset = "0xD84BE0", VA = "0x180D859E0")]
		protected GameObject CreateTableTemplate(GameObject template)
		{
			return null;
		}

		[Token(Token = "0x6008C82")]
		[Address(RVA = "0xD879D0", Offset = "0xD86BD0", VA = "0x180D879D0", Slot = "12")]
		internal virtual void SetTeamRoomInfo()
		{
		}

		[Token(Token = "0x6008C83")]
		[Address(RVA = "0xD86C80", Offset = "0xD85E80", VA = "0x180D86C80")]
		internal void SetBGCard(int mrk, bool active = true)
		{
		}

		[Token(Token = "0x6008C84")]
		[Address(RVA = "0xD891C0", Offset = "0xD883C0", VA = "0x180D891C0", Slot = "13")]
		internal virtual void UpdateRoom()
		{
		}

		[Token(Token = "0x6008C85")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "14")]
		internal virtual void UpdateTable()
		{
		}

		[Token(Token = "0x6008C86")]
		[Address(RVA = "0xD88020", Offset = "0xD87220", VA = "0x180D88020", Slot = "15")]
		internal virtual void SetTeamTable(bool isUpdateDataCount = false)
		{
		}

		[Token(Token = "0x6008C87")]
		[Address(RVA = "0xD88E90", Offset = "0xD88090", VA = "0x180D88E90")]
		internal void UpdateDeck()
		{
		}

		[Token(Token = "0x6008C88")]
		[Address(RVA = "0xD87370", Offset = "0xD86570", VA = "0x180D87370", Slot = "16")]
		internal virtual bool SetDeck(int did)
		{
			return default(bool);
		}

		[Token(Token = "0x6008C89")]
		[Address(RVA = "0xD85D40", Offset = "0xD84F40", VA = "0x180D85D40")]
		protected void LoadDuelDurationConfig()
		{
		}

		[Token(Token = "0x6008C8A")]
		[Address(RVA = "0xD85B90", Offset = "0xD84D90", VA = "0x180D85B90")]
		public static Dictionary<string, object> GetTeamInfo()
		{
			return null;
		}

		[Token(Token = "0x6008C8B")]
		[Address(RVA = "0xD85CE0", Offset = "0xD84EE0", VA = "0x180D85CE0")]
		public static List<object> GetTeamTable()
		{
			return null;
		}

		[Token(Token = "0x6008C8C")]
		[Address(RVA = "0xD85BF0", Offset = "0xD84DF0", VA = "0x180D85BF0")]
		public static Dictionary<string, object> GetTeamMemberInfo(long pcode)
		{
			return null;
		}

		[Token(Token = "0x6008C8D")]
		[Address(RVA = "0xD85B00", Offset = "0xD84D00", VA = "0x180D85B00")]
		public static int GetTeamComment(long pcode)
		{
			return default(int);
		}

		[Token(Token = "0x6008C8E")]
		[Address(RVA = "0xD85C80", Offset = "0xD84E80", VA = "0x180D85C80")]
		public static Dictionary<string, object> GetTeamRegulation()
		{
			return null;
		}

		[Token(Token = "0x6008C8F")]
		[Address(RVA = "0xD85AA0", Offset = "0xD84CA0", VA = "0x180D85AA0")]
		public static Dictionary<string, object> GetDeckInfo()
		{
			return null;
		}

		[Token(Token = "0x6008C90")]
		[Address(RVA = "0xD850A0", Offset = "0xD842A0", VA = "0x180D850A0")]
		protected void AddCallingCount()
		{
		}

		[Token(Token = "0x6008C91")]
		[Address(RVA = "0xD85A90", Offset = "0xD84C90", VA = "0x180D85A90")]
		protected void DecCallingCount()
		{
		}

		[Token(Token = "0x6008C92")]
		[Address(RVA = "0xD850B0", Offset = "0xD842B0", VA = "0x180D850B0", Slot = "17")]
		internal virtual void CallAPIDeckCheck([Optional] Action onFinish)
		{
		}

		[Token(Token = "0x6008C93")]
		[Address(RVA = "0xD85240", Offset = "0xD84440", VA = "0x180D85240")]
		internal void CallAPITeamExitRoom()
		{
		}

		[Token(Token = "0x6008C94")]
		[Address(RVA = "0xD852E0", Offset = "0xD844E0", VA = "0x180D852E0")]
		internal void CallAPITeamRoomTablePoling([Optional] Action onFinish, bool init = false)
		{
		}

		[Token(Token = "0x6008C95")]
		[Address(RVA = "0xD867E0", Offset = "0xD859E0", VA = "0x180D867E0")]
		internal void OnTablePollingResponsed(Handle handle, Action onFinish, bool init)
		{
		}

		[Token(Token = "0x6008C96")]
		[Address(RVA = "0xD853E0", Offset = "0xD845E0", VA = "0x180D853E0", Slot = "18")]
		internal virtual void CallAPITeamTableArrive(int tableNo)
		{
		}

		[Token(Token = "0x6008C97")]
		[Address(RVA = "0xD85480", Offset = "0xD84680", VA = "0x180D85480", Slot = "19")]
		internal virtual void CallAPITeamTableLeave([Optional] UnityAction onSuccess)
		{
		}

		[Token(Token = "0x6008C98")]
		[Address(RVA = "0xD851A0", Offset = "0xD843A0", VA = "0x180D851A0", Slot = "20")]
		internal virtual void CallAPIRoomSetUserComment(int commentID)
		{
		}

		[Token(Token = "0x6008C99")]
		[Address(RVA = "0xD86720", Offset = "0xD85920", VA = "0x180D86720")]
		internal void OnErrorCallAPI(TeamCode teamCode)
		{
		}
	}

	[Token(Token = "0x200169D")]
	internal class TeamBehaviourNormal : TeamBehaviour
	{
		[Token(Token = "0x200169E")]
		private enum MenuBtn
		{
			[Token(Token = "0x400D7BC")]
			NONE,
			[Token(Token = "0x400D7BD")]
			INFO,
			[Token(Token = "0x400D7BE")]
			MEMBER,
			[Token(Token = "0x400D7BF")]
			INVITE,
			[Token(Token = "0x400D7C0")]
			RECRUIT,
			[Token(Token = "0x400D7C1")]
			REGULATION,
			[Token(Token = "0x400D7C2")]
			DECK,
			[Token(Token = "0x400D7C3")]
			DECK_READONLY,
			[Token(Token = "0x400D7C4")]
			APPLY_TEAM_ID
		}

		[Token(Token = "0x400D7B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
		private Dictionary<int, SelectionButton> _menuButtonmap;

		[Token(Token = "0x400D7B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
		private SelectionButton _duelButton_random;

		[Token(Token = "0x400D7B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
		private SelectionButton _duelButton_designation;

		[Token(Token = "0x400D7B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
		private List<string> regulationStringList;

		[Token(Token = "0x400D7B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
		private int[] regulationIntList;

		[Token(Token = "0x400D7B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
		private bool NotAllMR;

		[Token(Token = "0x400D7BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
		private ExtendedTextMeshProUGUI _teamIdApplyText;

		[Token(Token = "0x6008CBB")]
		[Address(RVA = "0xD84DD0", Offset = "0xD83FD0", VA = "0x180D84DD0")]
		public TeamBehaviourNormal(ViewControllerManager manager, TeamRoomViewController vc, ElementObjectManager viewEom)
		{
		}

		[Token(Token = "0x6008CBC")]
		[Address(RVA = "0xD82230", Offset = "0xD81430", VA = "0x180D82230", Slot = "10")]
		internal override void Initialize()
		{
		}

		[Token(Token = "0x6008CBD")]
		[Address(RVA = "0xD83700", Offset = "0xD82900", VA = "0x180D83700", Slot = "12")]
		internal override void SetTeamRoomInfo()
		{
		}

		[Token(Token = "0x6008CBE")]
		[Address(RVA = "0xD829A0", Offset = "0xD81BA0", VA = "0x180D829A0", Slot = "6")]
		internal override void OnApplyingStatusChanged(TeamLobbyPollingWatcher.ApplyingBattleData data)
		{
		}

		[Token(Token = "0x6008CBF")]
		[Address(RVA = "0xD82470", Offset = "0xD81670", VA = "0x180D82470", Slot = "7")]
		internal override void OnAppliedFromOtherTeam(TeamLobbyPollingWatcher.AppliedBattleData data)
		{
		}

		[Token(Token = "0x6008CC0")]
		[Address(RVA = "0xD82F10", Offset = "0xD82110", VA = "0x180D82F10", Slot = "8")]
		internal override void OnOpponentTeamInfoUpdated(OpponentTeamInfo data)
		{
		}

		[Token(Token = "0x6008CC1")]
		[Address(RVA = "0xD81F70", Offset = "0xD81170", VA = "0x180D81F70")]
		protected void CreateTableTemplates()
		{
		}

		[Token(Token = "0x6008CC2")]
		[Address(RVA = "0xD838E0", Offset = "0xD82AE0", VA = "0x180D838E0", Slot = "15")]
		internal override void SetTeamTable(bool isEntry = false)
		{
		}

		[Token(Token = "0x6008CC3")]
		[Address(RVA = "0xD805B0", Offset = "0xD7F7B0", VA = "0x180D805B0", Slot = "11")]
		protected override void CreateMenuButtons([Optional] Action onFinished)
		{
		}

		[Token(Token = "0x6008CC4")]
		[Address(RVA = "0xD84EE0", Offset = "0xD840E0", VA = "0x180D84EE0")]
		private void setRegualtionIntList(Dictionary<string, object> value)
		{
		}

		[Token(Token = "0x6008CC5")]
		[Address(RVA = "0xD834B0", Offset = "0xD826B0", VA = "0x180D834B0")]
		private void RestrictMenuButtons(bool on)
		{
		}

		[Token(Token = "0x6008CC6")]
		[Address(RVA = "0xD83270", Offset = "0xD82470", VA = "0x180D83270")]
		private void RestrictEachMenuButton(MenuBtn kind, SelectionButton button, bool on)
		{
		}

		[Token(Token = "0x6008CC7")]
		[Address(RVA = "0xD83FA0", Offset = "0xD831A0", VA = "0x180D83FA0", Slot = "14")]
		internal override void UpdateTable()
		{
		}

		[Token(Token = "0x6008CC8")]
		[Address(RVA = "0xD83610", Offset = "0xD82810", VA = "0x180D83610")]
		private void SetComment(MatchingComment balloon, MemberData data)
		{
		}

		[Token(Token = "0x6008CC9")]
		[Address(RVA = "0xD83690", Offset = "0xD82890", VA = "0x180D83690")]
		private void SetDUELButtonPushable(bool pushable)
		{
		}

		[Token(Token = "0x6008CCA")]
		[Address(RVA = "0xD83040", Offset = "0xD82240", VA = "0x180D83040", Slot = "4")]
		internal override void PlayDUELBtnTextChanging(string text)
		{
		}

		[Token(Token = "0x6008CCB")]
		[Address(RVA = "0xD83D10", Offset = "0xD82F10", VA = "0x180D83D10", Slot = "5")]
		internal override void StopDUELBtnTextChanging()
		{
		}

		[Token(Token = "0x6008CCC")]
		[Address(RVA = "0xD80320", Offset = "0xD7F520", VA = "0x180D80320")]
		private void ChangeTeamIDDesignateButton(bool designatable)
		{
		}

		[Token(Token = "0x6008CCD")]
		[Address(RVA = "0xD82DC0", Offset = "0xD81FC0", VA = "0x180D82DC0")]
		private void OnClickDeck()
		{
		}

		[Token(Token = "0x6008CCE")]
		[Address(RVA = "0xD82E40", Offset = "0xD82040", VA = "0x180D82E40")]
		private void OnGoingToDesignation()
		{
		}

		[Token(Token = "0x6008CCF")]
		[Address(RVA = "0xD82C30", Offset = "0xD81E30", VA = "0x180D82C30")]
		private void OnCancelingDesignation()
		{
		}
	}

	[Token(Token = "0x20016A8")]
	[CompilerGenerated]
	private sealed class _003CwaitPolling_003Ed__8 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400D7E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400D7E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400D7E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public TeamRoomViewController _003C_003E4__this;

		[Token(Token = "0x17001564")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6008D00")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17001565")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6008D02")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6008CFD")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CwaitPolling_003Ed__8(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6008CFE")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6008CFF")]
		[Address(RVA = "0xD90CA0", Offset = "0xD8FEA0", VA = "0x180D90CA0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6008D01")]
		[Address(RVA = "0xD90F00", Offset = "0xD90100", VA = "0x180D90F00", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x400D74C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	private TeamBehaviour teamBehaviour;

	[Token(Token = "0x400D74D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	private bool isBackDuelClientError;

	[Token(Token = "0x17001560")]
	protected override Type[] textIds
	{
		[Token(Token = "0x6008C61")]
		[Address(RVA = "0xD8A9A0", Offset = "0xD89BA0", VA = "0x180D8A9A0", Slot = "21")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001561")]
	protected bool existDialog
	{
		[Token(Token = "0x6008C62")]
		[Address(RVA = "0xD8A830", Offset = "0xD89A30", VA = "0x180D8A830")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6008C63")]
	[Address(RVA = "0xD8AC70", Offset = "0xD89E70", VA = "0x180D8AC70")]
	[IteratorStateMachine(typeof(_003CwaitPolling_003Ed__8))]
	private IEnumerator waitPolling()
	{
		return null;
	}

	[Token(Token = "0x6008C64")]
	[Address(RVA = "0xD89BA0", Offset = "0xD88DA0", VA = "0x180D89BA0", Slot = "8")]
	public override void NotificationStack(ViewControllerManager vcm, ViewController vc, bool isEntry)
	{
	}

	[Token(Token = "0x6008C65")]
	[Address(RVA = "0x3E4080", Offset = "0x3E3280", VA = "0x1803E4080", Slot = "6")]
	public override void NotificationStackEntry()
	{
	}

	[Token(Token = "0x6008C66")]
	[Address(RVA = "0xD89AF0", Offset = "0xD88CF0", VA = "0x180D89AF0", Slot = "7")]
	public override void NotificationStackRemove()
	{
	}

	[Token(Token = "0x6008C67")]
	[Address(RVA = "0xD8A5F0", Offset = "0xD897F0", VA = "0x180D8A5F0", Slot = "14")]
	public override bool OnResult(ViewController from, object value)
	{
		return default(bool);
	}

	[Token(Token = "0x6008C68")]
	[Address(RVA = "0xD8A3E0", Offset = "0xD895E0", VA = "0x180D8A3E0", Slot = "23")]
	protected override void OnCreatedView()
	{
	}

	[Token(Token = "0x6008C69")]
	[Address(RVA = "0xD8A590", Offset = "0xD89790", VA = "0x180D8A590", Slot = "28")]
	public void OnPollingResponse(Handle handle)
	{
	}

	[Token(Token = "0x6008C6A")]
	[Address(RVA = "0xD8A3A0", Offset = "0xD895A0", VA = "0x180D8A3A0", Slot = "29")]
	public void OnApplyingStatusChanged(TeamLobbyPollingWatcher.ApplyingBattleData data)
	{
	}

	[Token(Token = "0x6008C6B")]
	[Address(RVA = "0xD8A360", Offset = "0xD89560", VA = "0x180D8A360", Slot = "30")]
	public void OnAppliedFromOtherTeam(TeamLobbyPollingWatcher.AppliedBattleData data)
	{
	}

	[Token(Token = "0x6008C6C")]
	[Address(RVA = "0xD8A560", Offset = "0xD89760", VA = "0x180D8A560", Slot = "31")]
	public void OnOpponentTeamInfoUpdated(OpponentTeamInfo data)
	{
	}

	[Token(Token = "0x6008C6D")]
	[Address(RVA = "0x3E3340", Offset = "0x3E2540", VA = "0x1803E3340")]
	public TeamRoomViewController()
	{
	}
}
