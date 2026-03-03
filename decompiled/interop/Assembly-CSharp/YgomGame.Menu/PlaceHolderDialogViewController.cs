using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using YgomSystem.UI;

namespace YgomGame.Menu;

[Token(Token = "0x20012FF")]
public class PlaceHolderDialogViewController : BaseMenuViewController, IBokeSupported
{
	[Token(Token = "0x400BEA8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	private ViewController m_Owner;

	[Token(Token = "0x60075FE")]
	[Address(RVA = "0xBC5480", Offset = "0xBC4680", VA = "0x180BC5480")]
	public static PlaceHolderDialogViewController PushOpen(ViewController owner, [Optional] Dictionary<string, object> args)
	{
		return null;
	}

	[Token(Token = "0x60075FF")]
	[Address(RVA = "0xBC4FF0", Offset = "0xBC41F0", VA = "0x180BC4FF0", Slot = "6")]
	public override void NotificationStackEntry()
	{
	}

	[Token(Token = "0x6007600")]
	[Address(RVA = "0xBC5340", Offset = "0xBC4540", VA = "0x180BC5340", Slot = "15")]
	public override void OnFocusChanged(bool setfocus)
	{
	}

	[Token(Token = "0x6007601")]
	[Address(RVA = "0xBC52A0", Offset = "0xBC44A0", VA = "0x180BC52A0")]
	private void OnContentTransition(TransitionType transitionType, ViewController hideVc, ViewController showVc)
	{
	}

	[Token(Token = "0x6007602")]
	[Address(RVA = "0xBC50A0", Offset = "0xBC42A0", VA = "0x180BC50A0", Slot = "7")]
	public override void NotificationStackRemove()
	{
	}

	[Token(Token = "0x6007603")]
	[Address(RVA = "0xBC5200", Offset = "0xBC4400", VA = "0x180BC5200", Slot = "13")]
	public override bool OnBack()
	{
		return default(bool);
	}

	[Token(Token = "0x6007604")]
	[Address(RVA = "0x3E3340", Offset = "0x3E2540", VA = "0x1803E3340")]
	public PlaceHolderDialogViewController()
	{
	}
}
