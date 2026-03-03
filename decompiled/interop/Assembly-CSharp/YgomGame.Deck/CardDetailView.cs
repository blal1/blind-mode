using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using YgomGame.Card;
using YgomSystem.ElementSystem;
using YgomSystem.UI;
using YgomSystem.UI.ElementWidget;
using YgomSystem.YGomTMPro;

namespace YgomGame.Deck;

[Token(Token = "0x2001092")]
[RequireComponent(typeof(ElementObjectManager))]
public class CardDetailView : MonoBehaviour
{
	[Token(Token = "0x2001093")]
	public abstract class ElementWidget : MonoBehaviour
	{
		[Token(Token = "0x400B066")]
		[FieldOffset(Offset = "0x20")]
		protected ElementObjectManager m_Eom;

		[Token(Token = "0x400B067")]
		[FieldOffset(Offset = "0x28")]
		protected bool isInitialized;

		[Token(Token = "0x1700104E")]
		public bool isIni
		{
			[Token(Token = "0x6006626")]
			[Address(RVA = "0x588F60", Offset = "0x588160", VA = "0x180588F60")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6006627")]
		[Address(RVA = "0xAD10C0", Offset = "0xAD02C0", VA = "0x180AD10C0")]
		public void Initialize()
		{
		}

		[Token(Token = "0x6006628")]
		[Address(RVA = "0xAD10B0", Offset = "0xAD02B0", VA = "0x180AD10B0")]
		private void Awake()
		{
		}

		[Token(Token = "0x6006629")]
		protected abstract void InitializeElements();

		[Token(Token = "0x600662A")]
		[Address(RVA = "0x3D2BD0", Offset = "0x3D1DD0", VA = "0x1803D2BD0")]
		protected ElementWidget()
		{
		}
	}

	[Token(Token = "0x2001094")]
	private class TitleArea : ElementWidget
	{
		[Token(Token = "0x1700104F")]
		public RubyTextGX m_CardName
		{
			[Token(Token = "0x600662B")]
			[Address(RVA = "0x402CE0", Offset = "0x401EE0", VA = "0x180402CE0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600662C")]
			[Address(RVA = "0x4130D0", Offset = "0x4122D0", VA = "0x1804130D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17001050")]
		public RectTransform m_NameArea
		{
			[Token(Token = "0x600662D")]
			[Address(RVA = "0x404860", Offset = "0x403A60", VA = "0x180404860")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600662E")]
			[Address(RVA = "0x595520", Offset = "0x594720", VA = "0x180595520")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17001051")]
		public Image m_NameAreaBG
		{
			[Token(Token = "0x600662F")]
			[Address(RVA = "0x404850", Offset = "0x403A50", VA = "0x180404850")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6006630")]
			[Address(RVA = "0x595530", Offset = "0x594730", VA = "0x180595530")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17001052")]
		public Image m_AttrIcon
		{
			[Token(Token = "0x6006631")]
			[Address(RVA = "0x414E80", Offset = "0x414080", VA = "0x180414E80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6006632")]
			[Address(RVA = "0x414E90", Offset = "0x414090", VA = "0x180414E90")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x6006633")]
		[Address(RVA = "0xAD2900", Offset = "0xAD1B00", VA = "0x180AD2900", Slot = "4")]
		protected override void InitializeElements()
		{
		}

		[Token(Token = "0x6006634")]
		[Address(RVA = "0x3D2BD0", Offset = "0x3D1DD0", VA = "0x1803D2BD0")]
		public TitleArea()
		{
		}
	}

	[Token(Token = "0x2001095")]
	public class CardArea : ElementWidget
	{
		[Token(Token = "0x400B06C")]
		[FieldOffset(Offset = "0x30")]
		private int m_CardID;

		[Token(Token = "0x400B06D")]
		[FieldOffset(Offset = "0x34")]
		private CardCollectionInfo.Premium m_Premium;

		[Token(Token = "0x17001053")]
		public RawImage m_CardImage
		{
			[Token(Token = "0x6006637")]
			[Address(RVA = "0x404860", Offset = "0x403A60", VA = "0x180404860")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6006638")]
			[Address(RVA = "0x595520", Offset = "0x594720", VA = "0x180595520")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17001054")]
		public Image m_LimitIcon
		{
			[Token(Token = "0x6006639")]
			[Address(RVA = "0x404850", Offset = "0x403A50", VA = "0x180404850")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600663A")]
			[Address(RVA = "0x595530", Offset = "0x594730", VA = "0x180595530")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17001055")]
		public Image m_RarityIcon
		{
			[Token(Token = "0x600663B")]
			[Address(RVA = "0x414E80", Offset = "0x414080", VA = "0x180414E80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600663C")]
			[Address(RVA = "0x414E90", Offset = "0x414090", VA = "0x180414E90")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17001056")]
		public SelectionButton m_CardButton
		{
			[Token(Token = "0x600663D")]
			[Address(RVA = "0x580700", Offset = "0x57F900", VA = "0x180580700")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600663E")]
			[Address(RVA = "0x580760", Offset = "0x57F960", VA = "0x180580760")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17001057")]
		public Image m_RentalImage
		{
			[Token(Token = "0x600663F")]
			[Address(RVA = "0x5EA220", Offset = "0x5E9420", VA = "0x1805EA220")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6006640")]
			[Address(RVA = "0x81BD60", Offset = "0x81AF60", VA = "0x18081BD60")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17001058")]
		public ExtendedTextMeshProUGUI m_CardTotalText
		{
			[Token(Token = "0x6006642")]
			[Address(RVA = "0x589E50", Offset = "0x589050", VA = "0x180589E50")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6006643")]
			[Address(RVA = "0x589E60", Offset = "0x589060", VA = "0x180589E60")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17001059")]
		public ExtendedTextMeshProUGUI m_NonPrizeCardTotalText
		{
			[Token(Token = "0x6006644")]
			[Address(RVA = "0x49B9F0", Offset = "0x49ABF0", VA = "0x18049B9F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6006645")]
			[Address(RVA = "0x49C1F0", Offset = "0x49B3F0", VA = "0x18049C1F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700105A")]
		public RectTransform m_CardNumRoot
		{
			[Token(Token = "0x6006646")]
			[Address(RVA = "0x449820", Offset = "0x448A20", VA = "0x180449820")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6006647")]
			[Address(RVA = "0x3D77E0", Offset = "0x3D69E0", VA = "0x1803D77E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x6006635")]
		[Address(RVA = "0x99C310", Offset = "0x99B510", VA = "0x18099C310")]
		public void SetCard(int cardId, CardCollectionInfo.Premium premium)
		{
		}

		[Token(Token = "0x6006636")]
		[Address(RVA = "0xAB3FF0", Offset = "0xAB31F0", VA = "0x180AB3FF0", Slot = "4")]
		protected override void InitializeElements()
		{
		}

		[Token(Token = "0x6006641")]
		[Address(RVA = "0xAB3D50", Offset = "0xAB2F50", VA = "0x180AB3D50")]
		private void InitializeCardImage()
		{
		}

		[Token(Token = "0x6006648")]
		[Address(RVA = "0xAB3EC0", Offset = "0xAB30C0", VA = "0x180AB3EC0")]
		private void InitializeCardNumText()
		{
		}

		[Token(Token = "0x6006649")]
		[Address(RVA = "0x99C320", Offset = "0x99B520", VA = "0x18099C320")]
		public CardArea()
		{
		}
	}

	[Token(Token = "0x2001096")]
	private class ParameterArea : ElementWidget
	{
		[Token(Token = "0x2001097")]
		public class ParamIcon : ElementWidget
		{
			[Token(Token = "0x17001068")]
			public Image m_IconImage
			{
				[Token(Token = "0x6006668")]
				[Address(RVA = "0x402CE0", Offset = "0x401EE0", VA = "0x180402CE0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x6006669")]
				[Address(RVA = "0x4130D0", Offset = "0x4122D0", VA = "0x1804130D0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x17001069")]
			public ExtendedTextMeshProUGUI m_IconText
			{
				[Token(Token = "0x600666A")]
				[Address(RVA = "0x404860", Offset = "0x403A60", VA = "0x180404860")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x600666B")]
				[Address(RVA = "0x595520", Offset = "0x594720", VA = "0x180595520")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x600666C")]
			[Address(RVA = "0xAD1E80", Offset = "0xAD1080", VA = "0x180AD1E80", Slot = "4")]
			protected override void InitializeElements()
			{
			}

			[Token(Token = "0x600666D")]
			[Address(RVA = "0x3D2BD0", Offset = "0x3D1DD0", VA = "0x1803D2BD0")]
			public ParamIcon()
			{
			}
		}

		[Token(Token = "0x400B083")]
		[FieldOffset(Offset = "0x98")]
		public GameObject m_RentalCardText;

		[Token(Token = "0x400B084")]
		[FieldOffset(Offset = "0xA0")]
		private ElementObjectManager m_PremiumNumGroupEom;

		[Token(Token = "0x400B085")]
		[FieldOffset(Offset = "0xA8")]
		private ExtendedTextMeshProUGUI m_PremNum0;

		[Token(Token = "0x400B086")]
		[FieldOffset(Offset = "0xB0")]
		private ExtendedTextMeshProUGUI m_PremNum1;

		[Token(Token = "0x400B087")]
		[FieldOffset(Offset = "0xB8")]
		private ExtendedTextMeshProUGUI m_PremNum2;

		[Token(Token = "0x400B088")]
		[FieldOffset(Offset = "0xC0")]
		private Image m_PremSelector0;

		[Token(Token = "0x400B089")]
		[FieldOffset(Offset = "0xC8")]
		private Image m_PremSelector1;

		[Token(Token = "0x400B08A")]
		[FieldOffset(Offset = "0xD0")]
		private Image m_PremSelector2;

		[Token(Token = "0x1700105B")]
		public ParamIcon m_TunerIcon
		{
			[Token(Token = "0x600664A")]
			[Address(RVA = "0x402CE0", Offset = "0x401EE0", VA = "0x180402CE0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600664B")]
			[Address(RVA = "0x4130D0", Offset = "0x4122D0", VA = "0x1804130D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700105C")]
		public ParamIcon m_TypeIcon
		{
			[Token(Token = "0x600664C")]
			[Address(RVA = "0x404860", Offset = "0x403A60", VA = "0x180404860")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600664D")]
			[Address(RVA = "0x595520", Offset = "0x594720", VA = "0x180595520")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700105D")]
		public ParamIcon m_PendScaleIcon
		{
			[Token(Token = "0x600664E")]
			[Address(RVA = "0x404850", Offset = "0x403A50", VA = "0x180404850")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600664F")]
			[Address(RVA = "0x595530", Offset = "0x594730", VA = "0x180595530")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700105E")]
		public ParamIcon m_LvlIcon
		{
			[Token(Token = "0x6006650")]
			[Address(RVA = "0x414E80", Offset = "0x414080", VA = "0x180414E80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6006651")]
			[Address(RVA = "0x414E90", Offset = "0x414090", VA = "0x180414E90")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700105F")]
		public ParamIcon m_RankIcon
		{
			[Token(Token = "0x6006652")]
			[Address(RVA = "0x580700", Offset = "0x57F900", VA = "0x180580700")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6006653")]
			[Address(RVA = "0x580760", Offset = "0x57F960", VA = "0x180580760")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17001060")]
		public ParamIcon m_LinkIcon
		{
			[Token(Token = "0x6006654")]
			[Address(RVA = "0x5EA220", Offset = "0x5E9420", VA = "0x1805EA220")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6006655")]
			[Address(RVA = "0x81BD60", Offset = "0x81AF60", VA = "0x18081BD60")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17001061")]
		public ParamIcon m_AtkIcon
		{
			[Token(Token = "0x6006656")]
			[Address(RVA = "0x589E50", Offset = "0x589050", VA = "0x180589E50")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6006657")]
			[Address(RVA = "0x589E60", Offset = "0x589060", VA = "0x180589E60")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17001062")]
		public ParamIcon m_DefIcon
		{
			[Token(Token = "0x6006658")]
			[Address(RVA = "0x49B9F0", Offset = "0x49ABF0", VA = "0x18049B9F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6006659")]
			[Address(RVA = "0x49C1F0", Offset = "0x49B3F0", VA = "0x18049C1F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17001063")]
		public RectTransform m_SpellTrapTypeRoot
		{
			[Token(Token = "0x600665A")]
			[Address(RVA = "0x449820", Offset = "0x448A20", VA = "0x180449820")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600665B")]
			[Address(RVA = "0x3D77E0", Offset = "0x3D69E0", VA = "0x1803D77E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17001064")]
		public Image m_SpellTrapIconImage
		{
			[Token(Token = "0x600665C")]
			[Address(RVA = "0x49BD10", Offset = "0x49AF10", VA = "0x18049BD10")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600665D")]
			[Address(RVA = "0x4573F0", Offset = "0x4565F0", VA = "0x1804573F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17001065")]
		public ExtendedTextMeshProUGUI m_SpellTrapIconText
		{
			[Token(Token = "0x600665E")]
			[Address(RVA = "0x49B7F0", Offset = "0x49A9F0", VA = "0x18049B7F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600665F")]
			[Address(RVA = "0x457400", Offset = "0x456600", VA = "0x180457400")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17001066")]
		public RectTransform m_DismantleableRoot
		{
			[Token(Token = "0x6006660")]
			[Address(RVA = "0x49BEA0", Offset = "0x49B0A0", VA = "0x18049BEA0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6006661")]
			[Address(RVA = "0x457410", Offset = "0x456610", VA = "0x180457410")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17001067")]
		public ExtendedTextMeshProUGUI m_DismantleableValueText
		{
			[Token(Token = "0x6006662")]
			[Address(RVA = "0x49BDC0", Offset = "0x49AFC0", VA = "0x18049BDC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6006663")]
			[Address(RVA = "0x4989A0", Offset = "0x497BA0", VA = "0x1804989A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x6006664")]
		[Address(RVA = "0xAD25F0", Offset = "0xAD17F0", VA = "0x180AD25F0")]
		public void SetAsRental(bool isRental, bool dispDismantleableText = false)
		{
		}

		[Token(Token = "0x6006665")]
		[Address(RVA = "0xAD26C0", Offset = "0xAD18C0", VA = "0x180AD26C0")]
		public void SetPrems(int cardId, CardCollectionInfo.Premium prem, bool isRental)
		{
		}

		[Token(Token = "0x6006666")]
		[Address(RVA = "0xAD1F20", Offset = "0xAD1120", VA = "0x180AD1F20", Slot = "4")]
		protected override void InitializeElements()
		{
		}

		[Token(Token = "0x6006667")]
		[Address(RVA = "0x3D2BD0", Offset = "0x3D1DD0", VA = "0x1803D2BD0")]
		public ParameterArea()
		{
		}
	}

	[Token(Token = "0x2001098")]
	private class MenuArea : ElementWidget
	{
		[Token(Token = "0x2001099")]
		private class CraftButtonWidget : ElementWidget
		{
			[Token(Token = "0x400B09A")]
			[FieldOffset(Offset = "0x30")]
			public SelectionButton m_Button;

			[Token(Token = "0x400B09B")]
			[FieldOffset(Offset = "0x38")]
			public Transform m_CPGroup;

			[Token(Token = "0x400B09C")]
			[FieldOffset(Offset = "0x40")]
			public ExtendedTextMeshProUGUI m_ButtonText;

			[Token(Token = "0x400B09D")]
			[FieldOffset(Offset = "0x48")]
			public Image m_IconCP;

			[Token(Token = "0x400B09E")]
			[FieldOffset(Offset = "0x50")]
			public ExtendedTextMeshProUGUI m_TextCP;

			[Token(Token = "0x400B09F")]
			[FieldOffset(Offset = "0x58")]
			public Image m_IconEnabled;

			[Token(Token = "0x400B0A0")]
			[FieldOffset(Offset = "0x60")]
			public Image m_IconDisabled;

			[Token(Token = "0x400B0A1")]
			[FieldOffset(Offset = "0x68")]
			public Image m_IconLocked;

			[Token(Token = "0x6006688")]
			[Address(RVA = "0xABC410", Offset = "0xABB610", VA = "0x180ABC410", Slot = "4")]
			protected override void InitializeElements()
			{
			}

			[Token(Token = "0x6006689")]
			[Address(RVA = "0x3D2BD0", Offset = "0x3D1DD0", VA = "0x1803D2BD0")]
			public CraftButtonWidget()
			{
			}
		}

		[Token(Token = "0x400B08E")]
		[FieldOffset(Offset = "0x38")]
		private RectTransform m_BookmarkOn;

		[Token(Token = "0x400B08F")]
		[FieldOffset(Offset = "0x40")]
		private RectTransform m_BookmarkOff;

		[Token(Token = "0x400B098")]
		[FieldOffset(Offset = "0x88")]
		private CraftButtonWidget m_CraftCreateButton;

		[Token(Token = "0x400B099")]
		[FieldOffset(Offset = "0x90")]
		private CraftButtonWidget m_CraftDismantleButton;

		[Token(Token = "0x1700106A")]
		public SelectionButton m_BookmarkButton
		{
			[Token(Token = "0x600666E")]
			[Address(RVA = "0x402CE0", Offset = "0x401EE0", VA = "0x180402CE0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600666F")]
			[Address(RVA = "0x4130D0", Offset = "0x4122D0", VA = "0x1804130D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700106B")]
		public SelectionButton m_HowToGetButton
		{
			[Token(Token = "0x6006670")]
			[Address(RVA = "0x414E80", Offset = "0x414080", VA = "0x180414E80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6006671")]
			[Address(RVA = "0x414E90", Offset = "0x414090", VA = "0x180414E90")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700106C")]
		public SelectionButton m_RelatedCardButton
		{
			[Token(Token = "0x6006672")]
			[Address(RVA = "0x580700", Offset = "0x57F900", VA = "0x180580700")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6006673")]
			[Address(RVA = "0x580760", Offset = "0x57F960", VA = "0x180580760")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700106D")]
		public SelectionButton m_AddCardButton
		{
			[Token(Token = "0x6006674")]
			[Address(RVA = "0x5EA220", Offset = "0x5E9420", VA = "0x1805EA220")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6006675")]
			[Address(RVA = "0x81BD60", Offset = "0x81AF60", VA = "0x18081BD60")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700106E")]
		public SelectionButton m_RemoveCardButton
		{
			[Token(Token = "0x6006676")]
			[Address(RVA = "0x589E50", Offset = "0x589050", VA = "0x180589E50")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6006677")]
			[Address(RVA = "0x589E60", Offset = "0x589060", VA = "0x180589E60")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700106F")]
		public SelectionButton m_CreateButton
		{
			[Token(Token = "0x6006678")]
			[Address(RVA = "0xAD1E40", Offset = "0xAD1040", VA = "0x180AD1E40")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17001070")]
		public SelectionButton m_DismantleButton
		{
			[Token(Token = "0x6006679")]
			[Address(RVA = "0xAD1E60", Offset = "0xAD1060", VA = "0x180AD1E60")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17001071")]
		public RectTransform m_CardGroupRoot
		{
			[Token(Token = "0x600667A")]
			[Address(RVA = "0x49B9F0", Offset = "0x49ABF0", VA = "0x18049B9F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600667B")]
			[Address(RVA = "0x49C1F0", Offset = "0x49B3F0", VA = "0x18049C1F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17001072")]
		public RectTransform m_LockGroupRoot
		{
			[Token(Token = "0x600667C")]
			[Address(RVA = "0x449820", Offset = "0x448A20", VA = "0x180449820")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600667D")]
			[Address(RVA = "0x3D77E0", Offset = "0x3D69E0", VA = "0x1803D77E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17001073")]
		public RectTransform m_MenuGroupRoot
		{
			[Token(Token = "0x600667E")]
			[Address(RVA = "0x49BD10", Offset = "0x49AF10", VA = "0x18049BD10")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600667F")]
			[Address(RVA = "0x4573F0", Offset = "0x4565F0", VA = "0x1804573F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17001074")]
		public RectTransform m_CraftGroupRoot
		{
			[Token(Token = "0x6006680")]
			[Address(RVA = "0x49B7F0", Offset = "0x49A9F0", VA = "0x18049B7F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6006681")]
			[Address(RVA = "0x457400", Offset = "0x456600", VA = "0x180457400")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x6006682")]
		[Address(RVA = "0xAD1240", Offset = "0xAD0440", VA = "0x180AD1240", Slot = "4")]
		protected override void InitializeElements()
		{
		}

		[Token(Token = "0x6006683")]
		[Address(RVA = "0xAAFAF0", Offset = "0xAAECF0", VA = "0x180AAFAF0")]
		public void ToggleBookmark(bool isBookmarked)
		{
		}

		[Token(Token = "0x6006684")]
		[Address(RVA = "0xAD1140", Offset = "0xAD0340", VA = "0x180AD1140")]
		private void InitializeCraftElements()
		{
		}

		[Token(Token = "0x6006685")]
		[Address(RVA = "0xAD1630", Offset = "0xAD0830", VA = "0x180AD1630")]
		public void SetCraftable(bool craftable, int rarityID)
		{
		}

		[Token(Token = "0x6006686")]
		[Address(RVA = "0xAD18D0", Offset = "0xAD0AD0", VA = "0x180AD18D0")]
		public void SetDismantable(bool dismantable, int rarityID, CardCollectionInfo.Premium premium, bool isLocked = false, bool isAlterComp = false)
		{
		}

		[Token(Token = "0x6006687")]
		[Address(RVA = "0x3D2BD0", Offset = "0x3D1DD0", VA = "0x1803D2BD0")]
		public MenuArea()
		{
		}
	}

	[Token(Token = "0x400B048")]
	[FieldOffset(Offset = "0x20")]
	private ElementObjectManager m_Eom;

	[Token(Token = "0x400B049")]
	[FieldOffset(Offset = "0x28")]
	private ElementObjectManager m_eom;

	[Token(Token = "0x400B04A")]
	[FieldOffset(Offset = "0x30")]
	private bool isIni;

	[Token(Token = "0x400B04D")]
	[FieldOffset(Offset = "0x3C")]
	protected int m_Rarity;

	[Token(Token = "0x400B04F")]
	[FieldOffset(Offset = "0x48")]
	protected CardIconSprites m_CardIconSprites;

	[Token(Token = "0x400B050")]
	[FieldOffset(Offset = "0x50")]
	private TitleArea m_TitleArea;

	[Token(Token = "0x400B051")]
	[FieldOffset(Offset = "0x58")]
	protected CardArea m_CardArea;

	[Token(Token = "0x400B052")]
	[FieldOffset(Offset = "0x60")]
	private ParameterArea m_ParameterArea;

	[Token(Token = "0x400B053")]
	[FieldOffset(Offset = "0x68")]
	private MenuArea m_MenuArea;

	[Token(Token = "0x400B054")]
	private const string LABEL_SB_WINDOW = "Window";

	[Token(Token = "0x400B055")]
	protected const string LABEL_Tween_AutoScroll = "AutoScroll";

	[Token(Token = "0x400B056")]
	[FieldOffset(Offset = "0x70")]
	protected Material m_TextBGMaterial;

	[Token(Token = "0x400B057")]
	[FieldOffset(Offset = "0x78")]
	protected ContentSizeFitter m_DescTextSizeFitter;

	[Token(Token = "0x400B058")]
	[FieldOffset(Offset = "0x80")]
	protected SelectionButtonUntouchable m_Window;

	[Token(Token = "0x400B059")]
	[FieldOffset(Offset = "0x88")]
	private UnityAction m_OnClickCraftCreate;

	[Token(Token = "0x400B05A")]
	[FieldOffset(Offset = "0x90")]
	private UnityAction m_OnClickCraftDismantle;

	[Token(Token = "0x400B05B")]
	[FieldOffset(Offset = "0x98")]
	private UnityAction m_OnClickRelatedCards;

	[Token(Token = "0x400B05C")]
	[FieldOffset(Offset = "0xA0")]
	private UnityAction m_OnClickButtonBookmark;

	[Token(Token = "0x400B05D")]
	[FieldOffset(Offset = "0xA8")]
	private UnityAction m_OnClickCheckSource;

	[Token(Token = "0x400B05E")]
	[FieldOffset(Offset = "0xB0")]
	private UnityAction m_OnClickAddCard;

	[Token(Token = "0x400B05F")]
	[FieldOffset(Offset = "0xB8")]
	private UnityAction m_OnClickRemoveCard;

	[Token(Token = "0x400B060")]
	[FieldOffset(Offset = "0xC0")]
	private UnityAction m_OnClickCardButton;

	[Token(Token = "0x400B061")]
	[FieldOffset(Offset = "0xC8")]
	public ToggleWidget bookmarkToggle;

	[Token(Token = "0x1700101A")]
	protected int m_CardID
	{
		[Token(Token = "0x60065AF")]
		[Address(RVA = "0x6333C0", Offset = "0x6325C0", VA = "0x1806333C0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60065B0")]
		[Address(RVA = "0x9941B0", Offset = "0x9933B0", VA = "0x1809941B0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x1700101B")]
	public CardBaseData card
	{
		[Token(Token = "0x60065B1")]
		[Address(RVA = "0xAB7630", Offset = "0xAB6830", VA = "0x180AB7630")]
		get
		{
			return default(CardBaseData);
		}
	}

	[Token(Token = "0x1700101C")]
	protected CardCollectionInfo.Premium m_Premium
	{
		[Token(Token = "0x60065B2")]
		[Address(RVA = "0x40C450", Offset = "0x40B650", VA = "0x18040C450")]
		[CompilerGenerated]
		get
		{
			return default(CardCollectionInfo.Premium);
		}
		[Token(Token = "0x60065B3")]
		[Address(RVA = "0x4A69B0", Offset = "0x4A5BB0", VA = "0x1804A69B0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x1700101D")]
	protected bool m_IsRental
	{
		[Token(Token = "0x60065B4")]
		[Address(RVA = "0x416640", Offset = "0x415840", VA = "0x180416640")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60065B5")]
		[Address(RVA = "0x3D77B0", Offset = "0x3D69B0", VA = "0x1803D77B0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x1700101E")]
	private static Content m_cci
	{
		[Token(Token = "0x60065B6")]
		[Address(RVA = "0xAB7C20", Offset = "0xAB6E20", VA = "0x180AB7C20")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700101F")]
	protected Image m_AttrIcon
	{
		[Token(Token = "0x60065BB")]
		[Address(RVA = "0xAB7700", Offset = "0xAB6900", VA = "0x180AB7700")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001020")]
	protected Image m_NameAreaBG
	{
		[Token(Token = "0x60065BC")]
		[Address(RVA = "0xAB79E0", Offset = "0xAB6BE0", VA = "0x180AB79E0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001021")]
	protected RubyTextGX m_CardName
	{
		[Token(Token = "0x60065BD")]
		[Address(RVA = "0xAB7740", Offset = "0xAB6940", VA = "0x180AB7740")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001022")]
	protected RectTransform m_NameArea
	{
		[Token(Token = "0x60065BE")]
		[Address(RVA = "0xAB7A00", Offset = "0xAB6C00", VA = "0x180AB7A00")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001023")]
	protected SelectionButton m_CardButton
	{
		[Token(Token = "0x60065BF")]
		[Address(RVA = "0xAB7720", Offset = "0xAB6920", VA = "0x180AB7720")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001024")]
	protected RawImage m_CardImage
	{
		[Token(Token = "0x60065C0")]
		[Address(RVA = "0x99F900", Offset = "0x99EB00", VA = "0x18099F900")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001025")]
	protected Image m_RarityIcon
	{
		[Token(Token = "0x60065C1")]
		[Address(RVA = "0xAB7AE0", Offset = "0xAB6CE0", VA = "0x180AB7AE0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001026")]
	protected Image m_RegulationIcon
	{
		[Token(Token = "0x60065C2")]
		[Address(RVA = "0xAB7B00", Offset = "0xAB6D00", VA = "0x180AB7B00")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001027")]
	protected ExtendedTextMeshProUGUI m_CardTotalText
	{
		[Token(Token = "0x60065C3")]
		[Address(RVA = "0xAB7780", Offset = "0xAB6980", VA = "0x180AB7780")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001028")]
	protected RectTransform m_CardNumRoot
	{
		[Token(Token = "0x60065C4")]
		[Address(RVA = "0xAB7760", Offset = "0xAB6960", VA = "0x180AB7760")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001029")]
	protected Image m_TunerIcon
	{
		[Token(Token = "0x60065C5")]
		[Address(RVA = "0xAB7BC0", Offset = "0xAB6DC0", VA = "0x180AB7BC0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700102A")]
	protected Image m_TypeIcon
	{
		[Token(Token = "0x60065C6")]
		[Address(RVA = "0xAB7BF0", Offset = "0xAB6DF0", VA = "0x180AB7BF0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700102B")]
	protected Image m_PendScaleIcon
	{
		[Token(Token = "0x60065C7")]
		[Address(RVA = "0xAB7A20", Offset = "0xAB6C20", VA = "0x180AB7A20")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700102C")]
	protected Image m_LvlIcon
	{
		[Token(Token = "0x60065C8")]
		[Address(RVA = "0xAB7960", Offset = "0xAB6B60", VA = "0x180AB7960")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700102D")]
	protected Image m_RankIcon
	{
		[Token(Token = "0x60065C9")]
		[Address(RVA = "0xAB7A80", Offset = "0xAB6C80", VA = "0x180AB7A80")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700102E")]
	protected Image m_LinkIcon
	{
		[Token(Token = "0x60065CA")]
		[Address(RVA = "0xAB78E0", Offset = "0xAB6AE0", VA = "0x180AB78E0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700102F")]
	protected Image m_AtkIcon
	{
		[Token(Token = "0x60065CB")]
		[Address(RVA = "0xAB76A0", Offset = "0xAB68A0", VA = "0x180AB76A0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001030")]
	protected Image m_DefIcon
	{
		[Token(Token = "0x60065CC")]
		[Address(RVA = "0xAB77F0", Offset = "0xAB69F0", VA = "0x180AB77F0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001031")]
	protected ExtendedTextMeshProUGUI m_PendScaleText
	{
		[Token(Token = "0x60065CD")]
		[Address(RVA = "0xAB7A50", Offset = "0xAB6C50", VA = "0x180AB7A50")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001032")]
	protected ExtendedTextMeshProUGUI m_LvlText
	{
		[Token(Token = "0x60065CE")]
		[Address(RVA = "0xAB7990", Offset = "0xAB6B90", VA = "0x180AB7990")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001033")]
	protected ExtendedTextMeshProUGUI m_RankText
	{
		[Token(Token = "0x60065CF")]
		[Address(RVA = "0xAB7AB0", Offset = "0xAB6CB0", VA = "0x180AB7AB0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001034")]
	protected ExtendedTextMeshProUGUI m_LinkText
	{
		[Token(Token = "0x60065D0")]
		[Address(RVA = "0xAB7910", Offset = "0xAB6B10", VA = "0x180AB7910")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001035")]
	protected ExtendedTextMeshProUGUI m_AtkText
	{
		[Token(Token = "0x60065D1")]
		[Address(RVA = "0xAB76D0", Offset = "0xAB68D0", VA = "0x180AB76D0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001036")]
	protected ExtendedTextMeshProUGUI m_DefText
	{
		[Token(Token = "0x60065D2")]
		[Address(RVA = "0xAB7820", Offset = "0xAB6A20", VA = "0x180AB7820")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001037")]
	protected RectTransform m_SpellTrapType
	{
		[Token(Token = "0x60065D3")]
		[Address(RVA = "0xAB7BA0", Offset = "0xAB6DA0", VA = "0x180AB7BA0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001038")]
	protected Image m_SpellTrapTypeIcon
	{
		[Token(Token = "0x60065D4")]
		[Address(RVA = "0xAB7B60", Offset = "0xAB6D60", VA = "0x180AB7B60")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001039")]
	protected ExtendedTextMeshProUGUI m_SpellTrapTypeText
	{
		[Token(Token = "0x60065D5")]
		[Address(RVA = "0xAB7B80", Offset = "0xAB6D80", VA = "0x180AB7B80")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700103A")]
	protected RectTransform m_DismantleableRoot
	{
		[Token(Token = "0x60065D6")]
		[Address(RVA = "0xAB7880", Offset = "0xAB6A80", VA = "0x180AB7880")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700103B")]
	protected ExtendedTextMeshProUGUI m_DismantleableValue
	{
		[Token(Token = "0x60065D7")]
		[Address(RVA = "0xAB78A0", Offset = "0xAB6AA0", VA = "0x180AB78A0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700103C")]
	protected SelectionButton m_AddCardButton
	{
		[Token(Token = "0x60065D9")]
		[Address(RVA = "0xAB7680", Offset = "0xAB6880", VA = "0x180AB7680")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700103D")]
	protected SelectionButton m_RemoveCardButton
	{
		[Token(Token = "0x60065DA")]
		[Address(RVA = "0xAB7B40", Offset = "0xAB6D40", VA = "0x180AB7B40")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700103E")]
	protected SelectionButton m_BookmarkButton
	{
		[Token(Token = "0x60065DB")]
		[Address(RVA = "0x8A9A00", Offset = "0x8A8C00", VA = "0x1808A9A00")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700103F")]
	protected SelectionButton m_HowToGetButton
	{
		[Token(Token = "0x60065DC")]
		[Address(RVA = "0xAB78C0", Offset = "0xAB6AC0", VA = "0x180AB78C0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001040")]
	protected SelectionButton m_RelatedCardButton
	{
		[Token(Token = "0x60065DD")]
		[Address(RVA = "0xAB7B20", Offset = "0xAB6D20", VA = "0x180AB7B20")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001041")]
	protected SelectionButton m_CreateButton
	{
		[Token(Token = "0x60065DE")]
		[Address(RVA = "0xAB77C0", Offset = "0xAB69C0", VA = "0x180AB77C0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001042")]
	protected SelectionButton m_DismantleButton
	{
		[Token(Token = "0x60065DF")]
		[Address(RVA = "0xAB7850", Offset = "0xAB6A50", VA = "0x180AB7850")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001043")]
	protected RectTransform m_LockGroup
	{
		[Token(Token = "0x60065E0")]
		[Address(RVA = "0xAB7940", Offset = "0xAB6B40", VA = "0x180AB7940")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001044")]
	protected RectTransform m_MenuGroup
	{
		[Token(Token = "0x60065E1")]
		[Address(RVA = "0xAB79C0", Offset = "0xAB6BC0", VA = "0x180AB79C0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001045")]
	protected RectTransform m_CraftGroup
	{
		[Token(Token = "0x60065E2")]
		[Address(RVA = "0xAB77A0", Offset = "0xAB69A0", VA = "0x180AB77A0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001046")]
	protected ExtendedTextMeshProUGUI m_DescText
	{
		[Token(Token = "0x60065E3")]
		[Address(RVA = "0x5961F0", Offset = "0x5953F0", VA = "0x1805961F0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001047")]
	protected ExtendedTextMeshProUGUI m_DescTitleText
	{
		[Token(Token = "0x60065E4")]
		[Address(RVA = "0x5961E0", Offset = "0x5953E0", VA = "0x1805961E0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001048")]
	protected Image m_DescAreaBG
	{
		[Token(Token = "0x60065E5")]
		[Address(RVA = "0x49BAE0", Offset = "0x49ACE0", VA = "0x18049BAE0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001049")]
	protected ExtendedScrollRect m_TextAreaScroll
	{
		[Token(Token = "0x60065E6")]
		[Address(RVA = "0x5857B0", Offset = "0x5849B0", VA = "0x1805857B0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700104A")]
	private ExtendedScrollRect m_TextArea
	{
		[Token(Token = "0x60065E7")]
		[Address(RVA = "0x5857B0", Offset = "0x5849B0", VA = "0x1805857B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x60065E8")]
		[Address(RVA = "0x42FFB0", Offset = "0x42F1B0", VA = "0x18042FFB0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x1700104B")]
	private ExtendedTextMeshProUGUI m_CardDesc
	{
		[Token(Token = "0x60065E9")]
		[Address(RVA = "0x5961F0", Offset = "0x5953F0", VA = "0x1805961F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x60065EA")]
		[Address(RVA = "0x662500", Offset = "0x661700", VA = "0x180662500")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x1700104C")]
	private ExtendedTextMeshProUGUI m_CardDescHeading
	{
		[Token(Token = "0x60065EB")]
		[Address(RVA = "0x5961E0", Offset = "0x5953E0", VA = "0x1805961E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x60065EC")]
		[Address(RVA = "0x662520", Offset = "0x661720", VA = "0x180662520")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x1700104D")]
	private Image m_DescAreaBG_
	{
		[Token(Token = "0x60065ED")]
		[Address(RVA = "0x49BAE0", Offset = "0x49ACE0", VA = "0x18049BAE0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x60065EE")]
		[Address(RVA = "0x49C200", Offset = "0x49B400", VA = "0x18049C200")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x60065B7")]
	[Address(RVA = "0xAB5AB0", Offset = "0xAB4CB0", VA = "0x180AB5AB0")]
	public void SetActiveButtonCraftCreate(bool active)
	{
	}

	[Token(Token = "0x60065B8")]
	[Address(RVA = "0xAB5AF0", Offset = "0xAB4CF0", VA = "0x180AB5AF0")]
	public void SetActiveButtonCraftDismantle(bool active)
	{
	}

	[Token(Token = "0x60065B9")]
	[Address(RVA = "0xAB8280", Offset = "0xAB7480", VA = "0x180AB8280")]
	protected void setCraftPoint(bool isRental = false, bool isLocked = false, bool isAlterComp = false)
	{
	}

	[Token(Token = "0x60065BA")]
	[Address(RVA = "0xAB7610", Offset = "0xAB6810", VA = "0x180AB7610")]
	public void UpdateCraftPoint()
	{
	}

	[Token(Token = "0x60065D8")]
	[Address(RVA = "0xAB74B0", Offset = "0xAB66B0", VA = "0x180AB74B0")]
	protected void SetPrems(int cardId, CardCollectionInfo.Premium prem, bool isRental)
	{
	}

	[Token(Token = "0x60065EF")]
	[Address(RVA = "0xAB5A30", Offset = "0xAB4C30", VA = "0x180AB5A30")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x60065F0")]
	[Address(RVA = "0xAB56E0", Offset = "0xAB48E0", VA = "0x180AB56E0")]
	private void InitializeElements()
	{
	}

	[Token(Token = "0x60065F1")]
	[Address(RVA = "0xAB50E0", Offset = "0xAB42E0", VA = "0x180AB50E0")]
	private void Awake()
	{
	}

	[Token(Token = "0x60065F2")]
	[Address(RVA = "0xAB74E0", Offset = "0xAB66E0", VA = "0x180AB74E0")]
	private void Start()
	{
	}

	[Token(Token = "0x60065F3")]
	[Address(RVA = "0xAB7EB0", Offset = "0xAB70B0", VA = "0x180AB7EB0")]
	protected void setCardImage()
	{
	}

	[Token(Token = "0x60065F4")]
	[Address(RVA = "0xAB8E10", Offset = "0xAB8010", VA = "0x180AB8E10")]
	protected void setRentalCardImage(bool isRental, bool dispDismantleableText = false)
	{
	}

	[Token(Token = "0x60065F5")]
	[Address(RVA = "0xAB7F60", Offset = "0xAB7160", VA = "0x180AB7F60")]
	protected void setCardName()
	{
	}

	[Token(Token = "0x60065F6")]
	[Address(RVA = "0xAB90D0", Offset = "0xAB82D0", VA = "0x180AB90D0")]
	protected void setTextBGMat()
	{
	}

	[Token(Token = "0x60065F7")]
	[Address(RVA = "0xAB8040", Offset = "0xAB7240", VA = "0x180AB8040")]
	protected void setCardText()
	{
	}

	[Token(Token = "0x60065F8")]
	[Address(RVA = "0xAB7E10", Offset = "0xAB7010", VA = "0x180AB7E10")]
	protected void setAttribute()
	{
	}

	[Token(Token = "0x60065F9")]
	[Address(RVA = "0xAB7CB0", Offset = "0xAB6EB0", VA = "0x180AB7CB0")]
	protected void setAttack()
	{
	}

	[Token(Token = "0x60065FA")]
	[Address(RVA = "0xAB83F0", Offset = "0xAB75F0", VA = "0x180AB83F0")]
	protected void setDefence()
	{
	}

	[Token(Token = "0x60065FB")]
	[Address(RVA = "0xAB9120", Offset = "0xAB8320", VA = "0x180AB9120")]
	protected void setTuner()
	{
	}

	[Token(Token = "0x60065FC")]
	[Address(RVA = "0xAB89D0", Offset = "0xAB7BD0", VA = "0x180AB89D0")]
	protected void setPendulumScale()
	{
	}

	[Token(Token = "0x60065FD")]
	[Address(RVA = "0xAB87F0", Offset = "0xAB79F0", VA = "0x180AB87F0")]
	protected void setLevel()
	{
	}

	[Token(Token = "0x60065FE")]
	[Address(RVA = "0xAB8AC0", Offset = "0xAB7CC0", VA = "0x180AB8AC0")]
	protected void setRank()
	{
	}

	[Token(Token = "0x60065FF")]
	[Address(RVA = "0xAB88E0", Offset = "0xAB7AE0", VA = "0x180AB88E0")]
	protected void setLinkRating()
	{
	}

	[Token(Token = "0x6006600")]
	[Address(RVA = "0xAB9190", Offset = "0xAB8390", VA = "0x180AB9190")]
	protected void setType()
	{
	}

	[Token(Token = "0x6006601")]
	[Address(RVA = "0xAB8F30", Offset = "0xAB8130", VA = "0x180AB8F30")]
	protected void setSpellTrapType()
	{
	}

	[Token(Token = "0x6006602")]
	[Address(RVA = "0xAB8BB0", Offset = "0xAB7DB0", VA = "0x180AB8BB0")]
	protected void setRarity()
	{
	}

	[Token(Token = "0x6006603")]
	[Address(RVA = "0xAB8580", Offset = "0xAB7780", VA = "0x180AB8580")]
	protected void setDescriptionTitle()
	{
	}

	[Token(Token = "0x6006604")]
	[Address(RVA = "0xAB7230", Offset = "0xAB6430", VA = "0x180AB7230")]
	public void SetInventory(int rentalID = 0, bool isRental = false)
	{
	}

	[Token(Token = "0x6006605")]
	[Address(RVA = "0xAB8700", Offset = "0xAB7900", VA = "0x180AB8700")]
	protected void setDismantleableValue()
	{
	}

	[Token(Token = "0x6006606")]
	[Address(RVA = "0xAB8CB0", Offset = "0xAB7EB0", VA = "0x180AB8CB0")]
	protected void setRegulationIcon(int id)
	{
	}

	[Token(Token = "0x6006607")]
	[Address(RVA = "0xAB5B30", Offset = "0xAB4D30", VA = "0x180AB5B30")]
	public void SetActiveButtons(bool b)
	{
	}

	[Token(Token = "0x6006608")]
	[Address(RVA = "0xAB5EB0", Offset = "0xAB50B0", VA = "0x180AB5EB0")]
	public void SetBookmark(bool b)
	{
	}

	[Token(Token = "0x6006609")]
	[Address(RVA = "0xAB5CD0", Offset = "0xAB4ED0", VA = "0x180AB5CD0")]
	public void SetBlank(bool b)
	{
	}

	[Token(Token = "0x600660A")]
	[Address(RVA = "0xAB5F50", Offset = "0xAB5150", VA = "0x180AB5F50", Slot = "4")]
	public virtual void SetCard(CardBaseData data, int rent = 0, int reg = -1, bool bookmark = false, bool dispDismantleableText = false, bool isLocked = false, bool isAlterComp = false)
	{
	}

	[Token(Token = "0x600660B")]
	[Address(RVA = "0x42FF10", Offset = "0x42F110", VA = "0x18042FF10")]
	public void SetOnClickBookmarkCallBack(UnityAction callback)
	{
	}

	[Token(Token = "0x600660C")]
	[Address(RVA = "0x457410", Offset = "0x456610", VA = "0x180457410")]
	public void SetOnClickCreateCallBack(UnityAction callback)
	{
	}

	[Token(Token = "0x600660D")]
	[Address(RVA = "0x4989A0", Offset = "0x497BA0", VA = "0x1804989A0")]
	public void SetOnClickDismantleCallBack(UnityAction callback)
	{
	}

	[Token(Token = "0x600660E")]
	[Address(RVA = "0x42FFD0", Offset = "0x42F1D0", VA = "0x18042FFD0")]
	public void SetOnClickRelatedCardsCallBack(UnityAction callback)
	{
	}

	[Token(Token = "0x600660F")]
	[Address(RVA = "0x42FF30", Offset = "0x42F130", VA = "0x18042FF30")]
	public void SetOnClickCheckSourceCallBack(UnityAction callback)
	{
	}

	[Token(Token = "0x6006610")]
	[Address(RVA = "0x42FF50", Offset = "0x42F150", VA = "0x18042FF50")]
	public void SetOnClickAddCardCallBack(UnityAction callback)
	{
	}

	[Token(Token = "0x6006611")]
	[Address(RVA = "0xAB5A80", Offset = "0xAB4C80", VA = "0x180AB5A80")]
	public void SetActiveAddCard(bool enabled)
	{
	}

	[Token(Token = "0x6006612")]
	[Address(RVA = "0x42FF70", Offset = "0x42F170", VA = "0x18042FF70")]
	public void SetOnClickRemoveCardCallBack(UnityAction callback)
	{
	}

	[Token(Token = "0x6006613")]
	[Address(RVA = "0xAB5C30", Offset = "0xAB4E30", VA = "0x180AB5C30")]
	public void SetActiveRemove(bool enabled)
	{
	}

	[Token(Token = "0x6006614")]
	[Address(RVA = "0x3DAE90", Offset = "0x3DA090", VA = "0x1803DAE90")]
	public void SetOnClickCardImage(UnityAction callback)
	{
	}

	[Token(Token = "0x6006615")]
	[Address(RVA = "0xAB5F20", Offset = "0xAB5120", VA = "0x180AB5F20")]
	public void SetCardButtonShortcutKey(SelectorManager.KeyType keyMain, SelectorManager.KeyType keySub)
	{
	}

	[Token(Token = "0x6006616")]
	[Address(RVA = "0xAB56B0", Offset = "0xAB48B0", VA = "0x180AB56B0")]
	public RectTransform GetCardImageRectTransform()
	{
		return null;
	}

	[Token(Token = "0x6006617")]
	[Address(RVA = "0xAB7080", Offset = "0xAB6280", VA = "0x180AB7080")]
	public void SetDefaultMode()
	{
	}

	[Token(Token = "0x6006618")]
	[Address(RVA = "0xAB7150", Offset = "0xAB6350", VA = "0x180AB7150")]
	public void SetDimsmantleMode(bool isLocked)
	{
	}

	[Token(Token = "0x6006619")]
	[Address(RVA = "0xAB73E0", Offset = "0xAB65E0", VA = "0x180AB73E0")]
	public void SetLockMode()
	{
	}

	[Token(Token = "0x600661A")]
	[Address(RVA = "0xAB5C60", Offset = "0xAB4E60", VA = "0x180AB5C60")]
	public void SetActiveSubMenuButton(bool activeRelatedCard, bool activeSourceButton)
	{
	}

	[Token(Token = "0x600661B")]
	[Address(RVA = "0xAB5BB0", Offset = "0xAB4DB0", VA = "0x180AB5BB0")]
	public void SetActiveCardMenu(bool b)
	{
	}

	[Token(Token = "0x600661C")]
	[Address(RVA = "0x3D2BD0", Offset = "0x3D1DD0", VA = "0x1803D2BD0")]
	public CardDetailView()
	{
	}
}
