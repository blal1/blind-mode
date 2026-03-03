using Il2CppDummyDll;

namespace Unity.Properties;

[Token(Token = "0x2000030")]
public interface INamedProperties<TContainer>
{
	[Token(Token = "0x60000BB")]
	bool TryGetProperty(ref TContainer container, string name, out IProperty<TContainer> property);
}
