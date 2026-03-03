using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine.Bindings;

namespace UnityEngine.UIElements;

[Token(Token = "0x20004DF")]
[UnityEngine.Bindings.VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
internal class ObjectListPool<T>
{
	[Token(Token = "0x4001005")]
	[FieldOffset(Offset = "0x0")]
	private static ObjectPool<List<T>> pool;

	[Token(Token = "0x600236B")]
	public static List<T> Get()
	{
		return null;
	}

	[Token(Token = "0x600236C")]
	public static void Release(List<T> elements)
	{
	}
}
