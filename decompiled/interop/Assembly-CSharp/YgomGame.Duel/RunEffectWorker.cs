using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace YgomGame.Duel;

[Token(Token = "0x2001B74")]
public class RunEffectWorker : AbstractRunEffectWorker
{
	[Token(Token = "0x2001B75")]
	private enum Step
	{
		[Token(Token = "0x400F97F")]
		Initializing,
		[Token(Token = "0x400F980")]
		Initialized,
		[Token(Token = "0x400F981")]
		Preparing,
		[Token(Token = "0x400F982")]
		ExecDuel,
		[Token(Token = "0x400F983")]
		Terminating,
		[Token(Token = "0x400F984")]
		Finish
	}

	[Token(Token = "0x2001B76")]
	private delegate Dictionary<string, object> preCreateDelegate(RunEffectWorker worker, int param1, int param2, int param3);

	[Token(Token = "0x2001B77")]
	private delegate EffectTask createDelegate(RunEffectWorker worker, int param1, int param2, int param3);

	[Token(Token = "0x2001B78")]
	private delegate EffectTask createDelegateAdvanced(RunEffectWorker worker, int param1, int param2, int param3, Dictionary<string, object> immediateWork);

	[Token(Token = "0x2001B79")]
	private class RunEffectParam
	{
		[Token(Token = "0x400F985")]
		[FieldOffset(Offset = "0x10")]
		public Engine.ViewType viewType;

		[Token(Token = "0x400F986")]
		[FieldOffset(Offset = "0x18")]
		public createDelegate createFunc;

		[Token(Token = "0x400F987")]
		[FieldOffset(Offset = "0x20")]
		public createDelegateAdvanced createFuncAdvanced;

		[Token(Token = "0x400F988")]
		[FieldOffset(Offset = "0x28")]
		public int param1;

		[Token(Token = "0x400F989")]
		[FieldOffset(Offset = "0x2C")]
		public int param2;

		[Token(Token = "0x400F98A")]
		[FieldOffset(Offset = "0x30")]
		public int param3;

		[Token(Token = "0x400F98B")]
		[FieldOffset(Offset = "0x38")]
		public EffectTask task;

		[Token(Token = "0x400F98C")]
		[FieldOffset(Offset = "0x40")]
		public Dictionary<string, object> immediateWork;

		[Token(Token = "0x600B2E4")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public RunEffectParam()
		{
		}
	}

	[Token(Token = "0x2001B7A")]
	public enum CountDialogType
	{
		[Token(Token = "0x400F98E")]
		None,
		[Token(Token = "0x400F98F")]
		Discard,
		[Token(Token = "0x400F990")]
		Ritual
	}

	[Token(Token = "0x2001B7B")]
	public class PlayerselfInfo<T>
	{
		[Token(Token = "0x400F991")]
		[FieldOffset(Offset = "0x0")]
		public T myself;

		[Token(Token = "0x400F992")]
		[FieldOffset(Offset = "0x0")]
		public T rival;

		[Token(Token = "0x600B2E5")]
		public PlayerselfInfo()
		{
		}
	}

	[Token(Token = "0x2001B81")]
	[CompilerGenerated]
	private sealed class _003CInitializeProcess_003Ed__458 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400F9A5")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400F9A6")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400F9A7")]
		[FieldOffset(Offset = "0x20")]
		public RunEffectWorker _003C_003E4__this;

		[Token(Token = "0x400F9A8")]
		[FieldOffset(Offset = "0x28")]
		private GameObject _003ClowPrioRoot_003E5__2;

		[Token(Token = "0x17001B63")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x600B2F7")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17001B64")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600B2F9")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600B2F4")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CInitializeProcess_003Ed__458(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x600B2F5")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x600B2F6")]
		[Address(RVA = "0x4AEB10", Offset = "0x4ADD10", VA = "0x1804AEB10", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600B2F8")]
		[Address(RVA = "0x4AF740", Offset = "0x4AE940", VA = "0x1804AF740", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x2001B82")]
	[CompilerGenerated]
	private sealed class _003CPrepareToDuelProcess_003Ed__461 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400F9A9")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400F9AA")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400F9AB")]
		[FieldOffset(Offset = "0x20")]
		public RunEffectWorker _003C_003E4__this;

		[Token(Token = "0x400F9AC")]
		[FieldOffset(Offset = "0x28")]
		private int _003Cmyself_003E5__2;

		[Token(Token = "0x400F9AD")]
		[FieldOffset(Offset = "0x2C")]
		private int _003Crival_003E5__3;

		[Token(Token = "0x400F9AE")]
		[FieldOffset(Offset = "0x30")]
		private Transform _003CmessageDialogRoot_003E5__4;

		[Token(Token = "0x17001B65")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x600B2FD")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17001B66")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600B2FF")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600B2FA")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CPrepareToDuelProcess_003Ed__461(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x600B2FB")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x600B2FC")]
		[Address(RVA = "0x4AF780", Offset = "0x4AE980", VA = "0x1804AF780", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600B2FE")]
		[Address(RVA = "0x4B1BE0", Offset = "0x4B0DE0", VA = "0x1804B1BE0", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x400F8F3")]
	[FieldOffset(Offset = "0x18")]
	private Step step;

	[Token(Token = "0x400F8F5")]
	[FieldOffset(Offset = "0x28")]
	private List<RunEffectParam> runEffectParams;

	[Token(Token = "0x400F8F7")]
	[FieldOffset(Offset = "0x38")]
	private DuelAcslInfo acsl;

	[Token(Token = "0x400F8F8")]
	[FieldOffset(Offset = "0x40")]
	private DuelRuleSetInfo ruleSet;

	[Token(Token = "0x400F8FD")]
	[FieldOffset(Offset = "0x58")]
	private Coroutine initializeCoroutine;

	[Token(Token = "0x400F8FE")]
	[FieldOffset(Offset = "0x60")]
	private Coroutine prepareToDuelCoroutine;

	[Token(Token = "0x400F90D")]
	[FieldOffset(Offset = "0xD1")]
	private bool initialized;

	[Token(Token = "0x400F90F")]
	[FieldOffset(Offset = "0xD8")]
	private MessageDialog messageDialogNoResponse;

	[Token(Token = "0x400F910")]
	[FieldOffset(Offset = "0xE0")]
	private MessageDialog messageDialogNoOperation;

	[Token(Token = "0x400F912")]
	[FieldOffset(Offset = "0xF0")]
	private bool isForeverInfoMessage;

	[Token(Token = "0x400F913")]
	[FieldOffset(Offset = "0xF4")]
	private float noOperationTimer;

	[Token(Token = "0x400F914")]
	private const float noOperationWarningSecond = 30f;

	[Token(Token = "0x400F915")]
	private const float noOperationSurrenderSecond = 40f;

	[Token(Token = "0x400F91C")]
	public const int SELECT_LOCATION_TEXT_ID = 326;

	[Token(Token = "0x400F91D")]
	public const int UNUSED_ZONE_TEXT_ID = 155;

	[Token(Token = "0x400F91E")]
	public const int SELECT_SIMPLE_TEXT_ID = 591;

	[Token(Token = "0x400F928")]
	[FieldOffset(Offset = "0x128")]
	public int attackedMonster;

	[Token(Token = "0x400F929")]
	[FieldOffset(Offset = "0x12C")]
	public bool autoAttack;

	[Token(Token = "0x400F930")]
	[FieldOffset(Offset = "0x13C")]
	private Engine.StepType m_BPStep;

	[Token(Token = "0x400F931")]
	[FieldOffset(Offset = "0x140")]
	private Engine.DmgStepType m_DMGStep;

	[Token(Token = "0x400F932")]
	[FieldOffset(Offset = "0x148")]
	public int[,] tmpFacedCard;

	[Token(Token = "0x400F933")]
	[FieldOffset(Offset = "0x150")]
	private float localLeftTime;

	[Token(Token = "0x400F934")]
	[FieldOffset(Offset = "0x154")]
	private float localTotalTime;

	[Token(Token = "0x400F935")]
	[FieldOffset(Offset = "0x158")]
	private float localTurn;

	[Token(Token = "0x400F936")]
	[FieldOffset(Offset = "0x15C")]
	private Engine.Phase localPhase;

	[Token(Token = "0x400F940")]
	[FieldOffset(Offset = "0x198")]
	private bool cardHappenTaskEnable;

	[Token(Token = "0x400F941")]
	[FieldOffset(Offset = "0x1A0")]
	public SelectingCursorManager selCursorMan;

	[Token(Token = "0x400F946")]
	[FieldOffset(Offset = "0x1C0")]
	private AttackTargetingOperation attackTargetingOperation;

	[Token(Token = "0x400F965")]
	[FieldOffset(Offset = "0x286")]
	private bool inputBlockActivated;

	[Token(Token = "0x400F966")]
	[FieldOffset(Offset = "0x287")]
	private bool screenEffectBlockForGamePad;

	[Token(Token = "0x400F967")]
	[FieldOffset(Offset = "0x288")]
	private bool screenEffectBlockForScreenInput;

	[Token(Token = "0x400F96F")]
	[FieldOffset(Offset = "0x2B8")]
	private List<ZoneCard> zoneCardNearGraveIn;

	[Token(Token = "0x400F970")]
	[FieldOffset(Offset = "0x2C0")]
	private ZoneCard zoneCardNearGraveOut;

	[Token(Token = "0x400F971")]
	[FieldOffset(Offset = "0x2C8")]
	private List<ZoneCard> zoneCardNearExcludeIn;

	[Token(Token = "0x400F972")]
	[FieldOffset(Offset = "0x2D0")]
	private ZoneCard zoneCardNearExcludeOut;

	[Token(Token = "0x400F973")]
	[FieldOffset(Offset = "0x2D8")]
	private List<ZoneCard> zoneCardFarGraveIn;

	[Token(Token = "0x400F974")]
	[FieldOffset(Offset = "0x2E0")]
	private ZoneCard zoneCardFarGraveOut;

	[Token(Token = "0x400F975")]
	[FieldOffset(Offset = "0x2E8")]
	private List<ZoneCard> zoneCardFarExcludeIn;

	[Token(Token = "0x400F976")]
	[FieldOffset(Offset = "0x2F0")]
	private ZoneCard zoneCardFarExcludeOut;

	[Token(Token = "0x400F97C")]
	[FieldOffset(Offset = "0x318")]
	private bool preparedToDuel;

	[Token(Token = "0x400F97D")]
	[FieldOffset(Offset = "0x319")]
	private bool _isTerminated;

	[Token(Token = "0x17001AF4")]
	public List<Engine.ViewType> busyEffectList
	{
		[Token(Token = "0x600B110")]
		[Address(RVA = "0x3D8370", Offset = "0x3D7570", VA = "0x1803D8370")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x600B111")]
		[Address(RVA = "0x3D8380", Offset = "0x3D7580", VA = "0x1803D8380")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17001AF5")]
	public int runEffectParamsCount
	{
		[Token(Token = "0x600B112")]
		[Address(RVA = "0x49BE50", Offset = "0x49B050", VA = "0x18049BE50")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17001AF6")]
	public Engine.ViewType currentViewType
	{
		[Token(Token = "0x600B113")]
		[Address(RVA = "0x49B840", Offset = "0x49AA40", VA = "0x18049B840")]
		[CompilerGenerated]
		get
		{
			return default(Engine.ViewType);
		}
		[Token(Token = "0x600B114")]
		[Address(RVA = "0x49C0C0", Offset = "0x49B2C0", VA = "0x18049C0C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17001AF7")]
	public DuelAcslInfo duelAcslInfo
	{
		[Token(Token = "0x600B115")]
		[Address(RVA = "0x49B8F0", Offset = "0x49AAF0", VA = "0x18049B8F0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001AF8")]
	public DuelRuleSetInfo duelRuleSetInfo
	{
		[Token(Token = "0x600B116")]
		[Address(RVA = "0x49B970", Offset = "0x49AB70", VA = "0x18049B970")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001AF9")]
	public bool isInputViewType
	{
		[Token(Token = "0x600B118")]
		[Address(RVA = "0x49BB50", Offset = "0x49AD50", VA = "0x18049BB50")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17001AFA")]
	public Engine.ViewType prevViewType
	{
		[Token(Token = "0x600B119")]
		[Address(RVA = "0x49BDB0", Offset = "0x49AFB0", VA = "0x18049BDB0")]
		[CompilerGenerated]
		get
		{
			return default(Engine.ViewType);
		}
		[Token(Token = "0x600B11A")]
		[Address(RVA = "0x49C4C0", Offset = "0x49B6C0", VA = "0x18049C4C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17001AFB")]
	public int prevViewParam1
	{
		[Token(Token = "0x600B11B")]
		[Address(RVA = "0x49BD80", Offset = "0x49AF80", VA = "0x18049BD80")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Token(Token = "0x600B11C")]
		[Address(RVA = "0x49C490", Offset = "0x49B690", VA = "0x18049C490")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17001AFC")]
	public int prevViewParam2
	{
		[Token(Token = "0x600B11D")]
		[Address(RVA = "0x49BD90", Offset = "0x49AF90", VA = "0x18049BD90")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Token(Token = "0x600B11E")]
		[Address(RVA = "0x49C4A0", Offset = "0x49B6A0", VA = "0x18049C4A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17001AFD")]
	public int prevViewParam3
	{
		[Token(Token = "0x600B11F")]
		[Address(RVA = "0x49BDA0", Offset = "0x49AFA0", VA = "0x18049BDA0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Token(Token = "0x600B120")]
		[Address(RVA = "0x49C4B0", Offset = "0x49B6B0", VA = "0x18049C4B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17001AFE")]
	public DuelGameObjectManager goManager
	{
		[Token(Token = "0x600B121")]
		[Address(RVA = "0x49B9F0", Offset = "0x49ABF0", VA = "0x18049B9F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x600B122")]
		[Address(RVA = "0x49C1F0", Offset = "0x49B3F0", VA = "0x18049C1F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17001AFF")]
	public DuelHUD duelHUD
	{
		[Token(Token = "0x600B123")]
		[Address(RVA = "0x49B930", Offset = "0x49AB30", VA = "0x18049B930")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001B00")]
	public bool selectAttacked
	{
		[Token(Token = "0x600B124")]
		[Address(RVA = "0x49BE90", Offset = "0x49B090", VA = "0x18049BE90")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600B125")]
		[Address(RVA = "0x49C580", Offset = "0x49B780", VA = "0x18049C580")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17001B01")]
	public DuelOkDialog okDialog
	{
		[Token(Token = "0x600B126")]
		[Address(RVA = "0x49BD10", Offset = "0x49AF10", VA = "0x18049BD10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x600B127")]
		[Address(RVA = "0x4573F0", Offset = "0x4565F0", VA = "0x1804573F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17001B02")]
	public DuelConfirmDialog confirmDialog
	{
		[Token(Token = "0x600B128")]
		[Address(RVA = "0x49B7F0", Offset = "0x49A9F0", VA = "0x18049B7F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x600B129")]
		[Address(RVA = "0x457400", Offset = "0x456600", VA = "0x180457400")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17001B03")]
	public DuelSelectDialog selectDialog
	{
		[Token(Token = "0x600B12A")]
		[Address(RVA = "0x49BEA0", Offset = "0x49B0A0", VA = "0x18049BEA0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x600B12B")]
		[Address(RVA = "0x457410", Offset = "0x456610", VA = "0x180457410")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17001B04")]
	public DuelPullDownDialog pullDownDialog
	{
		[Token(Token = "0x600B12C")]
		[Address(RVA = "0x49BDC0", Offset = "0x49AFC0", VA = "0x18049BDC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x600B12D")]
		[Address(RVA = "0x4989A0", Offset = "0x497BA0", VA = "0x1804989A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17001B05")]
	public DuelDiceDialog diceDialog
	{
		[Token(Token = "0x600B12E")]
		[Address(RVA = "0x49B870", Offset = "0x49AA70", VA = "0x18049B870")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x600B12F")]
		[Address(RVA = "0x42FFD0", Offset = "0x42F1D0", VA = "0x18042FFD0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17001B06")]
	public DuelCoinDialog coinDialog
	{
		[Token(Token = "0x600B130")]
		[Address(RVA = "0x49B7D0", Offset = "0x49A9D0", VA = "0x18049B7D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x600B131")]
		[Address(RVA = "0x42FF10", Offset = "0x42F110", VA = "0x18042FF10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17001B07")]
	public DuelRitualDialog ritualDialog
	{
		[Token(Token = "0x600B132")]
		[Address(RVA = "0x49BDF0", Offset = "0x49AFF0", VA = "0x18049BDF0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x600B133")]
		[Address(RVA = "0x42FF30", Offset = "0x42F130", VA = "0x18042FF30")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17001B08")]
	public InstantMessage instantMessage
	{
		[Token(Token = "0x600B134")]
		[Address(RVA = "0x49BB20", Offset = "0x49AD20", VA = "0x18049BB20")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x600B135")]
		[Address(RVA = "0x42FF50", Offset = "0x42F150", VA = "0x18042FF50")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17001B09")]
	public ChoiceFirstPlayerDialog choiceFirstPlayer
	{
		[Token(Token = "0x600B136")]
		[Address(RVA = "0x49B7C0", Offset = "0x49A9C0", VA = "0x18049B7C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x600B137")]
		[Address(RVA = "0x42FF70", Offset = "0x42F170", VA = "0x18042FF70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17001B0A")]
	public InstantCardDisplay instantCardDisplay
	{
		[Token(Token = "0x600B138")]
		[Address(RVA = "0x49BB10", Offset = "0x49AD10", VA = "0x18049BB10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x600B139")]
		[Address(RVA = "0x3DAE90", Offset = "0x3DA090", VA = "0x1803DAE90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17001B0B")]
	public DuelInfoDialog infoDialog
	{
		[Token(Token = "0x600B13A")]
		[Address(RVA = "0x49BAD0", Offset = "0x49ACD0", VA = "0x18049BAD0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x600B13B")]
		[Address(RVA = "0x42FF90", Offset = "0x42F190", VA = "0x18042FF90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17001B0C")]
	public bool fieldViewing
	{
		[Token(Token = "0x600B13C")]
		[Address(RVA = "0x49B9D0", Offset = "0x49ABD0", VA = "0x18049B9D0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600B13D")]
		[Address(RVA = "0x49C1C0", Offset = "0x49B3C0", VA = "0x18049C1C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17001B0D")]
	public override bool isInitialized
	{
		[Token(Token = "0x600B13E")]
		[Address(RVA = "0x49BB40", Offset = "0x49AD40", VA = "0x18049BB40", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17001B0E")]
	private bool inputting
	{
		[Token(Token = "0x600B13F")]
		[Address(RVA = "0x49BB00", Offset = "0x49AD00", VA = "0x18049BB00")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600B140")]
		[Address(RVA = "0x49C230", Offset = "0x49B430", VA = "0x18049C230")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x17001B0F")]
	public bool isInputing
	{
		[Token(Token = "0x600B141")]
		[Address(RVA = "0x49BB00", Offset = "0x49AD00", VA = "0x18049BB00")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17001B10")]
	private string infoMessage
	{
		[Token(Token = "0x600B142")]
		[Address(RVA = "0x49BAE0", Offset = "0x49ACE0", VA = "0x18049BAE0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x600B143")]
		[Address(RVA = "0x49C200", Offset = "0x49B400", VA = "0x18049C200")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x17001B11")]
	public bool blockAutoSurrener
	{
		[Token(Token = "0x600B144")]
		[Address(RVA = "0x49B790", Offset = "0x49A990", VA = "0x18049B790")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600B145")]
		[Address(RVA = "0x49C010", Offset = "0x49B210", VA = "0x18049C010")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x17001B12")]
	public bool autoSurrendered
	{
		[Token(Token = "0x600B146")]
		[Address(RVA = "0x49B740", Offset = "0x49A940", VA = "0x18049B740")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600B147")]
		[Address(RVA = "0x49BFC0", Offset = "0x49B1C0", VA = "0x18049BFC0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x17001B13")]
	public bool isRetryRequired
	{
		[Token(Token = "0x600B148")]
		[Address(RVA = "0x49BBE0", Offset = "0x49ADE0", VA = "0x18049BBE0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600B149")]
		[Address(RVA = "0x49C2B0", Offset = "0x49B4B0", VA = "0x18049C2B0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x17001B14")]
	public bool isDuelLiveContinuousRequired
	{
		[Token(Token = "0x600B14A")]
		[Address(RVA = "0x49BB30", Offset = "0x49AD30", VA = "0x18049BB30")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600B14B")]
		[Address(RVA = "0x49C240", Offset = "0x49B440", VA = "0x18049C240")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x17001B15")]
	public bool playingPhaseChangeEffect
	{
		[Token(Token = "0x600B14C")]
		[Address(RVA = "0x49BD50", Offset = "0x49AF50", VA = "0x18049BD50")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600B14D")]
		[Address(RVA = "0x49C460", Offset = "0x49B660", VA = "0x18049C460")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x17001B16")]
	public bool duelOver
	{
		[Token(Token = "0x600B14E")]
		[Address(RVA = "0x49B960", Offset = "0x49AB60", VA = "0x18049B960")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600B14F")]
		[Address(RVA = "0x49C180", Offset = "0x49B380", VA = "0x18049C180")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x17001B17")]
	public Engine.MenuActType currentActType
	{
		[Token(Token = "0x600B150")]
		[Address(RVA = "0x3F4B30", Offset = "0x3F3D30", VA = "0x1803F4B30")]
		[CompilerGenerated]
		get
		{
			return default(Engine.MenuActType);
		}
		[Token(Token = "0x600B151")]
		[Address(RVA = "0x3F4B40", Offset = "0x3F3D40", VA = "0x1803F4B40")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17001B18")]
	public CountDialogType currentCountDialog
	{
		[Token(Token = "0x600B152")]
		[Address(RVA = "0x49B800", Offset = "0x49AA00", VA = "0x18049B800")]
		[CompilerGenerated]
		get
		{
			return default(CountDialogType);
		}
		[Token(Token = "0x600B153")]
		[Address(RVA = "0x49C080", Offset = "0x49B280", VA = "0x18049C080")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x17001B19")]
	public bool discardReady
	{
		[Token(Token = "0x600B154")]
		[Address(RVA = "0x49B880", Offset = "0x49AA80", VA = "0x18049B880")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600B155")]
		[Address(RVA = "0x49C100", Offset = "0x49B300", VA = "0x18049C100")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x17001B1A")]
	public int discardRemain
	{
		[Token(Token = "0x600B156")]
		[Address(RVA = "0x49B890", Offset = "0x49AA90", VA = "0x18049B890")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Token(Token = "0x600B157")]
		[Address(RVA = "0x49C110", Offset = "0x49B310", VA = "0x18049C110")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x17001B1B")]
	public string discardMessage
	{
		[Token(Token = "0x600B158")]
		[Address(RVA = "0x3DA790", Offset = "0x3D9990", VA = "0x1803DA790")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x600B159")]
		[Address(RVA = "0x3DA7A0", Offset = "0x3D99A0", VA = "0x1803DA7A0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x17001B1C")]
	public int totalLevel
	{
		[Token(Token = "0x600B15A")]
		[Address(RVA = "0x49BF20", Offset = "0x49B120", VA = "0x18049BF20")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Token(Token = "0x600B15B")]
		[Address(RVA = "0x49C660", Offset = "0x49B860", VA = "0x18049C660")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x17001B1D")]
	public int ritualRemain
	{
		[Token(Token = "0x600B15C")]
		[Address(RVA = "0x49BE10", Offset = "0x49B010", VA = "0x18049BE10")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Token(Token = "0x600B15D")]
		[Address(RVA = "0x49C520", Offset = "0x49B720", VA = "0x18049C520")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x17001B1E")]
	public int dlgTextId
	{
		[Token(Token = "0x600B15E")]
		[Address(RVA = "0x49B8A0", Offset = "0x49AAA0", VA = "0x18049B8A0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Token(Token = "0x600B15F")]
		[Address(RVA = "0x49C120", Offset = "0x49B320", VA = "0x18049C120")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x17001B1F")]
	public Engine.DialogRitualType ritualType
	{
		[Token(Token = "0x600B160")]
		[Address(RVA = "0x49BE20", Offset = "0x49B020", VA = "0x18049BE20")]
		[CompilerGenerated]
		get
		{
			return default(Engine.DialogRitualType);
		}
		[Token(Token = "0x600B161")]
		[Address(RVA = "0x49C530", Offset = "0x49B730", VA = "0x18049C530")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x17001B20")]
	public int lastDialogTextId
	{
		[Token(Token = "0x600B162")]
		[Address(RVA = "0x49BC50", Offset = "0x49AE50", VA = "0x18049BC50")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Token(Token = "0x600B163")]
		[Address(RVA = "0x49C320", Offset = "0x49B520", VA = "0x18049C320")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x17001B21")]
	public int lastYesNoDialogEffectTextid
	{
		[Token(Token = "0x600B164")]
		[Address(RVA = "0x49BC70", Offset = "0x49AE70", VA = "0x18049BC70")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Token(Token = "0x600B165")]
		[Address(RVA = "0x49C340", Offset = "0x49B540", VA = "0x18049C340")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x17001B22")]
	public bool openCardInfoRByEffectIdFlag
	{
		[Token(Token = "0x600B166")]
		[Address(RVA = "0x49BD20", Offset = "0x49AF20", VA = "0x18049BD20")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600B167")]
		[Address(RVA = "0x49C410", Offset = "0x49B610", VA = "0x18049C410")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x17001B23")]
	public bool isNextInfoContinuousTrapEffect
	{
		[Token(Token = "0x600B168")]
		[Address(RVA = "0x49BBA0", Offset = "0x49ADA0", VA = "0x18049BBA0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600B169")]
		[Address(RVA = "0x49C280", Offset = "0x49B480", VA = "0x18049C280")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x17001B24")]
	public bool dlgTypeOkResult
	{
		[Token(Token = "0x600B16A")]
		[Address(RVA = "0x49B8B0", Offset = "0x49AAB0", VA = "0x18049B8B0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600B16B")]
		[Address(RVA = "0x49C130", Offset = "0x49B330", VA = "0x18049C130")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x17001B25")]
	public bool surrendered
	{
		[Token(Token = "0x600B16C")]
		[Address(RVA = "0x49BF00", Offset = "0x49B100", VA = "0x18049BF00")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600B16D")]
		[Address(RVA = "0x49C630", Offset = "0x49B830", VA = "0x18049C630")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17001B26")]
	public bool duelStart
	{
		[Token(Token = "0x600B16E")]
		[Address(RVA = "0x49B9B0", Offset = "0x49ABB0", VA = "0x18049B9B0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600B16F")]
		[Address(RVA = "0x49C190", Offset = "0x49B390", VA = "0x18049C190")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x17001B27")]
	private Dictionary<int, int> lp
	{
		[Token(Token = "0x600B170")]
		[Address(RVA = "0x49BCF0", Offset = "0x49AEF0", VA = "0x18049BCF0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x600B171")]
		[Address(RVA = "0x49C3D0", Offset = "0x49B5D0", VA = "0x18049C3D0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x17001B28")]
	private Dictionary<int, int> lpMin
	{
		[Token(Token = "0x600B172")]
		[Address(RVA = "0x49BCE0", Offset = "0x49AEE0", VA = "0x18049BCE0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x600B173")]
		[Address(RVA = "0x49C3B0", Offset = "0x49B5B0", VA = "0x18049C3B0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x17001B29")]
	public int battleSrcPlayer
	{
		[Token(Token = "0x600B174")]
		[Address(RVA = "0x49B770", Offset = "0x49A970", VA = "0x18049B770")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Token(Token = "0x600B175")]
		[Address(RVA = "0x49BFF0", Offset = "0x49B1F0", VA = "0x18049BFF0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x17001B2A")]
	public int battleSrcPosition
	{
		[Token(Token = "0x600B176")]
		[Address(RVA = "0x49B780", Offset = "0x49A980", VA = "0x18049B780")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Token(Token = "0x600B177")]
		[Address(RVA = "0x49C000", Offset = "0x49B200", VA = "0x18049C000")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x17001B2B")]
	public int battleDstPlayer
	{
		[Token(Token = "0x600B178")]
		[Address(RVA = "0x49B750", Offset = "0x49A950", VA = "0x18049B750")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Token(Token = "0x600B179")]
		[Address(RVA = "0x49BFD0", Offset = "0x49B1D0", VA = "0x18049BFD0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x17001B2C")]
	public int battleDstPosition
	{
		[Token(Token = "0x600B17A")]
		[Address(RVA = "0x49B760", Offset = "0x49A960", VA = "0x18049B760")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Token(Token = "0x600B17B")]
		[Address(RVA = "0x49BFE0", Offset = "0x49B1E0", VA = "0x18049BFE0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x17001B2D")]
	public Vector3 attackDirection
	{
		[Token(Token = "0x600B17C")]
		[Address(RVA = "0x49B710", Offset = "0x49A910", VA = "0x18049B710")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Token(Token = "0x600B17D")]
		[Address(RVA = "0x49BF90", Offset = "0x49B190", VA = "0x18049BF90")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x17001B2E")]
	public Engine.CutinSummonType cutinSummonType
	{
		[Token(Token = "0x600B17E")]
		[Address(RVA = "0x49B850", Offset = "0x49AA50", VA = "0x18049B850")]
		[CompilerGenerated]
		get
		{
			return default(Engine.CutinSummonType);
		}
		[Token(Token = "0x600B17F")]
		[Address(RVA = "0x49C0D0", Offset = "0x49B2D0", VA = "0x18049C0D0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x17001B2F")]
	public int currentSelectingPlayer
	{
		[Token(Token = "0x600B180")]
		[Address(RVA = "0x49B820", Offset = "0x49AA20", VA = "0x18049B820")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Token(Token = "0x600B181")]
		[Address(RVA = "0x49C0A0", Offset = "0x49B2A0", VA = "0x18049C0A0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x17001B30")]
	public int currentSelectingPosition
	{
		[Token(Token = "0x600B182")]
		[Address(RVA = "0x49B830", Offset = "0x49AA30", VA = "0x18049B830")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Token(Token = "0x600B183")]
		[Address(RVA = "0x49C0B0", Offset = "0x49B2B0", VA = "0x18049C0B0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x17001B31")]
	public int currentSelectingIndex
	{
		[Token(Token = "0x600B184")]
		[Address(RVA = "0x49B810", Offset = "0x49AA10", VA = "0x18049B810")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Token(Token = "0x600B185")]
		[Address(RVA = "0x49C090", Offset = "0x49B290", VA = "0x18049C090")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x17001B32")]
	public SelectionZoneIconController selectionZoneIcon
	{
		[Token(Token = "0x600B186")]
		[Address(RVA = "0x49BEC0", Offset = "0x49B0C0", VA = "0x18049BEC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x600B187")]
		[Address(RVA = "0x49C5B0", Offset = "0x49B7B0", VA = "0x18049C5B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17001B33")]
	public CommandOperation commandOperation
	{
		[Token(Token = "0x600B188")]
		[Address(RVA = "0x49B7E0", Offset = "0x49A9E0", VA = "0x18049B7E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x600B189")]
		[Address(RVA = "0x49C060", Offset = "0x49B260", VA = "0x18049C060")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17001B34")]
	public DecideOperation decideOperation
	{
		[Token(Token = "0x600B18A")]
		[Address(RVA = "0x49B860", Offset = "0x49AA60", VA = "0x18049B860")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x600B18B")]
		[Address(RVA = "0x49C0E0", Offset = "0x49B2E0", VA = "0x18049C0E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17001B35")]
	public SelectStandOperation selectStandOperation
	{
		[Token(Token = "0x600B18C")]
		[Address(RVA = "0x49BEB0", Offset = "0x49B0B0", VA = "0x18049BEB0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x600B18D")]
		[Address(RVA = "0x49C590", Offset = "0x49B790", VA = "0x18049C590")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17001B36")]
	public PhaseSelect3D phaseSelect
	{
		[Token(Token = "0x600B18E")]
		[Address(RVA = "0x3F2280", Offset = "0x3F1480", VA = "0x1803F2280")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x600B18F")]
		[Address(RVA = "0x3F2450", Offset = "0x3F1650", VA = "0x1803F2450")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17001B37")]
	public FusionEffect fusionEffect
	{
		[Token(Token = "0x600B190")]
		[Address(RVA = "0x3F22A0", Offset = "0x3F14A0", VA = "0x1803F22A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x600B191")]
		[Address(RVA = "0x3F2480", Offset = "0x3F1680", VA = "0x1803F2480")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17001B38")]
	public XyzEffect xyzEffect
	{
		[Token(Token = "0x600B192")]
		[Address(RVA = "0x49BF40", Offset = "0x49B140", VA = "0x18049BF40")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x600B193")]
		[Address(RVA = "0x49C690", Offset = "0x49B890", VA = "0x18049C690")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17001B39")]
	public LinkEffect linkEffect
	{
		[Token(Token = "0x600B194")]
		[Address(RVA = "0x49BCD0", Offset = "0x49AED0", VA = "0x18049BCD0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x600B195")]
		[Address(RVA = "0x49C390", Offset = "0x49B590", VA = "0x18049C390")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17001B3A")]
	public SynchroEffect synchroEffect
	{
		[Token(Token = "0x600B196")]
		[Address(RVA = "0x49BF10", Offset = "0x49B110", VA = "0x18049BF10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x600B197")]
		[Address(RVA = "0x49C640", Offset = "0x49B840", VA = "0x18049C640")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17001B3B")]
	public RitualEffect ritualEffect
	{
		[Token(Token = "0x600B198")]
		[Address(RVA = "0x49BE00", Offset = "0x49B000", VA = "0x18049BE00")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x600B199")]
		[Address(RVA = "0x49C500", Offset = "0x49B700", VA = "0x18049C500")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17001B3C")]
	public PendulumEffect pendulumEffect
	{
		[Token(Token = "0x600B19A")]
		[Address(RVA = "0x49BD30", Offset = "0x49AF30", VA = "0x18049BD30")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x600B19B")]
		[Address(RVA = "0x49C420", Offset = "0x49B620", VA = "0x18049C420")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17001B3D")]
	public PendulumReadyEffect pendulumReadyEffect
	{
		[Token(Token = "0x600B19C")]
		[Address(RVA = "0x49BD40", Offset = "0x49AF40", VA = "0x18049BD40")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x600B19D")]
		[Address(RVA = "0x49C440", Offset = "0x49B640", VA = "0x18049C440")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17001B3E")]
	public MonsterCutinEffect monsterCutinEffect
	{
		[Token(Token = "0x600B19E")]
		[Address(RVA = "0x49BD00", Offset = "0x49AF00", VA = "0x18049BD00")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x600B19F")]
		[Address(RVA = "0x49C3F0", Offset = "0x49B5F0", VA = "0x18049C3F0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x17001B3F")]
	public CardMoveEffectBase cardMoveEffect
	{
		[Token(Token = "0x600B1A0")]
		[Address(RVA = "0x49B7A0", Offset = "0x49A9A0", VA = "0x18049B7A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x600B1A1")]
		[Address(RVA = "0x49C020", Offset = "0x49B220", VA = "0x18049C020")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x17001B40")]
	public RunCoin runCoin
	{
		[Token(Token = "0x600B1A2")]
		[Address(RVA = "0x49BE30", Offset = "0x49B030", VA = "0x18049BE30")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x600B1A3")]
		[Address(RVA = "0x49C540", Offset = "0x49B740", VA = "0x18049C540")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x17001B41")]
	public RunDice runDice
	{
		[Token(Token = "0x600B1A4")]
		[Address(RVA = "0x49BE40", Offset = "0x49B040", VA = "0x18049BE40")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x600B1A5")]
		[Address(RVA = "0x49C560", Offset = "0x49B760", VA = "0x18049C560")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x17001B42")]
	public ResidualEffect residualEffect
	{
		[Token(Token = "0x600B1A6")]
		[Address(RVA = "0x49BDE0", Offset = "0x49AFE0", VA = "0x18049BDE0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x600B1A7")]
		[Address(RVA = "0x49C4E0", Offset = "0x49B6E0", VA = "0x18049C4E0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x17001B43")]
	public DuelChainManager chainManager
	{
		[Token(Token = "0x600B1A8")]
		[Address(RVA = "0x49B7B0", Offset = "0x49A9B0", VA = "0x18049B7B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x600B1A9")]
		[Address(RVA = "0x49C040", Offset = "0x49B240", VA = "0x18049C040")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17001B44")]
	public bool isPlayingMonsterCutin
	{
		[Token(Token = "0x600B1AA")]
		[Address(RVA = "0x49BBB0", Offset = "0x49ADB0", VA = "0x18049BBB0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600B1AB")]
		[Address(RVA = "0x49C290", Offset = "0x49B490", VA = "0x18049C290")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x17001B45")]
	public bool isMonsterCutinDone
	{
		[Token(Token = "0x600B1AC")]
		[Address(RVA = "0x49BB90", Offset = "0x49AD90", VA = "0x18049BB90")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600B1AD")]
		[Address(RVA = "0x49C270", Offset = "0x49B470", VA = "0x18049C270")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x17001B46")]
	public bool isMonsterCutinDoneTurn2
	{
		[Token(Token = "0x600B1AE")]
		[Address(RVA = "0x49BB80", Offset = "0x49AD80", VA = "0x18049BB80")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600B1AF")]
		[Address(RVA = "0x49C260", Offset = "0x49B460", VA = "0x18049C260")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x17001B47")]
	public bool isMaximumWaitFinish
	{
		[Token(Token = "0x600B1B0")]
		[Address(RVA = "0x49BB70", Offset = "0x49AD70", VA = "0x18049BB70")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600B1B1")]
		[Address(RVA = "0x49C250", Offset = "0x49B450", VA = "0x18049C250")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x17001B48")]
	public PlayerselfInfo<bool> isSpSummonFromExDeck
	{
		[Token(Token = "0x600B1B2")]
		[Address(RVA = "0x49BC10", Offset = "0x49AE10", VA = "0x18049BC10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x600B1B3")]
		[Address(RVA = "0x49C2C0", Offset = "0x49B4C0", VA = "0x18049C2C0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x17001B49")]
	public PlayerselfInfo<bool> kagari
	{
		[Token(Token = "0x600B1B4")]
		[Address(RVA = "0x49BC30", Offset = "0x49AE30", VA = "0x18049BC30")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x600B1B5")]
		[Address(RVA = "0x49C2F0", Offset = "0x49B4F0", VA = "0x18049C2F0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x17001B4A")]
	public PlayerselfInfo<bool> equiped
	{
		[Token(Token = "0x600B1B6")]
		[Address(RVA = "0x49B9C0", Offset = "0x49ABC0", VA = "0x18049B9C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x600B1B7")]
		[Address(RVA = "0x49C1A0", Offset = "0x49B3A0", VA = "0x18049C1A0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x17001B4B")]
	public PlayerselfInfo<bool> turnChange
	{
		[Token(Token = "0x600B1B8")]
		[Address(RVA = "0x49BF30", Offset = "0x49B130", VA = "0x18049BF30")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x600B1B9")]
		[Address(RVA = "0x49C670", Offset = "0x49B870", VA = "0x18049C670")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x17001B4C")]
	public int lastCardID
	{
		[Token(Token = "0x600B1BA")]
		[Address(RVA = "0x49BC40", Offset = "0x49AE40", VA = "0x18049BC40")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Token(Token = "0x600B1BB")]
		[Address(RVA = "0x49C310", Offset = "0x49B510", VA = "0x18049C310")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x17001B4D")]
	public int lastUniqueID
	{
		[Token(Token = "0x600B1BC")]
		[Address(RVA = "0x49BC60", Offset = "0x49AE60", VA = "0x18049BC60")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Token(Token = "0x600B1BD")]
		[Address(RVA = "0x49C330", Offset = "0x49B530", VA = "0x18049C330")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x17001B4E")]
	private int attackerUniqueID
	{
		[Token(Token = "0x600B1BE")]
		[Address(RVA = "0x49B730", Offset = "0x49A930", VA = "0x18049B730")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Token(Token = "0x600B1BF")]
		[Address(RVA = "0x49BFB0", Offset = "0x49B1B0", VA = "0x18049BFB0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x17001B4F")]
	public bool reqFinalBlow
	{
		[Token(Token = "0x600B1C0")]
		[Address(RVA = "0x49BDD0", Offset = "0x49AFD0", VA = "0x18049BDD0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600B1C1")]
		[Address(RVA = "0x49C4D0", Offset = "0x49B6D0", VA = "0x18049C4D0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x17001B50")]
	public bool inputAvailable
	{
		[Token(Token = "0x600B1C2")]
		[Address(RVA = "0x49BAF0", Offset = "0x49ACF0", VA = "0x18049BAF0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600B1C3")]
		[Address(RVA = "0x49C220", Offset = "0x49B420", VA = "0x18049C220")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x17001B51")]
	public bool isPlayingScreenEffect
	{
		[Token(Token = "0x600B1C4")]
		[Address(RVA = "0x49BBC0", Offset = "0x49ADC0", VA = "0x18049BBC0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600B1C5")]
		[Address(RVA = "0x49C2A0", Offset = "0x49B4A0", VA = "0x18049C2A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17001B52")]
	public FinalBlowEffect finalBlow
	{
		[Token(Token = "0x600B1C6")]
		[Address(RVA = "0x49B9E0", Offset = "0x49ABE0", VA = "0x18049B9E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x600B1C7")]
		[Address(RVA = "0x49C1D0", Offset = "0x49B3D0", VA = "0x18049C1D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17001B53")]
	public LethalEffect lethalEffect
	{
		[Token(Token = "0x600B1C8")]
		[Address(RVA = "0x49BCC0", Offset = "0x49AEC0", VA = "0x18049BCC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x600B1C9")]
		[Address(RVA = "0x49C370", Offset = "0x49B570", VA = "0x18049C370")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17001B54")]
	public bool lethalEffectPlayed
	{
		[Token(Token = "0x600B1CA")]
		[Address(RVA = "0x49BCA0", Offset = "0x49AEA0", VA = "0x18049BCA0")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17001B55")]
	public bool lethalEffectPlayedMyself
	{
		[Token(Token = "0x600B1CB")]
		[Address(RVA = "0x49BC80", Offset = "0x49AE80", VA = "0x18049BC80")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600B1CC")]
		[Address(RVA = "0x49C350", Offset = "0x49B550", VA = "0x18049C350")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17001B56")]
	public bool lethalEffectPlayedRival
	{
		[Token(Token = "0x600B1CD")]
		[Address(RVA = "0x49BC90", Offset = "0x49AE90", VA = "0x18049BC90")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600B1CE")]
		[Address(RVA = "0x49C360", Offset = "0x49B560", VA = "0x18049C360")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17001B57")]
	public SpecialWinBase specialWinEffect
	{
		[Token(Token = "0x600B1CF")]
		[Address(RVA = "0x49BEE0", Offset = "0x49B0E0", VA = "0x18049BEE0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x600B1D0")]
		[Address(RVA = "0x49C5F0", Offset = "0x49B7F0", VA = "0x18049C5F0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x17001B58")]
	public DrawOperation drawOperation
	{
		[Token(Token = "0x600B1D1")]
		[Address(RVA = "0x49B8E0", Offset = "0x49AAE0", VA = "0x18049B8E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x600B1D2")]
		[Address(RVA = "0x49C140", Offset = "0x49B340", VA = "0x18049C140")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x17001B59")]
	public bool drawOperationEnabled
	{
		[Token(Token = "0x600B1D3")]
		[Address(RVA = "0x49B8C0", Offset = "0x49AAC0", VA = "0x18049B8C0")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17001B5A")]
	public int preCardMoveFromPlayer
	{
		[Token(Token = "0x600B1D4")]
		[Address(RVA = "0x49BD60", Offset = "0x49AF60", VA = "0x18049BD60")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Token(Token = "0x600B1D5")]
		[Address(RVA = "0x49C470", Offset = "0x49B670", VA = "0x18049C470")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x17001B5B")]
	public int preCardMoveFromPosition
	{
		[Token(Token = "0x600B1D6")]
		[Address(RVA = "0x49BD70", Offset = "0x49AF70", VA = "0x18049BD70")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Token(Token = "0x600B1D7")]
		[Address(RVA = "0x49C480", Offset = "0x49B680", VA = "0x18049C480")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x17001B5C")]
	public DuelInfo duelInfo
	{
		[Token(Token = "0x600B1D8")]
		[Address(RVA = "0x49B950", Offset = "0x49AB50", VA = "0x18049B950")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x600B1D9")]
		[Address(RVA = "0x49C160", Offset = "0x49B360", VA = "0x18049C160")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17001B5D")]
	public Action sendChoiceFirstMessage
	{
		[Token(Token = "0x600B1DA")]
		[Address(RVA = "0x49BED0", Offset = "0x49B0D0", VA = "0x18049BED0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x600B1DB")]
		[Address(RVA = "0x49C5D0", Offset = "0x49B7D0", VA = "0x18049C5D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17001B5E")]
	public DuelSummonCountManager summonCountManager
	{
		[Token(Token = "0x600B1DC")]
		[Address(RVA = "0x49BEF0", Offset = "0x49B0F0", VA = "0x18049BEF0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x600B1DD")]
		[Address(RVA = "0x49C610", Offset = "0x49B810", VA = "0x18049C610")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17001B5F")]
	public override bool isPreparedToDuel
	{
		[Token(Token = "0x600B1E9")]
		[Address(RVA = "0x49BBD0", Offset = "0x49ADD0", VA = "0x18049BBD0", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17001B60")]
	public bool isShownUp
	{
		[Token(Token = "0x600B1EB")]
		[Address(RVA = "0x49BBF0", Offset = "0x49ADF0", VA = "0x18049BBF0")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17001B61")]
	public override bool isTerminated
	{
		[Token(Token = "0x600B1F4")]
		[Address(RVA = "0x49BC20", Offset = "0x49AE20", VA = "0x18049BC20", Slot = "10")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600B1F5")]
		[Address(RVA = "0x49C2E0", Offset = "0x49B4E0", VA = "0x18049C2E0", Slot = "11")]
		protected set
		{
		}
	}

	[Token(Token = "0x17001B62")]
	public bool iconVisible
	{
		[Token(Token = "0x600B26B")]
		[Address(RVA = "0x49BA00", Offset = "0x49AC00", VA = "0x18049BA00")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x600B117")]
	[Address(RVA = "0x48DCF0", Offset = "0x48CEF0", VA = "0x18048DCF0")]
	private void InitInfos()
	{
	}

	[Token(Token = "0x600B1DE")]
	[Address(RVA = "0x498F90", Offset = "0x498190", VA = "0x180498F90")]
	public RunEffectWorker(DuelClient host)
	{
	}

	[Token(Token = "0x600B1DF")]
	[Address(RVA = "0x48E000", Offset = "0x48D200", VA = "0x18048E000")]
	[IteratorStateMachine(typeof(_003CInitializeProcess_003Ed__458))]
	private IEnumerator InitializeProcess()
	{
		return null;
	}

	[Token(Token = "0x600B1E0")]
	[Address(RVA = "0x494910", Offset = "0x493B10", VA = "0x180494910", Slot = "6")]
	public override void PrepareToDuel()
	{
	}

	[Token(Token = "0x600B1E1")]
	[Address(RVA = "0x495D50", Offset = "0x494F50", VA = "0x180495D50")]
	public void SetGoManager(DuelGameObjectManager goManager)
	{
	}

	[Token(Token = "0x600B1E2")]
	[Address(RVA = "0x4948A0", Offset = "0x493AA0", VA = "0x1804948A0")]
	[IteratorStateMachine(typeof(_003CPrepareToDuelProcess_003Ed__461))]
	private IEnumerator PrepareToDuelProcess()
	{
		return null;
	}

	[Token(Token = "0x600B1E3")]
	[Address(RVA = "0x48ECC0", Offset = "0x48DEC0", VA = "0x18048ECC0")]
	private static Vector3 Multi(Vector3 a, Vector3 b)
	{
		return default(Vector3);
	}

	[Token(Token = "0x600B1E4")]
	[Address(RVA = "0x496AB0", Offset = "0x495CB0", VA = "0x180496AB0", Slot = "9")]
	public override void Terminate()
	{
	}

	[Token(Token = "0x600B1E5")]
	[Address(RVA = "0x491080", Offset = "0x490280", VA = "0x180491080", Slot = "12")]
	public override void OnDestroy()
	{
	}

	[Token(Token = "0x600B1E6")]
	[Address(RVA = "0x4927B0", Offset = "0x4919B0", VA = "0x1804927B0")]
	private void OnPreRunEffect(Engine.ViewType viewtype, int param1, int param2, int param3)
	{
	}

	[Token(Token = "0x600B1E7")]
	[Address(RVA = "0x492600", Offset = "0x491800", VA = "0x180492600")]
	private void OnPostRunEffect(Engine.ViewType viewtype, int param1, int param2, int param3)
	{
	}

	[Token(Token = "0x600B1E8")]
	[Address(RVA = "0x48E270", Offset = "0x48D470", VA = "0x18048E270", Slot = "14")]
	public override bool IsBusyEffect(Engine.ViewType viewType)
	{
		return default(bool);
	}

	[Token(Token = "0x600B1EA")]
	[Address(RVA = "0x496670", Offset = "0x495870", VA = "0x180496670")]
	public void ShowUpOnStartDuel(bool playEffect)
	{
	}

	[Token(Token = "0x600B1EC")]
	[Address(RVA = "0x48BDD0", Offset = "0x48AFD0", VA = "0x18048BDD0")]
	public void DispSelectingCursor(int team, int position, int index)
	{
	}

	[Token(Token = "0x600B1ED")]
	[Address(RVA = "0x48DC90", Offset = "0x48CE90", VA = "0x18048DC90")]
	public void HideSelectingCursor()
	{
	}

	[Token(Token = "0x600B1EE")]
	[Address(RVA = "0x494A90", Offset = "0x493C90", VA = "0x180494A90")]
	public void RefreshSelectingCursor()
	{
	}

	[Token(Token = "0x600B1EF")]
	[Address(RVA = "0x493E60", Offset = "0x493060", VA = "0x180493E60")]
	public void OpenPvpNoResponse()
	{
	}

	[Token(Token = "0x600B1F0")]
	[Address(RVA = "0x4949E0", Offset = "0x493BE0", VA = "0x1804949E0")]
	public void PvpResponsed()
	{
	}

	[Token(Token = "0x600B1F1")]
	[Address(RVA = "0x48B4A0", Offset = "0x48A6A0", VA = "0x18048B4A0")]
	public void ClosedPvpNoResponse()
	{
	}

	[Token(Token = "0x600B1F2")]
	[Address(RVA = "0x493C70", Offset = "0x492E70", VA = "0x180493C70")]
	private void OnUpdate()
	{
	}

	[Token(Token = "0x600B1F3")]
	[Address(RVA = "0x48C4C0", Offset = "0x48B6C0", VA = "0x18048C4C0")]
	private void ExecDuelStep()
	{
	}

	[Token(Token = "0x600B1F6")]
	[Address(RVA = "0x497A50", Offset = "0x496C50", VA = "0x180497A50")]
	private void TerminatingStep()
	{
	}

	[Token(Token = "0x600B1F7")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60")]
	private void FinishStep()
	{
	}

	[Token(Token = "0x600B1F8")]
	[Address(RVA = "0x48C270", Offset = "0x48B470", VA = "0x18048C270")]
	private void EnqueueTask(Engine.ViewType viewType, createDelegate createFunc, int param1, int param2, int param3)
	{
	}

	[Token(Token = "0x600B1F9")]
	[Address(RVA = "0x48C380", Offset = "0x48B580", VA = "0x18048C380")]
	private void EnqueueTask(Engine.ViewType viewType, preCreateDelegate preCreateFunc, createDelegateAdvanced createFuncAdvanced, int param1, int param2, int param3)
	{
	}

	[Token(Token = "0x600B1FA")]
	[Address(RVA = "0x48C1C0", Offset = "0x48B3C0", VA = "0x18048C1C0")]
	private void EnqueueTaskImpl(RunEffectParam runEffectParam)
	{
	}

	[Token(Token = "0x600B1FB")]
	[Address(RVA = "0x48BD30", Offset = "0x48AF30", VA = "0x18048BD30")]
	private void DequeueTask()
	{
	}

	[Token(Token = "0x600B1FC")]
	[Address(RVA = "0x4989D0", Offset = "0x497BD0", VA = "0x1804989D0")]
	private void UpdateBusyIds()
	{
	}

	[Token(Token = "0x600B1FD")]
	[Address(RVA = "0x494120", Offset = "0x493320", VA = "0x180494120")]
	private void PhaseChange(int param1, int param2, int param3)
	{
	}

	[Token(Token = "0x600B1FE")]
	[Address(RVA = "0x494110", Offset = "0x493310", VA = "0x180494110")]
	private void PhaseChangeMinimum(int param1, int param2, int param3)
	{
	}

	[Token(Token = "0x600B1FF")]
	[Address(RVA = "0x497F80", Offset = "0x497180", VA = "0x180497F80")]
	private void TurnChange(int param1, int param2, int param3)
	{
	}

	[Token(Token = "0x600B200")]
	[Address(RVA = "0x482430", Offset = "0x481630", VA = "0x180482430")]
	private void TurnChangeMinimum(int param1, int param2, int param3)
	{
	}

	[Token(Token = "0x600B201")]
	[Address(RVA = "0x48C040", Offset = "0x48B240", VA = "0x18048C040")]
	private void DuelStart(int param1, int param2, int param3)
	{
	}

	[Token(Token = "0x600B202")]
	[Address(RVA = "0x48C030", Offset = "0x48B230", VA = "0x18048C030")]
	private void DuelStartMinimum(int param1, int param2, int param3)
	{
	}

	[Token(Token = "0x600B203")]
	[Address(RVA = "0x48DD30", Offset = "0x48CF30", VA = "0x18048DD30")]
	public void InitializeOnDuelStart(bool playBGM, bool playEntryAnime)
	{
	}

	[Token(Token = "0x600B204")]
	[Address(RVA = "0x48BE00", Offset = "0x48B000", VA = "0x18048BE00")]
	private void DuelEnd(int param1, int param2, int param3)
	{
	}

	[Token(Token = "0x600B205")]
	[Address(RVA = "0x4898F0", Offset = "0x488AF0", VA = "0x1804898F0")]
	private void BattleAttack(int param1, int param2, int param3)
	{
	}

	[Token(Token = "0x600B206")]
	[Address(RVA = "0x4898E0", Offset = "0x488AE0", VA = "0x1804898E0")]
	private void BattleAttackMinimum(int param1, int param2, int param3)
	{
	}

	[Token(Token = "0x600B207")]
	[Address(RVA = "0x48E610", Offset = "0x48D810", VA = "0x18048E610")]
	private void LifeSet(int param1, int param2, int param3)
	{
	}

	[Token(Token = "0x600B208")]
	[Address(RVA = "0x48E600", Offset = "0x48D800", VA = "0x18048E600")]
	private void LifeSetMinimum(int param1, int param2, int param3)
	{
	}

	[Token(Token = "0x600B209")]
	[Address(RVA = "0x48E510", Offset = "0x48D710", VA = "0x18048E510")]
	private void LifeDamage(int param1, int param2, int param3)
	{
	}

	[Token(Token = "0x600B20A")]
	[Address(RVA = "0x48E500", Offset = "0x48D700", VA = "0x18048E500")]
	private void LifeDamageMinimum(int param1, int param2, int param3)
	{
	}

	[Token(Token = "0x600B20B")]
	[Address(RVA = "0x48ACB0", Offset = "0x489EB0", VA = "0x18048ACB0")]
	private void CardSet(int param1, int param2, int param3)
	{
	}

	[Token(Token = "0x600B20C")]
	[Address(RVA = "0x48A960", Offset = "0x489B60", VA = "0x18048A960")]
	private void CardIncTurn(int param1, int param2, int param3)
	{
	}

	[Token(Token = "0x600B20D")]
	[Address(RVA = "0x495190", Offset = "0x494390", VA = "0x180495190")]
	private void RunFusion(int param1, int param2, int param3)
	{
	}

	[Token(Token = "0x600B20E")]
	[Address(RVA = "0x48B710", Offset = "0x48A910", VA = "0x18048B710")]
	private void CutinDraw(int param1, int param2, int param3)
	{
	}

	[Token(Token = "0x600B20F")]
	[Address(RVA = "0x48B930", Offset = "0x48AB30", VA = "0x18048B930")]
	private void CutinSummon(int param1, int param2, int param3)
	{
	}

	[Token(Token = "0x600B210")]
	[Address(RVA = "0x48B560", Offset = "0x48A760", VA = "0x18048B560")]
	private void CutinActivate(int param1, int param2, int param3)
	{
	}

	[Token(Token = "0x600B211")]
	[Address(RVA = "0x48B550", Offset = "0x48A750", VA = "0x18048B550")]
	private void CutinActivateMinimum(int param1, int param2, int param3)
	{
	}

	[Token(Token = "0x600B212")]
	[Address(RVA = "0x48B7C0", Offset = "0x48A9C0", VA = "0x18048B7C0")]
	private void CutinSet(int param1, int param2, int param3)
	{
	}

	[Token(Token = "0x600B213")]
	[Address(RVA = "0x48B9F0", Offset = "0x48ABF0", VA = "0x18048B9F0")]
	private void CutinTurnEnd(int param1, int param2, int param3)
	{
	}

	[Token(Token = "0x600B214")]
	[Address(RVA = "0x48B9E0", Offset = "0x48ABE0", VA = "0x18048B9E0")]
	private void CutinTurnEndMinimum(int param1, int param2, int param3)
	{
	}

	[Token(Token = "0x600B215")]
	[Address(RVA = "0x48E910", Offset = "0x48DB10", VA = "0x18048E910")]
	private void ManaSet(int param1, int param2, int param3)
	{
	}

	[Token(Token = "0x600B216")]
	[Address(RVA = "0x497E90", Offset = "0x497090", VA = "0x180497E90")]
	private void TuningSet(int param1, int param2, int param3)
	{
	}

	[Token(Token = "0x600B217")]
	[Address(RVA = "0x497D30", Offset = "0x496F30", VA = "0x180497D30")]
	private void TuningReset(int param1, int param2, int param3)
	{
	}

	[Token(Token = "0x600B218")]
	[Address(RVA = "0x497DE0", Offset = "0x496FE0", VA = "0x180497DE0")]
	private void TuningRun(int param1, int param2, int param3)
	{
	}

	[Token(Token = "0x600B219")]
	[Address(RVA = "0x48B660", Offset = "0x48A860", VA = "0x18048B660")]
	private void CutinCoinDice(int param1, int param2, int param3)
	{
	}

	[Token(Token = "0x600B21A")]
	[Address(RVA = "0x494EE0", Offset = "0x4940E0", VA = "0x180494EE0")]
	private void RunCoinMinimum(int param1, int param2, int param3)
	{
	}

	[Token(Token = "0x600B21B")]
	[Address(RVA = "0x4950D0", Offset = "0x4942D0", VA = "0x1804950D0")]
	private void RunDiceMinimum(int param1, int param2, int param3)
	{
	}

	[Token(Token = "0x600B21C")]
	[Address(RVA = "0x498DB0", Offset = "0x497FB0", VA = "0x180498DB0")]
	private void WaitFrame(int param1, int param2, int param3)
	{
	}

	[Token(Token = "0x600B21D")]
	[Address(RVA = "0x498E60", Offset = "0x498060", VA = "0x180498E60")]
	private void WaitInput(int param1, int param2, int param3)
	{
	}

	[Token(Token = "0x600B21E")]
	[Address(RVA = "0x494FA0", Offset = "0x4941A0", VA = "0x180494FA0")]
	private void RunDialog(int param1, int param2, int param3)
	{
	}

	[Token(Token = "0x600B21F")]
	[Address(RVA = "0x495330", Offset = "0x494530", VA = "0x180495330")]
	private void RunList(int param1, int param2, int param3)
	{
	}

	[Token(Token = "0x600B220")]
	[Address(RVA = "0x489AA0", Offset = "0x488CA0", VA = "0x180489AA0")]
	private void BattleInit(int param1, int param2, int param3)
	{
	}

	[Token(Token = "0x600B221")]
	[Address(RVA = "0x4899E0", Offset = "0x488BE0", VA = "0x1804899E0")]
	private void BattleInitMinimum(int param1, int param2, int param3)
	{
	}

	[Token(Token = "0x600B222")]
	[Address(RVA = "0x489EE0", Offset = "0x4890E0", VA = "0x180489EE0")]
	private void BattleRun(int param1, int param2, int param3)
	{
	}

	[Token(Token = "0x600B223")]
	[Address(RVA = "0x489E60", Offset = "0x489060", VA = "0x180489E60")]
	private void BattleRunMinimum(int param1, int param2, int param3)
	{
	}

	[Token(Token = "0x600B224")]
	[Address(RVA = "0x4899F0", Offset = "0x488BF0", VA = "0x1804899F0")]
	private void BattleEnd(int param1, int param2, int param3)
	{
	}

	[Token(Token = "0x600B225")]
	[Address(RVA = "0x4899E0", Offset = "0x488BE0", VA = "0x1804899E0")]
	private void BattleEndMinimum(int param1, int param2, int param3)
	{
	}

	[Token(Token = "0x600B226")]
	[Address(RVA = "0x48DBE0", Offset = "0x48CDE0", VA = "0x18048DBE0")]
	private void HandShuffle(int param1, int param2, int param3)
	{
	}

	[Token(Token = "0x600B227")]
	[Address(RVA = "0x48DAF0", Offset = "0x48CCF0", VA = "0x18048DAF0")]
	private void HandOpen(int param1, int param2, int param3)
	{
	}

	[Token(Token = "0x600B228")]
	[Address(RVA = "0x48DAE0", Offset = "0x48CCE0", VA = "0x18048DAE0")]
	private void HandOpenMinimum(int param1, int param2, int param3)
	{
	}

	[Token(Token = "0x600B229")]
	[Address(RVA = "0x48BC80", Offset = "0x48AE80", VA = "0x18048BC80")]
	private void DeckShuffle(int param1, int param2, int param3)
	{
	}

	[Token(Token = "0x600B22A")]
	[Address(RVA = "0x48BAA0", Offset = "0x48ACA0", VA = "0x18048BAA0")]
	private void DeckFlipTop(int param1, int param2, int param3)
	{
	}

	[Token(Token = "0x600B22B")]
	[Address(RVA = "0x48BB90", Offset = "0x48AD90", VA = "0x18048BB90")]
	private void DeckReset(int param1, int param2, int param3)
	{
	}

	[Token(Token = "0x600B22C")]
	[Address(RVA = "0x48D9F0", Offset = "0x48CBF0", VA = "0x18048D9F0")]
	private void GraveTop(int param1, int param2, int param3)
	{
	}

	[Token(Token = "0x600B22D")]
	[Address(RVA = "0x48AB10", Offset = "0x489D10", VA = "0x18048AB10")]
	private void CardMove(int param1, int param2, int param3)
	{
	}

	[Token(Token = "0x600B22E")]
	[Address(RVA = "0x48AB00", Offset = "0x489D00", VA = "0x18048AB00")]
	private void CardMoveMinimum(int param1, int param2, int param3)
	{
	}

	[Token(Token = "0x600B22F")]
	[Address(RVA = "0x48AD70", Offset = "0x489F70", VA = "0x18048AD70")]
	private void CardSwap(int param1, int param2, int param3)
	{
	}

	[Token(Token = "0x600B230")]
	[Address(RVA = "0x48AD60", Offset = "0x489F60", VA = "0x18048AD60")]
	private void CardSwapMinimum(int param1, int param2, int param3)
	{
	}

	[Token(Token = "0x600B231")]
	[Address(RVA = "0x48A620", Offset = "0x489820", VA = "0x18048A620")]
	private void CardFlipTurn(int param1, int param2, int param3)
	{
	}

	[Token(Token = "0x600B232")]
	[Address(RVA = "0x48A610", Offset = "0x489810", VA = "0x18048A610")]
	private void CardFlipTurnMinimum(int param1, int param2, int param3)
	{
	}

	[Token(Token = "0x600B233")]
	[Address(RVA = "0x48A210", Offset = "0x489410", VA = "0x18048A210")]
	private void CardCheat(int param1, int param2, int param3)
	{
	}

	[Token(Token = "0x600B234")]
	[Address(RVA = "0x48A200", Offset = "0x489400", VA = "0x18048A200")]
	private void CardCheatMinimum(int param1, int param2, int param3)
	{
	}

	[Token(Token = "0x600B235")]
	[Address(RVA = "0x48AF50", Offset = "0x48A150", VA = "0x18048AF50")]
	private void CardVanish(int param1, int param2, int param3)
	{
	}

	[Token(Token = "0x600B236")]
	[Address(RVA = "0x48A110", Offset = "0x489310", VA = "0x18048A110")]
	private void CardBreak(int param1, int param2, int param3)
	{
	}

	[Token(Token = "0x600B237")]
	[Address(RVA = "0x48A100", Offset = "0x489300", VA = "0x18048A100")]
	private void CardBreakMinimum(int param1, int param2, int param3)
	{
	}

	[Token(Token = "0x600B238")]
	[Address(RVA = "0x48A560", Offset = "0x489760", VA = "0x18048A560")]
	private void CardExplosion(int param1, int param2, int param3)
	{
	}

	[Token(Token = "0x600B239")]
	[Address(RVA = "0x48A4B0", Offset = "0x4896B0", VA = "0x18048A4B0")]
	private void CardExclude(int param1, int param2, int param3)
	{
	}

	[Token(Token = "0x600B23A")]
	[Address(RVA = "0x48A300", Offset = "0x489500", VA = "0x18048A300")]
	private void CardDisable(int param1, int param2, int param3)
	{
	}

	[Token(Token = "0x600B23B")]
	[Address(RVA = "0x48A400", Offset = "0x489600", VA = "0x18048A400")]
	private void CardEquip(int param1, int param2, int param3)
	{
	}

	[Token(Token = "0x600B23C")]
	[Address(RVA = "0x48A3F0", Offset = "0x4895F0", VA = "0x18048A3F0")]
	private void CardEquipMinimum(int param1, int param2, int param3)
	{
	}

	[Token(Token = "0x600B23D")]
	[Address(RVA = "0x48AE60", Offset = "0x48A060", VA = "0x18048AE60")]
	private void CardUpdate(int param1, int param2, int param3)
	{
	}

	[Token(Token = "0x600B23E")]
	[Address(RVA = "0x48EC10", Offset = "0x48DE10", VA = "0x18048EC10")]
	private void MonstShuffle(int param1, int param2, int param3)
	{
	}

	[Token(Token = "0x600B23F")]
	[Address(RVA = "0x497C80", Offset = "0x496E80", VA = "0x180497C80")]
	private void TributeSet(int param1, int param2, int param3)
	{
	}

	[Token(Token = "0x600B240")]
	[Address(RVA = "0x497B20", Offset = "0x496D20", VA = "0x180497B20")]
	private void TributeReset(int param1, int param2, int param3)
	{
	}

	[Token(Token = "0x600B241")]
	[Address(RVA = "0x497BD0", Offset = "0x496DD0", VA = "0x180497BD0")]
	private void TributeRun(int param1, int param2, int param3)
	{
	}

	[Token(Token = "0x600B242")]
	[Address(RVA = "0x48EB60", Offset = "0x48DD60", VA = "0x18048EB60")]
	private void MaterialSet(int param1, int param2, int param3)
	{
	}

	[Token(Token = "0x600B243")]
	[Address(RVA = "0x48EA00", Offset = "0x48DC00", VA = "0x18048EA00")]
	private void MaterialReset(int param1, int param2, int param3)
	{
	}

	[Token(Token = "0x600B244")]
	[Address(RVA = "0x48EAB0", Offset = "0x48DCB0", VA = "0x18048EAB0")]
	private void MaterialRun(int param1, int param2, int param3)
	{
	}

	[Token(Token = "0x600B245")]
	[Address(RVA = "0x48B0D0", Offset = "0x48A2D0", VA = "0x18048B0D0")]
	private void ChainRun(int param1, int param2, int param3)
	{
	}

	[Token(Token = "0x600B246")]
	[Address(RVA = "0x48B0C0", Offset = "0x48A2C0", VA = "0x18048B0C0")]
	private void ChainRunMinimum(int param1, int param2, int param3)
	{
	}

	[Token(Token = "0x600B247")]
	[Address(RVA = "0x4956F0", Offset = "0x4948F0", VA = "0x1804956F0")]
	private void RunSummon(int param1, int param2, int param3)
	{
	}

	[Token(Token = "0x600B248")]
	[Address(RVA = "0x495460", Offset = "0x494660", VA = "0x180495460")]
	private void RunSpSummon(int param1, int param2, int param3)
	{
	}

	[Token(Token = "0x600B249")]
	[Address(RVA = "0x494EF0", Offset = "0x4940F0", VA = "0x180494EF0")]
	private void RunCoin(int param1, int param2, int param3)
	{
	}

	[Token(Token = "0x600B24A")]
	[Address(RVA = "0x4950E0", Offset = "0x4942E0", VA = "0x1804950E0")]
	private void RunDice(int param1, int param2, int param3)
	{
	}

	[Token(Token = "0x600B24B")]
	[Address(RVA = "0x495510", Offset = "0x494710", VA = "0x180495510")]
	private void RunSpecialWin(int param1, int param2, int param3)
	{
	}

	[Token(Token = "0x600B24C")]
	[Address(RVA = "0x494060", Offset = "0x493260", VA = "0x180494060")]
	private void OverlaySet(int param1, int param2, int param3)
	{
	}

	[Token(Token = "0x600B24D")]
	[Address(RVA = "0x493F00", Offset = "0x493100", VA = "0x180493F00")]
	private void OverlayReset(int param1, int param2, int param3)
	{
	}

	[Token(Token = "0x600B24E")]
	[Address(RVA = "0x493FB0", Offset = "0x4931B0", VA = "0x180493FB0")]
	private void OverlayRun(int param1, int param2, int param3)
	{
	}

	[Token(Token = "0x600B24F")]
	[Address(RVA = "0x48B880", Offset = "0x48AA80", VA = "0x18048B880")]
	private void CutinSuccess(int param1, int param2, int param3)
	{
	}

	[Token(Token = "0x600B250")]
	[Address(RVA = "0x48B870", Offset = "0x48AA70", VA = "0x18048B870")]
	private void CutinSuccessMinimum(int param1, int param2, int param3)
	{
	}

	[Token(Token = "0x600B251")]
	[Address(RVA = "0x48E820", Offset = "0x48DA20", VA = "0x18048E820")]
	private void LinkSet(int param1, int param2, int param3)
	{
	}

	[Token(Token = "0x600B252")]
	[Address(RVA = "0x48E6C0", Offset = "0x48D8C0", VA = "0x18048E6C0")]
	private void LinkReset(int param1, int param2, int param3)
	{
	}

	[Token(Token = "0x600B253")]
	[Address(RVA = "0x48E770", Offset = "0x48D970", VA = "0x18048E770")]
	private void LinkRun(int param1, int param2, int param3)
	{
	}

	[Token(Token = "0x600B254")]
	[Address(RVA = "0x48B280", Offset = "0x48A480", VA = "0x18048B280")]
	private void ChainStepMinimum(int param1, int param2, int param3)
	{
	}

	[Token(Token = "0x600B255")]
	[Address(RVA = "0x48B290", Offset = "0x48A490", VA = "0x18048B290")]
	private void ChainStep(int param1, int param2, int param3)
	{
	}

	[Token(Token = "0x600B256")]
	[Address(RVA = "0x495280", Offset = "0x494480", VA = "0x180495280")]
	private void RunJanken(int param1, int param2, int param3)
	{
	}

	[Token(Token = "0x600B257")]
	[Address(RVA = "0x495640", Offset = "0x494840", VA = "0x180495640")]
	private void RunSpecialefx(int param1, int param2, int param3)
	{
	}

	[Token(Token = "0x600B258")]
	[Address(RVA = "0x4955C0", Offset = "0x4947C0", VA = "0x1804955C0")]
	private void RunSpecialefxMinimum(int param1, int param2, int param3)
	{
	}

	[Token(Token = "0x600B259")]
	[Address(RVA = "0x4957A0", Offset = "0x4949A0", VA = "0x1804957A0")]
	private void RunVija(int param1, int param2, int param3)
	{
	}

	[Token(Token = "0x600B25A")]
	[Address(RVA = "0x48B510", Offset = "0x48A710", VA = "0x18048B510")]
	private void RunCommand(int param1, int param2, int param3)
	{
	}

	[Token(Token = "0x600B25B")]
	[Address(RVA = "0x489FD0", Offset = "0x4891D0", VA = "0x180489FD0")]
	private void BattleSelect(int player, int param2, int param3)
	{
	}

	[Token(Token = "0x600B25C")]
	[Address(RVA = "0x48AA10", Offset = "0x489C10", VA = "0x18048AA10")]
	private void CardLockon(int player, int posIdx, int type)
	{
	}

	[Token(Token = "0x600B25D")]
	[Address(RVA = "0x48A850", Offset = "0x489A50", VA = "0x18048A850")]
	private void CardHappen(int param1, int param2, int param3)
	{
	}

	[Token(Token = "0x600B25E")]
	[Address(RVA = "0x48A840", Offset = "0x489A40", VA = "0x18048A840")]
	private void CardHappenMinimum(int param1, int param2, int param3)
	{
	}

	[Token(Token = "0x600B25F")]
	[Address(RVA = "0x48B1D0", Offset = "0x48A3D0", VA = "0x18048B1D0")]
	private void ChainSet(int param1, int param2, int param3)
	{
	}

	[Token(Token = "0x600B260")]
	[Address(RVA = "0x48B1C0", Offset = "0x48A3C0", VA = "0x18048B1C0")]
	private void ChainSetMinimum(int param1, int param2, int param3)
	{
	}

	[Token(Token = "0x600B261")]
	[Address(RVA = "0x48B010", Offset = "0x48A210", VA = "0x18048B010")]
	private void ChainEnd(int param1, int param2, int param3)
	{
	}

	[Token(Token = "0x600B262")]
	[Address(RVA = "0x48B000", Offset = "0x48A200", VA = "0x18048B000")]
	private void ChainEndMinimum(int param1, int param2, int param3)
	{
	}

	[Token(Token = "0x600B263")]
	[Address(RVA = "0x48B510", Offset = "0x48A710", VA = "0x18048B510")]
	private void CpuThinking(int iPlayer, int end, int param3)
	{
	}

	[Token(Token = "0x600B264")]
	[Address(RVA = "0x48D330", Offset = "0x48C530", VA = "0x18048D330")]
	public int GetIndexByViewIndex(int player, int position, int viewIndex)
	{
		return default(int);
	}

	[Token(Token = "0x600B265")]
	[Address(RVA = "0x48D510", Offset = "0x48C710", VA = "0x18048D510")]
	public int GetViewIndex(int player, int position, int index)
	{
		return default(int);
	}

	[Token(Token = "0x600B266")]
	[Address(RVA = "0x496A00", Offset = "0x495C00", VA = "0x180496A00")]
	private void TapLocatorUnknown(int player, int position, int index)
	{
	}

	[Token(Token = "0x600B267")]
	[Address(RVA = "0x493620", Offset = "0x492820", VA = "0x180493620")]
	private void OnTapDownField(int team, int position, int viewIndex)
	{
	}

	[Token(Token = "0x600B268")]
	[Address(RVA = "0x493840", Offset = "0x492A40", VA = "0x180493840")]
	private void OnTapUpField(int player, int position, int viewIndex)
	{
	}

	[Token(Token = "0x600B269")]
	[Address(RVA = "0x48FAE0", Offset = "0x48ECE0", VA = "0x18048FAE0")]
	private void OnCursorEnter(int team, int position, int viewIndex)
	{
	}

	[Token(Token = "0x600B26A")]
	[Address(RVA = "0x48FB90", Offset = "0x48ED90", VA = "0x18048FB90")]
	private void OnCursorExit(int team, int position, int viewIndex)
	{
	}

	[Token(Token = "0x600B26C")]
	[Address(RVA = "0x492C10", Offset = "0x491E10", VA = "0x180492C10")]
	private void OnSelectField(int team, int position, int viewIndex)
	{
	}

	[Token(Token = "0x600B26D")]
	[Address(RVA = "0x490C90", Offset = "0x48FE90", VA = "0x180490C90")]
	private void OnDeselectField(int team, int position, int viewIndex)
	{
	}

	[Token(Token = "0x600B26E")]
	[Address(RVA = "0x4921E0", Offset = "0x4913E0", VA = "0x1804921E0")]
	private void OnFocusField(int team, int position, int viewIndex)
	{
	}

	[Token(Token = "0x600B26F")]
	[Address(RVA = "0x492550", Offset = "0x491750", VA = "0x180492550")]
	private void OnPlayScreenEffect()
	{
	}

	[Token(Token = "0x600B270")]
	[Address(RVA = "0x4934D0", Offset = "0x4926D0", VA = "0x1804934D0")]
	private void OnStopScreenEffect()
	{
	}

	[Token(Token = "0x600B271")]
	[Address(RVA = "0x48ED00", Offset = "0x48DF00", VA = "0x18048ED00")]
	private void OnAudienceReplayFinished()
	{
	}

	[Token(Token = "0x600B272")]
	[Address(RVA = "0x495FF0", Offset = "0x4951F0", VA = "0x180495FF0")]
	public void SetupInfoDialogShowPos(int focusTeam, int focusPosition, bool immediate)
	{
	}

	[Token(Token = "0x600B273")]
	[Address(RVA = "0x493960", Offset = "0x492B60", VA = "0x180493960")]
	private void OnUnfocusField(int team, int position, int viewIndex)
	{
	}

	[Token(Token = "0x600B274")]
	[Address(RVA = "0x48FD50", Offset = "0x48EF50", VA = "0x18048FD50")]
	private void OnDecideField(int team, int position, int viewIndex)
	{
	}

	[Token(Token = "0x600B275")]
	[Address(RVA = "0x4913D0", Offset = "0x4905D0", VA = "0x1804913D0")]
	private void OnDoubleClickField(int player, int position, int viewIndex)
	{
	}

	[Token(Token = "0x600B276")]
	[Address(RVA = "0x491640", Offset = "0x490840", VA = "0x180491640")]
	private void OnDragFieldBegin(int player, int position, int viewIndex, Vector2 screenPoint)
	{
	}

	[Token(Token = "0x600B277")]
	[Address(RVA = "0x492140", Offset = "0x491340", VA = "0x180492140")]
	private void OnDragField(int player, int position, int viewIndex, Vector2 screenPoint)
	{
	}

	[Token(Token = "0x600B278")]
	[Address(RVA = "0x491B70", Offset = "0x490D70", VA = "0x180491B70")]
	private void OnDragFieldEnd(int player, int position, int viewIndex, Vector2 screenPoint)
	{
	}

	[Token(Token = "0x600B279")]
	[Address(RVA = "0x492420", Offset = "0x491620", VA = "0x180492420")]
	private void OnHoldFieldBegin(int player, int position, int viewIndex, Vector2 screenPoint)
	{
	}

	[Token(Token = "0x600B27A")]
	[Address(RVA = "0x48FBC0", Offset = "0x48EDC0", VA = "0x18048FBC0")]
	private void OnDecideAttackTarget(int attackerPlayer, int attackerPosition, int attackerIndex, int targetPlayer, int targetPosition, int targetIndex)
	{
	}

	[Token(Token = "0x600B27B")]
	[Address(RVA = "0x48C950", Offset = "0x48BB50", VA = "0x18048C950")]
	public bool ExecuteCommandLocation()
	{
		return default(bool);
	}

	[Token(Token = "0x600B27C")]
	[Address(RVA = "0x494AC0", Offset = "0x493CC0", VA = "0x180494AC0")]
	public void ResetCommandOperation(bool resetCommand = true, bool resetStand = true)
	{
	}

	[Token(Token = "0x600B27D")]
	[Address(RVA = "0x494E80", Offset = "0x494080", VA = "0x180494E80")]
	private void ReturnDialogTrue()
	{
	}

	[Token(Token = "0x600B27E")]
	[Address(RVA = "0x494CE0", Offset = "0x493EE0", VA = "0x180494CE0")]
	private void ReturnDialogFalse()
	{
	}

	[Token(Token = "0x600B27F")]
	[Address(RVA = "0x494DE0", Offset = "0x493FE0", VA = "0x180494DE0")]
	public void ReturnDialogTrueAndFree(bool abort)
	{
	}

	[Token(Token = "0x600B280")]
	[Address(RVA = "0x494C40", Offset = "0x493E40", VA = "0x180494C40")]
	public void ReturnDialogFalseAndFree(bool abort)
	{
	}

	[Token(Token = "0x600B281")]
	[Address(RVA = "0x494D40", Offset = "0x493F40", VA = "0x180494D40")]
	public void ReturnDialogTrueAndFreeWithoutSave(bool abort)
	{
	}

	[Token(Token = "0x600B282")]
	[Address(RVA = "0x495D90", Offset = "0x494F90", VA = "0x180495D90")]
	public void SetInfoMessage(string text, bool isForever = false)
	{
	}

	[Token(Token = "0x600B283")]
	[Address(RVA = "0x498D60", Offset = "0x497F60", VA = "0x180498D60")]
	public string UseInfoMessage()
	{
		return null;
	}

	[Token(Token = "0x600B284")]
	[Address(RVA = "0x48B340", Offset = "0x48A540", VA = "0x18048B340")]
	public void ClearInfoMessage(bool alsoForever = false)
	{
	}

	[Token(Token = "0x600B285")]
	[Address(RVA = "0x48B380", Offset = "0x48A580", VA = "0x18048B380")]
	private void CloseEmotionalList(bool forceclose = false)
	{
	}

	[Token(Token = "0x600B286")]
	[Address(RVA = "0x48E8D0", Offset = "0x48DAD0", VA = "0x18048E8D0")]
	private void ListClosed()
	{
	}

	[Token(Token = "0x600B287")]
	[Address(RVA = "0x48B3C0", Offset = "0x48A5C0", VA = "0x18048B3C0")]
	public void CloseSpecialDialog()
	{
	}

	[Token(Token = "0x600B288")]
	[Address(RVA = "0x494BB0", Offset = "0x493DB0", VA = "0x180494BB0")]
	public void ResumeSpecialDialog()
	{
	}

	[Token(Token = "0x600B289")]
	[Address(RVA = "0x494B20", Offset = "0x493D20", VA = "0x180494B20")]
	public void RestartSpecialDialog()
	{
	}

	[Token(Token = "0x600B28A")]
	[Address(RVA = "0x48E070", Offset = "0x48D270", VA = "0x18048E070")]
	public bool IsAnyDialogShowing(bool ignoreFieldViewing = false)
	{
		return default(bool);
	}

	[Token(Token = "0x600B28B")]
	[Address(RVA = "0x48F5C0", Offset = "0x48E7C0", VA = "0x18048F5C0")]
	private bool OnBackEvent()
	{
		return default(bool);
	}

	[Token(Token = "0x600B28C")]
	[Address(RVA = "0x49BF50", Offset = "0x49B150", VA = "0x18049BF50")]
	private void listCardSelected(int player, int position, bool isKnown)
	{
	}

	[Token(Token = "0x600B28D")]
	[Address(RVA = "0x4934B0", Offset = "0x4926B0", VA = "0x1804934B0")]
	private void OnStartInput()
	{
	}

	[Token(Token = "0x600B28E")]
	[Address(RVA = "0x493A80", Offset = "0x492C80", VA = "0x180493A80")]
	private void OnUpdateTimeLimit()
	{
	}

	[Token(Token = "0x600B28F")]
	[Address(RVA = "0x48F9C0", Offset = "0x48EBC0", VA = "0x18048F9C0")]
	private void OnCheckTimeOver()
	{
	}

	[Token(Token = "0x600B290")]
	[Address(RVA = "0x498B20", Offset = "0x497D20", VA = "0x180498B20")]
	private void UpdateNoOperation()
	{
	}

	[Token(Token = "0x600B291")]
	[Address(RVA = "0x496880", Offset = "0x495A80", VA = "0x180496880")]
	public void StartInput(bool changeCameraView, bool fromPvpNoReponse = false)
	{
	}

	[Token(Token = "0x600B292")]
	[Address(RVA = "0x48CE20", Offset = "0x48C020", VA = "0x18048CE20")]
	public void FinishInput(bool changeCameraView, bool fromPvpNoResponce = false)
	{
	}

	[Token(Token = "0x600B293")]
	[Address(RVA = "0x496620", Offset = "0x495820", VA = "0x180496620")]
	private void ShowTimer()
	{
	}

	[Token(Token = "0x600B294")]
	[Address(RVA = "0x48F850", Offset = "0x48EA50", VA = "0x18048F850")]
	private void OnChangeFieldViewMode(bool bView)
	{
	}

	[Token(Token = "0x600B295")]
	[Address(RVA = "0x48BF10", Offset = "0x48B110", VA = "0x18048BF10")]
	public void DuelEnd()
	{
	}

	[Token(Token = "0x600B296")]
	[Address(RVA = "0x489120", Offset = "0x488320", VA = "0x180489120")]
	public void AbortInput(bool allHUD = true)
	{
	}

	[Token(Token = "0x600B297")]
	[Address(RVA = "0x493550", Offset = "0x492750", VA = "0x180493550")]
	private void OnSurrender(int param1, int param2, int param3)
	{
	}

	[Token(Token = "0x600B298")]
	[Address(RVA = "0x493560", Offset = "0x492760", VA = "0x180493560")]
	public void OnSurrender()
	{
	}

	[Token(Token = "0x600B299")]
	[Address(RVA = "0x493D90", Offset = "0x492F90", VA = "0x180493D90")]
	public void OpenConfirmDialog(string message, string rightButtonText, string leftButtonText, Action<DuelConfirmDialog.Result, bool> resultCallback, Action openCallback, bool useFieldView)
	{
	}

	[Token(Token = "0x600B29A")]
	[Address(RVA = "0x48E300", Offset = "0x48D500", VA = "0x18048E300")]
	public bool IsCommandDecideInExceptField()
	{
		return default(bool);
	}

	[Token(Token = "0x600B29B")]
	[Address(RVA = "0x489B90", Offset = "0x488D90", VA = "0x180489B90")]
	public void BattlePositionSelectStart(int uid, int face)
	{
	}

	[Token(Token = "0x600B29C")]
	[Address(RVA = "0x48CB40", Offset = "0x48BD40", VA = "0x18048CB40")]
	public bool ExecuteSpSummonLocation()
	{
		return default(bool);
	}

	[Token(Token = "0x600B29D")]
	[Address(RVA = "0x495CC0", Offset = "0x494EC0", VA = "0x180495CC0")]
	public bool SetCursorToListIfOpenning()
	{
		return default(bool);
	}

	[Token(Token = "0x600B29E")]
	[Address(RVA = "0x495BD0", Offset = "0x494DD0", VA = "0x180495BD0")]
	public bool SetCursorToCommandIfOpenning()
	{
		return default(bool);
	}

	[Token(Token = "0x600B29F")]
	[Address(RVA = "0x48D230", Offset = "0x48C430", VA = "0x18048D230")]
	public void FocusCard(int team, int position, int index, DuelClient.FocusCardSituation situation)
	{
	}

	[Token(Token = "0x600B2A0")]
	[Address(RVA = "0x4989C0", Offset = "0x497BC0", VA = "0x1804989C0")]
	public void UnfocusCard()
	{
	}

	[Token(Token = "0x600B2A1")]
	[Address(RVA = "0x4933F0", Offset = "0x4925F0", VA = "0x1804933F0")]
	private void OnShowAffectEffect(int team, int position, int index)
	{
	}

	[Token(Token = "0x600B2A2")]
	[Address(RVA = "0x4923F0", Offset = "0x4915F0", VA = "0x1804923F0")]
	private void OnHideAffectEffect()
	{
	}

	[Token(Token = "0x600B2A3")]
	[Address(RVA = "0x48A0C0", Offset = "0x4892C0", VA = "0x18048A0C0")]
	public void BeginAttackTargeting(int attackPlayer, int attackPosition, int targetPlayer, int targetPosition)
	{
	}

	[Token(Token = "0x600B2A4")]
	[Address(RVA = "0x48A060", Offset = "0x489260", VA = "0x18048A060")]
	public void BeginAttackTargeting()
	{
	}

	[Token(Token = "0x600B2A5")]
	[Address(RVA = "0x495BB0", Offset = "0x494DB0", VA = "0x180495BB0")]
	public void SetAttackTargetingLineDisp(bool disp)
	{
	}

	[Token(Token = "0x600B2A6")]
	[Address(RVA = "0x48D280", Offset = "0x48C480", VA = "0x18048D280")]
	public (int, int, int, int) GetCurrentAttackTargetingInfo()
	{
		return default((int, int, int, int));
	}

	[Token(Token = "0x600B2A7")]
	[Address(RVA = "0x48C130", Offset = "0x48B330", VA = "0x18048C130")]
	public void EndAttackTargeting()
	{
	}

	[Token(Token = "0x600B2A8")]
	[Address(RVA = "0x48CFB0", Offset = "0x48C1B0", VA = "0x18048CFB0")]
	private void FinishWaitInput()
	{
	}

	[Token(Token = "0x600B2A9")]
	[Address(RVA = "0x48DCC0", Offset = "0x48CEC0", VA = "0x18048DCC0")]
	public void HighlightAvailablePlaces(bool enable, uint cmdBit, Action onFinished)
	{
	}

	[Token(Token = "0x600B2AA")]
	[Address(RVA = "0x48D440", Offset = "0x48C640", VA = "0x18048D440")]
	public SummonEffectBase GetPlayingSummonEffect()
	{
		return null;
	}

	[Token(Token = "0x600B2AB")]
	[Address(RVA = "0x4941D0", Offset = "0x4933D0", VA = "0x1804941D0")]
	public (Vector3, Quaternion, Vector3) PlayDecideEffect(int player, int position, bool ignoreCard, Action onFinished)
	{
		return default((Vector3, Quaternion, Vector3));
	}

	[Token(Token = "0x600B2AC")]
	[Address(RVA = "0x495850", Offset = "0x494A50", VA = "0x180495850")]
	public void SelectLastHappenedCard()
	{
	}

	[Token(Token = "0x600B2AD")]
	[Address(RVA = "0x4966F0", Offset = "0x4958F0", VA = "0x1804966F0")]
	public void StartAttackReady(int player, int position)
	{
	}

	[Token(Token = "0x600B2AE")]
	[Address(RVA = "0x4967E0", Offset = "0x4959E0", VA = "0x1804967E0")]
	public void StartAttackReady(int uniqueID)
	{
	}

	[Token(Token = "0x600B2AF")]
	[Address(RVA = "0x48CD50", Offset = "0x48BF50", VA = "0x18048CD50")]
	public void FinishAttackReady()
	{
	}

	[Token(Token = "0x600B2B0")]
	[Address(RVA = "0x48E260", Offset = "0x48D460", VA = "0x18048E260")]
	public bool IsAttackReadyCard(int uniqueID)
	{
		return default(bool);
	}

	[Token(Token = "0x600B2B1")]
	[Address(RVA = "0x494730", Offset = "0x493930", VA = "0x180494730")]
	public void PlayLethalEffect(int loser, Action onFinished, bool useEffect, Vector3 effectPosition, bool draw, bool isDeckOut, LethalEffect.EffectType type = LethalEffect.EffectType.Normal)
	{
	}

	[Token(Token = "0x600B2B2")]
	[Address(RVA = "0x48E480", Offset = "0x48D680", VA = "0x18048E480")]
	public bool IsLethalEffectPlayedPlayer(int player)
	{
		return default(bool);
	}

	[Token(Token = "0x600B2B3")]
	[Address(RVA = "0x48C150", Offset = "0x48B350", VA = "0x18048C150")]
	public void EndCommand(bool resetCommand = false)
	{
	}

	[Token(Token = "0x600B2B4")]
	[Address(RVA = "0x48D3A0", Offset = "0x48C5A0", VA = "0x18048D3A0")]
	public int GetLocalLP(int player)
	{
		return default(int);
	}

	[Token(Token = "0x600B2B5")]
	[Address(RVA = "0x489820", Offset = "0x488A20", VA = "0x180489820")]
	public void AddDamageLocalLP(int player, int damage)
	{
	}

	[Token(Token = "0x600B2B6")]
	[Address(RVA = "0x495DD0", Offset = "0x494FD0", VA = "0x180495DD0")]
	public void SetLocalLP(int player, int lp)
	{
	}

	[Token(Token = "0x600B2B7")]
	[Address(RVA = "0x496550", Offset = "0x495750", VA = "0x180496550")]
	private void SetupLocalLP()
	{
	}

	[Token(Token = "0x600B2B8")]
	[Address(RVA = "0x496480", Offset = "0x495680", VA = "0x180496480")]
	private void SetupLocalLPMin()
	{
	}

	[Token(Token = "0x600B2B9")]
	[Address(RVA = "0x495E70", Offset = "0x495070", VA = "0x180495E70")]
	public void SetMinLP(int player, int lpt, bool force)
	{
	}

	[Token(Token = "0x600B2BA")]
	[Address(RVA = "0x48D570", Offset = "0x48C770", VA = "0x18048D570")]
	public ZoneCard GetZoneCard(int player, int position, ZoneCard.Mode mode)
	{
		return null;
	}

	[Token(Token = "0x600B2BB")]
	[Address(RVA = "0x48D4D0", Offset = "0x48C6D0", VA = "0x18048D4D0")]
	public int GetTopChainBlockCardID()
	{
		return default(int);
	}

	[Token(Token = "0x600B2BC")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60")]
	public void Assert(string msg)
	{
	}
}
