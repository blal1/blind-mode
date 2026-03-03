using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace YgomGame.Scenario;

[Token(Token = "0x2000AA3")]
public class ScenarioBehaviour_CardSwap : ScenarioBehaviour, IScenarioCardActorBehaviour, IScenarioLoadGroupHandleBehaviour
{
	[Token(Token = "0x4009322")]
	[FieldOffset(Offset = "0x50")]
	private ScenarioCardActor m_CardActor;

	[Token(Token = "0x4009323")]
	[FieldOffset(Offset = "0x58")]
	private int m_OldMrk;

	[Token(Token = "0x4009324")]
	[FieldOffset(Offset = "0x5C")]
	private int m_NewMrk;

	[Token(Token = "0x4009325")]
	[FieldOffset(Offset = "0x60")]
	private int[] m_ReserveSlots;

	[Token(Token = "0x4009326")]
	[FieldOffset(Offset = "0x68")]
	private bool m_PlayTrigger;

	[Token(Token = "0x4009327")]
	[FieldOffset(Offset = "0x69")]
	private bool m_PreLoadComplete;

	[Token(Token = "0x6004147")]
	[Address(RVA = "0x880F80", Offset = "0x880180", VA = "0x180880F80")]
	public ScenarioBehaviour_CardSwap(object commandData)
	{
	}

	[Token(Token = "0x6004148")]
	[Address(RVA = "0x880C70", Offset = "0x87FE70", VA = "0x180880C70", Slot = "23")]
	public IReadOnlyList<int> GetBehaveCardSlots()
	{
		return null;
	}

	[Token(Token = "0x6004149")]
	[Address(RVA = "0x44E380", Offset = "0x44D580", VA = "0x18044E380", Slot = "24")]
	public ScenarioCardContainer.Operations GetBehaveCardOperations()
	{
		return default(ScenarioCardContainer.Operations);
	}

	[Token(Token = "0x600414A")]
	[Address(RVA = "0x880D80", Offset = "0x87FF80", VA = "0x180880D80", Slot = "12")]
	protected override void ProgressInit()
	{
	}

	[Token(Token = "0x600414B")]
	[Address(RVA = "0x880D20", Offset = "0x87FF20", VA = "0x180880D20", Slot = "13")]
	protected override void ProgressAction()
	{
	}

	[Token(Token = "0x600414C")]
	[Address(RVA = "0x3C7A70", Offset = "0x3C6C70", VA = "0x1803C7A70", Slot = "19")]
	public override bool IsOverrideBehaviour(ScenarioBehaviour target)
	{
		return default(bool);
	}

	[Token(Token = "0x600414D")]
	[Address(RVA = "0x880A80", Offset = "0x87FC80", VA = "0x180880A80", Slot = "25")]
	public void CollectLoadPath(List<(string path, Type type)> res)
	{
	}

	[Token(Token = "0x600414E")]
	[Address(RVA = "0x8809E0", Offset = "0x87FBE0", VA = "0x1808809E0", Slot = "26")]
	public void CollectLoadMrk(List<int> res)
	{
	}
}
