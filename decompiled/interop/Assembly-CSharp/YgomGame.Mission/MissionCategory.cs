using Il2CppDummyDll;

namespace YgomGame.Mission;

[Token(Token = "0x2000BCF")]
public enum MissionCategory
{
	[Token(Token = "0x4009863")]
	None = -1,
	[Token(Token = "0x4009864")]
	Normal = 1,
	[Token(Token = "0x4009865")]
	Special = 2,
	[Token(Token = "0x4009866")]
	Secret = 3,
	[Token(Token = "0x4009867")]
	Starting = 4,
	[Token(Token = "0x4009868")]
	Life = 5,
	[Token(Token = "0x4009869")]
	Login = 6,
	[Token(Token = "0x400986A")]
	DuelLive = 7
}
