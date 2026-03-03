using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Playables;

namespace YgomGame.Scenario;

[Serializable]
[Token(Token = "0x2000AD7")]
public class ScenarioSoundClip : PlayableAsset
{
	[Token(Token = "0x4009426")]
	[FieldOffset(Offset = "0x18")]
	public ScenarioSoundClipBehaviour template;

	[Token(Token = "0x60042D9")]
	[Address(RVA = "0x8A17F0", Offset = "0x8A09F0", VA = "0x1808A17F0", Slot = "6")]
	public override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
	{
		return default(Playable);
	}

	[Token(Token = "0x60042DA")]
	[Address(RVA = "0x8A18C0", Offset = "0x8A0AC0", VA = "0x1808A18C0")]
	public ScenarioSoundClip()
	{
	}
}
