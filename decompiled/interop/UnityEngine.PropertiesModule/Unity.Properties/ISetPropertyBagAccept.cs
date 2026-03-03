using Il2CppDummyDll;

namespace Unity.Properties;

[Token(Token = "0x200004B")]
public interface ISetPropertyBagAccept<TContainer>
{
	[Token(Token = "0x6000130")]
	void Accept(ISetPropertyBagVisitor visitor, ref TContainer container);
}
