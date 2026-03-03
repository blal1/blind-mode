using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Playables;

namespace YgomSystem.Timeline;

[Serializable]
[Token(Token = "0x200020B")]
public class SkipClip : PlayableAsset
{
	[Token(Token = "0x4000AAF")]
	[FieldOffset(Offset = "0x18")]
	public SkipBehaviour template;

	[NonSerialized]
	[Token(Token = "0x4000AB0")]
	[FieldOffset(Offset = "0x20")]
	public double endTime;

	[Token(Token = "0x6000C4E")]
	[Address(RVA = "0xC15440", Offset = "0xC14640", VA = "0x180C15440", Slot = "6")]
	public override Playable CreatePlayable(PlayableGraph graph, GameObject go)
	{
		return default(Playable);
	}

	[Token(Token = "0x6000C4F")]
	[Address(RVA = "0xC15530", Offset = "0xC14730", VA = "0x180C15530")]
	public SkipClip()
	{
	}
}
