using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace YgomGame.Duel;

[Token(Token = "0x200182E")]
public class ReplayBase
{
	[Token(Token = "0x400E2C3")]
	protected const int ParamSize = 8;

	[Token(Token = "0x400E2C4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	protected IntPtr recordPtr;

	[Token(Token = "0x400E2C5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	protected BlockingQueue<byte[]> replayQueue;

	[Token(Token = "0x400E2C6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	protected BlockingQueue<byte[]> recordQueue;

	[Token(Token = "0x400E2C7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	protected int recordSize;

	[Token(Token = "0x400E2C8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	protected bool isEndReplay;

	[Token(Token = "0x400E2C9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2D")]
	protected bool dataEnd;

	[Token(Token = "0x60099A4")]
	[Address(RVA = "0xE3B430", Offset = "0xE3A630", VA = "0x180E3B430", Slot = "4")]
	public virtual void InitReplay()
	{
	}

	[Token(Token = "0x60099A5")]
	[Address(RVA = "0xE3B370", Offset = "0xE3A570", VA = "0x180E3B370")]
	public void InitRecord()
	{
	}

	[Token(Token = "0x60099A6")]
	[Address(RVA = "0xE3B940", Offset = "0xE3AB40", VA = "0x180E3B940")]
	public void SetRecord([Optional] byte[] dat)
	{
	}

	[Token(Token = "0x60099A7")]
	[Address(RVA = "0xE3B200", Offset = "0xE3A400", VA = "0x180E3B200")]
	public void EndData()
	{
	}

	[Token(Token = "0x60099A8")]
	[Address(RVA = "0x5F5C60", Offset = "0x5F4E60", VA = "0x1805F5C60")]
	public void Finish()
	{
	}

	[Token(Token = "0x60099A9")]
	[Address(RVA = "0xE3B210", Offset = "0xE3A410", VA = "0x180E3B210")]
	public byte[] GetData()
	{
		return null;
	}

	[Token(Token = "0x60099AA")]
	[Address(RVA = "0xE3B110", Offset = "0xE3A310", VA = "0x180E3B110")]
	protected void AllocMemory()
	{
	}

	[Token(Token = "0x60099AB")]
	[Address(RVA = "0xE3B810", Offset = "0xE3AA10", VA = "0x180E3B810")]
	protected void ReleaseMemory()
	{
	}

	[Token(Token = "0x60099AC")]
	[Address(RVA = "0xE3B880", Offset = "0xE3AA80", VA = "0x180E3B880")]
	protected void ReleaseRecordQueue()
	{
	}

	[Token(Token = "0x60099AD")]
	[Address(RVA = "0xE3B8E0", Offset = "0xE3AAE0", VA = "0x180E3B8E0")]
	protected void ReleaseReplayQueue()
	{
	}

	[Token(Token = "0x60099AE")]
	[Address(RVA = "0xE3AF00", Offset = "0xE3A100", VA = "0x180E3AF00")]
	protected bool AddQueueFromData(byte[] data)
	{
		return default(bool);
	}

	[Token(Token = "0x60099AF")]
	[Address(RVA = "0xE3B040", Offset = "0xE3A240", VA = "0x180E3B040")]
	protected void AddRecordImpl(IntPtr ptr, int size)
	{
	}

	[Token(Token = "0x60099B0")]
	[Address(RVA = "0xE3B690", Offset = "0xE3A890", VA = "0x180E3B690")]
	protected IntPtr NowRecordImpl()
	{
		return default(IntPtr);
	}

	[Token(Token = "0x60099B1")]
	[Address(RVA = "0xE3B790", Offset = "0xE3A990", VA = "0x180E3B790")]
	protected void RecordNextImpl()
	{
	}

	[Token(Token = "0x60099B2")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60")]
	protected void RecordBeginImpl()
	{
	}

	[Token(Token = "0x60099B3")]
	[Address(RVA = "0xE3B5C0", Offset = "0xE3A7C0", VA = "0x180E3B5C0")]
	protected int IsRecordEndImpl()
	{
		return default(int);
	}

	[Token(Token = "0x60099B4")]
	[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
	public ReplayBase()
	{
	}
}
