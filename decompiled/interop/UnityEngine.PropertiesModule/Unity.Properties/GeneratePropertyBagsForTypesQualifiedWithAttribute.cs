using System;
using Il2CppDummyDll;

namespace Unity.Properties;

[Token(Token = "0x200000D")]
[AttributeUsage(AttributeTargets.Assembly, AllowMultiple = true)]
public class GeneratePropertyBagsForTypesQualifiedWithAttribute : Attribute
{
	[Token(Token = "0x600001D")]
	[Address(RVA = "0x28D8920", Offset = "0x28D7B20", VA = "0x1828D8920")]
	public GeneratePropertyBagsForTypesQualifiedWithAttribute(Type type, TypeGenerationOptions options = TypeGenerationOptions.Default)
	{
	}
}
