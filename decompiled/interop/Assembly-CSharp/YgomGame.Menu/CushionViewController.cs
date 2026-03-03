using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using YgomSystem.UI;

namespace YgomGame.Menu;

[Token(Token = "0x20013E2")]
public class CushionViewController : BaseMenuViewController
{
	[Token(Token = "0x400C43F")]
	public const string PREFAB_PATH = "Utility/CushionView";

	[Token(Token = "0x400C440")]
	public const string k_ArgsKeyRootView = "RootView";

	[Token(Token = "0x400C441")]
	public const string k_ArgsKeyPushAction = "PushAction";

	[Token(Token = "0x400C442")]
	public const string k_ArgsKeyPopAction = "PopAction";

	[Token(Token = "0x400C443")]
	[FieldOffset(Offset = "0xD0")]
	private ViewController m_RootView;

	[Token(Token = "0x400C444")]
	[FieldOffset(Offset = "0xD8")]
	private Action m_PushAction;

	[Token(Token = "0x400C445")]
	[FieldOffset(Offset = "0xE0")]
	private Action m_PopAction;

	[Token(Token = "0x6007BB0")]
	[Address(RVA = "0xC3E570", Offset = "0xC3D770", VA = "0x180C3E570")]
	public static void Open(ViewController rootView, Action pushAction, Action popAction)
	{
	}

	[Token(Token = "0x6007BB1")]
	[Address(RVA = "0xC3E500", Offset = "0xC3D700", VA = "0x180C3E500")]
	public static void Open(Dictionary<string, object> args)
	{
	}

	[Token(Token = "0x6007BB2")]
	[Address(RVA = "0x3E4080", Offset = "0x3E3280", VA = "0x1803E4080", Slot = "6")]
	public override void NotificationStackEntry()
	{
	}

	[Token(Token = "0x6007BB3")]
	[Address(RVA = "0xC3E240", Offset = "0xC3D440", VA = "0x180C3E240", Slot = "23")]
	protected override void OnCreatedView()
	{
	}

	[Token(Token = "0x6007BB4")]
	[Address(RVA = "0xC3E0C0", Offset = "0xC3D2C0", VA = "0x180C3E0C0", Slot = "8")]
	public override void NotificationStack(ViewControllerManager vcm, ViewController vc, bool isEntry)
	{
	}

	[Token(Token = "0x6007BB5")]
	[Address(RVA = "0x3E3340", Offset = "0x3E2540", VA = "0x1803E3340")]
	public CushionViewController()
	{
	}
}
