using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using YgomSystem.ElementSystem;
using YgomSystem.UI;
using YgomSystem.Utility;
using YgomSystem.YGomTMPro;

namespace YgomGame.Duel;

[Token(Token = "0x20018BE")]
public class DuelLP : MonoBehaviour, IGameObjectPool
{
	[Token(Token = "0x20018BF")]
	public enum Step
	{
		[Token(Token = "0x400E853")]
		Idle,
		[Token(Token = "0x400E854")]
		WaitSubEffect,
		[Token(Token = "0x400E855")]
		TransitionLP,
		[Token(Token = "0x400E856")]
		WaitToIdle,
		[Token(Token = "0x400E857")]
		ToIdle
	}

	[Token(Token = "0x20018C0")]
	public enum DispMode
	{
		[Token(Token = "0x400E859")]
		NormalMode,
		[Token(Token = "0x400E85A")]
		SimpleMode
	}

	[Token(Token = "0x400E817")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float countTime;

	[Token(Token = "0x400E818")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public float EmergencyPeriod;

	[Token(Token = "0x400E819")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Color lpColorDamage;

	[Token(Token = "0x400E81A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public Color lpColorRecover;

	[Token(Token = "0x400E81B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public Color lpColorNormal;

	[Token(Token = "0x400E81C")]
	protected const string LAEBL_EO_RVS = "RestValueShow";

	[Token(Token = "0x400E81D")]
	protected const string LAEBL_EO_CONTENT = "Content";

	[Token(Token = "0x400E81E")]
	protected const string LAEBL_EO_LIFEPOINTROOT = "LifePointRoot";

	[Token(Token = "0x400E81F")]
	protected const string LAEBL_EO_CHANGEVALUEROOT = "ChangeValueRoot";

	[Token(Token = "0x400E820")]
	protected const string LAEBL_EO_LPLABEL = "LPLabel";

	[Token(Token = "0x400E821")]
	protected const string LAEBL_EO_RECTVALUEBG = "RectValueBg";

	[Token(Token = "0x400E822")]
	protected const string LAEBL_EO_PLAYERICON = "PlayerIcon";

	[Token(Token = "0x400E823")]
	protected const string LAEBL_EO_PLAYERICONFRAME = "PlayerIconBorder";

	[Token(Token = "0x400E824")]
	protected const string LAEBL_EO_PLAYERNAME = "PlayerName";

	[Token(Token = "0x400E825")]
	protected const string LAEBL_EO_EXTRAIDROOT = "ExtraIdRoot";

	[Token(Token = "0x400E826")]
	protected const string LAEBL_EO_EXTRAIDNAME = "ExtraIdName";

	[Token(Token = "0x400E827")]
	protected const string LAEBL_EO_EXTRAIDICON = "ExtraIdIcon";

	[Token(Token = "0x400E828")]
	protected const string LAEBL_EO_SPECIALACCOUNTICONS = "SpecialAccountIcons";

	[Token(Token = "0x400E829")]
	protected const string LAEBL_EO_VALPOS = "ValueBirthPos";

	[Token(Token = "0x400E82A")]
	protected const string LAEBL_EO_NETWORKERROR = "NetworkErrorRoot";

	[Token(Token = "0x400E82B")]
	protected const string LAEBL_TP_CSUB = "ChangeValue";

	[Token(Token = "0x400E82C")]
	protected const string LABEL_SE_LP_COUNT = "SE_LP_COUNT";

	[Token(Token = "0x400E82D")]
	protected const string LABEL_SE_LP_ZERO = "SE_LP_ZERO";

	[Token(Token = "0x400E82E")]
	protected const string LABEL_TW_CMAINZOOMIN = "CMainZoomIn";

	[Token(Token = "0x400E82F")]
	protected const string LABEL_TW_CSUBZOOMIN = "CSubZoomIn";

	[Token(Token = "0x400E830")]
	protected const string LABEL_TW_CSUBZOOMOUT = "CSubZoomOut";

	[Token(Token = "0x400E831")]
	protected const string CURRENTPLATFORMICONPATH = "Images/PlatformIcon/<_PLATFORM_>/CurrentPlatformS";

	[Token(Token = "0x400E832")]
	protected const string OTHERPLATFORMICONPATH = "Images/PlatformIcon/Common/OtherPlatformL";

	[Token(Token = "0x400E833")]
	protected const int NUM_DEFAULTCSUBNUM = 2;

	[Token(Token = "0x400E834")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	protected int m_LPBeforeTrans;

	[Token(Token = "0x400E835")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	protected int m_LPTarget;

	[Token(Token = "0x400E836")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	protected int m_LPCurrent;

	[Token(Token = "0x400E837")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	protected int m_LPForDisp;

	[Token(Token = "0x400E838")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	protected float m_CurrentTime;

	[Token(Token = "0x400E839")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	protected float m_WaitTime;

	[Token(Token = "0x400E83A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	protected DuelClient m_Host;

	[Token(Token = "0x400E83B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	protected Action m_OnFinishedCallBack;

	[Token(Token = "0x400E83C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	protected List<LPCounterSub> m_CounterSubs;

	[Token(Token = "0x400E83D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	protected Step m_Step;

	[Token(Token = "0x400E83E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	protected Dictionary<Step, Action> m_StepActTable;

	[Token(Token = "0x400E83F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	protected ElementObjectManager m_EOManager;

	[Token(Token = "0x400E840")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	protected DispMode m_DispMode;

	[Token(Token = "0x400E841")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
	protected DispMode m_TargetDispMode;

	[Token(Token = "0x400E842")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	protected string m_CurrentSeLabel;

	[Token(Token = "0x400E843")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	protected bool m_IsSimpleViewMode;

	[Token(Token = "0x400E844")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB1")]
	protected bool m_DuelEnd;

	[Token(Token = "0x400E845")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB2")]
	protected bool m_ValueChanged;

	[Token(Token = "0x400E846")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	private GameObject m_networkErrorRoot;

	[Token(Token = "0x400E847")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	private Dictionary<int, string> m_FilteredName;

	[Token(Token = "0x400E848")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	private string m_PlayerName;

	[Token(Token = "0x400E849")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	private RectTransform m_IconFrame;

	[Token(Token = "0x400E84A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	private GameObject m_PlatformRoot;

	[Token(Token = "0x400E84B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	private Image m_PlatformIcon;

	[Token(Token = "0x400E84C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	private ExtendedTextMeshProUGUI m_PlatformID;

	[Token(Token = "0x400E84D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	private SelectionButton m_PlayerIconButton;

	[Token(Token = "0x400E84E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	private SpecialAccountIcons m_SpecialAccount;

	[Token(Token = "0x400E84F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
	private ExtendedTextMeshProUGUI m_CounterMainTxtShow_Origin;

	[Token(Token = "0x400E850")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
	private bool m_IsInitialized;

	[Token(Token = "0x400E851")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x109")]
	private bool m_IsNear;

	[Token(Token = "0x17001836")]
	public int currentLP
	{
		[Token(Token = "0x6009F5A")]
		[Address(RVA = "0x404880", Offset = "0x403A80", VA = "0x180404880")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17001837")]
	protected ExtendedTextMeshProUGUI m_RVS
	{
		[Token(Token = "0x6009F5B")]
		[Address(RVA = "0xED2C80", Offset = "0xED1E80", VA = "0x180ED2C80")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001838")]
	public string poolKey
	{
		[Token(Token = "0x6009F5C")]
		[Address(RVA = "0xED2D40", Offset = "0xED1F40", VA = "0x180ED2D40", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001839")]
	public GameObject pooledTarget
	{
		[Token(Token = "0x6009F5E")]
		[Address(RVA = "0x4A1C50", Offset = "0x4A0E50", VA = "0x1804A1C50", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6009F5D")]
	[Address(RVA = "0xED1E60", Offset = "0xED1060", VA = "0x180ED1E60", Slot = "6")]
	public void OnReturned()
	{
	}

	[Token(Token = "0x6009F5F")]
	[Address(RVA = "0xED0C50", Offset = "0xECFE50", VA = "0x180ED0C50")]
	public static void Create(Transform parent, int player, DuelClient host, Action<DuelLP> onFinished)
	{
	}

	[Token(Token = "0x6009F60")]
	[Address(RVA = "0xED1890", Offset = "0xED0A90", VA = "0x180ED1890")]
	public void Initialize(int playerid, DuelClient host)
	{
	}

	[Token(Token = "0x6009F61")]
	[Address(RVA = "0xED1360", Offset = "0xED0560", VA = "0x180ED1360")]
	private void InitializeOnCreated(int playerid, DuelClient host)
	{
	}

	[Token(Token = "0x6009F62")]
	[Address(RVA = "0xED2210", Offset = "0xED1410", VA = "0x180ED2210")]
	public void SetLP(int lp, bool initialSet = false)
	{
	}

	[Token(Token = "0x6009F63")]
	[Address(RVA = "0xED0B80", Offset = "0xECFD80", VA = "0x180ED0B80")]
	public void ChangeLP(int afterLP, int damage, Engine.DamageType type, int player, int position, [Optional] Action onFinished)
	{
	}

	[Token(Token = "0x6009F64")]
	[Address(RVA = "0xED0C40", Offset = "0xECFE40", VA = "0x180ED0C40")]
	public void ChangeMode(DispMode mode)
	{
	}

	[Token(Token = "0x6009F65")]
	[Address(RVA = "0xED0500", Offset = "0xECF700", VA = "0x180ED0500")]
	protected LPCounterSub AppendLPCounterSub()
	{
		return null;
	}

	[Token(Token = "0x6009F66")]
	[Address(RVA = "0xED06C0", Offset = "0xECF8C0", VA = "0x180ED06C0")]
	protected bool ApplyCounterSub(int targetlp, int changevalue, Engine.DamageType type, int player, int position)
	{
		return default(bool);
	}

	[Token(Token = "0x6009F67")]
	[Address(RVA = "0xED1100", Offset = "0xED0300", VA = "0x180ED1100")]
	protected Vector2 GetRectPosBy3DPos(RectTransform rect, Vector3 worldpos)
	{
		return default(Vector2);
	}

	[Token(Token = "0x6009F68")]
	[Address(RVA = "0xED0A10", Offset = "0xECFC10", VA = "0x180ED0A10")]
	protected void ApplyTransLP(Color lpcol, int targetlife, Engine.DamageType type)
	{
	}

	[Token(Token = "0x6009F69")]
	[Address(RVA = "0xED1260", Offset = "0xED0460", VA = "0x180ED1260")]
	protected void IdleStep()
	{
	}

	[Token(Token = "0x6009F6A")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60")]
	protected void WaitSubEffectStep()
	{
	}

	[Token(Token = "0x6009F6B")]
	[Address(RVA = "0xED2670", Offset = "0xED1870", VA = "0x180ED2670")]
	protected void TransitionLPStep()
	{
	}

	[Token(Token = "0x6009F6C")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60")]
	protected void WaitToIdleStep()
	{
	}

	[Token(Token = "0x6009F6D")]
	[Address(RVA = "0xED25F0", Offset = "0xED17F0", VA = "0x180ED25F0")]
	protected void ToIdleStep()
	{
	}

	[Token(Token = "0x6009F6E")]
	[Address(RVA = "0xED0F40", Offset = "0xED0140", VA = "0x180ED0F40")]
	protected LPCounterSub GetAvailableLPCounterSub()
	{
		return null;
	}

	[Token(Token = "0x6009F6F")]
	[Address(RVA = "0xED0E90", Offset = "0xED0090", VA = "0x180ED0E90")]
	protected void EmergencyEffect()
	{
	}

	[Token(Token = "0x6009F70")]
	[Address(RVA = "0xED1DC0", Offset = "0xED0FC0", VA = "0x180ED1DC0")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6009F71")]
	[Address(RVA = "0xED2A00", Offset = "0xED1C00", VA = "0x180ED2A00")]
	private void Update()
	{
	}

	[Token(Token = "0x6009F72")]
	[Address(RVA = "0xED27A0", Offset = "0xED19A0", VA = "0x180ED27A0")]
	private void UpdateLayout()
	{
	}

	[Token(Token = "0x6009F73")]
	[Address(RVA = "0xED1E10", Offset = "0xED1010", VA = "0x180ED1E10")]
	public void OnDuelEnd()
	{
	}

	[Token(Token = "0x6009F74")]
	[Address(RVA = "0xED10A0", Offset = "0xED02A0", VA = "0x180ED10A0")]
	public SelectionButton GetButton()
	{
		return null;
	}

	[Token(Token = "0x6009F75")]
	[Address(RVA = "0xED21B0", Offset = "0xED13B0", VA = "0x180ED21B0")]
	public void SetDispNetworkError(bool disp)
	{
	}

	[Token(Token = "0x6009F76")]
	[Address(RVA = "0xED22B0", Offset = "0xED14B0", VA = "0x180ED22B0")]
	public void SetName(int playerid)
	{
	}

	[Token(Token = "0x6009F77")]
	[Address(RVA = "0xED2B30", Offset = "0xED1D30", VA = "0x180ED2B30")]
	public DuelLP()
	{
	}
}
