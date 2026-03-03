using Il2CppDummyDll;

namespace Unity.Properties;

[Token(Token = "0x200004A")]
public interface IListPropertyBagAccept<TContainer>
{
	[Token(Token = "0x600012F")]
	void Accept(IListPropertyBagVisitor visitor, ref TContainer container);
}
