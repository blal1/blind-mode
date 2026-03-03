using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using YgomGame.Menu;
using YgomSystem.ElementSystem;
using YgomSystem.UI;

namespace YgomGame.SeasonPoint;

[Token(Token = "0x2000A42")]
public class SeasonPointTeamTopViewController : BaseMenuViewController, IBackButtonSupported, IHeaderBorderSupported
{
	[Token(Token = "0x40090E3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	private readonly string L_AreaText;

	[Token(Token = "0x40090E4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	private readonly string L_TeamIdText;

	[Token(Token = "0x40090E5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	private readonly string L_Leader;

	[Token(Token = "0x40090E6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	private readonly string L_PlayerBoard;

	[Token(Token = "0x40090E7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	private readonly string L_TeamMember1;

	[Token(Token = "0x40090E8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	private readonly string L_TeamMember2;

	[Token(Token = "0x40090E9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
	private readonly string L_MenuButton;

	[Token(Token = "0x40090EA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
	private readonly string L_MenuButtonArea;

	[Token(Token = "0x40090EB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
	private readonly string L_EntryButton;

	[Token(Token = "0x40090EC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
	private readonly string L_EntryButtonArea;

	[Token(Token = "0x40090ED")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
	private readonly string L_StatusJoin;

	[Token(Token = "0x40090EE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
	private readonly string L_StatusLeave;

	[Token(Token = "0x40090EF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
	private readonly string L_StatusNone;

	[Token(Token = "0x40090F0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
	private readonly string L_TextNotice;

	[Token(Token = "0x40090F1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
	private readonly string L_TextCaution;

	[Token(Token = "0x40090F2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
	private readonly string L_ButtonDetail;

	[Token(Token = "0x40090F3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
	private readonly string L_ButtonGroup;

	[Token(Token = "0x40090F4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
	private readonly string L_PlateGroup;

	[Token(Token = "0x40090F5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
	private Dictionary<int, TeamMemberData> teamMemberDatas;

	[Token(Token = "0x40090F6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
	private Dictionary<int, int> memberStatusMap;

	[Token(Token = "0x40090F7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
	private List<PlayerWidget> PlayerWidgets;

	[Token(Token = "0x40090F8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
	private ElementObjectManager teamMember1Eom;

	[Token(Token = "0x40090F9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
	private ElementObjectManager teamMember2Eom;

	[Token(Token = "0x40090FA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
	private GameObject entryButtonArea;

	[Token(Token = "0x40090FB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
	private GameObject menuButtonArea;

	[Token(Token = "0x40090FC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
	private SelectionButton menuButton;

	[Token(Token = "0x40090FD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
	private bool isLeader;

	[Token(Token = "0x40090FE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A4")]
	private int myId;

	[Token(Token = "0x40090FF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
	private int uniqueTeamId;

	[Token(Token = "0x4009100")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1AC")]
	private int regionIdx;

	[Token(Token = "0x4009101")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1B0")]
	private long myPcode;

	[Token(Token = "0x4009102")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1B8")]
	private long disbandableEndData;

	[Token(Token = "0x4009103")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C0")]
	private long disbandableStartData;

	[Token(Token = "0x4009104")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C8")]
	private string disbandLimiTime;

	[Token(Token = "0x4009105")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1D0")]
	private int disband_grace;

	[Token(Token = "0x4009106")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1D4")]
	private SeasonPointUtil.TeamStatus teamStatus;

	[Token(Token = "0x1700085A")]
	private bool isEntry
	{
		[Token(Token = "0x6003ED9")]
		[Address(RVA = "0x874500", Offset = "0x873700", VA = "0x180874500")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700085B")]
	protected override Type[] textIds
	{
		[Token(Token = "0x6003EDA")]
		[Address(RVA = "0x8745A0", Offset = "0x8737A0", VA = "0x1808745A0", Slot = "21")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6003EDB")]
	[Address(RVA = "0x871760", Offset = "0x870960", VA = "0x180871760")]
	public static void Open([Optional] Action callback)
	{
	}

	[Token(Token = "0x6003EDC")]
	[Address(RVA = "0x8708C0", Offset = "0x86FAC0", VA = "0x1808708C0", Slot = "6")]
	public override void NotificationStackEntry()
	{
	}

	[Token(Token = "0x6003EDD")]
	[Address(RVA = "0x871880", Offset = "0x870A80", VA = "0x180871880")]
	private void SetCWData()
	{
	}

	[Token(Token = "0x6003EDE")]
	[Address(RVA = "0x872830", Offset = "0x871A30", VA = "0x180872830")]
	private void SetTeamMemberData(int index, Dictionary<string, object> dic)
	{
	}

	[Token(Token = "0x6003EDF")]
	[Address(RVA = "0x873250", Offset = "0x872450", VA = "0x180873250")]
	private void UpdateData()
	{
	}

	[Token(Token = "0x6003EE0")]
	[Address(RVA = "0x8709E0", Offset = "0x86FBE0", VA = "0x1808709E0", Slot = "23")]
	protected override void OnCreatedView()
	{
	}

	[Token(Token = "0x6003EE1")]
	[Address(RVA = "0x871EB0", Offset = "0x8710B0", VA = "0x180871EB0")]
	private void SetElements()
	{
	}

	[Token(Token = "0x6003EE2")]
	[Address(RVA = "0x873440", Offset = "0x872640", VA = "0x180873440")]
	private void UpdatePlayerBoard()
	{
	}

	[Token(Token = "0x6003EE3")]
	[Address(RVA = "0x870850", Offset = "0x86FA50", VA = "0x180870850")]
	private bool CheckDisbandable()
	{
		return default(bool);
	}

	[Token(Token = "0x6003EE4")]
	[Address(RVA = "0x872B00", Offset = "0x871D00", VA = "0x180872B00")]
	private void UpdateView()
	{
	}

	[Token(Token = "0x6003EE5")]
	[Address(RVA = "0x870EA0", Offset = "0x8700A0", VA = "0x180870EA0")]
	private void OpenManagementMenu()
	{
	}

	[Token(Token = "0x6003EE6")]
	[Address(RVA = "0x870B10", Offset = "0x86FD10", VA = "0x180870B10")]
	private void OpenDissolutionDialog()
	{
	}

	[Token(Token = "0x6003EE7")]
	[Address(RVA = "0x870420", Offset = "0x86F620", VA = "0x180870420")]
	private void CallAPITeamDissolution()
	{
	}

	[Token(Token = "0x6003EE8")]
	[Address(RVA = "0x870370", Offset = "0x86F570", VA = "0x180870370")]
	private void CallAPITeamDissolutionRequest()
	{
	}

	[Token(Token = "0x6003EE9")]
	[Address(RVA = "0x8702C0", Offset = "0x86F4C0", VA = "0x1808702C0")]
	private void CallAPITeamDissolutionRequestCancel()
	{
	}

	[Token(Token = "0x6003EEA")]
	[Address(RVA = "0x870560", Offset = "0x86F760", VA = "0x180870560")]
	private void CallAPITeamEntry()
	{
	}

	[Token(Token = "0x6003EEB")]
	[Address(RVA = "0x8708F0", Offset = "0x86FAF0", VA = "0x1808708F0", Slot = "13")]
	public override bool OnBack()
	{
		return default(bool);
	}

	[Token(Token = "0x6003EEC")]
	[Address(RVA = "0x8740B0", Offset = "0x8732B0", VA = "0x1808740B0")]
	public SeasonPointTeamTopViewController()
	{
	}
}
