using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using YgomSystem.ElementSystem;

[Token(Token = "0x2000020")]
public class TutorialNavigatorSimpleTest : MonoBehaviour
{
	[Token(Token = "0x2000024")]
	[CompilerGenerated]
	private sealed class _003CCallDelay_003Ed__7 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000091")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4000092")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4000093")]
		[FieldOffset(Offset = "0x20")]
		public float delaySec;

		[Token(Token = "0x4000094")]
		[FieldOffset(Offset = "0x28")]
		public Action action;

		[Token(Token = "0x1700000B")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x60000B6")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700000C")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60000B8")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60000B3")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CCallDelay_003Ed__7(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x60000B4")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x60000B5")]
		[Address(RVA = "0x3E7D70", Offset = "0x3E6F70", VA = "0x1803E7D70", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60000B7")]
		[Address(RVA = "0x3E7E40", Offset = "0x3E7040", VA = "0x1803E7E40", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x2000025")]
	[CompilerGenerated]
	private sealed class _003CStart_003Ed__1 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000095")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4000096")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4000097")]
		[FieldOffset(Offset = "0x20")]
		public TutorialNavigatorSimpleTest _003C_003E4__this;

		[Token(Token = "0x1700000D")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x60000BC")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700000E")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60000BE")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60000B9")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CStart_003Ed__1(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x60000BA")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x60000BB")]
		[Address(RVA = "0x3E9F60", Offset = "0x3E9160", VA = "0x1803E9F60", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60000BD")]
		[Address(RVA = "0x3EA500", Offset = "0x3E9700", VA = "0x1803EA500", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x400008A")]
	[FieldOffset(Offset = "0x20")]
	private ElementObjectManager _eoManager;

	[Token(Token = "0x60000A2")]
	[Address(RVA = "0x3E6CB0", Offset = "0x3E5EB0", VA = "0x1803E6CB0")]
	[IteratorStateMachine(typeof(_003CStart_003Ed__1))]
	private IEnumerator Start()
	{
		return null;
	}

	[Token(Token = "0x60000A3")]
	[Address(RVA = "0x3E6C70", Offset = "0x3E5E70", VA = "0x1803E6C70")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x60000A4")]
	[Address(RVA = "0x3E74C0", Offset = "0x3E66C0", VA = "0x1803E74C0")]
	private void TestClear()
	{
	}

	[Token(Token = "0x60000A5")]
	[Address(RVA = "0x3E6D20", Offset = "0x3E5F20", VA = "0x1803E6D20")]
	private void Test1()
	{
	}

	[Token(Token = "0x60000A6")]
	[Address(RVA = "0x3E6FB0", Offset = "0x3E61B0", VA = "0x1803E6FB0")]
	private void Test2()
	{
	}

	[Token(Token = "0x60000A7")]
	[Address(RVA = "0x3E71F0", Offset = "0x3E63F0", VA = "0x1803E71F0")]
	private void Test3()
	{
	}

	[Token(Token = "0x60000A8")]
	[Address(RVA = "0x3E6BF0", Offset = "0x3E5DF0", VA = "0x1803E6BF0")]
	[IteratorStateMachine(typeof(_003CCallDelay_003Ed__7))]
	private IEnumerator CallDelay(float delaySec, Action action)
	{
		return null;
	}

	[Token(Token = "0x60000A9")]
	[Address(RVA = "0x3D2BD0", Offset = "0x3D1DD0", VA = "0x1803D2BD0")]
	public TutorialNavigatorSimpleTest()
	{
	}
}
