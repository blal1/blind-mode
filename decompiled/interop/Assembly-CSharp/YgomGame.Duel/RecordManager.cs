using System;
using AOT;
using Il2CppDummyDll;

namespace YgomGame.Duel;

[Token(Token = "0x20017A6")]
public class RecordManager : ReplayBase
{
	[Token(Token = "0x400DD92")]
	[FieldOffset(Offset = "0x0")]
	public static RecordManager instance;

	[Token(Token = "0x60094D4")]
	[Address(RVA = "0xDEC9D0", Offset = "0xDEBBD0", VA = "0x180DEC9D0")]
	public RecordManager()
	{
	}

	[Token(Token = "0x60094D5")]
	[Address(RVA = "0xDEC680", Offset = "0xDEB880", VA = "0x180DEC680")]
	public void Destroy()
	{
	}

	[Token(Token = "0x60094D6")]
	[Address(RVA = "0xDEC700", Offset = "0xDEB900", VA = "0x180DEC700", Slot = "4")]
	public override void InitReplay()
	{
	}

	[Token(Token = "0x60094D7")]
	[Address(RVA = "0xDEC9B0", Offset = "0xDEBBB0", VA = "0x180DEC9B0")]
	public void SetReplay(byte[] data)
	{
	}

	[Token(Token = "0x60094D8")]
	[Address(RVA = "0xDEC620", Offset = "0xDEB820", VA = "0x180DEC620")]
	[MonoPInvokeCallback(typeof(Engine.AddRecord))]
	public static void AddRecord(IntPtr ptr, int size)
	{
	}

	[Token(Token = "0x60094D9")]
	[Address(RVA = "0xDEC8C0", Offset = "0xDEBAC0", VA = "0x180DEC8C0")]
	[MonoPInvokeCallback(typeof(Engine.NowRecord))]
	public static IntPtr NowRecord()
	{
		return default(IntPtr);
	}

	[Token(Token = "0x60094DA")]
	[Address(RVA = "0xDEC960", Offset = "0xDEBB60", VA = "0x180DEC960")]
	[MonoPInvokeCallback(typeof(Engine.RecordNext))]
	public static void RecordNext()
	{
	}

	[Token(Token = "0x60094DB")]
	[Address(RVA = "0xDEC910", Offset = "0xDEBB10", VA = "0x180DEC910")]
	[MonoPInvokeCallback(typeof(Engine.RecordBegin))]
	public static void RecordBegin()
	{
	}

	[Token(Token = "0x60094DC")]
	[Address(RVA = "0xDEC870", Offset = "0xDEBA70", VA = "0x180DEC870")]
	[MonoPInvokeCallback(typeof(Engine.IsRecordEnd))]
	public static int IsRecordEnd()
	{
		return default(int);
	}
}
