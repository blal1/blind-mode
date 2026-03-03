using Il2CppDummyDll;
using UnityEngine;

namespace YgomGame.Scenario;

[Token(Token = "0x2000AB2")]
public class ScenarioBehavior_Flash : ScenarioBehaviour, IScenarioScreenActorBehaviour, IScenarioBehaviour
{
	[Token(Token = "0x400935C")]
	[FieldOffset(Offset = "0x50")]
	private readonly string k_TweenFlash;

	[Token(Token = "0x400935D")]
	[FieldOffset(Offset = "0x58")]
	private GameObject m_TargetGo;

	[Token(Token = "0x400935E")]
	[FieldOffset(Offset = "0x60")]
	private int m_TotalCnt;

	[Token(Token = "0x400935F")]
	[FieldOffset(Offset = "0x64")]
	private int m_Cnt;

	[Token(Token = "0x170008B3")]
	public bool isOverrideBehaveScreen
	{
		[Token(Token = "0x60041B2")]
		[Address(RVA = "0x404830", Offset = "0x403A30", VA = "0x180404830", Slot = "23")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x60041B3")]
	[Address(RVA = "0x896EA0", Offset = "0x8960A0", VA = "0x180896EA0")]
	public ScenarioBehavior_Flash(object commandData)
	{
	}

	[Token(Token = "0x60041B4")]
	[Address(RVA = "0x4465B0", Offset = "0x4457B0", VA = "0x1804465B0", Slot = "24")]
	public ScenarioScreenContainer.Targets GetBehaveScreenTargets()
	{
		return default(ScenarioScreenContainer.Targets);
	}

	[Token(Token = "0x60041B5")]
	[Address(RVA = "0x4B8E10", Offset = "0x4B8010", VA = "0x1804B8E10", Slot = "25")]
	public ScenarioScreenContainer.Operations GetBehaveScreenOperations()
	{
		return default(ScenarioScreenContainer.Operations);
	}

	[Token(Token = "0x60041B6")]
	[Address(RVA = "0x896B80", Offset = "0x895D80", VA = "0x180896B80", Slot = "12")]
	protected override void ProgressInit()
	{
	}

	[Token(Token = "0x60041B7")]
	[Address(RVA = "0x8969D0", Offset = "0x895BD0", VA = "0x1808969D0", Slot = "13")]
	protected override void ProgressAction()
	{
	}

	[Token(Token = "0x60041B8")]
	[Address(RVA = "0x896AB0", Offset = "0x895CB0", VA = "0x180896AB0", Slot = "16")]
	protected override void ProgressFinish()
	{
	}

	[Token(Token = "0x60041B9")]
	[Address(RVA = "0x3C7A70", Offset = "0x3C6C70", VA = "0x1803C7A70", Slot = "19")]
	public override bool IsOverrideBehaviour(ScenarioBehaviour target)
	{
		return default(bool);
	}
}
