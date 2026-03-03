using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using YgomGame.Card;
using YgomSystem.UI;
using YgomSystem.Utility;
using YgomSystem.YGomTMPro;

namespace YgomGame.Duel;

[Token(Token = "0x200184D")]
public class CardInfo : CardInfoBase, IGameObjectPool
{
	[Token(Token = "0x200184E")]
	public enum ShowPos
	{
		[Token(Token = "0x400E3C8")]
		Left,
		[Token(Token = "0x400E3C9")]
		Right,
		[Token(Token = "0x400E3CA")]
		Top,
		[Token(Token = "0x400E3CB")]
		Bottom,
		[Token(Token = "0x400E3CC")]
		None,
		[Token(Token = "0x400E3CD")]
		NoChange
	}

	[Token(Token = "0x2001851")]
	[CompilerGenerated]
	private sealed class _003CSetHighlightTextToFirstView_003Ed__99 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400E3D2")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400E3D3")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400E3D4")]
		[FieldOffset(Offset = "0x20")]
		public CardInfo _003C_003E4__this;

		[Token(Token = "0x400E3D5")]
		[FieldOffset(Offset = "0x28")]
		private ScrollRect _003Cscrollrect_003E5__2;

		[Token(Token = "0x400E3D6")]
		[FieldOffset(Offset = "0x30")]
		private float _003CextraHeightOfContent_003E5__3;

		[Token(Token = "0x400E3D7")]
		[FieldOffset(Offset = "0x34")]
		private float _003CtopToHighlightAreaDistance_003E5__4;

		[Token(Token = "0x400E3D8")]
		[FieldOffset(Offset = "0x38")]
		private float _003CscrollBarValueTarget_003E5__5;

		[Token(Token = "0x17001775")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6009AE7")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17001776")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6009AE9")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6009AE4")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CSetHighlightTextToFirstView_003Ed__99(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6009AE5")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6009AE6")]
		[Address(RVA = "0xE666E0", Offset = "0xE658E0", VA = "0x180E666E0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6009AE8")]
		[Address(RVA = "0xE66A40", Offset = "0xE65C40", VA = "0x180E66A40", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x400E39F")]
	private const string HIGHLIGHTTAG_STYLE_0 = "<style=\"notice2\">";

	[Token(Token = "0x400E3A0")]
	private const string HIGHLIGHTTAG_STYLE_1 = "</style>";

	[Token(Token = "0x400E3A1")]
	private const string HIGHLIGHTTAG_COLOR_77 = "<color=#777777>";

	[Token(Token = "0x400E3A2")]
	private const string HIGHLIGHTTAG_COLOR_FF = "<color=#FFFFFF>";

	[Token(Token = "0x400E3A3")]
	private const string HIGHLIGHTTAG_COLOR_MY = "<color=#00AEEF>";

	[Token(Token = "0x400E3A4")]
	private const string HIGHLIGHTTAG_COLOR_RIVAL = "<color=#FF00FF>";

	[Token(Token = "0x400E3A5")]
	private const string HIGHLIGHTTAG_COLOR_YELLOW = "<color=#FFFF00>";

	[Token(Token = "0x400E3A6")]
	private const string HIGHLIGHTTAG_COLOR_END = "</color>";

	[Token(Token = "0x400E3A7")]
	protected const string LABEL_IMG_SWITCHCOUNTER = "SwitchCounterIcon";

	[Token(Token = "0x400E3A8")]
	protected const string LABEL_TXT_SWITCHCOUNTER = "SwitchCounterText";

	[Token(Token = "0x400E3A9")]
	protected const string LABEL_GO_SWITCHCOUNTER = "SwitchCounter";

	[Token(Token = "0x400E3AA")]
	protected const string LABEL_TW_ZOOMIN = "ZoomIn";

	[Token(Token = "0x400E3AB")]
	protected const string LABEL_TW_ZOOMOUT = "ZoomOut";

	[Token(Token = "0x400E3AC")]
	[FieldOffset(Offset = "0x340")]
	protected ExtendedTextMeshProUGUI m_SwitchCounterText_Property;

	[Token(Token = "0x400E3AD")]
	[FieldOffset(Offset = "0x348")]
	protected Image m_SwitchCounterIcon_Property;

	[Token(Token = "0x400E3AE")]
	[FieldOffset(Offset = "0x350")]
	protected GameObject m_SwitchCounter_Property;

	[Token(Token = "0x400E3AF")]
	[FieldOffset(Offset = "0x358")]
	protected ExtendedTextMeshProUGUI m_DspContentSub_Property;

	[Token(Token = "0x400E3B0")]
	[FieldOffset(Offset = "0x360")]
	protected Tween m_TW_SwitchCounter_Property;

	[Token(Token = "0x400E3B1")]
	[FieldOffset(Offset = "0x368")]
	protected Tween m_TW_SwitchAttribute_Property;

	[Token(Token = "0x400E3B2")]
	protected const string PATH_PREFAB = "Prefabs/Duel/UI/CardInfo";

	[Token(Token = "0x400E3B3")]
	protected const string PATH_PREFAB_MINI = "Prefabs/Duel/UI/CardInfoMini";

	[Token(Token = "0x400E3B4")]
	protected const int MAXCOUNTERNUM = 1;

	[Token(Token = "0x400E3B5")]
	[FieldOffset(Offset = "0x370")]
	private bool cardLock;

	[Token(Token = "0x400E3B6")]
	[FieldOffset(Offset = "0x371")]
	private bool m_FromCardSelectionList;

	[Token(Token = "0x400E3B7")]
	[FieldOffset(Offset = "0x378")]
	private Coroutine m_CurrentCoroutine;

	[Token(Token = "0x400E3B8")]
	[FieldOffset(Offset = "0x380")]
	private DuelClient m_Host;

	[Token(Token = "0x400E3B9")]
	[FieldOffset(Offset = "0x388")]
	private int m_HighlightRfxTableIndex;

	[Token(Token = "0x400E3BA")]
	[FieldOffset(Offset = "0x390")]
	private List<int> efxNoList;

	[Token(Token = "0x400E3BB")]
	[FieldOffset(Offset = "0x398")]
	private int m_CurrentCounterIndex;

	[Token(Token = "0x400E3BC")]
	[FieldOffset(Offset = "0x39C")]
	private bool m_IsSwitching;

	[Token(Token = "0x400E3BD")]
	[FieldOffset(Offset = "0x3A0")]
	private float m_DeltaTime;

	[Token(Token = "0x400E3BF")]
	[FieldOffset(Offset = "0x3A8")]
	private List<Content.Attribute> m_AttributeList;

	[Token(Token = "0x400E3C0")]
	[FieldOffset(Offset = "0x3B0")]
	private int m_CurrentAttributeIndex;

	[Token(Token = "0x400E3C1")]
	[FieldOffset(Offset = "0x3B4")]
	private bool m_IsSwitchingAttr;

	[Token(Token = "0x400E3C4")]
	[FieldOffset(Offset = "0x3C8")]
	public ShowPos currentMiniPos;

	[Token(Token = "0x400E3C5")]
	[FieldOffset(Offset = "0x3D0")]
	private UiSwitchTweenAnimationController m_UISwitch_Property;

	[Token(Token = "0x400E3C6")]
	[FieldOffset(Offset = "0x3D8")]
	public string key;

	[Token(Token = "0x17001768")]
	protected ExtendedTextMeshProUGUI m_SwitchCounterText
	{
		[Token(Token = "0x6009AA6")]
		[Address(RVA = "0xE65CE0", Offset = "0xE64EE0", VA = "0x180E65CE0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001769")]
	protected Image m_SwitchCounterIcon
	{
		[Token(Token = "0x6009AA7")]
		[Address(RVA = "0xE65C10", Offset = "0xE64E10", VA = "0x180E65C10")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700176A")]
	protected GameObject m_SwitchCounter
	{
		[Token(Token = "0x6009AA8")]
		[Address(RVA = "0xE65DB0", Offset = "0xE64FB0", VA = "0x180E65DB0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700176B")]
	protected ExtendedTextMeshProUGUI m_DspContentSub
	{
		[Token(Token = "0x6009AA9")]
		[Address(RVA = "0xE65B40", Offset = "0xE64D40", VA = "0x180E65B40")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700176C")]
	protected Tween m_TW_SwitchCounter
	{
		[Token(Token = "0x6009AAA")]
		[Address(RVA = "0xE65F40", Offset = "0xE65140", VA = "0x180E65F40")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700176D")]
	protected Tween m_TW_SwitchAttribute
	{
		[Token(Token = "0x6009AAB")]
		[Address(RVA = "0xE65E70", Offset = "0xE65070", VA = "0x180E65E70")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700176E")]
	public bool isMini
	{
		[Token(Token = "0x6009AAF")]
		[Address(RVA = "0xE65B30", Offset = "0xE64D30", VA = "0x180E65B30")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6009AB0")]
		[Address(RVA = "0xE661C0", Offset = "0xE653C0", VA = "0x180E661C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x1700176F")]
	public UnityEvent onOpenEvent
	{
		[Token(Token = "0x6009AB1")]
		[Address(RVA = "0xE660C0", Offset = "0xE652C0", VA = "0x180E660C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6009AB2")]
		[Address(RVA = "0xE661F0", Offset = "0xE653F0", VA = "0x180E661F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17001770")]
	public UnityEvent onCloseEvent
	{
		[Token(Token = "0x6009AB3")]
		[Address(RVA = "0xE660B0", Offset = "0xE652B0", VA = "0x180E660B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6009AB4")]
		[Address(RVA = "0xE661D0", Offset = "0xE653D0", VA = "0x180E661D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17001771")]
	public Vector2 windowSize
	{
		[Token(Token = "0x6009AB5")]
		[Address(RVA = "0xE660E0", Offset = "0xE652E0", VA = "0x180E660E0")]
		get
		{
			return default(Vector2);
		}
	}

	[Token(Token = "0x17001772")]
	private UiSwitchTweenAnimationController m_UISwitch
	{
		[Token(Token = "0x6009AB6")]
		[Address(RVA = "0xE66010", Offset = "0xE65210", VA = "0x180E66010")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001773")]
	public string poolKey
	{
		[Token(Token = "0x6009AB7")]
		[Address(RVA = "0xE660D0", Offset = "0xE652D0", VA = "0x180E660D0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001774")]
	public GameObject pooledTarget
	{
		[Token(Token = "0x6009AB8")]
		[Address(RVA = "0x4A1C50", Offset = "0x4A0E50", VA = "0x1804A1C50", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6009AAC")]
	[Address(RVA = "0xE61D50", Offset = "0xE60F50", VA = "0x180E61D50")]
	public static bool IsResourceLoaded(bool isMini)
	{
		return default(bool);
	}

	[Token(Token = "0x6009AAD")]
	[Address(RVA = "0xE61F60", Offset = "0xE61160", VA = "0x180E61F60")]
	public static void LoadResource(bool isMini)
	{
	}

	[Token(Token = "0x6009AAE")]
	[Address(RVA = "0xE65300", Offset = "0xE64500", VA = "0x180E65300")]
	public static void UnloadResource(bool isMini)
	{
	}

	[Token(Token = "0x6009AB9")]
	[Address(RVA = "0xE61E60", Offset = "0xE61060", VA = "0x180E61E60")]
	public static void LoadPrefab(bool isMini, UnityAction<GameObject> onFinished)
	{
	}

	[Token(Token = "0x6009ABA")]
	[Address(RVA = "0xE64D30", Offset = "0xE63F30", VA = "0x180E64D30")]
	public void Show(ShowPos miniPos)
	{
	}

	[Token(Token = "0x6009ABB")]
	[Address(RVA = "0xE63DF0", Offset = "0xE62FF0", VA = "0x180E63DF0")]
	public void SetMiniPos(ShowPos miniPos)
	{
	}

	[Token(Token = "0x6009ABC")]
	[Address(RVA = "0xE63460", Offset = "0xE62660", VA = "0x180E63460")]
	public void SetCardByUniqueId(int uniqueId, ShowPos miniPos, bool force = false, bool fromCardSelectionList = false, int highlightRfxTableIndex = -1)
	{
	}

	[Token(Token = "0x6009ABD")]
	[Address(RVA = "0xE632B0", Offset = "0xE624B0", VA = "0x180E632B0")]
	public void SetCardByCardId(int cardid, ShowPos miniPos, int styleid = 1, bool force = true, bool fromCardSelectionList = false, int player = -1, int highlightRfxTableIndex = -1)
	{
	}

	[Token(Token = "0x6009ABE")]
	[Address(RVA = "0xE63740", Offset = "0xE62940", VA = "0x180E63740")]
	public void SetCardLock(bool cardLock)
	{
	}

	[Token(Token = "0x6009ABF")]
	[Address(RVA = "0xE60B60", Offset = "0xE5FD60", VA = "0x180E60B60")]
	public void Close()
	{
	}

	[Token(Token = "0x6009AC0")]
	[Address(RVA = "0xE61400", Offset = "0xE60600", VA = "0x180E61400")]
	public void Initialize(DuelClient host, bool isLeft, bool ismini, bool onCreated = true)
	{
	}

	[Token(Token = "0x6009AC1")]
	[Address(RVA = "0xE64730", Offset = "0xE63930", VA = "0x180E64730")]
	public void SetSelectorPriority(SharedDefinition.DuelSelectorPriority priority)
	{
	}

	[Token(Token = "0x6009AC2")]
	[Address(RVA = "0xE647C0", Offset = "0xE639C0", VA = "0x180E647C0")]
	public void SetShortkeyIconVisible(bool visible)
	{
	}

	[Token(Token = "0x6009AC3")]
	[Address(RVA = "0xE64310", Offset = "0xE63510", VA = "0x180E64310")]
	public void SetPos(ShowPos pos)
	{
	}

	[Token(Token = "0x6009AC4")]
	[Address(RVA = "0xE64B30", Offset = "0xE63D30", VA = "0x180E64B30")]
	protected void SetTitleArea()
	{
	}

	[Token(Token = "0x6009AC5")]
	[Address(RVA = "0xE64A80", Offset = "0xE63C80", VA = "0x180E64A80")]
	protected void SetTitleAreaByCardId()
	{
	}

	[Token(Token = "0x6009AC6")]
	[Address(RVA = "0xE62080", Offset = "0xE61280", VA = "0x180E62080")]
	protected void ScrollReset()
	{
	}

	[Token(Token = "0x6009AC7")]
	[Address(RVA = "0xE62C90", Offset = "0xE61E90", VA = "0x180E62C90")]
	protected void SetCardArea()
	{
	}

	[Token(Token = "0x6009AC8")]
	[Address(RVA = "0xE63E10", Offset = "0xE63010", VA = "0x180E63E10")]
	protected void SetParameterArea()
	{
	}

	[Token(Token = "0x6009AC9")]
	[Address(RVA = "0xE64A60", Offset = "0xE63C60", VA = "0x180E64A60")]
	private void SetSwitchCounter()
	{
	}

	[Token(Token = "0x6009ACA")]
	[Address(RVA = "0xE654A0", Offset = "0xE646A0", VA = "0x180E654A0")]
	private void UpdateCounter()
	{
	}

	[Token(Token = "0x6009ACB")]
	[Address(RVA = "0xE651B0", Offset = "0xE643B0", VA = "0x180E651B0")]
	private void SwitchToNextCounter()
	{
	}

	[Token(Token = "0x6009ACC")]
	[Address(RVA = "0xE64850", Offset = "0xE63A50", VA = "0x180E64850")]
	private void SetSwitchAttribute()
	{
	}

	[Token(Token = "0x6009ACD")]
	[Address(RVA = "0xE65360", Offset = "0xE64560", VA = "0x180E65360")]
	private void UpdateAttribute()
	{
	}

	[Token(Token = "0x6009ACE")]
	[Address(RVA = "0xE65010", Offset = "0xE64210", VA = "0x180E65010")]
	private void SwitchToNextAttribute()
	{
	}

	[Token(Token = "0x6009ACF")]
	[Address(RVA = "0xE63750", Offset = "0xE62950", VA = "0x180E63750")]
	protected void SetDescriptionArea()
	{
	}

	[Token(Token = "0x6009AD0")]
	[Address(RVA = "0xE63970", Offset = "0xE62B70", VA = "0x180E63970")]
	protected void SetDspContent(int cardidorg, int effectid, int owner, bool isInField = false, bool isPdlPos = false, int effflag = 0)
	{
	}

	[Token(Token = "0x6009AD1")]
	[Address(RVA = "0xE611C0", Offset = "0xE603C0", VA = "0x180E611C0")]
	private void HighlightTextFromTable(string originalText)
	{
	}

	[Token(Token = "0x6009AD2")]
	[Address(RVA = "0xE60BF0", Offset = "0xE5FDF0", VA = "0x180E60BF0")]
	private void HighlightProvess(string tohappentext, string happeningtext, string tosummontext, string orgtext)
	{
	}

	[Token(Token = "0x6009AD3")]
	[Address(RVA = "0xE63D80", Offset = "0xE62F80", VA = "0x180E63D80")]
	[IteratorStateMachine(typeof(_003CSetHighlightTextToFirstView_003Ed__99))]
	private IEnumerator SetHighlightTextToFirstView()
	{
		return null;
	}

	[Token(Token = "0x6009AD4")]
	[Address(RVA = "0xE62160", Offset = "0xE61360", VA = "0x180E62160")]
	private void SetActivatedIconFromActivatedCardEffectNoDict(int cardId, int owner)
	{
	}

	[Token(Token = "0x6009AD5")]
	[Address(RVA = "0xE62370", Offset = "0xE61570", VA = "0x180E62370")]
	private void SetActivatedIconFromActivatedCardEffectNoList(List<int> effectNoList, int cardId, string ActivatedIconStr)
	{
	}

	[Token(Token = "0x6009AD6")]
	[Address(RVA = "0xE64CF0", Offset = "0xE63EF0", VA = "0x180E64CF0")]
	private void SetupCardData()
	{
	}

	[Token(Token = "0x6009AD7")]
	[Address(RVA = "0xE656F0", Offset = "0xE648F0", VA = "0x180E656F0")]
	private void Update()
	{
	}

	[Token(Token = "0x6009AD8")]
	[Address(RVA = "0xE61FC0", Offset = "0xE611C0", VA = "0x180E61FC0", Slot = "7")]
	public void OnReturned()
	{
	}

	[Token(Token = "0x6009AD9")]
	[Address(RVA = "0xE65A00", Offset = "0xE64C00", VA = "0x180E65A00")]
	public CardInfo()
	{
	}
}
