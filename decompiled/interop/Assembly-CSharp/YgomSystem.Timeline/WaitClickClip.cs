using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Playables;
using YgomSystem.UI;

namespace YgomSystem.Timeline;

[Serializable]
[Token(Token = "0x2000216")]
public class WaitClickClip : PlayableAsset
{
	[Token(Token = "0x4000AD3")]
	[FieldOffset(Offset = "0x18")]
	public WaitClickBehaviour template;

	[NonSerialized]
	[Token(Token = "0x4000AD4")]
	[FieldOffset(Offset = "0x20")]
	public double startTime;

	[NonSerialized]
	[Token(Token = "0x4000AD5")]
	[FieldOffset(Offset = "0x28")]
	public double endTime;

	[NonSerialized]
	[Token(Token = "0x4000AD6")]
	[FieldOffset(Offset = "0x30")]
	public SelectionButton waitButton;

	[Token(Token = "0x6000C78")]
	[Address(RVA = "0xD43420", Offset = "0xD42620", VA = "0x180D43420", Slot = "6")]
	public override Playable CreatePlayable(PlayableGraph graph, GameObject go)
	{
		return default(Playable);
	}

	[Token(Token = "0x6000C79")]
	[Address(RVA = "0xD43540", Offset = "0xD42740", VA = "0x180D43540")]
	public WaitClickClip()
	{
	}
}
