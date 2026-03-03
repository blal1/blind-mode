using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace YgomGame.DuelPreview.Data;

[Token(Token = "0x2000E3B")]
public class DuelPreviewSequence
{
	[Token(Token = "0x2000E3C")]
	[CompilerGenerated]
	private sealed class _003CSetup_003Ed__7 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400A2B6")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400A2B7")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400A2B8")]
		[FieldOffset(Offset = "0x20")]
		public DuelPreviewSequence _003C_003E4__this;

		[Token(Token = "0x400A2B9")]
		[FieldOffset(Offset = "0x28")]
		public IReadOnlyList<DuelPreviewTaskRawData> taskDatas;

		[Token(Token = "0x400A2BA")]
		[FieldOffset(Offset = "0x30")]
		public DuelPreviewPlayer player;

		[Token(Token = "0x400A2BB")]
		[FieldOffset(Offset = "0x38")]
		private List<IEnumerator> _003CsetupRoutines_003E5__2;

		[Token(Token = "0x400A2BC")]
		[FieldOffset(Offset = "0x40")]
		private int _003CdoneSetupCnt_003E5__3;

		[Token(Token = "0x17000CF2")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x600563A")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000CF3")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600563C")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6005637")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CSetup_003Ed__7(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6005638")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6005639")]
		[Address(RVA = "0x9C6F80", Offset = "0x9C6180", VA = "0x1809C6F80", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600563B")]
		[Address(RVA = "0x9C7430", Offset = "0x9C6630", VA = "0x1809C7430", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x2000E3D")]
	[CompilerGenerated]
	private sealed class _003CyPlay_003Ed__8 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400A2BD")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400A2BE")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400A2BF")]
		[FieldOffset(Offset = "0x20")]
		public DuelPreviewSequence _003C_003E4__this;

		[Token(Token = "0x400A2C0")]
		[FieldOffset(Offset = "0x28")]
		private IEnumerator _003CplayRoutines_003E5__2;

		[Token(Token = "0x17000CF4")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6005640")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000CF5")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6005642")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600563D")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CyPlay_003Ed__8(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x600563E")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x600563F")]
		[Address(RVA = "0x9CB0F0", Offset = "0x9CA2F0", VA = "0x1809CB0F0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6005641")]
		[Address(RVA = "0x9CB310", Offset = "0x9CA510", VA = "0x1809CB310", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x2000E3E")]
	[CompilerGenerated]
	private sealed class _003CyPlayRoutines_003Ed__9 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400A2C1")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400A2C2")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400A2C3")]
		[FieldOffset(Offset = "0x20")]
		public DuelPreviewSequence _003C_003E4__this;

		[Token(Token = "0x17000CF6")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6005646")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000CF7")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6005648")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6005643")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CyPlayRoutines_003Ed__9(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6005644")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6005645")]
		[Address(RVA = "0x9C8D80", Offset = "0x9C7F80", VA = "0x1809C8D80", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6005647")]
		[Address(RVA = "0x9C90B0", Offset = "0x9C82B0", VA = "0x1809C90B0", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x400A2B2")]
	[FieldOffset(Offset = "0x10")]
	private List<IDuelPreviewTask> m_Tasks;

	[Token(Token = "0x400A2B3")]
	[FieldOffset(Offset = "0x18")]
	private IEnumerator m_WaitPlayRoutine;

	[Token(Token = "0x400A2B4")]
	[FieldOffset(Offset = "0x20")]
	private List<IEnumerator> m_ThroughPlayRoutines;

	[Token(Token = "0x400A2B5")]
	[FieldOffset(Offset = "0x28")]
	private int m_SeqIdx;

	[Token(Token = "0x17000CF1")]
	public bool isEmpty
	{
		[Token(Token = "0x6005631")]
		[Address(RVA = "0x9B6DC0", Offset = "0x9B5FC0", VA = "0x1809B6DC0")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6005632")]
	[Address(RVA = "0x9B6BA0", Offset = "0x9B5DA0", VA = "0x1809B6BA0")]
	public void Clear()
	{
	}

	[Token(Token = "0x6005633")]
	[Address(RVA = "0x9B6C50", Offset = "0x9B5E50", VA = "0x1809B6C50")]
	[IteratorStateMachine(typeof(_003CSetup_003Ed__7))]
	public IEnumerator Setup(IReadOnlyList<DuelPreviewTaskRawData> taskDatas, DuelPreviewPlayer player)
	{
		return null;
	}

	[Token(Token = "0x6005634")]
	[Address(RVA = "0x9B6E80", Offset = "0x9B6080", VA = "0x1809B6E80")]
	[IteratorStateMachine(typeof(_003CyPlay_003Ed__8))]
	public IEnumerator yPlay()
	{
		return null;
	}

	[Token(Token = "0x6005635")]
	[Address(RVA = "0x9B6E10", Offset = "0x9B6010", VA = "0x1809B6E10")]
	[IteratorStateMachine(typeof(_003CyPlayRoutines_003Ed__9))]
	private IEnumerator yPlayRoutines()
	{
		return null;
	}

	[Token(Token = "0x6005636")]
	[Address(RVA = "0x9B6D00", Offset = "0x9B5F00", VA = "0x1809B6D00")]
	public DuelPreviewSequence()
	{
	}
}
