using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Playables;
using YgomGame.Menu;
using YgomSystem.ElementSystem;
using YgomSystem.UI;

namespace YgomGame.Lottery;

[Token(Token = "0x2001719")]
public class LotteryResultViewController : BaseMenuViewController
{
	[Token(Token = "0x200171A")]
	private class TurnOverQueue
	{
		[Token(Token = "0x400DA98")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private Queue<(PlayableDirector, Action<PlayableDirector>)> m_Queue;

		[Token(Token = "0x400DA99")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private List<GameObject> m_ExecutedObj;

		[Token(Token = "0x400DA9A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private PlayableDirector m_CurrentPlayPd;

		[Token(Token = "0x400DA9B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public bool isSkipping;

		[Token(Token = "0x1700164B")]
		public bool isPlaying
		{
			[Token(Token = "0x600911F")]
			[Address(RVA = "0xDB87F0", Offset = "0xDB79F0", VA = "0x180DB87F0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6009120")]
		[Address(RVA = "0xDB8720", Offset = "0xDB7920", VA = "0x180DB8720")]
		public TurnOverQueue()
		{
		}

		[Token(Token = "0x6009121")]
		[Address(RVA = "0xDB8410", Offset = "0xDB7610", VA = "0x180DB8410")]
		public void Enqueue(PlayableDirector pd, Action<PlayableDirector> action)
		{
		}

		[Token(Token = "0x6009122")]
		[Address(RVA = "0xDB84B0", Offset = "0xDB76B0", VA = "0x180DB84B0")]
		public void Update()
		{
		}
	}

	[Token(Token = "0x2001722")]
	[CompilerGenerated]
	private sealed class _003CyInitialize_003Ed__34 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400DAB3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400DAB4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400DAB5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public LotteryResultViewController _003C_003E4__this;

		[Token(Token = "0x1700164C")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6009141")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700164D")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6009143")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600913E")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CyInitialize_003Ed__34(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x600913F")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6009140")]
		[Address(RVA = "0xDBEF60", Offset = "0xDBE160", VA = "0x180DBEF60", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6009142")]
		[Address(RVA = "0xDBF1F0", Offset = "0xDBE3F0", VA = "0x180DBF1F0", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x400DA7D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	private readonly string k_TurnOverArea;

	[Token(Token = "0x400DA7E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	private readonly string k_SelectedArea;

	[Token(Token = "0x400DA7F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	private readonly string k_DragArea;

	[Token(Token = "0x400DA80")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	private readonly string k_CardLabel;

	[Token(Token = "0x400DA81")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	private readonly string k_SlideEffect;

	[Token(Token = "0x400DA82")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	private readonly string k_SheetNotificatorLabel;

	[Token(Token = "0x400DA83")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
	private readonly string k_WinningSeLabel;

	[Token(Token = "0x400DA84")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
	private readonly string k_AutoOpenButton;

	[Token(Token = "0x400DA85")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
	private readonly string k_SECategory;

	[Token(Token = "0x400DA86")]
	private const string KEY_LOTTERY_ID = "KeyLotteryId";

	[Token(Token = "0x400DA87")]
	private const string KEY_LOTTERY_SET = "KeyLotterySet";

	[Token(Token = "0x400DA88")]
	private const string KEY_LOTTERY_ONCOMPLETED = "KeyLotteryOnCompleted";

	[Token(Token = "0x400DA89")]
	private const string k_PrefPath = "Lottery/LotteryResult";

	[Token(Token = "0x400DA8A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
	[SerializeField]
	private int m_CardNum;

	[Token(Token = "0x400DA8B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x11C")]
	[SerializeField]
	private int m_RoundNum;

	[Token(Token = "0x400DA8C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
	private SelectionButton m_DragArea;

	[Token(Token = "0x400DA8D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
	private ElementObjectManager m_SelectedArea;

	[Token(Token = "0x400DA8E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
	private Vector2 m_PrevTouchScreenPos;

	[Token(Token = "0x400DA8F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
	private TurnOverQueue m_TurnOverQueue;

	[Token(Token = "0x400DA90")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
	private List<SheetViewer> m_SheetViewer;

	[Token(Token = "0x400DA91")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
	private int m_Id;

	[Token(Token = "0x400DA92")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14C")]
	private int m_Set;

	[Token(Token = "0x400DA93")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
	private List<GameObject> m_ExecutedObj;

	[Token(Token = "0x400DA94")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
	private GameObject m_SlideEffect;

	[Token(Token = "0x400DA95")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
	private bool[] m_IsTurned;

	[Token(Token = "0x400DA96")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
	private Coroutine m_InitCoroutine;

	[Token(Token = "0x400DA97")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
	private SelectionButton m_SkipButton;

	[Token(Token = "0x17001649")]
	protected override int outGameBgId
	{
		[Token(Token = "0x600910E")]
		[Address(RVA = "0xDA1B00", Offset = "0xDA0D00", VA = "0x180DA1B00", Slot = "20")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x1700164A")]
	protected override Type[] textIds
	{
		[Token(Token = "0x600910F")]
		[Address(RVA = "0xDAF450", Offset = "0xDAE650", VA = "0x180DAF450", Slot = "21")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6009110")]
	[Address(RVA = "0xDAEE50", Offset = "0xDAE050", VA = "0x180DAEE50")]
	public static void Open(int id, int set = 0, [Optional] Action onCompleted, [Optional] Dictionary<string, object> args)
	{
	}

	[Token(Token = "0x6009111")]
	[Address(RVA = "0xDADC20", Offset = "0xDACE20", VA = "0x180DADC20", Slot = "6")]
	public override void NotificationStackEntry()
	{
	}

	[Token(Token = "0x6009112")]
	[Address(RVA = "0xDAF520", Offset = "0xDAE720", VA = "0x180DAF520")]
	[IteratorStateMachine(typeof(_003CyInitialize_003Ed__34))]
	private IEnumerator yInitialize()
	{
		return null;
	}

	[Token(Token = "0x6009113")]
	[Address(RVA = "0xDADD80", Offset = "0xDACF80", VA = "0x180DADD80", Slot = "7")]
	public override void NotificationStackRemove()
	{
	}

	[Token(Token = "0x6009114")]
	[Address(RVA = "0xDAEDE0", Offset = "0xDADFE0", VA = "0x180DAEDE0")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6009115")]
	[Address(RVA = "0xDAF1C0", Offset = "0xDAE3C0", VA = "0x180DAF1C0")]
	private void Update()
	{
	}

	[Token(Token = "0x6009116")]
	[Address(RVA = "0xDADEC0", Offset = "0xDAD0C0", VA = "0x180DADEC0", Slot = "23")]
	protected override void OnCreatedView()
	{
	}

	[Token(Token = "0x6009117")]
	[Address(RVA = "0x81C9D0", Offset = "0x81BBD0", VA = "0x18081C9D0")]
	private bool IsDragStart(Vector2 start, Vector2 end)
	{
		return default(bool);
	}

	[Token(Token = "0x6009118")]
	[Address(RVA = "0xDACF20", Offset = "0xDAC120", VA = "0x180DACF20")]
	private void CheckHitDraggingCard(Vector2 prevScreenPos, Vector2 currentScreenPos)
	{
	}

	[Token(Token = "0x6009119")]
	[Address(RVA = "0xDAEFC0", Offset = "0xDAE1C0", VA = "0x180DAEFC0")]
	private void TurnOverAction(PlayableDirector pd)
	{
	}

	[Token(Token = "0x600911A")]
	[Address(RVA = "0xDAD5A0", Offset = "0xDAC7A0", VA = "0x180DAD5A0")]
	private void CheckTurnOverState(PlayableDirector pd)
	{
	}

	[Token(Token = "0x600911B")]
	[Address(RVA = "0xDACC80", Offset = "0xDABE80", VA = "0x180DACC80")]
	private void AutoOpen(List<PlayableDirector> cardButtons)
	{
	}

	[Token(Token = "0x600911C")]
	[Address(RVA = "0xDAF1E0", Offset = "0xDAE3E0", VA = "0x180DAF1E0")]
	public LotteryResultViewController()
	{
	}
}
