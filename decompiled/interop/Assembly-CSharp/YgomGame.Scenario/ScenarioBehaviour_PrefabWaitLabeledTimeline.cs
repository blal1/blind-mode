using Il2CppDummyDll;
using YgomSystem.Timeline;

namespace YgomGame.Scenario;

[Token(Token = "0x2000AAD")]
public class ScenarioBehaviour_PrefabWaitLabeledTimeline : ScenarioBehaviour
{
	[Token(Token = "0x4009343")]
	[FieldOffset(Offset = "0x50")]
	private LabeledPlayableController m_Target;

	[Token(Token = "0x4009344")]
	[FieldOffset(Offset = "0x58")]
	private bool m_IsEnableSkip;

	[Token(Token = "0x6004183")]
	[Address(RVA = "0x87EED0", Offset = "0x87E0D0", VA = "0x18087EED0")]
	public ScenarioBehaviour_PrefabWaitLabeledTimeline(object commandData)
	{
	}

	[Token(Token = "0x6004184")]
	[Address(RVA = "0x898AA0", Offset = "0x897CA0", VA = "0x180898AA0", Slot = "12")]
	protected override void ProgressInit()
	{
	}

	[Token(Token = "0x6004185")]
	[Address(RVA = "0x898A10", Offset = "0x897C10", VA = "0x180898A10", Slot = "13")]
	protected override void ProgressAction()
	{
	}

	[Token(Token = "0x6004186")]
	[Address(RVA = "0x898C80", Offset = "0x897E80", VA = "0x180898C80", Slot = "20")]
	protected override bool ProgressPointerClick()
	{
		return default(bool);
	}
}
