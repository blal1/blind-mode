using Il2CppDummyDll;

namespace YgomSystem.ResourceSystem;

[Token(Token = "0x20002D1")]
public class LocalFileChecker : BaseChecker
{
	[Token(Token = "0x170001BA")]
	protected virtual Resource.Type TypeLocalFile
	{
		[Token(Token = "0x600113C")]
		[Address(RVA = "0x549EC0", Offset = "0x5490C0", VA = "0x180549EC0", Slot = "16")]
		get
		{
			return default(Resource.Type);
		}
	}

	[Token(Token = "0x170001BB")]
	protected virtual Resource.Type TypeBinary
	{
		[Token(Token = "0x600113D")]
		[Address(RVA = "0x4465B0", Offset = "0x4457B0", VA = "0x1804465B0", Slot = "17")]
		get
		{
			return default(Resource.Type);
		}
	}

	[Token(Token = "0x170001BC")]
	protected virtual Resource.Type TypeAssetBundle
	{
		[Token(Token = "0x600113E")]
		[Address(RVA = "0x44E380", Offset = "0x44D580", VA = "0x18044E380", Slot = "18")]
		get
		{
			return default(Resource.Type);
		}
	}

	[Token(Token = "0x6001138")]
	[Address(RVA = "0xE6FA10", Offset = "0xE6EC10", VA = "0x180E6FA10", Slot = "9")]
	public override ResTypeData GetResType(string path)
	{
		return null;
	}

	[Token(Token = "0x6001139")]
	[Address(RVA = "0xE6F9F0", Offset = "0xE6EBF0", VA = "0x180E6F9F0", Slot = "10")]
	public override ResTypeData GetResTypeSimpleCheck(string path)
	{
		return null;
	}

	[Token(Token = "0x600113A")]
	[Address(RVA = "0xE6FA80", Offset = "0xE6EC80", VA = "0x180E6FA80", Slot = "14")]
	protected virtual bool isExistFile(string path)
	{
		return default(bool);
	}

	[Token(Token = "0x600113B")]
	[Address(RVA = "0xE6FA30", Offset = "0xE6EC30", VA = "0x180E6FA30", Slot = "15")]
	protected virtual bool isAssetBundleData(string path)
	{
		return default(bool);
	}

	[Token(Token = "0x600113F")]
	[Address(RVA = "0xE6F7C0", Offset = "0xE6E9C0", VA = "0x180E6F7C0", Slot = "19")]
	protected virtual ResTypeData GetResTypeCheckType(string path, bool checkType)
	{
		return null;
	}

	[Token(Token = "0x6001140")]
	[Address(RVA = "0xE6F5C0", Offset = "0xE6E7C0", VA = "0x180E6F5C0")]
	private string GetLocalFilePath(string path)
	{
		return null;
	}

	[Token(Token = "0x6001141")]
	[Address(RVA = "0xE6F530", Offset = "0xE6E730", VA = "0x180E6F530", Slot = "13")]
	public override void ClearCache()
	{
	}

	[Token(Token = "0x6001142")]
	[Address(RVA = "0xE6F540", Offset = "0xE6E740", VA = "0x180E6F540", Slot = "20")]
	protected virtual string GetCheckExistFilePath(string path)
	{
		return null;
	}

	[Token(Token = "0x6001143")]
	[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
	public LocalFileChecker()
	{
	}
}
