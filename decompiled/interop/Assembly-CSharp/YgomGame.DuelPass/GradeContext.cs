using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace YgomGame.Duelpass;

[Token(Token = "0x2000EC8")]
public class GradeContext
{
	[Token(Token = "0x17000DC5")]
	public int Current
	{
		[Token(Token = "0x6005986")]
		[Address(RVA = "0x3C7100", Offset = "0x3C6300", VA = "0x1803C7100")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6005987")]
		[Address(RVA = "0x5F4710", Offset = "0x5F3910", VA = "0x1805F4710")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17000DC6")]
	public int Next
	{
		[Token(Token = "0x6005988")]
		[Address(RVA = "0x64B770", Offset = "0x64A970", VA = "0x18064B770")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6005989")]
		[Address(RVA = "0x64B780", Offset = "0x64A980", VA = "0x18064B780")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17000DC7")]
	public int Percent
	{
		[Token(Token = "0x600598A")]
		[Address(RVA = "0x5C7C60", Offset = "0x5C6E60", VA = "0x1805C7C60")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Token(Token = "0x600598B")]
		[Address(RVA = "0x615AB0", Offset = "0x614CB0", VA = "0x180615AB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17000DC8")]
	public float PercentNorm
	{
		[Token(Token = "0x600598C")]
		[Address(RVA = "0x9F76B0", Offset = "0x9F68B0", VA = "0x1809F76B0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Token(Token = "0x600598D")]
		[Address(RVA = "0x9F76C0", Offset = "0x9F68C0", VA = "0x1809F76C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x600598E")]
	[Address(RVA = "0x9F7650", Offset = "0x9F6850", VA = "0x1809F7650")]
	public GradeContext(int current, int next, int percent)
	{
	}

	[Token(Token = "0x600598F")]
	[Address(RVA = "0x9F7640", Offset = "0x9F6840", VA = "0x1809F7640")]
	public float GetProgress()
	{
		return default(float);
	}
}
