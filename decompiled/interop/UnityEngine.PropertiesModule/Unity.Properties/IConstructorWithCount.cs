using Il2CppDummyDll;

namespace Unity.Properties;

[Token(Token = "0x2000065")]
internal interface IConstructorWithCount<out T> : IConstructor
{
	[Token(Token = "0x6000238")]
	T InstantiateWithCount(int count);
}
