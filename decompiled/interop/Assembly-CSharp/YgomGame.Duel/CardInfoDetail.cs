using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using YgomSystem.UI;
using YgomSystem.YGomTMPro;

namespace YgomGame.Duel;

[Token(Token = "0x2001859")]
public class CardInfoDetail : CardInfoBase
{
	[Token(Token = "0x400E490")]
	protected const int MAXCOUNTERNUM = 6;

	[Token(Token = "0x400E491")]
	protected const string PATH_PREHAB = "Prefabs/Duel/UI/CardInfoDetail";

	[Token(Token = "0x400E492")]
	internal const string PATH_PREHAB_DOWNLOAD = "Prefabs/Duel/UI/CardInfoDetail_Download";

	[Token(Token = "0x400E493")]
	internal const string PATH_PREHAB_BROWSER = "Prefabs/Duel/UI/CardInfoDetail_Browser";

	[Token(Token = "0x400E494")]
	protected const string WORD_EFFECT = "効果";

	[Token(Token = "0x400E495")]
	protected const string WORD_TUNER = "チューナー";

	[Token(Token = "0x400E496")]
	protected const string LABEL_EO_BUTTONBACK = "ButtonBack";

	[Token(Token = "0x400E497")]
	protected const string LABEL_EO_COUNTERNUM = "CounterNum";

	[Token(Token = "0x400E498")]
	protected const string LABEL_EO_ICONCOUNTER = "IconCounter";

	[Token(Token = "0x400E499")]
	protected const string LABEL_EO_ICONLIMIT = "IconLimit";

	[Token(Token = "0x400E49A")]
	protected const string LABEL_EO_ICONSTATUEBYBATTLE = "IconStatueByBattle";

	[Token(Token = "0x400E49B")]
	protected const string LABEL_EO_ICONSTATUECANTREVIVE = "IconStatueCantRevive";

	[Token(Token = "0x400E49C")]
	protected const string LABEL_EO_ICONSTATUEDEMENSIONHOLE = "IconStatueDemensionHole";

	[Token(Token = "0x400E49D")]
	protected const string LABEL_EO_ICONSTATUEDISABLE = "IconStatueDiable";

	[Token(Token = "0x400E49E")]
	protected const string LABEL_EO_ICONSTATUEFUSIONMAT = "IconStatueFusionMat";

	[Token(Token = "0x400E49F")]
	protected const string LABEL_EO_ICONSTATUELIGHTFORCE = "IconStatueLightForce";

	[Token(Token = "0x400E4A0")]
	protected const string LABEL_EO_ICONSTATUESYNCMAT = "IconStatueSyncMat";

	[Token(Token = "0x400E4A1")]
	protected const string LABEL_EO_ICONSTATUECANTATTACK = "IconStatueCantAttack";

	[Token(Token = "0x400E4A2")]
	protected const string LABEL_EO_ROOTTUNER = "TunerGroup";

	[Token(Token = "0x400E4A3")]
	protected const string LABEL_EO_ROOTTYPE = "TypeGroup";

	[Token(Token = "0x400E4A4")]
	protected const string LABEL_EO_PENDULUMDESCAREA = "PendulumDescriptionArea";

	[Token(Token = "0x400E4A5")]
	protected const string LABEL_EO_PLATEDESC = "PlateDescription";

	[Token(Token = "0x400E4A6")]
	protected const string LABEL_EO_PLATEPARAMATOR = "PlateParamator";

	[Token(Token = "0x400E4A7")]
	protected const string LABEL_EO_PLATEPENDESC = "PlatePendulumDescription";

	[Token(Token = "0x400E4A8")]
	protected const string LABEL_EO_TEXTPENDESCVALUE = "TextPendulumDescriptionValue";

	[Token(Token = "0x400E4A9")]
	protected const string LABEL_EO_TEXTPENDESC = "TextPendulumDescriptionItem";

	[Token(Token = "0x400E4AA")]
	protected const string LABEL_EO_PARAMATORAREABOTTOM = "ParamatorAreaBottom";

	[Token(Token = "0x400E4AB")]
	protected const string LABEL_EO_ICONLIMITROOT = "IconTwoLimitRoot";

	[Token(Token = "0x400E4AC")]
	protected const string LABEL_EO_ICONLIMITROOT0 = "RootLimit0";

	[Token(Token = "0x400E4AD")]
	protected const string LABEL_EO_ICONLIMITROOT1 = "RootLimit1";

	[Token(Token = "0x400E4AE")]
	protected const string LABEL_EO_ICONLIMIT0 = "IconLimit0";

	[Token(Token = "0x400E4AF")]
	protected const string LABEL_EO_ICONLIMIT1 = "IconLimit1";

	[Token(Token = "0x400E4B0")]
	[FieldOffset(Offset = "0x340")]
	protected int m_RegId;

	[Token(Token = "0x400E4B1")]
	[FieldOffset(Offset = "0x344")]
	protected bool m_EnableScrollByAnalogStick;

	[Token(Token = "0x400E4B2")]
	[FieldOffset(Offset = "0x345")]
	protected bool useTwoReglation;

	[Token(Token = "0x400E4B3")]
	[FieldOffset(Offset = "0x348")]
	protected int m_Reg0;

	[Token(Token = "0x400E4B4")]
	[FieldOffset(Offset = "0x34C")]
	protected int m_Reg1;

	[Token(Token = "0x400E4B5")]
	[FieldOffset(Offset = "0x350")]
	protected SelectionItem m_DspTextArea;

	[Token(Token = "0x400E4B6")]
	[FieldOffset(Offset = "0x358")]
	protected SelectionItem m_PenTextArea;

	[Token(Token = "0x400E4B7")]
	[FieldOffset(Offset = "0x360")]
	protected UiSwitchTweenAnimationController m_UiSwitchTweenAnimationController;

	[Token(Token = "0x400E4B8")]
	[FieldOffset(Offset = "0x368")]
	protected FullScreenUiBg m_FullScreenUiBg;

	[Token(Token = "0x170017B4")]
	protected RectTransform m_PendulumArea
	{
		[Token(Token = "0x6009B70")]
		[Address(RVA = "0xE897D0", Offset = "0xE889D0", VA = "0x180E897D0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170017B5")]
	protected Transform m_TunerRoot
	{
		[Token(Token = "0x6009B71")]
		[Address(RVA = "0xE89840", Offset = "0xE88A40", VA = "0x180E89840")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170017B6")]
	protected Image m_LimitIcon
	{
		[Token(Token = "0x6009B72")]
		[Address(RVA = "0xE89610", Offset = "0xE88810", VA = "0x180E89610")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170017B7")]
	protected GameObject m_LimitIconRoot
	{
		[Token(Token = "0x6009B73")]
		[Address(RVA = "0xE895B0", Offset = "0xE887B0", VA = "0x180E895B0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170017B8")]
	protected GameObject m_LimitIconRoot0
	{
		[Token(Token = "0x6009B74")]
		[Address(RVA = "0xE894F0", Offset = "0xE886F0", VA = "0x180E894F0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170017B9")]
	protected GameObject m_LimitIconRoot1
	{
		[Token(Token = "0x6009B75")]
		[Address(RVA = "0xE89550", Offset = "0xE88750", VA = "0x180E89550")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170017BA")]
	protected Image m_LimitIcon0
	{
		[Token(Token = "0x6009B76")]
		[Address(RVA = "0xE89410", Offset = "0xE88610", VA = "0x180E89410")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170017BB")]
	protected Image m_LimitIcon1
	{
		[Token(Token = "0x6009B77")]
		[Address(RVA = "0xE89480", Offset = "0xE88680", VA = "0x180E89480")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170017BC")]
	protected Image m_DescAreaBg
	{
		[Token(Token = "0x6009B78")]
		[Address(RVA = "0xE89330", Offset = "0xE88530", VA = "0x180E89330")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170017BD")]
	protected Image m_ParamAreaBg
	{
		[Token(Token = "0x6009B79")]
		[Address(RVA = "0xE896F0", Offset = "0xE888F0", VA = "0x180E896F0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170017BE")]
	protected Image m_PenDescAreaBg
	{
		[Token(Token = "0x6009B7A")]
		[Address(RVA = "0xE89760", Offset = "0xE88960", VA = "0x180E89760")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170017BF")]
	protected ExtendedTextMeshProUGUI m_DspPendulum
	{
		[Token(Token = "0x6009B7B")]
		[Address(RVA = "0xE893A0", Offset = "0xE885A0", VA = "0x180E893A0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170017C0")]
	protected SelectionButton m_BackButton
	{
		[Token(Token = "0x6009B7C")]
		[Address(RVA = "0xE892C0", Offset = "0xE884C0", VA = "0x180E892C0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170017C1")]
	protected RectTransform m_ParaAreaBottom
	{
		[Token(Token = "0x6009B7D")]
		[Address(RVA = "0xE89680", Offset = "0xE88880", VA = "0x180E89680")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170017C2")]
	public SelectionButton cardImageButton
	{
		[Token(Token = "0x6009B7E")]
		[Address(RVA = "0xE892B0", Offset = "0xE884B0", VA = "0x180E892B0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6009B6D")]
	[Address(RVA = "0xE86E00", Offset = "0xE86000", VA = "0x180E86E00")]
	public static bool IsResourceLoaded()
	{
		return default(bool);
	}

	[Token(Token = "0x6009B6E")]
	[Address(RVA = "0xE86E50", Offset = "0xE86050", VA = "0x180E86E50")]
	public static void LoadResource()
	{
	}

	[Token(Token = "0x6009B6F")]
	[Address(RVA = "0xE89270", Offset = "0xE88470", VA = "0x180E89270")]
	public static void UnloadResource()
	{
	}

	[Token(Token = "0x6009B7F")]
	[Address(RVA = "0xE86440", Offset = "0xE85640", VA = "0x180E86440")]
	public static void Create(Transform parent, Action finishedCallback, string prefPath)
	{
	}

	[Token(Token = "0x6009B80")]
	[Address(RVA = "0xE88200", Offset = "0xE87400", VA = "0x180E88200")]
	public void SetFullScreenUiBg(FullScreenUiBg fullScreenUiBg)
	{
	}

	[Token(Token = "0x6009B81")]
	[Address(RVA = "0xE88F50", Offset = "0xE88150", VA = "0x180E88F50")]
	public void Show()
	{
	}

	[Token(Token = "0x6009B82")]
	[Address(RVA = "0xE87510", Offset = "0xE86710", VA = "0x180E87510")]
	public void SetCardByCardInfoData(CardInfoData cardInfoData)
	{
	}

	[Token(Token = "0x6009B83")]
	[Address(RVA = "0xE871D0", Offset = "0xE863D0", VA = "0x180E871D0")]
	public void SetCardByCardId(int cardid, int styleid = 1)
	{
	}

	[Token(Token = "0x6009B84")]
	[Address(RVA = "0xE863C0", Offset = "0xE855C0", VA = "0x180E863C0")]
	public void Close(bool closebg = true)
	{
	}

	[Token(Token = "0x6009B85")]
	[Address(RVA = "0xE88DD0", Offset = "0xE87FD0", VA = "0x180E88DD0")]
	public void SetRegulationId(int regid)
	{
	}

	[Token(Token = "0x6009B86")]
	[Address(RVA = "0xE88DE0", Offset = "0xE87FE0", VA = "0x180E88DE0")]
	public void SetScrollByAnalogStickEnable(bool enable)
	{
	}

	[Token(Token = "0x6009B87")]
	[Address(RVA = "0xE86F30", Offset = "0xE86130", VA = "0x180E86F30")]
	public void SetAsMultiScrollItemEnable(bool enable, float dragThreshold = 0.01f)
	{
	}

	[Token(Token = "0x6009B88")]
	[Address(RVA = "0xE866E0", Offset = "0xE858E0", VA = "0x180E866E0", Slot = "4")]
	protected override void InitializeBase(bool onCreated = true)
	{
	}

	[Token(Token = "0x6009B89")]
	[Address(RVA = "0xE86520", Offset = "0xE85720", VA = "0x180E86520")]
	protected void InitRegulation()
	{
	}

	[Token(Token = "0x6009B8A")]
	[Address(RVA = "0xE86E90", Offset = "0xE86090", VA = "0x180E86E90")]
	protected void ResetNameScroll()
	{
	}

	[Token(Token = "0x6009B8B")]
	[Address(RVA = "0xE88DF0", Offset = "0xE87FF0", VA = "0x180E88DF0")]
	protected void SetTitleAreaByBasicVal(int cardIdOrg, ref Engine.BasicVal basicalval)
	{
	}

	[Token(Token = "0x6009B8C")]
	[Address(RVA = "0xE88E90", Offset = "0xE88090", VA = "0x180E88E90")]
	protected void SetTitleAreaByCardId(int cardid)
	{
	}

	[Token(Token = "0x6009B8D")]
	[Address(RVA = "0xE870C0", Offset = "0xE862C0", VA = "0x180E870C0")]
	protected void SetCardArea(CardInfoData cardinfodata)
	{
	}

	[Token(Token = "0x6009B8E")]
	[Address(RVA = "0xE88880", Offset = "0xE87A80", VA = "0x180E88880")]
	protected void SetParameterArea(CardInfoData cardinfodata)
	{
	}

	[Token(Token = "0x6009B8F")]
	[Address(RVA = "0xE87740", Offset = "0xE86940", VA = "0x180E87740")]
	protected void SetDescriptionArea(CardInfoData cardinfodata)
	{
	}

	[Token(Token = "0x6009B90")]
	[Address(RVA = "0xE88D30", Offset = "0xE87F30", VA = "0x180E88D30")]
	protected void SetPendulumTag()
	{
	}

	[Token(Token = "0x6009B91")]
	[Address(RVA = "0xE886F0", Offset = "0xE878F0", VA = "0x180E886F0")]
	protected void SetParaAreaBottom()
	{
	}

	[Token(Token = "0x6009B92")]
	[Address(RVA = "0xE87A80", Offset = "0xE86C80", VA = "0x180E87A80")]
	protected void SetDspContent(int cardidorg, int effectid, bool isInField = false, bool hasPenScale = false, int effflag = 0)
	{
	}

	[Token(Token = "0x6009B93")]
	[Address(RVA = "0xE88220", Offset = "0xE87420", VA = "0x180E88220")]
	protected void SetLimitIcon(int cardid)
	{
	}

	[Token(Token = "0x6009B94")]
	[Address(RVA = "0xE85260", Offset = "0xE84460", VA = "0x180E85260")]
	public CardInfoDetail()
	{
	}
}
