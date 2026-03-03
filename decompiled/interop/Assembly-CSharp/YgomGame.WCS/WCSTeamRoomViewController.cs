using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;
using Il2CppDummyDll;
using YgomGame.Menu.Common;
using YgomGame.WCS.Portal;
using YgomSystem.ElementSystem;
using YgomSystem.Network;
using YgomSystem.UI;
using YgomSystem.YGomTMPro;

namespace YgomGame.WCS;

[Token(Token = "0x200074A")]
public class WCSTeamRoomViewController : WCSTeamTableViewController
{
	[Token(Token = "0x4002494")]
	private const string CW_ROOM_INFO_PATH = "$.DuelMenu.WcsFinal.room_info";

	[Token(Token = "0x4002495")]
	private const string VC_PREFAB_PATH = "WCS/WCSTeamRoom";

	[Token(Token = "0x4002496")]
	internal const string ARG_KEY_ADMINISTRATOR = "administrator";

	[Token(Token = "0x4002497")]
	internal const string ARG_KEY_PARAM = "param";

	[Token(Token = "0x4002498")]
	private const string LABEL_REMAINEDTIME_TEXT = "RemainedTimeText";

	[Token(Token = "0x4002499")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
	private bool _isAdministrator;

	[Token(Token = "0x400249A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x109")]
	private bool _deckRegulationOK;

	[Token(Token = "0x400249B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
	private long _rivalPcode;

	[Token(Token = "0x400249C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
	private long _duelStartTime;

	[Token(Token = "0x400249D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
	private long _nextSetStartTime;

	[Token(Token = "0x400249E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
	private long _remainedByDuelStartTmp;

	[Token(Token = "0x400249F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
	private long _remainedByNextSetStartTmp;

	[Token(Token = "0x40024A0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
	private ElementObjectManager _rightMenuEom;

	[Token(Token = "0x40024A1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
	private DeckCaseWidget _deckCase;

	[Token(Token = "0x40024A2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
	private ExtendedTextMeshProUGUI _remainedTimeText;

	[Token(Token = "0x40024A3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
	private StringBuilder _titleTextTmp;

	[Token(Token = "0x170005E8")]
	protected override Type[] textIds
	{
		[Token(Token = "0x6002FBA")]
		[Address(RVA = "0x740CD0", Offset = "0x73FED0", VA = "0x180740CD0", Slot = "21")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170005E9")]
	protected override object roomInfo
	{
		[Token(Token = "0x6002FBB")]
		[Address(RVA = "0x740C70", Offset = "0x73FE70", VA = "0x180740C70", Slot = "31")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6002FBC")]
	[Address(RVA = "0x73FAD0", Offset = "0x73ECD0", VA = "0x18073FAD0")]
	public static void Open(ViewControllerManager manager, [Optional] Dictionary<string, object> args)
	{
	}

	[Token(Token = "0x6002FBD")]
	[Address(RVA = "0x73F960", Offset = "0x73EB60", VA = "0x18073F960", Slot = "6")]
	public override void NotificationStackEntry()
	{
	}

	[Token(Token = "0x6002FBE")]
	[Address(RVA = "0x740630", Offset = "0x73F830", VA = "0x180740630", Slot = "11")]
	public override void TransitionStart(TransitionType type)
	{
	}

	[Token(Token = "0x6002FBF")]
	[Address(RVA = "0x73F2C0", Offset = "0x73E4C0", VA = "0x18073F2C0", Slot = "29")]
	protected override void InitializeView()
	{
	}

	[Token(Token = "0x6002FC0")]
	[Address(RVA = "0x73FD20", Offset = "0x73EF20", VA = "0x18073FD20")]
	private void SetDeck(object deckInfo)
	{
	}

	[Token(Token = "0x6002FC1")]
	[Address(RVA = "0x73EF80", Offset = "0x73E180", VA = "0x18073EF80")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x6002FC2")]
	[Address(RVA = "0x73DC90", Offset = "0x73CE90", VA = "0x18073DC90", Slot = "32")]
	protected override void ApplyData(object roomInfo)
	{
	}

	[Token(Token = "0x6002FC3")]
	[Address(RVA = "0x73EDD0", Offset = "0x73DFD0", VA = "0x18073EDD0")]
	private bool CheckExtraDuelNow(List<object> tableList)
	{
		return default(bool);
	}

	[Token(Token = "0x6002FC4")]
	[Address(RVA = "0x73EB10", Offset = "0x73DD10", VA = "0x18073EB10", Slot = "34")]
	protected override Handle CallPollingAPI()
	{
		return null;
	}

	[Token(Token = "0x6002FC5")]
	[Address(RVA = "0x73D7C0", Offset = "0x73C9C0", VA = "0x18073D7C0")]
	private void AdjustTableButtonStatus(int tableIndex, int serverTableIndex, int status, long myTeamMatePcode, int myTeamId, long did, bool joining)
	{
	}

	[Token(Token = "0x6002FC6")]
	[Address(RVA = "0x73EA40", Offset = "0x73DC40", VA = "0x18073EA40")]
	private void CallAPI_CheckDeck(Action<int> onEnd)
	{
	}

	[Token(Token = "0x6002FC7")]
	[Address(RVA = "0x73F9F0", Offset = "0x73EBF0", VA = "0x18073F9F0")]
	private void OpenDeckSelect()
	{
	}

	[Token(Token = "0x6002FC8")]
	[Address(RVA = "0x740590", Offset = "0x73F790", VA = "0x180740590")]
	private void StartDuel(long oppPcode, int tableIndex)
	{
	}

	[Token(Token = "0x6002FC9")]
	[Address(RVA = "0x73EB20", Offset = "0x73DD20", VA = "0x18073EB20", Slot = "33")]
	protected override void CallWatchDuelAPI(long pcode)
	{
	}

	[Token(Token = "0x6002FCA")]
	[Address(RVA = "0x73FB30", Offset = "0x73ED30", VA = "0x18073FB30")]
	private void ReplayDuel(long pcode, long did)
	{
	}

	[Token(Token = "0x6002FCB")]
	[Address(RVA = "0x73FC50", Offset = "0x73EE50", VA = "0x18073FC50")]
	private void RoomNoExistError(string message)
	{
	}

	[Token(Token = "0x6002FCC")]
	[Address(RVA = "0x740BF0", Offset = "0x73FDF0", VA = "0x180740BF0")]
	public WCSTeamRoomViewController()
	{
	}
}
