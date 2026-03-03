using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using YgomSystem.ElementSystem;
using YgomSystem.UI;
using YgomSystem.UI.PropertyOverrider;
using YgomSystem.Utility;

namespace YgomGame.Duel;

[Token(Token = "0x2001BA2")]
public class GenericCardListController : MonoBehaviour, IGenericScrollViewSupport, IGameObjectPool
{
	[Token(Token = "0x2001BA3")]
	public enum ListType
	{
		[Token(Token = "0x400FABF")]
		NONE,
		[Token(Token = "0x400FAC0")]
		EXTRA_TEAM0,
		[Token(Token = "0x400FAC1")]
		EXTRA_TEAM1,
		[Token(Token = "0x400FAC2")]
		GRAVE_TEAM0,
		[Token(Token = "0x400FAC3")]
		GRAVE_TEAM1,
		[Token(Token = "0x400FAC4")]
		EXCLUDED_TEAM0,
		[Token(Token = "0x400FAC5")]
		EXCLUDED_TEAM1,
		[Token(Token = "0x400FAC6")]
		OVERLAYMATLIST_TEAM0,
		[Token(Token = "0x400FAC7")]
		OVERLAYMATLIST_TEAM1,
		[Token(Token = "0x400FAC8")]
		MAXIMUMLIST_TEAM0,
		[Token(Token = "0x400FAC9")]
		MAXIMUMLIST_TEAM1,
		[Token(Token = "0x400FACA")]
		INHERITEFFECTLIST
	}

	[Token(Token = "0x2001BA4")]
	public enum ListStatue
	{
		[Token(Token = "0x400FACC")]
		OPEN,
		[Token(Token = "0x400FACD")]
		OPENING,
		[Token(Token = "0x400FACE")]
		UPDATING,
		[Token(Token = "0x400FACF")]
		CLOSE,
		[Token(Token = "0x400FAD0")]
		CLOSING
	}

	[Token(Token = "0x2001BAA")]
	[CompilerGenerated]
	private sealed class _003CyChangeList_003Ed__92 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400FAE3")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400FAE4")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400FAE5")]
		[FieldOffset(Offset = "0x20")]
		public GenericCardListController _003C_003E4__this;

		[Token(Token = "0x400FAE6")]
		[FieldOffset(Offset = "0x28")]
		public bool layout;

		[Token(Token = "0x400FAE7")]
		[FieldOffset(Offset = "0x30")]
		public Action onFinished;

		[Token(Token = "0x17001BA2")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x600B43F")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17001BA3")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600B441")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600B43C")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CyChangeList_003Ed__92(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x600B43D")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x600B43E")]
		[Address(RVA = "0x4CEA10", Offset = "0x4CDC10", VA = "0x1804CEA10", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600B440")]
		[Address(RVA = "0x4CEC50", Offset = "0x4CDE50", VA = "0x1804CEC50", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x2001BAB")]
	[CompilerGenerated]
	private sealed class _003CyClose_003Ed__89 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400FAE8")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400FAE9")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400FAEA")]
		[FieldOffset(Offset = "0x20")]
		public Action onFinished;

		[Token(Token = "0x17001BA4")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x600B445")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17001BA5")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600B447")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600B442")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CyClose_003Ed__89(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x600B443")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x600B444")]
		[Address(RVA = "0x4CEC90", Offset = "0x4CDE90", VA = "0x1804CEC90", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600B446")]
		[Address(RVA = "0x4CED40", Offset = "0x4CDF40", VA = "0x1804CED40", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x2001BAC")]
	[CompilerGenerated]
	private sealed class _003CyOpen_003Ed__88 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400FAEB")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400FAEC")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400FAED")]
		[FieldOffset(Offset = "0x20")]
		public Action onFinished;

		[Token(Token = "0x17001BA6")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x600B44B")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17001BA7")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600B44D")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600B448")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CyOpen_003Ed__88(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x600B449")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x600B44A")]
		[Address(RVA = "0x4CED80", Offset = "0x4CDF80", VA = "0x1804CED80", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600B44C")]
		[Address(RVA = "0x4CEE30", Offset = "0x4CE030", VA = "0x1804CEE30", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x400FA81")]
	private const string PREHAB_PATH = "Prefabs/Duel/UI/GenericCardList";

	[Token(Token = "0x400FA82")]
	private const string PREHAB_PATH_MOBILE = "Prefabs/Duel/UI/GenericCardList_Mobile";

	[Token(Token = "0x400FA83")]
	private const string LABEL_EO_SCROLLVIEW = "ScrollView";

	[Token(Token = "0x400FA84")]
	private const string LABEL_EO_LISTTYPEICON = "ListTypeIcon";

	[Token(Token = "0x400FA85")]
	private const string LABEL_EO_CARDIMAGE = "CardImage";

	[Token(Token = "0x400FA86")]
	private const string LABEL_EO_CARDMASK = "CardMask";

	[Token(Token = "0x400FA87")]
	private const string LABEL_EO_STATUEROOT = "StatueRoot";

	[Token(Token = "0x400FA88")]
	private const string LABEL_EO_FROMEXTRAICON = "FromExtraIcon";

	[Token(Token = "0x400FA89")]
	private const string LABEL_EO_STATUEICON = "Icon";

	[Token(Token = "0x400FA8A")]
	private const string LABEL_EO_SHORTCUT_ICON = "ShortCutIcon";

	[Token(Token = "0x400FA8B")]
	private const string LABEL_EO_LINKMARKERS = "LinkMarkers";

	[Token(Token = "0x400FA8C")]
	private const string LABEL_EO_STATUETEXT = "Text";

	[Token(Token = "0x400FA8D")]
	private const string LABEL_EO_TEXTTOTALCOUNT = "TextTotalCount";

	[Token(Token = "0x400FA8E")]
	private const string LABEL_EO_WINDOW = "Window";

	[Token(Token = "0x400FA8F")]
	private const string LABEL_EO_CHANGELAYOUTBUTTON = "LayoutChangeButton";

	[Token(Token = "0x400FA90")]
	private const string LABEL_EO_CHANGELAYOUTSHORTCUT = "LayoutChangeShortcut";

	[Token(Token = "0x400FA91")]
	private const string LABEL_EO_CHANGELAYOUT_H = "LayoutChangeH";

	[Token(Token = "0x400FA92")]
	private const string LABEL_EO_CHANGELAYOUT_V = "LayoutChangeV";

	[Token(Token = "0x400FA93")]
	private const string LABEL_EO_LAYOUT_BG = "LayoutBG";

	[Token(Token = "0x400FA94")]
	private const string LABEL_EO_LINE_UP = "LineUp";

	[Token(Token = "0x400FA95")]
	private const string LABEL_EO_LINE_BOTTOM = "LineBottom";

	[Token(Token = "0x400FA96")]
	private const string LABEL_EO_SCALE_WRAP = "ScaleWrap";

	[Token(Token = "0x400FA97")]
	private const string LABEL_TWEEN_SHOW = "Show";

	[Token(Token = "0x400FA98")]
	private const string LABEL_TWEEN_HIDE = "Hide";

	[Token(Token = "0x400FA99")]
	private const string LABEL_TWEEN_INIT = "InitTween";

	[Token(Token = "0x400FA9A")]
	private const string LABEL_TWEEN_CHANGELIST = "ChangeList";

	[Token(Token = "0x400FA9B")]
	private const string LABEL_ORIGIN_POS = "OriginPos";

	[Token(Token = "0x400FA9C")]
	private const string LAYOUT_BASIC = "Basic";

	[Token(Token = "0x400FA9D")]
	private const string LAYOUT_EXPAND = "Expand";

	[Token(Token = "0x400FA9E")]
	[FieldOffset(Offset = "0x20")]
	private bool pooled;

	[Token(Token = "0x400FAA0")]
	[FieldOffset(Offset = "0x28")]
	private ListType m_Type;

	[Token(Token = "0x400FAA1")]
	[FieldOffset(Offset = "0x30")]
	private ElementObjectManager m_Eom;

	[Token(Token = "0x400FAA2")]
	[FieldOffset(Offset = "0x38")]
	public GenericScrollView m_Gsv;

	[Token(Token = "0x400FAA3")]
	[FieldOffset(Offset = "0x40")]
	private Tween m_TweenClose;

	[Token(Token = "0x400FAA4")]
	[FieldOffset(Offset = "0x48")]
	private Tween m_TweenOpen;

	[Token(Token = "0x400FAA5")]
	[FieldOffset(Offset = "0x50")]
	private Tween m_TweenChangeList;

	[Token(Token = "0x400FAA6")]
	[FieldOffset(Offset = "0x58")]
	private GameObject m_Window;

	[Token(Token = "0x400FAA7")]
	[FieldOffset(Offset = "0x60")]
	private RectTransform m_WindowRect;

	[Token(Token = "0x400FAA8")]
	[FieldOffset(Offset = "0x68")]
	private RectTransform m_OriginRect;

	[Token(Token = "0x400FAA9")]
	[FieldOffset(Offset = "0x70")]
	private Dictionary<ListType, List<int>> m_DataListTable;

	[Token(Token = "0x400FAAA")]
	[FieldOffset(Offset = "0x78")]
	private Dictionary<int, int> m_CardSourceTable;

	[Token(Token = "0x400FAAB")]
	[FieldOffset(Offset = "0x80")]
	private int m_TargetUniqueId;

	[Token(Token = "0x400FAAC")]
	[FieldOffset(Offset = "0x88")]
	private DuelClient m_Host;

	[Token(Token = "0x400FAAD")]
	[FieldOffset(Offset = "0x90")]
	private SelectionButton m_ChangeLayoutButton;

	[Token(Token = "0x400FAAE")]
	[FieldOffset(Offset = "0x98")]
	public int settingsLayout;

	[Token(Token = "0x400FAAF")]
	[FieldOffset(Offset = "0x9C")]
	private bool m_IsBasicLayout;

	[Token(Token = "0x400FAB0")]
	[FieldOffset(Offset = "0x9D")]
	private bool m_IsLayoutButtonEnabled;

	[Token(Token = "0x400FAB1")]
	[FieldOffset(Offset = "0xA0")]
	private GameObject m_ChangeLayoutIconH;

	[Token(Token = "0x400FAB2")]
	[FieldOffset(Offset = "0xA8")]
	private GameObject m_ChangeLayoutIconV;

	[Token(Token = "0x400FAB3")]
	[FieldOffset(Offset = "0xB0")]
	private GameObject m_LayoutShortCutIcon;

	[Token(Token = "0x400FAB4")]
	[FieldOffset(Offset = "0xB8")]
	private GameObject m_LayoutBG;

	[Token(Token = "0x400FAB5")]
	[FieldOffset(Offset = "0xC0")]
	private GameObject m_LTShortCutIcon;

	[Token(Token = "0x400FAB6")]
	[FieldOffset(Offset = "0xC8")]
	private PlatformOverriderGroup pog;

	[Token(Token = "0x400FAB7")]
	[FieldOffset(Offset = "0xD0")]
	private ShortcutIcon m_Icon;

	[Token(Token = "0x400FAB8")]
	[FieldOffset(Offset = "0xD8")]
	private Selector m_LayoutButtonSelector;

	[Token(Token = "0x400FAB9")]
	[FieldOffset(Offset = "0xE0")]
	private Coroutine m_OpenCoroutine;

	[Token(Token = "0x400FABA")]
	[FieldOffset(Offset = "0xE8")]
	private Coroutine m_CloseCoroutine;

	[Token(Token = "0x400FABB")]
	[FieldOffset(Offset = "0xF0")]
	private Coroutine m_ChangeListCoroutine;

	[Token(Token = "0x400FABC")]
	[FieldOffset(Offset = "0xF8")]
	private Action m_AdditionalAction;

	[Token(Token = "0x400FABD")]
	[FieldOffset(Offset = "0x100")]
	private Action m_ResetAction;

	[Token(Token = "0x17001B9A")]
	public string poolKey
	{
		[Token(Token = "0x600B3E3")]
		[Address(RVA = "0x4ACD90", Offset = "0x4ABF90", VA = "0x1804ACD90", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001B9B")]
	public GameObject pooledTarget
	{
		[Token(Token = "0x600B3E5")]
		[Address(RVA = "0x4A1C50", Offset = "0x4A0E50", VA = "0x1804A1C50", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001B9C")]
	protected bool isMobile
	{
		[Token(Token = "0x600B3E6")]
		[Address(RVA = "0x4ACCF0", Offset = "0x4ABEF0", VA = "0x1804ACCF0")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17001B9D")]
	protected bool isGamePad
	{
		[Token(Token = "0x600B3E7")]
		[Address(RVA = "0x4ACC60", Offset = "0x4ABE60", VA = "0x1804ACC60")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17001B9E")]
	public ListStatue Statue
	{
		[Token(Token = "0x600B3E9")]
		[Address(RVA = "0x416290", Offset = "0x415490", VA = "0x180416290")]
		[CompilerGenerated]
		get
		{
			return default(ListStatue);
		}
		[Token(Token = "0x600B3EA")]
		[Address(RVA = "0x416370", Offset = "0x415570", VA = "0x180416370")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17001B9F")]
	public bool isOpen
	{
		[Token(Token = "0x600B3EB")]
		[Address(RVA = "0x4A1C00", Offset = "0x4A0E00", VA = "0x1804A1C00")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17001BA0")]
	public bool isBasicLayout
	{
		[Token(Token = "0x600B3EC")]
		[Address(RVA = "0x4ACC50", Offset = "0x4ABE50", VA = "0x1804ACC50")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600B3ED")]
		[Address(RVA = "0x4ACDC0", Offset = "0x4ABFC0", VA = "0x1804ACDC0")]
		set
		{
		}
	}

	[Token(Token = "0x17001BA1")]
	private List<int> m_CurrentDataList
	{
		[Token(Token = "0x600B3EE")]
		[Address(RVA = "0x4ACD40", Offset = "0x4ABF40", VA = "0x1804ACD40")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600B3E4")]
	[Address(RVA = "0x4A8C90", Offset = "0x4A7E90", VA = "0x1804A8C90", Slot = "12")]
	public void OnReturned()
	{
	}

	[Token(Token = "0x600B3E8")]
	[Address(RVA = "0x4A7310", Offset = "0x4A6510", VA = "0x1804A7310")]
	public static void Create(Transform parent, DuelClient host, bool isBasicLayout, UnityAction<GenericCardListController> onFinish)
	{
	}

	[Token(Token = "0x600B3EF")]
	[Address(RVA = "0x4AC990", Offset = "0x4ABB90", VA = "0x1804AC990")]
	public void UpdateList(int team, int position, bool onCursor = false)
	{
	}

	[Token(Token = "0x600B3F0")]
	[Address(RVA = "0x4A8A70", Offset = "0x4A7C70", VA = "0x1804A8A70")]
	public void LayoutButtonActive(bool active)
	{
	}

	[Token(Token = "0x600B3F1")]
	[Address(RVA = "0x4AC290", Offset = "0x4AB490", VA = "0x1804AC290")]
	public void UpdateAsEffectList(int team, int position)
	{
	}

	[Token(Token = "0x600B3F2")]
	[Address(RVA = "0x4AB310", Offset = "0x4AA510", VA = "0x1804AB310")]
	public bool Show(bool onCursor = false)
	{
		return default(bool);
	}

	[Token(Token = "0x600B3F3")]
	[Address(RVA = "0x4A6FA0", Offset = "0x4A61A0", VA = "0x1804A6FA0")]
	public bool Close(bool skipOpenDuelLog = false)
	{
		return default(bool);
	}

	[Token(Token = "0x600B3F4")]
	[Address(RVA = "0x4ACF30", Offset = "0x4AC130", VA = "0x1804ACF30")]
	[IteratorStateMachine(typeof(_003CyOpen_003Ed__88))]
	private IEnumerator yOpen(Action onFinished)
	{
		return null;
	}

	[Token(Token = "0x600B3F5")]
	[Address(RVA = "0x4ACEC0", Offset = "0x4AC0C0", VA = "0x1804ACEC0")]
	[IteratorStateMachine(typeof(_003CyClose_003Ed__89))]
	private IEnumerator yClose(Action onFinished)
	{
		return null;
	}

	[Token(Token = "0x600B3F6")]
	[Address(RVA = "0x4A9070", Offset = "0x4A8270", VA = "0x1804A9070")]
	public void SetAlpha(float alpha)
	{
	}

	[Token(Token = "0x600B3F7")]
	[Address(RVA = "0x4A6D40", Offset = "0x4A5F40", VA = "0x1804A6D40")]
	public void ChangeList(bool layout, Action onFinished)
	{
	}

	[Token(Token = "0x600B3F8")]
	[Address(RVA = "0x4ACE20", Offset = "0x4AC020", VA = "0x1804ACE20")]
	[IteratorStateMachine(typeof(_003CyChangeList_003Ed__92))]
	private IEnumerator yChangeList(bool layout, Action onFinished)
	{
		return null;
	}

	[Token(Token = "0x600B3F9")]
	[Address(RVA = "0x4A6D00", Offset = "0x4A5F00", VA = "0x1804A6D00")]
	public void ChangeListImpl()
	{
	}

	[Token(Token = "0x600B3FA")]
	[Address(RVA = "0x4AC3D0", Offset = "0x4AB5D0", VA = "0x1804AC3D0")]
	public void UpdateContent(bool isLayoutChange = false)
	{
	}

	[Token(Token = "0x600B3FB")]
	[Address(RVA = "0x4AA150", Offset = "0x4A9350", VA = "0x1804AA150")]
	public void SetShortkeyIconVisible(bool visible, bool isCursorJump = false, bool isDialog = false, bool onCursor = false)
	{
	}

	[Token(Token = "0x600B3FC")]
	[Address(RVA = "0x4A79D0", Offset = "0x4A6BD0", VA = "0x1804A79D0")]
	public void HideLayoutIcons()
	{
	}

	[Token(Token = "0x600B3FD")]
	[Address(RVA = "0x4A7A60", Offset = "0x4A6C60", VA = "0x1804A7A60")]
	private void InitComponent()
	{
	}

	[Token(Token = "0x600B3FE")]
	[Address(RVA = "0x4A8370", Offset = "0x4A7570", VA = "0x1804A8370")]
	private void InitDataListTable()
	{
	}

	[Token(Token = "0x600B3FF")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x600B400")]
	[Address(RVA = "0x4AC680", Offset = "0x4AB880", VA = "0x1804AC680")]
	private void UpdateDataList()
	{
	}

	[Token(Token = "0x600B401")]
	[Address(RVA = "0x4A8E70", Offset = "0x4A8070", VA = "0x1804A8E70")]
	private void Open()
	{
	}

	[Token(Token = "0x600B402")]
	[Address(RVA = "0x4A69D0", Offset = "0x4A5BD0", VA = "0x1804A69D0")]
	private void ChangeLayout()
	{
	}

	[Token(Token = "0x600B403")]
	[Address(RVA = "0x4AB9B0", Offset = "0x4AABB0", VA = "0x1804AB9B0")]
	private void SwitchExpand(bool basic, bool isShow = false)
	{
	}

	[Token(Token = "0x600B404")]
	[Address(RVA = "0x4A77D0", Offset = "0x4A69D0", VA = "0x1804A77D0")]
	private (int, int) GetOwnerAndLocateByListType(ListType type)
	{
		return default((int, int));
	}

	[Token(Token = "0x600B405")]
	[Address(RVA = "0x4A75A0", Offset = "0x4A67A0", VA = "0x1804A75A0")]
	private bool GetLayout()
	{
		return default(bool);
	}

	[Token(Token = "0x600B406")]
	[Address(RVA = "0x4A75D0", Offset = "0x4A67D0", VA = "0x1804A75D0")]
	private ListType GetListTypeByOwnerAndLocate(int owner, int locate)
	{
		return default(ListType);
	}

	[Token(Token = "0x600B407")]
	[Address(RVA = "0x4AA780", Offset = "0x4A9980", VA = "0x1804AA780")]
	private void SetUidCard(int dataindex, GameObject gob)
	{
	}

	[Token(Token = "0x600B408")]
	[Address(RVA = "0x4A9270", Offset = "0x4A8470", VA = "0x1804A9270")]
	private void SetCidCard(int dataindex, GameObject gob)
	{
	}

	[Token(Token = "0x600B409")]
	[Address(RVA = "0x4A8C70", Offset = "0x4A7E70", VA = "0x1804A8C70", Slot = "4")]
	public void OnItemSetData(GameObject gob, int dataindex)
	{
	}

	[Token(Token = "0x600B40A")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "8")]
	public void OnGsvStanby()
	{
	}

	[Token(Token = "0x600B40B")]
	[Address(RVA = "0x4AA380", Offset = "0x4A9580", VA = "0x1804AA380")]
	private void SetStatues(ElementObjectManager eom, int cardid)
	{
	}

	[Token(Token = "0x600B40C")]
	[Address(RVA = "0x4A90E0", Offset = "0x4A82E0", VA = "0x1804A90E0")]
	private void SetCardPicture(RawImage cardpicture, GameObject cardmask, int uid)
	{
	}

	[Token(Token = "0x600B40D")]
	[Address(RVA = "0x4A9E30", Offset = "0x4A9030", VA = "0x1804A9E30")]
	private void SetLinkMarkers(ElementObjectManager eom, int linkmask, int linknum)
	{
	}

	[Token(Token = "0x600B40E")]
	[Address(RVA = "0x4A9CD0", Offset = "0x4A8ED0", VA = "0x1804A9CD0")]
	private void SetLevel(ElementObjectManager eom, int level)
	{
	}

	[Token(Token = "0x600B40F")]
	[Address(RVA = "0x4A9FF0", Offset = "0x4A91F0", VA = "0x1804A9FF0")]
	private void SetRank(ElementObjectManager eom, int rank)
	{
	}

	[Token(Token = "0x600B410")]
	[Address(RVA = "0x4AC340", Offset = "0x4AB540", VA = "0x1804AC340")]
	public void UpdateCardSourceTable(int uid, int pos)
	{
	}

	[Token(Token = "0x600B411")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "7")]
	public void OnItemInitialize(GameObject gob)
	{
	}

	[Token(Token = "0x600B412")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
	public void OnItemEntry(GameObject gob, int dataindex)
	{
	}

	[Token(Token = "0x600B413")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "6")]
	public void OnItemExit(GameObject gob, int dataindex)
	{
	}

	[Token(Token = "0x600B414")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "9")]
	public void UpdateLayout()
	{
	}

	[Token(Token = "0x600B415")]
	[Address(RVA = "0x4A8890", Offset = "0x4A7A90", VA = "0x1804A8890")]
	protected void Initialize(bool isBasic)
	{
	}

	[Token(Token = "0x600B416")]
	[Address(RVA = "0x4AB280", Offset = "0x4AA480", VA = "0x1804AB280")]
	private void SetupSelectorPriority()
	{
	}

	[Token(Token = "0x600B417")]
	[Address(RVA = "0x4A8720", Offset = "0x4A7920", VA = "0x1804A8720")]
	private void InitialLayout(bool isBasic)
	{
	}

	[Token(Token = "0x600B418")]
	[Address(RVA = "0x4A9A40", Offset = "0x4A8C40", VA = "0x1804A9A40")]
	private void SetLayout()
	{
	}

	[Token(Token = "0x600B419")]
	[Address(RVA = "0x4A6E50", Offset = "0x4A6050", VA = "0x1804A6E50")]
	public void CleanCoroutine()
	{
	}

	[Token(Token = "0x600B41A")]
	[Address(RVA = "0x4ACBD0", Offset = "0x4ABDD0", VA = "0x1804ACBD0")]
	public GenericCardListController()
	{
	}
}
