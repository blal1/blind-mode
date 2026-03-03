using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using YgomSystem.ElementSystem;

namespace YgomGame.Scenario;

[Token(Token = "0x2000A62")]
public class ScenarioCardContainer : ScenarioContainerBase
{
	[Token(Token = "0x2000A63")]
	public enum Operations
	{
		[Token(Token = "0x40091E0")]
		InitMrk = 1,
		[Token(Token = "0x40091E1")]
		PlayAnimation
	}

	[Token(Token = "0x2000A64")]
	public class InitializeData
	{
		[Token(Token = "0x40091E2")]
		[FieldOffset(Offset = "0x10")]
		public ElementObjectManager cardModelPref;

		[Token(Token = "0x40091E3")]
		[FieldOffset(Offset = "0x18")]
		public ElementObjectManager cardPopPref;

		[Token(Token = "0x40091E4")]
		[FieldOffset(Offset = "0x20")]
		public ScenarioCardActor.TimelineAssets timelineAssets;

		[Token(Token = "0x600400E")]
		[Address(RVA = "0x87C3D0", Offset = "0x87B5D0", VA = "0x18087C3D0")]
		public InitializeData()
		{
		}
	}

	[Token(Token = "0x40091D5")]
	[FieldOffset(Offset = "0x28")]
	public readonly int k_LocatorLen;

	[Token(Token = "0x40091D6")]
	[FieldOffset(Offset = "0x30")]
	private readonly string k_ELabelLocatorFormat;

	[Token(Token = "0x40091D7")]
	[FieldOffset(Offset = "0x38")]
	private readonly string k_ELabelCardLocator;

	[Token(Token = "0x40091D8")]
	[FieldOffset(Offset = "0x40")]
	private readonly string k_ELabelPopLocator;

	[Token(Token = "0x40091D9")]
	[FieldOffset(Offset = "0x48")]
	private readonly ElementObjectManager[] m_Locators;

	[Token(Token = "0x40091DA")]
	[FieldOffset(Offset = "0x50")]
	private ElementObjectManager m_CardModelPref;

	[Token(Token = "0x40091DB")]
	[FieldOffset(Offset = "0x58")]
	private ElementObjectManager m_CardPopPref;

	[Token(Token = "0x40091DC")]
	[FieldOffset(Offset = "0x60")]
	private ScenarioCardActor.TimelineAssets m_TimelineAssets;

	[Token(Token = "0x40091DD")]
	[FieldOffset(Offset = "0x68")]
	private Dictionary<int, ScenarioCardActor> m_CardActorMap;

	[Token(Token = "0x40091DE")]
	[FieldOffset(Offset = "0x70")]
	public Action<ScenarioCardActor> onCreateCallback;

	[Token(Token = "0x1700088E")]
	public int[] allExistsIdxs
	{
		[Token(Token = "0x6004005")]
		[Address(RVA = "0x884180", Offset = "0x883380", VA = "0x180884180")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700088F")]
	public ScenarioCardActor this[int index]
	{
		[Token(Token = "0x6004006")]
		[Address(RVA = "0x8840F0", Offset = "0x8832F0", VA = "0x1808840F0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6004007")]
	[Address(RVA = "0x883740", Offset = "0x882940", VA = "0x180883740")]
	public bool Contains(int index)
	{
		return default(bool);
	}

	[Token(Token = "0x6004008")]
	[Address(RVA = "0x883E90", Offset = "0x883090", VA = "0x180883E90")]
	public ScenarioCardContainer(ElementObjectManager eom)
	{
	}

	[Token(Token = "0x6004009")]
	[Address(RVA = "0x883BD0", Offset = "0x882DD0", VA = "0x180883BD0")]
	public void Initialize(InitializeData initializeData)
	{
	}

	[Token(Token = "0x600400A")]
	[Address(RVA = "0x8837D0", Offset = "0x8829D0", VA = "0x1808837D0")]
	public ScenarioCardActor CreateActor(int index)
	{
		return null;
	}

	[Token(Token = "0x600400B")]
	[Address(RVA = "0x883D90", Offset = "0x882F90", VA = "0x180883D90")]
	public ScenarioCardActor SearchByMrk(int mrk)
	{
		return null;
	}

	[Token(Token = "0x600400C")]
	[Address(RVA = "0x883AE0", Offset = "0x882CE0", VA = "0x180883AE0")]
	public int GetSlotByMrk(int mrk)
	{
		return default(int);
	}

	[Token(Token = "0x600400D")]
	[Address(RVA = "0x883C30", Offset = "0x882E30", VA = "0x180883C30")]
	public bool IsReadyControllBehaviour(IScenarioCardActorBehaviour controllBehaviour)
	{
		return default(bool);
	}
}
