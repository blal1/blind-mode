using Il2CppDummyDll;
using Unity.Collections;
using UnityEngine.Bindings;

namespace UnityEngine.UIElements;

[Token(Token = "0x20002A8")]
public class MeshWriteData
{
	[Token(Token = "0x4000AB8")]
	[FieldOffset(Offset = "0x10")]
	internal NativeSlice<Vertex> m_Vertices;

	[Token(Token = "0x4000AB9")]
	[FieldOffset(Offset = "0x20")]
	internal NativeSlice<ushort> m_Indices;

	[Token(Token = "0x4000ABA")]
	[FieldOffset(Offset = "0x30")]
	internal int currentIndex;

	[Token(Token = "0x4000ABB")]
	[FieldOffset(Offset = "0x34")]
	[UnityEngine.Bindings.VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
	internal int currentVertex;

	[Token(Token = "0x6001281")]
	[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
	internal MeshWriteData()
	{
	}
}
