using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Playables;
using YgomSystem.UI;

namespace YgomSystem.Timeline;

[Serializable]
[Token(Token = "0x2000208")]
public class SkipClickClip : PlayableAsset
{
	[Token(Token = "0x4000AAC")]
	[FieldOffset(Offset = "0x18")]
	public SkipClickBehaviour template;

	[NonSerialized]
	[Token(Token = "0x4000AAD")]
	[FieldOffset(Offset = "0x20")]
	public double endTime;

	[NonSerialized]
	[Token(Token = "0x4000AAE")]
	[FieldOffset(Offset = "0x28")]
	public SelectionButton waitButton;

	[Token(Token = "0x6000C48")]
	[Address(RVA = "0xC14DA0", Offset = "0xC13FA0", VA = "0x180C14DA0", Slot = "6")]
	public override Playable CreatePlayable(PlayableGraph graph, GameObject go)
	{
		return default(Playable);
	}

	[Token(Token = "0x6000C49")]
	[Address(RVA = "0xC14EB0", Offset = "0xC140B0", VA = "0x180C14EB0")]
	public SkipClickClip()
	{
	}
}
