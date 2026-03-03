using Il2CppInterop.Common.Attributes;

namespace Il2CppSystem.Security.Cryptography.X509Certificates;

[OriginalName("mscorlib.dll", "System.Security.Cryptography.X509Certificates", "X509ContentType")]
public enum X509ContentType
{
	Unknown = 0,
	Cert = 1,
	SerializedCert = 2,
	Pfx = 3,
	Pkcs12 = 3,
	SerializedStore = 4,
	Pkcs7 = 5,
	Authenticode = 6
}
