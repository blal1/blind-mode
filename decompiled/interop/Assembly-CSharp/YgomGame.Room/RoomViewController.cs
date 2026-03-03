using System;
using System.Collections.Generic;
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
using YgomSystem.UI.InfinityScroll;

namespace YgomGame.Room;

[Token(Token = "0x2000B14")]
public class RoomViewController : BaseMenuViewController, IBackButtonWithoutSCSupported, IBackButtonSupported, IHeaderBorderSupported
{
	[Token(Token = "0x2000B15")]
	internal abstract class RoomBehaviour
	{
		[Token(Token = "0x2000B16")]
		internal enum TableStatus
		{
			[Token(Token = "0x4009568")]
			WAIT = 1,
			[Token(Token = "0x4009569")]
			READY_RIGHT,
			[Token(Token = "0x400956A")]
			READY_LEFT,
			[Token(Token = "0x400956B")]
			DUEL,
			[Token(Token = "0x400956C")]
			SPECTATE
		}

		[Token(Token = "0x2000B17")]
		internal enum SittingState
		{
			[Token(Token = "0x400956E")]
			NONE,
			[Token(Token = "0x400956F")]
			MY_PLAYER_LEFT,
			[Token(Token = "0x4009570")]
			MY_PLAYER_RIGHT
		}

		[Token(Token = "0x2000B18")]
		internal class TableData
		{
			[Token(Token = "0x4009571")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			internal MemberData[] members;

			[Token(Token = "0x4009572")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			internal TableStatus status;

			[Token(Token = "0x17000916")]
			internal SittingState sittingState
			{
				[Token(Token = "0x6004425")]
				[Address(RVA = "0x62E220", Offset = "0x62D420", VA = "0x18062E220")]
				[CompilerGenerated]
				get
				{
					return default(SittingState);
				}
				[Token(Token = "0x6004424")]
				[Address(RVA = "0x62E250", Offset = "0x62D450", VA = "0x18062E250")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x17000917")]
			internal bool myPlayerEntry
			{
				[Token(Token = "0x6004426")]
				[Address(RVA = "0x8DAE80", Offset = "0x8DA080", VA = "0x1808DAE80")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x6004427")]
			[Address(RVA = "0x8DAE20", Offset = "0x8DA020", VA = "0x1808DAE20")]
			public TableData(MemberData[] members, TableStatus status, SittingState sittingState)
			{
			}
		}

		[Token(Token = "0x2000B19")]
		internal class MemberData
		{
			[Token(Token = "0x4009574")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			internal long pcode;

			[Token(Token = "0x4009575")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			internal string name;

			[Token(Token = "0x4009576")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			internal int iconID;

			[Token(Token = "0x4009577")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			internal int iconFrameID;

			[Token(Token = "0x4009578")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			internal int commentID;

			[Token(Token = "0x4009579")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			internal bool isResistedPlatform;

			[Token(Token = "0x400957A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2D")]
			internal bool isSamePlatform;

			[Token(Token = "0x400957B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			internal string platformName;

			[Token(Token = "0x6004428")]
			[Address(RVA = "0x8C9370", Offset = "0x8C8570", VA = "0x1808C9370")]
			public MemberData()
			{
			}
		}

		[Token(Token = "0x2000B1A")]
		internal class RoomInfo
		{
			[Token(Token = "0x400957C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			internal int roomID;

			[Token(Token = "0x400957D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			internal string roomName;

			[Token(Token = "0x400957E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			internal long roomMasterID;

			[Token(Token = "0x400957F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			internal int memberNum;

			[Token(Token = "0x4009580")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			internal int roomSpecterID;

			[Token(Token = "0x4009581")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			internal int specterNum;

			[Token(Token = "0x4009582")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			internal int memberMax;

			[Token(Token = "0x4009583")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			internal int regID;

			[Token(Token = "0x4009584")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			internal string regulation;

			[Token(Token = "0x4009585")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			internal int roomComment;

			[Token(Token = "0x4009586")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			internal bool canEnterFree;

			[Token(Token = "0x4009587")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4D")]
			internal bool canWatchRoom;

			[Token(Token = "0x4009588")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4E")]
			internal bool canWatchEnterFree;

			[Token(Token = "0x4009589")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			internal int havePlayTime;

			[Token(Token = "0x400958A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			internal int LP;

			[Token(Token = "0x400958B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			internal bool canWatchReplay;

			[Token(Token = "0x17000918")]
			internal int regID_in_client
			{
				[Token(Token = "0x6004429")]
				[Address(RVA = "0x8D40C0", Offset = "0x8D32C0", VA = "0x1808D40C0")]
				get
				{
					return default(int);
				}
			}

			[Token(Token = "0x600442A")]
			[Address(RVA = "0x8D4040", Offset = "0x8D3240", VA = "0x1808D4040")]
			public RoomInfo()
			{
			}
		}

		[Token(Token = "0x4009544")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		protected readonly string BTN_LABEL;

		[Token(Token = "0x4009545")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		protected readonly string ROOT_MENU_LABEL;

		[Token(Token = "0x4009546")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		protected readonly string TMP_BTN_MENU_LABEL;

		[Token(Token = "0x4009547")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		protected readonly string TXT_LABEL;

		[Token(Token = "0x4009548")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		protected readonly string BTN_EXIT_LABEL;

		[Token(Token = "0x4009549")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		protected readonly string BTN_DECK_LABEL;

		[Token(Token = "0x400954A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		protected readonly string BTN_DECK_READONLY_LABEL;

		[Token(Token = "0x400954B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		protected readonly string BTN_ENTRY_LABEL;

		[Token(Token = "0x400954C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		protected readonly string BTN_COMMENT_RIGHT_LABEL;

		[Token(Token = "0x400954D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		protected readonly string BTN_COMMENT_LEFT_LABEL;

		[Token(Token = "0x400954E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		protected readonly string BTN_LEAVE_LABEL;

		[Token(Token = "0x400954F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		protected readonly string TXT_ROOM_MEMBER_LABEL;

		[Token(Token = "0x4009550")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		protected readonly string TXT_ROOM_NAME_LABEL;

		[Token(Token = "0x4009551")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		protected readonly string TXT_ROOM_WATCHER_LABEL;

		[Token(Token = "0x4009552")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		protected readonly string ROOT_ROOM_WATCHER_LABEL;

		[Token(Token = "0x4009553")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		protected readonly string IMG_ICON_LABEL;

		[Token(Token = "0x4009554")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		protected readonly string TXT_TITLE_LABEL;

		[Token(Token = "0x4009555")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		protected readonly string TXT_REGULATION_LABEL;

		[Token(Token = "0x4009556")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		protected readonly string ICON_REGULATION_LABEL;

		[Token(Token = "0x4009557")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		protected readonly string PLATFORM_NAME_LABEL;

		[Token(Token = "0x4009558")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		protected readonly string PLATFORM_ICON_LABEL;

		[Token(Token = "0x4009559")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		protected readonly string TXT_STATUS_LABEL;

		[Token(Token = "0x400955A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		protected readonly string TXT_COMMENT_LABEL;

		[Token(Token = "0x400955B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		protected readonly string OBJ_COMMENT_LABEL;

		[Token(Token = "0x400955C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private int callingApiCount;

		[Token(Token = "0x400955D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		internal readonly ViewControllerManager manager;

		[Token(Token = "0x400955E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		internal readonly RoomViewController vc;

		[Token(Token = "0x400955F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		internal readonly ElementObjectManager viewEom;

		[Token(Token = "0x4009560")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		internal readonly InfinityScrollView isv;

		[Token(Token = "0x4009561")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		internal RoomInfo roomInfo;

		[Token(Token = "0x4009562")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		internal List<TableData> tableDataList;

		[Token(Token = "0x4009563")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		protected long myPcode;

		[Token(Token = "0x4009564")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		protected bool isSittingPlayer;

		[Token(Token = "0x4009565")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		protected string[] _tableComments;

		[Token(Token = "0x4009566")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		protected string beforeRoomName;

		[Token(Token = "0x17000915")]
		internal bool isCallingAPI
		{
			[Token(Token = "0x6004406")]
			[Address(RVA = "0x8D0030", Offset = "0x8CF230", VA = "0x1808D0030")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6004407")]
		[Address(RVA = "0x8CFA30", Offset = "0x8CEC30", VA = "0x1808CFA30")]
		internal RoomBehaviour(ViewControllerManager manager, RoomViewController vc, ElementObjectManager viewEom, InfinityScrollView isv)
		{
		}

		[Token(Token = "0x6004408")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "4")]
		internal virtual void OnTerminal()
		{
		}

		[Token(Token = "0x6004409")]
		internal abstract void InitRoom();

		[Token(Token = "0x600440A")]
		[Address(RVA = "0x8CF2C0", Offset = "0x8CE4C0", VA = "0x1808CF2C0", Slot = "6")]
		internal virtual void UpdateTable(ElementObjectManager eom, int index)
		{
		}

		[Token(Token = "0x600440B")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "7")]
		internal virtual void OnCreatedEntity(GameObject go)
		{
		}

		[Token(Token = "0x600440C")]
		[Address(RVA = "0x8CD6C0", Offset = "0x8CC8C0", VA = "0x1808CD6C0")]
		private void SetComment(MatchingComment balloon, MemberData data)
		{
		}

		[Token(Token = "0x600440D")]
		[Address(RVA = "0x8CD350", Offset = "0x8CC550", VA = "0x1808CD350")]
		public bool OnClickActionWithCheckSitting(UnityAction onFinish)
		{
			return default(bool);
		}

		[Token(Token = "0x600440E")]
		protected abstract void CreateMenuButtons();

		[Token(Token = "0x600440F")]
		[Address(RVA = "0x8CD0A0", Offset = "0x8CC2A0", VA = "0x1808CD0A0")]
		protected SelectionButton CreateMenuButton(Selector selector, GameObject template, string label, [Optional] UnityAction onClick, bool isDefaultItem = false)
		{
			return null;
		}

		[Token(Token = "0x6004410")]
		[Address(RVA = "0x8CD7B0", Offset = "0x8CC9B0", VA = "0x1808CD7B0", Slot = "9")]
		internal virtual void SetRoomInfo()
		{
		}

		[Token(Token = "0x6004411")]
		[Address(RVA = "0x8CEE30", Offset = "0x8CE030", VA = "0x1808CEE30", Slot = "10")]
		internal virtual void UpdateRoom()
		{
		}

		[Token(Token = "0x6004412")]
		[Address(RVA = "0x8CDF70", Offset = "0x8CD170", VA = "0x1808CDF70", Slot = "11")]
		internal virtual void SetTable(bool isUpdateDataCount = false)
		{
		}

		[Token(Token = "0x6004413")]
		[Address(RVA = "0x8CD4E0", Offset = "0x8CC6E0", VA = "0x1808CD4E0")]
		protected void OnClickExitButton()
		{
		}

		[Token(Token = "0x6004414")]
		[Address(RVA = "0x8CC940", Offset = "0x8CBB40", VA = "0x1808CC940")]
		protected void AddCallingCount()
		{
		}

		[Token(Token = "0x6004415")]
		[Address(RVA = "0x8CD340", Offset = "0x8CC540", VA = "0x1808CD340")]
		protected void DecCallingCount()
		{
		}

		[Token(Token = "0x6004416")]
		[Address(RVA = "0x8CCCE0", Offset = "0x8CBEE0", VA = "0x1808CCCE0", Slot = "12")]
		protected virtual void CallAPIRoomExit()
		{
		}

		[Token(Token = "0x6004417")]
		[Address(RVA = "0x8CCFB0", Offset = "0x8CC1B0", VA = "0x1808CCFB0", Slot = "13")]
		internal virtual void CallAPIRoomTablePoling([Optional] Action onFinish, bool isInit = false)
		{
		}

		[Token(Token = "0x6004418")]
		[Address(RVA = "0x8CCE20", Offset = "0x8CC020", VA = "0x1808CCE20", Slot = "14")]
		internal virtual void CallAPIRoomTableArrive(int tableNo)
		{
		}

		[Token(Token = "0x6004419")]
		[Address(RVA = "0x8CCEC0", Offset = "0x8CC0C0", VA = "0x1808CCEC0", Slot = "15")]
		internal virtual void CallAPIRoomTableLeave([Optional] UnityAction onSuccess)
		{
		}

		[Token(Token = "0x600441A")]
		[Address(RVA = "0x8CCB80", Offset = "0x8CBD80", VA = "0x1808CCB80", Slot = "16")]
		internal virtual void CallAPIRoomBattleReady(bool isReady, long rivalPcode = 0L)
		{
		}

		[Token(Token = "0x600441B")]
		[Address(RVA = "0x8CCD80", Offset = "0x8CBF80", VA = "0x1808CCD80", Slot = "17")]
		internal virtual void CallAPIRoomSetUserComment(int commentID)
		{
		}

		[Token(Token = "0x600441C")]
		[Address(RVA = "0x8CC950", Offset = "0x8CBB50", VA = "0x1808CC950")]
		protected void CallAPIPvPWatchDuel(long pcode)
		{
		}

		[Token(Token = "0x600441D")]
		[Address(RVA = "0x8CD640", Offset = "0x8CC840", VA = "0x1808CD640")]
		internal void OnErrorCallAPI(RoomCode roomCode)
		{
		}
	}

	[Token(Token = "0x2000B23")]
	internal class RoomBehaviourNormal : RoomBehaviour
	{
		[Token(Token = "0x2000B24")]
		private enum MenuBtn
		{
			[Token(Token = "0x40095AF")]
			NONE,
			[Token(Token = "0x40095B0")]
			INFO,
			[Token(Token = "0x40095B1")]
			MEMBER,
			[Token(Token = "0x40095B2")]
			REPLAY,
			[Token(Token = "0x40095B3")]
			INVITE,
			[Token(Token = "0x40095B4")]
			DECK,
			[Token(Token = "0x40095B5")]
			DECK_READONLY
		}

		[Token(Token = "0x2000B25")]
		private enum DeckSelectKind
		{
			[Token(Token = "0x40095B7")]
			EDIT,
			[Token(Token = "0x40095B8")]
			EDIT_ACCESSORRY,
			[Token(Token = "0x40095B9")]
			CHANGE,
			[Token(Token = "0x40095BA")]
			CONFIRM
		}

		[Token(Token = "0x40095AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		private Dictionary<int, SelectionButton> _menuButtonmap;

		[Token(Token = "0x40095AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		protected DeckCaseWidget deckCase;

		[Token(Token = "0x40095AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		protected StringBuilder deckNameBuf;

		[Token(Token = "0x40095AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		private int currentDeckId;

		[Token(Token = "0x6004448")]
		[Address(RVA = "0x8CC7E0", Offset = "0x8CB9E0", VA = "0x1808CC7E0")]
		public RoomBehaviourNormal(ViewControllerManager manager, RoomViewController vc, ElementObjectManager viewEom, InfinityScrollView isv)
		{
		}

		[Token(Token = "0x6004449")]
		[Address(RVA = "0x8CACD0", Offset = "0x8C9ED0", VA = "0x1808CACD0", Slot = "4")]
		internal override void OnTerminal()
		{
		}

		[Token(Token = "0x600444A")]
		[Address(RVA = "0x8C94F0", Offset = "0x8C86F0", VA = "0x1808C94F0", Slot = "8")]
		protected override void CreateMenuButtons()
		{
		}

		[Token(Token = "0x600444B")]
		[Address(RVA = "0x8CA030", Offset = "0x8C9230", VA = "0x1808CA030", Slot = "5")]
		internal override void InitRoom()
		{
		}

		[Token(Token = "0x600444C")]
		[Address(RVA = "0x8CBC30", Offset = "0x8CAE30", VA = "0x1808CBC30", Slot = "6")]
		internal override void UpdateTable(ElementObjectManager eom, int index)
		{
		}

		[Token(Token = "0x600444D")]
		[Address(RVA = "0x8CA7C0", Offset = "0x8C99C0", VA = "0x1808CA7C0", Slot = "7")]
		internal override void OnCreatedEntity(GameObject go)
		{
		}

		[Token(Token = "0x600444E")]
		[Address(RVA = "0x8CB910", Offset = "0x8CAB10", VA = "0x1808CB910")]
		public void UpdateDeck()
		{
		}

		[Token(Token = "0x600444F")]
		[Address(RVA = "0x8CAEB0", Offset = "0x8CA0B0", VA = "0x1808CAEB0", Slot = "18")]
		internal virtual bool SetDeck(int did)
		{
			return default(bool);
		}

		[Token(Token = "0x6004450")]
		[Address(RVA = "0x8C9400", Offset = "0x8C8600", VA = "0x1808C9400", Slot = "19")]
		internal virtual void CallAPIDeckCheck([Optional] Action onFinish)
		{
		}

		[Token(Token = "0x6004451")]
		[Address(RVA = "0x8CA1E0", Offset = "0x8C93E0", VA = "0x1808CA1E0")]
		private void OnClickDeck()
		{
		}

		[Token(Token = "0x6004452")]
		[Address(RVA = "0x8C9D20", Offset = "0x8C8F20", VA = "0x1808C9D20")]
		private IReadOnlyList<(SelectionItem, int, int)> CustomCollectionSelectionItems(GameObject entity)
		{
			return null;
		}

		[Token(Token = "0x6004453")]
		[Address(RVA = "0x8CB4A0", Offset = "0x8CA6A0", VA = "0x1808CB4A0", Slot = "11")]
		internal override void SetTable(bool isUpdateDataCount = false)
		{
		}

		[Token(Token = "0x6004454")]
		[Address(RVA = "0x8CAD20", Offset = "0x8C9F20", VA = "0x1808CAD20")]
		private void RestrictMenuButtons(bool on)
		{
		}

		[Token(Token = "0x6004455")]
		[Address(RVA = "0x8C9F50", Offset = "0x8C9150", VA = "0x1808C9F50")]
		private void GotoDeckSelect()
		{
		}

		[Token(Token = "0x6004456")]
		[Address(RVA = "0x8CAA10", Offset = "0x8C9C10", VA = "0x1808CAA10")]
		private void OnSelectInActionSheet(int select)
		{
		}
	}

	[Token(Token = "0x2000B30")]
	internal class RoomBehaviourSpecter : RoomBehaviour
	{
		[Token(Token = "0x6004481")]
		[Address(RVA = "0x8F3320", Offset = "0x8F2520", VA = "0x1808F3320")]
		internal RoomBehaviourSpecter(ViewControllerManager manager, RoomViewController vc, ElementObjectManager viewEom, InfinityScrollView isv)
		{
		}

		[Token(Token = "0x6004482")]
		[Address(RVA = "0x8F27A0", Offset = "0x8F19A0", VA = "0x1808F27A0", Slot = "8")]
		protected override void CreateMenuButtons()
		{
		}

		[Token(Token = "0x6004483")]
		[Address(RVA = "0x8F2EF0", Offset = "0x8F20F0", VA = "0x1808F2EF0", Slot = "7")]
		internal override void OnCreatedEntity(GameObject go)
		{
		}

		[Token(Token = "0x6004484")]
		[Address(RVA = "0x8F2DA0", Offset = "0x8F1FA0", VA = "0x1808F2DA0", Slot = "5")]
		internal override void InitRoom()
		{
		}

		[Token(Token = "0x6004485")]
		[Address(RVA = "0x8F3090", Offset = "0x8F2290", VA = "0x1808F3090", Slot = "6")]
		internal override void UpdateTable(ElementObjectManager eom, int index)
		{
		}

		[Token(Token = "0x6004486")]
		[Address(RVA = "0x8F2C90", Offset = "0x8F1E90", VA = "0x1808F2C90")]
		private IReadOnlyList<(SelectionItem, int, int)> CustomCollectionSelectionItems(GameObject entity)
		{
			return null;
		}
	}

	[Token(Token = "0x2000B34")]
	private static class Util
	{
		[Token(Token = "0x6004490")]
		[Address(RVA = "0x8FC470", Offset = "0x8FB670", VA = "0x1808FC470")]
		internal static int GetValueFromAccessory(Dictionary<string, object> accessory, string keyName)
		{
			return default(int);
		}
	}

	[Token(Token = "0x400953C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	private readonly string SCROLL_LABEL;

	[Token(Token = "0x400953D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	private readonly string SC_BACK_LABEL;

	[Token(Token = "0x400953E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	private readonly string k_ALabelDeckOverview;

	[Token(Token = "0x400953F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	private ElementObjectManager _deckOverview;

	[Token(Token = "0x4009540")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	private RoomBehaviour roomBehaviour;

	[Token(Token = "0x4009541")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	private InfinityScrollView isv;

	[Token(Token = "0x4009542")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
	private RoomEntryViewController.Mode mode;

	[Token(Token = "0x4009543")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
	private float pastSec;

	[Token(Token = "0x17000912")]
	protected override Type[] textIds
	{
		[Token(Token = "0x60043F2")]
		[Address(RVA = "0x8DAC20", Offset = "0x8D9E20", VA = "0x1808DAC20", Slot = "21")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000913")]
	protected override int selectorPriorityAddRange
	{
		[Token(Token = "0x60043F3")]
		[Address(RVA = "0x4B8E10", Offset = "0x4B8010", VA = "0x1804B8E10", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000914")]
	protected bool existDialog
	{
		[Token(Token = "0x60043F4")]
		[Address(RVA = "0x8DAAB0", Offset = "0x8D9CB0", VA = "0x1808DAAB0")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x60043F5")]
	[Address(RVA = "0x8DA7B0", Offset = "0x8D99B0", VA = "0x1808DA7B0")]
	private void Update()
	{
	}

	[Token(Token = "0x60043F6")]
	[Address(RVA = "0x8D9830", Offset = "0x8D8A30", VA = "0x1808D9830", Slot = "8")]
	public override void NotificationStack(ViewControllerManager vcm, ViewController vc, bool isEntry)
	{
	}

	[Token(Token = "0x60043F7")]
	[Address(RVA = "0x8D96D0", Offset = "0x8D88D0", VA = "0x1808D96D0", Slot = "6")]
	public override void NotificationStackEntry()
	{
	}

	[Token(Token = "0x60043F8")]
	[Address(RVA = "0x8D97F0", Offset = "0x8D89F0", VA = "0x1808D97F0", Slot = "7")]
	public override void NotificationStackRemove()
	{
	}

	[Token(Token = "0x60043F9")]
	[Address(RVA = "0x8D9C30", Offset = "0x8D8E30", VA = "0x1808D9C30", Slot = "23")]
	protected override void OnCreatedView()
	{
	}

	[Token(Token = "0x60043FA")]
	[Address(RVA = "0x8DA170", Offset = "0x8D9370", VA = "0x1808DA170", Slot = "14")]
	public override bool OnResult(ViewController from, object value)
	{
		return default(bool);
	}

	[Token(Token = "0x60043FB")]
	[Address(RVA = "0x8D9BA0", Offset = "0x8D8DA0", VA = "0x1808D9BA0", Slot = "13")]
	public override bool OnBack()
	{
		return default(bool);
	}

	[Token(Token = "0x60043FC")]
	[Address(RVA = "0x8DA720", Offset = "0x8D9920", VA = "0x1808DA720")]
	private void UpdateEntity(GameObject gob, int index)
	{
	}

	[Token(Token = "0x60043FD")]
	[Address(RVA = "0x8D91D0", Offset = "0x8D83D0", VA = "0x1808D91D0")]
	public GameObject CreateEmbedObj(int deckId)
	{
		return null;
	}

	[Token(Token = "0x60043FE")]
	[Address(RVA = "0x8DAA00", Offset = "0x8D9C00", VA = "0x1808DAA00")]
	public RoomViewController()
	{
	}
}
