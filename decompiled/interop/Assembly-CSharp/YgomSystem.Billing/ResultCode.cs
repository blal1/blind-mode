using Il2CppDummyDll;

namespace YgomSystem.Billing;

[Token(Token = "0x2000335")]
public enum ResultCode
{
	[Token(Token = "0x400116D")]
	NONE,
	[Token(Token = "0x400116E")]
	Success,
	[Token(Token = "0x400116F")]
	NotEnable,
	[Token(Token = "0x4001170")]
	Error,
	[Token(Token = "0x4001171")]
	ReservationError,
	[Token(Token = "0x4001172")]
	Cancel,
	[Token(Token = "0x4001173")]
	PurchaseError,
	[Token(Token = "0x4001174")]
	DateLimitOverError,
	[Token(Token = "0x4001175")]
	LimitExceededError,
	[Token(Token = "0x4001176")]
	LimitError,
	[Token(Token = "0x4001177")]
	RegisterAgeError,
	[Token(Token = "0x4001178")]
	AddItemError,
	[Token(Token = "0x4001179")]
	RestoreError,
	[Token(Token = "0x400117A")]
	SectionMainte,
	[Token(Token = "0x400117B")]
	StoreMainte,
	[Token(Token = "0x400117C")]
	Pending,
	[Token(Token = "0x400117D")]
	SteamOverlayCaution,
	[Token(Token = "0x400117E")]
	VoidedPurchaseError,
	[Token(Token = "0x400117F")]
	AdminFinishTransaction,
	[Token(Token = "0x4001180")]
	ResevationLock
}
