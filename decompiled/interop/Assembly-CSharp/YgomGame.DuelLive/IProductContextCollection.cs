using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace YgomGame.DuelLive;

[Token(Token = "0x2000F0E")]
public interface IProductContextCollection
{
	[Token(Token = "0x17000E49")]
	int filterSubId
	{
		[Token(Token = "0x6005B49")]
		get;
		[Token(Token = "0x6005B4A")]
		set;
	}

	[Token(Token = "0x17000E4A")]
	bool isDisplayEmpty
	{
		[Token(Token = "0x6005B4B")]
		get;
	}

	[Token(Token = "0x17000E4B")]
	List<int> subCategories
	{
		[Token(Token = "0x6005B4E")]
		get;
	}

	[Token(Token = "0x17000E4C")]
	IProductContext this[int index]
	{
		[Token(Token = "0x6005B4F")]
		get;
	}

	[Token(Token = "0x17000E4D")]
	int Count
	{
		[Token(Token = "0x6005B50")]
		get;
	}

	[Token(Token = "0x17000E4E")]
	IReadOnlyList<IProductContext> importedContexts
	{
		[Token(Token = "0x6005B52")]
		get;
	}

	[Token(Token = "0x1400008B")]
	event Action onUpdatedEvent;

	[Token(Token = "0x6005B51")]
	bool IsEmpty();

	[Token(Token = "0x6005B53")]
	void Import(Dictionary<string, object> productDatas);

	[Token(Token = "0x6005B54")]
	void Filter();
}
