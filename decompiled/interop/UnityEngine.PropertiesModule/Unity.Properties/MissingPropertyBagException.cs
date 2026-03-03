using System;
using Il2CppDummyDll;

namespace Unity.Properties;

[Serializable]
[Token(Token = "0x200000E")]
public class MissingPropertyBagException : Exception
{
	[Token(Token = "0x600001E")]
	[Address(RVA = "0x28D8F90", Offset = "0x28D8190", VA = "0x1828D8F90")]
	public MissingPropertyBagException(Type type)
	{
	}

	[Token(Token = "0x600001F")]
	[Address(RVA = "0x28D8F20", Offset = "0x28D8120", VA = "0x1828D8F20")]
	private static string GetMessageForType(Type type)
	{
		return null;
	}
}
