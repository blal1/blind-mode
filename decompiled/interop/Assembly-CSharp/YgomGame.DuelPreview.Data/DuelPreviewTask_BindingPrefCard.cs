using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace YgomGame.DuelPreview.Data;

[Token(Token = "0x2000E49")]
public class DuelPreviewTask_BindingPrefCard : DuelPreviewTaskBase
{
	[Token(Token = "0x2000E4A")]
	private enum BindingMode
	{
		[Token(Token = "0x400A2FE")]
		BinidngMat,
		[Token(Token = "0x400A2FF")]
		BindingTex
	}

	[Token(Token = "0x2000E4C")]
	[CompilerGenerated]
	private sealed class _003CPlay_003Ed__8 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400A302")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400A303")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400A304")]
		[FieldOffset(Offset = "0x20")]
		public DuelPreviewTask_BindingPrefCard _003C_003E4__this;

		[Token(Token = "0x17000D0A")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6005680")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000D0B")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6005682")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600567D")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CPlay_003Ed__8(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x600567E")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x600567F")]
		[Address(RVA = "0x9C6CF0", Offset = "0x9C5EF0", VA = "0x1809C6CF0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6005681")]
		[Address(RVA = "0x9C6F40", Offset = "0x9C6140", VA = "0x1809C6F40", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x2000E4D")]
	[CompilerGenerated]
	private sealed class _003CySetup_003Ed__7 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400A305")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400A306")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x17000D0C")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6005686")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000D0D")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6005688")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6005683")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CySetup_003Ed__7(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6005684")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6005685")]
		[Address(RVA = "0x59F130", Offset = "0x59E330", VA = "0x18059F130", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6005687")]
		[Address(RVA = "0x9CC1A0", Offset = "0x9CB3A0", VA = "0x1809CC1A0", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x400A2F8")]
	[FieldOffset(Offset = "0x20")]
	private string m_PrefLabel;

	[Token(Token = "0x400A2F9")]
	[FieldOffset(Offset = "0x28")]
	private int m_Mrk;

	[Token(Token = "0x400A2FA")]
	[FieldOffset(Offset = "0x2C")]
	private int m_Premium;

	[Token(Token = "0x400A2FB")]
	[FieldOffset(Offset = "0x30")]
	private BindingMode m_BindingMode;

	[Token(Token = "0x400A2FC")]
	[FieldOffset(Offset = "0x38")]
	private string m_CardTexName;

	[Token(Token = "0x6005677")]
	[Address(RVA = "0x9B7830", Offset = "0x9B6A30", VA = "0x1809B7830", Slot = "8")]
	protected override void OnInit()
	{
	}

	[Token(Token = "0x6005678")]
	[Address(RVA = "0x9B7BB0", Offset = "0x9B6DB0", VA = "0x1809B7BB0", Slot = "9")]
	[IteratorStateMachine(typeof(_003CySetup_003Ed__7))]
	public override IEnumerator ySetup()
	{
		return null;
	}

	[Token(Token = "0x6005679")]
	[Address(RVA = "0x9B7B00", Offset = "0x9B6D00", VA = "0x1809B7B00", Slot = "10")]
	[IteratorStateMachine(typeof(_003CPlay_003Ed__8))]
	public override IEnumerator Play()
	{
		return null;
	}

	[Token(Token = "0x600567A")]
	[Address(RVA = "0x9B7B70", Offset = "0x9B6D70", VA = "0x1809B7B70")]
	public DuelPreviewTask_BindingPrefCard()
	{
	}
}
