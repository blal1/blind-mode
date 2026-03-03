using Il2CppDummyDll;

namespace YgomSystem;

[Token(Token = "0x2000159")]
public static class BranchInfo
{
	[Token(Token = "0x400082A")]
	[FieldOffset(Offset = "0x0")]
	private static string s_branchName;

	[Token(Token = "0x400082B")]
	[FieldOffset(Offset = "0x8")]
	private static string s_commitHash;

	[Token(Token = "0x400082C")]
	[FieldOffset(Offset = "0x10")]
	private static bool s_isReleaseBranch;

	[Token(Token = "0x170000E7")]
	public static string branchName
	{
		[Token(Token = "0x6000890")]
		[Address(RVA = "0xAF2510", Offset = "0xAF1710", VA = "0x180AF2510")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170000E8")]
	public static string commitHash
	{
		[Token(Token = "0x6000891")]
		[Address(RVA = "0xAF2560", Offset = "0xAF1760", VA = "0x180AF2560")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170000E9")]
	public static bool isReleaseBranch
	{
		[Token(Token = "0x6000892")]
		[Address(RVA = "0xAF25B0", Offset = "0xAF17B0", VA = "0x180AF25B0")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6000893")]
	[Address(RVA = "0xAF2390", Offset = "0xAF1590", VA = "0x180AF2390")]
	public static void Initialize(BranchData data)
	{
	}
}
