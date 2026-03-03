using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace YgomGame.Menu;

[Token(Token = "0x20013B5")]
public class PvpMenuMatchingExhibition : PvpMenuMatchingBase
{
	[Token(Token = "0x20013B6")]
	[CompilerGenerated]
	private sealed class _003CyWaitMatching_003Ed__4 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400C390")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400C391")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400C392")]
		[FieldOffset(Offset = "0x20")]
		public PvpMenuMatchingExhibition _003C_003E4__this;

		[Token(Token = "0x400C393")]
		[FieldOffset(Offset = "0x28")]
		public Action callback;

		[Token(Token = "0x170012D9")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6007A94")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170012DA")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6007A96")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6007A91")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CyWaitMatching_003Ed__4(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6007A92")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6007A93")]
		[Address(RVA = "0xC53050", Offset = "0xC52250", VA = "0x180C53050", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6007A95")]
		[Address(RVA = "0xC53540", Offset = "0xC52740", VA = "0x180C53540", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x400C38D")]
	[FieldOffset(Offset = "0x40")]
	private int exhid;

	[Token(Token = "0x400C38E")]
	[FieldOffset(Offset = "0x44")]
	private int rentalState;

	[Token(Token = "0x400C38F")]
	[FieldOffset(Offset = "0x48")]
	private float m_ProgressCount;

	[Token(Token = "0x6007A8A")]
	[Address(RVA = "0xC43E80", Offset = "0xC43080", VA = "0x180C43E80", Slot = "7")]
	public override int ProgressCount()
	{
		return default(int);
	}

	[Token(Token = "0x6007A8B")]
	[Address(RVA = "0xC44F20", Offset = "0xC44120", VA = "0x180C44F20", Slot = "5")]
	public override void StartMatching(Dictionary<string, object> param)
	{
	}

	[Token(Token = "0x6007A8C")]
	[Address(RVA = "0xC45270", Offset = "0xC44470", VA = "0x180C45270", Slot = "8")]
	[IteratorStateMachine(typeof(_003CyWaitMatching_003Ed__4))]
	public override IEnumerator yWaitMatching(Action callback)
	{
		return null;
	}

	[Token(Token = "0x6007A8D")]
	[Address(RVA = "0xC44DE0", Offset = "0xC43FE0", VA = "0x180C44DE0", Slot = "10")]
	public override void SetBootDuelParam(ref Dictionary<string, object> param)
	{
	}

	[Token(Token = "0x6007A8E")]
	[Address(RVA = "0xC44370", Offset = "0xC43570", VA = "0x180C44370")]
	public PvpMenuMatchingExhibition()
	{
	}
}
