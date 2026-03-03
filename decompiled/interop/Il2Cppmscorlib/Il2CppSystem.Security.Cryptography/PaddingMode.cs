using System;
using Il2CppInterop.Common.Attributes;

namespace Il2CppSystem.Security.Cryptography;

[System.Serializable]
[OriginalName("mscorlib.dll", "System.Security.Cryptography", "PaddingMode")]
public enum PaddingMode
{
	None = 1,
	PKCS7,
	Zeros,
	ANSIX923,
	ISO10126
}
