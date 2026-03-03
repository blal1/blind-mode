using System.Collections.Generic;
using Il2CppDummyDll;

namespace YgomGame.Enquete;

[Token(Token = "0x2000DDF")]
public interface IContext
{
	[Token(Token = "0x17000C43")]
	string label
	{
		[Token(Token = "0x60053A1")]
		get;
	}

	[Token(Token = "0x60053A2")]
	void Import(object jsonData);

	[Token(Token = "0x60053A3")]
	void SearchDependencieTextGroups(List<string> resultList);
}
