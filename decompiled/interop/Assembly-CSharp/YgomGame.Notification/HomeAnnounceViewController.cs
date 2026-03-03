using System;
using Il2CppDummyDll;
using YgomGame.Menu;
using YgomSystem.UI;

namespace YgomGame.Notification;

[Token(Token = "0x2000C33")]
public class HomeAnnounceViewController : BaseMenuViewController
{
	[Token(Token = "0x4009A8F")]
	public const string PREFAB_PATH = "Home/HomeAnnounce";

	[Token(Token = "0x4009A90")]
	private const string k_ArgKeyOnClosedCallback = "OnClosedCallback";

	[Token(Token = "0x4009A91")]
	[FieldOffset(Offset = "0xD0")]
	private bool k_IsPop;

	[Token(Token = "0x17000A24")]
	protected override int outGameBgId
	{
		[Token(Token = "0x6004A89")]
		[Address(RVA = "0x3EF020", Offset = "0x3EE220", VA = "0x1803EF020", Slot = "20")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x6004A8A")]
	[Address(RVA = "0x933210", Offset = "0x932410", VA = "0x180933210")]
	public static void Open(Action onClosed)
	{
	}

	[Token(Token = "0x6004A8B")]
	[Address(RVA = "0x932DC0", Offset = "0x931FC0", VA = "0x180932DC0", Slot = "8")]
	public override void NotificationStack(ViewControllerManager vcm, ViewController vc, bool isEntry)
	{
	}

	[Token(Token = "0x6004A8C")]
	[Address(RVA = "0x932C90", Offset = "0x931E90", VA = "0x180932C90", Slot = "6")]
	public override void NotificationStackEntry()
	{
	}

	[Token(Token = "0x6004A8D")]
	[Address(RVA = "0x932D10", Offset = "0x931F10", VA = "0x180932D10", Slot = "7")]
	public override void NotificationStackRemove()
	{
	}

	[Token(Token = "0x6004A8E")]
	[Address(RVA = "0x932F80", Offset = "0x932180", VA = "0x180932F80")]
	private bool OpenAnnounce()
	{
		return default(bool);
	}

	[Token(Token = "0x6004A8F")]
	[Address(RVA = "0x9332F0", Offset = "0x9324F0", VA = "0x1809332F0")]
	private void SafetyPop()
	{
	}

	[Token(Token = "0x6004A90")]
	[Address(RVA = "0x3E3340", Offset = "0x3E2540", VA = "0x1803E3340")]
	public HomeAnnounceViewController()
	{
	}
}
