using Il2CppDummyDll;

namespace YgomGame.Duel;

[Token(Token = "0x2001A4A")]
public interface IFieldPlacementInfo
{
	[Token(Token = "0x17001A61")]
	int numMonsterPlaces
	{
		[Token(Token = "0x600AAB8")]
		get;
	}

	[Token(Token = "0x17001A62")]
	int numMagicPlaces
	{
		[Token(Token = "0x600AAB9")]
		get;
	}

	[Token(Token = "0x17001A63")]
	int monsterStartIdx
	{
		[Token(Token = "0x600AABA")]
		get;
	}

	[Token(Token = "0x17001A64")]
	int monsterEndIdx
	{
		[Token(Token = "0x600AABB")]
		get;
	}

	[Token(Token = "0x17001A65")]
	int magicStartIdx
	{
		[Token(Token = "0x600AABC")]
		get;
	}

	[Token(Token = "0x17001A66")]
	int magicEndIdx
	{
		[Token(Token = "0x600AABD")]
		get;
	}
}
