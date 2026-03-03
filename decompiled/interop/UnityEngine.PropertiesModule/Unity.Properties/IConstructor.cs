using Il2CppDummyDll;

namespace Unity.Properties;

[Token(Token = "0x2000063")]
internal interface IConstructor
{
	[Token(Token = "0x1700004C")]
	InstantiationKind InstantiationKind
	{
		[Token(Token = "0x6000236")]
		get;
	}
}
[Token(Token = "0x2000064")]
internal interface IConstructor<out T> : IConstructor
{
	[Token(Token = "0x6000237")]
	T Instantiate();
}
