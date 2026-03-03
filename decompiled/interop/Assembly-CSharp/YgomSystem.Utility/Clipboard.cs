using System.Reflection;
using Il2CppDummyDll;

namespace YgomSystem.Utility;

[Token(Token = "0x20003C4")]
public class Clipboard
{
	[Token(Token = "0x4001304")]
	[FieldOffset(Offset = "0x0")]
	private static PropertyInfo systemCopyBufferProperty;

	[Token(Token = "0x1700024B")]
	public static bool support
	{
		[Token(Token = "0x6001808")]
		[Address(RVA = "0x404830", Offset = "0x403A30", VA = "0x180404830")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6001809")]
	[Address(RVA = "0x5B9C70", Offset = "0x5B8E70", VA = "0x1805B9C70")]
	private static PropertyInfo GetSystemCopyBufferProperty()
	{
		return null;
	}

	[Token(Token = "0x600180A")]
	[Address(RVA = "0x5B9DD0", Offset = "0x5B8FD0", VA = "0x1805B9DD0")]
	public static void SetText(string text)
	{
	}

	[Token(Token = "0x600180B")]
	[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
	public Clipboard()
	{
	}
}
