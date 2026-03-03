using Il2CppDummyDll;

namespace YgomGame.Scenario;

[Token(Token = "0x2000AB5")]
public class ScenarioBehaviour_ShakeStart : ScenarioBehaviour
{
	[Token(Token = "0x4009367")]
	[FieldOffset(Offset = "0x50")]
	private ScenarioContainerBase m_PlayTarget;

	[Token(Token = "0x60041C4")]
	[Address(RVA = "0x87EED0", Offset = "0x87E0D0", VA = "0x18087EED0")]
	public ScenarioBehaviour_ShakeStart(object commandData)
	{
	}

	[Token(Token = "0x60041C5")]
	[Address(RVA = "0x899480", Offset = "0x898680", VA = "0x180899480", Slot = "12")]
	protected override void ProgressInit()
	{
	}

	[Token(Token = "0x60041C6")]
	[Address(RVA = "0x899440", Offset = "0x898640", VA = "0x180899440", Slot = "13")]
	protected override void ProgressAction()
	{
	}
}
