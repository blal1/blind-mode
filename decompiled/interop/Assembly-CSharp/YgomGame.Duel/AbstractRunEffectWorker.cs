using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace YgomGame.Duel;

[Token(Token = "0x2001AC5")]
public abstract class AbstractRunEffectWorker
{
	[Token(Token = "0x17001AED")]
	public virtual bool isInitialized
	{
		[Token(Token = "0x600ADFF")]
		[Address(RVA = "0x404830", Offset = "0x403A30", VA = "0x180404830", Slot = "4")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600AE00")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		protected set
		{
		}
	}

	[Token(Token = "0x17001AEE")]
	public virtual bool isPreparedToDuel
	{
		[Token(Token = "0x600AE02")]
		[Address(RVA = "0x404830", Offset = "0x403A30", VA = "0x180404830", Slot = "7")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600AE03")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "8")]
		protected set
		{
		}
	}

	[Token(Token = "0x17001AEF")]
	public virtual bool isTerminated
	{
		[Token(Token = "0x600AE05")]
		[Address(RVA = "0x404830", Offset = "0x403A30", VA = "0x180404830", Slot = "10")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600AE06")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "11")]
		protected set
		{
		}
	}

	[Token(Token = "0x17001AF0")]
	public DuelClient host
	{
		[Token(Token = "0x600AE0B")]
		[Address(RVA = "0x40C440", Offset = "0x40B640", VA = "0x18040C440")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x600AE0C")]
		[Address(RVA = "0x439010", Offset = "0x438210", VA = "0x180439010")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Token(Token = "0x600AE01")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "6")]
	public virtual void PrepareToDuel()
	{
	}

	[Token(Token = "0x600AE04")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "9")]
	public virtual void Terminate()
	{
	}

	[Token(Token = "0x600AE07")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "12")]
	public virtual void OnDestroy()
	{
	}

	[Token(Token = "0x600AE08")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "13")]
	[Obsolete]
	public virtual void RunEffect(Engine.ViewType viewType, int param1, int param2, int param3)
	{
	}

	[Token(Token = "0x600AE09")]
	[Address(RVA = "0x3C7A70", Offset = "0x3C6C70", VA = "0x1803C7A70", Slot = "14")]
	public virtual bool IsBusyEffect(Engine.ViewType viewType)
	{
		return default(bool);
	}

	[Token(Token = "0x600AE0A")]
	[Address(RVA = "0x438FD0", Offset = "0x4381D0", VA = "0x180438FD0")]
	public AbstractRunEffectWorker(DuelClient host)
	{
	}
}
