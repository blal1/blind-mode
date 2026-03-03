using System.Collections.Generic;
using Il2CppDummyDll;

namespace Unity.Properties;

[Token(Token = "0x200003F")]
public class ListPropertyBag<TElement> : IndexedCollectionPropertyBag<List<TElement>, TElement>
{
	[Token(Token = "0x17000030")]
	protected override InstantiationKind InstantiationKind
	{
		[Token(Token = "0x60000EB")]
		get
		{
			return default(InstantiationKind);
		}
	}

	[Token(Token = "0x60000EC")]
	protected override List<TElement> InstantiateWithCount(int count)
	{
		return null;
	}

	[Token(Token = "0x60000ED")]
	protected override List<TElement> Instantiate()
	{
		return null;
	}

	[Token(Token = "0x60000EE")]
	public ListPropertyBag()
	{
	}
}
