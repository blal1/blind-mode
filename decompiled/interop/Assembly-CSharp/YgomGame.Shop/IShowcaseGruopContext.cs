using Il2CppDummyDll;

namespace YgomGame.Shop;

[Token(Token = "0x2000925")]
public interface IShowcaseGruopContext
{
	[Token(Token = "0x170006BD")]
	int categoryId
	{
		[Token(Token = "0x6003718")]
		get;
	}

	[Token(Token = "0x170006BE")]
	int subCategoryId
	{
		[Token(Token = "0x6003719")]
		get;
	}

	[Token(Token = "0x170006BF")]
	int sectionId
	{
		[Token(Token = "0x600371A")]
		get;
	}
}
