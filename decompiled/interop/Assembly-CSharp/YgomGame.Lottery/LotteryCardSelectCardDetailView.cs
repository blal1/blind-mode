using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using YgomGame.Card;
using YgomGame.Deck;
using YgomSystem.ElementSystem;
using YgomSystem.UI;
using YgomSystem.UI.ElementWidget;
using YgomSystem.YGomTMPro;

namespace YgomGame.Lottery;

[Token(Token = "0x20016EA")]
[RequireComponent(typeof(ElementObjectManager))]
public class LotteryCardSelectCardDetailView : MonoBehaviour
{
	[Token(Token = "0x20016EB")]
	public abstract class ElementWidget : MonoBehaviour
	{
		[Token(Token = "0x400D95A")]
		[FieldOffset(Offset = "0x20")]
		protected ElementObjectManager m_Eom;

		[Token(Token = "0x400D95B")]
		[FieldOffset(Offset = "0x28")]
		protected bool isInitialized;

		[Token(Token = "0x17001604")]
		public bool isIni
		{
			[Token(Token = "0x6008F3A")]
			[Address(RVA = "0x588F60", Offset = "0x588160", VA = "0x180588F60")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6008F3B")]
		[Address(RVA = "0xD91930", Offset = "0xD90B30", VA = "0x180D91930")]
		public void Initialize()
		{
		}

		[Token(Token = "0x6008F3C")]
		[Address(RVA = "0xD918A0", Offset = "0xD90AA0", VA = "0x180D918A0")]
		private void Awake()
		{
		}

		[Token(Token = "0x6008F3D")]
		protected abstract void InitializeElements();

		[Token(Token = "0x6008F3E")]
		[Address(RVA = "0x3D2BD0", Offset = "0x3D1DD0", VA = "0x1803D2BD0")]
		protected ElementWidget()
		{
		}
	}

	[Token(Token = "0x20016EC")]
	private class TitleArea : ElementWidget
	{
		[Token(Token = "0x17001605")]
		public RubyTextGX m_CardName
		{
			[Token(Token = "0x6008F3F")]
			[Address(RVA = "0x402CE0", Offset = "0x401EE0", VA = "0x180402CE0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6008F40")]
			[Address(RVA = "0x4130D0", Offset = "0x4122D0", VA = "0x1804130D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17001606")]
		public RectTransform m_NameArea
		{
			[Token(Token = "0x6008F41")]
			[Address(RVA = "0x404860", Offset = "0x403A60", VA = "0x180404860")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6008F42")]
			[Address(RVA = "0x595520", Offset = "0x594720", VA = "0x180595520")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17001607")]
		public Image m_NameAreaBG
		{
			[Token(Token = "0x6008F43")]
			[Address(RVA = "0x404850", Offset = "0x403A50", VA = "0x180404850")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6008F44")]
			[Address(RVA = "0x595530", Offset = "0x594730", VA = "0x180595530")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17001608")]
		public Image m_AttrIcon
		{
			[Token(Token = "0x6008F45")]
			[Address(RVA = "0x414E80", Offset = "0x414080", VA = "0x180414E80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6008F46")]
			[Address(RVA = "0x414E90", Offset = "0x414090", VA = "0x180414E90")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x6008F47")]
		[Address(RVA = "0xDA5630", Offset = "0xDA4830", VA = "0x180DA5630", Slot = "4")]
		protected override void InitializeElements()
		{
		}

		[Token(Token = "0x6008F48")]
		[Address(RVA = "0x3D2BD0", Offset = "0x3D1DD0", VA = "0x1803D2BD0")]
		public TitleArea()
		{
		}
	}

	[Token(Token = "0x20016ED")]
	public class CardArea : ElementWidget
	{
		[Token(Token = "0x400D960")]
		[FieldOffset(Offset = "0x30")]
		private int m_CardID;

		[Token(Token = "0x400D961")]
		[FieldOffset(Offset = "0x34")]
		private CardCollectionInfo.Premium m_Premium;

		[Token(Token = "0x17001609")]
		public RawImage m_CardImage
		{
			[Token(Token = "0x6008F4B")]
			[Address(RVA = "0x404860", Offset = "0x403A60", VA = "0x180404860")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6008F4C")]
			[Address(RVA = "0x595520", Offset = "0x594720", VA = "0x180595520")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700160A")]
		public Image m_RarityIcon
		{
			[Token(Token = "0x6008F4D")]
			[Address(RVA = "0x404850", Offset = "0x403A50", VA = "0x180404850")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6008F4E")]
			[Address(RVA = "0x595530", Offset = "0x594730", VA = "0x180595530")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700160B")]
		public SelectionButton m_CardButton
		{
			[Token(Token = "0x6008F4F")]
			[Address(RVA = "0x414E80", Offset = "0x414080", VA = "0x180414E80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6008F50")]
			[Address(RVA = "0x414E90", Offset = "0x414090", VA = "0x180414E90")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x6008F49")]
		[Address(RVA = "0x99C310", Offset = "0x99B510", VA = "0x18099C310")]
		public void SetCard(int cardId, CardCollectionInfo.Premium premium)
		{
		}

		[Token(Token = "0x6008F4A")]
		[Address(RVA = "0xD911C0", Offset = "0xD903C0", VA = "0x180D911C0", Slot = "4")]
		protected override void InitializeElements()
		{
		}

		[Token(Token = "0x6008F51")]
		[Address(RVA = "0xD910C0", Offset = "0xD902C0", VA = "0x180D910C0")]
		private void InitializeCardImage()
		{
		}

		[Token(Token = "0x6008F52")]
		[Address(RVA = "0x99C320", Offset = "0x99B520", VA = "0x18099C320")]
		public CardArea()
		{
		}
	}

	[Token(Token = "0x20016EE")]
	private class ParameterArea : ElementWidget
	{
		[Token(Token = "0x20016EF")]
		public class ParamIcon : ElementWidget
		{
			[Token(Token = "0x17001617")]
			public Image m_IconImage
			{
				[Token(Token = "0x6008F6B")]
				[Address(RVA = "0x402CE0", Offset = "0x401EE0", VA = "0x180402CE0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x6008F6C")]
				[Address(RVA = "0x4130D0", Offset = "0x4122D0", VA = "0x1804130D0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x17001618")]
			public ExtendedTextMeshProUGUI m_IconText
			{
				[Token(Token = "0x6008F6D")]
				[Address(RVA = "0x404860", Offset = "0x403A60", VA = "0x180404860")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x6008F6E")]
				[Address(RVA = "0x595520", Offset = "0x594720", VA = "0x180595520")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x6008F6F")]
			[Address(RVA = "0xDA4D90", Offset = "0xDA3F90", VA = "0x180DA4D90", Slot = "4")]
			protected override void InitializeElements()
			{
			}

			[Token(Token = "0x6008F70")]
			[Address(RVA = "0x3D2BD0", Offset = "0x3D1DD0", VA = "0x1803D2BD0")]
			public ParamIcon()
			{
			}
		}

		[Token(Token = "0x1700160C")]
		public ParamIcon m_TunerIcon
		{
			[Token(Token = "0x6008F53")]
			[Address(RVA = "0x402CE0", Offset = "0x401EE0", VA = "0x180402CE0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6008F54")]
			[Address(RVA = "0x4130D0", Offset = "0x4122D0", VA = "0x1804130D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700160D")]
		public ParamIcon m_TypeIcon
		{
			[Token(Token = "0x6008F55")]
			[Address(RVA = "0x404860", Offset = "0x403A60", VA = "0x180404860")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6008F56")]
			[Address(RVA = "0x595520", Offset = "0x594720", VA = "0x180595520")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700160E")]
		public ParamIcon m_PendScaleIcon
		{
			[Token(Token = "0x6008F57")]
			[Address(RVA = "0x404850", Offset = "0x403A50", VA = "0x180404850")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6008F58")]
			[Address(RVA = "0x595530", Offset = "0x594730", VA = "0x180595530")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700160F")]
		public ParamIcon m_LvlIcon
		{
			[Token(Token = "0x6008F59")]
			[Address(RVA = "0x414E80", Offset = "0x414080", VA = "0x180414E80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6008F5A")]
			[Address(RVA = "0x414E90", Offset = "0x414090", VA = "0x180414E90")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17001610")]
		public ParamIcon m_RankIcon
		{
			[Token(Token = "0x6008F5B")]
			[Address(RVA = "0x580700", Offset = "0x57F900", VA = "0x180580700")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6008F5C")]
			[Address(RVA = "0x580760", Offset = "0x57F960", VA = "0x180580760")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17001611")]
		public ParamIcon m_LinkIcon
		{
			[Token(Token = "0x6008F5D")]
			[Address(RVA = "0x5EA220", Offset = "0x5E9420", VA = "0x1805EA220")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6008F5E")]
			[Address(RVA = "0x81BD60", Offset = "0x81AF60", VA = "0x18081BD60")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17001612")]
		public ParamIcon m_AtkIcon
		{
			[Token(Token = "0x6008F5F")]
			[Address(RVA = "0x589E50", Offset = "0x589050", VA = "0x180589E50")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6008F60")]
			[Address(RVA = "0x589E60", Offset = "0x589060", VA = "0x180589E60")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17001613")]
		public ParamIcon m_DefIcon
		{
			[Token(Token = "0x6008F61")]
			[Address(RVA = "0x49B9F0", Offset = "0x49ABF0", VA = "0x18049B9F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6008F62")]
			[Address(RVA = "0x49C1F0", Offset = "0x49B3F0", VA = "0x18049C1F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17001614")]
		public RectTransform m_SpellTrapTypeRoot
		{
			[Token(Token = "0x6008F63")]
			[Address(RVA = "0x449820", Offset = "0x448A20", VA = "0x180449820")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6008F64")]
			[Address(RVA = "0x3D77E0", Offset = "0x3D69E0", VA = "0x1803D77E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17001615")]
		public Image m_SpellTrapIconImage
		{
			[Token(Token = "0x6008F65")]
			[Address(RVA = "0x49BD10", Offset = "0x49AF10", VA = "0x18049BD10")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6008F66")]
			[Address(RVA = "0x4573F0", Offset = "0x4565F0", VA = "0x1804573F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17001616")]
		public ExtendedTextMeshProUGUI m_SpellTrapIconText
		{
			[Token(Token = "0x6008F67")]
			[Address(RVA = "0x49B7F0", Offset = "0x49A9F0", VA = "0x18049B7F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6008F68")]
			[Address(RVA = "0x457400", Offset = "0x456600", VA = "0x180457400")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x6008F69")]
		[Address(RVA = "0xDA4E30", Offset = "0xDA4030", VA = "0x180DA4E30", Slot = "4")]
		protected override void InitializeElements()
		{
		}

		[Token(Token = "0x6008F6A")]
		[Address(RVA = "0x3D2BD0", Offset = "0x3D1DD0", VA = "0x1803D2BD0")]
		public ParameterArea()
		{
		}
	}

	[Token(Token = "0x20016F0")]
	private class MenuArea : ElementWidget
	{
		[Token(Token = "0x17001619")]
		public SelectionButton m_AddCardButton
		{
			[Token(Token = "0x6008F71")]
			[Address(RVA = "0x402CE0", Offset = "0x401EE0", VA = "0x180402CE0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6008F72")]
			[Address(RVA = "0x4130D0", Offset = "0x4122D0", VA = "0x1804130D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700161A")]
		public SelectionButton m_RemoveCardButton
		{
			[Token(Token = "0x6008F73")]
			[Address(RVA = "0x404860", Offset = "0x403A60", VA = "0x180404860")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6008F74")]
			[Address(RVA = "0x595520", Offset = "0x594720", VA = "0x180595520")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700161B")]
		public RectTransform m_CardGroupRoot
		{
			[Token(Token = "0x6008F75")]
			[Address(RVA = "0x404850", Offset = "0x403A50", VA = "0x180404850")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6008F76")]
			[Address(RVA = "0x595530", Offset = "0x594730", VA = "0x180595530")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x6008F77")]
		[Address(RVA = "0xDA4890", Offset = "0xDA3A90", VA = "0x180DA4890", Slot = "4")]
		protected override void InitializeElements()
		{
		}

		[Token(Token = "0x6008F78")]
		[Address(RVA = "0x3D2BD0", Offset = "0x3D1DD0", VA = "0x1803D2BD0")]
		public MenuArea()
		{
		}
	}

	[Token(Token = "0x400D944")]
	[FieldOffset(Offset = "0x20")]
	private ElementObjectManager m_Eom;

	[Token(Token = "0x400D945")]
	[FieldOffset(Offset = "0x28")]
	private bool isIni;

	[Token(Token = "0x400D947")]
	[FieldOffset(Offset = "0x30")]
	protected int m_Rarity;

	[Token(Token = "0x400D948")]
	[FieldOffset(Offset = "0x38")]
	protected CardIconSprites m_CardIconSprites;

	[Token(Token = "0x400D949")]
	[FieldOffset(Offset = "0x40")]
	private TitleArea m_TitleArea;

	[Token(Token = "0x400D94A")]
	[FieldOffset(Offset = "0x48")]
	protected CardArea m_CardArea;

	[Token(Token = "0x400D94B")]
	[FieldOffset(Offset = "0x50")]
	private ParameterArea m_ParameterArea;

	[Token(Token = "0x400D94C")]
	[FieldOffset(Offset = "0x58")]
	private MenuArea m_MenuArea;

	[Token(Token = "0x400D94D")]
	private const string LABEL_SB_WINDOW = "Window";

	[Token(Token = "0x400D94E")]
	protected const string LABEL_Tween_AutoScroll = "AutoScroll";

	[Token(Token = "0x400D94F")]
	[FieldOffset(Offset = "0x60")]
	protected Material m_TextBGMaterial;

	[Token(Token = "0x400D950")]
	[FieldOffset(Offset = "0x68")]
	protected ContentSizeFitter m_DescTextSizeFitter;

	[Token(Token = "0x400D951")]
	[FieldOffset(Offset = "0x70")]
	protected SelectionButtonUntouchable m_Window;

	[Token(Token = "0x400D952")]
	[FieldOffset(Offset = "0x78")]
	private UnityAction m_OnClickAddCard;

	[Token(Token = "0x400D953")]
	[FieldOffset(Offset = "0x80")]
	private UnityAction m_OnClickRemoveCard;

	[Token(Token = "0x400D954")]
	[FieldOffset(Offset = "0x88")]
	private UnityAction m_OnClickCardButton;

	[Token(Token = "0x400D955")]
	[FieldOffset(Offset = "0x90")]
	public ToggleWidget bookmarkToggle;

	[Token(Token = "0x170015E0")]
	protected int m_CardID
	{
		[Token(Token = "0x6008EED")]
		[Address(RVA = "0x6333B0", Offset = "0x6325B0", VA = "0x1806333B0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6008EEE")]
		[Address(RVA = "0x7EB190", Offset = "0x7EA390", VA = "0x1807EB190")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x170015E1")]
	private static Content m_cci
	{
		[Token(Token = "0x6008EEF")]
		[Address(RVA = "0xD95830", Offset = "0xD94A30", VA = "0x180D95830")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170015E2")]
	protected Image m_AttrIcon
	{
		[Token(Token = "0x6008EF0")]
		[Address(RVA = "0x99F680", Offset = "0x99E880", VA = "0x18099F680")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170015E3")]
	protected Image m_NameAreaBG
	{
		[Token(Token = "0x6008EF1")]
		[Address(RVA = "0x99F7E0", Offset = "0x99E9E0", VA = "0x18099F7E0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170015E4")]
	protected RubyTextGX m_CardName
	{
		[Token(Token = "0x6008EF2")]
		[Address(RVA = "0x99F6A0", Offset = "0x99E8A0", VA = "0x18099F6A0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170015E5")]
	protected RectTransform m_NameArea
	{
		[Token(Token = "0x6008EF3")]
		[Address(RVA = "0x99F800", Offset = "0x99EA00", VA = "0x18099F800")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170015E6")]
	protected SelectionButton m_CardButton
	{
		[Token(Token = "0x6008EF4")]
		[Address(RVA = "0x68C980", Offset = "0x68BB80", VA = "0x18068C980")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170015E7")]
	protected RawImage m_CardImage
	{
		[Token(Token = "0x6008EF5")]
		[Address(RVA = "0x68DC10", Offset = "0x68CE10", VA = "0x18068DC10")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170015E8")]
	protected Image m_RarityIcon
	{
		[Token(Token = "0x6008EF6")]
		[Address(RVA = "0x99F8E0", Offset = "0x99EAE0", VA = "0x18099F8E0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170015E9")]
	protected Image m_TunerIcon
	{
		[Token(Token = "0x6008EF7")]
		[Address(RVA = "0x99F980", Offset = "0x99EB80", VA = "0x18099F980")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170015EA")]
	protected Image m_TypeIcon
	{
		[Token(Token = "0x6008EF8")]
		[Address(RVA = "0x99F9B0", Offset = "0x99EBB0", VA = "0x18099F9B0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170015EB")]
	protected Image m_PendScaleIcon
	{
		[Token(Token = "0x6008EF9")]
		[Address(RVA = "0x99F820", Offset = "0x99EA20", VA = "0x18099F820")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170015EC")]
	protected Image m_LvlIcon
	{
		[Token(Token = "0x6008EFA")]
		[Address(RVA = "0x99F780", Offset = "0x99E980", VA = "0x18099F780")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170015ED")]
	protected Image m_RankIcon
	{
		[Token(Token = "0x6008EFB")]
		[Address(RVA = "0x99F880", Offset = "0x99EA80", VA = "0x18099F880")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170015EE")]
	protected Image m_LinkIcon
	{
		[Token(Token = "0x6008EFC")]
		[Address(RVA = "0x99F720", Offset = "0x99E920", VA = "0x18099F720")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170015EF")]
	protected Image m_AtkIcon
	{
		[Token(Token = "0x6008EFD")]
		[Address(RVA = "0x99F620", Offset = "0x99E820", VA = "0x18099F620")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170015F0")]
	protected Image m_DefIcon
	{
		[Token(Token = "0x6008EFE")]
		[Address(RVA = "0x99F6C0", Offset = "0x99E8C0", VA = "0x18099F6C0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170015F1")]
	protected ExtendedTextMeshProUGUI m_PendScaleText
	{
		[Token(Token = "0x6008EFF")]
		[Address(RVA = "0x99F850", Offset = "0x99EA50", VA = "0x18099F850")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170015F2")]
	protected ExtendedTextMeshProUGUI m_LvlText
	{
		[Token(Token = "0x6008F00")]
		[Address(RVA = "0x99F7B0", Offset = "0x99E9B0", VA = "0x18099F7B0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170015F3")]
	protected ExtendedTextMeshProUGUI m_RankText
	{
		[Token(Token = "0x6008F01")]
		[Address(RVA = "0x99F8B0", Offset = "0x99EAB0", VA = "0x18099F8B0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170015F4")]
	protected ExtendedTextMeshProUGUI m_LinkText
	{
		[Token(Token = "0x6008F02")]
		[Address(RVA = "0x99F750", Offset = "0x99E950", VA = "0x18099F750")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170015F5")]
	protected ExtendedTextMeshProUGUI m_AtkText
	{
		[Token(Token = "0x6008F03")]
		[Address(RVA = "0x99F650", Offset = "0x99E850", VA = "0x18099F650")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170015F6")]
	protected ExtendedTextMeshProUGUI m_DefText
	{
		[Token(Token = "0x6008F04")]
		[Address(RVA = "0x99F6F0", Offset = "0x99E8F0", VA = "0x18099F6F0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170015F7")]
	protected RectTransform m_SpellTrapType
	{
		[Token(Token = "0x6008F05")]
		[Address(RVA = "0x99F960", Offset = "0x99EB60", VA = "0x18099F960")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170015F8")]
	protected Image m_SpellTrapTypeIcon
	{
		[Token(Token = "0x6008F06")]
		[Address(RVA = "0x99F920", Offset = "0x99EB20", VA = "0x18099F920")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170015F9")]
	protected ExtendedTextMeshProUGUI m_SpellTrapTypeText
	{
		[Token(Token = "0x6008F07")]
		[Address(RVA = "0x99F940", Offset = "0x99EB40", VA = "0x18099F940")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170015FA")]
	protected SelectionButton m_AddCardButton
	{
		[Token(Token = "0x6008F08")]
		[Address(RVA = "0x99F600", Offset = "0x99E800", VA = "0x18099F600")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170015FB")]
	protected SelectionButton m_RemoveCardButton
	{
		[Token(Token = "0x6008F09")]
		[Address(RVA = "0x99F900", Offset = "0x99EB00", VA = "0x18099F900")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170015FC")]
	protected ExtendedTextMeshProUGUI m_DescText
	{
		[Token(Token = "0x6008F0A")]
		[Address(RVA = "0x49B7D0", Offset = "0x49A9D0", VA = "0x18049B7D0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170015FD")]
	protected ExtendedTextMeshProUGUI m_DescTitleText
	{
		[Token(Token = "0x6008F0B")]
		[Address(RVA = "0x49BDF0", Offset = "0x49AFF0", VA = "0x18049BDF0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170015FE")]
	protected Image m_DescAreaBG
	{
		[Token(Token = "0x6008F0C")]
		[Address(RVA = "0x49BB20", Offset = "0x49AD20", VA = "0x18049BB20")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170015FF")]
	protected ExtendedScrollRect m_TextAreaScroll
	{
		[Token(Token = "0x6008F0D")]
		[Address(RVA = "0x49B870", Offset = "0x49AA70", VA = "0x18049B870")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001600")]
	private ExtendedScrollRect m_TextArea
	{
		[Token(Token = "0x6008F0E")]
		[Address(RVA = "0x49B870", Offset = "0x49AA70", VA = "0x18049B870")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6008F0F")]
		[Address(RVA = "0x42FFD0", Offset = "0x42F1D0", VA = "0x18042FFD0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x17001601")]
	private ExtendedTextMeshProUGUI m_CardDesc
	{
		[Token(Token = "0x6008F10")]
		[Address(RVA = "0x49B7D0", Offset = "0x49A9D0", VA = "0x18049B7D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6008F11")]
		[Address(RVA = "0x42FF10", Offset = "0x42F110", VA = "0x18042FF10")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x17001602")]
	private ExtendedTextMeshProUGUI m_CardDescHeading
	{
		[Token(Token = "0x6008F12")]
		[Address(RVA = "0x49BDF0", Offset = "0x49AFF0", VA = "0x18049BDF0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6008F13")]
		[Address(RVA = "0x42FF30", Offset = "0x42F130", VA = "0x18042FF30")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x17001603")]
	private Image m_DescAreaBG_
	{
		[Token(Token = "0x6008F14")]
		[Address(RVA = "0x49BB20", Offset = "0x49AD20", VA = "0x18049BB20")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6008F15")]
		[Address(RVA = "0x42FF50", Offset = "0x42F150", VA = "0x18042FF50")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x6008F16")]
	[Address(RVA = "0xD94AE0", Offset = "0xD93CE0", VA = "0x180D94AE0")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6008F17")]
	[Address(RVA = "0xD94790", Offset = "0xD93990", VA = "0x180D94790")]
	private void InitializeElements()
	{
	}

	[Token(Token = "0x6008F18")]
	[Address(RVA = "0xD94460", Offset = "0xD93660", VA = "0x180D94460")]
	private void Awake()
	{
	}

	[Token(Token = "0x6008F19")]
	[Address(RVA = "0xD95790", Offset = "0xD94990", VA = "0x180D95790")]
	private void Start()
	{
	}

	[Token(Token = "0x6008F1A")]
	[Address(RVA = "0xD95AC0", Offset = "0xD94CC0", VA = "0x180D95AC0")]
	protected void setCardImage()
	{
	}

	[Token(Token = "0x6008F1B")]
	[Address(RVA = "0xD95B70", Offset = "0xD94D70", VA = "0x180D95B70")]
	protected void setCardName()
	{
	}

	[Token(Token = "0x6008F1C")]
	[Address(RVA = "0xD96800", Offset = "0xD95A00", VA = "0x180D96800")]
	protected void setTextBGMat()
	{
	}

	[Token(Token = "0x6008F1D")]
	[Address(RVA = "0xD95C50", Offset = "0xD94E50", VA = "0x180D95C50")]
	protected void setCardText()
	{
	}

	[Token(Token = "0x6008F1E")]
	[Address(RVA = "0xD95A20", Offset = "0xD94C20", VA = "0x180D95A20")]
	protected void setAttribute()
	{
	}

	[Token(Token = "0x6008F1F")]
	[Address(RVA = "0xD958C0", Offset = "0xD94AC0", VA = "0x180D958C0")]
	protected void setAttack()
	{
	}

	[Token(Token = "0x6008F20")]
	[Address(RVA = "0xD95E90", Offset = "0xD95090", VA = "0x180D95E90")]
	protected void setDefence()
	{
	}

	[Token(Token = "0x6008F21")]
	[Address(RVA = "0xD96850", Offset = "0xD95A50", VA = "0x180D96850")]
	protected void setTuner()
	{
	}

	[Token(Token = "0x6008F22")]
	[Address(RVA = "0xD96380", Offset = "0xD95580", VA = "0x180D96380")]
	protected void setPendulumScale()
	{
	}

	[Token(Token = "0x6008F23")]
	[Address(RVA = "0xD961A0", Offset = "0xD953A0", VA = "0x180D961A0")]
	protected void setLevel()
	{
	}

	[Token(Token = "0x6008F24")]
	[Address(RVA = "0xD96470", Offset = "0xD95670", VA = "0x180D96470")]
	protected void setRank()
	{
	}

	[Token(Token = "0x6008F25")]
	[Address(RVA = "0xD96290", Offset = "0xD95490", VA = "0x180D96290")]
	protected void setLinkRating()
	{
	}

	[Token(Token = "0x6008F26")]
	[Address(RVA = "0xD968C0", Offset = "0xD95AC0", VA = "0x180D968C0")]
	protected void setType()
	{
	}

	[Token(Token = "0x6008F27")]
	[Address(RVA = "0xD96660", Offset = "0xD95860", VA = "0x180D96660")]
	protected void setSpellTrapType()
	{
	}

	[Token(Token = "0x6008F28")]
	[Address(RVA = "0xD96560", Offset = "0xD95760", VA = "0x180D96560")]
	protected void setRarity()
	{
	}

	[Token(Token = "0x6008F29")]
	[Address(RVA = "0xD96020", Offset = "0xD95220", VA = "0x180D96020")]
	protected void setDescriptionTitle()
	{
	}

	[Token(Token = "0x6008F2A")]
	[Address(RVA = "0xD94B30", Offset = "0xD93D30", VA = "0x180D94B30")]
	public void SetActiveButtons(bool b)
	{
	}

	[Token(Token = "0x6008F2B")]
	[Address(RVA = "0x99E7B0", Offset = "0x99D9B0", VA = "0x18099E7B0")]
	public void SetBlank(bool b)
	{
	}

	[Token(Token = "0x6008F2C")]
	[Address(RVA = "0xD94C30", Offset = "0xD93E30", VA = "0x180D94C30", Slot = "4")]
	public virtual void SetCard(CardBaseData data)
	{
	}

	[Token(Token = "0x6008F2D")]
	[Address(RVA = "0x4573F0", Offset = "0x4565F0", VA = "0x1804573F0")]
	public void SetOnClickAddCardCallBack(UnityAction callback)
	{
	}

	[Token(Token = "0x6008F2E")]
	[Address(RVA = "0x99E650", Offset = "0x99D850", VA = "0x18099E650")]
	public void SetActiveAddCard(bool enabled)
	{
	}

	[Token(Token = "0x6008F2F")]
	[Address(RVA = "0x457400", Offset = "0x456600", VA = "0x180457400")]
	public void SetOnClickRemoveCardCallBack(UnityAction callback)
	{
	}

	[Token(Token = "0x6008F30")]
	[Address(RVA = "0x99E780", Offset = "0x99D980", VA = "0x18099E780")]
	public void SetActiveRemove(bool enabled)
	{
	}

	[Token(Token = "0x6008F31")]
	[Address(RVA = "0x457410", Offset = "0x456610", VA = "0x180457410")]
	public void SetOnClickCardImage(UnityAction callback)
	{
	}

	[Token(Token = "0x6008F32")]
	[Address(RVA = "0x99E990", Offset = "0x99DB90", VA = "0x18099E990")]
	public void SetCardButtonShortcutKey(SelectorManager.KeyType keyMain, SelectorManager.KeyType keySub)
	{
	}

	[Token(Token = "0x6008F33")]
	[Address(RVA = "0x99DF10", Offset = "0x99D110", VA = "0x18099DF10")]
	public RectTransform GetCardImageRectTransform()
	{
		return null;
	}

	[Token(Token = "0x6008F34")]
	[Address(RVA = "0xD94BB0", Offset = "0xD93DB0", VA = "0x180D94BB0")]
	public void SetActiveCardMenu(bool b)
	{
	}

	[Token(Token = "0x6008F35")]
	[Address(RVA = "0x3D2BD0", Offset = "0x3D1DD0", VA = "0x1803D2BD0")]
	public LotteryCardSelectCardDetailView()
	{
	}
}
