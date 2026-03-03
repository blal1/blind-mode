using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine.Playables;

namespace YgomGame.Duel;

[Token(Token = "0x2001923")]
public abstract class SpecialWinBase
{
	[Token(Token = "0x400EAE1")]
	[FieldOffset(Offset = "0x10")]
	protected PlayableDirector timeline;

	[Token(Token = "0x170018CC")]
	protected abstract string prefabPath
	{
		[Token(Token = "0x600A21B")]
		get;
	}

	[Token(Token = "0x170018CD")]
	public bool isReady
	{
		[Token(Token = "0x600A21C")]
		[Address(RVA = "0x444790", Offset = "0x443990", VA = "0x180444790")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600A21D")]
		[Address(RVA = "0x662770", Offset = "0x661970", VA = "0x180662770")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Token(Token = "0x170018CE")]
	public virtual bool finished
	{
		[Token(Token = "0x600A21E")]
		[Address(RVA = "0x7CE720", Offset = "0x7CD920", VA = "0x1807CE720", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600A21F")]
		[Address(RVA = "0xAA0C10", Offset = "0xA9FE10", VA = "0x180AA0C10", Slot = "6")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Token(Token = "0x170018CF")]
	public bool goNext
	{
		[Token(Token = "0x600A220")]
		[Address(RVA = "0x7CE750", Offset = "0x7CD950", VA = "0x1807CE750")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600A221")]
		[Address(RVA = "0xEF99A0", Offset = "0xEF8BA0", VA = "0x180EF99A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x170018D0")]
	protected abstract List<string> seList
	{
		[Token(Token = "0x600A222")]
		get;
	}

	[Token(Token = "0x170018D1")]
	protected virtual bool destroyOnWinStart
	{
		[Token(Token = "0x600A223")]
		[Address(RVA = "0x3C7A70", Offset = "0x3C6C70", VA = "0x1803C7A70", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x600A224")]
	[Address(RVA = "0xEF9420", Offset = "0xEF8620", VA = "0x180EF9420", Slot = "9")]
	public virtual void Initialize()
	{
	}

	[Token(Token = "0x600A225")]
	[Address(RVA = "0xEF9420", Offset = "0xEF8620", VA = "0x180EF9420")]
	protected void LoadSE()
	{
	}

	[Token(Token = "0x600A226")]
	[Address(RVA = "0xEF95E0", Offset = "0xEF87E0", VA = "0x180EF95E0")]
	protected void LoadTimeine(Action<PlayableDirector> onLoaded)
	{
	}

	[Token(Token = "0x600A227")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "10")]
	protected virtual void Setup(PlayableDirector timeline)
	{
	}

	[Token(Token = "0x600A228")]
	[Address(RVA = "0xEF9780", Offset = "0xEF8980", VA = "0x180EF9780")]
	public void Play(Action onWinStart)
	{
	}

	[Token(Token = "0x600A229")]
	[Address(RVA = "0xEF9760", Offset = "0xEF8960", VA = "0x180EF9760", Slot = "11")]
	protected virtual void OnFinished()
	{
	}

	[Token(Token = "0x600A22A")]
	[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
	protected SpecialWinBase()
	{
	}
}
