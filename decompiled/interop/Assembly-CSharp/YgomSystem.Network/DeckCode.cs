using Il2CppDummyDll;

namespace YgomSystem.Network;

[Token(Token = "0x200024C")]
public enum DeckCode
{
	[Token(Token = "0x4000BF1")]
	NONE = 0,
	[Token(Token = "0x4000BF2")]
	ERROR = 1,
	[Token(Token = "0x4000BF3")]
	FATAL = 2,
	[Token(Token = "0x4000BF4")]
	CRITICAL = 3,
	[Token(Token = "0x4000BF5")]
	ERROR_DECK_CONFIG = 1400,
	[Token(Token = "0x4000BF6")]
	ERROR_DECK_LIMIT = 1401,
	[Token(Token = "0x4000BF7")]
	ERROR_DECK_REGULATION = 1402,
	[Token(Token = "0x4000BF8")]
	ERROR_PARAMS_CONFIG = 1403,
	[Token(Token = "0x4000BF9")]
	ERROR_TOURNAMENT_STATUS = 1404,
	[Token(Token = "0x4000BFA")]
	ERROR_EXHIBITION_STATUS = 1405,
	[Token(Token = "0x4000BFB")]
	ERROR_DECK_NAME_LEN = 1406,
	[Token(Token = "0x4000BFC")]
	ERROR_DECK_SAME_CARDS = 1407,
	[Token(Token = "0x4000BFD")]
	ERROR_DECK_NO = 1408,
	[Token(Token = "0x4000BFE")]
	ERROR_CARD_ID = 1409,
	[Token(Token = "0x4000BFF")]
	ERROR_UNFIND_MAINDECK = 1410,
	[Token(Token = "0x4000C00")]
	INVALID_DECK_COUNT = 1440,
	[Token(Token = "0x4000C01")]
	INVALID_DECK_NAME = 1441,
	[Token(Token = "0x4000C02")]
	INVALID_DECK_BIKO = 1442,
	[Token(Token = "0x4000C03")]
	CGN_ID_NOT_LINKED = 1443,
	[Token(Token = "0x4000C04")]
	OVER_DECK_LIMIT = 1444,
	[Token(Token = "0x4000C05")]
	INVALID_ACCESS = 1445,
	[Token(Token = "0x4000C06")]
	CDB_SERVER_ERROR = 1446,
	[Token(Token = "0x4000C07")]
	KONAMIID_SERVER_ERROR = 1447,
	[Token(Token = "0x4000C08")]
	NEURON_MAINTENANCE = 1448,
	[Token(Token = "0x4000C09")]
	NO_CONSTRUCT_DATA = 1460,
	[Token(Token = "0x4000C0A")]
	AUTO_CONSTRUCT_TIMEOUT = 1461,
	[Token(Token = "0x4000C0B")]
	AUTO_CONSTRUCT_NOT_ENOUGH = 1462
}
