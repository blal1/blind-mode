using System;
using Il2CppDummyDll;

namespace Unity.Properties;

[Token(Token = "0x2000016")]
public interface IProperty
{
	[Token(Token = "0x17000008")]
	string Name
	{
		[Token(Token = "0x600002F")]
		get;
	}

	[Token(Token = "0x6000030")]
	Type DeclaredValueType();
}
[Token(Token = "0x2000017")]
public interface IProperty<TContainer> : IProperty, IPropertyAccept<TContainer>
{
}
