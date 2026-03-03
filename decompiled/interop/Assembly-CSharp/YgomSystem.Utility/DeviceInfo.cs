using System;
using Il2CppDummyDll;

namespace YgomSystem.Utility;

[Token(Token = "0x20003C9")]
public abstract class DeviceInfo
{
	[Token(Token = "0x20003CA")]
	public enum Platform
	{
		[Token(Token = "0x4001319")]
		Unknown,
		[Token(Token = "0x400131A")]
		PS4,
		[Token(Token = "0x400131B")]
		PS5,
		[Token(Token = "0x400131C")]
		XboxOne,
		[Token(Token = "0x400131D")]
		XboxSeriesX,
		[Token(Token = "0x400131E")]
		Switch,
		[Token(Token = "0x400131F")]
		Android,
		[Token(Token = "0x4001320")]
		iOS,
		[Token(Token = "0x4001321")]
		PC,
		[Token(Token = "0x4001322")]
		Stadia,
		[Token(Token = "0x4001323")]
		Switch2
	}

	[Token(Token = "0x20003CB")]
	public enum PlatformType
	{
		[Token(Token = "0x4001325")]
		Unknown,
		[Token(Token = "0x4001326")]
		Console,
		[Token(Token = "0x4001327")]
		Mobile,
		[Token(Token = "0x4001328")]
		PC
	}

	[Token(Token = "0x20003CC")]
	public enum ResourceType
	{
		[Token(Token = "0x400132A")]
		Unknown,
		[Token(Token = "0x400132B")]
		HighEnd_HD,
		[Token(Token = "0x400132C")]
		HighEnd,
		[Token(Token = "0x400132D")]
		LowEnd
	}

	[Token(Token = "0x4001312")]
	[FieldOffset(Offset = "0x0")]
	private static string version;

	[Token(Token = "0x4001313")]
	[FieldOffset(Offset = "0x8")]
	private static string model;

	[Token(Token = "0x4001314")]
	[FieldOffset(Offset = "0x10")]
	private static string platform;

	[Token(Token = "0x4001315")]
	[FieldOffset(Offset = "0x18")]
	private static string dateFormat;

	[Token(Token = "0x4001316")]
	[FieldOffset(Offset = "0x20")]
	private static DeviceInfo s_Instance;

	[Token(Token = "0x4001317")]
	[FieldOffset(Offset = "0x28")]
	private static int topMargin;

	[Token(Token = "0x17000250")]
	public static bool IsInitialized
	{
		[Token(Token = "0x6001826")]
		[Address(RVA = "0x5BC9D0", Offset = "0x5BBBD0", VA = "0x1805BC9D0")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000251")]
	public static bool isXboxView
	{
		[Token(Token = "0x6001837")]
		[Address(RVA = "0x5BCAE0", Offset = "0x5BBCE0", VA = "0x1805BCAE0")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000252")]
	public static bool isTargetPlatformPlayerView
	{
		[Token(Token = "0x6001838")]
		[Address(RVA = "0x5BCA30", Offset = "0x5BBC30", VA = "0x1805BCA30")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000253")]
	public static Platform viewPlatform
	{
		[Token(Token = "0x6001839")]
		[Address(RVA = "0x5BCC70", Offset = "0x5BBE70", VA = "0x1805BCC70")]
		get
		{
			return default(Platform);
		}
	}

	[Token(Token = "0x17000254")]
	public static PlatformType viewPlatformType
	{
		[Token(Token = "0x600183C")]
		[Address(RVA = "0x5BCBD0", Offset = "0x5BBDD0", VA = "0x1805BCBD0")]
		get
		{
			return default(PlatformType);
		}
	}

	[Token(Token = "0x17000255")]
	public static ResourceType resourceType
	{
		[Token(Token = "0x600183F")]
		[Address(RVA = "0x5BCB30", Offset = "0x5BBD30", VA = "0x1805BCB30")]
		get
		{
			return default(ResourceType);
		}
	}

	[Token(Token = "0x6001824")]
	[Address(RVA = "0x5BA770", Offset = "0x5B9970", VA = "0x1805BA770")]
	private static DeviceInfo GetInstance()
	{
		return null;
	}

	[Token(Token = "0x6001825")]
	[Address(RVA = "0x5BA4B0", Offset = "0x5B96B0", VA = "0x1805BA4B0")]
	private static DeviceInfo CreateInstance()
	{
		return null;
	}

	[Token(Token = "0x6001827")]
	[Address(RVA = "0x5BAFC0", Offset = "0x5BA1C0", VA = "0x1805BAFC0")]
	public static void Initialize()
	{
	}

	[Token(Token = "0x6001828")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "4")]
	public virtual void initialize()
	{
	}

	[Token(Token = "0x6001829")]
	[Address(RVA = "0x5BA530", Offset = "0x5B9730", VA = "0x1805BA530")]
	public static string GetAppVersion()
	{
		return null;
	}

	[Token(Token = "0x600182A")]
	[Address(RVA = "0x5BC960", Offset = "0x5BBB60", VA = "0x1805BC960", Slot = "5")]
	protected virtual string getAppVersion()
	{
		return null;
	}

	[Token(Token = "0x600182B")]
	[Address(RVA = "0x5BA840", Offset = "0x5B9A40", VA = "0x1805BA840")]
	public static string GetLanguage()
	{
		return null;
	}

	[Token(Token = "0x600182C")]
	public abstract string getLanguage();

	[Token(Token = "0x600182D")]
	[Address(RVA = "0x5BABF0", Offset = "0x5B9DF0", VA = "0x1805BABF0")]
	public static string GetRegion()
	{
		return null;
	}

	[Token(Token = "0x600182E")]
	public abstract string getRegion();

	[Token(Token = "0x600182F")]
	[Address(RVA = "0x5BA9A0", Offset = "0x5B9BA0", VA = "0x1805BA9A0")]
	public static string GetOSVersion()
	{
		return null;
	}

	[Token(Token = "0x6001830")]
	public abstract string getOSVersion();

	[Token(Token = "0x6001831")]
	[Address(RVA = "0x5BA8B0", Offset = "0x5B9AB0", VA = "0x1805BA8B0")]
	public static string GetModelName()
	{
		return null;
	}

	[Token(Token = "0x6001832")]
	public abstract string getModelName();

	[Token(Token = "0x6001833")]
	[Address(RVA = "0x5BAE70", Offset = "0x5BA070", VA = "0x1805BAE70")]
	public static string GetTimeZone()
	{
		return null;
	}

	[Token(Token = "0x6001834")]
	public abstract string getTimeZone();

	[Token(Token = "0x6001835")]
	[Address(RVA = "0x5BAB00", Offset = "0x5B9D00", VA = "0x1805BAB00")]
	public static string GetPlatform()
	{
		return null;
	}

	[Token(Token = "0x6001836")]
	public abstract string getPlatform();

	[Token(Token = "0x600183A")]
	[Address(RVA = "0x5BAF50", Offset = "0x5BA150", VA = "0x1805BAF50")]
	public static Platform GetViewPlatform()
	{
		return default(Platform);
	}

	[Token(Token = "0x600183B")]
	public abstract Platform getViewPlatform();

	[Token(Token = "0x600183D")]
	[Address(RVA = "0x5BAEE0", Offset = "0x5BA0E0", VA = "0x1805BAEE0")]
	public static PlatformType GetViewPlatformType()
	{
		return default(PlatformType);
	}

	[Token(Token = "0x600183E")]
	public abstract PlatformType getViewPlatformType();

	[Token(Token = "0x6001840")]
	[Address(RVA = "0x5BAC60", Offset = "0x5B9E60", VA = "0x1805BAC60")]
	public static ResourceType GetResourceType()
	{
		return default(ResourceType);
	}

	[Token(Token = "0x6001841")]
	public abstract ResourceType getResourceType();

	[Token(Token = "0x6001842")]
	[Address(RVA = "0x5BAE00", Offset = "0x5BA000", VA = "0x1805BAE00")]
	public static string GetStartupUrl()
	{
		return null;
	}

	[Token(Token = "0x6001843")]
	public abstract string getStartupUrl();

	[Token(Token = "0x6001844")]
	[Address(RVA = "0x5BA440", Offset = "0x5B9640", VA = "0x1805BA440")]
	public static void ClearStartupUrl()
	{
	}

	[Token(Token = "0x6001845")]
	public abstract void clearStartupUrl();

	[Token(Token = "0x6001846")]
	[Address(RVA = "0x5BA700", Offset = "0x5B9900", VA = "0x1805BA700")]
	public static string GetIDFA()
	{
		return null;
	}

	[Token(Token = "0x6001847")]
	public abstract string getIDFA();

	[Token(Token = "0x6001848")]
	[Address(RVA = "0x5BA690", Offset = "0x5B9890", VA = "0x1805BA690")]
	public static string GetDeviceHash()
	{
		return null;
	}

	[Token(Token = "0x6001849")]
	public abstract string getDeviceHash();

	[Token(Token = "0x600184A")]
	[Address(RVA = "0x5BA5A0", Offset = "0x5B97A0", VA = "0x1805BA5A0")]
	public static string GetDateFormat()
	{
		return null;
	}

	[Token(Token = "0x600184B")]
	public abstract string getDateFormat();

	[Token(Token = "0x600184C")]
	[Address(RVA = "0x5BAD40", Offset = "0x5B9F40", VA = "0x1805BAD40")]
	[Obsolete("このメソッドはMDでは使用されてない。", true)]
	public static int GetSafeAreaTopMargin()
	{
		return default(int);
	}

	[Token(Token = "0x600184D")]
	public abstract int getSafeAreaTopMargin();

	[Token(Token = "0x600184E")]
	[Address(RVA = "0x5BACD0", Offset = "0x5B9ED0", VA = "0x1805BACD0")]
	[Obsolete("このメソッドはMDでは使用されてない。", true)]
	public static int GetSafeAreaBottomMargin()
	{
		return default(int);
	}

	[Token(Token = "0x600184F")]
	public abstract int getSafeAreaBottomMargin();

	[Token(Token = "0x6001850")]
	[Address(RVA = "0x5BB0C0", Offset = "0x5BA2C0", VA = "0x1805BB0C0")]
	public static bool IsOverHeight()
	{
		return default(bool);
	}

	[Token(Token = "0x6001851")]
	[Address(RVA = "0x5BB110", Offset = "0x5BA310", VA = "0x1805BB110")]
	public static bool IsOverWidth()
	{
		return default(bool);
	}

	[Token(Token = "0x6001852")]
	[Address(RVA = "0x5BAA90", Offset = "0x5B9C90", VA = "0x1805BAA90")]
	public static string GetPlatformUserName()
	{
		return null;
	}

	[Token(Token = "0x6001853")]
	[Address(RVA = "0x5BC9A0", Offset = "0x5BBBA0", VA = "0x1805BC9A0", Slot = "22")]
	protected virtual string getPlatformUserName()
	{
		return null;
	}

	[Token(Token = "0x6001854")]
	[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
	protected DeviceInfo()
	{
	}
}
