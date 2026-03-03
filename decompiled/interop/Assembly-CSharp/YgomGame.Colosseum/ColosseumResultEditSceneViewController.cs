using Il2CppDummyDll;
using YgomGame.Menu;
using YgomSystem.UI;

namespace YgomGame.Colosseum;

[Token(Token = "0x2001BB0")]
public class ColosseumResultEditSceneViewController : ColosseumInfoViewController, IBackButtonSupported, IHeaderBorderSupported
{
	[Token(Token = "0x600B456")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "8")]
	public override void NotificationStack(ViewControllerManager vcm, ViewController vc, bool isEntry)
	{
	}

	[Token(Token = "0x600B457")]
	[Address(RVA = "0x4C3040", Offset = "0x4C2240", VA = "0x1804C3040", Slot = "23")]
	protected override void OnCreatedView()
	{
	}

	[Token(Token = "0x600B458")]
	[Address(RVA = "0x4C2A10", Offset = "0x4C1C10", VA = "0x1804C2A10")]
	private void OnClickDecideButton()
	{
	}

	[Token(Token = "0x600B459")]
	[Address(RVA = "0x4C2BA0", Offset = "0x4C1DA0", VA = "0x1804C2BA0")]
	private void OnClickDeckButton()
	{
	}

	[Token(Token = "0x600B45A")]
	[Address(RVA = "0x4C2EC0", Offset = "0x4C20C0", VA = "0x1804C2EC0")]
	private void OnClickMenuButton()
	{
	}

	[Token(Token = "0x600B45B")]
	[Address(RVA = "0x4C2D30", Offset = "0x4C1F30", VA = "0x1804C2D30")]
	private void OnClickHighlightButton()
	{
	}

	[Token(Token = "0x600B45C")]
	[Address(RVA = "0x4BF300", Offset = "0x4BE500", VA = "0x1804BF300")]
	public ColosseumResultEditSceneViewController()
	{
	}
}
