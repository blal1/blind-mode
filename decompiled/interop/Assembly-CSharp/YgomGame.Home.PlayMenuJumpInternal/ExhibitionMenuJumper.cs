using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using YgomGame.Colosseum;

namespace YgomGame.Home.PlayMenuJumpInternal;

[Token(Token = "0x2000D7D")]
public class ExhibitionMenuJumper : PlayMenuJumperBase
{
	[Token(Token = "0x2000D7E")]
	[CompilerGenerated]
	private sealed class _003CcheckCoroutine_003Ed__8 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4009F04")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4009F05")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4009F06")]
		[FieldOffset(Offset = "0x20")]
		public ExhibitionMenuJumper _003C_003E4__this;

		[Token(Token = "0x4009F07")]
		[FieldOffset(Offset = "0x28")]
		public Action<bool> callback;

		[Token(Token = "0x17000BBB")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x600512A")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000BBC")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600512C")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6005127")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CcheckCoroutine_003Ed__8(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6005128")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6005129")]
		[Address(RVA = "0x99A470", Offset = "0x999670", VA = "0x18099A470", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600512B")]
		[Address(RVA = "0x99A6A0", Offset = "0x9998A0", VA = "0x18099A6A0", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x4009F03")]
	[FieldOffset(Offset = "0x10")]
	private int m_eventID;

	[Token(Token = "0x17000BB9")]
	protected override ColosseumUtil.PlayMode playMode
	{
		[Token(Token = "0x6005121")]
		[Address(RVA = "0x452710", Offset = "0x451910", VA = "0x180452710", Slot = "4")]
		get
		{
			return default(ColosseumUtil.PlayMode);
		}
	}

	[Token(Token = "0x17000BBA")]
	protected override string prefabPath
	{
		[Token(Token = "0x6005122")]
		[Address(RVA = "0x97F0E0", Offset = "0x97E2E0", VA = "0x18097F0E0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6005123")]
	[Address(RVA = "0x97EFC0", Offset = "0x97E1C0", VA = "0x18097EFC0", Slot = "6")]
	protected override void ExtendArgs(ref Dictionary<string, object> args)
	{
	}

	[Token(Token = "0x6005124")]
	[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
	public ExhibitionMenuJumper(int eventID)
	{
	}

	[Token(Token = "0x6005125")]
	[Address(RVA = "0x97EF30", Offset = "0x97E130", VA = "0x18097EF30", Slot = "7")]
	public override void Check(Action<bool> resultCallback)
	{
	}

	[Token(Token = "0x6005126")]
	[Address(RVA = "0x97F050", Offset = "0x97E250", VA = "0x18097F050")]
	[IteratorStateMachine(typeof(_003CcheckCoroutine_003Ed__8))]
	private IEnumerator checkCoroutine(Action<bool> callback)
	{
		return null;
	}
}
