using Il2CppDummyDll;

namespace YgomGame.DuelLive;

[Token(Token = "0x2000EEB")]
public interface IDuelLiveProductGruopData
{
	[Token(Token = "0x17000DF7")]
	int groupId
	{
		[Token(Token = "0x6005A87")]
		get;
	}

	[Token(Token = "0x17000DF8")]
	string labelTextId
	{
		[Token(Token = "0x6005A88")]
		get;
	}

	[Token(Token = "0x17000DF9")]
	string labelText
	{
		[Token(Token = "0x6005A89")]
		get;
	}

	[Token(Token = "0x17000DFA")]
	bool isBadge
	{
		[Token(Token = "0x6005A8B")]
		get;
	}

	[Token(Token = "0x6005A8A")]
	bool IsMatchProduct(IProductContext product);
}
