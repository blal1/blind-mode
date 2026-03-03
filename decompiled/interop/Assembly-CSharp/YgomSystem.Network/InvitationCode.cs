using Il2CppDummyDll;

namespace YgomSystem.Network;

[Token(Token = "0x200026F")]
public enum InvitationCode
{
	[Token(Token = "0x4000DBC")]
	NONE = 0,
	[Token(Token = "0x4000DBD")]
	ERROR = 1,
	[Token(Token = "0x4000DBE")]
	FATAL = 2,
	[Token(Token = "0x4000DBF")]
	CRITICAL = 3,
	[Token(Token = "0x4000DC0")]
	ERR_INVALID_PARAM = 4800,
	[Token(Token = "0x4000DC1")]
	ERR_OUT_OF_TERM = 4801,
	[Token(Token = "0x4000DC2")]
	ERR_ALREADY_RECEIVED = 4802,
	[Token(Token = "0x4000DC3")]
	ERR_INVALID_CODE = 4803,
	[Token(Token = "0x4000DC4")]
	ERR_REQUESTED_MULTIPLE = 4804,
	[Token(Token = "0x4000DC5")]
	ERR_FAILED_FOR_THRESHOLD = 4805,
	[Token(Token = "0x4000DC6")]
	ERR_SELF_INVITE_CODE_SENT = 4806,
	[Token(Token = "0x4000DC7")]
	ERR_RETRY_SEND_CODE_AGAIN = 4807,
	[Token(Token = "0x4000DC8")]
	ERR_OUT_OF_SEND_CODE_PERIOD = 4808
}
