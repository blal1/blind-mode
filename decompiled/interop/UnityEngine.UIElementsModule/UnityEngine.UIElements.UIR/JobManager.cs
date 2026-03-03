using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace UnityEngine.UIElements.UIR;

[Token(Token = "0x200053E")]
internal class JobManager : IDisposable
{
	[Token(Token = "0x40011EA")]
	[FieldOffset(Offset = "0x10")]
	private NativePagedList<NudgeJobData> m_NudgeJobs;

	[Token(Token = "0x40011EB")]
	[FieldOffset(Offset = "0x18")]
	private NativePagedList<ConvertMeshJobData> m_ConvertMeshJobs;

	[Token(Token = "0x40011EC")]
	[FieldOffset(Offset = "0x20")]
	private NativePagedList<CopyMeshJobData> m_CopyMeshJobs;

	[Token(Token = "0x40011ED")]
	[FieldOffset(Offset = "0x28")]
	private JobMerger m_JobMerger;

	[Token(Token = "0x17000992")]
	protected bool disposed
	{
		[Token(Token = "0x6002561")]
		[Address(RVA = "0x51FEA0", Offset = "0x51F0A0", VA = "0x18051FEA0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6002562")]
		[Address(RVA = "0x5FDF60", Offset = "0x5FD160", VA = "0x1805FDF60")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x600255B")]
	[Address(RVA = "0x2A4C0F0", Offset = "0x2A4B2F0", VA = "0x182A4C0F0")]
	public void Add(ref NudgeJobData job)
	{
	}

	[Token(Token = "0x600255C")]
	[Address(RVA = "0x2A4C030", Offset = "0x2A4B230", VA = "0x182A4C030")]
	public void Add(ref ConvertMeshJobData job)
	{
	}

	[Token(Token = "0x600255D")]
	[Address(RVA = "0x2A4C090", Offset = "0x2A4B290", VA = "0x182A4C090")]
	public void Add(ref CopyMeshJobData job)
	{
	}

	[Token(Token = "0x600255E")]
	[Address(RVA = "0x2A4C770", Offset = "0x2A4B970", VA = "0x182A4C770")]
	public void CompleteNudgeJobs()
	{
	}

	[Token(Token = "0x600255F")]
	[Address(RVA = "0x2A4C150", Offset = "0x2A4B350", VA = "0x182A4C150")]
	public void CompleteConvertMeshJobs()
	{
	}

	[Token(Token = "0x6002560")]
	[Address(RVA = "0x2A4C460", Offset = "0x2A4B660", VA = "0x182A4C460")]
	public void CompleteCopyMeshJobs()
	{
	}

	[Token(Token = "0x6002563")]
	[Address(RVA = "0x2A4CB40", Offset = "0x2A4BD40", VA = "0x182A4CB40", Slot = "4")]
	public void Dispose()
	{
	}

	[Token(Token = "0x6002564")]
	[Address(RVA = "0x2A4CA80", Offset = "0x2A4BC80", VA = "0x182A4CA80")]
	protected void Dispose(bool disposing)
	{
	}

	[Token(Token = "0x6002565")]
	[Address(RVA = "0x2A4CC20", Offset = "0x2A4BE20", VA = "0x182A4CC20")]
	public JobManager()
	{
	}
}
