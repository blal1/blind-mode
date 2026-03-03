using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace YgomGame.DuelPreview.Data;

[Token(Token = "0x2000E6F")]
public class DuelPreviewTask_SetField : DuelPreviewTaskBase
{
	[Token(Token = "0x2000E70")]
	[CompilerGenerated]
	private sealed class _003CPlay_003Ed__3 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400A349")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400A34A")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400A34B")]
		[FieldOffset(Offset = "0x20")]
		public DuelPreviewTask_SetField _003C_003E4__this;

		[Token(Token = "0x17000D44")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x600573E")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000D45")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6005740")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600573B")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CPlay_003Ed__3(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x600573C")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x600573D")]
		[Address(RVA = "0x9C6470", Offset = "0x9C5670", VA = "0x1809C6470", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600573F")]
		[Address(RVA = "0x9C64E0", Offset = "0x9C56E0", VA = "0x1809C64E0", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x2000E71")]
	[CompilerGenerated]
	private sealed class _003CySetup_003Ed__2 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400A34C")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400A34D")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400A34E")]
		[FieldOffset(Offset = "0x20")]
		public DuelPreviewTask_SetField _003C_003E4__this;

		[Token(Token = "0x400A34F")]
		[FieldOffset(Offset = "0x28")]
		private IEnumerator _003CfieldSetRoutine_003E5__2;

		[Token(Token = "0x17000D46")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6005744")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000D47")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6005746")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6005741")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CySetup_003Ed__2(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6005742")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6005743")]
		[Address(RVA = "0x9CBED0", Offset = "0x9CB0D0", VA = "0x1809CBED0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6005745")]
		[Address(RVA = "0x9CBFE0", Offset = "0x9CB1E0", VA = "0x1809CBFE0", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x17000D43")]
	private string fieldPath
	{
		[Token(Token = "0x6005737")]
		[Address(RVA = "0x9B7EE0", Offset = "0x9B70E0", VA = "0x1809B7EE0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6005738")]
	[Address(RVA = "0x9B8A90", Offset = "0x9B7C90", VA = "0x1809B8A90", Slot = "9")]
	[IteratorStateMachine(typeof(_003CySetup_003Ed__2))]
	public override IEnumerator ySetup()
	{
		return null;
	}

	[Token(Token = "0x6005739")]
	[Address(RVA = "0x9B8A20", Offset = "0x9B7C20", VA = "0x1809B8A20", Slot = "10")]
	[IteratorStateMachine(typeof(_003CPlay_003Ed__3))]
	public override IEnumerator Play()
	{
		return null;
	}

	[Token(Token = "0x600573A")]
	[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
	public DuelPreviewTask_SetField()
	{
	}
}
