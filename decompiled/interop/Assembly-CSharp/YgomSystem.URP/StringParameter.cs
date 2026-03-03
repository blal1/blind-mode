using System;
using Il2CppDummyDll;
using UnityEngine.Rendering;

namespace YgomSystem.URP;

[Serializable]
[Token(Token = "0x200031A")]
public class StringParameter : VolumeParameter<string>
{
	[Token(Token = "0x6001363")]
	[Address(RVA = "0x417E60", Offset = "0x417060", VA = "0x180417E60")]
	public StringParameter()
	{
	}

	[Token(Token = "0x6001364")]
	[Address(RVA = "0x417EA0", Offset = "0x4170A0", VA = "0x180417EA0")]
	public StringParameter(string value, bool overrideState = false)
	{
	}
}
