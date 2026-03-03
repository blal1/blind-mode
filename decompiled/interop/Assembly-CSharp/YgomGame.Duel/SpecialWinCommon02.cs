using Il2CppDummyDll;

namespace YgomGame.Duel;

[Token(Token = "0x2001928")]
public class SpecialWinCommon02 : SpecialWinCommonBase
{
	[Token(Token = "0x400EAED")]
	[FieldOffset(Offset = "0x48")]
	private string[] _labels;

	[Token(Token = "0x170018D4")]
	protected override string prefabPath
	{
		[Token(Token = "0x600A23A")]
		[Address(RVA = "0xEFA3C0", Offset = "0xEF95C0", VA = "0x180EFA3C0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170018D5")]
	protected override string[] labels
	{
		[Token(Token = "0x600A23B")]
		[Address(RVA = "0x414E80", Offset = "0x414080", VA = "0x180414E80", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600A23C")]
	[Address(RVA = "0xEF9DF0", Offset = "0xEF8FF0", VA = "0x180EF9DF0", Slot = "9")]
	public override void Initialize()
	{
	}

	[Token(Token = "0x600A23D")]
	[Address(RVA = "0xEFA090", Offset = "0xEF9290", VA = "0x180EFA090")]
	public void SetCardID(int cardID1, int cardID2)
	{
	}

	[Token(Token = "0x600A23E")]
	[Address(RVA = "0xEFA300", Offset = "0xEF9500", VA = "0x180EFA300")]
	public SpecialWinCommon02()
	{
	}
}
