using System.Collections.Generic;
using Il2CppDummyDll;

namespace YgomGame.Scenario;

[Token(Token = "0x2000A71")]
public interface IScenarioPreloadSoundBehaviour : IScenarioPreloadBehaviour
{
	[Token(Token = "0x6004031")]
	void AssignPreloadSoundLabels(List<string> soundLabels);
}
