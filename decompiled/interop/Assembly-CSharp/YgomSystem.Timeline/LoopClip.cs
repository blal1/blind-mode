using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Playables;

namespace YgomSystem.Timeline;

[Serializable]
[Token(Token = "0x20001FE")]
public class LoopClip : PlayableAsset
{
	[Token(Token = "0x4000A97")]
	[FieldOffset(Offset = "0x18")]
	public LoopBehaviour template;

	[Token(Token = "0x6000C17")]
	[Address(RVA = "0xC0D630", Offset = "0xC0C830", VA = "0x180C0D630", Slot = "6")]
	public override Playable CreatePlayable(PlayableGraph graph, GameObject go)
	{
		return default(Playable);
	}

	[Token(Token = "0x6000C18")]
	[Address(RVA = "0xC0D700", Offset = "0xC0C900", VA = "0x180C0D700")]
	public LoopClip()
	{
	}
}
