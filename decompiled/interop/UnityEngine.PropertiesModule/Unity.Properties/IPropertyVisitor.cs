using Il2CppDummyDll;

namespace Unity.Properties;

[Token(Token = "0x2000055")]
public interface IPropertyVisitor
{
	[Token(Token = "0x600013A")]
	void Visit<TContainer, TValue>(Property<TContainer, TValue> property, ref TContainer container);
}
