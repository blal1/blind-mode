using Il2CppDummyDll;

namespace YgomGame.Scenario;

[Token(Token = "0x2000A6B")]
public interface IScenarioLogTextBehavior : IScenarioLogBehavior
{
	[Token(Token = "0x600402D")]
	string GetLogText();
}
