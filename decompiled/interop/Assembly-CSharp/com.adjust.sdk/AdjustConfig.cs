using System;
using Il2CppDummyDll;

namespace com.adjust.sdk;

[Token(Token = "0x2001DDA")]
public class AdjustConfig
{
	[Token(Token = "0x40105A9")]
	public const string AdjustUrlStrategyChina = "china";

	[Token(Token = "0x40105AA")]
	public const string AdjustUrlStrategyIndia = "india";

	[Token(Token = "0x40105AB")]
	public const string AdjustUrlStrategyCn = "cn";

	[Token(Token = "0x40105AC")]
	public const string AdjustDataResidencyEU = "data-residency-eu";

	[Token(Token = "0x40105AD")]
	public const string AdjustDataResidencyTR = "data-residency-tr";

	[Token(Token = "0x40105AE")]
	public const string AdjustDataResidencyUS = "data-residency-us";

	[Token(Token = "0x40105AF")]
	public const string AdjustAdRevenueSourceAppLovinMAX = "applovin_max_sdk";

	[Token(Token = "0x40105B0")]
	public const string AdjustAdRevenueSourceMopub = "mopub";

	[Token(Token = "0x40105B1")]
	public const string AdjustAdRevenueSourceAdMob = "admob_sdk";

	[Token(Token = "0x40105B2")]
	public const string AdjustAdRevenueSourceIronSource = "ironsource_sdk";

	[Token(Token = "0x40105B3")]
	public const string AdjustAdRevenueSourceAdmost = "admost_sdk";

	[Token(Token = "0x40105B4")]
	public const string AdjustAdRevenueSourceUnity = "unity_sdk";

	[Token(Token = "0x40105B5")]
	public const string AdjustAdRevenueSourceHeliumChartboost = "helium_chartboost_sdk";

	[Token(Token = "0x40105B6")]
	public const string AdjustAdRevenueSourcePublisher = "publisher_sdk";

	[Token(Token = "0x40105B7")]
	[FieldOffset(Offset = "0x10")]
	internal string appToken;

	[Token(Token = "0x40105B8")]
	[FieldOffset(Offset = "0x18")]
	internal string sceneName;

	[Token(Token = "0x40105B9")]
	[FieldOffset(Offset = "0x20")]
	internal string userAgent;

	[Token(Token = "0x40105BA")]
	[FieldOffset(Offset = "0x28")]
	internal string defaultTracker;

	[Token(Token = "0x40105BB")]
	[FieldOffset(Offset = "0x30")]
	internal string externalDeviceId;

	[Token(Token = "0x40105BC")]
	[FieldOffset(Offset = "0x38")]
	internal string urlStrategy;

	[Token(Token = "0x40105BD")]
	[FieldOffset(Offset = "0x40")]
	internal long? info1;

	[Token(Token = "0x40105BE")]
	[FieldOffset(Offset = "0x50")]
	internal long? info2;

	[Token(Token = "0x40105BF")]
	[FieldOffset(Offset = "0x60")]
	internal long? info3;

	[Token(Token = "0x40105C0")]
	[FieldOffset(Offset = "0x70")]
	internal long? info4;

	[Token(Token = "0x40105C1")]
	[FieldOffset(Offset = "0x80")]
	internal long? secretId;

	[Token(Token = "0x40105C2")]
	[FieldOffset(Offset = "0x90")]
	internal double? delayStart;

	[Token(Token = "0x40105C3")]
	[FieldOffset(Offset = "0xA0")]
	internal bool? isDeviceKnown;

	[Token(Token = "0x40105C4")]
	[FieldOffset(Offset = "0xA2")]
	internal bool? sendInBackground;

	[Token(Token = "0x40105C5")]
	[FieldOffset(Offset = "0xA4")]
	internal bool? eventBufferingEnabled;

	[Token(Token = "0x40105C6")]
	[FieldOffset(Offset = "0xA6")]
	internal bool? coppaCompliantEnabled;

	[Token(Token = "0x40105C7")]
	[FieldOffset(Offset = "0xA8")]
	internal bool? playStoreKidsAppEnabled;

	[Token(Token = "0x40105C8")]
	[FieldOffset(Offset = "0xAA")]
	internal bool? allowSuppressLogLevel;

	[Token(Token = "0x40105C9")]
	[FieldOffset(Offset = "0xAC")]
	internal bool? needsCost;

	[Token(Token = "0x40105CA")]
	[FieldOffset(Offset = "0xAE")]
	internal bool launchDeferredDeeplink;

	[Token(Token = "0x40105CB")]
	[FieldOffset(Offset = "0xB0")]
	internal AdjustLogLevel? logLevel;

	[Token(Token = "0x40105CC")]
	[FieldOffset(Offset = "0xB8")]
	internal AdjustEnvironment environment;

	[Token(Token = "0x40105CD")]
	[FieldOffset(Offset = "0xC0")]
	internal Action<string> deferredDeeplinkDelegate;

	[Token(Token = "0x40105CE")]
	[FieldOffset(Offset = "0xC8")]
	internal Action<AdjustEventSuccess> eventSuccessDelegate;

	[Token(Token = "0x40105CF")]
	[FieldOffset(Offset = "0xD0")]
	internal Action<AdjustEventFailure> eventFailureDelegate;

	[Token(Token = "0x40105D0")]
	[FieldOffset(Offset = "0xD8")]
	internal Action<AdjustSessionSuccess> sessionSuccessDelegate;

	[Token(Token = "0x40105D1")]
	[FieldOffset(Offset = "0xE0")]
	internal Action<AdjustSessionFailure> sessionFailureDelegate;

	[Token(Token = "0x40105D2")]
	[FieldOffset(Offset = "0xE8")]
	internal Action<AdjustAttribution> attributionChangedDelegate;

	[Token(Token = "0x40105D3")]
	[FieldOffset(Offset = "0xF0")]
	internal Action<int> conversionValueUpdatedDelegate;

	[Token(Token = "0x40105D4")]
	[FieldOffset(Offset = "0xF8")]
	internal Action<int, string, bool> skad4ConversionValueUpdatedDelegate;

	[Token(Token = "0x40105D5")]
	[FieldOffset(Offset = "0x100")]
	internal string processName;

	[Token(Token = "0x40105D6")]
	[FieldOffset(Offset = "0x108")]
	internal bool? readImei;

	[Token(Token = "0x40105D7")]
	[FieldOffset(Offset = "0x10A")]
	internal bool? preinstallTrackingEnabled;

	[Token(Token = "0x40105D8")]
	[FieldOffset(Offset = "0x110")]
	internal string preinstallFilePath;

	[Token(Token = "0x40105D9")]
	[FieldOffset(Offset = "0x118")]
	internal bool? allowAdServicesInfoReading;

	[Token(Token = "0x40105DA")]
	[FieldOffset(Offset = "0x11A")]
	internal bool? allowIdfaReading;

	[Token(Token = "0x40105DB")]
	[FieldOffset(Offset = "0x11C")]
	internal bool? skAdNetworkHandling;

	[Token(Token = "0x40105DC")]
	[FieldOffset(Offset = "0x11E")]
	internal bool? linkMeEnabled;

	[Token(Token = "0x40105DD")]
	[FieldOffset(Offset = "0x120")]
	internal Action<string> logDelegate;

	[Token(Token = "0x600BF4F")]
	[Address(RVA = "0x595FE0", Offset = "0x5951E0", VA = "0x180595FE0")]
	public AdjustConfig(string appToken, AdjustEnvironment environment)
	{
	}

	[Token(Token = "0x600BF50")]
	[Address(RVA = "0x596080", Offset = "0x595280", VA = "0x180596080")]
	public AdjustConfig(string appToken, AdjustEnvironment environment, bool allowSuppressLogLevel)
	{
	}

	[Token(Token = "0x600BF51")]
	[Address(RVA = "0x596740", Offset = "0x595940", VA = "0x180596740")]
	public void setLogLevel(AdjustLogLevel logLevel)
	{
	}

	[Token(Token = "0x600BF52")]
	[Address(RVA = "0x402FB0", Offset = "0x4021B0", VA = "0x180402FB0")]
	public void setDefaultTracker(string defaultTracker)
	{
	}

	[Token(Token = "0x600BF53")]
	[Address(RVA = "0x4130D0", Offset = "0x4122D0", VA = "0x1804130D0")]
	public void setExternalDeviceId(string externalDeviceId)
	{
	}

	[Token(Token = "0x600BF54")]
	[Address(RVA = "0x5966B0", Offset = "0x5958B0", VA = "0x1805966B0")]
	public void setLaunchDeferredDeeplink(bool launchDeferredDeeplink)
	{
	}

	[Token(Token = "0x600BF55")]
	[Address(RVA = "0x5968E0", Offset = "0x595AE0", VA = "0x1805968E0")]
	public void setSendInBackground(bool sendInBackground)
	{
	}

	[Token(Token = "0x600BF56")]
	[Address(RVA = "0x596570", Offset = "0x595770", VA = "0x180596570")]
	public void setEventBufferingEnabled(bool eventBufferingEnabled)
	{
	}

	[Token(Token = "0x600BF57")]
	[Address(RVA = "0x596470", Offset = "0x595670", VA = "0x180596470")]
	public void setCoppaCompliantEnabled(bool coppaCompliantEnabled)
	{
	}

	[Token(Token = "0x600BF58")]
	[Address(RVA = "0x596800", Offset = "0x595A00", VA = "0x180596800")]
	public void setPlayStoreKidsAppEnabled(bool playStoreKidsAppEnabled)
	{
	}

	[Token(Token = "0x600BF59")]
	[Address(RVA = "0x5967A0", Offset = "0x5959A0", VA = "0x1805967A0")]
	public void setNeedsCost(bool needsCost)
	{
	}

	[Token(Token = "0x600BF5A")]
	[Address(RVA = "0x596510", Offset = "0x595710", VA = "0x180596510")]
	public void setDelayStart(double delayStart)
	{
	}

	[Token(Token = "0x600BF5B")]
	[Address(RVA = "0x3D8380", Offset = "0x3D7580", VA = "0x1803D8380")]
	public void setUserAgent(string userAgent)
	{
	}

	[Token(Token = "0x600BF5C")]
	[Address(RVA = "0x596650", Offset = "0x595850", VA = "0x180596650")]
	public void setIsDeviceKnown(bool isDeviceKnown)
	{
	}

	[Token(Token = "0x600BF5D")]
	[Address(RVA = "0x595520", Offset = "0x594720", VA = "0x180595520")]
	public void setUrlStrategy(string urlStrategy)
	{
	}

	[Token(Token = "0x600BF5E")]
	[Address(RVA = "0x596170", Offset = "0x595370", VA = "0x180596170")]
	public void deactivateSKAdNetworkHandling()
	{
	}

	[Token(Token = "0x600BF5F")]
	[Address(RVA = "0x5966C0", Offset = "0x5958C0", VA = "0x1805966C0")]
	public void setLinkMeEnabled(bool linkMeEnabled)
	{
	}

	[Token(Token = "0x600BF60")]
	[Address(RVA = "0x5964D0", Offset = "0x5956D0", VA = "0x1805964D0")]
	public void setDeferredDeeplinkDelegate(Action<string> deferredDeeplinkDelegate, string sceneName = "Adjust")
	{
	}

	[Token(Token = "0x600BF61")]
	[Address(RVA = "0x49BB10", Offset = "0x49AD10", VA = "0x18049BB10")]
	public Action<string> getDeferredDeeplinkDelegate()
	{
		return null;
	}

	[Token(Token = "0x600BF62")]
	[Address(RVA = "0x5963F0", Offset = "0x5955F0", VA = "0x1805963F0")]
	public void setAttributionChangedDelegate(Action<AdjustAttribution> attributionChangedDelegate, string sceneName = "Adjust")
	{
	}

	[Token(Token = "0x600BF63")]
	[Address(RVA = "0x49BAE0", Offset = "0x49ACE0", VA = "0x18049BAE0")]
	public Action<AdjustAttribution> getAttributionChangedDelegate()
	{
		return null;
	}

	[Token(Token = "0x600BF64")]
	[Address(RVA = "0x596610", Offset = "0x595810", VA = "0x180596610")]
	public void setEventSuccessDelegate(Action<AdjustEventSuccess> eventSuccessDelegate, string sceneName = "Adjust")
	{
	}

	[Token(Token = "0x600BF65")]
	[Address(RVA = "0x49BAD0", Offset = "0x49ACD0", VA = "0x18049BAD0")]
	public Action<AdjustEventSuccess> getEventSuccessDelegate()
	{
		return null;
	}

	[Token(Token = "0x600BF66")]
	[Address(RVA = "0x5965D0", Offset = "0x5957D0", VA = "0x1805965D0")]
	public void setEventFailureDelegate(Action<AdjustEventFailure> eventFailureDelegate, string sceneName = "Adjust")
	{
	}

	[Token(Token = "0x600BF67")]
	[Address(RVA = "0x5857B0", Offset = "0x5849B0", VA = "0x1805857B0")]
	public Action<AdjustEventFailure> getEventFailureDelegate()
	{
		return null;
	}

	[Token(Token = "0x600BF68")]
	[Address(RVA = "0x596980", Offset = "0x595B80", VA = "0x180596980")]
	public void setSessionSuccessDelegate(Action<AdjustSessionSuccess> sessionSuccessDelegate, string sceneName = "Adjust")
	{
	}

	[Token(Token = "0x600BF69")]
	[Address(RVA = "0x5961F0", Offset = "0x5953F0", VA = "0x1805961F0")]
	public Action<AdjustSessionSuccess> getSessionSuccessDelegate()
	{
		return null;
	}

	[Token(Token = "0x600BF6A")]
	[Address(RVA = "0x596940", Offset = "0x595B40", VA = "0x180596940")]
	public void setSessionFailureDelegate(Action<AdjustSessionFailure> sessionFailureDelegate, string sceneName = "Adjust")
	{
	}

	[Token(Token = "0x600BF6B")]
	[Address(RVA = "0x5961E0", Offset = "0x5953E0", VA = "0x1805961E0")]
	public Action<AdjustSessionFailure> getSessionFailureDelegate()
	{
		return null;
	}

	[Token(Token = "0x600BF6C")]
	[Address(RVA = "0x596430", Offset = "0x595630", VA = "0x180596430")]
	public void setConversionValueUpdatedDelegate(Action<int> conversionValueUpdatedDelegate, string sceneName = "Adjust")
	{
	}

	[Token(Token = "0x600BF6D")]
	[Address(RVA = "0x5969C0", Offset = "0x595BC0", VA = "0x1805969C0")]
	public void setSkad4ConversionValueUpdatedDelegate(Action<int, string, bool> skad4ConversionValueUpdatedDelegate, string sceneName = "Adjust")
	{
	}

	[Token(Token = "0x600BF6E")]
	[Address(RVA = "0x5961D0", Offset = "0x5953D0", VA = "0x1805961D0")]
	public Action<int> getConversionValueUpdatedDelegate()
	{
		return null;
	}

	[Token(Token = "0x600BF6F")]
	[Address(RVA = "0x596200", Offset = "0x595400", VA = "0x180596200")]
	public Action<int, string, bool> getSkad4ConversionValueUpdatedDelegate()
	{
		return null;
	}

	[Token(Token = "0x600BF70")]
	[Address(RVA = "0x5962D0", Offset = "0x5954D0", VA = "0x1805962D0")]
	public void setAppSecret(long secretId, long info1, long info2, long info3, long info4)
	{
	}

	[Token(Token = "0x600BF71")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60")]
	[Obsolete("This is an obsolete method. Apple Search Ads attribution with usage of iAd.framework has been sunset by Apple as of February 7th 2023.")]
	public void setAllowiAdInfoReading(bool allowiAdInfoReading)
	{
	}

	[Token(Token = "0x600BF72")]
	[Address(RVA = "0x596210", Offset = "0x595410", VA = "0x180596210")]
	public void setAllowAdServicesInfoReading(bool allowAdServicesInfoReading)
	{
	}

	[Token(Token = "0x600BF73")]
	[Address(RVA = "0x596270", Offset = "0x595470", VA = "0x180596270")]
	public void setAllowIdfaReading(bool allowIdfaReading)
	{
	}

	[Token(Token = "0x600BF74")]
	[Address(RVA = "0x5968C0", Offset = "0x595AC0", VA = "0x1805968C0")]
	public void setProcessName(string processName)
	{
	}

	[Token(Token = "0x600BF75")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60")]
	[Obsolete("This is an obsolete method.")]
	public void setReadMobileEquipmentIdentity(bool readMobileEquipmentIdentity)
	{
	}

	[Token(Token = "0x600BF76")]
	[Address(RVA = "0x596860", Offset = "0x595A60", VA = "0x180596860")]
	public void setPreinstallTrackingEnabled(bool preinstallTrackingEnabled)
	{
	}

	[Token(Token = "0x600BF77")]
	[Address(RVA = "0x3DA7A0", Offset = "0x3D99A0", VA = "0x1803DA7A0")]
	public void setPreinstallFilePath(string preinstallFilePath)
	{
	}

	[Token(Token = "0x600BF78")]
	[Address(RVA = "0x596720", Offset = "0x595920", VA = "0x180596720")]
	public void setLogDelegate(Action<string> logDelegate)
	{
	}
}
