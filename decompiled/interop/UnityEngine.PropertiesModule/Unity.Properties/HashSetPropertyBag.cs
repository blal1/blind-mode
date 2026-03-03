using System.Collections.Generic;
using Il2CppDummyDll;

namespace Unity.Properties;

[Token(Token = "0x2000028")]
public class HashSetPropertyBag<TElement> : SetPropertyBagBase<HashSet<TElement>, TElement>
{
	[Token(Token = "0x17000022")]
	protected override InstantiationKind InstantiationKind
	{
		[Token(Token = "0x6000098")]
		get
		{
			return default(InstantiationKind);
		}
	}

	[Token(Token = "0x6000099")]
	protected override HashSet<TElement> Instantiate()
	{
		return null;
	}

	[Token(Token = "0x600009A")]
	public HashSetPropertyBag()
	{
	}
}
