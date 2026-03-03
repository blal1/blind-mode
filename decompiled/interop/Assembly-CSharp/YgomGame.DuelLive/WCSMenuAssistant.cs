using Il2CppDummyDll;
using YgomSystem.UI;

namespace YgomGame.DuelLive;

[Token(Token = "0x2000F5B")]
public class WCSMenuAssistant : MenuAssistantBase
{
	[Token(Token = "0x6005D3E")]
	[Address(RVA = "0x500960", Offset = "0x4FFB60", VA = "0x180500960")]
	public WCSMenuAssistant(int menuID, ProductListWidget owner)
	{
	}

	[Token(Token = "0x6005D3F")]
	[Address(RVA = "0xA2EC40", Offset = "0xA2DE40", VA = "0x180A2EC40", Slot = "8")]
	public override string GetNoDataMessageText()
	{
		return null;
	}

	[Token(Token = "0x6005D40")]
	[Address(RVA = "0xA2ECA0", Offset = "0xA2DEA0", VA = "0x180A2ECA0", Slot = "4")]
	public override void MakeTemplateLayout(ProductListWidget.Context dstCtx, ProductContextCollection<DuelLiveProductContext> productContexts, object param)
	{
	}

	[Token(Token = "0x6005D41")]
	[Address(RVA = "0xA2E980", Offset = "0xA2DB80", VA = "0x180A2E980", Slot = "7")]
	public override bool CustomInnerTransition(SelectionItem item, PadInputDirection dir)
	{
		return default(bool);
	}

	[Token(Token = "0x6005D42")]
	[Address(RVA = "0xA2ED60", Offset = "0xA2DF60", VA = "0x180A2ED60", Slot = "5")]
	public override CustomFocusResult ModifyFocus(int dataIndex, bool isInitializeSelect)
	{
		return default(CustomFocusResult);
	}

	[Token(Token = "0x6005D43")]
	[Address(RVA = "0xA2E990", Offset = "0xA2DB90", VA = "0x180A2E990", Slot = "9")]
	public override bool CustomPadInputDirection(PadInputDirection dir)
	{
		return default(bool);
	}

	[Token(Token = "0x6005D44")]
	[Address(RVA = "0xA2F010", Offset = "0xA2E210", VA = "0x180A2F010")]
	private void makeTemplateLayoutWCS(ProductListWidget.Context dstCtx, ProductContextCollection<DuelLiveProductContext> productContexts, DuelLiveWCSData wcsData)
	{
	}

	[Token(Token = "0x6005D45")]
	[Address(RVA = "0xA2FE20", Offset = "0xA2F020", VA = "0x180A2FE20")]
	private void putEmptyBlock(ProductListWidget.Context dstCtx)
	{
	}
}
