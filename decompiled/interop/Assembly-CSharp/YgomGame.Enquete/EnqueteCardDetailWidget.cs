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

namespace YgomGame.Enquete;

[Token(Token = "0x2000E0C")]
public class EnqueteCardDetailWidget : MonoBehaviour
{
	[Token(Token = "0x2000E0D")]
	public abstract class ElementWidget : MonoBehaviour
	{
		[Token(Token = "0x400A1EB")]
		[FieldOffset(Offset = "0x20")]
		protected ElementObjectManager m_Eom;

		[Token(Token = "0x400A1EC")]
		[FieldOffset(Offset = "0x28")]
		protected bool isInitialized;

		[Token(Token = "0x17000C9B")]
		public bool isIni
		{
			[Token(Token = "0x60054FB")]
			[Address(RVA = "0x588F60", Offset = "0x588160", VA = "0x180588F60")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60054FC")]
		[Address(RVA = "0x99DE90", Offset = "0x99D090", VA = "0x18099DE90")]
		public void Initialize()
		{
		}

		[Token(Token = "0x60054FD")]
		[Address(RVA = "0x99DE80", Offset = "0x99D080", VA = "0x18099DE80")]
		private void Awake()
		{
		}

		[Token(Token = "0x60054FE")]
		protected abstract void InitializeElements();

		[Token(Token = "0x60054FF")]
		[Address(RVA = "0x3D2BD0", Offset = "0x3D1DD0", VA = "0x1803D2BD0")]
		protected ElementWidget()
		{
		}
	}

	[Token(Token = "0x2000E0E")]
	private class TitleArea : ElementWidget
	{
		[Token(Token = "0x17000C9C")]
		public RubyTextGX m_CardName
		{
			[Token(Token = "0x6005500")]
			[Address(RVA = "0x402CE0", Offset = "0x401EE0", VA = "0x180402CE0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6005501")]
			[Address(RVA = "0x4130D0", Offset = "0x4122D0", VA = "0x1804130D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000C9D")]
		public RectTransform m_NameArea
		{
			[Token(Token = "0x6005502")]
			[Address(RVA = "0x404860", Offset = "0x403A60", VA = "0x180404860")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6005503")]
			[Address(RVA = "0x595520", Offset = "0x594720", VA = "0x180595520")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000C9E")]
		public Image m_NameAreaBG
		{
			[Token(Token = "0x6005504")]
			[Address(RVA = "0x404850", Offset = "0x403A50", VA = "0x180404850")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6005505")]
			[Address(RVA = "0x595530", Offset = "0x594730", VA = "0x180595530")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000C9F")]
		public Image m_AttrIcon
		{
			[Token(Token = "0x6005506")]
			[Address(RVA = "0x414E80", Offset = "0x414080", VA = "0x180414E80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6005507")]
			[Address(RVA = "0x414E90", Offset = "0x414090", VA = "0x180414E90")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x6005508")]
		[Address(RVA = "0x9ABB70", Offset = "0x9AAD70", VA = "0x1809ABB70", Slot = "4")]
		protected override void InitializeElements()
		{
		}

		[Token(Token = "0x6005509")]
		[Address(RVA = "0x3D2BD0", Offset = "0x3D1DD0", VA = "0x1803D2BD0")]
		public TitleArea()
		{
		}
	}

	[Token(Token = "0x2000E0F")]
	public class CardArea : ElementWidget
	{
		[Token(Token = "0x400A1F1")]
		[FieldOffset(Offset = "0x30")]
		private int m_CardID;

		[Token(Token = "0x400A1F2")]
		[FieldOffset(Offset = "0x34")]
		private CardCollectionInfo.Premium m_Premium;

		[Token(Token = "0x17000CA0")]
		public RawImage m_CardImage
		{
			[Token(Token = "0x600550C")]
			[Address(RVA = "0x404860", Offset = "0x403A60", VA = "0x180404860")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600550D")]
			[Address(RVA = "0x595520", Offset = "0x594720", VA = "0x180595520")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000CA1")]
		public Image m_RarityIcon
		{
			[Token(Token = "0x600550E")]
			[Address(RVA = "0x404850", Offset = "0x403A50", VA = "0x180404850")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600550F")]
			[Address(RVA = "0x595530", Offset = "0x594730", VA = "0x180595530")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000CA2")]
		public SelectionButton m_CardButton
		{
			[Token(Token = "0x6005510")]
			[Address(RVA = "0x414E80", Offset = "0x414080", VA = "0x180414E80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6005511")]
			[Address(RVA = "0x414E90", Offset = "0x414090", VA = "0x180414E90")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x600550A")]
		[Address(RVA = "0x99C310", Offset = "0x99B510", VA = "0x18099C310")]
		public void SetCard(int cardId, CardCollectionInfo.Premium premium)
		{
		}

		[Token(Token = "0x600550B")]
		[Address(RVA = "0x99C190", Offset = "0x99B390", VA = "0x18099C190", Slot = "4")]
		protected override void InitializeElements()
		{
		}

		[Token(Token = "0x6005512")]
		[Address(RVA = "0x99C070", Offset = "0x99B270", VA = "0x18099C070")]
		private void InitializeCardImage()
		{
		}

		[Token(Token = "0x6005513")]
		[Address(RVA = "0x99C320", Offset = "0x99B520", VA = "0x18099C320")]
		public CardArea()
		{
		}
	}

	[Token(Token = "0x2000E10")]
	private class ParameterArea : ElementWidget
	{
		[Token(Token = "0x2000E11")]
		public class ParamIcon : ElementWidget
		{
			[Token(Token = "0x17000CAE")]
			public Image m_IconImage
			{
				[Token(Token = "0x600552C")]
				[Address(RVA = "0x402CE0", Offset = "0x401EE0", VA = "0x180402CE0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x600552D")]
				[Address(RVA = "0x4130D0", Offset = "0x4122D0", VA = "0x1804130D0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x17000CAF")]
			public ExtendedTextMeshProUGUI m_IconText
			{
				[Token(Token = "0x600552E")]
				[Address(RVA = "0x404860", Offset = "0x403A60", VA = "0x180404860")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x600552F")]
				[Address(RVA = "0x595520", Offset = "0x594720", VA = "0x180595520")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x6005530")]
			[Address(RVA = "0x9A8A00", Offset = "0x9A7C00", VA = "0x1809A8A00", Slot = "4")]
			protected override void InitializeElements()
			{
			}

			[Token(Token = "0x6005531")]
			[Address(RVA = "0x3D2BD0", Offset = "0x3D1DD0", VA = "0x1803D2BD0")]
			public ParamIcon()
			{
			}
		}

		[Token(Token = "0x17000CA3")]
		public ParamIcon m_TunerIcon
		{
			[Token(Token = "0x6005514")]
			[Address(RVA = "0x402CE0", Offset = "0x401EE0", VA = "0x180402CE0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6005515")]
			[Address(RVA = "0x4130D0", Offset = "0x4122D0", VA = "0x1804130D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000CA4")]
		public ParamIcon m_TypeIcon
		{
			[Token(Token = "0x6005516")]
			[Address(RVA = "0x404860", Offset = "0x403A60", VA = "0x180404860")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6005517")]
			[Address(RVA = "0x595520", Offset = "0x594720", VA = "0x180595520")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000CA5")]
		public ParamIcon m_PendScaleIcon
		{
			[Token(Token = "0x6005518")]
			[Address(RVA = "0x404850", Offset = "0x403A50", VA = "0x180404850")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6005519")]
			[Address(RVA = "0x595530", Offset = "0x594730", VA = "0x180595530")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000CA6")]
		public ParamIcon m_LvlIcon
		{
			[Token(Token = "0x600551A")]
			[Address(RVA = "0x414E80", Offset = "0x414080", VA = "0x180414E80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600551B")]
			[Address(RVA = "0x414E90", Offset = "0x414090", VA = "0x180414E90")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000CA7")]
		public ParamIcon m_RankIcon
		{
			[Token(Token = "0x600551C")]
			[Address(RVA = "0x580700", Offset = "0x57F900", VA = "0x180580700")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600551D")]
			[Address(RVA = "0x580760", Offset = "0x57F960", VA = "0x180580760")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000CA8")]
		public ParamIcon m_LinkIcon
		{
			[Token(Token = "0x600551E")]
			[Address(RVA = "0x5EA220", Offset = "0x5E9420", VA = "0x1805EA220")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600551F")]
			[Address(RVA = "0x81BD60", Offset = "0x81AF60", VA = "0x18081BD60")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000CA9")]
		public ParamIcon m_AtkIcon
		{
			[Token(Token = "0x6005520")]
			[Address(RVA = "0x589E50", Offset = "0x589050", VA = "0x180589E50")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6005521")]
			[Address(RVA = "0x589E60", Offset = "0x589060", VA = "0x180589E60")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000CAA")]
		public ParamIcon m_DefIcon
		{
			[Token(Token = "0x6005522")]
			[Address(RVA = "0x49B9F0", Offset = "0x49ABF0", VA = "0x18049B9F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6005523")]
			[Address(RVA = "0x49C1F0", Offset = "0x49B3F0", VA = "0x18049C1F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000CAB")]
		public RectTransform m_SpellTrapTypeRoot
		{
			[Token(Token = "0x6005524")]
			[Address(RVA = "0x449820", Offset = "0x448A20", VA = "0x180449820")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6005525")]
			[Address(RVA = "0x3D77E0", Offset = "0x3D69E0", VA = "0x1803D77E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000CAC")]
		public Image m_SpellTrapIconImage
		{
			[Token(Token = "0x6005526")]
			[Address(RVA = "0x49BD10", Offset = "0x49AF10", VA = "0x18049BD10")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6005527")]
			[Address(RVA = "0x4573F0", Offset = "0x4565F0", VA = "0x1804573F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000CAD")]
		public ExtendedTextMeshProUGUI m_SpellTrapIconText
		{
			[Token(Token = "0x6005528")]
			[Address(RVA = "0x49B7F0", Offset = "0x49A9F0", VA = "0x18049B7F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6005529")]
			[Address(RVA = "0x457400", Offset = "0x456600", VA = "0x180457400")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x600552A")]
		[Address(RVA = "0x9A8AA0", Offset = "0x9A7CA0", VA = "0x1809A8AA0", Slot = "4")]
		protected override void InitializeElements()
		{
		}

		[Token(Token = "0x600552B")]
		[Address(RVA = "0x3D2BD0", Offset = "0x3D1DD0", VA = "0x1803D2BD0")]
		public ParameterArea()
		{
		}
	}

	[Token(Token = "0x2000E12")]
	private class MenuArea : ElementWidget
	{
		[Token(Token = "0x17000CB0")]
		public SelectionButton m_AddCardButton
		{
			[Token(Token = "0x6005532")]
			[Address(RVA = "0x402CE0", Offset = "0x401EE0", VA = "0x180402CE0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6005533")]
			[Address(RVA = "0x4130D0", Offset = "0x4122D0", VA = "0x1804130D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000CB1")]
		public SelectionButton m_RemoveCardButton
		{
			[Token(Token = "0x6005534")]
			[Address(RVA = "0x404860", Offset = "0x403A60", VA = "0x180404860")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6005535")]
			[Address(RVA = "0x595520", Offset = "0x594720", VA = "0x180595520")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000CB2")]
		public RectTransform m_CardGroupRoot
		{
			[Token(Token = "0x6005536")]
			[Address(RVA = "0x404850", Offset = "0x403A50", VA = "0x180404850")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6005537")]
			[Address(RVA = "0x595530", Offset = "0x594730", VA = "0x180595530")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x6005538")]
		[Address(RVA = "0x9A8910", Offset = "0x9A7B10", VA = "0x1809A8910", Slot = "4")]
		protected override void InitializeElements()
		{
		}

		[Token(Token = "0x6005539")]
		[Address(RVA = "0x3D2BD0", Offset = "0x3D1DD0", VA = "0x1803D2BD0")]
		public MenuArea()
		{
		}
	}

	[Token(Token = "0x400A1D5")]
	[FieldOffset(Offset = "0x20")]
	private ElementObjectManager m_Eom;

	[Token(Token = "0x400A1D6")]
	[FieldOffset(Offset = "0x28")]
	private bool isIni;

	[Token(Token = "0x400A1D8")]
	[FieldOffset(Offset = "0x30")]
	protected int m_Rarity;

	[Token(Token = "0x400A1D9")]
	[FieldOffset(Offset = "0x38")]
	protected CardIconSprites m_CardIconSprites;

	[Token(Token = "0x400A1DA")]
	[FieldOffset(Offset = "0x40")]
	private TitleArea m_TitleArea;

	[Token(Token = "0x400A1DB")]
	[FieldOffset(Offset = "0x48")]
	protected CardArea m_CardArea;

	[Token(Token = "0x400A1DC")]
	[FieldOffset(Offset = "0x50")]
	private ParameterArea m_ParameterArea;

	[Token(Token = "0x400A1DD")]
	[FieldOffset(Offset = "0x58")]
	private MenuArea m_MenuArea;

	[Token(Token = "0x400A1DE")]
	private const string LABEL_SB_WINDOW = "Window";

	[Token(Token = "0x400A1DF")]
	protected const string LABEL_Tween_AutoScroll = "AutoScroll";

	[Token(Token = "0x400A1E0")]
	[FieldOffset(Offset = "0x60")]
	protected Material m_TextBGMaterial;

	[Token(Token = "0x400A1E1")]
	[FieldOffset(Offset = "0x68")]
	protected ContentSizeFitter m_DescTextSizeFitter;

	[Token(Token = "0x400A1E2")]
	[FieldOffset(Offset = "0x70")]
	protected SelectionButtonUntouchable m_Window;

	[Token(Token = "0x400A1E3")]
	[FieldOffset(Offset = "0x78")]
	private UnityAction m_OnClickAddCard;

	[Token(Token = "0x400A1E4")]
	[FieldOffset(Offset = "0x80")]
	private UnityAction m_OnClickRemoveCard;

	[Token(Token = "0x400A1E5")]
	[FieldOffset(Offset = "0x88")]
	private UnityAction m_OnClickCardButton;

	[Token(Token = "0x400A1E6")]
	[FieldOffset(Offset = "0x90")]
	public ToggleWidget bookmarkToggle;

	[Token(Token = "0x17000C75")]
	public bool isInitialized
	{
		[Token(Token = "0x60054AC")]
		[Address(RVA = "0x588F60", Offset = "0x588160", VA = "0x180588F60")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000C76")]
	protected int m_CardID
	{
		[Token(Token = "0x60054AD")]
		[Address(RVA = "0x6333B0", Offset = "0x6325B0", VA = "0x1806333B0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60054AE")]
		[Address(RVA = "0x7EB190", Offset = "0x7EA390", VA = "0x1807EB190")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x17000C77")]
	public int CardID
	{
		[Token(Token = "0x60054AF")]
		[Address(RVA = "0x6333B0", Offset = "0x6325B0", VA = "0x1806333B0")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000C78")]
	private static Content m_cci
	{
		[Token(Token = "0x60054B0")]
		[Address(RVA = "0x99F9E0", Offset = "0x99EBE0", VA = "0x18099F9E0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000C79")]
	protected Image m_AttrIcon
	{
		[Token(Token = "0x60054B1")]
		[Address(RVA = "0x99F680", Offset = "0x99E880", VA = "0x18099F680")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000C7A")]
	protected Image m_NameAreaBG
	{
		[Token(Token = "0x60054B2")]
		[Address(RVA = "0x99F7E0", Offset = "0x99E9E0", VA = "0x18099F7E0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000C7B")]
	protected RubyTextGX m_CardName
	{
		[Token(Token = "0x60054B3")]
		[Address(RVA = "0x99F6A0", Offset = "0x99E8A0", VA = "0x18099F6A0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000C7C")]
	protected RectTransform m_NameArea
	{
		[Token(Token = "0x60054B4")]
		[Address(RVA = "0x99F800", Offset = "0x99EA00", VA = "0x18099F800")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000C7D")]
	protected SelectionButton m_CardButton
	{
		[Token(Token = "0x60054B5")]
		[Address(RVA = "0x68C980", Offset = "0x68BB80", VA = "0x18068C980")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000C7E")]
	protected RawImage m_CardImage
	{
		[Token(Token = "0x60054B6")]
		[Address(RVA = "0x68DC10", Offset = "0x68CE10", VA = "0x18068DC10")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000C7F")]
	protected Image m_RarityIcon
	{
		[Token(Token = "0x60054B7")]
		[Address(RVA = "0x99F8E0", Offset = "0x99EAE0", VA = "0x18099F8E0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000C80")]
	protected Image m_TunerIcon
	{
		[Token(Token = "0x60054B8")]
		[Address(RVA = "0x99F980", Offset = "0x99EB80", VA = "0x18099F980")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000C81")]
	protected Image m_TypeIcon
	{
		[Token(Token = "0x60054B9")]
		[Address(RVA = "0x99F9B0", Offset = "0x99EBB0", VA = "0x18099F9B0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000C82")]
	protected Image m_PendScaleIcon
	{
		[Token(Token = "0x60054BA")]
		[Address(RVA = "0x99F820", Offset = "0x99EA20", VA = "0x18099F820")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000C83")]
	protected Image m_LvlIcon
	{
		[Token(Token = "0x60054BB")]
		[Address(RVA = "0x99F780", Offset = "0x99E980", VA = "0x18099F780")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000C84")]
	protected Image m_RankIcon
	{
		[Token(Token = "0x60054BC")]
		[Address(RVA = "0x99F880", Offset = "0x99EA80", VA = "0x18099F880")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000C85")]
	protected Image m_LinkIcon
	{
		[Token(Token = "0x60054BD")]
		[Address(RVA = "0x99F720", Offset = "0x99E920", VA = "0x18099F720")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000C86")]
	protected Image m_AtkIcon
	{
		[Token(Token = "0x60054BE")]
		[Address(RVA = "0x99F620", Offset = "0x99E820", VA = "0x18099F620")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000C87")]
	protected Image m_DefIcon
	{
		[Token(Token = "0x60054BF")]
		[Address(RVA = "0x99F6C0", Offset = "0x99E8C0", VA = "0x18099F6C0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000C88")]
	protected ExtendedTextMeshProUGUI m_PendScaleText
	{
		[Token(Token = "0x60054C0")]
		[Address(RVA = "0x99F850", Offset = "0x99EA50", VA = "0x18099F850")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000C89")]
	protected ExtendedTextMeshProUGUI m_LvlText
	{
		[Token(Token = "0x60054C1")]
		[Address(RVA = "0x99F7B0", Offset = "0x99E9B0", VA = "0x18099F7B0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000C8A")]
	protected ExtendedTextMeshProUGUI m_RankText
	{
		[Token(Token = "0x60054C2")]
		[Address(RVA = "0x99F8B0", Offset = "0x99EAB0", VA = "0x18099F8B0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000C8B")]
	protected ExtendedTextMeshProUGUI m_LinkText
	{
		[Token(Token = "0x60054C3")]
		[Address(RVA = "0x99F750", Offset = "0x99E950", VA = "0x18099F750")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000C8C")]
	protected ExtendedTextMeshProUGUI m_AtkText
	{
		[Token(Token = "0x60054C4")]
		[Address(RVA = "0x99F650", Offset = "0x99E850", VA = "0x18099F650")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000C8D")]
	protected ExtendedTextMeshProUGUI m_DefText
	{
		[Token(Token = "0x60054C5")]
		[Address(RVA = "0x99F6F0", Offset = "0x99E8F0", VA = "0x18099F6F0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000C8E")]
	protected RectTransform m_SpellTrapType
	{
		[Token(Token = "0x60054C6")]
		[Address(RVA = "0x99F960", Offset = "0x99EB60", VA = "0x18099F960")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000C8F")]
	protected Image m_SpellTrapTypeIcon
	{
		[Token(Token = "0x60054C7")]
		[Address(RVA = "0x99F920", Offset = "0x99EB20", VA = "0x18099F920")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000C90")]
	protected ExtendedTextMeshProUGUI m_SpellTrapTypeText
	{
		[Token(Token = "0x60054C8")]
		[Address(RVA = "0x99F940", Offset = "0x99EB40", VA = "0x18099F940")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000C91")]
	protected SelectionButton m_AddCardButton
	{
		[Token(Token = "0x60054C9")]
		[Address(RVA = "0x99F600", Offset = "0x99E800", VA = "0x18099F600")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000C92")]
	protected SelectionButton m_RemoveCardButton
	{
		[Token(Token = "0x60054CA")]
		[Address(RVA = "0x99F900", Offset = "0x99EB00", VA = "0x18099F900")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000C93")]
	protected ExtendedTextMeshProUGUI m_DescText
	{
		[Token(Token = "0x60054CB")]
		[Address(RVA = "0x49B7D0", Offset = "0x49A9D0", VA = "0x18049B7D0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000C94")]
	protected ExtendedTextMeshProUGUI m_DescTitleText
	{
		[Token(Token = "0x60054CC")]
		[Address(RVA = "0x49BDF0", Offset = "0x49AFF0", VA = "0x18049BDF0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000C95")]
	protected Image m_DescAreaBG
	{
		[Token(Token = "0x60054CD")]
		[Address(RVA = "0x49BB20", Offset = "0x49AD20", VA = "0x18049BB20")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000C96")]
	protected ExtendedScrollRect m_TextAreaScroll
	{
		[Token(Token = "0x60054CE")]
		[Address(RVA = "0x49B870", Offset = "0x49AA70", VA = "0x18049B870")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000C97")]
	private ExtendedScrollRect m_TextArea
	{
		[Token(Token = "0x60054CF")]
		[Address(RVA = "0x49B870", Offset = "0x49AA70", VA = "0x18049B870")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x60054D0")]
		[Address(RVA = "0x42FFD0", Offset = "0x42F1D0", VA = "0x18042FFD0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x17000C98")]
	private ExtendedTextMeshProUGUI m_CardDesc
	{
		[Token(Token = "0x60054D1")]
		[Address(RVA = "0x49B7D0", Offset = "0x49A9D0", VA = "0x18049B7D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x60054D2")]
		[Address(RVA = "0x42FF10", Offset = "0x42F110", VA = "0x18042FF10")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x17000C99")]
	private ExtendedTextMeshProUGUI m_CardDescHeading
	{
		[Token(Token = "0x60054D3")]
		[Address(RVA = "0x49BDF0", Offset = "0x49AFF0", VA = "0x18049BDF0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x60054D4")]
		[Address(RVA = "0x42FF30", Offset = "0x42F130", VA = "0x18042FF30")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x17000C9A")]
	private Image m_DescAreaBG_
	{
		[Token(Token = "0x60054D5")]
		[Address(RVA = "0x49BB20", Offset = "0x49AD20", VA = "0x18049BB20")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x60054D6")]
		[Address(RVA = "0x42FF50", Offset = "0x42F150", VA = "0x18042FF50")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x60054D7")]
	[Address(RVA = "0x99E600", Offset = "0x99D800", VA = "0x18099E600")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x60054D8")]
	[Address(RVA = "0x99DF40", Offset = "0x99D140", VA = "0x18099DF40")]
	private void InitializeElements()
	{
	}

	[Token(Token = "0x60054D9")]
	[Address(RVA = "0x99E2D0", Offset = "0x99D4D0", VA = "0x18099E2D0")]
	public void Initialize()
	{
	}

	[Token(Token = "0x60054DA")]
	[Address(RVA = "0x99F510", Offset = "0x99E710", VA = "0x18099F510")]
	private void Start()
	{
	}

	[Token(Token = "0x60054DB")]
	[Address(RVA = "0x99FC70", Offset = "0x99EE70", VA = "0x18099FC70")]
	protected void setCardImage()
	{
	}

	[Token(Token = "0x60054DC")]
	[Address(RVA = "0x99FD20", Offset = "0x99EF20", VA = "0x18099FD20")]
	protected void setCardName()
	{
	}

	[Token(Token = "0x60054DD")]
	[Address(RVA = "0x9A09B0", Offset = "0x99FBB0", VA = "0x1809A09B0")]
	protected void setTextBGMat()
	{
	}

	[Token(Token = "0x60054DE")]
	[Address(RVA = "0x99FE00", Offset = "0x99F000", VA = "0x18099FE00")]
	protected void setCardText()
	{
	}

	[Token(Token = "0x60054DF")]
	[Address(RVA = "0x99FBD0", Offset = "0x99EDD0", VA = "0x18099FBD0")]
	protected void setAttribute()
	{
	}

	[Token(Token = "0x60054E0")]
	[Address(RVA = "0x99FA70", Offset = "0x99EC70", VA = "0x18099FA70")]
	protected void setAttack()
	{
	}

	[Token(Token = "0x60054E1")]
	[Address(RVA = "0x9A0040", Offset = "0x99F240", VA = "0x1809A0040")]
	protected void setDefence()
	{
	}

	[Token(Token = "0x60054E2")]
	[Address(RVA = "0x9A0A00", Offset = "0x99FC00", VA = "0x1809A0A00")]
	protected void setTuner()
	{
	}

	[Token(Token = "0x60054E3")]
	[Address(RVA = "0x9A0530", Offset = "0x99F730", VA = "0x1809A0530")]
	protected void setPendulumScale()
	{
	}

	[Token(Token = "0x60054E4")]
	[Address(RVA = "0x9A0350", Offset = "0x99F550", VA = "0x1809A0350")]
	protected void setLevel()
	{
	}

	[Token(Token = "0x60054E5")]
	[Address(RVA = "0x9A0620", Offset = "0x99F820", VA = "0x1809A0620")]
	protected void setRank()
	{
	}

	[Token(Token = "0x60054E6")]
	[Address(RVA = "0x9A0440", Offset = "0x99F640", VA = "0x1809A0440")]
	protected void setLinkRating()
	{
	}

	[Token(Token = "0x60054E7")]
	[Address(RVA = "0x9A0A70", Offset = "0x99FC70", VA = "0x1809A0A70")]
	protected void setType()
	{
	}

	[Token(Token = "0x60054E8")]
	[Address(RVA = "0x9A0810", Offset = "0x99FA10", VA = "0x1809A0810")]
	protected void setSpellTrapType()
	{
	}

	[Token(Token = "0x60054E9")]
	[Address(RVA = "0x9A0710", Offset = "0x99F910", VA = "0x1809A0710")]
	protected void setRarity()
	{
	}

	[Token(Token = "0x60054EA")]
	[Address(RVA = "0x9A01D0", Offset = "0x99F3D0", VA = "0x1809A01D0")]
	protected void setDescriptionTitle()
	{
	}

	[Token(Token = "0x60054EB")]
	[Address(RVA = "0x99E680", Offset = "0x99D880", VA = "0x18099E680")]
	public void SetActiveButtons(bool b)
	{
	}

	[Token(Token = "0x60054EC")]
	[Address(RVA = "0x99E7B0", Offset = "0x99D9B0", VA = "0x18099E7B0")]
	public void SetBlank(bool b)
	{
	}

	[Token(Token = "0x60054ED")]
	[Address(RVA = "0x99E9C0", Offset = "0x99DBC0", VA = "0x18099E9C0", Slot = "4")]
	public virtual void SetCard(int mrk)
	{
	}

	[Token(Token = "0x60054EE")]
	[Address(RVA = "0x4573F0", Offset = "0x4565F0", VA = "0x1804573F0")]
	public void SetOnClickAddCardCallBack(UnityAction callback)
	{
	}

	[Token(Token = "0x60054EF")]
	[Address(RVA = "0x99E650", Offset = "0x99D850", VA = "0x18099E650")]
	public void SetActiveAddCard(bool enabled)
	{
	}

	[Token(Token = "0x60054F0")]
	[Address(RVA = "0x457400", Offset = "0x456600", VA = "0x180457400")]
	public void SetOnClickRemoveCardCallBack(UnityAction callback)
	{
	}

	[Token(Token = "0x60054F1")]
	[Address(RVA = "0x99E780", Offset = "0x99D980", VA = "0x18099E780")]
	public void SetActiveRemove(bool enabled)
	{
	}

	[Token(Token = "0x60054F2")]
	[Address(RVA = "0x457410", Offset = "0x456610", VA = "0x180457410")]
	public void SetOnClickCardImage(UnityAction callback)
	{
	}

	[Token(Token = "0x60054F3")]
	[Address(RVA = "0x99E990", Offset = "0x99DB90", VA = "0x18099E990")]
	public void SetCardButtonShortcutKey(SelectorManager.KeyType keyMain, SelectorManager.KeyType keySub)
	{
	}

	[Token(Token = "0x60054F4")]
	[Address(RVA = "0x99DF10", Offset = "0x99D110", VA = "0x18099DF10")]
	public RectTransform GetCardImageRectTransform()
	{
		return null;
	}

	[Token(Token = "0x60054F5")]
	[Address(RVA = "0x99E700", Offset = "0x99D900", VA = "0x18099E700")]
	public void SetActiveCardMenu(bool b)
	{
	}

	[Token(Token = "0x60054F6")]
	[Address(RVA = "0x3D2BD0", Offset = "0x3D1DD0", VA = "0x1803D2BD0")]
	public EnqueteCardDetailWidget()
	{
	}
}
