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
using YgomGame.Deck;
using YgomGame.Menu;
using YgomSystem.ElementSystem;
using YgomSystem.UI;
using YgomSystem.UI.ElementWidget;
using YgomSystem.UI.InfinityScroll;
using YgomSystem.YGomTMPro;

namespace YgomGame.CardPoolSelect;

[Token(Token = "0x2000D2B")]
public class CpsCardCollectionView : MonoBehaviour
{
	[Token(Token = "0x2000D2C")]
	public abstract class PartialView
	{
		[Token(Token = "0x4009DC3")]
		[FieldOffset(Offset = "0x10")]
		protected ElementObjectManager m_Eom;

		[Token(Token = "0x4009DC4")]
		[FieldOffset(Offset = "0x18")]
		protected bool isInitialized;

		[Token(Token = "0x17000B65")]
		public GameObject gameObject
		{
			[Token(Token = "0x6004F8B")]
			[Address(RVA = "0x977BA0", Offset = "0x976DA0", VA = "0x180977BA0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6004F8C")]
		protected abstract void InitializeElements();

		[Token(Token = "0x6004F8D")]
		[Address(RVA = "0x977B60", Offset = "0x976D60", VA = "0x180977B60")]
		protected void Initialize(ElementObjectManager eom)
		{
		}

		[Token(Token = "0x6004F8E")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		protected PartialView()
		{
		}
	}

	[Token(Token = "0x2000D2D")]
	public enum Area
	{
		[Token(Token = "0x4009DC6")]
		Collection
	}

	[Token(Token = "0x2000D2E")]
	public class FilterAndSearchArea : PartialView
	{
		[Token(Token = "0x4009DC7")]
		private const string k_ELabelInputField = "InputField";

		[Token(Token = "0x4009DC8")]
		private const string k_ELabelNotOwnedButton = "NotOwnedButton";

		[Token(Token = "0x4009DC9")]
		private const string k_ELabelSortButton = "SortButton";

		[Token(Token = "0x4009DCA")]
		private const string k_ELabelFilterButton = "FilterButton";

		[Token(Token = "0x4009DCB")]
		private const string k_ELabelClearButton = "ClearButton";

		[Token(Token = "0x4009DD6")]
		[FieldOffset(Offset = "0x70")]
		private ElementObjectManager m_SortButtonEom;

		[Token(Token = "0x4009DD7")]
		private const string k_ELabelSortIconAsc = "IconAsc";

		[Token(Token = "0x4009DD8")]
		private const string k_ELabelSortIconDesc = "IconDesc";

		[Token(Token = "0x4009DD9")]
		private const string k_ELabelSortText = "TextTMP";

		[Token(Token = "0x4009DDA")]
		[FieldOffset(Offset = "0x78")]
		private RectTransform m_SortIconAsc;

		[Token(Token = "0x4009DDB")]
		[FieldOffset(Offset = "0x80")]
		private RectTransform m_SortIconDesc;

		[Token(Token = "0x4009DDC")]
		[FieldOffset(Offset = "0x88")]
		private ExtendedTextMeshProUGUI m_SortText;

		[Token(Token = "0x4009DDD")]
		[FieldOffset(Offset = "0x90")]
		private Action OnClickSortButtonCallback;

		[Token(Token = "0x4009DDE")]
		[FieldOffset(Offset = "0x98")]
		private ElementObjectManager m_FilterButtonEom;

		[Token(Token = "0x4009DDF")]
		private const string k_ELabelFilterOnIcon = "IconOn";

		[Token(Token = "0x4009DE0")]
		private const string k_ELabelFilterOffIcon = "IconOff";

		[Token(Token = "0x4009DE1")]
		private const string k_ELabelFilterOnImage = "On";

		[Token(Token = "0x4009DE2")]
		private const string k_ELabelFilterOffImage = "Off";

		[Token(Token = "0x4009DE3")]
		[FieldOffset(Offset = "0xA0")]
		private RectTransform m_FilterButtonImageOn;

		[Token(Token = "0x4009DE4")]
		[FieldOffset(Offset = "0xA8")]
		private RectTransform m_FilterButtonImageOff;

		[Token(Token = "0x4009DE5")]
		[FieldOffset(Offset = "0xB0")]
		private RectTransform m_FilterButtonIconOn;

		[Token(Token = "0x4009DE6")]
		[FieldOffset(Offset = "0xB8")]
		private RectTransform m_FilterButtonIconOff;

		[Token(Token = "0x4009DE7")]
		[FieldOffset(Offset = "0xC0")]
		private Action OnClickFilterButtonCallback;

		[Token(Token = "0x4009DE8")]
		[FieldOffset(Offset = "0xC8")]
		private Action<string> OnEndSubmitEditCallback;

		[Token(Token = "0x4009DE9")]
		[FieldOffset(Offset = "0xD0")]
		private ElementObjectManager m_ClearButtonEom;

		[Token(Token = "0x4009DEA")]
		[FieldOffset(Offset = "0xD8")]
		private Action OnClickClearButtonCallback;

		[Token(Token = "0x4009DEB")]
		[FieldOffset(Offset = "0xE0")]
		private ElementObjectManager m_NotOwnButtonEom;

		[Token(Token = "0x4009DEC")]
		private const string k_ELabelNotOwnOnIcon = "IconOn";

		[Token(Token = "0x4009DED")]
		private const string k_ELabelNotOwnOffIcon = "IconOff";

		[Token(Token = "0x4009DEE")]
		private const string k_ELabelNotOwnOnImage = "On";

		[Token(Token = "0x4009DEF")]
		private const string k_ELabelNotOwnOffImage = "Off";

		[Token(Token = "0x4009DF0")]
		[FieldOffset(Offset = "0xE8")]
		private RectTransform m_NotOwnButtonImageOn;

		[Token(Token = "0x4009DF1")]
		[FieldOffset(Offset = "0xF0")]
		private RectTransform m_NotOwnButtonImageOff;

		[Token(Token = "0x4009DF2")]
		[FieldOffset(Offset = "0xF8")]
		private RectTransform m_NotOwnButtonIconOn;

		[Token(Token = "0x4009DF3")]
		[FieldOffset(Offset = "0x100")]
		private RectTransform m_NotOwnButtonIconOff;

		[Token(Token = "0x4009DF4")]
		[FieldOffset(Offset = "0x108")]
		private Action OnClickNotOwnButtonCallback;

		[Token(Token = "0x17000B66")]
		public SelectionButton m_SortButton
		{
			[Token(Token = "0x6004F8F")]
			[Address(RVA = "0x3D8370", Offset = "0x3D7570", VA = "0x1803D8370")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6004F90")]
			[Address(RVA = "0x3D8380", Offset = "0x3D7580", VA = "0x1803D8380")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000B67")]
		public SelectionButton m_FilterButton
		{
			[Token(Token = "0x6004F91")]
			[Address(RVA = "0x4030F0", Offset = "0x4022F0", VA = "0x1804030F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6004F92")]
			[Address(RVA = "0x402FB0", Offset = "0x4021B0", VA = "0x180402FB0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000B68")]
		public InputFieldWidget m_InputField
		{
			[Token(Token = "0x6004F93")]
			[Address(RVA = "0x402CE0", Offset = "0x401EE0", VA = "0x180402CE0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6004F94")]
			[Address(RVA = "0x4130D0", Offset = "0x4122D0", VA = "0x1804130D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000B69")]
		public SelectionButton m_ClearButton
		{
			[Token(Token = "0x6004F95")]
			[Address(RVA = "0x404860", Offset = "0x403A60", VA = "0x180404860")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6004F96")]
			[Address(RVA = "0x595520", Offset = "0x594720", VA = "0x180595520")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000B6A")]
		public SelectionButton m_NotOwnButton
		{
			[Token(Token = "0x6004F97")]
			[Address(RVA = "0x404850", Offset = "0x403A50", VA = "0x180404850")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6004F98")]
			[Address(RVA = "0x595530", Offset = "0x594730", VA = "0x180595530")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000B6B")]
		public DeviceIcon m_SortShortcutIcon
		{
			[Token(Token = "0x6004F99")]
			[Address(RVA = "0x414E80", Offset = "0x414080", VA = "0x180414E80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6004F9A")]
			[Address(RVA = "0x414E90", Offset = "0x414090", VA = "0x180414E90")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000B6C")]
		public DeviceIcon m_FilterShortcutIcon
		{
			[Token(Token = "0x6004F9B")]
			[Address(RVA = "0x580700", Offset = "0x57F900", VA = "0x180580700")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6004F9C")]
			[Address(RVA = "0x580760", Offset = "0x57F960", VA = "0x180580760")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000B6D")]
		public DeviceIcon m_InputFieldShortcutIcon
		{
			[Token(Token = "0x6004F9D")]
			[Address(RVA = "0x5EA220", Offset = "0x5E9420", VA = "0x1805EA220")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6004F9E")]
			[Address(RVA = "0x81BD60", Offset = "0x81AF60", VA = "0x18081BD60")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000B6E")]
		public DeviceIcon m_ClearShortcutIcon
		{
			[Token(Token = "0x6004F9F")]
			[Address(RVA = "0x589E50", Offset = "0x589050", VA = "0x180589E50")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6004FA0")]
			[Address(RVA = "0x589E60", Offset = "0x589060", VA = "0x180589E60")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000B6F")]
		public DeviceIcon m_NotOwnShortcutIcon
		{
			[Token(Token = "0x6004FA1")]
			[Address(RVA = "0x49B9F0", Offset = "0x49ABF0", VA = "0x18049B9F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6004FA2")]
			[Address(RVA = "0x49C1F0", Offset = "0x49B3F0", VA = "0x18049C1F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x6004FA3")]
		[Address(RVA = "0x965E90", Offset = "0x965090", VA = "0x180965E90")]
		public FilterAndSearchArea(ElementObjectManager eom)
		{
		}

		[Token(Token = "0x6004FA4")]
		[Address(RVA = "0x96CFD0", Offset = "0x96C1D0", VA = "0x18096CFD0", Slot = "4")]
		protected override void InitializeElements()
		{
		}

		[Token(Token = "0x6004FA5")]
		[Address(RVA = "0x96D400", Offset = "0x96C600", VA = "0x18096D400")]
		private void InitializeSortButtonElements()
		{
		}

		[Token(Token = "0x6004FA6")]
		[Address(RVA = "0x96D9D0", Offset = "0x96CBD0", VA = "0x18096D9D0")]
		public void SetOnOnClickSortButtonCallback(Action callback)
		{
		}

		[Token(Token = "0x6004FA7")]
		[Address(RVA = "0x96DBA0", Offset = "0x96CDA0", VA = "0x18096DBA0")]
		public void SetSortIcon(SortComparer.Sorter s)
		{
		}

		[Token(Token = "0x6004FA8")]
		[Address(RVA = "0x96CDC0", Offset = "0x96BFC0", VA = "0x18096CDC0")]
		private void InitializeDispButtonElements()
		{
		}

		[Token(Token = "0x6004FA9")]
		[Address(RVA = "0x96D840", Offset = "0x96CA40", VA = "0x18096D840")]
		public void SetOnOnClickFilterButtonCallback(Action callback)
		{
		}

		[Token(Token = "0x6004FAA")]
		[Address(RVA = "0x96DC90", Offset = "0x96CE90", VA = "0x18096DC90")]
		public void ToggleFilterButton(bool isFiltered)
		{
		}

		[Token(Token = "0x6004FAB")]
		[Address(RVA = "0x96D160", Offset = "0x96C360", VA = "0x18096D160")]
		private void InitializeInputFieldElements()
		{
		}

		[Token(Token = "0x6004FAC")]
		[Address(RVA = "0x96D6C0", Offset = "0x96C8C0", VA = "0x18096D6C0")]
		public void SetOnEndSubmitCallback(Action<string> callback)
		{
		}

		[Token(Token = "0x6004FAD")]
		[Address(RVA = "0x96CCA0", Offset = "0x96BEA0", VA = "0x18096CCA0")]
		public void ClearKeyword()
		{
		}

		[Token(Token = "0x6004FAE")]
		[Address(RVA = "0x96CCD0", Offset = "0x96BED0", VA = "0x18096CCD0")]
		private void InitializeClearButtonElements()
		{
		}

		[Token(Token = "0x6004FAF")]
		[Address(RVA = "0x96D780", Offset = "0x96C980", VA = "0x18096D780")]
		public void SetOnOnClickClearButtonCallback(Action callback)
		{
		}

		[Token(Token = "0x6004FB0")]
		[Address(RVA = "0x96D1F0", Offset = "0x96C3F0", VA = "0x18096D1F0")]
		private void InitializeNotOwnButtonElements()
		{
		}

		[Token(Token = "0x6004FB1")]
		[Address(RVA = "0x96D910", Offset = "0x96CB10", VA = "0x18096D910")]
		public void SetOnOnClickNotOwnButtonCallback(Action callback)
		{
		}

		[Token(Token = "0x6004FB2")]
		[Address(RVA = "0x96DD60", Offset = "0x96CF60", VA = "0x18096DD60")]
		public void ToggleNotOwnButton(bool isDispNotOwned)
		{
		}

		[Token(Token = "0x6004FB3")]
		[Address(RVA = "0x96D5C0", Offset = "0x96C7C0", VA = "0x18096D5C0")]
		public void SetInteractableButtons(bool isInteractable)
		{
		}

		[Token(Token = "0x6004FB4")]
		[Address(RVA = "0x96DAA0", Offset = "0x96CCA0", VA = "0x18096DAA0")]
		public void SetShortcutIcons(bool isActivate)
		{
		}
	}

	[Token(Token = "0x2000D2F")]
	public class CardDropArea : PartialView
	{
		[Token(Token = "0x4009DF5")]
		private const string k_ELabelAddBookmarkImage = "AddBookmarkImage";

		[Token(Token = "0x4009DF6")]
		private const string k_ELabelIconBookmark = "IconBookmark";

		[Token(Token = "0x4009DF7")]
		private const string k_ELabelIconDisableBookmark = "IconDisableBookmark";

		[Token(Token = "0x4009DF8")]
		private const string k_ELabelRemoveDeckImage = "RemoveDeckImage";

		[Token(Token = "0x4009DF9")]
		private const string k_ELabelDropAreaOver = "DropAreaOver";

		[Token(Token = "0x4009DFE")]
		[FieldOffset(Offset = "0x40")]
		public GameObject m_IconBookmark;

		[Token(Token = "0x4009DFF")]
		[FieldOffset(Offset = "0x48")]
		public GameObject m_IconDisableBookmark;

		[Token(Token = "0x17000B70")]
		public DropArea m_DropArea
		{
			[Token(Token = "0x6004FB6")]
			[Address(RVA = "0x3D8370", Offset = "0x3D7570", VA = "0x1803D8370")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6004FB7")]
			[Address(RVA = "0x3D8380", Offset = "0x3D7580", VA = "0x1803D8380")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000B71")]
		public RectTransform m_RemoveDeckImage
		{
			[Token(Token = "0x6004FB8")]
			[Address(RVA = "0x4030F0", Offset = "0x4022F0", VA = "0x1804030F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6004FB9")]
			[Address(RVA = "0x402FB0", Offset = "0x4021B0", VA = "0x180402FB0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000B72")]
		public RectTransform m_AddBookmarkImage
		{
			[Token(Token = "0x6004FBA")]
			[Address(RVA = "0x402CE0", Offset = "0x401EE0", VA = "0x180402CE0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6004FBB")]
			[Address(RVA = "0x4130D0", Offset = "0x4122D0", VA = "0x1804130D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000B73")]
		public RectTransform m_DropAreaOver
		{
			[Token(Token = "0x6004FBC")]
			[Address(RVA = "0x404860", Offset = "0x403A60", VA = "0x180404860")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6004FBD")]
			[Address(RVA = "0x595520", Offset = "0x594720", VA = "0x180595520")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x6004FBE")]
		[Address(RVA = "0x965E90", Offset = "0x965090", VA = "0x180965E90")]
		public CardDropArea(ElementObjectManager eom)
		{
		}

		[Token(Token = "0x6004FBF")]
		[Address(RVA = "0x965C80", Offset = "0x964E80", VA = "0x180965C80", Slot = "4")]
		protected override void InitializeElements()
		{
		}
	}

	[Token(Token = "0x2000D30")]
	public class CardListArea : PartialView
	{
		[Token(Token = "0x4009E00")]
		private const int numPreLoad = 12;

		[Token(Token = "0x4009E02")]
		private const string k_ELabelInfinityScroll = "CardList";

		[Token(Token = "0x4009E03")]
		private const string k_ELabelLoadingIcon = "Loading";

		[Token(Token = "0x4009E04")]
		private const string k_ELabelNoItemButton = "NoItemButton";

		[Token(Token = "0x4009E05")]
		private const string k_ELabelNoItemText = "NoItemText";

		[Token(Token = "0x4009E06")]
		private const string k_ELabelCollection = "CollectionAreaCenter";

		[Token(Token = "0x4009E0D")]
		[FieldOffset(Offset = "0x58")]
		private GridLayoutGroup m_GridLayout;

		[Token(Token = "0x4009E0E")]
		[FieldOffset(Offset = "0x60")]
		private CanvasGroup m_CardListCanavsGroup;

		[Token(Token = "0x4009E0F")]
		[FieldOffset(Offset = "0x68")]
		private EntityPoolController entityPoolController;

		[Token(Token = "0x4009E10")]
		[FieldOffset(Offset = "0x70")]
		public bool isDismantleMode;

		[Token(Token = "0x17000B74")]
		public CpsCardCollectionView cardCollectionView
		{
			[Token(Token = "0x6004FC0")]
			[Address(RVA = "0x3D8370", Offset = "0x3D7570", VA = "0x1803D8370")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6004FC1")]
			[Address(RVA = "0x3D8380", Offset = "0x3D7580", VA = "0x1803D8380")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000B75")]
		public InfinityScrollView m_InfinityScroll
		{
			[Token(Token = "0x6004FC2")]
			[Address(RVA = "0x4030F0", Offset = "0x4022F0", VA = "0x1804030F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6004FC3")]
			[Address(RVA = "0x402FB0", Offset = "0x4021B0", VA = "0x180402FB0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000B76")]
		public RectTransform m_LoadingIcon
		{
			[Token(Token = "0x6004FC4")]
			[Address(RVA = "0x402CE0", Offset = "0x401EE0", VA = "0x180402CE0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6004FC5")]
			[Address(RVA = "0x4130D0", Offset = "0x4122D0", VA = "0x1804130D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000B77")]
		public SelectionButton m_NoItemButton
		{
			[Token(Token = "0x6004FC6")]
			[Address(RVA = "0x404860", Offset = "0x403A60", VA = "0x180404860")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6004FC7")]
			[Address(RVA = "0x595520", Offset = "0x594720", VA = "0x180595520")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000B78")]
		public ExtendedTextMeshProUGUI m_NoItemText
		{
			[Token(Token = "0x6004FC8")]
			[Address(RVA = "0x404850", Offset = "0x403A50", VA = "0x180404850")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6004FC9")]
			[Address(RVA = "0x595530", Offset = "0x594730", VA = "0x180595530")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000B79")]
		public ExtendedScrollRect m_ExtendedScrollRect
		{
			[Token(Token = "0x6004FCA")]
			[Address(RVA = "0x414E80", Offset = "0x414080", VA = "0x180414E80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6004FCB")]
			[Address(RVA = "0x414E90", Offset = "0x414090", VA = "0x180414E90")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000B7A")]
		public RectTransform m_CollectionAreaCenter
		{
			[Token(Token = "0x6004FCC")]
			[Address(RVA = "0x580700", Offset = "0x57F900", VA = "0x180580700")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6004FCD")]
			[Address(RVA = "0x580760", Offset = "0x57F960", VA = "0x180580760")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000B7B")]
		private int constraintCount
		{
			[Token(Token = "0x6004FCE")]
			[Address(RVA = "0x9681D0", Offset = "0x9673D0", VA = "0x1809681D0")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000B7C")]
		private int constraintCount2
		{
			[Token(Token = "0x6004FCF")]
			[Address(RVA = "0x9681B0", Offset = "0x9673B0", VA = "0x1809681B0")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000B7D")]
		private List<CardBaseData> m_CardList
		{
			[Token(Token = "0x6004FD0")]
			[Address(RVA = "0x968230", Offset = "0x967430", VA = "0x180968230")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000B7E")]
		private int regulationId
		{
			[Token(Token = "0x6004FD1")]
			[Address(RVA = "0x968270", Offset = "0x967470", VA = "0x180968270")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000B7F")]
		private DeckEditViewController2.DisplayMode displayMode
		{
			[Token(Token = "0x6004FD2")]
			[Address(RVA = "0x968210", Offset = "0x967410", VA = "0x180968210")]
			get
			{
				return default(DeckEditViewController2.DisplayMode);
			}
		}

		[Token(Token = "0x17000B80")]
		private Area currentArea
		{
			[Token(Token = "0x6004FD3")]
			[Address(RVA = "0x9681F0", Offset = "0x9673F0", VA = "0x1809681F0")]
			get
			{
				return default(Area);
			}
		}

		[Token(Token = "0x17000B81")]
		public Action<CardStrip> onCreateCardCallback
		{
			[Token(Token = "0x6004FD7")]
			[Address(RVA = "0x49BD10", Offset = "0x49AF10", VA = "0x18049BD10")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6004FD8")]
			[Address(RVA = "0x4573F0", Offset = "0x4565F0", VA = "0x1804573F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000B82")]
		public Action<SelectionItem> onSelectedCardCallback
		{
			[Token(Token = "0x6004FD9")]
			[Address(RVA = "0x49B7F0", Offset = "0x49A9F0", VA = "0x18049B7F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6004FDA")]
			[Address(RVA = "0x457400", Offset = "0x456600", VA = "0x180457400")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000B83")]
		public Action<bool, CardBaseData> onUpdateViewCallback
		{
			[Token(Token = "0x6004FDF")]
			[Address(RVA = "0x49BEA0", Offset = "0x49B0A0", VA = "0x18049BEA0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6004FE0")]
			[Address(RVA = "0x457410", Offset = "0x456610", VA = "0x180457410")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000B84")]
		public Action<SelectionItem> onInputLeftEdge
		{
			[Token(Token = "0x6004FE8")]
			[Address(RVA = "0x49BDC0", Offset = "0x49AFC0", VA = "0x18049BDC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6004FE9")]
			[Address(RVA = "0x4989A0", Offset = "0x497BA0", VA = "0x1804989A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000B85")]
		public Action onInputUpEdge
		{
			[Token(Token = "0x6004FEA")]
			[Address(RVA = "0x49B870", Offset = "0x49AA70", VA = "0x18049B870")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6004FEB")]
			[Address(RVA = "0x42FFD0", Offset = "0x42F1D0", VA = "0x18042FFD0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x6004FD4")]
		[Address(RVA = "0x965E90", Offset = "0x965090", VA = "0x180965E90")]
		public CardListArea(ElementObjectManager eom)
		{
		}

		[Token(Token = "0x6004FD5")]
		[Address(RVA = "0x966500", Offset = "0x965700", VA = "0x180966500", Slot = "4")]
		protected override void InitializeElements()
		{
		}

		[Token(Token = "0x6004FD6")]
		[Address(RVA = "0x966B70", Offset = "0x965D70", VA = "0x180966B70")]
		public void InitializeTemplate()
		{
		}

		[Token(Token = "0x6004FDB")]
		[Address(RVA = "0x966910", Offset = "0x965B10", VA = "0x180966910")]
		public void InitializeScroll()
		{
		}

		[Token(Token = "0x6004FDC")]
		[Address(RVA = "0x966F40", Offset = "0x966140", VA = "0x180966F40")]
		private void OnCreateEntity(GameObject obj)
		{
		}

		[Token(Token = "0x6004FDD")]
		[Address(RVA = "0x967270", Offset = "0x966470", VA = "0x180967270")]
		private void OnUpdateEntity(GameObject obj, int idx)
		{
		}

		[Token(Token = "0x6004FDE")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60")]
		private void OnRemoveEntity(GameObject obj, int idx, bool isTop)
		{
		}

		[Token(Token = "0x6004FE1")]
		[Address(RVA = "0x967CB0", Offset = "0x966EB0", VA = "0x180967CB0")]
		public void UpdateView(bool updateDataCount, bool select = true)
		{
		}

		[Token(Token = "0x6004FE2")]
		[Address(RVA = "0x966390", Offset = "0x965590", VA = "0x180966390")]
		public int GetIndex(int cardID, int premiumID = -1)
		{
			return default(int);
		}

		[Token(Token = "0x6004FE3")]
		[Address(RVA = "0x9660C0", Offset = "0x9652C0", VA = "0x1809660C0")]
		public void CursorJumpUp()
		{
		}

		[Token(Token = "0x6004FE4")]
		[Address(RVA = "0x965EE0", Offset = "0x9650E0", VA = "0x180965EE0")]
		public void CursorJumpDown()
		{
		}

		[Token(Token = "0x6004FE5")]
		[Address(RVA = "0x966040", Offset = "0x965240", VA = "0x180966040")]
		public void CursorJumpRight()
		{
		}

		[Token(Token = "0x6004FE6")]
		[Address(RVA = "0x965FD0", Offset = "0x9651D0", VA = "0x180965FD0")]
		public void CursorJumpLeft()
		{
		}

		[Token(Token = "0x6004FE7")]
		[Address(RVA = "0x966270", Offset = "0x965470", VA = "0x180966270")]
		public void FocusItemAt(int index, bool immediate, bool select)
		{
		}

		[Token(Token = "0x6004FEC")]
		[Address(RVA = "0x967070", Offset = "0x966270", VA = "0x180967070")]
		private bool OnCustomEdgeTransition(SelectionItem selectionItem, PadInputDirection direction)
		{
			return default(bool);
		}

		[Token(Token = "0x6004FED")]
		[Address(RVA = "0x9674A0", Offset = "0x9666A0", VA = "0x1809674A0")]
		public void SelectLeftEdgeClosestItem(Vector2 screenPoint, float angleDot, bool isIni = false)
		{
		}

		[Token(Token = "0x6004FEE")]
		[Address(RVA = "0x967B70", Offset = "0x966D70", VA = "0x180967B70")]
		public void StopScroll()
		{
		}

		[Token(Token = "0x6004FEF")]
		[Address(RVA = "0x967B00", Offset = "0x966D00", VA = "0x180967B00")]
		private void SetDispNoItem(bool disp)
		{
		}

		[Token(Token = "0x6004FF0")]
		[Address(RVA = "0x9661B0", Offset = "0x9653B0", VA = "0x1809661B0")]
		public void DispLoadingIcon(bool disp)
		{
		}

		[Token(Token = "0x6004FF1")]
		[Address(RVA = "0x966E60", Offset = "0x966060", VA = "0x180966E60")]
		private void InitilizeNoItem()
		{
		}
	}

	[Token(Token = "0x2000D39")]
	[CompilerGenerated]
	private sealed class _003CwaitDecrementDragCounter_003Ed__82 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4009E21")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4009E22")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4009E23")]
		[FieldOffset(Offset = "0x20")]
		public CpsCardCollectionView _003C_003E4__this;

		[Token(Token = "0x17000B86")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6005008")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000B87")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600500A")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6005005")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CwaitDecrementDragCounter_003Ed__82(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6005006")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6005007")]
		[Address(RVA = "0x97B520", Offset = "0x97A720", VA = "0x18097B520", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6005009")]
		[Address(RVA = "0x97B5A0", Offset = "0x97A7A0", VA = "0x18097B5A0", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x4009DAB")]
	[FieldOffset(Offset = "0x20")]
	protected ElementObjectManager m_Eom;

	[Token(Token = "0x4009DAC")]
	[FieldOffset(Offset = "0x0")]
	private static Content m_cci;

	[Token(Token = "0x4009DAD")]
	private const string k_ELabelShortcutIconGroup = "ShortcutIconGroup";

	[Token(Token = "0x4009DAE")]
	private const string k_ELabelShortcutIcon0 = "Icon0";

	[Token(Token = "0x4009DAF")]
	private const string k_ELabelShortcutIcon1 = "Icon1";

	[Token(Token = "0x4009DB0")]
	private const string k_ELabelShortcutIconPlus = "IconPlus";

	[Token(Token = "0x4009DB1")]
	private const string k_ELabelFilterAndSortArea = "FilterAndSortArea";

	[Token(Token = "0x4009DB2")]
	private const string k_ELabelDropArea = "DropArea";

	[Token(Token = "0x4009DB3")]
	private const string k_ELabelCardListArea = "CardListArea";

	[Token(Token = "0x4009DB4")]
	private const string k_ELabelSelectedWindowCursor = "SelectedWindowCursor";

	[Token(Token = "0x4009DB5")]
	[FieldOffset(Offset = "0x28")]
	private ElementObjectManager m_FilterAndSortEom;

	[Token(Token = "0x4009DB6")]
	[FieldOffset(Offset = "0x30")]
	private ElementObjectManager m_DropEom;

	[Token(Token = "0x4009DB7")]
	[FieldOffset(Offset = "0x38")]
	private ElementObjectManager m_CardListEom;

	[Token(Token = "0x4009DBB")]
	[FieldOffset(Offset = "0x58")]
	private RectTransform m_SelectedWindowCursor;

	[Token(Token = "0x4009DBD")]
	[FieldOffset(Offset = "0x68")]
	public UnityAction m_SortFunc;

	[Token(Token = "0x4009DBE")]
	[FieldOffset(Offset = "0x70")]
	private SelectionItem currentItem;

	[Token(Token = "0x4009DC0")]
	[FieldOffset(Offset = "0x7C")]
	private DeckEditViewController2.DisplayMode displayMode;

	[Token(Token = "0x4009DC1")]
	[FieldOffset(Offset = "0x80")]
	private int regulationID;

	[Token(Token = "0x4009DC2")]
	[FieldOffset(Offset = "0x84")]
	private bool isCurrentView;

	[Token(Token = "0x17000B5D")]
	private FilterAndSearchArea m_FilterAndSearchArea
	{
		[Token(Token = "0x6004F53")]
		[Address(RVA = "0x404850", Offset = "0x403A50", VA = "0x180404850")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6004F54")]
		[Address(RVA = "0x595530", Offset = "0x594730", VA = "0x180595530")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x17000B5E")]
	public CardDropArea m_CardDropArea
	{
		[Token(Token = "0x6004F55")]
		[Address(RVA = "0x414E80", Offset = "0x414080", VA = "0x180414E80")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6004F56")]
		[Address(RVA = "0x414E90", Offset = "0x414090", VA = "0x180414E90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17000B5F")]
	public CardListArea m_CardListArea
	{
		[Token(Token = "0x6004F57")]
		[Address(RVA = "0x580700", Offset = "0x57F900", VA = "0x180580700")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6004F58")]
		[Address(RVA = "0x580760", Offset = "0x57F960", VA = "0x180580760")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17000B60")]
	public Func<List<CardBaseData>> m_CollectionCardGetter
	{
		[Token(Token = "0x6004F59")]
		[Address(RVA = "0x589E50", Offset = "0x589050", VA = "0x180589E50")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6004F5A")]
		[Address(RVA = "0x589E60", Offset = "0x589060", VA = "0x180589E60")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x17000B61")]
	public List<CardBaseData> m_DataList
	{
		[Token(Token = "0x6004F5B")]
		[Address(RVA = "0x96AD40", Offset = "0x969F40", VA = "0x18096AD40")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000B62")]
	public Area m_Area
	{
		[Token(Token = "0x6004F5C")]
		[Address(RVA = "0x55E5E0", Offset = "0x55D7E0", VA = "0x18055E5E0")]
		[CompilerGenerated]
		get
		{
			return default(Area);
		}
		[Token(Token = "0x6004F5D")]
		[Address(RVA = "0x55E600", Offset = "0x55D800", VA = "0x18055E600")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17000B63")]
	public bool isLoading
	{
		[Token(Token = "0x6004F84")]
		[Address(RVA = "0x96ACE0", Offset = "0x969EE0", VA = "0x18096ACE0")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000B64")]
	public RectTransform m_CollectionAreaLayoutGroup
	{
		[Token(Token = "0x6004F85")]
		[Address(RVA = "0x96AD20", Offset = "0x969F20", VA = "0x18096AD20")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6004F5E")]
	[Address(RVA = "0x588B20", Offset = "0x587D20", VA = "0x180588B20")]
	public void SetReguration(int regulationID)
	{
	}

	[Token(Token = "0x6004F5F")]
	[Address(RVA = "0x969110", Offset = "0x968310", VA = "0x180969110")]
	protected void Awake()
	{
	}

	[Token(Token = "0x6004F60")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60")]
	private void Start()
	{
	}

	[Token(Token = "0x6004F61")]
	[Address(RVA = "0x96A9D0", Offset = "0x969BD0", VA = "0x18096A9D0")]
	public void ToggleFilterButton(bool filtered)
	{
	}

	[Token(Token = "0x6004F62")]
	[Address(RVA = "0x96AAA0", Offset = "0x969CA0", VA = "0x18096AAA0")]
	public void ToggleShowAllCardsButton(bool showNotOwned)
	{
	}

	[Token(Token = "0x6004F63")]
	[Address(RVA = "0x969CB0", Offset = "0x968EB0", VA = "0x180969CB0")]
	public void SetInteractableFilterSort(bool interactable)
	{
	}

	[Token(Token = "0x6004F64")]
	[Address(RVA = "0x96A5A0", Offset = "0x9697A0", VA = "0x18096A5A0")]
	public void SetSearchKeyWord(string s)
	{
	}

	[Token(Token = "0x6004F65")]
	[Address(RVA = "0x96A400", Offset = "0x969600", VA = "0x18096A400")]
	public void SetOnSubmitSearch(UnityAction<string> callback)
	{
	}

	[Token(Token = "0x6004F66")]
	[Address(RVA = "0x969F20", Offset = "0x969120", VA = "0x180969F20")]
	public void SetOnClickResetSearchButton(UnityAction callback)
	{
	}

	[Token(Token = "0x6004F67")]
	[Address(RVA = "0x969DC0", Offset = "0x968FC0", VA = "0x180969DC0")]
	public void SetOnClickFilterButton(UnityAction callback)
	{
	}

	[Token(Token = "0x6004F68")]
	[Address(RVA = "0x96A070", Offset = "0x969270", VA = "0x18096A070")]
	public void SetOnClickShowAllCardsButton(UnityAction callback)
	{
	}

	[Token(Token = "0x6004F69")]
	[Address(RVA = "0x96A1C0", Offset = "0x9693C0", VA = "0x18096A1C0")]
	public void SetOnClickSortButton(UnityAction callback)
	{
	}

	[Token(Token = "0x6004F6A")]
	[Address(RVA = "0x969C70", Offset = "0x968E70", VA = "0x180969C70")]
	public void SetFilterButtonShortcutKey(SelectorManager.KeyType main, SelectorManager.KeyType sub)
	{
	}

	[Token(Token = "0x6004F6B")]
	[Address(RVA = "0x96A800", Offset = "0x969A00", VA = "0x18096A800")]
	public void SetSortButtonShortcutKey(SelectorManager.KeyType main, SelectorManager.KeyType sub)
	{
	}

	[Token(Token = "0x6004F6C")]
	[Address(RVA = "0x96A560", Offset = "0x969760", VA = "0x18096A560")]
	public void SetResetSearchButtonShortcutKey(SelectorManager.KeyType main, SelectorManager.KeyType sub)
	{
	}

	[Token(Token = "0x6004F6D")]
	[Address(RVA = "0x96A6D0", Offset = "0x9698D0", VA = "0x18096A6D0")]
	public void SetShowAllCardsButtonShortcutKey(SelectorManager.KeyType main, SelectorManager.KeyType sub)
	{
	}

	[Token(Token = "0x6004F6E")]
	[Address(RVA = "0x9690E0", Offset = "0x9682E0", VA = "0x1809690E0")]
	public void ActivateSearchInput()
	{
	}

	[Token(Token = "0x6004F6F")]
	[Address(RVA = "0x96A840", Offset = "0x969A40", VA = "0x18096A840")]
	public void SetTextSearchShortcutKey(SelectorManager.KeyType main, SelectorManager.KeyType sub)
	{
	}

	[Token(Token = "0x6004F70")]
	[Address(RVA = "0x96A910", Offset = "0x969B10", VA = "0x18096A910")]
	public void SetUncurrentView()
	{
	}

	[Token(Token = "0x6004F71")]
	[Address(RVA = "0x969B00", Offset = "0x968D00", VA = "0x180969B00")]
	public void SetCurrentView()
	{
	}

	[Token(Token = "0x6004F72")]
	[Address(RVA = "0x96A710", Offset = "0x969910", VA = "0x18096A710")]
	public void SetSortButtonLabel(SortComparer.Sorter sorter)
	{
	}

	[Token(Token = "0x6004F73")]
	[Address(RVA = "0x96A5E0", Offset = "0x9697E0", VA = "0x18096A5E0")]
	private void SetShortcut(SelectionButton button, DeviceIcon deviceIcon, SelectorManager.KeyType main, SelectorManager.KeyType sub)
	{
	}

	[Token(Token = "0x6004F74")]
	[Address(RVA = "0x969C30", Offset = "0x968E30", VA = "0x180969C30")]
	public void SetDispDropArea(bool disp)
	{
	}

	[Token(Token = "0x6004F75")]
	[Address(RVA = "0x969BF0", Offset = "0x968DF0", VA = "0x180969BF0")]
	public void SetDispDropAreaOver(bool disp)
	{
	}

	[Token(Token = "0x6004F76")]
	[Address(RVA = "0x969710", Offset = "0x968910", VA = "0x180969710")]
	public void CursorJumpUp()
	{
	}

	[Token(Token = "0x6004F77")]
	[Address(RVA = "0x969510", Offset = "0x968710", VA = "0x180969510")]
	public void CursorJumpDown()
	{
	}

	[Token(Token = "0x6004F78")]
	[Address(RVA = "0x969690", Offset = "0x968890", VA = "0x180969690")]
	public void CursorJumpRight()
	{
	}

	[Token(Token = "0x6004F79")]
	[Address(RVA = "0x969610", Offset = "0x968810", VA = "0x180969610")]
	public void CursorJumpLeft()
	{
	}

	[Token(Token = "0x6004F7A")]
	[Address(RVA = "0x969800", Offset = "0x968A00", VA = "0x180969800")]
	public void FocusItemAt(int index, bool immediate, bool select)
	{
	}

	[Token(Token = "0x6004F7B")]
	[Address(RVA = "0x969830", Offset = "0x968A30", VA = "0x180969830")]
	public int GetIndex(int cardID, int premiumID = -1)
	{
		return default(int);
	}

	[Token(Token = "0x6004F7C")]
	[Address(RVA = "0x96ABB0", Offset = "0x969DB0", VA = "0x18096ABB0")]
	public void UpdateDisplayMode(DeckEditViewController2.DisplayMode mode, bool updateScroll = true)
	{
	}

	[Token(Token = "0x6004F7D")]
	[Address(RVA = "0x96ABF0", Offset = "0x969DF0", VA = "0x18096ABF0")]
	public void UpdateView(bool updateDataCount, bool select = true)
	{
	}

	[Token(Token = "0x6004F7E")]
	[Address(RVA = "0x96A9A0", Offset = "0x969BA0", VA = "0x18096A9A0")]
	public void ShowLoading()
	{
	}

	[Token(Token = "0x6004F7F")]
	[Address(RVA = "0x969850", Offset = "0x968A50", VA = "0x180969850")]
	public void HideLoading()
	{
	}

	[Token(Token = "0x6004F80")]
	[Address(RVA = "0x9698B0", Offset = "0x968AB0", VA = "0x1809698B0")]
	public void SelectLeftEdgeClosestItem(Vector2 screenPoint, float angleDot, bool isIni = false)
	{
	}

	[Token(Token = "0x6004F81")]
	[Address(RVA = "0x969A60", Offset = "0x968C60", VA = "0x180969A60")]
	public void SetActiveScroll(bool condition)
	{
	}

	[Token(Token = "0x6004F82")]
	[Address(RVA = "0x96AD80", Offset = "0x969F80", VA = "0x18096AD80")]
	[IteratorStateMachine(typeof(_003CwaitDecrementDragCounter_003Ed__82))]
	private IEnumerator waitDecrementDragCounter()
	{
		return null;
	}

	[Token(Token = "0x6004F83")]
	[Address(RVA = "0x969980", Offset = "0x968B80", VA = "0x180969980")]
	public void SelectLeftUpEdgeItem(bool isIni = true)
	{
	}

	[Token(Token = "0x6004F86")]
	[Address(RVA = "0x96A320", Offset = "0x969520", VA = "0x18096A320")]
	public void SetOnSelectNoItemButton(UnityAction callback)
	{
	}

	[Token(Token = "0x6004F87")]
	[Address(RVA = "0x96ACC0", Offset = "0x969EC0", VA = "0x18096ACC0")]
	public CpsCardCollectionView()
	{
	}
}
