using System.Collections.Generic;
using Il2CppDummyDll;

namespace Unity.Properties;

[Token(Token = "0x2000026")]
public abstract class ContainerPropertyBag<TContainer> : PropertyBag<TContainer>, INamedProperties<TContainer>
{
	[Token(Token = "0x4000043")]
	[FieldOffset(Offset = "0x0")]
	private readonly List<IProperty<TContainer>> m_PropertiesList;

	[Token(Token = "0x4000044")]
	[FieldOffset(Offset = "0x0")]
	private readonly Dictionary<string, IProperty<TContainer>> m_PropertiesHash;

	[Token(Token = "0x600008F")]
	static ContainerPropertyBag()
	{
	}

	[Token(Token = "0x6000090")]
	protected void AddProperty<TValue>(Property<TContainer, TValue> property)
	{
	}

	[Token(Token = "0x6000091")]
	public override PropertyCollection<TContainer> GetProperties()
	{
		return default(PropertyCollection<TContainer>);
	}

	[Token(Token = "0x6000092")]
	public override PropertyCollection<TContainer> GetProperties(ref TContainer container)
	{
		return default(PropertyCollection<TContainer>);
	}

	[Token(Token = "0x6000093")]
	public bool TryGetProperty(ref TContainer container, string name, out IProperty<TContainer> property)
	{
		return default(bool);
	}

	[Token(Token = "0x6000094")]
	protected ContainerPropertyBag()
	{
	}
}
