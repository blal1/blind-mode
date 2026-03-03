using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Rendering.Universal;

namespace YgomSystem.URP;

[Token(Token = "0x2000302")]
public class VolumeAnimatorColorAdjustments : VolumeAnimatorComponentBase<ColorAdjustments>
{
	[Token(Token = "0x4001056")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private bool postExposure_Ov;

	[Token(Token = "0x4001057")]
	[FieldOffset(Offset = "0x34")]
	[SerializeField]
	private float postExposure_Val;

	[Token(Token = "0x4001058")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private bool contrast_Ov;

	[Token(Token = "0x4001059")]
	[FieldOffset(Offset = "0x3C")]
	[SerializeField]
	[Range(0f, 1f)]
	private float contrast_Val;

	[Token(Token = "0x400105A")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	private bool colorFilter_Ov;

	[Token(Token = "0x400105B")]
	[FieldOffset(Offset = "0x44")]
	[SerializeField]
	private Color colorFilter_Val;

	[Token(Token = "0x400105C")]
	[FieldOffset(Offset = "0x54")]
	[SerializeField]
	private bool hueShift_Ov;

	[Token(Token = "0x400105D")]
	[FieldOffset(Offset = "0x58")]
	[SerializeField]
	[Range(0f, 1f)]
	private float hueShift_Val;

	[Token(Token = "0x400105E")]
	[FieldOffset(Offset = "0x5C")]
	[SerializeField]
	private bool saturation_Ov;

	[Token(Token = "0x400105F")]
	[FieldOffset(Offset = "0x60")]
	[SerializeField]
	[Range(0f, 1f)]
	private float saturation_Val;

	[Token(Token = "0x60012F1")]
	[Address(RVA = "0x41A8A0", Offset = "0x419AA0", VA = "0x18041A8A0", Slot = "10")]
	protected override void ExecuteImport(ColorAdjustments component)
	{
	}

	[Token(Token = "0x60012F2")]
	[Address(RVA = "0x41A700", Offset = "0x419900", VA = "0x18041A700", Slot = "11")]
	protected override void ExecuteExport(ColorAdjustments component)
	{
	}

	[Token(Token = "0x60012F3")]
	[Address(RVA = "0x41AA30", Offset = "0x419C30", VA = "0x18041AA30")]
	public VolumeAnimatorColorAdjustments()
	{
	}
}
