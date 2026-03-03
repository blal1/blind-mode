using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace YgomGame.Menu;

[Token(Token = "0x20013BD")]
public class PvpMenuMatchingRate : PvpMenuMatchingBase
{
	[Token(Token = "0x20013BE")]
	[CompilerGenerated]
	private sealed class _003CyWaitMatching_003Ed__4 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400C3A9")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400C3AA")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400C3AB")]
		[FieldOffset(Offset = "0x20")]
		public PvpMenuMatchingRate _003C_003E4__this;

		[Token(Token = "0x400C3AC")]
		[FieldOffset(Offset = "0x28")]
		public Action callback;

		[Token(Token = "0x170012E1")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6007AC8")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170012E2")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6007ACA")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6007AC5")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CyWaitMatching_003Ed__4(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6007AC6")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6007AC7")]
		[Address(RVA = "0xC52E30", Offset = "0xC52030", VA = "0x180C52E30", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6007AC9")]
		[Address(RVA = "0xC53680", Offset = "0xC52880", VA = "0x180C53680", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x400C3A6")]
	[FieldOffset(Offset = "0x40")]
	private int seasonId;

	[Token(Token = "0x400C3A7")]
	[FieldOffset(Offset = "0x44")]
	private int rentalState;

	[Token(Token = "0x400C3A8")]
	[FieldOffset(Offset = "0x48")]
	private float m_ProgressCount;

	[Token(Token = "0x6007ABE")]
	[Address(RVA = "0xC43E80", Offset = "0xC43080", VA = "0x180C43E80", Slot = "7")]
	public override int ProgressCount()
	{
		return default(int);
	}

	[Token(Token = "0x6007ABF")]
	[Address(RVA = "0xC46570", Offset = "0xC45770", VA = "0x180C46570", Slot = "5")]
	public override void StartMatching(Dictionary<string, object> param)
	{
	}

	[Token(Token = "0x6007AC0")]
	[Address(RVA = "0xC468C0", Offset = "0xC45AC0", VA = "0x180C468C0", Slot = "8")]
	[IteratorStateMachine(typeof(_003CyWaitMatching_003Ed__4))]
	public override IEnumerator yWaitMatching(Action callback)
	{
		return null;
	}

	[Token(Token = "0x6007AC1")]
	[Address(RVA = "0xC46430", Offset = "0xC45630", VA = "0x180C46430", Slot = "10")]
	public override void SetBootDuelParam(ref Dictionary<string, object> param)
	{
	}

	[Token(Token = "0x6007AC2")]
	[Address(RVA = "0xC44370", Offset = "0xC43570", VA = "0x180C44370")]
	public PvpMenuMatchingRate()
	{
	}
}
