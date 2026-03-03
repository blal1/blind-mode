using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace YgomGame.DuelPreview.Data;

[Token(Token = "0x2000E85")]
public class DuelPreviewTask_SyncPos : DuelPreviewTaskBase
{
	[Token(Token = "0x2000E86")]
	[CompilerGenerated]
	private sealed class _003CPlay_003Ed__1 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400A378")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400A379")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400A37A")]
		[FieldOffset(Offset = "0x20")]
		public DuelPreviewTask_SyncPos _003C_003E4__this;

		[Token(Token = "0x400A37B")]
		[FieldOffset(Offset = "0x28")]
		private bool _003ConActiveOnly_003E5__2;

		[Token(Token = "0x400A37C")]
		[FieldOffset(Offset = "0x30")]
		private GameObject _003Croot_003E5__3;

		[Token(Token = "0x400A37D")]
		[FieldOffset(Offset = "0x38")]
		private GameObject _003CdestObj_003E5__4;

		[Token(Token = "0x17000D67")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x60057B0")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000D68")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60057B2")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60057AD")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CPlay_003Ed__1(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x60057AE")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x60057AF")]
		[Address(RVA = "0x9C4290", Offset = "0x9C3490", VA = "0x1809C4290", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60057B1")]
		[Address(RVA = "0x9C5F50", Offset = "0x9C5150", VA = "0x1809C5F50", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x2000E87")]
	[CompilerGenerated]
	private sealed class _003CySetup_003Ed__0 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400A37E")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400A37F")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x17000D69")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x60057B6")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000D6A")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60057B8")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60057B3")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CySetup_003Ed__0(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x60057B4")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x60057B5")]
		[Address(RVA = "0x59F130", Offset = "0x59E330", VA = "0x18059F130", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60057B7")]
		[Address(RVA = "0x9CBB20", Offset = "0x9CAD20", VA = "0x1809CBB20", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x60057AA")]
	[Address(RVA = "0x9B9110", Offset = "0x9B8310", VA = "0x1809B9110", Slot = "9")]
	[IteratorStateMachine(typeof(_003CySetup_003Ed__0))]
	public override IEnumerator ySetup()
	{
		return null;
	}

	[Token(Token = "0x60057AB")]
	[Address(RVA = "0x9B90A0", Offset = "0x9B82A0", VA = "0x1809B90A0", Slot = "10")]
	[IteratorStateMachine(typeof(_003CPlay_003Ed__1))]
	public override IEnumerator Play()
	{
		return null;
	}

	[Token(Token = "0x60057AC")]
	[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
	public DuelPreviewTask_SyncPos()
	{
	}
}
