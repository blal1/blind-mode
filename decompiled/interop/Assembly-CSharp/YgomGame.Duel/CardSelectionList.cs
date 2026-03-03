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
using YgomSystem.ElementSystem;
using YgomSystem.UI;
using YgomSystem.UI.ElementWidget;
using YgomSystem.YGomTMPro;

namespace YgomGame.Duel;

[Token(Token = "0x2001866")]
public class CardSelectionList : MonoBehaviour, IGenericScrollViewSupport
{
	[Token(Token = "0x2001867")]
	private class SeperateInfo
	{
		[Token(Token = "0x400E57C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int startindex;

		[Token(Token = "0x400E57D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public int endindex;

		[Token(Token = "0x400E57E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int playerid;

		[Token(Token = "0x400E57F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public CardLocateType locate;

		[Token(Token = "0x400E580")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public CardSelectionListGroupLabel grouplabel;

		[Token(Token = "0x170017E0")]
		public RectTransform grouplabelrt
		{
			[Token(Token = "0x6009C81")]
			[Address(RVA = "0xEB3A40", Offset = "0xEB2C40", VA = "0x180EB3A40")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6009C82")]
		[Address(RVA = "0xEB39E0", Offset = "0xEB2BE0", VA = "0x180EB39E0")]
		public SeperateInfo(CardLocateType locate, int playerid, CardSelectionListGroupLabel grouplabel)
		{
		}
	}

	[Token(Token = "0x2001868")]
	public enum CardLocateType
	{
		[Token(Token = "0x400E582")]
		FieldArea = 0,
		[Token(Token = "0x400E583")]
		FieldZone = 12,
		[Token(Token = "0x400E584")]
		Hand = 13,
		[Token(Token = "0x400E585")]
		Grave = 16,
		[Token(Token = "0x400E586")]
		Exclusion = 17,
		[Token(Token = "0x400E587")]
		ExDeck = 14,
		[Token(Token = "0x400E588")]
		MainDeck = 15,
		[Token(Token = "0x400E589")]
		OverlayUnit = 32,
		[Token(Token = "0x400E58A")]
		CheckTiming = 33,
		[Token(Token = "0x400E58B")]
		None = 18
	}

	[Token(Token = "0x2001869")]
	private class SetListDesc
	{
		[Token(Token = "0x400E58C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public ListType type;

		[Token(Token = "0x400E58D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Action onFinished;

		[Token(Token = "0x400E58E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string title;

		[Token(Token = "0x400E58F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public bool nocancel;

		[Token(Token = "0x400E590")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
		public bool decidable;

		[Token(Token = "0x400E591")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Action onCancelled;

		[Token(Token = "0x400E592")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public bool isWaitInput;

		[Token(Token = "0x400E593")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x39")]
		public bool isSort;

		[Token(Token = "0x6009C83")]
		[Address(RVA = "0xEB3A90", Offset = "0xEB2C90", VA = "0x180EB3A90")]
		public SetListDesc(ListType type, Action onFinished, string title, bool nocancel = false, bool decidable = false, [Optional] Action onCancelled, bool isWaitInput = false, bool isSort = true)
		{
		}
	}

	[Token(Token = "0x200186A")]
	public enum ListType
	{
		[Token(Token = "0x400E595")]
		Summon,
		[Token(Token = "0x400E596")]
		SpSummon,
		[Token(Token = "0x400E597")]
		MonsterEffect,
		[Token(Token = "0x400E598")]
		MagicTrap,
		[Token(Token = "0x400E599")]
		FlipTurn,
		[Token(Token = "0x400E59A")]
		Attack,
		[Token(Token = "0x400E59B")]
		Chain,
		[Token(Token = "0x400E59C")]
		CheckTiming,
		[Token(Token = "0x400E59D")]
		NoramlList,
		[Token(Token = "0x400E59E")]
		NoramlListSetResult,
		[Token(Token = "0x400E59F")]
		Selection,
		[Token(Token = "0x400E5A0")]
		BasicGrave,
		[Token(Token = "0x400E5A1")]
		BasicEx,
		[Token(Token = "0x400E5A2")]
		BasicDeck,
		[Token(Token = "0x400E5A3")]
		OpponentHand,
		[Token(Token = "0x400E5A4")]
		MyDeckTop,
		[Token(Token = "0x400E5A5")]
		OpponentDeckTop,
		[Token(Token = "0x400E5A6")]
		CheckCard,
		[Token(Token = "0x400E5A7")]
		BlindSelect,
		[Token(Token = "0x400E5A8")]
		SelAllCard,
		[Token(Token = "0x400E5A9")]
		SelAllDeck,
		[Token(Token = "0x400E5AA")]
		SelAllMonst,
		[Token(Token = "0x400E5AB")]
		SelAllMonst2,
		[Token(Token = "0x400E5AC")]
		SelAllGadget,
		[Token(Token = "0x400E5AD")]
		SelAllIndeck,
		[Token(Token = "0x400E5AE")]
		SelAllGunkan,
		[Token(Token = "0x400E5AF")]
		SelAllNormal,
		[Token(Token = "0x400E5B0")]
		SelAllNormal2,
		[Token(Token = "0x400E5B1")]
		SelAllArtmage,
		[Token(Token = "0x400E5B2")]
		None
	}

	[Token(Token = "0x200186B")]
	public enum CountMode
	{
		[Token(Token = "0x400E5B4")]
		None,
		[Token(Token = "0x400E5B5")]
		Star,
		[Token(Token = "0x400E5B6")]
		Link,
		[Token(Token = "0x400E5B7")]
		Atk
	}

	[Token(Token = "0x2001872")]
	[CompilerGenerated]
	private sealed class _003CDelayedSelect_003Ed__295 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400E5C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400E5C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400E5C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public CardSelectionList _003C_003E4__this;

		[Token(Token = "0x170017E1")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6009C96")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170017E2")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6009C98")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6009C93")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CDelayedSelect_003Ed__295(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6009C94")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6009C95")]
		[Address(RVA = "0xEB3B30", Offset = "0xEB2D30", VA = "0x180EB3B30", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6009C97")]
		[Address(RVA = "0xEB3BD0", Offset = "0xEB2DD0", VA = "0x180EB3BD0", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x2001873")]
	[CompilerGenerated]
	private sealed class _003CSetStartScale_003Ed__307 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400E5CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400E5CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400E5CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public CardSelectionList _003C_003E4__this;

		[Token(Token = "0x170017E3")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6009C9C")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170017E4")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6009C9E")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6009C99")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CSetStartScale_003Ed__307(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6009C9A")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6009C9B")]
		[Address(RVA = "0xEB3C10", Offset = "0xEB2E10", VA = "0x180EB3C10", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6009C9D")]
		[Address(RVA = "0xEB3E00", Offset = "0xEB3000", VA = "0x180EB3E00", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x2001874")]
	[CompilerGenerated]
	private sealed class _003CUpdateGroupLabelPoolPos_003Ed__235 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400E5CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400E5CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400E5CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public CardSelectionList _003C_003E4__this;

		[Token(Token = "0x170017E5")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6009CA2")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170017E6")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6009CA4")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6009C9F")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CUpdateGroupLabelPoolPos_003Ed__235(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6009CA0")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6009CA1")]
		[Address(RVA = "0xEB68A0", Offset = "0xEB5AA0", VA = "0x180EB68A0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6009CA3")]
		[Address(RVA = "0xEB6AB0", Offset = "0xEB5CB0", VA = "0x180EB6AB0", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x400E4D7")]
	private const string PATH_PREHAB = "Prefabs/Duel/CardSelectionList";

	[Token(Token = "0x400E4D8")]
	private const string PATH_PREHAB_MOBILE = "Prefabs/Duel/CardSelectionList_Mobile";

	[Token(Token = "0x400E4D9")]
	private const string LABEL_EO_TEXTTITLE = "TextTitle";

	[Token(Token = "0x400E4DA")]
	private const string LABEL_EO_TITLE = "Title";

	[Token(Token = "0x400E4DB")]
	private const string LABEL_EO_DECIDEBUTTON = "DecideButton";

	[Token(Token = "0x400E4DC")]
	private const string LABEL_EO_DECISIONBUTTON = "DecisionButton";

	[Token(Token = "0x400E4DD")]
	private const string LABEL_EO_CLOSEBUTTON = "CloseButton";

	[Token(Token = "0x400E4DE")]
	private const string LABEL_EO_VIEWTOGGLE = "ViewToggle";

	[Token(Token = "0x400E4DF")]
	private const string LABEL_EO_SCROLLVIEW_H = "ScrollViewH";

	[Token(Token = "0x400E4E0")]
	private const string LABEL_EO_SCROLLVIEW_V = "ScrollViewV";

	[Token(Token = "0x400E4E1")]
	private const string LABEL_EO_DECIDETEXT = "DecideText";

	[Token(Token = "0x400E4E2")]
	private const string LABEL_EO_CLOSETEXT = "CloseText";

	[Token(Token = "0x400E4E3")]
	private const string LABEL_EO_LISTWINDOW = "ListWindow";

	[Token(Token = "0x400E4E4")]
	private const string LABEL_EO_GROUPLABELTEMPLATE = "GroupLabelTemplate";

	[Token(Token = "0x400E4E5")]
	private const string LABEL_EO_GROUPLABELPILLAR = "GroupLabePillar";

	[Token(Token = "0x400E4E6")]
	private const string LABEL_EO_GROUPLABELPOOL = "GroupLabelPool";

	[Token(Token = "0x400E4E7")]
	private const string LABEL_EO_GROUPSCROLLLEFT = "GroupScrollLeftShortCutSbtn";

	[Token(Token = "0x400E4E8")]
	private const string LABEL_EO_GROUPSCROLLRIGHT = "GroupScrollRightShortCutSbtn";

	[Token(Token = "0x400E4E9")]
	private const string LABEL_EO_FIELDVIEWBUTTON = "FieldViewButton";

	[Token(Token = "0x400E4EA")]
	private const string LABEL_EO_FIELDVIEWON = "FieldViewOn";

	[Token(Token = "0x400E4EB")]
	private const string LABEL_EO_FIELDVIEWOFF = "FieldViewOff";

	[Token(Token = "0x400E4EC")]
	private const string LABEL_EO_FIELDVIEWOFF_EFFECT = "FieldViewOffEffect";

	[Token(Token = "0x400E4ED")]
	private const string LABEL_EO_FIELDVIEWSHORTCUT = "FieldViewShortcut";

	[Token(Token = "0x400E4EE")]
	private const string LABEL_EO_CHANGELAYOUTBUTTON = "LayoutChangeButton";

	[Token(Token = "0x400E4EF")]
	private const string LABEL_EO_CHANGELAYOUT_H = "LayoutChangeH";

	[Token(Token = "0x400E4F0")]
	private const string LABEL_EO_CHANGELAYOUT_V = "LayoutChangeV";

	[Token(Token = "0x400E4F1")]
	private const string LABEL_EO_CHANGELAYOUTSHORTCUT = "LayoutChangeShortcut";

	[Token(Token = "0x400E4F2")]
	private const string LABEL_EO_COUNTERGROUP = "CounterGroup";

	[Token(Token = "0x400E4F3")]
	private const string LABEL_EO_STARGROUP = "StarGroup";

	[Token(Token = "0x400E4F4")]
	private const string LABEL_EO_STARTEMPLATE = "StarTemplate";

	[Token(Token = "0x400E4F5")]
	private const string LABEL_EO_LINKGROUP = "LinkGroup";

	[Token(Token = "0x400E4F6")]
	private const string LABEL_EO_LINKTEMPLATE = "LinkTemplate";

	[Token(Token = "0x400E4F7")]
	private const string LABEL_EO_ATTACKGROUP = "AttackGroup";

	[Token(Token = "0x400E4F8")]
	private const string LABEL_EO_CURRENTPARAM = "CurrentParam";

	[Token(Token = "0x400E4F9")]
	private const string LABEL_EO_REQUIREPARAM = "RequireParam";

	[Token(Token = "0x400E4FA")]
	private const string LABEL_EO_DICARDGROUP = "DiscardGroup";

	[Token(Token = "0x400E4FB")]
	private const string LABEL_EO_DICARDREMAIN = "DiscardRemain";

	[Token(Token = "0x400E4FC")]
	private const string LABEL_EO_INPUTFIELD = "InputField";

	[Token(Token = "0x400E4FD")]
	private const string LABEL_EO_NOHITTEXT = "NoHitText";

	[Token(Token = "0x400E4FE")]
	private const string LABEL_EO_CARDNAME = "CardName";

	[Token(Token = "0x400E4FF")]
	private const string LABEL_EO_ARROWLEFT = "ArrowLeft";

	[Token(Token = "0x400E500")]
	private const string LABEL_EO_ARROWRIGHT = "ArrowRight";

	[Token(Token = "0x400E501")]
	private const string LABEL_EO_INPUTBUTTON = "InputButton";

	[Token(Token = "0x400E502")]
	private const string LABEL_TW_OPEN = "In";

	[Token(Token = "0x400E503")]
	private const string LABEL_TW_VIEWTOGGLE = "ViewToggle";

	[Token(Token = "0x400E504")]
	private const string LABEL_TW_DECIDEBUTTON = "DecideButton";

	[Token(Token = "0x400E505")]
	private const string LABEL_TW_CLOSEBUTTON = "CloseButton";

	[Token(Token = "0x400E506")]
	private const string LABEL_TW_FADEIN = "FadeIn";

	[Token(Token = "0x400E507")]
	private const string LABEL_TW_FADEOUT = "FadeOut";

	[Token(Token = "0x400E508")]
	private const string LABEL_TW_NORMALLIST = "Normal";

	[Token(Token = "0x400E509")]
	private const string LABEL_TW_CHAINLIST = "Chain";

	[Token(Token = "0x400E50A")]
	private const string LABEL_TW_VIEW_START = "StartFieldView";

	[Token(Token = "0x400E50B")]
	private const string LABEL_TW_VIEW_FINISH = "FinishFieldView";

	[Token(Token = "0x400E50C")]
	public const int INVALIDRUNLISTINEDX = -1;

	[Token(Token = "0x400E50D")]
	private const int TITLETEXT_INDEX_DEFAULT = -1;

	[Token(Token = "0x400E50E")]
	private const int TITLETEXT_INDEX_GENERIC = 266;

	[Token(Token = "0x400E50F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private bool m_IsWaitInput;

	[Token(Token = "0x400E510")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private Transform m_Parent;

	[Token(Token = "0x400E511")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static readonly Dictionary<ListType, uint> CmdMask;

	[Token(Token = "0x400E512")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	private float MaxWidth;

	[Token(Token = "0x400E513")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	[SerializeField]
	private float MinWidth;

	[Token(Token = "0x400E514")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[SerializeField]
	private float VerticalWidth;

	[Token(Token = "0x400E515")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	[SerializeField]
	private int MaxHeight;

	[Token(Token = "0x400E516")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[SerializeField]
	[Header("ヘッダが大きすぎる場合の高さ(安全装置)")]
	private int MiddleHeight;

	[Token(Token = "0x400E517")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	[SerializeField]
	[Header("↑の基準となる高さ")]
	private int HeaderHeight;

	[Token(Token = "0x400E518")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[SerializeField]
	private int ThresLabel;

	[Token(Token = "0x400E519")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private DuelClient m_DuelClient;

	[Token(Token = "0x400E51A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private ExtendedTextMeshProUGUI m_TextTitle;

	[Token(Token = "0x400E51B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private Selector m_Selector;

	[Token(Token = "0x400E51C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private Selector[] m_SelectorGroup;

	[Token(Token = "0x400E51D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private ElementObjectManager m_Eom;

	[Token(Token = "0x400E51E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private GenericScrollView m_Gsv;

	[Token(Token = "0x400E51F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private bool isVerticalScroll;

	[Token(Token = "0x400E520")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private GenericScrollView m_GsvH;

	[Token(Token = "0x400E521")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private ScrollRect m_ScrollRectH;

	[Token(Token = "0x400E522")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private GenericScrollView m_GsvV;

	[Token(Token = "0x400E523")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	private ScrollRect m_ScrollRectV;

	[Token(Token = "0x400E524")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	private SelectionButton m_DecideButton;

	[Token(Token = "0x400E525")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	private SelectionButton m_CloseButton;

	[Token(Token = "0x400E526")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	private SelectionButton m_DecisionButton;

	[Token(Token = "0x400E527")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	private RectTransform m_ListWindowRT;

	[Token(Token = "0x400E528")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	private InputFieldWidget m_InputFiled;

	[Token(Token = "0x400E529")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	private SelectionButtonUntouchable m_InputCancelButton;

	[Token(Token = "0x400E52A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	private GameObject m_NoHitText;

	[Token(Token = "0x400E52B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	private GameObject m_GroupLabelTemplate;

	[Token(Token = "0x400E52C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	private List<ListCardData> m_GroupedDataList;

	[Token(Token = "0x400E52D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	private List<int> m_TutorialHighlightList;

	[Token(Token = "0x400E52E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	private List<int> m_SelectedList;

	[Token(Token = "0x400E52F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
	private List<SeperateInfo> m_SeperateInfoList;

	[Token(Token = "0x400E530")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
	private Stack<CardSelectionListGroupLabel> m_GroupLabelFreeStack;

	[Token(Token = "0x400E531")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
	private RectTransform m_GroupLabelPillar;

	[Token(Token = "0x400E532")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
	private RectTransform m_GroupLabelPool;

	[Token(Token = "0x400E533")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
	private RectMask2D m_GroupLabelMask;

	[Token(Token = "0x400E534")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
	private ExtendedTextMeshProUGUI m_CardName;

	[Token(Token = "0x400E535")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
	private GameObject m_FieldViewIconOn;

	[Token(Token = "0x400E536")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
	private GameObject m_FieldViewIconOff;

	[Token(Token = "0x400E537")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
	private GameObject m_FieldViewIconOffEffect;

	[Token(Token = "0x400E538")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
	private GameObject m_BaseOn;

	[Token(Token = "0x400E539")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
	private GameObject m_BaseOnNormal;

	[Token(Token = "0x400E53A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
	private GameObject m_BaseOnChain;

	[Token(Token = "0x400E53B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
	private GameObject m_BaseOff;

	[Token(Token = "0x400E53C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
	private GameObject m_BaseOffNormal;

	[Token(Token = "0x400E53D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
	private GameObject m_BaseOffChain;

	[Token(Token = "0x400E53E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
	private SelectionButton m_ChangeLayoutButton;

	[Token(Token = "0x400E53F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
	private GameObject m_ChangeLayoutIconH;

	[Token(Token = "0x400E540")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
	private GameObject m_ChangeLayoutIconV;

	[Token(Token = "0x400E541")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
	private GameObject m_LayoutBaseNormal;

	[Token(Token = "0x400E542")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
	private GameObject m_LayoutBaseChain;

	[Token(Token = "0x400E543")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
	private GameObject m_ArrowGroup;

	[Token(Token = "0x400E544")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
	private SelectionButton m_ArrowLeft;

	[Token(Token = "0x400E545")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1B0")]
	private SelectionButton m_ArrowRight;

	[Token(Token = "0x400E546")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1B8")]
	private GameObject counterGroup;

	[Token(Token = "0x400E547")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C0")]
	private GameObject starGroup;

	[Token(Token = "0x400E548")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C8")]
	private GameObject linkGroup;

	[Token(Token = "0x400E549")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1D0")]
	private GameObject atkGroup;

	[Token(Token = "0x400E54A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1D8")]
	private ElementObjectManager starTemplate;

	[Token(Token = "0x400E54B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1E0")]
	private ElementObjectManager linkTemplate;

	[Token(Token = "0x400E54C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1E8")]
	private ExtendedTextMeshProUGUI textRequireParam;

	[Token(Token = "0x400E54D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1F0")]
	private ExtendedTextMeshProUGUI textCurrentParam;

	[Token(Token = "0x400E54E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1F8")]
	private CountMode currentCountMode;

	[Token(Token = "0x400E54F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1FC")]
	private int maxCount;

	[Token(Token = "0x400E550")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x200")]
	private int currentCount;

	[Token(Token = "0x400E551")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x208")]
	private List<ElementObjectManager> countObjects;

	[Token(Token = "0x400E552")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x210")]
	private GameObject discardGroup;

	[Token(Token = "0x400E553")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x218")]
	private ExtendedTextMeshProUGUI textDiscardRemain;

	[Token(Token = "0x400E554")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x220")]
	private bool m_FieldViewing;

	[Token(Token = "0x400E555")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x221")]
	private bool m_Closing;

	[Token(Token = "0x400E556")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x222")]
	private bool m_Opening;

	[Token(Token = "0x400E557")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x223")]
	private bool m_Open;

	[Token(Token = "0x400E558")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x224")]
	private bool m_Cancable;

	[Token(Token = "0x400E559")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x225")]
	private bool m_UseDecideButton;

	[Token(Token = "0x400E55A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x226")]
	private bool m_SkipSortFlag;

	[Token(Token = "0x400E55B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x228")]
	private int m_ChangeTitleFlag;

	[Token(Token = "0x400E55C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x22C")]
	private int m_SelectMaxNum;

	[Token(Token = "0x400E55D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x230")]
	private int m_SelectMinNum;

	[Token(Token = "0x400E55E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x238")]
	private RectTransform m_Title;

	[Token(Token = "0x400E55F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x240")]
	private string m_Titlemsg;

	[Token(Token = "0x400E560")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x248")]
	private ListType m_ListType;

	[Token(Token = "0x400E561")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x250")]
	private CanvasGroup m_CanvasGroup;

	[Token(Token = "0x400E562")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x258")]
	private PopUpTextForSelectionList m_PppupText;

	[Token(Token = "0x400E563")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x260")]
	private List<int> candidateCards;

	[Token(Token = "0x400E564")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x268")]
	private Queue<SetListDesc> m_DescQueue;

	[Token(Token = "0x400E565")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x270")]
	private Tween m_OpenTween;

	[Token(Token = "0x400E566")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x278")]
	private Tween m_CloseTween;

	[Token(Token = "0x400E567")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x280")]
	private Tween m_StartFieldViewTween;

	[Token(Token = "0x400E568")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x288")]
	private Tween m_FinishFieldViewTween;

	[Token(Token = "0x400E569")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x290")]
	private int m_InputBlockCounter;

	[Token(Token = "0x400E56A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x298")]
	private RectTransform m_CommandBase;

	[Token(Token = "0x400E56B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2A0")]
	private string cachedFmt;

	[Token(Token = "0x400E574")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2E8")]
	public Action OnFinished;

	[Token(Token = "0x400E575")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2F0")]
	public Action OnCanceled;

	[Token(Token = "0x400E576")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2F8")]
	public Action<int, int, bool> OnSelected;

	[Token(Token = "0x400E577")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x300")]
	public Action OnUnselect;

	[Token(Token = "0x400E57A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x318")]
	public int CurrentCursoredDataIndex;

	[Token(Token = "0x400E57B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x320")]
	private Action initialSelectCallback;

	[Token(Token = "0x170017C8")]
	private string LABEL_TW_CLOSE
	{
		[Token(Token = "0x6009BDE")]
		[Address(RVA = "0xE9CED0", Offset = "0xE9C0D0", VA = "0x180E9CED0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170017C9")]
	private bool m_IsDecisionActive
	{
		[Token(Token = "0x6009BE2")]
		[Address(RVA = "0xE9D0B0", Offset = "0xE9C2B0", VA = "0x180E9D0B0")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170017CA")]
	private bool m_IsDecideActive
	{
		[Token(Token = "0x6009BE3")]
		[Address(RVA = "0xE9D050", Offset = "0xE9C250", VA = "0x180E9D050")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170017CB")]
	private bool m_IsCloseActive
	{
		[Token(Token = "0x6009BE4")]
		[Address(RVA = "0xE9CFF0", Offset = "0xE9C1F0", VA = "0x180E9CFF0")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170017CC")]
	public bool isVertical
	{
		[Token(Token = "0x6009BE5")]
		[Address(RVA = "0x449800", Offset = "0x448A00", VA = "0x180449800")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170017CD")]
	private string remainFormat
	{
		[Token(Token = "0x6009BE6")]
		[Address(RVA = "0xE9D110", Offset = "0xE9C310", VA = "0x180E9D110")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170017CE")]
	public Action OnOpenBegin
	{
		[Token(Token = "0x6009BE7")]
		[Address(RVA = "0x49BEE0", Offset = "0x49B0E0", VA = "0x18049BEE0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6009BE8")]
		[Address(RVA = "0x49C5F0", Offset = "0x49B7F0", VA = "0x18049C5F0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x170017CF")]
	public Action OnOpenEnd
	{
		[Token(Token = "0x6009BE9")]
		[Address(RVA = "0x49B8E0", Offset = "0x49AAE0", VA = "0x18049B8E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6009BEA")]
		[Address(RVA = "0x49C140", Offset = "0x49B340", VA = "0x18049C140")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x170017D0")]
	public Action OnCloseBegin
	{
		[Token(Token = "0x6009BEB")]
		[Address(RVA = "0x6D4640", Offset = "0x6D3840", VA = "0x1806D4640")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6009BEC")]
		[Address(RVA = "0x4D4300", Offset = "0x4D3500", VA = "0x1804D4300")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x170017D1")]
	public Action OnCloseEnd
	{
		[Token(Token = "0x6009BED")]
		[Address(RVA = "0x6D4700", Offset = "0x6D3900", VA = "0x1806D4700")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6009BEE")]
		[Address(RVA = "0x498130", Offset = "0x497330", VA = "0x180498130")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x170017D2")]
	public Action OnFieldViewStartBegin
	{
		[Token(Token = "0x6009BEF")]
		[Address(RVA = "0xE9CF60", Offset = "0xE9C160", VA = "0x180E9CF60")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6009BF0")]
		[Address(RVA = "0xE9D240", Offset = "0xE9C440", VA = "0x180E9D240")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x170017D3")]
	public Action OnFieldViewStartEnd
	{
		[Token(Token = "0x6009BF1")]
		[Address(RVA = "0xE9CF70", Offset = "0xE9C170", VA = "0x180E9CF70")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6009BF2")]
		[Address(RVA = "0x498150", Offset = "0x497350", VA = "0x180498150")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x170017D4")]
	public Action OnFieldViewFinishBegin
	{
		[Token(Token = "0x6009BF3")]
		[Address(RVA = "0xE9CF40", Offset = "0xE9C140", VA = "0x180E9CF40")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6009BF4")]
		[Address(RVA = "0xE9D220", Offset = "0xE9C420", VA = "0x180E9D220")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x170017D5")]
	public Action OnFieldViewFinishEnd
	{
		[Token(Token = "0x6009BF5")]
		[Address(RVA = "0xE9CF50", Offset = "0xE9C150", VA = "0x180E9CF50")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6009BF6")]
		[Address(RVA = "0x498170", Offset = "0x497370", VA = "0x180498170")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x170017D6")]
	public bool IsActive
	{
		[Token(Token = "0x6009BF7")]
		[Address(RVA = "0xE9CE70", Offset = "0xE9C070", VA = "0x180E9CE70")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170017D7")]
	public bool IsDisp
	{
		[Token(Token = "0x6009BF8")]
		[Address(RVA = "0xE9CE90", Offset = "0xE9C090", VA = "0x180E9CE90")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170017D8")]
	public bool isCancelable
	{
		[Token(Token = "0x6009BF9")]
		[Address(RVA = "0xE9CF80", Offset = "0xE9C180", VA = "0x180E9CF80")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170017D9")]
	public bool isTweenPlaying
	{
		[Token(Token = "0x6009BFA")]
		[Address(RVA = "0xE9CFD0", Offset = "0xE9C1D0", VA = "0x180E9CFD0")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170017DA")]
	public bool isFieldViewing
	{
		[Token(Token = "0x6009BFB")]
		[Address(RVA = "0x608CD0", Offset = "0x607ED0", VA = "0x180608CD0")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170017DB")]
	public bool isTempFieldViewing
	{
		[Token(Token = "0x6009BFC")]
		[Address(RVA = "0xE9CFC0", Offset = "0xE9C1C0", VA = "0x180E9CFC0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6009BFD")]
		[Address(RVA = "0xE9D260", Offset = "0xE9C460", VA = "0x180E9D260")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x170017DC")]
	public bool isClosing
	{
		[Token(Token = "0x6009BFE")]
		[Address(RVA = "0xE9CF90", Offset = "0xE9C190", VA = "0x180E9CF90")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170017DD")]
	public bool isOpening
	{
		[Token(Token = "0x6009BFF")]
		[Address(RVA = "0xE9CFB0", Offset = "0xE9C1B0", VA = "0x180E9CFB0")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170017DE")]
	public bool isOpen
	{
		[Token(Token = "0x6009C00")]
		[Address(RVA = "0xE9CFA0", Offset = "0xE9C1A0", VA = "0x180E9CFA0")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170017DF")]
	public Action<bool, List<int>> decidedCallback
	{
		[Token(Token = "0x6009C01")]
		[Address(RVA = "0x49BEF0", Offset = "0x49B0F0", VA = "0x18049BEF0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6009C02")]
		[Address(RVA = "0x49C610", Offset = "0x49B810", VA = "0x18049C610")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x6009BDF")]
	[Address(RVA = "0xE8D970", Offset = "0xE8CB70", VA = "0x180E8D970")]
	public static void Create(DuelClient client, Transform parent, bool isVertical, UnityAction<CardSelectionList> onFisnih)
	{
	}

	[Token(Token = "0x6009BE0")]
	[Address(RVA = "0xE915D0", Offset = "0xE907D0", VA = "0x180E915D0")]
	private void Initialize(DuelClient client, Transform parent, bool isVertical)
	{
	}

	[Token(Token = "0x6009BE1")]
	[Address(RVA = "0xE99540", Offset = "0xE98740", VA = "0x180E99540")]
	public void SetList(ListType type, Action onFinished, string title, bool nocancel = false, bool decidable = false, [Optional] Action onCancelled, bool isWaitInput = false, bool isSort = true)
	{
	}

	[Token(Token = "0x6009C03")]
	[Address(RVA = "0xE8ED90", Offset = "0xE8DF90", VA = "0x180E8ED90")]
	private void InitComponents()
	{
	}

	[Token(Token = "0x6009C04")]
	[Address(RVA = "0xE97EA0", Offset = "0xE970A0", VA = "0x180E97EA0")]
	private void SetFieldViewButtonBase(bool isOn)
	{
	}

	[Token(Token = "0x6009C05")]
	[Address(RVA = "0xE966F0", Offset = "0xE958F0", VA = "0x180E966F0")]
	private void SetBaseChain(bool isChain)
	{
	}

	[Token(Token = "0x6009C06")]
	[Address(RVA = "0xE956B0", Offset = "0xE948B0", VA = "0x180E956B0")]
	private void OnScrollRectValueChange(Vector2 bias)
	{
	}

	[Token(Token = "0x6009C07")]
	[Address(RVA = "0xE9C5C0", Offset = "0xE9B7C0", VA = "0x180E9C5C0")]
	private void UpdateGroupLabelPos()
	{
	}

	[Token(Token = "0x6009C08")]
	[Address(RVA = "0xE9C550", Offset = "0xE9B750", VA = "0x180E9C550")]
	[IteratorStateMachine(typeof(_003CUpdateGroupLabelPoolPos_003Ed__235))]
	private IEnumerator UpdateGroupLabelPoolPos()
	{
		return null;
	}

	[Token(Token = "0x6009C09")]
	[Address(RVA = "0xE8EC60", Offset = "0xE8DE60", VA = "0x180E8EC60")]
	private int GetSeperateInfoIndexByDataIndex(int dataindex)
	{
		return default(int);
	}

	[Token(Token = "0x6009C0A")]
	[Address(RVA = "0xE91420", Offset = "0xE90620", VA = "0x180E91420")]
	private void InitVariables()
	{
	}

	[Token(Token = "0x6009C0B")]
	[Address(RVA = "0xE8DDD0", Offset = "0xE8CFD0", VA = "0x180E8DDD0")]
	private CardSelectionListGroupLabel GetGroupLabel(int player, CardLocateType locate)
	{
		return null;
	}

	[Token(Token = "0x6009C0C")]
	[Address(RVA = "0xE97210", Offset = "0xE96410", VA = "0x180E97210")]
	private void SetDecideVisible(bool visible, ListType type = ListType.Attack)
	{
	}

	[Token(Token = "0x6009C0D")]
	[Address(RVA = "0xE975D0", Offset = "0xE967D0", VA = "0x180E975D0")]
	private void SetDecisionVisible(bool visible)
	{
	}

	[Token(Token = "0x6009C0E")]
	[Address(RVA = "0xE97570", Offset = "0xE96770", VA = "0x180E97570")]
	private void SetDecisionEnable(bool enable)
	{
	}

	[Token(Token = "0x6009C0F")]
	[Address(RVA = "0xE96960", Offset = "0xE95B60", VA = "0x180E96960")]
	private void SetCloseVisible(bool visible, bool decidable)
	{
	}

	[Token(Token = "0x6009C10")]
	[Address(RVA = "0xE96900", Offset = "0xE95B00", VA = "0x180E96900")]
	private void SetCloseEnable(bool enable)
	{
	}

	[Token(Token = "0x6009C11")]
	[Address(RVA = "0xE96E90", Offset = "0xE96090", VA = "0x180E96E90")]
	private void SetDecideButtonTransition()
	{
	}

	[Token(Token = "0x6009C12")]
	[Address(RVA = "0xE967D0", Offset = "0xE959D0", VA = "0x180E967D0")]
	private void SetCloseButtonTransition()
	{
	}

	[Token(Token = "0x6009C13")]
	[Address(RVA = "0xE973B0", Offset = "0xE965B0", VA = "0x180E973B0")]
	private void SetDecisionButtonTransition()
	{
	}

	[Token(Token = "0x6009C14")]
	[Address(RVA = "0xE96F80", Offset = "0xE96180", VA = "0x180E96F80")]
	private void SetDecideEnable(bool valid, bool reachMax = false)
	{
	}

	[Token(Token = "0x6009C15")]
	[Address(RVA = "0xE97690", Offset = "0xE96890", VA = "0x180E97690")]
	public void SetFieldViewActive(bool field_view_active, bool changeContentActive = false, bool isTemperate = false, [Optional] SelectionItem selectItem)
	{
	}

	[Token(Token = "0x6009C16")]
	[Address(RVA = "0xE8B110", Offset = "0xE8A310", VA = "0x180E8B110")]
	private void ChangeLayout(bool isIni = false)
	{
	}

	[Token(Token = "0x6009C17")]
	[Address(RVA = "0xE97F60", Offset = "0xE97160", VA = "0x180E97F60")]
	private void SetLayout(bool vertical, bool isIni = false)
	{
	}

	[Token(Token = "0x6009C18")]
	[Address(RVA = "0xE964E0", Offset = "0xE956E0", VA = "0x180E964E0")]
	private void SetArrowVisible()
	{
	}

	[Token(Token = "0x6009C19")]
	[Address(RVA = "0xE9AB20", Offset = "0xE99D20", VA = "0x180E9AB20")]
	private void SwitchTween(string startlabel, string stoplabel = "")
	{
	}

	[Token(Token = "0x6009C1A")]
	[Address(RVA = "0xE997B0", Offset = "0xE989B0", VA = "0x180E997B0")]
	private void SetSelectionListWidth(int itemcount)
	{
	}

	[Token(Token = "0x6009C1B")]
	[Address(RVA = "0xE8BCE0", Offset = "0xE8AEE0", VA = "0x180E8BCE0")]
	private ListCardData CreateChainData(int position, int index)
	{
		return null;
	}

	[Token(Token = "0x6009C1C")]
	[Address(RVA = "0xE8C1C0", Offset = "0xE8B3C0", VA = "0x180E8C1C0")]
	private ListCardData CreateListCardData(int player, int position, int index, ListCardData.DataSource dataSource, bool forceinsight = false)
	{
		return null;
	}

	[Token(Token = "0x6009C1D")]
	[Address(RVA = "0xE8B7A0", Offset = "0xE8A9A0", VA = "0x180E8B7A0")]
	private List<ListCardData> CreateActivableList(ListType type)
	{
		return null;
	}

	[Token(Token = "0x6009C1E")]
	[Address(RVA = "0xE8C020", Offset = "0xE8B220", VA = "0x180E8C020")]
	private List<ListCardData> CreateDeckList([Optional] List<ListCardData> ret)
	{
		return null;
	}

	[Token(Token = "0x6009C1F")]
	[Address(RVA = "0xE8CD20", Offset = "0xE8BF20", VA = "0x180E8CD20")]
	private List<ListCardData> CreatePosSelectList([Optional] List<ListCardData> ret)
	{
		return null;
	}

	[Token(Token = "0x6009C20")]
	[Address(RVA = "0xE8C550", Offset = "0xE8B750", VA = "0x180E8C550")]
	private List<ListCardData> CreateNormalList()
	{
		return null;
	}

	[Token(Token = "0x6009C21")]
	[Address(RVA = "0xE8D460", Offset = "0xE8C660", VA = "0x180E8D460")]
	private List<ListCardData> CreateSelectionList()
	{
		return null;
	}

	[Token(Token = "0x6009C22")]
	[Address(RVA = "0xE8CBA0", Offset = "0xE8BDA0", VA = "0x180E8CBA0")]
	private List<ListCardData> CreateOpponentHandList()
	{
		return null;
	}

	[Token(Token = "0x6009C23")]
	[Address(RVA = "0xE8C0C0", Offset = "0xE8B2C0", VA = "0x180E8C0C0")]
	private List<ListCardData> CreateDeckTopList(int player)
	{
		return null;
	}

	[Token(Token = "0x6009C24")]
	[Address(RVA = "0xE8BD70", Offset = "0xE8AF70", VA = "0x180E8BD70")]
	private List<ListCardData> CreateCheckCardList()
	{
		return null;
	}

	[Token(Token = "0x6009C25")]
	[Address(RVA = "0xE95CB0", Offset = "0xE94EB0", VA = "0x180E95CB0")]
	private void RemoveCardBadge(int dataindex, ref ListCardData selecteddata)
	{
	}

	[Token(Token = "0x6009C26")]
	[Address(RVA = "0xE95FE0", Offset = "0xE951E0", VA = "0x180E95FE0")]
	private void SelectIndex(int dataindexsort)
	{
	}

	[Token(Token = "0x6009C27")]
	[Address(RVA = "0xE8AE20", Offset = "0xE8A020", VA = "0x180E8AE20")]
	private void ChangeDecideButtonText(ListCardData cardData)
	{
	}

	[Token(Token = "0x6009C28")]
	[Address(RVA = "0xE8AC60", Offset = "0xE89E60", VA = "0x180E8AC60")]
	private void AddTitleInfo()
	{
	}

	[Token(Token = "0x6009C29")]
	[Address(RVA = "0xE96E10", Offset = "0xE96010", VA = "0x180E96E10")]
	private void SetCursor(int dataindex)
	{
	}

	[Token(Token = "0x6009C2A")]
	[Address(RVA = "0xE93150", Offset = "0xE92350", VA = "0x180E93150")]
	private void OnClickCard(ListCard card)
	{
	}

	[Token(Token = "0x6009C2B")]
	[Address(RVA = "0xE94420", Offset = "0xE93620", VA = "0x180E94420")]
	private void OnHoldCard(ListCard card)
	{
	}

	[Token(Token = "0x6009C2C")]
	[Address(RVA = "0xE94060", Offset = "0xE93260", VA = "0x180E94060")]
	private void OnDoubleClickCard(ListCard card)
	{
	}

	[Token(Token = "0x6009C2D")]
	[Address(RVA = "0xE8DF60", Offset = "0xE8D160", VA = "0x180E8DF60")]
	private List<ListCardData> GetGroupedDataList(List<ListCardData> infoList, bool isSort = true)
	{
		return null;
	}

	[Token(Token = "0x6009C2E")]
	[Address(RVA = "0xE918D0", Offset = "0xE90AD0", VA = "0x180E918D0")]
	private List<ListCardData> ListGroupByLocate(List<ListCardData> infoList, int playerid, bool isSort = true)
	{
		return null;
	}

	[Token(Token = "0x6009C2F")]
	[Address(RVA = "0xE8B480", Offset = "0xE8A680", VA = "0x180E8B480")]
	private void CombineList(List<ListCardData> orglist, List<ListCardData> dstlist, CardLocateType locate, int playerid)
	{
	}

	[Token(Token = "0x6009C30")]
	[Address(RVA = "0xE95AD0", Offset = "0xE94CD0", VA = "0x180E95AD0")]
	private void RecycleGroupLabel()
	{
	}

	[Token(Token = "0x6009C31")]
	[Address(RVA = "0xE92030", Offset = "0xE91230", VA = "0x180E92030")]
	private List<ListCardData> ListSortByCard(List<ListCardData> infoList)
	{
		return null;
	}

	[Token(Token = "0x6009C32")]
	[Address(RVA = "0xE8E780", Offset = "0xE8D980", VA = "0x180E8E780")]
	private int GetMonsterSortPoint(int cardid)
	{
		return default(int);
	}

	[Token(Token = "0x6009C33")]
	[Address(RVA = "0xE8E410", Offset = "0xE8D610", VA = "0x180E8E410")]
	private int GetIconSortPoint(int cardid)
	{
		return default(int);
	}

	[Token(Token = "0x6009C34")]
	[Address(RVA = "0xE9A790", Offset = "0xE99990", VA = "0x180E9A790")]
	private void SetupSearchList(string path)
	{
	}

	[Token(Token = "0x6009C35")]
	[Address(RVA = "0xE98300", Offset = "0xE97500", VA = "0x180E98300")]
	private void SetListImpl(ListType type, Action callback, bool decidable, bool nocancel, Action cancelCb, bool isSort = true)
	{
	}

	[Token(Token = "0x6009C36")]
	[Address(RVA = "0xE956C0", Offset = "0xE948C0", VA = "0x180E956C0")]
	public void Open()
	{
	}

	[Token(Token = "0x6009C37")]
	[Address(RVA = "0xE8B1E0", Offset = "0xE8A3E0", VA = "0x180E8B1E0")]
	public void Close(bool forceclose = false)
	{
	}

	[Token(Token = "0x6009C38")]
	[Address(RVA = "0xE93600", Offset = "0xE92800", VA = "0x180E93600")]
	public void OnDecide()
	{
	}

	[Token(Token = "0x6009C39")]
	[Address(RVA = "0xE92F60", Offset = "0xE92160", VA = "0x180E92F60")]
	public void OnCancel(bool decide, bool playse = true)
	{
	}

	[Token(Token = "0x6009C3A")]
	[Address(RVA = "0xE92D80", Offset = "0xE91F80", VA = "0x180E92D80")]
	public bool OnBack()
	{
		return default(bool);
	}

	[Token(Token = "0x6009C3B")]
	[Address(RVA = "0x3C7A70", Offset = "0x3C6C70", VA = "0x1803C7A70")]
	public bool OnDecideCardInField(int player, int position, int index)
	{
		return default(bool);
	}

	[Token(Token = "0x6009C3C")]
	[Address(RVA = "0xE94110", Offset = "0xE93310", VA = "0x180E94110")]
	public void OnFinishClose()
	{
	}

	[Token(Token = "0x6009C3D")]
	[Address(RVA = "0xE99BB0", Offset = "0xE98DB0", VA = "0x180E99BB0")]
	private void SetSelectorsEnable(bool enable)
	{
	}

	[Token(Token = "0x6009C3E")]
	[Address(RVA = "0xE92B30", Offset = "0xE91D30", VA = "0x180E92B30")]
	private void ManualDownTransition(float position)
	{
	}

	[Token(Token = "0x6009C3F")]
	[Address(RVA = "0xE8E530", Offset = "0xE8D730", VA = "0x180E8E530")]
	private SelectionButton GetItemByManualDownTransition(float position)
	{
		return null;
	}

	[Token(Token = "0x6009C40")]
	[Address(RVA = "0xE94CF0", Offset = "0xE93EF0", VA = "0x180E94CF0", Slot = "4")]
	public void OnItemSetData(GameObject gob, int dataindex)
	{
	}

	[Token(Token = "0x6009C41")]
	[Address(RVA = "0xE94A50", Offset = "0xE93C50", VA = "0x180E94A50", Slot = "7")]
	public void OnItemInitialize(GameObject gob)
	{
	}

	[Token(Token = "0x6009C42")]
	[Address(RVA = "0xE94220", Offset = "0xE93420", VA = "0x180E94220", Slot = "8")]
	public void OnGsvStanby()
	{
	}

	[Token(Token = "0x6009C43")]
	[Address(RVA = "0xE8DC20", Offset = "0xE8CE20", VA = "0x180E8DC20")]
	[IteratorStateMachine(typeof(_003CDelayedSelect_003Ed__295))]
	private IEnumerator DelayedSelect()
	{
		return null;
	}

	[Token(Token = "0x6009C44")]
	[Address(RVA = "0xE9C910", Offset = "0xE9BB10", VA = "0x180E9C910", Slot = "9")]
	public void UpdateLayout()
	{
	}

	[Token(Token = "0x6009C45")]
	[Address(RVA = "0xE96D90", Offset = "0xE95F90", VA = "0x180E96D90")]
	public void SetCursorToCurrentIndex()
	{
	}

	[Token(Token = "0x6009C46")]
	[Address(RVA = "0xE95EE0", Offset = "0xE950E0", VA = "0x180E95EE0")]
	public bool SelectCardByUniqueId(int uniqueid)
	{
		return default(bool);
	}

	[Token(Token = "0x6009C47")]
	[Address(RVA = "0xE8DAD0", Offset = "0xE8CCD0", VA = "0x180E8DAD0")]
	public bool DecideCardByUniqueId(int uniqueid)
	{
		return default(bool);
	}

	[Token(Token = "0x6009C48")]
	[Address(RVA = "0xE99F20", Offset = "0xE99120", VA = "0x180E99F20")]
	private void SetTitle(string title)
	{
	}

	[Token(Token = "0x6009C49")]
	[Address(RVA = "0xE8D1B0", Offset = "0xE8C3B0", VA = "0x180E8D1B0")]
	private List<ListCardData> CreateSearchList(string searchText)
	{
		return null;
	}

	[Token(Token = "0x6009C4A")]
	[Address(RVA = "0xE9AA50", Offset = "0xE99C50", VA = "0x180E9AA50")]
	private void SetupSelectorPriority()
	{
	}

	[Token(Token = "0x6009C4B")]
	[Address(RVA = "0xE9AAE0", Offset = "0xE99CE0", VA = "0x180E9AAE0")]
	public void ShowCounter(Engine.DialogRitualType type, int remainCount, int maxCount)
	{
	}

	[Token(Token = "0x6009C4C")]
	[Address(RVA = "0xE8ED40", Offset = "0xE8DF40", VA = "0x180E8ED40")]
	public void HideOptionalGroup()
	{
	}

	[Token(Token = "0x6009C4D")]
	[Address(RVA = "0xE9A330", Offset = "0xE99530", VA = "0x180E9A330")]
	private void SetupCounterMethod(bool show, Engine.DialogRitualType type, int remainCount, int maxCount)
	{
	}

	[Token(Token = "0x6009C4E")]
	[Address(RVA = "0xE9A4A0", Offset = "0xE996A0", VA = "0x180E9A4A0")]
	private void SetupCounter(Engine.DialogRitualType type, int remainCount, int maxCount)
	{
	}

	[Token(Token = "0x6009C4F")]
	[Address(RVA = "0xE99EB0", Offset = "0xE990B0", VA = "0x180E99EB0")]
	[IteratorStateMachine(typeof(_003CSetStartScale_003Ed__307))]
	private IEnumerator SetStartScale()
	{
		return null;
	}

	[Token(Token = "0x6009C50")]
	[Address(RVA = "0xE99F80", Offset = "0xE99180", VA = "0x180E99F80")]
	private void SetupCountGroup(CountMode mode, int maxCount)
	{
	}

	[Token(Token = "0x6009C51")]
	[Address(RVA = "0xE96B40", Offset = "0xE95D40", VA = "0x180E96B40")]
	public void SetCount(int remainNum)
	{
	}

	[Token(Token = "0x6009C52")]
	[Address(RVA = "0xE8DC90", Offset = "0xE8CE90", VA = "0x180E8DC90")]
	private void DestroyCountObjectList()
	{
	}

	[Token(Token = "0x6009C53")]
	[Address(RVA = "0xE99C50", Offset = "0xE98E50", VA = "0x180E99C50")]
	private void SetStarFadeEnable(bool enable, ListCardData data)
	{
	}

	[Token(Token = "0x6009C54")]
	[Address(RVA = "0xE9AB10", Offset = "0xE99D10", VA = "0x180E9AB10")]
	public void ShowDiscardRemain(int remain)
	{
	}

	[Token(Token = "0x6009C55")]
	[Address(RVA = "0xE99C40", Offset = "0xE98E40", VA = "0x180E99C40")]
	public void SetSortSkipFlag(bool enableSkip)
	{
	}

	[Token(Token = "0x6009C56")]
	[Address(RVA = "0xE9A5F0", Offset = "0xE997F0", VA = "0x180E9A5F0")]
	private void SetupDiscardMethod(bool dispDiscard, int remain)
	{
	}

	[Token(Token = "0x6009C57")]
	[Address(RVA = "0xE99640", Offset = "0xE98840", VA = "0x180E99640")]
	public void SetRemain(int remainNum)
	{
	}

	[Token(Token = "0x6009C58")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
	public void OnItemEntry(GameObject gob, int dataindex)
	{
	}

	[Token(Token = "0x6009C59")]
	[Address(RVA = "0xE94930", Offset = "0xE93B30", VA = "0x180E94930", Slot = "6")]
	public void OnItemExit(GameObject gob, int dataindex)
	{
	}

	[Token(Token = "0x6009C5A")]
	[Address(RVA = "0xE9CA30", Offset = "0xE9BC30", VA = "0x180E9CA30")]
	private void Update()
	{
	}

	[Token(Token = "0x6009C5B")]
	[Address(RVA = "0xE94010", Offset = "0xE93210", VA = "0x180E94010")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6009C5C")]
	[Address(RVA = "0xE9CDA0", Offset = "0xE9BFA0", VA = "0x180E9CDA0")]
	public CardSelectionList()
	{
	}
}
