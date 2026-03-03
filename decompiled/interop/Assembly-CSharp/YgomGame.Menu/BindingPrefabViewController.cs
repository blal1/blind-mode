using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using YgomSystem.ElementSystem;
using YgomSystem.UI;

namespace YgomGame.Menu;

[Token(Token = "0x200124C")]
public class BindingPrefabViewController : BaseMenuViewController, IDynamicChangeDispHeaderSupported
{
	[Token(Token = "0x400BB08")]
	private const string k_ArgsPrefPath = "prefPath";

	[Token(Token = "0x400BB09")]
	private const string k_ArgsOnStackEntryCallback = "onStackEntryCallback";

	[Token(Token = "0x400BB0A")]
	private const string k_ArgsOnCreateViewCallback = "onCreateViewCallback";

	[Token(Token = "0x400BB0B")]
	private const string k_ArgsOnStackRemoveCallback = "onStackRemoveCallback";

	[Token(Token = "0x400BB0C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	public HeaderViewController.IsDispHeader headerDispFlags;

	[Token(Token = "0x170011FF")]
	public ElementObjectManager view
	{
		[Token(Token = "0x6007203")]
		[Address(RVA = "0x49BEA0", Offset = "0x49B0A0", VA = "0x18049BEA0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6007204")]
	[Address(RVA = "0x6D4620", Offset = "0x6D3820", VA = "0x1806D4620", Slot = "28")]
	public HeaderViewController.IsDispHeader IsDispContents()
	{
		return default(HeaderViewController.IsDispHeader);
	}

	[Token(Token = "0x6007205")]
	[Address(RVA = "0xB725A0", Offset = "0xB717A0", VA = "0x180B725A0")]
	public static void PushOpen(ViewControllerManager manager, string prefPath, Action<BindingPrefabViewController> onStackEntryCallback, Action<BindingPrefabViewController> onCreateViewCallback, Action<BindingPrefabViewController> onStackRemoveCallback, [Optional] Dictionary<string, object> args)
	{
	}

	[Token(Token = "0x6007206")]
	[Address(RVA = "0xB72300", Offset = "0xB71500", VA = "0x180B72300", Slot = "6")]
	public override void NotificationStackEntry()
	{
	}

	[Token(Token = "0x6007207")]
	[Address(RVA = "0xB72500", Offset = "0xB71700", VA = "0x180B72500", Slot = "23")]
	protected override void OnCreatedView()
	{
	}

	[Token(Token = "0x6007208")]
	[Address(RVA = "0xB72430", Offset = "0xB71630", VA = "0x180B72430", Slot = "7")]
	public override void NotificationStackRemove()
	{
	}

	[Token(Token = "0x6007209")]
	[Address(RVA = "0x3E3340", Offset = "0x3E2540", VA = "0x1803E3340")]
	public BindingPrefabViewController()
	{
	}
}
