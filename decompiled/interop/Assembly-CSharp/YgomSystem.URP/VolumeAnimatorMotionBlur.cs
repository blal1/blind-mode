using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Rendering.Universal;

namespace YgomSystem.URP;

[Token(Token = "0x200030A")]
public class VolumeAnimatorMotionBlur : VolumeAnimatorComponentBase<MotionBlur>
{
	[Token(Token = "0x40010A8")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private bool mode_Ov;

	[Token(Token = "0x40010A9")]
	[FieldOffset(Offset = "0x34")]
	[SerializeField]
	private MotionBlurMode mode_Val;

	[Token(Token = "0x40010AA")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private bool quality_Ov;

	[Token(Token = "0x40010AB")]
	[FieldOffset(Offset = "0x3C")]
	[SerializeField]
	private MotionBlurQuality quality_Val;

	[Token(Token = "0x40010AC")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	private bool intensity_Ov;

	[Token(Token = "0x40010AD")]
	[FieldOffset(Offset = "0x44")]
	[SerializeField]
	[Range(0f, 1f)]
	private float intensity_Val;

	[Token(Token = "0x40010AE")]
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	private bool clamp_Ov;

	[Token(Token = "0x40010AF")]
	[FieldOffset(Offset = "0x4C")]
	[SerializeField]
	[Range(0f, 1f)]
	private float clamp_Val;

	[Token(Token = "0x6001309")]
	[Address(RVA = "0x41C5A0", Offset = "0x41B7A0", VA = "0x18041C5A0", Slot = "10")]
	protected override void ExecuteImport(MotionBlur component)
	{
	}

	[Token(Token = "0x600130A")]
	[Address(RVA = "0x41C460", Offset = "0x41B660", VA = "0x18041C460", Slot = "11")]
	protected override void ExecuteExport(MotionBlur component)
	{
	}

	[Token(Token = "0x600130B")]
	[Address(RVA = "0x41C6E0", Offset = "0x41B8E0", VA = "0x18041C6E0")]
	public VolumeAnimatorMotionBlur()
	{
	}
}
