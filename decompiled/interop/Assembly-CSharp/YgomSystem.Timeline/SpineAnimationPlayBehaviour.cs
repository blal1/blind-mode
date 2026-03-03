using Il2CppDummyDll;
using Spine.Unity;
using UnityEngine.Playables;

namespace YgomSystem.Timeline;

[Token(Token = "0x2000212")]
public class SpineAnimationPlayBehaviour : PlayableBehaviour
{
	[Token(Token = "0x4000AC0")]
	[FieldOffset(Offset = "0x10")]
	public int trackIndex;

	[Token(Token = "0x4000AC1")]
	[FieldOffset(Offset = "0x14")]
	public bool setEmptyOnEndWithClip;

	[Token(Token = "0x4000AC2")]
	[FieldOffset(Offset = "0x18")]
	public AnimationReferenceAsset animationReference;

	[Token(Token = "0x4000AC3")]
	[FieldOffset(Offset = "0x20")]
	public bool loop;

	[Token(Token = "0x4000AC4")]
	[FieldOffset(Offset = "0x21")]
	public bool dontEndWithClip;

	[Token(Token = "0x4000AC5")]
	[FieldOffset(Offset = "0x28")]
	private object m_LastPlayerData;

	[Token(Token = "0x6000C62")]
	[Address(RVA = "0xD3A260", Offset = "0xD39460", VA = "0x180D3A260")]
	private SpineAnimationPlayMixerBehaviour TryGetMixerBehaviour(Playable playable)
	{
		return null;
	}

	[Token(Token = "0x6000C63")]
	[Address(RVA = "0xD39F70", Offset = "0xD39170", VA = "0x180D39F70", Slot = "21")]
	public override void ProcessFrame(Playable playable, FrameData info, object playerData)
	{
	}

	[Token(Token = "0x6000C64")]
	[Address(RVA = "0xD39E70", Offset = "0xD39070", VA = "0x180D39E70", Slot = "18")]
	public override void OnBehaviourPause(Playable playable, FrameData info)
	{
	}

	[Token(Token = "0x6000C65")]
	[Address(RVA = "0xD39DA0", Offset = "0xD38FA0", VA = "0x180D39DA0")]
	private void HandleClipEnd(Playable playable, FrameData info, object playerData)
	{
	}

	[Token(Token = "0x6000C66")]
	[Address(RVA = "0x3DC070", Offset = "0x3DB270", VA = "0x1803DC070")]
	public SpineAnimationPlayBehaviour()
	{
	}
}
