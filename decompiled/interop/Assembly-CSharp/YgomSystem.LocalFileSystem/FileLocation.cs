using Il2CppDummyDll;

namespace YgomSystem.LocalFileSystem;

[Token(Token = "0x20002DE")]
public struct FileLocation
{
	[Token(Token = "0x4000FBD")]
	[FieldOffset(Offset = "0x0")]
	public Storage storage;

	[Token(Token = "0x4000FBE")]
	[FieldOffset(Offset = "0x8")]
	public string name;

	[Token(Token = "0x4000FBF")]
	[FieldOffset(Offset = "0x10")]
	public FileNameType nameType;

	[Token(Token = "0x4000FC0")]
	[FieldOffset(Offset = "0x0")]
	private static readonly string s_locationDelimiter;

	[Token(Token = "0x4000FC1")]
	[FieldOffset(Offset = "0x8")]
	private static string[] s_locationSeparators;

	[Token(Token = "0x4000FC2")]
	[FieldOffset(Offset = "0x10")]
	public static FileLocation nullLocation;

	[Token(Token = "0x170001D0")]
	public bool isNull
	{
		[Token(Token = "0x600117D")]
		[Address(RVA = "0x407B60", Offset = "0x406D60", VA = "0x180407B60")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x600117A")]
	[Address(RVA = "0x407B30", Offset = "0x406D30", VA = "0x180407B30")]
	public FileLocation(Storage storage, string name, FileNameType nameType)
	{
	}

	[Token(Token = "0x600117B")]
	[Address(RVA = "0x407AB0", Offset = "0x406CB0", VA = "0x180407AB0")]
	public FileLocation(string str)
	{
	}

	[Token(Token = "0x600117C")]
	[Address(RVA = "0x407950", Offset = "0x406B50", VA = "0x180407950", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x600117E")]
	[Address(RVA = "0x407240", Offset = "0x406440", VA = "0x180407240")]
	public static string GetLocationString(Storage storage, string name, FileNameType nameType)
	{
		return null;
	}

	[Token(Token = "0x600117F")]
	[Address(RVA = "0x4075B0", Offset = "0x4067B0", VA = "0x1804075B0")]
	public static FileLocation ParseLocationString(string str)
	{
		return default(FileLocation);
	}
}
