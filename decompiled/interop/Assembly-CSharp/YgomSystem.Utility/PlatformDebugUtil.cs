using Il2CppDummyDll;

namespace YgomSystem.Utility;

[Token(Token = "0x20003F3")]
public static class PlatformDebugUtil
{
	[Token(Token = "0x40013B7")]
	public const string prefsKeyDebugActive = "PlatformDebug";

	[Token(Token = "0x40013B8")]
	public const string prefsKeyPlatform = "PlatformDebugType";

	[Token(Token = "0x40013B9")]
	public const string prefsKeyDisplayToolbar = "PlatformDebugDisplayToolbar";

	[Token(Token = "0x1700025D")]
	public static bool isPlatformDebugActive
	{
		[Token(Token = "0x6001947")]
		[Address(RVA = "0x3C7A70", Offset = "0x3C6C70", VA = "0x1803C7A70")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700025E")]
	public static DeviceInfo.Platform debugPlatform
	{
		[Token(Token = "0x6001948")]
		[Address(RVA = "0x3EF020", Offset = "0x3EE220", VA = "0x1803EF020")]
		get
		{
			return default(DeviceInfo.Platform);
		}
	}

	[Token(Token = "0x1700025F")]
	public static DeviceInfo.PlatformType debugPlatformType
	{
		[Token(Token = "0x6001949")]
		[Address(RVA = "0x5D1990", Offset = "0x5D0B90", VA = "0x1805D1990")]
		get
		{
			return default(DeviceInfo.PlatformType);
		}
	}
}
