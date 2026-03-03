using Il2CppDummyDll;
using YgomGame.Utility;

namespace YgomGame.Menu;

[Token(Token = "0x200118A")]
public class FriendDefinitionSetting
{
	[Token(Token = "0x400B7C4")]
	public const string k_AssetPath = "Definition/Friend/FriendDefine";

	[Token(Token = "0x400B7C5")]
	[FieldOffset(Offset = "0x10")]
	public readonly int pcodeLength;

	[Token(Token = "0x400B7C6")]
	[FieldOffset(Offset = "0x14")]
	public int followerPoolLimit;

	[Token(Token = "0x6006E0B")]
	[Address(RVA = "0xB5AE80", Offset = "0xB5A080", VA = "0x180B5AE80")]
	public FriendDefinitionSetting(DefinitionSetting definitionSetting)
	{
	}
}
