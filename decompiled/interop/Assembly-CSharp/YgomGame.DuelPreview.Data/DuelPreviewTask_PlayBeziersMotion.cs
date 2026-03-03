using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace YgomGame.DuelPreview.Data;

[Token(Token = "0x2000E54")]
public class DuelPreviewTask_PlayBeziersMotion : DuelPreviewTaskBase
{
	[Token(Token = "0x2000E55")]
	[CompilerGenerated]
	private sealed class _003CPlay_003Ed__6 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400A318")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400A319")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400A31A")]
		[FieldOffset(Offset = "0x20")]
		public DuelPreviewTask_PlayBeziersMotion _003C_003E4__this;

		[Token(Token = "0x17000D18")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x60056AF")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000D19")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60056B1")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60056AC")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CPlay_003Ed__6(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x60056AD")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x60056AE")]
		[Address(RVA = "0x9C6520", Offset = "0x9C5720", VA = "0x1809C6520", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60056B0")]
		[Address(RVA = "0x9C6A70", Offset = "0x9C5C70", VA = "0x1809C6A70", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x2000E56")]
	[CompilerGenerated]
	private sealed class _003CySetup_003Ed__5 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400A31B")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400A31C")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400A31D")]
		[FieldOffset(Offset = "0x20")]
		public DuelPreviewTask_PlayBeziersMotion _003C_003E4__this;

		[Token(Token = "0x17000D1A")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x60056B5")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000D1B")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60056B7")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60056B2")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CySetup_003Ed__5(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x60056B3")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x60056B4")]
		[Address(RVA = "0x9CC020", Offset = "0x9CB220", VA = "0x1809CC020", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60056B6")]
		[Address(RVA = "0x9CC120", Offset = "0x9CB320", VA = "0x1809CC120", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x400A317")]
	[FieldOffset(Offset = "0x20")]
	private IEnumerator m_Routine;

	[Token(Token = "0x17000D16")]
	private string targetLabel
	{
		[Token(Token = "0x60056A7")]
		[Address(RVA = "0x9B7EE0", Offset = "0x9B70E0", VA = "0x1809B7EE0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000D17")]
	private string bezierPath
	{
		[Token(Token = "0x60056A8")]
		[Address(RVA = "0x9B7EA0", Offset = "0x9B70A0", VA = "0x1809B7EA0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60056A9")]
	[Address(RVA = "0x9B7F20", Offset = "0x9B7120", VA = "0x1809B7F20", Slot = "9")]
	[IteratorStateMachine(typeof(_003CySetup_003Ed__5))]
	public override IEnumerator ySetup()
	{
		return null;
	}

	[Token(Token = "0x60056AA")]
	[Address(RVA = "0x9B7E30", Offset = "0x9B7030", VA = "0x1809B7E30", Slot = "10")]
	[IteratorStateMachine(typeof(_003CPlay_003Ed__6))]
	public override IEnumerator Play()
	{
		return null;
	}

	[Token(Token = "0x60056AB")]
	[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
	public DuelPreviewTask_PlayBeziersMotion()
	{
	}
}
