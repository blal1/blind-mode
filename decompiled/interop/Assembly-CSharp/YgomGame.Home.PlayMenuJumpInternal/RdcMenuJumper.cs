using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using YgomGame.Colosseum;

namespace YgomGame.Home.PlayMenuJumpInternal;

[Token(Token = "0x2000D8A")]
public class RdcMenuJumper : PlayMenuJumperBase
{
	[Token(Token = "0x2000D8B")]
	[CompilerGenerated]
	private sealed class _003CcheckCoroutine_003Ed__7 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4009F2C")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4009F2D")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4009F2E")]
		[FieldOffset(Offset = "0x20")]
		public RdcMenuJumper _003C_003E4__this;

		[Token(Token = "0x4009F2F")]
		[FieldOffset(Offset = "0x28")]
		public Action<bool> callback;

		[Token(Token = "0x4009F30")]
		[FieldOffset(Offset = "0x30")]
		private bool _003Cis_success_003E5__2;

		[Token(Token = "0x17000BD3")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6005175")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000BD4")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6005177")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6005172")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CcheckCoroutine_003Ed__7(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6005173")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6005174")]
		[Address(RVA = "0x999960", Offset = "0x998B60", VA = "0x180999960", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6005176")]
		[Address(RVA = "0x999CF0", Offset = "0x998EF0", VA = "0x180999CF0", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x4009F2B")]
	[FieldOffset(Offset = "0x10")]
	private int m_RdcId;

	[Token(Token = "0x17000BD1")]
	protected override ColosseumUtil.PlayMode playMode
	{
		[Token(Token = "0x600516C")]
		[Address(RVA = "0x575E00", Offset = "0x575000", VA = "0x180575E00", Slot = "4")]
		get
		{
			return default(ColosseumUtil.PlayMode);
		}
	}

	[Token(Token = "0x17000BD2")]
	protected override string prefabPath
	{
		[Token(Token = "0x600516D")]
		[Address(RVA = "0x995E90", Offset = "0x995090", VA = "0x180995E90", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600516E")]
	[Address(RVA = "0x995D70", Offset = "0x994F70", VA = "0x180995D70", Slot = "6")]
	protected override void ExtendArgs(ref Dictionary<string, object> args)
	{
	}

	[Token(Token = "0x600516F")]
	[Address(RVA = "0x995CE0", Offset = "0x994EE0", VA = "0x180995CE0", Slot = "7")]
	public override void Check(Action<bool> resultCallback)
	{
	}

	[Token(Token = "0x6005170")]
	[Address(RVA = "0x995E00", Offset = "0x995000", VA = "0x180995E00")]
	[IteratorStateMachine(typeof(_003CcheckCoroutine_003Ed__7))]
	private IEnumerator checkCoroutine(Action<bool> callback)
	{
		return null;
	}

	[Token(Token = "0x6005171")]
	[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
	public RdcMenuJumper()
	{
	}
}
