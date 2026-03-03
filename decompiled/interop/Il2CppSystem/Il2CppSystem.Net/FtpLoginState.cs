using Il2CppInterop.Common.Attributes;

namespace Il2CppSystem.Net;

[OriginalName("System.dll", "System.Net", "FtpLoginState")]
public enum FtpLoginState : byte
{
	NotLoggedIn,
	LoggedIn,
	LoggedInButNeedsRelogin,
	ReloginFailed
}
