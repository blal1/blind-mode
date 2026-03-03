using Il2CppDummyDll;

namespace Unity.Properties;

[Token(Token = "0x2000050")]
public interface IPropertyBagVisitor
{
	[Token(Token = "0x6000135")]
	void Visit<TContainer>(IPropertyBag<TContainer> properties, ref TContainer container);
}
