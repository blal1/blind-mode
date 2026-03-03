using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace YgomGame;

[Token(Token = "0x2000719")]
public class AutoDestroy : MonoBehaviour
{
	[Token(Token = "0x200071A")]
	[CompilerGenerated]
	private sealed class _003CDelayDestroy_003Ed__3 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4002367")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4002368")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4002369")]
		[FieldOffset(Offset = "0x20")]
		public AutoDestroy _003C_003E4__this;

		[Token(Token = "0x170005C9")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6002ECC")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170005CA")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6002ECE")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6002EC9")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CDelayDestroy_003Ed__3(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6002ECA")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6002ECB")]
		[Address(RVA = "0x724AA0", Offset = "0x723CA0", VA = "0x180724AA0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6002ECD")]
		[Address(RVA = "0x724B80", Offset = "0x723D80", VA = "0x180724B80", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x4002365")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private float delayTime;

	[Token(Token = "0x4002366")]
	[FieldOffset(Offset = "0x24")]
	private float restTime;

	[Token(Token = "0x6002EC6")]
	[Address(RVA = "0x718FA0", Offset = "0x7181A0", VA = "0x180718FA0")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6002EC7")]
	[Address(RVA = "0x718F30", Offset = "0x718130", VA = "0x180718F30")]
	[IteratorStateMachine(typeof(_003CDelayDestroy_003Ed__3))]
	private IEnumerator DelayDestroy()
	{
		return null;
	}

	[Token(Token = "0x6002EC8")]
	[Address(RVA = "0x3D2BD0", Offset = "0x3D1DD0", VA = "0x1803D2BD0")]
	public AutoDestroy()
	{
	}
}
