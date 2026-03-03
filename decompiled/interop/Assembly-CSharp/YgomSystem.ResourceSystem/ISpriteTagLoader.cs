using Il2CppDummyDll;

namespace YgomSystem.ResourceSystem;

[Token(Token = "0x20002C0")]
public interface ISpriteTagLoader
{
	[Token(Token = "0x60010CC")]
	string GetPathFromSpriteAtlasTag(string tag);
}
