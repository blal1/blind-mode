using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace YgomGame.Duel;

[Token(Token = "0x2001784")]
public class DuelEndOperation
{
	[Token(Token = "0x2001785")]
	private enum Mode
	{
		[Token(Token = "0x400DD11")]
		DuelEndEffect,
		[Token(Token = "0x400DD12")]
		Error
	}

	[Token(Token = "0x2001786")]
	private enum EffectStep
	{
		[Token(Token = "0x400DD14")]
		WaitCardEffect,
		[Token(Token = "0x400DD15")]
		InitWinLose,
		[Token(Token = "0x400DD16")]
		WaitSpecialWin,
		[Token(Token = "0x400DD17")]
		InitDeckOut,
		[Token(Token = "0x400DD18")]
		WaitDeckOut,
		[Token(Token = "0x400DD19")]
		InitMateMotion,
		[Token(Token = "0x400DD1A")]
		WaitMateMotion,
		[Token(Token = "0x400DD1B")]
		WaitWinLose,
		[Token(Token = "0x400DD1C")]
		WaitWinLose2,
		[Token(Token = "0x400DD1D")]
		FadeOut,
		[Token(Token = "0x400DD1E")]
		Finish
	}

	[Token(Token = "0x2001787")]
	private enum ErrorStep
	{
		[Token(Token = "0x400DD20")]
		WaitCardEffect,
		[Token(Token = "0x400DD21")]
		WaitErrorDialog,
		[Token(Token = "0x400DD22")]
		Finish
	}

	[Token(Token = "0x400DCE6")]
	[FieldOffset(Offset = "0x10")]
	private RunEffectWorker worker;

	[Token(Token = "0x400DCE9")]
	[FieldOffset(Offset = "0x1C")]
	private Mode mode;

	[Token(Token = "0x400DCEA")]
	[FieldOffset(Offset = "0x20")]
	private EffectStep step;

	[Token(Token = "0x400DCEB")]
	[FieldOffset(Offset = "0x24")]
	private ErrorStep errorStep;

	[Token(Token = "0x400DCEC")]
	[FieldOffset(Offset = "0x28")]
	private Engine.ResultType resultType;

	[Token(Token = "0x400DCED")]
	[FieldOffset(Offset = "0x2C")]
	private Engine.FinishType finishType;

	[Token(Token = "0x400DCEE")]
	[FieldOffset(Offset = "0x30")]
	private DuelEndMessage msgObj;

	[Token(Token = "0x400DCEF")]
	[FieldOffset(Offset = "0x38")]
	private float autoFinishTimer;

	[Token(Token = "0x400DCF0")]
	[FieldOffset(Offset = "0x40")]
	private string userNameMyself;

	[Token(Token = "0x400DCF1")]
	[FieldOffset(Offset = "0x48")]
	private string userNameRival;

	[Token(Token = "0x400DCF2")]
	[FieldOffset(Offset = "0x50")]
	private int iconIDMyself;

	[Token(Token = "0x400DCF3")]
	[FieldOffset(Offset = "0x54")]
	private int iconIDRival;

	[Token(Token = "0x400DCF4")]
	[FieldOffset(Offset = "0x58")]
	private int frameIDMyself;

	[Token(Token = "0x400DCF5")]
	[FieldOffset(Offset = "0x5C")]
	private int frameIDRival;

	[Token(Token = "0x400DCF6")]
	[FieldOffset(Offset = "0x60")]
	private int myselfid;

	[Token(Token = "0x400DCF7")]
	[FieldOffset(Offset = "0x64")]
	private int rivalid;

	[Token(Token = "0x400DCF8")]
	[FieldOffset(Offset = "0x68")]
	private string onlineIDMyself;

	[Token(Token = "0x400DCF9")]
	[FieldOffset(Offset = "0x70")]
	private string onlineIDRival;

	[Token(Token = "0x400DCFA")]
	[FieldOffset(Offset = "0x78")]
	private bool sameOSMyself;

	[Token(Token = "0x400DCFB")]
	[FieldOffset(Offset = "0x79")]
	private bool sameOSRival;

	[Token(Token = "0x400DCFC")]
	[FieldOffset(Offset = "0x7C")]
	private int prepareCounter;

	[Token(Token = "0x400DCFD")]
	[FieldOffset(Offset = "0x80")]
	private GameObject animation;

	[Token(Token = "0x400DCFE")]
	[FieldOffset(Offset = "0x88")]
	private string endReasonFormat;

	[Token(Token = "0x400DCFF")]
	[FieldOffset(Offset = "0x90")]
	private bool isOnlineMode;

	[Token(Token = "0x400DD00")]
	[FieldOffset(Offset = "0x91")]
	private bool isReplayMode;

	[Token(Token = "0x400DD01")]
	[FieldOffset(Offset = "0x92")]
	private bool isAudienceMode;

	[Token(Token = "0x400DD02")]
	[FieldOffset(Offset = "0x93")]
	private bool isShowRetry;

	[Token(Token = "0x400DD03")]
	[FieldOffset(Offset = "0x94")]
	private bool winMyself;

	[Token(Token = "0x400DD04")]
	[FieldOffset(Offset = "0x95")]
	private bool winRival;

	[Token(Token = "0x400DD05")]
	[FieldOffset(Offset = "0x96")]
	private bool isDuelLiveContinuous;

	[Token(Token = "0x400DD06")]
	[FieldOffset(Offset = "0x97")]
	private bool isForceNoProfileCard;

	[Token(Token = "0x400DD07")]
	[FieldOffset(Offset = "0x98")]
	private bool endMessageStarted;

	[Token(Token = "0x400DD08")]
	[FieldOffset(Offset = "0x99")]
	private bool hidePlayerID;

	[Token(Token = "0x400DD09")]
	[FieldOffset(Offset = "0xA0")]
	private long pcodeMyself;

	[Token(Token = "0x400DD0A")]
	[FieldOffset(Offset = "0xA8")]
	private long pcodeRival;

	[Token(Token = "0x400DD0B")]
	[FieldOffset(Offset = "0xB0")]
	private string followButtonPopupText;

	[Token(Token = "0x400DD0C")]
	[FieldOffset(Offset = "0xB8")]
	private DuelEndMessage.FollowButtonStatus followButtonStatus;

	[Token(Token = "0x400DD0D")]
	[FieldOffset(Offset = "0xC0")]
	private Dictionary<string, object> profileDataMyself;

	[Token(Token = "0x400DD0E")]
	[FieldOffset(Offset = "0xC8")]
	private Dictionary<string, object> profileDataRival;

	[Token(Token = "0x400DD0F")]
	private const float duelLiveAutoLeaveTime = 3f;

	[Token(Token = "0x170016A0")]
	public bool setup
	{
		[Token(Token = "0x6009412")]
		[Address(RVA = "0x444790", Offset = "0x443990", VA = "0x180444790")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6009413")]
		[Address(RVA = "0x662770", Offset = "0x661970", VA = "0x180662770")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x170016A1")]
	public bool finished
	{
		[Token(Token = "0x6009414")]
		[Address(RVA = "0x7CE720", Offset = "0x7CD920", VA = "0x1807CE720")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6009415")]
		[Address(RVA = "0xAA0C10", Offset = "0xA9FE10", VA = "0x180AA0C10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x170016A2")]
	private int winner
	{
		[Token(Token = "0x6009416")]
		[Address(RVA = "0xDDD540", Offset = "0xDDC740", VA = "0x180DDD540")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x170016A3")]
	private int loser
	{
		[Token(Token = "0x6009417")]
		[Address(RVA = "0xDDD4D0", Offset = "0xDDC6D0", VA = "0x180DDD4D0")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x6009418")]
	[Address(RVA = "0xDDAD40", Offset = "0xDD9F40", VA = "0x180DDAD40")]
	public static DuelEndOperation Create()
	{
		return null;
	}

	[Token(Token = "0x6009419")]
	[Address(RVA = "0xDDC060", Offset = "0xDDB260", VA = "0x180DDC060")]
	public void Setup(RunEffectWorker worker, Engine.ResultType resultType, Engine.FinishType finishType)
	{
	}

	[Token(Token = "0x600941A")]
	[Address(RVA = "0xDDB5A0", Offset = "0xDDA7A0", VA = "0x180DDB5A0")]
	public void InitParams()
	{
	}

	[Token(Token = "0x600941B")]
	[Address(RVA = "0xDDC010", Offset = "0xDDB210", VA = "0x180DDC010")]
	public void SetupError(RunEffectWorker worker)
	{
	}

	[Token(Token = "0x600941C")]
	[Address(RVA = "0xDDCED0", Offset = "0xDDC0D0", VA = "0x180DDCED0")]
	public void Update()
	{
	}

	[Token(Token = "0x600941D")]
	[Address(RVA = "0xDDC8A0", Offset = "0xDDBAA0", VA = "0x180DDC8A0")]
	private void UpdateEffect()
	{
	}

	[Token(Token = "0x600941E")]
	[Address(RVA = "0xDDBEA0", Offset = "0xDDB0A0", VA = "0x180DDBEA0")]
	private void RequestPreLoad()
	{
	}

	[Token(Token = "0x600941F")]
	[Address(RVA = "0xDDD1D0", Offset = "0xDDC3D0", VA = "0x180DDD1D0")]
	private bool WaitCardEffectStep()
	{
		return default(bool);
	}

	[Token(Token = "0x6009420")]
	[Address(RVA = "0xDDBB60", Offset = "0xDDAD60", VA = "0x180DDBB60")]
	private bool InitWinLoseStep()
	{
		return default(bool);
	}

	[Token(Token = "0x6009421")]
	[Address(RVA = "0xDDD220", Offset = "0xDDC420", VA = "0x180DDD220")]
	private bool WaitSpecialWin()
	{
		return default(bool);
	}

	[Token(Token = "0x6009422")]
	[Address(RVA = "0xDDB150", Offset = "0xDDA350", VA = "0x180DDB150")]
	private bool InitDeckOutStep()
	{
		return default(bool);
	}

	[Token(Token = "0x6009423")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60")]
	private void WaitDeckOutStep()
	{
	}

	[Token(Token = "0x6009424")]
	[Address(RVA = "0xDDB2B0", Offset = "0xDDA4B0", VA = "0x180DDB2B0")]
	private bool InitMateMotionStep()
	{
		return default(bool);
	}

	[Token(Token = "0x6009425")]
	[Address(RVA = "0xDDBD60", Offset = "0xDDAF60", VA = "0x180DDBD60")]
	private void PlayWinLose()
	{
	}

	[Token(Token = "0x6009426")]
	[Address(RVA = "0xDDC300", Offset = "0xDDB500", VA = "0x180DDC300")]
	private void StartEndMessage()
	{
	}

	[Token(Token = "0x6009427")]
	[Address(RVA = "0xDDD470", Offset = "0xDDC670", VA = "0x180DDD470")]
	private void WaitWinLoseStep()
	{
	}

	[Token(Token = "0x6009428")]
	[Address(RVA = "0xDDD270", Offset = "0xDDC470", VA = "0x180DDD270")]
	private void WaitWinLoseStep2()
	{
	}

	[Token(Token = "0x6009429")]
	[Address(RVA = "0xDDADB0", Offset = "0xDD9FB0", VA = "0x180DDADB0")]
	private void FadeOutStep()
	{
	}

	[Token(Token = "0x600942A")]
	[Address(RVA = "0xDDADC0", Offset = "0xDD9FC0", VA = "0x180DDADC0")]
	private void FinishStep()
	{
	}

	[Token(Token = "0x600942B")]
	[Address(RVA = "0xDDCD50", Offset = "0xDDBF50", VA = "0x180DDCD50")]
	private void UpdateError()
	{
	}

	[Token(Token = "0x600942C")]
	[Address(RVA = "0xDDD070", Offset = "0xDDC270", VA = "0x180DDD070")]
	private void WaitCardEffectErrorStep()
	{
	}

	[Token(Token = "0x600942D")]
	[Address(RVA = "0x7B3570", Offset = "0x7B2770", VA = "0x1807B3570")]
	private void FinishErrorStep()
	{
	}

	[Token(Token = "0x600942E")]
	[Address(RVA = "0xDDBCB0", Offset = "0xDDAEB0", VA = "0x180DDBCB0")]
	private bool IsSpecialWin(Engine.FinishType finishType)
	{
		return default(bool);
	}

	[Token(Token = "0x600942F")]
	[Address(RVA = "0xDDAEB0", Offset = "0xDDA0B0", VA = "0x180DDAEB0")]
	private string GetWinLoseTimelinePath(Engine.FinishType finishType, Engine.ResultType resultType)
	{
		return null;
	}

	[Token(Token = "0x6009430")]
	[Address(RVA = "0xDDBFF0", Offset = "0xDDB1F0", VA = "0x180DDBFF0")]
	public void SelectEndMessageBtn()
	{
	}

	[Token(Token = "0x6009431")]
	[Address(RVA = "0xDDBCD0", Offset = "0xDDAED0", VA = "0x180DDBCD0")]
	public void OnDestroy()
	{
	}

	[Token(Token = "0x6009432")]
	[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
	public DuelEndOperation()
	{
	}
}
