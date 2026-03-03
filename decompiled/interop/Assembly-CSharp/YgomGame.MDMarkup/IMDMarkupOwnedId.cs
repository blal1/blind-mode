using System.Collections.Generic;
using Il2CppDummyDll;

namespace YgomGame.MDMarkup;

[Token(Token = "0x2000C74")]
public interface IMDMarkupOwnedId
{
	[Token(Token = "0x6004B6D")]
	void CollectContentsIdMap(Dictionary<string, IMDMarkupId> destMap);
}
