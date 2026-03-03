using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using YgomGame.Menu;
using YgomSystem.UI;
using YgomSystem.UI.InfinityScroll;
using YgomSystem.YGomTMPro;

namespace YgomGame.WCS;

[Token(Token = "0x2000750")]
public class WCSTeamTableViewControllerBase : BaseMenuViewController
{
	[Token(Token = "0x2000751")]
	public class Player
	{
		[Token(Token = "0x40024BD")]
		[FieldOffset(Offset = "0x28")]
		private bool _update;

		[Token(Token = "0x40024BE")]
		[FieldOffset(Offset = "0x30")]
		public ExtendedTextMeshProUGUI uiPlayerName;

		[Token(Token = "0x40024BF")]
		[FieldOffset(Offset = "0x38")]
		public GameObject uiPlayerIcon;

		[Token(Token = "0x40024C0")]
		[FieldOffset(Offset = "0x40")]
		public ExtendedTextMeshProUGUI uiResultText;

		[Token(Token = "0x170005F0")]
		public Result result
		{
			[Token(Token = "0x6003006")]
			[Address(RVA = "0x3C7100", Offset = "0x3C6300", VA = "0x1803C7100")]
			[CompilerGenerated]
			get
			{
				return default(Result);
			}
			[Token(Token = "0x6003005")]
			[Address(RVA = "0x5F4710", Offset = "0x5F3910", VA = "0x1805F4710")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x170005F1")]
		public string name
		{
			[Token(Token = "0x6003008")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6003007")]
			[Address(RVA = "0x417C80", Offset = "0x416E80", VA = "0x180417C80")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x170005F2")]
		public (int, int) iconIDs
		{
			[Token(Token = "0x600300A")]
			[Address(RVA = "0x3D8370", Offset = "0x3D7570", VA = "0x1803D8370")]
			[CompilerGenerated]
			get
			{
				return default((int, int));
			}
			[Token(Token = "0x6003009")]
			[Address(RVA = "0x7320F0", Offset = "0x7312F0", VA = "0x1807320F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x600300B")]
		[Address(RVA = "0x731EC0", Offset = "0x7310C0", VA = "0x180731EC0")]
		public void UpdateUI()
		{
		}

		[Token(Token = "0x600300C")]
		[Address(RVA = "0x731E20", Offset = "0x731020", VA = "0x180731E20")]
		public void SetPlayerInfo(string name, (int, int)? profileIconIDs)
		{
		}

		[Token(Token = "0x600300D")]
		[Address(RVA = "0x731EB0", Offset = "0x7310B0", VA = "0x180731EB0")]
		public void SetResult(Result result)
		{
		}

		[Token(Token = "0x600300E")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public Player()
		{
		}
	}

	[Token(Token = "0x2000752")]
	public class Table
	{
		[Token(Token = "0x40024C2")]
		[FieldOffset(Offset = "0x18")]
		public Player[] players;

		[Token(Token = "0x40024C3")]
		[FieldOffset(Offset = "0x20")]
		private bool _update;

		[Token(Token = "0x40024C4")]
		[FieldOffset(Offset = "0x28")]
		public SelectionButton uiStatusButton;

		[Token(Token = "0x40024C5")]
		[FieldOffset(Offset = "0x30")]
		public ExtendedTextMeshProUGUI uiStatusButtonText;

		[Token(Token = "0x170005F3")]
		public string statusText
		{
			[Token(Token = "0x6003010")]
			[Address(RVA = "0x40C440", Offset = "0x40B640", VA = "0x18040C440")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600300F")]
			[Address(RVA = "0x439010", Offset = "0x438210", VA = "0x180439010")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x6003011")]
		[Address(RVA = "0x7328A0", Offset = "0x731AA0", VA = "0x1807328A0")]
		private Table()
		{
		}

		[Token(Token = "0x6003012")]
		[Address(RVA = "0x7324D0", Offset = "0x7316D0", VA = "0x1807324D0")]
		public static Table[,] CreateTables(uint sectionNum, uint memberMax)
		{
			return null;
		}

		[Token(Token = "0x6003013")]
		[Address(RVA = "0x732830", Offset = "0x731A30", VA = "0x180732830")]
		public void Terminate()
		{
		}

		[Token(Token = "0x6003014")]
		[Address(RVA = "0x732860", Offset = "0x731A60", VA = "0x180732860")]
		public void UpdateUI()
		{
		}

		[Token(Token = "0x6003015")]
		[Address(RVA = "0x732730", Offset = "0x731930", VA = "0x180732730")]
		public void SetStatusButton(bool pushable)
		{
		}

		[Token(Token = "0x6003016")]
		[Address(RVA = "0x732700", Offset = "0x731900", VA = "0x180732700")]
		public void SetStatusButtonText(string labelText)
		{
		}

		[Token(Token = "0x6003017")]
		[Address(RVA = "0x732690", Offset = "0x731890", VA = "0x180732690")]
		public void SetStatusButtonListener(UnityAction callback)
		{
		}

		[Token(Token = "0x6003018")]
		[Address(RVA = "0x732770", Offset = "0x731970", VA = "0x180732770")]
		public void SetWin(Side which)
		{
		}

		[Token(Token = "0x6003019")]
		[Address(RVA = "0x732630", Offset = "0x731830", VA = "0x180732630")]
		public void SetDraw()
		{
		}

		[Token(Token = "0x600301A")]
		[Address(RVA = "0x7325D0", Offset = "0x7317D0", VA = "0x1807325D0")]
		public void ResetBothResult()
		{
		}
	}

	[Token(Token = "0x2000753")]
	private class TeamInfo
	{
		[Token(Token = "0x40024CB")]
		[FieldOffset(Offset = "0x38")]
		private bool _update;

		[Token(Token = "0x40024CC")]
		[FieldOffset(Offset = "0x40")]
		internal ExtendedTextMeshProUGUI uiGroupText;

		[Token(Token = "0x40024CD")]
		[FieldOffset(Offset = "0x48")]
		internal ExtendedTextMeshProUGUI uiNameText;

		[Token(Token = "0x40024CE")]
		[FieldOffset(Offset = "0x50")]
		internal ExtendedTextMeshProUGUI uiScoreText;

		[Token(Token = "0x40024CF")]
		[FieldOffset(Offset = "0x58")]
		internal GameObject uiWinnerIcon;

		[Token(Token = "0x40024D0")]
		[FieldOffset(Offset = "0x60")]
		internal SelectionButton uiInfoBtn;

		[Token(Token = "0x40024D1")]
		[FieldOffset(Offset = "0x68")]
		internal Image uiTeamIcon;

		[Token(Token = "0x170005F4")]
		internal bool win
		{
			[Token(Token = "0x600301C")]
			[Address(RVA = "0x465880", Offset = "0x464A80", VA = "0x180465880")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600301B")]
			[Address(RVA = "0x71FA70", Offset = "0x71EC70", VA = "0x18071FA70")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x170005F5")]
		internal string areaName
		{
			[Token(Token = "0x600301E")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600301D")]
			[Address(RVA = "0x417C80", Offset = "0x416E80", VA = "0x180417C80")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x170005F6")]
		internal string name
		{
			[Token(Token = "0x6003020")]
			[Address(RVA = "0x3D8370", Offset = "0x3D7570", VA = "0x1803D8370")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600301F")]
			[Address(RVA = "0x3D8380", Offset = "0x3D7580", VA = "0x1803D8380")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x170005F7")]
		internal int score
		{
			[Token(Token = "0x6003022")]
			[Address(RVA = "0x62E210", Offset = "0x62D410", VA = "0x18062E210")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6003021")]
			[Address(RVA = "0x62E240", Offset = "0x62D440", VA = "0x18062E240")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x170005F8")]
		internal string teamIconPath
		{
			[Token(Token = "0x6003024")]
			[Address(RVA = "0x402CE0", Offset = "0x401EE0", VA = "0x180402CE0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6003023")]
			[Address(RVA = "0x4130D0", Offset = "0x4122D0", VA = "0x1804130D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x6003025")]
		[Address(RVA = "0x732BA0", Offset = "0x731DA0", VA = "0x180732BA0")]
		internal void Terminate()
		{
		}

		[Token(Token = "0x6003026")]
		[Address(RVA = "0x732BD0", Offset = "0x731DD0", VA = "0x180732BD0")]
		internal void UpdateUI()
		{
		}

		[Token(Token = "0x6003027")]
		[Address(RVA = "0x7329D0", Offset = "0x731BD0", VA = "0x1807329D0")]
		internal void EnableInfoButton(bool on)
		{
		}

		[Token(Token = "0x6003028")]
		[Address(RVA = "0x732A50", Offset = "0x731C50", VA = "0x180732A50")]
		internal void SetInfoButtonListener(UnityAction callback)
		{
		}

		[Token(Token = "0x6003029")]
		[Address(RVA = "0x732AD0", Offset = "0x731CD0", VA = "0x180732AD0")]
		internal void SetTeamInfo(string areaName, string name, int? score, string iconPath)
		{
		}

		[Token(Token = "0x600302A")]
		[Address(RVA = "0x732AC0", Offset = "0x731CC0", VA = "0x180732AC0")]
		internal void SetResult(bool win)
		{
		}

		[Token(Token = "0x600302B")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public TeamInfo()
		{
		}
	}

	[Token(Token = "0x2000754")]
	public enum Side
	{
		[Token(Token = "0x40024D3")]
		LEFT,
		[Token(Token = "0x40024D4")]
		RIGHT
	}

	[Token(Token = "0x2000755")]
	public enum Result
	{
		[Token(Token = "0x40024D6")]
		NONE,
		[Token(Token = "0x40024D7")]
		WIN,
		[Token(Token = "0x40024D8")]
		LOSE,
		[Token(Token = "0x40024D9")]
		DRAW
	}

	[Token(Token = "0x40024B0")]
	private const int DEFAULT_SECTION_NUM = 1;

	[Token(Token = "0x40024B1")]
	private const int DEFAULT_TABLE_NUM = 3;

	[Token(Token = "0x40024B2")]
	internal const string ARG_KEY_SECTION_NUM = "section_num";

	[Token(Token = "0x40024B3")]
	internal const string ARG_KEY_TABLE_NUM = "table_num";

	[Token(Token = "0x40024B4")]
	internal const string ARG_KEY_DRYRUN = "dryrun";

	[Token(Token = "0x40024B5")]
	[FieldOffset(Offset = "0xD0")]
	private TeamInfo[] _teamList;

	[Token(Token = "0x40024B6")]
	[FieldOffset(Offset = "0xD8")]
	private Table[,] _tableDataLists;

	[Token(Token = "0x40024B7")]
	[FieldOffset(Offset = "0xE0")]
	protected InfinityScrollView _scrollView;

	[Token(Token = "0x170005EA")]
	protected override Type[] textIds
	{
		[Token(Token = "0x6002FDE")]
		[Address(RVA = "0x743A40", Offset = "0x742C40", VA = "0x180743A40", Slot = "21")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170005EB")]
	protected bool dryrun
	{
		[Token(Token = "0x6002FDF")]
		[Address(RVA = "0x7439C0", Offset = "0x742BC0", VA = "0x1807439C0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6002FE0")]
		[Address(RVA = "0x743B80", Offset = "0x742D80", VA = "0x180743B80")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x170005EC")]
	protected bool initialized
	{
		[Token(Token = "0x6002FE2")]
		[Address(RVA = "0x7439D0", Offset = "0x742BD0", VA = "0x1807439D0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6002FE1")]
		[Address(RVA = "0x743B90", Offset = "0x742D90", VA = "0x180743B90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x170005ED")]
	protected int teamCount
	{
		[Token(Token = "0x6002FE3")]
		[Address(RVA = "0x743A20", Offset = "0x742C20", VA = "0x180743A20")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x170005EE")]
	public int sectionCount
	{
		[Token(Token = "0x6002FE4")]
		[Address(RVA = "0x7439E0", Offset = "0x742BE0", VA = "0x1807439E0")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x170005EF")]
	public int tableCount
	{
		[Token(Token = "0x6002FE5")]
		[Address(RVA = "0x743A00", Offset = "0x742C00", VA = "0x180743A00")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x6002FE6")]
	[Address(RVA = "0x743880", Offset = "0x742A80", VA = "0x180743880")]
	public WCSTeamTableViewControllerBase()
	{
	}

	[Token(Token = "0x6002FE7")]
	[Address(RVA = "0x7420E0", Offset = "0x7412E0", VA = "0x1807420E0", Slot = "28")]
	protected virtual void OnDestroy()
	{
	}

	[Token(Token = "0x6002FE8")]
	[Address(RVA = "0x742C30", Offset = "0x741E30", VA = "0x180742C30")]
	private void Terminate()
	{
	}

	[Token(Token = "0x6002FE9")]
	[Address(RVA = "0x7419F0", Offset = "0x740BF0", VA = "0x1807419F0", Slot = "6")]
	public override void NotificationStackEntry()
	{
	}

	[Token(Token = "0x6002FEA")]
	[Address(RVA = "0x741BC0", Offset = "0x740DC0", VA = "0x180741BC0", Slot = "7")]
	public override void NotificationStackRemove()
	{
	}

	[Token(Token = "0x6002FEB")]
	[Address(RVA = "0x741BE0", Offset = "0x740DE0", VA = "0x180741BE0", Slot = "23")]
	protected sealed override void OnCreatedView()
	{
	}

	[Token(Token = "0x6002FEC")]
	[Address(RVA = "0x740F50", Offset = "0x740150", VA = "0x180740F50", Slot = "29")]
	protected virtual void InitializeView()
	{
	}

	[Token(Token = "0x6002FED")]
	[Address(RVA = "0x743860", Offset = "0x742A60", VA = "0x180743860")]
	private void Update()
	{
	}

	[Token(Token = "0x6002FEE")]
	[Address(RVA = "0x743590", Offset = "0x742790", VA = "0x180743590")]
	private void UpdateTeamInfo()
	{
	}

	[Token(Token = "0x6002FEF")]
	[Address(RVA = "0x743000", Offset = "0x742200", VA = "0x180743000")]
	private void UpdateTableData(GameObject gob, int index)
	{
	}

	[Token(Token = "0x6002FF0")]
	[Address(RVA = "0x742B70", Offset = "0x741D70", VA = "0x180742B70")]
	protected void SetTitle(string title)
	{
	}

	[Token(Token = "0x6002FF1")]
	[Address(RVA = "0x742380", Offset = "0x741580", VA = "0x180742380")]
	protected void SetLeftTeamInfo(string areaName, string name, int? score, string iconPath)
	{
	}

	[Token(Token = "0x6002FF2")]
	[Address(RVA = "0x742700", Offset = "0x741900", VA = "0x180742700")]
	protected void SetRightTeamInfo(string areaName, string name, int? score, string iconPath)
	{
	}

	[Token(Token = "0x6002FF3")]
	[Address(RVA = "0x740ED0", Offset = "0x7400D0", VA = "0x180740ED0")]
	protected void EnableLeftTeamInfoBtn(bool on)
	{
	}

	[Token(Token = "0x6002FF4")]
	[Address(RVA = "0x740F10", Offset = "0x740110", VA = "0x180740F10")]
	protected void EnableRightTeamInfoBtn(bool on)
	{
	}

	[Token(Token = "0x6002FF5")]
	[Address(RVA = "0x742AF0", Offset = "0x741CF0", VA = "0x180742AF0")]
	protected void SetTeamWin(Side which)
	{
	}

	[Token(Token = "0x6002FF6")]
	[Address(RVA = "0x742180", Offset = "0x741380", VA = "0x180742180")]
	protected void ResetTeamResult()
	{
	}

	[Token(Token = "0x6002FF7")]
	[Address(RVA = "0x742A80", Offset = "0x741C80", VA = "0x180742A80")]
	protected void SetTableStatusText(int section, int index, string text)
	{
	}

	[Token(Token = "0x6002FF8")]
	[Address(RVA = "0x7421F0", Offset = "0x7413F0", VA = "0x1807421F0")]
	protected void SetLeftPlayerInfo(int section, int index, string name, (int, int)? profileIconIDs)
	{
	}

	[Token(Token = "0x6002FF9")]
	[Address(RVA = "0x742570", Offset = "0x741770", VA = "0x180742570")]
	protected void SetRightPlayerInfo(int section, int index, string name, (int, int)? profileIconIDs)
	{
	}

	[Token(Token = "0x6002FFA")]
	[Address(RVA = "0x742480", Offset = "0x741680", VA = "0x180742480")]
	protected void SetPlayerWin(int section, int tableIndex, Side which)
	{
	}

	[Token(Token = "0x6002FFB")]
	[Address(RVA = "0x7424E0", Offset = "0x7416E0", VA = "0x1807424E0")]
	protected void SetResultDraw(int section, int tableIndex)
	{
	}

	[Token(Token = "0x6002FFC")]
	[Address(RVA = "0x7420F0", Offset = "0x7412F0", VA = "0x1807420F0")]
	protected void ResetBothPlayerResult(int section, int tableIndex)
	{
	}

	[Token(Token = "0x6002FFD")]
	[Address(RVA = "0x742300", Offset = "0x741500", VA = "0x180742300")]
	protected void SetLeftTeamInfoButtonListener(UnityAction callback)
	{
	}

	[Token(Token = "0x6002FFE")]
	[Address(RVA = "0x742680", Offset = "0x741880", VA = "0x180742680")]
	protected void SetRightTeamInfoButtonListener(UnityAction callback)
	{
	}

	[Token(Token = "0x6002FFF")]
	[Address(RVA = "0x7429E0", Offset = "0x741BE0", VA = "0x1807429E0")]
	protected void SetTableStatusButton(int section, int index, bool pushable)
	{
	}

	[Token(Token = "0x6003000")]
	[Address(RVA = "0x742940", Offset = "0x741B40", VA = "0x180742940")]
	protected void SetTableStatusButtonListener(int section, int index, UnityAction callback)
	{
	}

	[Token(Token = "0x6003001")]
	[Address(RVA = "0x742800", Offset = "0x741A00", VA = "0x180742800")]
	protected void SetTableStatusButtonAll(bool pushable)
	{
	}
}
