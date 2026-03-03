using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using YgomSystem.ElementSystem;

namespace YgomGame.Tdy;

[Token(Token = "0x200083E")]
public class TdyCompleteKizunaCutInViewController : TdyCutInViewController
{
	[Token(Token = "0x200083F")]
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass10_0
	{
		[Token(Token = "0x400859A")]
		[FieldOffset(Offset = "0x10")]
		public bool wait_dialog;

		[Token(Token = "0x6003248")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public _003C_003Ec__DisplayClass10_0()
		{
		}

		[Token(Token = "0x6003249")]
		[Address(RVA = "0x75BCB0", Offset = "0x75AEB0", VA = "0x18075BCB0")]
		internal void _003CwaitForConfirmationDialogs_003Eb__0()
		{
		}
	}

	[Token(Token = "0x2000840")]
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass9_0
	{
		[Token(Token = "0x400859B")]
		[FieldOffset(Offset = "0x10")]
		public MeshRenderer renderer;

		[Token(Token = "0x400859C")]
		[FieldOffset(Offset = "0x18")]
		public bool wait_renderer;

		[Token(Token = "0x600324A")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public _003C_003Ec__DisplayClass9_0()
		{
		}

		[Token(Token = "0x600324B")]
		[Address(RVA = "0x75CD50", Offset = "0x75BF50", VA = "0x18075CD50")]
		internal void _003CpostProcessTimelineLoad_003Eb__0()
		{
		}
	}

	[Token(Token = "0x2000841")]
	[CompilerGenerated]
	private sealed class _003CpostProcessTimelineLoad_003Ed__9 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400859D")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400859E")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400859F")]
		[FieldOffset(Offset = "0x20")]
		public TdyCompleteKizunaCutInViewController _003C_003E4__this;

		[Token(Token = "0x40085A0")]
		[FieldOffset(Offset = "0x28")]
		private _003C_003Ec__DisplayClass9_0 _003C_003E8__1;

		[Token(Token = "0x40085A1")]
		[FieldOffset(Offset = "0x30")]
		public ElementObjectManager eom;

		[Token(Token = "0x1700063C")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x600324F")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700063D")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6003251")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600324C")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CpostProcessTimelineLoad_003Ed__9(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x600324D")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x600324E")]
		[Address(RVA = "0x75D750", Offset = "0x75C950", VA = "0x18075D750", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6003250")]
		[Address(RVA = "0x75D9D0", Offset = "0x75CBD0", VA = "0x18075D9D0", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x2000842")]
	[CompilerGenerated]
	private sealed class _003CwaitForConfirmationDialogs_003Ed__10 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40085A2")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x40085A3")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x40085A4")]
		[FieldOffset(Offset = "0x20")]
		public TdyCompleteKizunaCutInViewController _003C_003E4__this;

		[Token(Token = "0x40085A5")]
		[FieldOffset(Offset = "0x28")]
		private _003C_003Ec__DisplayClass10_0 _003C_003E8__1;

		[Token(Token = "0x1700063E")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6003255")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700063F")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6003257")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6003252")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CwaitForConfirmationDialogs_003Ed__10(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6003253")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6003254")]
		[Address(RVA = "0x75DF50", Offset = "0x75D150", VA = "0x18075DF50", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6003256")]
		[Address(RVA = "0x75E160", Offset = "0x75D360", VA = "0x18075E160", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x4008596")]
	[FieldOffset(Offset = "0x110")]
	private List<RewardDialogData> m_rewardDatas;

	[Token(Token = "0x4008597")]
	[FieldOffset(Offset = "0x118")]
	private Action m_finishCallback;

	[Token(Token = "0x4008598")]
	[FieldOffset(Offset = "0x120")]
	private int m_rewardCardMrk;

	[Token(Token = "0x4008599")]
	[FieldOffset(Offset = "0x124")]
	private int m_rewardCardStyle;

	[Token(Token = "0x1700063B")]
	protected override Type[] textIds
	{
		[Token(Token = "0x6003240")]
		[Address(RVA = "0x754C80", Offset = "0x753E80", VA = "0x180754C80", Slot = "21")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6003241")]
	[Address(RVA = "0x754D90", Offset = "0x753F90", VA = "0x180754D90", Slot = "28")]
	protected override void onStackEntry()
	{
	}

	[Token(Token = "0x6003242")]
	[Address(RVA = "0x754B80", Offset = "0x753D80", VA = "0x180754B80", Slot = "29")]
	protected override PlayEffectDesc getPlayDesc()
	{
		return null;
	}

	[Token(Token = "0x6003243")]
	[Address(RVA = "0x754C50", Offset = "0x753E50", VA = "0x180754C50", Slot = "30")]
	protected override string getTimelinePrefabPath()
	{
		return null;
	}

	[Token(Token = "0x6003244")]
	[Address(RVA = "0x754F40", Offset = "0x754140", VA = "0x180754F40", Slot = "31")]
	[IteratorStateMachine(typeof(_003CpostProcessTimelineLoad_003Ed__9))]
	protected override IEnumerator postProcessTimelineLoad(ElementObjectManager eom)
	{
		return null;
	}

	[Token(Token = "0x6003245")]
	[Address(RVA = "0x754FD0", Offset = "0x7541D0", VA = "0x180754FD0", Slot = "33")]
	[IteratorStateMachine(typeof(_003CwaitForConfirmationDialogs_003Ed__10))]
	protected override IEnumerator waitForConfirmationDialogs()
	{
		return null;
	}

	[Token(Token = "0x6003246")]
	[Address(RVA = "0x754D50", Offset = "0x753F50", VA = "0x180754D50", Slot = "34")]
	protected override void onEnd()
	{
	}

	[Token(Token = "0x6003247")]
	[Address(RVA = "0x3E3340", Offset = "0x3E2540", VA = "0x1803E3340")]
	public TdyCompleteKizunaCutInViewController()
	{
	}
}
