using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace YgomGame.Scenario;

[Token(Token = "0x2000A84")]
public class ScenarioRootScreen : MonoBehaviour
{
	[Token(Token = "0x2000A85")]
	public enum State
	{
		[Token(Token = "0x40092A0")]
		None,
		[Token(Token = "0x40092A1")]
		FadeIn,
		[Token(Token = "0x40092A2")]
		FadeOut
	}

	[Token(Token = "0x4009299")]
	[FieldOffset(Offset = "0x20")]
	private Image m_Target;

	[Token(Token = "0x400929A")]
	[FieldOffset(Offset = "0x28")]
	private float m_FadeDuration;

	[Token(Token = "0x400929B")]
	[FieldOffset(Offset = "0x2C")]
	private float m_CurrentSec;

	[Token(Token = "0x400929C")]
	[FieldOffset(Offset = "0x30")]
	private float m_FromAlpha;

	[Token(Token = "0x400929D")]
	[FieldOffset(Offset = "0x34")]
	private float m_ToAlpha;

	[Token(Token = "0x400929E")]
	[FieldOffset(Offset = "0x38")]
	private State m_State;

	[Token(Token = "0x170008A2")]
	public bool isPlaying
	{
		[Token(Token = "0x60040CC")]
		[Address(RVA = "0x88F450", Offset = "0x88E650", VA = "0x18088F450")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170008A3")]
	public State state
	{
		[Token(Token = "0x60040CD")]
		[Address(RVA = "0x40C450", Offset = "0x40B650", VA = "0x18040C450")]
		get
		{
			return default(State);
		}
	}

	[Token(Token = "0x60040CE")]
	[Address(RVA = "0x88EFA0", Offset = "0x88E1A0", VA = "0x18088EFA0")]
	public static ScenarioRootScreen Create(Image target)
	{
		return null;
	}

	[Token(Token = "0x60040CF")]
	[Address(RVA = "0x88F030", Offset = "0x88E230", VA = "0x18088F030")]
	public void PlayFadeIn(float duration)
	{
	}

	[Token(Token = "0x60040D0")]
	[Address(RVA = "0x88F060", Offset = "0x88E260", VA = "0x18088F060")]
	public void PlayFadeOut(float duration)
	{
	}

	[Token(Token = "0x60040D1")]
	[Address(RVA = "0x88F090", Offset = "0x88E290", VA = "0x18088F090")]
	private void Setup(float toAlpha, float duration)
	{
	}

	[Token(Token = "0x60040D2")]
	[Address(RVA = "0x88F210", Offset = "0x88E410", VA = "0x18088F210")]
	private void Update()
	{
	}

	[Token(Token = "0x60040D3")]
	[Address(RVA = "0x88F440", Offset = "0x88E640", VA = "0x18088F440")]
	public ScenarioRootScreen()
	{
	}
}
