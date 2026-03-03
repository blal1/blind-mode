using Il2CppDummyDll;

namespace YgomGame.Download;

[Token(Token = "0x2000F6B")]
public class DLCVersion
{
	[Token(Token = "0x400A816")]
	private const string kFileName = "dlcVersion";

	[Token(Token = "0x400A817")]
	[FieldOffset(Offset = "0x0")]
	private static bool s_isInitialize;

	[Token(Token = "0x400A818")]
	[FieldOffset(Offset = "0x1")]
	private static bool s_isExistFlag;

	[Token(Token = "0x6005DA5")]
	[Address(RVA = "0xA31F30", Offset = "0xA31130", VA = "0x180A31F30")]
	public static bool ExistFlag()
	{
		return default(bool);
	}

	[Token(Token = "0x6005DA6")]
	[Address(RVA = "0xA31F70", Offset = "0xA31170", VA = "0x180A31F70")]
	public static void Initialize()
	{
	}

	[Token(Token = "0x6005DA7")]
	[Address(RVA = "0xA31E50", Offset = "0xA31050", VA = "0x180A31E50")]
	private static void DLEndNotificator(object value)
	{
	}

	[Token(Token = "0x6005DA8")]
	[Address(RVA = "0xA32240", Offset = "0xA31440", VA = "0x180A32240")]
	public static void Save()
	{
	}

	[Token(Token = "0x6005DA9")]
	[Address(RVA = "0xA32040", Offset = "0xA31240", VA = "0x180A32040")]
	public static void Load()
	{
	}

	[Token(Token = "0x6005DAA")]
	[Address(RVA = "0xA31ED0", Offset = "0xA310D0", VA = "0x180A31ED0")]
	public static void Delete()
	{
	}

	[Token(Token = "0x6005DAB")]
	[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
	public DLCVersion()
	{
	}
}
