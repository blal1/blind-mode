using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace YgomGame.DuelLive;

[Token(Token = "0x2000F0F")]
public class ProductContextCollection<T> : List<T>, IProductContextCollection where T : IProductContext, new()
{
	[Token(Token = "0x400A5D6")]
	[FieldOffset(Offset = "0x0")]
	public readonly List<T> m_ImportedContexts;

	[Token(Token = "0x400A5D7")]
	[FieldOffset(Offset = "0x0")]
	private readonly List<int> m_ImportedSubCategories;

	[Token(Token = "0x17000E4F")]
	public int filterSubId
	{
		[Token(Token = "0x6005B55")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6005B56")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x17000E50")]
	public bool isDisplayEmpty
	{
		[Token(Token = "0x6005B57")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000E51")]
	public List<int> subCategories
	{
		[Token(Token = "0x6005B58")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000E52")]
	public IReadOnlyList<IProductContext> importedContexts
	{
		[Token(Token = "0x6005B59")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000E53")]
	private IProductContext YgomGame_002EDuelLive_002EIProductContextCollection_002EItem
	{
		[Token(Token = "0x6005B5A")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1400008C")]
	public event Action onUpdatedEvent
	{
		[Token(Token = "0x6005B5B")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x6005B5C")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x6005B5D")]
	public bool IsEmpty()
	{
		return default(bool);
	}

	[Token(Token = "0x6005B5E")]
	public void Import(Dictionary<string, object> productDatas)
	{
	}

	[Token(Token = "0x6005B5F")]
	public void Filter()
	{
	}

	[Token(Token = "0x6005B60")]
	public void Filter(Func<T, bool> appendFilter)
	{
	}

	[Token(Token = "0x6005B61")]
	public ProductContextCollection()
	{
	}
}
