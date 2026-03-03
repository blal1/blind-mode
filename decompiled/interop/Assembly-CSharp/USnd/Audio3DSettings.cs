using System;
using Il2CppDummyDll;
using UnityEngine;

namespace USnd;

[Token(Token = "0x20000E5")]
[CreateAssetMenu(menuName = "USnd/ Create Audio3DSettings Instance")]
public class Audio3DSettings : ScriptableObject, ICloneable
{
	[Token(Token = "0x400053F")]
	[FieldOffset(Offset = "0x18")]
	public string spatialName;

	[Token(Token = "0x4000540")]
	[FieldOffset(Offset = "0x20")]
	[Range(0f, 1f)]
	public float spatialBlend;

	[Token(Token = "0x4000541")]
	[FieldOffset(Offset = "0x24")]
	[Range(0f, 1.1f)]
	public float reverbZoneMix;

	[Token(Token = "0x4000542")]
	[FieldOffset(Offset = "0x28")]
	[Range(0f, 5f)]
	public float dopplerLevel;

	[Token(Token = "0x4000543")]
	[FieldOffset(Offset = "0x2C")]
	[Range(0f, 360f)]
	public int spread;

	[Token(Token = "0x4000544")]
	[FieldOffset(Offset = "0x30")]
	public AudioRolloffMode rolloffMode;

	[Token(Token = "0x4000545")]
	[FieldOffset(Offset = "0x34")]
	public float minDistance;

	[Token(Token = "0x4000546")]
	[FieldOffset(Offset = "0x38")]
	public float maxDistance;

	[Token(Token = "0x4000547")]
	[FieldOffset(Offset = "0x40")]
	public AnimationCurve customRolloffCurve;

	[Token(Token = "0x4000548")]
	[FieldOffset(Offset = "0x48")]
	public AnimationCurve spatialBlendCurve;

	[Token(Token = "0x4000549")]
	[FieldOffset(Offset = "0x50")]
	public AnimationCurve reverbZoneMixCurve;

	[Token(Token = "0x400054A")]
	[FieldOffset(Offset = "0x58")]
	public AnimationCurve spreadCurve;

	[Token(Token = "0x6000442")]
	[Address(RVA = "0x77FB50", Offset = "0x77ED50", VA = "0x18077FB50", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Token(Token = "0x6000443")]
	[Address(RVA = "0x77FD80", Offset = "0x77EF80", VA = "0x18077FD80")]
	public void Copy(Audio3DSettings newParam)
	{
	}

	[Token(Token = "0x6000444")]
	[Address(RVA = "0x77FF90", Offset = "0x77F190", VA = "0x18077FF90")]
	public Audio3DSettings()
	{
	}
}
