using System.Collections.Generic;
using Il2CppDummyDll;

namespace YgomGame.MDMarkup;

[Token(Token = "0x2000CAA")]
public interface IMDMarkupModifierPreload : IMDMarkupModifier
{
	[Token(Token = "0x6004CDE")]
	bool ModifyOnPreload(IMDMarkupId idContent, Dictionary<string, object> args);
}
