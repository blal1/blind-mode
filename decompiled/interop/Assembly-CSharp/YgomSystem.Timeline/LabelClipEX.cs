using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Playables;

namespace YgomSystem.Timeline;

[Serializable]
[Token(Token = "0x20001F8")]
public class LabelClipEX : LabelClip
{
	[Token(Token = "0x4000A84")]
	[FieldOffset(Offset = "0x20")]
	public bool overrideWrapMode;

	[Token(Token = "0x4000A85")]
	[FieldOffset(Offset = "0x24")]
	public LabelDirectorWrapMode wrapmode;

	[Token(Token = "0x6000BDC")]
	[Address(RVA = "0xC0AC70", Offset = "0xC09E70", VA = "0x180C0AC70", Slot = "6")]
	public override Playable CreatePlayable(PlayableGraph graph, GameObject go)
	{
		return default(Playable);
	}

	[Token(Token = "0x6000BDD")]
	[Address(RVA = "0xC0AD40", Offset = "0xC09F40", VA = "0x180C0AD40")]
	public LabelClipEX()
	{
	}
}
