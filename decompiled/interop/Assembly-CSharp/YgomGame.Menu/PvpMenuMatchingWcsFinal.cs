using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace YgomGame.Menu;

[Token(Token = "0x20013CD")]
public class PvpMenuMatchingWcsFinal : PvpMenuMatchingBase
{
	[Token(Token = "0x20013CE")]
	[CompilerGenerated]
	private sealed class _003CyWaitMatching_003Ed__2 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400C3D2")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400C3D3")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400C3D4")]
		[FieldOffset(Offset = "0x20")]
		public PvpMenuMatchingWcsFinal _003C_003E4__this;

		[Token(Token = "0x400C3D5")]
		[FieldOffset(Offset = "0x28")]
		public Action callback;

		[Token(Token = "0x170012EF")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6007B2B")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170012F0")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6007B2D")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6007B28")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CyWaitMatching_003Ed__2(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6007B29")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6007B2A")]
		[Address(RVA = "0xC52710", Offset = "0xC51910", VA = "0x180C52710", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6007B2C")]
		[Address(RVA = "0xC528A0", Offset = "0xC51AA0", VA = "0x180C528A0", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x400C3D1")]
	[FieldOffset(Offset = "0x40")]
	private float m_ProgressCount;

	[Token(Token = "0x6007B21")]
	[Address(RVA = "0xB9EDB0", Offset = "0xB9DFB0", VA = "0x180B9EDB0", Slot = "7")]
	public override int ProgressCount()
	{
		return default(int);
	}

	[Token(Token = "0x6007B22")]
	[Address(RVA = "0xC47D40", Offset = "0xC46F40", VA = "0x180C47D40", Slot = "5")]
	public override void StartMatching(Dictionary<string, object> param)
	{
	}

	[Token(Token = "0x6007B23")]
	[Address(RVA = "0xC47EB0", Offset = "0xC470B0", VA = "0x180C47EB0", Slot = "8")]
	[IteratorStateMachine(typeof(_003CyWaitMatching_003Ed__2))]
	public override IEnumerator yWaitMatching(Action callback)
	{
		return null;
	}

	[Token(Token = "0x6007B24")]
	[Address(RVA = "0xC47CA0", Offset = "0xC46EA0", VA = "0x180C47CA0", Slot = "10")]
	public override void SetBootDuelParam(ref Dictionary<string, object> param)
	{
	}

	[Token(Token = "0x6007B25")]
	[Address(RVA = "0xC44370", Offset = "0xC43570", VA = "0x180C44370")]
	public PvpMenuMatchingWcsFinal()
	{
	}
}
