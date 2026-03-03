using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine.Playables;

namespace YgomGame.Scenario;

[Serializable]
[Token(Token = "0x2000AD9")]
public class ScenarioSoundMixerBehaviour : PlayableBehaviour
{
	[Token(Token = "0x2000ADA")]
	public enum ClipState
	{
		[Token(Token = "0x400942C")]
		Wait,
		[Token(Token = "0x400942D")]
		InProgress_EaseIn,
		[Token(Token = "0x400942E")]
		InProgress_Play,
		[Token(Token = "0x400942F")]
		End
	}

	[Token(Token = "0x4009429")]
	[FieldOffset(Offset = "0x10")]
	private Dictionary<string, ScenarioSoundClipBehaviour> m_ClipMap;

	[Token(Token = "0x400942A")]
	[FieldOffset(Offset = "0x18")]
	private bool m_ClipMapDirty;

	[Token(Token = "0x170008F5")]
	public bool ready
	{
		[Token(Token = "0x60042DE")]
		[Address(RVA = "0x8A1EE0", Offset = "0x8A10E0", VA = "0x1808A1EE0")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x60042DF")]
	[Address(RVA = "0x8A1980", Offset = "0x8A0B80", VA = "0x1808A1980")]
	public bool ContainClip(string clipName)
	{
		return default(bool);
	}

	[Token(Token = "0x60042E0")]
	[Address(RVA = "0x8A19F0", Offset = "0x8A0BF0", VA = "0x1808A19F0")]
	public ClipState GetClipState(string clipName, double time)
	{
		return default(ClipState);
	}

	[Token(Token = "0x60042E1")]
	[Address(RVA = "0x8A1930", Offset = "0x8A0B30", VA = "0x1808A1930", Slot = "13")]
	public override void OnGraphStart(Playable playable)
	{
	}

	[Token(Token = "0x60042E2")]
	[Address(RVA = "0x8A1E10", Offset = "0x8A1010", VA = "0x1808A1E10", Slot = "21")]
	public override void ProcessFrame(Playable playable, FrameData info, object playerData)
	{
	}

	[Token(Token = "0x60042E3")]
	[Address(RVA = "0x8A1930", Offset = "0x8A0B30", VA = "0x1808A1930")]
	private void ClearClipMap()
	{
	}

	[Token(Token = "0x60042E4")]
	[Address(RVA = "0x8A1B10", Offset = "0x8A0D10", VA = "0x1808A1B10")]
	private void PrepareClipMap(Playable playable)
	{
	}

	[Token(Token = "0x60042E5")]
	[Address(RVA = "0x8A1ED0", Offset = "0x8A10D0", VA = "0x1808A1ED0")]
	public ScenarioSoundMixerBehaviour()
	{
	}
}
