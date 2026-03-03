using System;
using AOT;
using Il2CppDummyDll;

namespace YgomGame.Duel;

[Token(Token = "0x200182F")]
public class ReplayStream : ReplayBase
{
	[Token(Token = "0x400E2CA")]
	[FieldOffset(Offset = "0x0")]
	public static ReplayStream s_instance;

	[Token(Token = "0x60099B5")]
	[Address(RVA = "0xE3C3F0", Offset = "0xE3B5F0", VA = "0x180E3C3F0")]
	public ReplayStream()
	{
	}

	[Token(Token = "0x60099B6")]
	[Address(RVA = "0xE3BAE0", Offset = "0xE3ACE0", VA = "0x180E3BAE0")]
	public void Destroy()
	{
	}

	[Token(Token = "0x60099B7")]
	[Address(RVA = "0xE3BC10", Offset = "0xE3AE10", VA = "0x180E3BC10", Slot = "4")]
	public override void InitReplay()
	{
	}

	[Token(Token = "0x60099B8")]
	[Address(RVA = "0xE3C090", Offset = "0xE3B290", VA = "0x180E3C090")]
	public bool IsQueued()
	{
		return default(bool);
	}

	[Token(Token = "0x60099B9")]
	[Address(RVA = "0xE3B9B0", Offset = "0xE3ABB0", VA = "0x180E3B9B0")]
	public void Add(byte[] data)
	{
	}

	[Token(Token = "0x60099BA")]
	[Address(RVA = "0xE3C1E0", Offset = "0xE3B3E0", VA = "0x180E3C1E0")]
	[MonoPInvokeCallback(typeof(Engine.NowRecord))]
	public static IntPtr NowRecord()
	{
		return default(IntPtr);
	}

	[Token(Token = "0x60099BB")]
	[Address(RVA = "0xE3C340", Offset = "0xE3B540", VA = "0x180E3C340")]
	[MonoPInvokeCallback(typeof(Engine.RecordNext))]
	public static void RecordNext()
	{
	}

	[Token(Token = "0x60099BC")]
	[Address(RVA = "0xE3C300", Offset = "0xE3B500", VA = "0x180E3C300")]
	[MonoPInvokeCallback(typeof(Engine.RecordBegin))]
	public static void RecordBegin()
	{
	}

	[Token(Token = "0x60099BD")]
	[Address(RVA = "0xE3C0E0", Offset = "0xE3B2E0", VA = "0x180E3C0E0")]
	[MonoPInvokeCallback(typeof(Engine.IsRecordEnd))]
	public static int IsRecordEnd()
	{
		return default(int);
	}
}
