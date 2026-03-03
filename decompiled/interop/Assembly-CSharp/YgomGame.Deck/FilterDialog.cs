using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using YgomGame.Card;
using YgomGame.Menu;
using YgomSystem.ElementSystem;
using YgomSystem.UI;
using YgomSystem.Utility;
using YgomSystem.YGomTMPro;

namespace YgomGame.Deck;

[Token(Token = "0x20010E5")]
public class FilterDialog : SelectDialogViewControllerBase<SearchFilter.Setting, SearchFilter.Setting, List<FilterDialog.FilterGroupType>, SearchFilter.Setting>, IBokeSupported
{
	[Token(Token = "0x20010E6")]
	public enum FilterGroupType
	{
		[Token(Token = "0x400B32C")]
		Rarity,
		[Token(Token = "0x400B32D")]
		Frame,
		[Token(Token = "0x400B32E")]
		Attribute,
		[Token(Token = "0x400B32F")]
		Spell,
		[Token(Token = "0x400B330")]
		Trap,
		[Token(Token = "0x400B331")]
		Tribe,
		[Token(Token = "0x400B332")]
		Level,
		[Token(Token = "0x400B333")]
		Link,
		[Token(Token = "0x400B334")]
		LinkMarker,
		[Token(Token = "0x400B335")]
		PendulumScale,
		[Token(Token = "0x400B336")]
		Attack,
		[Token(Token = "0x400B337")]
		Defense,
		[Token(Token = "0x400B338")]
		Ability,
		[Token(Token = "0x400B339")]
		Style,
		[Token(Token = "0x400B33A")]
		Limit,
		[Token(Token = "0x400B33B")]
		Cutin
	}

	[Token(Token = "0x20010E7")]
	public class OptionMask
	{
		[Token(Token = "0x400B33C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public BitArray Frame;

		[Token(Token = "0x6006A49")]
		[Address(RVA = "0xB1A9A0", Offset = "0xB19BA0", VA = "0x180B1A9A0")]
		public OptionMask()
		{
		}
	}

	[Token(Token = "0x20010E8")]
	private class FilterGroup : MonoBehaviour
	{
		[Token(Token = "0x400B33D")]
		private const string k_ELabelIcon = "Icon";

		[Token(Token = "0x400B33E")]
		private const string k_ELabelText = "TextTMP";

		[Token(Token = "0x400B33F")]
		private const string k_ELabelButtonArea = "ButtonArea";

		[Token(Token = "0x400B340")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private ElementObjectManager m_Eom;

		[Token(Token = "0x400B341")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Image m_GroupIconImage;

		[Token(Token = "0x400B342")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private ExtendedTextMeshProUGUI m_GroupNameText;

		[Token(Token = "0x400B345")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private GridLayoutGroup m_GridLayoutGroup;

		[Token(Token = "0x400B346")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private bool isInitialized;

		[Token(Token = "0x400B347")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private FilterGroupType m_Type;

		[Token(Token = "0x400B348")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Dictionary<string, FilterToggle> m_FilterToggles;

		[Token(Token = "0x170010FB")]
		public RectTransform m_ButtonArea
		{
			[Token(Token = "0x6006A4A")]
			[Address(RVA = "0x404860", Offset = "0x403A60", VA = "0x180404860")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6006A4B")]
			[Address(RVA = "0x595520", Offset = "0x594720", VA = "0x180595520")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x170010FC")]
		public RectTransform m_RectTransform
		{
			[Token(Token = "0x6006A4C")]
			[Address(RVA = "0x404850", Offset = "0x403A50", VA = "0x180404850")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6006A4D")]
			[Address(RVA = "0x595530", Offset = "0x594730", VA = "0x180595530")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x6006A4E")]
		[Address(RVA = "0xB16AF0", Offset = "0xB15CF0", VA = "0x180B16AF0")]
		public void InitializeElements()
		{
		}

		[Token(Token = "0x6006A4F")]
		[Address(RVA = "0xB16AE0", Offset = "0xB15CE0", VA = "0x180B16AE0")]
		private void Awake()
		{
		}

		[Token(Token = "0x6006A50")]
		[Address(RVA = "0xB16C50", Offset = "0xB15E50", VA = "0x180B16C50")]
		public void Initialize(FilterGroupType type)
		{
		}

		[Token(Token = "0x6006A51")]
		[Address(RVA = "0xB16A30", Offset = "0xB15C30", VA = "0x180B16A30")]
		public void AddFilterToggle(string label, FilterToggle filterToggle)
		{
		}

		[Token(Token = "0x6006A52")]
		[Address(RVA = "0x3D2BD0", Offset = "0x3D1DD0", VA = "0x1803D2BD0")]
		public FilterGroup()
		{
		}
	}

	[Token(Token = "0x20010E9")]
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass200_0
	{
		[Token(Token = "0x400B349")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public FilterDialog _003C_003E4__this;

		[Token(Token = "0x400B34A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public FilterCheck checkFrame;

		[Token(Token = "0x400B34B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public FilterCheck checkLinkMarker;

		[Token(Token = "0x400B34C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public UnityAction _003C_003E9__0;

		[Token(Token = "0x400B34D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public UnityAction _003C_003E9__8;

		[Token(Token = "0x400B34E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public UnityAction _003C_003E9__9;

		[Token(Token = "0x400B34F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public UnityAction _003C_003E9__1;

		[Token(Token = "0x400B350")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public UnityAction _003C_003E9__17;

		[Token(Token = "0x400B351")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public UnityAction _003C_003E9__18;

		[Token(Token = "0x6006A53")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public _003C_003Ec__DisplayClass200_0()
		{
		}

		[Token(Token = "0x6006A54")]
		[Address(RVA = "0xB21E30", Offset = "0xB21030", VA = "0x180B21E30")]
		internal void _003CInitializeFileterMenu_003Eb__0()
		{
		}

		[Token(Token = "0x6006A55")]
		[Address(RVA = "0xB221F0", Offset = "0xB213F0", VA = "0x180B221F0")]
		internal void _003CInitializeFileterMenu_003Eb__8()
		{
		}

		[Token(Token = "0x6006A56")]
		[Address(RVA = "0xB22290", Offset = "0xB21490", VA = "0x180B22290")]
		internal void _003CInitializeFileterMenu_003Eb__9()
		{
		}

		[Token(Token = "0x6006A57")]
		[Address(RVA = "0xB22090", Offset = "0xB21290", VA = "0x180B22090")]
		internal void _003CInitializeFileterMenu_003Eb__1()
		{
		}

		[Token(Token = "0x6006A58")]
		[Address(RVA = "0xB21F90", Offset = "0xB21190", VA = "0x180B21F90")]
		internal void _003CInitializeFileterMenu_003Eb__17()
		{
		}

		[Token(Token = "0x6006A59")]
		[Address(RVA = "0xB22030", Offset = "0xB21230", VA = "0x180B22030")]
		internal void _003CInitializeFileterMenu_003Eb__18()
		{
		}
	}

	[Token(Token = "0x20010EA")]
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass200_1
	{
		[Token(Token = "0x400B352")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public FilterSlider filterSliderAttack;

		[Token(Token = "0x400B353")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public FilterSlider filterSliderDefense;

		[Token(Token = "0x400B354")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public _003C_003Ec__DisplayClass200_0 CS_0024_003C_003E8__locals1;

		[Token(Token = "0x6006A5A")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public _003C_003Ec__DisplayClass200_1()
		{
		}

		[Token(Token = "0x6006A5B")]
		[Address(RVA = "0xB22890", Offset = "0xB21A90", VA = "0x180B22890")]
		internal void _003CInitializeFileterMenu_003Eb__2()
		{
		}

		[Token(Token = "0x6006A5C")]
		[Address(RVA = "0xB228D0", Offset = "0xB21AD0", VA = "0x180B228D0")]
		internal void _003CInitializeFileterMenu_003Eb__3()
		{
		}

		[Token(Token = "0x6006A5D")]
		[Address(RVA = "0xB22910", Offset = "0xB21B10", VA = "0x180B22910")]
		internal void _003CInitializeFileterMenu_003Eb__4()
		{
		}

		[Token(Token = "0x6006A5E")]
		[Address(RVA = "0xB22950", Offset = "0xB21B50", VA = "0x180B22950")]
		internal void _003CInitializeFileterMenu_003Eb__5()
		{
		}
	}

	[Token(Token = "0x20010F6")]
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass200_7
	{
		[Token(Token = "0x400B36B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public FilterToggle filterToggle;

		[Token(Token = "0x400B36C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public _003C_003Ec__DisplayClass200_1 CS_0024_003C_003E8__locals7;

		[Token(Token = "0x6006A75")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public _003C_003Ec__DisplayClass200_7()
		{
		}

		[Token(Token = "0x6006A76")]
		[Address(RVA = "0xB22E40", Offset = "0xB22040", VA = "0x180B22E40")]
		internal void _003CInitializeFileterMenu_003Eb__13()
		{
		}
	}

	[Token(Token = "0x20010FB")]
	[CompilerGenerated]
	private sealed class _003CInitializeFileterMenu_003Ed__200 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400B375")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400B376")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400B377")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public FilterDialog _003C_003E4__this;

		[Token(Token = "0x400B378")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private _003C_003Ec__DisplayClass200_0 _003C_003E8__1;

		[Token(Token = "0x400B379")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private _003C_003Ec__DisplayClass200_1 _003C_003E8__2;

		[Token(Token = "0x400B37A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private _003C_003Ec__DisplayClass200_7 _003C_003E8__3;

		[Token(Token = "0x400B37B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private SelectionButton _003CLeft1Button_003E5__2;

		[Token(Token = "0x400B37C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private SelectionButton _003CLeft2Button_003E5__3;

		[Token(Token = "0x400B37D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private SelectionButton _003CRight1Button_003E5__4;

		[Token(Token = "0x400B37E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private SelectionButton _003CRight2Button_003E5__5;

		[Token(Token = "0x400B37F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private (SelectorManager.KeyType main, SelectorManager.KeyType sub) _003CkeyInfo_003E5__6;

		[Token(Token = "0x400B380")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private int _003Ci_003E5__7;

		[Token(Token = "0x400B381")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private int _003Ccount_003E5__8;

		[Token(Token = "0x400B382")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private FilterGroup _003CtribeGroup_003E5__9;

		[Token(Token = "0x400B383")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Dictionary<string, SearchFilter.Setting.TRIBE>.Enumerator _003C_003E7__wrap9;

		[Token(Token = "0x170010FD")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6006A84")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170010FE")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6006A86")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6006A80")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CInitializeFileterMenu_003Ed__200(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6006A81")]
		[Address(RVA = "0xB21CD0", Offset = "0xB20ED0", VA = "0x180B21CD0", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6006A82")]
		[Address(RVA = "0xB1AA10", Offset = "0xB19C10", VA = "0x180B1AA10", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6006A83")]
		[Address(RVA = "0xB21D60", Offset = "0xB20F60", VA = "0x180B21D60")]
		private void _003C_003Em__Finally1()
		{
		}

		[Token(Token = "0x6006A85")]
		[Address(RVA = "0xB21C90", Offset = "0xB20E90", VA = "0x180B21C90", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x400B26E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	[SerializeField]
	private KeyConfigContainer keyConfig;

	[Token(Token = "0x400B26F")]
	private const string PREFAB_PATH_FILTERDIALOG = "DeckEdit/FilterDialog";

	[Token(Token = "0x400B270")]
	private const string MMA_PATH_HELP = "Help/MMA/HelpMode/MMAHelpDeckFilterDialog";

	[Token(Token = "0x400B271")]
	private const string k_ELabelFilterMenuArea = "FilterMenuArea";

	[Token(Token = "0x400B272")]
	private const string k_ELabelFilterScroll = "FilterScroll";

	[Token(Token = "0x400B273")]
	private const string k_ELabelFooterArea = "FooterArea";

	[Token(Token = "0x400B274")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	private ElementObjectManager m_FilterMenuEom;

	[Token(Token = "0x400B275")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	private ElementObjectManager m_FooterEom;

	[Token(Token = "0x400B276")]
	private const string k_ALabelFilterToggleTemplate = "FilterToggleTemplate";

	[Token(Token = "0x400B277")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	private GameObject m_FilterToggleTemplate;

	[Token(Token = "0x400B278")]
	private const string k_ALabelFilterLinkMarkTemplate = "FilterLinkMarkTemplate";

	[Token(Token = "0x400B279")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
	private GameObject m_FilterLinkMarkTemplate;

	[Token(Token = "0x400B27A")]
	private const string k_ALabelFilterCheckTemplate = "FilterCheckTemplate";

	[Token(Token = "0x400B27B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
	private GameObject m_FilterCheckTemplate;

	[Token(Token = "0x400B27C")]
	private const string k_ALabelFilterMinMaxSliderTemplate = "FilterMinMaxSliderTemplate";

	[Token(Token = "0x400B27D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
	private GameObject m_FilterMinMaxSliderTemplate;

	[Token(Token = "0x400B27E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
	private (SelectorManager.KeyType main, SelectorManager.KeyType sub) keyInfoUpGroup;

	[Token(Token = "0x400B27F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
	private (SelectorManager.KeyType main, SelectorManager.KeyType sub) keyInfoDownGroup;

	[Token(Token = "0x400B280")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
	private Coroutine m_InitializeCoroutine;

	[Token(Token = "0x400B281")]
	private const string Label_Frame_Normal = "通常";

	[Token(Token = "0x400B282")]
	private const string Label_Frame_Effect = "効果";

	[Token(Token = "0x400B283")]
	private const string Label_Frame_Fusion = "融合";

	[Token(Token = "0x400B284")]
	private const string Label_Frame_Ritual = "儀式";

	[Token(Token = "0x400B285")]
	private const string Label_Frame_Synchro = "シンクロ";

	[Token(Token = "0x400B286")]
	private const string Label_Frame_Xyz = "エクシーズ";

	[Token(Token = "0x400B287")]
	private const string Label_Frame_Pendulum = "ペンデュラム";

	[Token(Token = "0x400B288")]
	private const string Label_Frame_Link = "リンク";

	[Token(Token = "0x400B289")]
	private const string Label_Frame_Magic = "魔法";

	[Token(Token = "0x400B28A")]
	private const string Label_Frame_Trap = "罠";

	[Token(Token = "0x400B28B")]
	private const string Label_Attr_Light = "光属性";

	[Token(Token = "0x400B28C")]
	private const string Label_Attr_Dark = "闇属性";

	[Token(Token = "0x400B28D")]
	private const string Label_Attr_Water = "水属性";

	[Token(Token = "0x400B28E")]
	private const string Label_Attr_Fire = "炎属性";

	[Token(Token = "0x400B28F")]
	private const string Label_Attr_Earth = "地属性";

	[Token(Token = "0x400B290")]
	private const string Label_Attr_Wind = "風属性";

	[Token(Token = "0x400B291")]
	private const string Label_Attr_Divine = "神属性";

	[Token(Token = "0x400B292")]
	private const string Label_Tribe_SpellCaster = "魔法使い族";

	[Token(Token = "0x400B293")]
	private const string Label_Tribe_Dragon = "ドラゴン族";

	[Token(Token = "0x400B294")]
	private const string Label_Tribe_Zombie = "アンデット族";

	[Token(Token = "0x400B295")]
	private const string Label_Tribe_Warrior = "戦士族";

	[Token(Token = "0x400B296")]
	private const string Label_Tribe_BeastWarrior = "獣戦士族";

	[Token(Token = "0x400B297")]
	private const string Label_Tribe_Beast = "獣族";

	[Token(Token = "0x400B298")]
	private const string Label_Tribe_WingedBeast = "鳥獣族";

	[Token(Token = "0x400B299")]
	private const string Label_Tribe_Machine = "機械族";

	[Token(Token = "0x400B29A")]
	private const string Label_Tribe_Fiend = "悪魔族";

	[Token(Token = "0x400B29B")]
	private const string Label_Tribe_Fairy = "天使族";

	[Token(Token = "0x400B29C")]
	private const string Label_Tribe_Insect = "昆虫族";

	[Token(Token = "0x400B29D")]
	private const string Label_Tribe_Dinosaur = "恐竜族";

	[Token(Token = "0x400B29E")]
	private const string Label_Tribe_Reptile = "爬虫類族";

	[Token(Token = "0x400B29F")]
	private const string Label_Tribe_Fish = "魚族";

	[Token(Token = "0x400B2A0")]
	private const string Label_Tribe_SeaSerpent = "海竜族";

	[Token(Token = "0x400B2A1")]
	private const string Label_Tribe_Aqua = "水族";

	[Token(Token = "0x400B2A2")]
	private const string Label_Tribe_Pyro = "炎族";

	[Token(Token = "0x400B2A3")]
	private const string Label_Tribe_Thunder = "雷族";

	[Token(Token = "0x400B2A4")]
	private const string Label_Tribe_Rock = "岩石族";

	[Token(Token = "0x400B2A5")]
	private const string Label_Tribe_Plant = "植物族";

	[Token(Token = "0x400B2A6")]
	private const string Label_Tribe_Psychic = "サイキック族";

	[Token(Token = "0x400B2A7")]
	private const string Label_Tribe_Wyrm = "幻竜族";

	[Token(Token = "0x400B2A8")]
	private const string Label_Tribe_Cyberse = "サイバース族";

	[Token(Token = "0x400B2A9")]
	private const string Label_Tribe_Illusioner = "幻想魔族";

	[Token(Token = "0x400B2AA")]
	private const string Label_Tribe_DivineBeast = "幻神獣族";

	[Token(Token = "0x400B2AB")]
	private const string Label_Lvl0 = "0";

	[Token(Token = "0x400B2AC")]
	private const string Label_Lvl1 = "1";

	[Token(Token = "0x400B2AD")]
	private const string Label_Lvl2 = "2";

	[Token(Token = "0x400B2AE")]
	private const string Label_Lvl3 = "3";

	[Token(Token = "0x400B2AF")]
	private const string Label_Lvl4 = "4";

	[Token(Token = "0x400B2B0")]
	private const string Label_Lvl5 = "5";

	[Token(Token = "0x400B2B1")]
	private const string Label_Lvl6 = "6";

	[Token(Token = "0x400B2B2")]
	private const string Label_Lvl7 = "7";

	[Token(Token = "0x400B2B3")]
	private const string Label_Lvl8 = "8";

	[Token(Token = "0x400B2B4")]
	private const string Label_Lvl9 = "9";

	[Token(Token = "0x400B2B5")]
	private const string Label_Lvl10 = "10";

	[Token(Token = "0x400B2B6")]
	private const string Label_Lvl11 = "11";

	[Token(Token = "0x400B2B7")]
	private const string Label_Lvl12 = "12";

	[Token(Token = "0x400B2B8")]
	private const string Label_Lvl13 = "13";

	[Token(Token = "0x400B2B9")]
	private const string Label_Link1 = "Link_1";

	[Token(Token = "0x400B2BA")]
	private const string Label_Link2 = "Link_2";

	[Token(Token = "0x400B2BB")]
	private const string Label_Link3 = "Link_3";

	[Token(Token = "0x400B2BC")]
	private const string Label_Link4 = "Link_4";

	[Token(Token = "0x400B2BD")]
	private const string Label_Link5 = "Link_5";

	[Token(Token = "0x400B2BE")]
	private const string Label_Link6 = "Link_6";

	[Token(Token = "0x400B2BF")]
	private const string Label_Link7 = "Link_7";

	[Token(Token = "0x400B2C0")]
	private const string Label_Link8 = "Link_8";

	[Token(Token = "0x400B2C1")]
	private const string Label_Spell_Normal = "通常魔法";

	[Token(Token = "0x400B2C2")]
	private const string Label_Spell_Field = "フィールド魔法";

	[Token(Token = "0x400B2C3")]
	private const string Label_Spell_Equip = "装備魔法";

	[Token(Token = "0x400B2C4")]
	private const string Label_Spell_Continuous = "永続魔法";

	[Token(Token = "0x400B2C5")]
	private const string Label_Spell_QuickPlay = "速攻魔法";

	[Token(Token = "0x400B2C6")]
	private const string Label_Spell_Ritual = "儀式魔法";

	[Token(Token = "0x400B2C7")]
	private const string Label_Trap_Normal = "通常罠";

	[Token(Token = "0x400B2C8")]
	private const string Label_Trap_Continuous = "永続罠";

	[Token(Token = "0x400B2C9")]
	private const string Label_Trap_Counter = "カウンター罠";

	[Token(Token = "0x400B2CA")]
	private const string Label_Rarity_Normal = "N";

	[Token(Token = "0x400B2CB")]
	private const string Label_Rarity_Rare = "R";

	[Token(Token = "0x400B2CC")]
	private const string Label_Rarity_SuperRare = "SR";

	[Token(Token = "0x400B2CD")]
	private const string Label_Rarity_UltraRare = "UR";

	[Token(Token = "0x400B2CE")]
	private const string Label_Style_Normal = "Normal";

	[Token(Token = "0x400B2CF")]
	private const string Label_Style_Shine = "Shine";

	[Token(Token = "0x400B2D0")]
	private const string Label_Style_Royal = "Royal";

	[Token(Token = "0x400B2D1")]
	private const string Label_Limit_0 = "禁止(仮)";

	[Token(Token = "0x400B2D2")]
	private const string Label_Limit_1 = "制限(仮)";

	[Token(Token = "0x400B2D3")]
	private const string Label_Limit_2 = "準制限(仮)";

	[Token(Token = "0x400B2D4")]
	private const string Label_Limit_3 = "無制限(仮)";

	[Token(Token = "0x400B2D5")]
	private const string Label_Cutin_Exist = "有り(仮)";

	[Token(Token = "0x400B2D6")]
	private const string Label_Cutin_NotExist = "無し(仮)";

	[Token(Token = "0x400B2D7")]
	private const string Label_Ability_Toon = "トゥーン(仮)";

	[Token(Token = "0x400B2D8")]
	private const string Label_Ability_Dual = "デュアル(仮)";

	[Token(Token = "0x400B2D9")]
	private const string Label_Ability_Union = "ユニオン(仮)";

	[Token(Token = "0x400B2DA")]
	private const string Label_Ability_Spirit = "スピリット(仮)";

	[Token(Token = "0x400B2DB")]
	private const string Label_Ability_Tuner = "チューナー(仮)";

	[Token(Token = "0x400B2DC")]
	private const string Label_Ability_Reverse = "リバース(仮)";

	[Token(Token = "0x400B2DD")]
	private const string Label_Ability_SpSummon = "特殊召喚(仮)";

	[Token(Token = "0x400B2DE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
	private SearchFilter.Setting m_setting;

	[Token(Token = "0x400B2DF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static Dictionary<string, SearchFilter.Setting.FRAME> frameSettingTbl;

	[Token(Token = "0x400B2E0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private static Dictionary<string, SearchFilter.Setting.ATTR> attrSettingTbl;

	[Token(Token = "0x400B2E1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private static Dictionary<string, SearchFilter.Setting.TRIBE> tribeSettingTbl;

	[Token(Token = "0x400B2E2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private static Dictionary<string, SearchFilter.Setting.LEVEL> lvlSettingTbl;

	[Token(Token = "0x400B2E3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private static Dictionary<string, SearchFilter.Setting.LINK> linkSettingTbl;

	[Token(Token = "0x400B2E4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private static Dictionary<string, SearchFilter.Setting.NOTMONSTER> spellSettingTbl;

	[Token(Token = "0x400B2E5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private static Dictionary<string, SearchFilter.Setting.NOTMONSTER> trapSettingTbl;

	[Token(Token = "0x400B2E6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private static Dictionary<string, SearchFilter.Setting.RARITY> raritySettingTbl;

	[Token(Token = "0x400B2E7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private static Dictionary<string, SearchFilter.Setting.STYLE> styleSettingTbl;

	[Token(Token = "0x400B2E8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private static Dictionary<string, SearchFilter.Setting.LIMIT> limitSettingTbl;

	[Token(Token = "0x400B2E9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private static Dictionary<string, SearchFilter.Setting.CUTIN> cutinSettingTbl;

	[Token(Token = "0x400B2EA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private static Dictionary<string, SearchFilter.Setting.LINKMARKER> linkMarkerSettingTbl;

	[Token(Token = "0x400B2EB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private static Dictionary<string, SearchFilter.Setting.ATTACK> attackSettingTbl;

	[Token(Token = "0x400B2EC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private static Dictionary<string, SearchFilter.Setting.DEFENSE> defenseSettingTbl;

	[Token(Token = "0x400B2ED")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private static Dictionary<string, SearchFilter.Setting.ABILITY> abilitySettingTbl;

	[Token(Token = "0x400B2EE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private static Dictionary<string, string> frameButtonLabelTbl;

	[Token(Token = "0x400B2EF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private static Dictionary<string, Content.Attribute> attrButtonLabelTbl;

	[Token(Token = "0x400B2F0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private static Dictionary<string, Content.Type> tribeButtonLabelTbl;

	[Token(Token = "0x400B2F1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private static Dictionary<string, Content.Icon> spellButtonLabelTbl;

	[Token(Token = "0x400B2F2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private static Dictionary<string, Content.Icon> trapButtonLabelTbl;

	[Token(Token = "0x400B2F3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	private static Dictionary<string, string> rarityButtonLabelTbl;

	[Token(Token = "0x400B2F4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	private static Dictionary<string, string> styleButtonLabelTbl;

	[Token(Token = "0x400B2F5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	private static Dictionary<string, string> limitButtonLabelTbl;

	[Token(Token = "0x400B2F6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	private static Dictionary<string, string> cutinButtonLabelTbl;

	[Token(Token = "0x400B2F7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	private static Dictionary<string, string> abilityButtonLabelTbl;

	[Token(Token = "0x400B2F8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	private static Dictionary<string, string> toggleLabelTbl;

	[Token(Token = "0x400B2F9")]
	private const int numToggles = 105;

	[Token(Token = "0x400B2FA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
	private List<FilterToggle> toggles;

	[Token(Token = "0x400B2FB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
	private List<FilterLinkMark> linkMarks;

	[Token(Token = "0x400B2FC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
	private List<FilterCheck> filterChecks;

	[Token(Token = "0x400B2FD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
	private List<FilterSlider> filterSliders;

	[Token(Token = "0x400B2FE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
	private Dictionary<FilterGroupType, SelectionItem> groupTopItem;

	[Token(Token = "0x400B2FF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
	private ExtendedScrollRect m_FilterScroll;

	[Token(Token = "0x400B300")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
	private bool contentScrollAnimation;

	[Token(Token = "0x400B301")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x16C")]
	private Vector2 targetContentPosition;

	[Token(Token = "0x400B302")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	private static SearchFilter.Setting deckEditSetting;

	[Token(Token = "0x400B303")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	private static List<FilterGroupType> deckEditFilterGroupTypes;

	[Token(Token = "0x400B304")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
	private readonly Dictionary<FilterGroupType, int> groupSize;

	[Token(Token = "0x400B305")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
	private readonly int spacing;

	[Token(Token = "0x400B306")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x184")]
	private readonly int spacingMobile;

	[Token(Token = "0x400B307")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
	private readonly int paddingTop;

	[Token(Token = "0x400B308")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18C")]
	private readonly int paddingBottom;

	[Token(Token = "0x400B309")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
	private readonly Dictionary<FilterGroupType, int> groupSizeMobile;

	[Token(Token = "0x400B30A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
	private OptionMask optionMask;

	[Token(Token = "0x400B30B")]
	private const string k_argKeyOptionMask = "ArgOptionMask";

	[Token(Token = "0x400B30C")]
	private const string k_ELabelCautionButton = "CautionButton";

	[Token(Token = "0x400B30D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
	private SelectionButton m_CautionButton;

	[Token(Token = "0x400B30E")]
	private const string k_ELabelCancelButton = "CancelButton";

	[Token(Token = "0x400B30F")]
	private const string k_ELabelFilterButton = "FilterButton";

	[Token(Token = "0x400B310")]
	private const string k_ELabelResetButton = "ResetButton";

	[Token(Token = "0x400B311")]
	private const string k_ELabelCancelShortcut = "CancelShortcut";

	[Token(Token = "0x400B312")]
	private const string k_ELabelFilterShortcut = "FilterShortcut";

	[Token(Token = "0x400B313")]
	private const string k_ELabelResetShortcut = "ResetShortcut";

	[Token(Token = "0x400B314")]
	private const string k_ELabelAndOrShortcut = "AndOrShortcut";

	[Token(Token = "0x400B315")]
	private const string k_ELabelResetShortcutMain = "ResetShortcut/ShortcutIcon0";

	[Token(Token = "0x400B316")]
	private const string k_ELabelResetShortcutSub = "ResetShortcut/ShortcutIcon1";

	[Token(Token = "0x400B317")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
	private SelectionButton m_CancelButton;

	[Token(Token = "0x400B318")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1B0")]
	private SelectionButton m_FilterButton;

	[Token(Token = "0x400B319")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1B8")]
	private SelectionButton m_ResetButton;

	[Token(Token = "0x400B31A")]
	private const string k_ELabelFilterGroupFrame = "Frame";

	[Token(Token = "0x400B31B")]
	private const string k_ELabelFilterGroupAttribute = "Attribute";

	[Token(Token = "0x400B31C")]
	private const string k_ELabelFilterGroupSpellTrap = "SpellTrap";

	[Token(Token = "0x400B31D")]
	private const string k_ELabelFilterGroupTribe = "Tribe";

	[Token(Token = "0x400B31E")]
	private const string k_ELabelFilterGroupLevel = "Level";

	[Token(Token = "0x400B31F")]
	private const string k_ELabelFilterGroupLink = "Link";

	[Token(Token = "0x400B320")]
	private const string k_ELabelFilterGroupLinkMarker = "LinkMarker";

	[Token(Token = "0x400B321")]
	private const string k_ELabelFilterGroupRarity = "Rarity";

	[Token(Token = "0x400B322")]
	private const string k_ELabelFilterGroupAbility = "Ability";

	[Token(Token = "0x400B323")]
	private const string k_ELabelFilterGroupStyle = "Style";

	[Token(Token = "0x400B324")]
	private const string k_ELabelFilterGroupLimit = "Limit";

	[Token(Token = "0x400B325")]
	private const string k_ELabelFilterGroupCutin = "Cutin";

	[Token(Token = "0x400B326")]
	private const string k_ELabelFilterGroupPendulumScale = "PendulumScale";

	[Token(Token = "0x400B327")]
	private const string k_ELabelFilterGroupAttack = "Attack";

	[Token(Token = "0x400B328")]
	private const string k_ELabelFilterGroupDefense = "Defense";

	[Token(Token = "0x400B329")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C0")]
	private List<FilterGroupType> m_FilterGroupTypes;

	[Token(Token = "0x400B32A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C8")]
	public SearchFilter.Setting m_DefaultSetting;

	[Token(Token = "0x170010FA")]
	private static Content m_cci
	{
		[Token(Token = "0x6006A16")]
		[Address(RVA = "0xB15D90", Offset = "0xB14F90", VA = "0x180B15D90")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6006A17")]
	[Address(RVA = "0xB11350", Offset = "0xB10550", VA = "0x180B11350")]
	public static void Open(SearchFilter.Setting setting, [Optional] Action<SearchFilter.Setting> callback)
	{
	}

	[Token(Token = "0x6006A18")]
	[Address(RVA = "0xB112C0", Offset = "0xB104C0", VA = "0x180B112C0")]
	public static void Open(SearchFilter.Setting setting, SearchFilter.Setting defaultSetting, List<FilterGroupType> filterGroupTypes, [Optional] Action<SearchFilter.Setting> callback)
	{
	}

	[Token(Token = "0x6006A19")]
	[Address(RVA = "0xB111B0", Offset = "0xB103B0", VA = "0x180B111B0")]
	public static void OpenWithMask(SearchFilter.Setting setting, SearchFilter.Setting defaultSetting, List<FilterGroupType> filterGroupTypes, OptionMask optionMask, [Optional] Action<SearchFilter.Setting> callback)
	{
	}

	[Token(Token = "0x6006A1A")]
	[Address(RVA = "0xB0FA00", Offset = "0xB0EC00", VA = "0x180B0FA00", Slot = "6")]
	public override void NotificationStackEntry()
	{
	}

	[Token(Token = "0x6006A1B")]
	[Address(RVA = "0xB0FC70", Offset = "0xB0EE70", VA = "0x180B0FC70", Slot = "23")]
	protected override void OnCreatedView()
	{
	}

	[Token(Token = "0x6006A1C")]
	[Address(RVA = "0xB0F210", Offset = "0xB0E410", VA = "0x180B0F210")]
	private void InitializeDefault()
	{
	}

	[Token(Token = "0x6006A1D")]
	[Address(RVA = "0xB0F8F0", Offset = "0xB0EAF0", VA = "0x180B0F8F0")]
	private void InitializeHeader()
	{
	}

	[Token(Token = "0x6006A1E")]
	[Address(RVA = "0xB0F3C0", Offset = "0xB0E5C0", VA = "0x180B0F3C0")]
	private void InitializeFooter()
	{
	}

	[Token(Token = "0x6006A1F")]
	[Address(RVA = "0xB0F350", Offset = "0xB0E550", VA = "0x180B0F350")]
	[IteratorStateMachine(typeof(_003CInitializeFileterMenu_003Ed__200))]
	private IEnumerator InitializeFileterMenu()
	{
		return null;
	}

	[Token(Token = "0x6006A20")]
	[Address(RVA = "0xB15E20", Offset = "0xB15020", VA = "0x180B15E20")]
	private bool isNeededAdjustFrameAreaHeight()
	{
		return default(bool);
	}

	[Token(Token = "0x6006A21")]
	[Address(RVA = "0xB15D30", Offset = "0xB14F30", VA = "0x180B15D30")]
	private int getFrameAreaHeightAdjust()
	{
		return default(int);
	}

	[Token(Token = "0x6006A22")]
	[Address(RVA = "0xB15BD0", Offset = "0xB14DD0", VA = "0x180B15BD0")]
	private void adjustFrameAreaHeight(ElementObjectManager frameEom)
	{
	}

	[Token(Token = "0x6006A23")]
	[Address(RVA = "0xB16190", Offset = "0xB15390", VA = "0x180B16190")]
	private void setFilterFrame(FilterToggle ft)
	{
	}

	[Token(Token = "0x6006A24")]
	[Address(RVA = "0xB169D0", Offset = "0xB15BD0", VA = "0x180B169D0")]
	private void setIsAndFrame(FilterCheck fct)
	{
	}

	[Token(Token = "0x6006A25")]
	[Address(RVA = "0xB15FB0", Offset = "0xB151B0", VA = "0x180B15FB0")]
	private void setFilterAttr(FilterToggle ft)
	{
	}

	[Token(Token = "0x6006A26")]
	[Address(RVA = "0xB16910", Offset = "0xB15B10", VA = "0x180B16910")]
	private void setFilterTribe(FilterToggle ft)
	{
	}

	[Token(Token = "0x6006A27")]
	[Address(RVA = "0xB16250", Offset = "0xB15450", VA = "0x180B16250")]
	private void setFilterLevel(FilterToggle ft)
	{
	}

	[Token(Token = "0x6006A28")]
	[Address(RVA = "0xB16490", Offset = "0xB15690", VA = "0x180B16490")]
	private void setFilterLink(FilterToggle ft)
	{
	}

	[Token(Token = "0x6006A29")]
	[Address(RVA = "0xB16550", Offset = "0xB15750", VA = "0x180B16550")]
	private void setFilterPendulumScale(FilterToggle ft)
	{
	}

	[Token(Token = "0x6006A2A")]
	[Address(RVA = "0xB166D0", Offset = "0xB158D0", VA = "0x180B166D0")]
	private void setFilterSpell(FilterToggle ft)
	{
	}

	[Token(Token = "0x6006A2B")]
	[Address(RVA = "0xB16850", Offset = "0xB15A50", VA = "0x180B16850")]
	private void setFilterTrap(FilterToggle ft)
	{
	}

	[Token(Token = "0x6006A2C")]
	[Address(RVA = "0xB16610", Offset = "0xB15810", VA = "0x180B16610")]
	private void setFilterRarity(FilterToggle ft)
	{
	}

	[Token(Token = "0x6006A2D")]
	[Address(RVA = "0xB15E90", Offset = "0xB15090", VA = "0x180B15E90")]
	private void setFilterAbility(FilterToggle ft)
	{
	}

	[Token(Token = "0x6006A2E")]
	[Address(RVA = "0xB16790", Offset = "0xB15990", VA = "0x180B16790")]
	private void setFilterStyle(FilterToggle ft)
	{
	}

	[Token(Token = "0x6006A2F")]
	[Address(RVA = "0xB16310", Offset = "0xB15510", VA = "0x180B16310")]
	private void setFilterLimit(FilterToggle ft)
	{
	}

	[Token(Token = "0x6006A30")]
	[Address(RVA = "0xB16070", Offset = "0xB15270", VA = "0x180B16070")]
	private void setFilterCutin(FilterToggle ft)
	{
	}

	[Token(Token = "0x6006A31")]
	[Address(RVA = "0xB163D0", Offset = "0xB155D0", VA = "0x180B163D0")]
	private void setFilterLinkMark(FilterLinkMark fl)
	{
	}

	[Token(Token = "0x6006A32")]
	[Address(RVA = "0xB16A00", Offset = "0xB15C00", VA = "0x180B16A00")]
	private void setIsAndLinkMark(FilterCheck fct)
	{
	}

	[Token(Token = "0x6006A33")]
	[Address(RVA = "0xB15F80", Offset = "0xB15180", VA = "0x180B15F80")]
	private void setFilterAttackMin(FilterSlider fs)
	{
	}

	[Token(Token = "0x6006A34")]
	[Address(RVA = "0xB15F50", Offset = "0xB15150", VA = "0x180B15F50")]
	private void setFilterAttackMax(FilterSlider fs)
	{
	}

	[Token(Token = "0x6006A35")]
	[Address(RVA = "0xB16160", Offset = "0xB15360", VA = "0x180B16160")]
	private void setFilterDefenseMin(FilterSlider fs)
	{
	}

	[Token(Token = "0x6006A36")]
	[Address(RVA = "0xB16130", Offset = "0xB15330", VA = "0x180B16130")]
	private void setFilterDefenseMax(FilterSlider fs)
	{
	}

	[Token(Token = "0x6006A37")]
	[Address(RVA = "0xB10090", Offset = "0xB0F290", VA = "0x180B10090")]
	private void OnReset()
	{
	}

	[Token(Token = "0x6006A38")]
	[Address(RVA = "0xB11400", Offset = "0xB10600", VA = "0x180B11400")]
	private void SelectNextGroupTop(FilterGroupType filterGroup)
	{
	}

	[Token(Token = "0x6006A39")]
	[Address(RVA = "0xB11550", Offset = "0xB10750", VA = "0x180B11550")]
	private void SelectPrevGroupTop(FilterGroupType filterGroup)
	{
	}

	[Token(Token = "0x6006A3A")]
	[Address(RVA = "0xB11690", Offset = "0xB10890", VA = "0x180B11690")]
	private void SetupScrollToSelectingItem(SelectionItem item, RectTransform itemRootRect)
	{
	}

	[Token(Token = "0x6006A3B")]
	[Address(RVA = "0xB0EFA0", Offset = "0xB0E1A0", VA = "0x180B0EFA0")]
	private void InitPadTransition(SelectionButton button, RectTransform buttonArea, FilterGroupType type)
	{
	}

	[Token(Token = "0x6006A3C")]
	[Address(RVA = "0xB11C40", Offset = "0xB10E40", VA = "0x180B11C40")]
	private void Update()
	{
	}

	[Token(Token = "0x6006A3D")]
	[Address(RVA = "0xB0FBF0", Offset = "0xB0EDF0", VA = "0x180B0FBF0", Slot = "13")]
	public override bool OnBack()
	{
		return default(bool);
	}

	[Token(Token = "0x6006A3E")]
	[Address(RVA = "0xB155B0", Offset = "0xB147B0", VA = "0x180B155B0")]
	public FilterDialog()
	{
	}
}
