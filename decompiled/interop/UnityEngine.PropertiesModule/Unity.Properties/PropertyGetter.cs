using Il2CppDummyDll;

namespace Unity.Properties;

[Token(Token = "0x2000010")]
public delegate TValue PropertyGetter<TContainer, out TValue>(ref TContainer container);
