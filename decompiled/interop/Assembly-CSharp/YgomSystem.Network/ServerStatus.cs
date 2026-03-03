using Il2CppDummyDll;

namespace YgomSystem.Network;

[Token(Token = "0x2000245")]
public enum ServerStatus
{
	[Token(Token = "0x4000B80")]
	NORMAL,
	[Token(Token = "0x4000B81")]
	INCIDENT,
	[Token(Token = "0x4000B82")]
	MAINTENANCE,
	[Token(Token = "0x4000B83")]
	MAINTENANCE_TEAM
}
