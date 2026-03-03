using System;
using Il2CppDummyDll;

namespace UnityEngine.UIElements;

[Token(Token = "0x20004A3")]
public class UxmlTypeAttributeDescription<TBase> : TypedUxmlAttributeDescription<Type>
{
	[Token(Token = "0x6002283")]
	public UxmlTypeAttributeDescription()
	{
	}

	[Token(Token = "0x6002284")]
	public override Type GetValueFromBag(IUxmlAttributes bag, CreationContext cc)
	{
		return null;
	}

	[Token(Token = "0x6002285")]
	private Type ConvertValueToType(string v, Type defaultValue)
	{
		return null;
	}
}
