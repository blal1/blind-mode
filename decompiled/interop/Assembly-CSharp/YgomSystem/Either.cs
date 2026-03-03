using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace YgomSystem;

[Token(Token = "0x200015B")]
public class Either<L, R>
{
	[Token(Token = "0x170000EA")]
	public L Left
	{
		[Token(Token = "0x6000899")]
		[CompilerGenerated]
		get
		{
			return (L)null;
		}
	}

	[Token(Token = "0x170000EB")]
	public R Right
	{
		[Token(Token = "0x600089A")]
		[CompilerGenerated]
		get
		{
			return (R)null;
		}
	}

	[Token(Token = "0x170000EC")]
	public bool isRight
	{
		[Token(Token = "0x600089B")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170000ED")]
	public bool isLeft
	{
		[Token(Token = "0x600089C")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x600089D")]
	private Either(L left)
	{
	}

	[Token(Token = "0x600089E")]
	private Either(R right)
	{
	}

	[Token(Token = "0x600089F")]
	public static Either<L, R> CreateRight(R right)
	{
		return null;
	}

	[Token(Token = "0x60008A0")]
	public static Either<L, R> CreateLeft(L left)
	{
		return null;
	}

	[Token(Token = "0x60008A1")]
	public void Match(Action<L> left, Action<R> right)
	{
	}

	[Token(Token = "0x60008A2")]
	public T Match<T>(Func<L, T> left, Func<R, T> right)
	{
		return (T)null;
	}
}
