using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Playables;

namespace YgomSystem.Timeline;

[Serializable]
[Token(Token = "0x2000202")]
public class PauseClip : PlayableAsset
{
	[Token(Token = "0x4000AA2")]
	[FieldOffset(Offset = "0x18")]
	public PauseBehaviour template;

	[NonSerialized]
	[Token(Token = "0x4000AA3")]
	[FieldOffset(Offset = "0x20")]
	public double startTime;

	[NonSerialized]
	[Token(Token = "0x4000AA4")]
	[FieldOffset(Offset = "0x28")]
	public double endTime;

	[Token(Token = "0x6000C2F")]
	[Address(RVA = "0xC0FF80", Offset = "0xC0F180", VA = "0x180C0FF80", Slot = "6")]
	public override Playable CreatePlayable(PlayableGraph graph, GameObject go)
	{
		return default(Playable);
	}

	[Token(Token = "0x6000C30")]
	[Address(RVA = "0xC10080", Offset = "0xC0F280", VA = "0x180C10080")]
	public PauseClip()
	{
	}
}
