using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine.Bindings;
using UnityEngine.Scripting.APIUpdating;

namespace UnityEngine.UIElements;

[Token(Token = "0x20004C4")]
[UnityEngine.Bindings.VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
internal class VisualElementFactoryRegistry
{
	[Token(Token = "0x4000F83")]
	[FieldOffset(Offset = "0x0")]
	private static Dictionary<string, List<IUxmlFactory>> s_Factories;

	[Token(Token = "0x4000F84")]
	[FieldOffset(Offset = "0x8")]
	private static Dictionary<string, List<IUxmlFactory>> s_MovedTypesFactories;

	[Token(Token = "0x17000939")]
	internal static Dictionary<string, List<IUxmlFactory>> factories
	{
		[Token(Token = "0x60022E9")]
		[Address(RVA = "0x2A23280", Offset = "0x2A22480", VA = "0x182A23280")]
		[UnityEngine.Bindings.VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60022E8")]
	[Address(RVA = "0x2A20EC0", Offset = "0x2A200C0", VA = "0x182A20EC0")]
	internal static string GetMovedUIControlTypeName(Type type, MovedFromAttribute attr)
	{
		return null;
	}

	[Token(Token = "0x60022EA")]
	[Address(RVA = "0x2A22950", Offset = "0x2A21B50", VA = "0x182A22950")]
	protected static void RegisterFactory(IUxmlFactory factory)
	{
	}

	[Token(Token = "0x60022EB")]
	[Address(RVA = "0x2A231E0", Offset = "0x2A223E0", VA = "0x182A231E0")]
	[UnityEngine.Bindings.VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
	internal static bool TryGetValue(string fullTypeName, out List<IUxmlFactory> factoryList)
	{
		return default(bool);
	}

	[Token(Token = "0x60022EC")]
	[Address(RVA = "0x2A20FE0", Offset = "0x2A201E0", VA = "0x182A20FE0")]
	private static void RegisterEngineFactories()
	{
	}

	[Token(Token = "0x60022ED")]
	[Address(RVA = "0x2A22EE0", Offset = "0x2A220E0", VA = "0x182A22EE0")]
	internal static void RegisterUserFactories()
	{
	}
}
