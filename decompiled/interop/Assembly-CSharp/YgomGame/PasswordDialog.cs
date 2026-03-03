using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace YgomGame;

[Token(Token = "0x20006C3")]
public static class PasswordDialog
{
	[Token(Token = "0x20006C4")]
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass1_0
	{
		[Token(Token = "0x40021F7")]
		[FieldOffset(Offset = "0x10")]
		public string input_str;

		[Token(Token = "0x40021F8")]
		[FieldOffset(Offset = "0x18")]
		public bool wait;

		[Token(Token = "0x6002D21")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public _003C_003Ec__DisplayClass1_0()
		{
		}

		[Token(Token = "0x6002D22")]
		[Address(RVA = "0x708300", Offset = "0x707500", VA = "0x180708300")]
		internal void _003CInput_003Eb__0(string str)
		{
		}
	}

	[Token(Token = "0x20006C5")]
	[CompilerGenerated]
	private sealed class _003CInput_003Ed__1 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40021F9")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x40021FA")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x40021FB")]
		[FieldOffset(Offset = "0x20")]
		private _003C_003Ec__DisplayClass1_0 _003C_003E8__1;

		[Token(Token = "0x40021FC")]
		[FieldOffset(Offset = "0x28")]
		public Action<string> callback;

		[Token(Token = "0x1700058A")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6002D26")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700058B")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6002D28")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6002D23")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CInput_003Ed__1(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6002D24")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6002D25")]
		[Address(RVA = "0x707A40", Offset = "0x706C40", VA = "0x180707A40", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6002D27")]
		[Address(RVA = "0x707D20", Offset = "0x706F20", VA = "0x180707D20", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x6002D1F")]
	[Address(RVA = "0x706CD0", Offset = "0x705ED0", VA = "0x180706CD0")]
	public static void Open(Action<string> callback)
	{
	}

	[Token(Token = "0x6002D20")]
	[Address(RVA = "0x706C60", Offset = "0x705E60", VA = "0x180706C60")]
	[IteratorStateMachine(typeof(_003CInput_003Ed__1))]
	public static IEnumerator Input(Action<string> callback)
	{
		return null;
	}
}
