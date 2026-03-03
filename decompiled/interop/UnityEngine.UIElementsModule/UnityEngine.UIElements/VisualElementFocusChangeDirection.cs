using Il2CppDummyDll;

namespace UnityEngine.UIElements;

[Token(Token = "0x20004EE")]
public class VisualElementFocusChangeDirection : FocusChangeDirection
{
	[Token(Token = "0x4001033")]
	[FieldOffset(Offset = "0x0")]
	private static readonly VisualElementFocusChangeDirection s_Left;

	[Token(Token = "0x4001034")]
	[FieldOffset(Offset = "0x8")]
	private static readonly VisualElementFocusChangeDirection s_Right;

	[Token(Token = "0x1700095A")]
	public static FocusChangeDirection left
	{
		[Token(Token = "0x6002396")]
		[Address(RVA = "0x2A3CDD0", Offset = "0x2A3BFD0", VA = "0x182A3CDD0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700095B")]
	public static FocusChangeDirection right
	{
		[Token(Token = "0x6002397")]
		[Address(RVA = "0x2A3CE20", Offset = "0x2A3C020", VA = "0x182A3CE20")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6002398")]
	[Address(RVA = "0x2A3CD70", Offset = "0x2A3BF70", VA = "0x182A3CD70")]
	protected VisualElementFocusChangeDirection(int value)
	{
	}
}
