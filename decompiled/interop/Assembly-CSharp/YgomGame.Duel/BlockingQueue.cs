using System.Collections.Generic;
using Il2CppDummyDll;

namespace YgomGame.Duel;

[Token(Token = "0x20017D1")]
public class BlockingQueue<T>
{
	[Token(Token = "0x400DEB8")]
	[FieldOffset(Offset = "0x0")]
	private Queue<T> queue;

	[Token(Token = "0x170016CD")]
	public int Count
	{
		[Token(Token = "0x6009655")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x6009656")]
	public void Clear()
	{
	}

	[Token(Token = "0x6009657")]
	public T Peek()
	{
		return (T)null;
	}

	[Token(Token = "0x6009658")]
	public void Enqueue(T obj)
	{
	}

	[Token(Token = "0x6009659")]
	public T Dequeue()
	{
		return (T)null;
	}

	[Token(Token = "0x600965A")]
	public T[] ToArray()
	{
		return null;
	}

	[Token(Token = "0x600965B")]
	public U DeepCopy<U>(U target)
	{
		return (U)null;
	}

	[Token(Token = "0x600965C")]
	public BlockingQueue()
	{
	}
}
