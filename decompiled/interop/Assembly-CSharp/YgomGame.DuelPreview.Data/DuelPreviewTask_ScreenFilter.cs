using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace YgomGame.DuelPreview.Data;

[Token(Token = "0x2000E66")]
public class DuelPreviewTask_ScreenFilter : DuelPreviewTaskBase
{
	[Token(Token = "0x2000E67")]
	[CompilerGenerated]
	private sealed class _003CPlay_003Ed__1 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400A33A")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400A33B")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400A33C")]
		[FieldOffset(Offset = "0x20")]
		public DuelPreviewTask_ScreenFilter _003C_003E4__this;

		[Token(Token = "0x17000D37")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6005710")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000D38")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6005712")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600570D")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CPlay_003Ed__1(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x600570E")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x600570F")]
		[Address(RVA = "0x9C5030", Offset = "0x9C4230", VA = "0x1809C5030", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6005711")]
		[Address(RVA = "0x9C62D0", Offset = "0x9C54D0", VA = "0x1809C62D0", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x2000E68")]
	[CompilerGenerated]
	private sealed class _003CySetup_003Ed__0 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400A33D")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400A33E")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x17000D39")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6005716")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000D3A")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6005718")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6005713")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CySetup_003Ed__0(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6005714")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6005715")]
		[Address(RVA = "0x59F130", Offset = "0x59E330", VA = "0x18059F130", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6005717")]
		[Address(RVA = "0x9CB9E0", Offset = "0x9CABE0", VA = "0x1809CB9E0", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x600570A")]
	[Address(RVA = "0x9B8850", Offset = "0x9B7A50", VA = "0x1809B8850", Slot = "9")]
	[IteratorStateMachine(typeof(_003CySetup_003Ed__0))]
	public override IEnumerator ySetup()
	{
		return null;
	}

	[Token(Token = "0x600570B")]
	[Address(RVA = "0x9B87E0", Offset = "0x9B79E0", VA = "0x1809B87E0", Slot = "10")]
	[IteratorStateMachine(typeof(_003CPlay_003Ed__1))]
	public override IEnumerator Play()
	{
		return null;
	}

	[Token(Token = "0x600570C")]
	[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
	public DuelPreviewTask_ScreenFilter()
	{
	}
}
