using Il2CppDummyDll;

namespace YgomGame.Scenario;

[Token(Token = "0x2000AC7")]
public class ScenarioBehaviour_VoiceChild : ScenarioBehaviour, IScenarioBehaviour_SoundPlay
{
	[Token(Token = "0x40093A1")]
	[FieldOffset(Offset = "0x50")]
	private readonly ScenarioBehaviour_SoundPlay m_SoundPlayBehaviour;

	[Token(Token = "0x170008CA")]
	public bool readyTMClip
	{
		[Token(Token = "0x6004226")]
		[Address(RVA = "0x89D230", Offset = "0x89C430", VA = "0x18089D230", Slot = "23")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170008CB")]
	public bool useTMClip
	{
		[Token(Token = "0x6004227")]
		[Address(RVA = "0x89D250", Offset = "0x89C450", VA = "0x18089D250", Slot = "24")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6004228")]
	[Address(RVA = "0x89D130", Offset = "0x89C330", VA = "0x18089D130")]
	public ScenarioBehaviour_VoiceChild(object commandData)
	{
	}

	[Token(Token = "0x6004229")]
	[Address(RVA = "0x89D050", Offset = "0x89C250", VA = "0x18089D050", Slot = "9")]
	protected override bool AllowProgressNextChild(ScenarioBehaviour child)
	{
		return default(bool);
	}

	[Token(Token = "0x600422A")]
	[Address(RVA = "0x89D0F0", Offset = "0x89C2F0", VA = "0x18089D0F0", Slot = "7")]
	public override void SetScenarioWork(ScenarioWork work)
	{
	}

	[Token(Token = "0x600422B")]
	[Address(RVA = "0x8831B0", Offset = "0x8823B0", VA = "0x1808831B0", Slot = "12")]
	protected override void ProgressInit()
	{
	}
}
