using Il2CppDummyDll;

namespace Unity.Properties;

[Token(Token = "0x200004D")]
public interface IPropertyAccept<TContainer>
{
	[Token(Token = "0x6000132")]
	void Accept(IPropertyVisitor visitor, ref TContainer container);
}
