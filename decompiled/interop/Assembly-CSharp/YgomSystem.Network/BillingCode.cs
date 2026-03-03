using Il2CppDummyDll;

namespace YgomSystem.Network;

[Token(Token = "0x200025B")]
public enum BillingCode
{
	[Token(Token = "0x4000CA2")]
	NONE = 0,
	[Token(Token = "0x4000CA3")]
	ERROR = 1,
	[Token(Token = "0x4000CA4")]
	FATAL = 2,
	[Token(Token = "0x4000CA5")]
	CRITICAL = 3,
	[Token(Token = "0x4000CA6")]
	PURCHASE_FAILED = 2901,
	[Token(Token = "0x4000CA7")]
	PURCHASE_FATAL = 2902,
	[Token(Token = "0x4000CA8")]
	PURCHASE_CRITICAL = 2903,
	[Token(Token = "0x4000CA9")]
	INVALID_RECEIPT = 2904,
	[Token(Token = "0x4000CAA")]
	PROCESSED = 2905,
	[Token(Token = "0x4000CAB")]
	BILLING_LIMIT = 2906,
	[Token(Token = "0x4000CAC")]
	REQUIRE_AGE = 2907,
	[Token(Token = "0x4000CAD")]
	REGISTER_AGE_FAILED = 2908,
	[Token(Token = "0x4000CAE")]
	UN_COMPLETE_PURCHASE_ITEM = 2909,
	[Token(Token = "0x4000CAF")]
	PURCHASE_ITEM_ADD_FAILED = 2910,
	[Token(Token = "0x4000CB0")]
	INVALID_RECEIPT_REACCESS = 2911,
	[Token(Token = "0x4000CB1")]
	HISTORY_FAILED = 2912,
	[Token(Token = "0x4000CB2")]
	PLATFORM_AUTH_EXPIRED = 2913,
	[Token(Token = "0x4000CB3")]
	NO_ITEM_PURCHASED = 2914,
	[Token(Token = "0x4000CB4")]
	MIIM_MAINTENANCE = 2915,
	[Token(Token = "0x4000CB5")]
	DIVISION_MAINTENANCE = 2916,
	[Token(Token = "0x4000CB6")]
	DATE_LIMIT_OVER = 2917,
	[Token(Token = "0x4000CB7")]
	LIMIT_EXCEEDED = 2918,
	[Token(Token = "0x4000CB8")]
	PURCHASE_PENDING = 2919,
	[Token(Token = "0x4000CB9")]
	VOIDED_PURCHASE = 2920,
	[Token(Token = "0x4000CBA")]
	ADMIN_FINISH_TRANSACTION = 2921,
	[Token(Token = "0x4000CBB")]
	RESERVATION_LOCK = 2922,
	[Token(Token = "0x4000CBC")]
	STEAM_OVER_LAY_OFF = 2930,
	[Token(Token = "0x4000CBD")]
	NX_BAASERROR_SERVICE_MAINTENANCE = 2950,
	[Token(Token = "0x4000CBE")]
	NX_SUGARERROR_SERVICE_MAINTENANCE = 2951
}
