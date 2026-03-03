using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace YgomGame.DuelPreview.Data;

[Token(Token = "0x2000E72")]
public class DuelPreviewTask_SetPos : DuelPreviewTaskBase
{
	[Token(Token = "0x2000E73")]
	[CompilerGenerated]
	private sealed class _003CPlay_003Ed__7 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400A350")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400A351")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400A352")]
		[FieldOffset(Offset = "0x20")]
		public DuelPreviewTask_SetPos _003C_003E4__this;

		[Token(Token = "0x17000D4B")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6005750")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000D4C")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6005752")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600574D")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CPlay_003Ed__7(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x600574E")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x600574F")]
		[Address(RVA = "0x9C6AB0", Offset = "0x9C5CB0", VA = "0x1809C6AB0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6005751")]
		[Address(RVA = "0x9C6CB0", Offset = "0x9C5EB0", VA = "0x1809C6CB0", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x2000E74")]
	[CompilerGenerated]
	private sealed class _003CySetup_003Ed__6 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400A353")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400A354")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x17000D4D")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6005756")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000D4E")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6005758")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6005753")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CySetup_003Ed__6(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6005754")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6005755")]
		[Address(RVA = "0x59F130", Offset = "0x59E330", VA = "0x18059F130", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6005757")]
		[Address(RVA = "0x9CC160", Offset = "0x9CB360", VA = "0x1809CC160", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x17000D48")]
	private Vector3 pos
	{
		[Token(Token = "0x6005747")]
		[Address(RVA = "0x9B8B70", Offset = "0x9B7D70", VA = "0x1809B8B70")]
		get
		{
			return default(Vector3);
		}
	}

	[Token(Token = "0x17000D49")]
	private Vector3 rotate
	{
		[Token(Token = "0x6005748")]
		[Address(RVA = "0x9B8BB0", Offset = "0x9B7DB0", VA = "0x1809B8BB0")]
		get
		{
			return default(Vector3);
		}
	}

	[Token(Token = "0x17000D4A")]
	private Vector3 scale
	{
		[Token(Token = "0x6005749")]
		[Address(RVA = "0x9B8BF0", Offset = "0x9B7DF0", VA = "0x1809B8BF0")]
		get
		{
			return default(Vector3);
		}
	}

	[Token(Token = "0x600574A")]
	[Address(RVA = "0x9B8C30", Offset = "0x9B7E30", VA = "0x1809B8C30", Slot = "9")]
	[IteratorStateMachine(typeof(_003CySetup_003Ed__6))]
	public override IEnumerator ySetup()
	{
		return null;
	}

	[Token(Token = "0x600574B")]
	[Address(RVA = "0x9B8B00", Offset = "0x9B7D00", VA = "0x1809B8B00", Slot = "10")]
	[IteratorStateMachine(typeof(_003CPlay_003Ed__7))]
	public override IEnumerator Play()
	{
		return null;
	}

	[Token(Token = "0x600574C")]
	[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
	public DuelPreviewTask_SetPos()
	{
	}
}
