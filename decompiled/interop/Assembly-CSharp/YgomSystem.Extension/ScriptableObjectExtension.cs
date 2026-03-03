using Il2CppDummyDll;
using UnityEngine;

namespace YgomSystem.Extension;

[Token(Token = "0x200036C")]
public static class ScriptableObjectExtension
{
	[Token(Token = "0x600154A")]
	public static T SafeRef<T>(this T scriptableObject) where T : ScriptableObject
	{
		return null;
	}
}
