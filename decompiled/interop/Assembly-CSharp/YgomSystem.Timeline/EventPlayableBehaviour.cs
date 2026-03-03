using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine.Playables;

namespace YgomSystem.Timeline;

[Token(Token = "0x20001F3")]
public class EventPlayableBehaviour : PlayableBehaviour
{
	[Token(Token = "0x20001F4")]
	public class EventInfo
	{
		[Token(Token = "0x4000A80")]
		[FieldOffset(Offset = "0x10")]
		public string label;

		[Token(Token = "0x4000A81")]
		[FieldOffset(Offset = "0x18")]
		public double time;

		[Token(Token = "0x4000A82")]
		[FieldOffset(Offset = "0x20")]
		public bool isDone;

		[Token(Token = "0x6000BD7")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public EventInfo()
		{
		}
	}

	[Token(Token = "0x4000A7D")]
	[FieldOffset(Offset = "0x10")]
	public List<EventInfo> eventList;

	[Token(Token = "0x4000A7E")]
	[FieldOffset(Offset = "0x18")]
	public double startTime;

	[Token(Token = "0x4000A7F")]
	[FieldOffset(Offset = "0x20")]
	private bool processed;

	[Token(Token = "0x6000BD2")]
	[Address(RVA = "0xC086D0", Offset = "0xC078D0", VA = "0x180C086D0", Slot = "17")]
	public override void OnBehaviourPlay(Playable playable, FrameData info)
	{
	}

	[Token(Token = "0x6000BD3")]
	[Address(RVA = "0xC08760", Offset = "0xC07960", VA = "0x180C08760", Slot = "21")]
	public override void ProcessFrame(Playable playable, FrameData info, object playerData)
	{
	}

	[Token(Token = "0x6000BD4")]
	[Address(RVA = "0xC08650", Offset = "0xC07850", VA = "0x180C08650", Slot = "18")]
	public override void OnBehaviourPause(Playable playable, FrameData info)
	{
	}

	[Token(Token = "0x6000BD5")]
	[Address(RVA = "0xC08520", Offset = "0xC07720", VA = "0x180C08520")]
	private void CheckEventInfos(Playable playable)
	{
	}

	[Token(Token = "0x6000BD6")]
	[Address(RVA = "0xC087F0", Offset = "0xC079F0", VA = "0x180C087F0")]
	public EventPlayableBehaviour()
	{
	}
}
