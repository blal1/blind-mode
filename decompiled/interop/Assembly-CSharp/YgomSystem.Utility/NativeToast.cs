using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace YgomSystem.Utility;

[Token(Token = "0x20003F0")]
public static class NativeToast
{
	[Token(Token = "0x20003F1")]
	[CompilerGenerated]
	private sealed class _003CyOpen_003Ed__4 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40013B2")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x40013B3")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x1700025B")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6001941")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700025C")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6001943")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600193E")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CyOpen_003Ed__4(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x600193F")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6001940")]
		[Address(RVA = "0x5E1D50", Offset = "0x5E0F50", VA = "0x1805E1D50", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6001942")]
		[Address(RVA = "0x5E1E30", Offset = "0x5E1030", VA = "0x1805E1E30", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x40013B0")]
	[FieldOffset(Offset = "0x0")]
	private static WaitForSeconds waitTime;

	[Token(Token = "0x40013B1")]
	[FieldOffset(Offset = "0x8")]
	private static IEnumerator yCoroutine;

	[Token(Token = "0x600193B")]
	[Address(RVA = "0x5D13E0", Offset = "0x5D05E0", VA = "0x1805D13E0")]
	static NativeToast()
	{
	}

	[Token(Token = "0x600193C")]
	[Address(RVA = "0x5D12C0", Offset = "0x5D04C0", VA = "0x1805D12C0")]
	public static void Open(string message)
	{
	}

	[Token(Token = "0x600193D")]
	[Address(RVA = "0x5D1460", Offset = "0x5D0660", VA = "0x1805D1460")]
	[IteratorStateMachine(typeof(_003CyOpen_003Ed__4))]
	private static IEnumerator yOpen(string message)
	{
		return null;
	}
}
