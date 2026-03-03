using Il2CppDummyDll;

namespace YgomGame.Scenario;

[Token(Token = "0x2000AC1")]
public class ScenarioBehaviour_TitleVoice : ScenarioBehaviour, IScenarioFadeInTransitionBehaviour
{
	[Token(Token = "0x400938B")]
	[FieldOffset(Offset = "0x50")]
	private readonly ScenarioBehaviour_Title m_TitleBehaviour;

	[Token(Token = "0x400938C")]
	[FieldOffset(Offset = "0x58")]
	private readonly ScenarioBehaviour_SoundPlay m_SoundPlayBehaviour;

	[Token(Token = "0x6004200")]
	[Address(RVA = "0x89C060", Offset = "0x89B260", VA = "0x18089C060", Slot = "23")]
	public bool IsFadeInTransitionCompleted()
	{
		return default(bool);
	}

	[Token(Token = "0x6004201")]
	[Address(RVA = "0x89C0E0", Offset = "0x89B2E0", VA = "0x18089C0E0")]
	public ScenarioBehaviour_TitleVoice(object commandData)
	{
	}

	[Token(Token = "0x6004202")]
	[Address(RVA = "0x89C090", Offset = "0x89B290", VA = "0x18089C090", Slot = "7")]
	public override void SetScenarioWork(ScenarioWork work)
	{
	}

	[Token(Token = "0x6004203")]
	[Address(RVA = "0x8831B0", Offset = "0x8823B0", VA = "0x1808831B0", Slot = "12")]
	protected override void ProgressInit()
	{
	}
}
