using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using YgomGame.Card;
using YgomGame.Duel;
using YgomSystem.ElementSystem;
using YgomSystem.UI;
using YgomSystem.YGomTMPro;

namespace YgomGame.Deck;

[Token(Token = "0x2001058")]
public class CardActionMenu : CardUtilWidget
{
	[Token(Token = "0x2001059")]
	public enum TweenType
	{
		[Token(Token = "0x400AE74")]
		Open,
		[Token(Token = "0x400AE75")]
		Close,
		[Token(Token = "0x400AE76")]
		Update,
		[Token(Token = "0x400AE77")]
		Prev,
		[Token(Token = "0x400AE78")]
		Next
	}

	[Token(Token = "0x200105A")]
	private class TitleArea : ElementWidget
	{
		[Token(Token = "0x17000F91")]
		public RubyTextGX m_CardName
		{
			[Token(Token = "0x600635E")]
			[Address(RVA = "0x402CE0", Offset = "0x401EE0", VA = "0x180402CE0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600635F")]
			[Address(RVA = "0x4130D0", Offset = "0x4122D0", VA = "0x1804130D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000F92")]
		public RectTransform m_NameArea
		{
			[Token(Token = "0x6006360")]
			[Address(RVA = "0x404860", Offset = "0x403A60", VA = "0x180404860")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6006361")]
			[Address(RVA = "0x595520", Offset = "0x594720", VA = "0x180595520")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000F93")]
		public Image m_NameAreaBG
		{
			[Token(Token = "0x6006362")]
			[Address(RVA = "0x404850", Offset = "0x403A50", VA = "0x180404850")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6006363")]
			[Address(RVA = "0x595530", Offset = "0x594730", VA = "0x180595530")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000F94")]
		public Image m_AttrIcon
		{
			[Token(Token = "0x6006364")]
			[Address(RVA = "0x414E80", Offset = "0x414080", VA = "0x180414E80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6006365")]
			[Address(RVA = "0x414E90", Offset = "0x414090", VA = "0x180414E90")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x6006366")]
		[Address(RVA = "0xAB1710", Offset = "0xAB0910", VA = "0x180AB1710", Slot = "4")]
		protected override void InitializeElements()
		{
		}

		[Token(Token = "0x6006367")]
		[Address(RVA = "0x3D2BD0", Offset = "0x3D1DD0", VA = "0x1803D2BD0")]
		public TitleArea()
		{
		}
	}

	[Token(Token = "0x200105B")]
	private class ParameterArea : ElementWidget
	{
		[Token(Token = "0x200105C")]
		public class ParamIcon : ElementWidget
		{
			[Token(Token = "0x17000FA0")]
			public Image m_IconImage
			{
				[Token(Token = "0x6006380")]
				[Address(RVA = "0x402CE0", Offset = "0x401EE0", VA = "0x180402CE0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x6006381")]
				[Address(RVA = "0x4130D0", Offset = "0x4122D0", VA = "0x1804130D0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x17000FA1")]
			public ExtendedTextMeshProUGUI m_IconText
			{
				[Token(Token = "0x6006382")]
				[Address(RVA = "0x404860", Offset = "0x403A60", VA = "0x180404860")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x6006383")]
				[Address(RVA = "0x595520", Offset = "0x594720", VA = "0x180595520")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x6006384")]
			[Address(RVA = "0xAAFBC0", Offset = "0xAAEDC0", VA = "0x180AAFBC0", Slot = "4")]
			protected override void InitializeElements()
			{
			}

			[Token(Token = "0x6006385")]
			[Address(RVA = "0x3D2BD0", Offset = "0x3D1DD0", VA = "0x1803D2BD0")]
			public ParamIcon()
			{
			}
		}

		[Token(Token = "0x17000F95")]
		public ParamIcon m_TunerIcon
		{
			[Token(Token = "0x6006368")]
			[Address(RVA = "0x402CE0", Offset = "0x401EE0", VA = "0x180402CE0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6006369")]
			[Address(RVA = "0x4130D0", Offset = "0x4122D0", VA = "0x1804130D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000F96")]
		public ParamIcon m_TypeIcon
		{
			[Token(Token = "0x600636A")]
			[Address(RVA = "0x404860", Offset = "0x403A60", VA = "0x180404860")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600636B")]
			[Address(RVA = "0x595520", Offset = "0x594720", VA = "0x180595520")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000F97")]
		public ParamIcon m_PendScaleIcon
		{
			[Token(Token = "0x600636C")]
			[Address(RVA = "0x404850", Offset = "0x403A50", VA = "0x180404850")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600636D")]
			[Address(RVA = "0x595530", Offset = "0x594730", VA = "0x180595530")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000F98")]
		public ParamIcon m_LvlIcon
		{
			[Token(Token = "0x600636E")]
			[Address(RVA = "0x414E80", Offset = "0x414080", VA = "0x180414E80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600636F")]
			[Address(RVA = "0x414E90", Offset = "0x414090", VA = "0x180414E90")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000F99")]
		public ParamIcon m_RankIcon
		{
			[Token(Token = "0x6006370")]
			[Address(RVA = "0x580700", Offset = "0x57F900", VA = "0x180580700")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6006371")]
			[Address(RVA = "0x580760", Offset = "0x57F960", VA = "0x180580760")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000F9A")]
		public ParamIcon m_LinkIcon
		{
			[Token(Token = "0x6006372")]
			[Address(RVA = "0x5EA220", Offset = "0x5E9420", VA = "0x1805EA220")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6006373")]
			[Address(RVA = "0x81BD60", Offset = "0x81AF60", VA = "0x18081BD60")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000F9B")]
		public ParamIcon m_AtkIcon
		{
			[Token(Token = "0x6006374")]
			[Address(RVA = "0x589E50", Offset = "0x589050", VA = "0x180589E50")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6006375")]
			[Address(RVA = "0x589E60", Offset = "0x589060", VA = "0x180589E60")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000F9C")]
		public ParamIcon m_DefIcon
		{
			[Token(Token = "0x6006376")]
			[Address(RVA = "0x49B9F0", Offset = "0x49ABF0", VA = "0x18049B9F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6006377")]
			[Address(RVA = "0x49C1F0", Offset = "0x49B3F0", VA = "0x18049C1F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000F9D")]
		public RectTransform m_SpellTrapType
		{
			[Token(Token = "0x6006378")]
			[Address(RVA = "0x449820", Offset = "0x448A20", VA = "0x180449820")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6006379")]
			[Address(RVA = "0x3D77E0", Offset = "0x3D69E0", VA = "0x1803D77E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000F9E")]
		public Image m_SpellTrapIconImage
		{
			[Token(Token = "0x600637A")]
			[Address(RVA = "0x49BD10", Offset = "0x49AF10", VA = "0x18049BD10")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600637B")]
			[Address(RVA = "0x4573F0", Offset = "0x4565F0", VA = "0x1804573F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000F9F")]
		public ExtendedTextMeshProUGUI m_SpellTrapIconText
		{
			[Token(Token = "0x600637C")]
			[Address(RVA = "0x49B7F0", Offset = "0x49A9F0", VA = "0x18049B7F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600637D")]
			[Address(RVA = "0x457400", Offset = "0x456600", VA = "0x180457400")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x600637E")]
		[Address(RVA = "0xAAFC60", Offset = "0xAAEE60", VA = "0x180AAFC60", Slot = "4")]
		protected override void InitializeElements()
		{
		}

		[Token(Token = "0x600637F")]
		[Address(RVA = "0x3D2BD0", Offset = "0x3D1DD0", VA = "0x1803D2BD0")]
		public ParameterArea()
		{
		}
	}

	[Token(Token = "0x200105D")]
	private class DescriptionArea : ElementWidget
	{
		[Token(Token = "0x17000FA2")]
		public ExtendedScrollRect m_PendulumTextArea
		{
			[Token(Token = "0x6006386")]
			[Address(RVA = "0x402CE0", Offset = "0x401EE0", VA = "0x180402CE0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6006387")]
			[Address(RVA = "0x4130D0", Offset = "0x4122D0", VA = "0x1804130D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000FA3")]
		public RectTransform m_PendulumDescArea
		{
			[Token(Token = "0x6006388")]
			[Address(RVA = "0x404860", Offset = "0x403A60", VA = "0x180404860")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6006389")]
			[Address(RVA = "0x595520", Offset = "0x594720", VA = "0x180595520")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000FA4")]
		public ExtendedTextMeshProUGUI m_CardDescPend
		{
			[Token(Token = "0x600638A")]
			[Address(RVA = "0x404850", Offset = "0x403A50", VA = "0x180404850")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600638B")]
			[Address(RVA = "0x595530", Offset = "0x594730", VA = "0x180595530")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000FA5")]
		public ExtendedTextMeshProUGUI m_CardDescHeadingPendulum
		{
			[Token(Token = "0x600638C")]
			[Address(RVA = "0x414E80", Offset = "0x414080", VA = "0x180414E80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600638D")]
			[Address(RVA = "0x414E90", Offset = "0x414090", VA = "0x180414E90")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000FA6")]
		public ExtendedScrollRect m_TextArea
		{
			[Token(Token = "0x600638E")]
			[Address(RVA = "0x580700", Offset = "0x57F900", VA = "0x180580700")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600638F")]
			[Address(RVA = "0x580760", Offset = "0x57F960", VA = "0x180580760")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000FA7")]
		public ExtendedTextMeshProUGUI m_CardDesc
		{
			[Token(Token = "0x6006390")]
			[Address(RVA = "0x5EA220", Offset = "0x5E9420", VA = "0x1805EA220")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6006391")]
			[Address(RVA = "0x81BD60", Offset = "0x81AF60", VA = "0x18081BD60")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000FA8")]
		public ExtendedTextMeshProUGUI m_CardDescHeading
		{
			[Token(Token = "0x6006392")]
			[Address(RVA = "0x589E50", Offset = "0x589050", VA = "0x180589E50")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6006393")]
			[Address(RVA = "0x589E60", Offset = "0x589060", VA = "0x180589E60")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000FA9")]
		public Image m_DescAreaBG
		{
			[Token(Token = "0x6006394")]
			[Address(RVA = "0x49B9F0", Offset = "0x49ABF0", VA = "0x18049B9F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6006395")]
			[Address(RVA = "0x49C1F0", Offset = "0x49B3F0", VA = "0x18049C1F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000FAA")]
		public Image m_PendulumDescAreaBG
		{
			[Token(Token = "0x6006396")]
			[Address(RVA = "0x449820", Offset = "0x448A20", VA = "0x180449820")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6006397")]
			[Address(RVA = "0x3D77E0", Offset = "0x3D69E0", VA = "0x1803D77E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x6006398")]
		[Address(RVA = "0xAAE6D0", Offset = "0xAAD8D0", VA = "0x180AAE6D0", Slot = "4")]
		protected override void InitializeElements()
		{
		}

		[Token(Token = "0x6006399")]
		[Address(RVA = "0x3D2BD0", Offset = "0x3D1DD0", VA = "0x1803D2BD0")]
		public DescriptionArea()
		{
		}
	}

	[Token(Token = "0x200105E")]
	private class CardArea : ElementWidget
	{
		[Token(Token = "0x400AE93")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private int m_CardID;

		[Token(Token = "0x400AE94")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private CardCollectionInfo.Premium m_Premium;

		[Token(Token = "0x400AE95")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Image m_RentalImage;

		[Token(Token = "0x400AE96")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private bool m_IsRental;

		[Token(Token = "0x400AE9E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private ElementObjectManager m_PremiumNumGroupEom;

		[Token(Token = "0x400AE9F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private ElementObject m_DismantleCardNumGroup;

		[Token(Token = "0x400AEA0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private ElementObject m_RentalCardTextGroup;

		[Token(Token = "0x400AEA1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private ExtendedTextMeshProUGUI m_PremNum0;

		[Token(Token = "0x400AEA2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private ExtendedTextMeshProUGUI m_PremNum1;

		[Token(Token = "0x400AEA3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private ExtendedTextMeshProUGUI m_PremNum2;

		[Token(Token = "0x400AEA4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Image m_PremSelector0;

		[Token(Token = "0x400AEA5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private Image m_PremSelector1;

		[Token(Token = "0x400AEA6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private Image m_PremSelector2;

		[Token(Token = "0x400AEA7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private Image m_IndicatorRental;

		[Token(Token = "0x400AEA8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private Image m_Indicator0;

		[Token(Token = "0x400AEA9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private Image m_Indicator1;

		[Token(Token = "0x400AEAA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private Image m_Indicator2;

		[Token(Token = "0x400AEAB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private int inDeckR;

		[Token(Token = "0x400AEAC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
		private int inDeckN;

		[Token(Token = "0x400AEAD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private int inDeckP1;

		[Token(Token = "0x400AEAE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
		private int inDeckP2;

		[Token(Token = "0x400AEAF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private List<Image> m_IndicatorsR;

		[Token(Token = "0x400AEB0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private List<Image> m_IndicatorsN;

		[Token(Token = "0x400AEB1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private List<Image> m_IndicatorsP1;

		[Token(Token = "0x400AEB2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private List<Image> m_IndicatorsP2;

		[Token(Token = "0x400AEB3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private int inDeckAlterR;

		[Token(Token = "0x400AEB4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x11C")]
		private int inDeckAlterN;

		[Token(Token = "0x400AEB5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private int inDeckAlterP1;

		[Token(Token = "0x400AEB6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x124")]
		private int inDeckAlterP2;

		[Token(Token = "0x400AEB7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		private List<Image> m_IndicatorsAlterR;

		[Token(Token = "0x400AEB8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private List<Image> m_IndicatorsAlterN;

		[Token(Token = "0x400AEB9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		private List<Image> m_IndicatorsAlterP1;

		[Token(Token = "0x400AEBA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		private List<Image> m_IndicatorsAlterP2;

		[Token(Token = "0x17000FAB")]
		public RawImage m_CardImage
		{
			[Token(Token = "0x600639C")]
			[Address(RVA = "0x414E80", Offset = "0x414080", VA = "0x180414E80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600639D")]
			[Address(RVA = "0x414E90", Offset = "0x414090", VA = "0x180414E90")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000FAC")]
		public SelectionButton m_CardImageButton
		{
			[Token(Token = "0x600639E")]
			[Address(RVA = "0x580700", Offset = "0x57F900", VA = "0x180580700")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600639F")]
			[Address(RVA = "0x580760", Offset = "0x57F960", VA = "0x180580760")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000FAD")]
		public Image m_LimitIcon
		{
			[Token(Token = "0x60063A0")]
			[Address(RVA = "0x5EA220", Offset = "0x5E9420", VA = "0x1805EA220")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60063A1")]
			[Address(RVA = "0x81BD60", Offset = "0x81AF60", VA = "0x18081BD60")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000FAE")]
		public Image m_RarityIcon
		{
			[Token(Token = "0x60063A2")]
			[Address(RVA = "0x589E50", Offset = "0x589050", VA = "0x180589E50")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60063A3")]
			[Address(RVA = "0x589E60", Offset = "0x589060", VA = "0x180589E60")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000FAF")]
		public Action m_OnClickImageButton
		{
			[Token(Token = "0x60063A4")]
			[Address(RVA = "0x49B9F0", Offset = "0x49ABF0", VA = "0x18049B9F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60063A5")]
			[Address(RVA = "0x49C1F0", Offset = "0x49B3F0", VA = "0x18049C1F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000FB0")]
		public ExtendedTextMeshProUGUI m_CardTotalText
		{
			[Token(Token = "0x60063A9")]
			[Address(RVA = "0x449820", Offset = "0x448A20", VA = "0x180449820")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60063AA")]
			[Address(RVA = "0x3D77E0", Offset = "0x3D69E0", VA = "0x1803D77E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000FB1")]
		public ExtendedTextMeshProUGUI m_NonPrizeCardTotalText
		{
			[Token(Token = "0x60063AB")]
			[Address(RVA = "0x49BD10", Offset = "0x49AF10", VA = "0x18049BD10")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60063AC")]
			[Address(RVA = "0x4573F0", Offset = "0x4565F0", VA = "0x1804573F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x600639A")]
		[Address(RVA = "0xA9FB00", Offset = "0xA9ED00", VA = "0x180A9FB00")]
		public void SetCard(int cardId, CardCollectionInfo.Premium premium, bool isRental)
		{
		}

		[Token(Token = "0x600639B")]
		[Address(RVA = "0xA9F850", Offset = "0xA9EA50", VA = "0x180A9F850", Slot = "4")]
		protected override void InitializeElements()
		{
		}

		[Token(Token = "0x60063A6")]
		[Address(RVA = "0xA9F360", Offset = "0xA9E560", VA = "0x180A9F360")]
		private void InitializeCardImage()
		{
		}

		[Token(Token = "0x60063A7")]
		[Address(RVA = "0xAA0750", Offset = "0xA9F950", VA = "0x180AA0750")]
		public void SetRentalImage(bool isRental)
		{
		}

		[Token(Token = "0x60063A8")]
		[Address(RVA = "0x49C1F0", Offset = "0x49B3F0", VA = "0x18049C1F0")]
		public void SetOnClickCardImageButton(Action action)
		{
		}

		[Token(Token = "0x60063AD")]
		[Address(RVA = "0xA9F520", Offset = "0xA9E720", VA = "0x180A9F520")]
		private void InitializeCardNumText()
		{
		}

		[Token(Token = "0x60063AE")]
		[Address(RVA = "0xAA0520", Offset = "0xA9F720", VA = "0x180AA0520")]
		public void SetPrems()
		{
		}

		[Token(Token = "0x60063AF")]
		[Address(RVA = "0xA9F920", Offset = "0xA9EB20", VA = "0x180A9F920")]
		private void InitializeIndicator()
		{
		}

		[Token(Token = "0x60063B0")]
		[Address(RVA = "0xAA0310", Offset = "0xA9F510", VA = "0x180AA0310")]
		public void SetInDeckSum(int numN, int alterN, int numP1, int alterP1, int numP2, int alterP2, int numR, int alterR)
		{
		}

		[Token(Token = "0x60063B1")]
		[Address(RVA = "0xA9F0D0", Offset = "0xA9E2D0", VA = "0x180A9F0D0")]
		private void AdjustIndicator(int oldNum, int newNum, List<Image> list, Image template, bool isAlter = false)
		{
		}

		[Token(Token = "0x60063B2")]
		[Address(RVA = "0xA9FB20", Offset = "0xA9ED20", VA = "0x180A9FB20")]
		public void SetInDeckIndicatorColor(bool isFull)
		{
		}

		[Token(Token = "0x60063B3")]
		[Address(RVA = "0xAA0830", Offset = "0xA9FA30", VA = "0x180AA0830")]
		public CardArea()
		{
		}
	}

	[Token(Token = "0x200105F")]
	private class CraftArea : ElementWidget
	{
		[Token(Token = "0x2001060")]
		private class CraftButtonWidget : ElementWidget
		{
			[Token(Token = "0x400AEBD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public SelectionButton m_Button;

			[Token(Token = "0x400AEBE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public ExtendedTextMeshProUGUI m_ButtonText;

			[Token(Token = "0x400AEBF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public Image m_IconCP;

			[Token(Token = "0x400AEC0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public ExtendedTextMeshProUGUI m_TextCP;

			[Token(Token = "0x400AEC1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public Image m_IconEnabled;

			[Token(Token = "0x400AEC2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public Image m_IconDisabled;

			[Token(Token = "0x400AEC3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			public Image m_IconLocked;

			[Token(Token = "0x60063BB")]
			[Address(RVA = "0xAADE80", Offset = "0xAAD080", VA = "0x180AADE80", Slot = "4")]
			protected override void InitializeElements()
			{
			}

			[Token(Token = "0x60063BC")]
			[Address(RVA = "0x3D2BD0", Offset = "0x3D1DD0", VA = "0x1803D2BD0")]
			public CraftButtonWidget()
			{
			}
		}

		[Token(Token = "0x400AEBB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private CraftButtonWidget CraftCreateButton;

		[Token(Token = "0x400AEBC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private CraftButtonWidget CraftDismantleButton;

		[Token(Token = "0x17000FB2")]
		public SelectionButton CreateButton
		{
			[Token(Token = "0x60063B5")]
			[Address(RVA = "0xAADE40", Offset = "0xAAD040", VA = "0x180AADE40")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000FB3")]
		public SelectionButton DismantleButton
		{
			[Token(Token = "0x60063B6")]
			[Address(RVA = "0xAADE60", Offset = "0xAAD060", VA = "0x180AADE60")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60063B7")]
		[Address(RVA = "0xAAD550", Offset = "0xAAC750", VA = "0x180AAD550", Slot = "4")]
		protected override void InitializeElements()
		{
		}

		[Token(Token = "0x60063B8")]
		[Address(RVA = "0xAAD610", Offset = "0xAAC810", VA = "0x180AAD610")]
		public void SetCraftable(bool craftable, int rarityID)
		{
		}

		[Token(Token = "0x60063B9")]
		[Address(RVA = "0xAAD8D0", Offset = "0xAACAD0", VA = "0x180AAD8D0")]
		public void SetDismantable(bool dismantable, int rarityID, CardCollectionInfo.Premium premium, bool isLocked = false, bool isAlterComp = false)
		{
		}

		[Token(Token = "0x60063BA")]
		[Address(RVA = "0x3D2BD0", Offset = "0x3D1DD0", VA = "0x1803D2BD0")]
		public CraftArea()
		{
		}
	}

	[Token(Token = "0x2001061")]
	private class MenuArea : ElementWidget
	{
		[Token(Token = "0x400AEC5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private RectTransform m_BookmarkOn;

		[Token(Token = "0x400AEC6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private RectTransform m_BookmarkOff;

		[Token(Token = "0x17000FB4")]
		public SelectionButton m_BookmarkButton
		{
			[Token(Token = "0x60063BD")]
			[Address(RVA = "0x402CE0", Offset = "0x401EE0", VA = "0x180402CE0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60063BE")]
			[Address(RVA = "0x4130D0", Offset = "0x4122D0", VA = "0x1804130D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000FB5")]
		public SelectionButton m_HowToGetButton
		{
			[Token(Token = "0x60063BF")]
			[Address(RVA = "0x414E80", Offset = "0x414080", VA = "0x180414E80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60063C0")]
			[Address(RVA = "0x414E90", Offset = "0x414090", VA = "0x180414E90")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000FB6")]
		public SelectionButton m_RelatedCardButton
		{
			[Token(Token = "0x60063C1")]
			[Address(RVA = "0x580700", Offset = "0x57F900", VA = "0x180580700")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60063C2")]
			[Address(RVA = "0x580760", Offset = "0x57F960", VA = "0x180580760")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000FB7")]
		public SelectionButton m_AddCardButton
		{
			[Token(Token = "0x60063C3")]
			[Address(RVA = "0x5EA220", Offset = "0x5E9420", VA = "0x1805EA220")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60063C4")]
			[Address(RVA = "0x81BD60", Offset = "0x81AF60", VA = "0x18081BD60")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000FB8")]
		public SelectionButton m_RemoveCardButton
		{
			[Token(Token = "0x60063C5")]
			[Address(RVA = "0x589E50", Offset = "0x589050", VA = "0x180589E50")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60063C6")]
			[Address(RVA = "0x589E60", Offset = "0x589060", VA = "0x180589E60")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000FB9")]
		public Selector m_Selector
		{
			[Token(Token = "0x60063C7")]
			[Address(RVA = "0x49B9F0", Offset = "0x49ABF0", VA = "0x18049B9F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60063C8")]
			[Address(RVA = "0x49C1F0", Offset = "0x49B3F0", VA = "0x18049C1F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x60063C9")]
		[Address(RVA = "0xAAF790", Offset = "0xAAE990", VA = "0x180AAF790", Slot = "4")]
		protected override void InitializeElements()
		{
		}

		[Token(Token = "0x60063CA")]
		[Address(RVA = "0xAAFAF0", Offset = "0xAAECF0", VA = "0x180AAFAF0")]
		public void ToggleBookmark(bool isBookmarked)
		{
		}

		[Token(Token = "0x60063CB")]
		[Address(RVA = "0xAAFA80", Offset = "0xAAEC80", VA = "0x180AAFA80")]
		public void SetActiveAddCardButtons(bool isActive)
		{
		}

		[Token(Token = "0x60063CC")]
		[Address(RVA = "0x3D2BD0", Offset = "0x3D1DD0", VA = "0x1803D2BD0")]
		public MenuArea()
		{
		}
	}

	[Token(Token = "0x2001065")]
	[CompilerGenerated]
	private sealed class _003CyPlayPaging_003Ed__143 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400AEEE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400AEEF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400AEF0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public TweenType tweenType;

		[Token(Token = "0x400AEF1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public CardActionMenu _003C_003E4__this;

		[Token(Token = "0x400AEF2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Action onUpdate;

		[Token(Token = "0x400AEF3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Action onFinish;

		[Token(Token = "0x17000FBA")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x60063DC")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000FBB")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60063DE")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60063D9")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CyPlayPaging_003Ed__143(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x60063DA")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x60063DB")]
		[Address(RVA = "0xAB3760", Offset = "0xAB2960", VA = "0x180AB3760", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60063DD")]
		[Address(RVA = "0xAB3D10", Offset = "0xAB2F10", VA = "0x180AB3D10", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x400AE52")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
	private ElementObjectManager m_Eom;

	[Token(Token = "0x400AE53")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
	private bool isIni;

	[Token(Token = "0x400AE54")]
	private const string tweenLabelIn = "In";

	[Token(Token = "0x400AE55")]
	private const string tweenLabelOut = "Out";

	[Token(Token = "0x400AE56")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
	private SelectionButton m_PrevButton;

	[Token(Token = "0x400AE57")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
	private SelectionButton m_NextButton;

	[Token(Token = "0x400AE58")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
	private SelectionButton m_FlickButton;

	[Token(Token = "0x400AE59")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
	private bool horizontalSwipe;

	[Token(Token = "0x400AE5A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x13C")]
	private Vector2 pressedPoint;

	[Token(Token = "0x400AE5B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x144")]
	private CardBaseData m_PrevCard;

	[Token(Token = "0x400AE5C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
	private CardBaseData m_NextCard;

	[Token(Token = "0x400AE5D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
	private DeckView m_DeckView;

	[Token(Token = "0x400AE5E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
	private CardCollectionView m_CollectionView;

	[Token(Token = "0x400AE5F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
	private bool fromDeck;

	[Token(Token = "0x400AE60")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x194")]
	private int regulationID;

	[Token(Token = "0x400AE61")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
	private int rentalID;

	[Token(Token = "0x400AE62")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
	private Action<CardActionMenu, CardBaseData> onInitAction;

	[Token(Token = "0x400AE63")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
	private CardExpand m_CardExpand;

	[Token(Token = "0x400AE67")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C4")]
	private CardCollectionInfo.Premium m_CurrentPremium;

	[Token(Token = "0x400AE68")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C8")]
	private bool m_CurrentRental;

	[Token(Token = "0x400AE69")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1CC")]
	private int m_CurrentIdx;

	[Token(Token = "0x400AE6A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1D0")]
	private TitleArea m_TitleArea;

	[Token(Token = "0x400AE6B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1D8")]
	private ParameterArea m_ParameterArea;

	[Token(Token = "0x400AE6C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1E0")]
	private DescriptionArea m_DescriptionArea;

	[Token(Token = "0x400AE6D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1E8")]
	private CardArea m_CardArea;

	[Token(Token = "0x400AE6E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1F0")]
	private CraftArea m_CraftArea;

	[Token(Token = "0x400AE6F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1F8")]
	private MenuArea m_MenuArea;

	[Token(Token = "0x400AE70")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x200")]
	public CanvasGroup m_Window;

	[Token(Token = "0x400AE71")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x208")]
	public SelectionItem m_WindowItem;

	[Token(Token = "0x400AE72")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x210")]
	private SelectionButton m_ButtonBack;

	[Token(Token = "0x17000F68")]
	protected override Image m_AttrIcon
	{
		[Token(Token = "0x60062F9")]
		[Address(RVA = "0xA8EB80", Offset = "0xA8DD80", VA = "0x180A8EB80", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000F69")]
	protected override Image m_TunerIcon
	{
		[Token(Token = "0x60062FA")]
		[Address(RVA = "0xA8F080", Offset = "0xA8E280", VA = "0x180A8F080", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000F6A")]
	protected override Image m_TypeIcon
	{
		[Token(Token = "0x60062FB")]
		[Address(RVA = "0xA8F0B0", Offset = "0xA8E2B0", VA = "0x180A8F0B0", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000F6B")]
	protected override Image m_SpellTrapTypeIcon
	{
		[Token(Token = "0x60062FC")]
		[Address(RVA = "0xA8EFF0", Offset = "0xA8E1F0", VA = "0x180A8EFF0", Slot = "16")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000F6C")]
	protected override Image m_PendScaleIcon
	{
		[Token(Token = "0x60062FD")]
		[Address(RVA = "0xA8EE50", Offset = "0xA8E050", VA = "0x180A8EE50", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000F6D")]
	protected override ExtendedTextMeshProUGUI m_PendScaleText
	{
		[Token(Token = "0x60062FE")]
		[Address(RVA = "0xA8EE80", Offset = "0xA8E080", VA = "0x180A8EE80", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000F6E")]
	protected override Image m_LvlIcon
	{
		[Token(Token = "0x60062FF")]
		[Address(RVA = "0xA8EDD0", Offset = "0xA8DFD0", VA = "0x180A8EDD0", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000F6F")]
	protected override ExtendedTextMeshProUGUI m_LvlText
	{
		[Token(Token = "0x6006300")]
		[Address(RVA = "0xA8EE00", Offset = "0xA8E000", VA = "0x180A8EE00", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000F70")]
	protected override Image m_RankIcon
	{
		[Token(Token = "0x6006301")]
		[Address(RVA = "0xA8EF10", Offset = "0xA8E110", VA = "0x180A8EF10", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000F71")]
	protected override ExtendedTextMeshProUGUI m_RankText
	{
		[Token(Token = "0x6006302")]
		[Address(RVA = "0xA8EF40", Offset = "0xA8E140", VA = "0x180A8EF40", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000F72")]
	protected override Image m_LinkIcon
	{
		[Token(Token = "0x6006303")]
		[Address(RVA = "0xA8ED70", Offset = "0xA8DF70", VA = "0x180A8ED70", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000F73")]
	protected override ExtendedTextMeshProUGUI m_LinkText
	{
		[Token(Token = "0x6006304")]
		[Address(RVA = "0xA8EDA0", Offset = "0xA8DFA0", VA = "0x180A8EDA0", Slot = "14")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000F74")]
	protected override Image m_AtkIcon
	{
		[Token(Token = "0x6006305")]
		[Address(RVA = "0xA8EB20", Offset = "0xA8DD20", VA = "0x180A8EB20", Slot = "19")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000F75")]
	protected override ExtendedTextMeshProUGUI m_AtkText
	{
		[Token(Token = "0x6006306")]
		[Address(RVA = "0xA8EB50", Offset = "0xA8DD50", VA = "0x180A8EB50", Slot = "20")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000F76")]
	protected override Image m_DefIcon
	{
		[Token(Token = "0x6006307")]
		[Address(RVA = "0xA8ECA0", Offset = "0xA8DEA0", VA = "0x180A8ECA0", Slot = "21")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000F77")]
	protected override ExtendedTextMeshProUGUI m_DefText
	{
		[Token(Token = "0x6006308")]
		[Address(RVA = "0xA8ECD0", Offset = "0xA8DED0", VA = "0x180A8ECD0", Slot = "22")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000F78")]
	protected override RectTransform m_SpellTrapType
	{
		[Token(Token = "0x6006309")]
		[Address(RVA = "0xA8F040", Offset = "0xA8E240", VA = "0x180A8F040", Slot = "23")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000F79")]
	protected override ExtendedTextMeshProUGUI m_SpellTrapTypeText
	{
		[Token(Token = "0x600630A")]
		[Address(RVA = "0xA8F010", Offset = "0xA8E210", VA = "0x180A8F010", Slot = "24")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000F7A")]
	protected override Image m_RegulationIcon
	{
		[Token(Token = "0x600630B")]
		[Address(RVA = "0xA8EF90", Offset = "0xA8E190", VA = "0x180A8EF90", Slot = "17")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000F7B")]
	protected override Image m_RarityIcon
	{
		[Token(Token = "0x600630C")]
		[Address(RVA = "0xA8EF70", Offset = "0xA8E170", VA = "0x180A8EF70", Slot = "18")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000F7C")]
	protected override ExtendedScrollRect m_TextArea
	{
		[Token(Token = "0x600630D")]
		[Address(RVA = "0xA8F060", Offset = "0xA8E260", VA = "0x180A8F060", Slot = "25")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000F7D")]
	protected override ExtendedTextMeshProUGUI m_CardDesc
	{
		[Token(Token = "0x600630E")]
		[Address(RVA = "0xA8EC20", Offset = "0xA8DE20", VA = "0x180A8EC20", Slot = "26")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000F7E")]
	protected override ExtendedTextMeshProUGUI m_CardDescHeading
	{
		[Token(Token = "0x600630F")]
		[Address(RVA = "0xA8EBE0", Offset = "0xA8DDE0", VA = "0x180A8EBE0", Slot = "27")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000F7F")]
	protected override Image m_DescAreaBG
	{
		[Token(Token = "0x6006310")]
		[Address(RVA = "0xA8ED00", Offset = "0xA8DF00", VA = "0x180A8ED00", Slot = "29")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000F80")]
	protected override SelectionButton m_CreateButton
	{
		[Token(Token = "0x6006311")]
		[Address(RVA = "0xA8EC60", Offset = "0xA8DE60", VA = "0x180A8EC60", Slot = "31")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000F81")]
	protected override SelectionButton m_DismantleButton
	{
		[Token(Token = "0x6006312")]
		[Address(RVA = "0xA8ED20", Offset = "0xA8DF20", VA = "0x180A8ED20", Slot = "32")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000F82")]
	protected override SelectionButton m_AddCardButton
	{
		[Token(Token = "0x6006313")]
		[Address(RVA = "0xA8EB00", Offset = "0xA8DD00", VA = "0x180A8EB00", Slot = "33")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000F83")]
	protected override SelectionButton m_RemoveCardButton
	{
		[Token(Token = "0x6006314")]
		[Address(RVA = "0xA8EFD0", Offset = "0xA8E1D0", VA = "0x180A8EFD0", Slot = "34")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000F84")]
	protected override SelectionButton m_BookmarkButton
	{
		[Token(Token = "0x6006315")]
		[Address(RVA = "0xA8EBA0", Offset = "0xA8DDA0", VA = "0x180A8EBA0", Slot = "35")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000F85")]
	protected override SelectionButton m_HowToGetButton
	{
		[Token(Token = "0x6006316")]
		[Address(RVA = "0xA8ED50", Offset = "0xA8DF50", VA = "0x180A8ED50", Slot = "36")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000F86")]
	protected override SelectionButton m_RelatedCardButton
	{
		[Token(Token = "0x6006317")]
		[Address(RVA = "0xA8EFB0", Offset = "0xA8E1B0", VA = "0x180A8EFB0", Slot = "37")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000F87")]
	protected override Image m_NameAreaBG
	{
		[Token(Token = "0x6006318")]
		[Address(RVA = "0xA8EE30", Offset = "0xA8E030", VA = "0x180A8EE30", Slot = "28")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000F88")]
	protected override RubyTextGX m_CardName
	{
		[Token(Token = "0x6006319")]
		[Address(RVA = "0xA8EC40", Offset = "0xA8DE40", VA = "0x180A8EC40", Slot = "30")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000F89")]
	private ExtendedScrollRect m_PendulumTextArea
	{
		[Token(Token = "0x600631A")]
		[Address(RVA = "0xA8EEF0", Offset = "0xA8E0F0", VA = "0x180A8EEF0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000F8A")]
	private RectTransform m_PendulumDescArea
	{
		[Token(Token = "0x600631B")]
		[Address(RVA = "0xA8EED0", Offset = "0xA8E0D0", VA = "0x180A8EED0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000F8B")]
	private ExtendedTextMeshProUGUI m_CardDescPend
	{
		[Token(Token = "0x600631C")]
		[Address(RVA = "0xA8EC00", Offset = "0xA8DE00", VA = "0x180A8EC00")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000F8C")]
	private ExtendedTextMeshProUGUI m_CardDescHeadingPendulum
	{
		[Token(Token = "0x600631D")]
		[Address(RVA = "0xA8EBC0", Offset = "0xA8DDC0", VA = "0x180A8EBC0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000F8D")]
	private Image m_PendulumDescAreaBG
	{
		[Token(Token = "0x600631E")]
		[Address(RVA = "0xA8EEB0", Offset = "0xA8E0B0", VA = "0x180A8EEB0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000F8E")]
	public Action onClickPrevButton
	{
		[Token(Token = "0x600631F")]
		[Address(RVA = "0xA8F0E0", Offset = "0xA8E2E0", VA = "0x180A8F0E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6006320")]
		[Address(RVA = "0xA8F910", Offset = "0xA8EB10", VA = "0x180A8F910")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x17000F8F")]
	public Action onClickNextButton
	{
		[Token(Token = "0x6006321")]
		[Address(RVA = "0x49BEC0", Offset = "0x49B0C0", VA = "0x18049BEC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6006322")]
		[Address(RVA = "0x49C5B0", Offset = "0x49B7B0", VA = "0x18049C5B0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x17000F90")]
	private int m_CurrentCardID
	{
		[Token(Token = "0x6006323")]
		[Address(RVA = "0xA8EC90", Offset = "0xA8DE90", VA = "0x180A8EC90")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6006324")]
		[Address(RVA = "0xA8F900", Offset = "0xA8EB00", VA = "0x180A8F900")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x6006325")]
	[Address(RVA = "0xA8D030", Offset = "0xA8C230", VA = "0x180A8D030")]
	public void SetActiveAddCardArea(bool isActive)
	{
	}

	[Token(Token = "0x6006326")]
	[Address(RVA = "0xA8D1E0", Offset = "0xA8C3E0", VA = "0x180A8D1E0")]
	public void SetActiveButtonCraftCreate(bool active)
	{
	}

	[Token(Token = "0x6006327")]
	[Address(RVA = "0xA8D1A0", Offset = "0xA8C3A0", VA = "0x180A8D1A0")]
	public void SetActiveButtonAddCard(bool active)
	{
	}

	[Token(Token = "0x6006328")]
	[Address(RVA = "0xA8D260", Offset = "0xA8C460", VA = "0x180A8D260")]
	public void SetActiveButtonRemoveCard(bool active)
	{
	}

	[Token(Token = "0x6006329")]
	[Address(RVA = "0xA8D220", Offset = "0xA8C420", VA = "0x180A8D220")]
	public void SetActiveButtonCraftDismantle(bool active)
	{
	}

	[Token(Token = "0x600632A")]
	[Address(RVA = "0xA8D890", Offset = "0xA8CA90", VA = "0x180A8D890")]
	protected void SetCraftPoint()
	{
	}

	[Token(Token = "0x600632B")]
	[Address(RVA = "0xA8EAD0", Offset = "0xA8DCD0", VA = "0x180A8EAD0")]
	public void UpdateCraftPoint()
	{
	}

	[Token(Token = "0x600632C")]
	[Address(RVA = "0xA8E0A0", Offset = "0xA8D2A0", VA = "0x180A8E0A0")]
	public void ToggleBookmark(bool isBookmarked)
	{
	}

	[Token(Token = "0x600632D")]
	[Address(RVA = "0xA8D2A0", Offset = "0xA8C4A0", VA = "0x180A8D2A0")]
	public void SetActiveSubMenuButton(bool activeRelatedCard, bool activeSourceButton)
	{
	}

	[Token(Token = "0x600632E")]
	[Address(RVA = "0xA8B400", Offset = "0xA8A600", VA = "0x180A8B400")]
	public void InitializeElements()
	{
	}

	[Token(Token = "0x600632F")]
	[Address(RVA = "0xA8BB10", Offset = "0xA8AD10", VA = "0x180A8BB10")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6006330")]
	[Address(RVA = "0xA8ABB0", Offset = "0xA89DB0", VA = "0x180A8ABB0")]
	private void Awake()
	{
	}

	[Token(Token = "0x6006331")]
	[Address(RVA = "0xA8B880", Offset = "0xA8AA80", VA = "0x180A8B880")]
	private void InnerOpen(int id, int inDeckN, int inDeckAlterN, int inDeckP1, int inDeckAlterP1, int inDeckP2, int inDeckAlterP2, int inDeckR, int inDeckAlterR, bool isFull, CardCollectionInfo.Premium prem, bool isRental, DeckView.Mode mode, int reg, int rent, TweenType tweenType = TweenType.Open)
	{
	}

	[Token(Token = "0x6006332")]
	[Address(RVA = "0xA8C860", Offset = "0xA8BA60", VA = "0x180A8C860")]
	public void Open(TweenType tweenType = TweenType.Open, [Optional] Action onUpdate)
	{
	}

	[Token(Token = "0x6006333")]
	[Address(RVA = "0xA8C7C0", Offset = "0xA8B9C0", VA = "0x180A8C7C0")]
	public void Open(int cardID, int inDeckN, int inDeckAlterN, int inDeckP1, int inDeckAlterP1, int inDeckP2, int inDeckAlterP2, int inDeckR, int inDeckAlterR, CardCollectionInfo.Premium prem, bool isFull, DeckView.Mode mode, int regulationID, int rentalID, bool isLocked)
	{
	}

	[Token(Token = "0x6006334")]
	[Address(RVA = "0xA8BCB0", Offset = "0xA8AEB0", VA = "0x180A8BCB0")]
	public void OpenFromCollectionView(int cardID, int premID, InDeckNumInfo inDeckInfo, bool isFull, DeckView.Mode mode, int regulationID, int rentalID, DeckView deckView, CardCollectionView collectionView, Action<CardActionMenu, CardBaseData> initAction, TweenType tweenType = TweenType.Open)
	{
	}

	[Token(Token = "0x6006335")]
	[Address(RVA = "0xA8C2C0", Offset = "0xA8B4C0", VA = "0x180A8C2C0")]
	public void OpenFromDeckView(int idx, InDeckNumInfo inDeckInfo, bool isFull, DeckView.Mode mode, int regulationID, int rentalID, DeckView deckView, CardCollectionView collectionView, Action<CardActionMenu, CardBaseData> initAction, TweenType tweenType = TweenType.Open)
	{
	}

	[Token(Token = "0x6006336")]
	[Address(RVA = "0xA8B2E0", Offset = "0xA8A4E0", VA = "0x180A8B2E0")]
	public void Close()
	{
	}

	[Token(Token = "0x6006337")]
	[Address(RVA = "0xA8F930", Offset = "0xA8EB30", VA = "0x180A8F930")]
	[IteratorStateMachine(typeof(_003CyPlayPaging_003Ed__143))]
	private IEnumerator yPlayPaging(TweenType tweenType = TweenType.Next, [Optional] Action onFinish, [Optional] Action onUpdate)
	{
		return null;
	}

	[Token(Token = "0x6006338")]
	[Address(RVA = "0xA8C9E0", Offset = "0xA8BBE0", VA = "0x180A8C9E0")]
	public void PagingCheck(CardBaseData baseData, bool added)
	{
	}

	[Token(Token = "0x6006339")]
	[Address(RVA = "0xA8D320", Offset = "0xA8C520", VA = "0x180A8D320")]
	public void SetBatchDismantleMode(bool active)
	{
	}

	[Token(Token = "0x600633A")]
	[Address(RVA = "0xA8DDD0", Offset = "0xA8CFD0", VA = "0x180A8DDD0")]
	public void SetMode(DeckView.Mode mode)
	{
	}

	[Token(Token = "0x600633B")]
	[Address(RVA = "0xA8DCE0", Offset = "0xA8CEE0", VA = "0x180A8DCE0")]
	public void SetInteractableWindow(bool b)
	{
	}

	[Token(Token = "0x600633C")]
	[Address(RVA = "0xA8F570", Offset = "0xA8E770", VA = "0x180A8F570")]
	private new void setDescriptionHeading()
	{
	}

	[Token(Token = "0x600633D")]
	[Address(RVA = "0xA8F0F0", Offset = "0xA8E2F0", VA = "0x180A8F0F0")]
	protected void setCardText()
	{
	}

	[Token(Token = "0x600633E")]
	[Address(RVA = "0xA8F520", Offset = "0xA8E720", VA = "0x180A8F520")]
	protected new void setDescAreaBG()
	{
	}

	[Token(Token = "0x600633F")]
	[Address(RVA = "0xA8DBC0", Offset = "0xA8CDC0", VA = "0x180A8DBC0")]
	public void SetInDeckIndicators(int numN, int alterN, int numP1, int alterP1, int numP2, int alterP2, int numR, int alterR, bool isFull)
	{
	}

	[Token(Token = "0x6006340")]
	[Address(RVA = "0xA8DC50", Offset = "0xA8CE50", VA = "0x180A8DC50")]
	public void SetInDeckIndicators(InDeckNumInfo inDeckInfo, bool isFull)
	{
	}

	[Token(Token = "0x6006341")]
	[Address(RVA = "0xA8E040", Offset = "0xA8D240", VA = "0x180A8E040")]
	public void SetPremiums()
	{
	}

	[Token(Token = "0x6006342")]
	[Address(RVA = "0xA8D470", Offset = "0xA8C670", VA = "0x180A8D470")]
	public void SetCardPremiumType(CardCollectionInfo.Premium prem)
	{
	}

	[Token(Token = "0x6006343")]
	[Address(RVA = "0xA8D5D0", Offset = "0xA8C7D0", VA = "0x180A8D5D0")]
	public void SetCardTotals(int rentalID = 0, bool isRental = false)
	{
	}

	[Token(Token = "0x6006344")]
	[Address(RVA = "0xA8B360", Offset = "0xA8A560", VA = "0x180A8B360")]
	public RectTransform GetCardImageRectTransform()
	{
		return null;
	}

	[Token(Token = "0x6006345")]
	[Address(RVA = "0xA8F7C0", Offset = "0xA8E9C0", VA = "0x180A8F7C0")]
	protected new void setRarity(bool b = true)
	{
	}

	[Token(Token = "0x6006346")]
	[Address(RVA = "0xA8E070", Offset = "0xA8D270", VA = "0x180A8E070")]
	public void SetRentalImageOverlay(bool active)
	{
	}

	[Token(Token = "0x6006347")]
	[Address(RVA = "0xA8BB60", Offset = "0xA8AD60", VA = "0x180A8BB60")]
	protected void OpenCardExpand()
	{
	}

	[Token(Token = "0x6006348")]
	[Address(RVA = "0xA8EAE0", Offset = "0xA8DCE0", VA = "0x180A8EAE0")]
	public CardActionMenu()
	{
	}
}
