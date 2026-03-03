using System;
using Il2CppDummyDll;

namespace YgomGame.SubMenu;

[Token(Token = "0x2001043")]
public class HomeSubMenuViewController : SubMenuViewController
{
	[Token(Token = "0x17000F64")]
	protected override Type[] textIds
	{
		[Token(Token = "0x6006282")]
		[Address(RVA = "0xA923F0", Offset = "0xA915F0", VA = "0x180A923F0", Slot = "21")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6006283")]
	[Address(RVA = "0xA8FB50", Offset = "0xA8ED50", VA = "0x180A8FB50", Slot = "6")]
	public override void NotificationStackEntry()
	{
	}

	[Token(Token = "0x6006284")]
	[Address(RVA = "0xA91310", Offset = "0xA90510", VA = "0x180A91310", Slot = "23")]
	protected override void OnCreatedView()
	{
	}

	[Token(Token = "0x6006285")]
	[Address(RVA = "0xA90330", Offset = "0xA8F530", VA = "0x180A90330")]
	public HomeSubMenuViewController()
	{
	}
}
