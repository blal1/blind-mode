using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using YgomSystem.Network;

namespace YgomSystem.Utility;

[Token(Token = "0x200042A")]
public class WebAPIQueue
{
	[Token(Token = "0x200042B")]
	private class RequestEntry
	{
		[Token(Token = "0x4001477")]
		[FieldOffset(Offset = "0x10")]
		public Func<Handle> createHandle;

		[Token(Token = "0x4001478")]
		[FieldOffset(Offset = "0x18")]
		public Action<int> resultCallback;

		[Token(Token = "0x6001AD4")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public RequestEntry()
		{
		}
	}

	[Token(Token = "0x200042C")]
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass8_0
	{
		[Token(Token = "0x4001479")]
		[FieldOffset(Offset = "0x10")]
		public int apiCode;

		[Token(Token = "0x6001AD5")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public _003C_003Ec__DisplayClass8_0()
		{
		}

		[Token(Token = "0x6001AD6")]
		[Address(RVA = "0x5F4710", Offset = "0x5F3910", VA = "0x1805F4710")]
		internal void _003Cprocess_003Eb__0(int res)
		{
		}
	}

	[Token(Token = "0x200042D")]
	[CompilerGenerated]
	private sealed class _003Cprocess_003Ed__8 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400147A")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400147B")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400147C")]
		[FieldOffset(Offset = "0x20")]
		public WebAPIQueue _003C_003E4__this;

		[Token(Token = "0x400147D")]
		[FieldOffset(Offset = "0x28")]
		private _003C_003Ec__DisplayClass8_0 _003C_003E8__1;

		[Token(Token = "0x17000276")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6001ADA")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000277")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6001ADC")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6001AD7")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003Cprocess_003Ed__8(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6001AD8")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6001AD9")]
		[Address(RVA = "0x5F4870", Offset = "0x5F3A70", VA = "0x1805F4870", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6001ADB")]
		[Address(RVA = "0x5F4B60", Offset = "0x5F3D60", VA = "0x1805F4B60", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x4001473")]
	[FieldOffset(Offset = "0x10")]
	private Queue<RequestEntry> m_queue;

	[Token(Token = "0x4001474")]
	[FieldOffset(Offset = "0x18")]
	private RequestEntry m_current;

	[Token(Token = "0x4001475")]
	[FieldOffset(Offset = "0x20")]
	private IEnumerator m_process;

	[Token(Token = "0x4001476")]
	[FieldOffset(Offset = "0x28")]
	private bool m_abort;

	[Token(Token = "0x6001ACF")]
	[Address(RVA = "0x5F9BD0", Offset = "0x5F8DD0", VA = "0x1805F9BD0")]
	public void StartProcess()
	{
	}

	[Token(Token = "0x6001AD0")]
	[Address(RVA = "0x5F9AF0", Offset = "0x5F8CF0", VA = "0x1805F9AF0")]
	public bool AddRequest(Func<Handle> createHandle, Action<int> resultCallback)
	{
		return default(bool);
	}

	[Token(Token = "0x6001AD1")]
	[Address(RVA = "0x5F9A60", Offset = "0x5F8C60", VA = "0x1805F9A60")]
	public void Abort()
	{
	}

	[Token(Token = "0x6001AD2")]
	[Address(RVA = "0x5F9CE0", Offset = "0x5F8EE0", VA = "0x1805F9CE0")]
	[IteratorStateMachine(typeof(_003Cprocess_003Ed__8))]
	private IEnumerator process()
	{
		return null;
	}

	[Token(Token = "0x6001AD3")]
	[Address(RVA = "0x5F9C60", Offset = "0x5F8E60", VA = "0x1805F9C60")]
	public WebAPIQueue()
	{
	}
}
