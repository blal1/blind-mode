using Il2CppDummyDll;
using UnityEngine.Playables;
using UnityEngine.Rendering;

namespace YgomSystem;

[Token(Token = "0x200019E")]
public class PostEffectPlayableBehaviour : PlayableBehaviour
{
	[Token(Token = "0x40009B9")]
	[FieldOffset(Offset = "0x10")]
	public Volume volume;

	[Token(Token = "0x40009BA")]
	[FieldOffset(Offset = "0x18")]
	public VolumeProfile volumeProfile;

	[Token(Token = "0x40009BB")]
	[FieldOffset(Offset = "0x20")]
	public PlayableDirector playableDirector;

	[Token(Token = "0x6000A5A")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "13")]
	public override void OnGraphStart(Playable playable)
	{
	}

	[Token(Token = "0x6000A5B")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "14")]
	public override void OnGraphStop(Playable playable)
	{
	}

	[Token(Token = "0x6000A5C")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "17")]
	public override void OnBehaviourPlay(Playable playable, FrameData info)
	{
	}

	[Token(Token = "0x6000A5D")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "18")]
	public override void OnBehaviourPause(Playable playable, FrameData info)
	{
	}

	[Token(Token = "0x6000A5E")]
	[Address(RVA = "0xC117A0", Offset = "0xC109A0", VA = "0x180C117A0", Slot = "20")]
	public override void PrepareFrame(Playable playable, FrameData info)
	{
	}

	[Token(Token = "0x6000A5F")]
	[Address(RVA = "0x3DC070", Offset = "0x3DB270", VA = "0x1803DC070")]
	public PostEffectPlayableBehaviour()
	{
	}
}
