using Il2CppDummyDll;
using UnityEngine;

namespace YgomGame.Scenario;

[Token(Token = "0x2000A9D")]
public class ScenarioBehavior_BgZoom : ScenarioBehaviour
{
	[Token(Token = "0x4009309")]
	[FieldOffset(Offset = "0x50")]
	private ScenarioBGActor m_BGActor;

	[Token(Token = "0x400930A")]
	[FieldOffset(Offset = "0x58")]
	private object m_RenderTarget;

	[Token(Token = "0x400930B")]
	[FieldOffset(Offset = "0x60")]
	private float m_TotalFadeSec;

	[Token(Token = "0x400930C")]
	[FieldOffset(Offset = "0x64")]
	private float m_FadeSec;

	[Token(Token = "0x400930D")]
	[FieldOffset(Offset = "0x68")]
	private bool m_FadeoutKeep;

	[Token(Token = "0x400930E")]
	[FieldOffset(Offset = "0x6C")]
	private float m_CurveDiff;

	[Token(Token = "0x400930F")]
	[FieldOffset(Offset = "0x70")]
	private AnimationCurve m_AnimationCurve;

	[Token(Token = "0x4009310")]
	[FieldOffset(Offset = "0x78")]
	private float m_SrcScale;

	[Token(Token = "0x4009311")]
	[FieldOffset(Offset = "0x7C")]
	private float m_DstScale;

	[Token(Token = "0x600412C")]
	[Address(RVA = "0x87E460", Offset = "0x87D660", VA = "0x18087E460")]
	public ScenarioBehavior_BgZoom(object commandData)
	{
	}

	[Token(Token = "0x600412D")]
	[Address(RVA = "0x87E130", Offset = "0x87D330", VA = "0x18087E130", Slot = "12")]
	protected override void ProgressInit()
	{
	}

	[Token(Token = "0x600412E")]
	[Address(RVA = "0x87DF50", Offset = "0x87D150", VA = "0x18087DF50", Slot = "13")]
	protected override void ProgressAction()
	{
	}
}
