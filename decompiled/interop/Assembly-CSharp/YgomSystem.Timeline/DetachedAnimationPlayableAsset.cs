using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Playables;

namespace YgomSystem.Timeline;

[Token(Token = "0x20001ED")]
public class DetachedAnimationPlayableAsset : PlayableAsset
{
	[Token(Token = "0x4000A70")]
	[FieldOffset(Offset = "0x18")]
	public DetachedAnimationPlayableBehaviour template;

	[Token(Token = "0x6000BC4")]
	[Address(RVA = "0xC07880", Offset = "0xC06A80", VA = "0x180C07880", Slot = "6")]
	public override Playable CreatePlayable(PlayableGraph graph, GameObject go)
	{
		return default(Playable);
	}

	[Token(Token = "0x6000BC5")]
	[Address(RVA = "0xC07950", Offset = "0xC06B50", VA = "0x180C07950")]
	public DetachedAnimationPlayableAsset()
	{
	}
}
