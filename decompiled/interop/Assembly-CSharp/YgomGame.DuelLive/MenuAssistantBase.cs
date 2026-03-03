using Il2CppDummyDll;
using YgomSystem.UI;

namespace YgomGame.DuelLive;

[Token(Token = "0x2000F55")]
public abstract class MenuAssistantBase
{
	[Token(Token = "0x2000F56")]
	public enum CustomFocusResult
	{
		[Token(Token = "0x400A784")]
		Finished,
		[Token(Token = "0x400A785")]
		Continued,
		[Token(Token = "0x400A786")]
		FallThrough
	}

	[Token(Token = "0x400A781")]
	[FieldOffset(Offset = "0x10")]
	public int menuID;

	[Token(Token = "0x400A782")]
	[FieldOffset(Offset = "0x18")]
	protected ProductListWidget owner;

	[Token(Token = "0x6005D28")]
	[Address(RVA = "0x500960", Offset = "0x4FFB60", VA = "0x180500960")]
	public MenuAssistantBase(int menuID, ProductListWidget owner)
	{
	}

	[Token(Token = "0x6005D29")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "4")]
	public virtual void MakeTemplateLayout(ProductListWidget.Context dstCtx, ProductContextCollection<DuelLiveProductContext> productContexts, object param)
	{
	}

	[Token(Token = "0x6005D2A")]
	[Address(RVA = "0x44E380", Offset = "0x44D580", VA = "0x18044E380", Slot = "5")]
	public virtual CustomFocusResult ModifyFocus(int dataIndex, bool isInitializeSelect)
	{
		return default(CustomFocusResult);
	}

	[Token(Token = "0x6005D2B")]
	[Address(RVA = "0xA201C0", Offset = "0xA1F3C0", VA = "0x180A201C0", Slot = "6")]
	public virtual bool ModifyContentPos(int dataIndex, out float modifiedPos)
	{
		return default(bool);
	}

	[Token(Token = "0x6005D2C")]
	[Address(RVA = "0x3C7A70", Offset = "0x3C6C70", VA = "0x1803C7A70", Slot = "7")]
	public virtual bool CustomInnerTransition(SelectionItem item, PadInputDirection dir)
	{
		return default(bool);
	}

	[Token(Token = "0x6005D2D")]
	[Address(RVA = "0xA20160", Offset = "0xA1F360", VA = "0x180A20160", Slot = "8")]
	public virtual string GetNoDataMessageText()
	{
		return null;
	}

	[Token(Token = "0x6005D2E")]
	[Address(RVA = "0x3C7A70", Offset = "0x3C6C70", VA = "0x1803C7A70", Slot = "9")]
	public virtual bool CustomPadInputDirection(PadInputDirection dir)
	{
		return default(bool);
	}

	[Token(Token = "0x6005D2F")]
	[Address(RVA = "0xA1F470", Offset = "0xA1E670", VA = "0x180A1F470")]
	public bool CustomPadInputDirectionUpDown(PadInputDirection dir)
	{
		return default(bool);
	}
}
