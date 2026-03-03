using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace YgomGame.DuelLive;

[Token(Token = "0x2000F0D")]
public abstract class ProductContextBase<T> : IComparable<T>, IProductContext
{
	[Token(Token = "0x400A5D5")]
	[FieldOffset(Offset = "0x0")]
	protected Dictionary<string, object> m_ProductData;

	[Token(Token = "0x17000E2C")]
	public long duelLiveId
	{
		[Token(Token = "0x6005B28")]
		get
		{
			return default(long);
		}
	}

	[Token(Token = "0x17000E2D")]
	public int menuId
	{
		[Token(Token = "0x6005B29")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000E2E")]
	public int replayIdx
	{
		[Token(Token = "0x6005B2A")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000E2F")]
	public int categoryId
	{
		[Token(Token = "0x6005B2B")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000E30")]
	public int categoryIdx
	{
		[Token(Token = "0x6005B2C")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000E31")]
	public int subCategoryId
	{
		[Token(Token = "0x6005B2D")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000E32")]
	public int subCategoryIdx
	{
		[Token(Token = "0x6005B2E")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000E33")]
	public int sectionId
	{
		[Token(Token = "0x6005B2F")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000E34")]
	public int widgetType
	{
		[Token(Token = "0x6005B30")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000E35")]
	public List<object> mrk
	{
		[Token(Token = "0x6005B31")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000E36")]
	public string imagePath
	{
		[Token(Token = "0x6005B32")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000E37")]
	public string name1
	{
		[Token(Token = "0x6005B33")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000E38")]
	public string name2
	{
		[Token(Token = "0x6005B34")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000E39")]
	public int userId1
	{
		[Token(Token = "0x6005B35")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000E3A")]
	public int userId2
	{
		[Token(Token = "0x6005B36")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000E3B")]
	public int teamId1
	{
		[Token(Token = "0x6005B37")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000E3C")]
	public int teamId2
	{
		[Token(Token = "0x6005B38")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000E3D")]
	public int highlightId
	{
		[Token(Token = "0x6005B39")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000E3E")]
	public bool badget
	{
		[Token(Token = "0x6005B3A")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000E3F")]
	public int userIcon1
	{
		[Token(Token = "0x6005B3B")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000E40")]
	public int userIcon2
	{
		[Token(Token = "0x6005B3C")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000E41")]
	public int userIconFrame1
	{
		[Token(Token = "0x6005B3D")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000E42")]
	public int userIconFrame2
	{
		[Token(Token = "0x6005B3E")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000E43")]
	public int userDeckCase1
	{
		[Token(Token = "0x6005B3F")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000E44")]
	public int userDeckCase2
	{
		[Token(Token = "0x6005B40")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000E45")]
	public int highlightCardMenuId
	{
		[Token(Token = "0x6005B41")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000E46")]
	public int winnerId
	{
		[Token(Token = "0x6005B42")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000E47")]
	public bool isDeckPublic
	{
		[Token(Token = "0x6005B43")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000E48")]
	public int sort
	{
		[Token(Token = "0x6005B44")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x6005B45")]
	public void Import(Dictionary<string, object> productData)
	{
	}

	[Token(Token = "0x6005B46")]
	public abstract int Compare(T a, T b);

	[Token(Token = "0x6005B47")]
	public abstract int CompareTo(T other);

	[Token(Token = "0x6005B48")]
	protected ProductContextBase()
	{
	}
}
