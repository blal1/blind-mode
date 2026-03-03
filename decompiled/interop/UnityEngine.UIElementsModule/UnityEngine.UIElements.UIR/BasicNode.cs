using Il2CppDummyDll;

namespace UnityEngine.UIElements.UIR;

[Token(Token = "0x2000545")]
internal class BasicNode<T> : LinkedPoolItem<BasicNode<T>>
{
	[Token(Token = "0x400121B")]
	[FieldOffset(Offset = "0x0")]
	public BasicNode<T> next;

	[Token(Token = "0x400121C")]
	[FieldOffset(Offset = "0x0")]
	public T data;

	[Token(Token = "0x6002574")]
	public void InsertFirst(ref BasicNode<T> first)
	{
	}

	[Token(Token = "0x6002575")]
	public BasicNode()
	{
	}
}
