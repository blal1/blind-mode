using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Unity.Collections;
using Unity.Profiling;

namespace UnityEngine.UIElements.UIR;

[Token(Token = "0x200051E")]
internal class UIRenderDevice : IDisposable
{
	[Token(Token = "0x200051F")]
	internal struct AllocToUpdate
	{
		[Token(Token = "0x40010FE")]
		[FieldOffset(Offset = "0x0")]
		public uint id;

		[Token(Token = "0x40010FF")]
		[FieldOffset(Offset = "0x4")]
		public uint allocTime;

		[Token(Token = "0x4001100")]
		[FieldOffset(Offset = "0x8")]
		public MeshHandle meshHandle;

		[Token(Token = "0x4001101")]
		[FieldOffset(Offset = "0x10")]
		public Alloc permAllocVerts;

		[Token(Token = "0x4001102")]
		[FieldOffset(Offset = "0x28")]
		public Alloc permAllocIndices;

		[Token(Token = "0x4001103")]
		[FieldOffset(Offset = "0x40")]
		public Page permPage;

		[Token(Token = "0x4001104")]
		[FieldOffset(Offset = "0x48")]
		public bool copyBackIndices;
	}

	[Token(Token = "0x2000520")]
	private struct AllocToFree
	{
		[Token(Token = "0x4001105")]
		[FieldOffset(Offset = "0x0")]
		public Alloc alloc;

		[Token(Token = "0x4001106")]
		[FieldOffset(Offset = "0x18")]
		public Page page;

		[Token(Token = "0x4001107")]
		[FieldOffset(Offset = "0x20")]
		public bool vertices;
	}

	[Token(Token = "0x2000521")]
	private struct DeviceToFree
	{
		[Token(Token = "0x4001108")]
		[FieldOffset(Offset = "0x0")]
		public uint handle;

		[Token(Token = "0x4001109")]
		[FieldOffset(Offset = "0x8")]
		public Page page;

		[Token(Token = "0x400110A")]
		[FieldOffset(Offset = "0x10")]
		public List<CommandList>[] commandLists;

		[Token(Token = "0x60024D0")]
		[Address(RVA = "0x2A463C0", Offset = "0x2A455C0", VA = "0x182A463C0")]
		public void Dispose()
		{
		}
	}

	[Token(Token = "0x2000522")]
	private struct EvaluationState
	{
		[Token(Token = "0x400110B")]
		[FieldOffset(Offset = "0x0")]
		public CommandList activeCommandList;

		[Token(Token = "0x400110C")]
		[FieldOffset(Offset = "0x8")]
		public MaterialPropertyBlock constantProps;

		[Token(Token = "0x400110D")]
		[FieldOffset(Offset = "0x10")]
		public MaterialPropertyBlock batchProps;

		[Token(Token = "0x400110E")]
		[FieldOffset(Offset = "0x18")]
		public Material defaultMat;

		[Token(Token = "0x400110F")]
		[FieldOffset(Offset = "0x20")]
		public State curState;

		[Token(Token = "0x4001110")]
		[FieldOffset(Offset = "0x38")]
		public Page curPage;

		[Token(Token = "0x4001111")]
		[FieldOffset(Offset = "0x40")]
		public bool mustApplyMaterial;

		[Token(Token = "0x4001112")]
		[FieldOffset(Offset = "0x41")]
		public bool mustApplyBatchProps;

		[Token(Token = "0x4001113")]
		[FieldOffset(Offset = "0x42")]
		public bool mustApplyStencil;
	}

	[Token(Token = "0x2000523")]
	internal struct DrawStatistics
	{
		[Token(Token = "0x4001114")]
		[FieldOffset(Offset = "0x0")]
		public int currentFrameIndex;

		[Token(Token = "0x4001115")]
		[FieldOffset(Offset = "0x4")]
		public uint totalIndices;

		[Token(Token = "0x4001116")]
		[FieldOffset(Offset = "0x8")]
		public uint commandCount;

		[Token(Token = "0x4001117")]
		[FieldOffset(Offset = "0xC")]
		public uint skippedCommandCount;

		[Token(Token = "0x4001118")]
		[FieldOffset(Offset = "0x10")]
		public uint drawCommandCount;

		[Token(Token = "0x4001119")]
		[FieldOffset(Offset = "0x14")]
		public uint disableCommandCount;

		[Token(Token = "0x400111A")]
		[FieldOffset(Offset = "0x18")]
		public uint materialSetCount;

		[Token(Token = "0x400111B")]
		[FieldOffset(Offset = "0x1C")]
		public uint drawRangeCount;

		[Token(Token = "0x400111C")]
		[FieldOffset(Offset = "0x20")]
		public uint drawRangeCallCount;

		[Token(Token = "0x400111D")]
		[FieldOffset(Offset = "0x24")]
		public uint immediateDraws;

		[Token(Token = "0x400111E")]
		[FieldOffset(Offset = "0x28")]
		public uint stencilRefChanges;
	}

	[Token(Token = "0x40010DB")]
	[FieldOffset(Offset = "0x10")]
	private readonly bool m_MockDevice;

	[Token(Token = "0x40010DC")]
	[FieldOffset(Offset = "0x18")]
	private IntPtr m_DefaultStencilState;

	[Token(Token = "0x40010DD")]
	[FieldOffset(Offset = "0x20")]
	private IntPtr m_VertexDecl;

	[Token(Token = "0x40010DE")]
	[FieldOffset(Offset = "0x28")]
	private Page m_FirstPage;

	[Token(Token = "0x40010DF")]
	[FieldOffset(Offset = "0x30")]
	private uint m_NextPageVertexCount;

	[Token(Token = "0x40010E0")]
	[FieldOffset(Offset = "0x34")]
	private uint m_LargeMeshVertexCount;

	[Token(Token = "0x40010E1")]
	[FieldOffset(Offset = "0x38")]
	private float m_IndexToVertexCountRatio;

	[Token(Token = "0x40010E2")]
	[FieldOffset(Offset = "0x40")]
	private List<List<AllocToFree>> m_DeferredFrees;

	[Token(Token = "0x40010E3")]
	[FieldOffset(Offset = "0x48")]
	private List<List<AllocToUpdate>> m_Updates;

	[Token(Token = "0x40010E4")]
	[FieldOffset(Offset = "0x50")]
	private List<CommandList>[] m_CommandLists;

	[Token(Token = "0x40010E5")]
	[FieldOffset(Offset = "0x58")]
	private uint[] m_Fences;

	[Token(Token = "0x40010E6")]
	[FieldOffset(Offset = "0x60")]
	private MaterialPropertyBlock m_ConstantProps;

	[Token(Token = "0x40010E7")]
	[FieldOffset(Offset = "0x68")]
	private MaterialPropertyBlock m_BatchProps;

	[Token(Token = "0x40010E8")]
	[FieldOffset(Offset = "0x70")]
	private uint m_FrameIndex;

	[Token(Token = "0x40010E9")]
	[FieldOffset(Offset = "0x74")]
	private uint m_NextUpdateID;

	[Token(Token = "0x40010EA")]
	[FieldOffset(Offset = "0x78")]
	private DrawStatistics m_DrawStats;

	[Token(Token = "0x40010EB")]
	[FieldOffset(Offset = "0xA8")]
	private readonly LinkedPool<MeshHandle> m_MeshHandles;

	[Token(Token = "0x40010EC")]
	[FieldOffset(Offset = "0xB0")]
	private readonly DrawParams m_DrawParams;

	[Token(Token = "0x40010ED")]
	[FieldOffset(Offset = "0xB8")]
	private readonly TextureSlotManager m_TextureSlotManager;

	[Token(Token = "0x40010EE")]
	[FieldOffset(Offset = "0x0")]
	private static LinkedList<DeviceToFree> m_DeviceFreeQueue;

	[Token(Token = "0x40010EF")]
	[FieldOffset(Offset = "0x8")]
	private static int m_ActiveDeviceCount;

	[Token(Token = "0x40010F0")]
	[FieldOffset(Offset = "0xC")]
	private static bool m_SubscribedToNotifications;

	[Token(Token = "0x40010F1")]
	[FieldOffset(Offset = "0xD")]
	private static bool m_SynchronousFree;

	[Token(Token = "0x40010F2")]
	[FieldOffset(Offset = "0x10")]
	private static readonly int s_GradientSettingsTexID;

	[Token(Token = "0x40010F3")]
	[FieldOffset(Offset = "0x14")]
	private static readonly int s_ShaderInfoTexID;

	[Token(Token = "0x40010F4")]
	[FieldOffset(Offset = "0x18")]
	private static ProfilerMarker s_MarkerAllocate;

	[Token(Token = "0x40010F5")]
	[FieldOffset(Offset = "0x20")]
	private static ProfilerMarker s_MarkerFree;

	[Token(Token = "0x40010F6")]
	[FieldOffset(Offset = "0x28")]
	private static ProfilerMarker s_MarkerAdvanceFrame;

	[Token(Token = "0x40010F7")]
	[FieldOffset(Offset = "0x30")]
	private static ProfilerMarker s_MarkerFence;

	[Token(Token = "0x40010F8")]
	[FieldOffset(Offset = "0x38")]
	private static ProfilerMarker s_MarkerBeforeDraw;

	[Token(Token = "0x40010FC")]
	[FieldOffset(Offset = "0xC4")]
	internal int currentFrameCommandListCount;

	[Token(Token = "0x17000976")]
	internal static uint maxVerticesPerPage
	{
		[Token(Token = "0x60024A1")]
		[Address(RVA = "0x1E84FA0", Offset = "0x1E841A0", VA = "0x181E84FA0")]
		get
		{
			return default(uint);
		}
	}

	[Token(Token = "0x17000977")]
	internal bool breakBatches
	{
		[Token(Token = "0x60024A2")]
		[Address(RVA = "0x56D880", Offset = "0x56CA80", VA = "0x18056D880")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60024A3")]
		[Address(RVA = "0x56D8B0", Offset = "0x56CAB0", VA = "0x18056D8B0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x17000978")]
	internal bool isFlat
	{
		[Token(Token = "0x60024A4")]
		[Address(RVA = "0x56D890", Offset = "0x56CA90", VA = "0x18056D890")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60024A5")]
		[Address(RVA = "0x56D8C0", Offset = "0x56CAC0", VA = "0x18056D8C0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x17000979")]
	internal bool drawsInCameras
	{
		[Token(Token = "0x60024A6")]
		[Address(RVA = "0x232F390", Offset = "0x232E590", VA = "0x18232F390")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60024A7")]
		[Address(RVA = "0x2A3A490", Offset = "0x2A39690", VA = "0x182A3A490")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x1700097A")]
	internal uint frameIndex
	{
		[Token(Token = "0x60024A8")]
		[Address(RVA = "0x803CC0", Offset = "0x802EC0", VA = "0x180803CC0")]
		get
		{
			return default(uint);
		}
	}

	[Token(Token = "0x1700097B")]
	internal List<CommandList>[] commandLists
	{
		[Token(Token = "0x60024A9")]
		[Address(RVA = "0x580700", Offset = "0x57F900", VA = "0x180580700")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700097C")]
	internal List<CommandList> currentFrameCommandLists
	{
		[Token(Token = "0x60024AA")]
		[Address(RVA = "0x2A3A430", Offset = "0x2A39630", VA = "0x182A3A430")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700097D")]
	private bool fullyCreated
	{
		[Token(Token = "0x60024B0")]
		[Address(RVA = "0x2A3A480", Offset = "0x2A39680", VA = "0x182A3A480")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700097E")]
	protected bool disposed
	{
		[Token(Token = "0x60024B1")]
		[Address(RVA = "0xEB3670", Offset = "0xEB2870", VA = "0x180EB3670")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60024B2")]
		[Address(RVA = "0xEB3730", Offset = "0xEB2930", VA = "0x180EB3730")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x60024AB")]
	[Address(RVA = "0x2A39950", Offset = "0x2A38B50", VA = "0x182A39950")]
	static UIRenderDevice()
	{
	}

	[Token(Token = "0x60024AC")]
	[Address(RVA = "0x2A3A410", Offset = "0x2A39610", VA = "0x182A3A410")]
	public UIRenderDevice(uint initialVertexCapacity = 0u, uint initialIndexCapacity = 0u)
	{
	}

	[Token(Token = "0x60024AD")]
	[Address(RVA = "0x2A39DB0", Offset = "0x2A38FB0", VA = "0x182A39DB0")]
	protected UIRenderDevice(uint initialVertexCapacity, uint initialIndexCapacity, bool mockDevice)
	{
	}

	[Token(Token = "0x60024AE")]
	[Address(RVA = "0x2A37BA0", Offset = "0x2A36DA0", VA = "0x182A37BA0")]
	private void InitVertexDeclaration()
	{
	}

	[Token(Token = "0x60024AF")]
	[Address(RVA = "0x2A35E10", Offset = "0x2A35010", VA = "0x182A35E10")]
	private void CompleteCreation()
	{
	}

	[Token(Token = "0x60024B3")]
	[Address(RVA = "0x2A36330", Offset = "0x2A35530", VA = "0x182A36330", Slot = "4")]
	public void Dispose()
	{
	}

	[Token(Token = "0x60024B4")]
	[Address(RVA = "0x2A36140", Offset = "0x2A35340", VA = "0x182A36140", Slot = "5")]
	protected virtual void Dispose(bool disposing)
	{
	}

	[Token(Token = "0x60024B5")]
	[Address(RVA = "0x2A35070", Offset = "0x2A34270", VA = "0x182A35070")]
	public MeshHandle Allocate(uint vertexCount, uint indexCount, out NativeSlice<Vertex> vertexData, out NativeSlice<ushort> indexData, out ushort indexOffset)
	{
		return null;
	}

	[Token(Token = "0x60024B6")]
	[Address(RVA = "0x2A39320", Offset = "0x2A38520", VA = "0x182A39320")]
	public void Update(MeshHandle mesh, uint vertexCount, out NativeSlice<Vertex> vertexData)
	{
	}

	[Token(Token = "0x60024B7")]
	[Address(RVA = "0x2A39560", Offset = "0x2A38760", VA = "0x182A39560")]
	public void Update(MeshHandle mesh, uint vertexCount, uint indexCount, out NativeSlice<Vertex> vertexData, out NativeSlice<ushort> indexData, out ushort indexOffset)
	{
	}

	[Token(Token = "0x60024B8")]
	[Address(RVA = "0x2A390F0", Offset = "0x2A382F0", VA = "0x182A390F0")]
	private void UpdateCopyBackIndices(MeshHandle mesh, bool copyBackIndices)
	{
	}

	[Token(Token = "0x60024B9")]
	[Address(RVA = "0x2A34480", Offset = "0x2A33680", VA = "0x182A34480")]
	internal List<AllocToUpdate> ActiveUpdatesForMeshHandle(MeshHandle mesh)
	{
		return null;
	}

	[Token(Token = "0x60024BA")]
	[Address(RVA = "0x2A38860", Offset = "0x2A37A60", VA = "0x182A38860")]
	private bool TryAllocFromPage(Page page, uint vertexCount, uint indexCount, ref Alloc va, ref Alloc ia, bool shortLived)
	{
		return default(bool);
	}

	[Token(Token = "0x60024BB")]
	[Address(RVA = "0x2A35140", Offset = "0x2A34340", VA = "0x182A35140")]
	private void Allocate(MeshHandle meshHandle, uint vertexCount, uint indexCount, out NativeSlice<Vertex> vertexData, out NativeSlice<ushort> indexData, bool shortLived)
	{
	}

	[Token(Token = "0x60024BC")]
	[Address(RVA = "0x2A389B0", Offset = "0x2A37BB0", VA = "0x182A389B0")]
	private void UpdateAfterGPUUsedData(MeshHandle mesh, uint vertexCount, uint indexCount, out NativeSlice<Vertex> vertexData, out NativeSlice<ushort> indexData, out ushort indexOffset, out AllocToUpdate allocToUpdate, bool copyBackIndices)
	{
	}

	[Token(Token = "0x60024BD")]
	[Address(RVA = "0x2A37520", Offset = "0x2A36720", VA = "0x182A37520")]
	public void Free(MeshHandle mesh)
	{
	}

	[Token(Token = "0x60024BE")]
	[Address(RVA = "0x2A382E0", Offset = "0x2A374E0", VA = "0x182A382E0")]
	public void OnFrameRenderingBegin()
	{
	}

	[Token(Token = "0x60024BF")]
	internal unsafe static NativeSlice<T> PtrToSlice<T>(void* p, int count) where T : struct
	{
		return default(NativeSlice<T>);
	}

	[MethodImpl(256)]
	[Token(Token = "0x60024C0")]
	[Address(RVA = "0x2A35C30", Offset = "0x2A34E30", VA = "0x182A35C30")]
	private void ApplyDrawCommandState(RenderChainCommand cmd, int textureSlot, Material newMat, bool newMatDiffers, ref EvaluationState st)
	{
	}

	[Token(Token = "0x60024C1")]
	[Address(RVA = "0x2A35910", Offset = "0x2A34B10", VA = "0x182A35910")]
	private void ApplyBatchState(ref EvaluationState st)
	{
	}

	[Token(Token = "0x60024C2")]
	[Address(RVA = "0x2A366A0", Offset = "0x2A358A0", VA = "0x182A366A0")]
	public void EvaluateChain(RenderChainCommand head, Material initialMat, Material defaultMat, Texture gradientSettings, Texture shaderInfo, float pixelsPerPoint, ref Exception immediateException)
	{
	}

	[Token(Token = "0x60024C3")]
	[Address(RVA = "0x2A39240", Offset = "0x2A38440", VA = "0x182A39240")]
	private void UpdateFenceValue()
	{
	}

	[Token(Token = "0x60024C4")]
	[Address(RVA = "0x2A37F50", Offset = "0x2A37150", VA = "0x182A37F50")]
	private unsafe void KickRanges(DrawBufferRange* ranges, ref int rangesReady, ref int rangesStart, int rangesCount, Page curPage, CommandList commandList)
	{
	}

	[Token(Token = "0x60024C5")]
	[Address(RVA = "0x2A363A0", Offset = "0x2A355A0", VA = "0x182A363A0")]
	private void DrawRanges(Utility.GPUBuffer<ushort> ib, Utility.GPUBuffer<Vertex> vb, NativeSlice<DrawBufferRange> ranges, CommandList commandList)
	{
	}

	[Token(Token = "0x60024C6")]
	[Address(RVA = "0x2A39840", Offset = "0x2A38A40", VA = "0x182A39840")]
	private void WaitOnCpuFence(uint fence)
	{
	}

	[Token(Token = "0x60024C7")]
	[Address(RVA = "0x2A344F0", Offset = "0x2A336F0", VA = "0x182A344F0")]
	public void AdvanceFrame()
	{
	}

	[Token(Token = "0x60024C8")]
	[Address(RVA = "0x2A38730", Offset = "0x2A37930", VA = "0x182A38730")]
	private void PruneUnusedPages()
	{
	}

	[Token(Token = "0x60024C9")]
	[Address(RVA = "0x2A383A0", Offset = "0x2A375A0", VA = "0x182A383A0")]
	internal static void PrepareForGfxDeviceRecreate()
	{
	}

	[Token(Token = "0x60024CA")]
	[Address(RVA = "0x2A398F0", Offset = "0x2A38AF0", VA = "0x182A398F0")]
	internal static void WrapUpGfxDeviceRecreate()
	{
	}

	[Token(Token = "0x60024CB")]
	[Address(RVA = "0x2A37490", Offset = "0x2A36690", VA = "0x182A37490")]
	internal static void FlushAllPendingDeviceDisposes()
	{
	}

	[Token(Token = "0x60024CC")]
	[Address(RVA = "0x2A37B70", Offset = "0x2A36D70", VA = "0x182A37B70")]
	internal DrawStatistics GatherDrawStatistics()
	{
		return default(DrawStatistics);
	}

	[Token(Token = "0x60024CD")]
	[Address(RVA = "0x2A38400", Offset = "0x2A37600", VA = "0x182A38400")]
	public static void ProcessDeviceFreeQueue()
	{
	}

	[Token(Token = "0x60024CE")]
	[Address(RVA = "0x2A38240", Offset = "0x2A37440", VA = "0x182A38240")]
	private static void OnEngineUpdateGlobal()
	{
	}

	[Token(Token = "0x60024CF")]
	[Address(RVA = "0x2A38280", Offset = "0x2A37480", VA = "0x182A38280")]
	private static void OnFlushPendingResources()
	{
	}
}
