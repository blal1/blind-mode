using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace YgomGame.Duel;

[Token(Token = "0x2001964")]
public abstract class CardEffectBase
{
	[Token(Token = "0x170018F4")]
	public CardRoot cardRoot
	{
		[Token(Token = "0x600A318")]
		[Address(RVA = "0x40C440", Offset = "0x40B640", VA = "0x18040C440")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x600A319")]
		[Address(RVA = "0x439010", Offset = "0x438210", VA = "0x180439010")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Token(Token = "0x170018F5")]
	public bool finished
	{
		[Token(Token = "0x600A31A")]
		[Address(RVA = "0x444790", Offset = "0x443990", VA = "0x180444790")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600A31B")]
		[Address(RVA = "0x662770", Offset = "0x661970", VA = "0x180662770")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Token(Token = "0x170018F6")]
	protected Action onFinished
	{
		[Token(Token = "0x600A31C")]
		[Address(RVA = "0x3D8370", Offset = "0x3D7570", VA = "0x1803D8370")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x600A31D")]
		[Address(RVA = "0x3D8380", Offset = "0x3D7580", VA = "0x1803D8380")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x600A31E")]
	public abstract void StartEffect();

	[Token(Token = "0x600A31F")]
	[Address(RVA = "0x444790", Offset = "0x443990", VA = "0x180444790", Slot = "5")]
	public virtual bool UpdateEffect()
	{
		return default(bool);
	}

	[Token(Token = "0x600A320")]
	[Address(RVA = "0xF02000", Offset = "0xF01200", VA = "0x180F02000")]
	public void OnFinished()
	{
	}

	[Token(Token = "0x600A321")]
	[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
	protected CardEffectBase()
	{
	}
}
