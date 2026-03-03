using Il2CppDummyDll;

namespace Unity.Properties;

[Token(Token = "0x2000049")]
public interface ICollectionPropertyBagAccept<TContainer>
{
	[Token(Token = "0x600012E")]
	void Accept(ICollectionPropertyBagVisitor visitor, ref TContainer container);
}
