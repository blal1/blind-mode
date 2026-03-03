using Il2CppInterop.Common.Attributes;

namespace Il2CppSystem.Security.Cryptography;

[OriginalName("System.dll", "System.Security.Cryptography", "AsnDecodeStatus")]
public enum AsnDecodeStatus
{
	NotDecoded = -1,
	Ok,
	BadAsn,
	BadTag,
	BadLength,
	InformationNotAvailable
}
