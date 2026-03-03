using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace YgomGame.DuelPreview.Data;

[Token(Token = "0x2000E8E")]
public class DuelPreviewTask_WaitTm : DuelPreviewTaskBase
{
	[Token(Token = "0x2000E8F")]
	[CompilerGenerated]
	private sealed class _003CPlay_003Ed__1 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400A38C")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400A38D")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400A38E")]
		[FieldOffset(Offset = "0x20")]
		public DuelPreviewTask_WaitTm _003C_003E4__this;

		[Token(Token = "0x400A38F")]
		[FieldOffset(Offset = "0x28")]
		private string _003CprefLabel_003E5__2;

		[Token(Token = "0x17000D73")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x60057DD")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000D74")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60057DF")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60057DA")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CPlay_003Ed__1(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x60057DB")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x60057DC")]
		[Address(RVA = "0x9C4190", Offset = "0x9C3390", VA = "0x1809C4190", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60057DE")]
		[Address(RVA = "0x9C5FD0", Offset = "0x9C51D0", VA = "0x1809C5FD0", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x2000E90")]
	[CompilerGenerated]
	private sealed class _003CySetup_003Ed__0 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400A390")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400A391")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x17000D75")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x60057E3")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000D76")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60057E5")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60057E0")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CySetup_003Ed__0(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x60057E1")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x60057E2")]
		[Address(RVA = "0x59F130", Offset = "0x59E330", VA = "0x18059F130", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60057E4")]
		[Address(RVA = "0x9CB9A0", Offset = "0x9CABA0", VA = "0x1809CB9A0", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x60057D7")]
	[Address(RVA = "0x9B9350", Offset = "0x9B8550", VA = "0x1809B9350", Slot = "9")]
	[IteratorStateMachine(typeof(_003CySetup_003Ed__0))]
	public override IEnumerator ySetup()
	{
		return null;
	}

	[Token(Token = "0x60057D8")]
	[Address(RVA = "0x9B92E0", Offset = "0x9B84E0", VA = "0x1809B92E0", Slot = "10")]
	[IteratorStateMachine(typeof(_003CPlay_003Ed__1))]
	public override IEnumerator Play()
	{
		return null;
	}

	[Token(Token = "0x60057D9")]
	[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
	public DuelPreviewTask_WaitTm()
	{
	}
}
