using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Unity.Jobs;
using Unity.Profiling;
using UnityEngine.UIElements.UIR;

namespace UnityEngine.UIElements;

[Token(Token = "0x20002AA")]
public class MeshGenerationContext
{
	[Token(Token = "0x20002AB")]
	[Flags]
	internal enum MeshFlags
	{
		[Token(Token = "0x4000ACB")]
		None = 0,
		[Token(Token = "0x4000ACC")]
		SkipDynamicAtlas = 2,
		[Token(Token = "0x4000ACD")]
		IsUsingVectorImageGradients = 4,
		[Token(Token = "0x4000ACE")]
		SliceTiled = 8
	}

	[Token(Token = "0x4000ABF")]
	[FieldOffset(Offset = "0x18")]
	private Painter2D m_Painter2D;

	[Token(Token = "0x4000AC0")]
	[FieldOffset(Offset = "0x20")]
	private MeshWriteDataPool m_MeshWriteDataPool;

	[Token(Token = "0x4000AC1")]
	[FieldOffset(Offset = "0x28")]
	private TempMeshAllocatorImpl m_Allocator;

	[Token(Token = "0x4000AC2")]
	[FieldOffset(Offset = "0x30")]
	private MeshGenerationDeferrer m_MeshGenerationDeferrer;

	[Token(Token = "0x4000AC3")]
	[FieldOffset(Offset = "0x38")]
	private MeshGenerationNodeManager m_MeshGenerationNodeManager;

	[Token(Token = "0x4000AC7")]
	[FieldOffset(Offset = "0x0")]
	private static readonly ProfilerMarker k_AllocateMarker;

	[Token(Token = "0x4000AC8")]
	[FieldOffset(Offset = "0x8")]
	private static readonly ProfilerMarker k_DrawVectorImageMarker;

	[Token(Token = "0x17000387")]
	public VisualElement visualElement
	{
		[Token(Token = "0x6001284")]
		[Address(RVA = "0x40C440", Offset = "0x40B640", VA = "0x18040C440")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6001285")]
		[Address(RVA = "0x439010", Offset = "0x438210", VA = "0x180439010")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17000388")]
	public Painter2D painter2D
	{
		[Token(Token = "0x6001286")]
		[Address(RVA = "0x2B68D90", Offset = "0x2B67F90", VA = "0x182B68D90")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000389")]
	internal bool hasPainter2D
	{
		[Token(Token = "0x6001287")]
		[Address(RVA = "0x5C4390", Offset = "0x5C3590", VA = "0x1805C4390")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700038A")]
	internal IMeshGenerator meshGenerator
	{
		[Token(Token = "0x6001288")]
		[Address(RVA = "0x404850", Offset = "0x403A50", VA = "0x180404850")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6001289")]
		[Address(RVA = "0x595530", Offset = "0x594730", VA = "0x180595530")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x1700038B")]
	internal EntryRecorder entryRecorder
	{
		[Token(Token = "0x600128A")]
		[Address(RVA = "0x414E80", Offset = "0x414080", VA = "0x180414E80")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x600128B")]
		[Address(RVA = "0x414E90", Offset = "0x414090", VA = "0x180414E90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x1700038C")]
	internal Entry parentEntry
	{
		[Token(Token = "0x600128C")]
		[Address(RVA = "0x580700", Offset = "0x57F900", VA = "0x180580700")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x600128D")]
		[Address(RVA = "0x580760", Offset = "0x57F960", VA = "0x180580760")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x1700038D")]
	internal bool disposed
	{
		[Token(Token = "0x6001296")]
		[Address(RVA = "0x453D30", Offset = "0x452F30", VA = "0x180453D30")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6001297")]
		[Address(RVA = "0x415440", Offset = "0x414640", VA = "0x180415440")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x600128E")]
	[Address(RVA = "0x2B68CB0", Offset = "0x2B67EB0", VA = "0x182B68CB0")]
	internal MeshGenerationContext(MeshWriteDataPool meshWriteDataPool, EntryRecorder entryRecorder, TempMeshAllocatorImpl allocator, MeshGenerationDeferrer meshGenerationDeferrer, MeshGenerationNodeManager meshGenerationNodeManager)
	{
	}

	[Token(Token = "0x600128F")]
	[Address(RVA = "0x2B68B30", Offset = "0x2B67D30", VA = "0x182B68B30")]
	public void GetTempMeshAllocator(out TempMeshAllocator allocator)
	{
	}

	[Token(Token = "0x6001290")]
	[Address(RVA = "0x2B68B50", Offset = "0x2B67D50", VA = "0x182B68B50")]
	public void InsertMeshGenerationNode(out MeshGenerationNode node)
	{
	}

	[Token(Token = "0x6001291")]
	[Address(RVA = "0x2B68BB0", Offset = "0x2B67DB0", VA = "0x182B68BB0")]
	internal void InsertUnsafeMeshGenerationNode(out UnsafeMeshGenerationNode node)
	{
	}

	[Token(Token = "0x6001292")]
	[Address(RVA = "0x2B68600", Offset = "0x2B67800", VA = "0x182B68600")]
	public void AddMeshGenerationJob(JobHandle jobHandle)
	{
	}

	[Token(Token = "0x6001293")]
	[Address(RVA = "0x2B685D0", Offset = "0x2B677D0", VA = "0x182B685D0")]
	internal void AddMeshGenerationCallback(MeshGenerationCallback callback, object userData, MeshGenerationCallbackType callbackType, bool isJobDependent)
	{
	}

	[Token(Token = "0x6001294")]
	[Address(RVA = "0x2B68630", Offset = "0x2B67830", VA = "0x182B68630")]
	internal void Begin(Entry parentEntry, VisualElement ve)
	{
	}

	[Token(Token = "0x6001295")]
	[Address(RVA = "0x2B68A10", Offset = "0x2B67C10", VA = "0x182B68A10")]
	internal void End()
	{
	}

	[Token(Token = "0x6001298")]
	[Address(RVA = "0x2B68800", Offset = "0x2B67A00", VA = "0x182B68800")]
	internal void Dispose()
	{
	}

	[Token(Token = "0x6001299")]
	[Address(RVA = "0x2B68860", Offset = "0x2B67A60", VA = "0x182B68860")]
	private void Dispose(bool disposing)
	{
	}
}
