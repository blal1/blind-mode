using Il2CppDummyDll;

namespace YgomGame.Duel;

[Token(Token = "0x200192A")]
public class SpecialWinCommon04 : SpecialWinCommonBase
{
	[Token(Token = "0x400EAEF")]
	[FieldOffset(Offset = "0x48")]
	private string[] _labels;

	[Token(Token = "0x170018D8")]
	protected override string prefabPath
	{
		[Token(Token = "0x600A24B")]
		[Address(RVA = "0xEFB510", Offset = "0xEFA710", VA = "0x180EFB510", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170018D9")]
	protected override string[] labels
	{
		[Token(Token = "0x600A24C")]
		[Address(RVA = "0x414E80", Offset = "0x414080", VA = "0x180414E80", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600A24D")]
	[Address(RVA = "0xEFABB0", Offset = "0xEF9DB0", VA = "0x180EFABB0", Slot = "9")]
	public override void Initialize()
	{
	}

	[Token(Token = "0x600A24E")]
	[Address(RVA = "0xEFAF70", Offset = "0xEFA170", VA = "0x180EFAF70")]
	public void SetCardID(int cardID1, int cardID2, int cardID3, int cardID4)
	{
	}

	[Token(Token = "0x600A24F")]
	[Address(RVA = "0xEFB3F0", Offset = "0xEFA5F0", VA = "0x180EFB3F0")]
	public SpecialWinCommon04()
	{
	}
}
