using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Unity.Collections;
using Unity.Jobs;

namespace UnityEngine.UIElements.UIR;

[Token(Token = "0x2000542")]
internal class JobMerger : IDisposable
{
	[Token(Token = "0x4001212")]
	[FieldOffset(Offset = "0x10")]
	private NativeArray<JobHandle> m_Jobs;

	[Token(Token = "0x4001213")]
	[FieldOffset(Offset = "0x20")]
	private int m_JobCount;

	[Token(Token = "0x17000993")]
	protected bool disposed
	{
		[Token(Token = "0x6002569")]
		[Address(RVA = "0x5CF080", Offset = "0x5CE280", VA = "0x1805CF080")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600256A")]
		[Address(RVA = "0x5CF0A0", Offset = "0x5CE2A0", VA = "0x1805CF0A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x6002566")]
	[Address(RVA = "0x2A4D020", Offset = "0x2A4C220", VA = "0x182A4D020")]
	public JobMerger(int capacity)
	{
	}

	[Token(Token = "0x6002567")]
	[Address(RVA = "0x2A4CE10", Offset = "0x2A4C010", VA = "0x182A4CE10")]
	public void Add(JobHandle job)
	{
	}

	[Token(Token = "0x6002568")]
	[Address(RVA = "0x2A4CF70", Offset = "0x2A4C170", VA = "0x182A4CF70")]
	public JobHandle MergeAndReset()
	{
		return default(JobHandle);
	}

	[Token(Token = "0x600256B")]
	[Address(RVA = "0x2A4CEF0", Offset = "0x2A4C0F0", VA = "0x182A4CEF0", Slot = "4")]
	public void Dispose()
	{
	}

	[Token(Token = "0x600256C")]
	[Address(RVA = "0x2A4CE90", Offset = "0x2A4C090", VA = "0x182A4CE90")]
	protected void Dispose(bool disposing)
	{
	}
}
