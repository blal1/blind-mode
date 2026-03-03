using System;
using Il2CppDummyDll;
using UnityEngine.Bindings;

namespace UnityEngine.UIElements;

[Serializable]
[Token(Token = "0x2000086")]
[UnityEngine.Bindings.VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
internal class SerializedVirtualizationData
{
	[Token(Token = "0x40002E2")]
	[FieldOffset(Offset = "0x10")]
	public Vector2 scrollOffset;

	[Token(Token = "0x40002E3")]
	[FieldOffset(Offset = "0x18")]
	public int firstVisibleIndex;

	[Token(Token = "0x40002E4")]
	[FieldOffset(Offset = "0x1C")]
	public float contentPadding;

	[Token(Token = "0x40002E5")]
	[FieldOffset(Offset = "0x20")]
	public float contentHeight;

	[Token(Token = "0x40002E6")]
	[FieldOffset(Offset = "0x24")]
	public int anchoredItemIndex;

	[Token(Token = "0x40002E7")]
	[FieldOffset(Offset = "0x28")]
	public float anchorOffset;

	[Token(Token = "0x60004ED")]
	[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
	public SerializedVirtualizationData()
	{
	}
}
