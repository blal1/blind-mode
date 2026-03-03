using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Unity.Collections;
using Unity.Jobs;
using Unity.Profiling;
using UnityEngine.TextCore.LowLevel;
using UnityEngine.TextCore.Text;

namespace UnityEngine.UIElements.UIR;

[Token(Token = "0x200054B")]
internal class MeshGenerator : IMeshGenerator, IDisposable
{
	[Token(Token = "0x200054C")]
	private struct RepeatRectUV
	{
		[Token(Token = "0x400123D")]
		[FieldOffset(Offset = "0x0")]
		public Rect rect;

		[Token(Token = "0x400123E")]
		[FieldOffset(Offset = "0x10")]
		public Rect uv;
	}

	[Token(Token = "0x200054D")]
	public struct BackgroundRepeatInstance
	{
		[Token(Token = "0x400123F")]
		[FieldOffset(Offset = "0x0")]
		public Rect rect;

		[Token(Token = "0x4001240")]
		[FieldOffset(Offset = "0x10")]
		public Rect backgroundRepeatRect;

		[Token(Token = "0x4001241")]
		[FieldOffset(Offset = "0x20")]
		public Rect uv;
	}

	[Token(Token = "0x200054E")]
	public struct BorderParams
	{
		[Token(Token = "0x4001242")]
		[FieldOffset(Offset = "0x0")]
		public Rect rect;

		[Token(Token = "0x4001243")]
		[FieldOffset(Offset = "0x10")]
		public Color playmodeTintColor;

		[Token(Token = "0x4001244")]
		[FieldOffset(Offset = "0x20")]
		public Color leftColor;

		[Token(Token = "0x4001245")]
		[FieldOffset(Offset = "0x30")]
		public Color topColor;

		[Token(Token = "0x4001246")]
		[FieldOffset(Offset = "0x40")]
		public Color rightColor;

		[Token(Token = "0x4001247")]
		[FieldOffset(Offset = "0x50")]
		public Color bottomColor;

		[Token(Token = "0x4001248")]
		[FieldOffset(Offset = "0x60")]
		public float leftWidth;

		[Token(Token = "0x4001249")]
		[FieldOffset(Offset = "0x64")]
		public float topWidth;

		[Token(Token = "0x400124A")]
		[FieldOffset(Offset = "0x68")]
		public float rightWidth;

		[Token(Token = "0x400124B")]
		[FieldOffset(Offset = "0x6C")]
		public float bottomWidth;

		[Token(Token = "0x400124C")]
		[FieldOffset(Offset = "0x70")]
		public Vector2 topLeftRadius;

		[Token(Token = "0x400124D")]
		[FieldOffset(Offset = "0x78")]
		public Vector2 topRightRadius;

		[Token(Token = "0x400124E")]
		[FieldOffset(Offset = "0x80")]
		public Vector2 bottomRightRadius;

		[Token(Token = "0x400124F")]
		[FieldOffset(Offset = "0x88")]
		public Vector2 bottomLeftRadius;

		[Token(Token = "0x4001250")]
		[FieldOffset(Offset = "0x90")]
		internal ColorPage leftColorPage;

		[Token(Token = "0x4001251")]
		[FieldOffset(Offset = "0x98")]
		internal ColorPage topColorPage;

		[Token(Token = "0x4001252")]
		[FieldOffset(Offset = "0xA0")]
		internal ColorPage rightColorPage;

		[Token(Token = "0x4001253")]
		[FieldOffset(Offset = "0xA8")]
		internal ColorPage bottomColorPage;

		[Token(Token = "0x60025A4")]
		[Address(RVA = "0x2A46290", Offset = "0x2A45490", VA = "0x182A46290")]
		internal MeshBuilderNative.NativeBorderParams ToNativeParams()
		{
			return default(MeshBuilderNative.NativeBorderParams);
		}
	}

	[Token(Token = "0x200054F")]
	public struct RectangleParams
	{
		[Token(Token = "0x4001254")]
		[FieldOffset(Offset = "0x0")]
		public Rect rect;

		[Token(Token = "0x4001255")]
		[FieldOffset(Offset = "0x10")]
		public Rect uv;

		[Token(Token = "0x4001256")]
		[FieldOffset(Offset = "0x20")]
		public Color color;

		[Token(Token = "0x4001257")]
		[FieldOffset(Offset = "0x30")]
		public Rect subRect;

		[Token(Token = "0x4001258")]
		[FieldOffset(Offset = "0x40")]
		public Rect backgroundRepeatRect;

		[Token(Token = "0x4001259")]
		[FieldOffset(Offset = "0x50")]
		public NativePagedList<BackgroundRepeatInstance> backgroundRepeatInstanceList;

		[Token(Token = "0x400125A")]
		[FieldOffset(Offset = "0x58")]
		public int backgroundRepeatInstanceListStartIndex;

		[Token(Token = "0x400125B")]
		[FieldOffset(Offset = "0x5C")]
		public int backgroundRepeatInstanceListEndIndex;

		[Token(Token = "0x400125C")]
		[FieldOffset(Offset = "0x60")]
		public BackgroundPosition backgroundPositionX;

		[Token(Token = "0x400125D")]
		[FieldOffset(Offset = "0x6C")]
		public BackgroundPosition backgroundPositionY;

		[Token(Token = "0x400125E")]
		[FieldOffset(Offset = "0x78")]
		public BackgroundRepeat backgroundRepeat;

		[Token(Token = "0x400125F")]
		[FieldOffset(Offset = "0x80")]
		public BackgroundSize backgroundSize;

		[Token(Token = "0x4001260")]
		[FieldOffset(Offset = "0x98")]
		public Texture texture;

		[Token(Token = "0x4001261")]
		[FieldOffset(Offset = "0xA0")]
		public Sprite sprite;

		[Token(Token = "0x4001262")]
		[FieldOffset(Offset = "0xA8")]
		public VectorImage vectorImage;

		[Token(Token = "0x4001263")]
		[FieldOffset(Offset = "0xB0")]
		public ScaleMode scaleMode;

		[Token(Token = "0x4001264")]
		[FieldOffset(Offset = "0xB4")]
		public Color playmodeTintColor;

		[Token(Token = "0x4001265")]
		[FieldOffset(Offset = "0xC4")]
		public Vector2 topLeftRadius;

		[Token(Token = "0x4001266")]
		[FieldOffset(Offset = "0xCC")]
		public Vector2 topRightRadius;

		[Token(Token = "0x4001267")]
		[FieldOffset(Offset = "0xD4")]
		public Vector2 bottomRightRadius;

		[Token(Token = "0x4001268")]
		[FieldOffset(Offset = "0xDC")]
		public Vector2 bottomLeftRadius;

		[Token(Token = "0x4001269")]
		[FieldOffset(Offset = "0xE4")]
		public Vector2 contentSize;

		[Token(Token = "0x400126A")]
		[FieldOffset(Offset = "0xEC")]
		public Vector2 textureSize;

		[Token(Token = "0x400126B")]
		[FieldOffset(Offset = "0xF4")]
		public int leftSlice;

		[Token(Token = "0x400126C")]
		[FieldOffset(Offset = "0xF8")]
		public int topSlice;

		[Token(Token = "0x400126D")]
		[FieldOffset(Offset = "0xFC")]
		public int rightSlice;

		[Token(Token = "0x400126E")]
		[FieldOffset(Offset = "0x100")]
		public int bottomSlice;

		[Token(Token = "0x400126F")]
		[FieldOffset(Offset = "0x104")]
		public float sliceScale;

		[Token(Token = "0x4001270")]
		[FieldOffset(Offset = "0x108")]
		internal Rect spriteGeomRect;

		[Token(Token = "0x4001271")]
		[FieldOffset(Offset = "0x118")]
		public Vector4 rectInset;

		[Token(Token = "0x4001272")]
		[FieldOffset(Offset = "0x128")]
		internal ColorPage colorPage;

		[Token(Token = "0x4001273")]
		[FieldOffset(Offset = "0x130")]
		internal MeshGenerationContext.MeshFlags meshFlags;

		[Token(Token = "0x60025A5")]
		[Address(RVA = "0x2A53B70", Offset = "0x2A52D70", VA = "0x182A53B70")]
		private static void AdjustUVsForScaleMode(Rect rect, Rect uv, Texture texture, ScaleMode scaleMode, out Rect rectOut, out Rect uvOut)
		{
		}

		[Token(Token = "0x60025A6")]
		[Address(RVA = "0x2A53690", Offset = "0x2A52890", VA = "0x182A53690")]
		private static void AdjustSpriteUVsForScaleMode(Rect containerRect, Rect srcRect, Rect spriteGeomRect, Sprite sprite, ScaleMode scaleMode, out Rect rectOut, out Rect uvOut)
		{
		}

		[Token(Token = "0x60025A7")]
		[Address(RVA = "0x2A553A0", Offset = "0x2A545A0", VA = "0x182A553A0")]
		internal static Rect RectIntersection(Rect a, Rect b)
		{
			return default(Rect);
		}

		[Token(Token = "0x60025A8")]
		[Address(RVA = "0x2A53E40", Offset = "0x2A53040", VA = "0x182A53E40")]
		private static Rect ComputeGeomRect(Sprite sprite)
		{
			return default(Rect);
		}

		[Token(Token = "0x60025A9")]
		[Address(RVA = "0x2A53F50", Offset = "0x2A53150", VA = "0x182A53F50")]
		private static Rect ComputeUVRect(Sprite sprite)
		{
			return default(Rect);
		}

		[Token(Token = "0x60025AA")]
		[Address(RVA = "0x2A53D80", Offset = "0x2A52F80", VA = "0x182A53D80")]
		private static Rect ApplyPackingRotation(Rect uv, SpritePackingRotation rotation)
		{
			return default(Rect);
		}

		[Token(Token = "0x60025AB")]
		[Address(RVA = "0x2A54FA0", Offset = "0x2A541A0", VA = "0x182A54FA0")]
		public static RectangleParams MakeTextured(Rect rect, Rect uv, Texture texture, ScaleMode scaleMode, Color playModeTintColor)
		{
			return default(RectangleParams);
		}

		[Token(Token = "0x60025AC")]
		[Address(RVA = "0x2A54130", Offset = "0x2A53330", VA = "0x182A54130")]
		public static RectangleParams MakeSprite(Rect containerRect, Rect subRect, Sprite sprite, ScaleMode scaleMode, Color playModeTintColor, bool hasRadius, ref Vector4 slices, bool useForRepeat = false)
		{
			return default(RectangleParams);
		}

		[Token(Token = "0x60025AD")]
		[Address(RVA = "0x2A551E0", Offset = "0x2A543E0", VA = "0x182A551E0")]
		public static RectangleParams MakeVectorTextured(Rect rect, Rect uv, VectorImage vectorImage, ScaleMode scaleMode, Color playModeTintColor)
		{
			return default(RectangleParams);
		}

		[Token(Token = "0x60025AE")]
		[Address(RVA = "0x2A54060", Offset = "0x2A53260", VA = "0x182A54060")]
		internal bool HasRadius(float epsilon)
		{
			return default(bool);
		}

		[Token(Token = "0x60025AF")]
		[Address(RVA = "0x2A540E0", Offset = "0x2A532E0", VA = "0x182A540E0")]
		internal bool HasSlices(float epsilon)
		{
			return default(bool);
		}

		[Token(Token = "0x60025B0")]
		[Address(RVA = "0x2A554A0", Offset = "0x2A546A0", VA = "0x182A554A0")]
		internal MeshBuilderNative.NativeRectParams ToNativeParams()
		{
			return default(MeshBuilderNative.NativeRectParams);
		}
	}

	[Token(Token = "0x2000550")]
	private struct TessellationJobParameters
	{
		[Token(Token = "0x4001274")]
		[FieldOffset(Offset = "0x0")]
		public bool isBorderJob;

		[Token(Token = "0x4001275")]
		[FieldOffset(Offset = "0x8")]
		public MeshBuilderNative.NativeRectParams rectParams;

		[Token(Token = "0x4001276")]
		[FieldOffset(Offset = "0x120")]
		public BorderParams borderParams;

		[Token(Token = "0x4001277")]
		[FieldOffset(Offset = "0x1D0")]
		public UnsafeMeshGenerationNode node;
	}

	[Token(Token = "0x2000551")]
	private struct TessellationJob : IJobParallelFor
	{
		[Token(Token = "0x4001278")]
		[FieldOffset(Offset = "0x0")]
		[ReadOnly]
		public TempMeshAllocator allocator;

		[Token(Token = "0x4001279")]
		[FieldOffset(Offset = "0x8")]
		[ReadOnly]
		public NativeSlice<TessellationJobParameters> jobParameters;

		[Token(Token = "0x60025B1")]
		[Address(RVA = "0x2A64E70", Offset = "0x2A64070", VA = "0x182A64E70", Slot = "4")]
		public void Execute(int i)
		{
		}

		[Token(Token = "0x60025B2")]
		private T ExtractHandle<T>(IntPtr handlePtr) where T : class
		{
			return null;
		}

		[Token(Token = "0x60025B3")]
		[Address(RVA = "0x2A63060", Offset = "0x2A62260", VA = "0x182A63060")]
		private void DrawBorder(UnsafeMeshGenerationNode node, ref BorderParams borderParams)
		{
		}

		[Token(Token = "0x60025B4")]
		[Address(RVA = "0x2A63440", Offset = "0x2A62640", VA = "0x182A63440")]
		private void DrawRectangle(UnsafeMeshGenerationNode node, ref MeshBuilderNative.NativeRectParams rectParams, Texture tex)
		{
		}

		[Token(Token = "0x60025B5")]
		[Address(RVA = "0x2A64180", Offset = "0x2A63380", VA = "0x182A64180")]
		private void DrawSprite(UnsafeMeshGenerationNode node, ref MeshBuilderNative.NativeRectParams rectParams, Sprite sprite)
		{
		}

		[Token(Token = "0x60025B6")]
		[Address(RVA = "0x2A64770", Offset = "0x2A63970", VA = "0x182A64770")]
		private void DrawVectorImage(UnsafeMeshGenerationNode node, ref MeshBuilderNative.NativeRectParams rectParams, VectorImage vi)
		{
		}
	}

	[Token(Token = "0x4001228")]
	[FieldOffset(Offset = "0x0")]
	private static readonly ProfilerMarker k_MarkerDrawRectangle;

	[Token(Token = "0x4001229")]
	[FieldOffset(Offset = "0x8")]
	private static readonly ProfilerMarker k_MarkerDrawBorder;

	[Token(Token = "0x400122A")]
	[FieldOffset(Offset = "0x10")]
	private static readonly ProfilerMarker k_MarkerDrawVectorImage;

	[Token(Token = "0x400122B")]
	[FieldOffset(Offset = "0x18")]
	private static readonly ProfilerMarker k_MarkerDrawRectangleRepeat;

	[Token(Token = "0x400122C")]
	[FieldOffset(Offset = "0x10")]
	private MeshGenerationContext m_MeshGenerationContext;

	[Token(Token = "0x400122D")]
	[FieldOffset(Offset = "0x18")]
	private List<RepeatRectUV>[] m_RepeatRectUVList;

	[Token(Token = "0x400122E")]
	[FieldOffset(Offset = "0x20")]
	private NativePagedList<BackgroundRepeatInstance> m_BackgroundRepeatInstanceList;

	[Token(Token = "0x400122F")]
	[FieldOffset(Offset = "0x28")]
	private GCHandlePool m_GCHandlePool;

	[Token(Token = "0x4001230")]
	[FieldOffset(Offset = "0x30")]
	private NativeArray<TessellationJobParameters> m_JobParameters;

	[Token(Token = "0x4001233")]
	[FieldOffset(Offset = "0x50")]
	private UnityEngine.TextCore.Text.TextInfo m_TextInfo;

	[Token(Token = "0x4001234")]
	[FieldOffset(Offset = "0x58")]
	private UnityEngine.TextCore.Text.TextGenerationSettings m_Settings;

	[Token(Token = "0x4001235")]
	[FieldOffset(Offset = "0x60")]
	private List<NativeSlice<Vertex>> m_VerticesArray;

	[Token(Token = "0x4001236")]
	[FieldOffset(Offset = "0x68")]
	private List<NativeSlice<ushort>> m_IndicesArray;

	[Token(Token = "0x4001237")]
	[FieldOffset(Offset = "0x70")]
	private List<Texture2D> m_Atlases;

	[Token(Token = "0x4001238")]
	[FieldOffset(Offset = "0x78")]
	private List<float> m_SdfScales;

	[Token(Token = "0x4001239")]
	[FieldOffset(Offset = "0x80")]
	private List<GlyphRenderMode> m_RenderModes;

	[Token(Token = "0x400123A")]
	[FieldOffset(Offset = "0x88")]
	private MeshGenerationCallback m_OnMeshGenerationDelegate;

	[Token(Token = "0x400123B")]
	[FieldOffset(Offset = "0x90")]
	private List<TessellationJobParameters> m_TesselationJobParameters;

	[Token(Token = "0x17000998")]
	public VisualElement currentElement
	{
		[Token(Token = "0x600258D")]
		[Address(RVA = "0x595530", Offset = "0x594730", VA = "0x180595530", Slot = "4")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x17000999")]
	public TextJobSystem textJobSystem
	{
		[Token(Token = "0x600258E")]
		[Address(RVA = "0x414E80", Offset = "0x414080", VA = "0x180414E80", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x600258F")]
		[Address(RVA = "0x414E90", Offset = "0x414090", VA = "0x180414E90", Slot = "13")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x1700099A")]
	internal bool disposed
	{
		[Token(Token = "0x600259F")]
		[Address(RVA = "0xDB8210", Offset = "0xDB7410", VA = "0x180DB8210")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60025A0")]
		[Address(RVA = "0xE348F0", Offset = "0xE33AF0", VA = "0x180E348F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x600258C")]
	[Address(RVA = "0x2A52DF0", Offset = "0x2A51FF0", VA = "0x182A52DF0")]
	public MeshGenerator(MeshGenerationContext mgc)
	{
	}

	[Token(Token = "0x6002590")]
	[Address(RVA = "0x2A4E2A0", Offset = "0x2A4D4A0", VA = "0x182A4E2A0")]
	private static Vector2 ConvertBorderRadiusPercentToPoints(Vector2 borderRectSize, Length length)
	{
		return default(Vector2);
	}

	[Token(Token = "0x6002591")]
	[Address(RVA = "0x2A51C40", Offset = "0x2A50E40", VA = "0x182A51C40")]
	public static void GetVisualElementRadii(VisualElement ve, out Vector2 topLeft, out Vector2 bottomLeft, out Vector2 topRight, out Vector2 bottomRight)
	{
	}

	[Token(Token = "0x6002592")]
	[Address(RVA = "0x2A4DAE0", Offset = "0x2A4CCE0", VA = "0x182A4DAE0")]
	public static void AdjustBackgroundSizeForBorders(VisualElement visualElement, ref RectangleParams rectParams)
	{
	}

	[Token(Token = "0x6002593")]
	[Address(RVA = "0x2A51930", Offset = "0x2A50B30", VA = "0x182A51930", Slot = "7")]
	public void DrawText(List<NativeSlice<Vertex>> vertices, List<NativeSlice<ushort>> indices, List<Material> materials, List<GlyphRenderMode> renderModes)
	{
	}

	[Token(Token = "0x6002594")]
	[Address(RVA = "0x2A51660", Offset = "0x2A50860", VA = "0x182A51660", Slot = "6")]
	public void DrawText(List<NativeSlice<Vertex>> vertices, List<NativeSlice<ushort>> indices, List<Texture2D> atlases, List<GlyphRenderMode> renderModes, List<float> sdfScales)
	{
	}

	[MethodImpl(256)]
	[Token(Token = "0x6002595")]
	[Address(RVA = "0x29F4310", Offset = "0x29F3510", VA = "0x1829F4310")]
	internal static Vertex ConvertTextVertexToUIRVertex(UnityEngine.TextCore.Text.TextCoreVertex vertex, Vector2 posOffset, bool isDynamicColor = false, bool isColorGlyph = false)
	{
		return default(Vertex);
	}

	[Token(Token = "0x6002596")]
	[Address(RVA = "0x2A51EF0", Offset = "0x2A510F0", VA = "0x182A51EF0")]
	private void MakeText(Texture texture, NativeSlice<Vertex> vertices, NativeSlice<ushort> indices, bool isSdf, float sdfScale, float sharpness, bool multiChannel)
	{
	}

	[Token(Token = "0x6002597")]
	[Address(RVA = "0x2A50A50", Offset = "0x2A4FC50", VA = "0x182A50A50", Slot = "8")]
	public void DrawRectangle(RectangleParams rectParams)
	{
	}

	[Token(Token = "0x6002598")]
	[Address(RVA = "0x2A507B0", Offset = "0x2A4F9B0", VA = "0x182A507B0", Slot = "9")]
	public void DrawBorder(BorderParams borderParams)
	{
	}

	[Token(Token = "0x6002599")]
	[Address(RVA = "0x2A50A20", Offset = "0x2A4FC20", VA = "0x182A50A20", Slot = "10")]
	public void DrawRectangleRepeat(RectangleParams rectParams, Rect totalRect, float scaledPixelsPerPoint)
	{
	}

	[MethodImpl(256)]
	[Token(Token = "0x600259A")]
	[Address(RVA = "0x2A4E460", Offset = "0x2A4D660", VA = "0x182A4E460")]
	private void DoDrawRectangleRepeat(ref RectangleParams rectParams, Rect totalRect, float scaledPixelsPerPoint)
	{
	}

	[Token(Token = "0x600259B")]
	[Address(RVA = "0x2A52400", Offset = "0x2A51600", VA = "0x182A52400")]
	private void StampRectangleWithSubRect(RectangleParams rectParams, Rect targetRect, Rect totalRect, Rect targetUV, ref NativePagedList<BackgroundRepeatInstance> backgroundRepeatInstanceList)
	{
	}

	[Token(Token = "0x600259C")]
	[Address(RVA = "0x2A4DEB0", Offset = "0x2A4D0B0", VA = "0x182A4DEB0")]
	private static void AdjustSpriteWinding(Vector2[] vertices, ushort[] indices, NativeSlice<ushort> newIndices)
	{
	}

	[Token(Token = "0x600259D")]
	[Address(RVA = "0x2A520A0", Offset = "0x2A512A0", VA = "0x182A520A0", Slot = "11")]
	public void ScheduleJobs(MeshGenerationContext mgc)
	{
	}

	[Token(Token = "0x600259E")]
	[Address(RVA = "0x2A52040", Offset = "0x2A51240", VA = "0x182A52040")]
	private void OnMeshGeneration(MeshGenerationContext ctx, object data)
	{
	}

	[Token(Token = "0x60025A1")]
	[Address(RVA = "0x2A4E300", Offset = "0x2A4D500", VA = "0x182A4E300", Slot = "12")]
	public void Dispose()
	{
	}

	[Token(Token = "0x60025A2")]
	[Address(RVA = "0x2A4E3C0", Offset = "0x2A4D5C0", VA = "0x182A4E3C0")]
	private void Dispose(bool disposing)
	{
	}
}
