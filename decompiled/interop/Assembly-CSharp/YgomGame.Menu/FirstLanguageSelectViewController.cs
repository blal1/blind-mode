using Il2CppDummyDll;

namespace YgomGame.Menu;

[Token(Token = "0x2001224")]
public class FirstLanguageSelectViewController : BaseMenuViewController
{
	[Token(Token = "0x400BA4A")]
	[FieldOffset(Offset = "0xD0")]
	private int m_step;

	[Token(Token = "0x400BA4B")]
	[FieldOffset(Offset = "0xD4")]
	private bool m_langChanged;

	[Token(Token = "0x600710D")]
	[Address(RVA = "0xB746D0", Offset = "0xB738D0", VA = "0x180B746D0", Slot = "6")]
	public override void NotificationStackEntry()
	{
	}

	[Token(Token = "0x600710E")]
	[Address(RVA = "0xB748E0", Offset = "0xB73AE0", VA = "0x180B748E0")]
	private void Update()
	{
	}

	[Token(Token = "0x600710F")]
	[Address(RVA = "0xB70F20", Offset = "0xB70120", VA = "0x180B70F20", Slot = "7")]
	public override void NotificationStackRemove()
	{
	}

	[Token(Token = "0x6007110")]
	[Address(RVA = "0x3E3340", Offset = "0x3E2540", VA = "0x1803E3340")]
	public FirstLanguageSelectViewController()
	{
	}
}
