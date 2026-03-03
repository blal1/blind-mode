using Il2CppDummyDll;

namespace YgomSystem.UI;

[Token(Token = "0x2000547")]
public class PlatformTypeVisibleIcon : PlatformVisibleIconBase
{
	[Token(Token = "0x2000548")]
	public enum PlatformFlags
	{
		[Token(Token = "0x40019A3")]
		Console_Pad = 1,
		[Token(Token = "0x40019A4")]
		Console_Point = 2,
		[Token(Token = "0x40019A5")]
		Mobile = 4,
		[Token(Token = "0x40019A6")]
		PC_Pad = 8,
		[Token(Token = "0x40019A7")]
		PC_Point = 0x10
	}

	[Token(Token = "0x40019A1")]
	[FieldOffset(Offset = "0x38")]
	[EnumFlags]
	public PlatformFlags platformFlags;

	[Token(Token = "0x600224D")]
	[Address(RVA = "0x64CDB0", Offset = "0x64BFB0", VA = "0x18064CDB0", Slot = "4")]
	protected override bool IsDispPlatform()
	{
		return default(bool);
	}

	[Token(Token = "0x600224E")]
	[Address(RVA = "0x3D2BD0", Offset = "0x3D1DD0", VA = "0x1803D2BD0")]
	public PlatformTypeVisibleIcon()
	{
	}
}
