using System;
using Il2CppDummyDll;

namespace UnityEngine.UIElements;

[Token(Token = "0x2000289")]
[Flags]
internal enum RenderHints
{
	[Token(Token = "0x4000A1E")]
	None = 0,
	[Token(Token = "0x4000A1F")]
	GroupTransform = 1,
	[Token(Token = "0x4000A20")]
	BoneTransform = 2,
	[Token(Token = "0x4000A21")]
	ClipWithScissors = 4,
	[Token(Token = "0x4000A22")]
	MaskContainer = 8,
	[Token(Token = "0x4000A23")]
	DynamicColor = 0x10,
	[Token(Token = "0x4000A24")]
	DirtyOffset = 5,
	[Token(Token = "0x4000A25")]
	DirtyGroupTransform = 0x20,
	[Token(Token = "0x4000A26")]
	DirtyBoneTransform = 0x40,
	[Token(Token = "0x4000A27")]
	DirtyClipWithScissors = 0x80,
	[Token(Token = "0x4000A28")]
	DirtyMaskContainer = 0x100,
	[Token(Token = "0x4000A29")]
	DirtyDynamicColor = 0x200,
	[Token(Token = "0x4000A2A")]
	DirtyAll = 0x3E0
}
