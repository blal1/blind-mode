using Il2CppDummyDll;
using UnityEngine;
using YgomSystem.ElementSystem;
using YgomSystem.UI;
using YgomSystem.UI.ElementWidget;

namespace YgomGame.Scenario;

[Token(Token = "0x2000A67")]
public class ScenarioContainerBase : ElementWidgetBase
{
	[Token(Token = "0x40091E9")]
	[FieldOffset(Offset = "0x20")]
	private ScenarioShaker m_Shaker;

	[Token(Token = "0x17000890")]
	protected virtual GameObject shakeTarget
	{
		[Token(Token = "0x6004015")]
		[Address(RVA = "0x6A94A0", Offset = "0x6A86A0", VA = "0x1806A94A0", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6004016")]
	[Address(RVA = "0x8847B0", Offset = "0x8839B0", VA = "0x1808847B0")]
	public ScenarioContainerBase(ElementObjectManager eom)
	{
	}

	[Token(Token = "0x6004017")]
	[Address(RVA = "0x8845B0", Offset = "0x8837B0", VA = "0x1808845B0")]
	public void PlayShake(float amount, float cycle, bool isShakeX, bool isShakeY, float autoStopSec = 0f)
	{
	}

	[Token(Token = "0x6004018")]
	[Address(RVA = "0x884730", Offset = "0x883930", VA = "0x180884730")]
	public void StopShake()
	{
	}

	[Token(Token = "0x6004019")]
	[Address(RVA = "0x884530", Offset = "0x883730", VA = "0x180884530")]
	public bool IsPlayingShake()
	{
		return default(bool);
	}
}
