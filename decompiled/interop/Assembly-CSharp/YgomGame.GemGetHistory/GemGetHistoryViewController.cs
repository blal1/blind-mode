using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using YgomGame.GetHistory;
using YgomGame.Menu;
using YgomSystem.ElementSystem;

namespace YgomGame.GemGetHistory;

[Token(Token = "0x2000DBB")]
public class GemGetHistoryViewController : GetHistoryViewController, IBackButtonSupported, IHeaderBorderSupported
{
	[Token(Token = "0x400A025")]
	[FieldOffset(Offset = "0x1E8")]
	private readonly string TEXT_GETDATE_LABEL;

	[Token(Token = "0x400A026")]
	[FieldOffset(Offset = "0x1F0")]
	private readonly string TEXT_NUM_LABEL;

	[Token(Token = "0x400A027")]
	[FieldOffset(Offset = "0x1F8")]
	private readonly string TEXT_LIMITDATE_LABEL;

	[Token(Token = "0x400A028")]
	[FieldOffset(Offset = "0x200")]
	private readonly string TEXT_UNUSEDGEM_LABEL;

	[Token(Token = "0x400A029")]
	[FieldOffset(Offset = "0x208")]
	private readonly string TEXT_CONSDATE_LABEL;

	[Token(Token = "0x400A02A")]
	[FieldOffset(Offset = "0x210")]
	private readonly string TEXT_COLLECTDATE_LABEL;

	[Token(Token = "0x400A02B")]
	[FieldOffset(Offset = "0x218")]
	private readonly string TEXT_PAIDNUM_LABEL;

	[Token(Token = "0x400A02C")]
	[FieldOffset(Offset = "0x220")]
	private readonly string TEXT_FREENUM_LABEL;

	[Token(Token = "0x400A02D")]
	[FieldOffset(Offset = "0x228")]
	private readonly string TEXT_DESC_LABEL;

	[Token(Token = "0x400A02E")]
	[FieldOffset(Offset = "0x230")]
	private readonly string KEY_PAGEMAX;

	[Token(Token = "0x400A02F")]
	[FieldOffset(Offset = "0x238")]
	private readonly string KEY_ISJP;

	[Token(Token = "0x400A030")]
	[FieldOffset(Offset = "0x240")]
	private readonly string KEY_NEXT_EXPIREDATE;

	[Token(Token = "0x400A031")]
	[FieldOffset(Offset = "0x248")]
	private readonly string KEY_NEXT_EXPIREPOINT;

	[Token(Token = "0x400A032")]
	[FieldOffset(Offset = "0x250")]
	private readonly string KEY_HISTORY;

	[Token(Token = "0x400A033")]
	[FieldOffset(Offset = "0x258")]
	private readonly string KEY_FREE_POINT_LIMIT;

	[Token(Token = "0x400A034")]
	[FieldOffset(Offset = "0x260")]
	private readonly string KEY_ORDERDATE;

	[Token(Token = "0x400A035")]
	[FieldOffset(Offset = "0x268")]
	private readonly string KEY_EXPIREDATE;

	[Token(Token = "0x400A036")]
	[FieldOffset(Offset = "0x270")]
	private readonly string KEY_ORDERTYPE_ID;

	[Token(Token = "0x400A037")]
	[FieldOffset(Offset = "0x278")]
	private readonly string KEY_PAID_POINT;

	[Token(Token = "0x400A038")]
	[FieldOffset(Offset = "0x280")]
	private readonly string KEY_FREE_POINT;

	[Token(Token = "0x400A039")]
	[FieldOffset(Offset = "0x288")]
	private readonly string KEY_UNUSED_PAID_POINT;

	[Token(Token = "0x400A03A")]
	[FieldOffset(Offset = "0x290")]
	private readonly string KEY_ORDERTYPE_ADD;

	[Token(Token = "0x400A03B")]
	[FieldOffset(Offset = "0x298")]
	private readonly string KEY_ORDERTYPE_CONSUME;

	[Token(Token = "0x400A03C")]
	[FieldOffset(Offset = "0x2A0")]
	private readonly string KEY_ORDERTYPE_EXPIRE;

	[Token(Token = "0x400A03D")]
	[FieldOffset(Offset = "0x2A8")]
	private readonly string KEY_ORDERTYPE_COLLECT;

	[Token(Token = "0x400A03E")]
	[FieldOffset(Offset = "0x2B0")]
	private List<ElementObjectManager> m_templateEOMList;

	[Token(Token = "0x400A03F")]
	[FieldOffset(Offset = "0x2B8")]
	private List<object> m_historyList;

	[Token(Token = "0x400A040")]
	[FieldOffset(Offset = "0x2C0")]
	private int m_haveFreeNum;

	[Token(Token = "0x400A041")]
	[FieldOffset(Offset = "0x2C4")]
	private int m_havePaidNum;

	[Token(Token = "0x400A042")]
	[FieldOffset(Offset = "0x2C8")]
	private int maxPosFreeNum;

	[Token(Token = "0x400A043")]
	private const int maxPosPaidNum = 499999;

	[Token(Token = "0x400A044")]
	[FieldOffset(Offset = "0x2D0")]
	private readonly string PATH_BILLINGHISTORY;

	[Token(Token = "0x17000BF4")]
	protected override Type[] textIds
	{
		[Token(Token = "0x6005265")]
		[Address(RVA = "0x9895F0", Offset = "0x9887F0", VA = "0x1809895F0", Slot = "21")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6005266")]
	[Address(RVA = "0x986F10", Offset = "0x986110", VA = "0x180986F10", Slot = "23")]
	protected override void OnCreatedView()
	{
	}

	[Token(Token = "0x6005267")]
	[Address(RVA = "0x3E4080", Offset = "0x3E3280", VA = "0x1803E4080", Slot = "6")]
	public override void NotificationStackEntry()
	{
	}

	[Token(Token = "0x6005268")]
	[Address(RVA = "0x9872F0", Offset = "0x9864F0", VA = "0x1809872F0")]
	private void SetFirstView()
	{
	}

	[Token(Token = "0x6005269")]
	[Address(RVA = "0x988550", Offset = "0x987750", VA = "0x180988550")]
	private void SetTemplateCons(Dictionary<string, object> dict)
	{
	}

	[Token(Token = "0x600526A")]
	[Address(RVA = "0x987C00", Offset = "0x986E00", VA = "0x180987C00")]
	private void SetTemplateAdd(Dictionary<string, object> dict)
	{
	}

	[Token(Token = "0x600526B")]
	[Address(RVA = "0x988930", Offset = "0x987B30", VA = "0x180988930")]
	private void SetTemplateExpire(Dictionary<string, object> dict)
	{
	}

	[Token(Token = "0x600526C")]
	[Address(RVA = "0x988170", Offset = "0x987370", VA = "0x180988170")]
	private void SetTemplateCollect(Dictionary<string, object> dict)
	{
	}

	[Token(Token = "0x600526D")]
	[Address(RVA = "0x988CF0", Offset = "0x987EF0", VA = "0x180988CF0")]
	private string ToAlertStyle(string text)
	{
		return null;
	}

	[Token(Token = "0x600526E")]
	[Address(RVA = "0x986D70", Offset = "0x985F70", VA = "0x180986D70")]
	private void ClearTemplates()
	{
	}

	[Token(Token = "0x600526F")]
	[Address(RVA = "0x988EF0", Offset = "0x9880F0", VA = "0x180988EF0")]
	private void UpdatePage()
	{
	}

	[Token(Token = "0x6005270")]
	[Address(RVA = "0x986D50", Offset = "0x985F50", VA = "0x180986D50")]
	private void ButtonRCallBack()
	{
	}

	[Token(Token = "0x6005271")]
	[Address(RVA = "0x986D30", Offset = "0x985F30", VA = "0x180986D30")]
	private void ButtonLCallBack()
	{
	}

	[Token(Token = "0x6005272")]
	[Address(RVA = "0x987080", Offset = "0x986280", VA = "0x180987080")]
	private void SetAllTemplates()
	{
	}

	[Token(Token = "0x6005273")]
	[Address(RVA = "0x9890D0", Offset = "0x9882D0", VA = "0x1809890D0")]
	public GemGetHistoryViewController()
	{
	}
}
