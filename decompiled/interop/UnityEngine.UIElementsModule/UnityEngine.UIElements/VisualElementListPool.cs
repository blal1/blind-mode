using System.Collections.Generic;
using Il2CppDummyDll;

namespace UnityEngine.UIElements;

[Token(Token = "0x20004DD")]
internal static class VisualElementListPool
{
	[Token(Token = "0x4001003")]
	[FieldOffset(Offset = "0x0")]
	private static ObjectPool<List<VisualElement>> pool;

	[Token(Token = "0x6002364")]
	[Address(RVA = "0x2A3E8E0", Offset = "0x2A3DAE0", VA = "0x182A3E8E0")]
	public static List<VisualElement> Copy(List<VisualElement> elements)
	{
		return null;
	}

	[Token(Token = "0x6002365")]
	[Address(RVA = "0x2A3E990", Offset = "0x2A3DB90", VA = "0x182A3E990")]
	public static List<VisualElement> Get(int initialCapacity = 0)
	{
		return null;
	}

	[Token(Token = "0x6002366")]
	[Address(RVA = "0x2A3EA60", Offset = "0x2A3DC60", VA = "0x182A3EA60")]
	public static void Release(List<VisualElement> elements)
	{
	}
}
