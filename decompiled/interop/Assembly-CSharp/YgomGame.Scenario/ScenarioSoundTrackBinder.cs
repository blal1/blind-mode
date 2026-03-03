using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Playables;

namespace YgomGame.Scenario;

[Token(Token = "0x2000ADC")]
public class ScenarioSoundTrackBinder : MonoBehaviour
{
	[Token(Token = "0x4009430")]
	[FieldOffset(Offset = "0x20")]
	private PlayableDirector m_Director;

	[Token(Token = "0x4009431")]
	[FieldOffset(Offset = "0x28")]
	private ScenarioSoundMixerBehaviour m_CurrentMixer;

	[Token(Token = "0x170008F6")]
	public bool ready
	{
		[Token(Token = "0x60042EA")]
		[Address(RVA = "0x8A21B0", Offset = "0x8A13B0", VA = "0x1808A21B0")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1400005A")]
	public event Action onProcessTrackEvent
	{
		[Token(Token = "0x60042EB")]
		[Address(RVA = "0x8A2110", Offset = "0x8A1310", VA = "0x1808A2110")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x60042EC")]
		[Address(RVA = "0x8A21D0", Offset = "0x8A13D0", VA = "0x1808A21D0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x60042ED")]
	[Address(RVA = "0x8A1EF0", Offset = "0x8A10F0", VA = "0x1808A1EF0")]
	public bool ContainClip(string clipName)
	{
		return default(bool);
	}

	[Token(Token = "0x60042EE")]
	[Address(RVA = "0x8A20B0", Offset = "0x8A12B0", VA = "0x1808A20B0")]
	public bool IsClipState(string clipName, ScenarioSoundMixerBehaviour.ClipState clipState)
	{
		return default(bool);
	}

	[Token(Token = "0x60042EF")]
	[Address(RVA = "0x8A1F60", Offset = "0x8A1160", VA = "0x1808A1F60")]
	public ScenarioSoundMixerBehaviour.ClipState GetClipState(string clipName)
	{
		return default(ScenarioSoundMixerBehaviour.ClipState);
	}

	[Token(Token = "0x60042F0")]
	[Address(RVA = "0x3D8380", Offset = "0x3D7580", VA = "0x1803D8380")]
	public void Setup(PlayableDirector director)
	{
	}

	[Token(Token = "0x60042F1")]
	[Address(RVA = "0x8A20D0", Offset = "0x8A12D0", VA = "0x1808A20D0")]
	public void OnProcessMixer(ScenarioSoundMixerBehaviour mixer)
	{
	}

	[Token(Token = "0x60042F2")]
	[Address(RVA = "0x3D2BD0", Offset = "0x3D1DD0", VA = "0x1803D2BD0")]
	public ScenarioSoundTrackBinder()
	{
	}
}
