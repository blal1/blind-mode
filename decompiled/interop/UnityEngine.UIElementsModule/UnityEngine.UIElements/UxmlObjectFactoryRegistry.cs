using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine.Bindings;

namespace UnityEngine.UIElements;

[Token(Token = "0x20004BD")]
[UnityEngine.Bindings.VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
[Obsolete("UxmlObjectFactoryRegistry is deprecated and will be removed. Use UxmlElementAttribute instead.", false)]
internal class UxmlObjectFactoryRegistry
{
	[Token(Token = "0x4000F70")]
	[FieldOffset(Offset = "0x0")]
	private static Dictionary<string, List<IBaseUxmlObjectFactory>> s_Factories;

	[Token(Token = "0x1700092F")]
	internal static Dictionary<string, List<IBaseUxmlObjectFactory>> factories
	{
		[Token(Token = "0x60022CC")]
		[Address(RVA = "0x2A1E990", Offset = "0x2A1DB90", VA = "0x182A1E990")]
		[UnityEngine.Bindings.VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60022CD")]
	[Address(RVA = "0x2A1E330", Offset = "0x2A1D530", VA = "0x182A1E330")]
	protected static void RegisterFactory(IBaseUxmlObjectFactory factory)
	{
	}

	[Token(Token = "0x60022CE")]
	[Address(RVA = "0x2A1E0F0", Offset = "0x2A1D2F0", VA = "0x182A1E0F0")]
	private static void RegisterEngineFactories()
	{
	}

	[Token(Token = "0x60022CF")]
	[Address(RVA = "0x2A1E690", Offset = "0x2A1D890", VA = "0x182A1E690")]
	private static void RegisterUserFactories()
	{
	}
}
