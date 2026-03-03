using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using YgomGame.Duel;
using YgomGame.Menu;
using YgomSystem.ElementSystem;
using YgomSystem.UI.InfinityScroll;

namespace YgomGame.Colosseum;

[Token(Token = "0x2001BCB")]
public class ColosseumHistoryViewController : BaseMenuViewController, IBackButtonSupported, IHeaderBorderSupported
{
	[Token(Token = "0x2001BCC")]
	internal interface ICustomBgSupported
	{
		[Token(Token = "0x600B4E5")]
		int GetBgId();
	}

	[Token(Token = "0x2001BCD")]
	internal abstract class ModeBehaviour
	{
		[Token(Token = "0x2001BCE")]
		protected class Data
		{
			[Token(Token = "0x400FB84")]
			[FieldOffset(Offset = "0x10")]
			public int idx;

			[Token(Token = "0x400FB85")]
			[FieldOffset(Offset = "0x18")]
			public long did;

			[Token(Token = "0x400FB86")]
			[FieldOffset(Offset = "0x20")]
			public int mode;

			[Token(Token = "0x400FB87")]
			[FieldOffset(Offset = "0x28")]
			public long pcode;

			[Token(Token = "0x400FB88")]
			[FieldOffset(Offset = "0x30")]
			public int iconID;

			[Token(Token = "0x400FB89")]
			[FieldOffset(Offset = "0x34")]
			public int frameID;

			[Token(Token = "0x400FB8A")]
			[FieldOffset(Offset = "0x38")]
			public int rank;

			[Token(Token = "0x400FB8B")]
			[FieldOffset(Offset = "0x3C")]
			public int tier;

			[Token(Token = "0x400FB8C")]
			[FieldOffset(Offset = "0x40")]
			public string date;

			[Token(Token = "0x400FB8D")]
			[FieldOffset(Offset = "0x48")]
			public string name;

			[Token(Token = "0x400FB8E")]
			[FieldOffset(Offset = "0x50")]
			public Engine.ResultType result;

			[Token(Token = "0x400FB8F")]
			[FieldOffset(Offset = "0x54")]
			public int turn;

			[Token(Token = "0x400FB90")]
			[FieldOffset(Offset = "0x58")]
			public int eventId;

			[Token(Token = "0x400FB91")]
			[FieldOffset(Offset = "0x5C")]
			public int groupId;

			[Token(Token = "0x400FB92")]
			[FieldOffset(Offset = "0x60")]
			public long time;

			[Token(Token = "0x400FB93")]
			[FieldOffset(Offset = "0x68")]
			public bool isResistedPlatform;

			[Token(Token = "0x400FB94")]
			[FieldOffset(Offset = "0x69")]
			public bool isSamePlatform;

			[Token(Token = "0x400FB95")]
			[FieldOffset(Offset = "0x70")]
			public string platformName;

			[Token(Token = "0x600B50D")]
			[Address(RVA = "0x4C37C0", Offset = "0x4C29C0", VA = "0x1804C37C0")]
			public Data(int idx, long did, int mode, long pcode, int iconID, int frameID, int rank, int tier, string date, string name, Engine.ResultType result, int turn, int eventId, int groupId, long time, bool isResistedPlatform = false, bool isSamePlatform = false, string platformName = "")
			{
			}
		}

		[Token(Token = "0x400FB70")]
		[FieldOffset(Offset = "0x10")]
		protected readonly string IMG_RANK_LABEL;

		[Token(Token = "0x400FB71")]
		[FieldOffset(Offset = "0x18")]
		protected readonly string IMG_VERSUSLOGO_LABEL;

		[Token(Token = "0x400FB72")]
		[FieldOffset(Offset = "0x20")]
		protected readonly string TMP_BTN_LABEL;

		[Token(Token = "0x400FB73")]
		[FieldOffset(Offset = "0x28")]
		protected readonly string TMP_IMG_ICON_LABEL;

		[Token(Token = "0x400FB74")]
		[FieldOffset(Offset = "0x30")]
		protected readonly string TMP_TXT_DATE_LABEL;

		[Token(Token = "0x400FB75")]
		[FieldOffset(Offset = "0x38")]
		protected readonly string TMP_TXT_RESULT_LABEL;

		[Token(Token = "0x400FB76")]
		[FieldOffset(Offset = "0x40")]
		protected readonly string TMP_TXT_TURN_LABEL;

		[Token(Token = "0x400FB77")]
		[FieldOffset(Offset = "0x48")]
		protected readonly string TMP_TXT_TITLE_LABEL;

		[Token(Token = "0x400FB78")]
		[FieldOffset(Offset = "0x50")]
		protected readonly string TMP_TITLE_TEXT_LABEL;

		[Token(Token = "0x400FB79")]
		[FieldOffset(Offset = "0x58")]
		protected readonly string TXT_TITLE_LABEL;

		[Token(Token = "0x400FB7A")]
		[FieldOffset(Offset = "0x60")]
		protected readonly string TXT_NOTBOOKMARK_LABEL;

		[Token(Token = "0x400FB7B")]
		[FieldOffset(Offset = "0x68")]
		protected readonly string PLATFORM_NAME_LABEL;

		[Token(Token = "0x400FB7C")]
		[FieldOffset(Offset = "0x70")]
		protected readonly string PLATFORM_ICON_LABEL;

		[Token(Token = "0x400FB7D")]
		[FieldOffset(Offset = "0x78")]
		protected readonly ColosseumHistoryViewController vc;

		[Token(Token = "0x400FB7E")]
		[FieldOffset(Offset = "0x80")]
		protected readonly InfinityScrollView isv;

		[Token(Token = "0x400FB7F")]
		[FieldOffset(Offset = "0x88")]
		protected readonly ElementObjectManager eom;

		[Token(Token = "0x400FB80")]
		[FieldOffset(Offset = "0x90")]
		protected readonly int id;

		[Token(Token = "0x400FB81")]
		[FieldOffset(Offset = "0x94")]
		protected readonly Util.GameMode duelUtilGameMode;

		[Token(Token = "0x400FB82")]
		[FieldOffset(Offset = "0x98")]
		protected List<Data> dataList;

		[Token(Token = "0x400FB83")]
		[FieldOffset(Offset = "0xA0")]
		protected long limitTs;

		[Token(Token = "0x17001BAF")]
		protected virtual string CWKEY_MYID
		{
			[Token(Token = "0x600B4E6")]
			[Address(RVA = "0x4C7ED0", Offset = "0x4C70D0", VA = "0x1804C7ED0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17001BB0")]
		protected virtual string CWKEY_DID
		{
			[Token(Token = "0x600B4E7")]
			[Address(RVA = "0x4C7D90", Offset = "0x4C6F90", VA = "0x1804C7D90", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17001BB1")]
		protected virtual string CWKEY_ICON
		{
			[Token(Token = "0x600B4E8")]
			[Address(RVA = "0x4C7E40", Offset = "0x4C7040", VA = "0x1804C7E40", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17001BB2")]
		protected virtual string CWKEY_ICONFRAME
		{
			[Token(Token = "0x600B4E9")]
			[Address(RVA = "0x4C7E10", Offset = "0x4C7010", VA = "0x1804C7E10", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17001BB3")]
		protected virtual string CWKEY_DATE
		{
			[Token(Token = "0x600B4EA")]
			[Address(RVA = "0x4C7D60", Offset = "0x4C6F60", VA = "0x1804C7D60", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17001BB4")]
		protected virtual string CWKEY_PLAYER
		{
			[Token(Token = "0x600B4EB")]
			[Address(RVA = "0x4C7F90", Offset = "0x4C7190", VA = "0x1804C7F90", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17001BB5")]
		protected virtual string CWKEY_PCODE
		{
			[Token(Token = "0x600B4EC")]
			[Address(RVA = "0x4C7F60", Offset = "0x4C7160", VA = "0x1804C7F60", Slot = "10")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17001BB6")]
		protected virtual string CWKEY_NAME
		{
			[Token(Token = "0x600B4ED")]
			[Address(RVA = "0x4C7F00", Offset = "0x4C7100", VA = "0x1804C7F00", Slot = "11")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17001BB7")]
		protected virtual string CWKEY_RANK
		{
			[Token(Token = "0x600B4EE")]
			[Address(RVA = "0x4C7FC0", Offset = "0x4C71C0", VA = "0x1804C7FC0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17001BB8")]
		protected virtual string CWKEY_RATE
		{
			[Token(Token = "0x600B4EF")]
			[Address(RVA = "0x4C7FF0", Offset = "0x4C71F0", VA = "0x1804C7FF0", Slot = "13")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17001BB9")]
		protected virtual string CWKEY_RES
		{
			[Token(Token = "0x600B4F0")]
			[Address(RVA = "0x4C8020", Offset = "0x4C7220", VA = "0x1804C8020", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17001BBA")]
		protected virtual string CWKEY_TURN
		{
			[Token(Token = "0x600B4F1")]
			[Address(RVA = "0x4C8080", Offset = "0x4C7280", VA = "0x1804C8080", Slot = "15")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17001BBB")]
		protected virtual string CWKEY_TIME
		{
			[Token(Token = "0x600B4F2")]
			[Address(RVA = "0x4C8050", Offset = "0x4C7250", VA = "0x1804C8050", Slot = "16")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17001BBC")]
		protected virtual string CWKEY_ONLINEID
		{
			[Token(Token = "0x600B4F3")]
			[Address(RVA = "0x4C7F30", Offset = "0x4C7130", VA = "0x1804C7F30", Slot = "17")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17001BBD")]
		protected virtual string CWKEY_ISSAMEOS
		{
			[Token(Token = "0x600B4F4")]
			[Address(RVA = "0x4C7E70", Offset = "0x4C7070", VA = "0x1804C7E70", Slot = "18")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17001BBE")]
		protected virtual string CWKEY_MODE
		{
			[Token(Token = "0x600B4F5")]
			[Address(RVA = "0x4C7EA0", Offset = "0x4C70A0", VA = "0x1804C7EA0", Slot = "19")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17001BBF")]
		protected virtual string CWKEY_GROUPID
		{
			[Token(Token = "0x600B4F6")]
			[Address(RVA = "0x4C7DE0", Offset = "0x4C6FE0", VA = "0x1804C7DE0", Slot = "20")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17001BC0")]
		protected virtual string CWKEY_EVENTID
		{
			[Token(Token = "0x600B4F7")]
			[Address(RVA = "0x4C7DC0", Offset = "0x4C6FC0", VA = "0x1804C7DC0", Slot = "21")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17001BC1")]
		protected virtual int ADJUST_ISV_INDEX
		{
			[Token(Token = "0x600B4F8")]
			[Address(RVA = "0x3EF020", Offset = "0x3EE220", VA = "0x1803EF020", Slot = "22")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x600B4F9")]
		[Address(RVA = "0x4C7A60", Offset = "0x4C6C60", VA = "0x1804C7A60")]
		protected ModeBehaviour(ColosseumHistoryViewController vc, InfinityScrollView isv, ElementObjectManager eom, int id, Util.GameMode gameMode)
		{
		}

		[Token(Token = "0x600B4FA")]
		internal abstract void CallAPI();

		[Token(Token = "0x600B4FB")]
		internal abstract string GetTitle();

		[Token(Token = "0x600B4FC")]
		[Address(RVA = "0x4C4FB0", Offset = "0x4C41B0", VA = "0x1804C4FB0", Slot = "25")]
		internal virtual void InitializeScroll()
		{
		}

		[Token(Token = "0x600B4FD")]
		[Address(RVA = "0x4C79F0", Offset = "0x4C6BF0", VA = "0x1804C79F0", Slot = "26")]
		internal virtual void UpdateView(Dictionary<string, object> dictionary)
		{
		}

		[Token(Token = "0x600B4FE")]
		[Address(RVA = "0x404830", Offset = "0x403A30", VA = "0x180404830", Slot = "27")]
		internal virtual bool CanStartUpdateEntity(GameObject go, int dataIndex)
		{
			return default(bool);
		}

		[Token(Token = "0x600B4FF")]
		[Address(RVA = "0x4C4CA0", Offset = "0x4C3EA0", VA = "0x1804C4CA0", Slot = "28")]
		protected virtual void BindRankIcon(Data data, ElementObjectManager entityEom)
		{
		}

		[Token(Token = "0x600B500")]
		[Address(RVA = "0x4C5010", Offset = "0x4C4210", VA = "0x1804C5010", Slot = "29")]
		protected virtual void OnClickButton(Data data)
		{
		}

		[Token(Token = "0x600B501")]
		[Address(RVA = "0x4C5FD0", Offset = "0x4C51D0", VA = "0x1804C5FD0")]
		protected void OpenActionSheetFull(Data data)
		{
		}

		[Token(Token = "0x600B502")]
		[Address(RVA = "0x4C5A20", Offset = "0x4C4C20", VA = "0x1804C5A20")]
		protected void OpenActionSheetFree(Data data)
		{
		}

		[Token(Token = "0x600B503")]
		[Address(RVA = "0x4C55F0", Offset = "0x4C47F0", VA = "0x1804C55F0")]
		protected void OpenActionSheetCup(Data data)
		{
		}

		[Token(Token = "0x600B504")]
		[Address(RVA = "0x4C50E0", Offset = "0x4C42E0", VA = "0x1804C50E0")]
		internal void OnSuccessAPI()
		{
		}

		[Token(Token = "0x600B505")]
		[Address(RVA = "0x4C5160", Offset = "0x4C4360", VA = "0x1804C5160")]
		internal void OnUpdateEntity(GameObject go, int dataIndex)
		{
		}

		[Token(Token = "0x600B506")]
		[Address(RVA = "0x4C5020", Offset = "0x4C4220", VA = "0x1804C5020", Slot = "30")]
		public virtual void OnCreatedEntity(GameObject go)
		{
		}

		[Token(Token = "0x600B507")]
		[Address(RVA = "0x4C4F10", Offset = "0x4C4110", VA = "0x1804C4F10", Slot = "31")]
		internal virtual void CallAPISaveReplay(long did, int eid = 0)
		{
		}

		[Token(Token = "0x600B508")]
		[Address(RVA = "0x4C7720", Offset = "0x4C6920", VA = "0x1804C7720")]
		protected void UpdateScrollData(Dictionary<string, object> dictionary)
		{
		}

		[Token(Token = "0x600B509")]
		[Address(RVA = "0x4C6B50", Offset = "0x4C5D50", VA = "0x1804C6B50")]
		protected Data SetData(KeyValuePair<string, object> kvp, Dictionary<string, object> dic)
		{
			return null;
		}

		[Token(Token = "0x600B50A")]
		[Address(RVA = "0x4C4F90", Offset = "0x4C4190", VA = "0x1804C4F90")]
		protected bool CanPlayReplay(long id, long time)
		{
			return default(bool);
		}

		[Token(Token = "0x600B50B")]
		[Address(RVA = "0x4C6580", Offset = "0x4C5780", VA = "0x1804C6580")]
		protected void OpenReportDialog(long opponentId)
		{
		}

		[Token(Token = "0x600B50C")]
		[Address(RVA = "0x4C4E10", Offset = "0x4C4010", VA = "0x1804C4E10")]
		protected void CallAPIPvPGetHistoryDeck(long did, int mode, int exid, int idx, int isOwn)
		{
		}
	}

	[Token(Token = "0x2001BD6")]
	internal class StandardBehaviour : ModeBehaviour
	{
		[Token(Token = "0x2001BD7")]
		private class DataRankHistory
		{
			[Token(Token = "0x400FBB2")]
			[FieldOffset(Offset = "0x10")]
			public readonly int rank;

			[Token(Token = "0x400FBB3")]
			[FieldOffset(Offset = "0x14")]
			public readonly int tier;

			[Token(Token = "0x600B52E")]
			[Address(RVA = "0x4C3770", Offset = "0x4C2970", VA = "0x1804C3770")]
			public DataRankHistory(int rank, int tier)
			{
			}
		}

		[Token(Token = "0x400FBAD")]
		[FieldOffset(Offset = "0xA8")]
		protected readonly string IMG_OPEN_LABEL;

		[Token(Token = "0x400FBAE")]
		private const int RECENT_RANK_DATA_INDEX = 0;

		[Token(Token = "0x400FBAF")]
		private const int RECENT_RANK_TEMPLATE_INDEX = 1;

		[Token(Token = "0x400FBB0")]
		private const int RANK_HISTORY_NUM = 6;

		[Token(Token = "0x400FBB1")]
		[FieldOffset(Offset = "0xB0")]
		private DataRankHistory[] dataRankHistorys;

		[Token(Token = "0x17001BC2")]
		protected override string CWKEY_EVENTID
		{
			[Token(Token = "0x600B524")]
			[Address(RVA = "0x4C9F00", Offset = "0x4C9100", VA = "0x1804C9F00", Slot = "21")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17001BC3")]
		protected override int ADJUST_ISV_INDEX
		{
			[Token(Token = "0x600B525")]
			[Address(RVA = "0x4C9EF0", Offset = "0x4C90F0", VA = "0x1804C9EF0", Slot = "22")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x600B526")]
		[Address(RVA = "0x4C9D40", Offset = "0x4C8F40", VA = "0x1804C9D40")]
		public StandardBehaviour(ColosseumHistoryViewController vc, InfinityScrollView isv, ElementObjectManager eom, int id, Util.GameMode gameMode)
		{
		}

		[Token(Token = "0x600B527")]
		[Address(RVA = "0x4C8EA0", Offset = "0x4C80A0", VA = "0x1804C8EA0", Slot = "23")]
		internal override void CallAPI()
		{
		}

		[Token(Token = "0x600B528")]
		[Address(RVA = "0x4C9540", Offset = "0x4C8740", VA = "0x1804C9540", Slot = "25")]
		internal override void InitializeScroll()
		{
		}

		[Token(Token = "0x600B529")]
		[Address(RVA = "0x4C98A0", Offset = "0x4C8AA0", VA = "0x1804C98A0", Slot = "26")]
		internal override void UpdateView(Dictionary<string, object> dictionary)
		{
		}

		[Token(Token = "0x600B52A")]
		[Address(RVA = "0x4C8F50", Offset = "0x4C8150", VA = "0x1804C8F50", Slot = "27")]
		internal override bool CanStartUpdateEntity(GameObject go, int dataIndex)
		{
			return default(bool);
		}

		[Token(Token = "0x600B52B")]
		[Address(RVA = "0x4C94E0", Offset = "0x4C86E0", VA = "0x1804C94E0", Slot = "24")]
		internal override string GetTitle()
		{
			return null;
		}
	}

	[Token(Token = "0x2001BD9")]
	internal class RateBehaviour : ModeBehaviour, ICustomBgSupported
	{
		[Token(Token = "0x400FBB6")]
		[FieldOffset(Offset = "0xA8")]
		protected readonly string IMG_OPEN_LABEL;

		[Token(Token = "0x17001BC4")]
		protected override string CWKEY_EVENTID
		{
			[Token(Token = "0x600B532")]
			[Address(RVA = "0x4C8E70", Offset = "0x4C8070", VA = "0x1804C8E70", Slot = "21")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600B533")]
		[Address(RVA = "0x4C8CF0", Offset = "0x4C7EF0", VA = "0x1804C8CF0")]
		public RateBehaviour(ColosseumHistoryViewController vc, InfinityScrollView isv, ElementObjectManager eom, int id, Util.GameMode gameMode)
		{
		}

		[Token(Token = "0x600B534")]
		[Address(RVA = "0x4C8A70", Offset = "0x4C7C70", VA = "0x1804C8A70", Slot = "23")]
		internal override void CallAPI()
		{
		}

		[Token(Token = "0x600B535")]
		[Address(RVA = "0x4C8B20", Offset = "0x4C7D20", VA = "0x1804C8B20", Slot = "24")]
		internal override string GetTitle()
		{
			return null;
		}

		[Token(Token = "0x600B536")]
		[Address(RVA = "0x4C89C0", Offset = "0x4C7BC0", VA = "0x1804C89C0", Slot = "28")]
		protected override void BindRankIcon(Data data, ElementObjectManager entityEom)
		{
		}

		[Token(Token = "0x600B537")]
		[Address(RVA = "0x4C4200", Offset = "0x4C3400", VA = "0x1804C4200", Slot = "29")]
		protected override void OnClickButton(Data data)
		{
		}

		[Token(Token = "0x600B538")]
		[Address(RVA = "0x3FC090", Offset = "0x3FB290", VA = "0x1803FC090", Slot = "32")]
		private int YgomGame_002EColosseum_002EColosseumHistoryViewController_002EICustomBgSupported_002EGetBgId()
		{
			return default(int);
		}
	}

	[Token(Token = "0x2001BDB")]
	internal class TournamentBehaviour : ModeBehaviour
	{
		[Token(Token = "0x17001BC5")]
		protected override string CWKEY_EVENTID
		{
			[Token(Token = "0x600B53D")]
			[Address(RVA = "0x4CA300", Offset = "0x4C9500", VA = "0x1804CA300", Slot = "21")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600B53E")]
		[Address(RVA = "0x4CA1B0", Offset = "0x4C93B0", VA = "0x1804CA1B0")]
		public TournamentBehaviour(ColosseumHistoryViewController vc, InfinityScrollView isv, ElementObjectManager eom, int id, Util.GameMode gameMode)
		{
		}

		[Token(Token = "0x600B53F")]
		[Address(RVA = "0x4C9F30", Offset = "0x4C9130", VA = "0x1804C9F30", Slot = "23")]
		internal override void CallAPI()
		{
		}

		[Token(Token = "0x600B540")]
		[Address(RVA = "0x4C9FE0", Offset = "0x4C91E0", VA = "0x1804C9FE0", Slot = "24")]
		internal override string GetTitle()
		{
			return null;
		}
	}

	[Token(Token = "0x2001BDD")]
	internal class ExhibitionBehaviour : ModeBehaviour
	{
		[Token(Token = "0x17001BC6")]
		protected override string CWKEY_EVENTID
		{
			[Token(Token = "0x600B545")]
			[Address(RVA = "0x4C48A0", Offset = "0x4C3AA0", VA = "0x1804C48A0", Slot = "21")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600B546")]
		[Address(RVA = "0x4C4750", Offset = "0x4C3950", VA = "0x1804C4750")]
		public ExhibitionBehaviour(ColosseumHistoryViewController vc, InfinityScrollView isv, ElementObjectManager eom, int id, Util.GameMode gameMode)
		{
		}

		[Token(Token = "0x600B547")]
		[Address(RVA = "0x4C44D0", Offset = "0x4C36D0", VA = "0x1804C44D0", Slot = "23")]
		internal override void CallAPI()
		{
		}

		[Token(Token = "0x600B548")]
		[Address(RVA = "0x4C4580", Offset = "0x4C3780", VA = "0x1804C4580", Slot = "24")]
		internal override string GetTitle()
		{
			return null;
		}
	}

	[Token(Token = "0x2001BDF")]
	internal class FreeBehaviour : ModeBehaviour
	{
		[Token(Token = "0x600B54D")]
		[Address(RVA = "0x4C4B50", Offset = "0x4C3D50", VA = "0x1804C4B50")]
		public FreeBehaviour(ColosseumHistoryViewController vc, InfinityScrollView isv, ElementObjectManager eom, int id, Util.GameMode gameMode)
		{
		}

		[Token(Token = "0x600B54E")]
		[Address(RVA = "0x4C48D0", Offset = "0x4C3AD0", VA = "0x1804C48D0", Slot = "23")]
		internal override void CallAPI()
		{
		}

		[Token(Token = "0x600B54F")]
		[Address(RVA = "0x4C4970", Offset = "0x4C3B70", VA = "0x1804C4970", Slot = "24")]
		internal override string GetTitle()
		{
			return null;
		}

		[Token(Token = "0x600B550")]
		[Address(RVA = "0x4C49D0", Offset = "0x4C3BD0", VA = "0x1804C49D0", Slot = "29")]
		protected override void OnClickButton(Data data)
		{
		}

		[Token(Token = "0x600B551")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "28")]
		protected override void BindRankIcon(Data data, ElementObjectManager entityEom)
		{
		}
	}

	[Token(Token = "0x2001BE1")]
	internal class DuelistCupBehaviour : ModeBehaviour
	{
		[Token(Token = "0x600B556")]
		[Address(RVA = "0x4C4380", Offset = "0x4C3580", VA = "0x1804C4380")]
		public DuelistCupBehaviour(ColosseumHistoryViewController vc, InfinityScrollView isv, ElementObjectManager eom, int id, Util.GameMode gameMode)
		{
		}

		[Token(Token = "0x600B557")]
		[Address(RVA = "0x4C40F0", Offset = "0x4C32F0", VA = "0x1804C40F0", Slot = "23")]
		internal override void CallAPI()
		{
		}

		[Token(Token = "0x600B558")]
		[Address(RVA = "0x4C41A0", Offset = "0x4C33A0", VA = "0x1804C41A0", Slot = "24")]
		internal override string GetTitle()
		{
			return null;
		}

		[Token(Token = "0x600B559")]
		[Address(RVA = "0x4C4200", Offset = "0x4C3400", VA = "0x1804C4200", Slot = "29")]
		protected override void OnClickButton(Data data)
		{
		}

		[Token(Token = "0x600B55A")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "28")]
		protected override void BindRankIcon(Data data, ElementObjectManager entityEom)
		{
		}
	}

	[Token(Token = "0x2001BE3")]
	internal class RankEventBehaviour : ModeBehaviour
	{
		[Token(Token = "0x17001BC7")]
		protected override string CWKEY_EVENTID
		{
			[Token(Token = "0x600B55F")]
			[Address(RVA = "0x4C8930", Offset = "0x4C7B30", VA = "0x1804C8930", Slot = "21")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17001BC8")]
		protected override string CWKEY_RANK
		{
			[Token(Token = "0x600B560")]
			[Address(RVA = "0x4C8960", Offset = "0x4C7B60", VA = "0x1804C8960", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17001BC9")]
		protected override string CWKEY_RATE
		{
			[Token(Token = "0x600B561")]
			[Address(RVA = "0x4C8990", Offset = "0x4C7B90", VA = "0x1804C8990", Slot = "13")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600B562")]
		[Address(RVA = "0x4C87E0", Offset = "0x4C79E0", VA = "0x1804C87E0")]
		public RankEventBehaviour(ColosseumHistoryViewController vc, InfinityScrollView isv, ElementObjectManager eom, int id, Util.GameMode gameMode)
		{
		}

		[Token(Token = "0x600B563")]
		[Address(RVA = "0x4C8560", Offset = "0x4C7760", VA = "0x1804C8560", Slot = "23")]
		internal override void CallAPI()
		{
		}

		[Token(Token = "0x600B564")]
		[Address(RVA = "0x4C8610", Offset = "0x4C7810", VA = "0x1804C8610", Slot = "24")]
		internal override string GetTitle()
		{
			return null;
		}

		[Token(Token = "0x600B565")]
		[Address(RVA = "0x4C8480", Offset = "0x4C7680", VA = "0x1804C8480", Slot = "28")]
		protected override void BindRankIcon(Data data, ElementObjectManager entityEom)
		{
		}
	}

	[Token(Token = "0x2001BE5")]
	internal class DuelTrialBehaviour : ModeBehaviour
	{
		[Token(Token = "0x17001BCA")]
		protected override string CWKEY_EVENTID
		{
			[Token(Token = "0x600B56A")]
			[Address(RVA = "0x4C40C0", Offset = "0x4C32C0", VA = "0x1804C40C0", Slot = "21")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600B56B")]
		[Address(RVA = "0x4C3F70", Offset = "0x4C3170", VA = "0x1804C3F70")]
		public DuelTrialBehaviour(ColosseumHistoryViewController vc, InfinityScrollView isv, ElementObjectManager eom, int id, Util.GameMode gameMode)
		{
		}

		[Token(Token = "0x600B56C")]
		[Address(RVA = "0x4C3CF0", Offset = "0x4C2EF0", VA = "0x1804C3CF0", Slot = "23")]
		internal override void CallAPI()
		{
		}

		[Token(Token = "0x600B56D")]
		[Address(RVA = "0x4C3DA0", Offset = "0x4C2FA0", VA = "0x1804C3DA0", Slot = "24")]
		internal override string GetTitle()
		{
			return null;
		}
	}

	[Token(Token = "0x2001BE7")]
	internal class WCSBehaviour : ModeBehaviour
	{
		[Token(Token = "0x600B572")]
		[Address(RVA = "0x4CF800", Offset = "0x4CEA00", VA = "0x1804CF800")]
		public WCSBehaviour(ColosseumHistoryViewController vc, InfinityScrollView isv, ElementObjectManager eom, int id, Util.GameMode gameMode)
		{
		}

		[Token(Token = "0x600B573")]
		[Address(RVA = "0x4CF580", Offset = "0x4CE780", VA = "0x1804CF580", Slot = "23")]
		internal override void CallAPI()
		{
		}

		[Token(Token = "0x600B574")]
		[Address(RVA = "0x4CF630", Offset = "0x4CE830", VA = "0x1804CF630", Slot = "24")]
		internal override string GetTitle()
		{
			return null;
		}

		[Token(Token = "0x600B575")]
		[Address(RVA = "0x4C4200", Offset = "0x4C3400", VA = "0x1804C4200", Slot = "29")]
		protected override void OnClickButton(Data data)
		{
		}

		[Token(Token = "0x600B576")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "28")]
		protected override void BindRankIcon(Data data, ElementObjectManager entityEom)
		{
		}
	}

	[Token(Token = "0x2001BE9")]
	internal class VersusBehaviour : ModeBehaviour
	{
		[Token(Token = "0x17001BCB")]
		protected override string CWKEY_EVENTID
		{
			[Token(Token = "0x600B57B")]
			[Address(RVA = "0x4CF550", Offset = "0x4CE750", VA = "0x1804CF550", Slot = "21")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600B57C")]
		[Address(RVA = "0x4CF400", Offset = "0x4CE600", VA = "0x1804CF400")]
		public VersusBehaviour(ColosseumHistoryViewController vc, InfinityScrollView isv, ElementObjectManager eom, int id, Util.GameMode gameMode)
		{
		}

		[Token(Token = "0x600B57D")]
		[Address(RVA = "0x4CF070", Offset = "0x4CE270", VA = "0x1804CF070", Slot = "23")]
		internal override void CallAPI()
		{
		}

		[Token(Token = "0x600B57E")]
		[Address(RVA = "0x4CF120", Offset = "0x4CE320", VA = "0x1804CF120", Slot = "24")]
		internal override string GetTitle()
		{
			return null;
		}

		[Token(Token = "0x600B57F")]
		[Address(RVA = "0x4CF180", Offset = "0x4CE380", VA = "0x1804CF180", Slot = "30")]
		public override void OnCreatedEntity(GameObject go)
		{
		}

		[Token(Token = "0x600B580")]
		[Address(RVA = "0x4CEE70", Offset = "0x4CE070", VA = "0x1804CEE70", Slot = "28")]
		protected override void BindRankIcon(Data data, ElementObjectManager entityEom)
		{
		}
	}

	[Token(Token = "0x2001BEB")]
	internal class RDCBehaviour : ModeBehaviour
	{
		[Token(Token = "0x600B585")]
		[Address(RVA = "0x4C8330", Offset = "0x4C7530", VA = "0x1804C8330")]
		public RDCBehaviour(ColosseumHistoryViewController vc, InfinityScrollView isv, ElementObjectManager eom, int id, Util.GameMode gameMode)
		{
		}

		[Token(Token = "0x600B586")]
		[Address(RVA = "0x4C80B0", Offset = "0x4C72B0", VA = "0x1804C80B0", Slot = "23")]
		internal override void CallAPI()
		{
		}

		[Token(Token = "0x600B587")]
		[Address(RVA = "0x4C8160", Offset = "0x4C7360", VA = "0x1804C8160", Slot = "24")]
		internal override string GetTitle()
		{
			return null;
		}

		[Token(Token = "0x600B588")]
		[Address(RVA = "0x4C4200", Offset = "0x4C3400", VA = "0x1804C4200", Slot = "29")]
		protected override void OnClickButton(Data data)
		{
		}

		[Token(Token = "0x600B589")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "28")]
		protected override void BindRankIcon(Data data, ElementObjectManager entityEom)
		{
		}
	}

	[Token(Token = "0x2001BED")]
	internal class DiceRallyBehaviour : ModeBehaviour
	{
		[Token(Token = "0x17001BCC")]
		protected override string CWKEY_EVENTID
		{
			[Token(Token = "0x600B58E")]
			[Address(RVA = "0x4C3CC0", Offset = "0x4C2EC0", VA = "0x1804C3CC0", Slot = "21")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600B58F")]
		[Address(RVA = "0x4C3B70", Offset = "0x4C2D70", VA = "0x1804C3B70")]
		public DiceRallyBehaviour(ColosseumHistoryViewController vc, InfinityScrollView isv, ElementObjectManager eom, int id, Util.GameMode gameMode)
		{
		}

		[Token(Token = "0x600B590")]
		[Address(RVA = "0x4C38F0", Offset = "0x4C2AF0", VA = "0x1804C38F0", Slot = "23")]
		internal override void CallAPI()
		{
		}

		[Token(Token = "0x600B591")]
		[Address(RVA = "0x4C39A0", Offset = "0x4C2BA0", VA = "0x1804C39A0", Slot = "24")]
		internal override string GetTitle()
		{
			return null;
		}
	}

	[Token(Token = "0x400FB6B")]
	[FieldOffset(Offset = "0xD0")]
	private readonly string SCROLL_REPLAY_LABEL;

	[Token(Token = "0x400FB6C")]
	[FieldOffset(Offset = "0xD8")]
	private readonly string TMP_RANK_LABEL;

	[Token(Token = "0x400FB6D")]
	private const int k_IsOwnId = 1;

	[Token(Token = "0x400FB6E")]
	[FieldOffset(Offset = "0xE0")]
	private ColosseumUtil.PlayMode mode;

	[Token(Token = "0x400FB6F")]
	[FieldOffset(Offset = "0xE8")]
	private ModeBehaviour modeBehaviour;

	[Token(Token = "0x17001BAD")]
	protected override int outGameBgId
	{
		[Token(Token = "0x600B4DF")]
		[Address(RVA = "0x4BEC90", Offset = "0x4BDE90", VA = "0x1804BEC90", Slot = "20")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17001BAE")]
	protected override Type[] textIds
	{
		[Token(Token = "0x600B4E0")]
		[Address(RVA = "0x4BED70", Offset = "0x4BDF70", VA = "0x1804BED70", Slot = "21")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600B4E1")]
	[Address(RVA = "0x3E4080", Offset = "0x3E3280", VA = "0x1803E4080", Slot = "6")]
	public override void NotificationStackEntry()
	{
	}

	[Token(Token = "0x600B4E2")]
	[Address(RVA = "0x4BDC40", Offset = "0x4BCE40", VA = "0x1804BDC40", Slot = "23")]
	protected override void OnCreatedView()
	{
	}

	[Token(Token = "0x600B4E3")]
	[Address(RVA = "0x4BEC00", Offset = "0x4BDE00", VA = "0x1804BEC00")]
	public ColosseumHistoryViewController()
	{
	}
}
