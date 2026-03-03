using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.U2D;

namespace YgomSystem.Utility;

[Token(Token = "0x2000406")]
public class SpriteAtlasContainer : MonoBehaviour
{
	[Token(Token = "0x40013FD")]
	[FieldOffset(Offset = "0x20")]
	public SpriteAtlas spriteAtlas;

	[Token(Token = "0x40013FE")]
	[FieldOffset(Offset = "0x28")]
	public List<SpriteAtlas> additionalSpriteAtlas;

	[Token(Token = "0x40013FF")]
	[FieldOffset(Offset = "0x30")]
	public List<string> spriteAtlasHashList;

	[Token(Token = "0x60019B5")]
	[Address(RVA = "0x5D78C0", Offset = "0x5D6AC0", VA = "0x1805D78C0")]
	public SpriteAtlasContainer()
	{
	}
}
