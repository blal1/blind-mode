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
using YgomGame.CardPoolSelect;
using YgomGame.Deck;
using YgomGame.Duel;
using YgomSystem.ElementSystem;
using YgomSystem.UI;
using YgomSystem.YGomTMPro;

namespace YgomGame.Lottery;

[Token(Token = "0x20016DC")]
public class LotteryCardSelectCardActionMenu : CardUtilWidget
{
	[Token(Token = "0x20016DD")]
	public enum TweenType
	{
		[Token(Token = "0x400D908")]
		Open,
		[Token(Token = "0x400D909")]
		Close,
		[Token(Token = "0x400D90A")]
		Update,
		[Token(Token = "0x400D90B")]
		Prev,
		[Token(Token = "0x400D90C")]
		Next
	}

	[Token(Token = "0x20016DE")]
	private class TitleArea : ElementWidget
	{
		[Token(Token = "0x170015BD")]
		public RubyTextGX m_CardName
		{
			[Token(Token = "0x6008E82")]
			[Address(RVA = "0x402CE0", Offset = "0x401EE0", VA = "0x180402CE0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6008E83")]
			[Address(RVA = "0x4130D0", Offset = "0x4122D0", VA = "0x1804130D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x170015BE")]
		public RectTransform m_NameArea
		{
			[Token(Token = "0x6008E84")]
			[Address(RVA = "0x404860", Offset = "0x403A60", VA = "0x180404860")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6008E85")]
			[Address(RVA = "0x595520", Offset = "0x594720", VA = "0x180595520")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x170015BF")]
		public Image m_NameAreaBG
		{
			[Token(Token = "0x6008E86")]
			[Address(RVA = "0x404850", Offset = "0x403A50", VA = "0x180404850")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6008E87")]
			[Address(RVA = "0x595530", Offset = "0x594730", VA = "0x180595530")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x170015C0")]
		public Image m_AttrIcon
		{
			[Token(Token = "0x6008E88")]
			[Address(RVA = "0x414E80", Offset = "0x414080", VA = "0x180414E80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6008E89")]
			[Address(RVA = "0x414E90", Offset = "0x414090", VA = "0x180414E90")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x6008E8A")]
		[Address(RVA = "0xDA5760", Offset = "0xDA4960", VA = "0x180DA5760", Slot = "4")]
		protected override void InitializeElements()
		{
		}

		[Token(Token = "0x6008E8B")]
		[Address(RVA = "0x3D2BD0", Offset = "0x3D1DD0", VA = "0x1803D2BD0")]
		public TitleArea()
		{
		}
	}

	[Token(Token = "0x20016DF")]
	private class ParameterArea : ElementWidget
	{
		[Token(Token = "0x20016E0")]
		public class ParamIcon : ElementWidget
		{
			[Token(Token = "0x170015CC")]
			public Image m_IconImage
			{
				[Token(Token = "0x6008EA4")]
				[Address(RVA = "0x402CE0", Offset = "0x401EE0", VA = "0x180402CE0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x6008EA5")]
				[Address(RVA = "0x4130D0", Offset = "0x4122D0", VA = "0x1804130D0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x170015CD")]
			public ExtendedTextMeshProUGUI m_IconText
			{
				[Token(Token = "0x6008EA6")]
				[Address(RVA = "0x404860", Offset = "0x403A60", VA = "0x180404860")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x6008EA7")]
				[Address(RVA = "0x595520", Offset = "0x594720", VA = "0x180595520")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x6008EA8")]
			[Address(RVA = "0xDA4CF0", Offset = "0xDA3EF0", VA = "0x180DA4CF0", Slot = "4")]
			protected override void InitializeElements()
			{
			}

			[Token(Token = "0x6008EA9")]
			[Address(RVA = "0x3D2BD0", Offset = "0x3D1DD0", VA = "0x1803D2BD0")]
			public ParamIcon()
			{
			}
		}

		[Token(Token = "0x170015C1")]
		public ParamIcon m_TunerIcon
		{
			[Token(Token = "0x6008E8C")]
			[Address(RVA = "0x402CE0", Offset = "0x401EE0", VA = "0x180402CE0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6008E8D")]
			[Address(RVA = "0x4130D0", Offset = "0x4122D0", VA = "0x1804130D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x170015C2")]
		public ParamIcon m_TypeIcon
		{
			[Token(Token = "0x6008E8E")]
			[Address(RVA = "0x404860", Offset = "0x403A60", VA = "0x180404860")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6008E8F")]
			[Address(RVA = "0x595520", Offset = "0x594720", VA = "0x180595520")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x170015C3")]
		public ParamIcon m_PendScaleIcon
		{
			[Token(Token = "0x6008E90")]
			[Address(RVA = "0x404850", Offset = "0x403A50", VA = "0x180404850")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6008E91")]
			[Address(RVA = "0x595530", Offset = "0x594730", VA = "0x180595530")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x170015C4")]
		public ParamIcon m_LvlIcon
		{
			[Token(Token = "0x6008E92")]
			[Address(RVA = "0x414E80", Offset = "0x414080", VA = "0x180414E80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6008E93")]
			[Address(RVA = "0x414E90", Offset = "0x414090", VA = "0x180414E90")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x170015C5")]
		public ParamIcon m_RankIcon
		{
			[Token(Token = "0x6008E94")]
			[Address(RVA = "0x580700", Offset = "0x57F900", VA = "0x180580700")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6008E95")]
			[Address(RVA = "0x580760", Offset = "0x57F960", VA = "0x180580760")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x170015C6")]
		public ParamIcon m_LinkIcon
		{
			[Token(Token = "0x6008E96")]
			[Address(RVA = "0x5EA220", Offset = "0x5E9420", VA = "0x1805EA220")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6008E97")]
			[Address(RVA = "0x81BD60", Offset = "0x81AF60", VA = "0x18081BD60")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x170015C7")]
		public ParamIcon m_AtkIcon
		{
			[Token(Token = "0x6008E98")]
			[Address(RVA = "0x589E50", Offset = "0x589050", VA = "0x180589E50")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6008E99")]
			[Address(RVA = "0x589E60", Offset = "0x589060", VA = "0x180589E60")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x170015C8")]
		public ParamIcon m_DefIcon
		{
			[Token(Token = "0x6008E9A")]
			[Address(RVA = "0x49B9F0", Offset = "0x49ABF0", VA = "0x18049B9F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6008E9B")]
			[Address(RVA = "0x49C1F0", Offset = "0x49B3F0", VA = "0x18049C1F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x170015C9")]
		public RectTransform m_SpellTrapType
		{
			[Token(Token = "0x6008E9C")]
			[Address(RVA = "0x449820", Offset = "0x448A20", VA = "0x180449820")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6008E9D")]
			[Address(RVA = "0x3D77E0", Offset = "0x3D69E0", VA = "0x1803D77E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x170015CA")]
		public Image m_SpellTrapIconImage
		{
			[Token(Token = "0x6008E9E")]
			[Address(RVA = "0x49BD10", Offset = "0x49AF10", VA = "0x18049BD10")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6008E9F")]
			[Address(RVA = "0x4573F0", Offset = "0x4565F0", VA = "0x1804573F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x170015CB")]
		public ExtendedTextMeshProUGUI m_SpellTrapIconText
		{
			[Token(Token = "0x6008EA0")]
			[Address(RVA = "0x49B7F0", Offset = "0x49A9F0", VA = "0x18049B7F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6008EA1")]
			[Address(RVA = "0x457400", Offset = "0x456600", VA = "0x180457400")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x6008EA2")]
		[Address(RVA = "0xDA51C0", Offset = "0xDA43C0", VA = "0x180DA51C0", Slot = "4")]
		protected override void InitializeElements()
		{
		}

		[Token(Token = "0x6008EA3")]
		[Address(RVA = "0x3D2BD0", Offset = "0x3D1DD0", VA = "0x1803D2BD0")]
		public ParameterArea()
		{
		}
	}

	[Token(Token = "0x20016E1")]
	private class DescriptionArea : ElementWidget
	{
		[Token(Token = "0x170015CE")]
		public ExtendedScrollRect m_PendulumTextArea
		{
			[Token(Token = "0x6008EAA")]
			[Address(RVA = "0x402CE0", Offset = "0x401EE0", VA = "0x180402CE0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6008EAB")]
			[Address(RVA = "0x4130D0", Offset = "0x4122D0", VA = "0x1804130D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x170015CF")]
		public RectTransform m_PendulumDescArea
		{
			[Token(Token = "0x6008EAC")]
			[Address(RVA = "0x404860", Offset = "0x403A60", VA = "0x180404860")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6008EAD")]
			[Address(RVA = "0x595520", Offset = "0x594720", VA = "0x180595520")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x170015D0")]
		public ExtendedTextMeshProUGUI m_CardDescPend
		{
			[Token(Token = "0x6008EAE")]
			[Address(RVA = "0x404850", Offset = "0x403A50", VA = "0x180404850")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6008EAF")]
			[Address(RVA = "0x595530", Offset = "0x594730", VA = "0x180595530")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x170015D1")]
		public ExtendedTextMeshProUGUI m_CardDescHeadingPendulum
		{
			[Token(Token = "0x6008EB0")]
			[Address(RVA = "0x414E80", Offset = "0x414080", VA = "0x180414E80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6008EB1")]
			[Address(RVA = "0x414E90", Offset = "0x414090", VA = "0x180414E90")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x170015D2")]
		public ExtendedScrollRect m_TextArea
		{
			[Token(Token = "0x6008EB2")]
			[Address(RVA = "0x580700", Offset = "0x57F900", VA = "0x180580700")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6008EB3")]
			[Address(RVA = "0x580760", Offset = "0x57F960", VA = "0x180580760")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x170015D3")]
		public ExtendedTextMeshProUGUI m_CardDesc
		{
			[Token(Token = "0x6008EB4")]
			[Address(RVA = "0x5EA220", Offset = "0x5E9420", VA = "0x1805EA220")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6008EB5")]
			[Address(RVA = "0x81BD60", Offset = "0x81AF60", VA = "0x18081BD60")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x170015D4")]
		public ExtendedTextMeshProUGUI m_CardDescHeading
		{
			[Token(Token = "0x6008EB6")]
			[Address(RVA = "0x589E50", Offset = "0x589050", VA = "0x180589E50")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6008EB7")]
			[Address(RVA = "0x589E60", Offset = "0x589060", VA = "0x180589E60")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x170015D5")]
		public Image m_DescAreaBG
		{
			[Token(Token = "0x6008EB8")]
			[Address(RVA = "0x49B9F0", Offset = "0x49ABF0", VA = "0x18049B9F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6008EB9")]
			[Address(RVA = "0x49C1F0", Offset = "0x49B3F0", VA = "0x18049C1F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x170015D6")]
		public Image m_PendulumDescAreaBG
		{
			[Token(Token = "0x6008EBA")]
			[Address(RVA = "0x449820", Offset = "0x448A20", VA = "0x180449820")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6008EBB")]
			[Address(RVA = "0x3D77E0", Offset = "0x3D69E0", VA = "0x1803D77E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x6008EBC")]
		[Address(RVA = "0xD91630", Offset = "0xD90830", VA = "0x180D91630", Slot = "4")]
		protected override void InitializeElements()
		{
		}

		[Token(Token = "0x6008EBD")]
		[Address(RVA = "0x3D2BD0", Offset = "0x3D1DD0", VA = "0x1803D2BD0")]
		public DescriptionArea()
		{
		}
	}

	[Token(Token = "0x20016E2")]
	private class CardArea : ElementWidget
	{
		[Token(Token = "0x400D927")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private int m_CardID;

		[Token(Token = "0x170015D7")]
		public RawImage m_CardImage
		{
			[Token(Token = "0x6008EC0")]
			[Address(RVA = "0x404860", Offset = "0x403A60", VA = "0x180404860")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6008EC1")]
			[Address(RVA = "0x595520", Offset = "0x594720", VA = "0x180595520")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x170015D8")]
		public SelectionButton m_CardImageButton
		{
			[Token(Token = "0x6008EC2")]
			[Address(RVA = "0x404850", Offset = "0x403A50", VA = "0x180404850")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6008EC3")]
			[Address(RVA = "0x595530", Offset = "0x594730", VA = "0x180595530")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x170015D9")]
		public Image m_RarityIcon
		{
			[Token(Token = "0x6008EC4")]
			[Address(RVA = "0x414E80", Offset = "0x414080", VA = "0x180414E80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6008EC5")]
			[Address(RVA = "0x414E90", Offset = "0x414090", VA = "0x180414E90")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x170015DA")]
		public Action m_OnClickImageButton
		{
			[Token(Token = "0x6008EC6")]
			[Address(RVA = "0x580700", Offset = "0x57F900", VA = "0x180580700")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6008EC7")]
			[Address(RVA = "0x580760", Offset = "0x57F960", VA = "0x180580760")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x6008EBE")]
		[Address(RVA = "0x49C0C0", Offset = "0x49B2C0", VA = "0x18049C0C0")]
		public void SetCard(int cardId, CardCollectionInfo.Premium premium)
		{
		}

		[Token(Token = "0x6008EBF")]
		[Address(RVA = "0xD91320", Offset = "0xD90520", VA = "0x180D91320", Slot = "4")]
		protected override void InitializeElements()
		{
		}

		[Token(Token = "0x6008EC8")]
		[Address(RVA = "0xD90F40", Offset = "0xD90140", VA = "0x180D90F40")]
		private void InitializeCardImage()
		{
		}

		[Token(Token = "0x6008EC9")]
		[Address(RVA = "0x580760", Offset = "0x57F960", VA = "0x180580760")]
		public void SetOnClickCardImageButton(Action action)
		{
		}

		[Token(Token = "0x6008ECA")]
		[Address(RVA = "0x3D2BD0", Offset = "0x3D1DD0", VA = "0x1803D2BD0")]
		public CardArea()
		{
		}
	}

	[Token(Token = "0x20016E3")]
	private class MenuArea : ElementWidget
	{
		[Token(Token = "0x170015DB")]
		public SelectionButton m_AddCardButton
		{
			[Token(Token = "0x6008ECC")]
			[Address(RVA = "0x402CE0", Offset = "0x401EE0", VA = "0x180402CE0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6008ECD")]
			[Address(RVA = "0x4130D0", Offset = "0x4122D0", VA = "0x1804130D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x170015DC")]
		public SelectionButton m_RemoveCardButton
		{
			[Token(Token = "0x6008ECE")]
			[Address(RVA = "0x404860", Offset = "0x403A60", VA = "0x180404860")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6008ECF")]
			[Address(RVA = "0x595520", Offset = "0x594720", VA = "0x180595520")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x170015DD")]
		public Selector m_Selector
		{
			[Token(Token = "0x6008ED0")]
			[Address(RVA = "0x404850", Offset = "0x403A50", VA = "0x180404850")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6008ED1")]
			[Address(RVA = "0x595530", Offset = "0x594730", VA = "0x180595530")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x6008ED2")]
		[Address(RVA = "0xDA4700", Offset = "0xDA3900", VA = "0x180DA4700", Slot = "4")]
		protected override void InitializeElements()
		{
		}

		[Token(Token = "0x6008ED3")]
		[Address(RVA = "0xDA4980", Offset = "0xDA3B80", VA = "0x180DA4980")]
		public void SetActiveAddCardButtons(bool isActive)
		{
		}

		[Token(Token = "0x6008ED4")]
		[Address(RVA = "0x3D2BD0", Offset = "0x3D1DD0", VA = "0x1803D2BD0")]
		public MenuArea()
		{
		}
	}

	[Token(Token = "0x20016E9")]
	[CompilerGenerated]
	private sealed class _003CyPlayPaging_003Ed__131 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400D93E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400D93F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400D940")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public TweenType tweenType;

		[Token(Token = "0x400D941")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public LotteryCardSelectCardActionMenu _003C_003E4__this;

		[Token(Token = "0x400D942")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Action onUpdate;

		[Token(Token = "0x400D943")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Action onFinish;

		[Token(Token = "0x170015DE")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6008EEA")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170015DF")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6008EEC")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6008EE7")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CyPlayPaging_003Ed__131(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6008EE8")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6008EE9")]
		[Address(RVA = "0xDA7930", Offset = "0xDA6B30", VA = "0x180DA7930", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6008EEB")]
		[Address(RVA = "0xDA7EE0", Offset = "0xDA70E0", VA = "0x180DA7EE0", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x400D8E9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
	private ElementObjectManager m_Eom;

	[Token(Token = "0x400D8EA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
	private bool isIni;

	[Token(Token = "0x400D8EB")]
	private const string tweenLabelIn = "In";

	[Token(Token = "0x400D8EC")]
	private const string tweenLabelOut = "Out";

	[Token(Token = "0x400D8ED")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
	private SelectionButton m_PrevButton;

	[Token(Token = "0x400D8EE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
	private SelectionButton m_NextButton;

	[Token(Token = "0x400D8EF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
	private SelectionButton m_FlickButton;

	[Token(Token = "0x400D8F0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
	private bool horizontalSwipe;

	[Token(Token = "0x400D8F1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x13C")]
	private Vector2 pressedPoint;

	[Token(Token = "0x400D8F2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x144")]
	private CardBaseData m_PrevCard;

	[Token(Token = "0x400D8F3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
	private CardBaseData m_NextCard;

	[Token(Token = "0x400D8F4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
	private LotteryCardSelectPickupView m_PickupView;

	[Token(Token = "0x400D8F5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
	private CpsCardCollectionView m_CollectionView;

	[Token(Token = "0x400D8F6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
	private bool m_isPickupCard;

	[Token(Token = "0x400D8F7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
	private CardExpand m_CardExpand;

	[Token(Token = "0x400D8FB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1B4")]
	private CardCollectionInfo.Premium m_CurrentPremium;

	[Token(Token = "0x400D8FC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1B8")]
	private int m_pickupSlotIndex;

	[Token(Token = "0x400D8FD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C0")]
	private Func<CardBaseData, int> m_pickupAddAction;

	[Token(Token = "0x400D8FE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C8")]
	private Func<int, bool> m_pickupRemoveAction;

	[Token(Token = "0x400D8FF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1D0")]
	private TitleArea m_TitleArea;

	[Token(Token = "0x400D900")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1D8")]
	private ParameterArea m_ParameterArea;

	[Token(Token = "0x400D901")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1E0")]
	private DescriptionArea m_DescriptionArea;

	[Token(Token = "0x400D902")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1E8")]
	private CardArea m_CardArea;

	[Token(Token = "0x400D903")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1F0")]
	private MenuArea m_MenuArea;

	[Token(Token = "0x400D904")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1F8")]
	public CanvasGroup m_Window;

	[Token(Token = "0x400D905")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x200")]
	public SelectionItem m_WindowItem;

	[Token(Token = "0x400D906")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x208")]
	private SelectionButton m_ButtonBack;

	[Token(Token = "0x17001594")]
	protected override Image m_AttrIcon
	{
		[Token(Token = "0x6008E36")]
		[Address(RVA = "0xA8EB80", Offset = "0xA8DD80", VA = "0x180A8EB80", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001595")]
	protected override Image m_TunerIcon
	{
		[Token(Token = "0x6008E37")]
		[Address(RVA = "0xA8F080", Offset = "0xA8E280", VA = "0x180A8F080", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001596")]
	protected override Image m_TypeIcon
	{
		[Token(Token = "0x6008E38")]
		[Address(RVA = "0xA8F0B0", Offset = "0xA8E2B0", VA = "0x180A8F0B0", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001597")]
	protected override Image m_SpellTrapTypeIcon
	{
		[Token(Token = "0x6008E39")]
		[Address(RVA = "0xA8EFF0", Offset = "0xA8E1F0", VA = "0x180A8EFF0", Slot = "16")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001598")]
	protected override Image m_PendScaleIcon
	{
		[Token(Token = "0x6008E3A")]
		[Address(RVA = "0xA8EE50", Offset = "0xA8E050", VA = "0x180A8EE50", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001599")]
	protected override ExtendedTextMeshProUGUI m_PendScaleText
	{
		[Token(Token = "0x6008E3B")]
		[Address(RVA = "0xA8EE80", Offset = "0xA8E080", VA = "0x180A8EE80", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700159A")]
	protected override Image m_LvlIcon
	{
		[Token(Token = "0x6008E3C")]
		[Address(RVA = "0xA8EDD0", Offset = "0xA8DFD0", VA = "0x180A8EDD0", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700159B")]
	protected override ExtendedTextMeshProUGUI m_LvlText
	{
		[Token(Token = "0x6008E3D")]
		[Address(RVA = "0xA8EE00", Offset = "0xA8E000", VA = "0x180A8EE00", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700159C")]
	protected override Image m_RankIcon
	{
		[Token(Token = "0x6008E3E")]
		[Address(RVA = "0xA8EF10", Offset = "0xA8E110", VA = "0x180A8EF10", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700159D")]
	protected override ExtendedTextMeshProUGUI m_RankText
	{
		[Token(Token = "0x6008E3F")]
		[Address(RVA = "0xA8EF40", Offset = "0xA8E140", VA = "0x180A8EF40", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700159E")]
	protected override Image m_LinkIcon
	{
		[Token(Token = "0x6008E40")]
		[Address(RVA = "0xA8ED70", Offset = "0xA8DF70", VA = "0x180A8ED70", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700159F")]
	protected override ExtendedTextMeshProUGUI m_LinkText
	{
		[Token(Token = "0x6008E41")]
		[Address(RVA = "0xA8EDA0", Offset = "0xA8DFA0", VA = "0x180A8EDA0", Slot = "14")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170015A0")]
	protected override Image m_AtkIcon
	{
		[Token(Token = "0x6008E42")]
		[Address(RVA = "0xA8EB20", Offset = "0xA8DD20", VA = "0x180A8EB20", Slot = "19")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170015A1")]
	protected override ExtendedTextMeshProUGUI m_AtkText
	{
		[Token(Token = "0x6008E43")]
		[Address(RVA = "0xA8EB50", Offset = "0xA8DD50", VA = "0x180A8EB50", Slot = "20")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170015A2")]
	protected override Image m_DefIcon
	{
		[Token(Token = "0x6008E44")]
		[Address(RVA = "0xA8ECA0", Offset = "0xA8DEA0", VA = "0x180A8ECA0", Slot = "21")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170015A3")]
	protected override ExtendedTextMeshProUGUI m_DefText
	{
		[Token(Token = "0x6008E45")]
		[Address(RVA = "0xA8ECD0", Offset = "0xA8DED0", VA = "0x180A8ECD0", Slot = "22")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170015A4")]
	protected override RectTransform m_SpellTrapType
	{
		[Token(Token = "0x6008E46")]
		[Address(RVA = "0xA8F040", Offset = "0xA8E240", VA = "0x180A8F040", Slot = "23")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170015A5")]
	protected override ExtendedTextMeshProUGUI m_SpellTrapTypeText
	{
		[Token(Token = "0x6008E47")]
		[Address(RVA = "0xA8F010", Offset = "0xA8E210", VA = "0x180A8F010", Slot = "24")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170015A6")]
	protected override Image m_RegulationIcon
	{
		[Token(Token = "0x6008E48")]
		[Address(RVA = "0x3EF020", Offset = "0x3EE220", VA = "0x1803EF020", Slot = "17")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170015A7")]
	protected override Image m_RarityIcon
	{
		[Token(Token = "0x6008E49")]
		[Address(RVA = "0xD939D0", Offset = "0xD92BD0", VA = "0x180D939D0", Slot = "18")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170015A8")]
	protected override ExtendedScrollRect m_TextArea
	{
		[Token(Token = "0x6008E4A")]
		[Address(RVA = "0xA8F060", Offset = "0xA8E260", VA = "0x180A8F060", Slot = "25")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170015A9")]
	protected override ExtendedTextMeshProUGUI m_CardDesc
	{
		[Token(Token = "0x6008E4B")]
		[Address(RVA = "0xA8EC20", Offset = "0xA8DE20", VA = "0x180A8EC20", Slot = "26")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170015AA")]
	protected override ExtendedTextMeshProUGUI m_CardDescHeading
	{
		[Token(Token = "0x6008E4C")]
		[Address(RVA = "0xA8EBE0", Offset = "0xA8DDE0", VA = "0x180A8EBE0", Slot = "27")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170015AB")]
	protected override Image m_DescAreaBG
	{
		[Token(Token = "0x6008E4D")]
		[Address(RVA = "0xA8ED00", Offset = "0xA8DF00", VA = "0x180A8ED00", Slot = "29")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170015AC")]
	protected override SelectionButton m_AddCardButton
	{
		[Token(Token = "0x6008E4E")]
		[Address(RVA = "0xD939B0", Offset = "0xD92BB0", VA = "0x180D939B0", Slot = "33")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170015AD")]
	protected override SelectionButton m_RemoveCardButton
	{
		[Token(Token = "0x6008E4F")]
		[Address(RVA = "0xD939F0", Offset = "0xD92BF0", VA = "0x180D939F0", Slot = "34")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170015AE")]
	protected override SelectionButton m_CreateButton
	{
		[Token(Token = "0x6008E50")]
		[Address(RVA = "0x3EF020", Offset = "0x3EE220", VA = "0x1803EF020", Slot = "31")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170015AF")]
	protected override SelectionButton m_DismantleButton
	{
		[Token(Token = "0x6008E51")]
		[Address(RVA = "0x3EF020", Offset = "0x3EE220", VA = "0x1803EF020", Slot = "32")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170015B0")]
	protected override SelectionButton m_BookmarkButton
	{
		[Token(Token = "0x6008E52")]
		[Address(RVA = "0x3EF020", Offset = "0x3EE220", VA = "0x1803EF020", Slot = "35")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170015B1")]
	protected override SelectionButton m_HowToGetButton
	{
		[Token(Token = "0x6008E53")]
		[Address(RVA = "0x3EF020", Offset = "0x3EE220", VA = "0x1803EF020", Slot = "36")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170015B2")]
	protected override SelectionButton m_RelatedCardButton
	{
		[Token(Token = "0x6008E54")]
		[Address(RVA = "0x3EF020", Offset = "0x3EE220", VA = "0x1803EF020", Slot = "37")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170015B3")]
	protected override Image m_NameAreaBG
	{
		[Token(Token = "0x6008E55")]
		[Address(RVA = "0xA8EE30", Offset = "0xA8E030", VA = "0x180A8EE30", Slot = "28")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170015B4")]
	protected override RubyTextGX m_CardName
	{
		[Token(Token = "0x6008E56")]
		[Address(RVA = "0xA8EC40", Offset = "0xA8DE40", VA = "0x180A8EC40", Slot = "30")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170015B5")]
	private ExtendedScrollRect m_PendulumTextArea
	{
		[Token(Token = "0x6008E57")]
		[Address(RVA = "0xA8EEF0", Offset = "0xA8E0F0", VA = "0x180A8EEF0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170015B6")]
	private RectTransform m_PendulumDescArea
	{
		[Token(Token = "0x6008E58")]
		[Address(RVA = "0xA8EED0", Offset = "0xA8E0D0", VA = "0x180A8EED0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170015B7")]
	private ExtendedTextMeshProUGUI m_CardDescPend
	{
		[Token(Token = "0x6008E59")]
		[Address(RVA = "0xA8EC00", Offset = "0xA8DE00", VA = "0x180A8EC00")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170015B8")]
	private ExtendedTextMeshProUGUI m_CardDescHeadingPendulum
	{
		[Token(Token = "0x6008E5A")]
		[Address(RVA = "0xA8EBC0", Offset = "0xA8DDC0", VA = "0x180A8EBC0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170015B9")]
	private Image m_PendulumDescAreaBG
	{
		[Token(Token = "0x6008E5B")]
		[Address(RVA = "0xA8EEB0", Offset = "0xA8E0B0", VA = "0x180A8EEB0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170015BA")]
	public Action onClickPrevButton
	{
		[Token(Token = "0x6008E5C")]
		[Address(RVA = "0xAE41D0", Offset = "0xAE33D0", VA = "0x180AE41D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6008E5D")]
		[Address(RVA = "0xA91080", Offset = "0xA90280", VA = "0x180A91080")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x170015BB")]
	public Action onClickNextButton
	{
		[Token(Token = "0x6008E5E")]
		[Address(RVA = "0xD0CAE0", Offset = "0xD0BCE0", VA = "0x180D0CAE0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6008E5F")]
		[Address(RVA = "0xA910A0", Offset = "0xA902A0", VA = "0x180A910A0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x170015BC")]
	private int m_CurrentCardID
	{
		[Token(Token = "0x6008E60")]
		[Address(RVA = "0x49B810", Offset = "0x49AA10", VA = "0x18049B810")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6008E61")]
		[Address(RVA = "0x49C090", Offset = "0x49B290", VA = "0x18049C090")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x6008E62")]
	[Address(RVA = "0xA8D1A0", Offset = "0xA8C3A0", VA = "0x180A8D1A0")]
	public void SetActiveButtonAddCard(bool active)
	{
	}

	[Token(Token = "0x6008E63")]
	[Address(RVA = "0xA8D260", Offset = "0xA8C460", VA = "0x180A8D260")]
	public void SetActiveButtonRemoveCard(bool active)
	{
	}

	[Token(Token = "0x6008E64")]
	[Address(RVA = "0xD91FE0", Offset = "0xD911E0", VA = "0x180D91FE0")]
	public void InitializeElements()
	{
	}

	[Token(Token = "0x6008E65")]
	[Address(RVA = "0xD92610", Offset = "0xD91810", VA = "0x180D92610")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6008E66")]
	[Address(RVA = "0xD919B0", Offset = "0xD90BB0", VA = "0x180D919B0")]
	private void Awake()
	{
	}

	[Token(Token = "0x6008E67")]
	[Address(RVA = "0xD92400", Offset = "0xD91600", VA = "0x180D92400")]
	private void InnerOpen(int id, TweenType tweenType = TweenType.Open)
	{
	}

	[Token(Token = "0x6008E68")]
	[Address(RVA = "0xD94220", Offset = "0xD93420", VA = "0x180D94220")]
	private void startOpenAction(TweenType tweenType = TweenType.Open, [Optional] Action onUpdate)
	{
	}

	[Token(Token = "0x6008E69")]
	[Address(RVA = "0xD927B0", Offset = "0xD919B0", VA = "0x180D927B0")]
	public void OpenFromCollectionView(int cardID, LotteryCardSelectPickupView pickupView, CpsCardCollectionView collectionView, Action<CardBaseData> addAction, Action<CardBaseData> removeAction, TweenType tweenType = TweenType.Open)
	{
	}

	[Token(Token = "0x6008E6A")]
	[Address(RVA = "0xD92D00", Offset = "0xD91F00", VA = "0x180D92D00")]
	public void OpenFromPickupView(int cardID, int slotIndex, LotteryCardSelectPickupView pickupView, CpsCardCollectionView collectionView, Func<CardBaseData, int> addAction, Func<int, bool> removeAction, TweenType tweenType = TweenType.Open)
	{
	}

	[Token(Token = "0x6008E6B")]
	[Address(RVA = "0xD91EC0", Offset = "0xD910C0", VA = "0x180D91EC0")]
	public void Close()
	{
	}

	[Token(Token = "0x6008E6C")]
	[Address(RVA = "0xD943A0", Offset = "0xD935A0", VA = "0x180D943A0")]
	[IteratorStateMachine(typeof(_003CyPlayPaging_003Ed__131))]
	private IEnumerator yPlayPaging(TweenType tweenType = TweenType.Next, [Optional] Action onFinish, [Optional] Action onUpdate)
	{
		return null;
	}

	[Token(Token = "0x6008E6D")]
	[Address(RVA = "0xD93800", Offset = "0xD92A00", VA = "0x180D93800")]
	private void checkPickupCardPrevPaging()
	{
	}

	[Token(Token = "0x6008E6E")]
	[Address(RVA = "0xD93650", Offset = "0xD92850", VA = "0x180D93650")]
	private void checkPickupCardNextPaging()
	{
	}

	[Token(Token = "0x6008E6F")]
	[Address(RVA = "0xD92FE0", Offset = "0xD921E0", VA = "0x180D92FE0")]
	public void SetInteractableWindow(bool b)
	{
	}

	[Token(Token = "0x6008E70")]
	[Address(RVA = "0xD93E90", Offset = "0xD93090", VA = "0x180D93E90")]
	private new void setDescriptionHeading()
	{
	}

	[Token(Token = "0x6008E71")]
	[Address(RVA = "0xD93A10", Offset = "0xD92C10", VA = "0x180D93A10")]
	protected void setCardText()
	{
	}

	[Token(Token = "0x6008E72")]
	[Address(RVA = "0xD93E40", Offset = "0xD93040", VA = "0x180D93E40")]
	protected new void setDescAreaBG()
	{
	}

	[Token(Token = "0x6008E73")]
	[Address(RVA = "0xD92F10", Offset = "0xD92110", VA = "0x180D92F10")]
	public void SetCardPremiumType(CardCollectionInfo.Premium prem)
	{
	}

	[Token(Token = "0x6008E74")]
	[Address(RVA = "0xD91F40", Offset = "0xD91140", VA = "0x180D91F40")]
	public RectTransform GetCardImageRectTransform()
	{
		return null;
	}

	[Token(Token = "0x6008E75")]
	[Address(RVA = "0xD940E0", Offset = "0xD932E0", VA = "0x180D940E0")]
	protected new void setRarity(bool b = true)
	{
	}

	[Token(Token = "0x6008E76")]
	[Address(RVA = "0xD92660", Offset = "0xD91860", VA = "0x180D92660")]
	protected void OpenCardExpand()
	{
	}

	[Token(Token = "0x6008E77")]
	[Address(RVA = "0xD93630", Offset = "0xD92830", VA = "0x180D93630")]
	public LotteryCardSelectCardActionMenu()
	{
	}
}
