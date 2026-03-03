using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Playables;
using YgomSystem.Timeline;

namespace YgomGame.Scenario;

[Serializable]
[Token(Token = "0x2000AD6")]
public class ScenarioLabelClip : LabelClipEX
{
	[Token(Token = "0x4009425")]
	[FieldOffset(Offset = "0x28")]
	[Header("ボイス字幕区間")]
	public bool voiceSUB;

	[Token(Token = "0x60042D7")]
	[Address(RVA = "0x8A0D40", Offset = "0x89FF40", VA = "0x1808A0D40", Slot = "6")]
	public override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
	{
		return default(Playable);
	}

	[Token(Token = "0x60042D8")]
	[Address(RVA = "0x8A0E10", Offset = "0x8A0010", VA = "0x1808A0E10")]
	public ScenarioLabelClip()
	{
	}
}
