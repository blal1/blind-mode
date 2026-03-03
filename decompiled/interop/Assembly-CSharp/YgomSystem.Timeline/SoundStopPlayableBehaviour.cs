using Il2CppDummyDll;
using UnityEngine.Playables;

namespace YgomSystem.Timeline;

[Token(Token = "0x200020F")]
public class SoundStopPlayableBehaviour : PlayableBehaviour
{
	[Token(Token = "0x4000AB8")]
	[FieldOffset(Offset = "0x10")]
	public SoundStopPlayableAsset playableAsset;

	[Token(Token = "0x4000AB9")]
	[FieldOffset(Offset = "0x18")]
	public string stopLabel;

	[Token(Token = "0x4000ABA")]
	[FieldOffset(Offset = "0x20")]
	public bool skipDuplicate;

	[Token(Token = "0x4000ABB")]
	[FieldOffset(Offset = "0x24")]
	public float fade;

	[Token(Token = "0x4000ABC")]
	[FieldOffset(Offset = "0x28")]
	private bool stopped;

	[Token(Token = "0x6000C59")]
	[Address(RVA = "0xC0FE60", Offset = "0xC0F060", VA = "0x180C0FE60", Slot = "13")]
	public override void OnGraphStart(Playable playable)
	{
	}

	[Token(Token = "0x6000C5A")]
	[Address(RVA = "0xC15D60", Offset = "0xC14F60", VA = "0x180C15D60", Slot = "17")]
	public override void OnBehaviourPlay(Playable playable, FrameData info)
	{
	}

	[Token(Token = "0x6000C5B")]
	[Address(RVA = "0x3DC070", Offset = "0x3DB270", VA = "0x1803DC070")]
	public SoundStopPlayableBehaviour()
	{
	}
}
