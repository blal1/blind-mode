using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using YgomGame.Duel;
using YgomSystem.ElementSystem;

namespace YgomDebug;

[Token(Token = "0x2000122")]
public class DuelLogForAnalysis : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x2000123")]
	public class SerializableList<T>
	{
		[Token(Token = "0x40006F2")]
		[FieldOffset(Offset = "0x0")]
		public List<T> list;

		[Token(Token = "0x6000750")]
		public SerializableList()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x2000124")]
	public class DuelLogData
	{
		[Token(Token = "0x40006F3")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		public SerializableList<LogBaseDataForAnalysis> m_LogBaseItemList;

		[Token(Token = "0x40006F4")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		public SerializableList<ShowTurnDataForAnalysis> m_DataList_ShowTurn;

		[Token(Token = "0x40006F5")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		public SerializableList<ShowActionDataForAnalysis> m_DataList_ShowAction;

		[Token(Token = "0x40006F6")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		public SerializableList<ShowChainDataForAnalysis> m_DataList_ShowChain;

		[Token(Token = "0x40006F7")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		public SerializableList<ShowCardNameDataForAnalysis> m_DataList_ShowCardName;

		[Token(Token = "0x40006F8")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		public SerializableList<ShowTextDataForAnalysis> m_DataList_ShowText;

		[Token(Token = "0x40006F9")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		public SerializableList<ShowPhaseDataForAnalysis> m_DataList_ShowPhase;

		[Token(Token = "0x40006FA")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		public SerializableList<ShowTagTypeForAnalysis> m_DataList_ShowTag;

		[Token(Token = "0x40006FB")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		public SerializableList<string> m_DataLabelList;

		[Token(Token = "0x40006FC")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		public SerializableList<string> m_TextTable;

		[Token(Token = "0x6000751")]
		[Address(RVA = "0x9CD650", Offset = "0x9CC850", VA = "0x1809CD650")]
		public static DuelLogData CreateFromJson(string json)
		{
			return null;
		}

		[Token(Token = "0x6000752")]
		[Address(RVA = "0x9CD610", Offset = "0x9CC810", VA = "0x1809CD610")]
		public static DuelLogData CreateFromDuelLogControllerData(string json)
		{
			return null;
		}

		[Token(Token = "0x6000753")]
		[Address(RVA = "0x9CD690", Offset = "0x9CC890", VA = "0x1809CD690")]
		public void SetDataFromDuelLogData(List<LogBaseData> logBaseDatas, List<ShowTurnData> showTurnDatas, List<ShowActionData> showActionDatas, List<ShowChainData> showChainDatas, List<ShowCardNameData> showCardNameDatas, List<ShowTextData> showTextDatas, List<ShowPhaseData> showPhaseDatas, List<ShowTagData> showTagTypes, List<string> dataLabelList, List<string> textTable)
		{
		}

		[Token(Token = "0x6000754")]
		[Address(RVA = "0x9CED10", Offset = "0x9CDF10", VA = "0x1809CED10")]
		public DuelLogData()
		{
		}
	}

	[Token(Token = "0x40006CD")]
	public const int INVALIDCARDID = 0;

	[Token(Token = "0x40006CE")]
	public const string LABEL_SHOWTURN = "ShowTurn";

	[Token(Token = "0x40006CF")]
	public const string LABEL_SHOWACTION = "ShowAction";

	[Token(Token = "0x40006D0")]
	public const string LABEL_SHOWCHAIN = "ShowChain";

	[Token(Token = "0x40006D1")]
	public const string LABEL_SHOWTAG = "ShowTag";

	[Token(Token = "0x40006D2")]
	public const string LABEL_SHOWCARDNAME = "ShowCardName";

	[Token(Token = "0x40006D3")]
	public const string LABEL_SHOWTEXT = "ShowText";

	[Token(Token = "0x40006D4")]
	public const string LABEL_SHOWPHASE = "ShowPhase";

	[Token(Token = "0x40006D5")]
	public const string LABEL_SAPERATELINE = "SeparateLine";

	[Token(Token = "0x40006D6")]
	public const string LABEL_ROOT = "Root";

	[Token(Token = "0x40006D7")]
	public const string LABEL_SCROLLUP = "ScrollUp";

	[Token(Token = "0x40006D8")]
	public const string LABEL_SCROLLDOWN = "ScrollDown";

	[Token(Token = "0x40006D9")]
	public const string LABEL_SCROLLVIEW = "ScrollView";

	[Token(Token = "0x40006DA")]
	public const string LABEL_BG = "Bg";

	[Token(Token = "0x40006DB")]
	public const string LABEL_TWEEN_SHOWLOG = "ShowLog";

	[Token(Token = "0x40006DC")]
	public const string LABEL_TWEEN_HIDELOG = "HideLog";

	[Token(Token = "0x40006DD")]
	public const string LABEL_TWEEN_READY = "Ready";

	[Token(Token = "0x40006DE")]
	public const string SE_LOG_OPEN = "SE_LOG_OPEN";

	[Token(Token = "0x40006DF")]
	public const string SE_LOG_CLOSE = "SE_LOG_CLOSE";

	[Token(Token = "0x40006E0")]
	private const string PREFAB_NAME = "Prefabs/VC/Debug/DuelLogForAnalysis";

	[Token(Token = "0x40006E3")]
	[FieldOffset(Offset = "0x30")]
	public DuelLogData m_DuelLogData;

	[Token(Token = "0x40006E4")]
	[FieldOffset(Offset = "0x38")]
	protected ElementObjectManager m_EOManager;

	[Token(Token = "0x40006E5")]
	[FieldOffset(Offset = "0x40")]
	protected DuelLogScrollViewForAnalysis m_ScrollView;

	[Token(Token = "0x40006E6")]
	[FieldOffset(Offset = "0x48")]
	protected Dictionary<string, int> m_DataTypeNumDict;

	[Token(Token = "0x40006E7")]
	[FieldOffset(Offset = "0x50")]
	protected Dictionary<Engine.ViewType, LogHandler> m_LogHandlerDict;

	[Token(Token = "0x40006E8")]
	[FieldOffset(Offset = "0x58")]
	protected Dictionary<string, LogItemHandler> m_UpdateItemDict;

	[Token(Token = "0x40006E9")]
	[FieldOffset(Offset = "0x60")]
	protected List<string> m_TemplateLabelList;

	[Token(Token = "0x40006EA")]
	[FieldOffset(Offset = "0x68")]
	protected Dictionary<int, Sprite> m_PlayerIconTable;

	[Token(Token = "0x40006EB")]
	[FieldOffset(Offset = "0x70")]
	protected Dictionary<int, Material> m_PlayerFrameTable;

	[Token(Token = "0x40006EC")]
	[FieldOffset(Offset = "0x78")]
	protected bool m_CloseTemprary;

	[Token(Token = "0x40006ED")]
	[FieldOffset(Offset = "0x80")]
	protected GameObject m_bgObj;

	[Token(Token = "0x40006EE")]
	[FieldOffset(Offset = "0x88")]
	private bool m_IsOpen;

	[Token(Token = "0x40006EF")]
	[FieldOffset(Offset = "0x8C")]
	private SPSUMMONTYPE m_SpSummonFlag;

	[Token(Token = "0x40006F0")]
	[FieldOffset(Offset = "0x90")]
	private int m_SpSummonFlagCount;

	[Token(Token = "0x40006F1")]
	[FieldOffset(Offset = "0x94")]
	private int m_ChainCount;

	[Token(Token = "0x170000A1")]
	public bool isOpen
	{
		[Token(Token = "0x6000722")]
		[Address(RVA = "0x422F90", Offset = "0x422190", VA = "0x180422F90")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170000A2")]
	public Action<bool> onChangeOpenClose
	{
		[Token(Token = "0x6000723")]
		[Address(RVA = "0x3D8370", Offset = "0x3D7570", VA = "0x1803D8370")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6000724")]
		[Address(RVA = "0x3D8380", Offset = "0x3D7580", VA = "0x1803D8380")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x170000A3")]
	public bool IsReady
	{
		[Token(Token = "0x6000725")]
		[Address(RVA = "0x588F60", Offset = "0x588160", VA = "0x180588F60")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000726")]
		[Address(RVA = "0x588F70", Offset = "0x588170", VA = "0x180588F70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x170000A4")]
	protected bool m_IsIndent
	{
		[Token(Token = "0x6000727")]
		[Address(RVA = "0x9D18D0", Offset = "0x9D0AD0", VA = "0x1809D18D0")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170000A5")]
	private List<LogBaseDataForAnalysis> m_LogBaseItemList
	{
		[Token(Token = "0x6000728")]
		[Address(RVA = "0x9D18E0", Offset = "0x9D0AE0", VA = "0x1809D18E0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170000A6")]
	private List<ShowTurnDataForAnalysis> m_DataList_ShowTurn
	{
		[Token(Token = "0x6000729")]
		[Address(RVA = "0x9D18A0", Offset = "0x9D0AA0", VA = "0x1809D18A0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170000A7")]
	private List<ShowActionDataForAnalysis> m_DataList_ShowAction
	{
		[Token(Token = "0x600072A")]
		[Address(RVA = "0x9D1780", Offset = "0x9D0980", VA = "0x1809D1780")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170000A8")]
	private List<ShowChainDataForAnalysis> m_DataList_ShowChain
	{
		[Token(Token = "0x600072B")]
		[Address(RVA = "0x9D17E0", Offset = "0x9D09E0", VA = "0x1809D17E0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170000A9")]
	private List<ShowCardNameDataForAnalysis> m_DataList_ShowCardName
	{
		[Token(Token = "0x600072C")]
		[Address(RVA = "0x9D17B0", Offset = "0x9D09B0", VA = "0x1809D17B0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170000AA")]
	private List<ShowTextDataForAnalysis> m_DataList_ShowText
	{
		[Token(Token = "0x600072D")]
		[Address(RVA = "0x9D1870", Offset = "0x9D0A70", VA = "0x1809D1870")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170000AB")]
	private List<ShowPhaseDataForAnalysis> m_DataList_ShowPhase
	{
		[Token(Token = "0x600072E")]
		[Address(RVA = "0x9D1810", Offset = "0x9D0A10", VA = "0x1809D1810")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170000AC")]
	private List<ShowTagTypeForAnalysis> m_DataList_ShowTag
	{
		[Token(Token = "0x600072F")]
		[Address(RVA = "0x9D1840", Offset = "0x9D0A40", VA = "0x1809D1840")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000730")]
	[Address(RVA = "0x9CF320", Offset = "0x9CE520", VA = "0x1809CF320")]
	public static DuelLogForAnalysis Create(Transform parent)
	{
		return null;
	}

	[Token(Token = "0x6000731")]
	[Address(RVA = "0x9D0D60", Offset = "0x9CFF60", VA = "0x1809D0D60")]
	public void Open()
	{
	}

	[Token(Token = "0x6000732")]
	[Address(RVA = "0x9CF170", Offset = "0x9CE370", VA = "0x1809CF170")]
	public void Close()
	{
	}

	[Token(Token = "0x6000733")]
	[Address(RVA = "0x9CF150", Offset = "0x9CE350", VA = "0x1809CF150")]
	public void CloseTemprary()
	{
	}

	[Token(Token = "0x6000734")]
	[Address(RVA = "0x9D0E80", Offset = "0x9D0080", VA = "0x1809D0E80")]
	public void Resume()
	{
	}

	[Token(Token = "0x6000735")]
	[Address(RVA = "0x9D0FB0", Offset = "0x9D01B0", VA = "0x1809D0FB0")]
	public void SetAlpha(float alpha)
	{
	}

	[Token(Token = "0x6000736")]
	[Address(RVA = "0x9D1030", Offset = "0x9D0230", VA = "0x1809D1030")]
	public void SetAutoScroll(bool auto)
	{
	}

	[Token(Token = "0x6000737")]
	[Address(RVA = "0x9D1200", Offset = "0x9D0400", VA = "0x1809D1200")]
	public void SetShortkeyIconVisible(bool visible)
	{
	}

	[Token(Token = "0x6000738")]
	[Address(RVA = "0x9CEFF0", Offset = "0x9CE1F0", VA = "0x1809CEFF0")]
	public void AddLogData(Engine.ViewType viewType, int param1, int param2, int param3)
	{
	}

	[Token(Token = "0x6000739")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60")]
	public void AddLogText(int player, string text)
	{
	}

	[Token(Token = "0x600073A")]
	[Address(RVA = "0x9D1320", Offset = "0x9D0520", VA = "0x1809D1320")]
	public void UpdateLogData(DuelLogData duelLogData)
	{
	}

	[Token(Token = "0x600073B")]
	[Address(RVA = "0x9D0440", Offset = "0x9CF640", VA = "0x1809D0440")]
	protected void OnUpdateListItemBase(GameObject gob, int baseitemindex)
	{
	}

	[Token(Token = "0x600073C")]
	[Address(RVA = "0x9D0BB0", Offset = "0x9CFDB0", VA = "0x1809D0BB0")]
	protected void OnUpdateShowTurn(GameObject eom, int dataindex)
	{
	}

	[Token(Token = "0x600073D")]
	[Address(RVA = "0x9D0500", Offset = "0x9CF700", VA = "0x1809D0500")]
	protected void OnUpdateShowAction(GameObject eom, int dataindex)
	{
	}

	[Token(Token = "0x600073E")]
	[Address(RVA = "0x9D0680", Offset = "0x9CF880", VA = "0x1809D0680")]
	protected void OnUpdateShowChain(GameObject eom, int dataindex)
	{
	}

	[Token(Token = "0x600073F")]
	[Address(RVA = "0x9D0800", Offset = "0x9CFA00", VA = "0x1809D0800")]
	protected void OnUpdateShowTag(GameObject eom, int dataindex)
	{
	}

	[Token(Token = "0x6000740")]
	[Address(RVA = "0x9D05D0", Offset = "0x9CF7D0", VA = "0x1809D05D0")]
	protected void OnUpdateShowCardName(GameObject eom, int dataindex)
	{
	}

	[Token(Token = "0x6000741")]
	[Address(RVA = "0x9D09E0", Offset = "0x9CFBE0", VA = "0x1809D09E0")]
	protected void OnUpdateShowText(GameObject eom, int dataindex)
	{
	}

	[Token(Token = "0x6000742")]
	[Address(RVA = "0x9D0750", Offset = "0x9CF950", VA = "0x1809D0750")]
	protected void OnUpdateShowPhase(GameObject eom, int dataindex)
	{
	}

	[Token(Token = "0x6000743")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60")]
	protected void OnUpdateSeparateLine(GameObject eom, int dataindex)
	{
	}

	[Token(Token = "0x6000744")]
	[Address(RVA = "0x9D0390", Offset = "0x9CF590", VA = "0x1809D0390")]
	private void Initialize()
	{
	}

	[Token(Token = "0x6000745")]
	[Address(RVA = "0x9D03B0", Offset = "0x9CF5B0", VA = "0x1809D03B0")]
	private void OnScrollViewReady()
	{
	}

	[Token(Token = "0x6000746")]
	[Address(RVA = "0x9D1910", Offset = "0x9D0B10", VA = "0x1809D1910")]
	private void initializeComponent()
	{
	}

	[Token(Token = "0x6000747")]
	[Address(RVA = "0x9CF7B0", Offset = "0x9CE9B0", VA = "0x1809CF7B0")]
	private void InitializeDict()
	{
	}

	[Token(Token = "0x6000748")]
	[Address(RVA = "0x9CF440", Offset = "0x9CE640", VA = "0x1809CF440")]
	private LOGACTIONTYPE GetActionType(Engine.CardMoveType moveType, Engine.CardStatus stFrom, Engine.CardStatus stTo)
	{
		return default(LOGACTIONTYPE);
	}

	[Token(Token = "0x6000749")]
	[Address(RVA = "0x9CF0C0", Offset = "0x9CE2C0", VA = "0x1809CF0C0")]
	private void CheckSpSummon(ref LOGACTIONTYPE actiontype)
	{
	}

	[Token(Token = "0x600074A")]
	[Address(RVA = "0x9D1170", Offset = "0x9D0370", VA = "0x1809D1170")]
	public void SetSelectorPriority(SharedDefinition.DuelSelectorPriority priority)
	{
	}

	[Token(Token = "0x600074B")]
	[Address(RVA = "0x9D1050", Offset = "0x9D0250", VA = "0x1809D1050")]
	public bool SetPlayerIcon(Image img, int playerid)
	{
		return default(bool);
	}

	[Token(Token = "0x600074C")]
	[Address(RVA = "0x9CF0B0", Offset = "0x9CE2B0", VA = "0x1809CF0B0")]
	private bool CheckCardidValid(int cardid)
	{
		return default(bool);
	}

	[Token(Token = "0x600074D")]
	[Address(RVA = "0x9D1570", Offset = "0x9D0770", VA = "0x1809D1570")]
	public DuelLogForAnalysis()
	{
	}
}
