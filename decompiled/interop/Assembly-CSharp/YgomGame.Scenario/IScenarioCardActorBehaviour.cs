using System.Collections.Generic;
using Il2CppDummyDll;

namespace YgomGame.Scenario;

[Token(Token = "0x2000A5E")]
public interface IScenarioCardActorBehaviour
{
	[Token(Token = "0x6003FD8")]
	IReadOnlyList<int> GetBehaveCardSlots();

	[Token(Token = "0x6003FD9")]
	ScenarioCardContainer.Operations GetBehaveCardOperations();
}
