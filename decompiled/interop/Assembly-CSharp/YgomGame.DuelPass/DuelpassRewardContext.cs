using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace YgomGame.Duelpass;

[Token(Token = "0x2000ECD")]
public class DuelpassRewardContext
{
	[Token(Token = "0x17000DD5")]
	public bool IsPeriod
	{
		[Token(Token = "0x60059AB")]
		[Address(RVA = "0x465880", Offset = "0x464A80", VA = "0x180465880")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60059AC")]
		[Address(RVA = "0x71FA70", Offset = "0x71EC70", VA = "0x18071FA70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17000DD6")]
	public int ItemCategory
	{
		[Token(Token = "0x60059AD")]
		[Address(RVA = "0x64B770", Offset = "0x64A970", VA = "0x18064B770")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60059AE")]
		[Address(RVA = "0x64B780", Offset = "0x64A980", VA = "0x18064B780")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17000DD7")]
	public int ItemId
	{
		[Token(Token = "0x60059AF")]
		[Address(RVA = "0x5C7C60", Offset = "0x5C6E60", VA = "0x1805C7C60")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60059B0")]
		[Address(RVA = "0x615AB0", Offset = "0x614CB0", VA = "0x180615AB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17000DD8")]
	public int ItemCount
	{
		[Token(Token = "0x60059B1")]
		[Address(RVA = "0x62E220", Offset = "0x62D420", VA = "0x18062E220")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60059B2")]
		[Address(RVA = "0x62E250", Offset = "0x62D450", VA = "0x18062E250")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17000DD9")]
	public bool IsRecommend
	{
		[Token(Token = "0x60059B3")]
		[Address(RVA = "0x416680", Offset = "0x415880", VA = "0x180416680")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60059B4")]
		[Address(RVA = "0x4166E0", Offset = "0x4158E0", VA = "0x1804166E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17000DDA")]
	public int Grade
	{
		[Token(Token = "0x60059B5")]
		[Address(RVA = "0x416290", Offset = "0x415490", VA = "0x180416290")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60059B6")]
		[Address(RVA = "0x416370", Offset = "0x415570", VA = "0x180416370")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17000DDB")]
	public int RewardId
	{
		[Token(Token = "0x60059B7")]
		[Address(RVA = "0x62E210", Offset = "0x62D410", VA = "0x18062E210")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60059B8")]
		[Address(RVA = "0x62E240", Offset = "0x62D440", VA = "0x18062E240")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17000DDC")]
	public bool IsReceived
	{
		[Token(Token = "0x60059B9")]
		[Address(RVA = "0x66A190", Offset = "0x669390", VA = "0x18066A190")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60059BA")]
		[Address(RVA = "0x6B2310", Offset = "0x6B1510", VA = "0x1806B2310")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17000DDD")]
	public PASS_TYPE PassType
	{
		[Token(Token = "0x60059BB")]
		[Address(RVA = "0x49B840", Offset = "0x49AA40", VA = "0x18049B840")]
		[CompilerGenerated]
		get
		{
			return default(PASS_TYPE);
		}
		[Token(Token = "0x60059BC")]
		[Address(RVA = "0x49C0C0", Offset = "0x49B2C0", VA = "0x18049C0C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17000DDE")]
	public bool IsAchieved
	{
		[Token(Token = "0x60059BD")]
		[Address(RVA = "0x4166A0", Offset = "0x4158A0", VA = "0x1804166A0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60059BE")]
		[Address(RVA = "0x416700", Offset = "0x415900", VA = "0x180416700")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17000DDF")]
	public bool HasGoldPass
	{
		[Token(Token = "0x60059BF")]
		[Address(RVA = "0x9F4B40", Offset = "0x9F3D40", VA = "0x1809F4B40")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60059C0")]
		[Address(RVA = "0x9F4B50", Offset = "0x9F3D50", VA = "0x1809F4B50")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x60059C1")]
	[Address(RVA = "0x9F49A0", Offset = "0x9F3BA0", VA = "0x1809F49A0")]
	public DuelpassRewardContext(object master, int rewardId, bool isRecieved, bool isAchieved, bool hasGoldPass)
	{
	}

	[Token(Token = "0x60059C2")]
	[Address(RVA = "0x9F4850", Offset = "0x9F3A50", VA = "0x1809F4850")]
	public DuelpassRewardContext(object master, int grade, int rewardId, bool isReceived, bool isAchieved, PASS_TYPE passType, bool hasGoldPass)
	{
	}

	[Token(Token = "0x60059C3")]
	[Address(RVA = "0x9F4840", Offset = "0x9F3A40", VA = "0x1809F4840")]
	public void Receive()
	{
	}

	[Token(Token = "0x60059C4")]
	[Address(RVA = "0x9F4820", Offset = "0x9F3A20", VA = "0x1809F4820")]
	public bool CanReceive()
	{
		return default(bool);
	}
}
