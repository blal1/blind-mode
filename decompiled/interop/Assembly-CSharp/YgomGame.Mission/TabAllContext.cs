using System.Collections.Generic;
using Il2CppDummyDll;

namespace YgomGame.Mission;

[Token(Token = "0x2000C01")]
public class TabAllContext : TabContext
{
	[Token(Token = "0x600491E")]
	[Address(RVA = "0x924AD0", Offset = "0x923CD0", VA = "0x180924AD0")]
	public TabAllContext()
	{
	}

	[Token(Token = "0x600491F")]
	[Address(RVA = "0x924810", Offset = "0x923A10", VA = "0x180924810")]
	public void ApplyContexts(List<TabContextImportable> tabs)
	{
	}
}
