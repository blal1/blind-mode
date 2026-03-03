using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Playables;

namespace YgomSystem.Timeline;

[Token(Token = "0x200020D")]
public class SoundPlayableAsset : PlayableAsset
{
	[Token(Token = "0x4000AB1")]
	[FieldOffset(Offset = "0x18")]
	public string startLabel;

	[Token(Token = "0x4000AB2")]
	[FieldOffset(Offset = "0x20")]
	public bool mute;

	[Token(Token = "0x4000AB3")]
	[FieldOffset(Offset = "0x21")]
	public bool skipDuplicate;

	[Token(Token = "0x4000AB4")]
	[FieldOffset(Offset = "0x28")]
	public LabeledPlayableController LabeledPlayableController;

	[Token(Token = "0x17000157")]
	public override double duration
	{
		[Token(Token = "0x6000C54")]
		[Address(RVA = "0xC15B70", Offset = "0xC14D70", VA = "0x180C15B70", Slot = "7")]
		get
		{
			return default(double);
		}
	}

	[Token(Token = "0x6000C53")]
	[Address(RVA = "0xC159F0", Offset = "0xC14BF0", VA = "0x180C159F0", Slot = "6")]
	public override Playable CreatePlayable(PlayableGraph graph, GameObject go)
	{
		return default(Playable);
	}

	[Token(Token = "0x6000C55")]
	[Address(RVA = "0x567800", Offset = "0x566A00", VA = "0x180567800")]
	public SoundPlayableAsset()
	{
	}
}
