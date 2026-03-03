using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace YgomGame.Scenario;

[Token(Token = "0x2000A68")]
public interface IScenarioLoadGroupHandleBehaviour
{
	[Token(Token = "0x600401A")]
	void CollectLoadPath(List<(string path, Type type)> res);

	[Token(Token = "0x600401B")]
	void CollectLoadMrk(List<int> res);
}
