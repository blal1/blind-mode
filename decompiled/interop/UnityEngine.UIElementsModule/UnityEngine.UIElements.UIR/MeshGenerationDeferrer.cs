using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Unity.Jobs;

namespace UnityEngine.UIElements.UIR;

[Token(Token = "0x2000548")]
internal class MeshGenerationDeferrer : IDisposable
{
	[Token(Token = "0x2000549")]
	private struct CallbackInfo
	{
		[Token(Token = "0x4001226")]
		[FieldOffset(Offset = "0x0")]
		public MeshGenerationCallback callback;

		[Token(Token = "0x4001227")]
		[FieldOffset(Offset = "0x8")]
		public object userData;
	}

	[Token(Token = "0x400121D")]
	[FieldOffset(Offset = "0x10")]
	private Queue<CallbackInfo> m_Fork;

	[Token(Token = "0x400121E")]
	[FieldOffset(Offset = "0x18")]
	private Queue<CallbackInfo> m_WorkThenFork;

	[Token(Token = "0x400121F")]
	[FieldOffset(Offset = "0x20")]
	private Queue<CallbackInfo> m_Work;

	[Token(Token = "0x4001220")]
	[FieldOffset(Offset = "0x28")]
	private Queue<CallbackInfo> m_JobDependentFork;

	[Token(Token = "0x4001221")]
	[FieldOffset(Offset = "0x30")]
	private Queue<CallbackInfo> m_JobDependentWorkThenFork;

	[Token(Token = "0x4001222")]
	[FieldOffset(Offset = "0x38")]
	private Queue<CallbackInfo> m_JobDependentWork;

	[Token(Token = "0x4001223")]
	[FieldOffset(Offset = "0x40")]
	private Queue<JobHandle> m_Dependencies;

	[Token(Token = "0x4001224")]
	[FieldOffset(Offset = "0x48")]
	private JobMerger m_DependencyMerger;

	[Token(Token = "0x17000995")]
	protected bool disposed
	{
		[Token(Token = "0x600257F")]
		[Address(RVA = "0x3E1DE0", Offset = "0x3E0FE0", VA = "0x1803E1DE0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6002580")]
		[Address(RVA = "0x3E1DF0", Offset = "0x3E0FF0", VA = "0x1803E1DF0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x600257B")]
	[Address(RVA = "0x2A4D280", Offset = "0x2A4C480", VA = "0x182A4D280")]
	public void AddMeshGenerationJob(JobHandle jobHandle)
	{
	}

	[Token(Token = "0x600257C")]
	[Address(RVA = "0x2A4D0C0", Offset = "0x2A4C2C0", VA = "0x182A4D0C0")]
	public void AddMeshGenerationCallback(MeshGenerationCallback callback, object userData, MeshGenerationCallbackType callbackType, bool isJobDependent)
	{
	}

	[Token(Token = "0x600257D")]
	[Address(RVA = "0x2A4D4B0", Offset = "0x2A4C6B0", VA = "0x182A4D4B0")]
	public void ProcessDeferredWork(MeshGenerationContext meshGenerationContext)
	{
	}

	[Token(Token = "0x600257E")]
	[Address(RVA = "0x2A4D3B0", Offset = "0x2A4C5B0", VA = "0x182A4D3B0")]
	private static void Invoke(CallbackInfo ci, MeshGenerationContext mgc)
	{
	}

	[Token(Token = "0x6002581")]
	[Address(RVA = "0x2A4D2E0", Offset = "0x2A4C4E0", VA = "0x182A4D2E0", Slot = "4")]
	public void Dispose()
	{
	}

	[Token(Token = "0x6002582")]
	[Address(RVA = "0x2A4D360", Offset = "0x2A4C560", VA = "0x182A4D360")]
	protected void Dispose(bool disposing)
	{
	}

	[Token(Token = "0x6002583")]
	[Address(RVA = "0x2A4D860", Offset = "0x2A4CA60", VA = "0x182A4D860")]
	public MeshGenerationDeferrer()
	{
	}
}
