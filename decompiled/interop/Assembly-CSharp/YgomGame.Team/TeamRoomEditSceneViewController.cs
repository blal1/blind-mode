using Il2CppDummyDll;
using YgomGame.Menu;
using YgomSystem.UI;

namespace YgomGame.Team;

[Token(Token = "0x2001641")]
public class TeamRoomEditSceneViewController : TeamRoomViewController, IBackButtonSupported, IHeaderBorderSupported
{
	[Token(Token = "0x6008A6C")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "8")]
	public override void NotificationStack(ViewControllerManager vcm, ViewController vc, bool isEntry)
	{
	}

	[Token(Token = "0x6008A6D")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "23")]
	protected override void OnCreatedView()
	{
	}

	[Token(Token = "0x6008A6E")]
	[Address(RVA = "0xB513D0", Offset = "0xB505D0", VA = "0x180B513D0")]
	public TeamRoomEditSceneViewController()
	{
	}
}
