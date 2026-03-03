using System.Collections.Generic;
using Il2CppDummyDll;

namespace YgomSystem.ResourceSystem;

[Token(Token = "0x20002A9")]
public class ResourceExistsConvertData
{
	[Token(Token = "0x4000F0E")]
	private const string kExistsFileName = "ExistsFileList.json";

	[Token(Token = "0x4000F0F")]
	[FieldOffset(Offset = "0x10")]
	private HashSet<string> existsFileList;

	[Token(Token = "0x600103D")]
	[Address(RVA = "0xE76C60", Offset = "0xE75E60", VA = "0x180E76C60")]
	public void Load()
	{
	}

	[Token(Token = "0x600103E")]
	[Address(RVA = "0xE76980", Offset = "0xE75B80", VA = "0x180E76980")]
	public bool Exists(string path)
	{
		return default(bool);
	}

	[Token(Token = "0x600103F")]
	[Address(RVA = "0xE76920", Offset = "0xE75B20", VA = "0x180E76920")]
	public void Clear()
	{
	}

	[Token(Token = "0x6001040")]
	[Address(RVA = "0xE769E0", Offset = "0xE75BE0", VA = "0x180E769E0")]
	private void LoadFromFile()
	{
	}

	[Token(Token = "0x6001041")]
	[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
	public ResourceExistsConvertData()
	{
	}
}
