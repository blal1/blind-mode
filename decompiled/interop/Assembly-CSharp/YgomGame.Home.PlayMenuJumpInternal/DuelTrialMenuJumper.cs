using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using YgomGame.Colosseum;

namespace YgomGame.Home.PlayMenuJumpInternal;

[Token(Token = "0x2000D86")]
public class DuelTrialMenuJumper : PlayMenuJumperBase
{
	[Token(Token = "0x2000D87")]
	[CompilerGenerated]
	private sealed class _003CcheckCoroutine_003Ed__8 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4009F22")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4009F23")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4009F24")]
		[FieldOffset(Offset = "0x20")]
		public DuelTrialMenuJumper _003C_003E4__this;

		[Token(Token = "0x4009F25")]
		[FieldOffset(Offset = "0x28")]
		public Action<bool> callback;

		[Token(Token = "0x17000BCB")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x600515D")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000BCC")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600515F")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600515A")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CcheckCoroutine_003Ed__8(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x600515B")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x600515C")]
		[Address(RVA = "0x999FE0", Offset = "0x9991E0", VA = "0x180999FE0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600515E")]
		[Address(RVA = "0x99A760", Offset = "0x999960", VA = "0x18099A760", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x4009F21")]
	[FieldOffset(Offset = "0x10")]
	private int m_eventID;

	[Token(Token = "0x17000BC9")]
	protected override ColosseumUtil.PlayMode playMode
	{
		[Token(Token = "0x6005154")]
		[Address(RVA = "0x573650", Offset = "0x572850", VA = "0x180573650", Slot = "4")]
		get
		{
			return default(ColosseumUtil.PlayMode);
		}
	}

	[Token(Token = "0x17000BCA")]
	protected override string prefabPath
	{
		[Token(Token = "0x6005155")]
		[Address(RVA = "0x97EB70", Offset = "0x97DD70", VA = "0x18097EB70", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6005156")]
	[Address(RVA = "0x97EA50", Offset = "0x97DC50", VA = "0x18097EA50", Slot = "6")]
	protected override void ExtendArgs(ref Dictionary<string, object> args)
	{
	}

	[Token(Token = "0x6005157")]
	[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
	public DuelTrialMenuJumper(int eventID)
	{
	}

	[Token(Token = "0x6005158")]
	[Address(RVA = "0x97E9C0", Offset = "0x97DBC0", VA = "0x18097E9C0", Slot = "7")]
	public override void Check(Action<bool> resultCallback)
	{
	}

	[Token(Token = "0x6005159")]
	[Address(RVA = "0x97EAE0", Offset = "0x97DCE0", VA = "0x18097EAE0")]
	[IteratorStateMachine(typeof(_003CcheckCoroutine_003Ed__8))]
	private IEnumerator checkCoroutine(Action<bool> callback)
	{
		return null;
	}
}
