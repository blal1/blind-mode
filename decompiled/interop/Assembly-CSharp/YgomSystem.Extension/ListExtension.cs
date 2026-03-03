using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace YgomSystem.Extension;

[Token(Token = "0x200035B")]
public static class ListExtension
{
	[Token(Token = "0x6001502")]
	public static bool IsNullOrEmpty<T>(this List<T> self)
	{
		return default(bool);
	}

	[Token(Token = "0x6001503")]
	public static bool IsExists<T>(this List<T> self)
	{
		return default(bool);
	}

	[Token(Token = "0x6001504")]
	public static int SafeGetCount<T>(this List<T> self)
	{
		return default(int);
	}

	[Token(Token = "0x6001505")]
	public static void Indexed<T>(this IEnumerable<T> enumerable, Action<T, int> func)
	{
	}

	[Token(Token = "0x6001506")]
	public static T GetValueAt<T>(this List<object> list, int index, Func<T, bool> predicator)
	{
		return (T)null;
	}

	[Token(Token = "0x6001507")]
	[Address(RVA = "0x524A40", Offset = "0x523C40", VA = "0x180524A40")]
	public static Dictionary<string, object> GetDicAt(this List<object> list, int index)
	{
		return null;
	}

	[Token(Token = "0x6001508")]
	[Address(RVA = "0x524A90", Offset = "0x523C90", VA = "0x180524A90")]
	public static Dictionary<string, object> GetDicOrEmptyAt(this List<object> list, int index)
	{
		return null;
	}

	[Token(Token = "0x6001509")]
	public static void Shuffle<T>(this List<T> list, [Optional] int? seed)
	{
	}
}
