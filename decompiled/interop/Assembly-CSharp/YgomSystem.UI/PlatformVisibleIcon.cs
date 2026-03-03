using Il2CppDummyDll;
using YgomSystem.Utility;

namespace YgomSystem.UI;

[Token(Token = "0x2000549")]
public class PlatformVisibleIcon : PlatformVisibleIconBase
{
	[Token(Token = "0x40019A8")]
	[FieldOffset(Offset = "0x38")]
	[EnumFlags]
	public DeviceInfo.Platform platformFlags;

	[Token(Token = "0x40019A9")]
	[FieldOffset(Offset = "0x3C")]
	[EnumFlags]
	public SelectorManager.InputDevice inputDeviceFlags;

	[Token(Token = "0x600224F")]
	[Address(RVA = "0x64D310", Offset = "0x64C510", VA = "0x18064D310", Slot = "4")]
	protected override bool IsDispPlatform()
	{
		return default(bool);
	}

	[Token(Token = "0x6002250")]
	[Address(RVA = "0x3D2BD0", Offset = "0x3D1DD0", VA = "0x1803D2BD0")]
	public PlatformVisibleIcon()
	{
	}
}
