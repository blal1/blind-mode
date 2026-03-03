using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace YgomSystem.Utility;

[Token(Token = "0x20003CE")]
public class DontDestroyObject : MonoBehaviour
{
	[Token(Token = "0x400132E")]
	[FieldOffset(Offset = "0x0")]
	private static Dictionary<string, GameObject> path2obj;

	[Token(Token = "0x6001868")]
	[Address(RVA = "0x5BCF60", Offset = "0x5BC160", VA = "0x1805BCF60")]
	private string GetObjectPath(Transform objtrns)
	{
		return null;
	}

	[Token(Token = "0x6001869")]
	[Address(RVA = "0x5BCD10", Offset = "0x5BBF10", VA = "0x1805BCD10")]
	private void Awake()
	{
	}

	[Token(Token = "0x600186A")]
	[Address(RVA = "0x3D2BD0", Offset = "0x3D1DD0", VA = "0x1803D2BD0")]
	public DontDestroyObject()
	{
	}
}
