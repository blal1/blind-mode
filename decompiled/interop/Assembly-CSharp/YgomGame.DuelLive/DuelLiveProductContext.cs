using Il2CppDummyDll;

namespace YgomGame.DuelLive;

[Token(Token = "0x2000EFA")]
public class DuelLiveProductContext : ProductContextBase<DuelLiveProductContext>
{
	[Token(Token = "0x6005ABC")]
	[Address(RVA = "0xA092E0", Offset = "0xA084E0", VA = "0x180A092E0")]
	public DuelLiveProductContext()
	{
	}

	[Token(Token = "0x6005ABD")]
	[Address(RVA = "0xA09220", Offset = "0xA08420", VA = "0x180A09220", Slot = "35")]
	public override int Compare(DuelLiveProductContext a, DuelLiveProductContext b)
	{
		return default(int);
	}

	[Token(Token = "0x6005ABE")]
	[Address(RVA = "0xA09200", Offset = "0xA08400", VA = "0x180A09200", Slot = "36")]
	public override int CompareTo(DuelLiveProductContext other)
	{
		return default(int);
	}
}
