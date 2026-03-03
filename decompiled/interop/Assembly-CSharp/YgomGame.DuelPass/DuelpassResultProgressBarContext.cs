using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace YgomGame.Duelpass;

[Token(Token = "0x2000ECA")]
public class DuelpassResultProgressBarContext
{
	[Token(Token = "0x17000DCB")]
	public GradeContext Before
	{
		[Token(Token = "0x6005995")]
		[Address(RVA = "0x40C440", Offset = "0x40B640", VA = "0x18040C440")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6005996")]
		[Address(RVA = "0x439010", Offset = "0x438210", VA = "0x180439010")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17000DCC")]
	public GradeContext BeforeForDisplay
	{
		[Token(Token = "0x6005997")]
		[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6005998")]
		[Address(RVA = "0x417C80", Offset = "0x416E80", VA = "0x180417C80")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17000DCD")]
	public GradeContext After
	{
		[Token(Token = "0x6005999")]
		[Address(RVA = "0x3D8370", Offset = "0x3D7570", VA = "0x1803D8370")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x600599A")]
		[Address(RVA = "0x3D8380", Offset = "0x3D7580", VA = "0x1803D8380")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17000DCE")]
	public GradeContext AfterForDisplay
	{
		[Token(Token = "0x600599B")]
		[Address(RVA = "0x4030F0", Offset = "0x4022F0", VA = "0x1804030F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x600599C")]
		[Address(RVA = "0x402FB0", Offset = "0x4021B0", VA = "0x180402FB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17000DCF")]
	public bool HasGoldpass
	{
		[Token(Token = "0x600599D")]
		[Address(RVA = "0x51FEA0", Offset = "0x51F0A0", VA = "0x18051FEA0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600599E")]
		[Address(RVA = "0x5FDF60", Offset = "0x5FD160", VA = "0x1805FDF60")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17000DD0")]
	public bool HasProgress
	{
		[Token(Token = "0x600599F")]
		[Address(RVA = "0x5F07F0", Offset = "0x5EF9F0", VA = "0x1805F07F0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60059A0")]
		[Address(RVA = "0x768DE0", Offset = "0x767FE0", VA = "0x180768DE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x60059A1")]
	[Address(RVA = "0x9F1D40", Offset = "0x9F0F40", VA = "0x1809F1D40")]
	public DuelpassResultProgressBarContext(int currentGrade, int percent, bool hasGoldpass, int afterCurrentGrade, int afterPercent)
	{
	}
}
