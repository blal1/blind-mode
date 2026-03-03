using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace YgomGame.DuelPreview.Data;

[Token(Token = "0x2000E60")]
public class DuelPreviewTask_PlayTmLabel : DuelPreviewTaskBase
{
	[Token(Token = "0x2000E61")]
	[CompilerGenerated]
	private sealed class _003CPlay_003Ed__1 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400A330")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400A331")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400A332")]
		[FieldOffset(Offset = "0x20")]
		public DuelPreviewTask_PlayTmLabel _003C_003E4__this;

		[Token(Token = "0x17000D2F")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x60056F2")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000D30")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60056F4")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60056EF")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CPlay_003Ed__1(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x60056F0")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x60056F1")]
		[Address(RVA = "0x9C5C50", Offset = "0x9C4E50", VA = "0x1809C5C50", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60056F3")]
		[Address(RVA = "0x9C6290", Offset = "0x9C5490", VA = "0x1809C6290", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x2000E62")]
	[CompilerGenerated]
	private sealed class _003CySetup_003Ed__0 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400A333")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400A334")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x17000D31")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x60056F8")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000D32")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60056FA")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60056F5")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CySetup_003Ed__0(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x60056F6")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x60056F7")]
		[Address(RVA = "0x59F130", Offset = "0x59E330", VA = "0x18059F130", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60056F9")]
		[Address(RVA = "0x9CB820", Offset = "0x9CAA20", VA = "0x1809CB820", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x60056EC")]
	[Address(RVA = "0x9B8610", Offset = "0x9B7810", VA = "0x1809B8610", Slot = "9")]
	[IteratorStateMachine(typeof(_003CySetup_003Ed__0))]
	public override IEnumerator ySetup()
	{
		return null;
	}

	[Token(Token = "0x60056ED")]
	[Address(RVA = "0x9B85A0", Offset = "0x9B77A0", VA = "0x1809B85A0", Slot = "10")]
	[IteratorStateMachine(typeof(_003CPlay_003Ed__1))]
	public override IEnumerator Play()
	{
		return null;
	}

	[Token(Token = "0x60056EE")]
	[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
	public DuelPreviewTask_PlayTmLabel()
	{
	}
}
