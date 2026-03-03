using System;
using Il2CppDummyDll;
using YgomGame.Menu;
using YgomSystem.UI;

namespace YgomGame.Tdy;

[Token(Token = "0x2000858")]
public class TdyDuelTransitionViewController : BaseMenuViewController
{
	[Token(Token = "0x4008601")]
	[FieldOffset(Offset = "0xD0")]
	private Action m_OnFinish;

	[Token(Token = "0x4008602")]
	[FieldOffset(Offset = "0x0")]
	private static readonly string k_ArgKeyOnFinish;

	[Token(Token = "0x60032BA")]
	[Address(RVA = "0x755BE0", Offset = "0x754DE0", VA = "0x180755BE0")]
	public static void Open(ViewControllerManager manager, Action onFinish)
	{
	}

	[Token(Token = "0x60032BB")]
	[Address(RVA = "0x755A40", Offset = "0x754C40", VA = "0x180755A40", Slot = "6")]
	public override void NotificationStackEntry()
	{
	}

	[Token(Token = "0x60032BC")]
	[Address(RVA = "0x755B90", Offset = "0x754D90", VA = "0x180755B90", Slot = "25")]
	protected override void OnTransitionEnd(TransitionType type)
	{
	}

	[Token(Token = "0x60032BD")]
	[Address(RVA = "0x3E3340", Offset = "0x3E2540", VA = "0x1803E3340")]
	public TdyDuelTransitionViewController()
	{
	}
}
