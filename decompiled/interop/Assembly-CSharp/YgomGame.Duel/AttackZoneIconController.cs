using Il2CppDummyDll;

namespace YgomGame.Duel;

[Token(Token = "0x200193B")]
public class AttackZoneIconController : ZoneIconController
{
	[Token(Token = "0x600A29F")]
	[Address(RVA = "0xEE87A0", Offset = "0xEE79A0", VA = "0x180EE87A0")]
	public static AttackZoneIconController Create(RunEffectWorker worker)
	{
		return null;
	}

	[Token(Token = "0x600A2A0")]
	[Address(RVA = "0xEE86F0", Offset = "0xEE78F0", VA = "0x180EE86F0")]
	public int ActivateAttackableAvailableZone(int targetPlayer, int targetMask)
	{
		return default(int);
	}

	[Token(Token = "0x600A2A1")]
	[Address(RVA = "0x4306B0", Offset = "0x42F8B0", VA = "0x1804306B0")]
	public AttackZoneIconController()
	{
	}
}
