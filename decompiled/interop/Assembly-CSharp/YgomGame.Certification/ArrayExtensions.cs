using System;
using Il2CppDummyDll;

namespace YgomGame.Certification;

[Token(Token = "0x2001519")]
public static class ArrayExtensions
{
	[Token(Token = "0x6008298")]
	public static void ForEach<T>(this T[] array, Action<T> action)
	{
	}

	[Token(Token = "0x6008299")]
	public static void Sort<T>(this T[] array) where T : IComparable<T>
	{
	}
}
