using System;
using Il2CppInterop.Common.Attributes;

namespace Il2CppSystem.Security.Cryptography;

[System.Serializable]
[OriginalName("mscorlib.dll", "System.Security.Cryptography", "CipherMode")]
public enum CipherMode
{
	CBC = 1,
	ECB,
	OFB,
	CFB,
	CTS
}
