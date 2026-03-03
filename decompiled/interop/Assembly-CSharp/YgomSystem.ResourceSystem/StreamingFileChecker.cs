using Il2CppDummyDll;

namespace YgomSystem.ResourceSystem;

[Token(Token = "0x20002D3")]
public class StreamingFileChecker : LocalFileChecker
{
	[Token(Token = "0x170001BD")]
	protected override Resource.Type TypeAssetBundle
	{
		[Token(Token = "0x6001147")]
		[Address(RVA = "0x4446D0", Offset = "0x4438D0", VA = "0x1804446D0", Slot = "18")]
		get
		{
			return default(Resource.Type);
		}
	}

	[Token(Token = "0x170001BE")]
	protected override Resource.Type TypeBinary
	{
		[Token(Token = "0x6001148")]
		[Address(RVA = "0x443230", Offset = "0x442430", VA = "0x180443230", Slot = "17")]
		get
		{
			return default(Resource.Type);
		}
	}

	[Token(Token = "0x170001BF")]
	protected override Resource.Type TypeLocalFile
	{
		[Token(Token = "0x6001149")]
		[Address(RVA = "0x577DA0", Offset = "0x576FA0", VA = "0x180577DA0", Slot = "16")]
		get
		{
			return default(Resource.Type);
		}
	}

	[Token(Token = "0x600114A")]
	[Address(RVA = "0xE7ABA0", Offset = "0xE79DA0", VA = "0x180E7ABA0", Slot = "14")]
	protected override bool isExistFile(string path)
	{
		return default(bool);
	}

	[Token(Token = "0x600114B")]
	[Address(RVA = "0xE7AB50", Offset = "0xE79D50", VA = "0x180E7AB50", Slot = "15")]
	protected override bool isAssetBundleData(string path)
	{
		return default(bool);
	}

	[Token(Token = "0x600114C")]
	[Address(RVA = "0xE7AAF0", Offset = "0xE79CF0", VA = "0x180E7AAF0", Slot = "20")]
	protected override string GetCheckExistFilePath(string path)
	{
		return null;
	}

	[Token(Token = "0x600114D")]
	[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
	public StreamingFileChecker()
	{
	}
}
