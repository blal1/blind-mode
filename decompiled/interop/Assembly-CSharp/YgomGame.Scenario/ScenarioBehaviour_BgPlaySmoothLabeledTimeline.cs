using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;

namespace YgomGame.Scenario;

[Token(Token = "0x2000A9B")]
public class ScenarioBehaviour_BgPlaySmoothLabeledTimeline : ScenarioBehaviour
{
	[Token(Token = "0x40092FD")]
	[FieldOffset(Offset = "0x50")]
	private ScenarioBGActor m_BGActor;

	[Token(Token = "0x40092FE")]
	[FieldOffset(Offset = "0x58")]
	private PlayableDirector m_BGDirector;

	[Token(Token = "0x40092FF")]
	[FieldOffset(Offset = "0x60")]
	private TimelineClip m_DestClip;

	[Token(Token = "0x4009300")]
	[FieldOffset(Offset = "0x68")]
	private string m_DestLabel;

	[Token(Token = "0x4009301")]
	[FieldOffset(Offset = "0x70")]
	private AnimationCurve m_SmoothCurve;

	[Token(Token = "0x4009302")]
	[FieldOffset(Offset = "0x78")]
	private double m_BeginTime;

	[Token(Token = "0x4009303")]
	[FieldOffset(Offset = "0x80")]
	private double m_SmoothDuration;

	[Token(Token = "0x4009304")]
	[FieldOffset(Offset = "0x88")]
	private double m_PastSec;

	[Token(Token = "0x4009305")]
	[FieldOffset(Offset = "0x90")]
	private float m_MaxSpeed;

	[Token(Token = "0x6004125")]
	[Address(RVA = "0x87F300", Offset = "0x87E500", VA = "0x18087F300")]
	public ScenarioBehaviour_BgPlaySmoothLabeledTimeline(object commandData)
	{
	}

	[Token(Token = "0x6004126")]
	[Address(RVA = "0x87F040", Offset = "0x87E240", VA = "0x18087F040", Slot = "12")]
	protected override void ProgressInit()
	{
	}

	[Token(Token = "0x6004127")]
	[Address(RVA = "0x87EEE0", Offset = "0x87E0E0", VA = "0x18087EEE0", Slot = "13")]
	protected override void ProgressAction()
	{
	}
}
