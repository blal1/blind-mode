using Il2CppDummyDll;

namespace UnityEngine.UIElements;

[Token(Token = "0x2000270")]
internal interface ISerializableJsonDictionary
{
	[Token(Token = "0x6001115")]
	void Set<T>(string key, T value) where T : class;

	[Token(Token = "0x6001116")]
	T Get<T>(string key) where T : class;

	[Token(Token = "0x6001117")]
	void Overwrite(object obj, string key);

	[Token(Token = "0x6001118")]
	bool ContainsKey(string key);
}
