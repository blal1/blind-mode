using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace YgomSystem.Advertisement;

[Token(Token = "0x2000352")]
public static class AdSDKManager
{
	[Token(Token = "0x17000226")]
	public static bool IsOptout
	{
		[Token(Token = "0x60014B7")]
		[Address(RVA = "0x51B410", Offset = "0x51A610", VA = "0x18051B410")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000227")]
	public static bool IsEnableDefine
	{
		[Token(Token = "0x60014B8")]
		[Address(RVA = "0x3C7A70", Offset = "0x3C6C70", VA = "0x1803C7A70")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000228")]
	public static bool IsEnable
	{
		[Token(Token = "0x60014B9")]
		[Address(RVA = "0x3C7A70", Offset = "0x3C6C70", VA = "0x1803C7A70")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000229")]
	public static bool IsInitialize
	{
		[Token(Token = "0x60014BA")]
		[Address(RVA = "0x51B3D0", Offset = "0x51A5D0", VA = "0x18051B3D0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60014BB")]
		[Address(RVA = "0x51B450", Offset = "0x51A650", VA = "0x18051B450")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x1700022A")]
	public static string AdId
	{
		[Token(Token = "0x60014BC")]
		[Address(RVA = "0x4C7DC0", Offset = "0x4C6FC0", VA = "0x1804C7DC0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700022B")]
	public static string Idfa
	{
		[Token(Token = "0x60014BD")]
		[Address(RVA = "0x4C7DC0", Offset = "0x4C6FC0", VA = "0x1804C7DC0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700022C")]
	public static string Idfv
	{
		[Token(Token = "0x60014BE")]
		[Address(RVA = "0x4C7DC0", Offset = "0x4C6FC0", VA = "0x1804C7DC0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700022D")]
	public static string gpsAdId
	{
		[Token(Token = "0x60014BF")]
		[Address(RVA = "0x4C7DC0", Offset = "0x4C6FC0", VA = "0x1804C7DC0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60014C0")]
	[Address(RVA = "0x51B3B0", Offset = "0x51A5B0", VA = "0x18051B3B0")]
	public static void Initialize([Optional] Action callback)
	{
	}

	[Token(Token = "0x60014C1")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60")]
	[Conditional("UNUSED_ADSDK_METHOD")]
	public static void UpdateID()
	{
	}

	[Token(Token = "0x60014C2")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60")]
	[Conditional("UNUSED_ADSDK_METHOD")]
	public static void UpdateAdjustData()
	{
	}

	[Token(Token = "0x60014C3")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60")]
	public static void OptoutNotificator(object o)
	{
	}

	[Token(Token = "0x60014C4")]
	[Address(RVA = "0x3C7A70", Offset = "0x3C6C70", VA = "0x1803C7A70")]
	public static bool IsAdRecommendEnable()
	{
		return default(bool);
	}

	[Token(Token = "0x60014C5")]
	[Address(RVA = "0x3D5200", Offset = "0x3D4400", VA = "0x1803D5200")]
	[Conditional("UNUSED_ADSDK_METHOD")]
	public static void OpenAdRecommend()
	{
	}

	[Token(Token = "0x60014C6")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60")]
	[Conditional("UNUSED_ADSDK_METHOD")]
	public static void SendTrackCreateUserId()
	{
	}

	[Token(Token = "0x60014C7")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60")]
	[Conditional("UNUSED_ADSDK_METHOD")]
	public static void SendTrackLaunch()
	{
	}

	[Token(Token = "0x60014C8")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60")]
	[Conditional("UNUSED_ADSDK_METHOD")]
	public static void SendTrackTutorialComp()
	{
	}
}
