using System;
using Il2CppDummyDll;

namespace YgomGame.Menu.TermOfService;

[Token(Token = "0x20013F8")]
public class TermOfServiceViewController : CommonScreenViewController
{
	[Token(Token = "0x400C4B1")]
	[FieldOffset(Offset = "0x118")]
	private string m_url;

	[Token(Token = "0x400C4B2")]
	[FieldOffset(Offset = "0x120")]
	private Action<int> m_resultCallback;

	[Token(Token = "0x400C4B3")]
	[FieldOffset(Offset = "0x128")]
	private UserAgreementType m_type;

	[Token(Token = "0x6007C43")]
	[Address(RVA = "0xC65B40", Offset = "0xC64D40", VA = "0x180C65B40")]
	private void setupButton(string element, string text, Action callback)
	{
	}

	[Token(Token = "0x6007C44")]
	[Address(RVA = "0xC65AC0", Offset = "0xC64CC0", VA = "0x180C65AC0")]
	private void closeButton(string element)
	{
	}

	[Token(Token = "0x6007C45")]
	[Address(RVA = "0xC652B0", Offset = "0xC644B0", VA = "0x180C652B0", Slot = "6")]
	public override void NotificationStackEntry()
	{
	}

	[Token(Token = "0x6007C46")]
	[Address(RVA = "0xC65370", Offset = "0xC64570", VA = "0x180C65370", Slot = "23")]
	protected override void OnCreatedView()
	{
	}

	[Token(Token = "0x6007C47")]
	[Address(RVA = "0xB59690", Offset = "0xB58890", VA = "0x180B59690")]
	private void Start()
	{
	}

	[Token(Token = "0x6007C48")]
	[Address(RVA = "0x543AE0", Offset = "0x542CE0", VA = "0x180543AE0", Slot = "7")]
	public override void NotificationStackRemove()
	{
	}

	[Token(Token = "0x6007C49")]
	[Address(RVA = "0xB513D0", Offset = "0xB505D0", VA = "0x180B513D0")]
	public TermOfServiceViewController()
	{
	}
}
