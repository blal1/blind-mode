using Il2CppDummyDll;

namespace YgomGame.Duel;

[Token(Token = "0x2001927")]
public class SpecialWinCommon01 : SpecialWinCommonBase
{
	[Token(Token = "0x400EAEC")]
	[FieldOffset(Offset = "0x48")]
	private string[] _labels;

	[Token(Token = "0x170018D2")]
	protected override string prefabPath
	{
		[Token(Token = "0x600A233")]
		[Address(RVA = "0xEF9DC0", Offset = "0xEF8FC0", VA = "0x180EF9DC0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170018D3")]
	protected override string[] labels
	{
		[Token(Token = "0x600A234")]
		[Address(RVA = "0x414E80", Offset = "0x414080", VA = "0x180414E80", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600A235")]
	[Address(RVA = "0xEF99B0", Offset = "0xEF8BB0", VA = "0x180EF99B0", Slot = "9")]
	public override void Initialize()
	{
	}

	[Token(Token = "0x600A236")]
	[Address(RVA = "0xEF9BC0", Offset = "0xEF8DC0", VA = "0x180EF9BC0")]
	public void SetCardID(int cardID1)
	{
	}

	[Token(Token = "0x600A237")]
	[Address(RVA = "0xEF9D20", Offset = "0xEF8F20", VA = "0x180EF9D20")]
	public SpecialWinCommon01()
	{
	}
}
