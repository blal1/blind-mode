using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace YgomGame.Menu;

[Token(Token = "0x20013CB")]
public class PvpMenuMatchingWcs : PvpMenuMatchingBase
{
	[Token(Token = "0x20013CC")]
	[CompilerGenerated]
	private sealed class _003CyWaitMatching_003Ed__3 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400C3CD")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400C3CE")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400C3CF")]
		[FieldOffset(Offset = "0x20")]
		public PvpMenuMatchingWcs _003C_003E4__this;

		[Token(Token = "0x400C3D0")]
		[FieldOffset(Offset = "0x28")]
		public Action callback;

		[Token(Token = "0x170012ED")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6007B1E")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170012EE")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6007B20")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6007B1B")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CyWaitMatching_003Ed__3(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6007B1C")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6007B1D")]
		[Address(RVA = "0xC52B40", Offset = "0xC51D40", VA = "0x180C52B40", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6007B1F")]
		[Address(RVA = "0xC52DF0", Offset = "0xC51FF0", VA = "0x180C52DF0", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x400C3CB")]
	[FieldOffset(Offset = "0x40")]
	private int wcs_id;

	[Token(Token = "0x400C3CC")]
	[FieldOffset(Offset = "0x44")]
	private float m_ProgressCount;

	[Token(Token = "0x6007B14")]
	[Address(RVA = "0xC44930", Offset = "0xC43B30", VA = "0x180C44930", Slot = "7")]
	public override int ProgressCount()
	{
		return default(int);
	}

	[Token(Token = "0x6007B15")]
	[Address(RVA = "0xC48040", Offset = "0xC47240", VA = "0x180C48040", Slot = "5")]
	public override void StartMatching(Dictionary<string, object> param)
	{
	}

	[Token(Token = "0x6007B16")]
	[Address(RVA = "0xC48300", Offset = "0xC47500", VA = "0x180C48300", Slot = "8")]
	[IteratorStateMachine(typeof(_003CyWaitMatching_003Ed__3))]
	public override IEnumerator yWaitMatching(Action callback)
	{
		return null;
	}

	[Token(Token = "0x6007B17")]
	[Address(RVA = "0xC47F40", Offset = "0xC47140", VA = "0x180C47F40", Slot = "10")]
	public override void SetBootDuelParam(ref Dictionary<string, object> param)
	{
	}

	[Token(Token = "0x6007B18")]
	[Address(RVA = "0xC44370", Offset = "0xC43570", VA = "0x180C44370")]
	public PvpMenuMatchingWcs()
	{
	}
}
