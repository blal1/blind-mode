using System.Collections.Generic;
using Il2CppDummyDll;
using YgomGame.Menu;
using YgomSystem.ElementSystem;
using YgomSystem.UI;

namespace YgomGame.SeasonPoint;

[Token(Token = "0x2000A51")]
public class SeasonPointViewController : BaseMenuViewController, IBackButtonSupported, IHeaderBorderSupported
{
	[Token(Token = "0x4009155")]
	private const string k_PREF_PATH = "SeasonPoint/SeasonPoint";

	[Token(Token = "0x4009156")]
	[FieldOffset(Offset = "0xD0")]
	private readonly string TITLE_NAME;

	[Token(Token = "0x4009157")]
	[FieldOffset(Offset = "0xD8")]
	private readonly string BUTTON_DETAIL_LABEL;

	[Token(Token = "0x4009158")]
	[FieldOffset(Offset = "0xE0")]
	private readonly string TEXT_NOTICE_LABEL;

	[Token(Token = "0x4009159")]
	[FieldOffset(Offset = "0xE8")]
	private readonly string UPDATE_DATE_TEXT;

	[Token(Token = "0x400915A")]
	[FieldOffset(Offset = "0xF0")]
	private readonly string SUMPOINT_GROUP_LABEL;

	[Token(Token = "0x400915B")]
	[FieldOffset(Offset = "0xF8")]
	private readonly string SUMPOINT_INFO_LABEL;

	[Token(Token = "0x400915C")]
	[FieldOffset(Offset = "0x100")]
	private readonly string MY_GROUP_LABEL;

	[Token(Token = "0x400915D")]
	[FieldOffset(Offset = "0x108")]
	private readonly string MY_INFO_LABEL;

	[Token(Token = "0x400915E")]
	[FieldOffset(Offset = "0x110")]
	private readonly string TEAM_GROUP_LABEL;

	[Token(Token = "0x400915F")]
	[FieldOffset(Offset = "0x118")]
	private readonly string MEMBER_INFO_LABEL;

	[Token(Token = "0x4009160")]
	[FieldOffset(Offset = "0x120")]
	private readonly string CP_TEXT_LABEL;

	[Token(Token = "0x4009161")]
	[FieldOffset(Offset = "0x128")]
	private readonly string CP_ICON_LABEL;

	[Token(Token = "0x4009162")]
	[FieldOffset(Offset = "0x130")]
	private readonly string SEASON_POINT_ICON_LABEL;

	[Token(Token = "0x4009163")]
	[FieldOffset(Offset = "0x138")]
	private readonly string TEXT_TEAM_NAME_LABEL;

	[Token(Token = "0x4009164")]
	[FieldOffset(Offset = "0x140")]
	private readonly string TEXT_POINT_LABEL;

	[Token(Token = "0x4009165")]
	[FieldOffset(Offset = "0x148")]
	private readonly string TEAM_ICON_LABEL;

	[Token(Token = "0x4009166")]
	[FieldOffset(Offset = "0x150")]
	private readonly string IMG_ICON_LABEL;

	[Token(Token = "0x4009167")]
	[FieldOffset(Offset = "0x158")]
	private readonly string PLATFORM_NAME_LABEL;

	[Token(Token = "0x4009168")]
	[FieldOffset(Offset = "0x160")]
	private readonly string PLATFORM_ICON_LABEL;

	[Token(Token = "0x4009169")]
	[FieldOffset(Offset = "0x168")]
	private readonly string TMP_BTN_LABEL;

	[Token(Token = "0x400916A")]
	private const string defaultText = "-";

	[Token(Token = "0x400916B")]
	[FieldOffset(Offset = "0x170")]
	private bool m_Createdteam;

	[Token(Token = "0x400916C")]
	[FieldOffset(Offset = "0x174")]
	private int m_MemberIndex;

	[Token(Token = "0x400916D")]
	[FieldOffset(Offset = "0x178")]
	private ElementObjectManager myGroup;

	[Token(Token = "0x400916E")]
	[FieldOffset(Offset = "0x180")]
	private ElementObjectManager myInfo;

	[Token(Token = "0x6003F53")]
	[Address(RVA = "0x878A70", Offset = "0x877C70", VA = "0x180878A70")]
	public static void Open(ViewControllerManager vcm)
	{
	}

	[Token(Token = "0x6003F54")]
	[Address(RVA = "0x878950", Offset = "0x877B50", VA = "0x180878950", Slot = "8")]
	public override void NotificationStack(ViewControllerManager vcm, ViewController vc, bool isEntry)
	{
	}

	[Token(Token = "0x6003F55")]
	[Address(RVA = "0x3E4080", Offset = "0x3E3280", VA = "0x1803E4080", Slot = "6")]
	public override void NotificationStackEntry()
	{
	}

	[Token(Token = "0x6003F56")]
	[Address(RVA = "0x878A40", Offset = "0x877C40", VA = "0x180878A40", Slot = "23")]
	protected override void OnCreatedView()
	{
	}

	[Token(Token = "0x6003F57")]
	[Address(RVA = "0x8780E0", Offset = "0x8772E0", VA = "0x1808780E0")]
	private void InitSetUp()
	{
	}

	[Token(Token = "0x6003F58")]
	[Address(RVA = "0x879BE0", Offset = "0x878DE0", VA = "0x180879BE0")]
	private void UpdateView()
	{
	}

	[Token(Token = "0x6003F59")]
	[Address(RVA = "0x8782B0", Offset = "0x8774B0", VA = "0x1808782B0")]
	private void IsCreatedTeam()
	{
	}

	[Token(Token = "0x6003F5A")]
	[Address(RVA = "0x8794F0", Offset = "0x8786F0", VA = "0x1808794F0")]
	private void SumInfoSetUp()
	{
	}

	[Token(Token = "0x6003F5B")]
	[Address(RVA = "0x878670", Offset = "0x877870", VA = "0x180878670")]
	private void MyInfoSetUp()
	{
	}

	[Token(Token = "0x6003F5C")]
	[Address(RVA = "0x8783E0", Offset = "0x8775E0", VA = "0x1808783E0")]
	private void MemberInfoSetUp(int index, int number)
	{
	}

	[Token(Token = "0x6003F5D")]
	[Address(RVA = "0x878AC0", Offset = "0x877CC0", VA = "0x180878AC0")]
	private void ProfileSetUp(Dictionary<string, object> dic)
	{
	}

	[Token(Token = "0x6003F5E")]
	[Address(RVA = "0x8790F0", Offset = "0x8782F0", VA = "0x1808790F0")]
	private void SetMemberData()
	{
	}

	[Token(Token = "0x6003F5F")]
	[Address(RVA = "0x879E10", Offset = "0x879010", VA = "0x180879E10")]
	public SeasonPointViewController()
	{
	}
}
