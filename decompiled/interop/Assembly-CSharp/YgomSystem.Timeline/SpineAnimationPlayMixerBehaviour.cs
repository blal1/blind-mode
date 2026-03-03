using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Spine;
using Spine.Unity;
using UnityEngine.Playables;

namespace YgomSystem.Timeline;

[Token(Token = "0x2000213")]
public class SpineAnimationPlayMixerBehaviour : PlayableBehaviour
{
	[Token(Token = "0x4000AC6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public int trackIndex;

	[Token(Token = "0x4000AC7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public bool setEmptyOnEndWithClip;

	[Token(Token = "0x4000AC8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private AnimationReferenceAsset m_ReserveEmptyAnimation;

	[Token(Token = "0x6000C67")]
	[Address(RVA = "0xD3A490", Offset = "0xD39690", VA = "0x180D3A490", Slot = "21")]
	public override void ProcessFrame(Playable playable, FrameData info, object playerData)
	{
	}

	[Token(Token = "0x6000C68")]
	[Address(RVA = "0xD3A490", Offset = "0xD39690", VA = "0x180D3A490")]
	public void CheckSetEmptyAnimation(Playable playable, FrameData info, object playerData)
	{
	}

	[Token(Token = "0x6000C69")]
	[Address(RVA = "0xD3A530", Offset = "0xD39730", VA = "0x180D3A530")]
	public void HandleClipEndEmptyAnimation(Playable playable, FrameData info, object playerData, AnimationReferenceAsset animationReference)
	{
	}

	[Token(Token = "0x6000C6A")]
	[Address(RVA = "0xD3A590", Offset = "0xD39790", VA = "0x180D3A590")]
	private bool TrySetEmptyAnimation(object playerData, [Optional] Animation verifyAnim)
	{
		return default(bool);
	}

	[Token(Token = "0x6000C6B")]
	[Address(RVA = "0x3DC070", Offset = "0x3DB270", VA = "0x1803DC070")]
	public SpineAnimationPlayMixerBehaviour()
	{
	}
}
