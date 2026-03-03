using Il2CppDummyDll;

namespace Unity.Properties;

[Token(Token = "0x2000032")]
public interface IPropertyBag
{
	[Token(Token = "0x60000BD")]
	void Accept(ITypeVisitor visitor);

	[Token(Token = "0x60000BE")]
	void Accept(IPropertyBagVisitor visitor, ref object container);
}
[Token(Token = "0x2000033")]
public interface IPropertyBag<TContainer> : IPropertyBag
{
	[Token(Token = "0x60000BF")]
	PropertyCollection<TContainer> GetProperties();

	[Token(Token = "0x60000C0")]
	PropertyCollection<TContainer> GetProperties(ref TContainer container);

	[Token(Token = "0x60000C1")]
	void Accept(IPropertyBagVisitor visitor, ref TContainer container);
}
