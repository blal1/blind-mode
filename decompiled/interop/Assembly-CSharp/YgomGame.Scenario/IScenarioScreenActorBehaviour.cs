using Il2CppDummyDll;

namespace YgomGame.Scenario;

[Token(Token = "0x2000A86")]
public interface IScenarioScreenActorBehaviour : IScenarioBehaviour
{
	[Token(Token = "0x170008A4")]
	bool isOverrideBehaveScreen
	{
		[Token(Token = "0x60040D4")]
		get;
	}

	[Token(Token = "0x60040D5")]
	ScenarioScreenContainer.Targets GetBehaveScreenTargets();

	[Token(Token = "0x60040D6")]
	ScenarioScreenContainer.Operations GetBehaveScreenOperations();
}
