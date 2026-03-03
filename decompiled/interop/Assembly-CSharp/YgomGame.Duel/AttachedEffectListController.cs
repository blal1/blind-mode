using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;
using YgomSystem.ElementSystem;
using YgomSystem.UI;
using YgomSystem.UI.PropertyOverrider;
using YgomSystem.Utility;

namespace YgomGame.Duel;

[Token(Token = "0x2001B99")]
public class AttachedEffectListController : MonoBehaviour, IGenericScrollViewSupport, IGameObjectPool
{
	[Token(Token = "0x2001B9A")]
	public enum ListStatue
	{
		[Token(Token = "0x400FA60")]
		OPEN,
		[Token(Token = "0x400FA61")]
		OPENING,
		[Token(Token = "0x400FA62")]
		UPDATING,
		[Token(Token = "0x400FA63")]
		CLOSE,
		[Token(Token = "0x400FA64")]
		CLOSING
	}

	[Token(Token = "0x2001B9F")]
	[CompilerGenerated]
	private sealed class _003CyChangeList_003Ed__98 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400FA76")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400FA77")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400FA78")]
		[FieldOffset(Offset = "0x20")]
		public AttachedEffectListController _003C_003E4__this;

		[Token(Token = "0x400FA79")]
		[FieldOffset(Offset = "0x28")]
		public bool layout;

		[Token(Token = "0x400FA7A")]
		[FieldOffset(Offset = "0x30")]
		public Action onFinished;

		[Token(Token = "0x17001B94")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x600B3D4")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17001B95")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600B3D6")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600B3D1")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CyChangeList_003Ed__98(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x600B3D2")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x600B3D3")]
		[Address(RVA = "0x4B4A00", Offset = "0x4B3C00", VA = "0x1804B4A00", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600B3D5")]
		[Address(RVA = "0x4B4C70", Offset = "0x4B3E70", VA = "0x1804B4C70", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x2001BA0")]
	[CompilerGenerated]
	private sealed class _003CyClose_003Ed__88 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400FA7B")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400FA7C")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400FA7D")]
		[FieldOffset(Offset = "0x20")]
		public Action onFinished;

		[Token(Token = "0x17001B96")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x600B3DA")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17001B97")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600B3DC")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600B3D7")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CyClose_003Ed__88(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x600B3D8")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x600B3D9")]
		[Address(RVA = "0x4B4CB0", Offset = "0x4B3EB0", VA = "0x1804B4CB0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600B3DB")]
		[Address(RVA = "0x4B4D60", Offset = "0x4B3F60", VA = "0x1804B4D60", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x2001BA1")]
	[CompilerGenerated]
	private sealed class _003CyOpen_003Ed__87 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400FA7E")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400FA7F")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400FA80")]
		[FieldOffset(Offset = "0x20")]
		public Action onFinished;

		[Token(Token = "0x17001B98")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x600B3E0")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17001B99")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600B3E2")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600B3DD")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CyOpen_003Ed__87(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x600B3DE")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x600B3DF")]
		[Address(RVA = "0x4B4DA0", Offset = "0x4B3FA0", VA = "0x1804B4DA0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600B3E1")]
		[Address(RVA = "0x4B4E50", Offset = "0x4B4050", VA = "0x1804B4E50", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x400FA27")]
	private const string PREHAB_PATH = "Prefabs/Duel/UI/AttachedEffectList";

	[Token(Token = "0x400FA28")]
	private const string PREHAB_PATH_MOBILE = "Prefabs/Duel/UI/AttachedEffectList_Mobile";

	[Token(Token = "0x400FA29")]
	private const string LABEL_EO_SCROLLVIEW = "ScrollView";

	[Token(Token = "0x400FA2A")]
	private const string LABEL_EO_CARDIMAGE = "CardImage";

	[Token(Token = "0x400FA2B")]
	private const string LABEL_EO_CARDMASK = "CardMask";

	[Token(Token = "0x400FA2C")]
	private const string LABEL_EO_STATUS_ROOT = "StatusRoot";

	[Token(Token = "0x400FA2D")]
	private const string LABEL_EO_TEXTTOTALCOUNT = "TextTotalCount";

	[Token(Token = "0x400FA2E")]
	private const string LABEL_EO_WINDOW = "Window";

	[Token(Token = "0x400FA2F")]
	private const string LABEL_EO_CHANGELAYOUTBUTTON = "LayoutChangeButton";

	[Token(Token = "0x400FA30")]
	private const string LABEL_EO_CHANGELAYOUTSHORTCUT = "LayoutChangeShortcut";

	[Token(Token = "0x400FA31")]
	private const string LABEL_EO_CHANGELAYOUT_H = "LayoutChangeH";

	[Token(Token = "0x400FA32")]
	private const string LABEL_EO_CHANGELAYOUT_V = "LayoutChangeV";

	[Token(Token = "0x400FA33")]
	private const string LABEL_EO_LAYOUT_BG = "LayoutBG";

	[Token(Token = "0x400FA34")]
	private const string LABEL_EO_LINE_UP = "LineUp";

	[Token(Token = "0x400FA35")]
	private const string LABEL_EO_LINE_BOTTOM = "LineBottom";

	[Token(Token = "0x400FA36")]
	private const string LABEL_EO_SCALE_WRAP = "ScaleWrap";

	[Token(Token = "0x400FA37")]
	private const string LABEL_TWEEN_SHOW = "Show";

	[Token(Token = "0x400FA38")]
	private const string LABEL_TWEEN_HIDE = "Hide";

	[Token(Token = "0x400FA39")]
	private const string LABEL_TWEEN_INIT = "InitTween";

	[Token(Token = "0x400FA3A")]
	private const string LABEL_TWEEN_CHANGELIST = "ChangeList";

	[Token(Token = "0x400FA3B")]
	private const string LABEL_ORIGIN_POS = "OriginPos";

	[Token(Token = "0x400FA3C")]
	private const string LAYOUT_BASIC = "Basic";

	[Token(Token = "0x400FA3D")]
	private const string LAYOUT_EXPAND = "Expand";

	[Token(Token = "0x400FA3E")]
	private const string LABEL_EO_SHORTCUT_ICON = "ShortCutIcon";

	[Token(Token = "0x400FA3F")]
	private const int maxAttachedStatusTypeNum = 3;

	[Token(Token = "0x400FA40")]
	[FieldOffset(Offset = "0x20")]
	private bool pooled;

	[Token(Token = "0x400FA44")]
	[FieldOffset(Offset = "0x38")]
	private ElementObjectManager m_Eom;

	[Token(Token = "0x400FA45")]
	[FieldOffset(Offset = "0x40")]
	public GenericScrollView m_Gsv;

	[Token(Token = "0x400FA46")]
	[FieldOffset(Offset = "0x48")]
	private Tween m_TweenClose;

	[Token(Token = "0x400FA47")]
	[FieldOffset(Offset = "0x50")]
	private Tween m_TweenOpen;

	[Token(Token = "0x400FA48")]
	[FieldOffset(Offset = "0x58")]
	private GameObject m_Window;

	[Token(Token = "0x400FA49")]
	[FieldOffset(Offset = "0x60")]
	private RectTransform m_WindowRect;

	[Token(Token = "0x400FA4A")]
	[FieldOffset(Offset = "0x68")]
	private RectTransform m_OriginRect;

	[Token(Token = "0x400FA4B")]
	[FieldOffset(Offset = "0x70")]
	private Engine.AffectProp[] prevAffectProps;

	[Token(Token = "0x400FA4C")]
	[FieldOffset(Offset = "0x78")]
	private List<Engine.AffectProp> m_DataList;

	[Token(Token = "0x400FA4D")]
	[FieldOffset(Offset = "0x80")]
	private DuelClient m_Host;

	[Token(Token = "0x400FA4E")]
	[FieldOffset(Offset = "0x88")]
	private SelectionButton m_ChangeLayoutButton;

	[Token(Token = "0x400FA4F")]
	[FieldOffset(Offset = "0x90")]
	public int settingsLayout;

	[Token(Token = "0x400FA50")]
	[FieldOffset(Offset = "0x94")]
	private bool m_IsBasicLayout;

	[Token(Token = "0x400FA51")]
	[FieldOffset(Offset = "0x95")]
	private bool m_IsLayoutButtonEnabled;

	[Token(Token = "0x400FA52")]
	[FieldOffset(Offset = "0x98")]
	private GameObject m_ChangeLayoutIconH;

	[Token(Token = "0x400FA53")]
	[FieldOffset(Offset = "0xA0")]
	private GameObject m_ChangeLayoutIconV;

	[Token(Token = "0x400FA54")]
	[FieldOffset(Offset = "0xA8")]
	private GameObject m_LayoutShortCutIcon;

	[Token(Token = "0x400FA55")]
	[FieldOffset(Offset = "0xB0")]
	private GameObject m_LayoutBG;

	[Token(Token = "0x400FA56")]
	[FieldOffset(Offset = "0xB8")]
	private GameObject m_LTShortCutIcon;

	[Token(Token = "0x400FA57")]
	[FieldOffset(Offset = "0xC0")]
	private PlatformOverriderGroup pog;

	[Token(Token = "0x400FA58")]
	[FieldOffset(Offset = "0xC8")]
	private ShortcutIcon m_Icon;

	[Token(Token = "0x400FA59")]
	[FieldOffset(Offset = "0xD0")]
	private Selector m_LayoutButtonSelector;

	[Token(Token = "0x400FA5A")]
	[FieldOffset(Offset = "0xD8")]
	private Coroutine m_OpenCoroutine;

	[Token(Token = "0x400FA5B")]
	[FieldOffset(Offset = "0xE0")]
	private Coroutine m_CloseCoroutine;

	[Token(Token = "0x400FA5C")]
	[FieldOffset(Offset = "0xE8")]
	private Coroutine m_ChangeListCoroutine;

	[Token(Token = "0x400FA5D")]
	[FieldOffset(Offset = "0xF0")]
	private Action m_AdditionalAction;

	[Token(Token = "0x400FA5E")]
	[FieldOffset(Offset = "0xF8")]
	private Action m_ResetAction;

	[Token(Token = "0x17001B89")]
	public static bool isEnabled
	{
		[Token(Token = "0x600B386")]
		[Address(RVA = "0x4A1AC0", Offset = "0x4A0CC0", VA = "0x1804A1AC0")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17001B8A")]
	public string poolKey
	{
		[Token(Token = "0x600B387")]
		[Address(RVA = "0x4A1C20", Offset = "0x4A0E20", VA = "0x1804A1C20", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001B8B")]
	public GameObject pooledTarget
	{
		[Token(Token = "0x600B389")]
		[Address(RVA = "0x4A1C50", Offset = "0x4A0E50", VA = "0x1804A1C50", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001B8C")]
	protected bool isMobile
	{
		[Token(Token = "0x600B38A")]
		[Address(RVA = "0x4A1BB0", Offset = "0x4A0DB0", VA = "0x1804A1BB0")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17001B8D")]
	protected bool isGamePad
	{
		[Token(Token = "0x600B38B")]
		[Address(RVA = "0x4A1B20", Offset = "0x4A0D20", VA = "0x1804A1B20")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17001B8E")]
	public ListStatue Statue
	{
		[Token(Token = "0x600B38D")]
		[Address(RVA = "0x416290", Offset = "0x415490", VA = "0x180416290")]
		[CompilerGenerated]
		get
		{
			return default(ListStatue);
		}
		[Token(Token = "0x600B38E")]
		[Address(RVA = "0x416370", Offset = "0x415570", VA = "0x180416370")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17001B8F")]
	public bool isOpen
	{
		[Token(Token = "0x600B38F")]
		[Address(RVA = "0x4A1C00", Offset = "0x4A0E00", VA = "0x1804A1C00")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17001B90")]
	public bool isBasicLayout
	{
		[Token(Token = "0x600B390")]
		[Address(RVA = "0x4A1920", Offset = "0x4A0B20", VA = "0x1804A1920")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600B391")]
		[Address(RVA = "0x4A1C60", Offset = "0x4A0E60", VA = "0x1804A1C60")]
		set
		{
		}
	}

	[Token(Token = "0x17001B91")]
	public Action<bool> onChangeOpenClose
	{
		[Token(Token = "0x600B392")]
		[Address(RVA = "0x4030F0", Offset = "0x4022F0", VA = "0x1804030F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x600B393")]
		[Address(RVA = "0x402FB0", Offset = "0x4021B0", VA = "0x180402FB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17001B92")]
	public Action<int> onChangeListNum
	{
		[Token(Token = "0x600B394")]
		[Address(RVA = "0x402CE0", Offset = "0x401EE0", VA = "0x180402CE0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x600B395")]
		[Address(RVA = "0x4130D0", Offset = "0x4122D0", VA = "0x1804130D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17001B93")]
	private bool isDirty
	{
		[Token(Token = "0x600B396")]
		[Address(RVA = "0x4A1930", Offset = "0x4A0B30", VA = "0x1804A1930")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x600B388")]
	[Address(RVA = "0x49F490", Offset = "0x49E690", VA = "0x18049F490", Slot = "12")]
	public void OnReturned()
	{
	}

	[Token(Token = "0x600B38C")]
	[Address(RVA = "0x49D550", Offset = "0x49C750", VA = "0x18049D550")]
	public static void Create(Transform parent, DuelClient host, bool isBasic, UnityAction<AttachedEffectListController> onFinish, Action<bool> onChangeOpenClose, Action<int> onChangeListNum)
	{
	}

	[Token(Token = "0x600B397")]
	[Address(RVA = "0x4A0660", Offset = "0x49F860", VA = "0x1804A0660")]
	public bool Show()
	{
		return default(bool);
	}

	[Token(Token = "0x600B398")]
	[Address(RVA = "0x49D0F0", Offset = "0x49C2F0", VA = "0x18049D0F0")]
	public bool Close(bool skipOpenDuelLog = false)
	{
		return default(bool);
	}

	[Token(Token = "0x600B399")]
	[Address(RVA = "0x4A1DD0", Offset = "0x4A0FD0", VA = "0x1804A1DD0")]
	[IteratorStateMachine(typeof(_003CyOpen_003Ed__87))]
	private IEnumerator yOpen(Action onFinished)
	{
		return null;
	}

	[Token(Token = "0x600B39A")]
	[Address(RVA = "0x4A1D60", Offset = "0x4A0F60", VA = "0x1804A1D60")]
	[IteratorStateMachine(typeof(_003CyClose_003Ed__88))]
	private IEnumerator yClose(Action onFinished)
	{
		return null;
	}

	[Token(Token = "0x600B39B")]
	[Address(RVA = "0x49FA50", Offset = "0x49EC50", VA = "0x18049FA50")]
	public void SetAlpha(float alpha)
	{
	}

	[Token(Token = "0x600B39C")]
	[Address(RVA = "0x4A1510", Offset = "0x4A0710", VA = "0x1804A1510")]
	public void UpdateContent(bool force = false, bool isLayoutChange = false)
	{
	}

	[Token(Token = "0x600B39D")]
	[Address(RVA = "0x49FCA0", Offset = "0x49EEA0", VA = "0x18049FCA0")]
	public void SetShortkeyIconVisible(bool visible, bool isCursorJump = false, bool isDialog = false, bool onCursor = false)
	{
	}

	[Token(Token = "0x600B39E")]
	[Address(RVA = "0x49E110", Offset = "0x49D310", VA = "0x18049E110")]
	private void InitList()
	{
	}

	[Token(Token = "0x600B39F")]
	[Address(RVA = "0x49D850", Offset = "0x49CA50", VA = "0x18049D850")]
	private void InitComponent()
	{
	}

	[Token(Token = "0x600B3A0")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x600B3A1")]
	[Address(RVA = "0x4A1720", Offset = "0x4A0920", VA = "0x1804A1720")]
	private void UpdateDataList()
	{
	}

	[Token(Token = "0x600B3A2")]
	[Address(RVA = "0x49F670", Offset = "0x49E870", VA = "0x18049F670")]
	public void Open()
	{
	}

	[Token(Token = "0x600B3A3")]
	[Address(RVA = "0x49CE50", Offset = "0x49C050", VA = "0x18049CE50")]
	public void ChangeList(bool layout, Action onFinished)
	{
	}

	[Token(Token = "0x600B3A4")]
	[Address(RVA = "0x4A1CC0", Offset = "0x4A0EC0", VA = "0x1804A1CC0")]
	[IteratorStateMachine(typeof(_003CyChangeList_003Ed__98))]
	private IEnumerator yChangeList(bool layout, Action onFinished)
	{
		return null;
	}

	[Token(Token = "0x600B3A5")]
	[Address(RVA = "0x49CB80", Offset = "0x49BD80", VA = "0x18049CB80")]
	private void ChangeLayout()
	{
	}

	[Token(Token = "0x600B3A6")]
	[Address(RVA = "0x4A0C90", Offset = "0x49FE90", VA = "0x1804A0C90")]
	private void SwitchExpand(bool basic, bool isShow = false)
	{
	}

	[Token(Token = "0x600B3A7")]
	[Address(RVA = "0x49E4F0", Offset = "0x49D6F0", VA = "0x18049E4F0")]
	public void LayoutButtonActive(bool active)
	{
	}

	[Token(Token = "0x600B3A8")]
	[Address(RVA = "0x49E6F0", Offset = "0x49D8F0", VA = "0x18049E6F0", Slot = "4")]
	public void OnItemSetData(GameObject gob, int dataindex)
	{
	}

	[Token(Token = "0x600B3A9")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "8")]
	public void OnGsvStanby()
	{
	}

	[Token(Token = "0x600B3AA")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "7")]
	public void OnItemInitialize(GameObject gob)
	{
	}

	[Token(Token = "0x600B3AB")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
	public void OnItemEntry(GameObject gob, int dataindex)
	{
	}

	[Token(Token = "0x600B3AC")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "6")]
	public void OnItemExit(GameObject gob, int dataindex)
	{
	}

	[Token(Token = "0x600B3AD")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "9")]
	public void UpdateLayout()
	{
	}

	[Token(Token = "0x600B3AE")]
	[Address(RVA = "0x49FED0", Offset = "0x49F0D0", VA = "0x18049FED0")]
	public void SetStatusIcon(Engine.AffectProp affectProp, ElementObjectManager statusRootEom)
	{
	}

	[Token(Token = "0x600B3AF")]
	[Address(RVA = "0x49E310", Offset = "0x49D510", VA = "0x18049E310")]
	protected void Initialize(bool isBasic)
	{
	}

	[Token(Token = "0x600B3B0")]
	[Address(RVA = "0x4A05D0", Offset = "0x49F7D0", VA = "0x1804A05D0")]
	private void SetupSelectorPriority()
	{
	}

	[Token(Token = "0x600B3B1")]
	[Address(RVA = "0x49E1A0", Offset = "0x49D3A0", VA = "0x18049E1A0")]
	private void InitialLayout(bool isBasic)
	{
	}

	[Token(Token = "0x600B3B2")]
	[Address(RVA = "0x49FAC0", Offset = "0x49ECC0", VA = "0x18049FAC0")]
	private void SetLayout()
	{
	}

	[Token(Token = "0x600B3B3")]
	[Address(RVA = "0x49CFA0", Offset = "0x49C1A0", VA = "0x18049CFA0")]
	public void CleanCoroutine()
	{
	}

	[Token(Token = "0x600B3B4")]
	[Address(RVA = "0x49D820", Offset = "0x49CA20", VA = "0x18049D820")]
	private bool GetLayout()
	{
		return default(bool);
	}

	[Token(Token = "0x600B3B5")]
	[Address(RVA = "0x4A1870", Offset = "0x4A0A70", VA = "0x1804A1870")]
	public AttachedEffectListController()
	{
	}
}
