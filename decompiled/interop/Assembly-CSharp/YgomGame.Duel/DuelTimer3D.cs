using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using YgomSystem.ElementSystem;
using YgomSystem.YGomTMPro;

namespace YgomGame.Duel;

[Token(Token = "0x20018DB")]
public class DuelTimer3D : MonoBehaviour
{
	[Token(Token = "0x20018DC")]
	private enum Step
	{
		[Token(Token = "0x400E901")]
		WaitInitialize,
		[Token(Token = "0x400E902")]
		Idle,
		[Token(Token = "0x400E903")]
		Duel,
		[Token(Token = "0x400E904")]
		Terminating
	}

	[Token(Token = "0x400E8D7")]
	[FieldOffset(Offset = "0x0")]
	private static bool ActivePre;

	[Token(Token = "0x400E8DA")]
	private const int EMERTGENCYTIME = 30;

	[Token(Token = "0x400E8DB")]
	private const string LABEL_TWEEN_ACTIVE = "Active";

	[Token(Token = "0x400E8DC")]
	private const string LABEL_TWEEN_INACTIVE = "Inactive";

	[Token(Token = "0x400E8DD")]
	private const string LABEL_TWEEN_ALERT = "Alert";

	[Token(Token = "0x400E8DE")]
	private const string LABEL_TWEEN_NORMAL = "Normal";

	[Token(Token = "0x400E8DF")]
	private const string LABEL_TWEEN_COUNTDOWN = "CountDown";

	[Token(Token = "0x400E8E0")]
	private const string LABEL_TWEEN_DUELSTART = "DuelStart";

	[Token(Token = "0x400E8E1")]
	private const string LABEL_TWEEN_DUELEND = "DuelEnd";

	[Token(Token = "0x400E8E2")]
	private const string LABEL_TIMERBODY = "Timer";

	[Token(Token = "0x400E8E3")]
	private const string LABEL_TIMERTEXT = "Text";

	[Token(Token = "0x400E8E4")]
	private const string LABEL_ZONEEFFECTROOT = "ZoneEffect";

	[Token(Token = "0x400E8E5")]
	private const string LABEL_ZONEEFFECT_SEC1 = "Section01";

	[Token(Token = "0x400E8E6")]
	private const string LABEL_ZONEEFFECT_SEC2 = "Section02";

	[Token(Token = "0x400E8E7")]
	private const string LABEL_ZONEEFFECT_SEC2Y = "Section02Yellow";

	[Token(Token = "0x400E8E8")]
	private const string LABEL_SHINYEFFECTROOT = "ShinyEffect";

	[Token(Token = "0x400E8E9")]
	private const string LABEL_SHINYEFFECT_BLUE = "LeadTime";

	[Token(Token = "0x400E8EA")]
	private const string LABEL_SHINYEFFECT_GOLD = "BaseTime";

	[Token(Token = "0x400E8EB")]
	private const string LABEL_SHADER_MAXTIME = "_MaxTime";

	[Token(Token = "0x400E8EC")]
	private const string LABEL_SHADER_ADDTIME = "_AddTime";

	[Token(Token = "0x400E8ED")]
	private const string LABEL_SHADER_ACTIVE = "_Active";

	[Token(Token = "0x400E8EE")]
	private const string PATH_PREHAB = "Duel/BG/Timer/Timer_c001/Timer_c001";

	[Token(Token = "0x400E8EF")]
	private const string PATH_PREHAB_SP = "Duel/BG/Timer/Timer_013/Timer_013";

	[Token(Token = "0x400E8F0")]
	[FieldOffset(Offset = "0x30")]
	private GameObject m_TimerModel;

	[Token(Token = "0x400E8F1")]
	[FieldOffset(Offset = "0x38")]
	private ElementObjectManager m_EOManager;

	[Token(Token = "0x400E8F2")]
	[FieldOffset(Offset = "0x40")]
	private MeshRenderer m_TimerBody;

	[Token(Token = "0x400E8F3")]
	[FieldOffset(Offset = "0x48")]
	private ExtendedTextMeshPro m_TimerText;

	[Token(Token = "0x400E8F4")]
	[FieldOffset(Offset = "0x50")]
	private ElementObjectManager m_ShinyEffectEom;

	[Token(Token = "0x400E8F5")]
	[FieldOffset(Offset = "0x58")]
	private ElementObjectManager m_ZoneEffectEom;

	[Token(Token = "0x400E8F6")]
	[FieldOffset(Offset = "0x60")]
	private int m_MaxDuelTime;

	[Token(Token = "0x400E8F7")]
	[FieldOffset(Offset = "0x64")]
	private bool m_Visilble;

	[Token(Token = "0x400E8F8")]
	[FieldOffset(Offset = "0x68")]
	private int m_MaxTurnTime;

	[Token(Token = "0x400E8F9")]
	[FieldOffset(Offset = "0x6C")]
	private int m_RemainTimeIntOrg;

	[Token(Token = "0x400E8FA")]
	[FieldOffset(Offset = "0x70")]
	private bool m_IsPlayerInput;

	[Token(Token = "0x400E8FB")]
	[FieldOffset(Offset = "0x74")]
	private float m_RemainInDuel;

	[Token(Token = "0x400E8FC")]
	[FieldOffset(Offset = "0x78")]
	private float m_RemainInTurn;

	[Token(Token = "0x400E8FD")]
	[FieldOffset(Offset = "0x7C")]
	private float m_RemainInTurnPre;

	[Token(Token = "0x400E8FE")]
	[FieldOffset(Offset = "0x80")]
	private float m_RealTimePreFrame;

	[Token(Token = "0x400E8FF")]
	[FieldOffset(Offset = "0x84")]
	private Step m_Step;

	[Token(Token = "0x1700184F")]
	public bool Active
	{
		[Token(Token = "0x600A024")]
		[Address(RVA = "0x416680", Offset = "0x415880", VA = "0x180416680")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600A023")]
		[Address(RVA = "0x4166E0", Offset = "0x4158E0", VA = "0x1804166E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17001850")]
	public bool isInitialized
	{
		[Token(Token = "0x600A025")]
		[Address(RVA = "0x5D7890", Offset = "0x5D6A90", VA = "0x1805D7890")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600A026")]
		[Address(RVA = "0x671010", Offset = "0x670210", VA = "0x180671010")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17001851")]
	public DuelGameObjectManager goManager
	{
		[Token(Token = "0x600A027")]
		[Address(RVA = "0x4030F0", Offset = "0x4022F0", VA = "0x1804030F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x600A028")]
		[Address(RVA = "0x402FB0", Offset = "0x4021B0", VA = "0x180402FB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17001852")]
	private float MAXTIME
	{
		[Token(Token = "0x600A029")]
		[Address(RVA = "0xEDC430", Offset = "0xEDB630", VA = "0x180EDC430")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x17001853")]
	private float m_RemainTotal
	{
		[Token(Token = "0x600A02A")]
		[Address(RVA = "0xEDC440", Offset = "0xEDB640", VA = "0x180EDC440")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x17001854")]
	private int m_RemainTimeInt
	{
		[Token(Token = "0x600A02B")]
		[Address(RVA = "0x803CD0", Offset = "0x802ED0", VA = "0x180803CD0")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x600A02C")]
		[Address(RVA = "0xEDC490", Offset = "0xEDB690", VA = "0x180EDC490")]
		set
		{
		}
	}

	[Token(Token = "0x17001855")]
	public bool IsPlayerTimeOver
	{
		[Token(Token = "0x600A02D")]
		[Address(RVA = "0xEDC410", Offset = "0xEDB610", VA = "0x180EDC410")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17001856")]
	private Material m_TimerMat
	{
		[Token(Token = "0x600A02E")]
		[Address(RVA = "0xEDC450", Offset = "0xEDB650", VA = "0x180EDC450")]
		get
		{
			return null;
		}
		[Token(Token = "0x600A02F")]
		[Address(RVA = "0xEDC7D0", Offset = "0xEDB9D0", VA = "0x180EDC7D0")]
		set
		{
		}
	}

	[Token(Token = "0x600A030")]
	[Address(RVA = "0x803CD0", Offset = "0x802ED0", VA = "0x180803CD0")]
	public int GetTime()
	{
		return default(int);
	}

	[Token(Token = "0x600A031")]
	[Address(RVA = "0xEDB2E0", Offset = "0xEDA4E0", VA = "0x180EDB2E0")]
	public static DuelTimer3D Create(DuelGameObjectManager goManager, string name, bool isEsportsVer)
	{
		return null;
	}

	[Token(Token = "0x600A032")]
	[Address(RVA = "0xEDB9A0", Offset = "0xEDABA0", VA = "0x180EDB9A0")]
	public void PrepareToDuel()
	{
	}

	[Token(Token = "0x600A033")]
	[Address(RVA = "0xEDBC80", Offset = "0xEDAE80", VA = "0x180EDBC80")]
	private void ResetTimer()
	{
	}

	[Token(Token = "0x600A034")]
	[Address(RVA = "0xEDBDE0", Offset = "0xEDAFE0", VA = "0x180EDBDE0")]
	public void SetRemainTime(float dueltime, float turntime)
	{
	}

	[Token(Token = "0x600A035")]
	[Address(RVA = "0xEDB920", Offset = "0xEDAB20", VA = "0x180EDB920")]
	public void OnDuelStart()
	{
	}

	[Token(Token = "0x600A036")]
	[Address(RVA = "0xEDB8A0", Offset = "0xEDAAA0", VA = "0x180EDB8A0")]
	public void OnDuelEnd()
	{
	}

	[Token(Token = "0x600A037")]
	[Address(RVA = "0xEDBDD0", Offset = "0xEDAFD0", VA = "0x180EDBDD0")]
	public void SetPlayerInput(bool value)
	{
	}

	[Token(Token = "0x600A038")]
	[Address(RVA = "0xEDC3F0", Offset = "0xEDB5F0", VA = "0x180EDC3F0")]
	private void WaitInitializeStep()
	{
	}

	[Token(Token = "0x600A039")]
	[Address(RVA = "0xEDB4E0", Offset = "0xEDA6E0", VA = "0x180EDB4E0")]
	private void DuelStep()
	{
	}

	[Token(Token = "0x600A03A")]
	[Address(RVA = "0xEDBE10", Offset = "0xEDB010", VA = "0x180EDBE10")]
	private void TerminatingStep()
	{
	}

	[Token(Token = "0x600A03B")]
	[Address(RVA = "0xEDC390", Offset = "0xEDB590", VA = "0x180EDC390")]
	private void Update()
	{
	}

	[Token(Token = "0x600A03C")]
	[Address(RVA = "0xEDC0C0", Offset = "0xEDB2C0", VA = "0x180EDC0C0")]
	private void UpdateTimerCage()
	{
	}

	[Token(Token = "0x600A03D")]
	[Address(RVA = "0xEDB740", Offset = "0xEDA940", VA = "0x180EDB740")]
	protected void EmergencyEffect()
	{
	}

	[Token(Token = "0x600A03E")]
	[Address(RVA = "0xEDB7E0", Offset = "0xEDA9E0", VA = "0x180EDB7E0")]
	protected void Initialize(bool isEsportsVer)
	{
	}

	[Token(Token = "0x600A03F")]
	[Address(RVA = "0xEDBE00", Offset = "0xEDB000", VA = "0x180EDBE00")]
	protected void Terminate()
	{
	}

	[Token(Token = "0x600A040")]
	[Address(RVA = "0x3D2BD0", Offset = "0x3D1DD0", VA = "0x1803D2BD0")]
	public DuelTimer3D()
	{
	}
}
