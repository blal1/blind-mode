using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Unity.Profiling;

namespace UnityEngine.UIElements.UIR;

[Token(Token = "0x200055A")]
internal class RenderChain : IDisposable
{
	[Token(Token = "0x200055B")]
	private struct DepthOrderedDirtyTracking
	{
		[Token(Token = "0x40012D0")]
		[FieldOffset(Offset = "0x0")]
		public List<VisualElement> heads;

		[Token(Token = "0x40012D1")]
		[FieldOffset(Offset = "0x8")]
		public List<VisualElement> tails;

		[Token(Token = "0x40012D2")]
		[FieldOffset(Offset = "0x10")]
		public int[] minDepths;

		[Token(Token = "0x40012D3")]
		[FieldOffset(Offset = "0x18")]
		public int[] maxDepths;

		[Token(Token = "0x40012D4")]
		[FieldOffset(Offset = "0x20")]
		public uint dirtyID;

		[Token(Token = "0x6002619")]
		[Address(RVA = "0x2A57DB0", Offset = "0x2A56FB0", VA = "0x182A57DB0")]
		public void EnsureFits(int maxDepth)
		{
		}

		[Token(Token = "0x600261A")]
		[Address(RVA = "0x2A57F00", Offset = "0x2A57100", VA = "0x182A57F00")]
		public void RegisterDirty(VisualElement ve, RenderDataDirtyTypes dirtyTypes, RenderDataDirtyTypeClasses dirtyTypeClass)
		{
		}

		[Token(Token = "0x600261B")]
		[Address(RVA = "0x2A57B90", Offset = "0x2A56D90", VA = "0x182A57B90")]
		public void ClearDirty(VisualElement ve, RenderDataDirtyTypes dirtyTypesInverse)
		{
		}

		[Token(Token = "0x600261C")]
		[Address(RVA = "0x2A58100", Offset = "0x2A57300", VA = "0x182A58100")]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x200055C")]
	private class VisualChangesProcessor : IDisposable
	{
		[Token(Token = "0x200055D")]
		private enum VisualsProcessingType
		{
			[Token(Token = "0x40012DF")]
			Head,
			[Token(Token = "0x40012E0")]
			Tail
		}

		[Token(Token = "0x200055E")]
		private struct EntryProcessingInfo
		{
			[Token(Token = "0x40012E1")]
			[FieldOffset(Offset = "0x0")]
			public VisualElement visualElement;

			[Token(Token = "0x40012E2")]
			[FieldOffset(Offset = "0x8")]
			public VisualsProcessingType type;

			[Token(Token = "0x40012E3")]
			[FieldOffset(Offset = "0x10")]
			public Entry rootEntry;
		}

		[Token(Token = "0x40012D5")]
		[FieldOffset(Offset = "0x0")]
		private static readonly ProfilerMarker k_GenerateEntriesMarker;

		[Token(Token = "0x40012D6")]
		[FieldOffset(Offset = "0x8")]
		private static readonly ProfilerMarker k_ConvertEntriesToCommandsMarker;

		[Token(Token = "0x40012D7")]
		[FieldOffset(Offset = "0x10")]
		private static readonly ProfilerMarker k_UpdateOpacityIdMarker;

		[Token(Token = "0x40012D8")]
		[FieldOffset(Offset = "0x10")]
		private RenderChain m_RenderChain;

		[Token(Token = "0x40012D9")]
		[FieldOffset(Offset = "0x18")]
		private MeshGenerationContext m_MeshGenerationContext;

		[Token(Token = "0x40012DA")]
		[FieldOffset(Offset = "0x20")]
		private BaseElementBuilder m_ElementBuilder;

		[Token(Token = "0x40012DB")]
		[FieldOffset(Offset = "0x28")]
		private List<EntryProcessingInfo> m_EntryProcessingList;

		[Token(Token = "0x40012DC")]
		[FieldOffset(Offset = "0x30")]
		private List<EntryProcessor> m_Processors;

		[Token(Token = "0x170009B1")]
		public BaseElementBuilder elementBuilder
		{
			[Token(Token = "0x600261D")]
			[Address(RVA = "0x3D8370", Offset = "0x3D7570", VA = "0x1803D8370")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170009B2")]
		public MeshGenerationContext meshGenerationContext
		{
			[Token(Token = "0x600261E")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170009B3")]
		protected bool disposed
		{
			[Token(Token = "0x6002627")]
			[Address(RVA = "0x406E70", Offset = "0x406070", VA = "0x180406E70")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6002628")]
			[Address(RVA = "0x406E80", Offset = "0x406080", VA = "0x180406E80")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x600261F")]
		[Address(RVA = "0x2A694C0", Offset = "0x2A686C0", VA = "0x182A694C0")]
		public VisualChangesProcessor(RenderChain renderChain)
		{
		}

		[Token(Token = "0x6002620")]
		[Address(RVA = "0x2A69200", Offset = "0x2A68400", VA = "0x182A69200")]
		public void ScheduleMeshGenerationJobs()
		{
		}

		[Token(Token = "0x6002621")]
		[Address(RVA = "0x2A691A0", Offset = "0x2A683A0", VA = "0x182A691A0")]
		public void ProcessOnVisualsChanged(VisualElement ve, uint dirtyID, ref ChainBuilderStats stats)
		{
		}

		[Token(Token = "0x6002622")]
		[Address(RVA = "0x2A68850", Offset = "0x2A67A50", VA = "0x182A68850")]
		private void DepthFirstOnVisualsChanged(VisualElement ve, uint dirtyID, bool hierarchical, ref ChainBuilderStats stats)
		{
		}

		[Token(Token = "0x6002623")]
		[Address(RVA = "0x2A69370", Offset = "0x2A68570", VA = "0x182A69370")]
		private static void UpdateWorldFlipsWinding(VisualElement ve)
		{
		}

		[Token(Token = "0x6002624")]
		[Address(RVA = "0x2A685F0", Offset = "0x2A677F0", VA = "0x182A685F0")]
		public void ConvertEntriesToCommands(ref ChainBuilderStats stats)
		{
		}

		[Token(Token = "0x6002625")]
		[Address(RVA = "0x2A69240", Offset = "0x2A68440", VA = "0x182A69240")]
		public static void UpdateOpacityId(VisualElement ve, RenderChain renderChain)
		{
		}

		[Token(Token = "0x6002626")]
		[Address(RVA = "0x2A68F80", Offset = "0x2A68180", VA = "0x182A68F80")]
		private static void DoUpdateOpacityId(VisualElement ve, RenderChain renderChain, MeshHandle mesh)
		{
		}

		[Token(Token = "0x6002629")]
		[Address(RVA = "0x2A68F00", Offset = "0x2A68100", VA = "0x182A68F00", Slot = "4")]
		public void Dispose()
		{
		}

		[Token(Token = "0x600262A")]
		[Address(RVA = "0x2A68EB0", Offset = "0x2A680B0", VA = "0x182A68EB0")]
		protected void Dispose(bool disposing)
		{
		}
	}

	[Token(Token = "0x40012A9")]
	[FieldOffset(Offset = "0x10")]
	private RenderChainCommand m_FirstCommand;

	[Token(Token = "0x40012AA")]
	[FieldOffset(Offset = "0x18")]
	private DepthOrderedDirtyTracking m_DirtyTracker;

	[Token(Token = "0x40012AB")]
	[FieldOffset(Offset = "0x40")]
	private VisualChangesProcessor m_VisualChangesProcessor;

	[Token(Token = "0x40012AC")]
	[FieldOffset(Offset = "0x48")]
	private LinkedPool<RenderChainCommand> m_CommandPool;

	[Token(Token = "0x40012AD")]
	[FieldOffset(Offset = "0x50")]
	private LinkedPool<ExtraRenderChainVEData> m_ExtraDataPool;

	[Token(Token = "0x40012AE")]
	[FieldOffset(Offset = "0x58")]
	private BasicNodePool<MeshHandle> m_MeshHandleNodePool;

	[Token(Token = "0x40012AF")]
	[FieldOffset(Offset = "0x60")]
	private BasicNodePool<TextureEntry> m_TexturePool;

	[Token(Token = "0x40012B0")]
	[FieldOffset(Offset = "0x68")]
	private Dictionary<VisualElement, ExtraRenderChainVEData> m_ExtraData;

	[Token(Token = "0x40012B1")]
	[FieldOffset(Offset = "0x70")]
	private MeshGenerationDeferrer m_MeshGenerationDeferrer;

	[Token(Token = "0x40012B2")]
	[FieldOffset(Offset = "0x78")]
	private Material m_DefaultMat;

	[Token(Token = "0x40012B3")]
	[FieldOffset(Offset = "0x80")]
	private bool m_BlockDirtyRegistration;

	[Token(Token = "0x40012B4")]
	[FieldOffset(Offset = "0x84")]
	private ChainBuilderStats m_Stats;

	[Token(Token = "0x40012B5")]
	[FieldOffset(Offset = "0xE0")]
	private uint m_StatsElementsAdded;

	[Token(Token = "0x40012B6")]
	[FieldOffset(Offset = "0xE4")]
	private uint m_StatsElementsRemoved;

	[Token(Token = "0x40012B7")]
	[FieldOffset(Offset = "0xE8")]
	private TextureRegistry m_TextureRegistry;

	[Token(Token = "0x40012B9")]
	[FieldOffset(Offset = "0x0")]
	private static EntryPool s_SharedEntryPool;

	[Token(Token = "0x40012BA")]
	[FieldOffset(Offset = "0x8")]
	private static readonly ProfilerMarker k_MarkerProcess;

	[Token(Token = "0x40012BB")]
	[FieldOffset(Offset = "0x10")]
	private static readonly ProfilerMarker k_MarkerClipProcessing;

	[Token(Token = "0x40012BC")]
	[FieldOffset(Offset = "0x18")]
	private static readonly ProfilerMarker k_MarkerOpacityProcessing;

	[Token(Token = "0x40012BD")]
	[FieldOffset(Offset = "0x20")]
	private static readonly ProfilerMarker k_MarkerColorsProcessing;

	[Token(Token = "0x40012BE")]
	[FieldOffset(Offset = "0x28")]
	private static readonly ProfilerMarker k_MarkerTransformProcessing;

	[Token(Token = "0x40012BF")]
	[FieldOffset(Offset = "0x30")]
	private static readonly ProfilerMarker k_MarkerVisualsProcessing;

	[Token(Token = "0x40012C0")]
	[FieldOffset(Offset = "0x38")]
	private static readonly ProfilerMarker k_MarkerSerialize;

	[Token(Token = "0x40012C8")]
	[FieldOffset(Offset = "0x130")]
	public EntryRecorder entryRecorder;

	[Token(Token = "0x40012CB")]
	[FieldOffset(Offset = "0x148")]
	internal UIRVEShaderInfoAllocator shaderInfoAllocator;

	[Token(Token = "0x1700099F")]
	public OpacityIdAccelerator opacityIdAccelerator
	{
		[Token(Token = "0x60025DB")]
		[Address(RVA = "0x5961D0", Offset = "0x5953D0", VA = "0x1805961D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x60025DC")]
		[Address(RVA = "0x5FC6E0", Offset = "0x5FB8E0", VA = "0x1805FC6E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x170009A0")]
	protected bool disposed
	{
		[Token(Token = "0x60025DF")]
		[Address(RVA = "0x49B790", Offset = "0x49A990", VA = "0x18049B790")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60025E0")]
		[Address(RVA = "0x49C010", Offset = "0x49B210", VA = "0x18049C010")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x170009A1")]
	internal unsafe ref ChainBuilderStats statsByRef
	{
		[Token(Token = "0x60025E3")]
		[Address(RVA = "0x2A5D4D0", Offset = "0x2A5C6D0", VA = "0x182A5D4D0")]
		get
		{
			return ref *(ChainBuilderStats*)null;
		}
	}

	[Token(Token = "0x170009A2")]
	internal BaseVisualElementPanel panel
	{
		[Token(Token = "0x60025F2")]
		[Address(RVA = "0x5FC5E0", Offset = "0x5FB7E0", VA = "0x1805FC5E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x60025F3")]
		[Address(RVA = "0x5968C0", Offset = "0x595AC0", VA = "0x1805968C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x170009A3")]
	internal UIRenderDevice device
	{
		[Token(Token = "0x60025F4")]
		[Address(RVA = "0x5FC5F0", Offset = "0x5FB7F0", VA = "0x1805FC5F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x60025F5")]
		[Address(RVA = "0x5FC6A0", Offset = "0x5FB8A0", VA = "0x1805FC6A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x170009A4")]
	public BaseElementBuilder elementBuilder
	{
		[Token(Token = "0x60025F6")]
		[Address(RVA = "0x2A5D460", Offset = "0x2A5C660", VA = "0x182A5D460")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170009A5")]
	internal AtlasBase atlas
	{
		[Token(Token = "0x60025F7")]
		[Address(RVA = "0x3DA790", Offset = "0x3D9990", VA = "0x1803DA790")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x60025F8")]
		[Address(RVA = "0x3DA7A0", Offset = "0x3D99A0", VA = "0x1803DA7A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x170009A6")]
	internal VectorImageManager vectorImageManager
	{
		[Token(Token = "0x60025F9")]
		[Address(RVA = "0x4D0610", Offset = "0x4CF810", VA = "0x1804D0610")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x60025FA")]
		[Address(RVA = "0x587E30", Offset = "0x587030", VA = "0x180587E30")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x170009A7")]
	internal TempMeshAllocatorImpl tempMeshAllocator
	{
		[Token(Token = "0x60025FB")]
		[Address(RVA = "0x9538F0", Offset = "0x952AF0", VA = "0x1809538F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x60025FC")]
		[Address(RVA = "0x596720", Offset = "0x595920", VA = "0x180596720")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x170009A8")]
	internal MeshWriteDataPool meshWriteDataPool
	{
		[Token(Token = "0x60025FD")]
		[Address(RVA = "0x62DA80", Offset = "0x62CC80", VA = "0x18062DA80")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170009A9")]
	internal EntryPool entryPool
	{
		[Token(Token = "0x60025FE")]
		[Address(RVA = "0x2A5D480", Offset = "0x2A5C680", VA = "0x182A5D480")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170009AA")]
	public MeshGenerationDeferrer meshGenerationDeferrer
	{
		[Token(Token = "0x60025FF")]
		[Address(RVA = "0x449820", Offset = "0x448A20", VA = "0x180449820")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170009AB")]
	public MeshGenerationNodeManager meshGenerationNodeManager
	{
		[Token(Token = "0x6002600")]
		[Address(RVA = "0x7ACC30", Offset = "0x7ABE30", VA = "0x1807ACC30")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6002601")]
		[Address(RVA = "0x7ACDE0", Offset = "0x7ABFE0", VA = "0x1807ACDE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x170009AC")]
	internal JobManager jobManager
	{
		[Token(Token = "0x6002602")]
		[Address(RVA = "0xB19AE0", Offset = "0xB18CE0", VA = "0x180B19AE0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6002603")]
		[Address(RVA = "0xB19B50", Offset = "0xB18D50", VA = "0x180B19B50")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x170009AD")]
	internal bool drawStats
	{
		[Token(Token = "0x6002604")]
		[Address(RVA = "0xF1A840", Offset = "0xF19A40", VA = "0x180F1A840")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6002605")]
		[Address(RVA = "0xF1A890", Offset = "0xF19A90", VA = "0x180F1A890")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x170009AE")]
	internal bool drawInCameras
	{
		[Token(Token = "0x6002606")]
		[Address(RVA = "0xA76E00", Offset = "0xA76000", VA = "0x180A76E00")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170009AF")]
	internal bool isFlat
	{
		[Token(Token = "0x6002607")]
		[Address(RVA = "0xA76E20", Offset = "0xA76020", VA = "0x180A76E20")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170009B0")]
	public bool forceGammaRendering
	{
		[Token(Token = "0x6002608")]
		[Address(RVA = "0xA76E10", Offset = "0xA76010", VA = "0x180A76E10")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x60025DD")]
	[Address(RVA = "0x2A5D2B0", Offset = "0x2A5C4B0", VA = "0x182A5D2B0")]
	public RenderChain(BaseVisualElementPanel panel)
	{
	}

	[Token(Token = "0x60025DE")]
	[Address(RVA = "0x2A5C450", Offset = "0x2A5B650", VA = "0x182A5C450")]
	protected RenderChain(BaseVisualElementPanel panel, UIRenderDevice device, AtlasBase atlas, VectorImageManager vectorImageManager)
	{
	}

	[Token(Token = "0x60025E1")]
	[Address(RVA = "0x2A591F0", Offset = "0x2A583F0", VA = "0x182A591F0", Slot = "4")]
	public void Dispose()
	{
	}

	[Token(Token = "0x60025E2")]
	[Address(RVA = "0x2A58C10", Offset = "0x2A57E10", VA = "0x182A58C10")]
	protected void Dispose(bool disposing)
	{
	}

	[Token(Token = "0x60025E4")]
	[Address(RVA = "0x2A5A1D0", Offset = "0x2A593D0", VA = "0x182A5A1D0")]
	public void ProcessChanges()
	{
	}

	[Token(Token = "0x60025E5")]
	[Address(RVA = "0x2A5B170", Offset = "0x2A5A370", VA = "0x182A5B170")]
	private void SerializeCommandsForCameras()
	{
	}

	[Token(Token = "0x60025E6")]
	[Address(RVA = "0x2A5AA70", Offset = "0x2A59C70", VA = "0x182A5AA70")]
	public void Render()
	{
	}

	[Token(Token = "0x60025E7")]
	[Address(RVA = "0x2A5B4C0", Offset = "0x2A5A6C0", VA = "0x182A5B4C0")]
	public void UIEOnChildAdded(VisualElement ve)
	{
	}

	[Token(Token = "0x60025E8")]
	[Address(RVA = "0x2A5B8F0", Offset = "0x2A5AAF0", VA = "0x182A5B8F0")]
	public void UIEOnChildrenReordered(VisualElement ve)
	{
	}

	[Token(Token = "0x60025E9")]
	[Address(RVA = "0x2A5B7E0", Offset = "0x2A5A9E0", VA = "0x182A5B7E0")]
	public void UIEOnChildRemoving(VisualElement ve)
	{
	}

	[Token(Token = "0x60025EA")]
	[Address(RVA = "0x2A5BF20", Offset = "0x2A5B120", VA = "0x182A5BF20")]
	public void UIEOnRenderHintsChanged(VisualElement ve)
	{
	}

	[Token(Token = "0x60025EB")]
	[Address(RVA = "0x2A5BC00", Offset = "0x2A5AE00", VA = "0x182A5BC00")]
	public void UIEOnClippingChanged(VisualElement ve, bool hierarchical)
	{
	}

	[Token(Token = "0x60025EC")]
	[Address(RVA = "0x2A5BDE0", Offset = "0x2A5AFE0", VA = "0x182A5BDE0")]
	public void UIEOnOpacityChanged(VisualElement ve, bool hierarchical = false)
	{
	}

	[Token(Token = "0x60025ED")]
	[Address(RVA = "0x2A5BCA0", Offset = "0x2A5AEA0", VA = "0x182A5BCA0")]
	public void UIEOnColorChanged(VisualElement ve)
	{
	}

	[Token(Token = "0x60025EE")]
	[Address(RVA = "0x2A5C0E0", Offset = "0x2A5B2E0", VA = "0x182A5C0E0")]
	public void UIEOnTransformOrSizeChanged(VisualElement ve, bool transformChanged, bool clipRectSizeChanged)
	{
	}

	[Token(Token = "0x60025EF")]
	[Address(RVA = "0x2A5C190", Offset = "0x2A5B390", VA = "0x182A5C190")]
	public void UIEOnVisualsChanged(VisualElement ve, bool hierarchical)
	{
	}

	[Token(Token = "0x60025F0")]
	[Address(RVA = "0x2A5BE80", Offset = "0x2A5B080", VA = "0x182A5BE80")]
	public void UIEOnOpacityIdChanged(VisualElement ve)
	{
	}

	[Token(Token = "0x60025F1")]
	[Address(RVA = "0x2A5BD40", Offset = "0x2A5AF40", VA = "0x182A5BD40")]
	public void UIEOnDisableRenderingChanged(VisualElement ve)
	{
	}

	[Token(Token = "0x6002609")]
	[Address(RVA = "0x2A59C20", Offset = "0x2A58E20", VA = "0x182A59C20")]
	internal void EnsureFitsDepth(int depth)
	{
	}

	[Token(Token = "0x600260A")]
	[Address(RVA = "0x2A58B60", Offset = "0x2A57D60", VA = "0x182A58B60")]
	internal void ChildWillBeRemoved(VisualElement ve)
	{
	}

	[Token(Token = "0x600260B")]
	[Address(RVA = "0x2A58B10", Offset = "0x2A57D10", VA = "0x182A58B10")]
	internal RenderChainCommand AllocCommand()
	{
		return null;
	}

	[Token(Token = "0x600260C")]
	[Address(RVA = "0x2A59C30", Offset = "0x2A58E30", VA = "0x182A59C30")]
	internal void FreeCommand(RenderChainCommand cmd)
	{
	}

	[Token(Token = "0x600260D")]
	[Address(RVA = "0x2A5A160", Offset = "0x2A59360", VA = "0x182A5A160")]
	internal void OnRenderCommandAdded(RenderChainCommand command)
	{
	}

	[Token(Token = "0x600260E")]
	[Address(RVA = "0x2A5A190", Offset = "0x2A59390", VA = "0x182A5A190")]
	internal void OnRenderCommandsRemoved(RenderChainCommand firstCommand, RenderChainCommand lastCommand)
	{
	}

	[Token(Token = "0x600260F")]
	[Address(RVA = "0x2A5AEF0", Offset = "0x2A5A0F0", VA = "0x182A5AEF0")]
	internal void RepaintTexturedElements()
	{
	}

	[Token(Token = "0x6002610")]
	[Address(RVA = "0x2A59F00", Offset = "0x2A59100", VA = "0x182A59F00")]
	public ExtraRenderChainVEData GetOrAddExtraData(VisualElement ve)
	{
		return null;
	}

	[Token(Token = "0x6002611")]
	[Address(RVA = "0x2A59CA0", Offset = "0x2A58EA0", VA = "0x182A59CA0")]
	public void FreeExtraData(VisualElement ve)
	{
	}

	[Token(Token = "0x6002612")]
	[Address(RVA = "0x2A59FD0", Offset = "0x2A591D0", VA = "0x182A59FD0")]
	public void InsertExtraMesh(VisualElement ve, MeshHandle mesh)
	{
	}

	[Token(Token = "0x6002613")]
	[Address(RVA = "0x2A59DA0", Offset = "0x2A58FA0", VA = "0x182A59DA0")]
	public void FreeExtraMeshes(VisualElement ve)
	{
	}

	[Token(Token = "0x6002614")]
	[Address(RVA = "0x2A5A0A0", Offset = "0x2A592A0", VA = "0x182A5A0A0")]
	public void InsertTexture(VisualElement ve, Texture src, TextureId id, bool isAtlas)
	{
	}

	[Token(Token = "0x6002615")]
	[Address(RVA = "0x2A5B040", Offset = "0x2A5A240", VA = "0x182A5B040")]
	public void ResetTextures(VisualElement ve)
	{
	}

	[Token(Token = "0x6002616")]
	[Address(RVA = "0x2A59250", Offset = "0x2A58450", VA = "0x182A59250")]
	private void DrawStats()
	{
	}

	[Token(Token = "0x6002617")]
	[Address(RVA = "0x2A59ED0", Offset = "0x2A590D0", VA = "0x182A59ED0")]
	private static VisualElement GetFirstElementInPanel(VisualElement ve)
	{
		return null;
	}
}
