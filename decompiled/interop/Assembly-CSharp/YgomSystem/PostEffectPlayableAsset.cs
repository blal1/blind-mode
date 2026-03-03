using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Rendering;

namespace YgomSystem;

[Serializable]
[Token(Token = "0x200019D")]
public class PostEffectPlayableAsset : PlayableAsset
{
	[Token(Token = "0x40009B7")]
	[FieldOffset(Offset = "0x18")]
	public ExposedReference<Volume> Volume;

	[Token(Token = "0x40009B8")]
	[FieldOffset(Offset = "0x28")]
	public ExposedReference<VolumeProfile> VolumeProfile;

	[Token(Token = "0x6000A58")]
	[Address(RVA = "0xC115D0", Offset = "0xC107D0", VA = "0x180C115D0", Slot = "6")]
	public override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
	{
		return default(Playable);
	}

	[Token(Token = "0x6000A59")]
	[Address(RVA = "0x567800", Offset = "0x566A00", VA = "0x180567800")]
	public PostEffectPlayableAsset()
	{
	}
}
