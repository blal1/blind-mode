using Il2CppDummyDll;

namespace UnityEngine.UIElements;

[Token(Token = "0x20002BF")]
internal struct Spacing
{
	[Token(Token = "0x4000B11")]
	[FieldOffset(Offset = "0x0")]
	public float left;

	[Token(Token = "0x4000B12")]
	[FieldOffset(Offset = "0x4")]
	public float top;

	[Token(Token = "0x4000B13")]
	[FieldOffset(Offset = "0x8")]
	public float right;

	[Token(Token = "0x4000B14")]
	[FieldOffset(Offset = "0xC")]
	public float bottom;

	[Token(Token = "0x170003A3")]
	public float horizontal
	{
		[Token(Token = "0x6001326")]
		[Address(RVA = "0x27C7150", Offset = "0x27C6350", VA = "0x1827C7150")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x170003A4")]
	public float vertical
	{
		[Token(Token = "0x6001327")]
		[Address(RVA = "0x27C7160", Offset = "0x27C6360", VA = "0x1827C7160")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x6001328")]
	[Address(RVA = "0x2440910", Offset = "0x243FB10", VA = "0x182440910")]
	public Spacing(float left, float top, float right, float bottom)
	{
	}

	[Token(Token = "0x6001329")]
	[Address(RVA = "0x2B6CC60", Offset = "0x2B6BE60", VA = "0x182B6CC60")]
	public static Rect operator -(Rect r, Spacing a)
	{
		return default(Rect);
	}
}
