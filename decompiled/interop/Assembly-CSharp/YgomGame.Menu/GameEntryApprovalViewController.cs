using System;
using System.Diagnostics;
using Il2CppDummyDll;
using YgomGame.Compliance;

namespace YgomGame.Menu;

[Token(Token = "0x20011AD")]
public class GameEntryApprovalViewController : CommonScreenViewController
{
	[Token(Token = "0x400B883")]
	[FieldOffset(Offset = "0x118")]
	private ApprovalView m_approvalView;

	[Token(Token = "0x400B884")]
	[FieldOffset(Offset = "0x120")]
	private Action<bool> m_resultCallback;

	[Token(Token = "0x6006EED")]
	[Address(RVA = "0xB5C600", Offset = "0xB5B800", VA = "0x180B5C600", Slot = "6")]
	public override void NotificationStackEntry()
	{
	}

	[Token(Token = "0x6006EEE")]
	[Address(RVA = "0xB5C740", Offset = "0xB5B940", VA = "0x180B5C740", Slot = "23")]
	protected override void OnCreatedView()
	{
	}

	[Token(Token = "0x6006EEF")]
	[Address(RVA = "0xB5C9A0", Offset = "0xB5BBA0", VA = "0x180B5C9A0")]
	private void Start()
	{
	}

	[Token(Token = "0x6006EF0")]
	[Address(RVA = "0xB5CA70", Offset = "0xB5BC70", VA = "0x180B5CA70")]
	private void Update()
	{
	}

	[Token(Token = "0x6006EF1")]
	[Address(RVA = "0xB5C6F0", Offset = "0xB5B8F0", VA = "0x180B5C6F0", Slot = "7")]
	public override void NotificationStackRemove()
	{
	}

	[Token(Token = "0x6006EF2")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60")]
	[Conditional("ENABLE_DEBUGLOG")]
	private static void debugLog(string str)
	{
	}

	[Token(Token = "0x6006EF3")]
	[Address(RVA = "0x3E3340", Offset = "0x3E2540", VA = "0x1803E3340")]
	public GameEntryApprovalViewController()
	{
	}
}
