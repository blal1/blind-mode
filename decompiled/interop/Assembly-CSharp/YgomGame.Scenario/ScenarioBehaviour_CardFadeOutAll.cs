using System.Collections.Generic;
using Il2CppDummyDll;

namespace YgomGame.Scenario;

[Token(Token = "0x2000AA2")]
public class ScenarioBehaviour_CardFadeOutAll : ScenarioBehaviour, IScenarioCardActorBehaviour
{
	[Token(Token = "0x400931F")]
	[FieldOffset(Offset = "0x50")]
	private List<int> m_CardSlots;

	[Token(Token = "0x4009320")]
	[FieldOffset(Offset = "0x58")]
	private ScenarioCardActor[] m_CardActors;

	[Token(Token = "0x4009321")]
	[FieldOffset(Offset = "0x60")]
	private bool m_PlayTrigger;

	[Token(Token = "0x6004141")]
	[Address(RVA = "0x880620", Offset = "0x87F820", VA = "0x180880620")]
	public ScenarioBehaviour_CardFadeOutAll(object commandData)
	{
	}

	[Token(Token = "0x6004142")]
	[Address(RVA = "0x8801D0", Offset = "0x87F3D0", VA = "0x1808801D0", Slot = "23")]
	public IReadOnlyList<int> GetBehaveCardSlots()
	{
		return null;
	}

	[Token(Token = "0x6004143")]
	[Address(RVA = "0x44E380", Offset = "0x44D580", VA = "0x18044E380", Slot = "24")]
	public ScenarioCardContainer.Operations GetBehaveCardOperations()
	{
		return default(ScenarioCardContainer.Operations);
	}

	[Token(Token = "0x6004144")]
	[Address(RVA = "0x880440", Offset = "0x87F640", VA = "0x180880440", Slot = "12")]
	protected override void ProgressInit()
	{
	}

	[Token(Token = "0x6004145")]
	[Address(RVA = "0x880370", Offset = "0x87F570", VA = "0x180880370", Slot = "13")]
	protected override void ProgressAction()
	{
	}

	[Token(Token = "0x6004146")]
	[Address(RVA = "0x3C7A70", Offset = "0x3C6C70", VA = "0x1803C7A70", Slot = "19")]
	public override bool IsOverrideBehaviour(ScenarioBehaviour target)
	{
		return default(bool);
	}
}
