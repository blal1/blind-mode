using Il2CppDummyDll;

namespace YgomSystem.LocalFileSystem;

[Token(Token = "0x20002FB")]
public class WindowsStorageIO : StandardStorageIO
{
	[Token(Token = "0x60012AB")]
	[Address(RVA = "0x41FFD0", Offset = "0x41F1D0", VA = "0x18041FFD0", Slot = "4")]
	protected override void OnInitialize()
	{
	}

	[Token(Token = "0x60012AC")]
	[Address(RVA = "0x41FE10", Offset = "0x41F010", VA = "0x18041FE10")]
	public string GetHashRootNativePath(Storage storage)
	{
		return null;
	}

	[Token(Token = "0x60012AD")]
	[Address(RVA = "0x41FE50", Offset = "0x41F050", VA = "0x18041FE50")]
	private string GetSteamUserDirectoryName()
	{
		return null;
	}

	[Token(Token = "0x60012AE")]
	[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
	public WindowsStorageIO()
	{
	}
}
