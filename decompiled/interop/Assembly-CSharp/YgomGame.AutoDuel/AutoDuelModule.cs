using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using YgomSystem.Network;

namespace YgomGame.AutoDuel;

[Token(Token = "0x2001DA2")]
public class AutoDuelModule
{
	[Token(Token = "0x2001DA3")]
	public class RoomInfo
	{
		[Token(Token = "0x401047F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		internal int roomID;

		[Token(Token = "0x4010480")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		internal string roomName;

		[Token(Token = "0x4010481")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		internal long roomMasterID;

		[Token(Token = "0x4010482")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		internal int memberNum;

		[Token(Token = "0x4010483")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		internal int roomSpecterID;

		[Token(Token = "0x4010484")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		internal int specterNum;

		[Token(Token = "0x4010485")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		internal int memberMax;

		[Token(Token = "0x4010486")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		internal int regID;

		[Token(Token = "0x4010487")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		internal string regulation;

		[Token(Token = "0x4010488")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		internal int roomComment;

		[Token(Token = "0x4010489")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		internal bool canEnterFree;

		[Token(Token = "0x401048A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4D")]
		internal bool canWatchRoom;

		[Token(Token = "0x401048B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4E")]
		internal bool canWatchEnterFree;

		[Token(Token = "0x401048C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		internal int havePlayTime;

		[Token(Token = "0x401048D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		internal int LP;

		[Token(Token = "0x401048E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		internal bool canWatchReplay;

		[Token(Token = "0x401048F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		internal int deckID;

		[Token(Token = "0x4010490")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		internal List<TableInfo> tableInfo;

		[Token(Token = "0x17001C2C")]
		internal int regID_in_client
		{
			[Token(Token = "0x600BDD2")]
			[Address(RVA = "0x58E160", Offset = "0x58D360", VA = "0x18058E160")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x600BDD3")]
		[Address(RVA = "0x58E080", Offset = "0x58D280", VA = "0x18058E080")]
		public RoomInfo()
		{
		}
	}

	[Token(Token = "0x2001DA4")]
	public class TableInfo
	{
		[Token(Token = "0x4010491")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		internal TableStatus stats;

		[Token(Token = "0x4010492")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		internal long pcode1;

		[Token(Token = "0x4010493")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		internal long pcode2;

		[Token(Token = "0x600BDD4")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public TableInfo()
		{
		}
	}

	[Token(Token = "0x2001DA5")]
	public enum TableStatus
	{
		[Token(Token = "0x4010495")]
		WAIT = 1,
		[Token(Token = "0x4010496")]
		READY_LEFT,
		[Token(Token = "0x4010497")]
		READY_RIGHT,
		[Token(Token = "0x4010498")]
		DUEL,
		[Token(Token = "0x4010499")]
		SPECTATE
	}

	[Token(Token = "0x2001DA6")]
	public enum Mode
	{
		[Token(Token = "0x401049B")]
		RoomOwner,
		[Token(Token = "0x401049C")]
		RoomMember,
		[Token(Token = "0x401049D")]
		Spectator
	}

	[Token(Token = "0x2001DA7")]
	public enum Step
	{
		[Token(Token = "0x401049F")]
		Initializing,
		[Token(Token = "0x40104A0")]
		CreateRoom,
		[Token(Token = "0x40104A1")]
		EnterRoom,
		[Token(Token = "0x40104A2")]
		TableArrive,
		[Token(Token = "0x40104A3")]
		WaitMatching,
		[Token(Token = "0x40104A4")]
		WaitNoMatching,
		[Token(Token = "0x40104A5")]
		CancelMatching,
		[Token(Token = "0x40104A6")]
		Duel,
		[Token(Token = "0x40104A7")]
		Spectator,
		[Token(Token = "0x40104A8")]
		Error
	}

	[Token(Token = "0x2001DA8")]
	public enum PlayerStatus
	{
		[Token(Token = "0x40104AA")]
		OutOfRoom,
		[Token(Token = "0x40104AB")]
		InRoom,
		[Token(Token = "0x40104AC")]
		TableArriving,
		[Token(Token = "0x40104AD")]
		BattleReady,
		[Token(Token = "0x40104AE")]
		Duel
	}

	[Token(Token = "0x4010472")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private bool apiCalling;

	[Token(Token = "0x4010473")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	private float pollingTimer;

	[Token(Token = "0x4010474")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private long rivalPcode;

	[Token(Token = "0x4010476")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Action<RoomInfo> onUpdateRoomInfo;

	[Token(Token = "0x4010477")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Action<Handle> onApiResponced;

	[Token(Token = "0x4010478")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public Action<Step, Step> onStepChanged;

	[Token(Token = "0x4010479")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public Action<PlayerStatus, PlayerStatus> onPlayerStatusChanged;

	[Token(Token = "0x401047A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public Action<Dictionary<string, object>> onDuelStart;

	[Token(Token = "0x401047C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private Mode mode;

	[Token(Token = "0x401047D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	private Step _step;

	[Token(Token = "0x401047E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private PlayerStatus _playerStatus;

	[Token(Token = "0x17001C28")]
	public bool autoMatching
	{
		[Token(Token = "0x600BD9D")]
		[Address(RVA = "0x416680", Offset = "0x415880", VA = "0x180416680")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600BD9E")]
		[Address(RVA = "0x4166E0", Offset = "0x4158E0", VA = "0x1804166E0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x17001C29")]
	public RoomInfo roomInfo
	{
		[Token(Token = "0x600BD9F")]
		[Address(RVA = "0x580700", Offset = "0x57F900", VA = "0x180580700")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x600BDA0")]
		[Address(RVA = "0x580760", Offset = "0x57F960", VA = "0x180580760")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17001C2A")]
	public Step step
	{
		[Token(Token = "0x600BDA1")]
		[Address(RVA = "0x404870", Offset = "0x403A70", VA = "0x180404870")]
		get
		{
			return default(Step);
		}
		[Token(Token = "0x600BDA2")]
		[Address(RVA = "0x580770", Offset = "0x57F970", VA = "0x180580770")]
		set
		{
		}
	}

	[Token(Token = "0x17001C2B")]
	private PlayerStatus playerStatus
	{
		[Token(Token = "0x600BDA3")]
		[Address(RVA = "0x404880", Offset = "0x403A80", VA = "0x180404880")]
		get
		{
			return default(PlayerStatus);
		}
		[Token(Token = "0x600BDA4")]
		[Address(RVA = "0x580710", Offset = "0x57F910", VA = "0x180580710")]
		set
		{
		}
	}

	[Token(Token = "0x600BDA5")]
	[Address(RVA = "0x57E750", Offset = "0x57D950", VA = "0x18057E750")]
	public void SetCallback(Action<RoomInfo> onUpdateRoomInfo, Action<Handle> onApiResponced, Action<Step, Step> onStepChanged, Action<PlayerStatus, PlayerStatus> onPlayerStatusChanged, Action<Dictionary<string, object>> onDuelStart)
	{
	}

	[Token(Token = "0x600BDA6")]
	[Address(RVA = "0x57D4D0", Offset = "0x57C6D0", VA = "0x18057D4D0")]
	public void BeginRoomOwner()
	{
	}

	[Token(Token = "0x600BDA7")]
	[Address(RVA = "0x57D4C0", Offset = "0x57C6C0", VA = "0x18057D4C0")]
	public void BeginRoomMember(int roomID)
	{
	}

	[Token(Token = "0x600BDA8")]
	[Address(RVA = "0x57D4E0", Offset = "0x57C6E0", VA = "0x18057D4E0")]
	public void BeginSpectator(int roomID)
	{
	}

	[Token(Token = "0x600BDA9")]
	[Address(RVA = "0x57D4F0", Offset = "0x57C6F0", VA = "0x18057D4F0")]
	private void Begin(Mode mode, int roomID = 0)
	{
	}

	[Token(Token = "0x600BDAA")]
	[Address(RVA = "0x580580", Offset = "0x57F780", VA = "0x180580580")]
	public void Update()
	{
	}

	[Token(Token = "0x600BDAB")]
	[Address(RVA = "0x57F5D0", Offset = "0x57E7D0", VA = "0x18057F5D0")]
	public void Terminate(Action onCompleted)
	{
	}

	[Token(Token = "0x600BDAC")]
	[Address(RVA = "0x57DCE0", Offset = "0x57CEE0", VA = "0x18057DCE0")]
	private void GoToCreateRoom()
	{
	}

	[Token(Token = "0x600BDAD")]
	[Address(RVA = "0x57D5E0", Offset = "0x57C7E0", VA = "0x18057D5E0")]
	private void CreateRoom(Action<bool> callback)
	{
	}

	[Token(Token = "0x600BDAE")]
	[Address(RVA = "0x57DF60", Offset = "0x57D160", VA = "0x18057DF60")]
	private void GoToEnterRoom(int roomID, bool spectator)
	{
	}

	[Token(Token = "0x600BDAF")]
	[Address(RVA = "0x57E630", Offset = "0x57D830", VA = "0x18057E630")]
	private void RoomExit(Action onCompleted)
	{
	}

	[Token(Token = "0x600BDB0")]
	[Address(RVA = "0x57E450", Offset = "0x57D650", VA = "0x18057E450")]
	private void RoomEntry(int roomID, bool spectator)
	{
	}

	[Token(Token = "0x600BDB1")]
	[Address(RVA = "0x57E010", Offset = "0x57D210", VA = "0x18057E010")]
	public void GoToTableArrive(bool tableArrive)
	{
	}

	[Token(Token = "0x600BDB2")]
	[Address(RVA = "0x57F360", Offset = "0x57E560", VA = "0x18057F360")]
	private void StepTableArrive()
	{
	}

	[Token(Token = "0x600BDB3")]
	[Address(RVA = "0x57E180", Offset = "0x57D380", VA = "0x18057E180")]
	private void GoToWaitMatching(bool ready, long rivalPcode, Action onFinished)
	{
	}

	[Token(Token = "0x600BDB4")]
	[Address(RVA = "0x580670", Offset = "0x57F870", VA = "0x180580670")]
	private void WaitMatchingStep()
	{
	}

	[Token(Token = "0x600BDB5")]
	[Address(RVA = "0x57DBC0", Offset = "0x57CDC0", VA = "0x18057DBC0")]
	private void GoToCancelMatching(Action onCompleted)
	{
	}

	[Token(Token = "0x600BDB6")]
	[Address(RVA = "0x57DE10", Offset = "0x57D010", VA = "0x18057DE10")]
	private void GoToDuel()
	{
	}

	[Token(Token = "0x600BDB7")]
	[Address(RVA = "0x57DFC0", Offset = "0x57D1C0", VA = "0x18057DFC0")]
	private void GoToSpectator()
	{
	}

	[Token(Token = "0x600BDB8")]
	[Address(RVA = "0x57DF70", Offset = "0x57D170", VA = "0x18057DF70")]
	private void GoToErrorStep()
	{
	}

	[Token(Token = "0x600BDB9")]
	[Address(RVA = "0x57E300", Offset = "0x57D500", VA = "0x18057E300")]
	public bool Polling(Action onCompleted, bool force = false)
	{
		return default(bool);
	}

	[Token(Token = "0x600BDBA")]
	[Address(RVA = "0x57E7D0", Offset = "0x57D9D0", VA = "0x18057E7D0")]
	private void SetRoomInfo()
	{
	}

	[Token(Token = "0x600BDBB")]
	[Address(RVA = "0x57D410", Offset = "0x57C610", VA = "0x18057D410")]
	private void APIResponce(Handle handle)
	{
	}

	[Token(Token = "0x600BDBC")]
	[Address(RVA = "0x580380", Offset = "0x57F580", VA = "0x180580380")]
	private void UpdateStatus()
	{
	}

	[Token(Token = "0x600BDBD")]
	[Address(RVA = "0x57DAD0", Offset = "0x57CCD0", VA = "0x18057DAD0")]
	public void DeckCheck([Optional] Action onCompleted)
	{
	}

	[Token(Token = "0x600BDBE")]
	[Address(RVA = "0x5806F0", Offset = "0x57F8F0", VA = "0x1805806F0")]
	public AutoDuelModule()
	{
	}
}
