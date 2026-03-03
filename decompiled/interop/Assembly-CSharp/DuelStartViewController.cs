using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using YgomGame.Coin;
using YgomGame.Duel;
using YgomGame.Menu;
using YgomSystem.ElementSystem;
using YgomSystem.Network;
using YgomSystem.UI;

[Token(Token = "0x2000067")]
public class DuelStartViewController : BaseMenuViewController
{
	[Token(Token = "0x2000068")]
	protected enum Step
	{
		[Token(Token = "0x40001F7")]
		START,
		[Token(Token = "0x40001F8")]
		INIT,
		[Token(Token = "0x40001F9")]
		WAIT_DUELRESOURCEDONE,
		[Token(Token = "0x40001FA")]
		WAIT_INIT,
		[Token(Token = "0x40001FB")]
		PLAYER_APPEAR,
		[Token(Token = "0x40001FC")]
		WAIT_PLAYER_APPEAR,
		[Token(Token = "0x40001FD")]
		COIN_TOSS,
		[Token(Token = "0x40001FE")]
		WAIT_COIN_TOSS,
		[Token(Token = "0x40001FF")]
		SELECT_TURN,
		[Token(Token = "0x4000200")]
		WAIT_SELECT_TURN,
		[Token(Token = "0x4000201")]
		DISP_SELECTED,
		[Token(Token = "0x4000202")]
		DUEL_BEGIN,
		[Token(Token = "0x4000203")]
		WAIT_FINAL,
		[Token(Token = "0x4000204")]
		END,
		[Token(Token = "0x4000205")]
		ERROR
	}

	[Token(Token = "0x2000069")]
	internal class PlayerSet
	{
		[Token(Token = "0x4000206")]
		[FieldOffset(Offset = "0x10")]
		private readonly string IMG_ICON_LABEL;

		[Token(Token = "0x4000207")]
		[FieldOffset(Offset = "0x18")]
		private readonly string IMG_RANK_LABEL;

		[Token(Token = "0x4000208")]
		[FieldOffset(Offset = "0x20")]
		private readonly string IMG_LINE_LABEL;

		[Token(Token = "0x4000209")]
		[FieldOffset(Offset = "0x28")]
		private readonly string IMG_DLV_LABEL;

		[Token(Token = "0x400020A")]
		[FieldOffset(Offset = "0x30")]
		private readonly string IMG_RATEGROUP_LABEL;

		[Token(Token = "0x400020B")]
		[FieldOffset(Offset = "0x38")]
		private readonly string IMG_TOPGROUP_LABEL;

		[Token(Token = "0x400020C")]
		[FieldOffset(Offset = "0x40")]
		private readonly string PLATFORM_NAME_LABEL;

		[Token(Token = "0x400020D")]
		[FieldOffset(Offset = "0x48")]
		private readonly string PLATFORM_ICON_LABEL;

		[Token(Token = "0x400020E")]
		[FieldOffset(Offset = "0x50")]
		private readonly string ROOT_RANKUP_LABEL;

		[Token(Token = "0x400020F")]
		[FieldOffset(Offset = "0x58")]
		private readonly string TXT_RANKUP_LABEL;

		[Token(Token = "0x4000210")]
		[FieldOffset(Offset = "0x60")]
		private readonly string ROOT_RANKDOWN_LABEL;

		[Token(Token = "0x4000211")]
		[FieldOffset(Offset = "0x68")]
		private readonly string TXT_RANKDOWN_LABEL;

		[Token(Token = "0x4000212")]
		[FieldOffset(Offset = "0x70")]
		private readonly string ROOT_RANK_LABEL;

		[Token(Token = "0x4000213")]
		[FieldOffset(Offset = "0x78")]
		private readonly string ROOT_PROFILE_LABEL;

		[Token(Token = "0x4000214")]
		[FieldOffset(Offset = "0x80")]
		private readonly string DECK_CASE_LABEL;

		[Token(Token = "0x4000215")]
		[FieldOffset(Offset = "0x88")]
		private readonly string TXT_RATE_LABEL;

		[Token(Token = "0x4000216")]
		[FieldOffset(Offset = "0x90")]
		private readonly string TXT_TOP_LABEL;

		[Token(Token = "0x4000217")]
		[FieldOffset(Offset = "0x98")]
		private readonly GameObject root;

		[Token(Token = "0x4000218")]
		[FieldOffset(Offset = "0xA0")]
		private readonly bool isPlayer;

		[Token(Token = "0x4000219")]
		[FieldOffset(Offset = "0xA1")]
		internal bool isLoading;

		[Token(Token = "0x400021A")]
		[FieldOffset(Offset = "0xA8")]
		internal Character2D chara;

		[Token(Token = "0x400021B")]
		[FieldOffset(Offset = "0xB0")]
		internal bool canChoice;

		[Token(Token = "0x400021C")]
		[FieldOffset(Offset = "0xB4")]
		internal int myid;

		[Token(Token = "0x400021D")]
		[FieldOffset(Offset = "0xB8")]
		internal Util.PlatformID platformID;

		[Token(Token = "0x60001DE")]
		[Address(RVA = "0x3F3FD0", Offset = "0x3F31D0", VA = "0x1803F3FD0")]
		internal PlayerSet(GameObject root, bool isPlayer)
		{
		}

		[Token(Token = "0x60001DF")]
		[Address(RVA = "0x3F2980", Offset = "0x3F1B80", VA = "0x1803F2980")]
		internal bool Initialize()
		{
			return default(bool);
		}
	}

	[Token(Token = "0x200006E")]
	[CompilerGenerated]
	private sealed class _003CStart_003Ed__91 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400022E")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400022F")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4000230")]
		[FieldOffset(Offset = "0x20")]
		public DuelStartViewController _003C_003E4__this;

		[Token(Token = "0x17000022")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x60001F5")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000023")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60001F7")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001F2")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CStart_003Ed__91(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x60001F3")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x60001F4")]
		[Address(RVA = "0x3FBF70", Offset = "0x3FB170", VA = "0x1803FBF70", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60001F6")]
		[Address(RVA = "0x3FC000", Offset = "0x3FB200", VA = "0x1803FC000", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x200006F")]
	[CompilerGenerated]
	private sealed class _003CyInit_003Ed__89 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000231")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4000232")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4000233")]
		[FieldOffset(Offset = "0x20")]
		public DuelStartViewController _003C_003E4__this;

		[Token(Token = "0x17000024")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x60001FB")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000025")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60001FD")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001F8")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CyInit_003Ed__89(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x60001F9")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x60001FA")]
		[Address(RVA = "0x3FDB10", Offset = "0x3FCD10", VA = "0x1803FDB10", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60001FC")]
		[Address(RVA = "0x3FDE90", Offset = "0x3FD090", VA = "0x1803FDE90", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x2000070")]
	[CompilerGenerated]
	private sealed class _003CyWait_003Ed__90 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000234")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4000235")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4000236")]
		[FieldOffset(Offset = "0x20")]
		public DuelStartViewController _003C_003E4__this;

		[Token(Token = "0x4000237")]
		[FieldOffset(Offset = "0x28")]
		private IEnumerator _003CieWaitMatching_003E5__2;

		[Token(Token = "0x17000026")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6000201")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000027")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6000203")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001FE")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CyWait_003Ed__90(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x60001FF")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6000200")]
		[Address(RVA = "0x400C80", Offset = "0x3FFE80", VA = "0x180400C80", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000202")]
		[Address(RVA = "0x401010", Offset = "0x400210", VA = "0x180401010", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x40001C6")]
	[FieldOffset(Offset = "0x0")]
	public static readonly string PrefabPath;

	[Token(Token = "0x40001C7")]
	[FieldOffset(Offset = "0xD0")]
	private readonly string ROOT_PLAYER_LABEL;

	[Token(Token = "0x40001C8")]
	[FieldOffset(Offset = "0xD8")]
	private readonly string ROOT_RIVAL_LABEL;

	[Token(Token = "0x40001C9")]
	[FieldOffset(Offset = "0xE0")]
	private readonly string ROOT_CAN_CHOICE_LABEL;

	[Token(Token = "0x40001CA")]
	[FieldOffset(Offset = "0xE8")]
	private readonly string ROOT_CANT_CHOICE_LABEL;

	[Token(Token = "0x40001CB")]
	[FieldOffset(Offset = "0xF0")]
	private readonly string ROOT_VS_LABEL;

	[Token(Token = "0x40001CC")]
	[FieldOffset(Offset = "0xF8")]
	private readonly string ROOT_RESULT_COINTOSS_LABEL;

	[Token(Token = "0x40001CD")]
	[FieldOffset(Offset = "0x100")]
	private readonly string TXT_TIME_LABEL;

	[Token(Token = "0x40001CE")]
	[FieldOffset(Offset = "0x108")]
	private readonly string TXT_LABEL;

	[Token(Token = "0x40001CF")]
	[FieldOffset(Offset = "0x110")]
	private readonly string SC_SKIP_LABEL;

	[Token(Token = "0x40001D0")]
	[FieldOffset(Offset = "0x118")]
	private readonly string BTN_FIRST_LABEL;

	[Token(Token = "0x40001D1")]
	[FieldOffset(Offset = "0x120")]
	private readonly string BTN_SECOND_LABEL;

	[Token(Token = "0x40001D2")]
	[FieldOffset(Offset = "0x128")]
	private readonly string BTN_BACKKEYSHORTCUT_LABEL;

	[Token(Token = "0x40001D3")]
	[FieldOffset(Offset = "0x130")]
	private readonly string TIME_COUNT_PATH;

	[Token(Token = "0x40001D4")]
	[FieldOffset(Offset = "0x138")]
	private readonly string COINTOSS_HEAD;

	[Token(Token = "0x40001D5")]
	[FieldOffset(Offset = "0x140")]
	private readonly string COINTOSS_TAIL;

	[Token(Token = "0x40001D6")]
	[FieldOffset(Offset = "0x148")]
	private readonly string coinTossTimeLinePath;

	[Token(Token = "0x40001D7")]
	[FieldOffset(Offset = "0x150")]
	private readonly string tlLabel_CoinHeadsOrTails;

	[Token(Token = "0x40001D8")]
	[FieldOffset(Offset = "0x158")]
	private readonly string tlLabel_FlashCoin;

	[Token(Token = "0x40001D9")]
	[FieldOffset(Offset = "0x160")]
	protected bool m_bInit;

	[Token(Token = "0x40001DA")]
	[FieldOffset(Offset = "0x161")]
	private bool m_bStartDuel;

	[Token(Token = "0x40001DB")]
	[FieldOffset(Offset = "0x168")]
	private Dictionary<string, object> m_DuelParam;

	[Token(Token = "0x40001DC")]
	[FieldOffset(Offset = "0x170")]
	private string m_LastBgmLabel;

	[Token(Token = "0x40001DD")]
	[FieldOffset(Offset = "0x178")]
	private DuelStartWaitingBase m_DSWaitingComponent;

	[Token(Token = "0x40001DE")]
	[FieldOffset(Offset = "0x180")]
	private Handle m_Handle;

	[Token(Token = "0x40001DF")]
	[FieldOffset(Offset = "0x188")]
	private IEnumerator m_SelectWaitCoroutine;

	[Token(Token = "0x40001E0")]
	[FieldOffset(Offset = "0x190")]
	private bool canChoice;

	[Token(Token = "0x40001E1")]
	[FieldOffset(Offset = "0x198")]
	private GameObject rootPlayer;

	[Token(Token = "0x40001E2")]
	[FieldOffset(Offset = "0x1A0")]
	private GameObject rootRival;

	[Token(Token = "0x40001E3")]
	[FieldOffset(Offset = "0x1A8")]
	private GameObject rootCanChoice;

	[Token(Token = "0x40001E4")]
	[FieldOffset(Offset = "0x1B0")]
	private GameObject rootCantChoice;

	[Token(Token = "0x40001E5")]
	[FieldOffset(Offset = "0x1B8")]
	protected GameObject rootVS;

	[Token(Token = "0x40001E6")]
	[FieldOffset(Offset = "0x1C0")]
	private GameObject duelStartResultCointoss;

	[Token(Token = "0x40001E7")]
	[FieldOffset(Offset = "0x1C8")]
	private PlayerSet player;

	[Token(Token = "0x40001E8")]
	[FieldOffset(Offset = "0x1D0")]
	private PlayerSet rival;

	[Token(Token = "0x40001E9")]
	[FieldOffset(Offset = "0x1D8")]
	private string m_PreloadedCoinPath;

	[Token(Token = "0x40001EA")]
	[FieldOffset(Offset = "0x1E0")]
	private string m_LoadedCoinTossTexturePath;

	[Token(Token = "0x40001EB")]
	[FieldOffset(Offset = "0x1E8")]
	private Sprite m_TargetSprite;

	[Token(Token = "0x40001EC")]
	[FieldOffset(Offset = "0x1F0")]
	private int coinId;

	[Token(Token = "0x40001ED")]
	[FieldOffset(Offset = "0x1F8")]
	private CoinSettings coinSettings;

	[Token(Token = "0x40001EE")]
	[FieldOffset(Offset = "0x200")]
	private Material materialCoinhighlight;

	[Token(Token = "0x40001EF")]
	[FieldOffset(Offset = "0x208")]
	private Material materialCoinStar;

	[Token(Token = "0x40001F0")]
	[FieldOffset(Offset = "0x210")]
	private Material materialCoin01;

	[Token(Token = "0x40001F1")]
	[FieldOffset(Offset = "0x218")]
	protected Step m_Step;

	[Token(Token = "0x40001F2")]
	[FieldOffset(Offset = "0x21C")]
	private bool isLoadedTexture;

	[Token(Token = "0x40001F3")]
	[FieldOffset(Offset = "0x21D")]
	private bool isCoinEffectLoaded;

	[Token(Token = "0x40001F4")]
	[FieldOffset(Offset = "0x21E")]
	private bool isCoinEffectLoaded2;

	[Token(Token = "0x40001F5")]
	[FieldOffset(Offset = "0x21F")]
	private bool isCoinEffectLoaded3;

	[Token(Token = "0x1700001E")]
	public string loadedCoinTossTexturePath
	{
		[Token(Token = "0x60001AC")]
		[Address(RVA = "0x3F2280", Offset = "0x3F1480", VA = "0x1803F2280")]
		get
		{
			return null;
		}
		[Token(Token = "0x60001AD")]
		[Address(RVA = "0x3F2450", Offset = "0x3F1650", VA = "0x1803F2450")]
		protected set
		{
		}
	}

	[Token(Token = "0x1700001F")]
	public Sprite targetTexture
	{
		[Token(Token = "0x60001AE")]
		[Address(RVA = "0x3F22A0", Offset = "0x3F14A0", VA = "0x1803F22A0")]
		get
		{
			return null;
		}
		[Token(Token = "0x60001AF")]
		[Address(RVA = "0x3F2480", Offset = "0x3F1680", VA = "0x1803F2480")]
		protected set
		{
		}
	}

	[Token(Token = "0x17000020")]
	protected override Type[] textIds
	{
		[Token(Token = "0x60001B0")]
		[Address(RVA = "0x3F22B0", Offset = "0x3F14B0", VA = "0x1803F22B0", Slot = "21")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000021")]
	protected Step step
	{
		[Token(Token = "0x60001B1")]
		[Address(RVA = "0x3F2290", Offset = "0x3F1490", VA = "0x1803F2290")]
		get
		{
			return default(Step);
		}
		[Token(Token = "0x60001B2")]
		[Address(RVA = "0x3F2470", Offset = "0x3F1670", VA = "0x1803F2470")]
		set
		{
		}
	}

	[Token(Token = "0x60001B3")]
	[Address(RVA = "0x3EF620", Offset = "0x3EE820", VA = "0x1803EF620", Slot = "6")]
	public override void NotificationStackEntry()
	{
	}

	[Token(Token = "0x60001B4")]
	[Address(RVA = "0x3EF4E0", Offset = "0x3EE6E0", VA = "0x1803EF4E0", Slot = "28")]
	protected virtual void InitTimeLine()
	{
	}

	[Token(Token = "0x60001B5")]
	[Address(RVA = "0x3EF6C0", Offset = "0x3EE8C0", VA = "0x1803EF6C0", Slot = "7")]
	public override void NotificationStackRemove()
	{
	}

	[Token(Token = "0x60001B6")]
	[Address(RVA = "0x3EF8B0", Offset = "0x3EEAB0", VA = "0x1803EF8B0", Slot = "23")]
	protected override void OnCreatedView()
	{
	}

	[Token(Token = "0x60001B7")]
	[Address(RVA = "0x3EFD60", Offset = "0x3EEF60", VA = "0x1803EFD60", Slot = "10")]
	public override void ProgressUpdate()
	{
	}

	[Token(Token = "0x60001B8")]
	[Address(RVA = "0x3F19E0", Offset = "0x3F0BE0", VA = "0x1803F19E0")]
	public void Update()
	{
	}

	[Token(Token = "0x60001B9")]
	[Address(RVA = "0x3EEB10", Offset = "0x3EDD10", VA = "0x1803EEB10")]
	private void EvalEachSteps()
	{
	}

	[Token(Token = "0x60001BA")]
	[Address(RVA = "0x3F0080", Offset = "0x3EF280", VA = "0x1803F0080")]
	private bool SetPvPConnection()
	{
		return default(bool);
	}

	[Token(Token = "0x60001BB")]
	[Address(RVA = "0x3EF510", Offset = "0x3EE710", VA = "0x1803EF510", Slot = "29")]
	protected virtual void Init()
	{
	}

	[Token(Token = "0x60001BC")]
	[Address(RVA = "0x3F19F0", Offset = "0x3F0BF0", VA = "0x1803F19F0")]
	private void WaitDuelResourceDone()
	{
	}

	[Token(Token = "0x60001BD")]
	[Address(RVA = "0x3EF520", Offset = "0x3EE720", VA = "0x1803EF520")]
	private bool LoadPlayers()
	{
		return default(bool);
	}

	[Token(Token = "0x60001BE")]
	[Address(RVA = "0x3F1CE0", Offset = "0x3F0EE0", VA = "0x1803F1CE0", Slot = "30")]
	protected virtual void WaitInit()
	{
	}

	[Token(Token = "0x60001BF")]
	[Address(RVA = "0x3EFC50", Offset = "0x3EEE50", VA = "0x1803EFC50")]
	private void PlayerAppear()
	{
	}

	[Token(Token = "0x60001C0")]
	[Address(RVA = "0x3EE430", Offset = "0x3ED630", VA = "0x1803EE430", Slot = "31")]
	protected virtual void ControllVSImage()
	{
	}

	[Token(Token = "0x60001C1")]
	[Address(RVA = "0x3F1D30", Offset = "0x3F0F30", VA = "0x1803F1D30", Slot = "32")]
	protected virtual void WaitPlayerAppear()
	{
	}

	[Token(Token = "0x60001C2")]
	[Address(RVA = "0x3EDF50", Offset = "0x3ED150", VA = "0x1803EDF50")]
	private void CoinToss()
	{
	}

	[Token(Token = "0x60001C3")]
	[Address(RVA = "0x3F0150", Offset = "0x3EF350", VA = "0x1803F0150")]
	private void SetupMeshRender(GameObject target, bool isHead)
	{
	}

	[Token(Token = "0x60001C4")]
	[Address(RVA = "0x3F03C0", Offset = "0x3EF5C0", VA = "0x1803F03C0")]
	private void SetupParticleMaterial(ElementObjectManager eom, int coinid)
	{
	}

	[Token(Token = "0x60001C5")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60")]
	private void WaitCoinToss()
	{
	}

	[Token(Token = "0x60001C6")]
	[Address(RVA = "0x3EFD80", Offset = "0x3EEF80", VA = "0x1803EFD80", Slot = "33")]
	protected virtual void SelectTurn()
	{
	}

	[Token(Token = "0x60001C7")]
	[Address(RVA = "0x3F0F90", Offset = "0x3F0190", VA = "0x1803F0F90")]
	private void TimeCountNotificator(object mes)
	{
	}

	[Token(Token = "0x60001C8")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60")]
	private void WaitSelectTurn()
	{
	}

	[Token(Token = "0x60001C9")]
	[Address(RVA = "0x3EE4B0", Offset = "0x3ED6B0", VA = "0x1803EE4B0")]
	private void DispSelected()
	{
	}

	[Token(Token = "0x60001CA")]
	[Address(RVA = "0x3EE880", Offset = "0x3EDA80", VA = "0x1803EE880", Slot = "34")]
	protected virtual void DuelBegin()
	{
	}

	[Token(Token = "0x60001CB")]
	[Address(RVA = "0x3F1B90", Offset = "0x3F0D90", VA = "0x1803F1B90")]
	private void WaitFinal()
	{
	}

	[Token(Token = "0x60001CC")]
	[Address(RVA = "0x3F0720", Offset = "0x3EF920", VA = "0x1803F0720", Slot = "35")]
	protected virtual void StartDuel()
	{
	}

	[Token(Token = "0x60001CD")]
	[Address(RVA = "0x3EDD50", Offset = "0x3ECF50", VA = "0x1803EDD50", Slot = "36")]
	protected virtual void CauseError()
	{
	}

	[Token(Token = "0x60001CE")]
	[Address(RVA = "0x3EF010", Offset = "0x3EE210", VA = "0x1803EF010")]
	public Color FadeColor(TransitionType type)
	{
		return default(Color);
	}

	[Token(Token = "0x60001CF")]
	[Address(RVA = "0x3EF020", Offset = "0x3EE220", VA = "0x1803EF020")]
	public SystemProgress.ProgressType FadeType(TransitionType type)
	{
		return default(SystemProgress.ProgressType);
	}

	[Token(Token = "0x60001D0")]
	[Address(RVA = "0x3F24A0", Offset = "0x3F16A0", VA = "0x1803F24A0", Slot = "37")]
	[IteratorStateMachine(typeof(_003CyInit_003Ed__89))]
	protected virtual IEnumerator yInit()
	{
		return null;
	}

	[Token(Token = "0x60001D1")]
	[Address(RVA = "0x3F2510", Offset = "0x3F1710", VA = "0x1803F2510")]
	[IteratorStateMachine(typeof(_003CyWait_003Ed__90))]
	private IEnumerator yWait()
	{
		return null;
	}

	[Token(Token = "0x60001D2")]
	[Address(RVA = "0x3F0900", Offset = "0x3EFB00", VA = "0x1803F0900")]
	[IteratorStateMachine(typeof(_003CStart_003Ed__91))]
	private IEnumerator Start()
	{
		return null;
	}

	[Token(Token = "0x60001D3")]
	[Address(RVA = "0x3EF280", Offset = "0x3EE480", VA = "0x1803EF280")]
	private string GetMyCoinPath()
	{
		return null;
	}

	[Token(Token = "0x60001D4")]
	[Address(RVA = "0x3EF030", Offset = "0x3EE230", VA = "0x1803EF030")]
	private string GetCoinId()
	{
		return null;
	}

	[Token(Token = "0x60001D5")]
	[Address(RVA = "0x3F1EB0", Offset = "0x3F10B0", VA = "0x1803F1EB0")]
	public DuelStartViewController()
	{
	}
}
