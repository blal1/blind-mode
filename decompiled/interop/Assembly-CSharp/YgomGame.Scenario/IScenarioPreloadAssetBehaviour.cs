using System.Collections.Generic;
using Il2CppDummyDll;

namespace YgomGame.Scenario;

[Token(Token = "0x2000A70")]
public interface IScenarioPreloadAssetBehaviour : IScenarioPreloadBehaviour
{
	[Token(Token = "0x6004030")]
	void AssignPreloadAssetPath(List<string> assetPaths);
}
