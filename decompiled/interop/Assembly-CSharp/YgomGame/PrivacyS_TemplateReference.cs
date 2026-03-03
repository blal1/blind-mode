using Il2CppDummyDll;

namespace YgomGame;

[Token(Token = "0x2000713")]
internal class PrivacyS_TemplateReference
{
	[Token(Token = "0x4002355")]
	[FieldOffset(Offset = "0x10")]
	public string informText;

	[Token(Token = "0x4002356")]
	[FieldOffset(Offset = "0x18")]
	public int id;

	[Token(Token = "0x4002357")]
	[FieldOffset(Offset = "0x1C")]
	public bool leftSelect;

	[Token(Token = "0x4002358")]
	[FieldOffset(Offset = "0x1D")]
	public bool rightSelect;

	[Token(Token = "0x4002359")]
	[FieldOffset(Offset = "0x1E")]
	public bool selected;

	[Token(Token = "0x6002EBB")]
	[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
	public PrivacyS_TemplateReference()
	{
	}
}
