using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace YgomSystem;

[Token(Token = "0x2000154")]
public abstract class Behavior
{
	[Token(Token = "0x170000E5")]
	public string name
	{
		[Token(Token = "0x600087F")]
		[Address(RVA = "0x40C440", Offset = "0x40B640", VA = "0x18040C440")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x600087E")]
		[Address(RVA = "0x439010", Offset = "0x438210", VA = "0x180439010")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x170000E6")]
	public bool alive
	{
		[Token(Token = "0x6000881")]
		[Address(RVA = "0x444790", Offset = "0x443990", VA = "0x180444790")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000880")]
		[Address(RVA = "0x662770", Offset = "0x661970", VA = "0x180662770")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Token(Token = "0x6000882")]
	public abstract void Update(float deltaTime);

	[Token(Token = "0x6000883")]
	[Address(RVA = "0xAF1F70", Offset = "0xAF1170", VA = "0x180AF1F70")]
	protected Behavior()
	{
	}
}
