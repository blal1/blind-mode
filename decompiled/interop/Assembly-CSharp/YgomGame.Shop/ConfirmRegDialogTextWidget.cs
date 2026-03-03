using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using YgomGame.Dialog.CommonDialog;
using YgomGame.Utility;
using YgomSystem.ElementSystem;

namespace YgomGame.Shop;

[Token(Token = "0x200098D")]
public class ConfirmRegDialogTextWidget : ContentWidgetBase<ConfirmRegDialogTextWidget, EntryInsertWidgetData>, IContentWidgetDirectionalInputListener
{
	[Token(Token = "0x4008C92")]
	public const string k_FormatProductName = "product_name";

	[Token(Token = "0x4008C93")]
	public const string k_FormatProductNumPaidGem = "product_num_paid_gem";

	[Token(Token = "0x4008C94")]
	public const string k_FormatProductNumFreeGem = "product_num_free_gem";

	[Token(Token = "0x4008C95")]
	public const string k_FormatProductNum = "product_num";

	[Token(Token = "0x4008C96")]
	public const string k_FormatProductPrice = "price";

	[Token(Token = "0x4008C97")]
	public const string k_FormatProductDoubleNotationPrice = "doubleNotationPrice";

	[Token(Token = "0x4008C98")]
	public const string k_FormatProductPriceLabel = "price_label";

	[Token(Token = "0x4008C99")]
	public const string k_FormatProductLimitdateTs = "limitdate_ts";

	[Token(Token = "0x4008C9A")]
	public const string k_FormatProductLimitdate = "limitdate";

	[Token(Token = "0x4008C9B")]
	public const string k_FormatProductLimitBuyCount = "limit_buy_count";

	[Token(Token = "0x4008C9C")]
	public const string k_FormatProductTypeName = "product_type_name";

	[Token(Token = "0x4008C9D")]
	public const string k_FormatProductExchangeCardName = "exchange_card_name";

	[Token(Token = "0x4008C9E")]
	public const string k_FormatProductExchangeCardNameWithCnt = "exchange_card_name_with_cnt";

	[Token(Token = "0x4008C9F")]
	public const string k_FormatProductExchangeItemName = "exchange_item_name";

	[Token(Token = "0x4008CA0")]
	public const string k_FormatProductExchangeItemNameWithCnt = "exchange_item_name_with_cnt";

	[Token(Token = "0x4008CA1")]
	[FieldOffset(Offset = "0x30")]
	private ScrollRect m_ScrollRect;

	[Token(Token = "0x4008CA2")]
	[FieldOffset(Offset = "0x38")]
	private ElementObjectManager m_HeaderGroupTemplate;

	[Token(Token = "0x4008CA3")]
	[FieldOffset(Offset = "0x40")]
	private ElementObjectManager m_TextTemplate;

	[Token(Token = "0x4008CA4")]
	[FieldOffset(Offset = "0x48")]
	private List<object> m_FormatParamSearcher;

	[Token(Token = "0x6003A69")]
	[Address(RVA = "0x810510", Offset = "0x80F710", VA = "0x180810510")]
	public static ConfirmRegDialogTextWidget Create(ElementObjectManager eom)
	{
		return null;
	}

	[Token(Token = "0x6003A6A")]
	[Address(RVA = "0x810390", Offset = "0x80F590", VA = "0x180810390", Slot = "17")]
	protected override void CollectComponents()
	{
	}

	[Token(Token = "0x6003A6B")]
	[Address(RVA = "0x810BA0", Offset = "0x80FDA0", VA = "0x180810BA0")]
	public void InsertContents(List<object> confirmRegDatas, TextGroupLoadHolder textGruopLoadHolder, Func<string, object> paramFormatFunc)
	{
	}

	[Token(Token = "0x6003A6C")]
	[Address(RVA = "0x810570", Offset = "0x80F770", VA = "0x180810570", Slot = "24")]
	protected override void InnerBinding(EntryInsertWidgetData entryData)
	{
	}

	[Token(Token = "0x6003A6D")]
	[Address(RVA = "0x810D80", Offset = "0x80FF80", VA = "0x180810D80")]
	private void InsertHeader(Dictionary<string, object> line)
	{
	}

	[Token(Token = "0x6003A6E")]
	[Address(RVA = "0x8105D0", Offset = "0x80F7D0", VA = "0x1808105D0")]
	private void InsertBody(Dictionary<string, object> line, TextGroupLoadHolder textGruopLoadHolder, Func<string, object> paramFormatFunc)
	{
	}

	[Token(Token = "0x6003A6F")]
	[Address(RVA = "0x810F20", Offset = "0x810120", VA = "0x180810F20", Slot = "25")]
	public void OnMainAnalogInput(Vector2 dir)
	{
	}

	[Token(Token = "0x6003A70")]
	[Address(RVA = "0x810F20", Offset = "0x810120", VA = "0x180810F20", Slot = "26")]
	public void OnSubAnalogInput(Vector2 dir)
	{
	}

	[Token(Token = "0x6003A71")]
	[Address(RVA = "0x810F10", Offset = "0x810110", VA = "0x180810F10", Slot = "27")]
	public void OnLeftInput()
	{
	}

	[Token(Token = "0x6003A72")]
	[Address(RVA = "0x810F30", Offset = "0x810130", VA = "0x180810F30", Slot = "28")]
	public void OnRightInput()
	{
	}

	[Token(Token = "0x6003A73")]
	[Address(RVA = "0x810F40", Offset = "0x810140", VA = "0x180810F40", Slot = "29")]
	public void OnUpInput()
	{
	}

	[Token(Token = "0x6003A74")]
	[Address(RVA = "0x810F00", Offset = "0x810100", VA = "0x180810F00", Slot = "30")]
	public void OnDownInput()
	{
	}

	[Token(Token = "0x6003A75")]
	[Address(RVA = "0x810F50", Offset = "0x810150", VA = "0x180810F50")]
	public ConfirmRegDialogTextWidget()
	{
	}
}
