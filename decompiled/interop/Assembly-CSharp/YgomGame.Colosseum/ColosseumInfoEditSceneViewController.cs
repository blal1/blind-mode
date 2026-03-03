using Il2CppDummyDll;
using YgomGame.Menu;
using YgomSystem.UI;

namespace YgomGame.Colosseum;

[Token(Token = "0x2001BAD")]
public class ColosseumInfoEditSceneViewController : ColosseumInfoViewController, IBackButtonSupported, IHeaderBorderSupported
{
	[Token(Token = "0x600B44E")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "8")]
	public override void NotificationStack(ViewControllerManager vcm, ViewController vc, bool isEntry)
	{
	}

	[Token(Token = "0x600B44F")]
	[Address(RVA = "0x4BF0B0", Offset = "0x4BE2B0", VA = "0x1804BF0B0", Slot = "23")]
	protected override void OnCreatedView()
	{
	}

	[Token(Token = "0x600B450")]
	[Address(RVA = "0x4BF300", Offset = "0x4BE500", VA = "0x1804BF300")]
	public ColosseumInfoEditSceneViewController()
	{
	}
}
