using System.Collections.Generic;
using Il2CppDummyDll;
using YgomSystem.UI;

namespace YgomGame.DuelLive;

[Token(Token = "0x2000F58")]
public class CardPackMenuAssistant : MenuAssistantBase
{
	[Token(Token = "0x2000F59")]
	public class CardPackSection
	{
		[Token(Token = "0x2000F5A")]
		public enum IndexPosition
		{
			[Token(Token = "0x400A78E")]
			OutOfRange = -1,
			[Token(Token = "0x400A78F")]
			Header,
			[Token(Token = "0x400A790")]
			Container
		}

		[Token(Token = "0x400A788")]
		[FieldOffset(Offset = "0x10")]
		public string nameText;

		[Token(Token = "0x400A789")]
		[FieldOffset(Offset = "0x18")]
		public int dataIndexOffset;

		[Token(Token = "0x400A78A")]
		[FieldOffset(Offset = "0x1C")]
		public int replayContainerCount;

		[Token(Token = "0x400A78B")]
		[FieldOffset(Offset = "0x20")]
		public bool hasShopButton;

		[Token(Token = "0x400A78C")]
		[FieldOffset(Offset = "0x21")]
		public bool hasHeader;

		[Token(Token = "0x17000EAC")]
		public int dataLength
		{
			[Token(Token = "0x6005D3A")]
			[Address(RVA = "0xA194A0", Offset = "0xA186A0", VA = "0x180A194A0")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x6005D3B")]
		[Address(RVA = "0xA19460", Offset = "0xA18660", VA = "0x180A19460")]
		public IndexPosition GetPosition(int dataIndex)
		{
			return default(IndexPosition);
		}

		[Token(Token = "0x6005D3C")]
		[Address(RVA = "0x5C7C60", Offset = "0x5C6E60", VA = "0x1805C7C60")]
		public int GetContainerTopDataIndex()
		{
			return default(int);
		}

		[Token(Token = "0x6005D3D")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public CardPackSection()
		{
		}
	}

	[Token(Token = "0x400A787")]
	[FieldOffset(Offset = "0x20")]
	public List<CardPackSection> sections;

	[Token(Token = "0x6005D33")]
	[Address(RVA = "0xA191D0", Offset = "0xA183D0", VA = "0x180A191D0")]
	public CardPackMenuAssistant(int menuID, ProductListWidget owner)
	{
	}

	[Token(Token = "0x6005D34")]
	[Address(RVA = "0xA188C0", Offset = "0xA17AC0", VA = "0x180A188C0")]
	public void AddSection(CardPackSection section)
	{
	}

	[Token(Token = "0x6005D35")]
	[Address(RVA = "0xA19280", Offset = "0xA18480", VA = "0x180A19280")]
	private (CardPackSection, CardPackSection.IndexPosition) findSection(int dataIndex)
	{
		return default((CardPackSection, CardPackSection.IndexPosition));
	}

	[Token(Token = "0x6005D36")]
	[Address(RVA = "0xA18F40", Offset = "0xA18140", VA = "0x180A18F40", Slot = "5")]
	public override CustomFocusResult ModifyFocus(int dataIndex, bool isInitializeSelect)
	{
		return default(CustomFocusResult);
	}

	[Token(Token = "0x6005D37")]
	[Address(RVA = "0xA18970", Offset = "0xA17B70", VA = "0x180A18970", Slot = "7")]
	public override bool CustomInnerTransition(SelectionItem item, PadInputDirection dir)
	{
		return default(bool);
	}

	[Token(Token = "0x6005D38")]
	[Address(RVA = "0xA18E40", Offset = "0xA18040", VA = "0x180A18E40", Slot = "6")]
	public override bool ModifyContentPos(int dataIndex, out float modifiedPos)
	{
		return default(bool);
	}

	[Token(Token = "0x6005D39")]
	[Address(RVA = "0xA18B30", Offset = "0xA17D30", VA = "0x180A18B30", Slot = "9")]
	public override bool CustomPadInputDirection(PadInputDirection dir)
	{
		return default(bool);
	}
}
