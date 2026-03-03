using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;

namespace YgomSystem;

[Token(Token = "0x20001D9")]
public static class PersistentSaveData
{
	[Token(Token = "0x4000A2D")]
	public const string SYSTEM_SAVE_PATH = "SteamPersistence.System";

	[Token(Token = "0x4000A2E")]
	public const string APP_SAVE_PATH = "SteamPersistence.App";

	[Token(Token = "0x4000A2F")]
	public const string CACHE_SAVE_PATH = "SteamPersistence.Cache";

	[Token(Token = "0x4000A30")]
	[FieldOffset(Offset = "0x0")]
	public static bool ignoreUpdateEvent;

	[Token(Token = "0x6000B05")]
	[Address(RVA = "0xC10B50", Offset = "0xC0FD50", VA = "0x180C10B50")]
	[Conditional("YGO_DEBUG")]
	private static void LogData(Dictionary<string, object> data, string basePath)
	{
	}

	[Token(Token = "0x6000B06")]
	[Address(RVA = "0xC105D0", Offset = "0xC0F7D0", VA = "0x180C105D0")]
	public static Dictionary<string, object> LoadPersistenceSystem()
	{
		return null;
	}

	[Token(Token = "0x6000B07")]
	[Address(RVA = "0xC10550", Offset = "0xC0F750", VA = "0x180C10550")]
	public static Dictionary<string, object> LoadPersistenceApp()
	{
		return null;
	}

	[Token(Token = "0x6000B08")]
	[Address(RVA = "0xC10590", Offset = "0xC0F790", VA = "0x180C10590")]
	public static Dictionary<string, object> LoadPersistenceCache()
	{
		return null;
	}

	[Token(Token = "0x6000B09")]
	[Address(RVA = "0xC10E80", Offset = "0xC10080", VA = "0x180C10E80")]
	public static void OnUpdatePersistenceSystem(object obj)
	{
	}

	[Token(Token = "0x6000B0A")]
	[Address(RVA = "0xC10CC0", Offset = "0xC0FEC0", VA = "0x180C10CC0")]
	public static void OnUpdatePersistenceApp(object obj)
	{
	}

	[Token(Token = "0x6000B0B")]
	[Address(RVA = "0xC10DA0", Offset = "0xC0FFA0", VA = "0x180C10DA0")]
	public static void OnUpdatePersistenceCache(object obj)
	{
	}

	[Token(Token = "0x6000B0C")]
	[Address(RVA = "0xC110D0", Offset = "0xC102D0", VA = "0x180C110D0")]
	private static void saveToFile(Dictionary<string, object> dic, string savePath)
	{
	}

	[Token(Token = "0x6000B0D")]
	[Address(RVA = "0xC10F60", Offset = "0xC10160", VA = "0x180C10F60")]
	private static Dictionary<string, object> loadFromFile(string savePath)
	{
		return null;
	}
}
