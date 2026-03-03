using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace YgomGame.Scenario;

[Token(Token = "0x2000AB3")]
public class ScenarioBehaviour_ScreenFade : ScenarioBehaviour, IScenarioScreenActorBehaviour, IScenarioBehaviour
{
	[Token(Token = "0x4009360")]
	[FieldOffset(Offset = "0x50")]
	private ScenarioScreenContainer.Targets m_ScreenTarget;

	[Token(Token = "0x4009361")]
	[FieldOffset(Offset = "0x58")]
	private Graphic m_FadeTarget;

	[Token(Token = "0x4009362")]
	[FieldOffset(Offset = "0x60")]
	private Color m_FromColor;

	[Token(Token = "0x4009363")]
	[FieldOffset(Offset = "0x70")]
	private Color m_ToColor;

	[Token(Token = "0x4009364")]
	[FieldOffset(Offset = "0x80")]
	private float m_FadeTime;

	[Token(Token = "0x4009365")]
	[FieldOffset(Offset = "0x84")]
	private float m_CrntTime;

	[Token(Token = "0x170008B4")]
	public bool isOverrideBehaveScreen
	{
		[Token(Token = "0x60041BA")]
		[Address(RVA = "0x404830", Offset = "0x403A30", VA = "0x180404830", Slot = "23")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x60041BB")]
	[Address(RVA = "0x899190", Offset = "0x898390", VA = "0x180899190")]
	public ScenarioBehaviour_ScreenFade(object commandData)
	{
	}

	[Token(Token = "0x60041BC")]
	[Address(RVA = "0x49BD90", Offset = "0x49AF90", VA = "0x18049BD90", Slot = "24")]
	public ScenarioScreenContainer.Targets GetBehaveScreenTargets()
	{
		return default(ScenarioScreenContainer.Targets);
	}

	[Token(Token = "0x60041BD")]
	[Address(RVA = "0x4B8E10", Offset = "0x4B8010", VA = "0x1804B8E10", Slot = "25")]
	public ScenarioScreenContainer.Operations GetBehaveScreenOperations()
	{
		return default(ScenarioScreenContainer.Operations);
	}

	[Token(Token = "0x60041BE")]
	[Address(RVA = "0x898EB0", Offset = "0x8980B0", VA = "0x180898EB0", Slot = "12")]
	protected override void ProgressInit()
	{
	}

	[Token(Token = "0x60041BF")]
	[Address(RVA = "0x898CD0", Offset = "0x897ED0", VA = "0x180898CD0", Slot = "13")]
	protected override void ProgressAction()
	{
	}

	[Token(Token = "0x60041C0")]
	[Address(RVA = "0x898E30", Offset = "0x898030", VA = "0x180898E30", Slot = "16")]
	protected override void ProgressFinish()
	{
	}

	[Token(Token = "0x60041C1")]
	[Address(RVA = "0x3C7A70", Offset = "0x3C6C70", VA = "0x1803C7A70", Slot = "19")]
	public override bool IsOverrideBehaviour(ScenarioBehaviour target)
	{
		return default(bool);
	}
}
