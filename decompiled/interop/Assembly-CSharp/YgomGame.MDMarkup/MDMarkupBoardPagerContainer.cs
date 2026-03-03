using System;
using Il2CppDummyDll;

namespace YgomGame.MDMarkup;

[Serializable]
[Token(Token = "0x2000C6D")]
public class MDMarkupBoardPagerContainer : MDMarkupTabsContainer
{
	[Token(Token = "0x17000A38")]
	public override MDMarkupDef.ContainerType containerType
	{
		[Token(Token = "0x6004B4B")]
		[Address(RVA = "0x4446D0", Offset = "0x4438D0", VA = "0x1804446D0", Slot = "15")]
		get
		{
			return default(MDMarkupDef.ContainerType);
		}
	}

	[Token(Token = "0x6004B4C")]
	[Address(RVA = "0x9360C0", Offset = "0x9352C0", VA = "0x1809360C0")]
	public MDMarkupBoardPagerContainer()
	{
	}
}
