using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using YgomGame.Colosseum;

namespace YgomGame.Home.PlayMenuJumpInternal;

[Token(Token = "0x2000D7B")]
public class RateMenuJumper : PlayMenuJumperBase
{
	[Token(Token = "0x2000D7C")]
	[CompilerGenerated]
	private sealed class _003CcheckCoroutine_003Ed__5 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4009F00")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4009F01")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4009F02")]
		[FieldOffset(Offset = "0x20")]
		public Action<bool> callback;

		[Token(Token = "0x17000BB7")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x600511E")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000BB8")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6005120")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600511B")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CcheckCoroutine_003Ed__5(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x600511C")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x600511D")]
		[Address(RVA = "0x998C40", Offset = "0x997E40", VA = "0x180998C40", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600511F")]
		[Address(RVA = "0x999200", Offset = "0x998400", VA = "0x180999200", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x17000BB5")]
	protected override ColosseumUtil.PlayMode playMode
	{
		[Token(Token = "0x6005116")]
		[Address(RVA = "0x937680", Offset = "0x936880", VA = "0x180937680", Slot = "4")]
		get
		{
			return default(ColosseumUtil.PlayMode);
		}
	}

	[Token(Token = "0x17000BB6")]
	protected override string prefabPath
	{
		[Token(Token = "0x6005117")]
		[Address(RVA = "0x995CB0", Offset = "0x994EB0", VA = "0x180995CB0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6005118")]
	[Address(RVA = "0x995BD0", Offset = "0x994DD0", VA = "0x180995BD0", Slot = "7")]
	public override void Check(Action<bool> resultCallback)
	{
	}

	[Token(Token = "0x6005119")]
	[Address(RVA = "0x995C40", Offset = "0x994E40", VA = "0x180995C40")]
	[IteratorStateMachine(typeof(_003CcheckCoroutine_003Ed__5))]
	private IEnumerator checkCoroutine(Action<bool> callback)
	{
		return null;
	}

	[Token(Token = "0x600511A")]
	[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
	public RateMenuJumper()
	{
	}
}
