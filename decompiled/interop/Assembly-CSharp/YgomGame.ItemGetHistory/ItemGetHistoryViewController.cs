using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using YgomGame.GetHistory;
using YgomGame.Menu;
using YgomSystem.ElementSystem;

namespace YgomGame.ItemGetHistory;

[Token(Token = "0x2000D3A")]
public class ItemGetHistoryViewController : GetHistoryViewController, IBackButtonSupported, IHeaderBorderSupported
{
	[Token(Token = "0x4009E24")]
	[FieldOffset(Offset = "0x1E8")]
	private readonly string TEXT_GETDATE_LABEL;

	[Token(Token = "0x4009E25")]
	[FieldOffset(Offset = "0x1F0")]
	private readonly string TEXT_ITEMNAME_LABEL;

	[Token(Token = "0x4009E26")]
	[FieldOffset(Offset = "0x1F8")]
	private readonly string TEXT_GETREASON_LABEL;

	[Token(Token = "0x4009E27")]
	[FieldOffset(Offset = "0x200")]
	private readonly string TEXT_LIMITDATE_LABEL;

	[Token(Token = "0x4009E28")]
	[FieldOffset(Offset = "0x208")]
	private readonly string KEY_ITEM_ID;

	[Token(Token = "0x4009E29")]
	[FieldOffset(Offset = "0x210")]
	private readonly string KEY_REASON;

	[Token(Token = "0x4009E2A")]
	[FieldOffset(Offset = "0x218")]
	private readonly string KEY_CATEGORY;

	[Token(Token = "0x4009E2B")]
	[FieldOffset(Offset = "0x220")]
	private readonly string KEY_GETDATE;

	[Token(Token = "0x4009E2C")]
	[FieldOffset(Offset = "0x228")]
	private readonly string KEY_LIMITDATE;

	[Token(Token = "0x4009E2D")]
	[FieldOffset(Offset = "0x230")]
	private readonly string KEY_NUM;

	[Token(Token = "0x4009E2E")]
	[FieldOffset(Offset = "0x238")]
	private readonly string KEY_PERIODITEMFLAG;

	[Token(Token = "0x4009E2F")]
	[FieldOffset(Offset = "0x240")]
	private List<object> m_itemGetHistory;

	[Token(Token = "0x4009E30")]
	[FieldOffset(Offset = "0x248")]
	private List<ElementObjectManager> m_templateEOMList;

	[Token(Token = "0x17000B88")]
	protected override Type[] textIds
	{
		[Token(Token = "0x600500B")]
		[Address(RVA = "0x9710B0", Offset = "0x9702B0", VA = "0x1809710B0", Slot = "21")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600500C")]
	[Address(RVA = "0x9701C0", Offset = "0x96F3C0", VA = "0x1809701C0", Slot = "23")]
	protected override void OnCreatedView()
	{
	}

	[Token(Token = "0x600500D")]
	[Address(RVA = "0x3E4080", Offset = "0x3E3280", VA = "0x1803E4080", Slot = "6")]
	public override void NotificationStackEntry()
	{
	}

	[Token(Token = "0x600500E")]
	[Address(RVA = "0x9702D0", Offset = "0x96F4D0", VA = "0x1809702D0")]
	public void SetTemplate(Dictionary<string, object> dict)
	{
	}

	[Token(Token = "0x600500F")]
	[Address(RVA = "0x96FD50", Offset = "0x96EF50", VA = "0x18096FD50")]
	private void ClearTemplates()
	{
	}

	[Token(Token = "0x6005010")]
	[Address(RVA = "0x970D30", Offset = "0x96FF30", VA = "0x180970D30")]
	private void UpdatePage()
	{
	}

	[Token(Token = "0x6005011")]
	[Address(RVA = "0x96FD30", Offset = "0x96EF30", VA = "0x18096FD30")]
	private void ButtonRCallBack()
	{
	}

	[Token(Token = "0x6005012")]
	[Address(RVA = "0x96FD10", Offset = "0x96EF10", VA = "0x18096FD10")]
	private void ButtonLCallBack()
	{
	}

	[Token(Token = "0x6005013")]
	[Address(RVA = "0x96FEF0", Offset = "0x96F0F0", VA = "0x18096FEF0")]
	private string GetGetReasonText(int getreason)
	{
		return null;
	}

	[Token(Token = "0x6005014")]
	[Address(RVA = "0x970090", Offset = "0x96F290", VA = "0x180970090")]
	private string GetItemNameWithCategory(bool isPeriod, int category, int itemId)
	{
		return null;
	}

	[Token(Token = "0x6005015")]
	[Address(RVA = "0x970E40", Offset = "0x970040", VA = "0x180970E40")]
	public ItemGetHistoryViewController()
	{
	}
}
