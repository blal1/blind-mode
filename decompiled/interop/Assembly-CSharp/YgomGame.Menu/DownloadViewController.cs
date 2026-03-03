using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Playables;
using UnityEngine.UI;
using YgomGame.Bg;
using YgomGame.Card;
using YgomGame.Certification;
using YgomGame.Download;
using YgomSystem.ElementSystem;
using YgomSystem.Timeline;
using YgomSystem.UI;
using YgomSystem.YGomTMPro;

namespace YgomGame.Menu;

[Token(Token = "0x200125F")]
public class DownloadViewController : BaseMenuViewController
{
	[Token(Token = "0x2001260")]
	public class DownloadQuizRogicHander : CertificationRogicHander
	{
		[Token(Token = "0x400BB99")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x220")]
		private GameObject questionResult;

		[Token(Token = "0x400BB9A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x228")]
		private SelectionButton retryButton;

		[Token(Token = "0x400BB9B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x230")]
		private ExtendedTextMeshProUGUI textResultScore;

		[Token(Token = "0x400BB9C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x238")]
		public Action onReplay;

		[Token(Token = "0x17001210")]
		public SelectionButton retryBtn
		{
			[Token(Token = "0x60072AF")]
			[Address(RVA = "0x49B7A0", Offset = "0x49A9A0", VA = "0x18049B7A0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60072B0")]
		[Address(RVA = "0xB8B2E0", Offset = "0xB8A4E0", VA = "0x180B8B2E0", Slot = "4")]
		public override void SetElements(ElementObjectManager m_View, ViewControllerManager vcm, BaseMenuViewController owner, Selector ownerSelector)
		{
		}

		[Token(Token = "0x60072B1")]
		[Address(RVA = "0xB8B100", Offset = "0xB8A300", VA = "0x180B8B100")]
		public void PlayResult(string score)
		{
		}

		[Token(Token = "0x60072B2")]
		[Address(RVA = "0xB8B1D0", Offset = "0xB8A3D0", VA = "0x180B8B1D0")]
		private void Replay()
		{
		}

		[Token(Token = "0x60072B3")]
		[Address(RVA = "0xB8B950", Offset = "0xB8AB50", VA = "0x180B8B950")]
		public DownloadQuizRogicHander()
		{
		}
	}

	[Token(Token = "0x2001261")]
	public static class CreateRandom
	{
		[Token(Token = "0x400BB9D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static System.Random random;

		[Token(Token = "0x60072B6")]
		[Address(RVA = "0xB88930", Offset = "0xB87B30", VA = "0x180B88930")]
		public static System.Random Create()
		{
			return null;
		}
	}

	[Token(Token = "0x2001266")]
	[CompilerGenerated]
	private sealed class _003CAsyncNewCardCheck_003Ed__142 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400BBAB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400BBAC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400BBAD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public DownloadViewController _003C_003E4__this;

		[Token(Token = "0x400BBAE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private System.Random _003Crand_003E5__2;

		[Token(Token = "0x400BBAF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private int _003CnewCardsNum_003E5__3;

		[Token(Token = "0x400BBB0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private List<int> _003CreturnList_003E5__4;

		[Token(Token = "0x400BBB1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private int _003CrandomStart_003E5__5;

		[Token(Token = "0x400BBB2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private int _003CrandomEnd_003E5__6;

		[Token(Token = "0x17001211")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x60072CC")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17001212")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60072CE")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60072C9")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CAsyncNewCardCheck_003Ed__142(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x60072CA")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x60072CB")]
		[Address(RVA = "0xB98C50", Offset = "0xB97E50", VA = "0x180B98C50", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60072CD")]
		[Address(RVA = "0xB990C0", Offset = "0xB982C0", VA = "0x180B990C0", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x2001267")]
	[CompilerGenerated]
	private sealed class _003CAsyncWaitAndStart_003Ed__143 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400BBB3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400BBB4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400BBB5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public DownloadViewController _003C_003E4__this;

		[Token(Token = "0x17001213")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x60072D2")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17001214")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60072D4")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60072CF")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CAsyncWaitAndStart_003Ed__143(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x60072D0")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x60072D1")]
		[Address(RVA = "0xB99100", Offset = "0xB98300", VA = "0x180B99100", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60072D3")]
		[Address(RVA = "0xB99480", Offset = "0xB98680", VA = "0x180B99480", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x2001268")]
	[CompilerGenerated]
	private sealed class _003CWaitPopView_003Ed__124 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400BBB6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400BBB7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400BBB8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public DownloadViewController _003C_003E4__this;

		[Token(Token = "0x400BBB9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float _003Ctimeout_003E5__2;

		[Token(Token = "0x17001215")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x60072D8")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17001216")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60072DA")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60072D5")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CWaitPopView_003Ed__124(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x60072D6")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x60072D7")]
		[Address(RVA = "0xB9E010", Offset = "0xB9D210", VA = "0x180B9E010", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60072D9")]
		[Address(RVA = "0xB9E2B0", Offset = "0xB9D4B0", VA = "0x180B9E2B0", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x400BB37")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	private ElementObjectManager m_rootQuizEom;

	[Token(Token = "0x400BB38")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	private readonly string assetPath;

	[Token(Token = "0x400BB39")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	private readonly string LABEL_RootQuiz;

	[Token(Token = "0x400BB3A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	private readonly string LABEL_ButtonNextIncorrect;

	[Token(Token = "0x400BB3B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	private readonly string LABEL_ButtonNextCorrect;

	[Token(Token = "0x400BB3C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	private readonly string TEMPLATE_PATH;

	[Token(Token = "0x400BB3D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
	private SelectionButton nextButtonCorrect;

	[Token(Token = "0x400BB3E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
	private SelectionButton nextButtonIncorrect;

	[Token(Token = "0x400BB3F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
	private Coroutine coroutine;

	[Token(Token = "0x400BB40")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
	private int totalQuestionNum;

	[Token(Token = "0x400BB41")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x11C")]
	private int requireNum;

	[Token(Token = "0x400BB42")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
	private int GradeIndex;

	[Token(Token = "0x400BB43")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
	private Dictionary<int, CertificationRogicHander.QuestionData> questionDatas;

	[Token(Token = "0x400BB44")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
	private Dictionary<int, CertificationRogicHander.QuestionData> pickedQuestionDatas;

	[Token(Token = "0x400BB45")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
	private DownloadQuizRogicHander rogicHander;

	[Token(Token = "0x400BB46")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
	private DownloadQuizSettings settings;

	[Token(Token = "0x400BB47")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
	private int numberOfCycle;

	[Token(Token = "0x400BB48")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14C")]
	private bool isReplay;

	[Token(Token = "0x400BB49")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
	private Dictionary<int, int> correctAnswerIndexList;

	[Token(Token = "0x400BB4A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
	private List<int> pickedCorrectAnswerIndexList;

	[Token(Token = "0x400BB4B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
	private readonly string TXT_DL_LABEL;

	[Token(Token = "0x400BB4C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
	private readonly string TXT_DL_STATE_LABEL;

	[Token(Token = "0x400BB4D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
	private readonly string BTN_OK_LABEL;

	[Token(Token = "0x400BB4E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
	private readonly string IMG_PROGRESS_GAUGE;

	[Token(Token = "0x400BB4F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
	private readonly string FLIP_BUTTON_LABEL;

	[Token(Token = "0x400BB50")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
	private readonly string BACK_AREA_BUTTON_LABEL;

	[Token(Token = "0x400BB51")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
	private readonly string CARD_BUTTON_LABEL;

	[Token(Token = "0x400BB52")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
	private readonly string TEXT_NEXT_LABEL;

	[Token(Token = "0x400BB53")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
	private readonly string TEXT_DETAIL_LABEL;

	[Token(Token = "0x400BB54")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
	private readonly string IMAGE_LABEL;

	[Token(Token = "0x400BB55")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1B0")]
	private readonly string CARDBROWSER;

	[Token(Token = "0x400BB56")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1B8")]
	private readonly string FOOTER_SC_ICON_0;

	[Token(Token = "0x400BB57")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C0")]
	private readonly string FOOTER_SC_ICON_1;

	[Token(Token = "0x400BB58")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C8")]
	private readonly string ANDROID_BACK_KEY_LABEL;

	[Token(Token = "0x400BB59")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1D0")]
	private readonly string FOOTER;

	[Token(Token = "0x400BB5A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1D8")]
	private readonly string ROOT;

	[Token(Token = "0x400BB5B")]
	private const long OneTerabyte = 1099511627776L;

	[Token(Token = "0x400BB5C")]
	private const long SizeThreshold = 109951162777600L;

	[Token(Token = "0x400BB5D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1E0")]
	private GameObject Root;

	[Token(Token = "0x400BB5E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1E8")]
	private GameObject Footer;

	[Token(Token = "0x400BB5F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1F0")]
	private TextMeshProUGUI DownloadingText;

	[Token(Token = "0x400BB60")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1F8")]
	private TextMeshProUGUI DownloadingStateText;

	[Token(Token = "0x400BB61")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x200")]
	private SelectionButton btnOK;

	[Token(Token = "0x400BB62")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x208")]
	private Image progressGaugeImage;

	[Token(Token = "0x400BB63")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x210")]
	private TextMeshProUGUI textNext;

	[Token(Token = "0x400BB64")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x218")]
	private TextMeshProUGUI textDetail;

	[Token(Token = "0x400BB65")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x220")]
	private Image BGimage;

	[Token(Token = "0x400BB66")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x228")]
	private ShortcutIcon shortCutIcon0;

	[Token(Token = "0x400BB67")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x230")]
	private ShortcutIcon shortCutIcon1;

	[Token(Token = "0x400BB68")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x238")]
	private SelectionButtonUntouchable backBtn;

	[Token(Token = "0x400BB69")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x240")]
	private DownloadController downloadController;

	[Token(Token = "0x400BB6A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x248")]
	private bool isDownloading;

	[Token(Token = "0x400BB6B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x249")]
	private bool endFlag;

	[Token(Token = "0x400BB6C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24A")]
	private bool isRendering;

	[Token(Token = "0x400BB6D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x250")]
	private PlayableDirector downloadTransition;

	[Token(Token = "0x400BB6E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x258")]
	private EventPlayableAsset eventPlayableAsset;

	[Token(Token = "0x400BB6F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x260")]
	private double TIME_OPEN;

	[Token(Token = "0x400BB70")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x268")]
	private bool BGcardSetCompletedFlag;

	[Token(Token = "0x400BB71")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x26C")]
	private int m_oldCardIndex;

	[Token(Token = "0x400BB72")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x270")]
	private int pickCount;

	[Token(Token = "0x400BB73")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x278")]
	private Renderer renderer0;

	[Token(Token = "0x400BB74")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x280")]
	private Renderer renderer1;

	[Token(Token = "0x400BB75")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x288")]
	private ElementObjectManager effEom;

	[Token(Token = "0x400BB76")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x290")]
	private ElementObjectManager eom;

	[Token(Token = "0x400BB77")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x298")]
	private ElementObject cardfront;

	[Token(Token = "0x400BB78")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2A0")]
	private List<UnityAction<Texture2D>> onFinishList;

	[Token(Token = "0x400BB79")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2A8")]
	private SelectionButton cardButton;

	[Token(Token = "0x400BB7A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2B0")]
	private SelectionButton backAreaButton;

	[Token(Token = "0x400BB7B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2B8")]
	private CardIllustManager cardIllustManager;

	[Token(Token = "0x400BB7C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C0")]
	private int mrk;

	[Token(Token = "0x400BB7D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C8")]
	private List<int> mrkList;

	[Token(Token = "0x400BB7E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2D0")]
	private bool FlipCardActiveFlag;

	[Token(Token = "0x400BB7F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2D1")]
	private bool timeLineStartFrag;

	[Token(Token = "0x400BB80")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2D2")]
	private bool isCardBrowserOpen;

	[Token(Token = "0x400BB81")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2D4")]
	private float flipTime;

	[Token(Token = "0x400BB82")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2D8")]
	private bool flipingFlag;

	[Token(Token = "0x400BB83")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2D9")]
	private bool openningCardBrowser;

	[Token(Token = "0x400BB84")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2E0")]
	private List<int> avoidList;

	[Token(Token = "0x400BB85")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2E8")]
	private int MIN_NUM;

	[Token(Token = "0x400BB86")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2EC")]
	private int startNum;

	[Token(Token = "0x400BB87")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2F0")]
	private int endNum;

	[Token(Token = "0x400BB88")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2F4")]
	private int MAX_STARTNUM;

	[Token(Token = "0x400BB89")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2F8")]
	private int MAX_ENDNUM;

	[Token(Token = "0x400BB8A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2FC")]
	private int plusNum;

	[Token(Token = "0x400BB8B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x300")]
	private int mustStart;

	[Token(Token = "0x400BB8C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x304")]
	private int mustEnd;

	[Token(Token = "0x400BB8D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x308")]
	private bool skipDownload;

	[Token(Token = "0x400BB8E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30C")]
	private float autofliptime;

	[Token(Token = "0x400BB8F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x310")]
	private int flipCountNum;

	[Token(Token = "0x400BB90")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x314")]
	private bool isCancel;

	[Token(Token = "0x400BB91")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x315")]
	private bool rebootFlag;

	[Token(Token = "0x400BB92")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x316")]
	private bool errCheckBGCardFrag;

	[Token(Token = "0x400BB93")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x318")]
	private List<int> builtinList;

	[Token(Token = "0x400BB94")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x320")]
	private int SelectorGoThroughPriority;

	[Token(Token = "0x400BB95")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x328")]
	private ViewController cardBrowserVC;

	[Token(Token = "0x400BB96")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x330")]
	private CertificationMateViewer mateViewer;

	[Token(Token = "0x400BB97")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x338")]
	private bool isQuizMode;

	[Token(Token = "0x400BB98")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x339")]
	private bool isClickedOK;

	[Token(Token = "0x1700120B")]
	public int totalQuestionNumPub
	{
		[Token(Token = "0x600726C")]
		[Address(RVA = "0x49BF20", Offset = "0x49B120", VA = "0x18049BF20")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x1700120C")]
	public int requireNumPub
	{
		[Token(Token = "0x600726D")]
		[Address(RVA = "0x49BE10", Offset = "0x49B010", VA = "0x18049BE10")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x1700120D")]
	public int GradeIndexPub
	{
		[Token(Token = "0x600726E")]
		[Address(RVA = "0x49B8A0", Offset = "0x49AAA0", VA = "0x18049B8A0")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x1700120E")]
	protected override Type[] textIds
	{
		[Token(Token = "0x6007278")]
		[Address(RVA = "0xB92430", Offset = "0xB91630", VA = "0x180B92430", Slot = "21")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700120F")]
	private bool isReadyMate
	{
		[Token(Token = "0x6007279")]
		[Address(RVA = "0xB923A0", Offset = "0xB915A0", VA = "0x180B923A0")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x600726F")]
	public T CreateGameObject<T>(GameObject parent, string name, [Optional] Type[] components) where T : MonoBehaviour
	{
		return null;
	}

	[Token(Token = "0x6007270")]
	[Address(RVA = "0xB8BF50", Offset = "0xB8B150", VA = "0x180B8BF50")]
	public GameObject CreateGameObject(GameObject parent, string name, [Optional] Type[] components)
	{
		return null;
	}

	[Token(Token = "0x6007271")]
	[Address(RVA = "0xB8ECC0", Offset = "0xB8DEC0", VA = "0x180B8ECC0")]
	private void StartQuiz()
	{
	}

	[Token(Token = "0x6007272")]
	[Address(RVA = "0xB8C7D0", Offset = "0xB8B9D0", VA = "0x180B8C7D0")]
	private void InitElements()
	{
	}

	[Token(Token = "0x6007273")]
	[Address(RVA = "0xB8D130", Offset = "0xB8C330", VA = "0x180B8D130")]
	private void OnClickNextBtn()
	{
	}

	[Token(Token = "0x6007274")]
	[Address(RVA = "0xB8C750", Offset = "0xB8B950", VA = "0x180B8C750")]
	private void InitData()
	{
	}

	[Token(Token = "0x6007275")]
	[Address(RVA = "0xB8E6D0", Offset = "0xB8D8D0", VA = "0x180B8E6D0")]
	private void SetQuestionDataRandom()
	{
	}

	[Token(Token = "0x6007276")]
	[Address(RVA = "0xB8DE80", Offset = "0xB8D080", VA = "0x180B8DE80")]
	private void OnRemove()
	{
	}

	[Token(Token = "0x6007277")]
	[Address(RVA = "0xB8DAE0", Offset = "0xB8CCE0", VA = "0x180B8DAE0")]
	private void OnFinishedQuiz()
	{
	}

	[Token(Token = "0x600727A")]
	[Address(RVA = "0xB8E4E0", Offset = "0xB8D6E0", VA = "0x180B8E4E0")]
	private void SetMate()
	{
	}

	[Token(Token = "0x600727B")]
	[Address(RVA = "0xB8E060", Offset = "0xB8D260", VA = "0x180B8E060")]
	private void PlayMateMotion(AvatarMotionSetting.MotionID id)
	{
	}

	[Token(Token = "0x600727C")]
	[Address(RVA = "0xB8DFB0", Offset = "0xB8D1B0", VA = "0x180B8DFB0", Slot = "24")]
	protected override void OnTransitionStart(TransitionType type)
	{
	}

	[Token(Token = "0x600727D")]
	[Address(RVA = "0xB8CD70", Offset = "0xB8BF70", VA = "0x180B8CD70", Slot = "6")]
	public override void NotificationStackEntry()
	{
	}

	[Token(Token = "0x600727E")]
	[Address(RVA = "0xB8CE90", Offset = "0xB8C090", VA = "0x180B8CE90", Slot = "7")]
	public override void NotificationStackRemove()
	{
	}

	[Token(Token = "0x600727F")]
	[Address(RVA = "0xB8D290", Offset = "0xB8C490", VA = "0x180B8D290", Slot = "23")]
	protected override void OnCreatedView()
	{
	}

	[Token(Token = "0x6007280")]
	[Address(RVA = "0xB916A0", Offset = "0xB908A0", VA = "0x180B916A0")]
	[IteratorStateMachine(typeof(_003CWaitPopView_003Ed__124))]
	private IEnumerator WaitPopView()
	{
		return null;
	}

	[Token(Token = "0x6007281")]
	[Address(RVA = "0xB91320", Offset = "0xB90520", VA = "0x180B91320")]
	private void Update()
	{
	}

	[Token(Token = "0x6007282")]
	[Address(RVA = "0xB8BED0", Offset = "0xB8B0D0", VA = "0x180B8BED0")]
	private bool CheckCardBrowser()
	{
		return default(bool);
	}

	[Token(Token = "0x6007283")]
	[Address(RVA = "0xB8BBA0", Offset = "0xB8ADA0", VA = "0x180B8BBA0")]
	private void ChangeCardBrowserUI()
	{
	}

	[Token(Token = "0x6007284")]
	[Address(RVA = "0xB8E140", Offset = "0xB8D340", VA = "0x180B8E140")]
	private void SetActiveFooter(bool set)
	{
	}

	[Token(Token = "0x6007285")]
	[Address(RVA = "0xB92140", Offset = "0xB91340", VA = "0x180B92140")]
	private void clickBackAreaButton()
	{
	}

	[Token(Token = "0x6007286")]
	[Address(RVA = "0xB8BA40", Offset = "0xB8AC40", VA = "0x180B8BA40")]
	private void AutoFlip()
	{
	}

	[Token(Token = "0x6007287")]
	[Address(RVA = "0xB8EB60", Offset = "0xB8DD60", VA = "0x180B8EB60")]
	private void StartDownload()
	{
	}

	[Token(Token = "0x6007288")]
	[Address(RVA = "0xB8C040", Offset = "0xB8B240", VA = "0x180B8C040")]
	public void FlipCard()
	{
	}

	[Token(Token = "0x6007289")]
	[Address(RVA = "0xB8BF60", Offset = "0xB8B160", VA = "0x180B8BF60")]
	private void FadeCard()
	{
	}

	[Token(Token = "0x600728A")]
	[Address(RVA = "0xB91D70", Offset = "0xB90F70", VA = "0x180B91D70")]
	private void changeCardIDRange()
	{
	}

	[Token(Token = "0x600728B")]
	[Address(RVA = "0xB8BDE0", Offset = "0xB8AFE0", VA = "0x180B8BDE0")]
	private void ChangeOneBGCard()
	{
	}

	[Token(Token = "0x600728C")]
	[Address(RVA = "0xB8BAC0", Offset = "0xB8ACC0", VA = "0x180B8BAC0")]
	private void CardDetail(int mrk)
	{
	}

	[Token(Token = "0x600728D")]
	[Address(RVA = "0xB92310", Offset = "0xB91510", VA = "0x180B92310")]
	private void endEvent()
	{
	}

	[Token(Token = "0x600728E")]
	[Address(RVA = "0xB8F2B0", Offset = "0xB8E4B0", VA = "0x180B8F2B0")]
	private void StartTimeLine()
	{
	}

	[Token(Token = "0x600728F")]
	[Address(RVA = "0xB8E1B0", Offset = "0xB8D3B0", VA = "0x180B8E1B0")]
	private void SetEventCallBackTimeLine()
	{
	}

	[Token(Token = "0x6007290")]
	[Address(RVA = "0xB8C2C0", Offset = "0xB8B4C0", VA = "0x180B8C2C0")]
	private EventPlayableAsset GetEventPlayableAsset(PlayableDirector timeline)
	{
		return null;
	}

	[Token(Token = "0x6007291")]
	[Address(RVA = "0xB8B960", Offset = "0xB8AB60", VA = "0x180B8B960")]
	[IteratorStateMachine(typeof(_003CAsyncNewCardCheck_003Ed__142))]
	private IEnumerator AsyncNewCardCheck(int mrk)
	{
		return null;
	}

	[Token(Token = "0x6007292")]
	[Address(RVA = "0xB8B9D0", Offset = "0xB8ABD0", VA = "0x180B8B9D0")]
	[IteratorStateMachine(typeof(_003CAsyncWaitAndStart_003Ed__143))]
	private IEnumerator AsyncWaitAndStart()
	{
		return null;
	}

	[Token(Token = "0x6007293")]
	[Address(RVA = "0xB92680", Offset = "0xB91880", VA = "0x180B92680")]
	private void setMrkList()
	{
	}

	[Token(Token = "0x6007294")]
	[Address(RVA = "0xB91FC0", Offset = "0xB911C0", VA = "0x180B91FC0")]
	private bool checkCardMrk(int id)
	{
		return default(bool);
	}

	[Token(Token = "0x6007295")]
	[Address(RVA = "0xB8C630", Offset = "0xB8B830", VA = "0x180B8C630")]
	public string GetPathByCardId(int mrk)
	{
		return null;
	}

	[Token(Token = "0x6007296")]
	[Address(RVA = "0xB91EF0", Offset = "0xB910F0", VA = "0x180B91EF0")]
	private bool checkCardMrkTest(int id)
	{
		return default(bool);
	}

	[Token(Token = "0x6007297")]
	[Address(RVA = "0xB91DD0", Offset = "0xB90FD0", VA = "0x180B91DD0")]
	private bool checkAvoidCard(int id)
	{
		return default(bool);
	}

	[Token(Token = "0x6007298")]
	[Address(RVA = "0xB92500", Offset = "0xB91700", VA = "0x180B92500")]
	private int randomMRK(int start, int end)
	{
		return default(int);
	}

	[Token(Token = "0x6007299")]
	[Address(RVA = "0xB91710", Offset = "0xB90910", VA = "0x180B91710")]
	public DownloadViewController()
	{
	}
}
