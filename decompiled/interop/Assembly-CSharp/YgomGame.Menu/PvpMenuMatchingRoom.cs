using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace YgomGame.Menu;

[Token(Token = "0x20013C1")]
public class PvpMenuMatchingRoom : PvpMenuMatchingBase
{
	[Token(Token = "0x20013C2")]
	[CompilerGenerated]
	private sealed class _003CyWaitMatching_003Ed__2 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400C3B5")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400C3B6")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400C3B7")]
		[FieldOffset(Offset = "0x20")]
		public PvpMenuMatchingRoom _003C_003E4__this;

		[Token(Token = "0x400C3B8")]
		[FieldOffset(Offset = "0x28")]
		public Action callback;

		[Token(Token = "0x170012E5")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6007AE2")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170012E6")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6007AE4")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6007ADF")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CyWaitMatching_003Ed__2(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6007AE0")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6007AE1")]
		[Address(RVA = "0xC52600", Offset = "0xC51800", VA = "0x180C52600", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6007AE3")]
		[Address(RVA = "0xC52860", Offset = "0xC51A60", VA = "0x180C52860", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x400C3B4")]
	[FieldOffset(Offset = "0x40")]
	private float m_ProgressCount;

	[Token(Token = "0x6007AD8")]
	[Address(RVA = "0xB9EDB0", Offset = "0xB9DFB0", VA = "0x180B9EDB0", Slot = "7")]
	public override int ProgressCount()
	{
		return default(int);
	}

	[Token(Token = "0x6007AD9")]
	[Address(RVA = "0xC469F0", Offset = "0xC45BF0", VA = "0x180C469F0", Slot = "5")]
	public override void StartMatching(Dictionary<string, object> param)
	{
	}

	[Token(Token = "0x6007ADA")]
	[Address(RVA = "0xC46B60", Offset = "0xC45D60", VA = "0x180C46B60", Slot = "8")]
	[IteratorStateMachine(typeof(_003CyWaitMatching_003Ed__2))]
	public override IEnumerator yWaitMatching(Action callback)
	{
		return null;
	}

	[Token(Token = "0x6007ADB")]
	[Address(RVA = "0xC46950", Offset = "0xC45B50", VA = "0x180C46950", Slot = "10")]
	public override void SetBootDuelParam(ref Dictionary<string, object> param)
	{
	}

	[Token(Token = "0x6007ADC")]
	[Address(RVA = "0xC44370", Offset = "0xC43570", VA = "0x180C44370")]
	public PvpMenuMatchingRoom()
	{
	}
}
