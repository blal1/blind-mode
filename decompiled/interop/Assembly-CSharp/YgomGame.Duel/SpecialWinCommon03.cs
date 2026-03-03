using Il2CppDummyDll;

namespace YgomGame.Duel;

[Token(Token = "0x2001929")]
public class SpecialWinCommon03 : SpecialWinCommonBase
{
	[Token(Token = "0x400EAEE")]
	[FieldOffset(Offset = "0x48")]
	private string[] _labels;

	[Token(Token = "0x170018D6")]
	protected override string prefabPath
	{
		[Token(Token = "0x600A242")]
		[Address(RVA = "0xEFAB80", Offset = "0xEF9D80", VA = "0x180EFAB80", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170018D7")]
	protected override string[] labels
	{
		[Token(Token = "0x600A243")]
		[Address(RVA = "0x414E80", Offset = "0x414080", VA = "0x180414E80", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600A244")]
	[Address(RVA = "0xEFA3F0", Offset = "0xEF95F0", VA = "0x180EFA3F0", Slot = "9")]
	public override void Initialize()
	{
	}

	[Token(Token = "0x600A245")]
	[Address(RVA = "0xEFA720", Offset = "0xEF9920", VA = "0x180EFA720")]
	public void SetCardID(int cardID1, int cardID2, int cardID3)
	{
	}

	[Token(Token = "0x600A246")]
	[Address(RVA = "0xEFAA90", Offset = "0xEF9C90", VA = "0x180EFAA90")]
	public SpecialWinCommon03()
	{
	}
}
