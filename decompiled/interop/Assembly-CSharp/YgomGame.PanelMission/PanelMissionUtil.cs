using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using YgomGame.Utility;

namespace YgomGame.PanelMission;

[Token(Token = "0x2000C1D")]
public static class PanelMissionUtil
{
	[Token(Token = "0x60049FD")]
	[Address(RVA = "0x944690", Offset = "0x943890", VA = "0x180944690")]
	public static (string, string) GetOnLaunchFailedDialogInfo(LaunchFailedCode launchFailedCode)
	{
		return default((string, string));
	}

	[Token(Token = "0x60049FE")]
	[Address(RVA = "0x944790", Offset = "0x943990", VA = "0x180944790")]
	public static void OpenLaunchFailedDialog(LaunchFailedCode launchFailedCode, [Optional] Action callback)
	{
	}

	[Token(Token = "0x60049FF")]
	[Address(RVA = "0x944780", Offset = "0x943980", VA = "0x180944780")]
	public static string MakeMissionName(TextGroupLoadHolder textGroupLoadHolder, int logicNo, List<object> logicParams)
	{
		return null;
	}

	[Token(Token = "0x6004A00")]
	[Address(RVA = "0x944770", Offset = "0x943970", VA = "0x180944770")]
	public static string MakeHintPath(string hintSfx)
	{
		return null;
	}

	[Token(Token = "0x6004A01")]
	[Address(RVA = "0x9444A0", Offset = "0x9436A0", VA = "0x1809444A0")]
	public static MissionState GetMissionState(Dictionary<string, object> panelMasterWork, Dictionary<string, object> panelDataWork, long currentTs)
	{
		return default(MissionState);
	}
}
