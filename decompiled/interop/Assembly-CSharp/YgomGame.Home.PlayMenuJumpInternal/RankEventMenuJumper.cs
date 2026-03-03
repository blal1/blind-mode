using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using YgomGame.Colosseum;

namespace YgomGame.Home.PlayMenuJumpInternal;

[Token(Token = "0x2000D88")]
public class RankEventMenuJumper : PlayMenuJumperBase
{
	[Token(Token = "0x2000D89")]
	[CompilerGenerated]
	private sealed class _003CcheckCoroutine_003Ed__8 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4009F27")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4009F28")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4009F29")]
		[FieldOffset(Offset = "0x20")]
		public RankEventMenuJumper _003C_003E4__this;

		[Token(Token = "0x4009F2A")]
		[FieldOffset(Offset = "0x28")]
		public Action<bool> callback;

		[Token(Token = "0x17000BCF")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6005169")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000BD0")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600516B")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6005166")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CcheckCoroutine_003Ed__8(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6005167")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6005168")]
		[Address(RVA = "0x99A210", Offset = "0x999410", VA = "0x18099A210", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600516A")]
		[Address(RVA = "0x99A6E0", Offset = "0x9998E0", VA = "0x18099A6E0", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x4009F26")]
	[FieldOffset(Offset = "0x10")]
	private int m_eventID;

	[Token(Token = "0x17000BCD")]
	protected override ColosseumUtil.PlayMode playMode
	{
		[Token(Token = "0x6005160")]
		[Address(RVA = "0x549EC0", Offset = "0x5490C0", VA = "0x180549EC0", Slot = "4")]
		get
		{
			return default(ColosseumUtil.PlayMode);
		}
	}

	[Token(Token = "0x17000BCE")]
	protected override string prefabPath
	{
		[Token(Token = "0x6005161")]
		[Address(RVA = "0x995BA0", Offset = "0x994DA0", VA = "0x180995BA0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6005162")]
	[Address(RVA = "0x995A80", Offset = "0x994C80", VA = "0x180995A80", Slot = "6")]
	protected override void ExtendArgs(ref Dictionary<string, object> args)
	{
	}

	[Token(Token = "0x6005163")]
	[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
	public RankEventMenuJumper(int eventID)
	{
	}

	[Token(Token = "0x6005164")]
	[Address(RVA = "0x9959F0", Offset = "0x994BF0", VA = "0x1809959F0", Slot = "7")]
	public override void Check(Action<bool> resultCallback)
	{
	}

	[Token(Token = "0x6005165")]
	[Address(RVA = "0x995B10", Offset = "0x994D10", VA = "0x180995B10")]
	[IteratorStateMachine(typeof(_003CcheckCoroutine_003Ed__8))]
	private IEnumerator checkCoroutine(Action<bool> callback)
	{
		return null;
	}
}
