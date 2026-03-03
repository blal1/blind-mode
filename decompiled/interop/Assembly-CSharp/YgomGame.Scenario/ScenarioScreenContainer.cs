using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine.UI;
using YgomSystem.ElementSystem;

namespace YgomGame.Scenario;

[Token(Token = "0x2000A87")]
public class ScenarioScreenContainer : ScenarioContainerBase
{
	[Token(Token = "0x2000A88")]
	public enum Targets
	{
		[Token(Token = "0x40092A8")]
		None,
		[Token(Token = "0x40092A9")]
		TextUnder,
		[Token(Token = "0x40092AA")]
		TextOver
	}

	[Token(Token = "0x2000A89")]
	public enum Operations
	{
		[Token(Token = "0x40092AC")]
		None,
		[Token(Token = "0x40092AD")]
		Color
	}

	[Token(Token = "0x40092A3")]
	[FieldOffset(Offset = "0x28")]
	private readonly List<IScenarioScreenActorBehaviour> m_RegistedBehaviours;

	[Token(Token = "0x40092A4")]
	[FieldOffset(Offset = "0x30")]
	private readonly List<IScenarioScreenActorBehaviour> m_ReserveRemoveBehaviours;

	[Token(Token = "0x40092A5")]
	[FieldOffset(Offset = "0x38")]
	private readonly Image m_ScreenTextUnder;

	[Token(Token = "0x40092A6")]
	[FieldOffset(Offset = "0x40")]
	private readonly Image m_ScreenTextOver;

	[Token(Token = "0x60040D7")]
	[Address(RVA = "0x88FBB0", Offset = "0x88EDB0", VA = "0x18088FBB0")]
	public ScenarioScreenContainer(ElementObjectManager eom, Image screenTextUnder, Image screenTextOver)
	{
	}

	[Token(Token = "0x60040D8")]
	[Address(RVA = "0x88F950", Offset = "0x88EB50", VA = "0x18088F950")]
	public Image GetScreen(Targets target)
	{
		return null;
	}

	[Token(Token = "0x60040D9")]
	[Address(RVA = "0x88F970", Offset = "0x88EB70", VA = "0x18088F970")]
	public bool IsReadyControllBehaviour(IScenarioScreenActorBehaviour controllBehaviour)
	{
		return default(bool);
	}

	[Token(Token = "0x60040DA")]
	[Address(RVA = "0x88F460", Offset = "0x88E660", VA = "0x18088F460")]
	public bool AssignBehaviour(IScenarioScreenActorBehaviour controllBehaviour)
	{
		return default(bool);
	}

	[Token(Token = "0x60040DB")]
	[Address(RVA = "0x88FB50", Offset = "0x88ED50", VA = "0x18088FB50")]
	public bool RemoveBehaviour(IScenarioScreenActorBehaviour controllBehaviour)
	{
		return default(bool);
	}
}
