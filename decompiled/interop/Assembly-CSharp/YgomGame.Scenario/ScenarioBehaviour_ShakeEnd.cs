using Il2CppDummyDll;

namespace YgomGame.Scenario;

[Token(Token = "0x2000AB4")]
public class ScenarioBehaviour_ShakeEnd : ScenarioBehaviour
{
	[Token(Token = "0x4009366")]
	[FieldOffset(Offset = "0x50")]
	public float autoStopSec;

	[Token(Token = "0x60041C2")]
	[Address(RVA = "0x87EED0", Offset = "0x87E0D0", VA = "0x18087EED0")]
	public ScenarioBehaviour_ShakeEnd(object commandData)
	{
	}

	[Token(Token = "0x60041C3")]
	[Address(RVA = "0x899380", Offset = "0x898580", VA = "0x180899380", Slot = "12")]
	protected override void ProgressInit()
	{
	}
}
