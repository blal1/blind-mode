using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using YgomGame.Menu;
using YgomGame.Menu.Common;
using YgomSystem.ElementSystem;
using YgomSystem.UI;
using YgomSystem.UI.InfinityScroll;
using YgomSystem.YGomTMPro;

namespace YgomGame.Team;

[Token(Token = "0x2001643")]
public class TeamCreateViewController : BaseMenuViewController, IBackButtonSupported, IHeaderBorderSupported
{
	[Token(Token = "0x2001644")]
	private class ConfigData
	{
		[Token(Token = "0x1700152E")]
		internal int memberNum
		{
			[Token(Token = "0x6008AA8")]
			[Address(RVA = "0x3C7100", Offset = "0x3C6300", VA = "0x1803C7100")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6008AA7")]
			[Address(RVA = "0x5F4710", Offset = "0x5F3910", VA = "0x1805F4710")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x1700152F")]
		internal int regulationSetIdx
		{
			[Token(Token = "0x6008AAA")]
			[Address(RVA = "0x64B770", Offset = "0x64A970", VA = "0x18064B770")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6008AA9")]
			[Address(RVA = "0x64B780", Offset = "0x64A980", VA = "0x18064B780")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17001530")]
		internal int mrkForTeamName
		{
			[Token(Token = "0x6008AAC")]
			[Address(RVA = "0x5C7C60", Offset = "0x5C6E60", VA = "0x1805C7C60")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6008AAB")]
			[Address(RVA = "0x615AB0", Offset = "0x614CB0", VA = "0x180615AB0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17001531")]
		internal int regulationIDToJoin
		{
			[Token(Token = "0x6008AAE")]
			[Address(RVA = "0x62E220", Offset = "0x62D420", VA = "0x18062E220")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6008AAD")]
			[Address(RVA = "0x62E250", Offset = "0x62D450", VA = "0x18062E250")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17001532")]
		internal TeamUtil.RegulationSet selectedRegulationSet
		{
			[Token(Token = "0x6008AB0")]
			[Address(RVA = "0x3D8370", Offset = "0x3D7570", VA = "0x1803D8370")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6008AAF")]
			[Address(RVA = "0x3D8380", Offset = "0x3D7580", VA = "0x1803D8380")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x6008AB1")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public ConfigData()
		{
		}
	}

	[Token(Token = "0x2001645")]
	public enum Mode
	{
		[Token(Token = "0x400D5AD")]
		CREATE,
		[Token(Token = "0x400D5AE")]
		SEARCH,
		[Token(Token = "0x400D5AF")]
		UNKNOWN
	}

	[Token(Token = "0x200164D")]
	[CompilerGenerated]
	private sealed class _003CStart_003Ed__39 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400D5C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400D5C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400D5C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public TeamCreateViewController _003C_003E4__this;

		[Token(Token = "0x17001533")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6008AC5")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17001534")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6008AC7")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6008AC2")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CStart_003Ed__39(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6008AC3")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6008AC4")]
		[Address(RVA = "0xD77B20", Offset = "0xD76D20", VA = "0x180D77B20", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6008AC6")]
		[Address(RVA = "0xD77CA0", Offset = "0xD76EA0", VA = "0x180D77CA0", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x400D58F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	private ConfigData _config;

	[Token(Token = "0x400D590")]
	private const string VC_PATH = "Team/TeamCreate";

	[Token(Token = "0x400D591")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static readonly string ARG_MODE;

	[Token(Token = "0x400D592")]
	private const string ARG_REGSET_DATA = "REGSET_DATA";

	[Token(Token = "0x400D593")]
	private const string ARG_CONFIG_DATA = "CONFIG_DATA";

	[Token(Token = "0x400D594")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private static bool c_TextLoadInOpen;

	[Token(Token = "0x400D595")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	private int m_teammemberIdx;

	[Token(Token = "0x400D598")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	private ElementObjectManager _searchInputField;

	[Token(Token = "0x400D599")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	private ExtendedTextMeshProUGUI _titleText;

	[Token(Token = "0x400D59A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	private InfinityScrollView _scrollView;

	[Token(Token = "0x400D59B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
	private ElementObjectManager _memberNumItem;

	[Token(Token = "0x400D59C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
	private ElementObjectManager _regulationSetItem;

	[Token(Token = "0x400D59D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
	private ElementObjectManager _teamCardNameItem;

	[Token(Token = "0x400D59E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
	private ElementObjectManager _regulationToJoinItem;

	[Token(Token = "0x400D59F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
	private ElementObjectManager _usingDeckItem;

	[Token(Token = "0x400D5A0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
	private SelectionButton _memberNumBtn;

	[Token(Token = "0x400D5A1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
	private SelectionButton _regulationSetBtn;

	[Token(Token = "0x400D5A2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
	private SelectionButton _teamCardNameBtn;

	[Token(Token = "0x400D5A3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
	private SelectionButton _regulationToJoinBtn;

	[Token(Token = "0x400D5A4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
	private SelectionButton _usingDeckBtn;

	[Token(Token = "0x400D5A5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
	private DeckCaseWidget _deckCaseWidget;

	[Token(Token = "0x400D5A6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
	private SelectionButton _decideBtn;

	[Token(Token = "0x1700152B")]
	private Mode mode
	{
		[Token(Token = "0x6008A80")]
		[Address(RVA = "0xA2A110", Offset = "0xA29310", VA = "0x180A2A110")]
		[CompilerGenerated]
		get
		{
			return default(Mode);
		}
		[Token(Token = "0x6008A7F")]
		[Address(RVA = "0xA2A550", Offset = "0xA29750", VA = "0x180A2A550")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x1700152C")]
	protected override Type[] textIds
	{
		[Token(Token = "0x6008A81")]
		[Address(RVA = "0xD61850", Offset = "0xD60A50", VA = "0x180D61850", Slot = "21")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700152D")]
	private SortedDictionary<int, List<TeamUtil.RegulationSet>> regulationSetDic
	{
		[Token(Token = "0x6008A83")]
		[Address(RVA = "0x5961E0", Offset = "0x5953E0", VA = "0x1805961E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6008A82")]
		[Address(RVA = "0x662520", Offset = "0x661720", VA = "0x180662520")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x6008A7D")]
	[Address(RVA = "0xD5F140", Offset = "0xD5E340", VA = "0x180D5F140")]
	public static void Open(ViewControllerManager manager)
	{
	}

	[Token(Token = "0x6008A7E")]
	[Address(RVA = "0xD5E490", Offset = "0xD5D690", VA = "0x180D5E490")]
	private static SortedDictionary<int, List<TeamUtil.RegulationSet>> LoadRegulationSetData(ref int minimumTeamNum)
	{
		return null;
	}

	[Token(Token = "0x6008A84")]
	[Address(RVA = "0xD5EAF0", Offset = "0xD5DCF0", VA = "0x180D5EAF0", Slot = "6")]
	public override void NotificationStackEntry()
	{
	}

	[Token(Token = "0x6008A85")]
	[Address(RVA = "0xD5EC90", Offset = "0xD5DE90", VA = "0x180D5EC90", Slot = "8")]
	public override void NotificationStack(ViewControllerManager vcm, ViewController vc, bool isEntry)
	{
	}

	[Token(Token = "0x6008A86")]
	[Address(RVA = "0xD5EBD0", Offset = "0xD5DDD0", VA = "0x180D5EBD0", Slot = "7")]
	public override void NotificationStackRemove()
	{
	}

	[Token(Token = "0x6008A87")]
	[Address(RVA = "0xD5FC00", Offset = "0xD5EE00", VA = "0x180D5FC00")]
	[IteratorStateMachine(typeof(_003CStart_003Ed__39))]
	private IEnumerator Start()
	{
		return null;
	}

	[Token(Token = "0x6008A88")]
	[Address(RVA = "0xD5DE80", Offset = "0xD5D080", VA = "0x180D5DE80")]
	private void InitScrollAsync(Action onEnd)
	{
	}

	[Token(Token = "0x6008A89")]
	[Address(RVA = "0xD5F380", Offset = "0xD5E580", VA = "0x180D5F380")]
	private void SetupView()
	{
	}

	[Token(Token = "0x6008A8A")]
	[Address(RVA = "0xD5E2B0", Offset = "0xD5D4B0", VA = "0x180D5E2B0")]
	private void LoadData()
	{
	}

	[Token(Token = "0x6008A8B")]
	[Address(RVA = "0xD60970", Offset = "0xD5FB70", VA = "0x180D60970")]
	private void UpdateMemberNum()
	{
	}

	[Token(Token = "0x6008A8C")]
	[Address(RVA = "0xD60BB0", Offset = "0xD5FDB0", VA = "0x180D60BB0")]
	private void UpdateRegulationSet()
	{
	}

	[Token(Token = "0x6008A8D")]
	[Address(RVA = "0xD60E00", Offset = "0xD60000", VA = "0x180D60E00")]
	private void UpdateTeamNameCard()
	{
	}

	[Token(Token = "0x6008A8E")]
	[Address(RVA = "0xD60D50", Offset = "0xD5FF50", VA = "0x180D60D50")]
	private void UpdateRegulationToJoin()
	{
	}

	[Token(Token = "0x6008A8F")]
	[Address(RVA = "0xD611B0", Offset = "0xD603B0", VA = "0x180D611B0")]
	private void UpdateUsingDeck([Optional] Dictionary<string, object> deckInfo)
	{
	}

	[Token(Token = "0x6008A90")]
	[Address(RVA = "0xD5F0D0", Offset = "0xD5E2D0", VA = "0x180D5F0D0")]
	private void OnTeamMemberNumChanging(int num)
	{
	}

	[Token(Token = "0x6008A91")]
	[Address(RVA = "0xD5EDF0", Offset = "0xD5DFF0", VA = "0x180D5EDF0")]
	private void OnRegulationSetSelecting(int index)
	{
	}

	[Token(Token = "0x6008A92")]
	[Address(RVA = "0xD5EFD0", Offset = "0xD5E1D0", VA = "0x180D5EFD0")]
	private void OnRegulationToJoinSelecting(int regulationID, bool deckCheck = true)
	{
	}

	[Token(Token = "0x6008A93")]
	[Address(RVA = "0xD5EDC0", Offset = "0xD5DFC0", VA = "0x180D5EDC0")]
	private void OnCardIdSelected(int cardId)
	{
	}

	[Token(Token = "0x6008A94")]
	[Address(RVA = "0xD5DBE0", Offset = "0xD5CDE0", VA = "0x180D5DBE0")]
	private void CallAPI_TeamCreate(Action onSuccess)
	{
	}

	[Token(Token = "0x6008A95")]
	[Address(RVA = "0xD5FB60", Offset = "0xD5ED60", VA = "0x180D5FB60")]
	private static void ShowFatalError()
	{
	}

	[Token(Token = "0x6008A96")]
	[Address(RVA = "0xD61830", Offset = "0xD60A30", VA = "0x180D61830")]
	public TeamCreateViewController()
	{
	}
}
