using System.Collections.Generic;
using Il2CppDummyDll;
using YgomGame.Utility;

namespace YgomGame.MDMarkup;

[Token(Token = "0x2000C65")]
public interface IMDMarkupContainer : IMDMarkupSourceRequireTextData, IMDMarkupOwnedId
{
	[Token(Token = "0x17000A2C")]
	MDMarkupDef.ContainerType containerType
	{
		[Token(Token = "0x6004B1B")]
		get;
	}

	[Token(Token = "0x17000A2D")]
	List<IMDMarkupModifier> modifiers
	{
		[Token(Token = "0x6004B1D")]
		get;
		[Token(Token = "0x6004B1E")]
		set;
	}

	[Token(Token = "0x17000A2E")]
	GlobalTextData title
	{
		[Token(Token = "0x6004B1F")]
		get;
	}

	[Token(Token = "0x17000A2F")]
	List<IMDMarkupContent> contents
	{
		[Token(Token = "0x6004B20")]
		get;
	}

	[Token(Token = "0x6004B1C")]
	void Clear();

	[Token(Token = "0x6004B21")]
	object ExportJsonObj();

	[Token(Token = "0x6004B22")]
	void ImportJsonObj(object jsonObj);

	[Token(Token = "0x6004B23")]
	void ImportJson(string json);
}
