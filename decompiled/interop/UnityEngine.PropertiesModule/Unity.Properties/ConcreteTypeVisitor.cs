using Il2CppDummyDll;

namespace Unity.Properties;

[Token(Token = "0x2000048")]
public abstract class ConcreteTypeVisitor : IPropertyBagVisitor
{
	[Token(Token = "0x600012B")]
	protected abstract void VisitContainer<TContainer>(ref TContainer container);

	[Token(Token = "0x600012C")]
	private void Unity_002EProperties_002EIPropertyBagVisitor_002EVisit<TContainer>(IPropertyBag<TContainer> properties, ref TContainer container)
	{
	}

	[Token(Token = "0x600012D")]
	[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
	protected ConcreteTypeVisitor()
	{
	}
}
