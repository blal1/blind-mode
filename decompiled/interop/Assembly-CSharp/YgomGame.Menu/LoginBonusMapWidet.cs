using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using YgomGame.Dialog.CommonDialog;
using YgomSystem.ElementSystem;
using YgomSystem.UI.ElementWidget;

namespace YgomGame.Menu;

[Token(Token = "0x2001242")]
public class LoginBonusMapWidet : ElementWidgetBase
{
	[Token(Token = "0x400BAC9")]
	private const string TWLABEL_STARTDIR = "StartDirection";

	[Token(Token = "0x400BACA")]
	private const string k_ELabelSlotGroup = "SlotGroup";

	[Token(Token = "0x400BACB")]
	private const string k_ELabelSlotGroupL = "SlotGroupL";

	[Token(Token = "0x400BACC")]
	private const string k_ELabelSlotTemplate = "SlotTemplate";

	[Token(Token = "0x400BACD")]
	private const string k_ELabelSlotCocatorFormat = "SlotLocator{0:D2}";

	[Token(Token = "0x400BACE")]
	private const string k_ELabelHoldingDate = "TextDate";

	[Token(Token = "0x400BACF")]
	private const string k_ELabelDescription = "TextDescription";

	[Token(Token = "0x400BAD0")]
	private const string k_ELabelTitle = "TextTitle";

	[Token(Token = "0x400BAD5")]
	[FieldOffset(Offset = "0x30")]
	private readonly LoginBonusSlotWidget[] m_SlotWidgets;

	[Token(Token = "0x170011E7")]
	public int progress
	{
		[Token(Token = "0x60071AA")]
		[Address(RVA = "0x4BDC30", Offset = "0x4BCE30", VA = "0x1804BDC30")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60071A9")]
		[Address(RVA = "0x51E0C0", Offset = "0x51D2C0", VA = "0x18051E0C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x170011E8")]
	public int addProgress
	{
		[Token(Token = "0x60071AC")]
		[Address(RVA = "0x416290", Offset = "0x415490", VA = "0x180416290")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60071AB")]
		[Address(RVA = "0x416370", Offset = "0x415570", VA = "0x180416370")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x170011E9")]
	public bool isSentPresentBox
	{
		[Token(Token = "0x60071AE")]
		[Address(RVA = "0x588F60", Offset = "0x588160", VA = "0x180588F60")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60071AD")]
		[Address(RVA = "0x588F70", Offset = "0x588170", VA = "0x180588F70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x170011EA")]
	public bool startDirEnd
	{
		[Token(Token = "0x60071AF")]
		[Address(RVA = "0x62E230", Offset = "0x62D430", VA = "0x18062E230")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60071B0")]
		[Address(RVA = "0x631700", Offset = "0x630900", VA = "0x180631700")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x170011EB")]
	public LoginBonusSlotWidget[] slotWidgets
	{
		[Token(Token = "0x60071B1")]
		[Address(RVA = "0x402CE0", Offset = "0x401EE0", VA = "0x180402CE0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60071B2")]
	[Address(RVA = "0xB78460", Offset = "0xB77660", VA = "0x180B78460")]
	public LoginBonusMapWidet(ElementObjectManager eom, Dictionary<string, object> cwDetailData, LoginBonusViewController.Mode mode)
	{
	}

	[Token(Token = "0x60071B3")]
	[Address(RVA = "0xB77A90", Offset = "0xB76C90", VA = "0x180B77A90")]
	public void Ready()
	{
	}

	[Token(Token = "0x60071B4")]
	[Address(RVA = "0xB783D0", Offset = "0xB775D0", VA = "0x180B783D0")]
	public void Terminate()
	{
	}

	[Token(Token = "0x60071B5")]
	[Address(RVA = "0xB77D00", Offset = "0xB76F00", VA = "0x180B77D00")]
	private void SetData(Dictionary<string, object> source, bool obtaining)
	{
	}

	[Token(Token = "0x60071B6")]
	[Address(RVA = "0xB78290", Offset = "0xB77490", VA = "0x180B78290")]
	public void ShowObtainedItemAndGoToNext(EntryItemListData itemList, List<object> shopInfoList, bool isPresentSent, Action callback)
	{
	}

	[Token(Token = "0x60071B7")]
	[Address(RVA = "0xB77C60", Offset = "0xB76E60", VA = "0x180B77C60")]
	public void SelectSlot()
	{
	}
}
