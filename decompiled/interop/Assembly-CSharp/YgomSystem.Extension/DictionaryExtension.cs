using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace YgomSystem.Extension;

[Token(Token = "0x2000357")]
public static class DictionaryExtension
{
	[Token(Token = "0x60014D3")]
	public static T GetValue<T>(this Dictionary<string, object> dic, string key, Func<T, bool> predicator)
	{
		return (T)null;
	}

	[Token(Token = "0x60014D4")]
	public static T GetValueOrDefault<T>(this Dictionary<string, object> dic, string key, T defaultValue, Func<T, bool> predicator)
	{
		return (T)null;
	}

	[Token(Token = "0x60014D5")]
	public static T GetValueOrNull<T>(this Dictionary<string, object> dic, string key, Func<T, bool> predicator) where T : class
	{
		return null;
	}

	[Token(Token = "0x60014D6")]
	public static bool TryGetValue<T>(this Dictionary<string, object> dic, string key, out T value, [Optional] T defaultValue)
	{
		return default(bool);
	}

	[Token(Token = "0x60014D7")]
	[Address(RVA = "0x522180", Offset = "0x521380", VA = "0x180522180")]
	public static bool GetBool(this Dictionary<string, object> dic, string key)
	{
		return default(bool);
	}

	[Token(Token = "0x60014D8")]
	[Address(RVA = "0x522010", Offset = "0x521210", VA = "0x180522010")]
	public static bool GetBoolOrDefault(this Dictionary<string, object> dic, string key, bool defaultValue = false)
	{
		return default(bool);
	}

	[Token(Token = "0x60014D9")]
	[Address(RVA = "0x523060", Offset = "0x522260", VA = "0x180523060")]
	public static bool TryGetBool(this Dictionary<string, object> dic, string key, out bool value, bool defaultValue = false)
	{
		return default(bool);
	}

	[Token(Token = "0x60014DA")]
	[Address(RVA = "0x522E90", Offset = "0x522090", VA = "0x180522E90")]
	public static long GetLong(this Dictionary<string, object> dic, string key)
	{
		return default(long);
	}

	[Token(Token = "0x60014DB")]
	[Address(RVA = "0x522D70", Offset = "0x521F70", VA = "0x180522D70")]
	public static long GetLongOrDefault(this Dictionary<string, object> dic, string key, long defaultValue = 0L)
	{
		return default(long);
	}

	[Token(Token = "0x60014DC")]
	[Address(RVA = "0x523240", Offset = "0x522440", VA = "0x180523240")]
	public static bool TryGetLong(this Dictionary<string, object> dic, string key, out long value, long defaultValue = 0L)
	{
		return default(bool);
	}

	[Token(Token = "0x60014DD")]
	[Address(RVA = "0x5229B0", Offset = "0x521BB0", VA = "0x1805229B0")]
	public static int GetInt(this Dictionary<string, object> dic, string key)
	{
		return default(int);
	}

	[Token(Token = "0x60014DE")]
	[Address(RVA = "0x5226F0", Offset = "0x5218F0", VA = "0x1805226F0")]
	public static int GetIntOrDefault(this Dictionary<string, object> dic, string key, int defaultValue = 0)
	{
		return default(int);
	}

	[Token(Token = "0x60014DF")]
	[Address(RVA = "0x523190", Offset = "0x522390", VA = "0x180523190")]
	public static bool TryGetInt(this Dictionary<string, object> dic, string key, out int value, int defaultValue = 0)
	{
		return default(bool);
	}

	[Token(Token = "0x60014E0")]
	[Address(RVA = "0x5226A0", Offset = "0x5218A0", VA = "0x1805226A0")]
	public static float GetFloat(this Dictionary<string, object> dic, string key)
	{
		return default(float);
	}

	[Token(Token = "0x60014E1")]
	[Address(RVA = "0x522580", Offset = "0x521780", VA = "0x180522580")]
	public static float GetFloatOrDefault(this Dictionary<string, object> dic, string key, float defaultValue = 0f)
	{
		return default(float);
	}

	[Token(Token = "0x60014E2")]
	[Address(RVA = "0x523120", Offset = "0x522320", VA = "0x180523120")]
	public static bool TryGetFloat(this Dictionary<string, object> dic, string key, out float value, float defaultValue = 0f)
	{
		return default(bool);
	}

	[Token(Token = "0x60014E3")]
	[Address(RVA = "0x523010", Offset = "0x522210", VA = "0x180523010")]
	public static string GetString(this Dictionary<string, object> dic, string key)
	{
		return null;
	}

	[Token(Token = "0x60014E4")]
	[Address(RVA = "0x522EE0", Offset = "0x5220E0", VA = "0x180522EE0")]
	public static string GetStringOrDefault(this Dictionary<string, object> dic, string key, string defaultValue)
	{
		return null;
	}

	[Token(Token = "0x60014E5")]
	[Address(RVA = "0x522F50", Offset = "0x522150", VA = "0x180522F50")]
	public static string GetStringOrEmpty(this Dictionary<string, object> dic, string key)
	{
		return null;
	}

	[Token(Token = "0x60014E6")]
	[Address(RVA = "0x522FC0", Offset = "0x5221C0", VA = "0x180522FC0")]
	public static string GetStringOrNull(this Dictionary<string, object> dic, string key)
	{
		return null;
	}

	[Token(Token = "0x60014E7")]
	[Address(RVA = "0x5232B0", Offset = "0x5224B0", VA = "0x1805232B0")]
	public static bool TryGetString(this Dictionary<string, object> dic, string key, out string value, [Optional] string defaultValue)
	{
		return default(bool);
	}

	[Token(Token = "0x60014E8")]
	public static T GetEnum<T>(this Dictionary<string, object> dic, string key) where T : Enum
	{
		return (T)null;
	}

	[Token(Token = "0x60014E9")]
	public static T GetEnumOrDefault<T>(this Dictionary<string, object> dic, string key, [Optional] T defaultValue) where T : Enum
	{
		return (T)null;
	}

	[Token(Token = "0x60014EA")]
	public static bool TryGetEnum<T>(this Dictionary<string, object> dic, string key, out T value, [Optional] T defaultValue) where T : Enum
	{
		return default(bool);
	}

	[Token(Token = "0x60014EB")]
	[Address(RVA = "0x522D20", Offset = "0x521F20", VA = "0x180522D20")]
	public static List<object> GetList(this Dictionary<string, object> dic, string key)
	{
		return null;
	}

	[Token(Token = "0x60014EC")]
	[Address(RVA = "0x522C00", Offset = "0x521E00", VA = "0x180522C00")]
	public static List<object> GetListOrEmpty(this Dictionary<string, object> dic, string key)
	{
		return null;
	}

	[Token(Token = "0x60014ED")]
	[Address(RVA = "0x522CD0", Offset = "0x521ED0", VA = "0x180522CD0")]
	public static List<object> GetListOrNull(this Dictionary<string, object> dic, string key)
	{
		return null;
	}

	[Token(Token = "0x60014EE")]
	[Address(RVA = "0x5231D0", Offset = "0x5223D0", VA = "0x1805231D0")]
	public static bool TryGetList(this Dictionary<string, object> dic, string key, out List<object> value)
	{
		return default(bool);
	}

	[Token(Token = "0x60014EF")]
	[Address(RVA = "0x522370", Offset = "0x521570", VA = "0x180522370")]
	public static Dictionary<string, object> GetDic(this Dictionary<string, object> dic, string key)
	{
		return null;
	}

	[Token(Token = "0x60014F0")]
	[Address(RVA = "0x5221D0", Offset = "0x5213D0", VA = "0x1805221D0")]
	public static Dictionary<string, object> GetDicOrEmpty(this Dictionary<string, object> dic, string key)
	{
		return null;
	}

	[Token(Token = "0x60014F1")]
	[Address(RVA = "0x5222D0", Offset = "0x5214D0", VA = "0x1805222D0")]
	public static Dictionary<string, object> GetDicOrNull(this Dictionary<string, object> dic, string key)
	{
		return null;
	}

	[Token(Token = "0x60014F2")]
	[Address(RVA = "0x5230D0", Offset = "0x5222D0", VA = "0x1805230D0")]
	public static bool TryGetDic(this Dictionary<string, object> dic, string key, out Dictionary<string, object> value)
	{
		return default(bool);
	}
}
