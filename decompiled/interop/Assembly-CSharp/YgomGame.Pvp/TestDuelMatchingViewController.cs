using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using YgomGame.Menu;
using YgomSystem.YGomTMPro;

namespace YgomGame.Pvp;

[Token(Token = "0x2001741")]
public class TestDuelMatchingViewController : BaseMenuViewController
{
	[Token(Token = "0x2001742")]
	public enum View
	{
		[Token(Token = "0x400DB4F")]
		SEARCHING,
		[Token(Token = "0x400DB50")]
		MATCHING,
		[Token(Token = "0x400DB51")]
		TIMEOUT
	}

	[Token(Token = "0x2001743")]
	[CompilerGenerated]
	private sealed class _003CStart_003Ed__22 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400DB52")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400DB53")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400DB54")]
		[FieldOffset(Offset = "0x20")]
		public TestDuelMatchingViewController _003C_003E4__this;

		[Token(Token = "0x1700165D")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x60091DC")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700165E")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60091DE")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60091D9")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CStart_003Ed__22(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x60091DA")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x60091DB")]
		[Address(RVA = "0xDD6800", Offset = "0xDD5A00", VA = "0x180DD6800", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60091DD")]
		[Address(RVA = "0xDD68E0", Offset = "0xDD5AE0", VA = "0x180DD68E0", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x2001744")]
	[CompilerGenerated]
	private sealed class _003CyInit_003Ed__20 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400DB55")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400DB56")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400DB57")]
		[FieldOffset(Offset = "0x20")]
		public TestDuelMatchingViewController _003C_003E4__this;

		[Token(Token = "0x1700165F")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x60091E2")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17001660")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60091E4")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60091DF")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CyInit_003Ed__20(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x60091E0")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x60091E1")]
		[Address(RVA = "0xDD7A80", Offset = "0xDD6C80", VA = "0x180DD7A80", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60091E3")]
		[Address(RVA = "0xDD7BC0", Offset = "0xDD6DC0", VA = "0x180DD7BC0", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x2001745")]
	[CompilerGenerated]
	private sealed class _003CyMatch_003Ed__21 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400DB58")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400DB59")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400DB5A")]
		[FieldOffset(Offset = "0x20")]
		public TestDuelMatchingViewController _003C_003E4__this;

		[Token(Token = "0x400DB5B")]
		[FieldOffset(Offset = "0x28")]
		private int _003Ci_003E5__2;

		[Token(Token = "0x17001661")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x60091E8")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17001662")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60091EA")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60091E5")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CyMatch_003Ed__21(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x60091E6")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x60091E7")]
		[Address(RVA = "0xDD7C00", Offset = "0xDD6E00", VA = "0x180DD7C00", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60091E9")]
		[Address(RVA = "0xDD7E40", Offset = "0xDD7040", VA = "0x180DD7E40", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x400DB3F")]
	[FieldOffset(Offset = "0xD0")]
	[SerializeField]
	private GameObject DuelStartPrefab;

	[Token(Token = "0x400DB40")]
	[FieldOffset(Offset = "0xD8")]
	private readonly string BTN_CANCEL_LABEL;

	[Token(Token = "0x400DB41")]
	[FieldOffset(Offset = "0xE0")]
	private readonly string BTN_BACK_LABEL;

	[Token(Token = "0x400DB42")]
	[FieldOffset(Offset = "0xE8")]
	private readonly string TXT_TIME_LABEL;

	[Token(Token = "0x400DB43")]
	[FieldOffset(Offset = "0xF0")]
	private readonly string ROOT_SEARCH_LABEL;

	[Token(Token = "0x400DB44")]
	[FieldOffset(Offset = "0xF8")]
	private readonly string ROOT_MATCH_LABEL;

	[Token(Token = "0x400DB45")]
	[FieldOffset(Offset = "0x100")]
	private readonly string ROOT_TIMEOUT_LABEL;

	[Token(Token = "0x400DB46")]
	[FieldOffset(Offset = "0x108")]
	private readonly string IMG_ICON_LABEL;

	[Token(Token = "0x400DB47")]
	[FieldOffset(Offset = "0x110")]
	private readonly int RESEARCH_TIME;

	[Token(Token = "0x400DB48")]
	[FieldOffset(Offset = "0x118")]
	private ExtendedTextMeshProUGUI m_TextTime;

	[Token(Token = "0x400DB49")]
	[FieldOffset(Offset = "0x120")]
	private int m_ElapsedTime;

	[Token(Token = "0x400DB4A")]
	[FieldOffset(Offset = "0x128")]
	private GameObject m_rootSearch;

	[Token(Token = "0x400DB4B")]
	[FieldOffset(Offset = "0x130")]
	private GameObject m_rootMatch;

	[Token(Token = "0x400DB4C")]
	[FieldOffset(Offset = "0x138")]
	private GameObject m_rootTimeout;

	[Token(Token = "0x400DB4D")]
	[FieldOffset(Offset = "0x140")]
	private View m_currentView;

	[Token(Token = "0x60091D1")]
	[Address(RVA = "0x540540", Offset = "0x53F740", VA = "0x180540540", Slot = "6")]
	public override void NotificationStackEntry()
	{
	}

	[Token(Token = "0x60091D2")]
	[Address(RVA = "0xDD5F00", Offset = "0xDD5100", VA = "0x180DD5F00", Slot = "23")]
	protected override void OnCreatedView()
	{
	}

	[Token(Token = "0x60091D3")]
	[Address(RVA = "0xDD61E0", Offset = "0xDD53E0", VA = "0x180DD61E0")]
	private void SetActiveView(View state)
	{
	}

	[Token(Token = "0x60091D4")]
	[Address(RVA = "0xDD5E00", Offset = "0xDD5000", VA = "0x180DD5E00")]
	private string ConvertDispTime(int time)
	{
		return null;
	}

	[Token(Token = "0x60091D5")]
	[Address(RVA = "0xDD6440", Offset = "0xDD5640", VA = "0x180DD6440")]
	[IteratorStateMachine(typeof(_003CyInit_003Ed__20))]
	private IEnumerator yInit()
	{
		return null;
	}

	[Token(Token = "0x60091D6")]
	[Address(RVA = "0xDD64B0", Offset = "0xDD56B0", VA = "0x180DD64B0")]
	[IteratorStateMachine(typeof(_003CyMatch_003Ed__21))]
	private IEnumerator yMatch()
	{
		return null;
	}

	[Token(Token = "0x60091D7")]
	[Address(RVA = "0xDD6260", Offset = "0xDD5460", VA = "0x180DD6260")]
	[IteratorStateMachine(typeof(_003CStart_003Ed__22))]
	private IEnumerator Start()
	{
		return null;
	}

	[Token(Token = "0x60091D8")]
	[Address(RVA = "0xDD62D0", Offset = "0xDD54D0", VA = "0x180DD62D0")]
	public TestDuelMatchingViewController()
	{
	}
}
