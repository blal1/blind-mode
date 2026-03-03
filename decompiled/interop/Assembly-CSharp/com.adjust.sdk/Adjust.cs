using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace com.adjust.sdk;

[Token(Token = "0x2001DD6")]
public class Adjust : MonoBehaviour
{
	[Token(Token = "0x4010570")]
	private const string errorMsgEditor = "[Adjust]: SDK can not be used in Editor.";

	[Token(Token = "0x4010571")]
	private const string errorMsgStart = "[Adjust]: SDK not started. Start it manually using the 'start' method.";

	[Token(Token = "0x4010572")]
	private const string errorMsgPlatform = "[Adjust]: SDK can only be used in Android, iOS, Windows Phone 8.1, Windows Store or Universal Windows apps.";

	[Token(Token = "0x4010573")]
	[FieldOffset(Offset = "0x20")]
	[HideInInspector]
	public bool startManually;

	[Token(Token = "0x4010574")]
	[FieldOffset(Offset = "0x28")]
	[HideInInspector]
	public string appToken;

	[Token(Token = "0x4010575")]
	[FieldOffset(Offset = "0x30")]
	[HideInInspector]
	public AdjustEnvironment environment;

	[Token(Token = "0x4010576")]
	[FieldOffset(Offset = "0x34")]
	[HideInInspector]
	public AdjustLogLevel logLevel;

	[Token(Token = "0x4010577")]
	[FieldOffset(Offset = "0x38")]
	[HideInInspector]
	public bool eventBuffering;

	[Token(Token = "0x4010578")]
	[FieldOffset(Offset = "0x39")]
	[HideInInspector]
	public bool sendInBackground;

	[Token(Token = "0x4010579")]
	[FieldOffset(Offset = "0x3A")]
	[HideInInspector]
	public bool launchDeferredDeeplink;

	[Token(Token = "0x401057A")]
	[FieldOffset(Offset = "0x3B")]
	[HideInInspector]
	public bool needsCost;

	[Token(Token = "0x401057B")]
	[FieldOffset(Offset = "0x3C")]
	[HideInInspector]
	public bool coppaCompliant;

	[Token(Token = "0x401057C")]
	[FieldOffset(Offset = "0x3D")]
	[HideInInspector]
	public bool linkMe;

	[Token(Token = "0x401057D")]
	[FieldOffset(Offset = "0x40")]
	[HideInInspector]
	public string defaultTracker;

	[Token(Token = "0x401057E")]
	[FieldOffset(Offset = "0x48")]
	[HideInInspector]
	public AdjustUrlStrategy urlStrategy;

	[Token(Token = "0x401057F")]
	[FieldOffset(Offset = "0x50")]
	[HideInInspector]
	public double startDelay;

	[Token(Token = "0x4010580")]
	[FieldOffset(Offset = "0x58")]
	[HideInInspector]
	public long secretId;

	[Token(Token = "0x4010581")]
	[FieldOffset(Offset = "0x60")]
	[HideInInspector]
	public long info1;

	[Token(Token = "0x4010582")]
	[FieldOffset(Offset = "0x68")]
	[HideInInspector]
	public long info2;

	[Token(Token = "0x4010583")]
	[FieldOffset(Offset = "0x70")]
	[HideInInspector]
	public long info3;

	[Token(Token = "0x4010584")]
	[FieldOffset(Offset = "0x78")]
	[HideInInspector]
	public long info4;

	[Token(Token = "0x4010585")]
	[FieldOffset(Offset = "0x80")]
	[HideInInspector]
	public bool preinstallTracking;

	[Token(Token = "0x4010586")]
	[FieldOffset(Offset = "0x88")]
	[HideInInspector]
	public string preinstallFilePath;

	[Token(Token = "0x4010587")]
	[FieldOffset(Offset = "0x90")]
	[HideInInspector]
	public bool playStoreKidsApp;

	[Token(Token = "0x4010588")]
	[FieldOffset(Offset = "0x91")]
	[HideInInspector]
	public bool adServicesInfoReading;

	[Token(Token = "0x4010589")]
	[FieldOffset(Offset = "0x92")]
	[HideInInspector]
	public bool idfaInfoReading;

	[Token(Token = "0x401058A")]
	[FieldOffset(Offset = "0x93")]
	[HideInInspector]
	public bool skAdNetworkHandling;

	[Token(Token = "0x600BEFD")]
	[Address(RVA = "0x59ABF0", Offset = "0x599DF0", VA = "0x18059ABF0")]
	private void Awake()
	{
	}

	[Token(Token = "0x600BEFE")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60")]
	private void OnApplicationPause(bool pauseStatus)
	{
	}

	[Token(Token = "0x600BEFF")]
	[Address(RVA = "0x3D5200", Offset = "0x3D4400", VA = "0x1803D5200")]
	public static void start(AdjustConfig adjustConfig)
	{
	}

	[Token(Token = "0x600BF00")]
	[Address(RVA = "0x3D5200", Offset = "0x3D4400", VA = "0x1803D5200")]
	public static void trackEvent(AdjustEvent adjustEvent)
	{
	}

	[Token(Token = "0x600BF01")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60")]
	public static void setEnabled(bool enabled)
	{
	}

	[Token(Token = "0x600BF02")]
	[Address(RVA = "0x3C7A70", Offset = "0x3C6C70", VA = "0x1803C7A70")]
	public static bool isEnabled()
	{
		return default(bool);
	}

	[Token(Token = "0x600BF03")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60")]
	public static void setOfflineMode(bool enabled)
	{
	}

	[Token(Token = "0x600BF04")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60")]
	public static void setDeviceToken(string deviceToken)
	{
	}

	[Token(Token = "0x600BF05")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60")]
	public static void gdprForgetMe()
	{
	}

	[Token(Token = "0x600BF06")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60")]
	public static void disableThirdPartySharing()
	{
	}

	[Token(Token = "0x600BF07")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60")]
	public static void appWillOpenUrl(string url)
	{
	}

	[Token(Token = "0x600BF08")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60")]
	public static void sendFirstPackages()
	{
	}

	[Token(Token = "0x600BF09")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60")]
	public static void addSessionPartnerParameter(string key, string value)
	{
	}

	[Token(Token = "0x600BF0A")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60")]
	public static void addSessionCallbackParameter(string key, string value)
	{
	}

	[Token(Token = "0x600BF0B")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60")]
	public static void removeSessionPartnerParameter(string key)
	{
	}

	[Token(Token = "0x600BF0C")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60")]
	public static void removeSessionCallbackParameter(string key)
	{
	}

	[Token(Token = "0x600BF0D")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60")]
	public static void resetSessionPartnerParameters()
	{
	}

	[Token(Token = "0x600BF0E")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60")]
	public static void resetSessionCallbackParameters()
	{
	}

	[Token(Token = "0x600BF0F")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60")]
	public static void trackAdRevenue(string source, string payload)
	{
	}

	[Token(Token = "0x600BF10")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60")]
	public static void trackAdRevenue(AdjustAdRevenue adRevenue)
	{
	}

	[Token(Token = "0x600BF11")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60")]
	public static void trackAppStoreSubscription(AdjustAppStoreSubscription subscription)
	{
	}

	[Token(Token = "0x600BF12")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60")]
	public static void trackPlayStoreSubscription(AdjustPlayStoreSubscription subscription)
	{
	}

	[Token(Token = "0x600BF13")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60")]
	public static void trackThirdPartySharing(AdjustThirdPartySharing thirdPartySharing)
	{
	}

	[Token(Token = "0x600BF14")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60")]
	public static void trackMeasurementConsent(bool measurementConsent)
	{
	}

	[Token(Token = "0x600BF15")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60")]
	public static void requestTrackingAuthorizationWithCompletionHandler(Action<int> statusCallback, string sceneName = "Adjust")
	{
	}

	[Token(Token = "0x600BF16")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60")]
	public static void updateConversionValue(int conversionValue)
	{
	}

	[Token(Token = "0x600BF17")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60")]
	public static void updateConversionValue(int conversionValue, Action<string> completionCallback, string sceneName = "Adjust")
	{
	}

	[Token(Token = "0x600BF18")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60")]
	public static void updateConversionValue(int conversionValue, string coarseValue, bool lockWindow, Action<string> completionCallback, string sceneName = "Adjust")
	{
	}

	[Token(Token = "0x600BF19")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60")]
	public static void checkForNewAttStatus()
	{
	}

	[Token(Token = "0x600BF1A")]
	[Address(RVA = "0x4C9EF0", Offset = "0x4C90F0", VA = "0x1804C9EF0")]
	public static int getAppTrackingAuthorizationStatus()
	{
		return default(int);
	}

	[Token(Token = "0x600BF1B")]
	[Address(RVA = "0x4C7DC0", Offset = "0x4C6FC0", VA = "0x1804C7DC0")]
	public static string getAdid()
	{
		return null;
	}

	[Token(Token = "0x600BF1C")]
	[Address(RVA = "0x3EF020", Offset = "0x3EE220", VA = "0x1803EF020")]
	public static AdjustAttribution getAttribution()
	{
		return null;
	}

	[Token(Token = "0x600BF1D")]
	[Address(RVA = "0x4C7DC0", Offset = "0x4C6FC0", VA = "0x1804C7DC0")]
	public static string getWinAdid()
	{
		return null;
	}

	[Token(Token = "0x600BF1E")]
	[Address(RVA = "0x4C7DC0", Offset = "0x4C6FC0", VA = "0x1804C7DC0")]
	public static string getIdfa()
	{
		return null;
	}

	[Token(Token = "0x600BF1F")]
	[Address(RVA = "0x4C7DC0", Offset = "0x4C6FC0", VA = "0x1804C7DC0")]
	public static string getSdkVersion()
	{
		return null;
	}

	[Token(Token = "0x600BF20")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60")]
	[Obsolete("This method is intended for testing purposes only. Do not use it.")]
	public static void setReferrer(string referrer)
	{
	}

	[Token(Token = "0x600BF21")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60")]
	public static void getGoogleAdId(Action<string> onDeviceIdsRead)
	{
	}

	[Token(Token = "0x600BF22")]
	[Address(RVA = "0x4C7DC0", Offset = "0x4C6FC0", VA = "0x1804C7DC0")]
	public static string getAmazonAdId()
	{
		return null;
	}

	[Token(Token = "0x600BF23")]
	[Address(RVA = "0x4C7DC0", Offset = "0x4C6FC0", VA = "0x1804C7DC0")]
	public static string getLastDeeplink()
	{
		return null;
	}

	[Token(Token = "0x600BF24")]
	[Address(RVA = "0x3C7A70", Offset = "0x3C6C70", VA = "0x1803C7A70")]
	private static bool IsEditor()
	{
		return default(bool);
	}

	[Token(Token = "0x600BF25")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60")]
	public static void SetTestOptions(Dictionary<string, string> testOptions)
	{
	}

	[Token(Token = "0x600BF26")]
	[Address(RVA = "0x59B2C0", Offset = "0x59A4C0", VA = "0x18059B2C0")]
	public Adjust()
	{
	}
}
