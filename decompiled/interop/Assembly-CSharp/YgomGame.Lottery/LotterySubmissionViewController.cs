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
using YgomSystem.Timeline;

namespace YgomGame.Lottery;

[Token(Token = "0x2001727")]
public class LotterySubmissionViewController : BaseMenuViewController, ILotteryChildViewControllerGroup
{
	[Token(Token = "0x2001728")]
	[CompilerGenerated]
	private sealed class _003CySubmitAnimation_003Ed__27 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400DAEB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400DAEC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400DAED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public LotterySubmissionViewController _003C_003E4__this;

		[Token(Token = "0x400DAEE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public List<int[]> cards;

		[Token(Token = "0x400DAEF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private int _003Cday_003E5__2;

		[Token(Token = "0x400DAF0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private PlayableDirector _003CcardInPd_003E5__3;

		[Token(Token = "0x400DAF1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private PlayableDirector _003CmovePd_003E5__4;

		[Token(Token = "0x400DAF2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private LabeledPlayableController _003CmoveTimeline_003E5__5;

		[Token(Token = "0x17001654")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6009168")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17001655")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600916A")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6009165")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CySubmitAnimation_003Ed__27(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6009166")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6009167")]
		[Address(RVA = "0xDBF230", Offset = "0xDBE430", VA = "0x180DBF230", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6009169")]
		[Address(RVA = "0xDBF930", Offset = "0xDBEB30", VA = "0x180DBF930", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x400DAD8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	private readonly string k_CardInViewArea;

	[Token(Token = "0x400DAD9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	private readonly string k_SubmittedViewArea;

	[Token(Token = "0x400DADA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	private readonly string k_UIArea;

	[Token(Token = "0x400DADB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	private readonly string k_TicketLabel;

	[Token(Token = "0x400DADC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	private readonly string k_TMMoveLabel;

	[Token(Token = "0x400DADD")]
	private const string KEY_SUBMIT_CARDS = "KeySubmitCards";

	[Token(Token = "0x400DADE")]
	private const string KEY_LOTTERY_ID = "KeyLotteryId";

	[Token(Token = "0x400DADF")]
	private const string k_PrefPath = "Lottery/LotterySubmission";

	[Token(Token = "0x400DAE0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	[SerializeField]
	private int m_RoundNum;

	[Token(Token = "0x400DAE1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xFC")]
	private int m_Id;

	[Token(Token = "0x400DAE2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
	private ElementObjectManager m_CardInEom;

	[Token(Token = "0x400DAE3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
	private ElementObjectManager m_SubmittedEom;

	[Token(Token = "0x400DAE4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
	private List<SheetViewer> m_SheetViewers;

	[Token(Token = "0x400DAE5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
	private ElementObjectManager m_UIEom;

	[Token(Token = "0x400DAE6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
	private ElementObjectManager m_FocusSheetEom;

	[Token(Token = "0x400DAE7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
	private SheetViewer m_FocusSheet;

	[Token(Token = "0x400DAE8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
	private List<GameObject> m_Shades;

	[Token(Token = "0x400DAE9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
	private Coroutine m_TimeLineController;

	[Token(Token = "0x400DAEA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
	private bool m_IsSkip;

	[Token(Token = "0x17001652")]
	protected override int outGameBgId
	{
		[Token(Token = "0x600915B")]
		[Address(RVA = "0xDA1B00", Offset = "0xDA0D00", VA = "0x180DA1B00", Slot = "20")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17001653")]
	protected override Type[] textIds
	{
		[Token(Token = "0x600915C")]
		[Address(RVA = "0xDB1F40", Offset = "0xDB1140", VA = "0x180DB1F40", Slot = "21")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600915D")]
	[Address(RVA = "0xDB1C40", Offset = "0xDB0E40", VA = "0x180DB1C40")]
	public static void Open(int id, int[] submitCards, [Optional] Dictionary<string, object> args)
	{
	}

	[Token(Token = "0x600915E")]
	[Address(RVA = "0xDB1550", Offset = "0xDB0750", VA = "0x180DB1550", Slot = "6")]
	public override void NotificationStackEntry()
	{
	}

	[Token(Token = "0x600915F")]
	[Address(RVA = "0xDB15C0", Offset = "0xDB07C0", VA = "0x180DB15C0", Slot = "23")]
	protected override void OnCreatedView()
	{
	}

	[Token(Token = "0x6009160")]
	[Address(RVA = "0xDB1BD0", Offset = "0xDB0DD0", VA = "0x180DB1BD0")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6009161")]
	[Address(RVA = "0xDB2010", Offset = "0xDB1210", VA = "0x180DB2010")]
	[IteratorStateMachine(typeof(_003CySubmitAnimation_003Ed__27))]
	private IEnumerator ySubmitAnimation(List<int[]> cards)
	{
		return null;
	}

	[Token(Token = "0x6009162")]
	[Address(RVA = "0xDB1D80", Offset = "0xDB0F80", VA = "0x180DB1D80")]
	public LotterySubmissionViewController()
	{
	}
}
