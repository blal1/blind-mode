using Il2CppDummyDll;

namespace YgomGame.Scenario;

[Token(Token = "0x2000ABD")]
public class ScenarioBehaviour_LoadGroup_Begin : ScenarioBehaviour, IScenarioFadeInTransitionBehaviour
{
	[Token(Token = "0x400937F")]
	[FieldOffset(Offset = "0x50")]
	private int m_InnerStep;

	[Token(Token = "0x60041F1")]
	[Address(RVA = "0x417C60", Offset = "0x416E60", VA = "0x180417C60", Slot = "23")]
	public bool IsFadeInTransitionCompleted()
	{
		return default(bool);
	}

	[Token(Token = "0x60041F2")]
	[Address(RVA = "0x87EED0", Offset = "0x87E0D0", VA = "0x18087EED0")]
	public ScenarioBehaviour_LoadGroup_Begin(object commandData)
	{
	}

	[Token(Token = "0x60041F3")]
	[Address(RVA = "0x8977D0", Offset = "0x8969D0", VA = "0x1808977D0", Slot = "12")]
	protected override void ProgressInit()
	{
	}
}
