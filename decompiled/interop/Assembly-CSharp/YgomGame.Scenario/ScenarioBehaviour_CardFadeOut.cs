using System.Collections.Generic;
using Il2CppDummyDll;

namespace YgomGame.Scenario;

[Token(Token = "0x2000AA1")]
public class ScenarioBehaviour_CardFadeOut : ScenarioBehaviour, IScenarioCardActorBehaviour
{
	[Token(Token = "0x400931B")]
	[FieldOffset(Offset = "0x50")]
	private ScenarioCardActor m_CardActor;

	[Token(Token = "0x400931C")]
	[FieldOffset(Offset = "0x58")]
	private bool m_PlayTrigger;

	[Token(Token = "0x400931D")]
	[FieldOffset(Offset = "0x5C")]
	private int m_Mrk;

	[Token(Token = "0x400931E")]
	[FieldOffset(Offset = "0x60")]
	private int[] m_ReserveSlots;

	[Token(Token = "0x600413B")]
	[Address(RVA = "0x880950", Offset = "0x87FB50", VA = "0x180880950")]
	public ScenarioBehaviour_CardFadeOut(object commandData)
	{
	}

	[Token(Token = "0x600413C")]
	[Address(RVA = "0x8806B0", Offset = "0x87F8B0", VA = "0x1808806B0", Slot = "23")]
	public IReadOnlyList<int> GetBehaveCardSlots()
	{
		return null;
	}

	[Token(Token = "0x600413D")]
	[Address(RVA = "0x44E380", Offset = "0x44D580", VA = "0x18044E380", Slot = "24")]
	public ScenarioCardContainer.Operations GetBehaveCardOperations()
	{
		return default(ScenarioCardContainer.Operations);
	}

	[Token(Token = "0x600413E")]
	[Address(RVA = "0x8807C0", Offset = "0x87F9C0", VA = "0x1808807C0", Slot = "12")]
	protected override void ProgressInit()
	{
	}

	[Token(Token = "0x600413F")]
	[Address(RVA = "0x880760", Offset = "0x87F960", VA = "0x180880760", Slot = "13")]
	protected override void ProgressAction()
	{
	}

	[Token(Token = "0x6004140")]
	[Address(RVA = "0x3C7A70", Offset = "0x3C6C70", VA = "0x1803C7A70", Slot = "19")]
	public override bool IsOverrideBehaviour(ScenarioBehaviour target)
	{
		return default(bool);
	}
}
