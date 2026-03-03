using System;
using Il2CppDummyDll;
using Unity.Properties;
using UnityEngine.Bindings;

namespace UnityEngine.UIElements;

[Token(Token = "0x200003D")]
[UnityEngine.Bindings.VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
internal readonly struct PropertyPathInfo
{
	[Token(Token = "0x400013A")]
	[FieldOffset(Offset = "0x0")]
	public readonly PropertyPath propertyPath;

	[Token(Token = "0x400013B")]
	[FieldOffset(Offset = "0x90")]
	public readonly Type type;

	[Token(Token = "0x60001F0")]
	[Address(RVA = "0x2997DB0", Offset = "0x2996FB0", VA = "0x182997DB0")]
	internal PropertyPathInfo(in PropertyPath propertyPath, Type type)
	{
	}
}
