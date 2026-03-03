using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace YgomGame.Scenario;

[Token(Token = "0x2000A9F")]
public class ScenarioBehaviour_CardFadeIn : ScenarioBehaviour, IScenarioCardActorBehaviour, IScenarioLoadGroupHandleBehaviour
{
	[Token(Token = "0x2000AA0")]
	private class PlayData
	{
		[Token(Token = "0x4009319")]
		[FieldOffset(Offset = "0x10")]
		public readonly ScenarioCardActor cardActor;

		[Token(Token = "0x400931A")]
		[FieldOffset(Offset = "0x18")]
		public readonly string seLabel;

		[Token(Token = "0x600413A")]
		[Address(RVA = "0x5FF240", Offset = "0x5FE440", VA = "0x1805FF240")]
		public PlayData(ScenarioCardActor cardActor, string seLabel)
		{
		}
	}

	[Token(Token = "0x4009314")]
	[FieldOffset(Offset = "0x50")]
	private List<ScenarioCardActor> m_CardActorLoads;

	[Token(Token = "0x4009315")]
	[FieldOffset(Offset = "0x58")]
	private Queue<PlayData> m_CardActorQueue;

	[Token(Token = "0x4009316")]
	[FieldOffset(Offset = "0x60")]
	private PlayData m_PlayingData;

	[Token(Token = "0x4009317")]
	[FieldOffset(Offset = "0x68")]
	private List<int> m_ReserveSlots;

	[Token(Token = "0x4009318")]
	[FieldOffset(Offset = "0x70")]
	private List<int> m_Mrks;

	[Token(Token = "0x6004132")]
	[Address(RVA = "0x87FF00", Offset = "0x87F100", VA = "0x18087FF00")]
	public ScenarioBehaviour_CardFadeIn(object commandData)
	{
	}

	[Token(Token = "0x6004133")]
	[Address(RVA = "0x49B9F0", Offset = "0x49ABF0", VA = "0x18049B9F0", Slot = "23")]
	public IReadOnlyList<int> GetBehaveCardSlots()
	{
		return null;
	}

	[Token(Token = "0x6004134")]
	[Address(RVA = "0x4465B0", Offset = "0x4457B0", VA = "0x1804465B0", Slot = "24")]
	public ScenarioCardContainer.Operations GetBehaveCardOperations()
	{
		return default(ScenarioCardContainer.Operations);
	}

	[Token(Token = "0x6004135")]
	[Address(RVA = "0x87F9F0", Offset = "0x87EBF0", VA = "0x18087F9F0", Slot = "12")]
	protected override void ProgressInit()
	{
	}

	[Token(Token = "0x6004136")]
	[Address(RVA = "0x87F8C0", Offset = "0x87EAC0", VA = "0x18087F8C0", Slot = "13")]
	protected override void ProgressAction()
	{
	}

	[Token(Token = "0x6004137")]
	[Address(RVA = "0x3C7A70", Offset = "0x3C6C70", VA = "0x1803C7A70", Slot = "19")]
	public override bool IsOverrideBehaviour(ScenarioBehaviour target)
	{
		return default(bool);
	}

	[Token(Token = "0x6004138")]
	[Address(RVA = "0x87F5C0", Offset = "0x87E7C0", VA = "0x18087F5C0", Slot = "25")]
	public void CollectLoadPath(List<(string path, Type type)> res)
	{
	}

	[Token(Token = "0x6004139")]
	[Address(RVA = "0x87F560", Offset = "0x87E760", VA = "0x18087F560", Slot = "26")]
	public void CollectLoadMrk(List<int> res)
	{
	}
}
