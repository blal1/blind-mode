using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Playables;

namespace YgomSystem.Timeline;

[Serializable]
[Token(Token = "0x20001F7")]
public class LabelClip : PlayableAsset
{
	[Token(Token = "0x4000A83")]
	[FieldOffset(Offset = "0x18")]
	public LabelBehaviour template;

	[Token(Token = "0x6000BDA")]
	[Address(RVA = "0xC0ADB0", Offset = "0xC09FB0", VA = "0x180C0ADB0", Slot = "6")]
	public override Playable CreatePlayable(PlayableGraph graph, GameObject go)
	{
		return default(Playable);
	}

	[Token(Token = "0x6000BDB")]
	[Address(RVA = "0xC0AE80", Offset = "0xC0A080", VA = "0x180C0AE80")]
	public LabelClip()
	{
	}
}
