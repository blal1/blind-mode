using System.Collections.Generic;
using Il2CppDummyDll;

namespace YgomGame.DuelLive;

[Token(Token = "0x2000F0C")]
public interface IProductContext
{
	[Token(Token = "0x17000E0F")]
	int menuId
	{
		[Token(Token = "0x6005B0A")]
		get;
	}

	[Token(Token = "0x17000E10")]
	int replayIdx
	{
		[Token(Token = "0x6005B0B")]
		get;
	}

	[Token(Token = "0x17000E11")]
	long duelLiveId
	{
		[Token(Token = "0x6005B0C")]
		get;
	}

	[Token(Token = "0x17000E12")]
	int categoryId
	{
		[Token(Token = "0x6005B0D")]
		get;
	}

	[Token(Token = "0x17000E13")]
	int categoryIdx
	{
		[Token(Token = "0x6005B0E")]
		get;
	}

	[Token(Token = "0x17000E14")]
	int subCategoryId
	{
		[Token(Token = "0x6005B0F")]
		get;
	}

	[Token(Token = "0x17000E15")]
	int subCategoryIdx
	{
		[Token(Token = "0x6005B10")]
		get;
	}

	[Token(Token = "0x17000E16")]
	int sectionId
	{
		[Token(Token = "0x6005B11")]
		get;
	}

	[Token(Token = "0x17000E17")]
	int widgetType
	{
		[Token(Token = "0x6005B12")]
		get;
	}

	[Token(Token = "0x17000E18")]
	List<object> mrk
	{
		[Token(Token = "0x6005B13")]
		get;
	}

	[Token(Token = "0x17000E19")]
	string imagePath
	{
		[Token(Token = "0x6005B14")]
		get;
	}

	[Token(Token = "0x17000E1A")]
	string name1
	{
		[Token(Token = "0x6005B15")]
		get;
	}

	[Token(Token = "0x17000E1B")]
	string name2
	{
		[Token(Token = "0x6005B16")]
		get;
	}

	[Token(Token = "0x17000E1C")]
	int userId1
	{
		[Token(Token = "0x6005B17")]
		get;
	}

	[Token(Token = "0x17000E1D")]
	int userId2
	{
		[Token(Token = "0x6005B18")]
		get;
	}

	[Token(Token = "0x17000E1E")]
	int teamId1
	{
		[Token(Token = "0x6005B19")]
		get;
	}

	[Token(Token = "0x17000E1F")]
	int teamId2
	{
		[Token(Token = "0x6005B1A")]
		get;
	}

	[Token(Token = "0x17000E20")]
	bool isDeckPublic
	{
		[Token(Token = "0x6005B1B")]
		get;
	}

	[Token(Token = "0x17000E21")]
	int highlightId
	{
		[Token(Token = "0x6005B1C")]
		get;
	}

	[Token(Token = "0x17000E22")]
	bool badget
	{
		[Token(Token = "0x6005B1D")]
		get;
	}

	[Token(Token = "0x17000E23")]
	int userIcon1
	{
		[Token(Token = "0x6005B1E")]
		get;
	}

	[Token(Token = "0x17000E24")]
	int userIcon2
	{
		[Token(Token = "0x6005B1F")]
		get;
	}

	[Token(Token = "0x17000E25")]
	int userIconFrame1
	{
		[Token(Token = "0x6005B20")]
		get;
	}

	[Token(Token = "0x17000E26")]
	int userIconFrame2
	{
		[Token(Token = "0x6005B21")]
		get;
	}

	[Token(Token = "0x17000E27")]
	int userDeckCase1
	{
		[Token(Token = "0x6005B22")]
		get;
	}

	[Token(Token = "0x17000E28")]
	int userDeckCase2
	{
		[Token(Token = "0x6005B23")]
		get;
	}

	[Token(Token = "0x17000E29")]
	int highlightCardMenuId
	{
		[Token(Token = "0x6005B24")]
		get;
	}

	[Token(Token = "0x17000E2A")]
	int winnerId
	{
		[Token(Token = "0x6005B25")]
		get;
	}

	[Token(Token = "0x17000E2B")]
	int sort
	{
		[Token(Token = "0x6005B26")]
		get;
	}

	[Token(Token = "0x6005B27")]
	void Import(Dictionary<string, object> productData);
}
