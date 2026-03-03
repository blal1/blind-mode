using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using Il2CppDummyDll;
using UnityEngine;

namespace YgomSystem.Utility;

[Token(Token = "0x20003DD")]
public static class JsonPath
{
	[Token(Token = "0x4001373")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static Regex makupRegex;

	[Token(Token = "0x4001374")]
	private const string onetab = "\t";

	[Token(Token = "0x4001375")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private static char[] strescape;

	[Token(Token = "0x4001376")]
	private const string yamltab = "  ";

	[Token(Token = "0x60018CE")]
	[Address(RVA = "0x5CDAB0", Offset = "0x5CCCB0", VA = "0x1805CDAB0")]
	private static string procForm(string jsonPath, object scan)
	{
		return null;
	}

	[Token(Token = "0x60018CF")]
	[Address(RVA = "0x5CD880", Offset = "0x5CCA80", VA = "0x1805CD880")]
	public static List<string> parth(string jsonPath, object scan)
	{
		return null;
	}

	[Token(Token = "0x60018D0")]
	[Address(RVA = "0x5C8D00", Offset = "0x5C7F00", VA = "0x1805C8D00")]
	public static object get(object scan, string jsonPath, out object lastparent, out string lastkey)
	{
		return null;
	}

	[Token(Token = "0x60018D1")]
	[Address(RVA = "0x5C8B00", Offset = "0x5C7D00", VA = "0x1805C8B00")]
	public static object get(object scan, string jsonPath)
	{
		return null;
	}

	[Token(Token = "0x60018D2")]
	[Address(RVA = "0x5CDC80", Offset = "0x5CCE80", VA = "0x1805CDC80")]
	public static bool set(object dst, string jsonPath, object value)
	{
		return default(bool);
	}

	[Token(Token = "0x60018D3")]
	[Address(RVA = "0x5C7D80", Offset = "0x5C6F80", VA = "0x1805C7D80")]
	public static bool contains(object scan, string jsonPath)
	{
		return default(bool);
	}

	[Token(Token = "0x60018D4")]
	[Address(RVA = "0x5C8380", Offset = "0x5C7580", VA = "0x1805C8380")]
	public static bool getBool(object scan, string jsonPath, bool defaultValue = false)
	{
		return default(bool);
	}

	[Token(Token = "0x60018D5")]
	[Address(RVA = "0x5C85B0", Offset = "0x5C77B0", VA = "0x1805C85B0")]
	public static int getInt(object scan, string jsonPath, int defaultValue = 0)
	{
		return default(int);
	}

	[Token(Token = "0x60018D6")]
	[Address(RVA = "0x5C86B0", Offset = "0x5C78B0", VA = "0x1805C86B0")]
	public static long getLong(object scan, string jsonPath, long defaultValue = 0L)
	{
		return default(long);
	}

	[Token(Token = "0x60018D7")]
	[Address(RVA = "0x5C8530", Offset = "0x5C7730", VA = "0x1805C8530")]
	public static float getFloat(object scan, string jsonPath, float defaultValue = 0f)
	{
		return default(float);
	}

	[Token(Token = "0x60018D8")]
	[Address(RVA = "0x5C88B0", Offset = "0x5C7AB0", VA = "0x1805C88B0")]
	public static string getString(object scan, string jsonPath, string defaultValue = "")
	{
		return null;
	}

	[Token(Token = "0x60018D9")]
	public static T getEnum<T>(object scan, string jsonPath, T defaultValue)
	{
		return (T)null;
	}

	[Token(Token = "0x60018DA")]
	[Address(RVA = "0x5C84B0", Offset = "0x5C76B0", VA = "0x1805C84B0")]
	public static Dictionary<string, object> getDictionary(object scan, string jsonPath, [Optional] Dictionary<string, object> defaultValue)
	{
		return null;
	}

	[Token(Token = "0x60018DB")]
	[Address(RVA = "0x5C8630", Offset = "0x5C7830", VA = "0x1805C8630")]
	public static List<object> getList(object scan, string jsonPath, [Optional] List<object> defaultValue)
	{
		return null;
	}

	[Token(Token = "0x60018DC")]
	[Address(RVA = "0x5C8930", Offset = "0x5C7B30", VA = "0x1805C8930")]
	public static Vector2 getVector2(object scan, string jsonPath, Vector2 defalutValie)
	{
		return default(Vector2);
	}

	[Token(Token = "0x60018DD")]
	[Address(RVA = "0x5C89B0", Offset = "0x5C7BB0", VA = "0x1805C89B0")]
	public static Vector3 getVector3(object scan, string jsonPath, Vector3 defalutValie)
	{
		return default(Vector3);
	}

	[Token(Token = "0x60018DE")]
	[Address(RVA = "0x5C8A60", Offset = "0x5C7C60", VA = "0x1805C8A60")]
	public static Vector4 getVector4(object scan, string jsonPath, Vector4 defalutValie)
	{
		return default(Vector4);
	}

	[Token(Token = "0x60018DF")]
	internal static T getTyped<T>(object scan, string jsonPath, T defaultValue)
	{
		return (T)null;
	}

	[Token(Token = "0x60018E0")]
	[Address(RVA = "0x5CA010", Offset = "0x5C9210", VA = "0x1805CA010")]
	public static bool objectToBool(object i, bool defaultValue = false)
	{
		return default(bool);
	}

	[Token(Token = "0x60018E1")]
	[Address(RVA = "0x5CA3F0", Offset = "0x5C95F0", VA = "0x1805CA3F0")]
	public static float objectToFloat(object i, float defaultValue = 0f)
	{
		return default(float);
	}

	[Token(Token = "0x60018E2")]
	[Address(RVA = "0x5CBBA0", Offset = "0x5CADA0", VA = "0x1805CBBA0")]
	public static int objectToInt(object i, int detaultValue = 0)
	{
		return default(int);
	}

	[Token(Token = "0x60018E3")]
	[Address(RVA = "0x5CC840", Offset = "0x5CBA40", VA = "0x1805CC840")]
	public static string objectToString(object i, [Optional] string detaultValue)
	{
		return null;
	}

	[Token(Token = "0x60018E4")]
	[Address(RVA = "0x5CC230", Offset = "0x5CB430", VA = "0x1805CC230")]
	public static long objectToLong(object i, long defaultValue = 0L)
	{
		return default(long);
	}

	[Token(Token = "0x60018E5")]
	[Address(RVA = "0x5CC870", Offset = "0x5CBA70", VA = "0x1805CC870")]
	public static Vector2 objectToVector2(object scan, Vector2 defalutValie)
	{
		return default(Vector2);
	}

	[Token(Token = "0x60018E6")]
	[Address(RVA = "0x5CCA50", Offset = "0x5CBC50", VA = "0x1805CCA50")]
	public static Vector3 objectToVector3(object scan, Vector3 defalutValie)
	{
		return default(Vector3);
	}

	[Token(Token = "0x60018E7")]
	[Address(RVA = "0x5CCC60", Offset = "0x5CBE60", VA = "0x1805CCC60")]
	public static Vector4 objectToVector4(object scan, Vector4 defalutValie)
	{
		return default(Vector4);
	}

	[Token(Token = "0x60018E8")]
	[Address(RVA = "0x5CA0F0", Offset = "0x5C92F0", VA = "0x1805CA0F0")]
	public static Color objectToColor(object c, Color degalutValue)
	{
		return default(Color);
	}

	[Token(Token = "0x60018E9")]
	[Address(RVA = "0x5CC3A0", Offset = "0x5CB5A0", VA = "0x1805CC3A0")]
	public static List<string> objectToStringList(object obj)
	{
		return null;
	}

	[Token(Token = "0x60018EA")]
	[Address(RVA = "0x5C8FC0", Offset = "0x5C81C0", VA = "0x1805C8FC0")]
	private static string jsonString(string str)
	{
		return null;
	}

	[Token(Token = "0x60018EB")]
	[Address(RVA = "0x5CBCF0", Offset = "0x5CAEF0", VA = "0x1805CBCF0")]
	public static string objectToJson(object obj)
	{
		return null;
	}

	[Token(Token = "0x60018EC")]
	[Address(RVA = "0x5CB080", Offset = "0x5CA280", VA = "0x1805CB080")]
	public static string objectToFormatJson(object obj, int tabdepth = 0)
	{
		return null;
	}

	[Token(Token = "0x60018ED")]
	[Address(RVA = "0x5CA590", Offset = "0x5C9790", VA = "0x1805CA590")]
	public static string objectToFormatJsonFistComma(object obj, int tabdepth = 0)
	{
		return null;
	}

	[Token(Token = "0x60018EE")]
	[Address(RVA = "0x5CCE60", Offset = "0x5CC060", VA = "0x1805CCE60")]
	public static string objectToYaml(object obj, int tabdepth = 0)
	{
		return null;
	}

	[Token(Token = "0x60018EF")]
	[Address(RVA = "0x5C7F80", Offset = "0x5C7180", VA = "0x1805C7F80")]
	public static object copyObject(object src)
	{
		return null;
	}

	[Token(Token = "0x60018F0")]
	[Address(RVA = "0x5C9ED0", Offset = "0x5C90D0", VA = "0x1805C9ED0")]
	public static void margeList(List<object> dst, List<object> src)
	{
	}

	[Token(Token = "0x60018F1")]
	[Address(RVA = "0x5C99A0", Offset = "0x5C8BA0", VA = "0x1805C99A0")]
	public static void margeDictionary(Dictionary<string, object> dst, Dictionary<string, object> src)
	{
	}

	[Token(Token = "0x60018F2")]
	[Address(RVA = "0x5C9110", Offset = "0x5C8310", VA = "0x1805C9110")]
	public static void margeDictionaryWithAlias(Dictionary<string, object> dst, Dictionary<string, object> src, Dictionary<string, object> alias)
	{
	}

	[Token(Token = "0x60018F3")]
	[Address(RVA = "0x5C8F40", Offset = "0x5C8140", VA = "0x1805C8F40")]
	public static Dictionary<string, object> joinDictionary(Dictionary<string, object> dic1, Dictionary<string, object> dic2)
	{
		return null;
	}
}
