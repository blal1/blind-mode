using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Unity.Collections;
using Unity.Jobs;
using Unity.Profiling;
using UnityEngine.Pool;
using UnityEngine.TextCore.LowLevel;
using UnityEngine.TextCore.Text;
using UnityEngine.UIElements.UIR;

namespace UnityEngine.UIElements;

[Token(Token = "0x200045C")]
internal class UITKTextJobSystem
{
	[Token(Token = "0x200045D")]
	private class ManagedJobData
	{
		[Token(Token = "0x4000E84")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public TextElement visualElement;

		[Token(Token = "0x4000E85")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public MeshGenerationNode node;

		[Token(Token = "0x4000E86")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public List<Material> materials;

		[Token(Token = "0x4000E87")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public List<GlyphRenderMode> renderModes;

		[Token(Token = "0x4000E88")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public List<NativeSlice<Vertex>> vertices;

		[Token(Token = "0x4000E89")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public List<NativeSlice<ushort>> indices;

		[Token(Token = "0x4000E8A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public bool prepareSuccess;

		[Token(Token = "0x6002076")]
		[Address(RVA = "0x29F76A0", Offset = "0x29F68A0", VA = "0x1829F76A0")]
		public void Release()
		{
		}

		[Token(Token = "0x6002077")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public ManagedJobData()
		{
		}
	}

	[Token(Token = "0x200045E")]
	private struct PrepareTextJobData : IJobParallelFor
	{
		[Token(Token = "0x4000E8B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public GCHandle managedJobDataHandle;

		[Token(Token = "0x6002078")]
		[Address(RVA = "0x29F7A00", Offset = "0x29F6C00", VA = "0x1829F7A00", Slot = "4")]
		public void Execute(int index)
		{
		}
	}

	[Token(Token = "0x200045F")]
	private struct GenerateTextJobData : IJobParallelFor
	{
		[Token(Token = "0x4000E8C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public GCHandle managedJobDataHandle;

		[Token(Token = "0x4000E8D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		[ReadOnly]
		public TempMeshAllocator alloc;

		[Token(Token = "0x6002079")]
		[Address(RVA = "0x2A09BE0", Offset = "0x2A08DE0", VA = "0x182A09BE0", Slot = "4")]
		public void Execute(int index)
		{
		}
	}

	[Token(Token = "0x4000E75")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static readonly ProfilerMarker k_ExecuteMarker;

	[Token(Token = "0x4000E76")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private static readonly ProfilerMarker k_UpdateMainThreadMarker;

	[Token(Token = "0x4000E77")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private static readonly ProfilerMarker k_PrepareMainThreadMarker;

	[Token(Token = "0x4000E78")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private static readonly ProfilerMarker k_PrepareJobifiedMarker;

	[Token(Token = "0x4000E79")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private GCHandle textJobDatasHandle;

	[Token(Token = "0x4000E7A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private List<ManagedJobData> textJobDatas;

	[Token(Token = "0x4000E7B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private bool hasPendingTextWork;

	[Token(Token = "0x4000E7C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private static UnityEngine.Pool.ObjectPool<ManagedJobData> s_JobDataPool;

	[Token(Token = "0x4000E7D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private static UnityEngine.Pool.ObjectPool<List<Material>> s_MaterialsPool;

	[Token(Token = "0x4000E7E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private static UnityEngine.Pool.ObjectPool<List<GlyphRenderMode>> s_RenderModesPool;

	[Token(Token = "0x4000E7F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private static UnityEngine.Pool.ObjectPool<List<NativeSlice<Vertex>>> s_VerticesPool;

	[Token(Token = "0x4000E80")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private static UnityEngine.Pool.ObjectPool<List<NativeSlice<ushort>>> s_IndicesPool;

	[Token(Token = "0x4000E81")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	internal MeshGenerationCallback m_PrepareTextJobifiedCallback;

	[Token(Token = "0x4000E82")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	internal MeshGenerationCallback m_GenerateTextJobifiedCallback;

	[Token(Token = "0x4000E83")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	internal MeshGenerationCallback m_AddDrawEntriesCallback;

	[Token(Token = "0x600206E")]
	[Address(RVA = "0x2A07190", Offset = "0x2A06390", VA = "0x182A07190")]
	public UITKTextJobSystem()
	{
	}

	[Token(Token = "0x600206F")]
	[Address(RVA = "0x2A06880", Offset = "0x2A05A80", VA = "0x182A06880")]
	private static void OnGetManagedJob(ManagedJobData managedJobData)
	{
	}

	[Token(Token = "0x6002070")]
	[Address(RVA = "0x2A066E0", Offset = "0x2A058E0", VA = "0x182A066E0")]
	internal void GenerateText(MeshGenerationContext mgc, TextElement textElement)
	{
	}

	[Token(Token = "0x6002071")]
	[Address(RVA = "0x2A068F0", Offset = "0x2A05AF0", VA = "0x182A068F0")]
	internal void PrepareTextJobified(MeshGenerationContext mgc, object _)
	{
	}

	[Token(Token = "0x6002072")]
	[Address(RVA = "0x2A06280", Offset = "0x2A05480", VA = "0x182A06280")]
	private void GenerateTextJobified(MeshGenerationContext mgc, object _)
	{
	}

	[Token(Token = "0x6002073")]
	[Address(RVA = "0x2A054E0", Offset = "0x2A046E0", VA = "0x182A054E0")]
	private static void ConvertMeshInfoToUIRVertex(UnityEngine.TextCore.Text.MeshInfo[] meshInfos, TempMeshAllocator alloc, TextElement visualElement, ref List<Material> materials, ref List<NativeSlice<Vertex>> verticesArray, ref List<NativeSlice<ushort>> indicesArray, ref List<GlyphRenderMode> renderModes)
	{
	}

	[Token(Token = "0x6002074")]
	[Address(RVA = "0x2A04FE0", Offset = "0x2A041E0", VA = "0x182A04FE0")]
	private void AddDrawEntries(MeshGenerationContext mgc, object _)
	{
	}
}
