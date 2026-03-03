using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using YgomGame.Menu;
using YgomSystem.ElementSystem;
using YgomSystem.UI;
using YgomSystem.YGomTMPro;

namespace YgomGame.Certification;

[Token(Token = "0x20014B3")]
public class CertificationDetailViewController : BaseMenuViewController, IBackButtonSupported, IHeaderBorderSupported
{
	[Token(Token = "0x20014B4")]
	public class ItemData
	{
		[Token(Token = "0x400C7D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int itemCategory;

		[Token(Token = "0x400C7D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public int itemId;

		[Token(Token = "0x400C7D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int num;

		[Token(Token = "0x400C7D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public int needLv;

		[Token(Token = "0x400C7D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool isPeriod;

		[Token(Token = "0x600806F")]
		[Address(RVA = "0xC98180", Offset = "0xC97380", VA = "0x180C98180")]
		public ItemData(int itemCategory, int itemId, int num, bool isPeriod)
		{
		}
	}

	[Token(Token = "0x20014B7")]
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass91_0
	{
		[Token(Token = "0x400C7DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public bool rewardDialogClose;

		[Token(Token = "0x6008076")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public _003C_003Ec__DisplayClass91_0()
		{
		}

		[Token(Token = "0x6008077")]
		[Address(RVA = "0x465890", Offset = "0x464A90", VA = "0x180465890")]
		internal void _003CCheckAnimation_003Eb__0()
		{
		}
	}

	[Token(Token = "0x20014B9")]
	[CompilerGenerated]
	private sealed class _003CCheckAnimation_003Ed__91 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400C7E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400C7E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400C7E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public CertificationDetailViewController _003C_003E4__this;

		[Token(Token = "0x400C7E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private _003C_003Ec__DisplayClass91_0 _003C_003E8__1;

		[Token(Token = "0x170013B4")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x600807F")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170013B5")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6008081")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600807C")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CCheckAnimation_003Ed__91(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x600807D")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x600807E")]
		[Address(RVA = "0xC98730", Offset = "0xC97930", VA = "0x180C98730", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6008080")]
		[Address(RVA = "0xC99110", Offset = "0xC98310", VA = "0x180C99110", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x20014BA")]
	[CompilerGenerated]
	private sealed class _003CyPlayPaging_003Ed__87 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400C7E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400C7E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400C7E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public int direction;

		[Token(Token = "0x400C7E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public CertificationDetailViewController _003C_003E4__this;

		[Token(Token = "0x400C7EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private string _003CoutKey_003E5__2;

		[Token(Token = "0x400C7EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private string _003CinKey_003E5__3;

		[Token(Token = "0x170013B6")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6008085")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170013B7")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6008087")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6008082")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CyPlayPaging_003Ed__87(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6008083")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6008084")]
		[Address(RVA = "0xC9B640", Offset = "0xC9A840", VA = "0x180C9B640", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6008086")]
		[Address(RVA = "0xC9B9E0", Offset = "0xC9ABE0", VA = "0x180C9B9E0", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x400C793")]
	public const string prefPath = "Certification/CertificationDetail";

	[Token(Token = "0x400C794")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	private readonly string BUTTON_ITEM_LABEL;

	[Token(Token = "0x400C795")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	private readonly string BUTTON_ICON_LABEL;

	[Token(Token = "0x400C796")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	private readonly string TEXT_ICONNAME_LABEL;

	[Token(Token = "0x400C797")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	private readonly string L_TextArea;

	[Token(Token = "0x400C798")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	private readonly string L_Main;

	[Token(Token = "0x400C799")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	private readonly string L_ClassIconNext;

	[Token(Token = "0x400C79A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
	private readonly string L_ClassIconPrev;

	[Token(Token = "0x400C79B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
	private readonly string L_IconTeam;

	[Token(Token = "0x400C79C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
	private readonly string L_IconTeamNext;

	[Token(Token = "0x400C79D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
	private readonly string L_IconTeamPrev;

	[Token(Token = "0x400C79E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
	private readonly string L_TextMax;

	[Token(Token = "0x400C79F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
	private readonly string L_Lock;

	[Token(Token = "0x400C7A0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
	private readonly string L_Unlock;

	[Token(Token = "0x400C7A1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
	private readonly string L_templatePractical;

	[Token(Token = "0x400C7A2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
	private readonly string L_templateReward;

	[Token(Token = "0x400C7A3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
	private readonly string L_templateWriting;

	[Token(Token = "0x400C7A4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
	private readonly string L_ButtonHelp;

	[Token(Token = "0x400C7A5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
	private readonly string L_TextTarget;

	[Token(Token = "0x400C7A6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
	private readonly string L_Button;

	[Token(Token = "0x400C7A7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
	private readonly string L_IconGet;

	[Token(Token = "0x400C7A8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
	private readonly string L_Tween_Default;

	[Token(Token = "0x400C7A9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
	private readonly string L_Tween_Complete;

	[Token(Token = "0x400C7AA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
	private readonly string L_Tween_Animate;

	[Token(Token = "0x400C7AB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
	private readonly string k_ELabelPrevButton;

	[Token(Token = "0x400C7AC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
	private readonly string k_ELabelNextButton;

	[Token(Token = "0x400C7AD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
	private readonly string k_TLabelPagingNextOut;

	[Token(Token = "0x400C7AE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
	private readonly string k_TLabelPagingBackOut;

	[Token(Token = "0x400C7AF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
	private readonly string k_TLabelPagingNextIn;

	[Token(Token = "0x400C7B0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1B0")]
	private readonly string k_TLabelPagingBackIn;

	[Token(Token = "0x400C7B1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1B8")]
	private readonly string k_ELabelShortcutButtonL1;

	[Token(Token = "0x400C7B2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C0")]
	private readonly string k_ELabelShortcutButtonR1;

	[Token(Token = "0x400C7B3")]
	public const string ArgsKeyPracticalResult = "PracticalResult";

	[Token(Token = "0x400C7B4")]
	public const string ArgsKeyOnFinished = "onFinished";

	[Token(Token = "0x400C7B5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C8")]
	private string m_BaseBGM;

	[Token(Token = "0x400C7B6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1D0")]
	private ElementObjectManager textAreaEom;

	[Token(Token = "0x400C7B7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1D8")]
	private ElementObjectManager mainEOM;

	[Token(Token = "0x400C7B8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1E0")]
	private ElementObjectManager templateWriting;

	[Token(Token = "0x400C7B9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1E8")]
	private ElementObjectManager templatePractical;

	[Token(Token = "0x400C7BA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1F0")]
	private ElementObjectManager templateReward;

	[Token(Token = "0x400C7BB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1F8")]
	private GameObject arrowLock;

	[Token(Token = "0x400C7BC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x200")]
	private GameObject arrowUnLock;

	[Token(Token = "0x400C7BD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x208")]
	private GameObject iconRewardGet;

	[Token(Token = "0x400C7BE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x210")]
	private bool isWritingComp;

	[Token(Token = "0x400C7BF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x211")]
	private bool isBothComp;

	[Token(Token = "0x400C7C0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x214")]
	private int m_PageIdx;

	[Token(Token = "0x400C7C1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x218")]
	private int m_PageCount;

	[Token(Token = "0x400C7C2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x21C")]
	private int m_InProgressGrade;

	[Token(Token = "0x400C7C3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x220")]
	private int m_rewardSetId;

	[Token(Token = "0x400C7C4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x224")]
	private int m_totalQuestionNum;

	[Token(Token = "0x400C7C5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x228")]
	private int m_requireNum;

	[Token(Token = "0x400C7C6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x22C")]
	private int m_PresentReceive;

	[Token(Token = "0x400C7C7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x230")]
	private int m_upgradeFragIdx;

	[Token(Token = "0x400C7C8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x234")]
	private CertificationUtil.ProgressState currentProgress;

	[Token(Token = "0x400C7C9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x238")]
	private List<ItemData> rewardItemDataList;

	[Token(Token = "0x400C7CA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x240")]
	private SelectionButton m_PrevButton;

	[Token(Token = "0x400C7CB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x248")]
	private SelectionButton m_NextButton;

	[Token(Token = "0x400C7CC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x250")]
	private Image m_PrevIcon;

	[Token(Token = "0x400C7CD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x258")]
	private Image m_NextIcon;

	[Token(Token = "0x400C7CE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x260")]
	private Image m_NowIcon;

	[Token(Token = "0x400C7CF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x268")]
	private ExtendedTextMeshProUGUI maxLvText;

	[Token(Token = "0x400C7D0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x270")]
	private ExtendedTextMeshProUGUI writingBorderText;

	[Token(Token = "0x400C7D1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x278")]
	private UnityAction onFinished;

	[Token(Token = "0x400C7D2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x280")]
	private Dictionary<string, object> master;

	[Token(Token = "0x400C7D3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x288")]
	private List<int> gradeIdsList;

	[Token(Token = "0x170013B2")]
	protected override Type[] textIds
	{
		[Token(Token = "0x6008051")]
		[Address(RVA = "0xC894E0", Offset = "0xC886E0", VA = "0x180C894E0", Slot = "21")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170013B3")]
	protected override int outGameBgId
	{
		[Token(Token = "0x6008052")]
		[Address(RVA = "0x573650", Offset = "0x572850", VA = "0x180573650", Slot = "20")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x6008053")]
	[Address(RVA = "0xC86EF0", Offset = "0xC860F0", VA = "0x180C86EF0")]
	public static void Open(ViewControllerManager vc, [Optional] Dictionary<string, object> args)
	{
	}

	[Token(Token = "0x6008054")]
	[Address(RVA = "0xC86760", Offset = "0xC85960", VA = "0x180C86760", Slot = "8")]
	public override void NotificationStack(ViewControllerManager vcm, ViewController vc, bool isEntry)
	{
	}

	[Token(Token = "0x6008055")]
	[Address(RVA = "0xC864F0", Offset = "0xC856F0", VA = "0x180C864F0", Slot = "6")]
	public override void NotificationStackEntry()
	{
	}

	[Token(Token = "0x6008056")]
	[Address(RVA = "0xC86720", Offset = "0xC85920", VA = "0x180C86720", Slot = "7")]
	public override void NotificationStackRemove()
	{
	}

	[Token(Token = "0x6008057")]
	[Address(RVA = "0xC86DB0", Offset = "0xC85FB0", VA = "0x180C86DB0", Slot = "23")]
	protected override void OnCreatedView()
	{
	}

	[Token(Token = "0x6008058")]
	[Address(RVA = "0xC87850", Offset = "0xC86A50", VA = "0x180C87850")]
	private void Start()
	{
	}

	[Token(Token = "0x6008059")]
	[Address(RVA = "0xC86DD0", Offset = "0xC85FD0", VA = "0x180C86DD0", Slot = "14")]
	public override bool OnResult(ViewController from, object value)
	{
		return default(bool);
	}

	[Token(Token = "0x600805A")]
	[Address(RVA = "0xC85790", Offset = "0xC84990", VA = "0x180C85790")]
	private void GetInitData(int index, bool isEntry = false, bool isBack = false)
	{
	}

	[Token(Token = "0x600805B")]
	[Address(RVA = "0xC87BF0", Offset = "0xC86DF0", VA = "0x180C87BF0")]
	private void UpdateView(bool isEntry = false)
	{
	}

	[Token(Token = "0x600805C")]
	[Address(RVA = "0xC87220", Offset = "0xC86420", VA = "0x180C87220")]
	private void SetElements()
	{
	}

	[Token(Token = "0x600805D")]
	[Address(RVA = "0xC87010", Offset = "0xC86210", VA = "0x180C87010")]
	private void SetButtonCallBack()
	{
	}

	[Token(Token = "0x600805E")]
	[Address(RVA = "0xC86AE0", Offset = "0xC85CE0", VA = "0x180C86AE0")]
	private void OnClickButtonWrit(int id)
	{
	}

	[Token(Token = "0x600805F")]
	[Address(RVA = "0xC869B0", Offset = "0xC85BB0", VA = "0x180C869B0")]
	private void OnClickButtonPrac(int id)
	{
	}

	[Token(Token = "0x6008060")]
	[Address(RVA = "0xC86C50", Offset = "0xC85E50", VA = "0x180C86C50")]
	private void OnClickNextButton()
	{
	}

	[Token(Token = "0x6008061")]
	[Address(RVA = "0xC86D00", Offset = "0xC85F00", VA = "0x180C86D00")]
	private void OnClickPrevButton()
	{
	}

	[Token(Token = "0x6008062")]
	[Address(RVA = "0xC86C50", Offset = "0xC85E50", VA = "0x180C86C50")]
	private void ToNextPage()
	{
	}

	[Token(Token = "0x6008063")]
	[Address(RVA = "0xC86D00", Offset = "0xC85F00", VA = "0x180C86D00")]
	private void ToPrevPage()
	{
	}

	[Token(Token = "0x6008064")]
	[Address(RVA = "0xC85640", Offset = "0xC84840", VA = "0x180C85640")]
	private void ChangePage(int dstIdx, int direction = 0)
	{
	}

	[Token(Token = "0x6008065")]
	[Address(RVA = "0xC897B0", Offset = "0xC889B0", VA = "0x180C897B0")]
	[IteratorStateMachine(typeof(_003CyPlayPaging_003Ed__87))]
	private IEnumerator yPlayPaging(int direction = 0)
	{
		return null;
	}

	[Token(Token = "0x6008066")]
	[Address(RVA = "0xC864D0", Offset = "0xC856D0", VA = "0x180C864D0")]
	private string GetTLabelPagingOut(int direction)
	{
		return null;
	}

	[Token(Token = "0x6008067")]
	[Address(RVA = "0x7F5F00", Offset = "0x7F5100", VA = "0x1807F5F00")]
	private string GetTLabelPagingIn(int direction)
	{
		return null;
	}

	[Token(Token = "0x6008068")]
	[Address(RVA = "0xC86FD0", Offset = "0xC861D0", VA = "0x180C86FD0")]
	private void RefreshPage()
	{
	}

	[Token(Token = "0x6008069")]
	[Address(RVA = "0xC85720", Offset = "0xC84920", VA = "0x180C85720")]
	[IteratorStateMachine(typeof(_003CCheckAnimation_003Ed__91))]
	private IEnumerator CheckAnimation()
	{
		return null;
	}

	[Token(Token = "0x600806A")]
	[Address(RVA = "0xC854E0", Offset = "0xC846E0", VA = "0x180C854E0")]
	private void CallApi([Optional] Action onComplited)
	{
	}

	[Token(Token = "0x600806B")]
	[Address(RVA = "0xC88E70", Offset = "0xC88070", VA = "0x180C88E70")]
	public CertificationDetailViewController()
	{
	}
}
