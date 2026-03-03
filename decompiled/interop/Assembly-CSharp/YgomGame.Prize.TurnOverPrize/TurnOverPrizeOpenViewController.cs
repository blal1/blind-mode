using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using YgomGame.Menu;
using YgomGame.Shop;

namespace YgomGame.Prize.TurnOverPrize;

[Token(Token = "0x2000BB2")]
public class TurnOverPrizeOpenViewController : BaseMenuViewController
{
	[Token(Token = "0x2000BB4")]
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass20_0
	{
		[Token(Token = "0x40097CE")]
		[FieldOffset(Offset = "0x10")]
		public bool doneDecideApi;

		[Token(Token = "0x40097CF")]
		[FieldOffset(Offset = "0x18")]
		public TurnOverPrizeOpenViewController _003C_003E4__this;

		[Token(Token = "0x6004755")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public _003C_003Ec__DisplayClass20_0()
		{
		}

		[Token(Token = "0x6004756")]
		[Address(RVA = "0x913D50", Offset = "0x912F50", VA = "0x180913D50")]
		internal void _003CyMainRoutine_003Eb__1()
		{
		}

		[Token(Token = "0x6004757")]
		[Address(RVA = "0x465880", Offset = "0x464A80", VA = "0x180465880")]
		internal bool _003CyMainRoutine_003Eb__2()
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2000BB5")]
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass22_0
	{
		[Token(Token = "0x40097D0")]
		[FieldOffset(Offset = "0x10")]
		public int selectedIdx;

		[Token(Token = "0x40097D1")]
		[FieldOffset(Offset = "0x14")]
		public int confirmIdx;

		[Token(Token = "0x40097D2")]
		[FieldOffset(Offset = "0x18")]
		public bool decided;

		[Token(Token = "0x40097D3")]
		[FieldOffset(Offset = "0x20")]
		public TurnOverPrizeOpenViewController _003C_003E4__this;

		[Token(Token = "0x6004758")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public _003C_003Ec__DisplayClass22_0()
		{
		}
	}

	[Token(Token = "0x2000BB8")]
	[CompilerGenerated]
	private sealed class _003CyMainRoutine_003Ed__20 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40097D8")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x40097D9")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x40097DA")]
		[FieldOffset(Offset = "0x20")]
		public TurnOverPrizeOpenViewController _003C_003E4__this;

		[Token(Token = "0x40097DB")]
		[FieldOffset(Offset = "0x28")]
		private _003C_003Ec__DisplayClass20_0 _003C_003E8__1;

		[Token(Token = "0x170009A3")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6004762")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170009A4")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6004764")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600475F")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CyMainRoutine_003Ed__20(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6004760")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6004761")]
		[Address(RVA = "0x914DB0", Offset = "0x913FB0", VA = "0x180914DB0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6004763")]
		[Address(RVA = "0x915670", Offset = "0x914870", VA = "0x180915670", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x2000BB9")]
	[CompilerGenerated]
	private sealed class _003CyPlayResult_003Ed__23 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40097DC")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x40097DD")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x40097DE")]
		[FieldOffset(Offset = "0x20")]
		public TurnOverPrizeOpenViewController _003C_003E4__this;

		[Token(Token = "0x170009A5")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6004768")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170009A6")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600476A")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6004765")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CyPlayResult_003Ed__23(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6004766")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6004767")]
		[Address(RVA = "0x915E70", Offset = "0x915070", VA = "0x180915E70", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6004769")]
		[Address(RVA = "0x915FC0", Offset = "0x9151C0", VA = "0x180915FC0", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x2000BBA")]
	[CompilerGenerated]
	private sealed class _003CyPlayShuffle_003Ed__21 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40097DF")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x40097E0")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x40097E1")]
		[FieldOffset(Offset = "0x20")]
		public TurnOverPrizeOpenViewController _003C_003E4__this;

		[Token(Token = "0x170009A7")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x600476E")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170009A8")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6004770")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600476B")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CyPlayShuffle_003Ed__21(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x600476C")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x600476D")]
		[Address(RVA = "0x9161C0", Offset = "0x9153C0", VA = "0x1809161C0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600476F")]
		[Address(RVA = "0x9162C0", Offset = "0x9154C0", VA = "0x1809162C0", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x2000BBB")]
	[CompilerGenerated]
	private sealed class _003CySelectPrize_003Ed__22 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40097E2")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x40097E3")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x40097E4")]
		[FieldOffset(Offset = "0x20")]
		public TurnOverPrizeOpenViewController _003C_003E4__this;

		[Token(Token = "0x40097E5")]
		[FieldOffset(Offset = "0x28")]
		private _003C_003Ec__DisplayClass22_0 _003C_003E8__1;

		[Token(Token = "0x170009A9")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6004774")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170009AA")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6004776")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6004771")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CySelectPrize_003Ed__22(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6004772")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6004773")]
		[Address(RVA = "0x916490", Offset = "0x915690", VA = "0x180916490", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6004775")]
		[Address(RVA = "0x916F40", Offset = "0x916140", VA = "0x180916F40", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x40097C0")]
	private const string k_VCPath = "Prize/TurnOverPrize/TurnOverPrizeOpen";

	[Token(Token = "0x40097C1")]
	private const string k_SECategory = "SE_ANNIV";

	[Token(Token = "0x40097C2")]
	private const string k_ArgKeyPrizeId = "prizeId";

	[Token(Token = "0x40097C3")]
	internal const string k_ArgKeyPurchaseHandler = "priceContext";

	[Token(Token = "0x40097C4")]
	[FieldOffset(Offset = "0xD0")]
	private bool m_BeforePostProcessing;

	[Token(Token = "0x40097C5")]
	[FieldOffset(Offset = "0xD8")]
	private ShopPurchase.PurchaseHandler m_PurchaseHandler;

	[Token(Token = "0x40097C6")]
	[FieldOffset(Offset = "0xE0")]
	private string m_CoverPath;

	[Token(Token = "0x40097C7")]
	[FieldOffset(Offset = "0xE8")]
	private List<object> m_PrizeDatas;

	[Token(Token = "0x40097C8")]
	[FieldOffset(Offset = "0xF0")]
	private List<string> m_LoadedAssetsPath;

	[Token(Token = "0x40097C9")]
	[FieldOffset(Offset = "0xF8")]
	private GameObject m_Root3D;

	[Token(Token = "0x40097CA")]
	[FieldOffset(Offset = "0x100")]
	private ActorRoot m_ActorRoot;

	[Token(Token = "0x40097CB")]
	[FieldOffset(Offset = "0x108")]
	private int m_DecidedIdx;

	[Token(Token = "0x170009A2")]
	protected override Type[] textIds
	{
		[Token(Token = "0x6004740")]
		[Address(RVA = "0x9117A0", Offset = "0x9109A0", VA = "0x1809117A0", Slot = "21")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6004741")]
	[Address(RVA = "0x9101B0", Offset = "0x90F3B0", VA = "0x1809101B0")]
	public static void Open(int prizeId, ShopPurchase.PurchaseHandler purchaseHandler, Dictionary<string, object> args)
	{
	}

	[Token(Token = "0x6004742")]
	[Address(RVA = "0x90F880", Offset = "0x90EA80", VA = "0x18090F880", Slot = "6")]
	public override void NotificationStackEntry()
	{
	}

	[Token(Token = "0x6004743")]
	[Address(RVA = "0x90FEF0", Offset = "0x90F0F0", VA = "0x18090FEF0", Slot = "23")]
	protected override void OnCreatedView()
	{
	}

	[Token(Token = "0x6004744")]
	[Address(RVA = "0x9111F0", Offset = "0x9103F0", VA = "0x1809111F0")]
	private void Start()
	{
	}

	[Token(Token = "0x6004745")]
	[Address(RVA = "0x90FE20", Offset = "0x90F020", VA = "0x18090FE20", Slot = "7")]
	public override void NotificationStackRemove()
	{
	}

	[Token(Token = "0x6004746")]
	[Address(RVA = "0x910030", Offset = "0x90F230", VA = "0x180910030")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6004747")]
	[Address(RVA = "0x9119A0", Offset = "0x910BA0", VA = "0x1809119A0")]
	[IteratorStateMachine(typeof(_003CyMainRoutine_003Ed__20))]
	private IEnumerator yMainRoutine()
	{
		return null;
	}

	[Token(Token = "0x6004748")]
	[Address(RVA = "0x911A80", Offset = "0x910C80", VA = "0x180911A80")]
	[IteratorStateMachine(typeof(_003CyPlayShuffle_003Ed__21))]
	private IEnumerator yPlayShuffle()
	{
		return null;
	}

	[Token(Token = "0x6004749")]
	[Address(RVA = "0x911AF0", Offset = "0x910CF0", VA = "0x180911AF0")]
	[IteratorStateMachine(typeof(_003CySelectPrize_003Ed__22))]
	private IEnumerator ySelectPrize()
	{
		return null;
	}

	[Token(Token = "0x600474A")]
	[Address(RVA = "0x911A10", Offset = "0x910C10", VA = "0x180911A10")]
	[IteratorStateMachine(typeof(_003CyPlayResult_003Ed__23))]
	private IEnumerator yPlayResult()
	{
		return null;
	}

	[Token(Token = "0x600474B")]
	[Address(RVA = "0x9102E0", Offset = "0x90F4E0", VA = "0x1809102E0")]
	private void SetAllPrizes(bool setArrowVisible = false)
	{
	}

	[Token(Token = "0x600474C")]
	[Address(RVA = "0x9105E0", Offset = "0x90F7E0", VA = "0x1809105E0")]
	private void SetPrizeByPos(int pos, bool setArrowVisible = false)
	{
	}

	[Token(Token = "0x600474D")]
	[Address(RVA = "0x910E80", Offset = "0x910080", VA = "0x180910E80")]
	private void SetPrizesAsBeforeSuffle()
	{
	}

	[Token(Token = "0x600474E")]
	[Address(RVA = "0x910AB0", Offset = "0x90FCB0", VA = "0x180910AB0")]
	private void SetPrizeOnUnlock(int idx)
	{
	}

	[Token(Token = "0x600474F")]
	[Address(RVA = "0x911720", Offset = "0x910920", VA = "0x180911720")]
	public TurnOverPrizeOpenViewController()
	{
	}
}
