using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using YgomGame.Deck;
using YgomGame.Menu;
using YgomGame.Menu.Common;
using YgomGame.Utility;
using YgomSystem.ElementSystem;
using YgomSystem.UI;
using YgomSystem.UI.ElementWidget;
using YgomSystem.UI.InfinityScroll;

namespace YgomGame.Regulation;

[Token(Token = "0x2000B37")]
public class CardListBrowserRegulationFilterViewController : BaseMenuViewController, IBackButtonSupported, IHeaderBorderSupported
{
	[Token(Token = "0x2000B38")]
	private class CardWidget : ElementWidgetBase
	{
		[Token(Token = "0x4009608")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private readonly string k_ECardLabelButton;

		[Token(Token = "0x4009609")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private readonly string k_ECardLabelHighlight;

		[Token(Token = "0x400960A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private readonly string k_ECardLabelIconRarity;

		[Token(Token = "0x400960B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private readonly string k_ECardLabelLimitIcon;

		[Token(Token = "0x400960C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private readonly string k_ECardLabelNumTextArea;

		[Token(Token = "0x400960D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private readonly string k_ECardLabelNumText;

		[Token(Token = "0x400960E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private readonly string k_ECardLabelNewIcon;

		[Token(Token = "0x400960F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private int m_Idx;

		[Token(Token = "0x4009610")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private int m_Mrk;

		[Token(Token = "0x4009611")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private int m_StyleId;

		[Token(Token = "0x4009612")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private readonly RawImage m_CardRawImage;

		[Token(Token = "0x4009613")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private BindingCardMaterial m_BindingCardMaterial;

		[Token(Token = "0x4009614")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public int regurationId;

		[Token(Token = "0x1700091B")]
		public int idx
		{
			[Token(Token = "0x60044BC")]
			[Address(RVA = "0x42D5A0", Offset = "0x42C7A0", VA = "0x18042D5A0")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700091C")]
		public bool highlightVisible
		{
			[Token(Token = "0x60044BD")]
			[Address(RVA = "0x8E5240", Offset = "0x8E4440", VA = "0x1808E5240")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60044BE")]
			[Address(RVA = "0x8E54A0", Offset = "0x8E46A0", VA = "0x1808E54A0")]
			set
			{
			}
		}

		[Token(Token = "0x1700091D")]
		public bool newIconVisible
		{
			[Token(Token = "0x60044BF")]
			[Address(RVA = "0x8E53A0", Offset = "0x8E45A0", VA = "0x1808E53A0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60044C0")]
			[Address(RVA = "0x8E5560", Offset = "0x8E4760", VA = "0x1808E5560")]
			set
			{
			}
		}

		[Token(Token = "0x1700091E")]
		public bool limitIconVisible
		{
			[Token(Token = "0x60044C1")]
			[Address(RVA = "0x8E5360", Offset = "0x8E4560", VA = "0x1808E5360")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60044C2")]
			[Address(RVA = "0x8E5520", Offset = "0x8E4720", VA = "0x1808E5520")]
			set
			{
			}
		}

		[Token(Token = "0x1700091F")]
		public Image limitIconImage
		{
			[Token(Token = "0x60044C3")]
			[Address(RVA = "0x8E5310", Offset = "0x8E4510", VA = "0x1808E5310")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000920")]
		public bool innerTextVisible
		{
			[Token(Token = "0x60044C4")]
			[Address(RVA = "0x8E5280", Offset = "0x8E4480", VA = "0x1808E5280")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60044C5")]
			[Address(RVA = "0x8E54E0", Offset = "0x8E46E0", VA = "0x1808E54E0")]
			set
			{
			}
		}

		[Token(Token = "0x17000921")]
		public TMP_Text innerText
		{
			[Token(Token = "0x60044C6")]
			[Address(RVA = "0x8E52C0", Offset = "0x8E44C0", VA = "0x1808E52C0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000922")]
		public SelectionButton button
		{
			[Token(Token = "0x60044C7")]
			[Address(RVA = "0x8E51F0", Offset = "0x8E43F0", VA = "0x1808E51F0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000923")]
		public BindingCardMaterial bindingCardMaterial
		{
			[Token(Token = "0x60044C8")]
			[Address(RVA = "0x449820", Offset = "0x448A20", VA = "0x180449820")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1400005D")]
		public event Action<CardWidget> onClickEvent
		{
			[Token(Token = "0x60044C9")]
			[Address(RVA = "0x8E5130", Offset = "0x8E4330", VA = "0x1808E5130")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60044CA")]
			[Address(RVA = "0x8E53E0", Offset = "0x8E45E0", VA = "0x1808E53E0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x60044CB")]
		[Address(RVA = "0x8E4DA0", Offset = "0x8E3FA0", VA = "0x1808E4DA0")]
		public static CardWidget Create(ElementObjectManager eom)
		{
			return null;
		}

		[Token(Token = "0x60044CC")]
		[Address(RVA = "0x8E4E20", Offset = "0x8E4020", VA = "0x1808E4E20")]
		public CardWidget(ElementObjectManager eom)
		{
		}

		[Token(Token = "0x60044CD")]
		[Address(RVA = "0x8E4AE0", Offset = "0x8E3CE0", VA = "0x1808E4AE0", Slot = "10")]
		public virtual void Binding(int idx, int mrk, int styleId = 1)
		{
		}

		[Token(Token = "0x60044CE")]
		[Address(RVA = "0x8E4E00", Offset = "0x8E4000", VA = "0x1808E4E00", Slot = "11")]
		protected virtual void OnClick()
		{
		}
	}

	[Token(Token = "0x2000B39")]
	private class FilterFormWidget : ElementWidgetBase
	{
		[Token(Token = "0x4009616")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private readonly string k_ELabelFilterLimitTabs;

		[Token(Token = "0x4009617")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public readonly DirectionalTabGroup tabGroup;

		[Token(Token = "0x60044CF")]
		[Address(RVA = "0x8E6120", Offset = "0x8E5320", VA = "0x1808E6120")]
		public FilterFormWidget(ElementObjectManager eom)
		{
		}
	}

	[Token(Token = "0x40095E7")]
	public const string k_ArgRegulationId = "regulationId";

	[Token(Token = "0x40095E8")]
	public const string k_ArgRegulationName = "regulationName";

	[Token(Token = "0x40095E9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	private readonly string k_ELabelRegulationNameText;

	[Token(Token = "0x40095EA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	private readonly string k_ELabelCardList;

	[Token(Token = "0x40095EB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	private readonly string k_ELabelEmptyText;

	[Token(Token = "0x40095EC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	private readonly string k_ELabelFilterForm;

	[Token(Token = "0x40095ED")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	private readonly string k_ELabelFilterButton;

	[Token(Token = "0x40095EE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	private readonly string k_ELabelDisplayInFilterText;

	[Token(Token = "0x40095EF")]
	private const string k_ELabelFilterOnIcon = "IconOn";

	[Token(Token = "0x40095F0")]
	private const string k_ELabelFilterOffIcon = "IconOff";

	[Token(Token = "0x40095F1")]
	private const string k_ELabelFilterOnImage = "On";

	[Token(Token = "0x40095F2")]
	private const string k_ELabelFilterOffImage = "Off";

	[Token(Token = "0x40095F3")]
	private const string k_ELabelRegulationLogo = "RegulationLogo";

	[Token(Token = "0x40095F4")]
	private const string k_ELabelAnalogDirectionItem = "AnalogDirectionItem";

	[Token(Token = "0x40095F5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
	private List<int> m_DisplayCardMrks;

	[Token(Token = "0x40095F6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
	private bool m_RegulationVisible;

	[Token(Token = "0x40095F7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10C")]
	private int m_RegulationId;

	[Token(Token = "0x40095F8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
	private InfinityScrollView m_ScrollView;

	[Token(Token = "0x40095F9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
	private TMP_Text m_EmptyText;

	[Token(Token = "0x40095FA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
	private Image m_RegulationLogoImage;

	[Token(Token = "0x40095FB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
	private TMP_Text m_DisplayInFilterText;

	[Token(Token = "0x40095FC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
	private bool isFiltered;

	[Token(Token = "0x40095FD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
	private FilterFormWidget m_FilterFormWidget;

	[Token(Token = "0x40095FE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
	private RectTransform m_FilterButtonImageOn;

	[Token(Token = "0x40095FF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
	private RectTransform m_FilterButtonImageOff;

	[Token(Token = "0x4009600")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
	private RectTransform m_FilterButtonIconOn;

	[Token(Token = "0x4009601")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
	private RectTransform m_FilterButtonIconOff;

	[Token(Token = "0x4009602")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
	private Dictionary<GameObject, CardWidget> m_CardWidgetDic;

	[Token(Token = "0x4009603")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
	private List<int>[] m_regMrksLists;

	[Token(Token = "0x4009604")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
	private FilterDialogManager m_FilterDialogManager;

	[Token(Token = "0x4009605")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
	private SelectionButton m_FilterButton;

	[Token(Token = "0x4009606")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
	private List<FilterDialog.FilterGroupType> m_FilterGroupTypes;

	[Token(Token = "0x4009607")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
	private SearchFilter.Setting m_DefaultSetting;

	[Token(Token = "0x17000919")]
	protected override Type[] textIds
	{
		[Token(Token = "0x60044A3")]
		[Address(RVA = "0x8E48E0", Offset = "0x8E3AE0", VA = "0x1808E48E0", Slot = "21")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700091A")]
	protected override int outGameBgId
	{
		[Token(Token = "0x60044A4")]
		[Address(RVA = "0x3EF020", Offset = "0x3EE220", VA = "0x1803EF020", Slot = "20")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x60044A5")]
	[Address(RVA = "0x8E2720", Offset = "0x8E1920", VA = "0x1808E2720")]
	private void InitDefaultSetting()
	{
	}

	[Token(Token = "0x60044A6")]
	[Address(RVA = "0x8E34B0", Offset = "0x8E26B0", VA = "0x1808E34B0")]
	public static void Open(string regulationName, int regulationId, [Optional] ViewControllerManager manager, [Optional] Dictionary<string, object> args)
	{
	}

	[Token(Token = "0x60044A7")]
	[Address(RVA = "0x8E33A0", Offset = "0x8E25A0", VA = "0x1808E33A0")]
	public static void OpenHome(string regulationName, int regulationId, [Optional] ViewControllerManager manager, [Optional] Dictionary<string, object> args)
	{
	}

	[Token(Token = "0x60044A8")]
	[Address(RVA = "0x3E4080", Offset = "0x3E3280", VA = "0x1803E4080", Slot = "6")]
	public override void NotificationStackEntry()
	{
	}

	[Token(Token = "0x60044A9")]
	[Address(RVA = "0x8E2B90", Offset = "0x8E1D90", VA = "0x1808E2B90", Slot = "23")]
	protected override void OnCreatedView()
	{
	}

	[Token(Token = "0x60044AA")]
	[Address(RVA = "0x8E3B10", Offset = "0x8E2D10", VA = "0x1808E3B10")]
	private void Start()
	{
	}

	[Token(Token = "0x60044AB")]
	[Address(RVA = "0x8E4040", Offset = "0x8E3240", VA = "0x1808E4040")]
	private void UpdateListDisplay()
	{
	}

	[Token(Token = "0x60044AC")]
	[Address(RVA = "0x8E3620", Offset = "0x8E2820", VA = "0x1808E3620")]
	private void RemoveExtraCard()
	{
	}

	[Token(Token = "0x60044AD")]
	[Address(RVA = "0x8E2140", Offset = "0x8E1340", VA = "0x1808E2140")]
	private List<int>[] CreateStandardLists()
	{
		return null;
	}

	[Token(Token = "0x60044AE")]
	[Address(RVA = "0x8E3D80", Offset = "0x8E2F80", VA = "0x1808E3D80")]
	private void SubtractStandard()
	{
	}

	[Token(Token = "0x60044AF")]
	[Address(RVA = "0x8E1F70", Offset = "0x8E1170", VA = "0x1808E1F70")]
	private void CreateRegMrksList()
	{
	}

	[Token(Token = "0x60044B0")]
	[Address(RVA = "0x8E3930", Offset = "0x8E2B30", VA = "0x1808E3930")]
	private List<int> SelectInCardRare(List<int> rawList)
	{
		return null;
	}

	[Token(Token = "0x60044B1")]
	[Address(RVA = "0x8E2FC0", Offset = "0x8E21C0", VA = "0x1808E2FC0")]
	public void OnEntityCreated(GameObject gob)
	{
	}

	[Token(Token = "0x60044B2")]
	[Address(RVA = "0x8E3220", Offset = "0x8E2420", VA = "0x1808E3220")]
	public void OnEntityUpdate(GameObject gob, int dataindex)
	{
	}

	[Token(Token = "0x60044B3")]
	[Address(RVA = "0x8E2B50", Offset = "0x8E1D50", VA = "0x1808E2B50")]
	private void OnClickEntity(CardWidget clickedWidget)
	{
	}

	[Token(Token = "0x60044B4")]
	[Address(RVA = "0x8E2620", Offset = "0x8E1820", VA = "0x1808E2620")]
	private void FilteredCallBack()
	{
	}

	[Token(Token = "0x60044B5")]
	[Address(RVA = "0x8E3EC0", Offset = "0x8E30C0", VA = "0x1808E3EC0")]
	private void ToggleFilterButton(bool isFiltered)
	{
	}

	[Token(Token = "0x60044B6")]
	[Address(RVA = "0x8E2800", Offset = "0x8E1A00", VA = "0x1808E2800")]
	private void InitializeFilterButton()
	{
	}

	[Token(Token = "0x60044B7")]
	[Address(RVA = "0x8E3360", Offset = "0x8E2560", VA = "0x1808E3360")]
	private void OnInputAnalogDirection(SelectorManager.AnalogType analogType, PadInputDirection dir)
	{
	}

	[Token(Token = "0x60044B8")]
	[Address(RVA = "0x8E41D0", Offset = "0x8E33D0", VA = "0x1808E41D0")]
	public CardListBrowserRegulationFilterViewController()
	{
	}
}
