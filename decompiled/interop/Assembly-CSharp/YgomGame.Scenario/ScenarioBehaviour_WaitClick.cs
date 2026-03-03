using Il2CppDummyDll;

namespace YgomGame.Scenario;

[Token(Token = "0x2000AC3")]
public class ScenarioBehaviour_WaitClick : ScenarioBehaviour
{
	[Token(Token = "0x170008C3")]
	protected override float autoWaitSec
	{
		[Token(Token = "0x6004208")]
		[Address(RVA = "0x89D670", Offset = "0x89C870", VA = "0x18089D670", Slot = "22")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x6004209")]
	[Address(RVA = "0x87EED0", Offset = "0x87E0D0", VA = "0x18087EED0")]
	public ScenarioBehaviour_WaitClick(object commandData)
	{
	}

	[Token(Token = "0x600420A")]
	[Address(RVA = "0x89D320", Offset = "0x89C520", VA = "0x18089D320", Slot = "12")]
	protected override void ProgressInit()
	{
	}

	[Token(Token = "0x600420B")]
	[Address(RVA = "0x89D630", Offset = "0x89C830", VA = "0x18089D630", Slot = "20")]
	protected override bool ProgressPointerClick()
	{
		return default(bool);
	}
}
