using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using YgomGame.Menu.Common;
using YgomSystem.ElementSystem;
using YgomSystem.UI;
using YgomSystem.UI.ElementWidget;

namespace YgomGame.GemShop;

[Token(Token = "0x2000DB9")]
public class ProductWidget : ElementWidgetBase
{
	[Token(Token = "0x2000DBA")]
	public class ItemWidget : ElementWidgetBase
	{
		[Token(Token = "0x400A024")]
		[FieldOffset(Offset = "0x20")]
		private readonly string k_ELabelItemNumText;

		[Token(Token = "0x17000BF3")]
		public TMP_Text itemNumText
		{
			[Token(Token = "0x6005263")]
			[Address(RVA = "0x993110", Offset = "0x992310", VA = "0x180993110")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6005264")]
		[Address(RVA = "0x9930B0", Offset = "0x9922B0", VA = "0x1809930B0")]
		public ItemWidget(ElementObjectManager eom)
		{
		}
	}

	[Token(Token = "0x400A00F")]
	[FieldOffset(Offset = "0x20")]
	private readonly string k_ELabelProductName;

	[Token(Token = "0x400A010")]
	[FieldOffset(Offset = "0x28")]
	private readonly string k_ELabelPriceLabel;

	[Token(Token = "0x400A011")]
	[FieldOffset(Offset = "0x30")]
	private readonly string k_ELabelDoubleNotationPriceGroup;

	[Token(Token = "0x400A012")]
	[FieldOffset(Offset = "0x38")]
	private readonly string k_ELabelDoubleNotationPriceLabel;

	[Token(Token = "0x400A013")]
	[FieldOffset(Offset = "0x40")]
	private readonly string k_ELabelGemShopIcon;

	[Token(Token = "0x400A014")]
	[FieldOffset(Offset = "0x48")]
	private readonly string k_ELabelPaidGemItem;

	[Token(Token = "0x400A015")]
	[FieldOffset(Offset = "0x50")]
	private readonly string k_ELabelFreeGemItem;

	[Token(Token = "0x400A016")]
	[FieldOffset(Offset = "0x58")]
	private readonly string k_ELabelLimitRoot;

	[Token(Token = "0x400A017")]
	[FieldOffset(Offset = "0x60")]
	private readonly string k_ELabelLimitText;

	[Token(Token = "0x400A018")]
	[FieldOffset(Offset = "0x68")]
	private readonly string k_ELabelLimitDateRoot;

	[Token(Token = "0x400A019")]
	[FieldOffset(Offset = "0x70")]
	private readonly string k_ELabelLimitDateText;

	[Token(Token = "0x400A01A")]
	[FieldOffset(Offset = "0x78")]
	private readonly string k_ELabelPopIconRoot;

	[Token(Token = "0x400A01B")]
	[FieldOffset(Offset = "0x80")]
	private readonly string k_ELabelPopIconLabel;

	[Token(Token = "0x400A01C")]
	[FieldOffset(Offset = "0x88")]
	private readonly string k_ELabelButton;

	[Token(Token = "0x400A01D")]
	[FieldOffset(Offset = "0x90")]
	private readonly string k_ELabelTweenDefault;

	[Token(Token = "0x400A01E")]
	[FieldOffset(Offset = "0x98")]
	private readonly string k_ELabelTweenHighlight;

	[Token(Token = "0x400A01F")]
	[FieldOffset(Offset = "0xA0")]
	private readonly string k_TLabel_PopIn;

	[Token(Token = "0x400A020")]
	[FieldOffset(Offset = "0xA8")]
	private readonly string k_TLabel_PopOut;

	[Token(Token = "0x400A021")]
	[FieldOffset(Offset = "0xB0")]
	private Dictionary<int, ItemWidget> m_ItemWidgetMap;

	[Token(Token = "0x400A022")]
	[FieldOffset(Offset = "0xB8")]
	public int idx;

	[Token(Token = "0x400A023")]
	[FieldOffset(Offset = "0xC0")]
	public Action<ProductWidget> onClickCallback;

	[Token(Token = "0x17000BE6")]
	public TMP_Text productName
	{
		[Token(Token = "0x6005251")]
		[Address(RVA = "0x9959A0", Offset = "0x994BA0", VA = "0x1809959A0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000BE7")]
	public TMP_Text priceLabel
	{
		[Token(Token = "0x6005252")]
		[Address(RVA = "0x995950", Offset = "0x994B50", VA = "0x180995950")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000BE8")]
	public GameObject doubleNotationPriceGroup
	{
		[Token(Token = "0x6005253")]
		[Address(RVA = "0x995700", Offset = "0x994900", VA = "0x180995700")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000BE9")]
	public TMP_Text doubleNotationPriceLabel
	{
		[Token(Token = "0x6005254")]
		[Address(RVA = "0x995730", Offset = "0x994930", VA = "0x180995730")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000BEA")]
	public BindingGemShopIcon gemShopIcon
	{
		[Token(Token = "0x6005255")]
		[Address(RVA = "0x995780", Offset = "0x994980", VA = "0x180995780")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000BEB")]
	public GameObject limitCountRoot
	{
		[Token(Token = "0x6005256")]
		[Address(RVA = "0x9957D0", Offset = "0x9949D0", VA = "0x1809957D0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000BEC")]
	public TMP_Text limitCountText
	{
		[Token(Token = "0x6005257")]
		[Address(RVA = "0x995800", Offset = "0x994A00", VA = "0x180995800")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000BED")]
	public GameObject limitDateRoot
	{
		[Token(Token = "0x6005258")]
		[Address(RVA = "0x995850", Offset = "0x994A50", VA = "0x180995850")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000BEE")]
	public TMP_Text limitDateText
	{
		[Token(Token = "0x6005259")]
		[Address(RVA = "0x995880", Offset = "0x994A80", VA = "0x180995880")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000BEF")]
	public GameObject popIconRoot
	{
		[Token(Token = "0x600525A")]
		[Address(RVA = "0x995920", Offset = "0x994B20", VA = "0x180995920")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000BF0")]
	public TMP_Text popIconLabel
	{
		[Token(Token = "0x600525B")]
		[Address(RVA = "0x9958D0", Offset = "0x994AD0", VA = "0x1809958D0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000BF1")]
	public SelectionButton button
	{
		[Token(Token = "0x600525C")]
		[Address(RVA = "0x9956B0", Offset = "0x9948B0", VA = "0x1809956B0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000BF2")]
	public IReadOnlyDictionary<int, ItemWidget> itemWidgetMap
	{
		[Token(Token = "0x600525D")]
		[Address(RVA = "0x49BB20", Offset = "0x49AD20", VA = "0x18049BB20")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600525E")]
	[Address(RVA = "0x995140", Offset = "0x994340", VA = "0x180995140")]
	public ProductWidget(ElementObjectManager eom)
	{
	}

	[Token(Token = "0x600525F")]
	[Address(RVA = "0x995090", Offset = "0x994290", VA = "0x180995090")]
	public void SetStyle(ProductStyle productStyle)
	{
	}

	[Token(Token = "0x6005260")]
	[Address(RVA = "0x994F80", Offset = "0x994180", VA = "0x180994F80")]
	private void OnClick()
	{
	}

	[Token(Token = "0x6005261")]
	[Address(RVA = "0x994E90", Offset = "0x994090", VA = "0x180994E90")]
	public void InitPopIcon(bool isIn)
	{
	}

	[Token(Token = "0x6005262")]
	[Address(RVA = "0x994FA0", Offset = "0x9941A0", VA = "0x180994FA0")]
	public void PlayPopIcon(bool isIn)
	{
	}
}
