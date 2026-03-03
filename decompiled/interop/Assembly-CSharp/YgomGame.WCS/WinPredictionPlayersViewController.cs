using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using YgomGame.Menu;
using YgomSystem;
using YgomSystem.ElementSystem;
using YgomSystem.UI;
using YgomSystem.UI.ElementWidget;
using YgomSystem.YGomTMPro;

namespace YgomGame.WCS;

[Token(Token = "0x2000720")]
public class WinPredictionPlayersViewController : BaseMenuViewController, IBackButtonSupported, IHeaderBorderSupported
{
	[Token(Token = "0x2000721")]
	private class PlayerData
	{
		[Token(Token = "0x40023B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string name;

		[Token(Token = "0x40023B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Dictionary<int, string> QuestionList;

		[Token(Token = "0x40023B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Dictionary<int, string> AnswerList;

		[Token(Token = "0x40023B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public int iconId;

		[Token(Token = "0x40023B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public int iconFrameId;

		[Token(Token = "0x40023BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool isReader;

		[Token(Token = "0x40023BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
		public bool isOpenProf;

		[Token(Token = "0x40023BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public int pcode;

		[Token(Token = "0x40023BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public int playerSubId;

		[Token(Token = "0x6002F09")]
		[Address(RVA = "0x71DAA0", Offset = "0x71CCA0", VA = "0x18071DAA0")]
		public PlayerData()
		{
		}
	}

	[Token(Token = "0x2000722")]
	private class TeamData
	{
		[Token(Token = "0x40023BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int id;

		[Token(Token = "0x40023BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string teamName;

		[Token(Token = "0x40023C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public List<PlayerData> players;

		[Token(Token = "0x6002F0A")]
		[Address(RVA = "0x722D60", Offset = "0x721F60", VA = "0x180722D60")]
		public TeamData()
		{
		}

		[Token(Token = "0x6002F0B")]
		[Address(RVA = "0x722CC0", Offset = "0x721EC0", VA = "0x180722CC0")]
		public TeamData(int id, string teamName)
		{
		}
	}

	[Token(Token = "0x2000726")]
	[CompilerGenerated]
	private sealed class _003CChangeTab_003Ed__71 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40023C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x40023C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x40023C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public WinPredictionPlayersViewController _003C_003E4__this;

		[Token(Token = "0x170005D4")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6002F16")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170005D5")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6002F18")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6002F13")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CChangeTab_003Ed__71(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6002F14")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6002F15")]
		[Address(RVA = "0x723E70", Offset = "0x723070", VA = "0x180723E70", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6002F17")]
		[Address(RVA = "0x723FC0", Offset = "0x7231C0", VA = "0x180723FC0", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x2000727")]
	[CompilerGenerated]
	private sealed class _003CCheckGryph_003Ed__69 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40023C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x40023CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x40023CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public WinPredictionPlayersViewController _003C_003E4__this;

		[Token(Token = "0x40023CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private TextMeshProGlyphCreater _003CtmpGlyphCreater_003E5__2;

		[Token(Token = "0x40023CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private int _003Cidx_003E5__3;

		[Token(Token = "0x40023CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private ElementObjectManager _003CtempEOM_003E5__4;

		[Token(Token = "0x40023CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private int _003CinstancedTempNum_003E5__5;

		[Token(Token = "0x40023D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private int _003Ccount_003E5__6;

		[Token(Token = "0x40023D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Dictionary<int, string>.Enumerator _003C_003E7__wrap6;

		[Token(Token = "0x40023D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private ExtendedTextMeshProUGUI _003CanswerTextMP_003E5__8;

		[Token(Token = "0x40023D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private string _003CanswerText_003E5__9;

		[Token(Token = "0x40023D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private IEnumerator _003Croutine_003E5__10;

		[Token(Token = "0x170005D6")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6002F1D")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170005D7")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6002F1F")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6002F19")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CCheckGryph_003Ed__69(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6002F1A")]
		[Address(RVA = "0x7249C0", Offset = "0x723BC0", VA = "0x1807249C0", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6002F1B")]
		[Address(RVA = "0x724000", Offset = "0x723200", VA = "0x180724000", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6002F1C")]
		[Address(RVA = "0x724A50", Offset = "0x723C50", VA = "0x180724A50")]
		private void _003C_003Em__Finally1()
		{
		}

		[Token(Token = "0x6002F1E")]
		[Address(RVA = "0x724980", Offset = "0x723B80", VA = "0x180724980", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x2000728")]
	[CompilerGenerated]
	private sealed class _003CyPlayPaging_003Ed__80 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40023D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x40023D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x40023D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public int direction;

		[Token(Token = "0x40023D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public WinPredictionPlayersViewController _003C_003E4__this;

		[Token(Token = "0x40023D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private string _003CoutKey_003E5__2;

		[Token(Token = "0x40023DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private string _003CinKey_003E5__3;

		[Token(Token = "0x170005D8")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6002F23")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170005D9")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6002F25")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6002F20")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CyPlayPaging_003Ed__80(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6002F21")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6002F22")]
		[Address(RVA = "0x727670", Offset = "0x726870", VA = "0x180727670", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6002F24")]
		[Address(RVA = "0x727A40", Offset = "0x726C40", VA = "0x180727A40", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x400237C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	private readonly string k_ELabelPrevButton;

	[Token(Token = "0x400237D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	private readonly string k_ELabelNextButton;

	[Token(Token = "0x400237E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	private readonly string k_TLabelPagingNextOut;

	[Token(Token = "0x400237F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	private readonly string k_TLabelPagingBackOut;

	[Token(Token = "0x4002380")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	private readonly string k_TLabelPagingNextIn;

	[Token(Token = "0x4002381")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	private readonly string k_TLabelPagingBackIn;

	[Token(Token = "0x4002382")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
	private readonly string k_ELabelShortcutButtonL1;

	[Token(Token = "0x4002383")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
	private readonly string k_ELabelShortcutButtonL2;

	[Token(Token = "0x4002384")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
	private readonly string k_ELabelShortcutButtonR1;

	[Token(Token = "0x4002385")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
	private readonly string k_ELabelShortcutButtonR2;

	[Token(Token = "0x4002386")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
	private SelectionButton m_PrevButton;

	[Token(Token = "0x4002387")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
	private SelectionButton m_NextButton;

	[Token(Token = "0x4002388")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static readonly string K_ArgSinglePage;

	[Token(Token = "0x4002389")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private static readonly string k_ArgPageIndex;

	[Token(Token = "0x400238A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private static readonly string k_ArgCallback;

	[Token(Token = "0x400238B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private static readonly string k_ArgIdOrderList;

	[Token(Token = "0x400238C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
	private readonly string CW_TEAM_NAME;

	[Token(Token = "0x400238D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
	private readonly string CW_PLAYER_QandA;

	[Token(Token = "0x400238E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
	private readonly string CW_PLAYER_ISLEADER;

	[Token(Token = "0x400238F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
	private readonly string CW_PLAYER_ICON;

	[Token(Token = "0x4002390")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
	private readonly string CW_PLAYER_ICONFRAME;

	[Token(Token = "0x4002391")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
	private readonly string CW_PLAYER_NAME;

	[Token(Token = "0x4002392")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
	private readonly string CW_PLAYER_PCODE;

	[Token(Token = "0x4002393")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
	private readonly string LABEL_PROFILE_TEMPLATE;

	[Token(Token = "0x4002394")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
	private readonly string LABEL_HEADER1_TXT;

	[Token(Token = "0x4002395")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
	private readonly string LABEL_TEMPLATE1_TXT;

	[Token(Token = "0x4002396")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
	private readonly string LABEL_PLATFORM_PLAYER_NAME;

	[Token(Token = "0x4002397")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
	private readonly string LABEL_TEAM_NAME_TXT;

	[Token(Token = "0x4002398")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
	private readonly string LABEL_AREA_TXT;

	[Token(Token = "0x4002399")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
	private readonly string LABEL_TEAM_ICON;

	[Token(Token = "0x400239A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
	private readonly string LABEL_ICON;

	[Token(Token = "0x400239B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
	private readonly string LABEL_IconLeader;

	[Token(Token = "0x400239C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1B0")]
	private readonly string LABEL_MAIN;

	[Token(Token = "0x400239D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1B8")]
	private readonly string LABEL_TEAM_AREA;

	[Token(Token = "0x400239E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C0")]
	private readonly string LABEL_Tabs;

	[Token(Token = "0x400239F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C8")]
	private readonly string LABEL_PLAYER_PROFILE;

	[Token(Token = "0x40023A0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1D0")]
	private int m_PageIdx;

	[Token(Token = "0x40023A1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1D4")]
	private int m_PageCount;

	[Token(Token = "0x40023A2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1D8")]
	private bool isSinglePage;

	[Token(Token = "0x40023A3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1DC")]
	private int m_TabIndex;

	[Token(Token = "0x40023A4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1E0")]
	private TeamData teamData;

	[Token(Token = "0x40023A5")]
	private const int TEAM_MEMBER_NUM = 3;

	[Token(Token = "0x40023A6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1E8")]
	private ElementObjectManager playerEom;

	[Token(Token = "0x40023A7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1F0")]
	private ElementObjectManager playerProfileEom;

	[Token(Token = "0x40023A8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1F8")]
	private ElementObjectManager teamArea;

	[Token(Token = "0x40023A9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x200")]
	private List<int> instancedTemplateNum;

	[Token(Token = "0x40023AA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x208")]
	private Dictionary<int, List<ElementObjectManager>> templateList;

	[Token(Token = "0x40023AB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x210")]
	private List<ElementObjectManager> instancedTemplateList;

	[Token(Token = "0x40023AC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x218")]
	private List<int> dataIdOrderList;

	[Token(Token = "0x40023AD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x220")]
	private ExtendedScrollRect m_ScrollView;

	[Token(Token = "0x40023AE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x228")]
	private DirectionalToggleGroupWidget directionalToggleGroup;

	[Token(Token = "0x40023AF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x230")]
	private ElementObjectManager tabsEom;

	[Token(Token = "0x40023B0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x238")]
	private int loadingCount;

	[Token(Token = "0x40023B1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x23C")]
	private int dispCount;

	[Token(Token = "0x40023B2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x240")]
	private int blockCount;

	[Token(Token = "0x40023B3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x244")]
	private bool isLoadingView;

	[Token(Token = "0x40023B4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x245")]
	private bool isChangingTab;

	[Token(Token = "0x170005D2")]
	protected override Type[] textIds
	{
		[Token(Token = "0x6002EE5")]
		[Address(RVA = "0x72F630", Offset = "0x72E830", VA = "0x18072F630", Slot = "21")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170005D3")]
	protected override int outGameBgId
	{
		[Token(Token = "0x6002EE6")]
		[Address(RVA = "0x549EC0", Offset = "0x5490C0", VA = "0x180549EC0", Slot = "20")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x6002EE7")]
	[Address(RVA = "0x72DFD0", Offset = "0x72D1D0", VA = "0x18072DFD0")]
	public static void Open(int id, bool isSinglePage, [Optional] Action callback)
	{
	}

	[Token(Token = "0x6002EE8")]
	[Address(RVA = "0x72DDC0", Offset = "0x72CFC0", VA = "0x18072DDC0")]
	public static void Open(int id, bool isSinglePage, List<int> list, [Optional] Action callback, bool isDebugMode = false)
	{
	}

	[Token(Token = "0x6002EE9")]
	[Address(RVA = "0x72CE80", Offset = "0x72C080", VA = "0x18072CE80", Slot = "7")]
	public override void NotificationStackRemove()
	{
	}

	[Token(Token = "0x6002EEA")]
	[Address(RVA = "0x72CA60", Offset = "0x72BC60", VA = "0x18072CA60", Slot = "6")]
	public override void NotificationStackEntry()
	{
	}

	[Token(Token = "0x6002EEB")]
	[Address(RVA = "0x72D1E0", Offset = "0x72C3E0", VA = "0x18072D1E0", Slot = "23")]
	protected override void OnCreatedView()
	{
	}

	[Token(Token = "0x6002EEC")]
	[Address(RVA = "0x72B8C0", Offset = "0x72AAC0", VA = "0x18072B8C0")]
	private Either<string, bool> Import(int idx, bool isRefresh = false, [Optional] Action onCompleted)
	{
		return null;
	}

	[Token(Token = "0x6002EED")]
	[Address(RVA = "0x72E170", Offset = "0x72D370", VA = "0x18072E170")]
	private void RefreshPage()
	{
	}

	[Token(Token = "0x6002EEE")]
	[Address(RVA = "0x72B690", Offset = "0x72A890", VA = "0x18072B690")]
	private bool ImportErrorCheck(Either<string, bool> result)
	{
		return default(bool);
	}

	[Token(Token = "0x6002EEF")]
	[Address(RVA = "0x72E450", Offset = "0x72D650", VA = "0x18072E450")]
	private void UpdateView(int idx)
	{
	}

	[Token(Token = "0x6002EF0")]
	[Address(RVA = "0x72B400", Offset = "0x72A600", VA = "0x18072B400")]
	[IteratorStateMachine(typeof(_003CCheckGryph_003Ed__69))]
	private IEnumerator CheckGryph()
	{
		return null;
	}

	[Token(Token = "0x6002EF1")]
	[Address(RVA = "0x72B390", Offset = "0x72A590", VA = "0x18072B390")]
	[IteratorStateMachine(typeof(_003CChangeTab_003Ed__71))]
	private IEnumerator ChangeTab()
	{
		return null;
	}

	[Token(Token = "0x6002EF2")]
	[Address(RVA = "0x72D090", Offset = "0x72C290", VA = "0x18072D090")]
	private void OnClickProfileButton(int pcode)
	{
	}

	[Token(Token = "0x6002EF3")]
	[Address(RVA = "0x72C8F0", Offset = "0x72BAF0", VA = "0x18072C8F0")]
	private void InActiveAllTemplate(ElementObjectManager eom)
	{
	}

	[Token(Token = "0x6002EF4")]
	[Address(RVA = "0x72C5D0", Offset = "0x72B7D0", VA = "0x18072C5D0")]
	private void InActiveAllTemplateOld(ElementObjectManager eom)
	{
	}

	[Token(Token = "0x6002EF5")]
	[Address(RVA = "0x72CF10", Offset = "0x72C110", VA = "0x18072CF10")]
	private void OnClickNextButton()
	{
	}

	[Token(Token = "0x6002EF6")]
	[Address(RVA = "0x72CFD0", Offset = "0x72C1D0", VA = "0x18072CFD0")]
	private void OnClickPrevButton()
	{
	}

	[Token(Token = "0x6002EF7")]
	[Address(RVA = "0x72CF10", Offset = "0x72C110", VA = "0x18072CF10")]
	private void ToNextPage()
	{
	}

	[Token(Token = "0x6002EF8")]
	[Address(RVA = "0x72CFD0", Offset = "0x72C1D0", VA = "0x18072CFD0")]
	private void ToPrevPage()
	{
	}

	[Token(Token = "0x6002EF9")]
	[Address(RVA = "0x72B2D0", Offset = "0x72A4D0", VA = "0x18072B2D0")]
	private void ChangePage(int dstIdx, int direction = 0)
	{
	}

	[Token(Token = "0x6002EFA")]
	[Address(RVA = "0x72F7D0", Offset = "0x72E9D0", VA = "0x18072F7D0")]
	[IteratorStateMachine(typeof(_003CyPlayPaging_003Ed__80))]
	private IEnumerator yPlayPaging(int direction = 0)
	{
		return null;
	}

	[Token(Token = "0x6002EFB")]
	[Address(RVA = "0x72B5E0", Offset = "0x72A7E0", VA = "0x18072B5E0")]
	private string GetTLabelPagingOut(int direction)
	{
		return null;
	}

	[Token(Token = "0x6002EFC")]
	[Address(RVA = "0x72B5C0", Offset = "0x72A7C0", VA = "0x18072B5C0")]
	private string GetTLabelPagingIn(int direction)
	{
		return null;
	}

	[Token(Token = "0x6002EFD")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60")]
	private void CallEntryAPI()
	{
	}

	[Token(Token = "0x6002EFE")]
	[Address(RVA = "0x72B600", Offset = "0x72A800", VA = "0x18072B600")]
	private Dictionary<string, object> GetTeamDatas(int idx)
	{
		return null;
	}

	[Token(Token = "0x6002EFF")]
	[Address(RVA = "0x72B4D0", Offset = "0x72A6D0", VA = "0x18072B4D0")]
	private Dictionary<string, object> GetPlayersDatas(int idx)
	{
		return null;
	}

	[Token(Token = "0x6002F00")]
	[Address(RVA = "0x72B470", Offset = "0x72A670", VA = "0x18072B470")]
	private Dictionary<string, object> GetDataRoot()
	{
		return null;
	}

	[Token(Token = "0x6002F01")]
	[Address(RVA = "0x72B560", Offset = "0x72A760", VA = "0x18072B560")]
	private Dictionary<string, object> GetQuestions()
	{
		return null;
	}

	[Token(Token = "0x6002F02")]
	[Address(RVA = "0x72EEB0", Offset = "0x72E0B0", VA = "0x18072EEB0")]
	public WinPredictionPlayersViewController()
	{
	}
}
