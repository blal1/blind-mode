using Il2CppDummyDll;

namespace YgomSystem.Compliance;

[Token(Token = "0x200032B")]
public enum ApprovalStatus
{
	[Token(Token = "0x4001158")]
	None,
	[Token(Token = "0x4001159")]
	Passed,
	[Token(Token = "0x400115A")]
	Rejected,
	[Token(Token = "0x400115B")]
	Error,
	[Token(Token = "0x400115C")]
	InProgress
}
