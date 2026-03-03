using Il2CppDummyDll;

namespace Unity.Properties;

[Token(Token = "0x2000025")]
public sealed class ArrayPropertyBag<TElement> : IndexedCollectionPropertyBag<TElement[], TElement>
{
	[Token(Token = "0x17000020")]
	protected override InstantiationKind InstantiationKind
	{
		[Token(Token = "0x600008B")]
		get
		{
			return default(InstantiationKind);
		}
	}

	[Token(Token = "0x600008C")]
	protected override TElement[] InstantiateWithCount(int count)
	{
		return null;
	}

	[Token(Token = "0x600008D")]
	protected override TElement[] Instantiate()
	{
		return null;
	}

	[Token(Token = "0x600008E")]
	public ArrayPropertyBag()
	{
	}
}
