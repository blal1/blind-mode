using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using YgomSystem.ElementSystem;

namespace YgomGame.Tdy;

[Token(Token = "0x2000839")]
public class TdyChainCutInViewController : TdyCutInViewController
{
	[Token(Token = "0x200083B")]
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass8_0
	{
		[Token(Token = "0x400858F")]
		[FieldOffset(Offset = "0x10")]
		public bool wait_dialog;

		[Token(Token = "0x6003237")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public _003C_003Ec__DisplayClass8_0()
		{
		}

		[Token(Token = "0x6003238")]
		[Address(RVA = "0x75BCB0", Offset = "0x75AEB0", VA = "0x18075BCB0")]
		internal void _003CwaitForConfirmationDialogs_003Eb__0()
		{
		}
	}

	[Token(Token = "0x200083C")]
	[CompilerGenerated]
	private sealed class _003CwaitForConfirmationDialogs_003Ed__8 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4008590")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4008591")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4008592")]
		[FieldOffset(Offset = "0x20")]
		public TdyChainCutInViewController _003C_003E4__this;

		[Token(Token = "0x4008593")]
		[FieldOffset(Offset = "0x28")]
		private _003C_003Ec__DisplayClass8_0 _003C_003E8__1;

		[Token(Token = "0x17000639")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x600323C")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700063A")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600323E")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6003239")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CwaitForConfirmationDialogs_003Ed__8(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x600323A")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x600323B")]
		[Address(RVA = "0x75E1A0", Offset = "0x75D3A0", VA = "0x18075E1A0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600323D")]
		[Address(RVA = "0x75E3E0", Offset = "0x75D5E0", VA = "0x18075E3E0", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x400858A")]
	[FieldOffset(Offset = "0x110")]
	private Queue<PlayEffectDesc> m_playQueue;

	[Token(Token = "0x400858B")]
	[FieldOffset(Offset = "0x118")]
	private Action m_finishCallback;

	[Token(Token = "0x17000638")]
	protected override Type[] textIds
	{
		[Token(Token = "0x600322D")]
		[Address(RVA = "0x7546B0", Offset = "0x7538B0", VA = "0x1807546B0", Slot = "21")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600322E")]
	[Address(RVA = "0x7548F0", Offset = "0x753AF0", VA = "0x1807548F0", Slot = "28")]
	protected override void onStackEntry()
	{
	}

	[Token(Token = "0x600322F")]
	[Address(RVA = "0x7545C0", Offset = "0x7537C0", VA = "0x1807545C0", Slot = "29")]
	protected override PlayEffectDesc getPlayDesc()
	{
		return null;
	}

	[Token(Token = "0x6003230")]
	[Address(RVA = "0x754610", Offset = "0x753810", VA = "0x180754610", Slot = "30")]
	protected override string getTimelinePrefabPath()
	{
		return null;
	}

	[Token(Token = "0x6003231")]
	[Address(RVA = "0x754970", Offset = "0x753B70", VA = "0x180754970", Slot = "32")]
	protected override void onTimelineLoadFinish(ElementObjectManager eom)
	{
	}

	[Token(Token = "0x6003232")]
	[Address(RVA = "0x754B10", Offset = "0x753D10", VA = "0x180754B10", Slot = "33")]
	[IteratorStateMachine(typeof(_003CwaitForConfirmationDialogs_003Ed__8))]
	protected override IEnumerator waitForConfirmationDialogs()
	{
		return null;
	}

	[Token(Token = "0x6003233")]
	[Address(RVA = "0x754780", Offset = "0x753980", VA = "0x180754780", Slot = "34")]
	protected override void onEnd()
	{
	}

	[Token(Token = "0x6003234")]
	[Address(RVA = "0x3E3340", Offset = "0x3E2540", VA = "0x1803E3340")]
	public TdyChainCutInViewController()
	{
	}
}
