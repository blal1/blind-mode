using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using YgomGame.Menu;
using YgomSystem.ElementSystem;
using YgomSystem.UI;
using YgomSystem.YGomTMPro;

namespace YgomGame.WCS;

[Token(Token = "0x200073D")]
public class WinPredictionViewController : BaseMenuViewController, IBackButtonSupported, IHeaderBorderSupported
{
	[Token(Token = "0x200073E")]
	public enum WinPredictionHomeCode
	{
		[Token(Token = "0x400246D")]
		NONE = 0,
		[Token(Token = "0x400246E")]
		ERR_OUT_OF_TERM = 4301
	}

	[Token(Token = "0x200073F")]
	public enum BgType
	{
		[Token(Token = "0x4002470")]
		NONE,
		[Token(Token = "0x4002471")]
		ADVANCED,
		[Token(Token = "0x4002472")]
		BEST8,
		[Token(Token = "0x4002473")]
		CHAMPION
	}

	[Token(Token = "0x2000740")]
	public class TeamData
	{
		[Token(Token = "0x4002474")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int order;

		[Token(Token = "0x4002475")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public int Id;

		[Token(Token = "0x4002476")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string name;

		[Token(Token = "0x4002477")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string areaName;

		[Token(Token = "0x4002478")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public int areaId;

		[Token(Token = "0x6002F9A")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public TeamData()
		{
		}
	}

	[Token(Token = "0x2000741")]
	public enum isPresentSentFrag
	{
		[Token(Token = "0x400247A")]
		NONE = 0,
		[Token(Token = "0x400247B")]
		NORMAL = 1,
		[Token(Token = "0x400247C")]
		SPECIAL = 2,
		[Token(Token = "0x400247D")]
		OTHERS = 4
	}

	[Token(Token = "0x2000747")]
	[CompilerGenerated]
	private sealed class _003CDelaySE_003Ed__65 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400248B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400248C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x170005E2")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6002FAB")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170005E3")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6002FAD")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6002FA8")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CDelaySE_003Ed__65(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6002FA9")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6002FAA")]
		[Address(RVA = "0x734720", Offset = "0x733920", VA = "0x180734720", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6002FAC")]
		[Address(RVA = "0x734810", Offset = "0x733A10", VA = "0x180734810", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x2000748")]
	[CompilerGenerated]
	private sealed class _003CTweenWait_003Ed__73 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400248D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400248E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400248F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public WinPredictionViewController _003C_003E4__this;

		[Token(Token = "0x4002490")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string label;

		[Token(Token = "0x170005E4")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6002FB1")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170005E5")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6002FB3")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6002FAE")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CTweenWait_003Ed__73(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6002FAF")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6002FB0")]
		[Address(RVA = "0x734D70", Offset = "0x733F70", VA = "0x180734D70", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6002FB2")]
		[Address(RVA = "0x734EE0", Offset = "0x7340E0", VA = "0x180734EE0", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x2000749")]
	[CompilerGenerated]
	private sealed class _003CrewardDisp_003Ed__52 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4002491")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4002492")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4002493")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public WinPredictionViewController _003C_003E4__this;

		[Token(Token = "0x170005E6")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6002FB7")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170005E7")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6002FB9")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6002FB4")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CrewardDisp_003Ed__52(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6002FB5")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6002FB6")]
		[Address(RVA = "0x7370C0", Offset = "0x7362C0", VA = "0x1807370C0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6002FB8")]
		[Address(RVA = "0x737180", Offset = "0x736380", VA = "0x180737180", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x400243D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	private string TEAMSELECT_GROUP_LABEL;

	[Token(Token = "0x400243E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	private string TEAMSELECT_BTN_UNSELECT_LABEL;

	[Token(Token = "0x400243F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	private string TEAMSELECT_BTN_LABEL;

	[Token(Token = "0x4002440")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	private string TEMPLATE_LABEL;

	[Token(Token = "0x4002441")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	private string REWARD_BTN_LABEL;

	[Token(Token = "0x4002442")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	private string TEXT_TEAM_SELECT_GROUP_LABEL;

	[Token(Token = "0x4002443")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
	private string TEXT_TEAM_SELECT_NAME_LABEL;

	[Token(Token = "0x4002444")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
	private string ICON_TEAM_LABEL;

	[Token(Token = "0x4002445")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
	private string TEAM_SELECT_CHEER_ICON_LABEL;

	[Token(Token = "0x4002446")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
	private string TEAM_SELECT_CHEER_ICON_RESULT_LABEL;

	[Token(Token = "0x4002447")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
	private string TEXT_TEAM_SELECT_LABEL;

	[Token(Token = "0x4002448")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
	private string TEXT_DATE_TEXT_LABEL;

	[Token(Token = "0x4002449")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
	private string TEXT_HOLDING_TEXT_LABEL;

	[Token(Token = "0x400244A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
	private string TEXT_DESC_LABEL;

	[Token(Token = "0x400244B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
	private string TEXT_RESULT_LABEL;

	[Token(Token = "0x400244C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
	private string IMG_RESULT_BG_LABEL;

	[Token(Token = "0x400244D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
	private string TEAM_NAME_LABEL;

	[Token(Token = "0x400244E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
	private string TEAM_GROUP_LABEL;

	[Token(Token = "0x400244F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
	private string CW_TEAM_NAME;

	[Token(Token = "0x4002450")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
	private string CW_TEAM_AREA;

	[Token(Token = "0x4002451")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
	private string CW_TEAM_ORDER;

	[Token(Token = "0x4002452")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
	private int m_SelectedTeamIndex;

	[Token(Token = "0x4002453")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
	private Dictionary<int, ElementObjectManager> templatesMap;

	[Token(Token = "0x4002454")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
	private List<TeamData> teamDatas;

	[Token(Token = "0x4002455")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
	private List<int> orderList;

	[Token(Token = "0x4002456")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
	private Dictionary<string, object> teamDicData;

	[Token(Token = "0x4002457")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
	private SelectionButton rewardButton;

	[Token(Token = "0x4002458")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
	private SelectionButton teamSelectButton;

	[Token(Token = "0x4002459")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1B0")]
	private SelectionButton teamSelectUnselectButton;

	[Token(Token = "0x400245A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1B8")]
	private ElementObjectManager teamSelectGroup;

	[Token(Token = "0x400245B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C0")]
	private ExtendedTextMeshProUGUI resultTextEo;

	[Token(Token = "0x400245C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C8")]
	private GameObject resultBg;

	[Token(Token = "0x400245D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1D0")]
	private ExtendedTextMeshProUGUI m_TeamSelectAreaText;

	[Token(Token = "0x400245E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1D8")]
	private ExtendedTextMeshProUGUI m_TeamSelectNameText;

	[Token(Token = "0x400245F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1E0")]
	private ExtendedTextMeshProUGUI m_TeamSelectText;

	[Token(Token = "0x4002460")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1E8")]
	private Image m_SelectTeamIcon;

	[Token(Token = "0x4002461")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1F0")]
	private GameObject m_CheerIcon;

	[Token(Token = "0x4002462")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1F8")]
	private GameObject m_CheerIconResult;

	[Token(Token = "0x4002463")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x200")]
	private Queue<Action> actionsQueue;

	[Token(Token = "0x4002464")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x208")]
	private bool OpenningFrag;

	[Token(Token = "0x4002465")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x209")]
	private bool isOutOfVote;

	[Token(Token = "0x4002466")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20A")]
	private bool isDecidedTeamResult;

	[Token(Token = "0x4002467")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x210")]
	private IEnumerator rewardCoroutine;

	[Token(Token = "0x4002468")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x218")]
	private Dictionary<string, object> supportDictionary;

	[Token(Token = "0x4002469")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x220")]
	private string infoText;

	[Token(Token = "0x400246A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x228")]
	private isPresentSentFrag m_InitFrag;

	[Token(Token = "0x400246B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x22C")]
	private bool isDebugMode;

	[Token(Token = "0x170005E0")]
	protected override Type[] textIds
	{
		[Token(Token = "0x6002F73")]
		[Address(RVA = "0x74CAB0", Offset = "0x74BCB0", VA = "0x18074CAB0", Slot = "21")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170005E1")]
	protected override int outGameBgId
	{
		[Token(Token = "0x6002F74")]
		[Address(RVA = "0x549EC0", Offset = "0x5490C0", VA = "0x180549EC0", Slot = "20")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x6002F75")]
	[Address(RVA = "0x3E4080", Offset = "0x3E3280", VA = "0x1803E4080", Slot = "6")]
	public override void NotificationStackEntry()
	{
	}

	[Token(Token = "0x6002F76")]
	[Address(RVA = "0x74A500", Offset = "0x749700", VA = "0x18074A500", Slot = "7")]
	public override void NotificationStackRemove()
	{
	}

	[Token(Token = "0x6002F77")]
	[Address(RVA = "0x74CB80", Offset = "0x74BD80", VA = "0x18074CB80")]
	[IteratorStateMachine(typeof(_003CrewardDisp_003Ed__52))]
	private IEnumerator rewardDisp()
	{
		return null;
	}

	[Token(Token = "0x6002F78")]
	[Address(RVA = "0x74B020", Offset = "0x74A220", VA = "0x18074B020")]
	private void SetViewElements()
	{
	}

	[Token(Token = "0x6002F79")]
	[Address(RVA = "0x74BAF0", Offset = "0x74ACF0", VA = "0x18074BAF0")]
	private void UpdateButtonView()
	{
	}

	[Token(Token = "0x6002F7A")]
	[Address(RVA = "0x749E60", Offset = "0x749060", VA = "0x180749E60")]
	private void Initialize()
	{
	}

	[Token(Token = "0x6002F7B")]
	[Address(RVA = "0x74A920", Offset = "0x749B20", VA = "0x18074A920", Slot = "23")]
	protected override void OnCreatedView()
	{
	}

	[Token(Token = "0x6002F7C")]
	[Address(RVA = "0x74A890", Offset = "0x749A90", VA = "0x18074A890")]
	private void OnClickTeamSelect()
	{
	}

	[Token(Token = "0x6002F7D")]
	[Address(RVA = "0x74A730", Offset = "0x749930", VA = "0x18074A730")]
	private void OnClickRewardButton()
	{
	}

	[Token(Token = "0x6002F7E")]
	[Address(RVA = "0x74AA60", Offset = "0x749C60", VA = "0x18074AA60", Slot = "14")]
	public override bool OnResult(ViewController from, object value)
	{
		return default(bool);
	}

	[Token(Token = "0x6002F7F")]
	[Address(RVA = "0x74A5D0", Offset = "0x7497D0", VA = "0x18074A5D0", Slot = "8")]
	public override void NotificationStack(ViewControllerManager vcm, ViewController vc, bool isEntry)
	{
	}

	[Token(Token = "0x6002F80")]
	[Address(RVA = "0x749720", Offset = "0x748920", VA = "0x180749720")]
	private void Import([Optional] Action OnCompleted)
	{
	}

	[Token(Token = "0x6002F81")]
	[Address(RVA = "0x74C0B0", Offset = "0x74B2B0", VA = "0x18074C0B0")]
	private void UpdateTemplateView([Optional] Action OnCompleted)
	{
	}

	[Token(Token = "0x6002F82")]
	[Address(RVA = "0x74BCB0", Offset = "0x74AEB0", VA = "0x18074BCB0")]
	private void UpdateTeamSelectText()
	{
	}

	[Token(Token = "0x6002F83")]
	[Address(RVA = "0x748AE0", Offset = "0x747CE0", VA = "0x180748AE0")]
	private void ActiveTweenIcon(bool active)
	{
	}

	[Token(Token = "0x6002F84")]
	[Address(RVA = "0x7493F0", Offset = "0x7485F0", VA = "0x1807493F0")]
	[IteratorStateMachine(typeof(_003CDelaySE_003Ed__65))]
	private IEnumerator DelaySE()
	{
		return null;
	}

	[Token(Token = "0x6002F85")]
	[Address(RVA = "0x74A8A0", Offset = "0x749AA0", VA = "0x18074A8A0")]
	private void OnClickTemplate(int idx)
	{
	}

	[Token(Token = "0x6002F86")]
	[Address(RVA = "0x74AD40", Offset = "0x749F40", VA = "0x18074AD40")]
	private void SetCallbackInputDown(int order)
	{
	}

	[Token(Token = "0x6002F87")]
	[Address(RVA = "0x74ACD0", Offset = "0x749ED0", VA = "0x18074ACD0")]
	private void SetCallBackInputUp()
	{
	}

	[Token(Token = "0x6002F88")]
	[Address(RVA = "0x748CC0", Offset = "0x747EC0", VA = "0x180748CC0")]
	private void CallApi([Optional] Action onComplited)
	{
	}

	[Token(Token = "0x6002F89")]
	[Address(RVA = "0x74AB50", Offset = "0x749D50", VA = "0x18074AB50")]
	private void OpenErrDialog(string title, string text)
	{
	}

	[Token(Token = "0x6002F8A")]
	[Address(RVA = "0x748DA0", Offset = "0x747FA0", VA = "0x180748DA0")]
	private bool CheckStatus()
	{
		return default(bool);
	}

	[Token(Token = "0x6002F8B")]
	[Address(RVA = "0x74AEE0", Offset = "0x74A0E0", VA = "0x18074AEE0")]
	private void SetResultBgView(BgType bgType)
	{
	}

	[Token(Token = "0x6002F8C")]
	[Address(RVA = "0x74BA20", Offset = "0x74AC20", VA = "0x18074BA20")]
	[IteratorStateMachine(typeof(_003CTweenWait_003Ed__73))]
	private IEnumerator TweenWait(string label)
	{
		return null;
	}

	[Token(Token = "0x6002F8D")]
	[Address(RVA = "0x749610", Offset = "0x748810", VA = "0x180749610")]
	private string GetResultText(int orderIndex)
	{
		return null;
	}

	[Token(Token = "0x6002F8E")]
	[Address(RVA = "0x749500", Offset = "0x748700", VA = "0x180749500")]
	private string GetProgressResultText(int orderIndex)
	{
		return null;
	}

	[Token(Token = "0x6002F8F")]
	[Address(RVA = "0x749440", Offset = "0x748640", VA = "0x180749440")]
	private Dictionary<string, object> GetCWSupport()
	{
		return null;
	}

	[Token(Token = "0x6002F90")]
	[Address(RVA = "0x7494A0", Offset = "0x7486A0", VA = "0x1807494A0")]
	private Dictionary<string, object> GetCWTeam()
	{
		return null;
	}

	[Token(Token = "0x6002F91")]
	[Address(RVA = "0x74C520", Offset = "0x74B720", VA = "0x18074C520")]
	public WinPredictionViewController()
	{
	}
}
