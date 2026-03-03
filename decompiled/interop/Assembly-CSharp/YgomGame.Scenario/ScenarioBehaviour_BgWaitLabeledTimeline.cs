using Il2CppDummyDll;

namespace YgomGame.Scenario;

[Token(Token = "0x2000A9C")]
public class ScenarioBehaviour_BgWaitLabeledTimeline : ScenarioBehaviour
{
	[Token(Token = "0x4009306")]
	[FieldOffset(Offset = "0x50")]
	private object m_RenderTarget;

	[Token(Token = "0x4009307")]
	[FieldOffset(Offset = "0x58")]
	private ScenarioBGActor m_BGActor;

	[Token(Token = "0x4009308")]
	[FieldOffset(Offset = "0x60")]
	private bool m_IsEnableSkip;

	[Token(Token = "0x6004128")]
	[Address(RVA = "0x87EED0", Offset = "0x87E0D0", VA = "0x18087EED0")]
	public ScenarioBehaviour_BgWaitLabeledTimeline(object commandData)
	{
	}

	[Token(Token = "0x6004129")]
	[Address(RVA = "0x87F390", Offset = "0x87E590", VA = "0x18087F390", Slot = "12")]
	protected override void ProgressInit()
	{
	}

	[Token(Token = "0x600412A")]
	[Address(RVA = "0x87F320", Offset = "0x87E520", VA = "0x18087F320", Slot = "13")]
	protected override void ProgressAction()
	{
	}

	[Token(Token = "0x600412B")]
	[Address(RVA = "0x87F520", Offset = "0x87E720", VA = "0x18087F520", Slot = "20")]
	protected override bool ProgressPointerClick()
	{
		return default(bool);
	}
}
