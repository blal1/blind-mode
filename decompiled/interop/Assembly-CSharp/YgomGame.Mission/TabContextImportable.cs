using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace YgomGame.Mission;

[Token(Token = "0x2000C04")]
public class TabContextImportable : TabContext
{
	[Token(Token = "0x6004933")]
	[Address(RVA = "0x925310", Offset = "0x924510", VA = "0x180925310")]
	public TabContextImportable(MissionTabType tabType, int campaignPoolId = 0, long campaignBeginTs = 0L, [Optional] string tabNameTextId, [Optional] string tabShortNameTextId)
	{
	}

	[Token(Token = "0x6004934")]
	[Address(RVA = "0x924C70", Offset = "0x923E70", VA = "0x180924C70")]
	public void ImportOverride(List<Dictionary<string, object>> masters, List<Dictionary<string, object>> datas)
	{
	}

	[Token(Token = "0x6004935")]
	[Address(RVA = "0x924B00", Offset = "0x923D00", VA = "0x180924B00")]
	public void ImportOverride(Dictionary<string, object> master, Dictionary<string, object> data)
	{
	}

	[Token(Token = "0x6004936")]
	[Address(RVA = "0x924F80", Offset = "0x924180", VA = "0x180924F80")]
	private void InnerImportOverride(Dictionary<string, object> master, Dictionary<string, object> data)
	{
	}
}
