using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace YgomGame.Menu;

[Token(Token = "0x20013BF")]
public class PvpMenuMatchingRDC : PvpMenuMatchingBase
{
	[Token(Token = "0x20013C0")]
	[CompilerGenerated]
	private sealed class _003CyWaitMatching_003Ed__4 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400C3B0")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400C3B1")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400C3B2")]
		[FieldOffset(Offset = "0x20")]
		public PvpMenuMatchingRDC _003C_003E4__this;

		[Token(Token = "0x400C3B3")]
		[FieldOffset(Offset = "0x28")]
		public Action callback;

		[Token(Token = "0x170012E3")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6007AD5")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170012E4")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6007AD7")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6007AD2")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CyWaitMatching_003Ed__4(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6007AD3")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6007AD4")]
		[Address(RVA = "0xC52F40", Offset = "0xC52140", VA = "0x180C52F40", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6007AD6")]
		[Address(RVA = "0xC53580", Offset = "0xC52780", VA = "0x180C53580", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x400C3AD")]
	[FieldOffset(Offset = "0x40")]
	private int rdcid;

	[Token(Token = "0x400C3AE")]
	[FieldOffset(Offset = "0x44")]
	private int rentalState;

	[Token(Token = "0x400C3AF")]
	[FieldOffset(Offset = "0x48")]
	private float m_ProgressCount;

	[Token(Token = "0x6007ACB")]
	[Address(RVA = "0xC43E80", Offset = "0xC43080", VA = "0x180C43E80", Slot = "7")]
	public override int ProgressCount()
	{
		return default(int);
	}

	[Token(Token = "0x6007ACC")]
	[Address(RVA = "0xC456E0", Offset = "0xC448E0", VA = "0x180C456E0", Slot = "5")]
	public override void StartMatching(Dictionary<string, object> param)
	{
	}

	[Token(Token = "0x6007ACD")]
	[Address(RVA = "0xC45A30", Offset = "0xC44C30", VA = "0x180C45A30", Slot = "8")]
	[IteratorStateMachine(typeof(_003CyWaitMatching_003Ed__4))]
	public override IEnumerator yWaitMatching(Action callback)
	{
		return null;
	}

	[Token(Token = "0x6007ACE")]
	[Address(RVA = "0xC455A0", Offset = "0xC447A0", VA = "0x180C455A0", Slot = "10")]
	public override void SetBootDuelParam(ref Dictionary<string, object> param)
	{
	}

	[Token(Token = "0x6007ACF")]
	[Address(RVA = "0xC44370", Offset = "0xC43570", VA = "0x180C44370")]
	public PvpMenuMatchingRDC()
	{
	}
}
