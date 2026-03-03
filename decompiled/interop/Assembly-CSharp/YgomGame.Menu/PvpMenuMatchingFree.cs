using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace YgomGame.Menu;

[Token(Token = "0x20013B7")]
public class PvpMenuMatchingFree : PvpMenuMatchingBase
{
	[Token(Token = "0x20013B8")]
	[CompilerGenerated]
	private sealed class _003CyWaitMatching_003Ed__2 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400C395")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400C396")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400C397")]
		[FieldOffset(Offset = "0x20")]
		public PvpMenuMatchingFree _003C_003E4__this;

		[Token(Token = "0x400C398")]
		[FieldOffset(Offset = "0x28")]
		public Action callback;

		[Token(Token = "0x170012DB")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6007AA1")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170012DC")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6007AA3")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6007A9E")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CyWaitMatching_003Ed__2(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6007A9F")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6007AA0")]
		[Address(RVA = "0xC524F0", Offset = "0xC516F0", VA = "0x180C524F0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6007AA2")]
		[Address(RVA = "0xC528E0", Offset = "0xC51AE0", VA = "0x180C528E0", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x400C394")]
	[FieldOffset(Offset = "0x40")]
	private float m_ProgressCount;

	[Token(Token = "0x6007A97")]
	[Address(RVA = "0xB9EDB0", Offset = "0xB9DFB0", VA = "0x180B9EDB0", Slot = "7")]
	public override int ProgressCount()
	{
		return default(int);
	}

	[Token(Token = "0x6007A98")]
	[Address(RVA = "0xC453A0", Offset = "0xC445A0", VA = "0x180C453A0", Slot = "5")]
	public override void StartMatching(Dictionary<string, object> param)
	{
	}

	[Token(Token = "0x6007A99")]
	[Address(RVA = "0xC45510", Offset = "0xC44710", VA = "0x180C45510", Slot = "8")]
	[IteratorStateMachine(typeof(_003CyWaitMatching_003Ed__2))]
	public override IEnumerator yWaitMatching(Action callback)
	{
		return null;
	}

	[Token(Token = "0x6007A9A")]
	[Address(RVA = "0xC45300", Offset = "0xC44500", VA = "0x180C45300", Slot = "10")]
	public override void SetBootDuelParam(ref Dictionary<string, object> param)
	{
	}

	[Token(Token = "0x6007A9B")]
	[Address(RVA = "0xC44370", Offset = "0xC43570", VA = "0x180C44370")]
	public PvpMenuMatchingFree()
	{
	}
}
