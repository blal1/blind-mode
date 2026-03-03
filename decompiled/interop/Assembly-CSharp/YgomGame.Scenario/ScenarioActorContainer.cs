using Il2CppDummyDll;
using YgomSystem.ElementSystem;

namespace YgomGame.Scenario;

[Token(Token = "0x2000A54")]
public class ScenarioActorContainer : ScenarioContainerBase
{
	[Token(Token = "0x4009173")]
	[FieldOffset(Offset = "0x28")]
	private readonly string k_ELabelUnitGroup;

	[Token(Token = "0x4009174")]
	[FieldOffset(Offset = "0x30")]
	private readonly string k_ELabelCardGroup;

	[Token(Token = "0x4009175")]
	[FieldOffset(Offset = "0x38")]
	public readonly ScenarioUnitContainer unitContainer;

	[Token(Token = "0x4009176")]
	[FieldOffset(Offset = "0x40")]
	public readonly ScenarioCardContainer cardContainer;

	[Token(Token = "0x6003F65")]
	[Address(RVA = "0x865420", Offset = "0x864620", VA = "0x180865420")]
	public ScenarioActorContainer(ElementObjectManager eom)
	{
	}
}
