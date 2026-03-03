using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace UnityEngine.UIElements.UIR;

[Token(Token = "0x2000533")]
internal class EntryPreProcessor
{
	[Token(Token = "0x2000534")]
	public struct AllocSize
	{
		[Token(Token = "0x4001180")]
		[FieldOffset(Offset = "0x0")]
		public int vertexCount;

		[Token(Token = "0x4001181")]
		[FieldOffset(Offset = "0x4")]
		public int indexCount;
	}

	[Token(Token = "0x4001178")]
	[FieldOffset(Offset = "0x10")]
	private int m_ChildrenIndex;

	[Token(Token = "0x4001179")]
	[FieldOffset(Offset = "0x18")]
	private List<AllocSize> m_Allocs;

	[Token(Token = "0x400117A")]
	[FieldOffset(Offset = "0x20")]
	private List<AllocSize> m_HeadAllocs;

	[Token(Token = "0x400117B")]
	[FieldOffset(Offset = "0x28")]
	private List<AllocSize> m_TailAllocs;

	[Token(Token = "0x400117C")]
	[FieldOffset(Offset = "0x30")]
	private List<Entry> m_FlattenedEntries;

	[Token(Token = "0x400117D")]
	[FieldOffset(Offset = "0x38")]
	private AllocSize m_Pending;

	[Token(Token = "0x400117E")]
	[FieldOffset(Offset = "0x40")]
	private Stack<AllocSize> m_Mask;

	[Token(Token = "0x400117F")]
	[FieldOffset(Offset = "0x48")]
	private bool m_IsPushingMask;

	[Token(Token = "0x17000986")]
	public int childrenIndex
	{
		[Token(Token = "0x600250C")]
		[Address(RVA = "0x3C7100", Offset = "0x3C6300", VA = "0x1803C7100")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000987")]
	public List<AllocSize> headAllocs
	{
		[Token(Token = "0x600250D")]
		[Address(RVA = "0x3D8370", Offset = "0x3D7570", VA = "0x1803D8370")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000988")]
	public List<AllocSize> tailAllocs
	{
		[Token(Token = "0x600250E")]
		[Address(RVA = "0x4030F0", Offset = "0x4022F0", VA = "0x1804030F0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000989")]
	public List<Entry> flattenedEntries
	{
		[Token(Token = "0x600250F")]
		[Address(RVA = "0x402CE0", Offset = "0x401EE0", VA = "0x180402CE0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6002510")]
	[Address(RVA = "0x2A47540", Offset = "0x2A46740", VA = "0x182A47540")]
	public void PreProcess(Entry root)
	{
	}

	[Token(Token = "0x6002511")]
	[Address(RVA = "0x2A47110", Offset = "0x2A46310", VA = "0x182A47110")]
	public void ClearReferences()
	{
	}

	[Token(Token = "0x6002512")]
	[Address(RVA = "0x2A47170", Offset = "0x2A46370", VA = "0x182A47170")]
	private void DoEvaluate(Entry entry)
	{
	}

	[Token(Token = "0x6002513")]
	[Address(RVA = "0x2A47030", Offset = "0x2A46230", VA = "0x182A47030")]
	private void Add(int vertexCount, int indexCount)
	{
	}

	[MethodImpl(256)]
	[Token(Token = "0x6002514")]
	[Address(RVA = "0x2A47490", Offset = "0x2A46690", VA = "0x182A47490")]
	private void Flush()
	{
	}

	[Token(Token = "0x6002515")]
	[Address(RVA = "0x2A47950", Offset = "0x2A46B50", VA = "0x182A47950")]
	public EntryPreProcessor()
	{
	}
}
