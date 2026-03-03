using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace YgomGame.MDMarkup;

[Token(Token = "0x2000CB3")]
public interface IMDMarkupSourceAsset : IMDMarkupSource
{
	[Token(Token = "0x6004CFA")]
	void SetArgs(Dictionary<string, object> args);

	[Token(Token = "0x6004CFB")]
	IEnumerator ySetup();

	[Token(Token = "0x6004CFC")]
	void Output(List<IMDMarkupContent> res);
}
