using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace YgomGame.Duel;

[Token(Token = "0x2001834")]
public class TagController : MonoBehaviour
{
	[Token(Token = "0x2001835")]
	[CompilerGenerated]
	private sealed class _003CStart_003Ed__2 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400E2E2")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400E2E3")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400E2E4")]
		[FieldOffset(Offset = "0x20")]
		public TagController _003C_003E4__this;

		[Token(Token = "0x17001745")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x60099CE")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17001746")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60099D0")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60099CB")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CStart_003Ed__2(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x60099CC")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x60099CD")]
		[Address(RVA = "0xE444D0", Offset = "0xE436D0", VA = "0x180E444D0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60099CF")]
		[Address(RVA = "0xE44610", Offset = "0xE43810", VA = "0x180E44610", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x400E2E0")]
	[FieldOffset(Offset = "0x20")]
	public bool checkStartVisible;

	[Token(Token = "0x400E2E1")]
	[FieldOffset(Offset = "0x28")]
	public Action onFirstInvisible;

	[Token(Token = "0x60099C8")]
	[Address(RVA = "0xE3CC00", Offset = "0xE3BE00", VA = "0x180E3CC00")]
	[IteratorStateMachine(typeof(_003CStart_003Ed__2))]
	private IEnumerator Start()
	{
		return null;
	}

	[Token(Token = "0x60099C9")]
	[Address(RVA = "0xE3CBC0", Offset = "0xE3BDC0", VA = "0x180E3CBC0")]
	private void OnBecameInvisible()
	{
	}

	[Token(Token = "0x60099CA")]
	[Address(RVA = "0x3D2BD0", Offset = "0x3D1DD0", VA = "0x1803D2BD0")]
	public TagController()
	{
	}
}
