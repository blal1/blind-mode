using System;
using Il2CppDummyDll;
using UnityEngine;

namespace YgomGame.Shop;

[Serializable]
[Token(Token = "0x2000932")]
public class ShopInformButtonData
{
	[Token(Token = "0x2000933")]
	public enum Behaviour
	{
		[Token(Token = "0x4008A2B")]
		OpenHelp,
		[Token(Token = "0x4008A2C")]
		OpenCardPackRateList,
		[Token(Token = "0x4008A2D")]
		OpenCardNormalPoolList,
		[Token(Token = "0x4008A2E")]
		OpenCardPickupList,
		[Token(Token = "0x4008A2F")]
		OpenStructureDeckBrowser,
		[Token(Token = "0x4008A30")]
		OpenItemViewer,
		[Token(Token = "0x4008A31")]
		OpenDuelPassRewardList,
		[Token(Token = "0x4008A32")]
		OpenHelpSwitchDx,
		[Token(Token = "0x4008A33")]
		OpenHelpSwitchPackType,
		[Token(Token = "0x4008A34")]
		OpenItemPreview,
		[Token(Token = "0x4008A35")]
		OpenPrizeList,
		[Token(Token = "0x4008A36")]
		OpenPrizeResult,
		[Token(Token = "0x4008A37")]
		OpenCardStandardPackRateList,
		[Token(Token = "0x4008A38")]
		OpenMMA,
		[Token(Token = "0x4008A39")]
		OpenMMASwitchDx,
		[Token(Token = "0x4008A3A")]
		OpenMMASwitchPackType,
		[Token(Token = "0x4008A3B")]
		OpenCardFile,
		[Token(Token = "0x4008A3C")]
		OpenPrizeItemResult,
		[Token(Token = "0x4008A3D")]
		OpenCardPoolList,
		[Token(Token = "0x4008A3E")]
		OpenCardExchangePoolList
	}

	[Token(Token = "0x2000934")]
	public enum BehaviourParamFormtData
	{
		[Token(Token = "0x4008A40")]
		ShopId = 10,
		[Token(Token = "0x4008A41")]
		PackId
	}

	[Token(Token = "0x2000935")]
	public enum ButtonStyle
	{
		[Token(Token = "0x4008A43")]
		Normal,
		[Token(Token = "0x4008A44")]
		Highlight_1,
		[Token(Token = "0x4008A45")]
		Highlight_2
	}

	[Token(Token = "0x2000936")]
	public enum FormatData
	{
		[Token(Token = "0x4008A47")]
		ProductName = 1,
		[Token(Token = "0x4008A48")]
		ProductSubLabel,
		[Token(Token = "0x4008A49")]
		ProductViewer
	}

	[Token(Token = "0x4008A1F")]
	[FieldOffset(Offset = "0x10")]
	[SerializeField]
	private string m_Label;

	[Token(Token = "0x4008A20")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private Behaviour m_Behaviour;

	[Token(Token = "0x4008A21")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private string[] m_BehaviourParams;

	[Token(Token = "0x4008A22")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private BehaviourParamFormtData[] m_BehaviourFormatDatas;

	[Token(Token = "0x4008A23")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private bool m_TryOpenShopDetail;

	[Token(Token = "0x4008A24")]
	[FieldOffset(Offset = "0x34")]
	[SerializeField]
	private ButtonStyle m_ButtonStyle;

	[Token(Token = "0x4008A25")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private bool m_ForceShrink;

	[Token(Token = "0x4008A26")]
	[FieldOffset(Offset = "0x39")]
	[SerializeField]
	private bool m_TryShrinkOnMobile;

	[Token(Token = "0x4008A27")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	private string m_LabelTextId;

	[Token(Token = "0x4008A28")]
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	private FormatData[] m_LabelFormatDatas;

	[Token(Token = "0x4008A29")]
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	private bool m_SkipOnBlockPurchase;

	[Token(Token = "0x17000727")]
	public string label
	{
		[Token(Token = "0x60037B7")]
		[Address(RVA = "0x40C440", Offset = "0x40B640", VA = "0x18040C440")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000728")]
	public Behaviour behaviour
	{
		[Token(Token = "0x60037B9")]
		[Address(RVA = "0x5C7C60", Offset = "0x5C6E60", VA = "0x1805C7C60")]
		get
		{
			return default(Behaviour);
		}
		[Token(Token = "0x60037B8")]
		[Address(RVA = "0x615AB0", Offset = "0x614CB0", VA = "0x180615AB0")]
		set
		{
		}
	}

	[Token(Token = "0x17000729")]
	public string[] behaviourParams
	{
		[Token(Token = "0x60037BA")]
		[Address(RVA = "0x3D8370", Offset = "0x3D7570", VA = "0x1803D8370")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700072A")]
	public BehaviourParamFormtData[] behaviourFormatDatas
	{
		[Token(Token = "0x60037BB")]
		[Address(RVA = "0x4030F0", Offset = "0x4022F0", VA = "0x1804030F0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700072B")]
	public bool tryOpenShopDetail
	{
		[Token(Token = "0x60037BC")]
		[Address(RVA = "0x51FEA0", Offset = "0x51F0A0", VA = "0x18051FEA0")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700072C")]
	public ButtonStyle buttonStyle
	{
		[Token(Token = "0x60037BD")]
		[Address(RVA = "0x6333C0", Offset = "0x6325C0", VA = "0x1806333C0")]
		get
		{
			return default(ButtonStyle);
		}
	}

	[Token(Token = "0x1700072D")]
	public ButtonStyle tryShrinkButtonStyle
	{
		[Token(Token = "0x60037BE")]
		[Address(RVA = "0x7DBD70", Offset = "0x7DAF70", VA = "0x1807DBD70")]
		get
		{
			return default(ButtonStyle);
		}
	}

	[Token(Token = "0x1700072E")]
	public bool tryShrink
	{
		[Token(Token = "0x60037BF")]
		[Address(RVA = "0x7DBDD0", Offset = "0x7DAFD0", VA = "0x1807DBDD0")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700072F")]
	public string labelTextId
	{
		[Token(Token = "0x60037C0")]
		[Address(RVA = "0x404850", Offset = "0x403A50", VA = "0x180404850")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000730")]
	public FormatData[] labelFormatDatas
	{
		[Token(Token = "0x60037C1")]
		[Address(RVA = "0x414E80", Offset = "0x414080", VA = "0x180414E80")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000731")]
	public bool skipOnBlockPurchase
	{
		[Token(Token = "0x60037C2")]
		[Address(RVA = "0x3E1DE0", Offset = "0x3E0FE0", VA = "0x1803E1DE0")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x60037C3")]
	[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
	public ShopInformButtonData()
	{
	}

	[Token(Token = "0x60037C4")]
	[Address(RVA = "0x7DBD30", Offset = "0x7DAF30", VA = "0x1807DBD30")]
	public ShopInformButtonData(ShopInformButtonData source)
	{
	}
}
