using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace YgomGame.Menu;

[Token(Token = "0x20013B3")]
public class PvpMenuMatchingDuelTrial : PvpMenuMatchingBase
{
	[Token(Token = "0x20013B4")]
	[CompilerGenerated]
	private sealed class _003CyWaitMatching_003Ed__4 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400C389")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400C38A")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400C38B")]
		[FieldOffset(Offset = "0x20")]
		public PvpMenuMatchingDuelTrial _003C_003E4__this;

		[Token(Token = "0x400C38C")]
		[FieldOffset(Offset = "0x28")]
		public Action callback;

		[Token(Token = "0x170012D7")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6007A87")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170012D8")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6007A89")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6007A84")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CyWaitMatching_003Ed__4(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6007A85")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6007A86")]
		[Address(RVA = "0xC53460", Offset = "0xC52660", VA = "0x180C53460", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6007A88")]
		[Address(RVA = "0xC53640", Offset = "0xC52840", VA = "0x180C53640", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x400C386")]
	[FieldOffset(Offset = "0x40")]
	public bool goto_cpu;

	[Token(Token = "0x400C387")]
	[FieldOffset(Offset = "0x44")]
	private int tid;

	[Token(Token = "0x400C388")]
	[FieldOffset(Offset = "0x48")]
	private int rentalState;

	[Token(Token = "0x6007A7E")]
	[Address(RVA = "0xC44550", Offset = "0xC43750", VA = "0x180C44550", Slot = "5")]
	public override void StartMatching(Dictionary<string, object> param)
	{
	}

	[Token(Token = "0x6007A7F")]
	[Address(RVA = "0xC448A0", Offset = "0xC43AA0", VA = "0x180C448A0", Slot = "8")]
	[IteratorStateMachine(typeof(_003CyWaitMatching_003Ed__4))]
	public override IEnumerator yWaitMatching(Action callback)
	{
		return null;
	}

	[Token(Token = "0x6007A80")]
	[Address(RVA = "0xC44410", Offset = "0xC43610", VA = "0x180C44410", Slot = "10")]
	public override void SetBootDuelParam(ref Dictionary<string, object> param)
	{
	}

	[Token(Token = "0x6007A81")]
	[Address(RVA = "0xC44370", Offset = "0xC43570", VA = "0x180C44370")]
	public PvpMenuMatchingDuelTrial()
	{
	}
}
