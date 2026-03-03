using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using YgomSystem.ElementSystem;
using YgomSystem.UI;
using YgomSystem.UI.ElementWidget;

namespace YgomGame.Shop;

[Token(Token = "0x2000966")]
public class ProductWidget : ElementWidgetBase
{
	[Token(Token = "0x4008B50")]
	[FieldOffset(Offset = "0x20")]
	private readonly string k_ELabelHeadIconText;

	[Token(Token = "0x4008B51")]
	[FieldOffset(Offset = "0x28")]
	private readonly string k_ELabelHeadSpCpIconImage;

	[Token(Token = "0x4008B52")]
	[FieldOffset(Offset = "0x30")]
	private readonly string k_ELabelDeluxBadge;

	[Token(Token = "0x4008B53")]
	internal const string k_TLabelStyleNormal = "Style_Normal";

	[Token(Token = "0x4008B54")]
	internal const string k_TLabelStyleHighlight = "Style_Highlight";

	[Token(Token = "0x4008B55")]
	private const string k_TLabelLimitAlert_OFF = "LimitAlert_OFF";

	[Token(Token = "0x4008B56")]
	private const string k_TLabelLimitAlert_ON = "LimitAlert_ON";

	[Token(Token = "0x4008B57")]
	[FieldOffset(Offset = "0x38")]
	public int index;

	[Token(Token = "0x4008B58")]
	[FieldOffset(Offset = "0x40")]
	public ProductContext productContext;

	[Token(Token = "0x4008B59")]
	[FieldOffset(Offset = "0x48")]
	public readonly string widgetLabel;

	[Token(Token = "0x4008B5A")]
	[FieldOffset(Offset = "0x50")]
	public readonly SelectionButton button;

	[Token(Token = "0x4008B5B")]
	[FieldOffset(Offset = "0x58")]
	public readonly GameObject badge;

	[Token(Token = "0x4008B5C")]
	[FieldOffset(Offset = "0x60")]
	public readonly GameObject newGroup;

	[Token(Token = "0x4008B5D")]
	[FieldOffset(Offset = "0x68")]
	public readonly GameObject dxBadge;

	[Token(Token = "0x4008B5E")]
	[FieldOffset(Offset = "0x70")]
	public readonly GameObject spCpGroup;

	[Token(Token = "0x4008B5F")]
	[FieldOffset(Offset = "0x78")]
	public readonly GameObject baseLower;

	[Token(Token = "0x4008B60")]
	[FieldOffset(Offset = "0x80")]
	public readonly TMP_Text pickupNameText;

	[Token(Token = "0x4008B61")]
	[FieldOffset(Offset = "0x88")]
	public readonly TMP_Text nameText;

	[Token(Token = "0x4008B62")]
	[FieldOffset(Offset = "0x90")]
	public readonly GameObject priceRoot;

	[Token(Token = "0x4008B63")]
	[FieldOffset(Offset = "0x98")]
	public readonly GameObject priceGroup;

	[Token(Token = "0x4008B64")]
	[FieldOffset(Offset = "0xA0")]
	public readonly GameObject priceBGDefault;

	[Token(Token = "0x4008B65")]
	[FieldOffset(Offset = "0xA8")]
	public readonly GameObject priceBGHighlight;

	[Token(Token = "0x4008B66")]
	[FieldOffset(Offset = "0xB0")]
	public readonly Image priceButtonIcon;

	[Token(Token = "0x4008B67")]
	[FieldOffset(Offset = "0xB8")]
	public readonly TMP_Text priceText;

	[Token(Token = "0x4008B68")]
	[FieldOffset(Offset = "0xC0")]
	public readonly TMP_Text priceLabelText;

	[Token(Token = "0x4008B69")]
	[FieldOffset(Offset = "0xC8")]
	public readonly TMP_Text priceFreeText;

	[Token(Token = "0x4008B6A")]
	[FieldOffset(Offset = "0xD0")]
	public readonly TMP_Text priceFreeLabelText;

	[Token(Token = "0x4008B6B")]
	[FieldOffset(Offset = "0xD8")]
	public readonly GameObject priceTimeLimitIcon;

	[Token(Token = "0x4008B6C")]
	[FieldOffset(Offset = "0xE0")]
	public readonly GameObject ownedGroup;

	[Token(Token = "0x4008B6D")]
	[FieldOffset(Offset = "0xE8")]
	public readonly RectTransform thumbHolder;

	[Token(Token = "0x4008B6E")]
	[FieldOffset(Offset = "0xF0")]
	public readonly ParticleAlphaGroup thumbHolderParticleAlphaGroup;

	[Token(Token = "0x4008B6F")]
	[FieldOffset(Offset = "0xF8")]
	public readonly GameObject grayoutCover;

	[Token(Token = "0x4008B70")]
	[FieldOffset(Offset = "0x100")]
	public readonly GameObject limitGroup;

	[Token(Token = "0x4008B71")]
	[FieldOffset(Offset = "0x108")]
	public readonly TMP_Text limitRemainText;

	[Token(Token = "0x4008B72")]
	[FieldOffset(Offset = "0x110")]
	public readonly TMP_Text limitDateText;

	[Token(Token = "0x4008B73")]
	[FieldOffset(Offset = "0x118")]
	public readonly GameObject numGroup;

	[Token(Token = "0x4008B74")]
	[FieldOffset(Offset = "0x120")]
	public readonly TMP_Text numText;

	[Token(Token = "0x4008B75")]
	[FieldOffset(Offset = "0x128")]
	public readonly TMP_Text descText;

	[Token(Token = "0x4008B76")]
	[FieldOffset(Offset = "0x130")]
	public readonly GameObject packPickupMessageGroup;

	[Token(Token = "0x4008B77")]
	[FieldOffset(Offset = "0x138")]
	public readonly TMP_Text packPickupMessage;

	[Token(Token = "0x4008B78")]
	[FieldOffset(Offset = "0x140")]
	private readonly UIEntityDuplicator m_PriceIconDuplicator;

	[Token(Token = "0x4008B79")]
	[FieldOffset(Offset = "0x148")]
	private List<Tween> tweens;

	[Token(Token = "0x4008B7A")]
	[FieldOffset(Offset = "0x150")]
	public Action<ProductWidget> onClickCallback;

	[Token(Token = "0x4008B7B")]
	[FieldOffset(Offset = "0x158")]
	public Action<ProductWidget> onSelectedCallback;

	[Token(Token = "0x4008B7C")]
	[FieldOffset(Offset = "0x160")]
	private PriceContext m_PriceCtx;

	[Token(Token = "0x1700077E")]
	public int shopId
	{
		[Token(Token = "0x6003949")]
		[Address(RVA = "0x7F4050", Offset = "0x7F3250", VA = "0x1807F4050")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x1700077F")]
	public bool isMarketProduct
	{
		[Token(Token = "0x600394A")]
		[Address(RVA = "0x7F3FA0", Offset = "0x7F31A0", VA = "0x1807F3FA0")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000780")]
	public bool marketUnlocked
	{
		[Token(Token = "0x600394B")]
		[Address(RVA = "0x7F3FE0", Offset = "0x7F31E0", VA = "0x1807F3FE0")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000781")]
	public int marketSlotIdx
	{
		[Token(Token = "0x600394C")]
		[Address(RVA = "0x7F3FC0", Offset = "0x7F31C0", VA = "0x1807F3FC0")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000782")]
	public TMP_Text newLabel
	{
		[Token(Token = "0x600394D")]
		[Address(RVA = "0x7F4000", Offset = "0x7F3200", VA = "0x1807F4000")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000783")]
	public Image spCpIconImage
	{
		[Token(Token = "0x600394E")]
		[Address(RVA = "0x7F4070", Offset = "0x7F3270", VA = "0x1807F4070")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600394F")]
	[Address(RVA = "0x7F3680", Offset = "0x7F2880", VA = "0x1807F3680")]
	public ProductWidget(string widgetLabel, ElementObjectManager eom)
	{
	}

	[Token(Token = "0x6003950")]
	[Address(RVA = "0x7F3600", Offset = "0x7F2800", VA = "0x1807F3600")]
	public void SetPriceIcons(PriceContext priceCtx)
	{
	}

	[Token(Token = "0x6003951")]
	[Address(RVA = "0x7F3060", Offset = "0x7F2260", VA = "0x1807F3060")]
	private void OnUpdatePriceIcon(GameObject icon, int idx)
	{
	}

	[Token(Token = "0x6003952")]
	[Address(RVA = "0x7F3500", Offset = "0x7F2700", VA = "0x1807F3500")]
	public void SetLimitAlertStyle(bool isAlertOn)
	{
	}

	[Token(Token = "0x6003953")]
	[Address(RVA = "0x7F3180", Offset = "0x7F2380", VA = "0x1807F3180")]
	public void PlayStyleTween(string label)
	{
	}

	[Token(Token = "0x6003954")]
	[Address(RVA = "0x7F3020", Offset = "0x7F2220", VA = "0x1807F3020")]
	protected void OnClick()
	{
	}

	[Token(Token = "0x6003955")]
	[Address(RVA = "0x7F3040", Offset = "0x7F2240", VA = "0x1807F3040")]
	protected void OnSelected()
	{
	}

	[Token(Token = "0x6003956")]
	[Address(RVA = "0x7F3470", Offset = "0x7F2670", VA = "0x1807F3470")]
	public void ReleaseResources()
	{
	}
}
