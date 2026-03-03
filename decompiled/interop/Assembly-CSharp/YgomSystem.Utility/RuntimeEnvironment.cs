using Il2CppDummyDll;

namespace YgomSystem.Utility;

[Token(Token = "0x20003FE")]
public static class RuntimeEnvironment
{
	[Token(Token = "0x20003FF")]
	public enum ServerType
	{
		[Token(Token = "0x40013DE")]
		Product = 0,
		[Token(Token = "0x40013DF")]
		Staging = 1,
		[Token(Token = "0x40013E0")]
		QC1 = 2,
		[Token(Token = "0x40013E1")]
		Development = 3,
		[Token(Token = "0x40013E2")]
		KonamiLan = 4,
		[Token(Token = "0x40013E3")]
		Mock = 5,
		[Token(Token = "0x40013E4")]
		Apple = 6,
		[Token(Token = "0x40013E5")]
		Event = 7,
		[Token(Token = "0x40013E6")]
		QC2 = 8,
		[Token(Token = "0x40013E7")]
		Mock1 = 9,
		[Token(Token = "0x40013E8")]
		Mock2 = 10,
		[Token(Token = "0x40013E9")]
		Mock3 = 11,
		[Token(Token = "0x40013EA")]
		Event2 = 12,
		[Token(Token = "0x40013EB")]
		Dummy = 9999
	}

	[Token(Token = "0x40013DB")]
	[FieldOffset(Offset = "0x0")]
	public static ServerType server;

	[Token(Token = "0x40013DC")]
	[FieldOffset(Offset = "0x8")]
	private static readonly string[] langs;

	[Token(Token = "0x6001999")]
	[Address(RVA = "0x3EF020", Offset = "0x3EE220", VA = "0x1803EF020")]
	public static ServerType GetDefaultServerType()
	{
		return default(ServerType);
	}

	[Token(Token = "0x600199A")]
	[Address(RVA = "0x5D5670", Offset = "0x5D4870", VA = "0x1805D5670")]
	static RuntimeEnvironment()
	{
	}
}
