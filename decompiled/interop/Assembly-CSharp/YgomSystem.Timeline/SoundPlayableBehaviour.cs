using Il2CppDummyDll;
using UnityEngine.Playables;

namespace YgomSystem.Timeline;

[Token(Token = "0x200020E")]
public class SoundPlayableBehaviour : PlayableBehaviour
{
	[Token(Token = "0x4000AB5")]
	[FieldOffset(Offset = "0x10")]
	public SoundPlayableAsset playableAsset;

	[Token(Token = "0x4000AB6")]
	[FieldOffset(Offset = "0x18")]
	public string startLabel;

	[Token(Token = "0x4000AB7")]
	[FieldOffset(Offset = "0x20")]
	public bool skipDuplicate;

	[Token(Token = "0x6000C56")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "13")]
	public override void OnGraphStart(Playable playable)
	{
	}

	[Token(Token = "0x6000C57")]
	[Address(RVA = "0xC15B80", Offset = "0xC14D80", VA = "0x180C15B80", Slot = "17")]
	public override void OnBehaviourPlay(Playable playable, FrameData info)
	{
	}

	[Token(Token = "0x6000C58")]
	[Address(RVA = "0x3DC070", Offset = "0x3DB270", VA = "0x1803DC070")]
	public SoundPlayableBehaviour()
	{
	}
}
