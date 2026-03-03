using Il2CppDummyDll;

namespace com.adjust.sdk;

[Token(Token = "0x2001DD4")]
internal class JSONLazyCreator : JSONNode
{
	[Token(Token = "0x401056E")]
	[FieldOffset(Offset = "0x10")]
	private JSONNode m_Node;

	[Token(Token = "0x401056F")]
	[FieldOffset(Offset = "0x18")]
	private string m_Key;

	[Token(Token = "0x17001C55")]
	public override JSONNode this[int aIndex]
	{
		[Token(Token = "0x600BEE6")]
		[Address(RVA = "0x59DCC0", Offset = "0x59CEC0", VA = "0x18059DCC0", Slot = "5")]
		get
		{
			return null;
		}
		[Token(Token = "0x600BEE7")]
		[Address(RVA = "0x59E150", Offset = "0x59D350", VA = "0x18059E150", Slot = "6")]
		set
		{
		}
	}

	[Token(Token = "0x17001C56")]
	public override JSONNode this[string aKey]
	{
		[Token(Token = "0x600BEE8")]
		[Address(RVA = "0x59DD40", Offset = "0x59CF40", VA = "0x18059DD40", Slot = "7")]
		get
		{
			return null;
		}
		[Token(Token = "0x600BEE9")]
		[Address(RVA = "0x59E230", Offset = "0x59D430", VA = "0x18059E230", Slot = "8")]
		set
		{
		}
	}

	[Token(Token = "0x17001C57")]
	public override int AsInt
	{
		[Token(Token = "0x600BEF2")]
		[Address(RVA = "0x59DB40", Offset = "0x59CD40", VA = "0x18059DB40", Slot = "18")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x600BEF3")]
		[Address(RVA = "0x59E070", Offset = "0x59D270", VA = "0x18059E070", Slot = "19")]
		set
		{
		}
	}

	[Token(Token = "0x17001C58")]
	public override float AsFloat
	{
		[Token(Token = "0x600BEF4")]
		[Address(RVA = "0x59DA70", Offset = "0x59CC70", VA = "0x18059DA70", Slot = "20")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x600BEF5")]
		[Address(RVA = "0x59DF90", Offset = "0x59D190", VA = "0x18059DF90", Slot = "21")]
		set
		{
		}
	}

	[Token(Token = "0x17001C59")]
	public override double AsDouble
	{
		[Token(Token = "0x600BEF6")]
		[Address(RVA = "0x59D9A0", Offset = "0x59CBA0", VA = "0x18059D9A0", Slot = "22")]
		get
		{
			return default(double);
		}
		[Token(Token = "0x600BEF7")]
		[Address(RVA = "0x59DEB0", Offset = "0x59D0B0", VA = "0x18059DEB0", Slot = "23")]
		set
		{
		}
	}

	[Token(Token = "0x17001C5A")]
	public override bool AsBool
	{
		[Token(Token = "0x600BEF8")]
		[Address(RVA = "0x59D8D0", Offset = "0x59CAD0", VA = "0x18059D8D0", Slot = "24")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600BEF9")]
		[Address(RVA = "0x59DDD0", Offset = "0x59CFD0", VA = "0x18059DDD0", Slot = "25")]
		set
		{
		}
	}

	[Token(Token = "0x17001C5B")]
	public override JSONArray AsArray
	{
		[Token(Token = "0x600BEFA")]
		[Address(RVA = "0x59D820", Offset = "0x59CA20", VA = "0x18059D820", Slot = "26")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001C5C")]
	public override JSONClass AsObject
	{
		[Token(Token = "0x600BEFB")]
		[Address(RVA = "0x59DC10", Offset = "0x59CE10", VA = "0x18059DC10", Slot = "27")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600BEE3")]
	[Address(RVA = "0x59D7D0", Offset = "0x59C9D0", VA = "0x18059D7D0")]
	public JSONLazyCreator(JSONNode aNode)
	{
	}

	[Token(Token = "0x600BEE4")]
	[Address(RVA = "0x59D780", Offset = "0x59C980", VA = "0x18059D780")]
	public JSONLazyCreator(JSONNode aNode, string aKey)
	{
	}

	[Token(Token = "0x600BEE5")]
	[Address(RVA = "0x59D6B0", Offset = "0x59C8B0", VA = "0x18059D6B0")]
	private void Set(JSONNode aVal)
	{
	}

	[Token(Token = "0x600BEEA")]
	[Address(RVA = "0x59D4C0", Offset = "0x59C6C0", VA = "0x18059D4C0", Slot = "12")]
	public override void Add(JSONNode aItem)
	{
	}

	[Token(Token = "0x600BEEB")]
	[Address(RVA = "0x59D5A0", Offset = "0x59C7A0", VA = "0x18059D5A0", Slot = "4")]
	public override void Add(string aKey, JSONNode aItem)
	{
	}

	[Token(Token = "0x600BEEC")]
	[Address(RVA = "0x59D690", Offset = "0x59C890", VA = "0x18059D690")]
	public static bool operator ==(JSONLazyCreator a, object b)
	{
		return default(bool);
	}

	[Token(Token = "0x600BEED")]
	[Address(RVA = "0x59DDC0", Offset = "0x59CFC0", VA = "0x18059DDC0")]
	public static bool operator !=(JSONLazyCreator a, object b)
	{
		return default(bool);
	}

	[Token(Token = "0x600BEEE")]
	[Address(RVA = "0x59D690", Offset = "0x59C890", VA = "0x18059D690", Slot = "0")]
	public override bool Equals(object obj)
	{
		return default(bool);
	}

	[Token(Token = "0x600BEEF")]
	[Address(RVA = "0x59D6A0", Offset = "0x59C8A0", VA = "0x18059D6A0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x600BEF0")]
	[Address(RVA = "0x59D720", Offset = "0x59C920", VA = "0x18059D720", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x600BEF1")]
	[Address(RVA = "0x59D750", Offset = "0x59C950", VA = "0x18059D750", Slot = "17")]
	public override string ToString(string aPrefix)
	{
		return null;
	}
}
