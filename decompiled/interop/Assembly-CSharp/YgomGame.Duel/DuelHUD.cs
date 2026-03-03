using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using YgomGame.Settings;
using YgomSystem.ElementSystem;
using YgomSystem.UI;

namespace YgomGame.Duel;

[Token(Token = "0x2001896")]
public class DuelHUD : MonoBehaviour
{
	[Token(Token = "0x2001898")]
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass138_0
	{
		[Token(Token = "0x400E6ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public DuelHUD _003C_003E4__this;

		[Token(Token = "0x400E6EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform cardInfoParent;

		[Token(Token = "0x400E6EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool ismobilelayout;

		[Token(Token = "0x400E6F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public UnityAction _003C_003E9__17;

		[Token(Token = "0x400E6F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public UnityAction _003C_003E9__18;

		[Token(Token = "0x6009E4C")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public _003C_003Ec__DisplayClass138_0()
		{
		}

		[Token(Token = "0x6009E4D")]
		[Address(RVA = "0xECEF50", Offset = "0xECE150", VA = "0x180ECEF50")]
		internal void _003CInitializeProcess_003Eb__0()
		{
		}

		[Token(Token = "0x6009E4E")]
		[Address(RVA = "0xECF5D0", Offset = "0xECE7D0", VA = "0x180ECF5D0")]
		internal void _003CInitializeProcess_003Eb__1(DuelClient.ActivateConfirmMode mode)
		{
		}

		[Token(Token = "0x6009E4F")]
		[Address(RVA = "0xECF600", Offset = "0xECE800", VA = "0x180ECF600")]
		internal void _003CInitializeProcess_003Eb__2()
		{
		}

		[Token(Token = "0x6009E50")]
		[Address(RVA = "0xECF700", Offset = "0xECE900", VA = "0x180ECF700")]
		internal void _003CInitializeProcess_003Eb__3()
		{
		}

		[Token(Token = "0x6009E51")]
		[Address(RVA = "0xECF800", Offset = "0xECEA00", VA = "0x180ECF800")]
		internal void _003CInitializeProcess_003Eb__4(GameObject cardinfoprefab)
		{
		}

		[Token(Token = "0x6009E52")]
		[Address(RVA = "0xECFAA0", Offset = "0xECECA0", VA = "0x180ECFAA0")]
		internal void _003CInitializeProcess_003Eb__5(FullScreenUiBg instance)
		{
		}

		[Token(Token = "0x6009E53")]
		[Address(RVA = "0xECFAF0", Offset = "0xECECF0", VA = "0x180ECFAF0")]
		internal void _003CInitializeProcess_003Eb__6(int cardid, int premid)
		{
		}

		[Token(Token = "0x6009E54")]
		[Address(RVA = "0xECFB60", Offset = "0xECED60", VA = "0x180ECFB60")]
		internal void _003CInitializeProcess_003Eb__7(DeckBrowserForDuel instance)
		{
		}

		[Token(Token = "0x6009E55")]
		[Address(RVA = "0xECF360", Offset = "0xECE560", VA = "0x180ECF360")]
		internal void _003CInitializeProcess_003Eb__17()
		{
		}

		[Token(Token = "0x6009E56")]
		[Address(RVA = "0xECFD20", Offset = "0xECEF20", VA = "0x180ECFD20")]
		internal void _003CInitializeProcess_003Eb__8(CardInfoDetailForDuel instance)
		{
		}

		[Token(Token = "0x6009E57")]
		[Address(RVA = "0xECFD50", Offset = "0xECEF50", VA = "0x180ECFD50")]
		internal void _003CInitializeProcess_003Eb__9(GenericCardListController instance)
		{
		}

		[Token(Token = "0x6009E58")]
		[Address(RVA = "0xECEF90", Offset = "0xECE190", VA = "0x180ECEF90")]
		internal void _003CInitializeProcess_003Eb__10(int cardid)
		{
		}

		[Token(Token = "0x6009E59")]
		[Address(RVA = "0xECF010", Offset = "0xECE210", VA = "0x180ECF010")]
		internal void _003CInitializeProcess_003Eb__11(GenericCardListEx instance)
		{
		}

		[Token(Token = "0x6009E5A")]
		[Address(RVA = "0xECF480", Offset = "0xECE680", VA = "0x180ECF480")]
		internal void _003CInitializeProcess_003Eb__18()
		{
		}

		[Token(Token = "0x6009E5B")]
		[Address(RVA = "0xECF210", Offset = "0xECE410", VA = "0x180ECF210")]
		internal void _003CInitializeProcess_003Eb__12(AutoCloseToggle instance)
		{
		}

		[Token(Token = "0x6009E5C")]
		[Address(RVA = "0xECF280", Offset = "0xECE480", VA = "0x180ECF280")]
		internal void _003CInitializeProcess_003Eb__13(CpuThinkingIcon instance)
		{
		}

		[Token(Token = "0x6009E5D")]
		[Address(RVA = "0xECF2B0", Offset = "0xECE4B0", VA = "0x180ECF2B0")]
		internal void _003CInitializeProcess_003Eb__14(CardSelectionList instance)
		{
		}

		[Token(Token = "0x6009E5E")]
		[Address(RVA = "0xECF2E0", Offset = "0xECE4E0", VA = "0x180ECF2E0")]
		internal void _003CInitializeProcess_003Eb__15(PhaseSelectWindow instance)
		{
		}

		[Token(Token = "0x6009E5F")]
		[Address(RVA = "0xECF310", Offset = "0xECE510", VA = "0x180ECF310")]
		internal void _003CInitializeProcess_003Eb__16(ManaSetManager res)
		{
		}
	}

	[Token(Token = "0x200189A")]
	[CompilerGenerated]
	private sealed class _003CInitializeProcess_003Ed__138 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400E6F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400E6F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400E6F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public DuelHUD _003C_003E4__this;

		[Token(Token = "0x400E6F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private _003C_003Ec__DisplayClass138_0 _003C_003E8__1;

		[Token(Token = "0x400E6F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Transform _003Chigh_003E5__2;

		[Token(Token = "0x400E6F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Transform _003Cmiddle_003E5__3;

		[Token(Token = "0x400E6FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Transform _003CcardInfoDetailParent_003E5__4;

		[Token(Token = "0x400E6FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Transform _003CphaseWindowRoot_003E5__5;

		[Token(Token = "0x1700181B")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6009E66")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700181C")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6009E68")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6009E63")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CInitializeProcess_003Ed__138(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6009E64")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6009E65")]
		[Address(RVA = "0xECB820", Offset = "0xECAA20", VA = "0x180ECB820", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6009E67")]
		[Address(RVA = "0xECDC90", Offset = "0xECCE90", VA = "0x180ECDC90", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x200189B")]
	[CompilerGenerated]
	private sealed class _003CPrepareToDuelProcess_003Ed__161 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400E6FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400E6FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400E6FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public DuelHUD _003C_003E4__this;

		[Token(Token = "0x400E6FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Transform _003Chigh_003E5__2;

		[Token(Token = "0x1700181D")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6009E6C")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700181E")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6009E6E")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6009E69")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CPrepareToDuelProcess_003Ed__161(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6009E6A")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6009E6B")]
		[Address(RVA = "0xECDCD0", Offset = "0xECCED0", VA = "0x180ECDCD0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6009E6D")]
		[Address(RVA = "0xECED50", Offset = "0xECDF50", VA = "0x180ECED50", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x400E6A1")]
	private const string SE_DUEL_SELECT = "SE_DUEL_SELECT";

	[Token(Token = "0x400E6A2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private GameObject prefabUI;

	[Token(Token = "0x400E6A3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private GameObject handStatusLabelSrc;

	[Token(Token = "0x400E6A4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	private GameObject placeStatusLabelSrc;

	[Token(Token = "0x400E6A5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[SerializeField]
	private GameObject placeStatusLabelRootSrc;

	[Token(Token = "0x400E6A6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[SerializeField]
	private UnityEngine.Object screenFadeSrc;

	[Token(Token = "0x400E6A7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private ElementObjectManager ui;

	[Token(Token = "0x400E6A9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private DamageFrame damageFrame;

	[Token(Token = "0x400E6AA")]
	private const int LATENCY_THRESHOLD = 127;

	[Token(Token = "0x400E6AB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private ElementObjectManager m_ButtonRootEom;

	[Token(Token = "0x400E6AC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private GameObject buttonRoot1;

	[Token(Token = "0x400E6AD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private GameObject buttonRoot2;

	[Token(Token = "0x400E6AE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private GameObject buttonRoot3;

	[Token(Token = "0x400E6AF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private GameObject buttonRoot4;

	[Token(Token = "0x400E6B2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private ReplayControl replayCtrl;

	[Token(Token = "0x400E6B7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	private GameObject buttonDuelMenu;

	[Token(Token = "0x400E6B9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	private AudienceInfo audienceInfo;

	[Token(Token = "0x400E6BA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	private ElementObjectManager logButton;

	[Token(Token = "0x400E6BB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	private GameObject duelLogOnIcon;

	[Token(Token = "0x400E6BC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	private GameObject duelLogOffIcon;

	[Token(Token = "0x400E6BD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	private ElementObjectManager attachedEffectButton;

	[Token(Token = "0x400E6BE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	private TextMeshProUGUI attachedEffectNumText;

	[Token(Token = "0x400E6BF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
	private GameObject attachedEffectBadge;

	[Token(Token = "0x400E6C0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
	private GameObject attachedEffectOnIcon;

	[Token(Token = "0x400E6C1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
	private GameObject attachedEffectOffIcon;

	[Token(Token = "0x400E6C2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
	private int attachedEffectNum;

	[Token(Token = "0x400E6C3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
	private SelectionButton cancelButton;

	[Token(Token = "0x400E6C4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
	private Action onClickCancelButton;

	[Token(Token = "0x400E6C5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
	private SelectionButton decisionButton;

	[Token(Token = "0x400E6C6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
	private Action onClickDecisionButton;

	[Token(Token = "0x400E6C7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
	private GameObject phaseButtonIcon;

	[Token(Token = "0x400E6C8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
	private ElementObjectManager cheatDetailButtonEom;

	[Token(Token = "0x400E6C9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
	private RawImage cheatCardTex;

	[Token(Token = "0x400E6D8")]
	private const string KEY_WATCH = "w";

	[Token(Token = "0x400E6D9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C8")]
	private bool duelEnd;

	[Token(Token = "0x400E6DA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1D0")]
	private Coroutine initializeCoroutine;

	[Token(Token = "0x400E6DB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1D8")]
	private Coroutine prepareToDuelCoroutine;

	[Token(Token = "0x400E6DC")]
	private const string DuelOptionsFileName = "DuelOptions";

	[Token(Token = "0x400E6DD")]
	private const string KEY_CARD_SELECTIONLIST_LAYOUT = "CardSelectionListLayout";

	[Token(Token = "0x400E6DE")]
	private const string KEY_GENERIC_CARDLIST_LAYOUT = "GenericCardListLayout";

	[Token(Token = "0x400E6DF")]
	private const string KEY_AUDIENCE_GENERIC_CARDLIST_LAYOUT = "AudienceGenericCardListLayout";

	[Token(Token = "0x400E6E0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1E0")]
	private Dictionary<string, object> duelOptionsDict;

	[Token(Token = "0x170017F9")]
	public GameObject root
	{
		[Token(Token = "0x6009DAB")]
		[Address(RVA = "0x580700", Offset = "0x57F900", VA = "0x180580700")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6009DAC")]
		[Address(RVA = "0x580760", Offset = "0x57F960", VA = "0x180580760")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x170017FA")]
	public DuelClient host
	{
		[Token(Token = "0x6009DAD")]
		[Address(RVA = "0x49BEA0", Offset = "0x49B0A0", VA = "0x18049BEA0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6009DAE")]
		[Address(RVA = "0x457410", Offset = "0x456610", VA = "0x180457410")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x170017FB")]
	public ActivateConfirmToggle activateToggle
	{
		[Token(Token = "0x6009DAF")]
		[Address(RVA = "0x49BDC0", Offset = "0x49AFC0", VA = "0x18049BDC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6009DB0")]
		[Address(RVA = "0x4989A0", Offset = "0x497BA0", VA = "0x1804989A0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x170017FC")]
	public DuelStatusViewer statusViewer
	{
		[Token(Token = "0x6009DB1")]
		[Address(RVA = "0x49B7D0", Offset = "0x49A9D0", VA = "0x18049B7D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6009DB2")]
		[Address(RVA = "0x42FF10", Offset = "0x42F110", VA = "0x18042FF10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x170017FD")]
	public DuelCursorJump cursorJump
	{
		[Token(Token = "0x6009DB3")]
		[Address(RVA = "0x49BDF0", Offset = "0x49AFF0", VA = "0x18049BDF0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6009DB4")]
		[Address(RVA = "0x42FF30", Offset = "0x42F130", VA = "0x18042FF30")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x170017FE")]
	public PlaceStatusManager placeStatus
	{
		[Token(Token = "0x6009DB5")]
		[Address(RVA = "0x49BB20", Offset = "0x49AD20", VA = "0x18049BB20")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6009DB6")]
		[Address(RVA = "0x42FF50", Offset = "0x42F150", VA = "0x18042FF50")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x170017FF")]
	public ManaSetManager manaSetManager
	{
		[Token(Token = "0x6009DB7")]
		[Address(RVA = "0x49B7C0", Offset = "0x49A9C0", VA = "0x18049B7C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6009DB8")]
		[Address(RVA = "0x42FF70", Offset = "0x42F170", VA = "0x18042FF70")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x17001800")]
	public bool isShowingSettingMenu
	{
		[Token(Token = "0x6009DB9")]
		[Address(RVA = "0xEB3670", Offset = "0xEB2870", VA = "0x180EB3670")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6009DBA")]
		[Address(RVA = "0xEB3730", Offset = "0xEB2930", VA = "0x180EB3730")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17001801")]
	public bool isCancelButtonActivated
	{
		[Token(Token = "0x6009DBB")]
		[Address(RVA = "0xEB3610", Offset = "0xEB2810", VA = "0x180EB3610")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17001802")]
	public bool isDecisionButtonActivated
	{
		[Token(Token = "0x6009DBC")]
		[Address(RVA = "0xEB3620", Offset = "0xEB2820", VA = "0x180EB3620")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17001803")]
	public CardInfo cardInfoL
	{
		[Token(Token = "0x6009DBD")]
		[Address(RVA = "0x4C15C0", Offset = "0x4C07C0", VA = "0x1804C15C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6009DBE")]
		[Address(RVA = "0x4C19D0", Offset = "0x4C0BD0", VA = "0x1804C19D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17001804")]
	public CardInfo cardInfoR
	{
		[Token(Token = "0x6009DBF")]
		[Address(RVA = "0xEB35D0", Offset = "0xEB27D0", VA = "0x180EB35D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6009DC0")]
		[Address(RVA = "0xEB36D0", Offset = "0xEB28D0", VA = "0x180EB36D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17001805")]
	public CardReportTelopManager cardReportTelopManager
	{
		[Token(Token = "0x6009DC1")]
		[Address(RVA = "0x49BCF0", Offset = "0x49AEF0", VA = "0x18049BCF0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6009DC2")]
		[Address(RVA = "0x49C3D0", Offset = "0x49B5D0", VA = "0x18049C3D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17001806")]
	public DuelLogController duellog
	{
		[Token(Token = "0x6009DC3")]
		[Address(RVA = "0x49BCE0", Offset = "0x49AEE0", VA = "0x18049BCE0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6009DC4")]
		[Address(RVA = "0x49C3B0", Offset = "0x49B5B0", VA = "0x18049C3B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17001807")]
	public AttachedEffectListController attachedEffectList
	{
		[Token(Token = "0x6009DC5")]
		[Address(RVA = "0xEB35C0", Offset = "0xEB27C0", VA = "0x180EB35C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6009DC6")]
		[Address(RVA = "0xEB2820", Offset = "0xEB1A20", VA = "0x180EB2820")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17001808")]
	public GenericCardListController genericCardList
	{
		[Token(Token = "0x6009DC7")]
		[Address(RVA = "0xEB3600", Offset = "0xEB2800", VA = "0x180EB3600")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6009DC8")]
		[Address(RVA = "0xEB36F0", Offset = "0xEB28F0", VA = "0x180EB36F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17001809")]
	public GenericCardListEx relativeCardList
	{
		[Token(Token = "0x6009DC9")]
		[Address(RVA = "0xEB36C0", Offset = "0xEB28C0", VA = "0x180EB36C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6009DCA")]
		[Address(RVA = "0xEB3760", Offset = "0xEB2960", VA = "0x180EB3760")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x1700180A")]
	public CardInfoDetailForDuel cardInfoDetail
	{
		[Token(Token = "0x6009DCB")]
		[Address(RVA = "0xAE41E0", Offset = "0xAE33E0", VA = "0x180AE41E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6009DCC")]
		[Address(RVA = "0xAE4560", Offset = "0xAE3760", VA = "0x180AE4560")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x1700180B")]
	public CpuThinkingIcon cpuThinkingIcon
	{
		[Token(Token = "0x6009DCD")]
		[Address(RVA = "0xAE41F0", Offset = "0xAE33F0", VA = "0x180AE41F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6009DCE")]
		[Address(RVA = "0xA91060", Offset = "0xA90260", VA = "0x180A91060")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x1700180C")]
	public CardSelectionList cardSelectionList
	{
		[Token(Token = "0x6009DCF")]
		[Address(RVA = "0xAE41D0", Offset = "0xAE33D0", VA = "0x180AE41D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6009DD0")]
		[Address(RVA = "0xA91080", Offset = "0xA90280", VA = "0x180A91080")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x1700180D")]
	public PhaseSelectWindow phaseWindow
	{
		[Token(Token = "0x6009DD1")]
		[Address(RVA = "0xD0CAE0", Offset = "0xD0BCE0", VA = "0x180D0CAE0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6009DD2")]
		[Address(RVA = "0xA910A0", Offset = "0xA902A0", VA = "0x180A910A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x1700180E")]
	public FullScreenUiBg fullScreenUiBg
	{
		[Token(Token = "0x6009DD3")]
		[Address(RVA = "0xA8F0E0", Offset = "0xA8E2E0", VA = "0x180A8F0E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6009DD4")]
		[Address(RVA = "0xA8F910", Offset = "0xA8EB10", VA = "0x180A8F910")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x1700180F")]
	public DeckBrowserForDuel deckBrowser
	{
		[Token(Token = "0x6009DD5")]
		[Address(RVA = "0x49BEC0", Offset = "0x49B0C0", VA = "0x18049BEC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6009DD6")]
		[Address(RVA = "0x49C5B0", Offset = "0x49B7B0", VA = "0x18049C5B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17001810")]
	public AutoCloseToggle autoCloseToggle
	{
		[Token(Token = "0x6009DD7")]
		[Address(RVA = "0xAE4200", Offset = "0xAE3400", VA = "0x180AE4200")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6009DD8")]
		[Address(RVA = "0xAE4580", Offset = "0xAE3780", VA = "0x180AE4580")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17001811")]
	public bool duelOver
	{
		[Token(Token = "0x6009DD9")]
		[Address(RVA = "0xEB35E0", Offset = "0xEB27E0", VA = "0x180EB35E0")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17001812")]
	public bool isInitialized
	{
		[Token(Token = "0x6009DE1")]
		[Address(RVA = "0xEB3630", Offset = "0xEB2830", VA = "0x180EB3630")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6009DE2")]
		[Address(RVA = "0xEB3710", Offset = "0xEB2910", VA = "0x180EB3710")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17001813")]
	public bool isTerminated
	{
		[Token(Token = "0x6009DE4")]
		[Address(RVA = "0xEB3680", Offset = "0xEB2880", VA = "0x180EB3680")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6009DE5")]
		[Address(RVA = "0xEB3740", Offset = "0xEB2940", VA = "0x180EB3740")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17001814")]
	public bool isTerminating
	{
		[Token(Token = "0x6009DE6")]
		[Address(RVA = "0xEB3690", Offset = "0xEB2890", VA = "0x180EB3690")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6009DE7")]
		[Address(RVA = "0xEB3750", Offset = "0xEB2950", VA = "0x180EB3750")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17001815")]
	public bool isPrepared
	{
		[Token(Token = "0x6009DE8")]
		[Address(RVA = "0xEB3640", Offset = "0xEB2840", VA = "0x180EB3640")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6009DE9")]
		[Address(RVA = "0xEB3720", Offset = "0xEB2920", VA = "0x180EB3720")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17001816")]
	private GameObject bgFade
	{
		[Token(Token = "0x6009DF0")]
		[Address(RVA = "0x49BF40", Offset = "0x49B140", VA = "0x18049BF40")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6009DF1")]
		[Address(RVA = "0x49C690", Offset = "0x49B890", VA = "0x18049C690")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x17001817")]
	public DuelLP nearLPCounter
	{
		[Token(Token = "0x6009DF2")]
		[Address(RVA = "0x49BCD0", Offset = "0x49AED0", VA = "0x18049BCD0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6009DF3")]
		[Address(RVA = "0x49C390", Offset = "0x49B590", VA = "0x18049C390")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17001818")]
	public DuelLP farLPCounter
	{
		[Token(Token = "0x6009DF4")]
		[Address(RVA = "0x49BF10", Offset = "0x49B110", VA = "0x18049BF10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6009DF5")]
		[Address(RVA = "0x49C640", Offset = "0x49B840", VA = "0x18049C640")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17001819")]
	public bool isReplayPause
	{
		[Token(Token = "0x6009DF6")]
		[Address(RVA = "0xEB3650", Offset = "0xEB2850", VA = "0x180EB3650")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700181A")]
	public bool isVisibleAllPlaceStatusLabel
	{
		[Token(Token = "0x6009DFE")]
		[Address(RVA = "0xEB36A0", Offset = "0xEB28A0", VA = "0x180EB36A0")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6009DDA")]
	[Address(RVA = "0xEB2F30", Offset = "0xEB2130", VA = "0x180EB2F30")]
	private void Update()
	{
	}

	[Token(Token = "0x6009DDB")]
	[Address(RVA = "0xEADE50", Offset = "0xEAD050", VA = "0x180EADE50")]
	public void Initialize(DuelClient host)
	{
	}

	[Token(Token = "0x6009DDC")]
	[Address(RVA = "0xEADDE0", Offset = "0xEACFE0", VA = "0x180EADDE0")]
	[IteratorStateMachine(typeof(_003CInitializeProcess_003Ed__138))]
	private IEnumerator InitializeProcess()
	{
		return null;
	}

	[Token(Token = "0x6009DDD")]
	[Address(RVA = "0xEB1160", Offset = "0xEB0360", VA = "0x180EB1160")]
	private void SetupSettingMenu()
	{
	}

	[Token(Token = "0x6009DDE")]
	[Address(RVA = "0xEAF340", Offset = "0xEAE540", VA = "0x180EAF340")]
	private void OpenSettingMenu()
	{
	}

	[Token(Token = "0x6009DDF")]
	[Address(RVA = "0xEB31C0", Offset = "0xEB23C0", VA = "0x180EB31C0")]
	private bool UseDeckConfirm()
	{
		return default(bool);
	}

	[Token(Token = "0x6009DE0")]
	[Address(RVA = "0xEACD00", Offset = "0xEABF00", VA = "0x180EACD00")]
	private void DeckConfirm()
	{
	}

	[Token(Token = "0x6009DE3")]
	[Address(RVA = "0xEB1370", Offset = "0xEB0570", VA = "0x180EB1370")]
	public void Terminate()
	{
	}

	[Token(Token = "0x6009DEA")]
	[Address(RVA = "0xEB0090", Offset = "0xEAF290", VA = "0x180EB0090")]
	public void PrepareToDuel()
	{
	}

	[Token(Token = "0x6009DEB")]
	[Address(RVA = "0xEB0020", Offset = "0xEAF220", VA = "0x180EB0020")]
	[IteratorStateMachine(typeof(_003CPrepareToDuelProcess_003Ed__161))]
	private IEnumerator PrepareToDuelProcess()
	{
		return null;
	}

	[Token(Token = "0x6009DEC")]
	[Address(RVA = "0xEADAC0", Offset = "0xEACCC0", VA = "0x180EADAC0")]
	public void DuelStart()
	{
	}

	[Token(Token = "0x6009DED")]
	[Address(RVA = "0xEAD2C0", Offset = "0xEAC4C0", VA = "0x180EAD2C0")]
	public void DuelEnd()
	{
	}

	[Token(Token = "0x6009DEE")]
	[Address(RVA = "0xEADC30", Offset = "0xEACE30", VA = "0x180EADC30")]
	public void HideButtons()
	{
	}

	[Token(Token = "0x6009DEF")]
	[Address(RVA = "0xEAC960", Offset = "0xEABB60", VA = "0x180EAC960")]
	public void CloseDialog()
	{
	}

	[Token(Token = "0x6009DF7")]
	[Address(RVA = "0xEB0D00", Offset = "0xEAFF00", VA = "0x180EB0D00")]
	public void SetLP(SharedDefinition.Location side, int lp)
	{
	}

	[Token(Token = "0x6009DF8")]
	[Address(RVA = "0xEAC4C0", Offset = "0xEAB6C0", VA = "0x180EAC4C0")]
	public void ChangeLP(SharedDefinition.Location side, int afterLP, int damage, Engine.DamageType type, [Optional] Action onFinished)
	{
	}

	[Token(Token = "0x6009DF9")]
	[Address(RVA = "0xEB0C80", Offset = "0xEAFE80", VA = "0x180EB0C80")]
	public void SetDisp(bool disp)
	{
	}

	[Token(Token = "0x6009DFA")]
	[Address(RVA = "0xEB1280", Offset = "0xEB0480", VA = "0x180EB1280")]
	public void ShowAllCardStatusLabel()
	{
	}

	[Token(Token = "0x6009DFB")]
	[Address(RVA = "0xEADB90", Offset = "0xEACD90", VA = "0x180EADB90")]
	public void HideAllCardStatusLabel()
	{
	}

	[Token(Token = "0x6009DFC")]
	[Address(RVA = "0xEB3410", Offset = "0xEB2610", VA = "0x180EB3410")]
	public PlaceStatusLabel UsePlaceStatusLabel(SharedDefinition.Location location, bool lieDown, bool hand)
	{
		return null;
	}

	[Token(Token = "0x6009DFD")]
	[Address(RVA = "0xEB29F0", Offset = "0xEB1BF0", VA = "0x180EB29F0")]
	public void UnusePlaceStatusLabel(PlaceStatusLabel instance)
	{
	}

	[Token(Token = "0x6009DFF")]
	[Address(RVA = "0xEB12E0", Offset = "0xEB04E0", VA = "0x180EB12E0")]
	public void ShowAllPlaceStatusLabel()
	{
	}

	[Token(Token = "0x6009E00")]
	[Address(RVA = "0xEADBF0", Offset = "0xEACDF0", VA = "0x180EADBF0")]
	public void HideAllPlaceStatusLabel()
	{
	}

	[Token(Token = "0x6009E01")]
	[Address(RVA = "0xEB1320", Offset = "0xEB0520", VA = "0x180EB1320")]
	public void ShowDamageFrame()
	{
	}

	[Token(Token = "0x6009E02")]
	[Address(RVA = "0xEB0650", Offset = "0xEAF850", VA = "0x180EB0650")]
	public void SetBgColor(Color color)
	{
	}

	[Token(Token = "0x6009E03")]
	[Address(RVA = "0xEB3780", Offset = "0xEB2980", VA = "0x180EB3780")]
	private void updateNetworkStatus()
	{
	}

	[Token(Token = "0x6009E04")]
	[Address(RVA = "0xEB2BC0", Offset = "0xEB1DC0", VA = "0x180EB2BC0")]
	private void UpdateActivateToggle(SettingsUtil.DuelParam.MANUAL_TYPE type, bool customUseSwitch)
	{
	}

	[Token(Token = "0x6009E05")]
	[Address(RVA = "0xEB2A30", Offset = "0xEB1C30", VA = "0x180EB2A30")]
	public void UpdateActivateToggleOnTurnEnd()
	{
	}

	[Token(Token = "0x6009E06")]
	[Address(RVA = "0xEAE9E0", Offset = "0xEADBE0", VA = "0x180EAE9E0")]
	public void OnClickReplayStop()
	{
	}

	[Token(Token = "0x6009E07")]
	[Address(RVA = "0xEAE960", Offset = "0xEADB60", VA = "0x180EAE960")]
	private void OnClickReplayFast()
	{
	}

	[Token(Token = "0x6009E08")]
	[Address(RVA = "0xEAE460", Offset = "0xEAD660", VA = "0x180EAE460")]
	public void OnChangeWatcherNum(int num)
	{
	}

	[Token(Token = "0x6009E09")]
	[Address(RVA = "0xEB2CF0", Offset = "0xEB1EF0", VA = "0x180EB2CF0")]
	private void UpdateWatcherNum()
	{
	}

	[Token(Token = "0x6009E0A")]
	[Address(RVA = "0xEAE7D0", Offset = "0xEAD9D0", VA = "0x180EAE7D0")]
	private void OnClickDuelLogButton()
	{
	}

	[Token(Token = "0x6009E0B")]
	[Address(RVA = "0xEAF1F0", Offset = "0xEAE3F0", VA = "0x180EAF1F0")]
	public void OpenDuelLog()
	{
	}

	[Token(Token = "0x6009E0C")]
	[Address(RVA = "0xEACAA0", Offset = "0xEABCA0", VA = "0x180EACAA0")]
	public void CloseDuelLog(bool forMobile)
	{
	}

	[Token(Token = "0x6009E0D")]
	[Address(RVA = "0xEAE3C0", Offset = "0xEAD5C0", VA = "0x180EAE3C0")]
	private void OnChangeDuelLogOpenClose(bool isOpen)
	{
	}

	[Token(Token = "0x6009E0E")]
	[Address(RVA = "0xEAE3C0", Offset = "0xEAD5C0", VA = "0x180EAE3C0")]
	private void SetDuelLogButtonStatus(bool isOpen)
	{
	}

	[Token(Token = "0x6009E0F")]
	[Address(RVA = "0xEAE370", Offset = "0xEAD570", VA = "0x180EAE370")]
	private void OnChangeAttachedEffectOpenClose(bool isOpen)
	{
	}

	[Token(Token = "0x6009E10")]
	[Address(RVA = "0xEAE370", Offset = "0xEAD570", VA = "0x180EAE370")]
	private void SetAttachedEffectStatus(bool isOpen)
	{
	}

	[Token(Token = "0x6009E11")]
	[Address(RVA = "0xEAE530", Offset = "0xEAD730", VA = "0x180EAE530")]
	private void OnClickAttachedEffectButton()
	{
	}

	[Token(Token = "0x6009E12")]
	[Address(RVA = "0xEAEA00", Offset = "0xEADC00", VA = "0x180EAEA00")]
	public void OpenAttachedEffectList()
	{
	}

	[Token(Token = "0x6009E13")]
	[Address(RVA = "0xEAC5C0", Offset = "0xEAB7C0", VA = "0x180EAC5C0")]
	public void CloseAttachedEffectList()
	{
	}

	[Token(Token = "0x6009E14")]
	[Address(RVA = "0xEB0420", Offset = "0xEAF620", VA = "0x180EB0420")]
	public void SetAttachedEffectNum(int num)
	{
	}

	[Token(Token = "0x6009E15")]
	[Address(RVA = "0xEB0E60", Offset = "0xEB0060", VA = "0x180EB0E60")]
	private void SetupCardinfoL(CardInfo instance, Transform parent, bool ismobilelayout, bool onCreated = true)
	{
	}

	[Token(Token = "0x6009E16")]
	[Address(RVA = "0xEB0FB0", Offset = "0xEB01B0", VA = "0x180EB0FB0")]
	private void SetupCardinfoR(CardInfo instance, bool onCreated = true)
	{
	}

	[Token(Token = "0x6009E17")]
	[Address(RVA = "0xEAC700", Offset = "0xEAB900", VA = "0x180EAC700")]
	public void CloseCardInfoDetail()
	{
	}

	[Token(Token = "0x6009E18")]
	[Address(RVA = "0xEAC8C0", Offset = "0xEABAC0", VA = "0x180EAC8C0")]
	public void CloseDeckBrowser()
	{
	}

	[Token(Token = "0x6009E19")]
	[Address(RVA = "0xEACBD0", Offset = "0xEABDD0", VA = "0x180EACBD0")]
	public void CloseRelativeCardList()
	{
	}

	[Token(Token = "0x6009E1A")]
	[Address(RVA = "0x62E000", Offset = "0x62D200", VA = "0x18062E000")]
	public void SetOnClickCancelButtonCallback(Action callback)
	{
	}

	[Token(Token = "0x6009E1B")]
	[Address(RVA = "0xEB0850", Offset = "0xEAFA50", VA = "0x180EB0850")]
	public void SetDispCancelButton(bool disp)
	{
	}

	[Token(Token = "0x6009E1C")]
	[Address(RVA = "0xEAC1E0", Offset = "0xEAB3E0", VA = "0x180EAC1E0")]
	public void ActivateCancelButton(Action clickCallback)
	{
	}

	[Token(Token = "0x6009E1D")]
	[Address(RVA = "0xEACC80", Offset = "0xEABE80", VA = "0x180EACC80")]
	public void DeactivateCancelButton()
	{
	}

	[Token(Token = "0x6009E1E")]
	[Address(RVA = "0x7ACDE0", Offset = "0x7ABFE0", VA = "0x1807ACDE0")]
	public void SetOnClickDecisionButtonCallback(Action callback)
	{
	}

	[Token(Token = "0x6009E1F")]
	[Address(RVA = "0xEB0A20", Offset = "0xEAFC20", VA = "0x180EB0A20")]
	public void SetDispDecisionButton(bool disp)
	{
	}

	[Token(Token = "0x6009E20")]
	[Address(RVA = "0xEAC220", Offset = "0xEAB420", VA = "0x180EAC220")]
	public void ActivateDecisionButton(Action clickCallback)
	{
	}

	[Token(Token = "0x6009E21")]
	[Address(RVA = "0xEACCC0", Offset = "0xEABEC0", VA = "0x180EACCC0")]
	public void DeactivateDecisionButton()
	{
	}

	[Token(Token = "0x6009E22")]
	[Address(RVA = "0xEAECF0", Offset = "0xEADEF0", VA = "0x180EAECF0")]
	public void OpenCardInfo(int team, int position, int index, bool isLeft = true, bool lockDisp = true, bool force = true, bool miniDisp = true, bool setTargetTopCardIndex = false)
	{
	}

	[Token(Token = "0x6009E23")]
	[Address(RVA = "0xEAEC40", Offset = "0xEADE40", VA = "0x180EAEC40")]
	public void OpenCardInfo(bool isLeft = true)
	{
	}

	[Token(Token = "0x6009E24")]
	[Address(RVA = "0xEAEB50", Offset = "0xEADD50", VA = "0x180EAEB50")]
	public void OpenCardInfoByUniqueID(int uniqueID, bool isLeft = true, bool lockDisp = true, bool showToHappenHighlight = false, int highlightRfxTableIndex = -1)
	{
	}

	[Token(Token = "0x6009E25")]
	[Address(RVA = "0xEAC260", Offset = "0xEAB460", VA = "0x180EAC260")]
	public void AutoClose()
	{
	}

	[Token(Token = "0x6009E26")]
	[Address(RVA = "0xEAC840", Offset = "0xEABA40", VA = "0x180EAC840")]
	public void CloseCardInfo(bool isLeft = true)
	{
	}

	[Token(Token = "0x6009E27")]
	[Address(RVA = "0xEAC7B0", Offset = "0xEAB9B0", VA = "0x180EAC7B0")]
	public void CloseCardInfoMini(bool isLeft = true)
	{
	}

	[Token(Token = "0x6009E28")]
	[Address(RVA = "0xEB0700", Offset = "0xEAF900", VA = "0x180EB0700")]
	public void SetCardInfoMiniPos(CardInfo.ShowPos miniPos, bool isLeft = true)
	{
	}

	[Token(Token = "0x6009E29")]
	[Address(RVA = "0xEB0D50", Offset = "0xEAFF50", VA = "0x180EB0D50")]
	public void SetPhaseButtonIconPosition(Vector3 worldPosition)
	{
	}

	[Token(Token = "0x6009E2A")]
	[Address(RVA = "0xEB0BF0", Offset = "0xEAFDF0", VA = "0x180EB0BF0")]
	public void SetDispPhaseButtonIcon(bool disp)
	{
	}

	[Token(Token = "0x6009E2B")]
	[Address(RVA = "0xEB3070", Offset = "0xEB2270", VA = "0x180EB3070")]
	public void UseCheatDetailButtonIcon(bool use, int cardID)
	{
	}

	[Token(Token = "0x6009E2C")]
	[Address(RVA = "0xEB0790", Offset = "0xEAF990", VA = "0x180EB0790")]
	protected void SetCard(int cardID)
	{
	}

	[Token(Token = "0x6009E2D")]
	[Address(RVA = "0xEB0230", Offset = "0xEAF430", VA = "0x180EB0230")]
	public void SetActivateShortcutIcon(bool activate, bool isCursorJump = false)
	{
	}

	[Token(Token = "0x6009E2E")]
	[Address(RVA = "0xEB0160", Offset = "0xEAF360", VA = "0x180EB0160")]
	private void SaveDuelOptions()
	{
	}

	[Token(Token = "0x6009E2F")]
	[Address(RVA = "0xEADF70", Offset = "0xEAD170", VA = "0x180EADF70")]
	private void LoadDuelOptions()
	{
	}

	[Token(Token = "0x6009E30")]
	[Address(RVA = "0xEB3460", Offset = "0xEB2660", VA = "0x180EB3460")]
	public DuelHUD()
	{
	}
}
