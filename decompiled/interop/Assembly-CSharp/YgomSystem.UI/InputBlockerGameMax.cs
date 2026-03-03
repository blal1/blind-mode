using Il2CppDummyDll;

namespace YgomSystem.UI;

[Token(Token = "0x200056A")]
public class InputBlockerGameMax : AbstractInputBlocker
{
	[Token(Token = "0x170003C7")]
	protected override int blockPriority
	{
		[Token(Token = "0x600231B")]
		[Address(RVA = "0x6494B0", Offset = "0x6486B0", VA = "0x1806494B0", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x600231C")]
	[Address(RVA = "0x422F60", Offset = "0x422160", VA = "0x180422F60")]
	public InputBlockerGameMax()
	{
	}
}
