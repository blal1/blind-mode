using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using YgomGame.Colosseum;

namespace YgomGame.Home.PlayMenuJumpInternal;

[Token(Token = "0x2000D79")]
public class StandardMenuJumper : PlayMenuJumperBase
{
	[Token(Token = "0x2000D7A")]
	[CompilerGenerated]
	private sealed class _003CcheckCoroutine_003Ed__5 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4009EFD")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4009EFE")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4009EFF")]
		[FieldOffset(Offset = "0x20")]
		public Action<bool> callback;

		[Token(Token = "0x17000BB3")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6005113")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000BB4")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6005115")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6005110")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CcheckCoroutine_003Ed__5(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6005111")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6005112")]
		[Address(RVA = "0x998FB0", Offset = "0x9981B0", VA = "0x180998FB0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6005114")]
		[Address(RVA = "0x9991C0", Offset = "0x9983C0", VA = "0x1809991C0", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x17000BB1")]
	protected override ColosseumUtil.PlayMode playMode
	{
		[Token(Token = "0x600510B")]
		[Address(RVA = "0x4B8E10", Offset = "0x4B8010", VA = "0x1804B8E10", Slot = "4")]
		get
		{
			return default(ColosseumUtil.PlayMode);
		}
	}

	[Token(Token = "0x17000BB2")]
	protected override string prefabPath
	{
		[Token(Token = "0x600510C")]
		[Address(RVA = "0x996B50", Offset = "0x995D50", VA = "0x180996B50", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600510D")]
	[Address(RVA = "0x996A70", Offset = "0x995C70", VA = "0x180996A70", Slot = "7")]
	public override void Check(Action<bool> resultCallback)
	{
	}

	[Token(Token = "0x600510E")]
	[Address(RVA = "0x996AE0", Offset = "0x995CE0", VA = "0x180996AE0")]
	[IteratorStateMachine(typeof(_003CcheckCoroutine_003Ed__5))]
	private IEnumerator checkCoroutine(Action<bool> callback)
	{
		return null;
	}

	[Token(Token = "0x600510F")]
	[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
	public StandardMenuJumper()
	{
	}
}
