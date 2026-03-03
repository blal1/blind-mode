using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace YgomGame.Utility;

[Token(Token = "0x2000917")]
public class CommonInstanceCache : MonoBehaviour
{
	[Token(Token = "0x4008994")]
	internal const string k_HelpMapping = "HelpMapping";

	[Token(Token = "0x4008995")]
	[FieldOffset(Offset = "0x0")]
	private static CommonInstanceCache s_Instance;

	[Token(Token = "0x4008996")]
	[FieldOffset(Offset = "0x20")]
	private Dictionary<string, object> m_CacheMap;

	[Token(Token = "0x1700068A")]
	private static CommonInstanceCache instance
	{
		[Token(Token = "0x6003690")]
		[Address(RVA = "0x7B8D00", Offset = "0x7B7F00", VA = "0x1807B8D00")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6003691")]
	public static T GetCache<T>(string key) where T : class
	{
		return null;
	}

	[Token(Token = "0x6003692")]
	[Address(RVA = "0x7B8BF0", Offset = "0x7B7DF0", VA = "0x1807B8BF0")]
	public static object GetCache(string key)
	{
		return null;
	}

	[Token(Token = "0x6003693")]
	[Address(RVA = "0x7B8B80", Offset = "0x7B7D80", VA = "0x1807B8B80")]
	public static void AssignCache(string key, object value)
	{
	}

	[Token(Token = "0x6003694")]
	[Address(RVA = "0x7B8C80", Offset = "0x7B7E80", VA = "0x1807B8C80")]
	public CommonInstanceCache()
	{
	}
}
