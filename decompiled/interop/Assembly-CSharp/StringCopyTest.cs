using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000027")]
public class StringCopyTest : MonoBehaviour
{
	[Token(Token = "0x2000028")]
	[CompilerGenerated]
	private sealed class _003CStart_003Ed__0 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40000A0")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x40000A1")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x40000A2")]
		[FieldOffset(Offset = "0x20")]
		private string _003Ca1_003E5__2;

		[Token(Token = "0x40000A3")]
		[FieldOffset(Offset = "0x28")]
		private string _003Ca2_003E5__3;

		[Token(Token = "0x1700000F")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x60000CD")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000010")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60000CF")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60000CA")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CStart_003Ed__0(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x60000CB")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x60000CC")]
		[Address(RVA = "0x3E9DA0", Offset = "0x3E8FA0", VA = "0x1803E9DA0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60000CE")]
		[Address(RVA = "0x3E9F20", Offset = "0x3E9120", VA = "0x1803E9F20", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x60000C8")]
	[Address(RVA = "0x3E3E40", Offset = "0x3E3040", VA = "0x1803E3E40")]
	[IteratorStateMachine(typeof(_003CStart_003Ed__0))]
	private IEnumerator Start()
	{
		return null;
	}

	[Token(Token = "0x60000C9")]
	[Address(RVA = "0x3D2BD0", Offset = "0x3D1DD0", VA = "0x1803D2BD0")]
	public StringCopyTest()
	{
	}
}
