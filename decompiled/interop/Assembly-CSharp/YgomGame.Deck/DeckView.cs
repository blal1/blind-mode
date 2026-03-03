using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using YgomGame.Card;
using YgomGame.Menu;
using YgomGame.TextIDs;
using YgomSystem.ElementSystem;
using YgomSystem.UI;
using YgomSystem.UI.ElementWidget;
using YgomSystem.UI.InfinityScroll;
using YgomSystem.YGomTMPro;

namespace YgomGame.Deck;

[Token(Token = "0x20010C7")]
public class DeckView : MonoBehaviour
{
	[Token(Token = "0x20010C8")]
	public enum Mode
	{
		[Token(Token = "0x400B1F9")]
		Default,
		[Token(Token = "0x400B1FA")]
		Dismantle,
		[Token(Token = "0x400B1FB")]
		Lock
	}

	[Token(Token = "0x20010C9")]
	private class HeaderArea : MonoBehaviour
	{
		[Token(Token = "0x400B1FC")]
		[FieldOffset(Offset = "0x20")]
		private ElementObjectManager m_Eom;

		[Token(Token = "0x400B1FD")]
		[FieldOffset(Offset = "0x28")]
		private bool isInitialized;

		[Token(Token = "0x400B20D")]
		[FieldOffset(Offset = "0xA8")]
		public ElementObjectManager m_PopupGroupEom;

		[Token(Token = "0x400B20E")]
		[FieldOffset(Offset = "0xB0")]
		private Image m_PopupDeckCaseIcon;

		[Token(Token = "0x400B20F")]
		[FieldOffset(Offset = "0xB8")]
		private GameObject m_PopupArrowAdd;

		[Token(Token = "0x400B210")]
		[FieldOffset(Offset = "0xC0")]
		private GameObject m_PopupArrowRemove;

		[Token(Token = "0x400B211")]
		[FieldOffset(Offset = "0xC8")]
		private RawImage m_PopupCardImage;

		[Token(Token = "0x400B212")]
		[FieldOffset(Offset = "0xD0")]
		private GameObject m_PopupResetDeckIcon;

		[Token(Token = "0x400B213")]
		[FieldOffset(Offset = "0xD8")]
		private TextMeshProUGUI m_PopupText;

		[Token(Token = "0x400B215")]
		[FieldOffset(Offset = "0xE8")]
		private DeviceIcon m_UndoButtonIcon;

		[Token(Token = "0x400B216")]
		[FieldOffset(Offset = "0xF0")]
		private DeviceIcon m_ResetDeckButtonIcon;

		[Token(Token = "0x170010D5")]
		public bool isIni
		{
			[Token(Token = "0x600694B")]
			[Address(RVA = "0x588F60", Offset = "0x588160", VA = "0x180588F60")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170010D6")]
		public InputFieldWidget m_DeckNameInput
		{
			[Token(Token = "0x600694C")]
			[Address(RVA = "0x402CE0", Offset = "0x401EE0", VA = "0x180402CE0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600694D")]
			[Address(RVA = "0x4130D0", Offset = "0x4122D0", VA = "0x1804130D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x170010D7")]
		public GameObject m_DeckIcon
		{
			[Token(Token = "0x600694E")]
			[Address(RVA = "0x404860", Offset = "0x403A60", VA = "0x180404860")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600694F")]
			[Address(RVA = "0x595520", Offset = "0x594720", VA = "0x180595520")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x170010D8")]
		public ExtendedTextMeshProUGUI m_EventDeckName
		{
			[Token(Token = "0x6006950")]
			[Address(RVA = "0x404850", Offset = "0x403A50", VA = "0x180404850")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6006951")]
			[Address(RVA = "0x595530", Offset = "0x594730", VA = "0x180595530")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x170010D9")]
		public ExtendedTextMeshProUGUI m_CountText
		{
			[Token(Token = "0x6006952")]
			[Address(RVA = "0x414E80", Offset = "0x414080", VA = "0x180414E80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6006953")]
			[Address(RVA = "0x414E90", Offset = "0x414090", VA = "0x180414E90")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x170010DA")]
		public GameObject m_DismantleText
		{
			[Token(Token = "0x6006954")]
			[Address(RVA = "0x580700", Offset = "0x57F900", VA = "0x180580700")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6006955")]
			[Address(RVA = "0x580760", Offset = "0x57F960", VA = "0x180580760")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x170010DB")]
		public SelectionButton m_DismantleBatchButton
		{
			[Token(Token = "0x6006956")]
			[Address(RVA = "0x5EA220", Offset = "0x5E9420", VA = "0x1805EA220")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6006957")]
			[Address(RVA = "0x81BD60", Offset = "0x81AF60", VA = "0x18081BD60")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x170010DC")]
		public SelectionButton m_DismantleResetButton
		{
			[Token(Token = "0x6006958")]
			[Address(RVA = "0x589E50", Offset = "0x589050", VA = "0x180589E50")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6006959")]
			[Address(RVA = "0x589E60", Offset = "0x589060", VA = "0x180589E60")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x170010DD")]
		public DeviceIcon m_DismantleBatchButtonShortcutIcon
		{
			[Token(Token = "0x600695A")]
			[Address(RVA = "0x49B9F0", Offset = "0x49ABF0", VA = "0x18049B9F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600695B")]
			[Address(RVA = "0x49C1F0", Offset = "0x49B3F0", VA = "0x18049C1F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x170010DE")]
		public GameObject m_LockCardHeaderGroup
		{
			[Token(Token = "0x600695C")]
			[Address(RVA = "0x449820", Offset = "0x448A20", VA = "0x180449820")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600695D")]
			[Address(RVA = "0x3D77E0", Offset = "0x3D69E0", VA = "0x1803D77E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x170010DF")]
		public ExtendedTextMeshProUGUI m_LockCardCountText
		{
			[Token(Token = "0x600695E")]
			[Address(RVA = "0x49BD10", Offset = "0x49AF10", VA = "0x18049BD10")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600695F")]
			[Address(RVA = "0x4573F0", Offset = "0x4565F0", VA = "0x1804573F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x170010E0")]
		public SelectionButton m_LockCardSaveButton
		{
			[Token(Token = "0x6006960")]
			[Address(RVA = "0x49B7F0", Offset = "0x49A9F0", VA = "0x18049B7F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6006961")]
			[Address(RVA = "0x457400", Offset = "0x456600", VA = "0x180457400")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x170010E1")]
		public DeviceIcon m_LockCardSaveButtonShortcutIcon
		{
			[Token(Token = "0x6006962")]
			[Address(RVA = "0x49BEA0", Offset = "0x49B0A0", VA = "0x18049BEA0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6006963")]
			[Address(RVA = "0x457410", Offset = "0x456610", VA = "0x180457410")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x170010E2")]
		public SelectionButton m_AutoBuildButton
		{
			[Token(Token = "0x6006964")]
			[Address(RVA = "0x49BDC0", Offset = "0x49AFC0", VA = "0x18049BDC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6006965")]
			[Address(RVA = "0x4989A0", Offset = "0x497BA0", VA = "0x1804989A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x170010E3")]
		public DeviceIcon m_AutoBuildBatchButtonShortcutIcon
		{
			[Token(Token = "0x6006966")]
			[Address(RVA = "0x49B870", Offset = "0x49AA70", VA = "0x18049B870")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6006967")]
			[Address(RVA = "0x42FFD0", Offset = "0x42F1D0", VA = "0x18042FFD0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x170010E4")]
		public SelectionButton m_UndoButton
		{
			[Token(Token = "0x6006968")]
			[Address(RVA = "0x49B7D0", Offset = "0x49A9D0", VA = "0x18049B7D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6006969")]
			[Address(RVA = "0x42FF10", Offset = "0x42F110", VA = "0x18042FF10")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x170010E5")]
		public SelectionButton m_ResetDeckButton
		{
			[Token(Token = "0x600696A")]
			[Address(RVA = "0x5961E0", Offset = "0x5953E0", VA = "0x1805961E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600696B")]
			[Address(RVA = "0x662520", Offset = "0x661720", VA = "0x180662520")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x170010E6")]
		public UnityAction<string> onSubmitDeckNameAction
		{
			[Token(Token = "0x600696E")]
			[Address(RVA = "0x596200", Offset = "0x595400", VA = "0x180596200")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600696F")]
			[Address(RVA = "0x5FC6C0", Offset = "0x5FB8C0", VA = "0x1805FC6C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x170010E7")]
		public UnityAction onClickAutoBuild
		{
			[Token(Token = "0x6006974")]
			[Address(RVA = "0x5FC5E0", Offset = "0x5FB7E0", VA = "0x1805FC5E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6006975")]
			[Address(RVA = "0x5968C0", Offset = "0x595AC0", VA = "0x1805968C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x170010E8")]
		public UnityAction onClickUndo
		{
			[Token(Token = "0x6006979")]
			[Address(RVA = "0x5FC5F0", Offset = "0x5FB7F0", VA = "0x1805FC5F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600697A")]
			[Address(RVA = "0x5FC6A0", Offset = "0x5FB8A0", VA = "0x1805FC6A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x170010E9")]
		public UnityAction onClickResetDeck
		{
			[Token(Token = "0x600697E")]
			[Address(RVA = "0x3DA790", Offset = "0x3D9990", VA = "0x1803DA790")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600697F")]
			[Address(RVA = "0x3DA7A0", Offset = "0x3D99A0", VA = "0x1803DA7A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x170010EA")]
		public UnityAction onClickMultiDismantle
		{
			[Token(Token = "0x6006981")]
			[Address(RVA = "0x4D0610", Offset = "0x4CF810", VA = "0x1804D0610")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6006982")]
			[Address(RVA = "0x587E30", Offset = "0x587030", VA = "0x180587E30")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x170010EB")]
		public UnityAction onSelectMultiDismantle
		{
			[Token(Token = "0x6006983")]
			[Address(RVA = "0x9538F0", Offset = "0x952AF0", VA = "0x1809538F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6006984")]
			[Address(RVA = "0x596720", Offset = "0x595920", VA = "0x180596720")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x170010EC")]
		public UnityAction<SelectionItem> onInputRightMultiDismantle
		{
			[Token(Token = "0x6006985")]
			[Address(RVA = "0x62DA80", Offset = "0x62CC80", VA = "0x18062DA80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6006986")]
			[Address(RVA = "0x62E000", Offset = "0x62D200", VA = "0x18062E000")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x170010ED")]
		public UnityAction<SelectionItem> onInputDownMultiDismantle
		{
			[Token(Token = "0x6006987")]
			[Address(RVA = "0xABF8A0", Offset = "0xABEAA0", VA = "0x180ABF8A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6006988")]
			[Address(RVA = "0xB19AF0", Offset = "0xB18CF0", VA = "0x180B19AF0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x170010EE")]
		public UnityAction onClickSaveLockCards
		{
			[Token(Token = "0x600698D")]
			[Address(RVA = "0x7ACC30", Offset = "0x7ABE30", VA = "0x1807ACC30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600698E")]
			[Address(RVA = "0x7ACDE0", Offset = "0x7ABFE0", VA = "0x1807ACDE0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x170010EF")]
		public UnityAction onSelectSaveLockCards
		{
			[Token(Token = "0x600698F")]
			[Address(RVA = "0xB19AE0", Offset = "0xB18CE0", VA = "0x180B19AE0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6006990")]
			[Address(RVA = "0xB19B50", Offset = "0xB18D50", VA = "0x180B19B50")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x170010F0")]
		public UnityAction<SelectionItem> onInputRightSaveLockCards
		{
			[Token(Token = "0x6006991")]
			[Address(RVA = "0xB19AD0", Offset = "0xB18CD0", VA = "0x180B19AD0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6006992")]
			[Address(RVA = "0xB19B30", Offset = "0xB18D30", VA = "0x180B19B30")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x170010F1")]
		public UnityAction<SelectionItem> onInputDownSaveLockCards
		{
			[Token(Token = "0x6006993")]
			[Address(RVA = "0xB19AC0", Offset = "0xB18CC0", VA = "0x180B19AC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6006994")]
			[Address(RVA = "0xB19B10", Offset = "0xB18D10", VA = "0x180B19B10")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x600696C")]
		[Address(RVA = "0xB177C0", Offset = "0xB169C0", VA = "0x180B177C0")]
		private void Awake()
		{
		}

		[Token(Token = "0x600696D")]
		[Address(RVA = "0xB17C00", Offset = "0xB16E00", VA = "0x180B17C00")]
		public void InitializeElements()
		{
		}

		[Token(Token = "0x6006970")]
		[Address(RVA = "0xB18570", Offset = "0xB17770", VA = "0x180B18570")]
		private void InitilaizeDeckNameElements()
		{
		}

		[Token(Token = "0x6006971")]
		[Address(RVA = "0xB18BC0", Offset = "0xB17DC0", VA = "0x180B18BC0")]
		public void SetDeckName(string str)
		{
		}

		[Token(Token = "0x6006972")]
		[Address(RVA = "0xB18D10", Offset = "0xB17F10", VA = "0x180B18D10")]
		public void SetEventDeckName(string str)
		{
		}

		[Token(Token = "0x6006973")]
		[Address(RVA = "0xB18AC0", Offset = "0xB17CC0", VA = "0x180B18AC0")]
		public void SetDeckCaseIcon(int deckcaseId)
		{
		}

		[Token(Token = "0x6006976")]
		[Address(RVA = "0xB177D0", Offset = "0xB169D0", VA = "0x180B177D0")]
		private void InitializeAutoBuildElements()
		{
		}

		[Token(Token = "0x6006977")]
		[Address(RVA = "0xB189D0", Offset = "0xB17BD0", VA = "0x180B189D0")]
		public void SetActiveAutoBuildButton(bool active)
		{
		}

		[Token(Token = "0x6006978")]
		[Address(RVA = "0xB18CE0", Offset = "0xB17EE0", VA = "0x180B18CE0")]
		public void SetEnableAutoBuildButton(bool active)
		{
		}

		[Token(Token = "0x600697B")]
		[Address(RVA = "0xB181A0", Offset = "0xB173A0", VA = "0x180B181A0")]
		private void InitializeUndoElements()
		{
		}

		[Token(Token = "0x600697C")]
		[Address(RVA = "0xB19460", Offset = "0xB18660", VA = "0x180B19460")]
		public void UpdatePopup(DeckEditViewController2.OperationType type, (int, int) cardData)
		{
		}

		[Token(Token = "0x600697D")]
		[Address(RVA = "0xB19250", Offset = "0xB18450", VA = "0x180B19250")]
		public void SetPopupCard(int mrk, int prem)
		{
		}

		[Token(Token = "0x6006980")]
		[Address(RVA = "0xB18050", Offset = "0xB17250", VA = "0x180B18050")]
		private void InitializeResetDeckElements()
		{
		}

		[Token(Token = "0x6006989")]
		[Address(RVA = "0xB17920", Offset = "0xB16B20", VA = "0x180B17920")]
		private void InitializeDismantleElements()
		{
		}

		[Token(Token = "0x600698A")]
		[Address(RVA = "0xB18C10", Offset = "0xB17E10", VA = "0x180B18C10")]
		public void SetDismantleCount(int count)
		{
		}

		[Token(Token = "0x600698B")]
		[Address(RVA = "0xB18DA0", Offset = "0xB17FA0", VA = "0x180B18DA0")]
		public void SetLockCount(int count)
		{
		}

		[Token(Token = "0x600698C")]
		[Address(RVA = "0xB18A50", Offset = "0xB17C50", VA = "0x180B18A50")]
		public void SetActiveDismantleButton(bool active)
		{
		}

		[Token(Token = "0x6006995")]
		[Address(RVA = "0xB186E0", Offset = "0xB178E0", VA = "0x180B186E0")]
		private void InitilaizeLockElements()
		{
		}

		[Token(Token = "0x6006996")]
		[Address(RVA = "0xB18E40", Offset = "0xB18040", VA = "0x180B18E40")]
		public void SetMode(Mode mode)
		{
		}

		[Token(Token = "0x6006997")]
		[Address(RVA = "0x3D2BD0", Offset = "0x3D1DD0", VA = "0x1803D2BD0")]
		public HeaderArea()
		{
		}
	}

	[Token(Token = "0x20010CA")]
	public enum AddableType
	{
		[Token(Token = "0x400B224")]
		Addable,
		[Token(Token = "0x400B225")]
		OverCapacity,
		[Token(Token = "0x400B226")]
		OverCardNum,
		[Token(Token = "0x400B227")]
		OverLimit0,
		[Token(Token = "0x400B228")]
		OverLimit1,
		[Token(Token = "0x400B229")]
		OverLimit2
	}

	[Token(Token = "0x20010CB")]
	public class DeckContentWidget
	{
		[Token(Token = "0x20010CC")]
		public enum Type
		{
			[Token(Token = "0x400B22E")]
			Header,
			[Token(Token = "0x400B22F")]
			CardGroup
		}

		[Token(Token = "0x20010CD")]
		public enum DeckType
		{
			[Token(Token = "0x400B231")]
			Main,
			[Token(Token = "0x400B232")]
			Extra,
			[Token(Token = "0x400B233")]
			Dismantle,
			[Token(Token = "0x400B234")]
			Lock
		}

		[Token(Token = "0x20010CE")]
		private class DeckContent
		{
			[Token(Token = "0x400B235")]
			[FieldOffset(Offset = "0x10")]
			public Type type;

			[Token(Token = "0x400B236")]
			[FieldOffset(Offset = "0x14")]
			public DeckType deckType;

			[Token(Token = "0x400B237")]
			[FieldOffset(Offset = "0x18")]
			public string headerTitle;

			[Token(Token = "0x60069B6")]
			[Address(RVA = "0xB0E150", Offset = "0xB0D350", VA = "0x180B0E150")]
			public static DeckContent CreateHeader(DeckType deckType, IDS_DECKEDIT title)
			{
				return null;
			}

			[Token(Token = "0x60069B7")]
			[Address(RVA = "0xB0E0D0", Offset = "0xB0D2D0", VA = "0x180B0E0D0")]
			public static DeckContent CreateCardGroup(DeckType deckType)
			{
				return null;
			}

			[Token(Token = "0x60069B8")]
			[Address(RVA = "0xB0E0C0", Offset = "0xB0D2C0", VA = "0x180B0E0C0")]
			public bool CheckType(DeckType deckType, Type type)
			{
				return default(bool);
			}

			[Token(Token = "0x60069B9")]
			[Address(RVA = "0xB0E210", Offset = "0xB0D410", VA = "0x180B0E210")]
			public int GetTemplateIndex()
			{
				return default(int);
			}

			[Token(Token = "0x60069BA")]
			[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
			public DeckContent()
			{
			}
		}

		[Token(Token = "0x400B22A")]
		[FieldOffset(Offset = "0x10")]
		public int maxCol;

		[Token(Token = "0x400B22B")]
		[FieldOffset(Offset = "0x18")]
		private List<DeckContent> deckContents;

		[Token(Token = "0x170010F2")]
		public List<int> templateIndexer
		{
			[Token(Token = "0x60069A4")]
			[Address(RVA = "0x3D8370", Offset = "0x3D7570", VA = "0x1803D8370")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60069A5")]
			[Address(RVA = "0x3D8380", Offset = "0x3D7580", VA = "0x1803D8380")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x60069A6")]
		[Address(RVA = "0xB0D800", Offset = "0xB0CA00", VA = "0x180B0D800")]
		public int GetCardGroupHeadIndex(DeckType deckType)
		{
			return default(int);
		}

		[Token(Token = "0x60069A7")]
		[Address(RVA = "0xB0D8D0", Offset = "0xB0CAD0", VA = "0x180B0D8D0")]
		public int GetCardGroupTailIndex(DeckType deckType)
		{
			return default(int);
		}

		[Token(Token = "0x60069A8")]
		[Address(RVA = "0xB0D3C0", Offset = "0xB0C5C0", VA = "0x180B0D3C0")]
		public void AddCardGroup(DeckType deckType)
		{
		}

		[Token(Token = "0x60069A9")]
		[Address(RVA = "0xB0D2B0", Offset = "0xB0C4B0", VA = "0x180B0D2B0")]
		public void AddCardGroup(DeckType deckType, int index)
		{
		}

		[Token(Token = "0x60069AA")]
		[Address(RVA = "0xB0D630", Offset = "0xB0C830", VA = "0x180B0D630")]
		public void AddHeader(DeckType deckType, IDS_DECKEDIT title, int index)
		{
		}

		[Token(Token = "0x60069AB")]
		[Address(RVA = "0xB0DEE0", Offset = "0xB0D0E0", VA = "0x180B0DEE0")]
		public void RemoveHeader(DeckType deckType)
		{
		}

		[Token(Token = "0x60069AC")]
		[Address(RVA = "0xB0D580", Offset = "0xB0C780", VA = "0x180B0D580")]
		private void AddDeckContent(DeckContent deckContent, int index)
		{
		}

		[Token(Token = "0x60069AD")]
		[Address(RVA = "0xB0DDC0", Offset = "0xB0CFC0", VA = "0x180B0DDC0")]
		public void RemoveCardGroup(DeckType deckType)
		{
		}

		[Token(Token = "0x60069AE")]
		[Address(RVA = "0xB0DD10", Offset = "0xB0CF10", VA = "0x180B0DD10")]
		public int GetMaxCardNum(DeckType deckType)
		{
			return default(int);
		}

		[Token(Token = "0x60069AF")]
		[Address(RVA = "0xB0DA00", Offset = "0xB0CC00", VA = "0x180B0DA00")]
		public int GetContentNum()
		{
			return default(int);
		}

		[Token(Token = "0x60069B0")]
		[Address(RVA = "0xB0DAA0", Offset = "0xB0CCA0", VA = "0x180B0DAA0")]
		public (int, int) GetDisplayCardIndex(int index)
		{
			return default((int, int));
		}

		[Token(Token = "0x60069B1")]
		[Address(RVA = "0xB0DA40", Offset = "0xB0CC40", VA = "0x180B0DA40")]
		public Type GetContentType(int index)
		{
			return default(Type);
		}

		[Token(Token = "0x60069B2")]
		[Address(RVA = "0xB0D9A0", Offset = "0xB0CBA0", VA = "0x180B0D9A0")]
		public DeckType GetContentDeckType(int index)
		{
			return default(DeckType);
		}

		[Token(Token = "0x60069B3")]
		[Address(RVA = "0xB0DC70", Offset = "0xB0CE70", VA = "0x180B0DC70")]
		public string GetHeaderTitle(int index)
		{
			return null;
		}

		[Token(Token = "0x60069B4")]
		[Address(RVA = "0xB0D780", Offset = "0xB0C980", VA = "0x180B0D780")]
		public void ClearContent()
		{
		}

		[Token(Token = "0x60069B5")]
		[Address(RVA = "0xB0E000", Offset = "0xB0D200", VA = "0x180B0E000")]
		public DeckContentWidget()
		{
		}
	}

	[Token(Token = "0x20010E0")]
	[CompilerGenerated]
	private sealed class _003CwaitDecrementDragCounter_003Ed__290 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400B256")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400B257")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400B258")]
		[FieldOffset(Offset = "0x20")]
		public DeckView _003C_003E4__this;

		[Token(Token = "0x170010F3")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x60069ED")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170010F4")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60069EF")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60069EA")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CwaitDecrementDragCounter_003Ed__290(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x60069EB")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x60069EC")]
		[Address(RVA = "0xB24440", Offset = "0xB23640", VA = "0x180B24440", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60069EE")]
		[Address(RVA = "0xB244B0", Offset = "0xB236B0", VA = "0x180B244B0", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x400B1A6")]
	[FieldOffset(Offset = "0x24")]
	public Mode mode;

	[Token(Token = "0x400B1A8")]
	[FieldOffset(Offset = "0x2C")]
	private float removedWait;

	[Token(Token = "0x400B1A9")]
	[FieldOffset(Offset = "0x30")]
	private ElementObjectManager m_Eom;

	[Token(Token = "0x400B1AA")]
	private const string k_ELabelHeaderArea = "HeaderArea";

	[Token(Token = "0x400B1AB")]
	[FieldOffset(Offset = "0x38")]
	private HeaderArea m_HeaderArea;

	[Token(Token = "0x400B1AC")]
	[FieldOffset(Offset = "0x40")]
	private ElementObjectManager m_MainDeckEom;

	[Token(Token = "0x400B1AF")]
	[FieldOffset(Offset = "0x58")]
	private ElementObjectManager m_ExtraDeckEom;

	[Token(Token = "0x400B1B6")]
	[FieldOffset(Offset = "0x90")]
	private RectTransform m_SelectedWindowCursor;

	[Token(Token = "0x400B1B7")]
	private const string k_ELabelMobileScroll = "Scroll";

	[Token(Token = "0x400B1BC")]
	[FieldOffset(Offset = "0xB8")]
	private bool isScrollReady;

	[Token(Token = "0x400B1BD")]
	[FieldOffset(Offset = "0xB9")]
	private bool IsAutoBuildImage;

	[Token(Token = "0x400B1BE")]
	private const string k_ELabelDeckNumCounter = "DeckNumCounter";

	[Token(Token = "0x400B1C9")]
	[FieldOffset(Offset = "0x110")]
	private List<DeckCard> mainDeckCards;

	[Token(Token = "0x400B1CA")]
	[FieldOffset(Offset = "0x118")]
	private List<DeckCard> extraDeckCards;

	[Token(Token = "0x400B1CB")]
	[FieldOffset(Offset = "0x120")]
	private List<DeckCard> dismantlePoolCards;

	[Token(Token = "0x400B1CC")]
	[FieldOffset(Offset = "0x128")]
	private List<DeckCard> lockedPoolCards;

	[Token(Token = "0x400B1CD")]
	[FieldOffset(Offset = "0x130")]
	private Dictionary<string, DeckCard> autoBuildCardDict;

	[Token(Token = "0x400B1CE")]
	private const int MAX_CARDS_MAIN = 65;

	[Token(Token = "0x400B1CF")]
	private const int THRESHOLD_CARDS_MAIN = 50;

	[Token(Token = "0x400B1D0")]
	private const int DEFAULT_ROWS_MAIN = 5;

	[Token(Token = "0x400B1D1")]
	private const int DEFAULT_COLUMNS_MAIN = 10;

	[Token(Token = "0x400B1D2")]
	private const int MIN_COLUMNS_MAIN = 15;

	[Token(Token = "0x400B1D3")]
	private const int MAX_COLUMNS_MAIN = 15;

	[Token(Token = "0x400B1D4")]
	private const int MAX_CARDS_EX = 20;

	[Token(Token = "0x400B1D5")]
	private const int THRESHOLD_CARDS_EX = 20;

	[Token(Token = "0x400B1D6")]
	private const int DEFAULT_ROWS_EX = 2;

	[Token(Token = "0x400B1D7")]
	private const int DEFAULT_COLUMNS_EX = 10;

	[Token(Token = "0x400B1D8")]
	private const int MIN_COLUMNS_EX = 20;

	[Token(Token = "0x400B1D9")]
	private const int MAX_COLUMNS_EX = 15;

	[Token(Token = "0x400B1DA")]
	private const int MAX_CARDS_DISMANTLE_POOL = 60;

	[Token(Token = "0x400B1DB")]
	private const int MAX_CARDS_LOCK_POOL = 50;

	[Token(Token = "0x400B1DC")]
	private const int MAX_CARDS_DECKCONTENT_CARDGROUP = 5;

	[Token(Token = "0x400B1DD")]
	[FieldOffset(Offset = "0x138")]
	public int m_MaxCol;

	[Token(Token = "0x400B1DE")]
	[FieldOffset(Offset = "0x13C")]
	private bool m_RegulationVisible;

	[Token(Token = "0x400B1DF")]
	[FieldOffset(Offset = "0x140")]
	private int m_RegulationID;

	[Token(Token = "0x400B1E0")]
	[FieldOffset(Offset = "0x144")]
	private int m_RentalCardID;

	[Token(Token = "0x400B1E1")]
	[FieldOffset(Offset = "0x148")]
	private bool m_RarityVisble;

	[Token(Token = "0x400B1E2")]
	[FieldOffset(Offset = "0x149")]
	private bool m_MonochromeEnable;

	[Token(Token = "0x400B1E3")]
	[FieldOffset(Offset = "0x14A")]
	private bool m_PremiumCheckEnable;

	[Token(Token = "0x400B1E4")]
	[FieldOffset(Offset = "0x14C")]
	private Vector2Int AspectRatioMainDeck;

	[Token(Token = "0x400B1E5")]
	[FieldOffset(Offset = "0x154")]
	private Vector2Int AspectRatioExDeck;

	[Token(Token = "0x400B1E6")]
	[FieldOffset(Offset = "0x160")]
	private DeckCard template_DeckCard;

	[Token(Token = "0x400B1E7")]
	[FieldOffset(Offset = "0x168")]
	private SortComparer.Sorter deckSorter;

	[Token(Token = "0x400B1E8")]
	[FieldOffset(Offset = "0x170")]
	private DeckCard currentCard;

	[Token(Token = "0x400B1E9")]
	[FieldOffset(Offset = "0x178")]
	private DeckContentWidget deckContents;

	[Token(Token = "0x400B1EA")]
	[FieldOffset(Offset = "0x180")]
	public List<CardBaseData> mainCardDataList;

	[Token(Token = "0x400B1EB")]
	[FieldOffset(Offset = "0x188")]
	public List<CardBaseData> extraCardDataList;

	[Token(Token = "0x400B1EF")]
	[FieldOffset(Offset = "0x1A8")]
	private int currentSelectIndex;

	[Token(Token = "0x400B1F0")]
	[FieldOffset(Offset = "0x1AC")]
	private DeckEditViewController2.DisplayMode displayMode;

	[Token(Token = "0x400B1F1")]
	[FieldOffset(Offset = "0x1B0")]
	private EntityPoolController entityPoolController;

	[Token(Token = "0x400B1F4")]
	[FieldOffset(Offset = "0x1C8")]
	private List<CardBaseData> dismantlePoolDataList;

	[Token(Token = "0x400B1F5")]
	[FieldOffset(Offset = "0x1D0")]
	private List<CardBaseData> lockPoolDataList;

	[Token(Token = "0x400B1F6")]
	[FieldOffset(Offset = "0x1D8")]
	private SortComparer.Sorter dismantlePoolSorter;

	[Token(Token = "0x400B1F7")]
	[FieldOffset(Offset = "0x1E0")]
	private SortComparer.Sorter lockPoolSorter;

	[Token(Token = "0x170010B3")]
	public bool isMobileLayout
	{
		[Token(Token = "0x600687D")]
		[Address(RVA = "0x416680", Offset = "0x415880", VA = "0x180416680")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600687E")]
		[Address(RVA = "0x4166E0", Offset = "0x4158E0", VA = "0x1804166E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x170010B4")]
	public bool isLoading
	{
		[Token(Token = "0x600687F")]
		[Address(RVA = "0x5D7890", Offset = "0x5D6A90", VA = "0x1805D7890")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6006880")]
		[Address(RVA = "0x671010", Offset = "0x670210", VA = "0x180671010")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x170010B5")]
	public bool isSelected
	{
		[Token(Token = "0x6006881")]
		[Address(RVA = "0x588F60", Offset = "0x588160", VA = "0x180588F60")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6006882")]
		[Address(RVA = "0x588F70", Offset = "0x588170", VA = "0x180588F70")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x170010B6")]
	private RectTransform m_MainDeckContent
	{
		[Token(Token = "0x600689A")]
		[Address(RVA = "0x414E80", Offset = "0x414080", VA = "0x180414E80")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x600689B")]
		[Address(RVA = "0x414E90", Offset = "0x414090", VA = "0x180414E90")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x170010B7")]
	private ExtendedTextMeshProUGUI m_MainDeckCardSumText
	{
		[Token(Token = "0x600689C")]
		[Address(RVA = "0x580700", Offset = "0x57F900", VA = "0x180580700")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x600689D")]
		[Address(RVA = "0x580760", Offset = "0x57F960", VA = "0x180580760")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x170010B8")]
	private RectTransform m_ExtraDeckContent
	{
		[Token(Token = "0x600689E")]
		[Address(RVA = "0x589E50", Offset = "0x589050", VA = "0x180589E50")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x600689F")]
		[Address(RVA = "0x589E60", Offset = "0x589060", VA = "0x180589E60")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x170010B9")]
	private ExtendedTextMeshProUGUI m_ExtraDeckCardSumText
	{
		[Token(Token = "0x60068A0")]
		[Address(RVA = "0x49B9F0", Offset = "0x49ABF0", VA = "0x18049B9F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x60068A1")]
		[Address(RVA = "0x49C1F0", Offset = "0x49B3F0", VA = "0x18049C1F0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x170010BA")]
	private ElementObjectManager m_DismantleBatchEom
	{
		[Token(Token = "0x60068A2")]
		[Address(RVA = "0x449820", Offset = "0x448A20", VA = "0x180449820")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x60068A3")]
		[Address(RVA = "0x3D77E0", Offset = "0x3D69E0", VA = "0x1803D77E0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x170010BB")]
	private RectTransform m_DismantleBatchContent
	{
		[Token(Token = "0x60068A4")]
		[Address(RVA = "0x49BD10", Offset = "0x49AF10", VA = "0x18049BD10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x60068A5")]
		[Address(RVA = "0x4573F0", Offset = "0x4565F0", VA = "0x1804573F0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x170010BC")]
	private ElementObjectManager m_LockEom
	{
		[Token(Token = "0x60068A6")]
		[Address(RVA = "0x49B7F0", Offset = "0x49A9F0", VA = "0x18049B7F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x60068A7")]
		[Address(RVA = "0x457400", Offset = "0x456600", VA = "0x180457400")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x170010BD")]
	private RectTransform m_LockContent
	{
		[Token(Token = "0x60068A8")]
		[Address(RVA = "0x49BEA0", Offset = "0x49B0A0", VA = "0x18049BEA0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x60068A9")]
		[Address(RVA = "0x457410", Offset = "0x456610", VA = "0x180457410")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x170010BE")]
	private ElementObjectManager m_ScrollEom
	{
		[Token(Token = "0x60068AA")]
		[Address(RVA = "0x49B870", Offset = "0x49AA70", VA = "0x18049B870")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x60068AB")]
		[Address(RVA = "0x42FFD0", Offset = "0x42F1D0", VA = "0x18042FFD0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x170010BF")]
	private ExtendedScrollRect m_Scroll
	{
		[Token(Token = "0x60068AC")]
		[Address(RVA = "0x49B7D0", Offset = "0x49A9D0", VA = "0x18049B7D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x60068AD")]
		[Address(RVA = "0x42FF10", Offset = "0x42F110", VA = "0x18042FF10")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x170010C0")]
	private InfinityScrollView m_InfinityScroll
	{
		[Token(Token = "0x60068AE")]
		[Address(RVA = "0x49BDF0", Offset = "0x49AFF0", VA = "0x18049BDF0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x60068AF")]
		[Address(RVA = "0x42FF30", Offset = "0x42F130", VA = "0x18042FF30")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x170010C1")]
	public RectTransform m_ScrollContent
	{
		[Token(Token = "0x60068B0")]
		[Address(RVA = "0x49BB20", Offset = "0x49AD20", VA = "0x18049BB20")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x60068B1")]
		[Address(RVA = "0x42FF50", Offset = "0x42F150", VA = "0x18042FF50")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x170010C2")]
	private ElementObjectManager m_DeckNumCounterEom
	{
		[Token(Token = "0x60068B2")]
		[Address(RVA = "0x49BB10", Offset = "0x49AD10", VA = "0x18049BB10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x60068B3")]
		[Address(RVA = "0x3DAE90", Offset = "0x3DA090", VA = "0x1803DAE90")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x170010C3")]
	private TMP_Text m_DeckNumCounterTextMain
	{
		[Token(Token = "0x60068B4")]
		[Address(RVA = "0x49BAD0", Offset = "0x49ACD0", VA = "0x18049BAD0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x60068B5")]
		[Address(RVA = "0x42FF90", Offset = "0x42F190", VA = "0x18042FF90")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x170010C4")]
	private TMP_Text m_DeckNumCounterTextExtra
	{
		[Token(Token = "0x60068B6")]
		[Address(RVA = "0x5857B0", Offset = "0x5849B0", VA = "0x1805857B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x60068B7")]
		[Address(RVA = "0x42FFB0", Offset = "0x42F1B0", VA = "0x18042FFB0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x170010C5")]
	private GameObject m_ScrollBlocker
	{
		[Token(Token = "0x60068B8")]
		[Address(RVA = "0x5961F0", Offset = "0x5953F0", VA = "0x1805961F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x60068B9")]
		[Address(RVA = "0x662500", Offset = "0x661700", VA = "0x180662500")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x170010C6")]
	private SelectionButton m_NoItemButton
	{
		[Token(Token = "0x60068BA")]
		[Address(RVA = "0x5961E0", Offset = "0x5953E0", VA = "0x1805961E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x60068BB")]
		[Address(RVA = "0x662520", Offset = "0x661720", VA = "0x180662520")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x170010C7")]
	private ExtendedTextMeshProUGUI m_NoItemButtonText
	{
		[Token(Token = "0x60068BC")]
		[Address(RVA = "0x49BAE0", Offset = "0x49ACE0", VA = "0x18049BAE0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x60068BD")]
		[Address(RVA = "0x49C200", Offset = "0x49B400", VA = "0x18049C200")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x170010C8")]
	private RectTransform m_Loading
	{
		[Token(Token = "0x60068BE")]
		[Address(RVA = "0x5961D0", Offset = "0x5953D0", VA = "0x1805961D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x60068BF")]
		[Address(RVA = "0x5FC6E0", Offset = "0x5FB8E0", VA = "0x1805FC6E0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x170010C9")]
	private RectTransform m_Viewport
	{
		[Token(Token = "0x60068C0")]
		[Address(RVA = "0x596200", Offset = "0x595400", VA = "0x180596200")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x60068C1")]
		[Address(RVA = "0x5FC6C0", Offset = "0x5FB8C0", VA = "0x1805FC6C0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x170010CA")]
	public DropArea m_DropArea
	{
		[Token(Token = "0x60068C2")]
		[Address(RVA = "0x5FC5E0", Offset = "0x5FB7E0", VA = "0x1805FC5E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x60068C3")]
		[Address(RVA = "0x5968C0", Offset = "0x595AC0", VA = "0x1805968C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x170010CB")]
	private RectTransform m_DropAreaOver
	{
		[Token(Token = "0x60068C4")]
		[Address(RVA = "0x5FC5F0", Offset = "0x5FB7F0", VA = "0x1805FC5F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x60068C5")]
		[Address(RVA = "0x5FC6A0", Offset = "0x5FB8A0", VA = "0x1805FC6A0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x170010CC")]
	private static Content m_cci
	{
		[Token(Token = "0x60068C6")]
		[Address(RVA = "0xAE4140", Offset = "0xAE3340", VA = "0x180AE4140")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170010CD")]
	public bool isPremiumCheckEnable
	{
		[Token(Token = "0x60068C7")]
		[Address(RVA = "0xAE4130", Offset = "0xAE3330", VA = "0x180AE4130")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60068C8")]
		[Address(RVA = "0xAE4550", Offset = "0xAE3750", VA = "0x180AE4550")]
		set
		{
		}
	}

	[Token(Token = "0x170010CE")]
	public Action<DeckCard, bool, int> onCreateDeckCardIdx
	{
		[Token(Token = "0x60068C9")]
		[Address(RVA = "0xAE41E0", Offset = "0xAE33E0", VA = "0x180AE41E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x60068CA")]
		[Address(RVA = "0xAE4560", Offset = "0xAE3760", VA = "0x180AE4560")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x170010CF")]
	public Action<DeckCard, bool> onCreateDeckCard
	{
		[Token(Token = "0x60068CB")]
		[Address(RVA = "0xAE41F0", Offset = "0xAE33F0", VA = "0x180AE41F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x60068CC")]
		[Address(RVA = "0xA91060", Offset = "0xA90260", VA = "0x180A91060")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x170010D0")]
	public Action<DeckCard, int> onCreateDeckCard2
	{
		[Token(Token = "0x60068CD")]
		[Address(RVA = "0xAE41D0", Offset = "0xAE33D0", VA = "0x180AE41D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x60068CE")]
		[Address(RVA = "0xA91080", Offset = "0xA90280", VA = "0x180A91080")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x170010D1")]
	public Action onNoItemButtonSelectedCallback
	{
		[Token(Token = "0x60068CF")]
		[Address(RVA = "0x49BEC0", Offset = "0x49B0C0", VA = "0x18049BEC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x60068D0")]
		[Address(RVA = "0x49C5B0", Offset = "0x49B7B0", VA = "0x18049C5B0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x170010D2")]
	public Action onNoItemButtonInputCallback
	{
		[Token(Token = "0x60068D1")]
		[Address(RVA = "0xAE4200", Offset = "0xAE3400", VA = "0x180AE4200")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x60068D2")]
		[Address(RVA = "0xAE4580", Offset = "0xAE3780", VA = "0x180AE4580")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x170010D3")]
	public List<CardBaseData> dismantleList
	{
		[Token(Token = "0x60068D3")]
		[Address(RVA = "0x49B7E0", Offset = "0x49A9E0", VA = "0x18049B7E0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170010D4")]
	public List<CardBaseData> lockList
	{
		[Token(Token = "0x60068D4")]
		[Address(RVA = "0x49B860", Offset = "0x49AA60", VA = "0x18049B860")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6006883")]
	[Address(RVA = "0xADFD90", Offset = "0xADEF90", VA = "0x180ADFD90")]
	public void SetDeckName(string s)
	{
	}

	[Token(Token = "0x6006884")]
	[Address(RVA = "0xADFFC0", Offset = "0xADF1C0", VA = "0x180ADFFC0")]
	public void SetEventDeckName(string s)
	{
	}

	[Token(Token = "0x6006885")]
	[Address(RVA = "0xAD69D0", Offset = "0xAD5BD0", VA = "0x180AD69D0")]
	public void ActivateEventDeckName(bool isActive)
	{
	}

	[Token(Token = "0x6006886")]
	[Address(RVA = "0xAE0910", Offset = "0xADFB10", VA = "0x180AE0910")]
	public void SetOnSubmitDeckName(UnityAction<string> callback)
	{
	}

	[Token(Token = "0x6006887")]
	[Address(RVA = "0xAD6990", Offset = "0xAD5B90", VA = "0x180AD6990")]
	public void ActivateDeckNameInput()
	{
	}

	[Token(Token = "0x6006888")]
	[Address(RVA = "0xADFD20", Offset = "0xADEF20", VA = "0x180ADFD20")]
	public void SetDeckCaseIcon(int deckcaseId)
	{
	}

	[Token(Token = "0x6006889")]
	[Address(RVA = "0xADFD40", Offset = "0xADEF40", VA = "0x180ADFD40")]
	public void SetDeckNameButtonActive(bool b)
	{
	}

	[Token(Token = "0x600688A")]
	[Address(RVA = "0xADFDB0", Offset = "0xADEFB0", VA = "0x180ADFDB0")]
	public void SetDismantlePoolCount()
	{
	}

	[Token(Token = "0x600688B")]
	[Address(RVA = "0xAE0140", Offset = "0xADF340", VA = "0x180AE0140")]
	public void SetLockPoolCount()
	{
	}

	[Token(Token = "0x600688C")]
	[Address(RVA = "0xADFA80", Offset = "0xADEC80", VA = "0x180ADFA80")]
	public void SetActiveMultiDismantleButton(bool active)
	{
	}

	[Token(Token = "0x600688D")]
	[Address(RVA = "0xADFB40", Offset = "0xADED40", VA = "0x180ADFB40")]
	public void SetCurrentView(bool current)
	{
	}

	[Token(Token = "0x600688E")]
	[Address(RVA = "0xAE0790", Offset = "0xADF990", VA = "0x180AE0790")]
	public void SetOnClickMultiDismantleButton(UnityAction callback)
	{
	}

	[Token(Token = "0x600688F")]
	[Address(RVA = "0xAE08B0", Offset = "0xADFAB0", VA = "0x180AE08B0")]
	public void SetOnSelectMultiDismantleButton(UnityAction callback)
	{
	}

	[Token(Token = "0x6006890")]
	[Address(RVA = "0xAE0850", Offset = "0xADFA50", VA = "0x180AE0850")]
	public void SetOnInputRightMultiDismantleButton(UnityAction<SelectionItem> callback)
	{
	}

	[Token(Token = "0x6006891")]
	[Address(RVA = "0xAE07F0", Offset = "0xADF9F0", VA = "0x180AE07F0")]
	public void SetOnClickSaveLockCardsButton(UnityAction callback)
	{
	}

	[Token(Token = "0x6006892")]
	[Address(RVA = "0xAE08E0", Offset = "0xADFAE0", VA = "0x180AE08E0")]
	public void SetOnSelectSaveLockCardsButton(UnityAction callback)
	{
	}

	[Token(Token = "0x6006893")]
	[Address(RVA = "0xAE0880", Offset = "0xADFA80", VA = "0x180AE0880")]
	public void SetOnInputRightSaveLockCardsButton(UnityAction<SelectionItem> callback)
	{
	}

	[Token(Token = "0x6006894")]
	[Address(RVA = "0xAE0760", Offset = "0xADF960", VA = "0x180AE0760")]
	public void SetOnClickAutoBuildButton(UnityAction callback)
	{
	}

	[Token(Token = "0x6006895")]
	[Address(RVA = "0xADFA60", Offset = "0xADEC60", VA = "0x180ADFA60")]
	public void SetActiveAutoBuildButton(bool active)
	{
	}

	[Token(Token = "0x6006896")]
	[Address(RVA = "0xADFFA0", Offset = "0xADF1A0", VA = "0x180ADFFA0")]
	public void SetEnableAutoBuildButton(bool active)
	{
	}

	[Token(Token = "0x6006897")]
	[Address(RVA = "0xAE0820", Offset = "0xADFA20", VA = "0x180AE0820")]
	public void SetOnClickUndoButton(UnityAction callback)
	{
	}

	[Token(Token = "0x6006898")]
	[Address(RVA = "0xAE3160", Offset = "0xAE2360", VA = "0x180AE3160")]
	public void UpdatePopup(DeckEditViewController2.OperationType type, (int, int) cardData)
	{
	}

	[Token(Token = "0x6006899")]
	[Address(RVA = "0xAE07C0", Offset = "0xADF9C0", VA = "0x180AE07C0")]
	public void SetOnClickResetDeckButton(UnityAction callback)
	{
	}

	[Token(Token = "0x60068D5")]
	[Address(RVA = "0xAE5040", Offset = "0xAE4240", VA = "0x180AE5040")]
	private void sortMainDeckCards()
	{
	}

	[Token(Token = "0x60068D6")]
	[Address(RVA = "0xAE48C0", Offset = "0xAE3AC0", VA = "0x180AE48C0")]
	private void sortExtraDeckCards()
	{
	}

	[Token(Token = "0x60068D7")]
	[Address(RVA = "0xAE45A0", Offset = "0xAE37A0", VA = "0x180AE45A0")]
	private void sortDismantlePoolCards()
	{
	}

	[Token(Token = "0x60068D8")]
	[Address(RVA = "0xAE4D10", Offset = "0xAE3F10", VA = "0x180AE4D10")]
	private void sortLockPoolCards()
	{
	}

	[Token(Token = "0x60068D9")]
	[Address(RVA = "0xAE0B40", Offset = "0xADFD40", VA = "0x180AE0B40")]
	private void SortbyLoc(DeckCard.LocationInDeck loc)
	{
	}

	[Token(Token = "0x60068DA")]
	[Address(RVA = "0xAE0AC0", Offset = "0xADFCC0", VA = "0x180AE0AC0")]
	public void SortInDeckCards()
	{
	}

	[Token(Token = "0x60068DB")]
	[Address(RVA = "0xAE0A40", Offset = "0xADFC40", VA = "0x180AE0A40")]
	public void SortInDeckCards(SortComparer.Sorter sorter)
	{
	}

	[Token(Token = "0x60068DC")]
	[Address(RVA = "0xADC1E0", Offset = "0xADB3E0", VA = "0x180ADC1E0")]
	public void InitializeDeckContents()
	{
	}

	[Token(Token = "0x60068DD")]
	[Address(RVA = "0xAD7870", Offset = "0xAD6A70", VA = "0x180AD7870")]
	private void Awake()
	{
	}

	[Token(Token = "0x60068DE")]
	[Address(RVA = "0xADBAC0", Offset = "0xADACC0", VA = "0x180ADBAC0")]
	private void InitMobileLayout()
	{
	}

	[Token(Token = "0x60068DF")]
	[Address(RVA = "0xADC5E0", Offset = "0xADB7E0", VA = "0x180ADC5E0")]
	private void InitilaizeConsoleElements()
	{
	}

	[Token(Token = "0x60068E0")]
	[Address(RVA = "0xAE0C30", Offset = "0xADFE30", VA = "0x180AE0C30")]
	private void Start()
	{
	}

	[Token(Token = "0x60068E1")]
	[Address(RVA = "0xADCA90", Offset = "0xADBC90", VA = "0x180ADCA90")]
	private DeckCard InstantiateDeckCard(CardBaseData data, RectTransform parent, int regID, DeckEditViewController2.DisplayMode mode = DeckEditViewController2.DisplayMode.Simple)
	{
		return null;
	}

	[Token(Token = "0x60068E2")]
	[Address(RVA = "0xAE3930", Offset = "0xAE2B30", VA = "0x180AE3930")]
	private float calculateSpacing(float length, float width, float columns)
	{
		return default(float);
	}

	[Token(Token = "0x60068E3")]
	[Address(RVA = "0xAE3950", Offset = "0xAE2B50", VA = "0x180AE3950")]
	private int getSizeOfColumn(Vector2 aspect, int num, int minSum)
	{
		return default(int);
	}

	[Token(Token = "0x60068E4")]
	[Address(RVA = "0xADA6F0", Offset = "0xAD98F0", VA = "0x180ADA6F0")]
	public int GetCurrentColumnNum(DeckCard.LocationInDeck loc)
	{
		return default(int);
	}

	[Token(Token = "0x60068E5")]
	[Address(RVA = "0xADAD10", Offset = "0xAD9F10", VA = "0x180ADAD10")]
	private int GetIndexInDeck(DeckCard card, DeckCard.LocationInDeck loc)
	{
		return default(int);
	}

	[Token(Token = "0x60068E6")]
	[Address(RVA = "0xADAE40", Offset = "0xADA040", VA = "0x180ADAE40")]
	public int GetIndexInDeck(DeckCard card)
	{
		return default(int);
	}

	[Token(Token = "0x60068E7")]
	[Address(RVA = "0xADCFD0", Offset = "0xADC1D0", VA = "0x180ADCFD0")]
	public bool IsLeftmostCard(DeckCard card, DeckCard.LocationInDeck loc)
	{
		return default(bool);
	}

	[Token(Token = "0x60068E8")]
	[Address(RVA = "0xADD250", Offset = "0xADC450", VA = "0x180ADD250")]
	public bool IsRightmostCard(DeckCard card, DeckCard.LocationInDeck loc)
	{
		return default(bool);
	}

	[Token(Token = "0x60068E9")]
	[Address(RVA = "0xADCBC0", Offset = "0xADBDC0", VA = "0x180ADCBC0")]
	public bool IsBottommostCard(DeckCard card, DeckCard.LocationInDeck loc)
	{
		return default(bool);
	}

	[Token(Token = "0x60068EA")]
	[Address(RVA = "0xADD3A0", Offset = "0xADC5A0", VA = "0x180ADD3A0")]
	public bool IsTopmostCard(DeckCard card, DeckCard.LocationInDeck loc)
	{
		return default(bool);
	}

	[Token(Token = "0x60068EB")]
	[Address(RVA = "0xADA1D0", Offset = "0xAD93D0", VA = "0x180ADA1D0")]
	private DeckCard GetCardAt(int index, DeckCard.LocationInDeck loc)
	{
		return null;
	}

	[Token(Token = "0x60068EC")]
	[Address(RVA = "0xADA2B0", Offset = "0xAD94B0", VA = "0x180ADA2B0")]
	public int GetCardNum(DeckCard.LocationInDeck loc)
	{
		return default(int);
	}

	[Token(Token = "0x60068ED")]
	[Address(RVA = "0xADA3A0", Offset = "0xAD95A0", VA = "0x180ADA3A0")]
	public int GetCardSumInDeck(int cardID)
	{
		return default(int);
	}

	[Token(Token = "0x60068EE")]
	[Address(RVA = "0xAE44A0", Offset = "0xAE36A0", VA = "0x180AE44A0")]
	private void setMainDeckGridSpacing()
	{
	}

	[Token(Token = "0x60068EF")]
	[Address(RVA = "0xAE43F0", Offset = "0xAE35F0", VA = "0x180AE43F0")]
	private void setExtraDeckGridSpacing()
	{
	}

	[Token(Token = "0x60068F0")]
	[Address(RVA = "0xAE42F0", Offset = "0xAE34F0", VA = "0x180AE42F0")]
	private void setCardSum(DeckCard.LocationInDeck loc)
	{
	}

	[Token(Token = "0x60068F1")]
	[Address(RVA = "0xADFFE0", Offset = "0xADF1E0", VA = "0x180ADFFE0")]
	public void SetInDeckCardSum()
	{
	}

	[Token(Token = "0x60068F2")]
	[Address(RVA = "0xAD9880", Offset = "0xAD8A80", VA = "0x180AD9880")]
	public AddableType GetAddableType(int cardID, int regulation)
	{
		return default(AddableType);
	}

	[Token(Token = "0x60068F3")]
	[Address(RVA = "0xADCBA0", Offset = "0xADBDA0", VA = "0x180ADCBA0")]
	public bool IsAddable(int cardID, int regulation)
	{
		return default(bool);
	}

	[Token(Token = "0x60068F4")]
	[Address(RVA = "0xAD7B50", Offset = "0xAD6D50", VA = "0x180AD7B50")]
	public bool CheckNumLimit(int regulation)
	{
		return default(bool);
	}

	[Token(Token = "0x60068F5")]
	[Address(RVA = "0xAD72F0", Offset = "0xAD64F0", VA = "0x180AD72F0")]
	public DeckCard AddToDeck(int id, int prem = 1, bool owned = true, bool isRental = false, bool isAutoBuild = false, int reg = -1, bool sort = true, bool isIni = false, DeckCard.LocationInDeck location = DeckCard.LocationInDeck.NA, bool noAdd = false)
	{
		return null;
	}

	[Token(Token = "0x60068F6")]
	[Address(RVA = "0xADD1C0", Offset = "0xADC3C0", VA = "0x180ADD1C0")]
	public bool IsRemovable(int id, int premiumID)
	{
		return default(bool);
	}

	[Token(Token = "0x60068F7")]
	[Address(RVA = "0xAE2190", Offset = "0xAE1390", VA = "0x180AE2190")]
	public void UpdateDeckNumCounter()
	{
	}

	[Token(Token = "0x60068F8")]
	[Address(RVA = "0xAE3CD0", Offset = "0xAE2ED0", VA = "0x180AE3CD0")]
	private List<DeckCard> getTargetCardsInDeck(int cardID)
	{
		return null;
	}

	[Token(Token = "0x60068F9")]
	[Address(RVA = "0xAE39D0", Offset = "0xAE2BD0", VA = "0x180AE39D0")]
	private List<DeckCard> getTargetCardsInDeck(int cardID, int premiumID, bool isRental = false)
	{
		return null;
	}

	[Token(Token = "0x60068FA")]
	[Address(RVA = "0xAE3F80", Offset = "0xAE3180", VA = "0x180AE3F80")]
	private List<DeckCard> getTargetCardsInDismantlePool(CardBaseData data)
	{
		return null;
	}

	[Token(Token = "0x60068FB")]
	[Address(RVA = "0xADFEB0", Offset = "0xADF0B0", VA = "0x180ADFEB0")]
	public void SetDispNoItemButton(bool disp)
	{
	}

	[Token(Token = "0x60068FC")]
	[Address(RVA = "0xAE4280", Offset = "0xAE3480", VA = "0x180AE4280")]
	private bool isMainDeckFull()
	{
		return default(bool);
	}

	[Token(Token = "0x60068FD")]
	[Address(RVA = "0xAE4210", Offset = "0xAE3410", VA = "0x180AE4210")]
	private bool isExtraDeckFull()
	{
		return default(bool);
	}

	[Token(Token = "0x60068FE")]
	[Address(RVA = "0xADB130", Offset = "0xADA330", VA = "0x180ADB130")]
	public (CardCollectionInfo.Premium, bool, bool) GetLowPremiumInDeck(int cardID)
	{
		return default((CardCollectionInfo.Premium, bool, bool));
	}

	[Token(Token = "0x60068FF")]
	[Address(RVA = "0xADAAE0", Offset = "0xAD9CE0", VA = "0x180ADAAE0")]
	public List<CardBaseData> GetInDeckCards(DeckInfo.DeckType type)
	{
		return null;
	}

	[Token(Token = "0x6006900")]
	[Address(RVA = "0xADA5B0", Offset = "0xAD97B0", VA = "0x180ADA5B0")]
	public int GetCardTotalInDeck(DeckInfo.DeckType type)
	{
		return default(int);
	}

	[Token(Token = "0x6006901")]
	[Address(RVA = "0xADAA30", Offset = "0xAD9C30", VA = "0x180ADAA30")]
	public List<CardBaseData> GetInDeckAll()
	{
		return null;
	}

	[Token(Token = "0x6006902")]
	[Address(RVA = "0xADB250", Offset = "0xADA450", VA = "0x180ADB250")]
	public int GetPremiumCardSumInDeck(int id, CardCollectionInfo.Premium premiumID, bool isRental = false)
	{
		return default(int);
	}

	[Token(Token = "0x6006903")]
	[Address(RVA = "0xADAB90", Offset = "0xAD9D90", VA = "0x180ADAB90")]
	public InDeckNumInfo GetInDeckInfo(int cardID)
	{
		return null;
	}

	[Token(Token = "0x6006904")]
	[Address(RVA = "0xAD9F80", Offset = "0xAD9180", VA = "0x180AD9F80")]
	public int GetAlterCardSumInDeck(int id, CardCollectionInfo.Premium premiumID, bool isRental = false)
	{
		return default(int);
	}

	[Token(Token = "0x6006905")]
	[Address(RVA = "0xADB3C0", Offset = "0xADA5C0", VA = "0x180ADB3C0")]
	public int GetPremiumCardSumInDismantlePool(CardBaseData data)
	{
		return default(int);
	}

	[Token(Token = "0x6006906")]
	[Address(RVA = "0xADB4C0", Offset = "0xADA6C0", VA = "0x180ADB4C0")]
	public int GetPremiumCardSumInLockPool(CardBaseData data)
	{
		return default(int);
	}

	[Token(Token = "0x6006907")]
	[Address(RVA = "0xADCCE0", Offset = "0xADBEE0", VA = "0x180ADCCE0")]
	public bool IsContainsUncraftedCard()
	{
		return default(bool);
	}

	[Token(Token = "0x6006908")]
	[Address(RVA = "0xAE2F30", Offset = "0xAE2130", VA = "0x180AE2F30")]
	public void UpdateIsOwned(bool styleFilling = true)
	{
	}

	[Token(Token = "0x6006909")]
	[Address(RVA = "0xAE27D0", Offset = "0xAE19D0", VA = "0x180AE27D0")]
	public void UpdateIsOwned(int cardID, bool isRental, bool styleFilling = true)
	{
	}

	[Token(Token = "0x600690A")]
	[Address(RVA = "0xAE16E0", Offset = "0xAE08E0", VA = "0x180AE16E0")]
	public void UpdateAllAutoBuildImage()
	{
	}

	[Token(Token = "0x600690B")]
	[Address(RVA = "0xAE30B0", Offset = "0xAE22B0", VA = "0x180AE30B0")]
	private CardBaseData UpdateIsOwned(CardBaseData baseData, ref int numN, ref int numP1, ref int numP2, bool styleFilling = true)
	{
		return default(CardBaseData);
	}

	[Token(Token = "0x600690C")]
	[Address(RVA = "0xADD030", Offset = "0xADC230", VA = "0x180ADD030")]
	public bool IsModified(List<CardBaseData> oldMainCards, List<CardBaseData> oldExtraCards)
	{
		return default(bool);
	}

	[Token(Token = "0x600690D")]
	[Address(RVA = "0xADD130", Offset = "0xADC330", VA = "0x180ADD130")]
	public bool IsModified(List<CardBaseData> oldLockCards)
	{
		return default(bool);
	}

	[Token(Token = "0x600690E")]
	[Address(RVA = "0xABEAD0", Offset = "0xABDCD0", VA = "0x180ABEAD0")]
	public void SetRegulation(int regulationID)
	{
	}

	[Token(Token = "0x600690F")]
	[Address(RVA = "0xAE0940", Offset = "0xADFB40", VA = "0x180AE0940")]
	public void SetRentalID(int rentalID)
	{
	}

	[Token(Token = "0x6006910")]
	[Address(RVA = "0xAE3190", Offset = "0xAE2390", VA = "0x180AE3190")]
	public void UpdateRegulation(int regulationID)
	{
	}

	[Token(Token = "0x6006911")]
	[Address(RVA = "0xAE2340", Offset = "0xAE1540", VA = "0x180AE2340")]
	public void UpdateDisplayMode(DeckEditViewController2.DisplayMode mode, bool updateScroll = true)
	{
	}

	[Token(Token = "0x6006912")]
	[Address(RVA = "0xAE2300", Offset = "0xAE1500", VA = "0x180AE2300")]
	public void UpdateDisplayModeForDeckBrowser(bool regulationVisible, int regulationID, bool rarityVisble, bool hasCard)
	{
	}

	[Token(Token = "0x6006913")]
	[Address(RVA = "0xAE2090", Offset = "0xAE1290", VA = "0x180AE2090")]
	private void UpdateDeckCard(DeckCard deckCard, bool isMonocro)
	{
	}

	[Token(Token = "0x6006914")]
	[Address(RVA = "0xAE3540", Offset = "0xAE2740", VA = "0x180AE3540")]
	public void UpdateView(bool updateDataCount)
	{
	}

	[Token(Token = "0x6006915")]
	[Address(RVA = "0xAE0E10", Offset = "0xAE0010", VA = "0x180AE0E10")]
	public void StopScroll()
	{
	}

	[Token(Token = "0x6006916")]
	[Address(RVA = "0xADA960", Offset = "0xAD9B60", VA = "0x180ADA960")]
	private DeckCard GetHeadDeckCard(DeckCard.LocationInDeck loc)
	{
		return null;
	}

	[Token(Token = "0x6006917")]
	[Address(RVA = "0xADA870", Offset = "0xAD9A70", VA = "0x180ADA870")]
	public SelectionItem GetDefaultFocusItem()
	{
		return null;
	}

	[Token(Token = "0x6006918")]
	[Address(RVA = "0xADEFB0", Offset = "0xADE1B0", VA = "0x180ADEFB0")]
	public void SelectDefaultFocusedItem()
	{
	}

	[Token(Token = "0x6006919")]
	[Address(RVA = "0x49C3B0", Offset = "0x49B5B0", VA = "0x18049C3B0")]
	public void SetCurrentCard(DeckCard card)
	{
	}

	[Token(Token = "0x600691A")]
	[Address(RVA = "0xAD9030", Offset = "0xAD8230", VA = "0x180AD9030")]
	public void CursorJumpUp()
	{
	}

	[Token(Token = "0x600691B")]
	[Address(RVA = "0xAD8520", Offset = "0xAD7720", VA = "0x180AD8520")]
	public void CursorJumpDown()
	{
	}

	[Token(Token = "0x600691C")]
	[Address(RVA = "0xAD8DB0", Offset = "0xAD7FB0", VA = "0x180AD8DB0")]
	public void CursorJumpLeft()
	{
	}

	[Token(Token = "0x600691D")]
	[Address(RVA = "0xAD8EB0", Offset = "0xAD80B0", VA = "0x180AD8EB0")]
	public void CursorJumpRight()
	{
	}

	[Token(Token = "0x600691E")]
	[Address(RVA = "0xADD2B0", Offset = "0xADC4B0", VA = "0x180ADD2B0")]
	public bool IsTailCard(DeckCard card, DeckCard.LocationInDeck location)
	{
		return default(bool);
	}

	[Token(Token = "0x600691F")]
	[Address(RVA = "0xADEFE0", Offset = "0xADE1E0", VA = "0x180ADEFE0")]
	public void SelectRightEdgeClosestItem(Vector2 screenPoint, float angleDot)
	{
	}

	[Token(Token = "0x6006920")]
	[Address(RVA = "0xADB5C0", Offset = "0xADA7C0", VA = "0x180ADB5C0")]
	private List<DeckCard> GetRightEdgeCards(List<DeckCard> cardList, DeckCard.LocationInDeck loc)
	{
		return null;
	}

	[Token(Token = "0x6006921")]
	[Address(RVA = "0xADF5D0", Offset = "0xADE7D0", VA = "0x180ADF5D0")]
	private void SelectTopEdgeItem(Vector2 screenPoint, float angleDot)
	{
	}

	[Token(Token = "0x6006922")]
	[Address(RVA = "0xADB860", Offset = "0xADAA60", VA = "0x180ADB860")]
	private List<DeckCard> GetTopEdgeCards(List<DeckCard> cardList, DeckCard.LocationInDeck loc)
	{
		return null;
	}

	[Token(Token = "0x6006923")]
	[Address(RVA = "0xADD400", Offset = "0xADC600", VA = "0x180ADD400")]
	public void OnCreateEntity(GameObject obj)
	{
	}

	[Token(Token = "0x6006924")]
	[Address(RVA = "0xADD500", Offset = "0xADC700", VA = "0x180ADD500")]
	public void OnUpdateEntity(GameObject obj, int idx)
	{
	}

	[Token(Token = "0x6006925")]
	[Address(RVA = "0xADFAA0", Offset = "0xADECA0", VA = "0x180ADFAA0")]
	public void SetActiveScroll(bool condition)
	{
	}

	[Token(Token = "0x6006926")]
	[Address(RVA = "0xAE5490", Offset = "0xAE4690", VA = "0x180AE5490")]
	[IteratorStateMachine(typeof(_003CwaitDecrementDragCounter_003Ed__290))]
	private IEnumerator waitDecrementDragCounter()
	{
		return null;
	}

	[Token(Token = "0x6006927")]
	[Address(RVA = "0xADB030", Offset = "0xADA230", VA = "0x180ADB030")]
	private (int, int) GetIndexMainDeckCard(List<CardBaseData> cardList, int cardID, int premiumID)
	{
		return default((int, int));
	}

	[Token(Token = "0x6006928")]
	[Address(RVA = "0xAE0200", Offset = "0xADF400", VA = "0x180AE0200")]
	public void SetMaxCol(int col)
	{
	}

	[Token(Token = "0x6006929")]
	[Address(RVA = "0xADFE70", Offset = "0xADF070", VA = "0x180ADFE70")]
	public void SetDispDropAreaOver(bool disp)
	{
	}

	[Token(Token = "0x600692A")]
	[Address(RVA = "0xADC290", Offset = "0xADB490", VA = "0x180ADC290")]
	public void InitializeDismantlePool()
	{
	}

	[Token(Token = "0x600692B")]
	[Address(RVA = "0xADC4E0", Offset = "0xADB6E0", VA = "0x180ADC4E0")]
	public void InitializeLockPool()
	{
	}

	[Token(Token = "0x600692C")]
	[Address(RVA = "0xAE0230", Offset = "0xADF430", VA = "0x180AE0230")]
	public void SetMode(Mode m)
	{
	}

	[Token(Token = "0x600692D")]
	[Address(RVA = "0xAE0950", Offset = "0xADFB50", VA = "0x180AE0950")]
	public void ShowLoading()
	{
	}

	[Token(Token = "0x600692E")]
	[Address(RVA = "0xADBA20", Offset = "0xADAC20", VA = "0x180ADBA20")]
	public void HideLoading()
	{
	}

	[Token(Token = "0x600692F")]
	[Address(RVA = "0xADE740", Offset = "0xADD940", VA = "0x180ADE740")]
	public void PostMultiDismantle()
	{
	}

	[Token(Token = "0x6006930")]
	[Address(RVA = "0xAD8230", Offset = "0xAD7430", VA = "0x180AD8230")]
	public void ClearAllCards()
	{
	}

	[Token(Token = "0x6006931")]
	[Address(RVA = "0xADA7C0", Offset = "0xAD99C0", VA = "0x180ADA7C0")]
	private List<CardBaseData> GetDataList(DeckCard.LocationInDeck loc)
	{
		return null;
	}

	[Token(Token = "0x6006932")]
	[Address(RVA = "0xADA820", Offset = "0xAD9A20", VA = "0x180ADA820")]
	public static DeckContentWidget.DeckType GetDeckType(DeckCard.LocationInDeck loc)
	{
		return default(DeckContentWidget.DeckType);
	}

	[Token(Token = "0x6006933")]
	[Address(RVA = "0xADA630", Offset = "0xAD9830", VA = "0x180ADA630")]
	private List<DeckCard> GetCards(DeckCard.LocationInDeck loc)
	{
		return null;
	}

	[Token(Token = "0x6006934")]
	[Address(RVA = "0xADA690", Offset = "0xAD9890", VA = "0x180ADA690")]
	private RectTransform GetContent(DeckCard.LocationInDeck loc)
	{
		return null;
	}

	[Token(Token = "0x6006935")]
	[Address(RVA = "0xAD6A10", Offset = "0xAD5C10", VA = "0x180AD6A10")]
	private DeckCard AddCard(CardBaseData cbd, DeckCard.LocationInDeck loc, int reg, bool sort = true, bool isIni = false, bool noAdd = false)
	{
		return null;
	}

	[Token(Token = "0x6006936")]
	[Address(RVA = "0xAD7730", Offset = "0xAD6930", VA = "0x180AD7730")]
	public DeckCard AddToMainDeckByID(int id, int prem = 1, bool owned = true, bool isRental = false, bool isAutoBuild = false, int reg = -1, bool sort = true, bool isIni = false, bool noAdd = false)
	{
		return null;
	}

	[Token(Token = "0x6006937")]
	[Address(RVA = "0xAD7520", Offset = "0xAD6720", VA = "0x180AD7520")]
	public DeckCard AddToExtraDeckByID(int id, int prem = 1, bool owned = true, bool isRental = false, bool isAutoBuild = false, int reg = -1, bool sort = true, bool isIni = false, bool noAdd = false)
	{
		return null;
	}

	[Token(Token = "0x6006938")]
	[Address(RVA = "0xAD7460", Offset = "0xAD6660", VA = "0x180AD7460")]
	public DeckCard AddToDismantlePool(CardBaseData cbd, int reg = -1, bool sort = true)
	{
		return null;
	}

	[Token(Token = "0x6006939")]
	[Address(RVA = "0xAD7660", Offset = "0xAD6860", VA = "0x180AD7660")]
	public DeckCard AddToLockPool(CardBaseData cbd, int reg = -1, bool sort = true, bool isIni = false)
	{
		return null;
	}

	[Token(Token = "0x600693A")]
	[Address(RVA = "0xADE880", Offset = "0xADDA80", VA = "0x180ADE880")]
	private DeckCard RemoveCard(CardBaseData cbd, DeckCard.LocationInDeck loc, bool sort = true)
	{
		return null;
	}

	[Token(Token = "0x600693B")]
	[Address(RVA = "0xADE7B0", Offset = "0xADD9B0", VA = "0x180ADE7B0")]
	public void RemoveCardFromMainOrExtra(int id, int premiumID, out DeckCard removedCard)
	{
	}

	[Token(Token = "0x600693C")]
	[Address(RVA = "0xADEF10", Offset = "0xADE110", VA = "0x180ADEF10")]
	public void RemoveFromDismantlePool(CardBaseData cbd, out DeckCard removedCard, bool sort = true)
	{
	}

	[Token(Token = "0x600693D")]
	[Address(RVA = "0xADEF60", Offset = "0xADE160", VA = "0x180ADEF60")]
	public void RemoveFromLockPool(CardBaseData cbd, out DeckCard removedCard, bool sort = true)
	{
	}

	[Token(Token = "0x600693E")]
	[Address(RVA = "0xAE35D0", Offset = "0xAE27D0", VA = "0x180AE35D0")]
	public DeckView()
	{
	}
}
