using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using YgomSystem.ElementSystem;
using YgomSystem.UI;
using YgomSystem.Utility;

namespace YgomGame.Duel;

[Token(Token = "0x20018B6")]
public class DuelLogController : MonoBehaviour, IGameObjectPool
{
	[Token(Token = "0x400E7A5")]
	public const int INVALIDCARDID = 0;

	[Token(Token = "0x400E7A6")]
	public const int CARDMOVE_COST_MASK = 256;

	[Token(Token = "0x400E7A7")]
	public const string LABEL_SHOWTURN = "ShowTurn";

	[Token(Token = "0x400E7A8")]
	public const string LABEL_SHOWACTION = "ShowAction";

	[Token(Token = "0x400E7A9")]
	public const string LABEL_SHOWCHAIN = "ShowChain";

	[Token(Token = "0x400E7AA")]
	public const string LABEL_SHOWTAG = "ShowTag";

	[Token(Token = "0x400E7AB")]
	public const string LABEL_SHOWCARDNAME = "ShowCardName";

	[Token(Token = "0x400E7AC")]
	public const string LABEL_SHOWTEXT = "ShowText";

	[Token(Token = "0x400E7AD")]
	public const string LABEL_SHOWPHASE = "ShowPhase";

	[Token(Token = "0x400E7AE")]
	public const string LABEL_SAPERATELINE = "SeparateLine";

	[Token(Token = "0x400E7AF")]
	public const string LABEL_MOVEMULTI_HEADER = "CardMoveMultiHeader";

	[Token(Token = "0x400E7B0")]
	public const string LABEL_MOVEMULTI = "CardMoveMulti";

	[Token(Token = "0x400E7B1")]
	public const string LABEL_SHOWFIRST = "ShowFirstPlayer";

	[Token(Token = "0x400E7B2")]
	public const string LABEL_ROOT = "Root";

	[Token(Token = "0x400E7B3")]
	public const string LABEL_SCROLLUP = "ScrollUp";

	[Token(Token = "0x400E7B4")]
	public const string LABEL_SCROLLDOWN = "ScrollDown";

	[Token(Token = "0x400E7B5")]
	public const string LABEL_SCROLLVIEW = "ScrollView";

	[Token(Token = "0x400E7B6")]
	public const string LABEL_BG = "Bg";

	[Token(Token = "0x400E7B7")]
	public const string LABEL_TWEEN_SHOWLOG = "ShowLog";

	[Token(Token = "0x400E7B8")]
	public const string LABEL_TWEEN_HIDELOG = "HideLog";

	[Token(Token = "0x400E7B9")]
	public const string LABEL_TWEEN_INIT = "InitTween";

	[Token(Token = "0x400E7BA")]
	public const string LABEL_TWEEN_READY = "Ready";

	[Token(Token = "0x400E7BB")]
	public const string SE_LOG_OPEN = "SE_LOG_OPEN";

	[Token(Token = "0x400E7BC")]
	public const string SE_LOG_CLOSE = "SE_LOG_CLOSE";

	[Token(Token = "0x400E7BD")]
	[FieldOffset(Offset = "0x20")]
	public SelectionButton m_DuelLogButton;

	[Token(Token = "0x400E7C0")]
	[FieldOffset(Offset = "0x38")]
	protected ElementObjectManager m_EOManager;

	[Token(Token = "0x400E7C1")]
	[FieldOffset(Offset = "0x40")]
	protected DuelLogScrollView m_ScrollView;

	[Token(Token = "0x400E7C2")]
	[FieldOffset(Offset = "0x48")]
	protected Dictionary<string, int> m_DataTypeNumDict;

	[Token(Token = "0x400E7C3")]
	[FieldOffset(Offset = "0x50")]
	protected Dictionary<Engine.ViewType, LogHandler> m_LogHandlerDict;

	[Token(Token = "0x400E7C4")]
	[FieldOffset(Offset = "0x58")]
	protected Dictionary<string, LogItemHandler> m_UpdateItemDict;

	[Token(Token = "0x400E7C5")]
	[FieldOffset(Offset = "0x60")]
	protected List<LogBaseData> m_LogBaseItemList;

	[Token(Token = "0x400E7C6")]
	[FieldOffset(Offset = "0x68")]
	protected List<ShowTurnData> m_DataList_ShowTurn;

	[Token(Token = "0x400E7C7")]
	[FieldOffset(Offset = "0x70")]
	protected List<ShowActionData> m_DataList_ShowAction;

	[Token(Token = "0x400E7C8")]
	[FieldOffset(Offset = "0x78")]
	protected List<ShowChainData> m_DataList_ShowChain;

	[Token(Token = "0x400E7C9")]
	[FieldOffset(Offset = "0x80")]
	protected List<ShowCardNameData> m_DataList_ShowCardName;

	[Token(Token = "0x400E7CA")]
	[FieldOffset(Offset = "0x88")]
	protected List<ShowTextData> m_DataList_ShowText;

	[Token(Token = "0x400E7CB")]
	[FieldOffset(Offset = "0x90")]
	protected List<ShowPhaseData> m_DataList_ShowPhase;

	[Token(Token = "0x400E7CC")]
	[FieldOffset(Offset = "0x98")]
	protected List<ShowTagData> m_DataList_ShowTag;

	[Token(Token = "0x400E7CD")]
	[FieldOffset(Offset = "0xA0")]
	protected List<string> m_TemplateLabelList;

	[Token(Token = "0x400E7CE")]
	[FieldOffset(Offset = "0xA8")]
	protected Dictionary<int, int> m_PlayerIconidTable;

	[Token(Token = "0x400E7CF")]
	[FieldOffset(Offset = "0xB0")]
	protected Dictionary<int, int> m_PlayerFrameidTable;

	[Token(Token = "0x400E7D0")]
	[FieldOffset(Offset = "0xB8")]
	protected Dictionary<int, int> m_UidCardidTable;

	[Token(Token = "0x400E7D1")]
	[FieldOffset(Offset = "0xC0")]
	protected Queue<KeyValuePair<ShowActionData, int>> m_HandOpenDataQueue;

	[Token(Token = "0x400E7D2")]
	[FieldOffset(Offset = "0xC8")]
	protected Queue<ShowActionData> m_CardMoveDataQueue;

	[Token(Token = "0x400E7D3")]
	[FieldOffset(Offset = "0xD0")]
	protected int m_ChainCount;

	[Token(Token = "0x400E7D4")]
	[FieldOffset(Offset = "0xD4")]
	protected bool m_IsEffectProcess;

	[Token(Token = "0x400E7D5")]
	[FieldOffset(Offset = "0xD5")]
	protected bool m_CloseTemprary;

	[Token(Token = "0x400E7D6")]
	[FieldOffset(Offset = "0xD8")]
	protected GameObject m_bgObj;

	[Token(Token = "0x400E7D7")]
	[FieldOffset(Offset = "0xE0")]
	protected DuelClient m_Host;

	[Token(Token = "0x400E7D8")]
	[FieldOffset(Offset = "0xE8")]
	protected ScrollColorBar m_ScrollColorBar;

	[Token(Token = "0x400E7D9")]
	[FieldOffset(Offset = "0xF0")]
	protected int currentTurn;

	[Token(Token = "0x400E7DA")]
	[FieldOffset(Offset = "0xF4")]
	private bool m_IsOpen;

	[Token(Token = "0x400E7DB")]
	[FieldOffset(Offset = "0xF8")]
	private SPSUMMONTYPE m_SpSummonFlag;

	[Token(Token = "0x400E7DC")]
	[FieldOffset(Offset = "0xFC")]
	private int m_SpSummonFlagCount;

	[Token(Token = "0x400E7DD")]
	[FieldOffset(Offset = "0x100")]
	private string m_IconPath0;

	[Token(Token = "0x400E7DE")]
	[FieldOffset(Offset = "0x108")]
	private string m_IconPath1;

	[Token(Token = "0x400E7DF")]
	[FieldOffset(Offset = "0x110")]
	private string m_FramePath0;

	[Token(Token = "0x400E7E0")]
	[FieldOffset(Offset = "0x118")]
	private string m_FramePath1;

	[Token(Token = "0x400E7E1")]
	[FieldOffset(Offset = "0x120")]
	private int m_PrevMoveType;

	[Token(Token = "0x400E7E2")]
	[FieldOffset(Offset = "0x124")]
	private bool m_AddCostTag;

	[Token(Token = "0x400E7E3")]
	[FieldOffset(Offset = "0x128")]
	private List<ShowActionData> m_LogDataBuff;

	[Token(Token = "0x400E7E4")]
	[FieldOffset(Offset = "0x130")]
	protected List<MoveMultiData> m_DataList_MoveMulti;

	[Token(Token = "0x400E7E5")]
	[FieldOffset(Offset = "0x138")]
	protected List<ShowActionData> m_DataList_MoveMultiHeader;

	[Token(Token = "0x400E7E6")]
	[FieldOffset(Offset = "0x140")]
	protected List<ChoiceFirstPlayerData> m_DataList_ChoiceFirstPlayer;

	[Token(Token = "0x17001823")]
	public bool isOpen
	{
		[Token(Token = "0x6009EC0")]
		[Address(RVA = "0xEC57D0", Offset = "0xEC49D0", VA = "0x180EC57D0")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17001824")]
	public bool isTmpClose
	{
		[Token(Token = "0x6009EC1")]
		[Address(RVA = "0xEC57E0", Offset = "0xEC49E0", VA = "0x180EC57E0")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17001825")]
	public Action<bool> onChangeOpenClose
	{
		[Token(Token = "0x6009EC2")]
		[Address(RVA = "0x4030F0", Offset = "0x4022F0", VA = "0x1804030F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6009EC3")]
		[Address(RVA = "0x402FB0", Offset = "0x4021B0", VA = "0x180402FB0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x17001826")]
	public bool IsReady
	{
		[Token(Token = "0x6009EC4")]
		[Address(RVA = "0x51FEA0", Offset = "0x51F0A0", VA = "0x18051FEA0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6009EC5")]
		[Address(RVA = "0x5FDF60", Offset = "0x5FD160", VA = "0x1805FDF60")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Token(Token = "0x17001827")]
	private Vector3 InitialPos
	{
		[Token(Token = "0x6009EC6")]
		[Address(RVA = "0xEC5750", Offset = "0xEC4950", VA = "0x180EC5750")]
		get
		{
			return default(Vector3);
		}
	}

	[Token(Token = "0x17001828")]
	protected bool m_IsIndent
	{
		[Token(Token = "0x6009EC7")]
		[Address(RVA = "0x8D0030", Offset = "0x8CF230", VA = "0x1808D0030")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17001829")]
	public string poolKey
	{
		[Token(Token = "0x6009EC8")]
		[Address(RVA = "0xEC57F0", Offset = "0xEC49F0", VA = "0x180EC57F0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700182A")]
	public GameObject pooledTarget
	{
		[Token(Token = "0x6009ECA")]
		[Address(RVA = "0x4A1C50", Offset = "0x4A0E50", VA = "0x1804A1C50", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6009EC9")]
	[Address(RVA = "0xEC2570", Offset = "0xEC1770", VA = "0x180EC2570", Slot = "6")]
	public void OnReturned()
	{
	}

	[Token(Token = "0x6009ECB")]
	[Address(RVA = "0xEBF690", Offset = "0xEBE890", VA = "0x180EBF690")]
	public static void Create(Transform parent, DuelClient host, SelectionButton duelLogButton, Action<bool> onChangeOpenClose, Action<DuelLogController> onFinish)
	{
	}

	[Token(Token = "0x6009ECC")]
	[Address(RVA = "0xEC3580", Offset = "0xEC2780", VA = "0x180EC3580")]
	public void Open()
	{
	}

	[Token(Token = "0x6009ECD")]
	[Address(RVA = "0xEBF400", Offset = "0xEBE600", VA = "0x180EBF400")]
	public void Close(bool skipSE = false)
	{
	}

	[Token(Token = "0x6009ECE")]
	[Address(RVA = "0xEBF3E0", Offset = "0xEBE5E0", VA = "0x180EBF3E0")]
	public void CloseTemporary()
	{
	}

	[Token(Token = "0x6009ECF")]
	[Address(RVA = "0xEC46D0", Offset = "0xEC38D0", VA = "0x180EC46D0")]
	public void Resume()
	{
	}

	[Token(Token = "0x6009ED0")]
	[Address(RVA = "0xEC4700", Offset = "0xEC3900", VA = "0x180EC4700")]
	public void SetAlpha(float alpha)
	{
	}

	[Token(Token = "0x6009ED1")]
	[Address(RVA = "0x9D1030", Offset = "0x9D0230", VA = "0x1809D1030")]
	public void SetAutoScroll(bool auto)
	{
	}

	[Token(Token = "0x6009ED2")]
	[Address(RVA = "0xEC4970", Offset = "0xEC3B70", VA = "0x180EC4970")]
	public void SetShortkeyIconVisible(bool visible)
	{
	}

	[Token(Token = "0x6009ED3")]
	[Address(RVA = "0xEBD460", Offset = "0xEBC660", VA = "0x180EBD460")]
	public void AddLogData(Engine.ViewType viewType, int param1, int param2, int param3)
	{
	}

	[Token(Token = "0x6009ED4")]
	[Address(RVA = "0xEC2DF0", Offset = "0xEC1FF0", VA = "0x180EC2DF0")]
	protected void OnUpdateListItemBase(GameObject gob, int baseitemindex)
	{
	}

	[Token(Token = "0x6009ED5")]
	[Address(RVA = "0xEC34C0", Offset = "0xEC26C0", VA = "0x180EC34C0")]
	protected void OnUpdateShowTurn(GameObject eom, int dataindex)
	{
	}

	[Token(Token = "0x6009ED6")]
	[Address(RVA = "0xEC3000", Offset = "0xEC2200", VA = "0x180EC3000")]
	protected void OnUpdateShowAction(GameObject eom, int dataindex)
	{
	}

	[Token(Token = "0x6009ED7")]
	[Address(RVA = "0xEC3170", Offset = "0xEC2370", VA = "0x180EC3170")]
	protected void OnUpdateShowChain(GameObject eom, int dataindex)
	{
	}

	[Token(Token = "0x6009ED8")]
	[Address(RVA = "0xEC3380", Offset = "0xEC2580", VA = "0x180EC3380")]
	protected void OnUpdateShowTag(GameObject eom, int dataindex)
	{
	}

	[Token(Token = "0x6009ED9")]
	[Address(RVA = "0xEC30B0", Offset = "0xEC22B0", VA = "0x180EC30B0")]
	protected void OnUpdateShowCardName(GameObject eom, int dataindex)
	{
	}

	[Token(Token = "0x6009EDA")]
	[Address(RVA = "0xEC3420", Offset = "0xEC2620", VA = "0x180EC3420")]
	protected void OnUpdateShowText(GameObject eom, int dataindex)
	{
	}

	[Token(Token = "0x6009EDB")]
	[Address(RVA = "0xEC32E0", Offset = "0xEC24E0", VA = "0x180EC32E0")]
	protected void OnUpdateShowPhase(GameObject eom, int dataindex)
	{
	}

	[Token(Token = "0x6009EDC")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60")]
	protected void OnUpdateSeparateLine(GameObject eom, int dataindex)
	{
	}

	[Token(Token = "0x6009EDD")]
	[Address(RVA = "0xEC2F60", Offset = "0xEC2160", VA = "0x180EC2F60")]
	protected void OnUpdateMoveMulti(GameObject eom, int dataindex)
	{
	}

	[Token(Token = "0x6009EDE")]
	[Address(RVA = "0xEC2EA0", Offset = "0xEC20A0", VA = "0x180EC2EA0")]
	protected void OnUpdateMoveMultiHeader(GameObject eom, int dataindex)
	{
	}

	[Token(Token = "0x6009EDF")]
	[Address(RVA = "0xEC3220", Offset = "0xEC2420", VA = "0x180EC3220")]
	protected void OnUpdateShowFirstPlayer(GameObject eom, int dataindex)
	{
	}

	[Token(Token = "0x6009EE0")]
	[Address(RVA = "0xEBEF70", Offset = "0xEBE170", VA = "0x180EBEF70")]
	protected void AfterAddLog(string label, int datalistcount, bool pushBuff = true)
	{
	}

	[Token(Token = "0x6009EE1")]
	[Address(RVA = "0xEC38A0", Offset = "0xEC2AA0", VA = "0x180EC38A0")]
	protected void PreAddLog(Engine.ViewType viewType, int param1, int param2, int param3)
	{
	}

	[Token(Token = "0x6009EE2")]
	[Address(RVA = "0xEBCC60", Offset = "0xEBBE60", VA = "0x180EBCC60")]
	protected void AddDuelStartLog(int param1, int param2, int param3)
	{
	}

	[Token(Token = "0x6009EE3")]
	[Address(RVA = "0xEBED70", Offset = "0xEBDF70", VA = "0x180EBED70")]
	protected void AddTurnChangeLog(int param1, int param2, int param3)
	{
	}

	[Token(Token = "0x6009EE4")]
	[Address(RVA = "0xEB8660", Offset = "0xEB7860", VA = "0x180EB8660")]
	protected void AddBattleAttackLog(int param1, int param2, int param3)
	{
	}

	[Token(Token = "0x6009EE5")]
	[Address(RVA = "0xEBD100", Offset = "0xEBC300", VA = "0x180EBD100")]
	protected void AddLifeDamageLog(int param1, int param2, int param3)
	{
	}

	[Token(Token = "0x6009EE6")]
	[Address(RVA = "0xEBDA00", Offset = "0xEBCC00", VA = "0x180EBDA00")]
	protected void AddPhaseChange(int param1, int param2, int param3)
	{
	}

	[Token(Token = "0x6009EE7")]
	[Address(RVA = "0xEBCE70", Offset = "0xEBC070", VA = "0x180EBCE70")]
	protected void AddHandOpenLog(int param1, int param2, int param3)
	{
	}

	[Token(Token = "0x6009EE8")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60")]
	protected void AddDeckShuffleLog(int param1, int param2, int param3)
	{
	}

	[Token(Token = "0x6009EE9")]
	[Address(RVA = "0xEBC900", Offset = "0xEBBB00", VA = "0x180EBC900")]
	protected void AddDeckFlipTopLog(int param1, int param2, int param3)
	{
	}

	[Token(Token = "0x6009EEA")]
	[Address(RVA = "0xEBAD80", Offset = "0xEB9F80", VA = "0x180EBAD80")]
	protected void AddCardLockonLog(int param1, int param2, int param3)
	{
	}

	[Token(Token = "0x6009EEB")]
	[Address(RVA = "0xEBB230", Offset = "0xEBA430", VA = "0x180EBB230")]
	protected void AddCardMoveLog(int param1, int param2, int param3)
	{
	}

	[Token(Token = "0x6009EEC")]
	[Address(RVA = "0xEBBB80", Offset = "0xEBAD80", VA = "0x180EBBB80")]
	protected void AddCardSwapLog(int param1, int param2, int param3)
	{
	}

	[Token(Token = "0x6009EED")]
	[Address(RVA = "0xEB9C90", Offset = "0xEB8E90", VA = "0x180EB9C90")]
	protected void AddCardFlipTurnLog(int param1, int param2, int param3)
	{
	}

	[Token(Token = "0x6009EEE")]
	[Address(RVA = "0xEBB7D0", Offset = "0xEBA9D0", VA = "0x180EBB7D0")]
	protected void AddCardSetLog(int param1, int param2, int param3)
	{
	}

	[Token(Token = "0x6009EEF")]
	[Address(RVA = "0xEB89C0", Offset = "0xEB7BC0", VA = "0x180EB89C0")]
	protected void AddCardBreakLog(int param1, int param2, int param3)
	{
	}

	[Token(Token = "0x6009EF0")]
	[Address(RVA = "0xEB97F0", Offset = "0xEB89F0", VA = "0x180EB97F0")]
	protected void AddCardExplosionLog(int param1, int param2, int param3)
	{
	}

	[Token(Token = "0x6009EF1")]
	[Address(RVA = "0xEBA190", Offset = "0xEB9390", VA = "0x180EBA190")]
	protected void AddCardHappenLog(int param1, int param2, int param3)
	{
	}

	[Token(Token = "0x6009EF2")]
	[Address(RVA = "0xEB9440", Offset = "0xEB8640", VA = "0x180EB9440")]
	protected void AddCardDisableLog(int param1, int param2, int param3)
	{
	}

	[Token(Token = "0x6009EF3")]
	[Address(RVA = "0xEBD550", Offset = "0xEBC750", VA = "0x180EBD550")]
	protected void AddManaSetLog(int param1, int param2, int param3)
	{
	}

	[Token(Token = "0x6009EF4")]
	[Address(RVA = "0xEBC580", Offset = "0xEBB780", VA = "0x180EBC580")]
	protected void AddChainSetLog(int param1, int param2, int param3)
	{
	}

	[Token(Token = "0x6009EF5")]
	[Address(RVA = "0xEBC430", Offset = "0xEBB630", VA = "0x180EBC430")]
	protected void AddChainRunLog(int param1, int param2, int param3)
	{
	}

	[Token(Token = "0x6009EF6")]
	[Address(RVA = "0xEBE5F0", Offset = "0xEBD7F0", VA = "0x180EBE5F0")]
	protected void AddRunSummonLog(int param1, int param2, int param3)
	{
	}

	[Token(Token = "0x6009EF7")]
	[Address(RVA = "0xEBDFE0", Offset = "0xEBD1E0", VA = "0x180EBDFE0")]
	protected void AddRunSpSummonLog(int param1, int param2, int param3)
	{
	}

	[Token(Token = "0x6009EF8")]
	[Address(RVA = "0xEBDF10", Offset = "0xEBD110", VA = "0x180EBDF10")]
	protected void AddRunFusionLog(int param1, int param2, int param3)
	{
	}

	[Token(Token = "0x6009EF9")]
	[Address(RVA = "0xEBDB10", Offset = "0xEBCD10", VA = "0x180EBDB10")]
	protected void AddRunCoinLog(int param1, int param2, int param3)
	{
	}

	[Token(Token = "0x6009EFA")]
	[Address(RVA = "0xEBDD00", Offset = "0xEBCF00", VA = "0x180EBDD00")]
	protected void AddRunDiceLog(int param1, int param2, int param3)
	{
	}

	[Token(Token = "0x6009EFB")]
	[Address(RVA = "0xEBC400", Offset = "0xEBB600", VA = "0x180EBC400")]
	protected void AddChainEndLog(int param1, int param2, int param3)
	{
	}

	[Token(Token = "0x6009EFC")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60")]
	protected void AddRunSpecialWinLog(int param1, int param2, int param3)
	{
	}

	[Token(Token = "0x6009EFD")]
	[Address(RVA = "0xEBEB80", Offset = "0xEBDD80", VA = "0x180EBEB80")]
	protected void AddShowTextLog(int param1, int param2, int param3)
	{
	}

	[Token(Token = "0x6009EFE")]
	[Address(RVA = "0xEB8E70", Offset = "0xEB8070", VA = "0x180EB8E70")]
	public void AddCardCheatLog(int param1, int param2, int param3, bool visible)
	{
	}

	[Token(Token = "0x6009EFF")]
	[Address(RVA = "0xEBC7C0", Offset = "0xEBB9C0", VA = "0x180EBC7C0")]
	public void AddChoiceFirstPlayerLog(int param1, int param2, int param3)
	{
	}

	[Token(Token = "0x6009F00")]
	[Address(RVA = "0xEBEB20", Offset = "0xEBDD20", VA = "0x180EBEB20")]
	protected void AddSeparateLine(bool pushBuff = true)
	{
	}

	[Token(Token = "0x6009F01")]
	[Address(RVA = "0xEBC660", Offset = "0xEBB860", VA = "0x180EBC660")]
	protected void AddChainTag(bool team, int cardid, int iNum, ShowChainData.ChainDataType type)
	{
	}

	[Token(Token = "0x6009F02")]
	[Address(RVA = "0xEC2540", Offset = "0xEC1740", VA = "0x180EC2540")]
	protected void Initialize()
	{
	}

	[Token(Token = "0x6009F03")]
	[Address(RVA = "0xEC2D20", Offset = "0xEC1F20", VA = "0x180EC2D20")]
	protected void OnScrollViewReady()
	{
	}

	[Token(Token = "0x6009F04")]
	[Address(RVA = "0xEC5820", Offset = "0xEC4A20", VA = "0x180EC5820")]
	protected void initializeComponent()
	{
	}

	[Token(Token = "0x6009F05")]
	[Address(RVA = "0xEC1E60", Offset = "0xEC1060", VA = "0x180EC1E60")]
	private void InitializePlayerInfo()
	{
	}

	[Token(Token = "0x6009F06")]
	[Address(RVA = "0xEC2040", Offset = "0xEC1240", VA = "0x180EC2040")]
	private void InitializeScroll()
	{
	}

	[Token(Token = "0x6009F07")]
	[Address(RVA = "0xEC0220", Offset = "0xEBF420", VA = "0x180EC0220")]
	private void InitializeDict()
	{
	}

	[Token(Token = "0x6009F08")]
	[Address(RVA = "0xEBF990", Offset = "0xEBEB90", VA = "0x180EBF990")]
	protected LOGACTIONTYPE GetActionType(Engine.CardMoveType moveType, Engine.CardStatus stFrom, Engine.CardStatus stTo, bool isCost)
	{
		return default(LOGACTIONTYPE);
	}

	[Token(Token = "0x6009F09")]
	[Address(RVA = "0xEBF350", Offset = "0xEBE550", VA = "0x180EBF350")]
	private void CheckSpSummon(ref LOGACTIONTYPE actiontype)
	{
	}

	[Token(Token = "0x6009F0A")]
	[Address(RVA = "0xEC48E0", Offset = "0xEC3AE0", VA = "0x180EC48E0")]
	public void SetSelectorPriority(SharedDefinition.DuelSelectorPriority priority)
	{
	}

	[Token(Token = "0x6009F0B")]
	[Address(RVA = "0xEC4780", Offset = "0xEC3980", VA = "0x180EC4780")]
	public bool SetPlayerIcon(Image img, int playerid)
	{
		return default(bool);
	}

	[Token(Token = "0x6009F0C")]
	[Address(RVA = "0x9CF0B0", Offset = "0x9CE2B0", VA = "0x1809CF0B0")]
	protected bool CheckCardidValid(int cardid)
	{
		return default(bool);
	}

	[Token(Token = "0x6009F0D")]
	[Address(RVA = "0xEC4F10", Offset = "0xEC4110", VA = "0x180EC4F10")]
	protected void UpdateColorBar(string label)
	{
	}

	[Token(Token = "0x6009F0E")]
	[Address(RVA = "0xEBFD80", Offset = "0xEBEF80", VA = "0x180EBFD80")]
	private float GetLabelLength(string label)
	{
		return default(float);
	}

	[Token(Token = "0x6009F0F")]
	[Address(RVA = "0xEBF110", Offset = "0xEBE310", VA = "0x180EBF110")]
	protected void BuffMoveData(ShowActionData actionData, Engine.CardMoveType moveType)
	{
	}

	[Token(Token = "0x6009F10")]
	[Address(RVA = "0xEC3D50", Offset = "0xEC2F50", VA = "0x180EC3D50")]
	public void PushBuff()
	{
	}

	[Token(Token = "0x6009F11")]
	[Address(RVA = "0xEC5150", Offset = "0xEC4350", VA = "0x180EC5150")]
	public DuelLogController()
	{
	}
}
