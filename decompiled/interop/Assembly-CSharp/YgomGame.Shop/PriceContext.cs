using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using YgomGame.Utility;

namespace YgomGame.Shop;

[Token(Token = "0x2000924")]
public class PriceContext : IComparable<PriceContext>
{
	[Token(Token = "0x40089F3")]
	[FieldOffset(Offset = "0x10")]
	private Dictionary<string, object> m_PriceData;

	[Token(Token = "0x40089F4")]
	[FieldOffset(Offset = "0x18")]
	private string m_PriceKey;

	[Token(Token = "0x40089F5")]
	[FieldOffset(Offset = "0x20")]
	private List<PriceContext> m_AllPrices;

	[Token(Token = "0x40089F6")]
	[FieldOffset(Offset = "0x28")]
	private TextGroupLoadHolder m_TextGroupLoadHolder;

	[Token(Token = "0x1700069E")]
	public string priceKey
	{
		[Token(Token = "0x60036EF")]
		[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700069F")]
	public int sort
	{
		[Token(Token = "0x60036F0")]
		[Address(RVA = "0x7D0600", Offset = "0x7CF800", VA = "0x1807D0600")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x170006A0")]
	public int priceId
	{
		[Token(Token = "0x60036F1")]
		[Address(RVA = "0x7D0580", Offset = "0x7CF780", VA = "0x1807D0580")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x170006A1")]
	public bool hasPaymentId
	{
		[Token(Token = "0x60036F2")]
		[Address(RVA = "0x7D00B0", Offset = "0x7CF2B0", VA = "0x1807D00B0")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170006A2")]
	public int confirmRegId
	{
		[Token(Token = "0x60036F3")]
		[Address(RVA = "0x7CFFA0", Offset = "0x7CF1A0", VA = "0x1807CFFA0")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x170006A3")]
	public bool payItemIsPeriod
	{
		[Token(Token = "0x60036F4")]
		[Address(RVA = "0x7D04C0", Offset = "0x7CF6C0", VA = "0x1807D04C0")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170006A4")]
	public int payItemCategory
	{
		[Token(Token = "0x60036F5")]
		[Address(RVA = "0x7D0370", Offset = "0x7CF570", VA = "0x1807D0370")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x170006A5")]
	public int payItemId
	{
		[Token(Token = "0x60036F6")]
		[Address(RVA = "0x7D0480", Offset = "0x7CF680", VA = "0x1807D0480")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x170006A6")]
	public int payItemHave
	{
		[Token(Token = "0x60036F7")]
		[Address(RVA = "0x7D03B0", Offset = "0x7CF5B0", VA = "0x1807D03B0")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x170006A7")]
	public long limitdateTs
	{
		[Token(Token = "0x60036F8")]
		[Address(RVA = "0x7D0190", Offset = "0x7CF390", VA = "0x1807D0190")]
		get
		{
			return default(long);
		}
	}

	[Token(Token = "0x170006A8")]
	public string limitdate
	{
		[Token(Token = "0x60036F9")]
		[Address(RVA = "0x7D0260", Offset = "0x7CF460", VA = "0x1807D0260")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170006A9")]
	public int priceAmount
	{
		[Token(Token = "0x60036FA")]
		[Address(RVA = "0x7D0500", Offset = "0x7CF700", VA = "0x1807D0500")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x170006AA")]
	public int freeNum
	{
		[Token(Token = "0x60036FB")]
		[Address(RVA = "0x7D0070", Offset = "0x7CF270", VA = "0x1807D0070")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x170006AB")]
	private string overrideConfirmText
	{
		[Token(Token = "0x60036FC")]
		[Address(RVA = "0x7D0330", Offset = "0x7CF530", VA = "0x1807D0330")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170006AC")]
	public bool existsOverrideConfirmText
	{
		[Token(Token = "0x60036FD")]
		[Address(RVA = "0x7D0020", Offset = "0x7CF220", VA = "0x1807D0020")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170006AD")]
	public List<PriceContext> allPrices
	{
		[Token(Token = "0x60036FE")]
		[Address(RVA = "0x3D8370", Offset = "0x3D7570", VA = "0x1803D8370")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170006AE")]
	public bool hasSubPrices
	{
		[Token(Token = "0x60036FF")]
		[Address(RVA = "0x7D0100", Offset = "0x7CF300", VA = "0x1807D0100")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170006AF")]
	public int buyCount
	{
		[Token(Token = "0x6003701")]
		[Address(RVA = "0x7CFEE0", Offset = "0x7CF0E0", VA = "0x1807CFEE0")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x170006B0")]
	public int buttonType
	{
		[Token(Token = "0x6003702")]
		[Address(RVA = "0x7CFEA0", Offset = "0x7CF0A0", VA = "0x1807CFEA0")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x170006B1")]
	public bool isHalfButton
	{
		[Token(Token = "0x6003703")]
		[Address(RVA = "0x7D0150", Offset = "0x7CF350", VA = "0x1807D0150")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170006B2")]
	public string priceButtonIconPath
	{
		[Token(Token = "0x6003704")]
		[Address(RVA = "0x7D0540", Offset = "0x7CF740", VA = "0x1807D0540")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170006B3")]
	public string confirmDialogTitleId
	{
		[Token(Token = "0x6003705")]
		[Address(RVA = "0x7CFF60", Offset = "0x7CF160", VA = "0x1807CFF60")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170006B4")]
	public string confirmDialogMessageId
	{
		[Token(Token = "0x6003706")]
		[Address(RVA = "0x7CFF20", Offset = "0x7CF120", VA = "0x1807CFF20")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170006B5")]
	public string actionScheme
	{
		[Token(Token = "0x6003707")]
		[Address(RVA = "0x7CFE60", Offset = "0x7CF060", VA = "0x1807CFE60")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170006B6")]
	public bool actionInteractable
	{
		[Token(Token = "0x6003708")]
		[Address(RVA = "0x7CFD90", Offset = "0x7CEF90", VA = "0x1807CFD90")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170006B7")]
	public string actionLabel
	{
		[Token(Token = "0x6003709")]
		[Address(RVA = "0x7CFDD0", Offset = "0x7CEFD0", VA = "0x1807CFDD0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170006B8")]
	public string actionArgs
	{
		[Token(Token = "0x600370A")]
		[Address(RVA = "0x7CFD50", Offset = "0x7CEF50", VA = "0x1807CFD50")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170006B9")]
	public string actionSE
	{
		[Token(Token = "0x600370B")]
		[Address(RVA = "0x7CFE10", Offset = "0x7CF010", VA = "0x1807CFE10")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170006BA")]
	public string routeScheme
	{
		[Token(Token = "0x600370C")]
		[Address(RVA = "0x7D05C0", Offset = "0x7CF7C0", VA = "0x1807D05C0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170006BB")]
	public int exchangeId
	{
		[Token(Token = "0x600370D")]
		[Address(RVA = "0x7CFFE0", Offset = "0x7CF1E0", VA = "0x1807CFFE0")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x170006BC")]
	public TextGroupLoadHolder textGroupLoadHolder
	{
		[Token(Token = "0x600370E")]
		[Address(RVA = "0x4030F0", Offset = "0x4022F0", VA = "0x1804030F0")]
		get
		{
			return null;
		}
		[Token(Token = "0x600370F")]
		[Address(RVA = "0x7D0640", Offset = "0x7CF840", VA = "0x1807D0640")]
		set
		{
		}
	}

	[Token(Token = "0x6003700")]
	[Address(RVA = "0x7CF360", Offset = "0x7CE560", VA = "0x1807CF360")]
	public string GetPriceFreeText()
	{
		return null;
	}

	[Token(Token = "0x6003710")]
	[Address(RVA = "0x7CFBE0", Offset = "0x7CEDE0", VA = "0x1807CFBE0")]
	public string MakePriceLabelText(ProductContext productContext)
	{
		return null;
	}

	[Token(Token = "0x6003711")]
	[Address(RVA = "0x7CFB50", Offset = "0x7CED50", VA = "0x1807CFB50")]
	public string MakePopText(TextGroupLoadHolder textGroupLoadHolder)
	{
		return null;
	}

	[Token(Token = "0x6003712")]
	[Address(RVA = "0x7CF9C0", Offset = "0x7CEBC0", VA = "0x1807CF9C0")]
	public string MakeActionLabel(TextGroupLoadHolder textGroupLoadHolder)
	{
		return null;
	}

	[Token(Token = "0x6003713")]
	[Address(RVA = "0x7CFA50", Offset = "0x7CEC50", VA = "0x1807CFA50")]
	public string MakeOverrideConfirmText(ProductContext productContext)
	{
		return null;
	}

	[Token(Token = "0x6003714")]
	[Address(RVA = "0x7CFCD0", Offset = "0x7CEED0", VA = "0x1807CFCD0")]
	public PriceContext()
	{
	}

	[Token(Token = "0x6003715")]
	[Address(RVA = "0x7CF620", Offset = "0x7CE820", VA = "0x1807CF620")]
	public void Import(string priceKey, Dictionary<string, object> priceData)
	{
	}

	[Token(Token = "0x6003716")]
	[Address(RVA = "0x7CF230", Offset = "0x7CE430", VA = "0x1807CF230")]
	public int Compare(PriceContext a, PriceContext b)
	{
		return default(int);
	}

	[Token(Token = "0x6003717")]
	[Address(RVA = "0x7CF100", Offset = "0x7CE300", VA = "0x1807CF100", Slot = "4")]
	public int CompareTo(PriceContext other)
	{
		return default(int);
	}
}
