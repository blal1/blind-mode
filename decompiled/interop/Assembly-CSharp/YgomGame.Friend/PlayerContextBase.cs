using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace YgomGame.Friend;

[Token(Token = "0x2000DC8")]
public abstract class PlayerContextBase : IPlayerContext, IComparable<IPlayerContext>
{
	[Token(Token = "0x400A06C")]
	[FieldOffset(Offset = "0x59")]
	private bool m_ExistsWatch;

	[Token(Token = "0x17000C19")]
	public long pcode
	{
		[Token(Token = "0x60052C5")]
		[Address(RVA = "0x40C440", Offset = "0x40B640", VA = "0x18040C440", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Token(Token = "0x60052C6")]
		[Address(RVA = "0x9941A0", Offset = "0x9933A0", VA = "0x1809941A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17000C1A")]
	public string playerName
	{
		[Token(Token = "0x60052C7")]
		[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x60052C8")]
		[Address(RVA = "0x417C80", Offset = "0x416E80", VA = "0x180417C80")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17000C1B")]
	public string platformPlayerName
	{
		[Token(Token = "0x60052C9")]
		[Address(RVA = "0x3D8370", Offset = "0x3D7570", VA = "0x1803D8370", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x60052CA")]
		[Address(RVA = "0x3D8380", Offset = "0x3D7580", VA = "0x1803D8380")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17000C1C")]
	public bool isRegistedPlatform
	{
		[Token(Token = "0x60052CB")]
		[Address(RVA = "0x588F60", Offset = "0x588160", VA = "0x180588F60", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60052CC")]
		[Address(RVA = "0x588F70", Offset = "0x588170", VA = "0x180588F70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17000C1D")]
	public bool isSamePlatform
	{
		[Token(Token = "0x60052CD")]
		[Address(RVA = "0x62E230", Offset = "0x62D430", VA = "0x18062E230", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60052CE")]
		[Address(RVA = "0x631700", Offset = "0x630900", VA = "0x180631700")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17000C1E")]
	public int iconId
	{
		[Token(Token = "0x60052CF")]
		[Address(RVA = "0x6333B0", Offset = "0x6325B0", VA = "0x1806333B0", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60052D0")]
		[Address(RVA = "0x7EB190", Offset = "0x7EA390", VA = "0x1807EB190")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17000C1F")]
	public int iconFrameId
	{
		[Token(Token = "0x60052D1")]
		[Address(RVA = "0x49B840", Offset = "0x49AA40", VA = "0x18049B840", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60052D2")]
		[Address(RVA = "0x49C0C0", Offset = "0x49B2C0", VA = "0x18049C0C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17000C20")]
	public int wallpaperId
	{
		[Token(Token = "0x60052D3")]
		[Address(RVA = "0x6333C0", Offset = "0x6325C0", VA = "0x1806333C0", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60052D4")]
		[Address(RVA = "0x9941B0", Offset = "0x9933B0", VA = "0x1809941B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17000C21")]
	public FollowState followState
	{
		[Token(Token = "0x60052D5")]
		[Address(RVA = "0x40C450", Offset = "0x40B650", VA = "0x18040C450", Slot = "12")]
		[CompilerGenerated]
		get
		{
			return default(FollowState);
		}
		[Token(Token = "0x60052D6")]
		[Address(RVA = "0x4A69B0", Offset = "0x4A5BB0", VA = "0x1804A69B0")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Token(Token = "0x17000C22")]
	public bool isPin
	{
		[Token(Token = "0x60052D7")]
		[Address(RVA = "0x994170", Offset = "0x993370", VA = "0x180994170", Slot = "13")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60052D8")]
		[Address(RVA = "0x994190", Offset = "0x993390", VA = "0x180994190")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Token(Token = "0x17000C23")]
	public long onlineTime
	{
		[Token(Token = "0x60052D9")]
		[Address(RVA = "0x404850", Offset = "0x403A50", VA = "0x180404850", Slot = "14")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Token(Token = "0x60052DA")]
		[Address(RVA = "0x980A70", Offset = "0x97FC70", VA = "0x180980A70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17000C24")]
	public long loginTime
	{
		[Token(Token = "0x60052DB")]
		[Address(RVA = "0x414E80", Offset = "0x414080", VA = "0x180414E80", Slot = "15")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Token(Token = "0x60052DC")]
		[Address(RVA = "0x980A60", Offset = "0x97FC60", VA = "0x180980A60")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17000C25")]
	public long followedTime
	{
		[Token(Token = "0x60052DD")]
		[Address(RVA = "0x580700", Offset = "0x57F900", VA = "0x180580700", Slot = "16")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Token(Token = "0x60052DE")]
		[Address(RVA = "0x994180", Offset = "0x993380", VA = "0x180994180")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17000C26")]
	public bool isOnline
	{
		[Token(Token = "0x60052DF")]
		[Address(RVA = "0x453D30", Offset = "0x452F30", VA = "0x180453D30", Slot = "17")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60052E0")]
		[Address(RVA = "0x415440", Offset = "0x414640", VA = "0x180415440")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17000C27")]
	public bool isEnableDuelWatch
	{
		[Token(Token = "0x60052E1")]
		[Address(RVA = "0x994110", Offset = "0x993310", VA = "0x180994110", Slot = "18")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000C28")]
	public int invitedRoomId
	{
		[Token(Token = "0x60052E2")]
		[Address(RVA = "0x404870", Offset = "0x403A70", VA = "0x180404870", Slot = "19")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60052E3")]
		[Address(RVA = "0x4048B0", Offset = "0x403AB0", VA = "0x1804048B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17000C29")]
	public int invitedTeamId
	{
		[Token(Token = "0x60052E4")]
		[Address(RVA = "0x404880", Offset = "0x403A80", VA = "0x180404880", Slot = "20")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60052E5")]
		[Address(RVA = "0x4048C0", Offset = "0x403AC0", VA = "0x1804048C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17000C2A")]
	public bool blocked
	{
		[Token(Token = "0x60052E6")]
		[Address(RVA = "0x9940C0", Offset = "0x9932C0", VA = "0x1809940C0", Slot = "21")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x60052E7")]
	[Address(RVA = "0x993DE0", Offset = "0x992FE0", VA = "0x180993DE0")]
	protected void Import(object playerData)
	{
	}

	[Token(Token = "0x60052E8")]
	[Address(RVA = "0x993D40", Offset = "0x992F40", VA = "0x180993D40")]
	public void ImportRefreshData(object playerRefreshData)
	{
	}

	[Token(Token = "0x60052E9")]
	[Address(RVA = "0x993B30", Offset = "0x992D30", VA = "0x180993B30", Slot = "23")]
	public virtual int CompareTo(IPlayerContext other)
	{
		return default(int);
	}

	[Token(Token = "0x60052EA")]
	[Address(RVA = "0x97E550", Offset = "0x97D750", VA = "0x18097E550")]
	protected PlayerContextBase()
	{
	}
}
