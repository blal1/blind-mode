using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

namespace YgomSystem.Utility;

[Token(Token = "0x20003C5")]
public class CoroutineExecuter : MonoBehaviour
{
	[Token(Token = "0x20003C6")]
	[CompilerGenerated]
	private sealed class _003CCallDelayRoutine_003Ed__9 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4001306")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4001307")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4001308")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float delaySec;

		[Token(Token = "0x4001309")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Action callback;

		[Token(Token = "0x1700024C")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6001819")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700024D")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600181B")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6001816")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CCallDelayRoutine_003Ed__9(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6001817")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6001818")]
		[Address(RVA = "0x5C3770", Offset = "0x5C2970", VA = "0x1805C3770", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600181A")]
		[Address(RVA = "0x5C3830", Offset = "0x5C2A30", VA = "0x1805C3830", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x20003C7")]
	[CompilerGenerated]
	private sealed class _003CCallbackCoroutine_003Ed__7 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400130A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400130B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400130C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Func<bool> func;

		[Token(Token = "0x400130D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Action callback;

		[Token(Token = "0x1700024E")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x600181F")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700024F")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6001821")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600181C")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CCallbackCoroutine_003Ed__7(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x600181D")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x600181E")]
		[Address(RVA = "0x5C3870", Offset = "0x5C2A70", VA = "0x1805C3870", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6001820")]
		[Address(RVA = "0x5C38F0", Offset = "0x5C2AF0", VA = "0x1805C38F0", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x4001305")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static CoroutineExecuter Instance;

	[Token(Token = "0x600180C")]
	[Address(RVA = "0x5BA280", Offset = "0x5B9480", VA = "0x1805BA280")]
	public static Coroutine Run(IEnumerator coroutine)
	{
		return null;
	}

	[Token(Token = "0x600180D")]
	[Address(RVA = "0x5BA380", Offset = "0x5B9580", VA = "0x1805BA380")]
	public static void Terminate(IEnumerator coroutine)
	{
	}

	[Token(Token = "0x600180E")]
	[Address(RVA = "0x5BA3E0", Offset = "0x5B95E0", VA = "0x1805BA3E0")]
	public static void Terminate(Coroutine coroutine)
	{
	}

	[Token(Token = "0x600180F")]
	[Address(RVA = "0x5BA010", Offset = "0x5B9210", VA = "0x1805BA010")]
	private void Awake()
	{
	}

	[Token(Token = "0x6001810")]
	[Address(RVA = "0x5BA230", Offset = "0x5B9430", VA = "0x1805BA230")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6001811")]
	[Address(RVA = "0x5BA2E0", Offset = "0x5B94E0", VA = "0x1805BA2E0")]
	public void StartCallbackCoroutine(Func<bool> func, Action callback)
	{
	}

	[Token(Token = "0x6001812")]
	[Address(RVA = "0x5BA1A0", Offset = "0x5B93A0", VA = "0x1805BA1A0")]
	[IteratorStateMachine(typeof(_003CCallbackCoroutine_003Ed__7))]
	private IEnumerator CallbackCoroutine(Func<bool> func, Action callback)
	{
		return null;
	}

	[Token(Token = "0x6001813")]
	[Address(RVA = "0x5BA0F0", Offset = "0x5B92F0", VA = "0x1805BA0F0")]
	public void CallDelay(Action callback, float delaySec, [Optional] MonoBehaviour caller)
	{
	}

	[Token(Token = "0x6001814")]
	[Address(RVA = "0x5BA070", Offset = "0x5B9270", VA = "0x1805BA070")]
	[IteratorStateMachine(typeof(_003CCallDelayRoutine_003Ed__9))]
	private static IEnumerator CallDelayRoutine(Action callback, float delaySec)
	{
		return null;
	}

	[Token(Token = "0x6001815")]
	[Address(RVA = "0x3D2BD0", Offset = "0x3D1DD0", VA = "0x1803D2BD0")]
	public CoroutineExecuter()
	{
	}
}
