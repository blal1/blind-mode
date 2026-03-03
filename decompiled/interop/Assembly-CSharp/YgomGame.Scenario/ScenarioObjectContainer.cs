using Il2CppDummyDll;
using YgomSystem.ElementSystem;

namespace YgomGame.Scenario;

[Token(Token = "0x2000A7D")]
public class ScenarioObjectContainer : ScenarioContainerBase
{
	[Token(Token = "0x4009267")]
	[FieldOffset(Offset = "0x28")]
	public readonly ScenarioObjectContainer3D container3D;

	[Token(Token = "0x4009268")]
	[FieldOffset(Offset = "0x30")]
	public readonly ScenarioObjectContainerUI containerUI;

	[Token(Token = "0x60040A1")]
	[Address(RVA = "0x88DD70", Offset = "0x88CF70", VA = "0x18088DD70")]
	public ScenarioObjectContainer(ElementObjectManager eom3D, ElementObjectManager eomUI)
	{
	}

	[Token(Token = "0x60040A2")]
	[Address(RVA = "0x88DCB0", Offset = "0x88CEB0", VA = "0x18088DCB0")]
	public void Initialize(ScenarioWork work)
	{
	}

	[Token(Token = "0x60040A3")]
	[Address(RVA = "0x88DCF0", Offset = "0x88CEF0", VA = "0x18088DCF0")]
	public void OnStackRemove()
	{
	}

	[Token(Token = "0x60040A4")]
	[Address(RVA = "0x88DC40", Offset = "0x88CE40", VA = "0x18088DC40")]
	public ScenarioContainerBase GetShakeTarget(int targetNo)
	{
		return null;
	}
}
