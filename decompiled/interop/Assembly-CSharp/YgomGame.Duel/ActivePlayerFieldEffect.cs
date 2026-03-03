using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;
using YgomSystem.ElementSystem;

namespace YgomGame.Duel;

[Token(Token = "0x2001837")]
public class ActivePlayerFieldEffect : MonoBehaviour
{
	[Token(Token = "0x2001838")]
	private enum PlauableGuideTrigger
	{
		[Token(Token = "0x400E30E")]
		CHANGE,
		[Token(Token = "0x400E30F")]
		APPEAR,
		[Token(Token = "0x400E310")]
		OUT
	}

	[Token(Token = "0x2001839")]
	private enum Step
	{
		[Token(Token = "0x400E312")]
		WaitInitialize,
		[Token(Token = "0x400E313")]
		Idle,
		[Token(Token = "0x400E314")]
		Duel,
		[Token(Token = "0x400E315")]
		Terminating
	}

	[Token(Token = "0x200183A")]
	private class DelayAction
	{
		[Token(Token = "0x400E316")]
		private const float DELAYTIME_S = 1f;

		[Token(Token = "0x400E317")]
		private const float DELAYTIME_L = 2f;

		[Token(Token = "0x400E318")]
		[FieldOffset(Offset = "0x10")]
		private UnityAction<int, bool> action;

		[Token(Token = "0x400E319")]
		[FieldOffset(Offset = "0x18")]
		private bool changeflag;

		[Token(Token = "0x400E31A")]
		[FieldOffset(Offset = "0x1C")]
		private float delaytime;

		[Token(Token = "0x400E31B")]
		[FieldOffset(Offset = "0x20")]
		private bool isInterrupted;

		[Token(Token = "0x1700174B")]
		private bool isOnTime
		{
			[Token(Token = "0x6009A05")]
			[Address(RVA = "0xE666D0", Offset = "0xE658D0", VA = "0x180E666D0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60099FF")]
		[Address(RVA = "0xE66290", Offset = "0xE65490", VA = "0x180E66290")]
		private bool IsPlayerActive(bool isinterrupt)
		{
			return default(bool);
		}

		[Token(Token = "0x6009A00")]
		[Address(RVA = "0x439010", Offset = "0x438210", VA = "0x180439010")]
		public void SetAction(UnityAction<int, bool> action)
		{
		}

		[Token(Token = "0x6009A01")]
		[Address(RVA = "0xE662F0", Offset = "0xE654F0", VA = "0x180E662F0")]
		public void SetTeamInstant(int turnplayer)
		{
		}

		[Token(Token = "0x6009A02")]
		[Address(RVA = "0xE66320", Offset = "0xE65520", VA = "0x180E66320")]
		public void ToInterrupt(bool isLongDelay)
		{
		}

		[Token(Token = "0x6009A03")]
		[Address(RVA = "0xE663C0", Offset = "0xE655C0", VA = "0x180E663C0")]
		public void ToTurnPlayer(bool forceswitch, bool isLongDelay)
		{
		}

		[Token(Token = "0x6009A04")]
		[Address(RVA = "0xE665A0", Offset = "0xE657A0", VA = "0x180E665A0")]
		public void Update()
		{
		}

		[Token(Token = "0x6009A06")]
		[Address(RVA = "0xE66470", Offset = "0xE65670", VA = "0x180E66470")]
		private void UpdateDelayTime(bool isLongDelay, bool isToNearPlayer)
		{
		}

		[Token(Token = "0x6009A07")]
		[Address(RVA = "0xE666C0", Offset = "0xE658C0", VA = "0x180E666C0")]
		public DelayAction()
		{
		}
	}

	[Token(Token = "0x400E2F9")]
	private const string PATH_GUIDE_NEAR = "Duel/BG/Timer/PlayableGuide_c001/PlayableGuide_c001_near";

	[Token(Token = "0x400E2FA")]
	private const string PATH_GUIDE_FAR = "Duel/BG/Timer/PlayableGuide_c001/PlayableGuide_c001_far";

	[Token(Token = "0x400E2FB")]
	private const string LABEL_TRIGGER_APPEAR = "Apper";

	[Token(Token = "0x400E2FC")]
	private const string LABEL_TRIGGER_NOTICE = "Notice";

	[Token(Token = "0x400E2FD")]
	private const string LABEL_TRIGGER_CHANGE = "Change";

	[Token(Token = "0x400E2FE")]
	private const string LABEL_TRIGGER_OUT = "Out";

	[Token(Token = "0x400E2FF")]
	private const string LABEL_TRIGGER_END = "End";

	[Token(Token = "0x400E300")]
	private const float WAIT_INPUT_NOTICE_INTERVAL = 15f;

	[Token(Token = "0x400E301")]
	private const int LATENCY_THRESHOLD = 127;

	[Token(Token = "0x400E302")]
	[FieldOffset(Offset = "0x20")]
	private Animator m_GuideNear;

	[Token(Token = "0x400E303")]
	[FieldOffset(Offset = "0x28")]
	private Animator m_GuideFar;

	[Token(Token = "0x400E304")]
	[FieldOffset(Offset = "0x30")]
	private ElementObjectManager m_EOManager;

	[Token(Token = "0x400E305")]
	[FieldOffset(Offset = "0x38")]
	private bool m_IsNearReady;

	[Token(Token = "0x400E306")]
	[FieldOffset(Offset = "0x39")]
	private bool m_IsFarReady;

	[Token(Token = "0x400E307")]
	[FieldOffset(Offset = "0x40")]
	private DelayAction m_DelayAction;

	[Token(Token = "0x400E308")]
	[FieldOffset(Offset = "0x48")]
	private Step m_Step;

	[Token(Token = "0x400E30A")]
	[FieldOffset(Offset = "0x50")]
	private float m_WaitInputTime;

	[Token(Token = "0x400E30C")]
	[FieldOffset(Offset = "0x60")]
	public bool IsShow;

	[Token(Token = "0x17001748")]
	public int currentActivePlayer
	{
		[Token(Token = "0x60099E7")]
		[Address(RVA = "0x49BD80", Offset = "0x49AF80", VA = "0x18049BD80")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60099E6")]
		[Address(RVA = "0x49C490", Offset = "0x49B690", VA = "0x18049C490")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17001749")]
	public bool isInitialized
	{
		[Token(Token = "0x60099E8")]
		[Address(RVA = "0xE35F50", Offset = "0xE35150", VA = "0x180E35F50")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700174A")]
	public DuelGameObjectManager goManager
	{
		[Token(Token = "0x60099E9")]
		[Address(RVA = "0x5EA220", Offset = "0x5E9420", VA = "0x1805EA220")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x60099EA")]
		[Address(RVA = "0x81BD60", Offset = "0x81AF60", VA = "0x18081BD60")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x60099EB")]
	[Address(RVA = "0xE34A10", Offset = "0xE33C10", VA = "0x180E34A10")]
	public static ActivePlayerFieldEffect Create(DuelGameObjectManager goManager, GameObject root, string name)
	{
		return null;
	}

	[Token(Token = "0x60099EC")]
	[Address(RVA = "0xE35020", Offset = "0xE34220", VA = "0x180E35020")]
	public void InitGuide(int firstPlayer)
	{
	}

	[Token(Token = "0x60099ED")]
	[Address(RVA = "0xE354B0", Offset = "0xE346B0", VA = "0x180E354B0")]
	public void OnDuelStart()
	{
	}

	[Token(Token = "0x60099EE")]
	[Address(RVA = "0xE35640", Offset = "0xE34840", VA = "0x180E35640")]
	public void SwitchGuide(int team, bool forceswitch = false)
	{
	}

	[Token(Token = "0x60099EF")]
	[Address(RVA = "0xE35860", Offset = "0xE34A60", VA = "0x180E35860")]
	public void TurnPhaseChange()
	{
	}

	[Token(Token = "0x60099F0")]
	[Address(RVA = "0xE34FC0", Offset = "0xE341C0", VA = "0x180E34FC0")]
	public void FinishGuide()
	{
	}

	[Token(Token = "0x60099F1")]
	[Address(RVA = "0xE35140", Offset = "0xE34340", VA = "0x180E35140")]
	protected void Initialize()
	{
	}

	[Token(Token = "0x60099F2")]
	[Address(RVA = "0xE35590", Offset = "0xE34790", VA = "0x180E35590")]
	private void SetGuideNotice()
	{
	}

	[Token(Token = "0x60099F3")]
	[Address(RVA = "0xE35F30", Offset = "0xE35130", VA = "0x180E35F30")]
	private void WaitInitializeStep()
	{
	}

	[Token(Token = "0x60099F4")]
	[Address(RVA = "0xE34BB0", Offset = "0xE33DB0", VA = "0x180E34BB0")]
	private void DuelStep()
	{
	}

	[Token(Token = "0x60099F5")]
	[Address(RVA = "0xE357D0", Offset = "0xE349D0", VA = "0x180E357D0")]
	private void TerminatingStep()
	{
	}

	[Token(Token = "0x60099F6")]
	[Address(RVA = "0xE35E50", Offset = "0xE35050", VA = "0x180E35E50")]
	private void Update()
	{
	}

	[Token(Token = "0x60099F7")]
	[Address(RVA = "0xE35C80", Offset = "0xE34E80", VA = "0x180E35C80")]
	private void UpdateHintEffect()
	{
	}

	[Token(Token = "0x60099F8")]
	[Address(RVA = "0xE34900", Offset = "0xE33B00", VA = "0x180E34900")]
	private bool CheckIsShow()
	{
		return default(bool);
	}

	[Token(Token = "0x60099F9")]
	[Address(RVA = "0xE354C0", Offset = "0xE346C0", VA = "0x180E354C0")]
	private void SetGuideEnable(bool isnear, bool enable, bool turnchange = false)
	{
	}

	[Token(Token = "0x60099FA")]
	[Address(RVA = "0xE357C0", Offset = "0xE349C0", VA = "0x180E357C0")]
	public void Terminate()
	{
	}

	[Token(Token = "0x60099FB")]
	[Address(RVA = "0x3D2BD0", Offset = "0x3D1DD0", VA = "0x1803D2BD0")]
	public ActivePlayerFieldEffect()
	{
	}
}
