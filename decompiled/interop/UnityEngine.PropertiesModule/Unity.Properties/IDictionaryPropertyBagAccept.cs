using Il2CppDummyDll;

namespace Unity.Properties;

[Token(Token = "0x200004C")]
public interface IDictionaryPropertyBagAccept<TContainer>
{
	[Token(Token = "0x6000131")]
	void Accept(IDictionaryPropertyBagVisitor visitor, ref TContainer container);
}
