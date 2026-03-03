using System.Collections.Generic;
using Il2CppDummyDll;
using YgomSystem.Network;

namespace YgomGame.Menu;

[Token(Token = "0x20013C5")]
public class PvpMenuMatchingTeam_Leader : PvpMenuMatchingTeam
{
	[Token(Token = "0x6007AF2")]
	[Address(RVA = "0xC46BF0", Offset = "0xC45DF0", VA = "0x180C46BF0", Slot = "12")]
	protected override Handle CallAPIMatching(Dictionary<string, object> matchParam)
	{
		return null;
	}

	[Token(Token = "0x6007AF3")]
	[Address(RVA = "0xC46C00", Offset = "0xC45E00", VA = "0x180C46C00", Slot = "13")]
	protected override void OnCompleteMatchingHandle(Handle e)
	{
	}

	[Token(Token = "0x6007AF4")]
	[Address(RVA = "0xC44370", Offset = "0xC43570", VA = "0x180C44370")]
	public PvpMenuMatchingTeam_Leader()
	{
	}
}
