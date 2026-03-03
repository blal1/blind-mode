using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using YgomGame.Colosseum;

namespace YgomGame.Home.PlayMenuJumpInternal;

[Token(Token = "0x2000D8C")]
public class DiceRallyMenuJumper : PlayMenuJumperBase
{
	[Token(Token = "0x2000D8D")]
	[CompilerGenerated]
	private sealed class _003CcheckCoroutine_003Ed__8 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4009F32")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4009F33")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4009F34")]
		[FieldOffset(Offset = "0x20")]
		public DiceRallyMenuJumper _003C_003E4__this;

		[Token(Token = "0x4009F35")]
		[FieldOffset(Offset = "0x28")]
		public Action<bool> callback;

		[Token(Token = "0x17000BD7")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6005181")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000BD8")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6005183")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600517E")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CcheckCoroutine_003Ed__8(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x600517F")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6005180")]
		[Address(RVA = "0x999DB0", Offset = "0x998FB0", VA = "0x180999DB0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6005182")]
		[Address(RVA = "0x99A720", Offset = "0x999920", VA = "0x18099A720", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x4009F31")]
	[FieldOffset(Offset = "0x10")]
	private int m_eventID;

	[Token(Token = "0x17000BD5")]
	protected override ColosseumUtil.PlayMode playMode
	{
		[Token(Token = "0x6005178")]
		[Address(RVA = "0x572CB0", Offset = "0x571EB0", VA = "0x180572CB0", Slot = "4")]
		get
		{
			return default(ColosseumUtil.PlayMode);
		}
	}

	[Token(Token = "0x17000BD6")]
	protected override string prefabPath
	{
		[Token(Token = "0x6005179")]
		[Address(RVA = "0x97E990", Offset = "0x97DB90", VA = "0x18097E990", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600517A")]
	[Address(RVA = "0x97E870", Offset = "0x97DA70", VA = "0x18097E870", Slot = "6")]
	protected override void ExtendArgs(ref Dictionary<string, object> args)
	{
	}

	[Token(Token = "0x600517B")]
	[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
	public DiceRallyMenuJumper(int eventID)
	{
	}

	[Token(Token = "0x600517C")]
	[Address(RVA = "0x97E7E0", Offset = "0x97D9E0", VA = "0x18097E7E0", Slot = "7")]
	public override void Check(Action<bool> resultCallback)
	{
	}

	[Token(Token = "0x600517D")]
	[Address(RVA = "0x97E900", Offset = "0x97DB00", VA = "0x18097E900")]
	[IteratorStateMachine(typeof(_003CcheckCoroutine_003Ed__8))]
	private IEnumerator checkCoroutine(Action<bool> callback)
	{
		return null;
	}
}
