using System;
using System.Diagnostics;
using Il2CppDummyDll;
using YgomGame.Compliance;

namespace YgomGame.Menu;

[Token(Token = "0x200119B")]
public class GemShopApprovalViewController : BaseMenuViewController, IBackButtonSupported, IHeaderBorderSupported
{
	[Token(Token = "0x400B82A")]
	[FieldOffset(Offset = "0xD0")]
	private ApprovalView m_approvalView;

	[Token(Token = "0x400B82B")]
	[FieldOffset(Offset = "0xD8")]
	private bool m_approved;

	[Token(Token = "0x400B82C")]
	[FieldOffset(Offset = "0xE0")]
	private Action<bool> m_resultCallback;

	[Token(Token = "0x6006E92")]
	[Address(RVA = "0xB5F9D0", Offset = "0xB5EBD0", VA = "0x180B5F9D0", Slot = "6")]
	public override void NotificationStackEntry()
	{
	}

	[Token(Token = "0x6006E93")]
	[Address(RVA = "0xB5FAE0", Offset = "0xB5ECE0", VA = "0x180B5FAE0", Slot = "23")]
	protected override void OnCreatedView()
	{
	}

	[Token(Token = "0x6006E94")]
	[Address(RVA = "0xB5FC60", Offset = "0xB5EE60", VA = "0x180B5FC60")]
	private void Start()
	{
	}

	[Token(Token = "0x6006E95")]
	[Address(RVA = "0xB5FCB0", Offset = "0xB5EEB0", VA = "0x180B5FCB0")]
	private void Update()
	{
	}

	[Token(Token = "0x6006E96")]
	[Address(RVA = "0xB5FAD0", Offset = "0xB5ECD0", VA = "0x180B5FAD0", Slot = "13")]
	public override bool OnBack()
	{
		return default(bool);
	}

	[Token(Token = "0x6006E97")]
	[Address(RVA = "0xB5FA50", Offset = "0xB5EC50", VA = "0x180B5FA50", Slot = "7")]
	public override void NotificationStackRemove()
	{
	}

	[Token(Token = "0x6006E98")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60")]
	[Conditional("YGO_DEBUG")]
	private static void debugLog(string str)
	{
	}

	[Token(Token = "0x6006E99")]
	[Address(RVA = "0x3E3340", Offset = "0x3E2540", VA = "0x1803E3340")]
	public GemShopApprovalViewController()
	{
	}
}
