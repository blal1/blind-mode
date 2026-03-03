using Il2CppDummyDll;

namespace UnityEngine.UIElements.StyleSheets;

[Token(Token = "0x20005D5")]
internal struct MatchResult
{
	[Token(Token = "0x4001582")]
	[FieldOffset(Offset = "0x0")]
	public MatchResultErrorCode errorCode;

	[Token(Token = "0x4001583")]
	[FieldOffset(Offset = "0x8")]
	public string errorValue;

	[Token(Token = "0x17000A7D")]
	public bool success
	{
		[Token(Token = "0x6002895")]
		[Address(RVA = "0x2A83590", Offset = "0x2A82790", VA = "0x182A83590")]
		get
		{
			return default(bool);
		}
	}
}
