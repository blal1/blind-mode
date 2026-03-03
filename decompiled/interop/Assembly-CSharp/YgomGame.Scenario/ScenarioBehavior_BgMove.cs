using Il2CppDummyDll;
using UnityEngine;

namespace YgomGame.Scenario;

[Token(Token = "0x2000A98")]
public class ScenarioBehavior_BgMove : ScenarioBehaviour
{
	[Token(Token = "0x40092F0")]
	[FieldOffset(Offset = "0x50")]
	private object m_RenderTarget;

	[Token(Token = "0x40092F1")]
	[FieldOffset(Offset = "0x58")]
	private ScenarioBGActor m_BGActor;

	[Token(Token = "0x40092F2")]
	[FieldOffset(Offset = "0x60")]
	private int m_Direction;

	[Token(Token = "0x40092F3")]
	[FieldOffset(Offset = "0x64")]
	private float m_TotalFadeSec;

	[Token(Token = "0x40092F4")]
	[FieldOffset(Offset = "0x68")]
	private float m_FadeSec;

	[Token(Token = "0x40092F5")]
	[FieldOffset(Offset = "0x6C")]
	private float m_CurveDiff;

	[Token(Token = "0x40092F6")]
	[FieldOffset(Offset = "0x70")]
	private bool m_FadeoutKeep;

	[Token(Token = "0x40092F7")]
	[FieldOffset(Offset = "0x78")]
	private AnimationCurve m_AnimationCurve;

	[Token(Token = "0x40092F8")]
	[FieldOffset(Offset = "0x80")]
	private Vector3 m_SrcPos;

	[Token(Token = "0x40092F9")]
	[FieldOffset(Offset = "0x8C")]
	private Vector3 m_DstPos;

	[Token(Token = "0x600411D")]
	[Address(RVA = "0x87DEA0", Offset = "0x87D0A0", VA = "0x18087DEA0")]
	public ScenarioBehavior_BgMove(object commandData)
	{
	}

	[Token(Token = "0x600411E")]
	[Address(RVA = "0x87DB20", Offset = "0x87CD20", VA = "0x18087DB20", Slot = "12")]
	protected override void ProgressInit()
	{
	}

	[Token(Token = "0x600411F")]
	[Address(RVA = "0x87D890", Offset = "0x87CA90", VA = "0x18087D890", Slot = "13")]
	protected override void ProgressAction()
	{
	}
}
