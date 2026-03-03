using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;

namespace UnityEngine.UIElements;

[Token(Token = "0x20002B5")]
[NativeContainerIsReadOnly]
[NativeContainer]
public struct TempMeshAllocator
{
	[Token(Token = "0x4000AF1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private GCHandle m_Handle;

	[Token(Token = "0x60012E4")]
	[Address(RVA = "0x2B69AC0", Offset = "0x2B68CC0", VA = "0x182B69AC0")]
	internal static void Create(GCHandle handle, out TempMeshAllocator allocator)
	{
	}

	[Token(Token = "0x60012E5")]
	[Address(RVA = "0x2B6CD60", Offset = "0x2B6BF60", VA = "0x182B6CD60")]
	public void AllocateTempMesh(int vertexCount, int indexCount, out NativeSlice<Vertex> vertices, out NativeSlice<ushort> indices)
	{
	}
}
