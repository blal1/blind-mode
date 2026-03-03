using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace YgomGame.DuelLive;

[Token(Token = "0x2000F03")]
public class DuelLiveWCSSetData
{
	[Token(Token = "0x2000F04")]
	[CompilerGenerated]
	private sealed class _003CenumerateReplayKey_003Ed__4 : IEnumerator<string>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400A5B8")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400A5B9")]
		[FieldOffset(Offset = "0x18")]
		private string _003C_003E2__current;

		[Token(Token = "0x400A5BA")]
		[FieldOffset(Offset = "0x20")]
		public DuelLiveWCSSetData _003C_003E4__this;

		[Token(Token = "0x400A5BB")]
		[FieldOffset(Offset = "0x28")]
		private int _003Ci_003E5__2;

		[Token(Token = "0x17000E0D")]
		private string System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EString_003E_002ECurrent
		{
			[Token(Token = "0x6005ADB")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000E0E")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6005ADD")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6005AD8")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CenumerateReplayKey_003Ed__4(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6005AD9")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6005ADA")]
		[Address(RVA = "0xA170A0", Offset = "0xA162A0", VA = "0x180A170A0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6005ADC")]
		[Address(RVA = "0xA17150", Offset = "0xA16350", VA = "0x180A17150", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x400A5B4")]
	[FieldOffset(Offset = "0x10")]
	public int setID;

	[Token(Token = "0x400A5B5")]
	[FieldOffset(Offset = "0x18")]
	public string displayText;

	[Token(Token = "0x400A5B6")]
	private const int ReplayMax = 3;

	[Token(Token = "0x400A5B7")]
	[FieldOffset(Offset = "0x20")]
	private string[] m_replayKeys;

	[Token(Token = "0x6005AD3")]
	[Address(RVA = "0xA13BE0", Offset = "0xA12DE0", VA = "0x180A13BE0")]
	[IteratorStateMachine(typeof(_003CenumerateReplayKey_003Ed__4))]
	private IEnumerator<string> enumerateReplayKey()
	{
		return null;
	}

	[Token(Token = "0x6005AD4")]
	[Address(RVA = "0xA13B60", Offset = "0xA12D60", VA = "0x180A13B60")]
	public DuelLiveWCSSetData(int setID, string displayText)
	{
	}

	[Token(Token = "0x6005AD5")]
	[Address(RVA = "0xA13A10", Offset = "0xA12C10", VA = "0x180A13A10")]
	public void RegisterReplayKey(string replayKey)
	{
	}

	[Token(Token = "0x6005AD6")]
	[Address(RVA = "0xA138B0", Offset = "0xA12AB0", VA = "0x180A138B0")]
	public void GetReplayKeys(Action<string> callback)
	{
	}

	[Token(Token = "0x6005AD7")]
	[Address(RVA = "0xA13820", Offset = "0xA12A20", VA = "0x180A13820")]
	public int GetRegisteredReplayNum()
	{
		return default(int);
	}
}
