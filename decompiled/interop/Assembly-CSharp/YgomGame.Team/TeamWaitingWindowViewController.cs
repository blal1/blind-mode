using Il2CppDummyDll;
using YgomGame.Menu;
using YgomSystem.UI;

namespace YgomGame.Team;

[Token(Token = "0x20016B3")]
public class TeamWaitingWindowViewController : BaseMenuViewController
{
	[Token(Token = "0x400D7FE")]
	public const string PREFAB_PATH = "Team/TeamWaitingWindow";

	[Token(Token = "0x400D7FF")]
	private const string KEY_MESSAGE = "message";

	[Token(Token = "0x400D800")]
	[FieldOffset(Offset = "0xD0")]
	private readonly string E_ButtonCancel;

	[Token(Token = "0x400D801")]
	[FieldOffset(Offset = "0xD8")]
	private readonly string E_RootText;

	[Token(Token = "0x400D802")]
	[FieldOffset(Offset = "0xE0")]
	private readonly string E_TextSearching;

	[Token(Token = "0x6008D2A")]
	[Address(RVA = "0xD8CAD0", Offset = "0xD8BCD0", VA = "0x180D8CAD0")]
	public static void Open(ViewControllerManager manager, string message = "")
	{
	}

	[Token(Token = "0x6008D2B")]
	[Address(RVA = "0xD8C870", Offset = "0xD8BA70", VA = "0x180D8C870")]
	public static bool Close(ViewControllerManager manager)
	{
		return default(bool);
	}

	[Token(Token = "0x6008D2C")]
	[Address(RVA = "0x3E4080", Offset = "0x3E3280", VA = "0x1803E4080", Slot = "6")]
	public override void NotificationStackEntry()
	{
	}

	[Token(Token = "0x6008D2D")]
	[Address(RVA = "0xD8C910", Offset = "0xD8BB10", VA = "0x180D8C910", Slot = "23")]
	protected override void OnCreatedView()
	{
	}

	[Token(Token = "0x6008D2E")]
	[Address(RVA = "0xD8CBA0", Offset = "0xD8BDA0", VA = "0x180D8CBA0")]
	public TeamWaitingWindowViewController()
	{
	}
}
