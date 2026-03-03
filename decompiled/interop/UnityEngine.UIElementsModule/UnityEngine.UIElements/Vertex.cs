using Il2CppDummyDll;

namespace UnityEngine.UIElements;

[Token(Token = "0x20002A6")]
public struct Vertex
{
	[Token(Token = "0x4000AA9")]
	[FieldOffset(Offset = "0x0")]
	public static readonly float nearZ;

	[Token(Token = "0x4000AAA")]
	[FieldOffset(Offset = "0x0")]
	public Vector3 position;

	[Token(Token = "0x4000AAB")]
	[FieldOffset(Offset = "0xC")]
	public Color32 tint;

	[Token(Token = "0x4000AAC")]
	[FieldOffset(Offset = "0x10")]
	public Vector2 uv;

	[Token(Token = "0x4000AAD")]
	[FieldOffset(Offset = "0x18")]
	internal Color32 xformClipPages;

	[Token(Token = "0x4000AAE")]
	[FieldOffset(Offset = "0x1C")]
	internal Color32 ids;

	[Token(Token = "0x4000AAF")]
	[FieldOffset(Offset = "0x20")]
	internal Color32 flags;

	[Token(Token = "0x4000AB0")]
	[FieldOffset(Offset = "0x24")]
	internal Color32 opacityColorPages;

	[Token(Token = "0x4000AB1")]
	[FieldOffset(Offset = "0x28")]
	internal Color32 settingIndex;

	[Token(Token = "0x4000AB2")]
	[FieldOffset(Offset = "0x2C")]
	internal Vector4 circle;

	[Token(Token = "0x4000AB3")]
	[FieldOffset(Offset = "0x3C")]
	internal float textureId;
}
