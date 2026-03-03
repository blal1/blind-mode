using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace YgomGame.Bg;

[Token(Token = "0x2001D9C")]
public class CharacterStateControl : StateMachineBehaviour
{
	[Token(Token = "0x2001D9E")]
	[CompilerGenerated]
	private sealed class _003CObjectActiveControlChangePreHide_003Ed__5 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x401046B")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x401046C")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x401046D")]
		[FieldOffset(Offset = "0x20")]
		public CharacterObjectControl.OnStateEnterControl ctl;

		[Token(Token = "0x401046E")]
		[FieldOffset(Offset = "0x28")]
		public CharacterObjectControl octl;

		[Token(Token = "0x17001C24")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x600BD92")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17001C25")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600BD94")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600BD8F")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CObjectActiveControlChangePreHide_003Ed__5(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x600BD90")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x600BD91")]
		[Address(RVA = "0x5905B0", Offset = "0x58F7B0", VA = "0x1805905B0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600BD93")]
		[Address(RVA = "0x590830", Offset = "0x58FA30", VA = "0x180590830", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x2001D9F")]
	[CompilerGenerated]
	private sealed class _003CObjectActiveControlOnStateEnter_003Ed__4 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x401046F")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4010470")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4010471")]
		[FieldOffset(Offset = "0x20")]
		public CharacterObjectControl.OnStateEnterControl ctl;

		[Token(Token = "0x17001C26")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x600BD98")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17001C27")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600BD9A")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600BD95")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CObjectActiveControlOnStateEnter_003Ed__4(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x600BD96")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x600BD97")]
		[Address(RVA = "0x590870", Offset = "0x58FA70", VA = "0x180590870", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600BD99")]
		[Address(RVA = "0x590BB0", Offset = "0x58FDB0", VA = "0x180590BB0", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x4010467")]
	[FieldOffset(Offset = "0x18")]
	public bool weightChange;

	[Token(Token = "0x4010468")]
	[FieldOffset(Offset = "0x1C")]
	public float weighValue;

	[Token(Token = "0x4010469")]
	[FieldOffset(Offset = "0x20")]
	public List<string> controlLabelList;

	[Token(Token = "0x600BD89")]
	[Address(RVA = "0x589080", Offset = "0x588280", VA = "0x180589080", Slot = "4")]
	public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
	}

	[Token(Token = "0x600BD8A")]
	[Address(RVA = "0x589010", Offset = "0x588210", VA = "0x180589010")]
	[IteratorStateMachine(typeof(_003CObjectActiveControlOnStateEnter_003Ed__4))]
	private IEnumerator ObjectActiveControlOnStateEnter(CharacterObjectControl.OnStateEnterControl ctl)
	{
		return null;
	}

	[Token(Token = "0x600BD8B")]
	[Address(RVA = "0x588F80", Offset = "0x588180", VA = "0x180588F80")]
	[IteratorStateMachine(typeof(_003CObjectActiveControlChangePreHide_003Ed__5))]
	private IEnumerator ObjectActiveControlChangePreHide(CharacterObjectControl.OnStateEnterControl ctl, CharacterObjectControl octl)
	{
		return null;
	}

	[Token(Token = "0x600BD8C")]
	[Address(RVA = "0x589400", Offset = "0x588600", VA = "0x180589400")]
	public CharacterStateControl()
	{
	}
}
