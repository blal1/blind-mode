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

[Token(Token = "0x2000452")]
internal class ATGTextJobSystem
{
	[Token(Token = "0x2000453")]
	private class ManagedJobData
	{
		[Token(Token = "0x4000E50")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public TextElement textElement;

		[Token(Token = "0x4000E51")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public MeshGenerationNode node;

		[Token(Token = "0x4000E52")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public UnityEngine.TextCore.Text.NativeTextInfo textInfo;

		[Token(Token = "0x4000E53")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public bool success;

		[Token(Token = "0x6002026")]
		[Address(RVA = "0x29F7820", Offset = "0x29F6A20", VA = "0x1829F7820")]
		public void Release()
		{
		}

		[Token(Token = "0x6002027")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public ManagedJobData()
		{
		}
	}

	[Token(Token = "0x2000454")]
	private struct GenerateTextJobData : IJobParallelFor
	{
		[Token(Token = "0x4000E54")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public GCHandle managedJobDataHandle;

		[Token(Token = "0x6002028")]
		[Address(RVA = "0x29F74A0", Offset = "0x29F66A0", VA = "0x1829F74A0", Slot = "4")]
		public void Execute(int index)
		{
		}
	}

	[Token(Token = "0x4000E42")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private GCHandle textJobDatasHandle;

	[Token(Token = "0x4000E43")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private List<ManagedJobData> textJobDatas;

	[Token(Token = "0x4000E44")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private bool hasPendingTextWork;

	[Token(Token = "0x4000E45")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static UnityEngine.Pool.ObjectPool<ManagedJobData> s_JobDataPool;

	[Token(Token = "0x4000E46")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	internal MeshGenerationCallback m_GenerateTextJobifiedCallback;

	[Token(Token = "0x4000E47")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	internal MeshGenerationCallback m_AddDrawEntriesCallback;

	[Token(Token = "0x4000E48")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private static readonly ProfilerMarker k_GenerateTextMarker;

	[Token(Token = "0x4000E49")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private static readonly ProfilerMarker k_ATGTextJobMarker;

	[Token(Token = "0x4000E4A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private static readonly bool k_IsMultiThreaded;

	[Token(Token = "0x4000E4B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private List<Texture2D> atlases;

	[Token(Token = "0x4000E4C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private List<float> sdfScalesArray;

	[Token(Token = "0x4000E4D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private List<NativeSlice<Vertex>> verticesArray;

	[Token(Token = "0x4000E4E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private List<NativeSlice<ushort>> indicesArray;

	[Token(Token = "0x4000E4F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private List<GlyphRenderMode> renderModes;

	[Token(Token = "0x6002020")]
	[Address(RVA = "0x29F7230", Offset = "0x29F6430", VA = "0x1829F7230")]
	public ATGTextJobSystem()
	{
	}

	[Token(Token = "0x6002021")]
	[Address(RVA = "0x29F6E50", Offset = "0x29F6050", VA = "0x1829F6E50")]
	public void GenerateText(MeshGenerationContext mgc, TextElement textElement)
	{
	}

	[Token(Token = "0x6002022")]
	[Address(RVA = "0x29F6A80", Offset = "0x29F5C80", VA = "0x1829F6A80")]
	private void GenerateTextJobified(MeshGenerationContext mgc, object _)
	{
	}

	[Token(Token = "0x6002023")]
	[Address(RVA = "0x29F5CC0", Offset = "0x29F4EC0", VA = "0x1829F5CC0")]
	private void AddDrawEntries(MeshGenerationContext mgc, object _)
	{
	}

	[Token(Token = "0x6002024")]
	[Address(RVA = "0x29F6100", Offset = "0x29F5300", VA = "0x1829F6100")]
	private static void ConvertMeshInfoToUIRVertex(UnityEngine.TextCore.Text.ATGMeshInfo[] meshInfos, TempMeshAllocator alloc, TextElement visualElement, ref List<Texture2D> atlases, ref List<NativeSlice<Vertex>> verticesArray, ref List<NativeSlice<ushort>> indicesArray, ref List<GlyphRenderMode> renderModes, ref List<float> sdfScales)
	{
	}
}
