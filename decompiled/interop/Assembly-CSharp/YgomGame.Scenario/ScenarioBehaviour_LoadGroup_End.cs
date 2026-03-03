using Il2CppDummyDll;

namespace YgomGame.Scenario;

[Token(Token = "0x2000ABE")]
public class ScenarioBehaviour_LoadGroup_End : ScenarioBehaviour, IScenarioFadeInTransitionBehaviour
{
	[Token(Token = "0x60041F4")]
	[Address(RVA = "0x417C60", Offset = "0x416E60", VA = "0x180417C60", Slot = "23")]
	public bool IsFadeInTransitionCompleted()
	{
		return default(bool);
	}

	[Token(Token = "0x60041F5")]
	[Address(RVA = "0x87EED0", Offset = "0x87E0D0", VA = "0x18087EED0")]
	public ScenarioBehaviour_LoadGroup_End(object commandData)
	{
	}

	[Token(Token = "0x60041F6")]
	[Address(RVA = "0x897860", Offset = "0x896A60", VA = "0x180897860", Slot = "12")]
	protected override void ProgressInit()
	{
	}
}
