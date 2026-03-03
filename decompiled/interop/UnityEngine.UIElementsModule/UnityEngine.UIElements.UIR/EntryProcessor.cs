using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Unity.Collections;

namespace UnityEngine.UIElements.UIR;

[Token(Token = "0x2000535")]
internal class EntryProcessor
{
	[Token(Token = "0x2000536")]
	private struct MaskMesh
	{
		[Token(Token = "0x40011AC")]
		[FieldOffset(Offset = "0x0")]
		public NativeSlice<Vertex> vertices;

		[Token(Token = "0x40011AD")]
		[FieldOffset(Offset = "0x10")]
		public NativeSlice<ushort> indices;

		[Token(Token = "0x40011AE")]
		[FieldOffset(Offset = "0x20")]
		public int indexOffset;
	}

	[Token(Token = "0x4001182")]
	[FieldOffset(Offset = "0x10")]
	private EntryPreProcessor m_PreProcessor;

	[Token(Token = "0x4001183")]
	[FieldOffset(Offset = "0x18")]
	private RenderChain m_RenderChain;

	[Token(Token = "0x4001184")]
	[FieldOffset(Offset = "0x20")]
	private VisualElement m_CurrentElement;

	[Token(Token = "0x4001185")]
	[FieldOffset(Offset = "0x28")]
	private int m_MaskDepth;

	[Token(Token = "0x4001186")]
	[FieldOffset(Offset = "0x2C")]
	private int m_MaskDepthPopped;

	[Token(Token = "0x4001187")]
	[FieldOffset(Offset = "0x30")]
	private int m_MaskDepthPushed;

	[Token(Token = "0x4001188")]
	[FieldOffset(Offset = "0x34")]
	private int m_StencilRef;

	[Token(Token = "0x4001189")]
	[FieldOffset(Offset = "0x38")]
	private int m_StencilRefPopped;

	[Token(Token = "0x400118A")]
	[FieldOffset(Offset = "0x3C")]
	private int m_StencilRefPushed;

	[Token(Token = "0x400118B")]
	[FieldOffset(Offset = "0x40")]
	private BMPAlloc m_ClipRectId;

	[Token(Token = "0x400118C")]
	[FieldOffset(Offset = "0x48")]
	private BMPAlloc m_ClipRectIdPopped;

	[Token(Token = "0x400118D")]
	[FieldOffset(Offset = "0x50")]
	private BMPAlloc m_ClipRectIdPushed;

	[Token(Token = "0x400118E")]
	[FieldOffset(Offset = "0x58")]
	private bool m_IsDrawingMask;

	[Token(Token = "0x400118F")]
	[FieldOffset(Offset = "0x60")]
	private Stack<MaskMesh> m_MaskMeshes;

	[Token(Token = "0x4001190")]
	[FieldOffset(Offset = "0x68")]
	private bool m_VertexDataComputed;

	[Token(Token = "0x4001191")]
	[FieldOffset(Offset = "0x6C")]
	private Matrix4x4 m_Transform;

	[Token(Token = "0x4001192")]
	[FieldOffset(Offset = "0xAC")]
	private Color32 m_TransformData;

	[Token(Token = "0x4001193")]
	[FieldOffset(Offset = "0xB0")]
	private Color32 m_OpacityData;

	[Token(Token = "0x4001194")]
	[FieldOffset(Offset = "0xB4")]
	private Color32 m_TextCoreSettingsPage;

	[Token(Token = "0x4001195")]
	[FieldOffset(Offset = "0xB8")]
	private MeshHandle m_Mesh;

	[Token(Token = "0x4001196")]
	[FieldOffset(Offset = "0xC0")]
	private NativeSlice<Vertex> m_Verts;

	[Token(Token = "0x4001197")]
	[FieldOffset(Offset = "0xD0")]
	private NativeSlice<ushort> m_Indices;

	[Token(Token = "0x4001198")]
	[FieldOffset(Offset = "0xE0")]
	private ushort m_IndexOffset;

	[Token(Token = "0x4001199")]
	[FieldOffset(Offset = "0xE4")]
	private int m_AllocVertexCount;

	[Token(Token = "0x400119A")]
	[FieldOffset(Offset = "0xE8")]
	private int m_AllocIndex;

	[Token(Token = "0x400119B")]
	[FieldOffset(Offset = "0xEC")]
	private int m_VertsFilled;

	[Token(Token = "0x400119C")]
	[FieldOffset(Offset = "0xF0")]
	private int m_IndicesFilled;

	[Token(Token = "0x400119D")]
	[FieldOffset(Offset = "0xF4")]
	private VertexFlags m_RenderType;

	[Token(Token = "0x400119E")]
	[FieldOffset(Offset = "0xF8")]
	private bool m_RemapUVs;

	[Token(Token = "0x400119F")]
	[FieldOffset(Offset = "0xFC")]
	private Rect m_AtlasRect;

	[Token(Token = "0x40011A0")]
	[FieldOffset(Offset = "0x10C")]
	private int m_GradientSettingIndexOffset;

	[Token(Token = "0x40011A1")]
	[FieldOffset(Offset = "0x110")]
	private bool m_IsTail;

	[Token(Token = "0x40011A2")]
	[FieldOffset(Offset = "0x118")]
	private RenderChainCommand m_FirstCommand;

	[Token(Token = "0x40011A3")]
	[FieldOffset(Offset = "0x120")]
	private RenderChainCommand m_LastCommand;

	[Token(Token = "0x40011A8")]
	[FieldOffset(Offset = "0x0")]
	private static Material s_blitMaterial_LinearToGamma;

	[Token(Token = "0x40011A9")]
	[FieldOffset(Offset = "0x8")]
	private static Material s_blitMaterial_GammaToLinear;

	[Token(Token = "0x40011AA")]
	[FieldOffset(Offset = "0x10")]
	private static Material s_blitMaterial_NoChange;

	[Token(Token = "0x40011AB")]
	[FieldOffset(Offset = "0x18")]
	private static Shader s_blitShader;

	[Token(Token = "0x1700098A")]
	public RenderChainCommand firstHeadCommand
	{
		[Token(Token = "0x6002516")]
		[Address(RVA = "0x62DA80", Offset = "0x62CC80", VA = "0x18062DA80")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6002517")]
		[Address(RVA = "0x62E000", Offset = "0x62D200", VA = "0x18062E000")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x1700098B")]
	public RenderChainCommand lastHeadCommand
	{
		[Token(Token = "0x6002518")]
		[Address(RVA = "0xABF8A0", Offset = "0xABEAA0", VA = "0x180ABF8A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6002519")]
		[Address(RVA = "0xB19AF0", Offset = "0xB18CF0", VA = "0x180B19AF0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x1700098C")]
	public RenderChainCommand firstTailCommand
	{
		[Token(Token = "0x600251A")]
		[Address(RVA = "0x7ACC30", Offset = "0x7ABE30", VA = "0x1807ACC30")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x600251B")]
		[Address(RVA = "0x7ACDE0", Offset = "0x7ABFE0", VA = "0x1807ACDE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x1700098D")]
	public RenderChainCommand lastTailCommand
	{
		[Token(Token = "0x600251C")]
		[Address(RVA = "0xB19AE0", Offset = "0xB18CE0", VA = "0x180B19AE0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x600251D")]
		[Address(RVA = "0xB19B50", Offset = "0xB18D50", VA = "0x180B19B50")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x600251E")]
	[Address(RVA = "0x2A485F0", Offset = "0x2A477F0", VA = "0x182A485F0")]
	public void Init(Entry root, RenderChain renderChain, VisualElement ve)
	{
	}

	[Token(Token = "0x600251F")]
	[Address(RVA = "0x2A47AA0", Offset = "0x2A46CA0", VA = "0x182A47AA0")]
	public void ClearReferences()
	{
	}

	[Token(Token = "0x6002520")]
	[Address(RVA = "0x2A48B60", Offset = "0x2A47D60", VA = "0x182A48B60")]
	public void ProcessHead()
	{
	}

	[Token(Token = "0x6002521")]
	[Address(RVA = "0x2A4A130", Offset = "0x2A49330", VA = "0x182A4A130")]
	public void ProcessTail()
	{
	}

	[Token(Token = "0x6002522")]
	[Address(RVA = "0x2A49720", Offset = "0x2A48920", VA = "0x182A49720")]
	private void ProcessRange(int first, int last)
	{
	}

	[Token(Token = "0x6002523")]
	[Address(RVA = "0x2A48C30", Offset = "0x2A47E30", VA = "0x182A48C30")]
	private void ProcessMeshEntry(Entry entry, TextureId textureId)
	{
	}

	[Token(Token = "0x6002524")]
	[Address(RVA = "0x2A47EB0", Offset = "0x2A470B0", VA = "0x182A47EB0")]
	private void DrawReverseMask()
	{
	}

	[Token(Token = "0x6002525")]
	[Address(RVA = "0x2A47DC0", Offset = "0x2A46FC0", VA = "0x182A47DC0")]
	private RenderChainCommand CreateMeshDrawCommand(MeshHandle mesh, int indexCount, int indexOffset, Material material, TextureId texture)
	{
		return null;
	}

	[MethodImpl(256)]
	[Token(Token = "0x6002526")]
	[Address(RVA = "0x2A43300", Offset = "0x2A42500", VA = "0x182A43300")]
	private void AppendCommand(RenderChainCommand next)
	{
	}

	[Token(Token = "0x6002527")]
	[Address(RVA = "0x2A48920", Offset = "0x2A47B20", VA = "0x182A48920")]
	private void ProcessFirstAlloc(List<EntryPreProcessor.AllocSize> allocList, ref MeshHandle mesh)
	{
	}

	[Token(Token = "0x6002528")]
	[Address(RVA = "0x2A494A0", Offset = "0x2A486A0", VA = "0x182A494A0")]
	private void ProcessNextAlloc()
	{
	}

	[Token(Token = "0x6002529")]
	[Address(RVA = "0x2A4A2A0", Offset = "0x2A494A0", VA = "0x182A4A2A0")]
	private static void UpdateOrAllocate(ref MeshHandle data, int vertexCount, int indexCount, UIRenderDevice device, out NativeSlice<Vertex> verts, out NativeSlice<ushort> indices, out ushort indexOffset, ref ChainBuilderStats stats)
	{
	}

	[Token(Token = "0x600252A")]
	[Address(RVA = "0x2A47BD0", Offset = "0x2A46DD0", VA = "0x182A47BD0")]
	private static Material CreateBlitShader(float colorConversion)
	{
		return null;
	}

	[Token(Token = "0x600252B")]
	[Address(RVA = "0x2A48390", Offset = "0x2A47590", VA = "0x182A48390")]
	private static Material GetBlitMaterial(VisualElement.RenderTargetMode mode)
	{
		return null;
	}

	[Token(Token = "0x600252C")]
	[Address(RVA = "0x2A4A3C0", Offset = "0x2A495C0", VA = "0x182A4A3C0")]
	public EntryProcessor()
	{
	}
}
