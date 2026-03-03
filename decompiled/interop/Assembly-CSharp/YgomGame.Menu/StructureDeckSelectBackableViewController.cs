using Il2CppDummyDll;

namespace YgomGame.Menu;

[Token(Token = "0x2001385")]
public class StructureDeckSelectBackableViewController : StructureDeckSelectViewController, IBackButtonSupported, IHeaderBorderSupported
{
	[Token(Token = "0x6007930")]
	[Address(RVA = "0xC24A90", Offset = "0xC23C90", VA = "0x180C24A90")]
	public static void Open()
	{
	}

	[Token(Token = "0x6007931")]
	[Address(RVA = "0xC249F0", Offset = "0xC23BF0", VA = "0x180C249F0", Slot = "6")]
	public override void NotificationStackEntry()
	{
	}

	[Token(Token = "0x6007932")]
	[Address(RVA = "0xC24A80", Offset = "0xC23C80", VA = "0x180C24A80", Slot = "28")]
	protected override void OnSelectedDeck(int structureDeckId)
	{
	}

	[Token(Token = "0x6007933")]
	[Address(RVA = "0xC24C80", Offset = "0xC23E80", VA = "0x180C24C80")]
	public StructureDeckSelectBackableViewController()
	{
	}
}
