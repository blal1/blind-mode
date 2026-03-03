using Il2CppDummyDll;

namespace UnityEngine.UIElements.UIR;

[Token(Token = "0x2000546")]
internal class BasicNodePool<T> : LinkedPool<BasicNode<T>>
{
	[Token(Token = "0x6002576")]
	private static void Reset(BasicNode<T> node)
	{
	}

	[Token(Token = "0x6002577")]
	private static BasicNode<T> Create()
	{
		return null;
	}

	[Token(Token = "0x6002578")]
	public BasicNodePool()
	{
	}
}
