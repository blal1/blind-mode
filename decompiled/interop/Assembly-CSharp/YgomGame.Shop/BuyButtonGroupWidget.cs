using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using YgomGame.Utility;
using YgomSystem.ElementSystem;
using YgomSystem.UI;
using YgomSystem.UI.ElementWidget;

namespace YgomGame.Shop;

[Token(Token = "0x2000985")]
public class BuyButtonGroupWidget : ElementWidgetBase
{
	[Token(Token = "0x2000986")]
	public class ButtonContext
	{
		[Token(Token = "0x4008C63")]
		[FieldOffset(Offset = "0x10")]
		public string buttonIconPath;

		[Token(Token = "0x4008C64")]
		[FieldOffset(Offset = "0x18")]
		public bool limitedIconVisible;

		[Token(Token = "0x4008C65")]
		[FieldOffset(Offset = "0x20")]
		public string numText;

		[Token(Token = "0x4008C66")]
		[FieldOffset(Offset = "0x28")]
		public bool paidIconVisible;

		[Token(Token = "0x4008C67")]
		[FieldOffset(Offset = "0x30")]
		public IReadOnlyList<PriceContext> payItemPriceContexts;

		[Token(Token = "0x4008C68")]
		[FieldOffset(Offset = "0x38")]
		public string priceText;

		[Token(Token = "0x4008C69")]
		[FieldOffset(Offset = "0x40")]
		public string actionLabel;

		[Token(Token = "0x4008C6A")]
		[FieldOffset(Offset = "0x48")]
		public bool actionInteractable;

		[Token(Token = "0x4008C6B")]
		[FieldOffset(Offset = "0x50")]
		public string infoText;

		[Token(Token = "0x6003A40")]
		[Address(RVA = "0x80C790", Offset = "0x80B990", VA = "0x18080C790")]
		public ButtonContext()
		{
		}

		[Token(Token = "0x6003A41")]
		[Address(RVA = "0x80C710", Offset = "0x80B910", VA = "0x18080C710")]
		public void Clear()
		{
		}
	}

	[Token(Token = "0x2000987")]
	public interface IButtonWidget
	{
		[Token(Token = "0x17000799")]
		GameObject gameObject
		{
			[Token(Token = "0x6003A42")]
			get;
		}

		[Token(Token = "0x1700079A")]
		SelectionButton button
		{
			[Token(Token = "0x6003A43")]
			get;
		}

		[Token(Token = "0x1700079B")]
		int xPos
		{
			[Token(Token = "0x6003A44")]
			get;
		}

		[Token(Token = "0x1700079C")]
		int yPos
		{
			[Token(Token = "0x6003A45")]
			get;
		}

		[Token(Token = "0x1700079D")]
		string buttonKey
		{
			[Token(Token = "0x6003A46")]
			get;
		}

		[Token(Token = "0x6003A47")]
		void RefreshView(ButtonContext buttonContext);
	}

	[Token(Token = "0x2000988")]
	public class BuyButtonWidget : ElementWidgetBase, IButtonWidget
	{
		[Token(Token = "0x4008C6C")]
		[FieldOffset(Offset = "0x20")]
		private readonly string k_ELabelButton;

		[Token(Token = "0x4008C6D")]
		[FieldOffset(Offset = "0x28")]
		private readonly string k_ELabelInfoText;

		[Token(Token = "0x4008C6E")]
		[FieldOffset(Offset = "0x30")]
		private readonly string k_ELabel_IconGrp;

		[Token(Token = "0x4008C6F")]
		[FieldOffset(Offset = "0x38")]
		private readonly string k_ELabel_IconGrp_PriceButtonIcon;

		[Token(Token = "0x4008C70")]
		[FieldOffset(Offset = "0x40")]
		private readonly string k_ELabel_NumGrp;

		[Token(Token = "0x4008C71")]
		[FieldOffset(Offset = "0x48")]
		private readonly string k_ELabel_NumGrp_PriceTimeLimitIcon;

		[Token(Token = "0x4008C72")]
		[FieldOffset(Offset = "0x50")]
		private readonly string k_ELabel_NumGrp_NumText;

		[Token(Token = "0x4008C73")]
		[FieldOffset(Offset = "0x58")]
		private readonly string k_ELabel_PriceGrp;

		[Token(Token = "0x4008C74")]
		[FieldOffset(Offset = "0x60")]
		private readonly string k_ELabel_PriceGrp_PaidIcon;

		[Token(Token = "0x4008C75")]
		[FieldOffset(Offset = "0x68")]
		private readonly string k_ELabel_PriceGrp_PriceIcon;

		[Token(Token = "0x4008C76")]
		[FieldOffset(Offset = "0x70")]
		private readonly string k_ELabel_PriceGrp_PriceIconTicket;

		[Token(Token = "0x4008C77")]
		[FieldOffset(Offset = "0x78")]
		private readonly string k_ELabel_PriceGrp_PriceText;

		[Token(Token = "0x4008C78")]
		[FieldOffset(Offset = "0x80")]
		public readonly ElementObjectManager buttonEom;

		[Token(Token = "0x4008C79")]
		[FieldOffset(Offset = "0x88")]
		public readonly SelectionButton button;

		[Token(Token = "0x4008C7A")]
		[FieldOffset(Offset = "0x90")]
		private readonly UIEntityDuplicator m_PriceIconTicketDuplicator;

		[Token(Token = "0x4008C7B")]
		[FieldOffset(Offset = "0x98")]
		public readonly TMP_Text infoText;

		[Token(Token = "0x4008C7C")]
		[FieldOffset(Offset = "0xA0")]
		public readonly int priceId;

		[Token(Token = "0x4008C7D")]
		[FieldOffset(Offset = "0xA4")]
		public readonly int xPos;

		[Token(Token = "0x4008C7E")]
		[FieldOffset(Offset = "0xA8")]
		public readonly int yPos;

		[Token(Token = "0x4008C80")]
		[FieldOffset(Offset = "0xB8")]
		private IReadOnlyList<PriceContext> m_PayItemPriceContexts;

		[Token(Token = "0x1700079E")]
		public GameObject iconGrp
		{
			[Token(Token = "0x6003A48")]
			[Address(RVA = "0x80FC40", Offset = "0x80EE40", VA = "0x18080FC40")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700079F")]
		public Image priceButtonIcon
		{
			[Token(Token = "0x6003A49")]
			[Address(RVA = "0x80FD50", Offset = "0x80EF50", VA = "0x18080FD50")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170007A0")]
		public GameObject numGrp
		{
			[Token(Token = "0x6003A4A")]
			[Address(RVA = "0x80FCA0", Offset = "0x80EEA0", VA = "0x18080FCA0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170007A1")]
		public GameObject limitPriceGroup
		{
			[Token(Token = "0x6003A4B")]
			[Address(RVA = "0x80FC70", Offset = "0x80EE70", VA = "0x18080FC70")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170007A2")]
		public TMP_Text numText
		{
			[Token(Token = "0x6003A4C")]
			[Address(RVA = "0x80FCD0", Offset = "0x80EED0", VA = "0x18080FCD0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170007A3")]
		public GameObject priceGrp
		{
			[Token(Token = "0x6003A4D")]
			[Address(RVA = "0x80FDA0", Offset = "0x80EFA0", VA = "0x18080FDA0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170007A4")]
		public GameObject paidIcon
		{
			[Token(Token = "0x6003A4E")]
			[Address(RVA = "0x80FD20", Offset = "0x80EF20", VA = "0x18080FD20")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170007A5")]
		public GameObject priceIcon
		{
			[Token(Token = "0x6003A4F")]
			[Address(RVA = "0x80FDD0", Offset = "0x80EFD0", VA = "0x18080FDD0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170007A6")]
		public TMP_Text priceText
		{
			[Token(Token = "0x6003A50")]
			[Address(RVA = "0x80FE00", Offset = "0x80F000", VA = "0x18080FE00")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170007A7")]
		private SelectionButton YgomGame_002EShop_002EBuyButtonGroupWidget_002EIButtonWidget_002Ebutton
		{
			[Token(Token = "0x6003A51")]
			[Address(RVA = "0x49BEA0", Offset = "0x49B0A0", VA = "0x18049BEA0", Slot = "11")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170007A8")]
		private int YgomGame_002EShop_002EBuyButtonGroupWidget_002EIButtonWidget_002ExPos
		{
			[Token(Token = "0x6003A52")]
			[Address(RVA = "0x80F760", Offset = "0x80E960", VA = "0x18080F760", Slot = "12")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170007A9")]
		private int YgomGame_002EShop_002EBuyButtonGroupWidget_002EIButtonWidget_002EyPos
		{
			[Token(Token = "0x6003A53")]
			[Address(RVA = "0x42D5E0", Offset = "0x42C7E0", VA = "0x18042D5E0", Slot = "13")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170007AA")]
		public string buttonKey
		{
			[Token(Token = "0x6003A54")]
			[Address(RVA = "0x49BB20", Offset = "0x49AD20", VA = "0x18049BB20", Slot = "14")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6003A55")]
			[Address(RVA = "0x42FF50", Offset = "0x42F150", VA = "0x18042FF50")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x6003A56")]
		[Address(RVA = "0x80F770", Offset = "0x80E970", VA = "0x18080F770")]
		public BuyButtonWidget(ElementObjectManager eom, PriceContext priceContext, int xPos, int yPos)
		{
		}

		[Token(Token = "0x6003A57")]
		[Address(RVA = "0x80ED30", Offset = "0x80DF30", VA = "0x18080ED30", Slot = "15")]
		public void RefreshView(ButtonContext ctx)
		{
		}

		[Token(Token = "0x6003A58")]
		[Address(RVA = "0x80EC00", Offset = "0x80DE00", VA = "0x18080EC00")]
		private void OnUpdatePriceTicketIcon(GameObject icon, int idx)
		{
		}
	}

	[Token(Token = "0x2000989")]
	public class ActionButtonWidget : ElementWidgetBase, IButtonWidget
	{
		[Token(Token = "0x4008C81")]
		[FieldOffset(Offset = "0x20")]
		private readonly string k_ELabelButton;

		[Token(Token = "0x4008C82")]
		[FieldOffset(Offset = "0x28")]
		private readonly string k_ELabelActionText;

		[Token(Token = "0x4008C83")]
		[FieldOffset(Offset = "0x30")]
		private readonly string k_ELabelInfoText;

		[Token(Token = "0x4008C84")]
		[FieldOffset(Offset = "0x38")]
		public readonly ElementObjectManager buttonEom;

		[Token(Token = "0x4008C85")]
		[FieldOffset(Offset = "0x40")]
		public readonly SelectionButton button;

		[Token(Token = "0x4008C86")]
		[FieldOffset(Offset = "0x48")]
		public readonly TMP_Text actionText;

		[Token(Token = "0x4008C87")]
		[FieldOffset(Offset = "0x50")]
		public readonly TMP_Text infoText;

		[Token(Token = "0x4008C88")]
		[FieldOffset(Offset = "0x58")]
		public readonly string actionScheme;

		[Token(Token = "0x4008C89")]
		[FieldOffset(Offset = "0x60")]
		public readonly int xPos;

		[Token(Token = "0x4008C8A")]
		[FieldOffset(Offset = "0x64")]
		public readonly int yPos;

		[Token(Token = "0x170007AB")]
		private SelectionButton YgomGame_002EShop_002EBuyButtonGroupWidget_002EIButtonWidget_002Ebutton
		{
			[Token(Token = "0x6003A59")]
			[Address(RVA = "0x404850", Offset = "0x403A50", VA = "0x180404850", Slot = "11")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170007AC")]
		private int YgomGame_002EShop_002EBuyButtonGroupWidget_002EIButtonWidget_002ExPos
		{
			[Token(Token = "0x6003A5A")]
			[Address(RVA = "0x404880", Offset = "0x403A80", VA = "0x180404880", Slot = "12")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170007AD")]
		private int YgomGame_002EShop_002EBuyButtonGroupWidget_002EIButtonWidget_002EyPos
		{
			[Token(Token = "0x6003A5B")]
			[Address(RVA = "0x80A510", Offset = "0x809710", VA = "0x18080A510", Slot = "13")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170007AE")]
		public string buttonKey
		{
			[Token(Token = "0x6003A5C")]
			[Address(RVA = "0x5EA220", Offset = "0x5E9420", VA = "0x1805EA220", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6003A5D")]
		[Address(RVA = "0x80A520", Offset = "0x809720", VA = "0x18080A520")]
		public ActionButtonWidget(ElementObjectManager eom, string actionScheme, int xPos, int yPos)
		{
		}

		[Token(Token = "0x6003A5E")]
		[Address(RVA = "0x80A3F0", Offset = "0x8095F0", VA = "0x18080A3F0", Slot = "15")]
		public void RefreshView(ButtonContext ctx)
		{
		}
	}

	[Token(Token = "0x4008C4D")]
	[FieldOffset(Offset = "0x20")]
	private readonly string k_ELabelBuyButtonTemplate;

	[Token(Token = "0x4008C4E")]
	[FieldOffset(Offset = "0x28")]
	private readonly string k_ELabelBuyButtonSRTemplate;

	[Token(Token = "0x4008C4F")]
	[FieldOffset(Offset = "0x30")]
	private readonly string k_ELabelBuyButtonURTemplate;

	[Token(Token = "0x4008C50")]
	[FieldOffset(Offset = "0x38")]
	private readonly string k_ELabelActionButtonTemplate;

	[Token(Token = "0x4008C51")]
	[FieldOffset(Offset = "0x40")]
	private readonly string k_ELabelHalfGroupTemplate;

	[Token(Token = "0x4008C52")]
	[FieldOffset(Offset = "0x48")]
	private readonly string k_OVGroupLabel_Default;

	[Token(Token = "0x4008C53")]
	[FieldOffset(Offset = "0x50")]
	private readonly string k_OVGroupLabel_Half;

	[Token(Token = "0x4008C54")]
	private const int k_ButtonStyleNormal = 1;

	[Token(Token = "0x4008C55")]
	private const int k_ButtonStyleSR = 2;

	[Token(Token = "0x4008C56")]
	private const int k_ButtonStyleUR = 3;

	[Token(Token = "0x4008C57")]
	[FieldOffset(Offset = "0x58")]
	private readonly ElementObjectManager m_BuyButtonTemplate;

	[Token(Token = "0x4008C58")]
	[FieldOffset(Offset = "0x60")]
	private readonly ElementObjectManager m_BuyButtonSRTemplate;

	[Token(Token = "0x4008C59")]
	[FieldOffset(Offset = "0x68")]
	private readonly ElementObjectManager m_BuyButtonURTemplate;

	[Token(Token = "0x4008C5A")]
	[FieldOffset(Offset = "0x70")]
	private readonly ElementObjectManager m_ActionButtonTemplate;

	[Token(Token = "0x4008C5B")]
	[FieldOffset(Offset = "0x78")]
	private readonly ElementObjectManager m_HalfGroupTemplate;

	[Token(Token = "0x4008C5C")]
	[FieldOffset(Offset = "0x80")]
	private Transform m_ButtonRoot;

	[Token(Token = "0x4008C5D")]
	[FieldOffset(Offset = "0x88")]
	private List<IButtonWidget> m_ButtonWidgets;

	[Token(Token = "0x4008C5E")]
	[FieldOffset(Offset = "0x90")]
	private ButtonContext m_ButtonCtx;

	[Token(Token = "0x4008C5F")]
	[FieldOffset(Offset = "0x98")]
	private string m_SelectedButtonKey;

	[Token(Token = "0x4008C60")]
	[FieldOffset(Offset = "0xA0")]
	public Action<PriceContext> onClickedCallback;

	[Token(Token = "0x4008C61")]
	[FieldOffset(Offset = "0xA8")]
	public Action onTransitionEdgeLeft;

	[Token(Token = "0x4008C62")]
	[FieldOffset(Offset = "0xB0")]
	public Action onTransitionEdgeUp;

	[Token(Token = "0x6003A37")]
	[Address(RVA = "0x80E850", Offset = "0x80DA50", VA = "0x18080E850")]
	public BuyButtonGroupWidget(ElementObjectManager eom)
	{
	}

	[Token(Token = "0x6003A38")]
	[Address(RVA = "0x80C7B0", Offset = "0x80B9B0", VA = "0x18080C7B0")]
	public void Binding(ProductContext productData, TextGroupLoadHolder textGroupLoadHolder)
	{
	}

	[Token(Token = "0x6003A39")]
	[Address(RVA = "0x80E610", Offset = "0x80D810", VA = "0x18080E610")]
	public bool TrySelectLatestButton()
	{
		return default(bool);
	}

	[Token(Token = "0x6003A3A")]
	[Address(RVA = "0x80DFA0", Offset = "0x80D1A0", VA = "0x18080DFA0")]
	private Transform InsertHalfGroup()
	{
		return null;
	}

	[Token(Token = "0x6003A3B")]
	[Address(RVA = "0x80E070", Offset = "0x80D270", VA = "0x18080E070")]
	private void InsertHalfSpacer(Transform parent, int spaceCnt)
	{
	}

	[Token(Token = "0x6003A3C")]
	[Address(RVA = "0x80D960", Offset = "0x80CB60", VA = "0x18080D960")]
	private IButtonWidget InsertButton(ProductContext productData, PriceContext priceContext, Transform parent, string ovGroupLabel, int xPos, int yPos)
	{
		return null;
	}

	[Token(Token = "0x6003A3D")]
	[Address(RVA = "0x80D8A0", Offset = "0x80CAA0", VA = "0x18080D8A0")]
	private ElementObjectManager GetButtonTemplate(ProductContext productData, PriceContext priceContext)
	{
		return null;
	}

	[Token(Token = "0x6003A3E")]
	[Address(RVA = "0x80E4A0", Offset = "0x80D6A0", VA = "0x18080E4A0")]
	public bool SelectHeadButton(bool initializeSelection = false)
	{
		return default(bool);
	}

	[Token(Token = "0x6003A3F")]
	[Address(RVA = "0x80E210", Offset = "0x80D410", VA = "0x18080E210")]
	private void OnButtonInputDirection(IButtonWidget from, int xAmount, int yAmount)
	{
	}
}
