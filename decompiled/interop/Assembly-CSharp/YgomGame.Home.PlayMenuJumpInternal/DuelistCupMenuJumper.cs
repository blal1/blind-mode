using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using YgomGame.Colosseum;

namespace YgomGame.Home.PlayMenuJumpInternal;

[Token(Token = "0x2000D82")]
public class DuelistCupMenuJumper : PlayMenuJumperBase
{
	[Token(Token = "0x2000D83")]
	[CompilerGenerated]
	private sealed class _003CcheckCoroutine_003Ed__7 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4009F16")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4009F17")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4009F18")]
		[FieldOffset(Offset = "0x20")]
		public DuelistCupMenuJumper _003C_003E4__this;

		[Token(Token = "0x4009F19")]
		[FieldOffset(Offset = "0x28")]
		public Action<bool> callback;

		[Token(Token = "0x4009F1A")]
		[FieldOffset(Offset = "0x30")]
		private bool _003Cis_success_003E5__2;

		[Token(Token = "0x17000BC3")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6005145")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000BC4")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6005147")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6005142")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CcheckCoroutine_003Ed__7(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6005143")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6005144")]
		[Address(RVA = "0x9995D0", Offset = "0x9987D0", VA = "0x1809995D0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6005146")]
		[Address(RVA = "0x999D30", Offset = "0x998F30", VA = "0x180999D30", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x4009F15")]
	[FieldOffset(Offset = "0x10")]
	private int m_cupID;

	[Token(Token = "0x17000BC1")]
	protected override ColosseumUtil.PlayMode playMode
	{
		[Token(Token = "0x600513C")]
		[Address(RVA = "0x443230", Offset = "0x442430", VA = "0x180443230", Slot = "4")]
		get
		{
			return default(ColosseumUtil.PlayMode);
		}
	}

	[Token(Token = "0x17000BC2")]
	protected override string prefabPath
	{
		[Token(Token = "0x600513D")]
		[Address(RVA = "0x97ED50", Offset = "0x97DF50", VA = "0x18097ED50", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600513E")]
	[Address(RVA = "0x97EC30", Offset = "0x97DE30", VA = "0x18097EC30", Slot = "6")]
	protected override void ExtendArgs(ref Dictionary<string, object> args)
	{
	}

	[Token(Token = "0x600513F")]
	[Address(RVA = "0x97EBA0", Offset = "0x97DDA0", VA = "0x18097EBA0", Slot = "7")]
	public override void Check(Action<bool> resultCallback)
	{
	}

	[Token(Token = "0x6005140")]
	[Address(RVA = "0x97ECC0", Offset = "0x97DEC0", VA = "0x18097ECC0")]
	[IteratorStateMachine(typeof(_003CcheckCoroutine_003Ed__7))]
	private IEnumerator checkCoroutine(Action<bool> callback)
	{
		return null;
	}

	[Token(Token = "0x6005141")]
	[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
	public DuelistCupMenuJumper()
	{
	}
}
