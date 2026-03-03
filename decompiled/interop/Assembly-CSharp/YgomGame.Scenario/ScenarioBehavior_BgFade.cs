using Il2CppDummyDll;
using UnityEngine;

namespace YgomGame.Scenario;

[Token(Token = "0x2000A97")]
public class ScenarioBehavior_BgFade : ScenarioBehaviour
{
	[Token(Token = "0x40092E7")]
	[FieldOffset(Offset = "0x50")]
	private object m_RenderTarget;

	[Token(Token = "0x40092E8")]
	[FieldOffset(Offset = "0x58")]
	private ScenarioBGActor m_BGActor;

	[Token(Token = "0x40092E9")]
	[FieldOffset(Offset = "0x60")]
	private float m_TotalFadeSec;

	[Token(Token = "0x40092EA")]
	[FieldOffset(Offset = "0x64")]
	private float m_fadeSec;

	[Token(Token = "0x40092EB")]
	[FieldOffset(Offset = "0x68")]
	private Vector3 m_SrcPos;

	[Token(Token = "0x40092EC")]
	[FieldOffset(Offset = "0x74")]
	private Vector3 m_DstPos;

	[Token(Token = "0x40092ED")]
	[FieldOffset(Offset = "0x80")]
	private Color m_FromColor;

	[Token(Token = "0x40092EE")]
	[FieldOffset(Offset = "0x90")]
	private Color m_ToColor;

	[Token(Token = "0x40092EF")]
	[FieldOffset(Offset = "0xA0")]
	private bool m_FadeoutKeep;

	[Token(Token = "0x600411A")]
	[Address(RVA = "0x87D7F0", Offset = "0x87C9F0", VA = "0x18087D7F0")]
	public ScenarioBehavior_BgFade(object commandData)
	{
	}

	[Token(Token = "0x600411B")]
	[Address(RVA = "0x87D560", Offset = "0x87C760", VA = "0x18087D560", Slot = "12")]
	protected override void ProgressInit()
	{
	}

	[Token(Token = "0x600411C")]
	[Address(RVA = "0x87D2E0", Offset = "0x87C4E0", VA = "0x18087D2E0", Slot = "13")]
	protected override void ProgressAction()
	{
	}
}
