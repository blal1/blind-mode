using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using YgomSystem.ElementSystem;

namespace YgomGame.Tdy;

[Token(Token = "0x200084C")]
public class TdyGetKizunaCutInViewController : TdyCutInViewController
{
	[Token(Token = "0x200084E")]
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass9_0
	{
		[Token(Token = "0x40085CF")]
		[FieldOffset(Offset = "0x10")]
		public bool wait_dialog;

		[Token(Token = "0x600329D")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public _003C_003Ec__DisplayClass9_0()
		{
		}

		[Token(Token = "0x600329E")]
		[Address(RVA = "0x75BCB0", Offset = "0x75AEB0", VA = "0x18075BCB0")]
		internal void _003CwaitForConfirmationDialogs_003Eb__0()
		{
		}
	}

	[Token(Token = "0x200084F")]
	[CompilerGenerated]
	private sealed class _003CwaitForConfirmationDialogs_003Ed__9 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40085D0")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x40085D1")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x40085D2")]
		[FieldOffset(Offset = "0x20")]
		public TdyGetKizunaCutInViewController _003C_003E4__this;

		[Token(Token = "0x40085D3")]
		[FieldOffset(Offset = "0x28")]
		private _003C_003Ec__DisplayClass9_0 _003C_003E8__1;

		[Token(Token = "0x1700064C")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x60032A2")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700064D")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60032A4")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600329F")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CwaitForConfirmationDialogs_003Ed__9(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x60032A0")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x60032A1")]
		[Address(RVA = "0x75E420", Offset = "0x75D620", VA = "0x18075E420", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60032A3")]
		[Address(RVA = "0x75E630", Offset = "0x75D830", VA = "0x18075E630", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x40085CA")]
	[FieldOffset(Offset = "0x110")]
	private PlayEffectDesc m_eff;

	[Token(Token = "0x40085CB")]
	[FieldOffset(Offset = "0x118")]
	private Action m_finishCallback;

	[Token(Token = "0x40085CC")]
	[FieldOffset(Offset = "0x120")]
	private List<RewardDialogData> m_rewardDatas;

	[Token(Token = "0x1700064B")]
	protected override Type[] textIds
	{
		[Token(Token = "0x6003293")]
		[Address(RVA = "0x755E10", Offset = "0x755010", VA = "0x180755E10", Slot = "21")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6003294")]
	[Address(RVA = "0x755EE0", Offset = "0x7550E0", VA = "0x180755EE0", Slot = "28")]
	protected override void onStackEntry()
	{
	}

	[Token(Token = "0x6003295")]
	[Address(RVA = "0x3DA790", Offset = "0x3D9990", VA = "0x1803DA790", Slot = "29")]
	protected override PlayEffectDesc getPlayDesc()
	{
		return null;
	}

	[Token(Token = "0x6003296")]
	[Address(RVA = "0x755D70", Offset = "0x754F70", VA = "0x180755D70", Slot = "30")]
	protected override string getTimelinePrefabPath()
	{
		return null;
	}

	[Token(Token = "0x6003297")]
	[Address(RVA = "0x755F80", Offset = "0x755180", VA = "0x180755F80", Slot = "32")]
	protected override void onTimelineLoadFinish(ElementObjectManager eom)
	{
	}

	[Token(Token = "0x6003298")]
	[Address(RVA = "0x756090", Offset = "0x755290", VA = "0x180756090", Slot = "33")]
	[IteratorStateMachine(typeof(_003CwaitForConfirmationDialogs_003Ed__9))]
	protected override IEnumerator waitForConfirmationDialogs()
	{
		return null;
	}

	[Token(Token = "0x6003299")]
	[Address(RVA = "0x754D50", Offset = "0x753F50", VA = "0x180754D50", Slot = "34")]
	protected override void onEnd()
	{
	}

	[Token(Token = "0x600329A")]
	[Address(RVA = "0x3E3340", Offset = "0x3E2540", VA = "0x1803E3340")]
	public TdyGetKizunaCutInViewController()
	{
	}
}
