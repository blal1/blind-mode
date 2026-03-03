using Il2CppDummyDll;

namespace YgomGame.Duel;

[Token(Token = "0x200192B")]
public class SpecialWinCommon05 : SpecialWinCommonBase
{
	[Token(Token = "0x400EAF0")]
	[FieldOffset(Offset = "0x48")]
	private string[] _labels;

	[Token(Token = "0x170018DA")]
	protected override string prefabPath
	{
		[Token(Token = "0x600A255")]
		[Address(RVA = "0xEFC060", Offset = "0xEFB260", VA = "0x180EFC060", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170018DB")]
	protected override string[] labels
	{
		[Token(Token = "0x600A256")]
		[Address(RVA = "0x414E80", Offset = "0x414080", VA = "0x180414E80", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600A257")]
	[Address(RVA = "0xEFB540", Offset = "0xEFA740", VA = "0x180EFB540", Slot = "9")]
	public override void Initialize()
	{
	}

	[Token(Token = "0x600A258")]
	[Address(RVA = "0xEFB990", Offset = "0xEFAB90", VA = "0x180EFB990")]
	public void SetCardID(int cardID1, int cardID2, int cardID3, int cardID4, int cardID5)
	{
	}

	[Token(Token = "0x600A259")]
	[Address(RVA = "0xEFBF20", Offset = "0xEFB120", VA = "0x180EFBF20")]
	public SpecialWinCommon05()
	{
	}
}
