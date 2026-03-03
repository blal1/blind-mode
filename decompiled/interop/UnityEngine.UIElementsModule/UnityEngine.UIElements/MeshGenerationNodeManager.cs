using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine.UIElements.UIR;

namespace UnityEngine.UIElements;

[Token(Token = "0x20002AF")]
internal class MeshGenerationNodeManager : IDisposable
{
	[Token(Token = "0x4000AD5")]
	[FieldOffset(Offset = "0x10")]
	private List<MeshGenerationNodeImpl> m_Nodes;

	[Token(Token = "0x4000AD6")]
	[FieldOffset(Offset = "0x18")]
	private int m_UsedCounter;

	[Token(Token = "0x4000AD7")]
	[FieldOffset(Offset = "0x20")]
	private EntryRecorder m_EntryRecorder;

	[Token(Token = "0x1700038F")]
	protected bool disposed
	{
		[Token(Token = "0x60012B4")]
		[Address(RVA = "0x588F60", Offset = "0x588160", VA = "0x180588F60")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60012B5")]
		[Address(RVA = "0x588F70", Offset = "0x588170", VA = "0x180588F70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x60012AF")]
	[Address(RVA = "0x2B69A20", Offset = "0x2B68C20", VA = "0x182B69A20")]
	public MeshGenerationNodeManager(EntryRecorder entryRecorder)
	{
	}

	[Token(Token = "0x60012B0")]
	[Address(RVA = "0x2B695B0", Offset = "0x2B687B0", VA = "0x182B695B0")]
	public void CreateNode(Entry parentEntry, out MeshGenerationNode node)
	{
	}

	[Token(Token = "0x60012B1")]
	[Address(RVA = "0x2B695E0", Offset = "0x2B687E0", VA = "0x182B695E0")]
	public void CreateUnsafeNode(Entry parentEntry, out UnsafeMeshGenerationNode node)
	{
	}

	[Token(Token = "0x60012B2")]
	[Address(RVA = "0x2B69390", Offset = "0x2B68590", VA = "0x182B69390")]
	private MeshGenerationNodeImpl CreateImpl(Entry parentEntry, bool safe)
	{
		return null;
	}

	[Token(Token = "0x60012B3")]
	[Address(RVA = "0x2B69900", Offset = "0x2B68B00", VA = "0x182B69900")]
	public void ResetAll()
	{
	}

	[Token(Token = "0x60012B6")]
	[Address(RVA = "0x2B69610", Offset = "0x2B68810", VA = "0x182B69610", Slot = "4")]
	public void Dispose()
	{
	}

	[Token(Token = "0x60012B7")]
	[Address(RVA = "0x2B697A0", Offset = "0x2B689A0", VA = "0x182B697A0")]
	protected void Dispose(bool disposing)
	{
	}
}
