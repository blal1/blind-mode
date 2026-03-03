using System.Collections.Generic;
using Il2CppDummyDll;

namespace YgomSystem.UI;

[Token(Token = "0x2000517")]
public interface IBindingModifiyByArgsHandler
{
	[Token(Token = "0x60020FA")]
	void OnPostModifiyByArgs(Dictionary<string, object> args);
}
