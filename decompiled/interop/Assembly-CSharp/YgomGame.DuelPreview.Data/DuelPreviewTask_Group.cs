using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace YgomGame.DuelPreview.Data;

[Token(Token = "0x2000E51")]
public class DuelPreviewTask_Group : DuelPreviewTaskBase
{
	[Token(Token = "0x2000E52")]
	[CompilerGenerated]
	private sealed class _003CPlay_003Ed__2 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400A30F")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400A310")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400A311")]
		[FieldOffset(Offset = "0x20")]
		public DuelPreviewTask_Group _003C_003E4__this;

		[Token(Token = "0x400A312")]
		[FieldOffset(Offset = "0x28")]
		private IEnumerator _003CplayRoutine_003E5__2;

		[Token(Token = "0x17000D12")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x600569E")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000D13")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60056A0")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600569B")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CPlay_003Ed__2(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x600569C")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x600569D")]
		[Address(RVA = "0x9C6310", Offset = "0x9C5510", VA = "0x1809C6310", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600569F")]
		[Address(RVA = "0x9C6430", Offset = "0x9C5630", VA = "0x1809C6430", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x2000E53")]
	[CompilerGenerated]
	private sealed class _003CySetup_003Ed__1 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400A313")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400A314")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400A315")]
		[FieldOffset(Offset = "0x20")]
		public DuelPreviewTask_Group _003C_003E4__this;

		[Token(Token = "0x400A316")]
		[FieldOffset(Offset = "0x28")]
		private IEnumerator _003CsetupRoutine_003E5__2;

		[Token(Token = "0x17000D14")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x60056A4")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000D15")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60056A6")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60056A1")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CySetup_003Ed__1(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x60056A2")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x60056A3")]
		[Address(RVA = "0x9CBD50", Offset = "0x9CAF50", VA = "0x1809CBD50", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60056A5")]
		[Address(RVA = "0x9CBE90", Offset = "0x9CB090", VA = "0x1809CBE90", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x400A30E")]
	[FieldOffset(Offset = "0x20")]
	private DuelPreviewSequence m_Sequence;

	[Token(Token = "0x6005698")]
	[Address(RVA = "0x9B7DC0", Offset = "0x9B6FC0", VA = "0x1809B7DC0", Slot = "9")]
	[IteratorStateMachine(typeof(_003CySetup_003Ed__1))]
	public override IEnumerator ySetup()
	{
		return null;
	}

	[Token(Token = "0x6005699")]
	[Address(RVA = "0x9B7CE0", Offset = "0x9B6EE0", VA = "0x1809B7CE0", Slot = "10")]
	[IteratorStateMachine(typeof(_003CPlay_003Ed__2))]
	public override IEnumerator Play()
	{
		return null;
	}

	[Token(Token = "0x600569A")]
	[Address(RVA = "0x9B7D50", Offset = "0x9B6F50", VA = "0x1809B7D50")]
	public DuelPreviewTask_Group()
	{
	}
}
