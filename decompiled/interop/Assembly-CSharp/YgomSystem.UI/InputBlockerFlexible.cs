using Il2CppDummyDll;

namespace YgomSystem.UI;

[Token(Token = "0x2000569")]
public class InputBlockerFlexible : AbstractInputBlocker
{
	[Token(Token = "0x4001A6B")]
	[FieldOffset(Offset = "0x28")]
	public int _blockPriority;

	[Token(Token = "0x170003C6")]
	protected override int blockPriority
	{
		[Token(Token = "0x6002318")]
		[Address(RVA = "0x62E210", Offset = "0x62D410", VA = "0x18062E210", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x6002319")]
	[Address(RVA = "0x6493E0", Offset = "0x6485E0", VA = "0x1806493E0")]
	public void SetBlockPriority(int priority)
	{
	}

	[Token(Token = "0x600231A")]
	[Address(RVA = "0x422F60", Offset = "0x422160", VA = "0x180422F60")]
	public InputBlockerFlexible()
	{
	}
}
