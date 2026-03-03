using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Unity.Collections.LowLevel.Unsafe;
using UnityEngine.UIElements.UIR;

namespace UnityEngine.UIElements;

[Token(Token = "0x20002AC")]
[NativeContainer]
public struct MeshGenerationNode
{
	[Token(Token = "0x4000ACF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private UnsafeMeshGenerationNode m_UnsafeNode;

	[MethodImpl(256)]
	[Token(Token = "0x600129B")]
	[Address(RVA = "0x2B69AC0", Offset = "0x2B68CC0", VA = "0x182B69AC0")]
	internal static void Create(GCHandle handle, out MeshGenerationNode node)
	{
	}

	[MethodImpl(256)]
	[Token(Token = "0x600129C")]
	[Address(RVA = "0x2B69AD0", Offset = "0x2B68CD0", VA = "0x182B69AD0")]
	internal Entry GetParentEntry()
	{
		return null;
	}
}
