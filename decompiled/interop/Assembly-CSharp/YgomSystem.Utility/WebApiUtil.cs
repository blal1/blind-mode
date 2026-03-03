using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using YgomSystem.Network;

namespace YgomSystem.Utility;

[Token(Token = "0x2000426")]
public static class WebApiUtil
{
	[Token(Token = "0x2000427")]
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass1_0
	{
		[Token(Token = "0x400146C")]
		[FieldOffset(Offset = "0x10")]
		public int resultCode;

		[Token(Token = "0x6001AC5")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public _003C_003Ec__DisplayClass1_0()
		{
		}

		[Token(Token = "0x6001AC6")]
		[Address(RVA = "0x5F4420", Offset = "0x5F3620", VA = "0x1805F4420")]
		internal void _003CCallCoroutine_003Eb__0(Handle handle)
		{
		}
	}

	[Token(Token = "0x2000429")]
	[CompilerGenerated]
	private sealed class _003CCallCoroutine_003Ed__1 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400146E")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400146F")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4001470")]
		[FieldOffset(Offset = "0x20")]
		public Handle apiHandle;

		[Token(Token = "0x4001471")]
		[FieldOffset(Offset = "0x28")]
		public Action<int> resultCallback;

		[Token(Token = "0x4001472")]
		[FieldOffset(Offset = "0x30")]
		private _003C_003Ec__DisplayClass1_0 _003C_003E8__1;

		[Token(Token = "0x17000274")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6001ACC")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000275")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6001ACE")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6001AC9")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CCallCoroutine_003Ed__1(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6001ACA")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6001ACB")]
		[Address(RVA = "0x5F37A0", Offset = "0x5F29A0", VA = "0x1805F37A0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6001ACD")]
		[Address(RVA = "0x5F3920", Offset = "0x5F2B20", VA = "0x1805F3920", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x400146B")]
	private const int NETWORK_ERROR = -1;

	[Token(Token = "0x6001AC3")]
	[Address(RVA = "0x5F9D50", Offset = "0x5F8F50", VA = "0x1805F9D50")]
	[IteratorStateMachine(typeof(_003CCallCoroutine_003Ed__1))]
	public static IEnumerator CallCoroutine(Handle apiHandle, Action<int> resultCallback)
	{
		return null;
	}

	[Token(Token = "0x6001AC4")]
	[Address(RVA = "0x5F9DE0", Offset = "0x5F8FE0", VA = "0x1805F9DE0")]
	public static void Call(Handle apiHandle, Action<int> resultCallback)
	{
	}
}
