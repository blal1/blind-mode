using Il2CppDummyDll;

namespace Unity.Properties;

[Token(Token = "0x200002F")]
public interface IIndexedProperties<TContainer>
{
	[Token(Token = "0x60000BA")]
	bool TryGetProperty(ref TContainer container, int index, out IProperty<TContainer> property);
}
