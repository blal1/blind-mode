using Il2CppDummyDll;

namespace Unity.Properties;

[Token(Token = "0x2000031")]
public interface IKeyedProperties<TContainer, TKey>
{
	[Token(Token = "0x60000BC")]
	bool TryGetProperty(ref TContainer container, TKey key, out IProperty<TContainer> property);
}
