using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace YgomGame.Duelpass;

[Token(Token = "0x2000ECB")]
public class DuelpassRewardColumnContext
{
	[Token(Token = "0x17000DD1")]
	public int Grade
	{
		[Token(Token = "0x60059A3")]
		[Address(RVA = "0x3C7100", Offset = "0x3C6300", VA = "0x1803C7100")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60059A2")]
		[Address(RVA = "0x5F4710", Offset = "0x5F3910", VA = "0x1805F4710")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17000DD2")]
	public int ScrollEntityIdx
	{
		[Token(Token = "0x60059A5")]
		[Address(RVA = "0x64B770", Offset = "0x64A970", VA = "0x18064B770")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60059A4")]
		[Address(RVA = "0x64B780", Offset = "0x64A980", VA = "0x18064B780")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17000DD3")]
	public int NormalRewardId
	{
		[Token(Token = "0x60059A7")]
		[Address(RVA = "0x5C7C60", Offset = "0x5C6E60", VA = "0x1805C7C60")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60059A6")]
		[Address(RVA = "0x615AB0", Offset = "0x614CB0", VA = "0x180615AB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17000DD4")]
	public int GoldRewardId
	{
		[Token(Token = "0x60059A9")]
		[Address(RVA = "0x62E220", Offset = "0x62D420", VA = "0x18062E220")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60059A8")]
		[Address(RVA = "0x62E250", Offset = "0x62D450", VA = "0x18062E250")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x60059AA")]
	[Address(RVA = "0x9F3680", Offset = "0x9F2880", VA = "0x1809F3680")]
	public DuelpassRewardColumnContext(int grade, int scrollEntityIdx, int normalRewardId = -1, int goldRewardId = -1)
	{
	}
}
