using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace YgomSystem.LocalFileSystem.Internal;

[Token(Token = "0x20002FC")]
public static class Helper
{
	[Token(Token = "0x4001020")]
	[FieldOffset(Offset = "0x0")]
	private static readonly StorageData[] s_storageDescriptions;

	[Token(Token = "0x4001021")]
	[FieldOffset(Offset = "0x8")]
	private static Dictionary<int, StorageData> s_storages;

	[Token(Token = "0x170001DE")]
	public static LocalFileManager manager
	{
		[Token(Token = "0x60012B1")]
		[Address(RVA = "0x408FE0", Offset = "0x4081E0", VA = "0x180408FE0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x60012B2")]
		[Address(RVA = "0x409080", Offset = "0x408280", VA = "0x180409080")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x170001DF")]
	public static StorageIO storageIO
	{
		[Token(Token = "0x60012B3")]
		[Address(RVA = "0x409030", Offset = "0x408230", VA = "0x180409030")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x60012B4")]
		[Address(RVA = "0x4090F0", Offset = "0x4082F0", VA = "0x1804090F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x60012AF")]
	[Address(RVA = "0x408280", Offset = "0x407480", VA = "0x180408280")]
	public static void Initialize(string env, LocalFileManager managerInstance, bool enableLog)
	{
	}

	[Token(Token = "0x60012B0")]
	[Address(RVA = "0x407B70", Offset = "0x406D70", VA = "0x180407B70")]
	public static void Cleanup()
	{
	}

	[Token(Token = "0x60012B5")]
	public static T GetStorageIO<T>() where T : StorageIO
	{
		return null;
	}

	[Token(Token = "0x60012B6")]
	[Address(RVA = "0x408E70", Offset = "0x408070", VA = "0x180408E70")]
	private static StorageIO createStorageIO()
	{
		return null;
	}

	[Token(Token = "0x60012B7")]
	[Address(RVA = "0x407CD0", Offset = "0x406ED0", VA = "0x180407CD0")]
	public static Stream CreateIOStream(string nativePath, StreamOpenMode openMode, FileLocation location)
	{
		return null;
	}

	[Token(Token = "0x60012B8")]
	[Address(RVA = "0x408EC0", Offset = "0x4080C0", VA = "0x180408EC0")]
	private static FileStream createSystemIOFileStream(string nativePath, StreamOpenMode openMode)
	{
		return null;
	}

	[Token(Token = "0x60012B9")]
	[Address(RVA = "0x407E20", Offset = "0x407020", VA = "0x180407E20")]
	public static string GetNativePath(Storage storage, string name, FileNameType nameType)
	{
		return null;
	}

	[Token(Token = "0x60012BA")]
	[Address(RVA = "0x408560", Offset = "0x407760", VA = "0x180408560")]
	public static string LocationToNativePath(FileLocation location)
	{
		return null;
	}

	[Token(Token = "0x60012BB")]
	[Address(RVA = "0x4080D0", Offset = "0x4072D0", VA = "0x1804080D0")]
	public static StorageData GetStorageData(Storage storage)
	{
		return null;
	}

	[Token(Token = "0x60012BC")]
	[Address(RVA = "0x408150", Offset = "0x407350", VA = "0x180408150")]
	public static string GetStorageName(Storage storage)
	{
		return null;
	}

	[Token(Token = "0x60012BD")]
	[Address(RVA = "0x408630", Offset = "0x407830", VA = "0x180408630")]
	public static Storage NameToStorage(string name, bool ignoreCase)
	{
		return default(Storage);
	}

	[Token(Token = "0x60012BE")]
	[Address(RVA = "0x4085E0", Offset = "0x4077E0", VA = "0x1804085E0")]
	public static Storage NameToStorage(string name)
	{
		return default(Storage);
	}

	[Token(Token = "0x60012BF")]
	[Address(RVA = "0x4081E0", Offset = "0x4073E0", VA = "0x1804081E0")]
	public static string HashFileName(string name)
	{
		return null;
	}

	[Token(Token = "0x60012C0")]
	[Address(RVA = "0x408980", Offset = "0x407B80", VA = "0x180408980")]
	public static string[] SplitHash(string hash)
	{
		return null;
	}
}
