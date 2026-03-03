using Il2CppDummyDll;

namespace YgomGame.Scenario;

[Token(Token = "0x2000A9A")]
public class ScenarioBehaviour_BgPlayLabeledTimeline : ScenarioBehaviour
{
	[Token(Token = "0x40092FC")]
	[FieldOffset(Offset = "0x50")]
	private ScenarioBGActor m_BGActor;

	[Token(Token = "0x6004123")]
	[Address(RVA = "0x87EED0", Offset = "0x87E0D0", VA = "0x18087EED0")]
	public ScenarioBehaviour_BgPlayLabeledTimeline(object commandData)
	{
	}

	[Token(Token = "0x6004124")]
	[Address(RVA = "0x87ED80", Offset = "0x87DF80", VA = "0x18087ED80", Slot = "12")]
	protected override void ProgressInit()
	{
	}
}
