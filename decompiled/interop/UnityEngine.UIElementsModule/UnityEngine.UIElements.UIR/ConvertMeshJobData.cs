using System;
using Il2CppDummyDll;

namespace UnityEngine.UIElements.UIR;

[Token(Token = "0x2000540")]
internal struct ConvertMeshJobData
{
	[Token(Token = "0x40011F6")]
	[FieldOffset(Offset = "0x0")]
	public IntPtr vertSrc;

	[Token(Token = "0x40011F7")]
	[FieldOffset(Offset = "0x8")]
	public IntPtr vertDst;

	[Token(Token = "0x40011F8")]
	[FieldOffset(Offset = "0x10")]
	public int vertCount;

	[Token(Token = "0x40011F9")]
	[FieldOffset(Offset = "0x14")]
	public Matrix4x4 transform;

	[Token(Token = "0x40011FA")]
	[FieldOffset(Offset = "0x54")]
	public Color32 xformClipPages;

	[Token(Token = "0x40011FB")]
	[FieldOffset(Offset = "0x58")]
	public Color32 ids;

	[Token(Token = "0x40011FC")]
	[FieldOffset(Offset = "0x5C")]
	public Color32 addFlags;

	[Token(Token = "0x40011FD")]
	[FieldOffset(Offset = "0x60")]
	public Color32 opacityPage;

	[Token(Token = "0x40011FE")]
	[FieldOffset(Offset = "0x64")]
	public Color32 textCoreSettingsPage;

	[Token(Token = "0x40011FF")]
	[FieldOffset(Offset = "0x68")]
	public int usesTextCoreSettings;

	[Token(Token = "0x4001200")]
	[FieldOffset(Offset = "0x6C")]
	public float textureId;

	[Token(Token = "0x4001201")]
	[FieldOffset(Offset = "0x70")]
	public int gradientSettingsIndexOffset;

	[Token(Token = "0x4001202")]
	[FieldOffset(Offset = "0x78")]
	public IntPtr indexSrc;

	[Token(Token = "0x4001203")]
	[FieldOffset(Offset = "0x80")]
	public IntPtr indexDst;

	[Token(Token = "0x4001204")]
	[FieldOffset(Offset = "0x88")]
	public int indexCount;

	[Token(Token = "0x4001205")]
	[FieldOffset(Offset = "0x8C")]
	public int indexOffset;

	[Token(Token = "0x4001206")]
	[FieldOffset(Offset = "0x90")]
	public int flipIndices;

	[Token(Token = "0x4001207")]
	[FieldOffset(Offset = "0x94")]
	public int forceZ;

	[Token(Token = "0x4001208")]
	[FieldOffset(Offset = "0x98")]
	public float positionZ;

	[Token(Token = "0x4001209")]
	[FieldOffset(Offset = "0x9C")]
	public int remapUVs;

	[Token(Token = "0x400120A")]
	[FieldOffset(Offset = "0xA0")]
	public Rect atlasRect;
}
