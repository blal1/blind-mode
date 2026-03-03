using System;
using Il2CppDummyDll;

namespace UnityEngine.UIElements;

[Token(Token = "0x20004A4")]
public class UxmlEnumAttributeDescription<T> : TypedUxmlAttributeDescription<T> where T : struct, IConvertible
{
	[Token(Token = "0x6002287")]
	public UxmlEnumAttributeDescription()
	{
	}

	[Token(Token = "0x6002288")]
	public override T GetValueFromBag(IUxmlAttributes bag, CreationContext cc)
	{
		return (T)null;
	}

	[Token(Token = "0x6002289")]
	public bool TryGetValueFromBag(IUxmlAttributes bag, CreationContext cc, ref T value)
	{
		return default(bool);
	}

	[Token(Token = "0x600228A")]
	private static U ConvertValueToEnum<U>(string v, U defaultValue) where U : struct
	{
		return (U)null;
	}

	[Token(Token = "0x600228B")]
	private static string GetEnumNameErrorMessage(string v, Type enumType)
	{
		return null;
	}

	[Token(Token = "0x600228C")]
	private static string GetEnumRangeErrorMessage(string v, Type enumType)
	{
		return null;
	}
}
