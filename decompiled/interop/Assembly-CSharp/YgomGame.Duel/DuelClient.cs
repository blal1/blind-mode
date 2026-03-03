using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AOT;
using Il2CppDummyDll;
using UnityEngine;
using YgomGame.Bg;
using YgomGame.Menu;
using YgomSystem.Network;
using YgomSystem.Timeline;
using YgomSystem.UI;

namespace YgomGame.Duel;

[Token(Token = "0x200175C")]
public class DuelClient : ViewController, IFadeSupported
{
	[Token(Token = "0x200175D")]
	public delegate void EffectHandler(int param1, int param2, int param3);

	[Token(Token = "0x200175E")]
	public enum GUIPriority
	{
		[Token(Token = "0x400DC72")]
		Low,
		[Token(Token = "0x400DC73")]
		Middle,
		[Token(Token = "0x400DC74")]
		High,
		[Token(Token = "0x400DC75")]
		CountDown,
		[Token(Token = "0x400DC76")]
		Command,
		[Token(Token = "0x400DC77")]
		DuelLog,
		[Token(Token = "0x400DC78")]
		ProfileCard,
		[Token(Token = "0x400DC79")]
		InstantMessage,
		[Token(Token = "0x400DC7A")]
		CardReportTelop,
		[Token(Token = "0x400DC7B")]
		FadePlane,
		[Token(Token = "0x400DC7C")]
		PhaseWindow,
		[Token(Token = "0x400DC7D")]
		CardInfoDetail,
		[Token(Token = "0x400DC7E")]
		CardInfo,
		[Token(Token = "0x400DC7F")]
		MessageDialog,
		[Token(Token = "0x400DC80")]
		TutorialNavigatorTop,
		[Token(Token = "0x400DC81")]
		TutorialNavigatorCenter
	}

	[Token(Token = "0x200175F")]
	public enum DuelSpeed
	{
		[Token(Token = "0x400DC83")]
		Normal,
		[Token(Token = "0x400DC84")]
		Fastest
	}

	[Token(Token = "0x2001760")]
	public enum ActivateConfirmMode
	{
		[Token(Token = "0x400DC86")]
		Default,
		[Token(Token = "0x400DC87")]
		Off,
		[Token(Token = "0x400DC88")]
		On
	}

	[Token(Token = "0x2001761")]
	public enum FocusCardSituation
	{
		[Token(Token = "0x400DC8A")]
		TYPICAL,
		[Token(Token = "0x400DC8B")]
		TYPICAL_FIX,
		[Token(Token = "0x400DC8C")]
		CARD_MOVE,
		[Token(Token = "0x400DC8D")]
		TARGET_SELECT,
		[Token(Token = "0x400DC8E")]
		IGNORE_RESET_ONCE
	}

	[Token(Token = "0x2001762")]
	public delegate void onShowAffectDelegate(int player, int position, int index);

	[Token(Token = "0x2001763")]
	public delegate void onHideAffectDelegate();

	[Token(Token = "0x2001764")]
	public delegate void onTapDownFieldDelegate(int team, int position, int viewIndex);

	[Token(Token = "0x2001765")]
	public delegate void onTapUpFieldDelegate(int team, int position, int viewIndex);

	[Token(Token = "0x2001766")]
	public delegate void onTapEnterFieldDelegate(int team, int position, int viewIndex);

	[Token(Token = "0x2001767")]
	public delegate void onTapExitFieldDelegate(int team, int position, int viewIndex);

	[Token(Token = "0x2001768")]
	public delegate void onCursorEnterFieldDelegate(int team, int position, int viewIndex);

	[Token(Token = "0x2001769")]
	public delegate void onCursorExitFieldDelegate(int team, int position, int viewIndex);

	[Token(Token = "0x200176A")]
	public delegate void onSelectFieldDelegate(int team, int position, int viewIndex);

	[Token(Token = "0x200176B")]
	public delegate void onDeselectFieldDelegate(int team, int position, int viewIndex);

	[Token(Token = "0x200176C")]
	public delegate void onFocusFieldDelegate(int team, int position, int viewIndex);

	[Token(Token = "0x200176D")]
	public delegate void onUnfocusFieldDelegate(int team, int position, int viewIndex);

	[Token(Token = "0x200176E")]
	public delegate void onDecideFieldDelegate(int team, int position, int viewIndex);

	[Token(Token = "0x200176F")]
	public delegate void onDoubleClickFieldDelegate(int team, int position, int viewIndex);

	[Token(Token = "0x2001770")]
	public delegate void onDragFieldBeginDelegate(int team, int position, int viewIndex, Vector2 screenPoint);

	[Token(Token = "0x2001771")]
	public delegate void onDragFieldDelegate(int team, int position, int viewIndex, Vector2 screenPoint);

	[Token(Token = "0x2001772")]
	public delegate void onDragFieldEndDelegate(int team, int position, int viewIndex, Vector2 screenPoint);

	[Token(Token = "0x2001773")]
	public delegate void onHoldFieldBeginDelegate(int team, int position, int viewIndex, Vector2 screenPoint);

	[Token(Token = "0x2001774")]
	public delegate void onDecideAttackTargetDelegate(int attackerPlayer, int attackerPosition, int attackerIndex, int targetPlayer, int targetPosition, int targetIndex);

	[Token(Token = "0x2001775")]
	public delegate void onFieldViewChangedDelegate(bool fieldViewing);

	[Token(Token = "0x2001776")]
	public delegate void onChangeActivateConfirmMode(ActivateConfirmMode mode);

	[Token(Token = "0x2001777")]
	public delegate void onChangeDetailShowing(bool showing);

	[Token(Token = "0x2001778")]
	public delegate void onFieldBackKey();

	[Token(Token = "0x2001779")]
	public delegate void onPlayScreenEffect();

	[Token(Token = "0x200177A")]
	public delegate void onStopScreenEffect();

	[Token(Token = "0x200177B")]
	private enum Step
	{
		[Token(Token = "0x400DC90")]
		InitLoadRes = 0,
		[Token(Token = "0x400DC91")]
		WaitLoadRes = 1,
		[Token(Token = "0x400DC92")]
		InitializeProcess = 2,
		[Token(Token = "0x400DC93")]
		FinishInitialize = 3,
		[Token(Token = "0x400DC94")]
		WaitConnecting = 4,
		[Token(Token = "0x400DC95")]
		InitEngine = 5,
		[Token(Token = "0x400DC96")]
		InitSound = 6,
		[Token(Token = "0x400DC97")]
		WaitSound = 7,
		[Token(Token = "0x400DC98")]
		InitLoadSound = 8,
		[Token(Token = "0x400DC99")]
		WaitLoadSound = 9,
		[Token(Token = "0x400DC9A")]
		WaitGameObjectInit = 10,
		[Token(Token = "0x400DC9B")]
		PrepareProcess = 11,
		[Token(Token = "0x400DC9C")]
		FinishPrepare = 12,
		[Token(Token = "0x400DC9D")]
		WaitCameraWork = 13,
		[Token(Token = "0x400DC9E")]
		ShowUpDuel = 14,
		[Token(Token = "0x400DC9F")]
		WaitShowUp = 15,
		[Token(Token = "0x400DCA0")]
		ExecDuel = 16,
		[Token(Token = "0x400DCA1")]
		EndDuel = 17,
		[Token(Token = "0x400DCA2")]
		WaitEndNetwork = 18,
		[Token(Token = "0x400DCA3")]
		DuelEnd = 19,
		[Token(Token = "0x400DCA4")]
		InitTerm = 20,
		[Token(Token = "0x400DCA5")]
		WaitEndViewClose = 21,
		[Token(Token = "0x400DCA6")]
		WaitTerm = 22,
		[Token(Token = "0x400DCA7")]
		End = 23,
		[Token(Token = "0x400DCA8")]
		WaitDestroy = 24,
		[Token(Token = "0x400DCA9")]
		ConnectingError = 25,
		[Token(Token = "0x400DCAA")]
		Beginning = 26,
		[Token(Token = "0x400DCAB")]
		InitSequenceStart = 0,
		[Token(Token = "0x400DCAC")]
		InitSequenceEnd = 12
	}

	[Token(Token = "0x200177C")]
	private enum InitStep
	{
		[Token(Token = "0x400DCAE")]
		Start,
		[Token(Token = "0x400DCAF")]
		InitTutorial,
		[Token(Token = "0x400DCB0")]
		WaitTutorial,
		[Token(Token = "0x400DCB1")]
		StartDuelHUD,
		[Token(Token = "0x400DCB2")]
		WaitDuelHUD,
		[Token(Token = "0x400DCB3")]
		StartEffectWorker,
		[Token(Token = "0x400DCB4")]
		AdoptiveGoManager,
		[Token(Token = "0x400DCB5")]
		Finish
	}

	[Token(Token = "0x200177D")]
	private enum PrepareStep
	{
		[Token(Token = "0x400DCB7")]
		Start,
		[Token(Token = "0x400DCB8")]
		StartDuelHUD,
		[Token(Token = "0x400DCB9")]
		WaitDuelHUD,
		[Token(Token = "0x400DCBA")]
		StartEffectWorker,
		[Token(Token = "0x400DCBB")]
		WaitEffectWorker,
		[Token(Token = "0x400DCBC")]
		StartTutorial,
		[Token(Token = "0x400DCBD")]
		WaitTutorial,
		[Token(Token = "0x400DCBE")]
		Finished
	}

	[Token(Token = "0x400DC1F")]
	[FieldOffset(Offset = "0x0")]
	private static DuelClient instance;

	[Token(Token = "0x400DC20")]
	[FieldOffset(Offset = "0x48")]
	private Dictionary<Engine.ViewType, EffectHandler> effectTable;

	[Token(Token = "0x400DC21")]
	[FieldOffset(Offset = "0x50")]
	private Dictionary<Engine.ViewType, EffectHandler> audienceReplayEffectTable;

	[Token(Token = "0x400DC26")]
	[FieldOffset(Offset = "0x78")]
	private bool isSetLastBgmLabel;

	[Token(Token = "0x400DC27")]
	[FieldOffset(Offset = "0x79")]
	private bool isPlatformChecker;

	[Token(Token = "0x400DC28")]
	[FieldOffset(Offset = "0x7C")]
	private DuelSpeed duelSpeed;

	[Token(Token = "0x400DC29")]
	[FieldOffset(Offset = "0x80")]
	private List<AbstractRunEffectWorker> workers;

	[Token(Token = "0x400DC2A")]
	[FieldOffset(Offset = "0x88")]
	private Dictionary<GUIPriority, GameObject> childRoots;

	[Token(Token = "0x400DC2B")]
	[FieldOffset(Offset = "0x90")]
	[SerializeField]
	private UnityEngine.Object duelHUDSrc;

	[Token(Token = "0x400DC2C")]
	[FieldOffset(Offset = "0x98")]
	private GameObject inputBlocker;

	[Token(Token = "0x400DC2D")]
	[FieldOffset(Offset = "0xA0")]
	private int inputBlockCounter;

	[Token(Token = "0x400DC2E")]
	[FieldOffset(Offset = "0xA4")]
	private int fieldInputBlockCounter;

	[Token(Token = "0x400DC2F")]
	[FieldOffset(Offset = "0xA8")]
	private InputBlockerFlexible fieldInputBlocker;

	[Token(Token = "0x400DC30")]
	[FieldOffset(Offset = "0xB0")]
	private string lastBgmLabel;

	[Token(Token = "0x400DC38")]
	[FieldOffset(Offset = "0xE4")]
	private int pvpErrorCount;

	[Token(Token = "0x400DC39")]
	[FieldOffset(Offset = "0xE8")]
	private bool pvpError;

	[Token(Token = "0x400DC3A")]
	[FieldOffset(Offset = "0xE9")]
	private bool pvpTimeout;

	[Token(Token = "0x400DC3C")]
	[FieldOffset(Offset = "0xEC")]
	private float replayTimeMargin;

	[Token(Token = "0x400DC3D")]
	[FieldOffset(Offset = "0xF0")]
	private bool replayRealtime;

	[Token(Token = "0x400DC57")]
	[FieldOffset(Offset = "0x1C0")]
	private bool quitReplay;

	[Token(Token = "0x400DC58")]
	[FieldOffset(Offset = "0x1C1")]
	private bool pauseReplay;

	[Token(Token = "0x400DC59")]
	[FieldOffset(Offset = "0x1C2")]
	private bool detailShowing;

	[Token(Token = "0x400DC5A")]
	[FieldOffset(Offset = "0x1C4")]
	private Step m_Step;

	[Token(Token = "0x400DC5B")]
	[FieldOffset(Offset = "0x1C8")]
	private InitStep initStep;

	[Token(Token = "0x400DC5C")]
	[FieldOffset(Offset = "0x1CC")]
	private PrepareStep prepareStep;

	[Token(Token = "0x400DC5D")]
	[FieldOffset(Offset = "0x1D0")]
	private Dictionary<string, object> dicResult;

	[Token(Token = "0x400DC5E")]
	[FieldOffset(Offset = "0x1D8")]
	private bool resultSending;

	[Token(Token = "0x400DC5F")]
	[FieldOffset(Offset = "0x1D9")]
	private bool resultSended;

	[Token(Token = "0x400DC60")]
	[FieldOffset(Offset = "0x1E0")]
	private ReplayStream replayStream;

	[Token(Token = "0x400DC61")]
	[FieldOffset(Offset = "0x1E8")]
	private RecordManager recordManager;

	[Token(Token = "0x400DC63")]
	[FieldOffset(Offset = "0x1F8")]
	private bool isEngineInitialized;

	[Token(Token = "0x400DC66")]
	[FieldOffset(Offset = "0x208")]
	private ulong did;

	[Token(Token = "0x400DC67")]
	[FieldOffset(Offset = "0x210")]
	private uint pcode0;

	[Token(Token = "0x400DC68")]
	[FieldOffset(Offset = "0x214")]
	private uint pcode1;

	[Token(Token = "0x400DC69")]
	private const int ExistWorkSize = 512;

	[Token(Token = "0x400DC6A")]
	[FieldOffset(Offset = "0x218")]
	private float networkTimeOutThrethold;

	[Token(Token = "0x400DC6B")]
	[FieldOffset(Offset = "0x21C")]
	private float networkTimeOutTimer;

	[Token(Token = "0x400DC6C")]
	private const int DEFAULT_TIMEOUT_TIME = 30;

	[Token(Token = "0x400DC6D")]
	[FieldOffset(Offset = "0x220")]
	private bool isAbend_s;

	[Token(Token = "0x400DC6E")]
	[FieldOffset(Offset = "0x221")]
	private bool isAbend_c;

	[Token(Token = "0x400DC6F")]
	[FieldOffset(Offset = "0x228")]
	private TimelineObject m_DuelEndTransTimeline;

	[Token(Token = "0x400DC70")]
	[FieldOffset(Offset = "0x230")]
	private bool isKicked;

	[Token(Token = "0x1700168B")]
	private List<Func<bool>> OnBackList
	{
		[Token(Token = "0x60092A1")]
		[Address(RVA = "0x589E50", Offset = "0x589050", VA = "0x180589E50")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x60092A2")]
		[Address(RVA = "0x589E60", Offset = "0x589060", VA = "0x180589E60")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x1700168C")]
	public EngineInitializer engineInitializer
	{
		[Token(Token = "0x60092A9")]
		[Address(RVA = "0x49BB10", Offset = "0x49AD10", VA = "0x18049BB10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x60092AA")]
		[Address(RVA = "0x3DAE90", Offset = "0x3DA090", VA = "0x1803DAE90")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Token(Token = "0x1700168D")]
	public DuelHUD duelHUD
	{
		[Token(Token = "0x60092AC")]
		[Address(RVA = "0x49BAD0", Offset = "0x49ACD0", VA = "0x18049BAD0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x60092AD")]
		[Address(RVA = "0x42FF90", Offset = "0x42F190", VA = "0x18042FF90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x1700168E")]
	public HandCardManager handCardManager
	{
		[Token(Token = "0x60092AF")]
		[Address(RVA = "0x5857B0", Offset = "0x5849B0", VA = "0x1805857B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x60092AE")]
		[Address(RVA = "0x42FFB0", Offset = "0x42F1B0", VA = "0x18042FFB0")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Token(Token = "0x1700168F")]
	public RunEffectWorker effectWorker
	{
		[Token(Token = "0x60092B0")]
		[Address(RVA = "0x5961F0", Offset = "0x5953F0", VA = "0x1805961F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x60092B1")]
		[Address(RVA = "0x662500", Offset = "0x661700", VA = "0x180662500")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17001690")]
	public static DuelCursor cursor
	{
		[Token(Token = "0x60092B2")]
		[Address(RVA = "0xDD2D10", Offset = "0xDD1F10", VA = "0x180DD2D10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x60092B3")]
		[Address(RVA = "0xDD4180", Offset = "0xDD3380", VA = "0x180DD4180")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17001691")]
	public ActivateConfirmMode activateConfirmMode
	{
		[Token(Token = "0x60092B4")]
		[Address(RVA = "0x746560", Offset = "0x745760", VA = "0x180746560")]
		[CompilerGenerated]
		get
		{
			return default(ActivateConfirmMode);
		}
		[Token(Token = "0x60092B5")]
		[Address(RVA = "0xA2A4F0", Offset = "0xA296F0", VA = "0x180A2A4F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17001692")]
	protected override int selectorPriorityAddRange
	{
		[Token(Token = "0x60092B6")]
		[Address(RVA = "0xDD2D70", Offset = "0xDD1F70", VA = "0x180DD2D70", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17001693")]
	public bool pvpProgress
	{
		[Token(Token = "0x60092CF")]
		[Address(RVA = "0xDD2D60", Offset = "0xDD1F60", VA = "0x180DD2D60")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60092D0")]
		[Address(RVA = "0xDD41F0", Offset = "0xDD33F0", VA = "0x180DD41F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17001694")]
	private Step step
	{
		[Token(Token = "0x600933E")]
		[Address(RVA = "0xDD2D80", Offset = "0xDD1F80", VA = "0x180DD2D80")]
		get
		{
			return default(Step);
		}
		[Token(Token = "0x600933F")]
		[Address(RVA = "0xDD4200", Offset = "0xDD3400", VA = "0x180DD4200")]
		set
		{
		}
	}

	[Token(Token = "0x17001695")]
	public DuelEndOperation duelEndOperation
	{
		[Token(Token = "0x6009340")]
		[Address(RVA = "0x49BF40", Offset = "0x49B140", VA = "0x18049BF40")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6009341")]
		[Address(RVA = "0x49C690", Offset = "0x49B890", VA = "0x18049C690")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x17001696")]
	public bool IsEngineInitialized
	{
		[Token(Token = "0x6009342")]
		[Address(RVA = "0xDD2CF0", Offset = "0xDD1EF0", VA = "0x180DD2CF0")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17001697")]
	public int chapterId
	{
		[Token(Token = "0x6009343")]
		[Address(RVA = "0xDD2D00", Offset = "0xDD1F00", VA = "0x180DD2D00")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6009344")]
		[Address(RVA = "0xDD4170", Offset = "0xDD3370", VA = "0x180DD4170")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17001698")]
	public bool isRentalDeck
	{
		[Token(Token = "0x6009345")]
		[Address(RVA = "0xDD2D50", Offset = "0xDD1F50", VA = "0x180DD2D50")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6009346")]
		[Address(RVA = "0xDD41E0", Offset = "0xDD33E0", VA = "0x180DD41E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17001699")]
	private float initProgress
	{
		[Token(Token = "0x6009347")]
		[Address(RVA = "0xDCEDC0", Offset = "0xDCDFC0", VA = "0x180DCEDC0")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x140000BD")]
	public event Action OnUpdate
	{
		[Token(Token = "0x600929F")]
		[Address(RVA = "0xDD1910", Offset = "0xDD0B10", VA = "0x180DD1910")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x60092A0")]
		[Address(RVA = "0xDD2D90", Offset = "0xDD1F90", VA = "0x180DD2D90")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x140000BE")]
	public event Action<Engine.ViewType, int, int, int> onPreRunEffect
	{
		[Token(Token = "0x60092A3")]
		[Address(RVA = "0xDD26C0", Offset = "0xDD18C0", VA = "0x180DD26C0")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x60092A4")]
		[Address(RVA = "0xDD3B40", Offset = "0xDD2D40", VA = "0x180DD3B40")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x140000BF")]
	public event Action<Engine.ViewType, int, int, int> onPostRunEffect
	{
		[Token(Token = "0x60092A5")]
		[Address(RVA = "0xDD2610", Offset = "0xDD1810", VA = "0x180DD2610")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x60092A6")]
		[Address(RVA = "0xDD3A90", Offset = "0xDD2C90", VA = "0x180DD3A90")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x140000C0")]
	public event Action onAudienceReplayFinished
	{
		[Token(Token = "0x60092A7")]
		[Address(RVA = "0xDD19B0", Offset = "0xDD0BB0", VA = "0x180DD19B0")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x60092A8")]
		[Address(RVA = "0xDD2E30", Offset = "0xDD2030", VA = "0x180DD2E30")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x140000C1")]
	public event onShowAffectDelegate onShowAffectHandler
	{
		[Token(Token = "0x60092DC")]
		[Address(RVA = "0xDD2820", Offset = "0xDD1A20", VA = "0x180DD2820")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x60092DD")]
		[Address(RVA = "0xDD3CA0", Offset = "0xDD2EA0", VA = "0x180DD3CA0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x140000C2")]
	public event onHideAffectDelegate onHideAffectHandler
	{
		[Token(Token = "0x60092DE")]
		[Address(RVA = "0xDD2400", Offset = "0xDD1600", VA = "0x180DD2400")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x60092DF")]
		[Address(RVA = "0xDD3880", Offset = "0xDD2A80", VA = "0x180DD3880")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x140000C3")]
	public event onTapDownFieldDelegate onTapDownFieldHandler
	{
		[Token(Token = "0x60092E0")]
		[Address(RVA = "0xDD2980", Offset = "0xDD1B80", VA = "0x180DD2980")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x60092E1")]
		[Address(RVA = "0xDD3E00", Offset = "0xDD3000", VA = "0x180DD3E00")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x140000C4")]
	public event onTapUpFieldDelegate onTapUpFieldHandler
	{
		[Token(Token = "0x60092E2")]
		[Address(RVA = "0xDD2B90", Offset = "0xDD1D90", VA = "0x180DD2B90")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x60092E3")]
		[Address(RVA = "0xDD4010", Offset = "0xDD3210", VA = "0x180DD4010")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x140000C5")]
	public event onTapEnterFieldDelegate onTapEnterFieldHandler
	{
		[Token(Token = "0x60092E4")]
		[Address(RVA = "0xDD2A30", Offset = "0xDD1C30", VA = "0x180DD2A30")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x60092E5")]
		[Address(RVA = "0xDD3EB0", Offset = "0xDD30B0", VA = "0x180DD3EB0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x140000C6")]
	public event onTapExitFieldDelegate onTapExitFieldHandler
	{
		[Token(Token = "0x60092E6")]
		[Address(RVA = "0xDD2AE0", Offset = "0xDD1CE0", VA = "0x180DD2AE0")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x60092E7")]
		[Address(RVA = "0xDD3F60", Offset = "0xDD3160", VA = "0x180DD3F60")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x140000C7")]
	public event onCursorEnterFieldDelegate onCursorEnterFieldHandler
	{
		[Token(Token = "0x60092E8")]
		[Address(RVA = "0xDD1BC0", Offset = "0xDD0DC0", VA = "0x180DD1BC0")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x60092E9")]
		[Address(RVA = "0xDD3040", Offset = "0xDD2240", VA = "0x180DD3040")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x140000C8")]
	public event onCursorExitFieldDelegate onCursorExitFieldHandler
	{
		[Token(Token = "0x60092EA")]
		[Address(RVA = "0xDD1C70", Offset = "0xDD0E70", VA = "0x180DD1C70")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x60092EB")]
		[Address(RVA = "0xDD30F0", Offset = "0xDD22F0", VA = "0x180DD30F0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x140000C9")]
	public event onSelectFieldDelegate onSelectFieldHandler
	{
		[Token(Token = "0x60092EC")]
		[Address(RVA = "0xDD2770", Offset = "0xDD1970", VA = "0x180DD2770")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x60092ED")]
		[Address(RVA = "0xDD3BF0", Offset = "0xDD2DF0", VA = "0x180DD3BF0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x140000CA")]
	public event onDeselectFieldDelegate onDeselectFieldHandler
	{
		[Token(Token = "0x60092EE")]
		[Address(RVA = "0xDD1E80", Offset = "0xDD1080", VA = "0x180DD1E80")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x60092EF")]
		[Address(RVA = "0xDD3300", Offset = "0xDD2500", VA = "0x180DD3300")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x140000CB")]
	public event onFocusFieldDelegate onFocusFieldHandler
	{
		[Token(Token = "0x60092F0")]
		[Address(RVA = "0xDD2350", Offset = "0xDD1550", VA = "0x180DD2350")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x60092F1")]
		[Address(RVA = "0xDD37D0", Offset = "0xDD29D0", VA = "0x180DD37D0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x140000CC")]
	public event onUnfocusFieldDelegate onUnfocusFieldHandler
	{
		[Token(Token = "0x60092F2")]
		[Address(RVA = "0xDD2C40", Offset = "0xDD1E40", VA = "0x180DD2C40")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x60092F3")]
		[Address(RVA = "0xDD40C0", Offset = "0xDD32C0", VA = "0x180DD40C0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x140000CD")]
	public event onDecideFieldDelegate onDecideFieldHandler
	{
		[Token(Token = "0x60092F4")]
		[Address(RVA = "0xDD1DD0", Offset = "0xDD0FD0", VA = "0x180DD1DD0")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x60092F5")]
		[Address(RVA = "0xDD3250", Offset = "0xDD2450", VA = "0x180DD3250")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x140000CE")]
	public event onDoubleClickFieldDelegate onDoubleClickFieldHandler
	{
		[Token(Token = "0x60092F6")]
		[Address(RVA = "0xDD1F30", Offset = "0xDD1130", VA = "0x180DD1F30")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x60092F7")]
		[Address(RVA = "0xDD33B0", Offset = "0xDD25B0", VA = "0x180DD33B0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x140000CF")]
	public event onDragFieldBeginDelegate onDragFieldBeginHandler
	{
		[Token(Token = "0x60092F8")]
		[Address(RVA = "0xDD1FE0", Offset = "0xDD11E0", VA = "0x180DD1FE0")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x60092F9")]
		[Address(RVA = "0xDD3460", Offset = "0xDD2660", VA = "0x180DD3460")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x140000D0")]
	public event onDragFieldDelegate onDragFieldHandler
	{
		[Token(Token = "0x60092FA")]
		[Address(RVA = "0xDD2140", Offset = "0xDD1340", VA = "0x180DD2140")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x60092FB")]
		[Address(RVA = "0xDD35C0", Offset = "0xDD27C0", VA = "0x180DD35C0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x140000D1")]
	public event onDragFieldEndDelegate onDragFieldEndHandler
	{
		[Token(Token = "0x60092FC")]
		[Address(RVA = "0xDD2090", Offset = "0xDD1290", VA = "0x180DD2090")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x60092FD")]
		[Address(RVA = "0xDD3510", Offset = "0xDD2710", VA = "0x180DD3510")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x140000D2")]
	public event onHoldFieldBeginDelegate onHoldFieldBeginHandler
	{
		[Token(Token = "0x60092FE")]
		[Address(RVA = "0xDD24B0", Offset = "0xDD16B0", VA = "0x180DD24B0")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x60092FF")]
		[Address(RVA = "0xDD3930", Offset = "0xDD2B30", VA = "0x180DD3930")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x140000D3")]
	public event onDecideAttackTargetDelegate onDecideAttackTargetHandler
	{
		[Token(Token = "0x6009300")]
		[Address(RVA = "0xDD1D20", Offset = "0xDD0F20", VA = "0x180DD1D20")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x6009301")]
		[Address(RVA = "0xDD31A0", Offset = "0xDD23A0", VA = "0x180DD31A0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x140000D4")]
	public event onFieldViewChangedDelegate onFieldViewChangedHandler
	{
		[Token(Token = "0x6009302")]
		[Address(RVA = "0xDD22A0", Offset = "0xDD14A0", VA = "0x180DD22A0")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x6009303")]
		[Address(RVA = "0xDD3720", Offset = "0xDD2920", VA = "0x180DD3720")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x140000D5")]
	public event onChangeActivateConfirmMode onChangeActivateConfirmModeHandler
	{
		[Token(Token = "0x6009304")]
		[Address(RVA = "0xDD1A60", Offset = "0xDD0C60", VA = "0x180DD1A60")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x6009305")]
		[Address(RVA = "0xDD2EE0", Offset = "0xDD20E0", VA = "0x180DD2EE0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x140000D6")]
	public event onChangeDetailShowing onChangeDetailShowingHandler
	{
		[Token(Token = "0x6009306")]
		[Address(RVA = "0xDD1B10", Offset = "0xDD0D10", VA = "0x180DD1B10")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x6009307")]
		[Address(RVA = "0xDD2F90", Offset = "0xDD2190", VA = "0x180DD2F90")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x140000D7")]
	public event onFieldBackKey onFieldBackKeyHandler
	{
		[Token(Token = "0x6009308")]
		[Address(RVA = "0xDD21F0", Offset = "0xDD13F0", VA = "0x180DD21F0")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x6009309")]
		[Address(RVA = "0xDD3670", Offset = "0xDD2870", VA = "0x180DD3670")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x140000D8")]
	public event onPlayScreenEffect onPlayScreenEffectHandler
	{
		[Token(Token = "0x600930A")]
		[Address(RVA = "0xDD2560", Offset = "0xDD1760", VA = "0x180DD2560")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x600930B")]
		[Address(RVA = "0xDD39E0", Offset = "0xDD2BE0", VA = "0x180DD39E0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x140000D9")]
	public event onStopScreenEffect onStopScreenEffectHandler
	{
		[Token(Token = "0x600930C")]
		[Address(RVA = "0xDD28D0", Offset = "0xDD1AD0", VA = "0x180DD28D0")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x600930D")]
		[Address(RVA = "0xDD3D50", Offset = "0xDD2F50", VA = "0x180DD3D50")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x60092AB")]
	[Address(RVA = "0xDC9A70", Offset = "0xDC8C70", VA = "0x180DC9A70")]
	public GameObject GetChildRoot(GUIPriority priority)
	{
		return null;
	}

	[Token(Token = "0x60092B7")]
	[Address(RVA = "0xDCDA80", Offset = "0xDCCC80", VA = "0x180DCDA80", Slot = "6")]
	public override void NotificationStackEntry()
	{
	}

	[Token(Token = "0x60092B8")]
	[Address(RVA = "0xDCDE70", Offset = "0xDCD070", VA = "0x180DCDE70", Slot = "7")]
	public override void NotificationStackRemove()
	{
	}

	[Token(Token = "0x60092B9")]
	[Address(RVA = "0xDCE050", Offset = "0xDCD250", VA = "0x180DCE050", Slot = "13")]
	public override bool OnBack()
	{
		return default(bool);
	}

	[Token(Token = "0x60092BA")]
	[Address(RVA = "0xDC7100", Offset = "0xDC6300", VA = "0x180DC7100")]
	private void Awake()
	{
	}

	[Token(Token = "0x60092BB")]
	[Address(RVA = "0xDCE1E0", Offset = "0xDCD3E0", VA = "0x180DCE1E0")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x60092BC")]
	[Address(RVA = "0xDCEDC0", Offset = "0xDCDFC0", VA = "0x180DCEDC0", Slot = "9")]
	public override float Progress()
	{
		return default(float);
	}

	[Token(Token = "0x60092BD")]
	[Address(RVA = "0xDCEDB0", Offset = "0xDCDFB0", VA = "0x180DCEDB0", Slot = "10")]
	public override void ProgressUpdate()
	{
	}

	[Token(Token = "0x60092BE")]
	[Address(RVA = "0xDCEDB0", Offset = "0xDCDFB0", VA = "0x180DCEDB0")]
	private void Update()
	{
	}

	[Token(Token = "0x60092BF")]
	[Address(RVA = "0xDCF8C0", Offset = "0xDCEAC0", VA = "0x180DCF8C0")]
	[MonoPInvokeCallback(typeof(Engine.RunEffect))]
	public static int RunEffect(int id, int param1, int param2, int param3)
	{
		return default(int);
	}

	[Token(Token = "0x60092C0")]
	[Address(RVA = "0xDCF780", Offset = "0xDCE980", VA = "0x180DCF780")]
	private int RunEffectImpl(int id, int param1, int param2, int param3)
	{
		return default(int);
	}

	[Token(Token = "0x60092C1")]
	[Address(RVA = "0xDCD540", Offset = "0xDCC740", VA = "0x180DCD540")]
	[MonoPInvokeCallback(typeof(Engine.IsBusyEffect))]
	public static int IsBusyEffect(int id)
	{
		return default(int);
	}

	[Token(Token = "0x60092C2")]
	[Address(RVA = "0xDCD460", Offset = "0xDCC660", VA = "0x180DCD460")]
	private int IsBusyEffectImpl(int id)
	{
		return default(int);
	}

	[Token(Token = "0x60092C3")]
	[Address(RVA = "0xDC6FE0", Offset = "0xDC61E0", VA = "0x180DC6FE0")]
	public void AddEffectHandler(Engine.ViewType type, EffectHandler eh)
	{
	}

	[Token(Token = "0x60092C4")]
	[Address(RVA = "0xDCF5A0", Offset = "0xDCE7A0", VA = "0x180DCF5A0")]
	public void RemoveEffectHandler(Engine.ViewType type, EffectHandler eh)
	{
	}

	[Token(Token = "0x60092C5")]
	[Address(RVA = "0xDC6DC0", Offset = "0xDC5FC0", VA = "0x180DC6DC0")]
	public void AddAudienceReplayEffectHandler(Engine.ViewType type, EffectHandler eh)
	{
	}

	[Token(Token = "0x60092C6")]
	[Address(RVA = "0xDCF450", Offset = "0xDCE650", VA = "0x180DCF450")]
	public void RemoveAudienceReplayEffectHandler(Engine.ViewType type, EffectHandler eh)
	{
	}

	[Token(Token = "0x60092C7")]
	[Address(RVA = "0xDC6EE0", Offset = "0xDC60E0", VA = "0x180DC6EE0")]
	public void AddBackEvent(Func<bool> func, bool first = false)
	{
	}

	[Token(Token = "0x60092C8")]
	[Address(RVA = "0xDCF540", Offset = "0xDCE740", VA = "0x180DCF540")]
	public void RemoveBackEvent(Func<bool> func)
	{
	}

	[Token(Token = "0x60092C9")]
	[Address(RVA = "0x3EF010", Offset = "0x3EE210", VA = "0x1803EF010", Slot = "16")]
	public Color FadeColor(TransitionType type)
	{
		return default(Color);
	}

	[Token(Token = "0x60092CA")]
	[Address(RVA = "0x3EF020", Offset = "0x3EE220", VA = "0x1803EF020", Slot = "17")]
	public SystemProgress.ProgressType FadeType(TransitionType type)
	{
		return default(SystemProgress.ProgressType);
	}

	[Token(Token = "0x60092CB")]
	[Address(RVA = "0xDCFE80", Offset = "0xDCF080", VA = "0x180DCFE80")]
	public void SetActiveInputBlocker(bool active)
	{
	}

	[Token(Token = "0x60092CC")]
	[Address(RVA = "0xDC7A80", Offset = "0xDC6C80", VA = "0x180DC7A80")]
	public void DeactiveInputBlocker(bool force)
	{
	}

	[Token(Token = "0x60092CD")]
	[Address(RVA = "0xDCFDB0", Offset = "0xDCEFB0", VA = "0x180DCFDB0")]
	public void SetActiveFieldInputBlocker(bool active, bool ifBlocked = false)
	{
	}

	[Token(Token = "0x60092CE")]
	[Address(RVA = "0xDC7990", Offset = "0xDC6B90", VA = "0x180DC7990")]
	public void DeactivateFieldInputBlocker(bool force = false)
	{
	}

	[Token(Token = "0x60092D1")]
	[Address(RVA = "0xDD0040", Offset = "0xDCF240", VA = "0x180DD0040")]
	private void SetupPvp()
	{
	}

	[Token(Token = "0x60092D2")]
	[Address(RVA = "0xDC9830", Offset = "0xDC8A30", VA = "0x180DC9830")]
	private void FinishPvP()
	{
	}

	[Token(Token = "0x60092D3")]
	[Address(RVA = "0xDCEDF0", Offset = "0xDCDFF0", VA = "0x180DCEDF0")]
	private void PvpNetworkCompleteHandler(PvP.Event ev, int code)
	{
	}

	[Token(Token = "0x60092D4")]
	[Address(RVA = "0xDCEEA0", Offset = "0xDCE0A0", VA = "0x180DCEEA0")]
	private void PvpNetworkErrorHandler(PvP.Event ev, int code)
	{
	}

	[Token(Token = "0x60092D5")]
	[Address(RVA = "0xDCEF80", Offset = "0xDCE180", VA = "0x180DCEF80")]
	private void PvpNetworkFatalErrorHandler(PvP.Event ev, int code)
	{
	}

	[Token(Token = "0x60092D6")]
	[Address(RVA = "0xDCF070", Offset = "0xDCE270", VA = "0x180DCF070")]
	private void PvpProgress(bool enable)
	{
	}

	[Token(Token = "0x60092D7")]
	[Address(RVA = "0xDCF690", Offset = "0xDCE890", VA = "0x180DCF690")]
	private void ReplayRealtime(bool replayQueued, bool mainQueued)
	{
	}

	[Token(Token = "0x60092D8")]
	[Address(RVA = "0x7439D0", Offset = "0x742BD0", VA = "0x1807439D0")]
	public bool GetPvpTimeout()
	{
		return default(bool);
	}

	[Token(Token = "0x60092D9")]
	[Address(RVA = "0xDCD750", Offset = "0xDCC950", VA = "0x180DCD750")]
	public bool IsReplayRealtime()
	{
		return default(bool);
	}

	[Token(Token = "0x60092DA")]
	[Address(RVA = "0xDCF770", Offset = "0xDCE970", VA = "0x180DCF770")]
	public void ResetReplayRealtimeFlag()
	{
	}

	[Token(Token = "0x60092DB")]
	[Address(RVA = "0xDD0970", Offset = "0xDCFB70", VA = "0x180DD0970")]
	public bool UseMinimumEffect()
	{
		return default(bool);
	}

	[Token(Token = "0x600930E")]
	[Address(RVA = "0xDCCC70", Offset = "0xDCBE70", VA = "0x180DCCC70")]
	public static void InvokeShowAffect(int player, int position, int index)
	{
	}

	[Token(Token = "0x600930F")]
	[Address(RVA = "0xDCC770", Offset = "0xDCB970", VA = "0x180DCC770")]
	public static void InvokeHideAffect()
	{
	}

	[Token(Token = "0x6009310")]
	[Address(RVA = "0xDCCE10", Offset = "0xDCC010", VA = "0x180DCCE10")]
	public static void InvokeTapDownField(int player, int position, int viewIndex)
	{
	}

	[Token(Token = "0x6009311")]
	[Address(RVA = "0xDCD0E0", Offset = "0xDCC2E0", VA = "0x180DCD0E0")]
	public static void InvokeTapUpField(int player, int position, int viewIndex)
	{
	}

	[Token(Token = "0x6009312")]
	[Address(RVA = "0xDCCF00", Offset = "0xDCC100", VA = "0x180DCCF00")]
	public static void InvokeTapEnterField(int player, int position, int viewIndex)
	{
	}

	[Token(Token = "0x6009313")]
	[Address(RVA = "0xDCCFF0", Offset = "0xDCC1F0", VA = "0x180DCCFF0")]
	public static void InvokeTapExitField(int player, int position, int viewIndex)
	{
	}

	[Token(Token = "0x6009314")]
	[Address(RVA = "0xDCB770", Offset = "0xDCA970", VA = "0x180DCB770")]
	public static void InvokeCursorEnterField(int player, int position, int viewIndex)
	{
	}

	[Token(Token = "0x6009315")]
	[Address(RVA = "0xDCB860", Offset = "0xDCAA60", VA = "0x180DCB860")]
	public static void InvokeCursorExitField(int player, int position, int viewIndex)
	{
	}

	[Token(Token = "0x6009316")]
	[Address(RVA = "0xDCCAD0", Offset = "0xDCBCD0", VA = "0x180DCCAD0")]
	public static void InvokeSelectField(SharedDefinition.Location location, int position, int viewIndex)
	{
	}

	[Token(Token = "0x6009317")]
	[Address(RVA = "0xDCC9E0", Offset = "0xDCBBE0", VA = "0x180DCC9E0")]
	public static void InvokeSelectField(int player, int position, int viewIndex)
	{
	}

	[Token(Token = "0x6009318")]
	[Address(RVA = "0xDCBCF0", Offset = "0xDCAEF0", VA = "0x180DCBCF0")]
	public static void InvokeDeselectField(SharedDefinition.Location location, int position, int viewIndex)
	{
	}

	[Token(Token = "0x6009319")]
	[Address(RVA = "0xDCBE90", Offset = "0xDCB090", VA = "0x180DCBE90")]
	public static void InvokeDeselectField(int player, int position, int viewIndex)
	{
	}

	[Token(Token = "0x600931A")]
	[Address(RVA = "0xDCC4E0", Offset = "0xDCB6E0", VA = "0x180DCC4E0")]
	public static void InvokeFocusField(SharedDefinition.Location location, int position, int viewIndex)
	{
	}

	[Token(Token = "0x600931B")]
	[Address(RVA = "0xDCC680", Offset = "0xDCB880", VA = "0x180DCC680")]
	public static void InvokeFocusField(int player, int position, int viewIndex)
	{
	}

	[Token(Token = "0x600931C")]
	[Address(RVA = "0xDCD1D0", Offset = "0xDCC3D0", VA = "0x180DCD1D0")]
	public static void InvokeUnfocusField(SharedDefinition.Location location, int position, int viewIndex)
	{
	}

	[Token(Token = "0x600931D")]
	[Address(RVA = "0xDCD370", Offset = "0xDCC570", VA = "0x180DCD370")]
	public static void InvokeUnfocusField(int player, int position, int viewIndex)
	{
	}

	[Token(Token = "0x600931E")]
	[Address(RVA = "0xDCBA60", Offset = "0xDCAC60", VA = "0x180DCBA60")]
	public static void InvokeDecideField(SharedDefinition.Location location, int position, int viewIndex)
	{
	}

	[Token(Token = "0x600931F")]
	[Address(RVA = "0xDCBC00", Offset = "0xDCAE00", VA = "0x180DCBC00")]
	public static void InvokeDecideField(int player, int position, int viewIndex)
	{
	}

	[Token(Token = "0x6009320")]
	[Address(RVA = "0xDCBF80", Offset = "0xDCB180", VA = "0x180DCBF80")]
	public static void InvokeDoubleClickField(int player, int position, int viewIndex)
	{
	}

	[Token(Token = "0x6009321")]
	[Address(RVA = "0xDCC070", Offset = "0xDCB270", VA = "0x180DCC070")]
	public static void InvokeDragFieldBegin(int player, int position, int viewIndex, Vector2 screenPoint)
	{
	}

	[Token(Token = "0x6009322")]
	[Address(RVA = "0xDCC270", Offset = "0xDCB470", VA = "0x180DCC270")]
	public static void InvokeDragField(int player, int position, int viewIndex, Vector2 screenPoint)
	{
	}

	[Token(Token = "0x6009323")]
	[Address(RVA = "0xDCC170", Offset = "0xDCB370", VA = "0x180DCC170")]
	public static void InvokeDragFieldEnd(int player, int position, int viewIndex, Vector2 screenPoint)
	{
	}

	[Token(Token = "0x6009324")]
	[Address(RVA = "0xDCC830", Offset = "0xDCBA30", VA = "0x180DCC830")]
	public static void InvokeHoldFieldBegin(int player, int position, int viewIndex, Vector2 screenPoint)
	{
	}

	[Token(Token = "0x6009325")]
	[Address(RVA = "0xDCB950", Offset = "0xDCAB50", VA = "0x180DCB950")]
	public static void InvokeDecideAttackTarget(int attackerPlayer, int attackerPosition, int attackerIndex, int targetPlayer, int targetPosition, int targetIndex)
	{
	}

	[Token(Token = "0x6009326")]
	[Address(RVA = "0xDCC420", Offset = "0xDCB620", VA = "0x180DCC420")]
	public static void InvokeFieldViewChanged(bool fieldViewing)
	{
	}

	[Token(Token = "0x6009327")]
	[Address(RVA = "0xDCB5D0", Offset = "0xDCA7D0", VA = "0x180DCB5D0")]
	public static void InvokeChangeActivateConfirmModeCheck(ActivateConfirmMode mode)
	{
	}

	[Token(Token = "0x6009328")]
	[Address(RVA = "0xDCB690", Offset = "0xDCA890", VA = "0x180DCB690")]
	public static void InvokeChangeDetailShowing(bool showing)
	{
	}

	[Token(Token = "0x6009329")]
	[Address(RVA = "0xDCC370", Offset = "0xDCB570", VA = "0x180DCC370")]
	public static void InvokeFieldBackKey()
	{
	}

	[Token(Token = "0x600932A")]
	[Address(RVA = "0xDCC930", Offset = "0xDCBB30", VA = "0x180DCC930")]
	public static void InvokePlayScreenEffect()
	{
	}

	[Token(Token = "0x600932B")]
	[Address(RVA = "0xDCCD60", Offset = "0xDCBF60", VA = "0x180DCCD60")]
	public static void InvokeStopScreenEffect()
	{
	}

	[Token(Token = "0x600932C")]
	[Address(RVA = "0xDC9CC0", Offset = "0xDC8EC0", VA = "0x180DC9CC0")]
	public static bool GetFieldCardFace(int player, int position, int index)
	{
		return default(bool);
	}

	[Token(Token = "0x600932D")]
	[Address(RVA = "0xDC9EF0", Offset = "0xDC90F0", VA = "0x180DC9EF0")]
	public static int GetFieldCardID(int player, int position, int index)
	{
		return default(int);
	}

	[Token(Token = "0x600932E")]
	[Address(RVA = "0xDCA0D0", Offset = "0xDC92D0", VA = "0x180DCA0D0")]
	public static int GetLP(int player)
	{
		return default(int);
	}

	[Token(Token = "0x600932F")]
	[Address(RVA = "0xDC9BA0", Offset = "0xDC8DA0", VA = "0x180DC9BA0")]
	public static DuelSpeed GetDuelSpeed()
	{
		return default(DuelSpeed);
	}

	[Token(Token = "0x6009330")]
	[Address(RVA = "0xDCFED0", Offset = "0xDCF0D0", VA = "0x180DCFED0")]
	public static void SetDuelSpeed(DuelSpeed duelSpeed)
	{
	}

	[Token(Token = "0x6009331")]
	[Address(RVA = "0xDC9B00", Offset = "0xDC8D00", VA = "0x180DC9B00")]
	public static float GetDuelDeltaTime()
	{
		return default(float);
	}

	[Token(Token = "0x6009332")]
	[Address(RVA = "0xDC9C40", Offset = "0xDC8E40", VA = "0x180DC9C40")]
	public static float GetDuelTimeScale()
	{
		return default(float);
	}

	[Token(Token = "0x6009333")]
	[Address(RVA = "0xDCF0F0", Offset = "0xDCE2F0", VA = "0x180DCF0F0")]
	public static void QuitReplay()
	{
	}

	[Token(Token = "0x6009334")]
	[Address(RVA = "0xDCFF70", Offset = "0xDCF170", VA = "0x180DCFF70")]
	public static void SetPauseReplay(bool pause)
	{
	}

	[Token(Token = "0x6009335")]
	[Address(RVA = "0xDCEA70", Offset = "0xDCDC70", VA = "0x180DCEA70")]
	public static Vector3 PositionToScreenPoint(int player, int position, int index = 0)
	{
		return default(Vector3);
	}

	[Token(Token = "0x6009336")]
	[Address(RVA = "0xDCE750", Offset = "0xDCD950", VA = "0x180DCE750")]
	public static Vector3 PositionToScreenLocalPoint(int player, int position)
	{
		return default(Vector3);
	}

	[Token(Token = "0x6009337")]
	[Address(RVA = "0xDCE860", Offset = "0xDCDA60", VA = "0x180DCE860")]
	public static Vector3 PositionToScreenLocalPoint(int player, int position, int index)
	{
		return default(Vector3);
	}

	[Token(Token = "0x6009338")]
	[Address(RVA = "0xDCFB90", Offset = "0xDCED90", VA = "0x180DCFB90")]
	public static Vector3 ScreenPointToLocalPointDuelClient(Vector3 pos)
	{
		return default(Vector3);
	}

	[Token(Token = "0x6009339")]
	[Address(RVA = "0xDCD890", Offset = "0xDCCA90", VA = "0x180DCD890")]
	public static Vector3 MateToScreenLocalPoint(BgUnit.Side side)
	{
		return default(Vector3);
	}

	[Token(Token = "0x600933A")]
	[Address(RVA = "0xDCFA50", Offset = "0xDCEC50", VA = "0x180DCFA50")]
	public static Vector3 ScreenPointToDuelCameraWorldPosition(Vector3 screenPoint)
	{
		return default(Vector3);
	}

	[Token(Token = "0x600933B")]
	[Address(RVA = "0xDCE640", Offset = "0xDCD840", VA = "0x180DCE640")]
	public static Vector2 PositionToHighlightPoint(int player, int position)
	{
		return default(Vector2);
	}

	[Token(Token = "0x600933C")]
	[Address(RVA = "0xDC9900", Offset = "0xDC8B00", VA = "0x180DC9900")]
	public static (int, int, int) GetCardPosition(Vector2 screenPoint)
	{
		return default((int, int, int));
	}

	[Token(Token = "0x600933D")]
	[Address(RVA = "0xDCD640", Offset = "0xDCC840", VA = "0x180DCD640")]
	public static bool IsDetailShowing()
	{
		return default(bool);
	}

	[Token(Token = "0x6009348")]
	[Address(RVA = "0xDCA1C0", Offset = "0xDC93C0", VA = "0x180DCA1C0")]
	private float GetProgress(Step current, Step start, Step end)
	{
		return default(float);
	}

	[Token(Token = "0x6009349")]
	[Address(RVA = "0xDCA370", Offset = "0xDC9570", VA = "0x180DCA370")]
	private void InitEngineImpl()
	{
	}

	[Token(Token = "0x600934A")]
	[Address(RVA = "0xDC8D10", Offset = "0xDC7F10", VA = "0x180DC8D10")]
	private void EvalEachSteps()
	{
	}

	[Token(Token = "0x600934B")]
	[Address(RVA = "0xDCEDB0", Offset = "0xDCDFB0", VA = "0x180DCEDB0")]
	private void UpdateInitStep()
	{
	}

	[Token(Token = "0x600934C")]
	[Address(RVA = "0xDCEDB0", Offset = "0xDCDFB0", VA = "0x180DCEDB0")]
	private void UpdateExecAndTermStep()
	{
	}

	[Token(Token = "0x600934D")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60")]
	private void BeginningStep()
	{
	}

	[Token(Token = "0x600934E")]
	[Address(RVA = "0xDCAC30", Offset = "0xDC9E30", VA = "0x180DCAC30")]
	private void InitLoadResStep()
	{
	}

	[Token(Token = "0x600934F")]
	[Address(RVA = "0xDD1250", Offset = "0xDD0450", VA = "0x180DD1250")]
	private void WaitLoadResStep()
	{
	}

	[Token(Token = "0x6009350")]
	[Address(RVA = "0xDCB190", Offset = "0xDCA390", VA = "0x180DCB190")]
	private void InitializeProcessStep()
	{
	}

	[Token(Token = "0x6009351")]
	[Address(RVA = "0xDC9780", Offset = "0xDC8980", VA = "0x180DC9780")]
	private void FinishInitializeStep()
	{
	}

	[Token(Token = "0x6009352")]
	[Address(RVA = "0xDD0B90", Offset = "0xDCFD90", VA = "0x180DD0B90")]
	private void WaitConnectingStep()
	{
	}

	[Token(Token = "0x6009353")]
	[Address(RVA = "0xDCA570", Offset = "0xDC9770", VA = "0x180DCA570")]
	private void InitEngineStep()
	{
	}

	[Token(Token = "0x6009354")]
	[Address(RVA = "0xDCACA0", Offset = "0xDC9EA0", VA = "0x180DCACA0")]
	private void InitSoundStep()
	{
	}

	[Token(Token = "0x6009355")]
	[Address(RVA = "0xDD1310", Offset = "0xDD0510", VA = "0x180DD1310")]
	private void WaitSoundStep()
	{
	}

	[Token(Token = "0x6009356")]
	[Address(RVA = "0xDCAC80", Offset = "0xDC9E80", VA = "0x180DCAC80")]
	private void InitLoadSoundStep()
	{
	}

	[Token(Token = "0x6009357")]
	[Address(RVA = "0xDD12B0", Offset = "0xDD04B0", VA = "0x180DD12B0")]
	private void WaitLoadSoundStep()
	{
	}

	[Token(Token = "0x6009358")]
	[Address(RVA = "0xDD1010", Offset = "0xDD0210", VA = "0x180DD1010")]
	private void WaitGameObjectInitStep()
	{
	}

	[Token(Token = "0x6009359")]
	[Address(RVA = "0xDCEC60", Offset = "0xDCDE60", VA = "0x180DCEC60")]
	private void PrepareProcessStep()
	{
	}

	[Token(Token = "0x600935A")]
	[Address(RVA = "0xDC9820", Offset = "0xDC8A20", VA = "0x180DC9820")]
	private void FinishPrepareStep()
	{
	}

	[Token(Token = "0x600935B")]
	[Address(RVA = "0xDD09F0", Offset = "0xDCFBF0", VA = "0x180DD09F0")]
	private void WaitCameraWork()
	{
	}

	[Token(Token = "0x600935C")]
	[Address(RVA = "0xDD0390", Offset = "0xDCF590", VA = "0x180DD0390")]
	private void ShowUpDuelStep()
	{
	}

	[Token(Token = "0x600935D")]
	[Address(RVA = "0xDD12D0", Offset = "0xDD04D0", VA = "0x180DD12D0")]
	private void WaitShowUpStep()
	{
	}

	[Token(Token = "0x600935E")]
	[Address(RVA = "0xDCA1F0", Offset = "0xDC93F0", VA = "0x180DCA1F0")]
	private void InitDuel()
	{
	}

	[Token(Token = "0x600935F")]
	[Address(RVA = "0xDC9470", Offset = "0xDC8670", VA = "0x180DC9470")]
	private void ExecDuelStep()
	{
	}

	[Token(Token = "0x6009360")]
	[Address(RVA = "0xDCD760", Offset = "0xDCC960", VA = "0x180DCD760")]
	private bool IsToMainQueueIsEmpty()
	{
		return default(bool);
	}

	[Token(Token = "0x6009361")]
	[Address(RVA = "0xDC7D70", Offset = "0xDC6F70", VA = "0x180DC7D70")]
	private void EndDuelStep()
	{
	}

	[Token(Token = "0x6009362")]
	[Address(RVA = "0xDC7CE0", Offset = "0xDC6EE0", VA = "0x180DC7CE0")]
	private void DuelEndStep()
	{
	}

	[Token(Token = "0x6009363")]
	[Address(RVA = "0xDCAF60", Offset = "0xDCA160", VA = "0x180DCAF60")]
	private void InitTermStep()
	{
	}

	[Token(Token = "0x6009364")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60")]
	private void WaitEndViewClose()
	{
	}

	[Token(Token = "0x6009365")]
	[Address(RVA = "0xDCD6E0", Offset = "0xDCC8E0", VA = "0x180DCD6E0")]
	private bool IsPlayDuelClientEndView()
	{
		return default(bool);
	}

	[Token(Token = "0x6009366")]
	[Address(RVA = "0xDD1320", Offset = "0xDD0520", VA = "0x180DD1320")]
	private void WaitTermStep()
	{
	}

	[Token(Token = "0x6009367")]
	[Address(RVA = "0xDD0FF0", Offset = "0xDD01F0", VA = "0x180DD0FF0")]
	private void WaitEndNetworkStep()
	{
	}

	[Token(Token = "0x6009368")]
	[Address(RVA = "0xDC81D0", Offset = "0xDC73D0", VA = "0x180DC81D0")]
	private void EndStep()
	{
	}

	[Token(Token = "0x6009369")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60")]
	private void WaitDestroyStep()
	{
	}

	[Token(Token = "0x600936A")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60")]
	private void ConnectingErrorStep()
	{
	}

	[Token(Token = "0x600936B")]
	[Address(RVA = "0xDD0150", Offset = "0xDCF350", VA = "0x180DD0150")]
	private void ShowErrorDialog(string msg, Step nextStep)
	{
	}

	[Token(Token = "0x600936C")]
	[Address(RVA = "0xDC7AD0", Offset = "0xDC6CD0", VA = "0x180DC7AD0")]
	private void DestroyStep()
	{
	}

	[Token(Token = "0x600936D")]
	[Address(RVA = "0xDCF210", Offset = "0xDCE410", VA = "0x180DCF210")]
	private void ReleaseResources()
	{
	}

	[Token(Token = "0x600936E")]
	[Address(RVA = "0xDD15A0", Offset = "0xDD07A0", VA = "0x180DD15A0")]
	private void WriteResultToSendWork()
	{
	}

	[Token(Token = "0x600936F")]
	[Address(RVA = "0xDC9840", Offset = "0xDC8A40", VA = "0x180DC9840")]
	public uint GetANumber()
	{
		return default(uint);
	}

	[Token(Token = "0x6009370")]
	[Address(RVA = "0xDCE010", Offset = "0xDCD210", VA = "0x180DCE010")]
	private void OnApplicationQuit()
	{
	}

	[Token(Token = "0x6009371")]
	[Address(RVA = "0xDD1780", Offset = "0xDD0980", VA = "0x180DD1780")]
	public DuelClient()
	{
	}
}
