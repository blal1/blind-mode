using Il2CppDummyDll;
using UnityEngine;

namespace YgomSystem.Extension;

[Token(Token = "0x2000356")]
public static class ComponentExtension
{
	[Token(Token = "0x60014D0")]
	public static T SafeRef<T>(this T component) where T : Component
	{
		return null;
	}

	[Token(Token = "0x60014D1")]
	public static T GetOrAddComponent<T>(this Component component) where T : Component
	{
		return null;
	}

	[Token(Token = "0x60014D2")]
	public static T AddOrReplaceComponent<T>(this Component component) where T : Component
	{
		return null;
	}
}
