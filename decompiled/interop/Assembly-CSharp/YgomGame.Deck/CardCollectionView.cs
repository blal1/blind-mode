using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using YgomGame.Card;
using YgomGame.Menu;
using YgomSystem.ElementSystem;
using YgomSystem.UI;
using YgomSystem.UI.ElementWidget;
using YgomSystem.UI.InfinityScroll;
using YgomSystem.YGomTMPro;

namespace YgomGame.Deck;

[Token(Token = "0x200106A")]
public class CardCollectionView : MonoBehaviour
{
	[Token(Token = "0x200106B")]
	public abstract class PartialView
	{
		[Token(Token = "0x400AF3C")]
		[FieldOffset(Offset = "0x10")]
		protected ElementObjectManager m_Eom;

		[Token(Token = "0x400AF3D")]
		[FieldOffset(Offset = "0x18")]
		protected bool isInitialized;

		[Token(Token = "0x17000FD6")]
		public GameObject gameObject
		{
			[Token(Token = "0x600647B")]
			[Address(RVA = "0x977BA0", Offset = "0x976DA0", VA = "0x180977BA0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600647C")]
		protected abstract void InitializeElements();

		[Token(Token = "0x600647D")]
		[Address(RVA = "0x977B60", Offset = "0x976D60", VA = "0x180977B60")]
		protected void Initialize(ElementObjectManager eom)
		{
		}

		[Token(Token = "0x600647E")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		protected PartialView()
		{
		}
	}

	[Token(Token = "0x200106C")]
	public enum Area
	{
		[Token(Token = "0x400AF3F")]
		Collection,
		[Token(Token = "0x400AF40")]
		Bookmark,
		[Token(Token = "0x400AF41")]
		History
	}

	[Token(Token = "0x200106D")]
	public class TabArea : PartialView
	{
		[Token(Token = "0x200106E")]
		private class TabButton : PartialView
		{
			[Token(Token = "0x17000FDB")]
			public SelectionButton button
			{
				[Token(Token = "0x600648D")]
				[Address(RVA = "0x3D8370", Offset = "0x3D7570", VA = "0x1803D8370")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x600648E")]
				[Address(RVA = "0x3D8380", Offset = "0x3D7580", VA = "0x1803D8380")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x17000FDC")]
			public RectTransform imageOn
			{
				[Token(Token = "0x600648F")]
				[Address(RVA = "0x4030F0", Offset = "0x4022F0", VA = "0x1804030F0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x6006490")]
				[Address(RVA = "0x402FB0", Offset = "0x4021B0", VA = "0x180402FB0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x17000FDD")]
			public RectTransform imageOff
			{
				[Token(Token = "0x6006491")]
				[Address(RVA = "0x402CE0", Offset = "0x401EE0", VA = "0x180402CE0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x6006492")]
				[Address(RVA = "0x4130D0", Offset = "0x4122D0", VA = "0x1804130D0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x17000FDE")]
			public ShortcutIcon shortcutIcon
			{
				[Token(Token = "0x6006493")]
				[Address(RVA = "0x404860", Offset = "0x403A60", VA = "0x180404860")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x6006494")]
				[Address(RVA = "0x595520", Offset = "0x594720", VA = "0x180595520")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x6006495")]
			[Address(RVA = "0x965E90", Offset = "0x965090", VA = "0x180965E90")]
			public TabButton(ElementObjectManager eom)
			{
			}

			[Token(Token = "0x6006496")]
			[Address(RVA = "0xAB1580", Offset = "0xAB0780", VA = "0x180AB1580", Slot = "4")]
			protected override void InitializeElements()
			{
			}

			[Token(Token = "0x6006497")]
			[Address(RVA = "0xAB16A0", Offset = "0xAB08A0", VA = "0x180AB16A0")]
			public void Toggle(bool isOn)
			{
			}
		}

		[Token(Token = "0x400AF42")]
		private const string k_ELabelImageOn = "ImageOn";

		[Token(Token = "0x400AF43")]
		private const string k_ELabelImageOff = "ImageOff";

		[Token(Token = "0x400AF44")]
		private const string k_ELabelShortcutIcon = "ShortcutIcon";

		[Token(Token = "0x400AF45")]
		private const string k_ELabelCardListButton = "CardListButton";

		[Token(Token = "0x400AF46")]
		private const string k_ELabelBookmarkButton = "BookmarkButton";

		[Token(Token = "0x400AF47")]
		private const string k_ELabelHistoryButton = "HistoryButton";

		[Token(Token = "0x400AF48")]
		private const string k_ELabelBookmarkText = "TextBookmarkNum";

		[Token(Token = "0x400AF49")]
		[FieldOffset(Offset = "0x20")]
		private TabButton m_CardListTab;

		[Token(Token = "0x400AF4A")]
		[FieldOffset(Offset = "0x28")]
		private TabButton m_BookmarkTab;

		[Token(Token = "0x400AF4B")]
		[FieldOffset(Offset = "0x30")]
		private TabButton m_HistoryTab;

		[Token(Token = "0x400AF4C")]
		[FieldOffset(Offset = "0x38")]
		private ExtendedTextMeshProUGUI m_TextBookmarkNum;

		[Token(Token = "0x400AF4D")]
		[FieldOffset(Offset = "0x40")]
		private Dictionary<Area, TabButton> m_Tabs;

		[Token(Token = "0x400AF4E")]
		[FieldOffset(Offset = "0x48")]
		private Action OnClickCardListButtonCallback;

		[Token(Token = "0x400AF4F")]
		[FieldOffset(Offset = "0x50")]
		private Action OnClickBookmarkButtonCallback;

		[Token(Token = "0x400AF50")]
		[FieldOffset(Offset = "0x58")]
		private Action OnClickHistoryButtonCallback;

		[Token(Token = "0x17000FD7")]
		public SelectionButton m_CardListButton
		{
			[Token(Token = "0x600647F")]
			[Address(RVA = "0x571A60", Offset = "0x570C60", VA = "0x180571A60")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000FD8")]
		public SelectionButton m_BookmarkButton
		{
			[Token(Token = "0x6006480")]
			[Address(RVA = "0xAB1540", Offset = "0xAB0740", VA = "0x180AB1540")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000FD9")]
		public SelectionButton m_HistoryButton
		{
			[Token(Token = "0x6006481")]
			[Address(RVA = "0xAB1560", Offset = "0xAB0760", VA = "0x180AB1560")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000FDA")]
		public Action<Area> onChagedAreaCallback
		{
			[Token(Token = "0x6006487")]
			[Address(RVA = "0x589E50", Offset = "0x589050", VA = "0x180589E50")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6006488")]
			[Address(RVA = "0x589E60", Offset = "0x589060", VA = "0x180589E60")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x6006482")]
		[Address(RVA = "0x965E90", Offset = "0x965090", VA = "0x180965E90")]
		public TabArea(ElementObjectManager eom)
		{
		}

		[Token(Token = "0x6006483")]
		[Address(RVA = "0xAB0C30", Offset = "0xAAFE30", VA = "0x180AB0C30", Slot = "4")]
		protected override void InitializeElements()
		{
		}

		[Token(Token = "0x6006484")]
		[Address(RVA = "0xAB10C0", Offset = "0xAB02C0", VA = "0x180AB10C0")]
		public void SetOnOnClickCardListButtonCallback(Action callback)
		{
		}

		[Token(Token = "0x6006485")]
		[Address(RVA = "0xAB1000", Offset = "0xAB0200", VA = "0x180AB1000")]
		public void SetOnOnClickBookmarkButtonCallback(Action callback)
		{
		}

		[Token(Token = "0x6006486")]
		[Address(RVA = "0xAB1180", Offset = "0xAB0380", VA = "0x180AB1180")]
		public void SetOnOnClickHistoryButtonCallback(Action callback)
		{
		}

		[Token(Token = "0x6006489")]
		[Address(RVA = "0xAB13A0", Offset = "0xAB05A0", VA = "0x180AB13A0")]
		public void ToggleByArea(Area area)
		{
		}

		[Token(Token = "0x600648A")]
		[Address(RVA = "0xAB09E0", Offset = "0xAAFBE0", VA = "0x180AB09E0")]
		public void DispShotcutIconByArea(Area area, bool hide = false)
		{
		}

		[Token(Token = "0x600648B")]
		[Address(RVA = "0xAB1240", Offset = "0xAB0440", VA = "0x180AB1240")]
		public void SetShortcutIcons(SelectorManager.KeyType main, SelectorManager.KeyType sub)
		{
		}

		[Token(Token = "0x600648C")]
		[Address(RVA = "0xAB0F10", Offset = "0xAB0110", VA = "0x180AB0F10")]
		public void SetBookmarkNum(int num, int max)
		{
		}
	}

	[Token(Token = "0x200106F")]
	public class FilterAndSearchArea : PartialView
	{
		[Token(Token = "0x400AF56")]
		private const string k_ELabelInputField = "InputField";

		[Token(Token = "0x400AF57")]
		private const string k_ELabelNotOwnedButton = "NotOwnedButton";

		[Token(Token = "0x400AF58")]
		private const string k_ELabelSortButton = "SortButton";

		[Token(Token = "0x400AF59")]
		private const string k_ELabelFilterButton = "FilterButton";

		[Token(Token = "0x400AF5A")]
		private const string k_ELabelClearButton = "ClearButton";

		[Token(Token = "0x400AF65")]
		[FieldOffset(Offset = "0x70")]
		private ElementObjectManager m_SortButtonEom;

		[Token(Token = "0x400AF66")]
		private const string k_ELabelSortIconAsc = "IconAsc";

		[Token(Token = "0x400AF67")]
		private const string k_ELabelSortIconDesc = "IconDesc";

		[Token(Token = "0x400AF68")]
		private const string k_ELabelSortText = "TextTMP";

		[Token(Token = "0x400AF69")]
		[FieldOffset(Offset = "0x78")]
		private RectTransform m_SortIconAsc;

		[Token(Token = "0x400AF6A")]
		[FieldOffset(Offset = "0x80")]
		private RectTransform m_SortIconDesc;

		[Token(Token = "0x400AF6B")]
		[FieldOffset(Offset = "0x88")]
		private ExtendedTextMeshProUGUI m_SortText;

		[Token(Token = "0x400AF6C")]
		[FieldOffset(Offset = "0x90")]
		private Action OnClickSortButtonCallback;

		[Token(Token = "0x400AF6D")]
		[FieldOffset(Offset = "0x98")]
		private ElementObjectManager m_FilterButtonEom;

		[Token(Token = "0x400AF6E")]
		private const string k_ELabelFilterOnIcon = "IconOn";

		[Token(Token = "0x400AF6F")]
		private const string k_ELabelFilterOffIcon = "IconOff";

		[Token(Token = "0x400AF70")]
		private const string k_ELabelFilterOnImage = "On";

		[Token(Token = "0x400AF71")]
		private const string k_ELabelFilterOffImage = "Off";

		[Token(Token = "0x400AF72")]
		[FieldOffset(Offset = "0xA0")]
		private RectTransform m_FilterButtonImageOn;

		[Token(Token = "0x400AF73")]
		[FieldOffset(Offset = "0xA8")]
		private RectTransform m_FilterButtonImageOff;

		[Token(Token = "0x400AF74")]
		[FieldOffset(Offset = "0xB0")]
		private RectTransform m_FilterButtonIconOn;

		[Token(Token = "0x400AF75")]
		[FieldOffset(Offset = "0xB8")]
		private RectTransform m_FilterButtonIconOff;

		[Token(Token = "0x400AF76")]
		[FieldOffset(Offset = "0xC0")]
		private Action OnClickFilterButtonCallback;

		[Token(Token = "0x400AF77")]
		[FieldOffset(Offset = "0xC8")]
		private Action<string> OnEndSubmitEditCallback;

		[Token(Token = "0x400AF78")]
		[FieldOffset(Offset = "0xD0")]
		private ElementObjectManager m_ClearButtonEom;

		[Token(Token = "0x400AF79")]
		[FieldOffset(Offset = "0xD8")]
		private Action OnClickClearButtonCallback;

		[Token(Token = "0x400AF7A")]
		[FieldOffset(Offset = "0xE0")]
		private ElementObjectManager m_NotOwnButtonEom;

		[Token(Token = "0x400AF7B")]
		private const string k_ELabelNotOwnOnIcon = "IconOn";

		[Token(Token = "0x400AF7C")]
		private const string k_ELabelNotOwnOffIcon = "IconOff";

		[Token(Token = "0x400AF7D")]
		private const string k_ELabelNotOwnOnImage = "On";

		[Token(Token = "0x400AF7E")]
		private const string k_ELabelNotOwnOffImage = "Off";

		[Token(Token = "0x400AF7F")]
		[FieldOffset(Offset = "0xE8")]
		private RectTransform m_NotOwnButtonImageOn;

		[Token(Token = "0x400AF80")]
		[FieldOffset(Offset = "0xF0")]
		private RectTransform m_NotOwnButtonImageOff;

		[Token(Token = "0x400AF81")]
		[FieldOffset(Offset = "0xF8")]
		private RectTransform m_NotOwnButtonIconOn;

		[Token(Token = "0x400AF82")]
		[FieldOffset(Offset = "0x100")]
		private RectTransform m_NotOwnButtonIconOff;

		[Token(Token = "0x400AF83")]
		[FieldOffset(Offset = "0x108")]
		private Action OnClickNotOwnButtonCallback;

		[Token(Token = "0x17000FDF")]
		public SelectionButton m_SortButton
		{
			[Token(Token = "0x6006498")]
			[Address(RVA = "0x3D8370", Offset = "0x3D7570", VA = "0x1803D8370")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6006499")]
			[Address(RVA = "0x3D8380", Offset = "0x3D7580", VA = "0x1803D8380")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000FE0")]
		public SelectionButton m_FilterButton
		{
			[Token(Token = "0x600649A")]
			[Address(RVA = "0x4030F0", Offset = "0x4022F0", VA = "0x1804030F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600649B")]
			[Address(RVA = "0x402FB0", Offset = "0x4021B0", VA = "0x180402FB0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000FE1")]
		public InputFieldWidget m_InputField
		{
			[Token(Token = "0x600649C")]
			[Address(RVA = "0x402CE0", Offset = "0x401EE0", VA = "0x180402CE0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600649D")]
			[Address(RVA = "0x4130D0", Offset = "0x4122D0", VA = "0x1804130D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000FE2")]
		public SelectionButton m_ClearButton
		{
			[Token(Token = "0x600649E")]
			[Address(RVA = "0x404860", Offset = "0x403A60", VA = "0x180404860")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600649F")]
			[Address(RVA = "0x595520", Offset = "0x594720", VA = "0x180595520")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000FE3")]
		public SelectionButton m_NotOwnButton
		{
			[Token(Token = "0x60064A0")]
			[Address(RVA = "0x404850", Offset = "0x403A50", VA = "0x180404850")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60064A1")]
			[Address(RVA = "0x595530", Offset = "0x594730", VA = "0x180595530")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000FE4")]
		public DeviceIcon m_SortShortcutIcon
		{
			[Token(Token = "0x60064A2")]
			[Address(RVA = "0x414E80", Offset = "0x414080", VA = "0x180414E80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60064A3")]
			[Address(RVA = "0x414E90", Offset = "0x414090", VA = "0x180414E90")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000FE5")]
		public DeviceIcon m_FilterShortcutIcon
		{
			[Token(Token = "0x60064A4")]
			[Address(RVA = "0x580700", Offset = "0x57F900", VA = "0x180580700")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60064A5")]
			[Address(RVA = "0x580760", Offset = "0x57F960", VA = "0x180580760")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000FE6")]
		public DeviceIcon m_InputFieldShortcutIcon
		{
			[Token(Token = "0x60064A6")]
			[Address(RVA = "0x5EA220", Offset = "0x5E9420", VA = "0x1805EA220")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60064A7")]
			[Address(RVA = "0x81BD60", Offset = "0x81AF60", VA = "0x18081BD60")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000FE7")]
		public DeviceIcon m_ClearShortcutIcon
		{
			[Token(Token = "0x60064A8")]
			[Address(RVA = "0x589E50", Offset = "0x589050", VA = "0x180589E50")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60064A9")]
			[Address(RVA = "0x589E60", Offset = "0x589060", VA = "0x180589E60")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000FE8")]
		public DeviceIcon m_NotOwnShortcutIcon
		{
			[Token(Token = "0x60064AA")]
			[Address(RVA = "0x49B9F0", Offset = "0x49ABF0", VA = "0x18049B9F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60064AB")]
			[Address(RVA = "0x49C1F0", Offset = "0x49B3F0", VA = "0x18049C1F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x60064AC")]
		[Address(RVA = "0x965E90", Offset = "0x965090", VA = "0x180965E90")]
		public FilterAndSearchArea(ElementObjectManager eom)
		{
		}

		[Token(Token = "0x60064AD")]
		[Address(RVA = "0xAAECD0", Offset = "0xAADED0", VA = "0x180AAECD0", Slot = "4")]
		protected override void InitializeElements()
		{
		}

		[Token(Token = "0x60064AE")]
		[Address(RVA = "0xAAF100", Offset = "0xAAE300", VA = "0x180AAF100")]
		private void InitializeSortButtonElements()
		{
		}

		[Token(Token = "0x60064AF")]
		[Address(RVA = "0xAAF5D0", Offset = "0xAAE7D0", VA = "0x180AAF5D0")]
		public void SetOnOnClickSortButtonCallback(Action callback)
		{
		}

		[Token(Token = "0x60064B0")]
		[Address(RVA = "0xAAF6A0", Offset = "0xAAE8A0", VA = "0x180AAF6A0")]
		public void SetSortIcon(SortComparer.Sorter s)
		{
		}

		[Token(Token = "0x60064B1")]
		[Address(RVA = "0xAAEAC0", Offset = "0xAADCC0", VA = "0x180AAEAC0")]
		private void InitializeDispButtonElements()
		{
		}

		[Token(Token = "0x60064B2")]
		[Address(RVA = "0xAAF440", Offset = "0xAAE640", VA = "0x180AAF440")]
		public void SetOnOnClickFilterButtonCallback(Action callback)
		{
		}

		[Token(Token = "0x60064B3")]
		[Address(RVA = "0x96DC90", Offset = "0x96CE90", VA = "0x18096DC90")]
		public void ToggleFilterButton(bool isFiltered)
		{
		}

		[Token(Token = "0x60064B4")]
		[Address(RVA = "0xAAEE60", Offset = "0xAAE060", VA = "0x180AAEE60")]
		private void InitializeInputFieldElements()
		{
		}

		[Token(Token = "0x60064B5")]
		[Address(RVA = "0xAAF2C0", Offset = "0xAAE4C0", VA = "0x180AAF2C0")]
		public void SetOnEndSubmitCallback(Action<string> callback)
		{
		}

		[Token(Token = "0x60064B6")]
		[Address(RVA = "0x96CCA0", Offset = "0x96BEA0", VA = "0x18096CCA0")]
		public void ClearKeyword()
		{
		}

		[Token(Token = "0x60064B7")]
		[Address(RVA = "0xAAE9D0", Offset = "0xAADBD0", VA = "0x180AAE9D0")]
		private void InitializeClearButtonElements()
		{
		}

		[Token(Token = "0x60064B8")]
		[Address(RVA = "0xAAF380", Offset = "0xAAE580", VA = "0x180AAF380")]
		public void SetOnOnClickClearButtonCallback(Action callback)
		{
		}

		[Token(Token = "0x60064B9")]
		[Address(RVA = "0xAAEEF0", Offset = "0xAAE0F0", VA = "0x180AAEEF0")]
		private void InitializeNotOwnButtonElements()
		{
		}

		[Token(Token = "0x60064BA")]
		[Address(RVA = "0xAAF510", Offset = "0xAAE710", VA = "0x180AAF510")]
		public void SetOnOnClickNotOwnButtonCallback(Action callback)
		{
		}

		[Token(Token = "0x60064BB")]
		[Address(RVA = "0x96DD60", Offset = "0x96CF60", VA = "0x18096DD60")]
		public void ToggleNotOwnButton(bool isDispNotOwned)
		{
		}

		[Token(Token = "0x60064BC")]
		[Address(RVA = "0x96D5C0", Offset = "0x96C7C0", VA = "0x18096D5C0")]
		public void SetInteractableButtons(bool isInteractable)
		{
		}

		[Token(Token = "0x60064BD")]
		[Address(RVA = "0x96DAA0", Offset = "0x96CCA0", VA = "0x18096DAA0")]
		public void SetShortcutIcons(bool isActivate)
		{
		}
	}

	[Token(Token = "0x2001070")]
	public class RelatedArea : PartialView
	{
		[Token(Token = "0x400AF86")]
		private const string k_ELabelRelatedCardRoot = "RelatedCard";

		[Token(Token = "0x400AF87")]
		private const string k_ELabelRelatedCardText = "RelatedCardText";

		[Token(Token = "0x400AF88")]
		private const string k_ELabelRelatedCardButton = "RelatedCardButton";

		[Token(Token = "0x400AF89")]
		[FieldOffset(Offset = "0x30")]
		private ElementObjectManager m_RelatedCardEom;

		[Token(Token = "0x400AF8A")]
		[FieldOffset(Offset = "0x38")]
		private Transform m_CardRoot;

		[Token(Token = "0x400AF8B")]
		[FieldOffset(Offset = "0x40")]
		private RawImage m_CardImage;

		[Token(Token = "0x400AF8C")]
		[FieldOffset(Offset = "0x48")]
		private ExtendedTextMeshProUGUI m_CardText;

		[Token(Token = "0x400AF8D")]
		[FieldOffset(Offset = "0x50")]
		private int relatedCardID;

		[Token(Token = "0x400AF8E")]
		[FieldOffset(Offset = "0x58")]
		private Action OnSetRelatedCardCallback;

		[Token(Token = "0x400AF8F")]
		[FieldOffset(Offset = "0x60")]
		private Action OnDispRelatedCardCallback;

		[Token(Token = "0x400AF90")]
		[FieldOffset(Offset = "0x68")]
		private Action<int> OnClickRelatedCardButtonCallback;

		[Token(Token = "0x400AF91")]
		[FieldOffset(Offset = "0x70")]
		private Action<int> OnSelectdRelatedCardButtonCallback;

		[Token(Token = "0x400AF92")]
		[FieldOffset(Offset = "0x78")]
		private Action<int> OnSelectdRelatedCardButtonKetyDownCallback;

		[Token(Token = "0x400AF93")]
		private const string k_ELabelCloseButton = "CloseButton";

		[Token(Token = "0x400AF94")]
		[FieldOffset(Offset = "0x80")]
		private Action OnClickCloseButtonCallback;

		[Token(Token = "0x400AF95")]
		[FieldOffset(Offset = "0x88")]
		private Action OnSelectdCloseButtonCallback;

		[Token(Token = "0x17000FE9")]
		public SelectionButton m_CardButton
		{
			[Token(Token = "0x60064BF")]
			[Address(RVA = "0x3D8370", Offset = "0x3D7570", VA = "0x1803D8370")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60064C0")]
			[Address(RVA = "0x3D8380", Offset = "0x3D7580", VA = "0x1803D8380")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000FEA")]
		public SelectionButton m_CloseButton
		{
			[Token(Token = "0x60064C1")]
			[Address(RVA = "0x4030F0", Offset = "0x4022F0", VA = "0x1804030F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60064C2")]
			[Address(RVA = "0x402FB0", Offset = "0x4021B0", VA = "0x180402FB0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000FEB")]
		private bool isActive
		{
			[Token(Token = "0x60064C5")]
			[Address(RVA = "0xAB09A0", Offset = "0xAAFBA0", VA = "0x180AB09A0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000FEC")]
		public bool isSet
		{
			[Token(Token = "0x60064C6")]
			[Address(RVA = "0xAB09D0", Offset = "0xAAFBD0", VA = "0x180AB09D0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60064C3")]
		[Address(RVA = "0x965E90", Offset = "0x965090", VA = "0x180965E90")]
		public RelatedArea(ElementObjectManager eom)
		{
		}

		[Token(Token = "0x60064C4")]
		[Address(RVA = "0xAB00E0", Offset = "0xAAF2E0", VA = "0x180AB00E0", Slot = "4")]
		protected override void InitializeElements()
		{
		}

		[Token(Token = "0x60064C7")]
		[Address(RVA = "0xAB0270", Offset = "0xAAF470", VA = "0x180AB0270")]
		private void InitializeRelatedCardElements()
		{
		}

		[Token(Token = "0x60064C8")]
		[Address(RVA = "0xAB0720", Offset = "0xAAF920", VA = "0x180AB0720")]
		public void SetRelatedCardId(int cardId)
		{
		}

		[Token(Token = "0x60064C9")]
		[Address(RVA = "0x81BD60", Offset = "0x81AF60", VA = "0x18081BD60")]
		public void SetOnSetRelatedCardCallback(Action callback)
		{
		}

		[Token(Token = "0x60064CA")]
		[Address(RVA = "0xAAFFF0", Offset = "0xAAF1F0", VA = "0x180AAFFF0")]
		public void DispRelatedCard(bool b)
		{
		}

		[Token(Token = "0x60064CB")]
		[Address(RVA = "0x589E60", Offset = "0x589060", VA = "0x180589E60")]
		public void SetOnDispRelatedCardCallback(Action callback)
		{
		}

		[Token(Token = "0x60064CC")]
		[Address(RVA = "0xAB0450", Offset = "0xAAF650", VA = "0x180AB0450")]
		public void SetOnOnClickRelatedCardButtonCallback(Action<int> callback)
		{
		}

		[Token(Token = "0x60064CD")]
		[Address(RVA = "0xAB0680", Offset = "0xAAF880", VA = "0x180AB0680")]
		public void SetOnSelectedRelatedCardButtonCallback(Action<int> callback)
		{
		}

		[Token(Token = "0x60064CE")]
		[Address(RVA = "0xAB05B0", Offset = "0xAAF7B0", VA = "0x180AB05B0")]
		public void SetOnSelectdRelatedCardButtonKetyDownCallback(SelectorManager.KeyType main, SelectorManager.KeyType sub, Action<int> callback)
		{
		}

		[Token(Token = "0x60064CF")]
		[Address(RVA = "0xAB0070", Offset = "0xAAF270", VA = "0x180AB0070")]
		private void InitializeCloseButtonElement()
		{
		}

		[Token(Token = "0x60064D0")]
		[Address(RVA = "0xAB03A0", Offset = "0xAAF5A0", VA = "0x180AB03A0")]
		public void SetOnClickCloseButtonCallback(Action callback)
		{
		}

		[Token(Token = "0x60064D1")]
		[Address(RVA = "0xAB0500", Offset = "0xAAF700", VA = "0x180AB0500")]
		public void SetOnSelectCloseButtonCallback(Action callback)
		{
		}
	}

	[Token(Token = "0x2001071")]
	public class CardDropArea : PartialView
	{
		[Token(Token = "0x400AF96")]
		private const string k_ELabelAddBookmarkImage = "AddBookmarkImage";

		[Token(Token = "0x400AF97")]
		private const string k_ELabelIconBookmark = "IconBookmark";

		[Token(Token = "0x400AF98")]
		private const string k_ELabelIconDisableBookmark = "IconDisableBookmark";

		[Token(Token = "0x400AF99")]
		private const string k_ELabelRemoveDeckImage = "RemoveDeckImage";

		[Token(Token = "0x400AF9A")]
		private const string k_ELabelDropAreaOver = "DropAreaOver";

		[Token(Token = "0x400AF9F")]
		[FieldOffset(Offset = "0x40")]
		public GameObject m_IconBookmark;

		[Token(Token = "0x400AFA0")]
		[FieldOffset(Offset = "0x48")]
		public GameObject m_IconDisableBookmark;

		[Token(Token = "0x17000FED")]
		public DropArea m_DropArea
		{
			[Token(Token = "0x60064D7")]
			[Address(RVA = "0x3D8370", Offset = "0x3D7570", VA = "0x1803D8370")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60064D8")]
			[Address(RVA = "0x3D8380", Offset = "0x3D7580", VA = "0x1803D8380")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000FEE")]
		public RectTransform m_RemoveDeckImage
		{
			[Token(Token = "0x60064D9")]
			[Address(RVA = "0x4030F0", Offset = "0x4022F0", VA = "0x1804030F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60064DA")]
			[Address(RVA = "0x402FB0", Offset = "0x4021B0", VA = "0x180402FB0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000FEF")]
		public RectTransform m_AddBookmarkImage
		{
			[Token(Token = "0x60064DB")]
			[Address(RVA = "0x402CE0", Offset = "0x401EE0", VA = "0x180402CE0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60064DC")]
			[Address(RVA = "0x4130D0", Offset = "0x4122D0", VA = "0x1804130D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000FF0")]
		public RectTransform m_DropAreaOver
		{
			[Token(Token = "0x60064DD")]
			[Address(RVA = "0x404860", Offset = "0x403A60", VA = "0x180404860")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60064DE")]
			[Address(RVA = "0x595520", Offset = "0x594720", VA = "0x180595520")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x60064DF")]
		[Address(RVA = "0x965E90", Offset = "0x965090", VA = "0x180965E90")]
		public CardDropArea(ElementObjectManager eom)
		{
		}

		[Token(Token = "0x60064E0")]
		[Address(RVA = "0xAAB4A0", Offset = "0xAAA6A0", VA = "0x180AAB4A0", Slot = "4")]
		protected override void InitializeElements()
		{
		}
	}

	[Token(Token = "0x2001072")]
	public class CardListArea : PartialView
	{
		[Token(Token = "0x400AFA1")]
		private const int numPreLoad = 12;

		[Token(Token = "0x400AFA3")]
		private const string k_ELabelInfinityScroll = "CardList";

		[Token(Token = "0x400AFA4")]
		private const string k_ELabelLoadingIcon = "Loading";

		[Token(Token = "0x400AFA5")]
		private const string k_ELabelNoItemButton = "NoItemButton";

		[Token(Token = "0x400AFA6")]
		private const string k_ELabelNoItemText = "NoItemText";

		[Token(Token = "0x400AFA7")]
		private const string k_ELabelCollection = "CollectionAreaCenter";

		[Token(Token = "0x400AFAE")]
		[FieldOffset(Offset = "0x58")]
		private GridLayoutGroup m_GridLayout;

		[Token(Token = "0x400AFAF")]
		[FieldOffset(Offset = "0x60")]
		private CanvasGroup m_CardListCanavsGroup;

		[Token(Token = "0x400AFB0")]
		[FieldOffset(Offset = "0x68")]
		private EntityPoolController entityPoolController;

		[Token(Token = "0x400AFB1")]
		[FieldOffset(Offset = "0x70")]
		public bool isDismantleMode;

		[Token(Token = "0x17000FF1")]
		public CardCollectionView cardCollectionView
		{
			[Token(Token = "0x60064E1")]
			[Address(RVA = "0x3D8370", Offset = "0x3D7570", VA = "0x1803D8370")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60064E2")]
			[Address(RVA = "0x3D8380", Offset = "0x3D7580", VA = "0x1803D8380")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000FF2")]
		public InfinityScrollView m_InfinityScroll
		{
			[Token(Token = "0x60064E3")]
			[Address(RVA = "0x4030F0", Offset = "0x4022F0", VA = "0x1804030F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60064E4")]
			[Address(RVA = "0x402FB0", Offset = "0x4021B0", VA = "0x180402FB0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000FF3")]
		public RectTransform m_LoadingIcon
		{
			[Token(Token = "0x60064E5")]
			[Address(RVA = "0x402CE0", Offset = "0x401EE0", VA = "0x180402CE0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60064E6")]
			[Address(RVA = "0x4130D0", Offset = "0x4122D0", VA = "0x1804130D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000FF4")]
		public SelectionButton m_NoItemButton
		{
			[Token(Token = "0x60064E7")]
			[Address(RVA = "0x404860", Offset = "0x403A60", VA = "0x180404860")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60064E8")]
			[Address(RVA = "0x595520", Offset = "0x594720", VA = "0x180595520")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000FF5")]
		public ExtendedTextMeshProUGUI m_NoItemText
		{
			[Token(Token = "0x60064E9")]
			[Address(RVA = "0x404850", Offset = "0x403A50", VA = "0x180404850")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60064EA")]
			[Address(RVA = "0x595530", Offset = "0x594730", VA = "0x180595530")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000FF6")]
		public ExtendedScrollRect m_ExtendedScrollRect
		{
			[Token(Token = "0x60064EB")]
			[Address(RVA = "0x414E80", Offset = "0x414080", VA = "0x180414E80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60064EC")]
			[Address(RVA = "0x414E90", Offset = "0x414090", VA = "0x180414E90")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000FF7")]
		public RectTransform m_CollectionAreaCenter
		{
			[Token(Token = "0x60064ED")]
			[Address(RVA = "0x580700", Offset = "0x57F900", VA = "0x180580700")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60064EE")]
			[Address(RVA = "0x580760", Offset = "0x57F960", VA = "0x180580760")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000FF8")]
		private int constraintCount
		{
			[Token(Token = "0x60064EF")]
			[Address(RVA = "0x9681D0", Offset = "0x9673D0", VA = "0x1809681D0")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000FF9")]
		private int constraintCount2
		{
			[Token(Token = "0x60064F0")]
			[Address(RVA = "0x9681B0", Offset = "0x9673B0", VA = "0x1809681B0")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000FFA")]
		private List<CardBaseData> m_CardList
		{
			[Token(Token = "0x60064F1")]
			[Address(RVA = "0xAAD510", Offset = "0xAAC710", VA = "0x180AAD510")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000FFB")]
		private int regulationId
		{
			[Token(Token = "0x60064F2")]
			[Address(RVA = "0xAAD530", Offset = "0xAAC730", VA = "0x180AAD530")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000FFC")]
		private DeckEditViewController2.DisplayMode displayMode
		{
			[Token(Token = "0x60064F3")]
			[Address(RVA = "0xAAD4F0", Offset = "0xAAC6F0", VA = "0x180AAD4F0")]
			get
			{
				return default(DeckEditViewController2.DisplayMode);
			}
		}

		[Token(Token = "0x17000FFD")]
		private Area currentArea
		{
			[Token(Token = "0x60064F4")]
			[Address(RVA = "0xAAD4D0", Offset = "0xAAC6D0", VA = "0x180AAD4D0")]
			get
			{
				return default(Area);
			}
		}

		[Token(Token = "0x17000FFE")]
		public Action<CardStrip, bool> onCreateCardCallback
		{
			[Token(Token = "0x60064F8")]
			[Address(RVA = "0x49BD10", Offset = "0x49AF10", VA = "0x18049BD10")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60064F9")]
			[Address(RVA = "0x4573F0", Offset = "0x4565F0", VA = "0x1804573F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000FFF")]
		public Action<SelectionItem> onSelectedCardCallback
		{
			[Token(Token = "0x60064FA")]
			[Address(RVA = "0x49B7F0", Offset = "0x49A9F0", VA = "0x18049B7F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60064FB")]
			[Address(RVA = "0x457400", Offset = "0x456600", VA = "0x180457400")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17001000")]
		public Action<bool, CardBaseData> onUpdateViewCallback
		{
			[Token(Token = "0x6006500")]
			[Address(RVA = "0x49BEA0", Offset = "0x49B0A0", VA = "0x18049BEA0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6006501")]
			[Address(RVA = "0x457410", Offset = "0x456610", VA = "0x180457410")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17001001")]
		public Action<SelectionItem> onInputLeftEdge
		{
			[Token(Token = "0x6006509")]
			[Address(RVA = "0x49BDC0", Offset = "0x49AFC0", VA = "0x18049BDC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600650A")]
			[Address(RVA = "0x4989A0", Offset = "0x497BA0", VA = "0x1804989A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17001002")]
		public Action onInputUpEdge
		{
			[Token(Token = "0x600650B")]
			[Address(RVA = "0x49B870", Offset = "0x49AA70", VA = "0x18049B870")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600650C")]
			[Address(RVA = "0x42FFD0", Offset = "0x42F1D0", VA = "0x18042FFD0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x60064F5")]
		[Address(RVA = "0x965E90", Offset = "0x965090", VA = "0x180965E90")]
		public CardListArea(ElementObjectManager eom)
		{
		}

		[Token(Token = "0x60064F6")]
		[Address(RVA = "0xAABA60", Offset = "0xAAAC60", VA = "0x180AABA60", Slot = "4")]
		protected override void InitializeElements()
		{
		}

		[Token(Token = "0x60064F7")]
		[Address(RVA = "0xAAC0D0", Offset = "0xAAB2D0", VA = "0x180AAC0D0")]
		public void InitializeTemplate()
		{
		}

		[Token(Token = "0x60064FC")]
		[Address(RVA = "0xAABE70", Offset = "0xAAB070", VA = "0x180AABE70")]
		public void InitializeScroll()
		{
		}

		[Token(Token = "0x60064FD")]
		[Address(RVA = "0xAAC4A0", Offset = "0xAAB6A0", VA = "0x180AAC4A0")]
		private void OnCreateEntity(GameObject obj)
		{
		}

		[Token(Token = "0x60064FE")]
		[Address(RVA = "0xAAC790", Offset = "0xAAB990", VA = "0x180AAC790")]
		private void OnUpdateEntity(GameObject obj, int idx)
		{
		}

		[Token(Token = "0x60064FF")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60")]
		private void OnRemoveEntity(GameObject obj, int idx, bool isTop)
		{
		}

		[Token(Token = "0x6006502")]
		[Address(RVA = "0xAAD080", Offset = "0xAAC280", VA = "0x180AAD080")]
		public void UpdateView(bool updateDataCount, bool select = true)
		{
		}

		[Token(Token = "0x6006503")]
		[Address(RVA = "0xAAB950", Offset = "0xAAAB50", VA = "0x180AAB950")]
		public int GetIndex(int cardID, int premiumID = -1)
		{
			return default(int);
		}

		[Token(Token = "0x6006504")]
		[Address(RVA = "0xAAB780", Offset = "0xAAA980", VA = "0x180AAB780")]
		public void CursorJumpUp()
		{
		}

		[Token(Token = "0x6006505")]
		[Address(RVA = "0xAAB6B0", Offset = "0xAAA8B0", VA = "0x180AAB6B0")]
		public void CursorJumpDown()
		{
		}

		[Token(Token = "0x6006506")]
		[Address(RVA = "0x966040", Offset = "0x965240", VA = "0x180966040")]
		public void CursorJumpRight()
		{
		}

		[Token(Token = "0x6006507")]
		[Address(RVA = "0x965FD0", Offset = "0x9651D0", VA = "0x180965FD0")]
		public void CursorJumpLeft()
		{
		}

		[Token(Token = "0x6006508")]
		[Address(RVA = "0xAAB850", Offset = "0xAAAA50", VA = "0x180AAB850")]
		public void FocusItemAt(int index, bool immediate, bool select)
		{
		}

		[Token(Token = "0x600650D")]
		[Address(RVA = "0xAAC5D0", Offset = "0xAAB7D0", VA = "0x180AAC5D0")]
		private bool OnCustomEdgeTransition(SelectionItem selectionItem, PadInputDirection direction)
		{
			return default(bool);
		}

		[Token(Token = "0x600650E")]
		[Address(RVA = "0xAAC970", Offset = "0xAABB70", VA = "0x180AAC970")]
		public void SelectLeftEdgeClosestItem(Vector2 screenPoint, float angleDot, bool isIni = false)
		{
		}

		[Token(Token = "0x600650F")]
		[Address(RVA = "0x967B70", Offset = "0x966D70", VA = "0x180967B70")]
		public void StopScroll()
		{
		}

		[Token(Token = "0x6006510")]
		[Address(RVA = "0x967B00", Offset = "0x966D00", VA = "0x180967B00")]
		private void SetDispNoItem(bool disp)
		{
		}

		[Token(Token = "0x6006511")]
		[Address(RVA = "0x9661B0", Offset = "0x9653B0", VA = "0x1809661B0")]
		public void DispLoadingIcon(bool disp)
		{
		}

		[Token(Token = "0x6006512")]
		[Address(RVA = "0xAAC3C0", Offset = "0xAAB5C0", VA = "0x180AAC3C0")]
		private void InitilizeNoItem()
		{
		}
	}

	[Token(Token = "0x2001081")]
	[CompilerGenerated]
	private sealed class _003CwaitDecrementDragCounter_003Ed__143 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400AFC9")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400AFCA")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400AFCB")]
		[FieldOffset(Offset = "0x20")]
		public CardCollectionView _003C_003E4__this;

		[Token(Token = "0x17001003")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6006534")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17001004")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6006536")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6006531")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CwaitDecrementDragCounter_003Ed__143(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6006532")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6006533")]
		[Address(RVA = "0xAB36A0", Offset = "0xAB28A0", VA = "0x180AB36A0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6006535")]
		[Address(RVA = "0xAB3720", Offset = "0xAB2920", VA = "0x180AB3720", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x400AF15")]
	[FieldOffset(Offset = "0x20")]
	protected ElementObjectManager m_Eom;

	[Token(Token = "0x400AF16")]
	[FieldOffset(Offset = "0x0")]
	private static Content m_cci;

	[Token(Token = "0x400AF17")]
	private const string k_ELabelShortcutIconGroup = "ShortcutIconGroup";

	[Token(Token = "0x400AF18")]
	private const string k_ELabelShortcutIcon0 = "Icon0";

	[Token(Token = "0x400AF19")]
	private const string k_ELabelShortcutIcon1 = "Icon1";

	[Token(Token = "0x400AF1A")]
	private const string k_ELabelShortcutIconPlus = "IconPlus";

	[Token(Token = "0x400AF1B")]
	private const string k_ELabelFilterAndSortArea = "FilterAndSortArea";

	[Token(Token = "0x400AF1C")]
	private const string k_ELabelRelatedArea = "RelatedArea";

	[Token(Token = "0x400AF1D")]
	private const string k_ELabelTabArea = "TabArea";

	[Token(Token = "0x400AF1E")]
	private const string k_ELabelDropArea = "DropArea";

	[Token(Token = "0x400AF1F")]
	private const string k_ELabelCardListArea = "CardListArea";

	[Token(Token = "0x400AF20")]
	private const string k_ELabelSelectedWindowCursor = "SelectedWindowCursor";

	[Token(Token = "0x400AF21")]
	[FieldOffset(Offset = "0x28")]
	private ElementObjectManager m_FilterAndSortEom;

	[Token(Token = "0x400AF22")]
	[FieldOffset(Offset = "0x30")]
	private ElementObjectManager m_RelatedEom;

	[Token(Token = "0x400AF23")]
	[FieldOffset(Offset = "0x38")]
	private ElementObjectManager m_TabEom;

	[Token(Token = "0x400AF24")]
	[FieldOffset(Offset = "0x40")]
	private ElementObjectManager m_DropEom;

	[Token(Token = "0x400AF25")]
	[FieldOffset(Offset = "0x48")]
	private ElementObjectManager m_CardListEom;

	[Token(Token = "0x400AF2B")]
	[FieldOffset(Offset = "0x78")]
	private RectTransform m_SelectedWindowCursor;

	[Token(Token = "0x400AF2C")]
	[FieldOffset(Offset = "0x80")]
	protected List<int> pooledHistoryCardIDs;

	[Token(Token = "0x400AF2D")]
	[FieldOffset(Offset = "0x88")]
	protected List<int> pooledBookmarkCardIDs;

	[Token(Token = "0x400AF31")]
	[FieldOffset(Offset = "0xA8")]
	public UnityAction m_SortFunc;

	[Token(Token = "0x400AF34")]
	[FieldOffset(Offset = "0xB8")]
	private SelectionItem currentItem;

	[Token(Token = "0x400AF36")]
	[FieldOffset(Offset = "0xC4")]
	private DeckEditViewController2.DisplayMode displayMode;

	[Token(Token = "0x400AF37")]
	[FieldOffset(Offset = "0xC8")]
	private int regulationID;

	[Token(Token = "0x400AF38")]
	[FieldOffset(Offset = "0xCC")]
	private bool isModified;

	[Token(Token = "0x400AF3A")]
	[FieldOffset(Offset = "0xD4")]
	private bool isCurrentView;

	[Token(Token = "0x400AF3B")]
	[FieldOffset(Offset = "0xD8")]
	private Action OnToggleTabAndAreaCallback;

	[Token(Token = "0x17000FC6")]
	public FilterAndSearchArea m_FilterAndSearchArea
	{
		[Token(Token = "0x6006417")]
		[Address(RVA = "0x580700", Offset = "0x57F900", VA = "0x180580700")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6006418")]
		[Address(RVA = "0x580760", Offset = "0x57F960", VA = "0x180580760")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17000FC7")]
	public RelatedArea m_RelatedArea
	{
		[Token(Token = "0x6006419")]
		[Address(RVA = "0x5EA220", Offset = "0x5E9420", VA = "0x1805EA220")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x600641A")]
		[Address(RVA = "0x81BD60", Offset = "0x81AF60", VA = "0x18081BD60")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17000FC8")]
	public TabArea m_TabArea
	{
		[Token(Token = "0x600641B")]
		[Address(RVA = "0x589E50", Offset = "0x589050", VA = "0x180589E50")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x600641C")]
		[Address(RVA = "0x589E60", Offset = "0x589060", VA = "0x180589E60")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17000FC9")]
	public CardDropArea m_CardDropArea
	{
		[Token(Token = "0x600641D")]
		[Address(RVA = "0x49B9F0", Offset = "0x49ABF0", VA = "0x18049B9F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x600641E")]
		[Address(RVA = "0x49C1F0", Offset = "0x49B3F0", VA = "0x18049C1F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17000FCA")]
	public CardListArea m_CardListArea
	{
		[Token(Token = "0x600641F")]
		[Address(RVA = "0x449820", Offset = "0x448A20", VA = "0x180449820")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6006420")]
		[Address(RVA = "0x3D77E0", Offset = "0x3D69E0", VA = "0x1803D77E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17000FCB")]
	public Func<List<CardBaseData>> m_CollectionCardGetter
	{
		[Token(Token = "0x6006421")]
		[Address(RVA = "0x49BDC0", Offset = "0x49AFC0", VA = "0x18049BDC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6006422")]
		[Address(RVA = "0x4989A0", Offset = "0x497BA0", VA = "0x1804989A0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x17000FCC")]
	public Func<List<CardBaseData>> m_BookmarkCardGetter
	{
		[Token(Token = "0x6006423")]
		[Address(RVA = "0x49B870", Offset = "0x49AA70", VA = "0x18049B870")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6006424")]
		[Address(RVA = "0x42FFD0", Offset = "0x42F1D0", VA = "0x18042FFD0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x17000FCD")]
	public Func<List<CardBaseData>> m_HistoryCardGetter
	{
		[Token(Token = "0x6006425")]
		[Address(RVA = "0x49B7D0", Offset = "0x49A9D0", VA = "0x18049B7D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6006426")]
		[Address(RVA = "0x42FF10", Offset = "0x42F110", VA = "0x18042FF10")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x17000FCE")]
	public List<CardBaseData> m_DataList
	{
		[Token(Token = "0x6006427")]
		[Address(RVA = "0xAA4F30", Offset = "0xAA4130", VA = "0x180AA4F30")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000FCF")]
	public int m_BookmarkMax
	{
		[Token(Token = "0x6006428")]
		[Address(RVA = "0x42D5D0", Offset = "0x42C7D0", VA = "0x18042D5D0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6006429")]
		[Address(RVA = "0x42D680", Offset = "0x42C880", VA = "0x18042D680")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17000FD0")]
	public bool isRelatedCardActive
	{
		[Token(Token = "0x600642A")]
		[Address(RVA = "0x5EA5D0", Offset = "0x5E97D0", VA = "0x1805EA5D0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600642B")]
		[Address(RVA = "0xAA4FB0", Offset = "0xAA41B0", VA = "0x180AA4FB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17000FD1")]
	public Area m_Area
	{
		[Token(Token = "0x600642C")]
		[Address(RVA = "0xAA4ED0", Offset = "0xAA40D0", VA = "0x180AA4ED0")]
		[CompilerGenerated]
		get
		{
			return default(Area);
		}
		[Token(Token = "0x600642D")]
		[Address(RVA = "0xAA4930", Offset = "0xAA3B30", VA = "0x180AA4930")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17000FD2")]
	public DeckView.Mode Mode
	{
		[Token(Token = "0x600642E")]
		[Address(RVA = "0x6D4620", Offset = "0x6D3820", VA = "0x1806D4620")]
		[CompilerGenerated]
		get
		{
			return default(DeckView.Mode);
		}
		[Token(Token = "0x600642F")]
		[Address(RVA = "0x6D7640", Offset = "0x6D6840", VA = "0x1806D7640")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17000FD3")]
	public SelectionButton m_CollectionTab
	{
		[Token(Token = "0x600643B")]
		[Address(RVA = "0xAA4F00", Offset = "0xAA4100", VA = "0x180AA4F00")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000FD4")]
	public bool isLoading
	{
		[Token(Token = "0x600646C")]
		[Address(RVA = "0xAA4E90", Offset = "0xAA4090", VA = "0x180AA4E90")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000FD5")]
	public RectTransform m_CollectionAreaLayoutGroup
	{
		[Token(Token = "0x600646D")]
		[Address(RVA = "0xAA4EE0", Offset = "0xAA40E0", VA = "0x180AA4EE0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6006430")]
	[Address(RVA = "0xAA3880", Offset = "0xAA2A80", VA = "0x180AA3880")]
	public void SetReguration(int regulationID)
	{
	}

	[Token(Token = "0x6006431")]
	[Address(RVA = "0xAA2540", Offset = "0xAA1740", VA = "0x180AA2540")]
	public void SetDirty()
	{
	}

	[Token(Token = "0x6006432")]
	[Address(RVA = "0xAA1FE0", Offset = "0xAA11E0", VA = "0x180AA1FE0")]
	public bool IsModified()
	{
		return default(bool);
	}

	[Token(Token = "0x6006433")]
	[Address(RVA = "0xAA1FF0", Offset = "0xAA11F0", VA = "0x180AA1FF0")]
	public void OnSaved()
	{
	}

	[Token(Token = "0x6006434")]
	[Address(RVA = "0xAA1640", Offset = "0xAA0840", VA = "0x180AA1640")]
	protected void Awake()
	{
	}

	[Token(Token = "0x6006435")]
	[Address(RVA = "0xAA3E50", Offset = "0xAA3050", VA = "0x180AA3E50")]
	private void Start()
	{
	}

	[Token(Token = "0x6006436")]
	[Address(RVA = "0x662500", Offset = "0x661700", VA = "0x180662500")]
	public void SetOnToggleTabAndAreaCallback(Action callback)
	{
	}

	[Token(Token = "0x6006437")]
	[Address(RVA = "0xAA46D0", Offset = "0xAA38D0", VA = "0x180AA46D0")]
	public void ToggleTabAndArea(Area a)
	{
	}

	[Token(Token = "0x6006438")]
	[Address(RVA = "0xAA43E0", Offset = "0xAA35E0", VA = "0x180AA43E0")]
	public void SwitchImage(bool remove)
	{
	}

	[Token(Token = "0x6006439")]
	[Address(RVA = "0xAA47A0", Offset = "0xAA39A0", VA = "0x180AA47A0")]
	private void ToggleTab(Area a)
	{
	}

	[Token(Token = "0x600643A")]
	[Address(RVA = "0xAA4550", Offset = "0xAA3750", VA = "0x180AA4550")]
	public void ToggleNextTabAndArea()
	{
	}

	[Token(Token = "0x600643C")]
	[Address(RVA = "0xAA3DF0", Offset = "0xAA2FF0", VA = "0x180AA3DF0")]
	public void SetupTabShortcutIcon(Area currentArea)
	{
	}

	[Token(Token = "0x600643D")]
	[Address(RVA = "0xAA2A60", Offset = "0xAA1C60", VA = "0x180AA2A60")]
	public void SetOnClickCollectionTabButton(UnityAction callback)
	{
	}

	[Token(Token = "0x600643E")]
	[Address(RVA = "0xAA27C0", Offset = "0xAA19C0", VA = "0x180AA27C0")]
	public void SetOnClickBookmarkTabButton(UnityAction callback)
	{
	}

	[Token(Token = "0x600643F")]
	[Address(RVA = "0xAA2D10", Offset = "0xAA1F10", VA = "0x180AA2D10")]
	public void SetOnClickHistoryTabButton(UnityAction callback)
	{
	}

	[Token(Token = "0x6006440")]
	[Address(RVA = "0xAA3C50", Offset = "0xAA2E50", VA = "0x180AA3C50")]
	public void SetTabChangeShortcutKey(SelectorManager.KeyType main, SelectorManager.KeyType sub)
	{
	}

	[Token(Token = "0x6006441")]
	[Address(RVA = "0xAA4470", Offset = "0xAA3670", VA = "0x180AA4470")]
	public void ToggleFilterButton(bool filtered)
	{
	}

	[Token(Token = "0x6006442")]
	[Address(RVA = "0xAA4600", Offset = "0xAA3800", VA = "0x180AA4600")]
	public void ToggleShowAllCardsButton(bool showNotOwned)
	{
	}

	[Token(Token = "0x6006443")]
	[Address(RVA = "0xAA2630", Offset = "0xAA1830", VA = "0x180AA2630")]
	public void SetInteractableFilterSort(bool interactable)
	{
	}

	[Token(Token = "0x6006444")]
	[Address(RVA = "0xAA38D0", Offset = "0xAA2AD0", VA = "0x180AA38D0")]
	public void SetSearchKeyWord(string s)
	{
	}

	[Token(Token = "0x6006445")]
	[Address(RVA = "0xAA3720", Offset = "0xAA2920", VA = "0x180AA3720")]
	public void SetOnSubmitSearch(UnityAction<string> callback)
	{
	}

	[Token(Token = "0x6006446")]
	[Address(RVA = "0xAA2FA0", Offset = "0xAA21A0", VA = "0x180AA2FA0")]
	public void SetOnClickResetSearchButton(UnityAction callback)
	{
	}

	[Token(Token = "0x6006447")]
	[Address(RVA = "0xAA2BB0", Offset = "0xAA1DB0", VA = "0x180AA2BB0")]
	public void SetOnClickFilterButton(UnityAction callback)
	{
	}

	[Token(Token = "0x6006448")]
	[Address(RVA = "0xAA30F0", Offset = "0xAA22F0", VA = "0x180AA30F0")]
	public void SetOnClickShowAllCardsButton(UnityAction callback)
	{
	}

	[Token(Token = "0x6006449")]
	[Address(RVA = "0xAA3240", Offset = "0xAA2440", VA = "0x180AA3240")]
	public void SetOnClickSortButton(UnityAction callback)
	{
	}

	[Token(Token = "0x600644A")]
	[Address(RVA = "0xAA25F0", Offset = "0xAA17F0", VA = "0x180AA25F0")]
	public void SetFilterButtonShortcutKey(SelectorManager.KeyType main, SelectorManager.KeyType sub)
	{
	}

	[Token(Token = "0x600644B")]
	[Address(RVA = "0xAA3C10", Offset = "0xAA2E10", VA = "0x180AA3C10")]
	public void SetSortButtonShortcutKey(SelectorManager.KeyType main, SelectorManager.KeyType sub)
	{
	}

	[Token(Token = "0x600644C")]
	[Address(RVA = "0xAA3890", Offset = "0xAA2A90", VA = "0x180AA3890")]
	public void SetResetSearchButtonShortcutKey(SelectorManager.KeyType main, SelectorManager.KeyType sub)
	{
	}

	[Token(Token = "0x600644D")]
	[Address(RVA = "0xAA3AE0", Offset = "0xAA2CE0", VA = "0x180AA3AE0")]
	public void SetShowAllCardsButtonShortcutKey(SelectorManager.KeyType main, SelectorManager.KeyType sub)
	{
	}

	[Token(Token = "0x600644E")]
	[Address(RVA = "0xAA1610", Offset = "0xAA0810", VA = "0x180AA1610")]
	public void ActivateSearchInput()
	{
	}

	[Token(Token = "0x600644F")]
	[Address(RVA = "0xAA3C70", Offset = "0xAA2E70", VA = "0x180AA3C70")]
	public void SetTextSearchShortcutKey(SelectorManager.KeyType main, SelectorManager.KeyType sub)
	{
	}

	[Token(Token = "0x6006450")]
	[Address(RVA = "0xAA3D40", Offset = "0xAA2F40", VA = "0x180AA3D40")]
	public void SetUncurrentView()
	{
	}

	[Token(Token = "0x6006451")]
	[Address(RVA = "0xAA2420", Offset = "0xAA1620", VA = "0x180AA2420")]
	public void SetCurrentView()
	{
	}

	[Token(Token = "0x6006452")]
	[Address(RVA = "0xAA2740", Offset = "0xAA1940", VA = "0x180AA2740")]
	public void SetMode(DeckView.Mode mode)
	{
	}

	[Token(Token = "0x6006453")]
	[Address(RVA = "0xAA3B20", Offset = "0xAA2D20", VA = "0x180AA3B20")]
	public void SetSortButtonLabel(SortComparer.Sorter sorter)
	{
	}

	[Token(Token = "0x6006454")]
	[Address(RVA = "0xAA33A0", Offset = "0xAA25A0", VA = "0x180AA33A0")]
	public void SetOnSelectCloseRelatedCard(UnityAction callback)
	{
	}

	[Token(Token = "0x6006455")]
	[Address(RVA = "0xAA2910", Offset = "0xAA1B10", VA = "0x180AA2910")]
	public void SetOnClickCloseRelatedCard(UnityAction callback)
	{
	}

	[Token(Token = "0x6006456")]
	[Address(RVA = "0xAA21D0", Offset = "0xAA13D0", VA = "0x180AA21D0")]
	public void SetActiveRelatedCard(bool b, int id = 0)
	{
	}

	[Token(Token = "0x6006457")]
	[Address(RVA = "0xAA25D0", Offset = "0xAA17D0", VA = "0x180AA25D0")]
	private void SetDispRelatedCard(bool disp)
	{
	}

	[Token(Token = "0x6006458")]
	[Address(RVA = "0xAA35D0", Offset = "0xAA27D0", VA = "0x180AA35D0")]
	public void SetOnSelectRelatedCard(UnityAction<int> callback)
	{
	}

	[Token(Token = "0x6006459")]
	[Address(RVA = "0xAA2E60", Offset = "0xAA2060", VA = "0x180AA2E60")]
	public void SetOnClickRelatedCard(UnityAction<int> callback)
	{
	}

	[Token(Token = "0x600645A")]
	[Address(RVA = "0xAA3910", Offset = "0xAA2B10", VA = "0x180AA3910")]
	public void SetSelectedShortcutRelatedCard(SelectorManager.KeyType main, SelectorManager.KeyType sub, Action<int> callback)
	{
	}

	[Token(Token = "0x600645B")]
	[Address(RVA = "0xAA39F0", Offset = "0xAA2BF0", VA = "0x180AA39F0")]
	private void SetShortcut(SelectionButton button, DeviceIcon deviceIcon, SelectorManager.KeyType main, SelectorManager.KeyType sub)
	{
	}

	[Token(Token = "0x600645C")]
	[Address(RVA = "0xAA2590", Offset = "0xAA1790", VA = "0x180AA2590")]
	public void SetDispDropArea(bool disp)
	{
	}

	[Token(Token = "0x600645D")]
	[Address(RVA = "0xAA2550", Offset = "0xAA1750", VA = "0x180AA2550")]
	public void SetDispDropAreaOver(bool disp)
	{
	}

	[Token(Token = "0x600645E")]
	[Address(RVA = "0xAA1D70", Offset = "0xAA0F70", VA = "0x180AA1D70")]
	public void CursorJumpUp()
	{
	}

	[Token(Token = "0x600645F")]
	[Address(RVA = "0xAA1BA0", Offset = "0xAA0DA0", VA = "0x180AA1BA0")]
	public void CursorJumpDown()
	{
	}

	[Token(Token = "0x6006460")]
	[Address(RVA = "0xAA1CF0", Offset = "0xAA0EF0", VA = "0x180AA1CF0")]
	public void CursorJumpRight()
	{
	}

	[Token(Token = "0x6006461")]
	[Address(RVA = "0xAA1C70", Offset = "0xAA0E70", VA = "0x180AA1C70")]
	public void CursorJumpLeft()
	{
	}

	[Token(Token = "0x6006462")]
	[Address(RVA = "0xAA1E40", Offset = "0xAA1040", VA = "0x180AA1E40")]
	public void FocusItemAt(int index, bool immediate, bool select)
	{
	}

	[Token(Token = "0x6006463")]
	[Address(RVA = "0xAA1E70", Offset = "0xAA1070", VA = "0x180AA1E70")]
	public int GetIndex(int cardID, int premiumID = -1)
	{
		return default(int);
	}

	[Token(Token = "0x6006464")]
	[Address(RVA = "0xAA4CC0", Offset = "0xAA3EC0", VA = "0x180AA4CC0")]
	public void UpdateDisplayMode(DeckEditViewController2.DisplayMode mode, bool updateScroll = true)
	{
	}

	[Token(Token = "0x6006465")]
	[Address(RVA = "0xAA4D00", Offset = "0xAA3F00", VA = "0x180AA4D00")]
	public void UpdateView(bool updateDataCount, bool select = true)
	{
	}

	[Token(Token = "0x6006466")]
	[Address(RVA = "0xAA3E20", Offset = "0xAA3020", VA = "0x180AA3E20")]
	public void ShowLoading()
	{
	}

	[Token(Token = "0x6006467")]
	[Address(RVA = "0xAA1F80", Offset = "0xAA1180", VA = "0x180AA1F80")]
	public void HideLoading()
	{
	}

	[Token(Token = "0x6006468")]
	[Address(RVA = "0xAA2000", Offset = "0xAA1200", VA = "0x180AA2000")]
	public void SelectLeftEdgeClosestItem(Vector2 screenPoint, float angleDot, bool isIni = false)
	{
	}

	[Token(Token = "0x6006469")]
	[Address(RVA = "0xAA2380", Offset = "0xAA1580", VA = "0x180AA2380")]
	public void SetActiveScroll(bool condition)
	{
	}

	[Token(Token = "0x600646A")]
	[Address(RVA = "0xAA4FC0", Offset = "0xAA41C0", VA = "0x180AA4FC0")]
	[IteratorStateMachine(typeof(_003CwaitDecrementDragCounter_003Ed__143))]
	private IEnumerator waitDecrementDragCounter()
	{
		return null;
	}

	[Token(Token = "0x600646B")]
	[Address(RVA = "0xAA20E0", Offset = "0xAA12E0", VA = "0x180AA20E0")]
	public void SelectLeftUpEdgeItem(bool isIni = true)
	{
	}

	[Token(Token = "0x600646E")]
	[Address(RVA = "0xAA34F0", Offset = "0xAA26F0", VA = "0x180AA34F0")]
	public void SetOnSelectNoItemButton(UnityAction callback)
	{
	}

	[Token(Token = "0x600646F")]
	[Address(RVA = "0xAA4DD0", Offset = "0xAA3FD0", VA = "0x180AA4DD0")]
	public CardCollectionView()
	{
	}
}
