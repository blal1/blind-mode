using System.Collections.Generic;
using Il2CppDummyDll;

namespace Unity.Properties;

[Token(Token = "0x2000027")]
public class DictionaryPropertyBag<TKey, TValue> : KeyValueCollectionPropertyBag<Dictionary<TKey, TValue>, TKey, TValue>
{
	[Token(Token = "0x17000021")]
	protected override InstantiationKind InstantiationKind
	{
		[Token(Token = "0x6000095")]
		get
		{
			return default(InstantiationKind);
		}
	}

	[Token(Token = "0x6000096")]
	protected override Dictionary<TKey, TValue> Instantiate()
	{
		return null;
	}

	[Token(Token = "0x6000097")]
	public DictionaryPropertyBag()
	{
	}
}
