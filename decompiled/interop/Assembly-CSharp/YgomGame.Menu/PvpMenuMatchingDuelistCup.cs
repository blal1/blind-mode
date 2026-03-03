using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace YgomGame.Menu;

[Token(Token = "0x20013B1")]
public class PvpMenuMatchingDuelistCup : PvpMenuMatchingBase
{
	[Token(Token = "0x20013B2")]
	[CompilerGenerated]
	private sealed class _003CyWaitMatching_003Ed__3 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400C382")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400C383")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400C384")]
		[FieldOffset(Offset = "0x20")]
		public PvpMenuMatchingDuelistCup _003C_003E4__this;

		[Token(Token = "0x400C385")]
		[FieldOffset(Offset = "0x28")]
		public Action callback;

		[Token(Token = "0x170012D5")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6007A7B")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170012D6")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6007A7D")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6007A78")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CyWaitMatching_003Ed__3(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6007A79")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6007A7A")]
		[Address(RVA = "0xC52920", Offset = "0xC51B20", VA = "0x180C52920", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6007A7C")]
		[Address(RVA = "0xC52D30", Offset = "0xC51F30", VA = "0x180C52D30", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x400C380")]
	[FieldOffset(Offset = "0x40")]
	private int cid;

	[Token(Token = "0x400C381")]
	[FieldOffset(Offset = "0x44")]
	private float m_ProgressCount;

	[Token(Token = "0x6007A71")]
	[Address(RVA = "0xC44930", Offset = "0xC43B30", VA = "0x180C44930", Slot = "7")]
	public override int ProgressCount()
	{
		return default(int);
	}

	[Token(Token = "0x6007A72")]
	[Address(RVA = "0xC44A90", Offset = "0xC43C90", VA = "0x180C44A90", Slot = "5")]
	public override void StartMatching(Dictionary<string, object> param)
	{
	}

	[Token(Token = "0x6007A73")]
	[Address(RVA = "0xC44D50", Offset = "0xC43F50", VA = "0x180C44D50", Slot = "8")]
	[IteratorStateMachine(typeof(_003CyWaitMatching_003Ed__3))]
	public override IEnumerator yWaitMatching(Action callback)
	{
		return null;
	}

	[Token(Token = "0x6007A74")]
	[Address(RVA = "0xC44990", Offset = "0xC43B90", VA = "0x180C44990", Slot = "10")]
	public override void SetBootDuelParam(ref Dictionary<string, object> param)
	{
	}

	[Token(Token = "0x6007A75")]
	[Address(RVA = "0xC44370", Offset = "0xC43570", VA = "0x180C44370")]
	public PvpMenuMatchingDuelistCup()
	{
	}
}
