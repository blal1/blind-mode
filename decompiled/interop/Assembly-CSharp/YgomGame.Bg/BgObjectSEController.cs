using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace YgomGame.Bg;

[Token(Token = "0x2001D65")]
public class BgObjectSEController : MonoBehaviour
{
	[Token(Token = "0x2001D66")]
	[CompilerGenerated]
	private sealed class _003CPlaySE_003Ed__11 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x401039C")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x401039D")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x401039E")]
		[FieldOffset(Offset = "0x20")]
		public BgObjectSEController _003C_003E4__this;

		[Token(Token = "0x17001C0F")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x600BCAA")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17001C10")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600BCAC")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600BCA7")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CPlaySE_003Ed__11(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x600BCA8")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x600BCA9")]
		[Address(RVA = "0x591220", Offset = "0x590420", VA = "0x180591220", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600BCAB")]
		[Address(RVA = "0x5913E0", Offset = "0x5905E0", VA = "0x1805913E0", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x4010395")]
	[FieldOffset(Offset = "0x20")]
	private int seId;

	[Token(Token = "0x4010396")]
	[FieldOffset(Offset = "0x24")]
	private float sePan;

	[Token(Token = "0x4010397")]
	[FieldOffset(Offset = "0x28")]
	private MotionModel motion;

	[Token(Token = "0x4010398")]
	[FieldOffset(Offset = "0x30")]
	private Coroutine sePlayCroutine;

	[Token(Token = "0x4010399")]
	[FieldOffset(Offset = "0x38")]
	private bool enableSE;

	[Token(Token = "0x401039A")]
	[FieldOffset(Offset = "0x3C")]
	public float delay;

	[Token(Token = "0x401039B")]
	[FieldOffset(Offset = "0x40")]
	public string seLabel;

	[Token(Token = "0x600BCA1")]
	[Address(RVA = "0x582FB0", Offset = "0x5821B0", VA = "0x180582FB0")]
	private void Awake()
	{
	}

	[Token(Token = "0x600BCA2")]
	[Address(RVA = "0x5831D0", Offset = "0x5823D0", VA = "0x1805831D0")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x600BCA3")]
	[Address(RVA = "0x583150", Offset = "0x582350", VA = "0x180583150")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x600BCA4")]
	[Address(RVA = "0x583050", Offset = "0x582250", VA = "0x180583050")]
	public void OnDestroy()
	{
	}

	[Token(Token = "0x600BCA5")]
	[Address(RVA = "0x583250", Offset = "0x582450", VA = "0x180583250")]
	[IteratorStateMachine(typeof(_003CPlaySE_003Ed__11))]
	private IEnumerator PlaySE()
	{
		return null;
	}

	[Token(Token = "0x600BCA6")]
	[Address(RVA = "0x5832C0", Offset = "0x5824C0", VA = "0x1805832C0")]
	public BgObjectSEController()
	{
	}
}
