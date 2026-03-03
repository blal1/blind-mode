using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using YgomGame.Menu;
using YgomSystem.UI;
using YgomSystem.UI.ElementWidget;
using YgomSystem.YGomTMPro;

namespace YgomGame.Team;

[Token(Token = "0x200164E")]
public class TeamDesignationViewController : BaseMenuViewController, IBackButtonSupported, IHeaderBorderSupported
{
	[Token(Token = "0x400D5C4")]
	private const string VC_PATH = "Team/TeamDesignation";

	[Token(Token = "0x400D5C5")]
	private const string ARGKEY_DURATION_CONFIG = "duration_config";

	[Token(Token = "0x400D5C6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	private TeamLobbyPollingWatcher _watchDog;

	[Token(Token = "0x400D5C7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	private InputFieldWidget _teamIdInput;

	[Token(Token = "0x400D5C8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	private SelectionButton _duelDurationSelectBtn;

	[Token(Token = "0x400D5C9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	private ExtendedTextMeshProUGUI _duelDurationValueText;

	[Token(Token = "0x400D5CA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	private SelectionButton _applyButton;

	[Token(Token = "0x400D5CB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	private List<(int id, string name, int duration, int order)> _duelDurationConfigList;

	[Token(Token = "0x400D5CC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
	private int _selectedDuelDurationIndex;

	[Token(Token = "0x6008AC8")]
	[Address(RVA = "0xD626B0", Offset = "0xD618B0", VA = "0x180D626B0")]
	public static void Open(ViewControllerManager manager, List<(int id, string name, int duration, int order)> duelDurationConfigList, [Optional] Dictionary<string, object> args)
	{
	}

	[Token(Token = "0x6008AC9")]
	[Address(RVA = "0xD61DC0", Offset = "0xD60FC0", VA = "0x180D61DC0", Slot = "6")]
	public override void NotificationStackEntry()
	{
	}

	[Token(Token = "0x6008ACA")]
	[Address(RVA = "0xD62040", Offset = "0xD61240", VA = "0x180D62040", Slot = "23")]
	protected override void OnCreatedView()
	{
	}

	[Token(Token = "0x6008ACB")]
	[Address(RVA = "0xD61B80", Offset = "0xD60D80", VA = "0x180D61B80")]
	private void LoadData()
	{
	}

	[Token(Token = "0x6008ACC")]
	[Address(RVA = "0xD61F40", Offset = "0xD61140", VA = "0x180D61F40")]
	private void OnApplyingForMatch()
	{
	}

	[Token(Token = "0x6008ACD")]
	[Address(RVA = "0xD62620", Offset = "0xD61820", VA = "0x180D62620")]
	private void OnTeamIDInputEnd(string text)
	{
	}

	[Token(Token = "0x6008ACE")]
	[Address(RVA = "0xD62420", Offset = "0xD61620", VA = "0x180D62420")]
	private void OnDuelDurationSelecting()
	{
	}

	[Token(Token = "0x6008ACF")]
	[Address(RVA = "0xD61A50", Offset = "0xD60C50", VA = "0x180D61A50")]
	private string AcquireDuelDurationConfigName(int index)
	{
		return null;
	}

	[Token(Token = "0x6008AD0")]
	[Address(RVA = "0x3E3340", Offset = "0x3E2540", VA = "0x1803E3340")]
	public TeamDesignationViewController()
	{
	}
}
