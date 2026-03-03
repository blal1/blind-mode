using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Playables;

namespace YgomSystem.Timeline;

[Token(Token = "0x2000210")]
public class SoundStopPlayableAsset : PlayableAsset
{
	[Token(Token = "0x4000ABD")]
	[FieldOffset(Offset = "0x18")]
	public string stopLabel;

	[Token(Token = "0x4000ABE")]
	[FieldOffset(Offset = "0x20")]
	public float fade;

	[Token(Token = "0x4000ABF")]
	[FieldOffset(Offset = "0x24")]
	public bool mute;

	[Token(Token = "0x17000158")]
	public override double duration
	{
		[Token(Token = "0x6000C5D")]
		[Address(RVA = "0xC15B70", Offset = "0xC14D70", VA = "0x180C15B70", Slot = "7")]
		get
		{
			return default(double);
		}
	}

	[Token(Token = "0x6000C5C")]
	[Address(RVA = "0xD39770", Offset = "0xD38970", VA = "0x180D39770", Slot = "6")]
	public override Playable CreatePlayable(PlayableGraph graph, GameObject go)
	{
		return default(Playable);
	}

	[Token(Token = "0x6000C5E")]
	[Address(RVA = "0x567800", Offset = "0x566A00", VA = "0x180567800")]
	public SoundStopPlayableAsset()
	{
	}
}
