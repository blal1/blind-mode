using System.Collections.Generic;
using Il2CppDummyDll;

namespace YgomSystem.ResourceSystem;

[Token(Token = "0x20002A7")]
public class ResourceExistsBuiltInData
{
	[Token(Token = "0x4000F09")]
	private const string kExistsFileName = "ExistsBuiltInFileList.json";

	[Token(Token = "0x4000F0A")]
	[FieldOffset(Offset = "0x10")]
	private HashSet<string> existsFileList;

	[Token(Token = "0x4000F0B")]
	[FieldOffset(Offset = "0x0")]
	private static ResourceExistsBuiltInData s_instance;

	[Token(Token = "0x6001034")]
	[Address(RVA = "0xE76580", Offset = "0xE75780", VA = "0x180E76580")]
	public static ResourceExistsBuiltInData GetInstance()
	{
		return null;
	}

	[Token(Token = "0x6001035")]
	[Address(RVA = "0xE768B0", Offset = "0xE75AB0", VA = "0x180E768B0")]
	private void Load()
	{
	}

	[Token(Token = "0x6001036")]
	[Address(RVA = "0xE76630", Offset = "0xE75830", VA = "0x180E76630")]
	private void LoadFromFile()
	{
	}

	[Token(Token = "0x6001037")]
	[Address(RVA = "0xE76480", Offset = "0xE75680", VA = "0x180E76480")]
	public static bool Exists(string path)
	{
		return default(bool);
	}

	[Token(Token = "0x6001038")]
	[Address(RVA = "0xE768C0", Offset = "0xE75AC0", VA = "0x180E768C0")]
	public bool exists(string path)
	{
		return default(bool);
	}

	[Token(Token = "0x6001039")]
	[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
	public ResourceExistsBuiltInData()
	{
	}
}
