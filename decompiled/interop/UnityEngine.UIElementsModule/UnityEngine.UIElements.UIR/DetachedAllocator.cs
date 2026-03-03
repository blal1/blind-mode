using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace UnityEngine.UIElements.UIR;

[Token(Token = "0x200051A")]
internal class DetachedAllocator : IDisposable
{
	[Token(Token = "0x40010CF")]
	[FieldOffset(Offset = "0x10")]
	private TempAllocator<Vertex> m_VertsPool;

	[Token(Token = "0x40010D0")]
	[FieldOffset(Offset = "0x18")]
	private TempAllocator<ushort> m_IndexPool;

	[Token(Token = "0x40010D1")]
	[FieldOffset(Offset = "0x20")]
	private List<MeshWriteData> m_MeshWriteDataPool;

	[Token(Token = "0x40010D2")]
	[FieldOffset(Offset = "0x28")]
	private int m_MeshWriteDataCount;

	[Token(Token = "0x40010D3")]
	[FieldOffset(Offset = "0x2C")]
	private bool m_Disposed;

	[Token(Token = "0x600248C")]
	[Address(RVA = "0x2A30C40", Offset = "0x2A2FE40", VA = "0x182A30C40")]
	public DetachedAllocator()
	{
	}

	[Token(Token = "0x600248D")]
	[Address(RVA = "0x2A30B00", Offset = "0x2A2FD00", VA = "0x182A30B00", Slot = "4")]
	public void Dispose()
	{
	}

	[Token(Token = "0x600248E")]
	[Address(RVA = "0x2A30BB0", Offset = "0x2A2FDB0", VA = "0x182A30BB0")]
	protected void Dispose(bool disposing)
	{
	}
}
