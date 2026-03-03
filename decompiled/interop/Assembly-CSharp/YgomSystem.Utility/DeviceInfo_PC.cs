using Il2CppDummyDll;

namespace YgomSystem.Utility;

[Token(Token = "0x20003CD")]
public class DeviceInfo_PC : DeviceInfo
{
	[Token(Token = "0x6001856")]
	[Address(RVA = "0x5BC890", Offset = "0x5BBA90", VA = "0x1805BC890", Slot = "4")]
	public override void initialize()
	{
	}

	[Token(Token = "0x6001857")]
	[Address(RVA = "0x5BB440", Offset = "0x5BA640", VA = "0x1805BB440", Slot = "6")]
	public override string getLanguage()
	{
		return null;
	}

	[Token(Token = "0x6001858")]
	[Address(RVA = "0x5BC130", Offset = "0x5BB330", VA = "0x1805BC130", Slot = "7")]
	public override string getRegion()
	{
		return null;
	}

	[Token(Token = "0x6001859")]
	[Address(RVA = "0x5BC020", Offset = "0x5BB220", VA = "0x1805BC020", Slot = "8")]
	public override string getOSVersion()
	{
		return null;
	}

	[Token(Token = "0x600185A")]
	[Address(RVA = "0x5BC010", Offset = "0x5BB210", VA = "0x1805BC010", Slot = "9")]
	public override string getModelName()
	{
		return null;
	}

	[Token(Token = "0x600185B")]
	[Address(RVA = "0x5BC740", Offset = "0x5BB940", VA = "0x1805BC740", Slot = "10")]
	public override string getTimeZone()
	{
		return null;
	}

	[Token(Token = "0x600185C")]
	[Address(RVA = "0x5BC0E0", Offset = "0x5BB2E0", VA = "0x1805BC0E0", Slot = "11")]
	public override string getPlatform()
	{
		return null;
	}

	[Token(Token = "0x600185D")]
	[Address(RVA = "0x577DA0", Offset = "0x576FA0", VA = "0x180577DA0", Slot = "12")]
	public override Platform getViewPlatform()
	{
		return default(Platform);
	}

	[Token(Token = "0x600185E")]
	[Address(RVA = "0x4465B0", Offset = "0x4457B0", VA = "0x1804465B0", Slot = "13")]
	public override PlatformType getViewPlatformType()
	{
		return default(PlatformType);
	}

	[Token(Token = "0x600185F")]
	[Address(RVA = "0x5BC6F0", Offset = "0x5BB8F0", VA = "0x1805BC6F0", Slot = "14")]
	public override ResourceType getResourceType()
	{
		return default(ResourceType);
	}

	[Token(Token = "0x6001860")]
	[Address(RVA = "0x3EF020", Offset = "0x3EE220", VA = "0x1803EF020", Slot = "15")]
	public override string getStartupUrl()
	{
		return null;
	}

	[Token(Token = "0x6001861")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "16")]
	public override void clearStartupUrl()
	{
	}

	[Token(Token = "0x6001862")]
	[Address(RVA = "0x3EF020", Offset = "0x3EE220", VA = "0x1803EF020", Slot = "17")]
	public override string getIDFA()
	{
		return null;
	}

	[Token(Token = "0x6001863")]
	[Address(RVA = "0x5BB280", Offset = "0x5BA480", VA = "0x1805BB280", Slot = "18")]
	public override string getDeviceHash()
	{
		return null;
	}

	[Token(Token = "0x6001864")]
	[Address(RVA = "0x5BB1B0", Offset = "0x5BA3B0", VA = "0x1805BB1B0", Slot = "19")]
	public override string getDateFormat()
	{
		return null;
	}

	[Token(Token = "0x6001865")]
	[Address(RVA = "0x3EF020", Offset = "0x3EE220", VA = "0x1803EF020", Slot = "20")]
	public override int getSafeAreaTopMargin()
	{
		return default(int);
	}

	[Token(Token = "0x6001866")]
	[Address(RVA = "0x3EF020", Offset = "0x3EE220", VA = "0x1803EF020", Slot = "21")]
	public override int getSafeAreaBottomMargin()
	{
		return default(int);
	}

	[Token(Token = "0x6001867")]
	[Address(RVA = "0x5BB160", Offset = "0x5BA360", VA = "0x1805BB160")]
	public DeviceInfo_PC()
	{
	}
}
