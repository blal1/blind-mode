using Il2CppDummyDll;
using YgomGame.Dialog.CommonDialog;
using YgomSystem.ElementSystem;

namespace YgomGame.Deck;

[Token(Token = "0x200108F")]
public class ConfirmCraftCPWidget : ContentWidgetBase<ConfirmCraftCPWidget, EntryInsertWidgetData>
{
	[Token(Token = "0x6006598")]
	[Address(RVA = "0xABC1B0", Offset = "0xABB3B0", VA = "0x180ABC1B0")]
	public static ConfirmCraftCPWidget Create(ElementObjectManager eom, int rarityID, int beforeCP, int afterCP)
	{
		return null;
	}

	[Token(Token = "0x6006599")]
	[Address(RVA = "0xABC350", Offset = "0xABB550", VA = "0x180ABC350", Slot = "24")]
	protected override void InnerBinding(EntryInsertWidgetData entryData)
	{
	}

	[Token(Token = "0x600659A")]
	[Address(RVA = "0xABC3D0", Offset = "0xABB5D0", VA = "0x180ABC3D0")]
	public ConfirmCraftCPWidget()
	{
	}
}
