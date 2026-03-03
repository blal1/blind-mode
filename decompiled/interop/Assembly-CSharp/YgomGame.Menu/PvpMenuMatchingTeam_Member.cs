using System.Collections.Generic;
using Il2CppDummyDll;
using YgomSystem.Network;

namespace YgomGame.Menu;

[Token(Token = "0x20013C6")]
public class PvpMenuMatchingTeam_Member : PvpMenuMatchingTeam
{
	[Token(Token = "0x6007AF7")]
	[Address(RVA = "0xC46E00", Offset = "0xC46000", VA = "0x180C46E00", Slot = "12")]
	protected override Handle CallAPIMatching(Dictionary<string, object> matchParam)
	{
		return null;
	}

	[Token(Token = "0x6007AF8")]
	[Address(RVA = "0xC46E10", Offset = "0xC46010", VA = "0x180C46E10", Slot = "13")]
	protected override void OnCompleteMatchingHandle(Handle e)
	{
	}

	[Token(Token = "0x6007AF9")]
	[Address(RVA = "0xC44370", Offset = "0xC43570", VA = "0x180C44370")]
	public PvpMenuMatchingTeam_Member()
	{
	}
}
