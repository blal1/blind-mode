using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace YgomGame.Utility;

[Token(Token = "0x200090E")]
public class ScriptableObjectManagerUtil
{
	[Token(Token = "0x4008976")]
	[FieldOffset(Offset = "0x0")]
	public static Dictionary<string, ScriptableObject> loadedSettingList;

	[Token(Token = "0x600365C")]
	[Address(RVA = "0x7C7F30", Offset = "0x7C7130", VA = "0x1807C7F30")]
	public static void UnloadAll()
	{
	}

	[Token(Token = "0x600365D")]
	[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
	public ScriptableObjectManagerUtil()
	{
	}
}
