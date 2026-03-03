using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using YgomGame.Colosseum;

namespace YgomGame.Home.PlayMenuJumpInternal;

[Token(Token = "0x2000D84")]
public class WCSMenuJumper : PlayMenuJumperBase
{
	[Token(Token = "0x2000D85")]
	[CompilerGenerated]
	private sealed class _003CcheckCoroutine_003Ed__7 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4009F1C")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4009F1D")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4009F1E")]
		[FieldOffset(Offset = "0x20")]
		public WCSMenuJumper _003C_003E4__this;

		[Token(Token = "0x4009F1F")]
		[FieldOffset(Offset = "0x28")]
		public Action<bool> callback;

		[Token(Token = "0x4009F20")]
		[FieldOffset(Offset = "0x30")]
		private bool _003Cis_success_003E5__2;

		[Token(Token = "0x17000BC7")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6005151")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000BC8")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6005153")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600514E")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CcheckCoroutine_003Ed__7(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x600514F")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6005150")]
		[Address(RVA = "0x999240", Offset = "0x998440", VA = "0x180999240", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6005152")]
		[Address(RVA = "0x999D70", Offset = "0x998F70", VA = "0x180999D70", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x4009F1B")]
	[FieldOffset(Offset = "0x10")]
	private int m_wcsID;

	[Token(Token = "0x17000BC5")]
	protected override ColosseumUtil.PlayMode playMode
	{
		[Token(Token = "0x6005148")]
		[Address(RVA = "0x578DC0", Offset = "0x577FC0", VA = "0x180578DC0", Slot = "4")]
		get
		{
			return default(ColosseumUtil.PlayMode);
		}
	}

	[Token(Token = "0x17000BC6")]
	protected override string prefabPath
	{
		[Token(Token = "0x6005149")]
		[Address(RVA = "0x99BFE0", Offset = "0x99B1E0", VA = "0x18099BFE0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600514A")]
	[Address(RVA = "0x99BEC0", Offset = "0x99B0C0", VA = "0x18099BEC0", Slot = "6")]
	protected override void ExtendArgs(ref Dictionary<string, object> args)
	{
	}

	[Token(Token = "0x600514B")]
	[Address(RVA = "0x99BE30", Offset = "0x99B030", VA = "0x18099BE30", Slot = "7")]
	public override void Check(Action<bool> resultCallback)
	{
	}

	[Token(Token = "0x600514C")]
	[Address(RVA = "0x99BF50", Offset = "0x99B150", VA = "0x18099BF50")]
	[IteratorStateMachine(typeof(_003CcheckCoroutine_003Ed__7))]
	private IEnumerator checkCoroutine(Action<bool> callback)
	{
		return null;
	}

	[Token(Token = "0x600514D")]
	[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
	public WCSMenuJumper()
	{
	}
}
