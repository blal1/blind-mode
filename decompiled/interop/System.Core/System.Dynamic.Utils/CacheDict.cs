using System.Reflection;
using Il2CppDummyDll;

namespace System.Dynamic.Utils;

[Token(Token = "0x200003A")]
[DefaultMember("Item")]
internal sealed class CacheDict<TKey, TValue>
{
	[Token(Token = "0x200003B")]
	private sealed class Entry
	{
	}

	[Token(Token = "0x4000109")]
	[FieldOffset(Offset = "0x0")]
	private readonly int _mask;

	[Token(Token = "0x400010A")]
	[FieldOffset(Offset = "0x0")]
	private readonly Entry[] _entries;

	[Token(Token = "0x6000142")]
	internal CacheDict(int size)
	{
	}

	[Token(Token = "0x6000143")]
	private static int AlignSize(int size)
	{
		return default(int);
	}
}
