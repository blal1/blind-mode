using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace YgomGame.Pvp;

[Token(Token = "0x200173E")]
public class TestDuelEntryViewController : DuelStartViewController
{
	[Token(Token = "0x200173F")]
	[CompilerGenerated]
	private sealed class _003CyInit_003Ed__0 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400DB3C")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400DB3D")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400DB3E")]
		[FieldOffset(Offset = "0x20")]
		public TestDuelEntryViewController _003C_003E4__this;

		[Token(Token = "0x1700165B")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x60091C9")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700165C")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60091CB")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60091C6")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CyInit_003Ed__0(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x60091C7")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x60091C8")]
		[Address(RVA = "0x3EB550", Offset = "0x3EA750", VA = "0x1803EB550", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60091CA")]
		[Address(RVA = "0xDD7A40", Offset = "0xDD6C40", VA = "0x180DD7A40", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x60091C0")]
	[Address(RVA = "0xDD5D90", Offset = "0xDD4F90", VA = "0x180DD5D90", Slot = "37")]
	[IteratorStateMachine(typeof(_003CyInit_003Ed__0))]
	protected override IEnumerator yInit()
	{
		return null;
	}

	[Token(Token = "0x60091C1")]
	[Address(RVA = "0xDD5B40", Offset = "0xDD4D40", VA = "0x180DD5B40", Slot = "33")]
	protected override void SelectTurn()
	{
	}

	[Token(Token = "0x60091C2")]
	[Address(RVA = "0x3E60E0", Offset = "0x3E52E0", VA = "0x1803E60E0")]
	private void Delay()
	{
	}

	[Token(Token = "0x60091C3")]
	[Address(RVA = "0xDD5AA0", Offset = "0xDD4CA0", VA = "0x180DD5AA0", Slot = "34")]
	protected override void DuelBegin()
	{
	}

	[Token(Token = "0x60091C4")]
	[Address(RVA = "0xDD5B90", Offset = "0xDD4D90", VA = "0x180DD5B90", Slot = "35")]
	protected override void StartDuel()
	{
	}

	[Token(Token = "0x60091C5")]
	[Address(RVA = "0xDD5D40", Offset = "0xDD4F40", VA = "0x180DD5D40")]
	public TestDuelEntryViewController()
	{
	}
}
