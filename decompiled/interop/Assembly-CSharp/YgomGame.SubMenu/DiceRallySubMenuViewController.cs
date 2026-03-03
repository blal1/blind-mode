using System;
using Il2CppDummyDll;
using YgomGame.Colosseum;

namespace YgomGame.SubMenu;

[Token(Token = "0x2001042")]
public class DiceRallySubMenuViewController : SubMenuViewController
{
	[Token(Token = "0x400ADA1")]
	[FieldOffset(Offset = "0x178")]
	private readonly string KEY_ITEMDIC_LABEL;

	[Token(Token = "0x400ADA2")]
	[FieldOffset(Offset = "0x180")]
	private readonly string KEY_COLOSSEUM_DIALOG_MANAGER;

	[Token(Token = "0x400ADA3")]
	[FieldOffset(Offset = "0x188")]
	private readonly string BTN_MASK_LABEL;

	[Token(Token = "0x400ADA4")]
	[FieldOffset(Offset = "0x190")]
	private ColosseumDialogMangaer dialogManager;

	[Token(Token = "0x17000F63")]
	protected override Type[] textIds
	{
		[Token(Token = "0x600627D")]
		[Address(RVA = "0xA90950", Offset = "0xA8FB50", VA = "0x180A90950", Slot = "21")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600627E")]
	[Address(RVA = "0xA8FB50", Offset = "0xA8ED50", VA = "0x180A8FB50", Slot = "6")]
	public override void NotificationStackEntry()
	{
	}

	[Token(Token = "0x600627F")]
	[Address(RVA = "0xA90480", Offset = "0xA8F680", VA = "0x180A90480", Slot = "23")]
	protected override void OnCreatedView()
	{
	}

	[Token(Token = "0x6006280")]
	[Address(RVA = "0xA908A0", Offset = "0xA8FAA0", VA = "0x180A908A0")]
	public DiceRallySubMenuViewController()
	{
	}
}
