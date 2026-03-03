using System;
using Il2CppDummyDll;
using UnityEngine.Playables;
using YgomSystem.UI;

namespace YgomSystem.Timeline;

[Serializable]
[Token(Token = "0x2000215")]
public class WaitClickBehaviour : PlayableBehaviour
{
	[Token(Token = "0x4000ACB")]
	[FieldOffset(Offset = "0x10")]
	private PlayableDirector m_Director;

	[Token(Token = "0x4000ACC")]
	[FieldOffset(Offset = "0x18")]
	private bool m_WaitTrigger;

	[Token(Token = "0x4000ACD")]
	[FieldOffset(Offset = "0x19")]
	private bool m_Waited;

	[Token(Token = "0x4000ACE")]
	[FieldOffset(Offset = "0x1A")]
	private bool m_IsLooping;

	[Token(Token = "0x4000ACF")]
	[FieldOffset(Offset = "0x1B")]
	public bool isLoop;

	[NonSerialized]
	[Token(Token = "0x4000AD0")]
	[FieldOffset(Offset = "0x20")]
	public double startTime;

	[NonSerialized]
	[Token(Token = "0x4000AD1")]
	[FieldOffset(Offset = "0x28")]
	public double endTime;

	[NonSerialized]
	[Token(Token = "0x4000AD2")]
	[FieldOffset(Offset = "0x30")]
	public SelectionButton waitButton;

	[Token(Token = "0x6000C6F")]
	[Address(RVA = "0xD43270", Offset = "0xD42470", VA = "0x180D43270", Slot = "15")]
	public override void OnPlayableCreate(Playable playable)
	{
	}

	[Token(Token = "0x6000C70")]
	[Address(RVA = "0xD43260", Offset = "0xD42460", VA = "0x180D43260", Slot = "13")]
	public override void OnGraphStart(Playable playable)
	{
	}

	[Token(Token = "0x6000C71")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "14")]
	public override void OnGraphStop(Playable playable)
	{
	}

	[Token(Token = "0x6000C72")]
	[Address(RVA = "0x455950", Offset = "0x454B50", VA = "0x180455950", Slot = "17")]
	public override void OnBehaviourPlay(Playable playable, FrameData info)
	{
	}

	[Token(Token = "0x6000C73")]
	[Address(RVA = "0xD42EC0", Offset = "0xD420C0", VA = "0x180D42EC0", Slot = "18")]
	public override void OnBehaviourPause(Playable playable, FrameData info)
	{
	}

	[Token(Token = "0x6000C74")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "20")]
	public override void PrepareFrame(Playable playable, FrameData info)
	{
	}

	[Token(Token = "0x6000C75")]
	[Address(RVA = "0xD43380", Offset = "0xD42580", VA = "0x180D43380", Slot = "16")]
	public override void OnPlayableDestroy(Playable playable)
	{
	}

	[Token(Token = "0x6000C76")]
	[Address(RVA = "0xD43150", Offset = "0xD42350", VA = "0x180D43150")]
	public void OnClicked()
	{
	}

	[Token(Token = "0x6000C77")]
	[Address(RVA = "0x3DC070", Offset = "0x3DB270", VA = "0x1803DC070")]
	public WaitClickBehaviour()
	{
	}
}
