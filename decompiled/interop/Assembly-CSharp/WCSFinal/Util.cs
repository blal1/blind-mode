using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using YgomSystem.UI;

namespace WCSFinal;

[Token(Token = "0x2000103")]
public class Util
{
	[Token(Token = "0x400066F")]
	public const string APP_VERSION = "Yu-Gi-Oh! World Championship 2024";

	[Token(Token = "0x4000670")]
	private const string PATH_PREFIX = "Prefabs/VC/WCS/WCSFinal/";

	[Token(Token = "0x4000671")]
	public const string PATH_DUELMENU = "Prefabs/VC/WCS/WCSFinal/WCSFinal_Colosseum";

	[Token(Token = "0x4000672")]
	public const string PATH_ADMIN_1STSTAGE = "Prefabs/VC/WCS/Portal/WCSLeagueBattleInfo";

	[Token(Token = "0x4000673")]
	public const string PATH_ADMIN_TOURNAMENT = "Prefabs/VC/WCS/Portal/WCSFinalBattleInfo";

	[Token(Token = "0x4000674")]
	public const string PATH_PROFILE = "Prefabs/VC/WCS/WCSFinal/WCSFinal_Profile";

	[Token(Token = "0x4000675")]
	public const string PATH_TEAM_TABLE = "Prefabs/VC/WCS/WCSFinal/WCSFinal_TeamTable";

	[Token(Token = "0x4000676")]
	public const string PATH_TIMER = "Prefabs/VC/WCS/WCSFinal/WCSFinal_Timer";

	[Token(Token = "0x4000677")]
	public const string PATH_TIMESETTING = "Prefabs/VC/WCS/WCSFinal/WCSFinal_TimerSetting";

	[Token(Token = "0x6000689")]
	[Address(RVA = "0x9E7A30", Offset = "0x9E6C30", VA = "0x1809E7A30")]
	public static void PushChildViewController(ViewControllerManager manager, string prefabpath, [Optional] Dictionary<string, object> args)
	{
	}

	[Token(Token = "0x600068A")]
	[Address(RVA = "0x9E73B0", Offset = "0x9E65B0", VA = "0x1809E73B0")]
	private static void GetArgs(string prefabpath, ref Dictionary<string, object> args)
	{
	}

	[Token(Token = "0x600068B")]
	[Address(RVA = "0x9E79A0", Offset = "0x9E6BA0", VA = "0x1809E79A0")]
	public static bool IsWCSAdmin()
	{
		return default(bool);
	}

	[Token(Token = "0x600068C")]
	[Address(RVA = "0x9E73A0", Offset = "0x9E65A0", VA = "0x1809E73A0")]
	public static bool CheckCurrentTimeDispSwicthingTriger()
	{
		return default(bool);
	}

	[Token(Token = "0x600068D")]
	[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
	public Util()
	{
	}
}
