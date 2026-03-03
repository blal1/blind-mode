using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace YgomGame.Tdy;

[Token(Token = "0x2000855")]
public abstract class TDYMapParam
{
	[Token(Token = "0x40085EE")]
	internal const int AREA_MAX = 18;

	[Token(Token = "0x40085EF")]
	internal const int LEVEL_MAX = 4;

	[Token(Token = "0x1700064E")]
	public abstract int pollingPeriod
	{
		[Token(Token = "0x60032AC")]
		get;
	}

	[Token(Token = "0x1700064F")]
	public string pollingAPI
	{
		[Token(Token = "0x60032AE")]
		[Address(RVA = "0x40C440", Offset = "0x40B640", VA = "0x18040C440")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x60032AD")]
		[Address(RVA = "0x439010", Offset = "0x438210", VA = "0x180439010")]
		[CompilerGenerated]
		protected internal set
		{
		}
	}

	[Token(Token = "0x17000650")]
	public string cwPrefix
	{
		[Token(Token = "0x60032B0")]
		[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x60032AF")]
		[Address(RVA = "0x417C80", Offset = "0x416E80", VA = "0x180417C80")]
		[CompilerGenerated]
		protected internal set
		{
		}
	}

	[Token(Token = "0x17000651")]
	public string cwPollIntervalPath
	{
		[Token(Token = "0x60032B2")]
		[Address(RVA = "0x3D8370", Offset = "0x3D7570", VA = "0x1803D8370")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x60032B1")]
		[Address(RVA = "0x3D8380", Offset = "0x3D7580", VA = "0x1803D8380")]
		[CompilerGenerated]
		protected internal set
		{
		}
	}

	[Token(Token = "0x17000652")]
	public object prevMapData
	{
		[Token(Token = "0x60032B4")]
		[Address(RVA = "0x4030F0", Offset = "0x4022F0", VA = "0x1804030F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x60032B3")]
		[Address(RVA = "0x402FB0", Offset = "0x4021B0", VA = "0x180402FB0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x60032B5")]
	[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
	protected TDYMapParam()
	{
	}
}
