using Il2CppDummyDll;
using UnityEngine;

namespace YgomGame.MDMarkup;

[Token(Token = "0x2000D1A")]
public interface IMDMarkupWidget : IMDMarkupAsyncWidget
{
	[Token(Token = "0x17000B51")]
	GameObject gameObject
	{
		[Token(Token = "0x6004F0F")]
		get;
	}

	[Token(Token = "0x17000B52")]
	Transform transform
	{
		[Token(Token = "0x6004F10")]
		get;
	}

	[Token(Token = "0x17000B53")]
	MDMarkupIndentWidget indentWidget
	{
		[Token(Token = "0x6004F11")]
		get;
	}

	[Token(Token = "0x6004F12")]
	void BindContentData(IMDMarkupContent mdMarkupContent);
}
