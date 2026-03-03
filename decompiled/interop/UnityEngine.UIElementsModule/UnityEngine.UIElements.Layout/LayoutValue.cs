using Il2CppDummyDll;

namespace UnityEngine.UIElements.Layout;

[Token(Token = "0x20005B3")]
internal struct LayoutValue
{
	[Token(Token = "0x400148B")]
	[FieldOffset(Offset = "0x0")]
	private float value;

	[Token(Token = "0x400148C")]
	[FieldOffset(Offset = "0x4")]
	private LayoutUnit unit;

	[Token(Token = "0x17000A22")]
	public LayoutUnit Unit
	{
		[Token(Token = "0x60027B4")]
		[Address(RVA = "0x9D59A0", Offset = "0x9D4BA0", VA = "0x1809D59A0")]
		get
		{
			return default(LayoutUnit);
		}
	}

	[Token(Token = "0x17000A23")]
	public float Value
	{
		[Token(Token = "0x60027B5")]
		[Address(RVA = "0x1C3A870", Offset = "0x1C39A70", VA = "0x181C3A870")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x60027B6")]
	[Address(RVA = "0x2A745D0", Offset = "0x2A737D0", VA = "0x182A745D0")]
	public static LayoutValue Point(float value)
	{
		return default(LayoutValue);
	}

	[Token(Token = "0x60027B7")]
	[Address(RVA = "0x2A74510", Offset = "0x2A73710", VA = "0x182A74510")]
	public bool Equals(LayoutValue other)
	{
		return default(bool);
	}

	[Token(Token = "0x60027B8")]
	[Address(RVA = "0x2A74420", Offset = "0x2A73620", VA = "0x182A74420", Slot = "0")]
	public override bool Equals(object obj)
	{
		return default(bool);
	}

	[Token(Token = "0x60027B9")]
	[Address(RVA = "0x2A74570", Offset = "0x2A73770", VA = "0x182A74570", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x60027BA")]
	[Address(RVA = "0x2A74600", Offset = "0x2A73800", VA = "0x182A74600")]
	public static LayoutValue Undefined()
	{
		return default(LayoutValue);
	}

	[Token(Token = "0x60027BB")]
	[Address(RVA = "0x2A74400", Offset = "0x2A73600", VA = "0x182A74400")]
	public static LayoutValue Auto()
	{
		return default(LayoutValue);
	}

	[Token(Token = "0x60027BC")]
	[Address(RVA = "0x2A745A0", Offset = "0x2A737A0", VA = "0x182A745A0")]
	public static LayoutValue Percent(float value)
	{
		return default(LayoutValue);
	}

	[Token(Token = "0x60027BD")]
	[Address(RVA = "0x2A745D0", Offset = "0x2A737D0", VA = "0x182A745D0")]
	public static implicit operator LayoutValue(float value)
	{
		return default(LayoutValue);
	}
}
