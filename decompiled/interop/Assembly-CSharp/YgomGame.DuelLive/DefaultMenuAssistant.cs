using Il2CppDummyDll;
using YgomSystem.UI;

namespace YgomGame.DuelLive;

[Token(Token = "0x2000F57")]
public class DefaultMenuAssistant : MenuAssistantBase
{
	[Token(Token = "0x6005D30")]
	[Address(RVA = "0x500960", Offset = "0x4FFB60", VA = "0x180500960")]
	public DefaultMenuAssistant(int menuID, ProductListWidget owner)
	{
	}

	[Token(Token = "0x6005D31")]
	[Address(RVA = "0xA1AD70", Offset = "0xA19F70", VA = "0x180A1AD70", Slot = "5")]
	public override CustomFocusResult ModifyFocus(int dataIndex, bool isInitializeSelect)
	{
		return default(CustomFocusResult);
	}

	[Token(Token = "0x6005D32")]
	[Address(RVA = "0xA1AB60", Offset = "0xA19D60", VA = "0x180A1AB60", Slot = "9")]
	public override bool CustomPadInputDirection(PadInputDirection dir)
	{
		return default(bool);
	}
}
