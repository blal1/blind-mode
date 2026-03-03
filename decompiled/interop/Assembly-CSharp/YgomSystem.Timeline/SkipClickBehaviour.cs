using System;
using Il2CppDummyDll;
using UnityEngine.Playables;
using YgomSystem.UI;

namespace YgomSystem.Timeline;

[Serializable]
[Token(Token = "0x2000207")]
public class SkipClickBehaviour : PlayableBehaviour
{
	[Token(Token = "0x4000AA9")]
	[FieldOffset(Offset = "0x10")]
	private PlayableDirector m_Director;

	[NonSerialized]
	[Token(Token = "0x4000AAA")]
	[FieldOffset(Offset = "0x18")]
	public double endTime;

	[NonSerialized]
	[Token(Token = "0x4000AAB")]
	[FieldOffset(Offset = "0x20")]
	public SelectionButton waitButton;

	[Token(Token = "0x6000C42")]
	[Address(RVA = "0xC14BF0", Offset = "0xC13DF0", VA = "0x180C14BF0", Slot = "15")]
	public override void OnPlayableCreate(Playable playable)
	{
	}

	[Token(Token = "0x6000C43")]
	[Address(RVA = "0xC14980", Offset = "0xC13B80", VA = "0x180C14980", Slot = "17")]
	public override void OnBehaviourPlay(Playable playable, FrameData info)
	{
	}

	[Token(Token = "0x6000C44")]
	[Address(RVA = "0xC148E0", Offset = "0xC13AE0", VA = "0x180C148E0", Slot = "18")]
	public override void OnBehaviourPause(Playable playable, FrameData info)
	{
	}

	[Token(Token = "0x6000C45")]
	[Address(RVA = "0xC14D00", Offset = "0xC13F00", VA = "0x180C14D00", Slot = "16")]
	public override void OnPlayableDestroy(Playable playable)
	{
	}

	[Token(Token = "0x6000C46")]
	[Address(RVA = "0xC14B00", Offset = "0xC13D00", VA = "0x180C14B00")]
	public void OnClicked()
	{
	}

	[Token(Token = "0x6000C47")]
	[Address(RVA = "0x3DC070", Offset = "0x3DB270", VA = "0x1803DC070")]
	public SkipClickBehaviour()
	{
	}
}
