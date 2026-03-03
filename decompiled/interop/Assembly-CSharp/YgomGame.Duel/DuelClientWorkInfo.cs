using System.Collections.Generic;
using Il2CppDummyDll;

namespace YgomGame.Duel;

[Token(Token = "0x2001782")]
public class DuelClientWorkInfo
{
	[Token(Token = "0x2001783")]
	public class PlayerInfo
	{
		[Token(Token = "0x400DCD7")]
		[FieldOffset(Offset = "0x10")]
		public int playerID;

		[Token(Token = "0x400DCD8")]
		[FieldOffset(Offset = "0x18")]
		public string userName;

		[Token(Token = "0x400DCD9")]
		[FieldOffset(Offset = "0x20")]
		public long pcode;

		[Token(Token = "0x400DCDA")]
		[FieldOffset(Offset = "0x28")]
		public int iconID;

		[Token(Token = "0x400DCDB")]
		[FieldOffset(Offset = "0x2C")]
		public int frameID;

		[Token(Token = "0x400DCDC")]
		[FieldOffset(Offset = "0x30")]
		public int avatarID;

		[Token(Token = "0x400DCDD")]
		[FieldOffset(Offset = "0x34")]
		public int avatarBaseID;

		[Token(Token = "0x400DCDE")]
		[FieldOffset(Offset = "0x38")]
		public int duelObjID;

		[Token(Token = "0x400DCDF")]
		[FieldOffset(Offset = "0x3C")]
		public int matID;

		[Token(Token = "0x400DCE0")]
		[FieldOffset(Offset = "0x40")]
		public int sleeveID;

		[Token(Token = "0x400DCE1")]
		[FieldOffset(Offset = "0x44")]
		public bool sameOS;

		[Token(Token = "0x400DCE2")]
		[FieldOffset(Offset = "0x48")]
		public string onlineID;

		[Token(Token = "0x400DCE3")]
		[FieldOffset(Offset = "0x50")]
		public int coin;

		[Token(Token = "0x400DCE4")]
		[FieldOffset(Offset = "0x54")]
		public int finalBlow;

		[Token(Token = "0x400DCE5")]
		[FieldOffset(Offset = "0x58")]
		public Dictionary<string, object> profileData;

		[Token(Token = "0x600940F")]
		[Address(RVA = "0xDEBF70", Offset = "0xDEB170", VA = "0x180DEBF70")]
		public PlayerInfo(int playerID, bool isOnlineMode, bool isReplayMode, bool isAudienceMode, int myid)
		{
		}

		[Token(Token = "0x6009410")]
		[Address(RVA = "0xDEBE10", Offset = "0xDEB010", VA = "0x180DEBE10")]
		public void Remake(bool myself)
		{
		}
	}

	[Token(Token = "0x400DCD1")]
	[FieldOffset(Offset = "0x10")]
	private int myid;

	[Token(Token = "0x400DCD2")]
	[FieldOffset(Offset = "0x18")]
	public List<PlayerInfo> players;

	[Token(Token = "0x400DCD3")]
	[FieldOffset(Offset = "0x20")]
	public bool isIncludeMyself;

	[Token(Token = "0x400DCD4")]
	[FieldOffset(Offset = "0x24")]
	public int isFollowing;

	[Token(Token = "0x400DCD5")]
	[FieldOffset(Offset = "0x28")]
	public bool isFollowMax;

	[Token(Token = "0x400DCD6")]
	[FieldOffset(Offset = "0x2C")]
	public Util.GameMode gameMode;

	[Token(Token = "0x1700169A")]
	public bool isAudience
	{
		[Token(Token = "0x60093F3")]
		[Address(RVA = "0xDDACE0", Offset = "0xDD9EE0", VA = "0x180DDACE0")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700169B")]
	public bool isReplay
	{
		[Token(Token = "0x60093F4")]
		[Address(RVA = "0xDDAD30", Offset = "0xDD9F30", VA = "0x180DDAD30")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700169C")]
	public bool isOnline
	{
		[Token(Token = "0x60093F5")]
		[Address(RVA = "0xDDACF0", Offset = "0xDD9EF0", VA = "0x180DDACF0")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700169D")]
	public static bool IsAudience
	{
		[Token(Token = "0x60093F6")]
		[Address(RVA = "0xDDAC60", Offset = "0xDD9E60", VA = "0x180DDAC60")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700169E")]
	public static bool IsReplay
	{
		[Token(Token = "0x60093F7")]
		[Address(RVA = "0xDDACC0", Offset = "0xDD9EC0", VA = "0x180DDACC0")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700169F")]
	public static bool IsOnline
	{
		[Token(Token = "0x60093F8")]
		[Address(RVA = "0xDDAC80", Offset = "0xDD9E80", VA = "0x180DDAC80")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x60093F9")]
	[Address(RVA = "0xDD8C50", Offset = "0xDD7E50", VA = "0x180DD8C50")]
	public static DuelClientWorkInfo Create()
	{
		return null;
	}

	[Token(Token = "0x60093FA")]
	[Address(RVA = "0xDDA640", Offset = "0xDD9840", VA = "0x180DDA640")]
	private void InitParams()
	{
	}

	[Token(Token = "0x60093FB")]
	[Address(RVA = "0xDDAB30", Offset = "0xDD9D30", VA = "0x180DDAB30")]
	public void Remake()
	{
	}

	[Token(Token = "0x60093FC")]
	[Address(RVA = "0xDDA330", Offset = "0xDD9530", VA = "0x180DDA330")]
	public static string GetUserName(int player)
	{
		return null;
	}

	[Token(Token = "0x60093FD")]
	[Address(RVA = "0xDD9800", Offset = "0xDD8A00", VA = "0x180DD9800")]
	public static long GetPcode(int player)
	{
		return default(long);
	}

	[Token(Token = "0x60093FE")]
	[Address(RVA = "0xDD9040", Offset = "0xDD8240", VA = "0x180DD9040")]
	public static int GetFaceIconId(int player)
	{
		return default(int);
	}

	[Token(Token = "0x60093FF")]
	[Address(RVA = "0xDD8F70", Offset = "0xDD8170", VA = "0x180DD8F70")]
	public static int GetFaceIconFrameId(int player)
	{
		return default(int);
	}

	[Token(Token = "0x6009400")]
	[Address(RVA = "0xDD8D00", Offset = "0xDD7F00", VA = "0x180DD8D00")]
	public static int GetAvatarIconId(int player)
	{
		return default(int);
	}

	[Token(Token = "0x6009401")]
	[Address(RVA = "0xDD8DD0", Offset = "0xDD7FD0", VA = "0x180DD8DD0")]
	public static int GetAvatarStandId(int player)
	{
		return default(int);
	}

	[Token(Token = "0x6009402")]
	[Address(RVA = "0xDD92F0", Offset = "0xDD84F0", VA = "0x180DD92F0")]
	public static int GetGraveId(int player)
	{
		return default(int);
	}

	[Token(Token = "0x6009403")]
	[Address(RVA = "0xDD95B0", Offset = "0xDD87B0", VA = "0x180DD95B0")]
	public static int GetMatId(int player)
	{
		return default(int);
	}

	[Token(Token = "0x6009404")]
	[Address(RVA = "0xDDA200", Offset = "0xDD9400", VA = "0x180DDA200")]
	public static int GetSleeveId(int player)
	{
		return default(int);
	}

	[Token(Token = "0x6009405")]
	[Address(RVA = "0xDDA480", Offset = "0xDD9680", VA = "0x180DDA480")]
	public static bool IncludeMySelf()
	{
		return default(bool);
	}

	[Token(Token = "0x6009406")]
	[Address(RVA = "0xDD91E0", Offset = "0xDD83E0", VA = "0x180DD91E0")]
	public static Util.GameMode GetGameMode()
	{
		return default(Util.GameMode);
	}

	[Token(Token = "0x6009407")]
	[Address(RVA = "0xDD94C0", Offset = "0xDD86C0", VA = "0x180DD94C0")]
	public static bool GetIsSameOS(int player, bool myself)
	{
		return default(bool);
	}

	[Token(Token = "0x6009408")]
	[Address(RVA = "0xDD9680", Offset = "0xDD8880", VA = "0x180DD9680")]
	public static string GetOnlineID(int player, bool isSameOS)
	{
		return null;
	}

	[Token(Token = "0x6009409")]
	[Address(RVA = "0xDD9420", Offset = "0xDD8620", VA = "0x180DD9420")]
	public static int GetIsFollowing()
	{
		return default(int);
	}

	[Token(Token = "0x600940A")]
	[Address(RVA = "0xDD93C0", Offset = "0xDD85C0", VA = "0x180DD93C0")]
	public static bool GetIsFollowMax()
	{
		return default(bool);
	}

	[Token(Token = "0x600940B")]
	[Address(RVA = "0xDD9110", Offset = "0xDD8310", VA = "0x180DD9110")]
	public static int GetFinalBlow(int player)
	{
		return default(int);
	}

	[Token(Token = "0x600940C")]
	[Address(RVA = "0xDD8EA0", Offset = "0xDD80A0", VA = "0x180DD8EA0")]
	public static int GetCoinID(int player)
	{
		return default(int);
	}

	[Token(Token = "0x600940D")]
	[Address(RVA = "0xDD98D0", Offset = "0xDD8AD0", VA = "0x180DD98D0")]
	public static Dictionary<string, object> GetPlayerProfile(int player, bool isMyself)
	{
		return null;
	}

	[Token(Token = "0x600940E")]
	[Address(RVA = "0xDDABE0", Offset = "0xDD9DE0", VA = "0x180DDABE0")]
	public DuelClientWorkInfo()
	{
	}
}
