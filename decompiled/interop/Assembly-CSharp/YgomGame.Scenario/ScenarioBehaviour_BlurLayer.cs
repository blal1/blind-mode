using Il2CppDummyDll;

namespace YgomGame.Scenario;

[Token(Token = "0x2000AB1")]
public class ScenarioBehaviour_BlurLayer : ScenarioBehaviour
{
	[Token(Token = "0x4009357")]
	[FieldOffset(Offset = "0x50")]
	private ScenarioBlurLayerActor m_BlurLayerActor;

	[Token(Token = "0x4009358")]
	[FieldOffset(Offset = "0x58")]
	private float m_TotalFadeSec;

	[Token(Token = "0x4009359")]
	[FieldOffset(Offset = "0x5C")]
	private float m_FadeSec;

	[Token(Token = "0x400935A")]
	[FieldOffset(Offset = "0x60")]
	private float m_FromEffectVal;

	[Token(Token = "0x400935B")]
	[FieldOffset(Offset = "0x64")]
	private float m_ToEffectVal;

	[Token(Token = "0x60041AF")]
	[Address(RVA = "0x87EED0", Offset = "0x87E0D0", VA = "0x18087EED0")]
	public ScenarioBehaviour_BlurLayer(object commandData)
	{
	}

	[Token(Token = "0x60041B0")]
	[Address(RVA = "0x897270", Offset = "0x896470", VA = "0x180897270", Slot = "12")]
	protected override void ProgressInit()
	{
	}

	[Token(Token = "0x60041B1")]
	[Address(RVA = "0x8971A0", Offset = "0x8963A0", VA = "0x1808971A0", Slot = "13")]
	protected override void ProgressAction()
	{
	}
}
