using System.Collections.Generic;
using Il2CppDummyDll;

namespace YgomGame.MDMarkup;

[Token(Token = "0x2000CAB")]
public interface IMDMarkupModifierOnLoadComplete : IMDMarkupModifier
{
	[Token(Token = "0x6004CDF")]
	bool ModifyOnLoadComplete(IMDMarkupId idContent, Dictionary<string, object> args);
}
