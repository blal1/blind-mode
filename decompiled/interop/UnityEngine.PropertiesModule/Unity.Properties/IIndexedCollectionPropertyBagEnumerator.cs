using Il2CppDummyDll;

namespace Unity.Properties;

[Token(Token = "0x200002B")]
internal interface IIndexedCollectionPropertyBagEnumerator<TContainer>
{
	[Token(Token = "0x60000A3")]
	int GetCount(ref TContainer container);

	[Token(Token = "0x60000A4")]
	IProperty<TContainer> GetSharedProperty();

	[Token(Token = "0x60000A5")]
	IndexedCollectionSharedPropertyState GetSharedPropertyState();

	[Token(Token = "0x60000A6")]
	void SetSharedPropertyState(IndexedCollectionSharedPropertyState state);
}
