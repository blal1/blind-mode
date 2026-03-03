using Il2CppInterop.Common.Attributes;

namespace Il2CppSystem.Net;

[OriginalName("System.dll", "System.Net", "WebHeaderCollectionType")]
public enum WebHeaderCollectionType : ushort
{
	Unknown,
	WebRequest,
	WebResponse,
	HttpWebRequest,
	HttpWebResponse,
	HttpListenerRequest,
	HttpListenerResponse,
	FtpWebRequest,
	FtpWebResponse,
	FileWebRequest,
	FileWebResponse
}
