using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace YgomGame.Menu;

[Token(Token = "0x20013AF")]
public class PvpMenuMatchingDiceRally : PvpMenuMatchingBase
{
	[Token(Token = "0x20013B0")]
	[CompilerGenerated]
	private sealed class _003CyWaitMatching_003Ed__4 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400C37C")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400C37D")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400C37E")]
		[FieldOffset(Offset = "0x20")]
		public PvpMenuMatchingDiceRally _003C_003E4__this;

		[Token(Token = "0x400C37F")]
		[FieldOffset(Offset = "0x28")]
		public Action callback;

		[Token(Token = "0x170012D3")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6007A6E")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170012D4")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6007A70")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6007A6B")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CyWaitMatching_003Ed__4(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6007A6C")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6007A6D")]
		[Address(RVA = "0xC53270", Offset = "0xC52470", VA = "0x180C53270", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6007A6F")]
		[Address(RVA = "0xC53600", Offset = "0xC52800", VA = "0x180C53600", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x400C379")]
	[FieldOffset(Offset = "0x40")]
	private int drid;

	[Token(Token = "0x400C37A")]
	[FieldOffset(Offset = "0x44")]
	private int rentalState;

	[Token(Token = "0x400C37B")]
	[FieldOffset(Offset = "0x48")]
	private float m_ProgressCount;

	[Token(Token = "0x6007A64")]
	[Address(RVA = "0xC43E80", Offset = "0xC43080", VA = "0x180C43E80", Slot = "7")]
	public override int ProgressCount()
	{
		return default(int);
	}

	[Token(Token = "0x6007A65")]
	[Address(RVA = "0xC44020", Offset = "0xC43220", VA = "0x180C44020", Slot = "5")]
	public override void StartMatching(Dictionary<string, object> param)
	{
	}

	[Token(Token = "0x6007A66")]
	[Address(RVA = "0xC44380", Offset = "0xC43580", VA = "0x180C44380", Slot = "8")]
	[IteratorStateMachine(typeof(_003CyWaitMatching_003Ed__4))]
	public override IEnumerator yWaitMatching(Action callback)
	{
		return null;
	}

	[Token(Token = "0x6007A67")]
	[Address(RVA = "0xC43EE0", Offset = "0xC430E0", VA = "0x180C43EE0", Slot = "10")]
	public override void SetBootDuelParam(ref Dictionary<string, object> param)
	{
	}

	[Token(Token = "0x6007A68")]
	[Address(RVA = "0xC44370", Offset = "0xC43570", VA = "0x180C44370")]
	public PvpMenuMatchingDiceRally()
	{
	}
}
