using Il2CppDummyDll;

namespace YgomGame.Scenario;

[Token(Token = "0x2000AC2")]
public class ScenarioBehaviour_Wait : ScenarioBehaviour
{
	[Token(Token = "0x400938D")]
	[FieldOffset(Offset = "0x50")]
	private float waitSec;

	[Token(Token = "0x400938E")]
	[FieldOffset(Offset = "0x54")]
	private bool m_IsEnableSkip;

	[Token(Token = "0x6004204")]
	[Address(RVA = "0x87EED0", Offset = "0x87E0D0", VA = "0x18087EED0")]
	public ScenarioBehaviour_Wait(object commandData)
	{
	}

	[Token(Token = "0x6004205")]
	[Address(RVA = "0x89D6E0", Offset = "0x89C8E0", VA = "0x18089D6E0", Slot = "12")]
	protected override void ProgressInit()
	{
	}

	[Token(Token = "0x6004206")]
	[Address(RVA = "0x89D690", Offset = "0x89C890", VA = "0x18089D690", Slot = "13")]
	protected override void ProgressAction()
	{
	}

	[Token(Token = "0x6004207")]
	[Address(RVA = "0x89D790", Offset = "0x89C990", VA = "0x18089D790", Slot = "20")]
	protected override bool ProgressPointerClick()
	{
		return default(bool);
	}
}
