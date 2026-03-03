using System.Collections.Generic;
using Il2CppDummyDll;

namespace YgomSystem.Extension;

[Token(Token = "0x200035C")]
public static class IReadOnlyCollectionExtension
{
	[Token(Token = "0x600150A")]
	public static bool IsNullOrEmpty<T>(this IReadOnlyCollection<T> self)
	{
		return default(bool);
	}

	[Token(Token = "0x600150B")]
	public static bool IsExists<T>(this IReadOnlyCollection<T> self)
	{
		return default(bool);
	}

	[Token(Token = "0x600150C")]
	public static int SafeGetCount<T>(this IReadOnlyCollection<T> self)
	{
		return default(int);
	}
}
