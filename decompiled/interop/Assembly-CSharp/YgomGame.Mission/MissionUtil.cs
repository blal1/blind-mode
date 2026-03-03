using System.Collections.Generic;
using Il2CppDummyDll;
using YgomGame.Utility;

namespace YgomGame.Mission;

[Token(Token = "0x2000BD2")]
public static class MissionUtil
{
	[Token(Token = "0x60047DC")]
	[Address(RVA = "0x8FDB00", Offset = "0x8FCD00", VA = "0x1808FDB00")]
	public static bool IsResidentTab(this MissionTabType tabType)
	{
		return default(bool);
	}

	[Token(Token = "0x60047DD")]
	[Address(RVA = "0x8FDA90", Offset = "0x8FCC90", VA = "0x1808FDA90")]
	public static bool ExistsUnlockResidentTab(this MissionTabType tabType)
	{
		return default(bool);
	}

	[Token(Token = "0x60047DE")]
	[Address(RVA = "0x8FDAA0", Offset = "0x8FCCA0", VA = "0x1808FDAA0")]
	public static int GetOrder(this MissionTabType tabType)
	{
		return default(int);
	}

	[Token(Token = "0x60047DF")]
	[Address(RVA = "0x8FDC40", Offset = "0x8FCE40", VA = "0x1808FDC40")]
	public static MissionTabType ToResidentTabType(this MissionCategory category)
	{
		return default(MissionTabType);
	}

	[Token(Token = "0x60047E0")]
	[Address(RVA = "0x8FDB80", Offset = "0x8FCD80", VA = "0x1808FDB80")]
	public static string MakeMissionName(TextGroupLoadHolder textGroupLoadHolder, int logicNo, List<object> logicParams)
	{
		return null;
	}

	[Token(Token = "0x60047E1")]
	[Address(RVA = "0x8FDB10", Offset = "0x8FCD10", VA = "0x1808FDB10")]
	public static string MakeHintPath(string hintSfx)
	{
		return null;
	}
}
