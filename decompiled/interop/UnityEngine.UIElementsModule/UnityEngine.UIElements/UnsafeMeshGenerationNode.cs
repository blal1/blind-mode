using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Unity.Collections;
using UnityEngine.UIElements.UIR;

namespace UnityEngine.UIElements;

[Token(Token = "0x20002AD")]
internal struct UnsafeMeshGenerationNode
{
	[Token(Token = "0x4000AD0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private GCHandle m_Handle;

	[MethodImpl(256)]
	[Token(Token = "0x600129D")]
	[Address(RVA = "0x2B72F60", Offset = "0x2B72160", VA = "0x182B72F60")]
	private MeshGenerationNodeImpl GetManaged()
	{
		return null;
	}

	[MethodImpl(256)]
	[Token(Token = "0x600129E")]
	[Address(RVA = "0x2B69AC0", Offset = "0x2B68CC0", VA = "0x182B69AC0")]
	internal static void Create(GCHandle handle, out UnsafeMeshGenerationNode node)
	{
	}

	[MethodImpl(256)]
	[Token(Token = "0x600129F")]
	[Address(RVA = "0x2B72E60", Offset = "0x2B72060", VA = "0x182B72E60")]
	public void DrawMesh(NativeSlice<Vertex> vertices, NativeSlice<ushort> indices, [Optional] Texture texture)
	{
	}

	[MethodImpl(256)]
	[Token(Token = "0x60012A0")]
	[Address(RVA = "0x2B72D60", Offset = "0x2B71F60", VA = "0x182B72D60")]
	internal void DrawMeshInternal(NativeSlice<Vertex> vertices, NativeSlice<ushort> indices, [Optional] Texture texture, bool skipAtlas = false)
	{
	}

	[MethodImpl(256)]
	[Token(Token = "0x60012A1")]
	[Address(RVA = "0x2B72C30", Offset = "0x2B71E30", VA = "0x182B72C30")]
	internal void DrawGradientsInternal(NativeSlice<Vertex> vertices, NativeSlice<ushort> indices, VectorImage gradientsOwner)
	{
	}

	[MethodImpl(256)]
	[Token(Token = "0x60012A2")]
	[Address(RVA = "0x2B69AD0", Offset = "0x2B68CD0", VA = "0x182B69AD0")]
	internal Entry GetParentEntry()
	{
		return null;
	}
}
